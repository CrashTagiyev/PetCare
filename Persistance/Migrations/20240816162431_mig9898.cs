using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Persistance.Migrations
{
    /// <inheritdoc />
    public partial class mig9898 : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<string>(
                name: "CompanyName",
                table: "AspNetUsers",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: 2001,
                columns: new[] { "CompanyName", "ConcurrencyStamp", "CreatedTime", "LastUpdatedTime", "RefreshTokenCreateTime" },
                values: new object[] { null, "44d0e08d-074a-4e67-b828-aa351f0751d7", new DateTime(2024, 8, 16, 16, 24, 29, 966, DateTimeKind.Utc).AddTicks(820), new DateTime(2024, 8, 16, 16, 24, 29, 966, DateTimeKind.Utc).AddTicks(822), new DateTime(2024, 8, 16, 20, 24, 29, 966, DateTimeKind.Local).AddTicks(710) });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: 2002,
                columns: new[] { "CompanyName", "ConcurrencyStamp", "CreatedTime", "LastUpdatedTime", "RefreshTokenCreateTime" },
                values: new object[] { null, "6127a97e-d398-4bc0-9ecc-7482d3091729", new DateTime(2024, 8, 16, 16, 24, 29, 966, DateTimeKind.Utc).AddTicks(865), new DateTime(2024, 8, 16, 16, 24, 29, 966, DateTimeKind.Utc).AddTicks(865), new DateTime(2024, 8, 16, 20, 24, 29, 966, DateTimeKind.Local).AddTicks(849) });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: 2003,
                columns: new[] { "CompanyName", "ConcurrencyStamp", "CreatedTime", "LastUpdatedTime", "RefreshTokenCreateTime" },
                values: new object[] { null, "e1926a47-374e-4e26-935a-ec2560932564", new DateTime(2024, 8, 16, 16, 24, 29, 966, DateTimeKind.Utc).AddTicks(945), new DateTime(2024, 8, 16, 16, 24, 29, 966, DateTimeKind.Utc).AddTicks(946), new DateTime(2024, 8, 16, 20, 24, 29, 966, DateTimeKind.Local).AddTicks(938) });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: 2004,
                columns: new[] { "CompanyName", "ConcurrencyStamp", "CreatedTime", "LastUpdatedTime", "RefreshTokenCreateTime" },
                values: new object[] { null, "2d22cb50-0338-4aa6-b1d1-1d1134818729", new DateTime(2024, 8, 16, 16, 24, 29, 966, DateTimeKind.Utc).AddTicks(960), new DateTime(2024, 8, 16, 16, 24, 29, 966, DateTimeKind.Utc).AddTicks(960), new DateTime(2024, 8, 16, 20, 24, 29, 966, DateTimeKind.Local).AddTicks(954) });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: 2005,
                columns: new[] { "CompanyName", "ConcurrencyStamp", "CreatedTime", "LastUpdatedTime", "RefreshTokenCreateTime" },
                values: new object[] { null, "31ab1b85-7009-4a6b-97b9-621db496370d", new DateTime(2024, 8, 16, 16, 24, 29, 966, DateTimeKind.Utc).AddTicks(975), new DateTime(2024, 8, 16, 16, 24, 29, 966, DateTimeKind.Utc).AddTicks(975), new DateTime(2024, 8, 16, 20, 24, 29, 966, DateTimeKind.Local).AddTicks(969) });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: 2006,
                columns: new[] { "CompanyName", "ConcurrencyStamp", "CreatedTime", "LastUpdatedTime", "RefreshTokenCreateTime" },
                values: new object[] { null, "41cf8376-e96b-40ce-8215-a3d4fdcc1a72", new DateTime(2024, 8, 16, 16, 24, 29, 966, DateTimeKind.Utc).AddTicks(994), new DateTime(2024, 8, 16, 16, 24, 29, 966, DateTimeKind.Utc).AddTicks(994), new DateTime(2024, 8, 16, 20, 24, 29, 966, DateTimeKind.Local).AddTicks(988) });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: 2007,
                columns: new[] { "CompanyName", "ConcurrencyStamp", "CreatedTime", "LastUpdatedTime", "RefreshTokenCreateTime" },
                values: new object[] { null, "0f2f8336-3202-49ee-95e5-6303605a5c7b", new DateTime(2024, 8, 16, 16, 24, 29, 966, DateTimeKind.Utc).AddTicks(1009), new DateTime(2024, 8, 16, 16, 24, 29, 966, DateTimeKind.Utc).AddTicks(1010), new DateTime(2024, 8, 16, 20, 24, 29, 966, DateTimeKind.Local).AddTicks(1003) });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: 2008,
                columns: new[] { "CompanyName", "ConcurrencyStamp", "CreatedTime", "LastUpdatedTime", "RefreshTokenCreateTime" },
                values: new object[] { null, "85cb79c0-21d5-43af-896b-0d7c197b10f7", new DateTime(2024, 8, 16, 16, 24, 29, 966, DateTimeKind.Utc).AddTicks(1024), new DateTime(2024, 8, 16, 16, 24, 29, 966, DateTimeKind.Utc).AddTicks(1025), new DateTime(2024, 8, 16, 20, 24, 29, 966, DateTimeKind.Local).AddTicks(1018) });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: 2009,
                columns: new[] { "CompanyName", "ConcurrencyStamp", "CreatedTime", "LastUpdatedTime", "RefreshTokenCreateTime" },
                values: new object[] { null, "b274cfb7-252c-4839-84b8-b0e1924e104b", new DateTime(2024, 8, 16, 16, 24, 29, 966, DateTimeKind.Utc).AddTicks(1039), new DateTime(2024, 8, 16, 16, 24, 29, 966, DateTimeKind.Utc).AddTicks(1040), new DateTime(2024, 8, 16, 20, 24, 29, 966, DateTimeKind.Local).AddTicks(1034) });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: 2010,
                columns: new[] { "CompanyName", "ConcurrencyStamp", "CreatedTime", "LastUpdatedTime", "RefreshTokenCreateTime" },
                values: new object[] { null, "0184de23-7bc2-4861-8294-1985be1dfdc1", new DateTime(2024, 8, 16, 16, 24, 29, 966, DateTimeKind.Utc).AddTicks(1061), new DateTime(2024, 8, 16, 16, 24, 29, 966, DateTimeKind.Utc).AddTicks(1061), new DateTime(2024, 8, 16, 20, 24, 29, 966, DateTimeKind.Local).AddTicks(1050) });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: 2011,
                columns: new[] { "CompanyName", "ConcurrencyStamp", "CreatedTime", "LastUpdatedTime", "RefreshTokenCreateTime" },
                values: new object[] { null, "3d7c08d9-d9ec-4cf7-9716-f7c83b01c4a5", new DateTime(2024, 8, 16, 16, 24, 29, 966, DateTimeKind.Utc).AddTicks(1076), new DateTime(2024, 8, 16, 16, 24, 29, 966, DateTimeKind.Utc).AddTicks(1077), new DateTime(2024, 8, 16, 20, 24, 29, 966, DateTimeKind.Local).AddTicks(1071) });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: 2012,
                columns: new[] { "CompanyName", "ConcurrencyStamp", "CreatedTime", "LastUpdatedTime", "RefreshTokenCreateTime" },
                values: new object[] { null, "b69755ab-2dc2-4c1a-82a4-4bf1313ed133", new DateTime(2024, 8, 16, 16, 24, 29, 966, DateTimeKind.Utc).AddTicks(1131), new DateTime(2024, 8, 16, 16, 24, 29, 966, DateTimeKind.Utc).AddTicks(1132), new DateTime(2024, 8, 16, 20, 24, 29, 966, DateTimeKind.Local).AddTicks(1125) });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: 2013,
                columns: new[] { "CompanyName", "ConcurrencyStamp", "CreatedTime", "LastUpdatedTime", "RefreshTokenCreateTime" },
                values: new object[] { null, "f2e1656a-6539-4eb2-bc5d-ba5624e5f300", new DateTime(2024, 8, 16, 16, 24, 29, 966, DateTimeKind.Utc).AddTicks(1147), new DateTime(2024, 8, 16, 16, 24, 29, 966, DateTimeKind.Utc).AddTicks(1147), new DateTime(2024, 8, 16, 20, 24, 29, 966, DateTimeKind.Local).AddTicks(1141) });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: 2014,
                columns: new[] { "CompanyName", "ConcurrencyStamp", "CreatedTime", "LastUpdatedTime", "RefreshTokenCreateTime" },
                values: new object[] { null, "bd938109-ca6a-4d6f-b8d8-69b2f08d49a0", new DateTime(2024, 8, 16, 16, 24, 29, 966, DateTimeKind.Utc).AddTicks(1161), new DateTime(2024, 8, 16, 16, 24, 29, 966, DateTimeKind.Utc).AddTicks(1162), new DateTime(2024, 8, 16, 20, 24, 29, 966, DateTimeKind.Local).AddTicks(1156) });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: 2015,
                columns: new[] { "CompanyName", "ConcurrencyStamp", "CreatedTime", "LastUpdatedTime", "RefreshTokenCreateTime" },
                values: new object[] { null, "a971b087-08cb-4c17-811a-6afb37702748", new DateTime(2024, 8, 16, 16, 24, 29, 966, DateTimeKind.Utc).AddTicks(1176), new DateTime(2024, 8, 16, 16, 24, 29, 966, DateTimeKind.Utc).AddTicks(1176), new DateTime(2024, 8, 16, 20, 24, 29, 966, DateTimeKind.Local).AddTicks(1170) });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: 2016,
                columns: new[] { "CompanyName", "ConcurrencyStamp", "CreatedTime", "LastUpdatedTime", "RefreshTokenCreateTime" },
                values: new object[] { null, "ad6cc927-27af-4442-943d-d30dd2338dcb", new DateTime(2024, 8, 16, 16, 24, 29, 966, DateTimeKind.Utc).AddTicks(1190), new DateTime(2024, 8, 16, 16, 24, 29, 966, DateTimeKind.Utc).AddTicks(1191), new DateTime(2024, 8, 16, 20, 24, 29, 966, DateTimeKind.Local).AddTicks(1185) });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: 2017,
                columns: new[] { "CompanyName", "ConcurrencyStamp", "CreatedTime", "LastUpdatedTime", "RefreshTokenCreateTime" },
                values: new object[] { null, "77037f31-9b2e-43c5-8c71-e6a58ecc0ea0", new DateTime(2024, 8, 16, 16, 24, 29, 966, DateTimeKind.Utc).AddTicks(1205), new DateTime(2024, 8, 16, 16, 24, 29, 966, DateTimeKind.Utc).AddTicks(1205), new DateTime(2024, 8, 16, 20, 24, 29, 966, DateTimeKind.Local).AddTicks(1199) });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: 2018,
                columns: new[] { "CompanyName", "ConcurrencyStamp", "CreatedTime", "LastUpdatedTime", "RefreshTokenCreateTime" },
                values: new object[] { null, "93da719e-10e2-4925-a20e-83515a57a9b5", new DateTime(2024, 8, 16, 16, 24, 29, 966, DateTimeKind.Utc).AddTicks(1225), new DateTime(2024, 8, 16, 16, 24, 29, 966, DateTimeKind.Utc).AddTicks(1226), new DateTime(2024, 8, 16, 20, 24, 29, 966, DateTimeKind.Local).AddTicks(1216) });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: 2019,
                columns: new[] { "CompanyName", "ConcurrencyStamp", "CreatedTime", "LastUpdatedTime", "RefreshTokenCreateTime" },
                values: new object[] { null, "edb4ef6b-f2d3-4a20-923c-abeb9a2daacf", new DateTime(2024, 8, 16, 16, 24, 29, 966, DateTimeKind.Utc).AddTicks(1240), new DateTime(2024, 8, 16, 16, 24, 29, 966, DateTimeKind.Utc).AddTicks(1241), new DateTime(2024, 8, 16, 20, 24, 29, 966, DateTimeKind.Local).AddTicks(1235) });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: 2020,
                columns: new[] { "CompanyName", "ConcurrencyStamp", "CreatedTime", "LastUpdatedTime", "RefreshTokenCreateTime" },
                values: new object[] { null, "9758ab7a-30b2-495e-809f-c8f24ff11625", new DateTime(2024, 8, 16, 16, 24, 29, 966, DateTimeKind.Utc).AddTicks(1255), new DateTime(2024, 8, 16, 16, 24, 29, 966, DateTimeKind.Utc).AddTicks(1255), new DateTime(2024, 8, 16, 20, 24, 29, 966, DateTimeKind.Local).AddTicks(1249) });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: 2021,
                columns: new[] { "CompanyName", "ConcurrencyStamp", "CreatedTime", "LastUpdatedTime", "RefreshTokenCreateTime" },
                values: new object[] { null, "be471e69-612f-40ee-b15d-6407e66eaab3", new DateTime(2024, 8, 16, 16, 24, 29, 966, DateTimeKind.Utc).AddTicks(1308), new DateTime(2024, 8, 16, 16, 24, 29, 966, DateTimeKind.Utc).AddTicks(1308), new DateTime(2024, 8, 16, 20, 24, 29, 966, DateTimeKind.Local).AddTicks(1302) });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: 2022,
                columns: new[] { "CompanyName", "ConcurrencyStamp", "CreatedTime", "LastUpdatedTime", "RefreshTokenCreateTime" },
                values: new object[] { null, "22687ebb-203e-4812-8061-eb10e23201dc", new DateTime(2024, 8, 16, 16, 24, 29, 966, DateTimeKind.Utc).AddTicks(1331), new DateTime(2024, 8, 16, 16, 24, 29, 966, DateTimeKind.Utc).AddTicks(1331), new DateTime(2024, 8, 16, 20, 24, 29, 966, DateTimeKind.Local).AddTicks(1324) });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: 2023,
                columns: new[] { "CompanyName", "ConcurrencyStamp", "CreatedTime", "LastUpdatedTime", "RefreshTokenCreateTime" },
                values: new object[] { null, "d6337ead-ab1d-4e13-9424-09db774559ee", new DateTime(2024, 8, 16, 16, 24, 29, 966, DateTimeKind.Utc).AddTicks(1347), new DateTime(2024, 8, 16, 16, 24, 29, 966, DateTimeKind.Utc).AddTicks(1347), new DateTime(2024, 8, 16, 20, 24, 29, 966, DateTimeKind.Local).AddTicks(1341) });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: 2024,
                columns: new[] { "CompanyName", "ConcurrencyStamp", "CreatedTime", "LastUpdatedTime", "RefreshTokenCreateTime" },
                values: new object[] { null, "45b5aee9-672b-4448-a541-fbb7b689e9fe", new DateTime(2024, 8, 16, 16, 24, 29, 966, DateTimeKind.Utc).AddTicks(1363), new DateTime(2024, 8, 16, 16, 24, 29, 966, DateTimeKind.Utc).AddTicks(1363), new DateTime(2024, 8, 16, 20, 24, 29, 966, DateTimeKind.Local).AddTicks(1357) });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: 2025,
                columns: new[] { "CompanyName", "ConcurrencyStamp", "CreatedTime", "LastUpdatedTime", "RefreshTokenCreateTime" },
                values: new object[] { null, "8396ee5e-d474-4d00-8ca0-af20144354d7", new DateTime(2024, 8, 16, 16, 24, 29, 966, DateTimeKind.Utc).AddTicks(1379), new DateTime(2024, 8, 16, 16, 24, 29, 966, DateTimeKind.Utc).AddTicks(1380), new DateTime(2024, 8, 16, 20, 24, 29, 966, DateTimeKind.Local).AddTicks(1373) });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: 2026,
                columns: new[] { "CompanyName", "ConcurrencyStamp", "CreatedTime", "LastUpdatedTime", "RefreshTokenCreateTime" },
                values: new object[] { null, "037bce16-9d37-4dc6-af33-33450cba96f3", new DateTime(2024, 8, 16, 16, 24, 29, 966, DateTimeKind.Utc).AddTicks(1398), new DateTime(2024, 8, 16, 16, 24, 29, 966, DateTimeKind.Utc).AddTicks(1398), new DateTime(2024, 8, 16, 20, 24, 29, 966, DateTimeKind.Local).AddTicks(1390) });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: 2027,
                columns: new[] { "CompanyName", "ConcurrencyStamp", "CreatedTime", "LastUpdatedTime", "RefreshTokenCreateTime" },
                values: new object[] { null, "4a590b81-988d-4203-a4c7-4c83ae5fcd07", new DateTime(2024, 8, 16, 16, 24, 29, 966, DateTimeKind.Utc).AddTicks(1414), new DateTime(2024, 8, 16, 16, 24, 29, 966, DateTimeKind.Utc).AddTicks(1414), new DateTime(2024, 8, 16, 20, 24, 29, 966, DateTimeKind.Local).AddTicks(1408) });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: 2028,
                columns: new[] { "CompanyName", "ConcurrencyStamp", "CreatedTime", "LastUpdatedTime", "RefreshTokenCreateTime" },
                values: new object[] { null, "8e72629f-831d-4d40-ad1b-428fded4f207", new DateTime(2024, 8, 16, 16, 24, 29, 966, DateTimeKind.Utc).AddTicks(1430), new DateTime(2024, 8, 16, 16, 24, 29, 966, DateTimeKind.Utc).AddTicks(1430), new DateTime(2024, 8, 16, 20, 24, 29, 966, DateTimeKind.Local).AddTicks(1424) });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: 2029,
                columns: new[] { "CompanyName", "ConcurrencyStamp", "CreatedTime", "LastUpdatedTime", "RefreshTokenCreateTime" },
                values: new object[] { null, "2a8fb5e0-4dd4-4684-8119-2a5af830a9e5", new DateTime(2024, 8, 16, 16, 24, 29, 966, DateTimeKind.Utc).AddTicks(1481), new DateTime(2024, 8, 16, 16, 24, 29, 966, DateTimeKind.Utc).AddTicks(1481), new DateTime(2024, 8, 16, 20, 24, 29, 966, DateTimeKind.Local).AddTicks(1440) });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: 2030,
                columns: new[] { "CompanyName", "ConcurrencyStamp", "CreatedTime", "LastUpdatedTime", "RefreshTokenCreateTime" },
                values: new object[] { null, "9344269a-588b-4f57-8266-a24690c449ef", new DateTime(2024, 8, 16, 16, 24, 29, 966, DateTimeKind.Utc).AddTicks(1498), new DateTime(2024, 8, 16, 16, 24, 29, 966, DateTimeKind.Utc).AddTicks(1498), new DateTime(2024, 8, 16, 20, 24, 29, 966, DateTimeKind.Local).AddTicks(1492) });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: 2031,
                columns: new[] { "CompanyName", "ConcurrencyStamp", "CreatedTime", "LastUpdatedTime", "RefreshTokenCreateTime" },
                values: new object[] { null, "75d88893-081e-4797-a432-c709f71bfe73", new DateTime(2024, 8, 16, 16, 24, 29, 966, DateTimeKind.Utc).AddTicks(1513), new DateTime(2024, 8, 16, 16, 24, 29, 966, DateTimeKind.Utc).AddTicks(1514), new DateTime(2024, 8, 16, 20, 24, 29, 966, DateTimeKind.Local).AddTicks(1508) });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: 2032,
                columns: new[] { "CompanyName", "ConcurrencyStamp", "CreatedTime", "LastUpdatedTime", "RefreshTokenCreateTime" },
                values: new object[] { null, "ce9d35a0-fb25-490a-af48-c24f88600614", new DateTime(2024, 8, 16, 16, 24, 29, 966, DateTimeKind.Utc).AddTicks(1531), new DateTime(2024, 8, 16, 16, 24, 29, 966, DateTimeKind.Utc).AddTicks(1531), new DateTime(2024, 8, 16, 20, 24, 29, 966, DateTimeKind.Local).AddTicks(1524) });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: 2033,
                columns: new[] { "CompanyName", "ConcurrencyStamp", "CreatedTime", "LastUpdatedTime", "RefreshTokenCreateTime" },
                values: new object[] { null, "c544cf29-5e00-4239-93c7-280f32a9cc0a", new DateTime(2024, 8, 16, 16, 24, 29, 966, DateTimeKind.Utc).AddTicks(1547), new DateTime(2024, 8, 16, 16, 24, 29, 966, DateTimeKind.Utc).AddTicks(1548), new DateTime(2024, 8, 16, 20, 24, 29, 966, DateTimeKind.Local).AddTicks(1542) });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: 2034,
                columns: new[] { "CompanyName", "ConcurrencyStamp", "CreatedTime", "LastUpdatedTime", "RefreshTokenCreateTime" },
                values: new object[] { null, "6178b5cd-4e00-43f5-bd78-132c3110bb38", new DateTime(2024, 8, 16, 16, 24, 29, 966, DateTimeKind.Utc).AddTicks(1571), new DateTime(2024, 8, 16, 16, 24, 29, 966, DateTimeKind.Utc).AddTicks(1571), new DateTime(2024, 8, 16, 20, 24, 29, 966, DateTimeKind.Local).AddTicks(1561) });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: 2035,
                columns: new[] { "CompanyName", "ConcurrencyStamp", "CreatedTime", "LastUpdatedTime", "RefreshTokenCreateTime" },
                values: new object[] { null, "c8bb41e3-7948-4135-9fcc-8e43fe314f42", new DateTime(2024, 8, 16, 16, 24, 29, 966, DateTimeKind.Utc).AddTicks(1587), new DateTime(2024, 8, 16, 16, 24, 29, 966, DateTimeKind.Utc).AddTicks(1588), new DateTime(2024, 8, 16, 20, 24, 29, 966, DateTimeKind.Local).AddTicks(1581) });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: 2036,
                columns: new[] { "CompanyName", "ConcurrencyStamp", "CreatedTime", "LastUpdatedTime", "RefreshTokenCreateTime" },
                values: new object[] { null, "cf5d6025-0ace-4ea0-9bef-f3cee45db3f8", new DateTime(2024, 8, 16, 16, 24, 29, 966, DateTimeKind.Utc).AddTicks(1603), new DateTime(2024, 8, 16, 16, 24, 29, 966, DateTimeKind.Utc).AddTicks(1604), new DateTime(2024, 8, 16, 20, 24, 29, 966, DateTimeKind.Local).AddTicks(1598) });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: 2037,
                columns: new[] { "CompanyName", "ConcurrencyStamp", "CreatedTime", "LastUpdatedTime", "RefreshTokenCreateTime" },
                values: new object[] { null, "cb87bd1d-66c2-4eb1-a7f5-c0631208dbf5", new DateTime(2024, 8, 16, 16, 24, 29, 966, DateTimeKind.Utc).AddTicks(1620), new DateTime(2024, 8, 16, 16, 24, 29, 966, DateTimeKind.Utc).AddTicks(1620), new DateTime(2024, 8, 16, 20, 24, 29, 966, DateTimeKind.Local).AddTicks(1614) });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: 2038,
                columns: new[] { "CompanyName", "ConcurrencyStamp", "CreatedTime", "LastUpdatedTime", "RefreshTokenCreateTime" },
                values: new object[] { null, "8356fec2-7eee-4382-9d74-964f4240e8a9", new DateTime(2024, 8, 16, 16, 24, 29, 966, DateTimeKind.Utc).AddTicks(1740), new DateTime(2024, 8, 16, 16, 24, 29, 966, DateTimeKind.Utc).AddTicks(1741), new DateTime(2024, 8, 16, 20, 24, 29, 966, DateTimeKind.Local).AddTicks(1732) });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: 2039,
                columns: new[] { "CompanyName", "ConcurrencyStamp", "CreatedTime", "LastUpdatedTime", "RefreshTokenCreateTime" },
                values: new object[] { null, "363df187-5681-429f-8a51-c3c83333e7e6", new DateTime(2024, 8, 16, 16, 24, 29, 966, DateTimeKind.Utc).AddTicks(1757), new DateTime(2024, 8, 16, 16, 24, 29, 966, DateTimeKind.Utc).AddTicks(1757), new DateTime(2024, 8, 16, 20, 24, 29, 966, DateTimeKind.Local).AddTicks(1751) });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: 2040,
                columns: new[] { "CompanyName", "ConcurrencyStamp", "CreatedTime", "LastUpdatedTime", "RefreshTokenCreateTime" },
                values: new object[] { null, "4aa6f188-a7a2-4fe8-9c9f-8bf139e98f4b", new DateTime(2024, 8, 16, 16, 24, 29, 966, DateTimeKind.Utc).AddTicks(1773), new DateTime(2024, 8, 16, 16, 24, 29, 966, DateTimeKind.Utc).AddTicks(1773), new DateTime(2024, 8, 16, 20, 24, 29, 966, DateTimeKind.Local).AddTicks(1767) });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: 2041,
                columns: new[] { "CompanyName", "ConcurrencyStamp", "CreatedTime", "LastUpdatedTime", "RefreshTokenCreateTime" },
                values: new object[] { null, "2afeeba6-9e87-4b9d-886e-88bcde5cd9b7", new DateTime(2024, 8, 16, 16, 24, 29, 966, DateTimeKind.Utc).AddTicks(1789), new DateTime(2024, 8, 16, 16, 24, 29, 966, DateTimeKind.Utc).AddTicks(1789), new DateTime(2024, 8, 16, 20, 24, 29, 966, DateTimeKind.Local).AddTicks(1783) });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: 2042,
                columns: new[] { "CompanyName", "ConcurrencyStamp", "CreatedTime", "LastUpdatedTime", "RefreshTokenCreateTime" },
                values: new object[] { null, "52acd9a6-bdbb-4a03-ae49-6327c0117e82", new DateTime(2024, 8, 16, 16, 24, 29, 966, DateTimeKind.Utc).AddTicks(1812), new DateTime(2024, 8, 16, 16, 24, 29, 966, DateTimeKind.Utc).AddTicks(1812), new DateTime(2024, 8, 16, 20, 24, 29, 966, DateTimeKind.Local).AddTicks(1803) });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: 2043,
                columns: new[] { "CompanyName", "ConcurrencyStamp", "CreatedTime", "LastUpdatedTime", "RefreshTokenCreateTime" },
                values: new object[] { null, "259dd369-0522-40bf-8530-6daae97dbe8b", new DateTime(2024, 8, 16, 16, 24, 29, 966, DateTimeKind.Utc).AddTicks(1828), new DateTime(2024, 8, 16, 16, 24, 29, 966, DateTimeKind.Utc).AddTicks(1828), new DateTime(2024, 8, 16, 20, 24, 29, 966, DateTimeKind.Local).AddTicks(1822) });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: 2044,
                columns: new[] { "CompanyName", "ConcurrencyStamp", "CreatedTime", "LastUpdatedTime", "RefreshTokenCreateTime" },
                values: new object[] { null, "0a03583e-7b63-4734-bdd6-16be27a72d7a", new DateTime(2024, 8, 16, 16, 24, 29, 966, DateTimeKind.Utc).AddTicks(1842), new DateTime(2024, 8, 16, 16, 24, 29, 966, DateTimeKind.Utc).AddTicks(1843), new DateTime(2024, 8, 16, 20, 24, 29, 966, DateTimeKind.Local).AddTicks(1837) });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: 2045,
                columns: new[] { "CompanyName", "ConcurrencyStamp", "CreatedTime", "LastUpdatedTime", "RefreshTokenCreateTime" },
                values: new object[] { null, "4954c410-a8f3-4efa-9499-70b50b59a3c6", new DateTime(2024, 8, 16, 16, 24, 29, 966, DateTimeKind.Utc).AddTicks(1857), new DateTime(2024, 8, 16, 16, 24, 29, 966, DateTimeKind.Utc).AddTicks(1857), new DateTime(2024, 8, 16, 20, 24, 29, 966, DateTimeKind.Local).AddTicks(1851) });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: 2046,
                columns: new[] { "CompanyName", "ConcurrencyStamp", "CreatedTime", "LastUpdatedTime", "RefreshTokenCreateTime" },
                values: new object[] { null, "b6955dac-71ac-4fa3-b79c-726e44991d1f", new DateTime(2024, 8, 16, 16, 24, 29, 966, DateTimeKind.Utc).AddTicks(1871), new DateTime(2024, 8, 16, 16, 24, 29, 966, DateTimeKind.Utc).AddTicks(1872), new DateTime(2024, 8, 16, 20, 24, 29, 966, DateTimeKind.Local).AddTicks(1866) });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: 2047,
                columns: new[] { "CompanyName", "ConcurrencyStamp", "CreatedTime", "LastUpdatedTime", "RefreshTokenCreateTime" },
                values: new object[] { null, "9c1111d3-ba7f-46ee-b439-10f839838412", new DateTime(2024, 8, 16, 16, 24, 29, 966, DateTimeKind.Utc).AddTicks(1910), new DateTime(2024, 8, 16, 16, 24, 29, 966, DateTimeKind.Utc).AddTicks(1911), new DateTime(2024, 8, 16, 20, 24, 29, 966, DateTimeKind.Local).AddTicks(1905) });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: 2048,
                columns: new[] { "CompanyName", "ConcurrencyStamp", "CreatedTime", "LastUpdatedTime", "RefreshTokenCreateTime" },
                values: new object[] { null, "31008eff-2ba3-4e94-b63f-ad8ba0e62e08", new DateTime(2024, 8, 16, 16, 24, 29, 966, DateTimeKind.Utc).AddTicks(1925), new DateTime(2024, 8, 16, 16, 24, 29, 966, DateTimeKind.Utc).AddTicks(1925), new DateTime(2024, 8, 16, 20, 24, 29, 966, DateTimeKind.Local).AddTicks(1920) });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: 2049,
                columns: new[] { "CompanyName", "ConcurrencyStamp", "CreatedTime", "LastUpdatedTime", "RefreshTokenCreateTime" },
                values: new object[] { null, "0b9cf85f-8ee4-4a1f-b96e-4651912b86d2", new DateTime(2024, 8, 16, 16, 24, 29, 966, DateTimeKind.Utc).AddTicks(1940), new DateTime(2024, 8, 16, 16, 24, 29, 966, DateTimeKind.Utc).AddTicks(1940), new DateTime(2024, 8, 16, 20, 24, 29, 966, DateTimeKind.Local).AddTicks(1934) });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: 2050,
                columns: new[] { "CompanyName", "ConcurrencyStamp", "CreatedTime", "LastUpdatedTime", "RefreshTokenCreateTime" },
                values: new object[] { null, "40a14dfd-76ae-44e5-8ec1-d78e090e4e33", new DateTime(2024, 8, 16, 16, 24, 29, 966, DateTimeKind.Utc).AddTicks(1958), new DateTime(2024, 8, 16, 16, 24, 29, 966, DateTimeKind.Utc).AddTicks(1958), new DateTime(2024, 8, 16, 20, 24, 29, 966, DateTimeKind.Local).AddTicks(1950) });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: 2051,
                columns: new[] { "CompanyName", "ConcurrencyStamp", "CreatedTime", "LastUpdatedTime", "RefreshTokenCreateTime" },
                values: new object[] { null, "6cb20a72-79a1-4e88-9281-ba8e9bf975aa", new DateTime(2024, 8, 16, 16, 24, 29, 966, DateTimeKind.Utc).AddTicks(1972), new DateTime(2024, 8, 16, 16, 24, 29, 966, DateTimeKind.Utc).AddTicks(1973), new DateTime(2024, 8, 16, 20, 24, 29, 966, DateTimeKind.Local).AddTicks(1967) });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: 2052,
                columns: new[] { "CompanyName", "ConcurrencyStamp", "CreatedTime", "LastUpdatedTime", "RefreshTokenCreateTime" },
                values: new object[] { null, "8d0eaff2-5489-451c-b47a-526af9d6a19b", new DateTime(2024, 8, 16, 16, 24, 29, 966, DateTimeKind.Utc).AddTicks(1987), new DateTime(2024, 8, 16, 16, 24, 29, 966, DateTimeKind.Utc).AddTicks(1988), new DateTime(2024, 8, 16, 20, 24, 29, 966, DateTimeKind.Local).AddTicks(1982) });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: 2053,
                columns: new[] { "CompanyName", "ConcurrencyStamp", "CreatedTime", "LastUpdatedTime", "RefreshTokenCreateTime" },
                values: new object[] { null, "408679ce-0f53-4274-be57-0c58e2e7cc43", new DateTime(2024, 8, 16, 16, 24, 29, 966, DateTimeKind.Utc).AddTicks(2002), new DateTime(2024, 8, 16, 16, 24, 29, 966, DateTimeKind.Utc).AddTicks(2002), new DateTime(2024, 8, 16, 20, 24, 29, 966, DateTimeKind.Local).AddTicks(1996) });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: 2054,
                columns: new[] { "CompanyName", "ConcurrencyStamp", "CreatedTime", "LastUpdatedTime", "RefreshTokenCreateTime" },
                values: new object[] { null, "537feb0b-36a8-4848-a12a-136468a42845", new DateTime(2024, 8, 16, 16, 24, 29, 966, DateTimeKind.Utc).AddTicks(2016), new DateTime(2024, 8, 16, 16, 24, 29, 966, DateTimeKind.Utc).AddTicks(2016), new DateTime(2024, 8, 16, 20, 24, 29, 966, DateTimeKind.Local).AddTicks(2011) });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: 2055,
                columns: new[] { "CompanyName", "ConcurrencyStamp", "CreatedTime", "LastUpdatedTime", "RefreshTokenCreateTime" },
                values: new object[] { null, "8367e7e3-6acd-4da9-850e-de7283f563f4", new DateTime(2024, 8, 16, 16, 24, 29, 966, DateTimeKind.Utc).AddTicks(2097), new DateTime(2024, 8, 16, 16, 24, 29, 966, DateTimeKind.Utc).AddTicks(2097), new DateTime(2024, 8, 16, 20, 24, 29, 966, DateTimeKind.Local).AddTicks(2025) });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: 2056,
                columns: new[] { "CompanyName", "ConcurrencyStamp", "CreatedTime", "LastUpdatedTime", "RefreshTokenCreateTime" },
                values: new object[] { null, "2087648f-3bd7-4307-81f0-0b7174ee3b36", new DateTime(2024, 8, 16, 16, 24, 29, 966, DateTimeKind.Utc).AddTicks(2113), new DateTime(2024, 8, 16, 16, 24, 29, 966, DateTimeKind.Utc).AddTicks(2113), new DateTime(2024, 8, 16, 20, 24, 29, 966, DateTimeKind.Local).AddTicks(2106) });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: 2057,
                columns: new[] { "CompanyName", "ConcurrencyStamp", "CreatedTime", "LastUpdatedTime", "RefreshTokenCreateTime" },
                values: new object[] { null, "2d5e3341-b5ec-4714-b065-436a95f335c6", new DateTime(2024, 8, 16, 16, 24, 29, 966, DateTimeKind.Utc).AddTicks(2128), new DateTime(2024, 8, 16, 16, 24, 29, 966, DateTimeKind.Utc).AddTicks(2128), new DateTime(2024, 8, 16, 20, 24, 29, 966, DateTimeKind.Local).AddTicks(2122) });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: 2058,
                columns: new[] { "CompanyName", "ConcurrencyStamp", "CreatedTime", "LastUpdatedTime", "RefreshTokenCreateTime" },
                values: new object[] { null, "ccc796f1-210b-48a2-bf2f-7f06e68b3ab4", new DateTime(2024, 8, 16, 16, 24, 29, 966, DateTimeKind.Utc).AddTicks(2146), new DateTime(2024, 8, 16, 16, 24, 29, 966, DateTimeKind.Utc).AddTicks(2146), new DateTime(2024, 8, 16, 20, 24, 29, 966, DateTimeKind.Local).AddTicks(2137) });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: 2059,
                columns: new[] { "CompanyName", "ConcurrencyStamp", "CreatedTime", "LastUpdatedTime", "RefreshTokenCreateTime" },
                values: new object[] { null, "2dfe9bec-c244-4d0d-9bfb-c4a8920d5c29", new DateTime(2024, 8, 16, 16, 24, 29, 966, DateTimeKind.Utc).AddTicks(2161), new DateTime(2024, 8, 16, 16, 24, 29, 966, DateTimeKind.Utc).AddTicks(2161), new DateTime(2024, 8, 16, 20, 24, 29, 966, DateTimeKind.Local).AddTicks(2155) });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: 2060,
                columns: new[] { "CompanyName", "ConcurrencyStamp", "CreatedTime", "LastUpdatedTime", "RefreshTokenCreateTime" },
                values: new object[] { null, "016edb72-7f1e-42b9-baa6-e68cab4a3a48", new DateTime(2024, 8, 16, 16, 24, 29, 966, DateTimeKind.Utc).AddTicks(2176), new DateTime(2024, 8, 16, 16, 24, 29, 966, DateTimeKind.Utc).AddTicks(2176), new DateTime(2024, 8, 16, 20, 24, 29, 966, DateTimeKind.Local).AddTicks(2170) });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "CompanyName",
                table: "AspNetUsers");

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
    }
}
