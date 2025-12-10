using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BLL.DTOs
{
    public class ReporteCajaDTO
    {
        public string NombreMedioPago { get; set; }
        public decimal TotalRecaudado { get; set; }
        public int CantidadDeVentas { get; set; }
    }
}
