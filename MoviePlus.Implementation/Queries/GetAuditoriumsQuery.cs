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
    public class GetAuditoriumsQuery : IGetAuditoirumsQuery
    {
        private readonly MoviePlusContext _context;

        public GetAuditoriumsQuery(MoviePlusContext context)
        {
            _context = context;
        }

        public int Id => 20;

        public string Name => "Search Auditoirums";

        public PageResponse<AuditoriumDto> Execute(AuditoriumSearch search)
        {
            var query = _context.Auditoriums.Include(a => a.Seats).Include(a => a.Screenings).AsQueryable();

            if (!string.IsNullOrEmpty(search.Name) || !string.IsNullOrWhiteSpace(search.Name))
            {
                query = query.Where(x => x.Name.ToLower().Contains(search.Name.ToLower()));

            }


            var skipCount = search.ItemsPerPage * (search.CurrentPage - 1);

            var response = new PageResponse<AuditoriumDto>
            {
                TotalCount = query.Count(),
                CurrentPage = search.CurrentPage,
                ItemsPerPage = search.ItemsPerPage,
                Items = query.Skip(skipCount)
                             .Take(search.ItemsPerPage)
                             .Select(a => new AuditoriumDto
                             {
                                 Id = a.Id,
                                 Name = a.Name,
                                 CreatedAt = a.CreatedAt,
                                 AuditoirumSeats = a.Seats.Select(s => new AuditoirumSeats
                                 {
                                     Id = s.Id,
                                     Number = s.Number,
                                 })
                             }).ToList()
            };

            return response;


        }
    }
}
