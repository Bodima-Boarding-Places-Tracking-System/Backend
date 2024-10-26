using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace user_mgt.Migrations
{
    /// <inheritdoc />
    public partial class updated : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "BoardingOwners",
                keyColumn: "UserId",
                keyValue: new Guid("193549ff-d60c-4902-ae35-901b1abb6d79"));

            migrationBuilder.DeleteData(
                table: "Students",
                keyColumn: "UserId",
                keyValue: new Guid("bfee54bc-4fb0-4997-97a9-878d777be2cc"));

            migrationBuilder.RenameColumn(
                name: "Role",
                table: "Students",
                newName: "Roles");

            migrationBuilder.RenameColumn(
                name: "Role",
                table: "BoardingOwners",
                newName: "Roles");

            migrationBuilder.InsertData(
                table: "BoardingOwners",
                columns: new[] { "UserId", "Email", "FirstName", "IsActive", "IsAdmin", "LastLogin", "LastName", "Password", "Phone", "RegistrationDate", "Roles" },
                values: new object[] { new Guid("84d6053f-0dd3-43ea-8335-968e50b8419e"), "lahirunanayakkara@gmail.com", "Lahiru", true, true, new DateTime(2024, 10, 22, 11, 34, 8, 802, DateTimeKind.Local).AddTicks(3382), "Nanayakkara", "12345678", "0760944045", new DateTime(2024, 10, 22, 11, 34, 8, 802, DateTimeKind.Local).AddTicks(3367), "[\"BoardingOwner\",\"Admin\"]" });

            migrationBuilder.InsertData(
                table: "Students",
                columns: new[] { "UserId", "FirstName", "IsActive", "IsAdmin", "LastLogin", "LastName", "Password", "RegistrationDate", "Roles", "Webmail" },
                values: new object[] { new Guid("0307287d-46e1-418a-a8ac-4ed18a4aed25"), "Lahiru", true, true, new DateTime(2024, 10, 22, 11, 34, 8, 802, DateTimeKind.Local).AddTicks(3530), "Nanayakkara", "+i7b14TZoXcFHDfIGw8b3g==;U5uWa6FpNeUamE6v5EVntc/nvlqGCDGe7tXLBlxz4t0=", new DateTime(2024, 10, 22, 11, 34, 8, 802, DateTimeKind.Local).AddTicks(3529), "[\"Student\",\"Admin\"]", "example.21@uom.lk" });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "BoardingOwners",
                keyColumn: "UserId",
                keyValue: new Guid("84d6053f-0dd3-43ea-8335-968e50b8419e"));

            migrationBuilder.DeleteData(
                table: "Students",
                keyColumn: "UserId",
                keyValue: new Guid("0307287d-46e1-418a-a8ac-4ed18a4aed25"));

            migrationBuilder.RenameColumn(
                name: "Roles",
                table: "Students",
                newName: "Role");

            migrationBuilder.RenameColumn(
                name: "Roles",
                table: "BoardingOwners",
                newName: "Role");

            migrationBuilder.InsertData(
                table: "BoardingOwners",
                columns: new[] { "UserId", "Email", "FirstName", "IsActive", "IsAdmin", "LastLogin", "LastName", "Password", "Phone", "RegistrationDate", "Role" },
                values: new object[] { new Guid("193549ff-d60c-4902-ae35-901b1abb6d79"), "lahirunanayakkara@gmail.com", "Lahiru", true, true, new DateTime(2024, 10, 7, 2, 43, 55, 919, DateTimeKind.Local).AddTicks(4494), "Nanayakkara", "12345678", "0760944045", new DateTime(2024, 10, 7, 2, 43, 55, 919, DateTimeKind.Local).AddTicks(4482), "BoardingOwner" });

            migrationBuilder.InsertData(
                table: "Students",
                columns: new[] { "UserId", "FirstName", "IsActive", "IsAdmin", "LastLogin", "LastName", "Password", "RegistrationDate", "Role", "Webmail" },
                values: new object[] { new Guid("bfee54bc-4fb0-4997-97a9-878d777be2cc"), "Lahiru", true, true, new DateTime(2024, 10, 7, 2, 43, 55, 919, DateTimeKind.Local).AddTicks(4698), "Nanayakkara", "+i7b14TZoXcFHDfIGw8b3g==;U5uWa6FpNeUamE6v5EVntc/nvlqGCDGe7tXLBlxz4t0=", new DateTime(2024, 10, 7, 2, 43, 55, 919, DateTimeKind.Local).AddTicks(4697), "Student", "example.21@uom.lk" });
        }
    }
}
