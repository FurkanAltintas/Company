using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Company.EntityLayer.Concrete
{
    [Table("Services")]
    public class Services : BaseEntity
    {
        public int Id { get; set; }
        public string Title { get; set; }
        public string Contents { get; set; }
        public string Icon { get; set; }
    }
}
