using Services.Domain.Security;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Services.Domain.Logging
{
    public class LogEntry
    {
        public DateTime Timestamp { get; set; }
        public LogLevel Level { get; set; }
        public string Message { get; set; }
        public Exception Exception { get; set; }
        public Usuario Usuario { get; set; }

        public LogEntry(DateTime timestamp, LogLevel level, string message)
        {
            this.Timestamp = timestamp;
            this.Level = level;
            this.Message = message;
        }

        public LogEntry(DateTime timestamp, LogLevel level, string message, Exception ex)
        {
            this.Timestamp = timestamp;
            this.Level = level;
            this.Message = message;
            this.Exception = ex;
        }

        public override string ToString()
        {
            string exceptionInfo = Exception != null ? $"\tExcepción: {Exception}, StackTrace: {Exception.StackTrace}" : "";
            string userInfo = Usuario != null ? $"Usuario logueado: {Usuario.Nombre}, ID: {Usuario.IdUsuario}" : "";
            return $"[{Timestamp: yyyy-MM-dd HH:mm:ss.fff zzz}] [{Level.ToString().ToUpper()}] {Message} [Exception: {exceptionInfo}] [Usuario: {userInfo}]";
        }
    }
}
