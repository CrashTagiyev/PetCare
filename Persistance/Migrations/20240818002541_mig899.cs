using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Persistance.Migrations
{
    /// <inheritdoc />
    public partial class mig899 : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<string>(
                name: "AboutShelter",
                table: "Shelters",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "AdoptionPolicy",
                table: "Shelters",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: 2001,
                columns: new[] { "About", "Address", "City", "ConcurrencyStamp", "CreatedTime", "LastUpdatedTime", "RefreshTokenCreateTime" },
                values: new object[] { "Somme about text for something bla bla bla", "Koroglu Rahimov 70", "Baku", "35c3e0cc-9de5-40fd-acbe-bec6d24065fe", new DateTime(2024, 8, 18, 0, 25, 40, 96, DateTimeKind.Utc).AddTicks(2487), new DateTime(2024, 8, 18, 0, 25, 40, 96, DateTimeKind.Utc).AddTicks(2488), new DateTime(2024, 8, 18, 4, 25, 40, 96, DateTimeKind.Local).AddTicks(2408) });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: 2002,
                columns: new[] { "About", "Address", "City", "ConcurrencyStamp", "CreatedTime", "LastUpdatedTime", "RefreshTokenCreateTime" },
                values: new object[] { "Somme about text for something bla bla bla", "Koroglu Rahimov 70", "Baku", "5aa081a9-9664-481b-a773-7922578cd746", new DateTime(2024, 8, 18, 0, 25, 40, 96, DateTimeKind.Utc).AddTicks(2549), new DateTime(2024, 8, 18, 0, 25, 40, 96, DateTimeKind.Utc).AddTicks(2549), new DateTime(2024, 8, 18, 4, 25, 40, 96, DateTimeKind.Local).AddTicks(2544) });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: 2003,
                columns: new[] { "About", "Address", "City", "ConcurrencyStamp", "CreatedTime", "LastUpdatedTime", "RefreshTokenCreateTime" },
                values: new object[] { "Somme about text for something bla bla bla", "Koroglu Rahimov 70", "Baku", "28c8aa5f-1b8f-4671-a917-e5d17f92d2c7", new DateTime(2024, 8, 18, 0, 25, 40, 96, DateTimeKind.Utc).AddTicks(2575), new DateTime(2024, 8, 18, 0, 25, 40, 96, DateTimeKind.Utc).AddTicks(2576), new DateTime(2024, 8, 18, 4, 25, 40, 96, DateTimeKind.Local).AddTicks(2559) });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: 2004,
                columns: new[] { "About", "Address", "City", "ConcurrencyStamp", "CreatedTime", "LastUpdatedTime", "RefreshTokenCreateTime" },
                values: new object[] { "Somme about text for something bla bla bla", "Koroglu Rahimov 70", "Baku", "8d2bff1a-cf30-4324-af48-082c129795b6", new DateTime(2024, 8, 18, 0, 25, 40, 96, DateTimeKind.Utc).AddTicks(2588), new DateTime(2024, 8, 18, 0, 25, 40, 96, DateTimeKind.Utc).AddTicks(2588), new DateTime(2024, 8, 18, 4, 25, 40, 96, DateTimeKind.Local).AddTicks(2584) });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: 2005,
                columns: new[] { "About", "Address", "City", "ConcurrencyStamp", "CreatedTime", "LastUpdatedTime", "RefreshTokenCreateTime" },
                values: new object[] { "Somme about text for something bla bla bla", "Koroglu Rahimov 70", "Baku", "1972a1a6-419f-4555-b26c-d3f7e0baca51", new DateTime(2024, 8, 18, 0, 25, 40, 96, DateTimeKind.Utc).AddTicks(2599), new DateTime(2024, 8, 18, 0, 25, 40, 96, DateTimeKind.Utc).AddTicks(2600), new DateTime(2024, 8, 18, 4, 25, 40, 96, DateTimeKind.Local).AddTicks(2596) });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: 2006,
                columns: new[] { "About", "Address", "City", "ConcurrencyStamp", "CreatedTime", "LastUpdatedTime", "RefreshTokenCreateTime" },
                values: new object[] { "Somme about text for something bla bla bla", "Koroglu Rahimov 70", "Baku", "1bdd8cd9-181d-4a1b-8dc4-68f125f1d81e", new DateTime(2024, 8, 18, 0, 25, 40, 96, DateTimeKind.Utc).AddTicks(2615), new DateTime(2024, 8, 18, 0, 25, 40, 96, DateTimeKind.Utc).AddTicks(2616), new DateTime(2024, 8, 18, 4, 25, 40, 96, DateTimeKind.Local).AddTicks(2611) });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: 2007,
                columns: new[] { "About", "Address", "City", "ConcurrencyStamp", "CreatedTime", "LastUpdatedTime", "RefreshTokenCreateTime" },
                values: new object[] { "Somme about text for something bla bla bla", "Koroglu Rahimov 70", "Baku", "c2b6b14f-a4b7-4be1-b39d-c551e77a4c1e", new DateTime(2024, 8, 18, 0, 25, 40, 96, DateTimeKind.Utc).AddTicks(2627), new DateTime(2024, 8, 18, 0, 25, 40, 96, DateTimeKind.Utc).AddTicks(2628), new DateTime(2024, 8, 18, 4, 25, 40, 96, DateTimeKind.Local).AddTicks(2624) });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: 2008,
                columns: new[] { "About", "Address", "City", "ConcurrencyStamp", "CreatedTime", "LastUpdatedTime", "RefreshTokenCreateTime" },
                values: new object[] { "Somme about text for something bla bla bla", "Koroglu Rahimov 70", "Baku", "f877fc86-2f5a-40a5-bf93-bb88c184c50b", new DateTime(2024, 8, 18, 0, 25, 40, 96, DateTimeKind.Utc).AddTicks(2694), new DateTime(2024, 8, 18, 0, 25, 40, 96, DateTimeKind.Utc).AddTicks(2694), new DateTime(2024, 8, 18, 4, 25, 40, 96, DateTimeKind.Local).AddTicks(2690) });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: 2009,
                columns: new[] { "About", "Address", "City", "ConcurrencyStamp", "CreatedTime", "LastUpdatedTime", "RefreshTokenCreateTime" },
                values: new object[] { "Somme about text for something bla bla bla", "Koroglu Rahimov 70", "Baku", "674041e1-1dc1-4dfb-b2d2-2221d9bb3c58", new DateTime(2024, 8, 18, 0, 25, 40, 96, DateTimeKind.Utc).AddTicks(2706), new DateTime(2024, 8, 18, 0, 25, 40, 96, DateTimeKind.Utc).AddTicks(2707), new DateTime(2024, 8, 18, 4, 25, 40, 96, DateTimeKind.Local).AddTicks(2703) });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: 2010,
                columns: new[] { "About", "Address", "City", "ConcurrencyStamp", "CreatedTime", "LastUpdatedTime", "RefreshTokenCreateTime" },
                values: new object[] { "Somme about text for something bla bla bla", "Koroglu Rahimov 70", "Baku", "d1457913-6fae-4af5-9825-3b51a93e3340", new DateTime(2024, 8, 18, 0, 25, 40, 96, DateTimeKind.Utc).AddTicks(2720), new DateTime(2024, 8, 18, 0, 25, 40, 96, DateTimeKind.Utc).AddTicks(2721), new DateTime(2024, 8, 18, 4, 25, 40, 96, DateTimeKind.Local).AddTicks(2717) });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: 2011,
                columns: new[] { "About", "Address", "City", "ConcurrencyStamp", "CreatedTime", "LastUpdatedTime", "RefreshTokenCreateTime" },
                values: new object[] { "Somme about text for something bla bla bla", "Koroglu Rahimov 70", "Baku", "d96fb4b5-1f65-4c57-9c36-c66d33c586ca", new DateTime(2024, 8, 18, 0, 25, 40, 96, DateTimeKind.Utc).AddTicks(2740), new DateTime(2024, 8, 18, 0, 25, 40, 96, DateTimeKind.Utc).AddTicks(2740), new DateTime(2024, 8, 18, 4, 25, 40, 96, DateTimeKind.Local).AddTicks(2732) });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: 2012,
                columns: new[] { "About", "Address", "City", "ConcurrencyStamp", "CreatedTime", "LastUpdatedTime", "RefreshTokenCreateTime" },
                values: new object[] { "Somme about text for something bla bla bla", "Koroglu Rahimov 70", "Baku", "ec111df7-d734-4d92-a320-f382539a0596", new DateTime(2024, 8, 18, 0, 25, 40, 96, DateTimeKind.Utc).AddTicks(2752), new DateTime(2024, 8, 18, 0, 25, 40, 96, DateTimeKind.Utc).AddTicks(2753), new DateTime(2024, 8, 18, 4, 25, 40, 96, DateTimeKind.Local).AddTicks(2749) });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: 2013,
                columns: new[] { "About", "Address", "City", "ConcurrencyStamp", "CreatedTime", "LastUpdatedTime", "RefreshTokenCreateTime" },
                values: new object[] { "Somme about text for something bla bla bla", "Koroglu Rahimov 70", "Baku", "45d9d15b-458c-4c4b-ac92-1bc6088d4b04", new DateTime(2024, 8, 18, 0, 25, 40, 96, DateTimeKind.Utc).AddTicks(2764), new DateTime(2024, 8, 18, 0, 25, 40, 96, DateTimeKind.Utc).AddTicks(2765), new DateTime(2024, 8, 18, 4, 25, 40, 96, DateTimeKind.Local).AddTicks(2761) });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: 2014,
                columns: new[] { "About", "Address", "City", "ConcurrencyStamp", "CreatedTime", "LastUpdatedTime", "RefreshTokenCreateTime" },
                values: new object[] { "Somme about text for something bla bla bla", "Koroglu Rahimov 70", "Baku", "f6326293-ba97-47b0-9c3b-00eaefb34cf2", new DateTime(2024, 8, 18, 0, 25, 40, 96, DateTimeKind.Utc).AddTicks(2776), new DateTime(2024, 8, 18, 0, 25, 40, 96, DateTimeKind.Utc).AddTicks(2776), new DateTime(2024, 8, 18, 4, 25, 40, 96, DateTimeKind.Local).AddTicks(2773) });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: 2015,
                columns: new[] { "About", "Address", "City", "ConcurrencyStamp", "CreatedTime", "LastUpdatedTime", "RefreshTokenCreateTime" },
                values: new object[] { "Somme about text for something bla bla bla", "Koroglu Rahimov 70", "Baku", "7ccd5538-d80d-4a76-b543-3b9d73c272c4", new DateTime(2024, 8, 18, 0, 25, 40, 96, DateTimeKind.Utc).AddTicks(2788), new DateTime(2024, 8, 18, 0, 25, 40, 96, DateTimeKind.Utc).AddTicks(2788), new DateTime(2024, 8, 18, 4, 25, 40, 96, DateTimeKind.Local).AddTicks(2785) });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: 2016,
                columns: new[] { "About", "Address", "City", "ConcurrencyStamp", "CreatedTime", "LastUpdatedTime", "RefreshTokenCreateTime" },
                values: new object[] { "Somme about text for something bla bla bla", "Koroglu Rahimov 70", "Baku", "78fdfa6c-f33b-4e38-8b38-66364a4dec76", new DateTime(2024, 8, 18, 0, 25, 40, 96, DateTimeKind.Utc).AddTicks(2800), new DateTime(2024, 8, 18, 0, 25, 40, 96, DateTimeKind.Utc).AddTicks(2800), new DateTime(2024, 8, 18, 4, 25, 40, 96, DateTimeKind.Local).AddTicks(2797) });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: 2017,
                columns: new[] { "About", "Address", "City", "ConcurrencyStamp", "CreatedTime", "LastUpdatedTime", "RefreshTokenCreateTime" },
                values: new object[] { "Somme about text for something bla bla bla", "Koroglu Rahimov 70", "Baku", "847d427a-488a-4259-b1f7-15e99721e3f4", new DateTime(2024, 8, 18, 0, 25, 40, 96, DateTimeKind.Utc).AddTicks(2811), new DateTime(2024, 8, 18, 0, 25, 40, 96, DateTimeKind.Utc).AddTicks(2812), new DateTime(2024, 8, 18, 4, 25, 40, 96, DateTimeKind.Local).AddTicks(2808) });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: 2018,
                columns: new[] { "About", "Address", "City", "ConcurrencyStamp", "CreatedTime", "LastUpdatedTime", "RefreshTokenCreateTime" },
                values: new object[] { "Somme about text for something bla bla bla", "Koroglu Rahimov 70", "Baku", "4a752bb8-e53c-4c8c-a560-cb5929c9202b", new DateTime(2024, 8, 18, 0, 25, 40, 96, DateTimeKind.Utc).AddTicks(2857), new DateTime(2024, 8, 18, 0, 25, 40, 96, DateTimeKind.Utc).AddTicks(2857), new DateTime(2024, 8, 18, 4, 25, 40, 96, DateTimeKind.Local).AddTicks(2853) });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: 2019,
                columns: new[] { "About", "Address", "City", "ConcurrencyStamp", "CreatedTime", "LastUpdatedTime", "RefreshTokenCreateTime" },
                values: new object[] { "Somme about text for something bla bla bla", "Koroglu Rahimov 70", "Baku", "f4005c92-2a19-4dfc-8918-45603de1d61b", new DateTime(2024, 8, 18, 0, 25, 40, 96, DateTimeKind.Utc).AddTicks(2873), new DateTime(2024, 8, 18, 0, 25, 40, 96, DateTimeKind.Utc).AddTicks(2874), new DateTime(2024, 8, 18, 4, 25, 40, 96, DateTimeKind.Local).AddTicks(2867) });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: 2020,
                columns: new[] { "About", "Address", "City", "ConcurrencyStamp", "CreatedTime", "LastUpdatedTime", "RefreshTokenCreateTime" },
                values: new object[] { "Somme about text for something bla bla bla", "Koroglu Rahimov 70", "Baku", "5c98b8ca-3686-4b36-9057-68fb0db730a2", new DateTime(2024, 8, 18, 0, 25, 40, 96, DateTimeKind.Utc).AddTicks(2885), new DateTime(2024, 8, 18, 0, 25, 40, 96, DateTimeKind.Utc).AddTicks(2886), new DateTime(2024, 8, 18, 4, 25, 40, 96, DateTimeKind.Local).AddTicks(2882) });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: 2021,
                columns: new[] { "About", "Address", "City", "ConcurrencyStamp", "CreatedTime", "LastUpdatedTime", "RefreshTokenCreateTime" },
                values: new object[] { "Somme about text for something bla bla bla", "Koroglu Rahimov 70", "Baku", "19cc291e-3204-4d67-b84b-ad880c48e3f2", new DateTime(2024, 8, 18, 0, 25, 40, 96, DateTimeKind.Utc).AddTicks(2897), new DateTime(2024, 8, 18, 0, 25, 40, 96, DateTimeKind.Utc).AddTicks(2898), new DateTime(2024, 8, 18, 4, 25, 40, 96, DateTimeKind.Local).AddTicks(2894) });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: 2022,
                columns: new[] { "About", "Address", "City", "ConcurrencyStamp", "CreatedTime", "LastUpdatedTime", "RefreshTokenCreateTime" },
                values: new object[] { "Somme about text for something bla bla bla", "Koroglu Rahimov 70", "Baku", "9a904312-dc7b-4fa2-87ea-0f60c6aab6f5", new DateTime(2024, 8, 18, 0, 25, 40, 96, DateTimeKind.Utc).AddTicks(2915), new DateTime(2024, 8, 18, 0, 25, 40, 96, DateTimeKind.Utc).AddTicks(2916), new DateTime(2024, 8, 18, 4, 25, 40, 96, DateTimeKind.Local).AddTicks(2912) });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: 2023,
                columns: new[] { "About", "Address", "City", "ConcurrencyStamp", "CreatedTime", "LastUpdatedTime", "RefreshTokenCreateTime" },
                values: new object[] { "Somme about text for something bla bla bla", "Koroglu Rahimov 70", "Baku", "a58d2144-f6f2-4928-9185-5755be8dbff9", new DateTime(2024, 8, 18, 0, 25, 40, 96, DateTimeKind.Utc).AddTicks(2929), new DateTime(2024, 8, 18, 0, 25, 40, 96, DateTimeKind.Utc).AddTicks(2929), new DateTime(2024, 8, 18, 4, 25, 40, 96, DateTimeKind.Local).AddTicks(2926) });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: 2024,
                columns: new[] { "About", "Address", "City", "ConcurrencyStamp", "CreatedTime", "LastUpdatedTime", "RefreshTokenCreateTime" },
                values: new object[] { "Somme about text for something bla bla bla", "Koroglu Rahimov 70", "Baku", "6951c6ac-821f-4d91-9a06-f2ea0de88812", new DateTime(2024, 8, 18, 0, 25, 40, 96, DateTimeKind.Utc).AddTicks(2942), new DateTime(2024, 8, 18, 0, 25, 40, 96, DateTimeKind.Utc).AddTicks(2943), new DateTime(2024, 8, 18, 4, 25, 40, 96, DateTimeKind.Local).AddTicks(2939) });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: 2025,
                columns: new[] { "About", "Address", "City", "ConcurrencyStamp", "CreatedTime", "LastUpdatedTime", "RefreshTokenCreateTime" },
                values: new object[] { "Somme about text for something bla bla bla", "Koroglu Rahimov 70", "Baku", "d7e7f11f-dd8d-4fc5-9ce0-03d0168f7672", new DateTime(2024, 8, 18, 0, 25, 40, 96, DateTimeKind.Utc).AddTicks(2955), new DateTime(2024, 8, 18, 0, 25, 40, 96, DateTimeKind.Utc).AddTicks(2955), new DateTime(2024, 8, 18, 4, 25, 40, 96, DateTimeKind.Local).AddTicks(2952) });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: 2026,
                columns: new[] { "About", "Address", "City", "ConcurrencyStamp", "CreatedTime", "LastUpdatedTime", "RefreshTokenCreateTime" },
                values: new object[] { "Somme about text for something bla bla bla", "Koroglu Rahimov 70", "Baku", "87a48e5a-72b9-413c-ad42-1a2952b5d85c", new DateTime(2024, 8, 18, 0, 25, 40, 96, DateTimeKind.Utc).AddTicks(2967), new DateTime(2024, 8, 18, 0, 25, 40, 96, DateTimeKind.Utc).AddTicks(2968), new DateTime(2024, 8, 18, 4, 25, 40, 96, DateTimeKind.Local).AddTicks(2964) });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: 2027,
                columns: new[] { "About", "Address", "City", "ConcurrencyStamp", "CreatedTime", "LastUpdatedTime", "RefreshTokenCreateTime" },
                values: new object[] { "Somme about text for something bla bla bla", "Koroglu Rahimov 70", "Baku", "61d5c89e-86e9-4e49-b2ab-10c6b1c82817", new DateTime(2024, 8, 18, 0, 25, 40, 96, DateTimeKind.Utc).AddTicks(3014), new DateTime(2024, 8, 18, 0, 25, 40, 96, DateTimeKind.Utc).AddTicks(3015), new DateTime(2024, 8, 18, 4, 25, 40, 96, DateTimeKind.Local).AddTicks(3007) });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: 2028,
                columns: new[] { "About", "Address", "City", "ConcurrencyStamp", "CreatedTime", "LastUpdatedTime", "RefreshTokenCreateTime" },
                values: new object[] { "Somme about text for something bla bla bla", "Koroglu Rahimov 70", "Baku", "a8489d20-ca38-41c6-b0e7-568e66d2f170", new DateTime(2024, 8, 18, 0, 25, 40, 96, DateTimeKind.Utc).AddTicks(3027), new DateTime(2024, 8, 18, 0, 25, 40, 96, DateTimeKind.Utc).AddTicks(3028), new DateTime(2024, 8, 18, 4, 25, 40, 96, DateTimeKind.Local).AddTicks(3024) });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: 2029,
                columns: new[] { "About", "Address", "City", "ConcurrencyStamp", "CreatedTime", "LastUpdatedTime", "RefreshTokenCreateTime" },
                values: new object[] { "Somme about text for something bla bla bla", "Koroglu Rahimov 70", "Baku", "0d5eead4-567a-47f5-9f27-f5baa87dd909", new DateTime(2024, 8, 18, 0, 25, 40, 96, DateTimeKind.Utc).AddTicks(3040), new DateTime(2024, 8, 18, 0, 25, 40, 96, DateTimeKind.Utc).AddTicks(3040), new DateTime(2024, 8, 18, 4, 25, 40, 96, DateTimeKind.Local).AddTicks(3036) });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: 2030,
                columns: new[] { "About", "Address", "City", "ConcurrencyStamp", "CreatedTime", "LastUpdatedTime", "RefreshTokenCreateTime" },
                values: new object[] { "Somme about text for something bla bla bla", "Koroglu Rahimov 70", "Baku", "ab437893-15f5-4439-ac9f-4c20cd7ad715", new DateTime(2024, 8, 18, 0, 25, 40, 96, DateTimeKind.Utc).AddTicks(3052), new DateTime(2024, 8, 18, 0, 25, 40, 96, DateTimeKind.Utc).AddTicks(3052), new DateTime(2024, 8, 18, 4, 25, 40, 96, DateTimeKind.Local).AddTicks(3049) });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: 2031,
                columns: new[] { "About", "Address", "City", "ConcurrencyStamp", "CreatedTime", "LastUpdatedTime", "RefreshTokenCreateTime" },
                values: new object[] { "Somme about text for something bla bla bla", "Koroglu Rahimov 70", "Baku", "dffb09d0-08b4-499c-afbc-e7071fe5d5c6", new DateTime(2024, 8, 18, 0, 25, 40, 96, DateTimeKind.Utc).AddTicks(3064), new DateTime(2024, 8, 18, 0, 25, 40, 96, DateTimeKind.Utc).AddTicks(3064), new DateTime(2024, 8, 18, 4, 25, 40, 96, DateTimeKind.Local).AddTicks(3060) });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: 2032,
                columns: new[] { "About", "Address", "City", "ConcurrencyStamp", "CreatedTime", "LastUpdatedTime", "RefreshTokenCreateTime" },
                values: new object[] { "Somme about text for something bla bla bla", "Koroglu Rahimov 70", "Baku", "6103268b-f37b-4a98-acd0-b2a3ca97e92a", new DateTime(2024, 8, 18, 0, 25, 40, 96, DateTimeKind.Utc).AddTicks(3077), new DateTime(2024, 8, 18, 0, 25, 40, 96, DateTimeKind.Utc).AddTicks(3077), new DateTime(2024, 8, 18, 4, 25, 40, 96, DateTimeKind.Local).AddTicks(3073) });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: 2033,
                columns: new[] { "About", "Address", "City", "ConcurrencyStamp", "CreatedTime", "LastUpdatedTime", "RefreshTokenCreateTime" },
                values: new object[] { "Somme about text for something bla bla bla", "Koroglu Rahimov 70", "Baku", "0b6c2176-a91a-488e-8171-bfc277535509", new DateTime(2024, 8, 18, 0, 25, 40, 96, DateTimeKind.Utc).AddTicks(3088), new DateTime(2024, 8, 18, 0, 25, 40, 96, DateTimeKind.Utc).AddTicks(3089), new DateTime(2024, 8, 18, 4, 25, 40, 96, DateTimeKind.Local).AddTicks(3085) });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: 2034,
                columns: new[] { "About", "Address", "City", "ConcurrencyStamp", "CreatedTime", "LastUpdatedTime", "RefreshTokenCreateTime" },
                values: new object[] { "Somme about text for something bla bla bla", "Koroglu Rahimov 70", "Baku", "bfeddb1b-e63a-43ec-adfe-e7aa0fc98a7b", new DateTime(2024, 8, 18, 0, 25, 40, 96, DateTimeKind.Utc).AddTicks(3103), new DateTime(2024, 8, 18, 0, 25, 40, 96, DateTimeKind.Utc).AddTicks(3103), new DateTime(2024, 8, 18, 4, 25, 40, 96, DateTimeKind.Local).AddTicks(3099) });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: 2035,
                columns: new[] { "About", "Address", "City", "ConcurrencyStamp", "CreatedTime", "LastUpdatedTime", "RefreshTokenCreateTime" },
                values: new object[] { "Somme about text for something bla bla bla", "Koroglu Rahimov 70", "Baku", "16002133-de13-4310-947a-4a4b94778b77", new DateTime(2024, 8, 18, 0, 25, 40, 96, DateTimeKind.Utc).AddTicks(3118), new DateTime(2024, 8, 18, 0, 25, 40, 96, DateTimeKind.Utc).AddTicks(3119), new DateTime(2024, 8, 18, 4, 25, 40, 96, DateTimeKind.Local).AddTicks(3112) });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: 2036,
                columns: new[] { "About", "Address", "City", "ConcurrencyStamp", "CreatedTime", "LastUpdatedTime", "RefreshTokenCreateTime" },
                values: new object[] { "Somme about text for something bla bla bla", "Koroglu Rahimov 70", "Baku", "71829f47-d0cf-4006-9f8e-b48371fac0fe", new DateTime(2024, 8, 18, 0, 25, 40, 96, DateTimeKind.Utc).AddTicks(3166), new DateTime(2024, 8, 18, 0, 25, 40, 96, DateTimeKind.Utc).AddTicks(3166), new DateTime(2024, 8, 18, 4, 25, 40, 96, DateTimeKind.Local).AddTicks(3162) });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: 2037,
                columns: new[] { "About", "Address", "City", "ConcurrencyStamp", "CreatedTime", "LastUpdatedTime", "RefreshTokenCreateTime" },
                values: new object[] { "Somme about text for something bla bla bla", "Koroglu Rahimov 70", "Baku", "f5e12d55-1b7f-4ff5-8c7e-6e76acd4f99f", new DateTime(2024, 8, 18, 0, 25, 40, 96, DateTimeKind.Utc).AddTicks(3179), new DateTime(2024, 8, 18, 0, 25, 40, 96, DateTimeKind.Utc).AddTicks(3180), new DateTime(2024, 8, 18, 4, 25, 40, 96, DateTimeKind.Local).AddTicks(3175) });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: 2038,
                columns: new[] { "About", "Address", "City", "ConcurrencyStamp", "CreatedTime", "LastUpdatedTime", "RefreshTokenCreateTime" },
                values: new object[] { "Somme about text for something bla bla bla", "Koroglu Rahimov 70", "Baku", "f0887ac2-91ce-4c3e-8096-f18a8cc48d2b", new DateTime(2024, 8, 18, 0, 25, 40, 96, DateTimeKind.Utc).AddTicks(3192), new DateTime(2024, 8, 18, 0, 25, 40, 96, DateTimeKind.Utc).AddTicks(3192), new DateTime(2024, 8, 18, 4, 25, 40, 96, DateTimeKind.Local).AddTicks(3188) });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: 2039,
                columns: new[] { "About", "Address", "City", "ConcurrencyStamp", "CreatedTime", "LastUpdatedTime", "RefreshTokenCreateTime" },
                values: new object[] { "Somme about text for something bla bla bla", "Koroglu Rahimov 70", "Baku", "296c0f50-6aba-40b3-9cdb-874483a21ee6", new DateTime(2024, 8, 18, 0, 25, 40, 96, DateTimeKind.Utc).AddTicks(3203), new DateTime(2024, 8, 18, 0, 25, 40, 96, DateTimeKind.Utc).AddTicks(3204), new DateTime(2024, 8, 18, 4, 25, 40, 96, DateTimeKind.Local).AddTicks(3200) });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: 2040,
                columns: new[] { "About", "Address", "City", "ConcurrencyStamp", "CreatedTime", "LastUpdatedTime", "RefreshTokenCreateTime" },
                values: new object[] { "Somme about text for something bla bla bla", "Koroglu Rahimov 70", "Baku", "94f51f11-8cda-4ab7-b196-081e744bd097", new DateTime(2024, 8, 18, 0, 25, 40, 96, DateTimeKind.Utc).AddTicks(3216), new DateTime(2024, 8, 18, 0, 25, 40, 96, DateTimeKind.Utc).AddTicks(3216), new DateTime(2024, 8, 18, 4, 25, 40, 96, DateTimeKind.Local).AddTicks(3212) });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: 2041,
                columns: new[] { "About", "Address", "City", "ConcurrencyStamp", "CreatedTime", "LastUpdatedTime", "RefreshTokenCreateTime" },
                values: new object[] { "Somme about text for something bla bla bla", "Koroglu Rahimov 70", "Baku", "85be156c-6a46-42c1-9f1c-1d64dc8f2ffe", new DateTime(2024, 8, 18, 0, 25, 40, 96, DateTimeKind.Utc).AddTicks(3228), new DateTime(2024, 8, 18, 0, 25, 40, 96, DateTimeKind.Utc).AddTicks(3228), new DateTime(2024, 8, 18, 4, 25, 40, 96, DateTimeKind.Local).AddTicks(3224) });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: 2042,
                columns: new[] { "About", "Address", "City", "ConcurrencyStamp", "CreatedTime", "LastUpdatedTime", "RefreshTokenCreateTime" },
                values: new object[] { "Somme about text for something bla bla bla", "Koroglu Rahimov 70", "Baku", "22bcf165-6450-4ded-8d52-1e300bb2fe48", new DateTime(2024, 8, 18, 0, 25, 40, 96, DateTimeKind.Utc).AddTicks(3246), new DateTime(2024, 8, 18, 0, 25, 40, 96, DateTimeKind.Utc).AddTicks(3246), new DateTime(2024, 8, 18, 4, 25, 40, 96, DateTimeKind.Local).AddTicks(3242) });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: 2043,
                columns: new[] { "About", "Address", "City", "ConcurrencyStamp", "CreatedTime", "LastUpdatedTime", "RefreshTokenCreateTime" },
                values: new object[] { "Somme about text for something bla bla bla", "Koroglu Rahimov 70", "Baku", "f47aa250-c464-418a-a0ca-582998c0e5ff", new DateTime(2024, 8, 18, 0, 25, 40, 96, DateTimeKind.Utc).AddTicks(3261), new DateTime(2024, 8, 18, 0, 25, 40, 96, DateTimeKind.Utc).AddTicks(3261), new DateTime(2024, 8, 18, 4, 25, 40, 96, DateTimeKind.Local).AddTicks(3255) });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: 2044,
                columns: new[] { "About", "Address", "City", "ConcurrencyStamp", "CreatedTime", "LastUpdatedTime", "RefreshTokenCreateTime" },
                values: new object[] { "Somme about text for something bla bla bla", "Koroglu Rahimov 70", "Baku", "e0e9efb4-8772-4fe0-8f3a-5067db50bc7c", new DateTime(2024, 8, 18, 0, 25, 40, 96, DateTimeKind.Utc).AddTicks(3274), new DateTime(2024, 8, 18, 0, 25, 40, 96, DateTimeKind.Utc).AddTicks(3274), new DateTime(2024, 8, 18, 4, 25, 40, 96, DateTimeKind.Local).AddTicks(3270) });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: 2045,
                columns: new[] { "About", "Address", "City", "ConcurrencyStamp", "CreatedTime", "LastUpdatedTime", "RefreshTokenCreateTime" },
                values: new object[] { "Somme about text for something bla bla bla", "Koroglu Rahimov 70", "Baku", "4d13da6c-bfc3-4c1c-affb-aff25d69cda8", new DateTime(2024, 8, 18, 0, 25, 40, 96, DateTimeKind.Utc).AddTicks(3319), new DateTime(2024, 8, 18, 0, 25, 40, 96, DateTimeKind.Utc).AddTicks(3320), new DateTime(2024, 8, 18, 4, 25, 40, 96, DateTimeKind.Local).AddTicks(3282) });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: 2046,
                columns: new[] { "About", "Address", "City", "ConcurrencyStamp", "CreatedTime", "LastUpdatedTime", "RefreshTokenCreateTime" },
                values: new object[] { "Somme about text for something bla bla bla", "Koroglu Rahimov 70", "Baku", "402264df-d5e9-4b84-a6eb-aad157830a77", new DateTime(2024, 8, 18, 0, 25, 40, 96, DateTimeKind.Utc).AddTicks(3333), new DateTime(2024, 8, 18, 0, 25, 40, 96, DateTimeKind.Utc).AddTicks(3333), new DateTime(2024, 8, 18, 4, 25, 40, 96, DateTimeKind.Local).AddTicks(3329) });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: 2047,
                columns: new[] { "About", "Address", "City", "ConcurrencyStamp", "CreatedTime", "LastUpdatedTime", "RefreshTokenCreateTime" },
                values: new object[] { "Somme about text for something bla bla bla", "Koroglu Rahimov 70", "Baku", "eb021033-cce1-4cdd-8bd5-6972bd012025", new DateTime(2024, 8, 18, 0, 25, 40, 96, DateTimeKind.Utc).AddTicks(3345), new DateTime(2024, 8, 18, 0, 25, 40, 96, DateTimeKind.Utc).AddTicks(3345), new DateTime(2024, 8, 18, 4, 25, 40, 96, DateTimeKind.Local).AddTicks(3341) });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: 2048,
                columns: new[] { "About", "Address", "City", "ConcurrencyStamp", "CreatedTime", "LastUpdatedTime", "RefreshTokenCreateTime" },
                values: new object[] { "Somme about text for something bla bla bla", "Koroglu Rahimov 70", "Baku", "5f66ddb4-b9c3-4780-8db7-b811989e56ae", new DateTime(2024, 8, 18, 0, 25, 40, 96, DateTimeKind.Utc).AddTicks(3357), new DateTime(2024, 8, 18, 0, 25, 40, 96, DateTimeKind.Utc).AddTicks(3357), new DateTime(2024, 8, 18, 4, 25, 40, 96, DateTimeKind.Local).AddTicks(3354) });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: 2049,
                columns: new[] { "About", "Address", "City", "ConcurrencyStamp", "CreatedTime", "LastUpdatedTime", "RefreshTokenCreateTime" },
                values: new object[] { "Somme about text for something bla bla bla", "Koroglu Rahimov 70", "Baku", "01373bfb-d8ac-43a5-9d2c-183ceb9cf00a", new DateTime(2024, 8, 18, 0, 25, 40, 96, DateTimeKind.Utc).AddTicks(3369), new DateTime(2024, 8, 18, 0, 25, 40, 96, DateTimeKind.Utc).AddTicks(3369), new DateTime(2024, 8, 18, 4, 25, 40, 96, DateTimeKind.Local).AddTicks(3365) });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: 2050,
                columns: new[] { "About", "Address", "City", "ConcurrencyStamp", "CreatedTime", "LastUpdatedTime", "RefreshTokenCreateTime" },
                values: new object[] { "Somme about text for something bla bla bla", "Koroglu Rahimov 70", "Baku", "ccd887b5-fa60-4ee3-a15e-e3aa5a6cc013", new DateTime(2024, 8, 18, 0, 25, 40, 96, DateTimeKind.Utc).AddTicks(3381), new DateTime(2024, 8, 18, 0, 25, 40, 96, DateTimeKind.Utc).AddTicks(3381), new DateTime(2024, 8, 18, 4, 25, 40, 96, DateTimeKind.Local).AddTicks(3377) });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: 2051,
                columns: new[] { "About", "Address", "City", "ConcurrencyStamp", "CreatedTime", "LastUpdatedTime", "RefreshTokenCreateTime" },
                values: new object[] { "Somme about text for something bla bla bla", "Koroglu Rahimov 70", "Baku", "02aef52c-374f-40d8-bec5-b949bfc31d6f", new DateTime(2024, 8, 18, 0, 25, 40, 96, DateTimeKind.Utc).AddTicks(3396), new DateTime(2024, 8, 18, 0, 25, 40, 96, DateTimeKind.Utc).AddTicks(3396), new DateTime(2024, 8, 18, 4, 25, 40, 96, DateTimeKind.Local).AddTicks(3390) });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: 2052,
                columns: new[] { "About", "Address", "City", "ConcurrencyStamp", "CreatedTime", "LastUpdatedTime", "RefreshTokenCreateTime" },
                values: new object[] { "Somme about text for something bla bla bla", "Koroglu Rahimov 70", "Baku", "62b5d533-768b-4a9b-ae84-c557f6e8ff9a", new DateTime(2024, 8, 18, 0, 25, 40, 96, DateTimeKind.Utc).AddTicks(3408), new DateTime(2024, 8, 18, 0, 25, 40, 96, DateTimeKind.Utc).AddTicks(3409), new DateTime(2024, 8, 18, 4, 25, 40, 96, DateTimeKind.Local).AddTicks(3405) });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: 2053,
                columns: new[] { "About", "Address", "City", "ConcurrencyStamp", "CreatedTime", "LastUpdatedTime", "RefreshTokenCreateTime" },
                values: new object[] { "Somme about text for something bla bla bla", "Koroglu Rahimov 70", "Baku", "c5f97c66-2780-4d4f-b7a9-145b70357b2f", new DateTime(2024, 8, 18, 0, 25, 40, 96, DateTimeKind.Utc).AddTicks(3421), new DateTime(2024, 8, 18, 0, 25, 40, 96, DateTimeKind.Utc).AddTicks(3421), new DateTime(2024, 8, 18, 4, 25, 40, 96, DateTimeKind.Local).AddTicks(3417) });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: 2054,
                columns: new[] { "About", "Address", "City", "ConcurrencyStamp", "CreatedTime", "LastUpdatedTime", "RefreshTokenCreateTime" },
                values: new object[] { "Somme about text for something bla bla bla", "Koroglu Rahimov 70", "Baku", "c4d0373f-3e31-4f8a-a8d3-65dd4b795059", new DateTime(2024, 8, 18, 0, 25, 40, 96, DateTimeKind.Utc).AddTicks(3433), new DateTime(2024, 8, 18, 0, 25, 40, 96, DateTimeKind.Utc).AddTicks(3433), new DateTime(2024, 8, 18, 4, 25, 40, 96, DateTimeKind.Local).AddTicks(3429) });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: 2055,
                columns: new[] { "About", "Address", "City", "ConcurrencyStamp", "CreatedTime", "LastUpdatedTime", "RefreshTokenCreateTime" },
                values: new object[] { "Somme about text for something bla bla bla", "Koroglu Rahimov 70", "Baku", "a504fe68-83ef-435e-bbf1-f51ffd5978b7", new DateTime(2024, 8, 18, 0, 25, 40, 96, DateTimeKind.Utc).AddTicks(3475), new DateTime(2024, 8, 18, 0, 25, 40, 96, DateTimeKind.Utc).AddTicks(3475), new DateTime(2024, 8, 18, 4, 25, 40, 96, DateTimeKind.Local).AddTicks(3441) });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: 2056,
                columns: new[] { "About", "Address", "City", "ConcurrencyStamp", "CreatedTime", "LastUpdatedTime", "RefreshTokenCreateTime" },
                values: new object[] { "Somme about text for something bla bla bla", "Koroglu Rahimov 70", "Baku", "a1619b9a-2473-4970-a46d-4861951abea8", new DateTime(2024, 8, 18, 0, 25, 40, 96, DateTimeKind.Utc).AddTicks(3488), new DateTime(2024, 8, 18, 0, 25, 40, 96, DateTimeKind.Utc).AddTicks(3489), new DateTime(2024, 8, 18, 4, 25, 40, 96, DateTimeKind.Local).AddTicks(3485) });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: 2057,
                columns: new[] { "About", "Address", "City", "ConcurrencyStamp", "CreatedTime", "LastUpdatedTime", "RefreshTokenCreateTime" },
                values: new object[] { "Somme about text for something bla bla bla", "Koroglu Rahimov 70", "Baku", "9ec34e8c-07b5-485f-98f1-0de7e1975bca", new DateTime(2024, 8, 18, 0, 25, 40, 96, DateTimeKind.Utc).AddTicks(3500), new DateTime(2024, 8, 18, 0, 25, 40, 96, DateTimeKind.Utc).AddTicks(3501), new DateTime(2024, 8, 18, 4, 25, 40, 96, DateTimeKind.Local).AddTicks(3497) });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: 2058,
                columns: new[] { "About", "Address", "City", "ConcurrencyStamp", "CreatedTime", "LastUpdatedTime", "RefreshTokenCreateTime" },
                values: new object[] { "Somme about text for something bla bla bla", "Koroglu Rahimov 70", "Baku", "e2ff2e22-592c-479f-845e-a753dea9e9a8", new DateTime(2024, 8, 18, 0, 25, 40, 96, DateTimeKind.Utc).AddTicks(3512), new DateTime(2024, 8, 18, 0, 25, 40, 96, DateTimeKind.Utc).AddTicks(3512), new DateTime(2024, 8, 18, 4, 25, 40, 96, DateTimeKind.Local).AddTicks(3509) });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: 2059,
                columns: new[] { "About", "Address", "City", "ConcurrencyStamp", "CreatedTime", "LastUpdatedTime", "RefreshTokenCreateTime" },
                values: new object[] { "Somme about text for something bla bla bla", "Koroglu Rahimov 70", "Baku", "7f490d7f-6929-44a8-a75f-104e750f9050", new DateTime(2024, 8, 18, 0, 25, 40, 96, DateTimeKind.Utc).AddTicks(3527), new DateTime(2024, 8, 18, 0, 25, 40, 96, DateTimeKind.Utc).AddTicks(3527), new DateTime(2024, 8, 18, 4, 25, 40, 96, DateTimeKind.Local).AddTicks(3521) });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: 2060,
                columns: new[] { "About", "Address", "City", "ConcurrencyStamp", "CreatedTime", "LastUpdatedTime", "RefreshTokenCreateTime" },
                values: new object[] { "Somme about text for something bla bla bla", "Koroglu Rahimov 70", "Baku", "6b4bf58a-e68f-4f55-983a-0f3a9d2a0fd6", new DateTime(2024, 8, 18, 0, 25, 40, 96, DateTimeKind.Utc).AddTicks(3539), new DateTime(2024, 8, 18, 0, 25, 40, 96, DateTimeKind.Utc).AddTicks(3540), new DateTime(2024, 8, 18, 4, 25, 40, 96, DateTimeKind.Local).AddTicks(3536) });

            migrationBuilder.UpdateData(
                table: "Breeds",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedTime",
                value: new DateTime(2024, 8, 18, 4, 25, 40, 87, DateTimeKind.Local).AddTicks(5141));

            migrationBuilder.UpdateData(
                table: "Breeds",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreatedTime",
                value: new DateTime(2024, 8, 18, 4, 25, 40, 87, DateTimeKind.Local).AddTicks(5149));

            migrationBuilder.UpdateData(
                table: "Breeds",
                keyColumn: "Id",
                keyValue: 3,
                column: "CreatedTime",
                value: new DateTime(2024, 8, 18, 4, 25, 40, 87, DateTimeKind.Local).AddTicks(5150));

            migrationBuilder.UpdateData(
                table: "Breeds",
                keyColumn: "Id",
                keyValue: 4,
                column: "CreatedTime",
                value: new DateTime(2024, 8, 18, 4, 25, 40, 87, DateTimeKind.Local).AddTicks(5152));

            migrationBuilder.UpdateData(
                table: "Breeds",
                keyColumn: "Id",
                keyValue: 5,
                column: "CreatedTime",
                value: new DateTime(2024, 8, 18, 4, 25, 40, 87, DateTimeKind.Local).AddTicks(5153));

            migrationBuilder.UpdateData(
                table: "Breeds",
                keyColumn: "Id",
                keyValue: 6,
                column: "CreatedTime",
                value: new DateTime(2024, 8, 18, 4, 25, 40, 87, DateTimeKind.Local).AddTicks(5155));

            migrationBuilder.UpdateData(
                table: "Breeds",
                keyColumn: "Id",
                keyValue: 7,
                column: "CreatedTime",
                value: new DateTime(2024, 8, 18, 4, 25, 40, 87, DateTimeKind.Local).AddTicks(5156));

            migrationBuilder.UpdateData(
                table: "Breeds",
                keyColumn: "Id",
                keyValue: 8,
                column: "CreatedTime",
                value: new DateTime(2024, 8, 18, 4, 25, 40, 87, DateTimeKind.Local).AddTicks(5158));

            migrationBuilder.UpdateData(
                table: "Breeds",
                keyColumn: "Id",
                keyValue: 9,
                column: "CreatedTime",
                value: new DateTime(2024, 8, 18, 4, 25, 40, 87, DateTimeKind.Local).AddTicks(5159));

            migrationBuilder.UpdateData(
                table: "Breeds",
                keyColumn: "Id",
                keyValue: 10,
                column: "CreatedTime",
                value: new DateTime(2024, 8, 18, 4, 25, 40, 87, DateTimeKind.Local).AddTicks(5161));

            migrationBuilder.UpdateData(
                table: "Breeds",
                keyColumn: "Id",
                keyValue: 11,
                column: "CreatedTime",
                value: new DateTime(2024, 8, 18, 4, 25, 40, 87, DateTimeKind.Local).AddTicks(5162));

            migrationBuilder.UpdateData(
                table: "Breeds",
                keyColumn: "Id",
                keyValue: 12,
                column: "CreatedTime",
                value: new DateTime(2024, 8, 18, 4, 25, 40, 87, DateTimeKind.Local).AddTicks(5163));

            migrationBuilder.UpdateData(
                table: "Breeds",
                keyColumn: "Id",
                keyValue: 13,
                column: "CreatedTime",
                value: new DateTime(2024, 8, 18, 4, 25, 40, 87, DateTimeKind.Local).AddTicks(5165));

            migrationBuilder.UpdateData(
                table: "Breeds",
                keyColumn: "Id",
                keyValue: 14,
                column: "CreatedTime",
                value: new DateTime(2024, 8, 18, 4, 25, 40, 87, DateTimeKind.Local).AddTicks(5166));

            migrationBuilder.UpdateData(
                table: "Breeds",
                keyColumn: "Id",
                keyValue: 15,
                column: "CreatedTime",
                value: new DateTime(2024, 8, 18, 4, 25, 40, 87, DateTimeKind.Local).AddTicks(5168));

            migrationBuilder.UpdateData(
                table: "Breeds",
                keyColumn: "Id",
                keyValue: 16,
                column: "CreatedTime",
                value: new DateTime(2024, 8, 18, 4, 25, 40, 87, DateTimeKind.Local).AddTicks(5212));

            migrationBuilder.UpdateData(
                table: "Breeds",
                keyColumn: "Id",
                keyValue: 17,
                column: "CreatedTime",
                value: new DateTime(2024, 8, 18, 4, 25, 40, 87, DateTimeKind.Local).AddTicks(5214));

            migrationBuilder.UpdateData(
                table: "Breeds",
                keyColumn: "Id",
                keyValue: 18,
                column: "CreatedTime",
                value: new DateTime(2024, 8, 18, 4, 25, 40, 87, DateTimeKind.Local).AddTicks(5215));

            migrationBuilder.UpdateData(
                table: "Breeds",
                keyColumn: "Id",
                keyValue: 19,
                column: "CreatedTime",
                value: new DateTime(2024, 8, 18, 4, 25, 40, 87, DateTimeKind.Local).AddTicks(5217));

            migrationBuilder.UpdateData(
                table: "Breeds",
                keyColumn: "Id",
                keyValue: 20,
                column: "CreatedTime",
                value: new DateTime(2024, 8, 18, 4, 25, 40, 87, DateTimeKind.Local).AddTicks(5218));

            migrationBuilder.UpdateData(
                table: "Breeds",
                keyColumn: "Id",
                keyValue: 21,
                column: "CreatedTime",
                value: new DateTime(2024, 8, 18, 4, 25, 40, 87, DateTimeKind.Local).AddTicks(5219));

            migrationBuilder.UpdateData(
                table: "Breeds",
                keyColumn: "Id",
                keyValue: 22,
                column: "CreatedTime",
                value: new DateTime(2024, 8, 18, 4, 25, 40, 87, DateTimeKind.Local).AddTicks(5221));

            migrationBuilder.UpdateData(
                table: "Breeds",
                keyColumn: "Id",
                keyValue: 23,
                column: "CreatedTime",
                value: new DateTime(2024, 8, 18, 4, 25, 40, 87, DateTimeKind.Local).AddTicks(5222));

            migrationBuilder.UpdateData(
                table: "Breeds",
                keyColumn: "Id",
                keyValue: 24,
                column: "CreatedTime",
                value: new DateTime(2024, 8, 18, 4, 25, 40, 87, DateTimeKind.Local).AddTicks(5224));

            migrationBuilder.UpdateData(
                table: "Breeds",
                keyColumn: "Id",
                keyValue: 25,
                column: "CreatedTime",
                value: new DateTime(2024, 8, 18, 4, 25, 40, 87, DateTimeKind.Local).AddTicks(5225));

            migrationBuilder.UpdateData(
                table: "Breeds",
                keyColumn: "Id",
                keyValue: 26,
                column: "CreatedTime",
                value: new DateTime(2024, 8, 18, 4, 25, 40, 87, DateTimeKind.Local).AddTicks(5226));

            migrationBuilder.UpdateData(
                table: "Breeds",
                keyColumn: "Id",
                keyValue: 27,
                column: "CreatedTime",
                value: new DateTime(2024, 8, 18, 4, 25, 40, 87, DateTimeKind.Local).AddTicks(5228));

            migrationBuilder.UpdateData(
                table: "Breeds",
                keyColumn: "Id",
                keyValue: 28,
                column: "CreatedTime",
                value: new DateTime(2024, 8, 18, 4, 25, 40, 87, DateTimeKind.Local).AddTicks(5229));

            migrationBuilder.UpdateData(
                table: "Breeds",
                keyColumn: "Id",
                keyValue: 29,
                column: "CreatedTime",
                value: new DateTime(2024, 8, 18, 4, 25, 40, 87, DateTimeKind.Local).AddTicks(5231));

            migrationBuilder.UpdateData(
                table: "Breeds",
                keyColumn: "Id",
                keyValue: 30,
                column: "CreatedTime",
                value: new DateTime(2024, 8, 18, 4, 25, 40, 87, DateTimeKind.Local).AddTicks(5232));

            migrationBuilder.UpdateData(
                table: "Breeds",
                keyColumn: "Id",
                keyValue: 31,
                column: "CreatedTime",
                value: new DateTime(2024, 8, 18, 4, 25, 40, 87, DateTimeKind.Local).AddTicks(5234));

            migrationBuilder.UpdateData(
                table: "Breeds",
                keyColumn: "Id",
                keyValue: 32,
                column: "CreatedTime",
                value: new DateTime(2024, 8, 18, 4, 25, 40, 87, DateTimeKind.Local).AddTicks(5235));

            migrationBuilder.UpdateData(
                table: "Breeds",
                keyColumn: "Id",
                keyValue: 33,
                column: "CreatedTime",
                value: new DateTime(2024, 8, 18, 4, 25, 40, 87, DateTimeKind.Local).AddTicks(5237));

            migrationBuilder.UpdateData(
                table: "Breeds",
                keyColumn: "Id",
                keyValue: 34,
                column: "CreatedTime",
                value: new DateTime(2024, 8, 18, 4, 25, 40, 87, DateTimeKind.Local).AddTicks(5238));

            migrationBuilder.UpdateData(
                table: "Breeds",
                keyColumn: "Id",
                keyValue: 35,
                column: "CreatedTime",
                value: new DateTime(2024, 8, 18, 4, 25, 40, 87, DateTimeKind.Local).AddTicks(5239));

            migrationBuilder.UpdateData(
                table: "Breeds",
                keyColumn: "Id",
                keyValue: 36,
                column: "CreatedTime",
                value: new DateTime(2024, 8, 18, 4, 25, 40, 87, DateTimeKind.Local).AddTicks(5241));

            migrationBuilder.UpdateData(
                table: "Breeds",
                keyColumn: "Id",
                keyValue: 37,
                column: "CreatedTime",
                value: new DateTime(2024, 8, 18, 4, 25, 40, 87, DateTimeKind.Local).AddTicks(5242));

            migrationBuilder.UpdateData(
                table: "Breeds",
                keyColumn: "Id",
                keyValue: 38,
                column: "CreatedTime",
                value: new DateTime(2024, 8, 18, 4, 25, 40, 87, DateTimeKind.Local).AddTicks(5244));

            migrationBuilder.UpdateData(
                table: "Breeds",
                keyColumn: "Id",
                keyValue: 39,
                column: "CreatedTime",
                value: new DateTime(2024, 8, 18, 4, 25, 40, 87, DateTimeKind.Local).AddTicks(5245));

            migrationBuilder.UpdateData(
                table: "Breeds",
                keyColumn: "Id",
                keyValue: 40,
                column: "CreatedTime",
                value: new DateTime(2024, 8, 18, 4, 25, 40, 87, DateTimeKind.Local).AddTicks(5247));

            migrationBuilder.UpdateData(
                table: "Breeds",
                keyColumn: "Id",
                keyValue: 41,
                column: "CreatedTime",
                value: new DateTime(2024, 8, 18, 4, 25, 40, 87, DateTimeKind.Local).AddTicks(5248));

            migrationBuilder.UpdateData(
                table: "Breeds",
                keyColumn: "Id",
                keyValue: 42,
                column: "CreatedTime",
                value: new DateTime(2024, 8, 18, 4, 25, 40, 87, DateTimeKind.Local).AddTicks(5250));

            migrationBuilder.UpdateData(
                table: "Breeds",
                keyColumn: "Id",
                keyValue: 43,
                column: "CreatedTime",
                value: new DateTime(2024, 8, 18, 4, 25, 40, 87, DateTimeKind.Local).AddTicks(5251));

            migrationBuilder.UpdateData(
                table: "Breeds",
                keyColumn: "Id",
                keyValue: 44,
                column: "CreatedTime",
                value: new DateTime(2024, 8, 18, 4, 25, 40, 87, DateTimeKind.Local).AddTicks(5252));

            migrationBuilder.UpdateData(
                table: "Breeds",
                keyColumn: "Id",
                keyValue: 45,
                column: "CreatedTime",
                value: new DateTime(2024, 8, 18, 4, 25, 40, 87, DateTimeKind.Local).AddTicks(5254));

            migrationBuilder.UpdateData(
                table: "Breeds",
                keyColumn: "Id",
                keyValue: 46,
                column: "CreatedTime",
                value: new DateTime(2024, 8, 18, 4, 25, 40, 87, DateTimeKind.Local).AddTicks(5256));

            migrationBuilder.UpdateData(
                table: "Breeds",
                keyColumn: "Id",
                keyValue: 47,
                column: "CreatedTime",
                value: new DateTime(2024, 8, 18, 4, 25, 40, 87, DateTimeKind.Local).AddTicks(5258));

            migrationBuilder.UpdateData(
                table: "Breeds",
                keyColumn: "Id",
                keyValue: 48,
                column: "CreatedTime",
                value: new DateTime(2024, 8, 18, 4, 25, 40, 87, DateTimeKind.Local).AddTicks(5259));

            migrationBuilder.UpdateData(
                table: "Breeds",
                keyColumn: "Id",
                keyValue: 49,
                column: "CreatedTime",
                value: new DateTime(2024, 8, 18, 4, 25, 40, 87, DateTimeKind.Local).AddTicks(5260));

            migrationBuilder.UpdateData(
                table: "Breeds",
                keyColumn: "Id",
                keyValue: 50,
                column: "CreatedTime",
                value: new DateTime(2024, 8, 18, 4, 25, 40, 87, DateTimeKind.Local).AddTicks(5262));

            migrationBuilder.UpdateData(
                table: "Breeds",
                keyColumn: "Id",
                keyValue: 51,
                column: "CreatedTime",
                value: new DateTime(2024, 8, 18, 4, 25, 40, 87, DateTimeKind.Local).AddTicks(5263));

            migrationBuilder.UpdateData(
                table: "Breeds",
                keyColumn: "Id",
                keyValue: 52,
                column: "CreatedTime",
                value: new DateTime(2024, 8, 18, 4, 25, 40, 87, DateTimeKind.Local).AddTicks(5264));

            migrationBuilder.UpdateData(
                table: "Breeds",
                keyColumn: "Id",
                keyValue: 53,
                column: "CreatedTime",
                value: new DateTime(2024, 8, 18, 4, 25, 40, 87, DateTimeKind.Local).AddTicks(5266));

            migrationBuilder.UpdateData(
                table: "Breeds",
                keyColumn: "Id",
                keyValue: 54,
                column: "CreatedTime",
                value: new DateTime(2024, 8, 18, 4, 25, 40, 87, DateTimeKind.Local).AddTicks(5267));

            migrationBuilder.UpdateData(
                table: "Breeds",
                keyColumn: "Id",
                keyValue: 55,
                column: "CreatedTime",
                value: new DateTime(2024, 8, 18, 4, 25, 40, 87, DateTimeKind.Local).AddTicks(5268));

            migrationBuilder.UpdateData(
                table: "Breeds",
                keyColumn: "Id",
                keyValue: 56,
                column: "CreatedTime",
                value: new DateTime(2024, 8, 18, 4, 25, 40, 87, DateTimeKind.Local).AddTicks(5270));

            migrationBuilder.UpdateData(
                table: "Breeds",
                keyColumn: "Id",
                keyValue: 57,
                column: "CreatedTime",
                value: new DateTime(2024, 8, 18, 4, 25, 40, 87, DateTimeKind.Local).AddTicks(5271));

            migrationBuilder.UpdateData(
                table: "Breeds",
                keyColumn: "Id",
                keyValue: 58,
                column: "CreatedTime",
                value: new DateTime(2024, 8, 18, 4, 25, 40, 87, DateTimeKind.Local).AddTicks(5273));

            migrationBuilder.UpdateData(
                table: "Breeds",
                keyColumn: "Id",
                keyValue: 59,
                column: "CreatedTime",
                value: new DateTime(2024, 8, 18, 4, 25, 40, 87, DateTimeKind.Local).AddTicks(5274));

            migrationBuilder.UpdateData(
                table: "Breeds",
                keyColumn: "Id",
                keyValue: 60,
                column: "CreatedTime",
                value: new DateTime(2024, 8, 18, 4, 25, 40, 87, DateTimeKind.Local).AddTicks(5276));

            migrationBuilder.UpdateData(
                table: "Breeds",
                keyColumn: "Id",
                keyValue: 61,
                column: "CreatedTime",
                value: new DateTime(2024, 8, 18, 4, 25, 40, 87, DateTimeKind.Local).AddTicks(5277));

            migrationBuilder.UpdateData(
                table: "Breeds",
                keyColumn: "Id",
                keyValue: 62,
                column: "CreatedTime",
                value: new DateTime(2024, 8, 18, 4, 25, 40, 87, DateTimeKind.Local).AddTicks(5278));

            migrationBuilder.UpdateData(
                table: "Breeds",
                keyColumn: "Id",
                keyValue: 63,
                column: "CreatedTime",
                value: new DateTime(2024, 8, 18, 4, 25, 40, 87, DateTimeKind.Local).AddTicks(5280));

            migrationBuilder.UpdateData(
                table: "Breeds",
                keyColumn: "Id",
                keyValue: 64,
                column: "CreatedTime",
                value: new DateTime(2024, 8, 18, 4, 25, 40, 87, DateTimeKind.Local).AddTicks(5281));

            migrationBuilder.UpdateData(
                table: "Breeds",
                keyColumn: "Id",
                keyValue: 65,
                column: "CreatedTime",
                value: new DateTime(2024, 8, 18, 4, 25, 40, 87, DateTimeKind.Local).AddTicks(5283));

            migrationBuilder.UpdateData(
                table: "Breeds",
                keyColumn: "Id",
                keyValue: 66,
                column: "CreatedTime",
                value: new DateTime(2024, 8, 18, 4, 25, 40, 87, DateTimeKind.Local).AddTicks(5284));

            migrationBuilder.UpdateData(
                table: "Breeds",
                keyColumn: "Id",
                keyValue: 67,
                column: "CreatedTime",
                value: new DateTime(2024, 8, 18, 4, 25, 40, 87, DateTimeKind.Local).AddTicks(5285));

            migrationBuilder.UpdateData(
                table: "Breeds",
                keyColumn: "Id",
                keyValue: 68,
                column: "CreatedTime",
                value: new DateTime(2024, 8, 18, 4, 25, 40, 87, DateTimeKind.Local).AddTicks(5287));

            migrationBuilder.UpdateData(
                table: "Breeds",
                keyColumn: "Id",
                keyValue: 69,
                column: "CreatedTime",
                value: new DateTime(2024, 8, 18, 4, 25, 40, 87, DateTimeKind.Local).AddTicks(5288));

            migrationBuilder.UpdateData(
                table: "Breeds",
                keyColumn: "Id",
                keyValue: 70,
                column: "CreatedTime",
                value: new DateTime(2024, 8, 18, 4, 25, 40, 87, DateTimeKind.Local).AddTicks(5290));

            migrationBuilder.UpdateData(
                table: "Breeds",
                keyColumn: "Id",
                keyValue: 71,
                column: "CreatedTime",
                value: new DateTime(2024, 8, 18, 4, 25, 40, 87, DateTimeKind.Local).AddTicks(5291));

            migrationBuilder.UpdateData(
                table: "Breeds",
                keyColumn: "Id",
                keyValue: 72,
                column: "CreatedTime",
                value: new DateTime(2024, 8, 18, 4, 25, 40, 87, DateTimeKind.Local).AddTicks(5292));

            migrationBuilder.UpdateData(
                table: "Breeds",
                keyColumn: "Id",
                keyValue: 73,
                column: "CreatedTime",
                value: new DateTime(2024, 8, 18, 4, 25, 40, 87, DateTimeKind.Local).AddTicks(5294));

            migrationBuilder.UpdateData(
                table: "Breeds",
                keyColumn: "Id",
                keyValue: 74,
                column: "CreatedTime",
                value: new DateTime(2024, 8, 18, 4, 25, 40, 87, DateTimeKind.Local).AddTicks(5295));

            migrationBuilder.UpdateData(
                table: "Breeds",
                keyColumn: "Id",
                keyValue: 75,
                column: "CreatedTime",
                value: new DateTime(2024, 8, 18, 4, 25, 40, 87, DateTimeKind.Local).AddTicks(5298));

            migrationBuilder.UpdateData(
                table: "Breeds",
                keyColumn: "Id",
                keyValue: 76,
                column: "CreatedTime",
                value: new DateTime(2024, 8, 18, 4, 25, 40, 87, DateTimeKind.Local).AddTicks(5299));

            migrationBuilder.UpdateData(
                table: "Breeds",
                keyColumn: "Id",
                keyValue: 77,
                column: "CreatedTime",
                value: new DateTime(2024, 8, 18, 4, 25, 40, 87, DateTimeKind.Local).AddTicks(5300));

            migrationBuilder.UpdateData(
                table: "Breeds",
                keyColumn: "Id",
                keyValue: 78,
                column: "CreatedTime",
                value: new DateTime(2024, 8, 18, 4, 25, 40, 87, DateTimeKind.Local).AddTicks(5302));

            migrationBuilder.UpdateData(
                table: "Breeds",
                keyColumn: "Id",
                keyValue: 79,
                column: "CreatedTime",
                value: new DateTime(2024, 8, 18, 4, 25, 40, 87, DateTimeKind.Local).AddTicks(5303));

            migrationBuilder.UpdateData(
                table: "Breeds",
                keyColumn: "Id",
                keyValue: 80,
                column: "CreatedTime",
                value: new DateTime(2024, 8, 18, 4, 25, 40, 87, DateTimeKind.Local).AddTicks(5304));

            migrationBuilder.UpdateData(
                table: "Breeds",
                keyColumn: "Id",
                keyValue: 81,
                column: "CreatedTime",
                value: new DateTime(2024, 8, 18, 4, 25, 40, 87, DateTimeKind.Local).AddTicks(5306));

            migrationBuilder.UpdateData(
                table: "Breeds",
                keyColumn: "Id",
                keyValue: 82,
                column: "CreatedTime",
                value: new DateTime(2024, 8, 18, 4, 25, 40, 87, DateTimeKind.Local).AddTicks(5307));

            migrationBuilder.UpdateData(
                table: "Breeds",
                keyColumn: "Id",
                keyValue: 83,
                column: "CreatedTime",
                value: new DateTime(2024, 8, 18, 4, 25, 40, 87, DateTimeKind.Local).AddTicks(5308));

            migrationBuilder.UpdateData(
                table: "Breeds",
                keyColumn: "Id",
                keyValue: 84,
                column: "CreatedTime",
                value: new DateTime(2024, 8, 18, 4, 25, 40, 87, DateTimeKind.Local).AddTicks(5310));

            migrationBuilder.UpdateData(
                table: "Breeds",
                keyColumn: "Id",
                keyValue: 85,
                column: "CreatedTime",
                value: new DateTime(2024, 8, 18, 4, 25, 40, 87, DateTimeKind.Local).AddTicks(5311));

            migrationBuilder.UpdateData(
                table: "Breeds",
                keyColumn: "Id",
                keyValue: 86,
                column: "CreatedTime",
                value: new DateTime(2024, 8, 18, 4, 25, 40, 87, DateTimeKind.Local).AddTicks(5312));

            migrationBuilder.UpdateData(
                table: "Breeds",
                keyColumn: "Id",
                keyValue: 87,
                column: "CreatedTime",
                value: new DateTime(2024, 8, 18, 4, 25, 40, 87, DateTimeKind.Local).AddTicks(5314));

            migrationBuilder.UpdateData(
                table: "Breeds",
                keyColumn: "Id",
                keyValue: 88,
                column: "CreatedTime",
                value: new DateTime(2024, 8, 18, 4, 25, 40, 87, DateTimeKind.Local).AddTicks(5315));

            migrationBuilder.UpdateData(
                table: "Breeds",
                keyColumn: "Id",
                keyValue: 89,
                column: "CreatedTime",
                value: new DateTime(2024, 8, 18, 4, 25, 40, 87, DateTimeKind.Local).AddTicks(5316));

            migrationBuilder.UpdateData(
                table: "Breeds",
                keyColumn: "Id",
                keyValue: 90,
                column: "CreatedTime",
                value: new DateTime(2024, 8, 18, 4, 25, 40, 87, DateTimeKind.Local).AddTicks(5318));

            migrationBuilder.UpdateData(
                table: "Breeds",
                keyColumn: "Id",
                keyValue: 91,
                column: "CreatedTime",
                value: new DateTime(2024, 8, 18, 4, 25, 40, 87, DateTimeKind.Local).AddTicks(5319));

            migrationBuilder.UpdateData(
                table: "Breeds",
                keyColumn: "Id",
                keyValue: 92,
                column: "CreatedTime",
                value: new DateTime(2024, 8, 18, 4, 25, 40, 87, DateTimeKind.Local).AddTicks(5321));

            migrationBuilder.UpdateData(
                table: "Breeds",
                keyColumn: "Id",
                keyValue: 93,
                column: "CreatedTime",
                value: new DateTime(2024, 8, 18, 4, 25, 40, 87, DateTimeKind.Local).AddTicks(5322));

            migrationBuilder.UpdateData(
                table: "Breeds",
                keyColumn: "Id",
                keyValue: 94,
                column: "CreatedTime",
                value: new DateTime(2024, 8, 18, 4, 25, 40, 87, DateTimeKind.Local).AddTicks(5323));

            migrationBuilder.UpdateData(
                table: "Breeds",
                keyColumn: "Id",
                keyValue: 95,
                column: "CreatedTime",
                value: new DateTime(2024, 8, 18, 4, 25, 40, 87, DateTimeKind.Local).AddTicks(5325));

            migrationBuilder.UpdateData(
                table: "Breeds",
                keyColumn: "Id",
                keyValue: 96,
                column: "CreatedTime",
                value: new DateTime(2024, 8, 18, 4, 25, 40, 87, DateTimeKind.Local).AddTicks(5326));

            migrationBuilder.UpdateData(
                table: "Breeds",
                keyColumn: "Id",
                keyValue: 97,
                column: "CreatedTime",
                value: new DateTime(2024, 8, 18, 4, 25, 40, 87, DateTimeKind.Local).AddTicks(5328));

            migrationBuilder.UpdateData(
                table: "Breeds",
                keyColumn: "Id",
                keyValue: 98,
                column: "CreatedTime",
                value: new DateTime(2024, 8, 18, 4, 25, 40, 87, DateTimeKind.Local).AddTicks(5329));

            migrationBuilder.UpdateData(
                table: "Breeds",
                keyColumn: "Id",
                keyValue: 99,
                column: "CreatedTime",
                value: new DateTime(2024, 8, 18, 4, 25, 40, 87, DateTimeKind.Local).AddTicks(5330));

            migrationBuilder.UpdateData(
                table: "Breeds",
                keyColumn: "Id",
                keyValue: 100,
                column: "CreatedTime",
                value: new DateTime(2024, 8, 18, 4, 25, 40, 87, DateTimeKind.Local).AddTicks(5332));

            migrationBuilder.UpdateData(
                table: "Breeds",
                keyColumn: "Id",
                keyValue: 101,
                column: "CreatedTime",
                value: new DateTime(2024, 8, 18, 4, 25, 40, 87, DateTimeKind.Local).AddTicks(5333));

            migrationBuilder.UpdateData(
                table: "Breeds",
                keyColumn: "Id",
                keyValue: 102,
                column: "CreatedTime",
                value: new DateTime(2024, 8, 18, 4, 25, 40, 87, DateTimeKind.Local).AddTicks(5335));

            migrationBuilder.UpdateData(
                table: "Breeds",
                keyColumn: "Id",
                keyValue: 103,
                column: "CreatedTime",
                value: new DateTime(2024, 8, 18, 4, 25, 40, 87, DateTimeKind.Local).AddTicks(5336));

            migrationBuilder.UpdateData(
                table: "Breeds",
                keyColumn: "Id",
                keyValue: 104,
                column: "CreatedTime",
                value: new DateTime(2024, 8, 18, 4, 25, 40, 87, DateTimeKind.Local).AddTicks(5338));

            migrationBuilder.UpdateData(
                table: "Breeds",
                keyColumn: "Id",
                keyValue: 105,
                column: "CreatedTime",
                value: new DateTime(2024, 8, 18, 4, 25, 40, 87, DateTimeKind.Local).AddTicks(5340));

            migrationBuilder.UpdateData(
                table: "Breeds",
                keyColumn: "Id",
                keyValue: 106,
                column: "CreatedTime",
                value: new DateTime(2024, 8, 18, 4, 25, 40, 87, DateTimeKind.Local).AddTicks(5341));

            migrationBuilder.UpdateData(
                table: "Breeds",
                keyColumn: "Id",
                keyValue: 107,
                column: "CreatedTime",
                value: new DateTime(2024, 8, 18, 4, 25, 40, 87, DateTimeKind.Local).AddTicks(5343));

            migrationBuilder.UpdateData(
                table: "Breeds",
                keyColumn: "Id",
                keyValue: 108,
                column: "CreatedTime",
                value: new DateTime(2024, 8, 18, 4, 25, 40, 87, DateTimeKind.Local).AddTicks(5344));

            migrationBuilder.UpdateData(
                table: "Breeds",
                keyColumn: "Id",
                keyValue: 109,
                column: "CreatedTime",
                value: new DateTime(2024, 8, 18, 4, 25, 40, 87, DateTimeKind.Local).AddTicks(5345));

            migrationBuilder.UpdateData(
                table: "Breeds",
                keyColumn: "Id",
                keyValue: 110,
                column: "CreatedTime",
                value: new DateTime(2024, 8, 18, 4, 25, 40, 87, DateTimeKind.Local).AddTicks(5347));

            migrationBuilder.UpdateData(
                table: "Breeds",
                keyColumn: "Id",
                keyValue: 111,
                column: "CreatedTime",
                value: new DateTime(2024, 8, 18, 4, 25, 40, 87, DateTimeKind.Local).AddTicks(5348));

            migrationBuilder.UpdateData(
                table: "Breeds",
                keyColumn: "Id",
                keyValue: 112,
                column: "CreatedTime",
                value: new DateTime(2024, 8, 18, 4, 25, 40, 87, DateTimeKind.Local).AddTicks(5349));

            migrationBuilder.UpdateData(
                table: "Breeds",
                keyColumn: "Id",
                keyValue: 113,
                column: "CreatedTime",
                value: new DateTime(2024, 8, 18, 4, 25, 40, 87, DateTimeKind.Local).AddTicks(5351));

            migrationBuilder.UpdateData(
                table: "Breeds",
                keyColumn: "Id",
                keyValue: 114,
                column: "CreatedTime",
                value: new DateTime(2024, 8, 18, 4, 25, 40, 87, DateTimeKind.Local).AddTicks(5352));

            migrationBuilder.UpdateData(
                table: "Breeds",
                keyColumn: "Id",
                keyValue: 115,
                column: "CreatedTime",
                value: new DateTime(2024, 8, 18, 4, 25, 40, 87, DateTimeKind.Local).AddTicks(5353));

            migrationBuilder.UpdateData(
                table: "Breeds",
                keyColumn: "Id",
                keyValue: 116,
                column: "CreatedTime",
                value: new DateTime(2024, 8, 18, 4, 25, 40, 87, DateTimeKind.Local).AddTicks(5355));

            migrationBuilder.UpdateData(
                table: "Breeds",
                keyColumn: "Id",
                keyValue: 117,
                column: "CreatedTime",
                value: new DateTime(2024, 8, 18, 4, 25, 40, 87, DateTimeKind.Local).AddTicks(5357));

            migrationBuilder.UpdateData(
                table: "Breeds",
                keyColumn: "Id",
                keyValue: 118,
                column: "CreatedTime",
                value: new DateTime(2024, 8, 18, 4, 25, 40, 87, DateTimeKind.Local).AddTicks(5358));

            migrationBuilder.UpdateData(
                table: "Breeds",
                keyColumn: "Id",
                keyValue: 119,
                column: "CreatedTime",
                value: new DateTime(2024, 8, 18, 4, 25, 40, 87, DateTimeKind.Local).AddTicks(5359));

            migrationBuilder.UpdateData(
                table: "Breeds",
                keyColumn: "Id",
                keyValue: 120,
                column: "CreatedTime",
                value: new DateTime(2024, 8, 18, 4, 25, 40, 87, DateTimeKind.Local).AddTicks(5361));

            migrationBuilder.UpdateData(
                table: "Breeds",
                keyColumn: "Id",
                keyValue: 121,
                column: "CreatedTime",
                value: new DateTime(2024, 8, 18, 4, 25, 40, 87, DateTimeKind.Local).AddTicks(5362));

            migrationBuilder.UpdateData(
                table: "Breeds",
                keyColumn: "Id",
                keyValue: 122,
                column: "CreatedTime",
                value: new DateTime(2024, 8, 18, 4, 25, 40, 87, DateTimeKind.Local).AddTicks(5364));

            migrationBuilder.UpdateData(
                table: "Breeds",
                keyColumn: "Id",
                keyValue: 123,
                column: "CreatedTime",
                value: new DateTime(2024, 8, 18, 4, 25, 40, 87, DateTimeKind.Local).AddTicks(5365));

            migrationBuilder.UpdateData(
                table: "Breeds",
                keyColumn: "Id",
                keyValue: 124,
                column: "CreatedTime",
                value: new DateTime(2024, 8, 18, 4, 25, 40, 87, DateTimeKind.Local).AddTicks(5366));

            migrationBuilder.UpdateData(
                table: "Breeds",
                keyColumn: "Id",
                keyValue: 125,
                column: "CreatedTime",
                value: new DateTime(2024, 8, 18, 4, 25, 40, 87, DateTimeKind.Local).AddTicks(5368));

            migrationBuilder.UpdateData(
                table: "Breeds",
                keyColumn: "Id",
                keyValue: 126,
                column: "CreatedTime",
                value: new DateTime(2024, 8, 18, 4, 25, 40, 87, DateTimeKind.Local).AddTicks(5369));

            migrationBuilder.UpdateData(
                table: "Breeds",
                keyColumn: "Id",
                keyValue: 127,
                column: "CreatedTime",
                value: new DateTime(2024, 8, 18, 4, 25, 40, 87, DateTimeKind.Local).AddTicks(5371));

            migrationBuilder.UpdateData(
                table: "Breeds",
                keyColumn: "Id",
                keyValue: 128,
                column: "CreatedTime",
                value: new DateTime(2024, 8, 18, 4, 25, 40, 87, DateTimeKind.Local).AddTicks(5372));

            migrationBuilder.UpdateData(
                table: "Breeds",
                keyColumn: "Id",
                keyValue: 129,
                column: "CreatedTime",
                value: new DateTime(2024, 8, 18, 4, 25, 40, 87, DateTimeKind.Local).AddTicks(5373));

            migrationBuilder.UpdateData(
                table: "Breeds",
                keyColumn: "Id",
                keyValue: 130,
                column: "CreatedTime",
                value: new DateTime(2024, 8, 18, 4, 25, 40, 87, DateTimeKind.Local).AddTicks(5375));

            migrationBuilder.UpdateData(
                table: "Breeds",
                keyColumn: "Id",
                keyValue: 131,
                column: "CreatedTime",
                value: new DateTime(2024, 8, 18, 4, 25, 40, 87, DateTimeKind.Local).AddTicks(5376));

            migrationBuilder.UpdateData(
                table: "Breeds",
                keyColumn: "Id",
                keyValue: 132,
                column: "CreatedTime",
                value: new DateTime(2024, 8, 18, 4, 25, 40, 87, DateTimeKind.Local).AddTicks(5377));

            migrationBuilder.UpdateData(
                table: "Breeds",
                keyColumn: "Id",
                keyValue: 133,
                column: "CreatedTime",
                value: new DateTime(2024, 8, 18, 4, 25, 40, 87, DateTimeKind.Local).AddTicks(5380));

            migrationBuilder.UpdateData(
                table: "Breeds",
                keyColumn: "Id",
                keyValue: 134,
                column: "CreatedTime",
                value: new DateTime(2024, 8, 18, 4, 25, 40, 87, DateTimeKind.Local).AddTicks(5381));

            migrationBuilder.UpdateData(
                table: "Breeds",
                keyColumn: "Id",
                keyValue: 135,
                column: "CreatedTime",
                value: new DateTime(2024, 8, 18, 4, 25, 40, 87, DateTimeKind.Local).AddTicks(5382));

            migrationBuilder.UpdateData(
                table: "Breeds",
                keyColumn: "Id",
                keyValue: 136,
                column: "CreatedTime",
                value: new DateTime(2024, 8, 18, 4, 25, 40, 87, DateTimeKind.Local).AddTicks(5384));

            migrationBuilder.UpdateData(
                table: "Breeds",
                keyColumn: "Id",
                keyValue: 137,
                column: "CreatedTime",
                value: new DateTime(2024, 8, 18, 4, 25, 40, 87, DateTimeKind.Local).AddTicks(5385));

            migrationBuilder.UpdateData(
                table: "Breeds",
                keyColumn: "Id",
                keyValue: 138,
                column: "CreatedTime",
                value: new DateTime(2024, 8, 18, 4, 25, 40, 87, DateTimeKind.Local).AddTicks(5386));

            migrationBuilder.UpdateData(
                table: "Breeds",
                keyColumn: "Id",
                keyValue: 139,
                column: "CreatedTime",
                value: new DateTime(2024, 8, 18, 4, 25, 40, 87, DateTimeKind.Local).AddTicks(5387));

            migrationBuilder.UpdateData(
                table: "Breeds",
                keyColumn: "Id",
                keyValue: 140,
                column: "CreatedTime",
                value: new DateTime(2024, 8, 18, 4, 25, 40, 87, DateTimeKind.Local).AddTicks(5389));

            migrationBuilder.UpdateData(
                table: "Breeds",
                keyColumn: "Id",
                keyValue: 141,
                column: "CreatedTime",
                value: new DateTime(2024, 8, 18, 4, 25, 40, 87, DateTimeKind.Local).AddTicks(5390));

            migrationBuilder.UpdateData(
                table: "Breeds",
                keyColumn: "Id",
                keyValue: 142,
                column: "CreatedTime",
                value: new DateTime(2024, 8, 18, 4, 25, 40, 87, DateTimeKind.Local).AddTicks(5391));

            migrationBuilder.UpdateData(
                table: "Breeds",
                keyColumn: "Id",
                keyValue: 143,
                column: "CreatedTime",
                value: new DateTime(2024, 8, 18, 4, 25, 40, 87, DateTimeKind.Local).AddTicks(5393));

            migrationBuilder.UpdateData(
                table: "Breeds",
                keyColumn: "Id",
                keyValue: 144,
                column: "CreatedTime",
                value: new DateTime(2024, 8, 18, 4, 25, 40, 87, DateTimeKind.Local).AddTicks(5424));

            migrationBuilder.UpdateData(
                table: "Breeds",
                keyColumn: "Id",
                keyValue: 145,
                column: "CreatedTime",
                value: new DateTime(2024, 8, 18, 4, 25, 40, 87, DateTimeKind.Local).AddTicks(5426));

            migrationBuilder.UpdateData(
                table: "Breeds",
                keyColumn: "Id",
                keyValue: 146,
                column: "CreatedTime",
                value: new DateTime(2024, 8, 18, 4, 25, 40, 87, DateTimeKind.Local).AddTicks(5427));

            migrationBuilder.UpdateData(
                table: "Breeds",
                keyColumn: "Id",
                keyValue: 147,
                column: "CreatedTime",
                value: new DateTime(2024, 8, 18, 4, 25, 40, 87, DateTimeKind.Local).AddTicks(5429));

            migrationBuilder.UpdateData(
                table: "Breeds",
                keyColumn: "Id",
                keyValue: 148,
                column: "CreatedTime",
                value: new DateTime(2024, 8, 18, 4, 25, 40, 87, DateTimeKind.Local).AddTicks(5430));

            migrationBuilder.UpdateData(
                table: "Breeds",
                keyColumn: "Id",
                keyValue: 149,
                column: "CreatedTime",
                value: new DateTime(2024, 8, 18, 4, 25, 40, 87, DateTimeKind.Local).AddTicks(5431));

            migrationBuilder.UpdateData(
                table: "Breeds",
                keyColumn: "Id",
                keyValue: 150,
                column: "CreatedTime",
                value: new DateTime(2024, 8, 18, 4, 25, 40, 87, DateTimeKind.Local).AddTicks(5433));

            migrationBuilder.UpdateData(
                table: "Breeds",
                keyColumn: "Id",
                keyValue: 151,
                column: "CreatedTime",
                value: new DateTime(2024, 8, 18, 4, 25, 40, 87, DateTimeKind.Local).AddTicks(5434));

            migrationBuilder.UpdateData(
                table: "Breeds",
                keyColumn: "Id",
                keyValue: 152,
                column: "CreatedTime",
                value: new DateTime(2024, 8, 18, 4, 25, 40, 87, DateTimeKind.Local).AddTicks(5435));

            migrationBuilder.UpdateData(
                table: "Breeds",
                keyColumn: "Id",
                keyValue: 153,
                column: "CreatedTime",
                value: new DateTime(2024, 8, 18, 4, 25, 40, 87, DateTimeKind.Local).AddTicks(5437));

            migrationBuilder.UpdateData(
                table: "Breeds",
                keyColumn: "Id",
                keyValue: 154,
                column: "CreatedTime",
                value: new DateTime(2024, 8, 18, 4, 25, 40, 87, DateTimeKind.Local).AddTicks(5438));

            migrationBuilder.UpdateData(
                table: "Breeds",
                keyColumn: "Id",
                keyValue: 155,
                column: "CreatedTime",
                value: new DateTime(2024, 8, 18, 4, 25, 40, 87, DateTimeKind.Local).AddTicks(5439));

            migrationBuilder.UpdateData(
                table: "Breeds",
                keyColumn: "Id",
                keyValue: 156,
                column: "CreatedTime",
                value: new DateTime(2024, 8, 18, 4, 25, 40, 87, DateTimeKind.Local).AddTicks(5442));

            migrationBuilder.UpdateData(
                table: "Breeds",
                keyColumn: "Id",
                keyValue: 157,
                column: "CreatedTime",
                value: new DateTime(2024, 8, 18, 4, 25, 40, 87, DateTimeKind.Local).AddTicks(5444));

            migrationBuilder.UpdateData(
                table: "Breeds",
                keyColumn: "Id",
                keyValue: 158,
                column: "CreatedTime",
                value: new DateTime(2024, 8, 18, 4, 25, 40, 87, DateTimeKind.Local).AddTicks(5446));

            migrationBuilder.UpdateData(
                table: "Breeds",
                keyColumn: "Id",
                keyValue: 159,
                column: "CreatedTime",
                value: new DateTime(2024, 8, 18, 4, 25, 40, 87, DateTimeKind.Local).AddTicks(5447));

            migrationBuilder.UpdateData(
                table: "Breeds",
                keyColumn: "Id",
                keyValue: 160,
                column: "CreatedTime",
                value: new DateTime(2024, 8, 18, 4, 25, 40, 87, DateTimeKind.Local).AddTicks(5448));

            migrationBuilder.UpdateData(
                table: "PetTypes",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedTime",
                value: new DateTime(2024, 8, 18, 4, 25, 40, 87, DateTimeKind.Local).AddTicks(2601));

            migrationBuilder.UpdateData(
                table: "PetTypes",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreatedTime",
                value: new DateTime(2024, 8, 18, 4, 25, 40, 87, DateTimeKind.Local).AddTicks(2618));

            migrationBuilder.UpdateData(
                table: "PetTypes",
                keyColumn: "Id",
                keyValue: 3,
                column: "CreatedTime",
                value: new DateTime(2024, 8, 18, 4, 25, 40, 87, DateTimeKind.Local).AddTicks(2619));

            migrationBuilder.UpdateData(
                table: "PetTypes",
                keyColumn: "Id",
                keyValue: 4,
                column: "CreatedTime",
                value: new DateTime(2024, 8, 18, 4, 25, 40, 87, DateTimeKind.Local).AddTicks(2621));

            migrationBuilder.UpdateData(
                table: "PetTypes",
                keyColumn: "Id",
                keyValue: 5,
                column: "CreatedTime",
                value: new DateTime(2024, 8, 18, 4, 25, 40, 87, DateTimeKind.Local).AddTicks(2622));

            migrationBuilder.UpdateData(
                table: "PetTypes",
                keyColumn: "Id",
                keyValue: 6,
                column: "CreatedTime",
                value: new DateTime(2024, 8, 18, 4, 25, 40, 87, DateTimeKind.Local).AddTicks(2624));

            migrationBuilder.UpdateData(
                table: "PetTypes",
                keyColumn: "Id",
                keyValue: 7,
                column: "CreatedTime",
                value: new DateTime(2024, 8, 18, 4, 25, 40, 87, DateTimeKind.Local).AddTicks(2625));

            migrationBuilder.UpdateData(
                table: "PetTypes",
                keyColumn: "Id",
                keyValue: 8,
                column: "CreatedTime",
                value: new DateTime(2024, 8, 18, 4, 25, 40, 87, DateTimeKind.Local).AddTicks(2626));
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "AboutShelter",
                table: "Shelters");

            migrationBuilder.DropColumn(
                name: "AdoptionPolicy",
                table: "Shelters");

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: 2001,
                columns: new[] { "About", "Address", "City", "ConcurrencyStamp", "CreatedTime", "LastUpdatedTime", "RefreshTokenCreateTime" },
                values: new object[] { "NULL", "Address1", "City1", "fb2e3252-44dc-4c71-82d8-49768c6d8831", new DateTime(2024, 8, 16, 23, 49, 5, 286, DateTimeKind.Utc).AddTicks(322), new DateTime(2024, 8, 16, 23, 49, 5, 286, DateTimeKind.Utc).AddTicks(323), new DateTime(2024, 8, 17, 3, 49, 5, 286, DateTimeKind.Local).AddTicks(215) });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: 2002,
                columns: new[] { "About", "Address", "City", "ConcurrencyStamp", "CreatedTime", "LastUpdatedTime", "RefreshTokenCreateTime" },
                values: new object[] { "NULL", "Address2", "City2", "1fd55fc2-d194-406b-980d-a8cdda72a70c", new DateTime(2024, 8, 16, 23, 49, 5, 286, DateTimeKind.Utc).AddTicks(356), new DateTime(2024, 8, 16, 23, 49, 5, 286, DateTimeKind.Utc).AddTicks(357), new DateTime(2024, 8, 17, 3, 49, 5, 286, DateTimeKind.Local).AddTicks(349) });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: 2003,
                columns: new[] { "About", "Address", "City", "ConcurrencyStamp", "CreatedTime", "LastUpdatedTime", "RefreshTokenCreateTime" },
                values: new object[] { "NULL", "Address3", "City3", "4384ed0f-3cef-4cc2-b7fa-5309064ba5a2", new DateTime(2024, 8, 16, 23, 49, 5, 286, DateTimeKind.Utc).AddTicks(385), new DateTime(2024, 8, 16, 23, 49, 5, 286, DateTimeKind.Utc).AddTicks(386), new DateTime(2024, 8, 17, 3, 49, 5, 286, DateTimeKind.Local).AddTicks(366) });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: 2004,
                columns: new[] { "About", "Address", "City", "ConcurrencyStamp", "CreatedTime", "LastUpdatedTime", "RefreshTokenCreateTime" },
                values: new object[] { "NULL", "Address4", "City4", "58ddf741-4ab7-4991-8208-b5781b8bbfe4", new DateTime(2024, 8, 16, 23, 49, 5, 286, DateTimeKind.Utc).AddTicks(400), new DateTime(2024, 8, 16, 23, 49, 5, 286, DateTimeKind.Utc).AddTicks(400), new DateTime(2024, 8, 17, 3, 49, 5, 286, DateTimeKind.Local).AddTicks(395) });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: 2005,
                columns: new[] { "About", "Address", "City", "ConcurrencyStamp", "CreatedTime", "LastUpdatedTime", "RefreshTokenCreateTime" },
                values: new object[] { "NULL", "Address5", "City5", "1ab28c71-fdf3-4730-95c7-6fea3e3b6a45", new DateTime(2024, 8, 16, 23, 49, 5, 286, DateTimeKind.Utc).AddTicks(413), new DateTime(2024, 8, 16, 23, 49, 5, 286, DateTimeKind.Utc).AddTicks(413), new DateTime(2024, 8, 17, 3, 49, 5, 286, DateTimeKind.Local).AddTicks(408) });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: 2006,
                columns: new[] { "About", "Address", "City", "ConcurrencyStamp", "CreatedTime", "LastUpdatedTime", "RefreshTokenCreateTime" },
                values: new object[] { "NULL", "Address6", "City6", "abfeb5ac-6ff4-4a2c-962f-a80e6d453aa2", new DateTime(2024, 8, 16, 23, 49, 5, 286, DateTimeKind.Utc).AddTicks(429), new DateTime(2024, 8, 16, 23, 49, 5, 286, DateTimeKind.Utc).AddTicks(430), new DateTime(2024, 8, 17, 3, 49, 5, 286, DateTimeKind.Local).AddTicks(424) });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: 2007,
                columns: new[] { "About", "Address", "City", "ConcurrencyStamp", "CreatedTime", "LastUpdatedTime", "RefreshTokenCreateTime" },
                values: new object[] { "NULL", "Address7", "City7", "6638354b-e840-4b41-8a05-15e4a4a2d69a", new DateTime(2024, 8, 16, 23, 49, 5, 286, DateTimeKind.Utc).AddTicks(442), new DateTime(2024, 8, 16, 23, 49, 5, 286, DateTimeKind.Utc).AddTicks(443), new DateTime(2024, 8, 17, 3, 49, 5, 286, DateTimeKind.Local).AddTicks(437) });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: 2008,
                columns: new[] { "About", "Address", "City", "ConcurrencyStamp", "CreatedTime", "LastUpdatedTime", "RefreshTokenCreateTime" },
                values: new object[] { "NULL", "Address8", "City8", "0c5412b6-8ac6-48d5-89a0-7313cef064f4", new DateTime(2024, 8, 16, 23, 49, 5, 286, DateTimeKind.Utc).AddTicks(500), new DateTime(2024, 8, 16, 23, 49, 5, 286, DateTimeKind.Utc).AddTicks(501), new DateTime(2024, 8, 17, 3, 49, 5, 286, DateTimeKind.Local).AddTicks(450) });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: 2009,
                columns: new[] { "About", "Address", "City", "ConcurrencyStamp", "CreatedTime", "LastUpdatedTime", "RefreshTokenCreateTime" },
                values: new object[] { "NULL", "Address9", "City9", "c3bb1607-5117-48bd-875b-89406d3e5ff7", new DateTime(2024, 8, 16, 23, 49, 5, 286, DateTimeKind.Utc).AddTicks(514), new DateTime(2024, 8, 16, 23, 49, 5, 286, DateTimeKind.Utc).AddTicks(515), new DateTime(2024, 8, 17, 3, 49, 5, 286, DateTimeKind.Local).AddTicks(509) });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: 2010,
                columns: new[] { "About", "Address", "City", "ConcurrencyStamp", "CreatedTime", "LastUpdatedTime", "RefreshTokenCreateTime" },
                values: new object[] { "NULL", "Address10", "City10", "3d8a66e8-b900-4bb6-a425-c6cd7d4aca7b", new DateTime(2024, 8, 16, 23, 49, 5, 286, DateTimeKind.Utc).AddTicks(530), new DateTime(2024, 8, 16, 23, 49, 5, 286, DateTimeKind.Utc).AddTicks(531), new DateTime(2024, 8, 17, 3, 49, 5, 286, DateTimeKind.Local).AddTicks(524) });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: 2011,
                columns: new[] { "About", "Address", "City", "ConcurrencyStamp", "CreatedTime", "LastUpdatedTime", "RefreshTokenCreateTime" },
                values: new object[] { "NULL", "Address11", "City11", "83ba7c9a-c830-4d86-9072-9a22534c8c33", new DateTime(2024, 8, 16, 23, 49, 5, 286, DateTimeKind.Utc).AddTicks(550), new DateTime(2024, 8, 16, 23, 49, 5, 286, DateTimeKind.Utc).AddTicks(551), new DateTime(2024, 8, 17, 3, 49, 5, 286, DateTimeKind.Local).AddTicks(540) });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: 2012,
                columns: new[] { "About", "Address", "City", "ConcurrencyStamp", "CreatedTime", "LastUpdatedTime", "RefreshTokenCreateTime" },
                values: new object[] { "NULL", "Address12", "City12", "6209a90c-aa84-42c7-830d-cce90cac65b6", new DateTime(2024, 8, 16, 23, 49, 5, 286, DateTimeKind.Utc).AddTicks(564), new DateTime(2024, 8, 16, 23, 49, 5, 286, DateTimeKind.Utc).AddTicks(565), new DateTime(2024, 8, 17, 3, 49, 5, 286, DateTimeKind.Local).AddTicks(559) });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: 2013,
                columns: new[] { "About", "Address", "City", "ConcurrencyStamp", "CreatedTime", "LastUpdatedTime", "RefreshTokenCreateTime" },
                values: new object[] { "NULL", "Address13", "City13", "dad9500e-02d9-4c39-b2e6-184a206049f4", new DateTime(2024, 8, 16, 23, 49, 5, 286, DateTimeKind.Utc).AddTicks(577), new DateTime(2024, 8, 16, 23, 49, 5, 286, DateTimeKind.Utc).AddTicks(578), new DateTime(2024, 8, 17, 3, 49, 5, 286, DateTimeKind.Local).AddTicks(572) });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: 2014,
                columns: new[] { "About", "Address", "City", "ConcurrencyStamp", "CreatedTime", "LastUpdatedTime", "RefreshTokenCreateTime" },
                values: new object[] { "NULL", "Address14", "City14", "8c659428-356d-4d8b-9720-1e5ef04695ec", new DateTime(2024, 8, 16, 23, 49, 5, 286, DateTimeKind.Utc).AddTicks(590), new DateTime(2024, 8, 16, 23, 49, 5, 286, DateTimeKind.Utc).AddTicks(590), new DateTime(2024, 8, 17, 3, 49, 5, 286, DateTimeKind.Local).AddTicks(585) });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: 2015,
                columns: new[] { "About", "Address", "City", "ConcurrencyStamp", "CreatedTime", "LastUpdatedTime", "RefreshTokenCreateTime" },
                values: new object[] { "NULL", "Address15", "City15", "3be77fff-906c-4de6-801b-6620f93493ea", new DateTime(2024, 8, 16, 23, 49, 5, 286, DateTimeKind.Utc).AddTicks(604), new DateTime(2024, 8, 16, 23, 49, 5, 286, DateTimeKind.Utc).AddTicks(605), new DateTime(2024, 8, 17, 3, 49, 5, 286, DateTimeKind.Local).AddTicks(599) });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: 2016,
                columns: new[] { "About", "Address", "City", "ConcurrencyStamp", "CreatedTime", "LastUpdatedTime", "RefreshTokenCreateTime" },
                values: new object[] { "NULL", "Address16", "City16", "3f4714fa-0391-4647-ac52-3797edfb7693", new DateTime(2024, 8, 16, 23, 49, 5, 286, DateTimeKind.Utc).AddTicks(617), new DateTime(2024, 8, 16, 23, 49, 5, 286, DateTimeKind.Utc).AddTicks(618), new DateTime(2024, 8, 17, 3, 49, 5, 286, DateTimeKind.Local).AddTicks(612) });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: 2017,
                columns: new[] { "About", "Address", "City", "ConcurrencyStamp", "CreatedTime", "LastUpdatedTime", "RefreshTokenCreateTime" },
                values: new object[] { "NULL", "Address17", "City17", "e2518270-6c23-435e-a0b0-319a9d21c3c2", new DateTime(2024, 8, 16, 23, 49, 5, 286, DateTimeKind.Utc).AddTicks(668), new DateTime(2024, 8, 16, 23, 49, 5, 286, DateTimeKind.Utc).AddTicks(668), new DateTime(2024, 8, 17, 3, 49, 5, 286, DateTimeKind.Local).AddTicks(662) });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: 2018,
                columns: new[] { "About", "Address", "City", "ConcurrencyStamp", "CreatedTime", "LastUpdatedTime", "RefreshTokenCreateTime" },
                values: new object[] { "NULL", "Address18", "City18", "cdc09b82-dca3-47b5-be7f-36dc015af0db", new DateTime(2024, 8, 16, 23, 49, 5, 286, DateTimeKind.Utc).AddTicks(683), new DateTime(2024, 8, 16, 23, 49, 5, 286, DateTimeKind.Utc).AddTicks(684), new DateTime(2024, 8, 17, 3, 49, 5, 286, DateTimeKind.Local).AddTicks(678) });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: 2019,
                columns: new[] { "About", "Address", "City", "ConcurrencyStamp", "CreatedTime", "LastUpdatedTime", "RefreshTokenCreateTime" },
                values: new object[] { "NULL", "Address19", "City19", "561d6276-ee8a-4b00-b3b9-38a3db494b1b", new DateTime(2024, 8, 16, 23, 49, 5, 286, DateTimeKind.Utc).AddTicks(701), new DateTime(2024, 8, 16, 23, 49, 5, 286, DateTimeKind.Utc).AddTicks(701), new DateTime(2024, 8, 17, 3, 49, 5, 286, DateTimeKind.Local).AddTicks(692) });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: 2020,
                columns: new[] { "About", "Address", "City", "ConcurrencyStamp", "CreatedTime", "LastUpdatedTime", "RefreshTokenCreateTime" },
                values: new object[] { "NULL", "Address20", "City20", "ec71e5d2-dbf4-4351-be8f-e56c0930610b", new DateTime(2024, 8, 16, 23, 49, 5, 286, DateTimeKind.Utc).AddTicks(715), new DateTime(2024, 8, 16, 23, 49, 5, 286, DateTimeKind.Utc).AddTicks(715), new DateTime(2024, 8, 17, 3, 49, 5, 286, DateTimeKind.Local).AddTicks(709) });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: 2021,
                columns: new[] { "About", "Address", "City", "ConcurrencyStamp", "CreatedTime", "LastUpdatedTime", "RefreshTokenCreateTime" },
                values: new object[] { "NULL", "Address21", "City21", "484a5565-156f-45ae-99a6-159eec196270", new DateTime(2024, 8, 16, 23, 49, 5, 286, DateTimeKind.Utc).AddTicks(728), new DateTime(2024, 8, 16, 23, 49, 5, 286, DateTimeKind.Utc).AddTicks(729), new DateTime(2024, 8, 17, 3, 49, 5, 286, DateTimeKind.Local).AddTicks(723) });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: 2022,
                columns: new[] { "About", "Address", "City", "ConcurrencyStamp", "CreatedTime", "LastUpdatedTime", "RefreshTokenCreateTime" },
                values: new object[] { "NULL", "Address22", "City22", "5d3175f1-c272-455e-a4d5-52cf26068c3d", new DateTime(2024, 8, 16, 23, 49, 5, 286, DateTimeKind.Utc).AddTicks(747), new DateTime(2024, 8, 16, 23, 49, 5, 286, DateTimeKind.Utc).AddTicks(748), new DateTime(2024, 8, 17, 3, 49, 5, 286, DateTimeKind.Local).AddTicks(742) });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: 2023,
                columns: new[] { "About", "Address", "City", "ConcurrencyStamp", "CreatedTime", "LastUpdatedTime", "RefreshTokenCreateTime" },
                values: new object[] { "NULL", "Address23", "City23", "08600ecc-3b9c-40d3-a8a4-5da72ce35cd1", new DateTime(2024, 8, 16, 23, 49, 5, 286, DateTimeKind.Utc).AddTicks(762), new DateTime(2024, 8, 16, 23, 49, 5, 286, DateTimeKind.Utc).AddTicks(762), new DateTime(2024, 8, 17, 3, 49, 5, 286, DateTimeKind.Local).AddTicks(757) });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: 2024,
                columns: new[] { "About", "Address", "City", "ConcurrencyStamp", "CreatedTime", "LastUpdatedTime", "RefreshTokenCreateTime" },
                values: new object[] { "NULL", "Address24", "City24", "09dee302-c5d9-4466-8bd1-dd91db3ab384", new DateTime(2024, 8, 16, 23, 49, 5, 286, DateTimeKind.Utc).AddTicks(775), new DateTime(2024, 8, 16, 23, 49, 5, 286, DateTimeKind.Utc).AddTicks(775), new DateTime(2024, 8, 17, 3, 49, 5, 286, DateTimeKind.Local).AddTicks(770) });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: 2025,
                columns: new[] { "About", "Address", "City", "ConcurrencyStamp", "CreatedTime", "LastUpdatedTime", "RefreshTokenCreateTime" },
                values: new object[] { "NULL", "Address25", "City25", "c3c2a899-302e-4353-b151-5aae0ad27992", new DateTime(2024, 8, 16, 23, 49, 5, 286, DateTimeKind.Utc).AddTicks(787), new DateTime(2024, 8, 16, 23, 49, 5, 286, DateTimeKind.Utc).AddTicks(788), new DateTime(2024, 8, 17, 3, 49, 5, 286, DateTimeKind.Local).AddTicks(782) });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: 2026,
                columns: new[] { "About", "Address", "City", "ConcurrencyStamp", "CreatedTime", "LastUpdatedTime", "RefreshTokenCreateTime" },
                values: new object[] { "NULL", "Address26", "City26", "66159b02-5617-435c-9896-9764657b2e04", new DateTime(2024, 8, 16, 23, 49, 5, 286, DateTimeKind.Utc).AddTicks(837), new DateTime(2024, 8, 16, 23, 49, 5, 286, DateTimeKind.Utc).AddTicks(837), new DateTime(2024, 8, 17, 3, 49, 5, 286, DateTimeKind.Local).AddTicks(832) });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: 2027,
                columns: new[] { "About", "Address", "City", "ConcurrencyStamp", "CreatedTime", "LastUpdatedTime", "RefreshTokenCreateTime" },
                values: new object[] { "NULL", "Address27", "City27", "38cf7010-c21a-4e0f-a2a0-c11b91503bab", new DateTime(2024, 8, 16, 23, 49, 5, 286, DateTimeKind.Utc).AddTicks(854), new DateTime(2024, 8, 16, 23, 49, 5, 286, DateTimeKind.Utc).AddTicks(855), new DateTime(2024, 8, 17, 3, 49, 5, 286, DateTimeKind.Local).AddTicks(845) });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: 2028,
                columns: new[] { "About", "Address", "City", "ConcurrencyStamp", "CreatedTime", "LastUpdatedTime", "RefreshTokenCreateTime" },
                values: new object[] { "NULL", "Address28", "City28", "f9d98b47-8c64-4d1f-a0cb-1e3bb0e2aeff", new DateTime(2024, 8, 16, 23, 49, 5, 286, DateTimeKind.Utc).AddTicks(1033), new DateTime(2024, 8, 16, 23, 49, 5, 286, DateTimeKind.Utc).AddTicks(1035), new DateTime(2024, 8, 17, 3, 49, 5, 286, DateTimeKind.Local).AddTicks(1016) });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: 2029,
                columns: new[] { "About", "Address", "City", "ConcurrencyStamp", "CreatedTime", "LastUpdatedTime", "RefreshTokenCreateTime" },
                values: new object[] { "NULL", "Address29", "City29", "ef03c792-a597-4d53-867f-460265103477", new DateTime(2024, 8, 16, 23, 49, 5, 286, DateTimeKind.Utc).AddTicks(1072), new DateTime(2024, 8, 16, 23, 49, 5, 286, DateTimeKind.Utc).AddTicks(1073), new DateTime(2024, 8, 17, 3, 49, 5, 286, DateTimeKind.Local).AddTicks(1057) });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: 2030,
                columns: new[] { "About", "Address", "City", "ConcurrencyStamp", "CreatedTime", "LastUpdatedTime", "RefreshTokenCreateTime" },
                values: new object[] { "NULL", "Address30", "City30", "1cc0a0c0-1230-4dd5-9ae3-51912f08a930", new DateTime(2024, 8, 16, 23, 49, 5, 286, DateTimeKind.Utc).AddTicks(1247), new DateTime(2024, 8, 16, 23, 49, 5, 286, DateTimeKind.Utc).AddTicks(1247), new DateTime(2024, 8, 17, 3, 49, 5, 286, DateTimeKind.Local).AddTicks(1241) });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: 2031,
                columns: new[] { "About", "Address", "City", "ConcurrencyStamp", "CreatedTime", "LastUpdatedTime", "RefreshTokenCreateTime" },
                values: new object[] { "NULL", "Address31", "City31", "c4d11013-2e2f-4338-92df-75236be3c66d", new DateTime(2024, 8, 16, 23, 49, 5, 286, DateTimeKind.Utc).AddTicks(1259), new DateTime(2024, 8, 16, 23, 49, 5, 286, DateTimeKind.Utc).AddTicks(1260), new DateTime(2024, 8, 17, 3, 49, 5, 286, DateTimeKind.Local).AddTicks(1254) });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: 2032,
                columns: new[] { "About", "Address", "City", "ConcurrencyStamp", "CreatedTime", "LastUpdatedTime", "RefreshTokenCreateTime" },
                values: new object[] { "NULL", "Address32", "City32", "87d65948-e1b6-4d2d-8050-ba171e3b8f54", new DateTime(2024, 8, 16, 23, 49, 5, 286, DateTimeKind.Utc).AddTicks(1273), new DateTime(2024, 8, 16, 23, 49, 5, 286, DateTimeKind.Utc).AddTicks(1273), new DateTime(2024, 8, 17, 3, 49, 5, 286, DateTimeKind.Local).AddTicks(1268) });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: 2033,
                columns: new[] { "About", "Address", "City", "ConcurrencyStamp", "CreatedTime", "LastUpdatedTime", "RefreshTokenCreateTime" },
                values: new object[] { "NULL", "Address33", "City33", "26a976df-bafe-4fee-8838-6f986bc3df6f", new DateTime(2024, 8, 16, 23, 49, 5, 286, DateTimeKind.Utc).AddTicks(1286), new DateTime(2024, 8, 16, 23, 49, 5, 286, DateTimeKind.Utc).AddTicks(1286), new DateTime(2024, 8, 17, 3, 49, 5, 286, DateTimeKind.Local).AddTicks(1281) });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: 2034,
                columns: new[] { "About", "Address", "City", "ConcurrencyStamp", "CreatedTime", "LastUpdatedTime", "RefreshTokenCreateTime" },
                values: new object[] { "NULL", "Address34", "City34", "f3321992-1b7b-48d1-8f39-03bd7d7b2a79", new DateTime(2024, 8, 16, 23, 49, 5, 286, DateTimeKind.Utc).AddTicks(1499), new DateTime(2024, 8, 16, 23, 49, 5, 286, DateTimeKind.Utc).AddTicks(1501), new DateTime(2024, 8, 17, 3, 49, 5, 286, DateTimeKind.Local).AddTicks(1480) });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: 2035,
                columns: new[] { "About", "Address", "City", "ConcurrencyStamp", "CreatedTime", "LastUpdatedTime", "RefreshTokenCreateTime" },
                values: new object[] { "NULL", "Address35", "City35", "e160a811-a75f-4d19-9f38-8fa0be5f0d7f", new DateTime(2024, 8, 16, 23, 49, 5, 286, DateTimeKind.Utc).AddTicks(1549), new DateTime(2024, 8, 16, 23, 49, 5, 286, DateTimeKind.Utc).AddTicks(1551), new DateTime(2024, 8, 17, 3, 49, 5, 286, DateTimeKind.Local).AddTicks(1523) });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: 2036,
                columns: new[] { "About", "Address", "City", "ConcurrencyStamp", "CreatedTime", "LastUpdatedTime", "RefreshTokenCreateTime" },
                values: new object[] { "NULL", "Address36", "City36", "2cad6c71-8b1c-4958-9f29-d76dbbb169f3", new DateTime(2024, 8, 16, 23, 49, 5, 286, DateTimeKind.Utc).AddTicks(1724), new DateTime(2024, 8, 16, 23, 49, 5, 286, DateTimeKind.Utc).AddTicks(1725), new DateTime(2024, 8, 17, 3, 49, 5, 286, DateTimeKind.Local).AddTicks(1719) });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: 2037,
                columns: new[] { "About", "Address", "City", "ConcurrencyStamp", "CreatedTime", "LastUpdatedTime", "RefreshTokenCreateTime" },
                values: new object[] { "NULL", "Address37", "City37", "c8089cea-407f-48e3-9d1a-d937e7bd9330", new DateTime(2024, 8, 16, 23, 49, 5, 286, DateTimeKind.Utc).AddTicks(1738), new DateTime(2024, 8, 16, 23, 49, 5, 286, DateTimeKind.Utc).AddTicks(1738), new DateTime(2024, 8, 17, 3, 49, 5, 286, DateTimeKind.Local).AddTicks(1733) });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: 2038,
                columns: new[] { "About", "Address", "City", "ConcurrencyStamp", "CreatedTime", "LastUpdatedTime", "RefreshTokenCreateTime" },
                values: new object[] { "NULL", "Address38", "City38", "9db7ddb2-af2a-4c5a-8182-6b7f953dc973", new DateTime(2024, 8, 16, 23, 49, 5, 286, DateTimeKind.Utc).AddTicks(1751), new DateTime(2024, 8, 16, 23, 49, 5, 286, DateTimeKind.Utc).AddTicks(1751), new DateTime(2024, 8, 17, 3, 49, 5, 286, DateTimeKind.Local).AddTicks(1746) });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: 2039,
                columns: new[] { "About", "Address", "City", "ConcurrencyStamp", "CreatedTime", "LastUpdatedTime", "RefreshTokenCreateTime" },
                values: new object[] { "NULL", "Address39", "City39", "5cdce083-c44e-4697-bc61-9b1b94d641c8", new DateTime(2024, 8, 16, 23, 49, 5, 286, DateTimeKind.Utc).AddTicks(1764), new DateTime(2024, 8, 16, 23, 49, 5, 286, DateTimeKind.Utc).AddTicks(1765), new DateTime(2024, 8, 17, 3, 49, 5, 286, DateTimeKind.Local).AddTicks(1759) });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: 2040,
                columns: new[] { "About", "Address", "City", "ConcurrencyStamp", "CreatedTime", "LastUpdatedTime", "RefreshTokenCreateTime" },
                values: new object[] { "NULL", "Address40", "City40", "edccf5c1-55cc-494d-aa2a-2186569e4acb", new DateTime(2024, 8, 16, 23, 49, 5, 286, DateTimeKind.Utc).AddTicks(1778), new DateTime(2024, 8, 16, 23, 49, 5, 286, DateTimeKind.Utc).AddTicks(1779), new DateTime(2024, 8, 17, 3, 49, 5, 286, DateTimeKind.Local).AddTicks(1773) });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: 2041,
                columns: new[] { "About", "Address", "City", "ConcurrencyStamp", "CreatedTime", "LastUpdatedTime", "RefreshTokenCreateTime" },
                values: new object[] { "NULL", "Address41", "City41", "47cfd453-395e-44fc-bba4-10aa3e8b57ae", new DateTime(2024, 8, 16, 23, 49, 5, 286, DateTimeKind.Utc).AddTicks(1791), new DateTime(2024, 8, 16, 23, 49, 5, 286, DateTimeKind.Utc).AddTicks(1792), new DateTime(2024, 8, 17, 3, 49, 5, 286, DateTimeKind.Local).AddTicks(1786) });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: 2042,
                columns: new[] { "About", "Address", "City", "ConcurrencyStamp", "CreatedTime", "LastUpdatedTime", "RefreshTokenCreateTime" },
                values: new object[] { "NULL", "Address42", "City42", "61631bb3-4a05-499a-9982-0247cf9f7028", new DateTime(2024, 8, 16, 23, 49, 5, 286, DateTimeKind.Utc).AddTicks(1810), new DateTime(2024, 8, 16, 23, 49, 5, 286, DateTimeKind.Utc).AddTicks(1811), new DateTime(2024, 8, 17, 3, 49, 5, 286, DateTimeKind.Local).AddTicks(1805) });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: 2043,
                columns: new[] { "About", "Address", "City", "ConcurrencyStamp", "CreatedTime", "LastUpdatedTime", "RefreshTokenCreateTime" },
                values: new object[] { "NULL", "Address43", "City43", "2894274d-de18-47f3-aa10-7aad289fcdb1", new DateTime(2024, 8, 16, 23, 49, 5, 286, DateTimeKind.Utc).AddTicks(1864), new DateTime(2024, 8, 16, 23, 49, 5, 286, DateTimeKind.Utc).AddTicks(1865), new DateTime(2024, 8, 17, 3, 49, 5, 286, DateTimeKind.Local).AddTicks(1855) });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: 2044,
                columns: new[] { "About", "Address", "City", "ConcurrencyStamp", "CreatedTime", "LastUpdatedTime", "RefreshTokenCreateTime" },
                values: new object[] { "NULL", "Address44", "City44", "f10fb501-d926-42bb-970c-55767fe6d017", new DateTime(2024, 8, 16, 23, 49, 5, 286, DateTimeKind.Utc).AddTicks(1879), new DateTime(2024, 8, 16, 23, 49, 5, 286, DateTimeKind.Utc).AddTicks(1879), new DateTime(2024, 8, 17, 3, 49, 5, 286, DateTimeKind.Local).AddTicks(1874) });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: 2045,
                columns: new[] { "About", "Address", "City", "ConcurrencyStamp", "CreatedTime", "LastUpdatedTime", "RefreshTokenCreateTime" },
                values: new object[] { "NULL", "Address45", "City45", "990d6e0f-a467-4792-a1aa-cbf761a63376", new DateTime(2024, 8, 16, 23, 49, 5, 286, DateTimeKind.Utc).AddTicks(1892), new DateTime(2024, 8, 16, 23, 49, 5, 286, DateTimeKind.Utc).AddTicks(1892), new DateTime(2024, 8, 17, 3, 49, 5, 286, DateTimeKind.Local).AddTicks(1887) });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: 2046,
                columns: new[] { "About", "Address", "City", "ConcurrencyStamp", "CreatedTime", "LastUpdatedTime", "RefreshTokenCreateTime" },
                values: new object[] { "NULL", "Address46", "City46", "d60cfa3e-3cba-4d86-a51e-d67639c370cf", new DateTime(2024, 8, 16, 23, 49, 5, 286, DateTimeKind.Utc).AddTicks(1905), new DateTime(2024, 8, 16, 23, 49, 5, 286, DateTimeKind.Utc).AddTicks(1905), new DateTime(2024, 8, 17, 3, 49, 5, 286, DateTimeKind.Local).AddTicks(1900) });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: 2047,
                columns: new[] { "About", "Address", "City", "ConcurrencyStamp", "CreatedTime", "LastUpdatedTime", "RefreshTokenCreateTime" },
                values: new object[] { "NULL", "Address47", "City47", "fbcefe60-7ed6-4afe-949f-adcd29f71f85", new DateTime(2024, 8, 16, 23, 49, 5, 286, DateTimeKind.Utc).AddTicks(1919), new DateTime(2024, 8, 16, 23, 49, 5, 286, DateTimeKind.Utc).AddTicks(1919), new DateTime(2024, 8, 17, 3, 49, 5, 286, DateTimeKind.Local).AddTicks(1913) });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: 2048,
                columns: new[] { "About", "Address", "City", "ConcurrencyStamp", "CreatedTime", "LastUpdatedTime", "RefreshTokenCreateTime" },
                values: new object[] { "NULL", "Address48", "City48", "766f6b64-9c42-421d-8acf-ede1e6f3e076", new DateTime(2024, 8, 16, 23, 49, 5, 286, DateTimeKind.Utc).AddTicks(1932), new DateTime(2024, 8, 16, 23, 49, 5, 286, DateTimeKind.Utc).AddTicks(1932), new DateTime(2024, 8, 17, 3, 49, 5, 286, DateTimeKind.Local).AddTicks(1927) });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: 2049,
                columns: new[] { "About", "Address", "City", "ConcurrencyStamp", "CreatedTime", "LastUpdatedTime", "RefreshTokenCreateTime" },
                values: new object[] { "NULL", "Address49", "City49", "37053795-31b8-4242-892a-21aa053344cd", new DateTime(2024, 8, 16, 23, 49, 5, 286, DateTimeKind.Utc).AddTicks(1945), new DateTime(2024, 8, 16, 23, 49, 5, 286, DateTimeKind.Utc).AddTicks(1945), new DateTime(2024, 8, 17, 3, 49, 5, 286, DateTimeKind.Local).AddTicks(1939) });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: 2050,
                columns: new[] { "About", "Address", "City", "ConcurrencyStamp", "CreatedTime", "LastUpdatedTime", "RefreshTokenCreateTime" },
                values: new object[] { "NULL", "Address50", "City50", "3747f2f1-c72d-40c5-9b03-6969d451a818", new DateTime(2024, 8, 16, 23, 49, 5, 286, DateTimeKind.Utc).AddTicks(1958), new DateTime(2024, 8, 16, 23, 49, 5, 286, DateTimeKind.Utc).AddTicks(1959), new DateTime(2024, 8, 17, 3, 49, 5, 286, DateTimeKind.Local).AddTicks(1953) });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: 2051,
                columns: new[] { "About", "Address", "City", "ConcurrencyStamp", "CreatedTime", "LastUpdatedTime", "RefreshTokenCreateTime" },
                values: new object[] { "NULL", "Address51", "City51", "9a287b39-e689-4e3b-84bd-ab48c56356a6", new DateTime(2024, 8, 16, 23, 49, 5, 286, DateTimeKind.Utc).AddTicks(1976), new DateTime(2024, 8, 16, 23, 49, 5, 286, DateTimeKind.Utc).AddTicks(1976), new DateTime(2024, 8, 17, 3, 49, 5, 286, DateTimeKind.Local).AddTicks(1967) });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: 2052,
                columns: new[] { "About", "Address", "City", "ConcurrencyStamp", "CreatedTime", "LastUpdatedTime", "RefreshTokenCreateTime" },
                values: new object[] { "NULL", "Address52", "City52", "dd8beb63-c54c-42f2-8296-36a1cacca8d3", new DateTime(2024, 8, 16, 23, 49, 5, 286, DateTimeKind.Utc).AddTicks(2013), new DateTime(2024, 8, 16, 23, 49, 5, 286, DateTimeKind.Utc).AddTicks(2014), new DateTime(2024, 8, 17, 3, 49, 5, 286, DateTimeKind.Local).AddTicks(2008) });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: 2053,
                columns: new[] { "About", "Address", "City", "ConcurrencyStamp", "CreatedTime", "LastUpdatedTime", "RefreshTokenCreateTime" },
                values: new object[] { "NULL", "Address53", "City53", "ddb6b5d1-7f9f-465a-8dba-fac17163dd71", new DateTime(2024, 8, 16, 23, 49, 5, 286, DateTimeKind.Utc).AddTicks(2026), new DateTime(2024, 8, 16, 23, 49, 5, 286, DateTimeKind.Utc).AddTicks(2027), new DateTime(2024, 8, 17, 3, 49, 5, 286, DateTimeKind.Local).AddTicks(2021) });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: 2054,
                columns: new[] { "About", "Address", "City", "ConcurrencyStamp", "CreatedTime", "LastUpdatedTime", "RefreshTokenCreateTime" },
                values: new object[] { "NULL", "Address54", "City54", "f79e037b-6de3-4d8b-9439-11fd22cc61a8", new DateTime(2024, 8, 16, 23, 49, 5, 286, DateTimeKind.Utc).AddTicks(2039), new DateTime(2024, 8, 16, 23, 49, 5, 286, DateTimeKind.Utc).AddTicks(2040), new DateTime(2024, 8, 17, 3, 49, 5, 286, DateTimeKind.Local).AddTicks(2034) });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: 2055,
                columns: new[] { "About", "Address", "City", "ConcurrencyStamp", "CreatedTime", "LastUpdatedTime", "RefreshTokenCreateTime" },
                values: new object[] { "NULL", "Address55", "City55", "cec5a612-4faf-4520-8cec-d98077a65fd9", new DateTime(2024, 8, 16, 23, 49, 5, 286, DateTimeKind.Utc).AddTicks(2053), new DateTime(2024, 8, 16, 23, 49, 5, 286, DateTimeKind.Utc).AddTicks(2053), new DateTime(2024, 8, 17, 3, 49, 5, 286, DateTimeKind.Local).AddTicks(2047) });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: 2056,
                columns: new[] { "About", "Address", "City", "ConcurrencyStamp", "CreatedTime", "LastUpdatedTime", "RefreshTokenCreateTime" },
                values: new object[] { "NULL", "Address56", "City56", "43839435-9cf5-459b-9789-f9443adba8bb", new DateTime(2024, 8, 16, 23, 49, 5, 286, DateTimeKind.Utc).AddTicks(2066), new DateTime(2024, 8, 16, 23, 49, 5, 286, DateTimeKind.Utc).AddTicks(2066), new DateTime(2024, 8, 17, 3, 49, 5, 286, DateTimeKind.Local).AddTicks(2061) });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: 2057,
                columns: new[] { "About", "Address", "City", "ConcurrencyStamp", "CreatedTime", "LastUpdatedTime", "RefreshTokenCreateTime" },
                values: new object[] { "NULL", "Address57", "City57", "f69a4200-6b0a-425f-9136-7008aa96cecd", new DateTime(2024, 8, 16, 23, 49, 5, 286, DateTimeKind.Utc).AddTicks(2079), new DateTime(2024, 8, 16, 23, 49, 5, 286, DateTimeKind.Utc).AddTicks(2080), new DateTime(2024, 8, 17, 3, 49, 5, 286, DateTimeKind.Local).AddTicks(2074) });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: 2058,
                columns: new[] { "About", "Address", "City", "ConcurrencyStamp", "CreatedTime", "LastUpdatedTime", "RefreshTokenCreateTime" },
                values: new object[] { "NULL", "Address58", "City58", "36d196fc-db5e-438c-9843-f52e14c96299", new DateTime(2024, 8, 16, 23, 49, 5, 286, DateTimeKind.Utc).AddTicks(2092), new DateTime(2024, 8, 16, 23, 49, 5, 286, DateTimeKind.Utc).AddTicks(2093), new DateTime(2024, 8, 17, 3, 49, 5, 286, DateTimeKind.Local).AddTicks(2087) });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: 2059,
                columns: new[] { "About", "Address", "City", "ConcurrencyStamp", "CreatedTime", "LastUpdatedTime", "RefreshTokenCreateTime" },
                values: new object[] { "NULL", "Address59", "City59", "3a14bed2-bc7d-4aaa-9244-11c6aa7e19d8", new DateTime(2024, 8, 16, 23, 49, 5, 286, DateTimeKind.Utc).AddTicks(2109), new DateTime(2024, 8, 16, 23, 49, 5, 286, DateTimeKind.Utc).AddTicks(2109), new DateTime(2024, 8, 17, 3, 49, 5, 286, DateTimeKind.Local).AddTicks(2100) });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: 2060,
                columns: new[] { "About", "Address", "City", "ConcurrencyStamp", "CreatedTime", "LastUpdatedTime", "RefreshTokenCreateTime" },
                values: new object[] { "NULL", "Address60", "City60", "555943ff-6ab3-4247-a5af-7ec155fa22ad", new DateTime(2024, 8, 16, 23, 49, 5, 286, DateTimeKind.Utc).AddTicks(2121), new DateTime(2024, 8, 16, 23, 49, 5, 286, DateTimeKind.Utc).AddTicks(2122), new DateTime(2024, 8, 17, 3, 49, 5, 286, DateTimeKind.Local).AddTicks(2116) });

            migrationBuilder.UpdateData(
                table: "Breeds",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedTime",
                value: new DateTime(2024, 8, 17, 3, 49, 5, 277, DateTimeKind.Local).AddTicks(4615));

            migrationBuilder.UpdateData(
                table: "Breeds",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreatedTime",
                value: new DateTime(2024, 8, 17, 3, 49, 5, 277, DateTimeKind.Local).AddTicks(4622));

            migrationBuilder.UpdateData(
                table: "Breeds",
                keyColumn: "Id",
                keyValue: 3,
                column: "CreatedTime",
                value: new DateTime(2024, 8, 17, 3, 49, 5, 277, DateTimeKind.Local).AddTicks(4623));

            migrationBuilder.UpdateData(
                table: "Breeds",
                keyColumn: "Id",
                keyValue: 4,
                column: "CreatedTime",
                value: new DateTime(2024, 8, 17, 3, 49, 5, 277, DateTimeKind.Local).AddTicks(4625));

            migrationBuilder.UpdateData(
                table: "Breeds",
                keyColumn: "Id",
                keyValue: 5,
                column: "CreatedTime",
                value: new DateTime(2024, 8, 17, 3, 49, 5, 277, DateTimeKind.Local).AddTicks(4626));

            migrationBuilder.UpdateData(
                table: "Breeds",
                keyColumn: "Id",
                keyValue: 6,
                column: "CreatedTime",
                value: new DateTime(2024, 8, 17, 3, 49, 5, 277, DateTimeKind.Local).AddTicks(4628));

            migrationBuilder.UpdateData(
                table: "Breeds",
                keyColumn: "Id",
                keyValue: 7,
                column: "CreatedTime",
                value: new DateTime(2024, 8, 17, 3, 49, 5, 277, DateTimeKind.Local).AddTicks(4629));

            migrationBuilder.UpdateData(
                table: "Breeds",
                keyColumn: "Id",
                keyValue: 8,
                column: "CreatedTime",
                value: new DateTime(2024, 8, 17, 3, 49, 5, 277, DateTimeKind.Local).AddTicks(4631));

            migrationBuilder.UpdateData(
                table: "Breeds",
                keyColumn: "Id",
                keyValue: 9,
                column: "CreatedTime",
                value: new DateTime(2024, 8, 17, 3, 49, 5, 277, DateTimeKind.Local).AddTicks(4632));

            migrationBuilder.UpdateData(
                table: "Breeds",
                keyColumn: "Id",
                keyValue: 10,
                column: "CreatedTime",
                value: new DateTime(2024, 8, 17, 3, 49, 5, 277, DateTimeKind.Local).AddTicks(4634));

            migrationBuilder.UpdateData(
                table: "Breeds",
                keyColumn: "Id",
                keyValue: 11,
                column: "CreatedTime",
                value: new DateTime(2024, 8, 17, 3, 49, 5, 277, DateTimeKind.Local).AddTicks(4635));

            migrationBuilder.UpdateData(
                table: "Breeds",
                keyColumn: "Id",
                keyValue: 12,
                column: "CreatedTime",
                value: new DateTime(2024, 8, 17, 3, 49, 5, 277, DateTimeKind.Local).AddTicks(4636));

            migrationBuilder.UpdateData(
                table: "Breeds",
                keyColumn: "Id",
                keyValue: 13,
                column: "CreatedTime",
                value: new DateTime(2024, 8, 17, 3, 49, 5, 277, DateTimeKind.Local).AddTicks(4637));

            migrationBuilder.UpdateData(
                table: "Breeds",
                keyColumn: "Id",
                keyValue: 14,
                column: "CreatedTime",
                value: new DateTime(2024, 8, 17, 3, 49, 5, 277, DateTimeKind.Local).AddTicks(4639));

            migrationBuilder.UpdateData(
                table: "Breeds",
                keyColumn: "Id",
                keyValue: 15,
                column: "CreatedTime",
                value: new DateTime(2024, 8, 17, 3, 49, 5, 277, DateTimeKind.Local).AddTicks(4640));

            migrationBuilder.UpdateData(
                table: "Breeds",
                keyColumn: "Id",
                keyValue: 16,
                column: "CreatedTime",
                value: new DateTime(2024, 8, 17, 3, 49, 5, 277, DateTimeKind.Local).AddTicks(4642));

            migrationBuilder.UpdateData(
                table: "Breeds",
                keyColumn: "Id",
                keyValue: 17,
                column: "CreatedTime",
                value: new DateTime(2024, 8, 17, 3, 49, 5, 277, DateTimeKind.Local).AddTicks(4643));

            migrationBuilder.UpdateData(
                table: "Breeds",
                keyColumn: "Id",
                keyValue: 18,
                column: "CreatedTime",
                value: new DateTime(2024, 8, 17, 3, 49, 5, 277, DateTimeKind.Local).AddTicks(4645));

            migrationBuilder.UpdateData(
                table: "Breeds",
                keyColumn: "Id",
                keyValue: 19,
                column: "CreatedTime",
                value: new DateTime(2024, 8, 17, 3, 49, 5, 277, DateTimeKind.Local).AddTicks(4647));

            migrationBuilder.UpdateData(
                table: "Breeds",
                keyColumn: "Id",
                keyValue: 20,
                column: "CreatedTime",
                value: new DateTime(2024, 8, 17, 3, 49, 5, 277, DateTimeKind.Local).AddTicks(4648));

            migrationBuilder.UpdateData(
                table: "Breeds",
                keyColumn: "Id",
                keyValue: 21,
                column: "CreatedTime",
                value: new DateTime(2024, 8, 17, 3, 49, 5, 277, DateTimeKind.Local).AddTicks(4649));

            migrationBuilder.UpdateData(
                table: "Breeds",
                keyColumn: "Id",
                keyValue: 22,
                column: "CreatedTime",
                value: new DateTime(2024, 8, 17, 3, 49, 5, 277, DateTimeKind.Local).AddTicks(4650));

            migrationBuilder.UpdateData(
                table: "Breeds",
                keyColumn: "Id",
                keyValue: 23,
                column: "CreatedTime",
                value: new DateTime(2024, 8, 17, 3, 49, 5, 277, DateTimeKind.Local).AddTicks(4652));

            migrationBuilder.UpdateData(
                table: "Breeds",
                keyColumn: "Id",
                keyValue: 24,
                column: "CreatedTime",
                value: new DateTime(2024, 8, 17, 3, 49, 5, 277, DateTimeKind.Local).AddTicks(4653));

            migrationBuilder.UpdateData(
                table: "Breeds",
                keyColumn: "Id",
                keyValue: 25,
                column: "CreatedTime",
                value: new DateTime(2024, 8, 17, 3, 49, 5, 277, DateTimeKind.Local).AddTicks(4654));

            migrationBuilder.UpdateData(
                table: "Breeds",
                keyColumn: "Id",
                keyValue: 26,
                column: "CreatedTime",
                value: new DateTime(2024, 8, 17, 3, 49, 5, 277, DateTimeKind.Local).AddTicks(4656));

            migrationBuilder.UpdateData(
                table: "Breeds",
                keyColumn: "Id",
                keyValue: 27,
                column: "CreatedTime",
                value: new DateTime(2024, 8, 17, 3, 49, 5, 277, DateTimeKind.Local).AddTicks(4658));

            migrationBuilder.UpdateData(
                table: "Breeds",
                keyColumn: "Id",
                keyValue: 28,
                column: "CreatedTime",
                value: new DateTime(2024, 8, 17, 3, 49, 5, 277, DateTimeKind.Local).AddTicks(4659));

            migrationBuilder.UpdateData(
                table: "Breeds",
                keyColumn: "Id",
                keyValue: 29,
                column: "CreatedTime",
                value: new DateTime(2024, 8, 17, 3, 49, 5, 277, DateTimeKind.Local).AddTicks(4660));

            migrationBuilder.UpdateData(
                table: "Breeds",
                keyColumn: "Id",
                keyValue: 30,
                column: "CreatedTime",
                value: new DateTime(2024, 8, 17, 3, 49, 5, 277, DateTimeKind.Local).AddTicks(4662));

            migrationBuilder.UpdateData(
                table: "Breeds",
                keyColumn: "Id",
                keyValue: 31,
                column: "CreatedTime",
                value: new DateTime(2024, 8, 17, 3, 49, 5, 277, DateTimeKind.Local).AddTicks(4663));

            migrationBuilder.UpdateData(
                table: "Breeds",
                keyColumn: "Id",
                keyValue: 32,
                column: "CreatedTime",
                value: new DateTime(2024, 8, 17, 3, 49, 5, 277, DateTimeKind.Local).AddTicks(4664));

            migrationBuilder.UpdateData(
                table: "Breeds",
                keyColumn: "Id",
                keyValue: 33,
                column: "CreatedTime",
                value: new DateTime(2024, 8, 17, 3, 49, 5, 277, DateTimeKind.Local).AddTicks(4666));

            migrationBuilder.UpdateData(
                table: "Breeds",
                keyColumn: "Id",
                keyValue: 34,
                column: "CreatedTime",
                value: new DateTime(2024, 8, 17, 3, 49, 5, 277, DateTimeKind.Local).AddTicks(4667));

            migrationBuilder.UpdateData(
                table: "Breeds",
                keyColumn: "Id",
                keyValue: 35,
                column: "CreatedTime",
                value: new DateTime(2024, 8, 17, 3, 49, 5, 277, DateTimeKind.Local).AddTicks(4668));

            migrationBuilder.UpdateData(
                table: "Breeds",
                keyColumn: "Id",
                keyValue: 36,
                column: "CreatedTime",
                value: new DateTime(2024, 8, 17, 3, 49, 5, 277, DateTimeKind.Local).AddTicks(4669));

            migrationBuilder.UpdateData(
                table: "Breeds",
                keyColumn: "Id",
                keyValue: 37,
                column: "CreatedTime",
                value: new DateTime(2024, 8, 17, 3, 49, 5, 277, DateTimeKind.Local).AddTicks(4671));

            migrationBuilder.UpdateData(
                table: "Breeds",
                keyColumn: "Id",
                keyValue: 38,
                column: "CreatedTime",
                value: new DateTime(2024, 8, 17, 3, 49, 5, 277, DateTimeKind.Local).AddTicks(4673));

            migrationBuilder.UpdateData(
                table: "Breeds",
                keyColumn: "Id",
                keyValue: 39,
                column: "CreatedTime",
                value: new DateTime(2024, 8, 17, 3, 49, 5, 277, DateTimeKind.Local).AddTicks(4675));

            migrationBuilder.UpdateData(
                table: "Breeds",
                keyColumn: "Id",
                keyValue: 40,
                column: "CreatedTime",
                value: new DateTime(2024, 8, 17, 3, 49, 5, 277, DateTimeKind.Local).AddTicks(4676));

            migrationBuilder.UpdateData(
                table: "Breeds",
                keyColumn: "Id",
                keyValue: 41,
                column: "CreatedTime",
                value: new DateTime(2024, 8, 17, 3, 49, 5, 277, DateTimeKind.Local).AddTicks(4678));

            migrationBuilder.UpdateData(
                table: "Breeds",
                keyColumn: "Id",
                keyValue: 42,
                column: "CreatedTime",
                value: new DateTime(2024, 8, 17, 3, 49, 5, 277, DateTimeKind.Local).AddTicks(4679));

            migrationBuilder.UpdateData(
                table: "Breeds",
                keyColumn: "Id",
                keyValue: 43,
                column: "CreatedTime",
                value: new DateTime(2024, 8, 17, 3, 49, 5, 277, DateTimeKind.Local).AddTicks(4681));

            migrationBuilder.UpdateData(
                table: "Breeds",
                keyColumn: "Id",
                keyValue: 44,
                column: "CreatedTime",
                value: new DateTime(2024, 8, 17, 3, 49, 5, 277, DateTimeKind.Local).AddTicks(4683));

            migrationBuilder.UpdateData(
                table: "Breeds",
                keyColumn: "Id",
                keyValue: 45,
                column: "CreatedTime",
                value: new DateTime(2024, 8, 17, 3, 49, 5, 277, DateTimeKind.Local).AddTicks(4684));

            migrationBuilder.UpdateData(
                table: "Breeds",
                keyColumn: "Id",
                keyValue: 46,
                column: "CreatedTime",
                value: new DateTime(2024, 8, 17, 3, 49, 5, 277, DateTimeKind.Local).AddTicks(4686));

            migrationBuilder.UpdateData(
                table: "Breeds",
                keyColumn: "Id",
                keyValue: 47,
                column: "CreatedTime",
                value: new DateTime(2024, 8, 17, 3, 49, 5, 277, DateTimeKind.Local).AddTicks(4687));

            migrationBuilder.UpdateData(
                table: "Breeds",
                keyColumn: "Id",
                keyValue: 48,
                column: "CreatedTime",
                value: new DateTime(2024, 8, 17, 3, 49, 5, 277, DateTimeKind.Local).AddTicks(4688));

            migrationBuilder.UpdateData(
                table: "Breeds",
                keyColumn: "Id",
                keyValue: 49,
                column: "CreatedTime",
                value: new DateTime(2024, 8, 17, 3, 49, 5, 277, DateTimeKind.Local).AddTicks(4689));

            migrationBuilder.UpdateData(
                table: "Breeds",
                keyColumn: "Id",
                keyValue: 50,
                column: "CreatedTime",
                value: new DateTime(2024, 8, 17, 3, 49, 5, 277, DateTimeKind.Local).AddTicks(4691));

            migrationBuilder.UpdateData(
                table: "Breeds",
                keyColumn: "Id",
                keyValue: 51,
                column: "CreatedTime",
                value: new DateTime(2024, 8, 17, 3, 49, 5, 277, DateTimeKind.Local).AddTicks(4692));

            migrationBuilder.UpdateData(
                table: "Breeds",
                keyColumn: "Id",
                keyValue: 52,
                column: "CreatedTime",
                value: new DateTime(2024, 8, 17, 3, 49, 5, 277, DateTimeKind.Local).AddTicks(4693));

            migrationBuilder.UpdateData(
                table: "Breeds",
                keyColumn: "Id",
                keyValue: 53,
                column: "CreatedTime",
                value: new DateTime(2024, 8, 17, 3, 49, 5, 277, DateTimeKind.Local).AddTicks(4696));

            migrationBuilder.UpdateData(
                table: "Breeds",
                keyColumn: "Id",
                keyValue: 54,
                column: "CreatedTime",
                value: new DateTime(2024, 8, 17, 3, 49, 5, 277, DateTimeKind.Local).AddTicks(4697));

            migrationBuilder.UpdateData(
                table: "Breeds",
                keyColumn: "Id",
                keyValue: 55,
                column: "CreatedTime",
                value: new DateTime(2024, 8, 17, 3, 49, 5, 277, DateTimeKind.Local).AddTicks(4699));

            migrationBuilder.UpdateData(
                table: "Breeds",
                keyColumn: "Id",
                keyValue: 56,
                column: "CreatedTime",
                value: new DateTime(2024, 8, 17, 3, 49, 5, 277, DateTimeKind.Local).AddTicks(4700));

            migrationBuilder.UpdateData(
                table: "Breeds",
                keyColumn: "Id",
                keyValue: 57,
                column: "CreatedTime",
                value: new DateTime(2024, 8, 17, 3, 49, 5, 277, DateTimeKind.Local).AddTicks(4701));

            migrationBuilder.UpdateData(
                table: "Breeds",
                keyColumn: "Id",
                keyValue: 58,
                column: "CreatedTime",
                value: new DateTime(2024, 8, 17, 3, 49, 5, 277, DateTimeKind.Local).AddTicks(4703));

            migrationBuilder.UpdateData(
                table: "Breeds",
                keyColumn: "Id",
                keyValue: 59,
                column: "CreatedTime",
                value: new DateTime(2024, 8, 17, 3, 49, 5, 277, DateTimeKind.Local).AddTicks(4704));

            migrationBuilder.UpdateData(
                table: "Breeds",
                keyColumn: "Id",
                keyValue: 60,
                column: "CreatedTime",
                value: new DateTime(2024, 8, 17, 3, 49, 5, 277, DateTimeKind.Local).AddTicks(4706));

            migrationBuilder.UpdateData(
                table: "Breeds",
                keyColumn: "Id",
                keyValue: 61,
                column: "CreatedTime",
                value: new DateTime(2024, 8, 17, 3, 49, 5, 277, DateTimeKind.Local).AddTicks(4707));

            migrationBuilder.UpdateData(
                table: "Breeds",
                keyColumn: "Id",
                keyValue: 62,
                column: "CreatedTime",
                value: new DateTime(2024, 8, 17, 3, 49, 5, 277, DateTimeKind.Local).AddTicks(4708));

            migrationBuilder.UpdateData(
                table: "Breeds",
                keyColumn: "Id",
                keyValue: 63,
                column: "CreatedTime",
                value: new DateTime(2024, 8, 17, 3, 49, 5, 277, DateTimeKind.Local).AddTicks(4710));

            migrationBuilder.UpdateData(
                table: "Breeds",
                keyColumn: "Id",
                keyValue: 64,
                column: "CreatedTime",
                value: new DateTime(2024, 8, 17, 3, 49, 5, 277, DateTimeKind.Local).AddTicks(4711));

            migrationBuilder.UpdateData(
                table: "Breeds",
                keyColumn: "Id",
                keyValue: 65,
                column: "CreatedTime",
                value: new DateTime(2024, 8, 17, 3, 49, 5, 277, DateTimeKind.Local).AddTicks(4713));

            migrationBuilder.UpdateData(
                table: "Breeds",
                keyColumn: "Id",
                keyValue: 66,
                column: "CreatedTime",
                value: new DateTime(2024, 8, 17, 3, 49, 5, 277, DateTimeKind.Local).AddTicks(4715));

            migrationBuilder.UpdateData(
                table: "Breeds",
                keyColumn: "Id",
                keyValue: 67,
                column: "CreatedTime",
                value: new DateTime(2024, 8, 17, 3, 49, 5, 277, DateTimeKind.Local).AddTicks(4717));

            migrationBuilder.UpdateData(
                table: "Breeds",
                keyColumn: "Id",
                keyValue: 68,
                column: "CreatedTime",
                value: new DateTime(2024, 8, 17, 3, 49, 5, 277, DateTimeKind.Local).AddTicks(4718));

            migrationBuilder.UpdateData(
                table: "Breeds",
                keyColumn: "Id",
                keyValue: 69,
                column: "CreatedTime",
                value: new DateTime(2024, 8, 17, 3, 49, 5, 277, DateTimeKind.Local).AddTicks(4719));

            migrationBuilder.UpdateData(
                table: "Breeds",
                keyColumn: "Id",
                keyValue: 70,
                column: "CreatedTime",
                value: new DateTime(2024, 8, 17, 3, 49, 5, 277, DateTimeKind.Local).AddTicks(4721));

            migrationBuilder.UpdateData(
                table: "Breeds",
                keyColumn: "Id",
                keyValue: 71,
                column: "CreatedTime",
                value: new DateTime(2024, 8, 17, 3, 49, 5, 277, DateTimeKind.Local).AddTicks(4722));

            migrationBuilder.UpdateData(
                table: "Breeds",
                keyColumn: "Id",
                keyValue: 72,
                column: "CreatedTime",
                value: new DateTime(2024, 8, 17, 3, 49, 5, 277, DateTimeKind.Local).AddTicks(4723));

            migrationBuilder.UpdateData(
                table: "Breeds",
                keyColumn: "Id",
                keyValue: 73,
                column: "CreatedTime",
                value: new DateTime(2024, 8, 17, 3, 49, 5, 277, DateTimeKind.Local).AddTicks(4725));

            migrationBuilder.UpdateData(
                table: "Breeds",
                keyColumn: "Id",
                keyValue: 74,
                column: "CreatedTime",
                value: new DateTime(2024, 8, 17, 3, 49, 5, 277, DateTimeKind.Local).AddTicks(4726));

            migrationBuilder.UpdateData(
                table: "Breeds",
                keyColumn: "Id",
                keyValue: 75,
                column: "CreatedTime",
                value: new DateTime(2024, 8, 17, 3, 49, 5, 277, DateTimeKind.Local).AddTicks(4728));

            migrationBuilder.UpdateData(
                table: "Breeds",
                keyColumn: "Id",
                keyValue: 76,
                column: "CreatedTime",
                value: new DateTime(2024, 8, 17, 3, 49, 5, 277, DateTimeKind.Local).AddTicks(4729));

            migrationBuilder.UpdateData(
                table: "Breeds",
                keyColumn: "Id",
                keyValue: 77,
                column: "CreatedTime",
                value: new DateTime(2024, 8, 17, 3, 49, 5, 277, DateTimeKind.Local).AddTicks(4730));

            migrationBuilder.UpdateData(
                table: "Breeds",
                keyColumn: "Id",
                keyValue: 78,
                column: "CreatedTime",
                value: new DateTime(2024, 8, 17, 3, 49, 5, 277, DateTimeKind.Local).AddTicks(4731));

            migrationBuilder.UpdateData(
                table: "Breeds",
                keyColumn: "Id",
                keyValue: 79,
                column: "CreatedTime",
                value: new DateTime(2024, 8, 17, 3, 49, 5, 277, DateTimeKind.Local).AddTicks(4733));

            migrationBuilder.UpdateData(
                table: "Breeds",
                keyColumn: "Id",
                keyValue: 80,
                column: "CreatedTime",
                value: new DateTime(2024, 8, 17, 3, 49, 5, 277, DateTimeKind.Local).AddTicks(4734));

            migrationBuilder.UpdateData(
                table: "Breeds",
                keyColumn: "Id",
                keyValue: 81,
                column: "CreatedTime",
                value: new DateTime(2024, 8, 17, 3, 49, 5, 277, DateTimeKind.Local).AddTicks(4766));

            migrationBuilder.UpdateData(
                table: "Breeds",
                keyColumn: "Id",
                keyValue: 82,
                column: "CreatedTime",
                value: new DateTime(2024, 8, 17, 3, 49, 5, 277, DateTimeKind.Local).AddTicks(4767));

            migrationBuilder.UpdateData(
                table: "Breeds",
                keyColumn: "Id",
                keyValue: 83,
                column: "CreatedTime",
                value: new DateTime(2024, 8, 17, 3, 49, 5, 277, DateTimeKind.Local).AddTicks(4769));

            migrationBuilder.UpdateData(
                table: "Breeds",
                keyColumn: "Id",
                keyValue: 84,
                column: "CreatedTime",
                value: new DateTime(2024, 8, 17, 3, 49, 5, 277, DateTimeKind.Local).AddTicks(4770));

            migrationBuilder.UpdateData(
                table: "Breeds",
                keyColumn: "Id",
                keyValue: 85,
                column: "CreatedTime",
                value: new DateTime(2024, 8, 17, 3, 49, 5, 277, DateTimeKind.Local).AddTicks(4772));

            migrationBuilder.UpdateData(
                table: "Breeds",
                keyColumn: "Id",
                keyValue: 86,
                column: "CreatedTime",
                value: new DateTime(2024, 8, 17, 3, 49, 5, 277, DateTimeKind.Local).AddTicks(4773));

            migrationBuilder.UpdateData(
                table: "Breeds",
                keyColumn: "Id",
                keyValue: 87,
                column: "CreatedTime",
                value: new DateTime(2024, 8, 17, 3, 49, 5, 277, DateTimeKind.Local).AddTicks(4774));

            migrationBuilder.UpdateData(
                table: "Breeds",
                keyColumn: "Id",
                keyValue: 88,
                column: "CreatedTime",
                value: new DateTime(2024, 8, 17, 3, 49, 5, 277, DateTimeKind.Local).AddTicks(4775));

            migrationBuilder.UpdateData(
                table: "Breeds",
                keyColumn: "Id",
                keyValue: 89,
                column: "CreatedTime",
                value: new DateTime(2024, 8, 17, 3, 49, 5, 277, DateTimeKind.Local).AddTicks(4777));

            migrationBuilder.UpdateData(
                table: "Breeds",
                keyColumn: "Id",
                keyValue: 90,
                column: "CreatedTime",
                value: new DateTime(2024, 8, 17, 3, 49, 5, 277, DateTimeKind.Local).AddTicks(4778));

            migrationBuilder.UpdateData(
                table: "Breeds",
                keyColumn: "Id",
                keyValue: 91,
                column: "CreatedTime",
                value: new DateTime(2024, 8, 17, 3, 49, 5, 277, DateTimeKind.Local).AddTicks(4779));

            migrationBuilder.UpdateData(
                table: "Breeds",
                keyColumn: "Id",
                keyValue: 92,
                column: "CreatedTime",
                value: new DateTime(2024, 8, 17, 3, 49, 5, 277, DateTimeKind.Local).AddTicks(4780));

            migrationBuilder.UpdateData(
                table: "Breeds",
                keyColumn: "Id",
                keyValue: 93,
                column: "CreatedTime",
                value: new DateTime(2024, 8, 17, 3, 49, 5, 277, DateTimeKind.Local).AddTicks(4782));

            migrationBuilder.UpdateData(
                table: "Breeds",
                keyColumn: "Id",
                keyValue: 94,
                column: "CreatedTime",
                value: new DateTime(2024, 8, 17, 3, 49, 5, 277, DateTimeKind.Local).AddTicks(4784));

            migrationBuilder.UpdateData(
                table: "Breeds",
                keyColumn: "Id",
                keyValue: 95,
                column: "CreatedTime",
                value: new DateTime(2024, 8, 17, 3, 49, 5, 277, DateTimeKind.Local).AddTicks(4786));

            migrationBuilder.UpdateData(
                table: "Breeds",
                keyColumn: "Id",
                keyValue: 96,
                column: "CreatedTime",
                value: new DateTime(2024, 8, 17, 3, 49, 5, 277, DateTimeKind.Local).AddTicks(4787));

            migrationBuilder.UpdateData(
                table: "Breeds",
                keyColumn: "Id",
                keyValue: 97,
                column: "CreatedTime",
                value: new DateTime(2024, 8, 17, 3, 49, 5, 277, DateTimeKind.Local).AddTicks(4788));

            migrationBuilder.UpdateData(
                table: "Breeds",
                keyColumn: "Id",
                keyValue: 98,
                column: "CreatedTime",
                value: new DateTime(2024, 8, 17, 3, 49, 5, 277, DateTimeKind.Local).AddTicks(4789));

            migrationBuilder.UpdateData(
                table: "Breeds",
                keyColumn: "Id",
                keyValue: 99,
                column: "CreatedTime",
                value: new DateTime(2024, 8, 17, 3, 49, 5, 277, DateTimeKind.Local).AddTicks(4791));

            migrationBuilder.UpdateData(
                table: "Breeds",
                keyColumn: "Id",
                keyValue: 100,
                column: "CreatedTime",
                value: new DateTime(2024, 8, 17, 3, 49, 5, 277, DateTimeKind.Local).AddTicks(4792));

            migrationBuilder.UpdateData(
                table: "Breeds",
                keyColumn: "Id",
                keyValue: 101,
                column: "CreatedTime",
                value: new DateTime(2024, 8, 17, 3, 49, 5, 277, DateTimeKind.Local).AddTicks(4794));

            migrationBuilder.UpdateData(
                table: "Breeds",
                keyColumn: "Id",
                keyValue: 102,
                column: "CreatedTime",
                value: new DateTime(2024, 8, 17, 3, 49, 5, 277, DateTimeKind.Local).AddTicks(4795));

            migrationBuilder.UpdateData(
                table: "Breeds",
                keyColumn: "Id",
                keyValue: 103,
                column: "CreatedTime",
                value: new DateTime(2024, 8, 17, 3, 49, 5, 277, DateTimeKind.Local).AddTicks(4796));

            migrationBuilder.UpdateData(
                table: "Breeds",
                keyColumn: "Id",
                keyValue: 104,
                column: "CreatedTime",
                value: new DateTime(2024, 8, 17, 3, 49, 5, 277, DateTimeKind.Local).AddTicks(4797));

            migrationBuilder.UpdateData(
                table: "Breeds",
                keyColumn: "Id",
                keyValue: 105,
                column: "CreatedTime",
                value: new DateTime(2024, 8, 17, 3, 49, 5, 277, DateTimeKind.Local).AddTicks(4800));

            migrationBuilder.UpdateData(
                table: "Breeds",
                keyColumn: "Id",
                keyValue: 106,
                column: "CreatedTime",
                value: new DateTime(2024, 8, 17, 3, 49, 5, 277, DateTimeKind.Local).AddTicks(4802));

            migrationBuilder.UpdateData(
                table: "Breeds",
                keyColumn: "Id",
                keyValue: 107,
                column: "CreatedTime",
                value: new DateTime(2024, 8, 17, 3, 49, 5, 277, DateTimeKind.Local).AddTicks(4804));

            migrationBuilder.UpdateData(
                table: "Breeds",
                keyColumn: "Id",
                keyValue: 108,
                column: "CreatedTime",
                value: new DateTime(2024, 8, 17, 3, 49, 5, 277, DateTimeKind.Local).AddTicks(4805));

            migrationBuilder.UpdateData(
                table: "Breeds",
                keyColumn: "Id",
                keyValue: 109,
                column: "CreatedTime",
                value: new DateTime(2024, 8, 17, 3, 49, 5, 277, DateTimeKind.Local).AddTicks(4807));

            migrationBuilder.UpdateData(
                table: "Breeds",
                keyColumn: "Id",
                keyValue: 110,
                column: "CreatedTime",
                value: new DateTime(2024, 8, 17, 3, 49, 5, 277, DateTimeKind.Local).AddTicks(4808));

            migrationBuilder.UpdateData(
                table: "Breeds",
                keyColumn: "Id",
                keyValue: 111,
                column: "CreatedTime",
                value: new DateTime(2024, 8, 17, 3, 49, 5, 277, DateTimeKind.Local).AddTicks(4809));

            migrationBuilder.UpdateData(
                table: "Breeds",
                keyColumn: "Id",
                keyValue: 112,
                column: "CreatedTime",
                value: new DateTime(2024, 8, 17, 3, 49, 5, 277, DateTimeKind.Local).AddTicks(4810));

            migrationBuilder.UpdateData(
                table: "Breeds",
                keyColumn: "Id",
                keyValue: 113,
                column: "CreatedTime",
                value: new DateTime(2024, 8, 17, 3, 49, 5, 277, DateTimeKind.Local).AddTicks(4812));

            migrationBuilder.UpdateData(
                table: "Breeds",
                keyColumn: "Id",
                keyValue: 114,
                column: "CreatedTime",
                value: new DateTime(2024, 8, 17, 3, 49, 5, 277, DateTimeKind.Local).AddTicks(4813));

            migrationBuilder.UpdateData(
                table: "Breeds",
                keyColumn: "Id",
                keyValue: 115,
                column: "CreatedTime",
                value: new DateTime(2024, 8, 17, 3, 49, 5, 277, DateTimeKind.Local).AddTicks(4814));

            migrationBuilder.UpdateData(
                table: "Breeds",
                keyColumn: "Id",
                keyValue: 116,
                column: "CreatedTime",
                value: new DateTime(2024, 8, 17, 3, 49, 5, 277, DateTimeKind.Local).AddTicks(4816));

            migrationBuilder.UpdateData(
                table: "Breeds",
                keyColumn: "Id",
                keyValue: 117,
                column: "CreatedTime",
                value: new DateTime(2024, 8, 17, 3, 49, 5, 277, DateTimeKind.Local).AddTicks(4817));

            migrationBuilder.UpdateData(
                table: "Breeds",
                keyColumn: "Id",
                keyValue: 118,
                column: "CreatedTime",
                value: new DateTime(2024, 8, 17, 3, 49, 5, 277, DateTimeKind.Local).AddTicks(4819));

            migrationBuilder.UpdateData(
                table: "Breeds",
                keyColumn: "Id",
                keyValue: 119,
                column: "CreatedTime",
                value: new DateTime(2024, 8, 17, 3, 49, 5, 277, DateTimeKind.Local).AddTicks(4820));

            migrationBuilder.UpdateData(
                table: "Breeds",
                keyColumn: "Id",
                keyValue: 120,
                column: "CreatedTime",
                value: new DateTime(2024, 8, 17, 3, 49, 5, 277, DateTimeKind.Local).AddTicks(4822));

            migrationBuilder.UpdateData(
                table: "Breeds",
                keyColumn: "Id",
                keyValue: 121,
                column: "CreatedTime",
                value: new DateTime(2024, 8, 17, 3, 49, 5, 277, DateTimeKind.Local).AddTicks(4823));

            migrationBuilder.UpdateData(
                table: "Breeds",
                keyColumn: "Id",
                keyValue: 122,
                column: "CreatedTime",
                value: new DateTime(2024, 8, 17, 3, 49, 5, 277, DateTimeKind.Local).AddTicks(4825));

            migrationBuilder.UpdateData(
                table: "Breeds",
                keyColumn: "Id",
                keyValue: 123,
                column: "CreatedTime",
                value: new DateTime(2024, 8, 17, 3, 49, 5, 277, DateTimeKind.Local).AddTicks(4826));

            migrationBuilder.UpdateData(
                table: "Breeds",
                keyColumn: "Id",
                keyValue: 124,
                column: "CreatedTime",
                value: new DateTime(2024, 8, 17, 3, 49, 5, 277, DateTimeKind.Local).AddTicks(4827));

            migrationBuilder.UpdateData(
                table: "Breeds",
                keyColumn: "Id",
                keyValue: 125,
                column: "CreatedTime",
                value: new DateTime(2024, 8, 17, 3, 49, 5, 277, DateTimeKind.Local).AddTicks(4829));

            migrationBuilder.UpdateData(
                table: "Breeds",
                keyColumn: "Id",
                keyValue: 126,
                column: "CreatedTime",
                value: new DateTime(2024, 8, 17, 3, 49, 5, 277, DateTimeKind.Local).AddTicks(4830));

            migrationBuilder.UpdateData(
                table: "Breeds",
                keyColumn: "Id",
                keyValue: 127,
                column: "CreatedTime",
                value: new DateTime(2024, 8, 17, 3, 49, 5, 277, DateTimeKind.Local).AddTicks(4831));

            migrationBuilder.UpdateData(
                table: "Breeds",
                keyColumn: "Id",
                keyValue: 128,
                column: "CreatedTime",
                value: new DateTime(2024, 8, 17, 3, 49, 5, 277, DateTimeKind.Local).AddTicks(4833));

            migrationBuilder.UpdateData(
                table: "Breeds",
                keyColumn: "Id",
                keyValue: 129,
                column: "CreatedTime",
                value: new DateTime(2024, 8, 17, 3, 49, 5, 277, DateTimeKind.Local).AddTicks(4834));

            migrationBuilder.UpdateData(
                table: "Breeds",
                keyColumn: "Id",
                keyValue: 130,
                column: "CreatedTime",
                value: new DateTime(2024, 8, 17, 3, 49, 5, 277, DateTimeKind.Local).AddTicks(4835));

            migrationBuilder.UpdateData(
                table: "Breeds",
                keyColumn: "Id",
                keyValue: 131,
                column: "CreatedTime",
                value: new DateTime(2024, 8, 17, 3, 49, 5, 277, DateTimeKind.Local).AddTicks(4837));

            migrationBuilder.UpdateData(
                table: "Breeds",
                keyColumn: "Id",
                keyValue: 132,
                column: "CreatedTime",
                value: new DateTime(2024, 8, 17, 3, 49, 5, 277, DateTimeKind.Local).AddTicks(4838));

            migrationBuilder.UpdateData(
                table: "Breeds",
                keyColumn: "Id",
                keyValue: 133,
                column: "CreatedTime",
                value: new DateTime(2024, 8, 17, 3, 49, 5, 277, DateTimeKind.Local).AddTicks(4839));

            migrationBuilder.UpdateData(
                table: "Breeds",
                keyColumn: "Id",
                keyValue: 134,
                column: "CreatedTime",
                value: new DateTime(2024, 8, 17, 3, 49, 5, 277, DateTimeKind.Local).AddTicks(4841));

            migrationBuilder.UpdateData(
                table: "Breeds",
                keyColumn: "Id",
                keyValue: 135,
                column: "CreatedTime",
                value: new DateTime(2024, 8, 17, 3, 49, 5, 277, DateTimeKind.Local).AddTicks(4842));

            migrationBuilder.UpdateData(
                table: "Breeds",
                keyColumn: "Id",
                keyValue: 136,
                column: "CreatedTime",
                value: new DateTime(2024, 8, 17, 3, 49, 5, 277, DateTimeKind.Local).AddTicks(4843));

            migrationBuilder.UpdateData(
                table: "Breeds",
                keyColumn: "Id",
                keyValue: 137,
                column: "CreatedTime",
                value: new DateTime(2024, 8, 17, 3, 49, 5, 277, DateTimeKind.Local).AddTicks(4845));

            migrationBuilder.UpdateData(
                table: "Breeds",
                keyColumn: "Id",
                keyValue: 138,
                column: "CreatedTime",
                value: new DateTime(2024, 8, 17, 3, 49, 5, 277, DateTimeKind.Local).AddTicks(4846));

            migrationBuilder.UpdateData(
                table: "Breeds",
                keyColumn: "Id",
                keyValue: 139,
                column: "CreatedTime",
                value: new DateTime(2024, 8, 17, 3, 49, 5, 277, DateTimeKind.Local).AddTicks(4848));

            migrationBuilder.UpdateData(
                table: "Breeds",
                keyColumn: "Id",
                keyValue: 140,
                column: "CreatedTime",
                value: new DateTime(2024, 8, 17, 3, 49, 5, 277, DateTimeKind.Local).AddTicks(4849));

            migrationBuilder.UpdateData(
                table: "Breeds",
                keyColumn: "Id",
                keyValue: 141,
                column: "CreatedTime",
                value: new DateTime(2024, 8, 17, 3, 49, 5, 277, DateTimeKind.Local).AddTicks(4851));

            migrationBuilder.UpdateData(
                table: "Breeds",
                keyColumn: "Id",
                keyValue: 142,
                column: "CreatedTime",
                value: new DateTime(2024, 8, 17, 3, 49, 5, 277, DateTimeKind.Local).AddTicks(4852));

            migrationBuilder.UpdateData(
                table: "Breeds",
                keyColumn: "Id",
                keyValue: 143,
                column: "CreatedTime",
                value: new DateTime(2024, 8, 17, 3, 49, 5, 277, DateTimeKind.Local).AddTicks(4853));

            migrationBuilder.UpdateData(
                table: "Breeds",
                keyColumn: "Id",
                keyValue: 144,
                column: "CreatedTime",
                value: new DateTime(2024, 8, 17, 3, 49, 5, 277, DateTimeKind.Local).AddTicks(4854));

            migrationBuilder.UpdateData(
                table: "Breeds",
                keyColumn: "Id",
                keyValue: 145,
                column: "CreatedTime",
                value: new DateTime(2024, 8, 17, 3, 49, 5, 277, DateTimeKind.Local).AddTicks(4856));

            migrationBuilder.UpdateData(
                table: "Breeds",
                keyColumn: "Id",
                keyValue: 146,
                column: "CreatedTime",
                value: new DateTime(2024, 8, 17, 3, 49, 5, 277, DateTimeKind.Local).AddTicks(4857));

            migrationBuilder.UpdateData(
                table: "Breeds",
                keyColumn: "Id",
                keyValue: 147,
                column: "CreatedTime",
                value: new DateTime(2024, 8, 17, 3, 49, 5, 277, DateTimeKind.Local).AddTicks(4858));

            migrationBuilder.UpdateData(
                table: "Breeds",
                keyColumn: "Id",
                keyValue: 148,
                column: "CreatedTime",
                value: new DateTime(2024, 8, 17, 3, 49, 5, 277, DateTimeKind.Local).AddTicks(4860));

            migrationBuilder.UpdateData(
                table: "Breeds",
                keyColumn: "Id",
                keyValue: 149,
                column: "CreatedTime",
                value: new DateTime(2024, 8, 17, 3, 49, 5, 277, DateTimeKind.Local).AddTicks(4861));

            migrationBuilder.UpdateData(
                table: "Breeds",
                keyColumn: "Id",
                keyValue: 150,
                column: "CreatedTime",
                value: new DateTime(2024, 8, 17, 3, 49, 5, 277, DateTimeKind.Local).AddTicks(4862));

            migrationBuilder.UpdateData(
                table: "Breeds",
                keyColumn: "Id",
                keyValue: 151,
                column: "CreatedTime",
                value: new DateTime(2024, 8, 17, 3, 49, 5, 277, DateTimeKind.Local).AddTicks(4864));

            migrationBuilder.UpdateData(
                table: "Breeds",
                keyColumn: "Id",
                keyValue: 152,
                column: "CreatedTime",
                value: new DateTime(2024, 8, 17, 3, 49, 5, 277, DateTimeKind.Local).AddTicks(4865));

            migrationBuilder.UpdateData(
                table: "Breeds",
                keyColumn: "Id",
                keyValue: 153,
                column: "CreatedTime",
                value: new DateTime(2024, 8, 17, 3, 49, 5, 277, DateTimeKind.Local).AddTicks(4866));

            migrationBuilder.UpdateData(
                table: "Breeds",
                keyColumn: "Id",
                keyValue: 154,
                column: "CreatedTime",
                value: new DateTime(2024, 8, 17, 3, 49, 5, 277, DateTimeKind.Local).AddTicks(4867));

            migrationBuilder.UpdateData(
                table: "Breeds",
                keyColumn: "Id",
                keyValue: 155,
                column: "CreatedTime",
                value: new DateTime(2024, 8, 17, 3, 49, 5, 277, DateTimeKind.Local).AddTicks(4869));

            migrationBuilder.UpdateData(
                table: "Breeds",
                keyColumn: "Id",
                keyValue: 156,
                column: "CreatedTime",
                value: new DateTime(2024, 8, 17, 3, 49, 5, 277, DateTimeKind.Local).AddTicks(4870));

            migrationBuilder.UpdateData(
                table: "Breeds",
                keyColumn: "Id",
                keyValue: 157,
                column: "CreatedTime",
                value: new DateTime(2024, 8, 17, 3, 49, 5, 277, DateTimeKind.Local).AddTicks(4871));

            migrationBuilder.UpdateData(
                table: "Breeds",
                keyColumn: "Id",
                keyValue: 158,
                column: "CreatedTime",
                value: new DateTime(2024, 8, 17, 3, 49, 5, 277, DateTimeKind.Local).AddTicks(4872));

            migrationBuilder.UpdateData(
                table: "Breeds",
                keyColumn: "Id",
                keyValue: 159,
                column: "CreatedTime",
                value: new DateTime(2024, 8, 17, 3, 49, 5, 277, DateTimeKind.Local).AddTicks(4874));

            migrationBuilder.UpdateData(
                table: "Breeds",
                keyColumn: "Id",
                keyValue: 160,
                column: "CreatedTime",
                value: new DateTime(2024, 8, 17, 3, 49, 5, 277, DateTimeKind.Local).AddTicks(4875));

            migrationBuilder.UpdateData(
                table: "PetTypes",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedTime",
                value: new DateTime(2024, 8, 17, 3, 49, 5, 277, DateTimeKind.Local).AddTicks(1924));

            migrationBuilder.UpdateData(
                table: "PetTypes",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreatedTime",
                value: new DateTime(2024, 8, 17, 3, 49, 5, 277, DateTimeKind.Local).AddTicks(1936));

            migrationBuilder.UpdateData(
                table: "PetTypes",
                keyColumn: "Id",
                keyValue: 3,
                column: "CreatedTime",
                value: new DateTime(2024, 8, 17, 3, 49, 5, 277, DateTimeKind.Local).AddTicks(1938));

            migrationBuilder.UpdateData(
                table: "PetTypes",
                keyColumn: "Id",
                keyValue: 4,
                column: "CreatedTime",
                value: new DateTime(2024, 8, 17, 3, 49, 5, 277, DateTimeKind.Local).AddTicks(1939));

            migrationBuilder.UpdateData(
                table: "PetTypes",
                keyColumn: "Id",
                keyValue: 5,
                column: "CreatedTime",
                value: new DateTime(2024, 8, 17, 3, 49, 5, 277, DateTimeKind.Local).AddTicks(1940));

            migrationBuilder.UpdateData(
                table: "PetTypes",
                keyColumn: "Id",
                keyValue: 6,
                column: "CreatedTime",
                value: new DateTime(2024, 8, 17, 3, 49, 5, 277, DateTimeKind.Local).AddTicks(1941));

            migrationBuilder.UpdateData(
                table: "PetTypes",
                keyColumn: "Id",
                keyValue: 7,
                column: "CreatedTime",
                value: new DateTime(2024, 8, 17, 3, 49, 5, 277, DateTimeKind.Local).AddTicks(1942));

            migrationBuilder.UpdateData(
                table: "PetTypes",
                keyColumn: "Id",
                keyValue: 8,
                column: "CreatedTime",
                value: new DateTime(2024, 8, 17, 3, 49, 5, 277, DateTimeKind.Local).AddTicks(1943));
        }
    }
}
