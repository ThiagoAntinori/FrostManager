using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BLL.DTOs
{
    public class ReporteVentasDTO
    {
        public DateTime Fecha { get; set; }
        public decimal Total { get; set; }
        public string MedioPago { get; set; }
        public string Estado { get; set; }
    }
}
