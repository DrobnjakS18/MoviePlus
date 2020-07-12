using FluentValidation;
using Microsoft.EntityFrameworkCore.Internal;
using MoviePlus.Application.Dto;
using MoviePlus.DataAccess;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace MoviePlus.Implementation.Validation
{
    public class InsertAuditoriumValidator : AbstractValidator<AuditoriumDto>
    {

        public InsertAuditoriumValidator(MoviePlusContext context)
        {
            RuleFor(x => x.Name)
                .NotEmpty()
                .Length(2, 40)
                .Must(x => !context.Auditoriums.Any(a => a.Name == x))
                .WithMessage("Auditorium name must be unique");
        }
    }
}
