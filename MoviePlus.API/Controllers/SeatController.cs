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
using MoviePlus.Implementation.Commands;

namespace MoviePlus.API.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class SeatController : ControllerBase
    {
        private readonly UseCaseExecutor _executor;

        public SeatController(UseCaseExecutor executor)
        {
            _executor = executor;
        }

        // GET: api/Seat?minSeatNumber=&maxSeatNumber?auditorium
        [HttpGet]
        public IActionResult Get(
            [FromQuery] SeatSearch search,
            [FromServices] IGetSeatsQuery query)
        {
            var result = _executor.ExecuteQuery(query, search);
            return Ok(result);
        }

        // GET: api/Seat/5
        [HttpGet("{id}", Name = "GetSeat")]
        public IActionResult Get(int id,
            [FromServices] IGetSingleSeatQuery query)
        {
            var result = _executor.ExecuteQuery(query, id);

            return Ok(result);
        }

        // POST: api/Seat
        [HttpPost]
        public IActionResult Post(
            [FromBody] SeatInsertDto dto,
            [FromServices] ISeatInsert command)
        {
            _executor.ExecuteCommand(command, dto);
            return StatusCode(201);
        }

        // PUT: api/Seat/5
        [HttpPut("{id}")]
        public IActionResult Put(int id,
            [FromBody] SeatUpdateDto dto,
            [FromServices] ISeatUpdate command)
        {
            dto.Id = id;
            _executor.ExecuteCommand(command, dto);
            return StatusCode(204);
        }

        // DELETE: api/Seat/5
        [HttpDelete("{id}")]
        public IActionResult Delete(int id,
            [FromServices] ISeatDelete command)
        {
            _executor.ExecuteCommand(command, id);
            return StatusCode(204);
        }
    }
}
