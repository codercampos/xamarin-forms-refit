using System.Collections.Generic;
using System.Linq;
using Api.Data;
using Api.Repositories;
using Microsoft.AspNetCore.Mvc;

namespace Api.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class TodosController : Controller
    {
        public List<Todo> Todos => new List<Todo>
        {
                new Todo { Id = 1, Title = "One elemenet", Description = "This is a description of your task", Done = false },
                new Todo { Id = 2, Title = "Two elemenet", Description = "This is a description of your task", Done = true },
                new Todo { Id = 3, Title = "Three elemenet", Description = "This is a description of your task", Done = false },
                new Todo { Id = 4, Title = "Four elemenet", Description = "This is a description of your task", Done = true },
                new Todo { Id = 5, Title = "Five elemenet", Description = "This is a description of your task", Done = false },
                new Todo { Id = 6, Title = "Six elemenet", Description = "This is a description of your task", Done = true },
                new Todo { Id = 7, Title = "Seven elemenet", Description = "This is a description of your task", Done = false },
                new Todo { Id = 8, Title = "Eight elemenet", Description = "This is a description of your task", Done = true },
                new Todo { Id = 9, Title = "Nine elemenet", Description = "This is a description of your task", Done = false },
                new Todo { Id = 10, Title = "Ten elemenet", Description = "This is a description of your task", Done = true }
        };
        public TodosController(ITodoRepository todoRepository)
        {

        }
        [HttpGet]
        public ActionResult<object> Get()
        {
            return Todos;
        }
        [HttpGet("/{id}")]
        public ActionResult<object> Get(int id)
        {
            return Todos.FirstOrDefault(x => x.Id == id);
        }
    }
}
