﻿using Microsoft.AspNetCore.Mvc;
using rest_asp_net_core.Model;
using rest_asp_net_core.Services;

namespace rest_asp_net_core.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class PersonController : ControllerBase
    {
        private IPersonService _personService;

        public PersonController(IPersonService personService)
        {
            _personService = personService;
        }

        [HttpGet]
        public IActionResult Get()
        {
            return Ok(_personService.FindAll());
        }

        [HttpGet("{id}")]
        public IActionResult Get(long id)
        {
            var person = _personService.FindById(id);

            if (person == null)
                return NotFound();

            return Ok(person);
        }

        [HttpPost]
        public IActionResult Post([FromBody]Person person)
        {
            if (person == null)
                return BadRequest();

            return new ObjectResult(person);
        }

        [HttpPut("{id}")]
        public IActionResult Put([FromBody]Person person)
        {
            if (person == null)
                return BadRequest();

            return new ObjectResult(person);
        }

        [HttpDelete("{id}")]
        public IActionResult Delete(long id)
        {
            _personService.Delete(id);
            return NoContent();
        }
    }
}
