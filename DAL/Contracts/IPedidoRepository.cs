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
        List<Pedido> GetByPeriodo(DateOnly fechaInicio, DateOnly fechaFin);
    }
}
