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
                if (item.StockActual <= 0)
                {
                    throw new Exception("El stock actual del envase debe ser mayor a cero.");
                }
                if (item.StockMinimo <= 0)
                {
                    throw new Exception("El stock mínimo del envase debe ser mayor a cero");
                }
                SaborRepository.Current.Insert(item);
            }
            catch (Exception ex)
            {
                ExceptionExtension.Handle(ex);
            }
        }

        public void Delete(Sabor item)
        {
            try
            {
                ValidationHelper.NotNull(item, nameof(item));
                ValidationHelper.NotEmptyGuid(item.IdInsumo, nameof(item.IdInsumo));
                SaborRepository.Current.Delete(item);
            }
            catch (Exception ex)
            {
                ExceptionExtension.Handle(ex);
            }
        }

        public IEnumerable<Sabor> SelectAll()
        {
            try
            {
                return SaborRepository.Current.GetAll();
            }
            catch (Exception ex)
            {
                ExceptionExtension.Handle(ex);
                throw;
            }
        }

        public Sabor SelectOne(Guid id)
        {
            try
            {
                ValidationHelper.NotEmptyGuid(id, nameof(id));
                return SaborRepository.Current.GetById(id);
            }
            catch (Exception ex)
            {
                ExceptionExtension.Handle(ex);
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
                if (item.StockActual <= 0)
                {
                    throw new Exception("El stock actual del envase debe ser mayor a cero.");
                }
                if (item.StockMinimo <= 0)
                {
                    throw new Exception("El stock mínimo del envase debe ser mayor a cero");
                }
                if (SaborRepository.Current.GetById(item.IdInsumo) is null)
                {
                    throw new Exception("No se encontró el sabor a modificar");
                }
                SaborRepository.Current.Update(item);
            }
            catch (Exception ex)
            {
                ExceptionExtension.Handle(ex);
            }
        }
    }
}
