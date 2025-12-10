using DAL.Tools;
using Services.BLL.Extensions;
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
                string txtFileName = $"log_{DateTime.Now:yyyy-MM-dd}.txt";
                string txtFilePath = Path.Combine(logDirectory, txtFileName);

                WriteTxt(txtFilePath, log.ToString());

                string jsonFileName = "log_FrostManager.json";
                string jsonFilePath = Path.Combine(logDirectory, jsonFileName);

                WriteJson(jsonFilePath, log);
            }
            catch (Exception ex)
            {
                ex.Handle();
            }
        }

        private void WriteTxt(string filePath, string line)
        {
            try
            {
                using (var writer = new StreamWriter(filePath, true))
                {
                    writer.WriteLine(line);
                }
            }
            catch(Exception ex)
            {
                ex.Handle();
            }
        }

        private void WriteJson(string filePath, LogEntry log)
        {
            try
            {
                List<LogEntry> logs = JsonHelper.LoadList<LogEntry>(filePath);
                logs.Add(log);
                JsonHelper.SaveList<LogEntry>(filePath, logs);
            }
            catch (Exception ex)
            {
                ex.Handle();
            }
        }

        public List<LogEntry> GetLogs()
        {
            try
            {
                List<LogEntry> logs = JsonHelper.LoadList<LogEntry>(Path.Combine(logDirectory, "log_FrostManager.json"));
                return logs;
            }
            catch(Exception ex)
            {
                ex.Handle();
                throw;
            }
        }
    }
}
