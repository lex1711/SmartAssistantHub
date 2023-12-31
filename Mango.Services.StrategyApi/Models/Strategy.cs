﻿using System;
using System.ComponentModel.DataAnnotations;
using Microsoft.AspNetCore.Mvc;

namespace Mango.Services.StrategyApi.Models
{
    public class Strategy
    {

        [Key]
        public int Id { get; set; }
        [Required]
        public required string Name { get; set; }
        [Required]
        public required string Description { get; set; }
        public List<string>? Categories { get; set; } // Список категорий
        public Int16? ComplexityLevel { get; set; } // Уровень сложности
        public List<string>? RecommendedFor { get; set; } // Рекомендуемые типы задач
        public List<string>? Resources { get; set; } // Ссылки на ресурсы (статьи, видео)
        public bool IsAIEnhanced { get; set; } // Поддержка усиления через ИИ
        public DateTime CreatedAt { get; set; }
        public DateTime UpdatedAt { get; set; }
        public List<string>? Tags { get; set; } // Теги для поиска и фильтрации

        public Strategy() { }

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

