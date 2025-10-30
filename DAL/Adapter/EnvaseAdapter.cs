using DAL.Contracts;
using Domain;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL.Adapter
{
    public class EnvaseAdapter : IAdapter<Envase>
    {

        private readonly static EnvaseAdapter _instance = new EnvaseAdapter();

        public static EnvaseAdapter Current
        {
            get
            {
                return _instance;
            }
        }

        private EnvaseAdapter()
        {
            // Implement here the initialization of your singleton
        }

        public Envase Adapt(object[] values)
        {
            return new Envase()
            {
                IdInsumo = Guid.Parse(values[0].ToString()),
                Descripcion = values[1].ToString(),
                StockActual = Convert.ToInt32(values[2].ToString()),
                StockMinimo = Convert.ToInt32(values[3].ToString()),
                CapacidadEnGramos = Convert.ToInt32(values[4])
            };
        }
    }
}
