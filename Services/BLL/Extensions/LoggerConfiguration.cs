using Services.DAL.Contracts;
using Services.DAL.Loggers;
using Services.Domain.Logging;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Services.BLL.Extensions
{
    public class LoggerConfiguration
    {
        public ILogger CreateFileLogger()
        {
            return new FileLogger();
        }
    }
}
