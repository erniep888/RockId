using Microsoft.EntityFrameworkCore.Migrations;

namespace RockId.Qarp.DataMapper.Migrations
{
    public partial class AddedDefaultData : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.InsertData(
                table: "Qarps",
                columns: new[] { "Id", "DisplayOrder", "DisplayText", "IsQuestion", "ParentId", "RockType" },
                values: new object[] { 1, 1, "What is the grain size?", true, null, "NA" });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Qarps",
                keyColumn: "Id",
                keyValue: 1);
        }
    }
}
