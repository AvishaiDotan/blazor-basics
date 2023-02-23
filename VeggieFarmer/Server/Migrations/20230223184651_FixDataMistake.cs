using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace VeggieFarmer.Server.Migrations
{
    /// <inheritdoc />
    public partial class FixDataMistake : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 7,
                column: "CategoryId",
                value: 2);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 7,
                column: "CategoryId",
                value: 1);
        }
    }
}
