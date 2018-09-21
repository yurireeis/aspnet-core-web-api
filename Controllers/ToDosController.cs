using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using AspNetWebApi.Data;

namespace AspNetWebApi.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ToDosController : ControllerBase
    {
        private readonly ToDoContext _Context;
        public ToDosController(ToDoContext context) => _Context = context;

        // GET api/todos
        [HttpGet]
        public IEnumerable<ToDo> Get() => _Context.ToDos;
    }
}
