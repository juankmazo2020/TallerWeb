using Microsoft.EntityFrameworkCore.Migrations;

namespace TallerWeb.Web.Migrations
{
    public partial class meet2 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Meetings_Churches_ChurchId",
                table: "Meetings");

            migrationBuilder.DropForeignKey(
                name: "FK_Meetings_Districts_ChurchId1",
                table: "Meetings");

            migrationBuilder.DropIndex(
                name: "IX_Meetings_ChurchId1",
                table: "Meetings");

            migrationBuilder.DropColumn(
                name: "ChurchId1",
                table: "Meetings");

            migrationBuilder.AddForeignKey(
                name: "FK_Meetings_Churches_ChurchId",
                table: "Meetings",
                column: "ChurchId",
                principalTable: "Churches",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Meetings_Churches_ChurchId",
                table: "Meetings");

            migrationBuilder.AddColumn<int>(
                name: "ChurchId1",
                table: "Meetings",
                nullable: true);

            migrationBuilder.CreateIndex(
                name: "IX_Meetings_ChurchId1",
                table: "Meetings",
                column: "ChurchId1");

            migrationBuilder.AddForeignKey(
                name: "FK_Meetings_Churches_ChurchId",
                table: "Meetings",
                column: "ChurchId",
                principalTable: "Churches",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_Meetings_Districts_ChurchId1",
                table: "Meetings",
                column: "ChurchId1",
                principalTable: "Districts",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);
        }
    }
}
