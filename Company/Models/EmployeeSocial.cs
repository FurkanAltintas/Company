using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using Company.EntityLayer.Concrete;

namespace Company.Models
{
    public class EmployeeSocial
    {
        public IEnumerable<Employee> Employee { get; set; }
        public IEnumerable<EmployeeSocialMedia> EmployeeSocialMedia { get; set; }
    }
}