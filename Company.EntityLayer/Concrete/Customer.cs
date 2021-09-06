using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Company.EntityLayer.Concrete
{
    [Table("Customer")]
    public class Customer : BaseEntity
    {
        public int Id { get; set; }
        public string FullName { get; set; }
        public string Degree { get; set; }
        public string Image { get; set; }
        public string Contents { get; set; }
    }
}
