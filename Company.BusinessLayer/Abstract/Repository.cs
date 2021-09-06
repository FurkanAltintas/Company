using Company.DataAccessLayer.Concrete;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Company.BusinessLayer.Abstract
{
    public class Repository<T> : IRepository<T> where T : class
    {
        private readonly Context c = new Context();
        private readonly DbSet<T> _obj;

        public Repository()
        {
            _obj = c.Set<T>();
        }

        public void Add(T p)
        {
            _obj.Add(p);
            Save();
        }

        public void Delete(T p)
        {
            _obj.Remove(p);
            Save();
        }

        public void DeleteId(object id)
        {
            T key = _obj.Find(id);
            if (key != null) _obj.Remove(key);
        }

        public T GetById(int id)
        {
            return _obj.Find(id);
        }

        public List<T> GetList()
        {
            return _obj.ToList();
        }

        public int Save()
        {
            return c.SaveChanges();
        }

        public void Update(T p)
        {
            _obj.Attach(p);
            c.Entry(p).State = EntityState.Modified;
            Save();
        }
    }
}
