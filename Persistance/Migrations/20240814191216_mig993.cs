using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace Persistance.Migrations
{
    /// <inheritdoc />
    public partial class mig993 : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.InsertData(
                table: "AspNetRoles",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[,]
                {
                    { 1, null, "User", "USER" },
                    { 2, null, "Vet", "VET" },
                    { 3, null, "Company", "COMPANY" },
                    { 4, null, "Admin", "Admin" }
                });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: 2001,
                columns: new[] { "ConcurrencyStamp", "CreatedTime", "LastUpdatedTime", "RefreshTokenCreateTime" },
                values: new object[] { "4ed58e67-79bb-4ec2-ac5a-5b2622b3599c", new DateTime(2024, 8, 14, 19, 12, 15, 248, DateTimeKind.Utc).AddTicks(5795), new DateTime(2024, 8, 14, 19, 12, 15, 248, DateTimeKind.Utc).AddTicks(5796), new DateTime(2024, 8, 14, 23, 12, 15, 248, DateTimeKind.Local).AddTicks(5688) });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: 2002,
                columns: new[] { "ConcurrencyStamp", "CreatedTime", "LastUpdatedTime", "RefreshTokenCreateTime" },
                values: new object[] { "a01166f7-6097-44fc-9b25-15a903748f8a", new DateTime(2024, 8, 14, 19, 12, 15, 248, DateTimeKind.Utc).AddTicks(5826), new DateTime(2024, 8, 14, 19, 12, 15, 248, DateTimeKind.Utc).AddTicks(5827), new DateTime(2024, 8, 14, 23, 12, 15, 248, DateTimeKind.Local).AddTicks(5819) });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: 2003,
                columns: new[] { "ConcurrencyStamp", "CreatedTime", "LastUpdatedTime", "RefreshTokenCreateTime" },
                values: new object[] { "fb2a4393-2ee1-4eb1-9f77-00c7a6cad22e", new DateTime(2024, 8, 14, 19, 12, 15, 248, DateTimeKind.Utc).AddTicks(5842), new DateTime(2024, 8, 14, 19, 12, 15, 248, DateTimeKind.Utc).AddTicks(5843), new DateTime(2024, 8, 14, 23, 12, 15, 248, DateTimeKind.Local).AddTicks(5837) });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: 2004,
                columns: new[] { "ConcurrencyStamp", "CreatedTime", "LastUpdatedTime", "RefreshTokenCreateTime" },
                values: new object[] { "1887dc7d-79f5-4af8-aab9-66418cc74963", new DateTime(2024, 8, 14, 19, 12, 15, 248, DateTimeKind.Utc).AddTicks(5856), new DateTime(2024, 8, 14, 19, 12, 15, 248, DateTimeKind.Utc).AddTicks(5856), new DateTime(2024, 8, 14, 23, 12, 15, 248, DateTimeKind.Local).AddTicks(5851) });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: 2005,
                columns: new[] { "ConcurrencyStamp", "CreatedTime", "LastUpdatedTime", "RefreshTokenCreateTime" },
                values: new object[] { "ee0a381f-8528-475d-9bac-c9df1a155913", new DateTime(2024, 8, 14, 19, 12, 15, 248, DateTimeKind.Utc).AddTicks(5869), new DateTime(2024, 8, 14, 19, 12, 15, 248, DateTimeKind.Utc).AddTicks(5869), new DateTime(2024, 8, 14, 23, 12, 15, 248, DateTimeKind.Local).AddTicks(5864) });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: 2006,
                columns: new[] { "ConcurrencyStamp", "CreatedTime", "LastUpdatedTime", "RefreshTokenCreateTime" },
                values: new object[] { "174dd210-1424-4061-923e-e2b71ed63f25", new DateTime(2024, 8, 14, 19, 12, 15, 248, DateTimeKind.Utc).AddTicks(5899), new DateTime(2024, 8, 14, 19, 12, 15, 248, DateTimeKind.Utc).AddTicks(5900), new DateTime(2024, 8, 14, 23, 12, 15, 248, DateTimeKind.Local).AddTicks(5881) });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: 2007,
                columns: new[] { "ConcurrencyStamp", "CreatedTime", "LastUpdatedTime", "RefreshTokenCreateTime" },
                values: new object[] { "54e62bb6-de41-40ee-ad7f-1191bd29cd33", new DateTime(2024, 8, 14, 19, 12, 15, 248, DateTimeKind.Utc).AddTicks(5957), new DateTime(2024, 8, 14, 19, 12, 15, 248, DateTimeKind.Utc).AddTicks(5958), new DateTime(2024, 8, 14, 23, 12, 15, 248, DateTimeKind.Local).AddTicks(5951) });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: 2008,
                columns: new[] { "ConcurrencyStamp", "CreatedTime", "LastUpdatedTime", "RefreshTokenCreateTime" },
                values: new object[] { "ebb8f392-f40b-4ccb-b1f8-50c926a18516", new DateTime(2024, 8, 14, 19, 12, 15, 248, DateTimeKind.Utc).AddTicks(5972), new DateTime(2024, 8, 14, 19, 12, 15, 248, DateTimeKind.Utc).AddTicks(5972), new DateTime(2024, 8, 14, 23, 12, 15, 248, DateTimeKind.Local).AddTicks(5966) });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: 2009,
                columns: new[] { "ConcurrencyStamp", "CreatedTime", "LastUpdatedTime", "RefreshTokenCreateTime" },
                values: new object[] { "25fe80df-d4e2-4190-b613-352d52a5496f", new DateTime(2024, 8, 14, 19, 12, 15, 248, DateTimeKind.Utc).AddTicks(5985), new DateTime(2024, 8, 14, 19, 12, 15, 248, DateTimeKind.Utc).AddTicks(5986), new DateTime(2024, 8, 14, 23, 12, 15, 248, DateTimeKind.Local).AddTicks(5980) });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: 2010,
                columns: new[] { "ConcurrencyStamp", "CreatedTime", "LastUpdatedTime", "RefreshTokenCreateTime" },
                values: new object[] { "bb0cba98-c4bd-4ff4-867e-7aa3ba32181d", new DateTime(2024, 8, 14, 19, 12, 15, 248, DateTimeKind.Utc).AddTicks(6002), new DateTime(2024, 8, 14, 19, 12, 15, 248, DateTimeKind.Utc).AddTicks(6002), new DateTime(2024, 8, 14, 23, 12, 15, 248, DateTimeKind.Local).AddTicks(5995) });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: 2011,
                columns: new[] { "ConcurrencyStamp", "CreatedTime", "LastUpdatedTime", "RefreshTokenCreateTime" },
                values: new object[] { "4f87a5a2-4408-4aeb-9c42-7d0c8001c0e4", new DateTime(2024, 8, 14, 19, 12, 15, 248, DateTimeKind.Utc).AddTicks(6016), new DateTime(2024, 8, 14, 19, 12, 15, 248, DateTimeKind.Utc).AddTicks(6016), new DateTime(2024, 8, 14, 23, 12, 15, 248, DateTimeKind.Local).AddTicks(6011) });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: 2012,
                columns: new[] { "ConcurrencyStamp", "CreatedTime", "LastUpdatedTime", "RefreshTokenCreateTime" },
                values: new object[] { "af43e2fd-bfdf-4640-b82d-9268333fea68", new DateTime(2024, 8, 14, 19, 12, 15, 248, DateTimeKind.Utc).AddTicks(6031), new DateTime(2024, 8, 14, 19, 12, 15, 248, DateTimeKind.Utc).AddTicks(6031), new DateTime(2024, 8, 14, 23, 12, 15, 248, DateTimeKind.Local).AddTicks(6025) });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: 2013,
                columns: new[] { "ConcurrencyStamp", "CreatedTime", "LastUpdatedTime", "RefreshTokenCreateTime" },
                values: new object[] { "17fd4ca9-58ec-49f8-b5f6-ef566592eaf3", new DateTime(2024, 8, 14, 19, 12, 15, 248, DateTimeKind.Utc).AddTicks(6044), new DateTime(2024, 8, 14, 19, 12, 15, 248, DateTimeKind.Utc).AddTicks(6044), new DateTime(2024, 8, 14, 23, 12, 15, 248, DateTimeKind.Local).AddTicks(6039) });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: 2014,
                columns: new[] { "ConcurrencyStamp", "CreatedTime", "LastUpdatedTime", "RefreshTokenCreateTime" },
                values: new object[] { "5e271ee5-06cd-4357-9c3f-35fe22dd4e10", new DateTime(2024, 8, 14, 19, 12, 15, 248, DateTimeKind.Utc).AddTicks(6062), new DateTime(2024, 8, 14, 19, 12, 15, 248, DateTimeKind.Utc).AddTicks(6062), new DateTime(2024, 8, 14, 23, 12, 15, 248, DateTimeKind.Local).AddTicks(6053) });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: 2015,
                columns: new[] { "ConcurrencyStamp", "CreatedTime", "LastUpdatedTime", "RefreshTokenCreateTime" },
                values: new object[] { "1087dfc5-22cc-4df7-8193-7617ce8a01ea", new DateTime(2024, 8, 14, 19, 12, 15, 248, DateTimeKind.Utc).AddTicks(6076), new DateTime(2024, 8, 14, 19, 12, 15, 248, DateTimeKind.Utc).AddTicks(6076), new DateTime(2024, 8, 14, 23, 12, 15, 248, DateTimeKind.Local).AddTicks(6070) });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: 2016,
                columns: new[] { "ConcurrencyStamp", "CreatedTime", "LastUpdatedTime", "RefreshTokenCreateTime" },
                values: new object[] { "0f098403-9b95-470a-8e62-c5c13c0ad6c5", new DateTime(2024, 8, 14, 19, 12, 15, 248, DateTimeKind.Utc).AddTicks(6120), new DateTime(2024, 8, 14, 19, 12, 15, 248, DateTimeKind.Utc).AddTicks(6121), new DateTime(2024, 8, 14, 23, 12, 15, 248, DateTimeKind.Local).AddTicks(6114) });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: 2017,
                columns: new[] { "ConcurrencyStamp", "CreatedTime", "LastUpdatedTime", "RefreshTokenCreateTime" },
                values: new object[] { "9add8fb8-1444-4e5e-a549-7022fcecc380", new DateTime(2024, 8, 14, 19, 12, 15, 248, DateTimeKind.Utc).AddTicks(6134), new DateTime(2024, 8, 14, 19, 12, 15, 248, DateTimeKind.Utc).AddTicks(6135), new DateTime(2024, 8, 14, 23, 12, 15, 248, DateTimeKind.Local).AddTicks(6129) });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: 2018,
                columns: new[] { "ConcurrencyStamp", "CreatedTime", "LastUpdatedTime", "RefreshTokenCreateTime" },
                values: new object[] { "8a851a38-3ce1-4838-8d56-15ea672c323a", new DateTime(2024, 8, 14, 19, 12, 15, 248, DateTimeKind.Utc).AddTicks(6151), new DateTime(2024, 8, 14, 19, 12, 15, 248, DateTimeKind.Utc).AddTicks(6151), new DateTime(2024, 8, 14, 23, 12, 15, 248, DateTimeKind.Local).AddTicks(6145) });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: 2019,
                columns: new[] { "ConcurrencyStamp", "CreatedTime", "LastUpdatedTime", "RefreshTokenCreateTime" },
                values: new object[] { "4cd5773f-1afa-4d3c-a03e-325963f8e8fd", new DateTime(2024, 8, 14, 19, 12, 15, 248, DateTimeKind.Utc).AddTicks(6164), new DateTime(2024, 8, 14, 19, 12, 15, 248, DateTimeKind.Utc).AddTicks(6165), new DateTime(2024, 8, 14, 23, 12, 15, 248, DateTimeKind.Local).AddTicks(6159) });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: 2020,
                columns: new[] { "ConcurrencyStamp", "CreatedTime", "LastUpdatedTime", "RefreshTokenCreateTime" },
                values: new object[] { "1555965d-f3fb-4ab3-8a73-f4d770c47df1", new DateTime(2024, 8, 14, 19, 12, 15, 248, DateTimeKind.Utc).AddTicks(6178), new DateTime(2024, 8, 14, 19, 12, 15, 248, DateTimeKind.Utc).AddTicks(6178), new DateTime(2024, 8, 14, 23, 12, 15, 248, DateTimeKind.Local).AddTicks(6173) });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: 2021,
                columns: new[] { "ConcurrencyStamp", "CreatedTime", "LastUpdatedTime", "RefreshTokenCreateTime" },
                values: new object[] { "d17ccdb4-c0d0-4f05-a66e-5bee13dac838", new DateTime(2024, 8, 14, 19, 12, 15, 248, DateTimeKind.Utc).AddTicks(6192), new DateTime(2024, 8, 14, 19, 12, 15, 248, DateTimeKind.Utc).AddTicks(6193), new DateTime(2024, 8, 14, 23, 12, 15, 248, DateTimeKind.Local).AddTicks(6187) });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: 2022,
                columns: new[] { "ConcurrencyStamp", "CreatedTime", "LastUpdatedTime", "RefreshTokenCreateTime" },
                values: new object[] { "8ac846bc-76a8-4897-8edd-6f70c7924766", new DateTime(2024, 8, 14, 19, 12, 15, 248, DateTimeKind.Utc).AddTicks(6215), new DateTime(2024, 8, 14, 19, 12, 15, 248, DateTimeKind.Utc).AddTicks(6216), new DateTime(2024, 8, 14, 23, 12, 15, 248, DateTimeKind.Local).AddTicks(6206) });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: 2023,
                columns: new[] { "ConcurrencyStamp", "CreatedTime", "LastUpdatedTime", "RefreshTokenCreateTime" },
                values: new object[] { "aa3ef3ab-b596-4604-a56a-e5e9ed353a3c", new DateTime(2024, 8, 14, 19, 12, 15, 248, DateTimeKind.Utc).AddTicks(6230), new DateTime(2024, 8, 14, 19, 12, 15, 248, DateTimeKind.Utc).AddTicks(6230), new DateTime(2024, 8, 14, 23, 12, 15, 248, DateTimeKind.Local).AddTicks(6224) });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: 2024,
                columns: new[] { "ConcurrencyStamp", "CreatedTime", "LastUpdatedTime", "RefreshTokenCreateTime" },
                values: new object[] { "ca5d8326-c2ea-4a71-a16b-5d9c69fc1d54", new DateTime(2024, 8, 14, 19, 12, 15, 248, DateTimeKind.Utc).AddTicks(6244), new DateTime(2024, 8, 14, 19, 12, 15, 248, DateTimeKind.Utc).AddTicks(6245), new DateTime(2024, 8, 14, 23, 12, 15, 248, DateTimeKind.Local).AddTicks(6239) });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: 2025,
                columns: new[] { "ConcurrencyStamp", "CreatedTime", "LastUpdatedTime", "RefreshTokenCreateTime" },
                values: new object[] { "f2e2e53d-8ea0-4fb3-b708-6e8b3fb6f46e", new DateTime(2024, 8, 14, 19, 12, 15, 248, DateTimeKind.Utc).AddTicks(6289), new DateTime(2024, 8, 14, 19, 12, 15, 248, DateTimeKind.Utc).AddTicks(6289), new DateTime(2024, 8, 14, 23, 12, 15, 248, DateTimeKind.Local).AddTicks(6284) });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: 2026,
                columns: new[] { "ConcurrencyStamp", "CreatedTime", "LastUpdatedTime", "RefreshTokenCreateTime" },
                values: new object[] { "0a7ff4ce-2321-4924-88bc-16a928402004", new DateTime(2024, 8, 14, 19, 12, 15, 248, DateTimeKind.Utc).AddTicks(6303), new DateTime(2024, 8, 14, 19, 12, 15, 248, DateTimeKind.Utc).AddTicks(6303), new DateTime(2024, 8, 14, 23, 12, 15, 248, DateTimeKind.Local).AddTicks(6297) });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: 2027,
                columns: new[] { "ConcurrencyStamp", "CreatedTime", "LastUpdatedTime", "RefreshTokenCreateTime" },
                values: new object[] { "2ba55749-0c27-4093-b083-0c17a38bf099", new DateTime(2024, 8, 14, 19, 12, 15, 248, DateTimeKind.Utc).AddTicks(6316), new DateTime(2024, 8, 14, 19, 12, 15, 248, DateTimeKind.Utc).AddTicks(6316), new DateTime(2024, 8, 14, 23, 12, 15, 248, DateTimeKind.Local).AddTicks(6311) });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: 2028,
                columns: new[] { "ConcurrencyStamp", "CreatedTime", "LastUpdatedTime", "RefreshTokenCreateTime" },
                values: new object[] { "711d059e-7fc1-4871-91e1-890be01db0f4", new DateTime(2024, 8, 14, 19, 12, 15, 248, DateTimeKind.Utc).AddTicks(6329), new DateTime(2024, 8, 14, 19, 12, 15, 248, DateTimeKind.Utc).AddTicks(6330), new DateTime(2024, 8, 14, 23, 12, 15, 248, DateTimeKind.Local).AddTicks(6324) });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: 2029,
                columns: new[] { "ConcurrencyStamp", "CreatedTime", "LastUpdatedTime", "RefreshTokenCreateTime" },
                values: new object[] { "01720fd0-6ab8-4b3d-9c4c-73eaa4051fd9", new DateTime(2024, 8, 14, 19, 12, 15, 248, DateTimeKind.Utc).AddTicks(6343), new DateTime(2024, 8, 14, 19, 12, 15, 248, DateTimeKind.Utc).AddTicks(6344), new DateTime(2024, 8, 14, 23, 12, 15, 248, DateTimeKind.Local).AddTicks(6338) });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: 2030,
                columns: new[] { "ConcurrencyStamp", "CreatedTime", "LastUpdatedTime", "RefreshTokenCreateTime" },
                values: new object[] { "199fbb05-4635-4948-b8ce-7b4491e4566f", new DateTime(2024, 8, 14, 19, 12, 15, 248, DateTimeKind.Utc).AddTicks(6360), new DateTime(2024, 8, 14, 19, 12, 15, 248, DateTimeKind.Utc).AddTicks(6360), new DateTime(2024, 8, 14, 23, 12, 15, 248, DateTimeKind.Local).AddTicks(6352) });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: 2031,
                columns: new[] { "ConcurrencyStamp", "CreatedTime", "LastUpdatedTime", "RefreshTokenCreateTime" },
                values: new object[] { "e5c2001f-f754-41cb-a7ae-debeb782b420", new DateTime(2024, 8, 14, 19, 12, 15, 248, DateTimeKind.Utc).AddTicks(6373), new DateTime(2024, 8, 14, 19, 12, 15, 248, DateTimeKind.Utc).AddTicks(6374), new DateTime(2024, 8, 14, 23, 12, 15, 248, DateTimeKind.Local).AddTicks(6368) });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: 2032,
                columns: new[] { "ConcurrencyStamp", "CreatedTime", "LastUpdatedTime", "RefreshTokenCreateTime" },
                values: new object[] { "dfc7c529-fba5-4fe5-9088-f8e5aeca09ac", new DateTime(2024, 8, 14, 19, 12, 15, 248, DateTimeKind.Utc).AddTicks(6387), new DateTime(2024, 8, 14, 19, 12, 15, 248, DateTimeKind.Utc).AddTicks(6388), new DateTime(2024, 8, 14, 23, 12, 15, 248, DateTimeKind.Local).AddTicks(6382) });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: 2033,
                columns: new[] { "ConcurrencyStamp", "CreatedTime", "LastUpdatedTime", "RefreshTokenCreateTime" },
                values: new object[] { "569e6684-b6ef-42ae-a68c-5114b79fc9b6", new DateTime(2024, 8, 14, 19, 12, 15, 248, DateTimeKind.Utc).AddTicks(6401), new DateTime(2024, 8, 14, 19, 12, 15, 248, DateTimeKind.Utc).AddTicks(6401), new DateTime(2024, 8, 14, 23, 12, 15, 248, DateTimeKind.Local).AddTicks(6395) });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: 2034,
                columns: new[] { "ConcurrencyStamp", "CreatedTime", "LastUpdatedTime", "RefreshTokenCreateTime" },
                values: new object[] { "37639813-40bb-4969-808a-d7a864b76065", new DateTime(2024, 8, 14, 19, 12, 15, 248, DateTimeKind.Utc).AddTicks(6436), new DateTime(2024, 8, 14, 19, 12, 15, 248, DateTimeKind.Utc).AddTicks(6436), new DateTime(2024, 8, 14, 23, 12, 15, 248, DateTimeKind.Local).AddTicks(6430) });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: 2035,
                columns: new[] { "ConcurrencyStamp", "CreatedTime", "LastUpdatedTime", "RefreshTokenCreateTime" },
                values: new object[] { "79f11ce7-9912-4659-b3f7-b904882847ab", new DateTime(2024, 8, 14, 19, 12, 15, 248, DateTimeKind.Utc).AddTicks(6450), new DateTime(2024, 8, 14, 19, 12, 15, 248, DateTimeKind.Utc).AddTicks(6451), new DateTime(2024, 8, 14, 23, 12, 15, 248, DateTimeKind.Local).AddTicks(6445) });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: 2036,
                columns: new[] { "ConcurrencyStamp", "CreatedTime", "LastUpdatedTime", "RefreshTokenCreateTime" },
                values: new object[] { "4f7c88a7-66cf-4a6f-bd0b-5b546a3cfbb8", new DateTime(2024, 8, 14, 19, 12, 15, 248, DateTimeKind.Utc).AddTicks(6464), new DateTime(2024, 8, 14, 19, 12, 15, 248, DateTimeKind.Utc).AddTicks(6464), new DateTime(2024, 8, 14, 23, 12, 15, 248, DateTimeKind.Local).AddTicks(6459) });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: 2037,
                columns: new[] { "ConcurrencyStamp", "CreatedTime", "LastUpdatedTime", "RefreshTokenCreateTime" },
                values: new object[] { "1e993413-de7d-4828-86cb-da3bc4857333", new DateTime(2024, 8, 14, 19, 12, 15, 248, DateTimeKind.Utc).AddTicks(6478), new DateTime(2024, 8, 14, 19, 12, 15, 248, DateTimeKind.Utc).AddTicks(6479), new DateTime(2024, 8, 14, 23, 12, 15, 248, DateTimeKind.Local).AddTicks(6472) });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: 2038,
                columns: new[] { "ConcurrencyStamp", "CreatedTime", "LastUpdatedTime", "RefreshTokenCreateTime" },
                values: new object[] { "d7c667ba-7531-41dc-98ac-591b7fac6b45", new DateTime(2024, 8, 14, 19, 12, 15, 248, DateTimeKind.Utc).AddTicks(6495), new DateTime(2024, 8, 14, 19, 12, 15, 248, DateTimeKind.Utc).AddTicks(6495), new DateTime(2024, 8, 14, 23, 12, 15, 248, DateTimeKind.Local).AddTicks(6486) });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: 2039,
                columns: new[] { "ConcurrencyStamp", "CreatedTime", "LastUpdatedTime", "RefreshTokenCreateTime" },
                values: new object[] { "388801d3-2c57-4905-a950-0a7ab8ab2981", new DateTime(2024, 8, 14, 19, 12, 15, 248, DateTimeKind.Utc).AddTicks(6508), new DateTime(2024, 8, 14, 19, 12, 15, 248, DateTimeKind.Utc).AddTicks(6508), new DateTime(2024, 8, 14, 23, 12, 15, 248, DateTimeKind.Local).AddTicks(6503) });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: 2040,
                columns: new[] { "ConcurrencyStamp", "CreatedTime", "LastUpdatedTime", "RefreshTokenCreateTime" },
                values: new object[] { "43942ffb-96ce-49fd-88b7-cfd915cf95ac", new DateTime(2024, 8, 14, 19, 12, 15, 248, DateTimeKind.Utc).AddTicks(6521), new DateTime(2024, 8, 14, 19, 12, 15, 248, DateTimeKind.Utc).AddTicks(6522), new DateTime(2024, 8, 14, 23, 12, 15, 248, DateTimeKind.Local).AddTicks(6516) });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: 2041,
                columns: new[] { "ConcurrencyStamp", "CreatedTime", "LastUpdatedTime", "RefreshTokenCreateTime" },
                values: new object[] { "91f61b8b-5240-4a94-b725-2b2e4ba89430", new DateTime(2024, 8, 14, 19, 12, 15, 248, DateTimeKind.Utc).AddTicks(6534), new DateTime(2024, 8, 14, 19, 12, 15, 248, DateTimeKind.Utc).AddTicks(6535), new DateTime(2024, 8, 14, 23, 12, 15, 248, DateTimeKind.Local).AddTicks(6529) });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: 2042,
                columns: new[] { "ConcurrencyStamp", "CreatedTime", "LastUpdatedTime", "RefreshTokenCreateTime" },
                values: new object[] { "4f7ef139-3765-4e20-a121-8b796807d864", new DateTime(2024, 8, 14, 19, 12, 15, 248, DateTimeKind.Utc).AddTicks(6628), new DateTime(2024, 8, 14, 19, 12, 15, 248, DateTimeKind.Utc).AddTicks(6629), new DateTime(2024, 8, 14, 23, 12, 15, 248, DateTimeKind.Local).AddTicks(6623) });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: 2043,
                columns: new[] { "ConcurrencyStamp", "CreatedTime", "LastUpdatedTime", "RefreshTokenCreateTime" },
                values: new object[] { "460a2739-13bf-42d5-88b5-e319779d6385", new DateTime(2024, 8, 14, 19, 12, 15, 248, DateTimeKind.Utc).AddTicks(6643), new DateTime(2024, 8, 14, 19, 12, 15, 248, DateTimeKind.Utc).AddTicks(6643), new DateTime(2024, 8, 14, 23, 12, 15, 248, DateTimeKind.Local).AddTicks(6638) });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: 2044,
                columns: new[] { "ConcurrencyStamp", "CreatedTime", "LastUpdatedTime", "RefreshTokenCreateTime" },
                values: new object[] { "f09f0b46-8923-47c1-9901-51018e926ce3", new DateTime(2024, 8, 14, 19, 12, 15, 248, DateTimeKind.Utc).AddTicks(6657), new DateTime(2024, 8, 14, 19, 12, 15, 248, DateTimeKind.Utc).AddTicks(6657), new DateTime(2024, 8, 14, 23, 12, 15, 248, DateTimeKind.Local).AddTicks(6651) });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: 2045,
                columns: new[] { "ConcurrencyStamp", "CreatedTime", "LastUpdatedTime", "RefreshTokenCreateTime" },
                values: new object[] { "9e4f7515-efb9-4e16-a38e-90a93002b2df", new DateTime(2024, 8, 14, 19, 12, 15, 248, DateTimeKind.Utc).AddTicks(6672), new DateTime(2024, 8, 14, 19, 12, 15, 248, DateTimeKind.Utc).AddTicks(6672), new DateTime(2024, 8, 14, 23, 12, 15, 248, DateTimeKind.Local).AddTicks(6666) });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: 2046,
                columns: new[] { "ConcurrencyStamp", "CreatedTime", "LastUpdatedTime", "RefreshTokenCreateTime" },
                values: new object[] { "22e71857-5728-4e59-89a9-973cbfe0b30b", new DateTime(2024, 8, 14, 19, 12, 15, 248, DateTimeKind.Utc).AddTicks(6688), new DateTime(2024, 8, 14, 19, 12, 15, 248, DateTimeKind.Utc).AddTicks(6689), new DateTime(2024, 8, 14, 23, 12, 15, 248, DateTimeKind.Local).AddTicks(6680) });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: 2047,
                columns: new[] { "ConcurrencyStamp", "CreatedTime", "LastUpdatedTime", "RefreshTokenCreateTime" },
                values: new object[] { "d131bd9b-48f9-4138-b824-350307f11053", new DateTime(2024, 8, 14, 19, 12, 15, 248, DateTimeKind.Utc).AddTicks(6703), new DateTime(2024, 8, 14, 19, 12, 15, 248, DateTimeKind.Utc).AddTicks(6703), new DateTime(2024, 8, 14, 23, 12, 15, 248, DateTimeKind.Local).AddTicks(6697) });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: 2048,
                columns: new[] { "ConcurrencyStamp", "CreatedTime", "LastUpdatedTime", "RefreshTokenCreateTime" },
                values: new object[] { "566eb4db-14f0-4ddf-b1d9-fe576f77d400", new DateTime(2024, 8, 14, 19, 12, 15, 248, DateTimeKind.Utc).AddTicks(6716), new DateTime(2024, 8, 14, 19, 12, 15, 248, DateTimeKind.Utc).AddTicks(6717), new DateTime(2024, 8, 14, 23, 12, 15, 248, DateTimeKind.Local).AddTicks(6711) });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: 2049,
                columns: new[] { "ConcurrencyStamp", "CreatedTime", "LastUpdatedTime", "RefreshTokenCreateTime" },
                values: new object[] { "dad1d1f8-2f3a-4e43-9787-eb1992cb82b6", new DateTime(2024, 8, 14, 19, 12, 15, 248, DateTimeKind.Utc).AddTicks(6730), new DateTime(2024, 8, 14, 19, 12, 15, 248, DateTimeKind.Utc).AddTicks(6730), new DateTime(2024, 8, 14, 23, 12, 15, 248, DateTimeKind.Local).AddTicks(6724) });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: 2050,
                columns: new[] { "ConcurrencyStamp", "CreatedTime", "LastUpdatedTime", "RefreshTokenCreateTime" },
                values: new object[] { "cc80a391-ab83-4fdc-8e29-f5d294469220", new DateTime(2024, 8, 14, 19, 12, 15, 248, DateTimeKind.Utc).AddTicks(6744), new DateTime(2024, 8, 14, 19, 12, 15, 248, DateTimeKind.Utc).AddTicks(6744), new DateTime(2024, 8, 14, 23, 12, 15, 248, DateTimeKind.Local).AddTicks(6738) });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: 2051,
                columns: new[] { "ConcurrencyStamp", "CreatedTime", "LastUpdatedTime", "RefreshTokenCreateTime" },
                values: new object[] { "dd88a15f-27b6-40e1-89cf-d4b64bd2c5a4", new DateTime(2024, 8, 14, 19, 12, 15, 248, DateTimeKind.Utc).AddTicks(6800), new DateTime(2024, 8, 14, 19, 12, 15, 248, DateTimeKind.Utc).AddTicks(6800), new DateTime(2024, 8, 14, 23, 12, 15, 248, DateTimeKind.Local).AddTicks(6794) });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: 2052,
                columns: new[] { "ConcurrencyStamp", "CreatedTime", "LastUpdatedTime", "RefreshTokenCreateTime" },
                values: new object[] { "4dac817b-7211-4616-bc10-01393c442c84", new DateTime(2024, 8, 14, 19, 12, 15, 248, DateTimeKind.Utc).AddTicks(6814), new DateTime(2024, 8, 14, 19, 12, 15, 248, DateTimeKind.Utc).AddTicks(6814), new DateTime(2024, 8, 14, 23, 12, 15, 248, DateTimeKind.Local).AddTicks(6809) });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: 2053,
                columns: new[] { "ConcurrencyStamp", "CreatedTime", "LastUpdatedTime", "RefreshTokenCreateTime" },
                values: new object[] { "96a48191-074d-4f52-9098-51b3004968d2", new DateTime(2024, 8, 14, 19, 12, 15, 248, DateTimeKind.Utc).AddTicks(6827), new DateTime(2024, 8, 14, 19, 12, 15, 248, DateTimeKind.Utc).AddTicks(6827), new DateTime(2024, 8, 14, 23, 12, 15, 248, DateTimeKind.Local).AddTicks(6822) });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: 2054,
                columns: new[] { "ConcurrencyStamp", "CreatedTime", "LastUpdatedTime", "RefreshTokenCreateTime" },
                values: new object[] { "eeac1b09-29c2-446a-a5e4-8a330bafe04e", new DateTime(2024, 8, 14, 19, 12, 15, 248, DateTimeKind.Utc).AddTicks(6844), new DateTime(2024, 8, 14, 19, 12, 15, 248, DateTimeKind.Utc).AddTicks(6844), new DateTime(2024, 8, 14, 23, 12, 15, 248, DateTimeKind.Local).AddTicks(6835) });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: 2055,
                columns: new[] { "ConcurrencyStamp", "CreatedTime", "LastUpdatedTime", "RefreshTokenCreateTime" },
                values: new object[] { "32c4e382-0878-40c2-a68e-7953397789ba", new DateTime(2024, 8, 14, 19, 12, 15, 248, DateTimeKind.Utc).AddTicks(6857), new DateTime(2024, 8, 14, 19, 12, 15, 248, DateTimeKind.Utc).AddTicks(6858), new DateTime(2024, 8, 14, 23, 12, 15, 248, DateTimeKind.Local).AddTicks(6852) });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: 2056,
                columns: new[] { "ConcurrencyStamp", "CreatedTime", "LastUpdatedTime", "RefreshTokenCreateTime" },
                values: new object[] { "ee549ede-3347-4bcc-8c6d-d350d91a1f41", new DateTime(2024, 8, 14, 19, 12, 15, 248, DateTimeKind.Utc).AddTicks(6871), new DateTime(2024, 8, 14, 19, 12, 15, 248, DateTimeKind.Utc).AddTicks(6871), new DateTime(2024, 8, 14, 23, 12, 15, 248, DateTimeKind.Local).AddTicks(6866) });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: 2057,
                columns: new[] { "ConcurrencyStamp", "CreatedTime", "LastUpdatedTime", "RefreshTokenCreateTime" },
                values: new object[] { "b22dae8e-a3df-4146-b3b7-38e21feed47d", new DateTime(2024, 8, 14, 19, 12, 15, 248, DateTimeKind.Utc).AddTicks(6884), new DateTime(2024, 8, 14, 19, 12, 15, 248, DateTimeKind.Utc).AddTicks(6885), new DateTime(2024, 8, 14, 23, 12, 15, 248, DateTimeKind.Local).AddTicks(6879) });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: 2058,
                columns: new[] { "ConcurrencyStamp", "CreatedTime", "LastUpdatedTime", "RefreshTokenCreateTime" },
                values: new object[] { "1a06d1d2-7516-47ec-9147-8e11f6741ef4", new DateTime(2024, 8, 14, 19, 12, 15, 248, DateTimeKind.Utc).AddTicks(6897), new DateTime(2024, 8, 14, 19, 12, 15, 248, DateTimeKind.Utc).AddTicks(6898), new DateTime(2024, 8, 14, 23, 12, 15, 248, DateTimeKind.Local).AddTicks(6892) });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: 2059,
                columns: new[] { "ConcurrencyStamp", "CreatedTime", "LastUpdatedTime", "RefreshTokenCreateTime" },
                values: new object[] { "6b4d225d-68e4-4366-8a30-02fd998414af", new DateTime(2024, 8, 14, 19, 12, 15, 248, DateTimeKind.Utc).AddTicks(6911), new DateTime(2024, 8, 14, 19, 12, 15, 248, DateTimeKind.Utc).AddTicks(6911), new DateTime(2024, 8, 14, 23, 12, 15, 248, DateTimeKind.Local).AddTicks(6906) });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: 2060,
                columns: new[] { "ConcurrencyStamp", "CreatedTime", "LastUpdatedTime", "RefreshTokenCreateTime" },
                values: new object[] { "9319a7c1-29d8-4478-9636-f3fcaa1db2bf", new DateTime(2024, 8, 14, 19, 12, 15, 248, DateTimeKind.Utc).AddTicks(6955), new DateTime(2024, 8, 14, 19, 12, 15, 248, DateTimeKind.Utc).AddTicks(6955), new DateTime(2024, 8, 14, 23, 12, 15, 248, DateTimeKind.Local).AddTicks(6919) });

            migrationBuilder.InsertData(
                table: "AspNetUserRoles",
                columns: new[] { "RoleId", "UserId" },
                values: new object[,]
                {
                    { 1, 2001 },
                    { 1, 2002 },
                    { 1, 2003 },
                    { 1, 2004 },
                    { 1, 2005 },
                    { 1, 2006 },
                    { 1, 2007 },
                    { 1, 2008 },
                    { 1, 2009 },
                    { 1, 2010 },
                    { 1, 2011 },
                    { 1, 2012 },
                    { 1, 2013 },
                    { 1, 2014 },
                    { 1, 2015 },
                    { 1, 2016 },
                    { 1, 2017 },
                    { 1, 2018 },
                    { 1, 2019 },
                    { 1, 2020 },
                    { 3, 2021 },
                    { 3, 2022 },
                    { 3, 2023 },
                    { 3, 2024 },
                    { 3, 2025 },
                    { 3, 2026 },
                    { 3, 2027 },
                    { 3, 2028 },
                    { 3, 2029 },
                    { 3, 2030 },
                    { 3, 2031 },
                    { 3, 2032 },
                    { 3, 2033 },
                    { 3, 2034 },
                    { 3, 2035 },
                    { 3, 2036 },
                    { 3, 2037 },
                    { 3, 2038 },
                    { 3, 2039 },
                    { 2, 2040 },
                    { 2, 2041 },
                    { 2, 2042 },
                    { 2, 2043 },
                    { 2, 2044 },
                    { 2, 2045 },
                    { 2, 2046 },
                    { 2, 2047 },
                    { 2, 2048 },
                    { 2, 2049 },
                    { 2, 2050 },
                    { 2, 2051 },
                    { 2, 2052 },
                    { 2, 2053 },
                    { 2, 2054 },
                    { 2, 2055 },
                    { 2, 2056 },
                    { 2, 2057 },
                    { 2, 2058 },
                    { 2, 2059 },
                    { 2, 2060 }
                });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: 4);

            migrationBuilder.DeleteData(
                table: "AspNetUserRoles",
                keyColumns: new[] { "RoleId", "UserId" },
                keyValues: new object[] { 1, 2001 });

            migrationBuilder.DeleteData(
                table: "AspNetUserRoles",
                keyColumns: new[] { "RoleId", "UserId" },
                keyValues: new object[] { 1, 2002 });

            migrationBuilder.DeleteData(
                table: "AspNetUserRoles",
                keyColumns: new[] { "RoleId", "UserId" },
                keyValues: new object[] { 1, 2003 });

            migrationBuilder.DeleteData(
                table: "AspNetUserRoles",
                keyColumns: new[] { "RoleId", "UserId" },
                keyValues: new object[] { 1, 2004 });

            migrationBuilder.DeleteData(
                table: "AspNetUserRoles",
                keyColumns: new[] { "RoleId", "UserId" },
                keyValues: new object[] { 1, 2005 });

            migrationBuilder.DeleteData(
                table: "AspNetUserRoles",
                keyColumns: new[] { "RoleId", "UserId" },
                keyValues: new object[] { 1, 2006 });

            migrationBuilder.DeleteData(
                table: "AspNetUserRoles",
                keyColumns: new[] { "RoleId", "UserId" },
                keyValues: new object[] { 1, 2007 });

            migrationBuilder.DeleteData(
                table: "AspNetUserRoles",
                keyColumns: new[] { "RoleId", "UserId" },
                keyValues: new object[] { 1, 2008 });

            migrationBuilder.DeleteData(
                table: "AspNetUserRoles",
                keyColumns: new[] { "RoleId", "UserId" },
                keyValues: new object[] { 1, 2009 });

            migrationBuilder.DeleteData(
                table: "AspNetUserRoles",
                keyColumns: new[] { "RoleId", "UserId" },
                keyValues: new object[] { 1, 2010 });

            migrationBuilder.DeleteData(
                table: "AspNetUserRoles",
                keyColumns: new[] { "RoleId", "UserId" },
                keyValues: new object[] { 1, 2011 });

            migrationBuilder.DeleteData(
                table: "AspNetUserRoles",
                keyColumns: new[] { "RoleId", "UserId" },
                keyValues: new object[] { 1, 2012 });

            migrationBuilder.DeleteData(
                table: "AspNetUserRoles",
                keyColumns: new[] { "RoleId", "UserId" },
                keyValues: new object[] { 1, 2013 });

            migrationBuilder.DeleteData(
                table: "AspNetUserRoles",
                keyColumns: new[] { "RoleId", "UserId" },
                keyValues: new object[] { 1, 2014 });

            migrationBuilder.DeleteData(
                table: "AspNetUserRoles",
                keyColumns: new[] { "RoleId", "UserId" },
                keyValues: new object[] { 1, 2015 });

            migrationBuilder.DeleteData(
                table: "AspNetUserRoles",
                keyColumns: new[] { "RoleId", "UserId" },
                keyValues: new object[] { 1, 2016 });

            migrationBuilder.DeleteData(
                table: "AspNetUserRoles",
                keyColumns: new[] { "RoleId", "UserId" },
                keyValues: new object[] { 1, 2017 });

            migrationBuilder.DeleteData(
                table: "AspNetUserRoles",
                keyColumns: new[] { "RoleId", "UserId" },
                keyValues: new object[] { 1, 2018 });

            migrationBuilder.DeleteData(
                table: "AspNetUserRoles",
                keyColumns: new[] { "RoleId", "UserId" },
                keyValues: new object[] { 1, 2019 });

            migrationBuilder.DeleteData(
                table: "AspNetUserRoles",
                keyColumns: new[] { "RoleId", "UserId" },
                keyValues: new object[] { 1, 2020 });

            migrationBuilder.DeleteData(
                table: "AspNetUserRoles",
                keyColumns: new[] { "RoleId", "UserId" },
                keyValues: new object[] { 3, 2021 });

            migrationBuilder.DeleteData(
                table: "AspNetUserRoles",
                keyColumns: new[] { "RoleId", "UserId" },
                keyValues: new object[] { 3, 2022 });

            migrationBuilder.DeleteData(
                table: "AspNetUserRoles",
                keyColumns: new[] { "RoleId", "UserId" },
                keyValues: new object[] { 3, 2023 });

            migrationBuilder.DeleteData(
                table: "AspNetUserRoles",
                keyColumns: new[] { "RoleId", "UserId" },
                keyValues: new object[] { 3, 2024 });

            migrationBuilder.DeleteData(
                table: "AspNetUserRoles",
                keyColumns: new[] { "RoleId", "UserId" },
                keyValues: new object[] { 3, 2025 });

            migrationBuilder.DeleteData(
                table: "AspNetUserRoles",
                keyColumns: new[] { "RoleId", "UserId" },
                keyValues: new object[] { 3, 2026 });

            migrationBuilder.DeleteData(
                table: "AspNetUserRoles",
                keyColumns: new[] { "RoleId", "UserId" },
                keyValues: new object[] { 3, 2027 });

            migrationBuilder.DeleteData(
                table: "AspNetUserRoles",
                keyColumns: new[] { "RoleId", "UserId" },
                keyValues: new object[] { 3, 2028 });

            migrationBuilder.DeleteData(
                table: "AspNetUserRoles",
                keyColumns: new[] { "RoleId", "UserId" },
                keyValues: new object[] { 3, 2029 });

            migrationBuilder.DeleteData(
                table: "AspNetUserRoles",
                keyColumns: new[] { "RoleId", "UserId" },
                keyValues: new object[] { 3, 2030 });

            migrationBuilder.DeleteData(
                table: "AspNetUserRoles",
                keyColumns: new[] { "RoleId", "UserId" },
                keyValues: new object[] { 3, 2031 });

            migrationBuilder.DeleteData(
                table: "AspNetUserRoles",
                keyColumns: new[] { "RoleId", "UserId" },
                keyValues: new object[] { 3, 2032 });

            migrationBuilder.DeleteData(
                table: "AspNetUserRoles",
                keyColumns: new[] { "RoleId", "UserId" },
                keyValues: new object[] { 3, 2033 });

            migrationBuilder.DeleteData(
                table: "AspNetUserRoles",
                keyColumns: new[] { "RoleId", "UserId" },
                keyValues: new object[] { 3, 2034 });

            migrationBuilder.DeleteData(
                table: "AspNetUserRoles",
                keyColumns: new[] { "RoleId", "UserId" },
                keyValues: new object[] { 3, 2035 });

            migrationBuilder.DeleteData(
                table: "AspNetUserRoles",
                keyColumns: new[] { "RoleId", "UserId" },
                keyValues: new object[] { 3, 2036 });

            migrationBuilder.DeleteData(
                table: "AspNetUserRoles",
                keyColumns: new[] { "RoleId", "UserId" },
                keyValues: new object[] { 3, 2037 });

            migrationBuilder.DeleteData(
                table: "AspNetUserRoles",
                keyColumns: new[] { "RoleId", "UserId" },
                keyValues: new object[] { 3, 2038 });

            migrationBuilder.DeleteData(
                table: "AspNetUserRoles",
                keyColumns: new[] { "RoleId", "UserId" },
                keyValues: new object[] { 3, 2039 });

            migrationBuilder.DeleteData(
                table: "AspNetUserRoles",
                keyColumns: new[] { "RoleId", "UserId" },
                keyValues: new object[] { 2, 2040 });

            migrationBuilder.DeleteData(
                table: "AspNetUserRoles",
                keyColumns: new[] { "RoleId", "UserId" },
                keyValues: new object[] { 2, 2041 });

            migrationBuilder.DeleteData(
                table: "AspNetUserRoles",
                keyColumns: new[] { "RoleId", "UserId" },
                keyValues: new object[] { 2, 2042 });

            migrationBuilder.DeleteData(
                table: "AspNetUserRoles",
                keyColumns: new[] { "RoleId", "UserId" },
                keyValues: new object[] { 2, 2043 });

            migrationBuilder.DeleteData(
                table: "AspNetUserRoles",
                keyColumns: new[] { "RoleId", "UserId" },
                keyValues: new object[] { 2, 2044 });

            migrationBuilder.DeleteData(
                table: "AspNetUserRoles",
                keyColumns: new[] { "RoleId", "UserId" },
                keyValues: new object[] { 2, 2045 });

            migrationBuilder.DeleteData(
                table: "AspNetUserRoles",
                keyColumns: new[] { "RoleId", "UserId" },
                keyValues: new object[] { 2, 2046 });

            migrationBuilder.DeleteData(
                table: "AspNetUserRoles",
                keyColumns: new[] { "RoleId", "UserId" },
                keyValues: new object[] { 2, 2047 });

            migrationBuilder.DeleteData(
                table: "AspNetUserRoles",
                keyColumns: new[] { "RoleId", "UserId" },
                keyValues: new object[] { 2, 2048 });

            migrationBuilder.DeleteData(
                table: "AspNetUserRoles",
                keyColumns: new[] { "RoleId", "UserId" },
                keyValues: new object[] { 2, 2049 });

            migrationBuilder.DeleteData(
                table: "AspNetUserRoles",
                keyColumns: new[] { "RoleId", "UserId" },
                keyValues: new object[] { 2, 2050 });

            migrationBuilder.DeleteData(
                table: "AspNetUserRoles",
                keyColumns: new[] { "RoleId", "UserId" },
                keyValues: new object[] { 2, 2051 });

            migrationBuilder.DeleteData(
                table: "AspNetUserRoles",
                keyColumns: new[] { "RoleId", "UserId" },
                keyValues: new object[] { 2, 2052 });

            migrationBuilder.DeleteData(
                table: "AspNetUserRoles",
                keyColumns: new[] { "RoleId", "UserId" },
                keyValues: new object[] { 2, 2053 });

            migrationBuilder.DeleteData(
                table: "AspNetUserRoles",
                keyColumns: new[] { "RoleId", "UserId" },
                keyValues: new object[] { 2, 2054 });

            migrationBuilder.DeleteData(
                table: "AspNetUserRoles",
                keyColumns: new[] { "RoleId", "UserId" },
                keyValues: new object[] { 2, 2055 });

            migrationBuilder.DeleteData(
                table: "AspNetUserRoles",
                keyColumns: new[] { "RoleId", "UserId" },
                keyValues: new object[] { 2, 2056 });

            migrationBuilder.DeleteData(
                table: "AspNetUserRoles",
                keyColumns: new[] { "RoleId", "UserId" },
                keyValues: new object[] { 2, 2057 });

            migrationBuilder.DeleteData(
                table: "AspNetUserRoles",
                keyColumns: new[] { "RoleId", "UserId" },
                keyValues: new object[] { 2, 2058 });

            migrationBuilder.DeleteData(
                table: "AspNetUserRoles",
                keyColumns: new[] { "RoleId", "UserId" },
                keyValues: new object[] { 2, 2059 });

            migrationBuilder.DeleteData(
                table: "AspNetUserRoles",
                keyColumns: new[] { "RoleId", "UserId" },
                keyValues: new object[] { 2, 2060 });

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: 3);

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: 2001,
                columns: new[] { "ConcurrencyStamp", "CreatedTime", "LastUpdatedTime", "RefreshTokenCreateTime" },
                values: new object[] { "a3d2b6f4-334f-4e60-b9db-9d309d6831b3", new DateTime(2024, 8, 14, 19, 2, 28, 562, DateTimeKind.Utc).AddTicks(3397), new DateTime(2024, 8, 14, 19, 2, 28, 562, DateTimeKind.Utc).AddTicks(3399), new DateTime(2024, 8, 14, 23, 2, 28, 562, DateTimeKind.Local).AddTicks(3268) });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: 2002,
                columns: new[] { "ConcurrencyStamp", "CreatedTime", "LastUpdatedTime", "RefreshTokenCreateTime" },
                values: new object[] { "51279223-cbd2-4165-855b-9e9cd1b29124", new DateTime(2024, 8, 14, 19, 2, 28, 562, DateTimeKind.Utc).AddTicks(3436), new DateTime(2024, 8, 14, 19, 2, 28, 562, DateTimeKind.Utc).AddTicks(3436), new DateTime(2024, 8, 14, 23, 2, 28, 562, DateTimeKind.Local).AddTicks(3428) });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: 2003,
                columns: new[] { "ConcurrencyStamp", "CreatedTime", "LastUpdatedTime", "RefreshTokenCreateTime" },
                values: new object[] { "87314677-9679-456d-a921-fb5fa792a728", new DateTime(2024, 8, 14, 19, 2, 28, 562, DateTimeKind.Utc).AddTicks(3499), new DateTime(2024, 8, 14, 19, 2, 28, 562, DateTimeKind.Utc).AddTicks(3500), new DateTime(2024, 8, 14, 23, 2, 28, 562, DateTimeKind.Local).AddTicks(3493) });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: 2004,
                columns: new[] { "ConcurrencyStamp", "CreatedTime", "LastUpdatedTime", "RefreshTokenCreateTime" },
                values: new object[] { "20065d78-61d9-4b85-a8cc-c5ba8579a8a1", new DateTime(2024, 8, 14, 19, 2, 28, 562, DateTimeKind.Utc).AddTicks(3527), new DateTime(2024, 8, 14, 19, 2, 28, 562, DateTimeKind.Utc).AddTicks(3528), new DateTime(2024, 8, 14, 23, 2, 28, 562, DateTimeKind.Local).AddTicks(3508) });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: 2005,
                columns: new[] { "ConcurrencyStamp", "CreatedTime", "LastUpdatedTime", "RefreshTokenCreateTime" },
                values: new object[] { "a24cb2c0-7561-457a-bc51-a7e533d5d17c", new DateTime(2024, 8, 14, 19, 2, 28, 562, DateTimeKind.Utc).AddTicks(3541), new DateTime(2024, 8, 14, 19, 2, 28, 562, DateTimeKind.Utc).AddTicks(3542), new DateTime(2024, 8, 14, 23, 2, 28, 562, DateTimeKind.Local).AddTicks(3536) });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: 2006,
                columns: new[] { "ConcurrencyStamp", "CreatedTime", "LastUpdatedTime", "RefreshTokenCreateTime" },
                values: new object[] { "7adcdb1a-c0c5-40c4-9c4d-f08aee1c7370", new DateTime(2024, 8, 14, 19, 2, 28, 562, DateTimeKind.Utc).AddTicks(3559), new DateTime(2024, 8, 14, 19, 2, 28, 562, DateTimeKind.Utc).AddTicks(3559), new DateTime(2024, 8, 14, 23, 2, 28, 562, DateTimeKind.Local).AddTicks(3553) });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: 2007,
                columns: new[] { "ConcurrencyStamp", "CreatedTime", "LastUpdatedTime", "RefreshTokenCreateTime" },
                values: new object[] { "946252c1-7b46-4d99-98a7-e922510c5053", new DateTime(2024, 8, 14, 19, 2, 28, 562, DateTimeKind.Utc).AddTicks(3573), new DateTime(2024, 8, 14, 19, 2, 28, 562, DateTimeKind.Utc).AddTicks(3574), new DateTime(2024, 8, 14, 23, 2, 28, 562, DateTimeKind.Local).AddTicks(3568) });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: 2008,
                columns: new[] { "ConcurrencyStamp", "CreatedTime", "LastUpdatedTime", "RefreshTokenCreateTime" },
                values: new object[] { "c59c8b50-8b03-47fc-9f25-100b8a5abfe7", new DateTime(2024, 8, 14, 19, 2, 28, 562, DateTimeKind.Utc).AddTicks(3587), new DateTime(2024, 8, 14, 19, 2, 28, 562, DateTimeKind.Utc).AddTicks(3588), new DateTime(2024, 8, 14, 23, 2, 28, 562, DateTimeKind.Local).AddTicks(3582) });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: 2009,
                columns: new[] { "ConcurrencyStamp", "CreatedTime", "LastUpdatedTime", "RefreshTokenCreateTime" },
                values: new object[] { "724d9e11-297d-4284-9d9c-fdf1be7770ba", new DateTime(2024, 8, 14, 19, 2, 28, 562, DateTimeKind.Utc).AddTicks(3603), new DateTime(2024, 8, 14, 19, 2, 28, 562, DateTimeKind.Utc).AddTicks(3603), new DateTime(2024, 8, 14, 23, 2, 28, 562, DateTimeKind.Local).AddTicks(3596) });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: 2010,
                columns: new[] { "ConcurrencyStamp", "CreatedTime", "LastUpdatedTime", "RefreshTokenCreateTime" },
                values: new object[] { "bb5d4c6c-da62-4d72-8f40-e8a0e6c4f5c9", new DateTime(2024, 8, 14, 19, 2, 28, 562, DateTimeKind.Utc).AddTicks(3621), new DateTime(2024, 8, 14, 19, 2, 28, 562, DateTimeKind.Utc).AddTicks(3621), new DateTime(2024, 8, 14, 23, 2, 28, 562, DateTimeKind.Local).AddTicks(3613) });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: 2011,
                columns: new[] { "ConcurrencyStamp", "CreatedTime", "LastUpdatedTime", "RefreshTokenCreateTime" },
                values: new object[] { "697dc1ca-869c-4805-950f-1c05201e7c54", new DateTime(2024, 8, 14, 19, 2, 28, 562, DateTimeKind.Utc).AddTicks(3636), new DateTime(2024, 8, 14, 19, 2, 28, 562, DateTimeKind.Utc).AddTicks(3636), new DateTime(2024, 8, 14, 23, 2, 28, 562, DateTimeKind.Local).AddTicks(3631) });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: 2012,
                columns: new[] { "ConcurrencyStamp", "CreatedTime", "LastUpdatedTime", "RefreshTokenCreateTime" },
                values: new object[] { "04372d74-b8af-4e94-81b3-c49da4559117", new DateTime(2024, 8, 14, 19, 2, 28, 562, DateTimeKind.Utc).AddTicks(3690), new DateTime(2024, 8, 14, 19, 2, 28, 562, DateTimeKind.Utc).AddTicks(3690), new DateTime(2024, 8, 14, 23, 2, 28, 562, DateTimeKind.Local).AddTicks(3645) });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: 2013,
                columns: new[] { "ConcurrencyStamp", "CreatedTime", "LastUpdatedTime", "RefreshTokenCreateTime" },
                values: new object[] { "6d1805d4-ba26-4c30-ba0e-d07e8a7d523c", new DateTime(2024, 8, 14, 19, 2, 28, 562, DateTimeKind.Utc).AddTicks(3705), new DateTime(2024, 8, 14, 19, 2, 28, 562, DateTimeKind.Utc).AddTicks(3706), new DateTime(2024, 8, 14, 23, 2, 28, 562, DateTimeKind.Local).AddTicks(3699) });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: 2014,
                columns: new[] { "ConcurrencyStamp", "CreatedTime", "LastUpdatedTime", "RefreshTokenCreateTime" },
                values: new object[] { "05ef2183-2b72-4ee5-b23a-f717f4c3b4c9", new DateTime(2024, 8, 14, 19, 2, 28, 562, DateTimeKind.Utc).AddTicks(3720), new DateTime(2024, 8, 14, 19, 2, 28, 562, DateTimeKind.Utc).AddTicks(3720), new DateTime(2024, 8, 14, 23, 2, 28, 562, DateTimeKind.Local).AddTicks(3714) });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: 2015,
                columns: new[] { "ConcurrencyStamp", "CreatedTime", "LastUpdatedTime", "RefreshTokenCreateTime" },
                values: new object[] { "50c32b3b-7c38-4d10-a123-97bbb54d3d1d", new DateTime(2024, 8, 14, 19, 2, 28, 562, DateTimeKind.Utc).AddTicks(3734), new DateTime(2024, 8, 14, 19, 2, 28, 562, DateTimeKind.Utc).AddTicks(3735), new DateTime(2024, 8, 14, 23, 2, 28, 562, DateTimeKind.Local).AddTicks(3729) });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: 2016,
                columns: new[] { "ConcurrencyStamp", "CreatedTime", "LastUpdatedTime", "RefreshTokenCreateTime" },
                values: new object[] { "af3aa788-2f82-4bb0-9269-6a87f10e3ab4", new DateTime(2024, 8, 14, 19, 2, 28, 562, DateTimeKind.Utc).AddTicks(3748), new DateTime(2024, 8, 14, 19, 2, 28, 562, DateTimeKind.Utc).AddTicks(3749), new DateTime(2024, 8, 14, 23, 2, 28, 562, DateTimeKind.Local).AddTicks(3743) });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: 2017,
                columns: new[] { "ConcurrencyStamp", "CreatedTime", "LastUpdatedTime", "RefreshTokenCreateTime" },
                values: new object[] { "fd18c7a7-cad9-4fd5-98c6-ca70d396a7fe", new DateTime(2024, 8, 14, 19, 2, 28, 562, DateTimeKind.Utc).AddTicks(3763), new DateTime(2024, 8, 14, 19, 2, 28, 562, DateTimeKind.Utc).AddTicks(3764), new DateTime(2024, 8, 14, 23, 2, 28, 562, DateTimeKind.Local).AddTicks(3758) });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: 2018,
                columns: new[] { "ConcurrencyStamp", "CreatedTime", "LastUpdatedTime", "RefreshTokenCreateTime" },
                values: new object[] { "8ebb4a3f-287d-4f22-a8ad-5072c7772fe0", new DateTime(2024, 8, 14, 19, 2, 28, 562, DateTimeKind.Utc).AddTicks(3779), new DateTime(2024, 8, 14, 19, 2, 28, 562, DateTimeKind.Utc).AddTicks(3780), new DateTime(2024, 8, 14, 23, 2, 28, 562, DateTimeKind.Local).AddTicks(3774) });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: 2019,
                columns: new[] { "ConcurrencyStamp", "CreatedTime", "LastUpdatedTime", "RefreshTokenCreateTime" },
                values: new object[] { "09cb471b-0ff4-43ab-982b-3e44f7a600ff", new DateTime(2024, 8, 14, 19, 2, 28, 562, DateTimeKind.Utc).AddTicks(3794), new DateTime(2024, 8, 14, 19, 2, 28, 562, DateTimeKind.Utc).AddTicks(3794), new DateTime(2024, 8, 14, 23, 2, 28, 562, DateTimeKind.Local).AddTicks(3788) });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: 2020,
                columns: new[] { "ConcurrencyStamp", "CreatedTime", "LastUpdatedTime", "RefreshTokenCreateTime" },
                values: new object[] { "e85b56f8-12ba-4cdd-9546-718e86fec485", new DateTime(2024, 8, 14, 19, 2, 28, 562, DateTimeKind.Utc).AddTicks(3812), new DateTime(2024, 8, 14, 19, 2, 28, 562, DateTimeKind.Utc).AddTicks(3812), new DateTime(2024, 8, 14, 23, 2, 28, 562, DateTimeKind.Local).AddTicks(3803) });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: 2021,
                columns: new[] { "ConcurrencyStamp", "CreatedTime", "LastUpdatedTime", "RefreshTokenCreateTime" },
                values: new object[] { "8dbaca79-fc21-447f-9b6e-5772b493069c", new DateTime(2024, 8, 14, 19, 2, 28, 562, DateTimeKind.Utc).AddTicks(3858), new DateTime(2024, 8, 14, 19, 2, 28, 562, DateTimeKind.Utc).AddTicks(3859), new DateTime(2024, 8, 14, 23, 2, 28, 562, DateTimeKind.Local).AddTicks(3852) });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: 2022,
                columns: new[] { "ConcurrencyStamp", "CreatedTime", "LastUpdatedTime", "RefreshTokenCreateTime" },
                values: new object[] { "01f57958-601c-4b5f-818a-a464c2a40cff", new DateTime(2024, 8, 14, 19, 2, 28, 562, DateTimeKind.Utc).AddTicks(3878), new DateTime(2024, 8, 14, 19, 2, 28, 562, DateTimeKind.Utc).AddTicks(3879), new DateTime(2024, 8, 14, 23, 2, 28, 562, DateTimeKind.Local).AddTicks(3872) });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: 2023,
                columns: new[] { "ConcurrencyStamp", "CreatedTime", "LastUpdatedTime", "RefreshTokenCreateTime" },
                values: new object[] { "3dca588e-eef3-4cc7-b1c4-2595e291bb07", new DateTime(2024, 8, 14, 19, 2, 28, 562, DateTimeKind.Utc).AddTicks(3893), new DateTime(2024, 8, 14, 19, 2, 28, 562, DateTimeKind.Utc).AddTicks(3894), new DateTime(2024, 8, 14, 23, 2, 28, 562, DateTimeKind.Local).AddTicks(3888) });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: 2024,
                columns: new[] { "ConcurrencyStamp", "CreatedTime", "LastUpdatedTime", "RefreshTokenCreateTime" },
                values: new object[] { "e1cefbf9-7f53-41a7-ae0d-b82f0e05020a", new DateTime(2024, 8, 14, 19, 2, 28, 562, DateTimeKind.Utc).AddTicks(3908), new DateTime(2024, 8, 14, 19, 2, 28, 562, DateTimeKind.Utc).AddTicks(3908), new DateTime(2024, 8, 14, 23, 2, 28, 562, DateTimeKind.Local).AddTicks(3902) });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: 2025,
                columns: new[] { "ConcurrencyStamp", "CreatedTime", "LastUpdatedTime", "RefreshTokenCreateTime" },
                values: new object[] { "546e0cef-d1d2-4d74-a757-5a95ac957e41", new DateTime(2024, 8, 14, 19, 2, 28, 562, DateTimeKind.Utc).AddTicks(3922), new DateTime(2024, 8, 14, 19, 2, 28, 562, DateTimeKind.Utc).AddTicks(3922), new DateTime(2024, 8, 14, 23, 2, 28, 562, DateTimeKind.Local).AddTicks(3917) });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: 2026,
                columns: new[] { "ConcurrencyStamp", "CreatedTime", "LastUpdatedTime", "RefreshTokenCreateTime" },
                values: new object[] { "c45ac3fb-6fb4-4ced-88e7-8a21a5347582", new DateTime(2024, 8, 14, 19, 2, 28, 562, DateTimeKind.Utc).AddTicks(3937), new DateTime(2024, 8, 14, 19, 2, 28, 562, DateTimeKind.Utc).AddTicks(3938), new DateTime(2024, 8, 14, 23, 2, 28, 562, DateTimeKind.Local).AddTicks(3931) });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: 2027,
                columns: new[] { "ConcurrencyStamp", "CreatedTime", "LastUpdatedTime", "RefreshTokenCreateTime" },
                values: new object[] { "4ce85c12-b847-48f3-aa84-0eceb6795ade", new DateTime(2024, 8, 14, 19, 2, 28, 562, DateTimeKind.Utc).AddTicks(3952), new DateTime(2024, 8, 14, 19, 2, 28, 562, DateTimeKind.Utc).AddTicks(3952), new DateTime(2024, 8, 14, 23, 2, 28, 562, DateTimeKind.Local).AddTicks(3947) });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: 2028,
                columns: new[] { "ConcurrencyStamp", "CreatedTime", "LastUpdatedTime", "RefreshTokenCreateTime" },
                values: new object[] { "3d342769-2855-4dc8-a5ba-c9197779311e", new DateTime(2024, 8, 14, 19, 2, 28, 562, DateTimeKind.Utc).AddTicks(3969), new DateTime(2024, 8, 14, 19, 2, 28, 562, DateTimeKind.Utc).AddTicks(3970), new DateTime(2024, 8, 14, 23, 2, 28, 562, DateTimeKind.Local).AddTicks(3961) });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: 2029,
                columns: new[] { "ConcurrencyStamp", "CreatedTime", "LastUpdatedTime", "RefreshTokenCreateTime" },
                values: new object[] { "82066386-6fdc-4d4c-8f92-62a6ca16a1f1", new DateTime(2024, 8, 14, 19, 2, 28, 562, DateTimeKind.Utc).AddTicks(3985), new DateTime(2024, 8, 14, 19, 2, 28, 562, DateTimeKind.Utc).AddTicks(3985), new DateTime(2024, 8, 14, 23, 2, 28, 562, DateTimeKind.Local).AddTicks(3979) });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: 2030,
                columns: new[] { "ConcurrencyStamp", "CreatedTime", "LastUpdatedTime", "RefreshTokenCreateTime" },
                values: new object[] { "2b728e98-0342-4c9f-a443-30545193e4f6", new DateTime(2024, 8, 14, 19, 2, 28, 562, DateTimeKind.Utc).AddTicks(4031), new DateTime(2024, 8, 14, 19, 2, 28, 562, DateTimeKind.Utc).AddTicks(4032), new DateTime(2024, 8, 14, 23, 2, 28, 562, DateTimeKind.Local).AddTicks(4025) });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: 2031,
                columns: new[] { "ConcurrencyStamp", "CreatedTime", "LastUpdatedTime", "RefreshTokenCreateTime" },
                values: new object[] { "8f1c8b73-448f-4596-be75-36c5afd74d13", new DateTime(2024, 8, 14, 19, 2, 28, 562, DateTimeKind.Utc).AddTicks(4046), new DateTime(2024, 8, 14, 19, 2, 28, 562, DateTimeKind.Utc).AddTicks(4046), new DateTime(2024, 8, 14, 23, 2, 28, 562, DateTimeKind.Local).AddTicks(4041) });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: 2032,
                columns: new[] { "ConcurrencyStamp", "CreatedTime", "LastUpdatedTime", "RefreshTokenCreateTime" },
                values: new object[] { "b852ef0e-08c3-468c-ba64-27f2ca7cc06d", new DateTime(2024, 8, 14, 19, 2, 28, 562, DateTimeKind.Utc).AddTicks(4060), new DateTime(2024, 8, 14, 19, 2, 28, 562, DateTimeKind.Utc).AddTicks(4061), new DateTime(2024, 8, 14, 23, 2, 28, 562, DateTimeKind.Local).AddTicks(4055) });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: 2033,
                columns: new[] { "ConcurrencyStamp", "CreatedTime", "LastUpdatedTime", "RefreshTokenCreateTime" },
                values: new object[] { "7d7cc09d-5bf7-441e-ac46-399b1f5f4784", new DateTime(2024, 8, 14, 19, 2, 28, 562, DateTimeKind.Utc).AddTicks(4074), new DateTime(2024, 8, 14, 19, 2, 28, 562, DateTimeKind.Utc).AddTicks(4075), new DateTime(2024, 8, 14, 23, 2, 28, 562, DateTimeKind.Local).AddTicks(4069) });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: 2034,
                columns: new[] { "ConcurrencyStamp", "CreatedTime", "LastUpdatedTime", "RefreshTokenCreateTime" },
                values: new object[] { "915dc780-4c4f-4a36-9cec-5b176abce6da", new DateTime(2024, 8, 14, 19, 2, 28, 562, DateTimeKind.Utc).AddTicks(4091), new DateTime(2024, 8, 14, 19, 2, 28, 562, DateTimeKind.Utc).AddTicks(4092), new DateTime(2024, 8, 14, 23, 2, 28, 562, DateTimeKind.Local).AddTicks(4086) });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: 2035,
                columns: new[] { "ConcurrencyStamp", "CreatedTime", "LastUpdatedTime", "RefreshTokenCreateTime" },
                values: new object[] { "0482645e-7a4a-48a7-9949-68e72a558e9e", new DateTime(2024, 8, 14, 19, 2, 28, 562, DateTimeKind.Utc).AddTicks(4106), new DateTime(2024, 8, 14, 19, 2, 28, 562, DateTimeKind.Utc).AddTicks(4106), new DateTime(2024, 8, 14, 23, 2, 28, 562, DateTimeKind.Local).AddTicks(4100) });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: 2036,
                columns: new[] { "ConcurrencyStamp", "CreatedTime", "LastUpdatedTime", "RefreshTokenCreateTime" },
                values: new object[] { "9cdb5bc9-92b2-476f-81de-2dca715b47c3", new DateTime(2024, 8, 14, 19, 2, 28, 562, DateTimeKind.Utc).AddTicks(4123), new DateTime(2024, 8, 14, 19, 2, 28, 562, DateTimeKind.Utc).AddTicks(4123), new DateTime(2024, 8, 14, 23, 2, 28, 562, DateTimeKind.Local).AddTicks(4114) });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: 2037,
                columns: new[] { "ConcurrencyStamp", "CreatedTime", "LastUpdatedTime", "RefreshTokenCreateTime" },
                values: new object[] { "b444d3a1-6376-4298-bf44-2cb5f609b9ef", new DateTime(2024, 8, 14, 19, 2, 28, 562, DateTimeKind.Utc).AddTicks(4138), new DateTime(2024, 8, 14, 19, 2, 28, 562, DateTimeKind.Utc).AddTicks(4138), new DateTime(2024, 8, 14, 23, 2, 28, 562, DateTimeKind.Local).AddTicks(4132) });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: 2038,
                columns: new[] { "ConcurrencyStamp", "CreatedTime", "LastUpdatedTime", "RefreshTokenCreateTime" },
                values: new object[] { "8a122241-20aa-49da-8a4c-6cf424432988", new DateTime(2024, 8, 14, 19, 2, 28, 562, DateTimeKind.Utc).AddTicks(4182), new DateTime(2024, 8, 14, 19, 2, 28, 562, DateTimeKind.Utc).AddTicks(4182), new DateTime(2024, 8, 14, 23, 2, 28, 562, DateTimeKind.Local).AddTicks(4146) });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: 2039,
                columns: new[] { "ConcurrencyStamp", "CreatedTime", "LastUpdatedTime", "RefreshTokenCreateTime" },
                values: new object[] { "822fb754-9e4e-4e8f-808c-048def1da0a1", new DateTime(2024, 8, 14, 19, 2, 28, 562, DateTimeKind.Utc).AddTicks(4196), new DateTime(2024, 8, 14, 19, 2, 28, 562, DateTimeKind.Utc).AddTicks(4197), new DateTime(2024, 8, 14, 23, 2, 28, 562, DateTimeKind.Local).AddTicks(4191) });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: 2040,
                columns: new[] { "ConcurrencyStamp", "CreatedTime", "LastUpdatedTime", "RefreshTokenCreateTime" },
                values: new object[] { "26f56aae-559d-410d-8e52-449c01aedb9b", new DateTime(2024, 8, 14, 19, 2, 28, 562, DateTimeKind.Utc).AddTicks(4211), new DateTime(2024, 8, 14, 19, 2, 28, 562, DateTimeKind.Utc).AddTicks(4211), new DateTime(2024, 8, 14, 23, 2, 28, 562, DateTimeKind.Local).AddTicks(4205) });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: 2041,
                columns: new[] { "ConcurrencyStamp", "CreatedTime", "LastUpdatedTime", "RefreshTokenCreateTime" },
                values: new object[] { "5ad7353f-7572-4022-b2b4-69678e5aa28f", new DateTime(2024, 8, 14, 19, 2, 28, 562, DateTimeKind.Utc).AddTicks(4226), new DateTime(2024, 8, 14, 19, 2, 28, 562, DateTimeKind.Utc).AddTicks(4226), new DateTime(2024, 8, 14, 23, 2, 28, 562, DateTimeKind.Local).AddTicks(4220) });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: 2042,
                columns: new[] { "ConcurrencyStamp", "CreatedTime", "LastUpdatedTime", "RefreshTokenCreateTime" },
                values: new object[] { "5f54513a-f9a3-483c-9dcb-f7a926409057", new DateTime(2024, 8, 14, 19, 2, 28, 562, DateTimeKind.Utc).AddTicks(4245), new DateTime(2024, 8, 14, 19, 2, 28, 562, DateTimeKind.Utc).AddTicks(4246), new DateTime(2024, 8, 14, 23, 2, 28, 562, DateTimeKind.Local).AddTicks(4240) });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: 2043,
                columns: new[] { "ConcurrencyStamp", "CreatedTime", "LastUpdatedTime", "RefreshTokenCreateTime" },
                values: new object[] { "c2034459-81d8-4425-ba22-626eacf66f2d", new DateTime(2024, 8, 14, 19, 2, 28, 562, DateTimeKind.Utc).AddTicks(4260), new DateTime(2024, 8, 14, 19, 2, 28, 562, DateTimeKind.Utc).AddTicks(4260), new DateTime(2024, 8, 14, 23, 2, 28, 562, DateTimeKind.Local).AddTicks(4255) });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: 2044,
                columns: new[] { "ConcurrencyStamp", "CreatedTime", "LastUpdatedTime", "RefreshTokenCreateTime" },
                values: new object[] { "97711a43-dac0-405e-ae5b-b375b5e569be", new DateTime(2024, 8, 14, 19, 2, 28, 562, DateTimeKind.Utc).AddTicks(4278), new DateTime(2024, 8, 14, 19, 2, 28, 562, DateTimeKind.Utc).AddTicks(4278), new DateTime(2024, 8, 14, 23, 2, 28, 562, DateTimeKind.Local).AddTicks(4270) });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: 2045,
                columns: new[] { "ConcurrencyStamp", "CreatedTime", "LastUpdatedTime", "RefreshTokenCreateTime" },
                values: new object[] { "0b374e95-0336-4fa6-bae3-63dadf8c5391", new DateTime(2024, 8, 14, 19, 2, 28, 562, DateTimeKind.Utc).AddTicks(4293), new DateTime(2024, 8, 14, 19, 2, 28, 562, DateTimeKind.Utc).AddTicks(4294), new DateTime(2024, 8, 14, 23, 2, 28, 562, DateTimeKind.Local).AddTicks(4288) });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: 2046,
                columns: new[] { "ConcurrencyStamp", "CreatedTime", "LastUpdatedTime", "RefreshTokenCreateTime" },
                values: new object[] { "31727611-a4ff-44a9-a68e-3abe206837f4", new DateTime(2024, 8, 14, 19, 2, 28, 562, DateTimeKind.Utc).AddTicks(4308), new DateTime(2024, 8, 14, 19, 2, 28, 562, DateTimeKind.Utc).AddTicks(4309), new DateTime(2024, 8, 14, 23, 2, 28, 562, DateTimeKind.Local).AddTicks(4303) });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: 2047,
                columns: new[] { "ConcurrencyStamp", "CreatedTime", "LastUpdatedTime", "RefreshTokenCreateTime" },
                values: new object[] { "7dede10a-f6eb-40da-a696-0dff3dd66636", new DateTime(2024, 8, 14, 19, 2, 28, 562, DateTimeKind.Utc).AddTicks(4323), new DateTime(2024, 8, 14, 19, 2, 28, 562, DateTimeKind.Utc).AddTicks(4323), new DateTime(2024, 8, 14, 23, 2, 28, 562, DateTimeKind.Local).AddTicks(4318) });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: 2048,
                columns: new[] { "ConcurrencyStamp", "CreatedTime", "LastUpdatedTime", "RefreshTokenCreateTime" },
                values: new object[] { "ebbc52b4-8d58-4dd0-975c-18ef53e74978", new DateTime(2024, 8, 14, 19, 2, 28, 562, DateTimeKind.Utc).AddTicks(4357), new DateTime(2024, 8, 14, 19, 2, 28, 562, DateTimeKind.Utc).AddTicks(4357), new DateTime(2024, 8, 14, 23, 2, 28, 562, DateTimeKind.Local).AddTicks(4351) });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: 2049,
                columns: new[] { "ConcurrencyStamp", "CreatedTime", "LastUpdatedTime", "RefreshTokenCreateTime" },
                values: new object[] { "be9c9889-ee88-4852-bf8e-8817fb0c38f7", new DateTime(2024, 8, 14, 19, 2, 28, 562, DateTimeKind.Utc).AddTicks(4371), new DateTime(2024, 8, 14, 19, 2, 28, 562, DateTimeKind.Utc).AddTicks(4372), new DateTime(2024, 8, 14, 23, 2, 28, 562, DateTimeKind.Local).AddTicks(4366) });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: 2050,
                columns: new[] { "ConcurrencyStamp", "CreatedTime", "LastUpdatedTime", "RefreshTokenCreateTime" },
                values: new object[] { "63b9c132-e7a4-4dfe-b73b-d6c8f3812b97", new DateTime(2024, 8, 14, 19, 2, 28, 562, DateTimeKind.Utc).AddTicks(4386), new DateTime(2024, 8, 14, 19, 2, 28, 562, DateTimeKind.Utc).AddTicks(4386), new DateTime(2024, 8, 14, 23, 2, 28, 562, DateTimeKind.Local).AddTicks(4380) });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: 2051,
                columns: new[] { "ConcurrencyStamp", "CreatedTime", "LastUpdatedTime", "RefreshTokenCreateTime" },
                values: new object[] { "9f03caa9-a0c1-4879-9ae9-5742a42ac453", new DateTime(2024, 8, 14, 19, 2, 28, 562, DateTimeKind.Utc).AddTicks(4401), new DateTime(2024, 8, 14, 19, 2, 28, 562, DateTimeKind.Utc).AddTicks(4401), new DateTime(2024, 8, 14, 23, 2, 28, 562, DateTimeKind.Local).AddTicks(4395) });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: 2052,
                columns: new[] { "ConcurrencyStamp", "CreatedTime", "LastUpdatedTime", "RefreshTokenCreateTime" },
                values: new object[] { "02e064ee-b108-474f-b80f-553ba6f283ad", new DateTime(2024, 8, 14, 19, 2, 28, 562, DateTimeKind.Utc).AddTicks(4419), new DateTime(2024, 8, 14, 19, 2, 28, 562, DateTimeKind.Utc).AddTicks(4419), new DateTime(2024, 8, 14, 23, 2, 28, 562, DateTimeKind.Local).AddTicks(4410) });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: 2053,
                columns: new[] { "ConcurrencyStamp", "CreatedTime", "LastUpdatedTime", "RefreshTokenCreateTime" },
                values: new object[] { "63a6faae-2107-4c90-a51d-208cd953cc03", new DateTime(2024, 8, 14, 19, 2, 28, 562, DateTimeKind.Utc).AddTicks(4433), new DateTime(2024, 8, 14, 19, 2, 28, 562, DateTimeKind.Utc).AddTicks(4433), new DateTime(2024, 8, 14, 23, 2, 28, 562, DateTimeKind.Local).AddTicks(4428) });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: 2054,
                columns: new[] { "ConcurrencyStamp", "CreatedTime", "LastUpdatedTime", "RefreshTokenCreateTime" },
                values: new object[] { "c519a3bd-38b0-43b4-b3ce-5a1d193bdef9", new DateTime(2024, 8, 14, 19, 2, 28, 562, DateTimeKind.Utc).AddTicks(4447), new DateTime(2024, 8, 14, 19, 2, 28, 562, DateTimeKind.Utc).AddTicks(4448), new DateTime(2024, 8, 14, 23, 2, 28, 562, DateTimeKind.Local).AddTicks(4442) });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: 2055,
                columns: new[] { "ConcurrencyStamp", "CreatedTime", "LastUpdatedTime", "RefreshTokenCreateTime" },
                values: new object[] { "7cd12d80-1877-4be7-a7de-9dbb4c9be158", new DateTime(2024, 8, 14, 19, 2, 28, 562, DateTimeKind.Utc).AddTicks(4461), new DateTime(2024, 8, 14, 19, 2, 28, 562, DateTimeKind.Utc).AddTicks(4462), new DateTime(2024, 8, 14, 23, 2, 28, 562, DateTimeKind.Local).AddTicks(4456) });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: 2056,
                columns: new[] { "ConcurrencyStamp", "CreatedTime", "LastUpdatedTime", "RefreshTokenCreateTime" },
                values: new object[] { "516477b9-fb47-46b3-bb60-1e11548a36f7", new DateTime(2024, 8, 14, 19, 2, 28, 562, DateTimeKind.Utc).AddTicks(4476), new DateTime(2024, 8, 14, 19, 2, 28, 562, DateTimeKind.Utc).AddTicks(4477), new DateTime(2024, 8, 14, 23, 2, 28, 562, DateTimeKind.Local).AddTicks(4471) });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: 2057,
                columns: new[] { "ConcurrencyStamp", "CreatedTime", "LastUpdatedTime", "RefreshTokenCreateTime" },
                values: new object[] { "f8d2b079-35c7-4470-8bef-6bd0ce8d91cb", new DateTime(2024, 8, 14, 19, 2, 28, 562, DateTimeKind.Utc).AddTicks(4549), new DateTime(2024, 8, 14, 19, 2, 28, 562, DateTimeKind.Utc).AddTicks(4550), new DateTime(2024, 8, 14, 23, 2, 28, 562, DateTimeKind.Local).AddTicks(4544) });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: 2058,
                columns: new[] { "ConcurrencyStamp", "CreatedTime", "LastUpdatedTime", "RefreshTokenCreateTime" },
                values: new object[] { "38621237-11f8-496c-b8ed-73cbab9132aa", new DateTime(2024, 8, 14, 19, 2, 28, 562, DateTimeKind.Utc).AddTicks(4564), new DateTime(2024, 8, 14, 19, 2, 28, 562, DateTimeKind.Utc).AddTicks(4565), new DateTime(2024, 8, 14, 23, 2, 28, 562, DateTimeKind.Local).AddTicks(4559) });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: 2059,
                columns: new[] { "ConcurrencyStamp", "CreatedTime", "LastUpdatedTime", "RefreshTokenCreateTime" },
                values: new object[] { "1a7f64aa-aaa6-4902-8560-87aae39f30a8", new DateTime(2024, 8, 14, 19, 2, 28, 562, DateTimeKind.Utc).AddTicks(4579), new DateTime(2024, 8, 14, 19, 2, 28, 562, DateTimeKind.Utc).AddTicks(4579), new DateTime(2024, 8, 14, 23, 2, 28, 562, DateTimeKind.Local).AddTicks(4573) });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: 2060,
                columns: new[] { "ConcurrencyStamp", "CreatedTime", "LastUpdatedTime", "RefreshTokenCreateTime" },
                values: new object[] { "b390502a-0ebc-4915-805a-8d717b865d4f", new DateTime(2024, 8, 14, 19, 2, 28, 562, DateTimeKind.Utc).AddTicks(4597), new DateTime(2024, 8, 14, 19, 2, 28, 562, DateTimeKind.Utc).AddTicks(4598), new DateTime(2024, 8, 14, 23, 2, 28, 562, DateTimeKind.Local).AddTicks(4589) });
        }
    }
}
