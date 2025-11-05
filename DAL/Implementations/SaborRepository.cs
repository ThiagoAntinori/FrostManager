using DAL.Contracts;
using DAL.Tools;
using Domain;
using System;
using System.Data;
using Microsoft.Data.SqlClient;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Services.BLL.Extensions;
using DAL.Adapter;

namespace DAL.Implementations
{
    public class SaborRepository : IGenericRepository<Sabor>
    {

        private readonly static SaborRepository _instance = new SaborRepository();

        public static SaborRepository Current
        {
            get
            {
                return _instance;
            }
        }

        private SaborRepository()
        {
            // Implement here the initialization of your singleton
        }

        public void Delete(Sabor obj)
        {

            try
            {
                string deleteQuery = "UPDATE Sabor SET Borrado = 1 WHERE IdSabor = @IdSabor";
                SqlHelper.ExecuteNonQuery(deleteQuery, CommandType.Text,
                    new SqlParameter[]
                    {
                        new SqlParameter("@IdSabor", obj.IdInsumo)
                    });
            }
            catch (Exception ex)
            {
                ExceptionExtension.Handle(ex);
            }
        }

        public IEnumerable<Sabor> GetAll()
        {
            try
            {
                Sabor saborGet = null;
                List<Sabor> sabores = new List<Sabor>();
                string selectQuery = @"
                    SELECT i.IdInsumo, i.Descripcion, i.StockActual, i.StockMinimo
                    FROM Insumo i
                    INNER JOIN Sabor s ON s.IdSabor = i.IdInsumo
                    WHERE s.Borrado = 0";
                using (SqlDataReader reader = SqlHelper.ExecuteReader(selectQuery,
                                                                        CommandType.Text,
                                                                        new SqlParameter[]
                                                                        {}))
                {
                    object[] values = new object[reader.FieldCount];

                    while (reader.Read())
                    {
                        reader.GetValues(values);
                        saborGet = SaborAdapter.Current.Adapt(values);
                        sabores.Add(saborGet);
                    }
                }
                return sabores;
            }
            catch (Exception ex)
            {
                ExceptionExtension.Handle(ex);
                throw;
            }
        }

        public Sabor GetById(Guid id)
        {
            try
            {
                Sabor saborGet = null;
                string selectQuery = @"
                    SELECT i.IdInsumo, i.Descripcion, i.StockActual, i.StockMinimo
                    FROM Insumo i
                    INNER JOIN Sabor s ON s.IdSabor = i.IdInsumo
                    WHERE i.IdInsumo = @IdSabor AND s.Borrado = 0";

                using (SqlDataReader reader = SqlHelper.ExecuteReader(selectQuery,
                                                                    CommandType.Text,
                                                                    new SqlParameter[]
                                                                    {
                                                                        new SqlParameter("@IdSabor", id)
                                                                    }))
                {
                    object[] values = new object[reader.FieldCount];

                    if (reader.Read())
                    {
                        reader.GetValues(values);
                        saborGet = SaborAdapter.Current.Adapt(values);
                    }
                }
                return saborGet;
            }
            catch (Exception ex)
            {
                ExceptionExtension.Handle(ex);
                throw;
            }
        }

        public void Insert(Sabor obj)
        {
            try
            {
                string insertQuery = @"
                    INSERT INTO Insumo (IdInsumo, Descripcion, StockActual, StockMinimo) VALUES (@IdSabor, @Descripcion, @StockActual, @StockMinimo);
                    INSERT INTO Sabor (IdSabor, Borrado) VALUES (@IdSabor, 0);";
                SqlHelper.ExecuteNonQuery(insertQuery,
                                            CommandType.Text,
                                            new SqlParameter[]
                                            {
                                                new SqlParameter("@IdSabor", obj.IdInsumo),
                                                new SqlParameter("@Descripcion", obj.Descripcion),
                                                new SqlParameter("@StockActual", obj.StockActual),
                                                new SqlParameter("@StockMinimo", obj.StockMinimo)
                                            });
            }
            catch (Exception ex)
            {
                ExceptionExtension.Handle(ex);
            }
        }

        public void Update(Sabor obj)
        {
            try
            {
                string updateQuery = @"
                    UPDATE Insumo SET Descripcion = @Descripcion, StockActual = @StockActual, StockMinimo = @StockMinimo WHERE IdInsumo = @IdSabor AND Borrado = 0;";
                SqlHelper.ExecuteNonQuery(updateQuery,
                                            CommandType.Text,
                                            new SqlParameter[]
                                            {
                                                new SqlParameter("@IdSabor", obj.IdInsumo),
                                                new SqlParameter("@Descripcion", obj.Descripcion),
                                                new SqlParameter("@StockActual", obj.StockActual),
                                                new SqlParameter("@StockMinimo", obj.StockMinimo)
                                            });
            }
            catch (Exception ex)
            {
                ExceptionExtension.Handle(ex);
                throw;
            }
        }
    }
}
