using FluentValidation;
using Solid.Domain.Entity;
using System;
using System.Collections.Generic;
using System.Text;

namespace Solid.Service.Validators
{
    public class CategoryValidator : AbstractValidator<CategoryEntity>
    {
        public CategoryValidator()
        {
            RuleFor(c => c)
                    .NotNull()
                    .OnAnyFailure(x =>
                    {
                        throw new ArgumentNullException("Can't found the object.");
                    });

            RuleFor(c => c.NmCategory)
                .NotEmpty().WithMessage("Is necessary to inform the Category.")
                .NotNull().WithMessage("Is necessary to inform the Category.");
        }
    }
}
