using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Persistance.Migrations
{
    /// <inheritdoc />
    public partial class mig_2 : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropIndex(
                name: "IX_Adoptions_PetId",
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

            migrationBuilder.CreateIndex(
                name: "IX_Adoptions_PetId",
                table: "Adoptions",
                column: "PetId");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropIndex(
                name: "IX_Adoptions_PetId",
                table: "Adoptions");

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: 2001,
                columns: new[] { "ConcurrencyStamp", "CreatedTime", "LastUpdatedTime", "RefreshTokenCreateTime" },
                values: new object[] { "2f5d35c1-0139-4c85-95ce-f659f8020382", new DateTime(2024, 8, 31, 7, 13, 3, 836, DateTimeKind.Utc).AddTicks(5380), new DateTime(2024, 8, 31, 7, 13, 3, 836, DateTimeKind.Utc).AddTicks(5380), new DateTime(2024, 8, 31, 7, 13, 3, 836, DateTimeKind.Utc).AddTicks(5300) });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: 2002,
                columns: new[] { "ConcurrencyStamp", "CreatedTime", "LastUpdatedTime", "RefreshTokenCreateTime" },
                values: new object[] { "0a64a1ad-5e7c-46fd-b062-f9eadc936ca1", new DateTime(2024, 8, 31, 7, 13, 3, 836, DateTimeKind.Utc).AddTicks(5410), new DateTime(2024, 8, 31, 7, 13, 3, 836, DateTimeKind.Utc).AddTicks(5410), new DateTime(2024, 8, 31, 7, 13, 3, 836, DateTimeKind.Utc).AddTicks(5400) });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: 2003,
                columns: new[] { "ConcurrencyStamp", "CreatedTime", "LastUpdatedTime", "RefreshTokenCreateTime" },
                values: new object[] { "623642b6-8546-4bd0-ae26-2cd1701c7c60", new DateTime(2024, 8, 31, 7, 13, 3, 836, DateTimeKind.Utc).AddTicks(5420), new DateTime(2024, 8, 31, 7, 13, 3, 836, DateTimeKind.Utc).AddTicks(5420), new DateTime(2024, 8, 31, 7, 13, 3, 836, DateTimeKind.Utc).AddTicks(5410) });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: 2004,
                columns: new[] { "ConcurrencyStamp", "CreatedTime", "LastUpdatedTime", "RefreshTokenCreateTime" },
                values: new object[] { "a8755595-7349-4069-b07e-5b67f3f827ca", new DateTime(2024, 8, 31, 7, 13, 3, 836, DateTimeKind.Utc).AddTicks(5430), new DateTime(2024, 8, 31, 7, 13, 3, 836, DateTimeKind.Utc).AddTicks(5430), new DateTime(2024, 8, 31, 7, 13, 3, 836, DateTimeKind.Utc).AddTicks(5420) });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: 2005,
                columns: new[] { "ConcurrencyStamp", "CreatedTime", "LastUpdatedTime", "RefreshTokenCreateTime" },
                values: new object[] { "9ad2c28f-e17f-4af6-b7d6-f888e258d9ce", new DateTime(2024, 8, 31, 7, 13, 3, 836, DateTimeKind.Utc).AddTicks(5440), new DateTime(2024, 8, 31, 7, 13, 3, 836, DateTimeKind.Utc).AddTicks(5440), new DateTime(2024, 8, 31, 7, 13, 3, 836, DateTimeKind.Utc).AddTicks(5430) });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: 2006,
                columns: new[] { "ConcurrencyStamp", "CreatedTime", "LastUpdatedTime", "RefreshTokenCreateTime" },
                values: new object[] { "f5545207-9296-45ae-8ab7-2a9dbbbfad4c", new DateTime(2024, 8, 31, 7, 13, 3, 836, DateTimeKind.Utc).AddTicks(5450), new DateTime(2024, 8, 31, 7, 13, 3, 836, DateTimeKind.Utc).AddTicks(5450), new DateTime(2024, 8, 31, 7, 13, 3, 836, DateTimeKind.Utc).AddTicks(5440) });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: 2007,
                columns: new[] { "ConcurrencyStamp", "CreatedTime", "LastUpdatedTime", "RefreshTokenCreateTime" },
                values: new object[] { "dc6676c3-36ad-45e9-a4f0-26e8731ef696", new DateTime(2024, 8, 31, 7, 13, 3, 836, DateTimeKind.Utc).AddTicks(5460), new DateTime(2024, 8, 31, 7, 13, 3, 836, DateTimeKind.Utc).AddTicks(5460), new DateTime(2024, 8, 31, 7, 13, 3, 836, DateTimeKind.Utc).AddTicks(5450) });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: 2008,
                columns: new[] { "ConcurrencyStamp", "CreatedTime", "LastUpdatedTime", "RefreshTokenCreateTime" },
                values: new object[] { "d2672116-19a7-4bed-83f1-7caffc681181", new DateTime(2024, 8, 31, 7, 13, 3, 836, DateTimeKind.Utc).AddTicks(5470), new DateTime(2024, 8, 31, 7, 13, 3, 836, DateTimeKind.Utc).AddTicks(5470), new DateTime(2024, 8, 31, 7, 13, 3, 836, DateTimeKind.Utc).AddTicks(5460) });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: 2009,
                columns: new[] { "ConcurrencyStamp", "CreatedTime", "LastUpdatedTime", "RefreshTokenCreateTime" },
                values: new object[] { "19709374-aef6-4e6f-aa24-f3a5d221f34b", new DateTime(2024, 8, 31, 7, 13, 3, 836, DateTimeKind.Utc).AddTicks(5480), new DateTime(2024, 8, 31, 7, 13, 3, 836, DateTimeKind.Utc).AddTicks(5480), new DateTime(2024, 8, 31, 7, 13, 3, 836, DateTimeKind.Utc).AddTicks(5470) });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: 2010,
                columns: new[] { "ConcurrencyStamp", "CreatedTime", "LastUpdatedTime", "RefreshTokenCreateTime" },
                values: new object[] { "c41232ce-e198-4a98-a393-3335121bfde2", new DateTime(2024, 8, 31, 7, 13, 3, 836, DateTimeKind.Utc).AddTicks(5490), new DateTime(2024, 8, 31, 7, 13, 3, 836, DateTimeKind.Utc).AddTicks(5490), new DateTime(2024, 8, 31, 7, 13, 3, 836, DateTimeKind.Utc).AddTicks(5480) });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: 2011,
                columns: new[] { "ConcurrencyStamp", "CreatedTime", "LastUpdatedTime", "RefreshTokenCreateTime" },
                values: new object[] { "408dce9e-9b2d-44e3-886b-c67c7584aa0d", new DateTime(2024, 8, 31, 7, 13, 3, 836, DateTimeKind.Utc).AddTicks(5500), new DateTime(2024, 8, 31, 7, 13, 3, 836, DateTimeKind.Utc).AddTicks(5500), new DateTime(2024, 8, 31, 7, 13, 3, 836, DateTimeKind.Utc).AddTicks(5490) });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: 2012,
                columns: new[] { "ConcurrencyStamp", "CreatedTime", "LastUpdatedTime", "RefreshTokenCreateTime" },
                values: new object[] { "5e83d4b8-6ce3-4736-ad53-1b34ba7916e4", new DateTime(2024, 8, 31, 7, 13, 3, 836, DateTimeKind.Utc).AddTicks(5510), new DateTime(2024, 8, 31, 7, 13, 3, 836, DateTimeKind.Utc).AddTicks(5510), new DateTime(2024, 8, 31, 7, 13, 3, 836, DateTimeKind.Utc).AddTicks(5500) });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: 2013,
                columns: new[] { "ConcurrencyStamp", "CreatedTime", "LastUpdatedTime", "RefreshTokenCreateTime" },
                values: new object[] { "97441151-6725-4412-9aa5-3e3d1f7675f4", new DateTime(2024, 8, 31, 7, 13, 3, 836, DateTimeKind.Utc).AddTicks(5510), new DateTime(2024, 8, 31, 7, 13, 3, 836, DateTimeKind.Utc).AddTicks(5510), new DateTime(2024, 8, 31, 7, 13, 3, 836, DateTimeKind.Utc).AddTicks(5510) });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: 2014,
                columns: new[] { "ConcurrencyStamp", "CreatedTime", "LastUpdatedTime", "RefreshTokenCreateTime" },
                values: new object[] { "1392948b-7302-4cf5-b05f-40ac40d1a2f8", new DateTime(2024, 8, 31, 7, 13, 3, 836, DateTimeKind.Utc).AddTicks(5520), new DateTime(2024, 8, 31, 7, 13, 3, 836, DateTimeKind.Utc).AddTicks(5520), new DateTime(2024, 8, 31, 7, 13, 3, 836, DateTimeKind.Utc).AddTicks(5520) });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: 2015,
                columns: new[] { "ConcurrencyStamp", "CreatedTime", "LastUpdatedTime", "RefreshTokenCreateTime" },
                values: new object[] { "376200bd-ef78-481a-9fbc-a0bff70366b6", new DateTime(2024, 8, 31, 7, 13, 3, 836, DateTimeKind.Utc).AddTicks(5530), new DateTime(2024, 8, 31, 7, 13, 3, 836, DateTimeKind.Utc).AddTicks(5530), new DateTime(2024, 8, 31, 7, 13, 3, 836, DateTimeKind.Utc).AddTicks(5530) });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: 2016,
                columns: new[] { "ConcurrencyStamp", "CreatedTime", "LastUpdatedTime", "RefreshTokenCreateTime" },
                values: new object[] { "f1f5690d-e592-46b1-92eb-9312c0e02f43", new DateTime(2024, 8, 31, 7, 13, 3, 836, DateTimeKind.Utc).AddTicks(5540), new DateTime(2024, 8, 31, 7, 13, 3, 836, DateTimeKind.Utc).AddTicks(5540), new DateTime(2024, 8, 31, 7, 13, 3, 836, DateTimeKind.Utc).AddTicks(5540) });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: 2017,
                columns: new[] { "ConcurrencyStamp", "CreatedTime", "LastUpdatedTime", "RefreshTokenCreateTime" },
                values: new object[] { "affa35e6-2fed-4cb3-8755-05795b3255a7", new DateTime(2024, 8, 31, 7, 13, 3, 836, DateTimeKind.Utc).AddTicks(5550), new DateTime(2024, 8, 31, 7, 13, 3, 836, DateTimeKind.Utc).AddTicks(5550), new DateTime(2024, 8, 31, 7, 13, 3, 836, DateTimeKind.Utc).AddTicks(5550) });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: 2018,
                columns: new[] { "ConcurrencyStamp", "CreatedTime", "LastUpdatedTime", "RefreshTokenCreateTime" },
                values: new object[] { "87a75fa8-503f-4508-b27c-9dc76bf16b50", new DateTime(2024, 8, 31, 7, 13, 3, 836, DateTimeKind.Utc).AddTicks(5600), new DateTime(2024, 8, 31, 7, 13, 3, 836, DateTimeKind.Utc).AddTicks(5600), new DateTime(2024, 8, 31, 7, 13, 3, 836, DateTimeKind.Utc).AddTicks(5600) });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: 2019,
                columns: new[] { "ConcurrencyStamp", "CreatedTime", "LastUpdatedTime", "RefreshTokenCreateTime" },
                values: new object[] { "bad590f9-034a-4f6e-8105-68e4f6f2c811", new DateTime(2024, 8, 31, 7, 13, 3, 836, DateTimeKind.Utc).AddTicks(5610), new DateTime(2024, 8, 31, 7, 13, 3, 836, DateTimeKind.Utc).AddTicks(5610), new DateTime(2024, 8, 31, 7, 13, 3, 836, DateTimeKind.Utc).AddTicks(5610) });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: 2020,
                columns: new[] { "ConcurrencyStamp", "CreatedTime", "LastUpdatedTime", "RefreshTokenCreateTime" },
                values: new object[] { "202e2e5f-999e-45c3-905b-869f0f9e6cf8", new DateTime(2024, 8, 31, 7, 13, 3, 836, DateTimeKind.Utc).AddTicks(5620), new DateTime(2024, 8, 31, 7, 13, 3, 836, DateTimeKind.Utc).AddTicks(5620), new DateTime(2024, 8, 31, 7, 13, 3, 836, DateTimeKind.Utc).AddTicks(5620) });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: 2021,
                columns: new[] { "ConcurrencyStamp", "CreatedTime", "LastUpdatedTime", "RefreshTokenCreateTime" },
                values: new object[] { "bd548470-768e-432b-8983-ebb23d9a8492", new DateTime(2024, 8, 31, 7, 13, 3, 836, DateTimeKind.Utc).AddTicks(5630), new DateTime(2024, 8, 31, 7, 13, 3, 836, DateTimeKind.Utc).AddTicks(5630), new DateTime(2024, 8, 31, 7, 13, 3, 836, DateTimeKind.Utc).AddTicks(5630) });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: 2022,
                columns: new[] { "ConcurrencyStamp", "CreatedTime", "LastUpdatedTime", "RefreshTokenCreateTime" },
                values: new object[] { "d9ec5bf5-cec4-4cb1-818a-305f81f60718", new DateTime(2024, 8, 31, 7, 13, 3, 836, DateTimeKind.Utc).AddTicks(5650), new DateTime(2024, 8, 31, 7, 13, 3, 836, DateTimeKind.Utc).AddTicks(5650), new DateTime(2024, 8, 31, 7, 13, 3, 836, DateTimeKind.Utc).AddTicks(5640) });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: 2023,
                columns: new[] { "ConcurrencyStamp", "CreatedTime", "LastUpdatedTime", "RefreshTokenCreateTime" },
                values: new object[] { "b46a796f-6ff4-4137-b254-1d093bef6dd4", new DateTime(2024, 8, 31, 7, 13, 3, 836, DateTimeKind.Utc).AddTicks(5660), new DateTime(2024, 8, 31, 7, 13, 3, 836, DateTimeKind.Utc).AddTicks(5660), new DateTime(2024, 8, 31, 7, 13, 3, 836, DateTimeKind.Utc).AddTicks(5660) });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: 2024,
                columns: new[] { "ConcurrencyStamp", "CreatedTime", "LastUpdatedTime", "RefreshTokenCreateTime" },
                values: new object[] { "db679a61-8356-4af3-aad6-18ce15d31fe4", new DateTime(2024, 8, 31, 7, 13, 3, 836, DateTimeKind.Utc).AddTicks(5670), new DateTime(2024, 8, 31, 7, 13, 3, 836, DateTimeKind.Utc).AddTicks(5670), new DateTime(2024, 8, 31, 7, 13, 3, 836, DateTimeKind.Utc).AddTicks(5670) });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: 2025,
                columns: new[] { "ConcurrencyStamp", "CreatedTime", "LastUpdatedTime", "RefreshTokenCreateTime" },
                values: new object[] { "c3f20f5b-c364-4b61-9e13-a59ab43fa42c", new DateTime(2024, 8, 31, 7, 13, 3, 836, DateTimeKind.Utc).AddTicks(5680), new DateTime(2024, 8, 31, 7, 13, 3, 836, DateTimeKind.Utc).AddTicks(5680), new DateTime(2024, 8, 31, 7, 13, 3, 836, DateTimeKind.Utc).AddTicks(5670) });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: 2026,
                columns: new[] { "ConcurrencyStamp", "CreatedTime", "LastUpdatedTime", "RefreshTokenCreateTime" },
                values: new object[] { "de43cf4a-6d15-46a0-8ed5-17300982bebd", new DateTime(2024, 8, 31, 7, 13, 3, 836, DateTimeKind.Utc).AddTicks(5690), new DateTime(2024, 8, 31, 7, 13, 3, 836, DateTimeKind.Utc).AddTicks(5690), new DateTime(2024, 8, 31, 7, 13, 3, 836, DateTimeKind.Utc).AddTicks(5680) });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: 2027,
                columns: new[] { "ConcurrencyStamp", "CreatedTime", "LastUpdatedTime", "RefreshTokenCreateTime" },
                values: new object[] { "7dd598ae-26eb-4c87-9483-b7ded89a6e2c", new DateTime(2024, 8, 31, 7, 13, 3, 836, DateTimeKind.Utc).AddTicks(5700), new DateTime(2024, 8, 31, 7, 13, 3, 836, DateTimeKind.Utc).AddTicks(5700), new DateTime(2024, 8, 31, 7, 13, 3, 836, DateTimeKind.Utc).AddTicks(5700) });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: 2028,
                columns: new[] { "ConcurrencyStamp", "CreatedTime", "LastUpdatedTime", "RefreshTokenCreateTime" },
                values: new object[] { "397a4d99-a710-4246-a6b2-124b9f18c196", new DateTime(2024, 8, 31, 7, 13, 3, 836, DateTimeKind.Utc).AddTicks(5710), new DateTime(2024, 8, 31, 7, 13, 3, 836, DateTimeKind.Utc).AddTicks(5710), new DateTime(2024, 8, 31, 7, 13, 3, 836, DateTimeKind.Utc).AddTicks(5710) });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: 2029,
                columns: new[] { "ConcurrencyStamp", "CreatedTime", "LastUpdatedTime", "RefreshTokenCreateTime" },
                values: new object[] { "e74c8173-6233-437e-955f-179a1dc6dc72", new DateTime(2024, 8, 31, 7, 13, 3, 836, DateTimeKind.Utc).AddTicks(5720), new DateTime(2024, 8, 31, 7, 13, 3, 836, DateTimeKind.Utc).AddTicks(5720), new DateTime(2024, 8, 31, 7, 13, 3, 836, DateTimeKind.Utc).AddTicks(5720) });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: 2030,
                columns: new[] { "ConcurrencyStamp", "CreatedTime", "LastUpdatedTime", "RefreshTokenCreateTime" },
                values: new object[] { "b77b30f1-9379-49fe-a4fb-36ba3285a401", new DateTime(2024, 8, 31, 7, 13, 3, 836, DateTimeKind.Utc).AddTicks(5730), new DateTime(2024, 8, 31, 7, 13, 3, 836, DateTimeKind.Utc).AddTicks(5730), new DateTime(2024, 8, 31, 7, 13, 3, 836, DateTimeKind.Utc).AddTicks(5730) });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: 2031,
                columns: new[] { "ConcurrencyStamp", "CreatedTime", "LastUpdatedTime", "RefreshTokenCreateTime" },
                values: new object[] { "3c1bcaa2-2c56-4194-a814-02e9ead9d415", new DateTime(2024, 8, 31, 7, 13, 3, 836, DateTimeKind.Utc).AddTicks(5740), new DateTime(2024, 8, 31, 7, 13, 3, 836, DateTimeKind.Utc).AddTicks(5740), new DateTime(2024, 8, 31, 7, 13, 3, 836, DateTimeKind.Utc).AddTicks(5740) });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: 2032,
                columns: new[] { "ConcurrencyStamp", "CreatedTime", "LastUpdatedTime", "RefreshTokenCreateTime" },
                values: new object[] { "7ee3acaa-58df-4c15-93c4-f4a53ac8c875", new DateTime(2024, 8, 31, 7, 13, 3, 836, DateTimeKind.Utc).AddTicks(5750), new DateTime(2024, 8, 31, 7, 13, 3, 836, DateTimeKind.Utc).AddTicks(5750), new DateTime(2024, 8, 31, 7, 13, 3, 836, DateTimeKind.Utc).AddTicks(5750) });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: 2033,
                columns: new[] { "ConcurrencyStamp", "CreatedTime", "LastUpdatedTime", "RefreshTokenCreateTime" },
                values: new object[] { "7241a5a8-cab9-43ca-bd89-64fbabca5a0a", new DateTime(2024, 8, 31, 7, 13, 3, 836, DateTimeKind.Utc).AddTicks(5760), new DateTime(2024, 8, 31, 7, 13, 3, 836, DateTimeKind.Utc).AddTicks(5760), new DateTime(2024, 8, 31, 7, 13, 3, 836, DateTimeKind.Utc).AddTicks(5760) });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: 2034,
                columns: new[] { "ConcurrencyStamp", "CreatedTime", "LastUpdatedTime", "RefreshTokenCreateTime" },
                values: new object[] { "4f0b5e41-0d1b-4cbd-8713-6a8ccd731e40", new DateTime(2024, 8, 31, 7, 13, 3, 836, DateTimeKind.Utc).AddTicks(5770), new DateTime(2024, 8, 31, 7, 13, 3, 836, DateTimeKind.Utc).AddTicks(5770), new DateTime(2024, 8, 31, 7, 13, 3, 836, DateTimeKind.Utc).AddTicks(5770) });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: 2035,
                columns: new[] { "ConcurrencyStamp", "CreatedTime", "LastUpdatedTime", "RefreshTokenCreateTime" },
                values: new object[] { "10f3646d-fc9b-4191-9a65-ed06192f1910", new DateTime(2024, 8, 31, 7, 13, 3, 836, DateTimeKind.Utc).AddTicks(5790), new DateTime(2024, 8, 31, 7, 13, 3, 836, DateTimeKind.Utc).AddTicks(5790), new DateTime(2024, 8, 31, 7, 13, 3, 836, DateTimeKind.Utc).AddTicks(5790) });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: 2036,
                columns: new[] { "ConcurrencyStamp", "CreatedTime", "LastUpdatedTime", "RefreshTokenCreateTime" },
                values: new object[] { "3cd2f605-067b-40d3-86d6-85d7e2bad9a6", new DateTime(2024, 8, 31, 7, 13, 3, 836, DateTimeKind.Utc).AddTicks(5800), new DateTime(2024, 8, 31, 7, 13, 3, 836, DateTimeKind.Utc).AddTicks(5800), new DateTime(2024, 8, 31, 7, 13, 3, 836, DateTimeKind.Utc).AddTicks(5800) });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: 2037,
                columns: new[] { "ConcurrencyStamp", "CreatedTime", "LastUpdatedTime", "RefreshTokenCreateTime" },
                values: new object[] { "3dd57b14-77bf-41d7-9a8a-edbe6817b6f8", new DateTime(2024, 8, 31, 7, 13, 3, 836, DateTimeKind.Utc).AddTicks(5810), new DateTime(2024, 8, 31, 7, 13, 3, 836, DateTimeKind.Utc).AddTicks(5810), new DateTime(2024, 8, 31, 7, 13, 3, 836, DateTimeKind.Utc).AddTicks(5810) });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: 2038,
                columns: new[] { "ConcurrencyStamp", "CreatedTime", "LastUpdatedTime", "RefreshTokenCreateTime" },
                values: new object[] { "06106a80-f58a-451f-890c-913b156e45d4", new DateTime(2024, 8, 31, 7, 13, 3, 836, DateTimeKind.Utc).AddTicks(5820), new DateTime(2024, 8, 31, 7, 13, 3, 836, DateTimeKind.Utc).AddTicks(5820), new DateTime(2024, 8, 31, 7, 13, 3, 836, DateTimeKind.Utc).AddTicks(5820) });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: 2039,
                columns: new[] { "ConcurrencyStamp", "CreatedTime", "LastUpdatedTime", "RefreshTokenCreateTime" },
                values: new object[] { "6b0ef697-e875-4f1e-89a5-1933f60fbc77", new DateTime(2024, 8, 31, 7, 13, 3, 836, DateTimeKind.Utc).AddTicks(5830), new DateTime(2024, 8, 31, 7, 13, 3, 836, DateTimeKind.Utc).AddTicks(5830), new DateTime(2024, 8, 31, 7, 13, 3, 836, DateTimeKind.Utc).AddTicks(5830) });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: 2040,
                columns: new[] { "ConcurrencyStamp", "CreatedTime", "LastUpdatedTime", "RefreshTokenCreateTime" },
                values: new object[] { "4a2c58e1-f04e-4607-866e-c3fcf8a31cca", new DateTime(2024, 8, 31, 7, 13, 3, 836, DateTimeKind.Utc).AddTicks(5840), new DateTime(2024, 8, 31, 7, 13, 3, 836, DateTimeKind.Utc).AddTicks(5840), new DateTime(2024, 8, 31, 7, 13, 3, 836, DateTimeKind.Utc).AddTicks(5840) });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: 2041,
                columns: new[] { "ConcurrencyStamp", "CreatedTime", "LastUpdatedTime", "RefreshTokenCreateTime" },
                values: new object[] { "dd696793-b450-4e15-93ef-b18987a446d8", new DateTime(2024, 8, 31, 7, 13, 3, 836, DateTimeKind.Utc).AddTicks(5850), new DateTime(2024, 8, 31, 7, 13, 3, 836, DateTimeKind.Utc).AddTicks(5850), new DateTime(2024, 8, 31, 7, 13, 3, 836, DateTimeKind.Utc).AddTicks(5850) });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: 2042,
                columns: new[] { "ConcurrencyStamp", "CreatedTime", "LastUpdatedTime", "RefreshTokenCreateTime" },
                values: new object[] { "99a4c1f9-57a6-4fbc-b799-8c9e6f5aeacf", new DateTime(2024, 8, 31, 7, 13, 3, 836, DateTimeKind.Utc).AddTicks(5870), new DateTime(2024, 8, 31, 7, 13, 3, 836, DateTimeKind.Utc).AddTicks(5870), new DateTime(2024, 8, 31, 7, 13, 3, 836, DateTimeKind.Utc).AddTicks(5860) });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: 2043,
                columns: new[] { "ConcurrencyStamp", "CreatedTime", "LastUpdatedTime", "RefreshTokenCreateTime" },
                values: new object[] { "6932b2fa-84e7-4489-983b-e21a94076838", new DateTime(2024, 8, 31, 7, 13, 3, 836, DateTimeKind.Utc).AddTicks(5880), new DateTime(2024, 8, 31, 7, 13, 3, 836, DateTimeKind.Utc).AddTicks(5880), new DateTime(2024, 8, 31, 7, 13, 3, 836, DateTimeKind.Utc).AddTicks(5870) });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: 2044,
                columns: new[] { "ConcurrencyStamp", "CreatedTime", "LastUpdatedTime", "RefreshTokenCreateTime" },
                values: new object[] { "9129c121-2754-4f19-b1bc-cfdb410d2a70", new DateTime(2024, 8, 31, 7, 13, 3, 836, DateTimeKind.Utc).AddTicks(5890), new DateTime(2024, 8, 31, 7, 13, 3, 836, DateTimeKind.Utc).AddTicks(5890), new DateTime(2024, 8, 31, 7, 13, 3, 836, DateTimeKind.Utc).AddTicks(5880) });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: 2045,
                columns: new[] { "ConcurrencyStamp", "CreatedTime", "LastUpdatedTime", "RefreshTokenCreateTime" },
                values: new object[] { "2ea06070-ed1e-41b5-afcd-322b0ec1982c", new DateTime(2024, 8, 31, 7, 13, 3, 836, DateTimeKind.Utc).AddTicks(5900), new DateTime(2024, 8, 31, 7, 13, 3, 836, DateTimeKind.Utc).AddTicks(5900), new DateTime(2024, 8, 31, 7, 13, 3, 836, DateTimeKind.Utc).AddTicks(5890) });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: 2046,
                columns: new[] { "ConcurrencyStamp", "CreatedTime", "LastUpdatedTime", "RefreshTokenCreateTime" },
                values: new object[] { "01f5cd90-7428-4867-a917-40f818505421", new DateTime(2024, 8, 31, 7, 13, 3, 836, DateTimeKind.Utc).AddTicks(5910), new DateTime(2024, 8, 31, 7, 13, 3, 836, DateTimeKind.Utc).AddTicks(5910), new DateTime(2024, 8, 31, 7, 13, 3, 836, DateTimeKind.Utc).AddTicks(5900) });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: 2047,
                columns: new[] { "ConcurrencyStamp", "CreatedTime", "LastUpdatedTime", "RefreshTokenCreateTime" },
                values: new object[] { "070c15be-135a-44a3-a88c-70ae3cf783bf", new DateTime(2024, 8, 31, 7, 13, 3, 836, DateTimeKind.Utc).AddTicks(5920), new DateTime(2024, 8, 31, 7, 13, 3, 836, DateTimeKind.Utc).AddTicks(5920), new DateTime(2024, 8, 31, 7, 13, 3, 836, DateTimeKind.Utc).AddTicks(5910) });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: 2048,
                columns: new[] { "ConcurrencyStamp", "CreatedTime", "LastUpdatedTime", "RefreshTokenCreateTime" },
                values: new object[] { "61e5a4fc-c7cf-47f3-ab16-bc009120d3b9", new DateTime(2024, 8, 31, 7, 13, 3, 836, DateTimeKind.Utc).AddTicks(5920), new DateTime(2024, 8, 31, 7, 13, 3, 836, DateTimeKind.Utc).AddTicks(5920), new DateTime(2024, 8, 31, 7, 13, 3, 836, DateTimeKind.Utc).AddTicks(5920) });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: 2049,
                columns: new[] { "ConcurrencyStamp", "CreatedTime", "LastUpdatedTime", "RefreshTokenCreateTime" },
                values: new object[] { "a622a512-92c4-45d9-b441-bb8b12f0fce8", new DateTime(2024, 8, 31, 7, 13, 3, 836, DateTimeKind.Utc).AddTicks(5930), new DateTime(2024, 8, 31, 7, 13, 3, 836, DateTimeKind.Utc).AddTicks(5930), new DateTime(2024, 8, 31, 7, 13, 3, 836, DateTimeKind.Utc).AddTicks(5930) });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: 2050,
                columns: new[] { "ConcurrencyStamp", "CreatedTime", "LastUpdatedTime", "RefreshTokenCreateTime" },
                values: new object[] { "1967b91d-40d9-4056-a25a-cd59dbff7032", new DateTime(2024, 8, 31, 7, 13, 3, 836, DateTimeKind.Utc).AddTicks(5940), new DateTime(2024, 8, 31, 7, 13, 3, 836, DateTimeKind.Utc).AddTicks(5940), new DateTime(2024, 8, 31, 7, 13, 3, 836, DateTimeKind.Utc).AddTicks(5940) });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: 2051,
                columns: new[] { "ConcurrencyStamp", "CreatedTime", "LastUpdatedTime", "RefreshTokenCreateTime" },
                values: new object[] { "78c27153-611d-4457-b3a8-09dad54974a3", new DateTime(2024, 8, 31, 7, 13, 3, 836, DateTimeKind.Utc).AddTicks(5950), new DateTime(2024, 8, 31, 7, 13, 3, 836, DateTimeKind.Utc).AddTicks(5950), new DateTime(2024, 8, 31, 7, 13, 3, 836, DateTimeKind.Utc).AddTicks(5950) });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: 2052,
                columns: new[] { "ConcurrencyStamp", "CreatedTime", "LastUpdatedTime", "RefreshTokenCreateTime" },
                values: new object[] { "9928d0a1-febf-4711-9a16-7f2e32481125", new DateTime(2024, 8, 31, 7, 13, 3, 836, DateTimeKind.Utc).AddTicks(5960), new DateTime(2024, 8, 31, 7, 13, 3, 836, DateTimeKind.Utc).AddTicks(5960), new DateTime(2024, 8, 31, 7, 13, 3, 836, DateTimeKind.Utc).AddTicks(5960) });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: 2053,
                columns: new[] { "ConcurrencyStamp", "CreatedTime", "LastUpdatedTime", "RefreshTokenCreateTime" },
                values: new object[] { "94244986-a6d3-46d1-9181-a70dfa54d054", new DateTime(2024, 8, 31, 7, 13, 3, 836, DateTimeKind.Utc).AddTicks(5970), new DateTime(2024, 8, 31, 7, 13, 3, 836, DateTimeKind.Utc).AddTicks(5970), new DateTime(2024, 8, 31, 7, 13, 3, 836, DateTimeKind.Utc).AddTicks(5970) });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: 2054,
                columns: new[] { "ConcurrencyStamp", "CreatedTime", "LastUpdatedTime", "RefreshTokenCreateTime" },
                values: new object[] { "ebe1388b-f456-4962-b013-b31df82c7cbb", new DateTime(2024, 8, 31, 7, 13, 3, 836, DateTimeKind.Utc).AddTicks(5980), new DateTime(2024, 8, 31, 7, 13, 3, 836, DateTimeKind.Utc).AddTicks(5980), new DateTime(2024, 8, 31, 7, 13, 3, 836, DateTimeKind.Utc).AddTicks(5980) });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: 2055,
                columns: new[] { "ConcurrencyStamp", "CreatedTime", "LastUpdatedTime", "RefreshTokenCreateTime" },
                values: new object[] { "962f65f9-075a-48a0-a428-42c217eb33ce", new DateTime(2024, 8, 31, 7, 13, 3, 836, DateTimeKind.Utc).AddTicks(6000), new DateTime(2024, 8, 31, 7, 13, 3, 836, DateTimeKind.Utc).AddTicks(6000), new DateTime(2024, 8, 31, 7, 13, 3, 836, DateTimeKind.Utc).AddTicks(6000) });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: 2056,
                columns: new[] { "ConcurrencyStamp", "CreatedTime", "LastUpdatedTime", "RefreshTokenCreateTime" },
                values: new object[] { "b7df49c0-2cb6-44ee-9ba0-b6c8703c9a7a", new DateTime(2024, 8, 31, 7, 13, 3, 836, DateTimeKind.Utc).AddTicks(6010), new DateTime(2024, 8, 31, 7, 13, 3, 836, DateTimeKind.Utc).AddTicks(6010), new DateTime(2024, 8, 31, 7, 13, 3, 836, DateTimeKind.Utc).AddTicks(6010) });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: 2057,
                columns: new[] { "ConcurrencyStamp", "CreatedTime", "LastUpdatedTime", "RefreshTokenCreateTime" },
                values: new object[] { "f95bef3a-0a6b-4c7d-b696-a0200672ab25", new DateTime(2024, 8, 31, 7, 13, 3, 836, DateTimeKind.Utc).AddTicks(6020), new DateTime(2024, 8, 31, 7, 13, 3, 836, DateTimeKind.Utc).AddTicks(6020), new DateTime(2024, 8, 31, 7, 13, 3, 836, DateTimeKind.Utc).AddTicks(6010) });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: 2058,
                columns: new[] { "ConcurrencyStamp", "CreatedTime", "LastUpdatedTime", "RefreshTokenCreateTime" },
                values: new object[] { "f04224b0-826f-4917-a6d5-fcc8fdd5c310", new DateTime(2024, 8, 31, 7, 13, 3, 836, DateTimeKind.Utc).AddTicks(6030), new DateTime(2024, 8, 31, 7, 13, 3, 836, DateTimeKind.Utc).AddTicks(6030), new DateTime(2024, 8, 31, 7, 13, 3, 836, DateTimeKind.Utc).AddTicks(6020) });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: 2059,
                columns: new[] { "ConcurrencyStamp", "CreatedTime", "LastUpdatedTime", "RefreshTokenCreateTime" },
                values: new object[] { "e71e9af0-7f24-45ff-aa40-8234b0f657bb", new DateTime(2024, 8, 31, 7, 13, 3, 836, DateTimeKind.Utc).AddTicks(6040), new DateTime(2024, 8, 31, 7, 13, 3, 836, DateTimeKind.Utc).AddTicks(6040), new DateTime(2024, 8, 31, 7, 13, 3, 836, DateTimeKind.Utc).AddTicks(6030) });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: 2060,
                columns: new[] { "ConcurrencyStamp", "CreatedTime", "LastUpdatedTime", "RefreshTokenCreateTime" },
                values: new object[] { "3c15b8e8-eae0-45a1-aaf2-3b06637cdf54", new DateTime(2024, 8, 31, 7, 13, 3, 836, DateTimeKind.Utc).AddTicks(6050), new DateTime(2024, 8, 31, 7, 13, 3, 836, DateTimeKind.Utc).AddTicks(6050), new DateTime(2024, 8, 31, 7, 13, 3, 836, DateTimeKind.Utc).AddTicks(6040) });

            migrationBuilder.UpdateData(
                table: "Breeds",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedTime",
                value: new DateTime(2024, 8, 31, 11, 13, 3, 833, DateTimeKind.Local).AddTicks(6030));

            migrationBuilder.UpdateData(
                table: "Breeds",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreatedTime",
                value: new DateTime(2024, 8, 31, 11, 13, 3, 833, DateTimeKind.Local).AddTicks(6040));

            migrationBuilder.UpdateData(
                table: "Breeds",
                keyColumn: "Id",
                keyValue: 3,
                column: "CreatedTime",
                value: new DateTime(2024, 8, 31, 11, 13, 3, 833, DateTimeKind.Local).AddTicks(6040));

            migrationBuilder.UpdateData(
                table: "Breeds",
                keyColumn: "Id",
                keyValue: 4,
                column: "CreatedTime",
                value: new DateTime(2024, 8, 31, 11, 13, 3, 833, DateTimeKind.Local).AddTicks(6040));

            migrationBuilder.UpdateData(
                table: "Breeds",
                keyColumn: "Id",
                keyValue: 5,
                column: "CreatedTime",
                value: new DateTime(2024, 8, 31, 11, 13, 3, 833, DateTimeKind.Local).AddTicks(6040));

            migrationBuilder.UpdateData(
                table: "Breeds",
                keyColumn: "Id",
                keyValue: 6,
                column: "CreatedTime",
                value: new DateTime(2024, 8, 31, 11, 13, 3, 833, DateTimeKind.Local).AddTicks(6050));

            migrationBuilder.UpdateData(
                table: "Breeds",
                keyColumn: "Id",
                keyValue: 7,
                column: "CreatedTime",
                value: new DateTime(2024, 8, 31, 11, 13, 3, 833, DateTimeKind.Local).AddTicks(6050));

            migrationBuilder.UpdateData(
                table: "Breeds",
                keyColumn: "Id",
                keyValue: 8,
                column: "CreatedTime",
                value: new DateTime(2024, 8, 31, 11, 13, 3, 833, DateTimeKind.Local).AddTicks(6050));

            migrationBuilder.UpdateData(
                table: "Breeds",
                keyColumn: "Id",
                keyValue: 9,
                column: "CreatedTime",
                value: new DateTime(2024, 8, 31, 11, 13, 3, 833, DateTimeKind.Local).AddTicks(6050));

            migrationBuilder.UpdateData(
                table: "Breeds",
                keyColumn: "Id",
                keyValue: 10,
                column: "CreatedTime",
                value: new DateTime(2024, 8, 31, 11, 13, 3, 833, DateTimeKind.Local).AddTicks(6050));

            migrationBuilder.UpdateData(
                table: "Breeds",
                keyColumn: "Id",
                keyValue: 11,
                column: "CreatedTime",
                value: new DateTime(2024, 8, 31, 11, 13, 3, 833, DateTimeKind.Local).AddTicks(6050));

            migrationBuilder.UpdateData(
                table: "Breeds",
                keyColumn: "Id",
                keyValue: 12,
                column: "CreatedTime",
                value: new DateTime(2024, 8, 31, 11, 13, 3, 833, DateTimeKind.Local).AddTicks(6060));

            migrationBuilder.UpdateData(
                table: "Breeds",
                keyColumn: "Id",
                keyValue: 13,
                column: "CreatedTime",
                value: new DateTime(2024, 8, 31, 11, 13, 3, 833, DateTimeKind.Local).AddTicks(6060));

            migrationBuilder.UpdateData(
                table: "Breeds",
                keyColumn: "Id",
                keyValue: 14,
                column: "CreatedTime",
                value: new DateTime(2024, 8, 31, 11, 13, 3, 833, DateTimeKind.Local).AddTicks(6060));

            migrationBuilder.UpdateData(
                table: "Breeds",
                keyColumn: "Id",
                keyValue: 15,
                column: "CreatedTime",
                value: new DateTime(2024, 8, 31, 11, 13, 3, 833, DateTimeKind.Local).AddTicks(6060));

            migrationBuilder.UpdateData(
                table: "Breeds",
                keyColumn: "Id",
                keyValue: 16,
                column: "CreatedTime",
                value: new DateTime(2024, 8, 31, 11, 13, 3, 833, DateTimeKind.Local).AddTicks(6060));

            migrationBuilder.UpdateData(
                table: "Breeds",
                keyColumn: "Id",
                keyValue: 17,
                column: "CreatedTime",
                value: new DateTime(2024, 8, 31, 11, 13, 3, 833, DateTimeKind.Local).AddTicks(6060));

            migrationBuilder.UpdateData(
                table: "Breeds",
                keyColumn: "Id",
                keyValue: 18,
                column: "CreatedTime",
                value: new DateTime(2024, 8, 31, 11, 13, 3, 833, DateTimeKind.Local).AddTicks(6060));

            migrationBuilder.UpdateData(
                table: "Breeds",
                keyColumn: "Id",
                keyValue: 19,
                column: "CreatedTime",
                value: new DateTime(2024, 8, 31, 11, 13, 3, 833, DateTimeKind.Local).AddTicks(6070));

            migrationBuilder.UpdateData(
                table: "Breeds",
                keyColumn: "Id",
                keyValue: 20,
                column: "CreatedTime",
                value: new DateTime(2024, 8, 31, 11, 13, 3, 833, DateTimeKind.Local).AddTicks(6070));

            migrationBuilder.UpdateData(
                table: "Breeds",
                keyColumn: "Id",
                keyValue: 21,
                column: "CreatedTime",
                value: new DateTime(2024, 8, 31, 11, 13, 3, 833, DateTimeKind.Local).AddTicks(6080));

            migrationBuilder.UpdateData(
                table: "Breeds",
                keyColumn: "Id",
                keyValue: 22,
                column: "CreatedTime",
                value: new DateTime(2024, 8, 31, 11, 13, 3, 833, DateTimeKind.Local).AddTicks(6080));

            migrationBuilder.UpdateData(
                table: "Breeds",
                keyColumn: "Id",
                keyValue: 23,
                column: "CreatedTime",
                value: new DateTime(2024, 8, 31, 11, 13, 3, 833, DateTimeKind.Local).AddTicks(6080));

            migrationBuilder.UpdateData(
                table: "Breeds",
                keyColumn: "Id",
                keyValue: 24,
                column: "CreatedTime",
                value: new DateTime(2024, 8, 31, 11, 13, 3, 833, DateTimeKind.Local).AddTicks(6080));

            migrationBuilder.UpdateData(
                table: "Breeds",
                keyColumn: "Id",
                keyValue: 25,
                column: "CreatedTime",
                value: new DateTime(2024, 8, 31, 11, 13, 3, 833, DateTimeKind.Local).AddTicks(6090));

            migrationBuilder.UpdateData(
                table: "Breeds",
                keyColumn: "Id",
                keyValue: 26,
                column: "CreatedTime",
                value: new DateTime(2024, 8, 31, 11, 13, 3, 833, DateTimeKind.Local).AddTicks(6090));

            migrationBuilder.UpdateData(
                table: "Breeds",
                keyColumn: "Id",
                keyValue: 27,
                column: "CreatedTime",
                value: new DateTime(2024, 8, 31, 11, 13, 3, 833, DateTimeKind.Local).AddTicks(6090));

            migrationBuilder.UpdateData(
                table: "Breeds",
                keyColumn: "Id",
                keyValue: 28,
                column: "CreatedTime",
                value: new DateTime(2024, 8, 31, 11, 13, 3, 833, DateTimeKind.Local).AddTicks(6090));

            migrationBuilder.UpdateData(
                table: "Breeds",
                keyColumn: "Id",
                keyValue: 29,
                column: "CreatedTime",
                value: new DateTime(2024, 8, 31, 11, 13, 3, 833, DateTimeKind.Local).AddTicks(6090));

            migrationBuilder.UpdateData(
                table: "Breeds",
                keyColumn: "Id",
                keyValue: 30,
                column: "CreatedTime",
                value: new DateTime(2024, 8, 31, 11, 13, 3, 833, DateTimeKind.Local).AddTicks(6090));

            migrationBuilder.UpdateData(
                table: "Breeds",
                keyColumn: "Id",
                keyValue: 31,
                column: "CreatedTime",
                value: new DateTime(2024, 8, 31, 11, 13, 3, 833, DateTimeKind.Local).AddTicks(6100));

            migrationBuilder.UpdateData(
                table: "Breeds",
                keyColumn: "Id",
                keyValue: 32,
                column: "CreatedTime",
                value: new DateTime(2024, 8, 31, 11, 13, 3, 833, DateTimeKind.Local).AddTicks(6100));

            migrationBuilder.UpdateData(
                table: "Breeds",
                keyColumn: "Id",
                keyValue: 33,
                column: "CreatedTime",
                value: new DateTime(2024, 8, 31, 11, 13, 3, 833, DateTimeKind.Local).AddTicks(6100));

            migrationBuilder.UpdateData(
                table: "Breeds",
                keyColumn: "Id",
                keyValue: 34,
                column: "CreatedTime",
                value: new DateTime(2024, 8, 31, 11, 13, 3, 833, DateTimeKind.Local).AddTicks(6100));

            migrationBuilder.UpdateData(
                table: "Breeds",
                keyColumn: "Id",
                keyValue: 35,
                column: "CreatedTime",
                value: new DateTime(2024, 8, 31, 11, 13, 3, 833, DateTimeKind.Local).AddTicks(6100));

            migrationBuilder.UpdateData(
                table: "Breeds",
                keyColumn: "Id",
                keyValue: 36,
                column: "CreatedTime",
                value: new DateTime(2024, 8, 31, 11, 13, 3, 833, DateTimeKind.Local).AddTicks(6100));

            migrationBuilder.UpdateData(
                table: "Breeds",
                keyColumn: "Id",
                keyValue: 37,
                column: "CreatedTime",
                value: new DateTime(2024, 8, 31, 11, 13, 3, 833, DateTimeKind.Local).AddTicks(6100));

            migrationBuilder.UpdateData(
                table: "Breeds",
                keyColumn: "Id",
                keyValue: 38,
                column: "CreatedTime",
                value: new DateTime(2024, 8, 31, 11, 13, 3, 833, DateTimeKind.Local).AddTicks(6110));

            migrationBuilder.UpdateData(
                table: "Breeds",
                keyColumn: "Id",
                keyValue: 39,
                column: "CreatedTime",
                value: new DateTime(2024, 8, 31, 11, 13, 3, 833, DateTimeKind.Local).AddTicks(6110));

            migrationBuilder.UpdateData(
                table: "Breeds",
                keyColumn: "Id",
                keyValue: 40,
                column: "CreatedTime",
                value: new DateTime(2024, 8, 31, 11, 13, 3, 833, DateTimeKind.Local).AddTicks(6110));

            migrationBuilder.UpdateData(
                table: "Breeds",
                keyColumn: "Id",
                keyValue: 41,
                column: "CreatedTime",
                value: new DateTime(2024, 8, 31, 11, 13, 3, 833, DateTimeKind.Local).AddTicks(6110));

            migrationBuilder.UpdateData(
                table: "Breeds",
                keyColumn: "Id",
                keyValue: 42,
                column: "CreatedTime",
                value: new DateTime(2024, 8, 31, 11, 13, 3, 833, DateTimeKind.Local).AddTicks(6110));

            migrationBuilder.UpdateData(
                table: "Breeds",
                keyColumn: "Id",
                keyValue: 43,
                column: "CreatedTime",
                value: new DateTime(2024, 8, 31, 11, 13, 3, 833, DateTimeKind.Local).AddTicks(6110));

            migrationBuilder.UpdateData(
                table: "Breeds",
                keyColumn: "Id",
                keyValue: 44,
                column: "CreatedTime",
                value: new DateTime(2024, 8, 31, 11, 13, 3, 833, DateTimeKind.Local).AddTicks(6110));

            migrationBuilder.UpdateData(
                table: "Breeds",
                keyColumn: "Id",
                keyValue: 45,
                column: "CreatedTime",
                value: new DateTime(2024, 8, 31, 11, 13, 3, 833, DateTimeKind.Local).AddTicks(6120));

            migrationBuilder.UpdateData(
                table: "Breeds",
                keyColumn: "Id",
                keyValue: 46,
                column: "CreatedTime",
                value: new DateTime(2024, 8, 31, 11, 13, 3, 833, DateTimeKind.Local).AddTicks(6120));

            migrationBuilder.UpdateData(
                table: "Breeds",
                keyColumn: "Id",
                keyValue: 47,
                column: "CreatedTime",
                value: new DateTime(2024, 8, 31, 11, 13, 3, 833, DateTimeKind.Local).AddTicks(6120));

            migrationBuilder.UpdateData(
                table: "Breeds",
                keyColumn: "Id",
                keyValue: 48,
                column: "CreatedTime",
                value: new DateTime(2024, 8, 31, 11, 13, 3, 833, DateTimeKind.Local).AddTicks(6120));

            migrationBuilder.UpdateData(
                table: "Breeds",
                keyColumn: "Id",
                keyValue: 49,
                column: "CreatedTime",
                value: new DateTime(2024, 8, 31, 11, 13, 3, 833, DateTimeKind.Local).AddTicks(6120));

            migrationBuilder.UpdateData(
                table: "Breeds",
                keyColumn: "Id",
                keyValue: 50,
                column: "CreatedTime",
                value: new DateTime(2024, 8, 31, 11, 13, 3, 833, DateTimeKind.Local).AddTicks(6120));

            migrationBuilder.UpdateData(
                table: "Breeds",
                keyColumn: "Id",
                keyValue: 51,
                column: "CreatedTime",
                value: new DateTime(2024, 8, 31, 11, 13, 3, 833, DateTimeKind.Local).AddTicks(6120));

            migrationBuilder.UpdateData(
                table: "Breeds",
                keyColumn: "Id",
                keyValue: 52,
                column: "CreatedTime",
                value: new DateTime(2024, 8, 31, 11, 13, 3, 833, DateTimeKind.Local).AddTicks(6130));

            migrationBuilder.UpdateData(
                table: "Breeds",
                keyColumn: "Id",
                keyValue: 53,
                column: "CreatedTime",
                value: new DateTime(2024, 8, 31, 11, 13, 3, 833, DateTimeKind.Local).AddTicks(6130));

            migrationBuilder.UpdateData(
                table: "Breeds",
                keyColumn: "Id",
                keyValue: 54,
                column: "CreatedTime",
                value: new DateTime(2024, 8, 31, 11, 13, 3, 833, DateTimeKind.Local).AddTicks(6130));

            migrationBuilder.UpdateData(
                table: "Breeds",
                keyColumn: "Id",
                keyValue: 55,
                column: "CreatedTime",
                value: new DateTime(2024, 8, 31, 11, 13, 3, 833, DateTimeKind.Local).AddTicks(6130));

            migrationBuilder.UpdateData(
                table: "Breeds",
                keyColumn: "Id",
                keyValue: 56,
                column: "CreatedTime",
                value: new DateTime(2024, 8, 31, 11, 13, 3, 833, DateTimeKind.Local).AddTicks(6130));

            migrationBuilder.UpdateData(
                table: "Breeds",
                keyColumn: "Id",
                keyValue: 57,
                column: "CreatedTime",
                value: new DateTime(2024, 8, 31, 11, 13, 3, 833, DateTimeKind.Local).AddTicks(6130));

            migrationBuilder.UpdateData(
                table: "Breeds",
                keyColumn: "Id",
                keyValue: 58,
                column: "CreatedTime",
                value: new DateTime(2024, 8, 31, 11, 13, 3, 833, DateTimeKind.Local).AddTicks(6140));

            migrationBuilder.UpdateData(
                table: "Breeds",
                keyColumn: "Id",
                keyValue: 59,
                column: "CreatedTime",
                value: new DateTime(2024, 8, 31, 11, 13, 3, 833, DateTimeKind.Local).AddTicks(6140));

            migrationBuilder.UpdateData(
                table: "Breeds",
                keyColumn: "Id",
                keyValue: 60,
                column: "CreatedTime",
                value: new DateTime(2024, 8, 31, 11, 13, 3, 833, DateTimeKind.Local).AddTicks(6140));

            migrationBuilder.UpdateData(
                table: "Breeds",
                keyColumn: "Id",
                keyValue: 61,
                column: "CreatedTime",
                value: new DateTime(2024, 8, 31, 11, 13, 3, 833, DateTimeKind.Local).AddTicks(6140));

            migrationBuilder.UpdateData(
                table: "Breeds",
                keyColumn: "Id",
                keyValue: 62,
                column: "CreatedTime",
                value: new DateTime(2024, 8, 31, 11, 13, 3, 833, DateTimeKind.Local).AddTicks(6140));

            migrationBuilder.UpdateData(
                table: "Breeds",
                keyColumn: "Id",
                keyValue: 63,
                column: "CreatedTime",
                value: new DateTime(2024, 8, 31, 11, 13, 3, 833, DateTimeKind.Local).AddTicks(6140));

            migrationBuilder.UpdateData(
                table: "Breeds",
                keyColumn: "Id",
                keyValue: 64,
                column: "CreatedTime",
                value: new DateTime(2024, 8, 31, 11, 13, 3, 833, DateTimeKind.Local).AddTicks(6140));

            migrationBuilder.UpdateData(
                table: "Breeds",
                keyColumn: "Id",
                keyValue: 65,
                column: "CreatedTime",
                value: new DateTime(2024, 8, 31, 11, 13, 3, 833, DateTimeKind.Local).AddTicks(6150));

            migrationBuilder.UpdateData(
                table: "Breeds",
                keyColumn: "Id",
                keyValue: 66,
                column: "CreatedTime",
                value: new DateTime(2024, 8, 31, 11, 13, 3, 833, DateTimeKind.Local).AddTicks(6150));

            migrationBuilder.UpdateData(
                table: "Breeds",
                keyColumn: "Id",
                keyValue: 67,
                column: "CreatedTime",
                value: new DateTime(2024, 8, 31, 11, 13, 3, 833, DateTimeKind.Local).AddTicks(6150));

            migrationBuilder.UpdateData(
                table: "Breeds",
                keyColumn: "Id",
                keyValue: 68,
                column: "CreatedTime",
                value: new DateTime(2024, 8, 31, 11, 13, 3, 833, DateTimeKind.Local).AddTicks(6150));

            migrationBuilder.UpdateData(
                table: "Breeds",
                keyColumn: "Id",
                keyValue: 69,
                column: "CreatedTime",
                value: new DateTime(2024, 8, 31, 11, 13, 3, 833, DateTimeKind.Local).AddTicks(6150));

            migrationBuilder.UpdateData(
                table: "Breeds",
                keyColumn: "Id",
                keyValue: 70,
                column: "CreatedTime",
                value: new DateTime(2024, 8, 31, 11, 13, 3, 833, DateTimeKind.Local).AddTicks(6150));

            migrationBuilder.UpdateData(
                table: "Breeds",
                keyColumn: "Id",
                keyValue: 71,
                column: "CreatedTime",
                value: new DateTime(2024, 8, 31, 11, 13, 3, 833, DateTimeKind.Local).AddTicks(6150));

            migrationBuilder.UpdateData(
                table: "Breeds",
                keyColumn: "Id",
                keyValue: 72,
                column: "CreatedTime",
                value: new DateTime(2024, 8, 31, 11, 13, 3, 833, DateTimeKind.Local).AddTicks(6160));

            migrationBuilder.UpdateData(
                table: "Breeds",
                keyColumn: "Id",
                keyValue: 73,
                column: "CreatedTime",
                value: new DateTime(2024, 8, 31, 11, 13, 3, 833, DateTimeKind.Local).AddTicks(6160));

            migrationBuilder.UpdateData(
                table: "Breeds",
                keyColumn: "Id",
                keyValue: 74,
                column: "CreatedTime",
                value: new DateTime(2024, 8, 31, 11, 13, 3, 833, DateTimeKind.Local).AddTicks(6160));

            migrationBuilder.UpdateData(
                table: "Breeds",
                keyColumn: "Id",
                keyValue: 75,
                column: "CreatedTime",
                value: new DateTime(2024, 8, 31, 11, 13, 3, 833, DateTimeKind.Local).AddTicks(6160));

            migrationBuilder.UpdateData(
                table: "Breeds",
                keyColumn: "Id",
                keyValue: 76,
                column: "CreatedTime",
                value: new DateTime(2024, 8, 31, 11, 13, 3, 833, DateTimeKind.Local).AddTicks(6160));

            migrationBuilder.UpdateData(
                table: "Breeds",
                keyColumn: "Id",
                keyValue: 77,
                column: "CreatedTime",
                value: new DateTime(2024, 8, 31, 11, 13, 3, 833, DateTimeKind.Local).AddTicks(6160));

            migrationBuilder.UpdateData(
                table: "Breeds",
                keyColumn: "Id",
                keyValue: 78,
                column: "CreatedTime",
                value: new DateTime(2024, 8, 31, 11, 13, 3, 833, DateTimeKind.Local).AddTicks(6170));

            migrationBuilder.UpdateData(
                table: "Breeds",
                keyColumn: "Id",
                keyValue: 79,
                column: "CreatedTime",
                value: new DateTime(2024, 8, 31, 11, 13, 3, 833, DateTimeKind.Local).AddTicks(6170));

            migrationBuilder.UpdateData(
                table: "Breeds",
                keyColumn: "Id",
                keyValue: 80,
                column: "CreatedTime",
                value: new DateTime(2024, 8, 31, 11, 13, 3, 833, DateTimeKind.Local).AddTicks(6170));

            migrationBuilder.UpdateData(
                table: "Breeds",
                keyColumn: "Id",
                keyValue: 81,
                column: "CreatedTime",
                value: new DateTime(2024, 8, 31, 11, 13, 3, 833, DateTimeKind.Local).AddTicks(6170));

            migrationBuilder.UpdateData(
                table: "Breeds",
                keyColumn: "Id",
                keyValue: 82,
                column: "CreatedTime",
                value: new DateTime(2024, 8, 31, 11, 13, 3, 833, DateTimeKind.Local).AddTicks(6170));

            migrationBuilder.UpdateData(
                table: "Breeds",
                keyColumn: "Id",
                keyValue: 83,
                column: "CreatedTime",
                value: new DateTime(2024, 8, 31, 11, 13, 3, 833, DateTimeKind.Local).AddTicks(6170));

            migrationBuilder.UpdateData(
                table: "Breeds",
                keyColumn: "Id",
                keyValue: 84,
                column: "CreatedTime",
                value: new DateTime(2024, 8, 31, 11, 13, 3, 833, DateTimeKind.Local).AddTicks(6170));

            migrationBuilder.UpdateData(
                table: "Breeds",
                keyColumn: "Id",
                keyValue: 85,
                column: "CreatedTime",
                value: new DateTime(2024, 8, 31, 11, 13, 3, 833, DateTimeKind.Local).AddTicks(6180));

            migrationBuilder.UpdateData(
                table: "Breeds",
                keyColumn: "Id",
                keyValue: 86,
                column: "CreatedTime",
                value: new DateTime(2024, 8, 31, 11, 13, 3, 833, DateTimeKind.Local).AddTicks(6180));

            migrationBuilder.UpdateData(
                table: "Breeds",
                keyColumn: "Id",
                keyValue: 87,
                column: "CreatedTime",
                value: new DateTime(2024, 8, 31, 11, 13, 3, 833, DateTimeKind.Local).AddTicks(6180));

            migrationBuilder.UpdateData(
                table: "Breeds",
                keyColumn: "Id",
                keyValue: 88,
                column: "CreatedTime",
                value: new DateTime(2024, 8, 31, 11, 13, 3, 833, DateTimeKind.Local).AddTicks(6190));

            migrationBuilder.UpdateData(
                table: "Breeds",
                keyColumn: "Id",
                keyValue: 89,
                column: "CreatedTime",
                value: new DateTime(2024, 8, 31, 11, 13, 3, 833, DateTimeKind.Local).AddTicks(6190));

            migrationBuilder.UpdateData(
                table: "Breeds",
                keyColumn: "Id",
                keyValue: 90,
                column: "CreatedTime",
                value: new DateTime(2024, 8, 31, 11, 13, 3, 833, DateTimeKind.Local).AddTicks(6190));

            migrationBuilder.UpdateData(
                table: "Breeds",
                keyColumn: "Id",
                keyValue: 91,
                column: "CreatedTime",
                value: new DateTime(2024, 8, 31, 11, 13, 3, 833, DateTimeKind.Local).AddTicks(6190));

            migrationBuilder.UpdateData(
                table: "Breeds",
                keyColumn: "Id",
                keyValue: 92,
                column: "CreatedTime",
                value: new DateTime(2024, 8, 31, 11, 13, 3, 833, DateTimeKind.Local).AddTicks(6190));

            migrationBuilder.UpdateData(
                table: "Breeds",
                keyColumn: "Id",
                keyValue: 93,
                column: "CreatedTime",
                value: new DateTime(2024, 8, 31, 11, 13, 3, 833, DateTimeKind.Local).AddTicks(6190));

            migrationBuilder.UpdateData(
                table: "Breeds",
                keyColumn: "Id",
                keyValue: 94,
                column: "CreatedTime",
                value: new DateTime(2024, 8, 31, 11, 13, 3, 833, DateTimeKind.Local).AddTicks(6190));

            migrationBuilder.UpdateData(
                table: "Breeds",
                keyColumn: "Id",
                keyValue: 95,
                column: "CreatedTime",
                value: new DateTime(2024, 8, 31, 11, 13, 3, 833, DateTimeKind.Local).AddTicks(6200));

            migrationBuilder.UpdateData(
                table: "Breeds",
                keyColumn: "Id",
                keyValue: 96,
                column: "CreatedTime",
                value: new DateTime(2024, 8, 31, 11, 13, 3, 833, DateTimeKind.Local).AddTicks(6200));

            migrationBuilder.UpdateData(
                table: "Breeds",
                keyColumn: "Id",
                keyValue: 97,
                column: "CreatedTime",
                value: new DateTime(2024, 8, 31, 11, 13, 3, 833, DateTimeKind.Local).AddTicks(6200));

            migrationBuilder.UpdateData(
                table: "Breeds",
                keyColumn: "Id",
                keyValue: 98,
                column: "CreatedTime",
                value: new DateTime(2024, 8, 31, 11, 13, 3, 833, DateTimeKind.Local).AddTicks(6200));

            migrationBuilder.UpdateData(
                table: "Breeds",
                keyColumn: "Id",
                keyValue: 99,
                column: "CreatedTime",
                value: new DateTime(2024, 8, 31, 11, 13, 3, 833, DateTimeKind.Local).AddTicks(6200));

            migrationBuilder.UpdateData(
                table: "Breeds",
                keyColumn: "Id",
                keyValue: 100,
                column: "CreatedTime",
                value: new DateTime(2024, 8, 31, 11, 13, 3, 833, DateTimeKind.Local).AddTicks(6200));

            migrationBuilder.UpdateData(
                table: "Breeds",
                keyColumn: "Id",
                keyValue: 101,
                column: "CreatedTime",
                value: new DateTime(2024, 8, 31, 11, 13, 3, 833, DateTimeKind.Local).AddTicks(6200));

            migrationBuilder.UpdateData(
                table: "Breeds",
                keyColumn: "Id",
                keyValue: 102,
                column: "CreatedTime",
                value: new DateTime(2024, 8, 31, 11, 13, 3, 833, DateTimeKind.Local).AddTicks(6210));

            migrationBuilder.UpdateData(
                table: "Breeds",
                keyColumn: "Id",
                keyValue: 103,
                column: "CreatedTime",
                value: new DateTime(2024, 8, 31, 11, 13, 3, 833, DateTimeKind.Local).AddTicks(6210));

            migrationBuilder.UpdateData(
                table: "Breeds",
                keyColumn: "Id",
                keyValue: 104,
                column: "CreatedTime",
                value: new DateTime(2024, 8, 31, 11, 13, 3, 833, DateTimeKind.Local).AddTicks(6210));

            migrationBuilder.UpdateData(
                table: "Breeds",
                keyColumn: "Id",
                keyValue: 105,
                column: "CreatedTime",
                value: new DateTime(2024, 8, 31, 11, 13, 3, 833, DateTimeKind.Local).AddTicks(6210));

            migrationBuilder.UpdateData(
                table: "Breeds",
                keyColumn: "Id",
                keyValue: 106,
                column: "CreatedTime",
                value: new DateTime(2024, 8, 31, 11, 13, 3, 833, DateTimeKind.Local).AddTicks(6210));

            migrationBuilder.UpdateData(
                table: "Breeds",
                keyColumn: "Id",
                keyValue: 107,
                column: "CreatedTime",
                value: new DateTime(2024, 8, 31, 11, 13, 3, 833, DateTimeKind.Local).AddTicks(6210));

            migrationBuilder.UpdateData(
                table: "Breeds",
                keyColumn: "Id",
                keyValue: 108,
                column: "CreatedTime",
                value: new DateTime(2024, 8, 31, 11, 13, 3, 833, DateTimeKind.Local).AddTicks(6220));

            migrationBuilder.UpdateData(
                table: "Breeds",
                keyColumn: "Id",
                keyValue: 109,
                column: "CreatedTime",
                value: new DateTime(2024, 8, 31, 11, 13, 3, 833, DateTimeKind.Local).AddTicks(6220));

            migrationBuilder.UpdateData(
                table: "Breeds",
                keyColumn: "Id",
                keyValue: 110,
                column: "CreatedTime",
                value: new DateTime(2024, 8, 31, 11, 13, 3, 833, DateTimeKind.Local).AddTicks(6220));

            migrationBuilder.UpdateData(
                table: "Breeds",
                keyColumn: "Id",
                keyValue: 111,
                column: "CreatedTime",
                value: new DateTime(2024, 8, 31, 11, 13, 3, 833, DateTimeKind.Local).AddTicks(6220));

            migrationBuilder.UpdateData(
                table: "Breeds",
                keyColumn: "Id",
                keyValue: 112,
                column: "CreatedTime",
                value: new DateTime(2024, 8, 31, 11, 13, 3, 833, DateTimeKind.Local).AddTicks(6220));

            migrationBuilder.UpdateData(
                table: "Breeds",
                keyColumn: "Id",
                keyValue: 113,
                column: "CreatedTime",
                value: new DateTime(2024, 8, 31, 11, 13, 3, 833, DateTimeKind.Local).AddTicks(6220));

            migrationBuilder.UpdateData(
                table: "Breeds",
                keyColumn: "Id",
                keyValue: 114,
                column: "CreatedTime",
                value: new DateTime(2024, 8, 31, 11, 13, 3, 833, DateTimeKind.Local).AddTicks(6230));

            migrationBuilder.UpdateData(
                table: "Breeds",
                keyColumn: "Id",
                keyValue: 115,
                column: "CreatedTime",
                value: new DateTime(2024, 8, 31, 11, 13, 3, 833, DateTimeKind.Local).AddTicks(6230));

            migrationBuilder.UpdateData(
                table: "Breeds",
                keyColumn: "Id",
                keyValue: 116,
                column: "CreatedTime",
                value: new DateTime(2024, 8, 31, 11, 13, 3, 833, DateTimeKind.Local).AddTicks(6230));

            migrationBuilder.UpdateData(
                table: "Breeds",
                keyColumn: "Id",
                keyValue: 117,
                column: "CreatedTime",
                value: new DateTime(2024, 8, 31, 11, 13, 3, 833, DateTimeKind.Local).AddTicks(6230));

            migrationBuilder.UpdateData(
                table: "Breeds",
                keyColumn: "Id",
                keyValue: 118,
                column: "CreatedTime",
                value: new DateTime(2024, 8, 31, 11, 13, 3, 833, DateTimeKind.Local).AddTicks(6230));

            migrationBuilder.UpdateData(
                table: "Breeds",
                keyColumn: "Id",
                keyValue: 119,
                column: "CreatedTime",
                value: new DateTime(2024, 8, 31, 11, 13, 3, 833, DateTimeKind.Local).AddTicks(6230));

            migrationBuilder.UpdateData(
                table: "Breeds",
                keyColumn: "Id",
                keyValue: 120,
                column: "CreatedTime",
                value: new DateTime(2024, 8, 31, 11, 13, 3, 833, DateTimeKind.Local).AddTicks(6230));

            migrationBuilder.UpdateData(
                table: "Breeds",
                keyColumn: "Id",
                keyValue: 121,
                column: "CreatedTime",
                value: new DateTime(2024, 8, 31, 11, 13, 3, 833, DateTimeKind.Local).AddTicks(6240));

            migrationBuilder.UpdateData(
                table: "Breeds",
                keyColumn: "Id",
                keyValue: 122,
                column: "CreatedTime",
                value: new DateTime(2024, 8, 31, 11, 13, 3, 833, DateTimeKind.Local).AddTicks(6240));

            migrationBuilder.UpdateData(
                table: "Breeds",
                keyColumn: "Id",
                keyValue: 123,
                column: "CreatedTime",
                value: new DateTime(2024, 8, 31, 11, 13, 3, 833, DateTimeKind.Local).AddTicks(6240));

            migrationBuilder.UpdateData(
                table: "Breeds",
                keyColumn: "Id",
                keyValue: 124,
                column: "CreatedTime",
                value: new DateTime(2024, 8, 31, 11, 13, 3, 833, DateTimeKind.Local).AddTicks(6240));

            migrationBuilder.UpdateData(
                table: "Breeds",
                keyColumn: "Id",
                keyValue: 125,
                column: "CreatedTime",
                value: new DateTime(2024, 8, 31, 11, 13, 3, 833, DateTimeKind.Local).AddTicks(6240));

            migrationBuilder.UpdateData(
                table: "Breeds",
                keyColumn: "Id",
                keyValue: 126,
                column: "CreatedTime",
                value: new DateTime(2024, 8, 31, 11, 13, 3, 833, DateTimeKind.Local).AddTicks(6240));

            migrationBuilder.UpdateData(
                table: "Breeds",
                keyColumn: "Id",
                keyValue: 127,
                column: "CreatedTime",
                value: new DateTime(2024, 8, 31, 11, 13, 3, 833, DateTimeKind.Local).AddTicks(6250));

            migrationBuilder.UpdateData(
                table: "Breeds",
                keyColumn: "Id",
                keyValue: 128,
                column: "CreatedTime",
                value: new DateTime(2024, 8, 31, 11, 13, 3, 833, DateTimeKind.Local).AddTicks(6250));

            migrationBuilder.UpdateData(
                table: "Breeds",
                keyColumn: "Id",
                keyValue: 129,
                column: "CreatedTime",
                value: new DateTime(2024, 8, 31, 11, 13, 3, 833, DateTimeKind.Local).AddTicks(6250));

            migrationBuilder.UpdateData(
                table: "Breeds",
                keyColumn: "Id",
                keyValue: 130,
                column: "CreatedTime",
                value: new DateTime(2024, 8, 31, 11, 13, 3, 833, DateTimeKind.Local).AddTicks(6250));

            migrationBuilder.UpdateData(
                table: "Breeds",
                keyColumn: "Id",
                keyValue: 131,
                column: "CreatedTime",
                value: new DateTime(2024, 8, 31, 11, 13, 3, 833, DateTimeKind.Local).AddTicks(6250));

            migrationBuilder.UpdateData(
                table: "Breeds",
                keyColumn: "Id",
                keyValue: 132,
                column: "CreatedTime",
                value: new DateTime(2024, 8, 31, 11, 13, 3, 833, DateTimeKind.Local).AddTicks(6250));

            migrationBuilder.UpdateData(
                table: "Breeds",
                keyColumn: "Id",
                keyValue: 133,
                column: "CreatedTime",
                value: new DateTime(2024, 8, 31, 11, 13, 3, 833, DateTimeKind.Local).AddTicks(6250));

            migrationBuilder.UpdateData(
                table: "Breeds",
                keyColumn: "Id",
                keyValue: 134,
                column: "CreatedTime",
                value: new DateTime(2024, 8, 31, 11, 13, 3, 833, DateTimeKind.Local).AddTicks(6260));

            migrationBuilder.UpdateData(
                table: "Breeds",
                keyColumn: "Id",
                keyValue: 135,
                column: "CreatedTime",
                value: new DateTime(2024, 8, 31, 11, 13, 3, 833, DateTimeKind.Local).AddTicks(6260));

            migrationBuilder.UpdateData(
                table: "Breeds",
                keyColumn: "Id",
                keyValue: 136,
                column: "CreatedTime",
                value: new DateTime(2024, 8, 31, 11, 13, 3, 833, DateTimeKind.Local).AddTicks(6260));

            migrationBuilder.UpdateData(
                table: "Breeds",
                keyColumn: "Id",
                keyValue: 137,
                column: "CreatedTime",
                value: new DateTime(2024, 8, 31, 11, 13, 3, 833, DateTimeKind.Local).AddTicks(6260));

            migrationBuilder.UpdateData(
                table: "Breeds",
                keyColumn: "Id",
                keyValue: 138,
                column: "CreatedTime",
                value: new DateTime(2024, 8, 31, 11, 13, 3, 833, DateTimeKind.Local).AddTicks(6260));

            migrationBuilder.UpdateData(
                table: "Breeds",
                keyColumn: "Id",
                keyValue: 139,
                column: "CreatedTime",
                value: new DateTime(2024, 8, 31, 11, 13, 3, 833, DateTimeKind.Local).AddTicks(6260));

            migrationBuilder.UpdateData(
                table: "Breeds",
                keyColumn: "Id",
                keyValue: 140,
                column: "CreatedTime",
                value: new DateTime(2024, 8, 31, 11, 13, 3, 833, DateTimeKind.Local).AddTicks(6260));

            migrationBuilder.UpdateData(
                table: "Breeds",
                keyColumn: "Id",
                keyValue: 141,
                column: "CreatedTime",
                value: new DateTime(2024, 8, 31, 11, 13, 3, 833, DateTimeKind.Local).AddTicks(6270));

            migrationBuilder.UpdateData(
                table: "Breeds",
                keyColumn: "Id",
                keyValue: 142,
                column: "CreatedTime",
                value: new DateTime(2024, 8, 31, 11, 13, 3, 833, DateTimeKind.Local).AddTicks(6270));

            migrationBuilder.UpdateData(
                table: "Breeds",
                keyColumn: "Id",
                keyValue: 143,
                column: "CreatedTime",
                value: new DateTime(2024, 8, 31, 11, 13, 3, 833, DateTimeKind.Local).AddTicks(6270));

            migrationBuilder.UpdateData(
                table: "Breeds",
                keyColumn: "Id",
                keyValue: 144,
                column: "CreatedTime",
                value: new DateTime(2024, 8, 31, 11, 13, 3, 833, DateTimeKind.Local).AddTicks(6270));

            migrationBuilder.UpdateData(
                table: "Breeds",
                keyColumn: "Id",
                keyValue: 145,
                column: "CreatedTime",
                value: new DateTime(2024, 8, 31, 11, 13, 3, 833, DateTimeKind.Local).AddTicks(6270));

            migrationBuilder.UpdateData(
                table: "Breeds",
                keyColumn: "Id",
                keyValue: 146,
                column: "CreatedTime",
                value: new DateTime(2024, 8, 31, 11, 13, 3, 833, DateTimeKind.Local).AddTicks(6270));

            migrationBuilder.UpdateData(
                table: "Breeds",
                keyColumn: "Id",
                keyValue: 147,
                column: "CreatedTime",
                value: new DateTime(2024, 8, 31, 11, 13, 3, 833, DateTimeKind.Local).AddTicks(6270));

            migrationBuilder.UpdateData(
                table: "Breeds",
                keyColumn: "Id",
                keyValue: 148,
                column: "CreatedTime",
                value: new DateTime(2024, 8, 31, 11, 13, 3, 833, DateTimeKind.Local).AddTicks(6280));

            migrationBuilder.UpdateData(
                table: "Breeds",
                keyColumn: "Id",
                keyValue: 149,
                column: "CreatedTime",
                value: new DateTime(2024, 8, 31, 11, 13, 3, 833, DateTimeKind.Local).AddTicks(6280));

            migrationBuilder.UpdateData(
                table: "Breeds",
                keyColumn: "Id",
                keyValue: 150,
                column: "CreatedTime",
                value: new DateTime(2024, 8, 31, 11, 13, 3, 833, DateTimeKind.Local).AddTicks(6280));

            migrationBuilder.UpdateData(
                table: "Breeds",
                keyColumn: "Id",
                keyValue: 151,
                column: "CreatedTime",
                value: new DateTime(2024, 8, 31, 11, 13, 3, 833, DateTimeKind.Local).AddTicks(6280));

            migrationBuilder.UpdateData(
                table: "Breeds",
                keyColumn: "Id",
                keyValue: 152,
                column: "CreatedTime",
                value: new DateTime(2024, 8, 31, 11, 13, 3, 833, DateTimeKind.Local).AddTicks(6280));

            migrationBuilder.UpdateData(
                table: "Breeds",
                keyColumn: "Id",
                keyValue: 153,
                column: "CreatedTime",
                value: new DateTime(2024, 8, 31, 11, 13, 3, 833, DateTimeKind.Local).AddTicks(6280));

            migrationBuilder.UpdateData(
                table: "Breeds",
                keyColumn: "Id",
                keyValue: 154,
                column: "CreatedTime",
                value: new DateTime(2024, 8, 31, 11, 13, 3, 833, DateTimeKind.Local).AddTicks(6290));

            migrationBuilder.UpdateData(
                table: "Breeds",
                keyColumn: "Id",
                keyValue: 155,
                column: "CreatedTime",
                value: new DateTime(2024, 8, 31, 11, 13, 3, 833, DateTimeKind.Local).AddTicks(6290));

            migrationBuilder.UpdateData(
                table: "Breeds",
                keyColumn: "Id",
                keyValue: 156,
                column: "CreatedTime",
                value: new DateTime(2024, 8, 31, 11, 13, 3, 833, DateTimeKind.Local).AddTicks(6290));

            migrationBuilder.UpdateData(
                table: "Breeds",
                keyColumn: "Id",
                keyValue: 157,
                column: "CreatedTime",
                value: new DateTime(2024, 8, 31, 11, 13, 3, 833, DateTimeKind.Local).AddTicks(6290));

            migrationBuilder.UpdateData(
                table: "Breeds",
                keyColumn: "Id",
                keyValue: 158,
                column: "CreatedTime",
                value: new DateTime(2024, 8, 31, 11, 13, 3, 833, DateTimeKind.Local).AddTicks(6290));

            migrationBuilder.UpdateData(
                table: "Breeds",
                keyColumn: "Id",
                keyValue: 159,
                column: "CreatedTime",
                value: new DateTime(2024, 8, 31, 11, 13, 3, 833, DateTimeKind.Local).AddTicks(6290));

            migrationBuilder.UpdateData(
                table: "Breeds",
                keyColumn: "Id",
                keyValue: 160,
                column: "CreatedTime",
                value: new DateTime(2024, 8, 31, 11, 13, 3, 833, DateTimeKind.Local).AddTicks(6290));

            migrationBuilder.UpdateData(
                table: "PetTypes",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedTime",
                value: new DateTime(2024, 8, 31, 11, 13, 3, 833, DateTimeKind.Local).AddTicks(5350));

            migrationBuilder.UpdateData(
                table: "PetTypes",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreatedTime",
                value: new DateTime(2024, 8, 31, 11, 13, 3, 833, DateTimeKind.Local).AddTicks(5350));

            migrationBuilder.UpdateData(
                table: "PetTypes",
                keyColumn: "Id",
                keyValue: 3,
                column: "CreatedTime",
                value: new DateTime(2024, 8, 31, 11, 13, 3, 833, DateTimeKind.Local).AddTicks(5360));

            migrationBuilder.UpdateData(
                table: "PetTypes",
                keyColumn: "Id",
                keyValue: 4,
                column: "CreatedTime",
                value: new DateTime(2024, 8, 31, 11, 13, 3, 833, DateTimeKind.Local).AddTicks(5360));

            migrationBuilder.UpdateData(
                table: "PetTypes",
                keyColumn: "Id",
                keyValue: 5,
                column: "CreatedTime",
                value: new DateTime(2024, 8, 31, 11, 13, 3, 833, DateTimeKind.Local).AddTicks(5360));

            migrationBuilder.UpdateData(
                table: "PetTypes",
                keyColumn: "Id",
                keyValue: 6,
                column: "CreatedTime",
                value: new DateTime(2024, 8, 31, 11, 13, 3, 833, DateTimeKind.Local).AddTicks(5360));

            migrationBuilder.UpdateData(
                table: "PetTypes",
                keyColumn: "Id",
                keyValue: 7,
                column: "CreatedTime",
                value: new DateTime(2024, 8, 31, 11, 13, 3, 833, DateTimeKind.Local).AddTicks(5360));

            migrationBuilder.UpdateData(
                table: "PetTypes",
                keyColumn: "Id",
                keyValue: 8,
                column: "CreatedTime",
                value: new DateTime(2024, 8, 31, 11, 13, 3, 833, DateTimeKind.Local).AddTicks(5360));

            migrationBuilder.UpdateData(
                table: "Pets",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedTime",
                value: new DateTime(2024, 8, 31, 11, 13, 3, 836, DateTimeKind.Local).AddTicks(8220));

            migrationBuilder.UpdateData(
                table: "Pets",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreatedTime",
                value: new DateTime(2024, 8, 31, 11, 13, 3, 836, DateTimeKind.Local).AddTicks(8230));

            migrationBuilder.UpdateData(
                table: "Pets",
                keyColumn: "Id",
                keyValue: 3,
                column: "CreatedTime",
                value: new DateTime(2024, 8, 31, 11, 13, 3, 836, DateTimeKind.Local).AddTicks(8240));

            migrationBuilder.UpdateData(
                table: "Pets",
                keyColumn: "Id",
                keyValue: 4,
                column: "CreatedTime",
                value: new DateTime(2024, 8, 31, 11, 13, 3, 836, DateTimeKind.Local).AddTicks(8240));

            migrationBuilder.UpdateData(
                table: "Pets",
                keyColumn: "Id",
                keyValue: 5,
                column: "CreatedTime",
                value: new DateTime(2024, 8, 31, 11, 13, 3, 836, DateTimeKind.Local).AddTicks(8240));

            migrationBuilder.UpdateData(
                table: "Pets",
                keyColumn: "Id",
                keyValue: 6,
                column: "CreatedTime",
                value: new DateTime(2024, 8, 31, 11, 13, 3, 836, DateTimeKind.Local).AddTicks(8250));

            migrationBuilder.UpdateData(
                table: "Pets",
                keyColumn: "Id",
                keyValue: 7,
                column: "CreatedTime",
                value: new DateTime(2024, 8, 31, 11, 13, 3, 836, DateTimeKind.Local).AddTicks(8250));

            migrationBuilder.UpdateData(
                table: "Pets",
                keyColumn: "Id",
                keyValue: 8,
                column: "CreatedTime",
                value: new DateTime(2024, 8, 31, 11, 13, 3, 836, DateTimeKind.Local).AddTicks(8260));

            migrationBuilder.UpdateData(
                table: "Pets",
                keyColumn: "Id",
                keyValue: 9,
                column: "CreatedTime",
                value: new DateTime(2024, 8, 31, 11, 13, 3, 836, DateTimeKind.Local).AddTicks(8270));

            migrationBuilder.UpdateData(
                table: "Pets",
                keyColumn: "Id",
                keyValue: 10,
                column: "CreatedTime",
                value: new DateTime(2024, 8, 31, 11, 13, 3, 836, DateTimeKind.Local).AddTicks(8270));

            migrationBuilder.UpdateData(
                table: "Pets",
                keyColumn: "Id",
                keyValue: 11,
                column: "CreatedTime",
                value: new DateTime(2024, 8, 31, 11, 13, 3, 836, DateTimeKind.Local).AddTicks(8270));

            migrationBuilder.UpdateData(
                table: "Pets",
                keyColumn: "Id",
                keyValue: 12,
                column: "CreatedTime",
                value: new DateTime(2024, 8, 31, 11, 13, 3, 836, DateTimeKind.Local).AddTicks(8280));

            migrationBuilder.UpdateData(
                table: "Pets",
                keyColumn: "Id",
                keyValue: 13,
                column: "CreatedTime",
                value: new DateTime(2024, 8, 31, 11, 13, 3, 836, DateTimeKind.Local).AddTicks(8280));

            migrationBuilder.UpdateData(
                table: "Pets",
                keyColumn: "Id",
                keyValue: 14,
                column: "CreatedTime",
                value: new DateTime(2024, 8, 31, 11, 13, 3, 836, DateTimeKind.Local).AddTicks(8280));

            migrationBuilder.UpdateData(
                table: "Pets",
                keyColumn: "Id",
                keyValue: 15,
                column: "CreatedTime",
                value: new DateTime(2024, 8, 31, 11, 13, 3, 836, DateTimeKind.Local).AddTicks(8300));

            migrationBuilder.UpdateData(
                table: "Pets",
                keyColumn: "Id",
                keyValue: 16,
                column: "CreatedTime",
                value: new DateTime(2024, 8, 31, 11, 13, 3, 836, DateTimeKind.Local).AddTicks(8310));

            migrationBuilder.UpdateData(
                table: "Pets",
                keyColumn: "Id",
                keyValue: 17,
                column: "CreatedTime",
                value: new DateTime(2024, 8, 31, 11, 13, 3, 836, DateTimeKind.Local).AddTicks(8310));

            migrationBuilder.UpdateData(
                table: "Pets",
                keyColumn: "Id",
                keyValue: 18,
                column: "CreatedTime",
                value: new DateTime(2024, 8, 31, 11, 13, 3, 836, DateTimeKind.Local).AddTicks(8310));

            migrationBuilder.UpdateData(
                table: "Pets",
                keyColumn: "Id",
                keyValue: 19,
                column: "CreatedTime",
                value: new DateTime(2024, 8, 31, 11, 13, 3, 836, DateTimeKind.Local).AddTicks(8320));

            migrationBuilder.UpdateData(
                table: "Pets",
                keyColumn: "Id",
                keyValue: 20,
                column: "CreatedTime",
                value: new DateTime(2024, 8, 31, 11, 13, 3, 836, DateTimeKind.Local).AddTicks(8320));

            migrationBuilder.UpdateData(
                table: "Pets",
                keyColumn: "Id",
                keyValue: 21,
                column: "CreatedTime",
                value: new DateTime(2024, 8, 31, 11, 13, 3, 836, DateTimeKind.Local).AddTicks(8320));

            migrationBuilder.UpdateData(
                table: "Pets",
                keyColumn: "Id",
                keyValue: 22,
                column: "CreatedTime",
                value: new DateTime(2024, 8, 31, 11, 13, 3, 836, DateTimeKind.Local).AddTicks(8330));

            migrationBuilder.UpdateData(
                table: "Pets",
                keyColumn: "Id",
                keyValue: 23,
                column: "CreatedTime",
                value: new DateTime(2024, 8, 31, 11, 13, 3, 836, DateTimeKind.Local).AddTicks(8330));

            migrationBuilder.UpdateData(
                table: "Pets",
                keyColumn: "Id",
                keyValue: 24,
                column: "CreatedTime",
                value: new DateTime(2024, 8, 31, 11, 13, 3, 836, DateTimeKind.Local).AddTicks(8330));

            migrationBuilder.UpdateData(
                table: "Pets",
                keyColumn: "Id",
                keyValue: 25,
                column: "CreatedTime",
                value: new DateTime(2024, 8, 31, 11, 13, 3, 836, DateTimeKind.Local).AddTicks(8330));

            migrationBuilder.UpdateData(
                table: "Pets",
                keyColumn: "Id",
                keyValue: 26,
                column: "CreatedTime",
                value: new DateTime(2024, 8, 31, 11, 13, 3, 836, DateTimeKind.Local).AddTicks(8340));

            migrationBuilder.UpdateData(
                table: "Pets",
                keyColumn: "Id",
                keyValue: 27,
                column: "CreatedTime",
                value: new DateTime(2024, 8, 31, 11, 13, 3, 836, DateTimeKind.Local).AddTicks(8340));

            migrationBuilder.UpdateData(
                table: "Pets",
                keyColumn: "Id",
                keyValue: 28,
                column: "CreatedTime",
                value: new DateTime(2024, 8, 31, 11, 13, 3, 836, DateTimeKind.Local).AddTicks(8340));

            migrationBuilder.UpdateData(
                table: "Pets",
                keyColumn: "Id",
                keyValue: 29,
                column: "CreatedTime",
                value: new DateTime(2024, 8, 31, 11, 13, 3, 836, DateTimeKind.Local).AddTicks(8350));

            migrationBuilder.UpdateData(
                table: "Pets",
                keyColumn: "Id",
                keyValue: 30,
                column: "CreatedTime",
                value: new DateTime(2024, 8, 31, 11, 13, 3, 836, DateTimeKind.Local).AddTicks(8350));

            migrationBuilder.UpdateData(
                table: "Pets",
                keyColumn: "Id",
                keyValue: 31,
                column: "CreatedTime",
                value: new DateTime(2024, 8, 31, 11, 13, 3, 836, DateTimeKind.Local).AddTicks(8350));

            migrationBuilder.UpdateData(
                table: "Pets",
                keyColumn: "Id",
                keyValue: 32,
                column: "CreatedTime",
                value: new DateTime(2024, 8, 31, 11, 13, 3, 836, DateTimeKind.Local).AddTicks(8360));

            migrationBuilder.UpdateData(
                table: "Pets",
                keyColumn: "Id",
                keyValue: 33,
                column: "CreatedTime",
                value: new DateTime(2024, 8, 31, 11, 13, 3, 836, DateTimeKind.Local).AddTicks(8360));

            migrationBuilder.UpdateData(
                table: "Pets",
                keyColumn: "Id",
                keyValue: 34,
                column: "CreatedTime",
                value: new DateTime(2024, 8, 31, 11, 13, 3, 836, DateTimeKind.Local).AddTicks(8360));

            migrationBuilder.UpdateData(
                table: "Pets",
                keyColumn: "Id",
                keyValue: 35,
                column: "CreatedTime",
                value: new DateTime(2024, 8, 31, 11, 13, 3, 836, DateTimeKind.Local).AddTicks(8370));

            migrationBuilder.UpdateData(
                table: "Pets",
                keyColumn: "Id",
                keyValue: 36,
                column: "CreatedTime",
                value: new DateTime(2024, 8, 31, 11, 13, 3, 836, DateTimeKind.Local).AddTicks(8370));

            migrationBuilder.UpdateData(
                table: "Pets",
                keyColumn: "Id",
                keyValue: 37,
                column: "CreatedTime",
                value: new DateTime(2024, 8, 31, 11, 13, 3, 836, DateTimeKind.Local).AddTicks(8370));

            migrationBuilder.UpdateData(
                table: "Pets",
                keyColumn: "Id",
                keyValue: 38,
                column: "CreatedTime",
                value: new DateTime(2024, 8, 31, 11, 13, 3, 836, DateTimeKind.Local).AddTicks(8380));

            migrationBuilder.UpdateData(
                table: "Pets",
                keyColumn: "Id",
                keyValue: 39,
                column: "CreatedTime",
                value: new DateTime(2024, 8, 31, 11, 13, 3, 836, DateTimeKind.Local).AddTicks(8380));

            migrationBuilder.UpdateData(
                table: "Pets",
                keyColumn: "Id",
                keyValue: 40,
                column: "CreatedTime",
                value: new DateTime(2024, 8, 31, 11, 13, 3, 836, DateTimeKind.Local).AddTicks(8380));

            migrationBuilder.UpdateData(
                table: "Pets",
                keyColumn: "Id",
                keyValue: 41,
                column: "CreatedTime",
                value: new DateTime(2024, 8, 31, 11, 13, 3, 836, DateTimeKind.Local).AddTicks(8390));

            migrationBuilder.UpdateData(
                table: "Pets",
                keyColumn: "Id",
                keyValue: 42,
                column: "CreatedTime",
                value: new DateTime(2024, 8, 31, 11, 13, 3, 836, DateTimeKind.Local).AddTicks(8390));

            migrationBuilder.UpdateData(
                table: "Pets",
                keyColumn: "Id",
                keyValue: 43,
                column: "CreatedTime",
                value: new DateTime(2024, 8, 31, 11, 13, 3, 836, DateTimeKind.Local).AddTicks(8390));

            migrationBuilder.UpdateData(
                table: "Pets",
                keyColumn: "Id",
                keyValue: 44,
                column: "CreatedTime",
                value: new DateTime(2024, 8, 31, 11, 13, 3, 836, DateTimeKind.Local).AddTicks(8400));

            migrationBuilder.UpdateData(
                table: "Pets",
                keyColumn: "Id",
                keyValue: 45,
                column: "CreatedTime",
                value: new DateTime(2024, 8, 31, 11, 13, 3, 836, DateTimeKind.Local).AddTicks(8400));

            migrationBuilder.UpdateData(
                table: "Pets",
                keyColumn: "Id",
                keyValue: 46,
                column: "CreatedTime",
                value: new DateTime(2024, 8, 31, 11, 13, 3, 836, DateTimeKind.Local).AddTicks(8400));

            migrationBuilder.UpdateData(
                table: "Pets",
                keyColumn: "Id",
                keyValue: 47,
                column: "CreatedTime",
                value: new DateTime(2024, 8, 31, 11, 13, 3, 836, DateTimeKind.Local).AddTicks(8400));

            migrationBuilder.UpdateData(
                table: "Pets",
                keyColumn: "Id",
                keyValue: 48,
                column: "CreatedTime",
                value: new DateTime(2024, 8, 31, 11, 13, 3, 836, DateTimeKind.Local).AddTicks(8410));

            migrationBuilder.UpdateData(
                table: "Pets",
                keyColumn: "Id",
                keyValue: 49,
                column: "CreatedTime",
                value: new DateTime(2024, 8, 31, 11, 13, 3, 836, DateTimeKind.Local).AddTicks(8410));

            migrationBuilder.UpdateData(
                table: "Pets",
                keyColumn: "Id",
                keyValue: 50,
                column: "CreatedTime",
                value: new DateTime(2024, 8, 31, 11, 13, 3, 836, DateTimeKind.Local).AddTicks(8410));

            migrationBuilder.UpdateData(
                table: "Shelters",
                keyColumn: "Id",
                keyValue: 1021,
                columns: new[] { "CreatedTime", "LastUpdatedTime" },
                values: new object[] { new DateTime(2024, 8, 31, 7, 13, 3, 833, DateTimeKind.Utc).AddTicks(4970), new DateTime(2024, 8, 31, 7, 13, 3, 833, DateTimeKind.Utc).AddTicks(4970) });

            migrationBuilder.UpdateData(
                table: "Shelters",
                keyColumn: "Id",
                keyValue: 1022,
                columns: new[] { "CreatedTime", "LastUpdatedTime" },
                values: new object[] { new DateTime(2024, 8, 31, 7, 13, 3, 833, DateTimeKind.Utc).AddTicks(4980), new DateTime(2024, 8, 31, 7, 13, 3, 833, DateTimeKind.Utc).AddTicks(4980) });

            migrationBuilder.UpdateData(
                table: "Shelters",
                keyColumn: "Id",
                keyValue: 1023,
                columns: new[] { "CreatedTime", "LastUpdatedTime" },
                values: new object[] { new DateTime(2024, 8, 31, 7, 13, 3, 833, DateTimeKind.Utc).AddTicks(4990), new DateTime(2024, 8, 31, 7, 13, 3, 833, DateTimeKind.Utc).AddTicks(4990) });

            migrationBuilder.UpdateData(
                table: "Shelters",
                keyColumn: "Id",
                keyValue: 1024,
                columns: new[] { "CreatedTime", "LastUpdatedTime" },
                values: new object[] { new DateTime(2024, 8, 31, 7, 13, 3, 833, DateTimeKind.Utc).AddTicks(5000), new DateTime(2024, 8, 31, 7, 13, 3, 833, DateTimeKind.Utc).AddTicks(5000) });

            migrationBuilder.UpdateData(
                table: "Shelters",
                keyColumn: "Id",
                keyValue: 1025,
                columns: new[] { "CreatedTime", "LastUpdatedTime" },
                values: new object[] { new DateTime(2024, 8, 31, 7, 13, 3, 833, DateTimeKind.Utc).AddTicks(5000), new DateTime(2024, 8, 31, 7, 13, 3, 833, DateTimeKind.Utc).AddTicks(5000) });

            migrationBuilder.UpdateData(
                table: "Shelters",
                keyColumn: "Id",
                keyValue: 1026,
                columns: new[] { "CreatedTime", "LastUpdatedTime" },
                values: new object[] { new DateTime(2024, 8, 31, 7, 13, 3, 833, DateTimeKind.Utc).AddTicks(5010), new DateTime(2024, 8, 31, 7, 13, 3, 833, DateTimeKind.Utc).AddTicks(5010) });

            migrationBuilder.UpdateData(
                table: "Shelters",
                keyColumn: "Id",
                keyValue: 1027,
                columns: new[] { "CreatedTime", "LastUpdatedTime" },
                values: new object[] { new DateTime(2024, 8, 31, 7, 13, 3, 833, DateTimeKind.Utc).AddTicks(5010), new DateTime(2024, 8, 31, 7, 13, 3, 833, DateTimeKind.Utc).AddTicks(5020) });

            migrationBuilder.UpdateData(
                table: "Shelters",
                keyColumn: "Id",
                keyValue: 1028,
                columns: new[] { "CreatedTime", "LastUpdatedTime" },
                values: new object[] { new DateTime(2024, 8, 31, 7, 13, 3, 833, DateTimeKind.Utc).AddTicks(5020), new DateTime(2024, 8, 31, 7, 13, 3, 833, DateTimeKind.Utc).AddTicks(5020) });

            migrationBuilder.UpdateData(
                table: "Shelters",
                keyColumn: "Id",
                keyValue: 1029,
                columns: new[] { "CreatedTime", "LastUpdatedTime" },
                values: new object[] { new DateTime(2024, 8, 31, 7, 13, 3, 833, DateTimeKind.Utc).AddTicks(5030), new DateTime(2024, 8, 31, 7, 13, 3, 833, DateTimeKind.Utc).AddTicks(5030) });

            migrationBuilder.UpdateData(
                table: "Shelters",
                keyColumn: "Id",
                keyValue: 1030,
                columns: new[] { "CreatedTime", "LastUpdatedTime" },
                values: new object[] { new DateTime(2024, 8, 31, 7, 13, 3, 833, DateTimeKind.Utc).AddTicks(5030), new DateTime(2024, 8, 31, 7, 13, 3, 833, DateTimeKind.Utc).AddTicks(5030) });

            migrationBuilder.UpdateData(
                table: "Shelters",
                keyColumn: "Id",
                keyValue: 1031,
                columns: new[] { "CreatedTime", "LastUpdatedTime" },
                values: new object[] { new DateTime(2024, 8, 31, 7, 13, 3, 833, DateTimeKind.Utc).AddTicks(5040), new DateTime(2024, 8, 31, 7, 13, 3, 833, DateTimeKind.Utc).AddTicks(5040) });

            migrationBuilder.UpdateData(
                table: "Shelters",
                keyColumn: "Id",
                keyValue: 1032,
                columns: new[] { "CreatedTime", "LastUpdatedTime" },
                values: new object[] { new DateTime(2024, 8, 31, 7, 13, 3, 833, DateTimeKind.Utc).AddTicks(5050), new DateTime(2024, 8, 31, 7, 13, 3, 833, DateTimeKind.Utc).AddTicks(5050) });

            migrationBuilder.UpdateData(
                table: "Shelters",
                keyColumn: "Id",
                keyValue: 1033,
                columns: new[] { "CreatedTime", "LastUpdatedTime" },
                values: new object[] { new DateTime(2024, 8, 31, 7, 13, 3, 833, DateTimeKind.Utc).AddTicks(5050), new DateTime(2024, 8, 31, 7, 13, 3, 833, DateTimeKind.Utc).AddTicks(5050) });

            migrationBuilder.UpdateData(
                table: "Shelters",
                keyColumn: "Id",
                keyValue: 1034,
                columns: new[] { "CreatedTime", "LastUpdatedTime" },
                values: new object[] { new DateTime(2024, 8, 31, 7, 13, 3, 833, DateTimeKind.Utc).AddTicks(5060), new DateTime(2024, 8, 31, 7, 13, 3, 833, DateTimeKind.Utc).AddTicks(5060) });

            migrationBuilder.UpdateData(
                table: "Shelters",
                keyColumn: "Id",
                keyValue: 1035,
                columns: new[] { "CreatedTime", "LastUpdatedTime" },
                values: new object[] { new DateTime(2024, 8, 31, 7, 13, 3, 833, DateTimeKind.Utc).AddTicks(5080), new DateTime(2024, 8, 31, 7, 13, 3, 833, DateTimeKind.Utc).AddTicks(5080) });

            migrationBuilder.UpdateData(
                table: "Shelters",
                keyColumn: "Id",
                keyValue: 1036,
                columns: new[] { "CreatedTime", "LastUpdatedTime" },
                values: new object[] { new DateTime(2024, 8, 31, 7, 13, 3, 833, DateTimeKind.Utc).AddTicks(5090), new DateTime(2024, 8, 31, 7, 13, 3, 833, DateTimeKind.Utc).AddTicks(5090) });

            migrationBuilder.UpdateData(
                table: "Shelters",
                keyColumn: "Id",
                keyValue: 1037,
                columns: new[] { "CreatedTime", "LastUpdatedTime" },
                values: new object[] { new DateTime(2024, 8, 31, 7, 13, 3, 833, DateTimeKind.Utc).AddTicks(5090), new DateTime(2024, 8, 31, 7, 13, 3, 833, DateTimeKind.Utc).AddTicks(5090) });

            migrationBuilder.UpdateData(
                table: "Shelters",
                keyColumn: "Id",
                keyValue: 1038,
                columns: new[] { "CreatedTime", "LastUpdatedTime" },
                values: new object[] { new DateTime(2024, 8, 31, 7, 13, 3, 833, DateTimeKind.Utc).AddTicks(5100), new DateTime(2024, 8, 31, 7, 13, 3, 833, DateTimeKind.Utc).AddTicks(5100) });

            migrationBuilder.UpdateData(
                table: "Shelters",
                keyColumn: "Id",
                keyValue: 1039,
                columns: new[] { "CreatedTime", "LastUpdatedTime" },
                values: new object[] { new DateTime(2024, 8, 31, 7, 13, 3, 833, DateTimeKind.Utc).AddTicks(5100), new DateTime(2024, 8, 31, 7, 13, 3, 833, DateTimeKind.Utc).AddTicks(5110) });

            migrationBuilder.UpdateData(
                table: "Shelters",
                keyColumn: "Id",
                keyValue: 1040,
                columns: new[] { "CreatedTime", "LastUpdatedTime" },
                values: new object[] { new DateTime(2024, 8, 31, 7, 13, 3, 833, DateTimeKind.Utc).AddTicks(5110), new DateTime(2024, 8, 31, 7, 13, 3, 833, DateTimeKind.Utc).AddTicks(5110) });

            migrationBuilder.CreateIndex(
                name: "IX_Adoptions_PetId",
                table: "Adoptions",
                column: "PetId",
                unique: true);
        }
    }
}
