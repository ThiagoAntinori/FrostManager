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
    public class InsumoService : IGenericService<Insumo>
    {

        private readonly static InsumoService _instance = new InsumoService();

        public static InsumoService Current
        {
            get
            {
                return _instance;
            }
        }

        private InsumoService()
        {
            // Implement here the initialization of your singleton
        }

        public void Add(Insumo item)
        {
            try
            {
                if(item is Envase envase)
                {
                    EnvaseService.Current.Add(envase);
                }
                else if(item is Sabor sabor)
                {
                    SaborService.Current.Add(sabor);
                }
            }
            catch (Exception ex)
            {
                ExceptionExtension.Handle(ex);
            }
        }

        public void Delete(Insumo item)
        {
            try
            {
                ValidationHelper.NotNull(item, nameof(item));
                ValidationHelper.NotEmptyGuid(item.IdInsumo, nameof(item.IdInsumo));
                InsumoRepository.Current.Delete(item);
            }
            catch (Exception ex)
            {
                ExceptionExtension.Handle(ex);
            }
        }

        public IEnumerable<Insumo> SelectAll()
        {
            try
            {
                return InsumoRepository.Current.GetAll();
            }
            catch (Exception ex)
            {
                ExceptionExtension.Handle(ex);
                throw;
            }
        }

        public Insumo SelectOne(Guid id)
        {
            try
            {
                ValidationHelper.NotEmptyGuid(id, "IdInsumo");
                Insumo insumoGet = InsumoRepository.Current.GetById(id);
                if(insumoGet == null)
                {
                    throw new Exception("No se encontró el insumo");
                }
                return insumoGet;
            }
            catch (Exception ex)
            {
                ExceptionExtension.Handle(ex);
                throw;
            }
        }

        public void Update(Insumo item)
        {
            try
            {
                if(item is Envase envase)
                {
                    EnvaseService.Current.Update(envase);
                }
                else if(item is Sabor sabor)
                {
                    SaborService.Current.Update(sabor);
                }
            }
            catch (Exception ex)
            {
                ExceptionExtension.Handle(ex);
            }
        }

        public void RegistrarIngreso(Insumo item, int cantidadASumar)
        {
            try
            {
                ValidationHelper.NotNull(item, nameof(item));
                ValidationHelper.NotEmptyGuid(item.IdInsumo, nameof(item.IdInsumo));
                ValidationHelper.PositiveValue(cantidadASumar, "Cantidad a sumar");
                item.StockActual += cantidadASumar;
                InsumoRepository.Current.Update(item);
            }
            catch (Exception ex)
            {
                ExceptionExtension.Handle(ex);
            }
        }

        public void RegistrarEgreso(Insumo item, int cantidadARestar)
        {
            try
            {
                ValidationHelper.NotNull(item, nameof(item));
                ValidationHelper.NotEmptyGuid(item.IdInsumo, nameof(item.IdInsumo));
                ValidationHelper.PositiveValue(cantidadARestar, "Cantidad a restar");
                if (item.StockActual - cantidadARestar < 0)
                {
                    throw new Exception("No es posible restar la cantidad de stock");
                }
                item.StockActual -= cantidadARestar;
                InsumoRepository.Current.Update(item);
            }
            catch (Exception ex)
            {
                ExceptionExtension.Handle(ex);
            }
        }
    }
}
