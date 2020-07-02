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
    public class GetSingleScreeningQuery : IGetSingleScreeningQuery
    {
        private readonly MoviePlusContext _context;

        public GetSingleScreeningQuery(MoviePlusContext context)
        {
            _context = context;
        }
        public int Id => 17;

        public string Name => "Update Screening TIme";

        public ScreeningDto Execute(int search)
        {
            var screning = _context.Screenings.Find(search);

            if (screning == null)
            {
                new NotFoundException(search, typeof(Screening));
            }

            var response = new ScreeningDto
            {
                Id = screning.Id,
                MovieId = screning.MovieId,
                AuditoriumId = screning.AuditoriumId,
                ScreeningTime = screning.ScreeningTime
            };

            return response;
        }
    }
}
