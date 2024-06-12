using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace AppApi.Migrations
{
    public partial class UpdateCategoryNameLength : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedDate",
                value: new DateTime(2024, 6, 13, 0, 33, 58, 493, DateTimeKind.Local).AddTicks(2894));

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreatedDate",
                value: new DateTime(2024, 6, 13, 0, 33, 58, 493, DateTimeKind.Local).AddTicks(2915));

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 3,
                column: "CreatedDate",
                value: new DateTime(2024, 6, 13, 0, 33, 58, 493, DateTimeKind.Local).AddTicks(2917));
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedDate",
                value: new DateTime(2024, 6, 13, 0, 27, 31, 127, DateTimeKind.Local).AddTicks(4266));

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreatedDate",
                value: new DateTime(2024, 6, 13, 0, 27, 31, 127, DateTimeKind.Local).AddTicks(4279));

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 3,
                column: "CreatedDate",
                value: new DateTime(2024, 6, 13, 0, 27, 31, 127, DateTimeKind.Local).AddTicks(4281));
        }
    }
}
