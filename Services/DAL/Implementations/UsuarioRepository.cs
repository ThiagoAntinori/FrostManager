using Microsoft.Data.SqlClient;
using Services.DAL.Adapter;
using Services.DAL.Contracts;
using Services.DAL.Tools;
using Services.Domain.Security;
using System;
using System.Collections.Generic;
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
                throw;
            }
        }

        public void Delete(Usuario item)
        {

        }

        public void Update(Usuario item)
        {
            throw new NotImplementedException();
        }

        public List<Usuario> GetAll()
        {
            throw new NotImplementedException();
        }

        public Usuario GetById(Guid id)
        {
            throw new NotImplementedException();
        }

        public Usuario GetByCorreoElectronico(string correo)
        {
            try
            {
                Usuario usuarioABuscar = null;
                using (var Reader = SqlHelper.ExecuteReader("SELECT IdUsuario, CorreoElectronico, Nombre, Password, EstaHabilitado FROM USUARIO WHERE CorreoElectronico = @CorreoElectronico",
                    System.Data.CommandType.Text,
                    new SqlParameter[]{
                        new SqlParameter("@CorreoElectronico", correo)
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

                throw;
            }
        }
    }
}
