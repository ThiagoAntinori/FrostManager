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
            throw new NotImplementedException();
        }

        public IEnumerable<Sabor> GetAll()
        {
            try
            {
                Sabor saborGet = null;
                List<Sabor> sabores = new List<Sabor>();

                using(SqlDataReader reader = SqlHelper.ExecuteReader("SELECT IdSabor, Descripcion, StockActual, StockMinimo FROM SABOR WHERE Borrado = 0",
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
                using (SqlDataReader reader = SqlHelper.ExecuteReader("SELECT IdSabor, Descripcion, StockActual, StockMinimo FROM SABOR WHERE IdSabor = @IdSabor AND Borrado = 0",
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
                SqlHelper.ExecuteNonQuery("INSERT INTO SABOR (IdSabor, Descripcion, StockActual, StockMinimo, Borrado) VALUES (@IdSabor, @Descripcion, @StockActual, @StockMinimo, 0)",
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
                SqlHelper.ExecuteNonQuery("UPDATE SABOR SET Descripcion = @Descripcion, StockActual = @StockActual, StockMinimo = @StockMinimo WHERE IdSabor = @IdSabor",
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
    }
}
