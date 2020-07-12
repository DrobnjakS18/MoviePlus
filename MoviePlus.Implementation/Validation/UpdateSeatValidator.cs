using FluentValidation;
using MoviePlus.Application.Dto;
using MoviePlus.DataAccess;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace MoviePlus.Implementation.Validation
{
    public class UpdateSeatValidator : AbstractValidator<SeatUpdateDto>
    {
        public UpdateSeatValidator(MoviePlusContext context)
        {

            RuleFor(x => x.AuditoriumName)
            .NotEmpty()
            .Length(2, 40)
            .Must(name => context.Auditoriums.Any(a => a.Name == name))
            .WithMessage(dto => $"{dto.AuditoriumName} does not exists as Auditorium in database");

            RuleFor(x => x.Number)
             .NotEmpty()
             .GreaterThan(0)
             .Must((dto, number) => !context.Seats.Any(a => a.Number == number && a.Auditorium.Name == dto.AuditoriumName))
             .WithMessage(s => $"Seat number {s.Number} already exists in {s.AuditoriumName}");
        }
    }
}
