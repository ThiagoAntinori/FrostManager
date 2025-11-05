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
                string selectQuery = @"
                    SELECT i.IdInsumo, i.Descripcion, i.StockActual, i.StockMinimo, e.CapacidadEnGramos
                    FROM Insumo i
                    INNER JOIN Envase e ON e.IdEnvase = i.IdInsumo
                    WHERE e.Borrado = 0";
                using (SqlDataReader reader = SqlHelper.ExecuteReader(selectQuery,
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
                string selectQuery = @"
                    SELECT i.IdInsumo, i.Descripcion, i.StockActual, i.StockMinimo, e.CapacidadEnGramos
                    FROM Insumo i
                    INNER JOIN Envase e ON e.IdEnvase = i.IdInsumo
                    WHERE i.IdInsumo = @IdEnvase AND e.Borrado = 0";

                using (SqlDataReader reader = SqlHelper.ExecuteReader(selectQuery, CommandType.Text,
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
                string insertQuery = @"INSERT INTO Insumo (IdInsumo, Descripcion, StockActual, StockMinimo) VALUES (@IdEnvase, @Descripcion, @StockActual, @StockMinimo);
                                        INSERT INTO Envase (IdEnvase, CapacidadEnGramos, Borrado) VALUES (@IdEnvase, @CapacidadEnGramos, 0);";
                SqlHelper.ExecuteNonQuery(insertQuery,
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
                string updateQuery = @"UPDATE Insumo SET Descripcion = @Descripcion, StockActual = @StockActual, StockMinimo = @StockMinimo WHERE IdEnvase = @IdEnvase;
                                        UPDATE Envase SET CapacidadEnGramos = @CapacidadEnGramos WHERE IdEnvase = @IdEnvase AND Borrado = 0";
                SqlHelper.ExecuteNonQuery(updateQuery,
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
