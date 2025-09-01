using Services.Domain.Security;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Services.BLL.Services
{
    public static class SesionService
    {
        public static void Login(string correoElectronico, string password)
        {
            try
            {
                if (string.IsNullOrEmpty(correoElectronico))
                {
                    throw new Exception("Ingrese un correo electrónico para iniciar sesión.");
                }
                if (string.IsNullOrEmpty(password))
                {
                    throw new Exception("Ingrese una contraseña para iniciar sesión.");
                }
                Usuario usuarioRegistrado = UsuarioService.Current.GetByCorreoElectronico(correoElectronico);
                if(usuarioRegistrado == null)
                {
                    throw new Exception("No se encontró un usuario con el correo electrónico ingresado");
                }
                if(!VerificarContraseña(usuarioRegistrado, password))
                {
                    throw new Exception("La contraseña es incorrecta. Intenta nuevamente");
                }
                UsuarioLogueado.IniciarSesion(usuarioRegistrado);
            }
            catch(Exception ex)
            {
                throw;
            }
        }

        private static bool VerificarContraseña(Usuario usuario, string password)
        {
            return usuario.Password == CriptographyService.HashPassword(password);
        }
    }
}
