using System;
namespace Api.Data
{
    public class Todo : Entity<int>
    {
        public string Title { get; set; }
        public string Description { get; set; }
        public bool Done { get; set; }
    }
}
