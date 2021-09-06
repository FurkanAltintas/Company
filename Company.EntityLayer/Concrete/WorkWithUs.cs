using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Company.EntityLayer.Concrete
{
    [Table("WorkWithUs")]
    public class WorkWithUs : BaseEntity
    {
        public int Id { get; set; }
        public string Title { get; set; }
        public string Contents { get; set; }
        public string Image { get; set; }
    }
}
