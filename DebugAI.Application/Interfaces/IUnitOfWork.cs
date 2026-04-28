using System;
using System.Collections.Generic;
using System.Text;

namespace DebugAI.Application.Interfaces
{
    public interface IUnitOfWork
    {
        Task<int> SaveChangesAsync();
    }
}
