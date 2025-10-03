using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace DataAccess.Migrations
{
    /// <inheritdoc />
    public partial class SeedData : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.InsertData(
                table: "LopHocs",
                columns: new[] { "Id", "TenLop" },
                values: new object[,]
                {
                    { 1, "CNTT 1" },
                    { 2, "CNTT 2" }
                });

            migrationBuilder.InsertData(
                table: "SinhViens",
                columns: new[] { "Id", "HoTen", "LopHocId" },
                values: new object[,]
                {
                    { 1, "Nguyen Van A", 1 },
                    { 2, "Tran Thi B", 2 }
                });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "SinhViens",
                keyColumn: "Id",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "SinhViens",
                keyColumn: "Id",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "LopHocs",
                keyColumn: "Id",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "LopHocs",
                keyColumn: "Id",
                keyValue: 2);
        }
    }
}
