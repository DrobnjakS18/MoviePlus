using Microsoft.EntityFrameworkCore;
using MoviePlus.Application.Commands;
using MoviePlus.Application.Dto;
using MoviePlus.Application.Exceptions;
using MoviePlus.DataAccess;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace MoviePlus.Implementation.Commands
{
    public class DeleteReservation : IDeleteReservation
    {
        private readonly MoviePlusContext _context;

        public DeleteReservation(MoviePlusContext context)
        {
            _context = context;
        }
        public int Id => 12;

        public string Name => "Delete Reservation";

        public void Execute(int request)
        {
            var reservation = _context.Reservations.Find(request);

            if (reservation == null)
            {
               throw new NotFoundException(request, typeof(ReservationDto));
            }

            using (var transaction = _context.Database.BeginTransaction())
            {
                try
                {
                    var seatsRes = _context.Reservations.Include(s => s.SeatReserveds).Where(s => s.Id == reservation.Id).First().SeatReserveds;

                    foreach (var item in seatsRes)
                    {
                        _context.SeatReserved.Remove(item);
                    }

                    _context.SaveChanges();

                    _context.Reservations.Remove(reservation);

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
