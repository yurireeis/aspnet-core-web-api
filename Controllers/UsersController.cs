using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;
using AspNetWebApi.Core;
using AspNetWebApi.Persistence;
using AspNetWebApi.Persistence.Repositories;
using Microsoft.AspNetCore.Mvc;

namespace AspNetWebApi.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class UsersController : ControllerBase
    {
        private readonly IUnitOfWork _Uow;
        public UsersController(IUnitOfWork uow) { _Uow = uow; }
        // GET api/users/5
        [HttpGet("{id:int}")]
        public IActionResult Get(int id)
        {
            var user = _Uow.Users.Get(id);
            return CreatedAtAction("Get", new { id = user.Id, displayname = user.DisplayName, email = user.Email });
        }

        // POST api/users
        [HttpPost]
        public IActionResult Post([FromBody] Task task)
        {
            return CreatedAtAction("Get", new { id = task.Id, title = task.Title }, task);
        }
    }
}
