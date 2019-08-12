using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace SIPASC2Stats.Migrations
{
    public partial class AddSIPAGameTable : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
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

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "SIPAGame");
        }
    }
}
