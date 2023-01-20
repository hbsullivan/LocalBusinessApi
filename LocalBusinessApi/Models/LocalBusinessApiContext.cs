using Microsoft.EntityFrameworkCore;

namespace LocalBusinessApi.Models
{
  public class LocalBusinessApiContext : DbContext
  {
    public DbSet<Business> Businesses { get; set; }
    public LocalBusinessApiContext(DbContextOptions<LocalBusinessApiContext> options) : base(options)
    {
    }

    protected override void OnModelCreating(ModelBuilder builder)
    {
      builder.Entity<Business>()
          .HasData(
            new Business { BusinessId = 1, Category = "Restaurant", Name = "Henry's Homeade Hotcakes", DaysOpen = "Thursday-Monday"},
            new Business { BusinessId = 2, Category = "Jewelry", Name = "Emma's Excellent Earrings", DaysOpen = "Monday-Friday"},
            new Business { BusinessId = 3, Category = "Pets", Name = "Toby's Tremendous Treats", DaysOpen = "Monday, Wednesday, Friday"}
          );
    }
  }
}