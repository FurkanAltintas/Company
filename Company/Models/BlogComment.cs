using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using Company.EntityLayer.Concrete;

namespace Company.Models
{
    public class BlogComment
    {
        public Blog Blog { get; set; }
        public Comment Comment { get; set; }
        public IEnumerable<Comment> CommentList { get; set; }
    }
}