using Microsoft.IdentityModel.Abstractions;
using Services.DAL.Contracts;
using Services.Domain.Logging;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Services.DAL.Loggers
{
    public class FileLogger : ILogger
    {
        private readonly string logFilePath;
        private readonly LogLevel minimunLogLevel;
        private readonly StreamWriter writer;

        public FileLogger(string logFilePath, LogLevel minimunLogLevel)
        {
            this.logFilePath = logFilePath;
            this.minimunLogLevel = minimunLogLevel;

            string directoryPath = Path.GetDirectoryName(logFilePath);
            if (!Directory.Exists(directoryPath))
            {
                Directory.CreateDirectory(directoryPath);
            }

            writer = new StreamWriter(logFilePath, true);
        }

        public void WriteLog()
        {
            try
            {
            }
            catch (Exception ex)
            {
                throw;
            }
            finally
            {
                writer.Close();
            }
        }
    }
}
