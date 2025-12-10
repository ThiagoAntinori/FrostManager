using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Services.Domain.Exceptions
{
    public class BackupException : Exception
    {
        public BackupException(Exception innerEx) : base("Ocurrió un error al respaldar/restaurar datos", innerEx)
        {

        }
    }
}
