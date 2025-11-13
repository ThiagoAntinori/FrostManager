using DAL.Implementations.SqlServer;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL.Contracts
{
    public interface IGenericRepository<T>
    {
        void Insert(T obj, UnitOfWork uow = null);
        void Update(T obj, UnitOfWork uow = null);
        void Delete(T obj, UnitOfWork uow = null);
        T GetById(Guid id);
        IEnumerable<T> GetAll();
    }
}
