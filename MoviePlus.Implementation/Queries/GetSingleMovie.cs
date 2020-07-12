using Microsoft.EntityFrameworkCore;
using MoviePlus.Application.Dto;
using MoviePlus.Application.Exceptions;
using MoviePlus.Application.Queries;
using MoviePlus.DataAccess;
using MoviePlus.Domain;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace MoviePlus.Implementation.Queries
{
    public class GetSingleMovie : IGetSIngleMovieQuery
    {
        private readonly MoviePlusContext _context;

        public GetSingleMovie(MoviePlusContext context)
        {
            _context = context;
        }

        public int Id => 9;

        public string Name => "get single Movie";

        public MovieDto Execute(int search)
        {
            var movie = _context.Movies.Find(search);

            if (movie == null)
            {
               throw new NotFoundException(search, typeof(Movie));
            }

            var response = new MovieDto
            {
                Id = movie.Id,
                Title = movie.Title,
                Description = movie.Description,
                Duration = movie.Duration,
                Image = movie.Image,
            };

            return response;
    }
    }
}
