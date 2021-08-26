using EntityCrudApp001.Models;
using EntityCrudApp001.Services;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace EntityCrudApp001.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class TodosController : ControllerBase
    {
        public TodosService _todosService;
        public TodosController(TodosService todosService)
        {
            _todosService = todosService;
        }

        [HttpPost]
        public IActionResult CreateTodo([FromBody] Todo todo)
        {
            _todosService.CreateTodo(todo);
            return Ok();
        }
    }
}
