using Microsoft.AspNetCore.Mvc;
using System.Collections.Generic;
using Todo.Api.Services;

namespace Todo.Api.Controllers
{
    [ApiController]
    [Route("api/todos")]
    public class TodoItemsController : ControllerBase
    {
        private TodoRepository repository;

        public TodoItemsController(ITodoRepository todoRepository)
        {
            repository = todoRepository ??
                throw new ArgumentNullException(nameof(todoRepository));
        }
        //public TodoItemsController()
        //{
            //repository = new TodoRepository();
        //}

        [HttpGet]
        public IActionResult GetTodos()
        {
           //var result = new List<TodoItem>(){
               //new TodoItem{ Id = 1, Action="Thing one.", IsDone=true},
               //new TodoItem{ Id = 2, Action="Thing two.", IsDone=false},
           //};

           var result = repository.GetAllTodoItems();
           if (result == null)
           {
               return NotFound();
           }
            return Ok(result);
        }
    }
}