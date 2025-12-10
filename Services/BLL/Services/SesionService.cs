using Services.Domain.Security;
using Services.Domain.Logging;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Services.BLL.Extensions;
using Services.DAL.Implementations;
using System.Net.Mail;
using System.Net;
using Services.Domain.Exceptions;

namespace Services.BLL.Services
{
    public static class SesionService
    {
        public static void Login(string nombreUsuario, string password)
        {
            try
            {
                if (string.IsNullOrEmpty(nombreUsuario))
                {
                    throw new Exception("Ingrese un nombre de usuario para iniciar sesión.");
                }
                if (string.IsNullOrEmpty(password))
                {
                    throw new Exception("Ingrese una contraseña para iniciar sesión.");
                }
                Usuario usuarioRegistrado = UsuarioService.Current.GetByCredentials(nombreUsuario, password);
                if(usuarioRegistrado == null)
                {
                    throw new CredencialesIncorrectasException(nombreUsuario);
                }
                if (!usuarioRegistrado.EstaHabilitado)
                {
                    throw new Exception("El usuario no está habilitado. Contacte al administrador");
                }
                UsuarioLogueado.IniciarSesion(usuarioRegistrado);
                LoggerService.GetLogger().WriteLog(new LogEntry(DateTime.Now, LogLevel.Information, "Ocurrió un inicio de sesión."));
            }
            catch(CredencialesIncorrectasException credEx)
            {
                UsuarioLogueado.SumarIntento(nombreUsuario);
                if (UsuarioLogueado.cantidadIntentos[nombreUsuario] >= 3)
                {
                    Usuario usuarioADeshabilitar = UsuarioService.Current.GetByNombreUsuario(nombreUsuario);
                    if (usuarioADeshabilitar.EstaHabilitado)
                    {
                        UsuarioService.Current.CambiarEstado(usuarioADeshabilitar);
                    }
                    throw new Exception(credEx.Message + "\nSe alcanzó el máximo de intentos y el usuario fue bloqueado. Contacte al administrador.");
                }
                else
                {
                    throw new Exception(credEx.Message + $"\nIntentos restantes: {UsuarioLogueado.cantidadIntentos[nombreUsuario]}");
                }
            }
            catch(Exception ex)
            {
                ex.Handle();
            }
        }

        public static void RecuperarContraseña(Usuario usuarioARecuperar)
        {
            try
            {
                if (usuarioARecuperar == null)
                {
                    throw new Exception("No se encontró un usuario con ese nombre. Intente nuevamente");
                }
                if (!usuarioARecuperar.EstaHabilitado)
                {
                    throw new Exception("El usuario no se encuentra habilitado. Contacte al administrador");
                }
                List<PasswordToken> tokens = PasswordTokenRepository.Current.GetByIdUsuario(usuarioARecuperar.IdUsuario);
                if (tokens.Where(t => t.FechaVencimiento > DateTime.Now).ToList().Count > 0)
                {
                    throw new Exception("Ya hay un token activo. Revise su correo electrónico");
                }
                PasswordToken nuevoToken = new PasswordToken(Guid.NewGuid(), UsuarioService.Current.GenerarPassword(), usuarioARecuperar, DateTime.Now.AddMinutes(15));
                PasswordTokenRepository.Current.Insert(nuevoToken);
                string asunto = "Recuperación de contraseña - FrostManager";
                string cuerpo = $"Hola {usuarioARecuperar.Nombre},\n\n" +
                                "Hemos recibido una solicitud para restablecer tu contraseña.\n" +
                                $"Tu código de recuperación es: {nuevoToken.Token}\n" +
                                $"Este código expira el {nuevoToken.FechaVencimiento}.\n\n" +
                                "Si no solicitaste este cambio, ignora este mensaje.";

                EmailService.EnviarEmail(usuarioARecuperar.CorreoElectronico, asunto, cuerpo);
            }
            catch (Exception ex)
            {
                ExceptionExtension.Handle(ex);
            }
        }

        public static void IniciarSesionToken(string token)
        {
            try
            {
                if (string.IsNullOrEmpty(token))
                {
                    throw new Exception("Ingrese un token para iniciar sesión");
                }
                PasswordToken resetToken = PasswordTokenRepository.Current.GetByToken(token);
                if(resetToken == null)
                {
                    throw new Exception("No se encontró el token ingresado");
                }
                if(resetToken.FechaVencimiento < DateTime.Now)
                {
                    throw new Exception("El token ya expiró. Solicite uno nuevo");
                }
                if(resetToken.Usuario == null || !resetToken.Usuario.EstaHabilitado)
                {
                    throw new Exception("El usuario no existe o está deshabilitado");
                }
                UsuarioLogueado.IniciarSesion(resetToken.Usuario);
            }
            catch(Exception ex)
            {
                ExceptionExtension.Handle(ex);
            }
        }

        public static void CambiarContraseña(string nombreUsuario, string contraseñaActual, string nuevaContraseña)
        {
            try
            {
                if (string.IsNullOrEmpty(nombreUsuario))
                {
                    throw new Exception("El usuario es inválido");
                }
                if (string.IsNullOrEmpty(contraseñaActual))
                {
                    throw new Exception("Debe ingresar la contraseña actual o token");
                }
                if (string.IsNullOrEmpty(nuevaContraseña))
                {
                    throw new Exception("Debe ingresar la nueva contraseña");
                }
                if(nuevaContraseña.Length < 8)
                {
                    throw new Exception("La nueva contraseña debe tener al menos 8 caracteres");
                }
                Usuario usuarioACambiar = UsuarioService.Current.GetByCredentials(nombreUsuario, contraseñaActual);
                if(usuarioACambiar == null)
                {
                    throw new Exception("Contraseña actual o token incorrectos.");
                }
                usuarioACambiar.Password = CriptographyService.HashMd5(nuevaContraseña);
                UsuarioRepository.Current.Update(usuarioACambiar);
                LoggerService.GetLogger().WriteLog(new LogEntry(DateTime.Now, LogLevel.Debug, $"Usuario {usuarioACambiar.Nombre} cambió su contraseña"));
            }
            catch (Exception ex)
            {
                ex.Handle();
            }
        }

        public static void CambiarContraseña(string token, string nuevaContraseña)
        {
            try
            {
                if (string.IsNullOrEmpty(token))
                {
                    throw new Exception("Debe ingresar el token");
                }
                if (string.IsNullOrEmpty(nuevaContraseña))
                {
                    throw new Exception("Debe ingresar una nueva contraseña");
                }
                if(nuevaContraseña.Length < 8)
                {
                    throw new Exception("La nueva contraseña debe tener al menos 8 caracteres");
                }
                PasswordToken resetToken = PasswordTokenRepository.Current.GetByToken(token);
                Usuario usuarioACambiar = resetToken.Usuario;
                if (resetToken == null)
                {
                    throw new Exception("No se encontró el token ingresado");
                }
                if (resetToken.FechaVencimiento < DateTime.Now)
                {
                    throw new Exception("El token ya expiró. Solicite uno nuevo");
                }
                if (resetToken.Usuario == null || !resetToken.Usuario.EstaHabilitado)
                {
                    throw new Exception("El usuario no existe o está deshabilitado");
                }
                usuarioACambiar.Password = CriptographyService.HashMd5(nuevaContraseña);
                UsuarioRepository.Current.Update(usuarioACambiar);
                LoggerService.GetLogger().WriteLog(new LogEntry(DateTime.Now, LogLevel.Debug, $"Usuario {usuarioACambiar.Nombre} cambió su contraseña"));
            }
            catch (Exception ex)
            {
                ex.Handle();
            }

        }
    }
}
