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
    public class DetalleVentaService : IGenericService<DetalleVenta>
    {

        private readonly static DetalleVentaService _instance = new DetalleVentaService();

        public static DetalleVentaService Current
        {
            get
            {
                return _instance;
            }
        }

        private DetalleVentaService()
        {
            // Implement here the initialization of your singleton
        }

        public void Add(DetalleVenta item)
        { 
            try
            {
                ValidationHelper.NotNull(item, nameof(item));
                ValidationHelper.NotEmptyGuid(item.IdDetalleVenta, nameof(item.IdDetalleVenta));
                ValidationHelper.NotNull(item.Producto, nameof(item.Producto));
                ValidationHelper.NotEmptyGuid(item.Producto.IdProducto, nameof(item.Producto.IdProducto));
                ValidationHelper.NotEmptyGuid(item.IdVenta, nameof(item.IdDetalleVenta));
                ValidationHelper.PositiveValue(item.Cantidad, nameof(item.Cantidad));

                DetalleVentaRepository.Current.Insert(item);
            }
            catch (Exception ex)
            {
                ExceptionExtension.Handle(ex);
            }
        }

        public void Delete(DetalleVenta item)
        {
            try
            {
                ValidationHelper.NotNull(item, nameof(item));
                ValidationHelper.NotEmptyGuid(item.IdDetalleVenta, nameof(item.IdDetalleVenta));

                DetalleVentaRepository.Current.Delete(item);
            }
            catch (Exception ex)
            {
                ExceptionExtension.Handle(ex);
            }   
        }

        public IEnumerable<DetalleVenta> SelectAll()
        {
            try
            {
                return DetalleVentaRepository.Current.GetAll();
            }
            catch (Exception ex)
            {
                ExceptionExtension.Handle(ex);
                throw;
            }
        }

        public DetalleVenta SelectOne(Guid id)
        {

            try
            {
                ValidationHelper.NotEmptyGuid(id, "ID");

                return DetalleVentaRepository.Current.GetById(id);
            }
            catch (Exception ex)
            {
                ExceptionExtension.Handle(ex);
                throw;
            }
        }

        public void Update(DetalleVenta item)
        {
            try
            {
                ValidationHelper.NotNull(item, nameof(item));
                ValidationHelper.NotEmptyGuid(item.IdDetalleVenta, nameof(item.IdDetalleVenta));
                ValidationHelper.PositiveValue(item.Cantidad, nameof(item.Cantidad));

                DetalleVentaRepository.Current.Update(item);
            }
            catch (Exception ex)
            {
                ExceptionExtension.Handle(ex);
            }
        }

        public List<DetalleVenta> GetByIdVenta(Guid idVenta)
        {
            try
            {
                ValidationHelper.NotEmptyGuid(idVenta, "IdVenta");

                return DetalleVentaRepository.Current.GetByIdVenta(idVenta);
            }
            catch (Exception ex)
            {
                ExceptionExtension.Handle(ex);
                throw;
            }
        }
    }
}
