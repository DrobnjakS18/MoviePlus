using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
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
        public IActionResult Get(
            [FromQuery] LogSearch search,
            [FromServices] IGetLogQuery query)
        {
            return Ok( new Response<LogDto> {
                Actor = _actor,
                Executor = _executor.ExecuteQuery(query, search)
            });
        }

        // GET: api/Log/5
        [HttpGet("{id}", Name = "Geasdt")]
        public string Get(int id)
        {
            return "value";
        }

        // POST: api/Log
        [HttpPost]
        public void Post([FromBody] string value)
        {
        }

        // PUT: api/Log/5
        [HttpPut("{id}")]
        public void Put(int id, [FromBody] string value)
        {
        }

        // DELETE: api/ApiWithActions/5
        [HttpDelete("{id}")]
        public void Delete(int id)
        {
        }
    }
}
