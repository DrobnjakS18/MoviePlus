using FluentValidation;
using MoviePlus.Application.Commands;
using MoviePlus.Application.Dto;
using MoviePlus.Application.Email;
using MoviePlus.DataAccess;
using MoviePlus.Domain;
using MoviePlus.Implementation.Validation;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace MoviePlus.Implementation.Commands
{
    public class RegisterUser : IRegisterUser
    {
        private readonly MoviePlusContext _context;
        private readonly RegisterUserValidator _validator;
        private readonly IEmailSender _email;

        public RegisterUser(MoviePlusContext context, RegisterUserValidator validator, IEmailSender email = null)
        {
            _context = context;
            _validator = validator;
            _email = email;
        }

        public int Id => 1;

        public string Name => "Register user";

        public void Execute(RegisterDto request)
        {
            _validator.ValidateAndThrow(request);

            var user = new User
            {
                FirstName = request.FirstName,
                LastName = request.LastName,
                Email = request.Email,
                Username = request.Username,
                Password = request.Password
            };

            _context.Users.Add(user);
            _context.SaveChanges();


            var lastId = _context.Users.Max(u => u.Id);

            var currentUser = _context.Users.Find(lastId);

            //Lista slucajemo kojima korisnik moze da pristupi
            var userUseCases = new List<int> { 2, 3, 4, 5 };

            foreach (var cases in userUseCases)
            {
                _context.UserUseCases.Add(
                       new UserUseCases {
                            UserId = currentUser.Id,
                            UseCaseId = cases
                       }
                    );
            }

            _context.SaveChanges();

            _email.Send(new EmailDto
            {
                EmailTo = request.Email,
                Subject = "Movie Plus Registration",
                Content = "<h1>You have successfully register.</h1>"
            });

        }
    }
}
