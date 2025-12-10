using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BLL.DTOs
{
    public class ReporteVentasContenedorDTO
    {
        public List<ReporteVentasDTO> Detalles { get; set; }
        public decimal TotalRecaudado { get; set; }
        public decimal PromedioDiario { get; set; }
    }
}
