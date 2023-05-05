using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Learn1.Persistence.Migrations
{
    public partial class addChenge2 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
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

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "Roles",
                keyColumn: "Id",
                keyValue: 1L,
                column: "InsertTime",
                value: new DateTime(2023, 5, 3, 1, 21, 5, 443, DateTimeKind.Local).AddTicks(698));

            migrationBuilder.UpdateData(
                table: "Roles",
                keyColumn: "Id",
                keyValue: 2L,
                column: "InsertTime",
                value: new DateTime(2023, 5, 3, 1, 21, 5, 443, DateTimeKind.Local).AddTicks(751));

            migrationBuilder.UpdateData(
                table: "Roles",
                keyColumn: "Id",
                keyValue: 3L,
                column: "InsertTime",
                value: new DateTime(2023, 5, 3, 1, 21, 5, 443, DateTimeKind.Local).AddTicks(761));
        }
    }
}
