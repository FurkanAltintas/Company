﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Company.DataAccessLayer.Abstract;
using Company.EntityLayer.Concrete;

namespace Company.DataAccessLayer.Concrete
{
    public class EfCommentDal : GenericRepository<Comment,Context>,ICommentDal
    {
    }
}
