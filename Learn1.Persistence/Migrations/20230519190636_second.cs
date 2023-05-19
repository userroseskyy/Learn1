using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Learn1.Persistence.Migrations
{
    public partial class second : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "Roles",
                keyColumn: "Id",
                keyValue: 1L,
                column: "InsertTime",
                value: new DateTime(2023, 5, 19, 22, 36, 36, 50, DateTimeKind.Local).AddTicks(7165));

            migrationBuilder.UpdateData(
                table: "Roles",
                keyColumn: "Id",
                keyValue: 2L,
                column: "InsertTime",
                value: new DateTime(2023, 5, 19, 22, 36, 36, 50, DateTimeKind.Local).AddTicks(7193));

            migrationBuilder.UpdateData(
                table: "Roles",
                keyColumn: "Id",
                keyValue: 3L,
                column: "InsertTime",
                value: new DateTime(2023, 5, 19, 22, 36, 36, 50, DateTimeKind.Local).AddTicks(7199));
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "Roles",
                keyColumn: "Id",
                keyValue: 1L,
                column: "InsertTime",
                value: new DateTime(2023, 5, 5, 17, 40, 28, 132, DateTimeKind.Local).AddTicks(894));

            migrationBuilder.UpdateData(
                table: "Roles",
                keyColumn: "Id",
                keyValue: 2L,
                column: "InsertTime",
                value: new DateTime(2023, 5, 5, 17, 40, 28, 132, DateTimeKind.Local).AddTicks(1102));

            migrationBuilder.UpdateData(
                table: "Roles",
                keyColumn: "Id",
                keyValue: 3L,
                column: "InsertTime",
                value: new DateTime(2023, 5, 5, 17, 40, 28, 132, DateTimeKind.Local).AddTicks(1111));
        }
    }
}
