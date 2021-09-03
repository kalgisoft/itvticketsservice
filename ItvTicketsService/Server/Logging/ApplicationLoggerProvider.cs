using ItvTicketsService.Server.Data;
using ItvTicketsService.Shared.Models;
using Microsoft.Extensions.Logging;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ItvTicketsService.Server.Logging
{
    public class ApplicationLoggerProvider : ILoggerProvider
    {
        private readonly ILogStore<Log> _context;

        public ApplicationLoggerProvider(ILogStore<Log> context)
        {
            _context = context;
        }

        public ILogger CreateLogger(string categoryName)
        {
            return new DatabaseLogger(_context);
        }

        public void Dispose()
        {
            
        }
    }
}
