using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Services.Domain.Exceptions
{
    public class CredencialesIncorrectasException : Exception
    {
        public CredencialesIncorrectasException(string nombreUsuario) : base("Usuario o contraseña incorrectos")
        {

        }
    }
}
