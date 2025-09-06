using Services.Domain.Security;
using Services.Domain.Logging;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Services.BLL.Extensions;

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
    }
}
