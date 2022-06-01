using System;

namespace BIT.LogService.Interfaces
{
    public interface ILogMessage
    {
        DateTime OccurDateTime { get; set; }

        LogLevel Level { get; set; }
        string Caller { get; set; }
        string Message { get; set; }
        string StackTrace { get; set; }
    }
}
