using Microsoft.EntityFrameworkCore;
using MoviePlus.Application;
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
    public class GetSingleSeatQuery : IGetSingleSeatQuery
    {
        private readonly MoviePlusContext _context;
        private readonly IApplicationUser _actor;

        public GetSingleSeatQuery(MoviePlusContext context, IApplicationUser actor)
        {
            _context = context;
            _actor = actor;
        }
        public int Id => 26;

        public string Name => "Get single Seat";

        public SeatDto Execute(int search)
        {
            var query = _context.Seats.Include(x => x.SeatReserveds).Include(x => x.Auditorium).AsQueryable();

            var seat = query.FirstOrDefault(s => s.Id == search);

            if (seat == null)
            {
                throw new NotFoundException(search, typeof(Seat));
            }

            var response = new SeatDto
            {
                Id = seat.Id,
                Number = seat.Number,
                AuditoriumName = seat.Auditorium.Name,
                SeatReserved = seat.SeatReserveds.Select(r => new SeatReservations
                {
                    RezervationId = r.ReservationId,
                    ScreeningTime = r.Screening.ScreeningTime
                })
            };


            return response;

        }
    }
}
