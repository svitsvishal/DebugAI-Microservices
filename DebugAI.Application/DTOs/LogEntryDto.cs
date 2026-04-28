using System;
using System.Collections.Generic;
using System.Text;

namespace DebugAI.Application.DTOs;
    public class LogEntryDto
    {
        public string ApplicationName { get; set; }
        public string Message { get; set; }
        public string Level { get; set; }
    }

