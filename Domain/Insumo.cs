using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Domain
{
    public abstract class Insumo
    {
        public int StockActual { get; set; }
        public int StockMinimo { get; set; }
    }
}
