using Services.DAL.Contracts;
using Services.DAL.Implementations;
using Services.Domain.Security;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Services.DAL.Adapter
{
    public class FamiliaAdapter : IAdapter<Familia>
    {

        private readonly static FamiliaAdapter _instance = new FamiliaAdapter();

        public static FamiliaAdapter Current
        {
            get
            {
                return _instance;
            }
        }

        private FamiliaAdapter()
        {
            // Implement here the initialization of your singleton
        }

        public Familia Adapt(object[] values)
        {
            Familia familia = new Familia()
            {
                IdComponente = Guid.Parse(values[0].ToString()),
                Nombre = values[1].ToString()
            };

            FamiliaFamiliaRepository.Current.GetChildren(familia);
            FamiliaPatenteRepository.Current.GetChildren(familia);

            return familia;
        }
    }
}
