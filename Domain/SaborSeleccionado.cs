using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Domain
{
    public class SaborSeleccionado
    {
        public Sabor Sabor { get; set; }
        public int CantidadEnGramos { get; set; }
        public Guid IdDetalleVenta { get; set; }
    }
}
