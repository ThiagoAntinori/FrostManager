using BLL.Contracts;
using BLL.Tools;
using DAL.Implementations.Factory;
using Domain;
using Microsoft.EntityFrameworkCore.Internal;
using Services.BLL.Extensions;
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
                item.HoraEnvio = DateTime.Now;
                item.HoraEntrega = DateTime.Now;

                Repository.GetPedidoInstance().Insert(item);
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

                item.Estado = nuevoEstado;
                if(nuevoEstado == EstadoPedido.EnCamino)
                {
                    item.HoraEnvio = DateTime.Now;
                }
                else if(nuevoEstado == EstadoPedido.Entregado)
                {
                    item.HoraEntrega = DateTime.Now;
                }

                Repository.GetPedidoInstance().Update(item);
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
            }
            catch(Exception ex)
            {
                ex.Handle();
            }
        }
    }
}
