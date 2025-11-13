using Domain;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL.Contracts
{
    public interface IClienteRepository : IGenericRepository<Cliente>
    {
        bool ExisteCliente(string DNI);
        Cliente GetByDNI(string DNI);
    }
}
