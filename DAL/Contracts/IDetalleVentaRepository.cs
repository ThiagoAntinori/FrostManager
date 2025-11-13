using Domain;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL.Contracts
{
    public interface IDetalleVentaRepository : IGenericRepository<DetalleVenta>
    {
        List<DetalleVenta> GetByIdVenta(Guid idVenta);
    }
}
