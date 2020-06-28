using MoviePlus.Application.Dto;
using MoviePlus.Application.Queries;
using MoviePlus.Application.Searches;
using MoviePlus.DataAccess;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace MoviePlus.Implementation.Queries
{
    public class GetLogQuery : IGetLogQuery
    {
        private readonly MoviePlusContext _context;
        public GetLogQuery(MoviePlusContext context)
        {
            _context = context;
        }

        public int Id => 5;

        public string Name => "Get Logs";

        public PageResponse<LogDto> Execute(LogSearch search)
        {
            //gradimo query
            var query = _context.AuditLogger.AsQueryable();

            if (!string.IsNullOrEmpty(search.Actor) || !string.IsNullOrWhiteSpace(search.Actor))
            {
                query = query.Where(x => x.Actor.ToLower().Contains(search.Actor.ToLower()));
            }

            if (!string.IsNullOrEmpty(search.UseCase) || !string.IsNullOrWhiteSpace(search.UseCase))
            {
                query = query.Where(x => x.UseCaseName.ToLower().Contains(search.UseCase.ToLower()));
            }

            //Predstavlja broj podataka koje treba da preskoci
            var skipCount = search.ItemsPerPage * (search.CurrentPage - 1);

            //Obavezno je na kraju dodati .ToList()
            var response = new PageResponse<LogDto>
            {

                TotalCount = query.Count(),
                ItemsPerPage = search.ItemsPerPage,
                CurrentPage = search.CurrentPage,
                //Skip(skipCount) - broj podataka koji se preskace
                Items = query.Skip(skipCount).Take(search.ItemsPerPage).Select(x => new LogDto
                {
                    Id = x.Id,
                    UseCase = x.UseCaseName,
                    Data = x.Data,
                    Actor = x.Actor,
                    Date = x.Time,
                }).ToList()
            };

            return response;
        }
    }
}
