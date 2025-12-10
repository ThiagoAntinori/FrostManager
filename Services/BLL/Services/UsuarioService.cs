using Services.BLL.Contracts;
using Services.BLL.Extensions;
using Services.DAL.Implementations;
using Services.Domain.Logging;
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
                    throw new Exception("Ya existe un usuario con ese nombre de usuario.");
                }
                obj.Password = CriptographyService.HashMd5(obj.Password);
                obj.EstaHabilitado = true;
                UsuarioRepository.Current.Insert(obj);
                LoggerService.GetLogger().WriteLog(new LogEntry(DateTime.Now, LogLevel.Information, $"Se registró un nuevo usuario. ID: {obj.IdUsuario}. Nombre: {obj.Nombre}"));
            }
            catch (Exception ex)
            {
                ExceptionExtension.Handle(ex);
            }
        }

        public void Update(Usuario obj)
        {
            try
            {
                if (string.IsNullOrEmpty(obj.Nombre))
                {
                    throw new Exception("El usuario debe tener un nombre");
                }
                if (string.IsNullOrEmpty(obj.CorreoElectronico))
                {
                    throw new Exception("El usuario debe tener un correo electrónico");
                }
                if (!obj.CorreoElectronico.Contains('@'))
                {
                    throw new Exception("El correo electrónico debe tener el formato correcto: user@example.com");
                }
                if (ExisteUsuario(obj))
                {
                    throw new Exception("Ya existe un usuario con ese nombre");
                }
                UsuarioRepository.Current.Update(obj);
                LoggerService.GetLogger().WriteLog(new LogEntry(DateTime.Now, LogLevel.Information, $"Se modificó un usuario. ID: {obj.IdUsuario}. Nombre: {obj.Nombre}"));
            }
            catch(Exception ex)
            {
                ExceptionExtension.Handle(ex);
            }
        }

        public void Delete(Usuario obj)
        {
            throw new NotImplementedException();
        }

        public List<Usuario> SelectAll()
        {
            try
            {
                return UsuarioRepository.Current.GetAll();
            }
            catch (Exception ex)
            {
                ExceptionExtension.Handle(ex);
                throw;
            }
        }

        public Usuario SelectOne(Guid id)
        {
            try
            {
                return UsuarioRepository.Current.GetById(id);
            }
            catch (Exception ex)
            {
                ex.Handle();
                throw;
            }
        }

        public bool ExisteUsuario(Usuario usuario)
        {
            try
            {
                if(usuario == null)
                {
                    throw new Exception("No es posible buscar el usuario");
                }
                if (UsuarioRepository.Current.GetByNombreUsuario(usuario.Nombre) == null)
                {
                    return false;
                }
                return true;
            }
            catch(Exception ex)
            {
                ExceptionExtension.Handle(ex);
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
                usuario.Privilegios.Add(componente);
                UsuarioComponenteRepository.Current.Add(usuario);
                LoggerService.GetLogger().WriteLog(new LogEntry(DateTime.Now, LogLevel.Information, $"Se modificaron los permisos de un usuario. ID: {usuario.IdUsuario}. Nombre: {usuario.Nombre}"));
            }
            catch (Exception ex)
            {
                ExceptionExtension.Handle(ex);
            }
        }

        public void AddComponentes(Usuario usuario, List<Componente> componentes)
        {
            try
            {
                if(componentes == null || !componentes.Any())
                {
                    throw new Exception("Ingrese los componentes a añadir");
                }
                foreach(Componente comp in componentes)
                {
                    usuario.Privilegios.Add(comp);
                    UsuarioComponenteRepository.Current.Add(usuario);
                }
                LoggerService.GetLogger().WriteLog(new LogEntry(DateTime.Now, LogLevel.Information, $"Se modificaron los permisos de un usuario. ID: {usuario.IdUsuario}. Nombre: {usuario.Nombre}"));
            }
            catch (Exception ex)
            {
                ex.Handle();
            }
        }

        public void CambiarEstado(Usuario usuario)
        {
            try
            {
                if(usuario == null)
                {
                    throw new ArgumentNullException(nameof(usuario));
                }
                UsuarioRepository.Current.CambiarEstado(usuario);
                LoggerService.GetLogger().WriteLog(new LogEntry(DateTime.Now, LogLevel.Information, $"Se modificó el estado de un usuario. ID: {usuario.IdUsuario}. Nombre: {usuario.Nombre}"));
            }
            catch (Exception ex)
            {
                ExceptionExtension.Handle(ex);
            }
        }

        public Usuario GetByNombreUsuario(string nombreUsuario)
        {
            try
            {
                if (string.IsNullOrEmpty(nombreUsuario))
                {
                    throw new Exception("No se pudo buscar el usuario por su nombre.");
                }
                return UsuarioRepository.Current.GetByNombreUsuario(nombreUsuario);
            }
            catch (Exception ex)
            {
                ExceptionExtension.Handle(ex);
                throw;
            }
        }

        public Usuario GetByCredentials(string nombreUsuario, string password)
        {
            try
            {
                string hashPassword = CriptographyService.HashMd5(password);
                return UsuarioRepository.Current.GetByCredentials(nombreUsuario, hashPassword);
            }
            catch (Exception ex)
            {
                ExceptionExtension.Handle(ex);
                throw;
            }
        }

        public List<Usuario> GetByPatente(string nombrePatente)
        {
            try
            {
                if (string.IsNullOrEmpty(nombrePatente))
                {
                    throw new Exception("No se pudo buscar los usuarios por patente");
                }

                List<Usuario> usuarios = UsuarioRepository.Current.GetAll();
                List<Usuario> usuariosConPatente = new List<Usuario>();
                foreach(Usuario usuario in usuarios)
                {
                    List<string> nombresPatente = usuario.GetAllPatentes().Select(p => p.Nombre).ToList();
                    if (nombresPatente.Contains(nombrePatente))
                    {
                        usuariosConPatente.Add(usuario);
                    }
                }

                return usuariosConPatente;
            }
            catch(Exception ex)
            {
                ex.Handle();
                throw;
            }
        }

        public string GenerarPassword()
        {
            string caracteres = "ABCDEFGHIJKLMNOPQRSTUVWXYZabcdefghijklmnopqrstuvwxyz0123456789";
            byte[] bytesAleatorios = new byte[8];
            char[] passwordChars = new char[8];

            using (var rng = RandomNumberGenerator.Create())
            {
                rng.GetBytes(bytesAleatorios);
            }

            for (int i = 0; i < 8; i++)
            {
                int index = bytesAleatorios[i] % caracteres.Length;
                passwordChars[i] = caracteres[index];
            }

            return new string(passwordChars);
        }
    }
}
