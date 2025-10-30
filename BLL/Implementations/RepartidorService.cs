using BLL.Contracts;
using BLL.Tools;
using DAL.Implementations;
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

                RepartidorRepository.Current.Insert(item);
            }
            catch (Exception ex)
            {
                ExceptionExtension.Handle(ex);
            }
        }

        public void Delete(Repartidor item)
        {
            try
            {
                ValidationHelper.NotNull(item, nameof(item));
                ValidationHelper.NotEmptyGuid(item.IdRepartidor, nameof(item.IdRepartidor));

                RepartidorRepository.Current.Delete(item);
            }
            catch (Exception ex)
            {
                ExceptionExtension.Handle(ex);
            }
        }

        public IEnumerable<Repartidor> SelectAll()
        {
            try
            {
                return RepartidorRepository.Current.GetAll();
            }
            catch (Exception ex)
            {
                ExceptionExtension.Handle(ex);
                throw;
            }
        }

        public Repartidor SelectOne(Guid id)
        {
            try
            {
                ValidationHelper.NotEmptyGuid(id, nameof(id));
                Repartidor repartidor = RepartidorRepository.Current.GetById(id);
                if(repartidor == null)
                {
                    throw new Exception("No se encontró el objeto.");
                }
                return repartidor;
            }
            catch (Exception ex)
            {
                ExceptionExtension.Handle(ex);
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
                if(RepartidorRepository.Current.GetById(item.IdRepartidor) == null)
                {
                    throw new Exception("No se encontró el Repartidor a modificar.");
                }
                RepartidorRepository.Current.Update(item);
            }
            catch (Exception ex)
            {
                ExceptionExtension.Handle(ex);
            }
        }
    }
}
