using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;
using AspNetWebApi.Core;
using AspNetWebApi.Core.Domain;
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

            if (user == null) { NoContent(); }

            return Ok(user);
        }

        // POST api/users
        [HttpPost]
        public IActionResult Post([FromBody] User user)
        {
            _Uow.Users.Add(user);
            _Uow.Complete();

            return CreatedAtAction("Post", user);
        }

        // GET api/users
        [HttpGet]
        public ActionResult<IEnumerable<string>> Get()
        {
            var users = _Uow.Users.GetAll();

            return Ok(users);
        }

        // PUT api/users/1
        [HttpPut("{id:int}")]
        public ActionResult Put(int id, [FromBody] User user)
        {
            var userToUpdate = _Uow.Users.Get(id);

            if (userToUpdate == null) { return NoContent(); }

            userToUpdate = user;
            _Uow.Complete();

            return Accepted(user);
        }
    }
}
