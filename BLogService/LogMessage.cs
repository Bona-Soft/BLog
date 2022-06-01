using System;
using BIT.LogService.Interfaces;

namespace BIT.LogService
{
    public class LogMessage : ILogMessage
    {
        public DateTime OccurDateTime { get; set; }

        public LogLevel Level { get; set; }
        public string Caller { get; set; }
        public string Message { get; set; }
        public string StackTrace { get; set; }
    }
}
