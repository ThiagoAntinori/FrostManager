using DAL.Implementations.SqlServer;
using Domain;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL.Contracts
{
    public interface IPedidoRepository : IGenericRepository<Pedido>
    {
        List<Pedido> GetByEstado(EstadoPedido estado);
        List<Pedido> GetByPeriodo(DateTime fechaInicio, DateTime fechaFin);
        void CambiarEstado(Pedido obj, EstadoPedido nuevoEstado, UnitOfWork uow = null);
    }
}
