using MoviePlus.Application.Dto;
using MoviePlus.Application.Exceptions;
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

            if (!string.IsNullOrWhiteSpace(search.StartDate) && !string.IsNullOrWhiteSpace(search.EndDate))
            {
                var splitStartDate = search.StartDate.Split('-');

                var splitEndDate = search.EndDate.Split('-');

                var startDate = new DateTime(int.Parse(splitStartDate[0]), int.Parse(splitStartDate[1]), int.Parse(splitStartDate[2]), 0, 0, 0);

                var endDate = new DateTime(int.Parse(splitEndDate[0]), int.Parse(splitEndDate[1]), int.Parse(splitEndDate[2]), 0, 0, 0);


                if (endDate < startDate)
                {
                    throw new NotFoundException(this.Id, typeof(MovieDto));
                }
                else if (endDate == startDate)
                {
                    query = query.Where(m => m.Time.Year == startDate.Year).Where(m => m.Time.Month == startDate.Month).Where(m => m.Time.Day == startDate.Day);
                }
                else {
                    query = query.Where(m => m.Time >= startDate).Where(m => m.Time < endDate);
                }

            }
            else if (!string.IsNullOrEmpty(search.StartDate) || !string.IsNullOrWhiteSpace(search.StartDate))
            {
                var splitDate = search.StartDate.Split('-');

                var startDate = new DateTime(int.Parse(splitDate[0]), int.Parse(splitDate[1]), int.Parse(splitDate[2]), 0, 0, 0);

                query = query.Where(m => m.Time.CompareTo(startDate) >= 0);
            }
            else if (!string.IsNullOrEmpty(search.EndDate) || !string.IsNullOrWhiteSpace(search.EndDate))
            {
                var splitDate = search.EndDate.Split('-');

                var endDate = new DateTime(int.Parse(splitDate[0]), int.Parse(splitDate[1]), int.Parse(splitDate[2]), 0, 0, 0);

                query = query.Where(m => m.Time.CompareTo(endDate) <= 0);
            }
            









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
