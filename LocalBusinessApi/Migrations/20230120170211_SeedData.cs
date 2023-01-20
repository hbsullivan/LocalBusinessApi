using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace LocalBusinessApi.Migrations
{
    public partial class SeedData : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.InsertData(
                table: "Businesses",
                columns: new[] { "BusinessId", "Category", "DaysOpen", "Name" },
                values: new object[] { 1, "Restaurant", "Thursday-Monday", "Henry's Homeade Hotcakes" });

            migrationBuilder.InsertData(
                table: "Businesses",
                columns: new[] { "BusinessId", "Category", "DaysOpen", "Name" },
                values: new object[] { 2, "Jewelry", "Monday-Friday", "Emma's Excellent Earrings" });

            migrationBuilder.InsertData(
                table: "Businesses",
                columns: new[] { "BusinessId", "Category", "DaysOpen", "Name" },
                values: new object[] { 3, "Pets", "Monday, Wednesday, Friday", "Toby's Tremendous Treats" });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Businesses",
                keyColumn: "BusinessId",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "Businesses",
                keyColumn: "BusinessId",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "Businesses",
                keyColumn: "BusinessId",
                keyValue: 3);
        }
    }
}
