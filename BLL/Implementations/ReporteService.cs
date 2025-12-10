using BLL.DTOs;
using Domain;
using Services.BLL.Extensions;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BLL.Implementations
{
    public class ReporteService
    {

        private readonly static ReporteService _instance = new ReporteService();

        public static ReporteService Current
        {
            get
            {
                return _instance;
            }
        }

        private ReporteService()
        {
            // Implement here the initialization of your singleton
        }

        public List<ReporteVentasDTO> GenerarDetallesReporteVentas(DateTime fechaInicio, DateTime fechaFin)
        {
            try
            {
                DateTime limiteSuperior = fechaFin.AddDays(1).AddSeconds(-1);

                List<Venta> ventasEnPeriodo = (List<Venta>)VentaService.Current.SelectByPeriodo(fechaInicio, fechaFin);
                List<Venta> ventasFinalizadas = ventasEnPeriodo.Where(v => v.EstadoVenta != EstadoVenta.EnCurso).ToList();

                if(ventasFinalizadas == null || !ventasFinalizadas.Any())
                {
                    throw new Exception("No se encontraron ventas cerradas en el período asignado");
                }
                List<ReporteVentasDTO> reporte = ventasFinalizadas
                                                .Select(v => new ReporteVentasDTO()
                                                {
                                                    Fecha = v.Fecha.AddHours(v.Hora.Hour).AddMinutes(v.Hora.Minute),
                                                    MedioPago = v.MedioDePago.ToString(),
                                                    Estado = v.EstadoVenta.ToString(),
                                                    Total = v.CalcularTotal()
                                                })
                                                .ToList();

                return reporte;
            }
            catch (Exception ex)
            {
                ex.Handle();
                throw;
            }
        }

        public ReporteVentasContenedorDTO GenerarReporteVentas(DateTime fechaInicio, DateTime fechaFin)
        {
            try
            {
                List<ReporteVentasDTO> detalles = GenerarDetallesReporteVentas(fechaInicio, fechaFin);

                decimal total = detalles.Sum(d => d.Total);
                int cantidadDias = (int)(fechaFin.Date - fechaInicio.Date).TotalDays + 1;
                decimal promedio = (cantidadDias > 0) ? total / cantidadDias : 0;

                return new ReporteVentasContenedorDTO()
                {
                    Detalles = detalles,
                    TotalRecaudado = total,
                    PromedioDiario = promedio
                };
            }
            catch (Exception ex)
            {
                ex.Handle();
                throw;
            }
        }

        public List<ReporteCajaDTO> GenerarReporteDeCajaDiaria(DateTime fecha)
        {
            try
            {
                List<Venta> ventasDelDia = (List<Venta>)VentaService.Current.SelectByFecha(fecha);
                List<Venta> ventasFinalizadas = ventasDelDia
                    .Where(v => v.EstadoVenta == EstadoVenta.Finalizada).ToList();

                if (ventasFinalizadas == null || !ventasFinalizadas.Any())
                {
                    throw new Exception("No se encontraron ventas finalizadas en el período asignado");
                }

                List<ReporteCajaDTO> datosAgrupados = ventasFinalizadas
                    .GroupBy(v => v.MedioDePago)
                    .Select(grupo => new ReporteCajaDTO()
                    {
                        NombreMedioPago = grupo.Key.ToString(),
                        TotalRecaudado = grupo.Sum(v => v.CalcularTotal()),
                        CantidadDeVentas = grupo.Count()
                    })
                    .OrderByDescending(dto => dto.TotalRecaudado)
                    .ToList();

                return datosAgrupados;
            }
            catch (Exception ex)
            {
                ex.Handle();
                throw;
            }
        }

        public List<ReporteSaboresDTO> GenerarReporteDeSaboresMasVendidos(DateTime fechaInicio, DateTime fechaFin)
        {
            try
            {
                List<Venta> ventasEnPeriodo = (List<Venta>)VentaService.Current.SelectByPeriodo(fechaInicio, fechaFin);
                List<Venta> ventasFinalizadas = ventasEnPeriodo.Where(v => v.EstadoVenta == EstadoVenta.Finalizada).ToList();

                if (ventasFinalizadas == null && !ventasFinalizadas.Any())
                {
                    throw new Exception("No se encontraron ventas finalizadas en el período asignado");
                }

                List<ReporteSaboresDTO> reporte = ventasEnPeriodo
                    .SelectMany(v => v.Detalles)
                    .SelectMany(d => d.SaboresSeleccionados)
                    .GroupBy(ss => ss.Sabor.IdInsumo)
                    .Select(grupo => new ReporteSaboresDTO()
                    {
                        Puesto = 0,
                        NombreSabor = grupo.First().Sabor.Descripcion,
                        CantidadDeVecesVendido = grupo.Count(),
                        CantidadVendidaEnGramos = grupo.Sum(ss => ss.CantidadEnGramos)
                    })
                    .OrderByDescending(dto => dto.CantidadVendidaEnGramos)
                    .ThenByDescending(dto => dto.CantidadDeVecesVendido)
                    .ToList();

                int puesto = 1;
                foreach(ReporteSaboresDTO dto in reporte)
                {
                    dto.Puesto = puesto++;
                }

                return reporte;
            }
            catch(Exception ex)
            {
                ex.Handle();
                throw;
            }
        }

        public List<ReportePedidosDTO> GenerarReporteDeEntregas(DateTime fechaInicio, DateTime fechaFin)
        {
            try
            {
                List<Pedido> pedidosEnPeriodo = (List<Pedido>)PedidoService.Current.SelectByPeriodo(fechaInicio, fechaFin);

                List<ReportePedidosDTO> reporte = pedidosEnPeriodo.Select(p => new ReportePedidosDTO()
                {
                    FechaPedido = p.Venta.Fecha.Date,
                    Estado = p.Estado.ToString(),
                    NombreCliente = p.Cliente.ToString(),
                    NombreRepartidor = p.Repartidor.ToString(),
                    TiempoEntrega = CalcularTiempoEntrega(p.HoraEnvio, p.HoraEntrega, p.Estado),
                    MontoTotal = p.Venta.CalcularTotal()
                }).ToList();

                return reporte;
            }
            catch (Exception ex)
            {
                ex.Handle();
                throw;
            }
        }

        private string CalcularTiempoEntrega(DateTime? horaEnvio, DateTime? horaEntrega, EstadoPedido estado)
        {
            try
            {
                if(estado == EstadoPedido.Cancelado)
                {
                    return "Cancelado";
                }

                if (!horaEnvio.HasValue)
                {
                    return estado.ToString();
                }
                if (!horaEntrega.HasValue)
                {
                    TimeSpan transcurrido = DateTime.Now - horaEnvio.Value;
                    return $"En curso ({Math.Floor(transcurrido.TotalMinutes)} min)";
                }

                TimeSpan tiempoEntrega = horaEntrega.Value - horaEnvio.Value;

                if(tiempoEntrega.Hours >= 1)
                {
                    return $"{tiempoEntrega.Hours}hs {tiempoEntrega.Minutes}min";
                }

                return $"{Math.Ceiling(tiempoEntrega.TotalMinutes)}min";
            }
            catch(Exception ex)
            {
                throw;
            }
        }
    }
}
