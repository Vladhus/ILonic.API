using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace ILonic.API.Data.Migrations
{
    public partial class InitialCreate : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "TempDatas",
                columns: table => new
                {
                    ID = table.Column<int>(type: "INTEGER", nullable: false)
                        .Annotation("Sqlite:Autoincrement", true),
                    Number = table.Column<string>(type: "TEXT", nullable: true),
                    Date = table.Column<DateTime>(type: "TEXT", nullable: false),
                    Amount = table.Column<int>(type: "INTEGER", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_TempDatas", x => x.ID);
                });

            migrationBuilder.CreateTable(
                name: "Users",
                columns: table => new
                {
                    Id = table.Column<int>(type: "INTEGER", nullable: false)
                        .Annotation("Sqlite:Autoincrement", true),
                    UserName = table.Column<string>(type: "TEXT", nullable: true),
                    Password = table.Column<string>(type: "TEXT", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Users", x => x.Id);
                });

            migrationBuilder.InsertData(
                table: "TempDatas",
                columns: new[] { "ID", "Amount", "Date", "Number" },
                values: new object[] { 1, 5, new DateTime(2021, 8, 7, 13, 5, 16, 769, DateTimeKind.Local).AddTicks(4361), "48 794 559 395" });

            migrationBuilder.InsertData(
                table: "TempDatas",
                columns: new[] { "ID", "Amount", "Date", "Number" },
                values: new object[] { 2, 9, new DateTime(2021, 8, 7, 13, 5, 16, 771, DateTimeKind.Local).AddTicks(5877), "48 794 559 395" });

            migrationBuilder.InsertData(
                table: "TempDatas",
                columns: new[] { "ID", "Amount", "Date", "Number" },
                values: new object[] { 3, 10, new DateTime(2021, 8, 7, 13, 5, 16, 771, DateTimeKind.Local).AddTicks(5935), "48 794 559 395" });

            migrationBuilder.InsertData(
                table: "TempDatas",
                columns: new[] { "ID", "Amount", "Date", "Number" },
                values: new object[] { 4, 11, new DateTime(2021, 8, 7, 13, 5, 16, 771, DateTimeKind.Local).AddTicks(5941), "48 794 559 395" });

            migrationBuilder.InsertData(
                table: "TempDatas",
                columns: new[] { "ID", "Amount", "Date", "Number" },
                values: new object[] { 5, 29, new DateTime(2021, 8, 7, 13, 5, 16, 771, DateTimeKind.Local).AddTicks(5944), "48 794 559 395" });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "TempDatas");

            migrationBuilder.DropTable(
                name: "Users");
        }
    }
}
