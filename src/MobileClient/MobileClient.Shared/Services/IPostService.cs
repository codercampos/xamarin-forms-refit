using System.Collections.Generic;
using System.Threading.Tasks;
using MobileClient.Shared.Models;
using Refit;

namespace MobileClient.Shared.Services
{
    public interface IPostService
    {
        [Get("/todos/")]
        Task<List<Post>> GetTodos();

        [Get("/todos/")]
        Task<Post> GetTodo([Query] int id);

        [Get("/todo/searchByName")]
        Task<List<Post>> GetByName([Query] string name);
    }
}
