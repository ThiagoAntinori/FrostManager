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
    public class SaborSeleccionadoAdapter : IAdapter<SaborSeleccionado>
    {

        private readonly static SaborSeleccionadoAdapter _instance = new SaborSeleccionadoAdapter();

        public static SaborSeleccionadoAdapter Current
        {
            get
            {
                return _instance;
            }
        }

        private SaborSeleccionadoAdapter()
        {
            // Implement here the initialization of your singleton
        }

        public SaborSeleccionado Adapt(object[] values)
        {
            return new SaborSeleccionado()
            {
                Sabor = Repository.GetSaborInstance().GetById(Guid.Parse(values[0].ToString())),
                CantidadEnGramos = Convert.ToInt32(values[1].ToString()),
                IdDetalleVenta = Guid.Parse(values[2].ToString())
            };
        }

    }
}
