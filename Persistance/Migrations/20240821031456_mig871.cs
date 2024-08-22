using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Persistance.Migrations
{
    /// <inheritdoc />
    public partial class mig871 : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "Region",
                table: "Locations");

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: 2001,
                columns: new[] { "ConcurrencyStamp", "CreatedTime", "LastUpdatedTime", "RefreshTokenCreateTime" },
                values: new object[] { "adcd001b-06e7-4bc4-ae0c-337900e0d99f", new DateTime(2024, 8, 21, 3, 14, 52, 184, DateTimeKind.Utc).AddTicks(6882), new DateTime(2024, 8, 21, 3, 14, 52, 184, DateTimeKind.Utc).AddTicks(6883), new DateTime(2024, 8, 21, 3, 14, 52, 184, DateTimeKind.Utc).AddTicks(6789) });
    
            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: 2002,
                columns: new[] { "ConcurrencyStamp", "CreatedTime", "LastUpdatedTime", "RefreshTokenCreateTime" },
                values: new object[] { "beb5aa7e-9465-4b8d-ae94-262367c37178", new DateTime(2024, 8, 21, 3, 14, 52, 184, DateTimeKind.Utc).AddTicks(6965), new DateTime(2024, 8, 21, 3, 14, 52, 184, DateTimeKind.Utc).AddTicks(6965), new DateTime(2024, 8, 21, 3, 14, 52, 184, DateTimeKind.Utc).AddTicks(6958) });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: 2003,
                columns: new[] { "ConcurrencyStamp", "CreatedTime", "LastUpdatedTime", "RefreshTokenCreateTime" },
                values: new object[] { "4af7c771-f553-4485-99d3-12b64f53f48f", new DateTime(2024, 8, 21, 3, 14, 52, 184, DateTimeKind.Utc).AddTicks(7047), new DateTime(2024, 8, 21, 3, 14, 52, 184, DateTimeKind.Utc).AddTicks(7047), new DateTime(2024, 8, 21, 3, 14, 52, 184, DateTimeKind.Utc).AddTicks(7043) });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: 2004,
                columns: new[] { "ConcurrencyStamp", "CreatedTime", "LastUpdatedTime", "RefreshTokenCreateTime" },
                values: new object[] { "d7c661aa-8938-4fcd-bed1-44ba3f6f75c7", new DateTime(2024, 8, 21, 3, 14, 52, 184, DateTimeKind.Utc).AddTicks(7074), new DateTime(2024, 8, 21, 3, 14, 52, 184, DateTimeKind.Utc).AddTicks(7074), new DateTime(2024, 8, 21, 3, 14, 52, 184, DateTimeKind.Utc).AddTicks(7070) });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: 2005,
                columns: new[] { "ConcurrencyStamp", "CreatedTime", "LastUpdatedTime", "RefreshTokenCreateTime" },
                values: new object[] { "5e02ffe4-b471-4d7f-b173-b2434990fa8b", new DateTime(2024, 8, 21, 3, 14, 52, 184, DateTimeKind.Utc).AddTicks(7086), new DateTime(2024, 8, 21, 3, 14, 52, 184, DateTimeKind.Utc).AddTicks(7086), new DateTime(2024, 8, 21, 3, 14, 52, 184, DateTimeKind.Utc).AddTicks(7083) });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: 2006,
                columns: new[] { "ConcurrencyStamp", "CreatedTime", "LastUpdatedTime", "RefreshTokenCreateTime" },
                values: new object[] { "769697ac-4140-4aa9-bcc5-f9bed133ee9e", new DateTime(2024, 8, 21, 3, 14, 52, 184, DateTimeKind.Utc).AddTicks(7149), new DateTime(2024, 8, 21, 3, 14, 52, 184, DateTimeKind.Utc).AddTicks(7150), new DateTime(2024, 8, 21, 3, 14, 52, 184, DateTimeKind.Utc).AddTicks(7130) });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: 2007,
                columns: new[] { "ConcurrencyStamp", "CreatedTime", "LastUpdatedTime", "RefreshTokenCreateTime" },
                values: new object[] { "9a8359d8-0079-4377-9558-e26abe63c709", new DateTime(2024, 8, 21, 3, 14, 52, 184, DateTimeKind.Utc).AddTicks(7163), new DateTime(2024, 8, 21, 3, 14, 52, 184, DateTimeKind.Utc).AddTicks(7163), new DateTime(2024, 8, 21, 3, 14, 52, 184, DateTimeKind.Utc).AddTicks(7159) });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: 2008,
                columns: new[] { "ConcurrencyStamp", "CreatedTime", "LastUpdatedTime", "RefreshTokenCreateTime" },
                values: new object[] { "85545ade-5390-4876-aa73-0082348ec2e5", new DateTime(2024, 8, 21, 3, 14, 52, 184, DateTimeKind.Utc).AddTicks(7175), new DateTime(2024, 8, 21, 3, 14, 52, 184, DateTimeKind.Utc).AddTicks(7175), new DateTime(2024, 8, 21, 3, 14, 52, 184, DateTimeKind.Utc).AddTicks(7172) });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: 2009,
                columns: new[] { "ConcurrencyStamp", "CreatedTime", "LastUpdatedTime", "RefreshTokenCreateTime" },
                values: new object[] { "5c19094f-135a-46da-bd07-fe0704dbc625", new DateTime(2024, 8, 21, 3, 14, 52, 184, DateTimeKind.Utc).AddTicks(7186), new DateTime(2024, 8, 21, 3, 14, 52, 184, DateTimeKind.Utc).AddTicks(7187), new DateTime(2024, 8, 21, 3, 14, 52, 184, DateTimeKind.Utc).AddTicks(7183) });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: 2010,
                columns: new[] { "ConcurrencyStamp", "CreatedTime", "LastUpdatedTime", "RefreshTokenCreateTime" },
                values: new object[] { "a5690611-4fae-4eb8-b976-203328be9b5e", new DateTime(2024, 8, 21, 3, 14, 52, 184, DateTimeKind.Utc).AddTicks(7200), new DateTime(2024, 8, 21, 3, 14, 52, 184, DateTimeKind.Utc).AddTicks(7200), new DateTime(2024, 8, 21, 3, 14, 52, 184, DateTimeKind.Utc).AddTicks(7197) });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: 2011,
                columns: new[] { "ConcurrencyStamp", "CreatedTime", "LastUpdatedTime", "RefreshTokenCreateTime" },
                values: new object[] { "5c36cfc5-a785-4cf4-a906-f514ee26c900", new DateTime(2024, 8, 21, 3, 14, 52, 184, DateTimeKind.Utc).AddTicks(7217), new DateTime(2024, 8, 21, 3, 14, 52, 184, DateTimeKind.Utc).AddTicks(7218), new DateTime(2024, 8, 21, 3, 14, 52, 184, DateTimeKind.Utc).AddTicks(7214) });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: 2012,
                columns: new[] { "ConcurrencyStamp", "CreatedTime", "LastUpdatedTime", "RefreshTokenCreateTime" },
                values: new object[] { "92d2516c-d5d9-46c8-a383-d506e647d5b0", new DateTime(2024, 8, 21, 3, 14, 52, 184, DateTimeKind.Utc).AddTicks(7270), new DateTime(2024, 8, 21, 3, 14, 52, 184, DateTimeKind.Utc).AddTicks(7270), new DateTime(2024, 8, 21, 3, 14, 52, 184, DateTimeKind.Utc).AddTicks(7227) });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: 2013,
                columns: new[] { "ConcurrencyStamp", "CreatedTime", "LastUpdatedTime", "RefreshTokenCreateTime" },
                values: new object[] { "2b625c9b-92b2-406d-87f4-57e43e678f98", new DateTime(2024, 8, 21, 3, 14, 52, 184, DateTimeKind.Utc).AddTicks(7284), new DateTime(2024, 8, 21, 3, 14, 52, 184, DateTimeKind.Utc).AddTicks(7284), new DateTime(2024, 8, 21, 3, 14, 52, 184, DateTimeKind.Utc).AddTicks(7280) });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: 2014,
                columns: new[] { "ConcurrencyStamp", "CreatedTime", "LastUpdatedTime", "RefreshTokenCreateTime" },
                values: new object[] { "400afd42-16fa-4232-8cbe-378ef5b8a547", new DateTime(2024, 8, 21, 3, 14, 52, 184, DateTimeKind.Utc).AddTicks(7301), new DateTime(2024, 8, 21, 3, 14, 52, 184, DateTimeKind.Utc).AddTicks(7301), new DateTime(2024, 8, 21, 3, 14, 52, 184, DateTimeKind.Utc).AddTicks(7293) });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: 2015,
                columns: new[] { "ConcurrencyStamp", "CreatedTime", "LastUpdatedTime", "RefreshTokenCreateTime" },
                values: new object[] { "2edf7a24-e10c-4d22-a5d1-4dd761e40d09", new DateTime(2024, 8, 21, 3, 14, 52, 184, DateTimeKind.Utc).AddTicks(7323), new DateTime(2024, 8, 21, 3, 14, 52, 184, DateTimeKind.Utc).AddTicks(7324), new DateTime(2024, 8, 21, 3, 14, 52, 184, DateTimeKind.Utc).AddTicks(7310) });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: 2016,
                columns: new[] { "ConcurrencyStamp", "CreatedTime", "LastUpdatedTime", "RefreshTokenCreateTime" },
                values: new object[] { "c97cdf3f-346b-410c-b4e7-e7fbc13dea4f", new DateTime(2024, 8, 21, 3, 14, 52, 184, DateTimeKind.Utc).AddTicks(7337), new DateTime(2024, 8, 21, 3, 14, 52, 184, DateTimeKind.Utc).AddTicks(7337), new DateTime(2024, 8, 21, 3, 14, 52, 184, DateTimeKind.Utc).AddTicks(7333) });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: 2017,
                columns: new[] { "ConcurrencyStamp", "CreatedTime", "LastUpdatedTime", "RefreshTokenCreateTime" },
                values: new object[] { "be9f75a8-e4cb-49a9-b1f0-84b01340f448", new DateTime(2024, 8, 21, 3, 14, 52, 184, DateTimeKind.Utc).AddTicks(7349), new DateTime(2024, 8, 21, 3, 14, 52, 184, DateTimeKind.Utc).AddTicks(7350), new DateTime(2024, 8, 21, 3, 14, 52, 184, DateTimeKind.Utc).AddTicks(7346) });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: 2018,
                columns: new[] { "ConcurrencyStamp", "CreatedTime", "LastUpdatedTime", "RefreshTokenCreateTime" },
                values: new object[] { "92ba8828-dc7f-4c10-b04c-58e880f61931", new DateTime(2024, 8, 21, 3, 14, 52, 184, DateTimeKind.Utc).AddTicks(7363), new DateTime(2024, 8, 21, 3, 14, 52, 184, DateTimeKind.Utc).AddTicks(7364), new DateTime(2024, 8, 21, 3, 14, 52, 184, DateTimeKind.Utc).AddTicks(7360) });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: 2019,
                columns: new[] { "ConcurrencyStamp", "CreatedTime", "LastUpdatedTime", "RefreshTokenCreateTime" },
                values: new object[] { "b0e9d10c-b316-46ee-aa46-686278b00b68", new DateTime(2024, 8, 21, 3, 14, 52, 184, DateTimeKind.Utc).AddTicks(7376), new DateTime(2024, 8, 21, 3, 14, 52, 184, DateTimeKind.Utc).AddTicks(7376), new DateTime(2024, 8, 21, 3, 14, 52, 184, DateTimeKind.Utc).AddTicks(7373) });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: 2020,
                columns: new[] { "ConcurrencyStamp", "CreatedTime", "LastUpdatedTime", "RefreshTokenCreateTime" },
                values: new object[] { "ed928e39-cfad-4984-8b5c-f03ba357d234", new DateTime(2024, 8, 21, 3, 14, 52, 184, DateTimeKind.Utc).AddTicks(7388), new DateTime(2024, 8, 21, 3, 14, 52, 184, DateTimeKind.Utc).AddTicks(7388), new DateTime(2024, 8, 21, 3, 14, 52, 184, DateTimeKind.Utc).AddTicks(7384) });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: 2021,
                columns: new[] { "ConcurrencyStamp", "CreatedTime", "LastUpdatedTime", "RefreshTokenCreateTime" },
                values: new object[] { "177c0874-9d06-4c4e-851f-3311fe822348", new DateTime(2024, 8, 21, 3, 14, 52, 184, DateTimeKind.Utc).AddTicks(7400), new DateTime(2024, 8, 21, 3, 14, 52, 184, DateTimeKind.Utc).AddTicks(7400), new DateTime(2024, 8, 21, 3, 14, 52, 184, DateTimeKind.Utc).AddTicks(7397) });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: 2022,
                columns: new[] { "ConcurrencyStamp", "CreatedTime", "LastUpdatedTime", "RefreshTokenCreateTime" },
                values: new object[] { "25fd6860-0a87-4400-bbfe-56296b96ec83", new DateTime(2024, 8, 21, 3, 14, 52, 184, DateTimeKind.Utc).AddTicks(7448), new DateTime(2024, 8, 21, 3, 14, 52, 184, DateTimeKind.Utc).AddTicks(7449), new DateTime(2024, 8, 21, 3, 14, 52, 184, DateTimeKind.Utc).AddTicks(7442) });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: 2023,
                columns: new[] { "ConcurrencyStamp", "CreatedTime", "LastUpdatedTime", "RefreshTokenCreateTime" },
                values: new object[] { "ab72230f-1cfe-42bc-8f78-948d83d19ee1", new DateTime(2024, 8, 21, 3, 14, 52, 184, DateTimeKind.Utc).AddTicks(7463), new DateTime(2024, 8, 21, 3, 14, 52, 184, DateTimeKind.Utc).AddTicks(7463), new DateTime(2024, 8, 21, 3, 14, 52, 184, DateTimeKind.Utc).AddTicks(7459) });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: 2024,
                columns: new[] { "ConcurrencyStamp", "CreatedTime", "LastUpdatedTime", "RefreshTokenCreateTime" },
                values: new object[] { "c84e00f7-3924-4492-a976-ff30b80a29e5", new DateTime(2024, 8, 21, 3, 14, 52, 184, DateTimeKind.Utc).AddTicks(7476), new DateTime(2024, 8, 21, 3, 14, 52, 184, DateTimeKind.Utc).AddTicks(7476), new DateTime(2024, 8, 21, 3, 14, 52, 184, DateTimeKind.Utc).AddTicks(7472) });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: 2025,
                columns: new[] { "ConcurrencyStamp", "CreatedTime", "LastUpdatedTime", "RefreshTokenCreateTime" },
                values: new object[] { "7ccc89a7-4748-40a3-83a6-9b1b905a8574", new DateTime(2024, 8, 21, 3, 14, 52, 184, DateTimeKind.Utc).AddTicks(7488), new DateTime(2024, 8, 21, 3, 14, 52, 184, DateTimeKind.Utc).AddTicks(7489), new DateTime(2024, 8, 21, 3, 14, 52, 184, DateTimeKind.Utc).AddTicks(7485) });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: 2026,
                columns: new[] { "ConcurrencyStamp", "CreatedTime", "LastUpdatedTime", "RefreshTokenCreateTime" },
                values: new object[] { "a3f2d773-125d-4e1e-8a26-002314ca67e8", new DateTime(2024, 8, 21, 3, 14, 52, 184, DateTimeKind.Utc).AddTicks(7502), new DateTime(2024, 8, 21, 3, 14, 52, 184, DateTimeKind.Utc).AddTicks(7502), new DateTime(2024, 8, 21, 3, 14, 52, 184, DateTimeKind.Utc).AddTicks(7499) });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: 2027,
                columns: new[] { "ConcurrencyStamp", "CreatedTime", "LastUpdatedTime", "RefreshTokenCreateTime" },
                values: new object[] { "6a1a14d7-6f52-4d93-86b5-c10d2b8d27a5", new DateTime(2024, 8, 21, 3, 14, 52, 184, DateTimeKind.Utc).AddTicks(7515), new DateTime(2024, 8, 21, 3, 14, 52, 184, DateTimeKind.Utc).AddTicks(7516), new DateTime(2024, 8, 21, 3, 14, 52, 184, DateTimeKind.Utc).AddTicks(7512) });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: 2028,
                columns: new[] { "ConcurrencyStamp", "CreatedTime", "LastUpdatedTime", "RefreshTokenCreateTime" },
                values: new object[] { "8b19c8e7-1e62-43ca-be10-1479d3a2ace2", new DateTime(2024, 8, 21, 3, 14, 52, 184, DateTimeKind.Utc).AddTicks(7528), new DateTime(2024, 8, 21, 3, 14, 52, 184, DateTimeKind.Utc).AddTicks(7528), new DateTime(2024, 8, 21, 3, 14, 52, 184, DateTimeKind.Utc).AddTicks(7524) });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: 2029,
                columns: new[] { "ConcurrencyStamp", "CreatedTime", "LastUpdatedTime", "RefreshTokenCreateTime" },
                values: new object[] { "5bc2e1a6-eda3-46fc-b04d-3ee7056b01ec", new DateTime(2024, 8, 21, 3, 14, 52, 184, DateTimeKind.Utc).AddTicks(7541), new DateTime(2024, 8, 21, 3, 14, 52, 184, DateTimeKind.Utc).AddTicks(7541), new DateTime(2024, 8, 21, 3, 14, 52, 184, DateTimeKind.Utc).AddTicks(7538) });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: 2030,
                columns: new[] { "ConcurrencyStamp", "CreatedTime", "LastUpdatedTime", "RefreshTokenCreateTime" },
                values: new object[] { "5735f637-1233-49f5-b2b6-49e588665250", new DateTime(2024, 8, 21, 3, 14, 52, 184, DateTimeKind.Utc).AddTicks(7727), new DateTime(2024, 8, 21, 3, 14, 52, 184, DateTimeKind.Utc).AddTicks(7728), new DateTime(2024, 8, 21, 3, 14, 52, 184, DateTimeKind.Utc).AddTicks(7551) });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: 2031,
                columns: new[] { "ConcurrencyStamp", "CreatedTime", "LastUpdatedTime", "RefreshTokenCreateTime" },
                values: new object[] { "2dd2edc6-1876-47ad-a063-6fbf7a197a6b", new DateTime(2024, 8, 21, 3, 14, 52, 184, DateTimeKind.Utc).AddTicks(7807), new DateTime(2024, 8, 21, 3, 14, 52, 184, DateTimeKind.Utc).AddTicks(7808), new DateTime(2024, 8, 21, 3, 14, 52, 184, DateTimeKind.Utc).AddTicks(7802) });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: 2032,
                columns: new[] { "ConcurrencyStamp", "CreatedTime", "LastUpdatedTime", "RefreshTokenCreateTime" },
                values: new object[] { "e7b1ab5c-6831-4f9c-9fe5-265d55885678", new DateTime(2024, 8, 21, 3, 14, 52, 184, DateTimeKind.Utc).AddTicks(7821), new DateTime(2024, 8, 21, 3, 14, 52, 184, DateTimeKind.Utc).AddTicks(7822), new DateTime(2024, 8, 21, 3, 14, 52, 184, DateTimeKind.Utc).AddTicks(7818) });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: 2033,
                columns: new[] { "ConcurrencyStamp", "CreatedTime", "LastUpdatedTime", "RefreshTokenCreateTime" },
                values: new object[] { "9fb18136-2b30-4831-86f4-5cc22a6cdda5", new DateTime(2024, 8, 21, 3, 14, 52, 184, DateTimeKind.Utc).AddTicks(7835), new DateTime(2024, 8, 21, 3, 14, 52, 184, DateTimeKind.Utc).AddTicks(7835), new DateTime(2024, 8, 21, 3, 14, 52, 184, DateTimeKind.Utc).AddTicks(7831) });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: 2034,
                columns: new[] { "ConcurrencyStamp", "CreatedTime", "LastUpdatedTime", "RefreshTokenCreateTime" },
                values: new object[] { "cb66bece-7a7b-4063-a248-88279621f60c", new DateTime(2024, 8, 21, 3, 14, 52, 184, DateTimeKind.Utc).AddTicks(7858), new DateTime(2024, 8, 21, 3, 14, 52, 184, DateTimeKind.Utc).AddTicks(7858), new DateTime(2024, 8, 21, 3, 14, 52, 184, DateTimeKind.Utc).AddTicks(7854) });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: 2035,
                columns: new[] { "ConcurrencyStamp", "CreatedTime", "LastUpdatedTime", "RefreshTokenCreateTime" },
                values: new object[] { "b03cd90b-5f66-4ab7-80e3-37595cbe67cc", new DateTime(2024, 8, 21, 3, 14, 52, 184, DateTimeKind.Utc).AddTicks(7872), new DateTime(2024, 8, 21, 3, 14, 52, 184, DateTimeKind.Utc).AddTicks(7872), new DateTime(2024, 8, 21, 3, 14, 52, 184, DateTimeKind.Utc).AddTicks(7868) });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: 2036,
                columns: new[] { "ConcurrencyStamp", "CreatedTime", "LastUpdatedTime", "RefreshTokenCreateTime" },
                values: new object[] { "6d246317-4310-4068-9794-02adefbe6ad2", new DateTime(2024, 8, 21, 3, 14, 52, 184, DateTimeKind.Utc).AddTicks(7885), new DateTime(2024, 8, 21, 3, 14, 52, 184, DateTimeKind.Utc).AddTicks(7886), new DateTime(2024, 8, 21, 3, 14, 52, 184, DateTimeKind.Utc).AddTicks(7882) });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: 2037,
                columns: new[] { "ConcurrencyStamp", "CreatedTime", "LastUpdatedTime", "RefreshTokenCreateTime" },
                values: new object[] { "63a8750a-6e97-4a3a-a6d6-02d1c7e18db0", new DateTime(2024, 8, 21, 3, 14, 52, 184, DateTimeKind.Utc).AddTicks(7910), new DateTime(2024, 8, 21, 3, 14, 52, 184, DateTimeKind.Utc).AddTicks(7910), new DateTime(2024, 8, 21, 3, 14, 52, 184, DateTimeKind.Utc).AddTicks(7906) });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: 2038,
                columns: new[] { "ConcurrencyStamp", "CreatedTime", "LastUpdatedTime", "RefreshTokenCreateTime" },
                values: new object[] { "9ed9f071-be27-42e5-8a32-e148d90c418c", new DateTime(2024, 8, 21, 3, 14, 52, 184, DateTimeKind.Utc).AddTicks(7941), new DateTime(2024, 8, 21, 3, 14, 52, 184, DateTimeKind.Utc).AddTicks(7942), new DateTime(2024, 8, 21, 3, 14, 52, 184, DateTimeKind.Utc).AddTicks(7920) });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: 2039,
                columns: new[] { "ConcurrencyStamp", "CreatedTime", "LastUpdatedTime", "RefreshTokenCreateTime" },
                values: new object[] { "ba3a8433-a26f-498f-a380-07f4578648cb", new DateTime(2024, 8, 21, 3, 14, 52, 184, DateTimeKind.Utc).AddTicks(8028), new DateTime(2024, 8, 21, 3, 14, 52, 184, DateTimeKind.Utc).AddTicks(8028), new DateTime(2024, 8, 21, 3, 14, 52, 184, DateTimeKind.Utc).AddTicks(8024) });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: 2040,
                columns: new[] { "ConcurrencyStamp", "CreatedTime", "LastUpdatedTime", "RefreshTokenCreateTime" },
                values: new object[] { "889ac704-9051-491a-8dca-e258bd7054fe", new DateTime(2024, 8, 21, 3, 14, 52, 184, DateTimeKind.Utc).AddTicks(8043), new DateTime(2024, 8, 21, 3, 14, 52, 184, DateTimeKind.Utc).AddTicks(8043), new DateTime(2024, 8, 21, 3, 14, 52, 184, DateTimeKind.Utc).AddTicks(8039) });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: 2041,
                columns: new[] { "ConcurrencyStamp", "CreatedTime", "LastUpdatedTime", "RefreshTokenCreateTime" },
                values: new object[] { "2818adcf-4a65-44ad-b0f9-8a8c54c9d2bb", new DateTime(2024, 8, 21, 3, 14, 52, 184, DateTimeKind.Utc).AddTicks(8056), new DateTime(2024, 8, 21, 3, 14, 52, 184, DateTimeKind.Utc).AddTicks(8057), new DateTime(2024, 8, 21, 3, 14, 52, 184, DateTimeKind.Utc).AddTicks(8053) });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: 2042,
                columns: new[] { "ConcurrencyStamp", "CreatedTime", "LastUpdatedTime", "RefreshTokenCreateTime" },
                values: new object[] { "27bd5051-7df6-4347-b000-6efe46ad8377", new DateTime(2024, 8, 21, 3, 14, 52, 184, DateTimeKind.Utc).AddTicks(8076), new DateTime(2024, 8, 21, 3, 14, 52, 184, DateTimeKind.Utc).AddTicks(8076), new DateTime(2024, 8, 21, 3, 14, 52, 184, DateTimeKind.Utc).AddTicks(8073) });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: 2043,
                columns: new[] { "ConcurrencyStamp", "CreatedTime", "LastUpdatedTime", "RefreshTokenCreateTime" },
                values: new object[] { "bf2839d2-f754-473e-8a33-922997d1b408", new DateTime(2024, 8, 21, 3, 14, 52, 184, DateTimeKind.Utc).AddTicks(8090), new DateTime(2024, 8, 21, 3, 14, 52, 184, DateTimeKind.Utc).AddTicks(8090), new DateTime(2024, 8, 21, 3, 14, 52, 184, DateTimeKind.Utc).AddTicks(8087) });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: 2044,
                columns: new[] { "ConcurrencyStamp", "CreatedTime", "LastUpdatedTime", "RefreshTokenCreateTime" },
                values: new object[] { "d4955782-b8b0-483b-97ab-1a97523db108", new DateTime(2024, 8, 21, 3, 14, 52, 184, DateTimeKind.Utc).AddTicks(8103), new DateTime(2024, 8, 21, 3, 14, 52, 184, DateTimeKind.Utc).AddTicks(8103), new DateTime(2024, 8, 21, 3, 14, 52, 184, DateTimeKind.Utc).AddTicks(8099) });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: 2045,
                columns: new[] { "ConcurrencyStamp", "CreatedTime", "LastUpdatedTime", "RefreshTokenCreateTime" },
                values: new object[] { "1ddc065f-5d1b-4059-b40e-2f22976b70de", new DateTime(2024, 8, 21, 3, 14, 52, 184, DateTimeKind.Utc).AddTicks(8115), new DateTime(2024, 8, 21, 3, 14, 52, 184, DateTimeKind.Utc).AddTicks(8116), new DateTime(2024, 8, 21, 3, 14, 52, 184, DateTimeKind.Utc).AddTicks(8112) });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: 2046,
                columns: new[] { "ConcurrencyStamp", "CreatedTime", "LastUpdatedTime", "RefreshTokenCreateTime" },
                values: new object[] { "9cea04bc-625e-4875-938c-3df7aee63ff5", new DateTime(2024, 8, 21, 3, 14, 52, 184, DateTimeKind.Utc).AddTicks(8132), new DateTime(2024, 8, 21, 3, 14, 52, 184, DateTimeKind.Utc).AddTicks(8132), new DateTime(2024, 8, 21, 3, 14, 52, 184, DateTimeKind.Utc).AddTicks(8124) });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: 2047,
                columns: new[] { "ConcurrencyStamp", "CreatedTime", "LastUpdatedTime", "RefreshTokenCreateTime" },
                values: new object[] { "8feca3e5-da89-4e5f-8b75-3b116e9087e4", new DateTime(2024, 8, 21, 3, 14, 52, 184, DateTimeKind.Utc).AddTicks(8144), new DateTime(2024, 8, 21, 3, 14, 52, 184, DateTimeKind.Utc).AddTicks(8145), new DateTime(2024, 8, 21, 3, 14, 52, 184, DateTimeKind.Utc).AddTicks(8141) });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: 2048,
                columns: new[] { "ConcurrencyStamp", "CreatedTime", "LastUpdatedTime", "RefreshTokenCreateTime" },
                values: new object[] { "3029ed03-1fa0-4ceb-8594-5f5a73ded22b", new DateTime(2024, 8, 21, 3, 14, 52, 184, DateTimeKind.Utc).AddTicks(8157), new DateTime(2024, 8, 21, 3, 14, 52, 184, DateTimeKind.Utc).AddTicks(8157), new DateTime(2024, 8, 21, 3, 14, 52, 184, DateTimeKind.Utc).AddTicks(8153) });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: 2049,
                columns: new[] { "ConcurrencyStamp", "CreatedTime", "LastUpdatedTime", "RefreshTokenCreateTime" },
                values: new object[] { "af8e9abe-ddad-4042-abbc-d42c84523ea8", new DateTime(2024, 8, 21, 3, 14, 52, 184, DateTimeKind.Utc).AddTicks(8211), new DateTime(2024, 8, 21, 3, 14, 52, 184, DateTimeKind.Utc).AddTicks(8211), new DateTime(2024, 8, 21, 3, 14, 52, 184, DateTimeKind.Utc).AddTicks(8207) });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: 2050,
                columns: new[] { "ConcurrencyStamp", "CreatedTime", "LastUpdatedTime", "RefreshTokenCreateTime" },
                values: new object[] { "bdfdf298-8abc-4fb8-bb2a-34ea4a7d2fcf", new DateTime(2024, 8, 21, 3, 14, 52, 184, DateTimeKind.Utc).AddTicks(8223), new DateTime(2024, 8, 21, 3, 14, 52, 184, DateTimeKind.Utc).AddTicks(8224), new DateTime(2024, 8, 21, 3, 14, 52, 184, DateTimeKind.Utc).AddTicks(8220) });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: 2051,
                columns: new[] { "ConcurrencyStamp", "CreatedTime", "LastUpdatedTime", "RefreshTokenCreateTime" },
                values: new object[] { "f88fe15b-f87b-4969-923e-e87085195a59", new DateTime(2024, 8, 21, 3, 14, 52, 184, DateTimeKind.Utc).AddTicks(8236), new DateTime(2024, 8, 21, 3, 14, 52, 184, DateTimeKind.Utc).AddTicks(8237), new DateTime(2024, 8, 21, 3, 14, 52, 184, DateTimeKind.Utc).AddTicks(8233) });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: 2052,
                columns: new[] { "ConcurrencyStamp", "CreatedTime", "LastUpdatedTime", "RefreshTokenCreateTime" },
                values: new object[] { "e15af4fb-20ae-438b-8834-5d6ed5c29cc6", new DateTime(2024, 8, 21, 3, 14, 52, 184, DateTimeKind.Utc).AddTicks(8249), new DateTime(2024, 8, 21, 3, 14, 52, 184, DateTimeKind.Utc).AddTicks(8249), new DateTime(2024, 8, 21, 3, 14, 52, 184, DateTimeKind.Utc).AddTicks(8245) });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: 2053,
                columns: new[] { "ConcurrencyStamp", "CreatedTime", "LastUpdatedTime", "RefreshTokenCreateTime" },
                values: new object[] { "f91f4f12-dc1b-462d-bf59-53b8a5bbb5f5", new DateTime(2024, 8, 21, 3, 14, 52, 184, DateTimeKind.Utc).AddTicks(8263), new DateTime(2024, 8, 21, 3, 14, 52, 184, DateTimeKind.Utc).AddTicks(8263), new DateTime(2024, 8, 21, 3, 14, 52, 184, DateTimeKind.Utc).AddTicks(8259) });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: 2054,
                columns: new[] { "ConcurrencyStamp", "CreatedTime", "LastUpdatedTime", "RefreshTokenCreateTime" },
                values: new object[] { "82aebce1-165c-4e55-8bc3-f4932310b6e8", new DateTime(2024, 8, 21, 3, 14, 52, 184, DateTimeKind.Utc).AddTicks(8277), new DateTime(2024, 8, 21, 3, 14, 52, 184, DateTimeKind.Utc).AddTicks(8278), new DateTime(2024, 8, 21, 3, 14, 52, 184, DateTimeKind.Utc).AddTicks(8271) });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: 2055,
                columns: new[] { "ConcurrencyStamp", "CreatedTime", "LastUpdatedTime", "RefreshTokenCreateTime" },
                values: new object[] { "0e3449cb-ee47-4891-b038-1863fb04ff5c", new DateTime(2024, 8, 21, 3, 14, 52, 184, DateTimeKind.Utc).AddTicks(8290), new DateTime(2024, 8, 21, 3, 14, 52, 184, DateTimeKind.Utc).AddTicks(8290), new DateTime(2024, 8, 21, 3, 14, 52, 184, DateTimeKind.Utc).AddTicks(8287) });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: 2056,
                columns: new[] { "ConcurrencyStamp", "CreatedTime", "LastUpdatedTime", "RefreshTokenCreateTime" },
                values: new object[] { "09365b1b-dac8-41a3-9d08-af706786a42f", new DateTime(2024, 8, 21, 3, 14, 52, 184, DateTimeKind.Utc).AddTicks(8302), new DateTime(2024, 8, 21, 3, 14, 52, 184, DateTimeKind.Utc).AddTicks(8303), new DateTime(2024, 8, 21, 3, 14, 52, 184, DateTimeKind.Utc).AddTicks(8299) });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: 2057,
                columns: new[] { "ConcurrencyStamp", "CreatedTime", "LastUpdatedTime", "RefreshTokenCreateTime" },
                values: new object[] { "ccf22b11-b3e7-4641-9dfe-4491d459d9a3", new DateTime(2024, 8, 21, 3, 14, 52, 184, DateTimeKind.Utc).AddTicks(8314), new DateTime(2024, 8, 21, 3, 14, 52, 184, DateTimeKind.Utc).AddTicks(8314), new DateTime(2024, 8, 21, 3, 14, 52, 184, DateTimeKind.Utc).AddTicks(8311) });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: 2058,
                columns: new[] { "ConcurrencyStamp", "CreatedTime", "LastUpdatedTime", "RefreshTokenCreateTime" },
                values: new object[] { "99d18073-8256-45b8-aced-6058d4289d1b", new DateTime(2024, 8, 21, 3, 14, 52, 184, DateTimeKind.Utc).AddTicks(8327), new DateTime(2024, 8, 21, 3, 14, 52, 184, DateTimeKind.Utc).AddTicks(8328), new DateTime(2024, 8, 21, 3, 14, 52, 184, DateTimeKind.Utc).AddTicks(8324) });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: 2059,
                columns: new[] { "ConcurrencyStamp", "CreatedTime", "LastUpdatedTime", "RefreshTokenCreateTime" },
                values: new object[] { "5f819917-49a2-473d-bd14-dea17f46af12", new DateTime(2024, 8, 21, 3, 14, 52, 184, DateTimeKind.Utc).AddTicks(8382), new DateTime(2024, 8, 21, 3, 14, 52, 184, DateTimeKind.Utc).AddTicks(8383), new DateTime(2024, 8, 21, 3, 14, 52, 184, DateTimeKind.Utc).AddTicks(8378) });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: 2060,
                columns: new[] { "ConcurrencyStamp", "CreatedTime", "LastUpdatedTime", "RefreshTokenCreateTime" },
                values: new object[] { "d026b45d-57ab-4e91-870d-8e91d52dd053", new DateTime(2024, 8, 21, 3, 14, 52, 184, DateTimeKind.Utc).AddTicks(8395), new DateTime(2024, 8, 21, 3, 14, 52, 184, DateTimeKind.Utc).AddTicks(8395), new DateTime(2024, 8, 21, 3, 14, 52, 184, DateTimeKind.Utc).AddTicks(8391) });

            migrationBuilder.UpdateData(
                table: "Breeds",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedTime",
                value: new DateTime(2024, 8, 21, 7, 14, 52, 169, DateTimeKind.Local).AddTicks(5469));

            migrationBuilder.UpdateData(
                table: "Breeds",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreatedTime",
                value: new DateTime(2024, 8, 21, 7, 14, 52, 169, DateTimeKind.Local).AddTicks(5479));

            migrationBuilder.UpdateData(
                table: "Breeds",
                keyColumn: "Id",
                keyValue: 3,
                column: "CreatedTime",
                value: new DateTime(2024, 8, 21, 7, 14, 52, 169, DateTimeKind.Local).AddTicks(5481));

            migrationBuilder.UpdateData(
                table: "Breeds",
                keyColumn: "Id",
                keyValue: 4,
                column: "CreatedTime",
                value: new DateTime(2024, 8, 21, 7, 14, 52, 169, DateTimeKind.Local).AddTicks(5482));

            migrationBuilder.UpdateData(
                table: "Breeds",
                keyColumn: "Id",
                keyValue: 5,
                column: "CreatedTime",
                value: new DateTime(2024, 8, 21, 7, 14, 52, 169, DateTimeKind.Local).AddTicks(5483));

            migrationBuilder.UpdateData(
                table: "Breeds",
                keyColumn: "Id",
                keyValue: 6,
                column: "CreatedTime",
                value: new DateTime(2024, 8, 21, 7, 14, 52, 169, DateTimeKind.Local).AddTicks(5485));

            migrationBuilder.UpdateData(
                table: "Breeds",
                keyColumn: "Id",
                keyValue: 7,
                column: "CreatedTime",
                value: new DateTime(2024, 8, 21, 7, 14, 52, 169, DateTimeKind.Local).AddTicks(5486));

            migrationBuilder.UpdateData(
                table: "Breeds",
                keyColumn: "Id",
                keyValue: 8,
                column: "CreatedTime",
                value: new DateTime(2024, 8, 21, 7, 14, 52, 169, DateTimeKind.Local).AddTicks(5487));

            migrationBuilder.UpdateData(
                table: "Breeds",
                keyColumn: "Id",
                keyValue: 9,
                column: "CreatedTime",
                value: new DateTime(2024, 8, 21, 7, 14, 52, 169, DateTimeKind.Local).AddTicks(5489));

            migrationBuilder.UpdateData(
                table: "Breeds",
                keyColumn: "Id",
                keyValue: 10,
                column: "CreatedTime",
                value: new DateTime(2024, 8, 21, 7, 14, 52, 169, DateTimeKind.Local).AddTicks(5490));

            migrationBuilder.UpdateData(
                table: "Breeds",
                keyColumn: "Id",
                keyValue: 11,
                column: "CreatedTime",
                value: new DateTime(2024, 8, 21, 7, 14, 52, 169, DateTimeKind.Local).AddTicks(5492));

            migrationBuilder.UpdateData(
                table: "Breeds",
                keyColumn: "Id",
                keyValue: 12,
                column: "CreatedTime",
                value: new DateTime(2024, 8, 21, 7, 14, 52, 169, DateTimeKind.Local).AddTicks(5493));

            migrationBuilder.UpdateData(
                table: "Breeds",
                keyColumn: "Id",
                keyValue: 13,
                column: "CreatedTime",
                value: new DateTime(2024, 8, 21, 7, 14, 52, 169, DateTimeKind.Local).AddTicks(5494));

            migrationBuilder.UpdateData(
                table: "Breeds",
                keyColumn: "Id",
                keyValue: 14,
                column: "CreatedTime",
                value: new DateTime(2024, 8, 21, 7, 14, 52, 169, DateTimeKind.Local).AddTicks(5496));

            migrationBuilder.UpdateData(
                table: "Breeds",
                keyColumn: "Id",
                keyValue: 15,
                column: "CreatedTime",
                value: new DateTime(2024, 8, 21, 7, 14, 52, 169, DateTimeKind.Local).AddTicks(5497));

            migrationBuilder.UpdateData(
                table: "Breeds",
                keyColumn: "Id",
                keyValue: 16,
                column: "CreatedTime",
                value: new DateTime(2024, 8, 21, 7, 14, 52, 169, DateTimeKind.Local).AddTicks(5499));

            migrationBuilder.UpdateData(
                table: "Breeds",
                keyColumn: "Id",
                keyValue: 17,
                column: "CreatedTime",
                value: new DateTime(2024, 8, 21, 7, 14, 52, 169, DateTimeKind.Local).AddTicks(5501));

            migrationBuilder.UpdateData(
                table: "Breeds",
                keyColumn: "Id",
                keyValue: 18,
                column: "CreatedTime",
                value: new DateTime(2024, 8, 21, 7, 14, 52, 169, DateTimeKind.Local).AddTicks(5502));

            migrationBuilder.UpdateData(
                table: "Breeds",
                keyColumn: "Id",
                keyValue: 19,
                column: "CreatedTime",
                value: new DateTime(2024, 8, 21, 7, 14, 52, 169, DateTimeKind.Local).AddTicks(5504));

            migrationBuilder.UpdateData(
                table: "Breeds",
                keyColumn: "Id",
                keyValue: 20,
                column: "CreatedTime",
                value: new DateTime(2024, 8, 21, 7, 14, 52, 169, DateTimeKind.Local).AddTicks(5505));

            migrationBuilder.UpdateData(
                table: "Breeds",
                keyColumn: "Id",
                keyValue: 21,
                column: "CreatedTime",
                value: new DateTime(2024, 8, 21, 7, 14, 52, 169, DateTimeKind.Local).AddTicks(5506));

            migrationBuilder.UpdateData(
                table: "Breeds",
                keyColumn: "Id",
                keyValue: 22,
                column: "CreatedTime",
                value: new DateTime(2024, 8, 21, 7, 14, 52, 169, DateTimeKind.Local).AddTicks(5519));

            migrationBuilder.UpdateData(
                table: "Breeds",
                keyColumn: "Id",
                keyValue: 23,
                column: "CreatedTime",
                value: new DateTime(2024, 8, 21, 7, 14, 52, 169, DateTimeKind.Local).AddTicks(5532));

            migrationBuilder.UpdateData(
                table: "Breeds",
                keyColumn: "Id",
                keyValue: 24,
                column: "CreatedTime",
                value: new DateTime(2024, 8, 21, 7, 14, 52, 169, DateTimeKind.Local).AddTicks(5533));

            migrationBuilder.UpdateData(
                table: "Breeds",
                keyColumn: "Id",
                keyValue: 25,
                column: "CreatedTime",
                value: new DateTime(2024, 8, 21, 7, 14, 52, 169, DateTimeKind.Local).AddTicks(5535));

            migrationBuilder.UpdateData(
                table: "Breeds",
                keyColumn: "Id",
                keyValue: 26,
                column: "CreatedTime",
                value: new DateTime(2024, 8, 21, 7, 14, 52, 169, DateTimeKind.Local).AddTicks(5536));

            migrationBuilder.UpdateData(
                table: "Breeds",
                keyColumn: "Id",
                keyValue: 27,
                column: "CreatedTime",
                value: new DateTime(2024, 8, 21, 7, 14, 52, 169, DateTimeKind.Local).AddTicks(5538));

            migrationBuilder.UpdateData(
                table: "Breeds",
                keyColumn: "Id",
                keyValue: 28,
                column: "CreatedTime",
                value: new DateTime(2024, 8, 21, 7, 14, 52, 169, DateTimeKind.Local).AddTicks(5539));

            migrationBuilder.UpdateData(
                table: "Breeds",
                keyColumn: "Id",
                keyValue: 29,
                column: "CreatedTime",
                value: new DateTime(2024, 8, 21, 7, 14, 52, 169, DateTimeKind.Local).AddTicks(5541));

            migrationBuilder.UpdateData(
                table: "Breeds",
                keyColumn: "Id",
                keyValue: 30,
                column: "CreatedTime",
                value: new DateTime(2024, 8, 21, 7, 14, 52, 169, DateTimeKind.Local).AddTicks(5542));

            migrationBuilder.UpdateData(
                table: "Breeds",
                keyColumn: "Id",
                keyValue: 31,
                column: "CreatedTime",
                value: new DateTime(2024, 8, 21, 7, 14, 52, 169, DateTimeKind.Local).AddTicks(5543));

            migrationBuilder.UpdateData(
                table: "Breeds",
                keyColumn: "Id",
                keyValue: 32,
                column: "CreatedTime",
                value: new DateTime(2024, 8, 21, 7, 14, 52, 169, DateTimeKind.Local).AddTicks(5545));

            migrationBuilder.UpdateData(
                table: "Breeds",
                keyColumn: "Id",
                keyValue: 33,
                column: "CreatedTime",
                value: new DateTime(2024, 8, 21, 7, 14, 52, 169, DateTimeKind.Local).AddTicks(5547));

            migrationBuilder.UpdateData(
                table: "Breeds",
                keyColumn: "Id",
                keyValue: 34,
                column: "CreatedTime",
                value: new DateTime(2024, 8, 21, 7, 14, 52, 169, DateTimeKind.Local).AddTicks(5549));

            migrationBuilder.UpdateData(
                table: "Breeds",
                keyColumn: "Id",
                keyValue: 35,
                column: "CreatedTime",
                value: new DateTime(2024, 8, 21, 7, 14, 52, 169, DateTimeKind.Local).AddTicks(5550));

            migrationBuilder.UpdateData(
                table: "Breeds",
                keyColumn: "Id",
                keyValue: 36,
                column: "CreatedTime",
                value: new DateTime(2024, 8, 21, 7, 14, 52, 169, DateTimeKind.Local).AddTicks(5551));

            migrationBuilder.UpdateData(
                table: "Breeds",
                keyColumn: "Id",
                keyValue: 37,
                column: "CreatedTime",
                value: new DateTime(2024, 8, 21, 7, 14, 52, 169, DateTimeKind.Local).AddTicks(5553));

            migrationBuilder.UpdateData(
                table: "Breeds",
                keyColumn: "Id",
                keyValue: 38,
                column: "CreatedTime",
                value: new DateTime(2024, 8, 21, 7, 14, 52, 169, DateTimeKind.Local).AddTicks(5554));

            migrationBuilder.UpdateData(
                table: "Breeds",
                keyColumn: "Id",
                keyValue: 39,
                column: "CreatedTime",
                value: new DateTime(2024, 8, 21, 7, 14, 52, 169, DateTimeKind.Local).AddTicks(5555));

            migrationBuilder.UpdateData(
                table: "Breeds",
                keyColumn: "Id",
                keyValue: 40,
                column: "CreatedTime",
                value: new DateTime(2024, 8, 21, 7, 14, 52, 169, DateTimeKind.Local).AddTicks(5557));

            migrationBuilder.UpdateData(
                table: "Breeds",
                keyColumn: "Id",
                keyValue: 41,
                column: "CreatedTime",
                value: new DateTime(2024, 8, 21, 7, 14, 52, 169, DateTimeKind.Local).AddTicks(5558));

            migrationBuilder.UpdateData(
                table: "Breeds",
                keyColumn: "Id",
                keyValue: 42,
                column: "CreatedTime",
                value: new DateTime(2024, 8, 21, 7, 14, 52, 169, DateTimeKind.Local).AddTicks(5559));

            migrationBuilder.UpdateData(
                table: "Breeds",
                keyColumn: "Id",
                keyValue: 43,
                column: "CreatedTime",
                value: new DateTime(2024, 8, 21, 7, 14, 52, 169, DateTimeKind.Local).AddTicks(5561));

            migrationBuilder.UpdateData(
                table: "Breeds",
                keyColumn: "Id",
                keyValue: 44,
                column: "CreatedTime",
                value: new DateTime(2024, 8, 21, 7, 14, 52, 169, DateTimeKind.Local).AddTicks(5562));

            migrationBuilder.UpdateData(
                table: "Breeds",
                keyColumn: "Id",
                keyValue: 45,
                column: "CreatedTime",
                value: new DateTime(2024, 8, 21, 7, 14, 52, 169, DateTimeKind.Local).AddTicks(5563));

            migrationBuilder.UpdateData(
                table: "Breeds",
                keyColumn: "Id",
                keyValue: 46,
                column: "CreatedTime",
                value: new DateTime(2024, 8, 21, 7, 14, 52, 169, DateTimeKind.Local).AddTicks(5565));

            migrationBuilder.UpdateData(
                table: "Breeds",
                keyColumn: "Id",
                keyValue: 47,
                column: "CreatedTime",
                value: new DateTime(2024, 8, 21, 7, 14, 52, 169, DateTimeKind.Local).AddTicks(5567));

            migrationBuilder.UpdateData(
                table: "Breeds",
                keyColumn: "Id",
                keyValue: 48,
                column: "CreatedTime",
                value: new DateTime(2024, 8, 21, 7, 14, 52, 169, DateTimeKind.Local).AddTicks(5568));

            migrationBuilder.UpdateData(
                table: "Breeds",
                keyColumn: "Id",
                keyValue: 49,
                column: "CreatedTime",
                value: new DateTime(2024, 8, 21, 7, 14, 52, 169, DateTimeKind.Local).AddTicks(5569));

            migrationBuilder.UpdateData(
                table: "Breeds",
                keyColumn: "Id",
                keyValue: 50,
                column: "CreatedTime",
                value: new DateTime(2024, 8, 21, 7, 14, 52, 169, DateTimeKind.Local).AddTicks(5571));

            migrationBuilder.UpdateData(
                table: "Breeds",
                keyColumn: "Id",
                keyValue: 51,
                column: "CreatedTime",
                value: new DateTime(2024, 8, 21, 7, 14, 52, 169, DateTimeKind.Local).AddTicks(5572));

            migrationBuilder.UpdateData(
                table: "Breeds",
                keyColumn: "Id",
                keyValue: 52,
                column: "CreatedTime",
                value: new DateTime(2024, 8, 21, 7, 14, 52, 169, DateTimeKind.Local).AddTicks(5573));

            migrationBuilder.UpdateData(
                table: "Breeds",
                keyColumn: "Id",
                keyValue: 53,
                column: "CreatedTime",
                value: new DateTime(2024, 8, 21, 7, 14, 52, 169, DateTimeKind.Local).AddTicks(5575));

            migrationBuilder.UpdateData(
                table: "Breeds",
                keyColumn: "Id",
                keyValue: 54,
                column: "CreatedTime",
                value: new DateTime(2024, 8, 21, 7, 14, 52, 169, DateTimeKind.Local).AddTicks(5576));

            migrationBuilder.UpdateData(
                table: "Breeds",
                keyColumn: "Id",
                keyValue: 55,
                column: "CreatedTime",
                value: new DateTime(2024, 8, 21, 7, 14, 52, 169, DateTimeKind.Local).AddTicks(5577));

            migrationBuilder.UpdateData(
                table: "Breeds",
                keyColumn: "Id",
                keyValue: 56,
                column: "CreatedTime",
                value: new DateTime(2024, 8, 21, 7, 14, 52, 169, DateTimeKind.Local).AddTicks(5578));

            migrationBuilder.UpdateData(
                table: "Breeds",
                keyColumn: "Id",
                keyValue: 57,
                column: "CreatedTime",
                value: new DateTime(2024, 8, 21, 7, 14, 52, 169, DateTimeKind.Local).AddTicks(5580));

            migrationBuilder.UpdateData(
                table: "Breeds",
                keyColumn: "Id",
                keyValue: 58,
                column: "CreatedTime",
                value: new DateTime(2024, 8, 21, 7, 14, 52, 169, DateTimeKind.Local).AddTicks(5581));

            migrationBuilder.UpdateData(
                table: "Breeds",
                keyColumn: "Id",
                keyValue: 59,
                column: "CreatedTime",
                value: new DateTime(2024, 8, 21, 7, 14, 52, 169, DateTimeKind.Local).AddTicks(5582));

            migrationBuilder.UpdateData(
                table: "Breeds",
                keyColumn: "Id",
                keyValue: 60,
                column: "CreatedTime",
                value: new DateTime(2024, 8, 21, 7, 14, 52, 169, DateTimeKind.Local).AddTicks(5583));

            migrationBuilder.UpdateData(
                table: "Breeds",
                keyColumn: "Id",
                keyValue: 61,
                column: "CreatedTime",
                value: new DateTime(2024, 8, 21, 7, 14, 52, 169, DateTimeKind.Local).AddTicks(5585));

            migrationBuilder.UpdateData(
                table: "Breeds",
                keyColumn: "Id",
                keyValue: 62,
                column: "CreatedTime",
                value: new DateTime(2024, 8, 21, 7, 14, 52, 169, DateTimeKind.Local).AddTicks(5586));

            migrationBuilder.UpdateData(
                table: "Breeds",
                keyColumn: "Id",
                keyValue: 63,
                column: "CreatedTime",
                value: new DateTime(2024, 8, 21, 7, 14, 52, 169, DateTimeKind.Local).AddTicks(5587));

            migrationBuilder.UpdateData(
                table: "Breeds",
                keyColumn: "Id",
                keyValue: 64,
                column: "CreatedTime",
                value: new DateTime(2024, 8, 21, 7, 14, 52, 169, DateTimeKind.Local).AddTicks(5589));

            migrationBuilder.UpdateData(
                table: "Breeds",
                keyColumn: "Id",
                keyValue: 65,
                column: "CreatedTime",
                value: new DateTime(2024, 8, 21, 7, 14, 52, 169, DateTimeKind.Local).AddTicks(5639));

            migrationBuilder.UpdateData(
                table: "Breeds",
                keyColumn: "Id",
                keyValue: 66,
                column: "CreatedTime",
                value: new DateTime(2024, 8, 21, 7, 14, 52, 169, DateTimeKind.Local).AddTicks(5641));

            migrationBuilder.UpdateData(
                table: "Breeds",
                keyColumn: "Id",
                keyValue: 67,
                column: "CreatedTime",
                value: new DateTime(2024, 8, 21, 7, 14, 52, 169, DateTimeKind.Local).AddTicks(5642));

            migrationBuilder.UpdateData(
                table: "Breeds",
                keyColumn: "Id",
                keyValue: 68,
                column: "CreatedTime",
                value: new DateTime(2024, 8, 21, 7, 14, 52, 169, DateTimeKind.Local).AddTicks(5644));

            migrationBuilder.UpdateData(
                table: "Breeds",
                keyColumn: "Id",
                keyValue: 69,
                column: "CreatedTime",
                value: new DateTime(2024, 8, 21, 7, 14, 52, 169, DateTimeKind.Local).AddTicks(5645));

            migrationBuilder.UpdateData(
                table: "Breeds",
                keyColumn: "Id",
                keyValue: 70,
                column: "CreatedTime",
                value: new DateTime(2024, 8, 21, 7, 14, 52, 169, DateTimeKind.Local).AddTicks(5646));

            migrationBuilder.UpdateData(
                table: "Breeds",
                keyColumn: "Id",
                keyValue: 71,
                column: "CreatedTime",
                value: new DateTime(2024, 8, 21, 7, 14, 52, 169, DateTimeKind.Local).AddTicks(5648));

            migrationBuilder.UpdateData(
                table: "Breeds",
                keyColumn: "Id",
                keyValue: 72,
                column: "CreatedTime",
                value: new DateTime(2024, 8, 21, 7, 14, 52, 169, DateTimeKind.Local).AddTicks(5649));

            migrationBuilder.UpdateData(
                table: "Breeds",
                keyColumn: "Id",
                keyValue: 73,
                column: "CreatedTime",
                value: new DateTime(2024, 8, 21, 7, 14, 52, 169, DateTimeKind.Local).AddTicks(5650));

            migrationBuilder.UpdateData(
                table: "Breeds",
                keyColumn: "Id",
                keyValue: 74,
                column: "CreatedTime",
                value: new DateTime(2024, 8, 21, 7, 14, 52, 169, DateTimeKind.Local).AddTicks(5652));

            migrationBuilder.UpdateData(
                table: "Breeds",
                keyColumn: "Id",
                keyValue: 75,
                column: "CreatedTime",
                value: new DateTime(2024, 8, 21, 7, 14, 52, 169, DateTimeKind.Local).AddTicks(5654));

            migrationBuilder.UpdateData(
                table: "Breeds",
                keyColumn: "Id",
                keyValue: 76,
                column: "CreatedTime",
                value: new DateTime(2024, 8, 21, 7, 14, 52, 169, DateTimeKind.Local).AddTicks(5656));

            migrationBuilder.UpdateData(
                table: "Breeds",
                keyColumn: "Id",
                keyValue: 77,
                column: "CreatedTime",
                value: new DateTime(2024, 8, 21, 7, 14, 52, 169, DateTimeKind.Local).AddTicks(5657));

            migrationBuilder.UpdateData(
                table: "Breeds",
                keyColumn: "Id",
                keyValue: 78,
                column: "CreatedTime",
                value: new DateTime(2024, 8, 21, 7, 14, 52, 169, DateTimeKind.Local).AddTicks(5658));

            migrationBuilder.UpdateData(
                table: "Breeds",
                keyColumn: "Id",
                keyValue: 79,
                column: "CreatedTime",
                value: new DateTime(2024, 8, 21, 7, 14, 52, 169, DateTimeKind.Local).AddTicks(5660));

            migrationBuilder.UpdateData(
                table: "Breeds",
                keyColumn: "Id",
                keyValue: 80,
                column: "CreatedTime",
                value: new DateTime(2024, 8, 21, 7, 14, 52, 169, DateTimeKind.Local).AddTicks(5661));

            migrationBuilder.UpdateData(
                table: "Breeds",
                keyColumn: "Id",
                keyValue: 81,
                column: "CreatedTime",
                value: new DateTime(2024, 8, 21, 7, 14, 52, 169, DateTimeKind.Local).AddTicks(5662));

            migrationBuilder.UpdateData(
                table: "Breeds",
                keyColumn: "Id",
                keyValue: 82,
                column: "CreatedTime",
                value: new DateTime(2024, 8, 21, 7, 14, 52, 169, DateTimeKind.Local).AddTicks(5664));

            migrationBuilder.UpdateData(
                table: "Breeds",
                keyColumn: "Id",
                keyValue: 83,
                column: "CreatedTime",
                value: new DateTime(2024, 8, 21, 7, 14, 52, 169, DateTimeKind.Local).AddTicks(5665));

            migrationBuilder.UpdateData(
                table: "Breeds",
                keyColumn: "Id",
                keyValue: 84,
                column: "CreatedTime",
                value: new DateTime(2024, 8, 21, 7, 14, 52, 169, DateTimeKind.Local).AddTicks(5666));

            migrationBuilder.UpdateData(
                table: "Breeds",
                keyColumn: "Id",
                keyValue: 85,
                column: "CreatedTime",
                value: new DateTime(2024, 8, 21, 7, 14, 52, 169, DateTimeKind.Local).AddTicks(5668));

            migrationBuilder.UpdateData(
                table: "Breeds",
                keyColumn: "Id",
                keyValue: 86,
                column: "CreatedTime",
                value: new DateTime(2024, 8, 21, 7, 14, 52, 169, DateTimeKind.Local).AddTicks(5669));

            migrationBuilder.UpdateData(
                table: "Breeds",
                keyColumn: "Id",
                keyValue: 87,
                column: "CreatedTime",
                value: new DateTime(2024, 8, 21, 7, 14, 52, 169, DateTimeKind.Local).AddTicks(5670));

            migrationBuilder.UpdateData(
                table: "Breeds",
                keyColumn: "Id",
                keyValue: 88,
                column: "CreatedTime",
                value: new DateTime(2024, 8, 21, 7, 14, 52, 169, DateTimeKind.Local).AddTicks(5672));

            migrationBuilder.UpdateData(
                table: "Breeds",
                keyColumn: "Id",
                keyValue: 89,
                column: "CreatedTime",
                value: new DateTime(2024, 8, 21, 7, 14, 52, 169, DateTimeKind.Local).AddTicks(5673));

            migrationBuilder.UpdateData(
                table: "Breeds",
                keyColumn: "Id",
                keyValue: 90,
                column: "CreatedTime",
                value: new DateTime(2024, 8, 21, 7, 14, 52, 169, DateTimeKind.Local).AddTicks(5674));

            migrationBuilder.UpdateData(
                table: "Breeds",
                keyColumn: "Id",
                keyValue: 91,
                column: "CreatedTime",
                value: new DateTime(2024, 8, 21, 7, 14, 52, 169, DateTimeKind.Local).AddTicks(5676));

            migrationBuilder.UpdateData(
                table: "Breeds",
                keyColumn: "Id",
                keyValue: 92,
                column: "CreatedTime",
                value: new DateTime(2024, 8, 21, 7, 14, 52, 169, DateTimeKind.Local).AddTicks(5677));

            migrationBuilder.UpdateData(
                table: "Breeds",
                keyColumn: "Id",
                keyValue: 93,
                column: "CreatedTime",
                value: new DateTime(2024, 8, 21, 7, 14, 52, 169, DateTimeKind.Local).AddTicks(5678));

            migrationBuilder.UpdateData(
                table: "Breeds",
                keyColumn: "Id",
                keyValue: 94,
                column: "CreatedTime",
                value: new DateTime(2024, 8, 21, 7, 14, 52, 169, DateTimeKind.Local).AddTicks(5679));

            migrationBuilder.UpdateData(
                table: "Breeds",
                keyColumn: "Id",
                keyValue: 95,
                column: "CreatedTime",
                value: new DateTime(2024, 8, 21, 7, 14, 52, 169, DateTimeKind.Local).AddTicks(5681));

            migrationBuilder.UpdateData(
                table: "Breeds",
                keyColumn: "Id",
                keyValue: 96,
                column: "CreatedTime",
                value: new DateTime(2024, 8, 21, 7, 14, 52, 169, DateTimeKind.Local).AddTicks(5682));

            migrationBuilder.UpdateData(
                table: "Breeds",
                keyColumn: "Id",
                keyValue: 97,
                column: "CreatedTime",
                value: new DateTime(2024, 8, 21, 7, 14, 52, 169, DateTimeKind.Local).AddTicks(5684));

            migrationBuilder.UpdateData(
                table: "Breeds",
                keyColumn: "Id",
                keyValue: 98,
                column: "CreatedTime",
                value: new DateTime(2024, 8, 21, 7, 14, 52, 169, DateTimeKind.Local).AddTicks(5685));

            migrationBuilder.UpdateData(
                table: "Breeds",
                keyColumn: "Id",
                keyValue: 99,
                column: "CreatedTime",
                value: new DateTime(2024, 8, 21, 7, 14, 52, 169, DateTimeKind.Local).AddTicks(5687));

            migrationBuilder.UpdateData(
                table: "Breeds",
                keyColumn: "Id",
                keyValue: 100,
                column: "CreatedTime",
                value: new DateTime(2024, 8, 21, 7, 14, 52, 169, DateTimeKind.Local).AddTicks(5688));

            migrationBuilder.UpdateData(
                table: "Breeds",
                keyColumn: "Id",
                keyValue: 101,
                column: "CreatedTime",
                value: new DateTime(2024, 8, 21, 7, 14, 52, 169, DateTimeKind.Local).AddTicks(5689));

            migrationBuilder.UpdateData(
                table: "Breeds",
                keyColumn: "Id",
                keyValue: 102,
                column: "CreatedTime",
                value: new DateTime(2024, 8, 21, 7, 14, 52, 169, DateTimeKind.Local).AddTicks(5691));

            migrationBuilder.UpdateData(
                table: "Breeds",
                keyColumn: "Id",
                keyValue: 103,
                column: "CreatedTime",
                value: new DateTime(2024, 8, 21, 7, 14, 52, 169, DateTimeKind.Local).AddTicks(5692));

            migrationBuilder.UpdateData(
                table: "Breeds",
                keyColumn: "Id",
                keyValue: 104,
                column: "CreatedTime",
                value: new DateTime(2024, 8, 21, 7, 14, 52, 169, DateTimeKind.Local).AddTicks(5694));

            migrationBuilder.UpdateData(
                table: "Breeds",
                keyColumn: "Id",
                keyValue: 105,
                column: "CreatedTime",
                value: new DateTime(2024, 8, 21, 7, 14, 52, 169, DateTimeKind.Local).AddTicks(5695));

            migrationBuilder.UpdateData(
                table: "Breeds",
                keyColumn: "Id",
                keyValue: 106,
                column: "CreatedTime",
                value: new DateTime(2024, 8, 21, 7, 14, 52, 169, DateTimeKind.Local).AddTicks(5697));

            migrationBuilder.UpdateData(
                table: "Breeds",
                keyColumn: "Id",
                keyValue: 107,
                column: "CreatedTime",
                value: new DateTime(2024, 8, 21, 7, 14, 52, 169, DateTimeKind.Local).AddTicks(5698));

            migrationBuilder.UpdateData(
                table: "Breeds",
                keyColumn: "Id",
                keyValue: 108,
                column: "CreatedTime",
                value: new DateTime(2024, 8, 21, 7, 14, 52, 169, DateTimeKind.Local).AddTicks(5700));

            migrationBuilder.UpdateData(
                table: "Breeds",
                keyColumn: "Id",
                keyValue: 109,
                column: "CreatedTime",
                value: new DateTime(2024, 8, 21, 7, 14, 52, 169, DateTimeKind.Local).AddTicks(5701));

            migrationBuilder.UpdateData(
                table: "Breeds",
                keyColumn: "Id",
                keyValue: 110,
                column: "CreatedTime",
                value: new DateTime(2024, 8, 21, 7, 14, 52, 169, DateTimeKind.Local).AddTicks(5702));

            migrationBuilder.UpdateData(
                table: "Breeds",
                keyColumn: "Id",
                keyValue: 111,
                column: "CreatedTime",
                value: new DateTime(2024, 8, 21, 7, 14, 52, 169, DateTimeKind.Local).AddTicks(5704));

            migrationBuilder.UpdateData(
                table: "Breeds",
                keyColumn: "Id",
                keyValue: 112,
                column: "CreatedTime",
                value: new DateTime(2024, 8, 21, 7, 14, 52, 169, DateTimeKind.Local).AddTicks(5705));

            migrationBuilder.UpdateData(
                table: "Breeds",
                keyColumn: "Id",
                keyValue: 113,
                column: "CreatedTime",
                value: new DateTime(2024, 8, 21, 7, 14, 52, 169, DateTimeKind.Local).AddTicks(5707));

            migrationBuilder.UpdateData(
                table: "Breeds",
                keyColumn: "Id",
                keyValue: 114,
                column: "CreatedTime",
                value: new DateTime(2024, 8, 21, 7, 14, 52, 169, DateTimeKind.Local).AddTicks(5708));

            migrationBuilder.UpdateData(
                table: "Breeds",
                keyColumn: "Id",
                keyValue: 115,
                column: "CreatedTime",
                value: new DateTime(2024, 8, 21, 7, 14, 52, 169, DateTimeKind.Local).AddTicks(5709));

            migrationBuilder.UpdateData(
                table: "Breeds",
                keyColumn: "Id",
                keyValue: 116,
                column: "CreatedTime",
                value: new DateTime(2024, 8, 21, 7, 14, 52, 169, DateTimeKind.Local).AddTicks(5710));

            migrationBuilder.UpdateData(
                table: "Breeds",
                keyColumn: "Id",
                keyValue: 117,
                column: "CreatedTime",
                value: new DateTime(2024, 8, 21, 7, 14, 52, 169, DateTimeKind.Local).AddTicks(5712));

            migrationBuilder.UpdateData(
                table: "Breeds",
                keyColumn: "Id",
                keyValue: 118,
                column: "CreatedTime",
                value: new DateTime(2024, 8, 21, 7, 14, 52, 169, DateTimeKind.Local).AddTicks(5713));

            migrationBuilder.UpdateData(
                table: "Breeds",
                keyColumn: "Id",
                keyValue: 119,
                column: "CreatedTime",
                value: new DateTime(2024, 8, 21, 7, 14, 52, 169, DateTimeKind.Local).AddTicks(5714));

            migrationBuilder.UpdateData(
                table: "Breeds",
                keyColumn: "Id",
                keyValue: 120,
                column: "CreatedTime",
                value: new DateTime(2024, 8, 21, 7, 14, 52, 169, DateTimeKind.Local).AddTicks(5716));

            migrationBuilder.UpdateData(
                table: "Breeds",
                keyColumn: "Id",
                keyValue: 121,
                column: "CreatedTime",
                value: new DateTime(2024, 8, 21, 7, 14, 52, 169, DateTimeKind.Local).AddTicks(5717));

            migrationBuilder.UpdateData(
                table: "Breeds",
                keyColumn: "Id",
                keyValue: 122,
                column: "CreatedTime",
                value: new DateTime(2024, 8, 21, 7, 14, 52, 169, DateTimeKind.Local).AddTicks(5718));

            migrationBuilder.UpdateData(
                table: "Breeds",
                keyColumn: "Id",
                keyValue: 123,
                column: "CreatedTime",
                value: new DateTime(2024, 8, 21, 7, 14, 52, 169, DateTimeKind.Local).AddTicks(5720));

            migrationBuilder.UpdateData(
                table: "Breeds",
                keyColumn: "Id",
                keyValue: 124,
                column: "CreatedTime",
                value: new DateTime(2024, 8, 21, 7, 14, 52, 169, DateTimeKind.Local).AddTicks(5721));

            migrationBuilder.UpdateData(
                table: "Breeds",
                keyColumn: "Id",
                keyValue: 125,
                column: "CreatedTime",
                value: new DateTime(2024, 8, 21, 7, 14, 52, 169, DateTimeKind.Local).AddTicks(5722));

            migrationBuilder.UpdateData(
                table: "Breeds",
                keyColumn: "Id",
                keyValue: 126,
                column: "CreatedTime",
                value: new DateTime(2024, 8, 21, 7, 14, 52, 169, DateTimeKind.Local).AddTicks(5723));

            migrationBuilder.UpdateData(
                table: "Breeds",
                keyColumn: "Id",
                keyValue: 127,
                column: "CreatedTime",
                value: new DateTime(2024, 8, 21, 7, 14, 52, 169, DateTimeKind.Local).AddTicks(5725));

            migrationBuilder.UpdateData(
                table: "Breeds",
                keyColumn: "Id",
                keyValue: 128,
                column: "CreatedTime",
                value: new DateTime(2024, 8, 21, 7, 14, 52, 169, DateTimeKind.Local).AddTicks(5726));

            migrationBuilder.UpdateData(
                table: "Breeds",
                keyColumn: "Id",
                keyValue: 129,
                column: "CreatedTime",
                value: new DateTime(2024, 8, 21, 7, 14, 52, 169, DateTimeKind.Local).AddTicks(5727));

            migrationBuilder.UpdateData(
                table: "Breeds",
                keyColumn: "Id",
                keyValue: 130,
                column: "CreatedTime",
                value: new DateTime(2024, 8, 21, 7, 14, 52, 169, DateTimeKind.Local).AddTicks(5729));

            migrationBuilder.UpdateData(
                table: "Breeds",
                keyColumn: "Id",
                keyValue: 131,
                column: "CreatedTime",
                value: new DateTime(2024, 8, 21, 7, 14, 52, 169, DateTimeKind.Local).AddTicks(5730));

            migrationBuilder.UpdateData(
                table: "Breeds",
                keyColumn: "Id",
                keyValue: 132,
                column: "CreatedTime",
                value: new DateTime(2024, 8, 21, 7, 14, 52, 169, DateTimeKind.Local).AddTicks(5731));

            migrationBuilder.UpdateData(
                table: "Breeds",
                keyColumn: "Id",
                keyValue: 133,
                column: "CreatedTime",
                value: new DateTime(2024, 8, 21, 7, 14, 52, 169, DateTimeKind.Local).AddTicks(5734));

            migrationBuilder.UpdateData(
                table: "Breeds",
                keyColumn: "Id",
                keyValue: 134,
                column: "CreatedTime",
                value: new DateTime(2024, 8, 21, 7, 14, 52, 169, DateTimeKind.Local).AddTicks(5735));

            migrationBuilder.UpdateData(
                table: "Breeds",
                keyColumn: "Id",
                keyValue: 135,
                column: "CreatedTime",
                value: new DateTime(2024, 8, 21, 7, 14, 52, 169, DateTimeKind.Local).AddTicks(5736));

            migrationBuilder.UpdateData(
                table: "Breeds",
                keyColumn: "Id",
                keyValue: 136,
                column: "CreatedTime",
                value: new DateTime(2024, 8, 21, 7, 14, 52, 169, DateTimeKind.Local).AddTicks(5738));

            migrationBuilder.UpdateData(
                table: "Breeds",
                keyColumn: "Id",
                keyValue: 137,
                column: "CreatedTime",
                value: new DateTime(2024, 8, 21, 7, 14, 52, 169, DateTimeKind.Local).AddTicks(5739));

            migrationBuilder.UpdateData(
                table: "Breeds",
                keyColumn: "Id",
                keyValue: 138,
                column: "CreatedTime",
                value: new DateTime(2024, 8, 21, 7, 14, 52, 169, DateTimeKind.Local).AddTicks(5740));

            migrationBuilder.UpdateData(
                table: "Breeds",
                keyColumn: "Id",
                keyValue: 139,
                column: "CreatedTime",
                value: new DateTime(2024, 8, 21, 7, 14, 52, 169, DateTimeKind.Local).AddTicks(5742));

            migrationBuilder.UpdateData(
                table: "Breeds",
                keyColumn: "Id",
                keyValue: 140,
                column: "CreatedTime",
                value: new DateTime(2024, 8, 21, 7, 14, 52, 169, DateTimeKind.Local).AddTicks(5743));

            migrationBuilder.UpdateData(
                table: "Breeds",
                keyColumn: "Id",
                keyValue: 141,
                column: "CreatedTime",
                value: new DateTime(2024, 8, 21, 7, 14, 52, 169, DateTimeKind.Local).AddTicks(5745));

            migrationBuilder.UpdateData(
                table: "Breeds",
                keyColumn: "Id",
                keyValue: 142,
                column: "CreatedTime",
                value: new DateTime(2024, 8, 21, 7, 14, 52, 169, DateTimeKind.Local).AddTicks(5746));

            migrationBuilder.UpdateData(
                table: "Breeds",
                keyColumn: "Id",
                keyValue: 143,
                column: "CreatedTime",
                value: new DateTime(2024, 8, 21, 7, 14, 52, 169, DateTimeKind.Local).AddTicks(5747));

            migrationBuilder.UpdateData(
                table: "Breeds",
                keyColumn: "Id",
                keyValue: 144,
                column: "CreatedTime",
                value: new DateTime(2024, 8, 21, 7, 14, 52, 169, DateTimeKind.Local).AddTicks(5749));

            migrationBuilder.UpdateData(
                table: "Breeds",
                keyColumn: "Id",
                keyValue: 145,
                column: "CreatedTime",
                value: new DateTime(2024, 8, 21, 7, 14, 52, 169, DateTimeKind.Local).AddTicks(5750));

            migrationBuilder.UpdateData(
                table: "Breeds",
                keyColumn: "Id",
                keyValue: 146,
                column: "CreatedTime",
                value: new DateTime(2024, 8, 21, 7, 14, 52, 169, DateTimeKind.Local).AddTicks(5751));

            migrationBuilder.UpdateData(
                table: "Breeds",
                keyColumn: "Id",
                keyValue: 147,
                column: "CreatedTime",
                value: new DateTime(2024, 8, 21, 7, 14, 52, 169, DateTimeKind.Local).AddTicks(5753));

            migrationBuilder.UpdateData(
                table: "Breeds",
                keyColumn: "Id",
                keyValue: 148,
                column: "CreatedTime",
                value: new DateTime(2024, 8, 21, 7, 14, 52, 169, DateTimeKind.Local).AddTicks(5754));

            migrationBuilder.UpdateData(
                table: "Breeds",
                keyColumn: "Id",
                keyValue: 149,
                column: "CreatedTime",
                value: new DateTime(2024, 8, 21, 7, 14, 52, 169, DateTimeKind.Local).AddTicks(5755));

            migrationBuilder.UpdateData(
                table: "Breeds",
                keyColumn: "Id",
                keyValue: 150,
                column: "CreatedTime",
                value: new DateTime(2024, 8, 21, 7, 14, 52, 169, DateTimeKind.Local).AddTicks(5757));

            migrationBuilder.UpdateData(
                table: "Breeds",
                keyColumn: "Id",
                keyValue: 151,
                column: "CreatedTime",
                value: new DateTime(2024, 8, 21, 7, 14, 52, 169, DateTimeKind.Local).AddTicks(5758));

            migrationBuilder.UpdateData(
                table: "Breeds",
                keyColumn: "Id",
                keyValue: 152,
                column: "CreatedTime",
                value: new DateTime(2024, 8, 21, 7, 14, 52, 169, DateTimeKind.Local).AddTicks(5759));

            migrationBuilder.UpdateData(
                table: "Breeds",
                keyColumn: "Id",
                keyValue: 153,
                column: "CreatedTime",
                value: new DateTime(2024, 8, 21, 7, 14, 52, 169, DateTimeKind.Local).AddTicks(5760));

            migrationBuilder.UpdateData(
                table: "Breeds",
                keyColumn: "Id",
                keyValue: 154,
                column: "CreatedTime",
                value: new DateTime(2024, 8, 21, 7, 14, 52, 169, DateTimeKind.Local).AddTicks(5762));

            migrationBuilder.UpdateData(
                table: "Breeds",
                keyColumn: "Id",
                keyValue: 155,
                column: "CreatedTime",
                value: new DateTime(2024, 8, 21, 7, 14, 52, 169, DateTimeKind.Local).AddTicks(5763));

            migrationBuilder.UpdateData(
                table: "Breeds",
                keyColumn: "Id",
                keyValue: 156,
                column: "CreatedTime",
                value: new DateTime(2024, 8, 21, 7, 14, 52, 169, DateTimeKind.Local).AddTicks(5764));

            migrationBuilder.UpdateData(
                table: "Breeds",
                keyColumn: "Id",
                keyValue: 157,
                column: "CreatedTime",
                value: new DateTime(2024, 8, 21, 7, 14, 52, 169, DateTimeKind.Local).AddTicks(5765));

            migrationBuilder.UpdateData(
                table: "Breeds",
                keyColumn: "Id",
                keyValue: 158,
                column: "CreatedTime",
                value: new DateTime(2024, 8, 21, 7, 14, 52, 169, DateTimeKind.Local).AddTicks(5767));

            migrationBuilder.UpdateData(
                table: "Breeds",
                keyColumn: "Id",
                keyValue: 159,
                column: "CreatedTime",
                value: new DateTime(2024, 8, 21, 7, 14, 52, 169, DateTimeKind.Local).AddTicks(5768));

            migrationBuilder.UpdateData(
                table: "Breeds",
                keyColumn: "Id",
                keyValue: 160,
                column: "CreatedTime",
                value: new DateTime(2024, 8, 21, 7, 14, 52, 169, DateTimeKind.Local).AddTicks(5769));

            migrationBuilder.UpdateData(
                table: "PetTypes",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedTime",
                value: new DateTime(2024, 8, 21, 7, 14, 52, 169, DateTimeKind.Local).AddTicks(1355));

            migrationBuilder.UpdateData(
                table: "PetTypes",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreatedTime",
                value: new DateTime(2024, 8, 21, 7, 14, 52, 169, DateTimeKind.Local).AddTicks(1431));

            migrationBuilder.UpdateData(
                table: "PetTypes",
                keyColumn: "Id",
                keyValue: 3,
                column: "CreatedTime",
                value: new DateTime(2024, 8, 21, 7, 14, 52, 169, DateTimeKind.Local).AddTicks(1433));

            migrationBuilder.UpdateData(
                table: "PetTypes",
                keyColumn: "Id",
                keyValue: 4,
                column: "CreatedTime",
                value: new DateTime(2024, 8, 21, 7, 14, 52, 169, DateTimeKind.Local).AddTicks(1434));

            migrationBuilder.UpdateData(
                table: "PetTypes",
                keyColumn: "Id",
                keyValue: 5,
                column: "CreatedTime",
                value: new DateTime(2024, 8, 21, 7, 14, 52, 169, DateTimeKind.Local).AddTicks(1435));

            migrationBuilder.UpdateData(
                table: "PetTypes",
                keyColumn: "Id",
                keyValue: 6,
                column: "CreatedTime",
                value: new DateTime(2024, 8, 21, 7, 14, 52, 169, DateTimeKind.Local).AddTicks(1437));

            migrationBuilder.UpdateData(
                table: "PetTypes",
                keyColumn: "Id",
                keyValue: 7,
                column: "CreatedTime",
                value: new DateTime(2024, 8, 21, 7, 14, 52, 169, DateTimeKind.Local).AddTicks(1438));

            migrationBuilder.UpdateData(
                table: "PetTypes",
                keyColumn: "Id",
                keyValue: 8,
                column: "CreatedTime",
                value: new DateTime(2024, 8, 21, 7, 14, 52, 169, DateTimeKind.Local).AddTicks(1439));
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<string>(
                name: "Region",
                table: "Locations",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "");

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: 2001,
                columns: new[] { "ConcurrencyStamp", "CreatedTime", "LastUpdatedTime", "RefreshTokenCreateTime" },
                values: new object[] { "ee0fc954-a3bb-4164-8c1e-db7c49ad41a9", new DateTime(2024, 8, 20, 18, 35, 3, 695, DateTimeKind.Utc).AddTicks(9149), new DateTime(2024, 8, 20, 18, 35, 3, 695, DateTimeKind.Utc).AddTicks(9150), new DateTime(2024, 8, 20, 18, 35, 3, 695, DateTimeKind.Utc).AddTicks(9075) });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: 2002,
                columns: new[] { "ConcurrencyStamp", "CreatedTime", "LastUpdatedTime", "RefreshTokenCreateTime" },
                values: new object[] { "c5128d4f-8694-4a80-bb73-a2c675e19c44", new DateTime(2024, 8, 20, 18, 35, 3, 695, DateTimeKind.Utc).AddTicks(9213), new DateTime(2024, 8, 20, 18, 35, 3, 695, DateTimeKind.Utc).AddTicks(9213), new DateTime(2024, 8, 20, 18, 35, 3, 695, DateTimeKind.Utc).AddTicks(9209) });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: 2003,
                columns: new[] { "ConcurrencyStamp", "CreatedTime", "LastUpdatedTime", "RefreshTokenCreateTime" },
                values: new object[] { "01665ebe-123d-4135-b6d5-297a4f249640", new DateTime(2024, 8, 20, 18, 35, 3, 695, DateTimeKind.Utc).AddTicks(9226), new DateTime(2024, 8, 20, 18, 35, 3, 695, DateTimeKind.Utc).AddTicks(9227), new DateTime(2024, 8, 20, 18, 35, 3, 695, DateTimeKind.Utc).AddTicks(9224) });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: 2004,
                columns: new[] { "ConcurrencyStamp", "CreatedTime", "LastUpdatedTime", "RefreshTokenCreateTime" },
                values: new object[] { "3db22117-309a-416e-8a19-dc2d0e4b0b9e", new DateTime(2024, 8, 20, 18, 35, 3, 695, DateTimeKind.Utc).AddTicks(9255), new DateTime(2024, 8, 20, 18, 35, 3, 695, DateTimeKind.Utc).AddTicks(9255), new DateTime(2024, 8, 20, 18, 35, 3, 695, DateTimeKind.Utc).AddTicks(9237) });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: 2005,
                columns: new[] { "ConcurrencyStamp", "CreatedTime", "LastUpdatedTime", "RefreshTokenCreateTime" },
                values: new object[] { "3a406a8c-7112-443f-aff2-97dd2341428f", new DateTime(2024, 8, 20, 18, 35, 3, 695, DateTimeKind.Utc).AddTicks(9267), new DateTime(2024, 8, 20, 18, 35, 3, 695, DateTimeKind.Utc).AddTicks(9267), new DateTime(2024, 8, 20, 18, 35, 3, 695, DateTimeKind.Utc).AddTicks(9264) });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: 2006,
                columns: new[] { "ConcurrencyStamp", "CreatedTime", "LastUpdatedTime", "RefreshTokenCreateTime" },
                values: new object[] { "b50fbb3d-b4fa-4c22-9b43-3ffb77eb60f9", new DateTime(2024, 8, 20, 18, 35, 3, 695, DateTimeKind.Utc).AddTicks(9374), new DateTime(2024, 8, 20, 18, 35, 3, 695, DateTimeKind.Utc).AddTicks(9375), new DateTime(2024, 8, 20, 18, 35, 3, 695, DateTimeKind.Utc).AddTicks(9371) });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: 2007,
                columns: new[] { "ConcurrencyStamp", "CreatedTime", "LastUpdatedTime", "RefreshTokenCreateTime" },
                values: new object[] { "edb49a56-9814-426e-ba5b-15a8f44c8fa1", new DateTime(2024, 8, 20, 18, 35, 3, 695, DateTimeKind.Utc).AddTicks(9388), new DateTime(2024, 8, 20, 18, 35, 3, 695, DateTimeKind.Utc).AddTicks(9388), new DateTime(2024, 8, 20, 18, 35, 3, 695, DateTimeKind.Utc).AddTicks(9385) });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: 2008,
                columns: new[] { "ConcurrencyStamp", "CreatedTime", "LastUpdatedTime", "RefreshTokenCreateTime" },
                values: new object[] { "90c0e0a8-bcf6-4b3f-9253-7a6ac378e774", new DateTime(2024, 8, 20, 18, 35, 3, 695, DateTimeKind.Utc).AddTicks(9401), new DateTime(2024, 8, 20, 18, 35, 3, 695, DateTimeKind.Utc).AddTicks(9401), new DateTime(2024, 8, 20, 18, 35, 3, 695, DateTimeKind.Utc).AddTicks(9398) });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: 2009,
                columns: new[] { "ConcurrencyStamp", "CreatedTime", "LastUpdatedTime", "RefreshTokenCreateTime" },
                values: new object[] { "e9461da3-d1cf-4e11-8b85-a762d97f6e22", new DateTime(2024, 8, 20, 18, 35, 3, 695, DateTimeKind.Utc).AddTicks(9413), new DateTime(2024, 8, 20, 18, 35, 3, 695, DateTimeKind.Utc).AddTicks(9414), new DateTime(2024, 8, 20, 18, 35, 3, 695, DateTimeKind.Utc).AddTicks(9410) });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: 2010,
                columns: new[] { "ConcurrencyStamp", "CreatedTime", "LastUpdatedTime", "RefreshTokenCreateTime" },
                values: new object[] { "a3f98fd2-820c-437a-8968-87990765d920", new DateTime(2024, 8, 20, 18, 35, 3, 695, DateTimeKind.Utc).AddTicks(9427), new DateTime(2024, 8, 20, 18, 35, 3, 695, DateTimeKind.Utc).AddTicks(9427), new DateTime(2024, 8, 20, 18, 35, 3, 695, DateTimeKind.Utc).AddTicks(9423) });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: 2011,
                columns: new[] { "ConcurrencyStamp", "CreatedTime", "LastUpdatedTime", "RefreshTokenCreateTime" },
                values: new object[] { "af64da6f-bb29-4647-968b-1fedfe2227b8", new DateTime(2024, 8, 20, 18, 35, 3, 695, DateTimeKind.Utc).AddTicks(9442), new DateTime(2024, 8, 20, 18, 35, 3, 695, DateTimeKind.Utc).AddTicks(9442), new DateTime(2024, 8, 20, 18, 35, 3, 695, DateTimeKind.Utc).AddTicks(9439) });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: 2012,
                columns: new[] { "ConcurrencyStamp", "CreatedTime", "LastUpdatedTime", "RefreshTokenCreateTime" },
                values: new object[] { "87bf5ded-e75a-4a6e-8a4f-ea27231a335c", new DateTime(2024, 8, 20, 18, 35, 3, 695, DateTimeKind.Utc).AddTicks(9458), new DateTime(2024, 8, 20, 18, 35, 3, 695, DateTimeKind.Utc).AddTicks(9459), new DateTime(2024, 8, 20, 18, 35, 3, 695, DateTimeKind.Utc).AddTicks(9452) });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: 2013,
                columns: new[] { "ConcurrencyStamp", "CreatedTime", "LastUpdatedTime", "RefreshTokenCreateTime" },
                values: new object[] { "77f08e03-1472-4f19-b6c1-cad911e59d4c", new DateTime(2024, 8, 20, 18, 35, 3, 695, DateTimeKind.Utc).AddTicks(9471), new DateTime(2024, 8, 20, 18, 35, 3, 695, DateTimeKind.Utc).AddTicks(9471), new DateTime(2024, 8, 20, 18, 35, 3, 695, DateTimeKind.Utc).AddTicks(9468) });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: 2014,
                columns: new[] { "ConcurrencyStamp", "CreatedTime", "LastUpdatedTime", "RefreshTokenCreateTime" },
                values: new object[] { "76078dd5-c6f8-49bc-ad8d-bd91f7fc89cf", new DateTime(2024, 8, 20, 18, 35, 3, 695, DateTimeKind.Utc).AddTicks(9483), new DateTime(2024, 8, 20, 18, 35, 3, 695, DateTimeKind.Utc).AddTicks(9483), new DateTime(2024, 8, 20, 18, 35, 3, 695, DateTimeKind.Utc).AddTicks(9480) });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: 2015,
                columns: new[] { "ConcurrencyStamp", "CreatedTime", "LastUpdatedTime", "RefreshTokenCreateTime" },
                values: new object[] { "fefe3495-265a-474c-9ad9-56f620cbdc5e", new DateTime(2024, 8, 20, 18, 35, 3, 695, DateTimeKind.Utc).AddTicks(9495), new DateTime(2024, 8, 20, 18, 35, 3, 695, DateTimeKind.Utc).AddTicks(9495), new DateTime(2024, 8, 20, 18, 35, 3, 695, DateTimeKind.Utc).AddTicks(9492) });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: 2016,
                columns: new[] { "ConcurrencyStamp", "CreatedTime", "LastUpdatedTime", "RefreshTokenCreateTime" },
                values: new object[] { "e1146f6f-56cc-4d45-9aa6-a5ebadb825e7", new DateTime(2024, 8, 20, 18, 35, 3, 695, DateTimeKind.Utc).AddTicks(9547), new DateTime(2024, 8, 20, 18, 35, 3, 695, DateTimeKind.Utc).AddTicks(9548), new DateTime(2024, 8, 20, 18, 35, 3, 695, DateTimeKind.Utc).AddTicks(9544) });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: 2017,
                columns: new[] { "ConcurrencyStamp", "CreatedTime", "LastUpdatedTime", "RefreshTokenCreateTime" },
                values: new object[] { "0fb82d1d-6baa-4e5e-a655-daab31955a5c", new DateTime(2024, 8, 20, 18, 35, 3, 695, DateTimeKind.Utc).AddTicks(9560), new DateTime(2024, 8, 20, 18, 35, 3, 695, DateTimeKind.Utc).AddTicks(9561), new DateTime(2024, 8, 20, 18, 35, 3, 695, DateTimeKind.Utc).AddTicks(9557) });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: 2018,
                columns: new[] { "ConcurrencyStamp", "CreatedTime", "LastUpdatedTime", "RefreshTokenCreateTime" },
                values: new object[] { "84e40cef-e6a6-4fbd-afeb-59cef19d0bcd", new DateTime(2024, 8, 20, 18, 35, 3, 695, DateTimeKind.Utc).AddTicks(9575), new DateTime(2024, 8, 20, 18, 35, 3, 695, DateTimeKind.Utc).AddTicks(9575), new DateTime(2024, 8, 20, 18, 35, 3, 695, DateTimeKind.Utc).AddTicks(9572) });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: 2019,
                columns: new[] { "ConcurrencyStamp", "CreatedTime", "LastUpdatedTime", "RefreshTokenCreateTime" },
                values: new object[] { "25426cf7-41f2-47b7-b4e5-3d357b94b5c6", new DateTime(2024, 8, 20, 18, 35, 3, 695, DateTimeKind.Utc).AddTicks(9589), new DateTime(2024, 8, 20, 18, 35, 3, 695, DateTimeKind.Utc).AddTicks(9589), new DateTime(2024, 8, 20, 18, 35, 3, 695, DateTimeKind.Utc).AddTicks(9585) });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: 2020,
                columns: new[] { "ConcurrencyStamp", "CreatedTime", "LastUpdatedTime", "RefreshTokenCreateTime" },
                values: new object[] { "26fb8ec3-719a-4c97-a5ae-2a63b2f545ac", new DateTime(2024, 8, 20, 18, 35, 3, 695, DateTimeKind.Utc).AddTicks(9604), new DateTime(2024, 8, 20, 18, 35, 3, 695, DateTimeKind.Utc).AddTicks(9605), new DateTime(2024, 8, 20, 18, 35, 3, 695, DateTimeKind.Utc).AddTicks(9598) });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: 2021,
                columns: new[] { "ConcurrencyStamp", "CreatedTime", "LastUpdatedTime", "RefreshTokenCreateTime" },
                values: new object[] { "10d0c056-8913-41f3-835e-e93f94c9d6cc", new DateTime(2024, 8, 20, 18, 35, 3, 695, DateTimeKind.Utc).AddTicks(9617), new DateTime(2024, 8, 20, 18, 35, 3, 695, DateTimeKind.Utc).AddTicks(9617), new DateTime(2024, 8, 20, 18, 35, 3, 695, DateTimeKind.Utc).AddTicks(9614) });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: 2022,
                columns: new[] { "ConcurrencyStamp", "CreatedTime", "LastUpdatedTime", "RefreshTokenCreateTime" },
                values: new object[] { "f4da5042-6ffb-4e6b-ba32-8f2633fc736b", new DateTime(2024, 8, 20, 18, 35, 3, 695, DateTimeKind.Utc).AddTicks(9638), new DateTime(2024, 8, 20, 18, 35, 3, 695, DateTimeKind.Utc).AddTicks(9638), new DateTime(2024, 8, 20, 18, 35, 3, 695, DateTimeKind.Utc).AddTicks(9635) });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: 2023,
                columns: new[] { "ConcurrencyStamp", "CreatedTime", "LastUpdatedTime", "RefreshTokenCreateTime" },
                values: new object[] { "a3c04d86-1cd7-4296-bc58-afaa38ebaae5", new DateTime(2024, 8, 20, 18, 35, 3, 695, DateTimeKind.Utc).AddTicks(9652), new DateTime(2024, 8, 20, 18, 35, 3, 695, DateTimeKind.Utc).AddTicks(9653), new DateTime(2024, 8, 20, 18, 35, 3, 695, DateTimeKind.Utc).AddTicks(9649) });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: 2024,
                columns: new[] { "ConcurrencyStamp", "CreatedTime", "LastUpdatedTime", "RefreshTokenCreateTime" },
                values: new object[] { "8de62453-c08e-4940-8925-edf3b13e7c41", new DateTime(2024, 8, 20, 18, 35, 3, 695, DateTimeKind.Utc).AddTicks(9666), new DateTime(2024, 8, 20, 18, 35, 3, 695, DateTimeKind.Utc).AddTicks(9666), new DateTime(2024, 8, 20, 18, 35, 3, 695, DateTimeKind.Utc).AddTicks(9663) });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: 2025,
                columns: new[] { "ConcurrencyStamp", "CreatedTime", "LastUpdatedTime", "RefreshTokenCreateTime" },
                values: new object[] { "aad34e89-f5de-4214-9bad-a854a149ea19", new DateTime(2024, 8, 20, 18, 35, 3, 695, DateTimeKind.Utc).AddTicks(9736), new DateTime(2024, 8, 20, 18, 35, 3, 695, DateTimeKind.Utc).AddTicks(9737), new DateTime(2024, 8, 20, 18, 35, 3, 695, DateTimeKind.Utc).AddTicks(9733) });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: 2026,
                columns: new[] { "ConcurrencyStamp", "CreatedTime", "LastUpdatedTime", "RefreshTokenCreateTime" },
                values: new object[] { "5593bc41-63f4-430b-b433-72a87e61c2c5", new DateTime(2024, 8, 20, 18, 35, 3, 695, DateTimeKind.Utc).AddTicks(9749), new DateTime(2024, 8, 20, 18, 35, 3, 695, DateTimeKind.Utc).AddTicks(9750), new DateTime(2024, 8, 20, 18, 35, 3, 695, DateTimeKind.Utc).AddTicks(9746) });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: 2027,
                columns: new[] { "ConcurrencyStamp", "CreatedTime", "LastUpdatedTime", "RefreshTokenCreateTime" },
                values: new object[] { "7061fad9-1235-4ee3-986e-7bb22ecf5254", new DateTime(2024, 8, 20, 18, 35, 3, 695, DateTimeKind.Utc).AddTicks(9763), new DateTime(2024, 8, 20, 18, 35, 3, 695, DateTimeKind.Utc).AddTicks(9763), new DateTime(2024, 8, 20, 18, 35, 3, 695, DateTimeKind.Utc).AddTicks(9760) });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: 2028,
                columns: new[] { "ConcurrencyStamp", "CreatedTime", "LastUpdatedTime", "RefreshTokenCreateTime" },
                values: new object[] { "989e192a-cb05-434a-aa22-e00a6285a4eb", new DateTime(2024, 8, 20, 18, 35, 3, 695, DateTimeKind.Utc).AddTicks(9779), new DateTime(2024, 8, 20, 18, 35, 3, 695, DateTimeKind.Utc).AddTicks(9780), new DateTime(2024, 8, 20, 18, 35, 3, 695, DateTimeKind.Utc).AddTicks(9773) });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: 2029,
                columns: new[] { "ConcurrencyStamp", "CreatedTime", "LastUpdatedTime", "RefreshTokenCreateTime" },
                values: new object[] { "391d17c2-0d20-49b1-bb50-3b7819d72851", new DateTime(2024, 8, 20, 18, 35, 3, 695, DateTimeKind.Utc).AddTicks(9793), new DateTime(2024, 8, 20, 18, 35, 3, 695, DateTimeKind.Utc).AddTicks(9793), new DateTime(2024, 8, 20, 18, 35, 3, 695, DateTimeKind.Utc).AddTicks(9790) });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: 2030,
                columns: new[] { "ConcurrencyStamp", "CreatedTime", "LastUpdatedTime", "RefreshTokenCreateTime" },
                values: new object[] { "2a6462b0-7a30-403b-90cd-8c4bb809c8c7", new DateTime(2024, 8, 20, 18, 35, 3, 695, DateTimeKind.Utc).AddTicks(9806), new DateTime(2024, 8, 20, 18, 35, 3, 695, DateTimeKind.Utc).AddTicks(9806), new DateTime(2024, 8, 20, 18, 35, 3, 695, DateTimeKind.Utc).AddTicks(9803) });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: 2031,
                columns: new[] { "ConcurrencyStamp", "CreatedTime", "LastUpdatedTime", "RefreshTokenCreateTime" },
                values: new object[] { "798e8618-9297-4d03-b950-e6d921c00ffe", new DateTime(2024, 8, 20, 18, 35, 3, 695, DateTimeKind.Utc).AddTicks(9819), new DateTime(2024, 8, 20, 18, 35, 3, 695, DateTimeKind.Utc).AddTicks(9819), new DateTime(2024, 8, 20, 18, 35, 3, 695, DateTimeKind.Utc).AddTicks(9816) });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: 2032,
                columns: new[] { "ConcurrencyStamp", "CreatedTime", "LastUpdatedTime", "RefreshTokenCreateTime" },
                values: new object[] { "86c0b41d-7ddd-42e0-9fbf-978bb2b35c54", new DateTime(2024, 8, 20, 18, 35, 3, 695, DateTimeKind.Utc).AddTicks(9832), new DateTime(2024, 8, 20, 18, 35, 3, 695, DateTimeKind.Utc).AddTicks(9832), new DateTime(2024, 8, 20, 18, 35, 3, 695, DateTimeKind.Utc).AddTicks(9829) });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: 2033,
                columns: new[] { "ConcurrencyStamp", "CreatedTime", "LastUpdatedTime", "RefreshTokenCreateTime" },
                values: new object[] { "d603c777-069e-4d74-a87b-6633a3480c77", new DateTime(2024, 8, 20, 18, 35, 3, 695, DateTimeKind.Utc).AddTicks(9845), new DateTime(2024, 8, 20, 18, 35, 3, 695, DateTimeKind.Utc).AddTicks(9845), new DateTime(2024, 8, 20, 18, 35, 3, 695, DateTimeKind.Utc).AddTicks(9842) });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: 2034,
                columns: new[] { "ConcurrencyStamp", "CreatedTime", "LastUpdatedTime", "RefreshTokenCreateTime" },
                values: new object[] { "e2e7e6b8-2ca1-4209-9ac4-6fcc40eee5ae", new DateTime(2024, 8, 20, 18, 35, 3, 695, DateTimeKind.Utc).AddTicks(9897), new DateTime(2024, 8, 20, 18, 35, 3, 695, DateTimeKind.Utc).AddTicks(9898), new DateTime(2024, 8, 20, 18, 35, 3, 695, DateTimeKind.Utc).AddTicks(9894) });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: 2035,
                columns: new[] { "ConcurrencyStamp", "CreatedTime", "LastUpdatedTime", "RefreshTokenCreateTime" },
                values: new object[] { "d8ff2049-896f-449a-97a7-97e7ae8b6097", new DateTime(2024, 8, 20, 18, 35, 3, 695, DateTimeKind.Utc).AddTicks(9911), new DateTime(2024, 8, 20, 18, 35, 3, 695, DateTimeKind.Utc).AddTicks(9912), new DateTime(2024, 8, 20, 18, 35, 3, 695, DateTimeKind.Utc).AddTicks(9908) });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: 2036,
                columns: new[] { "ConcurrencyStamp", "CreatedTime", "LastUpdatedTime", "RefreshTokenCreateTime" },
                values: new object[] { "2c06b5e0-f948-43f2-89dc-8e2993c654a2", new DateTime(2024, 8, 20, 18, 35, 3, 695, DateTimeKind.Utc).AddTicks(9927), new DateTime(2024, 8, 20, 18, 35, 3, 695, DateTimeKind.Utc).AddTicks(9928), new DateTime(2024, 8, 20, 18, 35, 3, 695, DateTimeKind.Utc).AddTicks(9922) });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: 2037,
                columns: new[] { "ConcurrencyStamp", "CreatedTime", "LastUpdatedTime", "RefreshTokenCreateTime" },
                values: new object[] { "c932a434-610d-4a8d-8020-6dede6105461", new DateTime(2024, 8, 20, 18, 35, 3, 695, DateTimeKind.Utc).AddTicks(9941), new DateTime(2024, 8, 20, 18, 35, 3, 695, DateTimeKind.Utc).AddTicks(9941), new DateTime(2024, 8, 20, 18, 35, 3, 695, DateTimeKind.Utc).AddTicks(9938) });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: 2038,
                columns: new[] { "ConcurrencyStamp", "CreatedTime", "LastUpdatedTime", "RefreshTokenCreateTime" },
                values: new object[] { "e1eef18e-4032-4f79-86e6-5e154cf51432", new DateTime(2024, 8, 20, 18, 35, 3, 695, DateTimeKind.Utc).AddTicks(9954), new DateTime(2024, 8, 20, 18, 35, 3, 695, DateTimeKind.Utc).AddTicks(9955), new DateTime(2024, 8, 20, 18, 35, 3, 695, DateTimeKind.Utc).AddTicks(9951) });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: 2039,
                columns: new[] { "ConcurrencyStamp", "CreatedTime", "LastUpdatedTime", "RefreshTokenCreateTime" },
                values: new object[] { "fee28acf-85f1-4947-b03a-9da4a11d8a0a", new DateTime(2024, 8, 20, 18, 35, 3, 695, DateTimeKind.Utc).AddTicks(9969), new DateTime(2024, 8, 20, 18, 35, 3, 695, DateTimeKind.Utc).AddTicks(9969), new DateTime(2024, 8, 20, 18, 35, 3, 695, DateTimeKind.Utc).AddTicks(9965) });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: 2040,
                columns: new[] { "ConcurrencyStamp", "CreatedTime", "LastUpdatedTime", "RefreshTokenCreateTime" },
                values: new object[] { "e96f2a3a-32ce-446b-89ae-d8b8a5dbdedb", new DateTime(2024, 8, 20, 18, 35, 3, 695, DateTimeKind.Utc).AddTicks(9982), new DateTime(2024, 8, 20, 18, 35, 3, 695, DateTimeKind.Utc).AddTicks(9982), new DateTime(2024, 8, 20, 18, 35, 3, 695, DateTimeKind.Utc).AddTicks(9979) });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: 2041,
                columns: new[] { "ConcurrencyStamp", "CreatedTime", "LastUpdatedTime", "RefreshTokenCreateTime" },
                values: new object[] { "339f59cc-af44-414e-8ab1-169ac259bfc9", new DateTime(2024, 8, 20, 18, 35, 3, 695, DateTimeKind.Utc).AddTicks(9995), new DateTime(2024, 8, 20, 18, 35, 3, 695, DateTimeKind.Utc).AddTicks(9996), new DateTime(2024, 8, 20, 18, 35, 3, 695, DateTimeKind.Utc).AddTicks(9992) });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: 2042,
                columns: new[] { "ConcurrencyStamp", "CreatedTime", "LastUpdatedTime", "RefreshTokenCreateTime" },
                values: new object[] { "7b0ca46d-8f83-4435-8f64-724a62049c21", new DateTime(2024, 8, 20, 18, 35, 3, 696, DateTimeKind.Utc).AddTicks(50), new DateTime(2024, 8, 20, 18, 35, 3, 696, DateTimeKind.Utc).AddTicks(50), new DateTime(2024, 8, 20, 18, 35, 3, 696, DateTimeKind.Utc).AddTicks(47) });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: 2043,
                columns: new[] { "ConcurrencyStamp", "CreatedTime", "LastUpdatedTime", "RefreshTokenCreateTime" },
                values: new object[] { "1e30a551-7b3a-45aa-ab7b-998e2fe5f013", new DateTime(2024, 8, 20, 18, 35, 3, 696, DateTimeKind.Utc).AddTicks(63), new DateTime(2024, 8, 20, 18, 35, 3, 696, DateTimeKind.Utc).AddTicks(64), new DateTime(2024, 8, 20, 18, 35, 3, 696, DateTimeKind.Utc).AddTicks(60) });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: 2044,
                columns: new[] { "ConcurrencyStamp", "CreatedTime", "LastUpdatedTime", "RefreshTokenCreateTime" },
                values: new object[] { "23055c63-d80c-4b4a-846c-9bbe1f69d66a", new DateTime(2024, 8, 20, 18, 35, 3, 696, DateTimeKind.Utc).AddTicks(79), new DateTime(2024, 8, 20, 18, 35, 3, 696, DateTimeKind.Utc).AddTicks(79), new DateTime(2024, 8, 20, 18, 35, 3, 696, DateTimeKind.Utc).AddTicks(73) });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: 2045,
                columns: new[] { "ConcurrencyStamp", "CreatedTime", "LastUpdatedTime", "RefreshTokenCreateTime" },
                values: new object[] { "6abd5e2f-dcf3-4c54-86f1-f832e247a486", new DateTime(2024, 8, 20, 18, 35, 3, 696, DateTimeKind.Utc).AddTicks(91), new DateTime(2024, 8, 20, 18, 35, 3, 696, DateTimeKind.Utc).AddTicks(91), new DateTime(2024, 8, 20, 18, 35, 3, 696, DateTimeKind.Utc).AddTicks(88) });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: 2046,
                columns: new[] { "ConcurrencyStamp", "CreatedTime", "LastUpdatedTime", "RefreshTokenCreateTime" },
                values: new object[] { "b03a363f-409c-4b4c-8d3a-c7327914b351", new DateTime(2024, 8, 20, 18, 35, 3, 696, DateTimeKind.Utc).AddTicks(103), new DateTime(2024, 8, 20, 18, 35, 3, 696, DateTimeKind.Utc).AddTicks(104), new DateTime(2024, 8, 20, 18, 35, 3, 696, DateTimeKind.Utc).AddTicks(100) });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: 2047,
                columns: new[] { "ConcurrencyStamp", "CreatedTime", "LastUpdatedTime", "RefreshTokenCreateTime" },
                values: new object[] { "c07f5893-5a5f-456f-a8dc-a523d9aac2c0", new DateTime(2024, 8, 20, 18, 35, 3, 696, DateTimeKind.Utc).AddTicks(116), new DateTime(2024, 8, 20, 18, 35, 3, 696, DateTimeKind.Utc).AddTicks(116), new DateTime(2024, 8, 20, 18, 35, 3, 696, DateTimeKind.Utc).AddTicks(113) });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: 2048,
                columns: new[] { "ConcurrencyStamp", "CreatedTime", "LastUpdatedTime", "RefreshTokenCreateTime" },
                values: new object[] { "4677e5c4-217d-4af5-98cc-acea9aa43e16", new DateTime(2024, 8, 20, 18, 35, 3, 696, DateTimeKind.Utc).AddTicks(129), new DateTime(2024, 8, 20, 18, 35, 3, 696, DateTimeKind.Utc).AddTicks(129), new DateTime(2024, 8, 20, 18, 35, 3, 696, DateTimeKind.Utc).AddTicks(125) });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: 2049,
                columns: new[] { "ConcurrencyStamp", "CreatedTime", "LastUpdatedTime", "RefreshTokenCreateTime" },
                values: new object[] { "ce5477d5-f6ec-457a-bf91-97dbf418296d", new DateTime(2024, 8, 20, 18, 35, 3, 696, DateTimeKind.Utc).AddTicks(141), new DateTime(2024, 8, 20, 18, 35, 3, 696, DateTimeKind.Utc).AddTicks(142), new DateTime(2024, 8, 20, 18, 35, 3, 696, DateTimeKind.Utc).AddTicks(138) });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: 2050,
                columns: new[] { "ConcurrencyStamp", "CreatedTime", "LastUpdatedTime", "RefreshTokenCreateTime" },
                values: new object[] { "da97cdce-0a12-45f5-9260-d7a201820fac", new DateTime(2024, 8, 20, 18, 35, 3, 696, DateTimeKind.Utc).AddTicks(153), new DateTime(2024, 8, 20, 18, 35, 3, 696, DateTimeKind.Utc).AddTicks(154), new DateTime(2024, 8, 20, 18, 35, 3, 696, DateTimeKind.Utc).AddTicks(150) });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: 2051,
                columns: new[] { "ConcurrencyStamp", "CreatedTime", "LastUpdatedTime", "RefreshTokenCreateTime" },
                values: new object[] { "c76ea76a-c0df-40bb-ad87-631310c68839", new DateTime(2024, 8, 20, 18, 35, 3, 696, DateTimeKind.Utc).AddTicks(166), new DateTime(2024, 8, 20, 18, 35, 3, 696, DateTimeKind.Utc).AddTicks(166), new DateTime(2024, 8, 20, 18, 35, 3, 696, DateTimeKind.Utc).AddTicks(163) });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: 2052,
                columns: new[] { "ConcurrencyStamp", "CreatedTime", "LastUpdatedTime", "RefreshTokenCreateTime" },
                values: new object[] { "ba7beaad-4b47-48ea-89ac-af5c8786ac08", new DateTime(2024, 8, 20, 18, 35, 3, 696, DateTimeKind.Utc).AddTicks(233), new DateTime(2024, 8, 20, 18, 35, 3, 696, DateTimeKind.Utc).AddTicks(234), new DateTime(2024, 8, 20, 18, 35, 3, 696, DateTimeKind.Utc).AddTicks(175) });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: 2053,
                columns: new[] { "ConcurrencyStamp", "CreatedTime", "LastUpdatedTime", "RefreshTokenCreateTime" },
                values: new object[] { "968c8d7f-8735-47b4-8dc6-71c44d349e76", new DateTime(2024, 8, 20, 18, 35, 3, 696, DateTimeKind.Utc).AddTicks(246), new DateTime(2024, 8, 20, 18, 35, 3, 696, DateTimeKind.Utc).AddTicks(247), new DateTime(2024, 8, 20, 18, 35, 3, 696, DateTimeKind.Utc).AddTicks(243) });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: 2054,
                columns: new[] { "ConcurrencyStamp", "CreatedTime", "LastUpdatedTime", "RefreshTokenCreateTime" },
                values: new object[] { "9614d2ad-fc6e-4c33-b741-c3515dd00557", new DateTime(2024, 8, 20, 18, 35, 3, 696, DateTimeKind.Utc).AddTicks(259), new DateTime(2024, 8, 20, 18, 35, 3, 696, DateTimeKind.Utc).AddTicks(260), new DateTime(2024, 8, 20, 18, 35, 3, 696, DateTimeKind.Utc).AddTicks(256) });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: 2055,
                columns: new[] { "ConcurrencyStamp", "CreatedTime", "LastUpdatedTime", "RefreshTokenCreateTime" },
                values: new object[] { "bc79e280-4605-4449-97a4-2cc65ab90a53", new DateTime(2024, 8, 20, 18, 35, 3, 696, DateTimeKind.Utc).AddTicks(272), new DateTime(2024, 8, 20, 18, 35, 3, 696, DateTimeKind.Utc).AddTicks(273), new DateTime(2024, 8, 20, 18, 35, 3, 696, DateTimeKind.Utc).AddTicks(269) });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: 2056,
                columns: new[] { "ConcurrencyStamp", "CreatedTime", "LastUpdatedTime", "RefreshTokenCreateTime" },
                values: new object[] { "fb81eff2-f1f1-4817-9a46-3c9ab52dfb08", new DateTime(2024, 8, 20, 18, 35, 3, 696, DateTimeKind.Utc).AddTicks(284), new DateTime(2024, 8, 20, 18, 35, 3, 696, DateTimeKind.Utc).AddTicks(284), new DateTime(2024, 8, 20, 18, 35, 3, 696, DateTimeKind.Utc).AddTicks(281) });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: 2057,
                columns: new[] { "ConcurrencyStamp", "CreatedTime", "LastUpdatedTime", "RefreshTokenCreateTime" },
                values: new object[] { "e9584a8e-14fc-44a3-ac24-d18357ffacbc", new DateTime(2024, 8, 20, 18, 35, 3, 696, DateTimeKind.Utc).AddTicks(296), new DateTime(2024, 8, 20, 18, 35, 3, 696, DateTimeKind.Utc).AddTicks(297), new DateTime(2024, 8, 20, 18, 35, 3, 696, DateTimeKind.Utc).AddTicks(293) });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: 2058,
                columns: new[] { "ConcurrencyStamp", "CreatedTime", "LastUpdatedTime", "RefreshTokenCreateTime" },
                values: new object[] { "d1ee1aea-107c-4fb5-b7bf-b3fb8dd24792", new DateTime(2024, 8, 20, 18, 35, 3, 696, DateTimeKind.Utc).AddTicks(309), new DateTime(2024, 8, 20, 18, 35, 3, 696, DateTimeKind.Utc).AddTicks(309), new DateTime(2024, 8, 20, 18, 35, 3, 696, DateTimeKind.Utc).AddTicks(305) });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: 2059,
                columns: new[] { "ConcurrencyStamp", "CreatedTime", "LastUpdatedTime", "RefreshTokenCreateTime" },
                values: new object[] { "6b2fbabb-f8af-406c-815d-30b6dd96afc1", new DateTime(2024, 8, 20, 18, 35, 3, 696, DateTimeKind.Utc).AddTicks(321), new DateTime(2024, 8, 20, 18, 35, 3, 696, DateTimeKind.Utc).AddTicks(321), new DateTime(2024, 8, 20, 18, 35, 3, 696, DateTimeKind.Utc).AddTicks(318) });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: 2060,
                columns: new[] { "ConcurrencyStamp", "CreatedTime", "LastUpdatedTime", "RefreshTokenCreateTime" },
                values: new object[] { "b54a8800-3a4c-4a85-b6c2-13fcb9c5ab61", new DateTime(2024, 8, 20, 18, 35, 3, 696, DateTimeKind.Utc).AddTicks(337), new DateTime(2024, 8, 20, 18, 35, 3, 696, DateTimeKind.Utc).AddTicks(337), new DateTime(2024, 8, 20, 18, 35, 3, 696, DateTimeKind.Utc).AddTicks(330) });

            migrationBuilder.UpdateData(
                table: "Breeds",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedTime",
                value: new DateTime(2024, 8, 20, 22, 35, 3, 684, DateTimeKind.Local).AddTicks(8718));

            migrationBuilder.UpdateData(
                table: "Breeds",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreatedTime",
                value: new DateTime(2024, 8, 20, 22, 35, 3, 684, DateTimeKind.Local).AddTicks(8731));

            migrationBuilder.UpdateData(
                table: "Breeds",
                keyColumn: "Id",
                keyValue: 3,
                column: "CreatedTime",
                value: new DateTime(2024, 8, 20, 22, 35, 3, 684, DateTimeKind.Local).AddTicks(8733));

            migrationBuilder.UpdateData(
                table: "Breeds",
                keyColumn: "Id",
                keyValue: 4,
                column: "CreatedTime",
                value: new DateTime(2024, 8, 20, 22, 35, 3, 684, DateTimeKind.Local).AddTicks(8734));

            migrationBuilder.UpdateData(
                table: "Breeds",
                keyColumn: "Id",
                keyValue: 5,
                column: "CreatedTime",
                value: new DateTime(2024, 8, 20, 22, 35, 3, 684, DateTimeKind.Local).AddTicks(8736));

            migrationBuilder.UpdateData(
                table: "Breeds",
                keyColumn: "Id",
                keyValue: 6,
                column: "CreatedTime",
                value: new DateTime(2024, 8, 20, 22, 35, 3, 684, DateTimeKind.Local).AddTicks(8737));

            migrationBuilder.UpdateData(
                table: "Breeds",
                keyColumn: "Id",
                keyValue: 7,
                column: "CreatedTime",
                value: new DateTime(2024, 8, 20, 22, 35, 3, 684, DateTimeKind.Local).AddTicks(8739));

            migrationBuilder.UpdateData(
                table: "Breeds",
                keyColumn: "Id",
                keyValue: 8,
                column: "CreatedTime",
                value: new DateTime(2024, 8, 20, 22, 35, 3, 684, DateTimeKind.Local).AddTicks(8741));

            migrationBuilder.UpdateData(
                table: "Breeds",
                keyColumn: "Id",
                keyValue: 9,
                column: "CreatedTime",
                value: new DateTime(2024, 8, 20, 22, 35, 3, 684, DateTimeKind.Local).AddTicks(8742));

            migrationBuilder.UpdateData(
                table: "Breeds",
                keyColumn: "Id",
                keyValue: 10,
                column: "CreatedTime",
                value: new DateTime(2024, 8, 20, 22, 35, 3, 684, DateTimeKind.Local).AddTicks(8743));

            migrationBuilder.UpdateData(
                table: "Breeds",
                keyColumn: "Id",
                keyValue: 11,
                column: "CreatedTime",
                value: new DateTime(2024, 8, 20, 22, 35, 3, 684, DateTimeKind.Local).AddTicks(8745));

            migrationBuilder.UpdateData(
                table: "Breeds",
                keyColumn: "Id",
                keyValue: 12,
                column: "CreatedTime",
                value: new DateTime(2024, 8, 20, 22, 35, 3, 684, DateTimeKind.Local).AddTicks(8746));

            migrationBuilder.UpdateData(
                table: "Breeds",
                keyColumn: "Id",
                keyValue: 13,
                column: "CreatedTime",
                value: new DateTime(2024, 8, 20, 22, 35, 3, 684, DateTimeKind.Local).AddTicks(8747));

            migrationBuilder.UpdateData(
                table: "Breeds",
                keyColumn: "Id",
                keyValue: 14,
                column: "CreatedTime",
                value: new DateTime(2024, 8, 20, 22, 35, 3, 684, DateTimeKind.Local).AddTicks(8749));

            migrationBuilder.UpdateData(
                table: "Breeds",
                keyColumn: "Id",
                keyValue: 15,
                column: "CreatedTime",
                value: new DateTime(2024, 8, 20, 22, 35, 3, 684, DateTimeKind.Local).AddTicks(8750));

            migrationBuilder.UpdateData(
                table: "Breeds",
                keyColumn: "Id",
                keyValue: 16,
                column: "CreatedTime",
                value: new DateTime(2024, 8, 20, 22, 35, 3, 684, DateTimeKind.Local).AddTicks(8751));

            migrationBuilder.UpdateData(
                table: "Breeds",
                keyColumn: "Id",
                keyValue: 17,
                column: "CreatedTime",
                value: new DateTime(2024, 8, 20, 22, 35, 3, 684, DateTimeKind.Local).AddTicks(8753));

            migrationBuilder.UpdateData(
                table: "Breeds",
                keyColumn: "Id",
                keyValue: 18,
                column: "CreatedTime",
                value: new DateTime(2024, 8, 20, 22, 35, 3, 684, DateTimeKind.Local).AddTicks(8755));

            migrationBuilder.UpdateData(
                table: "Breeds",
                keyColumn: "Id",
                keyValue: 19,
                column: "CreatedTime",
                value: new DateTime(2024, 8, 20, 22, 35, 3, 684, DateTimeKind.Local).AddTicks(8756));

            migrationBuilder.UpdateData(
                table: "Breeds",
                keyColumn: "Id",
                keyValue: 20,
                column: "CreatedTime",
                value: new DateTime(2024, 8, 20, 22, 35, 3, 684, DateTimeKind.Local).AddTicks(8757));

            migrationBuilder.UpdateData(
                table: "Breeds",
                keyColumn: "Id",
                keyValue: 21,
                column: "CreatedTime",
                value: new DateTime(2024, 8, 20, 22, 35, 3, 684, DateTimeKind.Local).AddTicks(8759));

            migrationBuilder.UpdateData(
                table: "Breeds",
                keyColumn: "Id",
                keyValue: 22,
                column: "CreatedTime",
                value: new DateTime(2024, 8, 20, 22, 35, 3, 684, DateTimeKind.Local).AddTicks(8760));

            migrationBuilder.UpdateData(
                table: "Breeds",
                keyColumn: "Id",
                keyValue: 23,
                column: "CreatedTime",
                value: new DateTime(2024, 8, 20, 22, 35, 3, 684, DateTimeKind.Local).AddTicks(8761));

            migrationBuilder.UpdateData(
                table: "Breeds",
                keyColumn: "Id",
                keyValue: 24,
                column: "CreatedTime",
                value: new DateTime(2024, 8, 20, 22, 35, 3, 684, DateTimeKind.Local).AddTicks(8762));

            migrationBuilder.UpdateData(
                table: "Breeds",
                keyColumn: "Id",
                keyValue: 25,
                column: "CreatedTime",
                value: new DateTime(2024, 8, 20, 22, 35, 3, 684, DateTimeKind.Local).AddTicks(8764));

            migrationBuilder.UpdateData(
                table: "Breeds",
                keyColumn: "Id",
                keyValue: 26,
                column: "CreatedTime",
                value: new DateTime(2024, 8, 20, 22, 35, 3, 684, DateTimeKind.Local).AddTicks(8765));

            migrationBuilder.UpdateData(
                table: "Breeds",
                keyColumn: "Id",
                keyValue: 27,
                column: "CreatedTime",
                value: new DateTime(2024, 8, 20, 22, 35, 3, 684, DateTimeKind.Local).AddTicks(8766));

            migrationBuilder.UpdateData(
                table: "Breeds",
                keyColumn: "Id",
                keyValue: 28,
                column: "CreatedTime",
                value: new DateTime(2024, 8, 20, 22, 35, 3, 684, DateTimeKind.Local).AddTicks(8768));

            migrationBuilder.UpdateData(
                table: "Breeds",
                keyColumn: "Id",
                keyValue: 29,
                column: "CreatedTime",
                value: new DateTime(2024, 8, 20, 22, 35, 3, 684, DateTimeKind.Local).AddTicks(8769));

            migrationBuilder.UpdateData(
                table: "Breeds",
                keyColumn: "Id",
                keyValue: 30,
                column: "CreatedTime",
                value: new DateTime(2024, 8, 20, 22, 35, 3, 684, DateTimeKind.Local).AddTicks(8770));

            migrationBuilder.UpdateData(
                table: "Breeds",
                keyColumn: "Id",
                keyValue: 31,
                column: "CreatedTime",
                value: new DateTime(2024, 8, 20, 22, 35, 3, 684, DateTimeKind.Local).AddTicks(8772));

            migrationBuilder.UpdateData(
                table: "Breeds",
                keyColumn: "Id",
                keyValue: 32,
                column: "CreatedTime",
                value: new DateTime(2024, 8, 20, 22, 35, 3, 684, DateTimeKind.Local).AddTicks(8773));

            migrationBuilder.UpdateData(
                table: "Breeds",
                keyColumn: "Id",
                keyValue: 33,
                column: "CreatedTime",
                value: new DateTime(2024, 8, 20, 22, 35, 3, 684, DateTimeKind.Local).AddTicks(8774));

            migrationBuilder.UpdateData(
                table: "Breeds",
                keyColumn: "Id",
                keyValue: 34,
                column: "CreatedTime",
                value: new DateTime(2024, 8, 20, 22, 35, 3, 684, DateTimeKind.Local).AddTicks(8776));

            migrationBuilder.UpdateData(
                table: "Breeds",
                keyColumn: "Id",
                keyValue: 35,
                column: "CreatedTime",
                value: new DateTime(2024, 8, 20, 22, 35, 3, 684, DateTimeKind.Local).AddTicks(8777));

            migrationBuilder.UpdateData(
                table: "Breeds",
                keyColumn: "Id",
                keyValue: 36,
                column: "CreatedTime",
                value: new DateTime(2024, 8, 20, 22, 35, 3, 684, DateTimeKind.Local).AddTicks(8778));

            migrationBuilder.UpdateData(
                table: "Breeds",
                keyColumn: "Id",
                keyValue: 37,
                column: "CreatedTime",
                value: new DateTime(2024, 8, 20, 22, 35, 3, 684, DateTimeKind.Local).AddTicks(8780));

            migrationBuilder.UpdateData(
                table: "Breeds",
                keyColumn: "Id",
                keyValue: 38,
                column: "CreatedTime",
                value: new DateTime(2024, 8, 20, 22, 35, 3, 684, DateTimeKind.Local).AddTicks(8781));

            migrationBuilder.UpdateData(
                table: "Breeds",
                keyColumn: "Id",
                keyValue: 39,
                column: "CreatedTime",
                value: new DateTime(2024, 8, 20, 22, 35, 3, 684, DateTimeKind.Local).AddTicks(8783));

            migrationBuilder.UpdateData(
                table: "Breeds",
                keyColumn: "Id",
                keyValue: 40,
                column: "CreatedTime",
                value: new DateTime(2024, 8, 20, 22, 35, 3, 684, DateTimeKind.Local).AddTicks(8784));

            migrationBuilder.UpdateData(
                table: "Breeds",
                keyColumn: "Id",
                keyValue: 41,
                column: "CreatedTime",
                value: new DateTime(2024, 8, 20, 22, 35, 3, 684, DateTimeKind.Local).AddTicks(8785));

            migrationBuilder.UpdateData(
                table: "Breeds",
                keyColumn: "Id",
                keyValue: 42,
                column: "CreatedTime",
                value: new DateTime(2024, 8, 20, 22, 35, 3, 684, DateTimeKind.Local).AddTicks(8786));

            migrationBuilder.UpdateData(
                table: "Breeds",
                keyColumn: "Id",
                keyValue: 43,
                column: "CreatedTime",
                value: new DateTime(2024, 8, 20, 22, 35, 3, 684, DateTimeKind.Local).AddTicks(8788));

            migrationBuilder.UpdateData(
                table: "Breeds",
                keyColumn: "Id",
                keyValue: 44,
                column: "CreatedTime",
                value: new DateTime(2024, 8, 20, 22, 35, 3, 684, DateTimeKind.Local).AddTicks(8789));

            migrationBuilder.UpdateData(
                table: "Breeds",
                keyColumn: "Id",
                keyValue: 45,
                column: "CreatedTime",
                value: new DateTime(2024, 8, 20, 22, 35, 3, 684, DateTimeKind.Local).AddTicks(8791));

            migrationBuilder.UpdateData(
                table: "Breeds",
                keyColumn: "Id",
                keyValue: 46,
                column: "CreatedTime",
                value: new DateTime(2024, 8, 20, 22, 35, 3, 684, DateTimeKind.Local).AddTicks(8792));

            migrationBuilder.UpdateData(
                table: "Breeds",
                keyColumn: "Id",
                keyValue: 47,
                column: "CreatedTime",
                value: new DateTime(2024, 8, 20, 22, 35, 3, 684, DateTimeKind.Local).AddTicks(8794));

            migrationBuilder.UpdateData(
                table: "Breeds",
                keyColumn: "Id",
                keyValue: 48,
                column: "CreatedTime",
                value: new DateTime(2024, 8, 20, 22, 35, 3, 684, DateTimeKind.Local).AddTicks(8795));

            migrationBuilder.UpdateData(
                table: "Breeds",
                keyColumn: "Id",
                keyValue: 49,
                column: "CreatedTime",
                value: new DateTime(2024, 8, 20, 22, 35, 3, 684, DateTimeKind.Local).AddTicks(8796));

            migrationBuilder.UpdateData(
                table: "Breeds",
                keyColumn: "Id",
                keyValue: 50,
                column: "CreatedTime",
                value: new DateTime(2024, 8, 20, 22, 35, 3, 684, DateTimeKind.Local).AddTicks(8798));

            migrationBuilder.UpdateData(
                table: "Breeds",
                keyColumn: "Id",
                keyValue: 51,
                column: "CreatedTime",
                value: new DateTime(2024, 8, 20, 22, 35, 3, 684, DateTimeKind.Local).AddTicks(8799));

            migrationBuilder.UpdateData(
                table: "Breeds",
                keyColumn: "Id",
                keyValue: 52,
                column: "CreatedTime",
                value: new DateTime(2024, 8, 20, 22, 35, 3, 684, DateTimeKind.Local).AddTicks(8801));

            migrationBuilder.UpdateData(
                table: "Breeds",
                keyColumn: "Id",
                keyValue: 53,
                column: "CreatedTime",
                value: new DateTime(2024, 8, 20, 22, 35, 3, 684, DateTimeKind.Local).AddTicks(8802));

            migrationBuilder.UpdateData(
                table: "Breeds",
                keyColumn: "Id",
                keyValue: 54,
                column: "CreatedTime",
                value: new DateTime(2024, 8, 20, 22, 35, 3, 684, DateTimeKind.Local).AddTicks(8803));

            migrationBuilder.UpdateData(
                table: "Breeds",
                keyColumn: "Id",
                keyValue: 55,
                column: "CreatedTime",
                value: new DateTime(2024, 8, 20, 22, 35, 3, 684, DateTimeKind.Local).AddTicks(8805));

            migrationBuilder.UpdateData(
                table: "Breeds",
                keyColumn: "Id",
                keyValue: 56,
                column: "CreatedTime",
                value: new DateTime(2024, 8, 20, 22, 35, 3, 684, DateTimeKind.Local).AddTicks(8806));

            migrationBuilder.UpdateData(
                table: "Breeds",
                keyColumn: "Id",
                keyValue: 57,
                column: "CreatedTime",
                value: new DateTime(2024, 8, 20, 22, 35, 3, 684, DateTimeKind.Local).AddTicks(8807));

            migrationBuilder.UpdateData(
                table: "Breeds",
                keyColumn: "Id",
                keyValue: 58,
                column: "CreatedTime",
                value: new DateTime(2024, 8, 20, 22, 35, 3, 684, DateTimeKind.Local).AddTicks(8809));

            migrationBuilder.UpdateData(
                table: "Breeds",
                keyColumn: "Id",
                keyValue: 59,
                column: "CreatedTime",
                value: new DateTime(2024, 8, 20, 22, 35, 3, 684, DateTimeKind.Local).AddTicks(8810));

            migrationBuilder.UpdateData(
                table: "Breeds",
                keyColumn: "Id",
                keyValue: 60,
                column: "CreatedTime",
                value: new DateTime(2024, 8, 20, 22, 35, 3, 684, DateTimeKind.Local).AddTicks(8811));

            migrationBuilder.UpdateData(
                table: "Breeds",
                keyColumn: "Id",
                keyValue: 61,
                column: "CreatedTime",
                value: new DateTime(2024, 8, 20, 22, 35, 3, 684, DateTimeKind.Local).AddTicks(8813));

            migrationBuilder.UpdateData(
                table: "Breeds",
                keyColumn: "Id",
                keyValue: 62,
                column: "CreatedTime",
                value: new DateTime(2024, 8, 20, 22, 35, 3, 684, DateTimeKind.Local).AddTicks(8814));

            migrationBuilder.UpdateData(
                table: "Breeds",
                keyColumn: "Id",
                keyValue: 63,
                column: "CreatedTime",
                value: new DateTime(2024, 8, 20, 22, 35, 3, 684, DateTimeKind.Local).AddTicks(8815));

            migrationBuilder.UpdateData(
                table: "Breeds",
                keyColumn: "Id",
                keyValue: 64,
                column: "CreatedTime",
                value: new DateTime(2024, 8, 20, 22, 35, 3, 684, DateTimeKind.Local).AddTicks(8817));

            migrationBuilder.UpdateData(
                table: "Breeds",
                keyColumn: "Id",
                keyValue: 65,
                column: "CreatedTime",
                value: new DateTime(2024, 8, 20, 22, 35, 3, 684, DateTimeKind.Local).AddTicks(8818));

            migrationBuilder.UpdateData(
                table: "Breeds",
                keyColumn: "Id",
                keyValue: 66,
                column: "CreatedTime",
                value: new DateTime(2024, 8, 20, 22, 35, 3, 684, DateTimeKind.Local).AddTicks(8819));

            migrationBuilder.UpdateData(
                table: "Breeds",
                keyColumn: "Id",
                keyValue: 67,
                column: "CreatedTime",
                value: new DateTime(2024, 8, 20, 22, 35, 3, 684, DateTimeKind.Local).AddTicks(8821));

            migrationBuilder.UpdateData(
                table: "Breeds",
                keyColumn: "Id",
                keyValue: 68,
                column: "CreatedTime",
                value: new DateTime(2024, 8, 20, 22, 35, 3, 684, DateTimeKind.Local).AddTicks(8822));

            migrationBuilder.UpdateData(
                table: "Breeds",
                keyColumn: "Id",
                keyValue: 69,
                column: "CreatedTime",
                value: new DateTime(2024, 8, 20, 22, 35, 3, 684, DateTimeKind.Local).AddTicks(8824));

            migrationBuilder.UpdateData(
                table: "Breeds",
                keyColumn: "Id",
                keyValue: 70,
                column: "CreatedTime",
                value: new DateTime(2024, 8, 20, 22, 35, 3, 684, DateTimeKind.Local).AddTicks(8825));

            migrationBuilder.UpdateData(
                table: "Breeds",
                keyColumn: "Id",
                keyValue: 71,
                column: "CreatedTime",
                value: new DateTime(2024, 8, 20, 22, 35, 3, 684, DateTimeKind.Local).AddTicks(8826));

            migrationBuilder.UpdateData(
                table: "Breeds",
                keyColumn: "Id",
                keyValue: 72,
                column: "CreatedTime",
                value: new DateTime(2024, 8, 20, 22, 35, 3, 684, DateTimeKind.Local).AddTicks(8828));

            migrationBuilder.UpdateData(
                table: "Breeds",
                keyColumn: "Id",
                keyValue: 73,
                column: "CreatedTime",
                value: new DateTime(2024, 8, 20, 22, 35, 3, 684, DateTimeKind.Local).AddTicks(8829));

            migrationBuilder.UpdateData(
                table: "Breeds",
                keyColumn: "Id",
                keyValue: 74,
                column: "CreatedTime",
                value: new DateTime(2024, 8, 20, 22, 35, 3, 684, DateTimeKind.Local).AddTicks(8830));

            migrationBuilder.UpdateData(
                table: "Breeds",
                keyColumn: "Id",
                keyValue: 75,
                column: "CreatedTime",
                value: new DateTime(2024, 8, 20, 22, 35, 3, 684, DateTimeKind.Local).AddTicks(8831));

            migrationBuilder.UpdateData(
                table: "Breeds",
                keyColumn: "Id",
                keyValue: 76,
                column: "CreatedTime",
                value: new DateTime(2024, 8, 20, 22, 35, 3, 684, DateTimeKind.Local).AddTicks(8834));

            migrationBuilder.UpdateData(
                table: "Breeds",
                keyColumn: "Id",
                keyValue: 77,
                column: "CreatedTime",
                value: new DateTime(2024, 8, 20, 22, 35, 3, 684, DateTimeKind.Local).AddTicks(8835));

            migrationBuilder.UpdateData(
                table: "Breeds",
                keyColumn: "Id",
                keyValue: 78,
                column: "CreatedTime",
                value: new DateTime(2024, 8, 20, 22, 35, 3, 684, DateTimeKind.Local).AddTicks(8836));

            migrationBuilder.UpdateData(
                table: "Breeds",
                keyColumn: "Id",
                keyValue: 79,
                column: "CreatedTime",
                value: new DateTime(2024, 8, 20, 22, 35, 3, 684, DateTimeKind.Local).AddTicks(8838));

            migrationBuilder.UpdateData(
                table: "Breeds",
                keyColumn: "Id",
                keyValue: 80,
                column: "CreatedTime",
                value: new DateTime(2024, 8, 20, 22, 35, 3, 684, DateTimeKind.Local).AddTicks(8839));

            migrationBuilder.UpdateData(
                table: "Breeds",
                keyColumn: "Id",
                keyValue: 81,
                column: "CreatedTime",
                value: new DateTime(2024, 8, 20, 22, 35, 3, 684, DateTimeKind.Local).AddTicks(8841));

            migrationBuilder.UpdateData(
                table: "Breeds",
                keyColumn: "Id",
                keyValue: 82,
                column: "CreatedTime",
                value: new DateTime(2024, 8, 20, 22, 35, 3, 684, DateTimeKind.Local).AddTicks(8842));

            migrationBuilder.UpdateData(
                table: "Breeds",
                keyColumn: "Id",
                keyValue: 83,
                column: "CreatedTime",
                value: new DateTime(2024, 8, 20, 22, 35, 3, 684, DateTimeKind.Local).AddTicks(8843));

            migrationBuilder.UpdateData(
                table: "Breeds",
                keyColumn: "Id",
                keyValue: 84,
                column: "CreatedTime",
                value: new DateTime(2024, 8, 20, 22, 35, 3, 684, DateTimeKind.Local).AddTicks(8844));

            migrationBuilder.UpdateData(
                table: "Breeds",
                keyColumn: "Id",
                keyValue: 85,
                column: "CreatedTime",
                value: new DateTime(2024, 8, 20, 22, 35, 3, 684, DateTimeKind.Local).AddTicks(8846));

            migrationBuilder.UpdateData(
                table: "Breeds",
                keyColumn: "Id",
                keyValue: 86,
                column: "CreatedTime",
                value: new DateTime(2024, 8, 20, 22, 35, 3, 684, DateTimeKind.Local).AddTicks(8847));

            migrationBuilder.UpdateData(
                table: "Breeds",
                keyColumn: "Id",
                keyValue: 87,
                column: "CreatedTime",
                value: new DateTime(2024, 8, 20, 22, 35, 3, 684, DateTimeKind.Local).AddTicks(8848));

            migrationBuilder.UpdateData(
                table: "Breeds",
                keyColumn: "Id",
                keyValue: 88,
                column: "CreatedTime",
                value: new DateTime(2024, 8, 20, 22, 35, 3, 684, DateTimeKind.Local).AddTicks(8849));

            migrationBuilder.UpdateData(
                table: "Breeds",
                keyColumn: "Id",
                keyValue: 89,
                column: "CreatedTime",
                value: new DateTime(2024, 8, 20, 22, 35, 3, 684, DateTimeKind.Local).AddTicks(8850));

            migrationBuilder.UpdateData(
                table: "Breeds",
                keyColumn: "Id",
                keyValue: 90,
                column: "CreatedTime",
                value: new DateTime(2024, 8, 20, 22, 35, 3, 684, DateTimeKind.Local).AddTicks(8852));

            migrationBuilder.UpdateData(
                table: "Breeds",
                keyColumn: "Id",
                keyValue: 91,
                column: "CreatedTime",
                value: new DateTime(2024, 8, 20, 22, 35, 3, 684, DateTimeKind.Local).AddTicks(8853));

            migrationBuilder.UpdateData(
                table: "Breeds",
                keyColumn: "Id",
                keyValue: 92,
                column: "CreatedTime",
                value: new DateTime(2024, 8, 20, 22, 35, 3, 684, DateTimeKind.Local).AddTicks(8854));

            migrationBuilder.UpdateData(
                table: "Breeds",
                keyColumn: "Id",
                keyValue: 93,
                column: "CreatedTime",
                value: new DateTime(2024, 8, 20, 22, 35, 3, 684, DateTimeKind.Local).AddTicks(8855));

            migrationBuilder.UpdateData(
                table: "Breeds",
                keyColumn: "Id",
                keyValue: 94,
                column: "CreatedTime",
                value: new DateTime(2024, 8, 20, 22, 35, 3, 684, DateTimeKind.Local).AddTicks(8856));

            migrationBuilder.UpdateData(
                table: "Breeds",
                keyColumn: "Id",
                keyValue: 95,
                column: "CreatedTime",
                value: new DateTime(2024, 8, 20, 22, 35, 3, 684, DateTimeKind.Local).AddTicks(8858));

            migrationBuilder.UpdateData(
                table: "Breeds",
                keyColumn: "Id",
                keyValue: 96,
                column: "CreatedTime",
                value: new DateTime(2024, 8, 20, 22, 35, 3, 684, DateTimeKind.Local).AddTicks(8859));

            migrationBuilder.UpdateData(
                table: "Breeds",
                keyColumn: "Id",
                keyValue: 97,
                column: "CreatedTime",
                value: new DateTime(2024, 8, 20, 22, 35, 3, 684, DateTimeKind.Local).AddTicks(8860));

            migrationBuilder.UpdateData(
                table: "Breeds",
                keyColumn: "Id",
                keyValue: 98,
                column: "CreatedTime",
                value: new DateTime(2024, 8, 20, 22, 35, 3, 684, DateTimeKind.Local).AddTicks(8861));

            migrationBuilder.UpdateData(
                table: "Breeds",
                keyColumn: "Id",
                keyValue: 99,
                column: "CreatedTime",
                value: new DateTime(2024, 8, 20, 22, 35, 3, 684, DateTimeKind.Local).AddTicks(8863));

            migrationBuilder.UpdateData(
                table: "Breeds",
                keyColumn: "Id",
                keyValue: 100,
                column: "CreatedTime",
                value: new DateTime(2024, 8, 20, 22, 35, 3, 684, DateTimeKind.Local).AddTicks(8864));

            migrationBuilder.UpdateData(
                table: "Breeds",
                keyColumn: "Id",
                keyValue: 101,
                column: "CreatedTime",
                value: new DateTime(2024, 8, 20, 22, 35, 3, 684, DateTimeKind.Local).AddTicks(8865));

            migrationBuilder.UpdateData(
                table: "Breeds",
                keyColumn: "Id",
                keyValue: 102,
                column: "CreatedTime",
                value: new DateTime(2024, 8, 20, 22, 35, 3, 684, DateTimeKind.Local).AddTicks(8866));

            migrationBuilder.UpdateData(
                table: "Breeds",
                keyColumn: "Id",
                keyValue: 103,
                column: "CreatedTime",
                value: new DateTime(2024, 8, 20, 22, 35, 3, 684, DateTimeKind.Local).AddTicks(8867));

            migrationBuilder.UpdateData(
                table: "Breeds",
                keyColumn: "Id",
                keyValue: 104,
                column: "CreatedTime",
                value: new DateTime(2024, 8, 20, 22, 35, 3, 684, DateTimeKind.Local).AddTicks(8869));

            migrationBuilder.UpdateData(
                table: "Breeds",
                keyColumn: "Id",
                keyValue: 105,
                column: "CreatedTime",
                value: new DateTime(2024, 8, 20, 22, 35, 3, 684, DateTimeKind.Local).AddTicks(8871));

            migrationBuilder.UpdateData(
                table: "Breeds",
                keyColumn: "Id",
                keyValue: 106,
                column: "CreatedTime",
                value: new DateTime(2024, 8, 20, 22, 35, 3, 684, DateTimeKind.Local).AddTicks(8872));

            migrationBuilder.UpdateData(
                table: "Breeds",
                keyColumn: "Id",
                keyValue: 107,
                column: "CreatedTime",
                value: new DateTime(2024, 8, 20, 22, 35, 3, 684, DateTimeKind.Local).AddTicks(8873));

            migrationBuilder.UpdateData(
                table: "Breeds",
                keyColumn: "Id",
                keyValue: 108,
                column: "CreatedTime",
                value: new DateTime(2024, 8, 20, 22, 35, 3, 684, DateTimeKind.Local).AddTicks(8875));

            migrationBuilder.UpdateData(
                table: "Breeds",
                keyColumn: "Id",
                keyValue: 109,
                column: "CreatedTime",
                value: new DateTime(2024, 8, 20, 22, 35, 3, 684, DateTimeKind.Local).AddTicks(8877));

            migrationBuilder.UpdateData(
                table: "Breeds",
                keyColumn: "Id",
                keyValue: 110,
                column: "CreatedTime",
                value: new DateTime(2024, 8, 20, 22, 35, 3, 684, DateTimeKind.Local).AddTicks(8879));

            migrationBuilder.UpdateData(
                table: "Breeds",
                keyColumn: "Id",
                keyValue: 111,
                column: "CreatedTime",
                value: new DateTime(2024, 8, 20, 22, 35, 3, 684, DateTimeKind.Local).AddTicks(8880));

            migrationBuilder.UpdateData(
                table: "Breeds",
                keyColumn: "Id",
                keyValue: 112,
                column: "CreatedTime",
                value: new DateTime(2024, 8, 20, 22, 35, 3, 684, DateTimeKind.Local).AddTicks(8881));

            migrationBuilder.UpdateData(
                table: "Breeds",
                keyColumn: "Id",
                keyValue: 113,
                column: "CreatedTime",
                value: new DateTime(2024, 8, 20, 22, 35, 3, 684, DateTimeKind.Local).AddTicks(8882));

            migrationBuilder.UpdateData(
                table: "Breeds",
                keyColumn: "Id",
                keyValue: 114,
                column: "CreatedTime",
                value: new DateTime(2024, 8, 20, 22, 35, 3, 684, DateTimeKind.Local).AddTicks(8884));

            migrationBuilder.UpdateData(
                table: "Breeds",
                keyColumn: "Id",
                keyValue: 115,
                column: "CreatedTime",
                value: new DateTime(2024, 8, 20, 22, 35, 3, 684, DateTimeKind.Local).AddTicks(8885));

            migrationBuilder.UpdateData(
                table: "Breeds",
                keyColumn: "Id",
                keyValue: 116,
                column: "CreatedTime",
                value: new DateTime(2024, 8, 20, 22, 35, 3, 684, DateTimeKind.Local).AddTicks(8886));

            migrationBuilder.UpdateData(
                table: "Breeds",
                keyColumn: "Id",
                keyValue: 117,
                column: "CreatedTime",
                value: new DateTime(2024, 8, 20, 22, 35, 3, 684, DateTimeKind.Local).AddTicks(8888));

            migrationBuilder.UpdateData(
                table: "Breeds",
                keyColumn: "Id",
                keyValue: 118,
                column: "CreatedTime",
                value: new DateTime(2024, 8, 20, 22, 35, 3, 684, DateTimeKind.Local).AddTicks(8889));

            migrationBuilder.UpdateData(
                table: "Breeds",
                keyColumn: "Id",
                keyValue: 119,
                column: "CreatedTime",
                value: new DateTime(2024, 8, 20, 22, 35, 3, 684, DateTimeKind.Local).AddTicks(8891));

            migrationBuilder.UpdateData(
                table: "Breeds",
                keyColumn: "Id",
                keyValue: 120,
                column: "CreatedTime",
                value: new DateTime(2024, 8, 20, 22, 35, 3, 684, DateTimeKind.Local).AddTicks(8993));

            migrationBuilder.UpdateData(
                table: "Breeds",
                keyColumn: "Id",
                keyValue: 121,
                column: "CreatedTime",
                value: new DateTime(2024, 8, 20, 22, 35, 3, 684, DateTimeKind.Local).AddTicks(8996));

            migrationBuilder.UpdateData(
                table: "Breeds",
                keyColumn: "Id",
                keyValue: 122,
                column: "CreatedTime",
                value: new DateTime(2024, 8, 20, 22, 35, 3, 684, DateTimeKind.Local).AddTicks(8997));

            migrationBuilder.UpdateData(
                table: "Breeds",
                keyColumn: "Id",
                keyValue: 123,
                column: "CreatedTime",
                value: new DateTime(2024, 8, 20, 22, 35, 3, 684, DateTimeKind.Local).AddTicks(8998));

            migrationBuilder.UpdateData(
                table: "Breeds",
                keyColumn: "Id",
                keyValue: 124,
                column: "CreatedTime",
                value: new DateTime(2024, 8, 20, 22, 35, 3, 684, DateTimeKind.Local).AddTicks(8999));

            migrationBuilder.UpdateData(
                table: "Breeds",
                keyColumn: "Id",
                keyValue: 125,
                column: "CreatedTime",
                value: new DateTime(2024, 8, 20, 22, 35, 3, 684, DateTimeKind.Local).AddTicks(9001));

            migrationBuilder.UpdateData(
                table: "Breeds",
                keyColumn: "Id",
                keyValue: 126,
                column: "CreatedTime",
                value: new DateTime(2024, 8, 20, 22, 35, 3, 684, DateTimeKind.Local).AddTicks(9002));

            migrationBuilder.UpdateData(
                table: "Breeds",
                keyColumn: "Id",
                keyValue: 127,
                column: "CreatedTime",
                value: new DateTime(2024, 8, 20, 22, 35, 3, 684, DateTimeKind.Local).AddTicks(9003));

            migrationBuilder.UpdateData(
                table: "Breeds",
                keyColumn: "Id",
                keyValue: 128,
                column: "CreatedTime",
                value: new DateTime(2024, 8, 20, 22, 35, 3, 684, DateTimeKind.Local).AddTicks(9005));

            migrationBuilder.UpdateData(
                table: "Breeds",
                keyColumn: "Id",
                keyValue: 129,
                column: "CreatedTime",
                value: new DateTime(2024, 8, 20, 22, 35, 3, 684, DateTimeKind.Local).AddTicks(9006));

            migrationBuilder.UpdateData(
                table: "Breeds",
                keyColumn: "Id",
                keyValue: 130,
                column: "CreatedTime",
                value: new DateTime(2024, 8, 20, 22, 35, 3, 684, DateTimeKind.Local).AddTicks(9007));

            migrationBuilder.UpdateData(
                table: "Breeds",
                keyColumn: "Id",
                keyValue: 131,
                column: "CreatedTime",
                value: new DateTime(2024, 8, 20, 22, 35, 3, 684, DateTimeKind.Local).AddTicks(9009));

            migrationBuilder.UpdateData(
                table: "Breeds",
                keyColumn: "Id",
                keyValue: 132,
                column: "CreatedTime",
                value: new DateTime(2024, 8, 20, 22, 35, 3, 684, DateTimeKind.Local).AddTicks(9010));

            migrationBuilder.UpdateData(
                table: "Breeds",
                keyColumn: "Id",
                keyValue: 133,
                column: "CreatedTime",
                value: new DateTime(2024, 8, 20, 22, 35, 3, 684, DateTimeKind.Local).AddTicks(9011));

            migrationBuilder.UpdateData(
                table: "Breeds",
                keyColumn: "Id",
                keyValue: 134,
                column: "CreatedTime",
                value: new DateTime(2024, 8, 20, 22, 35, 3, 684, DateTimeKind.Local).AddTicks(9013));

            migrationBuilder.UpdateData(
                table: "Breeds",
                keyColumn: "Id",
                keyValue: 135,
                column: "CreatedTime",
                value: new DateTime(2024, 8, 20, 22, 35, 3, 684, DateTimeKind.Local).AddTicks(9014));

            migrationBuilder.UpdateData(
                table: "Breeds",
                keyColumn: "Id",
                keyValue: 136,
                column: "CreatedTime",
                value: new DateTime(2024, 8, 20, 22, 35, 3, 684, DateTimeKind.Local).AddTicks(9015));

            migrationBuilder.UpdateData(
                table: "Breeds",
                keyColumn: "Id",
                keyValue: 137,
                column: "CreatedTime",
                value: new DateTime(2024, 8, 20, 22, 35, 3, 684, DateTimeKind.Local).AddTicks(9017));

            migrationBuilder.UpdateData(
                table: "Breeds",
                keyColumn: "Id",
                keyValue: 138,
                column: "CreatedTime",
                value: new DateTime(2024, 8, 20, 22, 35, 3, 684, DateTimeKind.Local).AddTicks(9019));

            migrationBuilder.UpdateData(
                table: "Breeds",
                keyColumn: "Id",
                keyValue: 139,
                column: "CreatedTime",
                value: new DateTime(2024, 8, 20, 22, 35, 3, 684, DateTimeKind.Local).AddTicks(9020));

            migrationBuilder.UpdateData(
                table: "Breeds",
                keyColumn: "Id",
                keyValue: 140,
                column: "CreatedTime",
                value: new DateTime(2024, 8, 20, 22, 35, 3, 684, DateTimeKind.Local).AddTicks(9022));

            migrationBuilder.UpdateData(
                table: "Breeds",
                keyColumn: "Id",
                keyValue: 141,
                column: "CreatedTime",
                value: new DateTime(2024, 8, 20, 22, 35, 3, 684, DateTimeKind.Local).AddTicks(9023));

            migrationBuilder.UpdateData(
                table: "Breeds",
                keyColumn: "Id",
                keyValue: 142,
                column: "CreatedTime",
                value: new DateTime(2024, 8, 20, 22, 35, 3, 684, DateTimeKind.Local).AddTicks(9024));

            migrationBuilder.UpdateData(
                table: "Breeds",
                keyColumn: "Id",
                keyValue: 143,
                column: "CreatedTime",
                value: new DateTime(2024, 8, 20, 22, 35, 3, 684, DateTimeKind.Local).AddTicks(9026));

            migrationBuilder.UpdateData(
                table: "Breeds",
                keyColumn: "Id",
                keyValue: 144,
                column: "CreatedTime",
                value: new DateTime(2024, 8, 20, 22, 35, 3, 684, DateTimeKind.Local).AddTicks(9027));

            migrationBuilder.UpdateData(
                table: "Breeds",
                keyColumn: "Id",
                keyValue: 145,
                column: "CreatedTime",
                value: new DateTime(2024, 8, 20, 22, 35, 3, 684, DateTimeKind.Local).AddTicks(9028));

            migrationBuilder.UpdateData(
                table: "Breeds",
                keyColumn: "Id",
                keyValue: 146,
                column: "CreatedTime",
                value: new DateTime(2024, 8, 20, 22, 35, 3, 684, DateTimeKind.Local).AddTicks(9030));

            migrationBuilder.UpdateData(
                table: "Breeds",
                keyColumn: "Id",
                keyValue: 147,
                column: "CreatedTime",
                value: new DateTime(2024, 8, 20, 22, 35, 3, 684, DateTimeKind.Local).AddTicks(9031));

            migrationBuilder.UpdateData(
                table: "Breeds",
                keyColumn: "Id",
                keyValue: 148,
                column: "CreatedTime",
                value: new DateTime(2024, 8, 20, 22, 35, 3, 684, DateTimeKind.Local).AddTicks(9032));

            migrationBuilder.UpdateData(
                table: "Breeds",
                keyColumn: "Id",
                keyValue: 149,
                column: "CreatedTime",
                value: new DateTime(2024, 8, 20, 22, 35, 3, 684, DateTimeKind.Local).AddTicks(9033));

            migrationBuilder.UpdateData(
                table: "Breeds",
                keyColumn: "Id",
                keyValue: 150,
                column: "CreatedTime",
                value: new DateTime(2024, 8, 20, 22, 35, 3, 684, DateTimeKind.Local).AddTicks(9035));

            migrationBuilder.UpdateData(
                table: "Breeds",
                keyColumn: "Id",
                keyValue: 151,
                column: "CreatedTime",
                value: new DateTime(2024, 8, 20, 22, 35, 3, 684, DateTimeKind.Local).AddTicks(9036));

            migrationBuilder.UpdateData(
                table: "Breeds",
                keyColumn: "Id",
                keyValue: 152,
                column: "CreatedTime",
                value: new DateTime(2024, 8, 20, 22, 35, 3, 684, DateTimeKind.Local).AddTicks(9037));

            migrationBuilder.UpdateData(
                table: "Breeds",
                keyColumn: "Id",
                keyValue: 153,
                column: "CreatedTime",
                value: new DateTime(2024, 8, 20, 22, 35, 3, 684, DateTimeKind.Local).AddTicks(9039));

            migrationBuilder.UpdateData(
                table: "Breeds",
                keyColumn: "Id",
                keyValue: 154,
                column: "CreatedTime",
                value: new DateTime(2024, 8, 20, 22, 35, 3, 684, DateTimeKind.Local).AddTicks(9040));

            migrationBuilder.UpdateData(
                table: "Breeds",
                keyColumn: "Id",
                keyValue: 155,
                column: "CreatedTime",
                value: new DateTime(2024, 8, 20, 22, 35, 3, 684, DateTimeKind.Local).AddTicks(9042));

            migrationBuilder.UpdateData(
                table: "Breeds",
                keyColumn: "Id",
                keyValue: 156,
                column: "CreatedTime",
                value: new DateTime(2024, 8, 20, 22, 35, 3, 684, DateTimeKind.Local).AddTicks(9043));

            migrationBuilder.UpdateData(
                table: "Breeds",
                keyColumn: "Id",
                keyValue: 157,
                column: "CreatedTime",
                value: new DateTime(2024, 8, 20, 22, 35, 3, 684, DateTimeKind.Local).AddTicks(9045));

            migrationBuilder.UpdateData(
                table: "Breeds",
                keyColumn: "Id",
                keyValue: 158,
                column: "CreatedTime",
                value: new DateTime(2024, 8, 20, 22, 35, 3, 684, DateTimeKind.Local).AddTicks(9046));

            migrationBuilder.UpdateData(
                table: "Breeds",
                keyColumn: "Id",
                keyValue: 159,
                column: "CreatedTime",
                value: new DateTime(2024, 8, 20, 22, 35, 3, 684, DateTimeKind.Local).AddTicks(9047));

            migrationBuilder.UpdateData(
                table: "Breeds",
                keyColumn: "Id",
                keyValue: 160,
                column: "CreatedTime",
                value: new DateTime(2024, 8, 20, 22, 35, 3, 684, DateTimeKind.Local).AddTicks(9049));

            migrationBuilder.UpdateData(
                table: "PetTypes",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedTime",
                value: new DateTime(2024, 8, 20, 22, 35, 3, 684, DateTimeKind.Local).AddTicks(5770));

            migrationBuilder.UpdateData(
                table: "PetTypes",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreatedTime",
                value: new DateTime(2024, 8, 20, 22, 35, 3, 684, DateTimeKind.Local).AddTicks(5787));

            migrationBuilder.UpdateData(
                table: "PetTypes",
                keyColumn: "Id",
                keyValue: 3,
                column: "CreatedTime",
                value: new DateTime(2024, 8, 20, 22, 35, 3, 684, DateTimeKind.Local).AddTicks(5789));

            migrationBuilder.UpdateData(
                table: "PetTypes",
                keyColumn: "Id",
                keyValue: 4,
                column: "CreatedTime",
                value: new DateTime(2024, 8, 20, 22, 35, 3, 684, DateTimeKind.Local).AddTicks(5790));

            migrationBuilder.UpdateData(
                table: "PetTypes",
                keyColumn: "Id",
                keyValue: 5,
                column: "CreatedTime",
                value: new DateTime(2024, 8, 20, 22, 35, 3, 684, DateTimeKind.Local).AddTicks(5792));

            migrationBuilder.UpdateData(
                table: "PetTypes",
                keyColumn: "Id",
                keyValue: 6,
                column: "CreatedTime",
                value: new DateTime(2024, 8, 20, 22, 35, 3, 684, DateTimeKind.Local).AddTicks(5793));

            migrationBuilder.UpdateData(
                table: "PetTypes",
                keyColumn: "Id",
                keyValue: 7,
                column: "CreatedTime",
                value: new DateTime(2024, 8, 20, 22, 35, 3, 684, DateTimeKind.Local).AddTicks(5795));

            migrationBuilder.UpdateData(
                table: "PetTypes",
                keyColumn: "Id",
                keyValue: 8,
                column: "CreatedTime",
                value: new DateTime(2024, 8, 20, 22, 35, 3, 684, DateTimeKind.Local).AddTicks(5796));
        }
    }
}
