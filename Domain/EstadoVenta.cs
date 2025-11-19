using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Domain
{
    public enum EstadoVenta
    {
        EnCurso = 1,
        PendienteDePago,
        PendienteDeEntrega,
        Finalizada,
        Cancelada
    }
}
