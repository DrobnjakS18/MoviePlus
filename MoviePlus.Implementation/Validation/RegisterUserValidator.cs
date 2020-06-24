using FluentValidation;
using MoviePlus.Application.Dto;
using MoviePlus.DataAccess;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace MoviePlus.Implementation.Validation
{
    public class RegisterUserValidator : AbstractValidator<RegisterDto>
    {
        public RegisterUserValidator(MoviePlusContext context)
        {

            RuleFor(x => x.FirstName).NotEmpty().MinimumLength(3);
            RuleFor(x => x.LastName).NotEmpty().MinimumLength(4);
            RuleFor(x => x.Password).NotEmpty().MinimumLength(4);
            RuleFor(x => x.Email)
                .NotEmpty()
                .EmailAddress()
                .Must(x => context.Users.Any(u => u.Email == x))
                .WithMessage("Email must be unique");

        }
    }
}
