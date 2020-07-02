using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using MoviePlus.Application;
using MoviePlus.Application.Commands;
using MoviePlus.Application.Dto;
using MoviePlus.Application.Queries;
using MoviePlus.Application.Searches;

namespace MoviePlus.API.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ScreeningController : ControllerBase
    {
        private readonly IApplicationUser _actor;
        private readonly UseCaseExecutor _executor;

        public ScreeningController(IApplicationUser actor, UseCaseExecutor executor)
        {
            _actor = actor;
            _executor = executor;
        }


        // GET: api/Screening
        [HttpGet]
        [Authorize]
        public IActionResult Get(
            [FromQuery] ScreeningSearch search,
            [FromServices] IGetScreeningQuery query)
        {
            return Ok(new
            {
                Actor = _actor,
                Executor = _executor.ExecuteQuery(query, search)
            });
        }

        // GET: api/Screening/5
        [HttpGet("{id}", Name = "Get")]
        [Authorize]
        public string Get(int id)
        {
            return "value";
        }

        // POST: api/Screening
        [HttpPost]
        [Authorize]
        public IActionResult Post([FromBody] ScreeningDto request,
            [FromServices] IScreeningInsert command)
        {
            _executor.ExecuteCommand(command, request);

            return StatusCode(201);
        }

        // PUT: api/Screening/5
        [HttpPut("{id}")]
        [Authorize]
        public void Put(int id, [FromBody] string value)
        {
        }

        // DELETE: api/Screening/5
        [HttpDelete("{id}")]
     
        public IActionResult Delete(int id,
            [FromServices] IScreeningDelete command)
        {
            _executor.ExecuteCommand(command, id);

            return NoContent();
        }
    }


}
