using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace AlGulumVerGulum.DAL.Migrations
{
    public partial class last : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.InsertData(
                table: "Categories",
                columns: new[] { "Id", "Created", "Description", "IsActive", "Name", "PicturePath", "Updated" },
                values: new object[] { 1, new DateTime(2021, 9, 20, 18, 57, 33, 999, DateTimeKind.Local).AddTicks(8637), "Tüm elektronik ürünler burada", false, "Elektronik", null, new DateTime(2021, 9, 20, 18, 57, 34, 1, DateTimeKind.Local).AddTicks(1830) });

            migrationBuilder.InsertData(
                table: "Categories",
                columns: new[] { "Id", "Created", "Description", "IsActive", "Name", "PicturePath", "Updated" },
                values: new object[] { 2, new DateTime(2021, 9, 20, 18, 57, 34, 1, DateTimeKind.Local).AddTicks(5408), "Tüm mobilya ürünleri burada", false, "Mobilya", null, new DateTime(2021, 9, 20, 18, 57, 34, 1, DateTimeKind.Local).AddTicks(5445) });

            migrationBuilder.InsertData(
                table: "Categories",
                columns: new[] { "Id", "Created", "Description", "IsActive", "Name", "PicturePath", "Updated" },
                values: new object[] { 3, new DateTime(2021, 9, 20, 18, 57, 34, 1, DateTimeKind.Local).AddTicks(5520), "Tüm giyim ürünleri", false, "Giyim", null, new DateTime(2021, 9, 20, 18, 57, 34, 1, DateTimeKind.Local).AddTicks(5524) });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 3);
        }
    }
}
