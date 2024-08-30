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
            migrationBuilder.DropColumn(
                name: "YearsOfPetExperience",
                table: "AcceptRequests");

            migrationBuilder.AddColumn<string>(
                name: "EmailAddress",
                table: "Shelters",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "About",
                table: "Adoptions",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "");

            migrationBuilder.AddColumn<int>(
                name: "YearsOfPetExperience",
                table: "Adoptions",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: 2001,
                columns: new[] { "ConcurrencyStamp", "CreatedTime", "LastUpdatedTime", "RefreshTokenCreateTime" },
                values: new object[] { "7c04f6a2-5a6f-46eb-9510-16d997a3f135", new DateTime(2024, 8, 30, 7, 21, 47, 408, DateTimeKind.Utc).AddTicks(103), new DateTime(2024, 8, 30, 7, 21, 47, 408, DateTimeKind.Utc).AddTicks(105), new DateTime(2024, 8, 30, 7, 21, 47, 408, DateTimeKind.Utc).AddTicks(32) });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: 2002,
                columns: new[] { "ConcurrencyStamp", "CreatedTime", "LastUpdatedTime", "RefreshTokenCreateTime" },
                values: new object[] { "a15664d0-ef9b-4330-b6f1-52e44f6190eb", new DateTime(2024, 8, 30, 7, 21, 47, 408, DateTimeKind.Utc).AddTicks(162), new DateTime(2024, 8, 30, 7, 21, 47, 408, DateTimeKind.Utc).AddTicks(163), new DateTime(2024, 8, 30, 7, 21, 47, 408, DateTimeKind.Utc).AddTicks(158) });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: 2003,
                columns: new[] { "ConcurrencyStamp", "CreatedTime", "LastUpdatedTime", "RefreshTokenCreateTime" },
                values: new object[] { "7f96425b-fba1-4e2b-9a82-cb8a2e097350", new DateTime(2024, 8, 30, 7, 21, 47, 408, DateTimeKind.Utc).AddTicks(176), new DateTime(2024, 8, 30, 7, 21, 47, 408, DateTimeKind.Utc).AddTicks(177), new DateTime(2024, 8, 30, 7, 21, 47, 408, DateTimeKind.Utc).AddTicks(173) });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: 2004,
                columns: new[] { "ConcurrencyStamp", "CreatedTime", "LastUpdatedTime", "RefreshTokenCreateTime" },
                values: new object[] { "e984f465-550d-48b4-953e-2a65d86654e3", new DateTime(2024, 8, 30, 7, 21, 47, 408, DateTimeKind.Utc).AddTicks(190), new DateTime(2024, 8, 30, 7, 21, 47, 408, DateTimeKind.Utc).AddTicks(190), new DateTime(2024, 8, 30, 7, 21, 47, 408, DateTimeKind.Utc).AddTicks(187) });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: 2005,
                columns: new[] { "ConcurrencyStamp", "CreatedTime", "LastUpdatedTime", "RefreshTokenCreateTime" },
                values: new object[] { "8955436d-4239-4ca3-bb39-a32d59dfa987", new DateTime(2024, 8, 30, 7, 21, 47, 408, DateTimeKind.Utc).AddTicks(203), new DateTime(2024, 8, 30, 7, 21, 47, 408, DateTimeKind.Utc).AddTicks(203), new DateTime(2024, 8, 30, 7, 21, 47, 408, DateTimeKind.Utc).AddTicks(200) });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: 2006,
                columns: new[] { "ConcurrencyStamp", "CreatedTime", "LastUpdatedTime", "RefreshTokenCreateTime" },
                values: new object[] { "8f8a501a-9121-4559-9050-bceb307131b4", new DateTime(2024, 8, 30, 7, 21, 47, 408, DateTimeKind.Utc).AddTicks(218), new DateTime(2024, 8, 30, 7, 21, 47, 408, DateTimeKind.Utc).AddTicks(219), new DateTime(2024, 8, 30, 7, 21, 47, 408, DateTimeKind.Utc).AddTicks(215) });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: 2007,
                columns: new[] { "ConcurrencyStamp", "CreatedTime", "LastUpdatedTime", "RefreshTokenCreateTime" },
                values: new object[] { "2fae0053-b663-42f5-aae7-1f81d3e1f41b", new DateTime(2024, 8, 30, 7, 21, 47, 408, DateTimeKind.Utc).AddTicks(230), new DateTime(2024, 8, 30, 7, 21, 47, 408, DateTimeKind.Utc).AddTicks(231), new DateTime(2024, 8, 30, 7, 21, 47, 408, DateTimeKind.Utc).AddTicks(227) });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: 2008,
                columns: new[] { "ConcurrencyStamp", "CreatedTime", "LastUpdatedTime", "RefreshTokenCreateTime" },
                values: new object[] { "3dfd9ff1-66c1-44ec-a41e-8d491169dfa9", new DateTime(2024, 8, 30, 7, 21, 47, 408, DateTimeKind.Utc).AddTicks(306), new DateTime(2024, 8, 30, 7, 21, 47, 408, DateTimeKind.Utc).AddTicks(307), new DateTime(2024, 8, 30, 7, 21, 47, 408, DateTimeKind.Utc).AddTicks(291) });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: 2009,
                columns: new[] { "ConcurrencyStamp", "CreatedTime", "LastUpdatedTime", "RefreshTokenCreateTime" },
                values: new object[] { "59ad86db-8f06-49ed-9124-18cde001ce16", new DateTime(2024, 8, 30, 7, 21, 47, 408, DateTimeKind.Utc).AddTicks(320), new DateTime(2024, 8, 30, 7, 21, 47, 408, DateTimeKind.Utc).AddTicks(320), new DateTime(2024, 8, 30, 7, 21, 47, 408, DateTimeKind.Utc).AddTicks(316) });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: 2010,
                columns: new[] { "ConcurrencyStamp", "CreatedTime", "LastUpdatedTime", "RefreshTokenCreateTime" },
                values: new object[] { "00617397-9e0f-46c0-ad4b-13b4613d13fb", new DateTime(2024, 8, 30, 7, 21, 47, 408, DateTimeKind.Utc).AddTicks(334), new DateTime(2024, 8, 30, 7, 21, 47, 408, DateTimeKind.Utc).AddTicks(335), new DateTime(2024, 8, 30, 7, 21, 47, 408, DateTimeKind.Utc).AddTicks(331) });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: 2011,
                columns: new[] { "ConcurrencyStamp", "CreatedTime", "LastUpdatedTime", "RefreshTokenCreateTime" },
                values: new object[] { "84f9a458-4d8f-4e62-ac96-c043143831a3", new DateTime(2024, 8, 30, 7, 21, 47, 408, DateTimeKind.Utc).AddTicks(349), new DateTime(2024, 8, 30, 7, 21, 47, 408, DateTimeKind.Utc).AddTicks(350), new DateTime(2024, 8, 30, 7, 21, 47, 408, DateTimeKind.Utc).AddTicks(346) });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: 2012,
                columns: new[] { "ConcurrencyStamp", "CreatedTime", "LastUpdatedTime", "RefreshTokenCreateTime" },
                values: new object[] { "dc45b937-1d00-446a-8b66-955708781ee9", new DateTime(2024, 8, 30, 7, 21, 47, 408, DateTimeKind.Utc).AddTicks(363), new DateTime(2024, 8, 30, 7, 21, 47, 408, DateTimeKind.Utc).AddTicks(363), new DateTime(2024, 8, 30, 7, 21, 47, 408, DateTimeKind.Utc).AddTicks(360) });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: 2013,
                columns: new[] { "ConcurrencyStamp", "CreatedTime", "LastUpdatedTime", "RefreshTokenCreateTime" },
                values: new object[] { "6f05d58b-a926-4739-bcd6-21853a0bf3ca", new DateTime(2024, 8, 30, 7, 21, 47, 408, DateTimeKind.Utc).AddTicks(375), new DateTime(2024, 8, 30, 7, 21, 47, 408, DateTimeKind.Utc).AddTicks(376), new DateTime(2024, 8, 30, 7, 21, 47, 408, DateTimeKind.Utc).AddTicks(372) });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: 2014,
                columns: new[] { "ConcurrencyStamp", "CreatedTime", "LastUpdatedTime", "RefreshTokenCreateTime" },
                values: new object[] { "14398ef8-36f0-493c-a279-f679b1c5dd80", new DateTime(2024, 8, 30, 7, 21, 47, 408, DateTimeKind.Utc).AddTicks(389), new DateTime(2024, 8, 30, 7, 21, 47, 408, DateTimeKind.Utc).AddTicks(389), new DateTime(2024, 8, 30, 7, 21, 47, 408, DateTimeKind.Utc).AddTicks(385) });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: 2015,
                columns: new[] { "ConcurrencyStamp", "CreatedTime", "LastUpdatedTime", "RefreshTokenCreateTime" },
                values: new object[] { "00afd329-23f1-46a8-a85a-b51faa401e48", new DateTime(2024, 8, 30, 7, 21, 47, 408, DateTimeKind.Utc).AddTicks(401), new DateTime(2024, 8, 30, 7, 21, 47, 408, DateTimeKind.Utc).AddTicks(401), new DateTime(2024, 8, 30, 7, 21, 47, 408, DateTimeKind.Utc).AddTicks(398) });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: 2016,
                columns: new[] { "ConcurrencyStamp", "CreatedTime", "LastUpdatedTime", "RefreshTokenCreateTime" },
                values: new object[] { "cf91c00b-5220-4df3-b973-a052285c460a", new DateTime(2024, 8, 30, 7, 21, 47, 408, DateTimeKind.Utc).AddTicks(417), new DateTime(2024, 8, 30, 7, 21, 47, 408, DateTimeKind.Utc).AddTicks(418), new DateTime(2024, 8, 30, 7, 21, 47, 408, DateTimeKind.Utc).AddTicks(411) });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: 2017,
                columns: new[] { "ConcurrencyStamp", "CreatedTime", "LastUpdatedTime", "RefreshTokenCreateTime" },
                values: new object[] { "3e2c6025-51cf-4315-be10-5c9a52d69528", new DateTime(2024, 8, 30, 7, 21, 47, 408, DateTimeKind.Utc).AddTicks(431), new DateTime(2024, 8, 30, 7, 21, 47, 408, DateTimeKind.Utc).AddTicks(431), new DateTime(2024, 8, 30, 7, 21, 47, 408, DateTimeKind.Utc).AddTicks(427) });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: 2018,
                columns: new[] { "ConcurrencyStamp", "CreatedTime", "LastUpdatedTime", "RefreshTokenCreateTime" },
                values: new object[] { "2d6472b6-f4ea-4105-91a3-9cb8aa6bd866", new DateTime(2024, 8, 30, 7, 21, 47, 408, DateTimeKind.Utc).AddTicks(484), new DateTime(2024, 8, 30, 7, 21, 47, 408, DateTimeKind.Utc).AddTicks(484), new DateTime(2024, 8, 30, 7, 21, 47, 408, DateTimeKind.Utc).AddTicks(481) });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: 2019,
                columns: new[] { "ConcurrencyStamp", "CreatedTime", "LastUpdatedTime", "RefreshTokenCreateTime" },
                values: new object[] { "4eddf356-5004-4b09-94b8-531f988dda59", new DateTime(2024, 8, 30, 7, 21, 47, 408, DateTimeKind.Utc).AddTicks(497), new DateTime(2024, 8, 30, 7, 21, 47, 408, DateTimeKind.Utc).AddTicks(497), new DateTime(2024, 8, 30, 7, 21, 47, 408, DateTimeKind.Utc).AddTicks(494) });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: 2020,
                columns: new[] { "ConcurrencyStamp", "CreatedTime", "LastUpdatedTime", "RefreshTokenCreateTime" },
                values: new object[] { "090751a9-6c8e-4958-bb36-e9ac54a0491c", new DateTime(2024, 8, 30, 7, 21, 47, 408, DateTimeKind.Utc).AddTicks(510), new DateTime(2024, 8, 30, 7, 21, 47, 408, DateTimeKind.Utc).AddTicks(510), new DateTime(2024, 8, 30, 7, 21, 47, 408, DateTimeKind.Utc).AddTicks(507) });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: 2021,
                columns: new[] { "ConcurrencyStamp", "CreatedTime", "LastUpdatedTime", "RefreshTokenCreateTime" },
                values: new object[] { "510b2564-d882-4e50-aae7-31edd7fff9f5", new DateTime(2024, 8, 30, 7, 21, 47, 408, DateTimeKind.Utc).AddTicks(522), new DateTime(2024, 8, 30, 7, 21, 47, 408, DateTimeKind.Utc).AddTicks(523), new DateTime(2024, 8, 30, 7, 21, 47, 408, DateTimeKind.Utc).AddTicks(519) });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: 2022,
                columns: new[] { "ConcurrencyStamp", "CreatedTime", "LastUpdatedTime", "RefreshTokenCreateTime" },
                values: new object[] { "b514baca-7eb0-4fd4-bae0-f1a61ed7ef5f", new DateTime(2024, 8, 30, 7, 21, 47, 408, DateTimeKind.Utc).AddTicks(541), new DateTime(2024, 8, 30, 7, 21, 47, 408, DateTimeKind.Utc).AddTicks(542), new DateTime(2024, 8, 30, 7, 21, 47, 408, DateTimeKind.Utc).AddTicks(538) });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: 2023,
                columns: new[] { "ConcurrencyStamp", "CreatedTime", "LastUpdatedTime", "RefreshTokenCreateTime" },
                values: new object[] { "5c9c8724-ac37-4d7d-94d9-22ff4528a051", new DateTime(2024, 8, 30, 7, 21, 47, 408, DateTimeKind.Utc).AddTicks(555), new DateTime(2024, 8, 30, 7, 21, 47, 408, DateTimeKind.Utc).AddTicks(556), new DateTime(2024, 8, 30, 7, 21, 47, 408, DateTimeKind.Utc).AddTicks(552) });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: 2024,
                columns: new[] { "ConcurrencyStamp", "CreatedTime", "LastUpdatedTime", "RefreshTokenCreateTime" },
                values: new object[] { "2495c268-c8cf-43b5-bb9e-725ac65e2ff1", new DateTime(2024, 8, 30, 7, 21, 47, 408, DateTimeKind.Utc).AddTicks(573), new DateTime(2024, 8, 30, 7, 21, 47, 408, DateTimeKind.Utc).AddTicks(573), new DateTime(2024, 8, 30, 7, 21, 47, 408, DateTimeKind.Utc).AddTicks(566) });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: 2025,
                columns: new[] { "ConcurrencyStamp", "CreatedTime", "LastUpdatedTime", "RefreshTokenCreateTime" },
                values: new object[] { "2e5fdcdc-4ba1-4521-b386-5389d5406b67", new DateTime(2024, 8, 30, 7, 21, 47, 408, DateTimeKind.Utc).AddTicks(587), new DateTime(2024, 8, 30, 7, 21, 47, 408, DateTimeKind.Utc).AddTicks(587), new DateTime(2024, 8, 30, 7, 21, 47, 408, DateTimeKind.Utc).AddTicks(583) });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: 2026,
                columns: new[] { "ConcurrencyStamp", "CreatedTime", "LastUpdatedTime", "RefreshTokenCreateTime" },
                values: new object[] { "5a1a679f-3230-43bb-b1ba-ab9adf1acdc7", new DateTime(2024, 8, 30, 7, 21, 47, 408, DateTimeKind.Utc).AddTicks(601), new DateTime(2024, 8, 30, 7, 21, 47, 408, DateTimeKind.Utc).AddTicks(601), new DateTime(2024, 8, 30, 7, 21, 47, 408, DateTimeKind.Utc).AddTicks(598) });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: 2027,
                columns: new[] { "ConcurrencyStamp", "CreatedTime", "LastUpdatedTime", "RefreshTokenCreateTime" },
                values: new object[] { "b35f6e68-d7bd-49a6-b666-3d261efb5c2e", new DateTime(2024, 8, 30, 7, 21, 47, 408, DateTimeKind.Utc).AddTicks(655), new DateTime(2024, 8, 30, 7, 21, 47, 408, DateTimeKind.Utc).AddTicks(655), new DateTime(2024, 8, 30, 7, 21, 47, 408, DateTimeKind.Utc).AddTicks(651) });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: 2028,
                columns: new[] { "ConcurrencyStamp", "CreatedTime", "LastUpdatedTime", "RefreshTokenCreateTime" },
                values: new object[] { "d47935eb-621c-4ecf-83dc-8a73e028f149", new DateTime(2024, 8, 30, 7, 21, 47, 408, DateTimeKind.Utc).AddTicks(668), new DateTime(2024, 8, 30, 7, 21, 47, 408, DateTimeKind.Utc).AddTicks(669), new DateTime(2024, 8, 30, 7, 21, 47, 408, DateTimeKind.Utc).AddTicks(666) });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: 2029,
                columns: new[] { "ConcurrencyStamp", "CreatedTime", "LastUpdatedTime", "RefreshTokenCreateTime" },
                values: new object[] { "870aaf4d-2bca-46f5-93c1-bd39eb583913", new DateTime(2024, 8, 30, 7, 21, 47, 408, DateTimeKind.Utc).AddTicks(682), new DateTime(2024, 8, 30, 7, 21, 47, 408, DateTimeKind.Utc).AddTicks(682), new DateTime(2024, 8, 30, 7, 21, 47, 408, DateTimeKind.Utc).AddTicks(679) });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: 2030,
                columns: new[] { "ConcurrencyStamp", "CreatedTime", "LastUpdatedTime", "RefreshTokenCreateTime" },
                values: new object[] { "01761988-e0bc-4825-9876-80ac12f04f50", new DateTime(2024, 8, 30, 7, 21, 47, 408, DateTimeKind.Utc).AddTicks(696), new DateTime(2024, 8, 30, 7, 21, 47, 408, DateTimeKind.Utc).AddTicks(696), new DateTime(2024, 8, 30, 7, 21, 47, 408, DateTimeKind.Utc).AddTicks(693) });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: 2031,
                columns: new[] { "ConcurrencyStamp", "CreatedTime", "LastUpdatedTime", "RefreshTokenCreateTime" },
                values: new object[] { "596c369c-c598-4d64-8d92-7797f3f82c40", new DateTime(2024, 8, 30, 7, 21, 47, 408, DateTimeKind.Utc).AddTicks(709), new DateTime(2024, 8, 30, 7, 21, 47, 408, DateTimeKind.Utc).AddTicks(710), new DateTime(2024, 8, 30, 7, 21, 47, 408, DateTimeKind.Utc).AddTicks(706) });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: 2032,
                columns: new[] { "ConcurrencyStamp", "CreatedTime", "LastUpdatedTime", "RefreshTokenCreateTime" },
                values: new object[] { "a7e844df-b1af-4620-a3f1-141670d5c116", new DateTime(2024, 8, 30, 7, 21, 47, 408, DateTimeKind.Utc).AddTicks(726), new DateTime(2024, 8, 30, 7, 21, 47, 408, DateTimeKind.Utc).AddTicks(727), new DateTime(2024, 8, 30, 7, 21, 47, 408, DateTimeKind.Utc).AddTicks(720) });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: 2033,
                columns: new[] { "ConcurrencyStamp", "CreatedTime", "LastUpdatedTime", "RefreshTokenCreateTime" },
                values: new object[] { "17338b14-54e2-4011-bdb2-70265f9eef58", new DateTime(2024, 8, 30, 7, 21, 47, 408, DateTimeKind.Utc).AddTicks(740), new DateTime(2024, 8, 30, 7, 21, 47, 408, DateTimeKind.Utc).AddTicks(740), new DateTime(2024, 8, 30, 7, 21, 47, 408, DateTimeKind.Utc).AddTicks(737) });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: 2034,
                columns: new[] { "ConcurrencyStamp", "CreatedTime", "LastUpdatedTime", "RefreshTokenCreateTime" },
                values: new object[] { "e86de801-55e4-426f-ade4-c8f0319c1797", new DateTime(2024, 8, 30, 7, 21, 47, 408, DateTimeKind.Utc).AddTicks(755), new DateTime(2024, 8, 30, 7, 21, 47, 408, DateTimeKind.Utc).AddTicks(756), new DateTime(2024, 8, 30, 7, 21, 47, 408, DateTimeKind.Utc).AddTicks(752) });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: 2035,
                columns: new[] { "ConcurrencyStamp", "CreatedTime", "LastUpdatedTime", "RefreshTokenCreateTime" },
                values: new object[] { "6dd7ae4c-dc46-4c4a-b38d-b9bb890ad289", new DateTime(2024, 8, 30, 7, 21, 47, 408, DateTimeKind.Utc).AddTicks(806), new DateTime(2024, 8, 30, 7, 21, 47, 408, DateTimeKind.Utc).AddTicks(807), new DateTime(2024, 8, 30, 7, 21, 47, 408, DateTimeKind.Utc).AddTicks(803) });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: 2036,
                columns: new[] { "ConcurrencyStamp", "CreatedTime", "LastUpdatedTime", "RefreshTokenCreateTime" },
                values: new object[] { "778a64e0-dcde-4080-be2b-dba0650d5f33", new DateTime(2024, 8, 30, 7, 21, 47, 408, DateTimeKind.Utc).AddTicks(820), new DateTime(2024, 8, 30, 7, 21, 47, 408, DateTimeKind.Utc).AddTicks(821), new DateTime(2024, 8, 30, 7, 21, 47, 408, DateTimeKind.Utc).AddTicks(817) });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: 2037,
                columns: new[] { "ConcurrencyStamp", "CreatedTime", "LastUpdatedTime", "RefreshTokenCreateTime" },
                values: new object[] { "a1fe0c26-4232-4bcc-aad4-cb706f3207b7", new DateTime(2024, 8, 30, 7, 21, 47, 408, DateTimeKind.Utc).AddTicks(834), new DateTime(2024, 8, 30, 7, 21, 47, 408, DateTimeKind.Utc).AddTicks(834), new DateTime(2024, 8, 30, 7, 21, 47, 408, DateTimeKind.Utc).AddTicks(830) });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: 2038,
                columns: new[] { "ConcurrencyStamp", "CreatedTime", "LastUpdatedTime", "RefreshTokenCreateTime" },
                values: new object[] { "b2287219-bd55-4332-8b84-9b35e8da5b1c", new DateTime(2024, 8, 30, 7, 21, 47, 408, DateTimeKind.Utc).AddTicks(848), new DateTime(2024, 8, 30, 7, 21, 47, 408, DateTimeKind.Utc).AddTicks(849), new DateTime(2024, 8, 30, 7, 21, 47, 408, DateTimeKind.Utc).AddTicks(845) });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: 2039,
                columns: new[] { "ConcurrencyStamp", "CreatedTime", "LastUpdatedTime", "RefreshTokenCreateTime" },
                values: new object[] { "aa8c0c8f-eeaa-47e6-90ab-88ef70e2d403", new DateTime(2024, 8, 30, 7, 21, 47, 408, DateTimeKind.Utc).AddTicks(861), new DateTime(2024, 8, 30, 7, 21, 47, 408, DateTimeKind.Utc).AddTicks(862), new DateTime(2024, 8, 30, 7, 21, 47, 408, DateTimeKind.Utc).AddTicks(859) });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: 2040,
                columns: new[] { "ConcurrencyStamp", "CreatedTime", "LastUpdatedTime", "RefreshTokenCreateTime" },
                values: new object[] { "f40961b8-7da5-4a3f-b29e-c28e2ce87c82", new DateTime(2024, 8, 30, 7, 21, 47, 408, DateTimeKind.Utc).AddTicks(878), new DateTime(2024, 8, 30, 7, 21, 47, 408, DateTimeKind.Utc).AddTicks(879), new DateTime(2024, 8, 30, 7, 21, 47, 408, DateTimeKind.Utc).AddTicks(872) });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: 2041,
                columns: new[] { "ConcurrencyStamp", "CreatedTime", "LastUpdatedTime", "RefreshTokenCreateTime" },
                values: new object[] { "dc2d1e6d-0525-46a1-bf67-c857f5ad66bb", new DateTime(2024, 8, 30, 7, 21, 47, 408, DateTimeKind.Utc).AddTicks(892), new DateTime(2024, 8, 30, 7, 21, 47, 408, DateTimeKind.Utc).AddTicks(893), new DateTime(2024, 8, 30, 7, 21, 47, 408, DateTimeKind.Utc).AddTicks(889) });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: 2042,
                columns: new[] { "ConcurrencyStamp", "CreatedTime", "LastUpdatedTime", "RefreshTokenCreateTime" },
                values: new object[] { "5b32f2c8-7265-4c9d-984e-eb490cf39ff8", new DateTime(2024, 8, 30, 7, 21, 47, 408, DateTimeKind.Utc).AddTicks(909), new DateTime(2024, 8, 30, 7, 21, 47, 408, DateTimeKind.Utc).AddTicks(910), new DateTime(2024, 8, 30, 7, 21, 47, 408, DateTimeKind.Utc).AddTicks(906) });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: 2043,
                columns: new[] { "ConcurrencyStamp", "CreatedTime", "LastUpdatedTime", "RefreshTokenCreateTime" },
                values: new object[] { "0b012e85-73ab-4254-83f7-1b7816404a1d", new DateTime(2024, 8, 30, 7, 21, 47, 408, DateTimeKind.Utc).AddTicks(923), new DateTime(2024, 8, 30, 7, 21, 47, 408, DateTimeKind.Utc).AddTicks(923), new DateTime(2024, 8, 30, 7, 21, 47, 408, DateTimeKind.Utc).AddTicks(920) });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: 2044,
                columns: new[] { "ConcurrencyStamp", "CreatedTime", "LastUpdatedTime", "RefreshTokenCreateTime" },
                values: new object[] { "5ca834e6-9346-4a6b-9f97-792597ed97a2", new DateTime(2024, 8, 30, 7, 21, 47, 408, DateTimeKind.Utc).AddTicks(971), new DateTime(2024, 8, 30, 7, 21, 47, 408, DateTimeKind.Utc).AddTicks(972), new DateTime(2024, 8, 30, 7, 21, 47, 408, DateTimeKind.Utc).AddTicks(968) });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: 2045,
                columns: new[] { "ConcurrencyStamp", "CreatedTime", "LastUpdatedTime", "RefreshTokenCreateTime" },
                values: new object[] { "f7a917ce-ef9a-4fda-89d9-ee081730d979", new DateTime(2024, 8, 30, 7, 21, 47, 408, DateTimeKind.Utc).AddTicks(985), new DateTime(2024, 8, 30, 7, 21, 47, 408, DateTimeKind.Utc).AddTicks(985), new DateTime(2024, 8, 30, 7, 21, 47, 408, DateTimeKind.Utc).AddTicks(981) });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: 2046,
                columns: new[] { "ConcurrencyStamp", "CreatedTime", "LastUpdatedTime", "RefreshTokenCreateTime" },
                values: new object[] { "881097b3-b031-4140-98e7-aea9256bea00", new DateTime(2024, 8, 30, 7, 21, 47, 408, DateTimeKind.Utc).AddTicks(997), new DateTime(2024, 8, 30, 7, 21, 47, 408, DateTimeKind.Utc).AddTicks(998), new DateTime(2024, 8, 30, 7, 21, 47, 408, DateTimeKind.Utc).AddTicks(994) });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: 2047,
                columns: new[] { "ConcurrencyStamp", "CreatedTime", "LastUpdatedTime", "RefreshTokenCreateTime" },
                values: new object[] { "0b34431d-ff25-464e-ab90-9333459aeb5a", new DateTime(2024, 8, 30, 7, 21, 47, 408, DateTimeKind.Utc).AddTicks(1009), new DateTime(2024, 8, 30, 7, 21, 47, 408, DateTimeKind.Utc).AddTicks(1010), new DateTime(2024, 8, 30, 7, 21, 47, 408, DateTimeKind.Utc).AddTicks(1007) });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: 2048,
                columns: new[] { "ConcurrencyStamp", "CreatedTime", "LastUpdatedTime", "RefreshTokenCreateTime" },
                values: new object[] { "5de3dea5-9e4f-4dfe-901e-cab63491cf14", new DateTime(2024, 8, 30, 7, 21, 47, 408, DateTimeKind.Utc).AddTicks(1026), new DateTime(2024, 8, 30, 7, 21, 47, 408, DateTimeKind.Utc).AddTicks(1026), new DateTime(2024, 8, 30, 7, 21, 47, 408, DateTimeKind.Utc).AddTicks(1020) });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: 2049,
                columns: new[] { "ConcurrencyStamp", "CreatedTime", "LastUpdatedTime", "RefreshTokenCreateTime" },
                values: new object[] { "99f563ef-a0a4-48d5-8896-e21fb7d2cc06", new DateTime(2024, 8, 30, 7, 21, 47, 408, DateTimeKind.Utc).AddTicks(1039), new DateTime(2024, 8, 30, 7, 21, 47, 408, DateTimeKind.Utc).AddTicks(1039), new DateTime(2024, 8, 30, 7, 21, 47, 408, DateTimeKind.Utc).AddTicks(1036) });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: 2050,
                columns: new[] { "ConcurrencyStamp", "CreatedTime", "LastUpdatedTime", "RefreshTokenCreateTime" },
                values: new object[] { "60f01eef-6a8b-4e55-9c48-be63a356b5dd", new DateTime(2024, 8, 30, 7, 21, 47, 408, DateTimeKind.Utc).AddTicks(1051), new DateTime(2024, 8, 30, 7, 21, 47, 408, DateTimeKind.Utc).AddTicks(1052), new DateTime(2024, 8, 30, 7, 21, 47, 408, DateTimeKind.Utc).AddTicks(1048) });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: 2051,
                columns: new[] { "ConcurrencyStamp", "CreatedTime", "LastUpdatedTime", "RefreshTokenCreateTime" },
                values: new object[] { "5d0b3cb1-2813-4129-bed4-9dd184ebbf5d", new DateTime(2024, 8, 30, 7, 21, 47, 408, DateTimeKind.Utc).AddTicks(1064), new DateTime(2024, 8, 30, 7, 21, 47, 408, DateTimeKind.Utc).AddTicks(1064), new DateTime(2024, 8, 30, 7, 21, 47, 408, DateTimeKind.Utc).AddTicks(1061) });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: 2052,
                columns: new[] { "ConcurrencyStamp", "CreatedTime", "LastUpdatedTime", "RefreshTokenCreateTime" },
                values: new object[] { "52dcdc04-26da-4f06-8200-7b42064a2a32", new DateTime(2024, 8, 30, 7, 21, 47, 408, DateTimeKind.Utc).AddTicks(1077), new DateTime(2024, 8, 30, 7, 21, 47, 408, DateTimeKind.Utc).AddTicks(1077), new DateTime(2024, 8, 30, 7, 21, 47, 408, DateTimeKind.Utc).AddTicks(1074) });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: 2053,
                columns: new[] { "ConcurrencyStamp", "CreatedTime", "LastUpdatedTime", "RefreshTokenCreateTime" },
                values: new object[] { "6fe29b9f-1201-4f3e-bf36-8bbf7772c12c", new DateTime(2024, 8, 30, 7, 21, 47, 408, DateTimeKind.Utc).AddTicks(1090), new DateTime(2024, 8, 30, 7, 21, 47, 408, DateTimeKind.Utc).AddTicks(1091), new DateTime(2024, 8, 30, 7, 21, 47, 408, DateTimeKind.Utc).AddTicks(1087) });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: 2054,
                columns: new[] { "ConcurrencyStamp", "CreatedTime", "LastUpdatedTime", "RefreshTokenCreateTime" },
                values: new object[] { "5a5787be-929a-4e05-9e7c-a67fb5cc9491", new DateTime(2024, 8, 30, 7, 21, 47, 408, DateTimeKind.Utc).AddTicks(1125), new DateTime(2024, 8, 30, 7, 21, 47, 408, DateTimeKind.Utc).AddTicks(1126), new DateTime(2024, 8, 30, 7, 21, 47, 408, DateTimeKind.Utc).AddTicks(1122) });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: 2055,
                columns: new[] { "ConcurrencyStamp", "CreatedTime", "LastUpdatedTime", "RefreshTokenCreateTime" },
                values: new object[] { "438d1b66-d536-4967-bebe-6cb624eab059", new DateTime(2024, 8, 30, 7, 21, 47, 408, DateTimeKind.Utc).AddTicks(1139), new DateTime(2024, 8, 30, 7, 21, 47, 408, DateTimeKind.Utc).AddTicks(1139), new DateTime(2024, 8, 30, 7, 21, 47, 408, DateTimeKind.Utc).AddTicks(1135) });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: 2056,
                columns: new[] { "ConcurrencyStamp", "CreatedTime", "LastUpdatedTime", "RefreshTokenCreateTime" },
                values: new object[] { "d0f1a7b3-a0f8-4c34-9d5a-6083575664c4", new DateTime(2024, 8, 30, 7, 21, 47, 408, DateTimeKind.Utc).AddTicks(1155), new DateTime(2024, 8, 30, 7, 21, 47, 408, DateTimeKind.Utc).AddTicks(1155), new DateTime(2024, 8, 30, 7, 21, 47, 408, DateTimeKind.Utc).AddTicks(1148) });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: 2057,
                columns: new[] { "ConcurrencyStamp", "CreatedTime", "LastUpdatedTime", "RefreshTokenCreateTime" },
                values: new object[] { "b689845e-099f-4d04-92b9-f81aebd6172f", new DateTime(2024, 8, 30, 7, 21, 47, 408, DateTimeKind.Utc).AddTicks(1167), new DateTime(2024, 8, 30, 7, 21, 47, 408, DateTimeKind.Utc).AddTicks(1167), new DateTime(2024, 8, 30, 7, 21, 47, 408, DateTimeKind.Utc).AddTicks(1164) });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: 2058,
                columns: new[] { "ConcurrencyStamp", "CreatedTime", "LastUpdatedTime", "RefreshTokenCreateTime" },
                values: new object[] { "9b39045b-172e-4429-a6dd-12602e816ddd", new DateTime(2024, 8, 30, 7, 21, 47, 408, DateTimeKind.Utc).AddTicks(1179), new DateTime(2024, 8, 30, 7, 21, 47, 408, DateTimeKind.Utc).AddTicks(1180), new DateTime(2024, 8, 30, 7, 21, 47, 408, DateTimeKind.Utc).AddTicks(1176) });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: 2059,
                columns: new[] { "ConcurrencyStamp", "CreatedTime", "LastUpdatedTime", "RefreshTokenCreateTime" },
                values: new object[] { "a1c8f7a9-9087-4f6b-a602-8ff5dcb88210", new DateTime(2024, 8, 30, 7, 21, 47, 408, DateTimeKind.Utc).AddTicks(1192), new DateTime(2024, 8, 30, 7, 21, 47, 408, DateTimeKind.Utc).AddTicks(1192), new DateTime(2024, 8, 30, 7, 21, 47, 408, DateTimeKind.Utc).AddTicks(1189) });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: 2060,
                columns: new[] { "ConcurrencyStamp", "CreatedTime", "LastUpdatedTime", "RefreshTokenCreateTime" },
                values: new object[] { "b76ff0a2-e19f-4421-8b8b-dac0c7aa727e", new DateTime(2024, 8, 30, 7, 21, 47, 408, DateTimeKind.Utc).AddTicks(1204), new DateTime(2024, 8, 30, 7, 21, 47, 408, DateTimeKind.Utc).AddTicks(1205), new DateTime(2024, 8, 30, 7, 21, 47, 408, DateTimeKind.Utc).AddTicks(1202) });

            migrationBuilder.UpdateData(
                table: "Breeds",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedTime",
                value: new DateTime(2024, 8, 30, 11, 21, 47, 399, DateTimeKind.Local).AddTicks(5250));

            migrationBuilder.UpdateData(
                table: "Breeds",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreatedTime",
                value: new DateTime(2024, 8, 30, 11, 21, 47, 399, DateTimeKind.Local).AddTicks(5257));

            migrationBuilder.UpdateData(
                table: "Breeds",
                keyColumn: "Id",
                keyValue: 3,
                column: "CreatedTime",
                value: new DateTime(2024, 8, 30, 11, 21, 47, 399, DateTimeKind.Local).AddTicks(5258));

            migrationBuilder.UpdateData(
                table: "Breeds",
                keyColumn: "Id",
                keyValue: 4,
                column: "CreatedTime",
                value: new DateTime(2024, 8, 30, 11, 21, 47, 399, DateTimeKind.Local).AddTicks(5260));

            migrationBuilder.UpdateData(
                table: "Breeds",
                keyColumn: "Id",
                keyValue: 5,
                column: "CreatedTime",
                value: new DateTime(2024, 8, 30, 11, 21, 47, 399, DateTimeKind.Local).AddTicks(5262));

            migrationBuilder.UpdateData(
                table: "Breeds",
                keyColumn: "Id",
                keyValue: 6,
                column: "CreatedTime",
                value: new DateTime(2024, 8, 30, 11, 21, 47, 399, DateTimeKind.Local).AddTicks(5263));

            migrationBuilder.UpdateData(
                table: "Breeds",
                keyColumn: "Id",
                keyValue: 7,
                column: "CreatedTime",
                value: new DateTime(2024, 8, 30, 11, 21, 47, 399, DateTimeKind.Local).AddTicks(5265));

            migrationBuilder.UpdateData(
                table: "Breeds",
                keyColumn: "Id",
                keyValue: 8,
                column: "CreatedTime",
                value: new DateTime(2024, 8, 30, 11, 21, 47, 399, DateTimeKind.Local).AddTicks(5266));

            migrationBuilder.UpdateData(
                table: "Breeds",
                keyColumn: "Id",
                keyValue: 9,
                column: "CreatedTime",
                value: new DateTime(2024, 8, 30, 11, 21, 47, 399, DateTimeKind.Local).AddTicks(5267));

            migrationBuilder.UpdateData(
                table: "Breeds",
                keyColumn: "Id",
                keyValue: 10,
                column: "CreatedTime",
                value: new DateTime(2024, 8, 30, 11, 21, 47, 399, DateTimeKind.Local).AddTicks(5269));

            migrationBuilder.UpdateData(
                table: "Breeds",
                keyColumn: "Id",
                keyValue: 11,
                column: "CreatedTime",
                value: new DateTime(2024, 8, 30, 11, 21, 47, 399, DateTimeKind.Local).AddTicks(5270));

            migrationBuilder.UpdateData(
                table: "Breeds",
                keyColumn: "Id",
                keyValue: 12,
                column: "CreatedTime",
                value: new DateTime(2024, 8, 30, 11, 21, 47, 399, DateTimeKind.Local).AddTicks(5272));

            migrationBuilder.UpdateData(
                table: "Breeds",
                keyColumn: "Id",
                keyValue: 13,
                column: "CreatedTime",
                value: new DateTime(2024, 8, 30, 11, 21, 47, 399, DateTimeKind.Local).AddTicks(5273));

            migrationBuilder.UpdateData(
                table: "Breeds",
                keyColumn: "Id",
                keyValue: 14,
                column: "CreatedTime",
                value: new DateTime(2024, 8, 30, 11, 21, 47, 399, DateTimeKind.Local).AddTicks(5274));

            migrationBuilder.UpdateData(
                table: "Breeds",
                keyColumn: "Id",
                keyValue: 15,
                column: "CreatedTime",
                value: new DateTime(2024, 8, 30, 11, 21, 47, 399, DateTimeKind.Local).AddTicks(5276));

            migrationBuilder.UpdateData(
                table: "Breeds",
                keyColumn: "Id",
                keyValue: 16,
                column: "CreatedTime",
                value: new DateTime(2024, 8, 30, 11, 21, 47, 399, DateTimeKind.Local).AddTicks(5278));

            migrationBuilder.UpdateData(
                table: "Breeds",
                keyColumn: "Id",
                keyValue: 17,
                column: "CreatedTime",
                value: new DateTime(2024, 8, 30, 11, 21, 47, 399, DateTimeKind.Local).AddTicks(5279));

            migrationBuilder.UpdateData(
                table: "Breeds",
                keyColumn: "Id",
                keyValue: 18,
                column: "CreatedTime",
                value: new DateTime(2024, 8, 30, 11, 21, 47, 399, DateTimeKind.Local).AddTicks(5281));

            migrationBuilder.UpdateData(
                table: "Breeds",
                keyColumn: "Id",
                keyValue: 19,
                column: "CreatedTime",
                value: new DateTime(2024, 8, 30, 11, 21, 47, 399, DateTimeKind.Local).AddTicks(5282));

            migrationBuilder.UpdateData(
                table: "Breeds",
                keyColumn: "Id",
                keyValue: 20,
                column: "CreatedTime",
                value: new DateTime(2024, 8, 30, 11, 21, 47, 399, DateTimeKind.Local).AddTicks(5283));

            migrationBuilder.UpdateData(
                table: "Breeds",
                keyColumn: "Id",
                keyValue: 21,
                column: "CreatedTime",
                value: new DateTime(2024, 8, 30, 11, 21, 47, 399, DateTimeKind.Local).AddTicks(5285));

            migrationBuilder.UpdateData(
                table: "Breeds",
                keyColumn: "Id",
                keyValue: 22,
                column: "CreatedTime",
                value: new DateTime(2024, 8, 30, 11, 21, 47, 399, DateTimeKind.Local).AddTicks(5286));

            migrationBuilder.UpdateData(
                table: "Breeds",
                keyColumn: "Id",
                keyValue: 23,
                column: "CreatedTime",
                value: new DateTime(2024, 8, 30, 11, 21, 47, 399, DateTimeKind.Local).AddTicks(5287));

            migrationBuilder.UpdateData(
                table: "Breeds",
                keyColumn: "Id",
                keyValue: 24,
                column: "CreatedTime",
                value: new DateTime(2024, 8, 30, 11, 21, 47, 399, DateTimeKind.Local).AddTicks(5289));

            migrationBuilder.UpdateData(
                table: "Breeds",
                keyColumn: "Id",
                keyValue: 25,
                column: "CreatedTime",
                value: new DateTime(2024, 8, 30, 11, 21, 47, 399, DateTimeKind.Local).AddTicks(5290));

            migrationBuilder.UpdateData(
                table: "Breeds",
                keyColumn: "Id",
                keyValue: 26,
                column: "CreatedTime",
                value: new DateTime(2024, 8, 30, 11, 21, 47, 399, DateTimeKind.Local).AddTicks(5291));

            migrationBuilder.UpdateData(
                table: "Breeds",
                keyColumn: "Id",
                keyValue: 27,
                column: "CreatedTime",
                value: new DateTime(2024, 8, 30, 11, 21, 47, 399, DateTimeKind.Local).AddTicks(5293));

            migrationBuilder.UpdateData(
                table: "Breeds",
                keyColumn: "Id",
                keyValue: 28,
                column: "CreatedTime",
                value: new DateTime(2024, 8, 30, 11, 21, 47, 399, DateTimeKind.Local).AddTicks(5294));

            migrationBuilder.UpdateData(
                table: "Breeds",
                keyColumn: "Id",
                keyValue: 29,
                column: "CreatedTime",
                value: new DateTime(2024, 8, 30, 11, 21, 47, 399, DateTimeKind.Local).AddTicks(5296));

            migrationBuilder.UpdateData(
                table: "Breeds",
                keyColumn: "Id",
                keyValue: 30,
                column: "CreatedTime",
                value: new DateTime(2024, 8, 30, 11, 21, 47, 399, DateTimeKind.Local).AddTicks(5297));

            migrationBuilder.UpdateData(
                table: "Breeds",
                keyColumn: "Id",
                keyValue: 31,
                column: "CreatedTime",
                value: new DateTime(2024, 8, 30, 11, 21, 47, 399, DateTimeKind.Local).AddTicks(5298));

            migrationBuilder.UpdateData(
                table: "Breeds",
                keyColumn: "Id",
                keyValue: 32,
                column: "CreatedTime",
                value: new DateTime(2024, 8, 30, 11, 21, 47, 399, DateTimeKind.Local).AddTicks(5299));

            migrationBuilder.UpdateData(
                table: "Breeds",
                keyColumn: "Id",
                keyValue: 33,
                column: "CreatedTime",
                value: new DateTime(2024, 8, 30, 11, 21, 47, 399, DateTimeKind.Local).AddTicks(5300));

            migrationBuilder.UpdateData(
                table: "Breeds",
                keyColumn: "Id",
                keyValue: 34,
                column: "CreatedTime",
                value: new DateTime(2024, 8, 30, 11, 21, 47, 399, DateTimeKind.Local).AddTicks(5302));

            migrationBuilder.UpdateData(
                table: "Breeds",
                keyColumn: "Id",
                keyValue: 35,
                column: "CreatedTime",
                value: new DateTime(2024, 8, 30, 11, 21, 47, 399, DateTimeKind.Local).AddTicks(5303));

            migrationBuilder.UpdateData(
                table: "Breeds",
                keyColumn: "Id",
                keyValue: 36,
                column: "CreatedTime",
                value: new DateTime(2024, 8, 30, 11, 21, 47, 399, DateTimeKind.Local).AddTicks(5304));

            migrationBuilder.UpdateData(
                table: "Breeds",
                keyColumn: "Id",
                keyValue: 37,
                column: "CreatedTime",
                value: new DateTime(2024, 8, 30, 11, 21, 47, 399, DateTimeKind.Local).AddTicks(5306));

            migrationBuilder.UpdateData(
                table: "Breeds",
                keyColumn: "Id",
                keyValue: 38,
                column: "CreatedTime",
                value: new DateTime(2024, 8, 30, 11, 21, 47, 399, DateTimeKind.Local).AddTicks(5307));

            migrationBuilder.UpdateData(
                table: "Breeds",
                keyColumn: "Id",
                keyValue: 39,
                column: "CreatedTime",
                value: new DateTime(2024, 8, 30, 11, 21, 47, 399, DateTimeKind.Local).AddTicks(5308));

            migrationBuilder.UpdateData(
                table: "Breeds",
                keyColumn: "Id",
                keyValue: 40,
                column: "CreatedTime",
                value: new DateTime(2024, 8, 30, 11, 21, 47, 399, DateTimeKind.Local).AddTicks(5310));

            migrationBuilder.UpdateData(
                table: "Breeds",
                keyColumn: "Id",
                keyValue: 41,
                column: "CreatedTime",
                value: new DateTime(2024, 8, 30, 11, 21, 47, 399, DateTimeKind.Local).AddTicks(5311));

            migrationBuilder.UpdateData(
                table: "Breeds",
                keyColumn: "Id",
                keyValue: 42,
                column: "CreatedTime",
                value: new DateTime(2024, 8, 30, 11, 21, 47, 399, DateTimeKind.Local).AddTicks(5312));

            migrationBuilder.UpdateData(
                table: "Breeds",
                keyColumn: "Id",
                keyValue: 43,
                column: "CreatedTime",
                value: new DateTime(2024, 8, 30, 11, 21, 47, 399, DateTimeKind.Local).AddTicks(5313));

            migrationBuilder.UpdateData(
                table: "Breeds",
                keyColumn: "Id",
                keyValue: 44,
                column: "CreatedTime",
                value: new DateTime(2024, 8, 30, 11, 21, 47, 399, DateTimeKind.Local).AddTicks(5315));

            migrationBuilder.UpdateData(
                table: "Breeds",
                keyColumn: "Id",
                keyValue: 45,
                column: "CreatedTime",
                value: new DateTime(2024, 8, 30, 11, 21, 47, 399, DateTimeKind.Local).AddTicks(5317));

            migrationBuilder.UpdateData(
                table: "Breeds",
                keyColumn: "Id",
                keyValue: 46,
                column: "CreatedTime",
                value: new DateTime(2024, 8, 30, 11, 21, 47, 399, DateTimeKind.Local).AddTicks(5318));

            migrationBuilder.UpdateData(
                table: "Breeds",
                keyColumn: "Id",
                keyValue: 47,
                column: "CreatedTime",
                value: new DateTime(2024, 8, 30, 11, 21, 47, 399, DateTimeKind.Local).AddTicks(5319));

            migrationBuilder.UpdateData(
                table: "Breeds",
                keyColumn: "Id",
                keyValue: 48,
                column: "CreatedTime",
                value: new DateTime(2024, 8, 30, 11, 21, 47, 399, DateTimeKind.Local).AddTicks(5321));

            migrationBuilder.UpdateData(
                table: "Breeds",
                keyColumn: "Id",
                keyValue: 49,
                column: "CreatedTime",
                value: new DateTime(2024, 8, 30, 11, 21, 47, 399, DateTimeKind.Local).AddTicks(5322));

            migrationBuilder.UpdateData(
                table: "Breeds",
                keyColumn: "Id",
                keyValue: 50,
                column: "CreatedTime",
                value: new DateTime(2024, 8, 30, 11, 21, 47, 399, DateTimeKind.Local).AddTicks(5323));

            migrationBuilder.UpdateData(
                table: "Breeds",
                keyColumn: "Id",
                keyValue: 51,
                column: "CreatedTime",
                value: new DateTime(2024, 8, 30, 11, 21, 47, 399, DateTimeKind.Local).AddTicks(5324));

            migrationBuilder.UpdateData(
                table: "Breeds",
                keyColumn: "Id",
                keyValue: 52,
                column: "CreatedTime",
                value: new DateTime(2024, 8, 30, 11, 21, 47, 399, DateTimeKind.Local).AddTicks(5325));

            migrationBuilder.UpdateData(
                table: "Breeds",
                keyColumn: "Id",
                keyValue: 53,
                column: "CreatedTime",
                value: new DateTime(2024, 8, 30, 11, 21, 47, 399, DateTimeKind.Local).AddTicks(5327));

            migrationBuilder.UpdateData(
                table: "Breeds",
                keyColumn: "Id",
                keyValue: 54,
                column: "CreatedTime",
                value: new DateTime(2024, 8, 30, 11, 21, 47, 399, DateTimeKind.Local).AddTicks(5328));

            migrationBuilder.UpdateData(
                table: "Breeds",
                keyColumn: "Id",
                keyValue: 55,
                column: "CreatedTime",
                value: new DateTime(2024, 8, 30, 11, 21, 47, 399, DateTimeKind.Local).AddTicks(5329));

            migrationBuilder.UpdateData(
                table: "Breeds",
                keyColumn: "Id",
                keyValue: 56,
                column: "CreatedTime",
                value: new DateTime(2024, 8, 30, 11, 21, 47, 399, DateTimeKind.Local).AddTicks(5330));

            migrationBuilder.UpdateData(
                table: "Breeds",
                keyColumn: "Id",
                keyValue: 57,
                column: "CreatedTime",
                value: new DateTime(2024, 8, 30, 11, 21, 47, 399, DateTimeKind.Local).AddTicks(5332));

            migrationBuilder.UpdateData(
                table: "Breeds",
                keyColumn: "Id",
                keyValue: 58,
                column: "CreatedTime",
                value: new DateTime(2024, 8, 30, 11, 21, 47, 399, DateTimeKind.Local).AddTicks(5333));

            migrationBuilder.UpdateData(
                table: "Breeds",
                keyColumn: "Id",
                keyValue: 59,
                column: "CreatedTime",
                value: new DateTime(2024, 8, 30, 11, 21, 47, 399, DateTimeKind.Local).AddTicks(5334));

            migrationBuilder.UpdateData(
                table: "Breeds",
                keyColumn: "Id",
                keyValue: 60,
                column: "CreatedTime",
                value: new DateTime(2024, 8, 30, 11, 21, 47, 399, DateTimeKind.Local).AddTicks(5335));

            migrationBuilder.UpdateData(
                table: "Breeds",
                keyColumn: "Id",
                keyValue: 61,
                column: "CreatedTime",
                value: new DateTime(2024, 8, 30, 11, 21, 47, 399, DateTimeKind.Local).AddTicks(5337));

            migrationBuilder.UpdateData(
                table: "Breeds",
                keyColumn: "Id",
                keyValue: 62,
                column: "CreatedTime",
                value: new DateTime(2024, 8, 30, 11, 21, 47, 399, DateTimeKind.Local).AddTicks(5338));

            migrationBuilder.UpdateData(
                table: "Breeds",
                keyColumn: "Id",
                keyValue: 63,
                column: "CreatedTime",
                value: new DateTime(2024, 8, 30, 11, 21, 47, 399, DateTimeKind.Local).AddTicks(5339));

            migrationBuilder.UpdateData(
                table: "Breeds",
                keyColumn: "Id",
                keyValue: 64,
                column: "CreatedTime",
                value: new DateTime(2024, 8, 30, 11, 21, 47, 399, DateTimeKind.Local).AddTicks(5340));

            migrationBuilder.UpdateData(
                table: "Breeds",
                keyColumn: "Id",
                keyValue: 65,
                column: "CreatedTime",
                value: new DateTime(2024, 8, 30, 11, 21, 47, 399, DateTimeKind.Local).AddTicks(5342));

            migrationBuilder.UpdateData(
                table: "Breeds",
                keyColumn: "Id",
                keyValue: 66,
                column: "CreatedTime",
                value: new DateTime(2024, 8, 30, 11, 21, 47, 399, DateTimeKind.Local).AddTicks(5343));

            migrationBuilder.UpdateData(
                table: "Breeds",
                keyColumn: "Id",
                keyValue: 67,
                column: "CreatedTime",
                value: new DateTime(2024, 8, 30, 11, 21, 47, 399, DateTimeKind.Local).AddTicks(5344));

            migrationBuilder.UpdateData(
                table: "Breeds",
                keyColumn: "Id",
                keyValue: 68,
                column: "CreatedTime",
                value: new DateTime(2024, 8, 30, 11, 21, 47, 399, DateTimeKind.Local).AddTicks(5345));

            migrationBuilder.UpdateData(
                table: "Breeds",
                keyColumn: "Id",
                keyValue: 69,
                column: "CreatedTime",
                value: new DateTime(2024, 8, 30, 11, 21, 47, 399, DateTimeKind.Local).AddTicks(5347));

            migrationBuilder.UpdateData(
                table: "Breeds",
                keyColumn: "Id",
                keyValue: 70,
                column: "CreatedTime",
                value: new DateTime(2024, 8, 30, 11, 21, 47, 399, DateTimeKind.Local).AddTicks(5348));

            migrationBuilder.UpdateData(
                table: "Breeds",
                keyColumn: "Id",
                keyValue: 71,
                column: "CreatedTime",
                value: new DateTime(2024, 8, 30, 11, 21, 47, 399, DateTimeKind.Local).AddTicks(5349));

            migrationBuilder.UpdateData(
                table: "Breeds",
                keyColumn: "Id",
                keyValue: 72,
                column: "CreatedTime",
                value: new DateTime(2024, 8, 30, 11, 21, 47, 399, DateTimeKind.Local).AddTicks(5350));

            migrationBuilder.UpdateData(
                table: "Breeds",
                keyColumn: "Id",
                keyValue: 73,
                column: "CreatedTime",
                value: new DateTime(2024, 8, 30, 11, 21, 47, 399, DateTimeKind.Local).AddTicks(5353));

            migrationBuilder.UpdateData(
                table: "Breeds",
                keyColumn: "Id",
                keyValue: 74,
                column: "CreatedTime",
                value: new DateTime(2024, 8, 30, 11, 21, 47, 399, DateTimeKind.Local).AddTicks(5354));

            migrationBuilder.UpdateData(
                table: "Breeds",
                keyColumn: "Id",
                keyValue: 75,
                column: "CreatedTime",
                value: new DateTime(2024, 8, 30, 11, 21, 47, 399, DateTimeKind.Local).AddTicks(5355));

            migrationBuilder.UpdateData(
                table: "Breeds",
                keyColumn: "Id",
                keyValue: 76,
                column: "CreatedTime",
                value: new DateTime(2024, 8, 30, 11, 21, 47, 399, DateTimeKind.Local).AddTicks(5356));

            migrationBuilder.UpdateData(
                table: "Breeds",
                keyColumn: "Id",
                keyValue: 77,
                column: "CreatedTime",
                value: new DateTime(2024, 8, 30, 11, 21, 47, 399, DateTimeKind.Local).AddTicks(5358));

            migrationBuilder.UpdateData(
                table: "Breeds",
                keyColumn: "Id",
                keyValue: 78,
                column: "CreatedTime",
                value: new DateTime(2024, 8, 30, 11, 21, 47, 399, DateTimeKind.Local).AddTicks(5359));

            migrationBuilder.UpdateData(
                table: "Breeds",
                keyColumn: "Id",
                keyValue: 79,
                column: "CreatedTime",
                value: new DateTime(2024, 8, 30, 11, 21, 47, 399, DateTimeKind.Local).AddTicks(5360));

            migrationBuilder.UpdateData(
                table: "Breeds",
                keyColumn: "Id",
                keyValue: 80,
                column: "CreatedTime",
                value: new DateTime(2024, 8, 30, 11, 21, 47, 399, DateTimeKind.Local).AddTicks(5361));

            migrationBuilder.UpdateData(
                table: "Breeds",
                keyColumn: "Id",
                keyValue: 81,
                column: "CreatedTime",
                value: new DateTime(2024, 8, 30, 11, 21, 47, 399, DateTimeKind.Local).AddTicks(5362));

            migrationBuilder.UpdateData(
                table: "Breeds",
                keyColumn: "Id",
                keyValue: 82,
                column: "CreatedTime",
                value: new DateTime(2024, 8, 30, 11, 21, 47, 399, DateTimeKind.Local).AddTicks(5364));

            migrationBuilder.UpdateData(
                table: "Breeds",
                keyColumn: "Id",
                keyValue: 83,
                column: "CreatedTime",
                value: new DateTime(2024, 8, 30, 11, 21, 47, 399, DateTimeKind.Local).AddTicks(5365));

            migrationBuilder.UpdateData(
                table: "Breeds",
                keyColumn: "Id",
                keyValue: 84,
                column: "CreatedTime",
                value: new DateTime(2024, 8, 30, 11, 21, 47, 399, DateTimeKind.Local).AddTicks(5366));

            migrationBuilder.UpdateData(
                table: "Breeds",
                keyColumn: "Id",
                keyValue: 85,
                column: "CreatedTime",
                value: new DateTime(2024, 8, 30, 11, 21, 47, 399, DateTimeKind.Local).AddTicks(5367));

            migrationBuilder.UpdateData(
                table: "Breeds",
                keyColumn: "Id",
                keyValue: 86,
                column: "CreatedTime",
                value: new DateTime(2024, 8, 30, 11, 21, 47, 399, DateTimeKind.Local).AddTicks(5368));

            migrationBuilder.UpdateData(
                table: "Breeds",
                keyColumn: "Id",
                keyValue: 87,
                column: "CreatedTime",
                value: new DateTime(2024, 8, 30, 11, 21, 47, 399, DateTimeKind.Local).AddTicks(5370));

            migrationBuilder.UpdateData(
                table: "Breeds",
                keyColumn: "Id",
                keyValue: 88,
                column: "CreatedTime",
                value: new DateTime(2024, 8, 30, 11, 21, 47, 399, DateTimeKind.Local).AddTicks(5371));

            migrationBuilder.UpdateData(
                table: "Breeds",
                keyColumn: "Id",
                keyValue: 89,
                column: "CreatedTime",
                value: new DateTime(2024, 8, 30, 11, 21, 47, 399, DateTimeKind.Local).AddTicks(5448));

            migrationBuilder.UpdateData(
                table: "Breeds",
                keyColumn: "Id",
                keyValue: 90,
                column: "CreatedTime",
                value: new DateTime(2024, 8, 30, 11, 21, 47, 399, DateTimeKind.Local).AddTicks(5450));

            migrationBuilder.UpdateData(
                table: "Breeds",
                keyColumn: "Id",
                keyValue: 91,
                column: "CreatedTime",
                value: new DateTime(2024, 8, 30, 11, 21, 47, 399, DateTimeKind.Local).AddTicks(5451));

            migrationBuilder.UpdateData(
                table: "Breeds",
                keyColumn: "Id",
                keyValue: 92,
                column: "CreatedTime",
                value: new DateTime(2024, 8, 30, 11, 21, 47, 399, DateTimeKind.Local).AddTicks(5452));

            migrationBuilder.UpdateData(
                table: "Breeds",
                keyColumn: "Id",
                keyValue: 93,
                column: "CreatedTime",
                value: new DateTime(2024, 8, 30, 11, 21, 47, 399, DateTimeKind.Local).AddTicks(5454));

            migrationBuilder.UpdateData(
                table: "Breeds",
                keyColumn: "Id",
                keyValue: 94,
                column: "CreatedTime",
                value: new DateTime(2024, 8, 30, 11, 21, 47, 399, DateTimeKind.Local).AddTicks(5455));

            migrationBuilder.UpdateData(
                table: "Breeds",
                keyColumn: "Id",
                keyValue: 95,
                column: "CreatedTime",
                value: new DateTime(2024, 8, 30, 11, 21, 47, 399, DateTimeKind.Local).AddTicks(5456));

            migrationBuilder.UpdateData(
                table: "Breeds",
                keyColumn: "Id",
                keyValue: 96,
                column: "CreatedTime",
                value: new DateTime(2024, 8, 30, 11, 21, 47, 399, DateTimeKind.Local).AddTicks(5458));

            migrationBuilder.UpdateData(
                table: "Breeds",
                keyColumn: "Id",
                keyValue: 97,
                column: "CreatedTime",
                value: new DateTime(2024, 8, 30, 11, 21, 47, 399, DateTimeKind.Local).AddTicks(5460));

            migrationBuilder.UpdateData(
                table: "Breeds",
                keyColumn: "Id",
                keyValue: 98,
                column: "CreatedTime",
                value: new DateTime(2024, 8, 30, 11, 21, 47, 399, DateTimeKind.Local).AddTicks(5461));

            migrationBuilder.UpdateData(
                table: "Breeds",
                keyColumn: "Id",
                keyValue: 99,
                column: "CreatedTime",
                value: new DateTime(2024, 8, 30, 11, 21, 47, 399, DateTimeKind.Local).AddTicks(5462));

            migrationBuilder.UpdateData(
                table: "Breeds",
                keyColumn: "Id",
                keyValue: 100,
                column: "CreatedTime",
                value: new DateTime(2024, 8, 30, 11, 21, 47, 399, DateTimeKind.Local).AddTicks(5464));

            migrationBuilder.UpdateData(
                table: "Breeds",
                keyColumn: "Id",
                keyValue: 101,
                column: "CreatedTime",
                value: new DateTime(2024, 8, 30, 11, 21, 47, 399, DateTimeKind.Local).AddTicks(5465));

            migrationBuilder.UpdateData(
                table: "Breeds",
                keyColumn: "Id",
                keyValue: 102,
                column: "CreatedTime",
                value: new DateTime(2024, 8, 30, 11, 21, 47, 399, DateTimeKind.Local).AddTicks(5467));

            migrationBuilder.UpdateData(
                table: "Breeds",
                keyColumn: "Id",
                keyValue: 103,
                column: "CreatedTime",
                value: new DateTime(2024, 8, 30, 11, 21, 47, 399, DateTimeKind.Local).AddTicks(5468));

            migrationBuilder.UpdateData(
                table: "Breeds",
                keyColumn: "Id",
                keyValue: 104,
                column: "CreatedTime",
                value: new DateTime(2024, 8, 30, 11, 21, 47, 399, DateTimeKind.Local).AddTicks(5470));

            migrationBuilder.UpdateData(
                table: "Breeds",
                keyColumn: "Id",
                keyValue: 105,
                column: "CreatedTime",
                value: new DateTime(2024, 8, 30, 11, 21, 47, 399, DateTimeKind.Local).AddTicks(5471));

            migrationBuilder.UpdateData(
                table: "Breeds",
                keyColumn: "Id",
                keyValue: 106,
                column: "CreatedTime",
                value: new DateTime(2024, 8, 30, 11, 21, 47, 399, DateTimeKind.Local).AddTicks(5472));

            migrationBuilder.UpdateData(
                table: "Breeds",
                keyColumn: "Id",
                keyValue: 107,
                column: "CreatedTime",
                value: new DateTime(2024, 8, 30, 11, 21, 47, 399, DateTimeKind.Local).AddTicks(5474));

            migrationBuilder.UpdateData(
                table: "Breeds",
                keyColumn: "Id",
                keyValue: 108,
                column: "CreatedTime",
                value: new DateTime(2024, 8, 30, 11, 21, 47, 399, DateTimeKind.Local).AddTicks(5475));

            migrationBuilder.UpdateData(
                table: "Breeds",
                keyColumn: "Id",
                keyValue: 109,
                column: "CreatedTime",
                value: new DateTime(2024, 8, 30, 11, 21, 47, 399, DateTimeKind.Local).AddTicks(5476));

            migrationBuilder.UpdateData(
                table: "Breeds",
                keyColumn: "Id",
                keyValue: 110,
                column: "CreatedTime",
                value: new DateTime(2024, 8, 30, 11, 21, 47, 399, DateTimeKind.Local).AddTicks(5477));

            migrationBuilder.UpdateData(
                table: "Breeds",
                keyColumn: "Id",
                keyValue: 111,
                column: "CreatedTime",
                value: new DateTime(2024, 8, 30, 11, 21, 47, 399, DateTimeKind.Local).AddTicks(5479));

            migrationBuilder.UpdateData(
                table: "Breeds",
                keyColumn: "Id",
                keyValue: 112,
                column: "CreatedTime",
                value: new DateTime(2024, 8, 30, 11, 21, 47, 399, DateTimeKind.Local).AddTicks(5480));

            migrationBuilder.UpdateData(
                table: "Breeds",
                keyColumn: "Id",
                keyValue: 113,
                column: "CreatedTime",
                value: new DateTime(2024, 8, 30, 11, 21, 47, 399, DateTimeKind.Local).AddTicks(5481));

            migrationBuilder.UpdateData(
                table: "Breeds",
                keyColumn: "Id",
                keyValue: 114,
                column: "CreatedTime",
                value: new DateTime(2024, 8, 30, 11, 21, 47, 399, DateTimeKind.Local).AddTicks(5483));

            migrationBuilder.UpdateData(
                table: "Breeds",
                keyColumn: "Id",
                keyValue: 115,
                column: "CreatedTime",
                value: new DateTime(2024, 8, 30, 11, 21, 47, 399, DateTimeKind.Local).AddTicks(5484));

            migrationBuilder.UpdateData(
                table: "Breeds",
                keyColumn: "Id",
                keyValue: 116,
                column: "CreatedTime",
                value: new DateTime(2024, 8, 30, 11, 21, 47, 399, DateTimeKind.Local).AddTicks(5485));

            migrationBuilder.UpdateData(
                table: "Breeds",
                keyColumn: "Id",
                keyValue: 117,
                column: "CreatedTime",
                value: new DateTime(2024, 8, 30, 11, 21, 47, 399, DateTimeKind.Local).AddTicks(5486));

            migrationBuilder.UpdateData(
                table: "Breeds",
                keyColumn: "Id",
                keyValue: 118,
                column: "CreatedTime",
                value: new DateTime(2024, 8, 30, 11, 21, 47, 399, DateTimeKind.Local).AddTicks(5488));

            migrationBuilder.UpdateData(
                table: "Breeds",
                keyColumn: "Id",
                keyValue: 119,
                column: "CreatedTime",
                value: new DateTime(2024, 8, 30, 11, 21, 47, 399, DateTimeKind.Local).AddTicks(5489));

            migrationBuilder.UpdateData(
                table: "Breeds",
                keyColumn: "Id",
                keyValue: 120,
                column: "CreatedTime",
                value: new DateTime(2024, 8, 30, 11, 21, 47, 399, DateTimeKind.Local).AddTicks(5490));

            migrationBuilder.UpdateData(
                table: "Breeds",
                keyColumn: "Id",
                keyValue: 121,
                column: "CreatedTime",
                value: new DateTime(2024, 8, 30, 11, 21, 47, 399, DateTimeKind.Local).AddTicks(5492));

            migrationBuilder.UpdateData(
                table: "Breeds",
                keyColumn: "Id",
                keyValue: 122,
                column: "CreatedTime",
                value: new DateTime(2024, 8, 30, 11, 21, 47, 399, DateTimeKind.Local).AddTicks(5493));

            migrationBuilder.UpdateData(
                table: "Breeds",
                keyColumn: "Id",
                keyValue: 123,
                column: "CreatedTime",
                value: new DateTime(2024, 8, 30, 11, 21, 47, 399, DateTimeKind.Local).AddTicks(5494));

            migrationBuilder.UpdateData(
                table: "Breeds",
                keyColumn: "Id",
                keyValue: 124,
                column: "CreatedTime",
                value: new DateTime(2024, 8, 30, 11, 21, 47, 399, DateTimeKind.Local).AddTicks(5495));

            migrationBuilder.UpdateData(
                table: "Breeds",
                keyColumn: "Id",
                keyValue: 125,
                column: "CreatedTime",
                value: new DateTime(2024, 8, 30, 11, 21, 47, 399, DateTimeKind.Local).AddTicks(5497));

            migrationBuilder.UpdateData(
                table: "Breeds",
                keyColumn: "Id",
                keyValue: 126,
                column: "CreatedTime",
                value: new DateTime(2024, 8, 30, 11, 21, 47, 399, DateTimeKind.Local).AddTicks(5498));

            migrationBuilder.UpdateData(
                table: "Breeds",
                keyColumn: "Id",
                keyValue: 127,
                column: "CreatedTime",
                value: new DateTime(2024, 8, 30, 11, 21, 47, 399, DateTimeKind.Local).AddTicks(5499));

            migrationBuilder.UpdateData(
                table: "Breeds",
                keyColumn: "Id",
                keyValue: 128,
                column: "CreatedTime",
                value: new DateTime(2024, 8, 30, 11, 21, 47, 399, DateTimeKind.Local).AddTicks(5500));

            migrationBuilder.UpdateData(
                table: "Breeds",
                keyColumn: "Id",
                keyValue: 129,
                column: "CreatedTime",
                value: new DateTime(2024, 8, 30, 11, 21, 47, 399, DateTimeKind.Local).AddTicks(5502));

            migrationBuilder.UpdateData(
                table: "Breeds",
                keyColumn: "Id",
                keyValue: 130,
                column: "CreatedTime",
                value: new DateTime(2024, 8, 30, 11, 21, 47, 399, DateTimeKind.Local).AddTicks(5503));

            migrationBuilder.UpdateData(
                table: "Breeds",
                keyColumn: "Id",
                keyValue: 131,
                column: "CreatedTime",
                value: new DateTime(2024, 8, 30, 11, 21, 47, 399, DateTimeKind.Local).AddTicks(5506));

            migrationBuilder.UpdateData(
                table: "Breeds",
                keyColumn: "Id",
                keyValue: 132,
                column: "CreatedTime",
                value: new DateTime(2024, 8, 30, 11, 21, 47, 399, DateTimeKind.Local).AddTicks(5507));

            migrationBuilder.UpdateData(
                table: "Breeds",
                keyColumn: "Id",
                keyValue: 133,
                column: "CreatedTime",
                value: new DateTime(2024, 8, 30, 11, 21, 47, 399, DateTimeKind.Local).AddTicks(5508));

            migrationBuilder.UpdateData(
                table: "Breeds",
                keyColumn: "Id",
                keyValue: 134,
                column: "CreatedTime",
                value: new DateTime(2024, 8, 30, 11, 21, 47, 399, DateTimeKind.Local).AddTicks(5510));

            migrationBuilder.UpdateData(
                table: "Breeds",
                keyColumn: "Id",
                keyValue: 135,
                column: "CreatedTime",
                value: new DateTime(2024, 8, 30, 11, 21, 47, 399, DateTimeKind.Local).AddTicks(5511));

            migrationBuilder.UpdateData(
                table: "Breeds",
                keyColumn: "Id",
                keyValue: 136,
                column: "CreatedTime",
                value: new DateTime(2024, 8, 30, 11, 21, 47, 399, DateTimeKind.Local).AddTicks(5512));

            migrationBuilder.UpdateData(
                table: "Breeds",
                keyColumn: "Id",
                keyValue: 137,
                column: "CreatedTime",
                value: new DateTime(2024, 8, 30, 11, 21, 47, 399, DateTimeKind.Local).AddTicks(5513));

            migrationBuilder.UpdateData(
                table: "Breeds",
                keyColumn: "Id",
                keyValue: 138,
                column: "CreatedTime",
                value: new DateTime(2024, 8, 30, 11, 21, 47, 399, DateTimeKind.Local).AddTicks(5514));

            migrationBuilder.UpdateData(
                table: "Breeds",
                keyColumn: "Id",
                keyValue: 139,
                column: "CreatedTime",
                value: new DateTime(2024, 8, 30, 11, 21, 47, 399, DateTimeKind.Local).AddTicks(5516));

            migrationBuilder.UpdateData(
                table: "Breeds",
                keyColumn: "Id",
                keyValue: 140,
                column: "CreatedTime",
                value: new DateTime(2024, 8, 30, 11, 21, 47, 399, DateTimeKind.Local).AddTicks(5517));

            migrationBuilder.UpdateData(
                table: "Breeds",
                keyColumn: "Id",
                keyValue: 141,
                column: "CreatedTime",
                value: new DateTime(2024, 8, 30, 11, 21, 47, 399, DateTimeKind.Local).AddTicks(5518));

            migrationBuilder.UpdateData(
                table: "Breeds",
                keyColumn: "Id",
                keyValue: 142,
                column: "CreatedTime",
                value: new DateTime(2024, 8, 30, 11, 21, 47, 399, DateTimeKind.Local).AddTicks(5520));

            migrationBuilder.UpdateData(
                table: "Breeds",
                keyColumn: "Id",
                keyValue: 143,
                column: "CreatedTime",
                value: new DateTime(2024, 8, 30, 11, 21, 47, 399, DateTimeKind.Local).AddTicks(5521));

            migrationBuilder.UpdateData(
                table: "Breeds",
                keyColumn: "Id",
                keyValue: 144,
                column: "CreatedTime",
                value: new DateTime(2024, 8, 30, 11, 21, 47, 399, DateTimeKind.Local).AddTicks(5522));

            migrationBuilder.UpdateData(
                table: "Breeds",
                keyColumn: "Id",
                keyValue: 145,
                column: "CreatedTime",
                value: new DateTime(2024, 8, 30, 11, 21, 47, 399, DateTimeKind.Local).AddTicks(5524));

            migrationBuilder.UpdateData(
                table: "Breeds",
                keyColumn: "Id",
                keyValue: 146,
                column: "CreatedTime",
                value: new DateTime(2024, 8, 30, 11, 21, 47, 399, DateTimeKind.Local).AddTicks(5525));

            migrationBuilder.UpdateData(
                table: "Breeds",
                keyColumn: "Id",
                keyValue: 147,
                column: "CreatedTime",
                value: new DateTime(2024, 8, 30, 11, 21, 47, 399, DateTimeKind.Local).AddTicks(5526));

            migrationBuilder.UpdateData(
                table: "Breeds",
                keyColumn: "Id",
                keyValue: 148,
                column: "CreatedTime",
                value: new DateTime(2024, 8, 30, 11, 21, 47, 399, DateTimeKind.Local).AddTicks(5527));

            migrationBuilder.UpdateData(
                table: "Breeds",
                keyColumn: "Id",
                keyValue: 149,
                column: "CreatedTime",
                value: new DateTime(2024, 8, 30, 11, 21, 47, 399, DateTimeKind.Local).AddTicks(5529));

            migrationBuilder.UpdateData(
                table: "Breeds",
                keyColumn: "Id",
                keyValue: 150,
                column: "CreatedTime",
                value: new DateTime(2024, 8, 30, 11, 21, 47, 399, DateTimeKind.Local).AddTicks(5530));

            migrationBuilder.UpdateData(
                table: "Breeds",
                keyColumn: "Id",
                keyValue: 151,
                column: "CreatedTime",
                value: new DateTime(2024, 8, 30, 11, 21, 47, 399, DateTimeKind.Local).AddTicks(5531));

            migrationBuilder.UpdateData(
                table: "Breeds",
                keyColumn: "Id",
                keyValue: 152,
                column: "CreatedTime",
                value: new DateTime(2024, 8, 30, 11, 21, 47, 399, DateTimeKind.Local).AddTicks(5533));

            migrationBuilder.UpdateData(
                table: "Breeds",
                keyColumn: "Id",
                keyValue: 153,
                column: "CreatedTime",
                value: new DateTime(2024, 8, 30, 11, 21, 47, 399, DateTimeKind.Local).AddTicks(5534));

            migrationBuilder.UpdateData(
                table: "Breeds",
                keyColumn: "Id",
                keyValue: 154,
                column: "CreatedTime",
                value: new DateTime(2024, 8, 30, 11, 21, 47, 399, DateTimeKind.Local).AddTicks(5535));

            migrationBuilder.UpdateData(
                table: "Breeds",
                keyColumn: "Id",
                keyValue: 155,
                column: "CreatedTime",
                value: new DateTime(2024, 8, 30, 11, 21, 47, 399, DateTimeKind.Local).AddTicks(5536));

            migrationBuilder.UpdateData(
                table: "Breeds",
                keyColumn: "Id",
                keyValue: 156,
                column: "CreatedTime",
                value: new DateTime(2024, 8, 30, 11, 21, 47, 399, DateTimeKind.Local).AddTicks(5537));

            migrationBuilder.UpdateData(
                table: "Breeds",
                keyColumn: "Id",
                keyValue: 157,
                column: "CreatedTime",
                value: new DateTime(2024, 8, 30, 11, 21, 47, 399, DateTimeKind.Local).AddTicks(5539));

            migrationBuilder.UpdateData(
                table: "Breeds",
                keyColumn: "Id",
                keyValue: 158,
                column: "CreatedTime",
                value: new DateTime(2024, 8, 30, 11, 21, 47, 399, DateTimeKind.Local).AddTicks(5540));

            migrationBuilder.UpdateData(
                table: "Breeds",
                keyColumn: "Id",
                keyValue: 159,
                column: "CreatedTime",
                value: new DateTime(2024, 8, 30, 11, 21, 47, 399, DateTimeKind.Local).AddTicks(5542));

            migrationBuilder.UpdateData(
                table: "Breeds",
                keyColumn: "Id",
                keyValue: 160,
                column: "CreatedTime",
                value: new DateTime(2024, 8, 30, 11, 21, 47, 399, DateTimeKind.Local).AddTicks(5543));

            migrationBuilder.UpdateData(
                table: "PetTypes",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedTime",
                value: new DateTime(2024, 8, 30, 11, 21, 47, 399, DateTimeKind.Local).AddTicks(2448));

            migrationBuilder.UpdateData(
                table: "PetTypes",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreatedTime",
                value: new DateTime(2024, 8, 30, 11, 21, 47, 399, DateTimeKind.Local).AddTicks(2452));

            migrationBuilder.UpdateData(
                table: "PetTypes",
                keyColumn: "Id",
                keyValue: 3,
                column: "CreatedTime",
                value: new DateTime(2024, 8, 30, 11, 21, 47, 399, DateTimeKind.Local).AddTicks(2453));

            migrationBuilder.UpdateData(
                table: "PetTypes",
                keyColumn: "Id",
                keyValue: 4,
                column: "CreatedTime",
                value: new DateTime(2024, 8, 30, 11, 21, 47, 399, DateTimeKind.Local).AddTicks(2454));

            migrationBuilder.UpdateData(
                table: "PetTypes",
                keyColumn: "Id",
                keyValue: 5,
                column: "CreatedTime",
                value: new DateTime(2024, 8, 30, 11, 21, 47, 399, DateTimeKind.Local).AddTicks(2456));

            migrationBuilder.UpdateData(
                table: "PetTypes",
                keyColumn: "Id",
                keyValue: 6,
                column: "CreatedTime",
                value: new DateTime(2024, 8, 30, 11, 21, 47, 399, DateTimeKind.Local).AddTicks(2457));

            migrationBuilder.UpdateData(
                table: "PetTypes",
                keyColumn: "Id",
                keyValue: 7,
                column: "CreatedTime",
                value: new DateTime(2024, 8, 30, 11, 21, 47, 399, DateTimeKind.Local).AddTicks(2458));

            migrationBuilder.UpdateData(
                table: "PetTypes",
                keyColumn: "Id",
                keyValue: 8,
                column: "CreatedTime",
                value: new DateTime(2024, 8, 30, 11, 21, 47, 399, DateTimeKind.Local).AddTicks(2459));

            migrationBuilder.UpdateData(
                table: "Pets",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedTime",
                value: new DateTime(2024, 8, 30, 11, 21, 47, 408, DateTimeKind.Local).AddTicks(8319));

            migrationBuilder.UpdateData(
                table: "Pets",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreatedTime",
                value: new DateTime(2024, 8, 30, 11, 21, 47, 408, DateTimeKind.Local).AddTicks(8341));

            migrationBuilder.UpdateData(
                table: "Pets",
                keyColumn: "Id",
                keyValue: 3,
                column: "CreatedTime",
                value: new DateTime(2024, 8, 30, 11, 21, 47, 408, DateTimeKind.Local).AddTicks(8345));

            migrationBuilder.UpdateData(
                table: "Pets",
                keyColumn: "Id",
                keyValue: 4,
                column: "CreatedTime",
                value: new DateTime(2024, 8, 30, 11, 21, 47, 408, DateTimeKind.Local).AddTicks(8349));

            migrationBuilder.UpdateData(
                table: "Pets",
                keyColumn: "Id",
                keyValue: 5,
                column: "CreatedTime",
                value: new DateTime(2024, 8, 30, 11, 21, 47, 408, DateTimeKind.Local).AddTicks(8352));

            migrationBuilder.UpdateData(
                table: "Pets",
                keyColumn: "Id",
                keyValue: 6,
                column: "CreatedTime",
                value: new DateTime(2024, 8, 30, 11, 21, 47, 408, DateTimeKind.Local).AddTicks(8356));

            migrationBuilder.UpdateData(
                table: "Pets",
                keyColumn: "Id",
                keyValue: 7,
                column: "CreatedTime",
                value: new DateTime(2024, 8, 30, 11, 21, 47, 408, DateTimeKind.Local).AddTicks(8360));

            migrationBuilder.UpdateData(
                table: "Pets",
                keyColumn: "Id",
                keyValue: 8,
                column: "CreatedTime",
                value: new DateTime(2024, 8, 30, 11, 21, 47, 408, DateTimeKind.Local).AddTicks(8410));

            migrationBuilder.UpdateData(
                table: "Pets",
                keyColumn: "Id",
                keyValue: 9,
                column: "CreatedTime",
                value: new DateTime(2024, 8, 30, 11, 21, 47, 408, DateTimeKind.Local).AddTicks(8415));

            migrationBuilder.UpdateData(
                table: "Pets",
                keyColumn: "Id",
                keyValue: 10,
                column: "CreatedTime",
                value: new DateTime(2024, 8, 30, 11, 21, 47, 408, DateTimeKind.Local).AddTicks(8419));

            migrationBuilder.UpdateData(
                table: "Pets",
                keyColumn: "Id",
                keyValue: 11,
                column: "CreatedTime",
                value: new DateTime(2024, 8, 30, 11, 21, 47, 408, DateTimeKind.Local).AddTicks(8422));

            migrationBuilder.UpdateData(
                table: "Pets",
                keyColumn: "Id",
                keyValue: 12,
                column: "CreatedTime",
                value: new DateTime(2024, 8, 30, 11, 21, 47, 408, DateTimeKind.Local).AddTicks(8426));

            migrationBuilder.UpdateData(
                table: "Pets",
                keyColumn: "Id",
                keyValue: 13,
                column: "CreatedTime",
                value: new DateTime(2024, 8, 30, 11, 21, 47, 408, DateTimeKind.Local).AddTicks(8430));

            migrationBuilder.UpdateData(
                table: "Pets",
                keyColumn: "Id",
                keyValue: 14,
                column: "CreatedTime",
                value: new DateTime(2024, 8, 30, 11, 21, 47, 408, DateTimeKind.Local).AddTicks(8434));

            migrationBuilder.UpdateData(
                table: "Pets",
                keyColumn: "Id",
                keyValue: 15,
                column: "CreatedTime",
                value: new DateTime(2024, 8, 30, 11, 21, 47, 408, DateTimeKind.Local).AddTicks(8437));

            migrationBuilder.UpdateData(
                table: "Pets",
                keyColumn: "Id",
                keyValue: 16,
                column: "CreatedTime",
                value: new DateTime(2024, 8, 30, 11, 21, 47, 408, DateTimeKind.Local).AddTicks(8441));

            migrationBuilder.UpdateData(
                table: "Pets",
                keyColumn: "Id",
                keyValue: 17,
                column: "CreatedTime",
                value: new DateTime(2024, 8, 30, 11, 21, 47, 408, DateTimeKind.Local).AddTicks(8445));

            migrationBuilder.UpdateData(
                table: "Pets",
                keyColumn: "Id",
                keyValue: 18,
                column: "CreatedTime",
                value: new DateTime(2024, 8, 30, 11, 21, 47, 408, DateTimeKind.Local).AddTicks(8449));

            migrationBuilder.UpdateData(
                table: "Pets",
                keyColumn: "Id",
                keyValue: 19,
                column: "CreatedTime",
                value: new DateTime(2024, 8, 30, 11, 21, 47, 408, DateTimeKind.Local).AddTicks(8452));

            migrationBuilder.UpdateData(
                table: "Pets",
                keyColumn: "Id",
                keyValue: 20,
                column: "CreatedTime",
                value: new DateTime(2024, 8, 30, 11, 21, 47, 408, DateTimeKind.Local).AddTicks(8457));

            migrationBuilder.UpdateData(
                table: "Pets",
                keyColumn: "Id",
                keyValue: 21,
                column: "CreatedTime",
                value: new DateTime(2024, 8, 30, 11, 21, 47, 408, DateTimeKind.Local).AddTicks(8460));

            migrationBuilder.UpdateData(
                table: "Pets",
                keyColumn: "Id",
                keyValue: 22,
                column: "CreatedTime",
                value: new DateTime(2024, 8, 30, 11, 21, 47, 408, DateTimeKind.Local).AddTicks(8464));

            migrationBuilder.UpdateData(
                table: "Pets",
                keyColumn: "Id",
                keyValue: 23,
                column: "CreatedTime",
                value: new DateTime(2024, 8, 30, 11, 21, 47, 408, DateTimeKind.Local).AddTicks(8468));

            migrationBuilder.UpdateData(
                table: "Pets",
                keyColumn: "Id",
                keyValue: 24,
                column: "CreatedTime",
                value: new DateTime(2024, 8, 30, 11, 21, 47, 408, DateTimeKind.Local).AddTicks(8471));

            migrationBuilder.UpdateData(
                table: "Pets",
                keyColumn: "Id",
                keyValue: 25,
                column: "CreatedTime",
                value: new DateTime(2024, 8, 30, 11, 21, 47, 408, DateTimeKind.Local).AddTicks(8477));

            migrationBuilder.UpdateData(
                table: "Pets",
                keyColumn: "Id",
                keyValue: 26,
                column: "CreatedTime",
                value: new DateTime(2024, 8, 30, 11, 21, 47, 408, DateTimeKind.Local).AddTicks(8481));

            migrationBuilder.UpdateData(
                table: "Pets",
                keyColumn: "Id",
                keyValue: 27,
                column: "CreatedTime",
                value: new DateTime(2024, 8, 30, 11, 21, 47, 408, DateTimeKind.Local).AddTicks(8485));

            migrationBuilder.UpdateData(
                table: "Pets",
                keyColumn: "Id",
                keyValue: 28,
                column: "CreatedTime",
                value: new DateTime(2024, 8, 30, 11, 21, 47, 408, DateTimeKind.Local).AddTicks(8488));

            migrationBuilder.UpdateData(
                table: "Pets",
                keyColumn: "Id",
                keyValue: 29,
                column: "CreatedTime",
                value: new DateTime(2024, 8, 30, 11, 21, 47, 408, DateTimeKind.Local).AddTicks(8492));

            migrationBuilder.UpdateData(
                table: "Pets",
                keyColumn: "Id",
                keyValue: 30,
                column: "CreatedTime",
                value: new DateTime(2024, 8, 30, 11, 21, 47, 408, DateTimeKind.Local).AddTicks(8495));

            migrationBuilder.UpdateData(
                table: "Pets",
                keyColumn: "Id",
                keyValue: 31,
                column: "CreatedTime",
                value: new DateTime(2024, 8, 30, 11, 21, 47, 408, DateTimeKind.Local).AddTicks(8498));

            migrationBuilder.UpdateData(
                table: "Pets",
                keyColumn: "Id",
                keyValue: 32,
                column: "CreatedTime",
                value: new DateTime(2024, 8, 30, 11, 21, 47, 408, DateTimeKind.Local).AddTicks(8503));

            migrationBuilder.UpdateData(
                table: "Pets",
                keyColumn: "Id",
                keyValue: 33,
                column: "CreatedTime",
                value: new DateTime(2024, 8, 30, 11, 21, 47, 408, DateTimeKind.Local).AddTicks(8506));

            migrationBuilder.UpdateData(
                table: "Pets",
                keyColumn: "Id",
                keyValue: 34,
                column: "CreatedTime",
                value: new DateTime(2024, 8, 30, 11, 21, 47, 408, DateTimeKind.Local).AddTicks(8509));

            migrationBuilder.UpdateData(
                table: "Pets",
                keyColumn: "Id",
                keyValue: 35,
                column: "CreatedTime",
                value: new DateTime(2024, 8, 30, 11, 21, 47, 408, DateTimeKind.Local).AddTicks(8513));

            migrationBuilder.UpdateData(
                table: "Pets",
                keyColumn: "Id",
                keyValue: 36,
                column: "CreatedTime",
                value: new DateTime(2024, 8, 30, 11, 21, 47, 408, DateTimeKind.Local).AddTicks(8516));

            migrationBuilder.UpdateData(
                table: "Pets",
                keyColumn: "Id",
                keyValue: 37,
                column: "CreatedTime",
                value: new DateTime(2024, 8, 30, 11, 21, 47, 408, DateTimeKind.Local).AddTicks(8520));

            migrationBuilder.UpdateData(
                table: "Pets",
                keyColumn: "Id",
                keyValue: 38,
                column: "CreatedTime",
                value: new DateTime(2024, 8, 30, 11, 21, 47, 408, DateTimeKind.Local).AddTicks(8523));

            migrationBuilder.UpdateData(
                table: "Pets",
                keyColumn: "Id",
                keyValue: 39,
                column: "CreatedTime",
                value: new DateTime(2024, 8, 30, 11, 21, 47, 408, DateTimeKind.Local).AddTicks(8527));

            migrationBuilder.UpdateData(
                table: "Pets",
                keyColumn: "Id",
                keyValue: 40,
                column: "CreatedTime",
                value: new DateTime(2024, 8, 30, 11, 21, 47, 408, DateTimeKind.Local).AddTicks(8531));

            migrationBuilder.UpdateData(
                table: "Pets",
                keyColumn: "Id",
                keyValue: 41,
                column: "CreatedTime",
                value: new DateTime(2024, 8, 30, 11, 21, 47, 408, DateTimeKind.Local).AddTicks(8534));

            migrationBuilder.UpdateData(
                table: "Pets",
                keyColumn: "Id",
                keyValue: 42,
                column: "CreatedTime",
                value: new DateTime(2024, 8, 30, 11, 21, 47, 408, DateTimeKind.Local).AddTicks(8538));

            migrationBuilder.UpdateData(
                table: "Pets",
                keyColumn: "Id",
                keyValue: 43,
                column: "CreatedTime",
                value: new DateTime(2024, 8, 30, 11, 21, 47, 408, DateTimeKind.Local).AddTicks(8541));

            migrationBuilder.UpdateData(
                table: "Pets",
                keyColumn: "Id",
                keyValue: 44,
                column: "CreatedTime",
                value: new DateTime(2024, 8, 30, 11, 21, 47, 408, DateTimeKind.Local).AddTicks(8544));

            migrationBuilder.UpdateData(
                table: "Pets",
                keyColumn: "Id",
                keyValue: 45,
                column: "CreatedTime",
                value: new DateTime(2024, 8, 30, 11, 21, 47, 408, DateTimeKind.Local).AddTicks(8548));

            migrationBuilder.UpdateData(
                table: "Pets",
                keyColumn: "Id",
                keyValue: 46,
                column: "CreatedTime",
                value: new DateTime(2024, 8, 30, 11, 21, 47, 408, DateTimeKind.Local).AddTicks(8551));

            migrationBuilder.UpdateData(
                table: "Pets",
                keyColumn: "Id",
                keyValue: 47,
                column: "CreatedTime",
                value: new DateTime(2024, 8, 30, 11, 21, 47, 408, DateTimeKind.Local).AddTicks(8555));

            migrationBuilder.UpdateData(
                table: "Pets",
                keyColumn: "Id",
                keyValue: 48,
                column: "CreatedTime",
                value: new DateTime(2024, 8, 30, 11, 21, 47, 408, DateTimeKind.Local).AddTicks(8596));

            migrationBuilder.UpdateData(
                table: "Pets",
                keyColumn: "Id",
                keyValue: 49,
                column: "CreatedTime",
                value: new DateTime(2024, 8, 30, 11, 21, 47, 408, DateTimeKind.Local).AddTicks(8602));

            migrationBuilder.UpdateData(
                table: "Pets",
                keyColumn: "Id",
                keyValue: 50,
                column: "CreatedTime",
                value: new DateTime(2024, 8, 30, 11, 21, 47, 408, DateTimeKind.Local).AddTicks(8606));

            migrationBuilder.UpdateData(
                table: "Shelters",
                keyColumn: "Id",
                keyValue: 1021,
                columns: new[] { "CreatedTime", "EmailAddress", "LastUpdatedTime" },
                values: new object[] { new DateTime(2024, 8, 30, 7, 21, 47, 399, DateTimeKind.Utc).AddTicks(1611), "ShelterEmailAddress21@gmail.com", new DateTime(2024, 8, 30, 7, 21, 47, 399, DateTimeKind.Utc).AddTicks(1613) });

            migrationBuilder.UpdateData(
                table: "Shelters",
                keyColumn: "Id",
                keyValue: 1022,
                columns: new[] { "CreatedTime", "EmailAddress", "LastUpdatedTime" },
                values: new object[] { new DateTime(2024, 8, 30, 7, 21, 47, 399, DateTimeKind.Utc).AddTicks(1630), "ShelterEmailAddress22@gmail.com", new DateTime(2024, 8, 30, 7, 21, 47, 399, DateTimeKind.Utc).AddTicks(1631) });

            migrationBuilder.UpdateData(
                table: "Shelters",
                keyColumn: "Id",
                keyValue: 1023,
                columns: new[] { "CreatedTime", "EmailAddress", "LastUpdatedTime" },
                values: new object[] { new DateTime(2024, 8, 30, 7, 21, 47, 399, DateTimeKind.Utc).AddTicks(1641), "ShelterEmailAddress23@gmail.com", new DateTime(2024, 8, 30, 7, 21, 47, 399, DateTimeKind.Utc).AddTicks(1641) });

            migrationBuilder.UpdateData(
                table: "Shelters",
                keyColumn: "Id",
                keyValue: 1024,
                columns: new[] { "CreatedTime", "EmailAddress", "LastUpdatedTime" },
                values: new object[] { new DateTime(2024, 8, 30, 7, 21, 47, 399, DateTimeKind.Utc).AddTicks(1650), "ShelterEmailAddress24@gmail.com", new DateTime(2024, 8, 30, 7, 21, 47, 399, DateTimeKind.Utc).AddTicks(1651) });

            migrationBuilder.UpdateData(
                table: "Shelters",
                keyColumn: "Id",
                keyValue: 1025,
                columns: new[] { "CreatedTime", "EmailAddress", "LastUpdatedTime" },
                values: new object[] { new DateTime(2024, 8, 30, 7, 21, 47, 399, DateTimeKind.Utc).AddTicks(1660), "ShelterEmailAddress25@gmail.com", new DateTime(2024, 8, 30, 7, 21, 47, 399, DateTimeKind.Utc).AddTicks(1660) });

            migrationBuilder.UpdateData(
                table: "Shelters",
                keyColumn: "Id",
                keyValue: 1026,
                columns: new[] { "CreatedTime", "EmailAddress", "LastUpdatedTime" },
                values: new object[] { new DateTime(2024, 8, 30, 7, 21, 47, 399, DateTimeKind.Utc).AddTicks(1726), "ShelterEmailAddress26@gmail.com", new DateTime(2024, 8, 30, 7, 21, 47, 399, DateTimeKind.Utc).AddTicks(1727) });

            migrationBuilder.UpdateData(
                table: "Shelters",
                keyColumn: "Id",
                keyValue: 1027,
                columns: new[] { "CreatedTime", "EmailAddress", "LastUpdatedTime" },
                values: new object[] { new DateTime(2024, 8, 30, 7, 21, 47, 399, DateTimeKind.Utc).AddTicks(1736), "ShelterEmailAddress27@gmail.com", new DateTime(2024, 8, 30, 7, 21, 47, 399, DateTimeKind.Utc).AddTicks(1736) });

            migrationBuilder.UpdateData(
                table: "Shelters",
                keyColumn: "Id",
                keyValue: 1028,
                columns: new[] { "CreatedTime", "EmailAddress", "LastUpdatedTime" },
                values: new object[] { new DateTime(2024, 8, 30, 7, 21, 47, 399, DateTimeKind.Utc).AddTicks(1745), "ShelterEmailAddress28@gmail.com", new DateTime(2024, 8, 30, 7, 21, 47, 399, DateTimeKind.Utc).AddTicks(1745) });

            migrationBuilder.UpdateData(
                table: "Shelters",
                keyColumn: "Id",
                keyValue: 1029,
                columns: new[] { "CreatedTime", "EmailAddress", "LastUpdatedTime" },
                values: new object[] { new DateTime(2024, 8, 30, 7, 21, 47, 399, DateTimeKind.Utc).AddTicks(1753), "ShelterEmailAddress29@gmail.com", new DateTime(2024, 8, 30, 7, 21, 47, 399, DateTimeKind.Utc).AddTicks(1754) });

            migrationBuilder.UpdateData(
                table: "Shelters",
                keyColumn: "Id",
                keyValue: 1030,
                columns: new[] { "CreatedTime", "EmailAddress", "LastUpdatedTime" },
                values: new object[] { new DateTime(2024, 8, 30, 7, 21, 47, 399, DateTimeKind.Utc).AddTicks(1764), "ShelterEmailAddress30@gmail.com", new DateTime(2024, 8, 30, 7, 21, 47, 399, DateTimeKind.Utc).AddTicks(1765) });

            migrationBuilder.UpdateData(
                table: "Shelters",
                keyColumn: "Id",
                keyValue: 1031,
                columns: new[] { "CreatedTime", "EmailAddress", "LastUpdatedTime" },
                values: new object[] { new DateTime(2024, 8, 30, 7, 21, 47, 399, DateTimeKind.Utc).AddTicks(1774), "ShelterEmailAddress31@gmail.com", new DateTime(2024, 8, 30, 7, 21, 47, 399, DateTimeKind.Utc).AddTicks(1774) });

            migrationBuilder.UpdateData(
                table: "Shelters",
                keyColumn: "Id",
                keyValue: 1032,
                columns: new[] { "CreatedTime", "EmailAddress", "LastUpdatedTime" },
                values: new object[] { new DateTime(2024, 8, 30, 7, 21, 47, 399, DateTimeKind.Utc).AddTicks(1783), "ShelterEmailAddress32@gmail.com", new DateTime(2024, 8, 30, 7, 21, 47, 399, DateTimeKind.Utc).AddTicks(1783) });

            migrationBuilder.UpdateData(
                table: "Shelters",
                keyColumn: "Id",
                keyValue: 1033,
                columns: new[] { "CreatedTime", "EmailAddress", "LastUpdatedTime" },
                values: new object[] { new DateTime(2024, 8, 30, 7, 21, 47, 399, DateTimeKind.Utc).AddTicks(1792), "ShelterEmailAddress33@gmail.com", new DateTime(2024, 8, 30, 7, 21, 47, 399, DateTimeKind.Utc).AddTicks(1792) });

            migrationBuilder.UpdateData(
                table: "Shelters",
                keyColumn: "Id",
                keyValue: 1034,
                columns: new[] { "CreatedTime", "EmailAddress", "LastUpdatedTime" },
                values: new object[] { new DateTime(2024, 8, 30, 7, 21, 47, 399, DateTimeKind.Utc).AddTicks(1801), "ShelterEmailAddress34@gmail.com", new DateTime(2024, 8, 30, 7, 21, 47, 399, DateTimeKind.Utc).AddTicks(1801) });

            migrationBuilder.UpdateData(
                table: "Shelters",
                keyColumn: "Id",
                keyValue: 1035,
                columns: new[] { "CreatedTime", "EmailAddress", "LastUpdatedTime" },
                values: new object[] { new DateTime(2024, 8, 30, 7, 21, 47, 399, DateTimeKind.Utc).AddTicks(1810), "ShelterEmailAddress35@gmail.com", new DateTime(2024, 8, 30, 7, 21, 47, 399, DateTimeKind.Utc).AddTicks(1810) });

            migrationBuilder.UpdateData(
                table: "Shelters",
                keyColumn: "Id",
                keyValue: 1036,
                columns: new[] { "CreatedTime", "EmailAddress", "LastUpdatedTime" },
                values: new object[] { new DateTime(2024, 8, 30, 7, 21, 47, 399, DateTimeKind.Utc).AddTicks(1818), "ShelterEmailAddress36@gmail.com", new DateTime(2024, 8, 30, 7, 21, 47, 399, DateTimeKind.Utc).AddTicks(1819) });

            migrationBuilder.UpdateData(
                table: "Shelters",
                keyColumn: "Id",
                keyValue: 1037,
                columns: new[] { "CreatedTime", "EmailAddress", "LastUpdatedTime" },
                values: new object[] { new DateTime(2024, 8, 30, 7, 21, 47, 399, DateTimeKind.Utc).AddTicks(1828), "ShelterEmailAddress37@gmail.com", new DateTime(2024, 8, 30, 7, 21, 47, 399, DateTimeKind.Utc).AddTicks(1828) });

            migrationBuilder.UpdateData(
                table: "Shelters",
                keyColumn: "Id",
                keyValue: 1038,
                columns: new[] { "CreatedTime", "EmailAddress", "LastUpdatedTime" },
                values: new object[] { new DateTime(2024, 8, 30, 7, 21, 47, 399, DateTimeKind.Utc).AddTicks(1876), "ShelterEmailAddress38@gmail.com", new DateTime(2024, 8, 30, 7, 21, 47, 399, DateTimeKind.Utc).AddTicks(1876) });

            migrationBuilder.UpdateData(
                table: "Shelters",
                keyColumn: "Id",
                keyValue: 1039,
                columns: new[] { "CreatedTime", "EmailAddress", "LastUpdatedTime" },
                values: new object[] { new DateTime(2024, 8, 30, 7, 21, 47, 399, DateTimeKind.Utc).AddTicks(1885), "ShelterEmailAddress39@gmail.com", new DateTime(2024, 8, 30, 7, 21, 47, 399, DateTimeKind.Utc).AddTicks(1885) });

            migrationBuilder.UpdateData(
                table: "Shelters",
                keyColumn: "Id",
                keyValue: 1040,
                columns: new[] { "CreatedTime", "EmailAddress", "LastUpdatedTime" },
                values: new object[] { new DateTime(2024, 8, 30, 7, 21, 47, 399, DateTimeKind.Utc).AddTicks(1894), "ShelterEmailAddress40@gmail.com", new DateTime(2024, 8, 30, 7, 21, 47, 399, DateTimeKind.Utc).AddTicks(1894) });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "EmailAddress",
                table: "Shelters");

            migrationBuilder.DropColumn(
                name: "About",
                table: "Adoptions");

            migrationBuilder.DropColumn(
                name: "YearsOfPetExperience",
                table: "Adoptions");

            migrationBuilder.AddColumn<int>(
                name: "YearsOfPetExperience",
                table: "AcceptRequests",
                type: "int",
                nullable: false,
                defaultValue: 0);

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
                column: "CreatedTime",
                value: new DateTime(2024, 8, 29, 15, 10, 46, 327, DateTimeKind.Local).AddTicks(1840));

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
                columns: new[] { "CreatedTime", "LastUpdatedTime" },
                values: new object[] { new DateTime(2024, 8, 29, 11, 10, 46, 256, DateTimeKind.Utc).AddTicks(3728), new DateTime(2024, 8, 29, 11, 10, 46, 256, DateTimeKind.Utc).AddTicks(3730) });

            migrationBuilder.UpdateData(
                table: "Shelters",
                keyColumn: "Id",
                keyValue: 1022,
                columns: new[] { "CreatedTime", "LastUpdatedTime" },
                values: new object[] { new DateTime(2024, 8, 29, 11, 10, 46, 256, DateTimeKind.Utc).AddTicks(3743), new DateTime(2024, 8, 29, 11, 10, 46, 256, DateTimeKind.Utc).AddTicks(3743) });

            migrationBuilder.UpdateData(
                table: "Shelters",
                keyColumn: "Id",
                keyValue: 1023,
                columns: new[] { "CreatedTime", "LastUpdatedTime" },
                values: new object[] { new DateTime(2024, 8, 29, 11, 10, 46, 256, DateTimeKind.Utc).AddTicks(3750), new DateTime(2024, 8, 29, 11, 10, 46, 256, DateTimeKind.Utc).AddTicks(3751) });

            migrationBuilder.UpdateData(
                table: "Shelters",
                keyColumn: "Id",
                keyValue: 1024,
                columns: new[] { "CreatedTime", "LastUpdatedTime" },
                values: new object[] { new DateTime(2024, 8, 29, 11, 10, 46, 256, DateTimeKind.Utc).AddTicks(3758), new DateTime(2024, 8, 29, 11, 10, 46, 256, DateTimeKind.Utc).AddTicks(3758) });

            migrationBuilder.UpdateData(
                table: "Shelters",
                keyColumn: "Id",
                keyValue: 1025,
                columns: new[] { "CreatedTime", "LastUpdatedTime" },
                values: new object[] { new DateTime(2024, 8, 29, 11, 10, 46, 256, DateTimeKind.Utc).AddTicks(3765), new DateTime(2024, 8, 29, 11, 10, 46, 256, DateTimeKind.Utc).AddTicks(3765) });

            migrationBuilder.UpdateData(
                table: "Shelters",
                keyColumn: "Id",
                keyValue: 1026,
                columns: new[] { "CreatedTime", "LastUpdatedTime" },
                values: new object[] { new DateTime(2024, 8, 29, 11, 10, 46, 256, DateTimeKind.Utc).AddTicks(3775), new DateTime(2024, 8, 29, 11, 10, 46, 256, DateTimeKind.Utc).AddTicks(3775) });

            migrationBuilder.UpdateData(
                table: "Shelters",
                keyColumn: "Id",
                keyValue: 1027,
                columns: new[] { "CreatedTime", "LastUpdatedTime" },
                values: new object[] { new DateTime(2024, 8, 29, 11, 10, 46, 256, DateTimeKind.Utc).AddTicks(3782), new DateTime(2024, 8, 29, 11, 10, 46, 256, DateTimeKind.Utc).AddTicks(3782) });

            migrationBuilder.UpdateData(
                table: "Shelters",
                keyColumn: "Id",
                keyValue: 1028,
                columns: new[] { "CreatedTime", "LastUpdatedTime" },
                values: new object[] { new DateTime(2024, 8, 29, 11, 10, 46, 256, DateTimeKind.Utc).AddTicks(3788), new DateTime(2024, 8, 29, 11, 10, 46, 256, DateTimeKind.Utc).AddTicks(3789) });

            migrationBuilder.UpdateData(
                table: "Shelters",
                keyColumn: "Id",
                keyValue: 1029,
                columns: new[] { "CreatedTime", "LastUpdatedTime" },
                values: new object[] { new DateTime(2024, 8, 29, 11, 10, 46, 256, DateTimeKind.Utc).AddTicks(3795), new DateTime(2024, 8, 29, 11, 10, 46, 256, DateTimeKind.Utc).AddTicks(3796) });

            migrationBuilder.UpdateData(
                table: "Shelters",
                keyColumn: "Id",
                keyValue: 1030,
                columns: new[] { "CreatedTime", "LastUpdatedTime" },
                values: new object[] { new DateTime(2024, 8, 29, 11, 10, 46, 256, DateTimeKind.Utc).AddTicks(3803), new DateTime(2024, 8, 29, 11, 10, 46, 256, DateTimeKind.Utc).AddTicks(3804) });

            migrationBuilder.UpdateData(
                table: "Shelters",
                keyColumn: "Id",
                keyValue: 1031,
                columns: new[] { "CreatedTime", "LastUpdatedTime" },
                values: new object[] { new DateTime(2024, 8, 29, 11, 10, 46, 256, DateTimeKind.Utc).AddTicks(3811), new DateTime(2024, 8, 29, 11, 10, 46, 256, DateTimeKind.Utc).AddTicks(3811) });

            migrationBuilder.UpdateData(
                table: "Shelters",
                keyColumn: "Id",
                keyValue: 1032,
                columns: new[] { "CreatedTime", "LastUpdatedTime" },
                values: new object[] { new DateTime(2024, 8, 29, 11, 10, 46, 256, DateTimeKind.Utc).AddTicks(3848), new DateTime(2024, 8, 29, 11, 10, 46, 256, DateTimeKind.Utc).AddTicks(3848) });

            migrationBuilder.UpdateData(
                table: "Shelters",
                keyColumn: "Id",
                keyValue: 1033,
                columns: new[] { "CreatedTime", "LastUpdatedTime" },
                values: new object[] { new DateTime(2024, 8, 29, 11, 10, 46, 256, DateTimeKind.Utc).AddTicks(4036), new DateTime(2024, 8, 29, 11, 10, 46, 256, DateTimeKind.Utc).AddTicks(4038) });

            migrationBuilder.UpdateData(
                table: "Shelters",
                keyColumn: "Id",
                keyValue: 1034,
                columns: new[] { "CreatedTime", "LastUpdatedTime" },
                values: new object[] { new DateTime(2024, 8, 29, 11, 10, 46, 256, DateTimeKind.Utc).AddTicks(4057), new DateTime(2024, 8, 29, 11, 10, 46, 256, DateTimeKind.Utc).AddTicks(4058) });

            migrationBuilder.UpdateData(
                table: "Shelters",
                keyColumn: "Id",
                keyValue: 1035,
                columns: new[] { "CreatedTime", "LastUpdatedTime" },
                values: new object[] { new DateTime(2024, 8, 29, 11, 10, 46, 256, DateTimeKind.Utc).AddTicks(4077), new DateTime(2024, 8, 29, 11, 10, 46, 256, DateTimeKind.Utc).AddTicks(4079) });

            migrationBuilder.UpdateData(
                table: "Shelters",
                keyColumn: "Id",
                keyValue: 1036,
                columns: new[] { "CreatedTime", "LastUpdatedTime" },
                values: new object[] { new DateTime(2024, 8, 29, 11, 10, 46, 256, DateTimeKind.Utc).AddTicks(4101), new DateTime(2024, 8, 29, 11, 10, 46, 256, DateTimeKind.Utc).AddTicks(4102) });

            migrationBuilder.UpdateData(
                table: "Shelters",
                keyColumn: "Id",
                keyValue: 1037,
                columns: new[] { "CreatedTime", "LastUpdatedTime" },
                values: new object[] { new DateTime(2024, 8, 29, 11, 10, 46, 256, DateTimeKind.Utc).AddTicks(4123), new DateTime(2024, 8, 29, 11, 10, 46, 256, DateTimeKind.Utc).AddTicks(4124) });

            migrationBuilder.UpdateData(
                table: "Shelters",
                keyColumn: "Id",
                keyValue: 1038,
                columns: new[] { "CreatedTime", "LastUpdatedTime" },
                values: new object[] { new DateTime(2024, 8, 29, 11, 10, 46, 256, DateTimeKind.Utc).AddTicks(4147), new DateTime(2024, 8, 29, 11, 10, 46, 256, DateTimeKind.Utc).AddTicks(4148) });

            migrationBuilder.UpdateData(
                table: "Shelters",
                keyColumn: "Id",
                keyValue: 1039,
                columns: new[] { "CreatedTime", "LastUpdatedTime" },
                values: new object[] { new DateTime(2024, 8, 29, 11, 10, 46, 256, DateTimeKind.Utc).AddTicks(4341), new DateTime(2024, 8, 29, 11, 10, 46, 256, DateTimeKind.Utc).AddTicks(4341) });

            migrationBuilder.UpdateData(
                table: "Shelters",
                keyColumn: "Id",
                keyValue: 1040,
                columns: new[] { "CreatedTime", "LastUpdatedTime" },
                values: new object[] { new DateTime(2024, 8, 29, 11, 10, 46, 256, DateTimeKind.Utc).AddTicks(4348), new DateTime(2024, 8, 29, 11, 10, 46, 256, DateTimeKind.Utc).AddTicks(4349) });
        }
    }
}
