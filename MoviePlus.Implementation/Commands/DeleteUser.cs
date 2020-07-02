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
    public class DeleteUser : IDeleteUser
    {
        private readonly MoviePlusContext _context;

        public DeleteUser(MoviePlusContext context)
        {
            _context = context;
        }

        public int Id => 13;

        public string Name => "Delete User";

        public void Execute(int request)
        {
            var user = _context.Users.Find(request);

            if (user == null) {
                throw new NotFoundException(user.Id, typeof(UserDto));
            }

            using (var transaction = _context.Database.BeginTransaction())
            {

                try
                {



                    var userReservations = _context.Users.Include(r => r.Reservations).Where(r => r.Id == user.Id).First().Reservations;

                    if (userReservations.Any()) {

                        foreach (var item in userReservations)
                        {

                            var seatRes = _context.Reservations.Include(r => r.SeatReserveds).Where(r => r.Id == item.Id).First().SeatReserveds;

                            foreach (var res  in seatRes)
                            {
                                _context.SeatReserved.Remove(res);
                            }

                            _context.Reservations.Remove(item);
                        }

                        _context.SaveChanges();
                    }



                    var logs = _context.AuditLogger.Where(a => a.Actor == user.Username);

                    if (logs.Any()) {

                        foreach (var item in logs)
                        {
                            _context.AuditLogger.Remove(item);
                        }

                        _context.SaveChanges();
                    }

                    _context.Users.Remove(user);

                    _context.SaveChanges();

                    transaction.Commit();
                }
                catch (Exception ex)
                {
                    Console.Write(ex);
                    transaction.Rollback();
                }

            }
        }
    }
}
