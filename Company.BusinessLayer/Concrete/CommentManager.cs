using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Company.BusinessLayer.Abstract;
using Company.DataAccessLayer.Abstract;
using Company.EntityLayer.Concrete;

namespace Company.BusinessLayer.Concrete
{
    public class CommentManager : ICommentService
    {
        ICommentDal _commentDal;

        public CommentManager(ICommentDal commentDal)
        {
            _commentDal = commentDal;
        }

        public void Add(Comment comment)
        {
            _commentDal.Add(comment);
        }

        public void Delete(int id)
        {
            var key = _commentDal.Get(x => x.Id == id);
            _commentDal.Delete(key);
        }

        public void Update(Comment comment)
        {
            _commentDal.Update(comment);
        }

        public List<Comment> List()
        {
            return _commentDal.GetAll();
        }

        public List<Comment> GetById(int id)
        {
            return _commentDal.GetAll(x => x.BlogId == id);
        }

        public Comment GetId(int id)
        {
            return _commentDal.Get(x => x.Id == id);
        }
    }
}
