using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Company.EntityLayer.Concrete
{
    [Table("EmployeeSocialMedia")]
    public class EmployeeSocialMedia : BaseEntity
    {
        public int Id { get; set; }
        public int EmployeeId { get; set; }
        [ForeignKey("EmployeeId")]
        public virtual Employee Employee { get; set; }
        public int SocialMediaId { get; set; }
        [ForeignKey("SocialMediaId")]
        public virtual SocialMedia SocialMedia { get; set; }
        public string Icon { get; set; }
        public string Url { get; set; }
    }
}
