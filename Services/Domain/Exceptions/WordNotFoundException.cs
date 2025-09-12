using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Services.Domain.Exceptions
{
    public class WordNotFoundException : Exception
    {
        public WordNotFoundException() : base("No se pudo traducir una palabra")
        {

        }
    }
}
