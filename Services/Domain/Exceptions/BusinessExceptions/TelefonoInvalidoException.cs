using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Services.Domain.Exceptions.BusinessExceptions
{
    public class TelefonoInvalidoException : BusinessException
    {
        public TelefonoInvalidoException(Exception ex = null) : base($"El telefono no es válido - Debe tener 10 dígitos", ex)
        {
        }
    }
}
