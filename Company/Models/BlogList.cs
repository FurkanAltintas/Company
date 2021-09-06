using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using Company.EntityLayer.Concrete;

namespace Company.Models
{
    public class BlogList
    {
        public IEnumerable<Blog> Blog { get; set; }
        public IEnumerable<Blog> Archive { get; set; }
        public IEnumerable<Comment> Comment { get; set; }
        public IEnumerable<Category> Category { get; set; }
    }
}