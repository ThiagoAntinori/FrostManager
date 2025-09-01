using Microsoft.Data.SqlClient;
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
    public class UsuarioComponenteRepository
    {

        private readonly static UsuarioComponenteRepository _instance = new UsuarioComponenteRepository();

        public static UsuarioComponenteRepository Current
        {
            get
            {
                return _instance;
            }
        }

        private UsuarioComponenteRepository()
        {
            // Implement here the initialization of your singleton
        }

        public void Add(Usuario obj)
        {
            try
            {
                foreach(var item in obj.Familias)
                {
                    SqlHelper.ExecuteNonQuery(@" IF NOT EXISTS (
                                                    SELECT 1 FROM USUARIO_FAMILIA 
                                                    WHERE IdFamilia = @IdFamilia AND IdUsuario = @IdUsuario
                                                    )
                                                BEGIN
                                                    INSERT INTO USUARIO_FAMILIA (IdFamilia, IdUsuario)
                                                    VALUES (@IdFamilia, @IdUsuario)
                                                    END", 
                            CommandType.Text,
                            new SqlParameter[]
                            {
                                new SqlParameter("@IdFamilia", item.IdComponente),
                                new SqlParameter("@IdUsuario", obj.IdUsuario)
                            });
                }
                foreach(var item in obj.Patentes)
                {
                    SqlHelper.ExecuteNonQuery("IF NOT EXISTS (" +
                            "SELECT 1 FROM USUARIO_PATENTE " +
                            "WHERE IdUsuario = @IdUsuario AND IdPatente = @IdPatente) " +
                            "BEGIN" +
                            " INSERT INTO USUARIO_PATENTE (IdUsuario, IdPatente)" +
                            " VALUES (@IdUsuario, @IdPatente)" +
                            " END", CommandType.Text,
                            new SqlParameter[]
                            {
                                new SqlParameter("@IdUsuario", obj.IdUsuario),
                                new SqlParameter("@IdPatente", item.IdComponente)
                            });
                }
            }
            catch (Exception ex)
            {
                throw;
            }
        }

        public void Delete(Usuario obj)
        {

        }

        public void GetComponentes(Usuario obj)
        {
            try
            {
                Familia familiaGet = null;
                Patente patenteGet = null;

                //Obtener familias del usuario obj
                using (var reader = SqlHelper.ExecuteReader("SELECT IdUsuario, IdFamilia FROM USUARIO_FAMILIA WHERE IdUsuario = @IdUsuario",
                    CommandType.Text,
                    new SqlParameter[]
                    {
                        new SqlParameter("@IdUsuario", obj.IdUsuario)
                    }))
                {
                    object[] values = new object[reader.FieldCount];

                    while (reader.Read())
                    {
                        reader.GetValues(values);
                        Guid idFamilia = Guid.Parse(values[1].ToString());
                        familiaGet = FamiliaRepository.Current.GetById(idFamilia);
                        obj.Familias.Add(familiaGet);
                    }
                }

                //Obtener patentes del usuario obj
                using (var reader = SqlHelper.ExecuteReader("SELECT IdUsuario, IdPatente FROM USUARIO_PATENTE WHERE IdUsuario = @IdUsuario",
                    CommandType.Text,
                    new SqlParameter[]
                    {
                        new SqlParameter("@IdUsuario", obj.IdUsuario)
                    }))
                {
                    object[] values = new object[reader.FieldCount];

                    while (reader.Read())
                    {
                        reader.GetValues(values);
                        Guid idPatente = Guid.Parse(values[1].ToString());
                        patenteGet = PatenteRepository.Current.GetById(idPatente);
                        obj.Familias.Add(familiaGet);
                    }
                }
            }
            catch (Exception ex)
            {
                throw;
            }
        }
    }
}
