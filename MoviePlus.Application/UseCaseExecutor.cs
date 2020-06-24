using MoviePlus.Application.Exceptions;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace MoviePlus.Application
{
    public class UseCaseExecutor
    {
        //Dohvatamo trenutnog korisnika koji izvrsava komandu
        private readonly IApplicationUser actor;
        private readonly IUseCaseLogger logger;
        public UseCaseExecutor(IApplicationUser actor, IUseCaseLogger logger)
        {
            this.actor = actor;
            this.logger = logger;
        }

        //Prilikom izvrsavanje upita mozemo da definisemo preprocessing i postprocessing
        public TResult ExecuteQuery<TSearch, TResult>(IQuery<TSearch, TResult> query, TSearch search)
        {
            //1. Ispisivanje poruke ko je i koju komandu izvrsio (preprocessing)
            //query parametar kao IUseCase zato sto ga nasledjuje
            logger.Log(query, actor, search);

            if (!actor.AllowedUseCases.Contains(query.Id))
            {
                throw new UnauthorizedException(query, actor);
            }

            return query.Execute(search);
        }


        //Prilikom izvrsavanje komande mozemo da definisemo preprocessing i postprocessing
        public void ExecuteCommand<Request>(ICommend<Request> command, Request request)
        {
            //1. Ispisivanje poruke ko je i koju komandu izvrsio (preprocessing)
            logger.Log(command, actor, request);

            if (!actor.AllowedUseCases.Contains(command.Id))
            {
                throw new UnauthorizedException(command, actor);
            }

            //2. Samo izvrsavanje komande
            command.Execute(request);
        }
    }
}
