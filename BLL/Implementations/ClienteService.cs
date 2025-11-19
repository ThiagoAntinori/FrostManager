using BLL.Contracts;
using BLL.Tools;
using DAL.Implementations.Factory;
using DAL.Implementations.SqlServer;
using Domain;
using Services.BLL.Extensions;
using Services.BLL.Services;
using Services.Domain.Exceptions.BusinessExceptions;
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
                ValidationHelper.NotNull(item, nameof(item));
                ValidationHelper.NotEmpty(item.Nombre, nameof(item.Nombre));
                ValidationHelper.NotEmpty(item.Apellido, nameof(item.Apellido));
                ValidationHelper.NotEmpty(item.Telefono, nameof(item.Telefono));
                ValidationHelper.NotEmpty(item.Direccion, nameof(item.DNI));

                if (item.Telefono.Length != 10)
                {
                    throw new Exception("El telefono debe tener 10 dígitos");
                }

                if(item.DNI.Length < 7 || item.DNI.Length > 8)
                {
                    throw new Exception("El DNI debe tener entre 7 y 8 caracteres");
                }

                if (this.ExisteCliente(item.DNI))
                {
                    throw new ClienteExistenteException();
                }

                item.DVH = DigitoVerificadorService.Current.CalcularDigitoVerificadorHorizontal(item);

                Repository.GetClienteInstance().Insert(item, null);
                LoggerHelper.RegistrarAlta(item);
            }

            catch(Exception ex)
            {
                ex.Handle();
            }
        }

        public void Delete(Cliente item)
        {
            try
            {
                ValidationHelper.NotNull(item, nameof(item));
                ValidationHelper.NotEmptyGuid(item.IdCliente, nameof(item.IdCliente));

                Repository.GetClienteInstance().Delete(item);
                LoggerHelper.RegistrarBaja(item);
            }
            catch(Exception ex)
            {
                ex.Handle();
            }
        }

        public IEnumerable<Cliente> SelectAll()
        {
            try
            {
                return Repository.GetClienteInstance().GetAll();
            }
            catch (Exception ex)
            {
                ex.Handle();
                throw;
            }
        }

        public Cliente SelectOne(Guid id)
        {
            try
            {
                ValidationHelper.NotEmptyGuid(id, "ID");
                return Repository.GetClienteInstance().GetById(id);
            }
            catch (Exception ex)
            {
                ex.Handle();
                throw;
            }
        }

        public void Update(Cliente item)
        {
            try
            {
                ValidationHelper.NotNull(item, nameof(item));
                ValidationHelper.NotEmptyGuid(item.IdCliente, nameof(item.IdCliente));
                ValidationHelper.NotEmpty(item.Nombre, nameof(item.Nombre));
                ValidationHelper.NotEmpty(item.Apellido, nameof(item.Apellido));
                ValidationHelper.NotEmpty(item.Telefono, nameof(item.Telefono));
                ValidationHelper.NotEmpty(item.Direccion, nameof(item.Direccion));

                if (item.Telefono.Length != 10)
                {
                    throw new Exception("El telefono debe tener 10 dígitos");
                }
                if (item.DNI.Length < 7 || item.DNI.Length > 8)
                {
                    throw new Exception("El DNI debe tener entre 7 y 8 caracteres");
                }
                if (this.SelectOne(item.IdCliente) == null)
                {
                    throw new Exception("No fue posible encontrar al cliente");
                }
                item.DVH = DigitoVerificadorService.Current.CalcularDigitoVerificadorHorizontal(item);
                Repository.GetClienteInstance().Update(item);
                LoggerHelper.RegistrarModificacion(item);
            }
            catch (Exception ex)
            {
                ex.Handle();
            }
        }

        public bool ExisteCliente(string dni)
        {
            try
            {
                ValidationHelper.NotEmpty(dni, "DNI");
                return Repository.GetClienteInstance().ExisteCliente(dni);
            }
            catch (Exception ex)
            {
                ex.Handle();
                throw;
            }
        }

        public Cliente SelectByDNI(string DNI)
        {

            try
            {
                ValidationHelper.NotEmpty(DNI, "DNI");
                return Repository.GetClienteInstance().GetByDNI(DNI);
            }
            catch (Exception ex)
            {
                ex.Handle();
                throw;
            }
        }
    }
}
