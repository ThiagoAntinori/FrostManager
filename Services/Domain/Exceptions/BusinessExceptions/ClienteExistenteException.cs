using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Services.Domain.Exceptions.BusinessExceptions
{
    public class ClienteExistenteException : BusinessException
    {
        public ClienteExistenteException(Exception ex = null) : base("Ya existe un cliente con el DNI ingresado", ex)
        {

        }
    }
}
