using DebugAI.Application.Interfaces;
using DebugAI.Domain.Entities;
using DebugAI.Infrastructure.Persistence;
using Microsoft.EntityFrameworkCore;


namespace DebugAI.Infrastructure.Repositories
{
    public class LogRepository : ILogRepository
    {
        private readonly AppDbContext _context;

        public LogRepository(AppDbContext context)
        {
            _context = context;
        }

        public async Task AddAsync(LogEntry log)
        {
            await _context.Logs.AddAsync(log);
        }

        public async Task<IEnumerable<LogEntry>> GetAllAsync()
        {
            return await _context.Logs
                .OrderByDescending(x => x.CreatedAt)
                .ToListAsync();
        }
    }
}
