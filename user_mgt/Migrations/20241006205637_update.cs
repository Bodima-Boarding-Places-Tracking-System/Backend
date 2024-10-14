using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace user_mgt.Migrations
{
    /// <inheritdoc />
    public partial class update : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "BoardingOwners",
                keyColumn: "UserId",
                keyValue: new Guid("72ed95d3-9e40-4d4f-aea1-c36a6da187d6"));

            migrationBuilder.DeleteData(
                table: "Students",
                keyColumn: "UserId",
                keyValue: new Guid("14dcd0cb-15f4-4a17-837a-ae01a809fcf4"));

            migrationBuilder.InsertData(
                table: "BoardingOwners",
                columns: new[] { "UserId", "Email", "FirstName", "IsActive", "IsAdmin", "LastLogin", "LastName", "Password", "Phone", "RegistrationDate", "Role" },
                values: new object[] { new Guid("b28a587d-b67a-408d-bbee-3a89f26fc74b"), "lahirunanayakkara@gmail.com", "Lahiru", true, true, new DateTime(2024, 10, 7, 2, 26, 37, 227, DateTimeKind.Local).AddTicks(2941), "Nanayakkara", "12345678", "0760944045", new DateTime(2024, 10, 7, 2, 26, 37, 227, DateTimeKind.Local).AddTicks(2924), "BoardingOwner" });

            migrationBuilder.InsertData(
                table: "Students",
                columns: new[] { "UserId", "FirstName", "IsActive", "IsAdmin", "LastLogin", "LastName", "Password", "RegistrationDate", "Role", "Webmail" },
                values: new object[] { new Guid("0fc8f308-c421-4b1f-bd11-f1d0aabe41be"), "Lahiru", true, true, new DateTime(2024, 10, 7, 2, 26, 37, 227, DateTimeKind.Local).AddTicks(3118), "Nanayakkara", "Lahiru#1", new DateTime(2024, 10, 7, 2, 26, 37, 227, DateTimeKind.Local).AddTicks(3117), "Student", "example.21@uom.lk" });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "BoardingOwners",
                keyColumn: "UserId",
                keyValue: new Guid("b28a587d-b67a-408d-bbee-3a89f26fc74b"));

            migrationBuilder.DeleteData(
                table: "Students",
                keyColumn: "UserId",
                keyValue: new Guid("0fc8f308-c421-4b1f-bd11-f1d0aabe41be"));

            migrationBuilder.InsertData(
                table: "BoardingOwners",
                columns: new[] { "UserId", "Email", "FirstName", "IsActive", "IsAdmin", "LastLogin", "LastName", "Password", "Phone", "RegistrationDate", "Role" },
                values: new object[] { new Guid("72ed95d3-9e40-4d4f-aea1-c36a6da187d6"), "lahirunanayakkara@gmail.com", "Lahiru", true, true, new DateTime(2024, 10, 5, 21, 30, 31, 714, DateTimeKind.Local).AddTicks(3886), "Nanayakkara", "12345678", "0760944045", new DateTime(2024, 10, 5, 21, 30, 31, 714, DateTimeKind.Local).AddTicks(3870), "BoardingOwner" });

            migrationBuilder.InsertData(
                table: "Students",
                columns: new[] { "UserId", "FirstName", "IsActive", "IsAdmin", "LastLogin", "LastName", "Password", "RegistrationDate", "Role", "Webmail" },
                values: new object[] { new Guid("14dcd0cb-15f4-4a17-837a-ae01a809fcf4"), "Lahiru", true, true, new DateTime(2024, 10, 5, 21, 30, 31, 714, DateTimeKind.Local).AddTicks(4075), "Nanayakkara", "Lahiru#1", new DateTime(2024, 10, 5, 21, 30, 31, 714, DateTimeKind.Local).AddTicks(4074), "Student", "example.21@uom.lk" });
        }
    }
}
