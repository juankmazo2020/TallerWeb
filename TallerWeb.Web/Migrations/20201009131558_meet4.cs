using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace TallerWeb.Web.Migrations
{
    public partial class meet4 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropIndex(
                name: "IX_Meetings_DateTime",
                table: "Meetings");

            migrationBuilder.DropIndex(
                name: "IX_Meetings_Name",
                table: "Meetings");

            migrationBuilder.DropColumn(
                name: "DateTime",
                table: "Meetings");

            migrationBuilder.AddColumn<DateTime>(
                name: "Date",
                table: "Meetings",
                nullable: false,
                defaultValue: new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified));

            migrationBuilder.CreateIndex(
                name: "IX_Meetings_Name_ChurchId",
                table: "Meetings",
                columns: new[] { "Name", "ChurchId" },
                unique: true,
                filter: "[ChurchId] IS NOT NULL");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropIndex(
                name: "IX_Meetings_Name_ChurchId",
                table: "Meetings");

            migrationBuilder.DropColumn(
                name: "Date",
                table: "Meetings");

            migrationBuilder.AddColumn<string>(
                name: "DateTime",
                table: "Meetings",
                nullable: true);

            migrationBuilder.CreateIndex(
                name: "IX_Meetings_DateTime",
                table: "Meetings",
                column: "DateTime");

            migrationBuilder.CreateIndex(
                name: "IX_Meetings_Name",
                table: "Meetings",
                column: "Name",
                unique: true);
        }
    }
}
