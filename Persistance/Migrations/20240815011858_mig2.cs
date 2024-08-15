using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Persistance.Migrations
{
    /// <inheritdoc />
    public partial class mig2 : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AlterColumn<int>(
                name: "Likes",
                table: "AspNetUsers",
                type: "int",
                nullable: true,
                oldClrType: typeof(int),
                oldType: "int");

            migrationBuilder.AlterColumn<int>(
                name: "Dislikes",
                table: "AspNetUsers",
                type: "int",
                nullable: true,
                oldClrType: typeof(int),
                oldType: "int");

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: 2001,
                columns: new[] { "ConcurrencyStamp", "CreatedTime", "Dislikes", "LastUpdatedTime", "Likes", "RefreshTokenCreateTime" },
                values: new object[] { "093a95a0-eebb-4b5d-86a8-d018d297c244", new DateTime(2024, 8, 15, 1, 18, 57, 29, DateTimeKind.Utc).AddTicks(6728), 1, new DateTime(2024, 8, 15, 1, 18, 57, 29, DateTimeKind.Utc).AddTicks(6730), 1, new DateTime(2024, 8, 15, 5, 18, 57, 29, DateTimeKind.Local).AddTicks(6612) });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: 2002,
                columns: new[] { "ConcurrencyStamp", "CreatedTime", "Dislikes", "LastUpdatedTime", "Likes", "RefreshTokenCreateTime" },
                values: new object[] { "56684a2e-a6b4-490e-9bd5-0a2d9e3ddb4a", new DateTime(2024, 8, 15, 1, 18, 57, 29, DateTimeKind.Utc).AddTicks(6765), 1, new DateTime(2024, 8, 15, 1, 18, 57, 29, DateTimeKind.Utc).AddTicks(6765), 1, new DateTime(2024, 8, 15, 5, 18, 57, 29, DateTimeKind.Local).AddTicks(6757) });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: 2003,
                columns: new[] { "ConcurrencyStamp", "CreatedTime", "Dislikes", "LastUpdatedTime", "Likes", "RefreshTokenCreateTime" },
                values: new object[] { "5c00c299-6772-4dd5-9c38-bbc7a7306be2", new DateTime(2024, 8, 15, 1, 18, 57, 29, DateTimeKind.Utc).AddTicks(6780), 1, new DateTime(2024, 8, 15, 1, 18, 57, 29, DateTimeKind.Utc).AddTicks(6780), 1, new DateTime(2024, 8, 15, 5, 18, 57, 29, DateTimeKind.Local).AddTicks(6774) });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: 2004,
                columns: new[] { "ConcurrencyStamp", "CreatedTime", "Dislikes", "LastUpdatedTime", "Likes", "RefreshTokenCreateTime" },
                values: new object[] { "26cd4000-7d5f-4fa1-93de-08500d116132", new DateTime(2024, 8, 15, 1, 18, 57, 29, DateTimeKind.Utc).AddTicks(6805), 1, new DateTime(2024, 8, 15, 1, 18, 57, 29, DateTimeKind.Utc).AddTicks(6805), 1, new DateTime(2024, 8, 15, 5, 18, 57, 29, DateTimeKind.Local).AddTicks(6788) });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: 2005,
                columns: new[] { "ConcurrencyStamp", "CreatedTime", "Dislikes", "LastUpdatedTime", "Likes", "RefreshTokenCreateTime" },
                values: new object[] { "fdc7b326-fb28-431a-92d2-fbfdc481d64e", new DateTime(2024, 8, 15, 1, 18, 57, 29, DateTimeKind.Utc).AddTicks(6818), 1, new DateTime(2024, 8, 15, 1, 18, 57, 29, DateTimeKind.Utc).AddTicks(6819), 1, new DateTime(2024, 8, 15, 5, 18, 57, 29, DateTimeKind.Local).AddTicks(6813) });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: 2006,
                columns: new[] { "ConcurrencyStamp", "CreatedTime", "Dislikes", "LastUpdatedTime", "Likes", "RefreshTokenCreateTime" },
                values: new object[] { "852b544e-1be0-4751-9cb9-f8d970c72bb8", new DateTime(2024, 8, 15, 1, 18, 57, 29, DateTimeKind.Utc).AddTicks(6836), 1, new DateTime(2024, 8, 15, 1, 18, 57, 29, DateTimeKind.Utc).AddTicks(6836), 1, new DateTime(2024, 8, 15, 5, 18, 57, 29, DateTimeKind.Local).AddTicks(6830) });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: 2007,
                columns: new[] { "ConcurrencyStamp", "CreatedTime", "Dislikes", "LastUpdatedTime", "Likes", "RefreshTokenCreateTime" },
                values: new object[] { "041a4a0b-609f-40dd-8713-50cda871500d", new DateTime(2024, 8, 15, 1, 18, 57, 29, DateTimeKind.Utc).AddTicks(6849), 1, new DateTime(2024, 8, 15, 1, 18, 57, 29, DateTimeKind.Utc).AddTicks(6849), 1, new DateTime(2024, 8, 15, 5, 18, 57, 29, DateTimeKind.Local).AddTicks(6843) });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: 2008,
                columns: new[] { "ConcurrencyStamp", "CreatedTime", "Dislikes", "LastUpdatedTime", "Likes", "RefreshTokenCreateTime" },
                values: new object[] { "10d157b9-632e-41f1-8b1a-94c984dbd397", new DateTime(2024, 8, 15, 1, 18, 57, 29, DateTimeKind.Utc).AddTicks(6862), 1, new DateTime(2024, 8, 15, 1, 18, 57, 29, DateTimeKind.Utc).AddTicks(6862), 1, new DateTime(2024, 8, 15, 5, 18, 57, 29, DateTimeKind.Local).AddTicks(6856) });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: 2009,
                columns: new[] { "ConcurrencyStamp", "CreatedTime", "Dislikes", "LastUpdatedTime", "Likes", "RefreshTokenCreateTime" },
                values: new object[] { "747b9667-ad40-4f46-a11d-0ac2e85c6224", new DateTime(2024, 8, 15, 1, 18, 57, 29, DateTimeKind.Utc).AddTicks(6943), 1, new DateTime(2024, 8, 15, 1, 18, 57, 29, DateTimeKind.Utc).AddTicks(6943), 1, new DateTime(2024, 8, 15, 5, 18, 57, 29, DateTimeKind.Local).AddTicks(6936) });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: 2010,
                columns: new[] { "ConcurrencyStamp", "CreatedTime", "Dislikes", "LastUpdatedTime", "Likes", "RefreshTokenCreateTime" },
                values: new object[] { "e221100e-0d14-4d92-9054-dbea7404ad6d", new DateTime(2024, 8, 15, 1, 18, 57, 29, DateTimeKind.Utc).AddTicks(6962), 1, new DateTime(2024, 8, 15, 1, 18, 57, 29, DateTimeKind.Utc).AddTicks(6963), 1, new DateTime(2024, 8, 15, 5, 18, 57, 29, DateTimeKind.Local).AddTicks(6952) });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: 2011,
                columns: new[] { "ConcurrencyStamp", "CreatedTime", "Dislikes", "LastUpdatedTime", "Likes", "RefreshTokenCreateTime" },
                values: new object[] { "0cdf4490-e6cc-4880-a8b5-d1c1d8414767", new DateTime(2024, 8, 15, 1, 18, 57, 29, DateTimeKind.Utc).AddTicks(6978), 1, new DateTime(2024, 8, 15, 1, 18, 57, 29, DateTimeKind.Utc).AddTicks(6978), 1, new DateTime(2024, 8, 15, 5, 18, 57, 29, DateTimeKind.Local).AddTicks(6972) });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: 2012,
                columns: new[] { "ConcurrencyStamp", "CreatedTime", "Dislikes", "LastUpdatedTime", "Likes", "RefreshTokenCreateTime" },
                values: new object[] { "78495064-b28b-459d-abbd-2195a6c6c081", new DateTime(2024, 8, 15, 1, 18, 57, 29, DateTimeKind.Utc).AddTicks(6996), 1, new DateTime(2024, 8, 15, 1, 18, 57, 29, DateTimeKind.Utc).AddTicks(6996), 1, new DateTime(2024, 8, 15, 5, 18, 57, 29, DateTimeKind.Local).AddTicks(6986) });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: 2013,
                columns: new[] { "ConcurrencyStamp", "CreatedTime", "Dislikes", "LastUpdatedTime", "Likes", "RefreshTokenCreateTime" },
                values: new object[] { "00b6d6e6-aa9b-439b-8299-a0d78f5cd1c9", new DateTime(2024, 8, 15, 1, 18, 57, 29, DateTimeKind.Utc).AddTicks(7010), 1, new DateTime(2024, 8, 15, 1, 18, 57, 29, DateTimeKind.Utc).AddTicks(7010), 1, new DateTime(2024, 8, 15, 5, 18, 57, 29, DateTimeKind.Local).AddTicks(7004) });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: 2014,
                columns: new[] { "ConcurrencyStamp", "CreatedTime", "Dislikes", "LastUpdatedTime", "Likes", "RefreshTokenCreateTime" },
                values: new object[] { "154680cd-7cf3-445e-9afd-5a0cfa3b7d6f", new DateTime(2024, 8, 15, 1, 18, 57, 29, DateTimeKind.Utc).AddTicks(7023), 1, new DateTime(2024, 8, 15, 1, 18, 57, 29, DateTimeKind.Utc).AddTicks(7024), 1, new DateTime(2024, 8, 15, 5, 18, 57, 29, DateTimeKind.Local).AddTicks(7018) });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: 2015,
                columns: new[] { "ConcurrencyStamp", "CreatedTime", "Dislikes", "LastUpdatedTime", "Likes", "RefreshTokenCreateTime" },
                values: new object[] { "3e9aa146-1329-4004-b69a-3ae5bf0a27bf", new DateTime(2024, 8, 15, 1, 18, 57, 29, DateTimeKind.Utc).AddTicks(7037), 1, new DateTime(2024, 8, 15, 1, 18, 57, 29, DateTimeKind.Utc).AddTicks(7038), 1, new DateTime(2024, 8, 15, 5, 18, 57, 29, DateTimeKind.Local).AddTicks(7032) });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: 2016,
                columns: new[] { "ConcurrencyStamp", "CreatedTime", "Dislikes", "LastUpdatedTime", "Likes", "RefreshTokenCreateTime" },
                values: new object[] { "b39fd919-4049-496e-9c0e-962e50443a24", new DateTime(2024, 8, 15, 1, 18, 57, 29, DateTimeKind.Utc).AddTicks(7051), 1, new DateTime(2024, 8, 15, 1, 18, 57, 29, DateTimeKind.Utc).AddTicks(7052), 1, new DateTime(2024, 8, 15, 5, 18, 57, 29, DateTimeKind.Local).AddTicks(7045) });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: 2017,
                columns: new[] { "ConcurrencyStamp", "CreatedTime", "Dislikes", "LastUpdatedTime", "Likes", "RefreshTokenCreateTime" },
                values: new object[] { "26f43411-4060-4880-84ec-bcf76dc616e1", new DateTime(2024, 8, 15, 1, 18, 57, 29, DateTimeKind.Utc).AddTicks(7064), 1, new DateTime(2024, 8, 15, 1, 18, 57, 29, DateTimeKind.Utc).AddTicks(7065), 1, new DateTime(2024, 8, 15, 5, 18, 57, 29, DateTimeKind.Local).AddTicks(7059) });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: 2018,
                columns: new[] { "ConcurrencyStamp", "CreatedTime", "Dislikes", "LastUpdatedTime", "Likes", "RefreshTokenCreateTime" },
                values: new object[] { "460f9a8a-c9a4-4a3f-863a-ef0eb3c0ce86", new DateTime(2024, 8, 15, 1, 18, 57, 29, DateTimeKind.Utc).AddTicks(7118), 1, new DateTime(2024, 8, 15, 1, 18, 57, 29, DateTimeKind.Utc).AddTicks(7119), 1, new DateTime(2024, 8, 15, 5, 18, 57, 29, DateTimeKind.Local).AddTicks(7112) });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: 2019,
                columns: new[] { "ConcurrencyStamp", "CreatedTime", "Dislikes", "LastUpdatedTime", "Likes", "RefreshTokenCreateTime" },
                values: new object[] { "ecbd6dd6-2987-42b7-8d2e-fb0b4dff8c1a", new DateTime(2024, 8, 15, 1, 18, 57, 29, DateTimeKind.Utc).AddTicks(7133), 1, new DateTime(2024, 8, 15, 1, 18, 57, 29, DateTimeKind.Utc).AddTicks(7133), 1, new DateTime(2024, 8, 15, 5, 18, 57, 29, DateTimeKind.Local).AddTicks(7127) });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: 2020,
                columns: new[] { "ConcurrencyStamp", "CreatedTime", "Dislikes", "LastUpdatedTime", "Likes", "RefreshTokenCreateTime" },
                values: new object[] { "5c858805-fd2a-4cee-990f-edcd1e62c7b1", new DateTime(2024, 8, 15, 1, 18, 57, 29, DateTimeKind.Utc).AddTicks(7149), 1, new DateTime(2024, 8, 15, 1, 18, 57, 29, DateTimeKind.Utc).AddTicks(7150), 1, new DateTime(2024, 8, 15, 5, 18, 57, 29, DateTimeKind.Local).AddTicks(7141) });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: 2021,
                columns: new[] { "ConcurrencyStamp", "CreatedTime", "Dislikes", "LastUpdatedTime", "Likes", "RefreshTokenCreateTime" },
                values: new object[] { "6ebb62af-714a-4765-9bb7-8a8b768bd1c0", new DateTime(2024, 8, 15, 1, 18, 57, 29, DateTimeKind.Utc).AddTicks(7163), 1, new DateTime(2024, 8, 15, 1, 18, 57, 29, DateTimeKind.Utc).AddTicks(7164), 1, new DateTime(2024, 8, 15, 5, 18, 57, 29, DateTimeKind.Local).AddTicks(7158) });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: 2022,
                columns: new[] { "ConcurrencyStamp", "CreatedTime", "Dislikes", "LastUpdatedTime", "Likes", "RefreshTokenCreateTime" },
                values: new object[] { "07b013c8-a5f0-4240-8d01-1764350d5c1b", new DateTime(2024, 8, 15, 1, 18, 57, 29, DateTimeKind.Utc).AddTicks(7184), 1, new DateTime(2024, 8, 15, 1, 18, 57, 29, DateTimeKind.Utc).AddTicks(7184), 1, new DateTime(2024, 8, 15, 5, 18, 57, 29, DateTimeKind.Local).AddTicks(7178) });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: 2023,
                columns: new[] { "ConcurrencyStamp", "CreatedTime", "Dislikes", "LastUpdatedTime", "Likes", "RefreshTokenCreateTime" },
                values: new object[] { "829c5ebe-47dc-4e9f-b694-7c35c8fbe043", new DateTime(2024, 8, 15, 1, 18, 57, 29, DateTimeKind.Utc).AddTicks(7199), 1, new DateTime(2024, 8, 15, 1, 18, 57, 29, DateTimeKind.Utc).AddTicks(7199), 1, new DateTime(2024, 8, 15, 5, 18, 57, 29, DateTimeKind.Local).AddTicks(7193) });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: 2024,
                columns: new[] { "ConcurrencyStamp", "CreatedTime", "Dislikes", "LastUpdatedTime", "Likes", "RefreshTokenCreateTime" },
                values: new object[] { "6a5bcd68-49fb-42fc-a4ef-7b5d9e27c28f", new DateTime(2024, 8, 15, 1, 18, 57, 29, DateTimeKind.Utc).AddTicks(7214), 1, new DateTime(2024, 8, 15, 1, 18, 57, 29, DateTimeKind.Utc).AddTicks(7214), 1, new DateTime(2024, 8, 15, 5, 18, 57, 29, DateTimeKind.Local).AddTicks(7208) });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: 2025,
                columns: new[] { "ConcurrencyStamp", "CreatedTime", "Dislikes", "LastUpdatedTime", "Likes", "RefreshTokenCreateTime" },
                values: new object[] { "da218fad-899c-4975-a6ed-c67e4743eda6", new DateTime(2024, 8, 15, 1, 18, 57, 29, DateTimeKind.Utc).AddTicks(7228), 1, new DateTime(2024, 8, 15, 1, 18, 57, 29, DateTimeKind.Utc).AddTicks(7229), 1, new DateTime(2024, 8, 15, 5, 18, 57, 29, DateTimeKind.Local).AddTicks(7222) });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: 2026,
                columns: new[] { "ConcurrencyStamp", "CreatedTime", "Dislikes", "LastUpdatedTime", "Likes", "RefreshTokenCreateTime" },
                values: new object[] { "3ba5ef6d-1591-46f3-bedb-8a9228f16f07", new DateTime(2024, 8, 15, 1, 18, 57, 29, DateTimeKind.Utc).AddTicks(7278), 1, new DateTime(2024, 8, 15, 1, 18, 57, 29, DateTimeKind.Utc).AddTicks(7279), 1, new DateTime(2024, 8, 15, 5, 18, 57, 29, DateTimeKind.Local).AddTicks(7272) });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: 2027,
                columns: new[] { "ConcurrencyStamp", "CreatedTime", "Dislikes", "LastUpdatedTime", "Likes", "RefreshTokenCreateTime" },
                values: new object[] { "57919dfd-8495-4751-87e1-dcfbd67b7fa6", new DateTime(2024, 8, 15, 1, 18, 57, 29, DateTimeKind.Utc).AddTicks(7292), 1, new DateTime(2024, 8, 15, 1, 18, 57, 29, DateTimeKind.Utc).AddTicks(7293), 1, new DateTime(2024, 8, 15, 5, 18, 57, 29, DateTimeKind.Local).AddTicks(7287) });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: 2028,
                columns: new[] { "ConcurrencyStamp", "CreatedTime", "Dislikes", "LastUpdatedTime", "Likes", "RefreshTokenCreateTime" },
                values: new object[] { "391e9038-a5b3-402f-bfc0-e5e90aca92e0", new DateTime(2024, 8, 15, 1, 18, 57, 29, DateTimeKind.Utc).AddTicks(7309), 1, new DateTime(2024, 8, 15, 1, 18, 57, 29, DateTimeKind.Utc).AddTicks(7310), 1, new DateTime(2024, 8, 15, 5, 18, 57, 29, DateTimeKind.Local).AddTicks(7300) });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: 2029,
                columns: new[] { "ConcurrencyStamp", "CreatedTime", "Dislikes", "LastUpdatedTime", "Likes", "RefreshTokenCreateTime" },
                values: new object[] { "8229783d-4671-4fe1-a745-cc46a0027ae8", new DateTime(2024, 8, 15, 1, 18, 57, 29, DateTimeKind.Utc).AddTicks(7323), 1, new DateTime(2024, 8, 15, 1, 18, 57, 29, DateTimeKind.Utc).AddTicks(7323), 1, new DateTime(2024, 8, 15, 5, 18, 57, 29, DateTimeKind.Local).AddTicks(7317) });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: 2030,
                columns: new[] { "ConcurrencyStamp", "CreatedTime", "Dislikes", "LastUpdatedTime", "Likes", "RefreshTokenCreateTime" },
                values: new object[] { "a33ee509-85b1-4ee2-aba6-2c41996a674c", new DateTime(2024, 8, 15, 1, 18, 57, 29, DateTimeKind.Utc).AddTicks(7336), 1, new DateTime(2024, 8, 15, 1, 18, 57, 29, DateTimeKind.Utc).AddTicks(7337), 1, new DateTime(2024, 8, 15, 5, 18, 57, 29, DateTimeKind.Local).AddTicks(7331) });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: 2031,
                columns: new[] { "ConcurrencyStamp", "CreatedTime", "Dislikes", "LastUpdatedTime", "Likes", "RefreshTokenCreateTime" },
                values: new object[] { "f00ccc51-0a00-415e-9d5d-2ba504aca47e", new DateTime(2024, 8, 15, 1, 18, 57, 29, DateTimeKind.Utc).AddTicks(7350), 1, new DateTime(2024, 8, 15, 1, 18, 57, 29, DateTimeKind.Utc).AddTicks(7351), 1, new DateTime(2024, 8, 15, 5, 18, 57, 29, DateTimeKind.Local).AddTicks(7345) });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: 2032,
                columns: new[] { "ConcurrencyStamp", "CreatedTime", "Dislikes", "LastUpdatedTime", "Likes", "RefreshTokenCreateTime" },
                values: new object[] { "1974fd40-68f4-489b-a35b-f5c007412a82", new DateTime(2024, 8, 15, 1, 18, 57, 29, DateTimeKind.Utc).AddTicks(7364), 1, new DateTime(2024, 8, 15, 1, 18, 57, 29, DateTimeKind.Utc).AddTicks(7364), 1, new DateTime(2024, 8, 15, 5, 18, 57, 29, DateTimeKind.Local).AddTicks(7358) });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: 2033,
                columns: new[] { "ConcurrencyStamp", "CreatedTime", "Dislikes", "LastUpdatedTime", "Likes", "RefreshTokenCreateTime" },
                values: new object[] { "bf718164-f925-4941-8f8d-e5eccc98601f", new DateTime(2024, 8, 15, 1, 18, 57, 29, DateTimeKind.Utc).AddTicks(7377), 1, new DateTime(2024, 8, 15, 1, 18, 57, 29, DateTimeKind.Utc).AddTicks(7378), 1, new DateTime(2024, 8, 15, 5, 18, 57, 29, DateTimeKind.Local).AddTicks(7372) });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: 2034,
                columns: new[] { "ConcurrencyStamp", "CreatedTime", "Dislikes", "LastUpdatedTime", "Likes", "RefreshTokenCreateTime" },
                values: new object[] { "26cb1811-d1a9-4daa-87d7-c6e683606cf8", new DateTime(2024, 8, 15, 1, 18, 57, 29, DateTimeKind.Utc).AddTicks(7429), 1, new DateTime(2024, 8, 15, 1, 18, 57, 29, DateTimeKind.Utc).AddTicks(7429), 1, new DateTime(2024, 8, 15, 5, 18, 57, 29, DateTimeKind.Local).AddTicks(7387) });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: 2035,
                columns: new[] { "ConcurrencyStamp", "CreatedTime", "Dislikes", "LastUpdatedTime", "Likes", "RefreshTokenCreateTime" },
                values: new object[] { "2f873d08-b9b8-46f8-9a27-c0e1bfc30630", new DateTime(2024, 8, 15, 1, 18, 57, 29, DateTimeKind.Utc).AddTicks(7444), 1, new DateTime(2024, 8, 15, 1, 18, 57, 29, DateTimeKind.Utc).AddTicks(7444), 1, new DateTime(2024, 8, 15, 5, 18, 57, 29, DateTimeKind.Local).AddTicks(7437) });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: 2036,
                columns: new[] { "ConcurrencyStamp", "CreatedTime", "Dislikes", "LastUpdatedTime", "Likes", "RefreshTokenCreateTime" },
                values: new object[] { "c898ffd2-a1f0-42c4-8ee0-480001feae59", new DateTime(2024, 8, 15, 1, 18, 57, 29, DateTimeKind.Utc).AddTicks(7461), 1, new DateTime(2024, 8, 15, 1, 18, 57, 29, DateTimeKind.Utc).AddTicks(7462), 1, new DateTime(2024, 8, 15, 5, 18, 57, 29, DateTimeKind.Local).AddTicks(7452) });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: 2037,
                columns: new[] { "ConcurrencyStamp", "CreatedTime", "Dislikes", "LastUpdatedTime", "Likes", "RefreshTokenCreateTime" },
                values: new object[] { "94a1b31a-2a3d-4d17-9bff-738217d5b4f0", new DateTime(2024, 8, 15, 1, 18, 57, 29, DateTimeKind.Utc).AddTicks(7476), 1, new DateTime(2024, 8, 15, 1, 18, 57, 29, DateTimeKind.Utc).AddTicks(7476), 1, new DateTime(2024, 8, 15, 5, 18, 57, 29, DateTimeKind.Local).AddTicks(7470) });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: 2038,
                columns: new[] { "ConcurrencyStamp", "CreatedTime", "Dislikes", "LastUpdatedTime", "Likes", "RefreshTokenCreateTime" },
                values: new object[] { "744a5b20-aa80-4c70-b4a4-c04dae7ec527", new DateTime(2024, 8, 15, 1, 18, 57, 29, DateTimeKind.Utc).AddTicks(7490), 1, new DateTime(2024, 8, 15, 1, 18, 57, 29, DateTimeKind.Utc).AddTicks(7490), 1, new DateTime(2024, 8, 15, 5, 18, 57, 29, DateTimeKind.Local).AddTicks(7484) });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: 2039,
                columns: new[] { "ConcurrencyStamp", "CreatedTime", "Dislikes", "LastUpdatedTime", "Likes", "RefreshTokenCreateTime" },
                values: new object[] { "44eba794-bf8b-476a-b68e-4c78b99037c5", new DateTime(2024, 8, 15, 1, 18, 57, 29, DateTimeKind.Utc).AddTicks(7504), 1, new DateTime(2024, 8, 15, 1, 18, 57, 29, DateTimeKind.Utc).AddTicks(7504), 1, new DateTime(2024, 8, 15, 5, 18, 57, 29, DateTimeKind.Local).AddTicks(7499) });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: 2040,
                columns: new[] { "ConcurrencyStamp", "CreatedTime", "Dislikes", "LastUpdatedTime", "Likes", "RefreshTokenCreateTime" },
                values: new object[] { "6bf04544-4a86-492a-aee3-0d5a4c97d1be", new DateTime(2024, 8, 15, 1, 18, 57, 29, DateTimeKind.Utc).AddTicks(7518), 1, new DateTime(2024, 8, 15, 1, 18, 57, 29, DateTimeKind.Utc).AddTicks(7518), 1, new DateTime(2024, 8, 15, 5, 18, 57, 29, DateTimeKind.Local).AddTicks(7512) });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: 2041,
                columns: new[] { "ConcurrencyStamp", "CreatedTime", "Dislikes", "LastUpdatedTime", "Likes", "RefreshTokenCreateTime" },
                values: new object[] { "9f70f20e-2abe-4235-84d6-a50198fd2ac6", new DateTime(2024, 8, 15, 1, 18, 57, 29, DateTimeKind.Utc).AddTicks(7531), 1, new DateTime(2024, 8, 15, 1, 18, 57, 29, DateTimeKind.Utc).AddTicks(7531), 1, new DateTime(2024, 8, 15, 5, 18, 57, 29, DateTimeKind.Local).AddTicks(7526) });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: 2042,
                columns: new[] { "ConcurrencyStamp", "CreatedTime", "Dislikes", "LastUpdatedTime", "Likes", "RefreshTokenCreateTime" },
                values: new object[] { "fb3c776b-39bc-4452-a1be-72f9bd3712e4", new DateTime(2024, 8, 15, 1, 18, 57, 29, DateTimeKind.Utc).AddTicks(7551), 1, new DateTime(2024, 8, 15, 1, 18, 57, 29, DateTimeKind.Utc).AddTicks(7551), 1, new DateTime(2024, 8, 15, 5, 18, 57, 29, DateTimeKind.Local).AddTicks(7546) });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: 2043,
                columns: new[] { "ConcurrencyStamp", "CreatedTime", "Dislikes", "LastUpdatedTime", "Likes", "RefreshTokenCreateTime" },
                values: new object[] { "ffc0bb7b-9b42-4006-800b-93f9d1f338ca", new DateTime(2024, 8, 15, 1, 18, 57, 29, DateTimeKind.Utc).AddTicks(7602), 1, new DateTime(2024, 8, 15, 1, 18, 57, 29, DateTimeKind.Utc).AddTicks(7602), 1, new DateTime(2024, 8, 15, 5, 18, 57, 29, DateTimeKind.Local).AddTicks(7560) });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: 2044,
                columns: new[] { "ConcurrencyStamp", "CreatedTime", "Dislikes", "LastUpdatedTime", "Likes", "RefreshTokenCreateTime" },
                values: new object[] { "113524f1-cd5a-4c12-9376-ce5e7f60181b", new DateTime(2024, 8, 15, 1, 18, 57, 29, DateTimeKind.Utc).AddTicks(7619), 1, new DateTime(2024, 8, 15, 1, 18, 57, 29, DateTimeKind.Utc).AddTicks(7620), 1, new DateTime(2024, 8, 15, 5, 18, 57, 29, DateTimeKind.Local).AddTicks(7610) });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: 2045,
                columns: new[] { "ConcurrencyStamp", "CreatedTime", "Dislikes", "LastUpdatedTime", "Likes", "RefreshTokenCreateTime" },
                values: new object[] { "764f6c0f-420c-46dd-8a58-f7d7800a4b0c", new DateTime(2024, 8, 15, 1, 18, 57, 29, DateTimeKind.Utc).AddTicks(7633), 1, new DateTime(2024, 8, 15, 1, 18, 57, 29, DateTimeKind.Utc).AddTicks(7634), 1, new DateTime(2024, 8, 15, 5, 18, 57, 29, DateTimeKind.Local).AddTicks(7627) });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: 2046,
                columns: new[] { "ConcurrencyStamp", "CreatedTime", "Dislikes", "LastUpdatedTime", "Likes", "RefreshTokenCreateTime" },
                values: new object[] { "74bb4455-e760-49ad-bbc8-f19122966604", new DateTime(2024, 8, 15, 1, 18, 57, 29, DateTimeKind.Utc).AddTicks(7647), 1, new DateTime(2024, 8, 15, 1, 18, 57, 29, DateTimeKind.Utc).AddTicks(7648), 1, new DateTime(2024, 8, 15, 5, 18, 57, 29, DateTimeKind.Local).AddTicks(7642) });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: 2047,
                columns: new[] { "ConcurrencyStamp", "CreatedTime", "Dislikes", "LastUpdatedTime", "Likes", "RefreshTokenCreateTime" },
                values: new object[] { "afb668f0-49a5-4dbd-9b9d-d6ec8f22964b", new DateTime(2024, 8, 15, 1, 18, 57, 29, DateTimeKind.Utc).AddTicks(7661), 1, new DateTime(2024, 8, 15, 1, 18, 57, 29, DateTimeKind.Utc).AddTicks(7661), 1, new DateTime(2024, 8, 15, 5, 18, 57, 29, DateTimeKind.Local).AddTicks(7655) });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: 2048,
                columns: new[] { "ConcurrencyStamp", "CreatedTime", "Dislikes", "LastUpdatedTime", "Likes", "RefreshTokenCreateTime" },
                values: new object[] { "7fddc4fe-a1fb-4942-8b5b-164036952d60", new DateTime(2024, 8, 15, 1, 18, 57, 29, DateTimeKind.Utc).AddTicks(7674), 1, new DateTime(2024, 8, 15, 1, 18, 57, 29, DateTimeKind.Utc).AddTicks(7675), 1, new DateTime(2024, 8, 15, 5, 18, 57, 29, DateTimeKind.Local).AddTicks(7668) });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: 2049,
                columns: new[] { "ConcurrencyStamp", "CreatedTime", "Dislikes", "LastUpdatedTime", "Likes", "RefreshTokenCreateTime" },
                values: new object[] { "7f653a20-6a6a-463b-8824-8bec8e549f9f", new DateTime(2024, 8, 15, 1, 18, 57, 29, DateTimeKind.Utc).AddTicks(7687), 1, new DateTime(2024, 8, 15, 1, 18, 57, 29, DateTimeKind.Utc).AddTicks(7688), 1, new DateTime(2024, 8, 15, 5, 18, 57, 29, DateTimeKind.Local).AddTicks(7682) });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: 2050,
                columns: new[] { "ConcurrencyStamp", "CreatedTime", "Dislikes", "LastUpdatedTime", "Likes", "RefreshTokenCreateTime" },
                values: new object[] { "1644d690-b619-4af3-b4ea-05dbd57009da", new DateTime(2024, 8, 15, 1, 18, 57, 29, DateTimeKind.Utc).AddTicks(7701), 1, new DateTime(2024, 8, 15, 1, 18, 57, 29, DateTimeKind.Utc).AddTicks(7701), 1, new DateTime(2024, 8, 15, 5, 18, 57, 29, DateTimeKind.Local).AddTicks(7695) });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: 2051,
                columns: new[] { "ConcurrencyStamp", "CreatedTime", "Dislikes", "LastUpdatedTime", "Likes", "RefreshTokenCreateTime" },
                values: new object[] { "d99ed03f-cb5a-4ea5-9ac3-262da6ada0a3", new DateTime(2024, 8, 15, 1, 18, 57, 29, DateTimeKind.Utc).AddTicks(7714), 1, new DateTime(2024, 8, 15, 1, 18, 57, 29, DateTimeKind.Utc).AddTicks(7715), 1, new DateTime(2024, 8, 15, 5, 18, 57, 29, DateTimeKind.Local).AddTicks(7709) });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: 2052,
                columns: new[] { "ConcurrencyStamp", "CreatedTime", "Dislikes", "LastUpdatedTime", "Likes", "RefreshTokenCreateTime" },
                values: new object[] { "f6b58b62-3387-41a1-8a43-c4c7e88104e3", new DateTime(2024, 8, 15, 1, 18, 57, 29, DateTimeKind.Utc).AddTicks(7731), 1, new DateTime(2024, 8, 15, 1, 18, 57, 29, DateTimeKind.Utc).AddTicks(7731), 1, new DateTime(2024, 8, 15, 5, 18, 57, 29, DateTimeKind.Local).AddTicks(7722) });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: 2053,
                columns: new[] { "ConcurrencyStamp", "CreatedTime", "Dislikes", "LastUpdatedTime", "Likes", "RefreshTokenCreateTime" },
                values: new object[] { "0492da3c-3e43-49a6-9235-6645d83ce1a5", new DateTime(2024, 8, 15, 1, 18, 57, 29, DateTimeKind.Utc).AddTicks(7780), 1, new DateTime(2024, 8, 15, 1, 18, 57, 29, DateTimeKind.Utc).AddTicks(7780), 1, new DateTime(2024, 8, 15, 5, 18, 57, 29, DateTimeKind.Local).AddTicks(7774) });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: 2054,
                columns: new[] { "ConcurrencyStamp", "CreatedTime", "Dislikes", "LastUpdatedTime", "Likes", "RefreshTokenCreateTime" },
                values: new object[] { "7591732b-3f4a-4fd8-9431-81c2e775e6a7", new DateTime(2024, 8, 15, 1, 18, 57, 29, DateTimeKind.Utc).AddTicks(7794), 1, new DateTime(2024, 8, 15, 1, 18, 57, 29, DateTimeKind.Utc).AddTicks(7794), 1, new DateTime(2024, 8, 15, 5, 18, 57, 29, DateTimeKind.Local).AddTicks(7788) });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: 2055,
                columns: new[] { "ConcurrencyStamp", "CreatedTime", "Dislikes", "LastUpdatedTime", "Likes", "RefreshTokenCreateTime" },
                values: new object[] { "58d5fa13-6eee-41d8-9953-3458e35f0f5a", new DateTime(2024, 8, 15, 1, 18, 57, 29, DateTimeKind.Utc).AddTicks(7807), 1, new DateTime(2024, 8, 15, 1, 18, 57, 29, DateTimeKind.Utc).AddTicks(7808), 1, new DateTime(2024, 8, 15, 5, 18, 57, 29, DateTimeKind.Local).AddTicks(7802) });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: 2056,
                columns: new[] { "ConcurrencyStamp", "CreatedTime", "Dislikes", "LastUpdatedTime", "Likes", "RefreshTokenCreateTime" },
                values: new object[] { "b0a86d80-1442-47ce-a02e-6687893d5b68", new DateTime(2024, 8, 15, 1, 18, 57, 29, DateTimeKind.Utc).AddTicks(7821), 1, new DateTime(2024, 8, 15, 1, 18, 57, 29, DateTimeKind.Utc).AddTicks(7821), 1, new DateTime(2024, 8, 15, 5, 18, 57, 29, DateTimeKind.Local).AddTicks(7815) });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: 2057,
                columns: new[] { "ConcurrencyStamp", "CreatedTime", "Dislikes", "LastUpdatedTime", "Likes", "RefreshTokenCreateTime" },
                values: new object[] { "aad9537e-d99a-430f-89f0-d0b49b8f3afe", new DateTime(2024, 8, 15, 1, 18, 57, 29, DateTimeKind.Utc).AddTicks(7834), 1, new DateTime(2024, 8, 15, 1, 18, 57, 29, DateTimeKind.Utc).AddTicks(7835), 1, new DateTime(2024, 8, 15, 5, 18, 57, 29, DateTimeKind.Local).AddTicks(7829) });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: 2058,
                columns: new[] { "ConcurrencyStamp", "CreatedTime", "Dislikes", "LastUpdatedTime", "Likes", "RefreshTokenCreateTime" },
                values: new object[] { "84bf252f-fe5b-4cc1-93ab-c9e1b5bdb5cf", new DateTime(2024, 8, 15, 1, 18, 57, 29, DateTimeKind.Utc).AddTicks(7848), 1, new DateTime(2024, 8, 15, 1, 18, 57, 29, DateTimeKind.Utc).AddTicks(7848), 1, new DateTime(2024, 8, 15, 5, 18, 57, 29, DateTimeKind.Local).AddTicks(7842) });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: 2059,
                columns: new[] { "ConcurrencyStamp", "CreatedTime", "Dislikes", "LastUpdatedTime", "Likes", "RefreshTokenCreateTime" },
                values: new object[] { "c5f541d1-9ecd-46ee-ba81-ad0f336d9f0d", new DateTime(2024, 8, 15, 1, 18, 57, 29, DateTimeKind.Utc).AddTicks(7861), 1, new DateTime(2024, 8, 15, 1, 18, 57, 29, DateTimeKind.Utc).AddTicks(7862), 1, new DateTime(2024, 8, 15, 5, 18, 57, 29, DateTimeKind.Local).AddTicks(7856) });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: 2060,
                columns: new[] { "ConcurrencyStamp", "CreatedTime", "Dislikes", "LastUpdatedTime", "Likes", "RefreshTokenCreateTime" },
                values: new object[] { "932e1440-cdf2-45d2-9325-c0aea854212b", new DateTime(2024, 8, 15, 1, 18, 57, 29, DateTimeKind.Utc).AddTicks(7878), 1, new DateTime(2024, 8, 15, 1, 18, 57, 29, DateTimeKind.Utc).AddTicks(7878), 1, new DateTime(2024, 8, 15, 5, 18, 57, 29, DateTimeKind.Local).AddTicks(7869) });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AlterColumn<int>(
                name: "Likes",
                table: "AspNetUsers",
                type: "int",
                nullable: false,
                defaultValue: 0,
                oldClrType: typeof(int),
                oldType: "int",
                oldNullable: true);

            migrationBuilder.AlterColumn<int>(
                name: "Dislikes",
                table: "AspNetUsers",
                type: "int",
                nullable: false,
                defaultValue: 0,
                oldClrType: typeof(int),
                oldType: "int",
                oldNullable: true);

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: 2001,
                columns: new[] { "ConcurrencyStamp", "CreatedTime", "Dislikes", "LastUpdatedTime", "Likes", "RefreshTokenCreateTime" },
                values: new object[] { "33a73321-5750-4b65-bb2d-1788ec4cafe9", new DateTime(2024, 8, 15, 1, 13, 49, 161, DateTimeKind.Utc).AddTicks(6453), 0, new DateTime(2024, 8, 15, 1, 13, 49, 161, DateTimeKind.Utc).AddTicks(6454), 0, new DateTime(2024, 8, 15, 5, 13, 49, 161, DateTimeKind.Local).AddTicks(6346) });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: 2002,
                columns: new[] { "ConcurrencyStamp", "CreatedTime", "Dislikes", "LastUpdatedTime", "Likes", "RefreshTokenCreateTime" },
                values: new object[] { "85e8a777-037c-4dc0-9398-106f8fe0bf37", new DateTime(2024, 8, 15, 1, 13, 49, 161, DateTimeKind.Utc).AddTicks(6487), 0, new DateTime(2024, 8, 15, 1, 13, 49, 161, DateTimeKind.Utc).AddTicks(6487), 0, new DateTime(2024, 8, 15, 5, 13, 49, 161, DateTimeKind.Local).AddTicks(6481) });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: 2003,
                columns: new[] { "ConcurrencyStamp", "CreatedTime", "Dislikes", "LastUpdatedTime", "Likes", "RefreshTokenCreateTime" },
                values: new object[] { "b420fdfd-c5ff-4203-9f65-44603076a833", new DateTime(2024, 8, 15, 1, 13, 49, 161, DateTimeKind.Utc).AddTicks(6510), 0, new DateTime(2024, 8, 15, 1, 13, 49, 161, DateTimeKind.Utc).AddTicks(6511), 0, new DateTime(2024, 8, 15, 5, 13, 49, 161, DateTimeKind.Local).AddTicks(6505) });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: 2004,
                columns: new[] { "ConcurrencyStamp", "CreatedTime", "Dislikes", "LastUpdatedTime", "Likes", "RefreshTokenCreateTime" },
                values: new object[] { "dbc68685-c476-4f8a-bb42-1a8fbf659cb5", new DateTime(2024, 8, 15, 1, 13, 49, 161, DateTimeKind.Utc).AddTicks(6523), 0, new DateTime(2024, 8, 15, 1, 13, 49, 161, DateTimeKind.Utc).AddTicks(6523), 0, new DateTime(2024, 8, 15, 5, 13, 49, 161, DateTimeKind.Local).AddTicks(6518) });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: 2005,
                columns: new[] { "ConcurrencyStamp", "CreatedTime", "Dislikes", "LastUpdatedTime", "Likes", "RefreshTokenCreateTime" },
                values: new object[] { "b894c9af-5b42-4b2b-adfd-944caed2acf4", new DateTime(2024, 8, 15, 1, 13, 49, 161, DateTimeKind.Utc).AddTicks(6536), 0, new DateTime(2024, 8, 15, 1, 13, 49, 161, DateTimeKind.Utc).AddTicks(6537), 0, new DateTime(2024, 8, 15, 5, 13, 49, 161, DateTimeKind.Local).AddTicks(6531) });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: 2006,
                columns: new[] { "ConcurrencyStamp", "CreatedTime", "Dislikes", "LastUpdatedTime", "Likes", "RefreshTokenCreateTime" },
                values: new object[] { "9e023dff-06ad-45cf-b32e-16510f3a3da6", new DateTime(2024, 8, 15, 1, 13, 49, 161, DateTimeKind.Utc).AddTicks(6552), 0, new DateTime(2024, 8, 15, 1, 13, 49, 161, DateTimeKind.Utc).AddTicks(6553), 0, new DateTime(2024, 8, 15, 5, 13, 49, 161, DateTimeKind.Local).AddTicks(6547) });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: 2007,
                columns: new[] { "ConcurrencyStamp", "CreatedTime", "Dislikes", "LastUpdatedTime", "Likes", "RefreshTokenCreateTime" },
                values: new object[] { "457a779f-ce80-4b5f-923a-a520c7490fdb", new DateTime(2024, 8, 15, 1, 13, 49, 161, DateTimeKind.Utc).AddTicks(6565), 0, new DateTime(2024, 8, 15, 1, 13, 49, 161, DateTimeKind.Utc).AddTicks(6565), 0, new DateTime(2024, 8, 15, 5, 13, 49, 161, DateTimeKind.Local).AddTicks(6560) });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: 2008,
                columns: new[] { "ConcurrencyStamp", "CreatedTime", "Dislikes", "LastUpdatedTime", "Likes", "RefreshTokenCreateTime" },
                values: new object[] { "4b4e7c90-194c-47da-98ee-9ad57e235eeb", new DateTime(2024, 8, 15, 1, 13, 49, 161, DateTimeKind.Utc).AddTicks(6591), 0, new DateTime(2024, 8, 15, 1, 13, 49, 161, DateTimeKind.Utc).AddTicks(6592), 0, new DateTime(2024, 8, 15, 5, 13, 49, 161, DateTimeKind.Local).AddTicks(6572) });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: 2009,
                columns: new[] { "ConcurrencyStamp", "CreatedTime", "Dislikes", "LastUpdatedTime", "Likes", "RefreshTokenCreateTime" },
                values: new object[] { "c1dfb5d0-9afd-440d-a211-55cdbcbd6fa0", new DateTime(2024, 8, 15, 1, 13, 49, 161, DateTimeKind.Utc).AddTicks(6604), 0, new DateTime(2024, 8, 15, 1, 13, 49, 161, DateTimeKind.Utc).AddTicks(6605), 0, new DateTime(2024, 8, 15, 5, 13, 49, 161, DateTimeKind.Local).AddTicks(6599) });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: 2010,
                columns: new[] { "ConcurrencyStamp", "CreatedTime", "Dislikes", "LastUpdatedTime", "Likes", "RefreshTokenCreateTime" },
                values: new object[] { "1f9291e1-2531-4d2f-bdb2-895c189bd0e7", new DateTime(2024, 8, 15, 1, 13, 49, 161, DateTimeKind.Utc).AddTicks(6620), 0, new DateTime(2024, 8, 15, 1, 13, 49, 161, DateTimeKind.Utc).AddTicks(6620), 0, new DateTime(2024, 8, 15, 5, 13, 49, 161, DateTimeKind.Local).AddTicks(6613) });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: 2011,
                columns: new[] { "ConcurrencyStamp", "CreatedTime", "Dislikes", "LastUpdatedTime", "Likes", "RefreshTokenCreateTime" },
                values: new object[] { "0ce38957-e552-4255-85c7-17729bc9b7e6", new DateTime(2024, 8, 15, 1, 13, 49, 161, DateTimeKind.Utc).AddTicks(6634), 0, new DateTime(2024, 8, 15, 1, 13, 49, 161, DateTimeKind.Utc).AddTicks(6634), 0, new DateTime(2024, 8, 15, 5, 13, 49, 161, DateTimeKind.Local).AddTicks(6629) });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: 2012,
                columns: new[] { "ConcurrencyStamp", "CreatedTime", "Dislikes", "LastUpdatedTime", "Likes", "RefreshTokenCreateTime" },
                values: new object[] { "13bfbc57-a5eb-4f99-bbd0-fc4c9ca7643d", new DateTime(2024, 8, 15, 1, 13, 49, 161, DateTimeKind.Utc).AddTicks(6656), 0, new DateTime(2024, 8, 15, 1, 13, 49, 161, DateTimeKind.Utc).AddTicks(6657), 0, new DateTime(2024, 8, 15, 5, 13, 49, 161, DateTimeKind.Local).AddTicks(6651) });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: 2013,
                columns: new[] { "ConcurrencyStamp", "CreatedTime", "Dislikes", "LastUpdatedTime", "Likes", "RefreshTokenCreateTime" },
                values: new object[] { "76903605-4c7d-4271-b0bb-85ca3e6aae4f", new DateTime(2024, 8, 15, 1, 13, 49, 161, DateTimeKind.Utc).AddTicks(6669), 0, new DateTime(2024, 8, 15, 1, 13, 49, 161, DateTimeKind.Utc).AddTicks(6669), 0, new DateTime(2024, 8, 15, 5, 13, 49, 161, DateTimeKind.Local).AddTicks(6664) });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: 2014,
                columns: new[] { "ConcurrencyStamp", "CreatedTime", "Dislikes", "LastUpdatedTime", "Likes", "RefreshTokenCreateTime" },
                values: new object[] { "efa8a616-f7a5-4766-a687-080a3efb8e93", new DateTime(2024, 8, 15, 1, 13, 49, 161, DateTimeKind.Utc).AddTicks(6682), 0, new DateTime(2024, 8, 15, 1, 13, 49, 161, DateTimeKind.Utc).AddTicks(6682), 0, new DateTime(2024, 8, 15, 5, 13, 49, 161, DateTimeKind.Local).AddTicks(6677) });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: 2015,
                columns: new[] { "ConcurrencyStamp", "CreatedTime", "Dislikes", "LastUpdatedTime", "Likes", "RefreshTokenCreateTime" },
                values: new object[] { "c40690ae-f28e-4623-b3ab-c27d4cbe42e5", new DateTime(2024, 8, 15, 1, 13, 49, 161, DateTimeKind.Utc).AddTicks(6695), 0, new DateTime(2024, 8, 15, 1, 13, 49, 161, DateTimeKind.Utc).AddTicks(6695), 0, new DateTime(2024, 8, 15, 5, 13, 49, 161, DateTimeKind.Local).AddTicks(6690) });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: 2016,
                columns: new[] { "ConcurrencyStamp", "CreatedTime", "Dislikes", "LastUpdatedTime", "Likes", "RefreshTokenCreateTime" },
                values: new object[] { "a07a2abb-3ad9-4111-b40e-83b397795b86", new DateTime(2024, 8, 15, 1, 13, 49, 161, DateTimeKind.Utc).AddTicks(6711), 0, new DateTime(2024, 8, 15, 1, 13, 49, 161, DateTimeKind.Utc).AddTicks(6711), 0, new DateTime(2024, 8, 15, 5, 13, 49, 161, DateTimeKind.Local).AddTicks(6703) });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: 2017,
                columns: new[] { "ConcurrencyStamp", "CreatedTime", "Dislikes", "LastUpdatedTime", "Likes", "RefreshTokenCreateTime" },
                values: new object[] { "4f1d8679-b957-431c-a0ab-8cd4b9c91c8d", new DateTime(2024, 8, 15, 1, 13, 49, 161, DateTimeKind.Utc).AddTicks(6724), 0, new DateTime(2024, 8, 15, 1, 13, 49, 161, DateTimeKind.Utc).AddTicks(6725), 0, new DateTime(2024, 8, 15, 5, 13, 49, 161, DateTimeKind.Local).AddTicks(6719) });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: 2018,
                columns: new[] { "ConcurrencyStamp", "CreatedTime", "Dislikes", "LastUpdatedTime", "Likes", "RefreshTokenCreateTime" },
                values: new object[] { "b9472f80-24eb-495e-93ef-90a19fbb51be", new DateTime(2024, 8, 15, 1, 13, 49, 161, DateTimeKind.Utc).AddTicks(6738), 0, new DateTime(2024, 8, 15, 1, 13, 49, 161, DateTimeKind.Utc).AddTicks(6739), 0, new DateTime(2024, 8, 15, 5, 13, 49, 161, DateTimeKind.Local).AddTicks(6733) });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: 2019,
                columns: new[] { "ConcurrencyStamp", "CreatedTime", "Dislikes", "LastUpdatedTime", "Likes", "RefreshTokenCreateTime" },
                values: new object[] { "7857b964-3ff2-4043-96bf-17eeb2132002", new DateTime(2024, 8, 15, 1, 13, 49, 161, DateTimeKind.Utc).AddTicks(6752), 0, new DateTime(2024, 8, 15, 1, 13, 49, 161, DateTimeKind.Utc).AddTicks(6752), 0, new DateTime(2024, 8, 15, 5, 13, 49, 161, DateTimeKind.Local).AddTicks(6747) });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: 2020,
                columns: new[] { "ConcurrencyStamp", "CreatedTime", "Dislikes", "LastUpdatedTime", "Likes", "RefreshTokenCreateTime" },
                values: new object[] { "f55d8a7a-27be-4145-92de-8599aac8624a", new DateTime(2024, 8, 15, 1, 13, 49, 161, DateTimeKind.Utc).AddTicks(6766), 0, new DateTime(2024, 8, 15, 1, 13, 49, 161, DateTimeKind.Utc).AddTicks(6766), 0, new DateTime(2024, 8, 15, 5, 13, 49, 161, DateTimeKind.Local).AddTicks(6760) });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: 2021,
                columns: new[] { "ConcurrencyStamp", "CreatedTime", "Dislikes", "LastUpdatedTime", "Likes", "RefreshTokenCreateTime" },
                values: new object[] { "a04cc06f-8565-4927-bf83-b78bf9c16cf5", new DateTime(2024, 8, 15, 1, 13, 49, 161, DateTimeKind.Utc).AddTicks(6785), 0, new DateTime(2024, 8, 15, 1, 13, 49, 161, DateTimeKind.Utc).AddTicks(6786), 0, new DateTime(2024, 8, 15, 5, 13, 49, 161, DateTimeKind.Local).AddTicks(6781) });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: 2022,
                columns: new[] { "ConcurrencyStamp", "CreatedTime", "Dislikes", "LastUpdatedTime", "Likes", "RefreshTokenCreateTime" },
                values: new object[] { "2029f037-3b60-4ee1-9548-6b9c9baa0999", new DateTime(2024, 8, 15, 1, 13, 49, 161, DateTimeKind.Utc).AddTicks(6804), 0, new DateTime(2024, 8, 15, 1, 13, 49, 161, DateTimeKind.Utc).AddTicks(6805), 0, new DateTime(2024, 8, 15, 5, 13, 49, 161, DateTimeKind.Local).AddTicks(6799) });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: 2023,
                columns: new[] { "ConcurrencyStamp", "CreatedTime", "Dislikes", "LastUpdatedTime", "Likes", "RefreshTokenCreateTime" },
                values: new object[] { "99e5fbfe-05cf-484a-9b88-9b996c9ea1c8", new DateTime(2024, 8, 15, 1, 13, 49, 161, DateTimeKind.Utc).AddTicks(6818), 0, new DateTime(2024, 8, 15, 1, 13, 49, 161, DateTimeKind.Utc).AddTicks(6818), 0, new DateTime(2024, 8, 15, 5, 13, 49, 161, DateTimeKind.Local).AddTicks(6813) });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: 2024,
                columns: new[] { "ConcurrencyStamp", "CreatedTime", "Dislikes", "LastUpdatedTime", "Likes", "RefreshTokenCreateTime" },
                values: new object[] { "d9089a58-6294-413b-bd6e-24c3fe47ff2e", new DateTime(2024, 8, 15, 1, 13, 49, 161, DateTimeKind.Utc).AddTicks(6834), 0, new DateTime(2024, 8, 15, 1, 13, 49, 161, DateTimeKind.Utc).AddTicks(6834), 0, new DateTime(2024, 8, 15, 5, 13, 49, 161, DateTimeKind.Local).AddTicks(6826) });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: 2025,
                columns: new[] { "ConcurrencyStamp", "CreatedTime", "Dislikes", "LastUpdatedTime", "Likes", "RefreshTokenCreateTime" },
                values: new object[] { "8789290f-6b5a-4b9c-8869-62f117d9c4ae", new DateTime(2024, 8, 15, 1, 13, 49, 161, DateTimeKind.Utc).AddTicks(6847), 0, new DateTime(2024, 8, 15, 1, 13, 49, 161, DateTimeKind.Utc).AddTicks(6847), 0, new DateTime(2024, 8, 15, 5, 13, 49, 161, DateTimeKind.Local).AddTicks(6842) });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: 2026,
                columns: new[] { "ConcurrencyStamp", "CreatedTime", "Dislikes", "LastUpdatedTime", "Likes", "RefreshTokenCreateTime" },
                values: new object[] { "92ea9853-993c-4679-8e54-697640629f03", new DateTime(2024, 8, 15, 1, 13, 49, 161, DateTimeKind.Utc).AddTicks(6860), 0, new DateTime(2024, 8, 15, 1, 13, 49, 161, DateTimeKind.Utc).AddTicks(6861), 0, new DateTime(2024, 8, 15, 5, 13, 49, 161, DateTimeKind.Local).AddTicks(6855) });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: 2027,
                columns: new[] { "ConcurrencyStamp", "CreatedTime", "Dislikes", "LastUpdatedTime", "Likes", "RefreshTokenCreateTime" },
                values: new object[] { "8e31054b-edd2-40bc-b8a0-022430242bed", new DateTime(2024, 8, 15, 1, 13, 49, 161, DateTimeKind.Utc).AddTicks(6873), 0, new DateTime(2024, 8, 15, 1, 13, 49, 161, DateTimeKind.Utc).AddTicks(6874), 0, new DateTime(2024, 8, 15, 5, 13, 49, 161, DateTimeKind.Local).AddTicks(6868) });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: 2028,
                columns: new[] { "ConcurrencyStamp", "CreatedTime", "Dislikes", "LastUpdatedTime", "Likes", "RefreshTokenCreateTime" },
                values: new object[] { "54ad50cb-63e3-40d9-a877-221ba6d9cfca", new DateTime(2024, 8, 15, 1, 13, 49, 161, DateTimeKind.Utc).AddTicks(6886), 0, new DateTime(2024, 8, 15, 1, 13, 49, 161, DateTimeKind.Utc).AddTicks(6887), 0, new DateTime(2024, 8, 15, 5, 13, 49, 161, DateTimeKind.Local).AddTicks(6881) });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: 2029,
                columns: new[] { "ConcurrencyStamp", "CreatedTime", "Dislikes", "LastUpdatedTime", "Likes", "RefreshTokenCreateTime" },
                values: new object[] { "f1acd1a4-9931-4c8d-88de-b0efe77c715e", new DateTime(2024, 8, 15, 1, 13, 49, 161, DateTimeKind.Utc).AddTicks(6900), 0, new DateTime(2024, 8, 15, 1, 13, 49, 161, DateTimeKind.Utc).AddTicks(6900), 0, new DateTime(2024, 8, 15, 5, 13, 49, 161, DateTimeKind.Local).AddTicks(6894) });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: 2030,
                columns: new[] { "ConcurrencyStamp", "CreatedTime", "Dislikes", "LastUpdatedTime", "Likes", "RefreshTokenCreateTime" },
                values: new object[] { "1d9d8381-939c-4c34-9045-1e5a21898a31", new DateTime(2024, 8, 15, 1, 13, 49, 161, DateTimeKind.Utc).AddTicks(6920), 0, new DateTime(2024, 8, 15, 1, 13, 49, 161, DateTimeKind.Utc).AddTicks(6920), 0, new DateTime(2024, 8, 15, 5, 13, 49, 161, DateTimeKind.Local).AddTicks(6915) });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: 2031,
                columns: new[] { "ConcurrencyStamp", "CreatedTime", "Dislikes", "LastUpdatedTime", "Likes", "RefreshTokenCreateTime" },
                values: new object[] { "c214f3da-90bd-4b8d-9fec-72b46714de8b", new DateTime(2024, 8, 15, 1, 13, 49, 161, DateTimeKind.Utc).AddTicks(6933), 0, new DateTime(2024, 8, 15, 1, 13, 49, 161, DateTimeKind.Utc).AddTicks(6933), 0, new DateTime(2024, 8, 15, 5, 13, 49, 161, DateTimeKind.Local).AddTicks(6928) });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: 2032,
                columns: new[] { "ConcurrencyStamp", "CreatedTime", "Dislikes", "LastUpdatedTime", "Likes", "RefreshTokenCreateTime" },
                values: new object[] { "eaeb9dda-72cd-46e6-b219-b3bf0ba37142", new DateTime(2024, 8, 15, 1, 13, 49, 161, DateTimeKind.Utc).AddTicks(6949), 0, new DateTime(2024, 8, 15, 1, 13, 49, 161, DateTimeKind.Utc).AddTicks(6949), 0, new DateTime(2024, 8, 15, 5, 13, 49, 161, DateTimeKind.Local).AddTicks(6941) });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: 2033,
                columns: new[] { "ConcurrencyStamp", "CreatedTime", "Dislikes", "LastUpdatedTime", "Likes", "RefreshTokenCreateTime" },
                values: new object[] { "4838552f-76d3-42bc-bc8c-1b5aa454e96a", new DateTime(2024, 8, 15, 1, 13, 49, 161, DateTimeKind.Utc).AddTicks(6962), 0, new DateTime(2024, 8, 15, 1, 13, 49, 161, DateTimeKind.Utc).AddTicks(6962), 0, new DateTime(2024, 8, 15, 5, 13, 49, 161, DateTimeKind.Local).AddTicks(6956) });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: 2034,
                columns: new[] { "ConcurrencyStamp", "CreatedTime", "Dislikes", "LastUpdatedTime", "Likes", "RefreshTokenCreateTime" },
                values: new object[] { "5c6c7d4c-c471-4095-9c5e-5cd6006e2997", new DateTime(2024, 8, 15, 1, 13, 49, 161, DateTimeKind.Utc).AddTicks(6976), 0, new DateTime(2024, 8, 15, 1, 13, 49, 161, DateTimeKind.Utc).AddTicks(6976), 0, new DateTime(2024, 8, 15, 5, 13, 49, 161, DateTimeKind.Local).AddTicks(6971) });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: 2035,
                columns: new[] { "ConcurrencyStamp", "CreatedTime", "Dislikes", "LastUpdatedTime", "Likes", "RefreshTokenCreateTime" },
                values: new object[] { "f7a882ca-12f8-4355-b570-5e0dd8603f60", new DateTime(2024, 8, 15, 1, 13, 49, 161, DateTimeKind.Utc).AddTicks(6989), 0, new DateTime(2024, 8, 15, 1, 13, 49, 161, DateTimeKind.Utc).AddTicks(6990), 0, new DateTime(2024, 8, 15, 5, 13, 49, 161, DateTimeKind.Local).AddTicks(6985) });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: 2036,
                columns: new[] { "ConcurrencyStamp", "CreatedTime", "Dislikes", "LastUpdatedTime", "Likes", "RefreshTokenCreateTime" },
                values: new object[] { "0d32cfdf-528a-46a0-8cb1-33ab0f16301b", new DateTime(2024, 8, 15, 1, 13, 49, 161, DateTimeKind.Utc).AddTicks(7002), 0, new DateTime(2024, 8, 15, 1, 13, 49, 161, DateTimeKind.Utc).AddTicks(7003), 0, new DateTime(2024, 8, 15, 5, 13, 49, 161, DateTimeKind.Local).AddTicks(6997) });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: 2037,
                columns: new[] { "ConcurrencyStamp", "CreatedTime", "Dislikes", "LastUpdatedTime", "Likes", "RefreshTokenCreateTime" },
                values: new object[] { "da155a13-0b6e-412e-9937-7e6fc9e1b1e8", new DateTime(2024, 8, 15, 1, 13, 49, 161, DateTimeKind.Utc).AddTicks(7015), 0, new DateTime(2024, 8, 15, 1, 13, 49, 161, DateTimeKind.Utc).AddTicks(7016), 0, new DateTime(2024, 8, 15, 5, 13, 49, 161, DateTimeKind.Local).AddTicks(7010) });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: 2038,
                columns: new[] { "ConcurrencyStamp", "CreatedTime", "Dislikes", "LastUpdatedTime", "Likes", "RefreshTokenCreateTime" },
                values: new object[] { "05f401a1-a5b9-4ec4-83c0-ff7fb211e04a", new DateTime(2024, 8, 15, 1, 13, 49, 161, DateTimeKind.Utc).AddTicks(7036), 0, new DateTime(2024, 8, 15, 1, 13, 49, 161, DateTimeKind.Utc).AddTicks(7036), 0, new DateTime(2024, 8, 15, 5, 13, 49, 161, DateTimeKind.Local).AddTicks(7031) });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: 2039,
                columns: new[] { "ConcurrencyStamp", "CreatedTime", "Dislikes", "LastUpdatedTime", "Likes", "RefreshTokenCreateTime" },
                values: new object[] { "6ea6ad8a-bf6a-433f-a462-9100c52fd725", new DateTime(2024, 8, 15, 1, 13, 49, 161, DateTimeKind.Utc).AddTicks(7049), 0, new DateTime(2024, 8, 15, 1, 13, 49, 161, DateTimeKind.Utc).AddTicks(7049), 0, new DateTime(2024, 8, 15, 5, 13, 49, 161, DateTimeKind.Local).AddTicks(7044) });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: 2040,
                columns: new[] { "ConcurrencyStamp", "CreatedTime", "Dislikes", "LastUpdatedTime", "Likes", "RefreshTokenCreateTime" },
                values: new object[] { "242e51c2-76d7-490e-b878-3246d3af073c", new DateTime(2024, 8, 15, 1, 13, 49, 161, DateTimeKind.Utc).AddTicks(7065), 0, new DateTime(2024, 8, 15, 1, 13, 49, 161, DateTimeKind.Utc).AddTicks(7065), 0, new DateTime(2024, 8, 15, 5, 13, 49, 161, DateTimeKind.Local).AddTicks(7057) });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: 2041,
                columns: new[] { "ConcurrencyStamp", "CreatedTime", "Dislikes", "LastUpdatedTime", "Likes", "RefreshTokenCreateTime" },
                values: new object[] { "55ec3270-b436-482b-86c7-ec352384f044", new DateTime(2024, 8, 15, 1, 13, 49, 161, DateTimeKind.Utc).AddTicks(7078), 0, new DateTime(2024, 8, 15, 1, 13, 49, 161, DateTimeKind.Utc).AddTicks(7079), 0, new DateTime(2024, 8, 15, 5, 13, 49, 161, DateTimeKind.Local).AddTicks(7073) });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: 2042,
                columns: new[] { "ConcurrencyStamp", "CreatedTime", "Dislikes", "LastUpdatedTime", "Likes", "RefreshTokenCreateTime" },
                values: new object[] { "4a245672-3bbc-4924-b21d-f08adc16eff9", new DateTime(2024, 8, 15, 1, 13, 49, 161, DateTimeKind.Utc).AddTicks(7096), 0, new DateTime(2024, 8, 15, 1, 13, 49, 161, DateTimeKind.Utc).AddTicks(7097), 0, new DateTime(2024, 8, 15, 5, 13, 49, 161, DateTimeKind.Local).AddTicks(7092) });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: 2043,
                columns: new[] { "ConcurrencyStamp", "CreatedTime", "Dislikes", "LastUpdatedTime", "Likes", "RefreshTokenCreateTime" },
                values: new object[] { "1d0bcb8f-7a14-473e-9f1f-b81b5c6ed64a", new DateTime(2024, 8, 15, 1, 13, 49, 161, DateTimeKind.Utc).AddTicks(7109), 0, new DateTime(2024, 8, 15, 1, 13, 49, 161, DateTimeKind.Utc).AddTicks(7110), 0, new DateTime(2024, 8, 15, 5, 13, 49, 161, DateTimeKind.Local).AddTicks(7105) });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: 2044,
                columns: new[] { "ConcurrencyStamp", "CreatedTime", "Dislikes", "LastUpdatedTime", "Likes", "RefreshTokenCreateTime" },
                values: new object[] { "3681c405-9213-4be4-a93c-f95bb4d0a018", new DateTime(2024, 8, 15, 1, 13, 49, 161, DateTimeKind.Utc).AddTicks(7122), 0, new DateTime(2024, 8, 15, 1, 13, 49, 161, DateTimeKind.Utc).AddTicks(7123), 0, new DateTime(2024, 8, 15, 5, 13, 49, 161, DateTimeKind.Local).AddTicks(7117) });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: 2045,
                columns: new[] { "ConcurrencyStamp", "CreatedTime", "Dislikes", "LastUpdatedTime", "Likes", "RefreshTokenCreateTime" },
                values: new object[] { "e2abd875-2885-40e8-8559-2de5f6913ff9", new DateTime(2024, 8, 15, 1, 13, 49, 161, DateTimeKind.Utc).AddTicks(7135), 0, new DateTime(2024, 8, 15, 1, 13, 49, 161, DateTimeKind.Utc).AddTicks(7136), 0, new DateTime(2024, 8, 15, 5, 13, 49, 161, DateTimeKind.Local).AddTicks(7130) });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: 2046,
                columns: new[] { "ConcurrencyStamp", "CreatedTime", "Dislikes", "LastUpdatedTime", "Likes", "RefreshTokenCreateTime" },
                values: new object[] { "b60c84eb-a122-4837-8ed5-043934545052", new DateTime(2024, 8, 15, 1, 13, 49, 161, DateTimeKind.Utc).AddTicks(7148), 0, new DateTime(2024, 8, 15, 1, 13, 49, 161, DateTimeKind.Utc).AddTicks(7149), 0, new DateTime(2024, 8, 15, 5, 13, 49, 161, DateTimeKind.Local).AddTicks(7143) });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: 2047,
                columns: new[] { "ConcurrencyStamp", "CreatedTime", "Dislikes", "LastUpdatedTime", "Likes", "RefreshTokenCreateTime" },
                values: new object[] { "db5d53d6-4841-47a6-82ee-e323eef10374", new DateTime(2024, 8, 15, 1, 13, 49, 161, DateTimeKind.Utc).AddTicks(7168), 0, new DateTime(2024, 8, 15, 1, 13, 49, 161, DateTimeKind.Utc).AddTicks(7169), 0, new DateTime(2024, 8, 15, 5, 13, 49, 161, DateTimeKind.Local).AddTicks(7163) });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: 2048,
                columns: new[] { "ConcurrencyStamp", "CreatedTime", "Dislikes", "LastUpdatedTime", "Likes", "RefreshTokenCreateTime" },
                values: new object[] { "b82fe1ba-4a41-4098-bb85-3e9c56449a1c", new DateTime(2024, 8, 15, 1, 13, 49, 161, DateTimeKind.Utc).AddTicks(7184), 0, new DateTime(2024, 8, 15, 1, 13, 49, 161, DateTimeKind.Utc).AddTicks(7184), 0, new DateTime(2024, 8, 15, 5, 13, 49, 161, DateTimeKind.Local).AddTicks(7176) });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: 2049,
                columns: new[] { "ConcurrencyStamp", "CreatedTime", "Dislikes", "LastUpdatedTime", "Likes", "RefreshTokenCreateTime" },
                values: new object[] { "ae69d81d-3503-437e-ac67-7ea119c7b635", new DateTime(2024, 8, 15, 1, 13, 49, 161, DateTimeKind.Utc).AddTicks(7197), 0, new DateTime(2024, 8, 15, 1, 13, 49, 161, DateTimeKind.Utc).AddTicks(7197), 0, new DateTime(2024, 8, 15, 5, 13, 49, 161, DateTimeKind.Local).AddTicks(7192) });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: 2050,
                columns: new[] { "ConcurrencyStamp", "CreatedTime", "Dislikes", "LastUpdatedTime", "Likes", "RefreshTokenCreateTime" },
                values: new object[] { "021082fc-de22-4219-981b-20d65bdaabfa", new DateTime(2024, 8, 15, 1, 13, 49, 161, DateTimeKind.Utc).AddTicks(7209), 0, new DateTime(2024, 8, 15, 1, 13, 49, 161, DateTimeKind.Utc).AddTicks(7210), 0, new DateTime(2024, 8, 15, 5, 13, 49, 161, DateTimeKind.Local).AddTicks(7205) });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: 2051,
                columns: new[] { "ConcurrencyStamp", "CreatedTime", "Dislikes", "LastUpdatedTime", "Likes", "RefreshTokenCreateTime" },
                values: new object[] { "e1418f2b-40da-4e78-92fd-865402f34631", new DateTime(2024, 8, 15, 1, 13, 49, 161, DateTimeKind.Utc).AddTicks(7223), 0, new DateTime(2024, 8, 15, 1, 13, 49, 161, DateTimeKind.Utc).AddTicks(7223), 0, new DateTime(2024, 8, 15, 5, 13, 49, 161, DateTimeKind.Local).AddTicks(7218) });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: 2052,
                columns: new[] { "ConcurrencyStamp", "CreatedTime", "Dislikes", "LastUpdatedTime", "Likes", "RefreshTokenCreateTime" },
                values: new object[] { "dc26b1e1-4f62-4786-87dd-d6e0ef4be651", new DateTime(2024, 8, 15, 1, 13, 49, 161, DateTimeKind.Utc).AddTicks(7235), 0, new DateTime(2024, 8, 15, 1, 13, 49, 161, DateTimeKind.Utc).AddTicks(7236), 0, new DateTime(2024, 8, 15, 5, 13, 49, 161, DateTimeKind.Local).AddTicks(7230) });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: 2053,
                columns: new[] { "ConcurrencyStamp", "CreatedTime", "Dislikes", "LastUpdatedTime", "Likes", "RefreshTokenCreateTime" },
                values: new object[] { "4a451653-f37b-4381-a19e-5b620ca5bc79", new DateTime(2024, 8, 15, 1, 13, 49, 161, DateTimeKind.Utc).AddTicks(7248), 0, new DateTime(2024, 8, 15, 1, 13, 49, 161, DateTimeKind.Utc).AddTicks(7249), 0, new DateTime(2024, 8, 15, 5, 13, 49, 161, DateTimeKind.Local).AddTicks(7243) });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: 2054,
                columns: new[] { "ConcurrencyStamp", "CreatedTime", "Dislikes", "LastUpdatedTime", "Likes", "RefreshTokenCreateTime" },
                values: new object[] { "184dc55d-0b5b-43c3-8d18-6b78769d8190", new DateTime(2024, 8, 15, 1, 13, 49, 161, DateTimeKind.Utc).AddTicks(7261), 0, new DateTime(2024, 8, 15, 1, 13, 49, 161, DateTimeKind.Utc).AddTicks(7261), 0, new DateTime(2024, 8, 15, 5, 13, 49, 161, DateTimeKind.Local).AddTicks(7256) });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: 2055,
                columns: new[] { "ConcurrencyStamp", "CreatedTime", "Dislikes", "LastUpdatedTime", "Likes", "RefreshTokenCreateTime" },
                values: new object[] { "7d3a7c49-b103-4bf9-a0dd-bae65bf3f39a", new DateTime(2024, 8, 15, 1, 13, 49, 161, DateTimeKind.Utc).AddTicks(7273), 0, new DateTime(2024, 8, 15, 1, 13, 49, 161, DateTimeKind.Utc).AddTicks(7274), 0, new DateTime(2024, 8, 15, 5, 13, 49, 161, DateTimeKind.Local).AddTicks(7269) });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: 2056,
                columns: new[] { "ConcurrencyStamp", "CreatedTime", "Dislikes", "LastUpdatedTime", "Likes", "RefreshTokenCreateTime" },
                values: new object[] { "ca9aae54-f8fe-4043-a150-027c5ca8fb3a", new DateTime(2024, 8, 15, 1, 13, 49, 161, DateTimeKind.Utc).AddTicks(7289), 0, new DateTime(2024, 8, 15, 1, 13, 49, 161, DateTimeKind.Utc).AddTicks(7290), 0, new DateTime(2024, 8, 15, 5, 13, 49, 161, DateTimeKind.Local).AddTicks(7281) });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: 2057,
                columns: new[] { "ConcurrencyStamp", "CreatedTime", "Dislikes", "LastUpdatedTime", "Likes", "RefreshTokenCreateTime" },
                values: new object[] { "cedacc49-3a41-469c-bc17-d6b8a9f5122d", new DateTime(2024, 8, 15, 1, 13, 49, 161, DateTimeKind.Utc).AddTicks(7310), 0, new DateTime(2024, 8, 15, 1, 13, 49, 161, DateTimeKind.Utc).AddTicks(7311), 0, new DateTime(2024, 8, 15, 5, 13, 49, 161, DateTimeKind.Local).AddTicks(7305) });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: 2058,
                columns: new[] { "ConcurrencyStamp", "CreatedTime", "Dislikes", "LastUpdatedTime", "Likes", "RefreshTokenCreateTime" },
                values: new object[] { "d56008f3-05dc-4995-abb2-1ea2e8e2d0a5", new DateTime(2024, 8, 15, 1, 13, 49, 161, DateTimeKind.Utc).AddTicks(7324), 0, new DateTime(2024, 8, 15, 1, 13, 49, 161, DateTimeKind.Utc).AddTicks(7324), 0, new DateTime(2024, 8, 15, 5, 13, 49, 161, DateTimeKind.Local).AddTicks(7318) });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: 2059,
                columns: new[] { "ConcurrencyStamp", "CreatedTime", "Dislikes", "LastUpdatedTime", "Likes", "RefreshTokenCreateTime" },
                values: new object[] { "ea5c4d22-d962-4b7a-a879-14958d4516e6", new DateTime(2024, 8, 15, 1, 13, 49, 161, DateTimeKind.Utc).AddTicks(7336), 0, new DateTime(2024, 8, 15, 1, 13, 49, 161, DateTimeKind.Utc).AddTicks(7337), 0, new DateTime(2024, 8, 15, 5, 13, 49, 161, DateTimeKind.Local).AddTicks(7332) });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: 2060,
                columns: new[] { "ConcurrencyStamp", "CreatedTime", "Dislikes", "LastUpdatedTime", "Likes", "RefreshTokenCreateTime" },
                values: new object[] { "5a839e7f-cabf-4f0e-942a-617f140fc6c8", new DateTime(2024, 8, 15, 1, 13, 49, 161, DateTimeKind.Utc).AddTicks(7349), 0, new DateTime(2024, 8, 15, 1, 13, 49, 161, DateTimeKind.Utc).AddTicks(7350), 0, new DateTime(2024, 8, 15, 5, 13, 49, 161, DateTimeKind.Local).AddTicks(7344) });
        }
    }
}
