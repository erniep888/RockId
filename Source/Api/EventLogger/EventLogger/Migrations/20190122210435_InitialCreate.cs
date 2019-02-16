using System;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;

namespace EventLogger.Migrations
{
    public partial class InitialCreate : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Events",
                columns: table => new
                {
                    RockIdEventId = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    EventTitle = table.Column<string>(nullable: false),
                    EventSource = table.Column<string>(nullable: false),
                    EventDateTimeUTC = table.Column<DateTime>(nullable: false),
                    EventStoredDateTimeUTC = table.Column<DateTime>(nullable: false),
                    User = table.Column<string>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Events", x => x.RockIdEventId);
                });

            migrationBuilder.InsertData(
                table: "Events",
                columns: new[] { "RockIdEventId", "EventTitle", "EventSource", "EventDateTimeUTC", "EventStoredDateTimeUTC", "User" },
                values: new object[] { 1, "Initial run event.", "Migration", DateTime.UtcNow, DateTime.UtcNow, "System" });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Events");
        }
    }
}
