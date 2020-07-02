using Microsoft.EntityFrameworkCore;
using MoviePlus.Application.Commands;
using MoviePlus.Application.Exceptions;
using MoviePlus.DataAccess;
using MoviePlus.Domain;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace MoviePlus.Implementation.Commands
{
    public class DeleteScreening : IScreeningDelete
    {
        private readonly MoviePlusContext _context;

        public DeleteScreening(MoviePlusContext context)
        {
            _context = context;
        }

        public int Id => 16;

        public string Name => "Delete Screening Time";

        public void Execute(int request)
        {
            var screening = _context.Screenings.Find(request);

            if (screening == null) {
                new NotFoundException(request, typeof(Screening));
            }

            using (var transaction = _context.Database.BeginTransaction())
            {
                try
                {
                    var reservations = _context.Screenings.Include(r => r.Reservations).Where(s => s.Id == screening.Id).First().Reservations;

                    if (reservations.Any())
                    {

                        foreach (var item in reservations)
                        {
                            _context.Reservations.Remove(item);
                        }
                    }

                    _context.SaveChanges();

                    var screeningSeats = _context.Screenings.Include(r => r.SeatReserveds).Where(s => s.Id == screening.Id).First().SeatReserveds;

                    if (screeningSeats.Any())
                    {

                        foreach (var item in screeningSeats)
                        {
                            _context.SeatReserved.Remove(item);
                        }
                    }

                    _context.SaveChanges();


                    _context.Screenings.Remove(screening);
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
