using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace kalashop.Migrations
{
    /// <inheritdoc />
    public partial class login : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "27a34882-bad2-443d-96d7-87a45629cb60");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "3a481740-33b3-408d-b59d-199ac92e756e");

            migrationBuilder.InsertData(
                table: "AspNetRoles",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[,]
                {
                    { "8d1a4c59-5b15-4b4b-bbdb-01a19196da23", null, "User", "USER" },
                    { "d4f938a2-e5ae-4a6f-ba73-a2edc00fc9cf", null, "Admin", "ADMIN" }
                });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "8d1a4c59-5b15-4b4b-bbdb-01a19196da23");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "d4f938a2-e5ae-4a6f-ba73-a2edc00fc9cf");

            migrationBuilder.InsertData(
                table: "AspNetRoles",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[,]
                {
                    { "27a34882-bad2-443d-96d7-87a45629cb60", null, "User", "USER" },
                    { "3a481740-33b3-408d-b59d-199ac92e756e", null, "Admin", "ADMIN" }
                });
        }
    }
}
