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
                if(item.SaboresSeleccionados == null || !item.SaboresSeleccionados.Any())
                {
                    throw new Exception("El detalle debe tener al menos un sabor seleccionado");
                }

                using (UnitOfWork uow = new UnitOfWork())
                {
                    try
                    {
                        Repository.GetDetalleVentaInstance().Insert(item, uow);
                        foreach (SaborSeleccionado s in item.SaboresSeleccionados)
                        {
                            s.IdDetalleVenta = item.IdDetalleVenta;
                            Repository.GetSaborSeleccionadoInstance().Insert(s, uow);
                        }
                        uow.Commit();
                    }
                    catch(Exception ex)
                    {
                        uow.Rollback();
                        throw;
                    }
                }
            }
            catch (Exception ex)
            {
                ex.Handle();
            }
        }

        public void Delete(DetalleVenta item)
        {
            try
            {
                ValidationHelper.NotNull(item, nameof(item));
                ValidationHelper.NotEmptyGuid(item.IdDetalleVenta, nameof(item.IdDetalleVenta));

                Repository.GetDetalleVentaInstance().Delete(item);
            }
            catch (Exception ex)
            {
                ex.Handle();
            }   
        }

        public IEnumerable<DetalleVenta> SelectAll()
        {
            try
            {
                return Repository.GetDetalleVentaInstance().GetAll();
            }
            catch (Exception ex)
            {
                ex.Handle();
                throw;
            }
        }

        public DetalleVenta SelectOne(Guid id)
        {

            try
            {
                ValidationHelper.NotEmptyGuid(id, "ID");

                return Repository.GetDetalleVentaInstance().GetById(id);
            }
            catch (Exception ex)
            {
                ex.Handle();
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

                Repository.GetDetalleVentaInstance().Update(item);
            }
            catch (Exception ex)
            {
                ex.Handle();
            }
        }

        public List<DetalleVenta> GetByIdVenta(Guid idVenta)
        {
            try
            {
                ValidationHelper.NotEmptyGuid(idVenta, "IdVenta");

                return Repository.GetDetalleVentaInstance().GetByIdVenta(idVenta);
            }
            catch (Exception ex)
            {
                ex.Handle();
                throw;
            }
        }
    }
}
