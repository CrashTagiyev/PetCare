using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Persistance.Migrations
{
    /// <inheritdoc />
    public partial class mig989 : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AlterColumn<string>(
                name: "City",
                table: "AspNetUsers",
                type: "nvarchar(max)",
                nullable: true,
                oldClrType: typeof(string),
                oldType: "nvarchar(max)");

            migrationBuilder.AlterColumn<string>(
                name: "Address",
                table: "AspNetUsers",
                type: "nvarchar(max)",
                nullable: true,
                oldClrType: typeof(string),
                oldType: "nvarchar(max)");

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: 2001,
                columns: new[] { "ConcurrencyStamp", "CreatedTime", "LastUpdatedTime", "RefreshTokenCreateTime" },
                values: new object[] { "5d2aad15-f559-4033-8d18-17056cc9ee1d", new DateTime(2024, 8, 16, 12, 50, 21, 408, DateTimeKind.Utc).AddTicks(9127), new DateTime(2024, 8, 16, 12, 50, 21, 408, DateTimeKind.Utc).AddTicks(9129), new DateTime(2024, 8, 16, 16, 50, 21, 408, DateTimeKind.Local).AddTicks(9003) });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: 2002,
                columns: new[] { "ConcurrencyStamp", "CreatedTime", "LastUpdatedTime", "RefreshTokenCreateTime" },
                values: new object[] { "f83d24ae-0105-4584-91b3-e41f59fdfb9e", new DateTime(2024, 8, 16, 12, 50, 21, 408, DateTimeKind.Utc).AddTicks(9170), new DateTime(2024, 8, 16, 12, 50, 21, 408, DateTimeKind.Utc).AddTicks(9171), new DateTime(2024, 8, 16, 16, 50, 21, 408, DateTimeKind.Local).AddTicks(9161) });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: 2003,
                columns: new[] { "ConcurrencyStamp", "CreatedTime", "LastUpdatedTime", "RefreshTokenCreateTime" },
                values: new object[] { "f37dec91-71de-4897-99e1-b1d6feeed678", new DateTime(2024, 8, 16, 12, 50, 21, 408, DateTimeKind.Utc).AddTicks(9189), new DateTime(2024, 8, 16, 12, 50, 21, 408, DateTimeKind.Utc).AddTicks(9189), new DateTime(2024, 8, 16, 16, 50, 21, 408, DateTimeKind.Local).AddTicks(9182) });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: 2004,
                columns: new[] { "ConcurrencyStamp", "CreatedTime", "LastUpdatedTime", "RefreshTokenCreateTime" },
                values: new object[] { "334587f9-d4a7-4a6f-b317-82658cf82414", new DateTime(2024, 8, 16, 12, 50, 21, 408, DateTimeKind.Utc).AddTicks(9211), new DateTime(2024, 8, 16, 12, 50, 21, 408, DateTimeKind.Utc).AddTicks(9212), new DateTime(2024, 8, 16, 16, 50, 21, 408, DateTimeKind.Local).AddTicks(9205) });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: 2005,
                columns: new[] { "ConcurrencyStamp", "CreatedTime", "LastUpdatedTime", "RefreshTokenCreateTime" },
                values: new object[] { "43d489d3-80ee-4699-a5ef-bf01928c26f7", new DateTime(2024, 8, 16, 12, 50, 21, 408, DateTimeKind.Utc).AddTicks(9309), new DateTime(2024, 8, 16, 12, 50, 21, 408, DateTimeKind.Utc).AddTicks(9310), new DateTime(2024, 8, 16, 16, 50, 21, 408, DateTimeKind.Local).AddTicks(9301) });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: 2006,
                columns: new[] { "ConcurrencyStamp", "CreatedTime", "LastUpdatedTime", "RefreshTokenCreateTime" },
                values: new object[] { "30827dc0-4672-4187-be4d-2114c091ba81", new DateTime(2024, 8, 16, 12, 50, 21, 408, DateTimeKind.Utc).AddTicks(9331), new DateTime(2024, 8, 16, 12, 50, 21, 408, DateTimeKind.Utc).AddTicks(9332), new DateTime(2024, 8, 16, 16, 50, 21, 408, DateTimeKind.Local).AddTicks(9324) });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: 2007,
                columns: new[] { "ConcurrencyStamp", "CreatedTime", "LastUpdatedTime", "RefreshTokenCreateTime" },
                values: new object[] { "e7918e98-1248-4331-b0bf-79edf2a7311a", new DateTime(2024, 8, 16, 12, 50, 21, 408, DateTimeKind.Utc).AddTicks(9347), new DateTime(2024, 8, 16, 12, 50, 21, 408, DateTimeKind.Utc).AddTicks(9348), new DateTime(2024, 8, 16, 16, 50, 21, 408, DateTimeKind.Local).AddTicks(9341) });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: 2008,
                columns: new[] { "ConcurrencyStamp", "CreatedTime", "LastUpdatedTime", "RefreshTokenCreateTime" },
                values: new object[] { "cac2c530-f361-4190-a0da-9818e27299c1", new DateTime(2024, 8, 16, 12, 50, 21, 408, DateTimeKind.Utc).AddTicks(9386), new DateTime(2024, 8, 16, 12, 50, 21, 408, DateTimeKind.Utc).AddTicks(9387), new DateTime(2024, 8, 16, 16, 50, 21, 408, DateTimeKind.Local).AddTicks(9357) });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: 2009,
                columns: new[] { "ConcurrencyStamp", "CreatedTime", "LastUpdatedTime", "RefreshTokenCreateTime" },
                values: new object[] { "f56b6b97-aee7-4a47-a066-e694259d3d90", new DateTime(2024, 8, 16, 12, 50, 21, 408, DateTimeKind.Utc).AddTicks(9405), new DateTime(2024, 8, 16, 12, 50, 21, 408, DateTimeKind.Utc).AddTicks(9406), new DateTime(2024, 8, 16, 16, 50, 21, 408, DateTimeKind.Local).AddTicks(9397) });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: 2010,
                columns: new[] { "ConcurrencyStamp", "CreatedTime", "LastUpdatedTime", "RefreshTokenCreateTime" },
                values: new object[] { "6badc450-52e9-4f5e-87dd-52e1d6daae3c", new DateTime(2024, 8, 16, 12, 50, 21, 408, DateTimeKind.Utc).AddTicks(9426), new DateTime(2024, 8, 16, 12, 50, 21, 408, DateTimeKind.Utc).AddTicks(9426), new DateTime(2024, 8, 16, 16, 50, 21, 408, DateTimeKind.Local).AddTicks(9417) });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: 2011,
                columns: new[] { "ConcurrencyStamp", "CreatedTime", "LastUpdatedTime", "RefreshTokenCreateTime" },
                values: new object[] { "d250d633-e596-4a8b-b889-c7373574d9ca", new DateTime(2024, 8, 16, 12, 50, 21, 408, DateTimeKind.Utc).AddTicks(9444), new DateTime(2024, 8, 16, 12, 50, 21, 408, DateTimeKind.Utc).AddTicks(9445), new DateTime(2024, 8, 16, 16, 50, 21, 408, DateTimeKind.Local).AddTicks(9438) });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: 2012,
                columns: new[] { "ConcurrencyStamp", "CreatedTime", "LastUpdatedTime", "RefreshTokenCreateTime" },
                values: new object[] { "eb6f5038-0281-4da4-ab18-cd4db04c8dc6", new DateTime(2024, 8, 16, 12, 50, 21, 408, DateTimeKind.Utc).AddTicks(9461), new DateTime(2024, 8, 16, 12, 50, 21, 408, DateTimeKind.Utc).AddTicks(9461), new DateTime(2024, 8, 16, 16, 50, 21, 408, DateTimeKind.Local).AddTicks(9454) });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: 2013,
                columns: new[] { "ConcurrencyStamp", "CreatedTime", "LastUpdatedTime", "RefreshTokenCreateTime" },
                values: new object[] { "df584994-e2d0-43d0-a0db-5ac3bdf77eaf", new DateTime(2024, 8, 16, 12, 50, 21, 408, DateTimeKind.Utc).AddTicks(9478), new DateTime(2024, 8, 16, 12, 50, 21, 408, DateTimeKind.Utc).AddTicks(9478), new DateTime(2024, 8, 16, 16, 50, 21, 408, DateTimeKind.Local).AddTicks(9471) });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: 2014,
                columns: new[] { "ConcurrencyStamp", "CreatedTime", "LastUpdatedTime", "RefreshTokenCreateTime" },
                values: new object[] { "b10bf9ed-00a2-4f14-a59e-4f6b235a31d9", new DateTime(2024, 8, 16, 12, 50, 21, 408, DateTimeKind.Utc).AddTicks(9709), new DateTime(2024, 8, 16, 12, 50, 21, 408, DateTimeKind.Utc).AddTicks(9710), new DateTime(2024, 8, 16, 16, 50, 21, 408, DateTimeKind.Local).AddTicks(9525) });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: 2015,
                columns: new[] { "ConcurrencyStamp", "CreatedTime", "LastUpdatedTime", "RefreshTokenCreateTime" },
                values: new object[] { "f0a85016-6aec-4d8c-8453-35ef4c88554f", new DateTime(2024, 8, 16, 12, 50, 21, 408, DateTimeKind.Utc).AddTicks(9788), new DateTime(2024, 8, 16, 12, 50, 21, 408, DateTimeKind.Utc).AddTicks(9789), new DateTime(2024, 8, 16, 16, 50, 21, 408, DateTimeKind.Local).AddTicks(9738) });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: 2016,
                columns: new[] { "ConcurrencyStamp", "CreatedTime", "LastUpdatedTime", "RefreshTokenCreateTime" },
                values: new object[] { "4a82e6d0-a5af-47e3-8513-07d92271b7ab", new DateTime(2024, 8, 16, 12, 50, 21, 409, DateTimeKind.Utc).AddTicks(12), new DateTime(2024, 8, 16, 12, 50, 21, 409, DateTimeKind.Utc).AddTicks(12), new DateTime(2024, 8, 16, 16, 50, 21, 408, DateTimeKind.Local).AddTicks(9815) });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: 2017,
                columns: new[] { "ConcurrencyStamp", "CreatedTime", "LastUpdatedTime", "RefreshTokenCreateTime" },
                values: new object[] { "c67a52a6-7541-41d0-a635-5e777d5bec6e", new DateTime(2024, 8, 16, 12, 50, 21, 409, DateTimeKind.Utc).AddTicks(28), new DateTime(2024, 8, 16, 12, 50, 21, 409, DateTimeKind.Utc).AddTicks(29), new DateTime(2024, 8, 16, 16, 50, 21, 409, DateTimeKind.Local).AddTicks(21) });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: 2018,
                columns: new[] { "ConcurrencyStamp", "CreatedTime", "LastUpdatedTime", "RefreshTokenCreateTime" },
                values: new object[] { "d3012cac-ac30-459d-86d7-f8d36d34709b", new DateTime(2024, 8, 16, 12, 50, 21, 409, DateTimeKind.Utc).AddTicks(46), new DateTime(2024, 8, 16, 12, 50, 21, 409, DateTimeKind.Utc).AddTicks(47), new DateTime(2024, 8, 16, 16, 50, 21, 409, DateTimeKind.Local).AddTicks(39) });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: 2019,
                columns: new[] { "ConcurrencyStamp", "CreatedTime", "LastUpdatedTime", "RefreshTokenCreateTime" },
                values: new object[] { "1042b0d0-9886-4198-bcab-2acc33dc3d08", new DateTime(2024, 8, 16, 12, 50, 21, 409, DateTimeKind.Utc).AddTicks(62), new DateTime(2024, 8, 16, 12, 50, 21, 409, DateTimeKind.Utc).AddTicks(62), new DateTime(2024, 8, 16, 16, 50, 21, 409, DateTimeKind.Local).AddTicks(55) });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: 2020,
                columns: new[] { "ConcurrencyStamp", "CreatedTime", "LastUpdatedTime", "RefreshTokenCreateTime" },
                values: new object[] { "81c35d3d-9142-4e31-849d-cb799f34ae04", new DateTime(2024, 8, 16, 12, 50, 21, 409, DateTimeKind.Utc).AddTicks(77), new DateTime(2024, 8, 16, 12, 50, 21, 409, DateTimeKind.Utc).AddTicks(77), new DateTime(2024, 8, 16, 16, 50, 21, 409, DateTimeKind.Local).AddTicks(71) });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: 2021,
                columns: new[] { "ConcurrencyStamp", "CreatedTime", "LastUpdatedTime", "RefreshTokenCreateTime" },
                values: new object[] { "72cefcd2-eaae-412c-b275-d8ad6cb5e176", new DateTime(2024, 8, 16, 12, 50, 21, 409, DateTimeKind.Utc).AddTicks(94), new DateTime(2024, 8, 16, 12, 50, 21, 409, DateTimeKind.Utc).AddTicks(95), new DateTime(2024, 8, 16, 16, 50, 21, 409, DateTimeKind.Local).AddTicks(87) });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: 2022,
                columns: new[] { "ConcurrencyStamp", "CreatedTime", "LastUpdatedTime", "RefreshTokenCreateTime" },
                values: new object[] { "d569f477-36ce-43ea-a55c-7e338ee4bb66", new DateTime(2024, 8, 16, 12, 50, 21, 409, DateTimeKind.Utc).AddTicks(118), new DateTime(2024, 8, 16, 12, 50, 21, 409, DateTimeKind.Utc).AddTicks(119), new DateTime(2024, 8, 16, 16, 50, 21, 409, DateTimeKind.Local).AddTicks(111) });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: 2023,
                columns: new[] { "ConcurrencyStamp", "CreatedTime", "LastUpdatedTime", "RefreshTokenCreateTime" },
                values: new object[] { "be9f664f-df43-43a4-b2e7-296b7e333597", new DateTime(2024, 8, 16, 12, 50, 21, 409, DateTimeKind.Utc).AddTicks(174), new DateTime(2024, 8, 16, 12, 50, 21, 409, DateTimeKind.Utc).AddTicks(175), new DateTime(2024, 8, 16, 16, 50, 21, 409, DateTimeKind.Local).AddTicks(167) });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: 2024,
                columns: new[] { "ConcurrencyStamp", "CreatedTime", "LastUpdatedTime", "RefreshTokenCreateTime" },
                values: new object[] { "8fb952d8-8fa7-4107-bee4-2522b5b0a8b2", new DateTime(2024, 8, 16, 12, 50, 21, 409, DateTimeKind.Utc).AddTicks(194), new DateTime(2024, 8, 16, 12, 50, 21, 409, DateTimeKind.Utc).AddTicks(194), new DateTime(2024, 8, 16, 16, 50, 21, 409, DateTimeKind.Local).AddTicks(184) });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: 2025,
                columns: new[] { "ConcurrencyStamp", "CreatedTime", "LastUpdatedTime", "RefreshTokenCreateTime" },
                values: new object[] { "e1506f57-e39a-40ec-b3b3-c4f54799a74d", new DateTime(2024, 8, 16, 12, 50, 21, 409, DateTimeKind.Utc).AddTicks(209), new DateTime(2024, 8, 16, 12, 50, 21, 409, DateTimeKind.Utc).AddTicks(378), new DateTime(2024, 8, 16, 16, 50, 21, 409, DateTimeKind.Local).AddTicks(203) });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: 2026,
                columns: new[] { "ConcurrencyStamp", "CreatedTime", "LastUpdatedTime", "RefreshTokenCreateTime" },
                values: new object[] { "64598b14-b539-4b84-ba9d-35b5b52d3896", new DateTime(2024, 8, 16, 12, 50, 21, 409, DateTimeKind.Utc).AddTicks(425), new DateTime(2024, 8, 16, 12, 50, 21, 409, DateTimeKind.Utc).AddTicks(427), new DateTime(2024, 8, 16, 16, 50, 21, 409, DateTimeKind.Local).AddTicks(406) });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: 2027,
                columns: new[] { "ConcurrencyStamp", "CreatedTime", "LastUpdatedTime", "RefreshTokenCreateTime" },
                values: new object[] { "8aac05eb-5c17-47ee-96c9-17f59d698763", new DateTime(2024, 8, 16, 12, 50, 21, 409, DateTimeKind.Utc).AddTicks(473), new DateTime(2024, 8, 16, 12, 50, 21, 409, DateTimeKind.Utc).AddTicks(475), new DateTime(2024, 8, 16, 16, 50, 21, 409, DateTimeKind.Local).AddTicks(455) });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: 2028,
                columns: new[] { "ConcurrencyStamp", "CreatedTime", "LastUpdatedTime", "RefreshTokenCreateTime" },
                values: new object[] { "c85d088f-0571-4a9b-a044-9d19d77a93b4", new DateTime(2024, 8, 16, 12, 50, 21, 409, DateTimeKind.Utc).AddTicks(695), new DateTime(2024, 8, 16, 12, 50, 21, 409, DateTimeKind.Utc).AddTicks(696), new DateTime(2024, 8, 16, 16, 50, 21, 409, DateTimeKind.Local).AddTicks(502) });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: 2029,
                columns: new[] { "ConcurrencyStamp", "CreatedTime", "LastUpdatedTime", "RefreshTokenCreateTime" },
                values: new object[] { "5c6bfe1f-88a1-4a94-a776-69ceea8d845c", new DateTime(2024, 8, 16, 12, 50, 21, 409, DateTimeKind.Utc).AddTicks(711), new DateTime(2024, 8, 16, 12, 50, 21, 409, DateTimeKind.Utc).AddTicks(711), new DateTime(2024, 8, 16, 16, 50, 21, 409, DateTimeKind.Local).AddTicks(704) });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: 2030,
                columns: new[] { "ConcurrencyStamp", "CreatedTime", "LastUpdatedTime", "RefreshTokenCreateTime" },
                values: new object[] { "61859945-26d2-4bf0-91a0-43aeada30c89", new DateTime(2024, 8, 16, 12, 50, 21, 409, DateTimeKind.Utc).AddTicks(1023), new DateTime(2024, 8, 16, 12, 50, 21, 409, DateTimeKind.Utc).AddTicks(1024), new DateTime(2024, 8, 16, 16, 50, 21, 409, DateTimeKind.Local).AddTicks(727) });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: 2031,
                columns: new[] { "ConcurrencyStamp", "CreatedTime", "LastUpdatedTime", "RefreshTokenCreateTime" },
                values: new object[] { "7d107632-d1a5-4adf-9d10-bb0565aa5144", new DateTime(2024, 8, 16, 12, 50, 21, 409, DateTimeKind.Utc).AddTicks(1119), new DateTime(2024, 8, 16, 12, 50, 21, 409, DateTimeKind.Utc).AddTicks(1120), new DateTime(2024, 8, 16, 16, 50, 21, 409, DateTimeKind.Local).AddTicks(1096) });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: 2032,
                columns: new[] { "ConcurrencyStamp", "CreatedTime", "LastUpdatedTime", "RefreshTokenCreateTime" },
                values: new object[] { "0f7ab1de-ac78-4f3d-8ca7-702af3d45c23", new DateTime(2024, 8, 16, 12, 50, 21, 409, DateTimeKind.Utc).AddTicks(1448), new DateTime(2024, 8, 16, 12, 50, 21, 409, DateTimeKind.Utc).AddTicks(1448), new DateTime(2024, 8, 16, 16, 50, 21, 409, DateTimeKind.Local).AddTicks(1436) });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: 2033,
                columns: new[] { "ConcurrencyStamp", "CreatedTime", "LastUpdatedTime", "RefreshTokenCreateTime" },
                values: new object[] { "420461f3-4110-4dbe-a2ef-ff8449235dce", new DateTime(2024, 8, 16, 12, 50, 21, 409, DateTimeKind.Utc).AddTicks(1464), new DateTime(2024, 8, 16, 12, 50, 21, 409, DateTimeKind.Utc).AddTicks(1465), new DateTime(2024, 8, 16, 16, 50, 21, 409, DateTimeKind.Local).AddTicks(1458) });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: 2034,
                columns: new[] { "ConcurrencyStamp", "CreatedTime", "LastUpdatedTime", "RefreshTokenCreateTime" },
                values: new object[] { "14388521-0647-48bb-86a2-aa2c4f715bdb", new DateTime(2024, 8, 16, 12, 50, 21, 409, DateTimeKind.Utc).AddTicks(1483), new DateTime(2024, 8, 16, 12, 50, 21, 409, DateTimeKind.Utc).AddTicks(1483), new DateTime(2024, 8, 16, 16, 50, 21, 409, DateTimeKind.Local).AddTicks(1476) });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: 2035,
                columns: new[] { "ConcurrencyStamp", "CreatedTime", "LastUpdatedTime", "RefreshTokenCreateTime" },
                values: new object[] { "9c5c8fa0-6dd4-496b-9785-b6d0d2a72146", new DateTime(2024, 8, 16, 12, 50, 21, 409, DateTimeKind.Utc).AddTicks(1499), new DateTime(2024, 8, 16, 12, 50, 21, 409, DateTimeKind.Utc).AddTicks(1500), new DateTime(2024, 8, 16, 16, 50, 21, 409, DateTimeKind.Local).AddTicks(1492) });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: 2036,
                columns: new[] { "ConcurrencyStamp", "CreatedTime", "LastUpdatedTime", "RefreshTokenCreateTime" },
                values: new object[] { "9afcfbe8-b52d-49b4-8e62-f1a53f554636", new DateTime(2024, 8, 16, 12, 50, 21, 409, DateTimeKind.Utc).AddTicks(1514), new DateTime(2024, 8, 16, 12, 50, 21, 409, DateTimeKind.Utc).AddTicks(1515), new DateTime(2024, 8, 16, 16, 50, 21, 409, DateTimeKind.Local).AddTicks(1508) });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: 2037,
                columns: new[] { "ConcurrencyStamp", "CreatedTime", "LastUpdatedTime", "RefreshTokenCreateTime" },
                values: new object[] { "442c338a-cf5f-4463-8238-5353fd5b85b2", new DateTime(2024, 8, 16, 12, 50, 21, 409, DateTimeKind.Utc).AddTicks(1531), new DateTime(2024, 8, 16, 12, 50, 21, 409, DateTimeKind.Utc).AddTicks(1532), new DateTime(2024, 8, 16, 16, 50, 21, 409, DateTimeKind.Local).AddTicks(1525) });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: 2038,
                columns: new[] { "ConcurrencyStamp", "CreatedTime", "LastUpdatedTime", "RefreshTokenCreateTime" },
                values: new object[] { "c3213358-af71-4206-9e59-b95d9779b54d", new DateTime(2024, 8, 16, 12, 50, 21, 409, DateTimeKind.Utc).AddTicks(1548), new DateTime(2024, 8, 16, 12, 50, 21, 409, DateTimeKind.Utc).AddTicks(1548), new DateTime(2024, 8, 16, 16, 50, 21, 409, DateTimeKind.Local).AddTicks(1540) });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: 2039,
                columns: new[] { "ConcurrencyStamp", "CreatedTime", "LastUpdatedTime", "RefreshTokenCreateTime" },
                values: new object[] { "80974931-f34f-45eb-9b1e-50d6703c005d", new DateTime(2024, 8, 16, 12, 50, 21, 409, DateTimeKind.Utc).AddTicks(1565), new DateTime(2024, 8, 16, 12, 50, 21, 409, DateTimeKind.Utc).AddTicks(1566), new DateTime(2024, 8, 16, 16, 50, 21, 409, DateTimeKind.Local).AddTicks(1559) });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: 2040,
                columns: new[] { "ConcurrencyStamp", "CreatedTime", "LastUpdatedTime", "RefreshTokenCreateTime" },
                values: new object[] { "9f64da18-0200-4301-ab31-e429977941ac", new DateTime(2024, 8, 16, 12, 50, 21, 409, DateTimeKind.Utc).AddTicks(1613), new DateTime(2024, 8, 16, 12, 50, 21, 409, DateTimeKind.Utc).AddTicks(1613), new DateTime(2024, 8, 16, 16, 50, 21, 409, DateTimeKind.Local).AddTicks(1602) });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: 2041,
                columns: new[] { "ConcurrencyStamp", "CreatedTime", "LastUpdatedTime", "RefreshTokenCreateTime" },
                values: new object[] { "a35a9e8b-2e6c-4e6a-84be-942d71243078", new DateTime(2024, 8, 16, 12, 50, 21, 409, DateTimeKind.Utc).AddTicks(1629), new DateTime(2024, 8, 16, 12, 50, 21, 409, DateTimeKind.Utc).AddTicks(1630), new DateTime(2024, 8, 16, 16, 50, 21, 409, DateTimeKind.Local).AddTicks(1623) });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: 2042,
                columns: new[] { "ConcurrencyStamp", "CreatedTime", "LastUpdatedTime", "RefreshTokenCreateTime" },
                values: new object[] { "d53e2c83-0955-42c5-a905-4e83d85b50de", new DateTime(2024, 8, 16, 12, 50, 21, 409, DateTimeKind.Utc).AddTicks(1652), new DateTime(2024, 8, 16, 12, 50, 21, 409, DateTimeKind.Utc).AddTicks(1652), new DateTime(2024, 8, 16, 16, 50, 21, 409, DateTimeKind.Local).AddTicks(1645) });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: 2043,
                columns: new[] { "ConcurrencyStamp", "CreatedTime", "LastUpdatedTime", "RefreshTokenCreateTime" },
                values: new object[] { "d367aeb8-5e0e-481d-9ef0-41d6d0c62a2a", new DateTime(2024, 8, 16, 12, 50, 21, 409, DateTimeKind.Utc).AddTicks(1669), new DateTime(2024, 8, 16, 12, 50, 21, 409, DateTimeKind.Utc).AddTicks(1669), new DateTime(2024, 8, 16, 16, 50, 21, 409, DateTimeKind.Local).AddTicks(1662) });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: 2044,
                columns: new[] { "ConcurrencyStamp", "CreatedTime", "LastUpdatedTime", "RefreshTokenCreateTime" },
                values: new object[] { "c78f9c0b-4da3-49e8-9783-1b226a40b737", new DateTime(2024, 8, 16, 12, 50, 21, 409, DateTimeKind.Utc).AddTicks(1684), new DateTime(2024, 8, 16, 12, 50, 21, 409, DateTimeKind.Utc).AddTicks(1685), new DateTime(2024, 8, 16, 16, 50, 21, 409, DateTimeKind.Local).AddTicks(1679) });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: 2045,
                columns: new[] { "ConcurrencyStamp", "CreatedTime", "LastUpdatedTime", "RefreshTokenCreateTime" },
                values: new object[] { "d0016d12-8dfe-4992-acd7-817737faa8ed", new DateTime(2024, 8, 16, 12, 50, 21, 409, DateTimeKind.Utc).AddTicks(1700), new DateTime(2024, 8, 16, 12, 50, 21, 409, DateTimeKind.Utc).AddTicks(1701), new DateTime(2024, 8, 16, 16, 50, 21, 409, DateTimeKind.Local).AddTicks(1694) });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: 2046,
                columns: new[] { "ConcurrencyStamp", "CreatedTime", "LastUpdatedTime", "RefreshTokenCreateTime" },
                values: new object[] { "ea19b559-58a7-4a38-81ef-7a0f63fb6f93", new DateTime(2024, 8, 16, 12, 50, 21, 409, DateTimeKind.Utc).AddTicks(1716), new DateTime(2024, 8, 16, 12, 50, 21, 409, DateTimeKind.Utc).AddTicks(1716), new DateTime(2024, 8, 16, 16, 50, 21, 409, DateTimeKind.Local).AddTicks(1710) });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: 2047,
                columns: new[] { "ConcurrencyStamp", "CreatedTime", "LastUpdatedTime", "RefreshTokenCreateTime" },
                values: new object[] { "9615eea5-f6fb-427f-8ca1-3eb74a0c0a0d", new DateTime(2024, 8, 16, 12, 50, 21, 409, DateTimeKind.Utc).AddTicks(3103), new DateTime(2024, 8, 16, 12, 50, 21, 409, DateTimeKind.Utc).AddTicks(3103), new DateTime(2024, 8, 16, 16, 50, 21, 409, DateTimeKind.Local).AddTicks(3083) });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: 2048,
                columns: new[] { "ConcurrencyStamp", "CreatedTime", "LastUpdatedTime", "RefreshTokenCreateTime" },
                values: new object[] { "ac01fdf8-17f3-436f-8643-3b8ed0dc243a", new DateTime(2024, 8, 16, 12, 50, 21, 409, DateTimeKind.Utc).AddTicks(3126), new DateTime(2024, 8, 16, 12, 50, 21, 409, DateTimeKind.Utc).AddTicks(3126), new DateTime(2024, 8, 16, 16, 50, 21, 409, DateTimeKind.Local).AddTicks(3115) });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: 2049,
                columns: new[] { "ConcurrencyStamp", "CreatedTime", "LastUpdatedTime", "RefreshTokenCreateTime" },
                values: new object[] { "2012b954-f432-47d6-ac28-9b9d9a3ee0a7", new DateTime(2024, 8, 16, 12, 50, 21, 409, DateTimeKind.Utc).AddTicks(4376), new DateTime(2024, 8, 16, 12, 50, 21, 409, DateTimeKind.Utc).AddTicks(4377), new DateTime(2024, 8, 16, 16, 50, 21, 409, DateTimeKind.Local).AddTicks(4320) });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: 2050,
                columns: new[] { "ConcurrencyStamp", "CreatedTime", "LastUpdatedTime", "RefreshTokenCreateTime" },
                values: new object[] { "7fa3a044-572d-4b3b-a24c-19a3bff5f8a0", new DateTime(2024, 8, 16, 12, 50, 21, 409, DateTimeKind.Utc).AddTicks(4403), new DateTime(2024, 8, 16, 12, 50, 21, 409, DateTimeKind.Utc).AddTicks(4404), new DateTime(2024, 8, 16, 16, 50, 21, 409, DateTimeKind.Local).AddTicks(4395) });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: 2051,
                columns: new[] { "ConcurrencyStamp", "CreatedTime", "LastUpdatedTime", "RefreshTokenCreateTime" },
                values: new object[] { "b76b55b9-c126-48b5-a108-df4933dad82d", new DateTime(2024, 8, 16, 12, 50, 21, 409, DateTimeKind.Utc).AddTicks(4421), new DateTime(2024, 8, 16, 12, 50, 21, 409, DateTimeKind.Utc).AddTicks(4421), new DateTime(2024, 8, 16, 16, 50, 21, 409, DateTimeKind.Local).AddTicks(4414) });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: 2052,
                columns: new[] { "ConcurrencyStamp", "CreatedTime", "LastUpdatedTime", "RefreshTokenCreateTime" },
                values: new object[] { "b7473d7a-06c7-4d4b-a627-02ad9706f296", new DateTime(2024, 8, 16, 12, 50, 21, 409, DateTimeKind.Utc).AddTicks(4437), new DateTime(2024, 8, 16, 12, 50, 21, 409, DateTimeKind.Utc).AddTicks(4438), new DateTime(2024, 8, 16, 16, 50, 21, 409, DateTimeKind.Local).AddTicks(4431) });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: 2053,
                columns: new[] { "ConcurrencyStamp", "CreatedTime", "LastUpdatedTime", "RefreshTokenCreateTime" },
                values: new object[] { "3f2d6bf6-c997-4756-ad1d-6c194de8ca9a", new DateTime(2024, 8, 16, 12, 50, 21, 409, DateTimeKind.Utc).AddTicks(4453), new DateTime(2024, 8, 16, 12, 50, 21, 409, DateTimeKind.Utc).AddTicks(4453), new DateTime(2024, 8, 16, 16, 50, 21, 409, DateTimeKind.Local).AddTicks(4446) });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: 2054,
                columns: new[] { "ConcurrencyStamp", "CreatedTime", "LastUpdatedTime", "RefreshTokenCreateTime" },
                values: new object[] { "b7f57c70-3369-4c34-bb84-a727781989c0", new DateTime(2024, 8, 16, 12, 50, 21, 409, DateTimeKind.Utc).AddTicks(4479), new DateTime(2024, 8, 16, 12, 50, 21, 409, DateTimeKind.Utc).AddTicks(4479), new DateTime(2024, 8, 16, 16, 50, 21, 409, DateTimeKind.Local).AddTicks(4462) });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: 2055,
                columns: new[] { "ConcurrencyStamp", "CreatedTime", "LastUpdatedTime", "RefreshTokenCreateTime" },
                values: new object[] { "8cbc305c-1f45-42b3-bfa1-8799754f4173", new DateTime(2024, 8, 16, 12, 50, 21, 409, DateTimeKind.Utc).AddTicks(4495), new DateTime(2024, 8, 16, 12, 50, 21, 409, DateTimeKind.Utc).AddTicks(4495), new DateTime(2024, 8, 16, 16, 50, 21, 409, DateTimeKind.Local).AddTicks(4488) });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: 2056,
                columns: new[] { "ConcurrencyStamp", "CreatedTime", "LastUpdatedTime", "RefreshTokenCreateTime" },
                values: new object[] { "1f63e406-46b3-475c-ae0b-4533edf65f77", new DateTime(2024, 8, 16, 12, 50, 21, 409, DateTimeKind.Utc).AddTicks(4510), new DateTime(2024, 8, 16, 12, 50, 21, 409, DateTimeKind.Utc).AddTicks(4510), new DateTime(2024, 8, 16, 16, 50, 21, 409, DateTimeKind.Local).AddTicks(4504) });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: 2057,
                columns: new[] { "ConcurrencyStamp", "CreatedTime", "LastUpdatedTime", "RefreshTokenCreateTime" },
                values: new object[] { "f0a04977-a792-4cb9-a36f-353f59d45c7c", new DateTime(2024, 8, 16, 12, 50, 21, 409, DateTimeKind.Utc).AddTicks(4525), new DateTime(2024, 8, 16, 12, 50, 21, 409, DateTimeKind.Utc).AddTicks(4526), new DateTime(2024, 8, 16, 16, 50, 21, 409, DateTimeKind.Local).AddTicks(4520) });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: 2058,
                columns: new[] { "ConcurrencyStamp", "CreatedTime", "LastUpdatedTime", "RefreshTokenCreateTime" },
                values: new object[] { "0ae382ca-0d62-47b6-8ddb-4c010fc2d932", new DateTime(2024, 8, 16, 12, 50, 21, 409, DateTimeKind.Utc).AddTicks(4601), new DateTime(2024, 8, 16, 12, 50, 21, 409, DateTimeKind.Utc).AddTicks(4601), new DateTime(2024, 8, 16, 16, 50, 21, 409, DateTimeKind.Local).AddTicks(4593) });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: 2059,
                columns: new[] { "ConcurrencyStamp", "CreatedTime", "LastUpdatedTime", "RefreshTokenCreateTime" },
                values: new object[] { "908fd4ca-d39b-49d1-aa30-752842f85393", new DateTime(2024, 8, 16, 12, 50, 21, 409, DateTimeKind.Utc).AddTicks(4617), new DateTime(2024, 8, 16, 12, 50, 21, 409, DateTimeKind.Utc).AddTicks(4617), new DateTime(2024, 8, 16, 16, 50, 21, 409, DateTimeKind.Local).AddTicks(4611) });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: 2060,
                columns: new[] { "ConcurrencyStamp", "CreatedTime", "LastUpdatedTime", "RefreshTokenCreateTime" },
                values: new object[] { "764d5973-62d3-4ce1-a516-f0455a6b60dc", new DateTime(2024, 8, 16, 12, 50, 21, 409, DateTimeKind.Utc).AddTicks(4633), new DateTime(2024, 8, 16, 12, 50, 21, 409, DateTimeKind.Utc).AddTicks(4634), new DateTime(2024, 8, 16, 16, 50, 21, 409, DateTimeKind.Local).AddTicks(4626) });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AlterColumn<string>(
                name: "City",
                table: "AspNetUsers",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "",
                oldClrType: typeof(string),
                oldType: "nvarchar(max)",
                oldNullable: true);

            migrationBuilder.AlterColumn<string>(
                name: "Address",
                table: "AspNetUsers",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "",
                oldClrType: typeof(string),
                oldType: "nvarchar(max)",
                oldNullable: true);

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: 2001,
                columns: new[] { "ConcurrencyStamp", "CreatedTime", "LastUpdatedTime", "RefreshTokenCreateTime" },
                values: new object[] { "fc0658b3-a738-41c0-86fe-fb0233350887", new DateTime(2024, 8, 15, 12, 14, 26, 880, DateTimeKind.Utc).AddTicks(9673), new DateTime(2024, 8, 15, 12, 14, 26, 880, DateTimeKind.Utc).AddTicks(9675), new DateTime(2024, 8, 15, 16, 14, 26, 880, DateTimeKind.Local).AddTicks(9564) });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: 2002,
                columns: new[] { "ConcurrencyStamp", "CreatedTime", "LastUpdatedTime", "RefreshTokenCreateTime" },
                values: new object[] { "33066809-4d02-47a0-8331-eea31c3db5ec", new DateTime(2024, 8, 15, 12, 14, 26, 880, DateTimeKind.Utc).AddTicks(9710), new DateTime(2024, 8, 15, 12, 14, 26, 880, DateTimeKind.Utc).AddTicks(9710), new DateTime(2024, 8, 15, 16, 14, 26, 880, DateTimeKind.Local).AddTicks(9702) });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: 2003,
                columns: new[] { "ConcurrencyStamp", "CreatedTime", "LastUpdatedTime", "RefreshTokenCreateTime" },
                values: new object[] { "2ce42d99-0502-4a96-a321-66889ad27ab5", new DateTime(2024, 8, 15, 12, 14, 26, 880, DateTimeKind.Utc).AddTicks(9725), new DateTime(2024, 8, 15, 12, 14, 26, 880, DateTimeKind.Utc).AddTicks(9726), new DateTime(2024, 8, 15, 16, 14, 26, 880, DateTimeKind.Local).AddTicks(9720) });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: 2004,
                columns: new[] { "ConcurrencyStamp", "CreatedTime", "LastUpdatedTime", "RefreshTokenCreateTime" },
                values: new object[] { "2fc506d7-98b9-47ad-8cdd-9a4daadd7699", new DateTime(2024, 8, 15, 12, 14, 26, 880, DateTimeKind.Utc).AddTicks(9754), new DateTime(2024, 8, 15, 12, 14, 26, 880, DateTimeKind.Utc).AddTicks(9754), new DateTime(2024, 8, 15, 16, 14, 26, 880, DateTimeKind.Local).AddTicks(9735) });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: 2005,
                columns: new[] { "ConcurrencyStamp", "CreatedTime", "LastUpdatedTime", "RefreshTokenCreateTime" },
                values: new object[] { "d40d0954-5fdc-4390-8415-53288fb16ae7", new DateTime(2024, 8, 15, 12, 14, 26, 880, DateTimeKind.Utc).AddTicks(9768), new DateTime(2024, 8, 15, 12, 14, 26, 880, DateTimeKind.Utc).AddTicks(9768), new DateTime(2024, 8, 15, 16, 14, 26, 880, DateTimeKind.Local).AddTicks(9762) });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: 2006,
                columns: new[] { "ConcurrencyStamp", "CreatedTime", "LastUpdatedTime", "RefreshTokenCreateTime" },
                values: new object[] { "b89cf968-98d3-4887-8fca-bebcdc6c1cff", new DateTime(2024, 8, 15, 12, 14, 26, 880, DateTimeKind.Utc).AddTicks(9784), new DateTime(2024, 8, 15, 12, 14, 26, 880, DateTimeKind.Utc).AddTicks(9785), new DateTime(2024, 8, 15, 16, 14, 26, 880, DateTimeKind.Local).AddTicks(9779) });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: 2007,
                columns: new[] { "ConcurrencyStamp", "CreatedTime", "LastUpdatedTime", "RefreshTokenCreateTime" },
                values: new object[] { "8a472d3f-c167-40e2-aa2c-7e62f8f4786e", new DateTime(2024, 8, 15, 12, 14, 26, 880, DateTimeKind.Utc).AddTicks(9798), new DateTime(2024, 8, 15, 12, 14, 26, 880, DateTimeKind.Utc).AddTicks(9798), new DateTime(2024, 8, 15, 16, 14, 26, 880, DateTimeKind.Local).AddTicks(9793) });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: 2008,
                columns: new[] { "ConcurrencyStamp", "CreatedTime", "LastUpdatedTime", "RefreshTokenCreateTime" },
                values: new object[] { "fe2979a9-a436-44eb-9901-b35085bef7a9", new DateTime(2024, 8, 15, 12, 14, 26, 880, DateTimeKind.Utc).AddTicks(9812), new DateTime(2024, 8, 15, 12, 14, 26, 880, DateTimeKind.Utc).AddTicks(9812), new DateTime(2024, 8, 15, 16, 14, 26, 880, DateTimeKind.Local).AddTicks(9806) });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: 2009,
                columns: new[] { "ConcurrencyStamp", "CreatedTime", "LastUpdatedTime", "RefreshTokenCreateTime" },
                values: new object[] { "a1262f32-c15c-4ecf-8dfc-b9842fbdf2da", new DateTime(2024, 8, 15, 12, 14, 26, 880, DateTimeKind.Utc).AddTicks(9824), new DateTime(2024, 8, 15, 12, 14, 26, 880, DateTimeKind.Utc).AddTicks(9825), new DateTime(2024, 8, 15, 16, 14, 26, 880, DateTimeKind.Local).AddTicks(9819) });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: 2010,
                columns: new[] { "ConcurrencyStamp", "CreatedTime", "LastUpdatedTime", "RefreshTokenCreateTime" },
                values: new object[] { "747dde12-d6c0-461c-ac58-13723dcb7469", new DateTime(2024, 8, 15, 12, 14, 26, 880, DateTimeKind.Utc).AddTicks(9900), new DateTime(2024, 8, 15, 12, 14, 26, 880, DateTimeKind.Utc).AddTicks(9900), new DateTime(2024, 8, 15, 16, 14, 26, 880, DateTimeKind.Local).AddTicks(9892) });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: 2011,
                columns: new[] { "ConcurrencyStamp", "CreatedTime", "LastUpdatedTime", "RefreshTokenCreateTime" },
                values: new object[] { "ba1dcabe-664b-43a4-80b5-a26bb983466a", new DateTime(2024, 8, 15, 12, 14, 26, 880, DateTimeKind.Utc).AddTicks(9914), new DateTime(2024, 8, 15, 12, 14, 26, 880, DateTimeKind.Utc).AddTicks(9915), new DateTime(2024, 8, 15, 16, 14, 26, 880, DateTimeKind.Local).AddTicks(9909) });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: 2012,
                columns: new[] { "ConcurrencyStamp", "CreatedTime", "LastUpdatedTime", "RefreshTokenCreateTime" },
                values: new object[] { "6db7fea4-baf1-4d5d-b001-15d88740206f", new DateTime(2024, 8, 15, 12, 14, 26, 880, DateTimeKind.Utc).AddTicks(9932), new DateTime(2024, 8, 15, 12, 14, 26, 880, DateTimeKind.Utc).AddTicks(9932), new DateTime(2024, 8, 15, 16, 14, 26, 880, DateTimeKind.Local).AddTicks(9923) });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: 2013,
                columns: new[] { "ConcurrencyStamp", "CreatedTime", "LastUpdatedTime", "RefreshTokenCreateTime" },
                values: new object[] { "2a2e0cb3-0d5d-4ef9-a1a5-ad9ee1e97a12", new DateTime(2024, 8, 15, 12, 14, 26, 880, DateTimeKind.Utc).AddTicks(9946), new DateTime(2024, 8, 15, 12, 14, 26, 880, DateTimeKind.Utc).AddTicks(9946), new DateTime(2024, 8, 15, 16, 14, 26, 880, DateTimeKind.Local).AddTicks(9941) });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: 2014,
                columns: new[] { "ConcurrencyStamp", "CreatedTime", "LastUpdatedTime", "RefreshTokenCreateTime" },
                values: new object[] { "f622037f-6d81-4573-bac1-8d84581fc556", new DateTime(2024, 8, 15, 12, 14, 26, 880, DateTimeKind.Utc).AddTicks(9960), new DateTime(2024, 8, 15, 12, 14, 26, 880, DateTimeKind.Utc).AddTicks(9961), new DateTime(2024, 8, 15, 16, 14, 26, 880, DateTimeKind.Local).AddTicks(9955) });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: 2015,
                columns: new[] { "ConcurrencyStamp", "CreatedTime", "LastUpdatedTime", "RefreshTokenCreateTime" },
                values: new object[] { "d4b88bcc-567c-4f71-8074-a9aff4440ad1", new DateTime(2024, 8, 15, 12, 14, 26, 880, DateTimeKind.Utc).AddTicks(9973), new DateTime(2024, 8, 15, 12, 14, 26, 880, DateTimeKind.Utc).AddTicks(9974), new DateTime(2024, 8, 15, 16, 14, 26, 880, DateTimeKind.Local).AddTicks(9968) });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: 2016,
                columns: new[] { "ConcurrencyStamp", "CreatedTime", "LastUpdatedTime", "RefreshTokenCreateTime" },
                values: new object[] { "7387df0b-0197-42cb-b01a-42256841aaf5", new DateTime(2024, 8, 15, 12, 14, 26, 880, DateTimeKind.Utc).AddTicks(9987), new DateTime(2024, 8, 15, 12, 14, 26, 880, DateTimeKind.Utc).AddTicks(9987), new DateTime(2024, 8, 15, 16, 14, 26, 880, DateTimeKind.Local).AddTicks(9982) });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: 2017,
                columns: new[] { "ConcurrencyStamp", "CreatedTime", "LastUpdatedTime", "RefreshTokenCreateTime" },
                values: new object[] { "8dbf0aad-6f52-4d2e-80bc-9b27420e948a", new DateTime(2024, 8, 15, 12, 14, 26, 881, DateTimeKind.Utc).AddTicks(2), new DateTime(2024, 8, 15, 12, 14, 26, 881, DateTimeKind.Utc).AddTicks(2), new DateTime(2024, 8, 15, 16, 14, 26, 880, DateTimeKind.Local).AddTicks(9997) });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: 2018,
                columns: new[] { "ConcurrencyStamp", "CreatedTime", "LastUpdatedTime", "RefreshTokenCreateTime" },
                values: new object[] { "3f1eb10e-6840-498b-aed7-3aa9f2e38801", new DateTime(2024, 8, 15, 12, 14, 26, 881, DateTimeKind.Utc).AddTicks(18), new DateTime(2024, 8, 15, 12, 14, 26, 881, DateTimeKind.Utc).AddTicks(18), new DateTime(2024, 8, 15, 16, 14, 26, 881, DateTimeKind.Local).AddTicks(12) });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: 2019,
                columns: new[] { "ConcurrencyStamp", "CreatedTime", "LastUpdatedTime", "RefreshTokenCreateTime" },
                values: new object[] { "3761e656-f390-4ae3-8969-a04f20a55905", new DateTime(2024, 8, 15, 12, 14, 26, 881, DateTimeKind.Utc).AddTicks(68), new DateTime(2024, 8, 15, 12, 14, 26, 881, DateTimeKind.Utc).AddTicks(69), new DateTime(2024, 8, 15, 16, 14, 26, 881, DateTimeKind.Local).AddTicks(63) });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: 2020,
                columns: new[] { "ConcurrencyStamp", "CreatedTime", "LastUpdatedTime", "RefreshTokenCreateTime" },
                values: new object[] { "0d76ff03-e08e-4e3d-9001-e5bad5c6a078", new DateTime(2024, 8, 15, 12, 14, 26, 881, DateTimeKind.Utc).AddTicks(86), new DateTime(2024, 8, 15, 12, 14, 26, 881, DateTimeKind.Utc).AddTicks(86), new DateTime(2024, 8, 15, 16, 14, 26, 881, DateTimeKind.Local).AddTicks(77) });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: 2021,
                columns: new[] { "ConcurrencyStamp", "CreatedTime", "LastUpdatedTime", "RefreshTokenCreateTime" },
                values: new object[] { "bfd0baab-2d10-48b9-821d-7e2b9f9ba78b", new DateTime(2024, 8, 15, 12, 14, 26, 881, DateTimeKind.Utc).AddTicks(100), new DateTime(2024, 8, 15, 12, 14, 26, 881, DateTimeKind.Utc).AddTicks(100), new DateTime(2024, 8, 15, 16, 14, 26, 881, DateTimeKind.Local).AddTicks(95) });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: 2022,
                columns: new[] { "ConcurrencyStamp", "CreatedTime", "LastUpdatedTime", "RefreshTokenCreateTime" },
                values: new object[] { "3fe909b0-eee3-4fed-93d2-6ad65f9349a8", new DateTime(2024, 8, 15, 12, 14, 26, 881, DateTimeKind.Utc).AddTicks(118), new DateTime(2024, 8, 15, 12, 14, 26, 881, DateTimeKind.Utc).AddTicks(118), new DateTime(2024, 8, 15, 16, 14, 26, 881, DateTimeKind.Local).AddTicks(113) });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: 2023,
                columns: new[] { "ConcurrencyStamp", "CreatedTime", "LastUpdatedTime", "RefreshTokenCreateTime" },
                values: new object[] { "2d1a2dcd-b88e-4bd8-8297-e51b2af49aca", new DateTime(2024, 8, 15, 12, 14, 26, 881, DateTimeKind.Utc).AddTicks(132), new DateTime(2024, 8, 15, 12, 14, 26, 881, DateTimeKind.Utc).AddTicks(132), new DateTime(2024, 8, 15, 16, 14, 26, 881, DateTimeKind.Local).AddTicks(127) });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: 2024,
                columns: new[] { "ConcurrencyStamp", "CreatedTime", "LastUpdatedTime", "RefreshTokenCreateTime" },
                values: new object[] { "60681c86-d0d9-4455-8666-c6bfa579b0d4", new DateTime(2024, 8, 15, 12, 14, 26, 881, DateTimeKind.Utc).AddTicks(146), new DateTime(2024, 8, 15, 12, 14, 26, 881, DateTimeKind.Utc).AddTicks(146), new DateTime(2024, 8, 15, 16, 14, 26, 881, DateTimeKind.Local).AddTicks(141) });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: 2025,
                columns: new[] { "ConcurrencyStamp", "CreatedTime", "LastUpdatedTime", "RefreshTokenCreateTime" },
                values: new object[] { "05d157cf-2b03-4d9d-96e7-3c06db4608a1", new DateTime(2024, 8, 15, 12, 14, 26, 881, DateTimeKind.Utc).AddTicks(160), new DateTime(2024, 8, 15, 12, 14, 26, 881, DateTimeKind.Utc).AddTicks(160), new DateTime(2024, 8, 15, 16, 14, 26, 881, DateTimeKind.Local).AddTicks(154) });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: 2026,
                columns: new[] { "ConcurrencyStamp", "CreatedTime", "LastUpdatedTime", "RefreshTokenCreateTime" },
                values: new object[] { "5a750761-9c03-434d-b471-5c8612dad2b0", new DateTime(2024, 8, 15, 12, 14, 26, 881, DateTimeKind.Utc).AddTicks(173), new DateTime(2024, 8, 15, 12, 14, 26, 881, DateTimeKind.Utc).AddTicks(173), new DateTime(2024, 8, 15, 16, 14, 26, 881, DateTimeKind.Local).AddTicks(168) });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: 2027,
                columns: new[] { "ConcurrencyStamp", "CreatedTime", "LastUpdatedTime", "RefreshTokenCreateTime" },
                values: new object[] { "9ed37c27-c214-4271-ae31-da43ce5871c0", new DateTime(2024, 8, 15, 12, 14, 26, 881, DateTimeKind.Utc).AddTicks(222), new DateTime(2024, 8, 15, 12, 14, 26, 881, DateTimeKind.Utc).AddTicks(222), new DateTime(2024, 8, 15, 16, 14, 26, 881, DateTimeKind.Local).AddTicks(182) });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: 2028,
                columns: new[] { "ConcurrencyStamp", "CreatedTime", "LastUpdatedTime", "RefreshTokenCreateTime" },
                values: new object[] { "864c86b1-5e03-407d-b5a8-a6241baf7eef", new DateTime(2024, 8, 15, 12, 14, 26, 881, DateTimeKind.Utc).AddTicks(239), new DateTime(2024, 8, 15, 12, 14, 26, 881, DateTimeKind.Utc).AddTicks(239), new DateTime(2024, 8, 15, 16, 14, 26, 881, DateTimeKind.Local).AddTicks(230) });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: 2029,
                columns: new[] { "ConcurrencyStamp", "CreatedTime", "LastUpdatedTime", "RefreshTokenCreateTime" },
                values: new object[] { "9c9d8821-7021-45d7-81f6-e2614101f5b5", new DateTime(2024, 8, 15, 12, 14, 26, 881, DateTimeKind.Utc).AddTicks(253), new DateTime(2024, 8, 15, 12, 14, 26, 881, DateTimeKind.Utc).AddTicks(254), new DateTime(2024, 8, 15, 16, 14, 26, 881, DateTimeKind.Local).AddTicks(248) });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: 2030,
                columns: new[] { "ConcurrencyStamp", "CreatedTime", "LastUpdatedTime", "RefreshTokenCreateTime" },
                values: new object[] { "6aeecfc8-0745-46b7-bd3d-5a3784a3b977", new DateTime(2024, 8, 15, 12, 14, 26, 881, DateTimeKind.Utc).AddTicks(267), new DateTime(2024, 8, 15, 12, 14, 26, 881, DateTimeKind.Utc).AddTicks(268), new DateTime(2024, 8, 15, 16, 14, 26, 881, DateTimeKind.Local).AddTicks(262) });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: 2031,
                columns: new[] { "ConcurrencyStamp", "CreatedTime", "LastUpdatedTime", "RefreshTokenCreateTime" },
                values: new object[] { "68b76f85-f97c-48db-a422-e62d278cb86f", new DateTime(2024, 8, 15, 12, 14, 26, 881, DateTimeKind.Utc).AddTicks(281), new DateTime(2024, 8, 15, 12, 14, 26, 881, DateTimeKind.Utc).AddTicks(281), new DateTime(2024, 8, 15, 16, 14, 26, 881, DateTimeKind.Local).AddTicks(276) });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: 2032,
                columns: new[] { "ConcurrencyStamp", "CreatedTime", "LastUpdatedTime", "RefreshTokenCreateTime" },
                values: new object[] { "63ac1d19-87cd-41ac-bde2-dba92ef85bcd", new DateTime(2024, 8, 15, 12, 14, 26, 881, DateTimeKind.Utc).AddTicks(295), new DateTime(2024, 8, 15, 12, 14, 26, 881, DateTimeKind.Utc).AddTicks(295), new DateTime(2024, 8, 15, 16, 14, 26, 881, DateTimeKind.Local).AddTicks(289) });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: 2033,
                columns: new[] { "ConcurrencyStamp", "CreatedTime", "LastUpdatedTime", "RefreshTokenCreateTime" },
                values: new object[] { "71b980ab-8e21-47fc-a7af-9cb0c9fbfb58", new DateTime(2024, 8, 15, 12, 14, 26, 881, DateTimeKind.Utc).AddTicks(309), new DateTime(2024, 8, 15, 12, 14, 26, 881, DateTimeKind.Utc).AddTicks(309), new DateTime(2024, 8, 15, 16, 14, 26, 881, DateTimeKind.Local).AddTicks(303) });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: 2034,
                columns: new[] { "ConcurrencyStamp", "CreatedTime", "LastUpdatedTime", "RefreshTokenCreateTime" },
                values: new object[] { "5adff99e-12b0-4ff2-86a8-b2e3366dab8d", new DateTime(2024, 8, 15, 12, 14, 26, 881, DateTimeKind.Utc).AddTicks(324), new DateTime(2024, 8, 15, 12, 14, 26, 881, DateTimeKind.Utc).AddTicks(325), new DateTime(2024, 8, 15, 16, 14, 26, 881, DateTimeKind.Local).AddTicks(319) });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: 2035,
                columns: new[] { "ConcurrencyStamp", "CreatedTime", "LastUpdatedTime", "RefreshTokenCreateTime" },
                values: new object[] { "a698063e-0e63-40bd-9a02-ec52f02465a9", new DateTime(2024, 8, 15, 12, 14, 26, 881, DateTimeKind.Utc).AddTicks(338), new DateTime(2024, 8, 15, 12, 14, 26, 881, DateTimeKind.Utc).AddTicks(339), new DateTime(2024, 8, 15, 16, 14, 26, 881, DateTimeKind.Local).AddTicks(333) });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: 2036,
                columns: new[] { "ConcurrencyStamp", "CreatedTime", "LastUpdatedTime", "RefreshTokenCreateTime" },
                values: new object[] { "69d93d1b-daf8-4ed0-92a9-8677962323d0", new DateTime(2024, 8, 15, 12, 14, 26, 881, DateTimeKind.Utc).AddTicks(390), new DateTime(2024, 8, 15, 12, 14, 26, 881, DateTimeKind.Utc).AddTicks(390), new DateTime(2024, 8, 15, 16, 14, 26, 881, DateTimeKind.Local).AddTicks(381) });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: 2037,
                columns: new[] { "ConcurrencyStamp", "CreatedTime", "LastUpdatedTime", "RefreshTokenCreateTime" },
                values: new object[] { "98088795-f1cb-4e04-a06d-449016739262", new DateTime(2024, 8, 15, 12, 14, 26, 881, DateTimeKind.Utc).AddTicks(404), new DateTime(2024, 8, 15, 12, 14, 26, 881, DateTimeKind.Utc).AddTicks(405), new DateTime(2024, 8, 15, 16, 14, 26, 881, DateTimeKind.Local).AddTicks(399) });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: 2038,
                columns: new[] { "ConcurrencyStamp", "CreatedTime", "LastUpdatedTime", "RefreshTokenCreateTime" },
                values: new object[] { "272027db-5bf7-4d10-acc0-1e8576fb5ece", new DateTime(2024, 8, 15, 12, 14, 26, 881, DateTimeKind.Utc).AddTicks(417), new DateTime(2024, 8, 15, 12, 14, 26, 881, DateTimeKind.Utc).AddTicks(418), new DateTime(2024, 8, 15, 16, 14, 26, 881, DateTimeKind.Local).AddTicks(412) });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: 2039,
                columns: new[] { "ConcurrencyStamp", "CreatedTime", "LastUpdatedTime", "RefreshTokenCreateTime" },
                values: new object[] { "6415968b-7d07-478f-b62a-00d8e389a675", new DateTime(2024, 8, 15, 12, 14, 26, 881, DateTimeKind.Utc).AddTicks(431), new DateTime(2024, 8, 15, 12, 14, 26, 881, DateTimeKind.Utc).AddTicks(432), new DateTime(2024, 8, 15, 16, 14, 26, 881, DateTimeKind.Local).AddTicks(426) });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: 2040,
                columns: new[] { "ConcurrencyStamp", "CreatedTime", "LastUpdatedTime", "RefreshTokenCreateTime" },
                values: new object[] { "d6cf4709-80e7-460a-af2b-34be316b9d8a", new DateTime(2024, 8, 15, 12, 14, 26, 881, DateTimeKind.Utc).AddTicks(444), new DateTime(2024, 8, 15, 12, 14, 26, 881, DateTimeKind.Utc).AddTicks(445), new DateTime(2024, 8, 15, 16, 14, 26, 881, DateTimeKind.Local).AddTicks(439) });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: 2041,
                columns: new[] { "ConcurrencyStamp", "CreatedTime", "LastUpdatedTime", "RefreshTokenCreateTime" },
                values: new object[] { "1dcea00b-0155-40eb-80c8-91f3e8f251a4", new DateTime(2024, 8, 15, 12, 14, 26, 881, DateTimeKind.Utc).AddTicks(457), new DateTime(2024, 8, 15, 12, 14, 26, 881, DateTimeKind.Utc).AddTicks(458), new DateTime(2024, 8, 15, 16, 14, 26, 881, DateTimeKind.Local).AddTicks(452) });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: 2042,
                columns: new[] { "ConcurrencyStamp", "CreatedTime", "LastUpdatedTime", "RefreshTokenCreateTime" },
                values: new object[] { "3c2a2694-f36f-4e18-a91d-4271e2de1984", new DateTime(2024, 8, 15, 12, 14, 26, 881, DateTimeKind.Utc).AddTicks(476), new DateTime(2024, 8, 15, 12, 14, 26, 881, DateTimeKind.Utc).AddTicks(477), new DateTime(2024, 8, 15, 16, 14, 26, 881, DateTimeKind.Local).AddTicks(471) });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: 2043,
                columns: new[] { "ConcurrencyStamp", "CreatedTime", "LastUpdatedTime", "RefreshTokenCreateTime" },
                values: new object[] { "825814ac-009d-46b7-b671-a3801e271409", new DateTime(2024, 8, 15, 12, 14, 26, 881, DateTimeKind.Utc).AddTicks(490), new DateTime(2024, 8, 15, 12, 14, 26, 881, DateTimeKind.Utc).AddTicks(491), new DateTime(2024, 8, 15, 16, 14, 26, 881, DateTimeKind.Local).AddTicks(485) });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: 2044,
                columns: new[] { "ConcurrencyStamp", "CreatedTime", "LastUpdatedTime", "RefreshTokenCreateTime" },
                values: new object[] { "77585ca6-d169-41e8-a1ca-62fccda77de4", new DateTime(2024, 8, 15, 12, 14, 26, 881, DateTimeKind.Utc).AddTicks(507), new DateTime(2024, 8, 15, 12, 14, 26, 881, DateTimeKind.Utc).AddTicks(507), new DateTime(2024, 8, 15, 16, 14, 26, 881, DateTimeKind.Local).AddTicks(499) });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: 2045,
                columns: new[] { "ConcurrencyStamp", "CreatedTime", "LastUpdatedTime", "RefreshTokenCreateTime" },
                values: new object[] { "c063c86d-d1e8-4be5-aa25-6648c7dc71e8", new DateTime(2024, 8, 15, 12, 14, 26, 881, DateTimeKind.Utc).AddTicks(551), new DateTime(2024, 8, 15, 12, 14, 26, 881, DateTimeKind.Utc).AddTicks(552), new DateTime(2024, 8, 15, 16, 14, 26, 881, DateTimeKind.Local).AddTicks(545) });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: 2046,
                columns: new[] { "ConcurrencyStamp", "CreatedTime", "LastUpdatedTime", "RefreshTokenCreateTime" },
                values: new object[] { "cbee5bb7-ad67-4e18-9078-7e2275b1d8b2", new DateTime(2024, 8, 15, 12, 14, 26, 881, DateTimeKind.Utc).AddTicks(565), new DateTime(2024, 8, 15, 12, 14, 26, 881, DateTimeKind.Utc).AddTicks(566), new DateTime(2024, 8, 15, 16, 14, 26, 881, DateTimeKind.Local).AddTicks(560) });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: 2047,
                columns: new[] { "ConcurrencyStamp", "CreatedTime", "LastUpdatedTime", "RefreshTokenCreateTime" },
                values: new object[] { "19bf05a2-07fd-400c-b11b-db9782814edb", new DateTime(2024, 8, 15, 12, 14, 26, 881, DateTimeKind.Utc).AddTicks(578), new DateTime(2024, 8, 15, 12, 14, 26, 881, DateTimeKind.Utc).AddTicks(579), new DateTime(2024, 8, 15, 16, 14, 26, 881, DateTimeKind.Local).AddTicks(573) });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: 2048,
                columns: new[] { "ConcurrencyStamp", "CreatedTime", "LastUpdatedTime", "RefreshTokenCreateTime" },
                values: new object[] { "2a3e6f50-94fe-4f7f-9d69-11fb732e25c1", new DateTime(2024, 8, 15, 12, 14, 26, 881, DateTimeKind.Utc).AddTicks(592), new DateTime(2024, 8, 15, 12, 14, 26, 881, DateTimeKind.Utc).AddTicks(593), new DateTime(2024, 8, 15, 16, 14, 26, 881, DateTimeKind.Local).AddTicks(587) });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: 2049,
                columns: new[] { "ConcurrencyStamp", "CreatedTime", "LastUpdatedTime", "RefreshTokenCreateTime" },
                values: new object[] { "3e48fb03-0654-4527-89e6-47088e7ec0da", new DateTime(2024, 8, 15, 12, 14, 26, 881, DateTimeKind.Utc).AddTicks(606), new DateTime(2024, 8, 15, 12, 14, 26, 881, DateTimeKind.Utc).AddTicks(606), new DateTime(2024, 8, 15, 16, 14, 26, 881, DateTimeKind.Local).AddTicks(601) });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: 2050,
                columns: new[] { "ConcurrencyStamp", "CreatedTime", "LastUpdatedTime", "RefreshTokenCreateTime" },
                values: new object[] { "0c8a4c00-5fe6-4bdf-9879-76af6299395b", new DateTime(2024, 8, 15, 12, 14, 26, 881, DateTimeKind.Utc).AddTicks(619), new DateTime(2024, 8, 15, 12, 14, 26, 881, DateTimeKind.Utc).AddTicks(620), new DateTime(2024, 8, 15, 16, 14, 26, 881, DateTimeKind.Local).AddTicks(614) });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: 2051,
                columns: new[] { "ConcurrencyStamp", "CreatedTime", "LastUpdatedTime", "RefreshTokenCreateTime" },
                values: new object[] { "aa928a33-6ed5-4bf5-99ed-f29fdf6aa836", new DateTime(2024, 8, 15, 12, 14, 26, 881, DateTimeKind.Utc).AddTicks(633), new DateTime(2024, 8, 15, 12, 14, 26, 881, DateTimeKind.Utc).AddTicks(633), new DateTime(2024, 8, 15, 16, 14, 26, 881, DateTimeKind.Local).AddTicks(627) });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: 2052,
                columns: new[] { "ConcurrencyStamp", "CreatedTime", "LastUpdatedTime", "RefreshTokenCreateTime" },
                values: new object[] { "065aa4d5-f3da-4455-a876-58e54da27a32", new DateTime(2024, 8, 15, 12, 14, 26, 881, DateTimeKind.Utc).AddTicks(649), new DateTime(2024, 8, 15, 12, 14, 26, 881, DateTimeKind.Utc).AddTicks(650), new DateTime(2024, 8, 15, 16, 14, 26, 881, DateTimeKind.Local).AddTicks(641) });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: 2053,
                columns: new[] { "ConcurrencyStamp", "CreatedTime", "LastUpdatedTime", "RefreshTokenCreateTime" },
                values: new object[] { "ab8807fc-96c7-4516-a88e-8341512de244", new DateTime(2024, 8, 15, 12, 14, 26, 881, DateTimeKind.Utc).AddTicks(663), new DateTime(2024, 8, 15, 12, 14, 26, 881, DateTimeKind.Utc).AddTicks(663), new DateTime(2024, 8, 15, 16, 14, 26, 881, DateTimeKind.Local).AddTicks(658) });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: 2054,
                columns: new[] { "ConcurrencyStamp", "CreatedTime", "LastUpdatedTime", "RefreshTokenCreateTime" },
                values: new object[] { "b3862536-d65b-4bfa-8e31-0526439770c8", new DateTime(2024, 8, 15, 12, 14, 26, 881, DateTimeKind.Utc).AddTicks(713), new DateTime(2024, 8, 15, 12, 14, 26, 881, DateTimeKind.Utc).AddTicks(713), new DateTime(2024, 8, 15, 16, 14, 26, 881, DateTimeKind.Local).AddTicks(707) });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: 2055,
                columns: new[] { "ConcurrencyStamp", "CreatedTime", "LastUpdatedTime", "RefreshTokenCreateTime" },
                values: new object[] { "2a60ca20-d753-4a99-896b-22e0718fda58", new DateTime(2024, 8, 15, 12, 14, 26, 881, DateTimeKind.Utc).AddTicks(727), new DateTime(2024, 8, 15, 12, 14, 26, 881, DateTimeKind.Utc).AddTicks(728), new DateTime(2024, 8, 15, 16, 14, 26, 881, DateTimeKind.Local).AddTicks(722) });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: 2056,
                columns: new[] { "ConcurrencyStamp", "CreatedTime", "LastUpdatedTime", "RefreshTokenCreateTime" },
                values: new object[] { "9b2f74e4-bcf3-49be-bd4b-bfe8b37b6c27", new DateTime(2024, 8, 15, 12, 14, 26, 881, DateTimeKind.Utc).AddTicks(741), new DateTime(2024, 8, 15, 12, 14, 26, 881, DateTimeKind.Utc).AddTicks(741), new DateTime(2024, 8, 15, 16, 14, 26, 881, DateTimeKind.Local).AddTicks(736) });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: 2057,
                columns: new[] { "ConcurrencyStamp", "CreatedTime", "LastUpdatedTime", "RefreshTokenCreateTime" },
                values: new object[] { "ad874f2b-3fd0-45b6-b3cb-9d54c301ff0a", new DateTime(2024, 8, 15, 12, 14, 26, 881, DateTimeKind.Utc).AddTicks(754), new DateTime(2024, 8, 15, 12, 14, 26, 881, DateTimeKind.Utc).AddTicks(755), new DateTime(2024, 8, 15, 16, 14, 26, 881, DateTimeKind.Local).AddTicks(749) });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: 2058,
                columns: new[] { "ConcurrencyStamp", "CreatedTime", "LastUpdatedTime", "RefreshTokenCreateTime" },
                values: new object[] { "82b98343-a347-4bb7-84e2-4e4301e189b4", new DateTime(2024, 8, 15, 12, 14, 26, 881, DateTimeKind.Utc).AddTicks(768), new DateTime(2024, 8, 15, 12, 14, 26, 881, DateTimeKind.Utc).AddTicks(768), new DateTime(2024, 8, 15, 16, 14, 26, 881, DateTimeKind.Local).AddTicks(763) });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: 2059,
                columns: new[] { "ConcurrencyStamp", "CreatedTime", "LastUpdatedTime", "RefreshTokenCreateTime" },
                values: new object[] { "70bb1502-c661-4c42-ae2c-21c23f985c46", new DateTime(2024, 8, 15, 12, 14, 26, 881, DateTimeKind.Utc).AddTicks(782), new DateTime(2024, 8, 15, 12, 14, 26, 881, DateTimeKind.Utc).AddTicks(782), new DateTime(2024, 8, 15, 16, 14, 26, 881, DateTimeKind.Local).AddTicks(777) });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: 2060,
                columns: new[] { "ConcurrencyStamp", "CreatedTime", "LastUpdatedTime", "RefreshTokenCreateTime" },
                values: new object[] { "454d3926-5293-419c-acd4-58f670aa67e1", new DateTime(2024, 8, 15, 12, 14, 26, 881, DateTimeKind.Utc).AddTicks(799), new DateTime(2024, 8, 15, 12, 14, 26, 881, DateTimeKind.Utc).AddTicks(799), new DateTime(2024, 8, 15, 16, 14, 26, 881, DateTimeKind.Local).AddTicks(790) });
        }
    }
}
