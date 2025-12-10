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

namespace DAL.Implementations.SqlServer
{
    public class DetalleVentaSqlRepository : IDetalleVentaRepository
    {
        public void Delete(DetalleVenta obj, UnitOfWork uow = null)
        {
            try
            {
                SqlHelper.ExecuteNonQuery("UPDATE DetalleVenta SET Borrado = 1 WHERE IdDetalleVenta = @IdDetalleVenta",
                    CommandType.Text,
                    uow?.Transaction,
                    new SqlParameter[]
                    {
                        new SqlParameter("@IdDetalleVenta", obj.IdDetalleVenta)
                    });
            }
            catch (Exception ex)
            {
                ex.Handle();
            }
        }

        public IEnumerable<DetalleVenta> GetAll()
        {
            try
            {
                DetalleVenta detalleVentaGet = null;
                List<DetalleVenta> detallesVenta = new List<DetalleVenta>();
                using (SqlDataReader reader = SqlHelper.ExecuteReader("SELECT IdDetalleVenta, Cantidad, IdProducto, IdVenta FROM DetalleVenta WHERE Borrado = 0",
                                                                        CommandType.Text,
                                                                        new SqlParameter[] { }))
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
                ex.Handle();
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
                ex.Handle();
                throw;
            }
        }

        public void Insert(DetalleVenta obj, UnitOfWork uow = null)
        {
            try
            {
                SqlHelper.ExecuteNonQuery("INSERT INTO DetalleVenta (IdDetalleVenta, Cantidad, IdProducto, IdVenta, Borrado) VALUES (@IdDetalleVenta, @Cantidad, @IdProducto, @IdVenta, 0)",
                                            CommandType.Text,
                                            uow?.Transaction,
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
                ex.Handle();
            }
        }

        public void Update(DetalleVenta obj, UnitOfWork uow = null)
        {
            try
            {
                SqlHelper.ExecuteNonQuery("UPDATE DetalleVenta SET Cantidad = @Cantidad WHERE IdDetalleVenta = @IdDetalleVenta AND Borrado = 0",
                    CommandType.Text,
                    uow?.Transaction,
                    new SqlParameter[]
                    {
                        new SqlParameter("@Cantidad", obj.Cantidad),
                        new SqlParameter("@IdDetalleVenta", obj.IdDetalleVenta)
                    });
            }
            catch (Exception ex)
            {
                ex.Handle();
            }
        }

        public IEnumerable<DetalleVenta> GetByIdVenta(Guid idVenta)
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
                ex.Handle();
                throw;
            }
        }

        public IEnumerable<DetalleVenta> GetDetallesPendientesByProducto(Guid idProducto)
        {
            try
            {
                DetalleVenta detalleVentaGet = null;
                List<DetalleVenta> detallesVenta = new List<DetalleVenta>();

                string selectQuery = @"SELECT dv.IdDetalleVenta, dv.Cantidad, dv.IdProducto, dv.IdVenta 
                                        FROM DetalleVenta dv
                                        INNER JOIN Venta v ON v.IdVenta = dv.IdVenta
                                        WHERE dv.IdProducto = @IdProducto AND dv.Borrado = 0 AND v.IdEstadoVenta IN (@IdEstadoEnCurso, @IdEstadoPendientePago)";

                using (SqlDataReader reader = SqlHelper.ExecuteReader(selectQuery,
                                                                        CommandType.Text,
                                                                        new SqlParameter[]
                                                                        {
                                                                            new SqlParameter("@IdProducto", idProducto),
                                                                            new SqlParameter("@IdEstadoEnCurso", (int)EstadoVenta.EnCurso),
                                                                            new SqlParameter("@IdEstadoPendientePago", (int)EstadoVenta.PendienteDePago)
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
                ex.Handle();
                throw;
            }
        }
    }
}
