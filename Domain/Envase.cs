using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Domain
{
    public class Envase : Insumo
    {
        public int CapacidadEnGramos { get; set; }
        public override string ToString() => Descripcion;
    }
}
