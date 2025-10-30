using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Domain
{
    public class MovimientoStock
    {
        public Guid IdMovimientoStock { get; set; }
        public Insumo Insumo { get; set; }
        public int Cantidad { get; set; }
        public DateTime FechaHora { get; set; }
        public TipoMovimientoStock TipoMovimiento { get; set; }
        public string Motivo { get; set; }
    }
}
