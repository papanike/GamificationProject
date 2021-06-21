using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Claims;
using System.Threading.Tasks;
using GamificationProject.Data;
using GamificationProject.Interfaces;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace GamificationProject.Api.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class LoginController : ControllerBase
    {
        private readonly ILoginService _Service;

        public LoginController(ILoginService service)
        {
            _Service = service;
        }

        [HttpGet]
        [Authorize]
        [Route("[action]")]
        public ActionResult GetSelf()
        {
            var userId = User.FindFirst(ClaimTypes.Name)?.Value;
            AuthenticatedUser user = userId != null ? _Service.GetUser(int.Parse(userId)) : null;
            if (user == null) return Unauthorized(new { message = "Please login" });

            return Ok(user);
        }

        [HttpPost]
        public ActionResult Post([FromBody] AuthenticationRequest entity)
        {
            AuthenticatedUser user = _Service.Login(entity);
            if (user == null) return BadRequest(new { message = "Username or password is incorrect" });

            return Ok(user);
        }
    }
}
