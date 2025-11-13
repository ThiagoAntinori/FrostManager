using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Domain
{
    public class DetalleVenta
    {
        public Guid IdDetalleVenta { get; set; }
        public int Cantidad { get; set; }
        public decimal Subtotal { get => Producto.PrecioUnitario * Cantidad; }
        public Producto Producto { get; set; }
        public Guid IdVenta { get; set; }
        public List<SaborSeleccionado> SaboresSeleccionados { get; set; } = new List<SaborSeleccionado>();
    }
}
