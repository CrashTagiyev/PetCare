using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Persistance.Migrations
{
    /// <inheritdoc />
    public partial class mig999 : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<string>(
                name: "PhoneNumber",
                table: "Shelters",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: 2001,
                columns: new[] { "ConcurrencyStamp", "CreatedTime", "LastUpdatedTime", "RefreshTokenCreateTime" },
                values: new object[] { "88903787-1703-4bd9-9ffb-e778c7e8d8a9", new DateTime(2024, 8, 29, 11, 10, 46, 309, DateTimeKind.Utc).AddTicks(3277), new DateTime(2024, 8, 29, 11, 10, 46, 309, DateTimeKind.Utc).AddTicks(3279), new DateTime(2024, 8, 29, 11, 10, 46, 309, DateTimeKind.Utc).AddTicks(3193) });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: 2002,
                columns: new[] { "ConcurrencyStamp", "CreatedTime", "LastUpdatedTime", "RefreshTokenCreateTime" },
                values: new object[] { "f3e8865d-b552-4822-abb2-3b159140752b", new DateTime(2024, 8, 29, 11, 10, 46, 309, DateTimeKind.Utc).AddTicks(3357), new DateTime(2024, 8, 29, 11, 10, 46, 309, DateTimeKind.Utc).AddTicks(3357), new DateTime(2024, 8, 29, 11, 10, 46, 309, DateTimeKind.Utc).AddTicks(3352) });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: 2003,
                columns: new[] { "ConcurrencyStamp", "CreatedTime", "LastUpdatedTime", "RefreshTokenCreateTime" },
                values: new object[] { "06bbf52d-1996-430e-aeca-1d5bff8212e5", new DateTime(2024, 8, 29, 11, 10, 46, 309, DateTimeKind.Utc).AddTicks(3423), new DateTime(2024, 8, 29, 11, 10, 46, 309, DateTimeKind.Utc).AddTicks(3424), new DateTime(2024, 8, 29, 11, 10, 46, 309, DateTimeKind.Utc).AddTicks(3419) });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: 2004,
                columns: new[] { "ConcurrencyStamp", "CreatedTime", "LastUpdatedTime", "RefreshTokenCreateTime" },
                values: new object[] { "daef3ed1-7313-452b-bfb4-8bce343ca444", new DateTime(2024, 8, 29, 11, 10, 46, 309, DateTimeKind.Utc).AddTicks(3447), new DateTime(2024, 8, 29, 11, 10, 46, 309, DateTimeKind.Utc).AddTicks(3447), new DateTime(2024, 8, 29, 11, 10, 46, 309, DateTimeKind.Utc).AddTicks(3442) });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: 2005,
                columns: new[] { "ConcurrencyStamp", "CreatedTime", "LastUpdatedTime", "RefreshTokenCreateTime" },
                values: new object[] { "1955fd04-307e-408c-97a9-31beead6a3fb", new DateTime(2024, 8, 29, 11, 10, 46, 309, DateTimeKind.Utc).AddTicks(3460), new DateTime(2024, 8, 29, 11, 10, 46, 309, DateTimeKind.Utc).AddTicks(3460), new DateTime(2024, 8, 29, 11, 10, 46, 309, DateTimeKind.Utc).AddTicks(3457) });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: 2006,
                columns: new[] { "ConcurrencyStamp", "CreatedTime", "LastUpdatedTime", "RefreshTokenCreateTime" },
                values: new object[] { "7937de6f-ff25-48a5-9a45-a0182586cf10", new DateTime(2024, 8, 29, 11, 10, 46, 309, DateTimeKind.Utc).AddTicks(3502), new DateTime(2024, 8, 29, 11, 10, 46, 309, DateTimeKind.Utc).AddTicks(3502), new DateTime(2024, 8, 29, 11, 10, 46, 309, DateTimeKind.Utc).AddTicks(3497) });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: 2007,
                columns: new[] { "ConcurrencyStamp", "CreatedTime", "LastUpdatedTime", "RefreshTokenCreateTime" },
                values: new object[] { "53c78c6e-2892-4614-b226-a38939c83b92", new DateTime(2024, 8, 29, 11, 10, 46, 309, DateTimeKind.Utc).AddTicks(3533), new DateTime(2024, 8, 29, 11, 10, 46, 309, DateTimeKind.Utc).AddTicks(3533), new DateTime(2024, 8, 29, 11, 10, 46, 309, DateTimeKind.Utc).AddTicks(3512) });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: 2008,
                columns: new[] { "ConcurrencyStamp", "CreatedTime", "LastUpdatedTime", "RefreshTokenCreateTime" },
                values: new object[] { "14b82810-1dd0-4a5f-9691-035a3e5969ba", new DateTime(2024, 8, 29, 11, 10, 46, 309, DateTimeKind.Utc).AddTicks(3551), new DateTime(2024, 8, 29, 11, 10, 46, 309, DateTimeKind.Utc).AddTicks(3552), new DateTime(2024, 8, 29, 11, 10, 46, 309, DateTimeKind.Utc).AddTicks(3542) });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: 2009,
                columns: new[] { "ConcurrencyStamp", "CreatedTime", "LastUpdatedTime", "RefreshTokenCreateTime" },
                values: new object[] { "2b1221c9-a1df-4e94-9c4a-0b69c6c17ae8", new DateTime(2024, 8, 29, 11, 10, 46, 309, DateTimeKind.Utc).AddTicks(3565), new DateTime(2024, 8, 29, 11, 10, 46, 309, DateTimeKind.Utc).AddTicks(3565), new DateTime(2024, 8, 29, 11, 10, 46, 309, DateTimeKind.Utc).AddTicks(3561) });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: 2010,
                columns: new[] { "ConcurrencyStamp", "CreatedTime", "LastUpdatedTime", "RefreshTokenCreateTime" },
                values: new object[] { "69ef5706-7fb5-41d4-a47e-26bb8a5409b6", new DateTime(2024, 8, 29, 11, 10, 46, 309, DateTimeKind.Utc).AddTicks(3581), new DateTime(2024, 8, 29, 11, 10, 46, 309, DateTimeKind.Utc).AddTicks(3581), new DateTime(2024, 8, 29, 11, 10, 46, 309, DateTimeKind.Utc).AddTicks(3577) });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: 2011,
                columns: new[] { "ConcurrencyStamp", "CreatedTime", "LastUpdatedTime", "RefreshTokenCreateTime" },
                values: new object[] { "4d294d89-57f1-49d4-b784-93ac08909092", new DateTime(2024, 8, 29, 11, 10, 46, 309, DateTimeKind.Utc).AddTicks(3598), new DateTime(2024, 8, 29, 11, 10, 46, 309, DateTimeKind.Utc).AddTicks(3598), new DateTime(2024, 8, 29, 11, 10, 46, 309, DateTimeKind.Utc).AddTicks(3594) });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: 2012,
                columns: new[] { "ConcurrencyStamp", "CreatedTime", "LastUpdatedTime", "RefreshTokenCreateTime" },
                values: new object[] { "0b714bbd-2e35-44de-9ed3-e59e471fda39", new DateTime(2024, 8, 29, 11, 10, 46, 309, DateTimeKind.Utc).AddTicks(3611), new DateTime(2024, 8, 29, 11, 10, 46, 309, DateTimeKind.Utc).AddTicks(3611), new DateTime(2024, 8, 29, 11, 10, 46, 309, DateTimeKind.Utc).AddTicks(3607) });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: 2013,
                columns: new[] { "ConcurrencyStamp", "CreatedTime", "LastUpdatedTime", "RefreshTokenCreateTime" },
                values: new object[] { "0457776c-b049-428c-b91c-c57b26cdc9af", new DateTime(2024, 8, 29, 11, 10, 46, 309, DateTimeKind.Utc).AddTicks(3660), new DateTime(2024, 8, 29, 11, 10, 46, 309, DateTimeKind.Utc).AddTicks(3661), new DateTime(2024, 8, 29, 11, 10, 46, 309, DateTimeKind.Utc).AddTicks(3656) });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: 2014,
                columns: new[] { "ConcurrencyStamp", "CreatedTime", "LastUpdatedTime", "RefreshTokenCreateTime" },
                values: new object[] { "fcb9253b-afbb-4612-953c-4b5f95f35f64", new DateTime(2024, 8, 29, 11, 10, 46, 309, DateTimeKind.Utc).AddTicks(3674), new DateTime(2024, 8, 29, 11, 10, 46, 309, DateTimeKind.Utc).AddTicks(3675), new DateTime(2024, 8, 29, 11, 10, 46, 309, DateTimeKind.Utc).AddTicks(3670) });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: 2015,
                columns: new[] { "ConcurrencyStamp", "CreatedTime", "LastUpdatedTime", "RefreshTokenCreateTime" },
                values: new object[] { "acefb6e0-6eaf-4033-afa3-ea1e681ed1ca", new DateTime(2024, 8, 29, 11, 10, 46, 309, DateTimeKind.Utc).AddTicks(3701), new DateTime(2024, 8, 29, 11, 10, 46, 309, DateTimeKind.Utc).AddTicks(3701), new DateTime(2024, 8, 29, 11, 10, 46, 309, DateTimeKind.Utc).AddTicks(3683) });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: 2016,
                columns: new[] { "ConcurrencyStamp", "CreatedTime", "LastUpdatedTime", "RefreshTokenCreateTime" },
                values: new object[] { "a964b831-bcbf-4480-9568-5e363f76e4e4", new DateTime(2024, 8, 29, 11, 10, 46, 309, DateTimeKind.Utc).AddTicks(3715), new DateTime(2024, 8, 29, 11, 10, 46, 309, DateTimeKind.Utc).AddTicks(3715), new DateTime(2024, 8, 29, 11, 10, 46, 309, DateTimeKind.Utc).AddTicks(3711) });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: 2017,
                columns: new[] { "ConcurrencyStamp", "CreatedTime", "LastUpdatedTime", "RefreshTokenCreateTime" },
                values: new object[] { "7827b080-eb92-44b2-917b-75a1f7d48571", new DateTime(2024, 8, 29, 11, 10, 46, 309, DateTimeKind.Utc).AddTicks(3729), new DateTime(2024, 8, 29, 11, 10, 46, 309, DateTimeKind.Utc).AddTicks(3729), new DateTime(2024, 8, 29, 11, 10, 46, 309, DateTimeKind.Utc).AddTicks(3725) });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: 2018,
                columns: new[] { "ConcurrencyStamp", "CreatedTime", "LastUpdatedTime", "RefreshTokenCreateTime" },
                values: new object[] { "774fa33e-63c0-40f7-9a37-1c9b75075c6c", new DateTime(2024, 8, 29, 11, 10, 46, 309, DateTimeKind.Utc).AddTicks(3745), new DateTime(2024, 8, 29, 11, 10, 46, 309, DateTimeKind.Utc).AddTicks(3746), new DateTime(2024, 8, 29, 11, 10, 46, 309, DateTimeKind.Utc).AddTicks(3742) });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: 2019,
                columns: new[] { "ConcurrencyStamp", "CreatedTime", "LastUpdatedTime", "RefreshTokenCreateTime" },
                values: new object[] { "2593d90c-ca47-4c6a-94fc-75fd1a933a84", new DateTime(2024, 8, 29, 11, 10, 46, 309, DateTimeKind.Utc).AddTicks(3758), new DateTime(2024, 8, 29, 11, 10, 46, 309, DateTimeKind.Utc).AddTicks(3759), new DateTime(2024, 8, 29, 11, 10, 46, 309, DateTimeKind.Utc).AddTicks(3755) });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: 2020,
                columns: new[] { "ConcurrencyStamp", "CreatedTime", "LastUpdatedTime", "RefreshTokenCreateTime" },
                values: new object[] { "5f1bbc4f-e44b-4d68-9a56-8b8475c2eab7", new DateTime(2024, 8, 29, 11, 10, 46, 309, DateTimeKind.Utc).AddTicks(3772), new DateTime(2024, 8, 29, 11, 10, 46, 309, DateTimeKind.Utc).AddTicks(3773), new DateTime(2024, 8, 29, 11, 10, 46, 309, DateTimeKind.Utc).AddTicks(3768) });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: 2021,
                columns: new[] { "ConcurrencyStamp", "CreatedTime", "LastUpdatedTime", "RefreshTokenCreateTime" },
                values: new object[] { "f9ccac42-cc4c-4c67-b18b-5db7535b79b7", new DateTime(2024, 8, 29, 11, 10, 46, 309, DateTimeKind.Utc).AddTicks(3785), new DateTime(2024, 8, 29, 11, 10, 46, 309, DateTimeKind.Utc).AddTicks(3786), new DateTime(2024, 8, 29, 11, 10, 46, 309, DateTimeKind.Utc).AddTicks(3782) });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: 2022,
                columns: new[] { "ConcurrencyStamp", "CreatedTime", "LastUpdatedTime", "RefreshTokenCreateTime" },
                values: new object[] { "52ebc613-dca4-49cf-aef3-8cdbc926862d", new DateTime(2024, 8, 29, 11, 10, 46, 309, DateTimeKind.Utc).AddTicks(4063), new DateTime(2024, 8, 29, 11, 10, 46, 309, DateTimeKind.Utc).AddTicks(4064), new DateTime(2024, 8, 29, 11, 10, 46, 309, DateTimeKind.Utc).AddTicks(4051) });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: 2023,
                columns: new[] { "ConcurrencyStamp", "CreatedTime", "LastUpdatedTime", "RefreshTokenCreateTime" },
                values: new object[] { "13def78b-3d26-4d66-928b-e9e8a097e98c", new DateTime(2024, 8, 29, 11, 10, 46, 309, DateTimeKind.Utc).AddTicks(4303), new DateTime(2024, 8, 29, 11, 10, 46, 309, DateTimeKind.Utc).AddTicks(4303), new DateTime(2024, 8, 29, 11, 10, 46, 309, DateTimeKind.Utc).AddTicks(4098) });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: 2024,
                columns: new[] { "ConcurrencyStamp", "CreatedTime", "LastUpdatedTime", "RefreshTokenCreateTime" },
                values: new object[] { "3d669f4e-506b-4b8c-88b2-6933ad0e926a", new DateTime(2024, 8, 29, 11, 10, 46, 309, DateTimeKind.Utc).AddTicks(4317), new DateTime(2024, 8, 29, 11, 10, 46, 309, DateTimeKind.Utc).AddTicks(4318), new DateTime(2024, 8, 29, 11, 10, 46, 309, DateTimeKind.Utc).AddTicks(4313) });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: 2025,
                columns: new[] { "ConcurrencyStamp", "CreatedTime", "LastUpdatedTime", "RefreshTokenCreateTime" },
                values: new object[] { "6318dc70-691a-48cb-9bb5-33c1e5ee5bb2", new DateTime(2024, 8, 29, 11, 10, 46, 309, DateTimeKind.Utc).AddTicks(4331), new DateTime(2024, 8, 29, 11, 10, 46, 309, DateTimeKind.Utc).AddTicks(4332), new DateTime(2024, 8, 29, 11, 10, 46, 309, DateTimeKind.Utc).AddTicks(4328) });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: 2026,
                columns: new[] { "ConcurrencyStamp", "CreatedTime", "LastUpdatedTime", "RefreshTokenCreateTime" },
                values: new object[] { "164de8be-a38e-4d30-81e1-8dd0a7138fef", new DateTime(2024, 8, 29, 11, 10, 46, 309, DateTimeKind.Utc).AddTicks(4346), new DateTime(2024, 8, 29, 11, 10, 46, 309, DateTimeKind.Utc).AddTicks(4346), new DateTime(2024, 8, 29, 11, 10, 46, 309, DateTimeKind.Utc).AddTicks(4342) });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: 2027,
                columns: new[] { "ConcurrencyStamp", "CreatedTime", "LastUpdatedTime", "RefreshTokenCreateTime" },
                values: new object[] { "1c5055ce-e46e-4bc9-8684-c695d17cd32d", new DateTime(2024, 8, 29, 11, 10, 46, 309, DateTimeKind.Utc).AddTicks(4360), new DateTime(2024, 8, 29, 11, 10, 46, 309, DateTimeKind.Utc).AddTicks(4360), new DateTime(2024, 8, 29, 11, 10, 46, 309, DateTimeKind.Utc).AddTicks(4356) });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: 2028,
                columns: new[] { "ConcurrencyStamp", "CreatedTime", "LastUpdatedTime", "RefreshTokenCreateTime" },
                values: new object[] { "088720ce-598a-4b4d-92db-1be626b42d1e", new DateTime(2024, 8, 29, 11, 10, 46, 309, DateTimeKind.Utc).AddTicks(4374), new DateTime(2024, 8, 29, 11, 10, 46, 309, DateTimeKind.Utc).AddTicks(4375), new DateTime(2024, 8, 29, 11, 10, 46, 309, DateTimeKind.Utc).AddTicks(4371) });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: 2029,
                columns: new[] { "ConcurrencyStamp", "CreatedTime", "LastUpdatedTime", "RefreshTokenCreateTime" },
                values: new object[] { "179f5568-8f03-43c0-953c-3f16a7e65531", new DateTime(2024, 8, 29, 11, 10, 46, 309, DateTimeKind.Utc).AddTicks(4389), new DateTime(2024, 8, 29, 11, 10, 46, 309, DateTimeKind.Utc).AddTicks(4390), new DateTime(2024, 8, 29, 11, 10, 46, 309, DateTimeKind.Utc).AddTicks(4385) });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: 2030,
                columns: new[] { "ConcurrencyStamp", "CreatedTime", "LastUpdatedTime", "RefreshTokenCreateTime" },
                values: new object[] { "41ebdddd-2cb5-43f0-8be7-37f8847a7682", new DateTime(2024, 8, 29, 11, 10, 46, 309, DateTimeKind.Utc).AddTicks(4481), new DateTime(2024, 8, 29, 11, 10, 46, 309, DateTimeKind.Utc).AddTicks(4481), new DateTime(2024, 8, 29, 11, 10, 46, 309, DateTimeKind.Utc).AddTicks(4400) });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: 2031,
                columns: new[] { "ConcurrencyStamp", "CreatedTime", "LastUpdatedTime", "RefreshTokenCreateTime" },
                values: new object[] { "1e803529-4688-4390-a13f-65a0051438ca", new DateTime(2024, 8, 29, 11, 10, 46, 309, DateTimeKind.Utc).AddTicks(4570), new DateTime(2024, 8, 29, 11, 10, 46, 309, DateTimeKind.Utc).AddTicks(4571), new DateTime(2024, 8, 29, 11, 10, 46, 309, DateTimeKind.Utc).AddTicks(4561) });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: 2032,
                columns: new[] { "ConcurrencyStamp", "CreatedTime", "LastUpdatedTime", "RefreshTokenCreateTime" },
                values: new object[] { "c8c76a87-2097-4042-b9c0-ae24ff6daf63", new DateTime(2024, 8, 29, 11, 10, 46, 309, DateTimeKind.Utc).AddTicks(4586), new DateTime(2024, 8, 29, 11, 10, 46, 309, DateTimeKind.Utc).AddTicks(4586), new DateTime(2024, 8, 29, 11, 10, 46, 309, DateTimeKind.Utc).AddTicks(4582) });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: 2033,
                columns: new[] { "ConcurrencyStamp", "CreatedTime", "LastUpdatedTime", "RefreshTokenCreateTime" },
                values: new object[] { "1a8b4574-7117-41e0-bf4d-db1a22791115", new DateTime(2024, 8, 29, 11, 10, 46, 309, DateTimeKind.Utc).AddTicks(4600), new DateTime(2024, 8, 29, 11, 10, 46, 309, DateTimeKind.Utc).AddTicks(4600), new DateTime(2024, 8, 29, 11, 10, 46, 309, DateTimeKind.Utc).AddTicks(4596) });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: 2034,
                columns: new[] { "ConcurrencyStamp", "CreatedTime", "LastUpdatedTime", "RefreshTokenCreateTime" },
                values: new object[] { "9d0c5567-8293-4091-aa53-acd032896f92", new DateTime(2024, 8, 29, 11, 10, 46, 309, DateTimeKind.Utc).AddTicks(4616), new DateTime(2024, 8, 29, 11, 10, 46, 309, DateTimeKind.Utc).AddTicks(4616), new DateTime(2024, 8, 29, 11, 10, 46, 309, DateTimeKind.Utc).AddTicks(4613) });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: 2035,
                columns: new[] { "ConcurrencyStamp", "CreatedTime", "LastUpdatedTime", "RefreshTokenCreateTime" },
                values: new object[] { "5c5e0a3e-4deb-4841-b889-1f0c7e1884bd", new DateTime(2024, 8, 29, 11, 10, 46, 309, DateTimeKind.Utc).AddTicks(4631), new DateTime(2024, 8, 29, 11, 10, 46, 309, DateTimeKind.Utc).AddTicks(4632), new DateTime(2024, 8, 29, 11, 10, 46, 309, DateTimeKind.Utc).AddTicks(4627) });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: 2036,
                columns: new[] { "ConcurrencyStamp", "CreatedTime", "LastUpdatedTime", "RefreshTokenCreateTime" },
                values: new object[] { "ec0a88e3-2ab3-4068-83b5-b2bfb88d53d0", new DateTime(2024, 8, 29, 11, 10, 46, 309, DateTimeKind.Utc).AddTicks(4645), new DateTime(2024, 8, 29, 11, 10, 46, 309, DateTimeKind.Utc).AddTicks(4646), new DateTime(2024, 8, 29, 11, 10, 46, 309, DateTimeKind.Utc).AddTicks(4642) });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: 2037,
                columns: new[] { "ConcurrencyStamp", "CreatedTime", "LastUpdatedTime", "RefreshTokenCreateTime" },
                values: new object[] { "14151275-3c33-4a6a-82be-00e784f7658d", new DateTime(2024, 8, 29, 11, 10, 46, 309, DateTimeKind.Utc).AddTicks(4660), new DateTime(2024, 8, 29, 11, 10, 46, 309, DateTimeKind.Utc).AddTicks(4660), new DateTime(2024, 8, 29, 11, 10, 46, 309, DateTimeKind.Utc).AddTicks(4655) });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: 2038,
                columns: new[] { "ConcurrencyStamp", "CreatedTime", "LastUpdatedTime", "RefreshTokenCreateTime" },
                values: new object[] { "4137c94c-e884-4e9f-a420-40c9f2d3eefd", new DateTime(2024, 8, 29, 11, 10, 46, 309, DateTimeKind.Utc).AddTicks(4673), new DateTime(2024, 8, 29, 11, 10, 46, 309, DateTimeKind.Utc).AddTicks(4674), new DateTime(2024, 8, 29, 11, 10, 46, 309, DateTimeKind.Utc).AddTicks(4670) });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: 2039,
                columns: new[] { "ConcurrencyStamp", "CreatedTime", "LastUpdatedTime", "RefreshTokenCreateTime" },
                values: new object[] { "fe01d09d-7d21-44b0-ab85-94a4ffe2fd55", new DateTime(2024, 8, 29, 11, 10, 46, 309, DateTimeKind.Utc).AddTicks(4722), new DateTime(2024, 8, 29, 11, 10, 46, 309, DateTimeKind.Utc).AddTicks(4723), new DateTime(2024, 8, 29, 11, 10, 46, 309, DateTimeKind.Utc).AddTicks(4715) });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: 2040,
                columns: new[] { "ConcurrencyStamp", "CreatedTime", "LastUpdatedTime", "RefreshTokenCreateTime" },
                values: new object[] { "e9659d0c-b445-4514-9aaf-f474e4d5fc36", new DateTime(2024, 8, 29, 11, 10, 46, 309, DateTimeKind.Utc).AddTicks(4737), new DateTime(2024, 8, 29, 11, 10, 46, 309, DateTimeKind.Utc).AddTicks(4738), new DateTime(2024, 8, 29, 11, 10, 46, 309, DateTimeKind.Utc).AddTicks(4734) });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: 2041,
                columns: new[] { "ConcurrencyStamp", "CreatedTime", "LastUpdatedTime", "RefreshTokenCreateTime" },
                values: new object[] { "a614c3c9-9cab-4c57-a00e-e92dd01cc102", new DateTime(2024, 8, 29, 11, 10, 46, 309, DateTimeKind.Utc).AddTicks(4751), new DateTime(2024, 8, 29, 11, 10, 46, 309, DateTimeKind.Utc).AddTicks(4751), new DateTime(2024, 8, 29, 11, 10, 46, 309, DateTimeKind.Utc).AddTicks(4747) });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: 2042,
                columns: new[] { "ConcurrencyStamp", "CreatedTime", "LastUpdatedTime", "RefreshTokenCreateTime" },
                values: new object[] { "b83bb3b7-42c0-497e-835d-e780cb3940e6", new DateTime(2024, 8, 29, 11, 10, 46, 309, DateTimeKind.Utc).AddTicks(4770), new DateTime(2024, 8, 29, 11, 10, 46, 309, DateTimeKind.Utc).AddTicks(4770), new DateTime(2024, 8, 29, 11, 10, 46, 309, DateTimeKind.Utc).AddTicks(4767) });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: 2043,
                columns: new[] { "ConcurrencyStamp", "CreatedTime", "LastUpdatedTime", "RefreshTokenCreateTime" },
                values: new object[] { "eecc7c46-44f1-4d8e-9180-c19201b3b1b7", new DateTime(2024, 8, 29, 11, 10, 46, 309, DateTimeKind.Utc).AddTicks(4784), new DateTime(2024, 8, 29, 11, 10, 46, 309, DateTimeKind.Utc).AddTicks(4785), new DateTime(2024, 8, 29, 11, 10, 46, 309, DateTimeKind.Utc).AddTicks(4780) });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: 2044,
                columns: new[] { "ConcurrencyStamp", "CreatedTime", "LastUpdatedTime", "RefreshTokenCreateTime" },
                values: new object[] { "ca5efd96-f8e3-4a58-b9e4-7884262d26c4", new DateTime(2024, 8, 29, 11, 10, 46, 309, DateTimeKind.Utc).AddTicks(4798), new DateTime(2024, 8, 29, 11, 10, 46, 309, DateTimeKind.Utc).AddTicks(4799), new DateTime(2024, 8, 29, 11, 10, 46, 309, DateTimeKind.Utc).AddTicks(4795) });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: 2045,
                columns: new[] { "ConcurrencyStamp", "CreatedTime", "LastUpdatedTime", "RefreshTokenCreateTime" },
                values: new object[] { "b0a15fbd-3bf4-4b8f-a95e-a34c70e320f7", new DateTime(2024, 8, 29, 11, 10, 46, 309, DateTimeKind.Utc).AddTicks(4812), new DateTime(2024, 8, 29, 11, 10, 46, 309, DateTimeKind.Utc).AddTicks(4812), new DateTime(2024, 8, 29, 11, 10, 46, 309, DateTimeKind.Utc).AddTicks(4808) });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: 2046,
                columns: new[] { "ConcurrencyStamp", "CreatedTime", "LastUpdatedTime", "RefreshTokenCreateTime" },
                values: new object[] { "540315e0-4d38-4505-8878-01ef3b43e123", new DateTime(2024, 8, 29, 11, 10, 46, 309, DateTimeKind.Utc).AddTicks(4825), new DateTime(2024, 8, 29, 11, 10, 46, 309, DateTimeKind.Utc).AddTicks(4826), new DateTime(2024, 8, 29, 11, 10, 46, 309, DateTimeKind.Utc).AddTicks(4822) });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: 2047,
                columns: new[] { "ConcurrencyStamp", "CreatedTime", "LastUpdatedTime", "RefreshTokenCreateTime" },
                values: new object[] { "88b0e3ca-71ff-4380-bf22-9837079f1284", new DateTime(2024, 8, 29, 11, 10, 46, 309, DateTimeKind.Utc).AddTicks(4843), new DateTime(2024, 8, 29, 11, 10, 46, 309, DateTimeKind.Utc).AddTicks(4843), new DateTime(2024, 8, 29, 11, 10, 46, 309, DateTimeKind.Utc).AddTicks(4836) });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: 2048,
                columns: new[] { "ConcurrencyStamp", "CreatedTime", "LastUpdatedTime", "RefreshTokenCreateTime" },
                values: new object[] { "af973616-6ae7-4012-bce1-9b73fd51849f", new DateTime(2024, 8, 29, 11, 10, 46, 309, DateTimeKind.Utc).AddTicks(4857), new DateTime(2024, 8, 29, 11, 10, 46, 309, DateTimeKind.Utc).AddTicks(4858), new DateTime(2024, 8, 29, 11, 10, 46, 309, DateTimeKind.Utc).AddTicks(4853) });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: 2049,
                columns: new[] { "ConcurrencyStamp", "CreatedTime", "LastUpdatedTime", "RefreshTokenCreateTime" },
                values: new object[] { "636c6ec4-db1a-4253-8e73-a14973b733a1", new DateTime(2024, 8, 29, 11, 10, 46, 309, DateTimeKind.Utc).AddTicks(4891), new DateTime(2024, 8, 29, 11, 10, 46, 309, DateTimeKind.Utc).AddTicks(4892), new DateTime(2024, 8, 29, 11, 10, 46, 309, DateTimeKind.Utc).AddTicks(4887) });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: 2050,
                columns: new[] { "ConcurrencyStamp", "CreatedTime", "LastUpdatedTime", "RefreshTokenCreateTime" },
                values: new object[] { "a0f49dc1-7356-4a4e-85b4-becff80468a3", new DateTime(2024, 8, 29, 11, 10, 46, 309, DateTimeKind.Utc).AddTicks(4905), new DateTime(2024, 8, 29, 11, 10, 46, 309, DateTimeKind.Utc).AddTicks(4905), new DateTime(2024, 8, 29, 11, 10, 46, 309, DateTimeKind.Utc).AddTicks(4901) });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: 2051,
                columns: new[] { "ConcurrencyStamp", "CreatedTime", "LastUpdatedTime", "RefreshTokenCreateTime" },
                values: new object[] { "b5056871-6c95-4797-abd2-705400fafbda", new DateTime(2024, 8, 29, 11, 10, 46, 309, DateTimeKind.Utc).AddTicks(4918), new DateTime(2024, 8, 29, 11, 10, 46, 309, DateTimeKind.Utc).AddTicks(4919), new DateTime(2024, 8, 29, 11, 10, 46, 309, DateTimeKind.Utc).AddTicks(4915) });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: 2052,
                columns: new[] { "ConcurrencyStamp", "CreatedTime", "LastUpdatedTime", "RefreshTokenCreateTime" },
                values: new object[] { "b31f73a2-7a90-45bd-9ad8-ee6bb852f953", new DateTime(2024, 8, 29, 11, 10, 46, 309, DateTimeKind.Utc).AddTicks(4931), new DateTime(2024, 8, 29, 11, 10, 46, 309, DateTimeKind.Utc).AddTicks(4932), new DateTime(2024, 8, 29, 11, 10, 46, 309, DateTimeKind.Utc).AddTicks(4928) });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: 2053,
                columns: new[] { "ConcurrencyStamp", "CreatedTime", "LastUpdatedTime", "RefreshTokenCreateTime" },
                values: new object[] { "ed382c68-a851-4073-af8b-a03ebc0cecb5", new DateTime(2024, 8, 29, 11, 10, 46, 309, DateTimeKind.Utc).AddTicks(4944), new DateTime(2024, 8, 29, 11, 10, 46, 309, DateTimeKind.Utc).AddTicks(4945), new DateTime(2024, 8, 29, 11, 10, 46, 309, DateTimeKind.Utc).AddTicks(4941) });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: 2054,
                columns: new[] { "ConcurrencyStamp", "CreatedTime", "LastUpdatedTime", "RefreshTokenCreateTime" },
                values: new object[] { "1267770f-0cb8-49a8-8dcc-a07ca8ed05a2", new DateTime(2024, 8, 29, 11, 10, 46, 309, DateTimeKind.Utc).AddTicks(4958), new DateTime(2024, 8, 29, 11, 10, 46, 309, DateTimeKind.Utc).AddTicks(4958), new DateTime(2024, 8, 29, 11, 10, 46, 309, DateTimeKind.Utc).AddTicks(4954) });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: 2055,
                columns: new[] { "ConcurrencyStamp", "CreatedTime", "LastUpdatedTime", "RefreshTokenCreateTime" },
                values: new object[] { "c47b98a5-542b-4a7c-bb4f-d3bbdcd58c76", new DateTime(2024, 8, 29, 11, 10, 46, 309, DateTimeKind.Utc).AddTicks(4974), new DateTime(2024, 8, 29, 11, 10, 46, 309, DateTimeKind.Utc).AddTicks(4975), new DateTime(2024, 8, 29, 11, 10, 46, 309, DateTimeKind.Utc).AddTicks(4968) });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: 2056,
                columns: new[] { "ConcurrencyStamp", "CreatedTime", "LastUpdatedTime", "RefreshTokenCreateTime" },
                values: new object[] { "2f84c6de-d083-4a04-afdb-2ad484a78764", new DateTime(2024, 8, 29, 11, 10, 46, 309, DateTimeKind.Utc).AddTicks(4989), new DateTime(2024, 8, 29, 11, 10, 46, 309, DateTimeKind.Utc).AddTicks(4989), new DateTime(2024, 8, 29, 11, 10, 46, 309, DateTimeKind.Utc).AddTicks(4985) });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: 2057,
                columns: new[] { "ConcurrencyStamp", "CreatedTime", "LastUpdatedTime", "RefreshTokenCreateTime" },
                values: new object[] { "20ec9ca8-fc64-4ef8-8667-43c9b52d7edf", new DateTime(2024, 8, 29, 11, 10, 46, 309, DateTimeKind.Utc).AddTicks(5003), new DateTime(2024, 8, 29, 11, 10, 46, 309, DateTimeKind.Utc).AddTicks(5003), new DateTime(2024, 8, 29, 11, 10, 46, 309, DateTimeKind.Utc).AddTicks(4999) });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: 2058,
                columns: new[] { "ConcurrencyStamp", "CreatedTime", "LastUpdatedTime", "RefreshTokenCreateTime" },
                values: new object[] { "4f23ef04-c46f-4f3c-add8-809a0c119f0e", new DateTime(2024, 8, 29, 11, 10, 46, 309, DateTimeKind.Utc).AddTicks(5016), new DateTime(2024, 8, 29, 11, 10, 46, 309, DateTimeKind.Utc).AddTicks(5017), new DateTime(2024, 8, 29, 11, 10, 46, 309, DateTimeKind.Utc).AddTicks(5013) });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: 2059,
                columns: new[] { "ConcurrencyStamp", "CreatedTime", "LastUpdatedTime", "RefreshTokenCreateTime" },
                values: new object[] { "44059a5f-522a-4fda-9668-d8bbf8391884", new DateTime(2024, 8, 29, 11, 10, 46, 309, DateTimeKind.Utc).AddTicks(5113), new DateTime(2024, 8, 29, 11, 10, 46, 309, DateTimeKind.Utc).AddTicks(5113), new DateTime(2024, 8, 29, 11, 10, 46, 309, DateTimeKind.Utc).AddTicks(5108) });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: 2060,
                columns: new[] { "ConcurrencyStamp", "CreatedTime", "LastUpdatedTime", "RefreshTokenCreateTime" },
                values: new object[] { "2b85a7a9-368c-4e67-916d-95bbc921dc07", new DateTime(2024, 8, 29, 11, 10, 46, 309, DateTimeKind.Utc).AddTicks(5126), new DateTime(2024, 8, 29, 11, 10, 46, 309, DateTimeKind.Utc).AddTicks(5126), new DateTime(2024, 8, 29, 11, 10, 46, 309, DateTimeKind.Utc).AddTicks(5122) });

            migrationBuilder.UpdateData(
                table: "Breeds",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedTime",
                value: new DateTime(2024, 8, 29, 15, 10, 46, 257, DateTimeKind.Local).AddTicks(3094));

            migrationBuilder.UpdateData(
                table: "Breeds",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreatedTime",
                value: new DateTime(2024, 8, 29, 15, 10, 46, 257, DateTimeKind.Local).AddTicks(3107));

            migrationBuilder.UpdateData(
                table: "Breeds",
                keyColumn: "Id",
                keyValue: 3,
                column: "CreatedTime",
                value: new DateTime(2024, 8, 29, 15, 10, 46, 257, DateTimeKind.Local).AddTicks(3109));

            migrationBuilder.UpdateData(
                table: "Breeds",
                keyColumn: "Id",
                keyValue: 4,
                column: "CreatedTime",
                value: new DateTime(2024, 8, 29, 15, 10, 46, 257, DateTimeKind.Local).AddTicks(3111));

            migrationBuilder.UpdateData(
                table: "Breeds",
                keyColumn: "Id",
                keyValue: 5,
                column: "CreatedTime",
                value: new DateTime(2024, 8, 29, 15, 10, 46, 257, DateTimeKind.Local).AddTicks(3112));

            migrationBuilder.UpdateData(
                table: "Breeds",
                keyColumn: "Id",
                keyValue: 6,
                column: "CreatedTime",
                value: new DateTime(2024, 8, 29, 15, 10, 46, 257, DateTimeKind.Local).AddTicks(3113));

            migrationBuilder.UpdateData(
                table: "Breeds",
                keyColumn: "Id",
                keyValue: 7,
                column: "CreatedTime",
                value: new DateTime(2024, 8, 29, 15, 10, 46, 257, DateTimeKind.Local).AddTicks(3115));

            migrationBuilder.UpdateData(
                table: "Breeds",
                keyColumn: "Id",
                keyValue: 8,
                column: "CreatedTime",
                value: new DateTime(2024, 8, 29, 15, 10, 46, 257, DateTimeKind.Local).AddTicks(3259));

            migrationBuilder.UpdateData(
                table: "Breeds",
                keyColumn: "Id",
                keyValue: 9,
                column: "CreatedTime",
                value: new DateTime(2024, 8, 29, 15, 10, 46, 257, DateTimeKind.Local).AddTicks(3261));

            migrationBuilder.UpdateData(
                table: "Breeds",
                keyColumn: "Id",
                keyValue: 10,
                column: "CreatedTime",
                value: new DateTime(2024, 8, 29, 15, 10, 46, 257, DateTimeKind.Local).AddTicks(3263));

            migrationBuilder.UpdateData(
                table: "Breeds",
                keyColumn: "Id",
                keyValue: 11,
                column: "CreatedTime",
                value: new DateTime(2024, 8, 29, 15, 10, 46, 257, DateTimeKind.Local).AddTicks(3264));

            migrationBuilder.UpdateData(
                table: "Breeds",
                keyColumn: "Id",
                keyValue: 12,
                column: "CreatedTime",
                value: new DateTime(2024, 8, 29, 15, 10, 46, 257, DateTimeKind.Local).AddTicks(3265));

            migrationBuilder.UpdateData(
                table: "Breeds",
                keyColumn: "Id",
                keyValue: 13,
                column: "CreatedTime",
                value: new DateTime(2024, 8, 29, 15, 10, 46, 257, DateTimeKind.Local).AddTicks(3267));

            migrationBuilder.UpdateData(
                table: "Breeds",
                keyColumn: "Id",
                keyValue: 14,
                column: "CreatedTime",
                value: new DateTime(2024, 8, 29, 15, 10, 46, 257, DateTimeKind.Local).AddTicks(3268));

            migrationBuilder.UpdateData(
                table: "Breeds",
                keyColumn: "Id",
                keyValue: 15,
                column: "CreatedTime",
                value: new DateTime(2024, 8, 29, 15, 10, 46, 257, DateTimeKind.Local).AddTicks(3269));

            migrationBuilder.UpdateData(
                table: "Breeds",
                keyColumn: "Id",
                keyValue: 16,
                column: "CreatedTime",
                value: new DateTime(2024, 8, 29, 15, 10, 46, 257, DateTimeKind.Local).AddTicks(3271));

            migrationBuilder.UpdateData(
                table: "Breeds",
                keyColumn: "Id",
                keyValue: 17,
                column: "CreatedTime",
                value: new DateTime(2024, 8, 29, 15, 10, 46, 257, DateTimeKind.Local).AddTicks(3272));

            migrationBuilder.UpdateData(
                table: "Breeds",
                keyColumn: "Id",
                keyValue: 18,
                column: "CreatedTime",
                value: new DateTime(2024, 8, 29, 15, 10, 46, 257, DateTimeKind.Local).AddTicks(3273));

            migrationBuilder.UpdateData(
                table: "Breeds",
                keyColumn: "Id",
                keyValue: 19,
                column: "CreatedTime",
                value: new DateTime(2024, 8, 29, 15, 10, 46, 257, DateTimeKind.Local).AddTicks(3275));

            migrationBuilder.UpdateData(
                table: "Breeds",
                keyColumn: "Id",
                keyValue: 20,
                column: "CreatedTime",
                value: new DateTime(2024, 8, 29, 15, 10, 46, 257, DateTimeKind.Local).AddTicks(3276));

            migrationBuilder.UpdateData(
                table: "Breeds",
                keyColumn: "Id",
                keyValue: 21,
                column: "CreatedTime",
                value: new DateTime(2024, 8, 29, 15, 10, 46, 257, DateTimeKind.Local).AddTicks(3277));

            migrationBuilder.UpdateData(
                table: "Breeds",
                keyColumn: "Id",
                keyValue: 22,
                column: "CreatedTime",
                value: new DateTime(2024, 8, 29, 15, 10, 46, 257, DateTimeKind.Local).AddTicks(3278));

            migrationBuilder.UpdateData(
                table: "Breeds",
                keyColumn: "Id",
                keyValue: 23,
                column: "CreatedTime",
                value: new DateTime(2024, 8, 29, 15, 10, 46, 257, DateTimeKind.Local).AddTicks(3280));

            migrationBuilder.UpdateData(
                table: "Breeds",
                keyColumn: "Id",
                keyValue: 24,
                column: "CreatedTime",
                value: new DateTime(2024, 8, 29, 15, 10, 46, 257, DateTimeKind.Local).AddTicks(3283));

            migrationBuilder.UpdateData(
                table: "Breeds",
                keyColumn: "Id",
                keyValue: 25,
                column: "CreatedTime",
                value: new DateTime(2024, 8, 29, 15, 10, 46, 257, DateTimeKind.Local).AddTicks(3285));

            migrationBuilder.UpdateData(
                table: "Breeds",
                keyColumn: "Id",
                keyValue: 26,
                column: "CreatedTime",
                value: new DateTime(2024, 8, 29, 15, 10, 46, 257, DateTimeKind.Local).AddTicks(3287));

            migrationBuilder.UpdateData(
                table: "Breeds",
                keyColumn: "Id",
                keyValue: 27,
                column: "CreatedTime",
                value: new DateTime(2024, 8, 29, 15, 10, 46, 257, DateTimeKind.Local).AddTicks(3288));

            migrationBuilder.UpdateData(
                table: "Breeds",
                keyColumn: "Id",
                keyValue: 28,
                column: "CreatedTime",
                value: new DateTime(2024, 8, 29, 15, 10, 46, 257, DateTimeKind.Local).AddTicks(3289));

            migrationBuilder.UpdateData(
                table: "Breeds",
                keyColumn: "Id",
                keyValue: 29,
                column: "CreatedTime",
                value: new DateTime(2024, 8, 29, 15, 10, 46, 257, DateTimeKind.Local).AddTicks(3291));

            migrationBuilder.UpdateData(
                table: "Breeds",
                keyColumn: "Id",
                keyValue: 30,
                column: "CreatedTime",
                value: new DateTime(2024, 8, 29, 15, 10, 46, 257, DateTimeKind.Local).AddTicks(3292));

            migrationBuilder.UpdateData(
                table: "Breeds",
                keyColumn: "Id",
                keyValue: 31,
                column: "CreatedTime",
                value: new DateTime(2024, 8, 29, 15, 10, 46, 257, DateTimeKind.Local).AddTicks(3293));

            migrationBuilder.UpdateData(
                table: "Breeds",
                keyColumn: "Id",
                keyValue: 32,
                column: "CreatedTime",
                value: new DateTime(2024, 8, 29, 15, 10, 46, 257, DateTimeKind.Local).AddTicks(3295));

            migrationBuilder.UpdateData(
                table: "Breeds",
                keyColumn: "Id",
                keyValue: 33,
                column: "CreatedTime",
                value: new DateTime(2024, 8, 29, 15, 10, 46, 257, DateTimeKind.Local).AddTicks(3296));

            migrationBuilder.UpdateData(
                table: "Breeds",
                keyColumn: "Id",
                keyValue: 34,
                column: "CreatedTime",
                value: new DateTime(2024, 8, 29, 15, 10, 46, 257, DateTimeKind.Local).AddTicks(3297));

            migrationBuilder.UpdateData(
                table: "Breeds",
                keyColumn: "Id",
                keyValue: 35,
                column: "CreatedTime",
                value: new DateTime(2024, 8, 29, 15, 10, 46, 257, DateTimeKind.Local).AddTicks(3299));

            migrationBuilder.UpdateData(
                table: "Breeds",
                keyColumn: "Id",
                keyValue: 36,
                column: "CreatedTime",
                value: new DateTime(2024, 8, 29, 15, 10, 46, 257, DateTimeKind.Local).AddTicks(3300));

            migrationBuilder.UpdateData(
                table: "Breeds",
                keyColumn: "Id",
                keyValue: 37,
                column: "CreatedTime",
                value: new DateTime(2024, 8, 29, 15, 10, 46, 257, DateTimeKind.Local).AddTicks(3301));

            migrationBuilder.UpdateData(
                table: "Breeds",
                keyColumn: "Id",
                keyValue: 38,
                column: "CreatedTime",
                value: new DateTime(2024, 8, 29, 15, 10, 46, 257, DateTimeKind.Local).AddTicks(3302));

            migrationBuilder.UpdateData(
                table: "Breeds",
                keyColumn: "Id",
                keyValue: 39,
                column: "CreatedTime",
                value: new DateTime(2024, 8, 29, 15, 10, 46, 257, DateTimeKind.Local).AddTicks(3303));

            migrationBuilder.UpdateData(
                table: "Breeds",
                keyColumn: "Id",
                keyValue: 40,
                column: "CreatedTime",
                value: new DateTime(2024, 8, 29, 15, 10, 46, 257, DateTimeKind.Local).AddTicks(3305));

            migrationBuilder.UpdateData(
                table: "Breeds",
                keyColumn: "Id",
                keyValue: 41,
                column: "CreatedTime",
                value: new DateTime(2024, 8, 29, 15, 10, 46, 257, DateTimeKind.Local).AddTicks(3306));

            migrationBuilder.UpdateData(
                table: "Breeds",
                keyColumn: "Id",
                keyValue: 42,
                column: "CreatedTime",
                value: new DateTime(2024, 8, 29, 15, 10, 46, 257, DateTimeKind.Local).AddTicks(3307));

            migrationBuilder.UpdateData(
                table: "Breeds",
                keyColumn: "Id",
                keyValue: 43,
                column: "CreatedTime",
                value: new DateTime(2024, 8, 29, 15, 10, 46, 257, DateTimeKind.Local).AddTicks(3309));

            migrationBuilder.UpdateData(
                table: "Breeds",
                keyColumn: "Id",
                keyValue: 44,
                column: "CreatedTime",
                value: new DateTime(2024, 8, 29, 15, 10, 46, 257, DateTimeKind.Local).AddTicks(3310));

            migrationBuilder.UpdateData(
                table: "Breeds",
                keyColumn: "Id",
                keyValue: 45,
                column: "CreatedTime",
                value: new DateTime(2024, 8, 29, 15, 10, 46, 257, DateTimeKind.Local).AddTicks(3311));

            migrationBuilder.UpdateData(
                table: "Breeds",
                keyColumn: "Id",
                keyValue: 46,
                column: "CreatedTime",
                value: new DateTime(2024, 8, 29, 15, 10, 46, 257, DateTimeKind.Local).AddTicks(3312));

            migrationBuilder.UpdateData(
                table: "Breeds",
                keyColumn: "Id",
                keyValue: 47,
                column: "CreatedTime",
                value: new DateTime(2024, 8, 29, 15, 10, 46, 257, DateTimeKind.Local).AddTicks(3437));

            migrationBuilder.UpdateData(
                table: "Breeds",
                keyColumn: "Id",
                keyValue: 48,
                column: "CreatedTime",
                value: new DateTime(2024, 8, 29, 15, 10, 46, 257, DateTimeKind.Local).AddTicks(3439));

            migrationBuilder.UpdateData(
                table: "Breeds",
                keyColumn: "Id",
                keyValue: 49,
                column: "CreatedTime",
                value: new DateTime(2024, 8, 29, 15, 10, 46, 257, DateTimeKind.Local).AddTicks(3440));

            migrationBuilder.UpdateData(
                table: "Breeds",
                keyColumn: "Id",
                keyValue: 50,
                column: "CreatedTime",
                value: new DateTime(2024, 8, 29, 15, 10, 46, 257, DateTimeKind.Local).AddTicks(3442));

            migrationBuilder.UpdateData(
                table: "Breeds",
                keyColumn: "Id",
                keyValue: 51,
                column: "CreatedTime",
                value: new DateTime(2024, 8, 29, 15, 10, 46, 257, DateTimeKind.Local).AddTicks(3443));

            migrationBuilder.UpdateData(
                table: "Breeds",
                keyColumn: "Id",
                keyValue: 52,
                column: "CreatedTime",
                value: new DateTime(2024, 8, 29, 15, 10, 46, 257, DateTimeKind.Local).AddTicks(3444));

            migrationBuilder.UpdateData(
                table: "Breeds",
                keyColumn: "Id",
                keyValue: 53,
                column: "CreatedTime",
                value: new DateTime(2024, 8, 29, 15, 10, 46, 257, DateTimeKind.Local).AddTicks(3446));

            migrationBuilder.UpdateData(
                table: "Breeds",
                keyColumn: "Id",
                keyValue: 54,
                column: "CreatedTime",
                value: new DateTime(2024, 8, 29, 15, 10, 46, 257, DateTimeKind.Local).AddTicks(3448));

            migrationBuilder.UpdateData(
                table: "Breeds",
                keyColumn: "Id",
                keyValue: 55,
                column: "CreatedTime",
                value: new DateTime(2024, 8, 29, 15, 10, 46, 257, DateTimeKind.Local).AddTicks(3449));

            migrationBuilder.UpdateData(
                table: "Breeds",
                keyColumn: "Id",
                keyValue: 56,
                column: "CreatedTime",
                value: new DateTime(2024, 8, 29, 15, 10, 46, 257, DateTimeKind.Local).AddTicks(3450));

            migrationBuilder.UpdateData(
                table: "Breeds",
                keyColumn: "Id",
                keyValue: 57,
                column: "CreatedTime",
                value: new DateTime(2024, 8, 29, 15, 10, 46, 257, DateTimeKind.Local).AddTicks(3451));

            migrationBuilder.UpdateData(
                table: "Breeds",
                keyColumn: "Id",
                keyValue: 58,
                column: "CreatedTime",
                value: new DateTime(2024, 8, 29, 15, 10, 46, 257, DateTimeKind.Local).AddTicks(3453));

            migrationBuilder.UpdateData(
                table: "Breeds",
                keyColumn: "Id",
                keyValue: 59,
                column: "CreatedTime",
                value: new DateTime(2024, 8, 29, 15, 10, 46, 257, DateTimeKind.Local).AddTicks(3454));

            migrationBuilder.UpdateData(
                table: "Breeds",
                keyColumn: "Id",
                keyValue: 60,
                column: "CreatedTime",
                value: new DateTime(2024, 8, 29, 15, 10, 46, 257, DateTimeKind.Local).AddTicks(3455));

            migrationBuilder.UpdateData(
                table: "Breeds",
                keyColumn: "Id",
                keyValue: 61,
                column: "CreatedTime",
                value: new DateTime(2024, 8, 29, 15, 10, 46, 257, DateTimeKind.Local).AddTicks(3457));

            migrationBuilder.UpdateData(
                table: "Breeds",
                keyColumn: "Id",
                keyValue: 62,
                column: "CreatedTime",
                value: new DateTime(2024, 8, 29, 15, 10, 46, 257, DateTimeKind.Local).AddTicks(3458));

            migrationBuilder.UpdateData(
                table: "Breeds",
                keyColumn: "Id",
                keyValue: 63,
                column: "CreatedTime",
                value: new DateTime(2024, 8, 29, 15, 10, 46, 257, DateTimeKind.Local).AddTicks(3460));

            migrationBuilder.UpdateData(
                table: "Breeds",
                keyColumn: "Id",
                keyValue: 64,
                column: "CreatedTime",
                value: new DateTime(2024, 8, 29, 15, 10, 46, 257, DateTimeKind.Local).AddTicks(3461));

            migrationBuilder.UpdateData(
                table: "Breeds",
                keyColumn: "Id",
                keyValue: 65,
                column: "CreatedTime",
                value: new DateTime(2024, 8, 29, 15, 10, 46, 257, DateTimeKind.Local).AddTicks(3462));

            migrationBuilder.UpdateData(
                table: "Breeds",
                keyColumn: "Id",
                keyValue: 66,
                column: "CreatedTime",
                value: new DateTime(2024, 8, 29, 15, 10, 46, 257, DateTimeKind.Local).AddTicks(3464));

            migrationBuilder.UpdateData(
                table: "Breeds",
                keyColumn: "Id",
                keyValue: 67,
                column: "CreatedTime",
                value: new DateTime(2024, 8, 29, 15, 10, 46, 257, DateTimeKind.Local).AddTicks(3465));

            migrationBuilder.UpdateData(
                table: "Breeds",
                keyColumn: "Id",
                keyValue: 68,
                column: "CreatedTime",
                value: new DateTime(2024, 8, 29, 15, 10, 46, 257, DateTimeKind.Local).AddTicks(3467));

            migrationBuilder.UpdateData(
                table: "Breeds",
                keyColumn: "Id",
                keyValue: 69,
                column: "CreatedTime",
                value: new DateTime(2024, 8, 29, 15, 10, 46, 257, DateTimeKind.Local).AddTicks(3468));

            migrationBuilder.UpdateData(
                table: "Breeds",
                keyColumn: "Id",
                keyValue: 70,
                column: "CreatedTime",
                value: new DateTime(2024, 8, 29, 15, 10, 46, 257, DateTimeKind.Local).AddTicks(3469));

            migrationBuilder.UpdateData(
                table: "Breeds",
                keyColumn: "Id",
                keyValue: 71,
                column: "CreatedTime",
                value: new DateTime(2024, 8, 29, 15, 10, 46, 257, DateTimeKind.Local).AddTicks(3470));

            migrationBuilder.UpdateData(
                table: "Breeds",
                keyColumn: "Id",
                keyValue: 72,
                column: "CreatedTime",
                value: new DateTime(2024, 8, 29, 15, 10, 46, 257, DateTimeKind.Local).AddTicks(3472));

            migrationBuilder.UpdateData(
                table: "Breeds",
                keyColumn: "Id",
                keyValue: 73,
                column: "CreatedTime",
                value: new DateTime(2024, 8, 29, 15, 10, 46, 257, DateTimeKind.Local).AddTicks(3473));

            migrationBuilder.UpdateData(
                table: "Breeds",
                keyColumn: "Id",
                keyValue: 74,
                column: "CreatedTime",
                value: new DateTime(2024, 8, 29, 15, 10, 46, 257, DateTimeKind.Local).AddTicks(3474));

            migrationBuilder.UpdateData(
                table: "Breeds",
                keyColumn: "Id",
                keyValue: 75,
                column: "CreatedTime",
                value: new DateTime(2024, 8, 29, 15, 10, 46, 257, DateTimeKind.Local).AddTicks(3476));

            migrationBuilder.UpdateData(
                table: "Breeds",
                keyColumn: "Id",
                keyValue: 76,
                column: "CreatedTime",
                value: new DateTime(2024, 8, 29, 15, 10, 46, 257, DateTimeKind.Local).AddTicks(3477));

            migrationBuilder.UpdateData(
                table: "Breeds",
                keyColumn: "Id",
                keyValue: 77,
                column: "CreatedTime",
                value: new DateTime(2024, 8, 29, 15, 10, 46, 257, DateTimeKind.Local).AddTicks(3478));

            migrationBuilder.UpdateData(
                table: "Breeds",
                keyColumn: "Id",
                keyValue: 78,
                column: "CreatedTime",
                value: new DateTime(2024, 8, 29, 15, 10, 46, 257, DateTimeKind.Local).AddTicks(3480));

            migrationBuilder.UpdateData(
                table: "Breeds",
                keyColumn: "Id",
                keyValue: 79,
                column: "CreatedTime",
                value: new DateTime(2024, 8, 29, 15, 10, 46, 257, DateTimeKind.Local).AddTicks(3481));

            migrationBuilder.UpdateData(
                table: "Breeds",
                keyColumn: "Id",
                keyValue: 80,
                column: "CreatedTime",
                value: new DateTime(2024, 8, 29, 15, 10, 46, 257, DateTimeKind.Local).AddTicks(3482));

            migrationBuilder.UpdateData(
                table: "Breeds",
                keyColumn: "Id",
                keyValue: 81,
                column: "CreatedTime",
                value: new DateTime(2024, 8, 29, 15, 10, 46, 257, DateTimeKind.Local).AddTicks(3483));

            migrationBuilder.UpdateData(
                table: "Breeds",
                keyColumn: "Id",
                keyValue: 82,
                column: "CreatedTime",
                value: new DateTime(2024, 8, 29, 15, 10, 46, 257, DateTimeKind.Local).AddTicks(3485));

            migrationBuilder.UpdateData(
                table: "Breeds",
                keyColumn: "Id",
                keyValue: 83,
                column: "CreatedTime",
                value: new DateTime(2024, 8, 29, 15, 10, 46, 257, DateTimeKind.Local).AddTicks(3487));

            migrationBuilder.UpdateData(
                table: "Breeds",
                keyColumn: "Id",
                keyValue: 84,
                column: "CreatedTime",
                value: new DateTime(2024, 8, 29, 15, 10, 46, 257, DateTimeKind.Local).AddTicks(3488));

            migrationBuilder.UpdateData(
                table: "Breeds",
                keyColumn: "Id",
                keyValue: 85,
                column: "CreatedTime",
                value: new DateTime(2024, 8, 29, 15, 10, 46, 257, DateTimeKind.Local).AddTicks(3489));

            migrationBuilder.UpdateData(
                table: "Breeds",
                keyColumn: "Id",
                keyValue: 86,
                column: "CreatedTime",
                value: new DateTime(2024, 8, 29, 15, 10, 46, 257, DateTimeKind.Local).AddTicks(3490));

            migrationBuilder.UpdateData(
                table: "Breeds",
                keyColumn: "Id",
                keyValue: 87,
                column: "CreatedTime",
                value: new DateTime(2024, 8, 29, 15, 10, 46, 257, DateTimeKind.Local).AddTicks(3492));

            migrationBuilder.UpdateData(
                table: "Breeds",
                keyColumn: "Id",
                keyValue: 88,
                column: "CreatedTime",
                value: new DateTime(2024, 8, 29, 15, 10, 46, 257, DateTimeKind.Local).AddTicks(3493));

            migrationBuilder.UpdateData(
                table: "Breeds",
                keyColumn: "Id",
                keyValue: 89,
                column: "CreatedTime",
                value: new DateTime(2024, 8, 29, 15, 10, 46, 257, DateTimeKind.Local).AddTicks(3494));

            migrationBuilder.UpdateData(
                table: "Breeds",
                keyColumn: "Id",
                keyValue: 90,
                column: "CreatedTime",
                value: new DateTime(2024, 8, 29, 15, 10, 46, 257, DateTimeKind.Local).AddTicks(3495));

            migrationBuilder.UpdateData(
                table: "Breeds",
                keyColumn: "Id",
                keyValue: 91,
                column: "CreatedTime",
                value: new DateTime(2024, 8, 29, 15, 10, 46, 257, DateTimeKind.Local).AddTicks(3497));

            migrationBuilder.UpdateData(
                table: "Breeds",
                keyColumn: "Id",
                keyValue: 92,
                column: "CreatedTime",
                value: new DateTime(2024, 8, 29, 15, 10, 46, 257, DateTimeKind.Local).AddTicks(3498));

            migrationBuilder.UpdateData(
                table: "Breeds",
                keyColumn: "Id",
                keyValue: 93,
                column: "CreatedTime",
                value: new DateTime(2024, 8, 29, 15, 10, 46, 257, DateTimeKind.Local).AddTicks(3499));

            migrationBuilder.UpdateData(
                table: "Breeds",
                keyColumn: "Id",
                keyValue: 94,
                column: "CreatedTime",
                value: new DateTime(2024, 8, 29, 15, 10, 46, 257, DateTimeKind.Local).AddTicks(3500));

            migrationBuilder.UpdateData(
                table: "Breeds",
                keyColumn: "Id",
                keyValue: 95,
                column: "CreatedTime",
                value: new DateTime(2024, 8, 29, 15, 10, 46, 257, DateTimeKind.Local).AddTicks(3501));

            migrationBuilder.UpdateData(
                table: "Breeds",
                keyColumn: "Id",
                keyValue: 96,
                column: "CreatedTime",
                value: new DateTime(2024, 8, 29, 15, 10, 46, 257, DateTimeKind.Local).AddTicks(3503));

            migrationBuilder.UpdateData(
                table: "Breeds",
                keyColumn: "Id",
                keyValue: 97,
                column: "CreatedTime",
                value: new DateTime(2024, 8, 29, 15, 10, 46, 257, DateTimeKind.Local).AddTicks(3504));

            migrationBuilder.UpdateData(
                table: "Breeds",
                keyColumn: "Id",
                keyValue: 98,
                column: "CreatedTime",
                value: new DateTime(2024, 8, 29, 15, 10, 46, 257, DateTimeKind.Local).AddTicks(3505));

            migrationBuilder.UpdateData(
                table: "Breeds",
                keyColumn: "Id",
                keyValue: 99,
                column: "CreatedTime",
                value: new DateTime(2024, 8, 29, 15, 10, 46, 257, DateTimeKind.Local).AddTicks(3506));

            migrationBuilder.UpdateData(
                table: "Breeds",
                keyColumn: "Id",
                keyValue: 100,
                column: "CreatedTime",
                value: new DateTime(2024, 8, 29, 15, 10, 46, 257, DateTimeKind.Local).AddTicks(3508));

            migrationBuilder.UpdateData(
                table: "Breeds",
                keyColumn: "Id",
                keyValue: 101,
                column: "CreatedTime",
                value: new DateTime(2024, 8, 29, 15, 10, 46, 257, DateTimeKind.Local).AddTicks(3510));

            migrationBuilder.UpdateData(
                table: "Breeds",
                keyColumn: "Id",
                keyValue: 102,
                column: "CreatedTime",
                value: new DateTime(2024, 8, 29, 15, 10, 46, 257, DateTimeKind.Local).AddTicks(3512));

            migrationBuilder.UpdateData(
                table: "Breeds",
                keyColumn: "Id",
                keyValue: 103,
                column: "CreatedTime",
                value: new DateTime(2024, 8, 29, 15, 10, 46, 257, DateTimeKind.Local).AddTicks(3513));

            migrationBuilder.UpdateData(
                table: "Breeds",
                keyColumn: "Id",
                keyValue: 104,
                column: "CreatedTime",
                value: new DateTime(2024, 8, 29, 15, 10, 46, 257, DateTimeKind.Local).AddTicks(3515));

            migrationBuilder.UpdateData(
                table: "Breeds",
                keyColumn: "Id",
                keyValue: 105,
                column: "CreatedTime",
                value: new DateTime(2024, 8, 29, 15, 10, 46, 257, DateTimeKind.Local).AddTicks(3516));

            migrationBuilder.UpdateData(
                table: "Breeds",
                keyColumn: "Id",
                keyValue: 106,
                column: "CreatedTime",
                value: new DateTime(2024, 8, 29, 15, 10, 46, 257, DateTimeKind.Local).AddTicks(3517));

            migrationBuilder.UpdateData(
                table: "Breeds",
                keyColumn: "Id",
                keyValue: 107,
                column: "CreatedTime",
                value: new DateTime(2024, 8, 29, 15, 10, 46, 257, DateTimeKind.Local).AddTicks(3519));

            migrationBuilder.UpdateData(
                table: "Breeds",
                keyColumn: "Id",
                keyValue: 108,
                column: "CreatedTime",
                value: new DateTime(2024, 8, 29, 15, 10, 46, 257, DateTimeKind.Local).AddTicks(3520));

            migrationBuilder.UpdateData(
                table: "Breeds",
                keyColumn: "Id",
                keyValue: 109,
                column: "CreatedTime",
                value: new DateTime(2024, 8, 29, 15, 10, 46, 257, DateTimeKind.Local).AddTicks(3521));

            migrationBuilder.UpdateData(
                table: "Breeds",
                keyColumn: "Id",
                keyValue: 110,
                column: "CreatedTime",
                value: new DateTime(2024, 8, 29, 15, 10, 46, 257, DateTimeKind.Local).AddTicks(3522));

            migrationBuilder.UpdateData(
                table: "Breeds",
                keyColumn: "Id",
                keyValue: 111,
                column: "CreatedTime",
                value: new DateTime(2024, 8, 29, 15, 10, 46, 257, DateTimeKind.Local).AddTicks(3524));

            migrationBuilder.UpdateData(
                table: "Breeds",
                keyColumn: "Id",
                keyValue: 112,
                column: "CreatedTime",
                value: new DateTime(2024, 8, 29, 15, 10, 46, 257, DateTimeKind.Local).AddTicks(3525));

            migrationBuilder.UpdateData(
                table: "Breeds",
                keyColumn: "Id",
                keyValue: 113,
                column: "CreatedTime",
                value: new DateTime(2024, 8, 29, 15, 10, 46, 257, DateTimeKind.Local).AddTicks(3526));

            migrationBuilder.UpdateData(
                table: "Breeds",
                keyColumn: "Id",
                keyValue: 114,
                column: "CreatedTime",
                value: new DateTime(2024, 8, 29, 15, 10, 46, 257, DateTimeKind.Local).AddTicks(3527));

            migrationBuilder.UpdateData(
                table: "Breeds",
                keyColumn: "Id",
                keyValue: 115,
                column: "CreatedTime",
                value: new DateTime(2024, 8, 29, 15, 10, 46, 257, DateTimeKind.Local).AddTicks(3528));

            migrationBuilder.UpdateData(
                table: "Breeds",
                keyColumn: "Id",
                keyValue: 116,
                column: "CreatedTime",
                value: new DateTime(2024, 8, 29, 15, 10, 46, 257, DateTimeKind.Local).AddTicks(3530));

            migrationBuilder.UpdateData(
                table: "Breeds",
                keyColumn: "Id",
                keyValue: 117,
                column: "CreatedTime",
                value: new DateTime(2024, 8, 29, 15, 10, 46, 257, DateTimeKind.Local).AddTicks(3531));

            migrationBuilder.UpdateData(
                table: "Breeds",
                keyColumn: "Id",
                keyValue: 118,
                column: "CreatedTime",
                value: new DateTime(2024, 8, 29, 15, 10, 46, 257, DateTimeKind.Local).AddTicks(3532));

            migrationBuilder.UpdateData(
                table: "Breeds",
                keyColumn: "Id",
                keyValue: 119,
                column: "CreatedTime",
                value: new DateTime(2024, 8, 29, 15, 10, 46, 257, DateTimeKind.Local).AddTicks(3533));

            migrationBuilder.UpdateData(
                table: "Breeds",
                keyColumn: "Id",
                keyValue: 120,
                column: "CreatedTime",
                value: new DateTime(2024, 8, 29, 15, 10, 46, 257, DateTimeKind.Local).AddTicks(3535));

            migrationBuilder.UpdateData(
                table: "Breeds",
                keyColumn: "Id",
                keyValue: 121,
                column: "CreatedTime",
                value: new DateTime(2024, 8, 29, 15, 10, 46, 257, DateTimeKind.Local).AddTicks(3536));

            migrationBuilder.UpdateData(
                table: "Breeds",
                keyColumn: "Id",
                keyValue: 122,
                column: "CreatedTime",
                value: new DateTime(2024, 8, 29, 15, 10, 46, 257, DateTimeKind.Local).AddTicks(3537));

            migrationBuilder.UpdateData(
                table: "Breeds",
                keyColumn: "Id",
                keyValue: 123,
                column: "CreatedTime",
                value: new DateTime(2024, 8, 29, 15, 10, 46, 257, DateTimeKind.Local).AddTicks(3538));

            migrationBuilder.UpdateData(
                table: "Breeds",
                keyColumn: "Id",
                keyValue: 124,
                column: "CreatedTime",
                value: new DateTime(2024, 8, 29, 15, 10, 46, 257, DateTimeKind.Local).AddTicks(3540));

            migrationBuilder.UpdateData(
                table: "Breeds",
                keyColumn: "Id",
                keyValue: 125,
                column: "CreatedTime",
                value: new DateTime(2024, 8, 29, 15, 10, 46, 257, DateTimeKind.Local).AddTicks(3541));

            migrationBuilder.UpdateData(
                table: "Breeds",
                keyColumn: "Id",
                keyValue: 126,
                column: "CreatedTime",
                value: new DateTime(2024, 8, 29, 15, 10, 46, 257, DateTimeKind.Local).AddTicks(3542));

            migrationBuilder.UpdateData(
                table: "Breeds",
                keyColumn: "Id",
                keyValue: 127,
                column: "CreatedTime",
                value: new DateTime(2024, 8, 29, 15, 10, 46, 257, DateTimeKind.Local).AddTicks(3543));

            migrationBuilder.UpdateData(
                table: "Breeds",
                keyColumn: "Id",
                keyValue: 128,
                column: "CreatedTime",
                value: new DateTime(2024, 8, 29, 15, 10, 46, 257, DateTimeKind.Local).AddTicks(3545));

            migrationBuilder.UpdateData(
                table: "Breeds",
                keyColumn: "Id",
                keyValue: 129,
                column: "CreatedTime",
                value: new DateTime(2024, 8, 29, 15, 10, 46, 257, DateTimeKind.Local).AddTicks(3546));

            migrationBuilder.UpdateData(
                table: "Breeds",
                keyColumn: "Id",
                keyValue: 130,
                column: "CreatedTime",
                value: new DateTime(2024, 8, 29, 15, 10, 46, 257, DateTimeKind.Local).AddTicks(3547));

            migrationBuilder.UpdateData(
                table: "Breeds",
                keyColumn: "Id",
                keyValue: 131,
                column: "CreatedTime",
                value: new DateTime(2024, 8, 29, 15, 10, 46, 257, DateTimeKind.Local).AddTicks(3548));

            migrationBuilder.UpdateData(
                table: "Breeds",
                keyColumn: "Id",
                keyValue: 132,
                column: "CreatedTime",
                value: new DateTime(2024, 8, 29, 15, 10, 46, 257, DateTimeKind.Local).AddTicks(3550));

            migrationBuilder.UpdateData(
                table: "Breeds",
                keyColumn: "Id",
                keyValue: 133,
                column: "CreatedTime",
                value: new DateTime(2024, 8, 29, 15, 10, 46, 257, DateTimeKind.Local).AddTicks(3551));

            migrationBuilder.UpdateData(
                table: "Breeds",
                keyColumn: "Id",
                keyValue: 134,
                column: "CreatedTime",
                value: new DateTime(2024, 8, 29, 15, 10, 46, 257, DateTimeKind.Local).AddTicks(3552));

            migrationBuilder.UpdateData(
                table: "Breeds",
                keyColumn: "Id",
                keyValue: 135,
                column: "CreatedTime",
                value: new DateTime(2024, 8, 29, 15, 10, 46, 257, DateTimeKind.Local).AddTicks(3554));

            migrationBuilder.UpdateData(
                table: "Breeds",
                keyColumn: "Id",
                keyValue: 136,
                column: "CreatedTime",
                value: new DateTime(2024, 8, 29, 15, 10, 46, 257, DateTimeKind.Local).AddTicks(3555));

            migrationBuilder.UpdateData(
                table: "Breeds",
                keyColumn: "Id",
                keyValue: 137,
                column: "CreatedTime",
                value: new DateTime(2024, 8, 29, 15, 10, 46, 257, DateTimeKind.Local).AddTicks(3556));

            migrationBuilder.UpdateData(
                table: "Breeds",
                keyColumn: "Id",
                keyValue: 138,
                column: "CreatedTime",
                value: new DateTime(2024, 8, 29, 15, 10, 46, 257, DateTimeKind.Local).AddTicks(3557));

            migrationBuilder.UpdateData(
                table: "Breeds",
                keyColumn: "Id",
                keyValue: 139,
                column: "CreatedTime",
                value: new DateTime(2024, 8, 29, 15, 10, 46, 257, DateTimeKind.Local).AddTicks(3558));

            migrationBuilder.UpdateData(
                table: "Breeds",
                keyColumn: "Id",
                keyValue: 140,
                column: "CreatedTime",
                value: new DateTime(2024, 8, 29, 15, 10, 46, 257, DateTimeKind.Local).AddTicks(3560));

            migrationBuilder.UpdateData(
                table: "Breeds",
                keyColumn: "Id",
                keyValue: 141,
                column: "CreatedTime",
                value: new DateTime(2024, 8, 29, 15, 10, 46, 257, DateTimeKind.Local).AddTicks(3561));

            migrationBuilder.UpdateData(
                table: "Breeds",
                keyColumn: "Id",
                keyValue: 142,
                column: "CreatedTime",
                value: new DateTime(2024, 8, 29, 15, 10, 46, 257, DateTimeKind.Local).AddTicks(3562));

            migrationBuilder.UpdateData(
                table: "Breeds",
                keyColumn: "Id",
                keyValue: 143,
                column: "CreatedTime",
                value: new DateTime(2024, 8, 29, 15, 10, 46, 257, DateTimeKind.Local).AddTicks(3564));

            migrationBuilder.UpdateData(
                table: "Breeds",
                keyColumn: "Id",
                keyValue: 144,
                column: "CreatedTime",
                value: new DateTime(2024, 8, 29, 15, 10, 46, 257, DateTimeKind.Local).AddTicks(3565));

            migrationBuilder.UpdateData(
                table: "Breeds",
                keyColumn: "Id",
                keyValue: 145,
                column: "CreatedTime",
                value: new DateTime(2024, 8, 29, 15, 10, 46, 257, DateTimeKind.Local).AddTicks(3566));

            migrationBuilder.UpdateData(
                table: "Breeds",
                keyColumn: "Id",
                keyValue: 146,
                column: "CreatedTime",
                value: new DateTime(2024, 8, 29, 15, 10, 46, 257, DateTimeKind.Local).AddTicks(3567));

            migrationBuilder.UpdateData(
                table: "Breeds",
                keyColumn: "Id",
                keyValue: 147,
                column: "CreatedTime",
                value: new DateTime(2024, 8, 29, 15, 10, 46, 257, DateTimeKind.Local).AddTicks(3569));

            migrationBuilder.UpdateData(
                table: "Breeds",
                keyColumn: "Id",
                keyValue: 148,
                column: "CreatedTime",
                value: new DateTime(2024, 8, 29, 15, 10, 46, 257, DateTimeKind.Local).AddTicks(3570));

            migrationBuilder.UpdateData(
                table: "Breeds",
                keyColumn: "Id",
                keyValue: 149,
                column: "CreatedTime",
                value: new DateTime(2024, 8, 29, 15, 10, 46, 257, DateTimeKind.Local).AddTicks(3571));

            migrationBuilder.UpdateData(
                table: "Breeds",
                keyColumn: "Id",
                keyValue: 150,
                column: "CreatedTime",
                value: new DateTime(2024, 8, 29, 15, 10, 46, 257, DateTimeKind.Local).AddTicks(3573));

            migrationBuilder.UpdateData(
                table: "Breeds",
                keyColumn: "Id",
                keyValue: 151,
                column: "CreatedTime",
                value: new DateTime(2024, 8, 29, 15, 10, 46, 257, DateTimeKind.Local).AddTicks(3574));

            migrationBuilder.UpdateData(
                table: "Breeds",
                keyColumn: "Id",
                keyValue: 152,
                column: "CreatedTime",
                value: new DateTime(2024, 8, 29, 15, 10, 46, 257, DateTimeKind.Local).AddTicks(3575));

            migrationBuilder.UpdateData(
                table: "Breeds",
                keyColumn: "Id",
                keyValue: 153,
                column: "CreatedTime",
                value: new DateTime(2024, 8, 29, 15, 10, 46, 257, DateTimeKind.Local).AddTicks(3576));

            migrationBuilder.UpdateData(
                table: "Breeds",
                keyColumn: "Id",
                keyValue: 154,
                column: "CreatedTime",
                value: new DateTime(2024, 8, 29, 15, 10, 46, 257, DateTimeKind.Local).AddTicks(3578));

            migrationBuilder.UpdateData(
                table: "Breeds",
                keyColumn: "Id",
                keyValue: 155,
                column: "CreatedTime",
                value: new DateTime(2024, 8, 29, 15, 10, 46, 257, DateTimeKind.Local).AddTicks(3579));

            migrationBuilder.UpdateData(
                table: "Breeds",
                keyColumn: "Id",
                keyValue: 156,
                column: "CreatedTime",
                value: new DateTime(2024, 8, 29, 15, 10, 46, 257, DateTimeKind.Local).AddTicks(3580));

            migrationBuilder.UpdateData(
                table: "Breeds",
                keyColumn: "Id",
                keyValue: 157,
                column: "CreatedTime",
                value: new DateTime(2024, 8, 29, 15, 10, 46, 257, DateTimeKind.Local).AddTicks(3582));

            migrationBuilder.UpdateData(
                table: "Breeds",
                keyColumn: "Id",
                keyValue: 158,
                column: "CreatedTime",
                value: new DateTime(2024, 8, 29, 15, 10, 46, 257, DateTimeKind.Local).AddTicks(3583));

            migrationBuilder.UpdateData(
                table: "Breeds",
                keyColumn: "Id",
                keyValue: 159,
                column: "CreatedTime",
                value: new DateTime(2024, 8, 29, 15, 10, 46, 257, DateTimeKind.Local).AddTicks(3584));

            migrationBuilder.UpdateData(
                table: "Breeds",
                keyColumn: "Id",
                keyValue: 160,
                column: "CreatedTime",
                value: new DateTime(2024, 8, 29, 15, 10, 46, 257, DateTimeKind.Local).AddTicks(3585));

            migrationBuilder.UpdateData(
                table: "PetTypes",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedTime",
                value: new DateTime(2024, 8, 29, 15, 10, 46, 256, DateTimeKind.Local).AddTicks(4947));

            migrationBuilder.UpdateData(
                table: "PetTypes",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreatedTime",
                value: new DateTime(2024, 8, 29, 15, 10, 46, 256, DateTimeKind.Local).AddTicks(4952));

            migrationBuilder.UpdateData(
                table: "PetTypes",
                keyColumn: "Id",
                keyValue: 3,
                column: "CreatedTime",
                value: new DateTime(2024, 8, 29, 15, 10, 46, 256, DateTimeKind.Local).AddTicks(4953));

            migrationBuilder.UpdateData(
                table: "PetTypes",
                keyColumn: "Id",
                keyValue: 4,
                column: "CreatedTime",
                value: new DateTime(2024, 8, 29, 15, 10, 46, 256, DateTimeKind.Local).AddTicks(4955));

            migrationBuilder.UpdateData(
                table: "PetTypes",
                keyColumn: "Id",
                keyValue: 5,
                column: "CreatedTime",
                value: new DateTime(2024, 8, 29, 15, 10, 46, 256, DateTimeKind.Local).AddTicks(4956));

            migrationBuilder.UpdateData(
                table: "PetTypes",
                keyColumn: "Id",
                keyValue: 6,
                column: "CreatedTime",
                value: new DateTime(2024, 8, 29, 15, 10, 46, 256, DateTimeKind.Local).AddTicks(4957));

            migrationBuilder.UpdateData(
                table: "PetTypes",
                keyColumn: "Id",
                keyValue: 7,
                column: "CreatedTime",
                value: new DateTime(2024, 8, 29, 15, 10, 46, 256, DateTimeKind.Local).AddTicks(4959));

            migrationBuilder.UpdateData(
                table: "PetTypes",
                keyColumn: "Id",
                keyValue: 8,
                column: "CreatedTime",
                value: new DateTime(2024, 8, 29, 15, 10, 46, 256, DateTimeKind.Local).AddTicks(4960));

            migrationBuilder.UpdateData(
                table: "Pets",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CreatedTime", "PetTypeId" },
                values: new object[] { new DateTime(2024, 8, 29, 15, 10, 46, 327, DateTimeKind.Local).AddTicks(1840), 2 });

            migrationBuilder.UpdateData(
                table: "Pets",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreatedTime",
                value: new DateTime(2024, 8, 29, 15, 10, 46, 327, DateTimeKind.Local).AddTicks(1871));

            migrationBuilder.UpdateData(
                table: "Pets",
                keyColumn: "Id",
                keyValue: 3,
                column: "CreatedTime",
                value: new DateTime(2024, 8, 29, 15, 10, 46, 327, DateTimeKind.Local).AddTicks(1876));

            migrationBuilder.UpdateData(
                table: "Pets",
                keyColumn: "Id",
                keyValue: 4,
                column: "CreatedTime",
                value: new DateTime(2024, 8, 29, 15, 10, 46, 327, DateTimeKind.Local).AddTicks(1880));

            migrationBuilder.UpdateData(
                table: "Pets",
                keyColumn: "Id",
                keyValue: 5,
                column: "CreatedTime",
                value: new DateTime(2024, 8, 29, 15, 10, 46, 327, DateTimeKind.Local).AddTicks(1884));

            migrationBuilder.UpdateData(
                table: "Pets",
                keyColumn: "Id",
                keyValue: 6,
                column: "CreatedTime",
                value: new DateTime(2024, 8, 29, 15, 10, 46, 327, DateTimeKind.Local).AddTicks(1888));

            migrationBuilder.UpdateData(
                table: "Pets",
                keyColumn: "Id",
                keyValue: 7,
                column: "CreatedTime",
                value: new DateTime(2024, 8, 29, 15, 10, 46, 327, DateTimeKind.Local).AddTicks(1892));

            migrationBuilder.UpdateData(
                table: "Pets",
                keyColumn: "Id",
                keyValue: 8,
                column: "CreatedTime",
                value: new DateTime(2024, 8, 29, 15, 10, 46, 327, DateTimeKind.Local).AddTicks(1896));

            migrationBuilder.UpdateData(
                table: "Pets",
                keyColumn: "Id",
                keyValue: 9,
                column: "CreatedTime",
                value: new DateTime(2024, 8, 29, 15, 10, 46, 327, DateTimeKind.Local).AddTicks(1899));

            migrationBuilder.UpdateData(
                table: "Pets",
                keyColumn: "Id",
                keyValue: 10,
                column: "CreatedTime",
                value: new DateTime(2024, 8, 29, 15, 10, 46, 327, DateTimeKind.Local).AddTicks(1903));

            migrationBuilder.UpdateData(
                table: "Pets",
                keyColumn: "Id",
                keyValue: 11,
                column: "CreatedTime",
                value: new DateTime(2024, 8, 29, 15, 10, 46, 327, DateTimeKind.Local).AddTicks(1906));

            migrationBuilder.UpdateData(
                table: "Pets",
                keyColumn: "Id",
                keyValue: 12,
                column: "CreatedTime",
                value: new DateTime(2024, 8, 29, 15, 10, 46, 327, DateTimeKind.Local).AddTicks(1910));

            migrationBuilder.UpdateData(
                table: "Pets",
                keyColumn: "Id",
                keyValue: 13,
                column: "CreatedTime",
                value: new DateTime(2024, 8, 29, 15, 10, 46, 327, DateTimeKind.Local).AddTicks(1914));

            migrationBuilder.UpdateData(
                table: "Pets",
                keyColumn: "Id",
                keyValue: 14,
                column: "CreatedTime",
                value: new DateTime(2024, 8, 29, 15, 10, 46, 327, DateTimeKind.Local).AddTicks(1919));

            migrationBuilder.UpdateData(
                table: "Pets",
                keyColumn: "Id",
                keyValue: 15,
                column: "CreatedTime",
                value: new DateTime(2024, 8, 29, 15, 10, 46, 327, DateTimeKind.Local).AddTicks(1922));

            migrationBuilder.UpdateData(
                table: "Pets",
                keyColumn: "Id",
                keyValue: 16,
                column: "CreatedTime",
                value: new DateTime(2024, 8, 29, 15, 10, 46, 327, DateTimeKind.Local).AddTicks(1926));

            migrationBuilder.UpdateData(
                table: "Pets",
                keyColumn: "Id",
                keyValue: 17,
                column: "CreatedTime",
                value: new DateTime(2024, 8, 29, 15, 10, 46, 327, DateTimeKind.Local).AddTicks(1929));

            migrationBuilder.UpdateData(
                table: "Pets",
                keyColumn: "Id",
                keyValue: 18,
                column: "CreatedTime",
                value: new DateTime(2024, 8, 29, 15, 10, 46, 327, DateTimeKind.Local).AddTicks(1933));

            migrationBuilder.UpdateData(
                table: "Pets",
                keyColumn: "Id",
                keyValue: 19,
                column: "CreatedTime",
                value: new DateTime(2024, 8, 29, 15, 10, 46, 327, DateTimeKind.Local).AddTicks(1937));

            migrationBuilder.UpdateData(
                table: "Pets",
                keyColumn: "Id",
                keyValue: 20,
                column: "CreatedTime",
                value: new DateTime(2024, 8, 29, 15, 10, 46, 327, DateTimeKind.Local).AddTicks(1941));

            migrationBuilder.UpdateData(
                table: "Pets",
                keyColumn: "Id",
                keyValue: 21,
                column: "CreatedTime",
                value: new DateTime(2024, 8, 29, 15, 10, 46, 327, DateTimeKind.Local).AddTicks(1945));

            migrationBuilder.UpdateData(
                table: "Pets",
                keyColumn: "Id",
                keyValue: 22,
                column: "CreatedTime",
                value: new DateTime(2024, 8, 29, 15, 10, 46, 327, DateTimeKind.Local).AddTicks(1948));

            migrationBuilder.UpdateData(
                table: "Pets",
                keyColumn: "Id",
                keyValue: 23,
                column: "CreatedTime",
                value: new DateTime(2024, 8, 29, 15, 10, 46, 327, DateTimeKind.Local).AddTicks(1952));

            migrationBuilder.UpdateData(
                table: "Pets",
                keyColumn: "Id",
                keyValue: 24,
                column: "CreatedTime",
                value: new DateTime(2024, 8, 29, 15, 10, 46, 327, DateTimeKind.Local).AddTicks(1955));

            migrationBuilder.UpdateData(
                table: "Pets",
                keyColumn: "Id",
                keyValue: 25,
                column: "CreatedTime",
                value: new DateTime(2024, 8, 29, 15, 10, 46, 327, DateTimeKind.Local).AddTicks(2000));

            migrationBuilder.UpdateData(
                table: "Pets",
                keyColumn: "Id",
                keyValue: 26,
                column: "CreatedTime",
                value: new DateTime(2024, 8, 29, 15, 10, 46, 327, DateTimeKind.Local).AddTicks(2006));

            migrationBuilder.UpdateData(
                table: "Pets",
                keyColumn: "Id",
                keyValue: 27,
                column: "CreatedTime",
                value: new DateTime(2024, 8, 29, 15, 10, 46, 327, DateTimeKind.Local).AddTicks(2009));

            migrationBuilder.UpdateData(
                table: "Pets",
                keyColumn: "Id",
                keyValue: 28,
                column: "CreatedTime",
                value: new DateTime(2024, 8, 29, 15, 10, 46, 327, DateTimeKind.Local).AddTicks(2013));

            migrationBuilder.UpdateData(
                table: "Pets",
                keyColumn: "Id",
                keyValue: 29,
                column: "CreatedTime",
                value: new DateTime(2024, 8, 29, 15, 10, 46, 327, DateTimeKind.Local).AddTicks(2017));

            migrationBuilder.UpdateData(
                table: "Pets",
                keyColumn: "Id",
                keyValue: 30,
                column: "CreatedTime",
                value: new DateTime(2024, 8, 29, 15, 10, 46, 327, DateTimeKind.Local).AddTicks(2025));

            migrationBuilder.UpdateData(
                table: "Pets",
                keyColumn: "Id",
                keyValue: 31,
                column: "CreatedTime",
                value: new DateTime(2024, 8, 29, 15, 10, 46, 327, DateTimeKind.Local).AddTicks(2238));

            migrationBuilder.UpdateData(
                table: "Pets",
                keyColumn: "Id",
                keyValue: 32,
                column: "CreatedTime",
                value: new DateTime(2024, 8, 29, 15, 10, 46, 327, DateTimeKind.Local).AddTicks(2250));

            migrationBuilder.UpdateData(
                table: "Pets",
                keyColumn: "Id",
                keyValue: 33,
                column: "CreatedTime",
                value: new DateTime(2024, 8, 29, 15, 10, 46, 327, DateTimeKind.Local).AddTicks(2261));

            migrationBuilder.UpdateData(
                table: "Pets",
                keyColumn: "Id",
                keyValue: 34,
                column: "CreatedTime",
                value: new DateTime(2024, 8, 29, 15, 10, 46, 327, DateTimeKind.Local).AddTicks(2272));

            migrationBuilder.UpdateData(
                table: "Pets",
                keyColumn: "Id",
                keyValue: 35,
                column: "CreatedTime",
                value: new DateTime(2024, 8, 29, 15, 10, 46, 327, DateTimeKind.Local).AddTicks(2282));

            migrationBuilder.UpdateData(
                table: "Pets",
                keyColumn: "Id",
                keyValue: 36,
                column: "CreatedTime",
                value: new DateTime(2024, 8, 29, 15, 10, 46, 327, DateTimeKind.Local).AddTicks(2293));

            migrationBuilder.UpdateData(
                table: "Pets",
                keyColumn: "Id",
                keyValue: 37,
                column: "CreatedTime",
                value: new DateTime(2024, 8, 29, 15, 10, 46, 327, DateTimeKind.Local).AddTicks(2305));

            migrationBuilder.UpdateData(
                table: "Pets",
                keyColumn: "Id",
                keyValue: 38,
                column: "CreatedTime",
                value: new DateTime(2024, 8, 29, 15, 10, 46, 327, DateTimeKind.Local).AddTicks(2316));

            migrationBuilder.UpdateData(
                table: "Pets",
                keyColumn: "Id",
                keyValue: 39,
                column: "CreatedTime",
                value: new DateTime(2024, 8, 29, 15, 10, 46, 327, DateTimeKind.Local).AddTicks(2327));

            migrationBuilder.UpdateData(
                table: "Pets",
                keyColumn: "Id",
                keyValue: 40,
                column: "CreatedTime",
                value: new DateTime(2024, 8, 29, 15, 10, 46, 327, DateTimeKind.Local).AddTicks(2338));

            migrationBuilder.UpdateData(
                table: "Pets",
                keyColumn: "Id",
                keyValue: 41,
                column: "CreatedTime",
                value: new DateTime(2024, 8, 29, 15, 10, 46, 327, DateTimeKind.Local).AddTicks(2349));

            migrationBuilder.UpdateData(
                table: "Pets",
                keyColumn: "Id",
                keyValue: 42,
                column: "CreatedTime",
                value: new DateTime(2024, 8, 29, 15, 10, 46, 327, DateTimeKind.Local).AddTicks(2360));

            migrationBuilder.UpdateData(
                table: "Pets",
                keyColumn: "Id",
                keyValue: 43,
                column: "CreatedTime",
                value: new DateTime(2024, 8, 29, 15, 10, 46, 327, DateTimeKind.Local).AddTicks(2371));

            migrationBuilder.UpdateData(
                table: "Pets",
                keyColumn: "Id",
                keyValue: 44,
                column: "CreatedTime",
                value: new DateTime(2024, 8, 29, 15, 10, 46, 327, DateTimeKind.Local).AddTicks(2383));

            migrationBuilder.UpdateData(
                table: "Pets",
                keyColumn: "Id",
                keyValue: 45,
                column: "CreatedTime",
                value: new DateTime(2024, 8, 29, 15, 10, 46, 327, DateTimeKind.Local).AddTicks(2394));

            migrationBuilder.UpdateData(
                table: "Pets",
                keyColumn: "Id",
                keyValue: 46,
                column: "CreatedTime",
                value: new DateTime(2024, 8, 29, 15, 10, 46, 327, DateTimeKind.Local).AddTicks(2405));

            migrationBuilder.UpdateData(
                table: "Pets",
                keyColumn: "Id",
                keyValue: 47,
                column: "CreatedTime",
                value: new DateTime(2024, 8, 29, 15, 10, 46, 327, DateTimeKind.Local).AddTicks(2415));

            migrationBuilder.UpdateData(
                table: "Pets",
                keyColumn: "Id",
                keyValue: 48,
                column: "CreatedTime",
                value: new DateTime(2024, 8, 29, 15, 10, 46, 327, DateTimeKind.Local).AddTicks(2426));

            migrationBuilder.UpdateData(
                table: "Pets",
                keyColumn: "Id",
                keyValue: 49,
                column: "CreatedTime",
                value: new DateTime(2024, 8, 29, 15, 10, 46, 327, DateTimeKind.Local).AddTicks(2437));

            migrationBuilder.UpdateData(
                table: "Pets",
                keyColumn: "Id",
                keyValue: 50,
                column: "CreatedTime",
                value: new DateTime(2024, 8, 29, 15, 10, 46, 327, DateTimeKind.Local).AddTicks(2448));

            migrationBuilder.UpdateData(
                table: "Shelters",
                keyColumn: "Id",
                keyValue: 1021,
                columns: new[] { "CreatedTime", "LastUpdatedTime", "PhoneNumber" },
                values: new object[] { new DateTime(2024, 8, 29, 11, 10, 46, 256, DateTimeKind.Utc).AddTicks(3728), new DateTime(2024, 8, 29, 11, 10, 46, 256, DateTimeKind.Utc).AddTicks(3730), "+994501234567" });

            migrationBuilder.UpdateData(
                table: "Shelters",
                keyColumn: "Id",
                keyValue: 1022,
                columns: new[] { "CreatedTime", "LastUpdatedTime", "PhoneNumber" },
                values: new object[] { new DateTime(2024, 8, 29, 11, 10, 46, 256, DateTimeKind.Utc).AddTicks(3743), new DateTime(2024, 8, 29, 11, 10, 46, 256, DateTimeKind.Utc).AddTicks(3743), "+994501234567" });

            migrationBuilder.UpdateData(
                table: "Shelters",
                keyColumn: "Id",
                keyValue: 1023,
                columns: new[] { "CreatedTime", "LastUpdatedTime", "PhoneNumber" },
                values: new object[] { new DateTime(2024, 8, 29, 11, 10, 46, 256, DateTimeKind.Utc).AddTicks(3750), new DateTime(2024, 8, 29, 11, 10, 46, 256, DateTimeKind.Utc).AddTicks(3751), "+994501234567" });

            migrationBuilder.UpdateData(
                table: "Shelters",
                keyColumn: "Id",
                keyValue: 1024,
                columns: new[] { "CreatedTime", "LastUpdatedTime", "PhoneNumber" },
                values: new object[] { new DateTime(2024, 8, 29, 11, 10, 46, 256, DateTimeKind.Utc).AddTicks(3758), new DateTime(2024, 8, 29, 11, 10, 46, 256, DateTimeKind.Utc).AddTicks(3758), "+994501234567" });

            migrationBuilder.UpdateData(
                table: "Shelters",
                keyColumn: "Id",
                keyValue: 1025,
                columns: new[] { "CreatedTime", "LastUpdatedTime", "PhoneNumber" },
                values: new object[] { new DateTime(2024, 8, 29, 11, 10, 46, 256, DateTimeKind.Utc).AddTicks(3765), new DateTime(2024, 8, 29, 11, 10, 46, 256, DateTimeKind.Utc).AddTicks(3765), "+994501234567" });

            migrationBuilder.UpdateData(
                table: "Shelters",
                keyColumn: "Id",
                keyValue: 1026,
                columns: new[] { "CreatedTime", "LastUpdatedTime", "PhoneNumber" },
                values: new object[] { new DateTime(2024, 8, 29, 11, 10, 46, 256, DateTimeKind.Utc).AddTicks(3775), new DateTime(2024, 8, 29, 11, 10, 46, 256, DateTimeKind.Utc).AddTicks(3775), "+994501234567" });

            migrationBuilder.UpdateData(
                table: "Shelters",
                keyColumn: "Id",
                keyValue: 1027,
                columns: new[] { "CreatedTime", "LastUpdatedTime", "PhoneNumber" },
                values: new object[] { new DateTime(2024, 8, 29, 11, 10, 46, 256, DateTimeKind.Utc).AddTicks(3782), new DateTime(2024, 8, 29, 11, 10, 46, 256, DateTimeKind.Utc).AddTicks(3782), "+994501234567" });

            migrationBuilder.UpdateData(
                table: "Shelters",
                keyColumn: "Id",
                keyValue: 1028,
                columns: new[] { "CreatedTime", "LastUpdatedTime", "PhoneNumber" },
                values: new object[] { new DateTime(2024, 8, 29, 11, 10, 46, 256, DateTimeKind.Utc).AddTicks(3788), new DateTime(2024, 8, 29, 11, 10, 46, 256, DateTimeKind.Utc).AddTicks(3789), "+994501234567" });

            migrationBuilder.UpdateData(
                table: "Shelters",
                keyColumn: "Id",
                keyValue: 1029,
                columns: new[] { "CreatedTime", "LastUpdatedTime", "PhoneNumber" },
                values: new object[] { new DateTime(2024, 8, 29, 11, 10, 46, 256, DateTimeKind.Utc).AddTicks(3795), new DateTime(2024, 8, 29, 11, 10, 46, 256, DateTimeKind.Utc).AddTicks(3796), "+994501234567" });

            migrationBuilder.UpdateData(
                table: "Shelters",
                keyColumn: "Id",
                keyValue: 1030,
                columns: new[] { "CreatedTime", "LastUpdatedTime", "PhoneNumber" },
                values: new object[] { new DateTime(2024, 8, 29, 11, 10, 46, 256, DateTimeKind.Utc).AddTicks(3803), new DateTime(2024, 8, 29, 11, 10, 46, 256, DateTimeKind.Utc).AddTicks(3804), "+994501234567" });

            migrationBuilder.UpdateData(
                table: "Shelters",
                keyColumn: "Id",
                keyValue: 1031,
                columns: new[] { "CreatedTime", "LastUpdatedTime", "PhoneNumber" },
                values: new object[] { new DateTime(2024, 8, 29, 11, 10, 46, 256, DateTimeKind.Utc).AddTicks(3811), new DateTime(2024, 8, 29, 11, 10, 46, 256, DateTimeKind.Utc).AddTicks(3811), "+994501234567" });

            migrationBuilder.UpdateData(
                table: "Shelters",
                keyColumn: "Id",
                keyValue: 1032,
                columns: new[] { "CreatedTime", "LastUpdatedTime", "PhoneNumber" },
                values: new object[] { new DateTime(2024, 8, 29, 11, 10, 46, 256, DateTimeKind.Utc).AddTicks(3848), new DateTime(2024, 8, 29, 11, 10, 46, 256, DateTimeKind.Utc).AddTicks(3848), "+994501234567" });

            migrationBuilder.UpdateData(
                table: "Shelters",
                keyColumn: "Id",
                keyValue: 1033,
                columns: new[] { "CreatedTime", "LastUpdatedTime", "PhoneNumber" },
                values: new object[] { new DateTime(2024, 8, 29, 11, 10, 46, 256, DateTimeKind.Utc).AddTicks(4036), new DateTime(2024, 8, 29, 11, 10, 46, 256, DateTimeKind.Utc).AddTicks(4038), "+994501234567" });

            migrationBuilder.UpdateData(
                table: "Shelters",
                keyColumn: "Id",
                keyValue: 1034,
                columns: new[] { "CreatedTime", "LastUpdatedTime", "PhoneNumber" },
                values: new object[] { new DateTime(2024, 8, 29, 11, 10, 46, 256, DateTimeKind.Utc).AddTicks(4057), new DateTime(2024, 8, 29, 11, 10, 46, 256, DateTimeKind.Utc).AddTicks(4058), "+994501234567" });

            migrationBuilder.UpdateData(
                table: "Shelters",
                keyColumn: "Id",
                keyValue: 1035,
                columns: new[] { "CreatedTime", "LastUpdatedTime", "PhoneNumber" },
                values: new object[] { new DateTime(2024, 8, 29, 11, 10, 46, 256, DateTimeKind.Utc).AddTicks(4077), new DateTime(2024, 8, 29, 11, 10, 46, 256, DateTimeKind.Utc).AddTicks(4079), "+994501234567" });

            migrationBuilder.UpdateData(
                table: "Shelters",
                keyColumn: "Id",
                keyValue: 1036,
                columns: new[] { "CreatedTime", "LastUpdatedTime", "PhoneNumber" },
                values: new object[] { new DateTime(2024, 8, 29, 11, 10, 46, 256, DateTimeKind.Utc).AddTicks(4101), new DateTime(2024, 8, 29, 11, 10, 46, 256, DateTimeKind.Utc).AddTicks(4102), "+994501234567" });

            migrationBuilder.UpdateData(
                table: "Shelters",
                keyColumn: "Id",
                keyValue: 1037,
                columns: new[] { "CreatedTime", "LastUpdatedTime", "PhoneNumber" },
                values: new object[] { new DateTime(2024, 8, 29, 11, 10, 46, 256, DateTimeKind.Utc).AddTicks(4123), new DateTime(2024, 8, 29, 11, 10, 46, 256, DateTimeKind.Utc).AddTicks(4124), "+994501234567" });

            migrationBuilder.UpdateData(
                table: "Shelters",
                keyColumn: "Id",
                keyValue: 1038,
                columns: new[] { "CreatedTime", "LastUpdatedTime", "PhoneNumber" },
                values: new object[] { new DateTime(2024, 8, 29, 11, 10, 46, 256, DateTimeKind.Utc).AddTicks(4147), new DateTime(2024, 8, 29, 11, 10, 46, 256, DateTimeKind.Utc).AddTicks(4148), "+994501234567" });

            migrationBuilder.UpdateData(
                table: "Shelters",
                keyColumn: "Id",
                keyValue: 1039,
                columns: new[] { "CreatedTime", "LastUpdatedTime", "PhoneNumber" },
                values: new object[] { new DateTime(2024, 8, 29, 11, 10, 46, 256, DateTimeKind.Utc).AddTicks(4341), new DateTime(2024, 8, 29, 11, 10, 46, 256, DateTimeKind.Utc).AddTicks(4341), "+994501234567" });

            migrationBuilder.UpdateData(
                table: "Shelters",
                keyColumn: "Id",
                keyValue: 1040,
                columns: new[] { "CreatedTime", "LastUpdatedTime", "PhoneNumber" },
                values: new object[] { new DateTime(2024, 8, 29, 11, 10, 46, 256, DateTimeKind.Utc).AddTicks(4348), new DateTime(2024, 8, 29, 11, 10, 46, 256, DateTimeKind.Utc).AddTicks(4349), "+994501234567" });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "PhoneNumber",
                table: "Shelters");

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: 2001,
                columns: new[] { "ConcurrencyStamp", "CreatedTime", "LastUpdatedTime", "RefreshTokenCreateTime" },
                values: new object[] { "546515a9-23a7-4aec-9034-9a9f4fe309f5", new DateTime(2024, 8, 26, 8, 2, 41, 232, DateTimeKind.Utc).AddTicks(2340), new DateTime(2024, 8, 26, 8, 2, 41, 232, DateTimeKind.Utc).AddTicks(2341), new DateTime(2024, 8, 26, 8, 2, 41, 232, DateTimeKind.Utc).AddTicks(2272) });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: 2002,
                columns: new[] { "ConcurrencyStamp", "CreatedTime", "LastUpdatedTime", "RefreshTokenCreateTime" },
                values: new object[] { "c5f00b48-f3f8-480f-863f-0ab40777c9ae", new DateTime(2024, 8, 26, 8, 2, 41, 232, DateTimeKind.Utc).AddTicks(2403), new DateTime(2024, 8, 26, 8, 2, 41, 232, DateTimeKind.Utc).AddTicks(2404), new DateTime(2024, 8, 26, 8, 2, 41, 232, DateTimeKind.Utc).AddTicks(2399) });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: 2003,
                columns: new[] { "ConcurrencyStamp", "CreatedTime", "LastUpdatedTime", "RefreshTokenCreateTime" },
                values: new object[] { "98042ee5-42ee-48b5-b1e5-f708eada4f81", new DateTime(2024, 8, 26, 8, 2, 41, 232, DateTimeKind.Utc).AddTicks(2429), new DateTime(2024, 8, 26, 8, 2, 41, 232, DateTimeKind.Utc).AddTicks(2429), new DateTime(2024, 8, 26, 8, 2, 41, 232, DateTimeKind.Utc).AddTicks(2413) });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: 2004,
                columns: new[] { "ConcurrencyStamp", "CreatedTime", "LastUpdatedTime", "RefreshTokenCreateTime" },
                values: new object[] { "b32a27d5-9246-42d6-864b-c96236e5a2ff", new DateTime(2024, 8, 26, 8, 2, 41, 232, DateTimeKind.Utc).AddTicks(2441), new DateTime(2024, 8, 26, 8, 2, 41, 232, DateTimeKind.Utc).AddTicks(2442), new DateTime(2024, 8, 26, 8, 2, 41, 232, DateTimeKind.Utc).AddTicks(2438) });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: 2005,
                columns: new[] { "ConcurrencyStamp", "CreatedTime", "LastUpdatedTime", "RefreshTokenCreateTime" },
                values: new object[] { "b0bbfa29-6f61-4c35-ab8b-babdf2ba9cc0", new DateTime(2024, 8, 26, 8, 2, 41, 232, DateTimeKind.Utc).AddTicks(2453), new DateTime(2024, 8, 26, 8, 2, 41, 232, DateTimeKind.Utc).AddTicks(2453), new DateTime(2024, 8, 26, 8, 2, 41, 232, DateTimeKind.Utc).AddTicks(2450) });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: 2006,
                columns: new[] { "ConcurrencyStamp", "CreatedTime", "LastUpdatedTime", "RefreshTokenCreateTime" },
                values: new object[] { "8299c46f-9f11-4334-a851-90bc46c0f830", new DateTime(2024, 8, 26, 8, 2, 41, 232, DateTimeKind.Utc).AddTicks(2467), new DateTime(2024, 8, 26, 8, 2, 41, 232, DateTimeKind.Utc).AddTicks(2468), new DateTime(2024, 8, 26, 8, 2, 41, 232, DateTimeKind.Utc).AddTicks(2464) });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: 2007,
                columns: new[] { "ConcurrencyStamp", "CreatedTime", "LastUpdatedTime", "RefreshTokenCreateTime" },
                values: new object[] { "cf0dcfdc-3943-4ca5-a6c0-9d550d248278", new DateTime(2024, 8, 26, 8, 2, 41, 232, DateTimeKind.Utc).AddTicks(2479), new DateTime(2024, 8, 26, 8, 2, 41, 232, DateTimeKind.Utc).AddTicks(2480), new DateTime(2024, 8, 26, 8, 2, 41, 232, DateTimeKind.Utc).AddTicks(2476) });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: 2008,
                columns: new[] { "ConcurrencyStamp", "CreatedTime", "LastUpdatedTime", "RefreshTokenCreateTime" },
                values: new object[] { "8c890f9d-6b0c-4089-847c-6caba45338d4", new DateTime(2024, 8, 26, 8, 2, 41, 232, DateTimeKind.Utc).AddTicks(2491), new DateTime(2024, 8, 26, 8, 2, 41, 232, DateTimeKind.Utc).AddTicks(2492), new DateTime(2024, 8, 26, 8, 2, 41, 232, DateTimeKind.Utc).AddTicks(2488) });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: 2009,
                columns: new[] { "ConcurrencyStamp", "CreatedTime", "LastUpdatedTime", "RefreshTokenCreateTime" },
                values: new object[] { "07b3d827-55b6-4a4a-a6c7-aeef6d022aea", new DateTime(2024, 8, 26, 8, 2, 41, 232, DateTimeKind.Utc).AddTicks(2502), new DateTime(2024, 8, 26, 8, 2, 41, 232, DateTimeKind.Utc).AddTicks(2503), new DateTime(2024, 8, 26, 8, 2, 41, 232, DateTimeKind.Utc).AddTicks(2500) });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: 2010,
                columns: new[] { "ConcurrencyStamp", "CreatedTime", "LastUpdatedTime", "RefreshTokenCreateTime" },
                values: new object[] { "4b6276bc-b2a2-4d3c-b943-e071fdca5f09", new DateTime(2024, 8, 26, 8, 2, 41, 232, DateTimeKind.Utc).AddTicks(2596), new DateTime(2024, 8, 26, 8, 2, 41, 232, DateTimeKind.Utc).AddTicks(2597), new DateTime(2024, 8, 26, 8, 2, 41, 232, DateTimeKind.Utc).AddTicks(2592) });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: 2011,
                columns: new[] { "ConcurrencyStamp", "CreatedTime", "LastUpdatedTime", "RefreshTokenCreateTime" },
                values: new object[] { "9fb51c97-c955-4018-995e-38e4900bab8c", new DateTime(2024, 8, 26, 8, 2, 41, 232, DateTimeKind.Utc).AddTicks(2616), new DateTime(2024, 8, 26, 8, 2, 41, 232, DateTimeKind.Utc).AddTicks(2617), new DateTime(2024, 8, 26, 8, 2, 41, 232, DateTimeKind.Utc).AddTicks(2608) });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: 2012,
                columns: new[] { "ConcurrencyStamp", "CreatedTime", "LastUpdatedTime", "RefreshTokenCreateTime" },
                values: new object[] { "ff189fc5-03ad-4ea2-ad32-fc3126ef6dc7", new DateTime(2024, 8, 26, 8, 2, 41, 232, DateTimeKind.Utc).AddTicks(2628), new DateTime(2024, 8, 26, 8, 2, 41, 232, DateTimeKind.Utc).AddTicks(2628), new DateTime(2024, 8, 26, 8, 2, 41, 232, DateTimeKind.Utc).AddTicks(2625) });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: 2013,
                columns: new[] { "ConcurrencyStamp", "CreatedTime", "LastUpdatedTime", "RefreshTokenCreateTime" },
                values: new object[] { "da1c9d59-a11c-4ab7-8d9d-111aa76d658a", new DateTime(2024, 8, 26, 8, 2, 41, 232, DateTimeKind.Utc).AddTicks(2639), new DateTime(2024, 8, 26, 8, 2, 41, 232, DateTimeKind.Utc).AddTicks(2639), new DateTime(2024, 8, 26, 8, 2, 41, 232, DateTimeKind.Utc).AddTicks(2636) });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: 2014,
                columns: new[] { "ConcurrencyStamp", "CreatedTime", "LastUpdatedTime", "RefreshTokenCreateTime" },
                values: new object[] { "23356796-4ef3-4028-bf5e-6ceaefea22ea", new DateTime(2024, 8, 26, 8, 2, 41, 232, DateTimeKind.Utc).AddTicks(2650), new DateTime(2024, 8, 26, 8, 2, 41, 232, DateTimeKind.Utc).AddTicks(2650), new DateTime(2024, 8, 26, 8, 2, 41, 232, DateTimeKind.Utc).AddTicks(2647) });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: 2015,
                columns: new[] { "ConcurrencyStamp", "CreatedTime", "LastUpdatedTime", "RefreshTokenCreateTime" },
                values: new object[] { "5ee4c89c-75f1-4b26-8602-834c7ed55e15", new DateTime(2024, 8, 26, 8, 2, 41, 232, DateTimeKind.Utc).AddTicks(2662), new DateTime(2024, 8, 26, 8, 2, 41, 232, DateTimeKind.Utc).AddTicks(2662), new DateTime(2024, 8, 26, 8, 2, 41, 232, DateTimeKind.Utc).AddTicks(2658) });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: 2016,
                columns: new[] { "ConcurrencyStamp", "CreatedTime", "LastUpdatedTime", "RefreshTokenCreateTime" },
                values: new object[] { "096f3701-1107-411a-b7b8-e57f27ebfef9", new DateTime(2024, 8, 26, 8, 2, 41, 232, DateTimeKind.Utc).AddTicks(2673), new DateTime(2024, 8, 26, 8, 2, 41, 232, DateTimeKind.Utc).AddTicks(2673), new DateTime(2024, 8, 26, 8, 2, 41, 232, DateTimeKind.Utc).AddTicks(2670) });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: 2017,
                columns: new[] { "ConcurrencyStamp", "CreatedTime", "LastUpdatedTime", "RefreshTokenCreateTime" },
                values: new object[] { "532c4e5f-2650-40b4-b99b-388fdb4f457d", new DateTime(2024, 8, 26, 8, 2, 41, 232, DateTimeKind.Utc).AddTicks(2684), new DateTime(2024, 8, 26, 8, 2, 41, 232, DateTimeKind.Utc).AddTicks(2685), new DateTime(2024, 8, 26, 8, 2, 41, 232, DateTimeKind.Utc).AddTicks(2681) });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: 2018,
                columns: new[] { "ConcurrencyStamp", "CreatedTime", "LastUpdatedTime", "RefreshTokenCreateTime" },
                values: new object[] { "b33d9df1-49a7-45d9-9bab-ca4675f037ad", new DateTime(2024, 8, 26, 8, 2, 41, 232, DateTimeKind.Utc).AddTicks(2698), new DateTime(2024, 8, 26, 8, 2, 41, 232, DateTimeKind.Utc).AddTicks(2698), new DateTime(2024, 8, 26, 8, 2, 41, 232, DateTimeKind.Utc).AddTicks(2695) });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: 2019,
                columns: new[] { "ConcurrencyStamp", "CreatedTime", "LastUpdatedTime", "RefreshTokenCreateTime" },
                values: new object[] { "ebe8153b-2afc-498e-9229-b198daa29311", new DateTime(2024, 8, 26, 8, 2, 41, 232, DateTimeKind.Utc).AddTicks(2765), new DateTime(2024, 8, 26, 8, 2, 41, 232, DateTimeKind.Utc).AddTicks(2766), new DateTime(2024, 8, 26, 8, 2, 41, 232, DateTimeKind.Utc).AddTicks(2758) });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: 2020,
                columns: new[] { "ConcurrencyStamp", "CreatedTime", "LastUpdatedTime", "RefreshTokenCreateTime" },
                values: new object[] { "c2929caa-ec2f-4c1f-ab46-3b23ca3fd76a", new DateTime(2024, 8, 26, 8, 2, 41, 232, DateTimeKind.Utc).AddTicks(2778), new DateTime(2024, 8, 26, 8, 2, 41, 232, DateTimeKind.Utc).AddTicks(2779), new DateTime(2024, 8, 26, 8, 2, 41, 232, DateTimeKind.Utc).AddTicks(2775) });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: 2021,
                columns: new[] { "ConcurrencyStamp", "CreatedTime", "LastUpdatedTime", "RefreshTokenCreateTime" },
                values: new object[] { "2f09ea2a-c710-4720-915c-3094f355579e", new DateTime(2024, 8, 26, 8, 2, 41, 232, DateTimeKind.Utc).AddTicks(2792), new DateTime(2024, 8, 26, 8, 2, 41, 232, DateTimeKind.Utc).AddTicks(2792), new DateTime(2024, 8, 26, 8, 2, 41, 232, DateTimeKind.Utc).AddTicks(2789) });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: 2022,
                columns: new[] { "ConcurrencyStamp", "CreatedTime", "LastUpdatedTime", "RefreshTokenCreateTime" },
                values: new object[] { "e444f09d-d1dd-468c-ad4b-e0d8dca25d09", new DateTime(2024, 8, 26, 8, 2, 41, 232, DateTimeKind.Utc).AddTicks(2811), new DateTime(2024, 8, 26, 8, 2, 41, 232, DateTimeKind.Utc).AddTicks(2812), new DateTime(2024, 8, 26, 8, 2, 41, 232, DateTimeKind.Utc).AddTicks(2808) });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: 2023,
                columns: new[] { "ConcurrencyStamp", "CreatedTime", "LastUpdatedTime", "RefreshTokenCreateTime" },
                values: new object[] { "f6ab9f36-0ca5-4812-b7f2-a9b567c45c85", new DateTime(2024, 8, 26, 8, 2, 41, 232, DateTimeKind.Utc).AddTicks(2824), new DateTime(2024, 8, 26, 8, 2, 41, 232, DateTimeKind.Utc).AddTicks(2825), new DateTime(2024, 8, 26, 8, 2, 41, 232, DateTimeKind.Utc).AddTicks(2821) });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: 2024,
                columns: new[] { "ConcurrencyStamp", "CreatedTime", "LastUpdatedTime", "RefreshTokenCreateTime" },
                values: new object[] { "4db6007a-72b5-46fd-95b4-2da6ec39e4ce", new DateTime(2024, 8, 26, 8, 2, 41, 232, DateTimeKind.Utc).AddTicks(2837), new DateTime(2024, 8, 26, 8, 2, 41, 232, DateTimeKind.Utc).AddTicks(2838), new DateTime(2024, 8, 26, 8, 2, 41, 232, DateTimeKind.Utc).AddTicks(2834) });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: 2025,
                columns: new[] { "ConcurrencyStamp", "CreatedTime", "LastUpdatedTime", "RefreshTokenCreateTime" },
                values: new object[] { "9036a215-b509-4920-b45a-2af239f42032", new DateTime(2024, 8, 26, 8, 2, 41, 232, DateTimeKind.Utc).AddTicks(2849), new DateTime(2024, 8, 26, 8, 2, 41, 232, DateTimeKind.Utc).AddTicks(2849), new DateTime(2024, 8, 26, 8, 2, 41, 232, DateTimeKind.Utc).AddTicks(2846) });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: 2026,
                columns: new[] { "ConcurrencyStamp", "CreatedTime", "LastUpdatedTime", "RefreshTokenCreateTime" },
                values: new object[] { "a6f19736-9722-4c35-b516-05dc3d872e43", new DateTime(2024, 8, 26, 8, 2, 41, 232, DateTimeKind.Utc).AddTicks(2861), new DateTime(2024, 8, 26, 8, 2, 41, 232, DateTimeKind.Utc).AddTicks(2862), new DateTime(2024, 8, 26, 8, 2, 41, 232, DateTimeKind.Utc).AddTicks(2858) });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: 2027,
                columns: new[] { "ConcurrencyStamp", "CreatedTime", "LastUpdatedTime", "RefreshTokenCreateTime" },
                values: new object[] { "a5f77e36-3da9-4818-b679-a1b1b168cfa9", new DateTime(2024, 8, 26, 8, 2, 41, 232, DateTimeKind.Utc).AddTicks(2878), new DateTime(2024, 8, 26, 8, 2, 41, 232, DateTimeKind.Utc).AddTicks(2878), new DateTime(2024, 8, 26, 8, 2, 41, 232, DateTimeKind.Utc).AddTicks(2872) });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: 2028,
                columns: new[] { "ConcurrencyStamp", "CreatedTime", "LastUpdatedTime", "RefreshTokenCreateTime" },
                values: new object[] { "bbd831bf-8882-453e-ae2c-9850997c6bd8", new DateTime(2024, 8, 26, 8, 2, 41, 232, DateTimeKind.Utc).AddTicks(2925), new DateTime(2024, 8, 26, 8, 2, 41, 232, DateTimeKind.Utc).AddTicks(2925), new DateTime(2024, 8, 26, 8, 2, 41, 232, DateTimeKind.Utc).AddTicks(2922) });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: 2029,
                columns: new[] { "ConcurrencyStamp", "CreatedTime", "LastUpdatedTime", "RefreshTokenCreateTime" },
                values: new object[] { "9b46643c-94b4-4bdb-b2fe-8463baa4339e", new DateTime(2024, 8, 26, 8, 2, 41, 232, DateTimeKind.Utc).AddTicks(2938), new DateTime(2024, 8, 26, 8, 2, 41, 232, DateTimeKind.Utc).AddTicks(2939), new DateTime(2024, 8, 26, 8, 2, 41, 232, DateTimeKind.Utc).AddTicks(2935) });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: 2030,
                columns: new[] { "ConcurrencyStamp", "CreatedTime", "LastUpdatedTime", "RefreshTokenCreateTime" },
                values: new object[] { "24507c25-7477-428b-b615-1a4b38a61486", new DateTime(2024, 8, 26, 8, 2, 41, 232, DateTimeKind.Utc).AddTicks(2951), new DateTime(2024, 8, 26, 8, 2, 41, 232, DateTimeKind.Utc).AddTicks(2951), new DateTime(2024, 8, 26, 8, 2, 41, 232, DateTimeKind.Utc).AddTicks(2948) });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: 2031,
                columns: new[] { "ConcurrencyStamp", "CreatedTime", "LastUpdatedTime", "RefreshTokenCreateTime" },
                values: new object[] { "4d775e06-2dc1-4eb0-a00d-7a0fedacfbe2", new DateTime(2024, 8, 26, 8, 2, 41, 232, DateTimeKind.Utc).AddTicks(2963), new DateTime(2024, 8, 26, 8, 2, 41, 232, DateTimeKind.Utc).AddTicks(2963), new DateTime(2024, 8, 26, 8, 2, 41, 232, DateTimeKind.Utc).AddTicks(2960) });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: 2032,
                columns: new[] { "ConcurrencyStamp", "CreatedTime", "LastUpdatedTime", "RefreshTokenCreateTime" },
                values: new object[] { "44ce0e53-0c68-4fbd-8ddd-e90218c0a096", new DateTime(2024, 8, 26, 8, 2, 41, 232, DateTimeKind.Utc).AddTicks(2976), new DateTime(2024, 8, 26, 8, 2, 41, 232, DateTimeKind.Utc).AddTicks(2976), new DateTime(2024, 8, 26, 8, 2, 41, 232, DateTimeKind.Utc).AddTicks(2972) });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: 2033,
                columns: new[] { "ConcurrencyStamp", "CreatedTime", "LastUpdatedTime", "RefreshTokenCreateTime" },
                values: new object[] { "5f2bbf4c-1e2f-457a-bfbf-5fe8f8d296df", new DateTime(2024, 8, 26, 8, 2, 41, 232, DateTimeKind.Utc).AddTicks(2988), new DateTime(2024, 8, 26, 8, 2, 41, 232, DateTimeKind.Utc).AddTicks(2989), new DateTime(2024, 8, 26, 8, 2, 41, 232, DateTimeKind.Utc).AddTicks(2985) });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: 2034,
                columns: new[] { "ConcurrencyStamp", "CreatedTime", "LastUpdatedTime", "RefreshTokenCreateTime" },
                values: new object[] { "e86a3f2e-2604-4f6b-aaa8-9db01c0ff762", new DateTime(2024, 8, 26, 8, 2, 41, 232, DateTimeKind.Utc).AddTicks(3003), new DateTime(2024, 8, 26, 8, 2, 41, 232, DateTimeKind.Utc).AddTicks(3003), new DateTime(2024, 8, 26, 8, 2, 41, 232, DateTimeKind.Utc).AddTicks(2999) });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: 2035,
                columns: new[] { "ConcurrencyStamp", "CreatedTime", "LastUpdatedTime", "RefreshTokenCreateTime" },
                values: new object[] { "19d91566-833a-406d-8dd9-e241bfdc6204", new DateTime(2024, 8, 26, 8, 2, 41, 232, DateTimeKind.Utc).AddTicks(3018), new DateTime(2024, 8, 26, 8, 2, 41, 232, DateTimeKind.Utc).AddTicks(3019), new DateTime(2024, 8, 26, 8, 2, 41, 232, DateTimeKind.Utc).AddTicks(3012) });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: 2036,
                columns: new[] { "ConcurrencyStamp", "CreatedTime", "LastUpdatedTime", "RefreshTokenCreateTime" },
                values: new object[] { "550b374a-95bb-4fc6-bbd9-0a889c1d003e", new DateTime(2024, 8, 26, 8, 2, 41, 232, DateTimeKind.Utc).AddTicks(3031), new DateTime(2024, 8, 26, 8, 2, 41, 232, DateTimeKind.Utc).AddTicks(3031), new DateTime(2024, 8, 26, 8, 2, 41, 232, DateTimeKind.Utc).AddTicks(3028) });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: 2037,
                columns: new[] { "ConcurrencyStamp", "CreatedTime", "LastUpdatedTime", "RefreshTokenCreateTime" },
                values: new object[] { "de6a6dfb-76f3-4dbe-9d5a-fb84ff3453d3", new DateTime(2024, 8, 26, 8, 2, 41, 232, DateTimeKind.Utc).AddTicks(3081), new DateTime(2024, 8, 26, 8, 2, 41, 232, DateTimeKind.Utc).AddTicks(3082), new DateTime(2024, 8, 26, 8, 2, 41, 232, DateTimeKind.Utc).AddTicks(3078) });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: 2038,
                columns: new[] { "ConcurrencyStamp", "CreatedTime", "LastUpdatedTime", "RefreshTokenCreateTime" },
                values: new object[] { "2c58d7fa-3f19-4c76-83d9-d2e23f2fe427", new DateTime(2024, 8, 26, 8, 2, 41, 232, DateTimeKind.Utc).AddTicks(3094), new DateTime(2024, 8, 26, 8, 2, 41, 232, DateTimeKind.Utc).AddTicks(3094), new DateTime(2024, 8, 26, 8, 2, 41, 232, DateTimeKind.Utc).AddTicks(3091) });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: 2039,
                columns: new[] { "ConcurrencyStamp", "CreatedTime", "LastUpdatedTime", "RefreshTokenCreateTime" },
                values: new object[] { "0b243900-cce9-43e3-abae-bd91cf207538", new DateTime(2024, 8, 26, 8, 2, 41, 232, DateTimeKind.Utc).AddTicks(3107), new DateTime(2024, 8, 26, 8, 2, 41, 232, DateTimeKind.Utc).AddTicks(3107), new DateTime(2024, 8, 26, 8, 2, 41, 232, DateTimeKind.Utc).AddTicks(3104) });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: 2040,
                columns: new[] { "ConcurrencyStamp", "CreatedTime", "LastUpdatedTime", "RefreshTokenCreateTime" },
                values: new object[] { "8cac7d98-a39a-45c6-bc0d-9510a108ea90", new DateTime(2024, 8, 26, 8, 2, 41, 232, DateTimeKind.Utc).AddTicks(3119), new DateTime(2024, 8, 26, 8, 2, 41, 232, DateTimeKind.Utc).AddTicks(3120), new DateTime(2024, 8, 26, 8, 2, 41, 232, DateTimeKind.Utc).AddTicks(3116) });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: 2041,
                columns: new[] { "ConcurrencyStamp", "CreatedTime", "LastUpdatedTime", "RefreshTokenCreateTime" },
                values: new object[] { "ae57dfec-7bf2-4c45-9772-6c1ea7d7f210", new DateTime(2024, 8, 26, 8, 2, 41, 232, DateTimeKind.Utc).AddTicks(3134), new DateTime(2024, 8, 26, 8, 2, 41, 232, DateTimeKind.Utc).AddTicks(3134), new DateTime(2024, 8, 26, 8, 2, 41, 232, DateTimeKind.Utc).AddTicks(3130) });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: 2042,
                columns: new[] { "ConcurrencyStamp", "CreatedTime", "LastUpdatedTime", "RefreshTokenCreateTime" },
                values: new object[] { "dd702af2-73c3-4e8d-972e-28bc1600f002", new DateTime(2024, 8, 26, 8, 2, 41, 232, DateTimeKind.Utc).AddTicks(3150), new DateTime(2024, 8, 26, 8, 2, 41, 232, DateTimeKind.Utc).AddTicks(3151), new DateTime(2024, 8, 26, 8, 2, 41, 232, DateTimeKind.Utc).AddTicks(3147) });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: 2043,
                columns: new[] { "ConcurrencyStamp", "CreatedTime", "LastUpdatedTime", "RefreshTokenCreateTime" },
                values: new object[] { "a89e86d8-1e53-45d0-afc8-08a103d6b04d", new DateTime(2024, 8, 26, 8, 2, 41, 232, DateTimeKind.Utc).AddTicks(3165), new DateTime(2024, 8, 26, 8, 2, 41, 232, DateTimeKind.Utc).AddTicks(3165), new DateTime(2024, 8, 26, 8, 2, 41, 232, DateTimeKind.Utc).AddTicks(3159) });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: 2044,
                columns: new[] { "ConcurrencyStamp", "CreatedTime", "LastUpdatedTime", "RefreshTokenCreateTime" },
                values: new object[] { "cea17281-1fec-465b-b7b5-69218cc00566", new DateTime(2024, 8, 26, 8, 2, 41, 232, DateTimeKind.Utc).AddTicks(3176), new DateTime(2024, 8, 26, 8, 2, 41, 232, DateTimeKind.Utc).AddTicks(3177), new DateTime(2024, 8, 26, 8, 2, 41, 232, DateTimeKind.Utc).AddTicks(3173) });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: 2045,
                columns: new[] { "ConcurrencyStamp", "CreatedTime", "LastUpdatedTime", "RefreshTokenCreateTime" },
                values: new object[] { "114840a7-9697-4595-9d16-0c0ef3828caf", new DateTime(2024, 8, 26, 8, 2, 41, 232, DateTimeKind.Utc).AddTicks(3188), new DateTime(2024, 8, 26, 8, 2, 41, 232, DateTimeKind.Utc).AddTicks(3189), new DateTime(2024, 8, 26, 8, 2, 41, 232, DateTimeKind.Utc).AddTicks(3185) });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: 2046,
                columns: new[] { "ConcurrencyStamp", "CreatedTime", "LastUpdatedTime", "RefreshTokenCreateTime" },
                values: new object[] { "6302f3d4-378c-4e07-90a2-e199131f406f", new DateTime(2024, 8, 26, 8, 2, 41, 232, DateTimeKind.Utc).AddTicks(3236), new DateTime(2024, 8, 26, 8, 2, 41, 232, DateTimeKind.Utc).AddTicks(3236), new DateTime(2024, 8, 26, 8, 2, 41, 232, DateTimeKind.Utc).AddTicks(3232) });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: 2047,
                columns: new[] { "ConcurrencyStamp", "CreatedTime", "LastUpdatedTime", "RefreshTokenCreateTime" },
                values: new object[] { "e3746cad-81f6-4585-a4a4-f64001554d27", new DateTime(2024, 8, 26, 8, 2, 41, 232, DateTimeKind.Utc).AddTicks(3247), new DateTime(2024, 8, 26, 8, 2, 41, 232, DateTimeKind.Utc).AddTicks(3248), new DateTime(2024, 8, 26, 8, 2, 41, 232, DateTimeKind.Utc).AddTicks(3245) });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: 2048,
                columns: new[] { "ConcurrencyStamp", "CreatedTime", "LastUpdatedTime", "RefreshTokenCreateTime" },
                values: new object[] { "38e7f195-12c8-4690-8b79-d878ff660c68", new DateTime(2024, 8, 26, 8, 2, 41, 232, DateTimeKind.Utc).AddTicks(3260), new DateTime(2024, 8, 26, 8, 2, 41, 232, DateTimeKind.Utc).AddTicks(3260), new DateTime(2024, 8, 26, 8, 2, 41, 232, DateTimeKind.Utc).AddTicks(3256) });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: 2049,
                columns: new[] { "ConcurrencyStamp", "CreatedTime", "LastUpdatedTime", "RefreshTokenCreateTime" },
                values: new object[] { "6b7c15de-37e8-49d8-91dd-80f126250cef", new DateTime(2024, 8, 26, 8, 2, 41, 232, DateTimeKind.Utc).AddTicks(3271), new DateTime(2024, 8, 26, 8, 2, 41, 232, DateTimeKind.Utc).AddTicks(3271), new DateTime(2024, 8, 26, 8, 2, 41, 232, DateTimeKind.Utc).AddTicks(3268) });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: 2050,
                columns: new[] { "ConcurrencyStamp", "CreatedTime", "LastUpdatedTime", "RefreshTokenCreateTime" },
                values: new object[] { "42a043e2-5a3e-44af-8bdf-4d075919436a", new DateTime(2024, 8, 26, 8, 2, 41, 232, DateTimeKind.Utc).AddTicks(3282), new DateTime(2024, 8, 26, 8, 2, 41, 232, DateTimeKind.Utc).AddTicks(3283), new DateTime(2024, 8, 26, 8, 2, 41, 232, DateTimeKind.Utc).AddTicks(3279) });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: 2051,
                columns: new[] { "ConcurrencyStamp", "CreatedTime", "LastUpdatedTime", "RefreshTokenCreateTime" },
                values: new object[] { "8227f51a-4ddf-4dba-bfd2-482e80b43f8b", new DateTime(2024, 8, 26, 8, 2, 41, 232, DateTimeKind.Utc).AddTicks(3296), new DateTime(2024, 8, 26, 8, 2, 41, 232, DateTimeKind.Utc).AddTicks(3297), new DateTime(2024, 8, 26, 8, 2, 41, 232, DateTimeKind.Utc).AddTicks(3290) });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: 2052,
                columns: new[] { "ConcurrencyStamp", "CreatedTime", "LastUpdatedTime", "RefreshTokenCreateTime" },
                values: new object[] { "74229607-ed1f-44dc-97fe-b53bd73da51d", new DateTime(2024, 8, 26, 8, 2, 41, 232, DateTimeKind.Utc).AddTicks(3308), new DateTime(2024, 8, 26, 8, 2, 41, 232, DateTimeKind.Utc).AddTicks(3308), new DateTime(2024, 8, 26, 8, 2, 41, 232, DateTimeKind.Utc).AddTicks(3304) });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: 2053,
                columns: new[] { "ConcurrencyStamp", "CreatedTime", "LastUpdatedTime", "RefreshTokenCreateTime" },
                values: new object[] { "4c03f496-6af1-42f2-a3c4-c7af88612fab", new DateTime(2024, 8, 26, 8, 2, 41, 232, DateTimeKind.Utc).AddTicks(3319), new DateTime(2024, 8, 26, 8, 2, 41, 232, DateTimeKind.Utc).AddTicks(3319), new DateTime(2024, 8, 26, 8, 2, 41, 232, DateTimeKind.Utc).AddTicks(3316) });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: 2054,
                columns: new[] { "ConcurrencyStamp", "CreatedTime", "LastUpdatedTime", "RefreshTokenCreateTime" },
                values: new object[] { "04767bc4-0f5b-40e2-a64a-3a3b9b1f5115", new DateTime(2024, 8, 26, 8, 2, 41, 232, DateTimeKind.Utc).AddTicks(3330), new DateTime(2024, 8, 26, 8, 2, 41, 232, DateTimeKind.Utc).AddTicks(3331), new DateTime(2024, 8, 26, 8, 2, 41, 232, DateTimeKind.Utc).AddTicks(3327) });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: 2055,
                columns: new[] { "ConcurrencyStamp", "CreatedTime", "LastUpdatedTime", "RefreshTokenCreateTime" },
                values: new object[] { "161210e1-73d7-4696-8be4-9a33733c2365", new DateTime(2024, 8, 26, 8, 2, 41, 232, DateTimeKind.Utc).AddTicks(3341), new DateTime(2024, 8, 26, 8, 2, 41, 232, DateTimeKind.Utc).AddTicks(3342), new DateTime(2024, 8, 26, 8, 2, 41, 232, DateTimeKind.Utc).AddTicks(3338) });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: 2056,
                columns: new[] { "ConcurrencyStamp", "CreatedTime", "LastUpdatedTime", "RefreshTokenCreateTime" },
                values: new object[] { "cd264ea6-c31e-4948-a1ea-dce62969e335", new DateTime(2024, 8, 26, 8, 2, 41, 232, DateTimeKind.Utc).AddTicks(3388), new DateTime(2024, 8, 26, 8, 2, 41, 232, DateTimeKind.Utc).AddTicks(3389), new DateTime(2024, 8, 26, 8, 2, 41, 232, DateTimeKind.Utc).AddTicks(3385) });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: 2057,
                columns: new[] { "ConcurrencyStamp", "CreatedTime", "LastUpdatedTime", "RefreshTokenCreateTime" },
                values: new object[] { "bfdb1f9c-c3cd-4a9a-ba0a-da2806cea88d", new DateTime(2024, 8, 26, 8, 2, 41, 232, DateTimeKind.Utc).AddTicks(3401), new DateTime(2024, 8, 26, 8, 2, 41, 232, DateTimeKind.Utc).AddTicks(3401), new DateTime(2024, 8, 26, 8, 2, 41, 232, DateTimeKind.Utc).AddTicks(3397) });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: 2058,
                columns: new[] { "ConcurrencyStamp", "CreatedTime", "LastUpdatedTime", "RefreshTokenCreateTime" },
                values: new object[] { "7181cc92-2898-4d65-b40b-fbde5c68d471", new DateTime(2024, 8, 26, 8, 2, 41, 232, DateTimeKind.Utc).AddTicks(3412), new DateTime(2024, 8, 26, 8, 2, 41, 232, DateTimeKind.Utc).AddTicks(3412), new DateTime(2024, 8, 26, 8, 2, 41, 232, DateTimeKind.Utc).AddTicks(3409) });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: 2059,
                columns: new[] { "ConcurrencyStamp", "CreatedTime", "LastUpdatedTime", "RefreshTokenCreateTime" },
                values: new object[] { "1c112ec5-5a6d-4faf-97e5-e35602dc7313", new DateTime(2024, 8, 26, 8, 2, 41, 232, DateTimeKind.Utc).AddTicks(3426), new DateTime(2024, 8, 26, 8, 2, 41, 232, DateTimeKind.Utc).AddTicks(3427), new DateTime(2024, 8, 26, 8, 2, 41, 232, DateTimeKind.Utc).AddTicks(3420) });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: 2060,
                columns: new[] { "ConcurrencyStamp", "CreatedTime", "LastUpdatedTime", "RefreshTokenCreateTime" },
                values: new object[] { "ffcdf433-68d6-40f7-a720-9bfbb042ebec", new DateTime(2024, 8, 26, 8, 2, 41, 232, DateTimeKind.Utc).AddTicks(3437), new DateTime(2024, 8, 26, 8, 2, 41, 232, DateTimeKind.Utc).AddTicks(3438), new DateTime(2024, 8, 26, 8, 2, 41, 232, DateTimeKind.Utc).AddTicks(3434) });

            migrationBuilder.UpdateData(
                table: "Breeds",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedTime",
                value: new DateTime(2024, 8, 26, 12, 2, 41, 221, DateTimeKind.Local).AddTicks(8275));

            migrationBuilder.UpdateData(
                table: "Breeds",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreatedTime",
                value: new DateTime(2024, 8, 26, 12, 2, 41, 221, DateTimeKind.Local).AddTicks(8284));

            migrationBuilder.UpdateData(
                table: "Breeds",
                keyColumn: "Id",
                keyValue: 3,
                column: "CreatedTime",
                value: new DateTime(2024, 8, 26, 12, 2, 41, 221, DateTimeKind.Local).AddTicks(8286));

            migrationBuilder.UpdateData(
                table: "Breeds",
                keyColumn: "Id",
                keyValue: 4,
                column: "CreatedTime",
                value: new DateTime(2024, 8, 26, 12, 2, 41, 221, DateTimeKind.Local).AddTicks(8287));

            migrationBuilder.UpdateData(
                table: "Breeds",
                keyColumn: "Id",
                keyValue: 5,
                column: "CreatedTime",
                value: new DateTime(2024, 8, 26, 12, 2, 41, 221, DateTimeKind.Local).AddTicks(8289));

            migrationBuilder.UpdateData(
                table: "Breeds",
                keyColumn: "Id",
                keyValue: 6,
                column: "CreatedTime",
                value: new DateTime(2024, 8, 26, 12, 2, 41, 221, DateTimeKind.Local).AddTicks(8290));

            migrationBuilder.UpdateData(
                table: "Breeds",
                keyColumn: "Id",
                keyValue: 7,
                column: "CreatedTime",
                value: new DateTime(2024, 8, 26, 12, 2, 41, 221, DateTimeKind.Local).AddTicks(8292));

            migrationBuilder.UpdateData(
                table: "Breeds",
                keyColumn: "Id",
                keyValue: 8,
                column: "CreatedTime",
                value: new DateTime(2024, 8, 26, 12, 2, 41, 221, DateTimeKind.Local).AddTicks(8293));

            migrationBuilder.UpdateData(
                table: "Breeds",
                keyColumn: "Id",
                keyValue: 9,
                column: "CreatedTime",
                value: new DateTime(2024, 8, 26, 12, 2, 41, 221, DateTimeKind.Local).AddTicks(8295));

            migrationBuilder.UpdateData(
                table: "Breeds",
                keyColumn: "Id",
                keyValue: 10,
                column: "CreatedTime",
                value: new DateTime(2024, 8, 26, 12, 2, 41, 221, DateTimeKind.Local).AddTicks(8296));

            migrationBuilder.UpdateData(
                table: "Breeds",
                keyColumn: "Id",
                keyValue: 11,
                column: "CreatedTime",
                value: new DateTime(2024, 8, 26, 12, 2, 41, 221, DateTimeKind.Local).AddTicks(8298));

            migrationBuilder.UpdateData(
                table: "Breeds",
                keyColumn: "Id",
                keyValue: 12,
                column: "CreatedTime",
                value: new DateTime(2024, 8, 26, 12, 2, 41, 221, DateTimeKind.Local).AddTicks(8299));

            migrationBuilder.UpdateData(
                table: "Breeds",
                keyColumn: "Id",
                keyValue: 13,
                column: "CreatedTime",
                value: new DateTime(2024, 8, 26, 12, 2, 41, 221, DateTimeKind.Local).AddTicks(8438));

            migrationBuilder.UpdateData(
                table: "Breeds",
                keyColumn: "Id",
                keyValue: 14,
                column: "CreatedTime",
                value: new DateTime(2024, 8, 26, 12, 2, 41, 221, DateTimeKind.Local).AddTicks(8440));

            migrationBuilder.UpdateData(
                table: "Breeds",
                keyColumn: "Id",
                keyValue: 15,
                column: "CreatedTime",
                value: new DateTime(2024, 8, 26, 12, 2, 41, 221, DateTimeKind.Local).AddTicks(8441));

            migrationBuilder.UpdateData(
                table: "Breeds",
                keyColumn: "Id",
                keyValue: 16,
                column: "CreatedTime",
                value: new DateTime(2024, 8, 26, 12, 2, 41, 221, DateTimeKind.Local).AddTicks(8443));

            migrationBuilder.UpdateData(
                table: "Breeds",
                keyColumn: "Id",
                keyValue: 17,
                column: "CreatedTime",
                value: new DateTime(2024, 8, 26, 12, 2, 41, 221, DateTimeKind.Local).AddTicks(8448));

            migrationBuilder.UpdateData(
                table: "Breeds",
                keyColumn: "Id",
                keyValue: 18,
                column: "CreatedTime",
                value: new DateTime(2024, 8, 26, 12, 2, 41, 221, DateTimeKind.Local).AddTicks(8450));

            migrationBuilder.UpdateData(
                table: "Breeds",
                keyColumn: "Id",
                keyValue: 19,
                column: "CreatedTime",
                value: new DateTime(2024, 8, 26, 12, 2, 41, 221, DateTimeKind.Local).AddTicks(8451));

            migrationBuilder.UpdateData(
                table: "Breeds",
                keyColumn: "Id",
                keyValue: 20,
                column: "CreatedTime",
                value: new DateTime(2024, 8, 26, 12, 2, 41, 221, DateTimeKind.Local).AddTicks(8452));

            migrationBuilder.UpdateData(
                table: "Breeds",
                keyColumn: "Id",
                keyValue: 21,
                column: "CreatedTime",
                value: new DateTime(2024, 8, 26, 12, 2, 41, 221, DateTimeKind.Local).AddTicks(8454));

            migrationBuilder.UpdateData(
                table: "Breeds",
                keyColumn: "Id",
                keyValue: 22,
                column: "CreatedTime",
                value: new DateTime(2024, 8, 26, 12, 2, 41, 221, DateTimeKind.Local).AddTicks(8455));

            migrationBuilder.UpdateData(
                table: "Breeds",
                keyColumn: "Id",
                keyValue: 23,
                column: "CreatedTime",
                value: new DateTime(2024, 8, 26, 12, 2, 41, 221, DateTimeKind.Local).AddTicks(8457));

            migrationBuilder.UpdateData(
                table: "Breeds",
                keyColumn: "Id",
                keyValue: 24,
                column: "CreatedTime",
                value: new DateTime(2024, 8, 26, 12, 2, 41, 221, DateTimeKind.Local).AddTicks(8458));

            migrationBuilder.UpdateData(
                table: "Breeds",
                keyColumn: "Id",
                keyValue: 25,
                column: "CreatedTime",
                value: new DateTime(2024, 8, 26, 12, 2, 41, 221, DateTimeKind.Local).AddTicks(8459));

            migrationBuilder.UpdateData(
                table: "Breeds",
                keyColumn: "Id",
                keyValue: 26,
                column: "CreatedTime",
                value: new DateTime(2024, 8, 26, 12, 2, 41, 221, DateTimeKind.Local).AddTicks(8461));

            migrationBuilder.UpdateData(
                table: "Breeds",
                keyColumn: "Id",
                keyValue: 27,
                column: "CreatedTime",
                value: new DateTime(2024, 8, 26, 12, 2, 41, 221, DateTimeKind.Local).AddTicks(8466));

            migrationBuilder.UpdateData(
                table: "Breeds",
                keyColumn: "Id",
                keyValue: 28,
                column: "CreatedTime",
                value: new DateTime(2024, 8, 26, 12, 2, 41, 221, DateTimeKind.Local).AddTicks(8467));

            migrationBuilder.UpdateData(
                table: "Breeds",
                keyColumn: "Id",
                keyValue: 29,
                column: "CreatedTime",
                value: new DateTime(2024, 8, 26, 12, 2, 41, 221, DateTimeKind.Local).AddTicks(8469));

            migrationBuilder.UpdateData(
                table: "Breeds",
                keyColumn: "Id",
                keyValue: 30,
                column: "CreatedTime",
                value: new DateTime(2024, 8, 26, 12, 2, 41, 221, DateTimeKind.Local).AddTicks(8470));

            migrationBuilder.UpdateData(
                table: "Breeds",
                keyColumn: "Id",
                keyValue: 31,
                column: "CreatedTime",
                value: new DateTime(2024, 8, 26, 12, 2, 41, 221, DateTimeKind.Local).AddTicks(8472));

            migrationBuilder.UpdateData(
                table: "Breeds",
                keyColumn: "Id",
                keyValue: 32,
                column: "CreatedTime",
                value: new DateTime(2024, 8, 26, 12, 2, 41, 221, DateTimeKind.Local).AddTicks(8473));

            migrationBuilder.UpdateData(
                table: "Breeds",
                keyColumn: "Id",
                keyValue: 33,
                column: "CreatedTime",
                value: new DateTime(2024, 8, 26, 12, 2, 41, 221, DateTimeKind.Local).AddTicks(8474));

            migrationBuilder.UpdateData(
                table: "Breeds",
                keyColumn: "Id",
                keyValue: 34,
                column: "CreatedTime",
                value: new DateTime(2024, 8, 26, 12, 2, 41, 221, DateTimeKind.Local).AddTicks(8476));

            migrationBuilder.UpdateData(
                table: "Breeds",
                keyColumn: "Id",
                keyValue: 35,
                column: "CreatedTime",
                value: new DateTime(2024, 8, 26, 12, 2, 41, 221, DateTimeKind.Local).AddTicks(8477));

            migrationBuilder.UpdateData(
                table: "Breeds",
                keyColumn: "Id",
                keyValue: 36,
                column: "CreatedTime",
                value: new DateTime(2024, 8, 26, 12, 2, 41, 221, DateTimeKind.Local).AddTicks(8479));

            migrationBuilder.UpdateData(
                table: "Breeds",
                keyColumn: "Id",
                keyValue: 37,
                column: "CreatedTime",
                value: new DateTime(2024, 8, 26, 12, 2, 41, 221, DateTimeKind.Local).AddTicks(8480));

            migrationBuilder.UpdateData(
                table: "Breeds",
                keyColumn: "Id",
                keyValue: 38,
                column: "CreatedTime",
                value: new DateTime(2024, 8, 26, 12, 2, 41, 221, DateTimeKind.Local).AddTicks(8482));

            migrationBuilder.UpdateData(
                table: "Breeds",
                keyColumn: "Id",
                keyValue: 39,
                column: "CreatedTime",
                value: new DateTime(2024, 8, 26, 12, 2, 41, 221, DateTimeKind.Local).AddTicks(8483));

            migrationBuilder.UpdateData(
                table: "Breeds",
                keyColumn: "Id",
                keyValue: 40,
                column: "CreatedTime",
                value: new DateTime(2024, 8, 26, 12, 2, 41, 221, DateTimeKind.Local).AddTicks(8485));

            migrationBuilder.UpdateData(
                table: "Breeds",
                keyColumn: "Id",
                keyValue: 41,
                column: "CreatedTime",
                value: new DateTime(2024, 8, 26, 12, 2, 41, 221, DateTimeKind.Local).AddTicks(8486));

            migrationBuilder.UpdateData(
                table: "Breeds",
                keyColumn: "Id",
                keyValue: 42,
                column: "CreatedTime",
                value: new DateTime(2024, 8, 26, 12, 2, 41, 221, DateTimeKind.Local).AddTicks(8487));

            migrationBuilder.UpdateData(
                table: "Breeds",
                keyColumn: "Id",
                keyValue: 43,
                column: "CreatedTime",
                value: new DateTime(2024, 8, 26, 12, 2, 41, 221, DateTimeKind.Local).AddTicks(8489));

            migrationBuilder.UpdateData(
                table: "Breeds",
                keyColumn: "Id",
                keyValue: 44,
                column: "CreatedTime",
                value: new DateTime(2024, 8, 26, 12, 2, 41, 221, DateTimeKind.Local).AddTicks(8490));

            migrationBuilder.UpdateData(
                table: "Breeds",
                keyColumn: "Id",
                keyValue: 45,
                column: "CreatedTime",
                value: new DateTime(2024, 8, 26, 12, 2, 41, 221, DateTimeKind.Local).AddTicks(8491));

            migrationBuilder.UpdateData(
                table: "Breeds",
                keyColumn: "Id",
                keyValue: 46,
                column: "CreatedTime",
                value: new DateTime(2024, 8, 26, 12, 2, 41, 221, DateTimeKind.Local).AddTicks(8494));

            migrationBuilder.UpdateData(
                table: "Breeds",
                keyColumn: "Id",
                keyValue: 47,
                column: "CreatedTime",
                value: new DateTime(2024, 8, 26, 12, 2, 41, 221, DateTimeKind.Local).AddTicks(8496));

            migrationBuilder.UpdateData(
                table: "Breeds",
                keyColumn: "Id",
                keyValue: 48,
                column: "CreatedTime",
                value: new DateTime(2024, 8, 26, 12, 2, 41, 221, DateTimeKind.Local).AddTicks(8497));

            migrationBuilder.UpdateData(
                table: "Breeds",
                keyColumn: "Id",
                keyValue: 49,
                column: "CreatedTime",
                value: new DateTime(2024, 8, 26, 12, 2, 41, 221, DateTimeKind.Local).AddTicks(8498));

            migrationBuilder.UpdateData(
                table: "Breeds",
                keyColumn: "Id",
                keyValue: 50,
                column: "CreatedTime",
                value: new DateTime(2024, 8, 26, 12, 2, 41, 221, DateTimeKind.Local).AddTicks(8499));

            migrationBuilder.UpdateData(
                table: "Breeds",
                keyColumn: "Id",
                keyValue: 51,
                column: "CreatedTime",
                value: new DateTime(2024, 8, 26, 12, 2, 41, 221, DateTimeKind.Local).AddTicks(8501));

            migrationBuilder.UpdateData(
                table: "Breeds",
                keyColumn: "Id",
                keyValue: 52,
                column: "CreatedTime",
                value: new DateTime(2024, 8, 26, 12, 2, 41, 221, DateTimeKind.Local).AddTicks(8502));

            migrationBuilder.UpdateData(
                table: "Breeds",
                keyColumn: "Id",
                keyValue: 53,
                column: "CreatedTime",
                value: new DateTime(2024, 8, 26, 12, 2, 41, 221, DateTimeKind.Local).AddTicks(8503));

            migrationBuilder.UpdateData(
                table: "Breeds",
                keyColumn: "Id",
                keyValue: 54,
                column: "CreatedTime",
                value: new DateTime(2024, 8, 26, 12, 2, 41, 221, DateTimeKind.Local).AddTicks(8507));

            migrationBuilder.UpdateData(
                table: "Breeds",
                keyColumn: "Id",
                keyValue: 55,
                column: "CreatedTime",
                value: new DateTime(2024, 8, 26, 12, 2, 41, 221, DateTimeKind.Local).AddTicks(8508));

            migrationBuilder.UpdateData(
                table: "Breeds",
                keyColumn: "Id",
                keyValue: 56,
                column: "CreatedTime",
                value: new DateTime(2024, 8, 26, 12, 2, 41, 221, DateTimeKind.Local).AddTicks(8510));

            migrationBuilder.UpdateData(
                table: "Breeds",
                keyColumn: "Id",
                keyValue: 57,
                column: "CreatedTime",
                value: new DateTime(2024, 8, 26, 12, 2, 41, 221, DateTimeKind.Local).AddTicks(8511));

            migrationBuilder.UpdateData(
                table: "Breeds",
                keyColumn: "Id",
                keyValue: 58,
                column: "CreatedTime",
                value: new DateTime(2024, 8, 26, 12, 2, 41, 221, DateTimeKind.Local).AddTicks(8512));

            migrationBuilder.UpdateData(
                table: "Breeds",
                keyColumn: "Id",
                keyValue: 59,
                column: "CreatedTime",
                value: new DateTime(2024, 8, 26, 12, 2, 41, 221, DateTimeKind.Local).AddTicks(8514));

            migrationBuilder.UpdateData(
                table: "Breeds",
                keyColumn: "Id",
                keyValue: 60,
                column: "CreatedTime",
                value: new DateTime(2024, 8, 26, 12, 2, 41, 221, DateTimeKind.Local).AddTicks(8515));

            migrationBuilder.UpdateData(
                table: "Breeds",
                keyColumn: "Id",
                keyValue: 61,
                column: "CreatedTime",
                value: new DateTime(2024, 8, 26, 12, 2, 41, 221, DateTimeKind.Local).AddTicks(8516));

            migrationBuilder.UpdateData(
                table: "Breeds",
                keyColumn: "Id",
                keyValue: 62,
                column: "CreatedTime",
                value: new DateTime(2024, 8, 26, 12, 2, 41, 221, DateTimeKind.Local).AddTicks(8518));

            migrationBuilder.UpdateData(
                table: "Breeds",
                keyColumn: "Id",
                keyValue: 63,
                column: "CreatedTime",
                value: new DateTime(2024, 8, 26, 12, 2, 41, 221, DateTimeKind.Local).AddTicks(8519));

            migrationBuilder.UpdateData(
                table: "Breeds",
                keyColumn: "Id",
                keyValue: 64,
                column: "CreatedTime",
                value: new DateTime(2024, 8, 26, 12, 2, 41, 221, DateTimeKind.Local).AddTicks(8520));

            migrationBuilder.UpdateData(
                table: "Breeds",
                keyColumn: "Id",
                keyValue: 65,
                column: "CreatedTime",
                value: new DateTime(2024, 8, 26, 12, 2, 41, 221, DateTimeKind.Local).AddTicks(8522));

            migrationBuilder.UpdateData(
                table: "Breeds",
                keyColumn: "Id",
                keyValue: 66,
                column: "CreatedTime",
                value: new DateTime(2024, 8, 26, 12, 2, 41, 221, DateTimeKind.Local).AddTicks(8523));

            migrationBuilder.UpdateData(
                table: "Breeds",
                keyColumn: "Id",
                keyValue: 67,
                column: "CreatedTime",
                value: new DateTime(2024, 8, 26, 12, 2, 41, 221, DateTimeKind.Local).AddTicks(8524));

            migrationBuilder.UpdateData(
                table: "Breeds",
                keyColumn: "Id",
                keyValue: 68,
                column: "CreatedTime",
                value: new DateTime(2024, 8, 26, 12, 2, 41, 221, DateTimeKind.Local).AddTicks(8526));

            migrationBuilder.UpdateData(
                table: "Breeds",
                keyColumn: "Id",
                keyValue: 69,
                column: "CreatedTime",
                value: new DateTime(2024, 8, 26, 12, 2, 41, 221, DateTimeKind.Local).AddTicks(8527));

            migrationBuilder.UpdateData(
                table: "Breeds",
                keyColumn: "Id",
                keyValue: 70,
                column: "CreatedTime",
                value: new DateTime(2024, 8, 26, 12, 2, 41, 221, DateTimeKind.Local).AddTicks(8528));

            migrationBuilder.UpdateData(
                table: "Breeds",
                keyColumn: "Id",
                keyValue: 71,
                column: "CreatedTime",
                value: new DateTime(2024, 8, 26, 12, 2, 41, 221, DateTimeKind.Local).AddTicks(8530));

            migrationBuilder.UpdateData(
                table: "Breeds",
                keyColumn: "Id",
                keyValue: 72,
                column: "CreatedTime",
                value: new DateTime(2024, 8, 26, 12, 2, 41, 221, DateTimeKind.Local).AddTicks(8531));

            migrationBuilder.UpdateData(
                table: "Breeds",
                keyColumn: "Id",
                keyValue: 73,
                column: "CreatedTime",
                value: new DateTime(2024, 8, 26, 12, 2, 41, 221, DateTimeKind.Local).AddTicks(8532));

            migrationBuilder.UpdateData(
                table: "Breeds",
                keyColumn: "Id",
                keyValue: 74,
                column: "CreatedTime",
                value: new DateTime(2024, 8, 26, 12, 2, 41, 221, DateTimeKind.Local).AddTicks(8533));

            migrationBuilder.UpdateData(
                table: "Breeds",
                keyColumn: "Id",
                keyValue: 75,
                column: "CreatedTime",
                value: new DateTime(2024, 8, 26, 12, 2, 41, 221, DateTimeKind.Local).AddTicks(8538));

            migrationBuilder.UpdateData(
                table: "Breeds",
                keyColumn: "Id",
                keyValue: 76,
                column: "CreatedTime",
                value: new DateTime(2024, 8, 26, 12, 2, 41, 221, DateTimeKind.Local).AddTicks(8540));

            migrationBuilder.UpdateData(
                table: "Breeds",
                keyColumn: "Id",
                keyValue: 77,
                column: "CreatedTime",
                value: new DateTime(2024, 8, 26, 12, 2, 41, 221, DateTimeKind.Local).AddTicks(8541));

            migrationBuilder.UpdateData(
                table: "Breeds",
                keyColumn: "Id",
                keyValue: 78,
                column: "CreatedTime",
                value: new DateTime(2024, 8, 26, 12, 2, 41, 221, DateTimeKind.Local).AddTicks(8542));

            migrationBuilder.UpdateData(
                table: "Breeds",
                keyColumn: "Id",
                keyValue: 79,
                column: "CreatedTime",
                value: new DateTime(2024, 8, 26, 12, 2, 41, 221, DateTimeKind.Local).AddTicks(8544));

            migrationBuilder.UpdateData(
                table: "Breeds",
                keyColumn: "Id",
                keyValue: 80,
                column: "CreatedTime",
                value: new DateTime(2024, 8, 26, 12, 2, 41, 221, DateTimeKind.Local).AddTicks(8545));

            migrationBuilder.UpdateData(
                table: "Breeds",
                keyColumn: "Id",
                keyValue: 81,
                column: "CreatedTime",
                value: new DateTime(2024, 8, 26, 12, 2, 41, 221, DateTimeKind.Local).AddTicks(8546));

            migrationBuilder.UpdateData(
                table: "Breeds",
                keyColumn: "Id",
                keyValue: 82,
                column: "CreatedTime",
                value: new DateTime(2024, 8, 26, 12, 2, 41, 221, DateTimeKind.Local).AddTicks(8547));

            migrationBuilder.UpdateData(
                table: "Breeds",
                keyColumn: "Id",
                keyValue: 83,
                column: "CreatedTime",
                value: new DateTime(2024, 8, 26, 12, 2, 41, 221, DateTimeKind.Local).AddTicks(8549));

            migrationBuilder.UpdateData(
                table: "Breeds",
                keyColumn: "Id",
                keyValue: 84,
                column: "CreatedTime",
                value: new DateTime(2024, 8, 26, 12, 2, 41, 221, DateTimeKind.Local).AddTicks(8550));

            migrationBuilder.UpdateData(
                table: "Breeds",
                keyColumn: "Id",
                keyValue: 85,
                column: "CreatedTime",
                value: new DateTime(2024, 8, 26, 12, 2, 41, 221, DateTimeKind.Local).AddTicks(8551));

            migrationBuilder.UpdateData(
                table: "Breeds",
                keyColumn: "Id",
                keyValue: 86,
                column: "CreatedTime",
                value: new DateTime(2024, 8, 26, 12, 2, 41, 221, DateTimeKind.Local).AddTicks(8552));

            migrationBuilder.UpdateData(
                table: "Breeds",
                keyColumn: "Id",
                keyValue: 87,
                column: "CreatedTime",
                value: new DateTime(2024, 8, 26, 12, 2, 41, 221, DateTimeKind.Local).AddTicks(8554));

            migrationBuilder.UpdateData(
                table: "Breeds",
                keyColumn: "Id",
                keyValue: 88,
                column: "CreatedTime",
                value: new DateTime(2024, 8, 26, 12, 2, 41, 221, DateTimeKind.Local).AddTicks(8555));

            migrationBuilder.UpdateData(
                table: "Breeds",
                keyColumn: "Id",
                keyValue: 89,
                column: "CreatedTime",
                value: new DateTime(2024, 8, 26, 12, 2, 41, 221, DateTimeKind.Local).AddTicks(8556));

            migrationBuilder.UpdateData(
                table: "Breeds",
                keyColumn: "Id",
                keyValue: 90,
                column: "CreatedTime",
                value: new DateTime(2024, 8, 26, 12, 2, 41, 221, DateTimeKind.Local).AddTicks(8558));

            migrationBuilder.UpdateData(
                table: "Breeds",
                keyColumn: "Id",
                keyValue: 91,
                column: "CreatedTime",
                value: new DateTime(2024, 8, 26, 12, 2, 41, 221, DateTimeKind.Local).AddTicks(8559));

            migrationBuilder.UpdateData(
                table: "Breeds",
                keyColumn: "Id",
                keyValue: 92,
                column: "CreatedTime",
                value: new DateTime(2024, 8, 26, 12, 2, 41, 221, DateTimeKind.Local).AddTicks(8560));

            migrationBuilder.UpdateData(
                table: "Breeds",
                keyColumn: "Id",
                keyValue: 93,
                column: "CreatedTime",
                value: new DateTime(2024, 8, 26, 12, 2, 41, 221, DateTimeKind.Local).AddTicks(8561));

            migrationBuilder.UpdateData(
                table: "Breeds",
                keyColumn: "Id",
                keyValue: 94,
                column: "CreatedTime",
                value: new DateTime(2024, 8, 26, 12, 2, 41, 221, DateTimeKind.Local).AddTicks(8563));

            migrationBuilder.UpdateData(
                table: "Breeds",
                keyColumn: "Id",
                keyValue: 95,
                column: "CreatedTime",
                value: new DateTime(2024, 8, 26, 12, 2, 41, 221, DateTimeKind.Local).AddTicks(8564));

            migrationBuilder.UpdateData(
                table: "Breeds",
                keyColumn: "Id",
                keyValue: 96,
                column: "CreatedTime",
                value: new DateTime(2024, 8, 26, 12, 2, 41, 221, DateTimeKind.Local).AddTicks(8565));

            migrationBuilder.UpdateData(
                table: "Breeds",
                keyColumn: "Id",
                keyValue: 97,
                column: "CreatedTime",
                value: new DateTime(2024, 8, 26, 12, 2, 41, 221, DateTimeKind.Local).AddTicks(8567));

            migrationBuilder.UpdateData(
                table: "Breeds",
                keyColumn: "Id",
                keyValue: 98,
                column: "CreatedTime",
                value: new DateTime(2024, 8, 26, 12, 2, 41, 221, DateTimeKind.Local).AddTicks(8568));

            migrationBuilder.UpdateData(
                table: "Breeds",
                keyColumn: "Id",
                keyValue: 99,
                column: "CreatedTime",
                value: new DateTime(2024, 8, 26, 12, 2, 41, 221, DateTimeKind.Local).AddTicks(8569));

            migrationBuilder.UpdateData(
                table: "Breeds",
                keyColumn: "Id",
                keyValue: 100,
                column: "CreatedTime",
                value: new DateTime(2024, 8, 26, 12, 2, 41, 221, DateTimeKind.Local).AddTicks(8570));

            migrationBuilder.UpdateData(
                table: "Breeds",
                keyColumn: "Id",
                keyValue: 101,
                column: "CreatedTime",
                value: new DateTime(2024, 8, 26, 12, 2, 41, 221, DateTimeKind.Local).AddTicks(8572));

            migrationBuilder.UpdateData(
                table: "Breeds",
                keyColumn: "Id",
                keyValue: 102,
                column: "CreatedTime",
                value: new DateTime(2024, 8, 26, 12, 2, 41, 221, DateTimeKind.Local).AddTicks(8573));

            migrationBuilder.UpdateData(
                table: "Breeds",
                keyColumn: "Id",
                keyValue: 103,
                column: "CreatedTime",
                value: new DateTime(2024, 8, 26, 12, 2, 41, 221, DateTimeKind.Local).AddTicks(8575));

            migrationBuilder.UpdateData(
                table: "Breeds",
                keyColumn: "Id",
                keyValue: 104,
                column: "CreatedTime",
                value: new DateTime(2024, 8, 26, 12, 2, 41, 221, DateTimeKind.Local).AddTicks(8576));

            migrationBuilder.UpdateData(
                table: "Breeds",
                keyColumn: "Id",
                keyValue: 105,
                column: "CreatedTime",
                value: new DateTime(2024, 8, 26, 12, 2, 41, 221, DateTimeKind.Local).AddTicks(8577));

            migrationBuilder.UpdateData(
                table: "Breeds",
                keyColumn: "Id",
                keyValue: 106,
                column: "CreatedTime",
                value: new DateTime(2024, 8, 26, 12, 2, 41, 221, DateTimeKind.Local).AddTicks(8579));

            migrationBuilder.UpdateData(
                table: "Breeds",
                keyColumn: "Id",
                keyValue: 107,
                column: "CreatedTime",
                value: new DateTime(2024, 8, 26, 12, 2, 41, 221, DateTimeKind.Local).AddTicks(8580));

            migrationBuilder.UpdateData(
                table: "Breeds",
                keyColumn: "Id",
                keyValue: 108,
                column: "CreatedTime",
                value: new DateTime(2024, 8, 26, 12, 2, 41, 221, DateTimeKind.Local).AddTicks(8581));

            migrationBuilder.UpdateData(
                table: "Breeds",
                keyColumn: "Id",
                keyValue: 109,
                column: "CreatedTime",
                value: new DateTime(2024, 8, 26, 12, 2, 41, 221, DateTimeKind.Local).AddTicks(8582));

            migrationBuilder.UpdateData(
                table: "Breeds",
                keyColumn: "Id",
                keyValue: 110,
                column: "CreatedTime",
                value: new DateTime(2024, 8, 26, 12, 2, 41, 221, DateTimeKind.Local).AddTicks(8583));

            migrationBuilder.UpdateData(
                table: "Breeds",
                keyColumn: "Id",
                keyValue: 111,
                column: "CreatedTime",
                value: new DateTime(2024, 8, 26, 12, 2, 41, 221, DateTimeKind.Local).AddTicks(8585));

            migrationBuilder.UpdateData(
                table: "Breeds",
                keyColumn: "Id",
                keyValue: 112,
                column: "CreatedTime",
                value: new DateTime(2024, 8, 26, 12, 2, 41, 221, DateTimeKind.Local).AddTicks(8586));

            migrationBuilder.UpdateData(
                table: "Breeds",
                keyColumn: "Id",
                keyValue: 113,
                column: "CreatedTime",
                value: new DateTime(2024, 8, 26, 12, 2, 41, 221, DateTimeKind.Local).AddTicks(8588));

            migrationBuilder.UpdateData(
                table: "Breeds",
                keyColumn: "Id",
                keyValue: 114,
                column: "CreatedTime",
                value: new DateTime(2024, 8, 26, 12, 2, 41, 221, DateTimeKind.Local).AddTicks(8589));

            migrationBuilder.UpdateData(
                table: "Breeds",
                keyColumn: "Id",
                keyValue: 115,
                column: "CreatedTime",
                value: new DateTime(2024, 8, 26, 12, 2, 41, 221, DateTimeKind.Local).AddTicks(8590));

            migrationBuilder.UpdateData(
                table: "Breeds",
                keyColumn: "Id",
                keyValue: 116,
                column: "CreatedTime",
                value: new DateTime(2024, 8, 26, 12, 2, 41, 221, DateTimeKind.Local).AddTicks(8591));

            migrationBuilder.UpdateData(
                table: "Breeds",
                keyColumn: "Id",
                keyValue: 117,
                column: "CreatedTime",
                value: new DateTime(2024, 8, 26, 12, 2, 41, 221, DateTimeKind.Local).AddTicks(8593));

            migrationBuilder.UpdateData(
                table: "Breeds",
                keyColumn: "Id",
                keyValue: 118,
                column: "CreatedTime",
                value: new DateTime(2024, 8, 26, 12, 2, 41, 221, DateTimeKind.Local).AddTicks(8595));

            migrationBuilder.UpdateData(
                table: "Breeds",
                keyColumn: "Id",
                keyValue: 119,
                column: "CreatedTime",
                value: new DateTime(2024, 8, 26, 12, 2, 41, 221, DateTimeKind.Local).AddTicks(8597));

            migrationBuilder.UpdateData(
                table: "Breeds",
                keyColumn: "Id",
                keyValue: 120,
                column: "CreatedTime",
                value: new DateTime(2024, 8, 26, 12, 2, 41, 221, DateTimeKind.Local).AddTicks(8598));

            migrationBuilder.UpdateData(
                table: "Breeds",
                keyColumn: "Id",
                keyValue: 121,
                column: "CreatedTime",
                value: new DateTime(2024, 8, 26, 12, 2, 41, 221, DateTimeKind.Local).AddTicks(8599));

            migrationBuilder.UpdateData(
                table: "Breeds",
                keyColumn: "Id",
                keyValue: 122,
                column: "CreatedTime",
                value: new DateTime(2024, 8, 26, 12, 2, 41, 221, DateTimeKind.Local).AddTicks(8600));

            migrationBuilder.UpdateData(
                table: "Breeds",
                keyColumn: "Id",
                keyValue: 123,
                column: "CreatedTime",
                value: new DateTime(2024, 8, 26, 12, 2, 41, 221, DateTimeKind.Local).AddTicks(8602));

            migrationBuilder.UpdateData(
                table: "Breeds",
                keyColumn: "Id",
                keyValue: 124,
                column: "CreatedTime",
                value: new DateTime(2024, 8, 26, 12, 2, 41, 221, DateTimeKind.Local).AddTicks(8604));

            migrationBuilder.UpdateData(
                table: "Breeds",
                keyColumn: "Id",
                keyValue: 125,
                column: "CreatedTime",
                value: new DateTime(2024, 8, 26, 12, 2, 41, 221, DateTimeKind.Local).AddTicks(8605));

            migrationBuilder.UpdateData(
                table: "Breeds",
                keyColumn: "Id",
                keyValue: 126,
                column: "CreatedTime",
                value: new DateTime(2024, 8, 26, 12, 2, 41, 221, DateTimeKind.Local).AddTicks(8606));

            migrationBuilder.UpdateData(
                table: "Breeds",
                keyColumn: "Id",
                keyValue: 127,
                column: "CreatedTime",
                value: new DateTime(2024, 8, 26, 12, 2, 41, 221, DateTimeKind.Local).AddTicks(8607));

            migrationBuilder.UpdateData(
                table: "Breeds",
                keyColumn: "Id",
                keyValue: 128,
                column: "CreatedTime",
                value: new DateTime(2024, 8, 26, 12, 2, 41, 221, DateTimeKind.Local).AddTicks(8609));

            migrationBuilder.UpdateData(
                table: "Breeds",
                keyColumn: "Id",
                keyValue: 129,
                column: "CreatedTime",
                value: new DateTime(2024, 8, 26, 12, 2, 41, 221, DateTimeKind.Local).AddTicks(8611));

            migrationBuilder.UpdateData(
                table: "Breeds",
                keyColumn: "Id",
                keyValue: 130,
                column: "CreatedTime",
                value: new DateTime(2024, 8, 26, 12, 2, 41, 221, DateTimeKind.Local).AddTicks(8612));

            migrationBuilder.UpdateData(
                table: "Breeds",
                keyColumn: "Id",
                keyValue: 131,
                column: "CreatedTime",
                value: new DateTime(2024, 8, 26, 12, 2, 41, 221, DateTimeKind.Local).AddTicks(8613));

            migrationBuilder.UpdateData(
                table: "Breeds",
                keyColumn: "Id",
                keyValue: 132,
                column: "CreatedTime",
                value: new DateTime(2024, 8, 26, 12, 2, 41, 221, DateTimeKind.Local).AddTicks(8614));

            migrationBuilder.UpdateData(
                table: "Breeds",
                keyColumn: "Id",
                keyValue: 133,
                column: "CreatedTime",
                value: new DateTime(2024, 8, 26, 12, 2, 41, 221, DateTimeKind.Local).AddTicks(8616));

            migrationBuilder.UpdateData(
                table: "Breeds",
                keyColumn: "Id",
                keyValue: 134,
                column: "CreatedTime",
                value: new DateTime(2024, 8, 26, 12, 2, 41, 221, DateTimeKind.Local).AddTicks(8617));

            migrationBuilder.UpdateData(
                table: "Breeds",
                keyColumn: "Id",
                keyValue: 135,
                column: "CreatedTime",
                value: new DateTime(2024, 8, 26, 12, 2, 41, 221, DateTimeKind.Local).AddTicks(8618));

            migrationBuilder.UpdateData(
                table: "Breeds",
                keyColumn: "Id",
                keyValue: 136,
                column: "CreatedTime",
                value: new DateTime(2024, 8, 26, 12, 2, 41, 221, DateTimeKind.Local).AddTicks(8620));

            migrationBuilder.UpdateData(
                table: "Breeds",
                keyColumn: "Id",
                keyValue: 137,
                column: "CreatedTime",
                value: new DateTime(2024, 8, 26, 12, 2, 41, 221, DateTimeKind.Local).AddTicks(8621));

            migrationBuilder.UpdateData(
                table: "Breeds",
                keyColumn: "Id",
                keyValue: 138,
                column: "CreatedTime",
                value: new DateTime(2024, 8, 26, 12, 2, 41, 221, DateTimeKind.Local).AddTicks(8622));

            migrationBuilder.UpdateData(
                table: "Breeds",
                keyColumn: "Id",
                keyValue: 139,
                column: "CreatedTime",
                value: new DateTime(2024, 8, 26, 12, 2, 41, 221, DateTimeKind.Local).AddTicks(8623));

            migrationBuilder.UpdateData(
                table: "Breeds",
                keyColumn: "Id",
                keyValue: 140,
                column: "CreatedTime",
                value: new DateTime(2024, 8, 26, 12, 2, 41, 221, DateTimeKind.Local).AddTicks(8625));

            migrationBuilder.UpdateData(
                table: "Breeds",
                keyColumn: "Id",
                keyValue: 141,
                column: "CreatedTime",
                value: new DateTime(2024, 8, 26, 12, 2, 41, 221, DateTimeKind.Local).AddTicks(8626));

            migrationBuilder.UpdateData(
                table: "Breeds",
                keyColumn: "Id",
                keyValue: 142,
                column: "CreatedTime",
                value: new DateTime(2024, 8, 26, 12, 2, 41, 221, DateTimeKind.Local).AddTicks(8684));

            migrationBuilder.UpdateData(
                table: "Breeds",
                keyColumn: "Id",
                keyValue: 143,
                column: "CreatedTime",
                value: new DateTime(2024, 8, 26, 12, 2, 41, 221, DateTimeKind.Local).AddTicks(8685));

            migrationBuilder.UpdateData(
                table: "Breeds",
                keyColumn: "Id",
                keyValue: 144,
                column: "CreatedTime",
                value: new DateTime(2024, 8, 26, 12, 2, 41, 221, DateTimeKind.Local).AddTicks(8687));

            migrationBuilder.UpdateData(
                table: "Breeds",
                keyColumn: "Id",
                keyValue: 145,
                column: "CreatedTime",
                value: new DateTime(2024, 8, 26, 12, 2, 41, 221, DateTimeKind.Local).AddTicks(8688));

            migrationBuilder.UpdateData(
                table: "Breeds",
                keyColumn: "Id",
                keyValue: 146,
                column: "CreatedTime",
                value: new DateTime(2024, 8, 26, 12, 2, 41, 221, DateTimeKind.Local).AddTicks(8690));

            migrationBuilder.UpdateData(
                table: "Breeds",
                keyColumn: "Id",
                keyValue: 147,
                column: "CreatedTime",
                value: new DateTime(2024, 8, 26, 12, 2, 41, 221, DateTimeKind.Local).AddTicks(8691));

            migrationBuilder.UpdateData(
                table: "Breeds",
                keyColumn: "Id",
                keyValue: 148,
                column: "CreatedTime",
                value: new DateTime(2024, 8, 26, 12, 2, 41, 221, DateTimeKind.Local).AddTicks(8693));

            migrationBuilder.UpdateData(
                table: "Breeds",
                keyColumn: "Id",
                keyValue: 149,
                column: "CreatedTime",
                value: new DateTime(2024, 8, 26, 12, 2, 41, 221, DateTimeKind.Local).AddTicks(8694));

            migrationBuilder.UpdateData(
                table: "Breeds",
                keyColumn: "Id",
                keyValue: 150,
                column: "CreatedTime",
                value: new DateTime(2024, 8, 26, 12, 2, 41, 221, DateTimeKind.Local).AddTicks(8695));

            migrationBuilder.UpdateData(
                table: "Breeds",
                keyColumn: "Id",
                keyValue: 151,
                column: "CreatedTime",
                value: new DateTime(2024, 8, 26, 12, 2, 41, 221, DateTimeKind.Local).AddTicks(8697));

            migrationBuilder.UpdateData(
                table: "Breeds",
                keyColumn: "Id",
                keyValue: 152,
                column: "CreatedTime",
                value: new DateTime(2024, 8, 26, 12, 2, 41, 221, DateTimeKind.Local).AddTicks(8698));

            migrationBuilder.UpdateData(
                table: "Breeds",
                keyColumn: "Id",
                keyValue: 153,
                column: "CreatedTime",
                value: new DateTime(2024, 8, 26, 12, 2, 41, 221, DateTimeKind.Local).AddTicks(8699));

            migrationBuilder.UpdateData(
                table: "Breeds",
                keyColumn: "Id",
                keyValue: 154,
                column: "CreatedTime",
                value: new DateTime(2024, 8, 26, 12, 2, 41, 221, DateTimeKind.Local).AddTicks(8701));

            migrationBuilder.UpdateData(
                table: "Breeds",
                keyColumn: "Id",
                keyValue: 155,
                column: "CreatedTime",
                value: new DateTime(2024, 8, 26, 12, 2, 41, 221, DateTimeKind.Local).AddTicks(8702));

            migrationBuilder.UpdateData(
                table: "Breeds",
                keyColumn: "Id",
                keyValue: 156,
                column: "CreatedTime",
                value: new DateTime(2024, 8, 26, 12, 2, 41, 221, DateTimeKind.Local).AddTicks(8703));

            migrationBuilder.UpdateData(
                table: "Breeds",
                keyColumn: "Id",
                keyValue: 157,
                column: "CreatedTime",
                value: new DateTime(2024, 8, 26, 12, 2, 41, 221, DateTimeKind.Local).AddTicks(8704));

            migrationBuilder.UpdateData(
                table: "Breeds",
                keyColumn: "Id",
                keyValue: 158,
                column: "CreatedTime",
                value: new DateTime(2024, 8, 26, 12, 2, 41, 221, DateTimeKind.Local).AddTicks(8706));

            migrationBuilder.UpdateData(
                table: "Breeds",
                keyColumn: "Id",
                keyValue: 159,
                column: "CreatedTime",
                value: new DateTime(2024, 8, 26, 12, 2, 41, 221, DateTimeKind.Local).AddTicks(8707));

            migrationBuilder.UpdateData(
                table: "Breeds",
                keyColumn: "Id",
                keyValue: 160,
                column: "CreatedTime",
                value: new DateTime(2024, 8, 26, 12, 2, 41, 221, DateTimeKind.Local).AddTicks(8708));

            migrationBuilder.UpdateData(
                table: "PetTypes",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedTime",
                value: new DateTime(2024, 8, 26, 12, 2, 41, 221, DateTimeKind.Local).AddTicks(5418));

            migrationBuilder.UpdateData(
                table: "PetTypes",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreatedTime",
                value: new DateTime(2024, 8, 26, 12, 2, 41, 221, DateTimeKind.Local).AddTicks(5423));

            migrationBuilder.UpdateData(
                table: "PetTypes",
                keyColumn: "Id",
                keyValue: 3,
                column: "CreatedTime",
                value: new DateTime(2024, 8, 26, 12, 2, 41, 221, DateTimeKind.Local).AddTicks(5425));

            migrationBuilder.UpdateData(
                table: "PetTypes",
                keyColumn: "Id",
                keyValue: 4,
                column: "CreatedTime",
                value: new DateTime(2024, 8, 26, 12, 2, 41, 221, DateTimeKind.Local).AddTicks(5426));

            migrationBuilder.UpdateData(
                table: "PetTypes",
                keyColumn: "Id",
                keyValue: 5,
                column: "CreatedTime",
                value: new DateTime(2024, 8, 26, 12, 2, 41, 221, DateTimeKind.Local).AddTicks(5428));

            migrationBuilder.UpdateData(
                table: "PetTypes",
                keyColumn: "Id",
                keyValue: 6,
                column: "CreatedTime",
                value: new DateTime(2024, 8, 26, 12, 2, 41, 221, DateTimeKind.Local).AddTicks(5429));

            migrationBuilder.UpdateData(
                table: "PetTypes",
                keyColumn: "Id",
                keyValue: 7,
                column: "CreatedTime",
                value: new DateTime(2024, 8, 26, 12, 2, 41, 221, DateTimeKind.Local).AddTicks(5430));

            migrationBuilder.UpdateData(
                table: "PetTypes",
                keyColumn: "Id",
                keyValue: 8,
                column: "CreatedTime",
                value: new DateTime(2024, 8, 26, 12, 2, 41, 221, DateTimeKind.Local).AddTicks(5431));

            migrationBuilder.UpdateData(
                table: "Pets",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CreatedTime", "PetTypeId" },
                values: new object[] { new DateTime(2024, 8, 26, 12, 2, 41, 233, DateTimeKind.Local).AddTicks(780), 1 });

            migrationBuilder.UpdateData(
                table: "Pets",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreatedTime",
                value: new DateTime(2024, 8, 26, 12, 2, 41, 233, DateTimeKind.Local).AddTicks(805));

            migrationBuilder.UpdateData(
                table: "Pets",
                keyColumn: "Id",
                keyValue: 3,
                column: "CreatedTime",
                value: new DateTime(2024, 8, 26, 12, 2, 41, 233, DateTimeKind.Local).AddTicks(811));

            migrationBuilder.UpdateData(
                table: "Pets",
                keyColumn: "Id",
                keyValue: 4,
                column: "CreatedTime",
                value: new DateTime(2024, 8, 26, 12, 2, 41, 233, DateTimeKind.Local).AddTicks(815));

            migrationBuilder.UpdateData(
                table: "Pets",
                keyColumn: "Id",
                keyValue: 5,
                column: "CreatedTime",
                value: new DateTime(2024, 8, 26, 12, 2, 41, 233, DateTimeKind.Local).AddTicks(820));

            migrationBuilder.UpdateData(
                table: "Pets",
                keyColumn: "Id",
                keyValue: 6,
                column: "CreatedTime",
                value: new DateTime(2024, 8, 26, 12, 2, 41, 233, DateTimeKind.Local).AddTicks(824));

            migrationBuilder.UpdateData(
                table: "Pets",
                keyColumn: "Id",
                keyValue: 7,
                column: "CreatedTime",
                value: new DateTime(2024, 8, 26, 12, 2, 41, 233, DateTimeKind.Local).AddTicks(828));

            migrationBuilder.UpdateData(
                table: "Pets",
                keyColumn: "Id",
                keyValue: 8,
                column: "CreatedTime",
                value: new DateTime(2024, 8, 26, 12, 2, 41, 233, DateTimeKind.Local).AddTicks(833));

            migrationBuilder.UpdateData(
                table: "Pets",
                keyColumn: "Id",
                keyValue: 9,
                column: "CreatedTime",
                value: new DateTime(2024, 8, 26, 12, 2, 41, 233, DateTimeKind.Local).AddTicks(837));

            migrationBuilder.UpdateData(
                table: "Pets",
                keyColumn: "Id",
                keyValue: 10,
                column: "CreatedTime",
                value: new DateTime(2024, 8, 26, 12, 2, 41, 233, DateTimeKind.Local).AddTicks(842));

            migrationBuilder.UpdateData(
                table: "Pets",
                keyColumn: "Id",
                keyValue: 11,
                column: "CreatedTime",
                value: new DateTime(2024, 8, 26, 12, 2, 41, 233, DateTimeKind.Local).AddTicks(846));

            migrationBuilder.UpdateData(
                table: "Pets",
                keyColumn: "Id",
                keyValue: 12,
                column: "CreatedTime",
                value: new DateTime(2024, 8, 26, 12, 2, 41, 233, DateTimeKind.Local).AddTicks(851));

            migrationBuilder.UpdateData(
                table: "Pets",
                keyColumn: "Id",
                keyValue: 13,
                column: "CreatedTime",
                value: new DateTime(2024, 8, 26, 12, 2, 41, 233, DateTimeKind.Local).AddTicks(854));

            migrationBuilder.UpdateData(
                table: "Pets",
                keyColumn: "Id",
                keyValue: 14,
                column: "CreatedTime",
                value: new DateTime(2024, 8, 26, 12, 2, 41, 233, DateTimeKind.Local).AddTicks(908));

            migrationBuilder.UpdateData(
                table: "Pets",
                keyColumn: "Id",
                keyValue: 15,
                column: "CreatedTime",
                value: new DateTime(2024, 8, 26, 12, 2, 41, 233, DateTimeKind.Local).AddTicks(914));

            migrationBuilder.UpdateData(
                table: "Pets",
                keyColumn: "Id",
                keyValue: 16,
                column: "CreatedTime",
                value: new DateTime(2024, 8, 26, 12, 2, 41, 233, DateTimeKind.Local).AddTicks(919));

            migrationBuilder.UpdateData(
                table: "Pets",
                keyColumn: "Id",
                keyValue: 17,
                column: "CreatedTime",
                value: new DateTime(2024, 8, 26, 12, 2, 41, 233, DateTimeKind.Local).AddTicks(923));

            migrationBuilder.UpdateData(
                table: "Pets",
                keyColumn: "Id",
                keyValue: 18,
                column: "CreatedTime",
                value: new DateTime(2024, 8, 26, 12, 2, 41, 233, DateTimeKind.Local).AddTicks(927));

            migrationBuilder.UpdateData(
                table: "Pets",
                keyColumn: "Id",
                keyValue: 19,
                column: "CreatedTime",
                value: new DateTime(2024, 8, 26, 12, 2, 41, 233, DateTimeKind.Local).AddTicks(931));

            migrationBuilder.UpdateData(
                table: "Pets",
                keyColumn: "Id",
                keyValue: 20,
                column: "CreatedTime",
                value: new DateTime(2024, 8, 26, 12, 2, 41, 233, DateTimeKind.Local).AddTicks(936));

            migrationBuilder.UpdateData(
                table: "Pets",
                keyColumn: "Id",
                keyValue: 21,
                column: "CreatedTime",
                value: new DateTime(2024, 8, 26, 12, 2, 41, 233, DateTimeKind.Local).AddTicks(942));

            migrationBuilder.UpdateData(
                table: "Pets",
                keyColumn: "Id",
                keyValue: 22,
                column: "CreatedTime",
                value: new DateTime(2024, 8, 26, 12, 2, 41, 233, DateTimeKind.Local).AddTicks(945));

            migrationBuilder.UpdateData(
                table: "Pets",
                keyColumn: "Id",
                keyValue: 23,
                column: "CreatedTime",
                value: new DateTime(2024, 8, 26, 12, 2, 41, 233, DateTimeKind.Local).AddTicks(949));

            migrationBuilder.UpdateData(
                table: "Pets",
                keyColumn: "Id",
                keyValue: 24,
                column: "CreatedTime",
                value: new DateTime(2024, 8, 26, 12, 2, 41, 233, DateTimeKind.Local).AddTicks(953));

            migrationBuilder.UpdateData(
                table: "Pets",
                keyColumn: "Id",
                keyValue: 25,
                column: "CreatedTime",
                value: new DateTime(2024, 8, 26, 12, 2, 41, 233, DateTimeKind.Local).AddTicks(957));

            migrationBuilder.UpdateData(
                table: "Pets",
                keyColumn: "Id",
                keyValue: 26,
                column: "CreatedTime",
                value: new DateTime(2024, 8, 26, 12, 2, 41, 233, DateTimeKind.Local).AddTicks(961));

            migrationBuilder.UpdateData(
                table: "Pets",
                keyColumn: "Id",
                keyValue: 27,
                column: "CreatedTime",
                value: new DateTime(2024, 8, 26, 12, 2, 41, 233, DateTimeKind.Local).AddTicks(966));

            migrationBuilder.UpdateData(
                table: "Pets",
                keyColumn: "Id",
                keyValue: 28,
                column: "CreatedTime",
                value: new DateTime(2024, 8, 26, 12, 2, 41, 233, DateTimeKind.Local).AddTicks(970));

            migrationBuilder.UpdateData(
                table: "Pets",
                keyColumn: "Id",
                keyValue: 29,
                column: "CreatedTime",
                value: new DateTime(2024, 8, 26, 12, 2, 41, 233, DateTimeKind.Local).AddTicks(974));

            migrationBuilder.UpdateData(
                table: "Pets",
                keyColumn: "Id",
                keyValue: 30,
                column: "CreatedTime",
                value: new DateTime(2024, 8, 26, 12, 2, 41, 233, DateTimeKind.Local).AddTicks(978));

            migrationBuilder.UpdateData(
                table: "Pets",
                keyColumn: "Id",
                keyValue: 31,
                column: "CreatedTime",
                value: new DateTime(2024, 8, 26, 12, 2, 41, 233, DateTimeKind.Local).AddTicks(982));

            migrationBuilder.UpdateData(
                table: "Pets",
                keyColumn: "Id",
                keyValue: 32,
                column: "CreatedTime",
                value: new DateTime(2024, 8, 26, 12, 2, 41, 233, DateTimeKind.Local).AddTicks(986));

            migrationBuilder.UpdateData(
                table: "Pets",
                keyColumn: "Id",
                keyValue: 33,
                column: "CreatedTime",
                value: new DateTime(2024, 8, 26, 12, 2, 41, 233, DateTimeKind.Local).AddTicks(990));

            migrationBuilder.UpdateData(
                table: "Pets",
                keyColumn: "Id",
                keyValue: 34,
                column: "CreatedTime",
                value: new DateTime(2024, 8, 26, 12, 2, 41, 233, DateTimeKind.Local).AddTicks(994));

            migrationBuilder.UpdateData(
                table: "Pets",
                keyColumn: "Id",
                keyValue: 35,
                column: "CreatedTime",
                value: new DateTime(2024, 8, 26, 12, 2, 41, 233, DateTimeKind.Local).AddTicks(999));

            migrationBuilder.UpdateData(
                table: "Pets",
                keyColumn: "Id",
                keyValue: 36,
                column: "CreatedTime",
                value: new DateTime(2024, 8, 26, 12, 2, 41, 233, DateTimeKind.Local).AddTicks(1003));

            migrationBuilder.UpdateData(
                table: "Pets",
                keyColumn: "Id",
                keyValue: 37,
                column: "CreatedTime",
                value: new DateTime(2024, 8, 26, 12, 2, 41, 233, DateTimeKind.Local).AddTicks(1007));

            migrationBuilder.UpdateData(
                table: "Pets",
                keyColumn: "Id",
                keyValue: 38,
                column: "CreatedTime",
                value: new DateTime(2024, 8, 26, 12, 2, 41, 233, DateTimeKind.Local).AddTicks(1011));

            migrationBuilder.UpdateData(
                table: "Pets",
                keyColumn: "Id",
                keyValue: 39,
                column: "CreatedTime",
                value: new DateTime(2024, 8, 26, 12, 2, 41, 233, DateTimeKind.Local).AddTicks(1015));

            migrationBuilder.UpdateData(
                table: "Pets",
                keyColumn: "Id",
                keyValue: 40,
                column: "CreatedTime",
                value: new DateTime(2024, 8, 26, 12, 2, 41, 233, DateTimeKind.Local).AddTicks(1019));

            migrationBuilder.UpdateData(
                table: "Pets",
                keyColumn: "Id",
                keyValue: 41,
                column: "CreatedTime",
                value: new DateTime(2024, 8, 26, 12, 2, 41, 233, DateTimeKind.Local).AddTicks(1023));

            migrationBuilder.UpdateData(
                table: "Pets",
                keyColumn: "Id",
                keyValue: 42,
                column: "CreatedTime",
                value: new DateTime(2024, 8, 26, 12, 2, 41, 233, DateTimeKind.Local).AddTicks(1026));

            migrationBuilder.UpdateData(
                table: "Pets",
                keyColumn: "Id",
                keyValue: 43,
                column: "CreatedTime",
                value: new DateTime(2024, 8, 26, 12, 2, 41, 233, DateTimeKind.Local).AddTicks(1031));

            migrationBuilder.UpdateData(
                table: "Pets",
                keyColumn: "Id",
                keyValue: 44,
                column: "CreatedTime",
                value: new DateTime(2024, 8, 26, 12, 2, 41, 233, DateTimeKind.Local).AddTicks(1035));

            migrationBuilder.UpdateData(
                table: "Pets",
                keyColumn: "Id",
                keyValue: 45,
                column: "CreatedTime",
                value: new DateTime(2024, 8, 26, 12, 2, 41, 233, DateTimeKind.Local).AddTicks(1039));

            migrationBuilder.UpdateData(
                table: "Pets",
                keyColumn: "Id",
                keyValue: 46,
                column: "CreatedTime",
                value: new DateTime(2024, 8, 26, 12, 2, 41, 233, DateTimeKind.Local).AddTicks(1042));

            migrationBuilder.UpdateData(
                table: "Pets",
                keyColumn: "Id",
                keyValue: 47,
                column: "CreatedTime",
                value: new DateTime(2024, 8, 26, 12, 2, 41, 233, DateTimeKind.Local).AddTicks(1046));

            migrationBuilder.UpdateData(
                table: "Pets",
                keyColumn: "Id",
                keyValue: 48,
                column: "CreatedTime",
                value: new DateTime(2024, 8, 26, 12, 2, 41, 233, DateTimeKind.Local).AddTicks(1050));

            migrationBuilder.UpdateData(
                table: "Pets",
                keyColumn: "Id",
                keyValue: 49,
                column: "CreatedTime",
                value: new DateTime(2024, 8, 26, 12, 2, 41, 233, DateTimeKind.Local).AddTicks(1054));

            migrationBuilder.UpdateData(
                table: "Pets",
                keyColumn: "Id",
                keyValue: 50,
                column: "CreatedTime",
                value: new DateTime(2024, 8, 26, 12, 2, 41, 233, DateTimeKind.Local).AddTicks(1059));

            migrationBuilder.UpdateData(
                table: "Shelters",
                keyColumn: "Id",
                keyValue: 1021,
                columns: new[] { "CreatedTime", "LastUpdatedTime" },
                values: new object[] { new DateTime(2024, 8, 26, 8, 2, 41, 221, DateTimeKind.Utc).AddTicks(4428), new DateTime(2024, 8, 26, 8, 2, 41, 221, DateTimeKind.Utc).AddTicks(4430) });

            migrationBuilder.UpdateData(
                table: "Shelters",
                keyColumn: "Id",
                keyValue: 1022,
                columns: new[] { "CreatedTime", "LastUpdatedTime" },
                values: new object[] { new DateTime(2024, 8, 26, 8, 2, 41, 221, DateTimeKind.Utc).AddTicks(4444), new DateTime(2024, 8, 26, 8, 2, 41, 221, DateTimeKind.Utc).AddTicks(4444) });

            migrationBuilder.UpdateData(
                table: "Shelters",
                keyColumn: "Id",
                keyValue: 1023,
                columns: new[] { "CreatedTime", "LastUpdatedTime" },
                values: new object[] { new DateTime(2024, 8, 26, 8, 2, 41, 221, DateTimeKind.Utc).AddTicks(4451), new DateTime(2024, 8, 26, 8, 2, 41, 221, DateTimeKind.Utc).AddTicks(4452) });

            migrationBuilder.UpdateData(
                table: "Shelters",
                keyColumn: "Id",
                keyValue: 1024,
                columns: new[] { "CreatedTime", "LastUpdatedTime" },
                values: new object[] { new DateTime(2024, 8, 26, 8, 2, 41, 221, DateTimeKind.Utc).AddTicks(4458), new DateTime(2024, 8, 26, 8, 2, 41, 221, DateTimeKind.Utc).AddTicks(4459) });

            migrationBuilder.UpdateData(
                table: "Shelters",
                keyColumn: "Id",
                keyValue: 1025,
                columns: new[] { "CreatedTime", "LastUpdatedTime" },
                values: new object[] { new DateTime(2024, 8, 26, 8, 2, 41, 221, DateTimeKind.Utc).AddTicks(4466), new DateTime(2024, 8, 26, 8, 2, 41, 221, DateTimeKind.Utc).AddTicks(4466) });

            migrationBuilder.UpdateData(
                table: "Shelters",
                keyColumn: "Id",
                keyValue: 1026,
                columns: new[] { "CreatedTime", "LastUpdatedTime" },
                values: new object[] { new DateTime(2024, 8, 26, 8, 2, 41, 221, DateTimeKind.Utc).AddTicks(4475), new DateTime(2024, 8, 26, 8, 2, 41, 221, DateTimeKind.Utc).AddTicks(4475) });

            migrationBuilder.UpdateData(
                table: "Shelters",
                keyColumn: "Id",
                keyValue: 1027,
                columns: new[] { "CreatedTime", "LastUpdatedTime" },
                values: new object[] { new DateTime(2024, 8, 26, 8, 2, 41, 221, DateTimeKind.Utc).AddTicks(4482), new DateTime(2024, 8, 26, 8, 2, 41, 221, DateTimeKind.Utc).AddTicks(4482) });

            migrationBuilder.UpdateData(
                table: "Shelters",
                keyColumn: "Id",
                keyValue: 1028,
                columns: new[] { "CreatedTime", "LastUpdatedTime" },
                values: new object[] { new DateTime(2024, 8, 26, 8, 2, 41, 221, DateTimeKind.Utc).AddTicks(4489), new DateTime(2024, 8, 26, 8, 2, 41, 221, DateTimeKind.Utc).AddTicks(4489) });

            migrationBuilder.UpdateData(
                table: "Shelters",
                keyColumn: "Id",
                keyValue: 1029,
                columns: new[] { "CreatedTime", "LastUpdatedTime" },
                values: new object[] { new DateTime(2024, 8, 26, 8, 2, 41, 221, DateTimeKind.Utc).AddTicks(4547), new DateTime(2024, 8, 26, 8, 2, 41, 221, DateTimeKind.Utc).AddTicks(4547) });

            migrationBuilder.UpdateData(
                table: "Shelters",
                keyColumn: "Id",
                keyValue: 1030,
                columns: new[] { "CreatedTime", "LastUpdatedTime" },
                values: new object[] { new DateTime(2024, 8, 26, 8, 2, 41, 221, DateTimeKind.Utc).AddTicks(4556), new DateTime(2024, 8, 26, 8, 2, 41, 221, DateTimeKind.Utc).AddTicks(4557) });

            migrationBuilder.UpdateData(
                table: "Shelters",
                keyColumn: "Id",
                keyValue: 1031,
                columns: new[] { "CreatedTime", "LastUpdatedTime" },
                values: new object[] { new DateTime(2024, 8, 26, 8, 2, 41, 221, DateTimeKind.Utc).AddTicks(4563), new DateTime(2024, 8, 26, 8, 2, 41, 221, DateTimeKind.Utc).AddTicks(4563) });

            migrationBuilder.UpdateData(
                table: "Shelters",
                keyColumn: "Id",
                keyValue: 1032,
                columns: new[] { "CreatedTime", "LastUpdatedTime" },
                values: new object[] { new DateTime(2024, 8, 26, 8, 2, 41, 221, DateTimeKind.Utc).AddTicks(4570), new DateTime(2024, 8, 26, 8, 2, 41, 221, DateTimeKind.Utc).AddTicks(4570) });

            migrationBuilder.UpdateData(
                table: "Shelters",
                keyColumn: "Id",
                keyValue: 1033,
                columns: new[] { "CreatedTime", "LastUpdatedTime" },
                values: new object[] { new DateTime(2024, 8, 26, 8, 2, 41, 221, DateTimeKind.Utc).AddTicks(4577), new DateTime(2024, 8, 26, 8, 2, 41, 221, DateTimeKind.Utc).AddTicks(4577) });

            migrationBuilder.UpdateData(
                table: "Shelters",
                keyColumn: "Id",
                keyValue: 1034,
                columns: new[] { "CreatedTime", "LastUpdatedTime" },
                values: new object[] { new DateTime(2024, 8, 26, 8, 2, 41, 221, DateTimeKind.Utc).AddTicks(4584), new DateTime(2024, 8, 26, 8, 2, 41, 221, DateTimeKind.Utc).AddTicks(4585) });

            migrationBuilder.UpdateData(
                table: "Shelters",
                keyColumn: "Id",
                keyValue: 1035,
                columns: new[] { "CreatedTime", "LastUpdatedTime" },
                values: new object[] { new DateTime(2024, 8, 26, 8, 2, 41, 221, DateTimeKind.Utc).AddTicks(4592), new DateTime(2024, 8, 26, 8, 2, 41, 221, DateTimeKind.Utc).AddTicks(4592) });

            migrationBuilder.UpdateData(
                table: "Shelters",
                keyColumn: "Id",
                keyValue: 1036,
                columns: new[] { "CreatedTime", "LastUpdatedTime" },
                values: new object[] { new DateTime(2024, 8, 26, 8, 2, 41, 221, DateTimeKind.Utc).AddTicks(4599), new DateTime(2024, 8, 26, 8, 2, 41, 221, DateTimeKind.Utc).AddTicks(4599) });

            migrationBuilder.UpdateData(
                table: "Shelters",
                keyColumn: "Id",
                keyValue: 1037,
                columns: new[] { "CreatedTime", "LastUpdatedTime" },
                values: new object[] { new DateTime(2024, 8, 26, 8, 2, 41, 221, DateTimeKind.Utc).AddTicks(4605), new DateTime(2024, 8, 26, 8, 2, 41, 221, DateTimeKind.Utc).AddTicks(4606) });

            migrationBuilder.UpdateData(
                table: "Shelters",
                keyColumn: "Id",
                keyValue: 1038,
                columns: new[] { "CreatedTime", "LastUpdatedTime" },
                values: new object[] { new DateTime(2024, 8, 26, 8, 2, 41, 221, DateTimeKind.Utc).AddTicks(4614), new DateTime(2024, 8, 26, 8, 2, 41, 221, DateTimeKind.Utc).AddTicks(4615) });

            migrationBuilder.UpdateData(
                table: "Shelters",
                keyColumn: "Id",
                keyValue: 1039,
                columns: new[] { "CreatedTime", "LastUpdatedTime" },
                values: new object[] { new DateTime(2024, 8, 26, 8, 2, 41, 221, DateTimeKind.Utc).AddTicks(4621), new DateTime(2024, 8, 26, 8, 2, 41, 221, DateTimeKind.Utc).AddTicks(4621) });

            migrationBuilder.UpdateData(
                table: "Shelters",
                keyColumn: "Id",
                keyValue: 1040,
                columns: new[] { "CreatedTime", "LastUpdatedTime" },
                values: new object[] { new DateTime(2024, 8, 26, 8, 2, 41, 221, DateTimeKind.Utc).AddTicks(4628), new DateTime(2024, 8, 26, 8, 2, 41, 221, DateTimeKind.Utc).AddTicks(4628) });
        }
    }
}
