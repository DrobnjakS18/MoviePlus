using FluentValidation;
using MoviePlus.Application.Dto;
using MoviePlus.DataAccess;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace MoviePlus.Implementation.Validation
{
    public class UpdateAuditoriumValidator : AbstractValidator<AuditoriumUpdateDto>
    {
        public UpdateAuditoriumValidator(MoviePlusContext context)
        {
            RuleFor(x => x.Name)
             .Must((dto, name) => !context.Auditoriums.Any(a => a.Name == name && a.Id != dto.Id))
             .WithMessage(a => $"Auditorium ({a.Name}) already exists in database");

        }
    }
}
