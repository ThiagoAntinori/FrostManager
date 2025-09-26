using BLL.Contracts;
using DAL.Implementations;
using Domain;
using Services.BLL.Extensions;
using Services.BLL.Services;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace BLL.Implementations
{
    public class ClienteService : IGenericService<Cliente>
    {

        private readonly static ClienteService _instance = new ClienteService();

        public static ClienteService Current
        {
            get
            {
                return _instance;
            }
        }

        private ClienteService()
        {
            // Implement here the initialization of your singleton
        }

        public void Add(Cliente item)
        {
            try
            {
                if(item == null)
                {
                    throw new ArgumentNullException(nameof(item));
                }
                if (string.IsNullOrEmpty(item.Nombre))
                {
                    throw new Exception("El cliente debe tener un nombre");
                }
                if (string.IsNullOrEmpty(item.Apellido))
                {
                    throw new Exception("El cliente debe tener un apellido");
                }
                if (string.IsNullOrEmpty(item.Telefono))
                {
                    throw new Exception("El cliente debe tener un teléfono");
                }
                if (string.IsNullOrEmpty(item.Direccion))
                {
                    throw new Exception("El cliente debe tener una dirección");
                }
                if (this.ExisteCliente(item.DNI))
                {
                    throw new Exception("Ya existe un cliente con el mismo DNI");
                }
                item.DVH = DigitoVerificadorService.Current.CalcularDigitoVerificadorHorizontal(item);
                ClienteRepository.Current.Insert(item);
            }
            catch(Exception ex)
            {
                ExceptionExtension.Handle(ex);
            }
        }

        public void Delete(Cliente item)
        {
            throw new NotImplementedException();
        }

        public IEnumerable<Cliente> SelectAll()
        {
            throw new NotImplementedException();
        }

        public Cliente SelectOne(Guid id)
        {
            throw new NotImplementedException();
        }

        public void Update(Cliente item)
        {
            throw new NotImplementedException();
        }

        public bool ExisteCliente(string DNI)
        {
            try
            {
                return ClienteRepository.Current.ExisteCliente(DNI);
            }
            catch (Exception ex)
            {
                ExceptionExtension.Handle(ex);
                throw;
            }
        }
    }
}
