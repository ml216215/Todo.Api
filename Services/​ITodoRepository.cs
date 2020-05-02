using System.Collections.Generic;
using Todo.Api.Controllers;
using Todo.Api.Models;

namespace Todo.Api.Services
{
    public interface ITodoRepository
    {
        IEnumerable<TodoItem> GetAllTodoItems();
    }
}