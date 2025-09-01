using Services.BLL.Contracts;
using Services.DAL.Implementations;
using Services.Domain.Security;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;

namespace Services.BLL.Services
{
    public class UsuarioService : IGenericService<Usuario>
    {

        private readonly static UsuarioService _instance = new UsuarioService();

        public static UsuarioService Current
        {
            get
            {
                return _instance;
            }
        }

        private UsuarioService()
        {
            // Implement here the initialization of your singleton
        }

        public void Add(Usuario obj)
        {
            try
            {
                if (string.IsNullOrEmpty(obj.CorreoElectronico))
                {
                    throw new Exception("El usuario debe tener un correo electrónico");
                }
                if (!obj.CorreoElectronico.Contains('@'))
                {
                    throw new Exception("El correo electrónico debe tener el formato correcto: user@example.com");
                }
                if (string.IsNullOrEmpty(obj.Nombre))
                {
                    throw new Exception("El usuario debe tener un nombre.");
                }
                if (ExisteUsuario(obj))
                {
                    throw new Exception("Ya existe un usuario con ese correo electrónico.");
                }
                obj.Password = CriptographyService.HashPassword(obj.Password);
                obj.EstaHabilitado = true;
                UsuarioRepository.Current.Insert(obj);
            }
            catch (Exception ex)
            {
                throw;
            }
        }

        public void Update(Usuario obj)
        {
            throw new NotImplementedException();
        }

        public void Delete(Guid id)
        {
            throw new NotImplementedException();
        }

        public List<Usuario> SelectAll()
        {
            throw new NotImplementedException();
        }

        public Usuario SelectOne(Guid id)
        {
            throw new NotImplementedException();
        }

        public bool ExisteUsuario(Usuario usuario)
        {
            try
            {
                if(usuario == null)
                {
                    throw new Exception("No es posible buscar el usuario");
                }
                if (this.GetByCorreoElectronico(usuario.CorreoElectronico) == null)
                {
                    return false;
                }
                return true;
            }
            catch(Exception ex)
            {
                throw;
            }
        }

        public void AddComponente(Usuario usuario, Componente componente)
        {
            try
            {
                if(componente == null)
                {
                    throw new Exception("Componente invalida");
                }
                if(usuario == null)
                {
                    throw new Exception("Usuario invalido");
                }
                if(componente.ChildrenCount() > 0)
                {
                    usuario.Familias.Add((Familia)componente);
                }
                else if(componente.ChildrenCount() == 0)
                {
                    usuario.Patentes.Add((Patente)componente);
                }
                UsuarioComponenteRepository.Current.Add(usuario);
            }
            catch (Exception ex)
            {

                throw;
            }
        }

        public Usuario GetByCorreoElectronico(string correo)
        {
            try
            {
                if (string.IsNullOrEmpty(correo))
                {
                    throw new Exception("No se pudo buscar el usuario por correo electrónico.");
                }
                return UsuarioRepository.Current.GetByCorreoElectronico(correo);
            }
            catch (Exception ex)
            {

                throw;
            }
        }

        public string GenerarPassword(int longitud = 8)
        {
            string caracteres = "ABCDEFGHIJKLMNOPQRSTUVWXYZabcdefghijklmnopqrstuvwxyz0123456789";
            Random random = new Random();
            byte[] bytesAleatorios = new byte[longitud];
            char[] passwordChars = new char[longitud];

            using (var rng = RandomNumberGenerator.Create())
            {
                rng.GetBytes(bytesAleatorios);
            }

            for (int i = 0; i < longitud; i++)
            {
                int index = bytesAleatorios[i] % caracteres.Length;
                passwordChars[i] = caracteres[index];
            }

            return new string(passwordChars);
        }
    }
}
