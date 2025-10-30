using DAL.Adapter;
using DAL.Contracts;
using DAL.Tools;
using Domain;
using Microsoft.Data.SqlClient;
using Services.BLL.Extensions;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL.Implementations
{
    public class EnvaseRepository : IGenericRepository<Envase>
    {

        private readonly static EnvaseRepository _instance = new EnvaseRepository();

        public static EnvaseRepository Current
        {
            get
            {
                return _instance;
            }
        }

        private EnvaseRepository()
        {
            // Implement here the initialization of your singleton
        }

        public void Delete(Envase obj)
        {
            try
            {
                SqlHelper.ExecuteNonQuery("UPDATE ENVASE SET Borrado = 1 WHERE IdEnvase = @IdEnvase",
                                            CommandType.Text,
                                            new SqlParameter[]
                                            {
                                                new SqlParameter("@IdEnvase", obj.IdInsumo)
                                            });
            }
            catch (Exception ex)
            {
                throw;
            }
        }

        public IEnumerable<Envase> GetAll()
        {
            try
            {
                Envase envaseGet = null;
                List<Envase> envases = new List<Envase>();
                using(SqlDataReader reader = SqlHelper.ExecuteReader("SELECT IdEnvase, Descripcion, StockActual, StockMinimo, CapacidadEnGramos FROM ENVASE WHERE Borrado = 0",
                        CommandType.Text,
                        new SqlParameter[] { }))
                {
                    object[] values = new object[reader.FieldCount];
                    while (reader.Read())
                    {
                        reader.GetValues(values);
                        envaseGet = EnvaseAdapter.Current.Adapt(values);
                        envases.Add(envaseGet);
                    }
                    return envases;
                }
            }
            catch (Exception ex)
            {
                ExceptionExtension.Handle(ex);
                throw;
            }
        }

        public Envase GetById(Guid id)
        {
            try
            {
                Envase envaseGet = null;
                using (SqlDataReader reader = SqlHelper.ExecuteReader("SELECT IdEnvase, Descripcion, StockActual, StockMinimo, CapacidadEnGramos FROM ENVASE WHERE IdEnvase = @IdEnvase",
                                                                    CommandType.Text,
                                                                    new SqlParameter[]
                                                                    {
                                                                        new SqlParameter("@IdEnvase", id)
                                                                    }))
                {
                    object[] values = new object[reader.FieldCount];

                    if (reader.Read())
                    {
                        reader.GetValues(values);
                        envaseGet =  EnvaseAdapter.Current.Adapt(values);
                    }
                }
                return envaseGet;
            }
            catch (Exception ex)
            {
                ExceptionExtension.Handle(ex);
                throw;
            }
        }

        public void Insert(Envase obj)
        {
            try
            {
                SqlHelper.ExecuteNonQuery("INSERT INTO ENVASE (IdEnvase, Descripcion, StockActual, StockMinimo, Borrado, CapacidadEnGramos) VALUES (@IdEnvase, @Descripcion, @StockActual, @StockMinimo, 0, @CapacidadEnGramos);",
                                        CommandType.Text,
                                        new SqlParameter[]
                                        {
                                            new SqlParameter("@IdEnvase", obj.IdInsumo),
                                            new SqlParameter("@Descripcion", obj.Descripcion),
                                            new SqlParameter("@StockActual", obj.StockActual),
                                            new SqlParameter("@StockMinimo", obj.StockMinimo),
                                            new SqlParameter("@CapacidadEnGramos", obj.CapacidadEnGramos)
                                        });
            }
            catch (Exception ex)
            {
                ExceptionExtension.Handle(ex);
            }
        }

        public void Update(Envase obj)
        {
            try
            {
                SqlHelper.ExecuteNonQuery("UPDATE ENVASE SET Descripcion = @Descripcion, StockActual = @StockActual, StockMinimo = @StockMinimo, CapacidadEnGramos = @CapacidadEnGramos WHERE IdEnvase = @IdEnvase AND Borrado = 0",
                                    CommandType.Text,
                                    new SqlParameter[]
                                    {
                                        new SqlParameter("@IdEnvase", obj.IdInsumo),
                                        new SqlParameter("@Descripcion", obj.Descripcion),
                                        new SqlParameter("@StockActual", obj.StockActual),
                                        new SqlParameter("@StockMinimo", obj.StockMinimo),
                                        new SqlParameter("@CapacidadEnGramos", obj.CapacidadEnGramos)
                                    });
            }
            catch (Exception ex)
            {
                ExceptionExtension.Handle(ex);
            }
        }
    }
}
