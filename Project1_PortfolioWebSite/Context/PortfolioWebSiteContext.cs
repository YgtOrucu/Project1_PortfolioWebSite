using Microsoft.EntityFrameworkCore;
using Project1_PortfolioWebSite.Entities;

namespace Project1_PortfolioWebSite.Context
{
    public class PortfolioWebSiteContext:DbContext
    {
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer("DB_ADRESİ");
        }

        public DbSet<About> Abouts { get; set; }
        public DbSet<Category> Categories { get; set; }
        public DbSet<Contact> Contacts { get; set; }
        public DbSet<Experience> Experiences { get; set; }
        public DbSet<Message> Messages { get; set; }
        public DbSet<Portfolio> Portfolios { get; set; }
        public DbSet<Service> Services { get; set; }
        public DbSet<Testimonial> Testimonials { get; set; }
        public DbSet<Education> Educations { get; set; }
        public DbSet<Skills> Skills { get; set; }
    }
}
