using FluentValidation;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HireLATAM.Application.Features.Commands.CreateItem
{
    public class CreateItemCommandValidator : AbstractValidator<CreateItemCommand>
    {
        public CreateItemCommandValidator()
        {
            RuleFor(w => w.Name)
             .NotEmpty().WithMessage("{PropertyName} cannot be empty")
             .NotNull().WithMessage("{PropertyName} is required");
            RuleFor(w => w.Description)
             .NotEmpty().WithMessage("{PropertyName} cannot be empty")
             .NotNull().WithMessage("{PropertyName} is required");
        }
    }
}
