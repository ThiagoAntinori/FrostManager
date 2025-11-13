using Domain;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL.Contracts
{
    public interface IVentaRepository : IGenericRepository<Venta>
    {
        IEnumerable<Venta> GetByPeriodo(DateTime fechaInicio, DateTime fechaFin);
        IEnumerable<Venta> GetByFecha(DateTime fecha);
        IEnumerable<Venta> GetByMedioPago(MedioPago medioPago);
        IEnumerable<Venta> GetByEstado(EstadoVenta estadoVenta);
        Venta GetVentaEnCurso();
    }
}
