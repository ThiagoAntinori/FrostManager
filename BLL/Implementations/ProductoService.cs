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
    public class ProductoService : IGenericService<Producto>
    {

        private readonly static ProductoService _instance = new ProductoService();

        public static ProductoService Current
        {
            get
            {
                return _instance;
            }
        }

        private ProductoService()
        {
            // Implement here the initialization of your singleton
        }

        public void Add(Producto item)
        {
            try
            {
                ValidationHelper.NotNull(item, nameof(item));
                ValidationHelper.NotEmptyGuid(item.IdProducto, nameof(item.IdProducto));
                ValidationHelper.NotEmpty(item.Descripcion, nameof(item.Descripcion));
                ValidationHelper.NotNull(item.CapacidadEnGramos, nameof(item.CapacidadEnGramos));
                ValidationHelper.NotNull(item.PrecioUnitario, nameof(item.PrecioUnitario));
                ValidationHelper.PositiveValue(item.CapacidadEnGramos, nameof(item.CapacidadEnGramos));
                ValidationHelper.PositiveValue(item.PrecioUnitario, nameof(item.PrecioUnitario));
                ProductoRepository.Current.Insert(item);
                LoggerHelper.RegistrarAlta(item);
            }
            catch(Exception ex)
            {
                ExceptionExtension.Handle(ex);
            }
        }

        public void Delete(Producto item)
        {
            try
            {
                ValidationHelper.NotNull(item, nameof(item));
                ValidationHelper.NotEmptyGuid(item.IdProducto, nameof(item.IdProducto));
                ProductoRepository.Current.Delete(item);
                LoggerHelper.RegistrarBaja(item);
            }
            catch (Exception ex)
            {
                ExceptionExtension.Handle(ex);
            }
        }

        public IEnumerable<Producto> SelectAll()
        {
            try
            {
                return ProductoRepository.Current.GetAll();
            }
            catch (Exception ex)
            {
                ExceptionExtension.Handle(ex);
                throw;
            }
        }

        public Producto SelectOne(Guid id)
        {
            try
            {
                if(id == Guid.Empty)
                {
                    throw new ArgumentNullException(nameof(id));
                }
                return ProductoRepository.Current.GetById(id);
            }
            catch (Exception ex)
            {
                ExceptionExtension.Handle(ex);
                throw;
            }
        }

        public void Update(Producto item)
        {
            try
            {
                ValidationHelper.NotNull(item, nameof(item));
                ValidationHelper.NotEmpty(item.Descripcion, nameof(item.Descripcion));
                ValidationHelper.NotEmptyGuid(item.IdProducto, nameof(item.IdProducto));
                ValidationHelper.PositiveValue(item.CapacidadEnGramos, nameof(item.CapacidadEnGramos));
                ValidationHelper.PositiveValue(item.PrecioUnitario, nameof(item.PrecioUnitario));
                if (this.SelectOne(item.IdProducto) == null)
                {
                    throw new Exception("No se encontró el producto a modificar");
                }
                ProductoRepository.Current.Update(item);
                LoggerHelper.RegistrarModificacion(item);
            }
            catch (Exception ex)
            {
                ExceptionExtension.Handle(ex);
            }
        }


    }
}
