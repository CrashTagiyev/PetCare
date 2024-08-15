using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Persistance.Migrations
{
    /// <inheritdoc />
    public partial class mig991 : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AlterColumn<string>(
                name: "Lastname",
                table: "AspNetUsers",
                type: "nvarchar(max)",
                nullable: true,
                oldClrType: typeof(string),
                oldType: "nvarchar(max)");

            migrationBuilder.AlterColumn<string>(
                name: "Firstname",
                table: "AspNetUsers",
                type: "nvarchar(max)",
                nullable: true,
                oldClrType: typeof(string),
                oldType: "nvarchar(max)");

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: 2001,
                columns: new[] { "ConcurrencyStamp", "CreatedTime", "LastUpdatedTime", "RefreshTokenCreateTime" },
                values: new object[] { "cd3551b5-045b-400e-afee-7504f39219eb", new DateTime(2024, 8, 15, 11, 50, 45, 690, DateTimeKind.Utc).AddTicks(7119), new DateTime(2024, 8, 15, 11, 50, 45, 690, DateTimeKind.Utc).AddTicks(7120), new DateTime(2024, 8, 15, 15, 50, 45, 690, DateTimeKind.Local).AddTicks(7005) });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: 2002,
                columns: new[] { "ConcurrencyStamp", "CreatedTime", "LastUpdatedTime", "RefreshTokenCreateTime" },
                values: new object[] { "7beae854-9060-435c-b3b0-8af0ce66e336", new DateTime(2024, 8, 15, 11, 50, 45, 690, DateTimeKind.Utc).AddTicks(7152), new DateTime(2024, 8, 15, 11, 50, 45, 690, DateTimeKind.Utc).AddTicks(7152), new DateTime(2024, 8, 15, 15, 50, 45, 690, DateTimeKind.Local).AddTicks(7144) });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: 2003,
                columns: new[] { "ConcurrencyStamp", "CreatedTime", "LastUpdatedTime", "RefreshTokenCreateTime" },
                values: new object[] { "d7e501f2-d255-4127-846f-000b35f1ff6d", new DateTime(2024, 8, 15, 11, 50, 45, 690, DateTimeKind.Utc).AddTicks(7168), new DateTime(2024, 8, 15, 11, 50, 45, 690, DateTimeKind.Utc).AddTicks(7168), new DateTime(2024, 8, 15, 15, 50, 45, 690, DateTimeKind.Local).AddTicks(7162) });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: 2004,
                columns: new[] { "ConcurrencyStamp", "CreatedTime", "LastUpdatedTime", "RefreshTokenCreateTime" },
                values: new object[] { "46e46b23-dbdb-4dff-a771-36266eaf0fd3", new DateTime(2024, 8, 15, 11, 50, 45, 690, DateTimeKind.Utc).AddTicks(7338), new DateTime(2024, 8, 15, 11, 50, 45, 690, DateTimeKind.Utc).AddTicks(7338), new DateTime(2024, 8, 15, 15, 50, 45, 690, DateTimeKind.Local).AddTicks(7177) });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: 2005,
                columns: new[] { "ConcurrencyStamp", "CreatedTime", "LastUpdatedTime", "RefreshTokenCreateTime" },
                values: new object[] { "155f31da-4dfc-4328-abdc-14e0290df701", new DateTime(2024, 8, 15, 11, 50, 45, 690, DateTimeKind.Utc).AddTicks(7356), new DateTime(2024, 8, 15, 11, 50, 45, 690, DateTimeKind.Utc).AddTicks(7356), new DateTime(2024, 8, 15, 15, 50, 45, 690, DateTimeKind.Local).AddTicks(7348) });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: 2006,
                columns: new[] { "ConcurrencyStamp", "CreatedTime", "LastUpdatedTime", "RefreshTokenCreateTime" },
                values: new object[] { "a6dd5bd9-bb15-44bb-a2da-bfa97cbbacd5", new DateTime(2024, 8, 15, 11, 50, 45, 690, DateTimeKind.Utc).AddTicks(7375), new DateTime(2024, 8, 15, 11, 50, 45, 690, DateTimeKind.Utc).AddTicks(7375), new DateTime(2024, 8, 15, 15, 50, 45, 690, DateTimeKind.Local).AddTicks(7369) });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: 2007,
                columns: new[] { "ConcurrencyStamp", "CreatedTime", "LastUpdatedTime", "RefreshTokenCreateTime" },
                values: new object[] { "c1864f4c-53fe-4593-9df6-26c2def076fb", new DateTime(2024, 8, 15, 11, 50, 45, 690, DateTimeKind.Utc).AddTicks(7388), new DateTime(2024, 8, 15, 11, 50, 45, 690, DateTimeKind.Utc).AddTicks(7389), new DateTime(2024, 8, 15, 15, 50, 45, 690, DateTimeKind.Local).AddTicks(7383) });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: 2008,
                columns: new[] { "ConcurrencyStamp", "CreatedTime", "LastUpdatedTime", "RefreshTokenCreateTime" },
                values: new object[] { "00ebb9c5-1957-432e-b6f5-5f2f04c95ef5", new DateTime(2024, 8, 15, 11, 50, 45, 690, DateTimeKind.Utc).AddTicks(7401), new DateTime(2024, 8, 15, 11, 50, 45, 690, DateTimeKind.Utc).AddTicks(7402), new DateTime(2024, 8, 15, 15, 50, 45, 690, DateTimeKind.Local).AddTicks(7396) });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: 2009,
                columns: new[] { "ConcurrencyStamp", "CreatedTime", "LastUpdatedTime", "RefreshTokenCreateTime" },
                values: new object[] { "12f095d9-db29-4f21-ae3d-a14f71807518", new DateTime(2024, 8, 15, 11, 50, 45, 690, DateTimeKind.Utc).AddTicks(7414), new DateTime(2024, 8, 15, 11, 50, 45, 690, DateTimeKind.Utc).AddTicks(7415), new DateTime(2024, 8, 15, 15, 50, 45, 690, DateTimeKind.Local).AddTicks(7409) });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: 2010,
                columns: new[] { "ConcurrencyStamp", "CreatedTime", "LastUpdatedTime", "RefreshTokenCreateTime" },
                values: new object[] { "aedd9658-ef03-47bd-a37f-1fea92791999", new DateTime(2024, 8, 15, 11, 50, 45, 690, DateTimeKind.Utc).AddTicks(7431), new DateTime(2024, 8, 15, 11, 50, 45, 690, DateTimeKind.Utc).AddTicks(7432), new DateTime(2024, 8, 15, 15, 50, 45, 690, DateTimeKind.Local).AddTicks(7423) });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: 2011,
                columns: new[] { "ConcurrencyStamp", "CreatedTime", "LastUpdatedTime", "RefreshTokenCreateTime" },
                values: new object[] { "6766454d-6c96-4cec-aa97-85826eb96f5e", new DateTime(2024, 8, 15, 11, 50, 45, 690, DateTimeKind.Utc).AddTicks(7446), new DateTime(2024, 8, 15, 11, 50, 45, 690, DateTimeKind.Utc).AddTicks(7447), new DateTime(2024, 8, 15, 15, 50, 45, 690, DateTimeKind.Local).AddTicks(7440) });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: 2012,
                columns: new[] { "ConcurrencyStamp", "CreatedTime", "LastUpdatedTime", "RefreshTokenCreateTime" },
                values: new object[] { "7f422e4e-ad8d-4b35-a0fb-b66901778af8", new DateTime(2024, 8, 15, 11, 50, 45, 690, DateTimeKind.Utc).AddTicks(7465), new DateTime(2024, 8, 15, 11, 50, 45, 690, DateTimeKind.Utc).AddTicks(7465), new DateTime(2024, 8, 15, 15, 50, 45, 690, DateTimeKind.Local).AddTicks(7454) });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: 2013,
                columns: new[] { "ConcurrencyStamp", "CreatedTime", "LastUpdatedTime", "RefreshTokenCreateTime" },
                values: new object[] { "24712a9e-58c1-4d14-ae91-5ab69f7a1722", new DateTime(2024, 8, 15, 11, 50, 45, 690, DateTimeKind.Utc).AddTicks(7478), new DateTime(2024, 8, 15, 11, 50, 45, 690, DateTimeKind.Utc).AddTicks(7478), new DateTime(2024, 8, 15, 15, 50, 45, 690, DateTimeKind.Local).AddTicks(7472) });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: 2014,
                columns: new[] { "ConcurrencyStamp", "CreatedTime", "LastUpdatedTime", "RefreshTokenCreateTime" },
                values: new object[] { "f5578202-d29a-43e7-8254-10b82328f3c1", new DateTime(2024, 8, 15, 11, 50, 45, 690, DateTimeKind.Utc).AddTicks(7546), new DateTime(2024, 8, 15, 11, 50, 45, 690, DateTimeKind.Utc).AddTicks(7546), new DateTime(2024, 8, 15, 15, 50, 45, 690, DateTimeKind.Local).AddTicks(7539) });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: 2015,
                columns: new[] { "ConcurrencyStamp", "CreatedTime", "LastUpdatedTime", "RefreshTokenCreateTime" },
                values: new object[] { "4756cbba-0902-47ae-8e1e-25d61df6fc77", new DateTime(2024, 8, 15, 11, 50, 45, 690, DateTimeKind.Utc).AddTicks(7560), new DateTime(2024, 8, 15, 11, 50, 45, 690, DateTimeKind.Utc).AddTicks(7560), new DateTime(2024, 8, 15, 15, 50, 45, 690, DateTimeKind.Local).AddTicks(7554) });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: 2016,
                columns: new[] { "ConcurrencyStamp", "CreatedTime", "LastUpdatedTime", "RefreshTokenCreateTime" },
                values: new object[] { "eb792842-5228-4c82-a950-017e17975d43", new DateTime(2024, 8, 15, 11, 50, 45, 690, DateTimeKind.Utc).AddTicks(7573), new DateTime(2024, 8, 15, 11, 50, 45, 690, DateTimeKind.Utc).AddTicks(7574), new DateTime(2024, 8, 15, 15, 50, 45, 690, DateTimeKind.Local).AddTicks(7568) });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: 2017,
                columns: new[] { "ConcurrencyStamp", "CreatedTime", "LastUpdatedTime", "RefreshTokenCreateTime" },
                values: new object[] { "cbf96bbd-2866-4c9b-a1a1-8404ed23c1df", new DateTime(2024, 8, 15, 11, 50, 45, 690, DateTimeKind.Utc).AddTicks(7587), new DateTime(2024, 8, 15, 11, 50, 45, 690, DateTimeKind.Utc).AddTicks(7588), new DateTime(2024, 8, 15, 15, 50, 45, 690, DateTimeKind.Local).AddTicks(7581) });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: 2018,
                columns: new[] { "ConcurrencyStamp", "CreatedTime", "LastUpdatedTime", "RefreshTokenCreateTime" },
                values: new object[] { "a54d9540-037b-4bf1-ad9f-c1373ddfbb39", new DateTime(2024, 8, 15, 11, 50, 45, 690, DateTimeKind.Utc).AddTicks(7603), new DateTime(2024, 8, 15, 11, 50, 45, 690, DateTimeKind.Utc).AddTicks(7603), new DateTime(2024, 8, 15, 15, 50, 45, 690, DateTimeKind.Local).AddTicks(7597) });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: 2019,
                columns: new[] { "ConcurrencyStamp", "CreatedTime", "LastUpdatedTime", "RefreshTokenCreateTime" },
                values: new object[] { "ebae795a-932f-47fd-97b2-33c80411cedf", new DateTime(2024, 8, 15, 11, 50, 45, 690, DateTimeKind.Utc).AddTicks(7616), new DateTime(2024, 8, 15, 11, 50, 45, 690, DateTimeKind.Utc).AddTicks(7616), new DateTime(2024, 8, 15, 15, 50, 45, 690, DateTimeKind.Local).AddTicks(7611) });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: 2020,
                columns: new[] { "ConcurrencyStamp", "CreatedTime", "LastUpdatedTime", "RefreshTokenCreateTime" },
                values: new object[] { "5fde59df-8608-4222-bbb6-ae6b0e77182d", new DateTime(2024, 8, 15, 11, 50, 45, 690, DateTimeKind.Utc).AddTicks(7633), new DateTime(2024, 8, 15, 11, 50, 45, 690, DateTimeKind.Utc).AddTicks(7633), new DateTime(2024, 8, 15, 15, 50, 45, 690, DateTimeKind.Local).AddTicks(7624) });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: 2021,
                columns: new[] { "ConcurrencyStamp", "CreatedTime", "LastUpdatedTime", "RefreshTokenCreateTime" },
                values: new object[] { "50d5ff1e-306b-4ec0-b986-1a1845816ccf", new DateTime(2024, 8, 15, 11, 50, 45, 690, DateTimeKind.Utc).AddTicks(7646), new DateTime(2024, 8, 15, 11, 50, 45, 690, DateTimeKind.Utc).AddTicks(7647), new DateTime(2024, 8, 15, 15, 50, 45, 690, DateTimeKind.Local).AddTicks(7641) });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: 2022,
                columns: new[] { "ConcurrencyStamp", "CreatedTime", "LastUpdatedTime", "RefreshTokenCreateTime" },
                values: new object[] { "c079b6cd-bfbe-49dd-b1b7-9a1e29eb80e1", new DateTime(2024, 8, 15, 11, 50, 45, 690, DateTimeKind.Utc).AddTicks(7703), new DateTime(2024, 8, 15, 11, 50, 45, 690, DateTimeKind.Utc).AddTicks(7704), new DateTime(2024, 8, 15, 15, 50, 45, 690, DateTimeKind.Local).AddTicks(7660) });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: 2023,
                columns: new[] { "ConcurrencyStamp", "CreatedTime", "LastUpdatedTime", "RefreshTokenCreateTime" },
                values: new object[] { "155954c3-d6de-4c25-943e-e1d93a77faf5", new DateTime(2024, 8, 15, 11, 50, 45, 690, DateTimeKind.Utc).AddTicks(7718), new DateTime(2024, 8, 15, 11, 50, 45, 690, DateTimeKind.Utc).AddTicks(7719), new DateTime(2024, 8, 15, 15, 50, 45, 690, DateTimeKind.Local).AddTicks(7712) });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: 2024,
                columns: new[] { "ConcurrencyStamp", "CreatedTime", "LastUpdatedTime", "RefreshTokenCreateTime" },
                values: new object[] { "6384b6d4-2a18-40ac-8959-888a15db67de", new DateTime(2024, 8, 15, 11, 50, 45, 690, DateTimeKind.Utc).AddTicks(7732), new DateTime(2024, 8, 15, 11, 50, 45, 690, DateTimeKind.Utc).AddTicks(7732), new DateTime(2024, 8, 15, 15, 50, 45, 690, DateTimeKind.Local).AddTicks(7726) });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: 2025,
                columns: new[] { "ConcurrencyStamp", "CreatedTime", "LastUpdatedTime", "RefreshTokenCreateTime" },
                values: new object[] { "bcb51ef8-6eac-40f5-a052-f9680f7885c7", new DateTime(2024, 8, 15, 11, 50, 45, 690, DateTimeKind.Utc).AddTicks(7746), new DateTime(2024, 8, 15, 11, 50, 45, 690, DateTimeKind.Utc).AddTicks(7746), new DateTime(2024, 8, 15, 15, 50, 45, 690, DateTimeKind.Local).AddTicks(7740) });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: 2026,
                columns: new[] { "ConcurrencyStamp", "CreatedTime", "LastUpdatedTime", "RefreshTokenCreateTime" },
                values: new object[] { "77cef02c-38a1-4735-b087-0d7737cebca0", new DateTime(2024, 8, 15, 11, 50, 45, 690, DateTimeKind.Utc).AddTicks(7759), new DateTime(2024, 8, 15, 11, 50, 45, 690, DateTimeKind.Utc).AddTicks(7760), new DateTime(2024, 8, 15, 15, 50, 45, 690, DateTimeKind.Local).AddTicks(7754) });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: 2027,
                columns: new[] { "ConcurrencyStamp", "CreatedTime", "LastUpdatedTime", "RefreshTokenCreateTime" },
                values: new object[] { "28de58d1-e337-45d3-b9da-3ef64f5389ab", new DateTime(2024, 8, 15, 11, 50, 45, 690, DateTimeKind.Utc).AddTicks(7773), new DateTime(2024, 8, 15, 11, 50, 45, 690, DateTimeKind.Utc).AddTicks(7773), new DateTime(2024, 8, 15, 15, 50, 45, 690, DateTimeKind.Local).AddTicks(7767) });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: 2028,
                columns: new[] { "ConcurrencyStamp", "CreatedTime", "LastUpdatedTime", "RefreshTokenCreateTime" },
                values: new object[] { "98472868-6f1d-4dcc-bb91-a4da9eacfb40", new DateTime(2024, 8, 15, 11, 50, 45, 690, DateTimeKind.Utc).AddTicks(7790), new DateTime(2024, 8, 15, 11, 50, 45, 690, DateTimeKind.Utc).AddTicks(7791), new DateTime(2024, 8, 15, 15, 50, 45, 690, DateTimeKind.Local).AddTicks(7781) });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: 2029,
                columns: new[] { "ConcurrencyStamp", "CreatedTime", "LastUpdatedTime", "RefreshTokenCreateTime" },
                values: new object[] { "2f8a11c3-2f1e-470e-b35b-4376fe9e89f3", new DateTime(2024, 8, 15, 11, 50, 45, 690, DateTimeKind.Utc).AddTicks(7804), new DateTime(2024, 8, 15, 11, 50, 45, 690, DateTimeKind.Utc).AddTicks(7805), new DateTime(2024, 8, 15, 15, 50, 45, 690, DateTimeKind.Local).AddTicks(7799) });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: 2030,
                columns: new[] { "ConcurrencyStamp", "CreatedTime", "LastUpdatedTime", "RefreshTokenCreateTime" },
                values: new object[] { "aa4c4598-35a1-4331-ad7f-2c7277088285", new DateTime(2024, 8, 15, 11, 50, 45, 690, DateTimeKind.Utc).AddTicks(7818), new DateTime(2024, 8, 15, 11, 50, 45, 690, DateTimeKind.Utc).AddTicks(7819), new DateTime(2024, 8, 15, 15, 50, 45, 690, DateTimeKind.Local).AddTicks(7813) });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: 2031,
                columns: new[] { "ConcurrencyStamp", "CreatedTime", "LastUpdatedTime", "RefreshTokenCreateTime" },
                values: new object[] { "946c5d25-0aa7-4ca6-b965-c6509bc9fc89", new DateTime(2024, 8, 15, 11, 50, 45, 690, DateTimeKind.Utc).AddTicks(7872), new DateTime(2024, 8, 15, 11, 50, 45, 690, DateTimeKind.Utc).AddTicks(7873), new DateTime(2024, 8, 15, 15, 50, 45, 690, DateTimeKind.Local).AddTicks(7866) });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: 2032,
                columns: new[] { "ConcurrencyStamp", "CreatedTime", "LastUpdatedTime", "RefreshTokenCreateTime" },
                values: new object[] { "49b0d825-810e-47d4-abd4-14973d88f770", new DateTime(2024, 8, 15, 11, 50, 45, 690, DateTimeKind.Utc).AddTicks(7886), new DateTime(2024, 8, 15, 11, 50, 45, 690, DateTimeKind.Utc).AddTicks(7887), new DateTime(2024, 8, 15, 15, 50, 45, 690, DateTimeKind.Local).AddTicks(7881) });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: 2033,
                columns: new[] { "ConcurrencyStamp", "CreatedTime", "LastUpdatedTime", "RefreshTokenCreateTime" },
                values: new object[] { "efc69785-01a0-44ba-bd1b-2cb965505d40", new DateTime(2024, 8, 15, 11, 50, 45, 690, DateTimeKind.Utc).AddTicks(7900), new DateTime(2024, 8, 15, 11, 50, 45, 690, DateTimeKind.Utc).AddTicks(7900), new DateTime(2024, 8, 15, 15, 50, 45, 690, DateTimeKind.Local).AddTicks(7894) });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: 2034,
                columns: new[] { "ConcurrencyStamp", "CreatedTime", "LastUpdatedTime", "RefreshTokenCreateTime" },
                values: new object[] { "d486146a-ba1a-4318-898d-b30b8541be3c", new DateTime(2024, 8, 15, 11, 50, 45, 690, DateTimeKind.Utc).AddTicks(7916), new DateTime(2024, 8, 15, 11, 50, 45, 690, DateTimeKind.Utc).AddTicks(7916), new DateTime(2024, 8, 15, 15, 50, 45, 690, DateTimeKind.Local).AddTicks(7910) });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: 2035,
                columns: new[] { "ConcurrencyStamp", "CreatedTime", "LastUpdatedTime", "RefreshTokenCreateTime" },
                values: new object[] { "6ce59e9c-deeb-4526-950c-0bc11b7eb3ed", new DateTime(2024, 8, 15, 11, 50, 45, 690, DateTimeKind.Utc).AddTicks(7930), new DateTime(2024, 8, 15, 11, 50, 45, 690, DateTimeKind.Utc).AddTicks(7930), new DateTime(2024, 8, 15, 15, 50, 45, 690, DateTimeKind.Local).AddTicks(7924) });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: 2036,
                columns: new[] { "ConcurrencyStamp", "CreatedTime", "LastUpdatedTime", "RefreshTokenCreateTime" },
                values: new object[] { "fac701aa-d484-4f7f-b23c-b1b5f29a6bbe", new DateTime(2024, 8, 15, 11, 50, 45, 690, DateTimeKind.Utc).AddTicks(7946), new DateTime(2024, 8, 15, 11, 50, 45, 690, DateTimeKind.Utc).AddTicks(7947), new DateTime(2024, 8, 15, 15, 50, 45, 690, DateTimeKind.Local).AddTicks(7938) });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: 2037,
                columns: new[] { "ConcurrencyStamp", "CreatedTime", "LastUpdatedTime", "RefreshTokenCreateTime" },
                values: new object[] { "a1843fc7-07a0-4b6e-a315-f6cb5e979f13", new DateTime(2024, 8, 15, 11, 50, 45, 690, DateTimeKind.Utc).AddTicks(7960), new DateTime(2024, 8, 15, 11, 50, 45, 690, DateTimeKind.Utc).AddTicks(7961), new DateTime(2024, 8, 15, 15, 50, 45, 690, DateTimeKind.Local).AddTicks(7955) });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: 2038,
                columns: new[] { "ConcurrencyStamp", "CreatedTime", "LastUpdatedTime", "RefreshTokenCreateTime" },
                values: new object[] { "0d365ae2-6d61-4911-80b0-e1cd2ca9fe56", new DateTime(2024, 8, 15, 11, 50, 45, 690, DateTimeKind.Utc).AddTicks(7974), new DateTime(2024, 8, 15, 11, 50, 45, 690, DateTimeKind.Utc).AddTicks(7974), new DateTime(2024, 8, 15, 15, 50, 45, 690, DateTimeKind.Local).AddTicks(7968) });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: 2039,
                columns: new[] { "ConcurrencyStamp", "CreatedTime", "LastUpdatedTime", "RefreshTokenCreateTime" },
                values: new object[] { "d59ac757-219a-4640-9c02-addf4d0e78f3", new DateTime(2024, 8, 15, 11, 50, 45, 690, DateTimeKind.Utc).AddTicks(8027), new DateTime(2024, 8, 15, 11, 50, 45, 690, DateTimeKind.Utc).AddTicks(8028), new DateTime(2024, 8, 15, 15, 50, 45, 690, DateTimeKind.Local).AddTicks(7982) });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: 2040,
                columns: new[] { "ConcurrencyStamp", "CreatedTime", "LastUpdatedTime", "RefreshTokenCreateTime" },
                values: new object[] { "e3fc6dc0-3acc-43b5-8533-387e67e8b2e4", new DateTime(2024, 8, 15, 11, 50, 45, 690, DateTimeKind.Utc).AddTicks(8041), new DateTime(2024, 8, 15, 11, 50, 45, 690, DateTimeKind.Utc).AddTicks(8042), new DateTime(2024, 8, 15, 15, 50, 45, 690, DateTimeKind.Local).AddTicks(8036) });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: 2041,
                columns: new[] { "ConcurrencyStamp", "CreatedTime", "LastUpdatedTime", "RefreshTokenCreateTime" },
                values: new object[] { "e1f23979-14f9-4634-aee0-cb60139f475f", new DateTime(2024, 8, 15, 11, 50, 45, 690, DateTimeKind.Utc).AddTicks(8055), new DateTime(2024, 8, 15, 11, 50, 45, 690, DateTimeKind.Utc).AddTicks(8056), new DateTime(2024, 8, 15, 15, 50, 45, 690, DateTimeKind.Local).AddTicks(8050) });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: 2042,
                columns: new[] { "ConcurrencyStamp", "CreatedTime", "LastUpdatedTime", "RefreshTokenCreateTime" },
                values: new object[] { "00aa88b2-724b-40c0-a7db-a6effbd88a40", new DateTime(2024, 8, 15, 11, 50, 45, 690, DateTimeKind.Utc).AddTicks(8075), new DateTime(2024, 8, 15, 11, 50, 45, 690, DateTimeKind.Utc).AddTicks(8076), new DateTime(2024, 8, 15, 15, 50, 45, 690, DateTimeKind.Local).AddTicks(8069) });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: 2043,
                columns: new[] { "ConcurrencyStamp", "CreatedTime", "LastUpdatedTime", "RefreshTokenCreateTime" },
                values: new object[] { "8225dcee-2b2f-4b39-9d8c-3e46eee65bcd", new DateTime(2024, 8, 15, 11, 50, 45, 690, DateTimeKind.Utc).AddTicks(8089), new DateTime(2024, 8, 15, 11, 50, 45, 690, DateTimeKind.Utc).AddTicks(8090), new DateTime(2024, 8, 15, 15, 50, 45, 690, DateTimeKind.Local).AddTicks(8084) });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: 2044,
                columns: new[] { "ConcurrencyStamp", "CreatedTime", "LastUpdatedTime", "RefreshTokenCreateTime" },
                values: new object[] { "77d9ebe0-153d-4125-b150-0da8051f0c0d", new DateTime(2024, 8, 15, 11, 50, 45, 690, DateTimeKind.Utc).AddTicks(8106), new DateTime(2024, 8, 15, 11, 50, 45, 690, DateTimeKind.Utc).AddTicks(8107), new DateTime(2024, 8, 15, 15, 50, 45, 690, DateTimeKind.Local).AddTicks(8098) });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: 2045,
                columns: new[] { "ConcurrencyStamp", "CreatedTime", "LastUpdatedTime", "RefreshTokenCreateTime" },
                values: new object[] { "20ae71da-b43c-46bb-a18f-454f0004c4c8", new DateTime(2024, 8, 15, 11, 50, 45, 690, DateTimeKind.Utc).AddTicks(8120), new DateTime(2024, 8, 15, 11, 50, 45, 690, DateTimeKind.Utc).AddTicks(8121), new DateTime(2024, 8, 15, 15, 50, 45, 690, DateTimeKind.Local).AddTicks(8115) });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: 2046,
                columns: new[] { "ConcurrencyStamp", "CreatedTime", "LastUpdatedTime", "RefreshTokenCreateTime" },
                values: new object[] { "7ea21cdb-3557-4a1c-ad4c-bc22234559de", new DateTime(2024, 8, 15, 11, 50, 45, 690, DateTimeKind.Utc).AddTicks(8134), new DateTime(2024, 8, 15, 11, 50, 45, 690, DateTimeKind.Utc).AddTicks(8134), new DateTime(2024, 8, 15, 15, 50, 45, 690, DateTimeKind.Local).AddTicks(8128) });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: 2047,
                columns: new[] { "ConcurrencyStamp", "CreatedTime", "LastUpdatedTime", "RefreshTokenCreateTime" },
                values: new object[] { "e725dbc4-2256-4443-8215-2b629277b79f", new DateTime(2024, 8, 15, 11, 50, 45, 690, DateTimeKind.Utc).AddTicks(8148), new DateTime(2024, 8, 15, 11, 50, 45, 690, DateTimeKind.Utc).AddTicks(8149), new DateTime(2024, 8, 15, 15, 50, 45, 690, DateTimeKind.Local).AddTicks(8142) });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: 2048,
                columns: new[] { "ConcurrencyStamp", "CreatedTime", "LastUpdatedTime", "RefreshTokenCreateTime" },
                values: new object[] { "1cd9cb33-6d7d-4250-90eb-5a0566134aa5", new DateTime(2024, 8, 15, 11, 50, 45, 690, DateTimeKind.Utc).AddTicks(8162), new DateTime(2024, 8, 15, 11, 50, 45, 690, DateTimeKind.Utc).AddTicks(8162), new DateTime(2024, 8, 15, 15, 50, 45, 690, DateTimeKind.Local).AddTicks(8156) });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: 2049,
                columns: new[] { "ConcurrencyStamp", "CreatedTime", "LastUpdatedTime", "RefreshTokenCreateTime" },
                values: new object[] { "14b4fbed-1d27-46ed-bcdf-8d04b183e4db", new DateTime(2024, 8, 15, 11, 50, 45, 690, DateTimeKind.Utc).AddTicks(8212), new DateTime(2024, 8, 15, 11, 50, 45, 690, DateTimeKind.Utc).AddTicks(8213), new DateTime(2024, 8, 15, 15, 50, 45, 690, DateTimeKind.Local).AddTicks(8206) });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: 2050,
                columns: new[] { "ConcurrencyStamp", "CreatedTime", "LastUpdatedTime", "RefreshTokenCreateTime" },
                values: new object[] { "d4acc5a8-cb57-4d81-87ea-5aa3ddd2f2ab", new DateTime(2024, 8, 15, 11, 50, 45, 690, DateTimeKind.Utc).AddTicks(8226), new DateTime(2024, 8, 15, 11, 50, 45, 690, DateTimeKind.Utc).AddTicks(8226), new DateTime(2024, 8, 15, 15, 50, 45, 690, DateTimeKind.Local).AddTicks(8220) });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: 2051,
                columns: new[] { "ConcurrencyStamp", "CreatedTime", "LastUpdatedTime", "RefreshTokenCreateTime" },
                values: new object[] { "cf5f71ae-30f9-476f-ab92-4be157847db1", new DateTime(2024, 8, 15, 11, 50, 45, 690, DateTimeKind.Utc).AddTicks(8239), new DateTime(2024, 8, 15, 11, 50, 45, 690, DateTimeKind.Utc).AddTicks(8240), new DateTime(2024, 8, 15, 15, 50, 45, 690, DateTimeKind.Local).AddTicks(8234) });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: 2052,
                columns: new[] { "ConcurrencyStamp", "CreatedTime", "LastUpdatedTime", "RefreshTokenCreateTime" },
                values: new object[] { "38843c6f-ec00-4f29-b92e-bb66720f583f", new DateTime(2024, 8, 15, 11, 50, 45, 690, DateTimeKind.Utc).AddTicks(8257), new DateTime(2024, 8, 15, 11, 50, 45, 690, DateTimeKind.Utc).AddTicks(8257), new DateTime(2024, 8, 15, 15, 50, 45, 690, DateTimeKind.Local).AddTicks(8248) });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: 2053,
                columns: new[] { "ConcurrencyStamp", "CreatedTime", "LastUpdatedTime", "RefreshTokenCreateTime" },
                values: new object[] { "8d3ce59c-1649-4f0f-a440-3431980884bd", new DateTime(2024, 8, 15, 11, 50, 45, 690, DateTimeKind.Utc).AddTicks(8271), new DateTime(2024, 8, 15, 11, 50, 45, 690, DateTimeKind.Utc).AddTicks(8271), new DateTime(2024, 8, 15, 15, 50, 45, 690, DateTimeKind.Local).AddTicks(8265) });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: 2054,
                columns: new[] { "ConcurrencyStamp", "CreatedTime", "LastUpdatedTime", "RefreshTokenCreateTime" },
                values: new object[] { "006a756a-f2cd-45da-aa87-46665c1bc30f", new DateTime(2024, 8, 15, 11, 50, 45, 690, DateTimeKind.Utc).AddTicks(8284), new DateTime(2024, 8, 15, 11, 50, 45, 690, DateTimeKind.Utc).AddTicks(8284), new DateTime(2024, 8, 15, 15, 50, 45, 690, DateTimeKind.Local).AddTicks(8279) });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: 2055,
                columns: new[] { "ConcurrencyStamp", "CreatedTime", "LastUpdatedTime", "RefreshTokenCreateTime" },
                values: new object[] { "2fcd93c3-a324-4190-80c3-efdcfae9763a", new DateTime(2024, 8, 15, 11, 50, 45, 690, DateTimeKind.Utc).AddTicks(8298), new DateTime(2024, 8, 15, 11, 50, 45, 690, DateTimeKind.Utc).AddTicks(8299), new DateTime(2024, 8, 15, 15, 50, 45, 690, DateTimeKind.Local).AddTicks(8292) });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: 2056,
                columns: new[] { "ConcurrencyStamp", "CreatedTime", "LastUpdatedTime", "RefreshTokenCreateTime" },
                values: new object[] { "aa3b6752-278b-4037-bf75-efd373b1ddbc", new DateTime(2024, 8, 15, 11, 50, 45, 690, DateTimeKind.Utc).AddTicks(8312), new DateTime(2024, 8, 15, 11, 50, 45, 690, DateTimeKind.Utc).AddTicks(8312), new DateTime(2024, 8, 15, 15, 50, 45, 690, DateTimeKind.Local).AddTicks(8306) });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: 2057,
                columns: new[] { "ConcurrencyStamp", "CreatedTime", "LastUpdatedTime", "RefreshTokenCreateTime" },
                values: new object[] { "998939e0-95e4-4f60-8908-d82d81ffe857", new DateTime(2024, 8, 15, 11, 50, 45, 690, DateTimeKind.Utc).AddTicks(8325), new DateTime(2024, 8, 15, 11, 50, 45, 690, DateTimeKind.Utc).AddTicks(8326), new DateTime(2024, 8, 15, 15, 50, 45, 690, DateTimeKind.Local).AddTicks(8320) });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: 2058,
                columns: new[] { "ConcurrencyStamp", "CreatedTime", "LastUpdatedTime", "RefreshTokenCreateTime" },
                values: new object[] { "187ecdcc-90d6-4a6e-870c-7630665693fd", new DateTime(2024, 8, 15, 11, 50, 45, 690, DateTimeKind.Utc).AddTicks(8377), new DateTime(2024, 8, 15, 11, 50, 45, 690, DateTimeKind.Utc).AddTicks(8377), new DateTime(2024, 8, 15, 15, 50, 45, 690, DateTimeKind.Local).AddTicks(8371) });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: 2059,
                columns: new[] { "ConcurrencyStamp", "CreatedTime", "LastUpdatedTime", "RefreshTokenCreateTime" },
                values: new object[] { "59c37aeb-3aa2-41b5-a1f1-8d45e7bf9885", new DateTime(2024, 8, 15, 11, 50, 45, 690, DateTimeKind.Utc).AddTicks(8391), new DateTime(2024, 8, 15, 11, 50, 45, 690, DateTimeKind.Utc).AddTicks(8391), new DateTime(2024, 8, 15, 15, 50, 45, 690, DateTimeKind.Local).AddTicks(8386) });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: 2060,
                columns: new[] { "ConcurrencyStamp", "CreatedTime", "LastUpdatedTime", "RefreshTokenCreateTime" },
                values: new object[] { "335b2680-a0aa-45a6-b064-67bdc630a421", new DateTime(2024, 8, 15, 11, 50, 45, 690, DateTimeKind.Utc).AddTicks(8408), new DateTime(2024, 8, 15, 11, 50, 45, 690, DateTimeKind.Utc).AddTicks(8409), new DateTime(2024, 8, 15, 15, 50, 45, 690, DateTimeKind.Local).AddTicks(8399) });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AlterColumn<string>(
                name: "Lastname",
                table: "AspNetUsers",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "",
                oldClrType: typeof(string),
                oldType: "nvarchar(max)",
                oldNullable: true);

            migrationBuilder.AlterColumn<string>(
                name: "Firstname",
                table: "AspNetUsers",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "",
                oldClrType: typeof(string),
                oldType: "nvarchar(max)",
                oldNullable: true);

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: 2001,
                columns: new[] { "ConcurrencyStamp", "CreatedTime", "LastUpdatedTime", "RefreshTokenCreateTime" },
                values: new object[] { "093a95a0-eebb-4b5d-86a8-d018d297c244", new DateTime(2024, 8, 15, 1, 18, 57, 29, DateTimeKind.Utc).AddTicks(6728), new DateTime(2024, 8, 15, 1, 18, 57, 29, DateTimeKind.Utc).AddTicks(6730), new DateTime(2024, 8, 15, 5, 18, 57, 29, DateTimeKind.Local).AddTicks(6612) });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: 2002,
                columns: new[] { "ConcurrencyStamp", "CreatedTime", "LastUpdatedTime", "RefreshTokenCreateTime" },
                values: new object[] { "56684a2e-a6b4-490e-9bd5-0a2d9e3ddb4a", new DateTime(2024, 8, 15, 1, 18, 57, 29, DateTimeKind.Utc).AddTicks(6765), new DateTime(2024, 8, 15, 1, 18, 57, 29, DateTimeKind.Utc).AddTicks(6765), new DateTime(2024, 8, 15, 5, 18, 57, 29, DateTimeKind.Local).AddTicks(6757) });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: 2003,
                columns: new[] { "ConcurrencyStamp", "CreatedTime", "LastUpdatedTime", "RefreshTokenCreateTime" },
                values: new object[] { "5c00c299-6772-4dd5-9c38-bbc7a7306be2", new DateTime(2024, 8, 15, 1, 18, 57, 29, DateTimeKind.Utc).AddTicks(6780), new DateTime(2024, 8, 15, 1, 18, 57, 29, DateTimeKind.Utc).AddTicks(6780), new DateTime(2024, 8, 15, 5, 18, 57, 29, DateTimeKind.Local).AddTicks(6774) });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: 2004,
                columns: new[] { "ConcurrencyStamp", "CreatedTime", "LastUpdatedTime", "RefreshTokenCreateTime" },
                values: new object[] { "26cd4000-7d5f-4fa1-93de-08500d116132", new DateTime(2024, 8, 15, 1, 18, 57, 29, DateTimeKind.Utc).AddTicks(6805), new DateTime(2024, 8, 15, 1, 18, 57, 29, DateTimeKind.Utc).AddTicks(6805), new DateTime(2024, 8, 15, 5, 18, 57, 29, DateTimeKind.Local).AddTicks(6788) });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: 2005,
                columns: new[] { "ConcurrencyStamp", "CreatedTime", "LastUpdatedTime", "RefreshTokenCreateTime" },
                values: new object[] { "fdc7b326-fb28-431a-92d2-fbfdc481d64e", new DateTime(2024, 8, 15, 1, 18, 57, 29, DateTimeKind.Utc).AddTicks(6818), new DateTime(2024, 8, 15, 1, 18, 57, 29, DateTimeKind.Utc).AddTicks(6819), new DateTime(2024, 8, 15, 5, 18, 57, 29, DateTimeKind.Local).AddTicks(6813) });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: 2006,
                columns: new[] { "ConcurrencyStamp", "CreatedTime", "LastUpdatedTime", "RefreshTokenCreateTime" },
                values: new object[] { "852b544e-1be0-4751-9cb9-f8d970c72bb8", new DateTime(2024, 8, 15, 1, 18, 57, 29, DateTimeKind.Utc).AddTicks(6836), new DateTime(2024, 8, 15, 1, 18, 57, 29, DateTimeKind.Utc).AddTicks(6836), new DateTime(2024, 8, 15, 5, 18, 57, 29, DateTimeKind.Local).AddTicks(6830) });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: 2007,
                columns: new[] { "ConcurrencyStamp", "CreatedTime", "LastUpdatedTime", "RefreshTokenCreateTime" },
                values: new object[] { "041a4a0b-609f-40dd-8713-50cda871500d", new DateTime(2024, 8, 15, 1, 18, 57, 29, DateTimeKind.Utc).AddTicks(6849), new DateTime(2024, 8, 15, 1, 18, 57, 29, DateTimeKind.Utc).AddTicks(6849), new DateTime(2024, 8, 15, 5, 18, 57, 29, DateTimeKind.Local).AddTicks(6843) });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: 2008,
                columns: new[] { "ConcurrencyStamp", "CreatedTime", "LastUpdatedTime", "RefreshTokenCreateTime" },
                values: new object[] { "10d157b9-632e-41f1-8b1a-94c984dbd397", new DateTime(2024, 8, 15, 1, 18, 57, 29, DateTimeKind.Utc).AddTicks(6862), new DateTime(2024, 8, 15, 1, 18, 57, 29, DateTimeKind.Utc).AddTicks(6862), new DateTime(2024, 8, 15, 5, 18, 57, 29, DateTimeKind.Local).AddTicks(6856) });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: 2009,
                columns: new[] { "ConcurrencyStamp", "CreatedTime", "LastUpdatedTime", "RefreshTokenCreateTime" },
                values: new object[] { "747b9667-ad40-4f46-a11d-0ac2e85c6224", new DateTime(2024, 8, 15, 1, 18, 57, 29, DateTimeKind.Utc).AddTicks(6943), new DateTime(2024, 8, 15, 1, 18, 57, 29, DateTimeKind.Utc).AddTicks(6943), new DateTime(2024, 8, 15, 5, 18, 57, 29, DateTimeKind.Local).AddTicks(6936) });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: 2010,
                columns: new[] { "ConcurrencyStamp", "CreatedTime", "LastUpdatedTime", "RefreshTokenCreateTime" },
                values: new object[] { "e221100e-0d14-4d92-9054-dbea7404ad6d", new DateTime(2024, 8, 15, 1, 18, 57, 29, DateTimeKind.Utc).AddTicks(6962), new DateTime(2024, 8, 15, 1, 18, 57, 29, DateTimeKind.Utc).AddTicks(6963), new DateTime(2024, 8, 15, 5, 18, 57, 29, DateTimeKind.Local).AddTicks(6952) });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: 2011,
                columns: new[] { "ConcurrencyStamp", "CreatedTime", "LastUpdatedTime", "RefreshTokenCreateTime" },
                values: new object[] { "0cdf4490-e6cc-4880-a8b5-d1c1d8414767", new DateTime(2024, 8, 15, 1, 18, 57, 29, DateTimeKind.Utc).AddTicks(6978), new DateTime(2024, 8, 15, 1, 18, 57, 29, DateTimeKind.Utc).AddTicks(6978), new DateTime(2024, 8, 15, 5, 18, 57, 29, DateTimeKind.Local).AddTicks(6972) });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: 2012,
                columns: new[] { "ConcurrencyStamp", "CreatedTime", "LastUpdatedTime", "RefreshTokenCreateTime" },
                values: new object[] { "78495064-b28b-459d-abbd-2195a6c6c081", new DateTime(2024, 8, 15, 1, 18, 57, 29, DateTimeKind.Utc).AddTicks(6996), new DateTime(2024, 8, 15, 1, 18, 57, 29, DateTimeKind.Utc).AddTicks(6996), new DateTime(2024, 8, 15, 5, 18, 57, 29, DateTimeKind.Local).AddTicks(6986) });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: 2013,
                columns: new[] { "ConcurrencyStamp", "CreatedTime", "LastUpdatedTime", "RefreshTokenCreateTime" },
                values: new object[] { "00b6d6e6-aa9b-439b-8299-a0d78f5cd1c9", new DateTime(2024, 8, 15, 1, 18, 57, 29, DateTimeKind.Utc).AddTicks(7010), new DateTime(2024, 8, 15, 1, 18, 57, 29, DateTimeKind.Utc).AddTicks(7010), new DateTime(2024, 8, 15, 5, 18, 57, 29, DateTimeKind.Local).AddTicks(7004) });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: 2014,
                columns: new[] { "ConcurrencyStamp", "CreatedTime", "LastUpdatedTime", "RefreshTokenCreateTime" },
                values: new object[] { "154680cd-7cf3-445e-9afd-5a0cfa3b7d6f", new DateTime(2024, 8, 15, 1, 18, 57, 29, DateTimeKind.Utc).AddTicks(7023), new DateTime(2024, 8, 15, 1, 18, 57, 29, DateTimeKind.Utc).AddTicks(7024), new DateTime(2024, 8, 15, 5, 18, 57, 29, DateTimeKind.Local).AddTicks(7018) });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: 2015,
                columns: new[] { "ConcurrencyStamp", "CreatedTime", "LastUpdatedTime", "RefreshTokenCreateTime" },
                values: new object[] { "3e9aa146-1329-4004-b69a-3ae5bf0a27bf", new DateTime(2024, 8, 15, 1, 18, 57, 29, DateTimeKind.Utc).AddTicks(7037), new DateTime(2024, 8, 15, 1, 18, 57, 29, DateTimeKind.Utc).AddTicks(7038), new DateTime(2024, 8, 15, 5, 18, 57, 29, DateTimeKind.Local).AddTicks(7032) });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: 2016,
                columns: new[] { "ConcurrencyStamp", "CreatedTime", "LastUpdatedTime", "RefreshTokenCreateTime" },
                values: new object[] { "b39fd919-4049-496e-9c0e-962e50443a24", new DateTime(2024, 8, 15, 1, 18, 57, 29, DateTimeKind.Utc).AddTicks(7051), new DateTime(2024, 8, 15, 1, 18, 57, 29, DateTimeKind.Utc).AddTicks(7052), new DateTime(2024, 8, 15, 5, 18, 57, 29, DateTimeKind.Local).AddTicks(7045) });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: 2017,
                columns: new[] { "ConcurrencyStamp", "CreatedTime", "LastUpdatedTime", "RefreshTokenCreateTime" },
                values: new object[] { "26f43411-4060-4880-84ec-bcf76dc616e1", new DateTime(2024, 8, 15, 1, 18, 57, 29, DateTimeKind.Utc).AddTicks(7064), new DateTime(2024, 8, 15, 1, 18, 57, 29, DateTimeKind.Utc).AddTicks(7065), new DateTime(2024, 8, 15, 5, 18, 57, 29, DateTimeKind.Local).AddTicks(7059) });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: 2018,
                columns: new[] { "ConcurrencyStamp", "CreatedTime", "LastUpdatedTime", "RefreshTokenCreateTime" },
                values: new object[] { "460f9a8a-c9a4-4a3f-863a-ef0eb3c0ce86", new DateTime(2024, 8, 15, 1, 18, 57, 29, DateTimeKind.Utc).AddTicks(7118), new DateTime(2024, 8, 15, 1, 18, 57, 29, DateTimeKind.Utc).AddTicks(7119), new DateTime(2024, 8, 15, 5, 18, 57, 29, DateTimeKind.Local).AddTicks(7112) });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: 2019,
                columns: new[] { "ConcurrencyStamp", "CreatedTime", "LastUpdatedTime", "RefreshTokenCreateTime" },
                values: new object[] { "ecbd6dd6-2987-42b7-8d2e-fb0b4dff8c1a", new DateTime(2024, 8, 15, 1, 18, 57, 29, DateTimeKind.Utc).AddTicks(7133), new DateTime(2024, 8, 15, 1, 18, 57, 29, DateTimeKind.Utc).AddTicks(7133), new DateTime(2024, 8, 15, 5, 18, 57, 29, DateTimeKind.Local).AddTicks(7127) });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: 2020,
                columns: new[] { "ConcurrencyStamp", "CreatedTime", "LastUpdatedTime", "RefreshTokenCreateTime" },
                values: new object[] { "5c858805-fd2a-4cee-990f-edcd1e62c7b1", new DateTime(2024, 8, 15, 1, 18, 57, 29, DateTimeKind.Utc).AddTicks(7149), new DateTime(2024, 8, 15, 1, 18, 57, 29, DateTimeKind.Utc).AddTicks(7150), new DateTime(2024, 8, 15, 5, 18, 57, 29, DateTimeKind.Local).AddTicks(7141) });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: 2021,
                columns: new[] { "ConcurrencyStamp", "CreatedTime", "LastUpdatedTime", "RefreshTokenCreateTime" },
                values: new object[] { "6ebb62af-714a-4765-9bb7-8a8b768bd1c0", new DateTime(2024, 8, 15, 1, 18, 57, 29, DateTimeKind.Utc).AddTicks(7163), new DateTime(2024, 8, 15, 1, 18, 57, 29, DateTimeKind.Utc).AddTicks(7164), new DateTime(2024, 8, 15, 5, 18, 57, 29, DateTimeKind.Local).AddTicks(7158) });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: 2022,
                columns: new[] { "ConcurrencyStamp", "CreatedTime", "LastUpdatedTime", "RefreshTokenCreateTime" },
                values: new object[] { "07b013c8-a5f0-4240-8d01-1764350d5c1b", new DateTime(2024, 8, 15, 1, 18, 57, 29, DateTimeKind.Utc).AddTicks(7184), new DateTime(2024, 8, 15, 1, 18, 57, 29, DateTimeKind.Utc).AddTicks(7184), new DateTime(2024, 8, 15, 5, 18, 57, 29, DateTimeKind.Local).AddTicks(7178) });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: 2023,
                columns: new[] { "ConcurrencyStamp", "CreatedTime", "LastUpdatedTime", "RefreshTokenCreateTime" },
                values: new object[] { "829c5ebe-47dc-4e9f-b694-7c35c8fbe043", new DateTime(2024, 8, 15, 1, 18, 57, 29, DateTimeKind.Utc).AddTicks(7199), new DateTime(2024, 8, 15, 1, 18, 57, 29, DateTimeKind.Utc).AddTicks(7199), new DateTime(2024, 8, 15, 5, 18, 57, 29, DateTimeKind.Local).AddTicks(7193) });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: 2024,
                columns: new[] { "ConcurrencyStamp", "CreatedTime", "LastUpdatedTime", "RefreshTokenCreateTime" },
                values: new object[] { "6a5bcd68-49fb-42fc-a4ef-7b5d9e27c28f", new DateTime(2024, 8, 15, 1, 18, 57, 29, DateTimeKind.Utc).AddTicks(7214), new DateTime(2024, 8, 15, 1, 18, 57, 29, DateTimeKind.Utc).AddTicks(7214), new DateTime(2024, 8, 15, 5, 18, 57, 29, DateTimeKind.Local).AddTicks(7208) });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: 2025,
                columns: new[] { "ConcurrencyStamp", "CreatedTime", "LastUpdatedTime", "RefreshTokenCreateTime" },
                values: new object[] { "da218fad-899c-4975-a6ed-c67e4743eda6", new DateTime(2024, 8, 15, 1, 18, 57, 29, DateTimeKind.Utc).AddTicks(7228), new DateTime(2024, 8, 15, 1, 18, 57, 29, DateTimeKind.Utc).AddTicks(7229), new DateTime(2024, 8, 15, 5, 18, 57, 29, DateTimeKind.Local).AddTicks(7222) });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: 2026,
                columns: new[] { "ConcurrencyStamp", "CreatedTime", "LastUpdatedTime", "RefreshTokenCreateTime" },
                values: new object[] { "3ba5ef6d-1591-46f3-bedb-8a9228f16f07", new DateTime(2024, 8, 15, 1, 18, 57, 29, DateTimeKind.Utc).AddTicks(7278), new DateTime(2024, 8, 15, 1, 18, 57, 29, DateTimeKind.Utc).AddTicks(7279), new DateTime(2024, 8, 15, 5, 18, 57, 29, DateTimeKind.Local).AddTicks(7272) });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: 2027,
                columns: new[] { "ConcurrencyStamp", "CreatedTime", "LastUpdatedTime", "RefreshTokenCreateTime" },
                values: new object[] { "57919dfd-8495-4751-87e1-dcfbd67b7fa6", new DateTime(2024, 8, 15, 1, 18, 57, 29, DateTimeKind.Utc).AddTicks(7292), new DateTime(2024, 8, 15, 1, 18, 57, 29, DateTimeKind.Utc).AddTicks(7293), new DateTime(2024, 8, 15, 5, 18, 57, 29, DateTimeKind.Local).AddTicks(7287) });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: 2028,
                columns: new[] { "ConcurrencyStamp", "CreatedTime", "LastUpdatedTime", "RefreshTokenCreateTime" },
                values: new object[] { "391e9038-a5b3-402f-bfc0-e5e90aca92e0", new DateTime(2024, 8, 15, 1, 18, 57, 29, DateTimeKind.Utc).AddTicks(7309), new DateTime(2024, 8, 15, 1, 18, 57, 29, DateTimeKind.Utc).AddTicks(7310), new DateTime(2024, 8, 15, 5, 18, 57, 29, DateTimeKind.Local).AddTicks(7300) });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: 2029,
                columns: new[] { "ConcurrencyStamp", "CreatedTime", "LastUpdatedTime", "RefreshTokenCreateTime" },
                values: new object[] { "8229783d-4671-4fe1-a745-cc46a0027ae8", new DateTime(2024, 8, 15, 1, 18, 57, 29, DateTimeKind.Utc).AddTicks(7323), new DateTime(2024, 8, 15, 1, 18, 57, 29, DateTimeKind.Utc).AddTicks(7323), new DateTime(2024, 8, 15, 5, 18, 57, 29, DateTimeKind.Local).AddTicks(7317) });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: 2030,
                columns: new[] { "ConcurrencyStamp", "CreatedTime", "LastUpdatedTime", "RefreshTokenCreateTime" },
                values: new object[] { "a33ee509-85b1-4ee2-aba6-2c41996a674c", new DateTime(2024, 8, 15, 1, 18, 57, 29, DateTimeKind.Utc).AddTicks(7336), new DateTime(2024, 8, 15, 1, 18, 57, 29, DateTimeKind.Utc).AddTicks(7337), new DateTime(2024, 8, 15, 5, 18, 57, 29, DateTimeKind.Local).AddTicks(7331) });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: 2031,
                columns: new[] { "ConcurrencyStamp", "CreatedTime", "LastUpdatedTime", "RefreshTokenCreateTime" },
                values: new object[] { "f00ccc51-0a00-415e-9d5d-2ba504aca47e", new DateTime(2024, 8, 15, 1, 18, 57, 29, DateTimeKind.Utc).AddTicks(7350), new DateTime(2024, 8, 15, 1, 18, 57, 29, DateTimeKind.Utc).AddTicks(7351), new DateTime(2024, 8, 15, 5, 18, 57, 29, DateTimeKind.Local).AddTicks(7345) });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: 2032,
                columns: new[] { "ConcurrencyStamp", "CreatedTime", "LastUpdatedTime", "RefreshTokenCreateTime" },
                values: new object[] { "1974fd40-68f4-489b-a35b-f5c007412a82", new DateTime(2024, 8, 15, 1, 18, 57, 29, DateTimeKind.Utc).AddTicks(7364), new DateTime(2024, 8, 15, 1, 18, 57, 29, DateTimeKind.Utc).AddTicks(7364), new DateTime(2024, 8, 15, 5, 18, 57, 29, DateTimeKind.Local).AddTicks(7358) });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: 2033,
                columns: new[] { "ConcurrencyStamp", "CreatedTime", "LastUpdatedTime", "RefreshTokenCreateTime" },
                values: new object[] { "bf718164-f925-4941-8f8d-e5eccc98601f", new DateTime(2024, 8, 15, 1, 18, 57, 29, DateTimeKind.Utc).AddTicks(7377), new DateTime(2024, 8, 15, 1, 18, 57, 29, DateTimeKind.Utc).AddTicks(7378), new DateTime(2024, 8, 15, 5, 18, 57, 29, DateTimeKind.Local).AddTicks(7372) });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: 2034,
                columns: new[] { "ConcurrencyStamp", "CreatedTime", "LastUpdatedTime", "RefreshTokenCreateTime" },
                values: new object[] { "26cb1811-d1a9-4daa-87d7-c6e683606cf8", new DateTime(2024, 8, 15, 1, 18, 57, 29, DateTimeKind.Utc).AddTicks(7429), new DateTime(2024, 8, 15, 1, 18, 57, 29, DateTimeKind.Utc).AddTicks(7429), new DateTime(2024, 8, 15, 5, 18, 57, 29, DateTimeKind.Local).AddTicks(7387) });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: 2035,
                columns: new[] { "ConcurrencyStamp", "CreatedTime", "LastUpdatedTime", "RefreshTokenCreateTime" },
                values: new object[] { "2f873d08-b9b8-46f8-9a27-c0e1bfc30630", new DateTime(2024, 8, 15, 1, 18, 57, 29, DateTimeKind.Utc).AddTicks(7444), new DateTime(2024, 8, 15, 1, 18, 57, 29, DateTimeKind.Utc).AddTicks(7444), new DateTime(2024, 8, 15, 5, 18, 57, 29, DateTimeKind.Local).AddTicks(7437) });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: 2036,
                columns: new[] { "ConcurrencyStamp", "CreatedTime", "LastUpdatedTime", "RefreshTokenCreateTime" },
                values: new object[] { "c898ffd2-a1f0-42c4-8ee0-480001feae59", new DateTime(2024, 8, 15, 1, 18, 57, 29, DateTimeKind.Utc).AddTicks(7461), new DateTime(2024, 8, 15, 1, 18, 57, 29, DateTimeKind.Utc).AddTicks(7462), new DateTime(2024, 8, 15, 5, 18, 57, 29, DateTimeKind.Local).AddTicks(7452) });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: 2037,
                columns: new[] { "ConcurrencyStamp", "CreatedTime", "LastUpdatedTime", "RefreshTokenCreateTime" },
                values: new object[] { "94a1b31a-2a3d-4d17-9bff-738217d5b4f0", new DateTime(2024, 8, 15, 1, 18, 57, 29, DateTimeKind.Utc).AddTicks(7476), new DateTime(2024, 8, 15, 1, 18, 57, 29, DateTimeKind.Utc).AddTicks(7476), new DateTime(2024, 8, 15, 5, 18, 57, 29, DateTimeKind.Local).AddTicks(7470) });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: 2038,
                columns: new[] { "ConcurrencyStamp", "CreatedTime", "LastUpdatedTime", "RefreshTokenCreateTime" },
                values: new object[] { "744a5b20-aa80-4c70-b4a4-c04dae7ec527", new DateTime(2024, 8, 15, 1, 18, 57, 29, DateTimeKind.Utc).AddTicks(7490), new DateTime(2024, 8, 15, 1, 18, 57, 29, DateTimeKind.Utc).AddTicks(7490), new DateTime(2024, 8, 15, 5, 18, 57, 29, DateTimeKind.Local).AddTicks(7484) });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: 2039,
                columns: new[] { "ConcurrencyStamp", "CreatedTime", "LastUpdatedTime", "RefreshTokenCreateTime" },
                values: new object[] { "44eba794-bf8b-476a-b68e-4c78b99037c5", new DateTime(2024, 8, 15, 1, 18, 57, 29, DateTimeKind.Utc).AddTicks(7504), new DateTime(2024, 8, 15, 1, 18, 57, 29, DateTimeKind.Utc).AddTicks(7504), new DateTime(2024, 8, 15, 5, 18, 57, 29, DateTimeKind.Local).AddTicks(7499) });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: 2040,
                columns: new[] { "ConcurrencyStamp", "CreatedTime", "LastUpdatedTime", "RefreshTokenCreateTime" },
                values: new object[] { "6bf04544-4a86-492a-aee3-0d5a4c97d1be", new DateTime(2024, 8, 15, 1, 18, 57, 29, DateTimeKind.Utc).AddTicks(7518), new DateTime(2024, 8, 15, 1, 18, 57, 29, DateTimeKind.Utc).AddTicks(7518), new DateTime(2024, 8, 15, 5, 18, 57, 29, DateTimeKind.Local).AddTicks(7512) });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: 2041,
                columns: new[] { "ConcurrencyStamp", "CreatedTime", "LastUpdatedTime", "RefreshTokenCreateTime" },
                values: new object[] { "9f70f20e-2abe-4235-84d6-a50198fd2ac6", new DateTime(2024, 8, 15, 1, 18, 57, 29, DateTimeKind.Utc).AddTicks(7531), new DateTime(2024, 8, 15, 1, 18, 57, 29, DateTimeKind.Utc).AddTicks(7531), new DateTime(2024, 8, 15, 5, 18, 57, 29, DateTimeKind.Local).AddTicks(7526) });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: 2042,
                columns: new[] { "ConcurrencyStamp", "CreatedTime", "LastUpdatedTime", "RefreshTokenCreateTime" },
                values: new object[] { "fb3c776b-39bc-4452-a1be-72f9bd3712e4", new DateTime(2024, 8, 15, 1, 18, 57, 29, DateTimeKind.Utc).AddTicks(7551), new DateTime(2024, 8, 15, 1, 18, 57, 29, DateTimeKind.Utc).AddTicks(7551), new DateTime(2024, 8, 15, 5, 18, 57, 29, DateTimeKind.Local).AddTicks(7546) });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: 2043,
                columns: new[] { "ConcurrencyStamp", "CreatedTime", "LastUpdatedTime", "RefreshTokenCreateTime" },
                values: new object[] { "ffc0bb7b-9b42-4006-800b-93f9d1f338ca", new DateTime(2024, 8, 15, 1, 18, 57, 29, DateTimeKind.Utc).AddTicks(7602), new DateTime(2024, 8, 15, 1, 18, 57, 29, DateTimeKind.Utc).AddTicks(7602), new DateTime(2024, 8, 15, 5, 18, 57, 29, DateTimeKind.Local).AddTicks(7560) });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: 2044,
                columns: new[] { "ConcurrencyStamp", "CreatedTime", "LastUpdatedTime", "RefreshTokenCreateTime" },
                values: new object[] { "113524f1-cd5a-4c12-9376-ce5e7f60181b", new DateTime(2024, 8, 15, 1, 18, 57, 29, DateTimeKind.Utc).AddTicks(7619), new DateTime(2024, 8, 15, 1, 18, 57, 29, DateTimeKind.Utc).AddTicks(7620), new DateTime(2024, 8, 15, 5, 18, 57, 29, DateTimeKind.Local).AddTicks(7610) });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: 2045,
                columns: new[] { "ConcurrencyStamp", "CreatedTime", "LastUpdatedTime", "RefreshTokenCreateTime" },
                values: new object[] { "764f6c0f-420c-46dd-8a58-f7d7800a4b0c", new DateTime(2024, 8, 15, 1, 18, 57, 29, DateTimeKind.Utc).AddTicks(7633), new DateTime(2024, 8, 15, 1, 18, 57, 29, DateTimeKind.Utc).AddTicks(7634), new DateTime(2024, 8, 15, 5, 18, 57, 29, DateTimeKind.Local).AddTicks(7627) });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: 2046,
                columns: new[] { "ConcurrencyStamp", "CreatedTime", "LastUpdatedTime", "RefreshTokenCreateTime" },
                values: new object[] { "74bb4455-e760-49ad-bbc8-f19122966604", new DateTime(2024, 8, 15, 1, 18, 57, 29, DateTimeKind.Utc).AddTicks(7647), new DateTime(2024, 8, 15, 1, 18, 57, 29, DateTimeKind.Utc).AddTicks(7648), new DateTime(2024, 8, 15, 5, 18, 57, 29, DateTimeKind.Local).AddTicks(7642) });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: 2047,
                columns: new[] { "ConcurrencyStamp", "CreatedTime", "LastUpdatedTime", "RefreshTokenCreateTime" },
                values: new object[] { "afb668f0-49a5-4dbd-9b9d-d6ec8f22964b", new DateTime(2024, 8, 15, 1, 18, 57, 29, DateTimeKind.Utc).AddTicks(7661), new DateTime(2024, 8, 15, 1, 18, 57, 29, DateTimeKind.Utc).AddTicks(7661), new DateTime(2024, 8, 15, 5, 18, 57, 29, DateTimeKind.Local).AddTicks(7655) });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: 2048,
                columns: new[] { "ConcurrencyStamp", "CreatedTime", "LastUpdatedTime", "RefreshTokenCreateTime" },
                values: new object[] { "7fddc4fe-a1fb-4942-8b5b-164036952d60", new DateTime(2024, 8, 15, 1, 18, 57, 29, DateTimeKind.Utc).AddTicks(7674), new DateTime(2024, 8, 15, 1, 18, 57, 29, DateTimeKind.Utc).AddTicks(7675), new DateTime(2024, 8, 15, 5, 18, 57, 29, DateTimeKind.Local).AddTicks(7668) });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: 2049,
                columns: new[] { "ConcurrencyStamp", "CreatedTime", "LastUpdatedTime", "RefreshTokenCreateTime" },
                values: new object[] { "7f653a20-6a6a-463b-8824-8bec8e549f9f", new DateTime(2024, 8, 15, 1, 18, 57, 29, DateTimeKind.Utc).AddTicks(7687), new DateTime(2024, 8, 15, 1, 18, 57, 29, DateTimeKind.Utc).AddTicks(7688), new DateTime(2024, 8, 15, 5, 18, 57, 29, DateTimeKind.Local).AddTicks(7682) });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: 2050,
                columns: new[] { "ConcurrencyStamp", "CreatedTime", "LastUpdatedTime", "RefreshTokenCreateTime" },
                values: new object[] { "1644d690-b619-4af3-b4ea-05dbd57009da", new DateTime(2024, 8, 15, 1, 18, 57, 29, DateTimeKind.Utc).AddTicks(7701), new DateTime(2024, 8, 15, 1, 18, 57, 29, DateTimeKind.Utc).AddTicks(7701), new DateTime(2024, 8, 15, 5, 18, 57, 29, DateTimeKind.Local).AddTicks(7695) });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: 2051,
                columns: new[] { "ConcurrencyStamp", "CreatedTime", "LastUpdatedTime", "RefreshTokenCreateTime" },
                values: new object[] { "d99ed03f-cb5a-4ea5-9ac3-262da6ada0a3", new DateTime(2024, 8, 15, 1, 18, 57, 29, DateTimeKind.Utc).AddTicks(7714), new DateTime(2024, 8, 15, 1, 18, 57, 29, DateTimeKind.Utc).AddTicks(7715), new DateTime(2024, 8, 15, 5, 18, 57, 29, DateTimeKind.Local).AddTicks(7709) });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: 2052,
                columns: new[] { "ConcurrencyStamp", "CreatedTime", "LastUpdatedTime", "RefreshTokenCreateTime" },
                values: new object[] { "f6b58b62-3387-41a1-8a43-c4c7e88104e3", new DateTime(2024, 8, 15, 1, 18, 57, 29, DateTimeKind.Utc).AddTicks(7731), new DateTime(2024, 8, 15, 1, 18, 57, 29, DateTimeKind.Utc).AddTicks(7731), new DateTime(2024, 8, 15, 5, 18, 57, 29, DateTimeKind.Local).AddTicks(7722) });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: 2053,
                columns: new[] { "ConcurrencyStamp", "CreatedTime", "LastUpdatedTime", "RefreshTokenCreateTime" },
                values: new object[] { "0492da3c-3e43-49a6-9235-6645d83ce1a5", new DateTime(2024, 8, 15, 1, 18, 57, 29, DateTimeKind.Utc).AddTicks(7780), new DateTime(2024, 8, 15, 1, 18, 57, 29, DateTimeKind.Utc).AddTicks(7780), new DateTime(2024, 8, 15, 5, 18, 57, 29, DateTimeKind.Local).AddTicks(7774) });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: 2054,
                columns: new[] { "ConcurrencyStamp", "CreatedTime", "LastUpdatedTime", "RefreshTokenCreateTime" },
                values: new object[] { "7591732b-3f4a-4fd8-9431-81c2e775e6a7", new DateTime(2024, 8, 15, 1, 18, 57, 29, DateTimeKind.Utc).AddTicks(7794), new DateTime(2024, 8, 15, 1, 18, 57, 29, DateTimeKind.Utc).AddTicks(7794), new DateTime(2024, 8, 15, 5, 18, 57, 29, DateTimeKind.Local).AddTicks(7788) });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: 2055,
                columns: new[] { "ConcurrencyStamp", "CreatedTime", "LastUpdatedTime", "RefreshTokenCreateTime" },
                values: new object[] { "58d5fa13-6eee-41d8-9953-3458e35f0f5a", new DateTime(2024, 8, 15, 1, 18, 57, 29, DateTimeKind.Utc).AddTicks(7807), new DateTime(2024, 8, 15, 1, 18, 57, 29, DateTimeKind.Utc).AddTicks(7808), new DateTime(2024, 8, 15, 5, 18, 57, 29, DateTimeKind.Local).AddTicks(7802) });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: 2056,
                columns: new[] { "ConcurrencyStamp", "CreatedTime", "LastUpdatedTime", "RefreshTokenCreateTime" },
                values: new object[] { "b0a86d80-1442-47ce-a02e-6687893d5b68", new DateTime(2024, 8, 15, 1, 18, 57, 29, DateTimeKind.Utc).AddTicks(7821), new DateTime(2024, 8, 15, 1, 18, 57, 29, DateTimeKind.Utc).AddTicks(7821), new DateTime(2024, 8, 15, 5, 18, 57, 29, DateTimeKind.Local).AddTicks(7815) });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: 2057,
                columns: new[] { "ConcurrencyStamp", "CreatedTime", "LastUpdatedTime", "RefreshTokenCreateTime" },
                values: new object[] { "aad9537e-d99a-430f-89f0-d0b49b8f3afe", new DateTime(2024, 8, 15, 1, 18, 57, 29, DateTimeKind.Utc).AddTicks(7834), new DateTime(2024, 8, 15, 1, 18, 57, 29, DateTimeKind.Utc).AddTicks(7835), new DateTime(2024, 8, 15, 5, 18, 57, 29, DateTimeKind.Local).AddTicks(7829) });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: 2058,
                columns: new[] { "ConcurrencyStamp", "CreatedTime", "LastUpdatedTime", "RefreshTokenCreateTime" },
                values: new object[] { "84bf252f-fe5b-4cc1-93ab-c9e1b5bdb5cf", new DateTime(2024, 8, 15, 1, 18, 57, 29, DateTimeKind.Utc).AddTicks(7848), new DateTime(2024, 8, 15, 1, 18, 57, 29, DateTimeKind.Utc).AddTicks(7848), new DateTime(2024, 8, 15, 5, 18, 57, 29, DateTimeKind.Local).AddTicks(7842) });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: 2059,
                columns: new[] { "ConcurrencyStamp", "CreatedTime", "LastUpdatedTime", "RefreshTokenCreateTime" },
                values: new object[] { "c5f541d1-9ecd-46ee-ba81-ad0f336d9f0d", new DateTime(2024, 8, 15, 1, 18, 57, 29, DateTimeKind.Utc).AddTicks(7861), new DateTime(2024, 8, 15, 1, 18, 57, 29, DateTimeKind.Utc).AddTicks(7862), new DateTime(2024, 8, 15, 5, 18, 57, 29, DateTimeKind.Local).AddTicks(7856) });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: 2060,
                columns: new[] { "ConcurrencyStamp", "CreatedTime", "LastUpdatedTime", "RefreshTokenCreateTime" },
                values: new object[] { "932e1440-cdf2-45d2-9325-c0aea854212b", new DateTime(2024, 8, 15, 1, 18, 57, 29, DateTimeKind.Utc).AddTicks(7878), new DateTime(2024, 8, 15, 1, 18, 57, 29, DateTimeKind.Utc).AddTicks(7878), new DateTime(2024, 8, 15, 5, 18, 57, 29, DateTimeKind.Local).AddTicks(7869) });
        }
    }
}
