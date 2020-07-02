using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using MoviePlus.Application;
using MoviePlus.Application.Commands;
using MoviePlus.Application.Dto;

namespace MoviePlus.API.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ReservationController : ControllerBase
    {
        private readonly IApplicationUser _actor;
        private readonly UseCaseExecutor _executor;

        //Ubacujemo ko izvrsava komandu i koju
        public ReservationController(IApplicationUser actor, UseCaseExecutor executor)
        {
            _actor = actor;
            _executor = executor;
        }

        // GET: api/Reservation
        [HttpGet]
        public IEnumerable<string> Get()
        {
            return new string[] { "value1", "value2" };
        }

        // GET: api/Reservation/5
        [HttpGet("{id}", Name = "Getasdsad")]
        public string Get(int id)
        {
            return "value";
        }

        // POST: api/Reservation
        [HttpPost]
        public IActionResult Post([FromBody] ReservationDto request,
            [FromServices] IReservationInsert command)
        {

            _executor.ExecuteCommand(command, request);

            return StatusCode(201);
        }

        // PUT: api/Reservation/5
        [HttpPut("{id}")]
        public void Put(int id, [FromBody] string value)
        {
        }

        // DELETE: api/ApiWithActions/5
        [HttpDelete("{id}")]
        public IActionResult Delete(int id,
            [FromServices] IDeleteReservation command)
        {

            _executor.ExecuteCommand(command, id);

            return NoContent();
        }
    }
}
