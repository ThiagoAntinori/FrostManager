using DAL.Contracts;
using DAL.Implementations.Factory;
using DAL.Implementations.SqlServer;
using Domain;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL.Adapter
{
    public class DetalleVentaAdapter : IAdapter<DetalleVenta>
    {

        private readonly static DetalleVentaAdapter _instance = new DetalleVentaAdapter();

        public static DetalleVentaAdapter Current
        {
            get
            {
                return _instance;
            }
        }

        private DetalleVentaAdapter()
        {
            // Implement here the initialization of your singleton
        }

        public DetalleVenta Adapt(object[] values)
        {
            DetalleVenta detalleVenta = new DetalleVenta()
            {
                IdDetalleVenta = Guid.Parse(values[0].ToString()),
                Cantidad = Convert.ToInt32(values[1].ToString()),
                Producto = Repository.GetProductoInstance().GetById(Guid.Parse(values[2].ToString())),
                IdVenta = Guid.Parse(values[3].ToString()),
            };

            detalleVenta.SaboresSeleccionados = Repository.GetSaborSeleccionadoInstance().GetByIdDetalleVenta(detalleVenta.IdDetalleVenta);
            return detalleVenta;
        }
    }
}
