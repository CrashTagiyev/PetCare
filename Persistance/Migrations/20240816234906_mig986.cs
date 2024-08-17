using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace Persistance.Migrations
{
    /// <inheritdoc />
    public partial class mig986 : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: 2001,
                columns: new[] { "ConcurrencyStamp", "CreatedTime", "LastUpdatedTime", "RefreshTokenCreateTime" },
                values: new object[] { "fb2e3252-44dc-4c71-82d8-49768c6d8831", new DateTime(2024, 8, 16, 23, 49, 5, 286, DateTimeKind.Utc).AddTicks(322), new DateTime(2024, 8, 16, 23, 49, 5, 286, DateTimeKind.Utc).AddTicks(323), new DateTime(2024, 8, 17, 3, 49, 5, 286, DateTimeKind.Local).AddTicks(215) });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: 2002,
                columns: new[] { "ConcurrencyStamp", "CreatedTime", "LastUpdatedTime", "RefreshTokenCreateTime" },
                values: new object[] { "1fd55fc2-d194-406b-980d-a8cdda72a70c", new DateTime(2024, 8, 16, 23, 49, 5, 286, DateTimeKind.Utc).AddTicks(356), new DateTime(2024, 8, 16, 23, 49, 5, 286, DateTimeKind.Utc).AddTicks(357), new DateTime(2024, 8, 17, 3, 49, 5, 286, DateTimeKind.Local).AddTicks(349) });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: 2003,
                columns: new[] { "ConcurrencyStamp", "CreatedTime", "LastUpdatedTime", "RefreshTokenCreateTime" },
                values: new object[] { "4384ed0f-3cef-4cc2-b7fa-5309064ba5a2", new DateTime(2024, 8, 16, 23, 49, 5, 286, DateTimeKind.Utc).AddTicks(385), new DateTime(2024, 8, 16, 23, 49, 5, 286, DateTimeKind.Utc).AddTicks(386), new DateTime(2024, 8, 17, 3, 49, 5, 286, DateTimeKind.Local).AddTicks(366) });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: 2004,
                columns: new[] { "ConcurrencyStamp", "CreatedTime", "LastUpdatedTime", "RefreshTokenCreateTime" },
                values: new object[] { "58ddf741-4ab7-4991-8208-b5781b8bbfe4", new DateTime(2024, 8, 16, 23, 49, 5, 286, DateTimeKind.Utc).AddTicks(400), new DateTime(2024, 8, 16, 23, 49, 5, 286, DateTimeKind.Utc).AddTicks(400), new DateTime(2024, 8, 17, 3, 49, 5, 286, DateTimeKind.Local).AddTicks(395) });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: 2005,
                columns: new[] { "ConcurrencyStamp", "CreatedTime", "LastUpdatedTime", "RefreshTokenCreateTime" },
                values: new object[] { "1ab28c71-fdf3-4730-95c7-6fea3e3b6a45", new DateTime(2024, 8, 16, 23, 49, 5, 286, DateTimeKind.Utc).AddTicks(413), new DateTime(2024, 8, 16, 23, 49, 5, 286, DateTimeKind.Utc).AddTicks(413), new DateTime(2024, 8, 17, 3, 49, 5, 286, DateTimeKind.Local).AddTicks(408) });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: 2006,
                columns: new[] { "ConcurrencyStamp", "CreatedTime", "LastUpdatedTime", "RefreshTokenCreateTime" },
                values: new object[] { "abfeb5ac-6ff4-4a2c-962f-a80e6d453aa2", new DateTime(2024, 8, 16, 23, 49, 5, 286, DateTimeKind.Utc).AddTicks(429), new DateTime(2024, 8, 16, 23, 49, 5, 286, DateTimeKind.Utc).AddTicks(430), new DateTime(2024, 8, 17, 3, 49, 5, 286, DateTimeKind.Local).AddTicks(424) });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: 2007,
                columns: new[] { "ConcurrencyStamp", "CreatedTime", "LastUpdatedTime", "RefreshTokenCreateTime" },
                values: new object[] { "6638354b-e840-4b41-8a05-15e4a4a2d69a", new DateTime(2024, 8, 16, 23, 49, 5, 286, DateTimeKind.Utc).AddTicks(442), new DateTime(2024, 8, 16, 23, 49, 5, 286, DateTimeKind.Utc).AddTicks(443), new DateTime(2024, 8, 17, 3, 49, 5, 286, DateTimeKind.Local).AddTicks(437) });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: 2008,
                columns: new[] { "ConcurrencyStamp", "CreatedTime", "LastUpdatedTime", "RefreshTokenCreateTime" },
                values: new object[] { "0c5412b6-8ac6-48d5-89a0-7313cef064f4", new DateTime(2024, 8, 16, 23, 49, 5, 286, DateTimeKind.Utc).AddTicks(500), new DateTime(2024, 8, 16, 23, 49, 5, 286, DateTimeKind.Utc).AddTicks(501), new DateTime(2024, 8, 17, 3, 49, 5, 286, DateTimeKind.Local).AddTicks(450) });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: 2009,
                columns: new[] { "ConcurrencyStamp", "CreatedTime", "LastUpdatedTime", "RefreshTokenCreateTime" },
                values: new object[] { "c3bb1607-5117-48bd-875b-89406d3e5ff7", new DateTime(2024, 8, 16, 23, 49, 5, 286, DateTimeKind.Utc).AddTicks(514), new DateTime(2024, 8, 16, 23, 49, 5, 286, DateTimeKind.Utc).AddTicks(515), new DateTime(2024, 8, 17, 3, 49, 5, 286, DateTimeKind.Local).AddTicks(509) });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: 2010,
                columns: new[] { "ConcurrencyStamp", "CreatedTime", "LastUpdatedTime", "RefreshTokenCreateTime" },
                values: new object[] { "3d8a66e8-b900-4bb6-a425-c6cd7d4aca7b", new DateTime(2024, 8, 16, 23, 49, 5, 286, DateTimeKind.Utc).AddTicks(530), new DateTime(2024, 8, 16, 23, 49, 5, 286, DateTimeKind.Utc).AddTicks(531), new DateTime(2024, 8, 17, 3, 49, 5, 286, DateTimeKind.Local).AddTicks(524) });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: 2011,
                columns: new[] { "ConcurrencyStamp", "CreatedTime", "LastUpdatedTime", "RefreshTokenCreateTime" },
                values: new object[] { "83ba7c9a-c830-4d86-9072-9a22534c8c33", new DateTime(2024, 8, 16, 23, 49, 5, 286, DateTimeKind.Utc).AddTicks(550), new DateTime(2024, 8, 16, 23, 49, 5, 286, DateTimeKind.Utc).AddTicks(551), new DateTime(2024, 8, 17, 3, 49, 5, 286, DateTimeKind.Local).AddTicks(540) });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: 2012,
                columns: new[] { "ConcurrencyStamp", "CreatedTime", "LastUpdatedTime", "RefreshTokenCreateTime" },
                values: new object[] { "6209a90c-aa84-42c7-830d-cce90cac65b6", new DateTime(2024, 8, 16, 23, 49, 5, 286, DateTimeKind.Utc).AddTicks(564), new DateTime(2024, 8, 16, 23, 49, 5, 286, DateTimeKind.Utc).AddTicks(565), new DateTime(2024, 8, 17, 3, 49, 5, 286, DateTimeKind.Local).AddTicks(559) });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: 2013,
                columns: new[] { "ConcurrencyStamp", "CreatedTime", "LastUpdatedTime", "RefreshTokenCreateTime" },
                values: new object[] { "dad9500e-02d9-4c39-b2e6-184a206049f4", new DateTime(2024, 8, 16, 23, 49, 5, 286, DateTimeKind.Utc).AddTicks(577), new DateTime(2024, 8, 16, 23, 49, 5, 286, DateTimeKind.Utc).AddTicks(578), new DateTime(2024, 8, 17, 3, 49, 5, 286, DateTimeKind.Local).AddTicks(572) });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: 2014,
                columns: new[] { "ConcurrencyStamp", "CreatedTime", "LastUpdatedTime", "RefreshTokenCreateTime" },
                values: new object[] { "8c659428-356d-4d8b-9720-1e5ef04695ec", new DateTime(2024, 8, 16, 23, 49, 5, 286, DateTimeKind.Utc).AddTicks(590), new DateTime(2024, 8, 16, 23, 49, 5, 286, DateTimeKind.Utc).AddTicks(590), new DateTime(2024, 8, 17, 3, 49, 5, 286, DateTimeKind.Local).AddTicks(585) });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: 2015,
                columns: new[] { "ConcurrencyStamp", "CreatedTime", "LastUpdatedTime", "RefreshTokenCreateTime" },
                values: new object[] { "3be77fff-906c-4de6-801b-6620f93493ea", new DateTime(2024, 8, 16, 23, 49, 5, 286, DateTimeKind.Utc).AddTicks(604), new DateTime(2024, 8, 16, 23, 49, 5, 286, DateTimeKind.Utc).AddTicks(605), new DateTime(2024, 8, 17, 3, 49, 5, 286, DateTimeKind.Local).AddTicks(599) });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: 2016,
                columns: new[] { "ConcurrencyStamp", "CreatedTime", "LastUpdatedTime", "RefreshTokenCreateTime" },
                values: new object[] { "3f4714fa-0391-4647-ac52-3797edfb7693", new DateTime(2024, 8, 16, 23, 49, 5, 286, DateTimeKind.Utc).AddTicks(617), new DateTime(2024, 8, 16, 23, 49, 5, 286, DateTimeKind.Utc).AddTicks(618), new DateTime(2024, 8, 17, 3, 49, 5, 286, DateTimeKind.Local).AddTicks(612) });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: 2017,
                columns: new[] { "ConcurrencyStamp", "CreatedTime", "LastUpdatedTime", "RefreshTokenCreateTime" },
                values: new object[] { "e2518270-6c23-435e-a0b0-319a9d21c3c2", new DateTime(2024, 8, 16, 23, 49, 5, 286, DateTimeKind.Utc).AddTicks(668), new DateTime(2024, 8, 16, 23, 49, 5, 286, DateTimeKind.Utc).AddTicks(668), new DateTime(2024, 8, 17, 3, 49, 5, 286, DateTimeKind.Local).AddTicks(662) });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: 2018,
                columns: new[] { "ConcurrencyStamp", "CreatedTime", "LastUpdatedTime", "RefreshTokenCreateTime" },
                values: new object[] { "cdc09b82-dca3-47b5-be7f-36dc015af0db", new DateTime(2024, 8, 16, 23, 49, 5, 286, DateTimeKind.Utc).AddTicks(683), new DateTime(2024, 8, 16, 23, 49, 5, 286, DateTimeKind.Utc).AddTicks(684), new DateTime(2024, 8, 17, 3, 49, 5, 286, DateTimeKind.Local).AddTicks(678) });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: 2019,
                columns: new[] { "ConcurrencyStamp", "CreatedTime", "LastUpdatedTime", "RefreshTokenCreateTime" },
                values: new object[] { "561d6276-ee8a-4b00-b3b9-38a3db494b1b", new DateTime(2024, 8, 16, 23, 49, 5, 286, DateTimeKind.Utc).AddTicks(701), new DateTime(2024, 8, 16, 23, 49, 5, 286, DateTimeKind.Utc).AddTicks(701), new DateTime(2024, 8, 17, 3, 49, 5, 286, DateTimeKind.Local).AddTicks(692) });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: 2020,
                columns: new[] { "ConcurrencyStamp", "CreatedTime", "LastUpdatedTime", "RefreshTokenCreateTime" },
                values: new object[] { "ec71e5d2-dbf4-4351-be8f-e56c0930610b", new DateTime(2024, 8, 16, 23, 49, 5, 286, DateTimeKind.Utc).AddTicks(715), new DateTime(2024, 8, 16, 23, 49, 5, 286, DateTimeKind.Utc).AddTicks(715), new DateTime(2024, 8, 17, 3, 49, 5, 286, DateTimeKind.Local).AddTicks(709) });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: 2021,
                columns: new[] { "ConcurrencyStamp", "CreatedTime", "LastUpdatedTime", "RefreshTokenCreateTime" },
                values: new object[] { "484a5565-156f-45ae-99a6-159eec196270", new DateTime(2024, 8, 16, 23, 49, 5, 286, DateTimeKind.Utc).AddTicks(728), new DateTime(2024, 8, 16, 23, 49, 5, 286, DateTimeKind.Utc).AddTicks(729), new DateTime(2024, 8, 17, 3, 49, 5, 286, DateTimeKind.Local).AddTicks(723) });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: 2022,
                columns: new[] { "ConcurrencyStamp", "CreatedTime", "LastUpdatedTime", "RefreshTokenCreateTime" },
                values: new object[] { "5d3175f1-c272-455e-a4d5-52cf26068c3d", new DateTime(2024, 8, 16, 23, 49, 5, 286, DateTimeKind.Utc).AddTicks(747), new DateTime(2024, 8, 16, 23, 49, 5, 286, DateTimeKind.Utc).AddTicks(748), new DateTime(2024, 8, 17, 3, 49, 5, 286, DateTimeKind.Local).AddTicks(742) });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: 2023,
                columns: new[] { "ConcurrencyStamp", "CreatedTime", "LastUpdatedTime", "RefreshTokenCreateTime" },
                values: new object[] { "08600ecc-3b9c-40d3-a8a4-5da72ce35cd1", new DateTime(2024, 8, 16, 23, 49, 5, 286, DateTimeKind.Utc).AddTicks(762), new DateTime(2024, 8, 16, 23, 49, 5, 286, DateTimeKind.Utc).AddTicks(762), new DateTime(2024, 8, 17, 3, 49, 5, 286, DateTimeKind.Local).AddTicks(757) });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: 2024,
                columns: new[] { "ConcurrencyStamp", "CreatedTime", "LastUpdatedTime", "RefreshTokenCreateTime" },
                values: new object[] { "09dee302-c5d9-4466-8bd1-dd91db3ab384", new DateTime(2024, 8, 16, 23, 49, 5, 286, DateTimeKind.Utc).AddTicks(775), new DateTime(2024, 8, 16, 23, 49, 5, 286, DateTimeKind.Utc).AddTicks(775), new DateTime(2024, 8, 17, 3, 49, 5, 286, DateTimeKind.Local).AddTicks(770) });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: 2025,
                columns: new[] { "ConcurrencyStamp", "CreatedTime", "LastUpdatedTime", "RefreshTokenCreateTime" },
                values: new object[] { "c3c2a899-302e-4353-b151-5aae0ad27992", new DateTime(2024, 8, 16, 23, 49, 5, 286, DateTimeKind.Utc).AddTicks(787), new DateTime(2024, 8, 16, 23, 49, 5, 286, DateTimeKind.Utc).AddTicks(788), new DateTime(2024, 8, 17, 3, 49, 5, 286, DateTimeKind.Local).AddTicks(782) });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: 2026,
                columns: new[] { "ConcurrencyStamp", "CreatedTime", "LastUpdatedTime", "RefreshTokenCreateTime" },
                values: new object[] { "66159b02-5617-435c-9896-9764657b2e04", new DateTime(2024, 8, 16, 23, 49, 5, 286, DateTimeKind.Utc).AddTicks(837), new DateTime(2024, 8, 16, 23, 49, 5, 286, DateTimeKind.Utc).AddTicks(837), new DateTime(2024, 8, 17, 3, 49, 5, 286, DateTimeKind.Local).AddTicks(832) });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: 2027,
                columns: new[] { "ConcurrencyStamp", "CreatedTime", "LastUpdatedTime", "RefreshTokenCreateTime" },
                values: new object[] { "38cf7010-c21a-4e0f-a2a0-c11b91503bab", new DateTime(2024, 8, 16, 23, 49, 5, 286, DateTimeKind.Utc).AddTicks(854), new DateTime(2024, 8, 16, 23, 49, 5, 286, DateTimeKind.Utc).AddTicks(855), new DateTime(2024, 8, 17, 3, 49, 5, 286, DateTimeKind.Local).AddTicks(845) });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: 2028,
                columns: new[] { "ConcurrencyStamp", "CreatedTime", "LastUpdatedTime", "RefreshTokenCreateTime" },
                values: new object[] { "f9d98b47-8c64-4d1f-a0cb-1e3bb0e2aeff", new DateTime(2024, 8, 16, 23, 49, 5, 286, DateTimeKind.Utc).AddTicks(1033), new DateTime(2024, 8, 16, 23, 49, 5, 286, DateTimeKind.Utc).AddTicks(1035), new DateTime(2024, 8, 17, 3, 49, 5, 286, DateTimeKind.Local).AddTicks(1016) });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: 2029,
                columns: new[] { "ConcurrencyStamp", "CreatedTime", "LastUpdatedTime", "RefreshTokenCreateTime" },
                values: new object[] { "ef03c792-a597-4d53-867f-460265103477", new DateTime(2024, 8, 16, 23, 49, 5, 286, DateTimeKind.Utc).AddTicks(1072), new DateTime(2024, 8, 16, 23, 49, 5, 286, DateTimeKind.Utc).AddTicks(1073), new DateTime(2024, 8, 17, 3, 49, 5, 286, DateTimeKind.Local).AddTicks(1057) });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: 2030,
                columns: new[] { "ConcurrencyStamp", "CreatedTime", "LastUpdatedTime", "RefreshTokenCreateTime" },
                values: new object[] { "1cc0a0c0-1230-4dd5-9ae3-51912f08a930", new DateTime(2024, 8, 16, 23, 49, 5, 286, DateTimeKind.Utc).AddTicks(1247), new DateTime(2024, 8, 16, 23, 49, 5, 286, DateTimeKind.Utc).AddTicks(1247), new DateTime(2024, 8, 17, 3, 49, 5, 286, DateTimeKind.Local).AddTicks(1241) });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: 2031,
                columns: new[] { "ConcurrencyStamp", "CreatedTime", "LastUpdatedTime", "RefreshTokenCreateTime" },
                values: new object[] { "c4d11013-2e2f-4338-92df-75236be3c66d", new DateTime(2024, 8, 16, 23, 49, 5, 286, DateTimeKind.Utc).AddTicks(1259), new DateTime(2024, 8, 16, 23, 49, 5, 286, DateTimeKind.Utc).AddTicks(1260), new DateTime(2024, 8, 17, 3, 49, 5, 286, DateTimeKind.Local).AddTicks(1254) });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: 2032,
                columns: new[] { "ConcurrencyStamp", "CreatedTime", "LastUpdatedTime", "RefreshTokenCreateTime" },
                values: new object[] { "87d65948-e1b6-4d2d-8050-ba171e3b8f54", new DateTime(2024, 8, 16, 23, 49, 5, 286, DateTimeKind.Utc).AddTicks(1273), new DateTime(2024, 8, 16, 23, 49, 5, 286, DateTimeKind.Utc).AddTicks(1273), new DateTime(2024, 8, 17, 3, 49, 5, 286, DateTimeKind.Local).AddTicks(1268) });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: 2033,
                columns: new[] { "ConcurrencyStamp", "CreatedTime", "LastUpdatedTime", "RefreshTokenCreateTime" },
                values: new object[] { "26a976df-bafe-4fee-8838-6f986bc3df6f", new DateTime(2024, 8, 16, 23, 49, 5, 286, DateTimeKind.Utc).AddTicks(1286), new DateTime(2024, 8, 16, 23, 49, 5, 286, DateTimeKind.Utc).AddTicks(1286), new DateTime(2024, 8, 17, 3, 49, 5, 286, DateTimeKind.Local).AddTicks(1281) });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: 2034,
                columns: new[] { "ConcurrencyStamp", "CreatedTime", "LastUpdatedTime", "RefreshTokenCreateTime" },
                values: new object[] { "f3321992-1b7b-48d1-8f39-03bd7d7b2a79", new DateTime(2024, 8, 16, 23, 49, 5, 286, DateTimeKind.Utc).AddTicks(1499), new DateTime(2024, 8, 16, 23, 49, 5, 286, DateTimeKind.Utc).AddTicks(1501), new DateTime(2024, 8, 17, 3, 49, 5, 286, DateTimeKind.Local).AddTicks(1480) });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: 2035,
                columns: new[] { "ConcurrencyStamp", "CreatedTime", "LastUpdatedTime", "RefreshTokenCreateTime" },
                values: new object[] { "e160a811-a75f-4d19-9f38-8fa0be5f0d7f", new DateTime(2024, 8, 16, 23, 49, 5, 286, DateTimeKind.Utc).AddTicks(1549), new DateTime(2024, 8, 16, 23, 49, 5, 286, DateTimeKind.Utc).AddTicks(1551), new DateTime(2024, 8, 17, 3, 49, 5, 286, DateTimeKind.Local).AddTicks(1523) });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: 2036,
                columns: new[] { "ConcurrencyStamp", "CreatedTime", "LastUpdatedTime", "RefreshTokenCreateTime" },
                values: new object[] { "2cad6c71-8b1c-4958-9f29-d76dbbb169f3", new DateTime(2024, 8, 16, 23, 49, 5, 286, DateTimeKind.Utc).AddTicks(1724), new DateTime(2024, 8, 16, 23, 49, 5, 286, DateTimeKind.Utc).AddTicks(1725), new DateTime(2024, 8, 17, 3, 49, 5, 286, DateTimeKind.Local).AddTicks(1719) });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: 2037,
                columns: new[] { "ConcurrencyStamp", "CreatedTime", "LastUpdatedTime", "RefreshTokenCreateTime" },
                values: new object[] { "c8089cea-407f-48e3-9d1a-d937e7bd9330", new DateTime(2024, 8, 16, 23, 49, 5, 286, DateTimeKind.Utc).AddTicks(1738), new DateTime(2024, 8, 16, 23, 49, 5, 286, DateTimeKind.Utc).AddTicks(1738), new DateTime(2024, 8, 17, 3, 49, 5, 286, DateTimeKind.Local).AddTicks(1733) });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: 2038,
                columns: new[] { "ConcurrencyStamp", "CreatedTime", "LastUpdatedTime", "RefreshTokenCreateTime" },
                values: new object[] { "9db7ddb2-af2a-4c5a-8182-6b7f953dc973", new DateTime(2024, 8, 16, 23, 49, 5, 286, DateTimeKind.Utc).AddTicks(1751), new DateTime(2024, 8, 16, 23, 49, 5, 286, DateTimeKind.Utc).AddTicks(1751), new DateTime(2024, 8, 17, 3, 49, 5, 286, DateTimeKind.Local).AddTicks(1746) });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: 2039,
                columns: new[] { "ConcurrencyStamp", "CreatedTime", "LastUpdatedTime", "RefreshTokenCreateTime" },
                values: new object[] { "5cdce083-c44e-4697-bc61-9b1b94d641c8", new DateTime(2024, 8, 16, 23, 49, 5, 286, DateTimeKind.Utc).AddTicks(1764), new DateTime(2024, 8, 16, 23, 49, 5, 286, DateTimeKind.Utc).AddTicks(1765), new DateTime(2024, 8, 17, 3, 49, 5, 286, DateTimeKind.Local).AddTicks(1759) });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: 2040,
                columns: new[] { "ConcurrencyStamp", "CreatedTime", "LastUpdatedTime", "RefreshTokenCreateTime" },
                values: new object[] { "edccf5c1-55cc-494d-aa2a-2186569e4acb", new DateTime(2024, 8, 16, 23, 49, 5, 286, DateTimeKind.Utc).AddTicks(1778), new DateTime(2024, 8, 16, 23, 49, 5, 286, DateTimeKind.Utc).AddTicks(1779), new DateTime(2024, 8, 17, 3, 49, 5, 286, DateTimeKind.Local).AddTicks(1773) });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: 2041,
                columns: new[] { "ConcurrencyStamp", "CreatedTime", "LastUpdatedTime", "RefreshTokenCreateTime" },
                values: new object[] { "47cfd453-395e-44fc-bba4-10aa3e8b57ae", new DateTime(2024, 8, 16, 23, 49, 5, 286, DateTimeKind.Utc).AddTicks(1791), new DateTime(2024, 8, 16, 23, 49, 5, 286, DateTimeKind.Utc).AddTicks(1792), new DateTime(2024, 8, 17, 3, 49, 5, 286, DateTimeKind.Local).AddTicks(1786) });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: 2042,
                columns: new[] { "ConcurrencyStamp", "CreatedTime", "LastUpdatedTime", "RefreshTokenCreateTime" },
                values: new object[] { "61631bb3-4a05-499a-9982-0247cf9f7028", new DateTime(2024, 8, 16, 23, 49, 5, 286, DateTimeKind.Utc).AddTicks(1810), new DateTime(2024, 8, 16, 23, 49, 5, 286, DateTimeKind.Utc).AddTicks(1811), new DateTime(2024, 8, 17, 3, 49, 5, 286, DateTimeKind.Local).AddTicks(1805) });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: 2043,
                columns: new[] { "ConcurrencyStamp", "CreatedTime", "LastUpdatedTime", "RefreshTokenCreateTime" },
                values: new object[] { "2894274d-de18-47f3-aa10-7aad289fcdb1", new DateTime(2024, 8, 16, 23, 49, 5, 286, DateTimeKind.Utc).AddTicks(1864), new DateTime(2024, 8, 16, 23, 49, 5, 286, DateTimeKind.Utc).AddTicks(1865), new DateTime(2024, 8, 17, 3, 49, 5, 286, DateTimeKind.Local).AddTicks(1855) });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: 2044,
                columns: new[] { "ConcurrencyStamp", "CreatedTime", "LastUpdatedTime", "RefreshTokenCreateTime" },
                values: new object[] { "f10fb501-d926-42bb-970c-55767fe6d017", new DateTime(2024, 8, 16, 23, 49, 5, 286, DateTimeKind.Utc).AddTicks(1879), new DateTime(2024, 8, 16, 23, 49, 5, 286, DateTimeKind.Utc).AddTicks(1879), new DateTime(2024, 8, 17, 3, 49, 5, 286, DateTimeKind.Local).AddTicks(1874) });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: 2045,
                columns: new[] { "ConcurrencyStamp", "CreatedTime", "LastUpdatedTime", "RefreshTokenCreateTime" },
                values: new object[] { "990d6e0f-a467-4792-a1aa-cbf761a63376", new DateTime(2024, 8, 16, 23, 49, 5, 286, DateTimeKind.Utc).AddTicks(1892), new DateTime(2024, 8, 16, 23, 49, 5, 286, DateTimeKind.Utc).AddTicks(1892), new DateTime(2024, 8, 17, 3, 49, 5, 286, DateTimeKind.Local).AddTicks(1887) });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: 2046,
                columns: new[] { "ConcurrencyStamp", "CreatedTime", "LastUpdatedTime", "RefreshTokenCreateTime" },
                values: new object[] { "d60cfa3e-3cba-4d86-a51e-d67639c370cf", new DateTime(2024, 8, 16, 23, 49, 5, 286, DateTimeKind.Utc).AddTicks(1905), new DateTime(2024, 8, 16, 23, 49, 5, 286, DateTimeKind.Utc).AddTicks(1905), new DateTime(2024, 8, 17, 3, 49, 5, 286, DateTimeKind.Local).AddTicks(1900) });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: 2047,
                columns: new[] { "ConcurrencyStamp", "CreatedTime", "LastUpdatedTime", "RefreshTokenCreateTime" },
                values: new object[] { "fbcefe60-7ed6-4afe-949f-adcd29f71f85", new DateTime(2024, 8, 16, 23, 49, 5, 286, DateTimeKind.Utc).AddTicks(1919), new DateTime(2024, 8, 16, 23, 49, 5, 286, DateTimeKind.Utc).AddTicks(1919), new DateTime(2024, 8, 17, 3, 49, 5, 286, DateTimeKind.Local).AddTicks(1913) });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: 2048,
                columns: new[] { "ConcurrencyStamp", "CreatedTime", "LastUpdatedTime", "RefreshTokenCreateTime" },
                values: new object[] { "766f6b64-9c42-421d-8acf-ede1e6f3e076", new DateTime(2024, 8, 16, 23, 49, 5, 286, DateTimeKind.Utc).AddTicks(1932), new DateTime(2024, 8, 16, 23, 49, 5, 286, DateTimeKind.Utc).AddTicks(1932), new DateTime(2024, 8, 17, 3, 49, 5, 286, DateTimeKind.Local).AddTicks(1927) });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: 2049,
                columns: new[] { "ConcurrencyStamp", "CreatedTime", "LastUpdatedTime", "RefreshTokenCreateTime" },
                values: new object[] { "37053795-31b8-4242-892a-21aa053344cd", new DateTime(2024, 8, 16, 23, 49, 5, 286, DateTimeKind.Utc).AddTicks(1945), new DateTime(2024, 8, 16, 23, 49, 5, 286, DateTimeKind.Utc).AddTicks(1945), new DateTime(2024, 8, 17, 3, 49, 5, 286, DateTimeKind.Local).AddTicks(1939) });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: 2050,
                columns: new[] { "ConcurrencyStamp", "CreatedTime", "LastUpdatedTime", "RefreshTokenCreateTime" },
                values: new object[] { "3747f2f1-c72d-40c5-9b03-6969d451a818", new DateTime(2024, 8, 16, 23, 49, 5, 286, DateTimeKind.Utc).AddTicks(1958), new DateTime(2024, 8, 16, 23, 49, 5, 286, DateTimeKind.Utc).AddTicks(1959), new DateTime(2024, 8, 17, 3, 49, 5, 286, DateTimeKind.Local).AddTicks(1953) });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: 2051,
                columns: new[] { "ConcurrencyStamp", "CreatedTime", "LastUpdatedTime", "RefreshTokenCreateTime" },
                values: new object[] { "9a287b39-e689-4e3b-84bd-ab48c56356a6", new DateTime(2024, 8, 16, 23, 49, 5, 286, DateTimeKind.Utc).AddTicks(1976), new DateTime(2024, 8, 16, 23, 49, 5, 286, DateTimeKind.Utc).AddTicks(1976), new DateTime(2024, 8, 17, 3, 49, 5, 286, DateTimeKind.Local).AddTicks(1967) });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: 2052,
                columns: new[] { "ConcurrencyStamp", "CreatedTime", "LastUpdatedTime", "RefreshTokenCreateTime" },
                values: new object[] { "dd8beb63-c54c-42f2-8296-36a1cacca8d3", new DateTime(2024, 8, 16, 23, 49, 5, 286, DateTimeKind.Utc).AddTicks(2013), new DateTime(2024, 8, 16, 23, 49, 5, 286, DateTimeKind.Utc).AddTicks(2014), new DateTime(2024, 8, 17, 3, 49, 5, 286, DateTimeKind.Local).AddTicks(2008) });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: 2053,
                columns: new[] { "ConcurrencyStamp", "CreatedTime", "LastUpdatedTime", "RefreshTokenCreateTime" },
                values: new object[] { "ddb6b5d1-7f9f-465a-8dba-fac17163dd71", new DateTime(2024, 8, 16, 23, 49, 5, 286, DateTimeKind.Utc).AddTicks(2026), new DateTime(2024, 8, 16, 23, 49, 5, 286, DateTimeKind.Utc).AddTicks(2027), new DateTime(2024, 8, 17, 3, 49, 5, 286, DateTimeKind.Local).AddTicks(2021) });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: 2054,
                columns: new[] { "ConcurrencyStamp", "CreatedTime", "LastUpdatedTime", "RefreshTokenCreateTime" },
                values: new object[] { "f79e037b-6de3-4d8b-9439-11fd22cc61a8", new DateTime(2024, 8, 16, 23, 49, 5, 286, DateTimeKind.Utc).AddTicks(2039), new DateTime(2024, 8, 16, 23, 49, 5, 286, DateTimeKind.Utc).AddTicks(2040), new DateTime(2024, 8, 17, 3, 49, 5, 286, DateTimeKind.Local).AddTicks(2034) });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: 2055,
                columns: new[] { "ConcurrencyStamp", "CreatedTime", "LastUpdatedTime", "RefreshTokenCreateTime" },
                values: new object[] { "cec5a612-4faf-4520-8cec-d98077a65fd9", new DateTime(2024, 8, 16, 23, 49, 5, 286, DateTimeKind.Utc).AddTicks(2053), new DateTime(2024, 8, 16, 23, 49, 5, 286, DateTimeKind.Utc).AddTicks(2053), new DateTime(2024, 8, 17, 3, 49, 5, 286, DateTimeKind.Local).AddTicks(2047) });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: 2056,
                columns: new[] { "ConcurrencyStamp", "CreatedTime", "LastUpdatedTime", "RefreshTokenCreateTime" },
                values: new object[] { "43839435-9cf5-459b-9789-f9443adba8bb", new DateTime(2024, 8, 16, 23, 49, 5, 286, DateTimeKind.Utc).AddTicks(2066), new DateTime(2024, 8, 16, 23, 49, 5, 286, DateTimeKind.Utc).AddTicks(2066), new DateTime(2024, 8, 17, 3, 49, 5, 286, DateTimeKind.Local).AddTicks(2061) });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: 2057,
                columns: new[] { "ConcurrencyStamp", "CreatedTime", "LastUpdatedTime", "RefreshTokenCreateTime" },
                values: new object[] { "f69a4200-6b0a-425f-9136-7008aa96cecd", new DateTime(2024, 8, 16, 23, 49, 5, 286, DateTimeKind.Utc).AddTicks(2079), new DateTime(2024, 8, 16, 23, 49, 5, 286, DateTimeKind.Utc).AddTicks(2080), new DateTime(2024, 8, 17, 3, 49, 5, 286, DateTimeKind.Local).AddTicks(2074) });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: 2058,
                columns: new[] { "ConcurrencyStamp", "CreatedTime", "LastUpdatedTime", "RefreshTokenCreateTime" },
                values: new object[] { "36d196fc-db5e-438c-9843-f52e14c96299", new DateTime(2024, 8, 16, 23, 49, 5, 286, DateTimeKind.Utc).AddTicks(2092), new DateTime(2024, 8, 16, 23, 49, 5, 286, DateTimeKind.Utc).AddTicks(2093), new DateTime(2024, 8, 17, 3, 49, 5, 286, DateTimeKind.Local).AddTicks(2087) });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: 2059,
                columns: new[] { "ConcurrencyStamp", "CreatedTime", "LastUpdatedTime", "RefreshTokenCreateTime" },
                values: new object[] { "3a14bed2-bc7d-4aaa-9244-11c6aa7e19d8", new DateTime(2024, 8, 16, 23, 49, 5, 286, DateTimeKind.Utc).AddTicks(2109), new DateTime(2024, 8, 16, 23, 49, 5, 286, DateTimeKind.Utc).AddTicks(2109), new DateTime(2024, 8, 17, 3, 49, 5, 286, DateTimeKind.Local).AddTicks(2100) });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: 2060,
                columns: new[] { "ConcurrencyStamp", "CreatedTime", "LastUpdatedTime", "RefreshTokenCreateTime" },
                values: new object[] { "555943ff-6ab3-4247-a5af-7ec155fa22ad", new DateTime(2024, 8, 16, 23, 49, 5, 286, DateTimeKind.Utc).AddTicks(2121), new DateTime(2024, 8, 16, 23, 49, 5, 286, DateTimeKind.Utc).AddTicks(2122), new DateTime(2024, 8, 17, 3, 49, 5, 286, DateTimeKind.Local).AddTicks(2116) });

            migrationBuilder.InsertData(
                table: "PetTypes",
                columns: new[] { "Id", "CreatedTime", "IsDeleted", "LastUpdatedTime", "TypeName" },
                values: new object[,]
                {
                    { 1, new DateTime(2024, 8, 17, 3, 49, 5, 277, DateTimeKind.Local).AddTicks(1924), false, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "Dogs" },
                    { 2, new DateTime(2024, 8, 17, 3, 49, 5, 277, DateTimeKind.Local).AddTicks(1936), false, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "Cats" },
                    { 3, new DateTime(2024, 8, 17, 3, 49, 5, 277, DateTimeKind.Local).AddTicks(1938), false, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "Birds" },
                    { 4, new DateTime(2024, 8, 17, 3, 49, 5, 277, DateTimeKind.Local).AddTicks(1939), false, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "Reptiles" },
                    { 5, new DateTime(2024, 8, 17, 3, 49, 5, 277, DateTimeKind.Local).AddTicks(1940), false, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "Rodents" },
                    { 6, new DateTime(2024, 8, 17, 3, 49, 5, 277, DateTimeKind.Local).AddTicks(1941), false, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "Fish" },
                    { 7, new DateTime(2024, 8, 17, 3, 49, 5, 277, DateTimeKind.Local).AddTicks(1942), false, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "Farm Animals" },
                    { 8, new DateTime(2024, 8, 17, 3, 49, 5, 277, DateTimeKind.Local).AddTicks(1943), false, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "Exotic Pets" }
                });

            migrationBuilder.InsertData(
                table: "Breeds",
                columns: new[] { "Id", "BreedName", "CreatedTime", "IsDeleted", "LastUpdatedTime", "PetTypeId" },
                values: new object[,]
                {
                    { 1, "Labrador Retriever", new DateTime(2024, 8, 17, 3, 49, 5, 277, DateTimeKind.Local).AddTicks(4615), false, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 1 },
                    { 2, "German Shepherd", new DateTime(2024, 8, 17, 3, 49, 5, 277, DateTimeKind.Local).AddTicks(4622), false, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 1 },
                    { 3, "Golden Retriever", new DateTime(2024, 8, 17, 3, 49, 5, 277, DateTimeKind.Local).AddTicks(4623), false, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 1 },
                    { 4, "French Bulldog", new DateTime(2024, 8, 17, 3, 49, 5, 277, DateTimeKind.Local).AddTicks(4625), false, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 1 },
                    { 5, "Bulldog", new DateTime(2024, 8, 17, 3, 49, 5, 277, DateTimeKind.Local).AddTicks(4626), false, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 1 },
                    { 6, "Beagle", new DateTime(2024, 8, 17, 3, 49, 5, 277, DateTimeKind.Local).AddTicks(4628), false, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 1 },
                    { 7, "Poodle", new DateTime(2024, 8, 17, 3, 49, 5, 277, DateTimeKind.Local).AddTicks(4629), false, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 1 },
                    { 8, "Rottweiler", new DateTime(2024, 8, 17, 3, 49, 5, 277, DateTimeKind.Local).AddTicks(4631), false, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 1 },
                    { 9, "Yorkshire Terrier", new DateTime(2024, 8, 17, 3, 49, 5, 277, DateTimeKind.Local).AddTicks(4632), false, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 1 },
                    { 10, "Boxer", new DateTime(2024, 8, 17, 3, 49, 5, 277, DateTimeKind.Local).AddTicks(4634), false, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 1 },
                    { 11, "Dachshund", new DateTime(2024, 8, 17, 3, 49, 5, 277, DateTimeKind.Local).AddTicks(4635), false, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 1 },
                    { 12, "Pembroke Welsh Corgi", new DateTime(2024, 8, 17, 3, 49, 5, 277, DateTimeKind.Local).AddTicks(4636), false, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 1 },
                    { 13, "Doberman Pinscher", new DateTime(2024, 8, 17, 3, 49, 5, 277, DateTimeKind.Local).AddTicks(4637), false, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 1 },
                    { 14, "Shih Tzu", new DateTime(2024, 8, 17, 3, 49, 5, 277, DateTimeKind.Local).AddTicks(4639), false, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 1 },
                    { 15, "Siberian Husky", new DateTime(2024, 8, 17, 3, 49, 5, 277, DateTimeKind.Local).AddTicks(4640), false, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 1 },
                    { 16, "Great Dane", new DateTime(2024, 8, 17, 3, 49, 5, 277, DateTimeKind.Local).AddTicks(4642), false, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 1 },
                    { 17, "Border Collie", new DateTime(2024, 8, 17, 3, 49, 5, 277, DateTimeKind.Local).AddTicks(4643), false, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 1 },
                    { 18, "Chihuahua", new DateTime(2024, 8, 17, 3, 49, 5, 277, DateTimeKind.Local).AddTicks(4645), false, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 1 },
                    { 19, "Boston Terrier", new DateTime(2024, 8, 17, 3, 49, 5, 277, DateTimeKind.Local).AddTicks(4647), false, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 1 },
                    { 20, "Australian Shepherd", new DateTime(2024, 8, 17, 3, 49, 5, 277, DateTimeKind.Local).AddTicks(4648), false, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 1 },
                    { 21, "Pug", new DateTime(2024, 8, 17, 3, 49, 5, 277, DateTimeKind.Local).AddTicks(4649), false, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 1 },
                    { 22, "Havanese", new DateTime(2024, 8, 17, 3, 49, 5, 277, DateTimeKind.Local).AddTicks(4650), false, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 1 },
                    { 23, "Maltese", new DateTime(2024, 8, 17, 3, 49, 5, 277, DateTimeKind.Local).AddTicks(4652), false, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 1 },
                    { 24, "Saint Bernard", new DateTime(2024, 8, 17, 3, 49, 5, 277, DateTimeKind.Local).AddTicks(4653), false, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 1 },
                    { 25, "Akita", new DateTime(2024, 8, 17, 3, 49, 5, 277, DateTimeKind.Local).AddTicks(4654), false, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 1 },
                    { 26, "Alaskan Malamute", new DateTime(2024, 8, 17, 3, 49, 5, 277, DateTimeKind.Local).AddTicks(4656), false, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 1 },
                    { 27, "Bichon Frise", new DateTime(2024, 8, 17, 3, 49, 5, 277, DateTimeKind.Local).AddTicks(4658), false, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 1 },
                    { 28, "Bull Terrier", new DateTime(2024, 8, 17, 3, 49, 5, 277, DateTimeKind.Local).AddTicks(4659), false, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 1 },
                    { 29, "Cane Corso", new DateTime(2024, 8, 17, 3, 49, 5, 277, DateTimeKind.Local).AddTicks(4660), false, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 1 },
                    { 30, "Chow Chow", new DateTime(2024, 8, 17, 3, 49, 5, 277, DateTimeKind.Local).AddTicks(4662), false, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 1 },
                    { 31, "Cocker Spaniel", new DateTime(2024, 8, 17, 3, 49, 5, 277, DateTimeKind.Local).AddTicks(4663), false, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 1 },
                    { 32, "Dogo Argentino", new DateTime(2024, 8, 17, 3, 49, 5, 277, DateTimeKind.Local).AddTicks(4664), false, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 1 },
                    { 33, "English Springer Spaniel", new DateTime(2024, 8, 17, 3, 49, 5, 277, DateTimeKind.Local).AddTicks(4666), false, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 1 },
                    { 34, "Irish Setter", new DateTime(2024, 8, 17, 3, 49, 5, 277, DateTimeKind.Local).AddTicks(4667), false, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 1 },
                    { 35, "Jack Russell Terrier", new DateTime(2024, 8, 17, 3, 49, 5, 277, DateTimeKind.Local).AddTicks(4668), false, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 1 },
                    { 36, "Lhasa Apso", new DateTime(2024, 8, 17, 3, 49, 5, 277, DateTimeKind.Local).AddTicks(4669), false, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 1 },
                    { 37, "Miniature Schnauzer", new DateTime(2024, 8, 17, 3, 49, 5, 277, DateTimeKind.Local).AddTicks(4671), false, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 1 },
                    { 38, "Neapolitan Mastiff", new DateTime(2024, 8, 17, 3, 49, 5, 277, DateTimeKind.Local).AddTicks(4673), false, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 1 },
                    { 39, "Old English Sheepdog", new DateTime(2024, 8, 17, 3, 49, 5, 277, DateTimeKind.Local).AddTicks(4675), false, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 1 },
                    { 40, "Papillon", new DateTime(2024, 8, 17, 3, 49, 5, 277, DateTimeKind.Local).AddTicks(4676), false, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 1 },
                    { 41, "Pekingese", new DateTime(2024, 8, 17, 3, 49, 5, 277, DateTimeKind.Local).AddTicks(4678), false, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 1 },
                    { 42, "Petit Basset Griffon Vendeen", new DateTime(2024, 8, 17, 3, 49, 5, 277, DateTimeKind.Local).AddTicks(4679), false, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 1 },
                    { 43, "Pomeranian", new DateTime(2024, 8, 17, 3, 49, 5, 277, DateTimeKind.Local).AddTicks(4681), false, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 1 },
                    { 44, "Portuguese Water Dog", new DateTime(2024, 8, 17, 3, 49, 5, 277, DateTimeKind.Local).AddTicks(4683), false, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 1 },
                    { 45, "Samoyed", new DateTime(2024, 8, 17, 3, 49, 5, 277, DateTimeKind.Local).AddTicks(4684), false, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 1 },
                    { 46, "Scottish Terrier", new DateTime(2024, 8, 17, 3, 49, 5, 277, DateTimeKind.Local).AddTicks(4686), false, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 1 },
                    { 47, "Shiba Inu", new DateTime(2024, 8, 17, 3, 49, 5, 277, DateTimeKind.Local).AddTicks(4687), false, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 1 },
                    { 48, "Weimaraner", new DateTime(2024, 8, 17, 3, 49, 5, 277, DateTimeKind.Local).AddTicks(4688), false, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 1 },
                    { 49, "Whippet", new DateTime(2024, 8, 17, 3, 49, 5, 277, DateTimeKind.Local).AddTicks(4689), false, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 1 },
                    { 50, "Persian", new DateTime(2024, 8, 17, 3, 49, 5, 277, DateTimeKind.Local).AddTicks(4691), false, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 2 },
                    { 51, "Maine Coon", new DateTime(2024, 8, 17, 3, 49, 5, 277, DateTimeKind.Local).AddTicks(4692), false, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 2 },
                    { 52, "Siamese", new DateTime(2024, 8, 17, 3, 49, 5, 277, DateTimeKind.Local).AddTicks(4693), false, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 2 },
                    { 53, "Ragdoll", new DateTime(2024, 8, 17, 3, 49, 5, 277, DateTimeKind.Local).AddTicks(4696), false, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 2 },
                    { 54, "British Shorthair", new DateTime(2024, 8, 17, 3, 49, 5, 277, DateTimeKind.Local).AddTicks(4697), false, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 2 },
                    { 55, "Sphynx", new DateTime(2024, 8, 17, 3, 49, 5, 277, DateTimeKind.Local).AddTicks(4699), false, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 2 },
                    { 56, "Bengal", new DateTime(2024, 8, 17, 3, 49, 5, 277, DateTimeKind.Local).AddTicks(4700), false, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 2 },
                    { 57, "Scottish Fold", new DateTime(2024, 8, 17, 3, 49, 5, 277, DateTimeKind.Local).AddTicks(4701), false, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 2 },
                    { 58, "Abyssinian", new DateTime(2024, 8, 17, 3, 49, 5, 277, DateTimeKind.Local).AddTicks(4703), false, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 2 },
                    { 59, "Burmese", new DateTime(2024, 8, 17, 3, 49, 5, 277, DateTimeKind.Local).AddTicks(4704), false, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 2 },
                    { 60, "Somali", new DateTime(2024, 8, 17, 3, 49, 5, 277, DateTimeKind.Local).AddTicks(4706), false, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 2 },
                    { 61, "Manx", new DateTime(2024, 8, 17, 3, 49, 5, 277, DateTimeKind.Local).AddTicks(4707), false, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 2 },
                    { 62, "Norwegian Forest Cat", new DateTime(2024, 8, 17, 3, 49, 5, 277, DateTimeKind.Local).AddTicks(4708), false, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 2 },
                    { 63, "Devon Rex", new DateTime(2024, 8, 17, 3, 49, 5, 277, DateTimeKind.Local).AddTicks(4710), false, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 2 },
                    { 64, "Cornish Rex", new DateTime(2024, 8, 17, 3, 49, 5, 277, DateTimeKind.Local).AddTicks(4711), false, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 2 },
                    { 65, "Russian Blue", new DateTime(2024, 8, 17, 3, 49, 5, 277, DateTimeKind.Local).AddTicks(4713), false, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 2 },
                    { 66, "Birman", new DateTime(2024, 8, 17, 3, 49, 5, 277, DateTimeKind.Local).AddTicks(4715), false, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 2 },
                    { 67, "Ocicat", new DateTime(2024, 8, 17, 3, 49, 5, 277, DateTimeKind.Local).AddTicks(4717), false, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 2 },
                    { 68, "American Shorthair", new DateTime(2024, 8, 17, 3, 49, 5, 277, DateTimeKind.Local).AddTicks(4718), false, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 2 },
                    { 69, "Turkish Angora", new DateTime(2024, 8, 17, 3, 49, 5, 277, DateTimeKind.Local).AddTicks(4719), false, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 2 },
                    { 70, "Selkirk Rex", new DateTime(2024, 8, 17, 3, 49, 5, 277, DateTimeKind.Local).AddTicks(4721), false, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 2 },
                    { 71, "Exotic Shorthair", new DateTime(2024, 8, 17, 3, 49, 5, 277, DateTimeKind.Local).AddTicks(4722), false, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 2 },
                    { 72, "LaPerm", new DateTime(2024, 8, 17, 3, 49, 5, 277, DateTimeKind.Local).AddTicks(4723), false, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 2 },
                    { 73, "Havana Brown", new DateTime(2024, 8, 17, 3, 49, 5, 277, DateTimeKind.Local).AddTicks(4725), false, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 2 },
                    { 74, "Tonkinese", new DateTime(2024, 8, 17, 3, 49, 5, 277, DateTimeKind.Local).AddTicks(4726), false, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 2 },
                    { 75, "Egyptian Mau", new DateTime(2024, 8, 17, 3, 49, 5, 277, DateTimeKind.Local).AddTicks(4728), false, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 2 },
                    { 76, "Singapura", new DateTime(2024, 8, 17, 3, 49, 5, 277, DateTimeKind.Local).AddTicks(4729), false, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 2 },
                    { 77, "Japanese Bobtail", new DateTime(2024, 8, 17, 3, 49, 5, 277, DateTimeKind.Local).AddTicks(4730), false, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 2 },
                    { 78, "American Curl", new DateTime(2024, 8, 17, 3, 49, 5, 277, DateTimeKind.Local).AddTicks(4731), false, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 2 },
                    { 79, "Parrot", new DateTime(2024, 8, 17, 3, 49, 5, 277, DateTimeKind.Local).AddTicks(4733), false, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 3 },
                    { 80, "Canary", new DateTime(2024, 8, 17, 3, 49, 5, 277, DateTimeKind.Local).AddTicks(4734), false, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 3 },
                    { 81, "Budgerigar", new DateTime(2024, 8, 17, 3, 49, 5, 277, DateTimeKind.Local).AddTicks(4766), false, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 3 },
                    { 82, "Cockatiel", new DateTime(2024, 8, 17, 3, 49, 5, 277, DateTimeKind.Local).AddTicks(4767), false, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 3 },
                    { 83, "Lovebird", new DateTime(2024, 8, 17, 3, 49, 5, 277, DateTimeKind.Local).AddTicks(4769), false, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 3 },
                    { 84, "Macaw", new DateTime(2024, 8, 17, 3, 49, 5, 277, DateTimeKind.Local).AddTicks(4770), false, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 3 },
                    { 85, "Conure", new DateTime(2024, 8, 17, 3, 49, 5, 277, DateTimeKind.Local).AddTicks(4772), false, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 3 },
                    { 86, "African Grey Parrot", new DateTime(2024, 8, 17, 3, 49, 5, 277, DateTimeKind.Local).AddTicks(4773), false, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 3 },
                    { 87, "Finches", new DateTime(2024, 8, 17, 3, 49, 5, 277, DateTimeKind.Local).AddTicks(4774), false, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 3 },
                    { 88, "Quaker Parrot", new DateTime(2024, 8, 17, 3, 49, 5, 277, DateTimeKind.Local).AddTicks(4775), false, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 3 },
                    { 89, "Amazon Parrot", new DateTime(2024, 8, 17, 3, 49, 5, 277, DateTimeKind.Local).AddTicks(4777), false, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 3 },
                    { 90, "Eclectus Parrot", new DateTime(2024, 8, 17, 3, 49, 5, 277, DateTimeKind.Local).AddTicks(4778), false, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 3 },
                    { 91, "Pigeon", new DateTime(2024, 8, 17, 3, 49, 5, 277, DateTimeKind.Local).AddTicks(4779), false, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 3 },
                    { 92, "Dove", new DateTime(2024, 8, 17, 3, 49, 5, 277, DateTimeKind.Local).AddTicks(4780), false, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 3 },
                    { 93, "Cockatoo", new DateTime(2024, 8, 17, 3, 49, 5, 277, DateTimeKind.Local).AddTicks(4782), false, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 3 },
                    { 94, "Sun Conure", new DateTime(2024, 8, 17, 3, 49, 5, 277, DateTimeKind.Local).AddTicks(4784), false, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 3 },
                    { 95, "Hyacinth Macaw", new DateTime(2024, 8, 17, 3, 49, 5, 277, DateTimeKind.Local).AddTicks(4786), false, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 3 },
                    { 96, "Lorikeet", new DateTime(2024, 8, 17, 3, 49, 5, 277, DateTimeKind.Local).AddTicks(4787), false, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 3 },
                    { 97, "Zebra Finch", new DateTime(2024, 8, 17, 3, 49, 5, 277, DateTimeKind.Local).AddTicks(4788), false, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 3 },
                    { 98, "Gouldian Finch", new DateTime(2024, 8, 17, 3, 49, 5, 277, DateTimeKind.Local).AddTicks(4789), false, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 3 },
                    { 99, "Canary Winged Parakeet", new DateTime(2024, 8, 17, 3, 49, 5, 277, DateTimeKind.Local).AddTicks(4791), false, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 3 },
                    { 100, "Quail", new DateTime(2024, 8, 17, 3, 49, 5, 277, DateTimeKind.Local).AddTicks(4792), false, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 3 },
                    { 101, "Iguana", new DateTime(2024, 8, 17, 3, 49, 5, 277, DateTimeKind.Local).AddTicks(4794), false, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 4 },
                    { 102, "Gecko", new DateTime(2024, 8, 17, 3, 49, 5, 277, DateTimeKind.Local).AddTicks(4795), false, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 4 },
                    { 103, "Bearded Dragon", new DateTime(2024, 8, 17, 3, 49, 5, 277, DateTimeKind.Local).AddTicks(4796), false, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 4 },
                    { 104, "Chameleon", new DateTime(2024, 8, 17, 3, 49, 5, 277, DateTimeKind.Local).AddTicks(4797), false, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 4 },
                    { 105, "Python", new DateTime(2024, 8, 17, 3, 49, 5, 277, DateTimeKind.Local).AddTicks(4800), false, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 4 },
                    { 106, "Boa Constrictor", new DateTime(2024, 8, 17, 3, 49, 5, 277, DateTimeKind.Local).AddTicks(4802), false, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 4 },
                    { 107, "Skink", new DateTime(2024, 8, 17, 3, 49, 5, 277, DateTimeKind.Local).AddTicks(4804), false, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 4 },
                    { 108, "Tortoise", new DateTime(2024, 8, 17, 3, 49, 5, 277, DateTimeKind.Local).AddTicks(4805), false, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 4 },
                    { 109, "Turtle", new DateTime(2024, 8, 17, 3, 49, 5, 277, DateTimeKind.Local).AddTicks(4807), false, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 4 },
                    { 110, "Monitor Lizard", new DateTime(2024, 8, 17, 3, 49, 5, 277, DateTimeKind.Local).AddTicks(4808), false, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 4 },
                    { 111, "Water Dragon", new DateTime(2024, 8, 17, 3, 49, 5, 277, DateTimeKind.Local).AddTicks(4809), false, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 4 },
                    { 112, "Uromastyx", new DateTime(2024, 8, 17, 3, 49, 5, 277, DateTimeKind.Local).AddTicks(4810), false, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 4 },
                    { 113, "Horned Toad", new DateTime(2024, 8, 17, 3, 49, 5, 277, DateTimeKind.Local).AddTicks(4812), false, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 4 },
                    { 114, "Hamster", new DateTime(2024, 8, 17, 3, 49, 5, 277, DateTimeKind.Local).AddTicks(4813), false, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 5 },
                    { 115, "Guinea Pig", new DateTime(2024, 8, 17, 3, 49, 5, 277, DateTimeKind.Local).AddTicks(4814), false, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 5 },
                    { 116, "Rat", new DateTime(2024, 8, 17, 3, 49, 5, 277, DateTimeKind.Local).AddTicks(4816), false, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 5 },
                    { 117, "Mouse", new DateTime(2024, 8, 17, 3, 49, 5, 277, DateTimeKind.Local).AddTicks(4817), false, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 5 },
                    { 118, "Gerbil", new DateTime(2024, 8, 17, 3, 49, 5, 277, DateTimeKind.Local).AddTicks(4819), false, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 5 },
                    { 119, "Chinchilla", new DateTime(2024, 8, 17, 3, 49, 5, 277, DateTimeKind.Local).AddTicks(4820), false, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 5 },
                    { 120, "Degu", new DateTime(2024, 8, 17, 3, 49, 5, 277, DateTimeKind.Local).AddTicks(4822), false, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 5 },
                    { 121, "Capybara", new DateTime(2024, 8, 17, 3, 49, 5, 277, DateTimeKind.Local).AddTicks(4823), false, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 5 },
                    { 122, "Prairie Dog", new DateTime(2024, 8, 17, 3, 49, 5, 277, DateTimeKind.Local).AddTicks(4825), false, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 5 },
                    { 123, "Goldfish", new DateTime(2024, 8, 17, 3, 49, 5, 277, DateTimeKind.Local).AddTicks(4826), false, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 6 },
                    { 124, "Betta", new DateTime(2024, 8, 17, 3, 49, 5, 277, DateTimeKind.Local).AddTicks(4827), false, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 6 },
                    { 125, "Guppy", new DateTime(2024, 8, 17, 3, 49, 5, 277, DateTimeKind.Local).AddTicks(4829), false, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 6 },
                    { 126, "Neon Tetra", new DateTime(2024, 8, 17, 3, 49, 5, 277, DateTimeKind.Local).AddTicks(4830), false, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 6 },
                    { 127, "Angelfish", new DateTime(2024, 8, 17, 3, 49, 5, 277, DateTimeKind.Local).AddTicks(4831), false, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 6 },
                    { 128, "Oscar", new DateTime(2024, 8, 17, 3, 49, 5, 277, DateTimeKind.Local).AddTicks(4833), false, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 6 },
                    { 129, "Clownfish", new DateTime(2024, 8, 17, 3, 49, 5, 277, DateTimeKind.Local).AddTicks(4834), false, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 6 },
                    { 130, "Corydoras Catfish", new DateTime(2024, 8, 17, 3, 49, 5, 277, DateTimeKind.Local).AddTicks(4835), false, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 6 },
                    { 131, "Molly", new DateTime(2024, 8, 17, 3, 49, 5, 277, DateTimeKind.Local).AddTicks(4837), false, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 6 },
                    { 132, "Swordtail", new DateTime(2024, 8, 17, 3, 49, 5, 277, DateTimeKind.Local).AddTicks(4838), false, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 6 },
                    { 133, "Rainbowfish", new DateTime(2024, 8, 17, 3, 49, 5, 277, DateTimeKind.Local).AddTicks(4839), false, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 6 },
                    { 134, "Plecostomus", new DateTime(2024, 8, 17, 3, 49, 5, 277, DateTimeKind.Local).AddTicks(4841), false, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 6 },
                    { 135, "Gourami", new DateTime(2024, 8, 17, 3, 49, 5, 277, DateTimeKind.Local).AddTicks(4842), false, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 6 },
                    { 136, "Danios", new DateTime(2024, 8, 17, 3, 49, 5, 277, DateTimeKind.Local).AddTicks(4843), false, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 6 },
                    { 137, "Apistogramma", new DateTime(2024, 8, 17, 3, 49, 5, 277, DateTimeKind.Local).AddTicks(4845), false, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 6 },
                    { 138, "Discus", new DateTime(2024, 8, 17, 3, 49, 5, 277, DateTimeKind.Local).AddTicks(4846), false, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 6 },
                    { 139, "Koi", new DateTime(2024, 8, 17, 3, 49, 5, 277, DateTimeKind.Local).AddTicks(4848), false, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 6 },
                    { 140, "Holstein Cow", new DateTime(2024, 8, 17, 3, 49, 5, 277, DateTimeKind.Local).AddTicks(4849), false, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 7 },
                    { 141, "Angus Cow", new DateTime(2024, 8, 17, 3, 49, 5, 277, DateTimeKind.Local).AddTicks(4851), false, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 7 },
                    { 142, "Jersey Cow", new DateTime(2024, 8, 17, 3, 49, 5, 277, DateTimeKind.Local).AddTicks(4852), false, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 7 },
                    { 143, "Guernsey Cow", new DateTime(2024, 8, 17, 3, 49, 5, 277, DateTimeKind.Local).AddTicks(4853), false, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 7 },
                    { 144, "Merino Sheep", new DateTime(2024, 8, 17, 3, 49, 5, 277, DateTimeKind.Local).AddTicks(4854), false, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 7 },
                    { 145, "Suffolk Sheep", new DateTime(2024, 8, 17, 3, 49, 5, 277, DateTimeKind.Local).AddTicks(4856), false, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 7 },
                    { 146, "Dorset Sheep", new DateTime(2024, 8, 17, 3, 49, 5, 277, DateTimeKind.Local).AddTicks(4857), false, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 7 },
                    { 147, "Hampshire Sheep", new DateTime(2024, 8, 17, 3, 49, 5, 277, DateTimeKind.Local).AddTicks(4858), false, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 7 },
                    { 148, "Berkshire Pig", new DateTime(2024, 8, 17, 3, 49, 5, 277, DateTimeKind.Local).AddTicks(4860), false, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 7 },
                    { 149, "Duroc Pig", new DateTime(2024, 8, 17, 3, 49, 5, 277, DateTimeKind.Local).AddTicks(4861), false, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 7 },
                    { 150, "Yorkshire Pig", new DateTime(2024, 8, 17, 3, 49, 5, 277, DateTimeKind.Local).AddTicks(4862), false, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 7 },
                    { 151, "Landrace Pig", new DateTime(2024, 8, 17, 3, 49, 5, 277, DateTimeKind.Local).AddTicks(4864), false, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 7 },
                    { 152, "Rhode Island Red Chicken", new DateTime(2024, 8, 17, 3, 49, 5, 277, DateTimeKind.Local).AddTicks(4865), false, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 7 },
                    { 153, "Leghorn Chicken", new DateTime(2024, 8, 17, 3, 49, 5, 277, DateTimeKind.Local).AddTicks(4866), false, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 7 },
                    { 154, "Plymouth Rock Chicken", new DateTime(2024, 8, 17, 3, 49, 5, 277, DateTimeKind.Local).AddTicks(4867), false, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 7 },
                    { 155, "Sussex Chicken", new DateTime(2024, 8, 17, 3, 49, 5, 277, DateTimeKind.Local).AddTicks(4869), false, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 7 },
                    { 156, "Turkeys", new DateTime(2024, 8, 17, 3, 49, 5, 277, DateTimeKind.Local).AddTicks(4870), false, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 7 },
                    { 157, "Ducks", new DateTime(2024, 8, 17, 3, 49, 5, 277, DateTimeKind.Local).AddTicks(4871), false, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 7 },
                    { 158, "Goats", new DateTime(2024, 8, 17, 3, 49, 5, 277, DateTimeKind.Local).AddTicks(4872), false, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 7 },
                    { 159, "Llamas", new DateTime(2024, 8, 17, 3, 49, 5, 277, DateTimeKind.Local).AddTicks(4874), false, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 7 },
                    { 160, "Alpacas", new DateTime(2024, 8, 17, 3, 49, 5, 277, DateTimeKind.Local).AddTicks(4875), false, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 7 }
                });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Breeds",
                keyColumn: "Id",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "Breeds",
                keyColumn: "Id",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "Breeds",
                keyColumn: "Id",
                keyValue: 3);

            migrationBuilder.DeleteData(
                table: "Breeds",
                keyColumn: "Id",
                keyValue: 4);

            migrationBuilder.DeleteData(
                table: "Breeds",
                keyColumn: "Id",
                keyValue: 5);

            migrationBuilder.DeleteData(
                table: "Breeds",
                keyColumn: "Id",
                keyValue: 6);

            migrationBuilder.DeleteData(
                table: "Breeds",
                keyColumn: "Id",
                keyValue: 7);

            migrationBuilder.DeleteData(
                table: "Breeds",
                keyColumn: "Id",
                keyValue: 8);

            migrationBuilder.DeleteData(
                table: "Breeds",
                keyColumn: "Id",
                keyValue: 9);

            migrationBuilder.DeleteData(
                table: "Breeds",
                keyColumn: "Id",
                keyValue: 10);

            migrationBuilder.DeleteData(
                table: "Breeds",
                keyColumn: "Id",
                keyValue: 11);

            migrationBuilder.DeleteData(
                table: "Breeds",
                keyColumn: "Id",
                keyValue: 12);

            migrationBuilder.DeleteData(
                table: "Breeds",
                keyColumn: "Id",
                keyValue: 13);

            migrationBuilder.DeleteData(
                table: "Breeds",
                keyColumn: "Id",
                keyValue: 14);

            migrationBuilder.DeleteData(
                table: "Breeds",
                keyColumn: "Id",
                keyValue: 15);

            migrationBuilder.DeleteData(
                table: "Breeds",
                keyColumn: "Id",
                keyValue: 16);

            migrationBuilder.DeleteData(
                table: "Breeds",
                keyColumn: "Id",
                keyValue: 17);

            migrationBuilder.DeleteData(
                table: "Breeds",
                keyColumn: "Id",
                keyValue: 18);

            migrationBuilder.DeleteData(
                table: "Breeds",
                keyColumn: "Id",
                keyValue: 19);

            migrationBuilder.DeleteData(
                table: "Breeds",
                keyColumn: "Id",
                keyValue: 20);

            migrationBuilder.DeleteData(
                table: "Breeds",
                keyColumn: "Id",
                keyValue: 21);

            migrationBuilder.DeleteData(
                table: "Breeds",
                keyColumn: "Id",
                keyValue: 22);

            migrationBuilder.DeleteData(
                table: "Breeds",
                keyColumn: "Id",
                keyValue: 23);

            migrationBuilder.DeleteData(
                table: "Breeds",
                keyColumn: "Id",
                keyValue: 24);

            migrationBuilder.DeleteData(
                table: "Breeds",
                keyColumn: "Id",
                keyValue: 25);

            migrationBuilder.DeleteData(
                table: "Breeds",
                keyColumn: "Id",
                keyValue: 26);

            migrationBuilder.DeleteData(
                table: "Breeds",
                keyColumn: "Id",
                keyValue: 27);

            migrationBuilder.DeleteData(
                table: "Breeds",
                keyColumn: "Id",
                keyValue: 28);

            migrationBuilder.DeleteData(
                table: "Breeds",
                keyColumn: "Id",
                keyValue: 29);

            migrationBuilder.DeleteData(
                table: "Breeds",
                keyColumn: "Id",
                keyValue: 30);

            migrationBuilder.DeleteData(
                table: "Breeds",
                keyColumn: "Id",
                keyValue: 31);

            migrationBuilder.DeleteData(
                table: "Breeds",
                keyColumn: "Id",
                keyValue: 32);

            migrationBuilder.DeleteData(
                table: "Breeds",
                keyColumn: "Id",
                keyValue: 33);

            migrationBuilder.DeleteData(
                table: "Breeds",
                keyColumn: "Id",
                keyValue: 34);

            migrationBuilder.DeleteData(
                table: "Breeds",
                keyColumn: "Id",
                keyValue: 35);

            migrationBuilder.DeleteData(
                table: "Breeds",
                keyColumn: "Id",
                keyValue: 36);

            migrationBuilder.DeleteData(
                table: "Breeds",
                keyColumn: "Id",
                keyValue: 37);

            migrationBuilder.DeleteData(
                table: "Breeds",
                keyColumn: "Id",
                keyValue: 38);

            migrationBuilder.DeleteData(
                table: "Breeds",
                keyColumn: "Id",
                keyValue: 39);

            migrationBuilder.DeleteData(
                table: "Breeds",
                keyColumn: "Id",
                keyValue: 40);

            migrationBuilder.DeleteData(
                table: "Breeds",
                keyColumn: "Id",
                keyValue: 41);

            migrationBuilder.DeleteData(
                table: "Breeds",
                keyColumn: "Id",
                keyValue: 42);

            migrationBuilder.DeleteData(
                table: "Breeds",
                keyColumn: "Id",
                keyValue: 43);

            migrationBuilder.DeleteData(
                table: "Breeds",
                keyColumn: "Id",
                keyValue: 44);

            migrationBuilder.DeleteData(
                table: "Breeds",
                keyColumn: "Id",
                keyValue: 45);

            migrationBuilder.DeleteData(
                table: "Breeds",
                keyColumn: "Id",
                keyValue: 46);

            migrationBuilder.DeleteData(
                table: "Breeds",
                keyColumn: "Id",
                keyValue: 47);

            migrationBuilder.DeleteData(
                table: "Breeds",
                keyColumn: "Id",
                keyValue: 48);

            migrationBuilder.DeleteData(
                table: "Breeds",
                keyColumn: "Id",
                keyValue: 49);

            migrationBuilder.DeleteData(
                table: "Breeds",
                keyColumn: "Id",
                keyValue: 50);

            migrationBuilder.DeleteData(
                table: "Breeds",
                keyColumn: "Id",
                keyValue: 51);

            migrationBuilder.DeleteData(
                table: "Breeds",
                keyColumn: "Id",
                keyValue: 52);

            migrationBuilder.DeleteData(
                table: "Breeds",
                keyColumn: "Id",
                keyValue: 53);

            migrationBuilder.DeleteData(
                table: "Breeds",
                keyColumn: "Id",
                keyValue: 54);

            migrationBuilder.DeleteData(
                table: "Breeds",
                keyColumn: "Id",
                keyValue: 55);

            migrationBuilder.DeleteData(
                table: "Breeds",
                keyColumn: "Id",
                keyValue: 56);

            migrationBuilder.DeleteData(
                table: "Breeds",
                keyColumn: "Id",
                keyValue: 57);

            migrationBuilder.DeleteData(
                table: "Breeds",
                keyColumn: "Id",
                keyValue: 58);

            migrationBuilder.DeleteData(
                table: "Breeds",
                keyColumn: "Id",
                keyValue: 59);

            migrationBuilder.DeleteData(
                table: "Breeds",
                keyColumn: "Id",
                keyValue: 60);

            migrationBuilder.DeleteData(
                table: "Breeds",
                keyColumn: "Id",
                keyValue: 61);

            migrationBuilder.DeleteData(
                table: "Breeds",
                keyColumn: "Id",
                keyValue: 62);

            migrationBuilder.DeleteData(
                table: "Breeds",
                keyColumn: "Id",
                keyValue: 63);

            migrationBuilder.DeleteData(
                table: "Breeds",
                keyColumn: "Id",
                keyValue: 64);

            migrationBuilder.DeleteData(
                table: "Breeds",
                keyColumn: "Id",
                keyValue: 65);

            migrationBuilder.DeleteData(
                table: "Breeds",
                keyColumn: "Id",
                keyValue: 66);

            migrationBuilder.DeleteData(
                table: "Breeds",
                keyColumn: "Id",
                keyValue: 67);

            migrationBuilder.DeleteData(
                table: "Breeds",
                keyColumn: "Id",
                keyValue: 68);

            migrationBuilder.DeleteData(
                table: "Breeds",
                keyColumn: "Id",
                keyValue: 69);

            migrationBuilder.DeleteData(
                table: "Breeds",
                keyColumn: "Id",
                keyValue: 70);

            migrationBuilder.DeleteData(
                table: "Breeds",
                keyColumn: "Id",
                keyValue: 71);

            migrationBuilder.DeleteData(
                table: "Breeds",
                keyColumn: "Id",
                keyValue: 72);

            migrationBuilder.DeleteData(
                table: "Breeds",
                keyColumn: "Id",
                keyValue: 73);

            migrationBuilder.DeleteData(
                table: "Breeds",
                keyColumn: "Id",
                keyValue: 74);

            migrationBuilder.DeleteData(
                table: "Breeds",
                keyColumn: "Id",
                keyValue: 75);

            migrationBuilder.DeleteData(
                table: "Breeds",
                keyColumn: "Id",
                keyValue: 76);

            migrationBuilder.DeleteData(
                table: "Breeds",
                keyColumn: "Id",
                keyValue: 77);

            migrationBuilder.DeleteData(
                table: "Breeds",
                keyColumn: "Id",
                keyValue: 78);

            migrationBuilder.DeleteData(
                table: "Breeds",
                keyColumn: "Id",
                keyValue: 79);

            migrationBuilder.DeleteData(
                table: "Breeds",
                keyColumn: "Id",
                keyValue: 80);

            migrationBuilder.DeleteData(
                table: "Breeds",
                keyColumn: "Id",
                keyValue: 81);

            migrationBuilder.DeleteData(
                table: "Breeds",
                keyColumn: "Id",
                keyValue: 82);

            migrationBuilder.DeleteData(
                table: "Breeds",
                keyColumn: "Id",
                keyValue: 83);

            migrationBuilder.DeleteData(
                table: "Breeds",
                keyColumn: "Id",
                keyValue: 84);

            migrationBuilder.DeleteData(
                table: "Breeds",
                keyColumn: "Id",
                keyValue: 85);

            migrationBuilder.DeleteData(
                table: "Breeds",
                keyColumn: "Id",
                keyValue: 86);

            migrationBuilder.DeleteData(
                table: "Breeds",
                keyColumn: "Id",
                keyValue: 87);

            migrationBuilder.DeleteData(
                table: "Breeds",
                keyColumn: "Id",
                keyValue: 88);

            migrationBuilder.DeleteData(
                table: "Breeds",
                keyColumn: "Id",
                keyValue: 89);

            migrationBuilder.DeleteData(
                table: "Breeds",
                keyColumn: "Id",
                keyValue: 90);

            migrationBuilder.DeleteData(
                table: "Breeds",
                keyColumn: "Id",
                keyValue: 91);

            migrationBuilder.DeleteData(
                table: "Breeds",
                keyColumn: "Id",
                keyValue: 92);

            migrationBuilder.DeleteData(
                table: "Breeds",
                keyColumn: "Id",
                keyValue: 93);

            migrationBuilder.DeleteData(
                table: "Breeds",
                keyColumn: "Id",
                keyValue: 94);

            migrationBuilder.DeleteData(
                table: "Breeds",
                keyColumn: "Id",
                keyValue: 95);

            migrationBuilder.DeleteData(
                table: "Breeds",
                keyColumn: "Id",
                keyValue: 96);

            migrationBuilder.DeleteData(
                table: "Breeds",
                keyColumn: "Id",
                keyValue: 97);

            migrationBuilder.DeleteData(
                table: "Breeds",
                keyColumn: "Id",
                keyValue: 98);

            migrationBuilder.DeleteData(
                table: "Breeds",
                keyColumn: "Id",
                keyValue: 99);

            migrationBuilder.DeleteData(
                table: "Breeds",
                keyColumn: "Id",
                keyValue: 100);

            migrationBuilder.DeleteData(
                table: "Breeds",
                keyColumn: "Id",
                keyValue: 101);

            migrationBuilder.DeleteData(
                table: "Breeds",
                keyColumn: "Id",
                keyValue: 102);

            migrationBuilder.DeleteData(
                table: "Breeds",
                keyColumn: "Id",
                keyValue: 103);

            migrationBuilder.DeleteData(
                table: "Breeds",
                keyColumn: "Id",
                keyValue: 104);

            migrationBuilder.DeleteData(
                table: "Breeds",
                keyColumn: "Id",
                keyValue: 105);

            migrationBuilder.DeleteData(
                table: "Breeds",
                keyColumn: "Id",
                keyValue: 106);

            migrationBuilder.DeleteData(
                table: "Breeds",
                keyColumn: "Id",
                keyValue: 107);

            migrationBuilder.DeleteData(
                table: "Breeds",
                keyColumn: "Id",
                keyValue: 108);

            migrationBuilder.DeleteData(
                table: "Breeds",
                keyColumn: "Id",
                keyValue: 109);

            migrationBuilder.DeleteData(
                table: "Breeds",
                keyColumn: "Id",
                keyValue: 110);

            migrationBuilder.DeleteData(
                table: "Breeds",
                keyColumn: "Id",
                keyValue: 111);

            migrationBuilder.DeleteData(
                table: "Breeds",
                keyColumn: "Id",
                keyValue: 112);

            migrationBuilder.DeleteData(
                table: "Breeds",
                keyColumn: "Id",
                keyValue: 113);

            migrationBuilder.DeleteData(
                table: "Breeds",
                keyColumn: "Id",
                keyValue: 114);

            migrationBuilder.DeleteData(
                table: "Breeds",
                keyColumn: "Id",
                keyValue: 115);

            migrationBuilder.DeleteData(
                table: "Breeds",
                keyColumn: "Id",
                keyValue: 116);

            migrationBuilder.DeleteData(
                table: "Breeds",
                keyColumn: "Id",
                keyValue: 117);

            migrationBuilder.DeleteData(
                table: "Breeds",
                keyColumn: "Id",
                keyValue: 118);

            migrationBuilder.DeleteData(
                table: "Breeds",
                keyColumn: "Id",
                keyValue: 119);

            migrationBuilder.DeleteData(
                table: "Breeds",
                keyColumn: "Id",
                keyValue: 120);

            migrationBuilder.DeleteData(
                table: "Breeds",
                keyColumn: "Id",
                keyValue: 121);

            migrationBuilder.DeleteData(
                table: "Breeds",
                keyColumn: "Id",
                keyValue: 122);

            migrationBuilder.DeleteData(
                table: "Breeds",
                keyColumn: "Id",
                keyValue: 123);

            migrationBuilder.DeleteData(
                table: "Breeds",
                keyColumn: "Id",
                keyValue: 124);

            migrationBuilder.DeleteData(
                table: "Breeds",
                keyColumn: "Id",
                keyValue: 125);

            migrationBuilder.DeleteData(
                table: "Breeds",
                keyColumn: "Id",
                keyValue: 126);

            migrationBuilder.DeleteData(
                table: "Breeds",
                keyColumn: "Id",
                keyValue: 127);

            migrationBuilder.DeleteData(
                table: "Breeds",
                keyColumn: "Id",
                keyValue: 128);

            migrationBuilder.DeleteData(
                table: "Breeds",
                keyColumn: "Id",
                keyValue: 129);

            migrationBuilder.DeleteData(
                table: "Breeds",
                keyColumn: "Id",
                keyValue: 130);

            migrationBuilder.DeleteData(
                table: "Breeds",
                keyColumn: "Id",
                keyValue: 131);

            migrationBuilder.DeleteData(
                table: "Breeds",
                keyColumn: "Id",
                keyValue: 132);

            migrationBuilder.DeleteData(
                table: "Breeds",
                keyColumn: "Id",
                keyValue: 133);

            migrationBuilder.DeleteData(
                table: "Breeds",
                keyColumn: "Id",
                keyValue: 134);

            migrationBuilder.DeleteData(
                table: "Breeds",
                keyColumn: "Id",
                keyValue: 135);

            migrationBuilder.DeleteData(
                table: "Breeds",
                keyColumn: "Id",
                keyValue: 136);

            migrationBuilder.DeleteData(
                table: "Breeds",
                keyColumn: "Id",
                keyValue: 137);

            migrationBuilder.DeleteData(
                table: "Breeds",
                keyColumn: "Id",
                keyValue: 138);

            migrationBuilder.DeleteData(
                table: "Breeds",
                keyColumn: "Id",
                keyValue: 139);

            migrationBuilder.DeleteData(
                table: "Breeds",
                keyColumn: "Id",
                keyValue: 140);

            migrationBuilder.DeleteData(
                table: "Breeds",
                keyColumn: "Id",
                keyValue: 141);

            migrationBuilder.DeleteData(
                table: "Breeds",
                keyColumn: "Id",
                keyValue: 142);

            migrationBuilder.DeleteData(
                table: "Breeds",
                keyColumn: "Id",
                keyValue: 143);

            migrationBuilder.DeleteData(
                table: "Breeds",
                keyColumn: "Id",
                keyValue: 144);

            migrationBuilder.DeleteData(
                table: "Breeds",
                keyColumn: "Id",
                keyValue: 145);

            migrationBuilder.DeleteData(
                table: "Breeds",
                keyColumn: "Id",
                keyValue: 146);

            migrationBuilder.DeleteData(
                table: "Breeds",
                keyColumn: "Id",
                keyValue: 147);

            migrationBuilder.DeleteData(
                table: "Breeds",
                keyColumn: "Id",
                keyValue: 148);

            migrationBuilder.DeleteData(
                table: "Breeds",
                keyColumn: "Id",
                keyValue: 149);

            migrationBuilder.DeleteData(
                table: "Breeds",
                keyColumn: "Id",
                keyValue: 150);

            migrationBuilder.DeleteData(
                table: "Breeds",
                keyColumn: "Id",
                keyValue: 151);

            migrationBuilder.DeleteData(
                table: "Breeds",
                keyColumn: "Id",
                keyValue: 152);

            migrationBuilder.DeleteData(
                table: "Breeds",
                keyColumn: "Id",
                keyValue: 153);

            migrationBuilder.DeleteData(
                table: "Breeds",
                keyColumn: "Id",
                keyValue: 154);

            migrationBuilder.DeleteData(
                table: "Breeds",
                keyColumn: "Id",
                keyValue: 155);

            migrationBuilder.DeleteData(
                table: "Breeds",
                keyColumn: "Id",
                keyValue: 156);

            migrationBuilder.DeleteData(
                table: "Breeds",
                keyColumn: "Id",
                keyValue: 157);

            migrationBuilder.DeleteData(
                table: "Breeds",
                keyColumn: "Id",
                keyValue: 158);

            migrationBuilder.DeleteData(
                table: "Breeds",
                keyColumn: "Id",
                keyValue: 159);

            migrationBuilder.DeleteData(
                table: "Breeds",
                keyColumn: "Id",
                keyValue: 160);

            migrationBuilder.DeleteData(
                table: "PetTypes",
                keyColumn: "Id",
                keyValue: 8);

            migrationBuilder.DeleteData(
                table: "PetTypes",
                keyColumn: "Id",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "PetTypes",
                keyColumn: "Id",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "PetTypes",
                keyColumn: "Id",
                keyValue: 3);

            migrationBuilder.DeleteData(
                table: "PetTypes",
                keyColumn: "Id",
                keyValue: 4);

            migrationBuilder.DeleteData(
                table: "PetTypes",
                keyColumn: "Id",
                keyValue: 5);

            migrationBuilder.DeleteData(
                table: "PetTypes",
                keyColumn: "Id",
                keyValue: 6);

            migrationBuilder.DeleteData(
                table: "PetTypes",
                keyColumn: "Id",
                keyValue: 7);

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: 2001,
                columns: new[] { "ConcurrencyStamp", "CreatedTime", "LastUpdatedTime", "RefreshTokenCreateTime" },
                values: new object[] { "158a19c8-b046-41e4-bec1-1bf29346ee28", new DateTime(2024, 8, 16, 23, 36, 18, 477, DateTimeKind.Utc).AddTicks(1764), new DateTime(2024, 8, 16, 23, 36, 18, 477, DateTimeKind.Utc).AddTicks(1766), new DateTime(2024, 8, 17, 3, 36, 18, 477, DateTimeKind.Local).AddTicks(1652) });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: 2002,
                columns: new[] { "ConcurrencyStamp", "CreatedTime", "LastUpdatedTime", "RefreshTokenCreateTime" },
                values: new object[] { "5473c986-53a3-4022-8392-6c108ffdb71a", new DateTime(2024, 8, 16, 23, 36, 18, 477, DateTimeKind.Utc).AddTicks(1802), new DateTime(2024, 8, 16, 23, 36, 18, 477, DateTimeKind.Utc).AddTicks(1802), new DateTime(2024, 8, 17, 3, 36, 18, 477, DateTimeKind.Local).AddTicks(1794) });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: 2003,
                columns: new[] { "ConcurrencyStamp", "CreatedTime", "LastUpdatedTime", "RefreshTokenCreateTime" },
                values: new object[] { "68281672-68b6-4ec9-9903-83035b044c0a", new DateTime(2024, 8, 16, 23, 36, 18, 477, DateTimeKind.Utc).AddTicks(1833), new DateTime(2024, 8, 16, 23, 36, 18, 477, DateTimeKind.Utc).AddTicks(1833), new DateTime(2024, 8, 17, 3, 36, 18, 477, DateTimeKind.Local).AddTicks(1812) });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: 2004,
                columns: new[] { "ConcurrencyStamp", "CreatedTime", "LastUpdatedTime", "RefreshTokenCreateTime" },
                values: new object[] { "a6f436f9-1b90-433b-8353-a9a3ec228160", new DateTime(2024, 8, 16, 23, 36, 18, 477, DateTimeKind.Utc).AddTicks(1847), new DateTime(2024, 8, 16, 23, 36, 18, 477, DateTimeKind.Utc).AddTicks(1848), new DateTime(2024, 8, 17, 3, 36, 18, 477, DateTimeKind.Local).AddTicks(1841) });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: 2005,
                columns: new[] { "ConcurrencyStamp", "CreatedTime", "LastUpdatedTime", "RefreshTokenCreateTime" },
                values: new object[] { "350dd62c-3389-4f18-9717-2366aa77d636", new DateTime(2024, 8, 16, 23, 36, 18, 477, DateTimeKind.Utc).AddTicks(1861), new DateTime(2024, 8, 16, 23, 36, 18, 477, DateTimeKind.Utc).AddTicks(1861), new DateTime(2024, 8, 17, 3, 36, 18, 477, DateTimeKind.Local).AddTicks(1855) });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: 2006,
                columns: new[] { "ConcurrencyStamp", "CreatedTime", "LastUpdatedTime", "RefreshTokenCreateTime" },
                values: new object[] { "60089523-6b14-4396-97a7-8a9cdf5e1dee", new DateTime(2024, 8, 16, 23, 36, 18, 477, DateTimeKind.Utc).AddTicks(1878), new DateTime(2024, 8, 16, 23, 36, 18, 477, DateTimeKind.Utc).AddTicks(1879), new DateTime(2024, 8, 17, 3, 36, 18, 477, DateTimeKind.Local).AddTicks(1873) });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: 2007,
                columns: new[] { "ConcurrencyStamp", "CreatedTime", "LastUpdatedTime", "RefreshTokenCreateTime" },
                values: new object[] { "5487ed91-4e7c-4aa8-86c7-910ddd58560f", new DateTime(2024, 8, 16, 23, 36, 18, 477, DateTimeKind.Utc).AddTicks(1935), new DateTime(2024, 8, 16, 23, 36, 18, 477, DateTimeKind.Utc).AddTicks(1936), new DateTime(2024, 8, 17, 3, 36, 18, 477, DateTimeKind.Local).AddTicks(1929) });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: 2008,
                columns: new[] { "ConcurrencyStamp", "CreatedTime", "LastUpdatedTime", "RefreshTokenCreateTime" },
                values: new object[] { "1cbd9db1-be90-45ce-b229-0b9ac152a089", new DateTime(2024, 8, 16, 23, 36, 18, 477, DateTimeKind.Utc).AddTicks(1949), new DateTime(2024, 8, 16, 23, 36, 18, 477, DateTimeKind.Utc).AddTicks(1949), new DateTime(2024, 8, 17, 3, 36, 18, 477, DateTimeKind.Local).AddTicks(1943) });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: 2009,
                columns: new[] { "ConcurrencyStamp", "CreatedTime", "LastUpdatedTime", "RefreshTokenCreateTime" },
                values: new object[] { "85bfb26b-397a-4e8e-a229-d587899e61d2", new DateTime(2024, 8, 16, 23, 36, 18, 477, DateTimeKind.Utc).AddTicks(1962), new DateTime(2024, 8, 16, 23, 36, 18, 477, DateTimeKind.Utc).AddTicks(1962), new DateTime(2024, 8, 17, 3, 36, 18, 477, DateTimeKind.Local).AddTicks(1956) });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: 2010,
                columns: new[] { "ConcurrencyStamp", "CreatedTime", "LastUpdatedTime", "RefreshTokenCreateTime" },
                values: new object[] { "7d5bf999-82b8-4c9a-b821-4939bdb913c1", new DateTime(2024, 8, 16, 23, 36, 18, 477, DateTimeKind.Utc).AddTicks(1980), new DateTime(2024, 8, 16, 23, 36, 18, 477, DateTimeKind.Utc).AddTicks(1980), new DateTime(2024, 8, 17, 3, 36, 18, 477, DateTimeKind.Local).AddTicks(1972) });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: 2011,
                columns: new[] { "ConcurrencyStamp", "CreatedTime", "LastUpdatedTime", "RefreshTokenCreateTime" },
                values: new object[] { "f0c56626-013b-4246-ad77-f6bf6e03d88f", new DateTime(2024, 8, 16, 23, 36, 18, 477, DateTimeKind.Utc).AddTicks(1997), new DateTime(2024, 8, 16, 23, 36, 18, 477, DateTimeKind.Utc).AddTicks(1998), new DateTime(2024, 8, 17, 3, 36, 18, 477, DateTimeKind.Local).AddTicks(1988) });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: 2012,
                columns: new[] { "ConcurrencyStamp", "CreatedTime", "LastUpdatedTime", "RefreshTokenCreateTime" },
                values: new object[] { "969d3f9f-4986-4fe6-84b4-bb8b372fed11", new DateTime(2024, 8, 16, 23, 36, 18, 477, DateTimeKind.Utc).AddTicks(2011), new DateTime(2024, 8, 16, 23, 36, 18, 477, DateTimeKind.Utc).AddTicks(2012), new DateTime(2024, 8, 17, 3, 36, 18, 477, DateTimeKind.Local).AddTicks(2006) });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: 2013,
                columns: new[] { "ConcurrencyStamp", "CreatedTime", "LastUpdatedTime", "RefreshTokenCreateTime" },
                values: new object[] { "98db38cd-6fb6-4d50-9967-c2ce340d78a9", new DateTime(2024, 8, 16, 23, 36, 18, 477, DateTimeKind.Utc).AddTicks(2025), new DateTime(2024, 8, 16, 23, 36, 18, 477, DateTimeKind.Utc).AddTicks(2026), new DateTime(2024, 8, 17, 3, 36, 18, 477, DateTimeKind.Local).AddTicks(2020) });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: 2014,
                columns: new[] { "ConcurrencyStamp", "CreatedTime", "LastUpdatedTime", "RefreshTokenCreateTime" },
                values: new object[] { "5f474c24-7fd2-4659-b83a-a5ccfaa2b400", new DateTime(2024, 8, 16, 23, 36, 18, 477, DateTimeKind.Utc).AddTicks(2039), new DateTime(2024, 8, 16, 23, 36, 18, 477, DateTimeKind.Utc).AddTicks(2039), new DateTime(2024, 8, 17, 3, 36, 18, 477, DateTimeKind.Local).AddTicks(2033) });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: 2015,
                columns: new[] { "ConcurrencyStamp", "CreatedTime", "LastUpdatedTime", "RefreshTokenCreateTime" },
                values: new object[] { "ac4738d0-8bb8-4aa5-b0e6-20dfafa1971e", new DateTime(2024, 8, 16, 23, 36, 18, 477, DateTimeKind.Utc).AddTicks(2052), new DateTime(2024, 8, 16, 23, 36, 18, 477, DateTimeKind.Utc).AddTicks(2052), new DateTime(2024, 8, 17, 3, 36, 18, 477, DateTimeKind.Local).AddTicks(2046) });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: 2016,
                columns: new[] { "ConcurrencyStamp", "CreatedTime", "LastUpdatedTime", "RefreshTokenCreateTime" },
                values: new object[] { "a24852bb-e720-411b-b1a8-1214e9370aeb", new DateTime(2024, 8, 16, 23, 36, 18, 477, DateTimeKind.Utc).AddTicks(2094), new DateTime(2024, 8, 16, 23, 36, 18, 477, DateTimeKind.Utc).AddTicks(2095), new DateTime(2024, 8, 17, 3, 36, 18, 477, DateTimeKind.Local).AddTicks(2089) });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: 2017,
                columns: new[] { "ConcurrencyStamp", "CreatedTime", "LastUpdatedTime", "RefreshTokenCreateTime" },
                values: new object[] { "72adb0e9-ba5a-46e9-b0cf-d6cc3c1aac9c", new DateTime(2024, 8, 16, 23, 36, 18, 477, DateTimeKind.Utc).AddTicks(2108), new DateTime(2024, 8, 16, 23, 36, 18, 477, DateTimeKind.Utc).AddTicks(2109), new DateTime(2024, 8, 17, 3, 36, 18, 477, DateTimeKind.Local).AddTicks(2103) });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: 2018,
                columns: new[] { "ConcurrencyStamp", "CreatedTime", "LastUpdatedTime", "RefreshTokenCreateTime" },
                values: new object[] { "afb8247b-5912-4d12-85c7-4104a67b4b48", new DateTime(2024, 8, 16, 23, 36, 18, 477, DateTimeKind.Utc).AddTicks(2124), new DateTime(2024, 8, 16, 23, 36, 18, 477, DateTimeKind.Utc).AddTicks(2124), new DateTime(2024, 8, 17, 3, 36, 18, 477, DateTimeKind.Local).AddTicks(2118) });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: 2019,
                columns: new[] { "ConcurrencyStamp", "CreatedTime", "LastUpdatedTime", "RefreshTokenCreateTime" },
                values: new object[] { "0a600699-98ee-4276-94af-c491956fa419", new DateTime(2024, 8, 16, 23, 36, 18, 477, DateTimeKind.Utc).AddTicks(2141), new DateTime(2024, 8, 16, 23, 36, 18, 477, DateTimeKind.Utc).AddTicks(2141), new DateTime(2024, 8, 17, 3, 36, 18, 477, DateTimeKind.Local).AddTicks(2132) });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: 2020,
                columns: new[] { "ConcurrencyStamp", "CreatedTime", "LastUpdatedTime", "RefreshTokenCreateTime" },
                values: new object[] { "fa934a39-f382-44c7-96bf-31609e65f717", new DateTime(2024, 8, 16, 23, 36, 18, 477, DateTimeKind.Utc).AddTicks(2155), new DateTime(2024, 8, 16, 23, 36, 18, 477, DateTimeKind.Utc).AddTicks(2155), new DateTime(2024, 8, 17, 3, 36, 18, 477, DateTimeKind.Local).AddTicks(2149) });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: 2021,
                columns: new[] { "ConcurrencyStamp", "CreatedTime", "LastUpdatedTime", "RefreshTokenCreateTime" },
                values: new object[] { "0fcf39ce-c996-4ef4-aac3-841697c05224", new DateTime(2024, 8, 16, 23, 36, 18, 477, DateTimeKind.Utc).AddTicks(2169), new DateTime(2024, 8, 16, 23, 36, 18, 477, DateTimeKind.Utc).AddTicks(2169), new DateTime(2024, 8, 17, 3, 36, 18, 477, DateTimeKind.Local).AddTicks(2163) });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: 2022,
                columns: new[] { "ConcurrencyStamp", "CreatedTime", "LastUpdatedTime", "RefreshTokenCreateTime" },
                values: new object[] { "1ea9e070-3535-4e67-9545-7d11ede1b1f7", new DateTime(2024, 8, 16, 23, 36, 18, 477, DateTimeKind.Utc).AddTicks(2191), new DateTime(2024, 8, 16, 23, 36, 18, 477, DateTimeKind.Utc).AddTicks(2191), new DateTime(2024, 8, 17, 3, 36, 18, 477, DateTimeKind.Local).AddTicks(2185) });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: 2023,
                columns: new[] { "ConcurrencyStamp", "CreatedTime", "LastUpdatedTime", "RefreshTokenCreateTime" },
                values: new object[] { "7a101157-1681-4840-a8d3-73b3508a25b4", new DateTime(2024, 8, 16, 23, 36, 18, 477, DateTimeKind.Utc).AddTicks(2206), new DateTime(2024, 8, 16, 23, 36, 18, 477, DateTimeKind.Utc).AddTicks(2206), new DateTime(2024, 8, 17, 3, 36, 18, 477, DateTimeKind.Local).AddTicks(2200) });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: 2024,
                columns: new[] { "ConcurrencyStamp", "CreatedTime", "LastUpdatedTime", "RefreshTokenCreateTime" },
                values: new object[] { "2d7a9194-3e46-4d01-9ceb-784154aaf421", new DateTime(2024, 8, 16, 23, 36, 18, 477, DateTimeKind.Utc).AddTicks(2220), new DateTime(2024, 8, 16, 23, 36, 18, 477, DateTimeKind.Utc).AddTicks(2220), new DateTime(2024, 8, 17, 3, 36, 18, 477, DateTimeKind.Local).AddTicks(2214) });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: 2025,
                columns: new[] { "ConcurrencyStamp", "CreatedTime", "LastUpdatedTime", "RefreshTokenCreateTime" },
                values: new object[] { "f8646247-2ed0-40ad-ab9c-ada8c87b4425", new DateTime(2024, 8, 16, 23, 36, 18, 477, DateTimeKind.Utc).AddTicks(2266), new DateTime(2024, 8, 16, 23, 36, 18, 477, DateTimeKind.Utc).AddTicks(2267), new DateTime(2024, 8, 17, 3, 36, 18, 477, DateTimeKind.Local).AddTicks(2261) });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: 2026,
                columns: new[] { "ConcurrencyStamp", "CreatedTime", "LastUpdatedTime", "RefreshTokenCreateTime" },
                values: new object[] { "61811708-27ea-4e04-9418-b72c33c987f2", new DateTime(2024, 8, 16, 23, 36, 18, 477, DateTimeKind.Utc).AddTicks(2280), new DateTime(2024, 8, 16, 23, 36, 18, 477, DateTimeKind.Utc).AddTicks(2281), new DateTime(2024, 8, 17, 3, 36, 18, 477, DateTimeKind.Local).AddTicks(2275) });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: 2027,
                columns: new[] { "ConcurrencyStamp", "CreatedTime", "LastUpdatedTime", "RefreshTokenCreateTime" },
                values: new object[] { "21fb7c8c-1e0f-4a10-adc1-1d1ef03699a7", new DateTime(2024, 8, 16, 23, 36, 18, 477, DateTimeKind.Utc).AddTicks(2297), new DateTime(2024, 8, 16, 23, 36, 18, 477, DateTimeKind.Utc).AddTicks(2297), new DateTime(2024, 8, 17, 3, 36, 18, 477, DateTimeKind.Local).AddTicks(2289) });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: 2028,
                columns: new[] { "ConcurrencyStamp", "CreatedTime", "LastUpdatedTime", "RefreshTokenCreateTime" },
                values: new object[] { "8fe53b15-8c88-48f6-8093-3dbcaa609b84", new DateTime(2024, 8, 16, 23, 36, 18, 477, DateTimeKind.Utc).AddTicks(2311), new DateTime(2024, 8, 16, 23, 36, 18, 477, DateTimeKind.Utc).AddTicks(2311), new DateTime(2024, 8, 17, 3, 36, 18, 477, DateTimeKind.Local).AddTicks(2305) });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: 2029,
                columns: new[] { "ConcurrencyStamp", "CreatedTime", "LastUpdatedTime", "RefreshTokenCreateTime" },
                values: new object[] { "e6bc7262-3cf8-4742-9a6d-3cffabd06e48", new DateTime(2024, 8, 16, 23, 36, 18, 477, DateTimeKind.Utc).AddTicks(2324), new DateTime(2024, 8, 16, 23, 36, 18, 477, DateTimeKind.Utc).AddTicks(2325), new DateTime(2024, 8, 17, 3, 36, 18, 477, DateTimeKind.Local).AddTicks(2319) });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: 2030,
                columns: new[] { "ConcurrencyStamp", "CreatedTime", "LastUpdatedTime", "RefreshTokenCreateTime" },
                values: new object[] { "deb42660-defc-4064-801f-c75296fdd384", new DateTime(2024, 8, 16, 23, 36, 18, 477, DateTimeKind.Utc).AddTicks(2338), new DateTime(2024, 8, 16, 23, 36, 18, 477, DateTimeKind.Utc).AddTicks(2339), new DateTime(2024, 8, 17, 3, 36, 18, 477, DateTimeKind.Local).AddTicks(2333) });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: 2031,
                columns: new[] { "ConcurrencyStamp", "CreatedTime", "LastUpdatedTime", "RefreshTokenCreateTime" },
                values: new object[] { "01d65e59-f018-4259-b328-aa1c2c5c555b", new DateTime(2024, 8, 16, 23, 36, 18, 477, DateTimeKind.Utc).AddTicks(2352), new DateTime(2024, 8, 16, 23, 36, 18, 477, DateTimeKind.Utc).AddTicks(2352), new DateTime(2024, 8, 17, 3, 36, 18, 477, DateTimeKind.Local).AddTicks(2347) });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: 2032,
                columns: new[] { "ConcurrencyStamp", "CreatedTime", "LastUpdatedTime", "RefreshTokenCreateTime" },
                values: new object[] { "ab6a91d9-6b56-4e8c-9657-b2c71570a0ff", new DateTime(2024, 8, 16, 23, 36, 18, 477, DateTimeKind.Utc).AddTicks(2365), new DateTime(2024, 8, 16, 23, 36, 18, 477, DateTimeKind.Utc).AddTicks(2366), new DateTime(2024, 8, 17, 3, 36, 18, 477, DateTimeKind.Local).AddTicks(2360) });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: 2033,
                columns: new[] { "ConcurrencyStamp", "CreatedTime", "LastUpdatedTime", "RefreshTokenCreateTime" },
                values: new object[] { "02decce7-58cc-4c04-941e-76d0b8884ac8", new DateTime(2024, 8, 16, 23, 36, 18, 477, DateTimeKind.Utc).AddTicks(2409), new DateTime(2024, 8, 16, 23, 36, 18, 477, DateTimeKind.Utc).AddTicks(2410), new DateTime(2024, 8, 17, 3, 36, 18, 477, DateTimeKind.Local).AddTicks(2403) });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: 2034,
                columns: new[] { "ConcurrencyStamp", "CreatedTime", "LastUpdatedTime", "RefreshTokenCreateTime" },
                values: new object[] { "63e8d42a-f880-46cc-b5df-f1fb804b2b4e", new DateTime(2024, 8, 16, 23, 36, 18, 477, DateTimeKind.Utc).AddTicks(2427), new DateTime(2024, 8, 16, 23, 36, 18, 477, DateTimeKind.Utc).AddTicks(2427), new DateTime(2024, 8, 17, 3, 36, 18, 477, DateTimeKind.Local).AddTicks(2421) });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: 2035,
                columns: new[] { "ConcurrencyStamp", "CreatedTime", "LastUpdatedTime", "RefreshTokenCreateTime" },
                values: new object[] { "62e3395f-e734-42ab-b460-4c471b28bb3f", new DateTime(2024, 8, 16, 23, 36, 18, 477, DateTimeKind.Utc).AddTicks(2444), new DateTime(2024, 8, 16, 23, 36, 18, 477, DateTimeKind.Utc).AddTicks(2444), new DateTime(2024, 8, 17, 3, 36, 18, 477, DateTimeKind.Local).AddTicks(2435) });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: 2036,
                columns: new[] { "ConcurrencyStamp", "CreatedTime", "LastUpdatedTime", "RefreshTokenCreateTime" },
                values: new object[] { "04a81651-bed5-483e-a692-e52882f10aa2", new DateTime(2024, 8, 16, 23, 36, 18, 477, DateTimeKind.Utc).AddTicks(2458), new DateTime(2024, 8, 16, 23, 36, 18, 477, DateTimeKind.Utc).AddTicks(2458), new DateTime(2024, 8, 17, 3, 36, 18, 477, DateTimeKind.Local).AddTicks(2452) });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: 2037,
                columns: new[] { "ConcurrencyStamp", "CreatedTime", "LastUpdatedTime", "RefreshTokenCreateTime" },
                values: new object[] { "311a08ea-57d8-459f-b1f5-d0b7c7f5775b", new DateTime(2024, 8, 16, 23, 36, 18, 477, DateTimeKind.Utc).AddTicks(2472), new DateTime(2024, 8, 16, 23, 36, 18, 477, DateTimeKind.Utc).AddTicks(2472), new DateTime(2024, 8, 17, 3, 36, 18, 477, DateTimeKind.Local).AddTicks(2466) });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: 2038,
                columns: new[] { "ConcurrencyStamp", "CreatedTime", "LastUpdatedTime", "RefreshTokenCreateTime" },
                values: new object[] { "4a02c949-9b1a-436e-a76d-e748a8256c53", new DateTime(2024, 8, 16, 23, 36, 18, 477, DateTimeKind.Utc).AddTicks(2485), new DateTime(2024, 8, 16, 23, 36, 18, 477, DateTimeKind.Utc).AddTicks(2485), new DateTime(2024, 8, 17, 3, 36, 18, 477, DateTimeKind.Local).AddTicks(2480) });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: 2039,
                columns: new[] { "ConcurrencyStamp", "CreatedTime", "LastUpdatedTime", "RefreshTokenCreateTime" },
                values: new object[] { "7e465e00-3aa0-480b-8e7c-98930c45d319", new DateTime(2024, 8, 16, 23, 36, 18, 477, DateTimeKind.Utc).AddTicks(2499), new DateTime(2024, 8, 16, 23, 36, 18, 477, DateTimeKind.Utc).AddTicks(2499), new DateTime(2024, 8, 17, 3, 36, 18, 477, DateTimeKind.Local).AddTicks(2493) });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: 2040,
                columns: new[] { "ConcurrencyStamp", "CreatedTime", "LastUpdatedTime", "RefreshTokenCreateTime" },
                values: new object[] { "26ada322-5c40-4d55-857d-1ffb93ed4e32", new DateTime(2024, 8, 16, 23, 36, 18, 477, DateTimeKind.Utc).AddTicks(2512), new DateTime(2024, 8, 16, 23, 36, 18, 477, DateTimeKind.Utc).AddTicks(2512), new DateTime(2024, 8, 17, 3, 36, 18, 477, DateTimeKind.Local).AddTicks(2507) });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: 2041,
                columns: new[] { "ConcurrencyStamp", "CreatedTime", "LastUpdatedTime", "RefreshTokenCreateTime" },
                values: new object[] { "4f6a9aaf-cd6c-4db8-934b-9a096545ba15", new DateTime(2024, 8, 16, 23, 36, 18, 477, DateTimeKind.Utc).AddTicks(2545), new DateTime(2024, 8, 16, 23, 36, 18, 477, DateTimeKind.Utc).AddTicks(2546), new DateTime(2024, 8, 17, 3, 36, 18, 477, DateTimeKind.Local).AddTicks(2520) });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: 2042,
                columns: new[] { "ConcurrencyStamp", "CreatedTime", "LastUpdatedTime", "RefreshTokenCreateTime" },
                values: new object[] { "e241a812-6f40-4491-b4ca-47398af164e8", new DateTime(2024, 8, 16, 23, 36, 18, 477, DateTimeKind.Utc).AddTicks(2565), new DateTime(2024, 8, 16, 23, 36, 18, 477, DateTimeKind.Utc).AddTicks(2565), new DateTime(2024, 8, 17, 3, 36, 18, 477, DateTimeKind.Local).AddTicks(2559) });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: 2043,
                columns: new[] { "ConcurrencyStamp", "CreatedTime", "LastUpdatedTime", "RefreshTokenCreateTime" },
                values: new object[] { "3d55049d-b93e-4e32-a80a-5228fd23e81f", new DateTime(2024, 8, 16, 23, 36, 18, 477, DateTimeKind.Utc).AddTicks(2582), new DateTime(2024, 8, 16, 23, 36, 18, 477, DateTimeKind.Utc).AddTicks(2583), new DateTime(2024, 8, 17, 3, 36, 18, 477, DateTimeKind.Local).AddTicks(2574) });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: 2044,
                columns: new[] { "ConcurrencyStamp", "CreatedTime", "LastUpdatedTime", "RefreshTokenCreateTime" },
                values: new object[] { "b7818ead-b6fe-4ae7-8cf5-6dd8b6719aa8", new DateTime(2024, 8, 16, 23, 36, 18, 477, DateTimeKind.Utc).AddTicks(2596), new DateTime(2024, 8, 16, 23, 36, 18, 477, DateTimeKind.Utc).AddTicks(2597), new DateTime(2024, 8, 17, 3, 36, 18, 477, DateTimeKind.Local).AddTicks(2591) });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: 2045,
                columns: new[] { "ConcurrencyStamp", "CreatedTime", "LastUpdatedTime", "RefreshTokenCreateTime" },
                values: new object[] { "05d60a78-b54d-4c48-8e9d-e0cac22cc47a", new DateTime(2024, 8, 16, 23, 36, 18, 477, DateTimeKind.Utc).AddTicks(2610), new DateTime(2024, 8, 16, 23, 36, 18, 477, DateTimeKind.Utc).AddTicks(2611), new DateTime(2024, 8, 17, 3, 36, 18, 477, DateTimeKind.Local).AddTicks(2605) });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: 2046,
                columns: new[] { "ConcurrencyStamp", "CreatedTime", "LastUpdatedTime", "RefreshTokenCreateTime" },
                values: new object[] { "d9f09b6e-9413-4fab-bb2f-91b808e4d285", new DateTime(2024, 8, 16, 23, 36, 18, 477, DateTimeKind.Utc).AddTicks(2624), new DateTime(2024, 8, 16, 23, 36, 18, 477, DateTimeKind.Utc).AddTicks(2624), new DateTime(2024, 8, 17, 3, 36, 18, 477, DateTimeKind.Local).AddTicks(2618) });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: 2047,
                columns: new[] { "ConcurrencyStamp", "CreatedTime", "LastUpdatedTime", "RefreshTokenCreateTime" },
                values: new object[] { "89b757ce-5075-432f-a113-2fc05f38ad12", new DateTime(2024, 8, 16, 23, 36, 18, 477, DateTimeKind.Utc).AddTicks(2637), new DateTime(2024, 8, 16, 23, 36, 18, 477, DateTimeKind.Utc).AddTicks(2638), new DateTime(2024, 8, 17, 3, 36, 18, 477, DateTimeKind.Local).AddTicks(2632) });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: 2048,
                columns: new[] { "ConcurrencyStamp", "CreatedTime", "LastUpdatedTime", "RefreshTokenCreateTime" },
                values: new object[] { "e732049f-b3f8-42e0-8440-8f0f1d439aa5", new DateTime(2024, 8, 16, 23, 36, 18, 477, DateTimeKind.Utc).AddTicks(2651), new DateTime(2024, 8, 16, 23, 36, 18, 477, DateTimeKind.Utc).AddTicks(2651), new DateTime(2024, 8, 17, 3, 36, 18, 477, DateTimeKind.Local).AddTicks(2645) });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: 2049,
                columns: new[] { "ConcurrencyStamp", "CreatedTime", "LastUpdatedTime", "RefreshTokenCreateTime" },
                values: new object[] { "7a4f7371-171d-453b-ac71-b097525ed352", new DateTime(2024, 8, 16, 23, 36, 18, 477, DateTimeKind.Utc).AddTicks(2664), new DateTime(2024, 8, 16, 23, 36, 18, 477, DateTimeKind.Utc).AddTicks(2664), new DateTime(2024, 8, 17, 3, 36, 18, 477, DateTimeKind.Local).AddTicks(2658) });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: 2050,
                columns: new[] { "ConcurrencyStamp", "CreatedTime", "LastUpdatedTime", "RefreshTokenCreateTime" },
                values: new object[] { "ce373ebd-6302-4517-bc6b-ef82ff214fc5", new DateTime(2024, 8, 16, 23, 36, 18, 477, DateTimeKind.Utc).AddTicks(2735), new DateTime(2024, 8, 16, 23, 36, 18, 477, DateTimeKind.Utc).AddTicks(2735), new DateTime(2024, 8, 17, 3, 36, 18, 477, DateTimeKind.Local).AddTicks(2729) });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: 2051,
                columns: new[] { "ConcurrencyStamp", "CreatedTime", "LastUpdatedTime", "RefreshTokenCreateTime" },
                values: new object[] { "a1673c68-281c-4b9f-8a76-3e29407158ed", new DateTime(2024, 8, 16, 23, 36, 18, 477, DateTimeKind.Utc).AddTicks(2753), new DateTime(2024, 8, 16, 23, 36, 18, 477, DateTimeKind.Utc).AddTicks(2753), new DateTime(2024, 8, 17, 3, 36, 18, 477, DateTimeKind.Local).AddTicks(2744) });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: 2052,
                columns: new[] { "ConcurrencyStamp", "CreatedTime", "LastUpdatedTime", "RefreshTokenCreateTime" },
                values: new object[] { "b98845c3-875b-49e0-bbc1-c990fe3ff0f6", new DateTime(2024, 8, 16, 23, 36, 18, 477, DateTimeKind.Utc).AddTicks(2766), new DateTime(2024, 8, 16, 23, 36, 18, 477, DateTimeKind.Utc).AddTicks(2766), new DateTime(2024, 8, 17, 3, 36, 18, 477, DateTimeKind.Local).AddTicks(2761) });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: 2053,
                columns: new[] { "ConcurrencyStamp", "CreatedTime", "LastUpdatedTime", "RefreshTokenCreateTime" },
                values: new object[] { "7c904d73-b0cb-494e-bf5c-2de9dba2ef9e", new DateTime(2024, 8, 16, 23, 36, 18, 477, DateTimeKind.Utc).AddTicks(2779), new DateTime(2024, 8, 16, 23, 36, 18, 477, DateTimeKind.Utc).AddTicks(2780), new DateTime(2024, 8, 17, 3, 36, 18, 477, DateTimeKind.Local).AddTicks(2774) });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: 2054,
                columns: new[] { "ConcurrencyStamp", "CreatedTime", "LastUpdatedTime", "RefreshTokenCreateTime" },
                values: new object[] { "552a6640-6bc8-448a-936f-b1dad705b146", new DateTime(2024, 8, 16, 23, 36, 18, 477, DateTimeKind.Utc).AddTicks(2793), new DateTime(2024, 8, 16, 23, 36, 18, 477, DateTimeKind.Utc).AddTicks(2793), new DateTime(2024, 8, 17, 3, 36, 18, 477, DateTimeKind.Local).AddTicks(2788) });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: 2055,
                columns: new[] { "ConcurrencyStamp", "CreatedTime", "LastUpdatedTime", "RefreshTokenCreateTime" },
                values: new object[] { "da286558-2d79-4b4e-b510-43adbf440dc1", new DateTime(2024, 8, 16, 23, 36, 18, 477, DateTimeKind.Utc).AddTicks(2806), new DateTime(2024, 8, 16, 23, 36, 18, 477, DateTimeKind.Utc).AddTicks(2806), new DateTime(2024, 8, 17, 3, 36, 18, 477, DateTimeKind.Local).AddTicks(2801) });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: 2056,
                columns: new[] { "ConcurrencyStamp", "CreatedTime", "LastUpdatedTime", "RefreshTokenCreateTime" },
                values: new object[] { "096c5be7-d7fc-4154-8524-ab49d000f807", new DateTime(2024, 8, 16, 23, 36, 18, 477, DateTimeKind.Utc).AddTicks(2820), new DateTime(2024, 8, 16, 23, 36, 18, 477, DateTimeKind.Utc).AddTicks(2820), new DateTime(2024, 8, 17, 3, 36, 18, 477, DateTimeKind.Local).AddTicks(2814) });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: 2057,
                columns: new[] { "ConcurrencyStamp", "CreatedTime", "LastUpdatedTime", "RefreshTokenCreateTime" },
                values: new object[] { "7af4599b-0eea-4c54-81ca-4ecb8c18cfc0", new DateTime(2024, 8, 16, 23, 36, 18, 477, DateTimeKind.Utc).AddTicks(2833), new DateTime(2024, 8, 16, 23, 36, 18, 477, DateTimeKind.Utc).AddTicks(2833), new DateTime(2024, 8, 17, 3, 36, 18, 477, DateTimeKind.Local).AddTicks(2828) });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: 2058,
                columns: new[] { "ConcurrencyStamp", "CreatedTime", "LastUpdatedTime", "RefreshTokenCreateTime" },
                values: new object[] { "5ffee3c5-d1ea-41c5-941d-86ed7291cef4", new DateTime(2024, 8, 16, 23, 36, 18, 477, DateTimeKind.Utc).AddTicks(2846), new DateTime(2024, 8, 16, 23, 36, 18, 477, DateTimeKind.Utc).AddTicks(2847), new DateTime(2024, 8, 17, 3, 36, 18, 477, DateTimeKind.Local).AddTicks(2841) });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: 2059,
                columns: new[] { "ConcurrencyStamp", "CreatedTime", "LastUpdatedTime", "RefreshTokenCreateTime" },
                values: new object[] { "e00ca8a6-b642-4f48-addf-76a52c8b9789", new DateTime(2024, 8, 16, 23, 36, 18, 477, DateTimeKind.Utc).AddTicks(2906), new DateTime(2024, 8, 16, 23, 36, 18, 477, DateTimeKind.Utc).AddTicks(2906), new DateTime(2024, 8, 17, 3, 36, 18, 477, DateTimeKind.Local).AddTicks(2854) });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: 2060,
                columns: new[] { "ConcurrencyStamp", "CreatedTime", "LastUpdatedTime", "RefreshTokenCreateTime" },
                values: new object[] { "2c2007b8-ffe4-4876-8ec8-1c81ddac162d", new DateTime(2024, 8, 16, 23, 36, 18, 477, DateTimeKind.Utc).AddTicks(2920), new DateTime(2024, 8, 16, 23, 36, 18, 477, DateTimeKind.Utc).AddTicks(2921), new DateTime(2024, 8, 17, 3, 36, 18, 477, DateTimeKind.Local).AddTicks(2914) });
        }
    }
}
