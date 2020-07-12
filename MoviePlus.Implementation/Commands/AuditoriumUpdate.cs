using FluentValidation;
using MoviePlus.Application.Commands;
using MoviePlus.Application.Dto;
using MoviePlus.Application.Exceptions;
using MoviePlus.DataAccess;
using MoviePlus.Domain;
using MoviePlus.Implementation.Validation;
using System;
using System.Collections.Generic;
using System.Text;

namespace MoviePlus.Implementation.Commands
{
    public class AuditoriumUpdate : IAuditoriumUpdate
    {
        private readonly MoviePlusContext _context;
        private readonly UpdateAuditoriumValidator _validator;

        public AuditoriumUpdate(MoviePlusContext context, UpdateAuditoriumValidator validator)
        {
            _context = context;
            _validator = validator;
        }

        public int Id => 23;

        public string Name => "Update Auditorium";

        public void Execute(AuditoriumUpdateDto request)
        {
            var auditorium = _context.Auditoriums.Find(request.Id);

            if (auditorium == null)
            {
                throw new NotFoundException(request.Id, typeof(Auditorium));
            }

            _validator.ValidateAndThrow(request);

            auditorium.Name = request.Name;
            auditorium.UpdatedAt = DateTime.Now;

            _context.SaveChanges();
        }
    }
}
