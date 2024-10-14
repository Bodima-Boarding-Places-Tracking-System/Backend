using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace user_mgt.Migrations
{
    /// <inheritdoc />
    public partial class update1 : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
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
                values: new object[] { new Guid("193549ff-d60c-4902-ae35-901b1abb6d79"), "lahirunanayakkara@gmail.com", "Lahiru", true, true, new DateTime(2024, 10, 7, 2, 43, 55, 919, DateTimeKind.Local).AddTicks(4494), "Nanayakkara", "12345678", "0760944045", new DateTime(2024, 10, 7, 2, 43, 55, 919, DateTimeKind.Local).AddTicks(4482), "BoardingOwner" });

            migrationBuilder.InsertData(
                table: "Students",
                columns: new[] { "UserId", "FirstName", "IsActive", "IsAdmin", "LastLogin", "LastName", "Password", "RegistrationDate", "Role", "Webmail" },
                values: new object[] { new Guid("bfee54bc-4fb0-4997-97a9-878d777be2cc"), "Lahiru", true, true, new DateTime(2024, 10, 7, 2, 43, 55, 919, DateTimeKind.Local).AddTicks(4698), "Nanayakkara", "+i7b14TZoXcFHDfIGw8b3g==;U5uWa6FpNeUamE6v5EVntc/nvlqGCDGe7tXLBlxz4t0=", new DateTime(2024, 10, 7, 2, 43, 55, 919, DateTimeKind.Local).AddTicks(4697), "Student", "example.21@uom.lk" });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "BoardingOwners",
                keyColumn: "UserId",
                keyValue: new Guid("193549ff-d60c-4902-ae35-901b1abb6d79"));

            migrationBuilder.DeleteData(
                table: "Students",
                keyColumn: "UserId",
                keyValue: new Guid("bfee54bc-4fb0-4997-97a9-878d777be2cc"));

            migrationBuilder.InsertData(
                table: "BoardingOwners",
                columns: new[] { "UserId", "Email", "FirstName", "IsActive", "IsAdmin", "LastLogin", "LastName", "Password", "Phone", "RegistrationDate", "Role" },
                values: new object[] { new Guid("b28a587d-b67a-408d-bbee-3a89f26fc74b"), "lahirunanayakkara@gmail.com", "Lahiru", true, true, new DateTime(2024, 10, 7, 2, 26, 37, 227, DateTimeKind.Local).AddTicks(2941), "Nanayakkara", "12345678", "0760944045", new DateTime(2024, 10, 7, 2, 26, 37, 227, DateTimeKind.Local).AddTicks(2924), "BoardingOwner" });

            migrationBuilder.InsertData(
                table: "Students",
                columns: new[] { "UserId", "FirstName", "IsActive", "IsAdmin", "LastLogin", "LastName", "Password", "RegistrationDate", "Role", "Webmail" },
                values: new object[] { new Guid("0fc8f308-c421-4b1f-bd11-f1d0aabe41be"), "Lahiru", true, true, new DateTime(2024, 10, 7, 2, 26, 37, 227, DateTimeKind.Local).AddTicks(3118), "Nanayakkara", "Lahiru#1", new DateTime(2024, 10, 7, 2, 26, 37, 227, DateTimeKind.Local).AddTicks(3117), "Student", "example.21@uom.lk" });
        }
    }
}
