using Api.Data;

namespace Api.Repositories
{
    public class TodoRepository : Repository<Todo>, ITodoRepository
    {
        
        public TodoRepository()
        {
            Add(new Todo { Title = "Example 1", Description = "This should be an example to remind you something later" });
            Add(new Todo { Title = "Example 2", Description = "This should be an example to remind you something later" });
            Add(new Todo { Title = "Example 3", Description = "This should be an example to remind you something later", Done = true });
            Add(new Todo { Title = "Example 4", Description = "This should be an example to remind you something later" });
            Add(new Todo { Title = "Example 5", Description = "This should be an example to remind you something later" });
            Add(new Todo { Title = "Example 6", Description = "This should be an example to remind you something later", Done = true });
            Add(new Todo { Title = "Example 7", Description = "This should be an example to remind you something later" });
        }
    }

    public interface ITodoRepository : IRepository<Todo>
    {

    }
}
