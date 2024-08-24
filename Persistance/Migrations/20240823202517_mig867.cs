using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Persistance.Migrations
{
    /// <inheritdoc />
    public partial class mig867 : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<string>(
                name: "ShelterName",
                table: "Shelters",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: 2001,
                columns: new[] { "ConcurrencyStamp", "CreatedTime", "LastUpdatedTime", "RefreshTokenCreateTime" },
                values: new object[] { "e93f1196-b956-4e88-90ee-d19bcfa9c6eb", new DateTime(2024, 8, 23, 20, 25, 15, 476, DateTimeKind.Utc).AddTicks(6715), new DateTime(2024, 8, 23, 20, 25, 15, 476, DateTimeKind.Utc).AddTicks(6718), new DateTime(2024, 8, 23, 20, 25, 15, 476, DateTimeKind.Utc).AddTicks(6640) });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: 2002,
                columns: new[] { "ConcurrencyStamp", "CreatedTime", "LastUpdatedTime", "RefreshTokenCreateTime" },
                values: new object[] { "c75b55a2-3769-4b7b-a9c6-f5721729a1bc", new DateTime(2024, 8, 23, 20, 25, 15, 476, DateTimeKind.Utc).AddTicks(6789), new DateTime(2024, 8, 23, 20, 25, 15, 476, DateTimeKind.Utc).AddTicks(6789), new DateTime(2024, 8, 23, 20, 25, 15, 476, DateTimeKind.Utc).AddTicks(6784) });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: 2003,
                columns: new[] { "ConcurrencyStamp", "CreatedTime", "LastUpdatedTime", "RefreshTokenCreateTime" },
                values: new object[] { "64bd72b3-3ff3-48f9-81d5-0570d12c7f7f", new DateTime(2024, 8, 23, 20, 25, 15, 476, DateTimeKind.Utc).AddTicks(6815), new DateTime(2024, 8, 23, 20, 25, 15, 476, DateTimeKind.Utc).AddTicks(6816), new DateTime(2024, 8, 23, 20, 25, 15, 476, DateTimeKind.Utc).AddTicks(6801) });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: 2004,
                columns: new[] { "ConcurrencyStamp", "CreatedTime", "LastUpdatedTime", "RefreshTokenCreateTime" },
                values: new object[] { "44c9d4b3-ddcd-48f1-a9c1-6b5302f74e55", new DateTime(2024, 8, 23, 20, 25, 15, 476, DateTimeKind.Utc).AddTicks(6835), new DateTime(2024, 8, 23, 20, 25, 15, 476, DateTimeKind.Utc).AddTicks(6835), new DateTime(2024, 8, 23, 20, 25, 15, 476, DateTimeKind.Utc).AddTicks(6831) });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: 2005,
                columns: new[] { "ConcurrencyStamp", "CreatedTime", "LastUpdatedTime", "RefreshTokenCreateTime" },
                values: new object[] { "cd34904e-f27b-4031-bcac-ee03ad252082", new DateTime(2024, 8, 23, 20, 25, 15, 476, DateTimeKind.Utc).AddTicks(6848), new DateTime(2024, 8, 23, 20, 25, 15, 476, DateTimeKind.Utc).AddTicks(6848), new DateTime(2024, 8, 23, 20, 25, 15, 476, DateTimeKind.Utc).AddTicks(6844) });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: 2006,
                columns: new[] { "ConcurrencyStamp", "CreatedTime", "LastUpdatedTime", "RefreshTokenCreateTime" },
                values: new object[] { "0817ec84-0a48-4f26-80aa-7736fde9aa1b", new DateTime(2024, 8, 23, 20, 25, 15, 476, DateTimeKind.Utc).AddTicks(6971), new DateTime(2024, 8, 23, 20, 25, 15, 476, DateTimeKind.Utc).AddTicks(6972), new DateTime(2024, 8, 23, 20, 25, 15, 476, DateTimeKind.Utc).AddTicks(6966) });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: 2007,
                columns: new[] { "ConcurrencyStamp", "CreatedTime", "LastUpdatedTime", "RefreshTokenCreateTime" },
                values: new object[] { "7c41242b-9d32-4211-9a60-8b3b1550296f", new DateTime(2024, 8, 23, 20, 25, 15, 476, DateTimeKind.Utc).AddTicks(6985), new DateTime(2024, 8, 23, 20, 25, 15, 476, DateTimeKind.Utc).AddTicks(6986), new DateTime(2024, 8, 23, 20, 25, 15, 476, DateTimeKind.Utc).AddTicks(6982) });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: 2008,
                columns: new[] { "ConcurrencyStamp", "CreatedTime", "LastUpdatedTime", "RefreshTokenCreateTime" },
                values: new object[] { "51eb591e-4bc5-4688-877a-b92c7ad60213", new DateTime(2024, 8, 23, 20, 25, 15, 476, DateTimeKind.Utc).AddTicks(7003), new DateTime(2024, 8, 23, 20, 25, 15, 476, DateTimeKind.Utc).AddTicks(7003), new DateTime(2024, 8, 23, 20, 25, 15, 476, DateTimeKind.Utc).AddTicks(6995) });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: 2009,
                columns: new[] { "ConcurrencyStamp", "CreatedTime", "LastUpdatedTime", "RefreshTokenCreateTime" },
                values: new object[] { "f2f81bbc-b7ce-401b-bdbb-777f83fa9476", new DateTime(2024, 8, 23, 20, 25, 15, 476, DateTimeKind.Utc).AddTicks(7017), new DateTime(2024, 8, 23, 20, 25, 15, 476, DateTimeKind.Utc).AddTicks(7018), new DateTime(2024, 8, 23, 20, 25, 15, 476, DateTimeKind.Utc).AddTicks(7013) });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: 2010,
                columns: new[] { "ConcurrencyStamp", "CreatedTime", "LastUpdatedTime", "RefreshTokenCreateTime" },
                values: new object[] { "18c5830b-e60a-41fe-814e-51e2a23d63c4", new DateTime(2024, 8, 23, 20, 25, 15, 476, DateTimeKind.Utc).AddTicks(7033), new DateTime(2024, 8, 23, 20, 25, 15, 476, DateTimeKind.Utc).AddTicks(7033), new DateTime(2024, 8, 23, 20, 25, 15, 476, DateTimeKind.Utc).AddTicks(7029) });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: 2011,
                columns: new[] { "ConcurrencyStamp", "CreatedTime", "LastUpdatedTime", "RefreshTokenCreateTime" },
                values: new object[] { "74ce9d78-e94c-4833-8f34-b83697238085", new DateTime(2024, 8, 23, 20, 25, 15, 476, DateTimeKind.Utc).AddTicks(7054), new DateTime(2024, 8, 23, 20, 25, 15, 476, DateTimeKind.Utc).AddTicks(7054), new DateTime(2024, 8, 23, 20, 25, 15, 476, DateTimeKind.Utc).AddTicks(7046) });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: 2012,
                columns: new[] { "ConcurrencyStamp", "CreatedTime", "LastUpdatedTime", "RefreshTokenCreateTime" },
                values: new object[] { "b7eb8767-2752-44b6-add1-81db3c4b99dc", new DateTime(2024, 8, 23, 20, 25, 15, 476, DateTimeKind.Utc).AddTicks(7067), new DateTime(2024, 8, 23, 20, 25, 15, 476, DateTimeKind.Utc).AddTicks(7068), new DateTime(2024, 8, 23, 20, 25, 15, 476, DateTimeKind.Utc).AddTicks(7064) });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: 2013,
                columns: new[] { "ConcurrencyStamp", "CreatedTime", "LastUpdatedTime", "RefreshTokenCreateTime" },
                values: new object[] { "7d4375b4-95cb-44ed-bd45-71342800596c", new DateTime(2024, 8, 23, 20, 25, 15, 476, DateTimeKind.Utc).AddTicks(7081), new DateTime(2024, 8, 23, 20, 25, 15, 476, DateTimeKind.Utc).AddTicks(7081), new DateTime(2024, 8, 23, 20, 25, 15, 476, DateTimeKind.Utc).AddTicks(7077) });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: 2014,
                columns: new[] { "ConcurrencyStamp", "CreatedTime", "LastUpdatedTime", "RefreshTokenCreateTime" },
                values: new object[] { "449064ba-2f66-4643-94ad-cc48a22faa95", new DateTime(2024, 8, 23, 20, 25, 15, 476, DateTimeKind.Utc).AddTicks(7094), new DateTime(2024, 8, 23, 20, 25, 15, 476, DateTimeKind.Utc).AddTicks(7094), new DateTime(2024, 8, 23, 20, 25, 15, 476, DateTimeKind.Utc).AddTicks(7091) });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: 2015,
                columns: new[] { "ConcurrencyStamp", "CreatedTime", "LastUpdatedTime", "RefreshTokenCreateTime" },
                values: new object[] { "1efd119f-32ac-4006-b2ab-3eb9d7897800", new DateTime(2024, 8, 23, 20, 25, 15, 476, DateTimeKind.Utc).AddTicks(7152), new DateTime(2024, 8, 23, 20, 25, 15, 476, DateTimeKind.Utc).AddTicks(7153), new DateTime(2024, 8, 23, 20, 25, 15, 476, DateTimeKind.Utc).AddTicks(7139) });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: 2016,
                columns: new[] { "ConcurrencyStamp", "CreatedTime", "LastUpdatedTime", "RefreshTokenCreateTime" },
                values: new object[] { "a282df2f-99ca-45f7-a7e5-494aff183522", new DateTime(2024, 8, 23, 20, 25, 15, 476, DateTimeKind.Utc).AddTicks(7166), new DateTime(2024, 8, 23, 20, 25, 15, 476, DateTimeKind.Utc).AddTicks(7167), new DateTime(2024, 8, 23, 20, 25, 15, 476, DateTimeKind.Utc).AddTicks(7162) });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: 2017,
                columns: new[] { "ConcurrencyStamp", "CreatedTime", "LastUpdatedTime", "RefreshTokenCreateTime" },
                values: new object[] { "33b15b15-195d-4de0-ad4d-00a1f0f71ed7", new DateTime(2024, 8, 23, 20, 25, 15, 476, DateTimeKind.Utc).AddTicks(7179), new DateTime(2024, 8, 23, 20, 25, 15, 476, DateTimeKind.Utc).AddTicks(7180), new DateTime(2024, 8, 23, 20, 25, 15, 476, DateTimeKind.Utc).AddTicks(7176) });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: 2018,
                columns: new[] { "ConcurrencyStamp", "CreatedTime", "LastUpdatedTime", "RefreshTokenCreateTime" },
                values: new object[] { "75f0d880-146c-4b4e-8f22-89d888b09217", new DateTime(2024, 8, 23, 20, 25, 15, 476, DateTimeKind.Utc).AddTicks(7194), new DateTime(2024, 8, 23, 20, 25, 15, 476, DateTimeKind.Utc).AddTicks(7194), new DateTime(2024, 8, 23, 20, 25, 15, 476, DateTimeKind.Utc).AddTicks(7190) });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: 2019,
                columns: new[] { "ConcurrencyStamp", "CreatedTime", "LastUpdatedTime", "RefreshTokenCreateTime" },
                values: new object[] { "55b94c6f-c354-471e-8804-97d9ea4d279c", new DateTime(2024, 8, 23, 20, 25, 15, 476, DateTimeKind.Utc).AddTicks(7210), new DateTime(2024, 8, 23, 20, 25, 15, 476, DateTimeKind.Utc).AddTicks(7210), new DateTime(2024, 8, 23, 20, 25, 15, 476, DateTimeKind.Utc).AddTicks(7204) });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: 2020,
                columns: new[] { "ConcurrencyStamp", "CreatedTime", "LastUpdatedTime", "RefreshTokenCreateTime" },
                values: new object[] { "0e5a9745-9c52-446c-a23c-9ccdedb240b6", new DateTime(2024, 8, 23, 20, 25, 15, 476, DateTimeKind.Utc).AddTicks(7223), new DateTime(2024, 8, 23, 20, 25, 15, 476, DateTimeKind.Utc).AddTicks(7223), new DateTime(2024, 8, 23, 20, 25, 15, 476, DateTimeKind.Utc).AddTicks(7220) });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: 2021,
                columns: new[] { "ConcurrencyStamp", "CreatedTime", "LastUpdatedTime", "RefreshTokenCreateTime" },
                values: new object[] { "4aae2a71-74f0-43ff-8b2f-0a898a9ef7ef", new DateTime(2024, 8, 23, 20, 25, 15, 476, DateTimeKind.Utc).AddTicks(7235), new DateTime(2024, 8, 23, 20, 25, 15, 476, DateTimeKind.Utc).AddTicks(7236), new DateTime(2024, 8, 23, 20, 25, 15, 476, DateTimeKind.Utc).AddTicks(7232) });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: 2022,
                columns: new[] { "ConcurrencyStamp", "CreatedTime", "LastUpdatedTime", "RefreshTokenCreateTime" },
                values: new object[] { "ef645ed7-a204-4778-8093-2a11286d2323", new DateTime(2024, 8, 23, 20, 25, 15, 476, DateTimeKind.Utc).AddTicks(7257), new DateTime(2024, 8, 23, 20, 25, 15, 476, DateTimeKind.Utc).AddTicks(7257), new DateTime(2024, 8, 23, 20, 25, 15, 476, DateTimeKind.Utc).AddTicks(7254) });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: 2023,
                columns: new[] { "ConcurrencyStamp", "CreatedTime", "LastUpdatedTime", "RefreshTokenCreateTime" },
                values: new object[] { "54f7f0bc-baa6-4c95-8f14-2f2c33b96df7", new DateTime(2024, 8, 23, 20, 25, 15, 476, DateTimeKind.Utc).AddTicks(7271), new DateTime(2024, 8, 23, 20, 25, 15, 476, DateTimeKind.Utc).AddTicks(7271), new DateTime(2024, 8, 23, 20, 25, 15, 476, DateTimeKind.Utc).AddTicks(7267) });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: 2024,
                columns: new[] { "ConcurrencyStamp", "CreatedTime", "LastUpdatedTime", "RefreshTokenCreateTime" },
                values: new object[] { "0ae9bf7a-18d1-4b24-b00e-fb1295b7a9b2", new DateTime(2024, 8, 23, 20, 25, 15, 476, DateTimeKind.Utc).AddTicks(7318), new DateTime(2024, 8, 23, 20, 25, 15, 476, DateTimeKind.Utc).AddTicks(7319), new DateTime(2024, 8, 23, 20, 25, 15, 476, DateTimeKind.Utc).AddTicks(7281) });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: 2025,
                columns: new[] { "ConcurrencyStamp", "CreatedTime", "LastUpdatedTime", "RefreshTokenCreateTime" },
                values: new object[] { "8badf94b-ca88-409f-8508-15c5e673c5eb", new DateTime(2024, 8, 23, 20, 25, 15, 476, DateTimeKind.Utc).AddTicks(7334), new DateTime(2024, 8, 23, 20, 25, 15, 476, DateTimeKind.Utc).AddTicks(7334), new DateTime(2024, 8, 23, 20, 25, 15, 476, DateTimeKind.Utc).AddTicks(7330) });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: 2026,
                columns: new[] { "ConcurrencyStamp", "CreatedTime", "LastUpdatedTime", "RefreshTokenCreateTime" },
                values: new object[] { "9ecc6384-798a-4704-b590-f89c63269a55", new DateTime(2024, 8, 23, 20, 25, 15, 476, DateTimeKind.Utc).AddTicks(7348), new DateTime(2024, 8, 23, 20, 25, 15, 476, DateTimeKind.Utc).AddTicks(7349), new DateTime(2024, 8, 23, 20, 25, 15, 476, DateTimeKind.Utc).AddTicks(7344) });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: 2027,
                columns: new[] { "ConcurrencyStamp", "CreatedTime", "LastUpdatedTime", "RefreshTokenCreateTime" },
                values: new object[] { "871a0132-57a4-445c-a3d4-581d23293ae9", new DateTime(2024, 8, 23, 20, 25, 15, 476, DateTimeKind.Utc).AddTicks(7365), new DateTime(2024, 8, 23, 20, 25, 15, 476, DateTimeKind.Utc).AddTicks(7365), new DateTime(2024, 8, 23, 20, 25, 15, 476, DateTimeKind.Utc).AddTicks(7358) });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: 2028,
                columns: new[] { "ConcurrencyStamp", "CreatedTime", "LastUpdatedTime", "RefreshTokenCreateTime" },
                values: new object[] { "e1a64e24-073c-40b3-9fda-8a7de6d8fffa", new DateTime(2024, 8, 23, 20, 25, 15, 476, DateTimeKind.Utc).AddTicks(7379), new DateTime(2024, 8, 23, 20, 25, 15, 476, DateTimeKind.Utc).AddTicks(7380), new DateTime(2024, 8, 23, 20, 25, 15, 476, DateTimeKind.Utc).AddTicks(7376) });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: 2029,
                columns: new[] { "ConcurrencyStamp", "CreatedTime", "LastUpdatedTime", "RefreshTokenCreateTime" },
                values: new object[] { "b9bd5f8b-2187-4652-9337-6667a441f802", new DateTime(2024, 8, 23, 20, 25, 15, 476, DateTimeKind.Utc).AddTicks(7394), new DateTime(2024, 8, 23, 20, 25, 15, 476, DateTimeKind.Utc).AddTicks(7394), new DateTime(2024, 8, 23, 20, 25, 15, 476, DateTimeKind.Utc).AddTicks(7390) });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: 2030,
                columns: new[] { "ConcurrencyStamp", "CreatedTime", "LastUpdatedTime", "RefreshTokenCreateTime" },
                values: new object[] { "cb8292e2-9cca-4b73-942b-5f915ac3d040", new DateTime(2024, 8, 23, 20, 25, 15, 476, DateTimeKind.Utc).AddTicks(7481), new DateTime(2024, 8, 23, 20, 25, 15, 476, DateTimeKind.Utc).AddTicks(7481), new DateTime(2024, 8, 23, 20, 25, 15, 476, DateTimeKind.Utc).AddTicks(7405) });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: 2031,
                columns: new[] { "ConcurrencyStamp", "CreatedTime", "LastUpdatedTime", "RefreshTokenCreateTime" },
                values: new object[] { "a0767fa6-10f0-4b50-af9b-639d6cb23125", new DateTime(2024, 8, 23, 20, 25, 15, 476, DateTimeKind.Utc).AddTicks(7518), new DateTime(2024, 8, 23, 20, 25, 15, 476, DateTimeKind.Utc).AddTicks(7518), new DateTime(2024, 8, 23, 20, 25, 15, 476, DateTimeKind.Utc).AddTicks(7513) });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: 2032,
                columns: new[] { "ConcurrencyStamp", "CreatedTime", "LastUpdatedTime", "RefreshTokenCreateTime" },
                values: new object[] { "278a4496-1924-49a6-8da9-faa5f522bf95", new DateTime(2024, 8, 23, 20, 25, 15, 476, DateTimeKind.Utc).AddTicks(7532), new DateTime(2024, 8, 23, 20, 25, 15, 476, DateTimeKind.Utc).AddTicks(7532), new DateTime(2024, 8, 23, 20, 25, 15, 476, DateTimeKind.Utc).AddTicks(7528) });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: 2033,
                columns: new[] { "ConcurrencyStamp", "CreatedTime", "LastUpdatedTime", "RefreshTokenCreateTime" },
                values: new object[] { "7c620426-5d18-4531-b6fe-027333514683", new DateTime(2024, 8, 23, 20, 25, 15, 476, DateTimeKind.Utc).AddTicks(7566), new DateTime(2024, 8, 23, 20, 25, 15, 476, DateTimeKind.Utc).AddTicks(7566), new DateTime(2024, 8, 23, 20, 25, 15, 476, DateTimeKind.Utc).AddTicks(7562) });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: 2034,
                columns: new[] { "ConcurrencyStamp", "CreatedTime", "LastUpdatedTime", "RefreshTokenCreateTime" },
                values: new object[] { "fd7e846e-11a1-488c-81fa-878a77890124", new DateTime(2024, 8, 23, 20, 25, 15, 476, DateTimeKind.Utc).AddTicks(7584), new DateTime(2024, 8, 23, 20, 25, 15, 476, DateTimeKind.Utc).AddTicks(7584), new DateTime(2024, 8, 23, 20, 25, 15, 476, DateTimeKind.Utc).AddTicks(7580) });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: 2035,
                columns: new[] { "ConcurrencyStamp", "CreatedTime", "LastUpdatedTime", "RefreshTokenCreateTime" },
                values: new object[] { "f702b62c-43ab-475f-8f07-14313ecc8988", new DateTime(2024, 8, 23, 20, 25, 15, 476, DateTimeKind.Utc).AddTicks(7601), new DateTime(2024, 8, 23, 20, 25, 15, 476, DateTimeKind.Utc).AddTicks(7602), new DateTime(2024, 8, 23, 20, 25, 15, 476, DateTimeKind.Utc).AddTicks(7595) });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: 2036,
                columns: new[] { "ConcurrencyStamp", "CreatedTime", "LastUpdatedTime", "RefreshTokenCreateTime" },
                values: new object[] { "0eaf0954-62c7-46de-af15-f0b87b3441c8", new DateTime(2024, 8, 23, 20, 25, 15, 476, DateTimeKind.Utc).AddTicks(7615), new DateTime(2024, 8, 23, 20, 25, 15, 476, DateTimeKind.Utc).AddTicks(7616), new DateTime(2024, 8, 23, 20, 25, 15, 476, DateTimeKind.Utc).AddTicks(7612) });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: 2037,
                columns: new[] { "ConcurrencyStamp", "CreatedTime", "LastUpdatedTime", "RefreshTokenCreateTime" },
                values: new object[] { "5af367e5-ed74-4f1e-82f4-d2e8a5535770", new DateTime(2024, 8, 23, 20, 25, 15, 476, DateTimeKind.Utc).AddTicks(7629), new DateTime(2024, 8, 23, 20, 25, 15, 476, DateTimeKind.Utc).AddTicks(7629), new DateTime(2024, 8, 23, 20, 25, 15, 476, DateTimeKind.Utc).AddTicks(7626) });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: 2038,
                columns: new[] { "ConcurrencyStamp", "CreatedTime", "LastUpdatedTime", "RefreshTokenCreateTime" },
                values: new object[] { "af086814-f663-4ceb-bb49-d40f5202c13c", new DateTime(2024, 8, 23, 20, 25, 15, 476, DateTimeKind.Utc).AddTicks(7643), new DateTime(2024, 8, 23, 20, 25, 15, 476, DateTimeKind.Utc).AddTicks(7644), new DateTime(2024, 8, 23, 20, 25, 15, 476, DateTimeKind.Utc).AddTicks(7640) });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: 2039,
                columns: new[] { "ConcurrencyStamp", "CreatedTime", "LastUpdatedTime", "RefreshTokenCreateTime" },
                values: new object[] { "dd9c3e18-13b2-41d1-a601-64144ccfd850", new DateTime(2024, 8, 23, 20, 25, 15, 476, DateTimeKind.Utc).AddTicks(7657), new DateTime(2024, 8, 23, 20, 25, 15, 476, DateTimeKind.Utc).AddTicks(7658), new DateTime(2024, 8, 23, 20, 25, 15, 476, DateTimeKind.Utc).AddTicks(7654) });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: 2040,
                columns: new[] { "ConcurrencyStamp", "CreatedTime", "LastUpdatedTime", "RefreshTokenCreateTime" },
                values: new object[] { "5cd42e61-f810-4e1f-bd6e-4355872074c9", new DateTime(2024, 8, 23, 20, 25, 15, 476, DateTimeKind.Utc).AddTicks(7671), new DateTime(2024, 8, 23, 20, 25, 15, 476, DateTimeKind.Utc).AddTicks(7671), new DateTime(2024, 8, 23, 20, 25, 15, 476, DateTimeKind.Utc).AddTicks(7668) });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: 2041,
                columns: new[] { "ConcurrencyStamp", "CreatedTime", "LastUpdatedTime", "RefreshTokenCreateTime" },
                values: new object[] { "2b0d48f3-61b6-4b87-8a85-101f25809b69", new DateTime(2024, 8, 23, 20, 25, 15, 476, DateTimeKind.Utc).AddTicks(7748), new DateTime(2024, 8, 23, 20, 25, 15, 476, DateTimeKind.Utc).AddTicks(7748), new DateTime(2024, 8, 23, 20, 25, 15, 476, DateTimeKind.Utc).AddTicks(7743) });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: 2042,
                columns: new[] { "ConcurrencyStamp", "CreatedTime", "LastUpdatedTime", "RefreshTokenCreateTime" },
                values: new object[] { "a770f582-4830-49a7-adc3-a0cd4d1aa6df", new DateTime(2024, 8, 23, 20, 25, 15, 476, DateTimeKind.Utc).AddTicks(7770), new DateTime(2024, 8, 23, 20, 25, 15, 476, DateTimeKind.Utc).AddTicks(7770), new DateTime(2024, 8, 23, 20, 25, 15, 476, DateTimeKind.Utc).AddTicks(7766) });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: 2043,
                columns: new[] { "ConcurrencyStamp", "CreatedTime", "LastUpdatedTime", "RefreshTokenCreateTime" },
                values: new object[] { "db910f0b-6cbd-485e-ada5-634b9e8e853f", new DateTime(2024, 8, 23, 20, 25, 15, 476, DateTimeKind.Utc).AddTicks(7787), new DateTime(2024, 8, 23, 20, 25, 15, 476, DateTimeKind.Utc).AddTicks(7788), new DateTime(2024, 8, 23, 20, 25, 15, 476, DateTimeKind.Utc).AddTicks(7781) });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: 2044,
                columns: new[] { "ConcurrencyStamp", "CreatedTime", "LastUpdatedTime", "RefreshTokenCreateTime" },
                values: new object[] { "e75227e3-27df-444d-9dcd-6ee48cd9a76b", new DateTime(2024, 8, 23, 20, 25, 15, 476, DateTimeKind.Utc).AddTicks(7802), new DateTime(2024, 8, 23, 20, 25, 15, 476, DateTimeKind.Utc).AddTicks(7802), new DateTime(2024, 8, 23, 20, 25, 15, 476, DateTimeKind.Utc).AddTicks(7798) });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: 2045,
                columns: new[] { "ConcurrencyStamp", "CreatedTime", "LastUpdatedTime", "RefreshTokenCreateTime" },
                values: new object[] { "682446ff-e52d-4db2-b9eb-106ead7b9149", new DateTime(2024, 8, 23, 20, 25, 15, 476, DateTimeKind.Utc).AddTicks(7816), new DateTime(2024, 8, 23, 20, 25, 15, 476, DateTimeKind.Utc).AddTicks(7817), new DateTime(2024, 8, 23, 20, 25, 15, 476, DateTimeKind.Utc).AddTicks(7813) });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: 2046,
                columns: new[] { "ConcurrencyStamp", "CreatedTime", "LastUpdatedTime", "RefreshTokenCreateTime" },
                values: new object[] { "96635f89-ff4a-4664-8a40-ff652d250b1f", new DateTime(2024, 8, 23, 20, 25, 15, 476, DateTimeKind.Utc).AddTicks(7829), new DateTime(2024, 8, 23, 20, 25, 15, 476, DateTimeKind.Utc).AddTicks(7830), new DateTime(2024, 8, 23, 20, 25, 15, 476, DateTimeKind.Utc).AddTicks(7826) });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: 2047,
                columns: new[] { "ConcurrencyStamp", "CreatedTime", "LastUpdatedTime", "RefreshTokenCreateTime" },
                values: new object[] { "029b899c-43c1-4d89-b3e7-fe89eda2e02a", new DateTime(2024, 8, 23, 20, 25, 15, 476, DateTimeKind.Utc).AddTicks(7844), new DateTime(2024, 8, 23, 20, 25, 15, 476, DateTimeKind.Utc).AddTicks(7844), new DateTime(2024, 8, 23, 20, 25, 15, 476, DateTimeKind.Utc).AddTicks(7840) });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: 2048,
                columns: new[] { "ConcurrencyStamp", "CreatedTime", "LastUpdatedTime", "RefreshTokenCreateTime" },
                values: new object[] { "0a5183ab-8184-4e46-840b-76e671ebae3b", new DateTime(2024, 8, 23, 20, 25, 15, 476, DateTimeKind.Utc).AddTicks(7857), new DateTime(2024, 8, 23, 20, 25, 15, 476, DateTimeKind.Utc).AddTicks(7858), new DateTime(2024, 8, 23, 20, 25, 15, 476, DateTimeKind.Utc).AddTicks(7854) });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: 2049,
                columns: new[] { "ConcurrencyStamp", "CreatedTime", "LastUpdatedTime", "RefreshTokenCreateTime" },
                values: new object[] { "c78add89-1f5b-4ee0-a749-9ed67209e17d", new DateTime(2024, 8, 23, 20, 25, 15, 476, DateTimeKind.Utc).AddTicks(7870), new DateTime(2024, 8, 23, 20, 25, 15, 476, DateTimeKind.Utc).AddTicks(7871), new DateTime(2024, 8, 23, 20, 25, 15, 476, DateTimeKind.Utc).AddTicks(7867) });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: 2050,
                columns: new[] { "ConcurrencyStamp", "CreatedTime", "LastUpdatedTime", "RefreshTokenCreateTime" },
                values: new object[] { "68ca104c-2500-46eb-aebd-d4aff79867ed", new DateTime(2024, 8, 23, 20, 25, 15, 476, DateTimeKind.Utc).AddTicks(7884), new DateTime(2024, 8, 23, 20, 25, 15, 476, DateTimeKind.Utc).AddTicks(7884), new DateTime(2024, 8, 23, 20, 25, 15, 476, DateTimeKind.Utc).AddTicks(7880) });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: 2051,
                columns: new[] { "ConcurrencyStamp", "CreatedTime", "LastUpdatedTime", "RefreshTokenCreateTime" },
                values: new object[] { "13ad63ad-839f-41aa-80e3-935cb95acb55", new DateTime(2024, 8, 23, 20, 25, 15, 476, DateTimeKind.Utc).AddTicks(7942), new DateTime(2024, 8, 23, 20, 25, 15, 476, DateTimeKind.Utc).AddTicks(7942), new DateTime(2024, 8, 23, 20, 25, 15, 476, DateTimeKind.Utc).AddTicks(7893) });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: 2052,
                columns: new[] { "ConcurrencyStamp", "CreatedTime", "LastUpdatedTime", "RefreshTokenCreateTime" },
                values: new object[] { "3eeb7abf-9365-4bc1-a68f-15157be1e3d1", new DateTime(2024, 8, 23, 20, 25, 15, 476, DateTimeKind.Utc).AddTicks(7956), new DateTime(2024, 8, 23, 20, 25, 15, 476, DateTimeKind.Utc).AddTicks(7956), new DateTime(2024, 8, 23, 20, 25, 15, 476, DateTimeKind.Utc).AddTicks(7952) });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: 2053,
                columns: new[] { "ConcurrencyStamp", "CreatedTime", "LastUpdatedTime", "RefreshTokenCreateTime" },
                values: new object[] { "01f6f661-dc24-4f32-b3ed-31fcf9113e0c", new DateTime(2024, 8, 23, 20, 25, 15, 476, DateTimeKind.Utc).AddTicks(7969), new DateTime(2024, 8, 23, 20, 25, 15, 476, DateTimeKind.Utc).AddTicks(7969), new DateTime(2024, 8, 23, 20, 25, 15, 476, DateTimeKind.Utc).AddTicks(7965) });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: 2054,
                columns: new[] { "ConcurrencyStamp", "CreatedTime", "LastUpdatedTime", "RefreshTokenCreateTime" },
                values: new object[] { "e02de188-595a-41e7-89c3-e69473938ce9", new DateTime(2024, 8, 23, 20, 25, 15, 476, DateTimeKind.Utc).AddTicks(7981), new DateTime(2024, 8, 23, 20, 25, 15, 476, DateTimeKind.Utc).AddTicks(7982), new DateTime(2024, 8, 23, 20, 25, 15, 476, DateTimeKind.Utc).AddTicks(7978) });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: 2055,
                columns: new[] { "ConcurrencyStamp", "CreatedTime", "LastUpdatedTime", "RefreshTokenCreateTime" },
                values: new object[] { "b991b1f5-3bd1-4fb3-a1a7-f1d04861d8ec", new DateTime(2024, 8, 23, 20, 25, 15, 476, DateTimeKind.Utc).AddTicks(7994), new DateTime(2024, 8, 23, 20, 25, 15, 476, DateTimeKind.Utc).AddTicks(7995), new DateTime(2024, 8, 23, 20, 25, 15, 476, DateTimeKind.Utc).AddTicks(7991) });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: 2056,
                columns: new[] { "ConcurrencyStamp", "CreatedTime", "LastUpdatedTime", "RefreshTokenCreateTime" },
                values: new object[] { "d586311c-ca9a-4a73-93db-f4d732289b60", new DateTime(2024, 8, 23, 20, 25, 15, 476, DateTimeKind.Utc).AddTicks(8009), new DateTime(2024, 8, 23, 20, 25, 15, 476, DateTimeKind.Utc).AddTicks(8010), new DateTime(2024, 8, 23, 20, 25, 15, 476, DateTimeKind.Utc).AddTicks(8006) });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: 2057,
                columns: new[] { "ConcurrencyStamp", "CreatedTime", "LastUpdatedTime", "RefreshTokenCreateTime" },
                values: new object[] { "2aed441e-0897-4ab7-953e-8c879a4620fb", new DateTime(2024, 8, 23, 20, 25, 15, 476, DateTimeKind.Utc).AddTicks(8023), new DateTime(2024, 8, 23, 20, 25, 15, 476, DateTimeKind.Utc).AddTicks(8023), new DateTime(2024, 8, 23, 20, 25, 15, 476, DateTimeKind.Utc).AddTicks(8019) });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: 2058,
                columns: new[] { "ConcurrencyStamp", "CreatedTime", "LastUpdatedTime", "RefreshTokenCreateTime" },
                values: new object[] { "fd259887-786a-46d6-b31c-0846a1cbee0a", new DateTime(2024, 8, 23, 20, 25, 15, 476, DateTimeKind.Utc).AddTicks(8036), new DateTime(2024, 8, 23, 20, 25, 15, 476, DateTimeKind.Utc).AddTicks(8036), new DateTime(2024, 8, 23, 20, 25, 15, 476, DateTimeKind.Utc).AddTicks(8033) });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: 2059,
                columns: new[] { "ConcurrencyStamp", "CreatedTime", "LastUpdatedTime", "RefreshTokenCreateTime" },
                values: new object[] { "7009c083-186f-435e-be22-9fc437d36196", new DateTime(2024, 8, 23, 20, 25, 15, 476, DateTimeKind.Utc).AddTicks(8051), new DateTime(2024, 8, 23, 20, 25, 15, 476, DateTimeKind.Utc).AddTicks(8052), new DateTime(2024, 8, 23, 20, 25, 15, 476, DateTimeKind.Utc).AddTicks(8045) });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: 2060,
                columns: new[] { "ConcurrencyStamp", "CreatedTime", "LastUpdatedTime", "RefreshTokenCreateTime" },
                values: new object[] { "5a87ff48-f10d-4abb-bf7c-68c51f9f0954", new DateTime(2024, 8, 23, 20, 25, 15, 476, DateTimeKind.Utc).AddTicks(8065), new DateTime(2024, 8, 23, 20, 25, 15, 476, DateTimeKind.Utc).AddTicks(8065), new DateTime(2024, 8, 23, 20, 25, 15, 476, DateTimeKind.Utc).AddTicks(8062) });

            migrationBuilder.UpdateData(
                table: "Breeds",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedTime",
                value: new DateTime(2024, 8, 24, 0, 25, 15, 446, DateTimeKind.Local).AddTicks(700));

            migrationBuilder.UpdateData(
                table: "Breeds",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreatedTime",
                value: new DateTime(2024, 8, 24, 0, 25, 15, 446, DateTimeKind.Local).AddTicks(711));

            migrationBuilder.UpdateData(
                table: "Breeds",
                keyColumn: "Id",
                keyValue: 3,
                column: "CreatedTime",
                value: new DateTime(2024, 8, 24, 0, 25, 15, 446, DateTimeKind.Local).AddTicks(713));

            migrationBuilder.UpdateData(
                table: "Breeds",
                keyColumn: "Id",
                keyValue: 4,
                column: "CreatedTime",
                value: new DateTime(2024, 8, 24, 0, 25, 15, 446, DateTimeKind.Local).AddTicks(714));

            migrationBuilder.UpdateData(
                table: "Breeds",
                keyColumn: "Id",
                keyValue: 5,
                column: "CreatedTime",
                value: new DateTime(2024, 8, 24, 0, 25, 15, 446, DateTimeKind.Local).AddTicks(716));

            migrationBuilder.UpdateData(
                table: "Breeds",
                keyColumn: "Id",
                keyValue: 6,
                column: "CreatedTime",
                value: new DateTime(2024, 8, 24, 0, 25, 15, 446, DateTimeKind.Local).AddTicks(717));

            migrationBuilder.UpdateData(
                table: "Breeds",
                keyColumn: "Id",
                keyValue: 7,
                column: "CreatedTime",
                value: new DateTime(2024, 8, 24, 0, 25, 15, 446, DateTimeKind.Local).AddTicks(719));

            migrationBuilder.UpdateData(
                table: "Breeds",
                keyColumn: "Id",
                keyValue: 8,
                column: "CreatedTime",
                value: new DateTime(2024, 8, 24, 0, 25, 15, 446, DateTimeKind.Local).AddTicks(720));

            migrationBuilder.UpdateData(
                table: "Breeds",
                keyColumn: "Id",
                keyValue: 9,
                column: "CreatedTime",
                value: new DateTime(2024, 8, 24, 0, 25, 15, 446, DateTimeKind.Local).AddTicks(721));

            migrationBuilder.UpdateData(
                table: "Breeds",
                keyColumn: "Id",
                keyValue: 10,
                column: "CreatedTime",
                value: new DateTime(2024, 8, 24, 0, 25, 15, 446, DateTimeKind.Local).AddTicks(723));

            migrationBuilder.UpdateData(
                table: "Breeds",
                keyColumn: "Id",
                keyValue: 11,
                column: "CreatedTime",
                value: new DateTime(2024, 8, 24, 0, 25, 15, 446, DateTimeKind.Local).AddTicks(724));

            migrationBuilder.UpdateData(
                table: "Breeds",
                keyColumn: "Id",
                keyValue: 12,
                column: "CreatedTime",
                value: new DateTime(2024, 8, 24, 0, 25, 15, 446, DateTimeKind.Local).AddTicks(725));

            migrationBuilder.UpdateData(
                table: "Breeds",
                keyColumn: "Id",
                keyValue: 13,
                column: "CreatedTime",
                value: new DateTime(2024, 8, 24, 0, 25, 15, 446, DateTimeKind.Local).AddTicks(726));

            migrationBuilder.UpdateData(
                table: "Breeds",
                keyColumn: "Id",
                keyValue: 14,
                column: "CreatedTime",
                value: new DateTime(2024, 8, 24, 0, 25, 15, 446, DateTimeKind.Local).AddTicks(728));

            migrationBuilder.UpdateData(
                table: "Breeds",
                keyColumn: "Id",
                keyValue: 15,
                column: "CreatedTime",
                value: new DateTime(2024, 8, 24, 0, 25, 15, 446, DateTimeKind.Local).AddTicks(729));

            migrationBuilder.UpdateData(
                table: "Breeds",
                keyColumn: "Id",
                keyValue: 16,
                column: "CreatedTime",
                value: new DateTime(2024, 8, 24, 0, 25, 15, 446, DateTimeKind.Local).AddTicks(731));

            migrationBuilder.UpdateData(
                table: "Breeds",
                keyColumn: "Id",
                keyValue: 17,
                column: "CreatedTime",
                value: new DateTime(2024, 8, 24, 0, 25, 15, 446, DateTimeKind.Local).AddTicks(732));

            migrationBuilder.UpdateData(
                table: "Breeds",
                keyColumn: "Id",
                keyValue: 18,
                column: "CreatedTime",
                value: new DateTime(2024, 8, 24, 0, 25, 15, 446, DateTimeKind.Local).AddTicks(734));

            migrationBuilder.UpdateData(
                table: "Breeds",
                keyColumn: "Id",
                keyValue: 19,
                column: "CreatedTime",
                value: new DateTime(2024, 8, 24, 0, 25, 15, 446, DateTimeKind.Local).AddTicks(735));

            migrationBuilder.UpdateData(
                table: "Breeds",
                keyColumn: "Id",
                keyValue: 20,
                column: "CreatedTime",
                value: new DateTime(2024, 8, 24, 0, 25, 15, 446, DateTimeKind.Local).AddTicks(736));

            migrationBuilder.UpdateData(
                table: "Breeds",
                keyColumn: "Id",
                keyValue: 21,
                column: "CreatedTime",
                value: new DateTime(2024, 8, 24, 0, 25, 15, 446, DateTimeKind.Local).AddTicks(738));

            migrationBuilder.UpdateData(
                table: "Breeds",
                keyColumn: "Id",
                keyValue: 22,
                column: "CreatedTime",
                value: new DateTime(2024, 8, 24, 0, 25, 15, 446, DateTimeKind.Local).AddTicks(739));

            migrationBuilder.UpdateData(
                table: "Breeds",
                keyColumn: "Id",
                keyValue: 23,
                column: "CreatedTime",
                value: new DateTime(2024, 8, 24, 0, 25, 15, 446, DateTimeKind.Local).AddTicks(740));

            migrationBuilder.UpdateData(
                table: "Breeds",
                keyColumn: "Id",
                keyValue: 24,
                column: "CreatedTime",
                value: new DateTime(2024, 8, 24, 0, 25, 15, 446, DateTimeKind.Local).AddTicks(742));

            migrationBuilder.UpdateData(
                table: "Breeds",
                keyColumn: "Id",
                keyValue: 25,
                column: "CreatedTime",
                value: new DateTime(2024, 8, 24, 0, 25, 15, 446, DateTimeKind.Local).AddTicks(743));

            migrationBuilder.UpdateData(
                table: "Breeds",
                keyColumn: "Id",
                keyValue: 26,
                column: "CreatedTime",
                value: new DateTime(2024, 8, 24, 0, 25, 15, 446, DateTimeKind.Local).AddTicks(744));

            migrationBuilder.UpdateData(
                table: "Breeds",
                keyColumn: "Id",
                keyValue: 27,
                column: "CreatedTime",
                value: new DateTime(2024, 8, 24, 0, 25, 15, 446, DateTimeKind.Local).AddTicks(745));

            migrationBuilder.UpdateData(
                table: "Breeds",
                keyColumn: "Id",
                keyValue: 28,
                column: "CreatedTime",
                value: new DateTime(2024, 8, 24, 0, 25, 15, 446, DateTimeKind.Local).AddTicks(747));

            migrationBuilder.UpdateData(
                table: "Breeds",
                keyColumn: "Id",
                keyValue: 29,
                column: "CreatedTime",
                value: new DateTime(2024, 8, 24, 0, 25, 15, 446, DateTimeKind.Local).AddTicks(748));

            migrationBuilder.UpdateData(
                table: "Breeds",
                keyColumn: "Id",
                keyValue: 30,
                column: "CreatedTime",
                value: new DateTime(2024, 8, 24, 0, 25, 15, 446, DateTimeKind.Local).AddTicks(749));

            migrationBuilder.UpdateData(
                table: "Breeds",
                keyColumn: "Id",
                keyValue: 31,
                column: "CreatedTime",
                value: new DateTime(2024, 8, 24, 0, 25, 15, 446, DateTimeKind.Local).AddTicks(751));

            migrationBuilder.UpdateData(
                table: "Breeds",
                keyColumn: "Id",
                keyValue: 32,
                column: "CreatedTime",
                value: new DateTime(2024, 8, 24, 0, 25, 15, 446, DateTimeKind.Local).AddTicks(752));

            migrationBuilder.UpdateData(
                table: "Breeds",
                keyColumn: "Id",
                keyValue: 33,
                column: "CreatedTime",
                value: new DateTime(2024, 8, 24, 0, 25, 15, 446, DateTimeKind.Local).AddTicks(753));

            migrationBuilder.UpdateData(
                table: "Breeds",
                keyColumn: "Id",
                keyValue: 34,
                column: "CreatedTime",
                value: new DateTime(2024, 8, 24, 0, 25, 15, 446, DateTimeKind.Local).AddTicks(755));

            migrationBuilder.UpdateData(
                table: "Breeds",
                keyColumn: "Id",
                keyValue: 35,
                column: "CreatedTime",
                value: new DateTime(2024, 8, 24, 0, 25, 15, 446, DateTimeKind.Local).AddTicks(756));

            migrationBuilder.UpdateData(
                table: "Breeds",
                keyColumn: "Id",
                keyValue: 36,
                column: "CreatedTime",
                value: new DateTime(2024, 8, 24, 0, 25, 15, 446, DateTimeKind.Local).AddTicks(757));

            migrationBuilder.UpdateData(
                table: "Breeds",
                keyColumn: "Id",
                keyValue: 37,
                column: "CreatedTime",
                value: new DateTime(2024, 8, 24, 0, 25, 15, 446, DateTimeKind.Local).AddTicks(758));

            migrationBuilder.UpdateData(
                table: "Breeds",
                keyColumn: "Id",
                keyValue: 38,
                column: "CreatedTime",
                value: new DateTime(2024, 8, 24, 0, 25, 15, 446, DateTimeKind.Local).AddTicks(760));

            migrationBuilder.UpdateData(
                table: "Breeds",
                keyColumn: "Id",
                keyValue: 39,
                column: "CreatedTime",
                value: new DateTime(2024, 8, 24, 0, 25, 15, 446, DateTimeKind.Local).AddTicks(761));

            migrationBuilder.UpdateData(
                table: "Breeds",
                keyColumn: "Id",
                keyValue: 40,
                column: "CreatedTime",
                value: new DateTime(2024, 8, 24, 0, 25, 15, 446, DateTimeKind.Local).AddTicks(762));

            migrationBuilder.UpdateData(
                table: "Breeds",
                keyColumn: "Id",
                keyValue: 41,
                column: "CreatedTime",
                value: new DateTime(2024, 8, 24, 0, 25, 15, 446, DateTimeKind.Local).AddTicks(763));

            migrationBuilder.UpdateData(
                table: "Breeds",
                keyColumn: "Id",
                keyValue: 42,
                column: "CreatedTime",
                value: new DateTime(2024, 8, 24, 0, 25, 15, 446, DateTimeKind.Local).AddTicks(765));

            migrationBuilder.UpdateData(
                table: "Breeds",
                keyColumn: "Id",
                keyValue: 43,
                column: "CreatedTime",
                value: new DateTime(2024, 8, 24, 0, 25, 15, 446, DateTimeKind.Local).AddTicks(766));

            migrationBuilder.UpdateData(
                table: "Breeds",
                keyColumn: "Id",
                keyValue: 44,
                column: "CreatedTime",
                value: new DateTime(2024, 8, 24, 0, 25, 15, 446, DateTimeKind.Local).AddTicks(768));

            migrationBuilder.UpdateData(
                table: "Breeds",
                keyColumn: "Id",
                keyValue: 45,
                column: "CreatedTime",
                value: new DateTime(2024, 8, 24, 0, 25, 15, 446, DateTimeKind.Local).AddTicks(770));

            migrationBuilder.UpdateData(
                table: "Breeds",
                keyColumn: "Id",
                keyValue: 46,
                column: "CreatedTime",
                value: new DateTime(2024, 8, 24, 0, 25, 15, 446, DateTimeKind.Local).AddTicks(771));

            migrationBuilder.UpdateData(
                table: "Breeds",
                keyColumn: "Id",
                keyValue: 47,
                column: "CreatedTime",
                value: new DateTime(2024, 8, 24, 0, 25, 15, 446, DateTimeKind.Local).AddTicks(773));

            migrationBuilder.UpdateData(
                table: "Breeds",
                keyColumn: "Id",
                keyValue: 48,
                column: "CreatedTime",
                value: new DateTime(2024, 8, 24, 0, 25, 15, 446, DateTimeKind.Local).AddTicks(774));

            migrationBuilder.UpdateData(
                table: "Breeds",
                keyColumn: "Id",
                keyValue: 49,
                column: "CreatedTime",
                value: new DateTime(2024, 8, 24, 0, 25, 15, 446, DateTimeKind.Local).AddTicks(775));

            migrationBuilder.UpdateData(
                table: "Breeds",
                keyColumn: "Id",
                keyValue: 50,
                column: "CreatedTime",
                value: new DateTime(2024, 8, 24, 0, 25, 15, 446, DateTimeKind.Local).AddTicks(777));

            migrationBuilder.UpdateData(
                table: "Breeds",
                keyColumn: "Id",
                keyValue: 51,
                column: "CreatedTime",
                value: new DateTime(2024, 8, 24, 0, 25, 15, 446, DateTimeKind.Local).AddTicks(778));

            migrationBuilder.UpdateData(
                table: "Breeds",
                keyColumn: "Id",
                keyValue: 52,
                column: "CreatedTime",
                value: new DateTime(2024, 8, 24, 0, 25, 15, 446, DateTimeKind.Local).AddTicks(779));

            migrationBuilder.UpdateData(
                table: "Breeds",
                keyColumn: "Id",
                keyValue: 53,
                column: "CreatedTime",
                value: new DateTime(2024, 8, 24, 0, 25, 15, 446, DateTimeKind.Local).AddTicks(781));

            migrationBuilder.UpdateData(
                table: "Breeds",
                keyColumn: "Id",
                keyValue: 54,
                column: "CreatedTime",
                value: new DateTime(2024, 8, 24, 0, 25, 15, 446, DateTimeKind.Local).AddTicks(782));

            migrationBuilder.UpdateData(
                table: "Breeds",
                keyColumn: "Id",
                keyValue: 55,
                column: "CreatedTime",
                value: new DateTime(2024, 8, 24, 0, 25, 15, 446, DateTimeKind.Local).AddTicks(784));

            migrationBuilder.UpdateData(
                table: "Breeds",
                keyColumn: "Id",
                keyValue: 56,
                column: "CreatedTime",
                value: new DateTime(2024, 8, 24, 0, 25, 15, 446, DateTimeKind.Local).AddTicks(785));

            migrationBuilder.UpdateData(
                table: "Breeds",
                keyColumn: "Id",
                keyValue: 57,
                column: "CreatedTime",
                value: new DateTime(2024, 8, 24, 0, 25, 15, 446, DateTimeKind.Local).AddTicks(786));

            migrationBuilder.UpdateData(
                table: "Breeds",
                keyColumn: "Id",
                keyValue: 58,
                column: "CreatedTime",
                value: new DateTime(2024, 8, 24, 0, 25, 15, 446, DateTimeKind.Local).AddTicks(787));

            migrationBuilder.UpdateData(
                table: "Breeds",
                keyColumn: "Id",
                keyValue: 59,
                column: "CreatedTime",
                value: new DateTime(2024, 8, 24, 0, 25, 15, 446, DateTimeKind.Local).AddTicks(789));

            migrationBuilder.UpdateData(
                table: "Breeds",
                keyColumn: "Id",
                keyValue: 60,
                column: "CreatedTime",
                value: new DateTime(2024, 8, 24, 0, 25, 15, 446, DateTimeKind.Local).AddTicks(790));

            migrationBuilder.UpdateData(
                table: "Breeds",
                keyColumn: "Id",
                keyValue: 61,
                column: "CreatedTime",
                value: new DateTime(2024, 8, 24, 0, 25, 15, 446, DateTimeKind.Local).AddTicks(792));

            migrationBuilder.UpdateData(
                table: "Breeds",
                keyColumn: "Id",
                keyValue: 62,
                column: "CreatedTime",
                value: new DateTime(2024, 8, 24, 0, 25, 15, 446, DateTimeKind.Local).AddTicks(793));

            migrationBuilder.UpdateData(
                table: "Breeds",
                keyColumn: "Id",
                keyValue: 63,
                column: "CreatedTime",
                value: new DateTime(2024, 8, 24, 0, 25, 15, 446, DateTimeKind.Local).AddTicks(794));

            migrationBuilder.UpdateData(
                table: "Breeds",
                keyColumn: "Id",
                keyValue: 64,
                column: "CreatedTime",
                value: new DateTime(2024, 8, 24, 0, 25, 15, 446, DateTimeKind.Local).AddTicks(796));

            migrationBuilder.UpdateData(
                table: "Breeds",
                keyColumn: "Id",
                keyValue: 65,
                column: "CreatedTime",
                value: new DateTime(2024, 8, 24, 0, 25, 15, 446, DateTimeKind.Local).AddTicks(797));

            migrationBuilder.UpdateData(
                table: "Breeds",
                keyColumn: "Id",
                keyValue: 66,
                column: "CreatedTime",
                value: new DateTime(2024, 8, 24, 0, 25, 15, 446, DateTimeKind.Local).AddTicks(798));

            migrationBuilder.UpdateData(
                table: "Breeds",
                keyColumn: "Id",
                keyValue: 67,
                column: "CreatedTime",
                value: new DateTime(2024, 8, 24, 0, 25, 15, 446, DateTimeKind.Local).AddTicks(845));

            migrationBuilder.UpdateData(
                table: "Breeds",
                keyColumn: "Id",
                keyValue: 68,
                column: "CreatedTime",
                value: new DateTime(2024, 8, 24, 0, 25, 15, 446, DateTimeKind.Local).AddTicks(847));

            migrationBuilder.UpdateData(
                table: "Breeds",
                keyColumn: "Id",
                keyValue: 69,
                column: "CreatedTime",
                value: new DateTime(2024, 8, 24, 0, 25, 15, 446, DateTimeKind.Local).AddTicks(848));

            migrationBuilder.UpdateData(
                table: "Breeds",
                keyColumn: "Id",
                keyValue: 70,
                column: "CreatedTime",
                value: new DateTime(2024, 8, 24, 0, 25, 15, 446, DateTimeKind.Local).AddTicks(850));

            migrationBuilder.UpdateData(
                table: "Breeds",
                keyColumn: "Id",
                keyValue: 71,
                column: "CreatedTime",
                value: new DateTime(2024, 8, 24, 0, 25, 15, 446, DateTimeKind.Local).AddTicks(851));

            migrationBuilder.UpdateData(
                table: "Breeds",
                keyColumn: "Id",
                keyValue: 72,
                column: "CreatedTime",
                value: new DateTime(2024, 8, 24, 0, 25, 15, 446, DateTimeKind.Local).AddTicks(852));

            migrationBuilder.UpdateData(
                table: "Breeds",
                keyColumn: "Id",
                keyValue: 73,
                column: "CreatedTime",
                value: new DateTime(2024, 8, 24, 0, 25, 15, 446, DateTimeKind.Local).AddTicks(854));

            migrationBuilder.UpdateData(
                table: "Breeds",
                keyColumn: "Id",
                keyValue: 74,
                column: "CreatedTime",
                value: new DateTime(2024, 8, 24, 0, 25, 15, 446, DateTimeKind.Local).AddTicks(856));

            migrationBuilder.UpdateData(
                table: "Breeds",
                keyColumn: "Id",
                keyValue: 75,
                column: "CreatedTime",
                value: new DateTime(2024, 8, 24, 0, 25, 15, 446, DateTimeKind.Local).AddTicks(857));

            migrationBuilder.UpdateData(
                table: "Breeds",
                keyColumn: "Id",
                keyValue: 76,
                column: "CreatedTime",
                value: new DateTime(2024, 8, 24, 0, 25, 15, 446, DateTimeKind.Local).AddTicks(858));

            migrationBuilder.UpdateData(
                table: "Breeds",
                keyColumn: "Id",
                keyValue: 77,
                column: "CreatedTime",
                value: new DateTime(2024, 8, 24, 0, 25, 15, 446, DateTimeKind.Local).AddTicks(859));

            migrationBuilder.UpdateData(
                table: "Breeds",
                keyColumn: "Id",
                keyValue: 78,
                column: "CreatedTime",
                value: new DateTime(2024, 8, 24, 0, 25, 15, 446, DateTimeKind.Local).AddTicks(861));

            migrationBuilder.UpdateData(
                table: "Breeds",
                keyColumn: "Id",
                keyValue: 79,
                column: "CreatedTime",
                value: new DateTime(2024, 8, 24, 0, 25, 15, 446, DateTimeKind.Local).AddTicks(862));

            migrationBuilder.UpdateData(
                table: "Breeds",
                keyColumn: "Id",
                keyValue: 80,
                column: "CreatedTime",
                value: new DateTime(2024, 8, 24, 0, 25, 15, 446, DateTimeKind.Local).AddTicks(863));

            migrationBuilder.UpdateData(
                table: "Breeds",
                keyColumn: "Id",
                keyValue: 81,
                column: "CreatedTime",
                value: new DateTime(2024, 8, 24, 0, 25, 15, 446, DateTimeKind.Local).AddTicks(864));

            migrationBuilder.UpdateData(
                table: "Breeds",
                keyColumn: "Id",
                keyValue: 82,
                column: "CreatedTime",
                value: new DateTime(2024, 8, 24, 0, 25, 15, 446, DateTimeKind.Local).AddTicks(866));

            migrationBuilder.UpdateData(
                table: "Breeds",
                keyColumn: "Id",
                keyValue: 83,
                column: "CreatedTime",
                value: new DateTime(2024, 8, 24, 0, 25, 15, 446, DateTimeKind.Local).AddTicks(867));

            migrationBuilder.UpdateData(
                table: "Breeds",
                keyColumn: "Id",
                keyValue: 84,
                column: "CreatedTime",
                value: new DateTime(2024, 8, 24, 0, 25, 15, 446, DateTimeKind.Local).AddTicks(868));

            migrationBuilder.UpdateData(
                table: "Breeds",
                keyColumn: "Id",
                keyValue: 85,
                column: "CreatedTime",
                value: new DateTime(2024, 8, 24, 0, 25, 15, 446, DateTimeKind.Local).AddTicks(870));

            migrationBuilder.UpdateData(
                table: "Breeds",
                keyColumn: "Id",
                keyValue: 86,
                column: "CreatedTime",
                value: new DateTime(2024, 8, 24, 0, 25, 15, 446, DateTimeKind.Local).AddTicks(871));

            migrationBuilder.UpdateData(
                table: "Breeds",
                keyColumn: "Id",
                keyValue: 87,
                column: "CreatedTime",
                value: new DateTime(2024, 8, 24, 0, 25, 15, 446, DateTimeKind.Local).AddTicks(872));

            migrationBuilder.UpdateData(
                table: "Breeds",
                keyColumn: "Id",
                keyValue: 88,
                column: "CreatedTime",
                value: new DateTime(2024, 8, 24, 0, 25, 15, 446, DateTimeKind.Local).AddTicks(874));

            migrationBuilder.UpdateData(
                table: "Breeds",
                keyColumn: "Id",
                keyValue: 89,
                column: "CreatedTime",
                value: new DateTime(2024, 8, 24, 0, 25, 15, 446, DateTimeKind.Local).AddTicks(875));

            migrationBuilder.UpdateData(
                table: "Breeds",
                keyColumn: "Id",
                keyValue: 90,
                column: "CreatedTime",
                value: new DateTime(2024, 8, 24, 0, 25, 15, 446, DateTimeKind.Local).AddTicks(876));

            migrationBuilder.UpdateData(
                table: "Breeds",
                keyColumn: "Id",
                keyValue: 91,
                column: "CreatedTime",
                value: new DateTime(2024, 8, 24, 0, 25, 15, 446, DateTimeKind.Local).AddTicks(877));

            migrationBuilder.UpdateData(
                table: "Breeds",
                keyColumn: "Id",
                keyValue: 92,
                column: "CreatedTime",
                value: new DateTime(2024, 8, 24, 0, 25, 15, 446, DateTimeKind.Local).AddTicks(879));

            migrationBuilder.UpdateData(
                table: "Breeds",
                keyColumn: "Id",
                keyValue: 93,
                column: "CreatedTime",
                value: new DateTime(2024, 8, 24, 0, 25, 15, 446, DateTimeKind.Local).AddTicks(880));

            migrationBuilder.UpdateData(
                table: "Breeds",
                keyColumn: "Id",
                keyValue: 94,
                column: "CreatedTime",
                value: new DateTime(2024, 8, 24, 0, 25, 15, 446, DateTimeKind.Local).AddTicks(881));

            migrationBuilder.UpdateData(
                table: "Breeds",
                keyColumn: "Id",
                keyValue: 95,
                column: "CreatedTime",
                value: new DateTime(2024, 8, 24, 0, 25, 15, 446, DateTimeKind.Local).AddTicks(883));

            migrationBuilder.UpdateData(
                table: "Breeds",
                keyColumn: "Id",
                keyValue: 96,
                column: "CreatedTime",
                value: new DateTime(2024, 8, 24, 0, 25, 15, 446, DateTimeKind.Local).AddTicks(884));

            migrationBuilder.UpdateData(
                table: "Breeds",
                keyColumn: "Id",
                keyValue: 97,
                column: "CreatedTime",
                value: new DateTime(2024, 8, 24, 0, 25, 15, 446, DateTimeKind.Local).AddTicks(885));

            migrationBuilder.UpdateData(
                table: "Breeds",
                keyColumn: "Id",
                keyValue: 98,
                column: "CreatedTime",
                value: new DateTime(2024, 8, 24, 0, 25, 15, 446, DateTimeKind.Local).AddTicks(886));

            migrationBuilder.UpdateData(
                table: "Breeds",
                keyColumn: "Id",
                keyValue: 99,
                column: "CreatedTime",
                value: new DateTime(2024, 8, 24, 0, 25, 15, 446, DateTimeKind.Local).AddTicks(888));

            migrationBuilder.UpdateData(
                table: "Breeds",
                keyColumn: "Id",
                keyValue: 100,
                column: "CreatedTime",
                value: new DateTime(2024, 8, 24, 0, 25, 15, 446, DateTimeKind.Local).AddTicks(889));

            migrationBuilder.UpdateData(
                table: "Breeds",
                keyColumn: "Id",
                keyValue: 101,
                column: "CreatedTime",
                value: new DateTime(2024, 8, 24, 0, 25, 15, 446, DateTimeKind.Local).AddTicks(890));

            migrationBuilder.UpdateData(
                table: "Breeds",
                keyColumn: "Id",
                keyValue: 102,
                column: "CreatedTime",
                value: new DateTime(2024, 8, 24, 0, 25, 15, 446, DateTimeKind.Local).AddTicks(891));

            migrationBuilder.UpdateData(
                table: "Breeds",
                keyColumn: "Id",
                keyValue: 103,
                column: "CreatedTime",
                value: new DateTime(2024, 8, 24, 0, 25, 15, 446, DateTimeKind.Local).AddTicks(896));

            migrationBuilder.UpdateData(
                table: "Breeds",
                keyColumn: "Id",
                keyValue: 104,
                column: "CreatedTime",
                value: new DateTime(2024, 8, 24, 0, 25, 15, 446, DateTimeKind.Local).AddTicks(897));

            migrationBuilder.UpdateData(
                table: "Breeds",
                keyColumn: "Id",
                keyValue: 105,
                column: "CreatedTime",
                value: new DateTime(2024, 8, 24, 0, 25, 15, 446, DateTimeKind.Local).AddTicks(898));

            migrationBuilder.UpdateData(
                table: "Breeds",
                keyColumn: "Id",
                keyValue: 106,
                column: "CreatedTime",
                value: new DateTime(2024, 8, 24, 0, 25, 15, 446, DateTimeKind.Local).AddTicks(899));

            migrationBuilder.UpdateData(
                table: "Breeds",
                keyColumn: "Id",
                keyValue: 107,
                column: "CreatedTime",
                value: new DateTime(2024, 8, 24, 0, 25, 15, 446, DateTimeKind.Local).AddTicks(901));

            migrationBuilder.UpdateData(
                table: "Breeds",
                keyColumn: "Id",
                keyValue: 108,
                column: "CreatedTime",
                value: new DateTime(2024, 8, 24, 0, 25, 15, 446, DateTimeKind.Local).AddTicks(902));

            migrationBuilder.UpdateData(
                table: "Breeds",
                keyColumn: "Id",
                keyValue: 109,
                column: "CreatedTime",
                value: new DateTime(2024, 8, 24, 0, 25, 15, 446, DateTimeKind.Local).AddTicks(903));

            migrationBuilder.UpdateData(
                table: "Breeds",
                keyColumn: "Id",
                keyValue: 110,
                column: "CreatedTime",
                value: new DateTime(2024, 8, 24, 0, 25, 15, 446, DateTimeKind.Local).AddTicks(904));

            migrationBuilder.UpdateData(
                table: "Breeds",
                keyColumn: "Id",
                keyValue: 111,
                column: "CreatedTime",
                value: new DateTime(2024, 8, 24, 0, 25, 15, 446, DateTimeKind.Local).AddTicks(906));

            migrationBuilder.UpdateData(
                table: "Breeds",
                keyColumn: "Id",
                keyValue: 112,
                column: "CreatedTime",
                value: new DateTime(2024, 8, 24, 0, 25, 15, 446, DateTimeKind.Local).AddTicks(907));

            migrationBuilder.UpdateData(
                table: "Breeds",
                keyColumn: "Id",
                keyValue: 113,
                column: "CreatedTime",
                value: new DateTime(2024, 8, 24, 0, 25, 15, 446, DateTimeKind.Local).AddTicks(908));

            migrationBuilder.UpdateData(
                table: "Breeds",
                keyColumn: "Id",
                keyValue: 114,
                column: "CreatedTime",
                value: new DateTime(2024, 8, 24, 0, 25, 15, 446, DateTimeKind.Local).AddTicks(909));

            migrationBuilder.UpdateData(
                table: "Breeds",
                keyColumn: "Id",
                keyValue: 115,
                column: "CreatedTime",
                value: new DateTime(2024, 8, 24, 0, 25, 15, 446, DateTimeKind.Local).AddTicks(911));

            migrationBuilder.UpdateData(
                table: "Breeds",
                keyColumn: "Id",
                keyValue: 116,
                column: "CreatedTime",
                value: new DateTime(2024, 8, 24, 0, 25, 15, 446, DateTimeKind.Local).AddTicks(912));

            migrationBuilder.UpdateData(
                table: "Breeds",
                keyColumn: "Id",
                keyValue: 117,
                column: "CreatedTime",
                value: new DateTime(2024, 8, 24, 0, 25, 15, 446, DateTimeKind.Local).AddTicks(914));

            migrationBuilder.UpdateData(
                table: "Breeds",
                keyColumn: "Id",
                keyValue: 118,
                column: "CreatedTime",
                value: new DateTime(2024, 8, 24, 0, 25, 15, 446, DateTimeKind.Local).AddTicks(915));

            migrationBuilder.UpdateData(
                table: "Breeds",
                keyColumn: "Id",
                keyValue: 119,
                column: "CreatedTime",
                value: new DateTime(2024, 8, 24, 0, 25, 15, 446, DateTimeKind.Local).AddTicks(916));

            migrationBuilder.UpdateData(
                table: "Breeds",
                keyColumn: "Id",
                keyValue: 120,
                column: "CreatedTime",
                value: new DateTime(2024, 8, 24, 0, 25, 15, 446, DateTimeKind.Local).AddTicks(918));

            migrationBuilder.UpdateData(
                table: "Breeds",
                keyColumn: "Id",
                keyValue: 121,
                column: "CreatedTime",
                value: new DateTime(2024, 8, 24, 0, 25, 15, 446, DateTimeKind.Local).AddTicks(919));

            migrationBuilder.UpdateData(
                table: "Breeds",
                keyColumn: "Id",
                keyValue: 122,
                column: "CreatedTime",
                value: new DateTime(2024, 8, 24, 0, 25, 15, 446, DateTimeKind.Local).AddTicks(920));

            migrationBuilder.UpdateData(
                table: "Breeds",
                keyColumn: "Id",
                keyValue: 123,
                column: "CreatedTime",
                value: new DateTime(2024, 8, 24, 0, 25, 15, 446, DateTimeKind.Local).AddTicks(922));

            migrationBuilder.UpdateData(
                table: "Breeds",
                keyColumn: "Id",
                keyValue: 124,
                column: "CreatedTime",
                value: new DateTime(2024, 8, 24, 0, 25, 15, 446, DateTimeKind.Local).AddTicks(923));

            migrationBuilder.UpdateData(
                table: "Breeds",
                keyColumn: "Id",
                keyValue: 125,
                column: "CreatedTime",
                value: new DateTime(2024, 8, 24, 0, 25, 15, 446, DateTimeKind.Local).AddTicks(924));

            migrationBuilder.UpdateData(
                table: "Breeds",
                keyColumn: "Id",
                keyValue: 126,
                column: "CreatedTime",
                value: new DateTime(2024, 8, 24, 0, 25, 15, 446, DateTimeKind.Local).AddTicks(925));

            migrationBuilder.UpdateData(
                table: "Breeds",
                keyColumn: "Id",
                keyValue: 127,
                column: "CreatedTime",
                value: new DateTime(2024, 8, 24, 0, 25, 15, 446, DateTimeKind.Local).AddTicks(927));

            migrationBuilder.UpdateData(
                table: "Breeds",
                keyColumn: "Id",
                keyValue: 128,
                column: "CreatedTime",
                value: new DateTime(2024, 8, 24, 0, 25, 15, 446, DateTimeKind.Local).AddTicks(928));

            migrationBuilder.UpdateData(
                table: "Breeds",
                keyColumn: "Id",
                keyValue: 129,
                column: "CreatedTime",
                value: new DateTime(2024, 8, 24, 0, 25, 15, 446, DateTimeKind.Local).AddTicks(929));

            migrationBuilder.UpdateData(
                table: "Breeds",
                keyColumn: "Id",
                keyValue: 130,
                column: "CreatedTime",
                value: new DateTime(2024, 8, 24, 0, 25, 15, 446, DateTimeKind.Local).AddTicks(931));

            migrationBuilder.UpdateData(
                table: "Breeds",
                keyColumn: "Id",
                keyValue: 131,
                column: "CreatedTime",
                value: new DateTime(2024, 8, 24, 0, 25, 15, 446, DateTimeKind.Local).AddTicks(932));

            migrationBuilder.UpdateData(
                table: "Breeds",
                keyColumn: "Id",
                keyValue: 132,
                column: "CreatedTime",
                value: new DateTime(2024, 8, 24, 0, 25, 15, 446, DateTimeKind.Local).AddTicks(935));

            migrationBuilder.UpdateData(
                table: "Breeds",
                keyColumn: "Id",
                keyValue: 133,
                column: "CreatedTime",
                value: new DateTime(2024, 8, 24, 0, 25, 15, 446, DateTimeKind.Local).AddTicks(936));

            migrationBuilder.UpdateData(
                table: "Breeds",
                keyColumn: "Id",
                keyValue: 134,
                column: "CreatedTime",
                value: new DateTime(2024, 8, 24, 0, 25, 15, 446, DateTimeKind.Local).AddTicks(938));

            migrationBuilder.UpdateData(
                table: "Breeds",
                keyColumn: "Id",
                keyValue: 135,
                column: "CreatedTime",
                value: new DateTime(2024, 8, 24, 0, 25, 15, 446, DateTimeKind.Local).AddTicks(939));

            migrationBuilder.UpdateData(
                table: "Breeds",
                keyColumn: "Id",
                keyValue: 136,
                column: "CreatedTime",
                value: new DateTime(2024, 8, 24, 0, 25, 15, 446, DateTimeKind.Local).AddTicks(940));

            migrationBuilder.UpdateData(
                table: "Breeds",
                keyColumn: "Id",
                keyValue: 137,
                column: "CreatedTime",
                value: new DateTime(2024, 8, 24, 0, 25, 15, 446, DateTimeKind.Local).AddTicks(941));

            migrationBuilder.UpdateData(
                table: "Breeds",
                keyColumn: "Id",
                keyValue: 138,
                column: "CreatedTime",
                value: new DateTime(2024, 8, 24, 0, 25, 15, 446, DateTimeKind.Local).AddTicks(943));

            migrationBuilder.UpdateData(
                table: "Breeds",
                keyColumn: "Id",
                keyValue: 139,
                column: "CreatedTime",
                value: new DateTime(2024, 8, 24, 0, 25, 15, 446, DateTimeKind.Local).AddTicks(944));

            migrationBuilder.UpdateData(
                table: "Breeds",
                keyColumn: "Id",
                keyValue: 140,
                column: "CreatedTime",
                value: new DateTime(2024, 8, 24, 0, 25, 15, 446, DateTimeKind.Local).AddTicks(945));

            migrationBuilder.UpdateData(
                table: "Breeds",
                keyColumn: "Id",
                keyValue: 141,
                column: "CreatedTime",
                value: new DateTime(2024, 8, 24, 0, 25, 15, 446, DateTimeKind.Local).AddTicks(947));

            migrationBuilder.UpdateData(
                table: "Breeds",
                keyColumn: "Id",
                keyValue: 142,
                column: "CreatedTime",
                value: new DateTime(2024, 8, 24, 0, 25, 15, 446, DateTimeKind.Local).AddTicks(948));

            migrationBuilder.UpdateData(
                table: "Breeds",
                keyColumn: "Id",
                keyValue: 143,
                column: "CreatedTime",
                value: new DateTime(2024, 8, 24, 0, 25, 15, 446, DateTimeKind.Local).AddTicks(949));

            migrationBuilder.UpdateData(
                table: "Breeds",
                keyColumn: "Id",
                keyValue: 144,
                column: "CreatedTime",
                value: new DateTime(2024, 8, 24, 0, 25, 15, 446, DateTimeKind.Local).AddTicks(951));

            migrationBuilder.UpdateData(
                table: "Breeds",
                keyColumn: "Id",
                keyValue: 145,
                column: "CreatedTime",
                value: new DateTime(2024, 8, 24, 0, 25, 15, 446, DateTimeKind.Local).AddTicks(952));

            migrationBuilder.UpdateData(
                table: "Breeds",
                keyColumn: "Id",
                keyValue: 146,
                column: "CreatedTime",
                value: new DateTime(2024, 8, 24, 0, 25, 15, 446, DateTimeKind.Local).AddTicks(953));

            migrationBuilder.UpdateData(
                table: "Breeds",
                keyColumn: "Id",
                keyValue: 147,
                column: "CreatedTime",
                value: new DateTime(2024, 8, 24, 0, 25, 15, 446, DateTimeKind.Local).AddTicks(955));

            migrationBuilder.UpdateData(
                table: "Breeds",
                keyColumn: "Id",
                keyValue: 148,
                column: "CreatedTime",
                value: new DateTime(2024, 8, 24, 0, 25, 15, 446, DateTimeKind.Local).AddTicks(956));

            migrationBuilder.UpdateData(
                table: "Breeds",
                keyColumn: "Id",
                keyValue: 149,
                column: "CreatedTime",
                value: new DateTime(2024, 8, 24, 0, 25, 15, 446, DateTimeKind.Local).AddTicks(957));

            migrationBuilder.UpdateData(
                table: "Breeds",
                keyColumn: "Id",
                keyValue: 150,
                column: "CreatedTime",
                value: new DateTime(2024, 8, 24, 0, 25, 15, 446, DateTimeKind.Local).AddTicks(958));

            migrationBuilder.UpdateData(
                table: "Breeds",
                keyColumn: "Id",
                keyValue: 151,
                column: "CreatedTime",
                value: new DateTime(2024, 8, 24, 0, 25, 15, 446, DateTimeKind.Local).AddTicks(960));

            migrationBuilder.UpdateData(
                table: "Breeds",
                keyColumn: "Id",
                keyValue: 152,
                column: "CreatedTime",
                value: new DateTime(2024, 8, 24, 0, 25, 15, 446, DateTimeKind.Local).AddTicks(961));

            migrationBuilder.UpdateData(
                table: "Breeds",
                keyColumn: "Id",
                keyValue: 153,
                column: "CreatedTime",
                value: new DateTime(2024, 8, 24, 0, 25, 15, 446, DateTimeKind.Local).AddTicks(962));

            migrationBuilder.UpdateData(
                table: "Breeds",
                keyColumn: "Id",
                keyValue: 154,
                column: "CreatedTime",
                value: new DateTime(2024, 8, 24, 0, 25, 15, 446, DateTimeKind.Local).AddTicks(964));

            migrationBuilder.UpdateData(
                table: "Breeds",
                keyColumn: "Id",
                keyValue: 155,
                column: "CreatedTime",
                value: new DateTime(2024, 8, 24, 0, 25, 15, 446, DateTimeKind.Local).AddTicks(965));

            migrationBuilder.UpdateData(
                table: "Breeds",
                keyColumn: "Id",
                keyValue: 156,
                column: "CreatedTime",
                value: new DateTime(2024, 8, 24, 0, 25, 15, 446, DateTimeKind.Local).AddTicks(967));

            migrationBuilder.UpdateData(
                table: "Breeds",
                keyColumn: "Id",
                keyValue: 157,
                column: "CreatedTime",
                value: new DateTime(2024, 8, 24, 0, 25, 15, 446, DateTimeKind.Local).AddTicks(968));

            migrationBuilder.UpdateData(
                table: "Breeds",
                keyColumn: "Id",
                keyValue: 158,
                column: "CreatedTime",
                value: new DateTime(2024, 8, 24, 0, 25, 15, 446, DateTimeKind.Local).AddTicks(969));

            migrationBuilder.UpdateData(
                table: "Breeds",
                keyColumn: "Id",
                keyValue: 159,
                column: "CreatedTime",
                value: new DateTime(2024, 8, 24, 0, 25, 15, 446, DateTimeKind.Local).AddTicks(970));

            migrationBuilder.UpdateData(
                table: "Breeds",
                keyColumn: "Id",
                keyValue: 160,
                column: "CreatedTime",
                value: new DateTime(2024, 8, 24, 0, 25, 15, 446, DateTimeKind.Local).AddTicks(972));

            migrationBuilder.UpdateData(
                table: "PetTypes",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedTime",
                value: new DateTime(2024, 8, 24, 0, 25, 15, 445, DateTimeKind.Local).AddTicks(4611));

            migrationBuilder.UpdateData(
                table: "PetTypes",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreatedTime",
                value: new DateTime(2024, 8, 24, 0, 25, 15, 445, DateTimeKind.Local).AddTicks(4624));

            migrationBuilder.UpdateData(
                table: "PetTypes",
                keyColumn: "Id",
                keyValue: 3,
                column: "CreatedTime",
                value: new DateTime(2024, 8, 24, 0, 25, 15, 445, DateTimeKind.Local).AddTicks(4625));

            migrationBuilder.UpdateData(
                table: "PetTypes",
                keyColumn: "Id",
                keyValue: 4,
                column: "CreatedTime",
                value: new DateTime(2024, 8, 24, 0, 25, 15, 445, DateTimeKind.Local).AddTicks(4627));

            migrationBuilder.UpdateData(
                table: "PetTypes",
                keyColumn: "Id",
                keyValue: 5,
                column: "CreatedTime",
                value: new DateTime(2024, 8, 24, 0, 25, 15, 445, DateTimeKind.Local).AddTicks(4628));

            migrationBuilder.UpdateData(
                table: "PetTypes",
                keyColumn: "Id",
                keyValue: 6,
                column: "CreatedTime",
                value: new DateTime(2024, 8, 24, 0, 25, 15, 445, DateTimeKind.Local).AddTicks(4630));

            migrationBuilder.UpdateData(
                table: "PetTypes",
                keyColumn: "Id",
                keyValue: 7,
                column: "CreatedTime",
                value: new DateTime(2024, 8, 24, 0, 25, 15, 445, DateTimeKind.Local).AddTicks(4631));

            migrationBuilder.UpdateData(
                table: "PetTypes",
                keyColumn: "Id",
                keyValue: 8,
                column: "CreatedTime",
                value: new DateTime(2024, 8, 24, 0, 25, 15, 445, DateTimeKind.Local).AddTicks(4632));

            migrationBuilder.UpdateData(
                table: "Shelters",
                keyColumn: "Id",
                keyValue: 1021,
                columns: new[] { "CreatedTime", "LastUpdatedTime", "ShelterName" },
                values: new object[] { new DateTime(2024, 8, 23, 20, 25, 15, 443, DateTimeKind.Utc).AddTicks(7643), new DateTime(2024, 8, 23, 20, 25, 15, 443, DateTimeKind.Utc).AddTicks(7645), null });

            migrationBuilder.UpdateData(
                table: "Shelters",
                keyColumn: "Id",
                keyValue: 1022,
                columns: new[] { "CreatedTime", "LastUpdatedTime", "ShelterName" },
                values: new object[] { new DateTime(2024, 8, 23, 20, 25, 15, 443, DateTimeKind.Utc).AddTicks(7654), new DateTime(2024, 8, 23, 20, 25, 15, 443, DateTimeKind.Utc).AddTicks(7654), null });

            migrationBuilder.UpdateData(
                table: "Shelters",
                keyColumn: "Id",
                keyValue: 1023,
                columns: new[] { "CreatedTime", "LastUpdatedTime", "ShelterName" },
                values: new object[] { new DateTime(2024, 8, 23, 20, 25, 15, 443, DateTimeKind.Utc).AddTicks(7661), new DateTime(2024, 8, 23, 20, 25, 15, 443, DateTimeKind.Utc).AddTicks(7661), null });

            migrationBuilder.UpdateData(
                table: "Shelters",
                keyColumn: "Id",
                keyValue: 1024,
                columns: new[] { "CreatedTime", "LastUpdatedTime", "ShelterName" },
                values: new object[] { new DateTime(2024, 8, 23, 20, 25, 15, 443, DateTimeKind.Utc).AddTicks(7701), new DateTime(2024, 8, 23, 20, 25, 15, 443, DateTimeKind.Utc).AddTicks(7702), null });

            migrationBuilder.UpdateData(
                table: "Shelters",
                keyColumn: "Id",
                keyValue: 1025,
                columns: new[] { "CreatedTime", "LastUpdatedTime", "ShelterName" },
                values: new object[] { new DateTime(2024, 8, 23, 20, 25, 15, 443, DateTimeKind.Utc).AddTicks(7708), new DateTime(2024, 8, 23, 20, 25, 15, 443, DateTimeKind.Utc).AddTicks(7708), null });

            migrationBuilder.UpdateData(
                table: "Shelters",
                keyColumn: "Id",
                keyValue: 1026,
                columns: new[] { "CreatedTime", "LastUpdatedTime", "ShelterName" },
                values: new object[] { new DateTime(2024, 8, 23, 20, 25, 15, 443, DateTimeKind.Utc).AddTicks(7716), new DateTime(2024, 8, 23, 20, 25, 15, 443, DateTimeKind.Utc).AddTicks(7717), null });

            migrationBuilder.UpdateData(
                table: "Shelters",
                keyColumn: "Id",
                keyValue: 1027,
                columns: new[] { "CreatedTime", "LastUpdatedTime", "ShelterName" },
                values: new object[] { new DateTime(2024, 8, 23, 20, 25, 15, 443, DateTimeKind.Utc).AddTicks(7722), new DateTime(2024, 8, 23, 20, 25, 15, 443, DateTimeKind.Utc).AddTicks(7723), null });

            migrationBuilder.UpdateData(
                table: "Shelters",
                keyColumn: "Id",
                keyValue: 1028,
                columns: new[] { "CreatedTime", "LastUpdatedTime", "ShelterName" },
                values: new object[] { new DateTime(2024, 8, 23, 20, 25, 15, 443, DateTimeKind.Utc).AddTicks(7728), new DateTime(2024, 8, 23, 20, 25, 15, 443, DateTimeKind.Utc).AddTicks(7728), null });

            migrationBuilder.UpdateData(
                table: "Shelters",
                keyColumn: "Id",
                keyValue: 1029,
                columns: new[] { "CreatedTime", "LastUpdatedTime", "ShelterName" },
                values: new object[] { new DateTime(2024, 8, 23, 20, 25, 15, 443, DateTimeKind.Utc).AddTicks(7734), new DateTime(2024, 8, 23, 20, 25, 15, 443, DateTimeKind.Utc).AddTicks(7734), null });

            migrationBuilder.UpdateData(
                table: "Shelters",
                keyColumn: "Id",
                keyValue: 1030,
                columns: new[] { "CreatedTime", "LastUpdatedTime", "ShelterName" },
                values: new object[] { new DateTime(2024, 8, 23, 20, 25, 15, 443, DateTimeKind.Utc).AddTicks(7741), new DateTime(2024, 8, 23, 20, 25, 15, 443, DateTimeKind.Utc).AddTicks(7742), null });

            migrationBuilder.UpdateData(
                table: "Shelters",
                keyColumn: "Id",
                keyValue: 1031,
                columns: new[] { "CreatedTime", "LastUpdatedTime", "ShelterName" },
                values: new object[] { new DateTime(2024, 8, 23, 20, 25, 15, 443, DateTimeKind.Utc).AddTicks(7747), new DateTime(2024, 8, 23, 20, 25, 15, 443, DateTimeKind.Utc).AddTicks(7748), null });

            migrationBuilder.UpdateData(
                table: "Shelters",
                keyColumn: "Id",
                keyValue: 1032,
                columns: new[] { "CreatedTime", "LastUpdatedTime", "ShelterName" },
                values: new object[] { new DateTime(2024, 8, 23, 20, 25, 15, 443, DateTimeKind.Utc).AddTicks(7753), new DateTime(2024, 8, 23, 20, 25, 15, 443, DateTimeKind.Utc).AddTicks(7754), null });

            migrationBuilder.UpdateData(
                table: "Shelters",
                keyColumn: "Id",
                keyValue: 1033,
                columns: new[] { "CreatedTime", "LastUpdatedTime", "ShelterName" },
                values: new object[] { new DateTime(2024, 8, 23, 20, 25, 15, 443, DateTimeKind.Utc).AddTicks(7759), new DateTime(2024, 8, 23, 20, 25, 15, 443, DateTimeKind.Utc).AddTicks(7759), null });

            migrationBuilder.UpdateData(
                table: "Shelters",
                keyColumn: "Id",
                keyValue: 1034,
                columns: new[] { "CreatedTime", "LastUpdatedTime", "ShelterName" },
                values: new object[] { new DateTime(2024, 8, 23, 20, 25, 15, 443, DateTimeKind.Utc).AddTicks(7765), new DateTime(2024, 8, 23, 20, 25, 15, 443, DateTimeKind.Utc).AddTicks(7765), null });

            migrationBuilder.UpdateData(
                table: "Shelters",
                keyColumn: "Id",
                keyValue: 1035,
                columns: new[] { "CreatedTime", "LastUpdatedTime", "ShelterName" },
                values: new object[] { new DateTime(2024, 8, 23, 20, 25, 15, 443, DateTimeKind.Utc).AddTicks(7771), new DateTime(2024, 8, 23, 20, 25, 15, 443, DateTimeKind.Utc).AddTicks(7771), null });

            migrationBuilder.UpdateData(
                table: "Shelters",
                keyColumn: "Id",
                keyValue: 1036,
                columns: new[] { "CreatedTime", "LastUpdatedTime", "ShelterName" },
                values: new object[] { new DateTime(2024, 8, 23, 20, 25, 15, 443, DateTimeKind.Utc).AddTicks(7776), new DateTime(2024, 8, 23, 20, 25, 15, 443, DateTimeKind.Utc).AddTicks(7777), null });

            migrationBuilder.UpdateData(
                table: "Shelters",
                keyColumn: "Id",
                keyValue: 1037,
                columns: new[] { "CreatedTime", "LastUpdatedTime", "ShelterName" },
                values: new object[] { new DateTime(2024, 8, 23, 20, 25, 15, 443, DateTimeKind.Utc).AddTicks(7782), new DateTime(2024, 8, 23, 20, 25, 15, 443, DateTimeKind.Utc).AddTicks(7782), null });

            migrationBuilder.UpdateData(
                table: "Shelters",
                keyColumn: "Id",
                keyValue: 1038,
                columns: new[] { "CreatedTime", "LastUpdatedTime", "ShelterName" },
                values: new object[] { new DateTime(2024, 8, 23, 20, 25, 15, 443, DateTimeKind.Utc).AddTicks(7789), new DateTime(2024, 8, 23, 20, 25, 15, 443, DateTimeKind.Utc).AddTicks(7789), null });

            migrationBuilder.UpdateData(
                table: "Shelters",
                keyColumn: "Id",
                keyValue: 1039,
                columns: new[] { "CreatedTime", "LastUpdatedTime", "ShelterName" },
                values: new object[] { new DateTime(2024, 8, 23, 20, 25, 15, 443, DateTimeKind.Utc).AddTicks(7795), new DateTime(2024, 8, 23, 20, 25, 15, 443, DateTimeKind.Utc).AddTicks(7795), null });

            migrationBuilder.UpdateData(
                table: "Shelters",
                keyColumn: "Id",
                keyValue: 1040,
                columns: new[] { "CreatedTime", "LastUpdatedTime", "ShelterName" },
                values: new object[] { new DateTime(2024, 8, 23, 20, 25, 15, 443, DateTimeKind.Utc).AddTicks(7800), new DateTime(2024, 8, 23, 20, 25, 15, 443, DateTimeKind.Utc).AddTicks(7801), null });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "ShelterName",
                table: "Shelters");

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
    }
}
