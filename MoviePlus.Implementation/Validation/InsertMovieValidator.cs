using FluentValidation;
using MoviePlus.Application.Dto;
using MoviePlus.DataAccess;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace MoviePlus.Implementation.Validation
{
    public class InsertMovieValidator : AbstractValidator<MovieDto>
    {

        public InsertMovieValidator(MoviePlusContext context)
        {
            RuleFor(x => x.Title)
                .NotEmpty()
                .Length(2,100)
                .Must(x => !context.Movies.Any(u => u.Title == x))
                .WithMessage("Title must be unique");

            RuleFor(x => x.Description)
                .NotEmpty()
                .Length(2, 1500)
                .Must(x => !context.Movies.Any(u => u.Description == x))
                .WithMessage("Description must be unique");

            RuleFor(x => x.Duration)
                .NotEmpty()
                .GreaterThan(0)
                .LessThan(300);

            RuleFor(x => x.Image)
                .NotEmpty();

            RuleFor(x => x.Date)
                .NotEmpty();

            RuleFor(x => x.Time)
                .NotEmpty();
        }
    }
}
