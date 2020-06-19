using Microsoft.EntityFrameworkCore.Migrations;

namespace Kolokwium_2.Migrations
{
    public partial class AddedSeed : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.InsertData(
                table: "Test",
                columns: new[] { "Id", "Name" },
                values: new object[] { 1, "Jan" });

            migrationBuilder.InsertData(
                table: "Test",
                columns: new[] { "Id", "Name" },
                values: new object[] { 2, "Malczewski" });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Test",
                keyColumn: "Id",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "Test",
                keyColumn: "Id",
                keyValue: 2);
        }
    }
}
