using DAL.Contracts;
using Domain;
using Services.BLL.Services;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL.Adapter
{
    public class ClienteAdapter : IAdapter<Cliente>
    {

        private readonly static ClienteAdapter _instance = new ClienteAdapter();

        public static ClienteAdapter Current
        {
            get
            {
                return _instance;
            }
        }

        private ClienteAdapter()
        {
            // Implement here the initialization of your singleton
        }

        public Cliente Adapt(object[] values)
        {
            return new Cliente
            {
                IdCliente = Guid.Parse(values[0].ToString()),
                Nombre = values[1].ToString(),
                Apellido = values[2].ToString(),
                DNI = values[3].ToString(),
                Telefono = CriptographyService.Decrypt(values[4].ToString()),
                Direccion = CriptographyService.Decrypt(values[5].ToString()),
                DVH = values[6].ToString()
            };
        }
    }
}
