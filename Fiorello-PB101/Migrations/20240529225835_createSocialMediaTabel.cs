using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Fiorello_PB101.Migrations
{
    public partial class createSocialMediaTabel : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Experts",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Name = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Position = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Image = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    SoftDeleted = table.Column<bool>(type: "bit", nullable: false),
                    CreatedDate = table.Column<DateTime>(type: "datetime2", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Experts", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "SocialMedias",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Name = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Url = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    SoftDeleted = table.Column<bool>(type: "bit", nullable: false),
                    CreatedDate = table.Column<DateTime>(type: "datetime2", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_SocialMedias", x => x.Id);
                });

            migrationBuilder.UpdateData(
                table: "Blogs",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedDate",
                value: new DateTime(2024, 5, 30, 2, 58, 34, 878, DateTimeKind.Local).AddTicks(5988));

            migrationBuilder.UpdateData(
                table: "Blogs",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreatedDate",
                value: new DateTime(2024, 5, 30, 2, 58, 34, 878, DateTimeKind.Local).AddTicks(5990));

            migrationBuilder.UpdateData(
                table: "Blogs",
                keyColumn: "Id",
                keyValue: 3,
                column: "CreatedDate",
                value: new DateTime(2024, 5, 30, 2, 58, 34, 878, DateTimeKind.Local).AddTicks(5991));

            migrationBuilder.UpdateData(
                table: "Settings",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedDate",
                value: new DateTime(2024, 5, 30, 2, 58, 34, 878, DateTimeKind.Local).AddTicks(5973));

            migrationBuilder.UpdateData(
                table: "Settings",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreatedDate",
                value: new DateTime(2024, 5, 30, 2, 58, 34, 878, DateTimeKind.Local).AddTicks(5974));

            migrationBuilder.UpdateData(
                table: "Settings",
                keyColumn: "Id",
                keyValue: 3,
                column: "CreatedDate",
                value: new DateTime(2024, 5, 30, 2, 58, 34, 878, DateTimeKind.Local).AddTicks(5975));

            migrationBuilder.InsertData(
                table: "SocialMedias",
                columns: new[] { "Id", "CreatedDate", "Name", "SoftDeleted", "Url" },
                values: new object[,]
                {
                    { 1, new DateTime(2024, 5, 30, 2, 58, 34, 878, DateTimeKind.Local).AddTicks(5877), "Instagram", false, "www.instagram.com" },
                    { 2, new DateTime(2024, 5, 30, 2, 58, 34, 878, DateTimeKind.Local).AddTicks(5878), "Twitter", false, "www.twitter.com" },
                    { 3, new DateTime(2024, 5, 30, 2, 58, 34, 878, DateTimeKind.Local).AddTicks(5880), "Facebook", false, "www.facebook.com" }
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Experts");

            migrationBuilder.DropTable(
                name: "SocialMedias");

            migrationBuilder.UpdateData(
                table: "Blogs",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedDate",
                value: new DateTime(2024, 5, 21, 10, 33, 59, 445, DateTimeKind.Local).AddTicks(8346));

            migrationBuilder.UpdateData(
                table: "Blogs",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreatedDate",
                value: new DateTime(2024, 5, 21, 10, 33, 59, 445, DateTimeKind.Local).AddTicks(8348));

            migrationBuilder.UpdateData(
                table: "Blogs",
                keyColumn: "Id",
                keyValue: 3,
                column: "CreatedDate",
                value: new DateTime(2024, 5, 21, 10, 33, 59, 445, DateTimeKind.Local).AddTicks(8349));

            migrationBuilder.UpdateData(
                table: "Settings",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedDate",
                value: new DateTime(2024, 5, 21, 10, 33, 59, 445, DateTimeKind.Local).AddTicks(8229));

            migrationBuilder.UpdateData(
                table: "Settings",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreatedDate",
                value: new DateTime(2024, 5, 21, 10, 33, 59, 445, DateTimeKind.Local).AddTicks(8231));

            migrationBuilder.UpdateData(
                table: "Settings",
                keyColumn: "Id",
                keyValue: 3,
                column: "CreatedDate",
                value: new DateTime(2024, 5, 21, 10, 33, 59, 445, DateTimeKind.Local).AddTicks(8233));
        }
    }
}
