using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace user_mgt.Migrations
{
    /// <inheritdoc />
    public partial class latest : Migration
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
                values: new object[] { new Guid("c309f0c1-d63f-4a23-b99f-2af8adc01520"), "lahirunanayakkara@gmail.com", "Lahiru Nanayakkara", true, new DateTime(2024, 9, 18, 5, 7, 18, 462, DateTimeKind.Local).AddTicks(8024), "12345678", "0760944045", new DateTime(2024, 9, 18, 5, 7, 18, 462, DateTimeKind.Local).AddTicks(8012), "BoardingOwner" });

            migrationBuilder.InsertData(
                table: "Students",
                columns: new[] { "UserId", "FullName", "IsActive", "LastLogin", "Password", "RegistrationDate", "Role", "Webmail" },
                values: new object[] { new Guid("82e29a8a-12b3-4aea-94ba-8f191b9235ea"), "Nanayakkara omll", true, new DateTime(2024, 9, 18, 5, 7, 18, 462, DateTimeKind.Local).AddTicks(8136), "Lahiru#1", new DateTime(2024, 9, 18, 5, 7, 18, 462, DateTimeKind.Local).AddTicks(8136), "Student", "nanayakkaraomll.21@uom.lk" });
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
