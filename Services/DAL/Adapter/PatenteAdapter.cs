using Services.DAL.Contracts;
using Services.Domain.Security;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Services.DAL.Adapter
{
    public class PatenteAdapter : IAdapter<Patente>
    {

        private readonly static PatenteAdapter _instance = new PatenteAdapter();

        public static PatenteAdapter Current
        {
            get
            {
                return _instance;
            }
        }

        private PatenteAdapter()
        {
            // Implement here the initialization of your singleton
        }

        public Patente Adapt(object[] values)
        {
            Patente patente = new Patente()
            {
                IdComponente = Guid.Parse(values[0].ToString()),
                Nombre = values[1].ToString(),
                MenuItemName = values[2].ToString(),
                FormName = values[3].ToString()
            };

            return patente;
        }
    }
}
