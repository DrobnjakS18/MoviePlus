using MoviePlus.Application.Dto;
using MoviePlus.Application.Queries;
using MoviePlus.Application.Searches;
using MoviePlus.DataAccess;
using MoviePlus.Domain;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace MoviePlus.Implementation.Queries
{
    public class GetUsersQuery : IGetUsersQuery
    {

        private readonly MoviePlusContext _context;

        public GetUsersQuery(MoviePlusContext context)
        {
            _context = context;
        }

        public int Id => 4;

        public string Name => "Get users";

        public PageResponse<UserDto> Execute(UsersSearch search)
        {
            //gradimo query
            var query = _context.Users.AsQueryable();

            //Predstavlja broj podataka koje treba da preskoci
            var skipCount = search.ItemsPerPage * (search.CurrentPage - 1);

            //Obavezno je na kraju dodati .ToList()
            var response = new PageResponse<UserDto>
            {

                TotalCount = query.Count(),
                ItemsPerPage = search.ItemsPerPage,
                CurrentPage = search.CurrentPage,
                //Skip(skipCount) - broj podataka koji se preskace
                Items = query.Skip(skipCount).Take(search.ItemsPerPage).Select(x => new UserDto
                {
                    Id = x.Id,
                    FirstName = x.FirstName,
                    LastName = x.LastName,
                    Email = x.Email,
                    Username = x.Username
                }).ToList()
            };

            return response;
        }
    }
}
