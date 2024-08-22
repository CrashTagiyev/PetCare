using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Persistance.Migrations
{
    /// <inheritdoc />
    public partial class mig869 : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Locations");

            migrationBuilder.AddColumn<string>(
                name: "City",
                table: "Shelters",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "Street",
                table: "Shelters",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: 2001,
                columns: new[] { "ConcurrencyStamp", "CreatedTime", "LastUpdatedTime", "RefreshTokenCreateTime" },
                values: new object[] { "76c6e7e3-9d95-4092-8060-c34537343e55", new DateTime(2024, 8, 21, 18, 20, 49, 723, DateTimeKind.Utc).AddTicks(3523), new DateTime(2024, 8, 21, 18, 20, 49, 723, DateTimeKind.Utc).AddTicks(3525), new DateTime(2024, 8, 21, 18, 20, 49, 723, DateTimeKind.Utc).AddTicks(3454) });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: 2002,
                columns: new[] { "ConcurrencyStamp", "CreatedTime", "LastUpdatedTime", "RefreshTokenCreateTime" },
                values: new object[] { "555a2458-7113-4836-a0b5-9dd97d9547d0", new DateTime(2024, 8, 21, 18, 20, 49, 723, DateTimeKind.Utc).AddTicks(3593), new DateTime(2024, 8, 21, 18, 20, 49, 723, DateTimeKind.Utc).AddTicks(3593), new DateTime(2024, 8, 21, 18, 20, 49, 723, DateTimeKind.Utc).AddTicks(3588) });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: 2003,
                columns: new[] { "ConcurrencyStamp", "CreatedTime", "LastUpdatedTime", "RefreshTokenCreateTime" },
                values: new object[] { "abe2ad0d-4444-4b9b-9c2c-bf96a0cf7089", new DateTime(2024, 8, 21, 18, 20, 49, 723, DateTimeKind.Utc).AddTicks(3607), new DateTime(2024, 8, 21, 18, 20, 49, 723, DateTimeKind.Utc).AddTicks(3608), new DateTime(2024, 8, 21, 18, 20, 49, 723, DateTimeKind.Utc).AddTicks(3604) });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: 2004,
                columns: new[] { "ConcurrencyStamp", "CreatedTime", "LastUpdatedTime", "RefreshTokenCreateTime" },
                values: new object[] { "056d39ec-d10b-43b7-b212-2f80430c5e95", new DateTime(2024, 8, 21, 18, 20, 49, 723, DateTimeKind.Utc).AddTicks(3679), new DateTime(2024, 8, 21, 18, 20, 49, 723, DateTimeKind.Utc).AddTicks(3680), new DateTime(2024, 8, 21, 18, 20, 49, 723, DateTimeKind.Utc).AddTicks(3616) });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: 2005,
                columns: new[] { "ConcurrencyStamp", "CreatedTime", "LastUpdatedTime", "RefreshTokenCreateTime" },
                values: new object[] { "7187d43d-9315-4e0a-94b2-708c6869106d", new DateTime(2024, 8, 21, 18, 20, 49, 723, DateTimeKind.Utc).AddTicks(3692), new DateTime(2024, 8, 21, 18, 20, 49, 723, DateTimeKind.Utc).AddTicks(3693), new DateTime(2024, 8, 21, 18, 20, 49, 723, DateTimeKind.Utc).AddTicks(3689) });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: 2006,
                columns: new[] { "ConcurrencyStamp", "CreatedTime", "LastUpdatedTime", "RefreshTokenCreateTime" },
                values: new object[] { "064de6ad-9827-40fb-a90c-26b2e5d0b771", new DateTime(2024, 8, 21, 18, 20, 49, 723, DateTimeKind.Utc).AddTicks(3706), new DateTime(2024, 8, 21, 18, 20, 49, 723, DateTimeKind.Utc).AddTicks(3707), new DateTime(2024, 8, 21, 18, 20, 49, 723, DateTimeKind.Utc).AddTicks(3703) });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: 2007,
                columns: new[] { "ConcurrencyStamp", "CreatedTime", "LastUpdatedTime", "RefreshTokenCreateTime" },
                values: new object[] { "9dd42226-23cd-4926-927d-26b5a6c7ff8c", new DateTime(2024, 8, 21, 18, 20, 49, 723, DateTimeKind.Utc).AddTicks(3717), new DateTime(2024, 8, 21, 18, 20, 49, 723, DateTimeKind.Utc).AddTicks(3718), new DateTime(2024, 8, 21, 18, 20, 49, 723, DateTimeKind.Utc).AddTicks(3714) });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: 2008,
                columns: new[] { "ConcurrencyStamp", "CreatedTime", "LastUpdatedTime", "RefreshTokenCreateTime" },
                values: new object[] { "103ced87-4d46-4927-ac59-2eb0cb96ba34", new DateTime(2024, 8, 21, 18, 20, 49, 723, DateTimeKind.Utc).AddTicks(3728), new DateTime(2024, 8, 21, 18, 20, 49, 723, DateTimeKind.Utc).AddTicks(3729), new DateTime(2024, 8, 21, 18, 20, 49, 723, DateTimeKind.Utc).AddTicks(3726) });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: 2009,
                columns: new[] { "ConcurrencyStamp", "CreatedTime", "LastUpdatedTime", "RefreshTokenCreateTime" },
                values: new object[] { "8c483e31-3c63-4d72-97ed-9279528363d3", new DateTime(2024, 8, 21, 18, 20, 49, 723, DateTimeKind.Utc).AddTicks(3740), new DateTime(2024, 8, 21, 18, 20, 49, 723, DateTimeKind.Utc).AddTicks(3741), new DateTime(2024, 8, 21, 18, 20, 49, 723, DateTimeKind.Utc).AddTicks(3737) });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: 2010,
                columns: new[] { "ConcurrencyStamp", "CreatedTime", "LastUpdatedTime", "RefreshTokenCreateTime" },
                values: new object[] { "be91bb20-6256-4f71-bdfa-f5c6e08322de", new DateTime(2024, 8, 21, 18, 20, 49, 723, DateTimeKind.Utc).AddTicks(3753), new DateTime(2024, 8, 21, 18, 20, 49, 723, DateTimeKind.Utc).AddTicks(3754), new DateTime(2024, 8, 21, 18, 20, 49, 723, DateTimeKind.Utc).AddTicks(3750) });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: 2011,
                columns: new[] { "ConcurrencyStamp", "CreatedTime", "LastUpdatedTime", "RefreshTokenCreateTime" },
                values: new object[] { "5a41c284-7943-4614-b216-fa2cc7bef57c", new DateTime(2024, 8, 21, 18, 20, 49, 723, DateTimeKind.Utc).AddTicks(3767), new DateTime(2024, 8, 21, 18, 20, 49, 723, DateTimeKind.Utc).AddTicks(3768), new DateTime(2024, 8, 21, 18, 20, 49, 723, DateTimeKind.Utc).AddTicks(3764) });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: 2012,
                columns: new[] { "ConcurrencyStamp", "CreatedTime", "LastUpdatedTime", "RefreshTokenCreateTime" },
                values: new object[] { "41f8f8aa-4de3-46fd-8d79-0e6d8d742dd2", new DateTime(2024, 8, 21, 18, 20, 49, 723, DateTimeKind.Utc).AddTicks(3783), new DateTime(2024, 8, 21, 18, 20, 49, 723, DateTimeKind.Utc).AddTicks(3783), new DateTime(2024, 8, 21, 18, 20, 49, 723, DateTimeKind.Utc).AddTicks(3776) });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: 2013,
                columns: new[] { "ConcurrencyStamp", "CreatedTime", "LastUpdatedTime", "RefreshTokenCreateTime" },
                values: new object[] { "ffd670bc-8df4-4805-9910-52a5177cc6a1", new DateTime(2024, 8, 21, 18, 20, 49, 723, DateTimeKind.Utc).AddTicks(3794), new DateTime(2024, 8, 21, 18, 20, 49, 723, DateTimeKind.Utc).AddTicks(3795), new DateTime(2024, 8, 21, 18, 20, 49, 723, DateTimeKind.Utc).AddTicks(3791) });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: 2014,
                columns: new[] { "ConcurrencyStamp", "CreatedTime", "LastUpdatedTime", "RefreshTokenCreateTime" },
                values: new object[] { "7ee6e359-b6c1-4dc5-af2e-b1bf3f0ea92c", new DateTime(2024, 8, 21, 18, 20, 49, 723, DateTimeKind.Utc).AddTicks(3837), new DateTime(2024, 8, 21, 18, 20, 49, 723, DateTimeKind.Utc).AddTicks(3837), new DateTime(2024, 8, 21, 18, 20, 49, 723, DateTimeKind.Utc).AddTicks(3833) });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: 2015,
                columns: new[] { "ConcurrencyStamp", "CreatedTime", "LastUpdatedTime", "RefreshTokenCreateTime" },
                values: new object[] { "ae3790f3-3366-4f12-bd96-62273462f2d2", new DateTime(2024, 8, 21, 18, 20, 49, 723, DateTimeKind.Utc).AddTicks(3848), new DateTime(2024, 8, 21, 18, 20, 49, 723, DateTimeKind.Utc).AddTicks(3849), new DateTime(2024, 8, 21, 18, 20, 49, 723, DateTimeKind.Utc).AddTicks(3845) });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: 2016,
                columns: new[] { "ConcurrencyStamp", "CreatedTime", "LastUpdatedTime", "RefreshTokenCreateTime" },
                values: new object[] { "865ad4e4-4936-4604-9118-a6f619f372e0", new DateTime(2024, 8, 21, 18, 20, 49, 723, DateTimeKind.Utc).AddTicks(3859), new DateTime(2024, 8, 21, 18, 20, 49, 723, DateTimeKind.Utc).AddTicks(3859), new DateTime(2024, 8, 21, 18, 20, 49, 723, DateTimeKind.Utc).AddTicks(3856) });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: 2017,
                columns: new[] { "ConcurrencyStamp", "CreatedTime", "LastUpdatedTime", "RefreshTokenCreateTime" },
                values: new object[] { "608503e1-15f9-4df3-a889-36f2073ba560", new DateTime(2024, 8, 21, 18, 20, 49, 723, DateTimeKind.Utc).AddTicks(3870), new DateTime(2024, 8, 21, 18, 20, 49, 723, DateTimeKind.Utc).AddTicks(3871), new DateTime(2024, 8, 21, 18, 20, 49, 723, DateTimeKind.Utc).AddTicks(3867) });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: 2018,
                columns: new[] { "ConcurrencyStamp", "CreatedTime", "LastUpdatedTime", "RefreshTokenCreateTime" },
                values: new object[] { "ae8340eb-d319-4128-8b7b-f3e49be988dc", new DateTime(2024, 8, 21, 18, 20, 49, 723, DateTimeKind.Utc).AddTicks(3883), new DateTime(2024, 8, 21, 18, 20, 49, 723, DateTimeKind.Utc).AddTicks(3883), new DateTime(2024, 8, 21, 18, 20, 49, 723, DateTimeKind.Utc).AddTicks(3880) });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: 2019,
                columns: new[] { "ConcurrencyStamp", "CreatedTime", "LastUpdatedTime", "RefreshTokenCreateTime" },
                values: new object[] { "b02c2d78-a07b-4aa2-ac37-840de89fcb28", new DateTime(2024, 8, 21, 18, 20, 49, 723, DateTimeKind.Utc).AddTicks(3894), new DateTime(2024, 8, 21, 18, 20, 49, 723, DateTimeKind.Utc).AddTicks(3895), new DateTime(2024, 8, 21, 18, 20, 49, 723, DateTimeKind.Utc).AddTicks(3891) });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: 2020,
                columns: new[] { "ConcurrencyStamp", "CreatedTime", "LastUpdatedTime", "RefreshTokenCreateTime" },
                values: new object[] { "57dd2717-ae92-45c0-86f9-06e803f2a2d2", new DateTime(2024, 8, 21, 18, 20, 49, 723, DateTimeKind.Utc).AddTicks(3909), new DateTime(2024, 8, 21, 18, 20, 49, 723, DateTimeKind.Utc).AddTicks(3909), new DateTime(2024, 8, 21, 18, 20, 49, 723, DateTimeKind.Utc).AddTicks(3903) });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: 2021,
                columns: new[] { "ConcurrencyStamp", "CreatedTime", "LastUpdatedTime", "RefreshTokenCreateTime" },
                values: new object[] { "585e479c-283a-4008-9269-cae0902f4dfd", new DateTime(2024, 8, 21, 18, 20, 49, 723, DateTimeKind.Utc).AddTicks(3920), new DateTime(2024, 8, 21, 18, 20, 49, 723, DateTimeKind.Utc).AddTicks(3921), new DateTime(2024, 8, 21, 18, 20, 49, 723, DateTimeKind.Utc).AddTicks(3917) });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: 2022,
                columns: new[] { "ConcurrencyStamp", "CreatedTime", "LastUpdatedTime", "RefreshTokenCreateTime" },
                values: new object[] { "eea72e09-fa71-41dc-a4df-004e6e43619d", new DateTime(2024, 8, 21, 18, 20, 49, 723, DateTimeKind.Utc).AddTicks(3939), new DateTime(2024, 8, 21, 18, 20, 49, 723, DateTimeKind.Utc).AddTicks(3939), new DateTime(2024, 8, 21, 18, 20, 49, 723, DateTimeKind.Utc).AddTicks(3936) });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: 2023,
                columns: new[] { "ConcurrencyStamp", "CreatedTime", "LastUpdatedTime", "RefreshTokenCreateTime" },
                values: new object[] { "716ef48a-2d24-4ab6-8773-32910112d989", new DateTime(2024, 8, 21, 18, 20, 49, 723, DateTimeKind.Utc).AddTicks(3981), new DateTime(2024, 8, 21, 18, 20, 49, 723, DateTimeKind.Utc).AddTicks(3981), new DateTime(2024, 8, 21, 18, 20, 49, 723, DateTimeKind.Utc).AddTicks(3949) });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: 2024,
                columns: new[] { "ConcurrencyStamp", "CreatedTime", "LastUpdatedTime", "RefreshTokenCreateTime" },
                values: new object[] { "f4050663-87fa-472f-b796-1166fb6f21e2", new DateTime(2024, 8, 21, 18, 20, 49, 723, DateTimeKind.Utc).AddTicks(3994), new DateTime(2024, 8, 21, 18, 20, 49, 723, DateTimeKind.Utc).AddTicks(3994), new DateTime(2024, 8, 21, 18, 20, 49, 723, DateTimeKind.Utc).AddTicks(3990) });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: 2025,
                columns: new[] { "ConcurrencyStamp", "CreatedTime", "LastUpdatedTime", "RefreshTokenCreateTime" },
                values: new object[] { "6f853c6b-726c-4b3f-ba4e-93137d44599b", new DateTime(2024, 8, 21, 18, 20, 49, 723, DateTimeKind.Utc).AddTicks(4006), new DateTime(2024, 8, 21, 18, 20, 49, 723, DateTimeKind.Utc).AddTicks(4007), new DateTime(2024, 8, 21, 18, 20, 49, 723, DateTimeKind.Utc).AddTicks(4003) });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: 2026,
                columns: new[] { "ConcurrencyStamp", "CreatedTime", "LastUpdatedTime", "RefreshTokenCreateTime" },
                values: new object[] { "7808cf1f-c19e-4f57-8a63-08d7d1df489a", new DateTime(2024, 8, 21, 18, 20, 49, 723, DateTimeKind.Utc).AddTicks(4018), new DateTime(2024, 8, 21, 18, 20, 49, 723, DateTimeKind.Utc).AddTicks(4019), new DateTime(2024, 8, 21, 18, 20, 49, 723, DateTimeKind.Utc).AddTicks(4015) });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: 2027,
                columns: new[] { "ConcurrencyStamp", "CreatedTime", "LastUpdatedTime", "RefreshTokenCreateTime" },
                values: new object[] { "d213aeeb-db83-49c9-9517-c40d89d0ca10", new DateTime(2024, 8, 21, 18, 20, 49, 723, DateTimeKind.Utc).AddTicks(4031), new DateTime(2024, 8, 21, 18, 20, 49, 723, DateTimeKind.Utc).AddTicks(4031), new DateTime(2024, 8, 21, 18, 20, 49, 723, DateTimeKind.Utc).AddTicks(4027) });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: 2028,
                columns: new[] { "ConcurrencyStamp", "CreatedTime", "LastUpdatedTime", "RefreshTokenCreateTime" },
                values: new object[] { "055a8e15-4eb0-4a1c-a718-4af85cae563b", new DateTime(2024, 8, 21, 18, 20, 49, 723, DateTimeKind.Utc).AddTicks(4046), new DateTime(2024, 8, 21, 18, 20, 49, 723, DateTimeKind.Utc).AddTicks(4047), new DateTime(2024, 8, 21, 18, 20, 49, 723, DateTimeKind.Utc).AddTicks(4040) });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: 2029,
                columns: new[] { "ConcurrencyStamp", "CreatedTime", "LastUpdatedTime", "RefreshTokenCreateTime" },
                values: new object[] { "77541a3d-be10-4949-9243-92388c345246", new DateTime(2024, 8, 21, 18, 20, 49, 723, DateTimeKind.Utc).AddTicks(4059), new DateTime(2024, 8, 21, 18, 20, 49, 723, DateTimeKind.Utc).AddTicks(4059), new DateTime(2024, 8, 21, 18, 20, 49, 723, DateTimeKind.Utc).AddTicks(4056) });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: 2030,
                columns: new[] { "ConcurrencyStamp", "CreatedTime", "LastUpdatedTime", "RefreshTokenCreateTime" },
                values: new object[] { "2c7709d6-dd47-43c0-9a59-7faee07f4dcc", new DateTime(2024, 8, 21, 18, 20, 49, 723, DateTimeKind.Utc).AddTicks(4071), new DateTime(2024, 8, 21, 18, 20, 49, 723, DateTimeKind.Utc).AddTicks(4071), new DateTime(2024, 8, 21, 18, 20, 49, 723, DateTimeKind.Utc).AddTicks(4068) });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: 2031,
                columns: new[] { "ConcurrencyStamp", "CreatedTime", "LastUpdatedTime", "RefreshTokenCreateTime" },
                values: new object[] { "78379ef5-1029-4f6f-8547-e87d8a2fe3eb", new DateTime(2024, 8, 21, 18, 20, 49, 723, DateTimeKind.Utc).AddTicks(4083), new DateTime(2024, 8, 21, 18, 20, 49, 723, DateTimeKind.Utc).AddTicks(4083), new DateTime(2024, 8, 21, 18, 20, 49, 723, DateTimeKind.Utc).AddTicks(4080) });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: 2032,
                columns: new[] { "ConcurrencyStamp", "CreatedTime", "LastUpdatedTime", "RefreshTokenCreateTime" },
                values: new object[] { "10ce7f55-6839-4798-af9b-b5172ce0024d", new DateTime(2024, 8, 21, 18, 20, 49, 723, DateTimeKind.Utc).AddTicks(4132), new DateTime(2024, 8, 21, 18, 20, 49, 723, DateTimeKind.Utc).AddTicks(4132), new DateTime(2024, 8, 21, 18, 20, 49, 723, DateTimeKind.Utc).AddTicks(4129) });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: 2033,
                columns: new[] { "ConcurrencyStamp", "CreatedTime", "LastUpdatedTime", "RefreshTokenCreateTime" },
                values: new object[] { "bc84b0d5-05fe-4cea-84d1-139fc1e94031", new DateTime(2024, 8, 21, 18, 20, 49, 723, DateTimeKind.Utc).AddTicks(4144), new DateTime(2024, 8, 21, 18, 20, 49, 723, DateTimeKind.Utc).AddTicks(4145), new DateTime(2024, 8, 21, 18, 20, 49, 723, DateTimeKind.Utc).AddTicks(4141) });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: 2034,
                columns: new[] { "ConcurrencyStamp", "CreatedTime", "LastUpdatedTime", "RefreshTokenCreateTime" },
                values: new object[] { "f88082b3-33ab-443f-ae9c-2ebc7009fe95", new DateTime(2024, 8, 21, 18, 20, 49, 723, DateTimeKind.Utc).AddTicks(4158), new DateTime(2024, 8, 21, 18, 20, 49, 723, DateTimeKind.Utc).AddTicks(4159), new DateTime(2024, 8, 21, 18, 20, 49, 723, DateTimeKind.Utc).AddTicks(4156) });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: 2035,
                columns: new[] { "ConcurrencyStamp", "CreatedTime", "LastUpdatedTime", "RefreshTokenCreateTime" },
                values: new object[] { "eb31cd23-701e-4ff4-8880-7d41d9868d61", new DateTime(2024, 8, 21, 18, 20, 49, 723, DateTimeKind.Utc).AddTicks(4171), new DateTime(2024, 8, 21, 18, 20, 49, 723, DateTimeKind.Utc).AddTicks(4171), new DateTime(2024, 8, 21, 18, 20, 49, 723, DateTimeKind.Utc).AddTicks(4168) });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: 2036,
                columns: new[] { "ConcurrencyStamp", "CreatedTime", "LastUpdatedTime", "RefreshTokenCreateTime" },
                values: new object[] { "c3a2df99-44c8-4ce3-8fba-2152b40cfa07", new DateTime(2024, 8, 21, 18, 20, 49, 723, DateTimeKind.Utc).AddTicks(4186), new DateTime(2024, 8, 21, 18, 20, 49, 723, DateTimeKind.Utc).AddTicks(4187), new DateTime(2024, 8, 21, 18, 20, 49, 723, DateTimeKind.Utc).AddTicks(4180) });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: 2037,
                columns: new[] { "ConcurrencyStamp", "CreatedTime", "LastUpdatedTime", "RefreshTokenCreateTime" },
                values: new object[] { "4e7c390a-2fea-4fbf-bcdc-58d88006078d", new DateTime(2024, 8, 21, 18, 20, 49, 723, DateTimeKind.Utc).AddTicks(4198), new DateTime(2024, 8, 21, 18, 20, 49, 723, DateTimeKind.Utc).AddTicks(4199), new DateTime(2024, 8, 21, 18, 20, 49, 723, DateTimeKind.Utc).AddTicks(4195) });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: 2038,
                columns: new[] { "ConcurrencyStamp", "CreatedTime", "LastUpdatedTime", "RefreshTokenCreateTime" },
                values: new object[] { "8fe76598-cfc5-497d-af62-c75f99e1e7b6", new DateTime(2024, 8, 21, 18, 20, 49, 723, DateTimeKind.Utc).AddTicks(4211), new DateTime(2024, 8, 21, 18, 20, 49, 723, DateTimeKind.Utc).AddTicks(4211), new DateTime(2024, 8, 21, 18, 20, 49, 723, DateTimeKind.Utc).AddTicks(4208) });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: 2039,
                columns: new[] { "ConcurrencyStamp", "CreatedTime", "LastUpdatedTime", "RefreshTokenCreateTime" },
                values: new object[] { "e8ba8f1c-0636-4f95-a34c-0aa060dcf9a6", new DateTime(2024, 8, 21, 18, 20, 49, 723, DateTimeKind.Utc).AddTicks(4222), new DateTime(2024, 8, 21, 18, 20, 49, 723, DateTimeKind.Utc).AddTicks(4223), new DateTime(2024, 8, 21, 18, 20, 49, 723, DateTimeKind.Utc).AddTicks(4219) });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: 2040,
                columns: new[] { "ConcurrencyStamp", "CreatedTime", "LastUpdatedTime", "RefreshTokenCreateTime" },
                values: new object[] { "b7dfe080-ceac-47fc-b250-bd736901995b", new DateTime(2024, 8, 21, 18, 20, 49, 723, DateTimeKind.Utc).AddTicks(4235), new DateTime(2024, 8, 21, 18, 20, 49, 723, DateTimeKind.Utc).AddTicks(4235), new DateTime(2024, 8, 21, 18, 20, 49, 723, DateTimeKind.Utc).AddTicks(4231) });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: 2041,
                columns: new[] { "ConcurrencyStamp", "CreatedTime", "LastUpdatedTime", "RefreshTokenCreateTime" },
                values: new object[] { "cc07ba89-f3ad-4d23-b048-a108192864fc", new DateTime(2024, 8, 21, 18, 20, 49, 723, DateTimeKind.Utc).AddTicks(4297), new DateTime(2024, 8, 21, 18, 20, 49, 723, DateTimeKind.Utc).AddTicks(4297), new DateTime(2024, 8, 21, 18, 20, 49, 723, DateTimeKind.Utc).AddTicks(4293) });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: 2042,
                columns: new[] { "ConcurrencyStamp", "CreatedTime", "LastUpdatedTime", "RefreshTokenCreateTime" },
                values: new object[] { "b373d2aa-a0f8-48f3-a2b4-d948418c7189", new DateTime(2024, 8, 21, 18, 20, 49, 723, DateTimeKind.Utc).AddTicks(4314), new DateTime(2024, 8, 21, 18, 20, 49, 723, DateTimeKind.Utc).AddTicks(4315), new DateTime(2024, 8, 21, 18, 20, 49, 723, DateTimeKind.Utc).AddTicks(4311) });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: 2043,
                columns: new[] { "ConcurrencyStamp", "CreatedTime", "LastUpdatedTime", "RefreshTokenCreateTime" },
                values: new object[] { "0cf78df0-f0eb-4b3a-99ec-8e6d0919bb0d", new DateTime(2024, 8, 21, 18, 20, 49, 723, DateTimeKind.Utc).AddTicks(4326), new DateTime(2024, 8, 21, 18, 20, 49, 723, DateTimeKind.Utc).AddTicks(4326), new DateTime(2024, 8, 21, 18, 20, 49, 723, DateTimeKind.Utc).AddTicks(4323) });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: 2044,
                columns: new[] { "ConcurrencyStamp", "CreatedTime", "LastUpdatedTime", "RefreshTokenCreateTime" },
                values: new object[] { "083ba984-d533-44e7-8d80-6e344593e99e", new DateTime(2024, 8, 21, 18, 20, 49, 723, DateTimeKind.Utc).AddTicks(4340), new DateTime(2024, 8, 21, 18, 20, 49, 723, DateTimeKind.Utc).AddTicks(4341), new DateTime(2024, 8, 21, 18, 20, 49, 723, DateTimeKind.Utc).AddTicks(4334) });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: 2045,
                columns: new[] { "ConcurrencyStamp", "CreatedTime", "LastUpdatedTime", "RefreshTokenCreateTime" },
                values: new object[] { "64f189d8-dd1b-492b-b1b5-69068a29b63b", new DateTime(2024, 8, 21, 18, 20, 49, 723, DateTimeKind.Utc).AddTicks(4352), new DateTime(2024, 8, 21, 18, 20, 49, 723, DateTimeKind.Utc).AddTicks(4352), new DateTime(2024, 8, 21, 18, 20, 49, 723, DateTimeKind.Utc).AddTicks(4349) });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: 2046,
                columns: new[] { "ConcurrencyStamp", "CreatedTime", "LastUpdatedTime", "RefreshTokenCreateTime" },
                values: new object[] { "ac7a822d-c484-4dc9-ab61-3f0b9f96be81", new DateTime(2024, 8, 21, 18, 20, 49, 723, DateTimeKind.Utc).AddTicks(4364), new DateTime(2024, 8, 21, 18, 20, 49, 723, DateTimeKind.Utc).AddTicks(4364), new DateTime(2024, 8, 21, 18, 20, 49, 723, DateTimeKind.Utc).AddTicks(4360) });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: 2047,
                columns: new[] { "ConcurrencyStamp", "CreatedTime", "LastUpdatedTime", "RefreshTokenCreateTime" },
                values: new object[] { "4b3a9ef5-1990-4afa-98da-f83e34086a40", new DateTime(2024, 8, 21, 18, 20, 49, 723, DateTimeKind.Utc).AddTicks(4375), new DateTime(2024, 8, 21, 18, 20, 49, 723, DateTimeKind.Utc).AddTicks(4375), new DateTime(2024, 8, 21, 18, 20, 49, 723, DateTimeKind.Utc).AddTicks(4372) });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: 2048,
                columns: new[] { "ConcurrencyStamp", "CreatedTime", "LastUpdatedTime", "RefreshTokenCreateTime" },
                values: new object[] { "6798e981-8d58-45cb-9f3b-37789a2200cd", new DateTime(2024, 8, 21, 18, 20, 49, 723, DateTimeKind.Utc).AddTicks(4386), new DateTime(2024, 8, 21, 18, 20, 49, 723, DateTimeKind.Utc).AddTicks(4386), new DateTime(2024, 8, 21, 18, 20, 49, 723, DateTimeKind.Utc).AddTicks(4383) });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: 2049,
                columns: new[] { "ConcurrencyStamp", "CreatedTime", "LastUpdatedTime", "RefreshTokenCreateTime" },
                values: new object[] { "e6b26b1c-3031-4826-b81b-2ba145b66488", new DateTime(2024, 8, 21, 18, 20, 49, 723, DateTimeKind.Utc).AddTicks(4397), new DateTime(2024, 8, 21, 18, 20, 49, 723, DateTimeKind.Utc).AddTicks(4398), new DateTime(2024, 8, 21, 18, 20, 49, 723, DateTimeKind.Utc).AddTicks(4394) });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: 2050,
                columns: new[] { "ConcurrencyStamp", "CreatedTime", "LastUpdatedTime", "RefreshTokenCreateTime" },
                values: new object[] { "14b872c4-d95c-4c22-8e54-1ebb5dfc23b8", new DateTime(2024, 8, 21, 18, 20, 49, 723, DateTimeKind.Utc).AddTicks(4408), new DateTime(2024, 8, 21, 18, 20, 49, 723, DateTimeKind.Utc).AddTicks(4409), new DateTime(2024, 8, 21, 18, 20, 49, 723, DateTimeKind.Utc).AddTicks(4405) });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: 2051,
                columns: new[] { "ConcurrencyStamp", "CreatedTime", "LastUpdatedTime", "RefreshTokenCreateTime" },
                values: new object[] { "2d07aec8-c89b-4b8e-9d5a-c87bae558093", new DateTime(2024, 8, 21, 18, 20, 49, 723, DateTimeKind.Utc).AddTicks(4441), new DateTime(2024, 8, 21, 18, 20, 49, 723, DateTimeKind.Utc).AddTicks(4441), new DateTime(2024, 8, 21, 18, 20, 49, 723, DateTimeKind.Utc).AddTicks(4437) });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: 2052,
                columns: new[] { "ConcurrencyStamp", "CreatedTime", "LastUpdatedTime", "RefreshTokenCreateTime" },
                values: new object[] { "ba7511e9-2192-45b4-bc88-d1dfb23d1fce", new DateTime(2024, 8, 21, 18, 20, 49, 723, DateTimeKind.Utc).AddTicks(4455), new DateTime(2024, 8, 21, 18, 20, 49, 723, DateTimeKind.Utc).AddTicks(4455), new DateTime(2024, 8, 21, 18, 20, 49, 723, DateTimeKind.Utc).AddTicks(4449) });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: 2053,
                columns: new[] { "ConcurrencyStamp", "CreatedTime", "LastUpdatedTime", "RefreshTokenCreateTime" },
                values: new object[] { "93c223bc-2c71-4e84-96e6-47902b3ee328", new DateTime(2024, 8, 21, 18, 20, 49, 723, DateTimeKind.Utc).AddTicks(4467), new DateTime(2024, 8, 21, 18, 20, 49, 723, DateTimeKind.Utc).AddTicks(4467), new DateTime(2024, 8, 21, 18, 20, 49, 723, DateTimeKind.Utc).AddTicks(4464) });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: 2054,
                columns: new[] { "ConcurrencyStamp", "CreatedTime", "LastUpdatedTime", "RefreshTokenCreateTime" },
                values: new object[] { "28fdf92e-63c6-488f-94b8-6dc6c813b6b1", new DateTime(2024, 8, 21, 18, 20, 49, 723, DateTimeKind.Utc).AddTicks(4478), new DateTime(2024, 8, 21, 18, 20, 49, 723, DateTimeKind.Utc).AddTicks(4479), new DateTime(2024, 8, 21, 18, 20, 49, 723, DateTimeKind.Utc).AddTicks(4475) });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: 2055,
                columns: new[] { "ConcurrencyStamp", "CreatedTime", "LastUpdatedTime", "RefreshTokenCreateTime" },
                values: new object[] { "f7076952-521e-4717-a26c-3167cd8adb7b", new DateTime(2024, 8, 21, 18, 20, 49, 723, DateTimeKind.Utc).AddTicks(4490), new DateTime(2024, 8, 21, 18, 20, 49, 723, DateTimeKind.Utc).AddTicks(4490), new DateTime(2024, 8, 21, 18, 20, 49, 723, DateTimeKind.Utc).AddTicks(4487) });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: 2056,
                columns: new[] { "ConcurrencyStamp", "CreatedTime", "LastUpdatedTime", "RefreshTokenCreateTime" },
                values: new object[] { "63721c04-eb88-423c-87f1-36204d21fc98", new DateTime(2024, 8, 21, 18, 20, 49, 723, DateTimeKind.Utc).AddTicks(4501), new DateTime(2024, 8, 21, 18, 20, 49, 723, DateTimeKind.Utc).AddTicks(4501), new DateTime(2024, 8, 21, 18, 20, 49, 723, DateTimeKind.Utc).AddTicks(4498) });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: 2057,
                columns: new[] { "ConcurrencyStamp", "CreatedTime", "LastUpdatedTime", "RefreshTokenCreateTime" },
                values: new object[] { "0e4a1772-466e-47d8-8638-cf720a174b9f", new DateTime(2024, 8, 21, 18, 20, 49, 723, DateTimeKind.Utc).AddTicks(4512), new DateTime(2024, 8, 21, 18, 20, 49, 723, DateTimeKind.Utc).AddTicks(4513), new DateTime(2024, 8, 21, 18, 20, 49, 723, DateTimeKind.Utc).AddTicks(4509) });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: 2058,
                columns: new[] { "ConcurrencyStamp", "CreatedTime", "LastUpdatedTime", "RefreshTokenCreateTime" },
                values: new object[] { "95f9b74d-6ec3-47f5-b030-6aeb18d980fa", new DateTime(2024, 8, 21, 18, 20, 49, 723, DateTimeKind.Utc).AddTicks(4523), new DateTime(2024, 8, 21, 18, 20, 49, 723, DateTimeKind.Utc).AddTicks(4524), new DateTime(2024, 8, 21, 18, 20, 49, 723, DateTimeKind.Utc).AddTicks(4520) });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: 2059,
                columns: new[] { "ConcurrencyStamp", "CreatedTime", "LastUpdatedTime", "RefreshTokenCreateTime" },
                values: new object[] { "6c6d8dbc-8e19-450e-936d-54f060a9895a", new DateTime(2024, 8, 21, 18, 20, 49, 723, DateTimeKind.Utc).AddTicks(4534), new DateTime(2024, 8, 21, 18, 20, 49, 723, DateTimeKind.Utc).AddTicks(4535), new DateTime(2024, 8, 21, 18, 20, 49, 723, DateTimeKind.Utc).AddTicks(4531) });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: 2060,
                columns: new[] { "ConcurrencyStamp", "CreatedTime", "LastUpdatedTime", "RefreshTokenCreateTime" },
                values: new object[] { "07697631-1fe1-4884-ba5e-da2530416d77", new DateTime(2024, 8, 21, 18, 20, 49, 723, DateTimeKind.Utc).AddTicks(4612), new DateTime(2024, 8, 21, 18, 20, 49, 723, DateTimeKind.Utc).AddTicks(4612), new DateTime(2024, 8, 21, 18, 20, 49, 723, DateTimeKind.Utc).AddTicks(4605) });

            migrationBuilder.UpdateData(
                table: "Breeds",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedTime",
                value: new DateTime(2024, 8, 21, 22, 20, 49, 713, DateTimeKind.Local).AddTicks(6975));

            migrationBuilder.UpdateData(
                table: "Breeds",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreatedTime",
                value: new DateTime(2024, 8, 21, 22, 20, 49, 713, DateTimeKind.Local).AddTicks(6982));

            migrationBuilder.UpdateData(
                table: "Breeds",
                keyColumn: "Id",
                keyValue: 3,
                column: "CreatedTime",
                value: new DateTime(2024, 8, 21, 22, 20, 49, 713, DateTimeKind.Local).AddTicks(6984));

            migrationBuilder.UpdateData(
                table: "Breeds",
                keyColumn: "Id",
                keyValue: 4,
                column: "CreatedTime",
                value: new DateTime(2024, 8, 21, 22, 20, 49, 713, DateTimeKind.Local).AddTicks(6986));

            migrationBuilder.UpdateData(
                table: "Breeds",
                keyColumn: "Id",
                keyValue: 5,
                column: "CreatedTime",
                value: new DateTime(2024, 8, 21, 22, 20, 49, 713, DateTimeKind.Local).AddTicks(6988));

            migrationBuilder.UpdateData(
                table: "Breeds",
                keyColumn: "Id",
                keyValue: 6,
                column: "CreatedTime",
                value: new DateTime(2024, 8, 21, 22, 20, 49, 713, DateTimeKind.Local).AddTicks(6989));

            migrationBuilder.UpdateData(
                table: "Breeds",
                keyColumn: "Id",
                keyValue: 7,
                column: "CreatedTime",
                value: new DateTime(2024, 8, 21, 22, 20, 49, 713, DateTimeKind.Local).AddTicks(6991));

            migrationBuilder.UpdateData(
                table: "Breeds",
                keyColumn: "Id",
                keyValue: 8,
                column: "CreatedTime",
                value: new DateTime(2024, 8, 21, 22, 20, 49, 713, DateTimeKind.Local).AddTicks(6993));

            migrationBuilder.UpdateData(
                table: "Breeds",
                keyColumn: "Id",
                keyValue: 9,
                column: "CreatedTime",
                value: new DateTime(2024, 8, 21, 22, 20, 49, 713, DateTimeKind.Local).AddTicks(6994));

            migrationBuilder.UpdateData(
                table: "Breeds",
                keyColumn: "Id",
                keyValue: 10,
                column: "CreatedTime",
                value: new DateTime(2024, 8, 21, 22, 20, 49, 713, DateTimeKind.Local).AddTicks(6996));

            migrationBuilder.UpdateData(
                table: "Breeds",
                keyColumn: "Id",
                keyValue: 11,
                column: "CreatedTime",
                value: new DateTime(2024, 8, 21, 22, 20, 49, 713, DateTimeKind.Local).AddTicks(6998));

            migrationBuilder.UpdateData(
                table: "Breeds",
                keyColumn: "Id",
                keyValue: 12,
                column: "CreatedTime",
                value: new DateTime(2024, 8, 21, 22, 20, 49, 713, DateTimeKind.Local).AddTicks(7000));

            migrationBuilder.UpdateData(
                table: "Breeds",
                keyColumn: "Id",
                keyValue: 13,
                column: "CreatedTime",
                value: new DateTime(2024, 8, 21, 22, 20, 49, 713, DateTimeKind.Local).AddTicks(7001));

            migrationBuilder.UpdateData(
                table: "Breeds",
                keyColumn: "Id",
                keyValue: 14,
                column: "CreatedTime",
                value: new DateTime(2024, 8, 21, 22, 20, 49, 713, DateTimeKind.Local).AddTicks(7002));

            migrationBuilder.UpdateData(
                table: "Breeds",
                keyColumn: "Id",
                keyValue: 15,
                column: "CreatedTime",
                value: new DateTime(2024, 8, 21, 22, 20, 49, 713, DateTimeKind.Local).AddTicks(7004));

            migrationBuilder.UpdateData(
                table: "Breeds",
                keyColumn: "Id",
                keyValue: 16,
                column: "CreatedTime",
                value: new DateTime(2024, 8, 21, 22, 20, 49, 713, DateTimeKind.Local).AddTicks(7005));

            migrationBuilder.UpdateData(
                table: "Breeds",
                keyColumn: "Id",
                keyValue: 17,
                column: "CreatedTime",
                value: new DateTime(2024, 8, 21, 22, 20, 49, 713, DateTimeKind.Local).AddTicks(7007));

            migrationBuilder.UpdateData(
                table: "Breeds",
                keyColumn: "Id",
                keyValue: 18,
                column: "CreatedTime",
                value: new DateTime(2024, 8, 21, 22, 20, 49, 713, DateTimeKind.Local).AddTicks(7008));

            migrationBuilder.UpdateData(
                table: "Breeds",
                keyColumn: "Id",
                keyValue: 19,
                column: "CreatedTime",
                value: new DateTime(2024, 8, 21, 22, 20, 49, 713, DateTimeKind.Local).AddTicks(7010));

            migrationBuilder.UpdateData(
                table: "Breeds",
                keyColumn: "Id",
                keyValue: 20,
                column: "CreatedTime",
                value: new DateTime(2024, 8, 21, 22, 20, 49, 713, DateTimeKind.Local).AddTicks(7011));

            migrationBuilder.UpdateData(
                table: "Breeds",
                keyColumn: "Id",
                keyValue: 21,
                column: "CreatedTime",
                value: new DateTime(2024, 8, 21, 22, 20, 49, 713, DateTimeKind.Local).AddTicks(7012));

            migrationBuilder.UpdateData(
                table: "Breeds",
                keyColumn: "Id",
                keyValue: 22,
                column: "CreatedTime",
                value: new DateTime(2024, 8, 21, 22, 20, 49, 713, DateTimeKind.Local).AddTicks(7014));

            migrationBuilder.UpdateData(
                table: "Breeds",
                keyColumn: "Id",
                keyValue: 23,
                column: "CreatedTime",
                value: new DateTime(2024, 8, 21, 22, 20, 49, 713, DateTimeKind.Local).AddTicks(7015));

            migrationBuilder.UpdateData(
                table: "Breeds",
                keyColumn: "Id",
                keyValue: 24,
                column: "CreatedTime",
                value: new DateTime(2024, 8, 21, 22, 20, 49, 713, DateTimeKind.Local).AddTicks(7017));

            migrationBuilder.UpdateData(
                table: "Breeds",
                keyColumn: "Id",
                keyValue: 25,
                column: "CreatedTime",
                value: new DateTime(2024, 8, 21, 22, 20, 49, 713, DateTimeKind.Local).AddTicks(7018));

            migrationBuilder.UpdateData(
                table: "Breeds",
                keyColumn: "Id",
                keyValue: 26,
                column: "CreatedTime",
                value: new DateTime(2024, 8, 21, 22, 20, 49, 713, DateTimeKind.Local).AddTicks(7020));

            migrationBuilder.UpdateData(
                table: "Breeds",
                keyColumn: "Id",
                keyValue: 27,
                column: "CreatedTime",
                value: new DateTime(2024, 8, 21, 22, 20, 49, 713, DateTimeKind.Local).AddTicks(7021));

            migrationBuilder.UpdateData(
                table: "Breeds",
                keyColumn: "Id",
                keyValue: 28,
                column: "CreatedTime",
                value: new DateTime(2024, 8, 21, 22, 20, 49, 713, DateTimeKind.Local).AddTicks(7069));

            migrationBuilder.UpdateData(
                table: "Breeds",
                keyColumn: "Id",
                keyValue: 29,
                column: "CreatedTime",
                value: new DateTime(2024, 8, 21, 22, 20, 49, 713, DateTimeKind.Local).AddTicks(7071));

            migrationBuilder.UpdateData(
                table: "Breeds",
                keyColumn: "Id",
                keyValue: 30,
                column: "CreatedTime",
                value: new DateTime(2024, 8, 21, 22, 20, 49, 713, DateTimeKind.Local).AddTicks(7072));

            migrationBuilder.UpdateData(
                table: "Breeds",
                keyColumn: "Id",
                keyValue: 31,
                column: "CreatedTime",
                value: new DateTime(2024, 8, 21, 22, 20, 49, 713, DateTimeKind.Local).AddTicks(7074));

            migrationBuilder.UpdateData(
                table: "Breeds",
                keyColumn: "Id",
                keyValue: 32,
                column: "CreatedTime",
                value: new DateTime(2024, 8, 21, 22, 20, 49, 713, DateTimeKind.Local).AddTicks(7076));

            migrationBuilder.UpdateData(
                table: "Breeds",
                keyColumn: "Id",
                keyValue: 33,
                column: "CreatedTime",
                value: new DateTime(2024, 8, 21, 22, 20, 49, 713, DateTimeKind.Local).AddTicks(7077));

            migrationBuilder.UpdateData(
                table: "Breeds",
                keyColumn: "Id",
                keyValue: 34,
                column: "CreatedTime",
                value: new DateTime(2024, 8, 21, 22, 20, 49, 713, DateTimeKind.Local).AddTicks(7079));

            migrationBuilder.UpdateData(
                table: "Breeds",
                keyColumn: "Id",
                keyValue: 35,
                column: "CreatedTime",
                value: new DateTime(2024, 8, 21, 22, 20, 49, 713, DateTimeKind.Local).AddTicks(7080));

            migrationBuilder.UpdateData(
                table: "Breeds",
                keyColumn: "Id",
                keyValue: 36,
                column: "CreatedTime",
                value: new DateTime(2024, 8, 21, 22, 20, 49, 713, DateTimeKind.Local).AddTicks(7081));

            migrationBuilder.UpdateData(
                table: "Breeds",
                keyColumn: "Id",
                keyValue: 37,
                column: "CreatedTime",
                value: new DateTime(2024, 8, 21, 22, 20, 49, 713, DateTimeKind.Local).AddTicks(7083));

            migrationBuilder.UpdateData(
                table: "Breeds",
                keyColumn: "Id",
                keyValue: 38,
                column: "CreatedTime",
                value: new DateTime(2024, 8, 21, 22, 20, 49, 713, DateTimeKind.Local).AddTicks(7084));

            migrationBuilder.UpdateData(
                table: "Breeds",
                keyColumn: "Id",
                keyValue: 39,
                column: "CreatedTime",
                value: new DateTime(2024, 8, 21, 22, 20, 49, 713, DateTimeKind.Local).AddTicks(7086));

            migrationBuilder.UpdateData(
                table: "Breeds",
                keyColumn: "Id",
                keyValue: 40,
                column: "CreatedTime",
                value: new DateTime(2024, 8, 21, 22, 20, 49, 713, DateTimeKind.Local).AddTicks(7087));

            migrationBuilder.UpdateData(
                table: "Breeds",
                keyColumn: "Id",
                keyValue: 41,
                column: "CreatedTime",
                value: new DateTime(2024, 8, 21, 22, 20, 49, 713, DateTimeKind.Local).AddTicks(7088));

            migrationBuilder.UpdateData(
                table: "Breeds",
                keyColumn: "Id",
                keyValue: 42,
                column: "CreatedTime",
                value: new DateTime(2024, 8, 21, 22, 20, 49, 713, DateTimeKind.Local).AddTicks(7090));

            migrationBuilder.UpdateData(
                table: "Breeds",
                keyColumn: "Id",
                keyValue: 43,
                column: "CreatedTime",
                value: new DateTime(2024, 8, 21, 22, 20, 49, 713, DateTimeKind.Local).AddTicks(7091));

            migrationBuilder.UpdateData(
                table: "Breeds",
                keyColumn: "Id",
                keyValue: 44,
                column: "CreatedTime",
                value: new DateTime(2024, 8, 21, 22, 20, 49, 713, DateTimeKind.Local).AddTicks(7093));

            migrationBuilder.UpdateData(
                table: "Breeds",
                keyColumn: "Id",
                keyValue: 45,
                column: "CreatedTime",
                value: new DateTime(2024, 8, 21, 22, 20, 49, 713, DateTimeKind.Local).AddTicks(7094));

            migrationBuilder.UpdateData(
                table: "Breeds",
                keyColumn: "Id",
                keyValue: 46,
                column: "CreatedTime",
                value: new DateTime(2024, 8, 21, 22, 20, 49, 713, DateTimeKind.Local).AddTicks(7096));

            migrationBuilder.UpdateData(
                table: "Breeds",
                keyColumn: "Id",
                keyValue: 47,
                column: "CreatedTime",
                value: new DateTime(2024, 8, 21, 22, 20, 49, 713, DateTimeKind.Local).AddTicks(7097));

            migrationBuilder.UpdateData(
                table: "Breeds",
                keyColumn: "Id",
                keyValue: 48,
                column: "CreatedTime",
                value: new DateTime(2024, 8, 21, 22, 20, 49, 713, DateTimeKind.Local).AddTicks(7098));

            migrationBuilder.UpdateData(
                table: "Breeds",
                keyColumn: "Id",
                keyValue: 49,
                column: "CreatedTime",
                value: new DateTime(2024, 8, 21, 22, 20, 49, 713, DateTimeKind.Local).AddTicks(7100));

            migrationBuilder.UpdateData(
                table: "Breeds",
                keyColumn: "Id",
                keyValue: 50,
                column: "CreatedTime",
                value: new DateTime(2024, 8, 21, 22, 20, 49, 713, DateTimeKind.Local).AddTicks(7101));

            migrationBuilder.UpdateData(
                table: "Breeds",
                keyColumn: "Id",
                keyValue: 51,
                column: "CreatedTime",
                value: new DateTime(2024, 8, 21, 22, 20, 49, 713, DateTimeKind.Local).AddTicks(7103));

            migrationBuilder.UpdateData(
                table: "Breeds",
                keyColumn: "Id",
                keyValue: 52,
                column: "CreatedTime",
                value: new DateTime(2024, 8, 21, 22, 20, 49, 713, DateTimeKind.Local).AddTicks(7104));

            migrationBuilder.UpdateData(
                table: "Breeds",
                keyColumn: "Id",
                keyValue: 53,
                column: "CreatedTime",
                value: new DateTime(2024, 8, 21, 22, 20, 49, 713, DateTimeKind.Local).AddTicks(7106));

            migrationBuilder.UpdateData(
                table: "Breeds",
                keyColumn: "Id",
                keyValue: 54,
                column: "CreatedTime",
                value: new DateTime(2024, 8, 21, 22, 20, 49, 713, DateTimeKind.Local).AddTicks(7107));

            migrationBuilder.UpdateData(
                table: "Breeds",
                keyColumn: "Id",
                keyValue: 55,
                column: "CreatedTime",
                value: new DateTime(2024, 8, 21, 22, 20, 49, 713, DateTimeKind.Local).AddTicks(7109));

            migrationBuilder.UpdateData(
                table: "Breeds",
                keyColumn: "Id",
                keyValue: 56,
                column: "CreatedTime",
                value: new DateTime(2024, 8, 21, 22, 20, 49, 713, DateTimeKind.Local).AddTicks(7110));

            migrationBuilder.UpdateData(
                table: "Breeds",
                keyColumn: "Id",
                keyValue: 57,
                column: "CreatedTime",
                value: new DateTime(2024, 8, 21, 22, 20, 49, 713, DateTimeKind.Local).AddTicks(7112));

            migrationBuilder.UpdateData(
                table: "Breeds",
                keyColumn: "Id",
                keyValue: 58,
                column: "CreatedTime",
                value: new DateTime(2024, 8, 21, 22, 20, 49, 713, DateTimeKind.Local).AddTicks(7114));

            migrationBuilder.UpdateData(
                table: "Breeds",
                keyColumn: "Id",
                keyValue: 59,
                column: "CreatedTime",
                value: new DateTime(2024, 8, 21, 22, 20, 49, 713, DateTimeKind.Local).AddTicks(7115));

            migrationBuilder.UpdateData(
                table: "Breeds",
                keyColumn: "Id",
                keyValue: 60,
                column: "CreatedTime",
                value: new DateTime(2024, 8, 21, 22, 20, 49, 713, DateTimeKind.Local).AddTicks(7116));

            migrationBuilder.UpdateData(
                table: "Breeds",
                keyColumn: "Id",
                keyValue: 61,
                column: "CreatedTime",
                value: new DateTime(2024, 8, 21, 22, 20, 49, 713, DateTimeKind.Local).AddTicks(7118));

            migrationBuilder.UpdateData(
                table: "Breeds",
                keyColumn: "Id",
                keyValue: 62,
                column: "CreatedTime",
                value: new DateTime(2024, 8, 21, 22, 20, 49, 713, DateTimeKind.Local).AddTicks(7119));

            migrationBuilder.UpdateData(
                table: "Breeds",
                keyColumn: "Id",
                keyValue: 63,
                column: "CreatedTime",
                value: new DateTime(2024, 8, 21, 22, 20, 49, 713, DateTimeKind.Local).AddTicks(7121));

            migrationBuilder.UpdateData(
                table: "Breeds",
                keyColumn: "Id",
                keyValue: 64,
                column: "CreatedTime",
                value: new DateTime(2024, 8, 21, 22, 20, 49, 713, DateTimeKind.Local).AddTicks(7122));

            migrationBuilder.UpdateData(
                table: "Breeds",
                keyColumn: "Id",
                keyValue: 65,
                column: "CreatedTime",
                value: new DateTime(2024, 8, 21, 22, 20, 49, 713, DateTimeKind.Local).AddTicks(7123));

            migrationBuilder.UpdateData(
                table: "Breeds",
                keyColumn: "Id",
                keyValue: 66,
                column: "CreatedTime",
                value: new DateTime(2024, 8, 21, 22, 20, 49, 713, DateTimeKind.Local).AddTicks(7125));

            migrationBuilder.UpdateData(
                table: "Breeds",
                keyColumn: "Id",
                keyValue: 67,
                column: "CreatedTime",
                value: new DateTime(2024, 8, 21, 22, 20, 49, 713, DateTimeKind.Local).AddTicks(7126));

            migrationBuilder.UpdateData(
                table: "Breeds",
                keyColumn: "Id",
                keyValue: 68,
                column: "CreatedTime",
                value: new DateTime(2024, 8, 21, 22, 20, 49, 713, DateTimeKind.Local).AddTicks(7128));

            migrationBuilder.UpdateData(
                table: "Breeds",
                keyColumn: "Id",
                keyValue: 69,
                column: "CreatedTime",
                value: new DateTime(2024, 8, 21, 22, 20, 49, 713, DateTimeKind.Local).AddTicks(7129));

            migrationBuilder.UpdateData(
                table: "Breeds",
                keyColumn: "Id",
                keyValue: 70,
                column: "CreatedTime",
                value: new DateTime(2024, 8, 21, 22, 20, 49, 713, DateTimeKind.Local).AddTicks(7130));

            migrationBuilder.UpdateData(
                table: "Breeds",
                keyColumn: "Id",
                keyValue: 71,
                column: "CreatedTime",
                value: new DateTime(2024, 8, 21, 22, 20, 49, 713, DateTimeKind.Local).AddTicks(7132));

            migrationBuilder.UpdateData(
                table: "Breeds",
                keyColumn: "Id",
                keyValue: 72,
                column: "CreatedTime",
                value: new DateTime(2024, 8, 21, 22, 20, 49, 713, DateTimeKind.Local).AddTicks(7133));

            migrationBuilder.UpdateData(
                table: "Breeds",
                keyColumn: "Id",
                keyValue: 73,
                column: "CreatedTime",
                value: new DateTime(2024, 8, 21, 22, 20, 49, 713, DateTimeKind.Local).AddTicks(7135));

            migrationBuilder.UpdateData(
                table: "Breeds",
                keyColumn: "Id",
                keyValue: 74,
                column: "CreatedTime",
                value: new DateTime(2024, 8, 21, 22, 20, 49, 713, DateTimeKind.Local).AddTicks(7136));

            migrationBuilder.UpdateData(
                table: "Breeds",
                keyColumn: "Id",
                keyValue: 75,
                column: "CreatedTime",
                value: new DateTime(2024, 8, 21, 22, 20, 49, 713, DateTimeKind.Local).AddTicks(7137));

            migrationBuilder.UpdateData(
                table: "Breeds",
                keyColumn: "Id",
                keyValue: 76,
                column: "CreatedTime",
                value: new DateTime(2024, 8, 21, 22, 20, 49, 713, DateTimeKind.Local).AddTicks(7139));

            migrationBuilder.UpdateData(
                table: "Breeds",
                keyColumn: "Id",
                keyValue: 77,
                column: "CreatedTime",
                value: new DateTime(2024, 8, 21, 22, 20, 49, 713, DateTimeKind.Local).AddTicks(7140));

            migrationBuilder.UpdateData(
                table: "Breeds",
                keyColumn: "Id",
                keyValue: 78,
                column: "CreatedTime",
                value: new DateTime(2024, 8, 21, 22, 20, 49, 713, DateTimeKind.Local).AddTicks(7142));

            migrationBuilder.UpdateData(
                table: "Breeds",
                keyColumn: "Id",
                keyValue: 79,
                column: "CreatedTime",
                value: new DateTime(2024, 8, 21, 22, 20, 49, 713, DateTimeKind.Local).AddTicks(7143));

            migrationBuilder.UpdateData(
                table: "Breeds",
                keyColumn: "Id",
                keyValue: 80,
                column: "CreatedTime",
                value: new DateTime(2024, 8, 21, 22, 20, 49, 713, DateTimeKind.Local).AddTicks(7144));

            migrationBuilder.UpdateData(
                table: "Breeds",
                keyColumn: "Id",
                keyValue: 81,
                column: "CreatedTime",
                value: new DateTime(2024, 8, 21, 22, 20, 49, 713, DateTimeKind.Local).AddTicks(7146));

            migrationBuilder.UpdateData(
                table: "Breeds",
                keyColumn: "Id",
                keyValue: 82,
                column: "CreatedTime",
                value: new DateTime(2024, 8, 21, 22, 20, 49, 713, DateTimeKind.Local).AddTicks(7147));

            migrationBuilder.UpdateData(
                table: "Breeds",
                keyColumn: "Id",
                keyValue: 83,
                column: "CreatedTime",
                value: new DateTime(2024, 8, 21, 22, 20, 49, 713, DateTimeKind.Local).AddTicks(7149));

            migrationBuilder.UpdateData(
                table: "Breeds",
                keyColumn: "Id",
                keyValue: 84,
                column: "CreatedTime",
                value: new DateTime(2024, 8, 21, 22, 20, 49, 713, DateTimeKind.Local).AddTicks(7150));

            migrationBuilder.UpdateData(
                table: "Breeds",
                keyColumn: "Id",
                keyValue: 85,
                column: "CreatedTime",
                value: new DateTime(2024, 8, 21, 22, 20, 49, 713, DateTimeKind.Local).AddTicks(7151));

            migrationBuilder.UpdateData(
                table: "Breeds",
                keyColumn: "Id",
                keyValue: 86,
                column: "CreatedTime",
                value: new DateTime(2024, 8, 21, 22, 20, 49, 713, DateTimeKind.Local).AddTicks(7154));

            migrationBuilder.UpdateData(
                table: "Breeds",
                keyColumn: "Id",
                keyValue: 87,
                column: "CreatedTime",
                value: new DateTime(2024, 8, 21, 22, 20, 49, 713, DateTimeKind.Local).AddTicks(7155));

            migrationBuilder.UpdateData(
                table: "Breeds",
                keyColumn: "Id",
                keyValue: 88,
                column: "CreatedTime",
                value: new DateTime(2024, 8, 21, 22, 20, 49, 713, DateTimeKind.Local).AddTicks(7156));

            migrationBuilder.UpdateData(
                table: "Breeds",
                keyColumn: "Id",
                keyValue: 89,
                column: "CreatedTime",
                value: new DateTime(2024, 8, 21, 22, 20, 49, 713, DateTimeKind.Local).AddTicks(7158));

            migrationBuilder.UpdateData(
                table: "Breeds",
                keyColumn: "Id",
                keyValue: 90,
                column: "CreatedTime",
                value: new DateTime(2024, 8, 21, 22, 20, 49, 713, DateTimeKind.Local).AddTicks(7159));

            migrationBuilder.UpdateData(
                table: "Breeds",
                keyColumn: "Id",
                keyValue: 91,
                column: "CreatedTime",
                value: new DateTime(2024, 8, 21, 22, 20, 49, 713, DateTimeKind.Local).AddTicks(7160));

            migrationBuilder.UpdateData(
                table: "Breeds",
                keyColumn: "Id",
                keyValue: 92,
                column: "CreatedTime",
                value: new DateTime(2024, 8, 21, 22, 20, 49, 713, DateTimeKind.Local).AddTicks(7162));

            migrationBuilder.UpdateData(
                table: "Breeds",
                keyColumn: "Id",
                keyValue: 93,
                column: "CreatedTime",
                value: new DateTime(2024, 8, 21, 22, 20, 49, 713, DateTimeKind.Local).AddTicks(7163));

            migrationBuilder.UpdateData(
                table: "Breeds",
                keyColumn: "Id",
                keyValue: 94,
                column: "CreatedTime",
                value: new DateTime(2024, 8, 21, 22, 20, 49, 713, DateTimeKind.Local).AddTicks(7165));

            migrationBuilder.UpdateData(
                table: "Breeds",
                keyColumn: "Id",
                keyValue: 95,
                column: "CreatedTime",
                value: new DateTime(2024, 8, 21, 22, 20, 49, 713, DateTimeKind.Local).AddTicks(7166));

            migrationBuilder.UpdateData(
                table: "Breeds",
                keyColumn: "Id",
                keyValue: 96,
                column: "CreatedTime",
                value: new DateTime(2024, 8, 21, 22, 20, 49, 713, DateTimeKind.Local).AddTicks(7167));

            migrationBuilder.UpdateData(
                table: "Breeds",
                keyColumn: "Id",
                keyValue: 97,
                column: "CreatedTime",
                value: new DateTime(2024, 8, 21, 22, 20, 49, 713, DateTimeKind.Local).AddTicks(7169));

            migrationBuilder.UpdateData(
                table: "Breeds",
                keyColumn: "Id",
                keyValue: 98,
                column: "CreatedTime",
                value: new DateTime(2024, 8, 21, 22, 20, 49, 713, DateTimeKind.Local).AddTicks(7170));

            migrationBuilder.UpdateData(
                table: "Breeds",
                keyColumn: "Id",
                keyValue: 99,
                column: "CreatedTime",
                value: new DateTime(2024, 8, 21, 22, 20, 49, 713, DateTimeKind.Local).AddTicks(7172));

            migrationBuilder.UpdateData(
                table: "Breeds",
                keyColumn: "Id",
                keyValue: 100,
                column: "CreatedTime",
                value: new DateTime(2024, 8, 21, 22, 20, 49, 713, DateTimeKind.Local).AddTicks(7173));

            migrationBuilder.UpdateData(
                table: "Breeds",
                keyColumn: "Id",
                keyValue: 101,
                column: "CreatedTime",
                value: new DateTime(2024, 8, 21, 22, 20, 49, 713, DateTimeKind.Local).AddTicks(7175));

            migrationBuilder.UpdateData(
                table: "Breeds",
                keyColumn: "Id",
                keyValue: 102,
                column: "CreatedTime",
                value: new DateTime(2024, 8, 21, 22, 20, 49, 713, DateTimeKind.Local).AddTicks(7176));

            migrationBuilder.UpdateData(
                table: "Breeds",
                keyColumn: "Id",
                keyValue: 103,
                column: "CreatedTime",
                value: new DateTime(2024, 8, 21, 22, 20, 49, 713, DateTimeKind.Local).AddTicks(7177));

            migrationBuilder.UpdateData(
                table: "Breeds",
                keyColumn: "Id",
                keyValue: 104,
                column: "CreatedTime",
                value: new DateTime(2024, 8, 21, 22, 20, 49, 713, DateTimeKind.Local).AddTicks(7179));

            migrationBuilder.UpdateData(
                table: "Breeds",
                keyColumn: "Id",
                keyValue: 105,
                column: "CreatedTime",
                value: new DateTime(2024, 8, 21, 22, 20, 49, 713, DateTimeKind.Local).AddTicks(7180));

            migrationBuilder.UpdateData(
                table: "Breeds",
                keyColumn: "Id",
                keyValue: 106,
                column: "CreatedTime",
                value: new DateTime(2024, 8, 21, 22, 20, 49, 713, DateTimeKind.Local).AddTicks(7182));

            migrationBuilder.UpdateData(
                table: "Breeds",
                keyColumn: "Id",
                keyValue: 107,
                column: "CreatedTime",
                value: new DateTime(2024, 8, 21, 22, 20, 49, 713, DateTimeKind.Local).AddTicks(7183));

            migrationBuilder.UpdateData(
                table: "Breeds",
                keyColumn: "Id",
                keyValue: 108,
                column: "CreatedTime",
                value: new DateTime(2024, 8, 21, 22, 20, 49, 713, DateTimeKind.Local).AddTicks(7184));

            migrationBuilder.UpdateData(
                table: "Breeds",
                keyColumn: "Id",
                keyValue: 109,
                column: "CreatedTime",
                value: new DateTime(2024, 8, 21, 22, 20, 49, 713, DateTimeKind.Local).AddTicks(7186));

            migrationBuilder.UpdateData(
                table: "Breeds",
                keyColumn: "Id",
                keyValue: 110,
                column: "CreatedTime",
                value: new DateTime(2024, 8, 21, 22, 20, 49, 713, DateTimeKind.Local).AddTicks(7187));

            migrationBuilder.UpdateData(
                table: "Breeds",
                keyColumn: "Id",
                keyValue: 111,
                column: "CreatedTime",
                value: new DateTime(2024, 8, 21, 22, 20, 49, 713, DateTimeKind.Local).AddTicks(7188));

            migrationBuilder.UpdateData(
                table: "Breeds",
                keyColumn: "Id",
                keyValue: 112,
                column: "CreatedTime",
                value: new DateTime(2024, 8, 21, 22, 20, 49, 713, DateTimeKind.Local).AddTicks(7190));

            migrationBuilder.UpdateData(
                table: "Breeds",
                keyColumn: "Id",
                keyValue: 113,
                column: "CreatedTime",
                value: new DateTime(2024, 8, 21, 22, 20, 49, 713, DateTimeKind.Local).AddTicks(7191));

            migrationBuilder.UpdateData(
                table: "Breeds",
                keyColumn: "Id",
                keyValue: 114,
                column: "CreatedTime",
                value: new DateTime(2024, 8, 21, 22, 20, 49, 713, DateTimeKind.Local).AddTicks(7193));

            migrationBuilder.UpdateData(
                table: "Breeds",
                keyColumn: "Id",
                keyValue: 115,
                column: "CreatedTime",
                value: new DateTime(2024, 8, 21, 22, 20, 49, 713, DateTimeKind.Local).AddTicks(7197));

            migrationBuilder.UpdateData(
                table: "Breeds",
                keyColumn: "Id",
                keyValue: 116,
                column: "CreatedTime",
                value: new DateTime(2024, 8, 21, 22, 20, 49, 713, DateTimeKind.Local).AddTicks(7198));

            migrationBuilder.UpdateData(
                table: "Breeds",
                keyColumn: "Id",
                keyValue: 117,
                column: "CreatedTime",
                value: new DateTime(2024, 8, 21, 22, 20, 49, 713, DateTimeKind.Local).AddTicks(7200));

            migrationBuilder.UpdateData(
                table: "Breeds",
                keyColumn: "Id",
                keyValue: 118,
                column: "CreatedTime",
                value: new DateTime(2024, 8, 21, 22, 20, 49, 713, DateTimeKind.Local).AddTicks(7202));

            migrationBuilder.UpdateData(
                table: "Breeds",
                keyColumn: "Id",
                keyValue: 119,
                column: "CreatedTime",
                value: new DateTime(2024, 8, 21, 22, 20, 49, 713, DateTimeKind.Local).AddTicks(7203));

            migrationBuilder.UpdateData(
                table: "Breeds",
                keyColumn: "Id",
                keyValue: 120,
                column: "CreatedTime",
                value: new DateTime(2024, 8, 21, 22, 20, 49, 713, DateTimeKind.Local).AddTicks(7205));

            migrationBuilder.UpdateData(
                table: "Breeds",
                keyColumn: "Id",
                keyValue: 121,
                column: "CreatedTime",
                value: new DateTime(2024, 8, 21, 22, 20, 49, 713, DateTimeKind.Local).AddTicks(7206));

            migrationBuilder.UpdateData(
                table: "Breeds",
                keyColumn: "Id",
                keyValue: 122,
                column: "CreatedTime",
                value: new DateTime(2024, 8, 21, 22, 20, 49, 713, DateTimeKind.Local).AddTicks(7207));

            migrationBuilder.UpdateData(
                table: "Breeds",
                keyColumn: "Id",
                keyValue: 123,
                column: "CreatedTime",
                value: new DateTime(2024, 8, 21, 22, 20, 49, 713, DateTimeKind.Local).AddTicks(7209));

            migrationBuilder.UpdateData(
                table: "Breeds",
                keyColumn: "Id",
                keyValue: 124,
                column: "CreatedTime",
                value: new DateTime(2024, 8, 21, 22, 20, 49, 713, DateTimeKind.Local).AddTicks(7210));

            migrationBuilder.UpdateData(
                table: "Breeds",
                keyColumn: "Id",
                keyValue: 125,
                column: "CreatedTime",
                value: new DateTime(2024, 8, 21, 22, 20, 49, 713, DateTimeKind.Local).AddTicks(7211));

            migrationBuilder.UpdateData(
                table: "Breeds",
                keyColumn: "Id",
                keyValue: 126,
                column: "CreatedTime",
                value: new DateTime(2024, 8, 21, 22, 20, 49, 713, DateTimeKind.Local).AddTicks(7213));

            migrationBuilder.UpdateData(
                table: "Breeds",
                keyColumn: "Id",
                keyValue: 127,
                column: "CreatedTime",
                value: new DateTime(2024, 8, 21, 22, 20, 49, 713, DateTimeKind.Local).AddTicks(7214));

            migrationBuilder.UpdateData(
                table: "Breeds",
                keyColumn: "Id",
                keyValue: 128,
                column: "CreatedTime",
                value: new DateTime(2024, 8, 21, 22, 20, 49, 713, DateTimeKind.Local).AddTicks(7215));

            migrationBuilder.UpdateData(
                table: "Breeds",
                keyColumn: "Id",
                keyValue: 129,
                column: "CreatedTime",
                value: new DateTime(2024, 8, 21, 22, 20, 49, 713, DateTimeKind.Local).AddTicks(7217));

            migrationBuilder.UpdateData(
                table: "Breeds",
                keyColumn: "Id",
                keyValue: 130,
                column: "CreatedTime",
                value: new DateTime(2024, 8, 21, 22, 20, 49, 713, DateTimeKind.Local).AddTicks(7218));

            migrationBuilder.UpdateData(
                table: "Breeds",
                keyColumn: "Id",
                keyValue: 131,
                column: "CreatedTime",
                value: new DateTime(2024, 8, 21, 22, 20, 49, 713, DateTimeKind.Local).AddTicks(7220));

            migrationBuilder.UpdateData(
                table: "Breeds",
                keyColumn: "Id",
                keyValue: 132,
                column: "CreatedTime",
                value: new DateTime(2024, 8, 21, 22, 20, 49, 713, DateTimeKind.Local).AddTicks(7221));

            migrationBuilder.UpdateData(
                table: "Breeds",
                keyColumn: "Id",
                keyValue: 133,
                column: "CreatedTime",
                value: new DateTime(2024, 8, 21, 22, 20, 49, 713, DateTimeKind.Local).AddTicks(7223));

            migrationBuilder.UpdateData(
                table: "Breeds",
                keyColumn: "Id",
                keyValue: 134,
                column: "CreatedTime",
                value: new DateTime(2024, 8, 21, 22, 20, 49, 713, DateTimeKind.Local).AddTicks(7224));

            migrationBuilder.UpdateData(
                table: "Breeds",
                keyColumn: "Id",
                keyValue: 135,
                column: "CreatedTime",
                value: new DateTime(2024, 8, 21, 22, 20, 49, 713, DateTimeKind.Local).AddTicks(7226));

            migrationBuilder.UpdateData(
                table: "Breeds",
                keyColumn: "Id",
                keyValue: 136,
                column: "CreatedTime",
                value: new DateTime(2024, 8, 21, 22, 20, 49, 713, DateTimeKind.Local).AddTicks(7227));

            migrationBuilder.UpdateData(
                table: "Breeds",
                keyColumn: "Id",
                keyValue: 137,
                column: "CreatedTime",
                value: new DateTime(2024, 8, 21, 22, 20, 49, 713, DateTimeKind.Local).AddTicks(7228));

            migrationBuilder.UpdateData(
                table: "Breeds",
                keyColumn: "Id",
                keyValue: 138,
                column: "CreatedTime",
                value: new DateTime(2024, 8, 21, 22, 20, 49, 713, DateTimeKind.Local).AddTicks(7230));

            migrationBuilder.UpdateData(
                table: "Breeds",
                keyColumn: "Id",
                keyValue: 139,
                column: "CreatedTime",
                value: new DateTime(2024, 8, 21, 22, 20, 49, 713, DateTimeKind.Local).AddTicks(7231));

            migrationBuilder.UpdateData(
                table: "Breeds",
                keyColumn: "Id",
                keyValue: 140,
                column: "CreatedTime",
                value: new DateTime(2024, 8, 21, 22, 20, 49, 713, DateTimeKind.Local).AddTicks(7233));

            migrationBuilder.UpdateData(
                table: "Breeds",
                keyColumn: "Id",
                keyValue: 141,
                column: "CreatedTime",
                value: new DateTime(2024, 8, 21, 22, 20, 49, 713, DateTimeKind.Local).AddTicks(7234));

            migrationBuilder.UpdateData(
                table: "Breeds",
                keyColumn: "Id",
                keyValue: 142,
                column: "CreatedTime",
                value: new DateTime(2024, 8, 21, 22, 20, 49, 713, DateTimeKind.Local).AddTicks(7235));

            migrationBuilder.UpdateData(
                table: "Breeds",
                keyColumn: "Id",
                keyValue: 143,
                column: "CreatedTime",
                value: new DateTime(2024, 8, 21, 22, 20, 49, 713, DateTimeKind.Local).AddTicks(7236));

            migrationBuilder.UpdateData(
                table: "Breeds",
                keyColumn: "Id",
                keyValue: 144,
                column: "CreatedTime",
                value: new DateTime(2024, 8, 21, 22, 20, 49, 713, DateTimeKind.Local).AddTicks(7238));

            migrationBuilder.UpdateData(
                table: "Breeds",
                keyColumn: "Id",
                keyValue: 145,
                column: "CreatedTime",
                value: new DateTime(2024, 8, 21, 22, 20, 49, 713, DateTimeKind.Local).AddTicks(7239));

            migrationBuilder.UpdateData(
                table: "Breeds",
                keyColumn: "Id",
                keyValue: 146,
                column: "CreatedTime",
                value: new DateTime(2024, 8, 21, 22, 20, 49, 713, DateTimeKind.Local).AddTicks(7241));

            migrationBuilder.UpdateData(
                table: "Breeds",
                keyColumn: "Id",
                keyValue: 147,
                column: "CreatedTime",
                value: new DateTime(2024, 8, 21, 22, 20, 49, 713, DateTimeKind.Local).AddTicks(7242));

            migrationBuilder.UpdateData(
                table: "Breeds",
                keyColumn: "Id",
                keyValue: 148,
                column: "CreatedTime",
                value: new DateTime(2024, 8, 21, 22, 20, 49, 713, DateTimeKind.Local).AddTicks(7243));

            migrationBuilder.UpdateData(
                table: "Breeds",
                keyColumn: "Id",
                keyValue: 149,
                column: "CreatedTime",
                value: new DateTime(2024, 8, 21, 22, 20, 49, 713, DateTimeKind.Local).AddTicks(7245));

            migrationBuilder.UpdateData(
                table: "Breeds",
                keyColumn: "Id",
                keyValue: 150,
                column: "CreatedTime",
                value: new DateTime(2024, 8, 21, 22, 20, 49, 713, DateTimeKind.Local).AddTicks(7246));

            migrationBuilder.UpdateData(
                table: "Breeds",
                keyColumn: "Id",
                keyValue: 151,
                column: "CreatedTime",
                value: new DateTime(2024, 8, 21, 22, 20, 49, 713, DateTimeKind.Local).AddTicks(7247));

            migrationBuilder.UpdateData(
                table: "Breeds",
                keyColumn: "Id",
                keyValue: 152,
                column: "CreatedTime",
                value: new DateTime(2024, 8, 21, 22, 20, 49, 713, DateTimeKind.Local).AddTicks(7249));

            migrationBuilder.UpdateData(
                table: "Breeds",
                keyColumn: "Id",
                keyValue: 153,
                column: "CreatedTime",
                value: new DateTime(2024, 8, 21, 22, 20, 49, 713, DateTimeKind.Local).AddTicks(7250));

            migrationBuilder.UpdateData(
                table: "Breeds",
                keyColumn: "Id",
                keyValue: 154,
                column: "CreatedTime",
                value: new DateTime(2024, 8, 21, 22, 20, 49, 713, DateTimeKind.Local).AddTicks(7252));

            migrationBuilder.UpdateData(
                table: "Breeds",
                keyColumn: "Id",
                keyValue: 155,
                column: "CreatedTime",
                value: new DateTime(2024, 8, 21, 22, 20, 49, 713, DateTimeKind.Local).AddTicks(7253));

            migrationBuilder.UpdateData(
                table: "Breeds",
                keyColumn: "Id",
                keyValue: 156,
                column: "CreatedTime",
                value: new DateTime(2024, 8, 21, 22, 20, 49, 713, DateTimeKind.Local).AddTicks(7254));

            migrationBuilder.UpdateData(
                table: "Breeds",
                keyColumn: "Id",
                keyValue: 157,
                column: "CreatedTime",
                value: new DateTime(2024, 8, 21, 22, 20, 49, 713, DateTimeKind.Local).AddTicks(7277));

            migrationBuilder.UpdateData(
                table: "Breeds",
                keyColumn: "Id",
                keyValue: 158,
                column: "CreatedTime",
                value: new DateTime(2024, 8, 21, 22, 20, 49, 713, DateTimeKind.Local).AddTicks(7279));

            migrationBuilder.UpdateData(
                table: "Breeds",
                keyColumn: "Id",
                keyValue: 159,
                column: "CreatedTime",
                value: new DateTime(2024, 8, 21, 22, 20, 49, 713, DateTimeKind.Local).AddTicks(7280));

            migrationBuilder.UpdateData(
                table: "Breeds",
                keyColumn: "Id",
                keyValue: 160,
                column: "CreatedTime",
                value: new DateTime(2024, 8, 21, 22, 20, 49, 713, DateTimeKind.Local).AddTicks(7283));

            migrationBuilder.UpdateData(
                table: "PetTypes",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedTime",
                value: new DateTime(2024, 8, 21, 22, 20, 49, 713, DateTimeKind.Local).AddTicks(4181));

            migrationBuilder.UpdateData(
                table: "PetTypes",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreatedTime",
                value: new DateTime(2024, 8, 21, 22, 20, 49, 713, DateTimeKind.Local).AddTicks(4241));

            migrationBuilder.UpdateData(
                table: "PetTypes",
                keyColumn: "Id",
                keyValue: 3,
                column: "CreatedTime",
                value: new DateTime(2024, 8, 21, 22, 20, 49, 713, DateTimeKind.Local).AddTicks(4243));

            migrationBuilder.UpdateData(
                table: "PetTypes",
                keyColumn: "Id",
                keyValue: 4,
                column: "CreatedTime",
                value: new DateTime(2024, 8, 21, 22, 20, 49, 713, DateTimeKind.Local).AddTicks(4245));

            migrationBuilder.UpdateData(
                table: "PetTypes",
                keyColumn: "Id",
                keyValue: 5,
                column: "CreatedTime",
                value: new DateTime(2024, 8, 21, 22, 20, 49, 713, DateTimeKind.Local).AddTicks(4246));

            migrationBuilder.UpdateData(
                table: "PetTypes",
                keyColumn: "Id",
                keyValue: 6,
                column: "CreatedTime",
                value: new DateTime(2024, 8, 21, 22, 20, 49, 713, DateTimeKind.Local).AddTicks(4248));

            migrationBuilder.UpdateData(
                table: "PetTypes",
                keyColumn: "Id",
                keyValue: 7,
                column: "CreatedTime",
                value: new DateTime(2024, 8, 21, 22, 20, 49, 713, DateTimeKind.Local).AddTicks(4249));

            migrationBuilder.UpdateData(
                table: "PetTypes",
                keyColumn: "Id",
                keyValue: 8,
                column: "CreatedTime",
                value: new DateTime(2024, 8, 21, 22, 20, 49, 713, DateTimeKind.Local).AddTicks(4250));
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "City",
                table: "Shelters");

            migrationBuilder.DropColumn(
                name: "Street",
                table: "Shelters");

            migrationBuilder.CreateTable(
                name: "Locations",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    ShelterId = table.Column<int>(type: "int", nullable: false),
                    City = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    CreatedTime = table.Column<DateTime>(type: "datetime2", nullable: false),
                    IsDeleted = table.Column<bool>(type: "bit", nullable: false),
                    LastUpdatedTime = table.Column<DateTime>(type: "datetime2", nullable: false),
                    Street = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Locations", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Locations_Shelters_ShelterId",
                        column: x => x.ShelterId,
                        principalTable: "Shelters",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                });

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

            migrationBuilder.CreateIndex(
                name: "IX_Locations_ShelterId",
                table: "Locations",
                column: "ShelterId",
                unique: true);
        }
    }
}
