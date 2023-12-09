using System;
using Mango.Services.StrategyApi.Models;
using Mango.Services.StrategyAPI;
using Microsoft.EntityFrameworkCore;

namespace Mango.Services.StrategyApi.Data
{
    public class AppDbContext : DbContext
    {
        public AppDbContext(DbContextOptions<AppDbContext> options) : base(options)
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

            modelBuilder.Entity<Strategy>().HasData(new Strategy
            {
                Id = 4,
                Name = "Pomodoro Technique",
                Description = "Техника управления временем, разбивающая работу на короткие интервалы с короткими перерывами.",
                Categories = new List<string> { "TimeManagement", "Productivity" },
                CreatedAt = DateTime.UtcNow,
                UpdatedAt = DateTime.UtcNow,
                Resources = new List<string> { "https://francescocirillo.com/pages/pomodoro-technique", "https://en.wikipedia.org/wiki/Pomodoro_Technique" },
                RecommendedFor = new List<string> { "Focus Improvement", "Task Management" },
                ComplexityLevel = 1,
                IsAIEnhanced = false,
                Tags = new List<string> { "Efficiency", "Time Management" }
            });
            modelBuilder.Entity<Strategy>().HasData(new Strategy
            {
                Id = 5,
                Name = "Kanban Method",
                Description = "Гибкий метод управления задачами с использованием досок Канбан для визуализации рабочего процесса.",
                Categories = new List<string> { "ProjectManagement", "Agile" },
                CreatedAt = DateTime.UtcNow,
                UpdatedAt = DateTime.UtcNow,
                Resources = new List<string> { "https://kanbanize.com/kanban-resources/getting-started/what-is-kanban", "https://en.wikipedia.org/wiki/Kanban" },
                RecommendedFor = new List<string> { "Workflow Management", "Team Collaboration" },
                ComplexityLevel = 2,
                IsAIEnhanced = false,
                Tags = new List<string> { "Agile", "Teamwork", "Productivity" }
            });
            modelBuilder.Entity<Strategy>().HasData(new Strategy
            {
                Id = 6,
                Name = "Mind Mapping",
                Description = "Техника визуального мышления и планирования, использующая диаграммы для отображения взаимосвязей между различными идеями или задачами.",
                Categories = new List<string> { "Brainstorming", "Creativity" },
                CreatedAt = DateTime.UtcNow,
                UpdatedAt = DateTime.UtcNow,
                Resources = new List<string> { "https://www.mindmapping.com/", "https://en.wikipedia.org/wiki/Mind_map" },
                RecommendedFor = new List<string> { "Idea Generation", "Problem Solving" },
                ComplexityLevel = 2,
                IsAIEnhanced = false,
                Tags = new List<string> { "Creativity", "Planning", "Organization" }
            });
            modelBuilder.Entity<Strategy>().HasData(new Strategy
            {
                Id = 7,
                Name = "Eisenhower Box",
                Description = "Метод управления задачами, основанный на разделении задач на категории по важности и срочности.",
                Categories = new List<string> { "TimeManagement", "DecisionMaking" },
                CreatedAt = DateTime.UtcNow,
                UpdatedAt = DateTime.UtcNow,
                Resources = new List<string> { "https://www.eisenhower.me/eisenhower-matrix/", "https://en.wikipedia.org/wiki/Time_management#The_Eisenhower_Method" },
                RecommendedFor = new List<string> { "Prioritization", "Efficiency" },
                ComplexityLevel = 1,
                IsAIEnhanced = false,
                Tags = new List<string> { "Productivity", "Focus", "Organization" }
            });
        }
    }
}