using System.Collections.Generic;
using Todo.Api.Controllers;
using Todo.Api.Models;

namespace Todo.Api.Services
{
    public class TodoRepository : ITodoRepository
    {
        private List<Models.TodoItem> _items = new List<Models.TodoItem>()
        {
                new TodoItem{ Id = 1, Action="Thing one.", IsDone=true},
                new TodoItem{ Id = 2, Action="Thing two.", IsDone=false},
        };

        public IEnumerable<Models.TodoItem> GetAllTodoItems()
        {
            return _items;
        }
    }
}