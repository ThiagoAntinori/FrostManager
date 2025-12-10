using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Domain
{
    public class Pedido
    {
        public Guid IdPedido { get; set; }
        public DateTime? HoraEnvio { get; set; }
        public DateTime? HoraEntrega { get; set; }
        public Venta Venta { get; set; }
        public EstadoPedido Estado { get; set; }
        public Cliente Cliente { get; set; }
        public Repartidor Repartidor { get; set; }
    }
}
