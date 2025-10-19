using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL.Contracts
{
    public interface IGenericRepository<T>
    {
        void Insert(T obj);
        void Update(T obj);
        void Delete(T obj);
        T GetById(Guid id);
        IEnumerable<T> GetAll(T obj);
    }
}
