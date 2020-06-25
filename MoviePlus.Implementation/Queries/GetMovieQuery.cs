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
    public class GetMovieQuery : IGetMovieQuery
    {
        private readonly MoviePlusContext _context;

        public GetMovieQuery(MoviePlusContext context)
        {
            _context = context;
        }

        public int Id => 2;

        public string Name => "Get movies";

        public PageResponse<MovieDto> Execute(MovieSearch search)
        {
            //gradimo query
            var query = _context.Movies.AsQueryable();

            //U slucaju da query nije prazan odradjujemo where
            if (!string.IsNullOrEmpty(search.Title) || !string.IsNullOrWhiteSpace(search.Title))
            {
                query = query.Where(x => x.Title.ToLower().Contains(search.Title.ToLower()));
            }

            if (!string.IsNullOrEmpty(search.Description) || !string.IsNullOrWhiteSpace(search.Description))
            {
                query = query.Where(x => x.Description.ToLower().Contains(search.Description.ToLower()));
            }

            //if (!string.IsNullOrEmpty(search.Duration.ToString()) || !string.IsNullOrWhiteSpace(search.Duration.ToString()))
            //{
            //    query = query.Where(x => x.Duration <= search.Duration);
            //}

            //Predstavlja broj podataka koje treba da preskoci
            var skipCount = search.ItemsPerPage * (search.CurrentPage - 1);

            //Obavezno je na kraju dodati .ToList()
            var response = new PageResponse<MovieDto>
            {
                TotalCount = query.Count(),
                ItemsPerPage = search.ItemsPerPage,
                CurrentPage = search.CurrentPage,
                //Skip(skipCount) - broj podataka koji se preskace
                Items = query.Skip(skipCount).Take(search.ItemsPerPage).Select(x => new MovieDto
                {
                    Id = x.Id,
                    Title = x.Title,
                    Description = x.Description,
                    Duration = x.Duration,

                }).ToList()
            };

            return response;
        }
    }
}
