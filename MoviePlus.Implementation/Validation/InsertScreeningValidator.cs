using FluentValidation;
using MoviePlus.Application.Dto;
using MoviePlus.DataAccess;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;

namespace MoviePlus.Implementation.Validation
{
    public class InsertScreeningValidator : AbstractValidator<ScreeningDto>
    {
        public InsertScreeningValidator(MoviePlusContext context)
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
