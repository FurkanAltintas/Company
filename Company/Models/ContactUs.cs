using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using Company.EntityLayer.Concrete;

namespace Company.Models
{
    public class ContactUs
    {
        public Contact contact { get; set; }
        public Footer footer { get; set; }
    }
}