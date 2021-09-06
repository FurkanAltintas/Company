using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Company.EntityLayer.Concrete
{
    [Table("Category")]
    public class Category : BaseEntity
    {
        public int Id { get; set; }
        public string Title { get; set; }
        public ICollection<Blog> Blog { get; set; }
    }
}
