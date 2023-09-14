using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace StoreApp.Migrations
{
    public partial class IdentityRoleSeedData : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.InsertData(
                table: "AspNetRoles",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[] { "32793314-8780-4462-9d14-bd99d2c4ec66", "27b43580-b26a-42b7-87dd-1846181fdab2", "User", "USER" });

            migrationBuilder.InsertData(
                table: "AspNetRoles",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[] { "97824bdc-8ad6-4668-88d7-4d84c6f6c3c4", "765e9549-0bf9-4d78-a3c0-e9a7b7c2e6e9", "Admin", "ADMIN" });

            migrationBuilder.InsertData(
                table: "AspNetRoles",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[] { "d4022b1f-2f8b-4362-a14f-0c870d83fa3b", "d1bdb7d7-1697-4e3f-8a89-8cc9ee2de5ea", "Editor", "EDITOR" });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "32793314-8780-4462-9d14-bd99d2c4ec66");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "97824bdc-8ad6-4668-88d7-4d84c6f6c3c4");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "d4022b1f-2f8b-4362-a14f-0c870d83fa3b");
        }
    }
}
