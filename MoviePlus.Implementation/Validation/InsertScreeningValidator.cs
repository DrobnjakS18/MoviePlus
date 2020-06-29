using FluentValidation;
using MoviePlus.Application.Dto;
using MoviePlus.DataAccess;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace MoviePlus.Implementation.Validation
{
    public class InsertScreeningValidator : AbstractValidator<ScreeningDto>
    {
        public InsertScreeningValidator(MoviePlusContext context)
        {
            //RuleFor(x => x.ScreeningTime)
            //   .NotEmpty()
            //   .Must(x => !context.Screenings.Any(u => u.ScreeningTime == x. && u.AuditoriumId == auditorumId))
            //   .WithMessage($"Screening Time in Auditorium {auditorumId} is already reserved.");
        }
    }
}
