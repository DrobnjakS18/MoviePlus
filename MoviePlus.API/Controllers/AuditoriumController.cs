using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
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
    public class AuditoriumController : ControllerBase
    {
        private readonly UseCaseExecutor _executor;

        public AuditoriumController(UseCaseExecutor executor)
        {
            _executor = executor;
        }

        // GET: api/Auditorium?name=
        [HttpGet]
        public IActionResult Get(
            [FromQuery] AuditoriumSearch search,
            [FromServices] IGetAuditoirumsQuery query)
        {
            var result = _executor.ExecuteQuery(query, search);
            return Ok(result);
        }

        // GET: api/Auditorium/5
        [HttpGet("{id}", Name = "GetAuditorium")]
        public IActionResult Get(int id,
            [FromServices] IGetSingleAuditoriumQuery query)
        {
            var result = _executor.ExecuteQuery(query, id);

            return Ok(result);
        }

        // POST: api/Auditorium
        [HttpPost]
        public IActionResult Post([FromBody] AuditoriumDto dto,
            [FromServices] IAuditoriumInsert command)
        {
            _executor.ExecuteCommand(command, dto);
            return StatusCode(201);
        }

        // PUT: api/Auditorium/5
        [HttpPut("{id}")]
        public IActionResult Put(int id,
            [FromBody] AuditoriumUpdateDto dto,
            [FromServices] IAuditoriumUpdate command)
        {
            dto.Id = id;
            _executor.ExecuteCommand(command, dto);
            return StatusCode(204);
        }

        // DELETE: api/Auditorium/5
        [HttpDelete("{id}")]
        public IActionResult Delete(int id,
            [FromServices] IAuditoriumDelete command)
        {
            _executor.ExecuteCommand(command, id);
            return StatusCode(204);
        }
    }
}
