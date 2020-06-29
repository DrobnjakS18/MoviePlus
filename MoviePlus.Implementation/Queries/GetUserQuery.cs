using MoviePlus.Application.Dto;
using MoviePlus.Application.Exceptions;
using MoviePlus.Application.Queries;
using MoviePlus.DataAccess;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace MoviePlus.Implementation.Queries
{
    public class GetUserQuery : IGetUserQuery
    {

        private readonly MoviePlusContext _context;

        public GetUserQuery(MoviePlusContext context)
        {
            _context = context;
        }

        public int Id => 6;

        public string Name => "Get single User";

        public UserDto Execute(int search)
        {
            var user = _context.Users.Find(search);

            //var Id = user. Reservation.Screening.Movie.Id;

            if (user != null)
            {

                return new UserDto
                {

                    Id = user.Id,
                    FirstName = user.FirstName,
                    LastName = user.LastName,
                    Email = user.Email,
                    Username = user.Username,
                    Ticket = new MovieDto {
                        Id = user.Reservation.Screening.Movie.Id,
                        Title = user.Reservation.Screening.Movie.Title,
                        Description = user.Reservation.Screening.Movie.Description,
                        Duration = user.Reservation.Screening.Movie.Duration,
                    }
            };
            }
            else {
                return null;
            }
        }
    }
}
