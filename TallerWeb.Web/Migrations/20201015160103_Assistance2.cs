using Microsoft.EntityFrameworkCore.Migrations;

namespace TallerWeb.Web.Migrations
{
    public partial class Assistance2 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Assistances_Meetings_MeetingId",
                table: "Assistances");

            migrationBuilder.AddForeignKey(
                name: "FK_Assistances_Meetings_MeetingId",
                table: "Assistances",
                column: "MeetingId",
                principalTable: "Meetings",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Assistances_Meetings_MeetingId",
                table: "Assistances");

            migrationBuilder.AddForeignKey(
                name: "FK_Assistances_Meetings_MeetingId",
                table: "Assistances",
                column: "MeetingId",
                principalTable: "Meetings",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);
        }
    }
}
