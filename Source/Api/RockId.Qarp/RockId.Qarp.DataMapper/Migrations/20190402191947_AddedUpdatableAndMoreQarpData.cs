using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace RockId.Qarp.DataMapper.Migrations
{
    public partial class AddedUpdatableAndMoreQarpData : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<DateTime>(
                name: "CreateDateUtc",
                table: "Qarps",
                nullable: false,
                defaultValue: new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified));

            migrationBuilder.AddColumn<string>(
                name: "CreatedBy",
                table: "Qarps",
                nullable: true);

            migrationBuilder.AddColumn<DateTime>(
                name: "UpdateDateUtc",
                table: "Qarps",
                nullable: false,
                defaultValue: new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified));

            migrationBuilder.AddColumn<string>(
                name: "UpdatedBy",
                table: "Qarps",
                nullable: true);

            migrationBuilder.UpdateData(
                table: "Qarps",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CreateDateUtc", "CreatedBy", "UpdateDateUtc", "UpdatedBy" },
                values: new object[] { new DateTime(2019, 4, 2, 19, 19, 46, 966, DateTimeKind.Utc).AddTicks(8238), "System", new DateTime(2019, 4, 2, 19, 19, 46, 966, DateTimeKind.Utc).AddTicks(8943), "System" });

            migrationBuilder.InsertData(
                table: "Qarps",
                columns: new[] { "Id", "CreateDateUtc", "CreatedBy", "DisplayOrder", "DisplayText", "IsQuestion", "ParentId", "RockType", "UpdateDateUtc", "UpdatedBy" },
                values: new object[,]
                {
                    { 2, new DateTime(2019, 4, 2, 19, 19, 46, 966, DateTimeKind.Utc).AddTicks(9653), "System", 1, "Glassy (no visible grains)", false, 1, "NA", new DateTime(2019, 4, 2, 19, 19, 46, 966, DateTimeKind.Utc).AddTicks(9658), "System" },
                    { 3, new DateTime(2019, 4, 2, 19, 19, 46, 966, DateTimeKind.Utc).AddTicks(9664), "System", 2, "Fine Grained (not easy to see grains)", false, 1, "NA", new DateTime(2019, 4, 2, 19, 19, 46, 966, DateTimeKind.Utc).AddTicks(9664), "System" },
                    { 4, new DateTime(2019, 4, 2, 19, 19, 46, 966, DateTimeKind.Utc).AddTicks(9665), "System", 3, "Mixed Fine and Coarse", false, 1, "NA", new DateTime(2019, 4, 2, 19, 19, 46, 966, DateTimeKind.Utc).AddTicks(9666), "System" },
                    { 5, new DateTime(2019, 4, 2, 19, 19, 46, 966, DateTimeKind.Utc).AddTicks(9666), "System", 4, "Medium to Coarse", false, 1, "NA", new DateTime(2019, 4, 2, 19, 19, 46, 966, DateTimeKind.Utc).AddTicks(9667), "System" },
                    { 6, new DateTime(2019, 4, 2, 19, 19, 46, 966, DateTimeKind.Utc).AddTicks(9668), "System", 1, "Is it light or dark?", true, 2, "NA", new DateTime(2019, 4, 2, 19, 19, 46, 966, DateTimeKind.Utc).AddTicks(9668), "System" },
                    { 7, new DateTime(2019, 4, 2, 19, 19, 46, 966, DateTimeKind.Utc).AddTicks(9669), "System", 1, "Light - Quartz", false, 6, "Igneous", new DateTime(2019, 4, 2, 19, 19, 46, 966, DateTimeKind.Utc).AddTicks(9669), "System" },
                    { 8, new DateTime(2019, 4, 2, 19, 19, 46, 966, DateTimeKind.Utc).AddTicks(9670), "System", 2, "Dark - Obsidian", false, 6, "Igneous", new DateTime(2019, 4, 2, 19, 19, 46, 966, DateTimeKind.Utc).AddTicks(9670), "System" }
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Qarps",
                keyColumn: "Id",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "Qarps",
                keyColumn: "Id",
                keyValue: 3);

            migrationBuilder.DeleteData(
                table: "Qarps",
                keyColumn: "Id",
                keyValue: 4);

            migrationBuilder.DeleteData(
                table: "Qarps",
                keyColumn: "Id",
                keyValue: 5);

            migrationBuilder.DeleteData(
                table: "Qarps",
                keyColumn: "Id",
                keyValue: 6);

            migrationBuilder.DeleteData(
                table: "Qarps",
                keyColumn: "Id",
                keyValue: 7);

            migrationBuilder.DeleteData(
                table: "Qarps",
                keyColumn: "Id",
                keyValue: 8);

            migrationBuilder.DropColumn(
                name: "CreateDateUtc",
                table: "Qarps");

            migrationBuilder.DropColumn(
                name: "CreatedBy",
                table: "Qarps");

            migrationBuilder.DropColumn(
                name: "UpdateDateUtc",
                table: "Qarps");

            migrationBuilder.DropColumn(
                name: "UpdatedBy",
                table: "Qarps");
        }
    }
}
