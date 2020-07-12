using FluentValidation;
using MoviePlus.Application.Dto;
using MoviePlus.DataAccess;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace MoviePlus.Implementation.Validation
{
    public class UpdateUserValidator : AbstractValidator<UserUpdateDto>
    {
        public UpdateUserValidator(MoviePlusContext context)
        {
            RuleFor(x => x.Username)
                .Must((dto, username) => !context.Users.Any(u => u.Username == username && u.Id != dto.Id))
                .WithMessage(u => $"User with ({u.Username}) already exists in database.");

            RuleFor(x => x.Email)
                .Must((dto, email) => !context.Users.Any(u => u.Email == email && u.Id != dto.Id))
                .WithMessage(u => $"Email ({u.Email}) is taken, try different one.");
        }
    }
}
