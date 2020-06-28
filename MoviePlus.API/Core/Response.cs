using MoviePlus.Application;
using MoviePlus.Application.Dto;
using MoviePlus.Application.Queries;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MoviePlus.API.Core
{
    public class Response<T> where T : class
    {

        public IApplicationUser Actor { get; set; }

        public PageResponse<T> Executor { get; set; }
    }
}
