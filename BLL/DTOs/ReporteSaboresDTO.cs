using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BLL.DTOs
{
    public class ReporteSaboresDTO
    {
        public int Puesto { get; set; }
        public string NombreSabor { get; set; }
        public int CantidadDeVecesVendido { get; set; }
        public int CantidadVendidaEnGramos { get; set; }
    }
}
