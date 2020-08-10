using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace BugTracker.Migrations
{
    public partial class ADDTABLE_REPORTNOTE : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "ReportNotes",
                columns: table => new
                {
                    NoteId = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    ReportId = table.Column<int>(nullable: false),
                    PostTime = table.Column<DateTime>(nullable: false),
                    Description = table.Column<string>(nullable: true),
                    PostedBy = table.Column<string>(nullable: true),
                    PhotoPath = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_ReportNotes", x => x.NoteId);
                    table.ForeignKey(
                        name: "FK_ReportNotes_BugReports_ReportId",
                        column: x => x.ReportId,
                        principalTable: "BugReports",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateIndex(
                name: "IX_ReportNotes_ReportId",
                table: "ReportNotes",
                column: "ReportId");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "ReportNotes");
        }
    }
}
