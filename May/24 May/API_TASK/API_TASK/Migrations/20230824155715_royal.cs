using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace API_TASK.Migrations
{
    public partial class royal : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.InsertData(
                table: "Categories",
                columns: new[] { "Id", "CategoryName", "Country", "Description", "Number" },
                values: new object[,]
                {
                    { 1, "T-Shirt", "Azerbaijan", "Beatiful", 1 },
                    { 2, "Cup", "Turkiye", "Perfect", 2 },
                    { 3, "Uniform", "Pakistan", "Nice", 3 }
                });

            migrationBuilder.InsertData(
                table: "Persons",
                columns: new[] { "Id", "PersonAge", "PersonName", "PersonNumber", "PersonSurname" },
                values: new object[,]
                {
                    { 1, 22, "Royal", 1, "Humbetov" },
                    { 2, 19, "Xeyal", 2, "Humbetli" },
                    { 3, 12, "Xeyyam", 3, "Humbetli" }
                });

            migrationBuilder.InsertData(
                table: "Products",
                columns: new[] { "Id", "Number", "ProductDescription", "ProductName" },
                values: new object[,]
                {
                    { 1, 1, "Description", "Testr" },
                    { 2, 2, "Descript", "assdf" }
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 3);

            migrationBuilder.DeleteData(
                table: "Persons",
                keyColumn: "Id",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "Persons",
                keyColumn: "Id",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "Persons",
                keyColumn: "Id",
                keyValue: 3);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 2);
        }
    }
}
