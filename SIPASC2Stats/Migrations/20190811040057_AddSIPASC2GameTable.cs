using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace SIPASC2Stats.Migrations
{
    public partial class AddSIPASC2GameTable : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "SIPAGame");

            migrationBuilder.CreateTable(
                name: "SIPASC2Game",
                columns: table => new
                {
                    ID = table.Column<string>(nullable: false),
                    BattleNetID = table.Column<string>(nullable: true),
                    Event_ID = table.Column<string>(nullable: true),
                    Win = table.Column<bool>(nullable: false),
                    Map = table.Column<string>(nullable: true),
                    ReplayFile = table.Column<string>(nullable: true),
                    ReplayFileSize = table.Column<long>(nullable: false),
                    UploadDT = table.Column<DateTime>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_SIPASC2Game", x => x.ID);
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "SIPASC2Game");

            migrationBuilder.CreateTable(
                name: "SIPAGame",
                columns: table => new
                {
                    ID = table.Column<string>(nullable: false),
                    BattleNetID = table.Column<string>(nullable: true),
                    ReplayFile = table.Column<string>(nullable: true),
                    ReplayFileSize = table.Column<long>(nullable: false),
                    UploadDT = table.Column<DateTime>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_SIPAGame", x => x.ID);
                });
        }
    }
}
