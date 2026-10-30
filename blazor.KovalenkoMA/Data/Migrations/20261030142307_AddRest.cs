using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace blazor.KovalenkoMA.Migrations
{
    /// <inheritdoc />
    public partial class AddRest : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AlterColumn<string>(
                name: "Title",
                table: "TaskItems",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "",
                oldClrType: typeof(string),
                oldType: "nvarchar(max)",
                oldNullable: true);

            migrationBuilder.AlterColumn<DateTime>(
                name: "FinishDate",
                table: "TaskItems",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldNullable: true);

            migrationBuilder.AlterColumn<string>(
                name: "Description",
                table: "TaskItems",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "",
                oldClrType: typeof(string),
                oldType: "nvarchar(max)",
                oldNullable: true);

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedDate",
                table: "TaskItems",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldNullable: true);

            migrationBuilder.UpdateData(
                table: "TaskItems",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CreatedDate", "FinishDate" },
                values: new object[] { new DateTime(2026, 10, 30, 19, 23, 6, 813, DateTimeKind.Local).AddTicks(1007), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "TaskItems",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "CreatedDate", "FinishDate" },
                values: new object[] { new DateTime(2026, 10, 30, 19, 23, 6, 813, DateTimeKind.Local).AddTicks(1020), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "TaskItems",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "CreatedDate", "FinishDate" },
                values: new object[] { new DateTime(2026, 10, 30, 19, 23, 6, 813, DateTimeKind.Local).AddTicks(1021), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "TaskItems",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "CreatedDate", "FinishDate" },
                values: new object[] { new DateTime(2026, 10, 30, 19, 23, 6, 813, DateTimeKind.Local).AddTicks(1023), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AlterColumn<string>(
                name: "Title",
                table: "TaskItems",
                type: "nvarchar(max)",
                nullable: true,
                oldClrType: typeof(string),
                oldType: "nvarchar(max)");

            migrationBuilder.AlterColumn<DateTime>(
                name: "FinishDate",
                table: "TaskItems",
                type: "datetime2",
                nullable: true,
                oldClrType: typeof(DateTime),
                oldType: "datetime2");

            migrationBuilder.AlterColumn<string>(
                name: "Description",
                table: "TaskItems",
                type: "nvarchar(max)",
                nullable: true,
                oldClrType: typeof(string),
                oldType: "nvarchar(max)");

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedDate",
                table: "TaskItems",
                type: "datetime2",
                nullable: true,
                oldClrType: typeof(DateTime),
                oldType: "datetime2");

            migrationBuilder.UpdateData(
                table: "TaskItems",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CreatedDate", "FinishDate" },
                values: new object[] { new DateTime(2026, 10, 27, 21, 46, 45, 607, DateTimeKind.Local).AddTicks(7733), null });

            migrationBuilder.UpdateData(
                table: "TaskItems",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "CreatedDate", "FinishDate" },
                values: new object[] { new DateTime(2026, 10, 27, 21, 46, 45, 607, DateTimeKind.Local).AddTicks(7752), null });

            migrationBuilder.UpdateData(
                table: "TaskItems",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "CreatedDate", "FinishDate" },
                values: new object[] { new DateTime(2026, 10, 27, 21, 46, 45, 607, DateTimeKind.Local).AddTicks(7753), null });

            migrationBuilder.UpdateData(
                table: "TaskItems",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "CreatedDate", "FinishDate" },
                values: new object[] { new DateTime(2026, 10, 27, 21, 46, 45, 607, DateTimeKind.Local).AddTicks(7754), null });
        }
    }
}
