using MoviePlus.Application.Dto;
using MoviePlus.Application.Exceptions;
using MoviePlus.Application.Queries;
using MoviePlus.DataAccess;
using MoviePlus.Domain;
using System;
using System.Collections.Generic;
using System.Text;

namespace MoviePlus.Implementation.Queries
{
    public class GetReservation : IGetReservationQuery
    {
        private readonly MoviePlusContext _context;
        public GetReservation(MoviePlusContext context)
        {
            _context = context;
        }

        public int Id => 19;

        public string Name => "Get Reservation";

        public ReservationDto Execute(int search)
        {
            var reservation = _context.Reservations.Find(search);

            if (reservation == null)
            {
                new NotFoundException(search, typeof(Reservation));
            }

            var response = new ReservationDto
            {
                Id = reservation.Id,
                UserId = reservation.UserId,
                ScreeningId = reservation.ScreeningId
            };

            return response;
        }
    }
}
