using Services.DAL.Contracts;
using Services.Domain.Logging;
using System;
using System.Collections.Generic;
using System.Configuration;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Services.DAL.Loggers
{
    public class FileLogger : ILogger
    {
        private readonly string logDirectory;

        public FileLogger()
        {
            this.logDirectory = ConfigurationManager.AppSettings["LogDirectory"];

            if (!Directory.Exists(logDirectory))
            {
                Directory.CreateDirectory(logDirectory);
            }
        }

        public void WriteLog(LogEntry log)
        {
            try
            {
                string fileName = $"log_{DateTime.Now:yyyy-MM-dd}.txt";
                string filePath = Path.Combine(logDirectory, fileName);

                string line = log.ToString();

                using (var writer = new StreamWriter(filePath, true))
                {
                    writer.WriteLine(line);
                }
            }
            catch (Exception ex)
            {
                throw;
            }
        }
    }
}
