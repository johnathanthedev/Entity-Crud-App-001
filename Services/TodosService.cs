using EntityCrudApp001.DB;
using EntityCrudApp001.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace EntityCrudApp001.Services
{
    public class TodosService
    {
        public AppDbContext _context;
        public TodosService(AppDbContext context)
        {
            _context = context;
        }
        
        public void CreateTodo(Todo todo)
        {
            var _todo = new Todo()
            {
                Title = todo.Title,
                Description = todo.Description
            };

            _context.Todos.Add(_todo);
            _context.SaveChanges();
        }
    
        public List<Todo> GetTodos()
        {
            return _context.Todos.ToList();
        }

        public Todo GetTodoById(int todoId)
        {
            return _context.Todos.FirstOrDefault(obj => obj.Id == todoId);
        }
    
        public Todo UpdateTodo(int todoId, Todo todo)
        {
            var _todo = _context.Todos.FirstOrDefault(obj => obj.Id == todoId);
            if (_todo != null)
            {
                _todo.Title = todo.Title;
                _todo.Description = todo.Description;

                _context.SaveChanges();
            }

            return _todo;
        }
    
        public void DeleteTodo(int todoId)
        {
            var _todo = _context.Todos.FirstOrDefault(obj => obj.Id == todoId);
            if(_todo != null)
            {
                _context.Todos.Remove(_todo);
                _context.SaveChanges();
            }
        }
    }
}
