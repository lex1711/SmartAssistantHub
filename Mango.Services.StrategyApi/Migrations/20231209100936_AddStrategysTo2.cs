using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace Mango.Services.StrategyAPI.Migrations
{
    /// <inheritdoc />
    public partial class AddStrategysTo2 : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AlterColumn<short>(
                name: "ComplexityLevel",
                table: "Strategies",
                type: "smallint",
                nullable: true,
                oldClrType: typeof(string),
                oldType: "nvarchar(max)",
                oldNullable: true);

            migrationBuilder.UpdateData(
                table: "Strategies",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "Categories", "ComplexityLevel", "CreatedAt", "Description", "Name", "RecommendedFor", "Resources", "Tags", "UpdatedAt" },
                values: new object[] { "[\"GoalSetting\",\"Personal Development\"]", (short)1, new DateTime(2023, 12, 9, 10, 9, 36, 345, DateTimeKind.Utc).AddTicks(6520), "Техника, помогающая формулировать цели так, чтобы они были конкретными, измеримыми, достижимыми, релевантными и ограниченными по времени.", "SMART Goals", "[\"Productivity\",\"Project Management\"]", "[\"https://en.wikipedia.org/wiki/SMART_criteria\",\"https://www.mindtools.com/pages/article/smart-goals.htm\"]", "[\"Career\",\"Personal Growth\"]", new DateTime(2023, 12, 9, 10, 9, 36, 345, DateTimeKind.Utc).AddTicks(6520) });

            migrationBuilder.InsertData(
                table: "Strategies",
                columns: new[] { "Id", "Categories", "ComplexityLevel", "CreatedAt", "Description", "IsAIEnhanced", "Name", "RecommendedFor", "Resources", "Tags", "UpdatedAt" },
                values: new object[,]
                {
                    { 2, "[\"GoalSetting\",\"Performance Management\"]", (short)3, new DateTime(2023, 12, 9, 10, 9, 36, 345, DateTimeKind.Utc).AddTicks(6570), "Система установления и отслеживания целей, использующая конкретные и ключевые результаты для измерения прогресса.", false, "OKR - Objectives and Key Results", "[\"Team Management\",\"Organizational Development\"]", "[\"https://en.wikipedia.org/wiki/OKR\",\"https://www.whatmatters.com/faqs/okr-meaning-definition-example/\"]", "[\"Business\",\"Teamwork\",\"Leadership\"]", new DateTime(2023, 12, 9, 10, 9, 36, 345, DateTimeKind.Utc).AddTicks(6570) },
                    { 3, "[\"GoalSetting\",\"Motivation\"]", (short)2, new DateTime(2023, 12, 9, 10, 9, 36, 345, DateTimeKind.Utc).AddTicks(6600), "Техника визуализации целей, помогающая укрепить мотивацию и представление о конечных результатах.", false, "Goal Visualization", "[\"Personal Growth\",\"Motivation\"]", "[\"https://positivepsychology.com/goal-visualization-techniques/\"]", "[\"Self-improvement\",\"Motivation\"]", new DateTime(2023, 12, 9, 10, 9, 36, 345, DateTimeKind.Utc).AddTicks(6600) }
                });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Strategies",
                keyColumn: "Id",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "Strategies",
                keyColumn: "Id",
                keyValue: 3);

            migrationBuilder.AlterColumn<string>(
                name: "ComplexityLevel",
                table: "Strategies",
                type: "nvarchar(max)",
                nullable: true,
                oldClrType: typeof(short),
                oldType: "smallint",
                oldNullable: true);

            migrationBuilder.UpdateData(
                table: "Strategies",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "Categories", "ComplexityLevel", "CreatedAt", "Description", "Name", "RecommendedFor", "Resources", "Tags", "UpdatedAt" },
                values: new object[] { "[\"Productivity\",\"Goals Manage\"]", null, new DateTime(2023, 12, 9, 9, 49, 23, 400, DateTimeKind.Utc).AddTicks(6480), "Some description", "Teset", null, null, null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) });
        }
    }
}
