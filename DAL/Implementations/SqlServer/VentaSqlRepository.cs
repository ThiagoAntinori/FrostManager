using DAL.Adapter;
using DAL.Contracts;
using DAL.Tools;
using Domain;
using Microsoft.Data.SqlClient;
using Services.BLL.Extensions;
using Services.Domain.Security;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL.Implementations.SqlServer
{
    public class VentaSqlRepository : IVentaRepository
    {
        public void Delete(Venta obj, UnitOfWork uow = null)
        {
            try
            {
                SqlHelper.ExecuteNonQuery("UPDATE Venta SET Borrado = 1, IdEstadoVenta = @IdEstadoVenta WHERE IdVenta = @IdVenta",
                                            CommandType.Text,
                                            uow?.Transaction,
                                            new SqlParameter[]
                                            {
                                                new SqlParameter("@IdVenta", obj.IdVenta),
                                                new SqlParameter("@IdEstadoVenta", (int)EstadoVenta.Cancelada)
                                            });
            }
            catch (Exception ex)
            {
                ExceptionExtension.Handle(ex);
            }
        }

        public IEnumerable<Venta> GetAll()
        {
            try
            {
                Venta ventaGet = null;
                List<Venta> ventas = new List<Venta>();
                string selectQuery = @"SELECT IdVenta, EsDelivery, Fecha, Hora, IdMedioPago, IdEstadoVenta 
                                        FROM Venta 
                                        WHERE Borrado = 0
                                        ORDER BY Fecha DESC, Hora DESC";

                using (SqlDataReader reader = SqlHelper.ExecuteReader(selectQuery,
                    CommandType.Text,
                    new SqlParameter[]
                    {}))
                {
                    object[] values = new object[reader.FieldCount];

                    while (reader.Read())
                    {
                        reader.GetValues(values);
                        ventaGet = VentaAdapter.Current.Adapt(values);
                        ventas.Add(ventaGet);
                    }
                }
                return ventas;
            }
            catch (Exception ex)
            {
                ex.Handle();
                throw;
            }
        }

        public IEnumerable<Venta> GetByPeriodo(DateTime fechaInicio, DateTime fechaFin)
        {
            try
            {
                Venta ventaGet = null;
                List<Venta> ventas = new List<Venta>();
                string selectQuery = @"SELECT IdVenta, EsDelivery, Fecha, Hora, IdMedioPago, IdEstadoVenta 
                                        FROM Venta 
                                        WHERE Borrado = 0 AND Fecha BETWEEN @FechaInicio AND @FechaFin
                                        ORDER BY Fecha DESC, Hora DESC";


                using (SqlDataReader reader = SqlHelper.ExecuteReader(selectQuery,
                    CommandType.Text,
                    new SqlParameter[]
                    {
                        new SqlParameter("@FechaInicio", fechaInicio.Date),
                        new SqlParameter("@FechaFin", fechaFin.Date)
                    }))
                {
                    object[] values = new object[reader.FieldCount];

                    while (reader.Read())
                    {
                        reader.GetValues(values);
                        ventaGet = VentaAdapter.Current.Adapt(values);
                        ventas.Add(ventaGet);
                    }
                }
                return ventas;
            }
            catch (Exception ex)
            {
                ex.Handle();
                throw;
            }
        }

        public IEnumerable<Venta> GetByFecha(DateTime fecha)
        {
            try
            {
                Venta ventaGet = null;
                List<Venta> ventas = new List<Venta>();
                string selectQuery = @"SELECT IdVenta, EsDelivery, Fecha, Hora, IdMedioPago, IdEstadoVenta 
                                        FROM Venta WHERE Fecha = @Fecha AND Borrado = 0
                                        ORDER BY Hora DESC";

                using (SqlDataReader reader = SqlHelper.ExecuteReader(selectQuery,
                    CommandType.Text,
                    new SqlParameter[]
                    {
                        new SqlParameter("@Fecha", fecha.Date)
                    }))
                {
                    object[] values = new object[reader.FieldCount];

                    while (reader.Read())
                    {
                        reader.GetValues(values);
                        ventaGet = VentaAdapter.Current.Adapt(values);
                        ventas.Add(ventaGet);
                    }
                }
                return ventas;
            }
            catch (Exception ex)
            {
                ex.Handle();
                throw;
            }
        }

        public Venta GetById(Guid id)
        {
            try
            {
                Venta ventaGet = null;

                using (SqlDataReader reader = SqlHelper.ExecuteReader("SELECT IdVenta, EsDelivery, Fecha, Hora, IdMedioPago, IdEstadoVenta FROM Venta WHERE IdVenta = @IdVenta AND Borrado = 0",
                    CommandType.Text,
                    new SqlParameter[]
                    {
                        new SqlParameter("@IdVenta", id)
                    }))
                {
                    object[] values = new object[reader.FieldCount];

                    if (reader.Read())
                    {
                        reader.GetValues(values);
                        ventaGet = VentaAdapter.Current.Adapt(values);
                    }
                }
                return ventaGet;
            }
            catch (Exception ex)
            {
                ex.Handle();
                throw;
            }
        }

        public IEnumerable<Venta> GetByMedioPago(MedioPago medioPago)
        {
            try
            {
                Venta ventaGet = null;
                List<Venta> ventas = new List<Venta>();
                string selectQuery = @"SELECT IdVenta, EsDelivery, Fecha, Hora, IdMedioPago, IdEstadoVenta 
                                        FROM Venta WHERE IdMedioPago = @IdMedioPago AND Borrado = 0
                                        ORDER BY Fecha DESC, Hora DESC";

                using (SqlDataReader reader = SqlHelper.ExecuteReader(selectQuery,
                    CommandType.Text,
                    new SqlParameter[]
                    {
                        new SqlParameter("@IdMedioPago", (int)medioPago)
                    }))
                {
                    object[] values = new object[reader.FieldCount];

                    while (reader.Read())
                    {
                        reader.GetValues(values);
                        ventaGet = VentaAdapter.Current.Adapt(values);
                        ventas.Add(ventaGet);
                    }
                }
                return ventas;
            }
            catch (Exception ex)
            {
                ex.Handle();
                throw;
            }
        }

        public void Insert(Venta obj, UnitOfWork uow)
        {
            try
            {
                SqlHelper.ExecuteNonQuery("INSERT INTO Venta (IdVenta, EsDelivery, Fecha, Hora, IdMedioPago, IdEstadoVenta, Borrado, IdUsuario) VALUES (@IdVenta, @EsDelivery, @Fecha, @Hora, @IdMedioPago, @IdEstadoVenta, 0, @IdUsuario)",
                    CommandType.Text,
                    uow?.Transaction,
                    new SqlParameter[]
                    {
                        new SqlParameter("@IdVenta", obj.IdVenta),
                        new SqlParameter("@EsDelivery", Convert.ToInt32(obj.EsDelivery)),
                        new SqlParameter("@Fecha", obj.Fecha),
                        new SqlParameter("@Hora", obj.Hora),
                        new SqlParameter("@IdMedioPago", (int)obj.MedioDePago),
                        new SqlParameter("@IdEstadoVenta", (int)obj.EstadoVenta),
                        new SqlParameter("@IdUsuario", UsuarioLogueado.Current.Usuario.IdUsuario)
                    });
            }
            catch (Exception ex)
            {
                ex.Handle();
            }
        }

        public void Update(Venta obj, UnitOfWork uow)
        {
            try
            {
                SqlHelper.ExecuteNonQuery("UPDATE Venta SET EsDelivery = @EsDelivery, Fecha = @Fecha, Hora = @Hora, IdMedioPago = @IdMedioPago, IdEstadoVenta = @IdEstadoVenta WHERE IdVenta = @IdVenta AND Borrado = 0",
                    CommandType.Text,
                    uow?.Transaction,
                    new SqlParameter[]
                    {
                        new SqlParameter("@IdVenta", obj.IdVenta),
                        new SqlParameter("@EsDelivery", Convert.ToInt32(obj.EsDelivery)),
                        new SqlParameter("@Fecha", obj.Fecha),
                        new SqlParameter("@Hora", obj.Hora),
                        new SqlParameter("@IdMedioPago", (int)obj.MedioDePago),
                        new SqlParameter("@IdEstadoVenta", (int)obj.EstadoVenta)
                    });
            }
            catch (Exception ex)
            {
                ex.Handle();
            }
        }

        public IEnumerable<Venta> GetByEstado(EstadoVenta estadoVenta)
        {
            try
            {
                Venta ventaGet = null;
                List<Venta> ventas = new List<Venta>();
                string selectQuery = @"SELECT IdVenta, EsDelivery, Fecha, Hora, IdMedioPago, IdEstadoVenta 
                                        FROM Venta 
                                        WHERE IdEstadoVenta = @IdEstadoVenta AND Borrado = 0
                                        ORDER BY Fecha DESC, Hora DESC";

                using (SqlDataReader reader = SqlHelper.ExecuteReader(selectQuery,
                    CommandType.Text,
                    new SqlParameter[]
                    {
                        new SqlParameter("@IdEstadoVenta", (int)estadoVenta)
                    }))
                {
                    object[] values = new object[reader.FieldCount];

                    while (reader.Read())
                    {
                        reader.GetValues(values);
                        ventaGet = VentaAdapter.Current.Adapt(values);
                        ventas.Add(ventaGet);
                    }
                }
                return ventas;
            }
            catch (Exception ex)
            {
                ex.Handle();
                throw;
            }
        }

        public Venta GetVentaPendiente()
        {
            try
            {
                Venta ventaGet = null;

                string selectQuery = @"SELECT TOP 1 IdVenta, EsDelivery, Fecha, Hora, IdMedioPago, IdEstadoVenta
                                        FROM Venta 
                                        WHERE IdEstadoVenta IN (@IdEstadoEnCurso, @IdEstadoPendientePago) AND Borrado = 0 AND IdUsuario = @IdUsuario
                                        ORDER BY Fecha DESC, Hora DESC";

                using (SqlDataReader reader = SqlHelper.ExecuteReader(selectQuery,
                    CommandType.Text,
                    new SqlParameter[]
                    {
                        new SqlParameter("@IdEstadoEnCurso", (int)EstadoVenta.EnCurso),
                        new SqlParameter("@IdEstadoPendientePago", (int)EstadoVenta.PendienteDePago),
                        new SqlParameter("@IdUsuario", UsuarioLogueado.Current.Usuario.IdUsuario)
                    }))
                {
                    object[] values = new object[reader.FieldCount];

                    if (reader.Read())
                    {
                        reader.GetValues(values);
                        ventaGet = VentaAdapter.Current.Adapt(values);
                    }
                }
                return ventaGet;
            }
            catch (Exception ex)
            {
                ex.Handle();
                throw;
            }
        }

        public void CambiarEstado(Venta obj, EstadoVenta nuevoEstado, UnitOfWork uow = null)
        {
            try
            {
                SqlHelper.ExecuteNonQuery("UPDATE Venta SET IdEstadoVenta = @IdEstadoVenta WHERE IdVenta = @IdVenta AND Borrado = 0",
                    CommandType.Text,
                    uow?.Transaction,
                    new SqlParameter[]
                    {
                        new SqlParameter("@IdVenta", obj.IdVenta),
                        new SqlParameter("@IdEstadoVenta", (int)nuevoEstado)
                    });
            }
            catch(Exception ex)
            {
                ex.Handle();
            }
        }
    }
}
