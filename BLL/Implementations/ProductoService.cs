using BLL.Contracts;
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
        public void Add(Producto item)
        {
            try
            {
                if (item == null)
                {
                    throw new ArgumentNullException(nameof(item));
                }
                if (string.IsNullOrEmpty(item.Descripcion))
                {
                    throw new Exception("El producto debe tener una descripción");
                }
                if (item.CapacidadEnGramos <= 0)
                {
                    throw new Exception("La capacidad del producto debe ser mayor a 0 gramos");
                }
                if (item.PrecioUnitario <= 0)
                {
                    throw new Exception("El precio del producto debe ser mayor a $0");
                }
                if (item.IdProducto == Guid.Empty)
                {
                    throw new Exception("El producto debe tener un ID");
                }
                ProductoRepository.Current.Insert(item);
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
                if (item == null)
                {
                    throw new ArgumentNullException(nameof(item));
                }
                if (item.IdProducto == Guid.Empty)
                {
                    throw new Exception("No se pudo encontrar el producto a eliminar");
                }
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
                if (item == null)
                {
                    throw new ArgumentNullException(nameof(item));
                }
                if (string.IsNullOrEmpty(item.Descripcion))
                {
                    throw new Exception("El producto debe tener una descripción");
                }
                if (item.CapacidadEnGramos <= 0)
                {
                    throw new Exception("La capacidad del producto debe ser mayor a 0 gramos");
                }
                if (item.PrecioUnitario <= 0)
                {
                    throw new Exception("El precio del producto debe ser mayor a $0");
                }
                if (item.IdProducto == Guid.Empty)
                {
                    throw new Exception("El producto debe tener un ID");
                }
                if (this.SelectOne(item.IdProducto) == null)
                {
                    throw new Exception("No se encontró el producto a modificar");
                }
                ProductoRepository.Current.Update(item);
            }
            catch (Exception ex)
            {
                ExceptionExtension.Handle(ex);
            }
        }


    }
}
