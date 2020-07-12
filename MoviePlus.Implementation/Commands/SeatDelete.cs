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
    public class SeatDelete : ISeatDelete
    {
        private readonly MoviePlusContext _context;

        public SeatDelete(MoviePlusContext context)
        {
            _context = context;

        }

        public int Id => 29;

        public string Name => "Delete Seat";

        public void Execute(int request)
        {
            var seat = _context.Seats.Find(request);

            if (seat == null)
            {
                throw new NotFoundException(request, typeof(Seat));
            }

            seat.DeletedAt = DateTime.Now;
            seat.IsDeleted = true;
            seat.IsActive = false;

            _context.SaveChanges();
        }
    }
}
