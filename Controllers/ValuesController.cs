using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;

namespace AspNetWebApi.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ValuesController : ControllerBase
    {
        // GET api/values
        [HttpGet]
        public ActionResult<IEnumerable<string>> Get([FromQuery] int id) => Ok(new Task() { Id = id });

        // GET api/values/5
        [HttpGet("{id:int}")]
        [Produces("application/json")]
        public ActionResult<string> Get(int id, string query) => Ok(new Task() { Id = id });

        // POST api/values
        [HttpPost]
        public IActionResult Post([FromBody] Task task)
        {
            if (!ModelState.IsValid) { return BadRequest(ModelState); }

            // created at will produce 201 status code response
            return CreatedAtAction("Get", new { id = task.Id, title = task.Title }, task);
        }

        // PUT api/values/5
        [HttpPut("{id:int}")]
        public void Put(int id, [FromBody] string value) { }

        // DELETE api/values/5
        [HttpDelete("{id}")]
        public void Delete(int id) { }
    }

    public class Task
    {
        public int Id { get; set; }

        [MinLength(3)]
        public string Title { get; set; }
    }
}
