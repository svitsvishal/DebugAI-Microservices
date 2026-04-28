using MediatR;
using System;
using System.Collections.Generic;
using System.Text;

namespace DebugAI.Application.Features.Logs.commands
{
    public class CreateLogsCommand :IRequest<Guid>
    {
        public string ApplicationName { get; set; }
        public string Message { get; set; }
        public string Level { get; set; }
    }
}
