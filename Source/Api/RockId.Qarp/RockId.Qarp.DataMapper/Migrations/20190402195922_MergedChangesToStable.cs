using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace RockId.Qarp.DataMapper.Migrations
{
    public partial class MergedChangesToStable : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "Qarps",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CreateDateUtc", "UpdateDateUtc" },
                values: new object[] { new DateTime(2019, 4, 2, 19, 59, 21, 798, DateTimeKind.Utc).AddTicks(4624), new DateTime(2019, 4, 2, 19, 59, 21, 798, DateTimeKind.Utc).AddTicks(5328) });

            migrationBuilder.UpdateData(
                table: "Qarps",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "CreateDateUtc", "UpdateDateUtc" },
                values: new object[] { new DateTime(2019, 4, 2, 19, 59, 21, 798, DateTimeKind.Utc).AddTicks(6039), new DateTime(2019, 4, 2, 19, 59, 21, 798, DateTimeKind.Utc).AddTicks(6044) });

            migrationBuilder.UpdateData(
                table: "Qarps",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "CreateDateUtc", "UpdateDateUtc" },
                values: new object[] { new DateTime(2019, 4, 2, 19, 59, 21, 798, DateTimeKind.Utc).AddTicks(6050), new DateTime(2019, 4, 2, 19, 59, 21, 798, DateTimeKind.Utc).AddTicks(6050) });

            migrationBuilder.UpdateData(
                table: "Qarps",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "CreateDateUtc", "UpdateDateUtc" },
                values: new object[] { new DateTime(2019, 4, 2, 19, 59, 21, 798, DateTimeKind.Utc).AddTicks(6051), new DateTime(2019, 4, 2, 19, 59, 21, 798, DateTimeKind.Utc).AddTicks(6052) });

            migrationBuilder.UpdateData(
                table: "Qarps",
                keyColumn: "Id",
                keyValue: 5,
                columns: new[] { "CreateDateUtc", "UpdateDateUtc" },
                values: new object[] { new DateTime(2019, 4, 2, 19, 59, 21, 798, DateTimeKind.Utc).AddTicks(6053), new DateTime(2019, 4, 2, 19, 59, 21, 798, DateTimeKind.Utc).AddTicks(6053) });

            migrationBuilder.UpdateData(
                table: "Qarps",
                keyColumn: "Id",
                keyValue: 6,
                columns: new[] { "CreateDateUtc", "UpdateDateUtc" },
                values: new object[] { new DateTime(2019, 4, 2, 19, 59, 21, 798, DateTimeKind.Utc).AddTicks(6054), new DateTime(2019, 4, 2, 19, 59, 21, 798, DateTimeKind.Utc).AddTicks(6054) });

            migrationBuilder.UpdateData(
                table: "Qarps",
                keyColumn: "Id",
                keyValue: 7,
                columns: new[] { "CreateDateUtc", "UpdateDateUtc" },
                values: new object[] { new DateTime(2019, 4, 2, 19, 59, 21, 798, DateTimeKind.Utc).AddTicks(6135), new DateTime(2019, 4, 2, 19, 59, 21, 798, DateTimeKind.Utc).AddTicks(6136) });

            migrationBuilder.UpdateData(
                table: "Qarps",
                keyColumn: "Id",
                keyValue: 8,
                columns: new[] { "CreateDateUtc", "UpdateDateUtc" },
                values: new object[] { new DateTime(2019, 4, 2, 19, 59, 21, 798, DateTimeKind.Utc).AddTicks(6137), new DateTime(2019, 4, 2, 19, 59, 21, 798, DateTimeKind.Utc).AddTicks(6137) });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "Qarps",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CreateDateUtc", "UpdateDateUtc" },
                values: new object[] { new DateTime(2019, 4, 2, 19, 19, 46, 966, DateTimeKind.Utc).AddTicks(8238), new DateTime(2019, 4, 2, 19, 19, 46, 966, DateTimeKind.Utc).AddTicks(8943) });

            migrationBuilder.UpdateData(
                table: "Qarps",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "CreateDateUtc", "UpdateDateUtc" },
                values: new object[] { new DateTime(2019, 4, 2, 19, 19, 46, 966, DateTimeKind.Utc).AddTicks(9653), new DateTime(2019, 4, 2, 19, 19, 46, 966, DateTimeKind.Utc).AddTicks(9658) });

            migrationBuilder.UpdateData(
                table: "Qarps",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "CreateDateUtc", "UpdateDateUtc" },
                values: new object[] { new DateTime(2019, 4, 2, 19, 19, 46, 966, DateTimeKind.Utc).AddTicks(9664), new DateTime(2019, 4, 2, 19, 19, 46, 966, DateTimeKind.Utc).AddTicks(9664) });

            migrationBuilder.UpdateData(
                table: "Qarps",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "CreateDateUtc", "UpdateDateUtc" },
                values: new object[] { new DateTime(2019, 4, 2, 19, 19, 46, 966, DateTimeKind.Utc).AddTicks(9665), new DateTime(2019, 4, 2, 19, 19, 46, 966, DateTimeKind.Utc).AddTicks(9666) });

            migrationBuilder.UpdateData(
                table: "Qarps",
                keyColumn: "Id",
                keyValue: 5,
                columns: new[] { "CreateDateUtc", "UpdateDateUtc" },
                values: new object[] { new DateTime(2019, 4, 2, 19, 19, 46, 966, DateTimeKind.Utc).AddTicks(9666), new DateTime(2019, 4, 2, 19, 19, 46, 966, DateTimeKind.Utc).AddTicks(9667) });

            migrationBuilder.UpdateData(
                table: "Qarps",
                keyColumn: "Id",
                keyValue: 6,
                columns: new[] { "CreateDateUtc", "UpdateDateUtc" },
                values: new object[] { new DateTime(2019, 4, 2, 19, 19, 46, 966, DateTimeKind.Utc).AddTicks(9668), new DateTime(2019, 4, 2, 19, 19, 46, 966, DateTimeKind.Utc).AddTicks(9668) });

            migrationBuilder.UpdateData(
                table: "Qarps",
                keyColumn: "Id",
                keyValue: 7,
                columns: new[] { "CreateDateUtc", "UpdateDateUtc" },
                values: new object[] { new DateTime(2019, 4, 2, 19, 19, 46, 966, DateTimeKind.Utc).AddTicks(9669), new DateTime(2019, 4, 2, 19, 19, 46, 966, DateTimeKind.Utc).AddTicks(9669) });

            migrationBuilder.UpdateData(
                table: "Qarps",
                keyColumn: "Id",
                keyValue: 8,
                columns: new[] { "CreateDateUtc", "UpdateDateUtc" },
                values: new object[] { new DateTime(2019, 4, 2, 19, 19, 46, 966, DateTimeKind.Utc).AddTicks(9670), new DateTime(2019, 4, 2, 19, 19, 46, 966, DateTimeKind.Utc).AddTicks(9670) });
        }
    }
}
