using Microsoft.EntityFrameworkCore;

public class AppDbContext : DbContext
{
    public DbSet<Site> MasterSiteList { get; set; }

    // Lägg till denna egenskap för anslutningssträngen
    public string DefaultConnection { get; set; }

    public AppDbContext(DbContextOptions<AppDbContext> options) : base(options)
    {
    }

    protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
    {
        // Använd anslutningssträngen från egenskapen DefaultConnection
        optionsBuilder.UseSqlServer(DefaultConnection);
    }
}
