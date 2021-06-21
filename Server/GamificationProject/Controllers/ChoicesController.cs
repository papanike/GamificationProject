using System.Collections.Generic;
using GamificationProject.Data;
using GamificationProject.Server.Services;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;

namespace GamificationProject.Api.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    [Authorize]
    //[ServiceFilter(typeof(SecurityAsyncActionFilter))]
    public class ChoicesController : ControllerBase
    {
        private readonly ChoiceService _Service;

        public ChoicesController(ChoiceService service)
        {
            _Service = service;
        }

        [HttpGet]
        public ActionResult<IEnumerable<Choice>> Get()
        {
            return Ok(_Service.All());
        }

        [HttpGet("{id}")]
        public ActionResult<Choice> Get(int id)
        {
            return Ok(_Service.Get(id));
        }

        [HttpPost]
        public ActionResult Post([FromBody] Choice entity)
        {
            _Service.Insert(entity);
            return Ok(entity);
        }

        [HttpPut("{id}")]
        public ActionResult Put(int id, [FromBody] Choice entity)
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

