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
using System.Security.Cryptography;
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

        public int Id => 2;

        public string Name => "Register user";

        public void Execute(UserDto request)
        {
            _validator.ValidateAndThrow(request);

            var md5 = MD5.Create();

            byte[] passwordBytes = Encoding.ASCII.GetBytes(request.Password);

            byte[] hash = md5.ComputeHash(passwordBytes);

            var stringBuilder = new StringBuilder();

            for (int i = 0; i < hash.Length; i++)
                stringBuilder.Append(hash[i].ToString("X2"));

            var hashedPassword = stringBuilder.ToString();

            var user = new User
            {
                FirstName = request.FirstName,
                LastName = request.LastName,
                Email = request.Email,
                Username = request.Username,
                Password = hashedPassword
            };

            _context.Users.Add(user);
            _context.SaveChanges();


            var lastId = _context.Users.Max(u => u.Id);

            var currentUser = _context.Users.Find(lastId);

            //Lista slucajemo kojima korisnik moze da pristupi
            var userUseCases = new List<int> { 3, 6, 9, 11, 12, 14, 19, 20, 21, 25, 26 };

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
