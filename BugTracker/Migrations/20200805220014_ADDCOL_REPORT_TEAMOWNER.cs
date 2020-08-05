using Microsoft.EntityFrameworkCore.Migrations;

namespace BugTracker.Migrations
{
    public partial class ADDCOL_REPORT_TEAMOWNER : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<string>(
                name: "TeamOwner",
                table: "BugReports",
                nullable: true);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "TeamOwner",
                table: "BugReports");
        }
    }
}
