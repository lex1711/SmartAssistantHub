using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Mango.Services.StrategyAPI.Migrations
{
    /// <inheritdoc />
    public partial class AddFirstMigration : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Strategies",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Name = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Description = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Categories = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    ComplexityLevel = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    RecommendedFor = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Resources = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    IsAIEnhanced = table.Column<bool>(type: "bit", nullable: false),
                    CreatedAt = table.Column<DateTime>(type: "datetime2", nullable: false),
                    UpdatedAt = table.Column<DateTime>(type: "datetime2", nullable: false),
                    Tags = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Strategies", x => x.Id);
                });

            migrationBuilder.InsertData(
                table: "Strategies",
                columns: new[] { "Id", "Categories", "ComplexityLevel", "CreatedAt", "Description", "IsAIEnhanced", "Name", "RecommendedFor", "Resources", "Tags", "UpdatedAt" },
                values: new object[] { 1, "[\"Productivity\",\"Goals Manage\"]", null, new DateTime(2023, 12, 7, 13, 45, 15, 664, DateTimeKind.Utc).AddTicks(980), "Some description", false, "Teset", null, null, null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Strategies");
        }
    }
}
