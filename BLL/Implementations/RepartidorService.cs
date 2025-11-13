using BLL.Contracts;
using BLL.Tools;
using DAL.Implementations.Factory;
using DAL.Implementations.SqlServer;
using Domain;
using Services.BLL.Extensions;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BLL.Implementations
{
    public class RepartidorService : IGenericService<Repartidor>
    {

        private readonly static RepartidorService _instance = new RepartidorService();

        public static RepartidorService Current
        {
            get
            {
                return _instance;
            }
        }

        private RepartidorService()
        {
            // Implement here the initialization of your singleton
        }

        public void Add(Repartidor item)
        {
            try
            {
                ValidationHelper.NotNull(item, nameof(item));
                ValidationHelper.NotEmptyGuid(item.IdRepartidor, nameof(item.IdRepartidor));
                ValidationHelper.NotEmpty(item.Nombre, nameof(item.Nombre));
                ValidationHelper.NotEmpty(item.Apellido, nameof(item.Apellido));
                ValidationHelper.NotEmpty(item.Telefono, nameof(item.Telefono));
                if(item.Telefono.Length != 10)
                {
                    throw new Exception("El telefono debe tener al menos 10 dígitos");
                }

                Repository.GetRepartidorInstance().Insert(item);
            }
            catch (Exception ex)
            {
                ex.Handle();
            }
        }

        public void Delete(Repartidor item)
        {
            try
            {
                ValidationHelper.NotNull(item, nameof(item));
                ValidationHelper.NotEmptyGuid(item.IdRepartidor, nameof(item.IdRepartidor));

                Repository.GetRepartidorInstance().Delete(item);
            }
            catch (Exception ex)
            {
                ex.Handle();
            }
        }

        public IEnumerable<Repartidor> SelectAll()
        {
            try
            {
                return Repository.GetRepartidorInstance().GetAll();
            }
            catch (Exception ex)
            {
                ex.Handle();
                throw;
            }
        }

        public Repartidor SelectOne(Guid id)
        {
            try
            {
                ValidationHelper.NotEmptyGuid(id, nameof(id));
                Repartidor repartidor = Repository.GetRepartidorInstance().GetById(id);
                if(repartidor == null)
                {
                    throw new Exception("No se encontró el objeto.");
                }
                return repartidor;
            }
            catch (Exception ex)
            {
                ex.Handle();
                throw;
            }
        }

        public void Update(Repartidor item)
        {
            try
            {
                ValidationHelper.NotNull(item, nameof(item));
                ValidationHelper.NotEmptyGuid(item.IdRepartidor, nameof(item.IdRepartidor));
                ValidationHelper.NotEmpty(item.Nombre, nameof(item.Nombre));
                ValidationHelper.NotEmpty(item.Apellido, nameof(item.Apellido));
                ValidationHelper.NotEmpty(item.Telefono, nameof(item.Telefono));
                if (item.Telefono.Length != 10)
                {
                    throw new Exception("El telefono debe tener al menos 10 dígitos");
                }
                if(Repository.GetRepartidorInstance().GetById(item.IdRepartidor) == null)
                {
                    throw new Exception("No se encontró el Repartidor a modificar.");
                }
                Repository.GetRepartidorInstance().Update(item);
            }
            catch (Exception ex)
            {
                ex.Handle();
            }
        }
    }
}
