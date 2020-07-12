using Microsoft.EntityFrameworkCore;
using MoviePlus.Application.Dto;
using MoviePlus.Application.Queries;
using MoviePlus.Application.Searches;
using MoviePlus.DataAccess;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace MoviePlus.Implementation.Queries
{
    public class GetSeatsQuery : IGetSeatsQuery
    {
        private readonly MoviePlusContext _context;

        public GetSeatsQuery(MoviePlusContext context)
        {
            _context = context;
        }
        public int Id => 25;

        public string Name => "Search Seats";

        public PageResponse<SeatDto> Execute(SeatSearch search)
        {
            var query = _context.Seats.Include(s => s.SeatReserveds).AsQueryable();

            if (!string.IsNullOrEmpty(search.Auditorium) || !string.IsNullOrWhiteSpace(search.Auditorium))
            {
                query = query.Where(x => x.Auditorium.Name.ToLower().Contains(search.Auditorium.ToLower()));

            }

            if (search.MinSeatNumber != 0)
            {
                query = query.Where(x => x.Number >= search.MinSeatNumber);
            }
            if (search.MaxSeatNumber != 0)
            {
                query = query.Where(x => x.Number <= search.MaxSeatNumber);
            }

            var skipCount = search.ItemsPerPage * (search.CurrentPage - 1);

            var response = new PageResponse<SeatDto>
            {
                TotalCount = query.Count(),
                CurrentPage = search.CurrentPage,
                ItemsPerPage = search.ItemsPerPage,
                Items = query.Skip(skipCount)
                          .Take(search.ItemsPerPage)
                          .Select(s => new SeatDto
                          {
                              Id = s.Id,
                              Number = s.Number,
                              AuditoriumName = s.Auditorium.Name,
                              SeatReserved = s.SeatReserveds.Select(r =>new SeatReservations
                              { 
                                RezervationId = r.ReservationId,
                                ScreeningTime = r.Screening.ScreeningTime
                              })
                          }).ToList()
            };

            return response;
        }
    }
}
