using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace Persistance.Migrations
{
    /// <inheritdoc />
    public partial class mig999 : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
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

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: 2001,
                columns: new[] { "ConcurrencyStamp", "CreatedTime", "LastUpdatedTime", "RefreshTokenCreateTime" },
                values: new object[] { "46d3ac5d-a256-4a4b-bd0f-816c603013ff", new DateTime(2024, 8, 13, 14, 39, 39, 393, DateTimeKind.Utc).AddTicks(3591), new DateTime(2024, 8, 13, 14, 39, 39, 393, DateTimeKind.Utc).AddTicks(3593), new DateTime(2024, 8, 13, 18, 39, 39, 393, DateTimeKind.Local).AddTicks(3471) });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: 2002,
                columns: new[] { "ConcurrencyStamp", "CreatedTime", "LastUpdatedTime", "RefreshTokenCreateTime" },
                values: new object[] { "17008b3c-e00a-412b-865f-525b78c7a27a", new DateTime(2024, 8, 13, 14, 39, 39, 393, DateTimeKind.Utc).AddTicks(3634), new DateTime(2024, 8, 13, 14, 39, 39, 393, DateTimeKind.Utc).AddTicks(3634), new DateTime(2024, 8, 13, 18, 39, 39, 393, DateTimeKind.Local).AddTicks(3615) });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: 2003,
                columns: new[] { "ConcurrencyStamp", "CreatedTime", "LastUpdatedTime", "RefreshTokenCreateTime" },
                values: new object[] { "34ff9bbf-2734-43c7-85e5-21c499d5331b", new DateTime(2024, 8, 13, 14, 39, 39, 393, DateTimeKind.Utc).AddTicks(3662), new DateTime(2024, 8, 13, 14, 39, 39, 393, DateTimeKind.Utc).AddTicks(3663), new DateTime(2024, 8, 13, 18, 39, 39, 393, DateTimeKind.Local).AddTicks(3643) });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: 2004,
                columns: new[] { "ConcurrencyStamp", "CreatedTime", "LastUpdatedTime", "RefreshTokenCreateTime" },
                values: new object[] { "13ca3b50-322e-461c-9bbf-30ec0fae1838", new DateTime(2024, 8, 13, 14, 39, 39, 393, DateTimeKind.Utc).AddTicks(3675), new DateTime(2024, 8, 13, 14, 39, 39, 393, DateTimeKind.Utc).AddTicks(3675), new DateTime(2024, 8, 13, 18, 39, 39, 393, DateTimeKind.Local).AddTicks(3670) });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: 2005,
                columns: new[] { "ConcurrencyStamp", "CreatedTime", "LastUpdatedTime", "RefreshTokenCreateTime" },
                values: new object[] { "c01447db-d69b-4ff9-8829-b69ba97e378e", new DateTime(2024, 8, 13, 14, 39, 39, 393, DateTimeKind.Utc).AddTicks(3687), new DateTime(2024, 8, 13, 14, 39, 39, 393, DateTimeKind.Utc).AddTicks(3687), new DateTime(2024, 8, 13, 18, 39, 39, 393, DateTimeKind.Local).AddTicks(3682) });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: 2006,
                columns: new[] { "ConcurrencyStamp", "CreatedTime", "LastUpdatedTime", "RefreshTokenCreateTime" },
                values: new object[] { "1525b30e-6e99-4e71-906e-00c659408d14", new DateTime(2024, 8, 13, 14, 39, 39, 393, DateTimeKind.Utc).AddTicks(3701), new DateTime(2024, 8, 13, 14, 39, 39, 393, DateTimeKind.Utc).AddTicks(3702), new DateTime(2024, 8, 13, 18, 39, 39, 393, DateTimeKind.Local).AddTicks(3697) });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: 2007,
                columns: new[] { "ConcurrencyStamp", "CreatedTime", "LastUpdatedTime", "RefreshTokenCreateTime" },
                values: new object[] { "f4bf956c-6964-4ca0-a1e3-ce6be051b899", new DateTime(2024, 8, 13, 14, 39, 39, 393, DateTimeKind.Utc).AddTicks(3713), new DateTime(2024, 8, 13, 14, 39, 39, 393, DateTimeKind.Utc).AddTicks(3714), new DateTime(2024, 8, 13, 18, 39, 39, 393, DateTimeKind.Local).AddTicks(3709) });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: 2008,
                columns: new[] { "ConcurrencyStamp", "CreatedTime", "LastUpdatedTime", "RefreshTokenCreateTime" },
                values: new object[] { "dc3cb40d-fbda-443f-aacf-b839bf657639", new DateTime(2024, 8, 13, 14, 39, 39, 393, DateTimeKind.Utc).AddTicks(3726), new DateTime(2024, 8, 13, 14, 39, 39, 393, DateTimeKind.Utc).AddTicks(3726), new DateTime(2024, 8, 13, 18, 39, 39, 393, DateTimeKind.Local).AddTicks(3720) });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: 2009,
                columns: new[] { "ConcurrencyStamp", "CreatedTime", "LastUpdatedTime", "RefreshTokenCreateTime" },
                values: new object[] { "a4eff339-6b4b-42cc-bb2f-3b431caad40d", new DateTime(2024, 8, 13, 14, 39, 39, 393, DateTimeKind.Utc).AddTicks(3738), new DateTime(2024, 8, 13, 14, 39, 39, 393, DateTimeKind.Utc).AddTicks(3738), new DateTime(2024, 8, 13, 18, 39, 39, 393, DateTimeKind.Local).AddTicks(3733) });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: 2010,
                columns: new[] { "ConcurrencyStamp", "CreatedTime", "LastUpdatedTime", "RefreshTokenCreateTime" },
                values: new object[] { "5f4ed920-533c-48fd-8dc4-3953ad6386c9", new DateTime(2024, 8, 13, 14, 39, 39, 393, DateTimeKind.Utc).AddTicks(3754), new DateTime(2024, 8, 13, 14, 39, 39, 393, DateTimeKind.Utc).AddTicks(3754), new DateTime(2024, 8, 13, 18, 39, 39, 393, DateTimeKind.Local).AddTicks(3746) });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: 2011,
                columns: new[] { "ConcurrencyStamp", "CreatedTime", "LastUpdatedTime", "RefreshTokenCreateTime" },
                values: new object[] { "9daa573d-5b36-4306-9464-dabe2f43990a", new DateTime(2024, 8, 13, 14, 39, 39, 393, DateTimeKind.Utc).AddTicks(3771), new DateTime(2024, 8, 13, 14, 39, 39, 393, DateTimeKind.Utc).AddTicks(3772), new DateTime(2024, 8, 13, 18, 39, 39, 393, DateTimeKind.Local).AddTicks(3762) });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: 2012,
                columns: new[] { "ConcurrencyStamp", "CreatedTime", "LastUpdatedTime", "RefreshTokenCreateTime" },
                values: new object[] { "6e1d58db-2b6c-4e56-919e-eb9e8fc59dc2", new DateTime(2024, 8, 13, 14, 39, 39, 393, DateTimeKind.Utc).AddTicks(3790), new DateTime(2024, 8, 13, 14, 39, 39, 393, DateTimeKind.Utc).AddTicks(3791), new DateTime(2024, 8, 13, 18, 39, 39, 393, DateTimeKind.Local).AddTicks(3785) });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: 2013,
                columns: new[] { "ConcurrencyStamp", "CreatedTime", "LastUpdatedTime", "RefreshTokenCreateTime" },
                values: new object[] { "66f8fe35-fccc-4cc3-869d-12df665478ed", new DateTime(2024, 8, 13, 14, 39, 39, 393, DateTimeKind.Utc).AddTicks(3803), new DateTime(2024, 8, 13, 14, 39, 39, 393, DateTimeKind.Utc).AddTicks(3804), new DateTime(2024, 8, 13, 18, 39, 39, 393, DateTimeKind.Local).AddTicks(3798) });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: 2014,
                columns: new[] { "ConcurrencyStamp", "CreatedTime", "LastUpdatedTime", "RefreshTokenCreateTime" },
                values: new object[] { "e572b22c-a514-4986-aef6-981006d12424", new DateTime(2024, 8, 13, 14, 39, 39, 393, DateTimeKind.Utc).AddTicks(3815), new DateTime(2024, 8, 13, 14, 39, 39, 393, DateTimeKind.Utc).AddTicks(3816), new DateTime(2024, 8, 13, 18, 39, 39, 393, DateTimeKind.Local).AddTicks(3811) });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: 2015,
                columns: new[] { "ConcurrencyStamp", "CreatedTime", "LastUpdatedTime", "RefreshTokenCreateTime" },
                values: new object[] { "003e3909-7f0c-43e1-970e-2e7c4e8bf1f9", new DateTime(2024, 8, 13, 14, 39, 39, 393, DateTimeKind.Utc).AddTicks(3827), new DateTime(2024, 8, 13, 14, 39, 39, 393, DateTimeKind.Utc).AddTicks(3828), new DateTime(2024, 8, 13, 18, 39, 39, 393, DateTimeKind.Local).AddTicks(3823) });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: 2016,
                columns: new[] { "ConcurrencyStamp", "CreatedTime", "LastUpdatedTime", "RefreshTokenCreateTime" },
                values: new object[] { "598b2463-0166-4a86-9faa-fb3825081130", new DateTime(2024, 8, 13, 14, 39, 39, 393, DateTimeKind.Utc).AddTicks(3839), new DateTime(2024, 8, 13, 14, 39, 39, 393, DateTimeKind.Utc).AddTicks(3840), new DateTime(2024, 8, 13, 18, 39, 39, 393, DateTimeKind.Local).AddTicks(3834) });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: 2017,
                columns: new[] { "ConcurrencyStamp", "CreatedTime", "LastUpdatedTime", "RefreshTokenCreateTime" },
                values: new object[] { "410b21a5-4e1e-4709-b220-4c3eade14e33", new DateTime(2024, 8, 13, 14, 39, 39, 393, DateTimeKind.Utc).AddTicks(3851), new DateTime(2024, 8, 13, 14, 39, 39, 393, DateTimeKind.Utc).AddTicks(3852), new DateTime(2024, 8, 13, 18, 39, 39, 393, DateTimeKind.Local).AddTicks(3847) });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: 2018,
                columns: new[] { "ConcurrencyStamp", "CreatedTime", "LastUpdatedTime", "RefreshTokenCreateTime" },
                values: new object[] { "bbd6487c-9918-4fb4-8f4f-93d905643b1b", new DateTime(2024, 8, 13, 14, 39, 39, 393, DateTimeKind.Utc).AddTicks(3865), new DateTime(2024, 8, 13, 14, 39, 39, 393, DateTimeKind.Utc).AddTicks(3866), new DateTime(2024, 8, 13, 18, 39, 39, 393, DateTimeKind.Local).AddTicks(3860) });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: 2019,
                columns: new[] { "ConcurrencyStamp", "CreatedTime", "LastUpdatedTime", "RefreshTokenCreateTime" },
                values: new object[] { "ac306a7c-cb8f-4bd2-8a0c-a620d338821a", new DateTime(2024, 8, 13, 14, 39, 39, 393, DateTimeKind.Utc).AddTicks(3881), new DateTime(2024, 8, 13, 14, 39, 39, 393, DateTimeKind.Utc).AddTicks(3881), new DateTime(2024, 8, 13, 18, 39, 39, 393, DateTimeKind.Local).AddTicks(3873) });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: 2020,
                columns: new[] { "ConcurrencyStamp", "CreatedTime", "LastUpdatedTime", "RefreshTokenCreateTime" },
                values: new object[] { "7712b86a-243c-4330-bec9-c64ef8d8ed08", new DateTime(2024, 8, 13, 14, 39, 39, 393, DateTimeKind.Utc).AddTicks(3894), new DateTime(2024, 8, 13, 14, 39, 39, 393, DateTimeKind.Utc).AddTicks(3894), new DateTime(2024, 8, 13, 18, 39, 39, 393, DateTimeKind.Local).AddTicks(3889) });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: 2021,
                columns: new[] { "ConcurrencyStamp", "CreatedTime", "LastUpdatedTime", "RefreshTokenCreateTime" },
                values: new object[] { "7e233705-04d1-4153-9b71-6a54a076acfc", new DateTime(2024, 8, 13, 14, 39, 39, 393, DateTimeKind.Utc).AddTicks(3912), new DateTime(2024, 8, 13, 14, 39, 39, 393, DateTimeKind.Utc).AddTicks(3912), new DateTime(2024, 8, 13, 18, 39, 39, 393, DateTimeKind.Local).AddTicks(3907) });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: 2022,
                columns: new[] { "ConcurrencyStamp", "CreatedTime", "LastUpdatedTime", "RefreshTokenCreateTime" },
                values: new object[] { "421fd55d-05b7-48a7-ab88-6bf03ae42e61", new DateTime(2024, 8, 13, 14, 39, 39, 393, DateTimeKind.Utc).AddTicks(3929), new DateTime(2024, 8, 13, 14, 39, 39, 393, DateTimeKind.Utc).AddTicks(3930), new DateTime(2024, 8, 13, 18, 39, 39, 393, DateTimeKind.Local).AddTicks(3924) });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: 2023,
                columns: new[] { "ConcurrencyStamp", "CreatedTime", "LastUpdatedTime", "RefreshTokenCreateTime" },
                values: new object[] { "482942ae-296f-4934-9f8b-0c9ee47364ed", new DateTime(2024, 8, 13, 14, 39, 39, 393, DateTimeKind.Utc).AddTicks(3942), new DateTime(2024, 8, 13, 14, 39, 39, 393, DateTimeKind.Utc).AddTicks(3942), new DateTime(2024, 8, 13, 18, 39, 39, 393, DateTimeKind.Local).AddTicks(3937) });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: 2024,
                columns: new[] { "ConcurrencyStamp", "CreatedTime", "LastUpdatedTime", "RefreshTokenCreateTime" },
                values: new object[] { "664d31c1-ad7d-44bf-89a6-ffb2975c4ba5", new DateTime(2024, 8, 13, 14, 39, 39, 393, DateTimeKind.Utc).AddTicks(3954), new DateTime(2024, 8, 13, 14, 39, 39, 393, DateTimeKind.Utc).AddTicks(3955), new DateTime(2024, 8, 13, 18, 39, 39, 393, DateTimeKind.Local).AddTicks(3949) });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: 2025,
                columns: new[] { "ConcurrencyStamp", "CreatedTime", "LastUpdatedTime", "RefreshTokenCreateTime" },
                values: new object[] { "fb2b2f34-3188-4746-a89e-b5b08740df02", new DateTime(2024, 8, 13, 14, 39, 39, 393, DateTimeKind.Utc).AddTicks(3966), new DateTime(2024, 8, 13, 14, 39, 39, 393, DateTimeKind.Utc).AddTicks(3967), new DateTime(2024, 8, 13, 18, 39, 39, 393, DateTimeKind.Local).AddTicks(3962) });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: 2026,
                columns: new[] { "ConcurrencyStamp", "CreatedTime", "LastUpdatedTime", "RefreshTokenCreateTime" },
                values: new object[] { "1de0c7a4-1082-48f0-9809-fef48f528b94", new DateTime(2024, 8, 13, 14, 39, 39, 393, DateTimeKind.Utc).AddTicks(3979), new DateTime(2024, 8, 13, 14, 39, 39, 393, DateTimeKind.Utc).AddTicks(3979), new DateTime(2024, 8, 13, 18, 39, 39, 393, DateTimeKind.Local).AddTicks(3973) });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: 2027,
                columns: new[] { "ConcurrencyStamp", "CreatedTime", "LastUpdatedTime", "RefreshTokenCreateTime" },
                values: new object[] { "e48f1c96-6a3a-48f8-b133-87dea54f4ce8", new DateTime(2024, 8, 13, 14, 39, 39, 393, DateTimeKind.Utc).AddTicks(3994), new DateTime(2024, 8, 13, 14, 39, 39, 393, DateTimeKind.Utc).AddTicks(3994), new DateTime(2024, 8, 13, 18, 39, 39, 393, DateTimeKind.Local).AddTicks(3986) });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: 2028,
                columns: new[] { "ConcurrencyStamp", "CreatedTime", "LastUpdatedTime", "RefreshTokenCreateTime" },
                values: new object[] { "09479982-2d61-4e5a-a335-93da2b19d60a", new DateTime(2024, 8, 13, 14, 39, 39, 393, DateTimeKind.Utc).AddTicks(4006), new DateTime(2024, 8, 13, 14, 39, 39, 393, DateTimeKind.Utc).AddTicks(4006), new DateTime(2024, 8, 13, 18, 39, 39, 393, DateTimeKind.Local).AddTicks(4001) });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: 2029,
                columns: new[] { "ConcurrencyStamp", "CreatedTime", "LastUpdatedTime", "RefreshTokenCreateTime" },
                values: new object[] { "fa60ff9a-319b-4b9e-8c8b-72af20b0fc40", new DateTime(2024, 8, 13, 14, 39, 39, 393, DateTimeKind.Utc).AddTicks(4018), new DateTime(2024, 8, 13, 14, 39, 39, 393, DateTimeKind.Utc).AddTicks(4019), new DateTime(2024, 8, 13, 18, 39, 39, 393, DateTimeKind.Local).AddTicks(4014) });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: 2030,
                columns: new[] { "ConcurrencyStamp", "CreatedTime", "LastUpdatedTime", "RefreshTokenCreateTime" },
                values: new object[] { "c2c24d3a-8539-4b2a-a11e-c907413ae2c4", new DateTime(2024, 8, 13, 14, 39, 39, 393, DateTimeKind.Utc).AddTicks(4043), new DateTime(2024, 8, 13, 14, 39, 39, 393, DateTimeKind.Utc).AddTicks(4043), new DateTime(2024, 8, 13, 18, 39, 39, 393, DateTimeKind.Local).AddTicks(4038) });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: 2031,
                columns: new[] { "ConcurrencyStamp", "CreatedTime", "LastUpdatedTime", "RefreshTokenCreateTime" },
                values: new object[] { "8279f6ac-e8cc-4697-83c8-840f5b023445", new DateTime(2024, 8, 13, 14, 39, 39, 393, DateTimeKind.Utc).AddTicks(4055), new DateTime(2024, 8, 13, 14, 39, 39, 393, DateTimeKind.Utc).AddTicks(4056), new DateTime(2024, 8, 13, 18, 39, 39, 393, DateTimeKind.Local).AddTicks(4050) });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: 2032,
                columns: new[] { "ConcurrencyStamp", "CreatedTime", "LastUpdatedTime", "RefreshTokenCreateTime" },
                values: new object[] { "c308dd23-fa18-4675-b802-af611c87514b", new DateTime(2024, 8, 13, 14, 39, 39, 393, DateTimeKind.Utc).AddTicks(4068), new DateTime(2024, 8, 13, 14, 39, 39, 393, DateTimeKind.Utc).AddTicks(4068), new DateTime(2024, 8, 13, 18, 39, 39, 393, DateTimeKind.Local).AddTicks(4063) });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: 2033,
                columns: new[] { "ConcurrencyStamp", "CreatedTime", "LastUpdatedTime", "RefreshTokenCreateTime" },
                values: new object[] { "3a3dca7d-8453-422b-9cba-3bedd9990c78", new DateTime(2024, 8, 13, 14, 39, 39, 393, DateTimeKind.Utc).AddTicks(4080), new DateTime(2024, 8, 13, 14, 39, 39, 393, DateTimeKind.Utc).AddTicks(4080), new DateTime(2024, 8, 13, 18, 39, 39, 393, DateTimeKind.Local).AddTicks(4075) });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: 2034,
                columns: new[] { "ConcurrencyStamp", "CreatedTime", "LastUpdatedTime", "RefreshTokenCreateTime" },
                values: new object[] { "9fe991df-e959-42c3-8913-b186eaca03c6", new DateTime(2024, 8, 13, 14, 39, 39, 393, DateTimeKind.Utc).AddTicks(4094), new DateTime(2024, 8, 13, 14, 39, 39, 393, DateTimeKind.Utc).AddTicks(4094), new DateTime(2024, 8, 13, 18, 39, 39, 393, DateTimeKind.Local).AddTicks(4089) });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: 2035,
                columns: new[] { "ConcurrencyStamp", "CreatedTime", "LastUpdatedTime", "RefreshTokenCreateTime" },
                values: new object[] { "cb470c4d-ad37-4492-9e95-cd3a4d535f4c", new DateTime(2024, 8, 13, 14, 39, 39, 393, DateTimeKind.Utc).AddTicks(4109), new DateTime(2024, 8, 13, 14, 39, 39, 393, DateTimeKind.Utc).AddTicks(4110), new DateTime(2024, 8, 13, 18, 39, 39, 393, DateTimeKind.Local).AddTicks(4101) });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: 2036,
                columns: new[] { "ConcurrencyStamp", "CreatedTime", "LastUpdatedTime", "RefreshTokenCreateTime" },
                values: new object[] { "24a3ed82-b9f5-4e1d-914a-3f8ad5808828", new DateTime(2024, 8, 13, 14, 39, 39, 393, DateTimeKind.Utc).AddTicks(4121), new DateTime(2024, 8, 13, 14, 39, 39, 393, DateTimeKind.Utc).AddTicks(4122), new DateTime(2024, 8, 13, 18, 39, 39, 393, DateTimeKind.Local).AddTicks(4116) });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: 2037,
                columns: new[] { "ConcurrencyStamp", "CreatedTime", "LastUpdatedTime", "RefreshTokenCreateTime" },
                values: new object[] { "e7869c30-015c-4fb6-8f0b-37446b0be215", new DateTime(2024, 8, 13, 14, 39, 39, 393, DateTimeKind.Utc).AddTicks(4134), new DateTime(2024, 8, 13, 14, 39, 39, 393, DateTimeKind.Utc).AddTicks(4134), new DateTime(2024, 8, 13, 18, 39, 39, 393, DateTimeKind.Local).AddTicks(4129) });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: 2038,
                columns: new[] { "ConcurrencyStamp", "CreatedTime", "LastUpdatedTime", "RefreshTokenCreateTime" },
                values: new object[] { "d76f1a7a-703c-4e6b-b59c-f95fad5fb77d", new DateTime(2024, 8, 13, 14, 39, 39, 393, DateTimeKind.Utc).AddTicks(4152), new DateTime(2024, 8, 13, 14, 39, 39, 393, DateTimeKind.Utc).AddTicks(4152), new DateTime(2024, 8, 13, 18, 39, 39, 393, DateTimeKind.Local).AddTicks(4141) });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: 2039,
                columns: new[] { "ConcurrencyStamp", "CreatedTime", "LastUpdatedTime", "RefreshTokenCreateTime" },
                values: new object[] { "7d53e569-41d0-45c8-a918-7289ca5e780e", new DateTime(2024, 8, 13, 14, 39, 39, 393, DateTimeKind.Utc).AddTicks(4165), new DateTime(2024, 8, 13, 14, 39, 39, 393, DateTimeKind.Utc).AddTicks(4165), new DateTime(2024, 8, 13, 18, 39, 39, 393, DateTimeKind.Local).AddTicks(4160) });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: 2040,
                columns: new[] { "ConcurrencyStamp", "CreatedTime", "LastUpdatedTime", "RefreshTokenCreateTime" },
                values: new object[] { "e21bb549-3e7e-4c62-8e75-f5257fab575a", new DateTime(2024, 8, 13, 14, 39, 39, 393, DateTimeKind.Utc).AddTicks(4177), new DateTime(2024, 8, 13, 14, 39, 39, 393, DateTimeKind.Utc).AddTicks(4177), new DateTime(2024, 8, 13, 18, 39, 39, 393, DateTimeKind.Local).AddTicks(4172) });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: 2041,
                columns: new[] { "ConcurrencyStamp", "CreatedTime", "LastUpdatedTime", "RefreshTokenCreateTime" },
                values: new object[] { "87e54a35-ca7d-44cb-baae-1da8e14e7cb8", new DateTime(2024, 8, 13, 14, 39, 39, 393, DateTimeKind.Utc).AddTicks(4189), new DateTime(2024, 8, 13, 14, 39, 39, 393, DateTimeKind.Utc).AddTicks(4189), new DateTime(2024, 8, 13, 18, 39, 39, 393, DateTimeKind.Local).AddTicks(4184) });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: 2042,
                columns: new[] { "ConcurrencyStamp", "CreatedTime", "LastUpdatedTime", "RefreshTokenCreateTime" },
                values: new object[] { "cc74b3f0-1178-4d9b-8d8f-3cb9467769e3", new DateTime(2024, 8, 13, 14, 39, 39, 393, DateTimeKind.Utc).AddTicks(4208), new DateTime(2024, 8, 13, 14, 39, 39, 393, DateTimeKind.Utc).AddTicks(4208), new DateTime(2024, 8, 13, 18, 39, 39, 393, DateTimeKind.Local).AddTicks(4202) });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: 2043,
                columns: new[] { "ConcurrencyStamp", "CreatedTime", "LastUpdatedTime", "RefreshTokenCreateTime" },
                values: new object[] { "3ed32891-768c-4a5a-9857-b3b756478a5f", new DateTime(2024, 8, 13, 14, 39, 39, 393, DateTimeKind.Utc).AddTicks(4223), new DateTime(2024, 8, 13, 14, 39, 39, 393, DateTimeKind.Utc).AddTicks(4224), new DateTime(2024, 8, 13, 18, 39, 39, 393, DateTimeKind.Local).AddTicks(4216) });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: 2044,
                columns: new[] { "ConcurrencyStamp", "CreatedTime", "LastUpdatedTime", "RefreshTokenCreateTime" },
                values: new object[] { "8daa76f6-3dbc-42bb-b4d4-487b145e0a66", new DateTime(2024, 8, 13, 14, 39, 39, 393, DateTimeKind.Utc).AddTicks(4236), new DateTime(2024, 8, 13, 14, 39, 39, 393, DateTimeKind.Utc).AddTicks(4237), new DateTime(2024, 8, 13, 18, 39, 39, 393, DateTimeKind.Local).AddTicks(4231) });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: 2045,
                columns: new[] { "ConcurrencyStamp", "CreatedTime", "LastUpdatedTime", "RefreshTokenCreateTime" },
                values: new object[] { "3e828d6d-a411-4f20-b490-baa1ef2e17bf", new DateTime(2024, 8, 13, 14, 39, 39, 393, DateTimeKind.Utc).AddTicks(4248), new DateTime(2024, 8, 13, 14, 39, 39, 393, DateTimeKind.Utc).AddTicks(4249), new DateTime(2024, 8, 13, 18, 39, 39, 393, DateTimeKind.Local).AddTicks(4244) });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: 2046,
                columns: new[] { "ConcurrencyStamp", "CreatedTime", "LastUpdatedTime", "RefreshTokenCreateTime" },
                values: new object[] { "d17a2828-6ffe-4b6b-af96-697356744dfb", new DateTime(2024, 8, 13, 14, 39, 39, 393, DateTimeKind.Utc).AddTicks(4260), new DateTime(2024, 8, 13, 14, 39, 39, 393, DateTimeKind.Utc).AddTicks(4261), new DateTime(2024, 8, 13, 18, 39, 39, 393, DateTimeKind.Local).AddTicks(4256) });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: 2047,
                columns: new[] { "ConcurrencyStamp", "CreatedTime", "LastUpdatedTime", "RefreshTokenCreateTime" },
                values: new object[] { "6fe6893f-7c2c-40b3-8f03-319f128a2250", new DateTime(2024, 8, 13, 14, 39, 39, 393, DateTimeKind.Utc).AddTicks(4272), new DateTime(2024, 8, 13, 14, 39, 39, 393, DateTimeKind.Utc).AddTicks(4273), new DateTime(2024, 8, 13, 18, 39, 39, 393, DateTimeKind.Local).AddTicks(4268) });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: 2048,
                columns: new[] { "ConcurrencyStamp", "CreatedTime", "LastUpdatedTime", "RefreshTokenCreateTime" },
                values: new object[] { "805a8eb6-88eb-489b-9c64-db0e1293b650", new DateTime(2024, 8, 13, 14, 39, 39, 393, DateTimeKind.Utc).AddTicks(4291), new DateTime(2024, 8, 13, 14, 39, 39, 393, DateTimeKind.Utc).AddTicks(4292), new DateTime(2024, 8, 13, 18, 39, 39, 393, DateTimeKind.Local).AddTicks(4286) });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: 2049,
                columns: new[] { "ConcurrencyStamp", "CreatedTime", "LastUpdatedTime", "RefreshTokenCreateTime" },
                values: new object[] { "34e4c9ac-faba-466f-8323-73ca260d1279", new DateTime(2024, 8, 13, 14, 39, 39, 393, DateTimeKind.Utc).AddTicks(4304), new DateTime(2024, 8, 13, 14, 39, 39, 393, DateTimeKind.Utc).AddTicks(4304), new DateTime(2024, 8, 13, 18, 39, 39, 393, DateTimeKind.Local).AddTicks(4299) });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: 2050,
                columns: new[] { "ConcurrencyStamp", "CreatedTime", "LastUpdatedTime", "RefreshTokenCreateTime" },
                values: new object[] { "f044807d-b62e-4f77-8a8b-aa7b493171bf", new DateTime(2024, 8, 13, 14, 39, 39, 393, DateTimeKind.Utc).AddTicks(4316), new DateTime(2024, 8, 13, 14, 39, 39, 393, DateTimeKind.Utc).AddTicks(4317), new DateTime(2024, 8, 13, 18, 39, 39, 393, DateTimeKind.Local).AddTicks(4311) });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: 2051,
                columns: new[] { "ConcurrencyStamp", "CreatedTime", "LastUpdatedTime", "RefreshTokenCreateTime" },
                values: new object[] { "aa799ec5-903c-47bf-9590-db9695c10f39", new DateTime(2024, 8, 13, 14, 39, 39, 393, DateTimeKind.Utc).AddTicks(4331), new DateTime(2024, 8, 13, 14, 39, 39, 393, DateTimeKind.Utc).AddTicks(4332), new DateTime(2024, 8, 13, 18, 39, 39, 393, DateTimeKind.Local).AddTicks(4324) });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: 2052,
                columns: new[] { "ConcurrencyStamp", "CreatedTime", "LastUpdatedTime", "RefreshTokenCreateTime" },
                values: new object[] { "000b03c3-c22f-4aa0-8129-a889deeb3080", new DateTime(2024, 8, 13, 14, 39, 39, 393, DateTimeKind.Utc).AddTicks(4343), new DateTime(2024, 8, 13, 14, 39, 39, 393, DateTimeKind.Utc).AddTicks(4344), new DateTime(2024, 8, 13, 18, 39, 39, 393, DateTimeKind.Local).AddTicks(4339) });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: 2053,
                columns: new[] { "ConcurrencyStamp", "CreatedTime", "LastUpdatedTime", "RefreshTokenCreateTime" },
                values: new object[] { "d885d496-57b3-4729-bf10-704308d92456", new DateTime(2024, 8, 13, 14, 39, 39, 393, DateTimeKind.Utc).AddTicks(4506), new DateTime(2024, 8, 13, 14, 39, 39, 393, DateTimeKind.Utc).AddTicks(4507), new DateTime(2024, 8, 13, 18, 39, 39, 393, DateTimeKind.Local).AddTicks(4350) });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: 2054,
                columns: new[] { "ConcurrencyStamp", "CreatedTime", "LastUpdatedTime", "RefreshTokenCreateTime" },
                values: new object[] { "aca50c6a-fe0f-4509-adee-02400d8a8d9b", new DateTime(2024, 8, 13, 14, 39, 39, 393, DateTimeKind.Utc).AddTicks(4544), new DateTime(2024, 8, 13, 14, 39, 39, 393, DateTimeKind.Utc).AddTicks(4545), new DateTime(2024, 8, 13, 18, 39, 39, 393, DateTimeKind.Local).AddTicks(4529) });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: 2055,
                columns: new[] { "ConcurrencyStamp", "CreatedTime", "LastUpdatedTime", "RefreshTokenCreateTime" },
                values: new object[] { "130693d0-fdd9-4d55-aae6-48ab2575b263", new DateTime(2024, 8, 13, 14, 39, 39, 393, DateTimeKind.Utc).AddTicks(4581), new DateTime(2024, 8, 13, 14, 39, 39, 393, DateTimeKind.Utc).AddTicks(4582), new DateTime(2024, 8, 13, 18, 39, 39, 393, DateTimeKind.Local).AddTicks(4565) });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: 2056,
                columns: new[] { "ConcurrencyStamp", "CreatedTime", "LastUpdatedTime", "RefreshTokenCreateTime" },
                values: new object[] { "a34f4533-a31a-4672-b0c7-99d1481eebde", new DateTime(2024, 8, 13, 14, 39, 39, 393, DateTimeKind.Utc).AddTicks(4752), new DateTime(2024, 8, 13, 14, 39, 39, 393, DateTimeKind.Utc).AddTicks(4752), new DateTime(2024, 8, 13, 18, 39, 39, 393, DateTimeKind.Local).AddTicks(4747) });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: 2057,
                columns: new[] { "ConcurrencyStamp", "CreatedTime", "LastUpdatedTime", "RefreshTokenCreateTime" },
                values: new object[] { "c73797b4-fe59-4f17-9fd9-c46793fd2da3", new DateTime(2024, 8, 13, 14, 39, 39, 393, DateTimeKind.Utc).AddTicks(4770), new DateTime(2024, 8, 13, 14, 39, 39, 393, DateTimeKind.Utc).AddTicks(4770), new DateTime(2024, 8, 13, 18, 39, 39, 393, DateTimeKind.Local).AddTicks(4759) });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: 2058,
                columns: new[] { "ConcurrencyStamp", "CreatedTime", "LastUpdatedTime", "RefreshTokenCreateTime" },
                values: new object[] { "33c9b237-7fe2-4470-9a5f-1416b8abe8ab", new DateTime(2024, 8, 13, 14, 39, 39, 393, DateTimeKind.Utc).AddTicks(4782), new DateTime(2024, 8, 13, 14, 39, 39, 393, DateTimeKind.Utc).AddTicks(4783), new DateTime(2024, 8, 13, 18, 39, 39, 393, DateTimeKind.Local).AddTicks(4777) });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: 2059,
                columns: new[] { "ConcurrencyStamp", "CreatedTime", "LastUpdatedTime", "RefreshTokenCreateTime" },
                values: new object[] { "c49960d8-da8c-40cc-9457-2e12fe6d53c3", new DateTime(2024, 8, 13, 14, 39, 39, 393, DateTimeKind.Utc).AddTicks(4797), new DateTime(2024, 8, 13, 14, 39, 39, 393, DateTimeKind.Utc).AddTicks(4798), new DateTime(2024, 8, 13, 18, 39, 39, 393, DateTimeKind.Local).AddTicks(4790) });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: 2060,
                columns: new[] { "ConcurrencyStamp", "CreatedTime", "LastUpdatedTime", "RefreshTokenCreateTime" },
                values: new object[] { "d7c645b9-43ad-494c-b69f-107fb24ae375", new DateTime(2024, 8, 13, 14, 39, 39, 393, DateTimeKind.Utc).AddTicks(4809), new DateTime(2024, 8, 13, 14, 39, 39, 393, DateTimeKind.Utc).AddTicks(4810), new DateTime(2024, 8, 13, 18, 39, 39, 393, DateTimeKind.Local).AddTicks(4805) });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
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

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: 2001,
                columns: new[] { "ConcurrencyStamp", "CreatedTime", "LastUpdatedTime", "RefreshTokenCreateTime" },
                values: new object[] { "bc26c54d-6b5a-4764-bd8b-c9eaa73cd521", new DateTime(2024, 8, 13, 14, 3, 13, 320, DateTimeKind.Utc).AddTicks(3081), new DateTime(2024, 8, 13, 14, 3, 13, 320, DateTimeKind.Utc).AddTicks(3083), new DateTime(2024, 8, 13, 18, 3, 13, 320, DateTimeKind.Local).AddTicks(2953) });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: 2002,
                columns: new[] { "ConcurrencyStamp", "CreatedTime", "LastUpdatedTime", "RefreshTokenCreateTime" },
                values: new object[] { "e48a419d-6980-4478-9cdb-3c4fe65fba1f", new DateTime(2024, 8, 13, 14, 3, 13, 320, DateTimeKind.Utc).AddTicks(3113), new DateTime(2024, 8, 13, 14, 3, 13, 320, DateTimeKind.Utc).AddTicks(3113), new DateTime(2024, 8, 13, 18, 3, 13, 320, DateTimeKind.Local).AddTicks(3106) });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: 2003,
                columns: new[] { "ConcurrencyStamp", "CreatedTime", "LastUpdatedTime", "RefreshTokenCreateTime" },
                values: new object[] { "83381d95-196e-4e5a-9983-322e2e987086", new DateTime(2024, 8, 13, 14, 3, 13, 320, DateTimeKind.Utc).AddTicks(3128), new DateTime(2024, 8, 13, 14, 3, 13, 320, DateTimeKind.Utc).AddTicks(3128), new DateTime(2024, 8, 13, 18, 3, 13, 320, DateTimeKind.Local).AddTicks(3123) });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: 2004,
                columns: new[] { "ConcurrencyStamp", "CreatedTime", "LastUpdatedTime", "RefreshTokenCreateTime" },
                values: new object[] { "756ab8f7-461f-40c1-aa79-8824d7fb4874", new DateTime(2024, 8, 13, 14, 3, 13, 320, DateTimeKind.Utc).AddTicks(3140), new DateTime(2024, 8, 13, 14, 3, 13, 320, DateTimeKind.Utc).AddTicks(3141), new DateTime(2024, 8, 13, 18, 3, 13, 320, DateTimeKind.Local).AddTicks(3135) });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: 2005,
                columns: new[] { "ConcurrencyStamp", "CreatedTime", "LastUpdatedTime", "RefreshTokenCreateTime" },
                values: new object[] { "85f2f7d3-220c-4966-92d4-d55d098e0be9", new DateTime(2024, 8, 13, 14, 3, 13, 320, DateTimeKind.Utc).AddTicks(3166), new DateTime(2024, 8, 13, 14, 3, 13, 320, DateTimeKind.Utc).AddTicks(3167), new DateTime(2024, 8, 13, 18, 3, 13, 320, DateTimeKind.Local).AddTicks(3148) });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: 2006,
                columns: new[] { "ConcurrencyStamp", "CreatedTime", "LastUpdatedTime", "RefreshTokenCreateTime" },
                values: new object[] { "242f289a-6a6f-4431-807a-ddf324a746ed", new DateTime(2024, 8, 13, 14, 3, 13, 320, DateTimeKind.Utc).AddTicks(3183), new DateTime(2024, 8, 13, 14, 3, 13, 320, DateTimeKind.Utc).AddTicks(3183), new DateTime(2024, 8, 13, 18, 3, 13, 320, DateTimeKind.Local).AddTicks(3177) });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: 2007,
                columns: new[] { "ConcurrencyStamp", "CreatedTime", "LastUpdatedTime", "RefreshTokenCreateTime" },
                values: new object[] { "60c3f9b0-a401-4598-9ac0-bdd17c1c24f0", new DateTime(2024, 8, 13, 14, 3, 13, 320, DateTimeKind.Utc).AddTicks(3206), new DateTime(2024, 8, 13, 14, 3, 13, 320, DateTimeKind.Utc).AddTicks(3207), new DateTime(2024, 8, 13, 18, 3, 13, 320, DateTimeKind.Local).AddTicks(3201) });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: 2008,
                columns: new[] { "ConcurrencyStamp", "CreatedTime", "LastUpdatedTime", "RefreshTokenCreateTime" },
                values: new object[] { "f74175df-43dd-4c49-b87d-0b12bf974cef", new DateTime(2024, 8, 13, 14, 3, 13, 320, DateTimeKind.Utc).AddTicks(3218), new DateTime(2024, 8, 13, 14, 3, 13, 320, DateTimeKind.Utc).AddTicks(3219), new DateTime(2024, 8, 13, 18, 3, 13, 320, DateTimeKind.Local).AddTicks(3214) });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: 2009,
                columns: new[] { "ConcurrencyStamp", "CreatedTime", "LastUpdatedTime", "RefreshTokenCreateTime" },
                values: new object[] { "4a846961-1555-4060-82ff-aac6b67f9ffb", new DateTime(2024, 8, 13, 14, 3, 13, 320, DateTimeKind.Utc).AddTicks(3230), new DateTime(2024, 8, 13, 14, 3, 13, 320, DateTimeKind.Utc).AddTicks(3231), new DateTime(2024, 8, 13, 18, 3, 13, 320, DateTimeKind.Local).AddTicks(3226) });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: 2010,
                columns: new[] { "ConcurrencyStamp", "CreatedTime", "LastUpdatedTime", "RefreshTokenCreateTime" },
                values: new object[] { "f98c09a9-6af9-4a54-b2dc-a5dec40f3511", new DateTime(2024, 8, 13, 14, 3, 13, 320, DateTimeKind.Utc).AddTicks(3247), new DateTime(2024, 8, 13, 14, 3, 13, 320, DateTimeKind.Utc).AddTicks(3247), new DateTime(2024, 8, 13, 18, 3, 13, 320, DateTimeKind.Local).AddTicks(3240) });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: 2011,
                columns: new[] { "ConcurrencyStamp", "CreatedTime", "LastUpdatedTime", "RefreshTokenCreateTime" },
                values: new object[] { "e178bc65-90f7-4946-8b67-c6cbb2c5eee3", new DateTime(2024, 8, 13, 14, 3, 13, 320, DateTimeKind.Utc).AddTicks(3261), new DateTime(2024, 8, 13, 14, 3, 13, 320, DateTimeKind.Utc).AddTicks(3261), new DateTime(2024, 8, 13, 18, 3, 13, 320, DateTimeKind.Local).AddTicks(3256) });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: 2012,
                columns: new[] { "ConcurrencyStamp", "CreatedTime", "LastUpdatedTime", "RefreshTokenCreateTime" },
                values: new object[] { "ae7fbe22-7a2b-4547-95fc-d7521e29973f", new DateTime(2024, 8, 13, 14, 3, 13, 320, DateTimeKind.Utc).AddTicks(3273), new DateTime(2024, 8, 13, 14, 3, 13, 320, DateTimeKind.Utc).AddTicks(3274), new DateTime(2024, 8, 13, 18, 3, 13, 320, DateTimeKind.Local).AddTicks(3269) });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: 2013,
                columns: new[] { "ConcurrencyStamp", "CreatedTime", "LastUpdatedTime", "RefreshTokenCreateTime" },
                values: new object[] { "70ca1964-8b1d-4223-bea5-19d2f785b12f", new DateTime(2024, 8, 13, 14, 3, 13, 320, DateTimeKind.Utc).AddTicks(3290), new DateTime(2024, 8, 13, 14, 3, 13, 320, DateTimeKind.Utc).AddTicks(3290), new DateTime(2024, 8, 13, 18, 3, 13, 320, DateTimeKind.Local).AddTicks(3281) });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: 2014,
                columns: new[] { "ConcurrencyStamp", "CreatedTime", "LastUpdatedTime", "RefreshTokenCreateTime" },
                values: new object[] { "553fb26a-7f30-459c-a57e-8875fdd441bc", new DateTime(2024, 8, 13, 14, 3, 13, 320, DateTimeKind.Utc).AddTicks(3303), new DateTime(2024, 8, 13, 14, 3, 13, 320, DateTimeKind.Utc).AddTicks(3304), new DateTime(2024, 8, 13, 18, 3, 13, 320, DateTimeKind.Local).AddTicks(3298) });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: 2015,
                columns: new[] { "ConcurrencyStamp", "CreatedTime", "LastUpdatedTime", "RefreshTokenCreateTime" },
                values: new object[] { "dfe2286b-a826-491a-9644-648466c11128", new DateTime(2024, 8, 13, 14, 3, 13, 320, DateTimeKind.Utc).AddTicks(3316), new DateTime(2024, 8, 13, 14, 3, 13, 320, DateTimeKind.Utc).AddTicks(3317), new DateTime(2024, 8, 13, 18, 3, 13, 320, DateTimeKind.Local).AddTicks(3311) });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: 2016,
                columns: new[] { "ConcurrencyStamp", "CreatedTime", "LastUpdatedTime", "RefreshTokenCreateTime" },
                values: new object[] { "aa4351f3-d64e-46dd-ac22-2f24c303f2d3", new DateTime(2024, 8, 13, 14, 3, 13, 320, DateTimeKind.Utc).AddTicks(3338), new DateTime(2024, 8, 13, 14, 3, 13, 320, DateTimeKind.Utc).AddTicks(3339), new DateTime(2024, 8, 13, 18, 3, 13, 320, DateTimeKind.Local).AddTicks(3332) });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: 2017,
                columns: new[] { "ConcurrencyStamp", "CreatedTime", "LastUpdatedTime", "RefreshTokenCreateTime" },
                values: new object[] { "df9a4a94-0ebb-45e4-a6b1-b762154539c7", new DateTime(2024, 8, 13, 14, 3, 13, 320, DateTimeKind.Utc).AddTicks(3351), new DateTime(2024, 8, 13, 14, 3, 13, 320, DateTimeKind.Utc).AddTicks(3351), new DateTime(2024, 8, 13, 18, 3, 13, 320, DateTimeKind.Local).AddTicks(3346) });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: 2018,
                columns: new[] { "ConcurrencyStamp", "CreatedTime", "LastUpdatedTime", "RefreshTokenCreateTime" },
                values: new object[] { "898c1f18-3c5d-4b97-924f-adb10d9201c9", new DateTime(2024, 8, 13, 14, 3, 13, 320, DateTimeKind.Utc).AddTicks(3366), new DateTime(2024, 8, 13, 14, 3, 13, 320, DateTimeKind.Utc).AddTicks(3366), new DateTime(2024, 8, 13, 18, 3, 13, 320, DateTimeKind.Local).AddTicks(3361) });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: 2019,
                columns: new[] { "ConcurrencyStamp", "CreatedTime", "LastUpdatedTime", "RefreshTokenCreateTime" },
                values: new object[] { "52f11b8c-04df-4aaf-a698-4d33d2605524", new DateTime(2024, 8, 13, 14, 3, 13, 320, DateTimeKind.Utc).AddTicks(3379), new DateTime(2024, 8, 13, 14, 3, 13, 320, DateTimeKind.Utc).AddTicks(3379), new DateTime(2024, 8, 13, 18, 3, 13, 320, DateTimeKind.Local).AddTicks(3374) });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: 2020,
                columns: new[] { "ConcurrencyStamp", "CreatedTime", "LastUpdatedTime", "RefreshTokenCreateTime" },
                values: new object[] { "2265f32d-369e-4fbc-af9d-00a216f38ba1", new DateTime(2024, 8, 13, 14, 3, 13, 320, DateTimeKind.Utc).AddTicks(3392), new DateTime(2024, 8, 13, 14, 3, 13, 320, DateTimeKind.Utc).AddTicks(3392), new DateTime(2024, 8, 13, 18, 3, 13, 320, DateTimeKind.Local).AddTicks(3387) });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: 2021,
                columns: new[] { "ConcurrencyStamp", "CreatedTime", "LastUpdatedTime", "RefreshTokenCreateTime" },
                values: new object[] { "d5f14130-5543-4135-b687-93ad05ca7fbf", new DateTime(2024, 8, 13, 14, 3, 13, 320, DateTimeKind.Utc).AddTicks(3410), new DateTime(2024, 8, 13, 14, 3, 13, 320, DateTimeKind.Utc).AddTicks(3410), new DateTime(2024, 8, 13, 18, 3, 13, 320, DateTimeKind.Local).AddTicks(3400) });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: 2022,
                columns: new[] { "ConcurrencyStamp", "CreatedTime", "LastUpdatedTime", "RefreshTokenCreateTime" },
                values: new object[] { "c679a3a6-58e6-4e1e-8ce6-d4e3016c1964", new DateTime(2024, 8, 13, 14, 3, 13, 320, DateTimeKind.Utc).AddTicks(3457), new DateTime(2024, 8, 13, 14, 3, 13, 320, DateTimeKind.Utc).AddTicks(3458), new DateTime(2024, 8, 13, 18, 3, 13, 320, DateTimeKind.Local).AddTicks(3451) });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: 2023,
                columns: new[] { "ConcurrencyStamp", "CreatedTime", "LastUpdatedTime", "RefreshTokenCreateTime" },
                values: new object[] { "31ce2206-a711-4206-a82a-7f68d6ef9f65", new DateTime(2024, 8, 13, 14, 3, 13, 320, DateTimeKind.Utc).AddTicks(3472), new DateTime(2024, 8, 13, 14, 3, 13, 320, DateTimeKind.Utc).AddTicks(3472), new DateTime(2024, 8, 13, 18, 3, 13, 320, DateTimeKind.Local).AddTicks(3467) });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: 2024,
                columns: new[] { "ConcurrencyStamp", "CreatedTime", "LastUpdatedTime", "RefreshTokenCreateTime" },
                values: new object[] { "e400733b-3583-4f94-b0e9-2d7e10277c46", new DateTime(2024, 8, 13, 14, 3, 13, 320, DateTimeKind.Utc).AddTicks(3484), new DateTime(2024, 8, 13, 14, 3, 13, 320, DateTimeKind.Utc).AddTicks(3485), new DateTime(2024, 8, 13, 18, 3, 13, 320, DateTimeKind.Local).AddTicks(3480) });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: 2025,
                columns: new[] { "ConcurrencyStamp", "CreatedTime", "LastUpdatedTime", "RefreshTokenCreateTime" },
                values: new object[] { "0dfe974f-fc66-4e2d-9ac4-f644758a8bfb", new DateTime(2024, 8, 13, 14, 3, 13, 320, DateTimeKind.Utc).AddTicks(3508), new DateTime(2024, 8, 13, 14, 3, 13, 320, DateTimeKind.Utc).AddTicks(3509), new DateTime(2024, 8, 13, 18, 3, 13, 320, DateTimeKind.Local).AddTicks(3503) });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: 2026,
                columns: new[] { "ConcurrencyStamp", "CreatedTime", "LastUpdatedTime", "RefreshTokenCreateTime" },
                values: new object[] { "4a6f219c-5ec2-46fa-8d38-d123ff9f9c2e", new DateTime(2024, 8, 13, 14, 3, 13, 320, DateTimeKind.Utc).AddTicks(3521), new DateTime(2024, 8, 13, 14, 3, 13, 320, DateTimeKind.Utc).AddTicks(3522), new DateTime(2024, 8, 13, 18, 3, 13, 320, DateTimeKind.Local).AddTicks(3517) });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: 2027,
                columns: new[] { "ConcurrencyStamp", "CreatedTime", "LastUpdatedTime", "RefreshTokenCreateTime" },
                values: new object[] { "86b8a7fb-6de7-4348-a4ea-43b1fbee4abd", new DateTime(2024, 8, 13, 14, 3, 13, 320, DateTimeKind.Utc).AddTicks(3534), new DateTime(2024, 8, 13, 14, 3, 13, 320, DateTimeKind.Utc).AddTicks(3535), new DateTime(2024, 8, 13, 18, 3, 13, 320, DateTimeKind.Local).AddTicks(3529) });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: 2028,
                columns: new[] { "ConcurrencyStamp", "CreatedTime", "LastUpdatedTime", "RefreshTokenCreateTime" },
                values: new object[] { "93d5b201-286c-44c2-918e-43a887fd40f3", new DateTime(2024, 8, 13, 14, 3, 13, 320, DateTimeKind.Utc).AddTicks(3547), new DateTime(2024, 8, 13, 14, 3, 13, 320, DateTimeKind.Utc).AddTicks(3548), new DateTime(2024, 8, 13, 18, 3, 13, 320, DateTimeKind.Local).AddTicks(3542) });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: 2029,
                columns: new[] { "ConcurrencyStamp", "CreatedTime", "LastUpdatedTime", "RefreshTokenCreateTime" },
                values: new object[] { "df0bafd2-1a0b-4c6a-9840-a479da283a9a", new DateTime(2024, 8, 13, 14, 3, 13, 320, DateTimeKind.Utc).AddTicks(3563), new DateTime(2024, 8, 13, 14, 3, 13, 320, DateTimeKind.Utc).AddTicks(3563), new DateTime(2024, 8, 13, 18, 3, 13, 320, DateTimeKind.Local).AddTicks(3555) });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: 2030,
                columns: new[] { "ConcurrencyStamp", "CreatedTime", "LastUpdatedTime", "RefreshTokenCreateTime" },
                values: new object[] { "9674b4fb-51fe-4409-a818-95995b0f3d6b", new DateTime(2024, 8, 13, 14, 3, 13, 320, DateTimeKind.Utc).AddTicks(3576), new DateTime(2024, 8, 13, 14, 3, 13, 320, DateTimeKind.Utc).AddTicks(3576), new DateTime(2024, 8, 13, 18, 3, 13, 320, DateTimeKind.Local).AddTicks(3570) });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: 2031,
                columns: new[] { "ConcurrencyStamp", "CreatedTime", "LastUpdatedTime", "RefreshTokenCreateTime" },
                values: new object[] { "856c98c3-b532-45c5-9185-af6f8d447ec8", new DateTime(2024, 8, 13, 14, 3, 13, 320, DateTimeKind.Utc).AddTicks(3588), new DateTime(2024, 8, 13, 14, 3, 13, 320, DateTimeKind.Utc).AddTicks(3589), new DateTime(2024, 8, 13, 18, 3, 13, 320, DateTimeKind.Local).AddTicks(3584) });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: 2032,
                columns: new[] { "ConcurrencyStamp", "CreatedTime", "LastUpdatedTime", "RefreshTokenCreateTime" },
                values: new object[] { "74e92983-c887-462e-9bf3-324c608a549f", new DateTime(2024, 8, 13, 14, 3, 13, 320, DateTimeKind.Utc).AddTicks(3601), new DateTime(2024, 8, 13, 14, 3, 13, 320, DateTimeKind.Utc).AddTicks(3601), new DateTime(2024, 8, 13, 18, 3, 13, 320, DateTimeKind.Local).AddTicks(3596) });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: 2033,
                columns: new[] { "ConcurrencyStamp", "CreatedTime", "LastUpdatedTime", "RefreshTokenCreateTime" },
                values: new object[] { "46294cd5-1eec-44ab-a025-1491971fd67b", new DateTime(2024, 8, 13, 14, 3, 13, 320, DateTimeKind.Utc).AddTicks(3614), new DateTime(2024, 8, 13, 14, 3, 13, 320, DateTimeKind.Utc).AddTicks(3614), new DateTime(2024, 8, 13, 18, 3, 13, 320, DateTimeKind.Local).AddTicks(3609) });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: 2034,
                columns: new[] { "ConcurrencyStamp", "CreatedTime", "LastUpdatedTime", "RefreshTokenCreateTime" },
                values: new object[] { "2044cee0-2934-41fd-a6a0-9355e9a51246", new DateTime(2024, 8, 13, 14, 3, 13, 320, DateTimeKind.Utc).AddTicks(3635), new DateTime(2024, 8, 13, 14, 3, 13, 320, DateTimeKind.Utc).AddTicks(3635), new DateTime(2024, 8, 13, 18, 3, 13, 320, DateTimeKind.Local).AddTicks(3629) });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: 2035,
                columns: new[] { "ConcurrencyStamp", "CreatedTime", "LastUpdatedTime", "RefreshTokenCreateTime" },
                values: new object[] { "95cde526-8a7c-4cb6-aad0-6081d0db8852", new DateTime(2024, 8, 13, 14, 3, 13, 320, DateTimeKind.Utc).AddTicks(3648), new DateTime(2024, 8, 13, 14, 3, 13, 320, DateTimeKind.Utc).AddTicks(3648), new DateTime(2024, 8, 13, 18, 3, 13, 320, DateTimeKind.Local).AddTicks(3643) });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: 2036,
                columns: new[] { "ConcurrencyStamp", "CreatedTime", "LastUpdatedTime", "RefreshTokenCreateTime" },
                values: new object[] { "5de7c471-0551-4a2f-9178-496c4ebea9a6", new DateTime(2024, 8, 13, 14, 3, 13, 320, DateTimeKind.Utc).AddTicks(3660), new DateTime(2024, 8, 13, 14, 3, 13, 320, DateTimeKind.Utc).AddTicks(3661), new DateTime(2024, 8, 13, 18, 3, 13, 320, DateTimeKind.Local).AddTicks(3655) });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: 2037,
                columns: new[] { "ConcurrencyStamp", "CreatedTime", "LastUpdatedTime", "RefreshTokenCreateTime" },
                values: new object[] { "b83d08bf-dbe7-4f63-8100-34da98b78375", new DateTime(2024, 8, 13, 14, 3, 13, 320, DateTimeKind.Utc).AddTicks(3676), new DateTime(2024, 8, 13, 14, 3, 13, 320, DateTimeKind.Utc).AddTicks(3676), new DateTime(2024, 8, 13, 18, 3, 13, 320, DateTimeKind.Local).AddTicks(3668) });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: 2038,
                columns: new[] { "ConcurrencyStamp", "CreatedTime", "LastUpdatedTime", "RefreshTokenCreateTime" },
                values: new object[] { "c44c1c26-9f05-4c69-bf99-df7e057dcc72", new DateTime(2024, 8, 13, 14, 3, 13, 320, DateTimeKind.Utc).AddTicks(3690), new DateTime(2024, 8, 13, 14, 3, 13, 320, DateTimeKind.Utc).AddTicks(3690), new DateTime(2024, 8, 13, 18, 3, 13, 320, DateTimeKind.Local).AddTicks(3685) });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: 2039,
                columns: new[] { "ConcurrencyStamp", "CreatedTime", "LastUpdatedTime", "RefreshTokenCreateTime" },
                values: new object[] { "85a38655-9dd8-459d-a7cd-ffb9c1c292ed", new DateTime(2024, 8, 13, 14, 3, 13, 320, DateTimeKind.Utc).AddTicks(3702), new DateTime(2024, 8, 13, 14, 3, 13, 320, DateTimeKind.Utc).AddTicks(3703), new DateTime(2024, 8, 13, 18, 3, 13, 320, DateTimeKind.Local).AddTicks(3698) });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: 2040,
                columns: new[] { "ConcurrencyStamp", "CreatedTime", "LastUpdatedTime", "RefreshTokenCreateTime" },
                values: new object[] { "07a076f7-5d14-4add-887a-326c853c87b4", new DateTime(2024, 8, 13, 14, 3, 13, 320, DateTimeKind.Utc).AddTicks(3716), new DateTime(2024, 8, 13, 14, 3, 13, 320, DateTimeKind.Utc).AddTicks(3717), new DateTime(2024, 8, 13, 18, 3, 13, 320, DateTimeKind.Local).AddTicks(3710) });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: 2041,
                columns: new[] { "ConcurrencyStamp", "CreatedTime", "LastUpdatedTime", "RefreshTokenCreateTime" },
                values: new object[] { "2ded68f8-78bc-4e1b-9fc8-26f33461d78a", new DateTime(2024, 8, 13, 14, 3, 13, 320, DateTimeKind.Utc).AddTicks(3729), new DateTime(2024, 8, 13, 14, 3, 13, 320, DateTimeKind.Utc).AddTicks(3729), new DateTime(2024, 8, 13, 18, 3, 13, 320, DateTimeKind.Local).AddTicks(3724) });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: 2042,
                columns: new[] { "ConcurrencyStamp", "CreatedTime", "LastUpdatedTime", "RefreshTokenCreateTime" },
                values: new object[] { "6c164bf2-de7b-49ca-9dbb-ef7eae054e25", new DateTime(2024, 8, 13, 14, 3, 13, 320, DateTimeKind.Utc).AddTicks(3754), new DateTime(2024, 8, 13, 14, 3, 13, 320, DateTimeKind.Utc).AddTicks(3754), new DateTime(2024, 8, 13, 18, 3, 13, 320, DateTimeKind.Local).AddTicks(3742) });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: 2043,
                columns: new[] { "ConcurrencyStamp", "CreatedTime", "LastUpdatedTime", "RefreshTokenCreateTime" },
                values: new object[] { "dbe0ec5d-1168-434a-8717-0edde7405d4c", new DateTime(2024, 8, 13, 14, 3, 13, 320, DateTimeKind.Utc).AddTicks(3768), new DateTime(2024, 8, 13, 14, 3, 13, 320, DateTimeKind.Utc).AddTicks(3769), new DateTime(2024, 8, 13, 18, 3, 13, 320, DateTimeKind.Local).AddTicks(3763) });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: 2044,
                columns: new[] { "ConcurrencyStamp", "CreatedTime", "LastUpdatedTime", "RefreshTokenCreateTime" },
                values: new object[] { "29c420d6-b454-4c9c-a741-c8c0873e2217", new DateTime(2024, 8, 13, 14, 3, 13, 320, DateTimeKind.Utc).AddTicks(3781), new DateTime(2024, 8, 13, 14, 3, 13, 320, DateTimeKind.Utc).AddTicks(3781), new DateTime(2024, 8, 13, 18, 3, 13, 320, DateTimeKind.Local).AddTicks(3776) });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: 2045,
                columns: new[] { "ConcurrencyStamp", "CreatedTime", "LastUpdatedTime", "RefreshTokenCreateTime" },
                values: new object[] { "1d71c766-ef16-4c33-80fa-f46dbc16323b", new DateTime(2024, 8, 13, 14, 3, 13, 320, DateTimeKind.Utc).AddTicks(3797), new DateTime(2024, 8, 13, 14, 3, 13, 320, DateTimeKind.Utc).AddTicks(3798), new DateTime(2024, 8, 13, 18, 3, 13, 320, DateTimeKind.Local).AddTicks(3789) });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: 2046,
                columns: new[] { "ConcurrencyStamp", "CreatedTime", "LastUpdatedTime", "RefreshTokenCreateTime" },
                values: new object[] { "f5d4bd5c-d82d-417a-80cd-f4570df5f897", new DateTime(2024, 8, 13, 14, 3, 13, 320, DateTimeKind.Utc).AddTicks(3811), new DateTime(2024, 8, 13, 14, 3, 13, 320, DateTimeKind.Utc).AddTicks(3812), new DateTime(2024, 8, 13, 18, 3, 13, 320, DateTimeKind.Local).AddTicks(3806) });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: 2047,
                columns: new[] { "ConcurrencyStamp", "CreatedTime", "LastUpdatedTime", "RefreshTokenCreateTime" },
                values: new object[] { "fcc79e25-6348-40d2-a921-16c47aa27e47", new DateTime(2024, 8, 13, 14, 3, 13, 320, DateTimeKind.Utc).AddTicks(3824), new DateTime(2024, 8, 13, 14, 3, 13, 320, DateTimeKind.Utc).AddTicks(3824), new DateTime(2024, 8, 13, 18, 3, 13, 320, DateTimeKind.Local).AddTicks(3819) });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: 2048,
                columns: new[] { "ConcurrencyStamp", "CreatedTime", "LastUpdatedTime", "RefreshTokenCreateTime" },
                values: new object[] { "b533cb3c-bd21-40a2-882a-aa03674af472", new DateTime(2024, 8, 13, 14, 3, 13, 320, DateTimeKind.Utc).AddTicks(3836), new DateTime(2024, 8, 13, 14, 3, 13, 320, DateTimeKind.Utc).AddTicks(3837), new DateTime(2024, 8, 13, 18, 3, 13, 320, DateTimeKind.Local).AddTicks(3831) });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: 2049,
                columns: new[] { "ConcurrencyStamp", "CreatedTime", "LastUpdatedTime", "RefreshTokenCreateTime" },
                values: new object[] { "38545fc0-5d1d-421f-a43a-710660503066", new DateTime(2024, 8, 13, 14, 3, 13, 320, DateTimeKind.Utc).AddTicks(3849), new DateTime(2024, 8, 13, 14, 3, 13, 320, DateTimeKind.Utc).AddTicks(3849), new DateTime(2024, 8, 13, 18, 3, 13, 320, DateTimeKind.Local).AddTicks(3844) });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: 2050,
                columns: new[] { "ConcurrencyStamp", "CreatedTime", "LastUpdatedTime", "RefreshTokenCreateTime" },
                values: new object[] { "58038feb-68c7-4a04-93a3-f80341b56050", new DateTime(2024, 8, 13, 14, 3, 13, 320, DateTimeKind.Utc).AddTicks(3861), new DateTime(2024, 8, 13, 14, 3, 13, 320, DateTimeKind.Utc).AddTicks(3861), new DateTime(2024, 8, 13, 18, 3, 13, 320, DateTimeKind.Local).AddTicks(3856) });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: 2051,
                columns: new[] { "ConcurrencyStamp", "CreatedTime", "LastUpdatedTime", "RefreshTokenCreateTime" },
                values: new object[] { "b84c1cd0-1793-4fee-8584-305a40b71e70", new DateTime(2024, 8, 13, 14, 3, 13, 320, DateTimeKind.Utc).AddTicks(3874), new DateTime(2024, 8, 13, 14, 3, 13, 320, DateTimeKind.Utc).AddTicks(3875), new DateTime(2024, 8, 13, 18, 3, 13, 320, DateTimeKind.Local).AddTicks(3869) });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: 2052,
                columns: new[] { "ConcurrencyStamp", "CreatedTime", "LastUpdatedTime", "RefreshTokenCreateTime" },
                values: new object[] { "0a7fb68a-1114-4df4-b828-f2c3394109fb", new DateTime(2024, 8, 13, 14, 3, 13, 320, DateTimeKind.Utc).AddTicks(3898), new DateTime(2024, 8, 13, 14, 3, 13, 320, DateTimeKind.Utc).AddTicks(3899), new DateTime(2024, 8, 13, 18, 3, 13, 320, DateTimeKind.Local).AddTicks(3891) });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: 2053,
                columns: new[] { "ConcurrencyStamp", "CreatedTime", "LastUpdatedTime", "RefreshTokenCreateTime" },
                values: new object[] { "724156ff-4813-45b3-a701-ae0e199d6296", new DateTime(2024, 8, 13, 14, 3, 13, 320, DateTimeKind.Utc).AddTicks(3914), new DateTime(2024, 8, 13, 14, 3, 13, 320, DateTimeKind.Utc).AddTicks(3915), new DateTime(2024, 8, 13, 18, 3, 13, 320, DateTimeKind.Local).AddTicks(3906) });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: 2054,
                columns: new[] { "ConcurrencyStamp", "CreatedTime", "LastUpdatedTime", "RefreshTokenCreateTime" },
                values: new object[] { "f6e923f4-ee5d-4119-b699-f6e71a1f791e", new DateTime(2024, 8, 13, 14, 3, 13, 320, DateTimeKind.Utc).AddTicks(3927), new DateTime(2024, 8, 13, 14, 3, 13, 320, DateTimeKind.Utc).AddTicks(3927), new DateTime(2024, 8, 13, 18, 3, 13, 320, DateTimeKind.Local).AddTicks(3922) });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: 2055,
                columns: new[] { "ConcurrencyStamp", "CreatedTime", "LastUpdatedTime", "RefreshTokenCreateTime" },
                values: new object[] { "53f478e4-dc5c-4fb2-a330-b8ab681da6f1", new DateTime(2024, 8, 13, 14, 3, 13, 320, DateTimeKind.Utc).AddTicks(3940), new DateTime(2024, 8, 13, 14, 3, 13, 320, DateTimeKind.Utc).AddTicks(3940), new DateTime(2024, 8, 13, 18, 3, 13, 320, DateTimeKind.Local).AddTicks(3935) });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: 2056,
                columns: new[] { "ConcurrencyStamp", "CreatedTime", "LastUpdatedTime", "RefreshTokenCreateTime" },
                values: new object[] { "a74e8914-8791-441c-bcd4-88a17fb98ebe", new DateTime(2024, 8, 13, 14, 3, 13, 320, DateTimeKind.Utc).AddTicks(3952), new DateTime(2024, 8, 13, 14, 3, 13, 320, DateTimeKind.Utc).AddTicks(3953), new DateTime(2024, 8, 13, 18, 3, 13, 320, DateTimeKind.Local).AddTicks(3947) });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: 2057,
                columns: new[] { "ConcurrencyStamp", "CreatedTime", "LastUpdatedTime", "RefreshTokenCreateTime" },
                values: new object[] { "b0edea47-b002-43c9-8455-1f03f32a72e1", new DateTime(2024, 8, 13, 14, 3, 13, 320, DateTimeKind.Utc).AddTicks(3965), new DateTime(2024, 8, 13, 14, 3, 13, 320, DateTimeKind.Utc).AddTicks(3965), new DateTime(2024, 8, 13, 18, 3, 13, 320, DateTimeKind.Local).AddTicks(3960) });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: 2058,
                columns: new[] { "ConcurrencyStamp", "CreatedTime", "LastUpdatedTime", "RefreshTokenCreateTime" },
                values: new object[] { "281b10d7-d6f1-4468-abb3-fcf8a02cce5f", new DateTime(2024, 8, 13, 14, 3, 13, 320, DateTimeKind.Utc).AddTicks(3978), new DateTime(2024, 8, 13, 14, 3, 13, 320, DateTimeKind.Utc).AddTicks(3978), new DateTime(2024, 8, 13, 18, 3, 13, 320, DateTimeKind.Local).AddTicks(3973) });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: 2059,
                columns: new[] { "ConcurrencyStamp", "CreatedTime", "LastUpdatedTime", "RefreshTokenCreateTime" },
                values: new object[] { "d8060f4e-c3a8-44ca-8953-ed23847c147c", new DateTime(2024, 8, 13, 14, 3, 13, 320, DateTimeKind.Utc).AddTicks(3990), new DateTime(2024, 8, 13, 14, 3, 13, 320, DateTimeKind.Utc).AddTicks(3991), new DateTime(2024, 8, 13, 18, 3, 13, 320, DateTimeKind.Local).AddTicks(3985) });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: 2060,
                columns: new[] { "ConcurrencyStamp", "CreatedTime", "LastUpdatedTime", "RefreshTokenCreateTime" },
                values: new object[] { "072c8c2e-0648-4646-a9ac-029aee6cd20d", new DateTime(2024, 8, 13, 14, 3, 13, 320, DateTimeKind.Utc).AddTicks(4003), new DateTime(2024, 8, 13, 14, 3, 13, 320, DateTimeKind.Utc).AddTicks(4003), new DateTime(2024, 8, 13, 18, 3, 13, 320, DateTimeKind.Local).AddTicks(3998) });
        }
    }
}
