using DAL.Contracts;
using Domain;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL.Adapter
{
    public class RepartidorAdapter : IAdapter<Repartidor>
    {

        private readonly static RepartidorAdapter _instance = new RepartidorAdapter();

        public static RepartidorAdapter Current
        {
            get
            {
                return _instance;
            }
        }

        private RepartidorAdapter()
        {
            // Implement here the initialization of your singleton
        }

        public Repartidor Adapt(object[] values)
        {
            return new Repartidor()
            {
                IdRepartidor = Guid.Parse(values[0].ToString()),
                Nombre = values[1].ToString(),
                Apellido = values[2].ToString(),
                Telefono = values[3].ToString(),
            };
        }
    }
}
