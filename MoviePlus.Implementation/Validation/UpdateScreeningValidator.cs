using FluentValidation;
using MoviePlus.Application.Dto;
using MoviePlus.DataAccess;
using System;
using System.Collections.Generic;
using System.Text;

namespace MoviePlus.Implementation.Validation
{
    public class UpdateScreeningValidator : AbstractValidator<ScreeningDto>
    {
        public UpdateScreeningValidator(MoviePlusContext context)
        {
            RuleFor(x => x.MovieId)
            .NotEmpty();

            RuleFor(x => x.AuditoriumId)
            .NotEmpty();

            RuleFor(x => x.ScreeningTime)
              .NotEmpty()
              .GreaterThan(DateTime.Now)
              .WithMessage("Date must not be in past");
        }
    }
}
