using DebugAI.Application.Interfaces;
using DebugAI.Domain.Entities;
using MediatR;

namespace DebugAI.Application.Features.Logs.commands
{
    public class CreateLogCommandHandler : IRequestHandler<CreateLogsCommand, Guid>
    {
        private readonly ILogRepository _repo;
        private readonly IUnitOfWork _unitOfWork;

        public CreateLogCommandHandler(ILogRepository repo, IUnitOfWork unitOfWork)
        {
            _repo = repo;
            _unitOfWork = unitOfWork;
        }

        public async Task<Guid> Handle(CreateLogsCommand request, CancellationToken cancellationToken)
        {
            var log = new LogEntry
            {
                Id = Guid.NewGuid(),
                ApplicationName = request.ApplicationName,
                Message = request.Message,
                Level = request.Level,
                CreatedAt = DateTime.UtcNow
            };

            await _repo.AddAsync(log);
            await _unitOfWork.SaveChangesAsync(); // 🔥 IMPORTANT

            return log.Id;
        }
    }
}
