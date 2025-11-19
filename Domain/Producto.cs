using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Domain
{
    public class Producto
    {
        public Guid IdProducto { get; set; }
        public string Descripcion { get; set; }
        public int CapacidadEnGramos { get; set; }
        public decimal PrecioUnitario { get; set; }
        public Envase EnvaseNecesario { get; set; }
        public override string ToString() => Descripcion;
    }
}
