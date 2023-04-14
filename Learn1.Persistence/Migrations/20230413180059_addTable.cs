using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Learn1.Persistence.Migrations
{
    public partial class addTable : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "Roles",
                keyColumn: "Id",
                keyValue: 1L,
                column: "InsertTime",
                value: new DateTime(2023, 4, 13, 22, 30, 58, 859, DateTimeKind.Local).AddTicks(7621));

            migrationBuilder.UpdateData(
                table: "Roles",
                keyColumn: "Id",
                keyValue: 2L,
                column: "InsertTime",
                value: new DateTime(2023, 4, 13, 22, 30, 58, 859, DateTimeKind.Local).AddTicks(7688));

            migrationBuilder.UpdateData(
                table: "Roles",
                keyColumn: "Id",
                keyValue: 3L,
                column: "InsertTime",
                value: new DateTime(2023, 4, 13, 22, 30, 58, 859, DateTimeKind.Local).AddTicks(7697));
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "Roles",
                keyColumn: "Id",
                keyValue: 1L,
                column: "InsertTime",
                value: new DateTime(2023, 4, 12, 17, 0, 33, 390, DateTimeKind.Local).AddTicks(4398));

            migrationBuilder.UpdateData(
                table: "Roles",
                keyColumn: "Id",
                keyValue: 2L,
                column: "InsertTime",
                value: new DateTime(2023, 4, 12, 17, 0, 33, 390, DateTimeKind.Local).AddTicks(4450));

            migrationBuilder.UpdateData(
                table: "Roles",
                keyColumn: "Id",
                keyValue: 3L,
                column: "InsertTime",
                value: new DateTime(2023, 4, 12, 17, 0, 33, 390, DateTimeKind.Local).AddTicks(4463));
        }
    }
}
