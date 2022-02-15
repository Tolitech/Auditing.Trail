using System;
using FluentValidation;

namespace Tolitech.CodeGenerator.Auditing.Trail.Commands.InsertItems
{
    public class InsertItemsCommandValidator : AbstractValidator<InsertItemsCommand>
    {
        public InsertItemsCommandValidator()
        {
            RuleFor(x => x.Items)
                .NotEmpty();
        }
    }
}
