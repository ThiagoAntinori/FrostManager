using DAL.Adapter;
using DAL.Contracts;
using DAL.Tools;
using Domain;
using Microsoft.Data.SqlClient;
using Services.BLL.Extensions;
using System;
using System.Collections.Generic;
using System.Data;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL.Implementations
{
    public class DetalleVentaRepository : IGenericRepository<DetalleVenta>
    {

        private readonly static DetalleVentaRepository _instance = new DetalleVentaRepository();

        public static DetalleVentaRepository Current
        {
            get
            {
                return _instance;
            }
        }

        private DetalleVentaRepository()
        {
            // Implement here the initialization of your singleton
        }

        public void Delete(DetalleVenta obj)
        {
            throw new NotImplementedException();
        }

        public IEnumerable<DetalleVenta> GetAll()
        {
            try
            {
                DetalleVenta detalleVentaGet = null;
                List<DetalleVenta> detallesVenta = new List<DetalleVenta>();
                using(SqlDataReader reader = SqlHelper.ExecuteReader("SELECT IdDetalleVenta, Cantidad, IdProducto, IdVenta FROM DetalleVenta",
                                                                        CommandType.Text,
                                                                        new SqlParameter[]{}))
                {
                    object[] values = new object[reader.FieldCount];

                    while (reader.Read())
                    {
                        reader.GetValues(values);
                        detalleVentaGet = DetalleVentaAdapter.Current.Adapt(values);
                        detallesVenta.Add(detalleVentaGet);
                    }
                }
                return detallesVenta;
            }
            catch (Exception ex)
            {
                ExceptionExtension.Handle(ex);
                throw;
            }
        }

        public DetalleVenta GetById(Guid id)
        {
            try
            {
                DetalleVenta detalleVentaGet = null;
                using (SqlDataReader reader = SqlHelper.ExecuteReader("SELECT IdDetalleVenta, Cantidad, IdProducto, IdVenta FROM DetalleVenta WHERE IdDetalleVenta = @IdDetalleVenta AND Borrado = 0",
                                                                        CommandType.Text,
                                                                        new SqlParameter[] 
                                                                        {
                                                                            new SqlParameter("@IdDetalleVenta", id)
                                                                        }))
                {
                    object[] values = new object[reader.FieldCount];

                    if (reader.Read())
                    {
                        reader.GetValues(values);
                        detalleVentaGet = DetalleVentaAdapter.Current.Adapt(values);
                    }
                }
                return detalleVentaGet;
            }
            catch (Exception ex)
            {
                ExceptionExtension.Handle(ex);
                throw;
            }
        }

        public void Insert(DetalleVenta obj)
        {
            try
            {
                SqlHelper.ExecuteNonQuery("INSERT INTO DetalleVenta (IdDetalleVenta, Cantidad, IdProducto, IdVenta) VALUES (@IdDetalleVenta, @Cantidad, @IdProducto, @IdVenta",
                                            CommandType.Text,
                                            new SqlParameter[]
                                            {
                                                new SqlParameter("@IdDetalleVenta", obj.IdDetalleVenta),
                                                new SqlParameter("@Cantidad", obj.Cantidad),
                                                new SqlParameter("@IdProducto", obj.Producto.IdProducto),
                                                new SqlParameter("@IdVenta", obj.IdVenta)
                                            });
            }
            catch (Exception ex)
            {
                ExceptionExtension.Handle(ex);
            }
        }

        public void Update(DetalleVenta obj)
        {
            try
            {
                SqlHelper.ExecuteNonQuery("UPDATE DetalleVenta SET Cantidad = @Cantidad WHERE IdDetalleVenta = @IdDetalleVenta",
                    CommandType.Text,
                    new SqlParameter[]
                    {
                        new SqlParameter("@Cantidad", obj.Cantidad),
                        new SqlParameter("@IdDetalleVenta", obj.IdDetalleVenta)
                    });
            }
            catch (Exception ex)
            {
                ExceptionExtension.Handle(ex);
            }   
        }

        public List<DetalleVenta> GetByIdVenta(Guid idVenta)
        {
            try
            {
                DetalleVenta detalleVentaGet = null;
                List<DetalleVenta> detallesVenta = new List<DetalleVenta>();
                using (SqlDataReader reader = SqlHelper.ExecuteReader("SELECT IdDetalleVenta, Cantidad, IdProducto, IdVenta FROM DetalleVenta WHERE IdVenta = @IdVenta AND Borrado = 0",
                                                                        CommandType.Text,
                                                                        new SqlParameter[] 
                                                                        {
                                                                            new SqlParameter("@IdVenta", idVenta)
                                                                        }))
                {
                    object[] values = new object[reader.FieldCount];

                    while (reader.Read())
                    {
                        reader.GetValues(values);
                        detalleVentaGet = DetalleVentaAdapter.Current.Adapt(values);
                        detallesVenta.Add(detalleVentaGet);
                    }
                }
                return detallesVenta;
            }
            catch (Exception ex)
            {
                ExceptionExtension.Handle(ex);
                throw;
            }
        }
    }
}
