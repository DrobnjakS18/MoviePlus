using FluentValidation;
using MoviePlus.Application.Commands;
using MoviePlus.Application.Dto;
using MoviePlus.Application.Exceptions;
using MoviePlus.DataAccess;
using MoviePlus.Domain;
using MoviePlus.Implementation.Validation;
using System;
using System.Collections.Generic;
using System.Text;

namespace MoviePlus.Implementation.Commands
{
    public class UpdateMovie : IMovieUpdate
    {
        private readonly MoviePlusContext _context;
        private readonly UpdateMovieValidator _validator;

        public UpdateMovie(MoviePlusContext context, UpdateMovieValidator validator)
        {
            _context = context;
            _validator = validator;

        }
        public int Id => 10;

        public string Name => "Update movie";

        public void Execute(MovieDto request)
        {
            var movie = _context.Movies.Find(request.Id);

            if (movie == null) {

                throw new NotFoundException(request.Id, typeof(MovieDto));
            }

            _validator.ValidateAndThrow(request);

            movie.Title = request.Title;
            movie.Description = request.Description;
            movie.Duration = request.Duration;
            movie.Image = request.Image;
            movie.UpdatedAt = DateTime.Now;

            _context.SaveChanges();
        }
    }
}
