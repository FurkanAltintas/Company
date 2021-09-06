using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Company.EntityLayer.Concrete
{
    [Table("Authority")]
    public class Authority : BaseEntity
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public ICollection<Employee> Employee { get; set; }
    }
}
