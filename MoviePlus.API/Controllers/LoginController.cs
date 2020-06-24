using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using MoviePlus.API.Core;

// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace MoviePlus.API.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class LoginController : ControllerBase
    {
        private readonly JwtManager _token;
        public LoginController(JwtManager token)
        {
            _token = token;
        }

        // POST api/login
        [HttpPost]
        public IActionResult Post([FromBody] LoginRequest request)
        {

            var token = _token.MakeToken(request.Username, request.Password);

            if (token == null)
            {

                return Unauthorized();
            }

            return Ok(new
            {
                token
            });
        }

        public class LoginRequest
        {
            public string Username { get; set; }

            public string Password { get; set; }
        }
    }
}
