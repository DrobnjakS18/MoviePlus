
using FluentValidation;
using MoviePlus.Application.Dto;
using MoviePlus.DataAccess;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace MoviePlus.Implementation.Validation
{
    public class RegisterUserValidator : AbstractValidator<UserDto>
    {
        public RegisterUserValidator(MoviePlusContext context)
        {

            RuleFor(x => x.FirstName)
                .NotEmpty()
                .Length(3, 32);

            RuleFor(x => x.LastName)
                .NotEmpty()
                .Length(4, 32);

            RuleFor(x => x.Username)
                .NotEmpty()
                .Length(4, 32)
                .Must(x => !context.Users.Any(u => u.Username == x))
                .WithMessage("Username must be unique");

            RuleFor(x => x.Password)
                .NotEmpty()
                .Length(4, 32);


            RuleFor(x => x.Email)
                .NotEmpty()
                .EmailAddress()
                .Must(x => !context.Users.Any(u => u.Email == x))
                .WithMessage("Email must be unique");

        }
    }
}
