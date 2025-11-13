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
        public DateTime Fecha { get; set; }
        public DateTime Hora { get; set; }
        public MedioPago MedioDePago { get; set; }
        public EstadoVenta EstadoVenta { get; set; }
        public List<DetalleVenta> Detalles { get; private set; } = new List<DetalleVenta>();

        public void AgregarDetalle(DetalleVenta nuevoDetalle)
        {
            Detalles.Add(nuevoDetalle);
        }

        public void RemoverDetalle(DetalleVenta detalleARemover)
        {
            Detalles.Remove(detalleARemover);
        }

        public decimal CalcularTotal()
        {
            decimal total = 0;
            foreach(DetalleVenta detalle in Detalles)
            {
                total += (detalle.Cantidad * detalle.Producto.PrecioUnitario);
            }
            return total;
        }
    }
}
