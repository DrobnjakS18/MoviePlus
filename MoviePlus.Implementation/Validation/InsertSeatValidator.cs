using FluentValidation;
using MoviePlus.Application.Dto;
using MoviePlus.DataAccess;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace MoviePlus.Implementation.Validation
{
    public class InsertSeatValidator : AbstractValidator<SeatInsertDto>
    {

        public InsertSeatValidator(MoviePlusContext context)
        {
            RuleFor(x => x.Number)
                .NotEmpty()
                .GreaterThan(0)
                .Must((dto, number) => !context.Seats.Any(a => a.Number == number && a.Auditorium.Name == dto.AuditoriumName))
                .WithMessage(s => $"Seat number {s.Number} already exists in {s.AuditoriumName}");

            RuleFor(x => x.AuditoriumName)
                .NotEmpty()
                .Length(2, 40)
                .Must(name => context.Auditoriums.Any(a => a.Name == name))
                .WithMessage(name => $"{name.AuditoriumName} does not exists as Auditorium in database");
        }
    }
}
