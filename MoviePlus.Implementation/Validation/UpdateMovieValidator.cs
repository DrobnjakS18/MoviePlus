using FluentValidation;
using MoviePlus.Application.Dto;
using MoviePlus.DataAccess;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace MoviePlus.Implementation.Validation
{
    public class UpdateMovieValidator : AbstractValidator<MovieDto>
    {
        public UpdateMovieValidator(MoviePlusContext context)
        {
            RuleFor(x => x.Title)
                .NotEmpty()
                .Must((dto, name) => !context.Movies.Any(p => p.Title == name && p.Id != dto.Id))//Posto je update pitamo jos da li naziv proizvoda postoji vec unutar baze ali sa razlicitim ID
                .WithMessage("Title name already exists in database");

            RuleFor(x => x.Description)
                .NotEmpty()
                .Must((dto, name) => !context.Movies.Any(p => p.Description == name && p.Id != dto.Id))
                .WithMessage("Description name already exists in database");

            RuleFor(x => x.Duration)
                .NotEmpty()
                .GreaterThan(0)
                .LessThan(300);

            RuleFor(x => x.Image)
                .NotEmpty();
        }
    }
}
