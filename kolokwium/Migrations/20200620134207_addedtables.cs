using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace kolokwium.Migrations
{
    public partial class addedtables : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Events",
                columns: table => new
                {
                    IdEvent = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Name = table.Column<string>(maxLength: 100, nullable: false),
                    StartDate = table.Column<DateTime>(nullable: false),
                    EndDate = table.Column<DateTime>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Events", x => x.IdEvent);
                });

            migrationBuilder.CreateTable(
                name: "Organiser",
                columns: table => new
                {
                    IdOrganiser = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Name = table.Column<string>(maxLength: 30, nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Organiser", x => x.IdOrganiser);
                });

            migrationBuilder.CreateTable(
                name: "Artist_Events",
                columns: table => new
                {
                    IdEvent = table.Column<int>(nullable: false),
                    IdArtist = table.Column<int>(nullable: false),
                    PerformanceDate = table.Column<DateTime>(nullable: false),
                    ArtistIdArtist = table.Column<int>(nullable: true),
                    EventIdEvent = table.Column<int>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Artist_Events", x => new { x.IdArtist, x.IdEvent });
                    table.ForeignKey(
                        name: "FK_Artist_Events_Artists_ArtistIdArtist",
                        column: x => x.ArtistIdArtist,
                        principalTable: "Artists",
                        principalColumn: "IdArtist",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_Artist_Events_Events_EventIdEvent",
                        column: x => x.EventIdEvent,
                        principalTable: "Events",
                        principalColumn: "IdEvent",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "Event_Organizers",
                columns: table => new
                {
                    IdEvent = table.Column<int>(nullable: false),
                    IdOrganiser = table.Column<int>(nullable: false),
                    EventIdEvent = table.Column<int>(nullable: true),
                    OrganiserIdOrganiser = table.Column<int>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Event_Organizers", x => new { x.IdEvent, x.IdOrganiser });
                    table.ForeignKey(
                        name: "FK_Event_Organizers_Events_EventIdEvent",
                        column: x => x.EventIdEvent,
                        principalTable: "Events",
                        principalColumn: "IdEvent",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_Event_Organizers_Organiser_OrganiserIdOrganiser",
                        column: x => x.OrganiserIdOrganiser,
                        principalTable: "Organiser",
                        principalColumn: "IdOrganiser",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateIndex(
                name: "IX_Artist_Events_ArtistIdArtist",
                table: "Artist_Events",
                column: "ArtistIdArtist");

            migrationBuilder.CreateIndex(
                name: "IX_Artist_Events_EventIdEvent",
                table: "Artist_Events",
                column: "EventIdEvent");

            migrationBuilder.CreateIndex(
                name: "IX_Event_Organizers_EventIdEvent",
                table: "Event_Organizers",
                column: "EventIdEvent");

            migrationBuilder.CreateIndex(
                name: "IX_Event_Organizers_OrganiserIdOrganiser",
                table: "Event_Organizers",
                column: "OrganiserIdOrganiser");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Artist_Events");

            migrationBuilder.DropTable(
                name: "Event_Organizers");

            migrationBuilder.DropTable(
                name: "Events");

            migrationBuilder.DropTable(
                name: "Organiser");
        }
    }
}
