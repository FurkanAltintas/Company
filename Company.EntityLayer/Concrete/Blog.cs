using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Company.EntityLayer.Concrete
{
    [Table("Blog")]
    public class Blog : BaseEntity
    {
        public int Id { get; set; }
        public int EmployeeId { get; set; }
        [ForeignKey("EmployeeId")]
        public virtual Employee Employee { get; set; }
        public int CategoryId { get; set; }
        [ForeignKey("CategoryId")]
        public virtual Category Category { get; set; }
        public string Title { get; set; }
        public string Contents { get; set; }
        public string Image { get; set; }
        public ICollection<Comment> Comment { get; set; }
        public ICollection<BlogTag> BlogTag { get; set; }
    }
}
