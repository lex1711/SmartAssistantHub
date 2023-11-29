using System;
namespace Mango.Services.StrategyApi.Models
{
	public class Strategy
    {

        public int Id { get; set; }
        public string Name { get; set; }
        public string Description { get; set; }
        public List<string>? Categories { get; set; } // Список категорий
        public string? ComplexityLevel { get; set; } // Уровень сложности
        public string? RecommendedFor { get; set; } // Рекомендуемые типы задач
        public List<string>? Resources { get; set; } // Ссылки на ресурсы (статьи, видео)
        public bool IsAIEnhanced { get; set; } // Поддержка усиления через ИИ
        public DateTime CreatedAt { get; set; }
        public DateTime UpdatedAt { get; set; }
        public List<string>? Tags { get; set; } // Теги для поиска и фильтрации

        
        public enum TechniqueCategory
           {       
        TimeManagement,
        Productivity,
        GoalSetting,
        StressManagement,
        Others
        // Другие категории по необходимости
        }
    }
}

