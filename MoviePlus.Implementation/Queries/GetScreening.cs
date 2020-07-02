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
    public class GetScreening : IGetScreeningQuery
    {
        private readonly MoviePlusContext _context;
        public GetScreening(MoviePlusContext context)
        {
            _context = context;
        }
        public int Id => 14;

        public string Name => "Get Screening Time";

        public PageResponse<ScreeningDto> Execute(ScreeningSearch search)
        {
            var query = _context.Screenings.AsQueryable();

            var skipCount = search.ItemsPerPage * (search.CurrentPage - 1);

            var response = new PageResponse<ScreeningDto>
            {

                TotalCount = query.Count(),
                ItemsPerPage = search.ItemsPerPage,
                CurrentPage = search.CurrentPage,
                //Skip(skipCount) - broj podataka koji se preskace
                Items = query.Skip(skipCount).Take(search.ItemsPerPage).Select(x => new ScreeningDto
                {
                    Id = x.Id,
                    MovieName = x.Movie.Title,
                    AuditoriumName = x.Auditorium.Name,
                    ScreeningTime = x.ScreeningTime
                }).ToList()
            };

            return response;
        }
    }
}
