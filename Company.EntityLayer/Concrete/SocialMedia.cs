using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;

namespace Company.EntityLayer.Concrete
{
    [Table("SocialMedia")]
    public class SocialMedia : BaseEntity
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public ICollection<CompanySocialMedia> CompanySocialMedia { get; set; }
        public ICollection<EmployeeSocialMedia> EmployeeSocialMedia { get; set; }
    }
}
