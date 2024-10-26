using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace user_mgt.Migrations
{
    /// <inheritdoc />
    public partial class new2 : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "BoardingOwners",
                keyColumn: "UserId",
                keyValue: new Guid("84d6053f-0dd3-43ea-8335-968e50b8419e"));

            migrationBuilder.DeleteData(
                table: "Students",
                keyColumn: "UserId",
                keyValue: new Guid("0307287d-46e1-418a-a8ac-4ed18a4aed25"));

            migrationBuilder.InsertData(
                table: "BoardingOwners",
                columns: new[] { "UserId", "Email", "FirstName", "IsActive", "IsAdmin", "LastLogin", "LastName", "Password", "Phone", "RegistrationDate", "Roles" },
                values: new object[] { new Guid("c9bb1d02-c56e-44a8-98e8-2c706d098ee8"), "lahirunanayakkara@gmail.com", "Lahiru", true, true, new DateTime(2024, 10, 26, 18, 6, 42, 824, DateTimeKind.Local).AddTicks(3204), "Nanayakkara", "12345678", "0760944045", new DateTime(2024, 10, 26, 18, 6, 42, 824, DateTimeKind.Local).AddTicks(3194), "[\"boarding-owner\",\"admin\"]" });

            migrationBuilder.InsertData(
                table: "Students",
                columns: new[] { "UserId", "FirstName", "IsActive", "IsAdmin", "LastLogin", "LastName", "Password", "RegistrationDate", "Roles", "Webmail" },
                values: new object[] { new Guid("9740b23b-8d88-4454-9988-8eb90dcd35c0"), "Lahiru", true, true, new DateTime(2024, 10, 26, 18, 6, 42, 824, DateTimeKind.Local).AddTicks(3315), "Nanayakkara", "+i7b14TZoXcFHDfIGw8b3g==;U5uWa6FpNeUamE6v5EVntc/nvlqGCDGe7tXLBlxz4t0=", new DateTime(2024, 10, 26, 18, 6, 42, 824, DateTimeKind.Local).AddTicks(3314), "[\"student\",\"admin\"]", "example.21@uom.lk" });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "BoardingOwners",
                keyColumn: "UserId",
                keyValue: new Guid("c9bb1d02-c56e-44a8-98e8-2c706d098ee8"));

            migrationBuilder.DeleteData(
                table: "Students",
                keyColumn: "UserId",
                keyValue: new Guid("9740b23b-8d88-4454-9988-8eb90dcd35c0"));

            migrationBuilder.InsertData(
                table: "BoardingOwners",
                columns: new[] { "UserId", "Email", "FirstName", "IsActive", "IsAdmin", "LastLogin", "LastName", "Password", "Phone", "RegistrationDate", "Roles" },
                values: new object[] { new Guid("84d6053f-0dd3-43ea-8335-968e50b8419e"), "lahirunanayakkara@gmail.com", "Lahiru", true, true, new DateTime(2024, 10, 22, 11, 34, 8, 802, DateTimeKind.Local).AddTicks(3382), "Nanayakkara", "12345678", "0760944045", new DateTime(2024, 10, 22, 11, 34, 8, 802, DateTimeKind.Local).AddTicks(3367), "[\"BoardingOwner\",\"Admin\"]" });

            migrationBuilder.InsertData(
                table: "Students",
                columns: new[] { "UserId", "FirstName", "IsActive", "IsAdmin", "LastLogin", "LastName", "Password", "RegistrationDate", "Roles", "Webmail" },
                values: new object[] { new Guid("0307287d-46e1-418a-a8ac-4ed18a4aed25"), "Lahiru", true, true, new DateTime(2024, 10, 22, 11, 34, 8, 802, DateTimeKind.Local).AddTicks(3530), "Nanayakkara", "+i7b14TZoXcFHDfIGw8b3g==;U5uWa6FpNeUamE6v5EVntc/nvlqGCDGe7tXLBlxz4t0=", new DateTime(2024, 10, 22, 11, 34, 8, 802, DateTimeKind.Local).AddTicks(3529), "[\"Student\",\"Admin\"]", "example.21@uom.lk" });
        }
    }
}
