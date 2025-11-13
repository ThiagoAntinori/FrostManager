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
    public class VentaAdapter : IAdapter<Venta>
    {

        private readonly static VentaAdapter _instance = new VentaAdapter();

        public static VentaAdapter Current
        {
            get
            {
                return _instance;
            }
        }

        private VentaAdapter()
        {
            // Implement here the initialization of your singleton
        }

        public Venta Adapt(object[] values)
        {
            Venta venta = new Venta()
            {
                IdVenta = Guid.Parse(values[0].ToString()),
                EsDelivery = Convert.ToBoolean(values[1].ToString()),
                Fecha = DateTime.Parse(values[2].ToString()),
                Hora = DateTime.Parse(values[3].ToString()),
                MedioDePago = Enum.GetValues(typeof(MedioPago)).Cast<MedioPago>().ToList()[Convert.ToInt32(values[4].ToString()) - 1],
                EstadoVenta = Enum.GetValues(typeof(EstadoVenta)).Cast<EstadoVenta>().ToList()[Convert.ToInt32(values[5].ToString()) - 1],
            };

            List<DetalleVenta> detalles = Repository.GetDetalleVentaInstance().GetByIdVenta(venta.IdVenta);

            foreach(var d in detalles)
            {
                venta.AgregarDetalle(d);
            }

            return venta;
        }
    }
}
