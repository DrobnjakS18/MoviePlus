using Microsoft.EntityFrameworkCore;
using MoviePlus.Application.Dto;
using MoviePlus.Application.Queries;
using MoviePlus.Application.Searches;
using MoviePlus.DataAccess;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.Xml;
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

            //var splitDate = search.Date.Split('-');

            //var searchDate = new DateTime(int.Parse(splitDate[0]) , int.Parse(splitDate[1]), int.Parse(splitDate[2]), int.Parse(search.Time), 0, 0);

            //U slucaju da query nije prazan odradjujemo where
            if (!string.IsNullOrEmpty(search.Title) || !string.IsNullOrWhiteSpace(search.Title))
            {
                query = query.Where(x => x.Title.ToLower().Contains(search.Title.ToLower()));
            }

            if (!string.IsNullOrEmpty(search.Description) || !string.IsNullOrWhiteSpace(search.Description))
            {
                query = query.Where(x => x.Description.ToLower().Contains(search.Description.ToLower()));
            }

            //query = query.Where(x => x.Screenings.Select(a => a.ScreeningTime).Equals(searchDate));

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
                    ScreeningTime = x.Screenings.Where(s => s.MovieId == x.Id).Select(a => new ScreeningDto
                    {
                        Id = a.Id,
                        Auditorium = a.Auditorium.Name,
                        Seats = a.Auditorium.Seats.Where(se => se.AuditoriumId == a.Id).Count(),
                        ScreeningTime = a.ScreeningTime
                    }).ToList()
                }).ToList()
            };

            return response;
        }
    }
} 
