using Microsoft.EntityFrameworkCore.Migrations;

namespace TallerWeb.Web.Migrations
{
    public partial class WhithUser : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Meetings_Churches_ChurchId",
                table: "Meetings");

            migrationBuilder.AddForeignKey(
                name: "FK_Meetings_Churches_ChurchId",
                table: "Meetings",
                column: "ChurchId",
                principalTable: "Churches",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Meetings_Churches_ChurchId",
                table: "Meetings");

            migrationBuilder.AddForeignKey(
                name: "FK_Meetings_Churches_ChurchId",
                table: "Meetings",
                column: "ChurchId",
                principalTable: "Churches",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }
    }
}
