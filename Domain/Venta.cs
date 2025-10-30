using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Domain
{
    public class Venta
    {
        public Guid IdVenta { get; set; }
        public bool EsDelivery { get; set; }
        public DateOnly Fecha { get; set; }
        public TimeOnly Hora { get; set; }
        public MedioPago MedioDePago { get; set; }
        public EstadoVenta EstadoVenta { get; set; }
        public List<DetalleVenta> Detalles { get; set; }
    }
}
