using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Company.EntityLayer.Concrete
{
    [Table("Footer")]
    public class Footer : BaseEntity
    {
        public int Id { get; set; }
        public string Call { get; set; }
        public string Email { get; set; }
        public string Web { get; set; }
        public string Location { get; set; }
        public string WorkingHours { get; set; }
        public string About { get; set; }
        public string Information { get; set; }
        public string Copyright { get; set; }
    }
}
