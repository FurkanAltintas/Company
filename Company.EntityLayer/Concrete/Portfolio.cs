using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Company.EntityLayer.Concrete
{
    [Table("Portfolio")]
    public class Portfolio : BaseEntity
    {
        public int Id { get; set; }
        public int PortfolioCategoryId { get; set; }
        [ForeignKey("PortfolioCategoryId")]
        public virtual PortfolioCategory PortfolioCategory { get; set; }
        public string Title { get; set; }
        public string SubTitle { get; set; }
        public string Image { get; set; }
    }
}
