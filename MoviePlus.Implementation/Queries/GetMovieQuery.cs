using Microsoft.EntityFrameworkCore;
using MoviePlus.Application.Dto;
using MoviePlus.Application.Exceptions;
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
            var query = _context.Movies.AsQueryable();

            //admin panel
            if (!string.IsNullOrWhiteSpace(search.Time) || !string.IsNullOrWhiteSpace(search.Date))
            {
                var splitDate = search.Date.Split('-');

                var searchDate = new DateTime(int.Parse(splitDate[0]), int.Parse(splitDate[1]), int.Parse(splitDate[2]), int.Parse(search.Time), 0, 0);

                query = query.Where(m => m.Screenings.Where(s => s.ScreeningTime == searchDate).Any());
            }


            if (!string.IsNullOrEmpty(search.Title) || !string.IsNullOrWhiteSpace(search.Title))
            {
                query = query.Where(x => x.Title.ToLower().Contains(search.Title.ToLower()));
            }

            if (!string.IsNullOrEmpty(search.Description) || !string.IsNullOrWhiteSpace(search.Description))
            {
                query = query.Where(x => x.Description.ToLower().Contains(search.Description.ToLower()));
            }

            var skipCount = search.ItemsPerPage * (search.CurrentPage - 1);

            var response = new PageResponse<MovieDto>
            {

                TotalCount = query.Count(),
                ItemsPerPage = search.ItemsPerPage,
                CurrentPage = search.CurrentPage,
                Items = query.Skip(skipCount).Take(search.ItemsPerPage).Select(x => new MovieDto
                {
                    Id = x.Id,
                    Title = x.Title,
                    Description = x.Description,
                    Duration = x.Duration,
                    Image = x.Image,
                    Screening = x.Screenings.Select(s => new ScreeningDto
                    {
                        Id = s.Id,
                        ScreeningTime = s.ScreeningTime,
                        MovieId = s.MovieId,
                        AuditoriumName = s.Auditorium.Name,
                        AuditoriumId = s.Auditorium.Id
                    }).ToList()
                }).ToList()
            };

            return response;
        }
    }
} 
