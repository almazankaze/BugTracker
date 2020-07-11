using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace BugTracker.Migrations
{
    public partial class ADDNEWCOLUMNS : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<DateTime>(
                name: "LastUpdate",
                table: "BugReports",
                nullable: false,
                defaultValue: new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified));

            migrationBuilder.AddColumn<string>(
                name: "Reporter",
                table: "BugReports",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "Resolution",
                table: "BugReports",
                nullable: true);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "LastUpdate",
                table: "BugReports");

            migrationBuilder.DropColumn(
                name: "Reporter",
                table: "BugReports");

            migrationBuilder.DropColumn(
                name: "Resolution",
                table: "BugReports");
        }
    }
}
