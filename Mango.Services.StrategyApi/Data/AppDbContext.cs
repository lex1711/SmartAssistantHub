using System;
using Mango.Services.StrategyApi.Models;
using Mango.Services.StrategyAPI;
using Microsoft.EntityFrameworkCore;

namespace Mango.Services.StrategyApi.Data
{
	public class AppDbContext: DbContext
    {
		public AppDbContext(DbContextOptions<AppDbContext> options): base(options)
		{
			
		}

		public DbSet<Strategy> Strategies { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);

            _ = modelBuilder.Entity<Strategy>().HasData(new Strategy
            {
                Id = 1,
                Name = "Teset",
                Description = "Some description",
                Categories = new List<string>
                {
                    "Productivity",
                    "Goals Manage"
                },
                CreatedAt = DateTime.UtcNow

            });
                
        }
    }
}

