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

        public int Id => 3;

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


            if(!string.IsNullOrEmpty(search.Date) || !string.IsNullOrWhiteSpace(search.Date))
            {

                //query = (IQueryable<Domain.Movie>)query.Select(x => x.Screenings.Select(s => s.ScreeningTime).Where(t => t.ToString("yyyy-MM-dd") == search.Date));

                //var screening = _context.Screenings;
                //var movieIds = screening.Select(t => t.MovieId);


                //foreach (var ids in movieIds)
                //{
                //    var date = datum.ToString("yyyy-MM-dd");

                //    if (date == search.Date)
                //    {
                //        //query = query.Where(x => x.Id == screening);
                //    }
                //}


                //query = query.Where(x => x.Id == x.Screenings.Select(t => t.MovieId));


                //foreach (var datum in screeningDate)
                //{
                //    var date = datum.ToString("yyyy-MM-dd");

                //    if (date == search.Date) {
                //        //query = query.Where(x => x.Id == screening);
                //    }
                //}
            }



            //query = query.Where(x => x.Screenings.Select(t => t.ScreeningTime));

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
