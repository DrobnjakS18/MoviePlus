using FluentValidation;
using MoviePlus.Application.Commands;
using MoviePlus.Application.Dto;
using MoviePlus.DataAccess;
using MoviePlus.Domain;
using MoviePlus.Implementation.Validation;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace MoviePlus.Implementation.Commands
{
    public class SeatInsert : ISeatInsert
    {
        private readonly MoviePlusContext _context;
        private readonly InsertSeatValidator _validator;

        public SeatInsert(MoviePlusContext context, InsertSeatValidator validator)
        {
            _context = context;
            _validator = validator;

        }
        public int Id => 27;

        public string Name => "Seat insert";

        public void Execute(SeatInsertDto request)
        {
            _validator.ValidateAndThrow(request);

            var seat = new Seat
            {
                Number = request.Number,
                AuditoriumId = _context.Auditoriums.Where(a => a.Name == request.AuditoriumName).First().Id
            };

            _context.Seats.Add(seat);
            _context.SaveChanges();
        }
    }
}
