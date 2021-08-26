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

        [HttpGet]
        public IActionResult GetTodos()
        {
            var allTodos = _todosService.GetTodos();
            return Ok(allTodos);
        }

        [HttpGet("/{id}")]
        public IActionResult GetTodo(int id)
        {
            var todo = _todosService.GetTodoById(id);
            return Ok(todo);
        }

        [HttpPost]
        public IActionResult CreateTodo([FromBody] Todo todo)
        {
            _todosService.CreateTodo(todo);
            return Ok();
        }
    
        [HttpPut("/{id}")]
        public IActionResult UpdateTodo(int id, [FromBody] Todo todo)
        {
            var updatedTodo = _todosService.UpdateTodo(id, todo);
            return Ok(updatedTodo);
        }
    
        [HttpDelete("/{id}")]
        public IActionResult DeleteTodo(int id)
        {
            _todosService.DeleteTodo(id);
            return Ok();
        }
    }
}
