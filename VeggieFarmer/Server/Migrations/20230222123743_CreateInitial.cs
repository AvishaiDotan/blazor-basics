using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace VeggieFarmer.Server.Migrations
{
    /// <inheritdoc />
    public partial class CreateInitial : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Products",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Title = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Description = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    ImgUrl = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Price = table.Column<decimal>(type: "decimal(18,2)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Products", x => x.Id);
                });

            migrationBuilder.InsertData(
                table: "Products",
                columns: new[] { "Id", "Description", "ImgUrl", "Price", "Title" },
                values: new object[,]
                {
                    { 1, "Tomato is a juicy berry used in cooking, high in vitamins and minerals.", "https://upload.wikimedia.org/wikipedia/commons/thumb/8/89/Tomato_je.jpg/330px-Tomato_je.jpg", 9.99m, "Tomato" },
                    { 2, "Cucumber is a green, refreshing vegetable, low in calories and high in vitamins and minerals.", "https://upload.wikimedia.org/wikipedia/commons/thumb/9/96/ARS_cucumber.jpg/800px-ARS_cucumber.jpg", 5.99m, "Cucumber" },
                    { 3, "Carrot is an orange root vegetable, sweet and crunchy, high in vitamins and minerals.", "https://upload.wikimedia.org/wikipedia/commons/thumb/a/a2/Vegetable-Carrot-Bundle-wStalks.jpg/1024px-Vegetable-Carrot-Bundle-wStalks.jpg", 2.99m, "Carrot" },
                    { 4, "Radish is a crunchy, spicy root vegetable, low in calories and high in vitamins and minerals.", "https://upload.wikimedia.org/wikipedia/commons/thumb/0/0c/Radish_3371103037_4ab07db0bf_o.jpg/800px-Radish_3371103037_4ab07db0bf_o.jpg", 12.99m, "Radish" },
                    { 5, "Turnip is a root vegetable with a slightly sweet and earthy flavor.", "https://upload.wikimedia.org/wikipedia/commons/d/d3/Turnip_2622027.jpg", 3.99m, "Turnip" }
                });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Products");
        }
    }
}
