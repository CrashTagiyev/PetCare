using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Persistance.Migrations
{
    /// <inheritdoc />
    public partial class randomusercreatedtimeMigration : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: 2001,
                columns: new[] { "ConcurrencyStamp", "CreatedTime", "LastUpdatedTime", "RefreshTokenCreateTime" },
                values: new object[] { "16c47610-00d9-4508-933f-6818d91f973f", new DateTime(2024, 5, 3, 10, 46, 33, 392, DateTimeKind.Utc).AddTicks(4114), new DateTime(2024, 9, 3, 10, 46, 33, 392, DateTimeKind.Utc).AddTicks(4121), new DateTime(2024, 9, 3, 10, 46, 33, 392, DateTimeKind.Utc).AddTicks(4108) });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: 2002,
                columns: new[] { "ConcurrencyStamp", "CreatedTime", "LastUpdatedTime", "RefreshTokenCreateTime" },
                values: new object[] { "2b565888-8677-4973-bb20-709b22fa2b1b", new DateTime(2024, 1, 3, 10, 46, 33, 392, DateTimeKind.Utc).AddTicks(4146), new DateTime(2024, 9, 3, 10, 46, 33, 392, DateTimeKind.Utc).AddTicks(4147), new DateTime(2024, 9, 3, 10, 46, 33, 392, DateTimeKind.Utc).AddTicks(4142) });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: 2003,
                columns: new[] { "ConcurrencyStamp", "CreatedTime", "LastUpdatedTime", "RefreshTokenCreateTime" },
                values: new object[] { "ece9f981-875c-4a33-8ee9-391bee693e5f", new DateTime(2024, 5, 3, 10, 46, 33, 392, DateTimeKind.Utc).AddTicks(4172), new DateTime(2024, 9, 3, 10, 46, 33, 392, DateTimeKind.Utc).AddTicks(4172), new DateTime(2024, 9, 3, 10, 46, 33, 392, DateTimeKind.Utc).AddTicks(4156) });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: 2004,
                columns: new[] { "ConcurrencyStamp", "CreatedTime", "LastUpdatedTime", "RefreshTokenCreateTime" },
                values: new object[] { "3d31ad6d-e3b5-495c-8ce4-e2cb44628adc", new DateTime(2024, 6, 3, 10, 46, 33, 392, DateTimeKind.Utc).AddTicks(4185), new DateTime(2024, 9, 3, 10, 46, 33, 392, DateTimeKind.Utc).AddTicks(4186), new DateTime(2024, 9, 3, 10, 46, 33, 392, DateTimeKind.Utc).AddTicks(4181) });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: 2005,
                columns: new[] { "ConcurrencyStamp", "CreatedTime", "LastUpdatedTime", "RefreshTokenCreateTime" },
                values: new object[] { "4fc5ed6e-6fa7-4c6a-8458-de5e31fa52e4", new DateTime(2023, 12, 3, 10, 46, 33, 392, DateTimeKind.Utc).AddTicks(4201), new DateTime(2024, 9, 3, 10, 46, 33, 392, DateTimeKind.Utc).AddTicks(4202), new DateTime(2024, 9, 3, 10, 46, 33, 392, DateTimeKind.Utc).AddTicks(4197) });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: 2006,
                columns: new[] { "ConcurrencyStamp", "CreatedTime", "LastUpdatedTime", "RefreshTokenCreateTime" },
                values: new object[] { "8b94c5f1-2f77-4ff9-9bb6-f045ce188951", new DateTime(2024, 8, 3, 10, 46, 33, 392, DateTimeKind.Utc).AddTicks(4214), new DateTime(2024, 9, 3, 10, 46, 33, 392, DateTimeKind.Utc).AddTicks(4215), new DateTime(2024, 9, 3, 10, 46, 33, 392, DateTimeKind.Utc).AddTicks(4210) });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: 2007,
                columns: new[] { "ConcurrencyStamp", "CreatedTime", "LastUpdatedTime", "RefreshTokenCreateTime" },
                values: new object[] { "dc92ffa8-b64f-4ded-9800-7f2b9db213bc", new DateTime(2024, 3, 3, 10, 46, 33, 392, DateTimeKind.Utc).AddTicks(4262), new DateTime(2024, 9, 3, 10, 46, 33, 392, DateTimeKind.Utc).AddTicks(4263), new DateTime(2024, 9, 3, 10, 46, 33, 392, DateTimeKind.Utc).AddTicks(4223) });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: 2008,
                columns: new[] { "ConcurrencyStamp", "CreatedTime", "LastUpdatedTime", "RefreshTokenCreateTime" },
                values: new object[] { "db24b6f1-9883-45d2-a859-59a7b155768c", new DateTime(2024, 3, 3, 10, 46, 33, 392, DateTimeKind.Utc).AddTicks(4276), new DateTime(2024, 9, 3, 10, 46, 33, 392, DateTimeKind.Utc).AddTicks(4277), new DateTime(2024, 9, 3, 10, 46, 33, 392, DateTimeKind.Utc).AddTicks(4273) });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: 2009,
                columns: new[] { "ConcurrencyStamp", "CreatedTime", "LastUpdatedTime", "RefreshTokenCreateTime" },
                values: new object[] { "efcb54bc-9208-4d00-a3a0-ad193156d233", new DateTime(2023, 11, 3, 10, 46, 33, 392, DateTimeKind.Utc).AddTicks(4290), new DateTime(2024, 9, 3, 10, 46, 33, 392, DateTimeKind.Utc).AddTicks(4291), new DateTime(2024, 9, 3, 10, 46, 33, 392, DateTimeKind.Utc).AddTicks(4287) });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: 2010,
                columns: new[] { "ConcurrencyStamp", "CreatedTime", "LastUpdatedTime", "RefreshTokenCreateTime" },
                values: new object[] { "8e66da52-a787-451b-accf-db3dc62b0d1b", new DateTime(2024, 1, 3, 10, 46, 33, 392, DateTimeKind.Utc).AddTicks(4302), new DateTime(2024, 9, 3, 10, 46, 33, 392, DateTimeKind.Utc).AddTicks(4303), new DateTime(2024, 9, 3, 10, 46, 33, 392, DateTimeKind.Utc).AddTicks(4299) });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: 2011,
                columns: new[] { "ConcurrencyStamp", "CreatedTime", "LastUpdatedTime", "RefreshTokenCreateTime" },
                values: new object[] { "58dc66a4-292c-48b4-ba3a-6ff1cdd7919e", new DateTime(2024, 6, 3, 10, 46, 33, 392, DateTimeKind.Utc).AddTicks(4321), new DateTime(2024, 9, 3, 10, 46, 33, 392, DateTimeKind.Utc).AddTicks(4322), new DateTime(2024, 9, 3, 10, 46, 33, 392, DateTimeKind.Utc).AddTicks(4314) });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: 2012,
                columns: new[] { "ConcurrencyStamp", "CreatedTime", "LastUpdatedTime", "RefreshTokenCreateTime" },
                values: new object[] { "a4fc318f-248a-404d-9dda-a94d7e40e002", new DateTime(2024, 1, 3, 10, 46, 33, 392, DateTimeKind.Utc).AddTicks(4334), new DateTime(2024, 9, 3, 10, 46, 33, 392, DateTimeKind.Utc).AddTicks(4335), new DateTime(2024, 9, 3, 10, 46, 33, 392, DateTimeKind.Utc).AddTicks(4331) });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: 2013,
                columns: new[] { "ConcurrencyStamp", "CreatedTime", "LastUpdatedTime", "RefreshTokenCreateTime" },
                values: new object[] { "2d2b5d67-edef-4f18-8737-720abe8840a1", new DateTime(2024, 7, 3, 10, 46, 33, 392, DateTimeKind.Utc).AddTicks(4346), new DateTime(2024, 9, 3, 10, 46, 33, 392, DateTimeKind.Utc).AddTicks(4347), new DateTime(2024, 9, 3, 10, 46, 33, 392, DateTimeKind.Utc).AddTicks(4343) });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: 2014,
                columns: new[] { "ConcurrencyStamp", "CreatedTime", "LastUpdatedTime", "RefreshTokenCreateTime" },
                values: new object[] { "776eec37-2d9c-44bf-a85f-a8c30ab28d63", new DateTime(2023, 11, 3, 10, 46, 33, 392, DateTimeKind.Utc).AddTicks(4358), new DateTime(2024, 9, 3, 10, 46, 33, 392, DateTimeKind.Utc).AddTicks(4359), new DateTime(2024, 9, 3, 10, 46, 33, 392, DateTimeKind.Utc).AddTicks(4356) });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: 2015,
                columns: new[] { "ConcurrencyStamp", "CreatedTime", "LastUpdatedTime", "RefreshTokenCreateTime" },
                values: new object[] { "4b31a35a-dcec-4df8-a2eb-2f7aca2fc0a8", new DateTime(2024, 5, 3, 10, 46, 33, 392, DateTimeKind.Utc).AddTicks(4371), new DateTime(2024, 9, 3, 10, 46, 33, 392, DateTimeKind.Utc).AddTicks(4372), new DateTime(2024, 9, 3, 10, 46, 33, 392, DateTimeKind.Utc).AddTicks(4368) });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: 2016,
                columns: new[] { "ConcurrencyStamp", "CreatedTime", "LastUpdatedTime", "RefreshTokenCreateTime" },
                values: new object[] { "27ca5377-bc8e-4304-b4b8-5fc03f1fe17f", new DateTime(2024, 1, 3, 10, 46, 33, 392, DateTimeKind.Utc).AddTicks(4384), new DateTime(2024, 9, 3, 10, 46, 33, 392, DateTimeKind.Utc).AddTicks(4384), new DateTime(2024, 9, 3, 10, 46, 33, 392, DateTimeKind.Utc).AddTicks(4380) });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: 2017,
                columns: new[] { "ConcurrencyStamp", "CreatedTime", "LastUpdatedTime", "RefreshTokenCreateTime" },
                values: new object[] { "a37d58ff-107c-41d3-975a-de48660e781a", new DateTime(2024, 8, 3, 10, 46, 33, 392, DateTimeKind.Utc).AddTicks(4473), new DateTime(2024, 9, 3, 10, 46, 33, 392, DateTimeKind.Utc).AddTicks(4474), new DateTime(2024, 9, 3, 10, 46, 33, 392, DateTimeKind.Utc).AddTicks(4469) });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: 2018,
                columns: new[] { "ConcurrencyStamp", "CreatedTime", "LastUpdatedTime", "RefreshTokenCreateTime" },
                values: new object[] { "59fc30ce-d696-479e-95c1-326b1345ea62", new DateTime(2024, 7, 3, 10, 46, 33, 392, DateTimeKind.Utc).AddTicks(4487), new DateTime(2024, 9, 3, 10, 46, 33, 392, DateTimeKind.Utc).AddTicks(4488), new DateTime(2024, 9, 3, 10, 46, 33, 392, DateTimeKind.Utc).AddTicks(4484) });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: 2019,
                columns: new[] { "ConcurrencyStamp", "CreatedTime", "LastUpdatedTime", "RefreshTokenCreateTime" },
                values: new object[] { "8203d9d6-c29e-4f77-b3c2-36a037f2b4fb", new DateTime(2023, 12, 3, 10, 46, 33, 392, DateTimeKind.Utc).AddTicks(4503), new DateTime(2024, 9, 3, 10, 46, 33, 392, DateTimeKind.Utc).AddTicks(4504), new DateTime(2024, 9, 3, 10, 46, 33, 392, DateTimeKind.Utc).AddTicks(4496) });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: 2020,
                columns: new[] { "ConcurrencyStamp", "CreatedTime", "LastUpdatedTime", "RefreshTokenCreateTime" },
                values: new object[] { "f31dcf1f-3da6-4788-b6b2-b2f4a53497a5", new DateTime(2024, 5, 3, 10, 46, 33, 392, DateTimeKind.Utc).AddTicks(4516), new DateTime(2024, 9, 3, 10, 46, 33, 392, DateTimeKind.Utc).AddTicks(4517), new DateTime(2024, 9, 3, 10, 46, 33, 392, DateTimeKind.Utc).AddTicks(4513) });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: 2021,
                columns: new[] { "ConcurrencyStamp", "CreatedTime", "LastUpdatedTime", "RefreshTokenCreateTime" },
                values: new object[] { "d52f940e-2c4d-4ce4-a8ec-23ac81b82736", new DateTime(2024, 8, 3, 10, 46, 33, 392, DateTimeKind.Utc).AddTicks(4529), new DateTime(2024, 9, 3, 10, 46, 33, 392, DateTimeKind.Utc).AddTicks(4529), new DateTime(2024, 9, 3, 10, 46, 33, 392, DateTimeKind.Utc).AddTicks(4525) });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: 2022,
                columns: new[] { "ConcurrencyStamp", "CreatedTime", "LastUpdatedTime", "RefreshTokenCreateTime" },
                values: new object[] { "62c0681e-d49f-475d-9cc2-613d9a49ae86", new DateTime(2024, 8, 3, 10, 46, 33, 392, DateTimeKind.Utc).AddTicks(4549), new DateTime(2024, 9, 3, 10, 46, 33, 392, DateTimeKind.Utc).AddTicks(4549), new DateTime(2024, 9, 3, 10, 46, 33, 392, DateTimeKind.Utc).AddTicks(4546) });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: 2023,
                columns: new[] { "ConcurrencyStamp", "CreatedTime", "LastUpdatedTime", "RefreshTokenCreateTime" },
                values: new object[] { "9569d356-3012-4e9f-b6d1-a851b5693320", new DateTime(2024, 6, 3, 10, 46, 33, 392, DateTimeKind.Utc).AddTicks(4563), new DateTime(2024, 9, 3, 10, 46, 33, 392, DateTimeKind.Utc).AddTicks(4564), new DateTime(2024, 9, 3, 10, 46, 33, 392, DateTimeKind.Utc).AddTicks(4560) });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: 2024,
                columns: new[] { "ConcurrencyStamp", "CreatedTime", "LastUpdatedTime", "RefreshTokenCreateTime" },
                values: new object[] { "abc17248-eea5-42c9-b883-f5b1e1a2fc73", new DateTime(2023, 11, 3, 10, 46, 33, 392, DateTimeKind.Utc).AddTicks(4577), new DateTime(2024, 9, 3, 10, 46, 33, 392, DateTimeKind.Utc).AddTicks(4578), new DateTime(2024, 9, 3, 10, 46, 33, 392, DateTimeKind.Utc).AddTicks(4573) });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: 2025,
                columns: new[] { "ConcurrencyStamp", "CreatedTime", "LastUpdatedTime", "RefreshTokenCreateTime" },
                values: new object[] { "cca2f988-1799-4ff4-982f-976df7c365e1", new DateTime(2024, 5, 3, 10, 46, 33, 392, DateTimeKind.Utc).AddTicks(4590), new DateTime(2024, 9, 3, 10, 46, 33, 392, DateTimeKind.Utc).AddTicks(4591), new DateTime(2024, 9, 3, 10, 46, 33, 392, DateTimeKind.Utc).AddTicks(4587) });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: 2026,
                columns: new[] { "ConcurrencyStamp", "CreatedTime", "LastUpdatedTime", "RefreshTokenCreateTime" },
                values: new object[] { "d2f28350-527c-44f6-8af9-c54375e77f13", new DateTime(2023, 12, 3, 10, 46, 33, 392, DateTimeKind.Utc).AddTicks(4658), new DateTime(2024, 9, 3, 10, 46, 33, 392, DateTimeKind.Utc).AddTicks(4659), new DateTime(2024, 9, 3, 10, 46, 33, 392, DateTimeKind.Utc).AddTicks(4655) });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: 2027,
                columns: new[] { "ConcurrencyStamp", "CreatedTime", "LastUpdatedTime", "RefreshTokenCreateTime" },
                values: new object[] { "3d1878be-a9fb-4334-a3cb-55d6dec64fc1", new DateTime(2024, 7, 3, 10, 46, 33, 392, DateTimeKind.Utc).AddTicks(4676), new DateTime(2024, 9, 3, 10, 46, 33, 392, DateTimeKind.Utc).AddTicks(4676), new DateTime(2024, 9, 3, 10, 46, 33, 392, DateTimeKind.Utc).AddTicks(4669) });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: 2028,
                columns: new[] { "ConcurrencyStamp", "CreatedTime", "LastUpdatedTime", "RefreshTokenCreateTime" },
                values: new object[] { "7ac9f249-db6c-4f7a-84be-46549a69aab3", new DateTime(2024, 1, 3, 10, 46, 33, 392, DateTimeKind.Utc).AddTicks(4690), new DateTime(2024, 9, 3, 10, 46, 33, 392, DateTimeKind.Utc).AddTicks(4691), new DateTime(2024, 9, 3, 10, 46, 33, 392, DateTimeKind.Utc).AddTicks(4686) });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: 2029,
                columns: new[] { "ConcurrencyStamp", "CreatedTime", "LastUpdatedTime", "RefreshTokenCreateTime" },
                values: new object[] { "60e30022-2b3c-4f0c-be6e-d68f11f37b34", new DateTime(2024, 1, 3, 10, 46, 33, 392, DateTimeKind.Utc).AddTicks(4703), new DateTime(2024, 9, 3, 10, 46, 33, 392, DateTimeKind.Utc).AddTicks(4704), new DateTime(2024, 9, 3, 10, 46, 33, 392, DateTimeKind.Utc).AddTicks(4700) });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: 2030,
                columns: new[] { "ConcurrencyStamp", "CreatedTime", "LastUpdatedTime", "RefreshTokenCreateTime" },
                values: new object[] { "43f9184d-0fdb-4599-9766-5e1b10cc63e3", new DateTime(2024, 6, 3, 10, 46, 33, 392, DateTimeKind.Utc).AddTicks(4716), new DateTime(2024, 9, 3, 10, 46, 33, 392, DateTimeKind.Utc).AddTicks(4717), new DateTime(2024, 9, 3, 10, 46, 33, 392, DateTimeKind.Utc).AddTicks(4713) });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: 2031,
                columns: new[] { "ConcurrencyStamp", "CreatedTime", "LastUpdatedTime", "RefreshTokenCreateTime" },
                values: new object[] { "79b5f204-1151-45cd-a0bb-5e0cac376538", new DateTime(2024, 4, 3, 10, 46, 33, 392, DateTimeKind.Utc).AddTicks(4729), new DateTime(2024, 9, 3, 10, 46, 33, 392, DateTimeKind.Utc).AddTicks(4730), new DateTime(2024, 9, 3, 10, 46, 33, 392, DateTimeKind.Utc).AddTicks(4726) });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: 2032,
                columns: new[] { "ConcurrencyStamp", "CreatedTime", "LastUpdatedTime", "RefreshTokenCreateTime" },
                values: new object[] { "4e8bdb5d-405a-496b-8c9a-7193d8dd86d3", new DateTime(2024, 3, 3, 10, 46, 33, 392, DateTimeKind.Utc).AddTicks(4743), new DateTime(2024, 9, 3, 10, 46, 33, 392, DateTimeKind.Utc).AddTicks(4744), new DateTime(2024, 9, 3, 10, 46, 33, 392, DateTimeKind.Utc).AddTicks(4740) });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: 2033,
                columns: new[] { "ConcurrencyStamp", "CreatedTime", "LastUpdatedTime", "RefreshTokenCreateTime" },
                values: new object[] { "498c78d8-9f90-4587-b4f8-da9e18e96886", new DateTime(2023, 11, 3, 10, 46, 33, 392, DateTimeKind.Utc).AddTicks(4759), new DateTime(2024, 9, 3, 10, 46, 33, 392, DateTimeKind.Utc).AddTicks(4760), new DateTime(2024, 9, 3, 10, 46, 33, 392, DateTimeKind.Utc).AddTicks(4756) });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: 2034,
                columns: new[] { "ConcurrencyStamp", "CreatedTime", "LastUpdatedTime", "RefreshTokenCreateTime" },
                values: new object[] { "d0ca3155-887f-481f-8950-a397956fbba8", new DateTime(2023, 10, 3, 10, 46, 33, 392, DateTimeKind.Utc).AddTicks(4811), new DateTime(2024, 9, 3, 10, 46, 33, 392, DateTimeKind.Utc).AddTicks(4812), new DateTime(2024, 9, 3, 10, 46, 33, 392, DateTimeKind.Utc).AddTicks(4808) });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: 2035,
                columns: new[] { "ConcurrencyStamp", "CreatedTime", "LastUpdatedTime", "RefreshTokenCreateTime" },
                values: new object[] { "bbe40309-ed77-425f-ba30-e7606a816f4c", new DateTime(2024, 1, 3, 10, 46, 33, 392, DateTimeKind.Utc).AddTicks(4829), new DateTime(2024, 9, 3, 10, 46, 33, 392, DateTimeKind.Utc).AddTicks(4830), new DateTime(2024, 9, 3, 10, 46, 33, 392, DateTimeKind.Utc).AddTicks(4823) });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: 2036,
                columns: new[] { "ConcurrencyStamp", "CreatedTime", "LastUpdatedTime", "RefreshTokenCreateTime" },
                values: new object[] { "e2b1077a-be4b-4d47-b994-ca44d210a432", new DateTime(2024, 6, 3, 10, 46, 33, 392, DateTimeKind.Utc).AddTicks(4843), new DateTime(2024, 9, 3, 10, 46, 33, 392, DateTimeKind.Utc).AddTicks(4844), new DateTime(2024, 9, 3, 10, 46, 33, 392, DateTimeKind.Utc).AddTicks(4840) });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: 2037,
                columns: new[] { "ConcurrencyStamp", "CreatedTime", "LastUpdatedTime", "RefreshTokenCreateTime" },
                values: new object[] { "36ccc4d8-b473-4cbc-a226-7648b55b09fb", new DateTime(2023, 11, 3, 10, 46, 33, 392, DateTimeKind.Utc).AddTicks(4856), new DateTime(2024, 9, 3, 10, 46, 33, 392, DateTimeKind.Utc).AddTicks(4857), new DateTime(2024, 9, 3, 10, 46, 33, 392, DateTimeKind.Utc).AddTicks(4853) });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: 2038,
                columns: new[] { "ConcurrencyStamp", "CreatedTime", "LastUpdatedTime", "RefreshTokenCreateTime" },
                values: new object[] { "47107ce4-a5d6-451d-8e95-4641afd7d339", new DateTime(2024, 8, 3, 10, 46, 33, 392, DateTimeKind.Utc).AddTicks(4870), new DateTime(2024, 9, 3, 10, 46, 33, 392, DateTimeKind.Utc).AddTicks(4871), new DateTime(2024, 9, 3, 10, 46, 33, 392, DateTimeKind.Utc).AddTicks(4867) });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: 2039,
                columns: new[] { "ConcurrencyStamp", "CreatedTime", "LastUpdatedTime", "RefreshTokenCreateTime" },
                values: new object[] { "82630fc2-7f39-4d8f-9fc9-ee8eb1588d6e", new DateTime(2024, 1, 3, 10, 46, 33, 392, DateTimeKind.Utc).AddTicks(4883), new DateTime(2024, 9, 3, 10, 46, 33, 392, DateTimeKind.Utc).AddTicks(4884), new DateTime(2024, 9, 3, 10, 46, 33, 392, DateTimeKind.Utc).AddTicks(4880) });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: 2040,
                columns: new[] { "ConcurrencyStamp", "CreatedTime", "LastUpdatedTime", "RefreshTokenCreateTime" },
                values: new object[] { "b2985bf4-4b89-4948-ac5c-789e755eb21a", new DateTime(2024, 7, 3, 10, 46, 33, 392, DateTimeKind.Utc).AddTicks(4897), new DateTime(2024, 9, 3, 10, 46, 33, 392, DateTimeKind.Utc).AddTicks(4898), new DateTime(2024, 9, 3, 10, 46, 33, 392, DateTimeKind.Utc).AddTicks(4894) });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: 2041,
                columns: new[] { "ConcurrencyStamp", "CreatedTime", "LastUpdatedTime", "RefreshTokenCreateTime" },
                values: new object[] { "2d3bed73-7b6d-4911-9c8b-f90935ad2b5f", new DateTime(2024, 8, 3, 10, 46, 33, 392, DateTimeKind.Utc).AddTicks(4911), new DateTime(2024, 9, 3, 10, 46, 33, 392, DateTimeKind.Utc).AddTicks(4911), new DateTime(2024, 9, 3, 10, 46, 33, 392, DateTimeKind.Utc).AddTicks(4908) });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: 2042,
                columns: new[] { "ConcurrencyStamp", "CreatedTime", "LastUpdatedTime", "RefreshTokenCreateTime" },
                values: new object[] { "ade58e52-8683-48f7-b496-bf4995a05c65", new DateTime(2024, 3, 3, 10, 46, 33, 392, DateTimeKind.Utc).AddTicks(4929), new DateTime(2024, 9, 3, 10, 46, 33, 392, DateTimeKind.Utc).AddTicks(4930), new DateTime(2024, 9, 3, 10, 46, 33, 392, DateTimeKind.Utc).AddTicks(4926) });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: 2043,
                columns: new[] { "ConcurrencyStamp", "CreatedTime", "LastUpdatedTime", "RefreshTokenCreateTime" },
                values: new object[] { "ee8c7b20-a101-491c-b306-23442d93b3c2", new DateTime(2024, 4, 3, 10, 46, 33, 392, DateTimeKind.Utc).AddTicks(4980), new DateTime(2024, 9, 3, 10, 46, 33, 392, DateTimeKind.Utc).AddTicks(4981), new DateTime(2024, 9, 3, 10, 46, 33, 392, DateTimeKind.Utc).AddTicks(4974) });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: 2044,
                columns: new[] { "ConcurrencyStamp", "CreatedTime", "LastUpdatedTime", "RefreshTokenCreateTime" },
                values: new object[] { "96ba760a-b857-40cb-84fb-63c9e26de2b6", new DateTime(2024, 3, 3, 10, 46, 33, 392, DateTimeKind.Utc).AddTicks(5164), new DateTime(2024, 9, 3, 10, 46, 33, 392, DateTimeKind.Utc).AddTicks(5166), new DateTime(2024, 9, 3, 10, 46, 33, 392, DateTimeKind.Utc).AddTicks(4991) });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: 2045,
                columns: new[] { "ConcurrencyStamp", "CreatedTime", "LastUpdatedTime", "RefreshTokenCreateTime" },
                values: new object[] { "74802430-8325-411a-ac20-184ed1cdc675", new DateTime(2024, 8, 3, 10, 46, 33, 392, DateTimeKind.Utc).AddTicks(5201), new DateTime(2024, 9, 3, 10, 46, 33, 392, DateTimeKind.Utc).AddTicks(5203), new DateTime(2024, 9, 3, 10, 46, 33, 392, DateTimeKind.Utc).AddTicks(5191) });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: 2046,
                columns: new[] { "ConcurrencyStamp", "CreatedTime", "LastUpdatedTime", "RefreshTokenCreateTime" },
                values: new object[] { "3de3b9f8-e022-4240-a818-56c067a63202", new DateTime(2024, 5, 3, 10, 46, 33, 392, DateTimeKind.Utc).AddTicks(5238), new DateTime(2024, 9, 3, 10, 46, 33, 392, DateTimeKind.Utc).AddTicks(5240), new DateTime(2024, 9, 3, 10, 46, 33, 392, DateTimeKind.Utc).AddTicks(5228) });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: 2047,
                columns: new[] { "ConcurrencyStamp", "CreatedTime", "LastUpdatedTime", "RefreshTokenCreateTime" },
                values: new object[] { "c88cfcac-0005-4456-9d13-ed57987ca69a", new DateTime(2024, 1, 3, 10, 46, 33, 392, DateTimeKind.Utc).AddTicks(5440), new DateTime(2024, 9, 3, 10, 46, 33, 392, DateTimeKind.Utc).AddTicks(5441), new DateTime(2024, 9, 3, 10, 46, 33, 392, DateTimeKind.Utc).AddTicks(5437) });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: 2048,
                columns: new[] { "ConcurrencyStamp", "CreatedTime", "LastUpdatedTime", "RefreshTokenCreateTime" },
                values: new object[] { "100ec548-7d82-4f07-a0ab-c9e288961f7a", new DateTime(2023, 10, 3, 10, 46, 33, 392, DateTimeKind.Utc).AddTicks(5452), new DateTime(2024, 9, 3, 10, 46, 33, 392, DateTimeKind.Utc).AddTicks(5453), new DateTime(2024, 9, 3, 10, 46, 33, 392, DateTimeKind.Utc).AddTicks(5449) });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: 2049,
                columns: new[] { "ConcurrencyStamp", "CreatedTime", "LastUpdatedTime", "RefreshTokenCreateTime" },
                values: new object[] { "03079ca4-bf40-4bef-8f7b-632f9bb28ee7", new DateTime(2024, 3, 3, 10, 46, 33, 392, DateTimeKind.Utc).AddTicks(5465), new DateTime(2024, 9, 3, 10, 46, 33, 392, DateTimeKind.Utc).AddTicks(5466), new DateTime(2024, 9, 3, 10, 46, 33, 392, DateTimeKind.Utc).AddTicks(5462) });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: 2050,
                columns: new[] { "ConcurrencyStamp", "CreatedTime", "LastUpdatedTime", "RefreshTokenCreateTime" },
                values: new object[] { "d9f1f02d-6f80-4d8b-b629-1c58165cbf71", new DateTime(2024, 1, 3, 10, 46, 33, 392, DateTimeKind.Utc).AddTicks(5477), new DateTime(2024, 9, 3, 10, 46, 33, 392, DateTimeKind.Utc).AddTicks(5478), new DateTime(2024, 9, 3, 10, 46, 33, 392, DateTimeKind.Utc).AddTicks(5474) });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: 2051,
                columns: new[] { "ConcurrencyStamp", "CreatedTime", "LastUpdatedTime", "RefreshTokenCreateTime" },
                values: new object[] { "2ca38b2c-1c83-4dcc-90be-c620b101cdf5", new DateTime(2024, 3, 3, 10, 46, 33, 392, DateTimeKind.Utc).AddTicks(5493), new DateTime(2024, 9, 3, 10, 46, 33, 392, DateTimeKind.Utc).AddTicks(5493), new DateTime(2024, 9, 3, 10, 46, 33, 392, DateTimeKind.Utc).AddTicks(5486) });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: 2052,
                columns: new[] { "ConcurrencyStamp", "CreatedTime", "LastUpdatedTime", "RefreshTokenCreateTime" },
                values: new object[] { "5e20ee91-208c-47ea-93f0-b3e504000fc1", new DateTime(2024, 1, 3, 10, 46, 33, 392, DateTimeKind.Utc).AddTicks(5505), new DateTime(2024, 9, 3, 10, 46, 33, 392, DateTimeKind.Utc).AddTicks(5506), new DateTime(2024, 9, 3, 10, 46, 33, 392, DateTimeKind.Utc).AddTicks(5502) });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: 2053,
                columns: new[] { "ConcurrencyStamp", "CreatedTime", "LastUpdatedTime", "RefreshTokenCreateTime" },
                values: new object[] { "50ee78ca-2169-43d4-ab26-3c5533706248", new DateTime(2024, 3, 3, 10, 46, 33, 392, DateTimeKind.Utc).AddTicks(5770), new DateTime(2024, 9, 3, 10, 46, 33, 392, DateTimeKind.Utc).AddTicks(5772), new DateTime(2024, 9, 3, 10, 46, 33, 392, DateTimeKind.Utc).AddTicks(5592) });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: 2054,
                columns: new[] { "ConcurrencyStamp", "CreatedTime", "LastUpdatedTime", "RefreshTokenCreateTime" },
                values: new object[] { "cf9ef245-8566-4383-ab32-8ad6e24b01f9", new DateTime(2024, 5, 3, 10, 46, 33, 392, DateTimeKind.Utc).AddTicks(5810), new DateTime(2024, 9, 3, 10, 46, 33, 392, DateTimeKind.Utc).AddTicks(5812), new DateTime(2024, 9, 3, 10, 46, 33, 392, DateTimeKind.Utc).AddTicks(5800) });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: 2055,
                columns: new[] { "ConcurrencyStamp", "CreatedTime", "LastUpdatedTime", "RefreshTokenCreateTime" },
                values: new object[] { "383f1367-be0f-4df4-90aa-32e471211516", new DateTime(2024, 4, 3, 10, 46, 33, 392, DateTimeKind.Utc).AddTicks(6027), new DateTime(2024, 9, 3, 10, 46, 33, 392, DateTimeKind.Utc).AddTicks(6028), new DateTime(2024, 9, 3, 10, 46, 33, 392, DateTimeKind.Utc).AddTicks(5837) });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: 2056,
                columns: new[] { "ConcurrencyStamp", "CreatedTime", "LastUpdatedTime", "RefreshTokenCreateTime" },
                values: new object[] { "d6fe4a04-d4bc-4e35-9483-2aa038cb88ca", new DateTime(2023, 11, 3, 10, 46, 33, 392, DateTimeKind.Utc).AddTicks(6039), new DateTime(2024, 9, 3, 10, 46, 33, 392, DateTimeKind.Utc).AddTicks(6040), new DateTime(2024, 9, 3, 10, 46, 33, 392, DateTimeKind.Utc).AddTicks(6036) });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: 2057,
                columns: new[] { "ConcurrencyStamp", "CreatedTime", "LastUpdatedTime", "RefreshTokenCreateTime" },
                values: new object[] { "3af851a5-e174-4586-ac7d-758c93d75342", new DateTime(2024, 1, 3, 10, 46, 33, 392, DateTimeKind.Utc).AddTicks(6053), new DateTime(2024, 9, 3, 10, 46, 33, 392, DateTimeKind.Utc).AddTicks(6054), new DateTime(2024, 9, 3, 10, 46, 33, 392, DateTimeKind.Utc).AddTicks(6050) });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: 2058,
                columns: new[] { "ConcurrencyStamp", "CreatedTime", "LastUpdatedTime", "RefreshTokenCreateTime" },
                values: new object[] { "ae7917d8-fb4c-44c6-ba41-e88ab4711cbf", new DateTime(2024, 1, 3, 10, 46, 33, 392, DateTimeKind.Utc).AddTicks(6065), new DateTime(2024, 9, 3, 10, 46, 33, 392, DateTimeKind.Utc).AddTicks(6066), new DateTime(2024, 9, 3, 10, 46, 33, 392, DateTimeKind.Utc).AddTicks(6062) });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: 2059,
                columns: new[] { "ConcurrencyStamp", "CreatedTime", "LastUpdatedTime", "RefreshTokenCreateTime" },
                values: new object[] { "84b65a86-d078-454d-9a46-74b9ba0c8ecf", new DateTime(2023, 10, 3, 10, 46, 33, 392, DateTimeKind.Utc).AddTicks(6081), new DateTime(2024, 9, 3, 10, 46, 33, 392, DateTimeKind.Utc).AddTicks(6082), new DateTime(2024, 9, 3, 10, 46, 33, 392, DateTimeKind.Utc).AddTicks(6075) });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: 2060,
                columns: new[] { "ConcurrencyStamp", "CreatedTime", "LastUpdatedTime", "RefreshTokenCreateTime" },
                values: new object[] { "174288bc-c1d6-43db-a4d1-c6fd82b75b44", new DateTime(2023, 10, 3, 10, 46, 33, 392, DateTimeKind.Utc).AddTicks(6093), new DateTime(2024, 9, 3, 10, 46, 33, 392, DateTimeKind.Utc).AddTicks(6094), new DateTime(2024, 9, 3, 10, 46, 33, 392, DateTimeKind.Utc).AddTicks(6090) });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: 9999,
                columns: new[] { "ConcurrencyStamp", "CreatedTime", "LastUpdatedTime", "RefreshTokenCreateTime" },
                values: new object[] { "5e1618a0-df2a-4c5c-9a4c-d0797a7886e0", new DateTime(2024, 9, 3, 10, 46, 33, 392, DateTimeKind.Utc).AddTicks(4062), new DateTime(2024, 9, 3, 10, 46, 33, 392, DateTimeKind.Utc).AddTicks(4064), new DateTime(2024, 9, 3, 10, 46, 33, 392, DateTimeKind.Utc).AddTicks(4006) });

            migrationBuilder.UpdateData(
                table: "Breeds",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedTime",
                value: new DateTime(2024, 9, 3, 14, 46, 33, 380, DateTimeKind.Local).AddTicks(9980));

            migrationBuilder.UpdateData(
                table: "Breeds",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreatedTime",
                value: new DateTime(2024, 9, 3, 14, 46, 33, 380, DateTimeKind.Local).AddTicks(9987));

            migrationBuilder.UpdateData(
                table: "Breeds",
                keyColumn: "Id",
                keyValue: 3,
                column: "CreatedTime",
                value: new DateTime(2024, 9, 3, 14, 46, 33, 380, DateTimeKind.Local).AddTicks(9989));

            migrationBuilder.UpdateData(
                table: "Breeds",
                keyColumn: "Id",
                keyValue: 4,
                column: "CreatedTime",
                value: new DateTime(2024, 9, 3, 14, 46, 33, 380, DateTimeKind.Local).AddTicks(9990));

            migrationBuilder.UpdateData(
                table: "Breeds",
                keyColumn: "Id",
                keyValue: 5,
                column: "CreatedTime",
                value: new DateTime(2024, 9, 3, 14, 46, 33, 380, DateTimeKind.Local).AddTicks(9992));

            migrationBuilder.UpdateData(
                table: "Breeds",
                keyColumn: "Id",
                keyValue: 6,
                column: "CreatedTime",
                value: new DateTime(2024, 9, 3, 14, 46, 33, 380, DateTimeKind.Local).AddTicks(9993));

            migrationBuilder.UpdateData(
                table: "Breeds",
                keyColumn: "Id",
                keyValue: 7,
                column: "CreatedTime",
                value: new DateTime(2024, 9, 3, 14, 46, 33, 380, DateTimeKind.Local).AddTicks(9995));

            migrationBuilder.UpdateData(
                table: "Breeds",
                keyColumn: "Id",
                keyValue: 8,
                column: "CreatedTime",
                value: new DateTime(2024, 9, 3, 14, 46, 33, 380, DateTimeKind.Local).AddTicks(9996));

            migrationBuilder.UpdateData(
                table: "Breeds",
                keyColumn: "Id",
                keyValue: 9,
                column: "CreatedTime",
                value: new DateTime(2024, 9, 3, 14, 46, 33, 380, DateTimeKind.Local).AddTicks(9998));

            migrationBuilder.UpdateData(
                table: "Breeds",
                keyColumn: "Id",
                keyValue: 10,
                column: "CreatedTime",
                value: new DateTime(2024, 9, 3, 14, 46, 33, 381, DateTimeKind.Local));

            migrationBuilder.UpdateData(
                table: "Breeds",
                keyColumn: "Id",
                keyValue: 11,
                column: "CreatedTime",
                value: new DateTime(2024, 9, 3, 14, 46, 33, 381, DateTimeKind.Local).AddTicks(1));

            migrationBuilder.UpdateData(
                table: "Breeds",
                keyColumn: "Id",
                keyValue: 12,
                column: "CreatedTime",
                value: new DateTime(2024, 9, 3, 14, 46, 33, 381, DateTimeKind.Local).AddTicks(2));

            migrationBuilder.UpdateData(
                table: "Breeds",
                keyColumn: "Id",
                keyValue: 13,
                column: "CreatedTime",
                value: new DateTime(2024, 9, 3, 14, 46, 33, 381, DateTimeKind.Local).AddTicks(4));

            migrationBuilder.UpdateData(
                table: "Breeds",
                keyColumn: "Id",
                keyValue: 14,
                column: "CreatedTime",
                value: new DateTime(2024, 9, 3, 14, 46, 33, 381, DateTimeKind.Local).AddTicks(5));

            migrationBuilder.UpdateData(
                table: "Breeds",
                keyColumn: "Id",
                keyValue: 15,
                column: "CreatedTime",
                value: new DateTime(2024, 9, 3, 14, 46, 33, 381, DateTimeKind.Local).AddTicks(6));

            migrationBuilder.UpdateData(
                table: "Breeds",
                keyColumn: "Id",
                keyValue: 16,
                column: "CreatedTime",
                value: new DateTime(2024, 9, 3, 14, 46, 33, 381, DateTimeKind.Local).AddTicks(7));

            migrationBuilder.UpdateData(
                table: "Breeds",
                keyColumn: "Id",
                keyValue: 17,
                column: "CreatedTime",
                value: new DateTime(2024, 9, 3, 14, 46, 33, 381, DateTimeKind.Local).AddTicks(9));

            migrationBuilder.UpdateData(
                table: "Breeds",
                keyColumn: "Id",
                keyValue: 18,
                column: "CreatedTime",
                value: new DateTime(2024, 9, 3, 14, 46, 33, 381, DateTimeKind.Local).AddTicks(10));

            migrationBuilder.UpdateData(
                table: "Breeds",
                keyColumn: "Id",
                keyValue: 19,
                column: "CreatedTime",
                value: new DateTime(2024, 9, 3, 14, 46, 33, 381, DateTimeKind.Local).AddTicks(11));

            migrationBuilder.UpdateData(
                table: "Breeds",
                keyColumn: "Id",
                keyValue: 20,
                column: "CreatedTime",
                value: new DateTime(2024, 9, 3, 14, 46, 33, 381, DateTimeKind.Local).AddTicks(13));

            migrationBuilder.UpdateData(
                table: "Breeds",
                keyColumn: "Id",
                keyValue: 21,
                column: "CreatedTime",
                value: new DateTime(2024, 9, 3, 14, 46, 33, 381, DateTimeKind.Local).AddTicks(14));

            migrationBuilder.UpdateData(
                table: "Breeds",
                keyColumn: "Id",
                keyValue: 22,
                column: "CreatedTime",
                value: new DateTime(2024, 9, 3, 14, 46, 33, 381, DateTimeKind.Local).AddTicks(15));

            migrationBuilder.UpdateData(
                table: "Breeds",
                keyColumn: "Id",
                keyValue: 23,
                column: "CreatedTime",
                value: new DateTime(2024, 9, 3, 14, 46, 33, 381, DateTimeKind.Local).AddTicks(17));

            migrationBuilder.UpdateData(
                table: "Breeds",
                keyColumn: "Id",
                keyValue: 24,
                column: "CreatedTime",
                value: new DateTime(2024, 9, 3, 14, 46, 33, 381, DateTimeKind.Local).AddTicks(18));

            migrationBuilder.UpdateData(
                table: "Breeds",
                keyColumn: "Id",
                keyValue: 25,
                column: "CreatedTime",
                value: new DateTime(2024, 9, 3, 14, 46, 33, 381, DateTimeKind.Local).AddTicks(19));

            migrationBuilder.UpdateData(
                table: "Breeds",
                keyColumn: "Id",
                keyValue: 26,
                column: "CreatedTime",
                value: new DateTime(2024, 9, 3, 14, 46, 33, 381, DateTimeKind.Local).AddTicks(20));

            migrationBuilder.UpdateData(
                table: "Breeds",
                keyColumn: "Id",
                keyValue: 27,
                column: "CreatedTime",
                value: new DateTime(2024, 9, 3, 14, 46, 33, 381, DateTimeKind.Local).AddTicks(22));

            migrationBuilder.UpdateData(
                table: "Breeds",
                keyColumn: "Id",
                keyValue: 28,
                column: "CreatedTime",
                value: new DateTime(2024, 9, 3, 14, 46, 33, 381, DateTimeKind.Local).AddTicks(23));

            migrationBuilder.UpdateData(
                table: "Breeds",
                keyColumn: "Id",
                keyValue: 29,
                column: "CreatedTime",
                value: new DateTime(2024, 9, 3, 14, 46, 33, 381, DateTimeKind.Local).AddTicks(24));

            migrationBuilder.UpdateData(
                table: "Breeds",
                keyColumn: "Id",
                keyValue: 30,
                column: "CreatedTime",
                value: new DateTime(2024, 9, 3, 14, 46, 33, 381, DateTimeKind.Local).AddTicks(26));

            migrationBuilder.UpdateData(
                table: "Breeds",
                keyColumn: "Id",
                keyValue: 31,
                column: "CreatedTime",
                value: new DateTime(2024, 9, 3, 14, 46, 33, 381, DateTimeKind.Local).AddTicks(27));

            migrationBuilder.UpdateData(
                table: "Breeds",
                keyColumn: "Id",
                keyValue: 32,
                column: "CreatedTime",
                value: new DateTime(2024, 9, 3, 14, 46, 33, 381, DateTimeKind.Local).AddTicks(28));

            migrationBuilder.UpdateData(
                table: "Breeds",
                keyColumn: "Id",
                keyValue: 33,
                column: "CreatedTime",
                value: new DateTime(2024, 9, 3, 14, 46, 33, 381, DateTimeKind.Local).AddTicks(30));

            migrationBuilder.UpdateData(
                table: "Breeds",
                keyColumn: "Id",
                keyValue: 34,
                column: "CreatedTime",
                value: new DateTime(2024, 9, 3, 14, 46, 33, 381, DateTimeKind.Local).AddTicks(31));

            migrationBuilder.UpdateData(
                table: "Breeds",
                keyColumn: "Id",
                keyValue: 35,
                column: "CreatedTime",
                value: new DateTime(2024, 9, 3, 14, 46, 33, 381, DateTimeKind.Local).AddTicks(32));

            migrationBuilder.UpdateData(
                table: "Breeds",
                keyColumn: "Id",
                keyValue: 36,
                column: "CreatedTime",
                value: new DateTime(2024, 9, 3, 14, 46, 33, 381, DateTimeKind.Local).AddTicks(34));

            migrationBuilder.UpdateData(
                table: "Breeds",
                keyColumn: "Id",
                keyValue: 37,
                column: "CreatedTime",
                value: new DateTime(2024, 9, 3, 14, 46, 33, 381, DateTimeKind.Local).AddTicks(35));

            migrationBuilder.UpdateData(
                table: "Breeds",
                keyColumn: "Id",
                keyValue: 38,
                column: "CreatedTime",
                value: new DateTime(2024, 9, 3, 14, 46, 33, 381, DateTimeKind.Local).AddTicks(36));

            migrationBuilder.UpdateData(
                table: "Breeds",
                keyColumn: "Id",
                keyValue: 39,
                column: "CreatedTime",
                value: new DateTime(2024, 9, 3, 14, 46, 33, 381, DateTimeKind.Local).AddTicks(37));

            migrationBuilder.UpdateData(
                table: "Breeds",
                keyColumn: "Id",
                keyValue: 40,
                column: "CreatedTime",
                value: new DateTime(2024, 9, 3, 14, 46, 33, 381, DateTimeKind.Local).AddTicks(39));

            migrationBuilder.UpdateData(
                table: "Breeds",
                keyColumn: "Id",
                keyValue: 41,
                column: "CreatedTime",
                value: new DateTime(2024, 9, 3, 14, 46, 33, 381, DateTimeKind.Local).AddTicks(40));

            migrationBuilder.UpdateData(
                table: "Breeds",
                keyColumn: "Id",
                keyValue: 42,
                column: "CreatedTime",
                value: new DateTime(2024, 9, 3, 14, 46, 33, 381, DateTimeKind.Local).AddTicks(41));

            migrationBuilder.UpdateData(
                table: "Breeds",
                keyColumn: "Id",
                keyValue: 43,
                column: "CreatedTime",
                value: new DateTime(2024, 9, 3, 14, 46, 33, 381, DateTimeKind.Local).AddTicks(43));

            migrationBuilder.UpdateData(
                table: "Breeds",
                keyColumn: "Id",
                keyValue: 44,
                column: "CreatedTime",
                value: new DateTime(2024, 9, 3, 14, 46, 33, 381, DateTimeKind.Local).AddTicks(45));

            migrationBuilder.UpdateData(
                table: "Breeds",
                keyColumn: "Id",
                keyValue: 45,
                column: "CreatedTime",
                value: new DateTime(2024, 9, 3, 14, 46, 33, 381, DateTimeKind.Local).AddTicks(46));

            migrationBuilder.UpdateData(
                table: "Breeds",
                keyColumn: "Id",
                keyValue: 46,
                column: "CreatedTime",
                value: new DateTime(2024, 9, 3, 14, 46, 33, 381, DateTimeKind.Local).AddTicks(47));

            migrationBuilder.UpdateData(
                table: "Breeds",
                keyColumn: "Id",
                keyValue: 47,
                column: "CreatedTime",
                value: new DateTime(2024, 9, 3, 14, 46, 33, 381, DateTimeKind.Local).AddTicks(49));

            migrationBuilder.UpdateData(
                table: "Breeds",
                keyColumn: "Id",
                keyValue: 48,
                column: "CreatedTime",
                value: new DateTime(2024, 9, 3, 14, 46, 33, 381, DateTimeKind.Local).AddTicks(50));

            migrationBuilder.UpdateData(
                table: "Breeds",
                keyColumn: "Id",
                keyValue: 49,
                column: "CreatedTime",
                value: new DateTime(2024, 9, 3, 14, 46, 33, 381, DateTimeKind.Local).AddTicks(51));

            migrationBuilder.UpdateData(
                table: "Breeds",
                keyColumn: "Id",
                keyValue: 50,
                column: "CreatedTime",
                value: new DateTime(2024, 9, 3, 14, 46, 33, 381, DateTimeKind.Local).AddTicks(52));

            migrationBuilder.UpdateData(
                table: "Breeds",
                keyColumn: "Id",
                keyValue: 51,
                column: "CreatedTime",
                value: new DateTime(2024, 9, 3, 14, 46, 33, 381, DateTimeKind.Local).AddTicks(54));

            migrationBuilder.UpdateData(
                table: "Breeds",
                keyColumn: "Id",
                keyValue: 52,
                column: "CreatedTime",
                value: new DateTime(2024, 9, 3, 14, 46, 33, 381, DateTimeKind.Local).AddTicks(55));

            migrationBuilder.UpdateData(
                table: "Breeds",
                keyColumn: "Id",
                keyValue: 53,
                column: "CreatedTime",
                value: new DateTime(2024, 9, 3, 14, 46, 33, 381, DateTimeKind.Local).AddTicks(56));

            migrationBuilder.UpdateData(
                table: "Breeds",
                keyColumn: "Id",
                keyValue: 54,
                column: "CreatedTime",
                value: new DateTime(2024, 9, 3, 14, 46, 33, 381, DateTimeKind.Local).AddTicks(58));

            migrationBuilder.UpdateData(
                table: "Breeds",
                keyColumn: "Id",
                keyValue: 55,
                column: "CreatedTime",
                value: new DateTime(2024, 9, 3, 14, 46, 33, 381, DateTimeKind.Local).AddTicks(59));

            migrationBuilder.UpdateData(
                table: "Breeds",
                keyColumn: "Id",
                keyValue: 56,
                column: "CreatedTime",
                value: new DateTime(2024, 9, 3, 14, 46, 33, 381, DateTimeKind.Local).AddTicks(60));

            migrationBuilder.UpdateData(
                table: "Breeds",
                keyColumn: "Id",
                keyValue: 57,
                column: "CreatedTime",
                value: new DateTime(2024, 9, 3, 14, 46, 33, 381, DateTimeKind.Local).AddTicks(61));

            migrationBuilder.UpdateData(
                table: "Breeds",
                keyColumn: "Id",
                keyValue: 58,
                column: "CreatedTime",
                value: new DateTime(2024, 9, 3, 14, 46, 33, 381, DateTimeKind.Local).AddTicks(63));

            migrationBuilder.UpdateData(
                table: "Breeds",
                keyColumn: "Id",
                keyValue: 59,
                column: "CreatedTime",
                value: new DateTime(2024, 9, 3, 14, 46, 33, 381, DateTimeKind.Local).AddTicks(64));

            migrationBuilder.UpdateData(
                table: "Breeds",
                keyColumn: "Id",
                keyValue: 60,
                column: "CreatedTime",
                value: new DateTime(2024, 9, 3, 14, 46, 33, 381, DateTimeKind.Local).AddTicks(66));

            migrationBuilder.UpdateData(
                table: "Breeds",
                keyColumn: "Id",
                keyValue: 61,
                column: "CreatedTime",
                value: new DateTime(2024, 9, 3, 14, 46, 33, 381, DateTimeKind.Local).AddTicks(67));

            migrationBuilder.UpdateData(
                table: "Breeds",
                keyColumn: "Id",
                keyValue: 62,
                column: "CreatedTime",
                value: new DateTime(2024, 9, 3, 14, 46, 33, 381, DateTimeKind.Local).AddTicks(68));

            migrationBuilder.UpdateData(
                table: "Breeds",
                keyColumn: "Id",
                keyValue: 63,
                column: "CreatedTime",
                value: new DateTime(2024, 9, 3, 14, 46, 33, 381, DateTimeKind.Local).AddTicks(69));

            migrationBuilder.UpdateData(
                table: "Breeds",
                keyColumn: "Id",
                keyValue: 64,
                column: "CreatedTime",
                value: new DateTime(2024, 9, 3, 14, 46, 33, 381, DateTimeKind.Local).AddTicks(71));

            migrationBuilder.UpdateData(
                table: "Breeds",
                keyColumn: "Id",
                keyValue: 65,
                column: "CreatedTime",
                value: new DateTime(2024, 9, 3, 14, 46, 33, 381, DateTimeKind.Local).AddTicks(72));

            migrationBuilder.UpdateData(
                table: "Breeds",
                keyColumn: "Id",
                keyValue: 66,
                column: "CreatedTime",
                value: new DateTime(2024, 9, 3, 14, 46, 33, 381, DateTimeKind.Local).AddTicks(74));

            migrationBuilder.UpdateData(
                table: "Breeds",
                keyColumn: "Id",
                keyValue: 67,
                column: "CreatedTime",
                value: new DateTime(2024, 9, 3, 14, 46, 33, 381, DateTimeKind.Local).AddTicks(75));

            migrationBuilder.UpdateData(
                table: "Breeds",
                keyColumn: "Id",
                keyValue: 68,
                column: "CreatedTime",
                value: new DateTime(2024, 9, 3, 14, 46, 33, 381, DateTimeKind.Local).AddTicks(76));

            migrationBuilder.UpdateData(
                table: "Breeds",
                keyColumn: "Id",
                keyValue: 69,
                column: "CreatedTime",
                value: new DateTime(2024, 9, 3, 14, 46, 33, 381, DateTimeKind.Local).AddTicks(78));

            migrationBuilder.UpdateData(
                table: "Breeds",
                keyColumn: "Id",
                keyValue: 70,
                column: "CreatedTime",
                value: new DateTime(2024, 9, 3, 14, 46, 33, 381, DateTimeKind.Local).AddTicks(79));

            migrationBuilder.UpdateData(
                table: "Breeds",
                keyColumn: "Id",
                keyValue: 71,
                column: "CreatedTime",
                value: new DateTime(2024, 9, 3, 14, 46, 33, 381, DateTimeKind.Local).AddTicks(80));

            migrationBuilder.UpdateData(
                table: "Breeds",
                keyColumn: "Id",
                keyValue: 72,
                column: "CreatedTime",
                value: new DateTime(2024, 9, 3, 14, 46, 33, 381, DateTimeKind.Local).AddTicks(81));

            migrationBuilder.UpdateData(
                table: "Breeds",
                keyColumn: "Id",
                keyValue: 73,
                column: "CreatedTime",
                value: new DateTime(2024, 9, 3, 14, 46, 33, 381, DateTimeKind.Local).AddTicks(84));

            migrationBuilder.UpdateData(
                table: "Breeds",
                keyColumn: "Id",
                keyValue: 74,
                column: "CreatedTime",
                value: new DateTime(2024, 9, 3, 14, 46, 33, 381, DateTimeKind.Local).AddTicks(85));

            migrationBuilder.UpdateData(
                table: "Breeds",
                keyColumn: "Id",
                keyValue: 75,
                column: "CreatedTime",
                value: new DateTime(2024, 9, 3, 14, 46, 33, 381, DateTimeKind.Local).AddTicks(86));

            migrationBuilder.UpdateData(
                table: "Breeds",
                keyColumn: "Id",
                keyValue: 76,
                column: "CreatedTime",
                value: new DateTime(2024, 9, 3, 14, 46, 33, 381, DateTimeKind.Local).AddTicks(88));

            migrationBuilder.UpdateData(
                table: "Breeds",
                keyColumn: "Id",
                keyValue: 77,
                column: "CreatedTime",
                value: new DateTime(2024, 9, 3, 14, 46, 33, 381, DateTimeKind.Local).AddTicks(89));

            migrationBuilder.UpdateData(
                table: "Breeds",
                keyColumn: "Id",
                keyValue: 78,
                column: "CreatedTime",
                value: new DateTime(2024, 9, 3, 14, 46, 33, 381, DateTimeKind.Local).AddTicks(90));

            migrationBuilder.UpdateData(
                table: "Breeds",
                keyColumn: "Id",
                keyValue: 79,
                column: "CreatedTime",
                value: new DateTime(2024, 9, 3, 14, 46, 33, 381, DateTimeKind.Local).AddTicks(92));

            migrationBuilder.UpdateData(
                table: "Breeds",
                keyColumn: "Id",
                keyValue: 80,
                column: "CreatedTime",
                value: new DateTime(2024, 9, 3, 14, 46, 33, 381, DateTimeKind.Local).AddTicks(93));

            migrationBuilder.UpdateData(
                table: "Breeds",
                keyColumn: "Id",
                keyValue: 81,
                column: "CreatedTime",
                value: new DateTime(2024, 9, 3, 14, 46, 33, 381, DateTimeKind.Local).AddTicks(94));

            migrationBuilder.UpdateData(
                table: "Breeds",
                keyColumn: "Id",
                keyValue: 82,
                column: "CreatedTime",
                value: new DateTime(2024, 9, 3, 14, 46, 33, 381, DateTimeKind.Local).AddTicks(95));

            migrationBuilder.UpdateData(
                table: "Breeds",
                keyColumn: "Id",
                keyValue: 83,
                column: "CreatedTime",
                value: new DateTime(2024, 9, 3, 14, 46, 33, 381, DateTimeKind.Local).AddTicks(97));

            migrationBuilder.UpdateData(
                table: "Breeds",
                keyColumn: "Id",
                keyValue: 84,
                column: "CreatedTime",
                value: new DateTime(2024, 9, 3, 14, 46, 33, 381, DateTimeKind.Local).AddTicks(98));

            migrationBuilder.UpdateData(
                table: "Breeds",
                keyColumn: "Id",
                keyValue: 85,
                column: "CreatedTime",
                value: new DateTime(2024, 9, 3, 14, 46, 33, 381, DateTimeKind.Local).AddTicks(99));

            migrationBuilder.UpdateData(
                table: "Breeds",
                keyColumn: "Id",
                keyValue: 86,
                column: "CreatedTime",
                value: new DateTime(2024, 9, 3, 14, 46, 33, 381, DateTimeKind.Local).AddTicks(101));

            migrationBuilder.UpdateData(
                table: "Breeds",
                keyColumn: "Id",
                keyValue: 87,
                column: "CreatedTime",
                value: new DateTime(2024, 9, 3, 14, 46, 33, 381, DateTimeKind.Local).AddTicks(102));

            migrationBuilder.UpdateData(
                table: "Breeds",
                keyColumn: "Id",
                keyValue: 88,
                column: "CreatedTime",
                value: new DateTime(2024, 9, 3, 14, 46, 33, 381, DateTimeKind.Local).AddTicks(103));

            migrationBuilder.UpdateData(
                table: "Breeds",
                keyColumn: "Id",
                keyValue: 89,
                column: "CreatedTime",
                value: new DateTime(2024, 9, 3, 14, 46, 33, 381, DateTimeKind.Local).AddTicks(105));

            migrationBuilder.UpdateData(
                table: "Breeds",
                keyColumn: "Id",
                keyValue: 90,
                column: "CreatedTime",
                value: new DateTime(2024, 9, 3, 14, 46, 33, 381, DateTimeKind.Local).AddTicks(106));

            migrationBuilder.UpdateData(
                table: "Breeds",
                keyColumn: "Id",
                keyValue: 91,
                column: "CreatedTime",
                value: new DateTime(2024, 9, 3, 14, 46, 33, 381, DateTimeKind.Local).AddTicks(107));

            migrationBuilder.UpdateData(
                table: "Breeds",
                keyColumn: "Id",
                keyValue: 92,
                column: "CreatedTime",
                value: new DateTime(2024, 9, 3, 14, 46, 33, 381, DateTimeKind.Local).AddTicks(109));

            migrationBuilder.UpdateData(
                table: "Breeds",
                keyColumn: "Id",
                keyValue: 93,
                column: "CreatedTime",
                value: new DateTime(2024, 9, 3, 14, 46, 33, 381, DateTimeKind.Local).AddTicks(154));

            migrationBuilder.UpdateData(
                table: "Breeds",
                keyColumn: "Id",
                keyValue: 94,
                column: "CreatedTime",
                value: new DateTime(2024, 9, 3, 14, 46, 33, 381, DateTimeKind.Local).AddTicks(155));

            migrationBuilder.UpdateData(
                table: "Breeds",
                keyColumn: "Id",
                keyValue: 95,
                column: "CreatedTime",
                value: new DateTime(2024, 9, 3, 14, 46, 33, 381, DateTimeKind.Local).AddTicks(157));

            migrationBuilder.UpdateData(
                table: "Breeds",
                keyColumn: "Id",
                keyValue: 96,
                column: "CreatedTime",
                value: new DateTime(2024, 9, 3, 14, 46, 33, 381, DateTimeKind.Local).AddTicks(158));

            migrationBuilder.UpdateData(
                table: "Breeds",
                keyColumn: "Id",
                keyValue: 97,
                column: "CreatedTime",
                value: new DateTime(2024, 9, 3, 14, 46, 33, 381, DateTimeKind.Local).AddTicks(159));

            migrationBuilder.UpdateData(
                table: "Breeds",
                keyColumn: "Id",
                keyValue: 98,
                column: "CreatedTime",
                value: new DateTime(2024, 9, 3, 14, 46, 33, 381, DateTimeKind.Local).AddTicks(161));

            migrationBuilder.UpdateData(
                table: "Breeds",
                keyColumn: "Id",
                keyValue: 99,
                column: "CreatedTime",
                value: new DateTime(2024, 9, 3, 14, 46, 33, 381, DateTimeKind.Local).AddTicks(162));

            migrationBuilder.UpdateData(
                table: "Breeds",
                keyColumn: "Id",
                keyValue: 100,
                column: "CreatedTime",
                value: new DateTime(2024, 9, 3, 14, 46, 33, 381, DateTimeKind.Local).AddTicks(163));

            migrationBuilder.UpdateData(
                table: "Breeds",
                keyColumn: "Id",
                keyValue: 101,
                column: "CreatedTime",
                value: new DateTime(2024, 9, 3, 14, 46, 33, 381, DateTimeKind.Local).AddTicks(164));

            migrationBuilder.UpdateData(
                table: "Breeds",
                keyColumn: "Id",
                keyValue: 102,
                column: "CreatedTime",
                value: new DateTime(2024, 9, 3, 14, 46, 33, 381, DateTimeKind.Local).AddTicks(167));

            migrationBuilder.UpdateData(
                table: "Breeds",
                keyColumn: "Id",
                keyValue: 103,
                column: "CreatedTime",
                value: new DateTime(2024, 9, 3, 14, 46, 33, 381, DateTimeKind.Local).AddTicks(168));

            migrationBuilder.UpdateData(
                table: "Breeds",
                keyColumn: "Id",
                keyValue: 104,
                column: "CreatedTime",
                value: new DateTime(2024, 9, 3, 14, 46, 33, 381, DateTimeKind.Local).AddTicks(169));

            migrationBuilder.UpdateData(
                table: "Breeds",
                keyColumn: "Id",
                keyValue: 105,
                column: "CreatedTime",
                value: new DateTime(2024, 9, 3, 14, 46, 33, 381, DateTimeKind.Local).AddTicks(171));

            migrationBuilder.UpdateData(
                table: "Breeds",
                keyColumn: "Id",
                keyValue: 106,
                column: "CreatedTime",
                value: new DateTime(2024, 9, 3, 14, 46, 33, 381, DateTimeKind.Local).AddTicks(172));

            migrationBuilder.UpdateData(
                table: "Breeds",
                keyColumn: "Id",
                keyValue: 107,
                column: "CreatedTime",
                value: new DateTime(2024, 9, 3, 14, 46, 33, 381, DateTimeKind.Local).AddTicks(173));

            migrationBuilder.UpdateData(
                table: "Breeds",
                keyColumn: "Id",
                keyValue: 108,
                column: "CreatedTime",
                value: new DateTime(2024, 9, 3, 14, 46, 33, 381, DateTimeKind.Local).AddTicks(174));

            migrationBuilder.UpdateData(
                table: "Breeds",
                keyColumn: "Id",
                keyValue: 109,
                column: "CreatedTime",
                value: new DateTime(2024, 9, 3, 14, 46, 33, 381, DateTimeKind.Local).AddTicks(176));

            migrationBuilder.UpdateData(
                table: "Breeds",
                keyColumn: "Id",
                keyValue: 110,
                column: "CreatedTime",
                value: new DateTime(2024, 9, 3, 14, 46, 33, 381, DateTimeKind.Local).AddTicks(177));

            migrationBuilder.UpdateData(
                table: "Breeds",
                keyColumn: "Id",
                keyValue: 111,
                column: "CreatedTime",
                value: new DateTime(2024, 9, 3, 14, 46, 33, 381, DateTimeKind.Local).AddTicks(178));

            migrationBuilder.UpdateData(
                table: "Breeds",
                keyColumn: "Id",
                keyValue: 112,
                column: "CreatedTime",
                value: new DateTime(2024, 9, 3, 14, 46, 33, 381, DateTimeKind.Local).AddTicks(179));

            migrationBuilder.UpdateData(
                table: "Breeds",
                keyColumn: "Id",
                keyValue: 113,
                column: "CreatedTime",
                value: new DateTime(2024, 9, 3, 14, 46, 33, 381, DateTimeKind.Local).AddTicks(181));

            migrationBuilder.UpdateData(
                table: "Breeds",
                keyColumn: "Id",
                keyValue: 114,
                column: "CreatedTime",
                value: new DateTime(2024, 9, 3, 14, 46, 33, 381, DateTimeKind.Local).AddTicks(182));

            migrationBuilder.UpdateData(
                table: "Breeds",
                keyColumn: "Id",
                keyValue: 115,
                column: "CreatedTime",
                value: new DateTime(2024, 9, 3, 14, 46, 33, 381, DateTimeKind.Local).AddTicks(183));

            migrationBuilder.UpdateData(
                table: "Breeds",
                keyColumn: "Id",
                keyValue: 116,
                column: "CreatedTime",
                value: new DateTime(2024, 9, 3, 14, 46, 33, 381, DateTimeKind.Local).AddTicks(185));

            migrationBuilder.UpdateData(
                table: "Breeds",
                keyColumn: "Id",
                keyValue: 117,
                column: "CreatedTime",
                value: new DateTime(2024, 9, 3, 14, 46, 33, 381, DateTimeKind.Local).AddTicks(186));

            migrationBuilder.UpdateData(
                table: "Breeds",
                keyColumn: "Id",
                keyValue: 118,
                column: "CreatedTime",
                value: new DateTime(2024, 9, 3, 14, 46, 33, 381, DateTimeKind.Local).AddTicks(187));

            migrationBuilder.UpdateData(
                table: "Breeds",
                keyColumn: "Id",
                keyValue: 119,
                column: "CreatedTime",
                value: new DateTime(2024, 9, 3, 14, 46, 33, 381, DateTimeKind.Local).AddTicks(189));

            migrationBuilder.UpdateData(
                table: "Breeds",
                keyColumn: "Id",
                keyValue: 120,
                column: "CreatedTime",
                value: new DateTime(2024, 9, 3, 14, 46, 33, 381, DateTimeKind.Local).AddTicks(190));

            migrationBuilder.UpdateData(
                table: "Breeds",
                keyColumn: "Id",
                keyValue: 121,
                column: "CreatedTime",
                value: new DateTime(2024, 9, 3, 14, 46, 33, 381, DateTimeKind.Local).AddTicks(191));

            migrationBuilder.UpdateData(
                table: "Breeds",
                keyColumn: "Id",
                keyValue: 122,
                column: "CreatedTime",
                value: new DateTime(2024, 9, 3, 14, 46, 33, 381, DateTimeKind.Local).AddTicks(193));

            migrationBuilder.UpdateData(
                table: "Breeds",
                keyColumn: "Id",
                keyValue: 123,
                column: "CreatedTime",
                value: new DateTime(2024, 9, 3, 14, 46, 33, 381, DateTimeKind.Local).AddTicks(194));

            migrationBuilder.UpdateData(
                table: "Breeds",
                keyColumn: "Id",
                keyValue: 124,
                column: "CreatedTime",
                value: new DateTime(2024, 9, 3, 14, 46, 33, 381, DateTimeKind.Local).AddTicks(195));

            migrationBuilder.UpdateData(
                table: "Breeds",
                keyColumn: "Id",
                keyValue: 125,
                column: "CreatedTime",
                value: new DateTime(2024, 9, 3, 14, 46, 33, 381, DateTimeKind.Local).AddTicks(197));

            migrationBuilder.UpdateData(
                table: "Breeds",
                keyColumn: "Id",
                keyValue: 126,
                column: "CreatedTime",
                value: new DateTime(2024, 9, 3, 14, 46, 33, 381, DateTimeKind.Local).AddTicks(198));

            migrationBuilder.UpdateData(
                table: "Breeds",
                keyColumn: "Id",
                keyValue: 127,
                column: "CreatedTime",
                value: new DateTime(2024, 9, 3, 14, 46, 33, 381, DateTimeKind.Local).AddTicks(199));

            migrationBuilder.UpdateData(
                table: "Breeds",
                keyColumn: "Id",
                keyValue: 128,
                column: "CreatedTime",
                value: new DateTime(2024, 9, 3, 14, 46, 33, 381, DateTimeKind.Local).AddTicks(200));

            migrationBuilder.UpdateData(
                table: "Breeds",
                keyColumn: "Id",
                keyValue: 129,
                column: "CreatedTime",
                value: new DateTime(2024, 9, 3, 14, 46, 33, 381, DateTimeKind.Local).AddTicks(202));

            migrationBuilder.UpdateData(
                table: "Breeds",
                keyColumn: "Id",
                keyValue: 130,
                column: "CreatedTime",
                value: new DateTime(2024, 9, 3, 14, 46, 33, 381, DateTimeKind.Local).AddTicks(203));

            migrationBuilder.UpdateData(
                table: "Breeds",
                keyColumn: "Id",
                keyValue: 131,
                column: "CreatedTime",
                value: new DateTime(2024, 9, 3, 14, 46, 33, 381, DateTimeKind.Local).AddTicks(205));

            migrationBuilder.UpdateData(
                table: "Breeds",
                keyColumn: "Id",
                keyValue: 132,
                column: "CreatedTime",
                value: new DateTime(2024, 9, 3, 14, 46, 33, 381, DateTimeKind.Local).AddTicks(207));

            migrationBuilder.UpdateData(
                table: "Breeds",
                keyColumn: "Id",
                keyValue: 133,
                column: "CreatedTime",
                value: new DateTime(2024, 9, 3, 14, 46, 33, 381, DateTimeKind.Local).AddTicks(208));

            migrationBuilder.UpdateData(
                table: "Breeds",
                keyColumn: "Id",
                keyValue: 134,
                column: "CreatedTime",
                value: new DateTime(2024, 9, 3, 14, 46, 33, 381, DateTimeKind.Local).AddTicks(209));

            migrationBuilder.UpdateData(
                table: "Breeds",
                keyColumn: "Id",
                keyValue: 135,
                column: "CreatedTime",
                value: new DateTime(2024, 9, 3, 14, 46, 33, 381, DateTimeKind.Local).AddTicks(211));

            migrationBuilder.UpdateData(
                table: "Breeds",
                keyColumn: "Id",
                keyValue: 136,
                column: "CreatedTime",
                value: new DateTime(2024, 9, 3, 14, 46, 33, 381, DateTimeKind.Local).AddTicks(212));

            migrationBuilder.UpdateData(
                table: "Breeds",
                keyColumn: "Id",
                keyValue: 137,
                column: "CreatedTime",
                value: new DateTime(2024, 9, 3, 14, 46, 33, 381, DateTimeKind.Local).AddTicks(213));

            migrationBuilder.UpdateData(
                table: "Breeds",
                keyColumn: "Id",
                keyValue: 138,
                column: "CreatedTime",
                value: new DateTime(2024, 9, 3, 14, 46, 33, 381, DateTimeKind.Local).AddTicks(214));

            migrationBuilder.UpdateData(
                table: "Breeds",
                keyColumn: "Id",
                keyValue: 139,
                column: "CreatedTime",
                value: new DateTime(2024, 9, 3, 14, 46, 33, 381, DateTimeKind.Local).AddTicks(216));

            migrationBuilder.UpdateData(
                table: "Breeds",
                keyColumn: "Id",
                keyValue: 140,
                column: "CreatedTime",
                value: new DateTime(2024, 9, 3, 14, 46, 33, 381, DateTimeKind.Local).AddTicks(217));

            migrationBuilder.UpdateData(
                table: "Breeds",
                keyColumn: "Id",
                keyValue: 141,
                column: "CreatedTime",
                value: new DateTime(2024, 9, 3, 14, 46, 33, 381, DateTimeKind.Local).AddTicks(218));

            migrationBuilder.UpdateData(
                table: "Breeds",
                keyColumn: "Id",
                keyValue: 142,
                column: "CreatedTime",
                value: new DateTime(2024, 9, 3, 14, 46, 33, 381, DateTimeKind.Local).AddTicks(220));

            migrationBuilder.UpdateData(
                table: "Breeds",
                keyColumn: "Id",
                keyValue: 143,
                column: "CreatedTime",
                value: new DateTime(2024, 9, 3, 14, 46, 33, 381, DateTimeKind.Local).AddTicks(221));

            migrationBuilder.UpdateData(
                table: "Breeds",
                keyColumn: "Id",
                keyValue: 144,
                column: "CreatedTime",
                value: new DateTime(2024, 9, 3, 14, 46, 33, 381, DateTimeKind.Local).AddTicks(222));

            migrationBuilder.UpdateData(
                table: "Breeds",
                keyColumn: "Id",
                keyValue: 145,
                column: "CreatedTime",
                value: new DateTime(2024, 9, 3, 14, 46, 33, 381, DateTimeKind.Local).AddTicks(224));

            migrationBuilder.UpdateData(
                table: "Breeds",
                keyColumn: "Id",
                keyValue: 146,
                column: "CreatedTime",
                value: new DateTime(2024, 9, 3, 14, 46, 33, 381, DateTimeKind.Local).AddTicks(225));

            migrationBuilder.UpdateData(
                table: "Breeds",
                keyColumn: "Id",
                keyValue: 147,
                column: "CreatedTime",
                value: new DateTime(2024, 9, 3, 14, 46, 33, 381, DateTimeKind.Local).AddTicks(226));

            migrationBuilder.UpdateData(
                table: "Breeds",
                keyColumn: "Id",
                keyValue: 148,
                column: "CreatedTime",
                value: new DateTime(2024, 9, 3, 14, 46, 33, 381, DateTimeKind.Local).AddTicks(227));

            migrationBuilder.UpdateData(
                table: "Breeds",
                keyColumn: "Id",
                keyValue: 149,
                column: "CreatedTime",
                value: new DateTime(2024, 9, 3, 14, 46, 33, 381, DateTimeKind.Local).AddTicks(229));

            migrationBuilder.UpdateData(
                table: "Breeds",
                keyColumn: "Id",
                keyValue: 150,
                column: "CreatedTime",
                value: new DateTime(2024, 9, 3, 14, 46, 33, 381, DateTimeKind.Local).AddTicks(230));

            migrationBuilder.UpdateData(
                table: "Breeds",
                keyColumn: "Id",
                keyValue: 151,
                column: "CreatedTime",
                value: new DateTime(2024, 9, 3, 14, 46, 33, 381, DateTimeKind.Local).AddTicks(232));

            migrationBuilder.UpdateData(
                table: "Breeds",
                keyColumn: "Id",
                keyValue: 152,
                column: "CreatedTime",
                value: new DateTime(2024, 9, 3, 14, 46, 33, 381, DateTimeKind.Local).AddTicks(233));

            migrationBuilder.UpdateData(
                table: "Breeds",
                keyColumn: "Id",
                keyValue: 153,
                column: "CreatedTime",
                value: new DateTime(2024, 9, 3, 14, 46, 33, 381, DateTimeKind.Local).AddTicks(234));

            migrationBuilder.UpdateData(
                table: "Breeds",
                keyColumn: "Id",
                keyValue: 154,
                column: "CreatedTime",
                value: new DateTime(2024, 9, 3, 14, 46, 33, 381, DateTimeKind.Local).AddTicks(236));

            migrationBuilder.UpdateData(
                table: "Breeds",
                keyColumn: "Id",
                keyValue: 155,
                column: "CreatedTime",
                value: new DateTime(2024, 9, 3, 14, 46, 33, 381, DateTimeKind.Local).AddTicks(238));

            migrationBuilder.UpdateData(
                table: "Breeds",
                keyColumn: "Id",
                keyValue: 156,
                column: "CreatedTime",
                value: new DateTime(2024, 9, 3, 14, 46, 33, 381, DateTimeKind.Local).AddTicks(239));

            migrationBuilder.UpdateData(
                table: "Breeds",
                keyColumn: "Id",
                keyValue: 157,
                column: "CreatedTime",
                value: new DateTime(2024, 9, 3, 14, 46, 33, 381, DateTimeKind.Local).AddTicks(241));

            migrationBuilder.UpdateData(
                table: "Breeds",
                keyColumn: "Id",
                keyValue: 158,
                column: "CreatedTime",
                value: new DateTime(2024, 9, 3, 14, 46, 33, 381, DateTimeKind.Local).AddTicks(242));

            migrationBuilder.UpdateData(
                table: "Breeds",
                keyColumn: "Id",
                keyValue: 159,
                column: "CreatedTime",
                value: new DateTime(2024, 9, 3, 14, 46, 33, 381, DateTimeKind.Local).AddTicks(243));

            migrationBuilder.UpdateData(
                table: "Breeds",
                keyColumn: "Id",
                keyValue: 160,
                column: "CreatedTime",
                value: new DateTime(2024, 9, 3, 14, 46, 33, 381, DateTimeKind.Local).AddTicks(245));

            migrationBuilder.UpdateData(
                table: "PetTypes",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedTime",
                value: new DateTime(2024, 9, 3, 14, 46, 33, 380, DateTimeKind.Local).AddTicks(6006));

            migrationBuilder.UpdateData(
                table: "PetTypes",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreatedTime",
                value: new DateTime(2024, 9, 3, 14, 46, 33, 380, DateTimeKind.Local).AddTicks(6008));

            migrationBuilder.UpdateData(
                table: "PetTypes",
                keyColumn: "Id",
                keyValue: 3,
                column: "CreatedTime",
                value: new DateTime(2024, 9, 3, 14, 46, 33, 380, DateTimeKind.Local).AddTicks(6010));

            migrationBuilder.UpdateData(
                table: "PetTypes",
                keyColumn: "Id",
                keyValue: 4,
                column: "CreatedTime",
                value: new DateTime(2024, 9, 3, 14, 46, 33, 380, DateTimeKind.Local).AddTicks(6011));

            migrationBuilder.UpdateData(
                table: "PetTypes",
                keyColumn: "Id",
                keyValue: 5,
                column: "CreatedTime",
                value: new DateTime(2024, 9, 3, 14, 46, 33, 380, DateTimeKind.Local).AddTicks(6012));

            migrationBuilder.UpdateData(
                table: "PetTypes",
                keyColumn: "Id",
                keyValue: 6,
                column: "CreatedTime",
                value: new DateTime(2024, 9, 3, 14, 46, 33, 380, DateTimeKind.Local).AddTicks(6014));

            migrationBuilder.UpdateData(
                table: "PetTypes",
                keyColumn: "Id",
                keyValue: 7,
                column: "CreatedTime",
                value: new DateTime(2024, 9, 3, 14, 46, 33, 380, DateTimeKind.Local).AddTicks(6015));

            migrationBuilder.UpdateData(
                table: "PetTypes",
                keyColumn: "Id",
                keyValue: 8,
                column: "CreatedTime",
                value: new DateTime(2024, 9, 3, 14, 46, 33, 380, DateTimeKind.Local).AddTicks(6016));

            migrationBuilder.UpdateData(
                table: "Pets",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedTime",
                value: new DateTime(2024, 1, 3, 14, 46, 33, 393, DateTimeKind.Local).AddTicks(5575));

            migrationBuilder.UpdateData(
                table: "Pets",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreatedTime",
                value: new DateTime(2024, 6, 3, 14, 46, 33, 393, DateTimeKind.Local).AddTicks(5591));

            migrationBuilder.UpdateData(
                table: "Pets",
                keyColumn: "Id",
                keyValue: 3,
                column: "CreatedTime",
                value: new DateTime(2023, 12, 3, 14, 46, 33, 393, DateTimeKind.Local).AddTicks(5600));

            migrationBuilder.UpdateData(
                table: "Pets",
                keyColumn: "Id",
                keyValue: 4,
                column: "CreatedTime",
                value: new DateTime(2024, 1, 3, 14, 46, 33, 393, DateTimeKind.Local).AddTicks(5606));

            migrationBuilder.UpdateData(
                table: "Pets",
                keyColumn: "Id",
                keyValue: 5,
                column: "CreatedTime",
                value: new DateTime(2023, 11, 3, 14, 46, 33, 393, DateTimeKind.Local).AddTicks(5612));

            migrationBuilder.UpdateData(
                table: "Pets",
                keyColumn: "Id",
                keyValue: 6,
                column: "CreatedTime",
                value: new DateTime(2024, 3, 3, 14, 46, 33, 393, DateTimeKind.Local).AddTicks(5621));

            migrationBuilder.UpdateData(
                table: "Pets",
                keyColumn: "Id",
                keyValue: 7,
                column: "CreatedTime",
                value: new DateTime(2024, 6, 3, 14, 46, 33, 393, DateTimeKind.Local).AddTicks(5626));

            migrationBuilder.UpdateData(
                table: "Pets",
                keyColumn: "Id",
                keyValue: 8,
                column: "CreatedTime",
                value: new DateTime(2024, 7, 3, 14, 46, 33, 393, DateTimeKind.Local).AddTicks(5631));

            migrationBuilder.UpdateData(
                table: "Pets",
                keyColumn: "Id",
                keyValue: 9,
                column: "CreatedTime",
                value: new DateTime(2024, 1, 3, 14, 46, 33, 393, DateTimeKind.Local).AddTicks(5636));

            migrationBuilder.UpdateData(
                table: "Pets",
                keyColumn: "Id",
                keyValue: 10,
                column: "CreatedTime",
                value: new DateTime(2023, 11, 3, 14, 46, 33, 393, DateTimeKind.Local).AddTicks(5641));

            migrationBuilder.UpdateData(
                table: "Pets",
                keyColumn: "Id",
                keyValue: 11,
                column: "CreatedTime",
                value: new DateTime(2024, 8, 3, 14, 46, 33, 393, DateTimeKind.Local).AddTicks(5646));

            migrationBuilder.UpdateData(
                table: "Pets",
                keyColumn: "Id",
                keyValue: 12,
                column: "CreatedTime",
                value: new DateTime(2024, 2, 3, 14, 46, 33, 393, DateTimeKind.Local).AddTicks(5651));

            migrationBuilder.UpdateData(
                table: "Pets",
                keyColumn: "Id",
                keyValue: 13,
                column: "CreatedTime",
                value: new DateTime(2024, 7, 3, 14, 46, 33, 393, DateTimeKind.Local).AddTicks(5656));

            migrationBuilder.UpdateData(
                table: "Pets",
                keyColumn: "Id",
                keyValue: 14,
                column: "CreatedTime",
                value: new DateTime(2024, 5, 3, 14, 46, 33, 393, DateTimeKind.Local).AddTicks(5662));

            migrationBuilder.UpdateData(
                table: "Pets",
                keyColumn: "Id",
                keyValue: 15,
                column: "CreatedTime",
                value: new DateTime(2024, 5, 3, 14, 46, 33, 393, DateTimeKind.Local).AddTicks(5667));

            migrationBuilder.UpdateData(
                table: "Pets",
                keyColumn: "Id",
                keyValue: 16,
                column: "CreatedTime",
                value: new DateTime(2024, 5, 3, 14, 46, 33, 393, DateTimeKind.Local).AddTicks(5672));

            migrationBuilder.UpdateData(
                table: "Pets",
                keyColumn: "Id",
                keyValue: 17,
                column: "CreatedTime",
                value: new DateTime(2024, 7, 3, 14, 46, 33, 393, DateTimeKind.Local).AddTicks(5677));

            migrationBuilder.UpdateData(
                table: "Pets",
                keyColumn: "Id",
                keyValue: 18,
                column: "CreatedTime",
                value: new DateTime(2023, 10, 3, 14, 46, 33, 393, DateTimeKind.Local).AddTicks(5682));

            migrationBuilder.UpdateData(
                table: "Pets",
                keyColumn: "Id",
                keyValue: 19,
                column: "CreatedTime",
                value: new DateTime(2024, 7, 3, 14, 46, 33, 393, DateTimeKind.Local).AddTicks(5687));

            migrationBuilder.UpdateData(
                table: "Pets",
                keyColumn: "Id",
                keyValue: 20,
                column: "CreatedTime",
                value: new DateTime(2024, 6, 3, 14, 46, 33, 393, DateTimeKind.Local).AddTicks(5693));

            migrationBuilder.UpdateData(
                table: "Pets",
                keyColumn: "Id",
                keyValue: 21,
                column: "CreatedTime",
                value: new DateTime(2024, 8, 3, 14, 46, 33, 393, DateTimeKind.Local).AddTicks(5697));

            migrationBuilder.UpdateData(
                table: "Pets",
                keyColumn: "Id",
                keyValue: 22,
                column: "CreatedTime",
                value: new DateTime(2024, 2, 3, 14, 46, 33, 393, DateTimeKind.Local).AddTicks(5702));

            migrationBuilder.UpdateData(
                table: "Pets",
                keyColumn: "Id",
                keyValue: 23,
                column: "CreatedTime",
                value: new DateTime(2023, 10, 3, 14, 46, 33, 393, DateTimeKind.Local).AddTicks(5709));

            migrationBuilder.UpdateData(
                table: "Pets",
                keyColumn: "Id",
                keyValue: 24,
                column: "CreatedTime",
                value: new DateTime(2024, 1, 3, 14, 46, 33, 393, DateTimeKind.Local).AddTicks(5714));

            migrationBuilder.UpdateData(
                table: "Pets",
                keyColumn: "Id",
                keyValue: 25,
                column: "CreatedTime",
                value: new DateTime(2023, 12, 3, 14, 46, 33, 393, DateTimeKind.Local).AddTicks(5719));

            migrationBuilder.UpdateData(
                table: "Pets",
                keyColumn: "Id",
                keyValue: 26,
                column: "CreatedTime",
                value: new DateTime(2024, 4, 3, 14, 46, 33, 393, DateTimeKind.Local).AddTicks(5726));

            migrationBuilder.UpdateData(
                table: "Pets",
                keyColumn: "Id",
                keyValue: 27,
                column: "CreatedTime",
                value: new DateTime(2024, 3, 3, 14, 46, 33, 393, DateTimeKind.Local).AddTicks(5732));

            migrationBuilder.UpdateData(
                table: "Pets",
                keyColumn: "Id",
                keyValue: 28,
                column: "CreatedTime",
                value: new DateTime(2024, 5, 3, 14, 46, 33, 393, DateTimeKind.Local).AddTicks(5737));

            migrationBuilder.UpdateData(
                table: "Pets",
                keyColumn: "Id",
                keyValue: 29,
                column: "CreatedTime",
                value: new DateTime(2024, 1, 3, 14, 46, 33, 393, DateTimeKind.Local).AddTicks(5742));

            migrationBuilder.UpdateData(
                table: "Pets",
                keyColumn: "Id",
                keyValue: 30,
                column: "CreatedTime",
                value: new DateTime(2024, 5, 3, 14, 46, 33, 393, DateTimeKind.Local).AddTicks(5747));

            migrationBuilder.UpdateData(
                table: "Pets",
                keyColumn: "Id",
                keyValue: 31,
                column: "CreatedTime",
                value: new DateTime(2024, 4, 3, 14, 46, 33, 393, DateTimeKind.Local).AddTicks(5752));

            migrationBuilder.UpdateData(
                table: "Pets",
                keyColumn: "Id",
                keyValue: 32,
                column: "CreatedTime",
                value: new DateTime(2024, 4, 3, 14, 46, 33, 393, DateTimeKind.Local).AddTicks(5758));

            migrationBuilder.UpdateData(
                table: "Pets",
                keyColumn: "Id",
                keyValue: 33,
                column: "CreatedTime",
                value: new DateTime(2024, 3, 3, 14, 46, 33, 393, DateTimeKind.Local).AddTicks(5763));

            migrationBuilder.UpdateData(
                table: "Pets",
                keyColumn: "Id",
                keyValue: 34,
                column: "CreatedTime",
                value: new DateTime(2023, 12, 3, 14, 46, 33, 393, DateTimeKind.Local).AddTicks(5767));

            migrationBuilder.UpdateData(
                table: "Pets",
                keyColumn: "Id",
                keyValue: 35,
                column: "CreatedTime",
                value: new DateTime(2024, 6, 3, 14, 46, 33, 393, DateTimeKind.Local).AddTicks(5773));

            migrationBuilder.UpdateData(
                table: "Pets",
                keyColumn: "Id",
                keyValue: 36,
                column: "CreatedTime",
                value: new DateTime(2024, 2, 3, 14, 46, 33, 393, DateTimeKind.Local).AddTicks(5777));

            migrationBuilder.UpdateData(
                table: "Pets",
                keyColumn: "Id",
                keyValue: 37,
                column: "CreatedTime",
                value: new DateTime(2023, 12, 3, 14, 46, 33, 393, DateTimeKind.Local).AddTicks(5782));

            migrationBuilder.UpdateData(
                table: "Pets",
                keyColumn: "Id",
                keyValue: 38,
                column: "CreatedTime",
                value: new DateTime(2024, 7, 3, 14, 46, 33, 393, DateTimeKind.Local).AddTicks(5788));

            migrationBuilder.UpdateData(
                table: "Pets",
                keyColumn: "Id",
                keyValue: 39,
                column: "CreatedTime",
                value: new DateTime(2024, 7, 3, 14, 46, 33, 393, DateTimeKind.Local).AddTicks(5793));

            migrationBuilder.UpdateData(
                table: "Pets",
                keyColumn: "Id",
                keyValue: 40,
                column: "CreatedTime",
                value: new DateTime(2024, 3, 3, 14, 46, 33, 393, DateTimeKind.Local).AddTicks(5798));

            migrationBuilder.UpdateData(
                table: "Pets",
                keyColumn: "Id",
                keyValue: 41,
                column: "CreatedTime",
                value: new DateTime(2024, 5, 3, 14, 46, 33, 393, DateTimeKind.Local).AddTicks(5843));

            migrationBuilder.UpdateData(
                table: "Pets",
                keyColumn: "Id",
                keyValue: 42,
                column: "CreatedTime",
                value: new DateTime(2024, 2, 3, 14, 46, 33, 393, DateTimeKind.Local).AddTicks(5849));

            migrationBuilder.UpdateData(
                table: "Pets",
                keyColumn: "Id",
                keyValue: 43,
                column: "CreatedTime",
                value: new DateTime(2023, 12, 3, 14, 46, 33, 393, DateTimeKind.Local).AddTicks(5855));

            migrationBuilder.UpdateData(
                table: "Pets",
                keyColumn: "Id",
                keyValue: 44,
                column: "CreatedTime",
                value: new DateTime(2024, 1, 3, 14, 46, 33, 393, DateTimeKind.Local).AddTicks(5860));

            migrationBuilder.UpdateData(
                table: "Pets",
                keyColumn: "Id",
                keyValue: 45,
                column: "CreatedTime",
                value: new DateTime(2023, 11, 3, 14, 46, 33, 393, DateTimeKind.Local).AddTicks(5865));

            migrationBuilder.UpdateData(
                table: "Pets",
                keyColumn: "Id",
                keyValue: 46,
                column: "CreatedTime",
                value: new DateTime(2024, 1, 3, 14, 46, 33, 393, DateTimeKind.Local).AddTicks(5871));

            migrationBuilder.UpdateData(
                table: "Pets",
                keyColumn: "Id",
                keyValue: 47,
                column: "CreatedTime",
                value: new DateTime(2023, 10, 3, 14, 46, 33, 393, DateTimeKind.Local).AddTicks(5876));

            migrationBuilder.UpdateData(
                table: "Pets",
                keyColumn: "Id",
                keyValue: 48,
                column: "CreatedTime",
                value: new DateTime(2023, 12, 3, 14, 46, 33, 393, DateTimeKind.Local).AddTicks(5882));

            migrationBuilder.UpdateData(
                table: "Pets",
                keyColumn: "Id",
                keyValue: 49,
                column: "CreatedTime",
                value: new DateTime(2023, 11, 3, 14, 46, 33, 393, DateTimeKind.Local).AddTicks(5887));

            migrationBuilder.UpdateData(
                table: "Pets",
                keyColumn: "Id",
                keyValue: 50,
                column: "CreatedTime",
                value: new DateTime(2024, 2, 3, 14, 46, 33, 393, DateTimeKind.Local).AddTicks(5892));

            migrationBuilder.UpdateData(
                table: "Shelters",
                keyColumn: "Id",
                keyValue: 1021,
                columns: new[] { "CreatedTime", "LastUpdatedTime" },
                values: new object[] { new DateTime(2024, 9, 3, 10, 46, 33, 380, DateTimeKind.Utc).AddTicks(4634), new DateTime(2024, 9, 3, 10, 46, 33, 380, DateTimeKind.Utc).AddTicks(4636) });

            migrationBuilder.UpdateData(
                table: "Shelters",
                keyColumn: "Id",
                keyValue: 1022,
                columns: new[] { "CreatedTime", "LastUpdatedTime" },
                values: new object[] { new DateTime(2024, 9, 3, 10, 46, 33, 380, DateTimeKind.Utc).AddTicks(4666), new DateTime(2024, 9, 3, 10, 46, 33, 380, DateTimeKind.Utc).AddTicks(4666) });

            migrationBuilder.UpdateData(
                table: "Shelters",
                keyColumn: "Id",
                keyValue: 1023,
                columns: new[] { "CreatedTime", "LastUpdatedTime" },
                values: new object[] { new DateTime(2024, 9, 3, 10, 46, 33, 380, DateTimeKind.Utc).AddTicks(4676), new DateTime(2024, 9, 3, 10, 46, 33, 380, DateTimeKind.Utc).AddTicks(4676) });

            migrationBuilder.UpdateData(
                table: "Shelters",
                keyColumn: "Id",
                keyValue: 1024,
                columns: new[] { "CreatedTime", "LastUpdatedTime" },
                values: new object[] { new DateTime(2024, 9, 3, 10, 46, 33, 380, DateTimeKind.Utc).AddTicks(4685), new DateTime(2024, 9, 3, 10, 46, 33, 380, DateTimeKind.Utc).AddTicks(4685) });

            migrationBuilder.UpdateData(
                table: "Shelters",
                keyColumn: "Id",
                keyValue: 1025,
                columns: new[] { "CreatedTime", "LastUpdatedTime" },
                values: new object[] { new DateTime(2024, 9, 3, 10, 46, 33, 380, DateTimeKind.Utc).AddTicks(4693), new DateTime(2024, 9, 3, 10, 46, 33, 380, DateTimeKind.Utc).AddTicks(4694) });

            migrationBuilder.UpdateData(
                table: "Shelters",
                keyColumn: "Id",
                keyValue: 1026,
                columns: new[] { "CreatedTime", "LastUpdatedTime" },
                values: new object[] { new DateTime(2024, 9, 3, 10, 46, 33, 380, DateTimeKind.Utc).AddTicks(4705), new DateTime(2024, 9, 3, 10, 46, 33, 380, DateTimeKind.Utc).AddTicks(4706) });

            migrationBuilder.UpdateData(
                table: "Shelters",
                keyColumn: "Id",
                keyValue: 1027,
                columns: new[] { "CreatedTime", "LastUpdatedTime" },
                values: new object[] { new DateTime(2024, 9, 3, 10, 46, 33, 380, DateTimeKind.Utc).AddTicks(4836), new DateTime(2024, 9, 3, 10, 46, 33, 380, DateTimeKind.Utc).AddTicks(4836) });

            migrationBuilder.UpdateData(
                table: "Shelters",
                keyColumn: "Id",
                keyValue: 1028,
                columns: new[] { "CreatedTime", "LastUpdatedTime" },
                values: new object[] { new DateTime(2024, 9, 3, 10, 46, 33, 380, DateTimeKind.Utc).AddTicks(4845), new DateTime(2024, 9, 3, 10, 46, 33, 380, DateTimeKind.Utc).AddTicks(4845) });

            migrationBuilder.UpdateData(
                table: "Shelters",
                keyColumn: "Id",
                keyValue: 1029,
                columns: new[] { "CreatedTime", "LastUpdatedTime" },
                values: new object[] { new DateTime(2024, 9, 3, 10, 46, 33, 380, DateTimeKind.Utc).AddTicks(4853), new DateTime(2024, 9, 3, 10, 46, 33, 380, DateTimeKind.Utc).AddTicks(4854) });

            migrationBuilder.UpdateData(
                table: "Shelters",
                keyColumn: "Id",
                keyValue: 1030,
                columns: new[] { "CreatedTime", "LastUpdatedTime" },
                values: new object[] { new DateTime(2024, 9, 3, 10, 46, 33, 380, DateTimeKind.Utc).AddTicks(4864), new DateTime(2024, 9, 3, 10, 46, 33, 380, DateTimeKind.Utc).AddTicks(4865) });

            migrationBuilder.UpdateData(
                table: "Shelters",
                keyColumn: "Id",
                keyValue: 1031,
                columns: new[] { "CreatedTime", "LastUpdatedTime" },
                values: new object[] { new DateTime(2024, 9, 3, 10, 46, 33, 380, DateTimeKind.Utc).AddTicks(4873), new DateTime(2024, 9, 3, 10, 46, 33, 380, DateTimeKind.Utc).AddTicks(4874) });

            migrationBuilder.UpdateData(
                table: "Shelters",
                keyColumn: "Id",
                keyValue: 1032,
                columns: new[] { "CreatedTime", "LastUpdatedTime" },
                values: new object[] { new DateTime(2024, 9, 3, 10, 46, 33, 380, DateTimeKind.Utc).AddTicks(4882), new DateTime(2024, 9, 3, 10, 46, 33, 380, DateTimeKind.Utc).AddTicks(4882) });

            migrationBuilder.UpdateData(
                table: "Shelters",
                keyColumn: "Id",
                keyValue: 1033,
                columns: new[] { "CreatedTime", "LastUpdatedTime" },
                values: new object[] { new DateTime(2024, 9, 3, 10, 46, 33, 380, DateTimeKind.Utc).AddTicks(4890), new DateTime(2024, 9, 3, 10, 46, 33, 380, DateTimeKind.Utc).AddTicks(4891) });

            migrationBuilder.UpdateData(
                table: "Shelters",
                keyColumn: "Id",
                keyValue: 1034,
                columns: new[] { "CreatedTime", "LastUpdatedTime" },
                values: new object[] { new DateTime(2024, 9, 3, 10, 46, 33, 380, DateTimeKind.Utc).AddTicks(4899), new DateTime(2024, 9, 3, 10, 46, 33, 380, DateTimeKind.Utc).AddTicks(4900) });

            migrationBuilder.UpdateData(
                table: "Shelters",
                keyColumn: "Id",
                keyValue: 1035,
                columns: new[] { "CreatedTime", "LastUpdatedTime" },
                values: new object[] { new DateTime(2024, 9, 3, 10, 46, 33, 380, DateTimeKind.Utc).AddTicks(4908), new DateTime(2024, 9, 3, 10, 46, 33, 380, DateTimeKind.Utc).AddTicks(4908) });

            migrationBuilder.UpdateData(
                table: "Shelters",
                keyColumn: "Id",
                keyValue: 1036,
                columns: new[] { "CreatedTime", "LastUpdatedTime" },
                values: new object[] { new DateTime(2024, 9, 3, 10, 46, 33, 380, DateTimeKind.Utc).AddTicks(4916), new DateTime(2024, 9, 3, 10, 46, 33, 380, DateTimeKind.Utc).AddTicks(4917) });

            migrationBuilder.UpdateData(
                table: "Shelters",
                keyColumn: "Id",
                keyValue: 1037,
                columns: new[] { "CreatedTime", "LastUpdatedTime" },
                values: new object[] { new DateTime(2024, 9, 3, 10, 46, 33, 380, DateTimeKind.Utc).AddTicks(4925), new DateTime(2024, 9, 3, 10, 46, 33, 380, DateTimeKind.Utc).AddTicks(4926) });

            migrationBuilder.UpdateData(
                table: "Shelters",
                keyColumn: "Id",
                keyValue: 1038,
                columns: new[] { "CreatedTime", "LastUpdatedTime" },
                values: new object[] { new DateTime(2024, 9, 3, 10, 46, 33, 380, DateTimeKind.Utc).AddTicks(4935), new DateTime(2024, 9, 3, 10, 46, 33, 380, DateTimeKind.Utc).AddTicks(4936) });

            migrationBuilder.UpdateData(
                table: "Shelters",
                keyColumn: "Id",
                keyValue: 1039,
                columns: new[] { "CreatedTime", "LastUpdatedTime" },
                values: new object[] { new DateTime(2024, 9, 3, 10, 46, 33, 380, DateTimeKind.Utc).AddTicks(4943), new DateTime(2024, 9, 3, 10, 46, 33, 380, DateTimeKind.Utc).AddTicks(4944) });

            migrationBuilder.UpdateData(
                table: "Shelters",
                keyColumn: "Id",
                keyValue: 1040,
                columns: new[] { "CreatedTime", "LastUpdatedTime" },
                values: new object[] { new DateTime(2024, 9, 3, 10, 46, 33, 380, DateTimeKind.Utc).AddTicks(5004), new DateTime(2024, 9, 3, 10, 46, 33, 380, DateTimeKind.Utc).AddTicks(5005) });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: 2001,
                columns: new[] { "ConcurrencyStamp", "CreatedTime", "LastUpdatedTime", "RefreshTokenCreateTime" },
                values: new object[] { "19461cad-c40a-497a-b86c-5eda8904ebd2", new DateTime(2024, 9, 3, 7, 57, 45, 905, DateTimeKind.Utc).AddTicks(1492), new DateTime(2024, 9, 3, 7, 57, 45, 905, DateTimeKind.Utc).AddTicks(1493), new DateTime(2024, 9, 3, 7, 57, 45, 905, DateTimeKind.Utc).AddTicks(1486) });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: 2002,
                columns: new[] { "ConcurrencyStamp", "CreatedTime", "LastUpdatedTime", "RefreshTokenCreateTime" },
                values: new object[] { "4e5315e0-c1b3-435d-a716-74cb3ca66939", new DateTime(2024, 9, 3, 7, 57, 45, 905, DateTimeKind.Utc).AddTicks(1516), new DateTime(2024, 9, 3, 7, 57, 45, 905, DateTimeKind.Utc).AddTicks(1516), new DateTime(2024, 9, 3, 7, 57, 45, 905, DateTimeKind.Utc).AddTicks(1512) });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: 2003,
                columns: new[] { "ConcurrencyStamp", "CreatedTime", "LastUpdatedTime", "RefreshTokenCreateTime" },
                values: new object[] { "54cc2962-2567-4e82-9602-3eed852f173a", new DateTime(2024, 9, 3, 7, 57, 45, 905, DateTimeKind.Utc).AddTicks(1529), new DateTime(2024, 9, 3, 7, 57, 45, 905, DateTimeKind.Utc).AddTicks(1530), new DateTime(2024, 9, 3, 7, 57, 45, 905, DateTimeKind.Utc).AddTicks(1526) });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: 2004,
                columns: new[] { "ConcurrencyStamp", "CreatedTime", "LastUpdatedTime", "RefreshTokenCreateTime" },
                values: new object[] { "8054f405-ca10-4e3f-a352-ee881fea198a", new DateTime(2024, 9, 3, 7, 57, 45, 905, DateTimeKind.Utc).AddTicks(1541), new DateTime(2024, 9, 3, 7, 57, 45, 905, DateTimeKind.Utc).AddTicks(1542), new DateTime(2024, 9, 3, 7, 57, 45, 905, DateTimeKind.Utc).AddTicks(1538) });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: 2005,
                columns: new[] { "ConcurrencyStamp", "CreatedTime", "LastUpdatedTime", "RefreshTokenCreateTime" },
                values: new object[] { "38000c52-3932-4cb6-8059-e6cb88ca7491", new DateTime(2024, 9, 3, 7, 57, 45, 905, DateTimeKind.Utc).AddTicks(1571), new DateTime(2024, 9, 3, 7, 57, 45, 905, DateTimeKind.Utc).AddTicks(1572), new DateTime(2024, 9, 3, 7, 57, 45, 905, DateTimeKind.Utc).AddTicks(1552) });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: 2006,
                columns: new[] { "ConcurrencyStamp", "CreatedTime", "LastUpdatedTime", "RefreshTokenCreateTime" },
                values: new object[] { "2ccd1597-8447-4c08-a54c-79fb5fdb94b5", new DateTime(2024, 9, 3, 7, 57, 45, 905, DateTimeKind.Utc).AddTicks(1583), new DateTime(2024, 9, 3, 7, 57, 45, 905, DateTimeKind.Utc).AddTicks(1584), new DateTime(2024, 9, 3, 7, 57, 45, 905, DateTimeKind.Utc).AddTicks(1580) });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: 2007,
                columns: new[] { "ConcurrencyStamp", "CreatedTime", "LastUpdatedTime", "RefreshTokenCreateTime" },
                values: new object[] { "7b574486-03ee-4fab-bd7d-e78423f860dc", new DateTime(2024, 9, 3, 7, 57, 45, 905, DateTimeKind.Utc).AddTicks(1594), new DateTime(2024, 9, 3, 7, 57, 45, 905, DateTimeKind.Utc).AddTicks(1595), new DateTime(2024, 9, 3, 7, 57, 45, 905, DateTimeKind.Utc).AddTicks(1591) });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: 2008,
                columns: new[] { "ConcurrencyStamp", "CreatedTime", "LastUpdatedTime", "RefreshTokenCreateTime" },
                values: new object[] { "8e7341ab-ae50-4fca-92c9-cb970d1205b5", new DateTime(2024, 9, 3, 7, 57, 45, 905, DateTimeKind.Utc).AddTicks(1606), new DateTime(2024, 9, 3, 7, 57, 45, 905, DateTimeKind.Utc).AddTicks(1606), new DateTime(2024, 9, 3, 7, 57, 45, 905, DateTimeKind.Utc).AddTicks(1602) });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: 2009,
                columns: new[] { "ConcurrencyStamp", "CreatedTime", "LastUpdatedTime", "RefreshTokenCreateTime" },
                values: new object[] { "0031a4c7-6ab6-4909-a47c-d77fa322c534", new DateTime(2024, 9, 3, 7, 57, 45, 905, DateTimeKind.Utc).AddTicks(1619), new DateTime(2024, 9, 3, 7, 57, 45, 905, DateTimeKind.Utc).AddTicks(1619), new DateTime(2024, 9, 3, 7, 57, 45, 905, DateTimeKind.Utc).AddTicks(1615) });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: 2010,
                columns: new[] { "ConcurrencyStamp", "CreatedTime", "LastUpdatedTime", "RefreshTokenCreateTime" },
                values: new object[] { "3ba8ee09-e845-4d1f-81bc-5caa232d6185", new DateTime(2024, 9, 3, 7, 57, 45, 905, DateTimeKind.Utc).AddTicks(1668), new DateTime(2024, 9, 3, 7, 57, 45, 905, DateTimeKind.Utc).AddTicks(1668), new DateTime(2024, 9, 3, 7, 57, 45, 905, DateTimeKind.Utc).AddTicks(1665) });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: 2011,
                columns: new[] { "ConcurrencyStamp", "CreatedTime", "LastUpdatedTime", "RefreshTokenCreateTime" },
                values: new object[] { "bdebb4a5-0177-4102-b9e2-9f17316dee17", new DateTime(2024, 9, 3, 7, 57, 45, 905, DateTimeKind.Utc).AddTicks(1682), new DateTime(2024, 9, 3, 7, 57, 45, 905, DateTimeKind.Utc).AddTicks(1683), new DateTime(2024, 9, 3, 7, 57, 45, 905, DateTimeKind.Utc).AddTicks(1679) });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: 2012,
                columns: new[] { "ConcurrencyStamp", "CreatedTime", "LastUpdatedTime", "RefreshTokenCreateTime" },
                values: new object[] { "acc64808-7a18-4408-9b9e-7d1b3651574a", new DateTime(2024, 9, 3, 7, 57, 45, 905, DateTimeKind.Utc).AddTicks(1694), new DateTime(2024, 9, 3, 7, 57, 45, 905, DateTimeKind.Utc).AddTicks(1694), new DateTime(2024, 9, 3, 7, 57, 45, 905, DateTimeKind.Utc).AddTicks(1691) });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: 2013,
                columns: new[] { "ConcurrencyStamp", "CreatedTime", "LastUpdatedTime", "RefreshTokenCreateTime" },
                values: new object[] { "c32f45f4-6421-455e-b43e-7e1cfb0fe6a0", new DateTime(2024, 9, 3, 7, 57, 45, 905, DateTimeKind.Utc).AddTicks(1710), new DateTime(2024, 9, 3, 7, 57, 45, 905, DateTimeKind.Utc).AddTicks(1710), new DateTime(2024, 9, 3, 7, 57, 45, 905, DateTimeKind.Utc).AddTicks(1702) });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: 2014,
                columns: new[] { "ConcurrencyStamp", "CreatedTime", "LastUpdatedTime", "RefreshTokenCreateTime" },
                values: new object[] { "0d5cf893-5dd0-45fc-b664-84017ce6b59b", new DateTime(2024, 9, 3, 7, 57, 45, 905, DateTimeKind.Utc).AddTicks(1721), new DateTime(2024, 9, 3, 7, 57, 45, 905, DateTimeKind.Utc).AddTicks(1722), new DateTime(2024, 9, 3, 7, 57, 45, 905, DateTimeKind.Utc).AddTicks(1718) });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: 2015,
                columns: new[] { "ConcurrencyStamp", "CreatedTime", "LastUpdatedTime", "RefreshTokenCreateTime" },
                values: new object[] { "9328263a-4eaa-4686-a507-d14ba019a762", new DateTime(2024, 9, 3, 7, 57, 45, 905, DateTimeKind.Utc).AddTicks(1733), new DateTime(2024, 9, 3, 7, 57, 45, 905, DateTimeKind.Utc).AddTicks(1733), new DateTime(2024, 9, 3, 7, 57, 45, 905, DateTimeKind.Utc).AddTicks(1730) });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: 2016,
                columns: new[] { "ConcurrencyStamp", "CreatedTime", "LastUpdatedTime", "RefreshTokenCreateTime" },
                values: new object[] { "e60bcd39-be31-438c-a350-92392e6a2b51", new DateTime(2024, 9, 3, 7, 57, 45, 905, DateTimeKind.Utc).AddTicks(1744), new DateTime(2024, 9, 3, 7, 57, 45, 905, DateTimeKind.Utc).AddTicks(1745), new DateTime(2024, 9, 3, 7, 57, 45, 905, DateTimeKind.Utc).AddTicks(1741) });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: 2017,
                columns: new[] { "ConcurrencyStamp", "CreatedTime", "LastUpdatedTime", "RefreshTokenCreateTime" },
                values: new object[] { "c6da50e1-95e3-473d-9e57-2e9044ec7b8d", new DateTime(2024, 9, 3, 7, 57, 45, 905, DateTimeKind.Utc).AddTicks(1757), new DateTime(2024, 9, 3, 7, 57, 45, 905, DateTimeKind.Utc).AddTicks(1757), new DateTime(2024, 9, 3, 7, 57, 45, 905, DateTimeKind.Utc).AddTicks(1754) });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: 2018,
                columns: new[] { "ConcurrencyStamp", "CreatedTime", "LastUpdatedTime", "RefreshTokenCreateTime" },
                values: new object[] { "e1435046-60c5-4193-887f-76b613a100b8", new DateTime(2024, 9, 3, 7, 57, 45, 905, DateTimeKind.Utc).AddTicks(1768), new DateTime(2024, 9, 3, 7, 57, 45, 905, DateTimeKind.Utc).AddTicks(1769), new DateTime(2024, 9, 3, 7, 57, 45, 905, DateTimeKind.Utc).AddTicks(1765) });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: 2019,
                columns: new[] { "ConcurrencyStamp", "CreatedTime", "LastUpdatedTime", "RefreshTokenCreateTime" },
                values: new object[] { "8e0f9c70-86b7-47c2-afec-7d225afcdd7d", new DateTime(2024, 9, 3, 7, 57, 45, 905, DateTimeKind.Utc).AddTicks(1780), new DateTime(2024, 9, 3, 7, 57, 45, 905, DateTimeKind.Utc).AddTicks(1780), new DateTime(2024, 9, 3, 7, 57, 45, 905, DateTimeKind.Utc).AddTicks(1777) });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: 2020,
                columns: new[] { "ConcurrencyStamp", "CreatedTime", "LastUpdatedTime", "RefreshTokenCreateTime" },
                values: new object[] { "ba2610a4-9ad4-4c79-8114-a1bbd336b3b0", new DateTime(2024, 9, 3, 7, 57, 45, 905, DateTimeKind.Utc).AddTicks(1814), new DateTime(2024, 9, 3, 7, 57, 45, 905, DateTimeKind.Utc).AddTicks(1815), new DateTime(2024, 9, 3, 7, 57, 45, 905, DateTimeKind.Utc).AddTicks(1811) });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: 2021,
                columns: new[] { "ConcurrencyStamp", "CreatedTime", "LastUpdatedTime", "RefreshTokenCreateTime" },
                values: new object[] { "95c1a5b9-8f59-42e1-bab0-67280a965722", new DateTime(2024, 9, 3, 7, 57, 45, 905, DateTimeKind.Utc).AddTicks(1830), new DateTime(2024, 9, 3, 7, 57, 45, 905, DateTimeKind.Utc).AddTicks(1830), new DateTime(2024, 9, 3, 7, 57, 45, 905, DateTimeKind.Utc).AddTicks(1823) });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: 2022,
                columns: new[] { "ConcurrencyStamp", "CreatedTime", "LastUpdatedTime", "RefreshTokenCreateTime" },
                values: new object[] { "bf85a1fa-1770-4e37-b5c9-9086c7fe2184", new DateTime(2024, 9, 3, 7, 57, 45, 905, DateTimeKind.Utc).AddTicks(1853), new DateTime(2024, 9, 3, 7, 57, 45, 905, DateTimeKind.Utc).AddTicks(1853), new DateTime(2024, 9, 3, 7, 57, 45, 905, DateTimeKind.Utc).AddTicks(1849) });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: 2023,
                columns: new[] { "ConcurrencyStamp", "CreatedTime", "LastUpdatedTime", "RefreshTokenCreateTime" },
                values: new object[] { "05d12388-26c7-4af7-94c3-3849d04563b0", new DateTime(2024, 9, 3, 7, 57, 45, 905, DateTimeKind.Utc).AddTicks(1866), new DateTime(2024, 9, 3, 7, 57, 45, 905, DateTimeKind.Utc).AddTicks(1866), new DateTime(2024, 9, 3, 7, 57, 45, 905, DateTimeKind.Utc).AddTicks(1863) });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: 2024,
                columns: new[] { "ConcurrencyStamp", "CreatedTime", "LastUpdatedTime", "RefreshTokenCreateTime" },
                values: new object[] { "ebb21f31-e0bb-49b3-af53-9eaecedbacd9", new DateTime(2024, 9, 3, 7, 57, 45, 905, DateTimeKind.Utc).AddTicks(1878), new DateTime(2024, 9, 3, 7, 57, 45, 905, DateTimeKind.Utc).AddTicks(1879), new DateTime(2024, 9, 3, 7, 57, 45, 905, DateTimeKind.Utc).AddTicks(1875) });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: 2025,
                columns: new[] { "ConcurrencyStamp", "CreatedTime", "LastUpdatedTime", "RefreshTokenCreateTime" },
                values: new object[] { "632cedec-fa89-4f0e-9406-3d3836421a26", new DateTime(2024, 9, 3, 7, 57, 45, 905, DateTimeKind.Utc).AddTicks(1892), new DateTime(2024, 9, 3, 7, 57, 45, 905, DateTimeKind.Utc).AddTicks(1892), new DateTime(2024, 9, 3, 7, 57, 45, 905, DateTimeKind.Utc).AddTicks(1888) });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: 2026,
                columns: new[] { "ConcurrencyStamp", "CreatedTime", "LastUpdatedTime", "RefreshTokenCreateTime" },
                values: new object[] { "7d5bff56-cf86-4324-b41f-433efa9801f3", new DateTime(2024, 9, 3, 7, 57, 45, 905, DateTimeKind.Utc).AddTicks(1904), new DateTime(2024, 9, 3, 7, 57, 45, 905, DateTimeKind.Utc).AddTicks(1905), new DateTime(2024, 9, 3, 7, 57, 45, 905, DateTimeKind.Utc).AddTicks(1901) });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: 2027,
                columns: new[] { "ConcurrencyStamp", "CreatedTime", "LastUpdatedTime", "RefreshTokenCreateTime" },
                values: new object[] { "4e51cfd8-79ae-4363-a7fb-5234c57f43d1", new DateTime(2024, 9, 3, 7, 57, 45, 905, DateTimeKind.Utc).AddTicks(1916), new DateTime(2024, 9, 3, 7, 57, 45, 905, DateTimeKind.Utc).AddTicks(1917), new DateTime(2024, 9, 3, 7, 57, 45, 905, DateTimeKind.Utc).AddTicks(1914) });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: 2028,
                columns: new[] { "ConcurrencyStamp", "CreatedTime", "LastUpdatedTime", "RefreshTokenCreateTime" },
                values: new object[] { "b55e6930-cab6-4833-9b6a-04f77ccb93a1", new DateTime(2024, 9, 3, 7, 57, 45, 905, DateTimeKind.Utc).AddTicks(1995), new DateTime(2024, 9, 3, 7, 57, 45, 905, DateTimeKind.Utc).AddTicks(1995), new DateTime(2024, 9, 3, 7, 57, 45, 905, DateTimeKind.Utc).AddTicks(1926) });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: 2029,
                columns: new[] { "ConcurrencyStamp", "CreatedTime", "LastUpdatedTime", "RefreshTokenCreateTime" },
                values: new object[] { "63e0ab54-1a62-4be9-84f6-b31972345be3", new DateTime(2024, 9, 3, 7, 57, 45, 905, DateTimeKind.Utc).AddTicks(2013), new DateTime(2024, 9, 3, 7, 57, 45, 905, DateTimeKind.Utc).AddTicks(2013), new DateTime(2024, 9, 3, 7, 57, 45, 905, DateTimeKind.Utc).AddTicks(2005) });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: 2030,
                columns: new[] { "ConcurrencyStamp", "CreatedTime", "LastUpdatedTime", "RefreshTokenCreateTime" },
                values: new object[] { "20146cca-e7fa-4c0f-b912-488d0954ff28", new DateTime(2024, 9, 3, 7, 57, 45, 905, DateTimeKind.Utc).AddTicks(2026), new DateTime(2024, 9, 3, 7, 57, 45, 905, DateTimeKind.Utc).AddTicks(2026), new DateTime(2024, 9, 3, 7, 57, 45, 905, DateTimeKind.Utc).AddTicks(2022) });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: 2031,
                columns: new[] { "ConcurrencyStamp", "CreatedTime", "LastUpdatedTime", "RefreshTokenCreateTime" },
                values: new object[] { "0f2bbc7d-7ba1-4009-9bd8-4f1303559e5b", new DateTime(2024, 9, 3, 7, 57, 45, 905, DateTimeKind.Utc).AddTicks(2039), new DateTime(2024, 9, 3, 7, 57, 45, 905, DateTimeKind.Utc).AddTicks(2039), new DateTime(2024, 9, 3, 7, 57, 45, 905, DateTimeKind.Utc).AddTicks(2036) });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: 2032,
                columns: new[] { "ConcurrencyStamp", "CreatedTime", "LastUpdatedTime", "RefreshTokenCreateTime" },
                values: new object[] { "ffd0d0c9-4354-4627-b2ae-eb3097d3930a", new DateTime(2024, 9, 3, 7, 57, 45, 905, DateTimeKind.Utc).AddTicks(2051), new DateTime(2024, 9, 3, 7, 57, 45, 905, DateTimeKind.Utc).AddTicks(2051), new DateTime(2024, 9, 3, 7, 57, 45, 905, DateTimeKind.Utc).AddTicks(2048) });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: 2033,
                columns: new[] { "ConcurrencyStamp", "CreatedTime", "LastUpdatedTime", "RefreshTokenCreateTime" },
                values: new object[] { "f13630b7-92aa-49e7-92d1-778f5f0fff00", new DateTime(2024, 9, 3, 7, 57, 45, 905, DateTimeKind.Utc).AddTicks(2066), new DateTime(2024, 9, 3, 7, 57, 45, 905, DateTimeKind.Utc).AddTicks(2066), new DateTime(2024, 9, 3, 7, 57, 45, 905, DateTimeKind.Utc).AddTicks(2063) });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: 2034,
                columns: new[] { "ConcurrencyStamp", "CreatedTime", "LastUpdatedTime", "RefreshTokenCreateTime" },
                values: new object[] { "fbb9ec61-f786-410e-a44d-ccdb42ad43e2", new DateTime(2024, 9, 3, 7, 57, 45, 905, DateTimeKind.Utc).AddTicks(2078), new DateTime(2024, 9, 3, 7, 57, 45, 905, DateTimeKind.Utc).AddTicks(2078), new DateTime(2024, 9, 3, 7, 57, 45, 905, DateTimeKind.Utc).AddTicks(2075) });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: 2035,
                columns: new[] { "ConcurrencyStamp", "CreatedTime", "LastUpdatedTime", "RefreshTokenCreateTime" },
                values: new object[] { "4bf06c3d-fada-4d5d-bfb2-25435a52ab2b", new DateTime(2024, 9, 3, 7, 57, 45, 905, DateTimeKind.Utc).AddTicks(2091), new DateTime(2024, 9, 3, 7, 57, 45, 905, DateTimeKind.Utc).AddTicks(2092), new DateTime(2024, 9, 3, 7, 57, 45, 905, DateTimeKind.Utc).AddTicks(2088) });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: 2036,
                columns: new[] { "ConcurrencyStamp", "CreatedTime", "LastUpdatedTime", "RefreshTokenCreateTime" },
                values: new object[] { "c222b1df-ef73-4d8f-a6f9-5c6c2e98c802", new DateTime(2024, 9, 3, 7, 57, 45, 905, DateTimeKind.Utc).AddTicks(2103), new DateTime(2024, 9, 3, 7, 57, 45, 905, DateTimeKind.Utc).AddTicks(2104), new DateTime(2024, 9, 3, 7, 57, 45, 905, DateTimeKind.Utc).AddTicks(2100) });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: 2037,
                columns: new[] { "ConcurrencyStamp", "CreatedTime", "LastUpdatedTime", "RefreshTokenCreateTime" },
                values: new object[] { "0b532f0b-ccc4-4345-8521-edd2b59016b6", new DateTime(2024, 9, 3, 7, 57, 45, 905, DateTimeKind.Utc).AddTicks(2164), new DateTime(2024, 9, 3, 7, 57, 45, 905, DateTimeKind.Utc).AddTicks(2165), new DateTime(2024, 9, 3, 7, 57, 45, 905, DateTimeKind.Utc).AddTicks(2158) });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: 2038,
                columns: new[] { "ConcurrencyStamp", "CreatedTime", "LastUpdatedTime", "RefreshTokenCreateTime" },
                values: new object[] { "b96dfeab-9d69-4697-bfcb-dcf1c375b322", new DateTime(2024, 9, 3, 7, 57, 45, 905, DateTimeKind.Utc).AddTicks(2177), new DateTime(2024, 9, 3, 7, 57, 45, 905, DateTimeKind.Utc).AddTicks(2178), new DateTime(2024, 9, 3, 7, 57, 45, 905, DateTimeKind.Utc).AddTicks(2174) });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: 2039,
                columns: new[] { "ConcurrencyStamp", "CreatedTime", "LastUpdatedTime", "RefreshTokenCreateTime" },
                values: new object[] { "6fb29a05-03ea-41ee-9f7a-6bc40c2eaabd", new DateTime(2024, 9, 3, 7, 57, 45, 905, DateTimeKind.Utc).AddTicks(2190), new DateTime(2024, 9, 3, 7, 57, 45, 905, DateTimeKind.Utc).AddTicks(2190), new DateTime(2024, 9, 3, 7, 57, 45, 905, DateTimeKind.Utc).AddTicks(2187) });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: 2040,
                columns: new[] { "ConcurrencyStamp", "CreatedTime", "LastUpdatedTime", "RefreshTokenCreateTime" },
                values: new object[] { "ea8797b6-7803-494d-9c12-8ccde3a2d24f", new DateTime(2024, 9, 3, 7, 57, 45, 905, DateTimeKind.Utc).AddTicks(2202), new DateTime(2024, 9, 3, 7, 57, 45, 905, DateTimeKind.Utc).AddTicks(2203), new DateTime(2024, 9, 3, 7, 57, 45, 905, DateTimeKind.Utc).AddTicks(2199) });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: 2041,
                columns: new[] { "ConcurrencyStamp", "CreatedTime", "LastUpdatedTime", "RefreshTokenCreateTime" },
                values: new object[] { "b1277ada-544c-4f44-b1f9-84de8d2d5460", new DateTime(2024, 9, 3, 7, 57, 45, 905, DateTimeKind.Utc).AddTicks(2215), new DateTime(2024, 9, 3, 7, 57, 45, 905, DateTimeKind.Utc).AddTicks(2216), new DateTime(2024, 9, 3, 7, 57, 45, 905, DateTimeKind.Utc).AddTicks(2212) });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: 2042,
                columns: new[] { "ConcurrencyStamp", "CreatedTime", "LastUpdatedTime", "RefreshTokenCreateTime" },
                values: new object[] { "e3d6a6f0-4844-49b2-9797-2ae9d563f7e9", new DateTime(2024, 9, 3, 7, 57, 45, 905, DateTimeKind.Utc).AddTicks(2233), new DateTime(2024, 9, 3, 7, 57, 45, 905, DateTimeKind.Utc).AddTicks(2233), new DateTime(2024, 9, 3, 7, 57, 45, 905, DateTimeKind.Utc).AddTicks(2230) });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: 2043,
                columns: new[] { "ConcurrencyStamp", "CreatedTime", "LastUpdatedTime", "RefreshTokenCreateTime" },
                values: new object[] { "5e5b3ce1-4b74-4718-92e0-ceda3cc9a8db", new DateTime(2024, 9, 3, 7, 57, 45, 905, DateTimeKind.Utc).AddTicks(2245), new DateTime(2024, 9, 3, 7, 57, 45, 905, DateTimeKind.Utc).AddTicks(2246), new DateTime(2024, 9, 3, 7, 57, 45, 905, DateTimeKind.Utc).AddTicks(2241) });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: 2044,
                columns: new[] { "ConcurrencyStamp", "CreatedTime", "LastUpdatedTime", "RefreshTokenCreateTime" },
                values: new object[] { "04062e7f-5216-4e60-a74d-43f9b55b0a5b", new DateTime(2024, 9, 3, 7, 57, 45, 905, DateTimeKind.Utc).AddTicks(2256), new DateTime(2024, 9, 3, 7, 57, 45, 905, DateTimeKind.Utc).AddTicks(2257), new DateTime(2024, 9, 3, 7, 57, 45, 905, DateTimeKind.Utc).AddTicks(2253) });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: 2045,
                columns: new[] { "ConcurrencyStamp", "CreatedTime", "LastUpdatedTime", "RefreshTokenCreateTime" },
                values: new object[] { "8ebbce83-c956-42a8-b563-f4156c9d874b", new DateTime(2024, 9, 3, 7, 57, 45, 905, DateTimeKind.Utc).AddTicks(2271), new DateTime(2024, 9, 3, 7, 57, 45, 905, DateTimeKind.Utc).AddTicks(2271), new DateTime(2024, 9, 3, 7, 57, 45, 905, DateTimeKind.Utc).AddTicks(2265) });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: 2046,
                columns: new[] { "ConcurrencyStamp", "CreatedTime", "LastUpdatedTime", "RefreshTokenCreateTime" },
                values: new object[] { "3d63e7ae-9e24-45b5-96bc-2622e8e55e84", new DateTime(2024, 9, 3, 7, 57, 45, 905, DateTimeKind.Utc).AddTicks(2311), new DateTime(2024, 9, 3, 7, 57, 45, 905, DateTimeKind.Utc).AddTicks(2311), new DateTime(2024, 9, 3, 7, 57, 45, 905, DateTimeKind.Utc).AddTicks(2308) });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: 2047,
                columns: new[] { "ConcurrencyStamp", "CreatedTime", "LastUpdatedTime", "RefreshTokenCreateTime" },
                values: new object[] { "308266d8-03d8-430f-8aad-72f664ea0d63", new DateTime(2024, 9, 3, 7, 57, 45, 905, DateTimeKind.Utc).AddTicks(2323), new DateTime(2024, 9, 3, 7, 57, 45, 905, DateTimeKind.Utc).AddTicks(2324), new DateTime(2024, 9, 3, 7, 57, 45, 905, DateTimeKind.Utc).AddTicks(2320) });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: 2048,
                columns: new[] { "ConcurrencyStamp", "CreatedTime", "LastUpdatedTime", "RefreshTokenCreateTime" },
                values: new object[] { "0b3e1f65-25fb-42c0-a122-e88baa69cd66", new DateTime(2024, 9, 3, 7, 57, 45, 905, DateTimeKind.Utc).AddTicks(2335), new DateTime(2024, 9, 3, 7, 57, 45, 905, DateTimeKind.Utc).AddTicks(2335), new DateTime(2024, 9, 3, 7, 57, 45, 905, DateTimeKind.Utc).AddTicks(2332) });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: 2049,
                columns: new[] { "ConcurrencyStamp", "CreatedTime", "LastUpdatedTime", "RefreshTokenCreateTime" },
                values: new object[] { "33446262-1f91-4990-9e54-776bda413a68", new DateTime(2024, 9, 3, 7, 57, 45, 905, DateTimeKind.Utc).AddTicks(2346), new DateTime(2024, 9, 3, 7, 57, 45, 905, DateTimeKind.Utc).AddTicks(2347), new DateTime(2024, 9, 3, 7, 57, 45, 905, DateTimeKind.Utc).AddTicks(2343) });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: 2050,
                columns: new[] { "ConcurrencyStamp", "CreatedTime", "LastUpdatedTime", "RefreshTokenCreateTime" },
                values: new object[] { "c3b5f8cf-b617-432c-bcd2-8c96ab068d1d", new DateTime(2024, 9, 3, 7, 57, 45, 905, DateTimeKind.Utc).AddTicks(2358), new DateTime(2024, 9, 3, 7, 57, 45, 905, DateTimeKind.Utc).AddTicks(2358), new DateTime(2024, 9, 3, 7, 57, 45, 905, DateTimeKind.Utc).AddTicks(2354) });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: 2051,
                columns: new[] { "ConcurrencyStamp", "CreatedTime", "LastUpdatedTime", "RefreshTokenCreateTime" },
                values: new object[] { "36bf2255-f613-4434-bdac-ea50f44b456e", new DateTime(2024, 9, 3, 7, 57, 45, 905, DateTimeKind.Utc).AddTicks(2369), new DateTime(2024, 9, 3, 7, 57, 45, 905, DateTimeKind.Utc).AddTicks(2369), new DateTime(2024, 9, 3, 7, 57, 45, 905, DateTimeKind.Utc).AddTicks(2366) });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: 2052,
                columns: new[] { "ConcurrencyStamp", "CreatedTime", "LastUpdatedTime", "RefreshTokenCreateTime" },
                values: new object[] { "0132cd67-ca56-4e2c-bef0-07e9f504e4e5", new DateTime(2024, 9, 3, 7, 57, 45, 905, DateTimeKind.Utc).AddTicks(2381), new DateTime(2024, 9, 3, 7, 57, 45, 905, DateTimeKind.Utc).AddTicks(2382), new DateTime(2024, 9, 3, 7, 57, 45, 905, DateTimeKind.Utc).AddTicks(2378) });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: 2053,
                columns: new[] { "ConcurrencyStamp", "CreatedTime", "LastUpdatedTime", "RefreshTokenCreateTime" },
                values: new object[] { "72a2a184-3690-4d06-bb1d-6b3148daba79", new DateTime(2024, 9, 3, 7, 57, 45, 905, DateTimeKind.Utc).AddTicks(2396), new DateTime(2024, 9, 3, 7, 57, 45, 905, DateTimeKind.Utc).AddTicks(2396), new DateTime(2024, 9, 3, 7, 57, 45, 905, DateTimeKind.Utc).AddTicks(2390) });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: 2054,
                columns: new[] { "ConcurrencyStamp", "CreatedTime", "LastUpdatedTime", "RefreshTokenCreateTime" },
                values: new object[] { "48b4ae59-656e-41d4-a3b3-9c04b71d5742", new DateTime(2024, 9, 3, 7, 57, 45, 905, DateTimeKind.Utc).AddTicks(2407), new DateTime(2024, 9, 3, 7, 57, 45, 905, DateTimeKind.Utc).AddTicks(2408), new DateTime(2024, 9, 3, 7, 57, 45, 905, DateTimeKind.Utc).AddTicks(2404) });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: 2055,
                columns: new[] { "ConcurrencyStamp", "CreatedTime", "LastUpdatedTime", "RefreshTokenCreateTime" },
                values: new object[] { "afb0d6f2-dc7d-4ad1-a709-95f5ee743f3f", new DateTime(2024, 9, 3, 7, 57, 45, 905, DateTimeKind.Utc).AddTicks(2420), new DateTime(2024, 9, 3, 7, 57, 45, 905, DateTimeKind.Utc).AddTicks(2420), new DateTime(2024, 9, 3, 7, 57, 45, 905, DateTimeKind.Utc).AddTicks(2416) });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: 2056,
                columns: new[] { "ConcurrencyStamp", "CreatedTime", "LastUpdatedTime", "RefreshTokenCreateTime" },
                values: new object[] { "5210a77b-000f-4bfc-9a57-c827ed428e0e", new DateTime(2024, 9, 3, 7, 57, 45, 905, DateTimeKind.Utc).AddTicks(2461), new DateTime(2024, 9, 3, 7, 57, 45, 905, DateTimeKind.Utc).AddTicks(2461), new DateTime(2024, 9, 3, 7, 57, 45, 905, DateTimeKind.Utc).AddTicks(2457) });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: 2057,
                columns: new[] { "ConcurrencyStamp", "CreatedTime", "LastUpdatedTime", "RefreshTokenCreateTime" },
                values: new object[] { "0be48306-ac87-4280-b3ad-f912fd49604a", new DateTime(2024, 9, 3, 7, 57, 45, 905, DateTimeKind.Utc).AddTicks(2473), new DateTime(2024, 9, 3, 7, 57, 45, 905, DateTimeKind.Utc).AddTicks(2473), new DateTime(2024, 9, 3, 7, 57, 45, 905, DateTimeKind.Utc).AddTicks(2470) });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: 2058,
                columns: new[] { "ConcurrencyStamp", "CreatedTime", "LastUpdatedTime", "RefreshTokenCreateTime" },
                values: new object[] { "bfeddd66-655a-4769-841f-a0e12223bac5", new DateTime(2024, 9, 3, 7, 57, 45, 905, DateTimeKind.Utc).AddTicks(2485), new DateTime(2024, 9, 3, 7, 57, 45, 905, DateTimeKind.Utc).AddTicks(2485), new DateTime(2024, 9, 3, 7, 57, 45, 905, DateTimeKind.Utc).AddTicks(2482) });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: 2059,
                columns: new[] { "ConcurrencyStamp", "CreatedTime", "LastUpdatedTime", "RefreshTokenCreateTime" },
                values: new object[] { "ac9fbd29-00c5-4435-9aee-9581ae898629", new DateTime(2024, 9, 3, 7, 57, 45, 905, DateTimeKind.Utc).AddTicks(2496), new DateTime(2024, 9, 3, 7, 57, 45, 905, DateTimeKind.Utc).AddTicks(2497), new DateTime(2024, 9, 3, 7, 57, 45, 905, DateTimeKind.Utc).AddTicks(2493) });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: 2060,
                columns: new[] { "ConcurrencyStamp", "CreatedTime", "LastUpdatedTime", "RefreshTokenCreateTime" },
                values: new object[] { "cc90ff91-7bdd-4773-bf8b-19f30c283d87", new DateTime(2024, 9, 3, 7, 57, 45, 905, DateTimeKind.Utc).AddTicks(2507), new DateTime(2024, 9, 3, 7, 57, 45, 905, DateTimeKind.Utc).AddTicks(2508), new DateTime(2024, 9, 3, 7, 57, 45, 905, DateTimeKind.Utc).AddTicks(2504) });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: 9999,
                columns: new[] { "ConcurrencyStamp", "CreatedTime", "LastUpdatedTime", "RefreshTokenCreateTime" },
                values: new object[] { "aa451165-1322-4d3c-bb7c-cc210b972c02", new DateTime(2024, 9, 3, 7, 57, 45, 905, DateTimeKind.Utc).AddTicks(1439), new DateTime(2024, 9, 3, 7, 57, 45, 905, DateTimeKind.Utc).AddTicks(1440), new DateTime(2024, 9, 3, 7, 57, 45, 905, DateTimeKind.Utc).AddTicks(1375) });

            migrationBuilder.UpdateData(
                table: "Breeds",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedTime",
                value: new DateTime(2024, 9, 3, 11, 57, 45, 896, DateTimeKind.Local).AddTicks(1666));

            migrationBuilder.UpdateData(
                table: "Breeds",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreatedTime",
                value: new DateTime(2024, 9, 3, 11, 57, 45, 896, DateTimeKind.Local).AddTicks(1674));

            migrationBuilder.UpdateData(
                table: "Breeds",
                keyColumn: "Id",
                keyValue: 3,
                column: "CreatedTime",
                value: new DateTime(2024, 9, 3, 11, 57, 45, 896, DateTimeKind.Local).AddTicks(1675));

            migrationBuilder.UpdateData(
                table: "Breeds",
                keyColumn: "Id",
                keyValue: 4,
                column: "CreatedTime",
                value: new DateTime(2024, 9, 3, 11, 57, 45, 896, DateTimeKind.Local).AddTicks(1676));

            migrationBuilder.UpdateData(
                table: "Breeds",
                keyColumn: "Id",
                keyValue: 5,
                column: "CreatedTime",
                value: new DateTime(2024, 9, 3, 11, 57, 45, 896, DateTimeKind.Local).AddTicks(1678));

            migrationBuilder.UpdateData(
                table: "Breeds",
                keyColumn: "Id",
                keyValue: 6,
                column: "CreatedTime",
                value: new DateTime(2024, 9, 3, 11, 57, 45, 896, DateTimeKind.Local).AddTicks(1679));

            migrationBuilder.UpdateData(
                table: "Breeds",
                keyColumn: "Id",
                keyValue: 7,
                column: "CreatedTime",
                value: new DateTime(2024, 9, 3, 11, 57, 45, 896, DateTimeKind.Local).AddTicks(1680));

            migrationBuilder.UpdateData(
                table: "Breeds",
                keyColumn: "Id",
                keyValue: 8,
                column: "CreatedTime",
                value: new DateTime(2024, 9, 3, 11, 57, 45, 896, DateTimeKind.Local).AddTicks(1682));

            migrationBuilder.UpdateData(
                table: "Breeds",
                keyColumn: "Id",
                keyValue: 9,
                column: "CreatedTime",
                value: new DateTime(2024, 9, 3, 11, 57, 45, 896, DateTimeKind.Local).AddTicks(1683));

            migrationBuilder.UpdateData(
                table: "Breeds",
                keyColumn: "Id",
                keyValue: 10,
                column: "CreatedTime",
                value: new DateTime(2024, 9, 3, 11, 57, 45, 896, DateTimeKind.Local).AddTicks(1684));

            migrationBuilder.UpdateData(
                table: "Breeds",
                keyColumn: "Id",
                keyValue: 11,
                column: "CreatedTime",
                value: new DateTime(2024, 9, 3, 11, 57, 45, 896, DateTimeKind.Local).AddTicks(1742));

            migrationBuilder.UpdateData(
                table: "Breeds",
                keyColumn: "Id",
                keyValue: 12,
                column: "CreatedTime",
                value: new DateTime(2024, 9, 3, 11, 57, 45, 896, DateTimeKind.Local).AddTicks(1744));

            migrationBuilder.UpdateData(
                table: "Breeds",
                keyColumn: "Id",
                keyValue: 13,
                column: "CreatedTime",
                value: new DateTime(2024, 9, 3, 11, 57, 45, 896, DateTimeKind.Local).AddTicks(1745));

            migrationBuilder.UpdateData(
                table: "Breeds",
                keyColumn: "Id",
                keyValue: 14,
                column: "CreatedTime",
                value: new DateTime(2024, 9, 3, 11, 57, 45, 896, DateTimeKind.Local).AddTicks(1746));

            migrationBuilder.UpdateData(
                table: "Breeds",
                keyColumn: "Id",
                keyValue: 15,
                column: "CreatedTime",
                value: new DateTime(2024, 9, 3, 11, 57, 45, 896, DateTimeKind.Local).AddTicks(1748));

            migrationBuilder.UpdateData(
                table: "Breeds",
                keyColumn: "Id",
                keyValue: 16,
                column: "CreatedTime",
                value: new DateTime(2024, 9, 3, 11, 57, 45, 896, DateTimeKind.Local).AddTicks(1749));

            migrationBuilder.UpdateData(
                table: "Breeds",
                keyColumn: "Id",
                keyValue: 17,
                column: "CreatedTime",
                value: new DateTime(2024, 9, 3, 11, 57, 45, 896, DateTimeKind.Local).AddTicks(1750));

            migrationBuilder.UpdateData(
                table: "Breeds",
                keyColumn: "Id",
                keyValue: 18,
                column: "CreatedTime",
                value: new DateTime(2024, 9, 3, 11, 57, 45, 896, DateTimeKind.Local).AddTicks(1752));

            migrationBuilder.UpdateData(
                table: "Breeds",
                keyColumn: "Id",
                keyValue: 19,
                column: "CreatedTime",
                value: new DateTime(2024, 9, 3, 11, 57, 45, 896, DateTimeKind.Local).AddTicks(1753));

            migrationBuilder.UpdateData(
                table: "Breeds",
                keyColumn: "Id",
                keyValue: 20,
                column: "CreatedTime",
                value: new DateTime(2024, 9, 3, 11, 57, 45, 896, DateTimeKind.Local).AddTicks(1754));

            migrationBuilder.UpdateData(
                table: "Breeds",
                keyColumn: "Id",
                keyValue: 21,
                column: "CreatedTime",
                value: new DateTime(2024, 9, 3, 11, 57, 45, 896, DateTimeKind.Local).AddTicks(1756));

            migrationBuilder.UpdateData(
                table: "Breeds",
                keyColumn: "Id",
                keyValue: 22,
                column: "CreatedTime",
                value: new DateTime(2024, 9, 3, 11, 57, 45, 896, DateTimeKind.Local).AddTicks(1757));

            migrationBuilder.UpdateData(
                table: "Breeds",
                keyColumn: "Id",
                keyValue: 23,
                column: "CreatedTime",
                value: new DateTime(2024, 9, 3, 11, 57, 45, 896, DateTimeKind.Local).AddTicks(1759));

            migrationBuilder.UpdateData(
                table: "Breeds",
                keyColumn: "Id",
                keyValue: 24,
                column: "CreatedTime",
                value: new DateTime(2024, 9, 3, 11, 57, 45, 896, DateTimeKind.Local).AddTicks(1760));

            migrationBuilder.UpdateData(
                table: "Breeds",
                keyColumn: "Id",
                keyValue: 25,
                column: "CreatedTime",
                value: new DateTime(2024, 9, 3, 11, 57, 45, 896, DateTimeKind.Local).AddTicks(1761));

            migrationBuilder.UpdateData(
                table: "Breeds",
                keyColumn: "Id",
                keyValue: 26,
                column: "CreatedTime",
                value: new DateTime(2024, 9, 3, 11, 57, 45, 896, DateTimeKind.Local).AddTicks(1763));

            migrationBuilder.UpdateData(
                table: "Breeds",
                keyColumn: "Id",
                keyValue: 27,
                column: "CreatedTime",
                value: new DateTime(2024, 9, 3, 11, 57, 45, 896, DateTimeKind.Local).AddTicks(1764));

            migrationBuilder.UpdateData(
                table: "Breeds",
                keyColumn: "Id",
                keyValue: 28,
                column: "CreatedTime",
                value: new DateTime(2024, 9, 3, 11, 57, 45, 896, DateTimeKind.Local).AddTicks(1765));

            migrationBuilder.UpdateData(
                table: "Breeds",
                keyColumn: "Id",
                keyValue: 29,
                column: "CreatedTime",
                value: new DateTime(2024, 9, 3, 11, 57, 45, 896, DateTimeKind.Local).AddTicks(1767));

            migrationBuilder.UpdateData(
                table: "Breeds",
                keyColumn: "Id",
                keyValue: 30,
                column: "CreatedTime",
                value: new DateTime(2024, 9, 3, 11, 57, 45, 896, DateTimeKind.Local).AddTicks(1769));

            migrationBuilder.UpdateData(
                table: "Breeds",
                keyColumn: "Id",
                keyValue: 31,
                column: "CreatedTime",
                value: new DateTime(2024, 9, 3, 11, 57, 45, 896, DateTimeKind.Local).AddTicks(1771));

            migrationBuilder.UpdateData(
                table: "Breeds",
                keyColumn: "Id",
                keyValue: 32,
                column: "CreatedTime",
                value: new DateTime(2024, 9, 3, 11, 57, 45, 896, DateTimeKind.Local).AddTicks(1772));

            migrationBuilder.UpdateData(
                table: "Breeds",
                keyColumn: "Id",
                keyValue: 33,
                column: "CreatedTime",
                value: new DateTime(2024, 9, 3, 11, 57, 45, 896, DateTimeKind.Local).AddTicks(1773));

            migrationBuilder.UpdateData(
                table: "Breeds",
                keyColumn: "Id",
                keyValue: 34,
                column: "CreatedTime",
                value: new DateTime(2024, 9, 3, 11, 57, 45, 896, DateTimeKind.Local).AddTicks(1775));

            migrationBuilder.UpdateData(
                table: "Breeds",
                keyColumn: "Id",
                keyValue: 35,
                column: "CreatedTime",
                value: new DateTime(2024, 9, 3, 11, 57, 45, 896, DateTimeKind.Local).AddTicks(1777));

            migrationBuilder.UpdateData(
                table: "Breeds",
                keyColumn: "Id",
                keyValue: 36,
                column: "CreatedTime",
                value: new DateTime(2024, 9, 3, 11, 57, 45, 896, DateTimeKind.Local).AddTicks(1778));

            migrationBuilder.UpdateData(
                table: "Breeds",
                keyColumn: "Id",
                keyValue: 37,
                column: "CreatedTime",
                value: new DateTime(2024, 9, 3, 11, 57, 45, 896, DateTimeKind.Local).AddTicks(1780));

            migrationBuilder.UpdateData(
                table: "Breeds",
                keyColumn: "Id",
                keyValue: 38,
                column: "CreatedTime",
                value: new DateTime(2024, 9, 3, 11, 57, 45, 896, DateTimeKind.Local).AddTicks(1781));

            migrationBuilder.UpdateData(
                table: "Breeds",
                keyColumn: "Id",
                keyValue: 39,
                column: "CreatedTime",
                value: new DateTime(2024, 9, 3, 11, 57, 45, 896, DateTimeKind.Local).AddTicks(1783));

            migrationBuilder.UpdateData(
                table: "Breeds",
                keyColumn: "Id",
                keyValue: 40,
                column: "CreatedTime",
                value: new DateTime(2024, 9, 3, 11, 57, 45, 896, DateTimeKind.Local).AddTicks(1784));

            migrationBuilder.UpdateData(
                table: "Breeds",
                keyColumn: "Id",
                keyValue: 41,
                column: "CreatedTime",
                value: new DateTime(2024, 9, 3, 11, 57, 45, 896, DateTimeKind.Local).AddTicks(1786));

            migrationBuilder.UpdateData(
                table: "Breeds",
                keyColumn: "Id",
                keyValue: 42,
                column: "CreatedTime",
                value: new DateTime(2024, 9, 3, 11, 57, 45, 896, DateTimeKind.Local).AddTicks(1787));

            migrationBuilder.UpdateData(
                table: "Breeds",
                keyColumn: "Id",
                keyValue: 43,
                column: "CreatedTime",
                value: new DateTime(2024, 9, 3, 11, 57, 45, 896, DateTimeKind.Local).AddTicks(1788));

            migrationBuilder.UpdateData(
                table: "Breeds",
                keyColumn: "Id",
                keyValue: 44,
                column: "CreatedTime",
                value: new DateTime(2024, 9, 3, 11, 57, 45, 896, DateTimeKind.Local).AddTicks(1791));

            migrationBuilder.UpdateData(
                table: "Breeds",
                keyColumn: "Id",
                keyValue: 45,
                column: "CreatedTime",
                value: new DateTime(2024, 9, 3, 11, 57, 45, 896, DateTimeKind.Local).AddTicks(1792));

            migrationBuilder.UpdateData(
                table: "Breeds",
                keyColumn: "Id",
                keyValue: 46,
                column: "CreatedTime",
                value: new DateTime(2024, 9, 3, 11, 57, 45, 896, DateTimeKind.Local).AddTicks(1794));

            migrationBuilder.UpdateData(
                table: "Breeds",
                keyColumn: "Id",
                keyValue: 47,
                column: "CreatedTime",
                value: new DateTime(2024, 9, 3, 11, 57, 45, 896, DateTimeKind.Local).AddTicks(1795));

            migrationBuilder.UpdateData(
                table: "Breeds",
                keyColumn: "Id",
                keyValue: 48,
                column: "CreatedTime",
                value: new DateTime(2024, 9, 3, 11, 57, 45, 896, DateTimeKind.Local).AddTicks(1796));

            migrationBuilder.UpdateData(
                table: "Breeds",
                keyColumn: "Id",
                keyValue: 49,
                column: "CreatedTime",
                value: new DateTime(2024, 9, 3, 11, 57, 45, 896, DateTimeKind.Local).AddTicks(1798));

            migrationBuilder.UpdateData(
                table: "Breeds",
                keyColumn: "Id",
                keyValue: 50,
                column: "CreatedTime",
                value: new DateTime(2024, 9, 3, 11, 57, 45, 896, DateTimeKind.Local).AddTicks(1799));

            migrationBuilder.UpdateData(
                table: "Breeds",
                keyColumn: "Id",
                keyValue: 51,
                column: "CreatedTime",
                value: new DateTime(2024, 9, 3, 11, 57, 45, 896, DateTimeKind.Local).AddTicks(1800));

            migrationBuilder.UpdateData(
                table: "Breeds",
                keyColumn: "Id",
                keyValue: 52,
                column: "CreatedTime",
                value: new DateTime(2024, 9, 3, 11, 57, 45, 896, DateTimeKind.Local).AddTicks(1801));

            migrationBuilder.UpdateData(
                table: "Breeds",
                keyColumn: "Id",
                keyValue: 53,
                column: "CreatedTime",
                value: new DateTime(2024, 9, 3, 11, 57, 45, 896, DateTimeKind.Local).AddTicks(1803));

            migrationBuilder.UpdateData(
                table: "Breeds",
                keyColumn: "Id",
                keyValue: 54,
                column: "CreatedTime",
                value: new DateTime(2024, 9, 3, 11, 57, 45, 896, DateTimeKind.Local).AddTicks(1804));

            migrationBuilder.UpdateData(
                table: "Breeds",
                keyColumn: "Id",
                keyValue: 55,
                column: "CreatedTime",
                value: new DateTime(2024, 9, 3, 11, 57, 45, 896, DateTimeKind.Local).AddTicks(1806));

            migrationBuilder.UpdateData(
                table: "Breeds",
                keyColumn: "Id",
                keyValue: 56,
                column: "CreatedTime",
                value: new DateTime(2024, 9, 3, 11, 57, 45, 896, DateTimeKind.Local).AddTicks(1807));

            migrationBuilder.UpdateData(
                table: "Breeds",
                keyColumn: "Id",
                keyValue: 57,
                column: "CreatedTime",
                value: new DateTime(2024, 9, 3, 11, 57, 45, 896, DateTimeKind.Local).AddTicks(1808));

            migrationBuilder.UpdateData(
                table: "Breeds",
                keyColumn: "Id",
                keyValue: 58,
                column: "CreatedTime",
                value: new DateTime(2024, 9, 3, 11, 57, 45, 896, DateTimeKind.Local).AddTicks(1809));

            migrationBuilder.UpdateData(
                table: "Breeds",
                keyColumn: "Id",
                keyValue: 59,
                column: "CreatedTime",
                value: new DateTime(2024, 9, 3, 11, 57, 45, 896, DateTimeKind.Local).AddTicks(1811));

            migrationBuilder.UpdateData(
                table: "Breeds",
                keyColumn: "Id",
                keyValue: 60,
                column: "CreatedTime",
                value: new DateTime(2024, 9, 3, 11, 57, 45, 896, DateTimeKind.Local).AddTicks(1812));

            migrationBuilder.UpdateData(
                table: "Breeds",
                keyColumn: "Id",
                keyValue: 61,
                column: "CreatedTime",
                value: new DateTime(2024, 9, 3, 11, 57, 45, 896, DateTimeKind.Local).AddTicks(1814));

            migrationBuilder.UpdateData(
                table: "Breeds",
                keyColumn: "Id",
                keyValue: 62,
                column: "CreatedTime",
                value: new DateTime(2024, 9, 3, 11, 57, 45, 896, DateTimeKind.Local).AddTicks(1815));

            migrationBuilder.UpdateData(
                table: "Breeds",
                keyColumn: "Id",
                keyValue: 63,
                column: "CreatedTime",
                value: new DateTime(2024, 9, 3, 11, 57, 45, 896, DateTimeKind.Local).AddTicks(1817));

            migrationBuilder.UpdateData(
                table: "Breeds",
                keyColumn: "Id",
                keyValue: 64,
                column: "CreatedTime",
                value: new DateTime(2024, 9, 3, 11, 57, 45, 896, DateTimeKind.Local).AddTicks(1818));

            migrationBuilder.UpdateData(
                table: "Breeds",
                keyColumn: "Id",
                keyValue: 65,
                column: "CreatedTime",
                value: new DateTime(2024, 9, 3, 11, 57, 45, 896, DateTimeKind.Local).AddTicks(1819));

            migrationBuilder.UpdateData(
                table: "Breeds",
                keyColumn: "Id",
                keyValue: 66,
                column: "CreatedTime",
                value: new DateTime(2024, 9, 3, 11, 57, 45, 896, DateTimeKind.Local).AddTicks(1821));

            migrationBuilder.UpdateData(
                table: "Breeds",
                keyColumn: "Id",
                keyValue: 67,
                column: "CreatedTime",
                value: new DateTime(2024, 9, 3, 11, 57, 45, 896, DateTimeKind.Local).AddTicks(1822));

            migrationBuilder.UpdateData(
                table: "Breeds",
                keyColumn: "Id",
                keyValue: 68,
                column: "CreatedTime",
                value: new DateTime(2024, 9, 3, 11, 57, 45, 896, DateTimeKind.Local).AddTicks(1823));

            migrationBuilder.UpdateData(
                table: "Breeds",
                keyColumn: "Id",
                keyValue: 69,
                column: "CreatedTime",
                value: new DateTime(2024, 9, 3, 11, 57, 45, 896, DateTimeKind.Local).AddTicks(1824));

            migrationBuilder.UpdateData(
                table: "Breeds",
                keyColumn: "Id",
                keyValue: 70,
                column: "CreatedTime",
                value: new DateTime(2024, 9, 3, 11, 57, 45, 896, DateTimeKind.Local).AddTicks(1826));

            migrationBuilder.UpdateData(
                table: "Breeds",
                keyColumn: "Id",
                keyValue: 71,
                column: "CreatedTime",
                value: new DateTime(2024, 9, 3, 11, 57, 45, 896, DateTimeKind.Local).AddTicks(1827));

            migrationBuilder.UpdateData(
                table: "Breeds",
                keyColumn: "Id",
                keyValue: 72,
                column: "CreatedTime",
                value: new DateTime(2024, 9, 3, 11, 57, 45, 896, DateTimeKind.Local).AddTicks(1828));

            migrationBuilder.UpdateData(
                table: "Breeds",
                keyColumn: "Id",
                keyValue: 73,
                column: "CreatedTime",
                value: new DateTime(2024, 9, 3, 11, 57, 45, 896, DateTimeKind.Local).AddTicks(1830));

            migrationBuilder.UpdateData(
                table: "Breeds",
                keyColumn: "Id",
                keyValue: 74,
                column: "CreatedTime",
                value: new DateTime(2024, 9, 3, 11, 57, 45, 896, DateTimeKind.Local).AddTicks(1832));

            migrationBuilder.UpdateData(
                table: "Breeds",
                keyColumn: "Id",
                keyValue: 75,
                column: "CreatedTime",
                value: new DateTime(2024, 9, 3, 11, 57, 45, 896, DateTimeKind.Local).AddTicks(1833));

            migrationBuilder.UpdateData(
                table: "Breeds",
                keyColumn: "Id",
                keyValue: 76,
                column: "CreatedTime",
                value: new DateTime(2024, 9, 3, 11, 57, 45, 896, DateTimeKind.Local).AddTicks(1834));

            migrationBuilder.UpdateData(
                table: "Breeds",
                keyColumn: "Id",
                keyValue: 77,
                column: "CreatedTime",
                value: new DateTime(2024, 9, 3, 11, 57, 45, 896, DateTimeKind.Local).AddTicks(1836));

            migrationBuilder.UpdateData(
                table: "Breeds",
                keyColumn: "Id",
                keyValue: 78,
                column: "CreatedTime",
                value: new DateTime(2024, 9, 3, 11, 57, 45, 896, DateTimeKind.Local).AddTicks(1837));

            migrationBuilder.UpdateData(
                table: "Breeds",
                keyColumn: "Id",
                keyValue: 79,
                column: "CreatedTime",
                value: new DateTime(2024, 9, 3, 11, 57, 45, 896, DateTimeKind.Local).AddTicks(1838));

            migrationBuilder.UpdateData(
                table: "Breeds",
                keyColumn: "Id",
                keyValue: 80,
                column: "CreatedTime",
                value: new DateTime(2024, 9, 3, 11, 57, 45, 896, DateTimeKind.Local).AddTicks(1839));

            migrationBuilder.UpdateData(
                table: "Breeds",
                keyColumn: "Id",
                keyValue: 81,
                column: "CreatedTime",
                value: new DateTime(2024, 9, 3, 11, 57, 45, 896, DateTimeKind.Local).AddTicks(1841));

            migrationBuilder.UpdateData(
                table: "Breeds",
                keyColumn: "Id",
                keyValue: 82,
                column: "CreatedTime",
                value: new DateTime(2024, 9, 3, 11, 57, 45, 896, DateTimeKind.Local).AddTicks(1842));

            migrationBuilder.UpdateData(
                table: "Breeds",
                keyColumn: "Id",
                keyValue: 83,
                column: "CreatedTime",
                value: new DateTime(2024, 9, 3, 11, 57, 45, 896, DateTimeKind.Local).AddTicks(1843));

            migrationBuilder.UpdateData(
                table: "Breeds",
                keyColumn: "Id",
                keyValue: 84,
                column: "CreatedTime",
                value: new DateTime(2024, 9, 3, 11, 57, 45, 896, DateTimeKind.Local).AddTicks(1844));

            migrationBuilder.UpdateData(
                table: "Breeds",
                keyColumn: "Id",
                keyValue: 85,
                column: "CreatedTime",
                value: new DateTime(2024, 9, 3, 11, 57, 45, 896, DateTimeKind.Local).AddTicks(1846));

            migrationBuilder.UpdateData(
                table: "Breeds",
                keyColumn: "Id",
                keyValue: 86,
                column: "CreatedTime",
                value: new DateTime(2024, 9, 3, 11, 57, 45, 896, DateTimeKind.Local).AddTicks(1847));

            migrationBuilder.UpdateData(
                table: "Breeds",
                keyColumn: "Id",
                keyValue: 87,
                column: "CreatedTime",
                value: new DateTime(2024, 9, 3, 11, 57, 45, 896, DateTimeKind.Local).AddTicks(1848));

            migrationBuilder.UpdateData(
                table: "Breeds",
                keyColumn: "Id",
                keyValue: 88,
                column: "CreatedTime",
                value: new DateTime(2024, 9, 3, 11, 57, 45, 896, DateTimeKind.Local).AddTicks(1849));

            migrationBuilder.UpdateData(
                table: "Breeds",
                keyColumn: "Id",
                keyValue: 89,
                column: "CreatedTime",
                value: new DateTime(2024, 9, 3, 11, 57, 45, 896, DateTimeKind.Local).AddTicks(1851));

            migrationBuilder.UpdateData(
                table: "Breeds",
                keyColumn: "Id",
                keyValue: 90,
                column: "CreatedTime",
                value: new DateTime(2024, 9, 3, 11, 57, 45, 896, DateTimeKind.Local).AddTicks(1852));

            migrationBuilder.UpdateData(
                table: "Breeds",
                keyColumn: "Id",
                keyValue: 91,
                column: "CreatedTime",
                value: new DateTime(2024, 9, 3, 11, 57, 45, 896, DateTimeKind.Local).AddTicks(1853));

            migrationBuilder.UpdateData(
                table: "Breeds",
                keyColumn: "Id",
                keyValue: 92,
                column: "CreatedTime",
                value: new DateTime(2024, 9, 3, 11, 57, 45, 896, DateTimeKind.Local).AddTicks(1855));

            migrationBuilder.UpdateData(
                table: "Breeds",
                keyColumn: "Id",
                keyValue: 93,
                column: "CreatedTime",
                value: new DateTime(2024, 9, 3, 11, 57, 45, 896, DateTimeKind.Local).AddTicks(1856));

            migrationBuilder.UpdateData(
                table: "Breeds",
                keyColumn: "Id",
                keyValue: 94,
                column: "CreatedTime",
                value: new DateTime(2024, 9, 3, 11, 57, 45, 896, DateTimeKind.Local).AddTicks(1857));

            migrationBuilder.UpdateData(
                table: "Breeds",
                keyColumn: "Id",
                keyValue: 95,
                column: "CreatedTime",
                value: new DateTime(2024, 9, 3, 11, 57, 45, 896, DateTimeKind.Local).AddTicks(1859));

            migrationBuilder.UpdateData(
                table: "Breeds",
                keyColumn: "Id",
                keyValue: 96,
                column: "CreatedTime",
                value: new DateTime(2024, 9, 3, 11, 57, 45, 896, DateTimeKind.Local).AddTicks(1860));

            migrationBuilder.UpdateData(
                table: "Breeds",
                keyColumn: "Id",
                keyValue: 97,
                column: "CreatedTime",
                value: new DateTime(2024, 9, 3, 11, 57, 45, 896, DateTimeKind.Local).AddTicks(1862));

            migrationBuilder.UpdateData(
                table: "Breeds",
                keyColumn: "Id",
                keyValue: 98,
                column: "CreatedTime",
                value: new DateTime(2024, 9, 3, 11, 57, 45, 896, DateTimeKind.Local).AddTicks(1863));

            migrationBuilder.UpdateData(
                table: "Breeds",
                keyColumn: "Id",
                keyValue: 99,
                column: "CreatedTime",
                value: new DateTime(2024, 9, 3, 11, 57, 45, 896, DateTimeKind.Local).AddTicks(1864));

            migrationBuilder.UpdateData(
                table: "Breeds",
                keyColumn: "Id",
                keyValue: 100,
                column: "CreatedTime",
                value: new DateTime(2024, 9, 3, 11, 57, 45, 896, DateTimeKind.Local).AddTicks(1865));

            migrationBuilder.UpdateData(
                table: "Breeds",
                keyColumn: "Id",
                keyValue: 101,
                column: "CreatedTime",
                value: new DateTime(2024, 9, 3, 11, 57, 45, 896, DateTimeKind.Local).AddTicks(1867));

            migrationBuilder.UpdateData(
                table: "Breeds",
                keyColumn: "Id",
                keyValue: 102,
                column: "CreatedTime",
                value: new DateTime(2024, 9, 3, 11, 57, 45, 896, DateTimeKind.Local).AddTicks(1869));

            migrationBuilder.UpdateData(
                table: "Breeds",
                keyColumn: "Id",
                keyValue: 103,
                column: "CreatedTime",
                value: new DateTime(2024, 9, 3, 11, 57, 45, 896, DateTimeKind.Local).AddTicks(1870));

            migrationBuilder.UpdateData(
                table: "Breeds",
                keyColumn: "Id",
                keyValue: 104,
                column: "CreatedTime",
                value: new DateTime(2024, 9, 3, 11, 57, 45, 896, DateTimeKind.Local).AddTicks(1872));

            migrationBuilder.UpdateData(
                table: "Breeds",
                keyColumn: "Id",
                keyValue: 105,
                column: "CreatedTime",
                value: new DateTime(2024, 9, 3, 11, 57, 45, 896, DateTimeKind.Local).AddTicks(1873));

            migrationBuilder.UpdateData(
                table: "Breeds",
                keyColumn: "Id",
                keyValue: 106,
                column: "CreatedTime",
                value: new DateTime(2024, 9, 3, 11, 57, 45, 896, DateTimeKind.Local).AddTicks(1874));

            migrationBuilder.UpdateData(
                table: "Breeds",
                keyColumn: "Id",
                keyValue: 107,
                column: "CreatedTime",
                value: new DateTime(2024, 9, 3, 11, 57, 45, 896, DateTimeKind.Local).AddTicks(1876));

            migrationBuilder.UpdateData(
                table: "Breeds",
                keyColumn: "Id",
                keyValue: 108,
                column: "CreatedTime",
                value: new DateTime(2024, 9, 3, 11, 57, 45, 896, DateTimeKind.Local).AddTicks(1877));

            migrationBuilder.UpdateData(
                table: "Breeds",
                keyColumn: "Id",
                keyValue: 109,
                column: "CreatedTime",
                value: new DateTime(2024, 9, 3, 11, 57, 45, 896, DateTimeKind.Local).AddTicks(1879));

            migrationBuilder.UpdateData(
                table: "Breeds",
                keyColumn: "Id",
                keyValue: 110,
                column: "CreatedTime",
                value: new DateTime(2024, 9, 3, 11, 57, 45, 896, DateTimeKind.Local).AddTicks(1881));

            migrationBuilder.UpdateData(
                table: "Breeds",
                keyColumn: "Id",
                keyValue: 111,
                column: "CreatedTime",
                value: new DateTime(2024, 9, 3, 11, 57, 45, 896, DateTimeKind.Local).AddTicks(1882));

            migrationBuilder.UpdateData(
                table: "Breeds",
                keyColumn: "Id",
                keyValue: 112,
                column: "CreatedTime",
                value: new DateTime(2024, 9, 3, 11, 57, 45, 896, DateTimeKind.Local).AddTicks(1884));

            migrationBuilder.UpdateData(
                table: "Breeds",
                keyColumn: "Id",
                keyValue: 113,
                column: "CreatedTime",
                value: new DateTime(2024, 9, 3, 11, 57, 45, 896, DateTimeKind.Local).AddTicks(1886));

            migrationBuilder.UpdateData(
                table: "Breeds",
                keyColumn: "Id",
                keyValue: 114,
                column: "CreatedTime",
                value: new DateTime(2024, 9, 3, 11, 57, 45, 896, DateTimeKind.Local).AddTicks(1887));

            migrationBuilder.UpdateData(
                table: "Breeds",
                keyColumn: "Id",
                keyValue: 115,
                column: "CreatedTime",
                value: new DateTime(2024, 9, 3, 11, 57, 45, 896, DateTimeKind.Local).AddTicks(1889));

            migrationBuilder.UpdateData(
                table: "Breeds",
                keyColumn: "Id",
                keyValue: 116,
                column: "CreatedTime",
                value: new DateTime(2024, 9, 3, 11, 57, 45, 896, DateTimeKind.Local).AddTicks(1890));

            migrationBuilder.UpdateData(
                table: "Breeds",
                keyColumn: "Id",
                keyValue: 117,
                column: "CreatedTime",
                value: new DateTime(2024, 9, 3, 11, 57, 45, 896, DateTimeKind.Local).AddTicks(1892));

            migrationBuilder.UpdateData(
                table: "Breeds",
                keyColumn: "Id",
                keyValue: 118,
                column: "CreatedTime",
                value: new DateTime(2024, 9, 3, 11, 57, 45, 896, DateTimeKind.Local).AddTicks(1893));

            migrationBuilder.UpdateData(
                table: "Breeds",
                keyColumn: "Id",
                keyValue: 119,
                column: "CreatedTime",
                value: new DateTime(2024, 9, 3, 11, 57, 45, 896, DateTimeKind.Local).AddTicks(1894));

            migrationBuilder.UpdateData(
                table: "Breeds",
                keyColumn: "Id",
                keyValue: 120,
                column: "CreatedTime",
                value: new DateTime(2024, 9, 3, 11, 57, 45, 896, DateTimeKind.Local).AddTicks(1897));

            migrationBuilder.UpdateData(
                table: "Breeds",
                keyColumn: "Id",
                keyValue: 121,
                column: "CreatedTime",
                value: new DateTime(2024, 9, 3, 11, 57, 45, 896, DateTimeKind.Local).AddTicks(1898));

            migrationBuilder.UpdateData(
                table: "Breeds",
                keyColumn: "Id",
                keyValue: 122,
                column: "CreatedTime",
                value: new DateTime(2024, 9, 3, 11, 57, 45, 896, DateTimeKind.Local).AddTicks(1900));

            migrationBuilder.UpdateData(
                table: "Breeds",
                keyColumn: "Id",
                keyValue: 123,
                column: "CreatedTime",
                value: new DateTime(2024, 9, 3, 11, 57, 45, 896, DateTimeKind.Local).AddTicks(1901));

            migrationBuilder.UpdateData(
                table: "Breeds",
                keyColumn: "Id",
                keyValue: 124,
                column: "CreatedTime",
                value: new DateTime(2024, 9, 3, 11, 57, 45, 896, DateTimeKind.Local).AddTicks(1902));

            migrationBuilder.UpdateData(
                table: "Breeds",
                keyColumn: "Id",
                keyValue: 125,
                column: "CreatedTime",
                value: new DateTime(2024, 9, 3, 11, 57, 45, 896, DateTimeKind.Local).AddTicks(1904));

            migrationBuilder.UpdateData(
                table: "Breeds",
                keyColumn: "Id",
                keyValue: 126,
                column: "CreatedTime",
                value: new DateTime(2024, 9, 3, 11, 57, 45, 896, DateTimeKind.Local).AddTicks(1905));

            migrationBuilder.UpdateData(
                table: "Breeds",
                keyColumn: "Id",
                keyValue: 127,
                column: "CreatedTime",
                value: new DateTime(2024, 9, 3, 11, 57, 45, 896, DateTimeKind.Local).AddTicks(1906));

            migrationBuilder.UpdateData(
                table: "Breeds",
                keyColumn: "Id",
                keyValue: 128,
                column: "CreatedTime",
                value: new DateTime(2024, 9, 3, 11, 57, 45, 896, DateTimeKind.Local).AddTicks(1908));

            migrationBuilder.UpdateData(
                table: "Breeds",
                keyColumn: "Id",
                keyValue: 129,
                column: "CreatedTime",
                value: new DateTime(2024, 9, 3, 11, 57, 45, 896, DateTimeKind.Local).AddTicks(1909));

            migrationBuilder.UpdateData(
                table: "Breeds",
                keyColumn: "Id",
                keyValue: 130,
                column: "CreatedTime",
                value: new DateTime(2024, 9, 3, 11, 57, 45, 896, DateTimeKind.Local).AddTicks(1911));

            migrationBuilder.UpdateData(
                table: "Breeds",
                keyColumn: "Id",
                keyValue: 131,
                column: "CreatedTime",
                value: new DateTime(2024, 9, 3, 11, 57, 45, 896, DateTimeKind.Local).AddTicks(1913));

            migrationBuilder.UpdateData(
                table: "Breeds",
                keyColumn: "Id",
                keyValue: 132,
                column: "CreatedTime",
                value: new DateTime(2024, 9, 3, 11, 57, 45, 896, DateTimeKind.Local).AddTicks(1914));

            migrationBuilder.UpdateData(
                table: "Breeds",
                keyColumn: "Id",
                keyValue: 133,
                column: "CreatedTime",
                value: new DateTime(2024, 9, 3, 11, 57, 45, 896, DateTimeKind.Local).AddTicks(1915));

            migrationBuilder.UpdateData(
                table: "Breeds",
                keyColumn: "Id",
                keyValue: 134,
                column: "CreatedTime",
                value: new DateTime(2024, 9, 3, 11, 57, 45, 896, DateTimeKind.Local).AddTicks(1917));

            migrationBuilder.UpdateData(
                table: "Breeds",
                keyColumn: "Id",
                keyValue: 135,
                column: "CreatedTime",
                value: new DateTime(2024, 9, 3, 11, 57, 45, 896, DateTimeKind.Local).AddTicks(1918));

            migrationBuilder.UpdateData(
                table: "Breeds",
                keyColumn: "Id",
                keyValue: 136,
                column: "CreatedTime",
                value: new DateTime(2024, 9, 3, 11, 57, 45, 896, DateTimeKind.Local).AddTicks(1919));

            migrationBuilder.UpdateData(
                table: "Breeds",
                keyColumn: "Id",
                keyValue: 137,
                column: "CreatedTime",
                value: new DateTime(2024, 9, 3, 11, 57, 45, 896, DateTimeKind.Local).AddTicks(1921));

            migrationBuilder.UpdateData(
                table: "Breeds",
                keyColumn: "Id",
                keyValue: 138,
                column: "CreatedTime",
                value: new DateTime(2024, 9, 3, 11, 57, 45, 896, DateTimeKind.Local).AddTicks(1922));

            migrationBuilder.UpdateData(
                table: "Breeds",
                keyColumn: "Id",
                keyValue: 139,
                column: "CreatedTime",
                value: new DateTime(2024, 9, 3, 11, 57, 45, 896, DateTimeKind.Local).AddTicks(1923));

            migrationBuilder.UpdateData(
                table: "Breeds",
                keyColumn: "Id",
                keyValue: 140,
                column: "CreatedTime",
                value: new DateTime(2024, 9, 3, 11, 57, 45, 896, DateTimeKind.Local).AddTicks(1962));

            migrationBuilder.UpdateData(
                table: "Breeds",
                keyColumn: "Id",
                keyValue: 141,
                column: "CreatedTime",
                value: new DateTime(2024, 9, 3, 11, 57, 45, 896, DateTimeKind.Local).AddTicks(1964));

            migrationBuilder.UpdateData(
                table: "Breeds",
                keyColumn: "Id",
                keyValue: 142,
                column: "CreatedTime",
                value: new DateTime(2024, 9, 3, 11, 57, 45, 896, DateTimeKind.Local).AddTicks(1965));

            migrationBuilder.UpdateData(
                table: "Breeds",
                keyColumn: "Id",
                keyValue: 143,
                column: "CreatedTime",
                value: new DateTime(2024, 9, 3, 11, 57, 45, 896, DateTimeKind.Local).AddTicks(1967));

            migrationBuilder.UpdateData(
                table: "Breeds",
                keyColumn: "Id",
                keyValue: 144,
                column: "CreatedTime",
                value: new DateTime(2024, 9, 3, 11, 57, 45, 896, DateTimeKind.Local).AddTicks(1968));

            migrationBuilder.UpdateData(
                table: "Breeds",
                keyColumn: "Id",
                keyValue: 145,
                column: "CreatedTime",
                value: new DateTime(2024, 9, 3, 11, 57, 45, 896, DateTimeKind.Local).AddTicks(1969));

            migrationBuilder.UpdateData(
                table: "Breeds",
                keyColumn: "Id",
                keyValue: 146,
                column: "CreatedTime",
                value: new DateTime(2024, 9, 3, 11, 57, 45, 896, DateTimeKind.Local).AddTicks(1971));

            migrationBuilder.UpdateData(
                table: "Breeds",
                keyColumn: "Id",
                keyValue: 147,
                column: "CreatedTime",
                value: new DateTime(2024, 9, 3, 11, 57, 45, 896, DateTimeKind.Local).AddTicks(1972));

            migrationBuilder.UpdateData(
                table: "Breeds",
                keyColumn: "Id",
                keyValue: 148,
                column: "CreatedTime",
                value: new DateTime(2024, 9, 3, 11, 57, 45, 896, DateTimeKind.Local).AddTicks(1974));

            migrationBuilder.UpdateData(
                table: "Breeds",
                keyColumn: "Id",
                keyValue: 149,
                column: "CreatedTime",
                value: new DateTime(2024, 9, 3, 11, 57, 45, 896, DateTimeKind.Local).AddTicks(1975));

            migrationBuilder.UpdateData(
                table: "Breeds",
                keyColumn: "Id",
                keyValue: 150,
                column: "CreatedTime",
                value: new DateTime(2024, 9, 3, 11, 57, 45, 896, DateTimeKind.Local).AddTicks(1977));

            migrationBuilder.UpdateData(
                table: "Breeds",
                keyColumn: "Id",
                keyValue: 151,
                column: "CreatedTime",
                value: new DateTime(2024, 9, 3, 11, 57, 45, 896, DateTimeKind.Local).AddTicks(1978));

            migrationBuilder.UpdateData(
                table: "Breeds",
                keyColumn: "Id",
                keyValue: 152,
                column: "CreatedTime",
                value: new DateTime(2024, 9, 3, 11, 57, 45, 896, DateTimeKind.Local).AddTicks(1980));

            migrationBuilder.UpdateData(
                table: "Breeds",
                keyColumn: "Id",
                keyValue: 153,
                column: "CreatedTime",
                value: new DateTime(2024, 9, 3, 11, 57, 45, 896, DateTimeKind.Local).AddTicks(1982));

            migrationBuilder.UpdateData(
                table: "Breeds",
                keyColumn: "Id",
                keyValue: 154,
                column: "CreatedTime",
                value: new DateTime(2024, 9, 3, 11, 57, 45, 896, DateTimeKind.Local).AddTicks(1983));

            migrationBuilder.UpdateData(
                table: "Breeds",
                keyColumn: "Id",
                keyValue: 155,
                column: "CreatedTime",
                value: new DateTime(2024, 9, 3, 11, 57, 45, 896, DateTimeKind.Local).AddTicks(1985));

            migrationBuilder.UpdateData(
                table: "Breeds",
                keyColumn: "Id",
                keyValue: 156,
                column: "CreatedTime",
                value: new DateTime(2024, 9, 3, 11, 57, 45, 896, DateTimeKind.Local).AddTicks(1986));

            migrationBuilder.UpdateData(
                table: "Breeds",
                keyColumn: "Id",
                keyValue: 157,
                column: "CreatedTime",
                value: new DateTime(2024, 9, 3, 11, 57, 45, 896, DateTimeKind.Local).AddTicks(1987));

            migrationBuilder.UpdateData(
                table: "Breeds",
                keyColumn: "Id",
                keyValue: 158,
                column: "CreatedTime",
                value: new DateTime(2024, 9, 3, 11, 57, 45, 896, DateTimeKind.Local).AddTicks(1988));

            migrationBuilder.UpdateData(
                table: "Breeds",
                keyColumn: "Id",
                keyValue: 159,
                column: "CreatedTime",
                value: new DateTime(2024, 9, 3, 11, 57, 45, 896, DateTimeKind.Local).AddTicks(1990));

            migrationBuilder.UpdateData(
                table: "Breeds",
                keyColumn: "Id",
                keyValue: 160,
                column: "CreatedTime",
                value: new DateTime(2024, 9, 3, 11, 57, 45, 896, DateTimeKind.Local).AddTicks(1991));

            migrationBuilder.UpdateData(
                table: "PetTypes",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedTime",
                value: new DateTime(2024, 9, 3, 11, 57, 45, 895, DateTimeKind.Local).AddTicks(8351));

            migrationBuilder.UpdateData(
                table: "PetTypes",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreatedTime",
                value: new DateTime(2024, 9, 3, 11, 57, 45, 895, DateTimeKind.Local).AddTicks(8356));

            migrationBuilder.UpdateData(
                table: "PetTypes",
                keyColumn: "Id",
                keyValue: 3,
                column: "CreatedTime",
                value: new DateTime(2024, 9, 3, 11, 57, 45, 895, DateTimeKind.Local).AddTicks(8357));

            migrationBuilder.UpdateData(
                table: "PetTypes",
                keyColumn: "Id",
                keyValue: 4,
                column: "CreatedTime",
                value: new DateTime(2024, 9, 3, 11, 57, 45, 895, DateTimeKind.Local).AddTicks(8358));

            migrationBuilder.UpdateData(
                table: "PetTypes",
                keyColumn: "Id",
                keyValue: 5,
                column: "CreatedTime",
                value: new DateTime(2024, 9, 3, 11, 57, 45, 895, DateTimeKind.Local).AddTicks(8360));

            migrationBuilder.UpdateData(
                table: "PetTypes",
                keyColumn: "Id",
                keyValue: 6,
                column: "CreatedTime",
                value: new DateTime(2024, 9, 3, 11, 57, 45, 895, DateTimeKind.Local).AddTicks(8361));

            migrationBuilder.UpdateData(
                table: "PetTypes",
                keyColumn: "Id",
                keyValue: 7,
                column: "CreatedTime",
                value: new DateTime(2024, 9, 3, 11, 57, 45, 895, DateTimeKind.Local).AddTicks(8363));

            migrationBuilder.UpdateData(
                table: "PetTypes",
                keyColumn: "Id",
                keyValue: 8,
                column: "CreatedTime",
                value: new DateTime(2024, 9, 3, 11, 57, 45, 895, DateTimeKind.Local).AddTicks(8364));

            migrationBuilder.UpdateData(
                table: "Pets",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedTime",
                value: new DateTime(2023, 11, 3, 11, 57, 45, 906, DateTimeKind.Local).AddTicks(1411));

            migrationBuilder.UpdateData(
                table: "Pets",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreatedTime",
                value: new DateTime(2024, 2, 3, 11, 57, 45, 906, DateTimeKind.Local).AddTicks(1428));

            migrationBuilder.UpdateData(
                table: "Pets",
                keyColumn: "Id",
                keyValue: 3,
                column: "CreatedTime",
                value: new DateTime(2024, 3, 3, 11, 57, 45, 906, DateTimeKind.Local).AddTicks(1435));

            migrationBuilder.UpdateData(
                table: "Pets",
                keyColumn: "Id",
                keyValue: 4,
                column: "CreatedTime",
                value: new DateTime(2024, 8, 3, 11, 57, 45, 906, DateTimeKind.Local).AddTicks(1441));

            migrationBuilder.UpdateData(
                table: "Pets",
                keyColumn: "Id",
                keyValue: 5,
                column: "CreatedTime",
                value: new DateTime(2024, 1, 3, 11, 57, 45, 906, DateTimeKind.Local).AddTicks(1498));

            migrationBuilder.UpdateData(
                table: "Pets",
                keyColumn: "Id",
                keyValue: 6,
                column: "CreatedTime",
                value: new DateTime(2024, 2, 3, 11, 57, 45, 906, DateTimeKind.Local).AddTicks(1505));

            migrationBuilder.UpdateData(
                table: "Pets",
                keyColumn: "Id",
                keyValue: 7,
                column: "CreatedTime",
                value: new DateTime(2023, 10, 3, 11, 57, 45, 906, DateTimeKind.Local).AddTicks(1511));

            migrationBuilder.UpdateData(
                table: "Pets",
                keyColumn: "Id",
                keyValue: 8,
                column: "CreatedTime",
                value: new DateTime(2024, 7, 3, 11, 57, 45, 906, DateTimeKind.Local).AddTicks(1516));

            migrationBuilder.UpdateData(
                table: "Pets",
                keyColumn: "Id",
                keyValue: 9,
                column: "CreatedTime",
                value: new DateTime(2024, 3, 3, 11, 57, 45, 906, DateTimeKind.Local).AddTicks(1522));

            migrationBuilder.UpdateData(
                table: "Pets",
                keyColumn: "Id",
                keyValue: 10,
                column: "CreatedTime",
                value: new DateTime(2023, 11, 3, 11, 57, 45, 906, DateTimeKind.Local).AddTicks(1528));

            migrationBuilder.UpdateData(
                table: "Pets",
                keyColumn: "Id",
                keyValue: 11,
                column: "CreatedTime",
                value: new DateTime(2023, 12, 3, 11, 57, 45, 906, DateTimeKind.Local).AddTicks(1533));

            migrationBuilder.UpdateData(
                table: "Pets",
                keyColumn: "Id",
                keyValue: 12,
                column: "CreatedTime",
                value: new DateTime(2023, 10, 3, 11, 57, 45, 906, DateTimeKind.Local).AddTicks(1540));

            migrationBuilder.UpdateData(
                table: "Pets",
                keyColumn: "Id",
                keyValue: 13,
                column: "CreatedTime",
                value: new DateTime(2024, 5, 3, 11, 57, 45, 906, DateTimeKind.Local).AddTicks(1546));

            migrationBuilder.UpdateData(
                table: "Pets",
                keyColumn: "Id",
                keyValue: 14,
                column: "CreatedTime",
                value: new DateTime(2024, 5, 3, 11, 57, 45, 906, DateTimeKind.Local).AddTicks(1551));

            migrationBuilder.UpdateData(
                table: "Pets",
                keyColumn: "Id",
                keyValue: 15,
                column: "CreatedTime",
                value: new DateTime(2023, 12, 3, 11, 57, 45, 906, DateTimeKind.Local).AddTicks(1557));

            migrationBuilder.UpdateData(
                table: "Pets",
                keyColumn: "Id",
                keyValue: 16,
                column: "CreatedTime",
                value: new DateTime(2024, 8, 3, 11, 57, 45, 906, DateTimeKind.Local).AddTicks(1563));

            migrationBuilder.UpdateData(
                table: "Pets",
                keyColumn: "Id",
                keyValue: 17,
                column: "CreatedTime",
                value: new DateTime(2023, 11, 3, 11, 57, 45, 906, DateTimeKind.Local).AddTicks(1569));

            migrationBuilder.UpdateData(
                table: "Pets",
                keyColumn: "Id",
                keyValue: 18,
                column: "CreatedTime",
                value: new DateTime(2023, 10, 3, 11, 57, 45, 906, DateTimeKind.Local).AddTicks(1574));

            migrationBuilder.UpdateData(
                table: "Pets",
                keyColumn: "Id",
                keyValue: 19,
                column: "CreatedTime",
                value: new DateTime(2024, 7, 3, 11, 57, 45, 906, DateTimeKind.Local).AddTicks(1580));

            migrationBuilder.UpdateData(
                table: "Pets",
                keyColumn: "Id",
                keyValue: 20,
                column: "CreatedTime",
                value: new DateTime(2024, 8, 3, 11, 57, 45, 906, DateTimeKind.Local).AddTicks(1587));

            migrationBuilder.UpdateData(
                table: "Pets",
                keyColumn: "Id",
                keyValue: 21,
                column: "CreatedTime",
                value: new DateTime(2024, 7, 3, 11, 57, 45, 906, DateTimeKind.Local).AddTicks(1593));

            migrationBuilder.UpdateData(
                table: "Pets",
                keyColumn: "Id",
                keyValue: 22,
                column: "CreatedTime",
                value: new DateTime(2024, 3, 3, 11, 57, 45, 906, DateTimeKind.Local).AddTicks(1599));

            migrationBuilder.UpdateData(
                table: "Pets",
                keyColumn: "Id",
                keyValue: 23,
                column: "CreatedTime",
                value: new DateTime(2024, 3, 3, 11, 57, 45, 906, DateTimeKind.Local).AddTicks(1604));

            migrationBuilder.UpdateData(
                table: "Pets",
                keyColumn: "Id",
                keyValue: 24,
                column: "CreatedTime",
                value: new DateTime(2024, 4, 3, 11, 57, 45, 906, DateTimeKind.Local).AddTicks(1609));

            migrationBuilder.UpdateData(
                table: "Pets",
                keyColumn: "Id",
                keyValue: 25,
                column: "CreatedTime",
                value: new DateTime(2024, 4, 3, 11, 57, 45, 906, DateTimeKind.Local).AddTicks(1615));

            migrationBuilder.UpdateData(
                table: "Pets",
                keyColumn: "Id",
                keyValue: 26,
                column: "CreatedTime",
                value: new DateTime(2024, 6, 3, 11, 57, 45, 906, DateTimeKind.Local).AddTicks(1623));

            migrationBuilder.UpdateData(
                table: "Pets",
                keyColumn: "Id",
                keyValue: 27,
                column: "CreatedTime",
                value: new DateTime(2024, 6, 3, 11, 57, 45, 906, DateTimeKind.Local).AddTicks(1628));

            migrationBuilder.UpdateData(
                table: "Pets",
                keyColumn: "Id",
                keyValue: 28,
                column: "CreatedTime",
                value: new DateTime(2024, 2, 3, 11, 57, 45, 906, DateTimeKind.Local).AddTicks(1634));

            migrationBuilder.UpdateData(
                table: "Pets",
                keyColumn: "Id",
                keyValue: 29,
                column: "CreatedTime",
                value: new DateTime(2023, 10, 3, 11, 57, 45, 906, DateTimeKind.Local).AddTicks(1639));

            migrationBuilder.UpdateData(
                table: "Pets",
                keyColumn: "Id",
                keyValue: 30,
                column: "CreatedTime",
                value: new DateTime(2024, 4, 3, 11, 57, 45, 906, DateTimeKind.Local).AddTicks(1645));

            migrationBuilder.UpdateData(
                table: "Pets",
                keyColumn: "Id",
                keyValue: 31,
                column: "CreatedTime",
                value: new DateTime(2024, 1, 3, 11, 57, 45, 906, DateTimeKind.Local).AddTicks(1651));

            migrationBuilder.UpdateData(
                table: "Pets",
                keyColumn: "Id",
                keyValue: 32,
                column: "CreatedTime",
                value: new DateTime(2023, 11, 3, 11, 57, 45, 906, DateTimeKind.Local).AddTicks(1656));

            migrationBuilder.UpdateData(
                table: "Pets",
                keyColumn: "Id",
                keyValue: 33,
                column: "CreatedTime",
                value: new DateTime(2024, 1, 3, 11, 57, 45, 906, DateTimeKind.Local).AddTicks(1662));

            migrationBuilder.UpdateData(
                table: "Pets",
                keyColumn: "Id",
                keyValue: 34,
                column: "CreatedTime",
                value: new DateTime(2024, 1, 3, 11, 57, 45, 906, DateTimeKind.Local).AddTicks(1668));

            migrationBuilder.UpdateData(
                table: "Pets",
                keyColumn: "Id",
                keyValue: 35,
                column: "CreatedTime",
                value: new DateTime(2024, 5, 3, 11, 57, 45, 906, DateTimeKind.Local).AddTicks(1673));

            migrationBuilder.UpdateData(
                table: "Pets",
                keyColumn: "Id",
                keyValue: 36,
                column: "CreatedTime",
                value: new DateTime(2024, 3, 3, 11, 57, 45, 906, DateTimeKind.Local).AddTicks(1678));

            migrationBuilder.UpdateData(
                table: "Pets",
                keyColumn: "Id",
                keyValue: 37,
                column: "CreatedTime",
                value: new DateTime(2024, 5, 3, 11, 57, 45, 906, DateTimeKind.Local).AddTicks(1685));

            migrationBuilder.UpdateData(
                table: "Pets",
                keyColumn: "Id",
                keyValue: 38,
                column: "CreatedTime",
                value: new DateTime(2024, 6, 3, 11, 57, 45, 906, DateTimeKind.Local).AddTicks(1690));

            migrationBuilder.UpdateData(
                table: "Pets",
                keyColumn: "Id",
                keyValue: 39,
                column: "CreatedTime",
                value: new DateTime(2024, 7, 3, 11, 57, 45, 906, DateTimeKind.Local).AddTicks(1695));

            migrationBuilder.UpdateData(
                table: "Pets",
                keyColumn: "Id",
                keyValue: 40,
                column: "CreatedTime",
                value: new DateTime(2024, 1, 3, 11, 57, 45, 906, DateTimeKind.Local).AddTicks(1701));

            migrationBuilder.UpdateData(
                table: "Pets",
                keyColumn: "Id",
                keyValue: 41,
                column: "CreatedTime",
                value: new DateTime(2024, 1, 3, 11, 57, 45, 906, DateTimeKind.Local).AddTicks(1706));

            migrationBuilder.UpdateData(
                table: "Pets",
                keyColumn: "Id",
                keyValue: 42,
                column: "CreatedTime",
                value: new DateTime(2024, 7, 3, 11, 57, 45, 906, DateTimeKind.Local).AddTicks(1711));

            migrationBuilder.UpdateData(
                table: "Pets",
                keyColumn: "Id",
                keyValue: 43,
                column: "CreatedTime",
                value: new DateTime(2023, 12, 3, 11, 57, 45, 906, DateTimeKind.Local).AddTicks(1717));

            migrationBuilder.UpdateData(
                table: "Pets",
                keyColumn: "Id",
                keyValue: 44,
                column: "CreatedTime",
                value: new DateTime(2023, 10, 3, 11, 57, 45, 906, DateTimeKind.Local).AddTicks(1723));

            migrationBuilder.UpdateData(
                table: "Pets",
                keyColumn: "Id",
                keyValue: 45,
                column: "CreatedTime",
                value: new DateTime(2024, 3, 3, 11, 57, 45, 906, DateTimeKind.Local).AddTicks(1760));

            migrationBuilder.UpdateData(
                table: "Pets",
                keyColumn: "Id",
                keyValue: 46,
                column: "CreatedTime",
                value: new DateTime(2023, 12, 3, 11, 57, 45, 906, DateTimeKind.Local).AddTicks(1766));

            migrationBuilder.UpdateData(
                table: "Pets",
                keyColumn: "Id",
                keyValue: 47,
                column: "CreatedTime",
                value: new DateTime(2024, 8, 3, 11, 57, 45, 906, DateTimeKind.Local).AddTicks(1771));

            migrationBuilder.UpdateData(
                table: "Pets",
                keyColumn: "Id",
                keyValue: 48,
                column: "CreatedTime",
                value: new DateTime(2024, 2, 3, 11, 57, 45, 906, DateTimeKind.Local).AddTicks(1778));

            migrationBuilder.UpdateData(
                table: "Pets",
                keyColumn: "Id",
                keyValue: 49,
                column: "CreatedTime",
                value: new DateTime(2023, 11, 3, 11, 57, 45, 906, DateTimeKind.Local).AddTicks(1784));

            migrationBuilder.UpdateData(
                table: "Pets",
                keyColumn: "Id",
                keyValue: 50,
                column: "CreatedTime",
                value: new DateTime(2024, 2, 3, 11, 57, 45, 906, DateTimeKind.Local).AddTicks(1789));

            migrationBuilder.UpdateData(
                table: "Shelters",
                keyColumn: "Id",
                keyValue: 1021,
                columns: new[] { "CreatedTime", "LastUpdatedTime" },
                values: new object[] { new DateTime(2024, 9, 3, 7, 57, 45, 895, DateTimeKind.Utc).AddTicks(7451), new DateTime(2024, 9, 3, 7, 57, 45, 895, DateTimeKind.Utc).AddTicks(7452) });

            migrationBuilder.UpdateData(
                table: "Shelters",
                keyColumn: "Id",
                keyValue: 1022,
                columns: new[] { "CreatedTime", "LastUpdatedTime" },
                values: new object[] { new DateTime(2024, 9, 3, 7, 57, 45, 895, DateTimeKind.Utc).AddTicks(7469), new DateTime(2024, 9, 3, 7, 57, 45, 895, DateTimeKind.Utc).AddTicks(7470) });

            migrationBuilder.UpdateData(
                table: "Shelters",
                keyColumn: "Id",
                keyValue: 1023,
                columns: new[] { "CreatedTime", "LastUpdatedTime" },
                values: new object[] { new DateTime(2024, 9, 3, 7, 57, 45, 895, DateTimeKind.Utc).AddTicks(7480), new DateTime(2024, 9, 3, 7, 57, 45, 895, DateTimeKind.Utc).AddTicks(7480) });

            migrationBuilder.UpdateData(
                table: "Shelters",
                keyColumn: "Id",
                keyValue: 1024,
                columns: new[] { "CreatedTime", "LastUpdatedTime" },
                values: new object[] { new DateTime(2024, 9, 3, 7, 57, 45, 895, DateTimeKind.Utc).AddTicks(7488), new DateTime(2024, 9, 3, 7, 57, 45, 895, DateTimeKind.Utc).AddTicks(7489) });

            migrationBuilder.UpdateData(
                table: "Shelters",
                keyColumn: "Id",
                keyValue: 1025,
                columns: new[] { "CreatedTime", "LastUpdatedTime" },
                values: new object[] { new DateTime(2024, 9, 3, 7, 57, 45, 895, DateTimeKind.Utc).AddTicks(7497), new DateTime(2024, 9, 3, 7, 57, 45, 895, DateTimeKind.Utc).AddTicks(7497) });

            migrationBuilder.UpdateData(
                table: "Shelters",
                keyColumn: "Id",
                keyValue: 1026,
                columns: new[] { "CreatedTime", "LastUpdatedTime" },
                values: new object[] { new DateTime(2024, 9, 3, 7, 57, 45, 895, DateTimeKind.Utc).AddTicks(7508), new DateTime(2024, 9, 3, 7, 57, 45, 895, DateTimeKind.Utc).AddTicks(7508) });

            migrationBuilder.UpdateData(
                table: "Shelters",
                keyColumn: "Id",
                keyValue: 1027,
                columns: new[] { "CreatedTime", "LastUpdatedTime" },
                values: new object[] { new DateTime(2024, 9, 3, 7, 57, 45, 895, DateTimeKind.Utc).AddTicks(7516), new DateTime(2024, 9, 3, 7, 57, 45, 895, DateTimeKind.Utc).AddTicks(7516) });

            migrationBuilder.UpdateData(
                table: "Shelters",
                keyColumn: "Id",
                keyValue: 1028,
                columns: new[] { "CreatedTime", "LastUpdatedTime" },
                values: new object[] { new DateTime(2024, 9, 3, 7, 57, 45, 895, DateTimeKind.Utc).AddTicks(7524), new DateTime(2024, 9, 3, 7, 57, 45, 895, DateTimeKind.Utc).AddTicks(7524) });

            migrationBuilder.UpdateData(
                table: "Shelters",
                keyColumn: "Id",
                keyValue: 1029,
                columns: new[] { "CreatedTime", "LastUpdatedTime" },
                values: new object[] { new DateTime(2024, 9, 3, 7, 57, 45, 895, DateTimeKind.Utc).AddTicks(7532), new DateTime(2024, 9, 3, 7, 57, 45, 895, DateTimeKind.Utc).AddTicks(7532) });

            migrationBuilder.UpdateData(
                table: "Shelters",
                keyColumn: "Id",
                keyValue: 1030,
                columns: new[] { "CreatedTime", "LastUpdatedTime" },
                values: new object[] { new DateTime(2024, 9, 3, 7, 57, 45, 895, DateTimeKind.Utc).AddTicks(7541), new DateTime(2024, 9, 3, 7, 57, 45, 895, DateTimeKind.Utc).AddTicks(7542) });

            migrationBuilder.UpdateData(
                table: "Shelters",
                keyColumn: "Id",
                keyValue: 1031,
                columns: new[] { "CreatedTime", "LastUpdatedTime" },
                values: new object[] { new DateTime(2024, 9, 3, 7, 57, 45, 895, DateTimeKind.Utc).AddTicks(7613), new DateTime(2024, 9, 3, 7, 57, 45, 895, DateTimeKind.Utc).AddTicks(7613) });

            migrationBuilder.UpdateData(
                table: "Shelters",
                keyColumn: "Id",
                keyValue: 1032,
                columns: new[] { "CreatedTime", "LastUpdatedTime" },
                values: new object[] { new DateTime(2024, 9, 3, 7, 57, 45, 895, DateTimeKind.Utc).AddTicks(7621), new DateTime(2024, 9, 3, 7, 57, 45, 895, DateTimeKind.Utc).AddTicks(7622) });

            migrationBuilder.UpdateData(
                table: "Shelters",
                keyColumn: "Id",
                keyValue: 1033,
                columns: new[] { "CreatedTime", "LastUpdatedTime" },
                values: new object[] { new DateTime(2024, 9, 3, 7, 57, 45, 895, DateTimeKind.Utc).AddTicks(7630), new DateTime(2024, 9, 3, 7, 57, 45, 895, DateTimeKind.Utc).AddTicks(7630) });

            migrationBuilder.UpdateData(
                table: "Shelters",
                keyColumn: "Id",
                keyValue: 1034,
                columns: new[] { "CreatedTime", "LastUpdatedTime" },
                values: new object[] { new DateTime(2024, 9, 3, 7, 57, 45, 895, DateTimeKind.Utc).AddTicks(7638), new DateTime(2024, 9, 3, 7, 57, 45, 895, DateTimeKind.Utc).AddTicks(7638) });

            migrationBuilder.UpdateData(
                table: "Shelters",
                keyColumn: "Id",
                keyValue: 1035,
                columns: new[] { "CreatedTime", "LastUpdatedTime" },
                values: new object[] { new DateTime(2024, 9, 3, 7, 57, 45, 895, DateTimeKind.Utc).AddTicks(7646), new DateTime(2024, 9, 3, 7, 57, 45, 895, DateTimeKind.Utc).AddTicks(7646) });

            migrationBuilder.UpdateData(
                table: "Shelters",
                keyColumn: "Id",
                keyValue: 1036,
                columns: new[] { "CreatedTime", "LastUpdatedTime" },
                values: new object[] { new DateTime(2024, 9, 3, 7, 57, 45, 895, DateTimeKind.Utc).AddTicks(7654), new DateTime(2024, 9, 3, 7, 57, 45, 895, DateTimeKind.Utc).AddTicks(7655) });

            migrationBuilder.UpdateData(
                table: "Shelters",
                keyColumn: "Id",
                keyValue: 1037,
                columns: new[] { "CreatedTime", "LastUpdatedTime" },
                values: new object[] { new DateTime(2024, 9, 3, 7, 57, 45, 895, DateTimeKind.Utc).AddTicks(7662), new DateTime(2024, 9, 3, 7, 57, 45, 895, DateTimeKind.Utc).AddTicks(7663) });

            migrationBuilder.UpdateData(
                table: "Shelters",
                keyColumn: "Id",
                keyValue: 1038,
                columns: new[] { "CreatedTime", "LastUpdatedTime" },
                values: new object[] { new DateTime(2024, 9, 3, 7, 57, 45, 895, DateTimeKind.Utc).AddTicks(7673), new DateTime(2024, 9, 3, 7, 57, 45, 895, DateTimeKind.Utc).AddTicks(7673) });

            migrationBuilder.UpdateData(
                table: "Shelters",
                keyColumn: "Id",
                keyValue: 1039,
                columns: new[] { "CreatedTime", "LastUpdatedTime" },
                values: new object[] { new DateTime(2024, 9, 3, 7, 57, 45, 895, DateTimeKind.Utc).AddTicks(7681), new DateTime(2024, 9, 3, 7, 57, 45, 895, DateTimeKind.Utc).AddTicks(7681) });

            migrationBuilder.UpdateData(
                table: "Shelters",
                keyColumn: "Id",
                keyValue: 1040,
                columns: new[] { "CreatedTime", "LastUpdatedTime" },
                values: new object[] { new DateTime(2024, 9, 3, 7, 57, 45, 895, DateTimeKind.Utc).AddTicks(7689), new DateTime(2024, 9, 3, 7, 57, 45, 895, DateTimeKind.Utc).AddTicks(7689) });
        }
    }
}
