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
using System.Security.Cryptography;
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


            if (string.IsNullOrWhiteSpace(request.FirstName)) {
                request.FirstName = user.FirstName;
            }

            if (string.IsNullOrWhiteSpace(request.LastName))
            {
                request.LastName = user.LastName;
            }

            if (!string.IsNullOrWhiteSpace(request.Password))
            {
                var md5 = MD5.Create();

                byte[] passwordBytes = Encoding.ASCII.GetBytes(request.Password);

                byte[] hash = md5.ComputeHash(passwordBytes);

                var stringBuilder = new StringBuilder();

                for (int i = 0; i < hash.Length; i++)
                {

                    stringBuilder.Append(hash[i].ToString("X2"));
                }

                var hashedPassword = stringBuilder.ToString();

                request.Password = hashedPassword;

            }
            else {
               
                request.Password = user.Password;
            }


            if (string.IsNullOrWhiteSpace(request.Email))
            {
                request.Email = user.Email;
            }

            _validator.ValidateAndThrow(request);

            user.FirstName = request.FirstName;
            user.LastName = request.LastName;
            user.Password = request.Password;
            user.Email = request.Email;
            user.UpdatedAt = DateTime.Now;


            _context.SaveChanges();
        }
    }
}
