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
	}
}

