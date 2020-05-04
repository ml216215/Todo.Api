using Microsoft.AspNetCore.Mvc;
using System.Collections.Generic;
using Todo.Api.Services;
using System;

namespace Todo.Api.Controllers
{
    [ApiController]
    [Route("api/todos")]
    public class TodoItemsController : ControllerBase
    {
        private TodoRepository repository;

        //public TodoItemsController(ITodoRepository todoRepository)
       // {
         //   repository = todoRepository ?? 
           //     throw new ArgumentNullException(nameof(todoRepository));
       // }

        public TodoItemsController()
        {
            repository = new TodoRepository();
        }

        [HttpGet]
        public IActionResult GetTodos()
        {
           var result = repository.GetAllTodoItems();
           if (result == null)
           {
               return NotFound();
           }
            return Ok(result);
        }
    }
}