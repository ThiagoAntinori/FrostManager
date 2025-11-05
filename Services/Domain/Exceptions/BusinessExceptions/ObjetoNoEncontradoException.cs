using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Services.Domain.Exceptions.BusinessExceptions
{
    public class ObjetoNoEncontradoException : BusinessException
    {
        public ObjetoNoEncontradoException(string message, object objeto, Exception ex = null) : base($"No se encontró el objeto {objeto.GetType()} en la base de datos.", ex)
        {

        }
    }
}
