using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using GamificationProject.Data;
using GamificationProject.Server.Services;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace GamificationProject.Api.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    [Authorize]
    //[ServiceFilter(typeof(SecurityAsyncActionFilter))]
    public class UsersController : ControllerBase
    {
        private readonly UserService _Service;

        public UsersController(UserService service)
        {
            _Service = service;
        }

        [HttpGet]
        public ActionResult<IEnumerable<User>> Get()
        {
            return Ok(_Service.All());
        }

        [HttpGet("{id}")]
        public ActionResult<User> Get(int id)
        {
            return Ok(_Service.Get(id));
        }

        [Route("[action]")]
        [HttpGet]
        public ActionResult<IEnumerable<User>> GetDetailed()
        {
            return Ok(_Service.AllDetailed());
        }

        [Route("[action]/{id}")]
        [HttpGet]
        public ActionResult<User> GetDetailed(int id)
        {
            return Ok(_Service.GetDetailed(id));
        }

        [HttpPost]
        public ActionResult Post([FromBody] User entity)
        {
            _Service.Insert(entity);
            return Ok(entity);
        }

        [HttpPut("{id}")]
        public ActionResult Put(int id, [FromBody] User entity)
        {
            _Service.Update(entity);
            return Ok(entity);
        }

        [HttpDelete("{id}")]
        public ActionResult Delete(int id)
        {
            _Service.Delete(id);
            return Ok();
        }
    }
}

