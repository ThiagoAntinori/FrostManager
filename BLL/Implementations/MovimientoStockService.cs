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
    public class MovimientoStockService : IGenericService<MovimientoStock>
    {

        private readonly static MovimientoStockService _instance = new MovimientoStockService();

        public static MovimientoStockService Current
        {
            get
            {
                return _instance;
            }
        }

        private MovimientoStockService()
        {
            // Implement here the initialization of your singleton
        }

        public void Add(MovimientoStock item)
        {
            try
            {
                ValidationHelper.NotNull(item, nameof(item));
                ValidationHelper.NotEmptyGuid(item.IdMovimientoStock, nameof(item.IdMovimientoStock));
                ValidationHelper.NotNull(item.Insumo, nameof(item.Insumo));
                ValidationHelper.NotEmptyGuid(item.Insumo.IdInsumo, nameof(item.Insumo.IdInsumo));
                ValidationHelper.PositiveValue(item.Cantidad, nameof(item.Cantidad));
                ValidationHelper.NotEmpty(item.Motivo, nameof(item.Motivo));

                item.FechaHora = DateTime.Now;

                Repository.GetMovimientoStockInstance().Insert(item, null);
            }
            catch (Exception ex)
            {
                ex.Handle();
            }
        }

        public void Delete(MovimientoStock item)
        {
            throw new NotImplementedException();
        }

        public IEnumerable<MovimientoStock> SelectAll()
        {
            try
            {
                return Repository.GetMovimientoStockInstance().GetAll();
            }
            catch (Exception ex)
            {
                ex.Handle();
                throw;
            }   
        }

        public MovimientoStock SelectOne(Guid id)
        {
            try
            {
                MovimientoStock movimientoStockGet = Repository.GetMovimientoStockInstance().GetById(id);
                if(movimientoStockGet == null)
                {
                    throw new Exception("No se encontró el objeto.");
                }
                return movimientoStockGet;
            }
            catch (Exception ex)
            {
                ex.Handle();
                throw;
            }
        }

        public void Update(MovimientoStock item)
        {
            throw new NotImplementedException();
        }
    }
}
