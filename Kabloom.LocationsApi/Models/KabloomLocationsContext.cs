using Microsoft.EntityFrameworkCore;

namespace KabloomLocationsApi.Models
{
    public class KabloomLocationsContext : DbContext
    {
        public KabloomLocationsContext(DbContextOptions<KabloomLocationsContext> options) : base(options)
        {

        }

        public DbSet<Location> Locations { get; set; }

        // protected override void OnModelCreating(ModelBuilder builder)
        // {
        //     builder.Entity<Location>()
        //         .HasData()

        // }
    }
}