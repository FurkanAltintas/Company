using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Company.EntityLayer.Concrete
{
    [Table("CompanySocialMedia")]
    public class CompanySocialMedia : BaseEntity
    {
        public int Id { get; set; }
        public int SocialMediaId { get; set; }
        [ForeignKey("SocialMediaId")]
        public virtual SocialMedia SocialMedia { get; set; }
        public string Icon { get; set; }
        public string Url { get; set; }
    }
}
