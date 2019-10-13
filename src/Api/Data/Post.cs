using System;
using System.Collections.Generic;

namespace Api.Data
{
    public class Post : Entity
    {
        public string Author { get; set; }
        public string Abstract { get; set; }
        public bool Approved { get; set; }
        public IList<Comment> Comments { get; set; }
    }
}
