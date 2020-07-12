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
    public class DeleteAuditorium : IAuditoriumDelete
    {
        private readonly MoviePlusContext _context;

        public DeleteAuditorium(MoviePlusContext context)
        {
            _context = context;

        }
        public int Id => 24;

        public string Name => "Delete Auditorium";

        public void Execute(int request)
        {
            var query = _context.Auditoriums.Include(s => s.Seats).AsQueryable();

            var auditorium = query.FirstOrDefault(a => a.Id == request);

            if (auditorium == null)
            {
                throw new NotFoundException(request, typeof(Auditorium));
            }

            auditorium.DeletedAt = DateTime.Now;
            auditorium.IsDeleted = true;
            auditorium.IsActive = false;

            _context.SaveChanges();
        }
    }
}
