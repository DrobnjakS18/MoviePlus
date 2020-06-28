using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using MoviePlus.API.Core;
using MoviePlus.Application;
using MoviePlus.Application.Dto;
using MoviePlus.Application.Queries;
using MoviePlus.Application.Searches;
using MoviePlus.DataAccess;

// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace MoviePlus.API.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class MovieController : ControllerBase
    {

        private readonly IApplicationUser _actor;
        private readonly UseCaseExecutor _executor;

        //Ubacujemo ko izvrsava komandu i koju
        public MovieController(IApplicationUser actor, UseCaseExecutor executor)
        {
            _actor = actor;
            _executor = executor;
        }

        // GET: api/movie?
        [HttpGet]
        [Authorize]
        public IActionResult Get(
            [FromQuery] MovieSearch search,
            [FromServices] IGetMovieQuery query)
        {
            return Ok(new Response<MovieDto>
            {
                Actor = _actor,
                Executor = _executor.ExecuteQuery(query, search)
            });
        }

        // GET api/movie/5
        [HttpGet("{id}")]
        public string Get(int id)
        {
            return "value";
        }

        // POST api/movie
        [HttpPost]
        public void Post([FromBody] string value)
        {
        }

        // PUT api/movie/5
        [HttpPut("{id}")]
        public void Put(int id, [FromBody] string value)
        {
        }

        // DELETE api/movie/5
        [HttpDelete("{id}")]
        public void Delete(int id)
        {
        }
    }
}
