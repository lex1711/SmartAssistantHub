using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Mango.Services.StrategyAPI.Migrations
{
    /// <inheritdoc />
    public partial class AddStrategysToDbStrategy : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "Strategies",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedAt",
                value: new DateTime(2023, 12, 9, 9, 49, 23, 400, DateTimeKind.Utc).AddTicks(6480));
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "Strategies",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedAt",
                value: new DateTime(2023, 12, 7, 14, 25, 2, 400, DateTimeKind.Utc).AddTicks(2430));
        }
    }
}
