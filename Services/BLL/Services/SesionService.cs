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
                Usuario usuarioRegistrado = UsuarioService.Current.GetByNombreUsuario(nombreUsuario);
                if(usuarioRegistrado == null)
                {
                    throw new Exception("No se encontró un usuario con el nombre ingresado");
                }
                if(!VerificarContraseña(usuarioRegistrado, password))
                {
                    throw new Exception("La contraseña es incorrecta. Intenta nuevamente");
                }
                if (!usuarioRegistrado.EstaHabilitado)
                {
                    throw new Exception("El usuario no está habilitado. Contacte al administrador");
                }
                UsuarioLogueado.IniciarSesion(usuarioRegistrado);
                LoggerService.GetLogger().WriteLog(new LogEntry(DateTime.Now, LogLevel.Information, "Ocurrió un inicio de sesión."));
            }
            catch(Exception ex)
            {
                ExceptionExtension.Handle(ex);
            }
        }

        private static bool VerificarContraseña(Usuario usuario, string password)
        {
            return usuario.Password == CriptographyService.HashMd5(password);
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
                PasswordToken nuevoToken = new PasswordToken(Guid.NewGuid().ToString(), usuarioARecuperar, DateTime.Now.AddMinutes(15));
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
    }
}
