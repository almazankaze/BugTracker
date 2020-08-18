using Microsoft.EntityFrameworkCore.Migrations;

namespace BugTracker.Migrations
{
    public partial class ADDCOL_PROJECTID : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<int>(
                name: "ProjectId",
                table: "BugReports",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.CreateIndex(
                name: "IX_BugReports_ProjectId",
                table: "BugReports",
                column: "ProjectId");

            migrationBuilder.AddForeignKey(
                name: "FK_BugReports_Projects_ProjectId",
                table: "BugReports",
                column: "ProjectId",
                principalTable: "Projects",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_BugReports_Projects_ProjectId",
                table: "BugReports");

            migrationBuilder.DropIndex(
                name: "IX_BugReports_ProjectId",
                table: "BugReports");

            migrationBuilder.DropColumn(
                name: "ProjectId",
                table: "BugReports");
        }
    }
}
