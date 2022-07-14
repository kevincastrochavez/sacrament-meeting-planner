using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace sacramentMeetingPlanner.Migrations
{
    public partial class MusicalNumber : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<int>(
                name: "MusicalNumberID",
                table: "SacramentMeeting",
                type: "INTEGER",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "MusicalPerformance",
                table: "SacramentMeeting",
                type: "TEXT",
                nullable: false,
                defaultValue: "");

            migrationBuilder.CreateIndex(
                name: "IX_SacramentMeeting_MusicalNumberID",
                table: "SacramentMeeting",
                column: "MusicalNumberID");

            migrationBuilder.AddForeignKey(
                name: "FK_SacramentMeeting_Hymn_MusicalNumberID",
                table: "SacramentMeeting",
                column: "MusicalNumberID",
                principalTable: "Hymn",
                principalColumn: "HymnID");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_SacramentMeeting_Hymn_MusicalNumberID",
                table: "SacramentMeeting");

            migrationBuilder.DropIndex(
                name: "IX_SacramentMeeting_MusicalNumberID",
                table: "SacramentMeeting");

            migrationBuilder.DropColumn(
                name: "MusicalNumberID",
                table: "SacramentMeeting");

            migrationBuilder.DropColumn(
                name: "MusicalPerformance",
                table: "SacramentMeeting");
        }
    }
}
