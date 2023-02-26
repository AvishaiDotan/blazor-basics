using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace VeggieFarmer.Server.Migrations
{
    /// <inheritdoc />
    public partial class updateToNewProducts : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_ProductTypes_Products_ProductId",
                table: "ProductTypes");

            migrationBuilder.DropIndex(
                name: "IX_ProductTypes_ProductId",
                table: "ProductTypes");

            migrationBuilder.DropColumn(
                name: "ProductId",
                table: "ProductTypes");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<int>(
                name: "ProductId",
                table: "ProductTypes",
                type: "int",
                nullable: true);

            migrationBuilder.UpdateData(
                table: "ProductTypes",
                keyColumn: "Id",
                keyValue: 1,
                column: "ProductId",
                value: null);

            migrationBuilder.UpdateData(
                table: "ProductTypes",
                keyColumn: "Id",
                keyValue: 2,
                column: "ProductId",
                value: null);

            migrationBuilder.UpdateData(
                table: "ProductTypes",
                keyColumn: "Id",
                keyValue: 3,
                column: "ProductId",
                value: null);

            migrationBuilder.UpdateData(
                table: "ProductTypes",
                keyColumn: "Id",
                keyValue: 4,
                column: "ProductId",
                value: null);

            migrationBuilder.UpdateData(
                table: "ProductTypes",
                keyColumn: "Id",
                keyValue: 5,
                column: "ProductId",
                value: null);

            migrationBuilder.UpdateData(
                table: "ProductTypes",
                keyColumn: "Id",
                keyValue: 6,
                column: "ProductId",
                value: null);

            migrationBuilder.UpdateData(
                table: "ProductTypes",
                keyColumn: "Id",
                keyValue: 7,
                column: "ProductId",
                value: null);

            migrationBuilder.UpdateData(
                table: "ProductTypes",
                keyColumn: "Id",
                keyValue: 8,
                column: "ProductId",
                value: null);

            migrationBuilder.UpdateData(
                table: "ProductTypes",
                keyColumn: "Id",
                keyValue: 9,
                column: "ProductId",
                value: null);

            migrationBuilder.UpdateData(
                table: "ProductTypes",
                keyColumn: "Id",
                keyValue: 10,
                column: "ProductId",
                value: null);

            migrationBuilder.CreateIndex(
                name: "IX_ProductTypes_ProductId",
                table: "ProductTypes",
                column: "ProductId");

            migrationBuilder.AddForeignKey(
                name: "FK_ProductTypes_Products_ProductId",
                table: "ProductTypes",
                column: "ProductId",
                principalTable: "Products",
                principalColumn: "Id");
        }
    }
}
