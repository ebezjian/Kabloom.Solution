using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;

namespace KabloomClient.Models
{
    public class KabloomClientContext : IdentityDbContext<ApplicationUser>
    {
        public DbSet<Plant> Plants { get; set; }

        public KabloomClientContext(DbContextOptions options) : base(options) { }
    }
}