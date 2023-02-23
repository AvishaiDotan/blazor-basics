using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace VeggieFarmer.Server.Migrations
{
    /// <inheritdoc />
    public partial class SeedMoreProducts : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.InsertData(
                table: "Products",
                columns: new[] { "Id", "CategoryId", "Description", "ImgUrl", "Price", "Title" },
                values: new object[,]
                {
                    { 6, 3, "Peanut is a legume crop grown mainly for its edible seeds. It is widely grown in the tropics and subtropics, important to both small and large commercial producers.", "https://upload.wikimedia.org/wikipedia/commons/thumb/a/a4/Arachis_hypogaea_-_K%C3%B6hler%E2%80%93s_Medizinal-Pflanzen-163.jpg/330px-Arachis_hypogaea_-_K%C3%B6hler%E2%80%93s_Medizinal-Pflanzen-163.jpg", 0.99m, "Peanuts" },
                    { 7, 2, "Watermelon (Citrullus lanatus) is a flowering plant species of the Cucurbitaceae family and the name of its edible fruit. ", "https://upload.wikimedia.org/wikipedia/commons/thumb/4/47/Taiwan_2009_Tainan_City_Organic_Farm_Watermelon_FRD_7962.jpg/800px-Taiwan_2009_Tainan_City_Organic_Farm_Watermelon_FRD_7962.jpg", 32.99m, "Watermelon" }
                });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 6);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 7);
        }
    }
}
