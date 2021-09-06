using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using Company.EntityLayer.Concrete;

namespace Company.Models
{
    public class CompanyInfo
    {
        public Footer footer { get; set; }
        public IEnumerable<CompanySocialMedia> companySocialMedia { get; set; }
    }
}