using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BLL.Tools
{
    public static class ValidationHelper
    {
        public static void NotNull(object obj, string paramName)
        {
            if(obj == null)
            {
                throw new ArgumentNullException($"El objeto {paramName} no puede ser nulo.");
            }
        }

        public static void NotEmpty(string value, string paramName)
        {
            if (string.IsNullOrWhiteSpace(value))
                throw new ArgumentException($"El campo {paramName} no puede estar vacío.");
        }

        public static void NotEmptyGuid(Guid value, string paramName)
        {
            if (value == Guid.Empty)
            {
                throw new ArgumentException($"El campo {paramName} no puede estar vacío.");
            }
        }

        public static void PositiveValue(int value, string paramName)
        {
            if(value >= 0)
            {
                throw new ArgumentException($"El campo {paramName} debe ser mayor a 0");
            }
        }

        public static void PositiveValue(decimal value, string paramName)
        {
            if(value >= 0)
            {
                throw new ArgumentException($"El campo {paramName} debe ser mayor a 0");
            }
        }
    }
}
