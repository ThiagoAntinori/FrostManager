using Services.Domain.Security;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.Json.Serialization;
using System.Threading.Tasks;

namespace Services.Domain.Logging
{
    public class LogEntry
    {
        public DateTime Timestamp { get; set; }
        public LogLevel Level { get; set; }
        public string Message { get; set; }
        public string ExceptionString { get; set; }
        public string ExceptionStackTrace { get; set; }
        public Usuario Usuario { get; set; }
        [JsonIgnore]
        public Exception Exception { get; set; }

        public LogEntry()
        {

        }

        public LogEntry(DateTime timestamp, LogLevel level, string message)
        {
            this.Timestamp = timestamp;
            this.Level = level;
            this.Message = message;
            this.Exception = null;
            this.ExceptionString = null;
            this.ExceptionStackTrace = null;
            this.Usuario = UsuarioLogueado.Current != null ? UsuarioLogueado.Current.Usuario : null;
        }

        public LogEntry(DateTime timestamp, LogLevel level, string message, Exception ex)
        {
            this.Timestamp = timestamp;
            this.Level = level;
            this.Message = message;
            this.Exception = ex;
            this.ExceptionString = ex.ToString();
            this.ExceptionStackTrace = ex.StackTrace;
            this.Usuario = UsuarioLogueado.Current != null ? UsuarioLogueado.Current.Usuario : null;
        }

        public override string ToString()
        {
            string exceptionInfo = Exception != null ? $"Excepción: {ExceptionString}, StackTrace: {ExceptionStackTrace}" : "";
            string userInfo = Usuario != null ? $"Usuario logueado: {Usuario.Nombre}, ID: {Usuario.IdUsuario}" : "";
            return $"[{Timestamp:yyyy-MM-dd HH:mm:ss.fff zzz}] [{Level.ToString().ToUpper()}] {Message} [{exceptionInfo}] [{userInfo}]";
        }
    }
}
