using Services.Domain.Logging;
using Services.DAL.Loggers;
using Services.BLL.Extensions;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Services.DAL.Contracts;
using System.Runtime.CompilerServices;
using Services.Domain.Security;

namespace Services.BLL.Services
{
    public class LoggerService
    {
        public static ILogger GetLogger()
        {
            var config = new LoggerConfiguration();
            return config.CreateFileLogger();
        }
    }
}
