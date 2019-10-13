using System;
namespace Api.Data
{
    public class Comment : Entity
    {
        public string Author { get; set; }
        public string Description { get; set; }
    }
}
