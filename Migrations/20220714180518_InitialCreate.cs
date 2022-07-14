using System;
using Microsoft.EntityFrameworkCore.Migrations;

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
                    OpeningHymnID = table.Column<int>(type: "INTEGER", nullable: true),
                    SacramentHymnID = table.Column<int>(type: "INTEGER", nullable: true),
                    ClosingHymnID = table.Column<int>(type: "INTEGER", nullable: true),
                    DismissalHymnID = table.Column<int>(type: "INTEGER", nullable: true),
                    PresidingID = table.Column<int>(type: "INTEGER", nullable: true),
                    ConductingID = table.Column<int>(type: "INTEGER", nullable: true),
                    MusicalNumberID = table.Column<int>(type: "INTEGER", nullable: true),
                    MusicalPerformance = table.Column<string>(type: "TEXT", nullable: true),
                    BishopricID = table.Column<int>(type: "INTEGER", nullable: true),
                    HymnID = table.Column<int>(type: "INTEGER", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_SacramentMeeting", x => x.SacramentMeetingID);
                    table.ForeignKey(
                        name: "FK_SacramentMeeting_Bishopric_BishopricID",
                        column: x => x.BishopricID,
                        principalTable: "Bishopric",
                        principalColumn: "BishopricID");
                    table.ForeignKey(
                        name: "FK_SacramentMeeting_Bishopric_ConductingID",
                        column: x => x.ConductingID,
                        principalTable: "Bishopric",
                        principalColumn: "BishopricID");
                    table.ForeignKey(
                        name: "FK_SacramentMeeting_Bishopric_PresidingID",
                        column: x => x.PresidingID,
                        principalTable: "Bishopric",
                        principalColumn: "BishopricID");
                    table.ForeignKey(
                        name: "FK_SacramentMeeting_Hymn_ClosingHymnID",
                        column: x => x.ClosingHymnID,
                        principalTable: "Hymn",
                        principalColumn: "HymnID");
                    table.ForeignKey(
                        name: "FK_SacramentMeeting_Hymn_DismissalHymnID",
                        column: x => x.DismissalHymnID,
                        principalTable: "Hymn",
                        principalColumn: "HymnID");
                    table.ForeignKey(
                        name: "FK_SacramentMeeting_Hymn_HymnID",
                        column: x => x.HymnID,
                        principalTable: "Hymn",
                        principalColumn: "HymnID");
                    table.ForeignKey(
                        name: "FK_SacramentMeeting_Hymn_MusicalNumberID",
                        column: x => x.MusicalNumberID,
                        principalTable: "Hymn",
                        principalColumn: "HymnID");
                    table.ForeignKey(
                        name: "FK_SacramentMeeting_Hymn_OpeningHymnID",
                        column: x => x.OpeningHymnID,
                        principalTable: "Hymn",
                        principalColumn: "HymnID");
                    table.ForeignKey(
                        name: "FK_SacramentMeeting_Hymn_SacramentHymnID",
                        column: x => x.SacramentHymnID,
                        principalTable: "Hymn",
                        principalColumn: "HymnID");
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
                    SacramentMeetingID = table.Column<int>(type: "INTEGER", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Speaker", x => x.SpeakerID);
                    table.ForeignKey(
                        name: "FK_Speaker_SacramentMeeting_SacramentMeetingID",
                        column: x => x.SacramentMeetingID,
                        principalTable: "SacramentMeeting",
                        principalColumn: "SacramentMeetingID");
                });

            migrationBuilder.CreateIndex(
                name: "IX_SacramentMeeting_BishopricID",
                table: "SacramentMeeting",
                column: "BishopricID");

            migrationBuilder.CreateIndex(
                name: "IX_SacramentMeeting_ClosingHymnID",
                table: "SacramentMeeting",
                column: "ClosingHymnID");

            migrationBuilder.CreateIndex(
                name: "IX_SacramentMeeting_ConductingID",
                table: "SacramentMeeting",
                column: "ConductingID");

            migrationBuilder.CreateIndex(
                name: "IX_SacramentMeeting_DismissalHymnID",
                table: "SacramentMeeting",
                column: "DismissalHymnID");

            migrationBuilder.CreateIndex(
                name: "IX_SacramentMeeting_HymnID",
                table: "SacramentMeeting",
                column: "HymnID");

            migrationBuilder.CreateIndex(
                name: "IX_SacramentMeeting_MusicalNumberID",
                table: "SacramentMeeting",
                column: "MusicalNumberID");

            migrationBuilder.CreateIndex(
                name: "IX_SacramentMeeting_OpeningHymnID",
                table: "SacramentMeeting",
                column: "OpeningHymnID");

            migrationBuilder.CreateIndex(
                name: "IX_SacramentMeeting_PresidingID",
                table: "SacramentMeeting",
                column: "PresidingID");

            migrationBuilder.CreateIndex(
                name: "IX_SacramentMeeting_SacramentHymnID",
                table: "SacramentMeeting",
                column: "SacramentHymnID");

            migrationBuilder.CreateIndex(
                name: "IX_Speaker_SacramentMeetingID",
                table: "Speaker",
                column: "SacramentMeetingID");
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
