using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Services.Domain.Exceptions.BusinessExceptions
{
    public class TransicionEstadoInvalidaException : BusinessException
    {
        public TransicionEstadoInvalidaException(string entidad, string estadoActual, string nuevoEstado) :
            base($"Error de flujo. La {entidad} no puede transicionar directamente de '{estadoActual}' a '{nuevoEstado}'.")
        {

        }
    }
}
