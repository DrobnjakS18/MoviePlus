using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using MoviePlus.API.Core;
using MoviePlus.Application;
using MoviePlus.Application.Commands;
using MoviePlus.Application.Dto;
using MoviePlus.Application.Queries;
using MoviePlus.Application.Searches;

namespace MoviePlus.API.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class UserController : ControllerBase
    {
        private readonly IApplicationUser _actor;
        private readonly UseCaseExecutor _executor;

        public UserController(IApplicationUser actor, UseCaseExecutor executor)
        {
            _actor = actor;
            _executor = executor;
        }

        // GET: api/User
        [HttpGet]
        [Authorize]
        public IActionResult Get(
            [FromQuery] UsersSearch search,
            [FromServices] IGetUsersQuery query)
        {
            return Ok(new
            {
                Actor = _actor,
                Executor = _executor.ExecuteQuery(query, search)
            });
        }

        // GET: api/User/5
        [HttpGet("{id}")]
        public IActionResult Get( int id,
            [FromServices] IGetUserQuery query)
        {
            return Ok(new 
            {
                Actor = _actor,
                Executor = _executor.ExecuteQuery(query, id)
            });
        }

        // POST api/user
        [HttpPost]
        [Authorize]
        public IActionResult Post(
            [FromBody] UserDto request, 
            [FromServices] IRegisterUser command)
        {
            _executor.ExecuteCommand(command, request);

            return StatusCode(201);
        }

        // PUT: api/User/5
        [HttpPut("{id}")]
        [Authorize]
        public IActionResult Put(int id,
            [FromBody] UserUpdateDto dto,
            [FromServices] IUserUpdate command)
        {
            dto.Id = id;

            _executor.ExecuteCommand(command, dto);

            return StatusCode(StatusCodes.Status204NoContent);
        }

        // DELETE: api/ApiWithActions/5
        [HttpDelete("{id}")]
        [Authorize]
        public IActionResult Delete(int id,
            [FromServices] IDeleteUser command)
        {
            _executor.ExecuteCommand(command, id);

            return NoContent();
        }
    }
}
