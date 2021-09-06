using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Company.EntityLayer.Abstract;

namespace Company.EntityLayer.Concrete
{
    [Table("Comment")]
    public class Comment : BaseEntity, IEntity
    {
        public int Id { get; set; }
        public int BlogId { get; set; }
        [ForeignKey("BlogId")]
        public virtual Blog Blog { get; set; }

        public string Name { get; set; }
        public string Email { get; set; }
        public string Website { get; set; }
        public string Message { get; set; }
    }
}
