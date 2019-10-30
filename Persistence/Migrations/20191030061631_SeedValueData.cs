using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace Persistence.Migrations
{
    public partial class SeedValueData : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.InsertData(
                table: "users",
                columns: new[] { "userId", "creationDate", "username" },
                values: new object[] { -1, new DateTime(2019, 10, 30, 1, 16, 31, 336, DateTimeKind.Local).AddTicks(4534), "Name -1" });

            migrationBuilder.InsertData(
                table: "users",
                columns: new[] { "userId", "creationDate", "username" },
                values: new object[] { -2, new DateTime(2019, 10, 30, 1, 16, 31, 341, DateTimeKind.Local).AddTicks(1000), "Name -2" });

            migrationBuilder.InsertData(
                table: "users",
                columns: new[] { "userId", "creationDate", "username" },
                values: new object[] { -3, new DateTime(2019, 10, 30, 1, 16, 31, 341, DateTimeKind.Local).AddTicks(1024), "Name -3" });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "users",
                keyColumn: "userId",
                keyValue: -3);

            migrationBuilder.DeleteData(
                table: "users",
                keyColumn: "userId",
                keyValue: -2);

            migrationBuilder.DeleteData(
                table: "users",
                keyColumn: "userId",
                keyValue: -1);
        }
    }
}
