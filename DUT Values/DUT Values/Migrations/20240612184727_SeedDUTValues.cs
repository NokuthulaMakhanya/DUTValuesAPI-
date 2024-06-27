using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace DUT_Values.Migrations
{
    /// <inheritdoc />
    public partial class SeedDUTValues : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.InsertData(
                table: "DUTValues",
                columns: new[] { "DUTValueId", "DUTValueName" },
                values: new object[,]
                {
                    { 1, "Transparency" },
                    { 2, "Honesty" },
                    { 3, "Integrity" },
                    { 4, "Respect" },
                    { 5, "Accountability" }
                });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "DUTValues",
                keyColumn: "DUTValueId",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "DUTValues",
                keyColumn: "DUTValueId",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "DUTValues",
                keyColumn: "DUTValueId",
                keyValue: 3);

            migrationBuilder.DeleteData(
                table: "DUTValues",
                keyColumn: "DUTValueId",
                keyValue: 4);

            migrationBuilder.DeleteData(
                table: "DUTValues",
                keyColumn: "DUTValueId",
                keyValue: 5);
        }
    }
}
