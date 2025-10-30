using DAL.Contracts;
using Domain;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL.Adapter
{
    public class SaborAdapter : IAdapter<Sabor>
    {

        private readonly static SaborAdapter _instance = new SaborAdapter();

        public static SaborAdapter Current
        {
            get
            {
                return _instance;
            }
        }

        private SaborAdapter()
        {
            // Implement here the initialization of your singleton
        }

        public Sabor Adapt(object[] values)
        {
            return new Sabor()
            {
                IdInsumo = Guid.Parse(values[0].ToString()),
                Descripcion = values[1].ToString(),
                StockActual = Convert.ToInt32(values[2].ToString()),
                StockMinimo = Convert.ToInt32(values[3].ToString())
            };
        }
    }
}
