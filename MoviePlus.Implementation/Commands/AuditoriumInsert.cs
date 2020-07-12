using FluentValidation;
using MoviePlus.Application.Commands;
using MoviePlus.Application.Dto;
using MoviePlus.DataAccess;
using MoviePlus.Domain;
using MoviePlus.Implementation.Validation;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace MoviePlus.Implementation.Commands
{
    public class AuditoriumInsert : IAuditoriumInsert
    {
        private readonly MoviePlusContext _context;
        private readonly InsertAuditoriumValidator _validator;

        public AuditoriumInsert(MoviePlusContext context, InsertAuditoriumValidator validator)
        {
            _context = context;
            _validator = validator;
        }

        public int Id => 22;

        public string Name => "Insert Auditoirum";

        public void Execute(AuditoriumDto request)
        {
            _validator.ValidateAndThrow(request);

            var auditorium = new Auditorium
            {
                Name = request.Name
            };

            _context.Auditoriums.Add(auditorium);
            _context.SaveChanges();

            int lastAuditoriumId = _context.Auditoriums.Max(item => item.Id);

            for (var i = 1; i <= 10; i++)
            {
                var seat = new Seat
                {
                    Number = i,
                    AuditoriumId = lastAuditoriumId
                };

                _context.Seats.Add(seat);
            }

            _context.SaveChanges();
        }
    }
}
