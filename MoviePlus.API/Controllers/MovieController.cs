using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using MoviePlus.API.Core;
using MoviePlus.Application;
using MoviePlus.Application.Commands;
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
        [Authorize]
        public IActionResult Post([FromBody] MovieDto request,
            [FromServices] IMovieInsert command)
        {

            if (request.Date == "") 
            {
                return StatusCode(400);
            }
            else {

                var splitDate = request.Date.Split('-');
                var searchDate = new DateTime(int.Parse(splitDate[0]), int.Parse(splitDate[1]), int.Parse(splitDate[2]), int.Parse(request.Time), 0, 0);

                if (searchDate <= DateTime.Now) {
                    return StatusCode(409);
                }

                _executor.ExecuteCommand(command, request);
            }



            return StatusCode(201);
        }

        // PUT api/movie/5
        [HttpPut("{id}")]
        public void Put(int id, [FromBody] string value)
        {
        }

        // DELETE api/movie/5
        [HttpDelete("{id}")]
        [Authorize]
        public IActionResult Delete(int id, 
            [FromServices] IDeleteMovie command)
        {

            _executor.ExecuteCommand(command, id);

            return NoContent();
        }
    }

}
