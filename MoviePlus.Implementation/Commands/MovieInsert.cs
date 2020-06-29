﻿using FluentValidation;
using MoviePlus.Application.Commands;
using MoviePlus.Application.Dto;
using MoviePlus.Application.Exceptions;
using MoviePlus.DataAccess;
using MoviePlus.Domain;
using MoviePlus.Implementation.Validation;
using System;
using System.Collections.Generic;
using System.Linq;
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
            var auditorumId = int.Parse(request.Auditorium);

            var splitDate = request.Date.Split('-');

            var searchDate = new DateTime(int.Parse(splitDate[0]), int.Parse(splitDate[1]), int.Parse(splitDate[2]), int.Parse(request.Time), 0, 0);

             _validator.ValidateAndThrow(request);


            var movie = new Movie
                {

                    Title = request.Title,
                    Description = request.Description,
                    Duration = request.Duration,
                    Image = request.Image
                };

            using (var transaction = _context.Database.BeginTransaction())
            {
                try
                {
                    _context.Movies.Add(movie);
                    _context.SaveChanges();

                    var lastMovie = _context.Movies.Max(item => item.Id);

                    var screening = new Screening
                    {
                        MovieId = lastMovie,
                        AuditoriumId = auditorumId,
                        ScreeningTime = searchDate
                    };

                    _context.Screenings.Add(screening);
                    _context.SaveChanges();

                    transaction.Commit();
                }
                catch (Exception)
                {
                    transaction.Rollback();
                }
            }
        }
    }
}
