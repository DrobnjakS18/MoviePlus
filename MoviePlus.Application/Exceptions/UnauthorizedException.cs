using System;
using System.Collections.Generic;
using System.Text;

namespace MoviePlus.Application.Exceptions
{
    public class UnauthorizedException : Exception
    {
        public UnauthorizedException(IUseCase useCase, IApplicationUser actor)
            : base($"Actor with id {actor.id}, identity {actor.Identity} wants to execute an unauthorized command {useCase.Name}")
        { }
    }
}
