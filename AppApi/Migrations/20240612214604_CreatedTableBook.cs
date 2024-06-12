using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace AppApi.Migrations
{
    public partial class CreatedTableBook : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedDate",
                value: new DateTime(2024, 6, 13, 1, 46, 4, 93, DateTimeKind.Local).AddTicks(7792));

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreatedDate",
                value: new DateTime(2024, 6, 13, 1, 46, 4, 93, DateTimeKind.Local).AddTicks(7812));

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 3,
                column: "CreatedDate",
                value: new DateTime(2024, 6, 13, 1, 46, 4, 93, DateTimeKind.Local).AddTicks(7815));
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedDate",
                value: new DateTime(2024, 6, 13, 1, 43, 19, 345, DateTimeKind.Local).AddTicks(9945));

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreatedDate",
                value: new DateTime(2024, 6, 13, 1, 43, 19, 345, DateTimeKind.Local).AddTicks(9964));

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 3,
                column: "CreatedDate",
                value: new DateTime(2024, 6, 13, 1, 43, 19, 345, DateTimeKind.Local).AddTicks(9967));
        }
    }
}
