using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Persistance.Migrations
{
    /// <inheritdoc />
    public partial class mig_3 : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<bool>(
                name: "isAccepted",
                table: "Adoptions",
                type: "bit",
                nullable: false,
                defaultValue: false);

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: 2001,
                columns: new[] { "ConcurrencyStamp", "CreatedTime", "LastUpdatedTime", "RefreshTokenCreateTime" },
                values: new object[] { "0e135c56-d34d-49a9-9e60-7b9e69b98e5b", new DateTime(2024, 9, 5, 7, 43, 57, 951, DateTimeKind.Utc).AddTicks(2330), new DateTime(2024, 9, 5, 7, 43, 57, 951, DateTimeKind.Utc).AddTicks(2330), new DateTime(2024, 9, 5, 7, 43, 57, 951, DateTimeKind.Utc).AddTicks(2260) });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: 2002,
                columns: new[] { "ConcurrencyStamp", "CreatedTime", "LastUpdatedTime", "RefreshTokenCreateTime" },
                values: new object[] { "fe8266cf-fef9-4494-879a-218846ff89f2", new DateTime(2024, 9, 5, 7, 43, 57, 951, DateTimeKind.Utc).AddTicks(2370), new DateTime(2024, 9, 5, 7, 43, 57, 951, DateTimeKind.Utc).AddTicks(2370), new DateTime(2024, 9, 5, 7, 43, 57, 951, DateTimeKind.Utc).AddTicks(2370) });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: 2003,
                columns: new[] { "ConcurrencyStamp", "CreatedTime", "LastUpdatedTime", "RefreshTokenCreateTime" },
                values: new object[] { "800d365e-34b1-44bc-b1f6-c6cbfffbec08", new DateTime(2024, 9, 5, 7, 43, 57, 951, DateTimeKind.Utc).AddTicks(2380), new DateTime(2024, 9, 5, 7, 43, 57, 951, DateTimeKind.Utc).AddTicks(2380), new DateTime(2024, 9, 5, 7, 43, 57, 951, DateTimeKind.Utc).AddTicks(2380) });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: 2004,
                columns: new[] { "ConcurrencyStamp", "CreatedTime", "LastUpdatedTime", "RefreshTokenCreateTime" },
                values: new object[] { "b0c26db9-9f5e-4f40-89e9-429150145bbe", new DateTime(2024, 9, 5, 7, 43, 57, 951, DateTimeKind.Utc).AddTicks(2390), new DateTime(2024, 9, 5, 7, 43, 57, 951, DateTimeKind.Utc).AddTicks(2390), new DateTime(2024, 9, 5, 7, 43, 57, 951, DateTimeKind.Utc).AddTicks(2390) });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: 2005,
                columns: new[] { "ConcurrencyStamp", "CreatedTime", "LastUpdatedTime", "RefreshTokenCreateTime" },
                values: new object[] { "2b74f526-9c2b-487c-80bd-3d3982badc59", new DateTime(2024, 9, 5, 7, 43, 57, 951, DateTimeKind.Utc).AddTicks(2400), new DateTime(2024, 9, 5, 7, 43, 57, 951, DateTimeKind.Utc).AddTicks(2400), new DateTime(2024, 9, 5, 7, 43, 57, 951, DateTimeKind.Utc).AddTicks(2400) });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: 2006,
                columns: new[] { "ConcurrencyStamp", "CreatedTime", "LastUpdatedTime", "RefreshTokenCreateTime" },
                values: new object[] { "4d90259a-d07b-406c-96a3-a16a90eae723", new DateTime(2024, 9, 5, 7, 43, 57, 951, DateTimeKind.Utc).AddTicks(2410), new DateTime(2024, 9, 5, 7, 43, 57, 951, DateTimeKind.Utc).AddTicks(2410), new DateTime(2024, 9, 5, 7, 43, 57, 951, DateTimeKind.Utc).AddTicks(2410) });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: 2007,
                columns: new[] { "ConcurrencyStamp", "CreatedTime", "LastUpdatedTime", "RefreshTokenCreateTime" },
                values: new object[] { "248cf91f-64a5-46c7-9ca6-b8c6aef3d2c5", new DateTime(2024, 9, 5, 7, 43, 57, 951, DateTimeKind.Utc).AddTicks(2420), new DateTime(2024, 9, 5, 7, 43, 57, 951, DateTimeKind.Utc).AddTicks(2420), new DateTime(2024, 9, 5, 7, 43, 57, 951, DateTimeKind.Utc).AddTicks(2410) });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: 2008,
                columns: new[] { "ConcurrencyStamp", "CreatedTime", "LastUpdatedTime", "RefreshTokenCreateTime" },
                values: new object[] { "535bf7c9-494c-44df-8e39-82d58db5c64c", new DateTime(2024, 9, 5, 7, 43, 57, 951, DateTimeKind.Utc).AddTicks(2430), new DateTime(2024, 9, 5, 7, 43, 57, 951, DateTimeKind.Utc).AddTicks(2430), new DateTime(2024, 9, 5, 7, 43, 57, 951, DateTimeKind.Utc).AddTicks(2420) });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: 2009,
                columns: new[] { "ConcurrencyStamp", "CreatedTime", "LastUpdatedTime", "RefreshTokenCreateTime" },
                values: new object[] { "88f1cb90-a9b7-4108-9171-bcc7a00b6f79", new DateTime(2024, 9, 5, 7, 43, 57, 951, DateTimeKind.Utc).AddTicks(2430), new DateTime(2024, 9, 5, 7, 43, 57, 951, DateTimeKind.Utc).AddTicks(2430), new DateTime(2024, 9, 5, 7, 43, 57, 951, DateTimeKind.Utc).AddTicks(2430) });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: 2010,
                columns: new[] { "ConcurrencyStamp", "CreatedTime", "LastUpdatedTime", "RefreshTokenCreateTime" },
                values: new object[] { "7b9078b1-f4a3-43d8-87fb-b05b7e15962e", new DateTime(2024, 9, 5, 7, 43, 57, 951, DateTimeKind.Utc).AddTicks(2440), new DateTime(2024, 9, 5, 7, 43, 57, 951, DateTimeKind.Utc).AddTicks(2440), new DateTime(2024, 9, 5, 7, 43, 57, 951, DateTimeKind.Utc).AddTicks(2440) });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: 2011,
                columns: new[] { "ConcurrencyStamp", "CreatedTime", "LastUpdatedTime", "RefreshTokenCreateTime" },
                values: new object[] { "2053ebc8-398e-4e1f-a95c-e45ecc1f7334", new DateTime(2024, 9, 5, 7, 43, 57, 951, DateTimeKind.Utc).AddTicks(2450), new DateTime(2024, 9, 5, 7, 43, 57, 951, DateTimeKind.Utc).AddTicks(2450), new DateTime(2024, 9, 5, 7, 43, 57, 951, DateTimeKind.Utc).AddTicks(2450) });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: 2012,
                columns: new[] { "ConcurrencyStamp", "CreatedTime", "LastUpdatedTime", "RefreshTokenCreateTime" },
                values: new object[] { "f769b5fd-0db5-4306-9a08-7bad564d06ab", new DateTime(2024, 9, 5, 7, 43, 57, 951, DateTimeKind.Utc).AddTicks(2480), new DateTime(2024, 9, 5, 7, 43, 57, 951, DateTimeKind.Utc).AddTicks(2480), new DateTime(2024, 9, 5, 7, 43, 57, 951, DateTimeKind.Utc).AddTicks(2470) });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: 2013,
                columns: new[] { "ConcurrencyStamp", "CreatedTime", "LastUpdatedTime", "RefreshTokenCreateTime" },
                values: new object[] { "4a13e3a0-8a2c-4b6b-ae9e-f72f5c2d2d17", new DateTime(2024, 9, 5, 7, 43, 57, 951, DateTimeKind.Utc).AddTicks(2490), new DateTime(2024, 9, 5, 7, 43, 57, 951, DateTimeKind.Utc).AddTicks(2490), new DateTime(2024, 9, 5, 7, 43, 57, 951, DateTimeKind.Utc).AddTicks(2480) });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: 2014,
                columns: new[] { "ConcurrencyStamp", "CreatedTime", "LastUpdatedTime", "RefreshTokenCreateTime" },
                values: new object[] { "ce61be8a-4567-40d4-8d74-da63420ae938", new DateTime(2024, 9, 5, 7, 43, 57, 951, DateTimeKind.Utc).AddTicks(2500), new DateTime(2024, 9, 5, 7, 43, 57, 951, DateTimeKind.Utc).AddTicks(2500), new DateTime(2024, 9, 5, 7, 43, 57, 951, DateTimeKind.Utc).AddTicks(2490) });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: 2015,
                columns: new[] { "ConcurrencyStamp", "CreatedTime", "LastUpdatedTime", "RefreshTokenCreateTime" },
                values: new object[] { "91d9c78c-a021-4064-981f-d1a6f810971c", new DateTime(2024, 9, 5, 7, 43, 57, 951, DateTimeKind.Utc).AddTicks(2500), new DateTime(2024, 9, 5, 7, 43, 57, 951, DateTimeKind.Utc).AddTicks(2510), new DateTime(2024, 9, 5, 7, 43, 57, 951, DateTimeKind.Utc).AddTicks(2500) });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: 2016,
                columns: new[] { "ConcurrencyStamp", "CreatedTime", "LastUpdatedTime", "RefreshTokenCreateTime" },
                values: new object[] { "deabbaeb-9cc6-4651-876b-5a43e263d291", new DateTime(2024, 9, 5, 7, 43, 57, 951, DateTimeKind.Utc).AddTicks(2510), new DateTime(2024, 9, 5, 7, 43, 57, 951, DateTimeKind.Utc).AddTicks(2510), new DateTime(2024, 9, 5, 7, 43, 57, 951, DateTimeKind.Utc).AddTicks(2510) });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: 2017,
                columns: new[] { "ConcurrencyStamp", "CreatedTime", "LastUpdatedTime", "RefreshTokenCreateTime" },
                values: new object[] { "d4e9a954-1c9f-4b81-be68-8a0181f4089c", new DateTime(2024, 9, 5, 7, 43, 57, 951, DateTimeKind.Utc).AddTicks(2520), new DateTime(2024, 9, 5, 7, 43, 57, 951, DateTimeKind.Utc).AddTicks(2520), new DateTime(2024, 9, 5, 7, 43, 57, 951, DateTimeKind.Utc).AddTicks(2520) });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: 2018,
                columns: new[] { "ConcurrencyStamp", "CreatedTime", "LastUpdatedTime", "RefreshTokenCreateTime" },
                values: new object[] { "7b1b9f08-ddb3-45b5-bc38-2ea323e7ef40", new DateTime(2024, 9, 5, 7, 43, 57, 951, DateTimeKind.Utc).AddTicks(2530), new DateTime(2024, 9, 5, 7, 43, 57, 951, DateTimeKind.Utc).AddTicks(2530), new DateTime(2024, 9, 5, 7, 43, 57, 951, DateTimeKind.Utc).AddTicks(2530) });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: 2019,
                columns: new[] { "ConcurrencyStamp", "CreatedTime", "LastUpdatedTime", "RefreshTokenCreateTime" },
                values: new object[] { "fe0fafae-40bc-4002-a8ac-ffce9b194a64", new DateTime(2024, 9, 5, 7, 43, 57, 951, DateTimeKind.Utc).AddTicks(2540), new DateTime(2024, 9, 5, 7, 43, 57, 951, DateTimeKind.Utc).AddTicks(2540), new DateTime(2024, 9, 5, 7, 43, 57, 951, DateTimeKind.Utc).AddTicks(2540) });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: 2020,
                columns: new[] { "ConcurrencyStamp", "CreatedTime", "LastUpdatedTime", "RefreshTokenCreateTime" },
                values: new object[] { "931408a4-f2ca-4a43-918a-c1834eaded7d", new DateTime(2024, 9, 5, 7, 43, 57, 951, DateTimeKind.Utc).AddTicks(2550), new DateTime(2024, 9, 5, 7, 43, 57, 951, DateTimeKind.Utc).AddTicks(2550), new DateTime(2024, 9, 5, 7, 43, 57, 951, DateTimeKind.Utc).AddTicks(2550) });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: 2021,
                columns: new[] { "ConcurrencyStamp", "CreatedTime", "LastUpdatedTime", "RefreshTokenCreateTime" },
                values: new object[] { "65f5aa7d-bcf0-4da1-9882-9467f1605940", new DateTime(2024, 9, 5, 7, 43, 57, 951, DateTimeKind.Utc).AddTicks(2560), new DateTime(2024, 9, 5, 7, 43, 57, 951, DateTimeKind.Utc).AddTicks(2560), new DateTime(2024, 9, 5, 7, 43, 57, 951, DateTimeKind.Utc).AddTicks(2560) });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: 2022,
                columns: new[] { "ConcurrencyStamp", "CreatedTime", "LastUpdatedTime", "RefreshTokenCreateTime" },
                values: new object[] { "8472b688-25b1-4be1-9577-bc93b501e8a0", new DateTime(2024, 9, 5, 7, 43, 57, 951, DateTimeKind.Utc).AddTicks(2580), new DateTime(2024, 9, 5, 7, 43, 57, 951, DateTimeKind.Utc).AddTicks(2580), new DateTime(2024, 9, 5, 7, 43, 57, 951, DateTimeKind.Utc).AddTicks(2570) });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: 2023,
                columns: new[] { "ConcurrencyStamp", "CreatedTime", "LastUpdatedTime", "RefreshTokenCreateTime" },
                values: new object[] { "32092b65-61a9-4aa6-a0a2-bdfdb0c22f0f", new DateTime(2024, 9, 5, 7, 43, 57, 951, DateTimeKind.Utc).AddTicks(2590), new DateTime(2024, 9, 5, 7, 43, 57, 951, DateTimeKind.Utc).AddTicks(2590), new DateTime(2024, 9, 5, 7, 43, 57, 951, DateTimeKind.Utc).AddTicks(2580) });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: 2024,
                columns: new[] { "ConcurrencyStamp", "CreatedTime", "LastUpdatedTime", "RefreshTokenCreateTime" },
                values: new object[] { "314c77af-ee7c-4f3f-8a7b-8b3e752dd52c", new DateTime(2024, 9, 5, 7, 43, 57, 951, DateTimeKind.Utc).AddTicks(2600), new DateTime(2024, 9, 5, 7, 43, 57, 951, DateTimeKind.Utc).AddTicks(2600), new DateTime(2024, 9, 5, 7, 43, 57, 951, DateTimeKind.Utc).AddTicks(2590) });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: 2025,
                columns: new[] { "ConcurrencyStamp", "CreatedTime", "LastUpdatedTime", "RefreshTokenCreateTime" },
                values: new object[] { "2ca41097-18ff-4952-a9a8-a9ae28861473", new DateTime(2024, 9, 5, 7, 43, 57, 951, DateTimeKind.Utc).AddTicks(2610), new DateTime(2024, 9, 5, 7, 43, 57, 951, DateTimeKind.Utc).AddTicks(2610), new DateTime(2024, 9, 5, 7, 43, 57, 951, DateTimeKind.Utc).AddTicks(2600) });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: 2026,
                columns: new[] { "ConcurrencyStamp", "CreatedTime", "LastUpdatedTime", "RefreshTokenCreateTime" },
                values: new object[] { "879e1e35-6ff7-4fb5-ba0c-1f2e49571fb2", new DateTime(2024, 9, 5, 7, 43, 57, 951, DateTimeKind.Utc).AddTicks(2610), new DateTime(2024, 9, 5, 7, 43, 57, 951, DateTimeKind.Utc).AddTicks(2610), new DateTime(2024, 9, 5, 7, 43, 57, 951, DateTimeKind.Utc).AddTicks(2610) });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: 2027,
                columns: new[] { "ConcurrencyStamp", "CreatedTime", "LastUpdatedTime", "RefreshTokenCreateTime" },
                values: new object[] { "c4c1e78a-8e38-48fc-80f3-733d270bc15e", new DateTime(2024, 9, 5, 7, 43, 57, 951, DateTimeKind.Utc).AddTicks(2620), new DateTime(2024, 9, 5, 7, 43, 57, 951, DateTimeKind.Utc).AddTicks(2620), new DateTime(2024, 9, 5, 7, 43, 57, 951, DateTimeKind.Utc).AddTicks(2620) });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: 2028,
                columns: new[] { "ConcurrencyStamp", "CreatedTime", "LastUpdatedTime", "RefreshTokenCreateTime" },
                values: new object[] { "2f5e5a74-f3f9-4aa9-b02f-243fc284de97", new DateTime(2024, 9, 5, 7, 43, 57, 951, DateTimeKind.Utc).AddTicks(2630), new DateTime(2024, 9, 5, 7, 43, 57, 951, DateTimeKind.Utc).AddTicks(2630), new DateTime(2024, 9, 5, 7, 43, 57, 951, DateTimeKind.Utc).AddTicks(2630) });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: 2029,
                columns: new[] { "ConcurrencyStamp", "CreatedTime", "LastUpdatedTime", "RefreshTokenCreateTime" },
                values: new object[] { "79c9b6a3-7fc3-46ee-843e-fd4bdeede22b", new DateTime(2024, 9, 5, 7, 43, 57, 951, DateTimeKind.Utc).AddTicks(2640), new DateTime(2024, 9, 5, 7, 43, 57, 951, DateTimeKind.Utc).AddTicks(2640), new DateTime(2024, 9, 5, 7, 43, 57, 951, DateTimeKind.Utc).AddTicks(2640) });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: 2030,
                columns: new[] { "ConcurrencyStamp", "CreatedTime", "LastUpdatedTime", "RefreshTokenCreateTime" },
                values: new object[] { "43998175-b8d8-4155-bc4c-51c0b816c575", new DateTime(2024, 9, 5, 7, 43, 57, 951, DateTimeKind.Utc).AddTicks(2660), new DateTime(2024, 9, 5, 7, 43, 57, 951, DateTimeKind.Utc).AddTicks(2660), new DateTime(2024, 9, 5, 7, 43, 57, 951, DateTimeKind.Utc).AddTicks(2650) });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: 2031,
                columns: new[] { "ConcurrencyStamp", "CreatedTime", "LastUpdatedTime", "RefreshTokenCreateTime" },
                values: new object[] { "b86ac9f4-227f-425e-bdcf-519eadce55fc", new DateTime(2024, 9, 5, 7, 43, 57, 951, DateTimeKind.Utc).AddTicks(2670), new DateTime(2024, 9, 5, 7, 43, 57, 951, DateTimeKind.Utc).AddTicks(2670), new DateTime(2024, 9, 5, 7, 43, 57, 951, DateTimeKind.Utc).AddTicks(2670) });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: 2032,
                columns: new[] { "ConcurrencyStamp", "CreatedTime", "LastUpdatedTime", "RefreshTokenCreateTime" },
                values: new object[] { "d11f0357-7bae-4204-b8e8-d4d7fa4e1df5", new DateTime(2024, 9, 5, 7, 43, 57, 951, DateTimeKind.Utc).AddTicks(2680), new DateTime(2024, 9, 5, 7, 43, 57, 951, DateTimeKind.Utc).AddTicks(2680), new DateTime(2024, 9, 5, 7, 43, 57, 951, DateTimeKind.Utc).AddTicks(2680) });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: 2033,
                columns: new[] { "ConcurrencyStamp", "CreatedTime", "LastUpdatedTime", "RefreshTokenCreateTime" },
                values: new object[] { "50778f9f-4cf8-4042-b1e5-e68610cc2d21", new DateTime(2024, 9, 5, 7, 43, 57, 951, DateTimeKind.Utc).AddTicks(2690), new DateTime(2024, 9, 5, 7, 43, 57, 951, DateTimeKind.Utc).AddTicks(2690), new DateTime(2024, 9, 5, 7, 43, 57, 951, DateTimeKind.Utc).AddTicks(2690) });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: 2034,
                columns: new[] { "ConcurrencyStamp", "CreatedTime", "LastUpdatedTime", "RefreshTokenCreateTime" },
                values: new object[] { "663c2ed8-5a26-4471-877e-6142841ab5ca", new DateTime(2024, 9, 5, 7, 43, 57, 951, DateTimeKind.Utc).AddTicks(2700), new DateTime(2024, 9, 5, 7, 43, 57, 951, DateTimeKind.Utc).AddTicks(2700), new DateTime(2024, 9, 5, 7, 43, 57, 951, DateTimeKind.Utc).AddTicks(2700) });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: 2035,
                columns: new[] { "ConcurrencyStamp", "CreatedTime", "LastUpdatedTime", "RefreshTokenCreateTime" },
                values: new object[] { "9c2e0e2b-d1ee-454d-b581-61f97bb42225", new DateTime(2024, 9, 5, 7, 43, 57, 951, DateTimeKind.Utc).AddTicks(2710), new DateTime(2024, 9, 5, 7, 43, 57, 951, DateTimeKind.Utc).AddTicks(2710), new DateTime(2024, 9, 5, 7, 43, 57, 951, DateTimeKind.Utc).AddTicks(2710) });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: 2036,
                columns: new[] { "ConcurrencyStamp", "CreatedTime", "LastUpdatedTime", "RefreshTokenCreateTime" },
                values: new object[] { "66533be1-0438-49e7-8f28-12929a3ea1a0", new DateTime(2024, 9, 5, 7, 43, 57, 951, DateTimeKind.Utc).AddTicks(2720), new DateTime(2024, 9, 5, 7, 43, 57, 951, DateTimeKind.Utc).AddTicks(2720), new DateTime(2024, 9, 5, 7, 43, 57, 951, DateTimeKind.Utc).AddTicks(2720) });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: 2037,
                columns: new[] { "ConcurrencyStamp", "CreatedTime", "LastUpdatedTime", "RefreshTokenCreateTime" },
                values: new object[] { "66e36970-4446-4377-b7da-9a04c49fb45c", new DateTime(2024, 9, 5, 7, 43, 57, 951, DateTimeKind.Utc).AddTicks(2730), new DateTime(2024, 9, 5, 7, 43, 57, 951, DateTimeKind.Utc).AddTicks(2730), new DateTime(2024, 9, 5, 7, 43, 57, 951, DateTimeKind.Utc).AddTicks(2730) });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: 2038,
                columns: new[] { "ConcurrencyStamp", "CreatedTime", "LastUpdatedTime", "RefreshTokenCreateTime" },
                values: new object[] { "7d775f79-4e99-4355-aeee-19b628b6601e", new DateTime(2024, 9, 5, 7, 43, 57, 951, DateTimeKind.Utc).AddTicks(2740), new DateTime(2024, 9, 5, 7, 43, 57, 951, DateTimeKind.Utc).AddTicks(2740), new DateTime(2024, 9, 5, 7, 43, 57, 951, DateTimeKind.Utc).AddTicks(2740) });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: 2039,
                columns: new[] { "ConcurrencyStamp", "CreatedTime", "LastUpdatedTime", "RefreshTokenCreateTime" },
                values: new object[] { "53858534-d28e-40b4-8171-7943ab67eb57", new DateTime(2024, 9, 5, 7, 43, 57, 951, DateTimeKind.Utc).AddTicks(2750), new DateTime(2024, 9, 5, 7, 43, 57, 951, DateTimeKind.Utc).AddTicks(2750), new DateTime(2024, 9, 5, 7, 43, 57, 951, DateTimeKind.Utc).AddTicks(2750) });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: 2040,
                columns: new[] { "ConcurrencyStamp", "CreatedTime", "LastUpdatedTime", "RefreshTokenCreateTime" },
                values: new object[] { "bb54ff90-5af4-4883-91e8-b8e457df0c5d", new DateTime(2024, 9, 5, 7, 43, 57, 951, DateTimeKind.Utc).AddTicks(2760), new DateTime(2024, 9, 5, 7, 43, 57, 951, DateTimeKind.Utc).AddTicks(2760), new DateTime(2024, 9, 5, 7, 43, 57, 951, DateTimeKind.Utc).AddTicks(2760) });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: 2041,
                columns: new[] { "ConcurrencyStamp", "CreatedTime", "LastUpdatedTime", "RefreshTokenCreateTime" },
                values: new object[] { "95f7335c-e42c-4714-a669-c80b045840e6", new DateTime(2024, 9, 5, 7, 43, 57, 951, DateTimeKind.Utc).AddTicks(2770), new DateTime(2024, 9, 5, 7, 43, 57, 951, DateTimeKind.Utc).AddTicks(2770), new DateTime(2024, 9, 5, 7, 43, 57, 951, DateTimeKind.Utc).AddTicks(2770) });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: 2042,
                columns: new[] { "ConcurrencyStamp", "CreatedTime", "LastUpdatedTime", "RefreshTokenCreateTime" },
                values: new object[] { "4095c48a-6f97-4d23-9e80-df943f2e440a", new DateTime(2024, 9, 5, 7, 43, 57, 951, DateTimeKind.Utc).AddTicks(2780), new DateTime(2024, 9, 5, 7, 43, 57, 951, DateTimeKind.Utc).AddTicks(2780), new DateTime(2024, 9, 5, 7, 43, 57, 951, DateTimeKind.Utc).AddTicks(2780) });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: 2043,
                columns: new[] { "ConcurrencyStamp", "CreatedTime", "LastUpdatedTime", "RefreshTokenCreateTime" },
                values: new object[] { "5d606e6b-b7cd-44e5-bd5b-8899838eb9a3", new DateTime(2024, 9, 5, 7, 43, 57, 951, DateTimeKind.Utc).AddTicks(2790), new DateTime(2024, 9, 5, 7, 43, 57, 951, DateTimeKind.Utc).AddTicks(2790), new DateTime(2024, 9, 5, 7, 43, 57, 951, DateTimeKind.Utc).AddTicks(2790) });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: 2044,
                columns: new[] { "ConcurrencyStamp", "CreatedTime", "LastUpdatedTime", "RefreshTokenCreateTime" },
                values: new object[] { "b8329c8a-00cb-4fd1-a744-b663717dc302", new DateTime(2024, 9, 5, 7, 43, 57, 951, DateTimeKind.Utc).AddTicks(2800), new DateTime(2024, 9, 5, 7, 43, 57, 951, DateTimeKind.Utc).AddTicks(2800), new DateTime(2024, 9, 5, 7, 43, 57, 951, DateTimeKind.Utc).AddTicks(2800) });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: 2045,
                columns: new[] { "ConcurrencyStamp", "CreatedTime", "LastUpdatedTime", "RefreshTokenCreateTime" },
                values: new object[] { "cd2920c8-e9df-4cd8-a286-fcf643095537", new DateTime(2024, 9, 5, 7, 43, 57, 951, DateTimeKind.Utc).AddTicks(2810), new DateTime(2024, 9, 5, 7, 43, 57, 951, DateTimeKind.Utc).AddTicks(2810), new DateTime(2024, 9, 5, 7, 43, 57, 951, DateTimeKind.Utc).AddTicks(2810) });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: 2046,
                columns: new[] { "ConcurrencyStamp", "CreatedTime", "LastUpdatedTime", "RefreshTokenCreateTime" },
                values: new object[] { "1fe15cb7-9a7d-4e88-938d-e1c8c3683e4f", new DateTime(2024, 9, 5, 7, 43, 57, 951, DateTimeKind.Utc).AddTicks(2820), new DateTime(2024, 9, 5, 7, 43, 57, 951, DateTimeKind.Utc).AddTicks(2820), new DateTime(2024, 9, 5, 7, 43, 57, 951, DateTimeKind.Utc).AddTicks(2820) });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: 2047,
                columns: new[] { "ConcurrencyStamp", "CreatedTime", "LastUpdatedTime", "RefreshTokenCreateTime" },
                values: new object[] { "58913be9-7e74-49a9-9a07-25c79b0ca582", new DateTime(2024, 9, 5, 7, 43, 57, 951, DateTimeKind.Utc).AddTicks(2830), new DateTime(2024, 9, 5, 7, 43, 57, 951, DateTimeKind.Utc).AddTicks(2830), new DateTime(2024, 9, 5, 7, 43, 57, 951, DateTimeKind.Utc).AddTicks(2820) });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: 2048,
                columns: new[] { "ConcurrencyStamp", "CreatedTime", "LastUpdatedTime", "RefreshTokenCreateTime" },
                values: new object[] { "29a5f06a-a22f-49f5-90e3-9a0a6a44cff3", new DateTime(2024, 9, 5, 7, 43, 57, 951, DateTimeKind.Utc).AddTicks(2840), new DateTime(2024, 9, 5, 7, 43, 57, 951, DateTimeKind.Utc).AddTicks(2840), new DateTime(2024, 9, 5, 7, 43, 57, 951, DateTimeKind.Utc).AddTicks(2830) });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: 2049,
                columns: new[] { "ConcurrencyStamp", "CreatedTime", "LastUpdatedTime", "RefreshTokenCreateTime" },
                values: new object[] { "17a2ed6a-6c4e-4af1-b751-6f3e224e96c2", new DateTime(2024, 9, 5, 7, 43, 57, 951, DateTimeKind.Utc).AddTicks(2860), new DateTime(2024, 9, 5, 7, 43, 57, 951, DateTimeKind.Utc).AddTicks(2860), new DateTime(2024, 9, 5, 7, 43, 57, 951, DateTimeKind.Utc).AddTicks(2850) });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: 2050,
                columns: new[] { "ConcurrencyStamp", "CreatedTime", "LastUpdatedTime", "RefreshTokenCreateTime" },
                values: new object[] { "a2331602-b371-451c-9632-c40477b4ddc8", new DateTime(2024, 9, 5, 7, 43, 57, 951, DateTimeKind.Utc).AddTicks(2870), new DateTime(2024, 9, 5, 7, 43, 57, 951, DateTimeKind.Utc).AddTicks(2870), new DateTime(2024, 9, 5, 7, 43, 57, 951, DateTimeKind.Utc).AddTicks(2860) });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: 2051,
                columns: new[] { "ConcurrencyStamp", "CreatedTime", "LastUpdatedTime", "RefreshTokenCreateTime" },
                values: new object[] { "0686f11d-e872-47ad-a389-2ebc8983132b", new DateTime(2024, 9, 5, 7, 43, 57, 951, DateTimeKind.Utc).AddTicks(2880), new DateTime(2024, 9, 5, 7, 43, 57, 951, DateTimeKind.Utc).AddTicks(2880), new DateTime(2024, 9, 5, 7, 43, 57, 951, DateTimeKind.Utc).AddTicks(2870) });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: 2052,
                columns: new[] { "ConcurrencyStamp", "CreatedTime", "LastUpdatedTime", "RefreshTokenCreateTime" },
                values: new object[] { "806b8884-e846-4d29-a317-3786bbb7633a", new DateTime(2024, 9, 5, 7, 43, 57, 951, DateTimeKind.Utc).AddTicks(2880), new DateTime(2024, 9, 5, 7, 43, 57, 951, DateTimeKind.Utc).AddTicks(2880), new DateTime(2024, 9, 5, 7, 43, 57, 951, DateTimeKind.Utc).AddTicks(2880) });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: 2053,
                columns: new[] { "ConcurrencyStamp", "CreatedTime", "LastUpdatedTime", "RefreshTokenCreateTime" },
                values: new object[] { "a43b4853-93f8-4f1c-9f54-a666e8a9a06c", new DateTime(2024, 9, 5, 7, 43, 57, 951, DateTimeKind.Utc).AddTicks(2890), new DateTime(2024, 9, 5, 7, 43, 57, 951, DateTimeKind.Utc).AddTicks(2890), new DateTime(2024, 9, 5, 7, 43, 57, 951, DateTimeKind.Utc).AddTicks(2890) });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: 2054,
                columns: new[] { "ConcurrencyStamp", "CreatedTime", "LastUpdatedTime", "RefreshTokenCreateTime" },
                values: new object[] { "981b9ca8-df56-45eb-8669-509032c4a3aa", new DateTime(2024, 9, 5, 7, 43, 57, 951, DateTimeKind.Utc).AddTicks(2900), new DateTime(2024, 9, 5, 7, 43, 57, 951, DateTimeKind.Utc).AddTicks(2900), new DateTime(2024, 9, 5, 7, 43, 57, 951, DateTimeKind.Utc).AddTicks(2900) });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: 2055,
                columns: new[] { "ConcurrencyStamp", "CreatedTime", "LastUpdatedTime", "RefreshTokenCreateTime" },
                values: new object[] { "b851f375-eccd-4e15-8bb4-71cd296a317b", new DateTime(2024, 9, 5, 7, 43, 57, 951, DateTimeKind.Utc).AddTicks(2910), new DateTime(2024, 9, 5, 7, 43, 57, 951, DateTimeKind.Utc).AddTicks(2910), new DateTime(2024, 9, 5, 7, 43, 57, 951, DateTimeKind.Utc).AddTicks(2910) });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: 2056,
                columns: new[] { "ConcurrencyStamp", "CreatedTime", "LastUpdatedTime", "RefreshTokenCreateTime" },
                values: new object[] { "000d0586-f677-4984-b32b-fafd8072d349", new DateTime(2024, 9, 5, 7, 43, 57, 951, DateTimeKind.Utc).AddTicks(2920), new DateTime(2024, 9, 5, 7, 43, 57, 951, DateTimeKind.Utc).AddTicks(2920), new DateTime(2024, 9, 5, 7, 43, 57, 951, DateTimeKind.Utc).AddTicks(2920) });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: 2057,
                columns: new[] { "ConcurrencyStamp", "CreatedTime", "LastUpdatedTime", "RefreshTokenCreateTime" },
                values: new object[] { "eb3814c0-1c4d-4ead-af94-302a6ce786a0", new DateTime(2024, 9, 5, 7, 43, 57, 951, DateTimeKind.Utc).AddTicks(2930), new DateTime(2024, 9, 5, 7, 43, 57, 951, DateTimeKind.Utc).AddTicks(2930), new DateTime(2024, 9, 5, 7, 43, 57, 951, DateTimeKind.Utc).AddTicks(2920) });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: 2058,
                columns: new[] { "ConcurrencyStamp", "CreatedTime", "LastUpdatedTime", "RefreshTokenCreateTime" },
                values: new object[] { "1c3b635b-1d6c-4081-9a93-85b8306325f3", new DateTime(2024, 9, 5, 7, 43, 57, 951, DateTimeKind.Utc).AddTicks(2940), new DateTime(2024, 9, 5, 7, 43, 57, 951, DateTimeKind.Utc).AddTicks(2940), new DateTime(2024, 9, 5, 7, 43, 57, 951, DateTimeKind.Utc).AddTicks(2930) });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: 2059,
                columns: new[] { "ConcurrencyStamp", "CreatedTime", "LastUpdatedTime", "RefreshTokenCreateTime" },
                values: new object[] { "19d25beb-a19d-4370-bb41-5d02eb0067b6", new DateTime(2024, 9, 5, 7, 43, 57, 951, DateTimeKind.Utc).AddTicks(2950), new DateTime(2024, 9, 5, 7, 43, 57, 951, DateTimeKind.Utc).AddTicks(2950), new DateTime(2024, 9, 5, 7, 43, 57, 951, DateTimeKind.Utc).AddTicks(2940) });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: 2060,
                columns: new[] { "ConcurrencyStamp", "CreatedTime", "LastUpdatedTime", "RefreshTokenCreateTime" },
                values: new object[] { "516a2d92-73a7-484b-b87b-b515053be73b", new DateTime(2024, 9, 5, 7, 43, 57, 951, DateTimeKind.Utc).AddTicks(2960), new DateTime(2024, 9, 5, 7, 43, 57, 951, DateTimeKind.Utc).AddTicks(2960), new DateTime(2024, 9, 5, 7, 43, 57, 951, DateTimeKind.Utc).AddTicks(2950) });

            migrationBuilder.UpdateData(
                table: "Breeds",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedTime",
                value: new DateTime(2024, 9, 5, 11, 43, 57, 948, DateTimeKind.Local).AddTicks(4160));

            migrationBuilder.UpdateData(
                table: "Breeds",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreatedTime",
                value: new DateTime(2024, 9, 5, 11, 43, 57, 948, DateTimeKind.Local).AddTicks(4170));

            migrationBuilder.UpdateData(
                table: "Breeds",
                keyColumn: "Id",
                keyValue: 3,
                column: "CreatedTime",
                value: new DateTime(2024, 9, 5, 11, 43, 57, 948, DateTimeKind.Local).AddTicks(4170));

            migrationBuilder.UpdateData(
                table: "Breeds",
                keyColumn: "Id",
                keyValue: 4,
                column: "CreatedTime",
                value: new DateTime(2024, 9, 5, 11, 43, 57, 948, DateTimeKind.Local).AddTicks(4170));

            migrationBuilder.UpdateData(
                table: "Breeds",
                keyColumn: "Id",
                keyValue: 5,
                column: "CreatedTime",
                value: new DateTime(2024, 9, 5, 11, 43, 57, 948, DateTimeKind.Local).AddTicks(4170));

            migrationBuilder.UpdateData(
                table: "Breeds",
                keyColumn: "Id",
                keyValue: 6,
                column: "CreatedTime",
                value: new DateTime(2024, 9, 5, 11, 43, 57, 948, DateTimeKind.Local).AddTicks(4170));

            migrationBuilder.UpdateData(
                table: "Breeds",
                keyColumn: "Id",
                keyValue: 7,
                column: "CreatedTime",
                value: new DateTime(2024, 9, 5, 11, 43, 57, 948, DateTimeKind.Local).AddTicks(4170));

            migrationBuilder.UpdateData(
                table: "Breeds",
                keyColumn: "Id",
                keyValue: 8,
                column: "CreatedTime",
                value: new DateTime(2024, 9, 5, 11, 43, 57, 948, DateTimeKind.Local).AddTicks(4170));

            migrationBuilder.UpdateData(
                table: "Breeds",
                keyColumn: "Id",
                keyValue: 9,
                column: "CreatedTime",
                value: new DateTime(2024, 9, 5, 11, 43, 57, 948, DateTimeKind.Local).AddTicks(4180));

            migrationBuilder.UpdateData(
                table: "Breeds",
                keyColumn: "Id",
                keyValue: 10,
                column: "CreatedTime",
                value: new DateTime(2024, 9, 5, 11, 43, 57, 948, DateTimeKind.Local).AddTicks(4180));

            migrationBuilder.UpdateData(
                table: "Breeds",
                keyColumn: "Id",
                keyValue: 11,
                column: "CreatedTime",
                value: new DateTime(2024, 9, 5, 11, 43, 57, 948, DateTimeKind.Local).AddTicks(4180));

            migrationBuilder.UpdateData(
                table: "Breeds",
                keyColumn: "Id",
                keyValue: 12,
                column: "CreatedTime",
                value: new DateTime(2024, 9, 5, 11, 43, 57, 948, DateTimeKind.Local).AddTicks(4180));

            migrationBuilder.UpdateData(
                table: "Breeds",
                keyColumn: "Id",
                keyValue: 13,
                column: "CreatedTime",
                value: new DateTime(2024, 9, 5, 11, 43, 57, 948, DateTimeKind.Local).AddTicks(4190));

            migrationBuilder.UpdateData(
                table: "Breeds",
                keyColumn: "Id",
                keyValue: 14,
                column: "CreatedTime",
                value: new DateTime(2024, 9, 5, 11, 43, 57, 948, DateTimeKind.Local).AddTicks(4190));

            migrationBuilder.UpdateData(
                table: "Breeds",
                keyColumn: "Id",
                keyValue: 15,
                column: "CreatedTime",
                value: new DateTime(2024, 9, 5, 11, 43, 57, 948, DateTimeKind.Local).AddTicks(4190));

            migrationBuilder.UpdateData(
                table: "Breeds",
                keyColumn: "Id",
                keyValue: 16,
                column: "CreatedTime",
                value: new DateTime(2024, 9, 5, 11, 43, 57, 948, DateTimeKind.Local).AddTicks(4190));

            migrationBuilder.UpdateData(
                table: "Breeds",
                keyColumn: "Id",
                keyValue: 17,
                column: "CreatedTime",
                value: new DateTime(2024, 9, 5, 11, 43, 57, 948, DateTimeKind.Local).AddTicks(4190));

            migrationBuilder.UpdateData(
                table: "Breeds",
                keyColumn: "Id",
                keyValue: 18,
                column: "CreatedTime",
                value: new DateTime(2024, 9, 5, 11, 43, 57, 948, DateTimeKind.Local).AddTicks(4190));

            migrationBuilder.UpdateData(
                table: "Breeds",
                keyColumn: "Id",
                keyValue: 19,
                column: "CreatedTime",
                value: new DateTime(2024, 9, 5, 11, 43, 57, 948, DateTimeKind.Local).AddTicks(4200));

            migrationBuilder.UpdateData(
                table: "Breeds",
                keyColumn: "Id",
                keyValue: 20,
                column: "CreatedTime",
                value: new DateTime(2024, 9, 5, 11, 43, 57, 948, DateTimeKind.Local).AddTicks(4200));

            migrationBuilder.UpdateData(
                table: "Breeds",
                keyColumn: "Id",
                keyValue: 21,
                column: "CreatedTime",
                value: new DateTime(2024, 9, 5, 11, 43, 57, 948, DateTimeKind.Local).AddTicks(4200));

            migrationBuilder.UpdateData(
                table: "Breeds",
                keyColumn: "Id",
                keyValue: 22,
                column: "CreatedTime",
                value: new DateTime(2024, 9, 5, 11, 43, 57, 948, DateTimeKind.Local).AddTicks(4200));

            migrationBuilder.UpdateData(
                table: "Breeds",
                keyColumn: "Id",
                keyValue: 23,
                column: "CreatedTime",
                value: new DateTime(2024, 9, 5, 11, 43, 57, 948, DateTimeKind.Local).AddTicks(4200));

            migrationBuilder.UpdateData(
                table: "Breeds",
                keyColumn: "Id",
                keyValue: 24,
                column: "CreatedTime",
                value: new DateTime(2024, 9, 5, 11, 43, 57, 948, DateTimeKind.Local).AddTicks(4200));

            migrationBuilder.UpdateData(
                table: "Breeds",
                keyColumn: "Id",
                keyValue: 25,
                column: "CreatedTime",
                value: new DateTime(2024, 9, 5, 11, 43, 57, 948, DateTimeKind.Local).AddTicks(4200));

            migrationBuilder.UpdateData(
                table: "Breeds",
                keyColumn: "Id",
                keyValue: 26,
                column: "CreatedTime",
                value: new DateTime(2024, 9, 5, 11, 43, 57, 948, DateTimeKind.Local).AddTicks(4210));

            migrationBuilder.UpdateData(
                table: "Breeds",
                keyColumn: "Id",
                keyValue: 27,
                column: "CreatedTime",
                value: new DateTime(2024, 9, 5, 11, 43, 57, 948, DateTimeKind.Local).AddTicks(4210));

            migrationBuilder.UpdateData(
                table: "Breeds",
                keyColumn: "Id",
                keyValue: 28,
                column: "CreatedTime",
                value: new DateTime(2024, 9, 5, 11, 43, 57, 948, DateTimeKind.Local).AddTicks(4210));

            migrationBuilder.UpdateData(
                table: "Breeds",
                keyColumn: "Id",
                keyValue: 29,
                column: "CreatedTime",
                value: new DateTime(2024, 9, 5, 11, 43, 57, 948, DateTimeKind.Local).AddTicks(4210));

            migrationBuilder.UpdateData(
                table: "Breeds",
                keyColumn: "Id",
                keyValue: 30,
                column: "CreatedTime",
                value: new DateTime(2024, 9, 5, 11, 43, 57, 948, DateTimeKind.Local).AddTicks(4210));

            migrationBuilder.UpdateData(
                table: "Breeds",
                keyColumn: "Id",
                keyValue: 31,
                column: "CreatedTime",
                value: new DateTime(2024, 9, 5, 11, 43, 57, 948, DateTimeKind.Local).AddTicks(4210));

            migrationBuilder.UpdateData(
                table: "Breeds",
                keyColumn: "Id",
                keyValue: 32,
                column: "CreatedTime",
                value: new DateTime(2024, 9, 5, 11, 43, 57, 948, DateTimeKind.Local).AddTicks(4220));

            migrationBuilder.UpdateData(
                table: "Breeds",
                keyColumn: "Id",
                keyValue: 33,
                column: "CreatedTime",
                value: new DateTime(2024, 9, 5, 11, 43, 57, 948, DateTimeKind.Local).AddTicks(4220));

            migrationBuilder.UpdateData(
                table: "Breeds",
                keyColumn: "Id",
                keyValue: 34,
                column: "CreatedTime",
                value: new DateTime(2024, 9, 5, 11, 43, 57, 948, DateTimeKind.Local).AddTicks(4220));

            migrationBuilder.UpdateData(
                table: "Breeds",
                keyColumn: "Id",
                keyValue: 35,
                column: "CreatedTime",
                value: new DateTime(2024, 9, 5, 11, 43, 57, 948, DateTimeKind.Local).AddTicks(4220));

            migrationBuilder.UpdateData(
                table: "Breeds",
                keyColumn: "Id",
                keyValue: 36,
                column: "CreatedTime",
                value: new DateTime(2024, 9, 5, 11, 43, 57, 948, DateTimeKind.Local).AddTicks(4220));

            migrationBuilder.UpdateData(
                table: "Breeds",
                keyColumn: "Id",
                keyValue: 37,
                column: "CreatedTime",
                value: new DateTime(2024, 9, 5, 11, 43, 57, 948, DateTimeKind.Local).AddTicks(4220));

            migrationBuilder.UpdateData(
                table: "Breeds",
                keyColumn: "Id",
                keyValue: 38,
                column: "CreatedTime",
                value: new DateTime(2024, 9, 5, 11, 43, 57, 948, DateTimeKind.Local).AddTicks(4220));

            migrationBuilder.UpdateData(
                table: "Breeds",
                keyColumn: "Id",
                keyValue: 39,
                column: "CreatedTime",
                value: new DateTime(2024, 9, 5, 11, 43, 57, 948, DateTimeKind.Local).AddTicks(4230));

            migrationBuilder.UpdateData(
                table: "Breeds",
                keyColumn: "Id",
                keyValue: 40,
                column: "CreatedTime",
                value: new DateTime(2024, 9, 5, 11, 43, 57, 948, DateTimeKind.Local).AddTicks(4230));

            migrationBuilder.UpdateData(
                table: "Breeds",
                keyColumn: "Id",
                keyValue: 41,
                column: "CreatedTime",
                value: new DateTime(2024, 9, 5, 11, 43, 57, 948, DateTimeKind.Local).AddTicks(4230));

            migrationBuilder.UpdateData(
                table: "Breeds",
                keyColumn: "Id",
                keyValue: 42,
                column: "CreatedTime",
                value: new DateTime(2024, 9, 5, 11, 43, 57, 948, DateTimeKind.Local).AddTicks(4230));

            migrationBuilder.UpdateData(
                table: "Breeds",
                keyColumn: "Id",
                keyValue: 43,
                column: "CreatedTime",
                value: new DateTime(2024, 9, 5, 11, 43, 57, 948, DateTimeKind.Local).AddTicks(4230));

            migrationBuilder.UpdateData(
                table: "Breeds",
                keyColumn: "Id",
                keyValue: 44,
                column: "CreatedTime",
                value: new DateTime(2024, 9, 5, 11, 43, 57, 948, DateTimeKind.Local).AddTicks(4230));

            migrationBuilder.UpdateData(
                table: "Breeds",
                keyColumn: "Id",
                keyValue: 45,
                column: "CreatedTime",
                value: new DateTime(2024, 9, 5, 11, 43, 57, 948, DateTimeKind.Local).AddTicks(4240));

            migrationBuilder.UpdateData(
                table: "Breeds",
                keyColumn: "Id",
                keyValue: 46,
                column: "CreatedTime",
                value: new DateTime(2024, 9, 5, 11, 43, 57, 948, DateTimeKind.Local).AddTicks(4240));

            migrationBuilder.UpdateData(
                table: "Breeds",
                keyColumn: "Id",
                keyValue: 47,
                column: "CreatedTime",
                value: new DateTime(2024, 9, 5, 11, 43, 57, 948, DateTimeKind.Local).AddTicks(4240));

            migrationBuilder.UpdateData(
                table: "Breeds",
                keyColumn: "Id",
                keyValue: 48,
                column: "CreatedTime",
                value: new DateTime(2024, 9, 5, 11, 43, 57, 948, DateTimeKind.Local).AddTicks(4240));

            migrationBuilder.UpdateData(
                table: "Breeds",
                keyColumn: "Id",
                keyValue: 49,
                column: "CreatedTime",
                value: new DateTime(2024, 9, 5, 11, 43, 57, 948, DateTimeKind.Local).AddTicks(4240));

            migrationBuilder.UpdateData(
                table: "Breeds",
                keyColumn: "Id",
                keyValue: 50,
                column: "CreatedTime",
                value: new DateTime(2024, 9, 5, 11, 43, 57, 948, DateTimeKind.Local).AddTicks(4240));

            migrationBuilder.UpdateData(
                table: "Breeds",
                keyColumn: "Id",
                keyValue: 51,
                column: "CreatedTime",
                value: new DateTime(2024, 9, 5, 11, 43, 57, 948, DateTimeKind.Local).AddTicks(4240));

            migrationBuilder.UpdateData(
                table: "Breeds",
                keyColumn: "Id",
                keyValue: 52,
                column: "CreatedTime",
                value: new DateTime(2024, 9, 5, 11, 43, 57, 948, DateTimeKind.Local).AddTicks(4250));

            migrationBuilder.UpdateData(
                table: "Breeds",
                keyColumn: "Id",
                keyValue: 53,
                column: "CreatedTime",
                value: new DateTime(2024, 9, 5, 11, 43, 57, 948, DateTimeKind.Local).AddTicks(4250));

            migrationBuilder.UpdateData(
                table: "Breeds",
                keyColumn: "Id",
                keyValue: 54,
                column: "CreatedTime",
                value: new DateTime(2024, 9, 5, 11, 43, 57, 948, DateTimeKind.Local).AddTicks(4250));

            migrationBuilder.UpdateData(
                table: "Breeds",
                keyColumn: "Id",
                keyValue: 55,
                column: "CreatedTime",
                value: new DateTime(2024, 9, 5, 11, 43, 57, 948, DateTimeKind.Local).AddTicks(4250));

            migrationBuilder.UpdateData(
                table: "Breeds",
                keyColumn: "Id",
                keyValue: 56,
                column: "CreatedTime",
                value: new DateTime(2024, 9, 5, 11, 43, 57, 948, DateTimeKind.Local).AddTicks(4250));

            migrationBuilder.UpdateData(
                table: "Breeds",
                keyColumn: "Id",
                keyValue: 57,
                column: "CreatedTime",
                value: new DateTime(2024, 9, 5, 11, 43, 57, 948, DateTimeKind.Local).AddTicks(4250));

            migrationBuilder.UpdateData(
                table: "Breeds",
                keyColumn: "Id",
                keyValue: 58,
                column: "CreatedTime",
                value: new DateTime(2024, 9, 5, 11, 43, 57, 948, DateTimeKind.Local).AddTicks(4260));

            migrationBuilder.UpdateData(
                table: "Breeds",
                keyColumn: "Id",
                keyValue: 59,
                column: "CreatedTime",
                value: new DateTime(2024, 9, 5, 11, 43, 57, 948, DateTimeKind.Local).AddTicks(4260));

            migrationBuilder.UpdateData(
                table: "Breeds",
                keyColumn: "Id",
                keyValue: 60,
                column: "CreatedTime",
                value: new DateTime(2024, 9, 5, 11, 43, 57, 948, DateTimeKind.Local).AddTicks(4260));

            migrationBuilder.UpdateData(
                table: "Breeds",
                keyColumn: "Id",
                keyValue: 61,
                column: "CreatedTime",
                value: new DateTime(2024, 9, 5, 11, 43, 57, 948, DateTimeKind.Local).AddTicks(4260));

            migrationBuilder.UpdateData(
                table: "Breeds",
                keyColumn: "Id",
                keyValue: 62,
                column: "CreatedTime",
                value: new DateTime(2024, 9, 5, 11, 43, 57, 948, DateTimeKind.Local).AddTicks(4260));

            migrationBuilder.UpdateData(
                table: "Breeds",
                keyColumn: "Id",
                keyValue: 63,
                column: "CreatedTime",
                value: new DateTime(2024, 9, 5, 11, 43, 57, 948, DateTimeKind.Local).AddTicks(4260));

            migrationBuilder.UpdateData(
                table: "Breeds",
                keyColumn: "Id",
                keyValue: 64,
                column: "CreatedTime",
                value: new DateTime(2024, 9, 5, 11, 43, 57, 948, DateTimeKind.Local).AddTicks(4260));

            migrationBuilder.UpdateData(
                table: "Breeds",
                keyColumn: "Id",
                keyValue: 65,
                column: "CreatedTime",
                value: new DateTime(2024, 9, 5, 11, 43, 57, 948, DateTimeKind.Local).AddTicks(4270));

            migrationBuilder.UpdateData(
                table: "Breeds",
                keyColumn: "Id",
                keyValue: 66,
                column: "CreatedTime",
                value: new DateTime(2024, 9, 5, 11, 43, 57, 948, DateTimeKind.Local).AddTicks(4270));

            migrationBuilder.UpdateData(
                table: "Breeds",
                keyColumn: "Id",
                keyValue: 67,
                column: "CreatedTime",
                value: new DateTime(2024, 9, 5, 11, 43, 57, 948, DateTimeKind.Local).AddTicks(4270));

            migrationBuilder.UpdateData(
                table: "Breeds",
                keyColumn: "Id",
                keyValue: 68,
                column: "CreatedTime",
                value: new DateTime(2024, 9, 5, 11, 43, 57, 948, DateTimeKind.Local).AddTicks(4270));

            migrationBuilder.UpdateData(
                table: "Breeds",
                keyColumn: "Id",
                keyValue: 69,
                column: "CreatedTime",
                value: new DateTime(2024, 9, 5, 11, 43, 57, 948, DateTimeKind.Local).AddTicks(4290));

            migrationBuilder.UpdateData(
                table: "Breeds",
                keyColumn: "Id",
                keyValue: 70,
                column: "CreatedTime",
                value: new DateTime(2024, 9, 5, 11, 43, 57, 948, DateTimeKind.Local).AddTicks(4290));

            migrationBuilder.UpdateData(
                table: "Breeds",
                keyColumn: "Id",
                keyValue: 71,
                column: "CreatedTime",
                value: new DateTime(2024, 9, 5, 11, 43, 57, 948, DateTimeKind.Local).AddTicks(4290));

            migrationBuilder.UpdateData(
                table: "Breeds",
                keyColumn: "Id",
                keyValue: 72,
                column: "CreatedTime",
                value: new DateTime(2024, 9, 5, 11, 43, 57, 948, DateTimeKind.Local).AddTicks(4290));

            migrationBuilder.UpdateData(
                table: "Breeds",
                keyColumn: "Id",
                keyValue: 73,
                column: "CreatedTime",
                value: new DateTime(2024, 9, 5, 11, 43, 57, 948, DateTimeKind.Local).AddTicks(4290));

            migrationBuilder.UpdateData(
                table: "Breeds",
                keyColumn: "Id",
                keyValue: 74,
                column: "CreatedTime",
                value: new DateTime(2024, 9, 5, 11, 43, 57, 948, DateTimeKind.Local).AddTicks(4290));

            migrationBuilder.UpdateData(
                table: "Breeds",
                keyColumn: "Id",
                keyValue: 75,
                column: "CreatedTime",
                value: new DateTime(2024, 9, 5, 11, 43, 57, 948, DateTimeKind.Local).AddTicks(4290));

            migrationBuilder.UpdateData(
                table: "Breeds",
                keyColumn: "Id",
                keyValue: 76,
                column: "CreatedTime",
                value: new DateTime(2024, 9, 5, 11, 43, 57, 948, DateTimeKind.Local).AddTicks(4300));

            migrationBuilder.UpdateData(
                table: "Breeds",
                keyColumn: "Id",
                keyValue: 77,
                column: "CreatedTime",
                value: new DateTime(2024, 9, 5, 11, 43, 57, 948, DateTimeKind.Local).AddTicks(4300));

            migrationBuilder.UpdateData(
                table: "Breeds",
                keyColumn: "Id",
                keyValue: 78,
                column: "CreatedTime",
                value: new DateTime(2024, 9, 5, 11, 43, 57, 948, DateTimeKind.Local).AddTicks(4300));

            migrationBuilder.UpdateData(
                table: "Breeds",
                keyColumn: "Id",
                keyValue: 79,
                column: "CreatedTime",
                value: new DateTime(2024, 9, 5, 11, 43, 57, 948, DateTimeKind.Local).AddTicks(4300));

            migrationBuilder.UpdateData(
                table: "Breeds",
                keyColumn: "Id",
                keyValue: 80,
                column: "CreatedTime",
                value: new DateTime(2024, 9, 5, 11, 43, 57, 948, DateTimeKind.Local).AddTicks(4300));

            migrationBuilder.UpdateData(
                table: "Breeds",
                keyColumn: "Id",
                keyValue: 81,
                column: "CreatedTime",
                value: new DateTime(2024, 9, 5, 11, 43, 57, 948, DateTimeKind.Local).AddTicks(4300));

            migrationBuilder.UpdateData(
                table: "Breeds",
                keyColumn: "Id",
                keyValue: 82,
                column: "CreatedTime",
                value: new DateTime(2024, 9, 5, 11, 43, 57, 948, DateTimeKind.Local).AddTicks(4310));

            migrationBuilder.UpdateData(
                table: "Breeds",
                keyColumn: "Id",
                keyValue: 83,
                column: "CreatedTime",
                value: new DateTime(2024, 9, 5, 11, 43, 57, 948, DateTimeKind.Local).AddTicks(4310));

            migrationBuilder.UpdateData(
                table: "Breeds",
                keyColumn: "Id",
                keyValue: 84,
                column: "CreatedTime",
                value: new DateTime(2024, 9, 5, 11, 43, 57, 948, DateTimeKind.Local).AddTicks(4310));

            migrationBuilder.UpdateData(
                table: "Breeds",
                keyColumn: "Id",
                keyValue: 85,
                column: "CreatedTime",
                value: new DateTime(2024, 9, 5, 11, 43, 57, 948, DateTimeKind.Local).AddTicks(4310));

            migrationBuilder.UpdateData(
                table: "Breeds",
                keyColumn: "Id",
                keyValue: 86,
                column: "CreatedTime",
                value: new DateTime(2024, 9, 5, 11, 43, 57, 948, DateTimeKind.Local).AddTicks(4310));

            migrationBuilder.UpdateData(
                table: "Breeds",
                keyColumn: "Id",
                keyValue: 87,
                column: "CreatedTime",
                value: new DateTime(2024, 9, 5, 11, 43, 57, 948, DateTimeKind.Local).AddTicks(4310));

            migrationBuilder.UpdateData(
                table: "Breeds",
                keyColumn: "Id",
                keyValue: 88,
                column: "CreatedTime",
                value: new DateTime(2024, 9, 5, 11, 43, 57, 948, DateTimeKind.Local).AddTicks(4310));

            migrationBuilder.UpdateData(
                table: "Breeds",
                keyColumn: "Id",
                keyValue: 89,
                column: "CreatedTime",
                value: new DateTime(2024, 9, 5, 11, 43, 57, 948, DateTimeKind.Local).AddTicks(4320));

            migrationBuilder.UpdateData(
                table: "Breeds",
                keyColumn: "Id",
                keyValue: 90,
                column: "CreatedTime",
                value: new DateTime(2024, 9, 5, 11, 43, 57, 948, DateTimeKind.Local).AddTicks(4320));

            migrationBuilder.UpdateData(
                table: "Breeds",
                keyColumn: "Id",
                keyValue: 91,
                column: "CreatedTime",
                value: new DateTime(2024, 9, 5, 11, 43, 57, 948, DateTimeKind.Local).AddTicks(4320));

            migrationBuilder.UpdateData(
                table: "Breeds",
                keyColumn: "Id",
                keyValue: 92,
                column: "CreatedTime",
                value: new DateTime(2024, 9, 5, 11, 43, 57, 948, DateTimeKind.Local).AddTicks(4320));

            migrationBuilder.UpdateData(
                table: "Breeds",
                keyColumn: "Id",
                keyValue: 93,
                column: "CreatedTime",
                value: new DateTime(2024, 9, 5, 11, 43, 57, 948, DateTimeKind.Local).AddTicks(4320));

            migrationBuilder.UpdateData(
                table: "Breeds",
                keyColumn: "Id",
                keyValue: 94,
                column: "CreatedTime",
                value: new DateTime(2024, 9, 5, 11, 43, 57, 948, DateTimeKind.Local).AddTicks(4320));

            migrationBuilder.UpdateData(
                table: "Breeds",
                keyColumn: "Id",
                keyValue: 95,
                column: "CreatedTime",
                value: new DateTime(2024, 9, 5, 11, 43, 57, 948, DateTimeKind.Local).AddTicks(4320));

            migrationBuilder.UpdateData(
                table: "Breeds",
                keyColumn: "Id",
                keyValue: 96,
                column: "CreatedTime",
                value: new DateTime(2024, 9, 5, 11, 43, 57, 948, DateTimeKind.Local).AddTicks(4330));

            migrationBuilder.UpdateData(
                table: "Breeds",
                keyColumn: "Id",
                keyValue: 97,
                column: "CreatedTime",
                value: new DateTime(2024, 9, 5, 11, 43, 57, 948, DateTimeKind.Local).AddTicks(4330));

            migrationBuilder.UpdateData(
                table: "Breeds",
                keyColumn: "Id",
                keyValue: 98,
                column: "CreatedTime",
                value: new DateTime(2024, 9, 5, 11, 43, 57, 948, DateTimeKind.Local).AddTicks(4330));

            migrationBuilder.UpdateData(
                table: "Breeds",
                keyColumn: "Id",
                keyValue: 99,
                column: "CreatedTime",
                value: new DateTime(2024, 9, 5, 11, 43, 57, 948, DateTimeKind.Local).AddTicks(4330));

            migrationBuilder.UpdateData(
                table: "Breeds",
                keyColumn: "Id",
                keyValue: 100,
                column: "CreatedTime",
                value: new DateTime(2024, 9, 5, 11, 43, 57, 948, DateTimeKind.Local).AddTicks(4330));

            migrationBuilder.UpdateData(
                table: "Breeds",
                keyColumn: "Id",
                keyValue: 101,
                column: "CreatedTime",
                value: new DateTime(2024, 9, 5, 11, 43, 57, 948, DateTimeKind.Local).AddTicks(4330));

            migrationBuilder.UpdateData(
                table: "Breeds",
                keyColumn: "Id",
                keyValue: 102,
                column: "CreatedTime",
                value: new DateTime(2024, 9, 5, 11, 43, 57, 948, DateTimeKind.Local).AddTicks(4340));

            migrationBuilder.UpdateData(
                table: "Breeds",
                keyColumn: "Id",
                keyValue: 103,
                column: "CreatedTime",
                value: new DateTime(2024, 9, 5, 11, 43, 57, 948, DateTimeKind.Local).AddTicks(4340));

            migrationBuilder.UpdateData(
                table: "Breeds",
                keyColumn: "Id",
                keyValue: 104,
                column: "CreatedTime",
                value: new DateTime(2024, 9, 5, 11, 43, 57, 948, DateTimeKind.Local).AddTicks(4340));

            migrationBuilder.UpdateData(
                table: "Breeds",
                keyColumn: "Id",
                keyValue: 105,
                column: "CreatedTime",
                value: new DateTime(2024, 9, 5, 11, 43, 57, 948, DateTimeKind.Local).AddTicks(4340));

            migrationBuilder.UpdateData(
                table: "Breeds",
                keyColumn: "Id",
                keyValue: 106,
                column: "CreatedTime",
                value: new DateTime(2024, 9, 5, 11, 43, 57, 948, DateTimeKind.Local).AddTicks(4340));

            migrationBuilder.UpdateData(
                table: "Breeds",
                keyColumn: "Id",
                keyValue: 107,
                column: "CreatedTime",
                value: new DateTime(2024, 9, 5, 11, 43, 57, 948, DateTimeKind.Local).AddTicks(4340));

            migrationBuilder.UpdateData(
                table: "Breeds",
                keyColumn: "Id",
                keyValue: 108,
                column: "CreatedTime",
                value: new DateTime(2024, 9, 5, 11, 43, 57, 948, DateTimeKind.Local).AddTicks(4340));

            migrationBuilder.UpdateData(
                table: "Breeds",
                keyColumn: "Id",
                keyValue: 109,
                column: "CreatedTime",
                value: new DateTime(2024, 9, 5, 11, 43, 57, 948, DateTimeKind.Local).AddTicks(4350));

            migrationBuilder.UpdateData(
                table: "Breeds",
                keyColumn: "Id",
                keyValue: 110,
                column: "CreatedTime",
                value: new DateTime(2024, 9, 5, 11, 43, 57, 948, DateTimeKind.Local).AddTicks(4350));

            migrationBuilder.UpdateData(
                table: "Breeds",
                keyColumn: "Id",
                keyValue: 111,
                column: "CreatedTime",
                value: new DateTime(2024, 9, 5, 11, 43, 57, 948, DateTimeKind.Local).AddTicks(4350));

            migrationBuilder.UpdateData(
                table: "Breeds",
                keyColumn: "Id",
                keyValue: 112,
                column: "CreatedTime",
                value: new DateTime(2024, 9, 5, 11, 43, 57, 948, DateTimeKind.Local).AddTicks(4350));

            migrationBuilder.UpdateData(
                table: "Breeds",
                keyColumn: "Id",
                keyValue: 113,
                column: "CreatedTime",
                value: new DateTime(2024, 9, 5, 11, 43, 57, 948, DateTimeKind.Local).AddTicks(4350));

            migrationBuilder.UpdateData(
                table: "Breeds",
                keyColumn: "Id",
                keyValue: 114,
                column: "CreatedTime",
                value: new DateTime(2024, 9, 5, 11, 43, 57, 948, DateTimeKind.Local).AddTicks(4350));

            migrationBuilder.UpdateData(
                table: "Breeds",
                keyColumn: "Id",
                keyValue: 115,
                column: "CreatedTime",
                value: new DateTime(2024, 9, 5, 11, 43, 57, 948, DateTimeKind.Local).AddTicks(4350));

            migrationBuilder.UpdateData(
                table: "Breeds",
                keyColumn: "Id",
                keyValue: 116,
                column: "CreatedTime",
                value: new DateTime(2024, 9, 5, 11, 43, 57, 948, DateTimeKind.Local).AddTicks(4360));

            migrationBuilder.UpdateData(
                table: "Breeds",
                keyColumn: "Id",
                keyValue: 117,
                column: "CreatedTime",
                value: new DateTime(2024, 9, 5, 11, 43, 57, 948, DateTimeKind.Local).AddTicks(4360));

            migrationBuilder.UpdateData(
                table: "Breeds",
                keyColumn: "Id",
                keyValue: 118,
                column: "CreatedTime",
                value: new DateTime(2024, 9, 5, 11, 43, 57, 948, DateTimeKind.Local).AddTicks(4360));

            migrationBuilder.UpdateData(
                table: "Breeds",
                keyColumn: "Id",
                keyValue: 119,
                column: "CreatedTime",
                value: new DateTime(2024, 9, 5, 11, 43, 57, 948, DateTimeKind.Local).AddTicks(4360));

            migrationBuilder.UpdateData(
                table: "Breeds",
                keyColumn: "Id",
                keyValue: 120,
                column: "CreatedTime",
                value: new DateTime(2024, 9, 5, 11, 43, 57, 948, DateTimeKind.Local).AddTicks(4360));

            migrationBuilder.UpdateData(
                table: "Breeds",
                keyColumn: "Id",
                keyValue: 121,
                column: "CreatedTime",
                value: new DateTime(2024, 9, 5, 11, 43, 57, 948, DateTimeKind.Local).AddTicks(4360));

            migrationBuilder.UpdateData(
                table: "Breeds",
                keyColumn: "Id",
                keyValue: 122,
                column: "CreatedTime",
                value: new DateTime(2024, 9, 5, 11, 43, 57, 948, DateTimeKind.Local).AddTicks(4370));

            migrationBuilder.UpdateData(
                table: "Breeds",
                keyColumn: "Id",
                keyValue: 123,
                column: "CreatedTime",
                value: new DateTime(2024, 9, 5, 11, 43, 57, 948, DateTimeKind.Local).AddTicks(4370));

            migrationBuilder.UpdateData(
                table: "Breeds",
                keyColumn: "Id",
                keyValue: 124,
                column: "CreatedTime",
                value: new DateTime(2024, 9, 5, 11, 43, 57, 948, DateTimeKind.Local).AddTicks(4370));

            migrationBuilder.UpdateData(
                table: "Breeds",
                keyColumn: "Id",
                keyValue: 125,
                column: "CreatedTime",
                value: new DateTime(2024, 9, 5, 11, 43, 57, 948, DateTimeKind.Local).AddTicks(4370));

            migrationBuilder.UpdateData(
                table: "Breeds",
                keyColumn: "Id",
                keyValue: 126,
                column: "CreatedTime",
                value: new DateTime(2024, 9, 5, 11, 43, 57, 948, DateTimeKind.Local).AddTicks(4370));

            migrationBuilder.UpdateData(
                table: "Breeds",
                keyColumn: "Id",
                keyValue: 127,
                column: "CreatedTime",
                value: new DateTime(2024, 9, 5, 11, 43, 57, 948, DateTimeKind.Local).AddTicks(4370));

            migrationBuilder.UpdateData(
                table: "Breeds",
                keyColumn: "Id",
                keyValue: 128,
                column: "CreatedTime",
                value: new DateTime(2024, 9, 5, 11, 43, 57, 948, DateTimeKind.Local).AddTicks(4370));

            migrationBuilder.UpdateData(
                table: "Breeds",
                keyColumn: "Id",
                keyValue: 129,
                column: "CreatedTime",
                value: new DateTime(2024, 9, 5, 11, 43, 57, 948, DateTimeKind.Local).AddTicks(4380));

            migrationBuilder.UpdateData(
                table: "Breeds",
                keyColumn: "Id",
                keyValue: 130,
                column: "CreatedTime",
                value: new DateTime(2024, 9, 5, 11, 43, 57, 948, DateTimeKind.Local).AddTicks(4380));

            migrationBuilder.UpdateData(
                table: "Breeds",
                keyColumn: "Id",
                keyValue: 131,
                column: "CreatedTime",
                value: new DateTime(2024, 9, 5, 11, 43, 57, 948, DateTimeKind.Local).AddTicks(4380));

            migrationBuilder.UpdateData(
                table: "Breeds",
                keyColumn: "Id",
                keyValue: 132,
                column: "CreatedTime",
                value: new DateTime(2024, 9, 5, 11, 43, 57, 948, DateTimeKind.Local).AddTicks(4380));

            migrationBuilder.UpdateData(
                table: "Breeds",
                keyColumn: "Id",
                keyValue: 133,
                column: "CreatedTime",
                value: new DateTime(2024, 9, 5, 11, 43, 57, 948, DateTimeKind.Local).AddTicks(4380));

            migrationBuilder.UpdateData(
                table: "Breeds",
                keyColumn: "Id",
                keyValue: 134,
                column: "CreatedTime",
                value: new DateTime(2024, 9, 5, 11, 43, 57, 948, DateTimeKind.Local).AddTicks(4380));

            migrationBuilder.UpdateData(
                table: "Breeds",
                keyColumn: "Id",
                keyValue: 135,
                column: "CreatedTime",
                value: new DateTime(2024, 9, 5, 11, 43, 57, 948, DateTimeKind.Local).AddTicks(4390));

            migrationBuilder.UpdateData(
                table: "Breeds",
                keyColumn: "Id",
                keyValue: 136,
                column: "CreatedTime",
                value: new DateTime(2024, 9, 5, 11, 43, 57, 948, DateTimeKind.Local).AddTicks(4390));

            migrationBuilder.UpdateData(
                table: "Breeds",
                keyColumn: "Id",
                keyValue: 137,
                column: "CreatedTime",
                value: new DateTime(2024, 9, 5, 11, 43, 57, 948, DateTimeKind.Local).AddTicks(4400));

            migrationBuilder.UpdateData(
                table: "Breeds",
                keyColumn: "Id",
                keyValue: 138,
                column: "CreatedTime",
                value: new DateTime(2024, 9, 5, 11, 43, 57, 948, DateTimeKind.Local).AddTicks(4410));

            migrationBuilder.UpdateData(
                table: "Breeds",
                keyColumn: "Id",
                keyValue: 139,
                column: "CreatedTime",
                value: new DateTime(2024, 9, 5, 11, 43, 57, 948, DateTimeKind.Local).AddTicks(4410));

            migrationBuilder.UpdateData(
                table: "Breeds",
                keyColumn: "Id",
                keyValue: 140,
                column: "CreatedTime",
                value: new DateTime(2024, 9, 5, 11, 43, 57, 948, DateTimeKind.Local).AddTicks(4410));

            migrationBuilder.UpdateData(
                table: "Breeds",
                keyColumn: "Id",
                keyValue: 141,
                column: "CreatedTime",
                value: new DateTime(2024, 9, 5, 11, 43, 57, 948, DateTimeKind.Local).AddTicks(4410));

            migrationBuilder.UpdateData(
                table: "Breeds",
                keyColumn: "Id",
                keyValue: 142,
                column: "CreatedTime",
                value: new DateTime(2024, 9, 5, 11, 43, 57, 948, DateTimeKind.Local).AddTicks(4410));

            migrationBuilder.UpdateData(
                table: "Breeds",
                keyColumn: "Id",
                keyValue: 143,
                column: "CreatedTime",
                value: new DateTime(2024, 9, 5, 11, 43, 57, 948, DateTimeKind.Local).AddTicks(4410));

            migrationBuilder.UpdateData(
                table: "Breeds",
                keyColumn: "Id",
                keyValue: 144,
                column: "CreatedTime",
                value: new DateTime(2024, 9, 5, 11, 43, 57, 948, DateTimeKind.Local).AddTicks(4420));

            migrationBuilder.UpdateData(
                table: "Breeds",
                keyColumn: "Id",
                keyValue: 145,
                column: "CreatedTime",
                value: new DateTime(2024, 9, 5, 11, 43, 57, 948, DateTimeKind.Local).AddTicks(4420));

            migrationBuilder.UpdateData(
                table: "Breeds",
                keyColumn: "Id",
                keyValue: 146,
                column: "CreatedTime",
                value: new DateTime(2024, 9, 5, 11, 43, 57, 948, DateTimeKind.Local).AddTicks(4420));

            migrationBuilder.UpdateData(
                table: "Breeds",
                keyColumn: "Id",
                keyValue: 147,
                column: "CreatedTime",
                value: new DateTime(2024, 9, 5, 11, 43, 57, 948, DateTimeKind.Local).AddTicks(4420));

            migrationBuilder.UpdateData(
                table: "Breeds",
                keyColumn: "Id",
                keyValue: 148,
                column: "CreatedTime",
                value: new DateTime(2024, 9, 5, 11, 43, 57, 948, DateTimeKind.Local).AddTicks(4420));

            migrationBuilder.UpdateData(
                table: "Breeds",
                keyColumn: "Id",
                keyValue: 149,
                column: "CreatedTime",
                value: new DateTime(2024, 9, 5, 11, 43, 57, 948, DateTimeKind.Local).AddTicks(4420));

            migrationBuilder.UpdateData(
                table: "Breeds",
                keyColumn: "Id",
                keyValue: 150,
                column: "CreatedTime",
                value: new DateTime(2024, 9, 5, 11, 43, 57, 948, DateTimeKind.Local).AddTicks(4420));

            migrationBuilder.UpdateData(
                table: "Breeds",
                keyColumn: "Id",
                keyValue: 151,
                column: "CreatedTime",
                value: new DateTime(2024, 9, 5, 11, 43, 57, 948, DateTimeKind.Local).AddTicks(4430));

            migrationBuilder.UpdateData(
                table: "Breeds",
                keyColumn: "Id",
                keyValue: 152,
                column: "CreatedTime",
                value: new DateTime(2024, 9, 5, 11, 43, 57, 948, DateTimeKind.Local).AddTicks(4430));

            migrationBuilder.UpdateData(
                table: "Breeds",
                keyColumn: "Id",
                keyValue: 153,
                column: "CreatedTime",
                value: new DateTime(2024, 9, 5, 11, 43, 57, 948, DateTimeKind.Local).AddTicks(4430));

            migrationBuilder.UpdateData(
                table: "Breeds",
                keyColumn: "Id",
                keyValue: 154,
                column: "CreatedTime",
                value: new DateTime(2024, 9, 5, 11, 43, 57, 948, DateTimeKind.Local).AddTicks(4430));

            migrationBuilder.UpdateData(
                table: "Breeds",
                keyColumn: "Id",
                keyValue: 155,
                column: "CreatedTime",
                value: new DateTime(2024, 9, 5, 11, 43, 57, 948, DateTimeKind.Local).AddTicks(4430));

            migrationBuilder.UpdateData(
                table: "Breeds",
                keyColumn: "Id",
                keyValue: 156,
                column: "CreatedTime",
                value: new DateTime(2024, 9, 5, 11, 43, 57, 948, DateTimeKind.Local).AddTicks(4430));

            migrationBuilder.UpdateData(
                table: "Breeds",
                keyColumn: "Id",
                keyValue: 157,
                column: "CreatedTime",
                value: new DateTime(2024, 9, 5, 11, 43, 57, 948, DateTimeKind.Local).AddTicks(4440));

            migrationBuilder.UpdateData(
                table: "Breeds",
                keyColumn: "Id",
                keyValue: 158,
                column: "CreatedTime",
                value: new DateTime(2024, 9, 5, 11, 43, 57, 948, DateTimeKind.Local).AddTicks(4440));

            migrationBuilder.UpdateData(
                table: "Breeds",
                keyColumn: "Id",
                keyValue: 159,
                column: "CreatedTime",
                value: new DateTime(2024, 9, 5, 11, 43, 57, 948, DateTimeKind.Local).AddTicks(4440));

            migrationBuilder.UpdateData(
                table: "Breeds",
                keyColumn: "Id",
                keyValue: 160,
                column: "CreatedTime",
                value: new DateTime(2024, 9, 5, 11, 43, 57, 948, DateTimeKind.Local).AddTicks(4440));

            migrationBuilder.UpdateData(
                table: "PetTypes",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedTime",
                value: new DateTime(2024, 9, 5, 11, 43, 57, 948, DateTimeKind.Local).AddTicks(3470));

            migrationBuilder.UpdateData(
                table: "PetTypes",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreatedTime",
                value: new DateTime(2024, 9, 5, 11, 43, 57, 948, DateTimeKind.Local).AddTicks(3470));

            migrationBuilder.UpdateData(
                table: "PetTypes",
                keyColumn: "Id",
                keyValue: 3,
                column: "CreatedTime",
                value: new DateTime(2024, 9, 5, 11, 43, 57, 948, DateTimeKind.Local).AddTicks(3470));

            migrationBuilder.UpdateData(
                table: "PetTypes",
                keyColumn: "Id",
                keyValue: 4,
                column: "CreatedTime",
                value: new DateTime(2024, 9, 5, 11, 43, 57, 948, DateTimeKind.Local).AddTicks(3470));

            migrationBuilder.UpdateData(
                table: "PetTypes",
                keyColumn: "Id",
                keyValue: 5,
                column: "CreatedTime",
                value: new DateTime(2024, 9, 5, 11, 43, 57, 948, DateTimeKind.Local).AddTicks(3470));

            migrationBuilder.UpdateData(
                table: "PetTypes",
                keyColumn: "Id",
                keyValue: 6,
                column: "CreatedTime",
                value: new DateTime(2024, 9, 5, 11, 43, 57, 948, DateTimeKind.Local).AddTicks(3480));

            migrationBuilder.UpdateData(
                table: "PetTypes",
                keyColumn: "Id",
                keyValue: 7,
                column: "CreatedTime",
                value: new DateTime(2024, 9, 5, 11, 43, 57, 948, DateTimeKind.Local).AddTicks(3480));

            migrationBuilder.UpdateData(
                table: "PetTypes",
                keyColumn: "Id",
                keyValue: 8,
                column: "CreatedTime",
                value: new DateTime(2024, 9, 5, 11, 43, 57, 948, DateTimeKind.Local).AddTicks(3480));

            migrationBuilder.UpdateData(
                table: "Pets",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedTime",
                value: new DateTime(2024, 9, 5, 11, 43, 57, 951, DateTimeKind.Local).AddTicks(5290));

            migrationBuilder.UpdateData(
                table: "Pets",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreatedTime",
                value: new DateTime(2024, 9, 5, 11, 43, 57, 951, DateTimeKind.Local).AddTicks(5300));

            migrationBuilder.UpdateData(
                table: "Pets",
                keyColumn: "Id",
                keyValue: 3,
                column: "CreatedTime",
                value: new DateTime(2024, 9, 5, 11, 43, 57, 951, DateTimeKind.Local).AddTicks(5310));

            migrationBuilder.UpdateData(
                table: "Pets",
                keyColumn: "Id",
                keyValue: 4,
                column: "CreatedTime",
                value: new DateTime(2024, 9, 5, 11, 43, 57, 951, DateTimeKind.Local).AddTicks(5310));

            migrationBuilder.UpdateData(
                table: "Pets",
                keyColumn: "Id",
                keyValue: 5,
                column: "CreatedTime",
                value: new DateTime(2024, 9, 5, 11, 43, 57, 951, DateTimeKind.Local).AddTicks(5310));

            migrationBuilder.UpdateData(
                table: "Pets",
                keyColumn: "Id",
                keyValue: 6,
                column: "CreatedTime",
                value: new DateTime(2024, 9, 5, 11, 43, 57, 951, DateTimeKind.Local).AddTicks(5320));

            migrationBuilder.UpdateData(
                table: "Pets",
                keyColumn: "Id",
                keyValue: 7,
                column: "CreatedTime",
                value: new DateTime(2024, 9, 5, 11, 43, 57, 951, DateTimeKind.Local).AddTicks(5320));

            migrationBuilder.UpdateData(
                table: "Pets",
                keyColumn: "Id",
                keyValue: 8,
                column: "CreatedTime",
                value: new DateTime(2024, 9, 5, 11, 43, 57, 951, DateTimeKind.Local).AddTicks(5320));

            migrationBuilder.UpdateData(
                table: "Pets",
                keyColumn: "Id",
                keyValue: 9,
                column: "CreatedTime",
                value: new DateTime(2024, 9, 5, 11, 43, 57, 951, DateTimeKind.Local).AddTicks(5330));

            migrationBuilder.UpdateData(
                table: "Pets",
                keyColumn: "Id",
                keyValue: 10,
                column: "CreatedTime",
                value: new DateTime(2024, 9, 5, 11, 43, 57, 951, DateTimeKind.Local).AddTicks(5330));

            migrationBuilder.UpdateData(
                table: "Pets",
                keyColumn: "Id",
                keyValue: 11,
                column: "CreatedTime",
                value: new DateTime(2024, 9, 5, 11, 43, 57, 951, DateTimeKind.Local).AddTicks(5340));

            migrationBuilder.UpdateData(
                table: "Pets",
                keyColumn: "Id",
                keyValue: 12,
                column: "CreatedTime",
                value: new DateTime(2024, 9, 5, 11, 43, 57, 951, DateTimeKind.Local).AddTicks(5340));

            migrationBuilder.UpdateData(
                table: "Pets",
                keyColumn: "Id",
                keyValue: 13,
                column: "CreatedTime",
                value: new DateTime(2024, 9, 5, 11, 43, 57, 951, DateTimeKind.Local).AddTicks(5350));

            migrationBuilder.UpdateData(
                table: "Pets",
                keyColumn: "Id",
                keyValue: 14,
                column: "CreatedTime",
                value: new DateTime(2024, 9, 5, 11, 43, 57, 951, DateTimeKind.Local).AddTicks(5350));

            migrationBuilder.UpdateData(
                table: "Pets",
                keyColumn: "Id",
                keyValue: 15,
                column: "CreatedTime",
                value: new DateTime(2024, 9, 5, 11, 43, 57, 951, DateTimeKind.Local).AddTicks(5350));

            migrationBuilder.UpdateData(
                table: "Pets",
                keyColumn: "Id",
                keyValue: 16,
                column: "CreatedTime",
                value: new DateTime(2024, 9, 5, 11, 43, 57, 951, DateTimeKind.Local).AddTicks(5360));

            migrationBuilder.UpdateData(
                table: "Pets",
                keyColumn: "Id",
                keyValue: 17,
                column: "CreatedTime",
                value: new DateTime(2024, 9, 5, 11, 43, 57, 951, DateTimeKind.Local).AddTicks(5360));

            migrationBuilder.UpdateData(
                table: "Pets",
                keyColumn: "Id",
                keyValue: 18,
                column: "CreatedTime",
                value: new DateTime(2024, 9, 5, 11, 43, 57, 951, DateTimeKind.Local).AddTicks(5360));

            migrationBuilder.UpdateData(
                table: "Pets",
                keyColumn: "Id",
                keyValue: 19,
                column: "CreatedTime",
                value: new DateTime(2024, 9, 5, 11, 43, 57, 951, DateTimeKind.Local).AddTicks(5370));

            migrationBuilder.UpdateData(
                table: "Pets",
                keyColumn: "Id",
                keyValue: 20,
                column: "CreatedTime",
                value: new DateTime(2024, 9, 5, 11, 43, 57, 951, DateTimeKind.Local).AddTicks(5370));

            migrationBuilder.UpdateData(
                table: "Pets",
                keyColumn: "Id",
                keyValue: 21,
                column: "CreatedTime",
                value: new DateTime(2024, 9, 5, 11, 43, 57, 951, DateTimeKind.Local).AddTicks(5370));

            migrationBuilder.UpdateData(
                table: "Pets",
                keyColumn: "Id",
                keyValue: 22,
                column: "CreatedTime",
                value: new DateTime(2024, 9, 5, 11, 43, 57, 951, DateTimeKind.Local).AddTicks(5380));

            migrationBuilder.UpdateData(
                table: "Pets",
                keyColumn: "Id",
                keyValue: 23,
                column: "CreatedTime",
                value: new DateTime(2024, 9, 5, 11, 43, 57, 951, DateTimeKind.Local).AddTicks(5380));

            migrationBuilder.UpdateData(
                table: "Pets",
                keyColumn: "Id",
                keyValue: 24,
                column: "CreatedTime",
                value: new DateTime(2024, 9, 5, 11, 43, 57, 951, DateTimeKind.Local).AddTicks(5380));

            migrationBuilder.UpdateData(
                table: "Pets",
                keyColumn: "Id",
                keyValue: 25,
                column: "CreatedTime",
                value: new DateTime(2024, 9, 5, 11, 43, 57, 951, DateTimeKind.Local).AddTicks(5390));

            migrationBuilder.UpdateData(
                table: "Pets",
                keyColumn: "Id",
                keyValue: 26,
                column: "CreatedTime",
                value: new DateTime(2024, 9, 5, 11, 43, 57, 951, DateTimeKind.Local).AddTicks(5390));

            migrationBuilder.UpdateData(
                table: "Pets",
                keyColumn: "Id",
                keyValue: 27,
                column: "CreatedTime",
                value: new DateTime(2024, 9, 5, 11, 43, 57, 951, DateTimeKind.Local).AddTicks(5390));

            migrationBuilder.UpdateData(
                table: "Pets",
                keyColumn: "Id",
                keyValue: 28,
                column: "CreatedTime",
                value: new DateTime(2024, 9, 5, 11, 43, 57, 951, DateTimeKind.Local).AddTicks(5400));

            migrationBuilder.UpdateData(
                table: "Pets",
                keyColumn: "Id",
                keyValue: 29,
                column: "CreatedTime",
                value: new DateTime(2024, 9, 5, 11, 43, 57, 951, DateTimeKind.Local).AddTicks(5400));

            migrationBuilder.UpdateData(
                table: "Pets",
                keyColumn: "Id",
                keyValue: 30,
                column: "CreatedTime",
                value: new DateTime(2024, 9, 5, 11, 43, 57, 951, DateTimeKind.Local).AddTicks(5400));

            migrationBuilder.UpdateData(
                table: "Pets",
                keyColumn: "Id",
                keyValue: 31,
                column: "CreatedTime",
                value: new DateTime(2024, 9, 5, 11, 43, 57, 951, DateTimeKind.Local).AddTicks(5410));

            migrationBuilder.UpdateData(
                table: "Pets",
                keyColumn: "Id",
                keyValue: 32,
                column: "CreatedTime",
                value: new DateTime(2024, 9, 5, 11, 43, 57, 951, DateTimeKind.Local).AddTicks(5410));

            migrationBuilder.UpdateData(
                table: "Pets",
                keyColumn: "Id",
                keyValue: 33,
                column: "CreatedTime",
                value: new DateTime(2024, 9, 5, 11, 43, 57, 951, DateTimeKind.Local).AddTicks(5410));

            migrationBuilder.UpdateData(
                table: "Pets",
                keyColumn: "Id",
                keyValue: 34,
                column: "CreatedTime",
                value: new DateTime(2024, 9, 5, 11, 43, 57, 951, DateTimeKind.Local).AddTicks(5420));

            migrationBuilder.UpdateData(
                table: "Pets",
                keyColumn: "Id",
                keyValue: 35,
                column: "CreatedTime",
                value: new DateTime(2024, 9, 5, 11, 43, 57, 951, DateTimeKind.Local).AddTicks(5420));

            migrationBuilder.UpdateData(
                table: "Pets",
                keyColumn: "Id",
                keyValue: 36,
                column: "CreatedTime",
                value: new DateTime(2024, 9, 5, 11, 43, 57, 951, DateTimeKind.Local).AddTicks(5420));

            migrationBuilder.UpdateData(
                table: "Pets",
                keyColumn: "Id",
                keyValue: 37,
                column: "CreatedTime",
                value: new DateTime(2024, 9, 5, 11, 43, 57, 951, DateTimeKind.Local).AddTicks(5420));

            migrationBuilder.UpdateData(
                table: "Pets",
                keyColumn: "Id",
                keyValue: 38,
                column: "CreatedTime",
                value: new DateTime(2024, 9, 5, 11, 43, 57, 951, DateTimeKind.Local).AddTicks(5430));

            migrationBuilder.UpdateData(
                table: "Pets",
                keyColumn: "Id",
                keyValue: 39,
                column: "CreatedTime",
                value: new DateTime(2024, 9, 5, 11, 43, 57, 951, DateTimeKind.Local).AddTicks(5430));

            migrationBuilder.UpdateData(
                table: "Pets",
                keyColumn: "Id",
                keyValue: 40,
                column: "CreatedTime",
                value: new DateTime(2024, 9, 5, 11, 43, 57, 951, DateTimeKind.Local).AddTicks(5430));

            migrationBuilder.UpdateData(
                table: "Pets",
                keyColumn: "Id",
                keyValue: 41,
                column: "CreatedTime",
                value: new DateTime(2024, 9, 5, 11, 43, 57, 951, DateTimeKind.Local).AddTicks(5440));

            migrationBuilder.UpdateData(
                table: "Pets",
                keyColumn: "Id",
                keyValue: 42,
                column: "CreatedTime",
                value: new DateTime(2024, 9, 5, 11, 43, 57, 951, DateTimeKind.Local).AddTicks(5440));

            migrationBuilder.UpdateData(
                table: "Pets",
                keyColumn: "Id",
                keyValue: 43,
                column: "CreatedTime",
                value: new DateTime(2024, 9, 5, 11, 43, 57, 951, DateTimeKind.Local).AddTicks(5440));

            migrationBuilder.UpdateData(
                table: "Pets",
                keyColumn: "Id",
                keyValue: 44,
                column: "CreatedTime",
                value: new DateTime(2024, 9, 5, 11, 43, 57, 951, DateTimeKind.Local).AddTicks(5450));

            migrationBuilder.UpdateData(
                table: "Pets",
                keyColumn: "Id",
                keyValue: 45,
                column: "CreatedTime",
                value: new DateTime(2024, 9, 5, 11, 43, 57, 951, DateTimeKind.Local).AddTicks(5450));

            migrationBuilder.UpdateData(
                table: "Pets",
                keyColumn: "Id",
                keyValue: 46,
                column: "CreatedTime",
                value: new DateTime(2024, 9, 5, 11, 43, 57, 951, DateTimeKind.Local).AddTicks(5450));

            migrationBuilder.UpdateData(
                table: "Pets",
                keyColumn: "Id",
                keyValue: 47,
                column: "CreatedTime",
                value: new DateTime(2024, 9, 5, 11, 43, 57, 951, DateTimeKind.Local).AddTicks(5460));

            migrationBuilder.UpdateData(
                table: "Pets",
                keyColumn: "Id",
                keyValue: 48,
                column: "CreatedTime",
                value: new DateTime(2024, 9, 5, 11, 43, 57, 951, DateTimeKind.Local).AddTicks(5460));

            migrationBuilder.UpdateData(
                table: "Pets",
                keyColumn: "Id",
                keyValue: 49,
                column: "CreatedTime",
                value: new DateTime(2024, 9, 5, 11, 43, 57, 951, DateTimeKind.Local).AddTicks(5460));

            migrationBuilder.UpdateData(
                table: "Pets",
                keyColumn: "Id",
                keyValue: 50,
                column: "CreatedTime",
                value: new DateTime(2024, 9, 5, 11, 43, 57, 951, DateTimeKind.Local).AddTicks(5470));

            migrationBuilder.UpdateData(
                table: "Shelters",
                keyColumn: "Id",
                keyValue: 1021,
                columns: new[] { "CreatedTime", "LastUpdatedTime" },
                values: new object[] { new DateTime(2024, 9, 5, 7, 43, 57, 948, DateTimeKind.Utc).AddTicks(3160), new DateTime(2024, 9, 5, 7, 43, 57, 948, DateTimeKind.Utc).AddTicks(3160) });

            migrationBuilder.UpdateData(
                table: "Shelters",
                keyColumn: "Id",
                keyValue: 1022,
                columns: new[] { "CreatedTime", "LastUpdatedTime" },
                values: new object[] { new DateTime(2024, 9, 5, 7, 43, 57, 948, DateTimeKind.Utc).AddTicks(3170), new DateTime(2024, 9, 5, 7, 43, 57, 948, DateTimeKind.Utc).AddTicks(3170) });

            migrationBuilder.UpdateData(
                table: "Shelters",
                keyColumn: "Id",
                keyValue: 1023,
                columns: new[] { "CreatedTime", "LastUpdatedTime" },
                values: new object[] { new DateTime(2024, 9, 5, 7, 43, 57, 948, DateTimeKind.Utc).AddTicks(3180), new DateTime(2024, 9, 5, 7, 43, 57, 948, DateTimeKind.Utc).AddTicks(3180) });

            migrationBuilder.UpdateData(
                table: "Shelters",
                keyColumn: "Id",
                keyValue: 1024,
                columns: new[] { "CreatedTime", "LastUpdatedTime" },
                values: new object[] { new DateTime(2024, 9, 5, 7, 43, 57, 948, DateTimeKind.Utc).AddTicks(3180), new DateTime(2024, 9, 5, 7, 43, 57, 948, DateTimeKind.Utc).AddTicks(3180) });

            migrationBuilder.UpdateData(
                table: "Shelters",
                keyColumn: "Id",
                keyValue: 1025,
                columns: new[] { "CreatedTime", "LastUpdatedTime" },
                values: new object[] { new DateTime(2024, 9, 5, 7, 43, 57, 948, DateTimeKind.Utc).AddTicks(3190), new DateTime(2024, 9, 5, 7, 43, 57, 948, DateTimeKind.Utc).AddTicks(3190) });

            migrationBuilder.UpdateData(
                table: "Shelters",
                keyColumn: "Id",
                keyValue: 1026,
                columns: new[] { "CreatedTime", "LastUpdatedTime" },
                values: new object[] { new DateTime(2024, 9, 5, 7, 43, 57, 948, DateTimeKind.Utc).AddTicks(3190), new DateTime(2024, 9, 5, 7, 43, 57, 948, DateTimeKind.Utc).AddTicks(3190) });

            migrationBuilder.UpdateData(
                table: "Shelters",
                keyColumn: "Id",
                keyValue: 1027,
                columns: new[] { "CreatedTime", "LastUpdatedTime" },
                values: new object[] { new DateTime(2024, 9, 5, 7, 43, 57, 948, DateTimeKind.Utc).AddTicks(3200), new DateTime(2024, 9, 5, 7, 43, 57, 948, DateTimeKind.Utc).AddTicks(3200) });

            migrationBuilder.UpdateData(
                table: "Shelters",
                keyColumn: "Id",
                keyValue: 1028,
                columns: new[] { "CreatedTime", "LastUpdatedTime" },
                values: new object[] { new DateTime(2024, 9, 5, 7, 43, 57, 948, DateTimeKind.Utc).AddTicks(3210), new DateTime(2024, 9, 5, 7, 43, 57, 948, DateTimeKind.Utc).AddTicks(3210) });

            migrationBuilder.UpdateData(
                table: "Shelters",
                keyColumn: "Id",
                keyValue: 1029,
                columns: new[] { "CreatedTime", "LastUpdatedTime" },
                values: new object[] { new DateTime(2024, 9, 5, 7, 43, 57, 948, DateTimeKind.Utc).AddTicks(3220), new DateTime(2024, 9, 5, 7, 43, 57, 948, DateTimeKind.Utc).AddTicks(3220) });

            migrationBuilder.UpdateData(
                table: "Shelters",
                keyColumn: "Id",
                keyValue: 1030,
                columns: new[] { "CreatedTime", "LastUpdatedTime" },
                values: new object[] { new DateTime(2024, 9, 5, 7, 43, 57, 948, DateTimeKind.Utc).AddTicks(3220), new DateTime(2024, 9, 5, 7, 43, 57, 948, DateTimeKind.Utc).AddTicks(3220) });

            migrationBuilder.UpdateData(
                table: "Shelters",
                keyColumn: "Id",
                keyValue: 1031,
                columns: new[] { "CreatedTime", "LastUpdatedTime" },
                values: new object[] { new DateTime(2024, 9, 5, 7, 43, 57, 948, DateTimeKind.Utc).AddTicks(3230), new DateTime(2024, 9, 5, 7, 43, 57, 948, DateTimeKind.Utc).AddTicks(3230) });

            migrationBuilder.UpdateData(
                table: "Shelters",
                keyColumn: "Id",
                keyValue: 1032,
                columns: new[] { "CreatedTime", "LastUpdatedTime" },
                values: new object[] { new DateTime(2024, 9, 5, 7, 43, 57, 948, DateTimeKind.Utc).AddTicks(3230), new DateTime(2024, 9, 5, 7, 43, 57, 948, DateTimeKind.Utc).AddTicks(3230) });

            migrationBuilder.UpdateData(
                table: "Shelters",
                keyColumn: "Id",
                keyValue: 1033,
                columns: new[] { "CreatedTime", "LastUpdatedTime" },
                values: new object[] { new DateTime(2024, 9, 5, 7, 43, 57, 948, DateTimeKind.Utc).AddTicks(3240), new DateTime(2024, 9, 5, 7, 43, 57, 948, DateTimeKind.Utc).AddTicks(3240) });

            migrationBuilder.UpdateData(
                table: "Shelters",
                keyColumn: "Id",
                keyValue: 1034,
                columns: new[] { "CreatedTime", "LastUpdatedTime" },
                values: new object[] { new DateTime(2024, 9, 5, 7, 43, 57, 948, DateTimeKind.Utc).AddTicks(3240), new DateTime(2024, 9, 5, 7, 43, 57, 948, DateTimeKind.Utc).AddTicks(3250) });

            migrationBuilder.UpdateData(
                table: "Shelters",
                keyColumn: "Id",
                keyValue: 1035,
                columns: new[] { "CreatedTime", "LastUpdatedTime" },
                values: new object[] { new DateTime(2024, 9, 5, 7, 43, 57, 948, DateTimeKind.Utc).AddTicks(3250), new DateTime(2024, 9, 5, 7, 43, 57, 948, DateTimeKind.Utc).AddTicks(3250) });

            migrationBuilder.UpdateData(
                table: "Shelters",
                keyColumn: "Id",
                keyValue: 1036,
                columns: new[] { "CreatedTime", "LastUpdatedTime" },
                values: new object[] { new DateTime(2024, 9, 5, 7, 43, 57, 948, DateTimeKind.Utc).AddTicks(3260), new DateTime(2024, 9, 5, 7, 43, 57, 948, DateTimeKind.Utc).AddTicks(3260) });

            migrationBuilder.UpdateData(
                table: "Shelters",
                keyColumn: "Id",
                keyValue: 1037,
                columns: new[] { "CreatedTime", "LastUpdatedTime" },
                values: new object[] { new DateTime(2024, 9, 5, 7, 43, 57, 948, DateTimeKind.Utc).AddTicks(3260), new DateTime(2024, 9, 5, 7, 43, 57, 948, DateTimeKind.Utc).AddTicks(3260) });

            migrationBuilder.UpdateData(
                table: "Shelters",
                keyColumn: "Id",
                keyValue: 1038,
                columns: new[] { "CreatedTime", "LastUpdatedTime" },
                values: new object[] { new DateTime(2024, 9, 5, 7, 43, 57, 948, DateTimeKind.Utc).AddTicks(3270), new DateTime(2024, 9, 5, 7, 43, 57, 948, DateTimeKind.Utc).AddTicks(3270) });

            migrationBuilder.UpdateData(
                table: "Shelters",
                keyColumn: "Id",
                keyValue: 1039,
                columns: new[] { "CreatedTime", "LastUpdatedTime" },
                values: new object[] { new DateTime(2024, 9, 5, 7, 43, 57, 948, DateTimeKind.Utc).AddTicks(3270), new DateTime(2024, 9, 5, 7, 43, 57, 948, DateTimeKind.Utc).AddTicks(3270) });

            migrationBuilder.UpdateData(
                table: "Shelters",
                keyColumn: "Id",
                keyValue: 1040,
                columns: new[] { "CreatedTime", "LastUpdatedTime" },
                values: new object[] { new DateTime(2024, 9, 5, 7, 43, 57, 948, DateTimeKind.Utc).AddTicks(3280), new DateTime(2024, 9, 5, 7, 43, 57, 948, DateTimeKind.Utc).AddTicks(3280) });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "isAccepted",
                table: "Adoptions");

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: 2001,
                columns: new[] { "ConcurrencyStamp", "CreatedTime", "LastUpdatedTime", "RefreshTokenCreateTime" },
                values: new object[] { "f3e48f13-b735-4ac3-9045-b89032139e2a", new DateTime(2024, 9, 2, 7, 3, 37, 11, DateTimeKind.Utc).AddTicks(8580), new DateTime(2024, 9, 2, 7, 3, 37, 11, DateTimeKind.Utc).AddTicks(8590), new DateTime(2024, 9, 2, 7, 3, 37, 11, DateTimeKind.Utc).AddTicks(8510) });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: 2002,
                columns: new[] { "ConcurrencyStamp", "CreatedTime", "LastUpdatedTime", "RefreshTokenCreateTime" },
                values: new object[] { "39f27a60-df46-495e-8d64-6d094a574ff0", new DateTime(2024, 9, 2, 7, 3, 37, 11, DateTimeKind.Utc).AddTicks(8610), new DateTime(2024, 9, 2, 7, 3, 37, 11, DateTimeKind.Utc).AddTicks(8610), new DateTime(2024, 9, 2, 7, 3, 37, 11, DateTimeKind.Utc).AddTicks(8610) });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: 2003,
                columns: new[] { "ConcurrencyStamp", "CreatedTime", "LastUpdatedTime", "RefreshTokenCreateTime" },
                values: new object[] { "44f8b95e-ea61-4895-afc1-d23edaa8b2f5", new DateTime(2024, 9, 2, 7, 3, 37, 11, DateTimeKind.Utc).AddTicks(8620), new DateTime(2024, 9, 2, 7, 3, 37, 11, DateTimeKind.Utc).AddTicks(8620), new DateTime(2024, 9, 2, 7, 3, 37, 11, DateTimeKind.Utc).AddTicks(8620) });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: 2004,
                columns: new[] { "ConcurrencyStamp", "CreatedTime", "LastUpdatedTime", "RefreshTokenCreateTime" },
                values: new object[] { "d8ba07dd-6d26-4079-85df-168b75f48a76", new DateTime(2024, 9, 2, 7, 3, 37, 11, DateTimeKind.Utc).AddTicks(8630), new DateTime(2024, 9, 2, 7, 3, 37, 11, DateTimeKind.Utc).AddTicks(8630), new DateTime(2024, 9, 2, 7, 3, 37, 11, DateTimeKind.Utc).AddTicks(8630) });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: 2005,
                columns: new[] { "ConcurrencyStamp", "CreatedTime", "LastUpdatedTime", "RefreshTokenCreateTime" },
                values: new object[] { "e9ef36fa-3fca-4ae7-b0bd-3d25d30f8702", new DateTime(2024, 9, 2, 7, 3, 37, 11, DateTimeKind.Utc).AddTicks(8640), new DateTime(2024, 9, 2, 7, 3, 37, 11, DateTimeKind.Utc).AddTicks(8640), new DateTime(2024, 9, 2, 7, 3, 37, 11, DateTimeKind.Utc).AddTicks(8640) });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: 2006,
                columns: new[] { "ConcurrencyStamp", "CreatedTime", "LastUpdatedTime", "RefreshTokenCreateTime" },
                values: new object[] { "7be362ab-b744-4560-ad38-9726df4e3606", new DateTime(2024, 9, 2, 7, 3, 37, 11, DateTimeKind.Utc).AddTicks(8650), new DateTime(2024, 9, 2, 7, 3, 37, 11, DateTimeKind.Utc).AddTicks(8650), new DateTime(2024, 9, 2, 7, 3, 37, 11, DateTimeKind.Utc).AddTicks(8650) });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: 2007,
                columns: new[] { "ConcurrencyStamp", "CreatedTime", "LastUpdatedTime", "RefreshTokenCreateTime" },
                values: new object[] { "ca60860b-b513-4de7-840c-61ece705abb5", new DateTime(2024, 9, 2, 7, 3, 37, 11, DateTimeKind.Utc).AddTicks(8660), new DateTime(2024, 9, 2, 7, 3, 37, 11, DateTimeKind.Utc).AddTicks(8660), new DateTime(2024, 9, 2, 7, 3, 37, 11, DateTimeKind.Utc).AddTicks(8650) });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: 2008,
                columns: new[] { "ConcurrencyStamp", "CreatedTime", "LastUpdatedTime", "RefreshTokenCreateTime" },
                values: new object[] { "b5af4c83-d16a-4348-916a-61683ad43657", new DateTime(2024, 9, 2, 7, 3, 37, 11, DateTimeKind.Utc).AddTicks(8670), new DateTime(2024, 9, 2, 7, 3, 37, 11, DateTimeKind.Utc).AddTicks(8670), new DateTime(2024, 9, 2, 7, 3, 37, 11, DateTimeKind.Utc).AddTicks(8660) });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: 2009,
                columns: new[] { "ConcurrencyStamp", "CreatedTime", "LastUpdatedTime", "RefreshTokenCreateTime" },
                values: new object[] { "519ba7c1-f5fc-4cb5-b331-a04a7c3d58ce", new DateTime(2024, 9, 2, 7, 3, 37, 11, DateTimeKind.Utc).AddTicks(8680), new DateTime(2024, 9, 2, 7, 3, 37, 11, DateTimeKind.Utc).AddTicks(8680), new DateTime(2024, 9, 2, 7, 3, 37, 11, DateTimeKind.Utc).AddTicks(8670) });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: 2010,
                columns: new[] { "ConcurrencyStamp", "CreatedTime", "LastUpdatedTime", "RefreshTokenCreateTime" },
                values: new object[] { "94e7803f-15ff-4134-b1ac-1173320548bf", new DateTime(2024, 9, 2, 7, 3, 37, 11, DateTimeKind.Utc).AddTicks(8700), new DateTime(2024, 9, 2, 7, 3, 37, 11, DateTimeKind.Utc).AddTicks(8700), new DateTime(2024, 9, 2, 7, 3, 37, 11, DateTimeKind.Utc).AddTicks(8700) });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: 2011,
                columns: new[] { "ConcurrencyStamp", "CreatedTime", "LastUpdatedTime", "RefreshTokenCreateTime" },
                values: new object[] { "5c512ba4-7a19-4c1a-bfc3-371cb026e8fc", new DateTime(2024, 9, 2, 7, 3, 37, 11, DateTimeKind.Utc).AddTicks(8710), new DateTime(2024, 9, 2, 7, 3, 37, 11, DateTimeKind.Utc).AddTicks(8710), new DateTime(2024, 9, 2, 7, 3, 37, 11, DateTimeKind.Utc).AddTicks(8710) });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: 2012,
                columns: new[] { "ConcurrencyStamp", "CreatedTime", "LastUpdatedTime", "RefreshTokenCreateTime" },
                values: new object[] { "6b1360a0-f1c8-4293-98f7-3aa370e70b5a", new DateTime(2024, 9, 2, 7, 3, 37, 11, DateTimeKind.Utc).AddTicks(8720), new DateTime(2024, 9, 2, 7, 3, 37, 11, DateTimeKind.Utc).AddTicks(8720), new DateTime(2024, 9, 2, 7, 3, 37, 11, DateTimeKind.Utc).AddTicks(8720) });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: 2013,
                columns: new[] { "ConcurrencyStamp", "CreatedTime", "LastUpdatedTime", "RefreshTokenCreateTime" },
                values: new object[] { "cf9dc367-c2a5-436e-9303-df5a889fc105", new DateTime(2024, 9, 2, 7, 3, 37, 11, DateTimeKind.Utc).AddTicks(8730), new DateTime(2024, 9, 2, 7, 3, 37, 11, DateTimeKind.Utc).AddTicks(8730), new DateTime(2024, 9, 2, 7, 3, 37, 11, DateTimeKind.Utc).AddTicks(8730) });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: 2014,
                columns: new[] { "ConcurrencyStamp", "CreatedTime", "LastUpdatedTime", "RefreshTokenCreateTime" },
                values: new object[] { "6ed9d688-c2f0-4b1a-ba97-6e87e30fc518", new DateTime(2024, 9, 2, 7, 3, 37, 11, DateTimeKind.Utc).AddTicks(8740), new DateTime(2024, 9, 2, 7, 3, 37, 11, DateTimeKind.Utc).AddTicks(8740), new DateTime(2024, 9, 2, 7, 3, 37, 11, DateTimeKind.Utc).AddTicks(8740) });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: 2015,
                columns: new[] { "ConcurrencyStamp", "CreatedTime", "LastUpdatedTime", "RefreshTokenCreateTime" },
                values: new object[] { "6d4fafb6-09c4-42f7-9358-ddf721322a3d", new DateTime(2024, 9, 2, 7, 3, 37, 11, DateTimeKind.Utc).AddTicks(8750), new DateTime(2024, 9, 2, 7, 3, 37, 11, DateTimeKind.Utc).AddTicks(8750), new DateTime(2024, 9, 2, 7, 3, 37, 11, DateTimeKind.Utc).AddTicks(8750) });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: 2016,
                columns: new[] { "ConcurrencyStamp", "CreatedTime", "LastUpdatedTime", "RefreshTokenCreateTime" },
                values: new object[] { "ba24cfbd-3b6e-432f-a6e0-1383497fd32f", new DateTime(2024, 9, 2, 7, 3, 37, 11, DateTimeKind.Utc).AddTicks(8760), new DateTime(2024, 9, 2, 7, 3, 37, 11, DateTimeKind.Utc).AddTicks(8760), new DateTime(2024, 9, 2, 7, 3, 37, 11, DateTimeKind.Utc).AddTicks(8760) });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: 2017,
                columns: new[] { "ConcurrencyStamp", "CreatedTime", "LastUpdatedTime", "RefreshTokenCreateTime" },
                values: new object[] { "417a8e97-a06b-4421-9a0a-d4648302244c", new DateTime(2024, 9, 2, 7, 3, 37, 11, DateTimeKind.Utc).AddTicks(8770), new DateTime(2024, 9, 2, 7, 3, 37, 11, DateTimeKind.Utc).AddTicks(8770), new DateTime(2024, 9, 2, 7, 3, 37, 11, DateTimeKind.Utc).AddTicks(8760) });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: 2018,
                columns: new[] { "ConcurrencyStamp", "CreatedTime", "LastUpdatedTime", "RefreshTokenCreateTime" },
                values: new object[] { "364ef30f-0312-4d37-a481-28792e3eb294", new DateTime(2024, 9, 2, 7, 3, 37, 11, DateTimeKind.Utc).AddTicks(8780), new DateTime(2024, 9, 2, 7, 3, 37, 11, DateTimeKind.Utc).AddTicks(8780), new DateTime(2024, 9, 2, 7, 3, 37, 11, DateTimeKind.Utc).AddTicks(8770) });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: 2019,
                columns: new[] { "ConcurrencyStamp", "CreatedTime", "LastUpdatedTime", "RefreshTokenCreateTime" },
                values: new object[] { "d20b87fe-dac0-42ce-805b-a7d799fe9848", new DateTime(2024, 9, 2, 7, 3, 37, 11, DateTimeKind.Utc).AddTicks(8790), new DateTime(2024, 9, 2, 7, 3, 37, 11, DateTimeKind.Utc).AddTicks(8790), new DateTime(2024, 9, 2, 7, 3, 37, 11, DateTimeKind.Utc).AddTicks(8780) });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: 2020,
                columns: new[] { "ConcurrencyStamp", "CreatedTime", "LastUpdatedTime", "RefreshTokenCreateTime" },
                values: new object[] { "c564770e-fbf8-42b8-94b3-e673440e51d1", new DateTime(2024, 9, 2, 7, 3, 37, 11, DateTimeKind.Utc).AddTicks(8800), new DateTime(2024, 9, 2, 7, 3, 37, 11, DateTimeKind.Utc).AddTicks(8800), new DateTime(2024, 9, 2, 7, 3, 37, 11, DateTimeKind.Utc).AddTicks(8800) });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: 2021,
                columns: new[] { "ConcurrencyStamp", "CreatedTime", "LastUpdatedTime", "RefreshTokenCreateTime" },
                values: new object[] { "978a0b65-19a7-4fd9-a71b-61ae923abae4", new DateTime(2024, 9, 2, 7, 3, 37, 11, DateTimeKind.Utc).AddTicks(8810), new DateTime(2024, 9, 2, 7, 3, 37, 11, DateTimeKind.Utc).AddTicks(8810), new DateTime(2024, 9, 2, 7, 3, 37, 11, DateTimeKind.Utc).AddTicks(8810) });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: 2022,
                columns: new[] { "ConcurrencyStamp", "CreatedTime", "LastUpdatedTime", "RefreshTokenCreateTime" },
                values: new object[] { "aa712df6-3420-4e25-8c33-7a5076b345de", new DateTime(2024, 9, 2, 7, 3, 37, 11, DateTimeKind.Utc).AddTicks(8830), new DateTime(2024, 9, 2, 7, 3, 37, 11, DateTimeKind.Utc).AddTicks(8830), new DateTime(2024, 9, 2, 7, 3, 37, 11, DateTimeKind.Utc).AddTicks(8820) });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: 2023,
                columns: new[] { "ConcurrencyStamp", "CreatedTime", "LastUpdatedTime", "RefreshTokenCreateTime" },
                values: new object[] { "eace3fd3-dee3-4ed1-ac8d-cc72ef0c1378", new DateTime(2024, 9, 2, 7, 3, 37, 11, DateTimeKind.Utc).AddTicks(8840), new DateTime(2024, 9, 2, 7, 3, 37, 11, DateTimeKind.Utc).AddTicks(8840), new DateTime(2024, 9, 2, 7, 3, 37, 11, DateTimeKind.Utc).AddTicks(8830) });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: 2024,
                columns: new[] { "ConcurrencyStamp", "CreatedTime", "LastUpdatedTime", "RefreshTokenCreateTime" },
                values: new object[] { "2027deed-2052-420e-aff8-9112c9d620ad", new DateTime(2024, 9, 2, 7, 3, 37, 11, DateTimeKind.Utc).AddTicks(8850), new DateTime(2024, 9, 2, 7, 3, 37, 11, DateTimeKind.Utc).AddTicks(8850), new DateTime(2024, 9, 2, 7, 3, 37, 11, DateTimeKind.Utc).AddTicks(8840) });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: 2025,
                columns: new[] { "ConcurrencyStamp", "CreatedTime", "LastUpdatedTime", "RefreshTokenCreateTime" },
                values: new object[] { "0bc69a9e-3bc0-4f44-b0d1-5b8d5a938a41", new DateTime(2024, 9, 2, 7, 3, 37, 11, DateTimeKind.Utc).AddTicks(8860), new DateTime(2024, 9, 2, 7, 3, 37, 11, DateTimeKind.Utc).AddTicks(8860), new DateTime(2024, 9, 2, 7, 3, 37, 11, DateTimeKind.Utc).AddTicks(8850) });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: 2026,
                columns: new[] { "ConcurrencyStamp", "CreatedTime", "LastUpdatedTime", "RefreshTokenCreateTime" },
                values: new object[] { "096dae24-c739-4e0a-9fb2-7450201116a3", new DateTime(2024, 9, 2, 7, 3, 37, 11, DateTimeKind.Utc).AddTicks(8870), new DateTime(2024, 9, 2, 7, 3, 37, 11, DateTimeKind.Utc).AddTicks(8870), new DateTime(2024, 9, 2, 7, 3, 37, 11, DateTimeKind.Utc).AddTicks(8860) });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: 2027,
                columns: new[] { "ConcurrencyStamp", "CreatedTime", "LastUpdatedTime", "RefreshTokenCreateTime" },
                values: new object[] { "bcc7e215-2f29-4d4f-859f-08edb2491e75", new DateTime(2024, 9, 2, 7, 3, 37, 11, DateTimeKind.Utc).AddTicks(8870), new DateTime(2024, 9, 2, 7, 3, 37, 11, DateTimeKind.Utc).AddTicks(8880), new DateTime(2024, 9, 2, 7, 3, 37, 11, DateTimeKind.Utc).AddTicks(8870) });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: 2028,
                columns: new[] { "ConcurrencyStamp", "CreatedTime", "LastUpdatedTime", "RefreshTokenCreateTime" },
                values: new object[] { "ec410d64-23ea-475c-8845-69c586b212e4", new DateTime(2024, 9, 2, 7, 3, 37, 11, DateTimeKind.Utc).AddTicks(8880), new DateTime(2024, 9, 2, 7, 3, 37, 11, DateTimeKind.Utc).AddTicks(8880), new DateTime(2024, 9, 2, 7, 3, 37, 11, DateTimeKind.Utc).AddTicks(8880) });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: 2029,
                columns: new[] { "ConcurrencyStamp", "CreatedTime", "LastUpdatedTime", "RefreshTokenCreateTime" },
                values: new object[] { "025131f5-c723-4ef7-9d12-dfdaa91d1bba", new DateTime(2024, 9, 2, 7, 3, 37, 11, DateTimeKind.Utc).AddTicks(8910), new DateTime(2024, 9, 2, 7, 3, 37, 11, DateTimeKind.Utc).AddTicks(8910), new DateTime(2024, 9, 2, 7, 3, 37, 11, DateTimeKind.Utc).AddTicks(8910) });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: 2030,
                columns: new[] { "ConcurrencyStamp", "CreatedTime", "LastUpdatedTime", "RefreshTokenCreateTime" },
                values: new object[] { "7bdaa9d6-5bff-40d8-9d98-1e0696653b0b", new DateTime(2024, 9, 2, 7, 3, 37, 11, DateTimeKind.Utc).AddTicks(8920), new DateTime(2024, 9, 2, 7, 3, 37, 11, DateTimeKind.Utc).AddTicks(8920), new DateTime(2024, 9, 2, 7, 3, 37, 11, DateTimeKind.Utc).AddTicks(8920) });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: 2031,
                columns: new[] { "ConcurrencyStamp", "CreatedTime", "LastUpdatedTime", "RefreshTokenCreateTime" },
                values: new object[] { "c5548280-ec31-4d15-9c8a-98cf5314d328", new DateTime(2024, 9, 2, 7, 3, 37, 11, DateTimeKind.Utc).AddTicks(8930), new DateTime(2024, 9, 2, 7, 3, 37, 11, DateTimeKind.Utc).AddTicks(8930), new DateTime(2024, 9, 2, 7, 3, 37, 11, DateTimeKind.Utc).AddTicks(8930) });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: 2032,
                columns: new[] { "ConcurrencyStamp", "CreatedTime", "LastUpdatedTime", "RefreshTokenCreateTime" },
                values: new object[] { "305353cb-0b9d-4a1e-954b-3933999ca6cb", new DateTime(2024, 9, 2, 7, 3, 37, 11, DateTimeKind.Utc).AddTicks(8940), new DateTime(2024, 9, 2, 7, 3, 37, 11, DateTimeKind.Utc).AddTicks(8940), new DateTime(2024, 9, 2, 7, 3, 37, 11, DateTimeKind.Utc).AddTicks(8930) });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: 2033,
                columns: new[] { "ConcurrencyStamp", "CreatedTime", "LastUpdatedTime", "RefreshTokenCreateTime" },
                values: new object[] { "14934281-85bb-407b-9460-0688f87032a9", new DateTime(2024, 9, 2, 7, 3, 37, 11, DateTimeKind.Utc).AddTicks(8950), new DateTime(2024, 9, 2, 7, 3, 37, 11, DateTimeKind.Utc).AddTicks(8950), new DateTime(2024, 9, 2, 7, 3, 37, 11, DateTimeKind.Utc).AddTicks(8940) });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: 2034,
                columns: new[] { "ConcurrencyStamp", "CreatedTime", "LastUpdatedTime", "RefreshTokenCreateTime" },
                values: new object[] { "0a996334-407a-44b2-91fd-bd60ebee0932", new DateTime(2024, 9, 2, 7, 3, 37, 11, DateTimeKind.Utc).AddTicks(8960), new DateTime(2024, 9, 2, 7, 3, 37, 11, DateTimeKind.Utc).AddTicks(8960), new DateTime(2024, 9, 2, 7, 3, 37, 11, DateTimeKind.Utc).AddTicks(8960) });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: 2035,
                columns: new[] { "ConcurrencyStamp", "CreatedTime", "LastUpdatedTime", "RefreshTokenCreateTime" },
                values: new object[] { "4c7b33f6-ef6a-485b-88f7-0ac1b4c103bc", new DateTime(2024, 9, 2, 7, 3, 37, 11, DateTimeKind.Utc).AddTicks(8970), new DateTime(2024, 9, 2, 7, 3, 37, 11, DateTimeKind.Utc).AddTicks(8970), new DateTime(2024, 9, 2, 7, 3, 37, 11, DateTimeKind.Utc).AddTicks(8970) });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: 2036,
                columns: new[] { "ConcurrencyStamp", "CreatedTime", "LastUpdatedTime", "RefreshTokenCreateTime" },
                values: new object[] { "464ed662-50a8-4140-85b7-bf6718376f62", new DateTime(2024, 9, 2, 7, 3, 37, 11, DateTimeKind.Utc).AddTicks(8980), new DateTime(2024, 9, 2, 7, 3, 37, 11, DateTimeKind.Utc).AddTicks(8980), new DateTime(2024, 9, 2, 7, 3, 37, 11, DateTimeKind.Utc).AddTicks(8980) });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: 2037,
                columns: new[] { "ConcurrencyStamp", "CreatedTime", "LastUpdatedTime", "RefreshTokenCreateTime" },
                values: new object[] { "ff4e2b7b-a4d5-4826-bd44-16932f0d788d", new DateTime(2024, 9, 2, 7, 3, 37, 11, DateTimeKind.Utc).AddTicks(8990), new DateTime(2024, 9, 2, 7, 3, 37, 11, DateTimeKind.Utc).AddTicks(8990), new DateTime(2024, 9, 2, 7, 3, 37, 11, DateTimeKind.Utc).AddTicks(8990) });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: 2038,
                columns: new[] { "ConcurrencyStamp", "CreatedTime", "LastUpdatedTime", "RefreshTokenCreateTime" },
                values: new object[] { "7c48fa24-596d-430f-b8f4-779f35586b8e", new DateTime(2024, 9, 2, 7, 3, 37, 11, DateTimeKind.Utc).AddTicks(9000), new DateTime(2024, 9, 2, 7, 3, 37, 11, DateTimeKind.Utc).AddTicks(9000), new DateTime(2024, 9, 2, 7, 3, 37, 11, DateTimeKind.Utc).AddTicks(9000) });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: 2039,
                columns: new[] { "ConcurrencyStamp", "CreatedTime", "LastUpdatedTime", "RefreshTokenCreateTime" },
                values: new object[] { "eb7c76c6-dbfa-4b25-9720-9ca81a622018", new DateTime(2024, 9, 2, 7, 3, 37, 11, DateTimeKind.Utc).AddTicks(9010), new DateTime(2024, 9, 2, 7, 3, 37, 11, DateTimeKind.Utc).AddTicks(9010), new DateTime(2024, 9, 2, 7, 3, 37, 11, DateTimeKind.Utc).AddTicks(9010) });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: 2040,
                columns: new[] { "ConcurrencyStamp", "CreatedTime", "LastUpdatedTime", "RefreshTokenCreateTime" },
                values: new object[] { "8506b2e1-5b74-488e-a959-b9ec85fbb1e6", new DateTime(2024, 9, 2, 7, 3, 37, 11, DateTimeKind.Utc).AddTicks(9020), new DateTime(2024, 9, 2, 7, 3, 37, 11, DateTimeKind.Utc).AddTicks(9020), new DateTime(2024, 9, 2, 7, 3, 37, 11, DateTimeKind.Utc).AddTicks(9020) });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: 2041,
                columns: new[] { "ConcurrencyStamp", "CreatedTime", "LastUpdatedTime", "RefreshTokenCreateTime" },
                values: new object[] { "42209b7f-9083-4f5f-b780-6d191d19fd95", new DateTime(2024, 9, 2, 7, 3, 37, 11, DateTimeKind.Utc).AddTicks(9030), new DateTime(2024, 9, 2, 7, 3, 37, 11, DateTimeKind.Utc).AddTicks(9030), new DateTime(2024, 9, 2, 7, 3, 37, 11, DateTimeKind.Utc).AddTicks(9030) });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: 2042,
                columns: new[] { "ConcurrencyStamp", "CreatedTime", "LastUpdatedTime", "RefreshTokenCreateTime" },
                values: new object[] { "cae37af2-5a79-4227-98c1-af2041186d5e", new DateTime(2024, 9, 2, 7, 3, 37, 11, DateTimeKind.Utc).AddTicks(9040), new DateTime(2024, 9, 2, 7, 3, 37, 11, DateTimeKind.Utc).AddTicks(9040), new DateTime(2024, 9, 2, 7, 3, 37, 11, DateTimeKind.Utc).AddTicks(9040) });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: 2043,
                columns: new[] { "ConcurrencyStamp", "CreatedTime", "LastUpdatedTime", "RefreshTokenCreateTime" },
                values: new object[] { "4f54a637-2dba-4cbd-95ad-7ce5d3810ccc", new DateTime(2024, 9, 2, 7, 3, 37, 11, DateTimeKind.Utc).AddTicks(9050), new DateTime(2024, 9, 2, 7, 3, 37, 11, DateTimeKind.Utc).AddTicks(9050), new DateTime(2024, 9, 2, 7, 3, 37, 11, DateTimeKind.Utc).AddTicks(9050) });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: 2044,
                columns: new[] { "ConcurrencyStamp", "CreatedTime", "LastUpdatedTime", "RefreshTokenCreateTime" },
                values: new object[] { "79e7f8bd-b0f4-4eed-a3d2-2f743d21646b", new DateTime(2024, 9, 2, 7, 3, 37, 11, DateTimeKind.Utc).AddTicks(9060), new DateTime(2024, 9, 2, 7, 3, 37, 11, DateTimeKind.Utc).AddTicks(9060), new DateTime(2024, 9, 2, 7, 3, 37, 11, DateTimeKind.Utc).AddTicks(9060) });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: 2045,
                columns: new[] { "ConcurrencyStamp", "CreatedTime", "LastUpdatedTime", "RefreshTokenCreateTime" },
                values: new object[] { "bb8429f1-a8e1-4020-b380-907dd20b6e7a", new DateTime(2024, 9, 2, 7, 3, 37, 11, DateTimeKind.Utc).AddTicks(9070), new DateTime(2024, 9, 2, 7, 3, 37, 11, DateTimeKind.Utc).AddTicks(9070), new DateTime(2024, 9, 2, 7, 3, 37, 11, DateTimeKind.Utc).AddTicks(9070) });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: 2046,
                columns: new[] { "ConcurrencyStamp", "CreatedTime", "LastUpdatedTime", "RefreshTokenCreateTime" },
                values: new object[] { "1dd02562-0a5d-442d-8a3c-07f65ed24e4f", new DateTime(2024, 9, 2, 7, 3, 37, 11, DateTimeKind.Utc).AddTicks(9120), new DateTime(2024, 9, 2, 7, 3, 37, 11, DateTimeKind.Utc).AddTicks(9120), new DateTime(2024, 9, 2, 7, 3, 37, 11, DateTimeKind.Utc).AddTicks(9120) });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: 2047,
                columns: new[] { "ConcurrencyStamp", "CreatedTime", "LastUpdatedTime", "RefreshTokenCreateTime" },
                values: new object[] { "ab5bf545-4e2c-4b45-9b3e-2e7d36ab7841", new DateTime(2024, 9, 2, 7, 3, 37, 11, DateTimeKind.Utc).AddTicks(9130), new DateTime(2024, 9, 2, 7, 3, 37, 11, DateTimeKind.Utc).AddTicks(9130), new DateTime(2024, 9, 2, 7, 3, 37, 11, DateTimeKind.Utc).AddTicks(9130) });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: 2048,
                columns: new[] { "ConcurrencyStamp", "CreatedTime", "LastUpdatedTime", "RefreshTokenCreateTime" },
                values: new object[] { "232d1d52-dbd6-4bb6-a33d-86b29d0c47ea", new DateTime(2024, 9, 2, 7, 3, 37, 11, DateTimeKind.Utc).AddTicks(9140), new DateTime(2024, 9, 2, 7, 3, 37, 11, DateTimeKind.Utc).AddTicks(9140), new DateTime(2024, 9, 2, 7, 3, 37, 11, DateTimeKind.Utc).AddTicks(9140) });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: 2049,
                columns: new[] { "ConcurrencyStamp", "CreatedTime", "LastUpdatedTime", "RefreshTokenCreateTime" },
                values: new object[] { "0a1c2e1b-06c6-41d7-a4ea-f1cec768b0d0", new DateTime(2024, 9, 2, 7, 3, 37, 11, DateTimeKind.Utc).AddTicks(9150), new DateTime(2024, 9, 2, 7, 3, 37, 11, DateTimeKind.Utc).AddTicks(9150), new DateTime(2024, 9, 2, 7, 3, 37, 11, DateTimeKind.Utc).AddTicks(9150) });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: 2050,
                columns: new[] { "ConcurrencyStamp", "CreatedTime", "LastUpdatedTime", "RefreshTokenCreateTime" },
                values: new object[] { "fa09705e-cf7c-4814-b63c-ff955eccead4", new DateTime(2024, 9, 2, 7, 3, 37, 11, DateTimeKind.Utc).AddTicks(9160), new DateTime(2024, 9, 2, 7, 3, 37, 11, DateTimeKind.Utc).AddTicks(9160), new DateTime(2024, 9, 2, 7, 3, 37, 11, DateTimeKind.Utc).AddTicks(9160) });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: 2051,
                columns: new[] { "ConcurrencyStamp", "CreatedTime", "LastUpdatedTime", "RefreshTokenCreateTime" },
                values: new object[] { "fb78a25f-e18f-4904-aa06-644927085097", new DateTime(2024, 9, 2, 7, 3, 37, 11, DateTimeKind.Utc).AddTicks(9170), new DateTime(2024, 9, 2, 7, 3, 37, 11, DateTimeKind.Utc).AddTicks(9170), new DateTime(2024, 9, 2, 7, 3, 37, 11, DateTimeKind.Utc).AddTicks(9170) });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: 2052,
                columns: new[] { "ConcurrencyStamp", "CreatedTime", "LastUpdatedTime", "RefreshTokenCreateTime" },
                values: new object[] { "ba09e513-4157-4162-b045-901a9778e2d3", new DateTime(2024, 9, 2, 7, 3, 37, 11, DateTimeKind.Utc).AddTicks(9180), new DateTime(2024, 9, 2, 7, 3, 37, 11, DateTimeKind.Utc).AddTicks(9180), new DateTime(2024, 9, 2, 7, 3, 37, 11, DateTimeKind.Utc).AddTicks(9180) });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: 2053,
                columns: new[] { "ConcurrencyStamp", "CreatedTime", "LastUpdatedTime", "RefreshTokenCreateTime" },
                values: new object[] { "6a263b41-be7e-4bf0-802a-630b358188c6", new DateTime(2024, 9, 2, 7, 3, 37, 11, DateTimeKind.Utc).AddTicks(9190), new DateTime(2024, 9, 2, 7, 3, 37, 11, DateTimeKind.Utc).AddTicks(9190), new DateTime(2024, 9, 2, 7, 3, 37, 11, DateTimeKind.Utc).AddTicks(9190) });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: 2054,
                columns: new[] { "ConcurrencyStamp", "CreatedTime", "LastUpdatedTime", "RefreshTokenCreateTime" },
                values: new object[] { "1094b798-fa3b-4e38-922f-8ec581b5aed3", new DateTime(2024, 9, 2, 7, 3, 37, 11, DateTimeKind.Utc).AddTicks(9200), new DateTime(2024, 9, 2, 7, 3, 37, 11, DateTimeKind.Utc).AddTicks(9200), new DateTime(2024, 9, 2, 7, 3, 37, 11, DateTimeKind.Utc).AddTicks(9200) });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: 2055,
                columns: new[] { "ConcurrencyStamp", "CreatedTime", "LastUpdatedTime", "RefreshTokenCreateTime" },
                values: new object[] { "5352fb8c-a893-42ee-89e0-ea1660b3ed3a", new DateTime(2024, 9, 2, 7, 3, 37, 11, DateTimeKind.Utc).AddTicks(9210), new DateTime(2024, 9, 2, 7, 3, 37, 11, DateTimeKind.Utc).AddTicks(9210), new DateTime(2024, 9, 2, 7, 3, 37, 11, DateTimeKind.Utc).AddTicks(9210) });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: 2056,
                columns: new[] { "ConcurrencyStamp", "CreatedTime", "LastUpdatedTime", "RefreshTokenCreateTime" },
                values: new object[] { "b4a43496-f2b1-40f1-bc95-05233a52bbe1", new DateTime(2024, 9, 2, 7, 3, 37, 11, DateTimeKind.Utc).AddTicks(9240), new DateTime(2024, 9, 2, 7, 3, 37, 11, DateTimeKind.Utc).AddTicks(9240), new DateTime(2024, 9, 2, 7, 3, 37, 11, DateTimeKind.Utc).AddTicks(9210) });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: 2057,
                columns: new[] { "ConcurrencyStamp", "CreatedTime", "LastUpdatedTime", "RefreshTokenCreateTime" },
                values: new object[] { "bdcc7d99-4dd5-4235-9b88-d707419eaf97", new DateTime(2024, 9, 2, 7, 3, 37, 11, DateTimeKind.Utc).AddTicks(9250), new DateTime(2024, 9, 2, 7, 3, 37, 11, DateTimeKind.Utc).AddTicks(9250), new DateTime(2024, 9, 2, 7, 3, 37, 11, DateTimeKind.Utc).AddTicks(9240) });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: 2058,
                columns: new[] { "ConcurrencyStamp", "CreatedTime", "LastUpdatedTime", "RefreshTokenCreateTime" },
                values: new object[] { "93aabf6f-eaaa-4b21-96d8-157ffd59f170", new DateTime(2024, 9, 2, 7, 3, 37, 11, DateTimeKind.Utc).AddTicks(9260), new DateTime(2024, 9, 2, 7, 3, 37, 11, DateTimeKind.Utc).AddTicks(9260), new DateTime(2024, 9, 2, 7, 3, 37, 11, DateTimeKind.Utc).AddTicks(9250) });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: 2059,
                columns: new[] { "ConcurrencyStamp", "CreatedTime", "LastUpdatedTime", "RefreshTokenCreateTime" },
                values: new object[] { "291da51b-f969-4b62-b33a-6e4297bc341e", new DateTime(2024, 9, 2, 7, 3, 37, 11, DateTimeKind.Utc).AddTicks(9260), new DateTime(2024, 9, 2, 7, 3, 37, 11, DateTimeKind.Utc).AddTicks(9270), new DateTime(2024, 9, 2, 7, 3, 37, 11, DateTimeKind.Utc).AddTicks(9260) });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: 2060,
                columns: new[] { "ConcurrencyStamp", "CreatedTime", "LastUpdatedTime", "RefreshTokenCreateTime" },
                values: new object[] { "5291a817-35c7-46dd-805a-ffa493546f56", new DateTime(2024, 9, 2, 7, 3, 37, 11, DateTimeKind.Utc).AddTicks(9270), new DateTime(2024, 9, 2, 7, 3, 37, 11, DateTimeKind.Utc).AddTicks(9270), new DateTime(2024, 9, 2, 7, 3, 37, 11, DateTimeKind.Utc).AddTicks(9270) });

            migrationBuilder.UpdateData(
                table: "Breeds",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedTime",
                value: new DateTime(2024, 9, 2, 11, 3, 37, 8, DateTimeKind.Local).AddTicks(9400));

            migrationBuilder.UpdateData(
                table: "Breeds",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreatedTime",
                value: new DateTime(2024, 9, 2, 11, 3, 37, 8, DateTimeKind.Local).AddTicks(9410));

            migrationBuilder.UpdateData(
                table: "Breeds",
                keyColumn: "Id",
                keyValue: 3,
                column: "CreatedTime",
                value: new DateTime(2024, 9, 2, 11, 3, 37, 8, DateTimeKind.Local).AddTicks(9410));

            migrationBuilder.UpdateData(
                table: "Breeds",
                keyColumn: "Id",
                keyValue: 4,
                column: "CreatedTime",
                value: new DateTime(2024, 9, 2, 11, 3, 37, 8, DateTimeKind.Local).AddTicks(9410));

            migrationBuilder.UpdateData(
                table: "Breeds",
                keyColumn: "Id",
                keyValue: 5,
                column: "CreatedTime",
                value: new DateTime(2024, 9, 2, 11, 3, 37, 8, DateTimeKind.Local).AddTicks(9410));

            migrationBuilder.UpdateData(
                table: "Breeds",
                keyColumn: "Id",
                keyValue: 6,
                column: "CreatedTime",
                value: new DateTime(2024, 9, 2, 11, 3, 37, 8, DateTimeKind.Local).AddTicks(9410));

            migrationBuilder.UpdateData(
                table: "Breeds",
                keyColumn: "Id",
                keyValue: 7,
                column: "CreatedTime",
                value: new DateTime(2024, 9, 2, 11, 3, 37, 8, DateTimeKind.Local).AddTicks(9420));

            migrationBuilder.UpdateData(
                table: "Breeds",
                keyColumn: "Id",
                keyValue: 8,
                column: "CreatedTime",
                value: new DateTime(2024, 9, 2, 11, 3, 37, 8, DateTimeKind.Local).AddTicks(9420));

            migrationBuilder.UpdateData(
                table: "Breeds",
                keyColumn: "Id",
                keyValue: 9,
                column: "CreatedTime",
                value: new DateTime(2024, 9, 2, 11, 3, 37, 8, DateTimeKind.Local).AddTicks(9420));

            migrationBuilder.UpdateData(
                table: "Breeds",
                keyColumn: "Id",
                keyValue: 10,
                column: "CreatedTime",
                value: new DateTime(2024, 9, 2, 11, 3, 37, 8, DateTimeKind.Local).AddTicks(9420));

            migrationBuilder.UpdateData(
                table: "Breeds",
                keyColumn: "Id",
                keyValue: 11,
                column: "CreatedTime",
                value: new DateTime(2024, 9, 2, 11, 3, 37, 8, DateTimeKind.Local).AddTicks(9420));

            migrationBuilder.UpdateData(
                table: "Breeds",
                keyColumn: "Id",
                keyValue: 12,
                column: "CreatedTime",
                value: new DateTime(2024, 9, 2, 11, 3, 37, 8, DateTimeKind.Local).AddTicks(9420));

            migrationBuilder.UpdateData(
                table: "Breeds",
                keyColumn: "Id",
                keyValue: 13,
                column: "CreatedTime",
                value: new DateTime(2024, 9, 2, 11, 3, 37, 8, DateTimeKind.Local).AddTicks(9420));

            migrationBuilder.UpdateData(
                table: "Breeds",
                keyColumn: "Id",
                keyValue: 14,
                column: "CreatedTime",
                value: new DateTime(2024, 9, 2, 11, 3, 37, 8, DateTimeKind.Local).AddTicks(9430));

            migrationBuilder.UpdateData(
                table: "Breeds",
                keyColumn: "Id",
                keyValue: 15,
                column: "CreatedTime",
                value: new DateTime(2024, 9, 2, 11, 3, 37, 8, DateTimeKind.Local).AddTicks(9430));

            migrationBuilder.UpdateData(
                table: "Breeds",
                keyColumn: "Id",
                keyValue: 16,
                column: "CreatedTime",
                value: new DateTime(2024, 9, 2, 11, 3, 37, 8, DateTimeKind.Local).AddTicks(9430));

            migrationBuilder.UpdateData(
                table: "Breeds",
                keyColumn: "Id",
                keyValue: 17,
                column: "CreatedTime",
                value: new DateTime(2024, 9, 2, 11, 3, 37, 8, DateTimeKind.Local).AddTicks(9430));

            migrationBuilder.UpdateData(
                table: "Breeds",
                keyColumn: "Id",
                keyValue: 18,
                column: "CreatedTime",
                value: new DateTime(2024, 9, 2, 11, 3, 37, 8, DateTimeKind.Local).AddTicks(9430));

            migrationBuilder.UpdateData(
                table: "Breeds",
                keyColumn: "Id",
                keyValue: 19,
                column: "CreatedTime",
                value: new DateTime(2024, 9, 2, 11, 3, 37, 8, DateTimeKind.Local).AddTicks(9430));

            migrationBuilder.UpdateData(
                table: "Breeds",
                keyColumn: "Id",
                keyValue: 20,
                column: "CreatedTime",
                value: new DateTime(2024, 9, 2, 11, 3, 37, 8, DateTimeKind.Local).AddTicks(9440));

            migrationBuilder.UpdateData(
                table: "Breeds",
                keyColumn: "Id",
                keyValue: 21,
                column: "CreatedTime",
                value: new DateTime(2024, 9, 2, 11, 3, 37, 8, DateTimeKind.Local).AddTicks(9440));

            migrationBuilder.UpdateData(
                table: "Breeds",
                keyColumn: "Id",
                keyValue: 22,
                column: "CreatedTime",
                value: new DateTime(2024, 9, 2, 11, 3, 37, 8, DateTimeKind.Local).AddTicks(9440));

            migrationBuilder.UpdateData(
                table: "Breeds",
                keyColumn: "Id",
                keyValue: 23,
                column: "CreatedTime",
                value: new DateTime(2024, 9, 2, 11, 3, 37, 8, DateTimeKind.Local).AddTicks(9440));

            migrationBuilder.UpdateData(
                table: "Breeds",
                keyColumn: "Id",
                keyValue: 24,
                column: "CreatedTime",
                value: new DateTime(2024, 9, 2, 11, 3, 37, 8, DateTimeKind.Local).AddTicks(9440));

            migrationBuilder.UpdateData(
                table: "Breeds",
                keyColumn: "Id",
                keyValue: 25,
                column: "CreatedTime",
                value: new DateTime(2024, 9, 2, 11, 3, 37, 8, DateTimeKind.Local).AddTicks(9440));

            migrationBuilder.UpdateData(
                table: "Breeds",
                keyColumn: "Id",
                keyValue: 26,
                column: "CreatedTime",
                value: new DateTime(2024, 9, 2, 11, 3, 37, 8, DateTimeKind.Local).AddTicks(9440));

            migrationBuilder.UpdateData(
                table: "Breeds",
                keyColumn: "Id",
                keyValue: 27,
                column: "CreatedTime",
                value: new DateTime(2024, 9, 2, 11, 3, 37, 8, DateTimeKind.Local).AddTicks(9450));

            migrationBuilder.UpdateData(
                table: "Breeds",
                keyColumn: "Id",
                keyValue: 28,
                column: "CreatedTime",
                value: new DateTime(2024, 9, 2, 11, 3, 37, 8, DateTimeKind.Local).AddTicks(9450));

            migrationBuilder.UpdateData(
                table: "Breeds",
                keyColumn: "Id",
                keyValue: 29,
                column: "CreatedTime",
                value: new DateTime(2024, 9, 2, 11, 3, 37, 8, DateTimeKind.Local).AddTicks(9450));

            migrationBuilder.UpdateData(
                table: "Breeds",
                keyColumn: "Id",
                keyValue: 30,
                column: "CreatedTime",
                value: new DateTime(2024, 9, 2, 11, 3, 37, 8, DateTimeKind.Local).AddTicks(9450));

            migrationBuilder.UpdateData(
                table: "Breeds",
                keyColumn: "Id",
                keyValue: 31,
                column: "CreatedTime",
                value: new DateTime(2024, 9, 2, 11, 3, 37, 8, DateTimeKind.Local).AddTicks(9450));

            migrationBuilder.UpdateData(
                table: "Breeds",
                keyColumn: "Id",
                keyValue: 32,
                column: "CreatedTime",
                value: new DateTime(2024, 9, 2, 11, 3, 37, 8, DateTimeKind.Local).AddTicks(9450));

            migrationBuilder.UpdateData(
                table: "Breeds",
                keyColumn: "Id",
                keyValue: 33,
                column: "CreatedTime",
                value: new DateTime(2024, 9, 2, 11, 3, 37, 8, DateTimeKind.Local).AddTicks(9450));

            migrationBuilder.UpdateData(
                table: "Breeds",
                keyColumn: "Id",
                keyValue: 34,
                column: "CreatedTime",
                value: new DateTime(2024, 9, 2, 11, 3, 37, 8, DateTimeKind.Local).AddTicks(9460));

            migrationBuilder.UpdateData(
                table: "Breeds",
                keyColumn: "Id",
                keyValue: 35,
                column: "CreatedTime",
                value: new DateTime(2024, 9, 2, 11, 3, 37, 8, DateTimeKind.Local).AddTicks(9460));

            migrationBuilder.UpdateData(
                table: "Breeds",
                keyColumn: "Id",
                keyValue: 36,
                column: "CreatedTime",
                value: new DateTime(2024, 9, 2, 11, 3, 37, 8, DateTimeKind.Local).AddTicks(9460));

            migrationBuilder.UpdateData(
                table: "Breeds",
                keyColumn: "Id",
                keyValue: 37,
                column: "CreatedTime",
                value: new DateTime(2024, 9, 2, 11, 3, 37, 8, DateTimeKind.Local).AddTicks(9460));

            migrationBuilder.UpdateData(
                table: "Breeds",
                keyColumn: "Id",
                keyValue: 38,
                column: "CreatedTime",
                value: new DateTime(2024, 9, 2, 11, 3, 37, 8, DateTimeKind.Local).AddTicks(9460));

            migrationBuilder.UpdateData(
                table: "Breeds",
                keyColumn: "Id",
                keyValue: 39,
                column: "CreatedTime",
                value: new DateTime(2024, 9, 2, 11, 3, 37, 8, DateTimeKind.Local).AddTicks(9460));

            migrationBuilder.UpdateData(
                table: "Breeds",
                keyColumn: "Id",
                keyValue: 40,
                column: "CreatedTime",
                value: new DateTime(2024, 9, 2, 11, 3, 37, 8, DateTimeKind.Local).AddTicks(9470));

            migrationBuilder.UpdateData(
                table: "Breeds",
                keyColumn: "Id",
                keyValue: 41,
                column: "CreatedTime",
                value: new DateTime(2024, 9, 2, 11, 3, 37, 8, DateTimeKind.Local).AddTicks(9470));

            migrationBuilder.UpdateData(
                table: "Breeds",
                keyColumn: "Id",
                keyValue: 42,
                column: "CreatedTime",
                value: new DateTime(2024, 9, 2, 11, 3, 37, 8, DateTimeKind.Local).AddTicks(9470));

            migrationBuilder.UpdateData(
                table: "Breeds",
                keyColumn: "Id",
                keyValue: 43,
                column: "CreatedTime",
                value: new DateTime(2024, 9, 2, 11, 3, 37, 8, DateTimeKind.Local).AddTicks(9470));

            migrationBuilder.UpdateData(
                table: "Breeds",
                keyColumn: "Id",
                keyValue: 44,
                column: "CreatedTime",
                value: new DateTime(2024, 9, 2, 11, 3, 37, 8, DateTimeKind.Local).AddTicks(9470));

            migrationBuilder.UpdateData(
                table: "Breeds",
                keyColumn: "Id",
                keyValue: 45,
                column: "CreatedTime",
                value: new DateTime(2024, 9, 2, 11, 3, 37, 8, DateTimeKind.Local).AddTicks(9470));

            migrationBuilder.UpdateData(
                table: "Breeds",
                keyColumn: "Id",
                keyValue: 46,
                column: "CreatedTime",
                value: new DateTime(2024, 9, 2, 11, 3, 37, 8, DateTimeKind.Local).AddTicks(9470));

            migrationBuilder.UpdateData(
                table: "Breeds",
                keyColumn: "Id",
                keyValue: 47,
                column: "CreatedTime",
                value: new DateTime(2024, 9, 2, 11, 3, 37, 8, DateTimeKind.Local).AddTicks(9480));

            migrationBuilder.UpdateData(
                table: "Breeds",
                keyColumn: "Id",
                keyValue: 48,
                column: "CreatedTime",
                value: new DateTime(2024, 9, 2, 11, 3, 37, 8, DateTimeKind.Local).AddTicks(9480));

            migrationBuilder.UpdateData(
                table: "Breeds",
                keyColumn: "Id",
                keyValue: 49,
                column: "CreatedTime",
                value: new DateTime(2024, 9, 2, 11, 3, 37, 8, DateTimeKind.Local).AddTicks(9480));

            migrationBuilder.UpdateData(
                table: "Breeds",
                keyColumn: "Id",
                keyValue: 50,
                column: "CreatedTime",
                value: new DateTime(2024, 9, 2, 11, 3, 37, 8, DateTimeKind.Local).AddTicks(9480));

            migrationBuilder.UpdateData(
                table: "Breeds",
                keyColumn: "Id",
                keyValue: 51,
                column: "CreatedTime",
                value: new DateTime(2024, 9, 2, 11, 3, 37, 8, DateTimeKind.Local).AddTicks(9480));

            migrationBuilder.UpdateData(
                table: "Breeds",
                keyColumn: "Id",
                keyValue: 52,
                column: "CreatedTime",
                value: new DateTime(2024, 9, 2, 11, 3, 37, 8, DateTimeKind.Local).AddTicks(9480));

            migrationBuilder.UpdateData(
                table: "Breeds",
                keyColumn: "Id",
                keyValue: 53,
                column: "CreatedTime",
                value: new DateTime(2024, 9, 2, 11, 3, 37, 8, DateTimeKind.Local).AddTicks(9490));

            migrationBuilder.UpdateData(
                table: "Breeds",
                keyColumn: "Id",
                keyValue: 54,
                column: "CreatedTime",
                value: new DateTime(2024, 9, 2, 11, 3, 37, 8, DateTimeKind.Local).AddTicks(9490));

            migrationBuilder.UpdateData(
                table: "Breeds",
                keyColumn: "Id",
                keyValue: 55,
                column: "CreatedTime",
                value: new DateTime(2024, 9, 2, 11, 3, 37, 8, DateTimeKind.Local).AddTicks(9490));

            migrationBuilder.UpdateData(
                table: "Breeds",
                keyColumn: "Id",
                keyValue: 56,
                column: "CreatedTime",
                value: new DateTime(2024, 9, 2, 11, 3, 37, 8, DateTimeKind.Local).AddTicks(9490));

            migrationBuilder.UpdateData(
                table: "Breeds",
                keyColumn: "Id",
                keyValue: 57,
                column: "CreatedTime",
                value: new DateTime(2024, 9, 2, 11, 3, 37, 8, DateTimeKind.Local).AddTicks(9490));

            migrationBuilder.UpdateData(
                table: "Breeds",
                keyColumn: "Id",
                keyValue: 58,
                column: "CreatedTime",
                value: new DateTime(2024, 9, 2, 11, 3, 37, 8, DateTimeKind.Local).AddTicks(9490));

            migrationBuilder.UpdateData(
                table: "Breeds",
                keyColumn: "Id",
                keyValue: 59,
                column: "CreatedTime",
                value: new DateTime(2024, 9, 2, 11, 3, 37, 8, DateTimeKind.Local).AddTicks(9490));

            migrationBuilder.UpdateData(
                table: "Breeds",
                keyColumn: "Id",
                keyValue: 60,
                column: "CreatedTime",
                value: new DateTime(2024, 9, 2, 11, 3, 37, 8, DateTimeKind.Local).AddTicks(9500));

            migrationBuilder.UpdateData(
                table: "Breeds",
                keyColumn: "Id",
                keyValue: 61,
                column: "CreatedTime",
                value: new DateTime(2024, 9, 2, 11, 3, 37, 8, DateTimeKind.Local).AddTicks(9500));

            migrationBuilder.UpdateData(
                table: "Breeds",
                keyColumn: "Id",
                keyValue: 62,
                column: "CreatedTime",
                value: new DateTime(2024, 9, 2, 11, 3, 37, 8, DateTimeKind.Local).AddTicks(9500));

            migrationBuilder.UpdateData(
                table: "Breeds",
                keyColumn: "Id",
                keyValue: 63,
                column: "CreatedTime",
                value: new DateTime(2024, 9, 2, 11, 3, 37, 8, DateTimeKind.Local).AddTicks(9500));

            migrationBuilder.UpdateData(
                table: "Breeds",
                keyColumn: "Id",
                keyValue: 64,
                column: "CreatedTime",
                value: new DateTime(2024, 9, 2, 11, 3, 37, 8, DateTimeKind.Local).AddTicks(9500));

            migrationBuilder.UpdateData(
                table: "Breeds",
                keyColumn: "Id",
                keyValue: 65,
                column: "CreatedTime",
                value: new DateTime(2024, 9, 2, 11, 3, 37, 8, DateTimeKind.Local).AddTicks(9500));

            migrationBuilder.UpdateData(
                table: "Breeds",
                keyColumn: "Id",
                keyValue: 66,
                column: "CreatedTime",
                value: new DateTime(2024, 9, 2, 11, 3, 37, 8, DateTimeKind.Local).AddTicks(9510));

            migrationBuilder.UpdateData(
                table: "Breeds",
                keyColumn: "Id",
                keyValue: 67,
                column: "CreatedTime",
                value: new DateTime(2024, 9, 2, 11, 3, 37, 8, DateTimeKind.Local).AddTicks(9510));

            migrationBuilder.UpdateData(
                table: "Breeds",
                keyColumn: "Id",
                keyValue: 68,
                column: "CreatedTime",
                value: new DateTime(2024, 9, 2, 11, 3, 37, 8, DateTimeKind.Local).AddTicks(9510));

            migrationBuilder.UpdateData(
                table: "Breeds",
                keyColumn: "Id",
                keyValue: 69,
                column: "CreatedTime",
                value: new DateTime(2024, 9, 2, 11, 3, 37, 8, DateTimeKind.Local).AddTicks(9510));

            migrationBuilder.UpdateData(
                table: "Breeds",
                keyColumn: "Id",
                keyValue: 70,
                column: "CreatedTime",
                value: new DateTime(2024, 9, 2, 11, 3, 37, 8, DateTimeKind.Local).AddTicks(9510));

            migrationBuilder.UpdateData(
                table: "Breeds",
                keyColumn: "Id",
                keyValue: 71,
                column: "CreatedTime",
                value: new DateTime(2024, 9, 2, 11, 3, 37, 8, DateTimeKind.Local).AddTicks(9510));

            migrationBuilder.UpdateData(
                table: "Breeds",
                keyColumn: "Id",
                keyValue: 72,
                column: "CreatedTime",
                value: new DateTime(2024, 9, 2, 11, 3, 37, 8, DateTimeKind.Local).AddTicks(9510));

            migrationBuilder.UpdateData(
                table: "Breeds",
                keyColumn: "Id",
                keyValue: 73,
                column: "CreatedTime",
                value: new DateTime(2024, 9, 2, 11, 3, 37, 8, DateTimeKind.Local).AddTicks(9520));

            migrationBuilder.UpdateData(
                table: "Breeds",
                keyColumn: "Id",
                keyValue: 74,
                column: "CreatedTime",
                value: new DateTime(2024, 9, 2, 11, 3, 37, 8, DateTimeKind.Local).AddTicks(9520));

            migrationBuilder.UpdateData(
                table: "Breeds",
                keyColumn: "Id",
                keyValue: 75,
                column: "CreatedTime",
                value: new DateTime(2024, 9, 2, 11, 3, 37, 8, DateTimeKind.Local).AddTicks(9520));

            migrationBuilder.UpdateData(
                table: "Breeds",
                keyColumn: "Id",
                keyValue: 76,
                column: "CreatedTime",
                value: new DateTime(2024, 9, 2, 11, 3, 37, 8, DateTimeKind.Local).AddTicks(9520));

            migrationBuilder.UpdateData(
                table: "Breeds",
                keyColumn: "Id",
                keyValue: 77,
                column: "CreatedTime",
                value: new DateTime(2024, 9, 2, 11, 3, 37, 8, DateTimeKind.Local).AddTicks(9520));

            migrationBuilder.UpdateData(
                table: "Breeds",
                keyColumn: "Id",
                keyValue: 78,
                column: "CreatedTime",
                value: new DateTime(2024, 9, 2, 11, 3, 37, 8, DateTimeKind.Local).AddTicks(9520));

            migrationBuilder.UpdateData(
                table: "Breeds",
                keyColumn: "Id",
                keyValue: 79,
                column: "CreatedTime",
                value: new DateTime(2024, 9, 2, 11, 3, 37, 8, DateTimeKind.Local).AddTicks(9520));

            migrationBuilder.UpdateData(
                table: "Breeds",
                keyColumn: "Id",
                keyValue: 80,
                column: "CreatedTime",
                value: new DateTime(2024, 9, 2, 11, 3, 37, 8, DateTimeKind.Local).AddTicks(9530));

            migrationBuilder.UpdateData(
                table: "Breeds",
                keyColumn: "Id",
                keyValue: 81,
                column: "CreatedTime",
                value: new DateTime(2024, 9, 2, 11, 3, 37, 8, DateTimeKind.Local).AddTicks(9530));

            migrationBuilder.UpdateData(
                table: "Breeds",
                keyColumn: "Id",
                keyValue: 82,
                column: "CreatedTime",
                value: new DateTime(2024, 9, 2, 11, 3, 37, 8, DateTimeKind.Local).AddTicks(9530));

            migrationBuilder.UpdateData(
                table: "Breeds",
                keyColumn: "Id",
                keyValue: 83,
                column: "CreatedTime",
                value: new DateTime(2024, 9, 2, 11, 3, 37, 8, DateTimeKind.Local).AddTicks(9530));

            migrationBuilder.UpdateData(
                table: "Breeds",
                keyColumn: "Id",
                keyValue: 84,
                column: "CreatedTime",
                value: new DateTime(2024, 9, 2, 11, 3, 37, 8, DateTimeKind.Local).AddTicks(9530));

            migrationBuilder.UpdateData(
                table: "Breeds",
                keyColumn: "Id",
                keyValue: 85,
                column: "CreatedTime",
                value: new DateTime(2024, 9, 2, 11, 3, 37, 8, DateTimeKind.Local).AddTicks(9530));

            migrationBuilder.UpdateData(
                table: "Breeds",
                keyColumn: "Id",
                keyValue: 86,
                column: "CreatedTime",
                value: new DateTime(2024, 9, 2, 11, 3, 37, 8, DateTimeKind.Local).AddTicks(9530));

            migrationBuilder.UpdateData(
                table: "Breeds",
                keyColumn: "Id",
                keyValue: 87,
                column: "CreatedTime",
                value: new DateTime(2024, 9, 2, 11, 3, 37, 8, DateTimeKind.Local).AddTicks(9540));

            migrationBuilder.UpdateData(
                table: "Breeds",
                keyColumn: "Id",
                keyValue: 88,
                column: "CreatedTime",
                value: new DateTime(2024, 9, 2, 11, 3, 37, 8, DateTimeKind.Local).AddTicks(9540));

            migrationBuilder.UpdateData(
                table: "Breeds",
                keyColumn: "Id",
                keyValue: 89,
                column: "CreatedTime",
                value: new DateTime(2024, 9, 2, 11, 3, 37, 8, DateTimeKind.Local).AddTicks(9540));

            migrationBuilder.UpdateData(
                table: "Breeds",
                keyColumn: "Id",
                keyValue: 90,
                column: "CreatedTime",
                value: new DateTime(2024, 9, 2, 11, 3, 37, 8, DateTimeKind.Local).AddTicks(9540));

            migrationBuilder.UpdateData(
                table: "Breeds",
                keyColumn: "Id",
                keyValue: 91,
                column: "CreatedTime",
                value: new DateTime(2024, 9, 2, 11, 3, 37, 8, DateTimeKind.Local).AddTicks(9540));

            migrationBuilder.UpdateData(
                table: "Breeds",
                keyColumn: "Id",
                keyValue: 92,
                column: "CreatedTime",
                value: new DateTime(2024, 9, 2, 11, 3, 37, 8, DateTimeKind.Local).AddTicks(9540));

            migrationBuilder.UpdateData(
                table: "Breeds",
                keyColumn: "Id",
                keyValue: 93,
                column: "CreatedTime",
                value: new DateTime(2024, 9, 2, 11, 3, 37, 8, DateTimeKind.Local).AddTicks(9550));

            migrationBuilder.UpdateData(
                table: "Breeds",
                keyColumn: "Id",
                keyValue: 94,
                column: "CreatedTime",
                value: new DateTime(2024, 9, 2, 11, 3, 37, 8, DateTimeKind.Local).AddTicks(9550));

            migrationBuilder.UpdateData(
                table: "Breeds",
                keyColumn: "Id",
                keyValue: 95,
                column: "CreatedTime",
                value: new DateTime(2024, 9, 2, 11, 3, 37, 8, DateTimeKind.Local).AddTicks(9550));

            migrationBuilder.UpdateData(
                table: "Breeds",
                keyColumn: "Id",
                keyValue: 96,
                column: "CreatedTime",
                value: new DateTime(2024, 9, 2, 11, 3, 37, 8, DateTimeKind.Local).AddTicks(9550));

            migrationBuilder.UpdateData(
                table: "Breeds",
                keyColumn: "Id",
                keyValue: 97,
                column: "CreatedTime",
                value: new DateTime(2024, 9, 2, 11, 3, 37, 8, DateTimeKind.Local).AddTicks(9550));

            migrationBuilder.UpdateData(
                table: "Breeds",
                keyColumn: "Id",
                keyValue: 98,
                column: "CreatedTime",
                value: new DateTime(2024, 9, 2, 11, 3, 37, 8, DateTimeKind.Local).AddTicks(9550));

            migrationBuilder.UpdateData(
                table: "Breeds",
                keyColumn: "Id",
                keyValue: 99,
                column: "CreatedTime",
                value: new DateTime(2024, 9, 2, 11, 3, 37, 8, DateTimeKind.Local).AddTicks(9550));

            migrationBuilder.UpdateData(
                table: "Breeds",
                keyColumn: "Id",
                keyValue: 100,
                column: "CreatedTime",
                value: new DateTime(2024, 9, 2, 11, 3, 37, 8, DateTimeKind.Local).AddTicks(9560));

            migrationBuilder.UpdateData(
                table: "Breeds",
                keyColumn: "Id",
                keyValue: 101,
                column: "CreatedTime",
                value: new DateTime(2024, 9, 2, 11, 3, 37, 8, DateTimeKind.Local).AddTicks(9560));

            migrationBuilder.UpdateData(
                table: "Breeds",
                keyColumn: "Id",
                keyValue: 102,
                column: "CreatedTime",
                value: new DateTime(2024, 9, 2, 11, 3, 37, 8, DateTimeKind.Local).AddTicks(9560));

            migrationBuilder.UpdateData(
                table: "Breeds",
                keyColumn: "Id",
                keyValue: 103,
                column: "CreatedTime",
                value: new DateTime(2024, 9, 2, 11, 3, 37, 8, DateTimeKind.Local).AddTicks(9560));

            migrationBuilder.UpdateData(
                table: "Breeds",
                keyColumn: "Id",
                keyValue: 104,
                column: "CreatedTime",
                value: new DateTime(2024, 9, 2, 11, 3, 37, 8, DateTimeKind.Local).AddTicks(9560));

            migrationBuilder.UpdateData(
                table: "Breeds",
                keyColumn: "Id",
                keyValue: 105,
                column: "CreatedTime",
                value: new DateTime(2024, 9, 2, 11, 3, 37, 8, DateTimeKind.Local).AddTicks(9560));

            migrationBuilder.UpdateData(
                table: "Breeds",
                keyColumn: "Id",
                keyValue: 106,
                column: "CreatedTime",
                value: new DateTime(2024, 9, 2, 11, 3, 37, 8, DateTimeKind.Local).AddTicks(9570));

            migrationBuilder.UpdateData(
                table: "Breeds",
                keyColumn: "Id",
                keyValue: 107,
                column: "CreatedTime",
                value: new DateTime(2024, 9, 2, 11, 3, 37, 8, DateTimeKind.Local).AddTicks(9570));

            migrationBuilder.UpdateData(
                table: "Breeds",
                keyColumn: "Id",
                keyValue: 108,
                column: "CreatedTime",
                value: new DateTime(2024, 9, 2, 11, 3, 37, 8, DateTimeKind.Local).AddTicks(9570));

            migrationBuilder.UpdateData(
                table: "Breeds",
                keyColumn: "Id",
                keyValue: 109,
                column: "CreatedTime",
                value: new DateTime(2024, 9, 2, 11, 3, 37, 8, DateTimeKind.Local).AddTicks(9570));

            migrationBuilder.UpdateData(
                table: "Breeds",
                keyColumn: "Id",
                keyValue: 110,
                column: "CreatedTime",
                value: new DateTime(2024, 9, 2, 11, 3, 37, 8, DateTimeKind.Local).AddTicks(9570));

            migrationBuilder.UpdateData(
                table: "Breeds",
                keyColumn: "Id",
                keyValue: 111,
                column: "CreatedTime",
                value: new DateTime(2024, 9, 2, 11, 3, 37, 8, DateTimeKind.Local).AddTicks(9570));

            migrationBuilder.UpdateData(
                table: "Breeds",
                keyColumn: "Id",
                keyValue: 112,
                column: "CreatedTime",
                value: new DateTime(2024, 9, 2, 11, 3, 37, 8, DateTimeKind.Local).AddTicks(9570));

            migrationBuilder.UpdateData(
                table: "Breeds",
                keyColumn: "Id",
                keyValue: 113,
                column: "CreatedTime",
                value: new DateTime(2024, 9, 2, 11, 3, 37, 8, DateTimeKind.Local).AddTicks(9580));

            migrationBuilder.UpdateData(
                table: "Breeds",
                keyColumn: "Id",
                keyValue: 114,
                column: "CreatedTime",
                value: new DateTime(2024, 9, 2, 11, 3, 37, 8, DateTimeKind.Local).AddTicks(9580));

            migrationBuilder.UpdateData(
                table: "Breeds",
                keyColumn: "Id",
                keyValue: 115,
                column: "CreatedTime",
                value: new DateTime(2024, 9, 2, 11, 3, 37, 8, DateTimeKind.Local).AddTicks(9580));

            migrationBuilder.UpdateData(
                table: "Breeds",
                keyColumn: "Id",
                keyValue: 116,
                column: "CreatedTime",
                value: new DateTime(2024, 9, 2, 11, 3, 37, 8, DateTimeKind.Local).AddTicks(9580));

            migrationBuilder.UpdateData(
                table: "Breeds",
                keyColumn: "Id",
                keyValue: 117,
                column: "CreatedTime",
                value: new DateTime(2024, 9, 2, 11, 3, 37, 8, DateTimeKind.Local).AddTicks(9580));

            migrationBuilder.UpdateData(
                table: "Breeds",
                keyColumn: "Id",
                keyValue: 118,
                column: "CreatedTime",
                value: new DateTime(2024, 9, 2, 11, 3, 37, 8, DateTimeKind.Local).AddTicks(9580));

            migrationBuilder.UpdateData(
                table: "Breeds",
                keyColumn: "Id",
                keyValue: 119,
                column: "CreatedTime",
                value: new DateTime(2024, 9, 2, 11, 3, 37, 8, DateTimeKind.Local).AddTicks(9580));

            migrationBuilder.UpdateData(
                table: "Breeds",
                keyColumn: "Id",
                keyValue: 120,
                column: "CreatedTime",
                value: new DateTime(2024, 9, 2, 11, 3, 37, 8, DateTimeKind.Local).AddTicks(9590));

            migrationBuilder.UpdateData(
                table: "Breeds",
                keyColumn: "Id",
                keyValue: 121,
                column: "CreatedTime",
                value: new DateTime(2024, 9, 2, 11, 3, 37, 8, DateTimeKind.Local).AddTicks(9590));

            migrationBuilder.UpdateData(
                table: "Breeds",
                keyColumn: "Id",
                keyValue: 122,
                column: "CreatedTime",
                value: new DateTime(2024, 9, 2, 11, 3, 37, 8, DateTimeKind.Local).AddTicks(9590));

            migrationBuilder.UpdateData(
                table: "Breeds",
                keyColumn: "Id",
                keyValue: 123,
                column: "CreatedTime",
                value: new DateTime(2024, 9, 2, 11, 3, 37, 8, DateTimeKind.Local).AddTicks(9590));

            migrationBuilder.UpdateData(
                table: "Breeds",
                keyColumn: "Id",
                keyValue: 124,
                column: "CreatedTime",
                value: new DateTime(2024, 9, 2, 11, 3, 37, 8, DateTimeKind.Local).AddTicks(9610));

            migrationBuilder.UpdateData(
                table: "Breeds",
                keyColumn: "Id",
                keyValue: 125,
                column: "CreatedTime",
                value: new DateTime(2024, 9, 2, 11, 3, 37, 8, DateTimeKind.Local).AddTicks(9610));

            migrationBuilder.UpdateData(
                table: "Breeds",
                keyColumn: "Id",
                keyValue: 126,
                column: "CreatedTime",
                value: new DateTime(2024, 9, 2, 11, 3, 37, 8, DateTimeKind.Local).AddTicks(9610));

            migrationBuilder.UpdateData(
                table: "Breeds",
                keyColumn: "Id",
                keyValue: 127,
                column: "CreatedTime",
                value: new DateTime(2024, 9, 2, 11, 3, 37, 8, DateTimeKind.Local).AddTicks(9610));

            migrationBuilder.UpdateData(
                table: "Breeds",
                keyColumn: "Id",
                keyValue: 128,
                column: "CreatedTime",
                value: new DateTime(2024, 9, 2, 11, 3, 37, 8, DateTimeKind.Local).AddTicks(9610));

            migrationBuilder.UpdateData(
                table: "Breeds",
                keyColumn: "Id",
                keyValue: 129,
                column: "CreatedTime",
                value: new DateTime(2024, 9, 2, 11, 3, 37, 8, DateTimeKind.Local).AddTicks(9610));

            migrationBuilder.UpdateData(
                table: "Breeds",
                keyColumn: "Id",
                keyValue: 130,
                column: "CreatedTime",
                value: new DateTime(2024, 9, 2, 11, 3, 37, 8, DateTimeKind.Local).AddTicks(9620));

            migrationBuilder.UpdateData(
                table: "Breeds",
                keyColumn: "Id",
                keyValue: 131,
                column: "CreatedTime",
                value: new DateTime(2024, 9, 2, 11, 3, 37, 8, DateTimeKind.Local).AddTicks(9620));

            migrationBuilder.UpdateData(
                table: "Breeds",
                keyColumn: "Id",
                keyValue: 132,
                column: "CreatedTime",
                value: new DateTime(2024, 9, 2, 11, 3, 37, 8, DateTimeKind.Local).AddTicks(9620));

            migrationBuilder.UpdateData(
                table: "Breeds",
                keyColumn: "Id",
                keyValue: 133,
                column: "CreatedTime",
                value: new DateTime(2024, 9, 2, 11, 3, 37, 8, DateTimeKind.Local).AddTicks(9620));

            migrationBuilder.UpdateData(
                table: "Breeds",
                keyColumn: "Id",
                keyValue: 134,
                column: "CreatedTime",
                value: new DateTime(2024, 9, 2, 11, 3, 37, 8, DateTimeKind.Local).AddTicks(9620));

            migrationBuilder.UpdateData(
                table: "Breeds",
                keyColumn: "Id",
                keyValue: 135,
                column: "CreatedTime",
                value: new DateTime(2024, 9, 2, 11, 3, 37, 8, DateTimeKind.Local).AddTicks(9620));

            migrationBuilder.UpdateData(
                table: "Breeds",
                keyColumn: "Id",
                keyValue: 136,
                column: "CreatedTime",
                value: new DateTime(2024, 9, 2, 11, 3, 37, 8, DateTimeKind.Local).AddTicks(9630));

            migrationBuilder.UpdateData(
                table: "Breeds",
                keyColumn: "Id",
                keyValue: 137,
                column: "CreatedTime",
                value: new DateTime(2024, 9, 2, 11, 3, 37, 8, DateTimeKind.Local).AddTicks(9630));

            migrationBuilder.UpdateData(
                table: "Breeds",
                keyColumn: "Id",
                keyValue: 138,
                column: "CreatedTime",
                value: new DateTime(2024, 9, 2, 11, 3, 37, 8, DateTimeKind.Local).AddTicks(9630));

            migrationBuilder.UpdateData(
                table: "Breeds",
                keyColumn: "Id",
                keyValue: 139,
                column: "CreatedTime",
                value: new DateTime(2024, 9, 2, 11, 3, 37, 8, DateTimeKind.Local).AddTicks(9630));

            migrationBuilder.UpdateData(
                table: "Breeds",
                keyColumn: "Id",
                keyValue: 140,
                column: "CreatedTime",
                value: new DateTime(2024, 9, 2, 11, 3, 37, 8, DateTimeKind.Local).AddTicks(9630));

            migrationBuilder.UpdateData(
                table: "Breeds",
                keyColumn: "Id",
                keyValue: 141,
                column: "CreatedTime",
                value: new DateTime(2024, 9, 2, 11, 3, 37, 8, DateTimeKind.Local).AddTicks(9630));

            migrationBuilder.UpdateData(
                table: "Breeds",
                keyColumn: "Id",
                keyValue: 142,
                column: "CreatedTime",
                value: new DateTime(2024, 9, 2, 11, 3, 37, 8, DateTimeKind.Local).AddTicks(9630));

            migrationBuilder.UpdateData(
                table: "Breeds",
                keyColumn: "Id",
                keyValue: 143,
                column: "CreatedTime",
                value: new DateTime(2024, 9, 2, 11, 3, 37, 8, DateTimeKind.Local).AddTicks(9640));

            migrationBuilder.UpdateData(
                table: "Breeds",
                keyColumn: "Id",
                keyValue: 144,
                column: "CreatedTime",
                value: new DateTime(2024, 9, 2, 11, 3, 37, 8, DateTimeKind.Local).AddTicks(9640));

            migrationBuilder.UpdateData(
                table: "Breeds",
                keyColumn: "Id",
                keyValue: 145,
                column: "CreatedTime",
                value: new DateTime(2024, 9, 2, 11, 3, 37, 8, DateTimeKind.Local).AddTicks(9640));

            migrationBuilder.UpdateData(
                table: "Breeds",
                keyColumn: "Id",
                keyValue: 146,
                column: "CreatedTime",
                value: new DateTime(2024, 9, 2, 11, 3, 37, 8, DateTimeKind.Local).AddTicks(9640));

            migrationBuilder.UpdateData(
                table: "Breeds",
                keyColumn: "Id",
                keyValue: 147,
                column: "CreatedTime",
                value: new DateTime(2024, 9, 2, 11, 3, 37, 8, DateTimeKind.Local).AddTicks(9640));

            migrationBuilder.UpdateData(
                table: "Breeds",
                keyColumn: "Id",
                keyValue: 148,
                column: "CreatedTime",
                value: new DateTime(2024, 9, 2, 11, 3, 37, 8, DateTimeKind.Local).AddTicks(9640));

            migrationBuilder.UpdateData(
                table: "Breeds",
                keyColumn: "Id",
                keyValue: 149,
                column: "CreatedTime",
                value: new DateTime(2024, 9, 2, 11, 3, 37, 8, DateTimeKind.Local).AddTicks(9650));

            migrationBuilder.UpdateData(
                table: "Breeds",
                keyColumn: "Id",
                keyValue: 150,
                column: "CreatedTime",
                value: new DateTime(2024, 9, 2, 11, 3, 37, 8, DateTimeKind.Local).AddTicks(9650));

            migrationBuilder.UpdateData(
                table: "Breeds",
                keyColumn: "Id",
                keyValue: 151,
                column: "CreatedTime",
                value: new DateTime(2024, 9, 2, 11, 3, 37, 8, DateTimeKind.Local).AddTicks(9650));

            migrationBuilder.UpdateData(
                table: "Breeds",
                keyColumn: "Id",
                keyValue: 152,
                column: "CreatedTime",
                value: new DateTime(2024, 9, 2, 11, 3, 37, 8, DateTimeKind.Local).AddTicks(9650));

            migrationBuilder.UpdateData(
                table: "Breeds",
                keyColumn: "Id",
                keyValue: 153,
                column: "CreatedTime",
                value: new DateTime(2024, 9, 2, 11, 3, 37, 8, DateTimeKind.Local).AddTicks(9650));

            migrationBuilder.UpdateData(
                table: "Breeds",
                keyColumn: "Id",
                keyValue: 154,
                column: "CreatedTime",
                value: new DateTime(2024, 9, 2, 11, 3, 37, 8, DateTimeKind.Local).AddTicks(9650));

            migrationBuilder.UpdateData(
                table: "Breeds",
                keyColumn: "Id",
                keyValue: 155,
                column: "CreatedTime",
                value: new DateTime(2024, 9, 2, 11, 3, 37, 8, DateTimeKind.Local).AddTicks(9650));

            migrationBuilder.UpdateData(
                table: "Breeds",
                keyColumn: "Id",
                keyValue: 156,
                column: "CreatedTime",
                value: new DateTime(2024, 9, 2, 11, 3, 37, 8, DateTimeKind.Local).AddTicks(9660));

            migrationBuilder.UpdateData(
                table: "Breeds",
                keyColumn: "Id",
                keyValue: 157,
                column: "CreatedTime",
                value: new DateTime(2024, 9, 2, 11, 3, 37, 8, DateTimeKind.Local).AddTicks(9660));

            migrationBuilder.UpdateData(
                table: "Breeds",
                keyColumn: "Id",
                keyValue: 158,
                column: "CreatedTime",
                value: new DateTime(2024, 9, 2, 11, 3, 37, 8, DateTimeKind.Local).AddTicks(9660));

            migrationBuilder.UpdateData(
                table: "Breeds",
                keyColumn: "Id",
                keyValue: 159,
                column: "CreatedTime",
                value: new DateTime(2024, 9, 2, 11, 3, 37, 8, DateTimeKind.Local).AddTicks(9660));

            migrationBuilder.UpdateData(
                table: "Breeds",
                keyColumn: "Id",
                keyValue: 160,
                column: "CreatedTime",
                value: new DateTime(2024, 9, 2, 11, 3, 37, 8, DateTimeKind.Local).AddTicks(9660));

            migrationBuilder.UpdateData(
                table: "PetTypes",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedTime",
                value: new DateTime(2024, 9, 2, 11, 3, 37, 8, DateTimeKind.Local).AddTicks(8680));

            migrationBuilder.UpdateData(
                table: "PetTypes",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreatedTime",
                value: new DateTime(2024, 9, 2, 11, 3, 37, 8, DateTimeKind.Local).AddTicks(8690));

            migrationBuilder.UpdateData(
                table: "PetTypes",
                keyColumn: "Id",
                keyValue: 3,
                column: "CreatedTime",
                value: new DateTime(2024, 9, 2, 11, 3, 37, 8, DateTimeKind.Local).AddTicks(8690));

            migrationBuilder.UpdateData(
                table: "PetTypes",
                keyColumn: "Id",
                keyValue: 4,
                column: "CreatedTime",
                value: new DateTime(2024, 9, 2, 11, 3, 37, 8, DateTimeKind.Local).AddTicks(8690));

            migrationBuilder.UpdateData(
                table: "PetTypes",
                keyColumn: "Id",
                keyValue: 5,
                column: "CreatedTime",
                value: new DateTime(2024, 9, 2, 11, 3, 37, 8, DateTimeKind.Local).AddTicks(8690));

            migrationBuilder.UpdateData(
                table: "PetTypes",
                keyColumn: "Id",
                keyValue: 6,
                column: "CreatedTime",
                value: new DateTime(2024, 9, 2, 11, 3, 37, 8, DateTimeKind.Local).AddTicks(8700));

            migrationBuilder.UpdateData(
                table: "PetTypes",
                keyColumn: "Id",
                keyValue: 7,
                column: "CreatedTime",
                value: new DateTime(2024, 9, 2, 11, 3, 37, 8, DateTimeKind.Local).AddTicks(8700));

            migrationBuilder.UpdateData(
                table: "PetTypes",
                keyColumn: "Id",
                keyValue: 8,
                column: "CreatedTime",
                value: new DateTime(2024, 9, 2, 11, 3, 37, 8, DateTimeKind.Local).AddTicks(8700));

            migrationBuilder.UpdateData(
                table: "Pets",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedTime",
                value: new DateTime(2024, 9, 2, 11, 3, 37, 12, DateTimeKind.Local).AddTicks(1690));

            migrationBuilder.UpdateData(
                table: "Pets",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreatedTime",
                value: new DateTime(2024, 9, 2, 11, 3, 37, 12, DateTimeKind.Local).AddTicks(1710));

            migrationBuilder.UpdateData(
                table: "Pets",
                keyColumn: "Id",
                keyValue: 3,
                column: "CreatedTime",
                value: new DateTime(2024, 9, 2, 11, 3, 37, 12, DateTimeKind.Local).AddTicks(1710));

            migrationBuilder.UpdateData(
                table: "Pets",
                keyColumn: "Id",
                keyValue: 4,
                column: "CreatedTime",
                value: new DateTime(2024, 9, 2, 11, 3, 37, 12, DateTimeKind.Local).AddTicks(1720));

            migrationBuilder.UpdateData(
                table: "Pets",
                keyColumn: "Id",
                keyValue: 5,
                column: "CreatedTime",
                value: new DateTime(2024, 9, 2, 11, 3, 37, 12, DateTimeKind.Local).AddTicks(1720));

            migrationBuilder.UpdateData(
                table: "Pets",
                keyColumn: "Id",
                keyValue: 6,
                column: "CreatedTime",
                value: new DateTime(2024, 9, 2, 11, 3, 37, 12, DateTimeKind.Local).AddTicks(1720));

            migrationBuilder.UpdateData(
                table: "Pets",
                keyColumn: "Id",
                keyValue: 7,
                column: "CreatedTime",
                value: new DateTime(2024, 9, 2, 11, 3, 37, 12, DateTimeKind.Local).AddTicks(1730));

            migrationBuilder.UpdateData(
                table: "Pets",
                keyColumn: "Id",
                keyValue: 8,
                column: "CreatedTime",
                value: new DateTime(2024, 9, 2, 11, 3, 37, 12, DateTimeKind.Local).AddTicks(1730));

            migrationBuilder.UpdateData(
                table: "Pets",
                keyColumn: "Id",
                keyValue: 9,
                column: "CreatedTime",
                value: new DateTime(2024, 9, 2, 11, 3, 37, 12, DateTimeKind.Local).AddTicks(1750));

            migrationBuilder.UpdateData(
                table: "Pets",
                keyColumn: "Id",
                keyValue: 10,
                column: "CreatedTime",
                value: new DateTime(2024, 9, 2, 11, 3, 37, 12, DateTimeKind.Local).AddTicks(1750));

            migrationBuilder.UpdateData(
                table: "Pets",
                keyColumn: "Id",
                keyValue: 11,
                column: "CreatedTime",
                value: new DateTime(2024, 9, 2, 11, 3, 37, 12, DateTimeKind.Local).AddTicks(1760));

            migrationBuilder.UpdateData(
                table: "Pets",
                keyColumn: "Id",
                keyValue: 12,
                column: "CreatedTime",
                value: new DateTime(2024, 9, 2, 11, 3, 37, 12, DateTimeKind.Local).AddTicks(1760));

            migrationBuilder.UpdateData(
                table: "Pets",
                keyColumn: "Id",
                keyValue: 13,
                column: "CreatedTime",
                value: new DateTime(2024, 9, 2, 11, 3, 37, 12, DateTimeKind.Local).AddTicks(1760));

            migrationBuilder.UpdateData(
                table: "Pets",
                keyColumn: "Id",
                keyValue: 14,
                column: "CreatedTime",
                value: new DateTime(2024, 9, 2, 11, 3, 37, 12, DateTimeKind.Local).AddTicks(1770));

            migrationBuilder.UpdateData(
                table: "Pets",
                keyColumn: "Id",
                keyValue: 15,
                column: "CreatedTime",
                value: new DateTime(2024, 9, 2, 11, 3, 37, 12, DateTimeKind.Local).AddTicks(1780));

            migrationBuilder.UpdateData(
                table: "Pets",
                keyColumn: "Id",
                keyValue: 16,
                column: "CreatedTime",
                value: new DateTime(2024, 9, 2, 11, 3, 37, 12, DateTimeKind.Local).AddTicks(1780));

            migrationBuilder.UpdateData(
                table: "Pets",
                keyColumn: "Id",
                keyValue: 17,
                column: "CreatedTime",
                value: new DateTime(2024, 9, 2, 11, 3, 37, 12, DateTimeKind.Local).AddTicks(1780));

            migrationBuilder.UpdateData(
                table: "Pets",
                keyColumn: "Id",
                keyValue: 18,
                column: "CreatedTime",
                value: new DateTime(2024, 9, 2, 11, 3, 37, 12, DateTimeKind.Local).AddTicks(1790));

            migrationBuilder.UpdateData(
                table: "Pets",
                keyColumn: "Id",
                keyValue: 19,
                column: "CreatedTime",
                value: new DateTime(2024, 9, 2, 11, 3, 37, 12, DateTimeKind.Local).AddTicks(1790));

            migrationBuilder.UpdateData(
                table: "Pets",
                keyColumn: "Id",
                keyValue: 20,
                column: "CreatedTime",
                value: new DateTime(2024, 9, 2, 11, 3, 37, 12, DateTimeKind.Local).AddTicks(1790));

            migrationBuilder.UpdateData(
                table: "Pets",
                keyColumn: "Id",
                keyValue: 21,
                column: "CreatedTime",
                value: new DateTime(2024, 9, 2, 11, 3, 37, 12, DateTimeKind.Local).AddTicks(1800));

            migrationBuilder.UpdateData(
                table: "Pets",
                keyColumn: "Id",
                keyValue: 22,
                column: "CreatedTime",
                value: new DateTime(2024, 9, 2, 11, 3, 37, 12, DateTimeKind.Local).AddTicks(1800));

            migrationBuilder.UpdateData(
                table: "Pets",
                keyColumn: "Id",
                keyValue: 23,
                column: "CreatedTime",
                value: new DateTime(2024, 9, 2, 11, 3, 37, 12, DateTimeKind.Local).AddTicks(1810));

            migrationBuilder.UpdateData(
                table: "Pets",
                keyColumn: "Id",
                keyValue: 24,
                column: "CreatedTime",
                value: new DateTime(2024, 9, 2, 11, 3, 37, 12, DateTimeKind.Local).AddTicks(1810));

            migrationBuilder.UpdateData(
                table: "Pets",
                keyColumn: "Id",
                keyValue: 25,
                column: "CreatedTime",
                value: new DateTime(2024, 9, 2, 11, 3, 37, 12, DateTimeKind.Local).AddTicks(1810));

            migrationBuilder.UpdateData(
                table: "Pets",
                keyColumn: "Id",
                keyValue: 26,
                column: "CreatedTime",
                value: new DateTime(2024, 9, 2, 11, 3, 37, 12, DateTimeKind.Local).AddTicks(1820));

            migrationBuilder.UpdateData(
                table: "Pets",
                keyColumn: "Id",
                keyValue: 27,
                column: "CreatedTime",
                value: new DateTime(2024, 9, 2, 11, 3, 37, 12, DateTimeKind.Local).AddTicks(1820));

            migrationBuilder.UpdateData(
                table: "Pets",
                keyColumn: "Id",
                keyValue: 28,
                column: "CreatedTime",
                value: new DateTime(2024, 9, 2, 11, 3, 37, 12, DateTimeKind.Local).AddTicks(1820));

            migrationBuilder.UpdateData(
                table: "Pets",
                keyColumn: "Id",
                keyValue: 29,
                column: "CreatedTime",
                value: new DateTime(2024, 9, 2, 11, 3, 37, 12, DateTimeKind.Local).AddTicks(1820));

            migrationBuilder.UpdateData(
                table: "Pets",
                keyColumn: "Id",
                keyValue: 30,
                column: "CreatedTime",
                value: new DateTime(2024, 9, 2, 11, 3, 37, 12, DateTimeKind.Local).AddTicks(1830));

            migrationBuilder.UpdateData(
                table: "Pets",
                keyColumn: "Id",
                keyValue: 31,
                column: "CreatedTime",
                value: new DateTime(2024, 9, 2, 11, 3, 37, 12, DateTimeKind.Local).AddTicks(1830));

            migrationBuilder.UpdateData(
                table: "Pets",
                keyColumn: "Id",
                keyValue: 32,
                column: "CreatedTime",
                value: new DateTime(2024, 9, 2, 11, 3, 37, 12, DateTimeKind.Local).AddTicks(1830));

            migrationBuilder.UpdateData(
                table: "Pets",
                keyColumn: "Id",
                keyValue: 33,
                column: "CreatedTime",
                value: new DateTime(2024, 9, 2, 11, 3, 37, 12, DateTimeKind.Local).AddTicks(1840));

            migrationBuilder.UpdateData(
                table: "Pets",
                keyColumn: "Id",
                keyValue: 34,
                column: "CreatedTime",
                value: new DateTime(2024, 9, 2, 11, 3, 37, 12, DateTimeKind.Local).AddTicks(1840));

            migrationBuilder.UpdateData(
                table: "Pets",
                keyColumn: "Id",
                keyValue: 35,
                column: "CreatedTime",
                value: new DateTime(2024, 9, 2, 11, 3, 37, 12, DateTimeKind.Local).AddTicks(1840));

            migrationBuilder.UpdateData(
                table: "Pets",
                keyColumn: "Id",
                keyValue: 36,
                column: "CreatedTime",
                value: new DateTime(2024, 9, 2, 11, 3, 37, 12, DateTimeKind.Local).AddTicks(1850));

            migrationBuilder.UpdateData(
                table: "Pets",
                keyColumn: "Id",
                keyValue: 37,
                column: "CreatedTime",
                value: new DateTime(2024, 9, 2, 11, 3, 37, 12, DateTimeKind.Local).AddTicks(1850));

            migrationBuilder.UpdateData(
                table: "Pets",
                keyColumn: "Id",
                keyValue: 38,
                column: "CreatedTime",
                value: new DateTime(2024, 9, 2, 11, 3, 37, 12, DateTimeKind.Local).AddTicks(1850));

            migrationBuilder.UpdateData(
                table: "Pets",
                keyColumn: "Id",
                keyValue: 39,
                column: "CreatedTime",
                value: new DateTime(2024, 9, 2, 11, 3, 37, 12, DateTimeKind.Local).AddTicks(1860));

            migrationBuilder.UpdateData(
                table: "Pets",
                keyColumn: "Id",
                keyValue: 40,
                column: "CreatedTime",
                value: new DateTime(2024, 9, 2, 11, 3, 37, 12, DateTimeKind.Local).AddTicks(1860));

            migrationBuilder.UpdateData(
                table: "Pets",
                keyColumn: "Id",
                keyValue: 41,
                column: "CreatedTime",
                value: new DateTime(2024, 9, 2, 11, 3, 37, 12, DateTimeKind.Local).AddTicks(1860));

            migrationBuilder.UpdateData(
                table: "Pets",
                keyColumn: "Id",
                keyValue: 42,
                column: "CreatedTime",
                value: new DateTime(2024, 9, 2, 11, 3, 37, 12, DateTimeKind.Local).AddTicks(1870));

            migrationBuilder.UpdateData(
                table: "Pets",
                keyColumn: "Id",
                keyValue: 43,
                column: "CreatedTime",
                value: new DateTime(2024, 9, 2, 11, 3, 37, 12, DateTimeKind.Local).AddTicks(1870));

            migrationBuilder.UpdateData(
                table: "Pets",
                keyColumn: "Id",
                keyValue: 44,
                column: "CreatedTime",
                value: new DateTime(2024, 9, 2, 11, 3, 37, 12, DateTimeKind.Local).AddTicks(1870));

            migrationBuilder.UpdateData(
                table: "Pets",
                keyColumn: "Id",
                keyValue: 45,
                column: "CreatedTime",
                value: new DateTime(2024, 9, 2, 11, 3, 37, 12, DateTimeKind.Local).AddTicks(1880));

            migrationBuilder.UpdateData(
                table: "Pets",
                keyColumn: "Id",
                keyValue: 46,
                column: "CreatedTime",
                value: new DateTime(2024, 9, 2, 11, 3, 37, 12, DateTimeKind.Local).AddTicks(1880));

            migrationBuilder.UpdateData(
                table: "Pets",
                keyColumn: "Id",
                keyValue: 47,
                column: "CreatedTime",
                value: new DateTime(2024, 9, 2, 11, 3, 37, 12, DateTimeKind.Local).AddTicks(1880));

            migrationBuilder.UpdateData(
                table: "Pets",
                keyColumn: "Id",
                keyValue: 48,
                column: "CreatedTime",
                value: new DateTime(2024, 9, 2, 11, 3, 37, 12, DateTimeKind.Local).AddTicks(1890));

            migrationBuilder.UpdateData(
                table: "Pets",
                keyColumn: "Id",
                keyValue: 49,
                column: "CreatedTime",
                value: new DateTime(2024, 9, 2, 11, 3, 37, 12, DateTimeKind.Local).AddTicks(1890));

            migrationBuilder.UpdateData(
                table: "Pets",
                keyColumn: "Id",
                keyValue: 50,
                column: "CreatedTime",
                value: new DateTime(2024, 9, 2, 11, 3, 37, 12, DateTimeKind.Local).AddTicks(1890));

            migrationBuilder.UpdateData(
                table: "Shelters",
                keyColumn: "Id",
                keyValue: 1021,
                columns: new[] { "CreatedTime", "LastUpdatedTime" },
                values: new object[] { new DateTime(2024, 9, 2, 7, 3, 37, 8, DateTimeKind.Utc).AddTicks(8320), new DateTime(2024, 9, 2, 7, 3, 37, 8, DateTimeKind.Utc).AddTicks(8330) });

            migrationBuilder.UpdateData(
                table: "Shelters",
                keyColumn: "Id",
                keyValue: 1022,
                columns: new[] { "CreatedTime", "LastUpdatedTime" },
                values: new object[] { new DateTime(2024, 9, 2, 7, 3, 37, 8, DateTimeKind.Utc).AddTicks(8340), new DateTime(2024, 9, 2, 7, 3, 37, 8, DateTimeKind.Utc).AddTicks(8340) });

            migrationBuilder.UpdateData(
                table: "Shelters",
                keyColumn: "Id",
                keyValue: 1023,
                columns: new[] { "CreatedTime", "LastUpdatedTime" },
                values: new object[] { new DateTime(2024, 9, 2, 7, 3, 37, 8, DateTimeKind.Utc).AddTicks(8340), new DateTime(2024, 9, 2, 7, 3, 37, 8, DateTimeKind.Utc).AddTicks(8340) });

            migrationBuilder.UpdateData(
                table: "Shelters",
                keyColumn: "Id",
                keyValue: 1024,
                columns: new[] { "CreatedTime", "LastUpdatedTime" },
                values: new object[] { new DateTime(2024, 9, 2, 7, 3, 37, 8, DateTimeKind.Utc).AddTicks(8350), new DateTime(2024, 9, 2, 7, 3, 37, 8, DateTimeKind.Utc).AddTicks(8350) });

            migrationBuilder.UpdateData(
                table: "Shelters",
                keyColumn: "Id",
                keyValue: 1025,
                columns: new[] { "CreatedTime", "LastUpdatedTime" },
                values: new object[] { new DateTime(2024, 9, 2, 7, 3, 37, 8, DateTimeKind.Utc).AddTicks(8350), new DateTime(2024, 9, 2, 7, 3, 37, 8, DateTimeKind.Utc).AddTicks(8360) });

            migrationBuilder.UpdateData(
                table: "Shelters",
                keyColumn: "Id",
                keyValue: 1026,
                columns: new[] { "CreatedTime", "LastUpdatedTime" },
                values: new object[] { new DateTime(2024, 9, 2, 7, 3, 37, 8, DateTimeKind.Utc).AddTicks(8380), new DateTime(2024, 9, 2, 7, 3, 37, 8, DateTimeKind.Utc).AddTicks(8380) });

            migrationBuilder.UpdateData(
                table: "Shelters",
                keyColumn: "Id",
                keyValue: 1027,
                columns: new[] { "CreatedTime", "LastUpdatedTime" },
                values: new object[] { new DateTime(2024, 9, 2, 7, 3, 37, 8, DateTimeKind.Utc).AddTicks(8390), new DateTime(2024, 9, 2, 7, 3, 37, 8, DateTimeKind.Utc).AddTicks(8390) });

            migrationBuilder.UpdateData(
                table: "Shelters",
                keyColumn: "Id",
                keyValue: 1028,
                columns: new[] { "CreatedTime", "LastUpdatedTime" },
                values: new object[] { new DateTime(2024, 9, 2, 7, 3, 37, 8, DateTimeKind.Utc).AddTicks(8390), new DateTime(2024, 9, 2, 7, 3, 37, 8, DateTimeKind.Utc).AddTicks(8390) });

            migrationBuilder.UpdateData(
                table: "Shelters",
                keyColumn: "Id",
                keyValue: 1029,
                columns: new[] { "CreatedTime", "LastUpdatedTime" },
                values: new object[] { new DateTime(2024, 9, 2, 7, 3, 37, 8, DateTimeKind.Utc).AddTicks(8400), new DateTime(2024, 9, 2, 7, 3, 37, 8, DateTimeKind.Utc).AddTicks(8400) });

            migrationBuilder.UpdateData(
                table: "Shelters",
                keyColumn: "Id",
                keyValue: 1030,
                columns: new[] { "CreatedTime", "LastUpdatedTime" },
                values: new object[] { new DateTime(2024, 9, 2, 7, 3, 37, 8, DateTimeKind.Utc).AddTicks(8400), new DateTime(2024, 9, 2, 7, 3, 37, 8, DateTimeKind.Utc).AddTicks(8400) });

            migrationBuilder.UpdateData(
                table: "Shelters",
                keyColumn: "Id",
                keyValue: 1031,
                columns: new[] { "CreatedTime", "LastUpdatedTime" },
                values: new object[] { new DateTime(2024, 9, 2, 7, 3, 37, 8, DateTimeKind.Utc).AddTicks(8410), new DateTime(2024, 9, 2, 7, 3, 37, 8, DateTimeKind.Utc).AddTicks(8410) });

            migrationBuilder.UpdateData(
                table: "Shelters",
                keyColumn: "Id",
                keyValue: 1032,
                columns: new[] { "CreatedTime", "LastUpdatedTime" },
                values: new object[] { new DateTime(2024, 9, 2, 7, 3, 37, 8, DateTimeKind.Utc).AddTicks(8420), new DateTime(2024, 9, 2, 7, 3, 37, 8, DateTimeKind.Utc).AddTicks(8420) });

            migrationBuilder.UpdateData(
                table: "Shelters",
                keyColumn: "Id",
                keyValue: 1033,
                columns: new[] { "CreatedTime", "LastUpdatedTime" },
                values: new object[] { new DateTime(2024, 9, 2, 7, 3, 37, 8, DateTimeKind.Utc).AddTicks(8420), new DateTime(2024, 9, 2, 7, 3, 37, 8, DateTimeKind.Utc).AddTicks(8420) });

            migrationBuilder.UpdateData(
                table: "Shelters",
                keyColumn: "Id",
                keyValue: 1034,
                columns: new[] { "CreatedTime", "LastUpdatedTime" },
                values: new object[] { new DateTime(2024, 9, 2, 7, 3, 37, 8, DateTimeKind.Utc).AddTicks(8430), new DateTime(2024, 9, 2, 7, 3, 37, 8, DateTimeKind.Utc).AddTicks(8430) });

            migrationBuilder.UpdateData(
                table: "Shelters",
                keyColumn: "Id",
                keyValue: 1035,
                columns: new[] { "CreatedTime", "LastUpdatedTime" },
                values: new object[] { new DateTime(2024, 9, 2, 7, 3, 37, 8, DateTimeKind.Utc).AddTicks(8430), new DateTime(2024, 9, 2, 7, 3, 37, 8, DateTimeKind.Utc).AddTicks(8430) });

            migrationBuilder.UpdateData(
                table: "Shelters",
                keyColumn: "Id",
                keyValue: 1036,
                columns: new[] { "CreatedTime", "LastUpdatedTime" },
                values: new object[] { new DateTime(2024, 9, 2, 7, 3, 37, 8, DateTimeKind.Utc).AddTicks(8440), new DateTime(2024, 9, 2, 7, 3, 37, 8, DateTimeKind.Utc).AddTicks(8440) });

            migrationBuilder.UpdateData(
                table: "Shelters",
                keyColumn: "Id",
                keyValue: 1037,
                columns: new[] { "CreatedTime", "LastUpdatedTime" },
                values: new object[] { new DateTime(2024, 9, 2, 7, 3, 37, 8, DateTimeKind.Utc).AddTicks(8450), new DateTime(2024, 9, 2, 7, 3, 37, 8, DateTimeKind.Utc).AddTicks(8450) });

            migrationBuilder.UpdateData(
                table: "Shelters",
                keyColumn: "Id",
                keyValue: 1038,
                columns: new[] { "CreatedTime", "LastUpdatedTime" },
                values: new object[] { new DateTime(2024, 9, 2, 7, 3, 37, 8, DateTimeKind.Utc).AddTicks(8450), new DateTime(2024, 9, 2, 7, 3, 37, 8, DateTimeKind.Utc).AddTicks(8450) });

            migrationBuilder.UpdateData(
                table: "Shelters",
                keyColumn: "Id",
                keyValue: 1039,
                columns: new[] { "CreatedTime", "LastUpdatedTime" },
                values: new object[] { new DateTime(2024, 9, 2, 7, 3, 37, 8, DateTimeKind.Utc).AddTicks(8460), new DateTime(2024, 9, 2, 7, 3, 37, 8, DateTimeKind.Utc).AddTicks(8460) });

            migrationBuilder.UpdateData(
                table: "Shelters",
                keyColumn: "Id",
                keyValue: 1040,
                columns: new[] { "CreatedTime", "LastUpdatedTime" },
                values: new object[] { new DateTime(2024, 9, 2, 7, 3, 37, 8, DateTimeKind.Utc).AddTicks(8470), new DateTime(2024, 9, 2, 7, 3, 37, 8, DateTimeKind.Utc).AddTicks(8470) });
        }
    }
}
