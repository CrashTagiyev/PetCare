using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Persistance.Migrations
{
    /// <inheritdoc />
    public partial class mig987 : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "AppUserPetType",
                columns: table => new
                {
                    ProficientPetTypesId = table.Column<int>(type: "int", nullable: false),
                    VetsId = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AppUserPetType", x => new { x.ProficientPetTypesId, x.VetsId });
                    table.ForeignKey(
                        name: "FK_AppUserPetType_AspNetUsers_VetsId",
                        column: x => x.VetsId,
                        principalTable: "AspNetUsers",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_AppUserPetType_PetTypes_ProficientPetTypesId",
                        column: x => x.ProficientPetTypesId,
                        principalTable: "PetTypes",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

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

            migrationBuilder.CreateIndex(
                name: "IX_AppUserPetType_VetsId",
                table: "AppUserPetType",
                column: "VetsId");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "AppUserPetType");

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: 2001,
                columns: new[] { "ConcurrencyStamp", "CreatedTime", "LastUpdatedTime", "RefreshTokenCreateTime" },
                values: new object[] { "44d0e08d-074a-4e67-b828-aa351f0751d7", new DateTime(2024, 8, 16, 16, 24, 29, 966, DateTimeKind.Utc).AddTicks(820), new DateTime(2024, 8, 16, 16, 24, 29, 966, DateTimeKind.Utc).AddTicks(822), new DateTime(2024, 8, 16, 20, 24, 29, 966, DateTimeKind.Local).AddTicks(710) });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: 2002,
                columns: new[] { "ConcurrencyStamp", "CreatedTime", "LastUpdatedTime", "RefreshTokenCreateTime" },
                values: new object[] { "6127a97e-d398-4bc0-9ecc-7482d3091729", new DateTime(2024, 8, 16, 16, 24, 29, 966, DateTimeKind.Utc).AddTicks(865), new DateTime(2024, 8, 16, 16, 24, 29, 966, DateTimeKind.Utc).AddTicks(865), new DateTime(2024, 8, 16, 20, 24, 29, 966, DateTimeKind.Local).AddTicks(849) });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: 2003,
                columns: new[] { "ConcurrencyStamp", "CreatedTime", "LastUpdatedTime", "RefreshTokenCreateTime" },
                values: new object[] { "e1926a47-374e-4e26-935a-ec2560932564", new DateTime(2024, 8, 16, 16, 24, 29, 966, DateTimeKind.Utc).AddTicks(945), new DateTime(2024, 8, 16, 16, 24, 29, 966, DateTimeKind.Utc).AddTicks(946), new DateTime(2024, 8, 16, 20, 24, 29, 966, DateTimeKind.Local).AddTicks(938) });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: 2004,
                columns: new[] { "ConcurrencyStamp", "CreatedTime", "LastUpdatedTime", "RefreshTokenCreateTime" },
                values: new object[] { "2d22cb50-0338-4aa6-b1d1-1d1134818729", new DateTime(2024, 8, 16, 16, 24, 29, 966, DateTimeKind.Utc).AddTicks(960), new DateTime(2024, 8, 16, 16, 24, 29, 966, DateTimeKind.Utc).AddTicks(960), new DateTime(2024, 8, 16, 20, 24, 29, 966, DateTimeKind.Local).AddTicks(954) });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: 2005,
                columns: new[] { "ConcurrencyStamp", "CreatedTime", "LastUpdatedTime", "RefreshTokenCreateTime" },
                values: new object[] { "31ab1b85-7009-4a6b-97b9-621db496370d", new DateTime(2024, 8, 16, 16, 24, 29, 966, DateTimeKind.Utc).AddTicks(975), new DateTime(2024, 8, 16, 16, 24, 29, 966, DateTimeKind.Utc).AddTicks(975), new DateTime(2024, 8, 16, 20, 24, 29, 966, DateTimeKind.Local).AddTicks(969) });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: 2006,
                columns: new[] { "ConcurrencyStamp", "CreatedTime", "LastUpdatedTime", "RefreshTokenCreateTime" },
                values: new object[] { "41cf8376-e96b-40ce-8215-a3d4fdcc1a72", new DateTime(2024, 8, 16, 16, 24, 29, 966, DateTimeKind.Utc).AddTicks(994), new DateTime(2024, 8, 16, 16, 24, 29, 966, DateTimeKind.Utc).AddTicks(994), new DateTime(2024, 8, 16, 20, 24, 29, 966, DateTimeKind.Local).AddTicks(988) });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: 2007,
                columns: new[] { "ConcurrencyStamp", "CreatedTime", "LastUpdatedTime", "RefreshTokenCreateTime" },
                values: new object[] { "0f2f8336-3202-49ee-95e5-6303605a5c7b", new DateTime(2024, 8, 16, 16, 24, 29, 966, DateTimeKind.Utc).AddTicks(1009), new DateTime(2024, 8, 16, 16, 24, 29, 966, DateTimeKind.Utc).AddTicks(1010), new DateTime(2024, 8, 16, 20, 24, 29, 966, DateTimeKind.Local).AddTicks(1003) });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: 2008,
                columns: new[] { "ConcurrencyStamp", "CreatedTime", "LastUpdatedTime", "RefreshTokenCreateTime" },
                values: new object[] { "85cb79c0-21d5-43af-896b-0d7c197b10f7", new DateTime(2024, 8, 16, 16, 24, 29, 966, DateTimeKind.Utc).AddTicks(1024), new DateTime(2024, 8, 16, 16, 24, 29, 966, DateTimeKind.Utc).AddTicks(1025), new DateTime(2024, 8, 16, 20, 24, 29, 966, DateTimeKind.Local).AddTicks(1018) });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: 2009,
                columns: new[] { "ConcurrencyStamp", "CreatedTime", "LastUpdatedTime", "RefreshTokenCreateTime" },
                values: new object[] { "b274cfb7-252c-4839-84b8-b0e1924e104b", new DateTime(2024, 8, 16, 16, 24, 29, 966, DateTimeKind.Utc).AddTicks(1039), new DateTime(2024, 8, 16, 16, 24, 29, 966, DateTimeKind.Utc).AddTicks(1040), new DateTime(2024, 8, 16, 20, 24, 29, 966, DateTimeKind.Local).AddTicks(1034) });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: 2010,
                columns: new[] { "ConcurrencyStamp", "CreatedTime", "LastUpdatedTime", "RefreshTokenCreateTime" },
                values: new object[] { "0184de23-7bc2-4861-8294-1985be1dfdc1", new DateTime(2024, 8, 16, 16, 24, 29, 966, DateTimeKind.Utc).AddTicks(1061), new DateTime(2024, 8, 16, 16, 24, 29, 966, DateTimeKind.Utc).AddTicks(1061), new DateTime(2024, 8, 16, 20, 24, 29, 966, DateTimeKind.Local).AddTicks(1050) });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: 2011,
                columns: new[] { "ConcurrencyStamp", "CreatedTime", "LastUpdatedTime", "RefreshTokenCreateTime" },
                values: new object[] { "3d7c08d9-d9ec-4cf7-9716-f7c83b01c4a5", new DateTime(2024, 8, 16, 16, 24, 29, 966, DateTimeKind.Utc).AddTicks(1076), new DateTime(2024, 8, 16, 16, 24, 29, 966, DateTimeKind.Utc).AddTicks(1077), new DateTime(2024, 8, 16, 20, 24, 29, 966, DateTimeKind.Local).AddTicks(1071) });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: 2012,
                columns: new[] { "ConcurrencyStamp", "CreatedTime", "LastUpdatedTime", "RefreshTokenCreateTime" },
                values: new object[] { "b69755ab-2dc2-4c1a-82a4-4bf1313ed133", new DateTime(2024, 8, 16, 16, 24, 29, 966, DateTimeKind.Utc).AddTicks(1131), new DateTime(2024, 8, 16, 16, 24, 29, 966, DateTimeKind.Utc).AddTicks(1132), new DateTime(2024, 8, 16, 20, 24, 29, 966, DateTimeKind.Local).AddTicks(1125) });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: 2013,
                columns: new[] { "ConcurrencyStamp", "CreatedTime", "LastUpdatedTime", "RefreshTokenCreateTime" },
                values: new object[] { "f2e1656a-6539-4eb2-bc5d-ba5624e5f300", new DateTime(2024, 8, 16, 16, 24, 29, 966, DateTimeKind.Utc).AddTicks(1147), new DateTime(2024, 8, 16, 16, 24, 29, 966, DateTimeKind.Utc).AddTicks(1147), new DateTime(2024, 8, 16, 20, 24, 29, 966, DateTimeKind.Local).AddTicks(1141) });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: 2014,
                columns: new[] { "ConcurrencyStamp", "CreatedTime", "LastUpdatedTime", "RefreshTokenCreateTime" },
                values: new object[] { "bd938109-ca6a-4d6f-b8d8-69b2f08d49a0", new DateTime(2024, 8, 16, 16, 24, 29, 966, DateTimeKind.Utc).AddTicks(1161), new DateTime(2024, 8, 16, 16, 24, 29, 966, DateTimeKind.Utc).AddTicks(1162), new DateTime(2024, 8, 16, 20, 24, 29, 966, DateTimeKind.Local).AddTicks(1156) });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: 2015,
                columns: new[] { "ConcurrencyStamp", "CreatedTime", "LastUpdatedTime", "RefreshTokenCreateTime" },
                values: new object[] { "a971b087-08cb-4c17-811a-6afb37702748", new DateTime(2024, 8, 16, 16, 24, 29, 966, DateTimeKind.Utc).AddTicks(1176), new DateTime(2024, 8, 16, 16, 24, 29, 966, DateTimeKind.Utc).AddTicks(1176), new DateTime(2024, 8, 16, 20, 24, 29, 966, DateTimeKind.Local).AddTicks(1170) });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: 2016,
                columns: new[] { "ConcurrencyStamp", "CreatedTime", "LastUpdatedTime", "RefreshTokenCreateTime" },
                values: new object[] { "ad6cc927-27af-4442-943d-d30dd2338dcb", new DateTime(2024, 8, 16, 16, 24, 29, 966, DateTimeKind.Utc).AddTicks(1190), new DateTime(2024, 8, 16, 16, 24, 29, 966, DateTimeKind.Utc).AddTicks(1191), new DateTime(2024, 8, 16, 20, 24, 29, 966, DateTimeKind.Local).AddTicks(1185) });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: 2017,
                columns: new[] { "ConcurrencyStamp", "CreatedTime", "LastUpdatedTime", "RefreshTokenCreateTime" },
                values: new object[] { "77037f31-9b2e-43c5-8c71-e6a58ecc0ea0", new DateTime(2024, 8, 16, 16, 24, 29, 966, DateTimeKind.Utc).AddTicks(1205), new DateTime(2024, 8, 16, 16, 24, 29, 966, DateTimeKind.Utc).AddTicks(1205), new DateTime(2024, 8, 16, 20, 24, 29, 966, DateTimeKind.Local).AddTicks(1199) });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: 2018,
                columns: new[] { "ConcurrencyStamp", "CreatedTime", "LastUpdatedTime", "RefreshTokenCreateTime" },
                values: new object[] { "93da719e-10e2-4925-a20e-83515a57a9b5", new DateTime(2024, 8, 16, 16, 24, 29, 966, DateTimeKind.Utc).AddTicks(1225), new DateTime(2024, 8, 16, 16, 24, 29, 966, DateTimeKind.Utc).AddTicks(1226), new DateTime(2024, 8, 16, 20, 24, 29, 966, DateTimeKind.Local).AddTicks(1216) });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: 2019,
                columns: new[] { "ConcurrencyStamp", "CreatedTime", "LastUpdatedTime", "RefreshTokenCreateTime" },
                values: new object[] { "edb4ef6b-f2d3-4a20-923c-abeb9a2daacf", new DateTime(2024, 8, 16, 16, 24, 29, 966, DateTimeKind.Utc).AddTicks(1240), new DateTime(2024, 8, 16, 16, 24, 29, 966, DateTimeKind.Utc).AddTicks(1241), new DateTime(2024, 8, 16, 20, 24, 29, 966, DateTimeKind.Local).AddTicks(1235) });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: 2020,
                columns: new[] { "ConcurrencyStamp", "CreatedTime", "LastUpdatedTime", "RefreshTokenCreateTime" },
                values: new object[] { "9758ab7a-30b2-495e-809f-c8f24ff11625", new DateTime(2024, 8, 16, 16, 24, 29, 966, DateTimeKind.Utc).AddTicks(1255), new DateTime(2024, 8, 16, 16, 24, 29, 966, DateTimeKind.Utc).AddTicks(1255), new DateTime(2024, 8, 16, 20, 24, 29, 966, DateTimeKind.Local).AddTicks(1249) });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: 2021,
                columns: new[] { "ConcurrencyStamp", "CreatedTime", "LastUpdatedTime", "RefreshTokenCreateTime" },
                values: new object[] { "be471e69-612f-40ee-b15d-6407e66eaab3", new DateTime(2024, 8, 16, 16, 24, 29, 966, DateTimeKind.Utc).AddTicks(1308), new DateTime(2024, 8, 16, 16, 24, 29, 966, DateTimeKind.Utc).AddTicks(1308), new DateTime(2024, 8, 16, 20, 24, 29, 966, DateTimeKind.Local).AddTicks(1302) });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: 2022,
                columns: new[] { "ConcurrencyStamp", "CreatedTime", "LastUpdatedTime", "RefreshTokenCreateTime" },
                values: new object[] { "22687ebb-203e-4812-8061-eb10e23201dc", new DateTime(2024, 8, 16, 16, 24, 29, 966, DateTimeKind.Utc).AddTicks(1331), new DateTime(2024, 8, 16, 16, 24, 29, 966, DateTimeKind.Utc).AddTicks(1331), new DateTime(2024, 8, 16, 20, 24, 29, 966, DateTimeKind.Local).AddTicks(1324) });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: 2023,
                columns: new[] { "ConcurrencyStamp", "CreatedTime", "LastUpdatedTime", "RefreshTokenCreateTime" },
                values: new object[] { "d6337ead-ab1d-4e13-9424-09db774559ee", new DateTime(2024, 8, 16, 16, 24, 29, 966, DateTimeKind.Utc).AddTicks(1347), new DateTime(2024, 8, 16, 16, 24, 29, 966, DateTimeKind.Utc).AddTicks(1347), new DateTime(2024, 8, 16, 20, 24, 29, 966, DateTimeKind.Local).AddTicks(1341) });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: 2024,
                columns: new[] { "ConcurrencyStamp", "CreatedTime", "LastUpdatedTime", "RefreshTokenCreateTime" },
                values: new object[] { "45b5aee9-672b-4448-a541-fbb7b689e9fe", new DateTime(2024, 8, 16, 16, 24, 29, 966, DateTimeKind.Utc).AddTicks(1363), new DateTime(2024, 8, 16, 16, 24, 29, 966, DateTimeKind.Utc).AddTicks(1363), new DateTime(2024, 8, 16, 20, 24, 29, 966, DateTimeKind.Local).AddTicks(1357) });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: 2025,
                columns: new[] { "ConcurrencyStamp", "CreatedTime", "LastUpdatedTime", "RefreshTokenCreateTime" },
                values: new object[] { "8396ee5e-d474-4d00-8ca0-af20144354d7", new DateTime(2024, 8, 16, 16, 24, 29, 966, DateTimeKind.Utc).AddTicks(1379), new DateTime(2024, 8, 16, 16, 24, 29, 966, DateTimeKind.Utc).AddTicks(1380), new DateTime(2024, 8, 16, 20, 24, 29, 966, DateTimeKind.Local).AddTicks(1373) });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: 2026,
                columns: new[] { "ConcurrencyStamp", "CreatedTime", "LastUpdatedTime", "RefreshTokenCreateTime" },
                values: new object[] { "037bce16-9d37-4dc6-af33-33450cba96f3", new DateTime(2024, 8, 16, 16, 24, 29, 966, DateTimeKind.Utc).AddTicks(1398), new DateTime(2024, 8, 16, 16, 24, 29, 966, DateTimeKind.Utc).AddTicks(1398), new DateTime(2024, 8, 16, 20, 24, 29, 966, DateTimeKind.Local).AddTicks(1390) });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: 2027,
                columns: new[] { "ConcurrencyStamp", "CreatedTime", "LastUpdatedTime", "RefreshTokenCreateTime" },
                values: new object[] { "4a590b81-988d-4203-a4c7-4c83ae5fcd07", new DateTime(2024, 8, 16, 16, 24, 29, 966, DateTimeKind.Utc).AddTicks(1414), new DateTime(2024, 8, 16, 16, 24, 29, 966, DateTimeKind.Utc).AddTicks(1414), new DateTime(2024, 8, 16, 20, 24, 29, 966, DateTimeKind.Local).AddTicks(1408) });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: 2028,
                columns: new[] { "ConcurrencyStamp", "CreatedTime", "LastUpdatedTime", "RefreshTokenCreateTime" },
                values: new object[] { "8e72629f-831d-4d40-ad1b-428fded4f207", new DateTime(2024, 8, 16, 16, 24, 29, 966, DateTimeKind.Utc).AddTicks(1430), new DateTime(2024, 8, 16, 16, 24, 29, 966, DateTimeKind.Utc).AddTicks(1430), new DateTime(2024, 8, 16, 20, 24, 29, 966, DateTimeKind.Local).AddTicks(1424) });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: 2029,
                columns: new[] { "ConcurrencyStamp", "CreatedTime", "LastUpdatedTime", "RefreshTokenCreateTime" },
                values: new object[] { "2a8fb5e0-4dd4-4684-8119-2a5af830a9e5", new DateTime(2024, 8, 16, 16, 24, 29, 966, DateTimeKind.Utc).AddTicks(1481), new DateTime(2024, 8, 16, 16, 24, 29, 966, DateTimeKind.Utc).AddTicks(1481), new DateTime(2024, 8, 16, 20, 24, 29, 966, DateTimeKind.Local).AddTicks(1440) });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: 2030,
                columns: new[] { "ConcurrencyStamp", "CreatedTime", "LastUpdatedTime", "RefreshTokenCreateTime" },
                values: new object[] { "9344269a-588b-4f57-8266-a24690c449ef", new DateTime(2024, 8, 16, 16, 24, 29, 966, DateTimeKind.Utc).AddTicks(1498), new DateTime(2024, 8, 16, 16, 24, 29, 966, DateTimeKind.Utc).AddTicks(1498), new DateTime(2024, 8, 16, 20, 24, 29, 966, DateTimeKind.Local).AddTicks(1492) });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: 2031,
                columns: new[] { "ConcurrencyStamp", "CreatedTime", "LastUpdatedTime", "RefreshTokenCreateTime" },
                values: new object[] { "75d88893-081e-4797-a432-c709f71bfe73", new DateTime(2024, 8, 16, 16, 24, 29, 966, DateTimeKind.Utc).AddTicks(1513), new DateTime(2024, 8, 16, 16, 24, 29, 966, DateTimeKind.Utc).AddTicks(1514), new DateTime(2024, 8, 16, 20, 24, 29, 966, DateTimeKind.Local).AddTicks(1508) });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: 2032,
                columns: new[] { "ConcurrencyStamp", "CreatedTime", "LastUpdatedTime", "RefreshTokenCreateTime" },
                values: new object[] { "ce9d35a0-fb25-490a-af48-c24f88600614", new DateTime(2024, 8, 16, 16, 24, 29, 966, DateTimeKind.Utc).AddTicks(1531), new DateTime(2024, 8, 16, 16, 24, 29, 966, DateTimeKind.Utc).AddTicks(1531), new DateTime(2024, 8, 16, 20, 24, 29, 966, DateTimeKind.Local).AddTicks(1524) });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: 2033,
                columns: new[] { "ConcurrencyStamp", "CreatedTime", "LastUpdatedTime", "RefreshTokenCreateTime" },
                values: new object[] { "c544cf29-5e00-4239-93c7-280f32a9cc0a", new DateTime(2024, 8, 16, 16, 24, 29, 966, DateTimeKind.Utc).AddTicks(1547), new DateTime(2024, 8, 16, 16, 24, 29, 966, DateTimeKind.Utc).AddTicks(1548), new DateTime(2024, 8, 16, 20, 24, 29, 966, DateTimeKind.Local).AddTicks(1542) });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: 2034,
                columns: new[] { "ConcurrencyStamp", "CreatedTime", "LastUpdatedTime", "RefreshTokenCreateTime" },
                values: new object[] { "6178b5cd-4e00-43f5-bd78-132c3110bb38", new DateTime(2024, 8, 16, 16, 24, 29, 966, DateTimeKind.Utc).AddTicks(1571), new DateTime(2024, 8, 16, 16, 24, 29, 966, DateTimeKind.Utc).AddTicks(1571), new DateTime(2024, 8, 16, 20, 24, 29, 966, DateTimeKind.Local).AddTicks(1561) });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: 2035,
                columns: new[] { "ConcurrencyStamp", "CreatedTime", "LastUpdatedTime", "RefreshTokenCreateTime" },
                values: new object[] { "c8bb41e3-7948-4135-9fcc-8e43fe314f42", new DateTime(2024, 8, 16, 16, 24, 29, 966, DateTimeKind.Utc).AddTicks(1587), new DateTime(2024, 8, 16, 16, 24, 29, 966, DateTimeKind.Utc).AddTicks(1588), new DateTime(2024, 8, 16, 20, 24, 29, 966, DateTimeKind.Local).AddTicks(1581) });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: 2036,
                columns: new[] { "ConcurrencyStamp", "CreatedTime", "LastUpdatedTime", "RefreshTokenCreateTime" },
                values: new object[] { "cf5d6025-0ace-4ea0-9bef-f3cee45db3f8", new DateTime(2024, 8, 16, 16, 24, 29, 966, DateTimeKind.Utc).AddTicks(1603), new DateTime(2024, 8, 16, 16, 24, 29, 966, DateTimeKind.Utc).AddTicks(1604), new DateTime(2024, 8, 16, 20, 24, 29, 966, DateTimeKind.Local).AddTicks(1598) });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: 2037,
                columns: new[] { "ConcurrencyStamp", "CreatedTime", "LastUpdatedTime", "RefreshTokenCreateTime" },
                values: new object[] { "cb87bd1d-66c2-4eb1-a7f5-c0631208dbf5", new DateTime(2024, 8, 16, 16, 24, 29, 966, DateTimeKind.Utc).AddTicks(1620), new DateTime(2024, 8, 16, 16, 24, 29, 966, DateTimeKind.Utc).AddTicks(1620), new DateTime(2024, 8, 16, 20, 24, 29, 966, DateTimeKind.Local).AddTicks(1614) });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: 2038,
                columns: new[] { "ConcurrencyStamp", "CreatedTime", "LastUpdatedTime", "RefreshTokenCreateTime" },
                values: new object[] { "8356fec2-7eee-4382-9d74-964f4240e8a9", new DateTime(2024, 8, 16, 16, 24, 29, 966, DateTimeKind.Utc).AddTicks(1740), new DateTime(2024, 8, 16, 16, 24, 29, 966, DateTimeKind.Utc).AddTicks(1741), new DateTime(2024, 8, 16, 20, 24, 29, 966, DateTimeKind.Local).AddTicks(1732) });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: 2039,
                columns: new[] { "ConcurrencyStamp", "CreatedTime", "LastUpdatedTime", "RefreshTokenCreateTime" },
                values: new object[] { "363df187-5681-429f-8a51-c3c83333e7e6", new DateTime(2024, 8, 16, 16, 24, 29, 966, DateTimeKind.Utc).AddTicks(1757), new DateTime(2024, 8, 16, 16, 24, 29, 966, DateTimeKind.Utc).AddTicks(1757), new DateTime(2024, 8, 16, 20, 24, 29, 966, DateTimeKind.Local).AddTicks(1751) });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: 2040,
                columns: new[] { "ConcurrencyStamp", "CreatedTime", "LastUpdatedTime", "RefreshTokenCreateTime" },
                values: new object[] { "4aa6f188-a7a2-4fe8-9c9f-8bf139e98f4b", new DateTime(2024, 8, 16, 16, 24, 29, 966, DateTimeKind.Utc).AddTicks(1773), new DateTime(2024, 8, 16, 16, 24, 29, 966, DateTimeKind.Utc).AddTicks(1773), new DateTime(2024, 8, 16, 20, 24, 29, 966, DateTimeKind.Local).AddTicks(1767) });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: 2041,
                columns: new[] { "ConcurrencyStamp", "CreatedTime", "LastUpdatedTime", "RefreshTokenCreateTime" },
                values: new object[] { "2afeeba6-9e87-4b9d-886e-88bcde5cd9b7", new DateTime(2024, 8, 16, 16, 24, 29, 966, DateTimeKind.Utc).AddTicks(1789), new DateTime(2024, 8, 16, 16, 24, 29, 966, DateTimeKind.Utc).AddTicks(1789), new DateTime(2024, 8, 16, 20, 24, 29, 966, DateTimeKind.Local).AddTicks(1783) });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: 2042,
                columns: new[] { "ConcurrencyStamp", "CreatedTime", "LastUpdatedTime", "RefreshTokenCreateTime" },
                values: new object[] { "52acd9a6-bdbb-4a03-ae49-6327c0117e82", new DateTime(2024, 8, 16, 16, 24, 29, 966, DateTimeKind.Utc).AddTicks(1812), new DateTime(2024, 8, 16, 16, 24, 29, 966, DateTimeKind.Utc).AddTicks(1812), new DateTime(2024, 8, 16, 20, 24, 29, 966, DateTimeKind.Local).AddTicks(1803) });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: 2043,
                columns: new[] { "ConcurrencyStamp", "CreatedTime", "LastUpdatedTime", "RefreshTokenCreateTime" },
                values: new object[] { "259dd369-0522-40bf-8530-6daae97dbe8b", new DateTime(2024, 8, 16, 16, 24, 29, 966, DateTimeKind.Utc).AddTicks(1828), new DateTime(2024, 8, 16, 16, 24, 29, 966, DateTimeKind.Utc).AddTicks(1828), new DateTime(2024, 8, 16, 20, 24, 29, 966, DateTimeKind.Local).AddTicks(1822) });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: 2044,
                columns: new[] { "ConcurrencyStamp", "CreatedTime", "LastUpdatedTime", "RefreshTokenCreateTime" },
                values: new object[] { "0a03583e-7b63-4734-bdd6-16be27a72d7a", new DateTime(2024, 8, 16, 16, 24, 29, 966, DateTimeKind.Utc).AddTicks(1842), new DateTime(2024, 8, 16, 16, 24, 29, 966, DateTimeKind.Utc).AddTicks(1843), new DateTime(2024, 8, 16, 20, 24, 29, 966, DateTimeKind.Local).AddTicks(1837) });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: 2045,
                columns: new[] { "ConcurrencyStamp", "CreatedTime", "LastUpdatedTime", "RefreshTokenCreateTime" },
                values: new object[] { "4954c410-a8f3-4efa-9499-70b50b59a3c6", new DateTime(2024, 8, 16, 16, 24, 29, 966, DateTimeKind.Utc).AddTicks(1857), new DateTime(2024, 8, 16, 16, 24, 29, 966, DateTimeKind.Utc).AddTicks(1857), new DateTime(2024, 8, 16, 20, 24, 29, 966, DateTimeKind.Local).AddTicks(1851) });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: 2046,
                columns: new[] { "ConcurrencyStamp", "CreatedTime", "LastUpdatedTime", "RefreshTokenCreateTime" },
                values: new object[] { "b6955dac-71ac-4fa3-b79c-726e44991d1f", new DateTime(2024, 8, 16, 16, 24, 29, 966, DateTimeKind.Utc).AddTicks(1871), new DateTime(2024, 8, 16, 16, 24, 29, 966, DateTimeKind.Utc).AddTicks(1872), new DateTime(2024, 8, 16, 20, 24, 29, 966, DateTimeKind.Local).AddTicks(1866) });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: 2047,
                columns: new[] { "ConcurrencyStamp", "CreatedTime", "LastUpdatedTime", "RefreshTokenCreateTime" },
                values: new object[] { "9c1111d3-ba7f-46ee-b439-10f839838412", new DateTime(2024, 8, 16, 16, 24, 29, 966, DateTimeKind.Utc).AddTicks(1910), new DateTime(2024, 8, 16, 16, 24, 29, 966, DateTimeKind.Utc).AddTicks(1911), new DateTime(2024, 8, 16, 20, 24, 29, 966, DateTimeKind.Local).AddTicks(1905) });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: 2048,
                columns: new[] { "ConcurrencyStamp", "CreatedTime", "LastUpdatedTime", "RefreshTokenCreateTime" },
                values: new object[] { "31008eff-2ba3-4e94-b63f-ad8ba0e62e08", new DateTime(2024, 8, 16, 16, 24, 29, 966, DateTimeKind.Utc).AddTicks(1925), new DateTime(2024, 8, 16, 16, 24, 29, 966, DateTimeKind.Utc).AddTicks(1925), new DateTime(2024, 8, 16, 20, 24, 29, 966, DateTimeKind.Local).AddTicks(1920) });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: 2049,
                columns: new[] { "ConcurrencyStamp", "CreatedTime", "LastUpdatedTime", "RefreshTokenCreateTime" },
                values: new object[] { "0b9cf85f-8ee4-4a1f-b96e-4651912b86d2", new DateTime(2024, 8, 16, 16, 24, 29, 966, DateTimeKind.Utc).AddTicks(1940), new DateTime(2024, 8, 16, 16, 24, 29, 966, DateTimeKind.Utc).AddTicks(1940), new DateTime(2024, 8, 16, 20, 24, 29, 966, DateTimeKind.Local).AddTicks(1934) });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: 2050,
                columns: new[] { "ConcurrencyStamp", "CreatedTime", "LastUpdatedTime", "RefreshTokenCreateTime" },
                values: new object[] { "40a14dfd-76ae-44e5-8ec1-d78e090e4e33", new DateTime(2024, 8, 16, 16, 24, 29, 966, DateTimeKind.Utc).AddTicks(1958), new DateTime(2024, 8, 16, 16, 24, 29, 966, DateTimeKind.Utc).AddTicks(1958), new DateTime(2024, 8, 16, 20, 24, 29, 966, DateTimeKind.Local).AddTicks(1950) });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: 2051,
                columns: new[] { "ConcurrencyStamp", "CreatedTime", "LastUpdatedTime", "RefreshTokenCreateTime" },
                values: new object[] { "6cb20a72-79a1-4e88-9281-ba8e9bf975aa", new DateTime(2024, 8, 16, 16, 24, 29, 966, DateTimeKind.Utc).AddTicks(1972), new DateTime(2024, 8, 16, 16, 24, 29, 966, DateTimeKind.Utc).AddTicks(1973), new DateTime(2024, 8, 16, 20, 24, 29, 966, DateTimeKind.Local).AddTicks(1967) });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: 2052,
                columns: new[] { "ConcurrencyStamp", "CreatedTime", "LastUpdatedTime", "RefreshTokenCreateTime" },
                values: new object[] { "8d0eaff2-5489-451c-b47a-526af9d6a19b", new DateTime(2024, 8, 16, 16, 24, 29, 966, DateTimeKind.Utc).AddTicks(1987), new DateTime(2024, 8, 16, 16, 24, 29, 966, DateTimeKind.Utc).AddTicks(1988), new DateTime(2024, 8, 16, 20, 24, 29, 966, DateTimeKind.Local).AddTicks(1982) });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: 2053,
                columns: new[] { "ConcurrencyStamp", "CreatedTime", "LastUpdatedTime", "RefreshTokenCreateTime" },
                values: new object[] { "408679ce-0f53-4274-be57-0c58e2e7cc43", new DateTime(2024, 8, 16, 16, 24, 29, 966, DateTimeKind.Utc).AddTicks(2002), new DateTime(2024, 8, 16, 16, 24, 29, 966, DateTimeKind.Utc).AddTicks(2002), new DateTime(2024, 8, 16, 20, 24, 29, 966, DateTimeKind.Local).AddTicks(1996) });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: 2054,
                columns: new[] { "ConcurrencyStamp", "CreatedTime", "LastUpdatedTime", "RefreshTokenCreateTime" },
                values: new object[] { "537feb0b-36a8-4848-a12a-136468a42845", new DateTime(2024, 8, 16, 16, 24, 29, 966, DateTimeKind.Utc).AddTicks(2016), new DateTime(2024, 8, 16, 16, 24, 29, 966, DateTimeKind.Utc).AddTicks(2016), new DateTime(2024, 8, 16, 20, 24, 29, 966, DateTimeKind.Local).AddTicks(2011) });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: 2055,
                columns: new[] { "ConcurrencyStamp", "CreatedTime", "LastUpdatedTime", "RefreshTokenCreateTime" },
                values: new object[] { "8367e7e3-6acd-4da9-850e-de7283f563f4", new DateTime(2024, 8, 16, 16, 24, 29, 966, DateTimeKind.Utc).AddTicks(2097), new DateTime(2024, 8, 16, 16, 24, 29, 966, DateTimeKind.Utc).AddTicks(2097), new DateTime(2024, 8, 16, 20, 24, 29, 966, DateTimeKind.Local).AddTicks(2025) });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: 2056,
                columns: new[] { "ConcurrencyStamp", "CreatedTime", "LastUpdatedTime", "RefreshTokenCreateTime" },
                values: new object[] { "2087648f-3bd7-4307-81f0-0b7174ee3b36", new DateTime(2024, 8, 16, 16, 24, 29, 966, DateTimeKind.Utc).AddTicks(2113), new DateTime(2024, 8, 16, 16, 24, 29, 966, DateTimeKind.Utc).AddTicks(2113), new DateTime(2024, 8, 16, 20, 24, 29, 966, DateTimeKind.Local).AddTicks(2106) });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: 2057,
                columns: new[] { "ConcurrencyStamp", "CreatedTime", "LastUpdatedTime", "RefreshTokenCreateTime" },
                values: new object[] { "2d5e3341-b5ec-4714-b065-436a95f335c6", new DateTime(2024, 8, 16, 16, 24, 29, 966, DateTimeKind.Utc).AddTicks(2128), new DateTime(2024, 8, 16, 16, 24, 29, 966, DateTimeKind.Utc).AddTicks(2128), new DateTime(2024, 8, 16, 20, 24, 29, 966, DateTimeKind.Local).AddTicks(2122) });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: 2058,
                columns: new[] { "ConcurrencyStamp", "CreatedTime", "LastUpdatedTime", "RefreshTokenCreateTime" },
                values: new object[] { "ccc796f1-210b-48a2-bf2f-7f06e68b3ab4", new DateTime(2024, 8, 16, 16, 24, 29, 966, DateTimeKind.Utc).AddTicks(2146), new DateTime(2024, 8, 16, 16, 24, 29, 966, DateTimeKind.Utc).AddTicks(2146), new DateTime(2024, 8, 16, 20, 24, 29, 966, DateTimeKind.Local).AddTicks(2137) });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: 2059,
                columns: new[] { "ConcurrencyStamp", "CreatedTime", "LastUpdatedTime", "RefreshTokenCreateTime" },
                values: new object[] { "2dfe9bec-c244-4d0d-9bfb-c4a8920d5c29", new DateTime(2024, 8, 16, 16, 24, 29, 966, DateTimeKind.Utc).AddTicks(2161), new DateTime(2024, 8, 16, 16, 24, 29, 966, DateTimeKind.Utc).AddTicks(2161), new DateTime(2024, 8, 16, 20, 24, 29, 966, DateTimeKind.Local).AddTicks(2155) });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: 2060,
                columns: new[] { "ConcurrencyStamp", "CreatedTime", "LastUpdatedTime", "RefreshTokenCreateTime" },
                values: new object[] { "016edb72-7f1e-42b9-baa6-e68cab4a3a48", new DateTime(2024, 8, 16, 16, 24, 29, 966, DateTimeKind.Utc).AddTicks(2176), new DateTime(2024, 8, 16, 16, 24, 29, 966, DateTimeKind.Utc).AddTicks(2176), new DateTime(2024, 8, 16, 20, 24, 29, 966, DateTimeKind.Local).AddTicks(2170) });
        }
    }
}
