using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace CafeReserve.Migrations
{
    public partial class UpdateAdminUser : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "UserId",
                keyValue: 1,
                columns: new[] { "Password", "Username" },
                values: new object[] { "12345", "sena" });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "UserId",
                keyValue: 1,
                columns: new[] { "Password", "Username" },
                values: new object[] { "1234", "admin" });
        }
    }
}
