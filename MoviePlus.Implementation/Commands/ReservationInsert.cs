using Microsoft.EntityFrameworkCore;
using MoviePlus.Application.Commands;
using MoviePlus.Application.Dto;
using MoviePlus.DataAccess;
using MoviePlus.Domain;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace MoviePlus.Implementation.Commands
{
    public class ReservationInsert : IReservationInsert
    {

        private readonly MoviePlusContext _context;

        public ReservationInsert(MoviePlusContext context)
        {
            _context = context;

        }
        public int Id => 11;

        public string Name => "Insert reservation";

        public void Execute(ReservationDto request)
        {
            using (var transaction = _context.Database.BeginTransaction())
            {
                try
                {
                    var reservation = new Reservation
                    {
                        UserId = request.UserId,
                        ScreeningId = request.ScreeningId
                    };

                    _context.Reservations.Add(reservation);
                    _context.SaveChanges();

                    int lastReservationId = _context.Reservations.Max(item => item.Id);


                    var randomSeatId = _context.Seats.FromSqlRaw($"select top 1 s.* from Seats s where s.AuditoriumId = {request.AuditoriumId} and s.Id not in(select s.Id from Seats s inner join SeatReserved r on s.Id = r.SeatId where r.ScreeningId = {request.ScreeningId} and s.AuditoriumId = {request.AuditoriumId} ) order by newid()").First().Id;


                    var seatReserved = new SeatReserved
                    {
                        ReservationId = lastReservationId,
                        ScreeningId = request.ScreeningId,
                        SeatId = randomSeatId
                    };

                    _context.SeatReserved.Add(seatReserved);
                    _context.SaveChanges();


                    transaction.Commit();
                }
                catch (Exception ex)
                {
                    Console.WriteLine(ex.Message);
                    transaction.Rollback();
                }
            }



        }
    }
}
