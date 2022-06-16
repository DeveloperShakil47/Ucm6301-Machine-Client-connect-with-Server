using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace UcmData.Client.Migrations
{
    public partial class Firstmigrations : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "cdrs",
                columns: table => new
                {
                    AcctId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    accountcode = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    src = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    dst = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    clid = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    start = table.Column<DateTime>(type: "datetime2", nullable: false),
                    answer = table.Column<DateTime>(type: "datetime2", nullable: false),
                    end = table.Column<DateTime>(type: "datetime2", nullable: false),
                    duration = table.Column<int>(type: "int", nullable: false),
                    billsec = table.Column<int>(type: "int", nullable: false),
                    dstchannel_ext = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    src_trunk_name = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_cdrs", x => x.AcctId);
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "cdrs");
        }
    }
}
