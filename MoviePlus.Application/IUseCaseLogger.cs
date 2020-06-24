using System;
using System.Collections.Generic;
using System.Text;

namespace MoviePlus.Application
{
    public interface IUseCaseLogger
    {
        //naziv komande koja je izvrsava, trenutni korisnik, prosledjeni podaci
        void Log(IUseCase useCase, IApplicationUser actor, object useCaseData);
    }
}
