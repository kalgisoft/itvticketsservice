using ItvTicketsService.Server.Data;
using ItvTicketsService.Shared.Models;
using Microsoft.Extensions.Logging;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ItvTicketsService.Server.Logging
{
    public class DatabaseLogger : ILogger
    {
        private readonly ILogStore<Log> _context;

        public DatabaseLogger(ILogStore<Log> context)
        {
            _context = context;
        }

        public IDisposable BeginScope<TState>(TState state)
        {
            return null;
        }

        public bool IsEnabled(LogLevel logLevel)
        {
            return true;
        }

        public void Log <TState>(LogLevel logLevel, EventId eventId, TState state, Exception exception, Func<TState, Exception, string> formatter)
        {
            if (exception == null) return; //nessun log

            Log log = new Log();
            log.LogLevel = logLevel.ToString();
            log.EventName = eventId.Name;
            log.ExceptionMessage = exception.Message;
            log.StackTrace = exception.StackTrace;
            log.Source = "Server";
            log.CreatedDate = DateTime.Now.ToString();

            //insert to database
            _context.LogInsert(log);
        }
    }
}
