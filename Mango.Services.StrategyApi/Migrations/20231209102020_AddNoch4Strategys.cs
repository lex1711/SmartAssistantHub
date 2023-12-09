using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace Mango.Services.StrategyAPI.Migrations
{
    /// <inheritdoc />
    public partial class AddNoch4Strategys : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "Strategies",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2023, 12, 9, 10, 20, 20, 149, DateTimeKind.Utc).AddTicks(8770), new DateTime(2023, 12, 9, 10, 20, 20, 149, DateTimeKind.Utc).AddTicks(8770) });

            migrationBuilder.UpdateData(
                table: "Strategies",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2023, 12, 9, 10, 20, 20, 149, DateTimeKind.Utc).AddTicks(8830), new DateTime(2023, 12, 9, 10, 20, 20, 149, DateTimeKind.Utc).AddTicks(8830) });

            migrationBuilder.UpdateData(
                table: "Strategies",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2023, 12, 9, 10, 20, 20, 149, DateTimeKind.Utc).AddTicks(9010), new DateTime(2023, 12, 9, 10, 20, 20, 149, DateTimeKind.Utc).AddTicks(9010) });

            migrationBuilder.InsertData(
                table: "Strategies",
                columns: new[] { "Id", "Categories", "ComplexityLevel", "CreatedAt", "Description", "IsAIEnhanced", "Name", "RecommendedFor", "Resources", "Tags", "UpdatedAt" },
                values: new object[,]
                {
                    { 4, "[\"TimeManagement\",\"Productivity\"]", (short)1, new DateTime(2023, 12, 9, 10, 20, 20, 149, DateTimeKind.Utc).AddTicks(9040), "Техника управления временем, разбивающая работу на короткие интервалы с короткими перерывами.", false, "Pomodoro Technique", "[\"Focus Improvement\",\"Task Management\"]", "[\"https://francescocirillo.com/pages/pomodoro-technique\",\"https://en.wikipedia.org/wiki/Pomodoro_Technique\"]", "[\"Efficiency\",\"Time Management\"]", new DateTime(2023, 12, 9, 10, 20, 20, 149, DateTimeKind.Utc).AddTicks(9040) },
                    { 5, "[\"ProjectManagement\",\"Agile\"]", (short)2, new DateTime(2023, 12, 9, 10, 20, 20, 149, DateTimeKind.Utc).AddTicks(9060), "Гибкий метод управления задачами с использованием досок Канбан для визуализации рабочего процесса.", false, "Kanban Method", "[\"Workflow Management\",\"Team Collaboration\"]", "[\"https://kanbanize.com/kanban-resources/getting-started/what-is-kanban\",\"https://en.wikipedia.org/wiki/Kanban\"]", "[\"Agile\",\"Teamwork\",\"Productivity\"]", new DateTime(2023, 12, 9, 10, 20, 20, 149, DateTimeKind.Utc).AddTicks(9060) },
                    { 6, "[\"Brainstorming\",\"Creativity\"]", (short)2, new DateTime(2023, 12, 9, 10, 20, 20, 149, DateTimeKind.Utc).AddTicks(9090), "Техника визуального мышления и планирования, использующая диаграммы для отображения взаимосвязей между различными идеями или задачами.", false, "Mind Mapping", "[\"Idea Generation\",\"Problem Solving\"]", "[\"https://www.mindmapping.com/\",\"https://en.wikipedia.org/wiki/Mind_map\"]", "[\"Creativity\",\"Planning\",\"Organization\"]", new DateTime(2023, 12, 9, 10, 20, 20, 149, DateTimeKind.Utc).AddTicks(9090) },
                    { 7, "[\"TimeManagement\",\"DecisionMaking\"]", (short)1, new DateTime(2023, 12, 9, 10, 20, 20, 149, DateTimeKind.Utc).AddTicks(9110), "Метод управления задачами, основанный на разделении задач на категории по важности и срочности.", false, "Eisenhower Box", "[\"Prioritization\",\"Efficiency\"]", "[\"https://www.eisenhower.me/eisenhower-matrix/\",\"https://en.wikipedia.org/wiki/Time_management#The_Eisenhower_Method\"]", "[\"Productivity\",\"Focus\",\"Organization\"]", new DateTime(2023, 12, 9, 10, 20, 20, 149, DateTimeKind.Utc).AddTicks(9110) }
                });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Strategies",
                keyColumn: "Id",
                keyValue: 4);

            migrationBuilder.DeleteData(
                table: "Strategies",
                keyColumn: "Id",
                keyValue: 5);

            migrationBuilder.DeleteData(
                table: "Strategies",
                keyColumn: "Id",
                keyValue: 6);

            migrationBuilder.DeleteData(
                table: "Strategies",
                keyColumn: "Id",
                keyValue: 7);

            migrationBuilder.UpdateData(
                table: "Strategies",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2023, 12, 9, 10, 9, 36, 345, DateTimeKind.Utc).AddTicks(6520), new DateTime(2023, 12, 9, 10, 9, 36, 345, DateTimeKind.Utc).AddTicks(6520) });

            migrationBuilder.UpdateData(
                table: "Strategies",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2023, 12, 9, 10, 9, 36, 345, DateTimeKind.Utc).AddTicks(6570), new DateTime(2023, 12, 9, 10, 9, 36, 345, DateTimeKind.Utc).AddTicks(6570) });

            migrationBuilder.UpdateData(
                table: "Strategies",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2023, 12, 9, 10, 9, 36, 345, DateTimeKind.Utc).AddTicks(6600), new DateTime(2023, 12, 9, 10, 9, 36, 345, DateTimeKind.Utc).AddTicks(6600) });
        }
    }
}
