using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using Company.EntityLayer.Concrete;

namespace Company.Models
{
    public class PortfolioType
    {
        public IEnumerable<Portfolio> Portfolio { get; set; }
        public IEnumerable<PortfolioCategory> PortfolioCategory { get; set; }
    }
}