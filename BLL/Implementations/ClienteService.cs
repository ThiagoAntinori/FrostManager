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
using System.Text.RegularExpressions;
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
                item.Telefono = NormalizarTelefono(item.Telefono);
                item.DNI = NormalizarDni(item.DNI);

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
                IEnumerable<Cliente> registros = Repository.GetClienteInstance().GetAll();
                if (!DigitoVerificadorService.Current.EsTablaConsistente<Cliente>(registros))
                {
                    DigitoVerificadorService.Current.HandleInconsistencia<Cliente>();
                }
                Repository.GetClienteInstance().Delete(item);
                LoggerHelper.RegistrarBaja(item);
            }
            catch(Exception ex)
            {
                ex.Handle();
            }
        }

        private string NormalizarTelefono(string telefonoIngresado)
        {
            string normalizado = Regex.Replace(telefonoIngresado, @"[^\d\+]", "");

            if (normalizado.Length < 7 || normalizado.Length > 15)
            {
                throw new DatosInvalidosException("Teléfono", "Debe tener entre 7 y 15 dígitos");
            }
            return normalizado;
        }

        private string NormalizarDni(string DniIngresado)
        {
            string normalizado = Regex.Replace(DniIngresado, @"[^\d]", "");
            if (normalizado.Length < 7 || normalizado.Length > 8)
            {
                throw new DatosInvalidosException("DNI", "Debe tener entre 7 y 8 dígitos");
            }
            return normalizado;
        }

        public IEnumerable<Cliente> SelectAll()
        {
            try
            {
                IEnumerable<Cliente> registros = Repository.GetClienteInstance().GetAll();
                if (!DigitoVerificadorService.Current.EsTablaConsistente<Cliente>(registros))
                {
                    DigitoVerificadorService.Current.HandleInconsistencia<Cliente>();
                }
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
                IEnumerable<Cliente> registros = Repository.GetClienteInstance().GetAll();
                if (!DigitoVerificadorService.Current.EsTablaConsistente<Cliente>(registros))
                {
                    DigitoVerificadorService.Current.HandleInconsistencia<Cliente>();
                }
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
                item.Telefono = NormalizarTelefono(item.Telefono);
                item.DNI = NormalizarDni(item.DNI);
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
                IEnumerable<Cliente> registros = Repository.GetClienteInstance().GetAll();
                if (!DigitoVerificadorService.Current.EsTablaConsistente<Cliente>(registros))
                {
                    DigitoVerificadorService.Current.HandleInconsistencia<Cliente>();
                }
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
