using DebugAI.Domain.Entities;
using MediatR;
using System;
using System.Collections.Generic;
using System.Text;

namespace DebugAI.Application.Features.Logs.Queries
{
    public class GetLogsQuery : IRequest<IEnumerable<LogEntry>>
    {
    }
}
