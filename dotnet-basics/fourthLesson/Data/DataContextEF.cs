using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using MyApp.Models;

namespace MyApp.Data
{

    public class DataContextEF(IConfiguration config) : DbContext
    {

        private readonly IConfiguration _config = config;

        protected override void OnConfiguring(DbContextOptionsBuilder options)
        {
            if (!options.IsConfigured)
            {
                options.UseSqlServer(_config.GetConnectionString("DefaultConnection"),
                options => options.EnableRetryOnFailure());
            }
        }


        public DbSet<Computer>? Computer { get; set; }


        protected override void OnModelCreating(ModelBuilder builder)
        {
            builder.HasDefaultSchema("TutorialAppSchema");
            builder.Entity<Computer>().HasKey(c => c.ComputerId);
        }

    }
}