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

            modelBuilder.Entity<Strategy>().HasData(new Strategy
            {
                Id = 1,
                Name = "SMART Goals",
                Description = "Техника, помогающая формулировать цели так, чтобы они были конкретными, измеримыми, достижимыми, релевантными и ограниченными по времени.",
                Categories = new List<string> { "GoalSetting", "Personal Development" },
                CreatedAt = DateTime.UtcNow,
                UpdatedAt = DateTime.UtcNow,
                Resources = new List<string> { "https://en.wikipedia.org/wiki/SMART_criteria", "https://www.mindtools.com/pages/article/smart-goals.htm" },
                RecommendedFor = new List<string> { "Productivity", "Project Management" },
                ComplexityLevel = 1,
                IsAIEnhanced = false,
                Tags = new List<string> { "Career", "Personal Growth" }
            });


            modelBuilder.Entity<Strategy>().HasData(new Strategy
            {
                Id = 2,
                Name = "OKR - Objectives and Key Results",
                Description = "Система установления и отслеживания целей, использующая конкретные и ключевые результаты для измерения прогресса.",
                Categories = new List<string> { "GoalSetting", "Performance Management" },
                CreatedAt = DateTime.UtcNow,
                UpdatedAt = DateTime.UtcNow,
                Resources = new List<string> { "https://en.wikipedia.org/wiki/OKR", "https://www.whatmatters.com/faqs/okr-meaning-definition-example/" },
                RecommendedFor = new List<string> { "Team Management", "Organizational Development" },
                ComplexityLevel = 3,
                IsAIEnhanced = false,
                Tags = new List<string> { "Business", "Teamwork", "Leadership" }
            });


            modelBuilder.Entity<Strategy>().HasData(new Strategy
            {
                Id = 3,
                Name = "Goal Visualization",
                Description = "Техника визуализации целей, помогающая укрепить мотивацию и представление о конечных результатах.",
                Categories = new List<string> { "GoalSetting", "Motivation" },
                CreatedAt = DateTime.UtcNow,
                UpdatedAt = DateTime.UtcNow,
                Resources = new List<string> { "https://positivepsychology.com/goal-visualization-techniques/" },
                RecommendedFor = new List<string> { "Personal Growth", "Motivation" },
                ComplexityLevel = 2,
                IsAIEnhanced = false,
                Tags = new List<string> { "Self-improvement", "Motivation" }
            });

        }
    }
}

