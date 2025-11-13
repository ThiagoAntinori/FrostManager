using DAL.Implementations.SqlServer;
using Domain;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL.Contracts
{
    public interface IInsumoRepository : IGenericRepository<Insumo>
    {
        void ActualizarStock(Insumo obj, UnitOfWork uow);
        void RestarStock(Guid idInsumo, int cantidad, UnitOfWork uow);
    }
}
