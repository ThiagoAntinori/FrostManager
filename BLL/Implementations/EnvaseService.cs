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
    public class EnvaseService : IGenericService<Envase>
    {
        private readonly static EnvaseService _instance = new EnvaseService();

        public static EnvaseService Current
        {
            get
            {
                return _instance;
            }
        }

        private EnvaseService()
        {
            // Implement here the initialization of your singleton
        }

        public void Add(Envase item)
        {
            try
            {
                ValidationHelper.NotNull(item, nameof(item));
                ValidationHelper.NotEmptyGuid(item.IdInsumo, nameof(item.IdInsumo));
                ValidationHelper.NotEmpty(item.Descripcion, nameof(item.Descripcion));
                if(item.StockActual <= 0)
                {
                    throw new Exception("El stock actual del envase debe ser mayor a cero.");
                }
                if(item.StockMinimo <= 0)
                {
                    throw new Exception("El stock mínimo del envase debe ser mayor a cero");
                }
                if(item.CapacidadEnGramos <= 0)
                {
                    throw new Exception("La capacidad en gramos del envase debe ser mayor a cero");
                }
                EnvaseRepository.Current.Insert(item);
            }
            catch (Exception ex)
            {
                ExceptionExtension.Handle(ex);
            }
        }

        public void Delete(Envase item)
        {
            try
            {
                ValidationHelper.NotNull(item, nameof(item));
                ValidationHelper.NotEmptyGuid(item.IdInsumo, nameof(item.IdInsumo));
                EnvaseRepository.Current.Delete(item);
            }
            catch (Exception ex)
            {
                ExceptionExtension.Handle(ex);
            }
        }

        public IEnumerable<Envase> SelectAll()
        {
            try
            {
                return EnvaseRepository.Current.GetAll();
            }
            catch (Exception ex)
            {
                ExceptionExtension.Handle(ex);
                throw;
            }
        }

        public Envase SelectOne(Guid id)
        {
            try
            {
                ValidationHelper.NotEmptyGuid(id, nameof(id));
                return EnvaseRepository.Current.GetById(id);
            }
            catch (Exception ex)
            {
                ExceptionExtension.Handle(ex);
                throw;
            }
        }

        public void Update(Envase item)
        {
            try
            {
                ValidationHelper.NotNull(item, nameof(item));
                ValidationHelper.NotEmptyGuid(item.IdInsumo, nameof(item.IdInsumo));
                ValidationHelper.NotEmpty(item.Descripcion, nameof(item.Descripcion));
                if (item.StockActual <= 0)
                {
                    throw new Exception("El stock actual del envase debe ser mayor a cero.");
                }
                if (item.StockMinimo <= 0)
                {
                    throw new Exception("El stock mínimo del envase debe ser mayor a cero");
                }
                if (item.CapacidadEnGramos <= 0)
                {
                    throw new Exception("La capacidad en gramos del envase debe ser mayor a cero");
                }
                EnvaseRepository.Current.Update(item);
            }
            catch (Exception ex)
            {
                ExceptionExtension.Handle(ex);
            }
        }
    }
}
