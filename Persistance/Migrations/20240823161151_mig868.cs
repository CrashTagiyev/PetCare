using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Persistance.Migrations
{
    /// <inheritdoc />
    public partial class mig868 : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.RenameColumn(
                name: "Street",
                table: "Shelters",
                newName: "Address");

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: 2001,
                columns: new[] { "ConcurrencyStamp", "CreatedTime", "LastUpdatedTime", "RefreshTokenCreateTime" },
                values: new object[] { "c71366a6-a3e3-47ec-b904-52125c77b61e", new DateTime(2024, 8, 23, 16, 11, 50, 144, DateTimeKind.Utc).AddTicks(4815), new DateTime(2024, 8, 23, 16, 11, 50, 144, DateTimeKind.Utc).AddTicks(4817), new DateTime(2024, 8, 23, 16, 11, 50, 144, DateTimeKind.Utc).AddTicks(4748) });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: 2002,
                columns: new[] { "ConcurrencyStamp", "CreatedTime", "LastUpdatedTime", "RefreshTokenCreateTime" },
                values: new object[] { "f91aa314-6298-452e-b1d7-e8d93dac9f26", new DateTime(2024, 8, 23, 16, 11, 50, 144, DateTimeKind.Utc).AddTicks(4874), new DateTime(2024, 8, 23, 16, 11, 50, 144, DateTimeKind.Utc).AddTicks(4874), new DateTime(2024, 8, 23, 16, 11, 50, 144, DateTimeKind.Utc).AddTicks(4870) });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: 2003,
                columns: new[] { "ConcurrencyStamp", "CreatedTime", "LastUpdatedTime", "RefreshTokenCreateTime" },
                values: new object[] { "f0f593f4-90fc-46a1-b434-f6d04ead1f49", new DateTime(2024, 8, 23, 16, 11, 50, 144, DateTimeKind.Utc).AddTicks(4886), new DateTime(2024, 8, 23, 16, 11, 50, 144, DateTimeKind.Utc).AddTicks(4886), new DateTime(2024, 8, 23, 16, 11, 50, 144, DateTimeKind.Utc).AddTicks(4882) });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: 2004,
                columns: new[] { "ConcurrencyStamp", "CreatedTime", "LastUpdatedTime", "RefreshTokenCreateTime" },
                values: new object[] { "42b48ddc-7745-4599-b023-60aa823f065f", new DateTime(2024, 8, 23, 16, 11, 50, 144, DateTimeKind.Utc).AddTicks(4896), new DateTime(2024, 8, 23, 16, 11, 50, 144, DateTimeKind.Utc).AddTicks(4897), new DateTime(2024, 8, 23, 16, 11, 50, 144, DateTimeKind.Utc).AddTicks(4894) });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: 2005,
                columns: new[] { "ConcurrencyStamp", "CreatedTime", "LastUpdatedTime", "RefreshTokenCreateTime" },
                values: new object[] { "c93607b8-f589-4a33-9d5a-229b02799b4e", new DateTime(2024, 8, 23, 16, 11, 50, 144, DateTimeKind.Utc).AddTicks(4920), new DateTime(2024, 8, 23, 16, 11, 50, 144, DateTimeKind.Utc).AddTicks(4920), new DateTime(2024, 8, 23, 16, 11, 50, 144, DateTimeKind.Utc).AddTicks(4904) });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: 2006,
                columns: new[] { "ConcurrencyStamp", "CreatedTime", "LastUpdatedTime", "RefreshTokenCreateTime" },
                values: new object[] { "cbdcaec5-a434-4982-8c89-ec7a2f66f489", new DateTime(2024, 8, 23, 16, 11, 50, 144, DateTimeKind.Utc).AddTicks(4996), new DateTime(2024, 8, 23, 16, 11, 50, 144, DateTimeKind.Utc).AddTicks(4996), new DateTime(2024, 8, 23, 16, 11, 50, 144, DateTimeKind.Utc).AddTicks(4992) });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: 2007,
                columns: new[] { "ConcurrencyStamp", "CreatedTime", "LastUpdatedTime", "RefreshTokenCreateTime" },
                values: new object[] { "03b41c9f-6ad5-495b-b92c-b8d7a2c16fe8", new DateTime(2024, 8, 23, 16, 11, 50, 144, DateTimeKind.Utc).AddTicks(5007), new DateTime(2024, 8, 23, 16, 11, 50, 144, DateTimeKind.Utc).AddTicks(5007), new DateTime(2024, 8, 23, 16, 11, 50, 144, DateTimeKind.Utc).AddTicks(5004) });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: 2008,
                columns: new[] { "ConcurrencyStamp", "CreatedTime", "LastUpdatedTime", "RefreshTokenCreateTime" },
                values: new object[] { "91325f16-0ae5-4ff3-99a4-a7c6701c3898", new DateTime(2024, 8, 23, 16, 11, 50, 144, DateTimeKind.Utc).AddTicks(5018), new DateTime(2024, 8, 23, 16, 11, 50, 144, DateTimeKind.Utc).AddTicks(5019), new DateTime(2024, 8, 23, 16, 11, 50, 144, DateTimeKind.Utc).AddTicks(5015) });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: 2009,
                columns: new[] { "ConcurrencyStamp", "CreatedTime", "LastUpdatedTime", "RefreshTokenCreateTime" },
                values: new object[] { "b1cb36ee-c5f2-44c0-bfc3-cd095c0de3a9", new DateTime(2024, 8, 23, 16, 11, 50, 144, DateTimeKind.Utc).AddTicks(5029), new DateTime(2024, 8, 23, 16, 11, 50, 144, DateTimeKind.Utc).AddTicks(5030), new DateTime(2024, 8, 23, 16, 11, 50, 144, DateTimeKind.Utc).AddTicks(5026) });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: 2010,
                columns: new[] { "ConcurrencyStamp", "CreatedTime", "LastUpdatedTime", "RefreshTokenCreateTime" },
                values: new object[] { "7c354413-e1de-413a-b12e-c50ae09ca6a5", new DateTime(2024, 8, 23, 16, 11, 50, 144, DateTimeKind.Utc).AddTicks(5041), new DateTime(2024, 8, 23, 16, 11, 50, 144, DateTimeKind.Utc).AddTicks(5041), new DateTime(2024, 8, 23, 16, 11, 50, 144, DateTimeKind.Utc).AddTicks(5038) });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: 2011,
                columns: new[] { "ConcurrencyStamp", "CreatedTime", "LastUpdatedTime", "RefreshTokenCreateTime" },
                values: new object[] { "d7423d8b-1328-4568-9abd-b3bd6d08918e", new DateTime(2024, 8, 23, 16, 11, 50, 144, DateTimeKind.Utc).AddTicks(5055), new DateTime(2024, 8, 23, 16, 11, 50, 144, DateTimeKind.Utc).AddTicks(5055), new DateTime(2024, 8, 23, 16, 11, 50, 144, DateTimeKind.Utc).AddTicks(5051) });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: 2012,
                columns: new[] { "ConcurrencyStamp", "CreatedTime", "LastUpdatedTime", "RefreshTokenCreateTime" },
                values: new object[] { "9fca1b59-e9ea-4872-b945-7107f058a4f2", new DateTime(2024, 8, 23, 16, 11, 50, 144, DateTimeKind.Utc).AddTicks(5065), new DateTime(2024, 8, 23, 16, 11, 50, 144, DateTimeKind.Utc).AddTicks(5066), new DateTime(2024, 8, 23, 16, 11, 50, 144, DateTimeKind.Utc).AddTicks(5063) });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: 2013,
                columns: new[] { "ConcurrencyStamp", "CreatedTime", "LastUpdatedTime", "RefreshTokenCreateTime" },
                values: new object[] { "ceeecfac-bef6-4658-b26a-6e0a9ac03e81", new DateTime(2024, 8, 23, 16, 11, 50, 144, DateTimeKind.Utc).AddTicks(5081), new DateTime(2024, 8, 23, 16, 11, 50, 144, DateTimeKind.Utc).AddTicks(5081), new DateTime(2024, 8, 23, 16, 11, 50, 144, DateTimeKind.Utc).AddTicks(5074) });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: 2014,
                columns: new[] { "ConcurrencyStamp", "CreatedTime", "LastUpdatedTime", "RefreshTokenCreateTime" },
                values: new object[] { "7b260432-9e1b-4a08-88a1-57bca350b284", new DateTime(2024, 8, 23, 16, 11, 50, 144, DateTimeKind.Utc).AddTicks(5092), new DateTime(2024, 8, 23, 16, 11, 50, 144, DateTimeKind.Utc).AddTicks(5093), new DateTime(2024, 8, 23, 16, 11, 50, 144, DateTimeKind.Utc).AddTicks(5089) });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: 2015,
                columns: new[] { "ConcurrencyStamp", "CreatedTime", "LastUpdatedTime", "RefreshTokenCreateTime" },
                values: new object[] { "59092ed1-ac66-4f1e-8d53-3ee4f039a34f", new DateTime(2024, 8, 23, 16, 11, 50, 144, DateTimeKind.Utc).AddTicks(5140), new DateTime(2024, 8, 23, 16, 11, 50, 144, DateTimeKind.Utc).AddTicks(5140), new DateTime(2024, 8, 23, 16, 11, 50, 144, DateTimeKind.Utc).AddTicks(5100) });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: 2016,
                columns: new[] { "ConcurrencyStamp", "CreatedTime", "LastUpdatedTime", "RefreshTokenCreateTime" },
                values: new object[] { "5f96be55-7e02-4216-af89-bc427674b687", new DateTime(2024, 8, 23, 16, 11, 50, 144, DateTimeKind.Utc).AddTicks(5153), new DateTime(2024, 8, 23, 16, 11, 50, 144, DateTimeKind.Utc).AddTicks(5153), new DateTime(2024, 8, 23, 16, 11, 50, 144, DateTimeKind.Utc).AddTicks(5150) });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: 2017,
                columns: new[] { "ConcurrencyStamp", "CreatedTime", "LastUpdatedTime", "RefreshTokenCreateTime" },
                values: new object[] { "a36d08bb-970e-4052-ae57-dff724bd9fdc", new DateTime(2024, 8, 23, 16, 11, 50, 144, DateTimeKind.Utc).AddTicks(5164), new DateTime(2024, 8, 23, 16, 11, 50, 144, DateTimeKind.Utc).AddTicks(5165), new DateTime(2024, 8, 23, 16, 11, 50, 144, DateTimeKind.Utc).AddTicks(5161) });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: 2018,
                columns: new[] { "ConcurrencyStamp", "CreatedTime", "LastUpdatedTime", "RefreshTokenCreateTime" },
                values: new object[] { "89685657-8603-4ca9-9f12-56edfb7b0027", new DateTime(2024, 8, 23, 16, 11, 50, 144, DateTimeKind.Utc).AddTicks(5178), new DateTime(2024, 8, 23, 16, 11, 50, 144, DateTimeKind.Utc).AddTicks(5178), new DateTime(2024, 8, 23, 16, 11, 50, 144, DateTimeKind.Utc).AddTicks(5174) });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: 2019,
                columns: new[] { "ConcurrencyStamp", "CreatedTime", "LastUpdatedTime", "RefreshTokenCreateTime" },
                values: new object[] { "bc6d6b5f-c29d-40ce-a079-dc40d418b752", new DateTime(2024, 8, 23, 16, 11, 50, 144, DateTimeKind.Utc).AddTicks(5190), new DateTime(2024, 8, 23, 16, 11, 50, 144, DateTimeKind.Utc).AddTicks(5190), new DateTime(2024, 8, 23, 16, 11, 50, 144, DateTimeKind.Utc).AddTicks(5186) });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: 2020,
                columns: new[] { "ConcurrencyStamp", "CreatedTime", "LastUpdatedTime", "RefreshTokenCreateTime" },
                values: new object[] { "a2d95f7d-dbc1-49c3-9e7c-3547d13f7029", new DateTime(2024, 8, 23, 16, 11, 50, 144, DateTimeKind.Utc).AddTicks(5201), new DateTime(2024, 8, 23, 16, 11, 50, 144, DateTimeKind.Utc).AddTicks(5201), new DateTime(2024, 8, 23, 16, 11, 50, 144, DateTimeKind.Utc).AddTicks(5198) });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: 2021,
                columns: new[] { "ConcurrencyStamp", "CreatedTime", "LastUpdatedTime", "RefreshTokenCreateTime" },
                values: new object[] { "d8dbf998-e38a-4adb-9bda-481519a03f39", new DateTime(2024, 8, 23, 16, 11, 50, 144, DateTimeKind.Utc).AddTicks(5215), new DateTime(2024, 8, 23, 16, 11, 50, 144, DateTimeKind.Utc).AddTicks(5216), new DateTime(2024, 8, 23, 16, 11, 50, 144, DateTimeKind.Utc).AddTicks(5209) });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: 2022,
                columns: new[] { "ConcurrencyStamp", "CreatedTime", "LastUpdatedTime", "RefreshTokenCreateTime" },
                values: new object[] { "05a43a5f-5b79-44c7-a39c-a48db191faf8", new DateTime(2024, 8, 23, 16, 11, 50, 144, DateTimeKind.Utc).AddTicks(5234), new DateTime(2024, 8, 23, 16, 11, 50, 144, DateTimeKind.Utc).AddTicks(5235), new DateTime(2024, 8, 23, 16, 11, 50, 144, DateTimeKind.Utc).AddTicks(5231) });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: 2023,
                columns: new[] { "ConcurrencyStamp", "CreatedTime", "LastUpdatedTime", "RefreshTokenCreateTime" },
                values: new object[] { "754a4406-9df3-4d87-b894-9c4c5dd10e75", new DateTime(2024, 8, 23, 16, 11, 50, 144, DateTimeKind.Utc).AddTicks(5247), new DateTime(2024, 8, 23, 16, 11, 50, 144, DateTimeKind.Utc).AddTicks(5248), new DateTime(2024, 8, 23, 16, 11, 50, 144, DateTimeKind.Utc).AddTicks(5244) });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: 2024,
                columns: new[] { "ConcurrencyStamp", "CreatedTime", "LastUpdatedTime", "RefreshTokenCreateTime" },
                values: new object[] { "731b620d-5888-4a58-8161-16a30f94d8ad", new DateTime(2024, 8, 23, 16, 11, 50, 144, DateTimeKind.Utc).AddTicks(5260), new DateTime(2024, 8, 23, 16, 11, 50, 144, DateTimeKind.Utc).AddTicks(5260), new DateTime(2024, 8, 23, 16, 11, 50, 144, DateTimeKind.Utc).AddTicks(5257) });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: 2025,
                columns: new[] { "ConcurrencyStamp", "CreatedTime", "LastUpdatedTime", "RefreshTokenCreateTime" },
                values: new object[] { "8def06e1-9019-44bf-b043-f8cc80ae78be", new DateTime(2024, 8, 23, 16, 11, 50, 144, DateTimeKind.Utc).AddTicks(5311), new DateTime(2024, 8, 23, 16, 11, 50, 144, DateTimeKind.Utc).AddTicks(5311), new DateTime(2024, 8, 23, 16, 11, 50, 144, DateTimeKind.Utc).AddTicks(5308) });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: 2026,
                columns: new[] { "ConcurrencyStamp", "CreatedTime", "LastUpdatedTime", "RefreshTokenCreateTime" },
                values: new object[] { "2ee19abf-180d-41ac-85fe-1f2369edcf50", new DateTime(2024, 8, 23, 16, 11, 50, 144, DateTimeKind.Utc).AddTicks(5324), new DateTime(2024, 8, 23, 16, 11, 50, 144, DateTimeKind.Utc).AddTicks(5324), new DateTime(2024, 8, 23, 16, 11, 50, 144, DateTimeKind.Utc).AddTicks(5321) });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: 2027,
                columns: new[] { "ConcurrencyStamp", "CreatedTime", "LastUpdatedTime", "RefreshTokenCreateTime" },
                values: new object[] { "011b23a0-3664-4487-bfd7-4812e73b3268", new DateTime(2024, 8, 23, 16, 11, 50, 144, DateTimeKind.Utc).AddTicks(5336), new DateTime(2024, 8, 23, 16, 11, 50, 144, DateTimeKind.Utc).AddTicks(5337), new DateTime(2024, 8, 23, 16, 11, 50, 144, DateTimeKind.Utc).AddTicks(5333) });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: 2028,
                columns: new[] { "ConcurrencyStamp", "CreatedTime", "LastUpdatedTime", "RefreshTokenCreateTime" },
                values: new object[] { "749c7a78-7a6e-413d-bc7e-f75cae9f3638", new DateTime(2024, 8, 23, 16, 11, 50, 144, DateTimeKind.Utc).AddTicks(5348), new DateTime(2024, 8, 23, 16, 11, 50, 144, DateTimeKind.Utc).AddTicks(5349), new DateTime(2024, 8, 23, 16, 11, 50, 144, DateTimeKind.Utc).AddTicks(5345) });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: 2029,
                columns: new[] { "ConcurrencyStamp", "CreatedTime", "LastUpdatedTime", "RefreshTokenCreateTime" },
                values: new object[] { "85de7688-1fb0-486b-8e0f-cf6ad0de31f0", new DateTime(2024, 8, 23, 16, 11, 50, 144, DateTimeKind.Utc).AddTicks(5364), new DateTime(2024, 8, 23, 16, 11, 50, 144, DateTimeKind.Utc).AddTicks(5364), new DateTime(2024, 8, 23, 16, 11, 50, 144, DateTimeKind.Utc).AddTicks(5358) });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: 2030,
                columns: new[] { "ConcurrencyStamp", "CreatedTime", "LastUpdatedTime", "RefreshTokenCreateTime" },
                values: new object[] { "796df097-5d80-4bb5-885c-ef634bfd9b59", new DateTime(2024, 8, 23, 16, 11, 50, 144, DateTimeKind.Utc).AddTicks(5377), new DateTime(2024, 8, 23, 16, 11, 50, 144, DateTimeKind.Utc).AddTicks(5377), new DateTime(2024, 8, 23, 16, 11, 50, 144, DateTimeKind.Utc).AddTicks(5373) });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: 2031,
                columns: new[] { "ConcurrencyStamp", "CreatedTime", "LastUpdatedTime", "RefreshTokenCreateTime" },
                values: new object[] { "d2c8007c-863b-4062-bae3-bc2affa1a665", new DateTime(2024, 8, 23, 16, 11, 50, 144, DateTimeKind.Utc).AddTicks(5388), new DateTime(2024, 8, 23, 16, 11, 50, 144, DateTimeKind.Utc).AddTicks(5389), new DateTime(2024, 8, 23, 16, 11, 50, 144, DateTimeKind.Utc).AddTicks(5385) });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: 2032,
                columns: new[] { "ConcurrencyStamp", "CreatedTime", "LastUpdatedTime", "RefreshTokenCreateTime" },
                values: new object[] { "a9d87dcd-3023-46ca-a2b0-5866b71c8ed4", new DateTime(2024, 8, 23, 16, 11, 50, 144, DateTimeKind.Utc).AddTicks(5400), new DateTime(2024, 8, 23, 16, 11, 50, 144, DateTimeKind.Utc).AddTicks(5401), new DateTime(2024, 8, 23, 16, 11, 50, 144, DateTimeKind.Utc).AddTicks(5397) });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: 2033,
                columns: new[] { "ConcurrencyStamp", "CreatedTime", "LastUpdatedTime", "RefreshTokenCreateTime" },
                values: new object[] { "cd7fa887-1e4d-4e46-a214-bd86f2720c2a", new DateTime(2024, 8, 23, 16, 11, 50, 144, DateTimeKind.Utc).AddTicks(5448), new DateTime(2024, 8, 23, 16, 11, 50, 144, DateTimeKind.Utc).AddTicks(5449), new DateTime(2024, 8, 23, 16, 11, 50, 144, DateTimeKind.Utc).AddTicks(5409) });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: 2034,
                columns: new[] { "ConcurrencyStamp", "CreatedTime", "LastUpdatedTime", "RefreshTokenCreateTime" },
                values: new object[] { "dced3eb5-a567-4cfb-b6f7-5aeeb4523668", new DateTime(2024, 8, 23, 16, 11, 50, 144, DateTimeKind.Utc).AddTicks(5463), new DateTime(2024, 8, 23, 16, 11, 50, 144, DateTimeKind.Utc).AddTicks(5464), new DateTime(2024, 8, 23, 16, 11, 50, 144, DateTimeKind.Utc).AddTicks(5460) });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: 2035,
                columns: new[] { "ConcurrencyStamp", "CreatedTime", "LastUpdatedTime", "RefreshTokenCreateTime" },
                values: new object[] { "e1e7b623-1322-4665-ac04-9afe38f1fb11", new DateTime(2024, 8, 23, 16, 11, 50, 144, DateTimeKind.Utc).AddTicks(5477), new DateTime(2024, 8, 23, 16, 11, 50, 144, DateTimeKind.Utc).AddTicks(5477), new DateTime(2024, 8, 23, 16, 11, 50, 144, DateTimeKind.Utc).AddTicks(5473) });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: 2036,
                columns: new[] { "ConcurrencyStamp", "CreatedTime", "LastUpdatedTime", "RefreshTokenCreateTime" },
                values: new object[] { "fe9d1d9c-4f16-482a-bfe5-9e280a23a0ac", new DateTime(2024, 8, 23, 16, 11, 50, 144, DateTimeKind.Utc).AddTicks(5489), new DateTime(2024, 8, 23, 16, 11, 50, 144, DateTimeKind.Utc).AddTicks(5490), new DateTime(2024, 8, 23, 16, 11, 50, 144, DateTimeKind.Utc).AddTicks(5487) });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: 2037,
                columns: new[] { "ConcurrencyStamp", "CreatedTime", "LastUpdatedTime", "RefreshTokenCreateTime" },
                values: new object[] { "4c0bc076-79f8-46ac-b479-d8e43d42d861", new DateTime(2024, 8, 23, 16, 11, 50, 144, DateTimeKind.Utc).AddTicks(5505), new DateTime(2024, 8, 23, 16, 11, 50, 144, DateTimeKind.Utc).AddTicks(5505), new DateTime(2024, 8, 23, 16, 11, 50, 144, DateTimeKind.Utc).AddTicks(5499) });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: 2038,
                columns: new[] { "ConcurrencyStamp", "CreatedTime", "LastUpdatedTime", "RefreshTokenCreateTime" },
                values: new object[] { "26a46c20-e26d-4bf3-a58e-86bf9f737857", new DateTime(2024, 8, 23, 16, 11, 50, 144, DateTimeKind.Utc).AddTicks(5518), new DateTime(2024, 8, 23, 16, 11, 50, 144, DateTimeKind.Utc).AddTicks(5518), new DateTime(2024, 8, 23, 16, 11, 50, 144, DateTimeKind.Utc).AddTicks(5515) });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: 2039,
                columns: new[] { "ConcurrencyStamp", "CreatedTime", "LastUpdatedTime", "RefreshTokenCreateTime" },
                values: new object[] { "991c3642-cfc9-462b-8985-7f08f3c669a1", new DateTime(2024, 8, 23, 16, 11, 50, 144, DateTimeKind.Utc).AddTicks(5530), new DateTime(2024, 8, 23, 16, 11, 50, 144, DateTimeKind.Utc).AddTicks(5530), new DateTime(2024, 8, 23, 16, 11, 50, 144, DateTimeKind.Utc).AddTicks(5527) });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: 2040,
                columns: new[] { "ConcurrencyStamp", "CreatedTime", "LastUpdatedTime", "RefreshTokenCreateTime" },
                values: new object[] { "c2bb5308-29d6-4e3b-b479-c093f2a63535", new DateTime(2024, 8, 23, 16, 11, 50, 144, DateTimeKind.Utc).AddTicks(5542), new DateTime(2024, 8, 23, 16, 11, 50, 144, DateTimeKind.Utc).AddTicks(5543), new DateTime(2024, 8, 23, 16, 11, 50, 144, DateTimeKind.Utc).AddTicks(5539) });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: 2041,
                columns: new[] { "ConcurrencyStamp", "CreatedTime", "LastUpdatedTime", "RefreshTokenCreateTime" },
                values: new object[] { "04ddd823-9775-4d94-8d81-ca45724ef181", new DateTime(2024, 8, 23, 16, 11, 50, 144, DateTimeKind.Utc).AddTicks(5555), new DateTime(2024, 8, 23, 16, 11, 50, 144, DateTimeKind.Utc).AddTicks(5555), new DateTime(2024, 8, 23, 16, 11, 50, 144, DateTimeKind.Utc).AddTicks(5552) });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: 2042,
                columns: new[] { "ConcurrencyStamp", "CreatedTime", "LastUpdatedTime", "RefreshTokenCreateTime" },
                values: new object[] { "c2d593a7-82ea-4d24-b894-f5b3453b9856", new DateTime(2024, 8, 23, 16, 11, 50, 144, DateTimeKind.Utc).AddTicks(5608), new DateTime(2024, 8, 23, 16, 11, 50, 144, DateTimeKind.Utc).AddTicks(5608), new DateTime(2024, 8, 23, 16, 11, 50, 144, DateTimeKind.Utc).AddTicks(5604) });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: 2043,
                columns: new[] { "ConcurrencyStamp", "CreatedTime", "LastUpdatedTime", "RefreshTokenCreateTime" },
                values: new object[] { "21c134b1-8b83-46fa-88bb-dcfb4276ce6e", new DateTime(2024, 8, 23, 16, 11, 50, 144, DateTimeKind.Utc).AddTicks(5621), new DateTime(2024, 8, 23, 16, 11, 50, 144, DateTimeKind.Utc).AddTicks(5621), new DateTime(2024, 8, 23, 16, 11, 50, 144, DateTimeKind.Utc).AddTicks(5618) });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: 2044,
                columns: new[] { "ConcurrencyStamp", "CreatedTime", "LastUpdatedTime", "RefreshTokenCreateTime" },
                values: new object[] { "4a714796-4903-4f02-962d-b135115caac4", new DateTime(2024, 8, 23, 16, 11, 50, 144, DateTimeKind.Utc).AddTicks(5632), new DateTime(2024, 8, 23, 16, 11, 50, 144, DateTimeKind.Utc).AddTicks(5632), new DateTime(2024, 8, 23, 16, 11, 50, 144, DateTimeKind.Utc).AddTicks(5629) });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: 2045,
                columns: new[] { "ConcurrencyStamp", "CreatedTime", "LastUpdatedTime", "RefreshTokenCreateTime" },
                values: new object[] { "050fca7c-c3e2-4557-9578-fe9c072b14c4", new DateTime(2024, 8, 23, 16, 11, 50, 144, DateTimeKind.Utc).AddTicks(5647), new DateTime(2024, 8, 23, 16, 11, 50, 144, DateTimeKind.Utc).AddTicks(5647), new DateTime(2024, 8, 23, 16, 11, 50, 144, DateTimeKind.Utc).AddTicks(5641) });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: 2046,
                columns: new[] { "ConcurrencyStamp", "CreatedTime", "LastUpdatedTime", "RefreshTokenCreateTime" },
                values: new object[] { "c05bc62d-db38-4d5e-8c10-82e6fae119c1", new DateTime(2024, 8, 23, 16, 11, 50, 144, DateTimeKind.Utc).AddTicks(5658), new DateTime(2024, 8, 23, 16, 11, 50, 144, DateTimeKind.Utc).AddTicks(5658), new DateTime(2024, 8, 23, 16, 11, 50, 144, DateTimeKind.Utc).AddTicks(5655) });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: 2047,
                columns: new[] { "ConcurrencyStamp", "CreatedTime", "LastUpdatedTime", "RefreshTokenCreateTime" },
                values: new object[] { "e18e7c34-da6e-49fa-8c5c-8dfac1fa6a70", new DateTime(2024, 8, 23, 16, 11, 50, 144, DateTimeKind.Utc).AddTicks(5670), new DateTime(2024, 8, 23, 16, 11, 50, 144, DateTimeKind.Utc).AddTicks(5670), new DateTime(2024, 8, 23, 16, 11, 50, 144, DateTimeKind.Utc).AddTicks(5666) });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: 2048,
                columns: new[] { "ConcurrencyStamp", "CreatedTime", "LastUpdatedTime", "RefreshTokenCreateTime" },
                values: new object[] { "cfa8f4c8-748f-4a40-a012-287ea912f13a", new DateTime(2024, 8, 23, 16, 11, 50, 144, DateTimeKind.Utc).AddTicks(5681), new DateTime(2024, 8, 23, 16, 11, 50, 144, DateTimeKind.Utc).AddTicks(5682), new DateTime(2024, 8, 23, 16, 11, 50, 144, DateTimeKind.Utc).AddTicks(5678) });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: 2049,
                columns: new[] { "ConcurrencyStamp", "CreatedTime", "LastUpdatedTime", "RefreshTokenCreateTime" },
                values: new object[] { "e02f4047-e4e8-4621-afb4-ae1b22f13451", new DateTime(2024, 8, 23, 16, 11, 50, 144, DateTimeKind.Utc).AddTicks(5693), new DateTime(2024, 8, 23, 16, 11, 50, 144, DateTimeKind.Utc).AddTicks(5693), new DateTime(2024, 8, 23, 16, 11, 50, 144, DateTimeKind.Utc).AddTicks(5690) });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: 2050,
                columns: new[] { "ConcurrencyStamp", "CreatedTime", "LastUpdatedTime", "RefreshTokenCreateTime" },
                values: new object[] { "cdf01deb-e88d-4d48-92c5-d826b8b61556", new DateTime(2024, 8, 23, 16, 11, 50, 144, DateTimeKind.Utc).AddTicks(5704), new DateTime(2024, 8, 23, 16, 11, 50, 144, DateTimeKind.Utc).AddTicks(5705), new DateTime(2024, 8, 23, 16, 11, 50, 144, DateTimeKind.Utc).AddTicks(5701) });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: 2051,
                columns: new[] { "ConcurrencyStamp", "CreatedTime", "LastUpdatedTime", "RefreshTokenCreateTime" },
                values: new object[] { "cd8019f7-e9ca-43dc-8b09-6112e9e912c8", new DateTime(2024, 8, 23, 16, 11, 50, 144, DateTimeKind.Utc).AddTicks(5716), new DateTime(2024, 8, 23, 16, 11, 50, 144, DateTimeKind.Utc).AddTicks(5716), new DateTime(2024, 8, 23, 16, 11, 50, 144, DateTimeKind.Utc).AddTicks(5713) });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: 2052,
                columns: new[] { "ConcurrencyStamp", "CreatedTime", "LastUpdatedTime", "RefreshTokenCreateTime" },
                values: new object[] { "e1c088a4-217d-41a5-8e9f-459c1dc31704", new DateTime(2024, 8, 23, 16, 11, 50, 144, DateTimeKind.Utc).AddTicks(5764), new DateTime(2024, 8, 23, 16, 11, 50, 144, DateTimeKind.Utc).AddTicks(5765), new DateTime(2024, 8, 23, 16, 11, 50, 144, DateTimeKind.Utc).AddTicks(5761) });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: 2053,
                columns: new[] { "ConcurrencyStamp", "CreatedTime", "LastUpdatedTime", "RefreshTokenCreateTime" },
                values: new object[] { "c7a46255-ed12-4adf-a5c4-430c17051aa6", new DateTime(2024, 8, 23, 16, 11, 50, 144, DateTimeKind.Utc).AddTicks(5780), new DateTime(2024, 8, 23, 16, 11, 50, 144, DateTimeKind.Utc).AddTicks(5780), new DateTime(2024, 8, 23, 16, 11, 50, 144, DateTimeKind.Utc).AddTicks(5773) });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: 2054,
                columns: new[] { "ConcurrencyStamp", "CreatedTime", "LastUpdatedTime", "RefreshTokenCreateTime" },
                values: new object[] { "6631c247-e097-45d8-a93b-648d7f702eb2", new DateTime(2024, 8, 23, 16, 11, 50, 144, DateTimeKind.Utc).AddTicks(5791), new DateTime(2024, 8, 23, 16, 11, 50, 144, DateTimeKind.Utc).AddTicks(5791), new DateTime(2024, 8, 23, 16, 11, 50, 144, DateTimeKind.Utc).AddTicks(5788) });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: 2055,
                columns: new[] { "ConcurrencyStamp", "CreatedTime", "LastUpdatedTime", "RefreshTokenCreateTime" },
                values: new object[] { "dd554c9d-dca9-4a66-aeaa-f7496f9ff29b", new DateTime(2024, 8, 23, 16, 11, 50, 144, DateTimeKind.Utc).AddTicks(5802), new DateTime(2024, 8, 23, 16, 11, 50, 144, DateTimeKind.Utc).AddTicks(5802), new DateTime(2024, 8, 23, 16, 11, 50, 144, DateTimeKind.Utc).AddTicks(5798) });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: 2056,
                columns: new[] { "ConcurrencyStamp", "CreatedTime", "LastUpdatedTime", "RefreshTokenCreateTime" },
                values: new object[] { "6bdd9695-2af0-40ef-9a07-dc3b779a5e37", new DateTime(2024, 8, 23, 16, 11, 50, 144, DateTimeKind.Utc).AddTicks(5813), new DateTime(2024, 8, 23, 16, 11, 50, 144, DateTimeKind.Utc).AddTicks(5813), new DateTime(2024, 8, 23, 16, 11, 50, 144, DateTimeKind.Utc).AddTicks(5810) });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: 2057,
                columns: new[] { "ConcurrencyStamp", "CreatedTime", "LastUpdatedTime", "RefreshTokenCreateTime" },
                values: new object[] { "88a35141-25b7-4c58-9da4-35eac0fa4a75", new DateTime(2024, 8, 23, 16, 11, 50, 144, DateTimeKind.Utc).AddTicks(5824), new DateTime(2024, 8, 23, 16, 11, 50, 144, DateTimeKind.Utc).AddTicks(5824), new DateTime(2024, 8, 23, 16, 11, 50, 144, DateTimeKind.Utc).AddTicks(5821) });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: 2058,
                columns: new[] { "ConcurrencyStamp", "CreatedTime", "LastUpdatedTime", "RefreshTokenCreateTime" },
                values: new object[] { "0aded33c-26c2-4a10-9558-d6a9c551ecad", new DateTime(2024, 8, 23, 16, 11, 50, 144, DateTimeKind.Utc).AddTicks(5836), new DateTime(2024, 8, 23, 16, 11, 50, 144, DateTimeKind.Utc).AddTicks(5836), new DateTime(2024, 8, 23, 16, 11, 50, 144, DateTimeKind.Utc).AddTicks(5832) });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: 2059,
                columns: new[] { "ConcurrencyStamp", "CreatedTime", "LastUpdatedTime", "RefreshTokenCreateTime" },
                values: new object[] { "be2c9f93-a546-42f8-950d-a7bbb2af2370", new DateTime(2024, 8, 23, 16, 11, 50, 144, DateTimeKind.Utc).AddTicks(5847), new DateTime(2024, 8, 23, 16, 11, 50, 144, DateTimeKind.Utc).AddTicks(5848), new DateTime(2024, 8, 23, 16, 11, 50, 144, DateTimeKind.Utc).AddTicks(5844) });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: 2060,
                columns: new[] { "ConcurrencyStamp", "CreatedTime", "LastUpdatedTime", "RefreshTokenCreateTime" },
                values: new object[] { "5de01dd2-3c48-4fb5-8645-8ea3c258473f", new DateTime(2024, 8, 23, 16, 11, 50, 144, DateTimeKind.Utc).AddTicks(5859), new DateTime(2024, 8, 23, 16, 11, 50, 144, DateTimeKind.Utc).AddTicks(5859), new DateTime(2024, 8, 23, 16, 11, 50, 144, DateTimeKind.Utc).AddTicks(5856) });

            migrationBuilder.UpdateData(
                table: "Breeds",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedTime",
                value: new DateTime(2024, 8, 23, 20, 11, 50, 135, DateTimeKind.Local).AddTicks(5020));

            migrationBuilder.UpdateData(
                table: "Breeds",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreatedTime",
                value: new DateTime(2024, 8, 23, 20, 11, 50, 135, DateTimeKind.Local).AddTicks(5027));

            migrationBuilder.UpdateData(
                table: "Breeds",
                keyColumn: "Id",
                keyValue: 3,
                column: "CreatedTime",
                value: new DateTime(2024, 8, 23, 20, 11, 50, 135, DateTimeKind.Local).AddTicks(5029));

            migrationBuilder.UpdateData(
                table: "Breeds",
                keyColumn: "Id",
                keyValue: 4,
                column: "CreatedTime",
                value: new DateTime(2024, 8, 23, 20, 11, 50, 135, DateTimeKind.Local).AddTicks(5030));

            migrationBuilder.UpdateData(
                table: "Breeds",
                keyColumn: "Id",
                keyValue: 5,
                column: "CreatedTime",
                value: new DateTime(2024, 8, 23, 20, 11, 50, 135, DateTimeKind.Local).AddTicks(5032));

            migrationBuilder.UpdateData(
                table: "Breeds",
                keyColumn: "Id",
                keyValue: 6,
                column: "CreatedTime",
                value: new DateTime(2024, 8, 23, 20, 11, 50, 135, DateTimeKind.Local).AddTicks(5033));

            migrationBuilder.UpdateData(
                table: "Breeds",
                keyColumn: "Id",
                keyValue: 7,
                column: "CreatedTime",
                value: new DateTime(2024, 8, 23, 20, 11, 50, 135, DateTimeKind.Local).AddTicks(5034));

            migrationBuilder.UpdateData(
                table: "Breeds",
                keyColumn: "Id",
                keyValue: 8,
                column: "CreatedTime",
                value: new DateTime(2024, 8, 23, 20, 11, 50, 135, DateTimeKind.Local).AddTicks(5037));

            migrationBuilder.UpdateData(
                table: "Breeds",
                keyColumn: "Id",
                keyValue: 9,
                column: "CreatedTime",
                value: new DateTime(2024, 8, 23, 20, 11, 50, 135, DateTimeKind.Local).AddTicks(5038));

            migrationBuilder.UpdateData(
                table: "Breeds",
                keyColumn: "Id",
                keyValue: 10,
                column: "CreatedTime",
                value: new DateTime(2024, 8, 23, 20, 11, 50, 135, DateTimeKind.Local).AddTicks(5040));

            migrationBuilder.UpdateData(
                table: "Breeds",
                keyColumn: "Id",
                keyValue: 11,
                column: "CreatedTime",
                value: new DateTime(2024, 8, 23, 20, 11, 50, 135, DateTimeKind.Local).AddTicks(5041));

            migrationBuilder.UpdateData(
                table: "Breeds",
                keyColumn: "Id",
                keyValue: 12,
                column: "CreatedTime",
                value: new DateTime(2024, 8, 23, 20, 11, 50, 135, DateTimeKind.Local).AddTicks(5043));

            migrationBuilder.UpdateData(
                table: "Breeds",
                keyColumn: "Id",
                keyValue: 13,
                column: "CreatedTime",
                value: new DateTime(2024, 8, 23, 20, 11, 50, 135, DateTimeKind.Local).AddTicks(5045));

            migrationBuilder.UpdateData(
                table: "Breeds",
                keyColumn: "Id",
                keyValue: 14,
                column: "CreatedTime",
                value: new DateTime(2024, 8, 23, 20, 11, 50, 135, DateTimeKind.Local).AddTicks(5047));

            migrationBuilder.UpdateData(
                table: "Breeds",
                keyColumn: "Id",
                keyValue: 15,
                column: "CreatedTime",
                value: new DateTime(2024, 8, 23, 20, 11, 50, 135, DateTimeKind.Local).AddTicks(5049));

            migrationBuilder.UpdateData(
                table: "Breeds",
                keyColumn: "Id",
                keyValue: 16,
                column: "CreatedTime",
                value: new DateTime(2024, 8, 23, 20, 11, 50, 135, DateTimeKind.Local).AddTicks(5050));

            migrationBuilder.UpdateData(
                table: "Breeds",
                keyColumn: "Id",
                keyValue: 17,
                column: "CreatedTime",
                value: new DateTime(2024, 8, 23, 20, 11, 50, 135, DateTimeKind.Local).AddTicks(5051));

            migrationBuilder.UpdateData(
                table: "Breeds",
                keyColumn: "Id",
                keyValue: 18,
                column: "CreatedTime",
                value: new DateTime(2024, 8, 23, 20, 11, 50, 135, DateTimeKind.Local).AddTicks(5052));

            migrationBuilder.UpdateData(
                table: "Breeds",
                keyColumn: "Id",
                keyValue: 19,
                column: "CreatedTime",
                value: new DateTime(2024, 8, 23, 20, 11, 50, 135, DateTimeKind.Local).AddTicks(5054));

            migrationBuilder.UpdateData(
                table: "Breeds",
                keyColumn: "Id",
                keyValue: 20,
                column: "CreatedTime",
                value: new DateTime(2024, 8, 23, 20, 11, 50, 135, DateTimeKind.Local).AddTicks(5055));

            migrationBuilder.UpdateData(
                table: "Breeds",
                keyColumn: "Id",
                keyValue: 21,
                column: "CreatedTime",
                value: new DateTime(2024, 8, 23, 20, 11, 50, 135, DateTimeKind.Local).AddTicks(5056));

            migrationBuilder.UpdateData(
                table: "Breeds",
                keyColumn: "Id",
                keyValue: 22,
                column: "CreatedTime",
                value: new DateTime(2024, 8, 23, 20, 11, 50, 135, DateTimeKind.Local).AddTicks(5057));

            migrationBuilder.UpdateData(
                table: "Breeds",
                keyColumn: "Id",
                keyValue: 23,
                column: "CreatedTime",
                value: new DateTime(2024, 8, 23, 20, 11, 50, 135, DateTimeKind.Local).AddTicks(5060));

            migrationBuilder.UpdateData(
                table: "Breeds",
                keyColumn: "Id",
                keyValue: 24,
                column: "CreatedTime",
                value: new DateTime(2024, 8, 23, 20, 11, 50, 135, DateTimeKind.Local).AddTicks(5061));

            migrationBuilder.UpdateData(
                table: "Breeds",
                keyColumn: "Id",
                keyValue: 25,
                column: "CreatedTime",
                value: new DateTime(2024, 8, 23, 20, 11, 50, 135, DateTimeKind.Local).AddTicks(5062));

            migrationBuilder.UpdateData(
                table: "Breeds",
                keyColumn: "Id",
                keyValue: 26,
                column: "CreatedTime",
                value: new DateTime(2024, 8, 23, 20, 11, 50, 135, DateTimeKind.Local).AddTicks(5063));

            migrationBuilder.UpdateData(
                table: "Breeds",
                keyColumn: "Id",
                keyValue: 27,
                column: "CreatedTime",
                value: new DateTime(2024, 8, 23, 20, 11, 50, 135, DateTimeKind.Local).AddTicks(5065));

            migrationBuilder.UpdateData(
                table: "Breeds",
                keyColumn: "Id",
                keyValue: 28,
                column: "CreatedTime",
                value: new DateTime(2024, 8, 23, 20, 11, 50, 135, DateTimeKind.Local).AddTicks(5066));

            migrationBuilder.UpdateData(
                table: "Breeds",
                keyColumn: "Id",
                keyValue: 29,
                column: "CreatedTime",
                value: new DateTime(2024, 8, 23, 20, 11, 50, 135, DateTimeKind.Local).AddTicks(5067));

            migrationBuilder.UpdateData(
                table: "Breeds",
                keyColumn: "Id",
                keyValue: 30,
                column: "CreatedTime",
                value: new DateTime(2024, 8, 23, 20, 11, 50, 135, DateTimeKind.Local).AddTicks(5069));

            migrationBuilder.UpdateData(
                table: "Breeds",
                keyColumn: "Id",
                keyValue: 31,
                column: "CreatedTime",
                value: new DateTime(2024, 8, 23, 20, 11, 50, 135, DateTimeKind.Local).AddTicks(5070));

            migrationBuilder.UpdateData(
                table: "Breeds",
                keyColumn: "Id",
                keyValue: 32,
                column: "CreatedTime",
                value: new DateTime(2024, 8, 23, 20, 11, 50, 135, DateTimeKind.Local).AddTicks(5071));

            migrationBuilder.UpdateData(
                table: "Breeds",
                keyColumn: "Id",
                keyValue: 33,
                column: "CreatedTime",
                value: new DateTime(2024, 8, 23, 20, 11, 50, 135, DateTimeKind.Local).AddTicks(5072));

            migrationBuilder.UpdateData(
                table: "Breeds",
                keyColumn: "Id",
                keyValue: 34,
                column: "CreatedTime",
                value: new DateTime(2024, 8, 23, 20, 11, 50, 135, DateTimeKind.Local).AddTicks(5074));

            migrationBuilder.UpdateData(
                table: "Breeds",
                keyColumn: "Id",
                keyValue: 35,
                column: "CreatedTime",
                value: new DateTime(2024, 8, 23, 20, 11, 50, 135, DateTimeKind.Local).AddTicks(5075));

            migrationBuilder.UpdateData(
                table: "Breeds",
                keyColumn: "Id",
                keyValue: 36,
                column: "CreatedTime",
                value: new DateTime(2024, 8, 23, 20, 11, 50, 135, DateTimeKind.Local).AddTicks(5077));

            migrationBuilder.UpdateData(
                table: "Breeds",
                keyColumn: "Id",
                keyValue: 37,
                column: "CreatedTime",
                value: new DateTime(2024, 8, 23, 20, 11, 50, 135, DateTimeKind.Local).AddTicks(5078));

            migrationBuilder.UpdateData(
                table: "Breeds",
                keyColumn: "Id",
                keyValue: 38,
                column: "CreatedTime",
                value: new DateTime(2024, 8, 23, 20, 11, 50, 135, DateTimeKind.Local).AddTicks(5079));

            migrationBuilder.UpdateData(
                table: "Breeds",
                keyColumn: "Id",
                keyValue: 39,
                column: "CreatedTime",
                value: new DateTime(2024, 8, 23, 20, 11, 50, 135, DateTimeKind.Local).AddTicks(5080));

            migrationBuilder.UpdateData(
                table: "Breeds",
                keyColumn: "Id",
                keyValue: 40,
                column: "CreatedTime",
                value: new DateTime(2024, 8, 23, 20, 11, 50, 135, DateTimeKind.Local).AddTicks(5082));

            migrationBuilder.UpdateData(
                table: "Breeds",
                keyColumn: "Id",
                keyValue: 41,
                column: "CreatedTime",
                value: new DateTime(2024, 8, 23, 20, 11, 50, 135, DateTimeKind.Local).AddTicks(5083));

            migrationBuilder.UpdateData(
                table: "Breeds",
                keyColumn: "Id",
                keyValue: 42,
                column: "CreatedTime",
                value: new DateTime(2024, 8, 23, 20, 11, 50, 135, DateTimeKind.Local).AddTicks(5084));

            migrationBuilder.UpdateData(
                table: "Breeds",
                keyColumn: "Id",
                keyValue: 43,
                column: "CreatedTime",
                value: new DateTime(2024, 8, 23, 20, 11, 50, 135, DateTimeKind.Local).AddTicks(5136));

            migrationBuilder.UpdateData(
                table: "Breeds",
                keyColumn: "Id",
                keyValue: 44,
                column: "CreatedTime",
                value: new DateTime(2024, 8, 23, 20, 11, 50, 135, DateTimeKind.Local).AddTicks(5138));

            migrationBuilder.UpdateData(
                table: "Breeds",
                keyColumn: "Id",
                keyValue: 45,
                column: "CreatedTime",
                value: new DateTime(2024, 8, 23, 20, 11, 50, 135, DateTimeKind.Local).AddTicks(5139));

            migrationBuilder.UpdateData(
                table: "Breeds",
                keyColumn: "Id",
                keyValue: 46,
                column: "CreatedTime",
                value: new DateTime(2024, 8, 23, 20, 11, 50, 135, DateTimeKind.Local).AddTicks(5140));

            migrationBuilder.UpdateData(
                table: "Breeds",
                keyColumn: "Id",
                keyValue: 47,
                column: "CreatedTime",
                value: new DateTime(2024, 8, 23, 20, 11, 50, 135, DateTimeKind.Local).AddTicks(5142));

            migrationBuilder.UpdateData(
                table: "Breeds",
                keyColumn: "Id",
                keyValue: 48,
                column: "CreatedTime",
                value: new DateTime(2024, 8, 23, 20, 11, 50, 135, DateTimeKind.Local).AddTicks(5143));

            migrationBuilder.UpdateData(
                table: "Breeds",
                keyColumn: "Id",
                keyValue: 49,
                column: "CreatedTime",
                value: new DateTime(2024, 8, 23, 20, 11, 50, 135, DateTimeKind.Local).AddTicks(5144));

            migrationBuilder.UpdateData(
                table: "Breeds",
                keyColumn: "Id",
                keyValue: 50,
                column: "CreatedTime",
                value: new DateTime(2024, 8, 23, 20, 11, 50, 135, DateTimeKind.Local).AddTicks(5145));

            migrationBuilder.UpdateData(
                table: "Breeds",
                keyColumn: "Id",
                keyValue: 51,
                column: "CreatedTime",
                value: new DateTime(2024, 8, 23, 20, 11, 50, 135, DateTimeKind.Local).AddTicks(5147));

            migrationBuilder.UpdateData(
                table: "Breeds",
                keyColumn: "Id",
                keyValue: 52,
                column: "CreatedTime",
                value: new DateTime(2024, 8, 23, 20, 11, 50, 135, DateTimeKind.Local).AddTicks(5148));

            migrationBuilder.UpdateData(
                table: "Breeds",
                keyColumn: "Id",
                keyValue: 53,
                column: "CreatedTime",
                value: new DateTime(2024, 8, 23, 20, 11, 50, 135, DateTimeKind.Local).AddTicks(5150));

            migrationBuilder.UpdateData(
                table: "Breeds",
                keyColumn: "Id",
                keyValue: 54,
                column: "CreatedTime",
                value: new DateTime(2024, 8, 23, 20, 11, 50, 135, DateTimeKind.Local).AddTicks(5152));

            migrationBuilder.UpdateData(
                table: "Breeds",
                keyColumn: "Id",
                keyValue: 55,
                column: "CreatedTime",
                value: new DateTime(2024, 8, 23, 20, 11, 50, 135, DateTimeKind.Local).AddTicks(5153));

            migrationBuilder.UpdateData(
                table: "Breeds",
                keyColumn: "Id",
                keyValue: 56,
                column: "CreatedTime",
                value: new DateTime(2024, 8, 23, 20, 11, 50, 135, DateTimeKind.Local).AddTicks(5154));

            migrationBuilder.UpdateData(
                table: "Breeds",
                keyColumn: "Id",
                keyValue: 57,
                column: "CreatedTime",
                value: new DateTime(2024, 8, 23, 20, 11, 50, 135, DateTimeKind.Local).AddTicks(5156));

            migrationBuilder.UpdateData(
                table: "Breeds",
                keyColumn: "Id",
                keyValue: 58,
                column: "CreatedTime",
                value: new DateTime(2024, 8, 23, 20, 11, 50, 135, DateTimeKind.Local).AddTicks(5157));

            migrationBuilder.UpdateData(
                table: "Breeds",
                keyColumn: "Id",
                keyValue: 59,
                column: "CreatedTime",
                value: new DateTime(2024, 8, 23, 20, 11, 50, 135, DateTimeKind.Local).AddTicks(5158));

            migrationBuilder.UpdateData(
                table: "Breeds",
                keyColumn: "Id",
                keyValue: 60,
                column: "CreatedTime",
                value: new DateTime(2024, 8, 23, 20, 11, 50, 135, DateTimeKind.Local).AddTicks(5159));

            migrationBuilder.UpdateData(
                table: "Breeds",
                keyColumn: "Id",
                keyValue: 61,
                column: "CreatedTime",
                value: new DateTime(2024, 8, 23, 20, 11, 50, 135, DateTimeKind.Local).AddTicks(5161));

            migrationBuilder.UpdateData(
                table: "Breeds",
                keyColumn: "Id",
                keyValue: 62,
                column: "CreatedTime",
                value: new DateTime(2024, 8, 23, 20, 11, 50, 135, DateTimeKind.Local).AddTicks(5162));

            migrationBuilder.UpdateData(
                table: "Breeds",
                keyColumn: "Id",
                keyValue: 63,
                column: "CreatedTime",
                value: new DateTime(2024, 8, 23, 20, 11, 50, 135, DateTimeKind.Local).AddTicks(5163));

            migrationBuilder.UpdateData(
                table: "Breeds",
                keyColumn: "Id",
                keyValue: 64,
                column: "CreatedTime",
                value: new DateTime(2024, 8, 23, 20, 11, 50, 135, DateTimeKind.Local).AddTicks(5164));

            migrationBuilder.UpdateData(
                table: "Breeds",
                keyColumn: "Id",
                keyValue: 65,
                column: "CreatedTime",
                value: new DateTime(2024, 8, 23, 20, 11, 50, 135, DateTimeKind.Local).AddTicks(5166));

            migrationBuilder.UpdateData(
                table: "Breeds",
                keyColumn: "Id",
                keyValue: 66,
                column: "CreatedTime",
                value: new DateTime(2024, 8, 23, 20, 11, 50, 135, DateTimeKind.Local).AddTicks(5167));

            migrationBuilder.UpdateData(
                table: "Breeds",
                keyColumn: "Id",
                keyValue: 67,
                column: "CreatedTime",
                value: new DateTime(2024, 8, 23, 20, 11, 50, 135, DateTimeKind.Local).AddTicks(5168));

            migrationBuilder.UpdateData(
                table: "Breeds",
                keyColumn: "Id",
                keyValue: 68,
                column: "CreatedTime",
                value: new DateTime(2024, 8, 23, 20, 11, 50, 135, DateTimeKind.Local).AddTicks(5170));

            migrationBuilder.UpdateData(
                table: "Breeds",
                keyColumn: "Id",
                keyValue: 69,
                column: "CreatedTime",
                value: new DateTime(2024, 8, 23, 20, 11, 50, 135, DateTimeKind.Local).AddTicks(5171));

            migrationBuilder.UpdateData(
                table: "Breeds",
                keyColumn: "Id",
                keyValue: 70,
                column: "CreatedTime",
                value: new DateTime(2024, 8, 23, 20, 11, 50, 135, DateTimeKind.Local).AddTicks(5172));

            migrationBuilder.UpdateData(
                table: "Breeds",
                keyColumn: "Id",
                keyValue: 71,
                column: "CreatedTime",
                value: new DateTime(2024, 8, 23, 20, 11, 50, 135, DateTimeKind.Local).AddTicks(5174));

            migrationBuilder.UpdateData(
                table: "Breeds",
                keyColumn: "Id",
                keyValue: 72,
                column: "CreatedTime",
                value: new DateTime(2024, 8, 23, 20, 11, 50, 135, DateTimeKind.Local).AddTicks(5175));

            migrationBuilder.UpdateData(
                table: "Breeds",
                keyColumn: "Id",
                keyValue: 73,
                column: "CreatedTime",
                value: new DateTime(2024, 8, 23, 20, 11, 50, 135, DateTimeKind.Local).AddTicks(5176));

            migrationBuilder.UpdateData(
                table: "Breeds",
                keyColumn: "Id",
                keyValue: 74,
                column: "CreatedTime",
                value: new DateTime(2024, 8, 23, 20, 11, 50, 135, DateTimeKind.Local).AddTicks(5178));

            migrationBuilder.UpdateData(
                table: "Breeds",
                keyColumn: "Id",
                keyValue: 75,
                column: "CreatedTime",
                value: new DateTime(2024, 8, 23, 20, 11, 50, 135, DateTimeKind.Local).AddTicks(5180));

            migrationBuilder.UpdateData(
                table: "Breeds",
                keyColumn: "Id",
                keyValue: 76,
                column: "CreatedTime",
                value: new DateTime(2024, 8, 23, 20, 11, 50, 135, DateTimeKind.Local).AddTicks(5181));

            migrationBuilder.UpdateData(
                table: "Breeds",
                keyColumn: "Id",
                keyValue: 77,
                column: "CreatedTime",
                value: new DateTime(2024, 8, 23, 20, 11, 50, 135, DateTimeKind.Local).AddTicks(5182));

            migrationBuilder.UpdateData(
                table: "Breeds",
                keyColumn: "Id",
                keyValue: 78,
                column: "CreatedTime",
                value: new DateTime(2024, 8, 23, 20, 11, 50, 135, DateTimeKind.Local).AddTicks(5183));

            migrationBuilder.UpdateData(
                table: "Breeds",
                keyColumn: "Id",
                keyValue: 79,
                column: "CreatedTime",
                value: new DateTime(2024, 8, 23, 20, 11, 50, 135, DateTimeKind.Local).AddTicks(5185));

            migrationBuilder.UpdateData(
                table: "Breeds",
                keyColumn: "Id",
                keyValue: 80,
                column: "CreatedTime",
                value: new DateTime(2024, 8, 23, 20, 11, 50, 135, DateTimeKind.Local).AddTicks(5186));

            migrationBuilder.UpdateData(
                table: "Breeds",
                keyColumn: "Id",
                keyValue: 81,
                column: "CreatedTime",
                value: new DateTime(2024, 8, 23, 20, 11, 50, 135, DateTimeKind.Local).AddTicks(5187));

            migrationBuilder.UpdateData(
                table: "Breeds",
                keyColumn: "Id",
                keyValue: 82,
                column: "CreatedTime",
                value: new DateTime(2024, 8, 23, 20, 11, 50, 135, DateTimeKind.Local).AddTicks(5189));

            migrationBuilder.UpdateData(
                table: "Breeds",
                keyColumn: "Id",
                keyValue: 83,
                column: "CreatedTime",
                value: new DateTime(2024, 8, 23, 20, 11, 50, 135, DateTimeKind.Local).AddTicks(5191));

            migrationBuilder.UpdateData(
                table: "Breeds",
                keyColumn: "Id",
                keyValue: 84,
                column: "CreatedTime",
                value: new DateTime(2024, 8, 23, 20, 11, 50, 135, DateTimeKind.Local).AddTicks(5192));

            migrationBuilder.UpdateData(
                table: "Breeds",
                keyColumn: "Id",
                keyValue: 85,
                column: "CreatedTime",
                value: new DateTime(2024, 8, 23, 20, 11, 50, 135, DateTimeKind.Local).AddTicks(5193));

            migrationBuilder.UpdateData(
                table: "Breeds",
                keyColumn: "Id",
                keyValue: 86,
                column: "CreatedTime",
                value: new DateTime(2024, 8, 23, 20, 11, 50, 135, DateTimeKind.Local).AddTicks(5194));

            migrationBuilder.UpdateData(
                table: "Breeds",
                keyColumn: "Id",
                keyValue: 87,
                column: "CreatedTime",
                value: new DateTime(2024, 8, 23, 20, 11, 50, 135, DateTimeKind.Local).AddTicks(5196));

            migrationBuilder.UpdateData(
                table: "Breeds",
                keyColumn: "Id",
                keyValue: 88,
                column: "CreatedTime",
                value: new DateTime(2024, 8, 23, 20, 11, 50, 135, DateTimeKind.Local).AddTicks(5197));

            migrationBuilder.UpdateData(
                table: "Breeds",
                keyColumn: "Id",
                keyValue: 89,
                column: "CreatedTime",
                value: new DateTime(2024, 8, 23, 20, 11, 50, 135, DateTimeKind.Local).AddTicks(5198));

            migrationBuilder.UpdateData(
                table: "Breeds",
                keyColumn: "Id",
                keyValue: 90,
                column: "CreatedTime",
                value: new DateTime(2024, 8, 23, 20, 11, 50, 135, DateTimeKind.Local).AddTicks(5199));

            migrationBuilder.UpdateData(
                table: "Breeds",
                keyColumn: "Id",
                keyValue: 91,
                column: "CreatedTime",
                value: new DateTime(2024, 8, 23, 20, 11, 50, 135, DateTimeKind.Local).AddTicks(5201));

            migrationBuilder.UpdateData(
                table: "Breeds",
                keyColumn: "Id",
                keyValue: 92,
                column: "CreatedTime",
                value: new DateTime(2024, 8, 23, 20, 11, 50, 135, DateTimeKind.Local).AddTicks(5202));

            migrationBuilder.UpdateData(
                table: "Breeds",
                keyColumn: "Id",
                keyValue: 93,
                column: "CreatedTime",
                value: new DateTime(2024, 8, 23, 20, 11, 50, 135, DateTimeKind.Local).AddTicks(5203));

            migrationBuilder.UpdateData(
                table: "Breeds",
                keyColumn: "Id",
                keyValue: 94,
                column: "CreatedTime",
                value: new DateTime(2024, 8, 23, 20, 11, 50, 135, DateTimeKind.Local).AddTicks(5204));

            migrationBuilder.UpdateData(
                table: "Breeds",
                keyColumn: "Id",
                keyValue: 95,
                column: "CreatedTime",
                value: new DateTime(2024, 8, 23, 20, 11, 50, 135, DateTimeKind.Local).AddTicks(5206));

            migrationBuilder.UpdateData(
                table: "Breeds",
                keyColumn: "Id",
                keyValue: 96,
                column: "CreatedTime",
                value: new DateTime(2024, 8, 23, 20, 11, 50, 135, DateTimeKind.Local).AddTicks(5207));

            migrationBuilder.UpdateData(
                table: "Breeds",
                keyColumn: "Id",
                keyValue: 97,
                column: "CreatedTime",
                value: new DateTime(2024, 8, 23, 20, 11, 50, 135, DateTimeKind.Local).AddTicks(5208));

            migrationBuilder.UpdateData(
                table: "Breeds",
                keyColumn: "Id",
                keyValue: 98,
                column: "CreatedTime",
                value: new DateTime(2024, 8, 23, 20, 11, 50, 135, DateTimeKind.Local).AddTicks(5210));

            migrationBuilder.UpdateData(
                table: "Breeds",
                keyColumn: "Id",
                keyValue: 99,
                column: "CreatedTime",
                value: new DateTime(2024, 8, 23, 20, 11, 50, 135, DateTimeKind.Local).AddTicks(5211));

            migrationBuilder.UpdateData(
                table: "Breeds",
                keyColumn: "Id",
                keyValue: 100,
                column: "CreatedTime",
                value: new DateTime(2024, 8, 23, 20, 11, 50, 135, DateTimeKind.Local).AddTicks(5212));

            migrationBuilder.UpdateData(
                table: "Breeds",
                keyColumn: "Id",
                keyValue: 101,
                column: "CreatedTime",
                value: new DateTime(2024, 8, 23, 20, 11, 50, 135, DateTimeKind.Local).AddTicks(5213));

            migrationBuilder.UpdateData(
                table: "Breeds",
                keyColumn: "Id",
                keyValue: 102,
                column: "CreatedTime",
                value: new DateTime(2024, 8, 23, 20, 11, 50, 135, DateTimeKind.Local).AddTicks(5214));

            migrationBuilder.UpdateData(
                table: "Breeds",
                keyColumn: "Id",
                keyValue: 103,
                column: "CreatedTime",
                value: new DateTime(2024, 8, 23, 20, 11, 50, 135, DateTimeKind.Local).AddTicks(5216));

            migrationBuilder.UpdateData(
                table: "Breeds",
                keyColumn: "Id",
                keyValue: 104,
                column: "CreatedTime",
                value: new DateTime(2024, 8, 23, 20, 11, 50, 135, DateTimeKind.Local).AddTicks(5217));

            migrationBuilder.UpdateData(
                table: "Breeds",
                keyColumn: "Id",
                keyValue: 105,
                column: "CreatedTime",
                value: new DateTime(2024, 8, 23, 20, 11, 50, 135, DateTimeKind.Local).AddTicks(5218));

            migrationBuilder.UpdateData(
                table: "Breeds",
                keyColumn: "Id",
                keyValue: 106,
                column: "CreatedTime",
                value: new DateTime(2024, 8, 23, 20, 11, 50, 135, DateTimeKind.Local).AddTicks(5219));

            migrationBuilder.UpdateData(
                table: "Breeds",
                keyColumn: "Id",
                keyValue: 107,
                column: "CreatedTime",
                value: new DateTime(2024, 8, 23, 20, 11, 50, 135, DateTimeKind.Local).AddTicks(5221));

            migrationBuilder.UpdateData(
                table: "Breeds",
                keyColumn: "Id",
                keyValue: 108,
                column: "CreatedTime",
                value: new DateTime(2024, 8, 23, 20, 11, 50, 135, DateTimeKind.Local).AddTicks(5222));

            migrationBuilder.UpdateData(
                table: "Breeds",
                keyColumn: "Id",
                keyValue: 109,
                column: "CreatedTime",
                value: new DateTime(2024, 8, 23, 20, 11, 50, 135, DateTimeKind.Local).AddTicks(5223));

            migrationBuilder.UpdateData(
                table: "Breeds",
                keyColumn: "Id",
                keyValue: 110,
                column: "CreatedTime",
                value: new DateTime(2024, 8, 23, 20, 11, 50, 135, DateTimeKind.Local).AddTicks(5224));

            migrationBuilder.UpdateData(
                table: "Breeds",
                keyColumn: "Id",
                keyValue: 111,
                column: "CreatedTime",
                value: new DateTime(2024, 8, 23, 20, 11, 50, 135, DateTimeKind.Local).AddTicks(5226));

            migrationBuilder.UpdateData(
                table: "Breeds",
                keyColumn: "Id",
                keyValue: 112,
                column: "CreatedTime",
                value: new DateTime(2024, 8, 23, 20, 11, 50, 135, DateTimeKind.Local).AddTicks(5228));

            migrationBuilder.UpdateData(
                table: "Breeds",
                keyColumn: "Id",
                keyValue: 113,
                column: "CreatedTime",
                value: new DateTime(2024, 8, 23, 20, 11, 50, 135, DateTimeKind.Local).AddTicks(5229));

            migrationBuilder.UpdateData(
                table: "Breeds",
                keyColumn: "Id",
                keyValue: 114,
                column: "CreatedTime",
                value: new DateTime(2024, 8, 23, 20, 11, 50, 135, DateTimeKind.Local).AddTicks(5230));

            migrationBuilder.UpdateData(
                table: "Breeds",
                keyColumn: "Id",
                keyValue: 115,
                column: "CreatedTime",
                value: new DateTime(2024, 8, 23, 20, 11, 50, 135, DateTimeKind.Local).AddTicks(5232));

            migrationBuilder.UpdateData(
                table: "Breeds",
                keyColumn: "Id",
                keyValue: 116,
                column: "CreatedTime",
                value: new DateTime(2024, 8, 23, 20, 11, 50, 135, DateTimeKind.Local).AddTicks(5233));

            migrationBuilder.UpdateData(
                table: "Breeds",
                keyColumn: "Id",
                keyValue: 117,
                column: "CreatedTime",
                value: new DateTime(2024, 8, 23, 20, 11, 50, 135, DateTimeKind.Local).AddTicks(5234));

            migrationBuilder.UpdateData(
                table: "Breeds",
                keyColumn: "Id",
                keyValue: 118,
                column: "CreatedTime",
                value: new DateTime(2024, 8, 23, 20, 11, 50, 135, DateTimeKind.Local).AddTicks(5235));

            migrationBuilder.UpdateData(
                table: "Breeds",
                keyColumn: "Id",
                keyValue: 119,
                column: "CreatedTime",
                value: new DateTime(2024, 8, 23, 20, 11, 50, 135, DateTimeKind.Local).AddTicks(5237));

            migrationBuilder.UpdateData(
                table: "Breeds",
                keyColumn: "Id",
                keyValue: 120,
                column: "CreatedTime",
                value: new DateTime(2024, 8, 23, 20, 11, 50, 135, DateTimeKind.Local).AddTicks(5238));

            migrationBuilder.UpdateData(
                table: "Breeds",
                keyColumn: "Id",
                keyValue: 121,
                column: "CreatedTime",
                value: new DateTime(2024, 8, 23, 20, 11, 50, 135, DateTimeKind.Local).AddTicks(5239));

            migrationBuilder.UpdateData(
                table: "Breeds",
                keyColumn: "Id",
                keyValue: 122,
                column: "CreatedTime",
                value: new DateTime(2024, 8, 23, 20, 11, 50, 135, DateTimeKind.Local).AddTicks(5241));

            migrationBuilder.UpdateData(
                table: "Breeds",
                keyColumn: "Id",
                keyValue: 123,
                column: "CreatedTime",
                value: new DateTime(2024, 8, 23, 20, 11, 50, 135, DateTimeKind.Local).AddTicks(5242));

            migrationBuilder.UpdateData(
                table: "Breeds",
                keyColumn: "Id",
                keyValue: 124,
                column: "CreatedTime",
                value: new DateTime(2024, 8, 23, 20, 11, 50, 135, DateTimeKind.Local).AddTicks(5243));

            migrationBuilder.UpdateData(
                table: "Breeds",
                keyColumn: "Id",
                keyValue: 125,
                column: "CreatedTime",
                value: new DateTime(2024, 8, 23, 20, 11, 50, 135, DateTimeKind.Local).AddTicks(5244));

            migrationBuilder.UpdateData(
                table: "Breeds",
                keyColumn: "Id",
                keyValue: 126,
                column: "CreatedTime",
                value: new DateTime(2024, 8, 23, 20, 11, 50, 135, DateTimeKind.Local).AddTicks(5245));

            migrationBuilder.UpdateData(
                table: "Breeds",
                keyColumn: "Id",
                keyValue: 127,
                column: "CreatedTime",
                value: new DateTime(2024, 8, 23, 20, 11, 50, 135, DateTimeKind.Local).AddTicks(5247));

            migrationBuilder.UpdateData(
                table: "Breeds",
                keyColumn: "Id",
                keyValue: 128,
                column: "CreatedTime",
                value: new DateTime(2024, 8, 23, 20, 11, 50, 135, DateTimeKind.Local).AddTicks(5248));

            migrationBuilder.UpdateData(
                table: "Breeds",
                keyColumn: "Id",
                keyValue: 129,
                column: "CreatedTime",
                value: new DateTime(2024, 8, 23, 20, 11, 50, 135, DateTimeKind.Local).AddTicks(5249));

            migrationBuilder.UpdateData(
                table: "Breeds",
                keyColumn: "Id",
                keyValue: 130,
                column: "CreatedTime",
                value: new DateTime(2024, 8, 23, 20, 11, 50, 135, DateTimeKind.Local).AddTicks(5250));

            migrationBuilder.UpdateData(
                table: "Breeds",
                keyColumn: "Id",
                keyValue: 131,
                column: "CreatedTime",
                value: new DateTime(2024, 8, 23, 20, 11, 50, 135, DateTimeKind.Local).AddTicks(5252));

            migrationBuilder.UpdateData(
                table: "Breeds",
                keyColumn: "Id",
                keyValue: 132,
                column: "CreatedTime",
                value: new DateTime(2024, 8, 23, 20, 11, 50, 135, DateTimeKind.Local).AddTicks(5253));

            migrationBuilder.UpdateData(
                table: "Breeds",
                keyColumn: "Id",
                keyValue: 133,
                column: "CreatedTime",
                value: new DateTime(2024, 8, 23, 20, 11, 50, 135, DateTimeKind.Local).AddTicks(5254));

            migrationBuilder.UpdateData(
                table: "Breeds",
                keyColumn: "Id",
                keyValue: 134,
                column: "CreatedTime",
                value: new DateTime(2024, 8, 23, 20, 11, 50, 135, DateTimeKind.Local).AddTicks(5256));

            migrationBuilder.UpdateData(
                table: "Breeds",
                keyColumn: "Id",
                keyValue: 135,
                column: "CreatedTime",
                value: new DateTime(2024, 8, 23, 20, 11, 50, 135, DateTimeKind.Local).AddTicks(5257));

            migrationBuilder.UpdateData(
                table: "Breeds",
                keyColumn: "Id",
                keyValue: 136,
                column: "CreatedTime",
                value: new DateTime(2024, 8, 23, 20, 11, 50, 135, DateTimeKind.Local).AddTicks(5258));

            migrationBuilder.UpdateData(
                table: "Breeds",
                keyColumn: "Id",
                keyValue: 137,
                column: "CreatedTime",
                value: new DateTime(2024, 8, 23, 20, 11, 50, 135, DateTimeKind.Local).AddTicks(5259));

            migrationBuilder.UpdateData(
                table: "Breeds",
                keyColumn: "Id",
                keyValue: 138,
                column: "CreatedTime",
                value: new DateTime(2024, 8, 23, 20, 11, 50, 135, DateTimeKind.Local).AddTicks(5261));

            migrationBuilder.UpdateData(
                table: "Breeds",
                keyColumn: "Id",
                keyValue: 139,
                column: "CreatedTime",
                value: new DateTime(2024, 8, 23, 20, 11, 50, 135, DateTimeKind.Local).AddTicks(5262));

            migrationBuilder.UpdateData(
                table: "Breeds",
                keyColumn: "Id",
                keyValue: 140,
                column: "CreatedTime",
                value: new DateTime(2024, 8, 23, 20, 11, 50, 135, DateTimeKind.Local).AddTicks(5263));

            migrationBuilder.UpdateData(
                table: "Breeds",
                keyColumn: "Id",
                keyValue: 141,
                column: "CreatedTime",
                value: new DateTime(2024, 8, 23, 20, 11, 50, 135, DateTimeKind.Local).AddTicks(5265));

            migrationBuilder.UpdateData(
                table: "Breeds",
                keyColumn: "Id",
                keyValue: 142,
                column: "CreatedTime",
                value: new DateTime(2024, 8, 23, 20, 11, 50, 135, DateTimeKind.Local).AddTicks(5266));

            migrationBuilder.UpdateData(
                table: "Breeds",
                keyColumn: "Id",
                keyValue: 143,
                column: "CreatedTime",
                value: new DateTime(2024, 8, 23, 20, 11, 50, 135, DateTimeKind.Local).AddTicks(5267));

            migrationBuilder.UpdateData(
                table: "Breeds",
                keyColumn: "Id",
                keyValue: 144,
                column: "CreatedTime",
                value: new DateTime(2024, 8, 23, 20, 11, 50, 135, DateTimeKind.Local).AddTicks(5268));

            migrationBuilder.UpdateData(
                table: "Breeds",
                keyColumn: "Id",
                keyValue: 145,
                column: "CreatedTime",
                value: new DateTime(2024, 8, 23, 20, 11, 50, 135, DateTimeKind.Local).AddTicks(5269));

            migrationBuilder.UpdateData(
                table: "Breeds",
                keyColumn: "Id",
                keyValue: 146,
                column: "CreatedTime",
                value: new DateTime(2024, 8, 23, 20, 11, 50, 135, DateTimeKind.Local).AddTicks(5271));

            migrationBuilder.UpdateData(
                table: "Breeds",
                keyColumn: "Id",
                keyValue: 147,
                column: "CreatedTime",
                value: new DateTime(2024, 8, 23, 20, 11, 50, 135, DateTimeKind.Local).AddTicks(5272));

            migrationBuilder.UpdateData(
                table: "Breeds",
                keyColumn: "Id",
                keyValue: 148,
                column: "CreatedTime",
                value: new DateTime(2024, 8, 23, 20, 11, 50, 135, DateTimeKind.Local).AddTicks(5273));

            migrationBuilder.UpdateData(
                table: "Breeds",
                keyColumn: "Id",
                keyValue: 149,
                column: "CreatedTime",
                value: new DateTime(2024, 8, 23, 20, 11, 50, 135, DateTimeKind.Local).AddTicks(5274));

            migrationBuilder.UpdateData(
                table: "Breeds",
                keyColumn: "Id",
                keyValue: 150,
                column: "CreatedTime",
                value: new DateTime(2024, 8, 23, 20, 11, 50, 135, DateTimeKind.Local).AddTicks(5276));

            migrationBuilder.UpdateData(
                table: "Breeds",
                keyColumn: "Id",
                keyValue: 151,
                column: "CreatedTime",
                value: new DateTime(2024, 8, 23, 20, 11, 50, 135, DateTimeKind.Local).AddTicks(5277));

            migrationBuilder.UpdateData(
                table: "Breeds",
                keyColumn: "Id",
                keyValue: 152,
                column: "CreatedTime",
                value: new DateTime(2024, 8, 23, 20, 11, 50, 135, DateTimeKind.Local).AddTicks(5278));

            migrationBuilder.UpdateData(
                table: "Breeds",
                keyColumn: "Id",
                keyValue: 153,
                column: "CreatedTime",
                value: new DateTime(2024, 8, 23, 20, 11, 50, 135, DateTimeKind.Local).AddTicks(5279));

            migrationBuilder.UpdateData(
                table: "Breeds",
                keyColumn: "Id",
                keyValue: 154,
                column: "CreatedTime",
                value: new DateTime(2024, 8, 23, 20, 11, 50, 135, DateTimeKind.Local).AddTicks(5280));

            migrationBuilder.UpdateData(
                table: "Breeds",
                keyColumn: "Id",
                keyValue: 155,
                column: "CreatedTime",
                value: new DateTime(2024, 8, 23, 20, 11, 50, 135, DateTimeKind.Local).AddTicks(5282));

            migrationBuilder.UpdateData(
                table: "Breeds",
                keyColumn: "Id",
                keyValue: 156,
                column: "CreatedTime",
                value: new DateTime(2024, 8, 23, 20, 11, 50, 135, DateTimeKind.Local).AddTicks(5283));

            migrationBuilder.UpdateData(
                table: "Breeds",
                keyColumn: "Id",
                keyValue: 157,
                column: "CreatedTime",
                value: new DateTime(2024, 8, 23, 20, 11, 50, 135, DateTimeKind.Local).AddTicks(5284));

            migrationBuilder.UpdateData(
                table: "Breeds",
                keyColumn: "Id",
                keyValue: 158,
                column: "CreatedTime",
                value: new DateTime(2024, 8, 23, 20, 11, 50, 135, DateTimeKind.Local).AddTicks(5285));

            migrationBuilder.UpdateData(
                table: "Breeds",
                keyColumn: "Id",
                keyValue: 159,
                column: "CreatedTime",
                value: new DateTime(2024, 8, 23, 20, 11, 50, 135, DateTimeKind.Local).AddTicks(5286));

            migrationBuilder.UpdateData(
                table: "Breeds",
                keyColumn: "Id",
                keyValue: 160,
                column: "CreatedTime",
                value: new DateTime(2024, 8, 23, 20, 11, 50, 135, DateTimeKind.Local).AddTicks(5288));

            migrationBuilder.UpdateData(
                table: "PetTypes",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedTime",
                value: new DateTime(2024, 8, 23, 20, 11, 50, 135, DateTimeKind.Local).AddTicks(2475));

            migrationBuilder.UpdateData(
                table: "PetTypes",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreatedTime",
                value: new DateTime(2024, 8, 23, 20, 11, 50, 135, DateTimeKind.Local).AddTicks(2485));

            migrationBuilder.UpdateData(
                table: "PetTypes",
                keyColumn: "Id",
                keyValue: 3,
                column: "CreatedTime",
                value: new DateTime(2024, 8, 23, 20, 11, 50, 135, DateTimeKind.Local).AddTicks(2486));

            migrationBuilder.UpdateData(
                table: "PetTypes",
                keyColumn: "Id",
                keyValue: 4,
                column: "CreatedTime",
                value: new DateTime(2024, 8, 23, 20, 11, 50, 135, DateTimeKind.Local).AddTicks(2487));

            migrationBuilder.UpdateData(
                table: "PetTypes",
                keyColumn: "Id",
                keyValue: 5,
                column: "CreatedTime",
                value: new DateTime(2024, 8, 23, 20, 11, 50, 135, DateTimeKind.Local).AddTicks(2488));

            migrationBuilder.UpdateData(
                table: "PetTypes",
                keyColumn: "Id",
                keyValue: 6,
                column: "CreatedTime",
                value: new DateTime(2024, 8, 23, 20, 11, 50, 135, DateTimeKind.Local).AddTicks(2490));

            migrationBuilder.UpdateData(
                table: "PetTypes",
                keyColumn: "Id",
                keyValue: 7,
                column: "CreatedTime",
                value: new DateTime(2024, 8, 23, 20, 11, 50, 135, DateTimeKind.Local).AddTicks(2491));

            migrationBuilder.UpdateData(
                table: "PetTypes",
                keyColumn: "Id",
                keyValue: 8,
                column: "CreatedTime",
                value: new DateTime(2024, 8, 23, 20, 11, 50, 135, DateTimeKind.Local).AddTicks(2492));

            migrationBuilder.UpdateData(
                table: "Shelters",
                keyColumn: "Id",
                keyValue: 1021,
                columns: new[] { "CreatedTime", "LastUpdatedTime" },
                values: new object[] { new DateTime(2024, 8, 23, 16, 11, 50, 133, DateTimeKind.Utc).AddTicks(5392), new DateTime(2024, 8, 23, 16, 11, 50, 133, DateTimeKind.Utc).AddTicks(5393) });

            migrationBuilder.UpdateData(
                table: "Shelters",
                keyColumn: "Id",
                keyValue: 1022,
                columns: new[] { "CreatedTime", "LastUpdatedTime" },
                values: new object[] { new DateTime(2024, 8, 23, 16, 11, 50, 133, DateTimeKind.Utc).AddTicks(5401), new DateTime(2024, 8, 23, 16, 11, 50, 133, DateTimeKind.Utc).AddTicks(5402) });

            migrationBuilder.UpdateData(
                table: "Shelters",
                keyColumn: "Id",
                keyValue: 1023,
                columns: new[] { "CreatedTime", "LastUpdatedTime" },
                values: new object[] { new DateTime(2024, 8, 23, 16, 11, 50, 133, DateTimeKind.Utc).AddTicks(5407), new DateTime(2024, 8, 23, 16, 11, 50, 133, DateTimeKind.Utc).AddTicks(5408) });

            migrationBuilder.UpdateData(
                table: "Shelters",
                keyColumn: "Id",
                keyValue: 1024,
                columns: new[] { "CreatedTime", "LastUpdatedTime" },
                values: new object[] { new DateTime(2024, 8, 23, 16, 11, 50, 133, DateTimeKind.Utc).AddTicks(5412), new DateTime(2024, 8, 23, 16, 11, 50, 133, DateTimeKind.Utc).AddTicks(5413) });

            migrationBuilder.UpdateData(
                table: "Shelters",
                keyColumn: "Id",
                keyValue: 1025,
                columns: new[] { "CreatedTime", "LastUpdatedTime" },
                values: new object[] { new DateTime(2024, 8, 23, 16, 11, 50, 133, DateTimeKind.Utc).AddTicks(5417), new DateTime(2024, 8, 23, 16, 11, 50, 133, DateTimeKind.Utc).AddTicks(5417) });

            migrationBuilder.UpdateData(
                table: "Shelters",
                keyColumn: "Id",
                keyValue: 1026,
                columns: new[] { "CreatedTime", "LastUpdatedTime" },
                values: new object[] { new DateTime(2024, 8, 23, 16, 11, 50, 133, DateTimeKind.Utc).AddTicks(5424), new DateTime(2024, 8, 23, 16, 11, 50, 133, DateTimeKind.Utc).AddTicks(5425) });

            migrationBuilder.UpdateData(
                table: "Shelters",
                keyColumn: "Id",
                keyValue: 1027,
                columns: new[] { "CreatedTime", "LastUpdatedTime" },
                values: new object[] { new DateTime(2024, 8, 23, 16, 11, 50, 133, DateTimeKind.Utc).AddTicks(5429), new DateTime(2024, 8, 23, 16, 11, 50, 133, DateTimeKind.Utc).AddTicks(5430) });

            migrationBuilder.UpdateData(
                table: "Shelters",
                keyColumn: "Id",
                keyValue: 1028,
                columns: new[] { "CreatedTime", "LastUpdatedTime" },
                values: new object[] { new DateTime(2024, 8, 23, 16, 11, 50, 133, DateTimeKind.Utc).AddTicks(5435), new DateTime(2024, 8, 23, 16, 11, 50, 133, DateTimeKind.Utc).AddTicks(5435) });

            migrationBuilder.UpdateData(
                table: "Shelters",
                keyColumn: "Id",
                keyValue: 1029,
                columns: new[] { "CreatedTime", "LastUpdatedTime" },
                values: new object[] { new DateTime(2024, 8, 23, 16, 11, 50, 133, DateTimeKind.Utc).AddTicks(5439), new DateTime(2024, 8, 23, 16, 11, 50, 133, DateTimeKind.Utc).AddTicks(5440) });

            migrationBuilder.UpdateData(
                table: "Shelters",
                keyColumn: "Id",
                keyValue: 1030,
                columns: new[] { "CreatedTime", "LastUpdatedTime" },
                values: new object[] { new DateTime(2024, 8, 23, 16, 11, 50, 133, DateTimeKind.Utc).AddTicks(5445), new DateTime(2024, 8, 23, 16, 11, 50, 133, DateTimeKind.Utc).AddTicks(5446) });

            migrationBuilder.UpdateData(
                table: "Shelters",
                keyColumn: "Id",
                keyValue: 1031,
                columns: new[] { "CreatedTime", "LastUpdatedTime" },
                values: new object[] { new DateTime(2024, 8, 23, 16, 11, 50, 133, DateTimeKind.Utc).AddTicks(5450), new DateTime(2024, 8, 23, 16, 11, 50, 133, DateTimeKind.Utc).AddTicks(5451) });

            migrationBuilder.UpdateData(
                table: "Shelters",
                keyColumn: "Id",
                keyValue: 1032,
                columns: new[] { "CreatedTime", "LastUpdatedTime" },
                values: new object[] { new DateTime(2024, 8, 23, 16, 11, 50, 133, DateTimeKind.Utc).AddTicks(5455), new DateTime(2024, 8, 23, 16, 11, 50, 133, DateTimeKind.Utc).AddTicks(5455) });

            migrationBuilder.UpdateData(
                table: "Shelters",
                keyColumn: "Id",
                keyValue: 1033,
                columns: new[] { "CreatedTime", "LastUpdatedTime" },
                values: new object[] { new DateTime(2024, 8, 23, 16, 11, 50, 133, DateTimeKind.Utc).AddTicks(5460), new DateTime(2024, 8, 23, 16, 11, 50, 133, DateTimeKind.Utc).AddTicks(5461) });

            migrationBuilder.UpdateData(
                table: "Shelters",
                keyColumn: "Id",
                keyValue: 1034,
                columns: new[] { "CreatedTime", "LastUpdatedTime" },
                values: new object[] { new DateTime(2024, 8, 23, 16, 11, 50, 133, DateTimeKind.Utc).AddTicks(5465), new DateTime(2024, 8, 23, 16, 11, 50, 133, DateTimeKind.Utc).AddTicks(5466) });

            migrationBuilder.UpdateData(
                table: "Shelters",
                keyColumn: "Id",
                keyValue: 1035,
                columns: new[] { "CreatedTime", "LastUpdatedTime" },
                values: new object[] { new DateTime(2024, 8, 23, 16, 11, 50, 133, DateTimeKind.Utc).AddTicks(5470), new DateTime(2024, 8, 23, 16, 11, 50, 133, DateTimeKind.Utc).AddTicks(5470) });

            migrationBuilder.UpdateData(
                table: "Shelters",
                keyColumn: "Id",
                keyValue: 1036,
                columns: new[] { "CreatedTime", "LastUpdatedTime" },
                values: new object[] { new DateTime(2024, 8, 23, 16, 11, 50, 133, DateTimeKind.Utc).AddTicks(5475), new DateTime(2024, 8, 23, 16, 11, 50, 133, DateTimeKind.Utc).AddTicks(5475) });

            migrationBuilder.UpdateData(
                table: "Shelters",
                keyColumn: "Id",
                keyValue: 1037,
                columns: new[] { "CreatedTime", "LastUpdatedTime" },
                values: new object[] { new DateTime(2024, 8, 23, 16, 11, 50, 133, DateTimeKind.Utc).AddTicks(5480), new DateTime(2024, 8, 23, 16, 11, 50, 133, DateTimeKind.Utc).AddTicks(5480) });

            migrationBuilder.UpdateData(
                table: "Shelters",
                keyColumn: "Id",
                keyValue: 1038,
                columns: new[] { "CreatedTime", "LastUpdatedTime" },
                values: new object[] { new DateTime(2024, 8, 23, 16, 11, 50, 133, DateTimeKind.Utc).AddTicks(5517), new DateTime(2024, 8, 23, 16, 11, 50, 133, DateTimeKind.Utc).AddTicks(5517) });

            migrationBuilder.UpdateData(
                table: "Shelters",
                keyColumn: "Id",
                keyValue: 1039,
                columns: new[] { "CreatedTime", "LastUpdatedTime" },
                values: new object[] { new DateTime(2024, 8, 23, 16, 11, 50, 133, DateTimeKind.Utc).AddTicks(5522), new DateTime(2024, 8, 23, 16, 11, 50, 133, DateTimeKind.Utc).AddTicks(5522) });

            migrationBuilder.UpdateData(
                table: "Shelters",
                keyColumn: "Id",
                keyValue: 1040,
                columns: new[] { "CreatedTime", "LastUpdatedTime" },
                values: new object[] { new DateTime(2024, 8, 23, 16, 11, 50, 133, DateTimeKind.Utc).AddTicks(5526), new DateTime(2024, 8, 23, 16, 11, 50, 133, DateTimeKind.Utc).AddTicks(5527) });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.RenameColumn(
                name: "Address",
                table: "Shelters",
                newName: "Street");

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: 2001,
                columns: new[] { "ConcurrencyStamp", "CreatedTime", "LastUpdatedTime", "RefreshTokenCreateTime" },
                values: new object[] { "68a2bdbb-8e0e-4e8b-92b1-59e401c7717c", new DateTime(2024, 8, 23, 11, 27, 24, 905, DateTimeKind.Utc).AddTicks(3165), new DateTime(2024, 8, 23, 11, 27, 24, 905, DateTimeKind.Utc).AddTicks(3167), new DateTime(2024, 8, 23, 11, 27, 24, 905, DateTimeKind.Utc).AddTicks(3094) });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: 2002,
                columns: new[] { "ConcurrencyStamp", "CreatedTime", "LastUpdatedTime", "RefreshTokenCreateTime" },
                values: new object[] { "2f0c22f2-0c59-4b9a-8e03-c69b13d4379b", new DateTime(2024, 8, 23, 11, 27, 24, 905, DateTimeKind.Utc).AddTicks(3225), new DateTime(2024, 8, 23, 11, 27, 24, 905, DateTimeKind.Utc).AddTicks(3226), new DateTime(2024, 8, 23, 11, 27, 24, 905, DateTimeKind.Utc).AddTicks(3221) });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: 2003,
                columns: new[] { "ConcurrencyStamp", "CreatedTime", "LastUpdatedTime", "RefreshTokenCreateTime" },
                values: new object[] { "aec56c87-c5a8-486f-be0e-d2a647bffbcb", new DateTime(2024, 8, 23, 11, 27, 24, 905, DateTimeKind.Utc).AddTicks(3240), new DateTime(2024, 8, 23, 11, 27, 24, 905, DateTimeKind.Utc).AddTicks(3240), new DateTime(2024, 8, 23, 11, 27, 24, 905, DateTimeKind.Utc).AddTicks(3236) });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: 2004,
                columns: new[] { "ConcurrencyStamp", "CreatedTime", "LastUpdatedTime", "RefreshTokenCreateTime" },
                values: new object[] { "efd6b6c0-d2f7-41b6-8778-170c2b8e8071", new DateTime(2024, 8, 23, 11, 27, 24, 905, DateTimeKind.Utc).AddTicks(3251), new DateTime(2024, 8, 23, 11, 27, 24, 905, DateTimeKind.Utc).AddTicks(3252), new DateTime(2024, 8, 23, 11, 27, 24, 905, DateTimeKind.Utc).AddTicks(3248) });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: 2005,
                columns: new[] { "ConcurrencyStamp", "CreatedTime", "LastUpdatedTime", "RefreshTokenCreateTime" },
                values: new object[] { "1d7c8a41-342f-4e58-aeb1-6539f89b24ae", new DateTime(2024, 8, 23, 11, 27, 24, 905, DateTimeKind.Utc).AddTicks(3262), new DateTime(2024, 8, 23, 11, 27, 24, 905, DateTimeKind.Utc).AddTicks(3263), new DateTime(2024, 8, 23, 11, 27, 24, 905, DateTimeKind.Utc).AddTicks(3259) });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: 2006,
                columns: new[] { "ConcurrencyStamp", "CreatedTime", "LastUpdatedTime", "RefreshTokenCreateTime" },
                values: new object[] { "4bc69c00-f688-4ade-9264-b44b61b170d8", new DateTime(2024, 8, 23, 11, 27, 24, 905, DateTimeKind.Utc).AddTicks(3277), new DateTime(2024, 8, 23, 11, 27, 24, 905, DateTimeKind.Utc).AddTicks(3278), new DateTime(2024, 8, 23, 11, 27, 24, 905, DateTimeKind.Utc).AddTicks(3275) });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: 2007,
                columns: new[] { "ConcurrencyStamp", "CreatedTime", "LastUpdatedTime", "RefreshTokenCreateTime" },
                values: new object[] { "eca8dae2-1e3d-4c17-b033-eaaab502ced6", new DateTime(2024, 8, 23, 11, 27, 24, 905, DateTimeKind.Utc).AddTicks(3289), new DateTime(2024, 8, 23, 11, 27, 24, 905, DateTimeKind.Utc).AddTicks(3289), new DateTime(2024, 8, 23, 11, 27, 24, 905, DateTimeKind.Utc).AddTicks(3286) });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: 2008,
                columns: new[] { "ConcurrencyStamp", "CreatedTime", "LastUpdatedTime", "RefreshTokenCreateTime" },
                values: new object[] { "9252932c-d9b8-4646-a9f7-18aca7e5061c", new DateTime(2024, 8, 23, 11, 27, 24, 905, DateTimeKind.Utc).AddTicks(3393), new DateTime(2024, 8, 23, 11, 27, 24, 905, DateTimeKind.Utc).AddTicks(3393), new DateTime(2024, 8, 23, 11, 27, 24, 905, DateTimeKind.Utc).AddTicks(3377) });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: 2009,
                columns: new[] { "ConcurrencyStamp", "CreatedTime", "LastUpdatedTime", "RefreshTokenCreateTime" },
                values: new object[] { "7fb1529a-bead-4023-8c03-5784fbd6d076", new DateTime(2024, 8, 23, 11, 27, 24, 905, DateTimeKind.Utc).AddTicks(3406), new DateTime(2024, 8, 23, 11, 27, 24, 905, DateTimeKind.Utc).AddTicks(3407), new DateTime(2024, 8, 23, 11, 27, 24, 905, DateTimeKind.Utc).AddTicks(3403) });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: 2010,
                columns: new[] { "ConcurrencyStamp", "CreatedTime", "LastUpdatedTime", "RefreshTokenCreateTime" },
                values: new object[] { "4afe4aa0-078e-4233-bc99-3181f4b3c8e2", new DateTime(2024, 8, 23, 11, 27, 24, 905, DateTimeKind.Utc).AddTicks(3419), new DateTime(2024, 8, 23, 11, 27, 24, 905, DateTimeKind.Utc).AddTicks(3420), new DateTime(2024, 8, 23, 11, 27, 24, 905, DateTimeKind.Utc).AddTicks(3416) });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: 2011,
                columns: new[] { "ConcurrencyStamp", "CreatedTime", "LastUpdatedTime", "RefreshTokenCreateTime" },
                values: new object[] { "5c0a284c-037c-4c71-95bc-02d3304c54f8", new DateTime(2024, 8, 23, 11, 27, 24, 905, DateTimeKind.Utc).AddTicks(3434), new DateTime(2024, 8, 23, 11, 27, 24, 905, DateTimeKind.Utc).AddTicks(3434), new DateTime(2024, 8, 23, 11, 27, 24, 905, DateTimeKind.Utc).AddTicks(3431) });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: 2012,
                columns: new[] { "ConcurrencyStamp", "CreatedTime", "LastUpdatedTime", "RefreshTokenCreateTime" },
                values: new object[] { "3a7efcfa-9538-4349-a5b9-232a076a27f6", new DateTime(2024, 8, 23, 11, 27, 24, 905, DateTimeKind.Utc).AddTicks(3445), new DateTime(2024, 8, 23, 11, 27, 24, 905, DateTimeKind.Utc).AddTicks(3446), new DateTime(2024, 8, 23, 11, 27, 24, 905, DateTimeKind.Utc).AddTicks(3442) });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: 2013,
                columns: new[] { "ConcurrencyStamp", "CreatedTime", "LastUpdatedTime", "RefreshTokenCreateTime" },
                values: new object[] { "f679f746-0884-47d1-bda1-fe1e7528e0e1", new DateTime(2024, 8, 23, 11, 27, 24, 905, DateTimeKind.Utc).AddTicks(3457), new DateTime(2024, 8, 23, 11, 27, 24, 905, DateTimeKind.Utc).AddTicks(3457), new DateTime(2024, 8, 23, 11, 27, 24, 905, DateTimeKind.Utc).AddTicks(3454) });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: 2014,
                columns: new[] { "ConcurrencyStamp", "CreatedTime", "LastUpdatedTime", "RefreshTokenCreateTime" },
                values: new object[] { "b7883c46-e6cd-4650-8237-98abf7023202", new DateTime(2024, 8, 23, 11, 27, 24, 905, DateTimeKind.Utc).AddTicks(3469), new DateTime(2024, 8, 23, 11, 27, 24, 905, DateTimeKind.Utc).AddTicks(3469), new DateTime(2024, 8, 23, 11, 27, 24, 905, DateTimeKind.Utc).AddTicks(3466) });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: 2015,
                columns: new[] { "ConcurrencyStamp", "CreatedTime", "LastUpdatedTime", "RefreshTokenCreateTime" },
                values: new object[] { "15fc39e5-f38c-45f4-85ab-ac8c41b0cf21", new DateTime(2024, 8, 23, 11, 27, 24, 905, DateTimeKind.Utc).AddTicks(3480), new DateTime(2024, 8, 23, 11, 27, 24, 905, DateTimeKind.Utc).AddTicks(3480), new DateTime(2024, 8, 23, 11, 27, 24, 905, DateTimeKind.Utc).AddTicks(3477) });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: 2016,
                columns: new[] { "ConcurrencyStamp", "CreatedTime", "LastUpdatedTime", "RefreshTokenCreateTime" },
                values: new object[] { "f200b7bd-835e-4758-ac9f-f84a82f2be42", new DateTime(2024, 8, 23, 11, 27, 24, 905, DateTimeKind.Utc).AddTicks(3494), new DateTime(2024, 8, 23, 11, 27, 24, 905, DateTimeKind.Utc).AddTicks(3495), new DateTime(2024, 8, 23, 11, 27, 24, 905, DateTimeKind.Utc).AddTicks(3488) });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: 2017,
                columns: new[] { "ConcurrencyStamp", "CreatedTime", "LastUpdatedTime", "RefreshTokenCreateTime" },
                values: new object[] { "6b87077e-3cfa-4345-9f5d-b52c0f2c9b66", new DateTime(2024, 8, 23, 11, 27, 24, 905, DateTimeKind.Utc).AddTicks(3506), new DateTime(2024, 8, 23, 11, 27, 24, 905, DateTimeKind.Utc).AddTicks(3506), new DateTime(2024, 8, 23, 11, 27, 24, 905, DateTimeKind.Utc).AddTicks(3503) });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: 2018,
                columns: new[] { "ConcurrencyStamp", "CreatedTime", "LastUpdatedTime", "RefreshTokenCreateTime" },
                values: new object[] { "6ee84622-2d78-49e0-a985-a8f11ae65cf9", new DateTime(2024, 8, 23, 11, 27, 24, 905, DateTimeKind.Utc).AddTicks(3572), new DateTime(2024, 8, 23, 11, 27, 24, 905, DateTimeKind.Utc).AddTicks(3572), new DateTime(2024, 8, 23, 11, 27, 24, 905, DateTimeKind.Utc).AddTicks(3569) });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: 2019,
                columns: new[] { "ConcurrencyStamp", "CreatedTime", "LastUpdatedTime", "RefreshTokenCreateTime" },
                values: new object[] { "84eb7fe5-408a-47bf-abc0-9c651402f397", new DateTime(2024, 8, 23, 11, 27, 24, 905, DateTimeKind.Utc).AddTicks(3584), new DateTime(2024, 8, 23, 11, 27, 24, 905, DateTimeKind.Utc).AddTicks(3584), new DateTime(2024, 8, 23, 11, 27, 24, 905, DateTimeKind.Utc).AddTicks(3581) });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: 2020,
                columns: new[] { "ConcurrencyStamp", "CreatedTime", "LastUpdatedTime", "RefreshTokenCreateTime" },
                values: new object[] { "1e39d566-0b1b-4c5d-8114-831e00043b24", new DateTime(2024, 8, 23, 11, 27, 24, 905, DateTimeKind.Utc).AddTicks(3595), new DateTime(2024, 8, 23, 11, 27, 24, 905, DateTimeKind.Utc).AddTicks(3596), new DateTime(2024, 8, 23, 11, 27, 24, 905, DateTimeKind.Utc).AddTicks(3592) });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: 2021,
                columns: new[] { "ConcurrencyStamp", "CreatedTime", "LastUpdatedTime", "RefreshTokenCreateTime" },
                values: new object[] { "96de93cc-dfec-4bad-ad30-7f266302e1e1", new DateTime(2024, 8, 23, 11, 27, 24, 905, DateTimeKind.Utc).AddTicks(3606), new DateTime(2024, 8, 23, 11, 27, 24, 905, DateTimeKind.Utc).AddTicks(3607), new DateTime(2024, 8, 23, 11, 27, 24, 905, DateTimeKind.Utc).AddTicks(3603) });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: 2022,
                columns: new[] { "ConcurrencyStamp", "CreatedTime", "LastUpdatedTime", "RefreshTokenCreateTime" },
                values: new object[] { "ee00ae93-ecf2-4be1-9773-1c58a013cd01", new DateTime(2024, 8, 23, 11, 27, 24, 905, DateTimeKind.Utc).AddTicks(3626), new DateTime(2024, 8, 23, 11, 27, 24, 905, DateTimeKind.Utc).AddTicks(3626), new DateTime(2024, 8, 23, 11, 27, 24, 905, DateTimeKind.Utc).AddTicks(3623) });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: 2023,
                columns: new[] { "ConcurrencyStamp", "CreatedTime", "LastUpdatedTime", "RefreshTokenCreateTime" },
                values: new object[] { "83f58708-879d-4058-a473-c7cd6df93155", new DateTime(2024, 8, 23, 11, 27, 24, 905, DateTimeKind.Utc).AddTicks(3639), new DateTime(2024, 8, 23, 11, 27, 24, 905, DateTimeKind.Utc).AddTicks(3639), new DateTime(2024, 8, 23, 11, 27, 24, 905, DateTimeKind.Utc).AddTicks(3636) });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: 2024,
                columns: new[] { "ConcurrencyStamp", "CreatedTime", "LastUpdatedTime", "RefreshTokenCreateTime" },
                values: new object[] { "d72a0f2c-a9b1-4035-bcff-2b55fe132dbc", new DateTime(2024, 8, 23, 11, 27, 24, 905, DateTimeKind.Utc).AddTicks(3654), new DateTime(2024, 8, 23, 11, 27, 24, 905, DateTimeKind.Utc).AddTicks(3655), new DateTime(2024, 8, 23, 11, 27, 24, 905, DateTimeKind.Utc).AddTicks(3648) });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: 2025,
                columns: new[] { "ConcurrencyStamp", "CreatedTime", "LastUpdatedTime", "RefreshTokenCreateTime" },
                values: new object[] { "7bdde75c-4c44-4cb1-ad88-67e443686a2b", new DateTime(2024, 8, 23, 11, 27, 24, 905, DateTimeKind.Utc).AddTicks(3667), new DateTime(2024, 8, 23, 11, 27, 24, 905, DateTimeKind.Utc).AddTicks(3667), new DateTime(2024, 8, 23, 11, 27, 24, 905, DateTimeKind.Utc).AddTicks(3664) });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: 2026,
                columns: new[] { "ConcurrencyStamp", "CreatedTime", "LastUpdatedTime", "RefreshTokenCreateTime" },
                values: new object[] { "8f16a2af-10e9-4b65-9149-d4a65193c8e8", new DateTime(2024, 8, 23, 11, 27, 24, 905, DateTimeKind.Utc).AddTicks(3679), new DateTime(2024, 8, 23, 11, 27, 24, 905, DateTimeKind.Utc).AddTicks(3680), new DateTime(2024, 8, 23, 11, 27, 24, 905, DateTimeKind.Utc).AddTicks(3676) });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: 2027,
                columns: new[] { "ConcurrencyStamp", "CreatedTime", "LastUpdatedTime", "RefreshTokenCreateTime" },
                values: new object[] { "346fa2c4-9380-44d3-8b7e-b4c78e9b029d", new DateTime(2024, 8, 23, 11, 27, 24, 905, DateTimeKind.Utc).AddTicks(3728), new DateTime(2024, 8, 23, 11, 27, 24, 905, DateTimeKind.Utc).AddTicks(3728), new DateTime(2024, 8, 23, 11, 27, 24, 905, DateTimeKind.Utc).AddTicks(3724) });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: 2028,
                columns: new[] { "ConcurrencyStamp", "CreatedTime", "LastUpdatedTime", "RefreshTokenCreateTime" },
                values: new object[] { "7b6f9f31-25c2-441d-959e-dc24345518bc", new DateTime(2024, 8, 23, 11, 27, 24, 905, DateTimeKind.Utc).AddTicks(3740), new DateTime(2024, 8, 23, 11, 27, 24, 905, DateTimeKind.Utc).AddTicks(3741), new DateTime(2024, 8, 23, 11, 27, 24, 905, DateTimeKind.Utc).AddTicks(3737) });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: 2029,
                columns: new[] { "ConcurrencyStamp", "CreatedTime", "LastUpdatedTime", "RefreshTokenCreateTime" },
                values: new object[] { "b335b848-0a69-4c60-a463-920851273fe8", new DateTime(2024, 8, 23, 11, 27, 24, 905, DateTimeKind.Utc).AddTicks(3752), new DateTime(2024, 8, 23, 11, 27, 24, 905, DateTimeKind.Utc).AddTicks(3753), new DateTime(2024, 8, 23, 11, 27, 24, 905, DateTimeKind.Utc).AddTicks(3749) });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: 2030,
                columns: new[] { "ConcurrencyStamp", "CreatedTime", "LastUpdatedTime", "RefreshTokenCreateTime" },
                values: new object[] { "003eca8b-5647-4da3-8c80-c7f180328306", new DateTime(2024, 8, 23, 11, 27, 24, 905, DateTimeKind.Utc).AddTicks(3765), new DateTime(2024, 8, 23, 11, 27, 24, 905, DateTimeKind.Utc).AddTicks(3765), new DateTime(2024, 8, 23, 11, 27, 24, 905, DateTimeKind.Utc).AddTicks(3762) });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: 2031,
                columns: new[] { "ConcurrencyStamp", "CreatedTime", "LastUpdatedTime", "RefreshTokenCreateTime" },
                values: new object[] { "00ac538e-a1f0-4e10-a039-74be7869a3e2", new DateTime(2024, 8, 23, 11, 27, 24, 905, DateTimeKind.Utc).AddTicks(3777), new DateTime(2024, 8, 23, 11, 27, 24, 905, DateTimeKind.Utc).AddTicks(3778), new DateTime(2024, 8, 23, 11, 27, 24, 905, DateTimeKind.Utc).AddTicks(3774) });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: 2032,
                columns: new[] { "ConcurrencyStamp", "CreatedTime", "LastUpdatedTime", "RefreshTokenCreateTime" },
                values: new object[] { "d5fe06d0-19c6-44fb-96a7-2b10f0b3e8b5", new DateTime(2024, 8, 23, 11, 27, 24, 905, DateTimeKind.Utc).AddTicks(3792), new DateTime(2024, 8, 23, 11, 27, 24, 905, DateTimeKind.Utc).AddTicks(3793), new DateTime(2024, 8, 23, 11, 27, 24, 905, DateTimeKind.Utc).AddTicks(3786) });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: 2033,
                columns: new[] { "ConcurrencyStamp", "CreatedTime", "LastUpdatedTime", "RefreshTokenCreateTime" },
                values: new object[] { "6abb3043-29ef-4d2b-bb7c-ebd668d496c6", new DateTime(2024, 8, 23, 11, 27, 24, 905, DateTimeKind.Utc).AddTicks(3804), new DateTime(2024, 8, 23, 11, 27, 24, 905, DateTimeKind.Utc).AddTicks(3805), new DateTime(2024, 8, 23, 11, 27, 24, 905, DateTimeKind.Utc).AddTicks(3801) });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: 2034,
                columns: new[] { "ConcurrencyStamp", "CreatedTime", "LastUpdatedTime", "RefreshTokenCreateTime" },
                values: new object[] { "9e76a8fa-40d9-457f-b81e-8b91b2c4a8ac", new DateTime(2024, 8, 23, 11, 27, 24, 905, DateTimeKind.Utc).AddTicks(3819), new DateTime(2024, 8, 23, 11, 27, 24, 905, DateTimeKind.Utc).AddTicks(3819), new DateTime(2024, 8, 23, 11, 27, 24, 905, DateTimeKind.Utc).AddTicks(3816) });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: 2035,
                columns: new[] { "ConcurrencyStamp", "CreatedTime", "LastUpdatedTime", "RefreshTokenCreateTime" },
                values: new object[] { "849c9bf4-492f-44a3-a189-c95ed51eaf99", new DateTime(2024, 8, 23, 11, 27, 24, 905, DateTimeKind.Utc).AddTicks(3892), new DateTime(2024, 8, 23, 11, 27, 24, 905, DateTimeKind.Utc).AddTicks(3893), new DateTime(2024, 8, 23, 11, 27, 24, 905, DateTimeKind.Utc).AddTicks(3889) });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: 2036,
                columns: new[] { "ConcurrencyStamp", "CreatedTime", "LastUpdatedTime", "RefreshTokenCreateTime" },
                values: new object[] { "c5e91925-7a6b-4f1b-ad38-452151785dfc", new DateTime(2024, 8, 23, 11, 27, 24, 905, DateTimeKind.Utc).AddTicks(3905), new DateTime(2024, 8, 23, 11, 27, 24, 905, DateTimeKind.Utc).AddTicks(3905), new DateTime(2024, 8, 23, 11, 27, 24, 905, DateTimeKind.Utc).AddTicks(3901) });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: 2037,
                columns: new[] { "ConcurrencyStamp", "CreatedTime", "LastUpdatedTime", "RefreshTokenCreateTime" },
                values: new object[] { "f8c21a71-567d-406f-adb7-f5eec929c0a7", new DateTime(2024, 8, 23, 11, 27, 24, 905, DateTimeKind.Utc).AddTicks(3917), new DateTime(2024, 8, 23, 11, 27, 24, 905, DateTimeKind.Utc).AddTicks(3917), new DateTime(2024, 8, 23, 11, 27, 24, 905, DateTimeKind.Utc).AddTicks(3914) });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: 2038,
                columns: new[] { "ConcurrencyStamp", "CreatedTime", "LastUpdatedTime", "RefreshTokenCreateTime" },
                values: new object[] { "dbbec5a0-6326-46ac-99d6-2d38aded1c03", new DateTime(2024, 8, 23, 11, 27, 24, 905, DateTimeKind.Utc).AddTicks(3929), new DateTime(2024, 8, 23, 11, 27, 24, 905, DateTimeKind.Utc).AddTicks(3930), new DateTime(2024, 8, 23, 11, 27, 24, 905, DateTimeKind.Utc).AddTicks(3927) });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: 2039,
                columns: new[] { "ConcurrencyStamp", "CreatedTime", "LastUpdatedTime", "RefreshTokenCreateTime" },
                values: new object[] { "dcb3adfa-c8e2-4574-8cf6-b1b15d81f608", new DateTime(2024, 8, 23, 11, 27, 24, 905, DateTimeKind.Utc).AddTicks(3942), new DateTime(2024, 8, 23, 11, 27, 24, 905, DateTimeKind.Utc).AddTicks(3942), new DateTime(2024, 8, 23, 11, 27, 24, 905, DateTimeKind.Utc).AddTicks(3939) });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: 2040,
                columns: new[] { "ConcurrencyStamp", "CreatedTime", "LastUpdatedTime", "RefreshTokenCreateTime" },
                values: new object[] { "64313b16-3df3-462d-bb2d-186be807c5dc", new DateTime(2024, 8, 23, 11, 27, 24, 905, DateTimeKind.Utc).AddTicks(3957), new DateTime(2024, 8, 23, 11, 27, 24, 905, DateTimeKind.Utc).AddTicks(3957), new DateTime(2024, 8, 23, 11, 27, 24, 905, DateTimeKind.Utc).AddTicks(3951) });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: 2041,
                columns: new[] { "ConcurrencyStamp", "CreatedTime", "LastUpdatedTime", "RefreshTokenCreateTime" },
                values: new object[] { "5cb57756-59ef-4baa-8f30-d9bf6bf6a5ee", new DateTime(2024, 8, 23, 11, 27, 24, 905, DateTimeKind.Utc).AddTicks(3969), new DateTime(2024, 8, 23, 11, 27, 24, 905, DateTimeKind.Utc).AddTicks(3970), new DateTime(2024, 8, 23, 11, 27, 24, 905, DateTimeKind.Utc).AddTicks(3966) });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: 2042,
                columns: new[] { "ConcurrencyStamp", "CreatedTime", "LastUpdatedTime", "RefreshTokenCreateTime" },
                values: new object[] { "bf7362f7-3159-4628-83a0-7ac20e8558a3", new DateTime(2024, 8, 23, 11, 27, 24, 905, DateTimeKind.Utc).AddTicks(3986), new DateTime(2024, 8, 23, 11, 27, 24, 905, DateTimeKind.Utc).AddTicks(3987), new DateTime(2024, 8, 23, 11, 27, 24, 905, DateTimeKind.Utc).AddTicks(3983) });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: 2043,
                columns: new[] { "ConcurrencyStamp", "CreatedTime", "LastUpdatedTime", "RefreshTokenCreateTime" },
                values: new object[] { "2e137223-b64a-47dc-aff0-3a49d1faa47f", new DateTime(2024, 8, 23, 11, 27, 24, 905, DateTimeKind.Utc).AddTicks(3998), new DateTime(2024, 8, 23, 11, 27, 24, 905, DateTimeKind.Utc).AddTicks(3999), new DateTime(2024, 8, 23, 11, 27, 24, 905, DateTimeKind.Utc).AddTicks(3995) });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: 2044,
                columns: new[] { "ConcurrencyStamp", "CreatedTime", "LastUpdatedTime", "RefreshTokenCreateTime" },
                values: new object[] { "0a464b47-d13a-4606-8a3b-b327a3ba7e72", new DateTime(2024, 8, 23, 11, 27, 24, 905, DateTimeKind.Utc).AddTicks(4046), new DateTime(2024, 8, 23, 11, 27, 24, 905, DateTimeKind.Utc).AddTicks(4046), new DateTime(2024, 8, 23, 11, 27, 24, 905, DateTimeKind.Utc).AddTicks(4042) });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: 2045,
                columns: new[] { "ConcurrencyStamp", "CreatedTime", "LastUpdatedTime", "RefreshTokenCreateTime" },
                values: new object[] { "0ee9268a-3ac0-4c7d-9219-cc3b334effa6", new DateTime(2024, 8, 23, 11, 27, 24, 905, DateTimeKind.Utc).AddTicks(4057), new DateTime(2024, 8, 23, 11, 27, 24, 905, DateTimeKind.Utc).AddTicks(4058), new DateTime(2024, 8, 23, 11, 27, 24, 905, DateTimeKind.Utc).AddTicks(4055) });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: 2046,
                columns: new[] { "ConcurrencyStamp", "CreatedTime", "LastUpdatedTime", "RefreshTokenCreateTime" },
                values: new object[] { "ce79bd5e-2e00-4f79-b16c-53e26467f3aa", new DateTime(2024, 8, 23, 11, 27, 24, 905, DateTimeKind.Utc).AddTicks(4069), new DateTime(2024, 8, 23, 11, 27, 24, 905, DateTimeKind.Utc).AddTicks(4070), new DateTime(2024, 8, 23, 11, 27, 24, 905, DateTimeKind.Utc).AddTicks(4066) });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: 2047,
                columns: new[] { "ConcurrencyStamp", "CreatedTime", "LastUpdatedTime", "RefreshTokenCreateTime" },
                values: new object[] { "95686ecb-6a39-4ef7-885f-8a30e4bff962", new DateTime(2024, 8, 23, 11, 27, 24, 905, DateTimeKind.Utc).AddTicks(4081), new DateTime(2024, 8, 23, 11, 27, 24, 905, DateTimeKind.Utc).AddTicks(4081), new DateTime(2024, 8, 23, 11, 27, 24, 905, DateTimeKind.Utc).AddTicks(4077) });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: 2048,
                columns: new[] { "ConcurrencyStamp", "CreatedTime", "LastUpdatedTime", "RefreshTokenCreateTime" },
                values: new object[] { "d38b5aac-5d2a-4530-8e3b-ce92afb60961", new DateTime(2024, 8, 23, 11, 27, 24, 905, DateTimeKind.Utc).AddTicks(4095), new DateTime(2024, 8, 23, 11, 27, 24, 905, DateTimeKind.Utc).AddTicks(4095), new DateTime(2024, 8, 23, 11, 27, 24, 905, DateTimeKind.Utc).AddTicks(4089) });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: 2049,
                columns: new[] { "ConcurrencyStamp", "CreatedTime", "LastUpdatedTime", "RefreshTokenCreateTime" },
                values: new object[] { "7c7d19a9-18d2-4b95-b2c2-e3dd3687aeee", new DateTime(2024, 8, 23, 11, 27, 24, 905, DateTimeKind.Utc).AddTicks(4107), new DateTime(2024, 8, 23, 11, 27, 24, 905, DateTimeKind.Utc).AddTicks(4107), new DateTime(2024, 8, 23, 11, 27, 24, 905, DateTimeKind.Utc).AddTicks(4104) });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: 2050,
                columns: new[] { "ConcurrencyStamp", "CreatedTime", "LastUpdatedTime", "RefreshTokenCreateTime" },
                values: new object[] { "afc65225-6859-4775-8d78-08bac3e5a145", new DateTime(2024, 8, 23, 11, 27, 24, 905, DateTimeKind.Utc).AddTicks(4118), new DateTime(2024, 8, 23, 11, 27, 24, 905, DateTimeKind.Utc).AddTicks(4119), new DateTime(2024, 8, 23, 11, 27, 24, 905, DateTimeKind.Utc).AddTicks(4115) });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: 2051,
                columns: new[] { "ConcurrencyStamp", "CreatedTime", "LastUpdatedTime", "RefreshTokenCreateTime" },
                values: new object[] { "fcd2c141-c95e-4bb8-adfd-2ecdaf8fcc5b", new DateTime(2024, 8, 23, 11, 27, 24, 905, DateTimeKind.Utc).AddTicks(4129), new DateTime(2024, 8, 23, 11, 27, 24, 905, DateTimeKind.Utc).AddTicks(4130), new DateTime(2024, 8, 23, 11, 27, 24, 905, DateTimeKind.Utc).AddTicks(4126) });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: 2052,
                columns: new[] { "ConcurrencyStamp", "CreatedTime", "LastUpdatedTime", "RefreshTokenCreateTime" },
                values: new object[] { "e38b80e5-c185-422c-a511-9468900a3edf", new DateTime(2024, 8, 23, 11, 27, 24, 905, DateTimeKind.Utc).AddTicks(4141), new DateTime(2024, 8, 23, 11, 27, 24, 905, DateTimeKind.Utc).AddTicks(4141), new DateTime(2024, 8, 23, 11, 27, 24, 905, DateTimeKind.Utc).AddTicks(4138) });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: 2053,
                columns: new[] { "ConcurrencyStamp", "CreatedTime", "LastUpdatedTime", "RefreshTokenCreateTime" },
                values: new object[] { "6b641af4-491c-4c9c-9fca-ab34f8d6fc5a", new DateTime(2024, 8, 23, 11, 27, 24, 905, DateTimeKind.Utc).AddTicks(4152), new DateTime(2024, 8, 23, 11, 27, 24, 905, DateTimeKind.Utc).AddTicks(4153), new DateTime(2024, 8, 23, 11, 27, 24, 905, DateTimeKind.Utc).AddTicks(4149) });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: 2054,
                columns: new[] { "ConcurrencyStamp", "CreatedTime", "LastUpdatedTime", "RefreshTokenCreateTime" },
                values: new object[] { "57c0817a-c262-4612-9289-e511d37b985f", new DateTime(2024, 8, 23, 11, 27, 24, 905, DateTimeKind.Utc).AddTicks(4199), new DateTime(2024, 8, 23, 11, 27, 24, 905, DateTimeKind.Utc).AddTicks(4199), new DateTime(2024, 8, 23, 11, 27, 24, 905, DateTimeKind.Utc).AddTicks(4196) });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: 2055,
                columns: new[] { "ConcurrencyStamp", "CreatedTime", "LastUpdatedTime", "RefreshTokenCreateTime" },
                values: new object[] { "cb17eda4-7213-4b09-a43b-84218605c9ab", new DateTime(2024, 8, 23, 11, 27, 24, 905, DateTimeKind.Utc).AddTicks(4210), new DateTime(2024, 8, 23, 11, 27, 24, 905, DateTimeKind.Utc).AddTicks(4211), new DateTime(2024, 8, 23, 11, 27, 24, 905, DateTimeKind.Utc).AddTicks(4207) });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: 2056,
                columns: new[] { "ConcurrencyStamp", "CreatedTime", "LastUpdatedTime", "RefreshTokenCreateTime" },
                values: new object[] { "4fa2e8b2-9a6b-4f31-9708-9be1d010835b", new DateTime(2024, 8, 23, 11, 27, 24, 905, DateTimeKind.Utc).AddTicks(4225), new DateTime(2024, 8, 23, 11, 27, 24, 905, DateTimeKind.Utc).AddTicks(4225), new DateTime(2024, 8, 23, 11, 27, 24, 905, DateTimeKind.Utc).AddTicks(4219) });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: 2057,
                columns: new[] { "ConcurrencyStamp", "CreatedTime", "LastUpdatedTime", "RefreshTokenCreateTime" },
                values: new object[] { "0994161f-0695-4a81-9f4b-bf3e435e7d19", new DateTime(2024, 8, 23, 11, 27, 24, 905, DateTimeKind.Utc).AddTicks(4237), new DateTime(2024, 8, 23, 11, 27, 24, 905, DateTimeKind.Utc).AddTicks(4237), new DateTime(2024, 8, 23, 11, 27, 24, 905, DateTimeKind.Utc).AddTicks(4233) });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: 2058,
                columns: new[] { "ConcurrencyStamp", "CreatedTime", "LastUpdatedTime", "RefreshTokenCreateTime" },
                values: new object[] { "596df4d0-9e9d-4d26-b584-14324c004c92", new DateTime(2024, 8, 23, 11, 27, 24, 905, DateTimeKind.Utc).AddTicks(4247), new DateTime(2024, 8, 23, 11, 27, 24, 905, DateTimeKind.Utc).AddTicks(4248), new DateTime(2024, 8, 23, 11, 27, 24, 905, DateTimeKind.Utc).AddTicks(4244) });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: 2059,
                columns: new[] { "ConcurrencyStamp", "CreatedTime", "LastUpdatedTime", "RefreshTokenCreateTime" },
                values: new object[] { "7562f530-7343-447c-8610-b8eb27fdd428", new DateTime(2024, 8, 23, 11, 27, 24, 905, DateTimeKind.Utc).AddTicks(4258), new DateTime(2024, 8, 23, 11, 27, 24, 905, DateTimeKind.Utc).AddTicks(4259), new DateTime(2024, 8, 23, 11, 27, 24, 905, DateTimeKind.Utc).AddTicks(4255) });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: 2060,
                columns: new[] { "ConcurrencyStamp", "CreatedTime", "LastUpdatedTime", "RefreshTokenCreateTime" },
                values: new object[] { "7ca6ed39-dd8a-41d1-b778-01176bbcb5a2", new DateTime(2024, 8, 23, 11, 27, 24, 905, DateTimeKind.Utc).AddTicks(4269), new DateTime(2024, 8, 23, 11, 27, 24, 905, DateTimeKind.Utc).AddTicks(4270), new DateTime(2024, 8, 23, 11, 27, 24, 905, DateTimeKind.Utc).AddTicks(4266) });

            migrationBuilder.UpdateData(
                table: "Breeds",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedTime",
                value: new DateTime(2024, 8, 23, 15, 27, 24, 895, DateTimeKind.Local).AddTicks(6486));

            migrationBuilder.UpdateData(
                table: "Breeds",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreatedTime",
                value: new DateTime(2024, 8, 23, 15, 27, 24, 895, DateTimeKind.Local).AddTicks(6493));

            migrationBuilder.UpdateData(
                table: "Breeds",
                keyColumn: "Id",
                keyValue: 3,
                column: "CreatedTime",
                value: new DateTime(2024, 8, 23, 15, 27, 24, 895, DateTimeKind.Local).AddTicks(6495));

            migrationBuilder.UpdateData(
                table: "Breeds",
                keyColumn: "Id",
                keyValue: 4,
                column: "CreatedTime",
                value: new DateTime(2024, 8, 23, 15, 27, 24, 895, DateTimeKind.Local).AddTicks(6496));

            migrationBuilder.UpdateData(
                table: "Breeds",
                keyColumn: "Id",
                keyValue: 5,
                column: "CreatedTime",
                value: new DateTime(2024, 8, 23, 15, 27, 24, 895, DateTimeKind.Local).AddTicks(6498));

            migrationBuilder.UpdateData(
                table: "Breeds",
                keyColumn: "Id",
                keyValue: 6,
                column: "CreatedTime",
                value: new DateTime(2024, 8, 23, 15, 27, 24, 895, DateTimeKind.Local).AddTicks(6499));

            migrationBuilder.UpdateData(
                table: "Breeds",
                keyColumn: "Id",
                keyValue: 7,
                column: "CreatedTime",
                value: new DateTime(2024, 8, 23, 15, 27, 24, 895, DateTimeKind.Local).AddTicks(6501));

            migrationBuilder.UpdateData(
                table: "Breeds",
                keyColumn: "Id",
                keyValue: 8,
                column: "CreatedTime",
                value: new DateTime(2024, 8, 23, 15, 27, 24, 895, DateTimeKind.Local).AddTicks(6502));

            migrationBuilder.UpdateData(
                table: "Breeds",
                keyColumn: "Id",
                keyValue: 9,
                column: "CreatedTime",
                value: new DateTime(2024, 8, 23, 15, 27, 24, 895, DateTimeKind.Local).AddTicks(6504));

            migrationBuilder.UpdateData(
                table: "Breeds",
                keyColumn: "Id",
                keyValue: 10,
                column: "CreatedTime",
                value: new DateTime(2024, 8, 23, 15, 27, 24, 895, DateTimeKind.Local).AddTicks(6505));

            migrationBuilder.UpdateData(
                table: "Breeds",
                keyColumn: "Id",
                keyValue: 11,
                column: "CreatedTime",
                value: new DateTime(2024, 8, 23, 15, 27, 24, 895, DateTimeKind.Local).AddTicks(6507));

            migrationBuilder.UpdateData(
                table: "Breeds",
                keyColumn: "Id",
                keyValue: 12,
                column: "CreatedTime",
                value: new DateTime(2024, 8, 23, 15, 27, 24, 895, DateTimeKind.Local).AddTicks(6508));

            migrationBuilder.UpdateData(
                table: "Breeds",
                keyColumn: "Id",
                keyValue: 13,
                column: "CreatedTime",
                value: new DateTime(2024, 8, 23, 15, 27, 24, 895, DateTimeKind.Local).AddTicks(6509));

            migrationBuilder.UpdateData(
                table: "Breeds",
                keyColumn: "Id",
                keyValue: 14,
                column: "CreatedTime",
                value: new DateTime(2024, 8, 23, 15, 27, 24, 895, DateTimeKind.Local).AddTicks(6511));

            migrationBuilder.UpdateData(
                table: "Breeds",
                keyColumn: "Id",
                keyValue: 15,
                column: "CreatedTime",
                value: new DateTime(2024, 8, 23, 15, 27, 24, 895, DateTimeKind.Local).AddTicks(6512));

            migrationBuilder.UpdateData(
                table: "Breeds",
                keyColumn: "Id",
                keyValue: 16,
                column: "CreatedTime",
                value: new DateTime(2024, 8, 23, 15, 27, 24, 895, DateTimeKind.Local).AddTicks(6513));

            migrationBuilder.UpdateData(
                table: "Breeds",
                keyColumn: "Id",
                keyValue: 17,
                column: "CreatedTime",
                value: new DateTime(2024, 8, 23, 15, 27, 24, 895, DateTimeKind.Local).AddTicks(6514));

            migrationBuilder.UpdateData(
                table: "Breeds",
                keyColumn: "Id",
                keyValue: 18,
                column: "CreatedTime",
                value: new DateTime(2024, 8, 23, 15, 27, 24, 895, DateTimeKind.Local).AddTicks(6516));

            migrationBuilder.UpdateData(
                table: "Breeds",
                keyColumn: "Id",
                keyValue: 19,
                column: "CreatedTime",
                value: new DateTime(2024, 8, 23, 15, 27, 24, 895, DateTimeKind.Local).AddTicks(6517));

            migrationBuilder.UpdateData(
                table: "Breeds",
                keyColumn: "Id",
                keyValue: 20,
                column: "CreatedTime",
                value: new DateTime(2024, 8, 23, 15, 27, 24, 895, DateTimeKind.Local).AddTicks(6518));

            migrationBuilder.UpdateData(
                table: "Breeds",
                keyColumn: "Id",
                keyValue: 21,
                column: "CreatedTime",
                value: new DateTime(2024, 8, 23, 15, 27, 24, 895, DateTimeKind.Local).AddTicks(6519));

            migrationBuilder.UpdateData(
                table: "Breeds",
                keyColumn: "Id",
                keyValue: 22,
                column: "CreatedTime",
                value: new DateTime(2024, 8, 23, 15, 27, 24, 895, DateTimeKind.Local).AddTicks(6521));

            migrationBuilder.UpdateData(
                table: "Breeds",
                keyColumn: "Id",
                keyValue: 23,
                column: "CreatedTime",
                value: new DateTime(2024, 8, 23, 15, 27, 24, 895, DateTimeKind.Local).AddTicks(6523));

            migrationBuilder.UpdateData(
                table: "Breeds",
                keyColumn: "Id",
                keyValue: 24,
                column: "CreatedTime",
                value: new DateTime(2024, 8, 23, 15, 27, 24, 895, DateTimeKind.Local).AddTicks(6524));

            migrationBuilder.UpdateData(
                table: "Breeds",
                keyColumn: "Id",
                keyValue: 25,
                column: "CreatedTime",
                value: new DateTime(2024, 8, 23, 15, 27, 24, 895, DateTimeKind.Local).AddTicks(6525));

            migrationBuilder.UpdateData(
                table: "Breeds",
                keyColumn: "Id",
                keyValue: 26,
                column: "CreatedTime",
                value: new DateTime(2024, 8, 23, 15, 27, 24, 895, DateTimeKind.Local).AddTicks(6527));

            migrationBuilder.UpdateData(
                table: "Breeds",
                keyColumn: "Id",
                keyValue: 27,
                column: "CreatedTime",
                value: new DateTime(2024, 8, 23, 15, 27, 24, 895, DateTimeKind.Local).AddTicks(6528));

            migrationBuilder.UpdateData(
                table: "Breeds",
                keyColumn: "Id",
                keyValue: 28,
                column: "CreatedTime",
                value: new DateTime(2024, 8, 23, 15, 27, 24, 895, DateTimeKind.Local).AddTicks(6529));

            migrationBuilder.UpdateData(
                table: "Breeds",
                keyColumn: "Id",
                keyValue: 29,
                column: "CreatedTime",
                value: new DateTime(2024, 8, 23, 15, 27, 24, 895, DateTimeKind.Local).AddTicks(6531));

            migrationBuilder.UpdateData(
                table: "Breeds",
                keyColumn: "Id",
                keyValue: 30,
                column: "CreatedTime",
                value: new DateTime(2024, 8, 23, 15, 27, 24, 895, DateTimeKind.Local).AddTicks(6532));

            migrationBuilder.UpdateData(
                table: "Breeds",
                keyColumn: "Id",
                keyValue: 31,
                column: "CreatedTime",
                value: new DateTime(2024, 8, 23, 15, 27, 24, 895, DateTimeKind.Local).AddTicks(6533));

            migrationBuilder.UpdateData(
                table: "Breeds",
                keyColumn: "Id",
                keyValue: 32,
                column: "CreatedTime",
                value: new DateTime(2024, 8, 23, 15, 27, 24, 895, DateTimeKind.Local).AddTicks(6535));

            migrationBuilder.UpdateData(
                table: "Breeds",
                keyColumn: "Id",
                keyValue: 33,
                column: "CreatedTime",
                value: new DateTime(2024, 8, 23, 15, 27, 24, 895, DateTimeKind.Local).AddTicks(6536));

            migrationBuilder.UpdateData(
                table: "Breeds",
                keyColumn: "Id",
                keyValue: 34,
                column: "CreatedTime",
                value: new DateTime(2024, 8, 23, 15, 27, 24, 895, DateTimeKind.Local).AddTicks(6538));

            migrationBuilder.UpdateData(
                table: "Breeds",
                keyColumn: "Id",
                keyValue: 35,
                column: "CreatedTime",
                value: new DateTime(2024, 8, 23, 15, 27, 24, 895, DateTimeKind.Local).AddTicks(6539));

            migrationBuilder.UpdateData(
                table: "Breeds",
                keyColumn: "Id",
                keyValue: 36,
                column: "CreatedTime",
                value: new DateTime(2024, 8, 23, 15, 27, 24, 895, DateTimeKind.Local).AddTicks(6540));

            migrationBuilder.UpdateData(
                table: "Breeds",
                keyColumn: "Id",
                keyValue: 37,
                column: "CreatedTime",
                value: new DateTime(2024, 8, 23, 15, 27, 24, 895, DateTimeKind.Local).AddTicks(6541));

            migrationBuilder.UpdateData(
                table: "Breeds",
                keyColumn: "Id",
                keyValue: 38,
                column: "CreatedTime",
                value: new DateTime(2024, 8, 23, 15, 27, 24, 895, DateTimeKind.Local).AddTicks(6543));

            migrationBuilder.UpdateData(
                table: "Breeds",
                keyColumn: "Id",
                keyValue: 39,
                column: "CreatedTime",
                value: new DateTime(2024, 8, 23, 15, 27, 24, 895, DateTimeKind.Local).AddTicks(6544));

            migrationBuilder.UpdateData(
                table: "Breeds",
                keyColumn: "Id",
                keyValue: 40,
                column: "CreatedTime",
                value: new DateTime(2024, 8, 23, 15, 27, 24, 895, DateTimeKind.Local).AddTicks(6545));

            migrationBuilder.UpdateData(
                table: "Breeds",
                keyColumn: "Id",
                keyValue: 41,
                column: "CreatedTime",
                value: new DateTime(2024, 8, 23, 15, 27, 24, 895, DateTimeKind.Local).AddTicks(6547));

            migrationBuilder.UpdateData(
                table: "Breeds",
                keyColumn: "Id",
                keyValue: 42,
                column: "CreatedTime",
                value: new DateTime(2024, 8, 23, 15, 27, 24, 895, DateTimeKind.Local).AddTicks(6548));

            migrationBuilder.UpdateData(
                table: "Breeds",
                keyColumn: "Id",
                keyValue: 43,
                column: "CreatedTime",
                value: new DateTime(2024, 8, 23, 15, 27, 24, 895, DateTimeKind.Local).AddTicks(6549));

            migrationBuilder.UpdateData(
                table: "Breeds",
                keyColumn: "Id",
                keyValue: 44,
                column: "CreatedTime",
                value: new DateTime(2024, 8, 23, 15, 27, 24, 895, DateTimeKind.Local).AddTicks(6550));

            migrationBuilder.UpdateData(
                table: "Breeds",
                keyColumn: "Id",
                keyValue: 45,
                column: "CreatedTime",
                value: new DateTime(2024, 8, 23, 15, 27, 24, 895, DateTimeKind.Local).AddTicks(6552));

            migrationBuilder.UpdateData(
                table: "Breeds",
                keyColumn: "Id",
                keyValue: 46,
                column: "CreatedTime",
                value: new DateTime(2024, 8, 23, 15, 27, 24, 895, DateTimeKind.Local).AddTicks(6553));

            migrationBuilder.UpdateData(
                table: "Breeds",
                keyColumn: "Id",
                keyValue: 47,
                column: "CreatedTime",
                value: new DateTime(2024, 8, 23, 15, 27, 24, 895, DateTimeKind.Local).AddTicks(6554));

            migrationBuilder.UpdateData(
                table: "Breeds",
                keyColumn: "Id",
                keyValue: 48,
                column: "CreatedTime",
                value: new DateTime(2024, 8, 23, 15, 27, 24, 895, DateTimeKind.Local).AddTicks(6555));

            migrationBuilder.UpdateData(
                table: "Breeds",
                keyColumn: "Id",
                keyValue: 49,
                column: "CreatedTime",
                value: new DateTime(2024, 8, 23, 15, 27, 24, 895, DateTimeKind.Local).AddTicks(6557));

            migrationBuilder.UpdateData(
                table: "Breeds",
                keyColumn: "Id",
                keyValue: 50,
                column: "CreatedTime",
                value: new DateTime(2024, 8, 23, 15, 27, 24, 895, DateTimeKind.Local).AddTicks(6558));

            migrationBuilder.UpdateData(
                table: "Breeds",
                keyColumn: "Id",
                keyValue: 51,
                column: "CreatedTime",
                value: new DateTime(2024, 8, 23, 15, 27, 24, 895, DateTimeKind.Local).AddTicks(6559));

            migrationBuilder.UpdateData(
                table: "Breeds",
                keyColumn: "Id",
                keyValue: 52,
                column: "CreatedTime",
                value: new DateTime(2024, 8, 23, 15, 27, 24, 895, DateTimeKind.Local).AddTicks(6561));

            migrationBuilder.UpdateData(
                table: "Breeds",
                keyColumn: "Id",
                keyValue: 53,
                column: "CreatedTime",
                value: new DateTime(2024, 8, 23, 15, 27, 24, 895, DateTimeKind.Local).AddTicks(6563));

            migrationBuilder.UpdateData(
                table: "Breeds",
                keyColumn: "Id",
                keyValue: 54,
                column: "CreatedTime",
                value: new DateTime(2024, 8, 23, 15, 27, 24, 895, DateTimeKind.Local).AddTicks(6564));

            migrationBuilder.UpdateData(
                table: "Breeds",
                keyColumn: "Id",
                keyValue: 55,
                column: "CreatedTime",
                value: new DateTime(2024, 8, 23, 15, 27, 24, 895, DateTimeKind.Local).AddTicks(6565));

            migrationBuilder.UpdateData(
                table: "Breeds",
                keyColumn: "Id",
                keyValue: 56,
                column: "CreatedTime",
                value: new DateTime(2024, 8, 23, 15, 27, 24, 895, DateTimeKind.Local).AddTicks(6567));

            migrationBuilder.UpdateData(
                table: "Breeds",
                keyColumn: "Id",
                keyValue: 57,
                column: "CreatedTime",
                value: new DateTime(2024, 8, 23, 15, 27, 24, 895, DateTimeKind.Local).AddTicks(6568));

            migrationBuilder.UpdateData(
                table: "Breeds",
                keyColumn: "Id",
                keyValue: 58,
                column: "CreatedTime",
                value: new DateTime(2024, 8, 23, 15, 27, 24, 895, DateTimeKind.Local).AddTicks(6569));

            migrationBuilder.UpdateData(
                table: "Breeds",
                keyColumn: "Id",
                keyValue: 59,
                column: "CreatedTime",
                value: new DateTime(2024, 8, 23, 15, 27, 24, 895, DateTimeKind.Local).AddTicks(6570));

            migrationBuilder.UpdateData(
                table: "Breeds",
                keyColumn: "Id",
                keyValue: 60,
                column: "CreatedTime",
                value: new DateTime(2024, 8, 23, 15, 27, 24, 895, DateTimeKind.Local).AddTicks(6572));

            migrationBuilder.UpdateData(
                table: "Breeds",
                keyColumn: "Id",
                keyValue: 61,
                column: "CreatedTime",
                value: new DateTime(2024, 8, 23, 15, 27, 24, 895, DateTimeKind.Local).AddTicks(6573));

            migrationBuilder.UpdateData(
                table: "Breeds",
                keyColumn: "Id",
                keyValue: 62,
                column: "CreatedTime",
                value: new DateTime(2024, 8, 23, 15, 27, 24, 895, DateTimeKind.Local).AddTicks(6574));

            migrationBuilder.UpdateData(
                table: "Breeds",
                keyColumn: "Id",
                keyValue: 63,
                column: "CreatedTime",
                value: new DateTime(2024, 8, 23, 15, 27, 24, 895, DateTimeKind.Local).AddTicks(6575));

            migrationBuilder.UpdateData(
                table: "Breeds",
                keyColumn: "Id",
                keyValue: 64,
                column: "CreatedTime",
                value: new DateTime(2024, 8, 23, 15, 27, 24, 895, DateTimeKind.Local).AddTicks(6577));

            migrationBuilder.UpdateData(
                table: "Breeds",
                keyColumn: "Id",
                keyValue: 65,
                column: "CreatedTime",
                value: new DateTime(2024, 8, 23, 15, 27, 24, 895, DateTimeKind.Local).AddTicks(6578));

            migrationBuilder.UpdateData(
                table: "Breeds",
                keyColumn: "Id",
                keyValue: 66,
                column: "CreatedTime",
                value: new DateTime(2024, 8, 23, 15, 27, 24, 895, DateTimeKind.Local).AddTicks(6579));

            migrationBuilder.UpdateData(
                table: "Breeds",
                keyColumn: "Id",
                keyValue: 67,
                column: "CreatedTime",
                value: new DateTime(2024, 8, 23, 15, 27, 24, 895, DateTimeKind.Local).AddTicks(6580));

            migrationBuilder.UpdateData(
                table: "Breeds",
                keyColumn: "Id",
                keyValue: 68,
                column: "CreatedTime",
                value: new DateTime(2024, 8, 23, 15, 27, 24, 895, DateTimeKind.Local).AddTicks(6582));

            migrationBuilder.UpdateData(
                table: "Breeds",
                keyColumn: "Id",
                keyValue: 69,
                column: "CreatedTime",
                value: new DateTime(2024, 8, 23, 15, 27, 24, 895, DateTimeKind.Local).AddTicks(6583));

            migrationBuilder.UpdateData(
                table: "Breeds",
                keyColumn: "Id",
                keyValue: 70,
                column: "CreatedTime",
                value: new DateTime(2024, 8, 23, 15, 27, 24, 895, DateTimeKind.Local).AddTicks(6584));

            migrationBuilder.UpdateData(
                table: "Breeds",
                keyColumn: "Id",
                keyValue: 71,
                column: "CreatedTime",
                value: new DateTime(2024, 8, 23, 15, 27, 24, 895, DateTimeKind.Local).AddTicks(6585));

            migrationBuilder.UpdateData(
                table: "Breeds",
                keyColumn: "Id",
                keyValue: 72,
                column: "CreatedTime",
                value: new DateTime(2024, 8, 23, 15, 27, 24, 895, DateTimeKind.Local).AddTicks(6587));

            migrationBuilder.UpdateData(
                table: "Breeds",
                keyColumn: "Id",
                keyValue: 73,
                column: "CreatedTime",
                value: new DateTime(2024, 8, 23, 15, 27, 24, 895, DateTimeKind.Local).AddTicks(6588));

            migrationBuilder.UpdateData(
                table: "Breeds",
                keyColumn: "Id",
                keyValue: 74,
                column: "CreatedTime",
                value: new DateTime(2024, 8, 23, 15, 27, 24, 895, DateTimeKind.Local).AddTicks(6589));

            migrationBuilder.UpdateData(
                table: "Breeds",
                keyColumn: "Id",
                keyValue: 75,
                column: "CreatedTime",
                value: new DateTime(2024, 8, 23, 15, 27, 24, 895, DateTimeKind.Local).AddTicks(6590));

            migrationBuilder.UpdateData(
                table: "Breeds",
                keyColumn: "Id",
                keyValue: 76,
                column: "CreatedTime",
                value: new DateTime(2024, 8, 23, 15, 27, 24, 895, DateTimeKind.Local).AddTicks(6592));

            migrationBuilder.UpdateData(
                table: "Breeds",
                keyColumn: "Id",
                keyValue: 77,
                column: "CreatedTime",
                value: new DateTime(2024, 8, 23, 15, 27, 24, 895, DateTimeKind.Local).AddTicks(6593));

            migrationBuilder.UpdateData(
                table: "Breeds",
                keyColumn: "Id",
                keyValue: 78,
                column: "CreatedTime",
                value: new DateTime(2024, 8, 23, 15, 27, 24, 895, DateTimeKind.Local).AddTicks(6594));

            migrationBuilder.UpdateData(
                table: "Breeds",
                keyColumn: "Id",
                keyValue: 79,
                column: "CreatedTime",
                value: new DateTime(2024, 8, 23, 15, 27, 24, 895, DateTimeKind.Local).AddTicks(6596));

            migrationBuilder.UpdateData(
                table: "Breeds",
                keyColumn: "Id",
                keyValue: 80,
                column: "CreatedTime",
                value: new DateTime(2024, 8, 23, 15, 27, 24, 895, DateTimeKind.Local).AddTicks(6597));

            migrationBuilder.UpdateData(
                table: "Breeds",
                keyColumn: "Id",
                keyValue: 81,
                column: "CreatedTime",
                value: new DateTime(2024, 8, 23, 15, 27, 24, 895, DateTimeKind.Local).AddTicks(6598));

            migrationBuilder.UpdateData(
                table: "Breeds",
                keyColumn: "Id",
                keyValue: 82,
                column: "CreatedTime",
                value: new DateTime(2024, 8, 23, 15, 27, 24, 895, DateTimeKind.Local).AddTicks(6600));

            migrationBuilder.UpdateData(
                table: "Breeds",
                keyColumn: "Id",
                keyValue: 83,
                column: "CreatedTime",
                value: new DateTime(2024, 8, 23, 15, 27, 24, 895, DateTimeKind.Local).AddTicks(6602));

            migrationBuilder.UpdateData(
                table: "Breeds",
                keyColumn: "Id",
                keyValue: 84,
                column: "CreatedTime",
                value: new DateTime(2024, 8, 23, 15, 27, 24, 895, DateTimeKind.Local).AddTicks(6603));

            migrationBuilder.UpdateData(
                table: "Breeds",
                keyColumn: "Id",
                keyValue: 85,
                column: "CreatedTime",
                value: new DateTime(2024, 8, 23, 15, 27, 24, 895, DateTimeKind.Local).AddTicks(6604));

            migrationBuilder.UpdateData(
                table: "Breeds",
                keyColumn: "Id",
                keyValue: 86,
                column: "CreatedTime",
                value: new DateTime(2024, 8, 23, 15, 27, 24, 895, DateTimeKind.Local).AddTicks(6605));

            migrationBuilder.UpdateData(
                table: "Breeds",
                keyColumn: "Id",
                keyValue: 87,
                column: "CreatedTime",
                value: new DateTime(2024, 8, 23, 15, 27, 24, 895, DateTimeKind.Local).AddTicks(6607));

            migrationBuilder.UpdateData(
                table: "Breeds",
                keyColumn: "Id",
                keyValue: 88,
                column: "CreatedTime",
                value: new DateTime(2024, 8, 23, 15, 27, 24, 895, DateTimeKind.Local).AddTicks(6609));

            migrationBuilder.UpdateData(
                table: "Breeds",
                keyColumn: "Id",
                keyValue: 89,
                column: "CreatedTime",
                value: new DateTime(2024, 8, 23, 15, 27, 24, 895, DateTimeKind.Local).AddTicks(6610));

            migrationBuilder.UpdateData(
                table: "Breeds",
                keyColumn: "Id",
                keyValue: 90,
                column: "CreatedTime",
                value: new DateTime(2024, 8, 23, 15, 27, 24, 895, DateTimeKind.Local).AddTicks(6611));

            migrationBuilder.UpdateData(
                table: "Breeds",
                keyColumn: "Id",
                keyValue: 91,
                column: "CreatedTime",
                value: new DateTime(2024, 8, 23, 15, 27, 24, 895, DateTimeKind.Local).AddTicks(6642));

            migrationBuilder.UpdateData(
                table: "Breeds",
                keyColumn: "Id",
                keyValue: 92,
                column: "CreatedTime",
                value: new DateTime(2024, 8, 23, 15, 27, 24, 895, DateTimeKind.Local).AddTicks(6644));

            migrationBuilder.UpdateData(
                table: "Breeds",
                keyColumn: "Id",
                keyValue: 93,
                column: "CreatedTime",
                value: new DateTime(2024, 8, 23, 15, 27, 24, 895, DateTimeKind.Local).AddTicks(6645));

            migrationBuilder.UpdateData(
                table: "Breeds",
                keyColumn: "Id",
                keyValue: 94,
                column: "CreatedTime",
                value: new DateTime(2024, 8, 23, 15, 27, 24, 895, DateTimeKind.Local).AddTicks(6646));

            migrationBuilder.UpdateData(
                table: "Breeds",
                keyColumn: "Id",
                keyValue: 95,
                column: "CreatedTime",
                value: new DateTime(2024, 8, 23, 15, 27, 24, 895, DateTimeKind.Local).AddTicks(6648));

            migrationBuilder.UpdateData(
                table: "Breeds",
                keyColumn: "Id",
                keyValue: 96,
                column: "CreatedTime",
                value: new DateTime(2024, 8, 23, 15, 27, 24, 895, DateTimeKind.Local).AddTicks(6649));

            migrationBuilder.UpdateData(
                table: "Breeds",
                keyColumn: "Id",
                keyValue: 97,
                column: "CreatedTime",
                value: new DateTime(2024, 8, 23, 15, 27, 24, 895, DateTimeKind.Local).AddTicks(6650));

            migrationBuilder.UpdateData(
                table: "Breeds",
                keyColumn: "Id",
                keyValue: 98,
                column: "CreatedTime",
                value: new DateTime(2024, 8, 23, 15, 27, 24, 895, DateTimeKind.Local).AddTicks(6652));

            migrationBuilder.UpdateData(
                table: "Breeds",
                keyColumn: "Id",
                keyValue: 99,
                column: "CreatedTime",
                value: new DateTime(2024, 8, 23, 15, 27, 24, 895, DateTimeKind.Local).AddTicks(6653));

            migrationBuilder.UpdateData(
                table: "Breeds",
                keyColumn: "Id",
                keyValue: 100,
                column: "CreatedTime",
                value: new DateTime(2024, 8, 23, 15, 27, 24, 895, DateTimeKind.Local).AddTicks(6654));

            migrationBuilder.UpdateData(
                table: "Breeds",
                keyColumn: "Id",
                keyValue: 101,
                column: "CreatedTime",
                value: new DateTime(2024, 8, 23, 15, 27, 24, 895, DateTimeKind.Local).AddTicks(6655));

            migrationBuilder.UpdateData(
                table: "Breeds",
                keyColumn: "Id",
                keyValue: 102,
                column: "CreatedTime",
                value: new DateTime(2024, 8, 23, 15, 27, 24, 895, DateTimeKind.Local).AddTicks(6657));

            migrationBuilder.UpdateData(
                table: "Breeds",
                keyColumn: "Id",
                keyValue: 103,
                column: "CreatedTime",
                value: new DateTime(2024, 8, 23, 15, 27, 24, 895, DateTimeKind.Local).AddTicks(6658));

            migrationBuilder.UpdateData(
                table: "Breeds",
                keyColumn: "Id",
                keyValue: 104,
                column: "CreatedTime",
                value: new DateTime(2024, 8, 23, 15, 27, 24, 895, DateTimeKind.Local).AddTicks(6659));

            migrationBuilder.UpdateData(
                table: "Breeds",
                keyColumn: "Id",
                keyValue: 105,
                column: "CreatedTime",
                value: new DateTime(2024, 8, 23, 15, 27, 24, 895, DateTimeKind.Local).AddTicks(6660));

            migrationBuilder.UpdateData(
                table: "Breeds",
                keyColumn: "Id",
                keyValue: 106,
                column: "CreatedTime",
                value: new DateTime(2024, 8, 23, 15, 27, 24, 895, DateTimeKind.Local).AddTicks(6662));

            migrationBuilder.UpdateData(
                table: "Breeds",
                keyColumn: "Id",
                keyValue: 107,
                column: "CreatedTime",
                value: new DateTime(2024, 8, 23, 15, 27, 24, 895, DateTimeKind.Local).AddTicks(6663));

            migrationBuilder.UpdateData(
                table: "Breeds",
                keyColumn: "Id",
                keyValue: 108,
                column: "CreatedTime",
                value: new DateTime(2024, 8, 23, 15, 27, 24, 895, DateTimeKind.Local).AddTicks(6664));

            migrationBuilder.UpdateData(
                table: "Breeds",
                keyColumn: "Id",
                keyValue: 109,
                column: "CreatedTime",
                value: new DateTime(2024, 8, 23, 15, 27, 24, 895, DateTimeKind.Local).AddTicks(6665));

            migrationBuilder.UpdateData(
                table: "Breeds",
                keyColumn: "Id",
                keyValue: 110,
                column: "CreatedTime",
                value: new DateTime(2024, 8, 23, 15, 27, 24, 895, DateTimeKind.Local).AddTicks(6667));

            migrationBuilder.UpdateData(
                table: "Breeds",
                keyColumn: "Id",
                keyValue: 111,
                column: "CreatedTime",
                value: new DateTime(2024, 8, 23, 15, 27, 24, 895, DateTimeKind.Local).AddTicks(6669));

            migrationBuilder.UpdateData(
                table: "Breeds",
                keyColumn: "Id",
                keyValue: 112,
                column: "CreatedTime",
                value: new DateTime(2024, 8, 23, 15, 27, 24, 895, DateTimeKind.Local).AddTicks(6671));

            migrationBuilder.UpdateData(
                table: "Breeds",
                keyColumn: "Id",
                keyValue: 113,
                column: "CreatedTime",
                value: new DateTime(2024, 8, 23, 15, 27, 24, 895, DateTimeKind.Local).AddTicks(6672));

            migrationBuilder.UpdateData(
                table: "Breeds",
                keyColumn: "Id",
                keyValue: 114,
                column: "CreatedTime",
                value: new DateTime(2024, 8, 23, 15, 27, 24, 895, DateTimeKind.Local).AddTicks(6673));

            migrationBuilder.UpdateData(
                table: "Breeds",
                keyColumn: "Id",
                keyValue: 115,
                column: "CreatedTime",
                value: new DateTime(2024, 8, 23, 15, 27, 24, 895, DateTimeKind.Local).AddTicks(6674));

            migrationBuilder.UpdateData(
                table: "Breeds",
                keyColumn: "Id",
                keyValue: 116,
                column: "CreatedTime",
                value: new DateTime(2024, 8, 23, 15, 27, 24, 895, DateTimeKind.Local).AddTicks(6675));

            migrationBuilder.UpdateData(
                table: "Breeds",
                keyColumn: "Id",
                keyValue: 117,
                column: "CreatedTime",
                value: new DateTime(2024, 8, 23, 15, 27, 24, 895, DateTimeKind.Local).AddTicks(6677));

            migrationBuilder.UpdateData(
                table: "Breeds",
                keyColumn: "Id",
                keyValue: 118,
                column: "CreatedTime",
                value: new DateTime(2024, 8, 23, 15, 27, 24, 895, DateTimeKind.Local).AddTicks(6678));

            migrationBuilder.UpdateData(
                table: "Breeds",
                keyColumn: "Id",
                keyValue: 119,
                column: "CreatedTime",
                value: new DateTime(2024, 8, 23, 15, 27, 24, 895, DateTimeKind.Local).AddTicks(6679));

            migrationBuilder.UpdateData(
                table: "Breeds",
                keyColumn: "Id",
                keyValue: 120,
                column: "CreatedTime",
                value: new DateTime(2024, 8, 23, 15, 27, 24, 895, DateTimeKind.Local).AddTicks(6681));

            migrationBuilder.UpdateData(
                table: "Breeds",
                keyColumn: "Id",
                keyValue: 121,
                column: "CreatedTime",
                value: new DateTime(2024, 8, 23, 15, 27, 24, 895, DateTimeKind.Local).AddTicks(6682));

            migrationBuilder.UpdateData(
                table: "Breeds",
                keyColumn: "Id",
                keyValue: 122,
                column: "CreatedTime",
                value: new DateTime(2024, 8, 23, 15, 27, 24, 895, DateTimeKind.Local).AddTicks(6683));

            migrationBuilder.UpdateData(
                table: "Breeds",
                keyColumn: "Id",
                keyValue: 123,
                column: "CreatedTime",
                value: new DateTime(2024, 8, 23, 15, 27, 24, 895, DateTimeKind.Local).AddTicks(6684));

            migrationBuilder.UpdateData(
                table: "Breeds",
                keyColumn: "Id",
                keyValue: 124,
                column: "CreatedTime",
                value: new DateTime(2024, 8, 23, 15, 27, 24, 895, DateTimeKind.Local).AddTicks(6686));

            migrationBuilder.UpdateData(
                table: "Breeds",
                keyColumn: "Id",
                keyValue: 125,
                column: "CreatedTime",
                value: new DateTime(2024, 8, 23, 15, 27, 24, 895, DateTimeKind.Local).AddTicks(6687));

            migrationBuilder.UpdateData(
                table: "Breeds",
                keyColumn: "Id",
                keyValue: 126,
                column: "CreatedTime",
                value: new DateTime(2024, 8, 23, 15, 27, 24, 895, DateTimeKind.Local).AddTicks(6688));

            migrationBuilder.UpdateData(
                table: "Breeds",
                keyColumn: "Id",
                keyValue: 127,
                column: "CreatedTime",
                value: new DateTime(2024, 8, 23, 15, 27, 24, 895, DateTimeKind.Local).AddTicks(6689));

            migrationBuilder.UpdateData(
                table: "Breeds",
                keyColumn: "Id",
                keyValue: 128,
                column: "CreatedTime",
                value: new DateTime(2024, 8, 23, 15, 27, 24, 895, DateTimeKind.Local).AddTicks(6691));

            migrationBuilder.UpdateData(
                table: "Breeds",
                keyColumn: "Id",
                keyValue: 129,
                column: "CreatedTime",
                value: new DateTime(2024, 8, 23, 15, 27, 24, 895, DateTimeKind.Local).AddTicks(6692));

            migrationBuilder.UpdateData(
                table: "Breeds",
                keyColumn: "Id",
                keyValue: 130,
                column: "CreatedTime",
                value: new DateTime(2024, 8, 23, 15, 27, 24, 895, DateTimeKind.Local).AddTicks(6693));

            migrationBuilder.UpdateData(
                table: "Breeds",
                keyColumn: "Id",
                keyValue: 131,
                column: "CreatedTime",
                value: new DateTime(2024, 8, 23, 15, 27, 24, 895, DateTimeKind.Local).AddTicks(6695));

            migrationBuilder.UpdateData(
                table: "Breeds",
                keyColumn: "Id",
                keyValue: 132,
                column: "CreatedTime",
                value: new DateTime(2024, 8, 23, 15, 27, 24, 895, DateTimeKind.Local).AddTicks(6696));

            migrationBuilder.UpdateData(
                table: "Breeds",
                keyColumn: "Id",
                keyValue: 133,
                column: "CreatedTime",
                value: new DateTime(2024, 8, 23, 15, 27, 24, 895, DateTimeKind.Local).AddTicks(6697));

            migrationBuilder.UpdateData(
                table: "Breeds",
                keyColumn: "Id",
                keyValue: 134,
                column: "CreatedTime",
                value: new DateTime(2024, 8, 23, 15, 27, 24, 895, DateTimeKind.Local).AddTicks(6699));

            migrationBuilder.UpdateData(
                table: "Breeds",
                keyColumn: "Id",
                keyValue: 135,
                column: "CreatedTime",
                value: new DateTime(2024, 8, 23, 15, 27, 24, 895, DateTimeKind.Local).AddTicks(6700));

            migrationBuilder.UpdateData(
                table: "Breeds",
                keyColumn: "Id",
                keyValue: 136,
                column: "CreatedTime",
                value: new DateTime(2024, 8, 23, 15, 27, 24, 895, DateTimeKind.Local).AddTicks(6701));

            migrationBuilder.UpdateData(
                table: "Breeds",
                keyColumn: "Id",
                keyValue: 137,
                column: "CreatedTime",
                value: new DateTime(2024, 8, 23, 15, 27, 24, 895, DateTimeKind.Local).AddTicks(6702));

            migrationBuilder.UpdateData(
                table: "Breeds",
                keyColumn: "Id",
                keyValue: 138,
                column: "CreatedTime",
                value: new DateTime(2024, 8, 23, 15, 27, 24, 895, DateTimeKind.Local).AddTicks(6703));

            migrationBuilder.UpdateData(
                table: "Breeds",
                keyColumn: "Id",
                keyValue: 139,
                column: "CreatedTime",
                value: new DateTime(2024, 8, 23, 15, 27, 24, 895, DateTimeKind.Local).AddTicks(6705));

            migrationBuilder.UpdateData(
                table: "Breeds",
                keyColumn: "Id",
                keyValue: 140,
                column: "CreatedTime",
                value: new DateTime(2024, 8, 23, 15, 27, 24, 895, DateTimeKind.Local).AddTicks(6706));

            migrationBuilder.UpdateData(
                table: "Breeds",
                keyColumn: "Id",
                keyValue: 141,
                column: "CreatedTime",
                value: new DateTime(2024, 8, 23, 15, 27, 24, 895, DateTimeKind.Local).AddTicks(6707));

            migrationBuilder.UpdateData(
                table: "Breeds",
                keyColumn: "Id",
                keyValue: 142,
                column: "CreatedTime",
                value: new DateTime(2024, 8, 23, 15, 27, 24, 895, DateTimeKind.Local).AddTicks(6708));

            migrationBuilder.UpdateData(
                table: "Breeds",
                keyColumn: "Id",
                keyValue: 143,
                column: "CreatedTime",
                value: new DateTime(2024, 8, 23, 15, 27, 24, 895, DateTimeKind.Local).AddTicks(6710));

            migrationBuilder.UpdateData(
                table: "Breeds",
                keyColumn: "Id",
                keyValue: 144,
                column: "CreatedTime",
                value: new DateTime(2024, 8, 23, 15, 27, 24, 895, DateTimeKind.Local).AddTicks(6711));

            migrationBuilder.UpdateData(
                table: "Breeds",
                keyColumn: "Id",
                keyValue: 145,
                column: "CreatedTime",
                value: new DateTime(2024, 8, 23, 15, 27, 24, 895, DateTimeKind.Local).AddTicks(6712));

            migrationBuilder.UpdateData(
                table: "Breeds",
                keyColumn: "Id",
                keyValue: 146,
                column: "CreatedTime",
                value: new DateTime(2024, 8, 23, 15, 27, 24, 895, DateTimeKind.Local).AddTicks(6714));

            migrationBuilder.UpdateData(
                table: "Breeds",
                keyColumn: "Id",
                keyValue: 147,
                column: "CreatedTime",
                value: new DateTime(2024, 8, 23, 15, 27, 24, 895, DateTimeKind.Local).AddTicks(6715));

            migrationBuilder.UpdateData(
                table: "Breeds",
                keyColumn: "Id",
                keyValue: 148,
                column: "CreatedTime",
                value: new DateTime(2024, 8, 23, 15, 27, 24, 895, DateTimeKind.Local).AddTicks(6716));

            migrationBuilder.UpdateData(
                table: "Breeds",
                keyColumn: "Id",
                keyValue: 149,
                column: "CreatedTime",
                value: new DateTime(2024, 8, 23, 15, 27, 24, 895, DateTimeKind.Local).AddTicks(6717));

            migrationBuilder.UpdateData(
                table: "Breeds",
                keyColumn: "Id",
                keyValue: 150,
                column: "CreatedTime",
                value: new DateTime(2024, 8, 23, 15, 27, 24, 895, DateTimeKind.Local).AddTicks(6719));

            migrationBuilder.UpdateData(
                table: "Breeds",
                keyColumn: "Id",
                keyValue: 151,
                column: "CreatedTime",
                value: new DateTime(2024, 8, 23, 15, 27, 24, 895, DateTimeKind.Local).AddTicks(6720));

            migrationBuilder.UpdateData(
                table: "Breeds",
                keyColumn: "Id",
                keyValue: 152,
                column: "CreatedTime",
                value: new DateTime(2024, 8, 23, 15, 27, 24, 895, DateTimeKind.Local).AddTicks(6721));

            migrationBuilder.UpdateData(
                table: "Breeds",
                keyColumn: "Id",
                keyValue: 153,
                column: "CreatedTime",
                value: new DateTime(2024, 8, 23, 15, 27, 24, 895, DateTimeKind.Local).AddTicks(6723));

            migrationBuilder.UpdateData(
                table: "Breeds",
                keyColumn: "Id",
                keyValue: 154,
                column: "CreatedTime",
                value: new DateTime(2024, 8, 23, 15, 27, 24, 895, DateTimeKind.Local).AddTicks(6724));

            migrationBuilder.UpdateData(
                table: "Breeds",
                keyColumn: "Id",
                keyValue: 155,
                column: "CreatedTime",
                value: new DateTime(2024, 8, 23, 15, 27, 24, 895, DateTimeKind.Local).AddTicks(6725));

            migrationBuilder.UpdateData(
                table: "Breeds",
                keyColumn: "Id",
                keyValue: 156,
                column: "CreatedTime",
                value: new DateTime(2024, 8, 23, 15, 27, 24, 895, DateTimeKind.Local).AddTicks(6728));

            migrationBuilder.UpdateData(
                table: "Breeds",
                keyColumn: "Id",
                keyValue: 157,
                column: "CreatedTime",
                value: new DateTime(2024, 8, 23, 15, 27, 24, 895, DateTimeKind.Local).AddTicks(6729));

            migrationBuilder.UpdateData(
                table: "Breeds",
                keyColumn: "Id",
                keyValue: 158,
                column: "CreatedTime",
                value: new DateTime(2024, 8, 23, 15, 27, 24, 895, DateTimeKind.Local).AddTicks(6730));

            migrationBuilder.UpdateData(
                table: "Breeds",
                keyColumn: "Id",
                keyValue: 159,
                column: "CreatedTime",
                value: new DateTime(2024, 8, 23, 15, 27, 24, 895, DateTimeKind.Local).AddTicks(6731));

            migrationBuilder.UpdateData(
                table: "Breeds",
                keyColumn: "Id",
                keyValue: 160,
                column: "CreatedTime",
                value: new DateTime(2024, 8, 23, 15, 27, 24, 895, DateTimeKind.Local).AddTicks(6733));

            migrationBuilder.UpdateData(
                table: "PetTypes",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedTime",
                value: new DateTime(2024, 8, 23, 15, 27, 24, 895, DateTimeKind.Local).AddTicks(3780));

            migrationBuilder.UpdateData(
                table: "PetTypes",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreatedTime",
                value: new DateTime(2024, 8, 23, 15, 27, 24, 895, DateTimeKind.Local).AddTicks(3793));

            migrationBuilder.UpdateData(
                table: "PetTypes",
                keyColumn: "Id",
                keyValue: 3,
                column: "CreatedTime",
                value: new DateTime(2024, 8, 23, 15, 27, 24, 895, DateTimeKind.Local).AddTicks(3794));

            migrationBuilder.UpdateData(
                table: "PetTypes",
                keyColumn: "Id",
                keyValue: 4,
                column: "CreatedTime",
                value: new DateTime(2024, 8, 23, 15, 27, 24, 895, DateTimeKind.Local).AddTicks(3795));

            migrationBuilder.UpdateData(
                table: "PetTypes",
                keyColumn: "Id",
                keyValue: 5,
                column: "CreatedTime",
                value: new DateTime(2024, 8, 23, 15, 27, 24, 895, DateTimeKind.Local).AddTicks(3796));

            migrationBuilder.UpdateData(
                table: "PetTypes",
                keyColumn: "Id",
                keyValue: 6,
                column: "CreatedTime",
                value: new DateTime(2024, 8, 23, 15, 27, 24, 895, DateTimeKind.Local).AddTicks(3798));

            migrationBuilder.UpdateData(
                table: "PetTypes",
                keyColumn: "Id",
                keyValue: 7,
                column: "CreatedTime",
                value: new DateTime(2024, 8, 23, 15, 27, 24, 895, DateTimeKind.Local).AddTicks(3799));

            migrationBuilder.UpdateData(
                table: "PetTypes",
                keyColumn: "Id",
                keyValue: 8,
                column: "CreatedTime",
                value: new DateTime(2024, 8, 23, 15, 27, 24, 895, DateTimeKind.Local).AddTicks(3800));

            migrationBuilder.UpdateData(
                table: "Shelters",
                keyColumn: "Id",
                keyValue: 1021,
                columns: new[] { "CreatedTime", "LastUpdatedTime" },
                values: new object[] { new DateTime(2024, 8, 23, 11, 27, 24, 893, DateTimeKind.Utc).AddTicks(6906), new DateTime(2024, 8, 23, 11, 27, 24, 893, DateTimeKind.Utc).AddTicks(6907) });

            migrationBuilder.UpdateData(
                table: "Shelters",
                keyColumn: "Id",
                keyValue: 1022,
                columns: new[] { "CreatedTime", "LastUpdatedTime" },
                values: new object[] { new DateTime(2024, 8, 23, 11, 27, 24, 893, DateTimeKind.Utc).AddTicks(6916), new DateTime(2024, 8, 23, 11, 27, 24, 893, DateTimeKind.Utc).AddTicks(6917) });

            migrationBuilder.UpdateData(
                table: "Shelters",
                keyColumn: "Id",
                keyValue: 1023,
                columns: new[] { "CreatedTime", "LastUpdatedTime" },
                values: new object[] { new DateTime(2024, 8, 23, 11, 27, 24, 893, DateTimeKind.Utc).AddTicks(6923), new DateTime(2024, 8, 23, 11, 27, 24, 893, DateTimeKind.Utc).AddTicks(6923) });

            migrationBuilder.UpdateData(
                table: "Shelters",
                keyColumn: "Id",
                keyValue: 1024,
                columns: new[] { "CreatedTime", "LastUpdatedTime" },
                values: new object[] { new DateTime(2024, 8, 23, 11, 27, 24, 893, DateTimeKind.Utc).AddTicks(6928), new DateTime(2024, 8, 23, 11, 27, 24, 893, DateTimeKind.Utc).AddTicks(6928) });

            migrationBuilder.UpdateData(
                table: "Shelters",
                keyColumn: "Id",
                keyValue: 1025,
                columns: new[] { "CreatedTime", "LastUpdatedTime" },
                values: new object[] { new DateTime(2024, 8, 23, 11, 27, 24, 893, DateTimeKind.Utc).AddTicks(6933), new DateTime(2024, 8, 23, 11, 27, 24, 893, DateTimeKind.Utc).AddTicks(6933) });

            migrationBuilder.UpdateData(
                table: "Shelters",
                keyColumn: "Id",
                keyValue: 1026,
                columns: new[] { "CreatedTime", "LastUpdatedTime" },
                values: new object[] { new DateTime(2024, 8, 23, 11, 27, 24, 893, DateTimeKind.Utc).AddTicks(6941), new DateTime(2024, 8, 23, 11, 27, 24, 893, DateTimeKind.Utc).AddTicks(6941) });

            migrationBuilder.UpdateData(
                table: "Shelters",
                keyColumn: "Id",
                keyValue: 1027,
                columns: new[] { "CreatedTime", "LastUpdatedTime" },
                values: new object[] { new DateTime(2024, 8, 23, 11, 27, 24, 893, DateTimeKind.Utc).AddTicks(7046), new DateTime(2024, 8, 23, 11, 27, 24, 893, DateTimeKind.Utc).AddTicks(7046) });

            migrationBuilder.UpdateData(
                table: "Shelters",
                keyColumn: "Id",
                keyValue: 1028,
                columns: new[] { "CreatedTime", "LastUpdatedTime" },
                values: new object[] { new DateTime(2024, 8, 23, 11, 27, 24, 893, DateTimeKind.Utc).AddTicks(7051), new DateTime(2024, 8, 23, 11, 27, 24, 893, DateTimeKind.Utc).AddTicks(7051) });

            migrationBuilder.UpdateData(
                table: "Shelters",
                keyColumn: "Id",
                keyValue: 1029,
                columns: new[] { "CreatedTime", "LastUpdatedTime" },
                values: new object[] { new DateTime(2024, 8, 23, 11, 27, 24, 893, DateTimeKind.Utc).AddTicks(7056), new DateTime(2024, 8, 23, 11, 27, 24, 893, DateTimeKind.Utc).AddTicks(7056) });

            migrationBuilder.UpdateData(
                table: "Shelters",
                keyColumn: "Id",
                keyValue: 1030,
                columns: new[] { "CreatedTime", "LastUpdatedTime" },
                values: new object[] { new DateTime(2024, 8, 23, 11, 27, 24, 893, DateTimeKind.Utc).AddTicks(7063), new DateTime(2024, 8, 23, 11, 27, 24, 893, DateTimeKind.Utc).AddTicks(7064) });

            migrationBuilder.UpdateData(
                table: "Shelters",
                keyColumn: "Id",
                keyValue: 1031,
                columns: new[] { "CreatedTime", "LastUpdatedTime" },
                values: new object[] { new DateTime(2024, 8, 23, 11, 27, 24, 893, DateTimeKind.Utc).AddTicks(7069), new DateTime(2024, 8, 23, 11, 27, 24, 893, DateTimeKind.Utc).AddTicks(7069) });

            migrationBuilder.UpdateData(
                table: "Shelters",
                keyColumn: "Id",
                keyValue: 1032,
                columns: new[] { "CreatedTime", "LastUpdatedTime" },
                values: new object[] { new DateTime(2024, 8, 23, 11, 27, 24, 893, DateTimeKind.Utc).AddTicks(7074), new DateTime(2024, 8, 23, 11, 27, 24, 893, DateTimeKind.Utc).AddTicks(7074) });

            migrationBuilder.UpdateData(
                table: "Shelters",
                keyColumn: "Id",
                keyValue: 1033,
                columns: new[] { "CreatedTime", "LastUpdatedTime" },
                values: new object[] { new DateTime(2024, 8, 23, 11, 27, 24, 893, DateTimeKind.Utc).AddTicks(7079), new DateTime(2024, 8, 23, 11, 27, 24, 893, DateTimeKind.Utc).AddTicks(7079) });

            migrationBuilder.UpdateData(
                table: "Shelters",
                keyColumn: "Id",
                keyValue: 1034,
                columns: new[] { "CreatedTime", "LastUpdatedTime" },
                values: new object[] { new DateTime(2024, 8, 23, 11, 27, 24, 893, DateTimeKind.Utc).AddTicks(7084), new DateTime(2024, 8, 23, 11, 27, 24, 893, DateTimeKind.Utc).AddTicks(7084) });

            migrationBuilder.UpdateData(
                table: "Shelters",
                keyColumn: "Id",
                keyValue: 1035,
                columns: new[] { "CreatedTime", "LastUpdatedTime" },
                values: new object[] { new DateTime(2024, 8, 23, 11, 27, 24, 893, DateTimeKind.Utc).AddTicks(7089), new DateTime(2024, 8, 23, 11, 27, 24, 893, DateTimeKind.Utc).AddTicks(7089) });

            migrationBuilder.UpdateData(
                table: "Shelters",
                keyColumn: "Id",
                keyValue: 1036,
                columns: new[] { "CreatedTime", "LastUpdatedTime" },
                values: new object[] { new DateTime(2024, 8, 23, 11, 27, 24, 893, DateTimeKind.Utc).AddTicks(7094), new DateTime(2024, 8, 23, 11, 27, 24, 893, DateTimeKind.Utc).AddTicks(7094) });

            migrationBuilder.UpdateData(
                table: "Shelters",
                keyColumn: "Id",
                keyValue: 1037,
                columns: new[] { "CreatedTime", "LastUpdatedTime" },
                values: new object[] { new DateTime(2024, 8, 23, 11, 27, 24, 893, DateTimeKind.Utc).AddTicks(7099), new DateTime(2024, 8, 23, 11, 27, 24, 893, DateTimeKind.Utc).AddTicks(7100) });

            migrationBuilder.UpdateData(
                table: "Shelters",
                keyColumn: "Id",
                keyValue: 1038,
                columns: new[] { "CreatedTime", "LastUpdatedTime" },
                values: new object[] { new DateTime(2024, 8, 23, 11, 27, 24, 893, DateTimeKind.Utc).AddTicks(7106), new DateTime(2024, 8, 23, 11, 27, 24, 893, DateTimeKind.Utc).AddTicks(7106) });

            migrationBuilder.UpdateData(
                table: "Shelters",
                keyColumn: "Id",
                keyValue: 1039,
                columns: new[] { "CreatedTime", "LastUpdatedTime" },
                values: new object[] { new DateTime(2024, 8, 23, 11, 27, 24, 893, DateTimeKind.Utc).AddTicks(7111), new DateTime(2024, 8, 23, 11, 27, 24, 893, DateTimeKind.Utc).AddTicks(7111) });

            migrationBuilder.UpdateData(
                table: "Shelters",
                keyColumn: "Id",
                keyValue: 1040,
                columns: new[] { "CreatedTime", "LastUpdatedTime" },
                values: new object[] { new DateTime(2024, 8, 23, 11, 27, 24, 893, DateTimeKind.Utc).AddTicks(7116), new DateTime(2024, 8, 23, 11, 27, 24, 893, DateTimeKind.Utc).AddTicks(7116) });
        }
    }
}
