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
    }
}
