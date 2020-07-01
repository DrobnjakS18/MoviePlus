using Microsoft.EntityFrameworkCore;
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


            if (user != null)
            {

                return new UserDto
                {

                    Id = user.Id,
                    FirstName = user.FirstName,
                    LastName = user.LastName,
                    Email = user.Email,
                    Username = user.Username,
                    //Koristiti include za dohvatenje podataka iz vezivnih tabela
                    Tickets = _context.Reservations.Include(u => u.User).Include(s => s.Screening).Where(u => u.UserId == user.Id).Select(r => new MovieDto
                    {
                        Id = r.Screening.Movie.Id,
                        Title = r.Screening.Movie.Title,
                        Description = r.Screening.Movie.Description,
                        Duration = r.Screening.Movie.Duration,
                        Image = r.Screening.Movie.Image,
                        ScreeningTime = r.Screening.ScreeningTime,
                        Auditorium = r.Screening.Auditorium.Name
                    }).ToList()

            };

            }
            else {
                return null;
            }
        }
    }
}
