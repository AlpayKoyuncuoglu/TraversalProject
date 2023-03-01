using EntityLayer.Concrete;
using Microsoft.EntityFrameworkCore;

namespace DataAccessLayer.Concrete
{
    public class Context : DbContext
    {
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            //optionsBuilder.UseSqlServer("Data Source=PC-KOYUNCUOGLU;Initial Catalog=TraversalPro;Integrated Security=True");
            optionsBuilder.UseSqlServer("Server=PC-KOYUNCUOGLU;Database=TraversalPro;Integrated Security=True");
        }

        public DbSet<About> Abouts {get;set;}
        public DbSet<AboutSecond> AboutSeconds { get;set;}
        public DbSet<Contact> Contacts {get;set;}
        public DbSet<Destination> Destinations { get;set;}
        public DbSet<Feature> Features {get;set;}
        public DbSet<FeatureSecond> FeatureSeconds { get;set;}
        public DbSet<Guide> Guides {get;set;}
        public DbSet<Newsletter> Newsletters { get;set; }
        public DbSet<SubAbout> SubAbouts { get;set; }
        public DbSet<Testimonial> Testimonials { get;set; }
    }
}
