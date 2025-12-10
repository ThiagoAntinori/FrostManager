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
    public class SaborService : IGenericService<Sabor>
    {

        private readonly static SaborService _instance = new SaborService();

        public static SaborService Current
        {
            get
            {
                return _instance;
            }
        }

        private SaborService()
        {
            // Implement here the initialization of your singleton
        }

        public void Add(Sabor item)
        {
            try
            {
                ValidationHelper.NotNull(item, nameof(item));
                ValidationHelper.NotEmptyGuid(item.IdInsumo, nameof(item.IdInsumo));
                ValidationHelper.NotEmpty(item.Descripcion, nameof(item.Descripcion));
                ValidationHelper.PositiveValue(item.StockActual, nameof(item.StockActual));
                ValidationHelper.PositiveValue(item.StockMinimo, nameof(item.StockMinimo));
                Repository.GetSaborInstance().Insert(item);
            }
            catch (Exception ex)
            {
                ex.Handle();
            }
        }

        public void Delete(Sabor item)
        {
            try
            {
                ValidationHelper.NotNull(item, nameof(item));
                ValidationHelper.NotEmptyGuid(item.IdInsumo, nameof(item.IdInsumo));
                Repository.GetSaborInstance().Delete(item);
                LoggerHelper.RegistrarBaja(item);
            }
            catch (Exception ex)
            {
                ex.Handle();
            }
        }

        public IEnumerable<Sabor> SelectAll()
        {
            try
            {
                return Repository.GetSaborInstance().GetAll();
            }
            catch (Exception ex)
            {
                ex.Handle();
                throw;
            }
        }

        public Sabor SelectOne(Guid id)
        {
            try
            {
                ValidationHelper.NotEmptyGuid(id, nameof(id));
                return Repository.GetSaborInstance().GetById(id);
            }
            catch (Exception ex)
            {
                ex.Handle();
                throw;
            }
        }

        public void Update(Sabor item)
        {
            try
            {
                ValidationHelper.NotNull(item, nameof(item));
                ValidationHelper.NotEmptyGuid(item.IdInsumo, nameof(item.IdInsumo));
                ValidationHelper.NotEmpty(item.Descripcion, nameof(item.Descripcion));
                ValidationHelper.PositiveValue(item.StockActual, nameof(item.StockActual));
                ValidationHelper.PositiveValue(item.StockMinimo, nameof(item.StockMinimo));
                if (Repository.GetSaborInstance().GetById(item.IdInsumo) is null)
                {
                    throw new Exception("No se encontró el sabor a modificar");
                }
                Repository.GetSaborInstance().Update(item);
                LoggerHelper.RegistrarModificacion(item);
            }
            catch (Exception ex)
            {
                ex.Handle();
            }
        }
    }
}
