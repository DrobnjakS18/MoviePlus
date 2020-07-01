using MoviePlus.Application.Commands;
using MoviePlus.Application.Dto;
using MoviePlus.Application.Exceptions;
using MoviePlus.DataAccess;
using MoviePlus.Domain;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace MoviePlus.Implementation.Commands
{
    public class DeleteMovie : IDeleteMovie
    {
        private readonly MoviePlusContext _context;

        public DeleteMovie(MoviePlusContext context)
        {
            _context = context;
        }
        public int Id => 8;

        public string Name => "Delete movie";

        public void Execute(int request)
        {
            var movie = _context.Movies.Find(request);

            if (movie == null)
            {
                new NotFoundException(request, typeof(Movie));
            }

            using (var transaction = _context.Database.BeginTransaction())
            {
                try
                {

                    //Proveriti kasnije da li radi soft delete iz SeatReserveds tabele
                    var movieScreening = _context.Screenings.Where(s => s.MovieId == movie.Id);

                    if (movieScreening != null) {

                    foreach (var time in movieScreening)
                        {

                            time.SeatReserveds.Select(s => new SeatReserved
                            {
                                IsActive = false,
                                IsDeleted = true,
                                DeletedAt = DateTime.Now
                            });
                        }
                        _context.SaveChanges();
                    }



                    var screening = _context.Screenings.Where(s => s.MovieId == movie.Id).Select(s => new Screening { 
                        IsActive = false,
                        IsDeleted = true,
                        DeletedAt = DateTime.Now
                    });

                    if (screening != null) {
                        _context.SaveChanges();
                    }

                    movie.IsActive = false;
                    movie.IsDeleted = true;
                    movie.DeletedAt = DateTime.Now;

                    _context.SaveChanges();

                    transaction.Commit();
                }
                catch (Exception)
                {
                    transaction.Rollback();
                }
            }
        }
    }
}
