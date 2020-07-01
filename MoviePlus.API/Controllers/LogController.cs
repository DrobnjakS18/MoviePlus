using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using MoviePlus.API.Core;
using MoviePlus.Application;
using MoviePlus.Application.Dto;
using MoviePlus.Application.Queries;
using MoviePlus.Application.Searches;

namespace MoviePlus.API.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class LogController : ControllerBase
    {

        private readonly IApplicationUser _actor;
        private readonly UseCaseExecutor _executor;

        public LogController(IApplicationUser actor, UseCaseExecutor executor)
        {
            _actor = actor;
            _executor = executor;
        }
        // GET: api/Log
        [HttpGet]
        [Authorize]
        public IActionResult Get(
            [FromQuery] LogSearch search,
            [FromServices] IGetLogQuery query)
        {
            return Ok( new Response<LogDto> {
                Actor = _actor,
                Executor = _executor.ExecuteQuery(query, search)
            });
        }
    }
}
