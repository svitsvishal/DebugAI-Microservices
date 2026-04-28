using System;
using System.Collections.Generic;
using System.Text;
using DebugAI.Domain.Entities;

namespace DebugAI.Application.Interfaces
{
    public interface ILogRepository
    {
        Task AddAsync(LogEntry log);
        Task<IEnumerable<LogEntry>> GetAllAsync();
    }
}
