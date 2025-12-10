using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Services.Domain.Exceptions.BusinessExceptions
{
    public class DatosInvalidosException : BusinessException
    {
        public DatosInvalidosException(string nombreCampo, string reglaNegocio) : 
            base($"El formato del campo {nombreCampo} es incorrecto. Motivo: {reglaNegocio}")
        {
        }
    }
}
