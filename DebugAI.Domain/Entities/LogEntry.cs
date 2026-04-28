using System;
using System.Collections.Generic;
using System.Text;

namespace DebugAI.Domain.Entities
{
    public class LogEntry
    {
        public Guid Id { get; set; }
        public string ApplicationName { get; set; }
        public string Message { get; set; }
        public string Level { get; set; }
        public DateTime CreatedAt { get; set; }
    }
}
