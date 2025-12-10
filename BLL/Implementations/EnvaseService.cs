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
                ValidationHelper.PositiveValue(item.StockMinimo, nameof(item.StockMinimo));
                ValidationHelper.PositiveValue(item.StockActual, nameof(item.StockActual));
                ValidationHelper.PositiveValue(item.CapacidadEnGramos, nameof(item.CapacidadEnGramos));
                Repository.GetEnvaseInstance().Insert(item);
                LoggerHelper.RegistrarAlta(item);
            }
            catch (Exception ex)
            {
                ex.Handle();
            }
        }

        public void Delete(Envase item)
        {
            try
            {
                ValidationHelper.NotNull(item, nameof(item));
                ValidationHelper.NotEmptyGuid(item.IdInsumo, nameof(item.IdInsumo));
                Repository.GetEnvaseInstance().Delete(item);
                LoggerHelper.RegistrarBaja(item);
            }
            catch (Exception ex)
            {
                ex.Handle();
            }
        }

        public IEnumerable<Envase> SelectAll()
        {
            try
            {
                return Repository.GetEnvaseInstance().GetAll();
            }
            catch (Exception ex)
            {
                ex.Handle();
                throw;
            }
        }

        public Envase SelectOne(Guid id)
        {
            try
            {
                ValidationHelper.NotEmptyGuid(id, nameof(id));
                return Repository.GetEnvaseInstance().GetById(id);
            }
            catch (Exception ex)
            {
                ex.Handle();
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
                ValidationHelper.PositiveValue(item.StockMinimo, nameof(item.StockMinimo));
                ValidationHelper.PositiveValue(item.StockActual, nameof(item.StockActual));
                ValidationHelper.PositiveValue(item.CapacidadEnGramos, nameof(item.CapacidadEnGramos));
                Repository.GetEnvaseInstance().Update(item);
                LoggerHelper.RegistrarModificacion(item);
            }
            catch (Exception ex)
            {
                ex.Handle();
            }
        }
    }
}
