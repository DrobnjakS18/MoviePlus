using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using MoviePlus.Application;
using MoviePlus.Application.Commands;
using MoviePlus.Application.Dto;

// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace MoviePlus.API.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class RegisterController : ControllerBase
    {
        private readonly UseCaseExecutor _executor;
        public RegisterController(UseCaseExecutor executor)
        {
            _executor = executor;
        }

        // POST api/register
        [HttpPost]
        public IActionResult Post(
            [FromBody] UserDto request, 
            [FromServices] IRegisterUser command)
        {
            _executor.ExecuteCommand(command, request);

            return StatusCode(201);
        }
    }
}
