using Microsoft.Data.SqlClient;
using Services.BLL.Extensions;
using Services.DAL.Adapter;
using Services.DAL.Contracts;
using Services.DAL.Tools;
using Services.Domain.Security;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Services.DAL.Implementations
{
    public class UsuarioRepository : IGenericRepository<Usuario>
    {

        private readonly static UsuarioRepository _instance = new UsuarioRepository();

        public static UsuarioRepository Current
        {
            get
            {
                return _instance;
            }
        }

        private UsuarioRepository()
        {
            // Implement here the initialization of your singleton
        }

        public void Insert(Usuario item)
        {
            try
            {
                SqlHelper.ExecuteNonQuery("INSERT INTO USUARIO (IdUsuario, CorreoElectronico, Nombre, Password, EstaHabilitado) VALUES (@IdUsuario, @CorreoElectronico, @Nombre, @Password, @EstaHabilitado)",
                                            System.Data.CommandType.Text, new SqlParameter[]
                                            {
                                                new SqlParameter("@IdUsuario", item.IdUsuario),
                                                new SqlParameter("@CorreoElectronico", item.CorreoElectronico),
                                                new SqlParameter("@Nombre", item.Nombre),
                                                new SqlParameter("@Password", item.Password),
                                                new SqlParameter("@EstaHabilitado", item.EstaHabilitado)
                                            });
            }
            catch(Exception ex)
            {
                ExceptionExtension.Handle(ex);
            }
        }

        public void Delete(Usuario item)
        {

        }

        public void Update(Usuario item)
        {
            try
            {
                SqlHelper.ExecuteNonQuery("UPDATE USUARIO SET Nombre = @Nombre, CorreoElectronico = @CorreoElectronico WHERE IdUsuario = @IdUsuario",
                    CommandType.Text,
                    new SqlParameter[]
                    {
                        new SqlParameter("@Nombre", item.Nombre),
                        new SqlParameter("@CorreoElectronico", item.CorreoElectronico),
                        new SqlParameter("@IdUsuario", item.IdUsuario)
                    });
            }
            catch (Exception ex)
            {
                ExceptionExtension.Handle(ex);
            }
        }

        public List<Usuario> GetAll()
        {
            try
            {
                Usuario usuarioGet = null;
                List<Usuario> usuarios = new List<Usuario>();
                using (var Reader = SqlHelper.ExecuteReader("SELECT IdUsuario, CorreoElectronico, Nombre, Password, EstaHabilitado FROM USUARIO",
                    System.Data.CommandType.Text,
                    new SqlParameter[]{}))
                {
                    object[] values = new object[Reader.FieldCount];

                    while (Reader.Read())
                    {
                        Reader.GetValues(values);
                        usuarioGet = UsuarioAdapter.Current.Adapt(values);
                        usuarios.Add(usuarioGet);
                    }
                    return usuarios;
                }
            }
            catch (Exception ex)
            {
                ExceptionExtension.Handle(ex);
                throw;
            }
        }

        public Usuario GetById(Guid id)
        {
            try
            {
                Usuario usuarioABuscar = null;
                using (var Reader = SqlHelper.ExecuteReader("SELECT IdUsuario, CorreoElectronico, Nombre, Password, EstaHabilitado FROM USUARIO WHERE IdUsuario = @IdUsuario",
                    System.Data.CommandType.Text,
                    new SqlParameter[]{
                        new SqlParameter("@IdUsuario", id)
                    }))
                {
                    object[] values = new object[Reader.FieldCount];

                    if (Reader.Read())
                    {
                        Reader.GetValues(values);
                        usuarioABuscar = UsuarioAdapter.Current.Adapt(values);
                    }
                    return usuarioABuscar;
                }
            }
            catch (Exception ex)
            {
                ExceptionExtension.Handle(ex);
                throw;
            }
        }

        public Usuario GetByNombreUsuario(string nombreUsuario)
        {
            try
            {
                Usuario usuarioABuscar = null;
                using (var Reader = SqlHelper.ExecuteReader("SELECT IdUsuario, CorreoElectronico, Nombre, Password, EstaHabilitado FROM USUARIO WHERE Nombre = @Nombre",
                    System.Data.CommandType.Text,
                    new SqlParameter[]{
                        new SqlParameter("@Nombre", nombreUsuario)
                    }))
                {
                    object[] values = new object[Reader.FieldCount];

                    if (Reader.Read())
                    {
                        Reader.GetValues(values);
                        usuarioABuscar = UsuarioAdapter.Current.Adapt(values);
                    }
                    return usuarioABuscar;
                }
            }
            catch (Exception ex)
            {
                ExceptionExtension.Handle(ex);
                throw;
            }
        }

        public void CambiarEstado(Usuario usuario)
        {
            try
            {
                SqlHelper.ExecuteNonQuery("UPDATE USUARIO SET EstaHabilitado = @EstaHabilitado WHERE IdUsuario = @IdUsuario",
                    CommandType.Text,
                    new SqlParameter[]
                    {
                        new SqlParameter("@EstaHabilitado", !usuario.EstaHabilitado),
                        new SqlParameter("@IdUsuario", usuario.IdUsuario)
                    });
            }
            catch (Exception ex)
            {
                ExceptionExtension.Handle(ex);
            }
        }
    }
}
