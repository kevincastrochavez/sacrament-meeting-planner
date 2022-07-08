using System;
using Microsoft.EntityFrameworkCore.Migrations;
using sacramentMeetingPlanner.Data;

#nullable disable

namespace sacramentMeetingPlanner.Migrations
{
    public partial class InitialCreate : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Bishopric",
                columns: table => new
                {
                    BishopricID = table.Column<int>(type: "INTEGER", nullable: false)
                        .Annotation("Sqlite:Autoincrement", true),
                    Name = table.Column<string>(type: "TEXT", nullable: false),
                    Calling = table.Column<string>(type: "TEXT", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Bishopric", x => x.BishopricID);
                });

            migrationBuilder.CreateTable(
                name: "Hymn",
                columns: table => new
                {
                    HymnID = table.Column<int>(type: "INTEGER", nullable: false)
                        .Annotation("Sqlite:Autoincrement", true),
                    Number = table.Column<int>(type: "INTEGER", nullable: false),
                    Title = table.Column<string>(type: "TEXT", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Hymn", x => x.HymnID);
                });

            migrationBuilder.CreateTable(
                name: "SacramentMeeting",
                columns: table => new
                {
                    SacramentMeetingID = table.Column<int>(type: "INTEGER", nullable: false)
                        .Annotation("Sqlite:Autoincrement", true),
                    Invocation = table.Column<string>(type: "TEXT", maxLength: 50, nullable: false),
                    Benediction = table.Column<string>(type: "TEXT", maxLength: 50, nullable: false),
                    Date = table.Column<DateTime>(type: "TEXT", nullable: false),
                    OpeningHymn = table.Column<int>(type: "INTEGER", nullable: false),
                    SacramentHymn = table.Column<int>(type: "INTEGER", nullable: false),
                    ClosingHymn = table.Column<int>(type: "INTEGER", nullable: false),
                    DismissalHymn = table.Column<int>(type: "INTEGER", nullable: false),
                    Presiding = table.Column<int>(type: "INTEGER", nullable: false),
                    Conducting = table.Column<int>(type: "INTEGER", nullable: false),
                    SpeakerID = table.Column<int>(type: "INTEGER", nullable: false),
                    BishopricID = table.Column<int>(type: "INTEGER", nullable: false),
                    HymnID = table.Column<int>(type: "INTEGER", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_SacramentMeeting", x => x.SacramentMeetingID);
                    table.ForeignKey(
                        name: "FK_SacramentMeeting_Bishopric_BishopricID",
                        column: x => x.BishopricID,
                        principalTable: "Bishopric",
                        principalColumn: "BishopricID",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_SacramentMeeting_Hymn_HymnID",
                        column: x => x.HymnID,
                        principalTable: "Hymn",
                        principalColumn: "HymnID",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "Speaker",
                columns: table => new
                {
                    SpeakerID = table.Column<int>(type: "INTEGER", nullable: false)
                        .Annotation("Sqlite:Autoincrement", true),
                    Name = table.Column<string>(type: "TEXT", nullable: false),
                    SubjectType = table.Column<string>(type: "TEXT", nullable: false),
                    Gender = table.Column<string>(type: "TEXT", nullable: false),
                    SacramentMeetingID = table.Column<int>(type: "INTEGER", nullable: false),
                    SacramentMeetingID1 = table.Column<int>(type: "INTEGER", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Speaker", x => x.SpeakerID);
                    table.ForeignKey(
                        name: "FK_Speaker_SacramentMeeting_SacramentMeetingID1",
                        column: x => x.SacramentMeetingID1,
                        principalTable: "SacramentMeeting",
                        principalColumn: "SacramentMeetingID",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateIndex(
                name: "IX_SacramentMeeting_BishopricID",
                table: "SacramentMeeting",
                column: "BishopricID");

            migrationBuilder.CreateIndex(
                name: "IX_SacramentMeeting_HymnID",
                table: "SacramentMeeting",
                column: "HymnID");

            migrationBuilder.CreateIndex(
                name: "IX_Speaker_SacramentMeetingID1",
                table: "Speaker",
                column: "SacramentMeetingID1");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Speaker");

            migrationBuilder.DropTable(
                name: "SacramentMeeting");

            migrationBuilder.DropTable(
                name: "Bishopric");

            migrationBuilder.DropTable(
                name: "Hymn");
        }
    }
}
