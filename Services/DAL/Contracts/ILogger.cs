using Microsoft.IdentityModel.Abstractions;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Services.DAL.Contracts
{
    public interface ILogger
    {
        void WriteLog(LogEntry log);
    }
}
