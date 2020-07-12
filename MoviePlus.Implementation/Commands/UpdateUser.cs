using FluentValidation;
using MoviePlus.Application;
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
    public class UpdateUser : IUserUpdate
    {

        private readonly MoviePlusContext _context;
        private readonly UpdateUserValidator _validator;
        private readonly IApplicationUser _actor;

        public UpdateUser(MoviePlusContext context, UpdateUserValidator validator, IApplicationUser actor)
        {
            _context = context;
            _validator = validator;
            _actor = actor;
        }
        public int Id => 18;

        public string Name => "Update User";

        public void Execute(UserUpdateDto request)
        {
            var user = _context.Users.Find(request.Id);

            if (user == null)
            {
                throw new NotFoundException(request.Id, typeof(User));
            }

            if (user.Id != _actor.id)
            {
                throw new UnauthorizedException(this, _actor);
            }
            if (request.FirstName == null && request.LastName == null)
            {
                request.FirstName = user.FirstName;
                request.LastName = user.LastName;
            }
            if (request.FirstName == null && request.LastName != null)
            {
                request.FirstName = user.FirstName;
            }
            if (request.FirstName != null && request.LastName == null)
            {
                request.LastName = user.LastName;
            }

            if (request.Password == null)
            {
                request.Password = user.Password;
            }
            if (request.Email == null)
            {
                request.Email = user.Email;
            }

            _validator.ValidateAndThrow(request);

            user.FirstName = request.FirstName;
            user.LastName = request.LastName;
            user.Password = request.Password;
            user.Email = request.Email;


            _context.SaveChanges();
        }
    }
}
