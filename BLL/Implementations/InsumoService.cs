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
                ex.Handle();
            }
        }

        public void Delete(Insumo item)
        {
            try
            {
                ValidationHelper.NotNull(item, nameof(item));
                ValidationHelper.NotEmptyGuid(item.IdInsumo, nameof(item.IdInsumo));
                Repository.GetInsumoInstance().Delete(item);
            }
            catch (Exception ex)
            {
                ex.Handle();
            }
        }

        public IEnumerable<Insumo> SelectAll()
        {
            try
            {
                return Repository.GetInsumoInstance().GetAll();
            }
            catch (Exception ex)
            {
                ex.Handle();
                throw;
            }
        }

        public Insumo SelectOne(Guid id)
        {
            try
            {
                ValidationHelper.NotEmptyGuid(id, "IdInsumo");
                Insumo insumoGet = Repository.GetInsumoInstance().GetById(id);
                if(insumoGet == null)
                {
                    throw new Exception("No se encontró el insumo");
                }
                return insumoGet;
            }
            catch (Exception ex)
            {
                ex.Handle();
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
                ex.Handle();
            }
        }

        public void RegistrarIngreso(Insumo item, MovimientoStock movimiento)
        {
            try
            {
                ValidationHelper.NotNull(item, nameof(item));
                ValidationHelper.NotEmptyGuid(item.IdInsumo, nameof(item.IdInsumo));
                ValidationHelper.PositiveValue(movimiento.Cantidad, "Cantidad a sumar");
                
                using (UnitOfWork uof = new UnitOfWork())
                {
                    try
                    {
                        item.StockActual += movimiento.Cantidad;
                        Repository.GetInsumoInstance().ActualizarStock(item, uof);
                        Repository.GetMovimientoStockInstance().Insert(movimiento, uof);
                        uof.Commit();
                    }
                    catch(Exception ex)
                    {
                        uof.Rollback();
                        throw;
                    }
                }
            }
            catch (Exception ex)
            {
                ex.Handle();
            }
        }

        public void RegistrarEgreso(Insumo item, MovimientoStock movimiento)
        {
            try
            {
                ValidationHelper.NotNull(item, nameof(item));
                ValidationHelper.NotEmptyGuid(item.IdInsumo, nameof(item.IdInsumo));
                ValidationHelper.NotNull(movimiento, nameof(movimiento));
                ValidationHelper.NotEmptyGuid(movimiento.IdMovimientoStock, nameof(movimiento.IdMovimientoStock));
                ValidationHelper.NotEmpty(movimiento.Motivo, nameof(movimiento.Motivo));
                ValidationHelper.PositiveValue(movimiento.Cantidad, "Cantidad a restar");
                if (item.StockActual - movimiento.Cantidad < 0)
                {
                    throw new Exception("No es posible restar la cantidad de stock");
                }
                using(UnitOfWork uow = new UnitOfWork())
                {
                    try
                    {
                        item.StockActual -= movimiento.Cantidad;
                        Repository.GetInsumoInstance().ActualizarStock(item, uow);
                        Repository.GetMovimientoStockInstance().Insert(movimiento, uow);
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

        public void ActualizarStock(Insumo item, MovimientoStock movimiento)
        {
            ValidationHelper.NotNull(item, nameof(item));
            ValidationHelper.NotEmptyGuid(item.IdInsumo, nameof(item.IdInsumo));
            ValidationHelper.NotNull(movimiento, nameof(movimiento));
            ValidationHelper.NotEmptyGuid(movimiento.IdMovimientoStock, nameof(movimiento.IdMovimientoStock));
            ValidationHelper.NotEmpty(movimiento.Motivo, nameof(movimiento.Motivo));
            ValidationHelper.PositiveValue(movimiento.Cantidad, "Nuevo stock");
            using (UnitOfWork uow = new UnitOfWork())
            {
                try
                {
                    item.StockActual = movimiento.Cantidad;
                    Repository.GetInsumoInstance().ActualizarStock(item, uow);
                    Repository.GetMovimientoStockInstance().Insert(movimiento, uow);
                    uow.Commit();
                }
                catch (Exception ex)
                {
                    uow.Rollback();
                    throw;
                }
            }
        }

        public bool VerificarStock(Insumo insumo, int cantidad)
        {
            try
            {
                ValidationHelper.NotNull(insumo, nameof(insumo));
                ValidationHelper.NotEmptyGuid(insumo.IdInsumo, nameof(insumo.IdInsumo));
                ValidationHelper.PositiveValue(cantidad, nameof(cantidad));
                int insumoDisponible = Repository.GetInsumoInstance().GetById(insumo.IdInsumo).StockActual;
                return insumoDisponible >= cantidad;
            }
            catch (Exception ex)
            {
                ex.Handle();
                throw;
            }
        }
    }
}
