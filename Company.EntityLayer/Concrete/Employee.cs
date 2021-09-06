using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Company.EntityLayer.Concrete
{
    [Table("Employee")]
    public class Employee : BaseEntity
    {
        public int Id { get; set; }
        public int AuthorityId { get; set; }
        [ForeignKey("AuthorityId")]
        public virtual Authority Authority { get; set; }
        public string Name { get; set; }
        public string Surname { get; set; }
        public string FullName { get { return string.Concat(Name + " " + Surname); } }
        public string Degree { get; set; }
        public string Image { get; set; }
        public string Email { get; set; }
        public string Password { get; set; }
        public string RPassword { get; set; }
        public ICollection<EmployeeSocialMedia> EmployeeSocialMedia { get; set; }
        public ICollection<Blog> Blog { get; set; }
    }
}
