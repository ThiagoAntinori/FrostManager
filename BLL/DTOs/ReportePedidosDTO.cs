using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BLL.DTOs
{
    public class ReportePedidosDTO
    {
        public DateTime FechaPedido { get; set; }
        public string Estado { get; set; }
        public string NombreCliente { get; set; }
        public string NombreRepartidor { get; set; }
        public string TiempoEntrega { get; set; }
        public decimal MontoTotal { get; set; }
    }
}
