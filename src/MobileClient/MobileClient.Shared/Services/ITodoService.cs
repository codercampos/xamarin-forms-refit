using System;
using System.Collections.Generic;
using System.Threading.Tasks;
using MobileClient.Shared.Models;
using Refit;

namespace MobileClient.Shared.Services
{
    public interface ITodoService
    {
        [Get("/todos/")]
        Task<List<Todo>> GetTodos();

        //[Get("/todos/{id}")]
        //Task<Todo> GetTodo([Query] int id);

        [Get("/todo/searchByName")]
        Task<List<Todo>> GetByName([Query] string name);
    }
}
