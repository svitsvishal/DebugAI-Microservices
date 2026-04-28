using DebugAI.Application.Features.Logs.commands;
using FluentValidation;
using System;
using System.Collections;
using System.Collections.Generic;
using System.Text;

namespace DebugAI.Application.Features.Logs.Commands
{
    public class CreateLogCommandValidator : AbstractValidator<CreateLogsCommand>
    {
        public CreateLogCommandValidator()
        {
            RuleFor(x => x.ApplicationName)
                .NotEmpty()
               // .EmailAddress()
                .MaximumLength(100);

            RuleFor(x => x.Message)
                .NotEmpty();

            RuleFor(x => x.Level)
                .NotEmpty()
                .Must(level => new[] { "Info", "Warning", "Error", "Critical" }
                .Contains(level))
                .WithMessage("Invalid log level");
        }
    }
}
