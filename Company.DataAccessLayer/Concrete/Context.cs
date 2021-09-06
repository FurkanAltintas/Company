using Company.EntityLayer.Concrete;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Company.DataAccessLayer.Concrete
{
    public class Context : DbContext
    {
        public Context() : base("Company")
        {

        }

        public DbSet<About> About { get; set; }
        public DbSet<Authority> Authority { get; set; }
        public DbSet<Blog> Blog { get; set; }
        public DbSet<Category> Category { get; set; }
        public DbSet<Comment> Comment { get; set; }
        public DbSet<CompanySocialMedia> CompanySocialMedia { get; set; }
        public DbSet<Contact> Contact { get; set; }
        public DbSet<Customer> Customer { get; set; }
        public DbSet<Employee> Employee { get; set; }
        public DbSet<EmployeeSocialMedia> EmployeSocialMedia { get; set; }
        public DbSet<Footer> Footer { get; set; }
        public DbSet<Portfolio> Portfolio { get; set; }
        public DbSet<PortfolioCategory> PortfolioCategory { get; set; }
        public DbSet<Services> Services { get; set; }
        public DbSet<Slider> Slider { get; set; }
        public DbSet<SocialMedia> SocialMedia { get; set; }
        public DbSet<WorkWithUs> WorkWithUs { get; set; }
    }
}
