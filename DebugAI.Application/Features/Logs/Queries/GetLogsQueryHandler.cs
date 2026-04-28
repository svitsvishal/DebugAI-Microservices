using DebugAI.Application.Interfaces;
using DebugAI.Domain.Entities;
using MediatR;

namespace DebugAI.Application.Features.Logs.Queries;

public class GetLogsQueryHandler : IRequestHandler<GetLogsQuery, IEnumerable<LogEntry>>
{
    private readonly ILogRepository _repo;

    public GetLogsQueryHandler(ILogRepository repo)
    {
        _repo = repo;
    }

    public async Task<IEnumerable<LogEntry>> Handle(GetLogsQuery request, CancellationToken cancellationToken)
    {
        return await _repo.GetAllAsync();
    }
}