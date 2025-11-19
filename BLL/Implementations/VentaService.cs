using BLL.Contracts;
using BLL.Tools;
using DAL.Implementations.Factory;
using DAL.Implementations.SqlServer;
using Domain;
using Microsoft.EntityFrameworkCore.Internal;
using Services.BLL.Extensions;
using Services.Domain.Exceptions;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Schema;

namespace BLL.Implementations
{
    public class VentaService : IGenericService<Venta>
    {

        private readonly static VentaService _instance = new VentaService();

        public static VentaService Current
        {
            get
            {
                return _instance;
            }
        }

        private VentaService()
        {
            // Implement here the initialization of your singleton
        }

        public void Add(Venta item)
        {
            try
            {
                ValidationHelper.NotNull(item, nameof(item));
                ValidationHelper.NotEmptyGuid(item.IdVenta, nameof(item.IdVenta));
                item.Fecha = DateTime.Now;
                item.Hora = DateTime.Now;
                item.EstadoVenta = EstadoVenta.EnCurso;
                item.MedioDePago = MedioPago.NoAsignado;
                item.EsDelivery = false;
                Repository.GetVentaInstance().Insert(item);
                LoggerHelper.RegistrarGenerico("INICIO", item);
            }
            catch (Exception ex)
            {
                ex.Handle();
            }
        }

        public void Delete(Venta item)
        {
            try
            {
                ValidationHelper.NotNull(item, nameof(item));
                ValidationHelper.NotEmptyGuid(item.IdVenta, nameof(item.IdVenta));

                using(UnitOfWork uow = new UnitOfWork())
                {
                    try
                    {
                        Repository.GetVentaInstance().Delete(item, uow);
                        List<DetalleVenta> detallesDeVenta = Repository.GetDetalleVentaInstance().GetByIdVenta(item.IdVenta);
                        foreach (DetalleVenta detalle in detallesDeVenta)
                        {
                            List<SaborSeleccionado> saboresSeleccionados = Repository.GetSaborSeleccionadoInstance().GetByIdDetalleVenta(detalle.IdDetalleVenta);
                            foreach (SaborSeleccionado ss in saboresSeleccionados)
                            {
                                Repository.GetSaborSeleccionadoInstance().Delete(ss, uow);
                            }
                            Repository.GetDetalleVentaInstance().Delete(detalle, uow);
                        }
                        uow.Commit();
                        LoggerHelper.RegistrarGenerico("CANCELACIÓN", item);
                    }
                    catch(Exception ex)
                    {
                        uow.Rollback();
                        throw;
                    }
                }
            }
            catch (Exception ex)
            {
                ex.Handle();
            }
        }

        public IEnumerable<Venta> SelectAll()
        {
            try
            {
                return Repository.GetVentaInstance().GetAll();
            }
            catch (Exception ex)
            {
                ex.Handle();
                throw;
            }
        }

        public Venta SelectOne(Guid id)
        {
            try
            {
                ValidationHelper.NotEmptyGuid(id, nameof(id));
                return Repository.GetVentaInstance().GetById(id);
            }
            catch (Exception ex)
            {
                ex.Handle();
                throw;
            }
        }

        public void Update(Venta item)
        {
            try
            {
                ValidationHelper.NotNull(item, nameof(item));
                ValidationHelper.NotEmptyGuid(item.IdVenta, nameof(item.IdVenta));
                ValidationHelper.NotNull(item.EsDelivery, nameof(item.EsDelivery));
                ValidationHelper.NotNull(item.MedioDePago, nameof(item.MedioDePago));
                if (item.Detalles == null || !item.Detalles.Any())
                    throw new ArgumentException("La venta debe contener al menos un producto.");
                ValidationHelper.NotNull(item.EstadoVenta, nameof(item.EstadoVenta));

                Repository.GetVentaInstance().Update(item);
            }
            catch (Exception ex)
            {
                ex.Handle();
            }
        }

