using BLL.Contracts;
using BLL.Tools;
using DAL.Implementations.Factory;
using DAL.Implementations.SqlServer;
using Domain;
using Microsoft.EntityFrameworkCore.Internal;
using Services.BLL.Extensions;
using Services.Domain.Exceptions.BusinessExceptions;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BLL.Implementations
{
    public class PedidoService : IGenericService<Pedido>
    {

        private readonly static PedidoService _instance = new PedidoService();

        public static PedidoService Current
        {
            get
            {
                return _instance;
            }
        }

        private PedidoService()
        {
            // Implement here the initialization of your singleton
        }

        public void Add(Pedido item)
        {
            try
            {
                ValidationHelper.NotNull(item, nameof(item));
                ValidationHelper.NotEmptyGuid(item.IdPedido, nameof(item.IdPedido));
                ValidationHelper.NotNull(item.Cliente, nameof(item.Cliente));
                ValidationHelper.NotEmptyGuid(item.Cliente.IdCliente, nameof(item.Cliente.IdCliente));
                ValidationHelper.NotNull(item.Venta, nameof(item.Venta));
                ValidationHelper.NotEmptyGuid(item.Venta.IdVenta, nameof(item.Venta.IdVenta));
                ValidationHelper.NotNull(item.Repartidor, nameof(item.Repartidor));
                ValidationHelper.NotEmptyGuid(item.Repartidor.IdRepartidor, nameof(item.Repartidor.IdRepartidor));

                item.Estado = EstadoPedido.EnPreparacion;

                Repository.GetPedidoInstance().Insert(item);
                LoggerHelper.RegistrarAlta(item);
            }
            catch (Exception ex)
            {
                ex.Handle();
            }
        }

        public void Delete(Pedido item)
        {
            try
            {
                ValidationHelper.NotNull(item, nameof(item));
                ValidationHelper.NotEmptyGuid(item.IdPedido, nameof(item.IdPedido));

                Repository.GetPedidoInstance().Delete(item);
                LoggerHelper.RegistrarBaja(item);
            }
            catch (Exception ex)
            {
                ex.Handle();
            }
        }

        public IEnumerable<Pedido> SelectAll()
        {
            try
            {
                return Repository.GetPedidoInstance().GetAll();
            }
            catch (Exception ex)
            {
                ex.Handle();
                throw;
            }
        }

        public Pedido SelectOne(Guid id)
        {
            try
            {
                ValidationHelper.NotNull(id, nameof(id));

                return Repository.GetPedidoInstance().GetById(id);
            }
            catch(Exception ex)
            {
                ex.Handle();
                throw;
            }
        }

        public void Update(Pedido item)
        {
            try
            {
                ValidationHelper.NotNull(item, nameof(item));
                ValidationHelper.NotEmptyGuid(item.IdPedido, nameof(item.IdPedido));
                ValidationHelper.NotNull(item.Cliente, nameof(item.Cliente));
                ValidationHelper.NotEmptyGuid(item.Cliente.IdCliente, nameof(item.Cliente.IdCliente));
                ValidationHelper.NotNull(item.Venta, nameof(item.Venta));
                ValidationHelper.NotEmptyGuid(item.Venta.IdVenta, nameof(item.Venta.IdVenta));
                ValidationHelper.NotNull(item.Repartidor, nameof(item.Repartidor));
                ValidationHelper.NotEmptyGuid(item.Repartidor.IdRepartidor, nameof(item.Repartidor.IdRepartidor));

                Repository.GetPedidoInstance().Update(item);
                LoggerHelper.RegistrarModificacion(item);
            }
            catch(Exception ex)
            {
                ex.Handle();
            }
        }

        public void CambiarEstado(Pedido item, EstadoPedido nuevoEstado)
        {
            try
            {
                ValidationHelper.NotNull(item, nameof(item));
                ValidationHelper.NotEmptyGuid(item.IdPedido, nameof(item.IdPedido));
                ValidationHelper.NotNull(nuevoEstado, nameof(nuevoEstado));

                if (item.Estado == nuevoEstado)
                {
                    return;
                }
                if (item.Estado == EstadoPedido.Entregado || item.Estado == EstadoPedido.Cancelado)
                {
                    throw new Exception($"El pedido ya se encuentra en estado final ({item.Estado}). No es posible modificar.");
                }

                switch (item.Estado)
                {
                    case EstadoPedido.EnPreparacion:
                        if (nuevoEstado != EstadoPedido.EnCamino && nuevoEstado != EstadoPedido.Cancelado)
                        {
                            throw new TransicionEstadoInvalidaException("Pedido", item.Estado.ToString(), nuevoEstado.ToString());
                        }
                        break;

                    case EstadoPedido.EnCamino:
                        if (nuevoEstado != EstadoPedido.Entregado && nuevoEstado != EstadoPedido.Cancelado)
                        {
                            throw new TransicionEstadoInvalidaException("Pedido", item.Estado.ToString(), nuevoEstado.ToString());
                        }
                        break;
                }

                item.Estado = nuevoEstado;

                if (item.Estado == EstadoPedido.EnCamino)
                {
                    ValidationHelper.NotNull(item.Repartidor, nameof(item.Repartidor));
                    RepartidorService.Current.NotificarPedidoARepartidor(item);
                    item.HoraEnvio = DateTime.Now;
                }
                if (item.Estado == EstadoPedido.Entregado)
                {
                    item.HoraEntrega = DateTime.Now;
                    VentaService.Current.ConfirmarVenta(item.Venta);
                }
                else if (item.Estado == EstadoPedido.Cancelado)
                {
                    VentaService.Current.CambiarEstado(item.Venta, EstadoVenta.Cancelada);
                }

                Repository.GetPedidoInstance().Update(item);
                LoggerHelper.RegistrarModificacion(item);
            }
            catch(Exception ex)
            {
                ex.Handle();
            }
        }

        public void AsignarRepartidor(Pedido item, Repartidor repartidor)
        {
            try
            {
                ValidationHelper.NotNull(item, nameof(item));
                ValidationHelper.NotEmptyGuid(item.IdPedido, nameof(item.IdPedido));
                ValidationHelper.NotNull(repartidor, nameof(repartidor));
                ValidationHelper.NotEmptyGuid(repartidor.IdRepartidor, nameof(repartidor.IdRepartidor));

                item.Repartidor = repartidor;
                Repository.GetPedidoInstance().Update(item);
                LoggerHelper.RegistrarModificacion(item);
            }
            catch(Exception ex)
            {
                ex.Handle();
            }
        }

        public IEnumerable<Pedido> SelectByPeriodo(DateTime fechaInicio, DateTime fechaFin)
        {
            try
            {
                if (fechaInicio > fechaFin)
                {
                    throw new Exception("La fecha de inicio debe ser posterior a la de fin");
                }

                return Repository.GetPedidoInstance().GetByPeriodo(fechaInicio, fechaFin);
            }
            catch (Exception ex)
            {
                ex.Handle();
                throw;
            }
        }
    }
}
