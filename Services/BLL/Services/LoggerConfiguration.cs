using Services.DAL.Contracts;
using Services.Domain.Logging;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Services.BLL.Services
{
    public class LoggerConfiguration
    {
        public string LogFilePath { get; set; } = "Logs/app.log";
        public LogLevel MinimumLogLevel { get; set; } = LogLevel.Information;

        public ILogger CreateFileLogger()
        {
            return new FileLogger(LogFilePath, MinimumLogLevel);
        }
    }
}