        public IEnumerable<Venta> SelectByPeriodo(DateTime fechaInicio, DateTime fechaFin)
        {
            try
            {
                if(fechaInicio > fechaFin)
                {
                    throw new Exception("La fecha de inicio debe ser posterior a la de fin");
                }
                return Repository.GetVentaInstance().GetByPeriodo(fechaInicio, fechaFin);
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
                ValidationHelper.NotNull(fecha, nameof(fecha));

                return Repository.GetVentaInstance().GetByFecha(fecha);
            }
            catch (Exception ex)
            {
                ex.Handle();
                throw;
            }
        }

        public IEnumerable<Venta> SelectByMedioPago(MedioPago medioPago)
        {
            try
            {
                ValidationHelper.NotNull(medioPago, nameof(medioPago));

                return Repository.GetVentaInstance().GetByMedioPago(medioPago);
            }
            catch (Exception ex)
            {
                ex.Handle();
                throw;
            }
        }

        public void ConfirmarVenta(Venta item)
        {
            try
            {
                ValidationHelper.NotNull(item, nameof(item));
                ValidationHelper.NotEmptyGuid(item.IdVenta, nameof(item.IdVenta));
                if (item.Detalles == null || !item.Detalles.Any())
                    throw new ArgumentException("La venta debe contener al menos un producto.");
                Dictionary<Guid, int> insumosRequeridos = new Dictionary<Guid, int>();
                foreach (DetalleVenta detalle in item.Detalles)
                {
                    if (detalle.SaboresSeleccionados == null || !detalle.SaboresSeleccionados.Any())
                        throw new ArgumentException("El detalle debe contener al menos un sabor");
                    Guid idEnvase = detalle.Producto.EnvaseNecesario.IdInsumo;
                    insumosRequeridos.TryAdd(idEnvase, 0);
                    insumosRequeridos[idEnvase] += detalle.Cantidad;

                    int capacidad = detalle.Producto.CapacidadEnGramos;
                    int cantidadSabores = detalle.SaboresSeleccionados.Count;
                    int gramosPorSaborPorUnidad = capacidad / cantidadSabores;
                    int totalPorSabor = gramosPorSaborPorUnidad * detalle.Cantidad;


                    foreach (var s in detalle.SaboresSeleccionados)
                    {
                        insumosRequeridos.TryAdd(s.Sabor.IdInsumo, 0);
                        insumosRequeridos[s.Sabor.IdInsumo] += totalPorSabor;
                        s.CantidadEnGramos = gramosPorSaborPorUnidad;
                    }
                }

                using (UnitOfWork uow = new UnitOfWork())
                {
                    try
                    {
                        foreach (var kv in insumosRequeridos)
                        {
                            Guid idInsumo = kv.Key;
                            int cantidad = kv.Value;
                            if(!Repository.GetInsumoInstance().RestarStock(idInsumo, cantidad, uow))
                            {
                                throw new Exception($"No hay stock suficiente para realizar la venta (Insumo: {InsumoService.Current.SelectOne(idInsumo).Descripcion})");
                            }
                        }
                        Repository.GetVentaInstance().Update(item, uow);
                        foreach (var detalle in item.Detalles)
                        {
                            foreach (var saborSeleccionado in detalle.SaboresSeleccionados)
                            {
                                Repository.GetSaborSeleccionadoInstance().Update(saborSeleccionado, uow);
                            }
                        }
                        uow.Commit();
                        LoggerHelper.RegistrarGenerico("CONFIRMACIÓN", item);
                    }
                    catch (Exception ex)
                    {
                        uow.Rollback();
                        throw;
                    }
                }
            }
            catch (Exception ex)
            {
                ex.Handle();
            }
        }

        public Venta SelectVentaEnCurso()
        {
            try
            {
                Venta ventaEnCurso = Repository.GetVentaInstance().GetVentaEnCurso();

                return ventaEnCurso;
            }
            catch (Exception ex)
            {
                ex.Handle();
                throw;
            }
        }

        public void AsignarMedioPago(Venta item, MedioPago medioDePago)
        {
            try
            {
                item.MedioDePago = medioDePago;
                Repository.GetVentaInstance().Update(item);
                LoggerHelper.RegistrarGenerico("COBRO", item);
            }
            catch(Exception ex)
            {
                ex.Handle();
            }
        }
    }
}
