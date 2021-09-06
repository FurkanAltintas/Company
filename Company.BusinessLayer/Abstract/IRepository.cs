using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Company.BusinessLayer.Abstract
{
    public interface IRepository<T> where T : class
    {
        List<T> GetList();
        void Add(T p);
        void Update(T p);
        void Delete(T p);
        void DeleteId(object id);
        int Save();
        T GetById(int id);
    }
}
