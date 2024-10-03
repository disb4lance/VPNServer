using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace VPN_Management.Migrations
{
    /// <inheritdoc />
    public partial class first : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "VPNConfigurations",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    UserId = table.Column<int>(type: "int", nullable: false),
                    Protocol = table.Column<int>(type: "int", nullable: false),
                    EncryptionLevel = table.Column<int>(type: "int", nullable: false),
                    CustomSettings = table.Column<string>(type: "nvarchar(max)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_VPNConfigurations", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "VPNServers",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Name = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    IP = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Country = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    MaxConnections = table.Column<int>(type: "int", nullable: false),
                    CurrentConnections = table.Column<int>(type: "int", nullable: false),
                    Status = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_VPNServers", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "VPNSessions",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    UserId = table.Column<int>(type: "int", nullable: false),
                    ServerId = table.Column<int>(type: "int", nullable: false),
                    StartTime = table.Column<DateTime>(type: "datetime2", nullable: false),
                    EndTime = table.Column<DateTime>(type: "datetime2", nullable: true),
                    DataUsage = table.Column<long>(type: "bigint", nullable: false),
                    VPNServerId = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_VPNSessions", x => x.Id);
                    table.ForeignKey(
                        name: "FK_VPNSessions_VPNServers_VPNServerId",
                        column: x => x.VPNServerId,
                        principalTable: "VPNServers",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateIndex(
                name: "IX_VPNSessions_VPNServerId",
                table: "VPNSessions",
                column: "VPNServerId");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "VPNConfigurations");

            migrationBuilder.DropTable(
                name: "VPNSessions");

            migrationBuilder.DropTable(
                name: "VPNServers");
        }
    }
}
