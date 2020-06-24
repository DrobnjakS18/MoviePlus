using MoviePlus.Application.Commands;
using MoviePlus.Application.Dto;
using MoviePlus.Application.Email;
using MoviePlus.DataAccess;
using MoviePlus.Domain;
using MoviePlus.Implementation.Validation;
using System;
using System.Collections.Generic;
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
            _validator.Validate(request);

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

            _email.Send(new EmailDto
            {
                EmailTo = request.Email,
                Subject = "Movie Plus Registration",
                Content = "<h1>You have successfully register.</h1>"
            });


        }
    }
}
