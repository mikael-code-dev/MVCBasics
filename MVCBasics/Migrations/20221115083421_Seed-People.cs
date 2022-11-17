using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace MVCBasics.Migrations
{
    public partial class SeedPeople : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.InsertData(
                table: "People",
                columns: new[] { "Id", "City", "Name", "PhoneNumber" },
                values: new object[,]
                {
                    { "10", "Buenos Aires", "Tom Andersson", "999-7777" },
                    { "11", "Hanoi", "Alma Starstruck", "888-4444" },
                    { "3", "Paris", "Jennie Antonsson", "444-4444" },
                    { "4", "London", "Sven Karlsson", "888-8888" },
                    { "5", "Stockholm", "Katarina Fors", "999-9999" },
                    { "6", "", "Wendely Blom", "222-2222" },
                    { "7", "Munich", "Hugo Magnusson", "444-2222" },
                    { "8", "Bangkok", "Alice Olsson", "111-1111" },
                    { "9", "Vladivostok", "Belly Button", "000-4444" }
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "People",
                keyColumn: "Id",
                keyValue: "10");

            migrationBuilder.DeleteData(
                table: "People",
                keyColumn: "Id",
                keyValue: "11");

            migrationBuilder.DeleteData(
                table: "People",
                keyColumn: "Id",
                keyValue: "3");

            migrationBuilder.DeleteData(
                table: "People",
                keyColumn: "Id",
                keyValue: "4");

            migrationBuilder.DeleteData(
                table: "People",
                keyColumn: "Id",
                keyValue: "5");

            migrationBuilder.DeleteData(
                table: "People",
                keyColumn: "Id",
                keyValue: "6");

            migrationBuilder.DeleteData(
                table: "People",
                keyColumn: "Id",
                keyValue: "7");

            migrationBuilder.DeleteData(
                table: "People",
                keyColumn: "Id",
                keyValue: "8");

            migrationBuilder.DeleteData(
                table: "People",
                keyColumn: "Id",
                keyValue: "9");
        }
    }
}
