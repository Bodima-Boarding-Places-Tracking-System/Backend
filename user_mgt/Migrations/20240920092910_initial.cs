using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace user_mgt.Migrations
{
    /// <inheritdoc />
    public partial class initial : Migration
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
                    FullName = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Role = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Password = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    RegistrationDate = table.Column<DateTime>(type: "datetime2", nullable: false),
                    LastLogin = table.Column<DateTime>(type: "datetime2", nullable: false),
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
                    FullName = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Role = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Password = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    RegistrationDate = table.Column<DateTime>(type: "datetime2", nullable: false),
                    LastLogin = table.Column<DateTime>(type: "datetime2", nullable: false),
                    IsActive = table.Column<bool>(type: "bit", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Students", x => x.UserId);
                });

            migrationBuilder.InsertData(
                table: "BoardingOwners",
                columns: new[] { "UserId", "Email", "FullName", "IsActive", "LastLogin", "Password", "Phone", "RegistrationDate", "Role" },
                values: new object[] { new Guid("88aebc5b-1cf1-4323-bc47-148c83fc4766"), "lahirunanayakkara@gmail.com", "Lahiru Nanayakkara", true, new DateTime(2024, 9, 20, 14, 59, 9, 548, DateTimeKind.Local).AddTicks(8815), "12345678", "0760944045", new DateTime(2024, 9, 20, 14, 59, 9, 548, DateTimeKind.Local).AddTicks(8804), "BoardingOwner" });

            migrationBuilder.InsertData(
                table: "Students",
                columns: new[] { "UserId", "FullName", "IsActive", "LastLogin", "Password", "RegistrationDate", "Role", "Webmail" },
                values: new object[] { new Guid("c8a6e6ef-3fdd-4d7b-a150-916d33f48113"), "Nanayakkara omll", true, new DateTime(2024, 9, 20, 14, 59, 9, 548, DateTimeKind.Local).AddTicks(8994), "Lahiru#1", new DateTime(2024, 9, 20, 14, 59, 9, 548, DateTimeKind.Local).AddTicks(8993), "Student", "nanayakkaraomll.21@uom.lk" });
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
