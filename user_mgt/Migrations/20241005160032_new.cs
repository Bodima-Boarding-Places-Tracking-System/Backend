using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace user_mgt.Migrations
{
    /// <inheritdoc />
    public partial class @new : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "BoardingOwners",
                columns: table => new
                {
                    UserId = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    Email = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Phone = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    FirstName = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    LastName = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Role = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Password = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    RegistrationDate = table.Column<DateTime>(type: "datetime2", nullable: false),
                    LastLogin = table.Column<DateTime>(type: "datetime2", nullable: false),
                    IsAdmin = table.Column<bool>(type: "bit", nullable: false),
                    IsActive = table.Column<bool>(type: "bit", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_BoardingOwners", x => x.UserId);
                });

            migrationBuilder.CreateTable(
                name: "Students",
                columns: table => new
                {
                    UserId = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    Webmail = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    FirstName = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    LastName = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Role = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Password = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    RegistrationDate = table.Column<DateTime>(type: "datetime2", nullable: false),
                    LastLogin = table.Column<DateTime>(type: "datetime2", nullable: false),
                    IsAdmin = table.Column<bool>(type: "bit", nullable: false),
                    IsActive = table.Column<bool>(type: "bit", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Students", x => x.UserId);
                });

            migrationBuilder.InsertData(
                table: "BoardingOwners",
                columns: new[] { "UserId", "Email", "FirstName", "IsActive", "IsAdmin", "LastLogin", "LastName", "Password", "Phone", "RegistrationDate", "Role" },
                values: new object[] { new Guid("72ed95d3-9e40-4d4f-aea1-c36a6da187d6"), "lahirunanayakkara@gmail.com", "Lahiru", true, true, new DateTime(2024, 10, 5, 21, 30, 31, 714, DateTimeKind.Local).AddTicks(3886), "Nanayakkara", "12345678", "0760944045", new DateTime(2024, 10, 5, 21, 30, 31, 714, DateTimeKind.Local).AddTicks(3870), "BoardingOwner" });

            migrationBuilder.InsertData(
                table: "Students",
                columns: new[] { "UserId", "FirstName", "IsActive", "IsAdmin", "LastLogin", "LastName", "Password", "RegistrationDate", "Role", "Webmail" },
                values: new object[] { new Guid("14dcd0cb-15f4-4a17-837a-ae01a809fcf4"), "Lahiru", true, true, new DateTime(2024, 10, 5, 21, 30, 31, 714, DateTimeKind.Local).AddTicks(4075), "Nanayakkara", "Lahiru#1", new DateTime(2024, 10, 5, 21, 30, 31, 714, DateTimeKind.Local).AddTicks(4074), "Student", "example.21@uom.lk" });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "BoardingOwners");

            migrationBuilder.DropTable(
                name: "Students");
        }
    }
}
