using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Company.EntityLayer.Concrete;

namespace Company.BusinessLayer.Abstract
{
    public interface ICommentService
    {
        List<Comment> List();
        List<Comment> GetById(int id);
        void Add(Comment comment);
        void Delete(int id);
        void Update(Comment comment);
        Comment GetId(int id);
    }
}
