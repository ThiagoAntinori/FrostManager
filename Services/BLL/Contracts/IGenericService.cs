using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Services.BLL.Contracts
{
    public interface IGenericService<T>
    {
        void Add(T obj);

        void Update(T obj);

        void Delete(T obj);

        List<T> SelectAll();

        T SelectOne(Guid id);
    }
}
