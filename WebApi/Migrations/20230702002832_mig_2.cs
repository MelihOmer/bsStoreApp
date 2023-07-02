using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace WebApi.Migrations
{
    public partial class mig_2 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "087099ca-d296-4f2a-a2ef-bb04030095d8");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "5063a646-c228-43cc-a196-f65a1afc4a9d");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "f7d69944-3a82-4b94-b935-dd007212b5f2");

            migrationBuilder.InsertData(
                table: "AspNetRoles",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[] { "04d4a88a-9969-4a77-8776-f18ccf26f0ea", "4e730005-0015-4f71-92ea-3986adca9f67", "User", "USER" });

            migrationBuilder.InsertData(
                table: "AspNetRoles",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[] { "310eb11f-2768-44fc-aaff-9cd9813ccf83", "4cc1fb1b-7441-4089-8fe6-fbc5e017b0cd", "Editor", "EDITOR" });

            migrationBuilder.InsertData(
                table: "AspNetRoles",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[] { "bc0277fb-f40f-4742-9524-06857f84ce3f", "fdd456ff-384a-4070-871a-66fff598a4d7", "Admin", "ADMIN" });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "04d4a88a-9969-4a77-8776-f18ccf26f0ea");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "310eb11f-2768-44fc-aaff-9cd9813ccf83");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "bc0277fb-f40f-4742-9524-06857f84ce3f");

            migrationBuilder.InsertData(
                table: "AspNetRoles",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[] { "087099ca-d296-4f2a-a2ef-bb04030095d8", "e827d03d-b548-4e64-854a-08b596bfdacd", "Editor", "EDITOR" });

            migrationBuilder.InsertData(
                table: "AspNetRoles",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[] { "5063a646-c228-43cc-a196-f65a1afc4a9d", "1b81b972-947a-49b6-8902-6ecd82b9da9f", "User", "USER" });

            migrationBuilder.InsertData(
                table: "AspNetRoles",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[] { "f7d69944-3a82-4b94-b935-dd007212b5f2", "aff893e2-318f-4059-b7b2-4902b9e035ea", "Admin", "ADMIN" });
        }
    }
}
