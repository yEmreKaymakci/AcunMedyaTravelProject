using System.Data.Entity;
using AcunMedyaTravelProject.Entities;

namespace AcunMedyaTravelProject.Context
{
    public class AcunmedyaDbContext : DbContext
    {
        //tablonun adını(yani entitiesdeki sınıfın adını) veri tabanında ne isimlendireceğimizin adı car -> cars
        public DbSet<Category> Categories { get; set; }
        public DbSet<Testimonial> Testimonials { get; set; }
        public DbSet<Destination> Destinations { get; set; }
        public DbSet<Slider> Sliders { get; set; }
        public DbSet<Services> Services { get; set; }   
        public DbSet<Guide> Guides { get; set; }
        public DbSet<Partner> Partners { get; set; }
        public DbSet<Tour> Tours { get; set; }
        public DbSet<Admin> Admins { get; set; }

    }
}