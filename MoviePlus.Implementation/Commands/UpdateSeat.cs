using FluentValidation;
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
    public class UpdateSeat : ISeatUpdate
    {
        private readonly MoviePlusContext _context;
        private readonly UpdateSeatValidator _validator;

        public UpdateSeat(MoviePlusContext context, UpdateSeatValidator validator)
        {
            _context = context;
            _validator = validator;
        }
        public int Id => 28;

        public string Name => "Update Seat";

        public void Execute(SeatUpdateDto request)
        {
            var seat = _context.Seats.Find(request.Id);

            if (seat == null)
            {
                throw new NotFoundException(request.Id, typeof(Seat));
            }

            _validator.ValidateAndThrow(request);

            seat.Number = request.Number;
            seat.AuditoriumId = _context.Auditoriums.Where(a => a.Name == request.AuditoriumName).First().Id;

            _context.SaveChanges();
        }
    }
}
