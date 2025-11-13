using DAL.Contracts;
using DAL.Implementations.Factory;
using Domain;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL.Adapter
{
    public class PedidoAdapter : IAdapter<Pedido>
    {

        private readonly static PedidoAdapter _instance = new PedidoAdapter();

        public static PedidoAdapter Current
        {
            get
            {
                return _instance;
            }
        }

        private PedidoAdapter()
        {
            // Implement here the initialization of your singleton
        }

        public Pedido Adapt(object[] values)
        {
            Pedido pedidoAdaptado = new Pedido()
            {
                IdPedido = Guid.Parse(values[0].ToString()),
                HoraEnvio = DateTime.Parse(values[1].ToString()),
                HoraEntrega = DateTime.Parse(values[2].ToString()),
                Estado = Enum.GetValues(typeof(EstadoPedido)).Cast<EstadoPedido>().ToList()[Convert.ToInt32(values[3].ToString())]
            };
            pedidoAdaptado.Venta = Repository.GetVentaInstance().GetById(Guid.Parse(values[4].ToString()));
            pedidoAdaptado.Cliente = Repository.GetClienteInstance().GetById(Guid.Parse(values[5].ToString()));
            pedidoAdaptado.Repartidor = Repository.GetRepartidorInstance().GetById(Guid.Parse(values[6].ToString()));

            return pedidoAdaptado;
        }

    }
}
