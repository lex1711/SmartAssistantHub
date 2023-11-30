using System;
using Mango.Services.StrategyAPI;
using Microsoft.EntityFrameworkCore;

namespace Mango.Services.StrategyApi.Data
{
	public class AppDbContext: DbContext
    {
		public AppDbContext(DbContextOptions<AppDbContext> options): base(options)
		{
			
		}

		public DbSet<Models.Strategy> Strategies { get; set; }
	}
}

