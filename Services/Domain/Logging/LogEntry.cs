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

        public LogEntry(DateTime timestamp, LogLevel level, string message)
        {
            this.Timestamp = timestamp;
            this.Level = level;
            this.Message = message;
        }

        public override string ToString()
        {
            return $"[{Timestamp: yyyy-MM-dd HH:mm:ss.fff zzz}] [{Level}] {Message}";
        }
    }
}
