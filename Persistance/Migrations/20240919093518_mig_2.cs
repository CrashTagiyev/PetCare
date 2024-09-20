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
            migrationBuilder.AlterColumn<int>(
                name: "isAccepted",
                table: "Adoptions",
                type: "int",
                nullable: false,
                oldClrType: typeof(bool),
                oldType: "bit");

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: 2001,
                columns: new[] { "ConcurrencyStamp", "CreatedTime", "LastUpdatedTime", "RefreshTokenCreateTime" },
                values: new object[] { "5840b742-303b-4681-9e6d-c7105b2a130e", new DateTime(2023, 12, 19, 9, 35, 17, 827, DateTimeKind.Utc).AddTicks(9330), new DateTime(2024, 9, 19, 9, 35, 17, 827, DateTimeKind.Utc).AddTicks(9340), new DateTime(2024, 9, 19, 9, 35, 17, 827, DateTimeKind.Utc).AddTicks(9330) });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: 2002,
                columns: new[] { "ConcurrencyStamp", "CreatedTime", "LastUpdatedTime", "RefreshTokenCreateTime" },
                values: new object[] { "a105e56c-9ea0-45fc-b902-21fc380434c4", new DateTime(2023, 11, 19, 9, 35, 17, 827, DateTimeKind.Utc).AddTicks(9370), new DateTime(2024, 9, 19, 9, 35, 17, 827, DateTimeKind.Utc).AddTicks(9380), new DateTime(2024, 9, 19, 9, 35, 17, 827, DateTimeKind.Utc).AddTicks(9370) });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: 2003,
                columns: new[] { "ConcurrencyStamp", "CreatedTime", "LastUpdatedTime", "RefreshTokenCreateTime" },
                values: new object[] { "58f31219-0295-46cc-af11-d6ff2c514fdd", new DateTime(2024, 8, 19, 9, 35, 17, 827, DateTimeKind.Utc).AddTicks(9380), new DateTime(2024, 9, 19, 9, 35, 17, 827, DateTimeKind.Utc).AddTicks(9390), new DateTime(2024, 9, 19, 9, 35, 17, 827, DateTimeKind.Utc).AddTicks(9380) });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: 2004,
                columns: new[] { "ConcurrencyStamp", "CreatedTime", "LastUpdatedTime", "RefreshTokenCreateTime" },
                values: new object[] { "9ca313a7-1efa-4d0c-a571-8cab4c60b0e2", new DateTime(2023, 11, 19, 9, 35, 17, 827, DateTimeKind.Utc).AddTicks(9400), new DateTime(2024, 9, 19, 9, 35, 17, 827, DateTimeKind.Utc).AddTicks(9400), new DateTime(2024, 9, 19, 9, 35, 17, 827, DateTimeKind.Utc).AddTicks(9390) });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: 2005,
                columns: new[] { "ConcurrencyStamp", "CreatedTime", "LastUpdatedTime", "RefreshTokenCreateTime" },
                values: new object[] { "01a23e5c-bc81-4100-99e8-6c0095fa0968", new DateTime(2023, 12, 19, 9, 35, 17, 827, DateTimeKind.Utc).AddTicks(9410), new DateTime(2024, 9, 19, 9, 35, 17, 827, DateTimeKind.Utc).AddTicks(9410), new DateTime(2024, 9, 19, 9, 35, 17, 827, DateTimeKind.Utc).AddTicks(9400) });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: 2006,
                columns: new[] { "ConcurrencyStamp", "CreatedTime", "LastUpdatedTime", "RefreshTokenCreateTime" },
                values: new object[] { "053ef234-6204-47ec-9740-5a5a0e066978", new DateTime(2023, 12, 19, 9, 35, 17, 827, DateTimeKind.Utc).AddTicks(9410), new DateTime(2024, 9, 19, 9, 35, 17, 827, DateTimeKind.Utc).AddTicks(9410), new DateTime(2024, 9, 19, 9, 35, 17, 827, DateTimeKind.Utc).AddTicks(9410) });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: 2007,
                columns: new[] { "ConcurrencyStamp", "CreatedTime", "LastUpdatedTime", "RefreshTokenCreateTime" },
                values: new object[] { "21c22a26-c140-41c0-bad8-17aa471d78d6", new DateTime(2023, 11, 19, 9, 35, 17, 827, DateTimeKind.Utc).AddTicks(9420), new DateTime(2024, 9, 19, 9, 35, 17, 827, DateTimeKind.Utc).AddTicks(9420), new DateTime(2024, 9, 19, 9, 35, 17, 827, DateTimeKind.Utc).AddTicks(9420) });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: 2008,
                columns: new[] { "ConcurrencyStamp", "CreatedTime", "LastUpdatedTime", "RefreshTokenCreateTime" },
                values: new object[] { "0cb48252-6f92-4063-86cd-c830298f8bc5", new DateTime(2024, 7, 19, 9, 35, 17, 827, DateTimeKind.Utc).AddTicks(9430), new DateTime(2024, 9, 19, 9, 35, 17, 827, DateTimeKind.Utc).AddTicks(9430), new DateTime(2024, 9, 19, 9, 35, 17, 827, DateTimeKind.Utc).AddTicks(9430) });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: 2009,
                columns: new[] { "ConcurrencyStamp", "CreatedTime", "LastUpdatedTime", "RefreshTokenCreateTime" },
                values: new object[] { "b0bae16c-a553-4e16-bf5c-5c3694b6c31b", new DateTime(2023, 11, 19, 9, 35, 17, 827, DateTimeKind.Utc).AddTicks(9440), new DateTime(2024, 9, 19, 9, 35, 17, 827, DateTimeKind.Utc).AddTicks(9440), new DateTime(2024, 9, 19, 9, 35, 17, 827, DateTimeKind.Utc).AddTicks(9440) });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: 2010,
                columns: new[] { "ConcurrencyStamp", "CreatedTime", "LastUpdatedTime", "RefreshTokenCreateTime" },
                values: new object[] { "1279c15e-f14e-420e-98e7-08ec4b642a66", new DateTime(2024, 2, 19, 9, 35, 17, 827, DateTimeKind.Utc).AddTicks(9450), new DateTime(2024, 9, 19, 9, 35, 17, 827, DateTimeKind.Utc).AddTicks(9450), new DateTime(2024, 9, 19, 9, 35, 17, 827, DateTimeKind.Utc).AddTicks(9450) });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: 2011,
                columns: new[] { "ConcurrencyStamp", "CreatedTime", "LastUpdatedTime", "RefreshTokenCreateTime" },
                values: new object[] { "ecdbdb90-b9ed-4071-be24-cf8b3cb7f88d", new DateTime(2024, 6, 19, 9, 35, 17, 827, DateTimeKind.Utc).AddTicks(9460), new DateTime(2024, 9, 19, 9, 35, 17, 827, DateTimeKind.Utc).AddTicks(9460), new DateTime(2024, 9, 19, 9, 35, 17, 827, DateTimeKind.Utc).AddTicks(9460) });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: 2012,
                columns: new[] { "ConcurrencyStamp", "CreatedTime", "LastUpdatedTime", "RefreshTokenCreateTime" },
                values: new object[] { "7d2047ef-5b05-4d29-815d-b7e7b9fc4f7b", new DateTime(2024, 1, 19, 9, 35, 17, 827, DateTimeKind.Utc).AddTicks(9480), new DateTime(2024, 9, 19, 9, 35, 17, 827, DateTimeKind.Utc).AddTicks(9480), new DateTime(2024, 9, 19, 9, 35, 17, 827, DateTimeKind.Utc).AddTicks(9470) });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: 2013,
                columns: new[] { "ConcurrencyStamp", "CreatedTime", "LastUpdatedTime", "RefreshTokenCreateTime" },
                values: new object[] { "84f5e874-e352-429a-b7fa-c1aa94d85a41", new DateTime(2024, 7, 19, 9, 35, 17, 827, DateTimeKind.Utc).AddTicks(9490), new DateTime(2024, 9, 19, 9, 35, 17, 827, DateTimeKind.Utc).AddTicks(9490), new DateTime(2024, 9, 19, 9, 35, 17, 827, DateTimeKind.Utc).AddTicks(9480) });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: 2014,
                columns: new[] { "ConcurrencyStamp", "CreatedTime", "LastUpdatedTime", "RefreshTokenCreateTime" },
                values: new object[] { "5ceccb00-1de2-4161-ad4e-ad79fe1ee277", new DateTime(2024, 3, 19, 9, 35, 17, 827, DateTimeKind.Utc).AddTicks(9490), new DateTime(2024, 9, 19, 9, 35, 17, 827, DateTimeKind.Utc).AddTicks(9500), new DateTime(2024, 9, 19, 9, 35, 17, 827, DateTimeKind.Utc).AddTicks(9490) });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: 2015,
                columns: new[] { "ConcurrencyStamp", "CreatedTime", "LastUpdatedTime", "RefreshTokenCreateTime" },
                values: new object[] { "8e0b2877-6c29-4215-a979-01990b51aa48", new DateTime(2024, 2, 19, 9, 35, 17, 827, DateTimeKind.Utc).AddTicks(9500), new DateTime(2024, 9, 19, 9, 35, 17, 827, DateTimeKind.Utc).AddTicks(9500), new DateTime(2024, 9, 19, 9, 35, 17, 827, DateTimeKind.Utc).AddTicks(9500) });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: 2016,
                columns: new[] { "ConcurrencyStamp", "CreatedTime", "LastUpdatedTime", "RefreshTokenCreateTime" },
                values: new object[] { "da5f6c13-f8bf-4d22-950f-4a734d8cce4f", new DateTime(2024, 7, 19, 9, 35, 17, 827, DateTimeKind.Utc).AddTicks(9510), new DateTime(2024, 9, 19, 9, 35, 17, 827, DateTimeKind.Utc).AddTicks(9510), new DateTime(2024, 9, 19, 9, 35, 17, 827, DateTimeKind.Utc).AddTicks(9510) });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: 2017,
                columns: new[] { "ConcurrencyStamp", "CreatedTime", "LastUpdatedTime", "RefreshTokenCreateTime" },
                values: new object[] { "32783098-2813-4a31-a63d-72186f5f1733", new DateTime(2023, 11, 19, 9, 35, 17, 827, DateTimeKind.Utc).AddTicks(9520), new DateTime(2024, 9, 19, 9, 35, 17, 827, DateTimeKind.Utc).AddTicks(9520), new DateTime(2024, 9, 19, 9, 35, 17, 827, DateTimeKind.Utc).AddTicks(9520) });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: 2018,
                columns: new[] { "ConcurrencyStamp", "CreatedTime", "LastUpdatedTime", "RefreshTokenCreateTime" },
                values: new object[] { "d41e8cc4-166e-41f1-acb9-2a0de7084612", new DateTime(2023, 12, 19, 9, 35, 17, 827, DateTimeKind.Utc).AddTicks(9530), new DateTime(2024, 9, 19, 9, 35, 17, 827, DateTimeKind.Utc).AddTicks(9530), new DateTime(2024, 9, 19, 9, 35, 17, 827, DateTimeKind.Utc).AddTicks(9530) });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: 2019,
                columns: new[] { "ConcurrencyStamp", "CreatedTime", "LastUpdatedTime", "RefreshTokenCreateTime" },
                values: new object[] { "4c96cc62-fbbc-4016-a212-b0ee7723f4ba", new DateTime(2024, 1, 19, 9, 35, 17, 827, DateTimeKind.Utc).AddTicks(9540), new DateTime(2024, 9, 19, 9, 35, 17, 827, DateTimeKind.Utc).AddTicks(9540), new DateTime(2024, 9, 19, 9, 35, 17, 827, DateTimeKind.Utc).AddTicks(9540) });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: 2020,
                columns: new[] { "ConcurrencyStamp", "CreatedTime", "LastUpdatedTime", "RefreshTokenCreateTime" },
                values: new object[] { "8053a65d-4a80-4404-907f-856e4e5e3989", new DateTime(2024, 1, 19, 9, 35, 17, 827, DateTimeKind.Utc).AddTicks(9550), new DateTime(2024, 9, 19, 9, 35, 17, 827, DateTimeKind.Utc).AddTicks(9550), new DateTime(2024, 9, 19, 9, 35, 17, 827, DateTimeKind.Utc).AddTicks(9550) });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: 2021,
                columns: new[] { "ConcurrencyStamp", "CreatedTime", "LastUpdatedTime", "RefreshTokenCreateTime" },
                values: new object[] { "8a3894d0-d95b-42f4-a20a-39adf6926f8d", new DateTime(2023, 12, 19, 9, 35, 17, 827, DateTimeKind.Utc).AddTicks(9560), new DateTime(2024, 9, 19, 9, 35, 17, 827, DateTimeKind.Utc).AddTicks(9560), new DateTime(2024, 9, 19, 9, 35, 17, 827, DateTimeKind.Utc).AddTicks(9560) });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: 2022,
                columns: new[] { "ConcurrencyStamp", "CreatedTime", "LastUpdatedTime", "RefreshTokenCreateTime" },
                values: new object[] { "e244b237-9162-4266-bb82-06193b620504", new DateTime(2023, 12, 19, 9, 35, 17, 827, DateTimeKind.Utc).AddTicks(9590), new DateTime(2024, 9, 19, 9, 35, 17, 827, DateTimeKind.Utc).AddTicks(9590), new DateTime(2024, 9, 19, 9, 35, 17, 827, DateTimeKind.Utc).AddTicks(9590) });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: 2023,
                columns: new[] { "ConcurrencyStamp", "CreatedTime", "LastUpdatedTime", "RefreshTokenCreateTime" },
                values: new object[] { "2dc1cb1b-9b76-473e-ba41-dd806c104d44", new DateTime(2024, 4, 19, 9, 35, 17, 827, DateTimeKind.Utc).AddTicks(9600), new DateTime(2024, 9, 19, 9, 35, 17, 827, DateTimeKind.Utc).AddTicks(9600), new DateTime(2024, 9, 19, 9, 35, 17, 827, DateTimeKind.Utc).AddTicks(9600) });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: 2024,
                columns: new[] { "ConcurrencyStamp", "CreatedTime", "LastUpdatedTime", "RefreshTokenCreateTime" },
                values: new object[] { "34b4fc59-158a-4833-9406-da6d7dba4240", new DateTime(2024, 3, 19, 9, 35, 17, 827, DateTimeKind.Utc).AddTicks(9610), new DateTime(2024, 9, 19, 9, 35, 17, 827, DateTimeKind.Utc).AddTicks(9610), new DateTime(2024, 9, 19, 9, 35, 17, 827, DateTimeKind.Utc).AddTicks(9610) });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: 2025,
                columns: new[] { "ConcurrencyStamp", "CreatedTime", "LastUpdatedTime", "RefreshTokenCreateTime" },
                values: new object[] { "0e701468-88f4-415a-9759-0257918859a7", new DateTime(2024, 2, 19, 9, 35, 17, 827, DateTimeKind.Utc).AddTicks(9620), new DateTime(2024, 9, 19, 9, 35, 17, 827, DateTimeKind.Utc).AddTicks(9620), new DateTime(2024, 9, 19, 9, 35, 17, 827, DateTimeKind.Utc).AddTicks(9620) });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: 2026,
                columns: new[] { "ConcurrencyStamp", "CreatedTime", "LastUpdatedTime", "RefreshTokenCreateTime" },
                values: new object[] { "f2e6ebc2-5cc9-4fd9-9af5-b27901944560", new DateTime(2024, 6, 19, 9, 35, 17, 827, DateTimeKind.Utc).AddTicks(9630), new DateTime(2024, 9, 19, 9, 35, 17, 827, DateTimeKind.Utc).AddTicks(9630), new DateTime(2024, 9, 19, 9, 35, 17, 827, DateTimeKind.Utc).AddTicks(9630) });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: 2027,
                columns: new[] { "ConcurrencyStamp", "CreatedTime", "LastUpdatedTime", "RefreshTokenCreateTime" },
                values: new object[] { "c7b92d65-5f28-4268-87b4-1961be998c78", new DateTime(2024, 2, 19, 9, 35, 17, 827, DateTimeKind.Utc).AddTicks(9640), new DateTime(2024, 9, 19, 9, 35, 17, 827, DateTimeKind.Utc).AddTicks(9640), new DateTime(2024, 9, 19, 9, 35, 17, 827, DateTimeKind.Utc).AddTicks(9640) });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: 2028,
                columns: new[] { "ConcurrencyStamp", "CreatedTime", "LastUpdatedTime", "RefreshTokenCreateTime" },
                values: new object[] { "6a52b4b6-815f-4204-8301-744476fa3efb", new DateTime(2024, 4, 19, 9, 35, 17, 827, DateTimeKind.Utc).AddTicks(9650), new DateTime(2024, 9, 19, 9, 35, 17, 827, DateTimeKind.Utc).AddTicks(9650), new DateTime(2024, 9, 19, 9, 35, 17, 827, DateTimeKind.Utc).AddTicks(9650) });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: 2029,
                columns: new[] { "ConcurrencyStamp", "CreatedTime", "LastUpdatedTime", "RefreshTokenCreateTime" },
                values: new object[] { "c5850828-ba23-4ef5-8109-9779b547ef8d", new DateTime(2024, 5, 19, 9, 35, 17, 827, DateTimeKind.Utc).AddTicks(9660), new DateTime(2024, 9, 19, 9, 35, 17, 827, DateTimeKind.Utc).AddTicks(9660), new DateTime(2024, 9, 19, 9, 35, 17, 827, DateTimeKind.Utc).AddTicks(9660) });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: 2030,
                columns: new[] { "ConcurrencyStamp", "CreatedTime", "LastUpdatedTime", "RefreshTokenCreateTime" },
                values: new object[] { "5befcef0-d9e8-47b3-8206-bd1319449185", new DateTime(2023, 11, 19, 9, 35, 17, 827, DateTimeKind.Utc).AddTicks(9670), new DateTime(2024, 9, 19, 9, 35, 17, 827, DateTimeKind.Utc).AddTicks(9680), new DateTime(2024, 9, 19, 9, 35, 17, 827, DateTimeKind.Utc).AddTicks(9670) });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: 2031,
                columns: new[] { "ConcurrencyStamp", "CreatedTime", "LastUpdatedTime", "RefreshTokenCreateTime" },
                values: new object[] { "31e657f6-fff6-494e-a71b-dee96fe1446c", new DateTime(2023, 12, 19, 9, 35, 17, 827, DateTimeKind.Utc).AddTicks(9690), new DateTime(2024, 9, 19, 9, 35, 17, 827, DateTimeKind.Utc).AddTicks(9690), new DateTime(2024, 9, 19, 9, 35, 17, 827, DateTimeKind.Utc).AddTicks(9680) });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: 2032,
                columns: new[] { "ConcurrencyStamp", "CreatedTime", "LastUpdatedTime", "RefreshTokenCreateTime" },
                values: new object[] { "4b033389-8189-4be3-a465-6f8b122f3f56", new DateTime(2024, 6, 19, 9, 35, 17, 827, DateTimeKind.Utc).AddTicks(9700), new DateTime(2024, 9, 19, 9, 35, 17, 827, DateTimeKind.Utc).AddTicks(9700), new DateTime(2024, 9, 19, 9, 35, 17, 827, DateTimeKind.Utc).AddTicks(9690) });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: 2033,
                columns: new[] { "ConcurrencyStamp", "CreatedTime", "LastUpdatedTime", "RefreshTokenCreateTime" },
                values: new object[] { "4b7fbfa7-8917-4772-b091-d0dd2cf3c408", new DateTime(2024, 7, 19, 9, 35, 17, 827, DateTimeKind.Utc).AddTicks(9710), new DateTime(2024, 9, 19, 9, 35, 17, 827, DateTimeKind.Utc).AddTicks(9710), new DateTime(2024, 9, 19, 9, 35, 17, 827, DateTimeKind.Utc).AddTicks(9700) });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: 2034,
                columns: new[] { "ConcurrencyStamp", "CreatedTime", "LastUpdatedTime", "RefreshTokenCreateTime" },
                values: new object[] { "49468bb5-6042-4942-b144-3be5d880613d", new DateTime(2024, 3, 19, 9, 35, 17, 827, DateTimeKind.Utc).AddTicks(9720), new DateTime(2024, 9, 19, 9, 35, 17, 827, DateTimeKind.Utc).AddTicks(9720), new DateTime(2024, 9, 19, 9, 35, 17, 827, DateTimeKind.Utc).AddTicks(9710) });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: 2035,
                columns: new[] { "ConcurrencyStamp", "CreatedTime", "LastUpdatedTime", "RefreshTokenCreateTime" },
                values: new object[] { "182e18a7-7f46-437c-bb59-57b5720392d8", new DateTime(2024, 1, 19, 9, 35, 17, 827, DateTimeKind.Utc).AddTicks(9730), new DateTime(2024, 9, 19, 9, 35, 17, 827, DateTimeKind.Utc).AddTicks(9730), new DateTime(2024, 9, 19, 9, 35, 17, 827, DateTimeKind.Utc).AddTicks(9720) });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: 2036,
                columns: new[] { "ConcurrencyStamp", "CreatedTime", "LastUpdatedTime", "RefreshTokenCreateTime" },
                values: new object[] { "d6da7a1e-379e-4c9e-bea5-bb89601605b1", new DateTime(2024, 1, 19, 9, 35, 17, 827, DateTimeKind.Utc).AddTicks(9740), new DateTime(2024, 9, 19, 9, 35, 17, 827, DateTimeKind.Utc).AddTicks(9740), new DateTime(2024, 9, 19, 9, 35, 17, 827, DateTimeKind.Utc).AddTicks(9730) });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: 2037,
                columns: new[] { "ConcurrencyStamp", "CreatedTime", "LastUpdatedTime", "RefreshTokenCreateTime" },
                values: new object[] { "ba78c3fa-d5c6-4602-9467-a621a80087f5", new DateTime(2024, 3, 19, 9, 35, 17, 827, DateTimeKind.Utc).AddTicks(9750), new DateTime(2024, 9, 19, 9, 35, 17, 827, DateTimeKind.Utc).AddTicks(9750), new DateTime(2024, 9, 19, 9, 35, 17, 827, DateTimeKind.Utc).AddTicks(9740) });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: 2038,
                columns: new[] { "ConcurrencyStamp", "CreatedTime", "LastUpdatedTime", "RefreshTokenCreateTime" },
                values: new object[] { "e4cd5ddd-47d6-4be3-b396-df4b533b4ce7", new DateTime(2024, 6, 19, 9, 35, 17, 827, DateTimeKind.Utc).AddTicks(9760), new DateTime(2024, 9, 19, 9, 35, 17, 827, DateTimeKind.Utc).AddTicks(9760), new DateTime(2024, 9, 19, 9, 35, 17, 827, DateTimeKind.Utc).AddTicks(9750) });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: 2039,
                columns: new[] { "ConcurrencyStamp", "CreatedTime", "LastUpdatedTime", "RefreshTokenCreateTime" },
                values: new object[] { "b53de5b4-28ea-4dfb-b8c5-6e5f11455da8", new DateTime(2024, 1, 19, 9, 35, 17, 827, DateTimeKind.Utc).AddTicks(9780), new DateTime(2024, 9, 19, 9, 35, 17, 827, DateTimeKind.Utc).AddTicks(9780), new DateTime(2024, 9, 19, 9, 35, 17, 827, DateTimeKind.Utc).AddTicks(9780) });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: 2040,
                columns: new[] { "ConcurrencyStamp", "CreatedTime", "LastUpdatedTime", "RefreshTokenCreateTime" },
                values: new object[] { "139044d1-18e8-4b02-8972-978876683a33", new DateTime(2024, 6, 19, 9, 35, 17, 827, DateTimeKind.Utc).AddTicks(9790), new DateTime(2024, 9, 19, 9, 35, 17, 827, DateTimeKind.Utc).AddTicks(9790), new DateTime(2024, 9, 19, 9, 35, 17, 827, DateTimeKind.Utc).AddTicks(9790) });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: 2041,
                columns: new[] { "ConcurrencyStamp", "CreatedTime", "LastUpdatedTime", "RefreshTokenCreateTime" },
                values: new object[] { "5ca7552d-4817-4d6f-8d3b-bcda21be5f35", new DateTime(2023, 10, 19, 9, 35, 17, 827, DateTimeKind.Utc).AddTicks(9800), new DateTime(2024, 9, 19, 9, 35, 17, 827, DateTimeKind.Utc).AddTicks(9800), new DateTime(2024, 9, 19, 9, 35, 17, 827, DateTimeKind.Utc).AddTicks(9800) });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: 2042,
                columns: new[] { "ConcurrencyStamp", "CreatedTime", "LastUpdatedTime", "RefreshTokenCreateTime" },
                values: new object[] { "2fd69b9d-5d40-4dff-8419-6d11771af6c0", new DateTime(2023, 11, 19, 9, 35, 17, 827, DateTimeKind.Utc).AddTicks(9810), new DateTime(2024, 9, 19, 9, 35, 17, 827, DateTimeKind.Utc).AddTicks(9820), new DateTime(2024, 9, 19, 9, 35, 17, 827, DateTimeKind.Utc).AddTicks(9810) });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: 2043,
                columns: new[] { "ConcurrencyStamp", "CreatedTime", "LastUpdatedTime", "RefreshTokenCreateTime" },
                values: new object[] { "9ad7523e-38a2-491f-ab21-98b1e11a3b75", new DateTime(2024, 1, 19, 9, 35, 17, 827, DateTimeKind.Utc).AddTicks(9820), new DateTime(2024, 9, 19, 9, 35, 17, 827, DateTimeKind.Utc).AddTicks(9830), new DateTime(2024, 9, 19, 9, 35, 17, 827, DateTimeKind.Utc).AddTicks(9820) });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: 2044,
                columns: new[] { "ConcurrencyStamp", "CreatedTime", "LastUpdatedTime", "RefreshTokenCreateTime" },
                values: new object[] { "9e245f68-9f52-4fed-adc2-47f7e45aff2c", new DateTime(2023, 10, 19, 9, 35, 17, 827, DateTimeKind.Utc).AddTicks(9830), new DateTime(2024, 9, 19, 9, 35, 17, 827, DateTimeKind.Utc).AddTicks(9830), new DateTime(2024, 9, 19, 9, 35, 17, 827, DateTimeKind.Utc).AddTicks(9830) });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: 2045,
                columns: new[] { "ConcurrencyStamp", "CreatedTime", "LastUpdatedTime", "RefreshTokenCreateTime" },
                values: new object[] { "8e8bc71b-f5d0-4796-8b62-08980689f412", new DateTime(2024, 4, 19, 9, 35, 17, 827, DateTimeKind.Utc).AddTicks(9840), new DateTime(2024, 9, 19, 9, 35, 17, 827, DateTimeKind.Utc).AddTicks(9840), new DateTime(2024, 9, 19, 9, 35, 17, 827, DateTimeKind.Utc).AddTicks(9840) });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: 2046,
                columns: new[] { "ConcurrencyStamp", "CreatedTime", "LastUpdatedTime", "RefreshTokenCreateTime" },
                values: new object[] { "7f9bc9e3-8557-4641-b94b-6e19829f532c", new DateTime(2024, 1, 19, 9, 35, 17, 827, DateTimeKind.Utc).AddTicks(9850), new DateTime(2024, 9, 19, 9, 35, 17, 827, DateTimeKind.Utc).AddTicks(9850), new DateTime(2024, 9, 19, 9, 35, 17, 827, DateTimeKind.Utc).AddTicks(9850) });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: 2047,
                columns: new[] { "ConcurrencyStamp", "CreatedTime", "LastUpdatedTime", "RefreshTokenCreateTime" },
                values: new object[] { "c13b5417-43b8-4cfa-9c98-1f2bd528f8b7", new DateTime(2024, 6, 19, 9, 35, 17, 827, DateTimeKind.Utc).AddTicks(9860), new DateTime(2024, 9, 19, 9, 35, 17, 827, DateTimeKind.Utc).AddTicks(9860), new DateTime(2024, 9, 19, 9, 35, 17, 827, DateTimeKind.Utc).AddTicks(9860) });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: 2048,
                columns: new[] { "ConcurrencyStamp", "CreatedTime", "LastUpdatedTime", "RefreshTokenCreateTime" },
                values: new object[] { "01e5cb86-be24-4fb6-89ce-65167c0a1d69", new DateTime(2024, 1, 19, 9, 35, 17, 827, DateTimeKind.Utc).AddTicks(9870), new DateTime(2024, 9, 19, 9, 35, 17, 827, DateTimeKind.Utc).AddTicks(9870), new DateTime(2024, 9, 19, 9, 35, 17, 827, DateTimeKind.Utc).AddTicks(9870) });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: 2049,
                columns: new[] { "ConcurrencyStamp", "CreatedTime", "LastUpdatedTime", "RefreshTokenCreateTime" },
                values: new object[] { "46291cda-76f2-423f-a0c3-97659678db97", new DateTime(2024, 1, 19, 9, 35, 17, 827, DateTimeKind.Utc).AddTicks(9890), new DateTime(2024, 9, 19, 9, 35, 17, 827, DateTimeKind.Utc).AddTicks(9890), new DateTime(2024, 9, 19, 9, 35, 17, 827, DateTimeKind.Utc).AddTicks(9880) });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: 2050,
                columns: new[] { "ConcurrencyStamp", "CreatedTime", "LastUpdatedTime", "RefreshTokenCreateTime" },
                values: new object[] { "3f536ba1-4ccc-44fe-a82e-4d9dc76e7739", new DateTime(2024, 3, 19, 9, 35, 17, 827, DateTimeKind.Utc).AddTicks(9890), new DateTime(2024, 9, 19, 9, 35, 17, 827, DateTimeKind.Utc).AddTicks(9900), new DateTime(2024, 9, 19, 9, 35, 17, 827, DateTimeKind.Utc).AddTicks(9890) });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: 2051,
                columns: new[] { "ConcurrencyStamp", "CreatedTime", "LastUpdatedTime", "RefreshTokenCreateTime" },
                values: new object[] { "1380997b-dfe7-4759-97f9-fef614b75166", new DateTime(2024, 2, 19, 9, 35, 17, 827, DateTimeKind.Utc).AddTicks(9900), new DateTime(2024, 9, 19, 9, 35, 17, 827, DateTimeKind.Utc).AddTicks(9900), new DateTime(2024, 9, 19, 9, 35, 17, 827, DateTimeKind.Utc).AddTicks(9900) });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: 2052,
                columns: new[] { "ConcurrencyStamp", "CreatedTime", "LastUpdatedTime", "RefreshTokenCreateTime" },
                values: new object[] { "24dd77f1-466b-46aa-bbbb-a3a50f8581d1", new DateTime(2024, 1, 19, 9, 35, 17, 827, DateTimeKind.Utc).AddTicks(9910), new DateTime(2024, 9, 19, 9, 35, 17, 827, DateTimeKind.Utc).AddTicks(9910), new DateTime(2024, 9, 19, 9, 35, 17, 827, DateTimeKind.Utc).AddTicks(9910) });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: 2053,
                columns: new[] { "ConcurrencyStamp", "CreatedTime", "LastUpdatedTime", "RefreshTokenCreateTime" },
                values: new object[] { "5d3558d1-6929-41d3-8a34-68b98372929d", new DateTime(2024, 6, 19, 9, 35, 17, 827, DateTimeKind.Utc).AddTicks(9920), new DateTime(2024, 9, 19, 9, 35, 17, 827, DateTimeKind.Utc).AddTicks(9920), new DateTime(2024, 9, 19, 9, 35, 17, 827, DateTimeKind.Utc).AddTicks(9920) });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: 2054,
                columns: new[] { "ConcurrencyStamp", "CreatedTime", "LastUpdatedTime", "RefreshTokenCreateTime" },
                values: new object[] { "0f8ecba3-16c7-497f-a8e9-822c7ec3774d", new DateTime(2023, 10, 19, 9, 35, 17, 827, DateTimeKind.Utc).AddTicks(9930), new DateTime(2024, 9, 19, 9, 35, 17, 827, DateTimeKind.Utc).AddTicks(9930), new DateTime(2024, 9, 19, 9, 35, 17, 827, DateTimeKind.Utc).AddTicks(9930) });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: 2055,
                columns: new[] { "ConcurrencyStamp", "CreatedTime", "LastUpdatedTime", "RefreshTokenCreateTime" },
                values: new object[] { "68fe1880-20e3-4650-bd7f-13adbbfafb26", new DateTime(2024, 8, 19, 9, 35, 17, 827, DateTimeKind.Utc).AddTicks(9940), new DateTime(2024, 9, 19, 9, 35, 17, 827, DateTimeKind.Utc).AddTicks(9940), new DateTime(2024, 9, 19, 9, 35, 17, 827, DateTimeKind.Utc).AddTicks(9940) });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: 2056,
                columns: new[] { "ConcurrencyStamp", "CreatedTime", "LastUpdatedTime", "RefreshTokenCreateTime" },
                values: new object[] { "7bbe41f4-1945-400d-aa99-0e9eeaa84562", new DateTime(2024, 7, 19, 9, 35, 17, 827, DateTimeKind.Utc).AddTicks(9950), new DateTime(2024, 9, 19, 9, 35, 17, 827, DateTimeKind.Utc).AddTicks(9950), new DateTime(2024, 9, 19, 9, 35, 17, 827, DateTimeKind.Utc).AddTicks(9950) });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: 2057,
                columns: new[] { "ConcurrencyStamp", "CreatedTime", "LastUpdatedTime", "RefreshTokenCreateTime" },
                values: new object[] { "e97fcbf0-b51d-4de5-b4be-2ba981a228e3", new DateTime(2023, 10, 19, 9, 35, 17, 827, DateTimeKind.Utc).AddTicks(9960), new DateTime(2024, 9, 19, 9, 35, 17, 827, DateTimeKind.Utc).AddTicks(9960), new DateTime(2024, 9, 19, 9, 35, 17, 827, DateTimeKind.Utc).AddTicks(9960) });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: 2058,
                columns: new[] { "ConcurrencyStamp", "CreatedTime", "LastUpdatedTime", "RefreshTokenCreateTime" },
                values: new object[] { "05198463-80e3-447c-87fa-82b22e779ff9", new DateTime(2024, 4, 19, 9, 35, 17, 827, DateTimeKind.Utc).AddTicks(9970), new DateTime(2024, 9, 19, 9, 35, 17, 827, DateTimeKind.Utc).AddTicks(9970), new DateTime(2024, 9, 19, 9, 35, 17, 827, DateTimeKind.Utc).AddTicks(9970) });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: 2059,
                columns: new[] { "ConcurrencyStamp", "CreatedTime", "LastUpdatedTime", "RefreshTokenCreateTime" },
                values: new object[] { "278dfbf1-dc6f-4e73-849c-324f00264a51", new DateTime(2023, 11, 19, 9, 35, 17, 827, DateTimeKind.Utc).AddTicks(9990), new DateTime(2024, 9, 19, 9, 35, 17, 827, DateTimeKind.Utc).AddTicks(9990), new DateTime(2024, 9, 19, 9, 35, 17, 827, DateTimeKind.Utc).AddTicks(9990) });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: 2060,
                columns: new[] { "ConcurrencyStamp", "CreatedTime", "LastUpdatedTime", "RefreshTokenCreateTime" },
                values: new object[] { "a13d2f49-6a74-47db-b153-bf6272b21415", new DateTime(2024, 5, 19, 9, 35, 17, 828, DateTimeKind.Utc), new DateTime(2024, 9, 19, 9, 35, 17, 828, DateTimeKind.Utc), new DateTime(2024, 9, 19, 9, 35, 17, 828, DateTimeKind.Utc) });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: 9999,
                columns: new[] { "ConcurrencyStamp", "CreatedTime", "LastUpdatedTime", "RefreshTokenCreateTime" },
                values: new object[] { "aee8763e-fd30-4167-8165-96889e53cb0a", new DateTime(2024, 9, 19, 9, 35, 17, 827, DateTimeKind.Utc).AddTicks(9310), new DateTime(2024, 9, 19, 9, 35, 17, 827, DateTimeKind.Utc).AddTicks(9310), new DateTime(2024, 9, 19, 9, 35, 17, 827, DateTimeKind.Utc).AddTicks(9280) });

            migrationBuilder.UpdateData(
                table: "Breeds",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedTime",
                value: new DateTime(2024, 9, 19, 13, 35, 17, 826, DateTimeKind.Local).AddTicks(4000));

            migrationBuilder.UpdateData(
                table: "Breeds",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreatedTime",
                value: new DateTime(2024, 9, 19, 13, 35, 17, 826, DateTimeKind.Local).AddTicks(4000));

            migrationBuilder.UpdateData(
                table: "Breeds",
                keyColumn: "Id",
                keyValue: 3,
                column: "CreatedTime",
                value: new DateTime(2024, 9, 19, 13, 35, 17, 826, DateTimeKind.Local).AddTicks(4000));

            migrationBuilder.UpdateData(
                table: "Breeds",
                keyColumn: "Id",
                keyValue: 4,
                column: "CreatedTime",
                value: new DateTime(2024, 9, 19, 13, 35, 17, 826, DateTimeKind.Local).AddTicks(4010));

            migrationBuilder.UpdateData(
                table: "Breeds",
                keyColumn: "Id",
                keyValue: 5,
                column: "CreatedTime",
                value: new DateTime(2024, 9, 19, 13, 35, 17, 826, DateTimeKind.Local).AddTicks(4010));

            migrationBuilder.UpdateData(
                table: "Breeds",
                keyColumn: "Id",
                keyValue: 6,
                column: "CreatedTime",
                value: new DateTime(2024, 9, 19, 13, 35, 17, 826, DateTimeKind.Local).AddTicks(4010));

            migrationBuilder.UpdateData(
                table: "Breeds",
                keyColumn: "Id",
                keyValue: 7,
                column: "CreatedTime",
                value: new DateTime(2024, 9, 19, 13, 35, 17, 826, DateTimeKind.Local).AddTicks(4010));

            migrationBuilder.UpdateData(
                table: "Breeds",
                keyColumn: "Id",
                keyValue: 8,
                column: "CreatedTime",
                value: new DateTime(2024, 9, 19, 13, 35, 17, 826, DateTimeKind.Local).AddTicks(4010));

            migrationBuilder.UpdateData(
                table: "Breeds",
                keyColumn: "Id",
                keyValue: 9,
                column: "CreatedTime",
                value: new DateTime(2024, 9, 19, 13, 35, 17, 826, DateTimeKind.Local).AddTicks(4010));

            migrationBuilder.UpdateData(
                table: "Breeds",
                keyColumn: "Id",
                keyValue: 10,
                column: "CreatedTime",
                value: new DateTime(2024, 9, 19, 13, 35, 17, 826, DateTimeKind.Local).AddTicks(4020));

            migrationBuilder.UpdateData(
                table: "Breeds",
                keyColumn: "Id",
                keyValue: 11,
                column: "CreatedTime",
                value: new DateTime(2024, 9, 19, 13, 35, 17, 826, DateTimeKind.Local).AddTicks(4020));

            migrationBuilder.UpdateData(
                table: "Breeds",
                keyColumn: "Id",
                keyValue: 12,
                column: "CreatedTime",
                value: new DateTime(2024, 9, 19, 13, 35, 17, 826, DateTimeKind.Local).AddTicks(4020));

            migrationBuilder.UpdateData(
                table: "Breeds",
                keyColumn: "Id",
                keyValue: 13,
                column: "CreatedTime",
                value: new DateTime(2024, 9, 19, 13, 35, 17, 826, DateTimeKind.Local).AddTicks(4020));

            migrationBuilder.UpdateData(
                table: "Breeds",
                keyColumn: "Id",
                keyValue: 14,
                column: "CreatedTime",
                value: new DateTime(2024, 9, 19, 13, 35, 17, 826, DateTimeKind.Local).AddTicks(4020));

            migrationBuilder.UpdateData(
                table: "Breeds",
                keyColumn: "Id",
                keyValue: 15,
                column: "CreatedTime",
                value: new DateTime(2024, 9, 19, 13, 35, 17, 826, DateTimeKind.Local).AddTicks(4020));

            migrationBuilder.UpdateData(
                table: "Breeds",
                keyColumn: "Id",
                keyValue: 16,
                column: "CreatedTime",
                value: new DateTime(2024, 9, 19, 13, 35, 17, 826, DateTimeKind.Local).AddTicks(4020));

            migrationBuilder.UpdateData(
                table: "Breeds",
                keyColumn: "Id",
                keyValue: 17,
                column: "CreatedTime",
                value: new DateTime(2024, 9, 19, 13, 35, 17, 826, DateTimeKind.Local).AddTicks(4030));

            migrationBuilder.UpdateData(
                table: "Breeds",
                keyColumn: "Id",
                keyValue: 18,
                column: "CreatedTime",
                value: new DateTime(2024, 9, 19, 13, 35, 17, 826, DateTimeKind.Local).AddTicks(4030));

            migrationBuilder.UpdateData(
                table: "Breeds",
                keyColumn: "Id",
                keyValue: 19,
                column: "CreatedTime",
                value: new DateTime(2024, 9, 19, 13, 35, 17, 826, DateTimeKind.Local).AddTicks(4030));

            migrationBuilder.UpdateData(
                table: "Breeds",
                keyColumn: "Id",
                keyValue: 20,
                column: "CreatedTime",
                value: new DateTime(2024, 9, 19, 13, 35, 17, 826, DateTimeKind.Local).AddTicks(4030));

            migrationBuilder.UpdateData(
                table: "Breeds",
                keyColumn: "Id",
                keyValue: 21,
                column: "CreatedTime",
                value: new DateTime(2024, 9, 19, 13, 35, 17, 826, DateTimeKind.Local).AddTicks(4030));

            migrationBuilder.UpdateData(
                table: "Breeds",
                keyColumn: "Id",
                keyValue: 22,
                column: "CreatedTime",
                value: new DateTime(2024, 9, 19, 13, 35, 17, 826, DateTimeKind.Local).AddTicks(4030));

            migrationBuilder.UpdateData(
                table: "Breeds",
                keyColumn: "Id",
                keyValue: 23,
                column: "CreatedTime",
                value: new DateTime(2024, 9, 19, 13, 35, 17, 826, DateTimeKind.Local).AddTicks(4040));

            migrationBuilder.UpdateData(
                table: "Breeds",
                keyColumn: "Id",
                keyValue: 24,
                column: "CreatedTime",
                value: new DateTime(2024, 9, 19, 13, 35, 17, 826, DateTimeKind.Local).AddTicks(4040));

            migrationBuilder.UpdateData(
                table: "Breeds",
                keyColumn: "Id",
                keyValue: 25,
                column: "CreatedTime",
                value: new DateTime(2024, 9, 19, 13, 35, 17, 826, DateTimeKind.Local).AddTicks(4040));

            migrationBuilder.UpdateData(
                table: "Breeds",
                keyColumn: "Id",
                keyValue: 26,
                column: "CreatedTime",
                value: new DateTime(2024, 9, 19, 13, 35, 17, 826, DateTimeKind.Local).AddTicks(4040));

            migrationBuilder.UpdateData(
                table: "Breeds",
                keyColumn: "Id",
                keyValue: 27,
                column: "CreatedTime",
                value: new DateTime(2024, 9, 19, 13, 35, 17, 826, DateTimeKind.Local).AddTicks(4040));

            migrationBuilder.UpdateData(
                table: "Breeds",
                keyColumn: "Id",
                keyValue: 28,
                column: "CreatedTime",
                value: new DateTime(2024, 9, 19, 13, 35, 17, 826, DateTimeKind.Local).AddTicks(4040));

            migrationBuilder.UpdateData(
                table: "Breeds",
                keyColumn: "Id",
                keyValue: 29,
                column: "CreatedTime",
                value: new DateTime(2024, 9, 19, 13, 35, 17, 826, DateTimeKind.Local).AddTicks(4040));

            migrationBuilder.UpdateData(
                table: "Breeds",
                keyColumn: "Id",
                keyValue: 30,
                column: "CreatedTime",
                value: new DateTime(2024, 9, 19, 13, 35, 17, 826, DateTimeKind.Local).AddTicks(4050));

            migrationBuilder.UpdateData(
                table: "Breeds",
                keyColumn: "Id",
                keyValue: 31,
                column: "CreatedTime",
                value: new DateTime(2024, 9, 19, 13, 35, 17, 826, DateTimeKind.Local).AddTicks(4050));

            migrationBuilder.UpdateData(
                table: "Breeds",
                keyColumn: "Id",
                keyValue: 32,
                column: "CreatedTime",
                value: new DateTime(2024, 9, 19, 13, 35, 17, 826, DateTimeKind.Local).AddTicks(4050));

            migrationBuilder.UpdateData(
                table: "Breeds",
                keyColumn: "Id",
                keyValue: 33,
                column: "CreatedTime",
                value: new DateTime(2024, 9, 19, 13, 35, 17, 826, DateTimeKind.Local).AddTicks(4050));

            migrationBuilder.UpdateData(
                table: "Breeds",
                keyColumn: "Id",
                keyValue: 34,
                column: "CreatedTime",
                value: new DateTime(2024, 9, 19, 13, 35, 17, 826, DateTimeKind.Local).AddTicks(4050));

            migrationBuilder.UpdateData(
                table: "Breeds",
                keyColumn: "Id",
                keyValue: 35,
                column: "CreatedTime",
                value: new DateTime(2024, 9, 19, 13, 35, 17, 826, DateTimeKind.Local).AddTicks(4050));

            migrationBuilder.UpdateData(
                table: "Breeds",
                keyColumn: "Id",
                keyValue: 36,
                column: "CreatedTime",
                value: new DateTime(2024, 9, 19, 13, 35, 17, 826, DateTimeKind.Local).AddTicks(4060));

            migrationBuilder.UpdateData(
                table: "Breeds",
                keyColumn: "Id",
                keyValue: 37,
                column: "CreatedTime",
                value: new DateTime(2024, 9, 19, 13, 35, 17, 826, DateTimeKind.Local).AddTicks(4060));

            migrationBuilder.UpdateData(
                table: "Breeds",
                keyColumn: "Id",
                keyValue: 38,
                column: "CreatedTime",
                value: new DateTime(2024, 9, 19, 13, 35, 17, 826, DateTimeKind.Local).AddTicks(4060));

            migrationBuilder.UpdateData(
                table: "Breeds",
                keyColumn: "Id",
                keyValue: 39,
                column: "CreatedTime",
                value: new DateTime(2024, 9, 19, 13, 35, 17, 826, DateTimeKind.Local).AddTicks(4060));

            migrationBuilder.UpdateData(
                table: "Breeds",
                keyColumn: "Id",
                keyValue: 40,
                column: "CreatedTime",
                value: new DateTime(2024, 9, 19, 13, 35, 17, 826, DateTimeKind.Local).AddTicks(4060));

            migrationBuilder.UpdateData(
                table: "Breeds",
                keyColumn: "Id",
                keyValue: 41,
                column: "CreatedTime",
                value: new DateTime(2024, 9, 19, 13, 35, 17, 826, DateTimeKind.Local).AddTicks(4060));

            migrationBuilder.UpdateData(
                table: "Breeds",
                keyColumn: "Id",
                keyValue: 42,
                column: "CreatedTime",
                value: new DateTime(2024, 9, 19, 13, 35, 17, 826, DateTimeKind.Local).AddTicks(4060));

            migrationBuilder.UpdateData(
                table: "Breeds",
                keyColumn: "Id",
                keyValue: 43,
                column: "CreatedTime",
                value: new DateTime(2024, 9, 19, 13, 35, 17, 826, DateTimeKind.Local).AddTicks(4070));

            migrationBuilder.UpdateData(
                table: "Breeds",
                keyColumn: "Id",
                keyValue: 44,
                column: "CreatedTime",
                value: new DateTime(2024, 9, 19, 13, 35, 17, 826, DateTimeKind.Local).AddTicks(4070));

            migrationBuilder.UpdateData(
                table: "Breeds",
                keyColumn: "Id",
                keyValue: 45,
                column: "CreatedTime",
                value: new DateTime(2024, 9, 19, 13, 35, 17, 826, DateTimeKind.Local).AddTicks(4070));

            migrationBuilder.UpdateData(
                table: "Breeds",
                keyColumn: "Id",
                keyValue: 46,
                column: "CreatedTime",
                value: new DateTime(2024, 9, 19, 13, 35, 17, 826, DateTimeKind.Local).AddTicks(4070));

            migrationBuilder.UpdateData(
                table: "Breeds",
                keyColumn: "Id",
                keyValue: 47,
                column: "CreatedTime",
                value: new DateTime(2024, 9, 19, 13, 35, 17, 826, DateTimeKind.Local).AddTicks(4070));

            migrationBuilder.UpdateData(
                table: "Breeds",
                keyColumn: "Id",
                keyValue: 48,
                column: "CreatedTime",
                value: new DateTime(2024, 9, 19, 13, 35, 17, 826, DateTimeKind.Local).AddTicks(4070));

            migrationBuilder.UpdateData(
                table: "Breeds",
                keyColumn: "Id",
                keyValue: 49,
                column: "CreatedTime",
                value: new DateTime(2024, 9, 19, 13, 35, 17, 826, DateTimeKind.Local).AddTicks(4080));

            migrationBuilder.UpdateData(
                table: "Breeds",
                keyColumn: "Id",
                keyValue: 50,
                column: "CreatedTime",
                value: new DateTime(2024, 9, 19, 13, 35, 17, 826, DateTimeKind.Local).AddTicks(4080));

            migrationBuilder.UpdateData(
                table: "Breeds",
                keyColumn: "Id",
                keyValue: 51,
                column: "CreatedTime",
                value: new DateTime(2024, 9, 19, 13, 35, 17, 826, DateTimeKind.Local).AddTicks(4080));

            migrationBuilder.UpdateData(
                table: "Breeds",
                keyColumn: "Id",
                keyValue: 52,
                column: "CreatedTime",
                value: new DateTime(2024, 9, 19, 13, 35, 17, 826, DateTimeKind.Local).AddTicks(4080));

            migrationBuilder.UpdateData(
                table: "Breeds",
                keyColumn: "Id",
                keyValue: 53,
                column: "CreatedTime",
                value: new DateTime(2024, 9, 19, 13, 35, 17, 826, DateTimeKind.Local).AddTicks(4080));

            migrationBuilder.UpdateData(
                table: "Breeds",
                keyColumn: "Id",
                keyValue: 54,
                column: "CreatedTime",
                value: new DateTime(2024, 9, 19, 13, 35, 17, 826, DateTimeKind.Local).AddTicks(4080));

            migrationBuilder.UpdateData(
                table: "Breeds",
                keyColumn: "Id",
                keyValue: 55,
                column: "CreatedTime",
                value: new DateTime(2024, 9, 19, 13, 35, 17, 826, DateTimeKind.Local).AddTicks(4080));

            migrationBuilder.UpdateData(
                table: "Breeds",
                keyColumn: "Id",
                keyValue: 56,
                column: "CreatedTime",
                value: new DateTime(2024, 9, 19, 13, 35, 17, 826, DateTimeKind.Local).AddTicks(4090));

            migrationBuilder.UpdateData(
                table: "Breeds",
                keyColumn: "Id",
                keyValue: 57,
                column: "CreatedTime",
                value: new DateTime(2024, 9, 19, 13, 35, 17, 826, DateTimeKind.Local).AddTicks(4090));

            migrationBuilder.UpdateData(
                table: "Breeds",
                keyColumn: "Id",
                keyValue: 58,
                column: "CreatedTime",
                value: new DateTime(2024, 9, 19, 13, 35, 17, 826, DateTimeKind.Local).AddTicks(4090));

            migrationBuilder.UpdateData(
                table: "Breeds",
                keyColumn: "Id",
                keyValue: 59,
                column: "CreatedTime",
                value: new DateTime(2024, 9, 19, 13, 35, 17, 826, DateTimeKind.Local).AddTicks(4090));

            migrationBuilder.UpdateData(
                table: "Breeds",
                keyColumn: "Id",
                keyValue: 60,
                column: "CreatedTime",
                value: new DateTime(2024, 9, 19, 13, 35, 17, 826, DateTimeKind.Local).AddTicks(4090));

            migrationBuilder.UpdateData(
                table: "Breeds",
                keyColumn: "Id",
                keyValue: 61,
                column: "CreatedTime",
                value: new DateTime(2024, 9, 19, 13, 35, 17, 826, DateTimeKind.Local).AddTicks(4090));

            migrationBuilder.UpdateData(
                table: "Breeds",
                keyColumn: "Id",
                keyValue: 62,
                column: "CreatedTime",
                value: new DateTime(2024, 9, 19, 13, 35, 17, 826, DateTimeKind.Local).AddTicks(4090));

            migrationBuilder.UpdateData(
                table: "Breeds",
                keyColumn: "Id",
                keyValue: 63,
                column: "CreatedTime",
                value: new DateTime(2024, 9, 19, 13, 35, 17, 826, DateTimeKind.Local).AddTicks(4100));

            migrationBuilder.UpdateData(
                table: "Breeds",
                keyColumn: "Id",
                keyValue: 64,
                column: "CreatedTime",
                value: new DateTime(2024, 9, 19, 13, 35, 17, 826, DateTimeKind.Local).AddTicks(4100));

            migrationBuilder.UpdateData(
                table: "Breeds",
                keyColumn: "Id",
                keyValue: 65,
                column: "CreatedTime",
                value: new DateTime(2024, 9, 19, 13, 35, 17, 826, DateTimeKind.Local).AddTicks(4100));

            migrationBuilder.UpdateData(
                table: "Breeds",
                keyColumn: "Id",
                keyValue: 66,
                column: "CreatedTime",
                value: new DateTime(2024, 9, 19, 13, 35, 17, 826, DateTimeKind.Local).AddTicks(4100));

            migrationBuilder.UpdateData(
                table: "Breeds",
                keyColumn: "Id",
                keyValue: 67,
                column: "CreatedTime",
                value: new DateTime(2024, 9, 19, 13, 35, 17, 826, DateTimeKind.Local).AddTicks(4100));

            migrationBuilder.UpdateData(
                table: "Breeds",
                keyColumn: "Id",
                keyValue: 68,
                column: "CreatedTime",
                value: new DateTime(2024, 9, 19, 13, 35, 17, 826, DateTimeKind.Local).AddTicks(4100));

            migrationBuilder.UpdateData(
                table: "Breeds",
                keyColumn: "Id",
                keyValue: 69,
                column: "CreatedTime",
                value: new DateTime(2024, 9, 19, 13, 35, 17, 826, DateTimeKind.Local).AddTicks(4110));

            migrationBuilder.UpdateData(
                table: "Breeds",
                keyColumn: "Id",
                keyValue: 70,
                column: "CreatedTime",
                value: new DateTime(2024, 9, 19, 13, 35, 17, 826, DateTimeKind.Local).AddTicks(4110));

            migrationBuilder.UpdateData(
                table: "Breeds",
                keyColumn: "Id",
                keyValue: 71,
                column: "CreatedTime",
                value: new DateTime(2024, 9, 19, 13, 35, 17, 826, DateTimeKind.Local).AddTicks(4110));

            migrationBuilder.UpdateData(
                table: "Breeds",
                keyColumn: "Id",
                keyValue: 72,
                column: "CreatedTime",
                value: new DateTime(2024, 9, 19, 13, 35, 17, 826, DateTimeKind.Local).AddTicks(4110));

            migrationBuilder.UpdateData(
                table: "Breeds",
                keyColumn: "Id",
                keyValue: 73,
                column: "CreatedTime",
                value: new DateTime(2024, 9, 19, 13, 35, 17, 826, DateTimeKind.Local).AddTicks(4110));

            migrationBuilder.UpdateData(
                table: "Breeds",
                keyColumn: "Id",
                keyValue: 74,
                column: "CreatedTime",
                value: new DateTime(2024, 9, 19, 13, 35, 17, 826, DateTimeKind.Local).AddTicks(4110));

            migrationBuilder.UpdateData(
                table: "Breeds",
                keyColumn: "Id",
                keyValue: 75,
                column: "CreatedTime",
                value: new DateTime(2024, 9, 19, 13, 35, 17, 826, DateTimeKind.Local).AddTicks(4110));

            migrationBuilder.UpdateData(
                table: "Breeds",
                keyColumn: "Id",
                keyValue: 76,
                column: "CreatedTime",
                value: new DateTime(2024, 9, 19, 13, 35, 17, 826, DateTimeKind.Local).AddTicks(4120));

            migrationBuilder.UpdateData(
                table: "Breeds",
                keyColumn: "Id",
                keyValue: 77,
                column: "CreatedTime",
                value: new DateTime(2024, 9, 19, 13, 35, 17, 826, DateTimeKind.Local).AddTicks(4120));

            migrationBuilder.UpdateData(
                table: "Breeds",
                keyColumn: "Id",
                keyValue: 78,
                column: "CreatedTime",
                value: new DateTime(2024, 9, 19, 13, 35, 17, 826, DateTimeKind.Local).AddTicks(4120));

            migrationBuilder.UpdateData(
                table: "Breeds",
                keyColumn: "Id",
                keyValue: 79,
                column: "CreatedTime",
                value: new DateTime(2024, 9, 19, 13, 35, 17, 826, DateTimeKind.Local).AddTicks(4120));

            migrationBuilder.UpdateData(
                table: "Breeds",
                keyColumn: "Id",
                keyValue: 80,
                column: "CreatedTime",
                value: new DateTime(2024, 9, 19, 13, 35, 17, 826, DateTimeKind.Local).AddTicks(4120));

            migrationBuilder.UpdateData(
                table: "Breeds",
                keyColumn: "Id",
                keyValue: 81,
                column: "CreatedTime",
                value: new DateTime(2024, 9, 19, 13, 35, 17, 826, DateTimeKind.Local).AddTicks(4120));

            migrationBuilder.UpdateData(
                table: "Breeds",
                keyColumn: "Id",
                keyValue: 82,
                column: "CreatedTime",
                value: new DateTime(2024, 9, 19, 13, 35, 17, 826, DateTimeKind.Local).AddTicks(4120));

            migrationBuilder.UpdateData(
                table: "Breeds",
                keyColumn: "Id",
                keyValue: 83,
                column: "CreatedTime",
                value: new DateTime(2024, 9, 19, 13, 35, 17, 826, DateTimeKind.Local).AddTicks(4130));

            migrationBuilder.UpdateData(
                table: "Breeds",
                keyColumn: "Id",
                keyValue: 84,
                column: "CreatedTime",
                value: new DateTime(2024, 9, 19, 13, 35, 17, 826, DateTimeKind.Local).AddTicks(4130));

            migrationBuilder.UpdateData(
                table: "Breeds",
                keyColumn: "Id",
                keyValue: 85,
                column: "CreatedTime",
                value: new DateTime(2024, 9, 19, 13, 35, 17, 826, DateTimeKind.Local).AddTicks(4130));

            migrationBuilder.UpdateData(
                table: "Breeds",
                keyColumn: "Id",
                keyValue: 86,
                column: "CreatedTime",
                value: new DateTime(2024, 9, 19, 13, 35, 17, 826, DateTimeKind.Local).AddTicks(4130));

            migrationBuilder.UpdateData(
                table: "Breeds",
                keyColumn: "Id",
                keyValue: 87,
                column: "CreatedTime",
                value: new DateTime(2024, 9, 19, 13, 35, 17, 826, DateTimeKind.Local).AddTicks(4130));

            migrationBuilder.UpdateData(
                table: "Breeds",
                keyColumn: "Id",
                keyValue: 88,
                column: "CreatedTime",
                value: new DateTime(2024, 9, 19, 13, 35, 17, 826, DateTimeKind.Local).AddTicks(4130));

            migrationBuilder.UpdateData(
                table: "Breeds",
                keyColumn: "Id",
                keyValue: 89,
                column: "CreatedTime",
                value: new DateTime(2024, 9, 19, 13, 35, 17, 826, DateTimeKind.Local).AddTicks(4140));

            migrationBuilder.UpdateData(
                table: "Breeds",
                keyColumn: "Id",
                keyValue: 90,
                column: "CreatedTime",
                value: new DateTime(2024, 9, 19, 13, 35, 17, 826, DateTimeKind.Local).AddTicks(4140));

            migrationBuilder.UpdateData(
                table: "Breeds",
                keyColumn: "Id",
                keyValue: 91,
                column: "CreatedTime",
                value: new DateTime(2024, 9, 19, 13, 35, 17, 826, DateTimeKind.Local).AddTicks(4140));

            migrationBuilder.UpdateData(
                table: "Breeds",
                keyColumn: "Id",
                keyValue: 92,
                column: "CreatedTime",
                value: new DateTime(2024, 9, 19, 13, 35, 17, 826, DateTimeKind.Local).AddTicks(4140));

            migrationBuilder.UpdateData(
                table: "Breeds",
                keyColumn: "Id",
                keyValue: 93,
                column: "CreatedTime",
                value: new DateTime(2024, 9, 19, 13, 35, 17, 826, DateTimeKind.Local).AddTicks(4140));

            migrationBuilder.UpdateData(
                table: "Breeds",
                keyColumn: "Id",
                keyValue: 94,
                column: "CreatedTime",
                value: new DateTime(2024, 9, 19, 13, 35, 17, 826, DateTimeKind.Local).AddTicks(4150));

            migrationBuilder.UpdateData(
                table: "Breeds",
                keyColumn: "Id",
                keyValue: 95,
                column: "CreatedTime",
                value: new DateTime(2024, 9, 19, 13, 35, 17, 826, DateTimeKind.Local).AddTicks(4150));

            migrationBuilder.UpdateData(
                table: "Breeds",
                keyColumn: "Id",
                keyValue: 96,
                column: "CreatedTime",
                value: new DateTime(2024, 9, 19, 13, 35, 17, 826, DateTimeKind.Local).AddTicks(4150));

            migrationBuilder.UpdateData(
                table: "Breeds",
                keyColumn: "Id",
                keyValue: 97,
                column: "CreatedTime",
                value: new DateTime(2024, 9, 19, 13, 35, 17, 826, DateTimeKind.Local).AddTicks(4150));

            migrationBuilder.UpdateData(
                table: "Breeds",
                keyColumn: "Id",
                keyValue: 98,
                column: "CreatedTime",
                value: new DateTime(2024, 9, 19, 13, 35, 17, 826, DateTimeKind.Local).AddTicks(4150));

            migrationBuilder.UpdateData(
                table: "Breeds",
                keyColumn: "Id",
                keyValue: 99,
                column: "CreatedTime",
                value: new DateTime(2024, 9, 19, 13, 35, 17, 826, DateTimeKind.Local).AddTicks(4150));

            migrationBuilder.UpdateData(
                table: "Breeds",
                keyColumn: "Id",
                keyValue: 100,
                column: "CreatedTime",
                value: new DateTime(2024, 9, 19, 13, 35, 17, 826, DateTimeKind.Local).AddTicks(4150));

            migrationBuilder.UpdateData(
                table: "Breeds",
                keyColumn: "Id",
                keyValue: 101,
                column: "CreatedTime",
                value: new DateTime(2024, 9, 19, 13, 35, 17, 826, DateTimeKind.Local).AddTicks(4160));

            migrationBuilder.UpdateData(
                table: "Breeds",
                keyColumn: "Id",
                keyValue: 102,
                column: "CreatedTime",
                value: new DateTime(2024, 9, 19, 13, 35, 17, 826, DateTimeKind.Local).AddTicks(4160));

            migrationBuilder.UpdateData(
                table: "Breeds",
                keyColumn: "Id",
                keyValue: 103,
                column: "CreatedTime",
                value: new DateTime(2024, 9, 19, 13, 35, 17, 826, DateTimeKind.Local).AddTicks(4160));

            migrationBuilder.UpdateData(
                table: "Breeds",
                keyColumn: "Id",
                keyValue: 104,
                column: "CreatedTime",
                value: new DateTime(2024, 9, 19, 13, 35, 17, 826, DateTimeKind.Local).AddTicks(4160));

            migrationBuilder.UpdateData(
                table: "Breeds",
                keyColumn: "Id",
                keyValue: 105,
                column: "CreatedTime",
                value: new DateTime(2024, 9, 19, 13, 35, 17, 826, DateTimeKind.Local).AddTicks(4160));

            migrationBuilder.UpdateData(
                table: "Breeds",
                keyColumn: "Id",
                keyValue: 106,
                column: "CreatedTime",
                value: new DateTime(2024, 9, 19, 13, 35, 17, 826, DateTimeKind.Local).AddTicks(4160));

            migrationBuilder.UpdateData(
                table: "Breeds",
                keyColumn: "Id",
                keyValue: 107,
                column: "CreatedTime",
                value: new DateTime(2024, 9, 19, 13, 35, 17, 826, DateTimeKind.Local).AddTicks(4170));

            migrationBuilder.UpdateData(
                table: "Breeds",
                keyColumn: "Id",
                keyValue: 108,
                column: "CreatedTime",
                value: new DateTime(2024, 9, 19, 13, 35, 17, 826, DateTimeKind.Local).AddTicks(4170));

            migrationBuilder.UpdateData(
                table: "Breeds",
                keyColumn: "Id",
                keyValue: 109,
                column: "CreatedTime",
                value: new DateTime(2024, 9, 19, 13, 35, 17, 826, DateTimeKind.Local).AddTicks(4170));

            migrationBuilder.UpdateData(
                table: "Breeds",
                keyColumn: "Id",
                keyValue: 110,
                column: "CreatedTime",
                value: new DateTime(2024, 9, 19, 13, 35, 17, 826, DateTimeKind.Local).AddTicks(4170));

            migrationBuilder.UpdateData(
                table: "Breeds",
                keyColumn: "Id",
                keyValue: 111,
                column: "CreatedTime",
                value: new DateTime(2024, 9, 19, 13, 35, 17, 826, DateTimeKind.Local).AddTicks(4170));

            migrationBuilder.UpdateData(
                table: "Breeds",
                keyColumn: "Id",
                keyValue: 112,
                column: "CreatedTime",
                value: new DateTime(2024, 9, 19, 13, 35, 17, 826, DateTimeKind.Local).AddTicks(4170));

            migrationBuilder.UpdateData(
                table: "Breeds",
                keyColumn: "Id",
                keyValue: 113,
                column: "CreatedTime",
                value: new DateTime(2024, 9, 19, 13, 35, 17, 826, DateTimeKind.Local).AddTicks(4180));

            migrationBuilder.UpdateData(
                table: "Breeds",
                keyColumn: "Id",
                keyValue: 114,
                column: "CreatedTime",
                value: new DateTime(2024, 9, 19, 13, 35, 17, 826, DateTimeKind.Local).AddTicks(4180));

            migrationBuilder.UpdateData(
                table: "Breeds",
                keyColumn: "Id",
                keyValue: 115,
                column: "CreatedTime",
                value: new DateTime(2024, 9, 19, 13, 35, 17, 826, DateTimeKind.Local).AddTicks(4180));

            migrationBuilder.UpdateData(
                table: "Breeds",
                keyColumn: "Id",
                keyValue: 116,
                column: "CreatedTime",
                value: new DateTime(2024, 9, 19, 13, 35, 17, 826, DateTimeKind.Local).AddTicks(4180));

            migrationBuilder.UpdateData(
                table: "Breeds",
                keyColumn: "Id",
                keyValue: 117,
                column: "CreatedTime",
                value: new DateTime(2024, 9, 19, 13, 35, 17, 826, DateTimeKind.Local).AddTicks(4180));

            migrationBuilder.UpdateData(
                table: "Breeds",
                keyColumn: "Id",
                keyValue: 118,
                column: "CreatedTime",
                value: new DateTime(2024, 9, 19, 13, 35, 17, 826, DateTimeKind.Local).AddTicks(4180));

            migrationBuilder.UpdateData(
                table: "Breeds",
                keyColumn: "Id",
                keyValue: 119,
                column: "CreatedTime",
                value: new DateTime(2024, 9, 19, 13, 35, 17, 826, DateTimeKind.Local).AddTicks(4180));

            migrationBuilder.UpdateData(
                table: "Breeds",
                keyColumn: "Id",
                keyValue: 120,
                column: "CreatedTime",
                value: new DateTime(2024, 9, 19, 13, 35, 17, 826, DateTimeKind.Local).AddTicks(4190));

            migrationBuilder.UpdateData(
                table: "Breeds",
                keyColumn: "Id",
                keyValue: 121,
                column: "CreatedTime",
                value: new DateTime(2024, 9, 19, 13, 35, 17, 826, DateTimeKind.Local).AddTicks(4190));

            migrationBuilder.UpdateData(
                table: "Breeds",
                keyColumn: "Id",
                keyValue: 122,
                column: "CreatedTime",
                value: new DateTime(2024, 9, 19, 13, 35, 17, 826, DateTimeKind.Local).AddTicks(4190));

            migrationBuilder.UpdateData(
                table: "Breeds",
                keyColumn: "Id",
                keyValue: 123,
                column: "CreatedTime",
                value: new DateTime(2024, 9, 19, 13, 35, 17, 826, DateTimeKind.Local).AddTicks(4190));

            migrationBuilder.UpdateData(
                table: "Breeds",
                keyColumn: "Id",
                keyValue: 124,
                column: "CreatedTime",
                value: new DateTime(2024, 9, 19, 13, 35, 17, 826, DateTimeKind.Local).AddTicks(4190));

            migrationBuilder.UpdateData(
                table: "Breeds",
                keyColumn: "Id",
                keyValue: 125,
                column: "CreatedTime",
                value: new DateTime(2024, 9, 19, 13, 35, 17, 826, DateTimeKind.Local).AddTicks(4190));

            migrationBuilder.UpdateData(
                table: "Breeds",
                keyColumn: "Id",
                keyValue: 126,
                column: "CreatedTime",
                value: new DateTime(2024, 9, 19, 13, 35, 17, 826, DateTimeKind.Local).AddTicks(4190));

            migrationBuilder.UpdateData(
                table: "Breeds",
                keyColumn: "Id",
                keyValue: 127,
                column: "CreatedTime",
                value: new DateTime(2024, 9, 19, 13, 35, 17, 826, DateTimeKind.Local).AddTicks(4200));

            migrationBuilder.UpdateData(
                table: "Breeds",
                keyColumn: "Id",
                keyValue: 128,
                column: "CreatedTime",
                value: new DateTime(2024, 9, 19, 13, 35, 17, 826, DateTimeKind.Local).AddTicks(4200));

            migrationBuilder.UpdateData(
                table: "Breeds",
                keyColumn: "Id",
                keyValue: 129,
                column: "CreatedTime",
                value: new DateTime(2024, 9, 19, 13, 35, 17, 826, DateTimeKind.Local).AddTicks(4200));

            migrationBuilder.UpdateData(
                table: "Breeds",
                keyColumn: "Id",
                keyValue: 130,
                column: "CreatedTime",
                value: new DateTime(2024, 9, 19, 13, 35, 17, 826, DateTimeKind.Local).AddTicks(4200));

            migrationBuilder.UpdateData(
                table: "Breeds",
                keyColumn: "Id",
                keyValue: 131,
                column: "CreatedTime",
                value: new DateTime(2024, 9, 19, 13, 35, 17, 826, DateTimeKind.Local).AddTicks(4200));

            migrationBuilder.UpdateData(
                table: "Breeds",
                keyColumn: "Id",
                keyValue: 132,
                column: "CreatedTime",
                value: new DateTime(2024, 9, 19, 13, 35, 17, 826, DateTimeKind.Local).AddTicks(4200));

            migrationBuilder.UpdateData(
                table: "Breeds",
                keyColumn: "Id",
                keyValue: 133,
                column: "CreatedTime",
                value: new DateTime(2024, 9, 19, 13, 35, 17, 826, DateTimeKind.Local).AddTicks(4210));

            migrationBuilder.UpdateData(
                table: "Breeds",
                keyColumn: "Id",
                keyValue: 134,
                column: "CreatedTime",
                value: new DateTime(2024, 9, 19, 13, 35, 17, 826, DateTimeKind.Local).AddTicks(4210));

            migrationBuilder.UpdateData(
                table: "Breeds",
                keyColumn: "Id",
                keyValue: 135,
                column: "CreatedTime",
                value: new DateTime(2024, 9, 19, 13, 35, 17, 826, DateTimeKind.Local).AddTicks(4210));

            migrationBuilder.UpdateData(
                table: "Breeds",
                keyColumn: "Id",
                keyValue: 136,
                column: "CreatedTime",
                value: new DateTime(2024, 9, 19, 13, 35, 17, 826, DateTimeKind.Local).AddTicks(4210));

            migrationBuilder.UpdateData(
                table: "Breeds",
                keyColumn: "Id",
                keyValue: 137,
                column: "CreatedTime",
                value: new DateTime(2024, 9, 19, 13, 35, 17, 826, DateTimeKind.Local).AddTicks(4210));

            migrationBuilder.UpdateData(
                table: "Breeds",
                keyColumn: "Id",
                keyValue: 138,
                column: "CreatedTime",
                value: new DateTime(2024, 9, 19, 13, 35, 17, 826, DateTimeKind.Local).AddTicks(4210));

            migrationBuilder.UpdateData(
                table: "Breeds",
                keyColumn: "Id",
                keyValue: 139,
                column: "CreatedTime",
                value: new DateTime(2024, 9, 19, 13, 35, 17, 826, DateTimeKind.Local).AddTicks(4210));

            migrationBuilder.UpdateData(
                table: "Breeds",
                keyColumn: "Id",
                keyValue: 140,
                column: "CreatedTime",
                value: new DateTime(2024, 9, 19, 13, 35, 17, 826, DateTimeKind.Local).AddTicks(4220));

            migrationBuilder.UpdateData(
                table: "Breeds",
                keyColumn: "Id",
                keyValue: 141,
                column: "CreatedTime",
                value: new DateTime(2024, 9, 19, 13, 35, 17, 826, DateTimeKind.Local).AddTicks(4220));

            migrationBuilder.UpdateData(
                table: "Breeds",
                keyColumn: "Id",
                keyValue: 142,
                column: "CreatedTime",
                value: new DateTime(2024, 9, 19, 13, 35, 17, 826, DateTimeKind.Local).AddTicks(4220));

            migrationBuilder.UpdateData(
                table: "Breeds",
                keyColumn: "Id",
                keyValue: 143,
                column: "CreatedTime",
                value: new DateTime(2024, 9, 19, 13, 35, 17, 826, DateTimeKind.Local).AddTicks(4220));

            migrationBuilder.UpdateData(
                table: "Breeds",
                keyColumn: "Id",
                keyValue: 144,
                column: "CreatedTime",
                value: new DateTime(2024, 9, 19, 13, 35, 17, 826, DateTimeKind.Local).AddTicks(4220));

            migrationBuilder.UpdateData(
                table: "Breeds",
                keyColumn: "Id",
                keyValue: 145,
                column: "CreatedTime",
                value: new DateTime(2024, 9, 19, 13, 35, 17, 826, DateTimeKind.Local).AddTicks(4220));

            migrationBuilder.UpdateData(
                table: "Breeds",
                keyColumn: "Id",
                keyValue: 146,
                column: "CreatedTime",
                value: new DateTime(2024, 9, 19, 13, 35, 17, 826, DateTimeKind.Local).AddTicks(4220));

            migrationBuilder.UpdateData(
                table: "Breeds",
                keyColumn: "Id",
                keyValue: 147,
                column: "CreatedTime",
                value: new DateTime(2024, 9, 19, 13, 35, 17, 826, DateTimeKind.Local).AddTicks(4230));

            migrationBuilder.UpdateData(
                table: "Breeds",
                keyColumn: "Id",
                keyValue: 148,
                column: "CreatedTime",
                value: new DateTime(2024, 9, 19, 13, 35, 17, 826, DateTimeKind.Local).AddTicks(4230));

            migrationBuilder.UpdateData(
                table: "Breeds",
                keyColumn: "Id",
                keyValue: 149,
                column: "CreatedTime",
                value: new DateTime(2024, 9, 19, 13, 35, 17, 826, DateTimeKind.Local).AddTicks(4230));

            migrationBuilder.UpdateData(
                table: "Breeds",
                keyColumn: "Id",
                keyValue: 150,
                column: "CreatedTime",
                value: new DateTime(2024, 9, 19, 13, 35, 17, 826, DateTimeKind.Local).AddTicks(4230));

            migrationBuilder.UpdateData(
                table: "Breeds",
                keyColumn: "Id",
                keyValue: 151,
                column: "CreatedTime",
                value: new DateTime(2024, 9, 19, 13, 35, 17, 826, DateTimeKind.Local).AddTicks(4230));

            migrationBuilder.UpdateData(
                table: "Breeds",
                keyColumn: "Id",
                keyValue: 152,
                column: "CreatedTime",
                value: new DateTime(2024, 9, 19, 13, 35, 17, 826, DateTimeKind.Local).AddTicks(4230));

            migrationBuilder.UpdateData(
                table: "Breeds",
                keyColumn: "Id",
                keyValue: 153,
                column: "CreatedTime",
                value: new DateTime(2024, 9, 19, 13, 35, 17, 826, DateTimeKind.Local).AddTicks(4240));

            migrationBuilder.UpdateData(
                table: "Breeds",
                keyColumn: "Id",
                keyValue: 154,
                column: "CreatedTime",
                value: new DateTime(2024, 9, 19, 13, 35, 17, 826, DateTimeKind.Local).AddTicks(4240));

            migrationBuilder.UpdateData(
                table: "Breeds",
                keyColumn: "Id",
                keyValue: 155,
                column: "CreatedTime",
                value: new DateTime(2024, 9, 19, 13, 35, 17, 826, DateTimeKind.Local).AddTicks(4240));

            migrationBuilder.UpdateData(
                table: "Breeds",
                keyColumn: "Id",
                keyValue: 156,
                column: "CreatedTime",
                value: new DateTime(2024, 9, 19, 13, 35, 17, 826, DateTimeKind.Local).AddTicks(4240));

            migrationBuilder.UpdateData(
                table: "Breeds",
                keyColumn: "Id",
                keyValue: 157,
                column: "CreatedTime",
                value: new DateTime(2024, 9, 19, 13, 35, 17, 826, DateTimeKind.Local).AddTicks(4240));

            migrationBuilder.UpdateData(
                table: "Breeds",
                keyColumn: "Id",
                keyValue: 158,
                column: "CreatedTime",
                value: new DateTime(2024, 9, 19, 13, 35, 17, 826, DateTimeKind.Local).AddTicks(4240));

            migrationBuilder.UpdateData(
                table: "Breeds",
                keyColumn: "Id",
                keyValue: 159,
                column: "CreatedTime",
                value: new DateTime(2024, 9, 19, 13, 35, 17, 826, DateTimeKind.Local).AddTicks(4240));

            migrationBuilder.UpdateData(
                table: "Breeds",
                keyColumn: "Id",
                keyValue: 160,
                column: "CreatedTime",
                value: new DateTime(2024, 9, 19, 13, 35, 17, 826, DateTimeKind.Local).AddTicks(4250));

            migrationBuilder.UpdateData(
                table: "PetTypes",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedTime",
                value: new DateTime(2024, 9, 19, 13, 35, 17, 826, DateTimeKind.Local).AddTicks(3320));

            migrationBuilder.UpdateData(
                table: "PetTypes",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreatedTime",
                value: new DateTime(2024, 9, 19, 13, 35, 17, 826, DateTimeKind.Local).AddTicks(3320));

            migrationBuilder.UpdateData(
                table: "PetTypes",
                keyColumn: "Id",
                keyValue: 3,
                column: "CreatedTime",
                value: new DateTime(2024, 9, 19, 13, 35, 17, 826, DateTimeKind.Local).AddTicks(3320));

            migrationBuilder.UpdateData(
                table: "PetTypes",
                keyColumn: "Id",
                keyValue: 4,
                column: "CreatedTime",
                value: new DateTime(2024, 9, 19, 13, 35, 17, 826, DateTimeKind.Local).AddTicks(3330));

            migrationBuilder.UpdateData(
                table: "PetTypes",
                keyColumn: "Id",
                keyValue: 5,
                column: "CreatedTime",
                value: new DateTime(2024, 9, 19, 13, 35, 17, 826, DateTimeKind.Local).AddTicks(3330));

            migrationBuilder.UpdateData(
                table: "PetTypes",
                keyColumn: "Id",
                keyValue: 6,
                column: "CreatedTime",
                value: new DateTime(2024, 9, 19, 13, 35, 17, 826, DateTimeKind.Local).AddTicks(3330));

            migrationBuilder.UpdateData(
                table: "PetTypes",
                keyColumn: "Id",
                keyValue: 7,
                column: "CreatedTime",
                value: new DateTime(2024, 9, 19, 13, 35, 17, 826, DateTimeKind.Local).AddTicks(3330));

            migrationBuilder.UpdateData(
                table: "PetTypes",
                keyColumn: "Id",
                keyValue: 8,
                column: "CreatedTime",
                value: new DateTime(2024, 9, 19, 13, 35, 17, 826, DateTimeKind.Local).AddTicks(3330));

            migrationBuilder.UpdateData(
                table: "Pets",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedTime",
                value: new DateTime(2024, 4, 19, 13, 35, 17, 828, DateTimeKind.Local).AddTicks(4160));

            migrationBuilder.UpdateData(
                table: "Pets",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreatedTime",
                value: new DateTime(2024, 7, 19, 13, 35, 17, 828, DateTimeKind.Local).AddTicks(4170));

            migrationBuilder.UpdateData(
                table: "Pets",
                keyColumn: "Id",
                keyValue: 3,
                column: "CreatedTime",
                value: new DateTime(2024, 8, 19, 13, 35, 17, 828, DateTimeKind.Local).AddTicks(4170));

            migrationBuilder.UpdateData(
                table: "Pets",
                keyColumn: "Id",
                keyValue: 4,
                column: "CreatedTime",
                value: new DateTime(2024, 1, 19, 13, 35, 17, 828, DateTimeKind.Local).AddTicks(4180));

            migrationBuilder.UpdateData(
                table: "Pets",
                keyColumn: "Id",
                keyValue: 5,
                column: "CreatedTime",
                value: new DateTime(2024, 1, 19, 13, 35, 17, 828, DateTimeKind.Local).AddTicks(4180));

            migrationBuilder.UpdateData(
                table: "Pets",
                keyColumn: "Id",
                keyValue: 6,
                column: "CreatedTime",
                value: new DateTime(2023, 10, 19, 13, 35, 17, 828, DateTimeKind.Local).AddTicks(4190));

            migrationBuilder.UpdateData(
                table: "Pets",
                keyColumn: "Id",
                keyValue: 7,
                column: "CreatedTime",
                value: new DateTime(2024, 3, 19, 13, 35, 17, 828, DateTimeKind.Local).AddTicks(4190));

            migrationBuilder.UpdateData(
                table: "Pets",
                keyColumn: "Id",
                keyValue: 8,
                column: "CreatedTime",
                value: new DateTime(2024, 7, 19, 13, 35, 17, 828, DateTimeKind.Local).AddTicks(4200));

            migrationBuilder.UpdateData(
                table: "Pets",
                keyColumn: "Id",
                keyValue: 9,
                column: "CreatedTime",
                value: new DateTime(2024, 8, 19, 13, 35, 17, 828, DateTimeKind.Local).AddTicks(4200));

            migrationBuilder.UpdateData(
                table: "Pets",
                keyColumn: "Id",
                keyValue: 10,
                column: "CreatedTime",
                value: new DateTime(2024, 6, 19, 13, 35, 17, 828, DateTimeKind.Local).AddTicks(4210));

            migrationBuilder.UpdateData(
                table: "Pets",
                keyColumn: "Id",
                keyValue: 11,
                column: "CreatedTime",
                value: new DateTime(2023, 12, 19, 13, 35, 17, 828, DateTimeKind.Local).AddTicks(4210));

            migrationBuilder.UpdateData(
                table: "Pets",
                keyColumn: "Id",
                keyValue: 12,
                column: "CreatedTime",
                value: new DateTime(2023, 11, 19, 13, 35, 17, 828, DateTimeKind.Local).AddTicks(4220));

            migrationBuilder.UpdateData(
                table: "Pets",
                keyColumn: "Id",
                keyValue: 13,
                column: "CreatedTime",
                value: new DateTime(2024, 7, 19, 13, 35, 17, 828, DateTimeKind.Local).AddTicks(4230));

            migrationBuilder.UpdateData(
                table: "Pets",
                keyColumn: "Id",
                keyValue: 14,
                column: "CreatedTime",
                value: new DateTime(2024, 3, 19, 13, 35, 17, 828, DateTimeKind.Local).AddTicks(4240));

            migrationBuilder.UpdateData(
                table: "Pets",
                keyColumn: "Id",
                keyValue: 15,
                column: "CreatedTime",
                value: new DateTime(2024, 4, 19, 13, 35, 17, 828, DateTimeKind.Local).AddTicks(4240));

            migrationBuilder.UpdateData(
                table: "Pets",
                keyColumn: "Id",
                keyValue: 16,
                column: "CreatedTime",
                value: new DateTime(2024, 1, 19, 13, 35, 17, 828, DateTimeKind.Local).AddTicks(4250));

            migrationBuilder.UpdateData(
                table: "Pets",
                keyColumn: "Id",
                keyValue: 17,
                column: "CreatedTime",
                value: new DateTime(2024, 4, 19, 13, 35, 17, 828, DateTimeKind.Local).AddTicks(4250));

            migrationBuilder.UpdateData(
                table: "Pets",
                keyColumn: "Id",
                keyValue: 18,
                column: "CreatedTime",
                value: new DateTime(2024, 2, 19, 13, 35, 17, 828, DateTimeKind.Local).AddTicks(4260));

            migrationBuilder.UpdateData(
                table: "Pets",
                keyColumn: "Id",
                keyValue: 19,
                column: "CreatedTime",
                value: new DateTime(2023, 12, 19, 13, 35, 17, 828, DateTimeKind.Local).AddTicks(4260));

            migrationBuilder.UpdateData(
                table: "Pets",
                keyColumn: "Id",
                keyValue: 20,
                column: "CreatedTime",
                value: new DateTime(2023, 11, 19, 13, 35, 17, 828, DateTimeKind.Local).AddTicks(4270));

            migrationBuilder.UpdateData(
                table: "Pets",
                keyColumn: "Id",
                keyValue: 21,
                column: "CreatedTime",
                value: new DateTime(2024, 4, 19, 13, 35, 17, 828, DateTimeKind.Local).AddTicks(4270));

            migrationBuilder.UpdateData(
                table: "Pets",
                keyColumn: "Id",
                keyValue: 22,
                column: "CreatedTime",
                value: new DateTime(2024, 4, 19, 13, 35, 17, 828, DateTimeKind.Local).AddTicks(4280));

            migrationBuilder.UpdateData(
                table: "Pets",
                keyColumn: "Id",
                keyValue: 23,
                column: "CreatedTime",
                value: new DateTime(2024, 7, 19, 13, 35, 17, 828, DateTimeKind.Local).AddTicks(4280));

            migrationBuilder.UpdateData(
                table: "Pets",
                keyColumn: "Id",
                keyValue: 24,
                column: "CreatedTime",
                value: new DateTime(2024, 3, 19, 13, 35, 17, 828, DateTimeKind.Local).AddTicks(4280));

            migrationBuilder.UpdateData(
                table: "Pets",
                keyColumn: "Id",
                keyValue: 25,
                column: "CreatedTime",
                value: new DateTime(2024, 8, 19, 13, 35, 17, 828, DateTimeKind.Local).AddTicks(4290));

            migrationBuilder.UpdateData(
                table: "Pets",
                keyColumn: "Id",
                keyValue: 26,
                column: "CreatedTime",
                value: new DateTime(2024, 5, 19, 13, 35, 17, 828, DateTimeKind.Local).AddTicks(4290));

            migrationBuilder.UpdateData(
                table: "Pets",
                keyColumn: "Id",
                keyValue: 27,
                column: "CreatedTime",
                value: new DateTime(2023, 10, 19, 13, 35, 17, 828, DateTimeKind.Local).AddTicks(4300));

            migrationBuilder.UpdateData(
                table: "Pets",
                keyColumn: "Id",
                keyValue: 28,
                column: "CreatedTime",
                value: new DateTime(2024, 6, 19, 13, 35, 17, 828, DateTimeKind.Local).AddTicks(4300));

            migrationBuilder.UpdateData(
                table: "Pets",
                keyColumn: "Id",
                keyValue: 29,
                column: "CreatedTime",
                value: new DateTime(2023, 10, 19, 13, 35, 17, 828, DateTimeKind.Local).AddTicks(4310));

            migrationBuilder.UpdateData(
                table: "Pets",
                keyColumn: "Id",
                keyValue: 30,
                column: "CreatedTime",
                value: new DateTime(2023, 12, 19, 13, 35, 17, 828, DateTimeKind.Local).AddTicks(4320));

            migrationBuilder.UpdateData(
                table: "Pets",
                keyColumn: "Id",
                keyValue: 31,
                column: "CreatedTime",
                value: new DateTime(2024, 6, 19, 13, 35, 17, 828, DateTimeKind.Local).AddTicks(4330));

            migrationBuilder.UpdateData(
                table: "Pets",
                keyColumn: "Id",
                keyValue: 32,
                column: "CreatedTime",
                value: new DateTime(2024, 8, 19, 13, 35, 17, 828, DateTimeKind.Local).AddTicks(4330));

            migrationBuilder.UpdateData(
                table: "Pets",
                keyColumn: "Id",
                keyValue: 33,
                column: "CreatedTime",
                value: new DateTime(2024, 4, 19, 13, 35, 17, 828, DateTimeKind.Local).AddTicks(4330));

            migrationBuilder.UpdateData(
                table: "Pets",
                keyColumn: "Id",
                keyValue: 34,
                column: "CreatedTime",
                value: new DateTime(2024, 7, 19, 13, 35, 17, 828, DateTimeKind.Local).AddTicks(4340));

            migrationBuilder.UpdateData(
                table: "Pets",
                keyColumn: "Id",
                keyValue: 35,
                column: "CreatedTime",
                value: new DateTime(2023, 10, 19, 13, 35, 17, 828, DateTimeKind.Local).AddTicks(4340));

            migrationBuilder.UpdateData(
                table: "Pets",
                keyColumn: "Id",
                keyValue: 36,
                column: "CreatedTime",
                value: new DateTime(2023, 11, 19, 13, 35, 17, 828, DateTimeKind.Local).AddTicks(4350));

            migrationBuilder.UpdateData(
                table: "Pets",
                keyColumn: "Id",
                keyValue: 37,
                column: "CreatedTime",
                value: new DateTime(2024, 6, 19, 13, 35, 17, 828, DateTimeKind.Local).AddTicks(4350));

            migrationBuilder.UpdateData(
                table: "Pets",
                keyColumn: "Id",
                keyValue: 38,
                column: "CreatedTime",
                value: new DateTime(2024, 2, 19, 13, 35, 17, 828, DateTimeKind.Local).AddTicks(4360));

            migrationBuilder.UpdateData(
                table: "Pets",
                keyColumn: "Id",
                keyValue: 39,
                column: "CreatedTime",
                value: new DateTime(2024, 6, 19, 13, 35, 17, 828, DateTimeKind.Local).AddTicks(4360));

            migrationBuilder.UpdateData(
                table: "Pets",
                keyColumn: "Id",
                keyValue: 40,
                column: "CreatedTime",
                value: new DateTime(2024, 5, 19, 13, 35, 17, 828, DateTimeKind.Local).AddTicks(4370));

            migrationBuilder.UpdateData(
                table: "Pets",
                keyColumn: "Id",
                keyValue: 41,
                column: "CreatedTime",
                value: new DateTime(2023, 10, 19, 13, 35, 17, 828, DateTimeKind.Local).AddTicks(4370));

            migrationBuilder.UpdateData(
                table: "Pets",
                keyColumn: "Id",
                keyValue: 42,
                column: "CreatedTime",
                value: new DateTime(2024, 5, 19, 13, 35, 17, 828, DateTimeKind.Local).AddTicks(4380));

            migrationBuilder.UpdateData(
                table: "Pets",
                keyColumn: "Id",
                keyValue: 43,
                column: "CreatedTime",
                value: new DateTime(2024, 4, 19, 13, 35, 17, 828, DateTimeKind.Local).AddTicks(4380));

            migrationBuilder.UpdateData(
                table: "Pets",
                keyColumn: "Id",
                keyValue: 44,
                column: "CreatedTime",
                value: new DateTime(2024, 8, 19, 13, 35, 17, 828, DateTimeKind.Local).AddTicks(4390));

            migrationBuilder.UpdateData(
                table: "Pets",
                keyColumn: "Id",
                keyValue: 45,
                column: "CreatedTime",
                value: new DateTime(2023, 12, 19, 13, 35, 17, 828, DateTimeKind.Local).AddTicks(4390));

            migrationBuilder.UpdateData(
                table: "Pets",
                keyColumn: "Id",
                keyValue: 46,
                column: "CreatedTime",
                value: new DateTime(2023, 12, 19, 13, 35, 17, 828, DateTimeKind.Local).AddTicks(4410));

            migrationBuilder.UpdateData(
                table: "Pets",
                keyColumn: "Id",
                keyValue: 47,
                column: "CreatedTime",
                value: new DateTime(2024, 8, 19, 13, 35, 17, 828, DateTimeKind.Local).AddTicks(4420));

            migrationBuilder.UpdateData(
                table: "Pets",
                keyColumn: "Id",
                keyValue: 48,
                column: "CreatedTime",
                value: new DateTime(2024, 3, 19, 13, 35, 17, 828, DateTimeKind.Local).AddTicks(4420));

            migrationBuilder.UpdateData(
                table: "Pets",
                keyColumn: "Id",
                keyValue: 49,
                column: "CreatedTime",
                value: new DateTime(2024, 8, 19, 13, 35, 17, 828, DateTimeKind.Local).AddTicks(4430));

            migrationBuilder.UpdateData(
                table: "Pets",
                keyColumn: "Id",
                keyValue: 50,
                column: "CreatedTime",
                value: new DateTime(2023, 11, 19, 13, 35, 17, 828, DateTimeKind.Local).AddTicks(4430));

            migrationBuilder.UpdateData(
                table: "Shelters",
                keyColumn: "Id",
                keyValue: 1021,
                columns: new[] { "CreatedTime", "LastUpdatedTime" },
                values: new object[] { new DateTime(2024, 9, 19, 9, 35, 17, 826, DateTimeKind.Utc).AddTicks(2970), new DateTime(2024, 9, 19, 9, 35, 17, 826, DateTimeKind.Utc).AddTicks(2970) });

            migrationBuilder.UpdateData(
                table: "Shelters",
                keyColumn: "Id",
                keyValue: 1022,
                columns: new[] { "CreatedTime", "LastUpdatedTime" },
                values: new object[] { new DateTime(2024, 9, 19, 9, 35, 17, 826, DateTimeKind.Utc).AddTicks(2980), new DateTime(2024, 9, 19, 9, 35, 17, 826, DateTimeKind.Utc).AddTicks(2980) });

            migrationBuilder.UpdateData(
                table: "Shelters",
                keyColumn: "Id",
                keyValue: 1023,
                columns: new[] { "CreatedTime", "LastUpdatedTime" },
                values: new object[] { new DateTime(2024, 9, 19, 9, 35, 17, 826, DateTimeKind.Utc).AddTicks(2990), new DateTime(2024, 9, 19, 9, 35, 17, 826, DateTimeKind.Utc).AddTicks(2990) });

            migrationBuilder.UpdateData(
                table: "Shelters",
                keyColumn: "Id",
                keyValue: 1024,
                columns: new[] { "CreatedTime", "LastUpdatedTime" },
                values: new object[] { new DateTime(2024, 9, 19, 9, 35, 17, 826, DateTimeKind.Utc).AddTicks(3000), new DateTime(2024, 9, 19, 9, 35, 17, 826, DateTimeKind.Utc).AddTicks(3000) });

            migrationBuilder.UpdateData(
                table: "Shelters",
                keyColumn: "Id",
                keyValue: 1025,
                columns: new[] { "CreatedTime", "LastUpdatedTime" },
                values: new object[] { new DateTime(2024, 9, 19, 9, 35, 17, 826, DateTimeKind.Utc).AddTicks(3000), new DateTime(2024, 9, 19, 9, 35, 17, 826, DateTimeKind.Utc).AddTicks(3000) });

            migrationBuilder.UpdateData(
                table: "Shelters",
                keyColumn: "Id",
                keyValue: 1026,
                columns: new[] { "CreatedTime", "LastUpdatedTime" },
                values: new object[] { new DateTime(2024, 9, 19, 9, 35, 17, 826, DateTimeKind.Utc).AddTicks(3010), new DateTime(2024, 9, 19, 9, 35, 17, 826, DateTimeKind.Utc).AddTicks(3010) });

            migrationBuilder.UpdateData(
                table: "Shelters",
                keyColumn: "Id",
                keyValue: 1027,
                columns: new[] { "CreatedTime", "LastUpdatedTime" },
                values: new object[] { new DateTime(2024, 9, 19, 9, 35, 17, 826, DateTimeKind.Utc).AddTicks(3020), new DateTime(2024, 9, 19, 9, 35, 17, 826, DateTimeKind.Utc).AddTicks(3020) });

            migrationBuilder.UpdateData(
                table: "Shelters",
                keyColumn: "Id",
                keyValue: 1028,
                columns: new[] { "CreatedTime", "LastUpdatedTime" },
                values: new object[] { new DateTime(2024, 9, 19, 9, 35, 17, 826, DateTimeKind.Utc).AddTicks(3020), new DateTime(2024, 9, 19, 9, 35, 17, 826, DateTimeKind.Utc).AddTicks(3020) });

            migrationBuilder.UpdateData(
                table: "Shelters",
                keyColumn: "Id",
                keyValue: 1029,
                columns: new[] { "CreatedTime", "LastUpdatedTime" },
                values: new object[] { new DateTime(2024, 9, 19, 9, 35, 17, 826, DateTimeKind.Utc).AddTicks(3030), new DateTime(2024, 9, 19, 9, 35, 17, 826, DateTimeKind.Utc).AddTicks(3030) });

            migrationBuilder.UpdateData(
                table: "Shelters",
                keyColumn: "Id",
                keyValue: 1030,
                columns: new[] { "CreatedTime", "LastUpdatedTime" },
                values: new object[] { new DateTime(2024, 9, 19, 9, 35, 17, 826, DateTimeKind.Utc).AddTicks(3040), new DateTime(2024, 9, 19, 9, 35, 17, 826, DateTimeKind.Utc).AddTicks(3040) });

            migrationBuilder.UpdateData(
                table: "Shelters",
                keyColumn: "Id",
                keyValue: 1031,
                columns: new[] { "CreatedTime", "LastUpdatedTime" },
                values: new object[] { new DateTime(2024, 9, 19, 9, 35, 17, 826, DateTimeKind.Utc).AddTicks(3040), new DateTime(2024, 9, 19, 9, 35, 17, 826, DateTimeKind.Utc).AddTicks(3040) });

            migrationBuilder.UpdateData(
                table: "Shelters",
                keyColumn: "Id",
                keyValue: 1032,
                columns: new[] { "CreatedTime", "LastUpdatedTime" },
                values: new object[] { new DateTime(2024, 9, 19, 9, 35, 17, 826, DateTimeKind.Utc).AddTicks(3050), new DateTime(2024, 9, 19, 9, 35, 17, 826, DateTimeKind.Utc).AddTicks(3050) });

            migrationBuilder.UpdateData(
                table: "Shelters",
                keyColumn: "Id",
                keyValue: 1033,
                columns: new[] { "CreatedTime", "LastUpdatedTime" },
                values: new object[] { new DateTime(2024, 9, 19, 9, 35, 17, 826, DateTimeKind.Utc).AddTicks(3050), new DateTime(2024, 9, 19, 9, 35, 17, 826, DateTimeKind.Utc).AddTicks(3050) });

            migrationBuilder.UpdateData(
                table: "Shelters",
                keyColumn: "Id",
                keyValue: 1034,
                columns: new[] { "CreatedTime", "LastUpdatedTime" },
                values: new object[] { new DateTime(2024, 9, 19, 9, 35, 17, 826, DateTimeKind.Utc).AddTicks(3060), new DateTime(2024, 9, 19, 9, 35, 17, 826, DateTimeKind.Utc).AddTicks(3060) });

            migrationBuilder.UpdateData(
                table: "Shelters",
                keyColumn: "Id",
                keyValue: 1035,
                columns: new[] { "CreatedTime", "LastUpdatedTime" },
                values: new object[] { new DateTime(2024, 9, 19, 9, 35, 17, 826, DateTimeKind.Utc).AddTicks(3070), new DateTime(2024, 9, 19, 9, 35, 17, 826, DateTimeKind.Utc).AddTicks(3070) });

            migrationBuilder.UpdateData(
                table: "Shelters",
                keyColumn: "Id",
                keyValue: 1036,
                columns: new[] { "CreatedTime", "LastUpdatedTime" },
                values: new object[] { new DateTime(2024, 9, 19, 9, 35, 17, 826, DateTimeKind.Utc).AddTicks(3070), new DateTime(2024, 9, 19, 9, 35, 17, 826, DateTimeKind.Utc).AddTicks(3070) });

            migrationBuilder.UpdateData(
                table: "Shelters",
                keyColumn: "Id",
                keyValue: 1037,
                columns: new[] { "CreatedTime", "LastUpdatedTime" },
                values: new object[] { new DateTime(2024, 9, 19, 9, 35, 17, 826, DateTimeKind.Utc).AddTicks(3090), new DateTime(2024, 9, 19, 9, 35, 17, 826, DateTimeKind.Utc).AddTicks(3090) });

            migrationBuilder.UpdateData(
                table: "Shelters",
                keyColumn: "Id",
                keyValue: 1038,
                columns: new[] { "CreatedTime", "LastUpdatedTime" },
                values: new object[] { new DateTime(2024, 9, 19, 9, 35, 17, 826, DateTimeKind.Utc).AddTicks(3100), new DateTime(2024, 9, 19, 9, 35, 17, 826, DateTimeKind.Utc).AddTicks(3100) });

            migrationBuilder.UpdateData(
                table: "Shelters",
                keyColumn: "Id",
                keyValue: 1039,
                columns: new[] { "CreatedTime", "LastUpdatedTime" },
                values: new object[] { new DateTime(2024, 9, 19, 9, 35, 17, 826, DateTimeKind.Utc).AddTicks(3110), new DateTime(2024, 9, 19, 9, 35, 17, 826, DateTimeKind.Utc).AddTicks(3110) });

            migrationBuilder.UpdateData(
                table: "Shelters",
                keyColumn: "Id",
                keyValue: 1040,
                columns: new[] { "CreatedTime", "LastUpdatedTime" },
                values: new object[] { new DateTime(2024, 9, 19, 9, 35, 17, 826, DateTimeKind.Utc).AddTicks(3110), new DateTime(2024, 9, 19, 9, 35, 17, 826, DateTimeKind.Utc).AddTicks(3110) });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AlterColumn<bool>(
                name: "isAccepted",
                table: "Adoptions",
                type: "bit",
                nullable: false,
                oldClrType: typeof(int),
                oldType: "int");

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: 2001,
                columns: new[] { "ConcurrencyStamp", "CreatedTime", "LastUpdatedTime", "RefreshTokenCreateTime" },
                values: new object[] { "7b54fac9-7056-43d2-9279-f3311a735235", new DateTime(2023, 11, 19, 9, 2, 19, 370, DateTimeKind.Utc).AddTicks(9360), new DateTime(2024, 9, 19, 9, 2, 19, 370, DateTimeKind.Utc).AddTicks(9360), new DateTime(2024, 9, 19, 9, 2, 19, 370, DateTimeKind.Utc).AddTicks(9350) });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: 2002,
                columns: new[] { "ConcurrencyStamp", "CreatedTime", "LastUpdatedTime", "RefreshTokenCreateTime" },
                values: new object[] { "b525b7aa-9334-4b99-8848-0d9e674a3cc1", new DateTime(2023, 12, 19, 9, 2, 19, 370, DateTimeKind.Utc).AddTicks(9380), new DateTime(2024, 9, 19, 9, 2, 19, 370, DateTimeKind.Utc).AddTicks(9380), new DateTime(2024, 9, 19, 9, 2, 19, 370, DateTimeKind.Utc).AddTicks(9370) });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: 2003,
                columns: new[] { "ConcurrencyStamp", "CreatedTime", "LastUpdatedTime", "RefreshTokenCreateTime" },
                values: new object[] { "7e8ad0af-d6ef-41b2-9bde-89973b808b99", new DateTime(2023, 10, 19, 9, 2, 19, 370, DateTimeKind.Utc).AddTicks(9390), new DateTime(2024, 9, 19, 9, 2, 19, 370, DateTimeKind.Utc).AddTicks(9390), new DateTime(2024, 9, 19, 9, 2, 19, 370, DateTimeKind.Utc).AddTicks(9380) });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: 2004,
                columns: new[] { "ConcurrencyStamp", "CreatedTime", "LastUpdatedTime", "RefreshTokenCreateTime" },
                values: new object[] { "ce1979e9-ae67-495a-9585-8417e4964192", new DateTime(2024, 8, 19, 9, 2, 19, 370, DateTimeKind.Utc).AddTicks(9400), new DateTime(2024, 9, 19, 9, 2, 19, 370, DateTimeKind.Utc).AddTicks(9400), new DateTime(2024, 9, 19, 9, 2, 19, 370, DateTimeKind.Utc).AddTicks(9390) });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: 2005,
                columns: new[] { "ConcurrencyStamp", "CreatedTime", "LastUpdatedTime", "RefreshTokenCreateTime" },
                values: new object[] { "d8e159d3-c89e-451b-b5b1-67db4e6af333", new DateTime(2024, 7, 19, 9, 2, 19, 370, DateTimeKind.Utc).AddTicks(9410), new DateTime(2024, 9, 19, 9, 2, 19, 370, DateTimeKind.Utc).AddTicks(9410), new DateTime(2024, 9, 19, 9, 2, 19, 370, DateTimeKind.Utc).AddTicks(9410) });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: 2006,
                columns: new[] { "ConcurrencyStamp", "CreatedTime", "LastUpdatedTime", "RefreshTokenCreateTime" },
                values: new object[] { "e0f11cb4-398c-4c60-ae05-e68a933ecec8", new DateTime(2023, 12, 19, 9, 2, 19, 370, DateTimeKind.Utc).AddTicks(9430), new DateTime(2024, 9, 19, 9, 2, 19, 370, DateTimeKind.Utc).AddTicks(9430), new DateTime(2024, 9, 19, 9, 2, 19, 370, DateTimeKind.Utc).AddTicks(9420) });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: 2007,
                columns: new[] { "ConcurrencyStamp", "CreatedTime", "LastUpdatedTime", "RefreshTokenCreateTime" },
                values: new object[] { "3b229888-76c9-40ee-b305-6d089a51b0b2", new DateTime(2024, 5, 19, 9, 2, 19, 370, DateTimeKind.Utc).AddTicks(9430), new DateTime(2024, 9, 19, 9, 2, 19, 370, DateTimeKind.Utc).AddTicks(9430), new DateTime(2024, 9, 19, 9, 2, 19, 370, DateTimeKind.Utc).AddTicks(9430) });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: 2008,
                columns: new[] { "ConcurrencyStamp", "CreatedTime", "LastUpdatedTime", "RefreshTokenCreateTime" },
                values: new object[] { "051817d4-2d25-4349-83d7-2df5c69a036a", new DateTime(2024, 5, 19, 9, 2, 19, 370, DateTimeKind.Utc).AddTicks(9440), new DateTime(2024, 9, 19, 9, 2, 19, 370, DateTimeKind.Utc).AddTicks(9440), new DateTime(2024, 9, 19, 9, 2, 19, 370, DateTimeKind.Utc).AddTicks(9440) });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: 2009,
                columns: new[] { "ConcurrencyStamp", "CreatedTime", "LastUpdatedTime", "RefreshTokenCreateTime" },
                values: new object[] { "b41572f0-7d3e-4500-bc1b-ab5dcc651359", new DateTime(2023, 10, 19, 9, 2, 19, 370, DateTimeKind.Utc).AddTicks(9450), new DateTime(2024, 9, 19, 9, 2, 19, 370, DateTimeKind.Utc).AddTicks(9450), new DateTime(2024, 9, 19, 9, 2, 19, 370, DateTimeKind.Utc).AddTicks(9450) });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: 2010,
                columns: new[] { "ConcurrencyStamp", "CreatedTime", "LastUpdatedTime", "RefreshTokenCreateTime" },
                values: new object[] { "d586ba3b-c76b-4b3e-93c7-812b0163f5fc", new DateTime(2023, 10, 19, 9, 2, 19, 370, DateTimeKind.Utc).AddTicks(9460), new DateTime(2024, 9, 19, 9, 2, 19, 370, DateTimeKind.Utc).AddTicks(9460), new DateTime(2024, 9, 19, 9, 2, 19, 370, DateTimeKind.Utc).AddTicks(9460) });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: 2011,
                columns: new[] { "ConcurrencyStamp", "CreatedTime", "LastUpdatedTime", "RefreshTokenCreateTime" },
                values: new object[] { "6951a19f-140a-4368-9543-17f31cffc95b", new DateTime(2024, 5, 19, 9, 2, 19, 370, DateTimeKind.Utc).AddTicks(9470), new DateTime(2024, 9, 19, 9, 2, 19, 370, DateTimeKind.Utc).AddTicks(9470), new DateTime(2024, 9, 19, 9, 2, 19, 370, DateTimeKind.Utc).AddTicks(9470) });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: 2012,
                columns: new[] { "ConcurrencyStamp", "CreatedTime", "LastUpdatedTime", "RefreshTokenCreateTime" },
                values: new object[] { "cdb6e640-2422-4c9e-9a45-12cd8a3f5639", new DateTime(2023, 11, 19, 9, 2, 19, 370, DateTimeKind.Utc).AddTicks(9480), new DateTime(2024, 9, 19, 9, 2, 19, 370, DateTimeKind.Utc).AddTicks(9480), new DateTime(2024, 9, 19, 9, 2, 19, 370, DateTimeKind.Utc).AddTicks(9480) });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: 2013,
                columns: new[] { "ConcurrencyStamp", "CreatedTime", "LastUpdatedTime", "RefreshTokenCreateTime" },
                values: new object[] { "28d92b75-f7fe-47b0-89c1-664ff02b18ac", new DateTime(2024, 3, 19, 9, 2, 19, 370, DateTimeKind.Utc).AddTicks(9490), new DateTime(2024, 9, 19, 9, 2, 19, 370, DateTimeKind.Utc).AddTicks(9490), new DateTime(2024, 9, 19, 9, 2, 19, 370, DateTimeKind.Utc).AddTicks(9490) });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: 2014,
                columns: new[] { "ConcurrencyStamp", "CreatedTime", "LastUpdatedTime", "RefreshTokenCreateTime" },
                values: new object[] { "b85925bf-cb14-40f2-adb6-51a017614402", new DateTime(2023, 12, 19, 9, 2, 19, 370, DateTimeKind.Utc).AddTicks(9500), new DateTime(2024, 9, 19, 9, 2, 19, 370, DateTimeKind.Utc).AddTicks(9500), new DateTime(2024, 9, 19, 9, 2, 19, 370, DateTimeKind.Utc).AddTicks(9500) });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: 2015,
                columns: new[] { "ConcurrencyStamp", "CreatedTime", "LastUpdatedTime", "RefreshTokenCreateTime" },
                values: new object[] { "43da4ae9-99eb-4e91-a45a-2427d160441c", new DateTime(2024, 2, 19, 9, 2, 19, 370, DateTimeKind.Utc).AddTicks(9570), new DateTime(2024, 9, 19, 9, 2, 19, 370, DateTimeKind.Utc).AddTicks(9570), new DateTime(2024, 9, 19, 9, 2, 19, 370, DateTimeKind.Utc).AddTicks(9570) });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: 2016,
                columns: new[] { "ConcurrencyStamp", "CreatedTime", "LastUpdatedTime", "RefreshTokenCreateTime" },
                values: new object[] { "2355d830-7282-4d98-addb-2beca58e6b18", new DateTime(2023, 10, 19, 9, 2, 19, 370, DateTimeKind.Utc).AddTicks(9580), new DateTime(2024, 9, 19, 9, 2, 19, 370, DateTimeKind.Utc).AddTicks(9580), new DateTime(2024, 9, 19, 9, 2, 19, 370, DateTimeKind.Utc).AddTicks(9570) });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: 2017,
                columns: new[] { "ConcurrencyStamp", "CreatedTime", "LastUpdatedTime", "RefreshTokenCreateTime" },
                values: new object[] { "909381d0-cadb-4ed2-95d5-c03758c3704d", new DateTime(2023, 11, 19, 9, 2, 19, 370, DateTimeKind.Utc).AddTicks(9590), new DateTime(2024, 9, 19, 9, 2, 19, 370, DateTimeKind.Utc).AddTicks(9590), new DateTime(2024, 9, 19, 9, 2, 19, 370, DateTimeKind.Utc).AddTicks(9580) });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: 2018,
                columns: new[] { "ConcurrencyStamp", "CreatedTime", "LastUpdatedTime", "RefreshTokenCreateTime" },
                values: new object[] { "f60d0c3a-8f3a-4f3d-bbe5-4c1a5c8f3d6a", new DateTime(2024, 8, 19, 9, 2, 19, 370, DateTimeKind.Utc).AddTicks(9600), new DateTime(2024, 9, 19, 9, 2, 19, 370, DateTimeKind.Utc).AddTicks(9600), new DateTime(2024, 9, 19, 9, 2, 19, 370, DateTimeKind.Utc).AddTicks(9590) });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: 2019,
                columns: new[] { "ConcurrencyStamp", "CreatedTime", "LastUpdatedTime", "RefreshTokenCreateTime" },
                values: new object[] { "5a27aa15-01f5-42b2-b09a-7bb0bbf4b18f", new DateTime(2024, 8, 19, 9, 2, 19, 370, DateTimeKind.Utc).AddTicks(9610), new DateTime(2024, 9, 19, 9, 2, 19, 370, DateTimeKind.Utc).AddTicks(9610), new DateTime(2024, 9, 19, 9, 2, 19, 370, DateTimeKind.Utc).AddTicks(9600) });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: 2020,
                columns: new[] { "ConcurrencyStamp", "CreatedTime", "LastUpdatedTime", "RefreshTokenCreateTime" },
                values: new object[] { "a901a3fe-ab7d-4ca3-a2ab-41744b6f71e3", new DateTime(2023, 11, 19, 9, 2, 19, 370, DateTimeKind.Utc).AddTicks(9620), new DateTime(2024, 9, 19, 9, 2, 19, 370, DateTimeKind.Utc).AddTicks(9620), new DateTime(2024, 9, 19, 9, 2, 19, 370, DateTimeKind.Utc).AddTicks(9610) });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: 2021,
                columns: new[] { "ConcurrencyStamp", "CreatedTime", "LastUpdatedTime", "RefreshTokenCreateTime" },
                values: new object[] { "ccbe97d5-edbd-46c5-89cd-36756bd6ab56", new DateTime(2024, 2, 19, 9, 2, 19, 370, DateTimeKind.Utc).AddTicks(9620), new DateTime(2024, 9, 19, 9, 2, 19, 370, DateTimeKind.Utc).AddTicks(9630), new DateTime(2024, 9, 19, 9, 2, 19, 370, DateTimeKind.Utc).AddTicks(9620) });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: 2022,
                columns: new[] { "ConcurrencyStamp", "CreatedTime", "LastUpdatedTime", "RefreshTokenCreateTime" },
                values: new object[] { "a32d638b-3b31-4109-bc0b-ea67053d4848", new DateTime(2024, 3, 19, 9, 2, 19, 370, DateTimeKind.Utc).AddTicks(9640), new DateTime(2024, 9, 19, 9, 2, 19, 370, DateTimeKind.Utc).AddTicks(9640), new DateTime(2024, 9, 19, 9, 2, 19, 370, DateTimeKind.Utc).AddTicks(9640) });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: 2023,
                columns: new[] { "ConcurrencyStamp", "CreatedTime", "LastUpdatedTime", "RefreshTokenCreateTime" },
                values: new object[] { "4243b8f8-9865-437f-988b-ac7c58b360d1", new DateTime(2024, 1, 19, 9, 2, 19, 370, DateTimeKind.Utc).AddTicks(9650), new DateTime(2024, 9, 19, 9, 2, 19, 370, DateTimeKind.Utc).AddTicks(9650), new DateTime(2024, 9, 19, 9, 2, 19, 370, DateTimeKind.Utc).AddTicks(9650) });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: 2024,
                columns: new[] { "ConcurrencyStamp", "CreatedTime", "LastUpdatedTime", "RefreshTokenCreateTime" },
                values: new object[] { "9fd729f1-e9bc-4cb0-b48e-75e113e3d79f", new DateTime(2023, 10, 19, 9, 2, 19, 370, DateTimeKind.Utc).AddTicks(9670), new DateTime(2024, 9, 19, 9, 2, 19, 370, DateTimeKind.Utc).AddTicks(9670), new DateTime(2024, 9, 19, 9, 2, 19, 370, DateTimeKind.Utc).AddTicks(9670) });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: 2025,
                columns: new[] { "ConcurrencyStamp", "CreatedTime", "LastUpdatedTime", "RefreshTokenCreateTime" },
                values: new object[] { "456e8c64-d1ee-4b6c-85f6-4d618a34d71d", new DateTime(2024, 8, 19, 9, 2, 19, 370, DateTimeKind.Utc).AddTicks(9680), new DateTime(2024, 9, 19, 9, 2, 19, 370, DateTimeKind.Utc).AddTicks(9680), new DateTime(2024, 9, 19, 9, 2, 19, 370, DateTimeKind.Utc).AddTicks(9680) });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: 2026,
                columns: new[] { "ConcurrencyStamp", "CreatedTime", "LastUpdatedTime", "RefreshTokenCreateTime" },
                values: new object[] { "cd4a349b-a412-4949-a839-236ddf042b20", new DateTime(2024, 8, 19, 9, 2, 19, 370, DateTimeKind.Utc).AddTicks(9690), new DateTime(2024, 9, 19, 9, 2, 19, 370, DateTimeKind.Utc).AddTicks(9690), new DateTime(2024, 9, 19, 9, 2, 19, 370, DateTimeKind.Utc).AddTicks(9690) });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: 2027,
                columns: new[] { "ConcurrencyStamp", "CreatedTime", "LastUpdatedTime", "RefreshTokenCreateTime" },
                values: new object[] { "620624f5-c6d2-4f08-9609-819246b79c47", new DateTime(2023, 10, 19, 9, 2, 19, 370, DateTimeKind.Utc).AddTicks(9700), new DateTime(2024, 9, 19, 9, 2, 19, 370, DateTimeKind.Utc).AddTicks(9700), new DateTime(2024, 9, 19, 9, 2, 19, 370, DateTimeKind.Utc).AddTicks(9700) });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: 2028,
                columns: new[] { "ConcurrencyStamp", "CreatedTime", "LastUpdatedTime", "RefreshTokenCreateTime" },
                values: new object[] { "aa6246fb-c715-4c46-96ee-225f52a377bd", new DateTime(2024, 6, 19, 9, 2, 19, 370, DateTimeKind.Utc).AddTicks(9710), new DateTime(2024, 9, 19, 9, 2, 19, 370, DateTimeKind.Utc).AddTicks(9710), new DateTime(2024, 9, 19, 9, 2, 19, 370, DateTimeKind.Utc).AddTicks(9710) });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: 2029,
                columns: new[] { "ConcurrencyStamp", "CreatedTime", "LastUpdatedTime", "RefreshTokenCreateTime" },
                values: new object[] { "f6fca8b7-00b4-418e-b495-d0d4b12c67f0", new DateTime(2024, 2, 19, 9, 2, 19, 370, DateTimeKind.Utc).AddTicks(9720), new DateTime(2024, 9, 19, 9, 2, 19, 370, DateTimeKind.Utc).AddTicks(9720), new DateTime(2024, 9, 19, 9, 2, 19, 370, DateTimeKind.Utc).AddTicks(9710) });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: 2030,
                columns: new[] { "ConcurrencyStamp", "CreatedTime", "LastUpdatedTime", "RefreshTokenCreateTime" },
                values: new object[] { "d07a74f8-48d6-41fb-b926-f9a7130ee726", new DateTime(2023, 10, 19, 9, 2, 19, 370, DateTimeKind.Utc).AddTicks(9730), new DateTime(2024, 9, 19, 9, 2, 19, 370, DateTimeKind.Utc).AddTicks(9730), new DateTime(2024, 9, 19, 9, 2, 19, 370, DateTimeKind.Utc).AddTicks(9720) });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: 2031,
                columns: new[] { "ConcurrencyStamp", "CreatedTime", "LastUpdatedTime", "RefreshTokenCreateTime" },
                values: new object[] { "7b08e077-ca0a-4511-987e-cba0c9871c36", new DateTime(2023, 11, 19, 9, 2, 19, 370, DateTimeKind.Utc).AddTicks(9740), new DateTime(2024, 9, 19, 9, 2, 19, 370, DateTimeKind.Utc).AddTicks(9740), new DateTime(2024, 9, 19, 9, 2, 19, 370, DateTimeKind.Utc).AddTicks(9730) });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: 2032,
                columns: new[] { "ConcurrencyStamp", "CreatedTime", "LastUpdatedTime", "RefreshTokenCreateTime" },
                values: new object[] { "b3a89d72-5beb-4623-ae91-39cfd80bed87", new DateTime(2024, 1, 19, 9, 2, 19, 370, DateTimeKind.Utc).AddTicks(9750), new DateTime(2024, 9, 19, 9, 2, 19, 370, DateTimeKind.Utc).AddTicks(9750), new DateTime(2024, 9, 19, 9, 2, 19, 370, DateTimeKind.Utc).AddTicks(9740) });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: 2033,
                columns: new[] { "ConcurrencyStamp", "CreatedTime", "LastUpdatedTime", "RefreshTokenCreateTime" },
                values: new object[] { "ef944076-b535-410a-be0e-6366cd358b98", new DateTime(2024, 8, 19, 9, 2, 19, 370, DateTimeKind.Utc).AddTicks(9760), new DateTime(2024, 9, 19, 9, 2, 19, 370, DateTimeKind.Utc).AddTicks(9760), new DateTime(2024, 9, 19, 9, 2, 19, 370, DateTimeKind.Utc).AddTicks(9760) });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: 2034,
                columns: new[] { "ConcurrencyStamp", "CreatedTime", "LastUpdatedTime", "RefreshTokenCreateTime" },
                values: new object[] { "a14d40e2-e31c-4c5a-8f84-4d43b0735e4b", new DateTime(2024, 6, 19, 9, 2, 19, 370, DateTimeKind.Utc).AddTicks(9770), new DateTime(2024, 9, 19, 9, 2, 19, 370, DateTimeKind.Utc).AddTicks(9770), new DateTime(2024, 9, 19, 9, 2, 19, 370, DateTimeKind.Utc).AddTicks(9770) });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: 2035,
                columns: new[] { "ConcurrencyStamp", "CreatedTime", "LastUpdatedTime", "RefreshTokenCreateTime" },
                values: new object[] { "b3922890-ca74-41b1-9392-985d0fee38de", new DateTime(2023, 10, 19, 9, 2, 19, 370, DateTimeKind.Utc).AddTicks(9780), new DateTime(2024, 9, 19, 9, 2, 19, 370, DateTimeKind.Utc).AddTicks(9780), new DateTime(2024, 9, 19, 9, 2, 19, 370, DateTimeKind.Utc).AddTicks(9770) });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: 2036,
                columns: new[] { "ConcurrencyStamp", "CreatedTime", "LastUpdatedTime", "RefreshTokenCreateTime" },
                values: new object[] { "3099e812-f4d1-4ffc-b1b8-c662e2d0e35c", new DateTime(2024, 5, 19, 9, 2, 19, 370, DateTimeKind.Utc).AddTicks(9790), new DateTime(2024, 9, 19, 9, 2, 19, 370, DateTimeKind.Utc).AddTicks(9790), new DateTime(2024, 9, 19, 9, 2, 19, 370, DateTimeKind.Utc).AddTicks(9780) });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: 2037,
                columns: new[] { "ConcurrencyStamp", "CreatedTime", "LastUpdatedTime", "RefreshTokenCreateTime" },
                values: new object[] { "1e133491-e9cd-45e2-8b35-1fd47ea7c77c", new DateTime(2023, 10, 19, 9, 2, 19, 370, DateTimeKind.Utc).AddTicks(9800), new DateTime(2024, 9, 19, 9, 2, 19, 370, DateTimeKind.Utc).AddTicks(9800), new DateTime(2024, 9, 19, 9, 2, 19, 370, DateTimeKind.Utc).AddTicks(9790) });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: 2038,
                columns: new[] { "ConcurrencyStamp", "CreatedTime", "LastUpdatedTime", "RefreshTokenCreateTime" },
                values: new object[] { "6dbb5068-5cd8-4796-9bee-4580f398d6f0", new DateTime(2024, 5, 19, 9, 2, 19, 370, DateTimeKind.Utc).AddTicks(9810), new DateTime(2024, 9, 19, 9, 2, 19, 370, DateTimeKind.Utc).AddTicks(9810), new DateTime(2024, 9, 19, 9, 2, 19, 370, DateTimeKind.Utc).AddTicks(9800) });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: 2039,
                columns: new[] { "ConcurrencyStamp", "CreatedTime", "LastUpdatedTime", "RefreshTokenCreateTime" },
                values: new object[] { "2ba71406-38d0-4aeb-87df-4fb376b8a067", new DateTime(2024, 7, 19, 9, 2, 19, 370, DateTimeKind.Utc).AddTicks(9820), new DateTime(2024, 9, 19, 9, 2, 19, 370, DateTimeKind.Utc).AddTicks(9820), new DateTime(2024, 9, 19, 9, 2, 19, 370, DateTimeKind.Utc).AddTicks(9810) });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: 2040,
                columns: new[] { "ConcurrencyStamp", "CreatedTime", "LastUpdatedTime", "RefreshTokenCreateTime" },
                values: new object[] { "217c2d4f-c209-4f63-a7b8-b832376110c6", new DateTime(2023, 12, 19, 9, 2, 19, 370, DateTimeKind.Utc).AddTicks(9830), new DateTime(2024, 9, 19, 9, 2, 19, 370, DateTimeKind.Utc).AddTicks(9830), new DateTime(2024, 9, 19, 9, 2, 19, 370, DateTimeKind.Utc).AddTicks(9820) });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: 2041,
                columns: new[] { "ConcurrencyStamp", "CreatedTime", "LastUpdatedTime", "RefreshTokenCreateTime" },
                values: new object[] { "d1320735-aefb-4791-9d92-38e352a922c8", new DateTime(2023, 11, 19, 9, 2, 19, 370, DateTimeKind.Utc).AddTicks(9850), new DateTime(2024, 9, 19, 9, 2, 19, 370, DateTimeKind.Utc).AddTicks(9850), new DateTime(2024, 9, 19, 9, 2, 19, 370, DateTimeKind.Utc).AddTicks(9830) });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: 2042,
                columns: new[] { "ConcurrencyStamp", "CreatedTime", "LastUpdatedTime", "RefreshTokenCreateTime" },
                values: new object[] { "d31f40f6-d5b1-4304-afb1-99ccac7a752e", new DateTime(2023, 12, 19, 9, 2, 19, 370, DateTimeKind.Utc).AddTicks(9860), new DateTime(2024, 9, 19, 9, 2, 19, 370, DateTimeKind.Utc).AddTicks(9860), new DateTime(2024, 9, 19, 9, 2, 19, 370, DateTimeKind.Utc).AddTicks(9860) });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: 2043,
                columns: new[] { "ConcurrencyStamp", "CreatedTime", "LastUpdatedTime", "RefreshTokenCreateTime" },
                values: new object[] { "3a2b5178-5d7a-418c-8356-cabe5af6c64c", new DateTime(2024, 3, 19, 9, 2, 19, 370, DateTimeKind.Utc).AddTicks(9870), new DateTime(2024, 9, 19, 9, 2, 19, 370, DateTimeKind.Utc).AddTicks(9870), new DateTime(2024, 9, 19, 9, 2, 19, 370, DateTimeKind.Utc).AddTicks(9870) });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: 2044,
                columns: new[] { "ConcurrencyStamp", "CreatedTime", "LastUpdatedTime", "RefreshTokenCreateTime" },
                values: new object[] { "848ccedc-ecbb-464a-a7a3-ad07d3017275", new DateTime(2024, 4, 19, 9, 2, 19, 370, DateTimeKind.Utc).AddTicks(9880), new DateTime(2024, 9, 19, 9, 2, 19, 370, DateTimeKind.Utc).AddTicks(9880), new DateTime(2024, 9, 19, 9, 2, 19, 370, DateTimeKind.Utc).AddTicks(9880) });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: 2045,
                columns: new[] { "ConcurrencyStamp", "CreatedTime", "LastUpdatedTime", "RefreshTokenCreateTime" },
                values: new object[] { "b6050aba-8514-40fd-85fe-8091c724ed26", new DateTime(2024, 4, 19, 9, 2, 19, 370, DateTimeKind.Utc).AddTicks(9890), new DateTime(2024, 9, 19, 9, 2, 19, 370, DateTimeKind.Utc).AddTicks(9890), new DateTime(2024, 9, 19, 9, 2, 19, 370, DateTimeKind.Utc).AddTicks(9880) });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: 2046,
                columns: new[] { "ConcurrencyStamp", "CreatedTime", "LastUpdatedTime", "RefreshTokenCreateTime" },
                values: new object[] { "0bf4d9f9-132d-4450-ba19-1d103775814b", new DateTime(2024, 3, 19, 9, 2, 19, 370, DateTimeKind.Utc).AddTicks(9900), new DateTime(2024, 9, 19, 9, 2, 19, 370, DateTimeKind.Utc).AddTicks(9900), new DateTime(2024, 9, 19, 9, 2, 19, 370, DateTimeKind.Utc).AddTicks(9890) });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: 2047,
                columns: new[] { "ConcurrencyStamp", "CreatedTime", "LastUpdatedTime", "RefreshTokenCreateTime" },
                values: new object[] { "8bf58158-5be5-44cb-b48b-0c3276339ead", new DateTime(2024, 4, 19, 9, 2, 19, 370, DateTimeKind.Utc).AddTicks(9910), new DateTime(2024, 9, 19, 9, 2, 19, 370, DateTimeKind.Utc).AddTicks(9910), new DateTime(2024, 9, 19, 9, 2, 19, 370, DateTimeKind.Utc).AddTicks(9900) });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: 2048,
                columns: new[] { "ConcurrencyStamp", "CreatedTime", "LastUpdatedTime", "RefreshTokenCreateTime" },
                values: new object[] { "2a3b5b6c-abc8-438f-a242-ccd2347ca189", new DateTime(2023, 12, 19, 9, 2, 19, 370, DateTimeKind.Utc).AddTicks(9910), new DateTime(2024, 9, 19, 9, 2, 19, 370, DateTimeKind.Utc).AddTicks(9920), new DateTime(2024, 9, 19, 9, 2, 19, 370, DateTimeKind.Utc).AddTicks(9910) });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: 2049,
                columns: new[] { "ConcurrencyStamp", "CreatedTime", "LastUpdatedTime", "RefreshTokenCreateTime" },
                values: new object[] { "79a817e9-fe4a-44d1-a9bf-939ce6d636f0", new DateTime(2023, 11, 19, 9, 2, 19, 370, DateTimeKind.Utc).AddTicks(9920), new DateTime(2024, 9, 19, 9, 2, 19, 370, DateTimeKind.Utc).AddTicks(9920), new DateTime(2024, 9, 19, 9, 2, 19, 370, DateTimeKind.Utc).AddTicks(9920) });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: 2050,
                columns: new[] { "ConcurrencyStamp", "CreatedTime", "LastUpdatedTime", "RefreshTokenCreateTime" },
                values: new object[] { "6c392ab7-0381-4f58-a3c7-295e4a676c01", new DateTime(2024, 8, 19, 9, 2, 19, 370, DateTimeKind.Utc).AddTicks(9930), new DateTime(2024, 9, 19, 9, 2, 19, 370, DateTimeKind.Utc).AddTicks(9930), new DateTime(2024, 9, 19, 9, 2, 19, 370, DateTimeKind.Utc).AddTicks(9930) });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: 2051,
                columns: new[] { "ConcurrencyStamp", "CreatedTime", "LastUpdatedTime", "RefreshTokenCreateTime" },
                values: new object[] { "31c64b75-b95f-4ab7-9eba-48839cfcdb44", new DateTime(2024, 2, 19, 9, 2, 19, 370, DateTimeKind.Utc).AddTicks(9940), new DateTime(2024, 9, 19, 9, 2, 19, 370, DateTimeKind.Utc).AddTicks(9940), new DateTime(2024, 9, 19, 9, 2, 19, 370, DateTimeKind.Utc).AddTicks(9940) });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: 2052,
                columns: new[] { "ConcurrencyStamp", "CreatedTime", "LastUpdatedTime", "RefreshTokenCreateTime" },
                values: new object[] { "1ba8609d-7ee4-45b8-a4f8-cfbb6fe7a65d", new DateTime(2024, 6, 19, 9, 2, 19, 370, DateTimeKind.Utc).AddTicks(9960), new DateTime(2024, 9, 19, 9, 2, 19, 370, DateTimeKind.Utc).AddTicks(9960), new DateTime(2024, 9, 19, 9, 2, 19, 370, DateTimeKind.Utc).AddTicks(9960) });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: 2053,
                columns: new[] { "ConcurrencyStamp", "CreatedTime", "LastUpdatedTime", "RefreshTokenCreateTime" },
                values: new object[] { "de464ce1-69cd-4c28-a1d9-fe4cb84c06e1", new DateTime(2024, 1, 19, 9, 2, 19, 370, DateTimeKind.Utc).AddTicks(9970), new DateTime(2024, 9, 19, 9, 2, 19, 370, DateTimeKind.Utc).AddTicks(9970), new DateTime(2024, 9, 19, 9, 2, 19, 370, DateTimeKind.Utc).AddTicks(9970) });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: 2054,
                columns: new[] { "ConcurrencyStamp", "CreatedTime", "LastUpdatedTime", "RefreshTokenCreateTime" },
                values: new object[] { "ffaa94ff-ad45-4f21-b3bf-ed0806417701", new DateTime(2024, 1, 19, 9, 2, 19, 370, DateTimeKind.Utc).AddTicks(9980), new DateTime(2024, 9, 19, 9, 2, 19, 370, DateTimeKind.Utc).AddTicks(9980), new DateTime(2024, 9, 19, 9, 2, 19, 370, DateTimeKind.Utc).AddTicks(9980) });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: 2055,
                columns: new[] { "ConcurrencyStamp", "CreatedTime", "LastUpdatedTime", "RefreshTokenCreateTime" },
                values: new object[] { "8ab6586f-1766-4638-b6fe-e89e1bbe53b0", new DateTime(2024, 7, 19, 9, 2, 19, 370, DateTimeKind.Utc).AddTicks(9990), new DateTime(2024, 9, 19, 9, 2, 19, 370, DateTimeKind.Utc).AddTicks(9990), new DateTime(2024, 9, 19, 9, 2, 19, 370, DateTimeKind.Utc).AddTicks(9980) });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: 2056,
                columns: new[] { "ConcurrencyStamp", "CreatedTime", "LastUpdatedTime", "RefreshTokenCreateTime" },
                values: new object[] { "dface9cf-5a87-4f73-ab81-1ba9b5eb11b9", new DateTime(2024, 1, 19, 9, 2, 19, 371, DateTimeKind.Utc), new DateTime(2024, 9, 19, 9, 2, 19, 371, DateTimeKind.Utc), new DateTime(2024, 9, 19, 9, 2, 19, 370, DateTimeKind.Utc).AddTicks(9990) });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: 2057,
                columns: new[] { "ConcurrencyStamp", "CreatedTime", "LastUpdatedTime", "RefreshTokenCreateTime" },
                values: new object[] { "201eaf82-e363-42c0-a6ce-d0a1a0570843", new DateTime(2023, 11, 19, 9, 2, 19, 371, DateTimeKind.Utc).AddTicks(10), new DateTime(2024, 9, 19, 9, 2, 19, 371, DateTimeKind.Utc).AddTicks(10), new DateTime(2024, 9, 19, 9, 2, 19, 371, DateTimeKind.Utc) });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: 2058,
                columns: new[] { "ConcurrencyStamp", "CreatedTime", "LastUpdatedTime", "RefreshTokenCreateTime" },
                values: new object[] { "bccbac2c-c76f-4714-af6a-18550c95117e", new DateTime(2024, 4, 19, 9, 2, 19, 371, DateTimeKind.Utc).AddTicks(20), new DateTime(2024, 9, 19, 9, 2, 19, 371, DateTimeKind.Utc).AddTicks(20), new DateTime(2024, 9, 19, 9, 2, 19, 371, DateTimeKind.Utc).AddTicks(10) });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: 2059,
                columns: new[] { "ConcurrencyStamp", "CreatedTime", "LastUpdatedTime", "RefreshTokenCreateTime" },
                values: new object[] { "92621016-b584-4016-a822-c41515900a2d", new DateTime(2024, 2, 19, 9, 2, 19, 371, DateTimeKind.Utc).AddTicks(20), new DateTime(2024, 9, 19, 9, 2, 19, 371, DateTimeKind.Utc).AddTicks(20), new DateTime(2024, 9, 19, 9, 2, 19, 371, DateTimeKind.Utc).AddTicks(20) });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: 2060,
                columns: new[] { "ConcurrencyStamp", "CreatedTime", "LastUpdatedTime", "RefreshTokenCreateTime" },
                values: new object[] { "f1166bb0-0166-4776-9600-94fb95d5851b", new DateTime(2024, 7, 19, 9, 2, 19, 371, DateTimeKind.Utc).AddTicks(30), new DateTime(2024, 9, 19, 9, 2, 19, 371, DateTimeKind.Utc).AddTicks(30), new DateTime(2024, 9, 19, 9, 2, 19, 371, DateTimeKind.Utc).AddTicks(30) });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: 9999,
                columns: new[] { "ConcurrencyStamp", "CreatedTime", "LastUpdatedTime", "RefreshTokenCreateTime" },
                values: new object[] { "bd184a55-f0ce-40a0-a392-6f1c5cf1aef7", new DateTime(2024, 9, 19, 9, 2, 19, 370, DateTimeKind.Utc).AddTicks(9340), new DateTime(2024, 9, 19, 9, 2, 19, 370, DateTimeKind.Utc).AddTicks(9340), new DateTime(2024, 9, 19, 9, 2, 19, 370, DateTimeKind.Utc).AddTicks(9300) });

            migrationBuilder.UpdateData(
                table: "Breeds",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedTime",
                value: new DateTime(2024, 9, 19, 13, 2, 19, 369, DateTimeKind.Local).AddTicks(4250));

            migrationBuilder.UpdateData(
                table: "Breeds",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreatedTime",
                value: new DateTime(2024, 9, 19, 13, 2, 19, 369, DateTimeKind.Local).AddTicks(4250));

            migrationBuilder.UpdateData(
                table: "Breeds",
                keyColumn: "Id",
                keyValue: 3,
                column: "CreatedTime",
                value: new DateTime(2024, 9, 19, 13, 2, 19, 369, DateTimeKind.Local).AddTicks(4250));

            migrationBuilder.UpdateData(
                table: "Breeds",
                keyColumn: "Id",
                keyValue: 4,
                column: "CreatedTime",
                value: new DateTime(2024, 9, 19, 13, 2, 19, 369, DateTimeKind.Local).AddTicks(4260));

            migrationBuilder.UpdateData(
                table: "Breeds",
                keyColumn: "Id",
                keyValue: 5,
                column: "CreatedTime",
                value: new DateTime(2024, 9, 19, 13, 2, 19, 369, DateTimeKind.Local).AddTicks(4260));

            migrationBuilder.UpdateData(
                table: "Breeds",
                keyColumn: "Id",
                keyValue: 6,
                column: "CreatedTime",
                value: new DateTime(2024, 9, 19, 13, 2, 19, 369, DateTimeKind.Local).AddTicks(4280));

            migrationBuilder.UpdateData(
                table: "Breeds",
                keyColumn: "Id",
                keyValue: 7,
                column: "CreatedTime",
                value: new DateTime(2024, 9, 19, 13, 2, 19, 369, DateTimeKind.Local).AddTicks(4280));

            migrationBuilder.UpdateData(
                table: "Breeds",
                keyColumn: "Id",
                keyValue: 8,
                column: "CreatedTime",
                value: new DateTime(2024, 9, 19, 13, 2, 19, 369, DateTimeKind.Local).AddTicks(4280));

            migrationBuilder.UpdateData(
                table: "Breeds",
                keyColumn: "Id",
                keyValue: 9,
                column: "CreatedTime",
                value: new DateTime(2024, 9, 19, 13, 2, 19, 369, DateTimeKind.Local).AddTicks(4290));

            migrationBuilder.UpdateData(
                table: "Breeds",
                keyColumn: "Id",
                keyValue: 10,
                column: "CreatedTime",
                value: new DateTime(2024, 9, 19, 13, 2, 19, 369, DateTimeKind.Local).AddTicks(4290));

            migrationBuilder.UpdateData(
                table: "Breeds",
                keyColumn: "Id",
                keyValue: 11,
                column: "CreatedTime",
                value: new DateTime(2024, 9, 19, 13, 2, 19, 369, DateTimeKind.Local).AddTicks(4300));

            migrationBuilder.UpdateData(
                table: "Breeds",
                keyColumn: "Id",
                keyValue: 12,
                column: "CreatedTime",
                value: new DateTime(2024, 9, 19, 13, 2, 19, 369, DateTimeKind.Local).AddTicks(4300));

            migrationBuilder.UpdateData(
                table: "Breeds",
                keyColumn: "Id",
                keyValue: 13,
                column: "CreatedTime",
                value: new DateTime(2024, 9, 19, 13, 2, 19, 369, DateTimeKind.Local).AddTicks(4300));

            migrationBuilder.UpdateData(
                table: "Breeds",
                keyColumn: "Id",
                keyValue: 14,
                column: "CreatedTime",
                value: new DateTime(2024, 9, 19, 13, 2, 19, 369, DateTimeKind.Local).AddTicks(4300));

            migrationBuilder.UpdateData(
                table: "Breeds",
                keyColumn: "Id",
                keyValue: 15,
                column: "CreatedTime",
                value: new DateTime(2024, 9, 19, 13, 2, 19, 369, DateTimeKind.Local).AddTicks(4300));

            migrationBuilder.UpdateData(
                table: "Breeds",
                keyColumn: "Id",
                keyValue: 16,
                column: "CreatedTime",
                value: new DateTime(2024, 9, 19, 13, 2, 19, 369, DateTimeKind.Local).AddTicks(4310));

            migrationBuilder.UpdateData(
                table: "Breeds",
                keyColumn: "Id",
                keyValue: 17,
                column: "CreatedTime",
                value: new DateTime(2024, 9, 19, 13, 2, 19, 369, DateTimeKind.Local).AddTicks(4310));

            migrationBuilder.UpdateData(
                table: "Breeds",
                keyColumn: "Id",
                keyValue: 18,
                column: "CreatedTime",
                value: new DateTime(2024, 9, 19, 13, 2, 19, 369, DateTimeKind.Local).AddTicks(4310));

            migrationBuilder.UpdateData(
                table: "Breeds",
                keyColumn: "Id",
                keyValue: 19,
                column: "CreatedTime",
                value: new DateTime(2024, 9, 19, 13, 2, 19, 369, DateTimeKind.Local).AddTicks(4310));

            migrationBuilder.UpdateData(
                table: "Breeds",
                keyColumn: "Id",
                keyValue: 20,
                column: "CreatedTime",
                value: new DateTime(2024, 9, 19, 13, 2, 19, 369, DateTimeKind.Local).AddTicks(4310));

            migrationBuilder.UpdateData(
                table: "Breeds",
                keyColumn: "Id",
                keyValue: 21,
                column: "CreatedTime",
                value: new DateTime(2024, 9, 19, 13, 2, 19, 369, DateTimeKind.Local).AddTicks(4310));

            migrationBuilder.UpdateData(
                table: "Breeds",
                keyColumn: "Id",
                keyValue: 22,
                column: "CreatedTime",
                value: new DateTime(2024, 9, 19, 13, 2, 19, 369, DateTimeKind.Local).AddTicks(4310));

            migrationBuilder.UpdateData(
                table: "Breeds",
                keyColumn: "Id",
                keyValue: 23,
                column: "CreatedTime",
                value: new DateTime(2024, 9, 19, 13, 2, 19, 369, DateTimeKind.Local).AddTicks(4320));

            migrationBuilder.UpdateData(
                table: "Breeds",
                keyColumn: "Id",
                keyValue: 24,
                column: "CreatedTime",
                value: new DateTime(2024, 9, 19, 13, 2, 19, 369, DateTimeKind.Local).AddTicks(4320));

            migrationBuilder.UpdateData(
                table: "Breeds",
                keyColumn: "Id",
                keyValue: 25,
                column: "CreatedTime",
                value: new DateTime(2024, 9, 19, 13, 2, 19, 369, DateTimeKind.Local).AddTicks(4320));

            migrationBuilder.UpdateData(
                table: "Breeds",
                keyColumn: "Id",
                keyValue: 26,
                column: "CreatedTime",
                value: new DateTime(2024, 9, 19, 13, 2, 19, 369, DateTimeKind.Local).AddTicks(4320));

            migrationBuilder.UpdateData(
                table: "Breeds",
                keyColumn: "Id",
                keyValue: 27,
                column: "CreatedTime",
                value: new DateTime(2024, 9, 19, 13, 2, 19, 369, DateTimeKind.Local).AddTicks(4320));

            migrationBuilder.UpdateData(
                table: "Breeds",
                keyColumn: "Id",
                keyValue: 28,
                column: "CreatedTime",
                value: new DateTime(2024, 9, 19, 13, 2, 19, 369, DateTimeKind.Local).AddTicks(4320));

            migrationBuilder.UpdateData(
                table: "Breeds",
                keyColumn: "Id",
                keyValue: 29,
                column: "CreatedTime",
                value: new DateTime(2024, 9, 19, 13, 2, 19, 369, DateTimeKind.Local).AddTicks(4320));

            migrationBuilder.UpdateData(
                table: "Breeds",
                keyColumn: "Id",
                keyValue: 30,
                column: "CreatedTime",
                value: new DateTime(2024, 9, 19, 13, 2, 19, 369, DateTimeKind.Local).AddTicks(4330));

            migrationBuilder.UpdateData(
                table: "Breeds",
                keyColumn: "Id",
                keyValue: 31,
                column: "CreatedTime",
                value: new DateTime(2024, 9, 19, 13, 2, 19, 369, DateTimeKind.Local).AddTicks(4330));

            migrationBuilder.UpdateData(
                table: "Breeds",
                keyColumn: "Id",
                keyValue: 32,
                column: "CreatedTime",
                value: new DateTime(2024, 9, 19, 13, 2, 19, 369, DateTimeKind.Local).AddTicks(4330));

            migrationBuilder.UpdateData(
                table: "Breeds",
                keyColumn: "Id",
                keyValue: 33,
                column: "CreatedTime",
                value: new DateTime(2024, 9, 19, 13, 2, 19, 369, DateTimeKind.Local).AddTicks(4330));

            migrationBuilder.UpdateData(
                table: "Breeds",
                keyColumn: "Id",
                keyValue: 34,
                column: "CreatedTime",
                value: new DateTime(2024, 9, 19, 13, 2, 19, 369, DateTimeKind.Local).AddTicks(4330));

            migrationBuilder.UpdateData(
                table: "Breeds",
                keyColumn: "Id",
                keyValue: 35,
                column: "CreatedTime",
                value: new DateTime(2024, 9, 19, 13, 2, 19, 369, DateTimeKind.Local).AddTicks(4330));

            migrationBuilder.UpdateData(
                table: "Breeds",
                keyColumn: "Id",
                keyValue: 36,
                column: "CreatedTime",
                value: new DateTime(2024, 9, 19, 13, 2, 19, 369, DateTimeKind.Local).AddTicks(4330));

            migrationBuilder.UpdateData(
                table: "Breeds",
                keyColumn: "Id",
                keyValue: 37,
                column: "CreatedTime",
                value: new DateTime(2024, 9, 19, 13, 2, 19, 369, DateTimeKind.Local).AddTicks(4340));

            migrationBuilder.UpdateData(
                table: "Breeds",
                keyColumn: "Id",
                keyValue: 38,
                column: "CreatedTime",
                value: new DateTime(2024, 9, 19, 13, 2, 19, 369, DateTimeKind.Local).AddTicks(4340));

            migrationBuilder.UpdateData(
                table: "Breeds",
                keyColumn: "Id",
                keyValue: 39,
                column: "CreatedTime",
                value: new DateTime(2024, 9, 19, 13, 2, 19, 369, DateTimeKind.Local).AddTicks(4340));

            migrationBuilder.UpdateData(
                table: "Breeds",
                keyColumn: "Id",
                keyValue: 40,
                column: "CreatedTime",
                value: new DateTime(2024, 9, 19, 13, 2, 19, 369, DateTimeKind.Local).AddTicks(4340));

            migrationBuilder.UpdateData(
                table: "Breeds",
                keyColumn: "Id",
                keyValue: 41,
                column: "CreatedTime",
                value: new DateTime(2024, 9, 19, 13, 2, 19, 369, DateTimeKind.Local).AddTicks(4340));

            migrationBuilder.UpdateData(
                table: "Breeds",
                keyColumn: "Id",
                keyValue: 42,
                column: "CreatedTime",
                value: new DateTime(2024, 9, 19, 13, 2, 19, 369, DateTimeKind.Local).AddTicks(4340));

            migrationBuilder.UpdateData(
                table: "Breeds",
                keyColumn: "Id",
                keyValue: 43,
                column: "CreatedTime",
                value: new DateTime(2024, 9, 19, 13, 2, 19, 369, DateTimeKind.Local).AddTicks(4340));

            migrationBuilder.UpdateData(
                table: "Breeds",
                keyColumn: "Id",
                keyValue: 44,
                column: "CreatedTime",
                value: new DateTime(2024, 9, 19, 13, 2, 19, 369, DateTimeKind.Local).AddTicks(4350));

            migrationBuilder.UpdateData(
                table: "Breeds",
                keyColumn: "Id",
                keyValue: 45,
                column: "CreatedTime",
                value: new DateTime(2024, 9, 19, 13, 2, 19, 369, DateTimeKind.Local).AddTicks(4350));

            migrationBuilder.UpdateData(
                table: "Breeds",
                keyColumn: "Id",
                keyValue: 46,
                column: "CreatedTime",
                value: new DateTime(2024, 9, 19, 13, 2, 19, 369, DateTimeKind.Local).AddTicks(4350));

            migrationBuilder.UpdateData(
                table: "Breeds",
                keyColumn: "Id",
                keyValue: 47,
                column: "CreatedTime",
                value: new DateTime(2024, 9, 19, 13, 2, 19, 369, DateTimeKind.Local).AddTicks(4350));

            migrationBuilder.UpdateData(
                table: "Breeds",
                keyColumn: "Id",
                keyValue: 48,
                column: "CreatedTime",
                value: new DateTime(2024, 9, 19, 13, 2, 19, 369, DateTimeKind.Local).AddTicks(4350));

            migrationBuilder.UpdateData(
                table: "Breeds",
                keyColumn: "Id",
                keyValue: 49,
                column: "CreatedTime",
                value: new DateTime(2024, 9, 19, 13, 2, 19, 369, DateTimeKind.Local).AddTicks(4350));

            migrationBuilder.UpdateData(
                table: "Breeds",
                keyColumn: "Id",
                keyValue: 50,
                column: "CreatedTime",
                value: new DateTime(2024, 9, 19, 13, 2, 19, 369, DateTimeKind.Local).AddTicks(4350));

            migrationBuilder.UpdateData(
                table: "Breeds",
                keyColumn: "Id",
                keyValue: 51,
                column: "CreatedTime",
                value: new DateTime(2024, 9, 19, 13, 2, 19, 369, DateTimeKind.Local).AddTicks(4360));

            migrationBuilder.UpdateData(
                table: "Breeds",
                keyColumn: "Id",
                keyValue: 52,
                column: "CreatedTime",
                value: new DateTime(2024, 9, 19, 13, 2, 19, 369, DateTimeKind.Local).AddTicks(4360));

            migrationBuilder.UpdateData(
                table: "Breeds",
                keyColumn: "Id",
                keyValue: 53,
                column: "CreatedTime",
                value: new DateTime(2024, 9, 19, 13, 2, 19, 369, DateTimeKind.Local).AddTicks(4360));

            migrationBuilder.UpdateData(
                table: "Breeds",
                keyColumn: "Id",
                keyValue: 54,
                column: "CreatedTime",
                value: new DateTime(2024, 9, 19, 13, 2, 19, 369, DateTimeKind.Local).AddTicks(4360));

            migrationBuilder.UpdateData(
                table: "Breeds",
                keyColumn: "Id",
                keyValue: 55,
                column: "CreatedTime",
                value: new DateTime(2024, 9, 19, 13, 2, 19, 369, DateTimeKind.Local).AddTicks(4360));

            migrationBuilder.UpdateData(
                table: "Breeds",
                keyColumn: "Id",
                keyValue: 56,
                column: "CreatedTime",
                value: new DateTime(2024, 9, 19, 13, 2, 19, 369, DateTimeKind.Local).AddTicks(4360));

            migrationBuilder.UpdateData(
                table: "Breeds",
                keyColumn: "Id",
                keyValue: 57,
                column: "CreatedTime",
                value: new DateTime(2024, 9, 19, 13, 2, 19, 369, DateTimeKind.Local).AddTicks(4360));

            migrationBuilder.UpdateData(
                table: "Breeds",
                keyColumn: "Id",
                keyValue: 58,
                column: "CreatedTime",
                value: new DateTime(2024, 9, 19, 13, 2, 19, 369, DateTimeKind.Local).AddTicks(4370));

            migrationBuilder.UpdateData(
                table: "Breeds",
                keyColumn: "Id",
                keyValue: 59,
                column: "CreatedTime",
                value: new DateTime(2024, 9, 19, 13, 2, 19, 369, DateTimeKind.Local).AddTicks(4370));

            migrationBuilder.UpdateData(
                table: "Breeds",
                keyColumn: "Id",
                keyValue: 60,
                column: "CreatedTime",
                value: new DateTime(2024, 9, 19, 13, 2, 19, 369, DateTimeKind.Local).AddTicks(4370));

            migrationBuilder.UpdateData(
                table: "Breeds",
                keyColumn: "Id",
                keyValue: 61,
                column: "CreatedTime",
                value: new DateTime(2024, 9, 19, 13, 2, 19, 369, DateTimeKind.Local).AddTicks(4370));

            migrationBuilder.UpdateData(
                table: "Breeds",
                keyColumn: "Id",
                keyValue: 62,
                column: "CreatedTime",
                value: new DateTime(2024, 9, 19, 13, 2, 19, 369, DateTimeKind.Local).AddTicks(4370));

            migrationBuilder.UpdateData(
                table: "Breeds",
                keyColumn: "Id",
                keyValue: 63,
                column: "CreatedTime",
                value: new DateTime(2024, 9, 19, 13, 2, 19, 369, DateTimeKind.Local).AddTicks(4370));

            migrationBuilder.UpdateData(
                table: "Breeds",
                keyColumn: "Id",
                keyValue: 64,
                column: "CreatedTime",
                value: new DateTime(2024, 9, 19, 13, 2, 19, 369, DateTimeKind.Local).AddTicks(4370));

            migrationBuilder.UpdateData(
                table: "Breeds",
                keyColumn: "Id",
                keyValue: 65,
                column: "CreatedTime",
                value: new DateTime(2024, 9, 19, 13, 2, 19, 369, DateTimeKind.Local).AddTicks(4380));

            migrationBuilder.UpdateData(
                table: "Breeds",
                keyColumn: "Id",
                keyValue: 66,
                column: "CreatedTime",
                value: new DateTime(2024, 9, 19, 13, 2, 19, 369, DateTimeKind.Local).AddTicks(4380));

            migrationBuilder.UpdateData(
                table: "Breeds",
                keyColumn: "Id",
                keyValue: 67,
                column: "CreatedTime",
                value: new DateTime(2024, 9, 19, 13, 2, 19, 369, DateTimeKind.Local).AddTicks(4380));

            migrationBuilder.UpdateData(
                table: "Breeds",
                keyColumn: "Id",
                keyValue: 68,
                column: "CreatedTime",
                value: new DateTime(2024, 9, 19, 13, 2, 19, 369, DateTimeKind.Local).AddTicks(4380));

            migrationBuilder.UpdateData(
                table: "Breeds",
                keyColumn: "Id",
                keyValue: 69,
                column: "CreatedTime",
                value: new DateTime(2024, 9, 19, 13, 2, 19, 369, DateTimeKind.Local).AddTicks(4380));

            migrationBuilder.UpdateData(
                table: "Breeds",
                keyColumn: "Id",
                keyValue: 70,
                column: "CreatedTime",
                value: new DateTime(2024, 9, 19, 13, 2, 19, 369, DateTimeKind.Local).AddTicks(4380));

            migrationBuilder.UpdateData(
                table: "Breeds",
                keyColumn: "Id",
                keyValue: 71,
                column: "CreatedTime",
                value: new DateTime(2024, 9, 19, 13, 2, 19, 369, DateTimeKind.Local).AddTicks(4380));

            migrationBuilder.UpdateData(
                table: "Breeds",
                keyColumn: "Id",
                keyValue: 72,
                column: "CreatedTime",
                value: new DateTime(2024, 9, 19, 13, 2, 19, 369, DateTimeKind.Local).AddTicks(4390));

            migrationBuilder.UpdateData(
                table: "Breeds",
                keyColumn: "Id",
                keyValue: 73,
                column: "CreatedTime",
                value: new DateTime(2024, 9, 19, 13, 2, 19, 369, DateTimeKind.Local).AddTicks(4390));

            migrationBuilder.UpdateData(
                table: "Breeds",
                keyColumn: "Id",
                keyValue: 74,
                column: "CreatedTime",
                value: new DateTime(2024, 9, 19, 13, 2, 19, 369, DateTimeKind.Local).AddTicks(4390));

            migrationBuilder.UpdateData(
                table: "Breeds",
                keyColumn: "Id",
                keyValue: 75,
                column: "CreatedTime",
                value: new DateTime(2024, 9, 19, 13, 2, 19, 369, DateTimeKind.Local).AddTicks(4390));

            migrationBuilder.UpdateData(
                table: "Breeds",
                keyColumn: "Id",
                keyValue: 76,
                column: "CreatedTime",
                value: new DateTime(2024, 9, 19, 13, 2, 19, 369, DateTimeKind.Local).AddTicks(4390));

            migrationBuilder.UpdateData(
                table: "Breeds",
                keyColumn: "Id",
                keyValue: 77,
                column: "CreatedTime",
                value: new DateTime(2024, 9, 19, 13, 2, 19, 369, DateTimeKind.Local).AddTicks(4390));

            migrationBuilder.UpdateData(
                table: "Breeds",
                keyColumn: "Id",
                keyValue: 78,
                column: "CreatedTime",
                value: new DateTime(2024, 9, 19, 13, 2, 19, 369, DateTimeKind.Local).AddTicks(4390));

            migrationBuilder.UpdateData(
                table: "Breeds",
                keyColumn: "Id",
                keyValue: 79,
                column: "CreatedTime",
                value: new DateTime(2024, 9, 19, 13, 2, 19, 369, DateTimeKind.Local).AddTicks(4400));

            migrationBuilder.UpdateData(
                table: "Breeds",
                keyColumn: "Id",
                keyValue: 80,
                column: "CreatedTime",
                value: new DateTime(2024, 9, 19, 13, 2, 19, 369, DateTimeKind.Local).AddTicks(4400));

            migrationBuilder.UpdateData(
                table: "Breeds",
                keyColumn: "Id",
                keyValue: 81,
                column: "CreatedTime",
                value: new DateTime(2024, 9, 19, 13, 2, 19, 369, DateTimeKind.Local).AddTicks(4400));

            migrationBuilder.UpdateData(
                table: "Breeds",
                keyColumn: "Id",
                keyValue: 82,
                column: "CreatedTime",
                value: new DateTime(2024, 9, 19, 13, 2, 19, 369, DateTimeKind.Local).AddTicks(4400));

            migrationBuilder.UpdateData(
                table: "Breeds",
                keyColumn: "Id",
                keyValue: 83,
                column: "CreatedTime",
                value: new DateTime(2024, 9, 19, 13, 2, 19, 369, DateTimeKind.Local).AddTicks(4400));

            migrationBuilder.UpdateData(
                table: "Breeds",
                keyColumn: "Id",
                keyValue: 84,
                column: "CreatedTime",
                value: new DateTime(2024, 9, 19, 13, 2, 19, 369, DateTimeKind.Local).AddTicks(4400));

            migrationBuilder.UpdateData(
                table: "Breeds",
                keyColumn: "Id",
                keyValue: 85,
                column: "CreatedTime",
                value: new DateTime(2024, 9, 19, 13, 2, 19, 369, DateTimeKind.Local).AddTicks(4400));

            migrationBuilder.UpdateData(
                table: "Breeds",
                keyColumn: "Id",
                keyValue: 86,
                column: "CreatedTime",
                value: new DateTime(2024, 9, 19, 13, 2, 19, 369, DateTimeKind.Local).AddTicks(4410));

            migrationBuilder.UpdateData(
                table: "Breeds",
                keyColumn: "Id",
                keyValue: 87,
                column: "CreatedTime",
                value: new DateTime(2024, 9, 19, 13, 2, 19, 369, DateTimeKind.Local).AddTicks(4410));

            migrationBuilder.UpdateData(
                table: "Breeds",
                keyColumn: "Id",
                keyValue: 88,
                column: "CreatedTime",
                value: new DateTime(2024, 9, 19, 13, 2, 19, 369, DateTimeKind.Local).AddTicks(4410));

            migrationBuilder.UpdateData(
                table: "Breeds",
                keyColumn: "Id",
                keyValue: 89,
                column: "CreatedTime",
                value: new DateTime(2024, 9, 19, 13, 2, 19, 369, DateTimeKind.Local).AddTicks(4410));

            migrationBuilder.UpdateData(
                table: "Breeds",
                keyColumn: "Id",
                keyValue: 90,
                column: "CreatedTime",
                value: new DateTime(2024, 9, 19, 13, 2, 19, 369, DateTimeKind.Local).AddTicks(4410));

            migrationBuilder.UpdateData(
                table: "Breeds",
                keyColumn: "Id",
                keyValue: 91,
                column: "CreatedTime",
                value: new DateTime(2024, 9, 19, 13, 2, 19, 369, DateTimeKind.Local).AddTicks(4410));

            migrationBuilder.UpdateData(
                table: "Breeds",
                keyColumn: "Id",
                keyValue: 92,
                column: "CreatedTime",
                value: new DateTime(2024, 9, 19, 13, 2, 19, 369, DateTimeKind.Local).AddTicks(4410));

            migrationBuilder.UpdateData(
                table: "Breeds",
                keyColumn: "Id",
                keyValue: 93,
                column: "CreatedTime",
                value: new DateTime(2024, 9, 19, 13, 2, 19, 369, DateTimeKind.Local).AddTicks(4420));

            migrationBuilder.UpdateData(
                table: "Breeds",
                keyColumn: "Id",
                keyValue: 94,
                column: "CreatedTime",
                value: new DateTime(2024, 9, 19, 13, 2, 19, 369, DateTimeKind.Local).AddTicks(4420));

            migrationBuilder.UpdateData(
                table: "Breeds",
                keyColumn: "Id",
                keyValue: 95,
                column: "CreatedTime",
                value: new DateTime(2024, 9, 19, 13, 2, 19, 369, DateTimeKind.Local).AddTicks(4420));

            migrationBuilder.UpdateData(
                table: "Breeds",
                keyColumn: "Id",
                keyValue: 96,
                column: "CreatedTime",
                value: new DateTime(2024, 9, 19, 13, 2, 19, 369, DateTimeKind.Local).AddTicks(4420));

            migrationBuilder.UpdateData(
                table: "Breeds",
                keyColumn: "Id",
                keyValue: 97,
                column: "CreatedTime",
                value: new DateTime(2024, 9, 19, 13, 2, 19, 369, DateTimeKind.Local).AddTicks(4420));

            migrationBuilder.UpdateData(
                table: "Breeds",
                keyColumn: "Id",
                keyValue: 98,
                column: "CreatedTime",
                value: new DateTime(2024, 9, 19, 13, 2, 19, 369, DateTimeKind.Local).AddTicks(4420));

            migrationBuilder.UpdateData(
                table: "Breeds",
                keyColumn: "Id",
                keyValue: 99,
                column: "CreatedTime",
                value: new DateTime(2024, 9, 19, 13, 2, 19, 369, DateTimeKind.Local).AddTicks(4420));

            migrationBuilder.UpdateData(
                table: "Breeds",
                keyColumn: "Id",
                keyValue: 100,
                column: "CreatedTime",
                value: new DateTime(2024, 9, 19, 13, 2, 19, 369, DateTimeKind.Local).AddTicks(4430));

            migrationBuilder.UpdateData(
                table: "Breeds",
                keyColumn: "Id",
                keyValue: 101,
                column: "CreatedTime",
                value: new DateTime(2024, 9, 19, 13, 2, 19, 369, DateTimeKind.Local).AddTicks(4430));

            migrationBuilder.UpdateData(
                table: "Breeds",
                keyColumn: "Id",
                keyValue: 102,
                column: "CreatedTime",
                value: new DateTime(2024, 9, 19, 13, 2, 19, 369, DateTimeKind.Local).AddTicks(4430));

            migrationBuilder.UpdateData(
                table: "Breeds",
                keyColumn: "Id",
                keyValue: 103,
                column: "CreatedTime",
                value: new DateTime(2024, 9, 19, 13, 2, 19, 369, DateTimeKind.Local).AddTicks(4430));

            migrationBuilder.UpdateData(
                table: "Breeds",
                keyColumn: "Id",
                keyValue: 104,
                column: "CreatedTime",
                value: new DateTime(2024, 9, 19, 13, 2, 19, 369, DateTimeKind.Local).AddTicks(4430));

            migrationBuilder.UpdateData(
                table: "Breeds",
                keyColumn: "Id",
                keyValue: 105,
                column: "CreatedTime",
                value: new DateTime(2024, 9, 19, 13, 2, 19, 369, DateTimeKind.Local).AddTicks(4430));

            migrationBuilder.UpdateData(
                table: "Breeds",
                keyColumn: "Id",
                keyValue: 106,
                column: "CreatedTime",
                value: new DateTime(2024, 9, 19, 13, 2, 19, 369, DateTimeKind.Local).AddTicks(4430));

            migrationBuilder.UpdateData(
                table: "Breeds",
                keyColumn: "Id",
                keyValue: 107,
                column: "CreatedTime",
                value: new DateTime(2024, 9, 19, 13, 2, 19, 369, DateTimeKind.Local).AddTicks(4440));

            migrationBuilder.UpdateData(
                table: "Breeds",
                keyColumn: "Id",
                keyValue: 108,
                column: "CreatedTime",
                value: new DateTime(2024, 9, 19, 13, 2, 19, 369, DateTimeKind.Local).AddTicks(4440));

            migrationBuilder.UpdateData(
                table: "Breeds",
                keyColumn: "Id",
                keyValue: 109,
                column: "CreatedTime",
                value: new DateTime(2024, 9, 19, 13, 2, 19, 369, DateTimeKind.Local).AddTicks(4440));

            migrationBuilder.UpdateData(
                table: "Breeds",
                keyColumn: "Id",
                keyValue: 110,
                column: "CreatedTime",
                value: new DateTime(2024, 9, 19, 13, 2, 19, 369, DateTimeKind.Local).AddTicks(4440));

            migrationBuilder.UpdateData(
                table: "Breeds",
                keyColumn: "Id",
                keyValue: 111,
                column: "CreatedTime",
                value: new DateTime(2024, 9, 19, 13, 2, 19, 369, DateTimeKind.Local).AddTicks(4440));

            migrationBuilder.UpdateData(
                table: "Breeds",
                keyColumn: "Id",
                keyValue: 112,
                column: "CreatedTime",
                value: new DateTime(2024, 9, 19, 13, 2, 19, 369, DateTimeKind.Local).AddTicks(4440));

            migrationBuilder.UpdateData(
                table: "Breeds",
                keyColumn: "Id",
                keyValue: 113,
                column: "CreatedTime",
                value: new DateTime(2024, 9, 19, 13, 2, 19, 369, DateTimeKind.Local).AddTicks(4440));

            migrationBuilder.UpdateData(
                table: "Breeds",
                keyColumn: "Id",
                keyValue: 114,
                column: "CreatedTime",
                value: new DateTime(2024, 9, 19, 13, 2, 19, 369, DateTimeKind.Local).AddTicks(4450));

            migrationBuilder.UpdateData(
                table: "Breeds",
                keyColumn: "Id",
                keyValue: 115,
                column: "CreatedTime",
                value: new DateTime(2024, 9, 19, 13, 2, 19, 369, DateTimeKind.Local).AddTicks(4450));

            migrationBuilder.UpdateData(
                table: "Breeds",
                keyColumn: "Id",
                keyValue: 116,
                column: "CreatedTime",
                value: new DateTime(2024, 9, 19, 13, 2, 19, 369, DateTimeKind.Local).AddTicks(4450));

            migrationBuilder.UpdateData(
                table: "Breeds",
                keyColumn: "Id",
                keyValue: 117,
                column: "CreatedTime",
                value: new DateTime(2024, 9, 19, 13, 2, 19, 369, DateTimeKind.Local).AddTicks(4450));

            migrationBuilder.UpdateData(
                table: "Breeds",
                keyColumn: "Id",
                keyValue: 118,
                column: "CreatedTime",
                value: new DateTime(2024, 9, 19, 13, 2, 19, 369, DateTimeKind.Local).AddTicks(4450));

            migrationBuilder.UpdateData(
                table: "Breeds",
                keyColumn: "Id",
                keyValue: 119,
                column: "CreatedTime",
                value: new DateTime(2024, 9, 19, 13, 2, 19, 369, DateTimeKind.Local).AddTicks(4450));

            migrationBuilder.UpdateData(
                table: "Breeds",
                keyColumn: "Id",
                keyValue: 120,
                column: "CreatedTime",
                value: new DateTime(2024, 9, 19, 13, 2, 19, 369, DateTimeKind.Local).AddTicks(4460));

            migrationBuilder.UpdateData(
                table: "Breeds",
                keyColumn: "Id",
                keyValue: 121,
                column: "CreatedTime",
                value: new DateTime(2024, 9, 19, 13, 2, 19, 369, DateTimeKind.Local).AddTicks(4460));

            migrationBuilder.UpdateData(
                table: "Breeds",
                keyColumn: "Id",
                keyValue: 122,
                column: "CreatedTime",
                value: new DateTime(2024, 9, 19, 13, 2, 19, 369, DateTimeKind.Local).AddTicks(4460));

            migrationBuilder.UpdateData(
                table: "Breeds",
                keyColumn: "Id",
                keyValue: 123,
                column: "CreatedTime",
                value: new DateTime(2024, 9, 19, 13, 2, 19, 369, DateTimeKind.Local).AddTicks(4460));

            migrationBuilder.UpdateData(
                table: "Breeds",
                keyColumn: "Id",
                keyValue: 124,
                column: "CreatedTime",
                value: new DateTime(2024, 9, 19, 13, 2, 19, 369, DateTimeKind.Local).AddTicks(4460));

            migrationBuilder.UpdateData(
                table: "Breeds",
                keyColumn: "Id",
                keyValue: 125,
                column: "CreatedTime",
                value: new DateTime(2024, 9, 19, 13, 2, 19, 369, DateTimeKind.Local).AddTicks(4460));

            migrationBuilder.UpdateData(
                table: "Breeds",
                keyColumn: "Id",
                keyValue: 126,
                column: "CreatedTime",
                value: new DateTime(2024, 9, 19, 13, 2, 19, 369, DateTimeKind.Local).AddTicks(4470));

            migrationBuilder.UpdateData(
                table: "Breeds",
                keyColumn: "Id",
                keyValue: 127,
                column: "CreatedTime",
                value: new DateTime(2024, 9, 19, 13, 2, 19, 369, DateTimeKind.Local).AddTicks(4470));

            migrationBuilder.UpdateData(
                table: "Breeds",
                keyColumn: "Id",
                keyValue: 128,
                column: "CreatedTime",
                value: new DateTime(2024, 9, 19, 13, 2, 19, 369, DateTimeKind.Local).AddTicks(4470));

            migrationBuilder.UpdateData(
                table: "Breeds",
                keyColumn: "Id",
                keyValue: 129,
                column: "CreatedTime",
                value: new DateTime(2024, 9, 19, 13, 2, 19, 369, DateTimeKind.Local).AddTicks(4470));

            migrationBuilder.UpdateData(
                table: "Breeds",
                keyColumn: "Id",
                keyValue: 130,
                column: "CreatedTime",
                value: new DateTime(2024, 9, 19, 13, 2, 19, 369, DateTimeKind.Local).AddTicks(4470));

            migrationBuilder.UpdateData(
                table: "Breeds",
                keyColumn: "Id",
                keyValue: 131,
                column: "CreatedTime",
                value: new DateTime(2024, 9, 19, 13, 2, 19, 369, DateTimeKind.Local).AddTicks(4470));

            migrationBuilder.UpdateData(
                table: "Breeds",
                keyColumn: "Id",
                keyValue: 132,
                column: "CreatedTime",
                value: new DateTime(2024, 9, 19, 13, 2, 19, 369, DateTimeKind.Local).AddTicks(4470));

            migrationBuilder.UpdateData(
                table: "Breeds",
                keyColumn: "Id",
                keyValue: 133,
                column: "CreatedTime",
                value: new DateTime(2024, 9, 19, 13, 2, 19, 369, DateTimeKind.Local).AddTicks(4480));

            migrationBuilder.UpdateData(
                table: "Breeds",
                keyColumn: "Id",
                keyValue: 134,
                column: "CreatedTime",
                value: new DateTime(2024, 9, 19, 13, 2, 19, 369, DateTimeKind.Local).AddTicks(4480));

            migrationBuilder.UpdateData(
                table: "Breeds",
                keyColumn: "Id",
                keyValue: 135,
                column: "CreatedTime",
                value: new DateTime(2024, 9, 19, 13, 2, 19, 369, DateTimeKind.Local).AddTicks(4480));

            migrationBuilder.UpdateData(
                table: "Breeds",
                keyColumn: "Id",
                keyValue: 136,
                column: "CreatedTime",
                value: new DateTime(2024, 9, 19, 13, 2, 19, 369, DateTimeKind.Local).AddTicks(4480));

            migrationBuilder.UpdateData(
                table: "Breeds",
                keyColumn: "Id",
                keyValue: 137,
                column: "CreatedTime",
                value: new DateTime(2024, 9, 19, 13, 2, 19, 369, DateTimeKind.Local).AddTicks(4480));

            migrationBuilder.UpdateData(
                table: "Breeds",
                keyColumn: "Id",
                keyValue: 138,
                column: "CreatedTime",
                value: new DateTime(2024, 9, 19, 13, 2, 19, 369, DateTimeKind.Local).AddTicks(4480));

            migrationBuilder.UpdateData(
                table: "Breeds",
                keyColumn: "Id",
                keyValue: 139,
                column: "CreatedTime",
                value: new DateTime(2024, 9, 19, 13, 2, 19, 369, DateTimeKind.Local).AddTicks(4480));

            migrationBuilder.UpdateData(
                table: "Breeds",
                keyColumn: "Id",
                keyValue: 140,
                column: "CreatedTime",
                value: new DateTime(2024, 9, 19, 13, 2, 19, 369, DateTimeKind.Local).AddTicks(4490));

            migrationBuilder.UpdateData(
                table: "Breeds",
                keyColumn: "Id",
                keyValue: 141,
                column: "CreatedTime",
                value: new DateTime(2024, 9, 19, 13, 2, 19, 369, DateTimeKind.Local).AddTicks(4490));

            migrationBuilder.UpdateData(
                table: "Breeds",
                keyColumn: "Id",
                keyValue: 142,
                column: "CreatedTime",
                value: new DateTime(2024, 9, 19, 13, 2, 19, 369, DateTimeKind.Local).AddTicks(4490));

            migrationBuilder.UpdateData(
                table: "Breeds",
                keyColumn: "Id",
                keyValue: 143,
                column: "CreatedTime",
                value: new DateTime(2024, 9, 19, 13, 2, 19, 369, DateTimeKind.Local).AddTicks(4490));

            migrationBuilder.UpdateData(
                table: "Breeds",
                keyColumn: "Id",
                keyValue: 144,
                column: "CreatedTime",
                value: new DateTime(2024, 9, 19, 13, 2, 19, 369, DateTimeKind.Local).AddTicks(4490));

            migrationBuilder.UpdateData(
                table: "Breeds",
                keyColumn: "Id",
                keyValue: 145,
                column: "CreatedTime",
                value: new DateTime(2024, 9, 19, 13, 2, 19, 369, DateTimeKind.Local).AddTicks(4490));

            migrationBuilder.UpdateData(
                table: "Breeds",
                keyColumn: "Id",
                keyValue: 146,
                column: "CreatedTime",
                value: new DateTime(2024, 9, 19, 13, 2, 19, 369, DateTimeKind.Local).AddTicks(4490));

            migrationBuilder.UpdateData(
                table: "Breeds",
                keyColumn: "Id",
                keyValue: 147,
                column: "CreatedTime",
                value: new DateTime(2024, 9, 19, 13, 2, 19, 369, DateTimeKind.Local).AddTicks(4500));

            migrationBuilder.UpdateData(
                table: "Breeds",
                keyColumn: "Id",
                keyValue: 148,
                column: "CreatedTime",
                value: new DateTime(2024, 9, 19, 13, 2, 19, 369, DateTimeKind.Local).AddTicks(4500));

            migrationBuilder.UpdateData(
                table: "Breeds",
                keyColumn: "Id",
                keyValue: 149,
                column: "CreatedTime",
                value: new DateTime(2024, 9, 19, 13, 2, 19, 369, DateTimeKind.Local).AddTicks(4500));

            migrationBuilder.UpdateData(
                table: "Breeds",
                keyColumn: "Id",
                keyValue: 150,
                column: "CreatedTime",
                value: new DateTime(2024, 9, 19, 13, 2, 19, 369, DateTimeKind.Local).AddTicks(4500));

            migrationBuilder.UpdateData(
                table: "Breeds",
                keyColumn: "Id",
                keyValue: 151,
                column: "CreatedTime",
                value: new DateTime(2024, 9, 19, 13, 2, 19, 369, DateTimeKind.Local).AddTicks(4500));

            migrationBuilder.UpdateData(
                table: "Breeds",
                keyColumn: "Id",
                keyValue: 152,
                column: "CreatedTime",
                value: new DateTime(2024, 9, 19, 13, 2, 19, 369, DateTimeKind.Local).AddTicks(4500));

            migrationBuilder.UpdateData(
                table: "Breeds",
                keyColumn: "Id",
                keyValue: 153,
                column: "CreatedTime",
                value: new DateTime(2024, 9, 19, 13, 2, 19, 369, DateTimeKind.Local).AddTicks(4500));

            migrationBuilder.UpdateData(
                table: "Breeds",
                keyColumn: "Id",
                keyValue: 154,
                column: "CreatedTime",
                value: new DateTime(2024, 9, 19, 13, 2, 19, 369, DateTimeKind.Local).AddTicks(4510));

            migrationBuilder.UpdateData(
                table: "Breeds",
                keyColumn: "Id",
                keyValue: 155,
                column: "CreatedTime",
                value: new DateTime(2024, 9, 19, 13, 2, 19, 369, DateTimeKind.Local).AddTicks(4510));

            migrationBuilder.UpdateData(
                table: "Breeds",
                keyColumn: "Id",
                keyValue: 156,
                column: "CreatedTime",
                value: new DateTime(2024, 9, 19, 13, 2, 19, 369, DateTimeKind.Local).AddTicks(4510));

            migrationBuilder.UpdateData(
                table: "Breeds",
                keyColumn: "Id",
                keyValue: 157,
                column: "CreatedTime",
                value: new DateTime(2024, 9, 19, 13, 2, 19, 369, DateTimeKind.Local).AddTicks(4510));

            migrationBuilder.UpdateData(
                table: "Breeds",
                keyColumn: "Id",
                keyValue: 158,
                column: "CreatedTime",
                value: new DateTime(2024, 9, 19, 13, 2, 19, 369, DateTimeKind.Local).AddTicks(4510));

            migrationBuilder.UpdateData(
                table: "Breeds",
                keyColumn: "Id",
                keyValue: 159,
                column: "CreatedTime",
                value: new DateTime(2024, 9, 19, 13, 2, 19, 369, DateTimeKind.Local).AddTicks(4510));

            migrationBuilder.UpdateData(
                table: "Breeds",
                keyColumn: "Id",
                keyValue: 160,
                column: "CreatedTime",
                value: new DateTime(2024, 9, 19, 13, 2, 19, 369, DateTimeKind.Local).AddTicks(4510));

            migrationBuilder.UpdateData(
                table: "PetTypes",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedTime",
                value: new DateTime(2024, 9, 19, 13, 2, 19, 369, DateTimeKind.Local).AddTicks(3600));

            migrationBuilder.UpdateData(
                table: "PetTypes",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreatedTime",
                value: new DateTime(2024, 9, 19, 13, 2, 19, 369, DateTimeKind.Local).AddTicks(3600));

            migrationBuilder.UpdateData(
                table: "PetTypes",
                keyColumn: "Id",
                keyValue: 3,
                column: "CreatedTime",
                value: new DateTime(2024, 9, 19, 13, 2, 19, 369, DateTimeKind.Local).AddTicks(3610));

            migrationBuilder.UpdateData(
                table: "PetTypes",
                keyColumn: "Id",
                keyValue: 4,
                column: "CreatedTime",
                value: new DateTime(2024, 9, 19, 13, 2, 19, 369, DateTimeKind.Local).AddTicks(3610));

            migrationBuilder.UpdateData(
                table: "PetTypes",
                keyColumn: "Id",
                keyValue: 5,
                column: "CreatedTime",
                value: new DateTime(2024, 9, 19, 13, 2, 19, 369, DateTimeKind.Local).AddTicks(3610));

            migrationBuilder.UpdateData(
                table: "PetTypes",
                keyColumn: "Id",
                keyValue: 6,
                column: "CreatedTime",
                value: new DateTime(2024, 9, 19, 13, 2, 19, 369, DateTimeKind.Local).AddTicks(3610));

            migrationBuilder.UpdateData(
                table: "PetTypes",
                keyColumn: "Id",
                keyValue: 7,
                column: "CreatedTime",
                value: new DateTime(2024, 9, 19, 13, 2, 19, 369, DateTimeKind.Local).AddTicks(3610));

            migrationBuilder.UpdateData(
                table: "PetTypes",
                keyColumn: "Id",
                keyValue: 8,
                column: "CreatedTime",
                value: new DateTime(2024, 9, 19, 13, 2, 19, 369, DateTimeKind.Local).AddTicks(3610));

            migrationBuilder.UpdateData(
                table: "Pets",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedTime",
                value: new DateTime(2024, 4, 19, 13, 2, 19, 371, DateTimeKind.Local).AddTicks(4180));

            migrationBuilder.UpdateData(
                table: "Pets",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreatedTime",
                value: new DateTime(2024, 2, 19, 13, 2, 19, 371, DateTimeKind.Local).AddTicks(4190));

            migrationBuilder.UpdateData(
                table: "Pets",
                keyColumn: "Id",
                keyValue: 3,
                column: "CreatedTime",
                value: new DateTime(2024, 8, 19, 13, 2, 19, 371, DateTimeKind.Local).AddTicks(4200));

            migrationBuilder.UpdateData(
                table: "Pets",
                keyColumn: "Id",
                keyValue: 4,
                column: "CreatedTime",
                value: new DateTime(2024, 4, 19, 13, 2, 19, 371, DateTimeKind.Local).AddTicks(4200));

            migrationBuilder.UpdateData(
                table: "Pets",
                keyColumn: "Id",
                keyValue: 5,
                column: "CreatedTime",
                value: new DateTime(2024, 8, 19, 13, 2, 19, 371, DateTimeKind.Local).AddTicks(4210));

            migrationBuilder.UpdateData(
                table: "Pets",
                keyColumn: "Id",
                keyValue: 6,
                column: "CreatedTime",
                value: new DateTime(2023, 11, 19, 13, 2, 19, 371, DateTimeKind.Local).AddTicks(4210));

            migrationBuilder.UpdateData(
                table: "Pets",
                keyColumn: "Id",
                keyValue: 7,
                column: "CreatedTime",
                value: new DateTime(2024, 7, 19, 13, 2, 19, 371, DateTimeKind.Local).AddTicks(4220));

            migrationBuilder.UpdateData(
                table: "Pets",
                keyColumn: "Id",
                keyValue: 8,
                column: "CreatedTime",
                value: new DateTime(2024, 6, 19, 13, 2, 19, 371, DateTimeKind.Local).AddTicks(4220));

            migrationBuilder.UpdateData(
                table: "Pets",
                keyColumn: "Id",
                keyValue: 9,
                column: "CreatedTime",
                value: new DateTime(2023, 12, 19, 13, 2, 19, 371, DateTimeKind.Local).AddTicks(4230));

            migrationBuilder.UpdateData(
                table: "Pets",
                keyColumn: "Id",
                keyValue: 10,
                column: "CreatedTime",
                value: new DateTime(2024, 4, 19, 13, 2, 19, 371, DateTimeKind.Local).AddTicks(4230));

            migrationBuilder.UpdateData(
                table: "Pets",
                keyColumn: "Id",
                keyValue: 11,
                column: "CreatedTime",
                value: new DateTime(2024, 7, 19, 13, 2, 19, 371, DateTimeKind.Local).AddTicks(4240));

            migrationBuilder.UpdateData(
                table: "Pets",
                keyColumn: "Id",
                keyValue: 12,
                column: "CreatedTime",
                value: new DateTime(2024, 5, 19, 13, 2, 19, 371, DateTimeKind.Local).AddTicks(4240));

            migrationBuilder.UpdateData(
                table: "Pets",
                keyColumn: "Id",
                keyValue: 13,
                column: "CreatedTime",
                value: new DateTime(2024, 7, 19, 13, 2, 19, 371, DateTimeKind.Local).AddTicks(4240));

            migrationBuilder.UpdateData(
                table: "Pets",
                keyColumn: "Id",
                keyValue: 14,
                column: "CreatedTime",
                value: new DateTime(2024, 7, 19, 13, 2, 19, 371, DateTimeKind.Local).AddTicks(4250));

            migrationBuilder.UpdateData(
                table: "Pets",
                keyColumn: "Id",
                keyValue: 15,
                column: "CreatedTime",
                value: new DateTime(2024, 3, 19, 13, 2, 19, 371, DateTimeKind.Local).AddTicks(4250));

            migrationBuilder.UpdateData(
                table: "Pets",
                keyColumn: "Id",
                keyValue: 16,
                column: "CreatedTime",
                value: new DateTime(2024, 8, 19, 13, 2, 19, 371, DateTimeKind.Local).AddTicks(4260));

            migrationBuilder.UpdateData(
                table: "Pets",
                keyColumn: "Id",
                keyValue: 17,
                column: "CreatedTime",
                value: new DateTime(2024, 3, 19, 13, 2, 19, 371, DateTimeKind.Local).AddTicks(4260));

            migrationBuilder.UpdateData(
                table: "Pets",
                keyColumn: "Id",
                keyValue: 18,
                column: "CreatedTime",
                value: new DateTime(2024, 2, 19, 13, 2, 19, 371, DateTimeKind.Local).AddTicks(4270));

            migrationBuilder.UpdateData(
                table: "Pets",
                keyColumn: "Id",
                keyValue: 19,
                column: "CreatedTime",
                value: new DateTime(2024, 7, 19, 13, 2, 19, 371, DateTimeKind.Local).AddTicks(4290));

            migrationBuilder.UpdateData(
                table: "Pets",
                keyColumn: "Id",
                keyValue: 20,
                column: "CreatedTime",
                value: new DateTime(2023, 10, 19, 13, 2, 19, 371, DateTimeKind.Local).AddTicks(4300));

            migrationBuilder.UpdateData(
                table: "Pets",
                keyColumn: "Id",
                keyValue: 21,
                column: "CreatedTime",
                value: new DateTime(2024, 8, 19, 13, 2, 19, 371, DateTimeKind.Local).AddTicks(4300));

            migrationBuilder.UpdateData(
                table: "Pets",
                keyColumn: "Id",
                keyValue: 22,
                column: "CreatedTime",
                value: new DateTime(2024, 1, 19, 13, 2, 19, 371, DateTimeKind.Local).AddTicks(4310));

            migrationBuilder.UpdateData(
                table: "Pets",
                keyColumn: "Id",
                keyValue: 23,
                column: "CreatedTime",
                value: new DateTime(2023, 11, 19, 13, 2, 19, 371, DateTimeKind.Local).AddTicks(4310));

            migrationBuilder.UpdateData(
                table: "Pets",
                keyColumn: "Id",
                keyValue: 24,
                column: "CreatedTime",
                value: new DateTime(2024, 8, 19, 13, 2, 19, 371, DateTimeKind.Local).AddTicks(4320));

            migrationBuilder.UpdateData(
                table: "Pets",
                keyColumn: "Id",
                keyValue: 25,
                column: "CreatedTime",
                value: new DateTime(2024, 5, 19, 13, 2, 19, 371, DateTimeKind.Local).AddTicks(4320));

            migrationBuilder.UpdateData(
                table: "Pets",
                keyColumn: "Id",
                keyValue: 26,
                column: "CreatedTime",
                value: new DateTime(2023, 12, 19, 13, 2, 19, 371, DateTimeKind.Local).AddTicks(4330));

            migrationBuilder.UpdateData(
                table: "Pets",
                keyColumn: "Id",
                keyValue: 27,
                column: "CreatedTime",
                value: new DateTime(2024, 5, 19, 13, 2, 19, 371, DateTimeKind.Local).AddTicks(4330));

            migrationBuilder.UpdateData(
                table: "Pets",
                keyColumn: "Id",
                keyValue: 28,
                column: "CreatedTime",
                value: new DateTime(2024, 1, 19, 13, 2, 19, 371, DateTimeKind.Local).AddTicks(4340));

            migrationBuilder.UpdateData(
                table: "Pets",
                keyColumn: "Id",
                keyValue: 29,
                column: "CreatedTime",
                value: new DateTime(2024, 3, 19, 13, 2, 19, 371, DateTimeKind.Local).AddTicks(4340));

            migrationBuilder.UpdateData(
                table: "Pets",
                keyColumn: "Id",
                keyValue: 30,
                column: "CreatedTime",
                value: new DateTime(2024, 1, 19, 13, 2, 19, 371, DateTimeKind.Local).AddTicks(4350));

            migrationBuilder.UpdateData(
                table: "Pets",
                keyColumn: "Id",
                keyValue: 31,
                column: "CreatedTime",
                value: new DateTime(2023, 12, 19, 13, 2, 19, 371, DateTimeKind.Local).AddTicks(4350));

            migrationBuilder.UpdateData(
                table: "Pets",
                keyColumn: "Id",
                keyValue: 32,
                column: "CreatedTime",
                value: new DateTime(2024, 8, 19, 13, 2, 19, 371, DateTimeKind.Local).AddTicks(4360));

            migrationBuilder.UpdateData(
                table: "Pets",
                keyColumn: "Id",
                keyValue: 33,
                column: "CreatedTime",
                value: new DateTime(2023, 12, 19, 13, 2, 19, 371, DateTimeKind.Local).AddTicks(4360));

            migrationBuilder.UpdateData(
                table: "Pets",
                keyColumn: "Id",
                keyValue: 34,
                column: "CreatedTime",
                value: new DateTime(2024, 5, 19, 13, 2, 19, 371, DateTimeKind.Local).AddTicks(4360));

            migrationBuilder.UpdateData(
                table: "Pets",
                keyColumn: "Id",
                keyValue: 35,
                column: "CreatedTime",
                value: new DateTime(2024, 6, 19, 13, 2, 19, 371, DateTimeKind.Local).AddTicks(4370));

            migrationBuilder.UpdateData(
                table: "Pets",
                keyColumn: "Id",
                keyValue: 36,
                column: "CreatedTime",
                value: new DateTime(2024, 4, 19, 13, 2, 19, 371, DateTimeKind.Local).AddTicks(4370));

            migrationBuilder.UpdateData(
                table: "Pets",
                keyColumn: "Id",
                keyValue: 37,
                column: "CreatedTime",
                value: new DateTime(2024, 2, 19, 13, 2, 19, 371, DateTimeKind.Local).AddTicks(4380));

            migrationBuilder.UpdateData(
                table: "Pets",
                keyColumn: "Id",
                keyValue: 38,
                column: "CreatedTime",
                value: new DateTime(2024, 5, 19, 13, 2, 19, 371, DateTimeKind.Local).AddTicks(4380));

            migrationBuilder.UpdateData(
                table: "Pets",
                keyColumn: "Id",
                keyValue: 39,
                column: "CreatedTime",
                value: new DateTime(2023, 10, 19, 13, 2, 19, 371, DateTimeKind.Local).AddTicks(4390));

            migrationBuilder.UpdateData(
                table: "Pets",
                keyColumn: "Id",
                keyValue: 40,
                column: "CreatedTime",
                value: new DateTime(2024, 6, 19, 13, 2, 19, 371, DateTimeKind.Local).AddTicks(4390));

            migrationBuilder.UpdateData(
                table: "Pets",
                keyColumn: "Id",
                keyValue: 41,
                column: "CreatedTime",
                value: new DateTime(2024, 6, 19, 13, 2, 19, 371, DateTimeKind.Local).AddTicks(4400));

            migrationBuilder.UpdateData(
                table: "Pets",
                keyColumn: "Id",
                keyValue: 42,
                column: "CreatedTime",
                value: new DateTime(2023, 12, 19, 13, 2, 19, 371, DateTimeKind.Local).AddTicks(4400));

            migrationBuilder.UpdateData(
                table: "Pets",
                keyColumn: "Id",
                keyValue: 43,
                column: "CreatedTime",
                value: new DateTime(2024, 6, 19, 13, 2, 19, 371, DateTimeKind.Local).AddTicks(4410));

            migrationBuilder.UpdateData(
                table: "Pets",
                keyColumn: "Id",
                keyValue: 44,
                column: "CreatedTime",
                value: new DateTime(2024, 5, 19, 13, 2, 19, 371, DateTimeKind.Local).AddTicks(4410));

            migrationBuilder.UpdateData(
                table: "Pets",
                keyColumn: "Id",
                keyValue: 45,
                column: "CreatedTime",
                value: new DateTime(2024, 4, 19, 13, 2, 19, 371, DateTimeKind.Local).AddTicks(4420));

            migrationBuilder.UpdateData(
                table: "Pets",
                keyColumn: "Id",
                keyValue: 46,
                column: "CreatedTime",
                value: new DateTime(2024, 2, 19, 13, 2, 19, 371, DateTimeKind.Local).AddTicks(4420));

            migrationBuilder.UpdateData(
                table: "Pets",
                keyColumn: "Id",
                keyValue: 47,
                column: "CreatedTime",
                value: new DateTime(2024, 2, 19, 13, 2, 19, 371, DateTimeKind.Local).AddTicks(4420));

            migrationBuilder.UpdateData(
                table: "Pets",
                keyColumn: "Id",
                keyValue: 48,
                column: "CreatedTime",
                value: new DateTime(2024, 5, 19, 13, 2, 19, 371, DateTimeKind.Local).AddTicks(4430));

            migrationBuilder.UpdateData(
                table: "Pets",
                keyColumn: "Id",
                keyValue: 49,
                column: "CreatedTime",
                value: new DateTime(2024, 7, 19, 13, 2, 19, 371, DateTimeKind.Local).AddTicks(4430));

            migrationBuilder.UpdateData(
                table: "Pets",
                keyColumn: "Id",
                keyValue: 50,
                column: "CreatedTime",
                value: new DateTime(2024, 2, 19, 13, 2, 19, 371, DateTimeKind.Local).AddTicks(4440));

            migrationBuilder.UpdateData(
                table: "Shelters",
                keyColumn: "Id",
                keyValue: 1021,
                columns: new[] { "CreatedTime", "LastUpdatedTime" },
                values: new object[] { new DateTime(2024, 9, 19, 9, 2, 19, 369, DateTimeKind.Utc).AddTicks(3250), new DateTime(2024, 9, 19, 9, 2, 19, 369, DateTimeKind.Utc).AddTicks(3250) });

            migrationBuilder.UpdateData(
                table: "Shelters",
                keyColumn: "Id",
                keyValue: 1022,
                columns: new[] { "CreatedTime", "LastUpdatedTime" },
                values: new object[] { new DateTime(2024, 9, 19, 9, 2, 19, 369, DateTimeKind.Utc).AddTicks(3270), new DateTime(2024, 9, 19, 9, 2, 19, 369, DateTimeKind.Utc).AddTicks(3270) });

            migrationBuilder.UpdateData(
                table: "Shelters",
                keyColumn: "Id",
                keyValue: 1023,
                columns: new[] { "CreatedTime", "LastUpdatedTime" },
                values: new object[] { new DateTime(2024, 9, 19, 9, 2, 19, 369, DateTimeKind.Utc).AddTicks(3270), new DateTime(2024, 9, 19, 9, 2, 19, 369, DateTimeKind.Utc).AddTicks(3270) });

            migrationBuilder.UpdateData(
                table: "Shelters",
                keyColumn: "Id",
                keyValue: 1024,
                columns: new[] { "CreatedTime", "LastUpdatedTime" },
                values: new object[] { new DateTime(2024, 9, 19, 9, 2, 19, 369, DateTimeKind.Utc).AddTicks(3280), new DateTime(2024, 9, 19, 9, 2, 19, 369, DateTimeKind.Utc).AddTicks(3280) });

            migrationBuilder.UpdateData(
                table: "Shelters",
                keyColumn: "Id",
                keyValue: 1025,
                columns: new[] { "CreatedTime", "LastUpdatedTime" },
                values: new object[] { new DateTime(2024, 9, 19, 9, 2, 19, 369, DateTimeKind.Utc).AddTicks(3280), new DateTime(2024, 9, 19, 9, 2, 19, 369, DateTimeKind.Utc).AddTicks(3280) });

            migrationBuilder.UpdateData(
                table: "Shelters",
                keyColumn: "Id",
                keyValue: 1026,
                columns: new[] { "CreatedTime", "LastUpdatedTime" },
                values: new object[] { new DateTime(2024, 9, 19, 9, 2, 19, 369, DateTimeKind.Utc).AddTicks(3290), new DateTime(2024, 9, 19, 9, 2, 19, 369, DateTimeKind.Utc).AddTicks(3290) });

            migrationBuilder.UpdateData(
                table: "Shelters",
                keyColumn: "Id",
                keyValue: 1027,
                columns: new[] { "CreatedTime", "LastUpdatedTime" },
                values: new object[] { new DateTime(2024, 9, 19, 9, 2, 19, 369, DateTimeKind.Utc).AddTicks(3310), new DateTime(2024, 9, 19, 9, 2, 19, 369, DateTimeKind.Utc).AddTicks(3310) });

            migrationBuilder.UpdateData(
                table: "Shelters",
                keyColumn: "Id",
                keyValue: 1028,
                columns: new[] { "CreatedTime", "LastUpdatedTime" },
                values: new object[] { new DateTime(2024, 9, 19, 9, 2, 19, 369, DateTimeKind.Utc).AddTicks(3320), new DateTime(2024, 9, 19, 9, 2, 19, 369, DateTimeKind.Utc).AddTicks(3320) });

            migrationBuilder.UpdateData(
                table: "Shelters",
                keyColumn: "Id",
                keyValue: 1029,
                columns: new[] { "CreatedTime", "LastUpdatedTime" },
                values: new object[] { new DateTime(2024, 9, 19, 9, 2, 19, 369, DateTimeKind.Utc).AddTicks(3330), new DateTime(2024, 9, 19, 9, 2, 19, 369, DateTimeKind.Utc).AddTicks(3330) });

            migrationBuilder.UpdateData(
                table: "Shelters",
                keyColumn: "Id",
                keyValue: 1030,
                columns: new[] { "CreatedTime", "LastUpdatedTime" },
                values: new object[] { new DateTime(2024, 9, 19, 9, 2, 19, 369, DateTimeKind.Utc).AddTicks(3330), new DateTime(2024, 9, 19, 9, 2, 19, 369, DateTimeKind.Utc).AddTicks(3330) });

            migrationBuilder.UpdateData(
                table: "Shelters",
                keyColumn: "Id",
                keyValue: 1031,
                columns: new[] { "CreatedTime", "LastUpdatedTime" },
                values: new object[] { new DateTime(2024, 9, 19, 9, 2, 19, 369, DateTimeKind.Utc).AddTicks(3340), new DateTime(2024, 9, 19, 9, 2, 19, 369, DateTimeKind.Utc).AddTicks(3340) });

            migrationBuilder.UpdateData(
                table: "Shelters",
                keyColumn: "Id",
                keyValue: 1032,
                columns: new[] { "CreatedTime", "LastUpdatedTime" },
                values: new object[] { new DateTime(2024, 9, 19, 9, 2, 19, 369, DateTimeKind.Utc).AddTicks(3340), new DateTime(2024, 9, 19, 9, 2, 19, 369, DateTimeKind.Utc).AddTicks(3340) });

            migrationBuilder.UpdateData(
                table: "Shelters",
                keyColumn: "Id",
                keyValue: 1033,
                columns: new[] { "CreatedTime", "LastUpdatedTime" },
                values: new object[] { new DateTime(2024, 9, 19, 9, 2, 19, 369, DateTimeKind.Utc).AddTicks(3350), new DateTime(2024, 9, 19, 9, 2, 19, 369, DateTimeKind.Utc).AddTicks(3350) });

            migrationBuilder.UpdateData(
                table: "Shelters",
                keyColumn: "Id",
                keyValue: 1034,
                columns: new[] { "CreatedTime", "LastUpdatedTime" },
                values: new object[] { new DateTime(2024, 9, 19, 9, 2, 19, 369, DateTimeKind.Utc).AddTicks(3360), new DateTime(2024, 9, 19, 9, 2, 19, 369, DateTimeKind.Utc).AddTicks(3360) });

            migrationBuilder.UpdateData(
                table: "Shelters",
                keyColumn: "Id",
                keyValue: 1035,
                columns: new[] { "CreatedTime", "LastUpdatedTime" },
                values: new object[] { new DateTime(2024, 9, 19, 9, 2, 19, 369, DateTimeKind.Utc).AddTicks(3360), new DateTime(2024, 9, 19, 9, 2, 19, 369, DateTimeKind.Utc).AddTicks(3360) });

            migrationBuilder.UpdateData(
                table: "Shelters",
                keyColumn: "Id",
                keyValue: 1036,
                columns: new[] { "CreatedTime", "LastUpdatedTime" },
                values: new object[] { new DateTime(2024, 9, 19, 9, 2, 19, 369, DateTimeKind.Utc).AddTicks(3370), new DateTime(2024, 9, 19, 9, 2, 19, 369, DateTimeKind.Utc).AddTicks(3370) });

            migrationBuilder.UpdateData(
                table: "Shelters",
                keyColumn: "Id",
                keyValue: 1037,
                columns: new[] { "CreatedTime", "LastUpdatedTime" },
                values: new object[] { new DateTime(2024, 9, 19, 9, 2, 19, 369, DateTimeKind.Utc).AddTicks(3370), new DateTime(2024, 9, 19, 9, 2, 19, 369, DateTimeKind.Utc).AddTicks(3370) });

            migrationBuilder.UpdateData(
                table: "Shelters",
                keyColumn: "Id",
                keyValue: 1038,
                columns: new[] { "CreatedTime", "LastUpdatedTime" },
                values: new object[] { new DateTime(2024, 9, 19, 9, 2, 19, 369, DateTimeKind.Utc).AddTicks(3380), new DateTime(2024, 9, 19, 9, 2, 19, 369, DateTimeKind.Utc).AddTicks(3380) });

            migrationBuilder.UpdateData(
                table: "Shelters",
                keyColumn: "Id",
                keyValue: 1039,
                columns: new[] { "CreatedTime", "LastUpdatedTime" },
                values: new object[] { new DateTime(2024, 9, 19, 9, 2, 19, 369, DateTimeKind.Utc).AddTicks(3390), new DateTime(2024, 9, 19, 9, 2, 19, 369, DateTimeKind.Utc).AddTicks(3390) });

            migrationBuilder.UpdateData(
                table: "Shelters",
                keyColumn: "Id",
                keyValue: 1040,
                columns: new[] { "CreatedTime", "LastUpdatedTime" },
                values: new object[] { new DateTime(2024, 9, 19, 9, 2, 19, 369, DateTimeKind.Utc).AddTicks(3390), new DateTime(2024, 9, 19, 9, 2, 19, 369, DateTimeKind.Utc).AddTicks(3390) });
        }
    }
}
