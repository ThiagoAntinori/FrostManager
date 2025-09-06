using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Services.Domain.Exceptions
{
    public class BusinessException : Exception
    {
        public BusinessException(string message, Exception ex = null) :
            base(message, ex)
        {

        }
    }
}
