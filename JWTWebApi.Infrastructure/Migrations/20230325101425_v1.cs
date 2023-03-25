using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace JWTWebApi.Infrastructure.Migrations
{
    /// <inheritdoc />
    public partial class v1 : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Categories",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Name = table.Column<string>(type: "varchar(100)", maxLength: 100, nullable: false),
                    Description = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    CreatedDate = table.Column<DateTime>(type: "datetime2", nullable: false),
                    CreatedBy = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    ModifiedDate = table.Column<DateTime>(type: "datetime2", nullable: false),
                    ModifiedBy = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Status = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Categories", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Users",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    UserName = table.Column<string>(type: "varchar(100)", maxLength: 100, nullable: false),
                    Password = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    CreatedDate = table.Column<DateTime>(type: "datetime2", nullable: false),
                    CreatedBy = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    ModifiedDate = table.Column<DateTime>(type: "datetime2", nullable: false),
                    ModifiedBy = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Status = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Users", x => x.Id);
                });

            migrationBuilder.InsertData(
                table: "Categories",
                columns: new[] { "Id", "CreatedBy", "CreatedDate", "Description", "ModifiedBy", "ModifiedDate", "Name", "Status" },
                values: new object[,]
                {
                    { 1, "sysAdmin", new DateTime(2023, 3, 25, 13, 14, 25, 496, DateTimeKind.Local).AddTicks(6823), "sebze", null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "Gıda", 1 },
                    { 2, "sysAdmin", new DateTime(2023, 3, 25, 13, 14, 25, 496, DateTimeKind.Local).AddTicks(6839), "pc,tablet", null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "Teknoloji", 1 },
                    { 3, "sysAdmin", new DateTime(2023, 3, 25, 13, 14, 25, 496, DateTimeKind.Local).AddTicks(6841), "takı toka", null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "Aksesuar", 1 }
                });

            migrationBuilder.InsertData(
                table: "Users",
                columns: new[] { "Id", "CreatedBy", "CreatedDate", "ModifiedBy", "ModifiedDate", "Password", "Status", "UserName" },
                values: new object[,]
                {
                    { 1, "sysAdmin", new DateTime(2023, 3, 25, 13, 14, 25, 496, DateTimeKind.Local).AddTicks(7204), null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "123", 1, "rido" },
                    { 2, "sysAdmin", new DateTime(2023, 3, 25, 13, 14, 25, 496, DateTimeKind.Local).AddTicks(7206), null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "123", 1, "onder" },
                    { 3, "sysAdmin", new DateTime(2023, 3, 25, 13, 14, 25, 496, DateTimeKind.Local).AddTicks(7207), null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "123", 1, "pelin" }
                });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Categories");

            migrationBuilder.DropTable(
                name: "Users");
        }
    }
}
