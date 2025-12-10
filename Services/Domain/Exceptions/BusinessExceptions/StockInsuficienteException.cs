using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Services.Domain.Exceptions.BusinessExceptions
{
    public class StockInsuficienteException : BusinessException
    {
        public StockInsuficienteException(string nombreInsumo, int cantidadFaltante) : 
            base($"Stock insuficiente de: {nombreInsumo}. Faltan {cantidadFaltante}")
        {

        }
    }
}
