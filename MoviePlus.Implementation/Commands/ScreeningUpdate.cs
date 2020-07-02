using FluentValidation;
using MoviePlus.Application.Commands;
using MoviePlus.Application.Dto;
using MoviePlus.Application.Exceptions;
using MoviePlus.DataAccess;
using MoviePlus.Implementation.Validation;
using System;
using System.Collections.Generic;
using System.Text;

namespace MoviePlus.Implementation.Commands
{
    public class ScreeningUpdate : IScreeningUpdate
    {
        private readonly MoviePlusContext _context;
        private readonly UpdateScreeningValidator _validator;

        public ScreeningUpdate(MoviePlusContext context, UpdateScreeningValidator validator)
        {
            _context = context;
            _validator = validator;

        }
        public int Id => 18;

        public string Name => "Update Screening Time";

        public void Execute(ScreeningDto request)
        {
            var screening = _context.Screenings.Find(request.Id);

            if (screening == null)
            {
                throw new NotFoundException(request.Id, typeof(ScreeningDto));
            }


            var splitDate = request.Date.Split('-');

            var searchDate = new DateTime(int.Parse(splitDate[0]), int.Parse(splitDate[1]), int.Parse(splitDate[2]), int.Parse(request.Time), 0, 0);


            var modifiedRequest = new ScreeningDto
            {
                MovieId = request.MovieId,
                AuditoriumId = request.AuditoriumId,
                ScreeningTime = searchDate
            };

            _validator.ValidateAndThrow(modifiedRequest);


            screening.MovieId = request.MovieId;
            screening.AuditoriumId = request.AuditoriumId;
            screening.ScreeningTime = searchDate;

            _context.SaveChanges();
        }
    }
}
