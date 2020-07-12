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
    public class GetSingleAuditoriumQuery : IGetSingleAuditoriumQuery
    {
        private readonly MoviePlusContext _context;
        private readonly IApplicationUser _actor;

        public GetSingleAuditoriumQuery(MoviePlusContext context, IApplicationUser actor)
        {
            _context = context;
            _actor = actor;
        }

        public int Id => 21;

        public string Name => "Get Single Auditorium";

        public AuditoriumDto Execute(int search)
        {
            var query = _context.Auditoriums.Include(x => x.Seats).AsQueryable();

            var auditoirum = query.FirstOrDefault(a => a.Id == search);

            if (auditoirum == null) {

                throw new NotFoundException(search, typeof(Auditorium));
            }

            var response = new AuditoriumDto
            {
                Id = auditoirum.Id,
                Name = auditoirum.Name,
                CreatedAt = auditoirum.CreatedAt,
                AuditoirumSeats = auditoirum.Seats.Select(s => new AuditoirumSeats
                {
                    Id = s.Id,
                    Number = s.Number
                })

            };

            return response;
        }
    }
}
