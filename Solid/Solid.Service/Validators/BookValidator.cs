using FluentValidation;
using Solid.Domain.Entity;
using System;
using System.Collections.Generic;
using System.Text;

namespace Solid.Service.Validators
{
    public class BookValidator : AbstractValidator<BookEntity>
    {
        public BookValidator()
        {
            RuleFor(c => c)
                   .NotNull()
                   .OnAnyFailure(x =>
                   {
                       throw new ArgumentNullException("Can't found the object.");
                   });

            RuleFor(c => c.NmBook)
                .NotEmpty().WithMessage("Is necessary to inform the Book.")
                .NotNull().WithMessage("Is necessary to inform the Book.");

            RuleFor(c => c.IdCategory)
                .NotEmpty().WithMessage("Is necessáry to inform a category.")
                .NotNull().WithMessage("Is necessáry to inform a category.");

            RuleFor(c => c.VrBook)
                .NotEmpty().WithMessage("Is necessáry to inform a category.")
                .NotNull().WithMessage("Is necessáry to inform a category.")
                .ScalePrecision(100, 4, true);
        }
    }
}
