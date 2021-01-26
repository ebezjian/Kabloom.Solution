using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;

namespace KabloomApi.Models
{
  public class KabloomApiContext : IdentityDbContext<ApplicationUser>
  {
    public DbSet<Plant> Plants { get; set; }

    public KabloomApiContext(DbContextOptions options) : base(options) { }
  }
}