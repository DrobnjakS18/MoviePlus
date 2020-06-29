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
    public class MovieInsert : IMovieInsert
    {

        private readonly MoviePlusContext _context;
        private readonly InsertMovieValidator _validator;

        public MovieInsert(MoviePlusContext context, InsertMovieValidator validator)
        {
            _context = context;
            _validator = validator;

        }
        public int Id => 7;

        public string Name => "Insert movie";

        public void Execute(MovieDto request)
        {
            var splitDate = request.Date.Split('-');

            var searchDate = new DateTime(int.Parse(splitDate[0]), int.Parse(splitDate[1]), int.Parse(splitDate[2]), int.Parse(request.Time), 0, 0);

            if (searchDate != null)
            {
                _validator.ValidateAndThrow(request);

                var movie = new Movie
                {

                    Title = request.Title,
                    Description = request.Description,
                    Duration = request.Duration,
                    Image = request.Image
                };

                _context.Add(movie);
                _context.SaveChanges();
            }



        }
    }
}
