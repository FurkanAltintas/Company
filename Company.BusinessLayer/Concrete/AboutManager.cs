using Company.BusinessLayer.Abstract;
using Company.EntityLayer.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Company.DataAccessLayer.Concrete;
using System.Data.Entity;

namespace Company.BusinessLayer.Concrete
{
    public class AboutManager : Repository<About>
    {
    }
}
