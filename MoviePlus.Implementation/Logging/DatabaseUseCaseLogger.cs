using MoviePlus.Application;
using MoviePlus.DataAccess;
using MoviePlus.Domain;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Text;

namespace MoviePlus.Implementation.Logging
{
    public class DatabaseUseCaseLogger : IUseCaseLogger
    {
        private readonly MoviePlusContext _context;

        public DatabaseUseCaseLogger(MoviePlusContext context)
        {
            _context = context;
        }

        public void Log(IUseCase useCase, IApplicationUser actor, object useCaseData)
        {
            var userLog = new AuditLogger
            {
                UseCaseName = useCase.Name,
                Data = JsonConvert.SerializeObject(useCaseData),
                Actor = actor.Identity,
                Time = DateTime.UtcNow
            };

            _context.Add(userLog);

            _context.SaveChanges();
        }
    }
}
