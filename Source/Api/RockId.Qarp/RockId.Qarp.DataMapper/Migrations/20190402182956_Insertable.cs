using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace RockId.Qarp.DataMapper.Migrations
{
    public partial class Insertable : Migration
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
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "CreateDateUtc",
                table: "Qarps");

            migrationBuilder.DropColumn(
                name: "CreatedBy",
                table: "Qarps");
        }
    }
}
