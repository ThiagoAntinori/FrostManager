using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BLL.Contracts
{
    public interface IGenericService<T>
    {
        void Add(T item);
        void Update(T item);
        void Delete(T item);
        T SelectOne(Guid id);
        IEnumerable<T> SelectAll();
    }
}
