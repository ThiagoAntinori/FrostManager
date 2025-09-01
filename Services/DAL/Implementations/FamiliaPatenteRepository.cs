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
    public class FamiliaPatenteRepository
    {

        private readonly static FamiliaPatenteRepository _instance = new FamiliaPatenteRepository();

        public static FamiliaPatenteRepository Current
        {
            get
            {
                return _instance;
            }
        }

        private FamiliaPatenteRepository()
        {
            // Implement here the initialization of your singleton
        }

        public void Add(Familia obj)
        {
            try
            {
                foreach(var item in obj.GetChildren())
                {
                    if(item.ChildrenCount() == 0)
                    {
                        SqlHelper.ExecuteNonQuery("IF NOT EXISTS (" +
                            "SELECT 1 FROM FAMILIA_PATENTE " +
                            "WHERE IdFamilia = @IdFamilia AND IdPatente = @IdPatente) " +
                            "BEGIN " +
                            "INSERT INTO FAMILIA_PATENTE (IdFamilia, IdPatente) " +
                            "VALUES (@IdFamilia, @IdPatente) " +
                            "END", CommandType.Text,
                            new SqlParameter[]
                            {
                                new SqlParameter("@IdFamilia", obj.IdComponente),
                                new SqlParameter("@IdPatente", item.IdComponente)
                            });
                    }
                }
            }
            catch (Exception ex)
            {

                throw;
            }
        }

        public void Delete(Familia obj)
        {
            try
            {

            }
            catch (Exception ex)
            {
                throw;
            }
        }

        public void GetChildren(Familia obj)
        {
            try
            {
                Patente patenteGet = null;

                using (var reader = SqlHelper.ExecuteReader("SELECT IdFamilia, IdPatente FROM FAMILIA_PATENTE WHERE IdFamilia = @IdFamilia",
                                                            CommandType.Text,
                                                            new SqlParameter[]
                                                            {
                                                                new SqlParameter("@IdFamilia", obj.IdComponente)
                                                            }))
                {
                    object[] values = new object[reader.FieldCount];

                    while (reader.Read())
                    {
                        reader.GetValues(values);
                        Guid idPatenteHija = Guid.Parse(values[1].ToString());
                        patenteGet = PatenteRepository.Current.GetById(idPatenteHija);
                        obj.Agregar(patenteGet);
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
