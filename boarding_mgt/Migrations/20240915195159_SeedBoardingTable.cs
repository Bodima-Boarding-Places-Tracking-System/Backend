using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace boarding_mgt.Migrations
{
    /// <inheritdoc />
    public partial class SeedBoardingTable : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.InsertData(
                table: "Boarding",
                columns: new[] { "Id", "Description", "Name", "Type" },
                values: new object[] { 1, "for girls", "Devi", "flat" });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Boarding",
                keyColumn: "Id",
                keyValue: 1);
        }
    }
}
