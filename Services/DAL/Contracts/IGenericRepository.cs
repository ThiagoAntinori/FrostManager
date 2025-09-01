using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Services.DAL.Contracts
{
    public interface IGenericRepository<T>
    {
        void Insert(T item);
        void Delete(T item);
        void Update(T item);
        List<T> GetAll();
        T GetById(Guid id);
    }
}
