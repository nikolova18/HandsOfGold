namespace HandsOfGold.Data
{
    using HandsOfGold.Data.Models;
    using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
    using Microsoft.EntityFrameworkCore;

    public class AdSiteDbContext : IdentityDbContext
    {
        public DbSet<Product> Products { get; init; }

        public AdSiteDbContext(DbContextOptions<AdSiteDbContext> options)
            : base(options)
        {
        }
    }
}
