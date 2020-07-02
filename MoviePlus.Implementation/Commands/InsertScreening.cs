using FluentValidation;
using MoviePlus.Application.Commands;
using MoviePlus.Application.Dto;
using MoviePlus.DataAccess;
using MoviePlus.Domain;
using MoviePlus.Implementation.Validation;
using System;
using System.Collections.Generic;
using System.Text;

namespace MoviePlus.Implementation.Commands
{
    public class InsertScreening : IScreeningInsert
    {
        private readonly MoviePlusContext _context;
        private readonly InsertScreeningValidator _validator;

        public InsertScreening(MoviePlusContext context, InsertScreeningValidator validator)
        {
            _context = context;
            _validator = validator;

        }

        public int Id => 15;

        public string Name => "Insert Screening";

        public void Execute(ScreeningDto request)
        {

            var splitDate = request.Date.Split('-');

            var searchDate = new DateTime(int.Parse(splitDate[0]), int.Parse(splitDate[1]), int.Parse(splitDate[2]), int.Parse(request.Time), 0, 0);

            var modifiedRequest = new ScreeningDto
            {
                MovieId = request.MovieId,
                AuditoriumId = request.AuditoriumId,
                ScreeningTime = searchDate
            };

            _validator.ValidateAndThrow(modifiedRequest);

            var screening = new Screening
            {
                MovieId = request.MovieId,
                AuditoriumId = request.AuditoriumId,
                ScreeningTime = searchDate
            };

            _context.Screenings.Add(screening);

            _context.SaveChanges();

        }
    }
}
