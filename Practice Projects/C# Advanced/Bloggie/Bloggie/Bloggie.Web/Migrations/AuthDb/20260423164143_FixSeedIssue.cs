using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Bloggie.Web.Migrations.AuthDb
{
    /// <inheritdoc />
    public partial class FixSeedIssue : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "2a839305-08be-46d2-b490-79bfbf98aeb6",
                column: "NormalizedName",
                value: "USER");

            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "571088a7-aad3-48d4-833b-4eb75d6afffe",
                column: "NormalizedName",
                value: "ADMIN");

            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "5dd4c8ba-8e5c-4437-b2fa-c5436d4ee1d8",
                column: "NormalizedName",
                value: "SUPERADMIN");

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "929a2627-cb4b-47cc-912f-4389df51eff7",
                columns: new[] { "ConcurrencyStamp", "NormalizedEmail", "NormalizedUserName", "PasswordHash", "SecurityStamp" },
                values: new object[] { "929a2627-cb4b-47cc-912f-4389df51eff7", "SUPERADMIN@BLOGGIE.COM", "SUPERADMIN@BLOGGIE.COM", "AQAAAAEAAYagAAAAEAARIjNEVWZ3iJmqu8zd7v9G3aY3iqsKoPleGJ/P2c8JeppSmy4zWMEu7Nd69ijz5A==", "929a2627-cb4b-47cc-912f-4389df51eff7" });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "2a839305-08be-46d2-b490-79bfbf98aeb6",
                column: "NormalizedName",
                value: "Usser");

            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "571088a7-aad3-48d4-833b-4eb75d6afffe",
                column: "NormalizedName",
                value: "Admin");

            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "5dd4c8ba-8e5c-4437-b2fa-c5436d4ee1d8",
                column: "NormalizedName",
                value: "SuperAdmin");

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "929a2627-cb4b-47cc-912f-4389df51eff7",
                columns: new[] { "ConcurrencyStamp", "NormalizedEmail", "NormalizedUserName", "PasswordHash", "SecurityStamp" },
                values: new object[] { "05565f41-2dd4-489c-a973-88b306150872", null, null, "AQAAAAIAAYagAAAAEI+djav1/gxMeYgBBVJk0xtjupMhPzjggqCXpTnh5hGJwk+KBf4Z890pCOxGNIWE0A==", "1491ceee-46c6-4321-9fd4-1e971f629bef" });
        }
    }
}
