using Microsoft.EntityFrameworkCore;
using MyNFTTracker.Models;

namespace MyNFTTracker
{
    public class MyNFTTrackerContext : DbContext
    {
        public DbSet<AppUser> Users { get; set; } = null!;
        public DbSet<Project> Projects { get; set; } = null!;
        public DbSet<NonFungibleToken> NonFungibleToken { get; set; } = null!;

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            var configuration = new ConfigurationBuilder()
                .SetBasePath(AppDomain.CurrentDomain.BaseDirectory)//S:\V1\MySolTracker\bin\Debug\net6.0\
                .AddJsonFile("appsettings.json")
                .Build();
            optionsBuilder.UseSqlServer(configuration.GetConnectionString("DevConnection"));
        }
    }
}
