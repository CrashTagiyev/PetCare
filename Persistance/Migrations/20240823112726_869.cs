using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Persistance.Migrations
{
    /// <inheritdoc />
    public partial class _869 : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<string>(
                name: "ShelterImageUrl",
                table: "Shelters",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: 2001,
                columns: new[] { "ConcurrencyStamp", "CreatedTime", "LastUpdatedTime", "RefreshTokenCreateTime" },
                values: new object[] { "68a2bdbb-8e0e-4e8b-92b1-59e401c7717c", new DateTime(2024, 8, 23, 11, 27, 24, 905, DateTimeKind.Utc).AddTicks(3165), new DateTime(2024, 8, 23, 11, 27, 24, 905, DateTimeKind.Utc).AddTicks(3167), new DateTime(2024, 8, 23, 11, 27, 24, 905, DateTimeKind.Utc).AddTicks(3094) });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: 2002,
                columns: new[] { "ConcurrencyStamp", "CreatedTime", "LastUpdatedTime", "RefreshTokenCreateTime" },
                values: new object[] { "2f0c22f2-0c59-4b9a-8e03-c69b13d4379b", new DateTime(2024, 8, 23, 11, 27, 24, 905, DateTimeKind.Utc).AddTicks(3225), new DateTime(2024, 8, 23, 11, 27, 24, 905, DateTimeKind.Utc).AddTicks(3226), new DateTime(2024, 8, 23, 11, 27, 24, 905, DateTimeKind.Utc).AddTicks(3221) });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: 2003,
                columns: new[] { "ConcurrencyStamp", "CreatedTime", "LastUpdatedTime", "RefreshTokenCreateTime" },
                values: new object[] { "aec56c87-c5a8-486f-be0e-d2a647bffbcb", new DateTime(2024, 8, 23, 11, 27, 24, 905, DateTimeKind.Utc).AddTicks(3240), new DateTime(2024, 8, 23, 11, 27, 24, 905, DateTimeKind.Utc).AddTicks(3240), new DateTime(2024, 8, 23, 11, 27, 24, 905, DateTimeKind.Utc).AddTicks(3236) });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: 2004,
                columns: new[] { "ConcurrencyStamp", "CreatedTime", "LastUpdatedTime", "RefreshTokenCreateTime" },
                values: new object[] { "efd6b6c0-d2f7-41b6-8778-170c2b8e8071", new DateTime(2024, 8, 23, 11, 27, 24, 905, DateTimeKind.Utc).AddTicks(3251), new DateTime(2024, 8, 23, 11, 27, 24, 905, DateTimeKind.Utc).AddTicks(3252), new DateTime(2024, 8, 23, 11, 27, 24, 905, DateTimeKind.Utc).AddTicks(3248) });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: 2005,
                columns: new[] { "ConcurrencyStamp", "CreatedTime", "LastUpdatedTime", "RefreshTokenCreateTime" },
                values: new object[] { "1d7c8a41-342f-4e58-aeb1-6539f89b24ae", new DateTime(2024, 8, 23, 11, 27, 24, 905, DateTimeKind.Utc).AddTicks(3262), new DateTime(2024, 8, 23, 11, 27, 24, 905, DateTimeKind.Utc).AddTicks(3263), new DateTime(2024, 8, 23, 11, 27, 24, 905, DateTimeKind.Utc).AddTicks(3259) });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: 2006,
                columns: new[] { "ConcurrencyStamp", "CreatedTime", "LastUpdatedTime", "RefreshTokenCreateTime" },
                values: new object[] { "4bc69c00-f688-4ade-9264-b44b61b170d8", new DateTime(2024, 8, 23, 11, 27, 24, 905, DateTimeKind.Utc).AddTicks(3277), new DateTime(2024, 8, 23, 11, 27, 24, 905, DateTimeKind.Utc).AddTicks(3278), new DateTime(2024, 8, 23, 11, 27, 24, 905, DateTimeKind.Utc).AddTicks(3275) });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: 2007,
                columns: new[] { "ConcurrencyStamp", "CreatedTime", "LastUpdatedTime", "RefreshTokenCreateTime" },
                values: new object[] { "eca8dae2-1e3d-4c17-b033-eaaab502ced6", new DateTime(2024, 8, 23, 11, 27, 24, 905, DateTimeKind.Utc).AddTicks(3289), new DateTime(2024, 8, 23, 11, 27, 24, 905, DateTimeKind.Utc).AddTicks(3289), new DateTime(2024, 8, 23, 11, 27, 24, 905, DateTimeKind.Utc).AddTicks(3286) });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: 2008,
                columns: new[] { "ConcurrencyStamp", "CreatedTime", "LastUpdatedTime", "RefreshTokenCreateTime" },
                values: new object[] { "9252932c-d9b8-4646-a9f7-18aca7e5061c", new DateTime(2024, 8, 23, 11, 27, 24, 905, DateTimeKind.Utc).AddTicks(3393), new DateTime(2024, 8, 23, 11, 27, 24, 905, DateTimeKind.Utc).AddTicks(3393), new DateTime(2024, 8, 23, 11, 27, 24, 905, DateTimeKind.Utc).AddTicks(3377) });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: 2009,
                columns: new[] { "ConcurrencyStamp", "CreatedTime", "LastUpdatedTime", "RefreshTokenCreateTime" },
                values: new object[] { "7fb1529a-bead-4023-8c03-5784fbd6d076", new DateTime(2024, 8, 23, 11, 27, 24, 905, DateTimeKind.Utc).AddTicks(3406), new DateTime(2024, 8, 23, 11, 27, 24, 905, DateTimeKind.Utc).AddTicks(3407), new DateTime(2024, 8, 23, 11, 27, 24, 905, DateTimeKind.Utc).AddTicks(3403) });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: 2010,
                columns: new[] { "ConcurrencyStamp", "CreatedTime", "LastUpdatedTime", "RefreshTokenCreateTime" },
                values: new object[] { "4afe4aa0-078e-4233-bc99-3181f4b3c8e2", new DateTime(2024, 8, 23, 11, 27, 24, 905, DateTimeKind.Utc).AddTicks(3419), new DateTime(2024, 8, 23, 11, 27, 24, 905, DateTimeKind.Utc).AddTicks(3420), new DateTime(2024, 8, 23, 11, 27, 24, 905, DateTimeKind.Utc).AddTicks(3416) });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: 2011,
                columns: new[] { "ConcurrencyStamp", "CreatedTime", "LastUpdatedTime", "RefreshTokenCreateTime" },
                values: new object[] { "5c0a284c-037c-4c71-95bc-02d3304c54f8", new DateTime(2024, 8, 23, 11, 27, 24, 905, DateTimeKind.Utc).AddTicks(3434), new DateTime(2024, 8, 23, 11, 27, 24, 905, DateTimeKind.Utc).AddTicks(3434), new DateTime(2024, 8, 23, 11, 27, 24, 905, DateTimeKind.Utc).AddTicks(3431) });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: 2012,
                columns: new[] { "ConcurrencyStamp", "CreatedTime", "LastUpdatedTime", "RefreshTokenCreateTime" },
                values: new object[] { "3a7efcfa-9538-4349-a5b9-232a076a27f6", new DateTime(2024, 8, 23, 11, 27, 24, 905, DateTimeKind.Utc).AddTicks(3445), new DateTime(2024, 8, 23, 11, 27, 24, 905, DateTimeKind.Utc).AddTicks(3446), new DateTime(2024, 8, 23, 11, 27, 24, 905, DateTimeKind.Utc).AddTicks(3442) });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: 2013,
                columns: new[] { "ConcurrencyStamp", "CreatedTime", "LastUpdatedTime", "RefreshTokenCreateTime" },
                values: new object[] { "f679f746-0884-47d1-bda1-fe1e7528e0e1", new DateTime(2024, 8, 23, 11, 27, 24, 905, DateTimeKind.Utc).AddTicks(3457), new DateTime(2024, 8, 23, 11, 27, 24, 905, DateTimeKind.Utc).AddTicks(3457), new DateTime(2024, 8, 23, 11, 27, 24, 905, DateTimeKind.Utc).AddTicks(3454) });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: 2014,
                columns: new[] { "ConcurrencyStamp", "CreatedTime", "LastUpdatedTime", "RefreshTokenCreateTime" },
                values: new object[] { "b7883c46-e6cd-4650-8237-98abf7023202", new DateTime(2024, 8, 23, 11, 27, 24, 905, DateTimeKind.Utc).AddTicks(3469), new DateTime(2024, 8, 23, 11, 27, 24, 905, DateTimeKind.Utc).AddTicks(3469), new DateTime(2024, 8, 23, 11, 27, 24, 905, DateTimeKind.Utc).AddTicks(3466) });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: 2015,
                columns: new[] { "ConcurrencyStamp", "CreatedTime", "LastUpdatedTime", "RefreshTokenCreateTime" },
                values: new object[] { "15fc39e5-f38c-45f4-85ab-ac8c41b0cf21", new DateTime(2024, 8, 23, 11, 27, 24, 905, DateTimeKind.Utc).AddTicks(3480), new DateTime(2024, 8, 23, 11, 27, 24, 905, DateTimeKind.Utc).AddTicks(3480), new DateTime(2024, 8, 23, 11, 27, 24, 905, DateTimeKind.Utc).AddTicks(3477) });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: 2016,
                columns: new[] { "ConcurrencyStamp", "CreatedTime", "LastUpdatedTime", "RefreshTokenCreateTime" },
                values: new object[] { "f200b7bd-835e-4758-ac9f-f84a82f2be42", new DateTime(2024, 8, 23, 11, 27, 24, 905, DateTimeKind.Utc).AddTicks(3494), new DateTime(2024, 8, 23, 11, 27, 24, 905, DateTimeKind.Utc).AddTicks(3495), new DateTime(2024, 8, 23, 11, 27, 24, 905, DateTimeKind.Utc).AddTicks(3488) });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: 2017,
                columns: new[] { "ConcurrencyStamp", "CreatedTime", "LastUpdatedTime", "RefreshTokenCreateTime" },
                values: new object[] { "6b87077e-3cfa-4345-9f5d-b52c0f2c9b66", new DateTime(2024, 8, 23, 11, 27, 24, 905, DateTimeKind.Utc).AddTicks(3506), new DateTime(2024, 8, 23, 11, 27, 24, 905, DateTimeKind.Utc).AddTicks(3506), new DateTime(2024, 8, 23, 11, 27, 24, 905, DateTimeKind.Utc).AddTicks(3503) });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: 2018,
                columns: new[] { "ConcurrencyStamp", "CreatedTime", "LastUpdatedTime", "RefreshTokenCreateTime" },
                values: new object[] { "6ee84622-2d78-49e0-a985-a8f11ae65cf9", new DateTime(2024, 8, 23, 11, 27, 24, 905, DateTimeKind.Utc).AddTicks(3572), new DateTime(2024, 8, 23, 11, 27, 24, 905, DateTimeKind.Utc).AddTicks(3572), new DateTime(2024, 8, 23, 11, 27, 24, 905, DateTimeKind.Utc).AddTicks(3569) });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: 2019,
                columns: new[] { "ConcurrencyStamp", "CreatedTime", "LastUpdatedTime", "RefreshTokenCreateTime" },
                values: new object[] { "84eb7fe5-408a-47bf-abc0-9c651402f397", new DateTime(2024, 8, 23, 11, 27, 24, 905, DateTimeKind.Utc).AddTicks(3584), new DateTime(2024, 8, 23, 11, 27, 24, 905, DateTimeKind.Utc).AddTicks(3584), new DateTime(2024, 8, 23, 11, 27, 24, 905, DateTimeKind.Utc).AddTicks(3581) });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: 2020,
                columns: new[] { "ConcurrencyStamp", "CreatedTime", "LastUpdatedTime", "RefreshTokenCreateTime" },
                values: new object[] { "1e39d566-0b1b-4c5d-8114-831e00043b24", new DateTime(2024, 8, 23, 11, 27, 24, 905, DateTimeKind.Utc).AddTicks(3595), new DateTime(2024, 8, 23, 11, 27, 24, 905, DateTimeKind.Utc).AddTicks(3596), new DateTime(2024, 8, 23, 11, 27, 24, 905, DateTimeKind.Utc).AddTicks(3592) });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: 2021,
                columns: new[] { "ConcurrencyStamp", "CreatedTime", "LastUpdatedTime", "RefreshTokenCreateTime" },
                values: new object[] { "96de93cc-dfec-4bad-ad30-7f266302e1e1", new DateTime(2024, 8, 23, 11, 27, 24, 905, DateTimeKind.Utc).AddTicks(3606), new DateTime(2024, 8, 23, 11, 27, 24, 905, DateTimeKind.Utc).AddTicks(3607), new DateTime(2024, 8, 23, 11, 27, 24, 905, DateTimeKind.Utc).AddTicks(3603) });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: 2022,
                columns: new[] { "ConcurrencyStamp", "CreatedTime", "LastUpdatedTime", "RefreshTokenCreateTime" },
                values: new object[] { "ee00ae93-ecf2-4be1-9773-1c58a013cd01", new DateTime(2024, 8, 23, 11, 27, 24, 905, DateTimeKind.Utc).AddTicks(3626), new DateTime(2024, 8, 23, 11, 27, 24, 905, DateTimeKind.Utc).AddTicks(3626), new DateTime(2024, 8, 23, 11, 27, 24, 905, DateTimeKind.Utc).AddTicks(3623) });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: 2023,
                columns: new[] { "ConcurrencyStamp", "CreatedTime", "LastUpdatedTime", "RefreshTokenCreateTime" },
                values: new object[] { "83f58708-879d-4058-a473-c7cd6df93155", new DateTime(2024, 8, 23, 11, 27, 24, 905, DateTimeKind.Utc).AddTicks(3639), new DateTime(2024, 8, 23, 11, 27, 24, 905, DateTimeKind.Utc).AddTicks(3639), new DateTime(2024, 8, 23, 11, 27, 24, 905, DateTimeKind.Utc).AddTicks(3636) });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: 2024,
                columns: new[] { "ConcurrencyStamp", "CreatedTime", "LastUpdatedTime", "RefreshTokenCreateTime" },
                values: new object[] { "d72a0f2c-a9b1-4035-bcff-2b55fe132dbc", new DateTime(2024, 8, 23, 11, 27, 24, 905, DateTimeKind.Utc).AddTicks(3654), new DateTime(2024, 8, 23, 11, 27, 24, 905, DateTimeKind.Utc).AddTicks(3655), new DateTime(2024, 8, 23, 11, 27, 24, 905, DateTimeKind.Utc).AddTicks(3648) });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: 2025,
                columns: new[] { "ConcurrencyStamp", "CreatedTime", "LastUpdatedTime", "RefreshTokenCreateTime" },
                values: new object[] { "7bdde75c-4c44-4cb1-ad88-67e443686a2b", new DateTime(2024, 8, 23, 11, 27, 24, 905, DateTimeKind.Utc).AddTicks(3667), new DateTime(2024, 8, 23, 11, 27, 24, 905, DateTimeKind.Utc).AddTicks(3667), new DateTime(2024, 8, 23, 11, 27, 24, 905, DateTimeKind.Utc).AddTicks(3664) });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: 2026,
                columns: new[] { "ConcurrencyStamp", "CreatedTime", "LastUpdatedTime", "RefreshTokenCreateTime" },
                values: new object[] { "8f16a2af-10e9-4b65-9149-d4a65193c8e8", new DateTime(2024, 8, 23, 11, 27, 24, 905, DateTimeKind.Utc).AddTicks(3679), new DateTime(2024, 8, 23, 11, 27, 24, 905, DateTimeKind.Utc).AddTicks(3680), new DateTime(2024, 8, 23, 11, 27, 24, 905, DateTimeKind.Utc).AddTicks(3676) });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: 2027,
                columns: new[] { "ConcurrencyStamp", "CreatedTime", "LastUpdatedTime", "RefreshTokenCreateTime" },
                values: new object[] { "346fa2c4-9380-44d3-8b7e-b4c78e9b029d", new DateTime(2024, 8, 23, 11, 27, 24, 905, DateTimeKind.Utc).AddTicks(3728), new DateTime(2024, 8, 23, 11, 27, 24, 905, DateTimeKind.Utc).AddTicks(3728), new DateTime(2024, 8, 23, 11, 27, 24, 905, DateTimeKind.Utc).AddTicks(3724) });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: 2028,
                columns: new[] { "ConcurrencyStamp", "CreatedTime", "LastUpdatedTime", "RefreshTokenCreateTime" },
                values: new object[] { "7b6f9f31-25c2-441d-959e-dc24345518bc", new DateTime(2024, 8, 23, 11, 27, 24, 905, DateTimeKind.Utc).AddTicks(3740), new DateTime(2024, 8, 23, 11, 27, 24, 905, DateTimeKind.Utc).AddTicks(3741), new DateTime(2024, 8, 23, 11, 27, 24, 905, DateTimeKind.Utc).AddTicks(3737) });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: 2029,
                columns: new[] { "ConcurrencyStamp", "CreatedTime", "LastUpdatedTime", "RefreshTokenCreateTime" },
                values: new object[] { "b335b848-0a69-4c60-a463-920851273fe8", new DateTime(2024, 8, 23, 11, 27, 24, 905, DateTimeKind.Utc).AddTicks(3752), new DateTime(2024, 8, 23, 11, 27, 24, 905, DateTimeKind.Utc).AddTicks(3753), new DateTime(2024, 8, 23, 11, 27, 24, 905, DateTimeKind.Utc).AddTicks(3749) });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: 2030,
                columns: new[] { "ConcurrencyStamp", "CreatedTime", "LastUpdatedTime", "RefreshTokenCreateTime" },
                values: new object[] { "003eca8b-5647-4da3-8c80-c7f180328306", new DateTime(2024, 8, 23, 11, 27, 24, 905, DateTimeKind.Utc).AddTicks(3765), new DateTime(2024, 8, 23, 11, 27, 24, 905, DateTimeKind.Utc).AddTicks(3765), new DateTime(2024, 8, 23, 11, 27, 24, 905, DateTimeKind.Utc).AddTicks(3762) });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: 2031,
                columns: new[] { "ConcurrencyStamp", "CreatedTime", "LastUpdatedTime", "RefreshTokenCreateTime" },
                values: new object[] { "00ac538e-a1f0-4e10-a039-74be7869a3e2", new DateTime(2024, 8, 23, 11, 27, 24, 905, DateTimeKind.Utc).AddTicks(3777), new DateTime(2024, 8, 23, 11, 27, 24, 905, DateTimeKind.Utc).AddTicks(3778), new DateTime(2024, 8, 23, 11, 27, 24, 905, DateTimeKind.Utc).AddTicks(3774) });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: 2032,
                columns: new[] { "ConcurrencyStamp", "CreatedTime", "LastUpdatedTime", "RefreshTokenCreateTime" },
                values: new object[] { "d5fe06d0-19c6-44fb-96a7-2b10f0b3e8b5", new DateTime(2024, 8, 23, 11, 27, 24, 905, DateTimeKind.Utc).AddTicks(3792), new DateTime(2024, 8, 23, 11, 27, 24, 905, DateTimeKind.Utc).AddTicks(3793), new DateTime(2024, 8, 23, 11, 27, 24, 905, DateTimeKind.Utc).AddTicks(3786) });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: 2033,
                columns: new[] { "ConcurrencyStamp", "CreatedTime", "LastUpdatedTime", "RefreshTokenCreateTime" },
                values: new object[] { "6abb3043-29ef-4d2b-bb7c-ebd668d496c6", new DateTime(2024, 8, 23, 11, 27, 24, 905, DateTimeKind.Utc).AddTicks(3804), new DateTime(2024, 8, 23, 11, 27, 24, 905, DateTimeKind.Utc).AddTicks(3805), new DateTime(2024, 8, 23, 11, 27, 24, 905, DateTimeKind.Utc).AddTicks(3801) });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: 2034,
                columns: new[] { "ConcurrencyStamp", "CreatedTime", "LastUpdatedTime", "RefreshTokenCreateTime" },
                values: new object[] { "9e76a8fa-40d9-457f-b81e-8b91b2c4a8ac", new DateTime(2024, 8, 23, 11, 27, 24, 905, DateTimeKind.Utc).AddTicks(3819), new DateTime(2024, 8, 23, 11, 27, 24, 905, DateTimeKind.Utc).AddTicks(3819), new DateTime(2024, 8, 23, 11, 27, 24, 905, DateTimeKind.Utc).AddTicks(3816) });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: 2035,
                columns: new[] { "ConcurrencyStamp", "CreatedTime", "LastUpdatedTime", "RefreshTokenCreateTime" },
                values: new object[] { "849c9bf4-492f-44a3-a189-c95ed51eaf99", new DateTime(2024, 8, 23, 11, 27, 24, 905, DateTimeKind.Utc).AddTicks(3892), new DateTime(2024, 8, 23, 11, 27, 24, 905, DateTimeKind.Utc).AddTicks(3893), new DateTime(2024, 8, 23, 11, 27, 24, 905, DateTimeKind.Utc).AddTicks(3889) });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: 2036,
                columns: new[] { "ConcurrencyStamp", "CreatedTime", "LastUpdatedTime", "RefreshTokenCreateTime" },
                values: new object[] { "c5e91925-7a6b-4f1b-ad38-452151785dfc", new DateTime(2024, 8, 23, 11, 27, 24, 905, DateTimeKind.Utc).AddTicks(3905), new DateTime(2024, 8, 23, 11, 27, 24, 905, DateTimeKind.Utc).AddTicks(3905), new DateTime(2024, 8, 23, 11, 27, 24, 905, DateTimeKind.Utc).AddTicks(3901) });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: 2037,
                columns: new[] { "ConcurrencyStamp", "CreatedTime", "LastUpdatedTime", "RefreshTokenCreateTime" },
                values: new object[] { "f8c21a71-567d-406f-adb7-f5eec929c0a7", new DateTime(2024, 8, 23, 11, 27, 24, 905, DateTimeKind.Utc).AddTicks(3917), new DateTime(2024, 8, 23, 11, 27, 24, 905, DateTimeKind.Utc).AddTicks(3917), new DateTime(2024, 8, 23, 11, 27, 24, 905, DateTimeKind.Utc).AddTicks(3914) });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: 2038,
                columns: new[] { "ConcurrencyStamp", "CreatedTime", "LastUpdatedTime", "RefreshTokenCreateTime" },
                values: new object[] { "dbbec5a0-6326-46ac-99d6-2d38aded1c03", new DateTime(2024, 8, 23, 11, 27, 24, 905, DateTimeKind.Utc).AddTicks(3929), new DateTime(2024, 8, 23, 11, 27, 24, 905, DateTimeKind.Utc).AddTicks(3930), new DateTime(2024, 8, 23, 11, 27, 24, 905, DateTimeKind.Utc).AddTicks(3927) });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: 2039,
                columns: new[] { "ConcurrencyStamp", "CreatedTime", "LastUpdatedTime", "RefreshTokenCreateTime" },
                values: new object[] { "dcb3adfa-c8e2-4574-8cf6-b1b15d81f608", new DateTime(2024, 8, 23, 11, 27, 24, 905, DateTimeKind.Utc).AddTicks(3942), new DateTime(2024, 8, 23, 11, 27, 24, 905, DateTimeKind.Utc).AddTicks(3942), new DateTime(2024, 8, 23, 11, 27, 24, 905, DateTimeKind.Utc).AddTicks(3939) });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: 2040,
                columns: new[] { "ConcurrencyStamp", "CreatedTime", "LastUpdatedTime", "RefreshTokenCreateTime" },
                values: new object[] { "64313b16-3df3-462d-bb2d-186be807c5dc", new DateTime(2024, 8, 23, 11, 27, 24, 905, DateTimeKind.Utc).AddTicks(3957), new DateTime(2024, 8, 23, 11, 27, 24, 905, DateTimeKind.Utc).AddTicks(3957), new DateTime(2024, 8, 23, 11, 27, 24, 905, DateTimeKind.Utc).AddTicks(3951) });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: 2041,
                columns: new[] { "ConcurrencyStamp", "CreatedTime", "LastUpdatedTime", "RefreshTokenCreateTime" },
                values: new object[] { "5cb57756-59ef-4baa-8f30-d9bf6bf6a5ee", new DateTime(2024, 8, 23, 11, 27, 24, 905, DateTimeKind.Utc).AddTicks(3969), new DateTime(2024, 8, 23, 11, 27, 24, 905, DateTimeKind.Utc).AddTicks(3970), new DateTime(2024, 8, 23, 11, 27, 24, 905, DateTimeKind.Utc).AddTicks(3966) });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: 2042,
                columns: new[] { "ConcurrencyStamp", "CreatedTime", "LastUpdatedTime", "RefreshTokenCreateTime" },
                values: new object[] { "bf7362f7-3159-4628-83a0-7ac20e8558a3", new DateTime(2024, 8, 23, 11, 27, 24, 905, DateTimeKind.Utc).AddTicks(3986), new DateTime(2024, 8, 23, 11, 27, 24, 905, DateTimeKind.Utc).AddTicks(3987), new DateTime(2024, 8, 23, 11, 27, 24, 905, DateTimeKind.Utc).AddTicks(3983) });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: 2043,
                columns: new[] { "ConcurrencyStamp", "CreatedTime", "LastUpdatedTime", "RefreshTokenCreateTime" },
                values: new object[] { "2e137223-b64a-47dc-aff0-3a49d1faa47f", new DateTime(2024, 8, 23, 11, 27, 24, 905, DateTimeKind.Utc).AddTicks(3998), new DateTime(2024, 8, 23, 11, 27, 24, 905, DateTimeKind.Utc).AddTicks(3999), new DateTime(2024, 8, 23, 11, 27, 24, 905, DateTimeKind.Utc).AddTicks(3995) });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: 2044,
                columns: new[] { "ConcurrencyStamp", "CreatedTime", "LastUpdatedTime", "RefreshTokenCreateTime" },
                values: new object[] { "0a464b47-d13a-4606-8a3b-b327a3ba7e72", new DateTime(2024, 8, 23, 11, 27, 24, 905, DateTimeKind.Utc).AddTicks(4046), new DateTime(2024, 8, 23, 11, 27, 24, 905, DateTimeKind.Utc).AddTicks(4046), new DateTime(2024, 8, 23, 11, 27, 24, 905, DateTimeKind.Utc).AddTicks(4042) });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: 2045,
                columns: new[] { "ConcurrencyStamp", "CreatedTime", "LastUpdatedTime", "RefreshTokenCreateTime" },
                values: new object[] { "0ee9268a-3ac0-4c7d-9219-cc3b334effa6", new DateTime(2024, 8, 23, 11, 27, 24, 905, DateTimeKind.Utc).AddTicks(4057), new DateTime(2024, 8, 23, 11, 27, 24, 905, DateTimeKind.Utc).AddTicks(4058), new DateTime(2024, 8, 23, 11, 27, 24, 905, DateTimeKind.Utc).AddTicks(4055) });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: 2046,
                columns: new[] { "ConcurrencyStamp", "CreatedTime", "LastUpdatedTime", "RefreshTokenCreateTime" },
                values: new object[] { "ce79bd5e-2e00-4f79-b16c-53e26467f3aa", new DateTime(2024, 8, 23, 11, 27, 24, 905, DateTimeKind.Utc).AddTicks(4069), new DateTime(2024, 8, 23, 11, 27, 24, 905, DateTimeKind.Utc).AddTicks(4070), new DateTime(2024, 8, 23, 11, 27, 24, 905, DateTimeKind.Utc).AddTicks(4066) });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: 2047,
                columns: new[] { "ConcurrencyStamp", "CreatedTime", "LastUpdatedTime", "RefreshTokenCreateTime" },
                values: new object[] { "95686ecb-6a39-4ef7-885f-8a30e4bff962", new DateTime(2024, 8, 23, 11, 27, 24, 905, DateTimeKind.Utc).AddTicks(4081), new DateTime(2024, 8, 23, 11, 27, 24, 905, DateTimeKind.Utc).AddTicks(4081), new DateTime(2024, 8, 23, 11, 27, 24, 905, DateTimeKind.Utc).AddTicks(4077) });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: 2048,
                columns: new[] { "ConcurrencyStamp", "CreatedTime", "LastUpdatedTime", "RefreshTokenCreateTime" },
                values: new object[] { "d38b5aac-5d2a-4530-8e3b-ce92afb60961", new DateTime(2024, 8, 23, 11, 27, 24, 905, DateTimeKind.Utc).AddTicks(4095), new DateTime(2024, 8, 23, 11, 27, 24, 905, DateTimeKind.Utc).AddTicks(4095), new DateTime(2024, 8, 23, 11, 27, 24, 905, DateTimeKind.Utc).AddTicks(4089) });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: 2049,
                columns: new[] { "ConcurrencyStamp", "CreatedTime", "LastUpdatedTime", "RefreshTokenCreateTime" },
                values: new object[] { "7c7d19a9-18d2-4b95-b2c2-e3dd3687aeee", new DateTime(2024, 8, 23, 11, 27, 24, 905, DateTimeKind.Utc).AddTicks(4107), new DateTime(2024, 8, 23, 11, 27, 24, 905, DateTimeKind.Utc).AddTicks(4107), new DateTime(2024, 8, 23, 11, 27, 24, 905, DateTimeKind.Utc).AddTicks(4104) });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: 2050,
                columns: new[] { "ConcurrencyStamp", "CreatedTime", "LastUpdatedTime", "RefreshTokenCreateTime" },
                values: new object[] { "afc65225-6859-4775-8d78-08bac3e5a145", new DateTime(2024, 8, 23, 11, 27, 24, 905, DateTimeKind.Utc).AddTicks(4118), new DateTime(2024, 8, 23, 11, 27, 24, 905, DateTimeKind.Utc).AddTicks(4119), new DateTime(2024, 8, 23, 11, 27, 24, 905, DateTimeKind.Utc).AddTicks(4115) });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: 2051,
                columns: new[] { "ConcurrencyStamp", "CreatedTime", "LastUpdatedTime", "RefreshTokenCreateTime" },
                values: new object[] { "fcd2c141-c95e-4bb8-adfd-2ecdaf8fcc5b", new DateTime(2024, 8, 23, 11, 27, 24, 905, DateTimeKind.Utc).AddTicks(4129), new DateTime(2024, 8, 23, 11, 27, 24, 905, DateTimeKind.Utc).AddTicks(4130), new DateTime(2024, 8, 23, 11, 27, 24, 905, DateTimeKind.Utc).AddTicks(4126) });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: 2052,
                columns: new[] { "ConcurrencyStamp", "CreatedTime", "LastUpdatedTime", "RefreshTokenCreateTime" },
                values: new object[] { "e38b80e5-c185-422c-a511-9468900a3edf", new DateTime(2024, 8, 23, 11, 27, 24, 905, DateTimeKind.Utc).AddTicks(4141), new DateTime(2024, 8, 23, 11, 27, 24, 905, DateTimeKind.Utc).AddTicks(4141), new DateTime(2024, 8, 23, 11, 27, 24, 905, DateTimeKind.Utc).AddTicks(4138) });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: 2053,
                columns: new[] { "ConcurrencyStamp", "CreatedTime", "LastUpdatedTime", "RefreshTokenCreateTime" },
                values: new object[] { "6b641af4-491c-4c9c-9fca-ab34f8d6fc5a", new DateTime(2024, 8, 23, 11, 27, 24, 905, DateTimeKind.Utc).AddTicks(4152), new DateTime(2024, 8, 23, 11, 27, 24, 905, DateTimeKind.Utc).AddTicks(4153), new DateTime(2024, 8, 23, 11, 27, 24, 905, DateTimeKind.Utc).AddTicks(4149) });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: 2054,
                columns: new[] { "ConcurrencyStamp", "CreatedTime", "LastUpdatedTime", "RefreshTokenCreateTime" },
                values: new object[] { "57c0817a-c262-4612-9289-e511d37b985f", new DateTime(2024, 8, 23, 11, 27, 24, 905, DateTimeKind.Utc).AddTicks(4199), new DateTime(2024, 8, 23, 11, 27, 24, 905, DateTimeKind.Utc).AddTicks(4199), new DateTime(2024, 8, 23, 11, 27, 24, 905, DateTimeKind.Utc).AddTicks(4196) });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: 2055,
                columns: new[] { "ConcurrencyStamp", "CreatedTime", "LastUpdatedTime", "RefreshTokenCreateTime" },
                values: new object[] { "cb17eda4-7213-4b09-a43b-84218605c9ab", new DateTime(2024, 8, 23, 11, 27, 24, 905, DateTimeKind.Utc).AddTicks(4210), new DateTime(2024, 8, 23, 11, 27, 24, 905, DateTimeKind.Utc).AddTicks(4211), new DateTime(2024, 8, 23, 11, 27, 24, 905, DateTimeKind.Utc).AddTicks(4207) });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: 2056,
                columns: new[] { "ConcurrencyStamp", "CreatedTime", "LastUpdatedTime", "RefreshTokenCreateTime" },
                values: new object[] { "4fa2e8b2-9a6b-4f31-9708-9be1d010835b", new DateTime(2024, 8, 23, 11, 27, 24, 905, DateTimeKind.Utc).AddTicks(4225), new DateTime(2024, 8, 23, 11, 27, 24, 905, DateTimeKind.Utc).AddTicks(4225), new DateTime(2024, 8, 23, 11, 27, 24, 905, DateTimeKind.Utc).AddTicks(4219) });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: 2057,
                columns: new[] { "ConcurrencyStamp", "CreatedTime", "LastUpdatedTime", "RefreshTokenCreateTime" },
                values: new object[] { "0994161f-0695-4a81-9f4b-bf3e435e7d19", new DateTime(2024, 8, 23, 11, 27, 24, 905, DateTimeKind.Utc).AddTicks(4237), new DateTime(2024, 8, 23, 11, 27, 24, 905, DateTimeKind.Utc).AddTicks(4237), new DateTime(2024, 8, 23, 11, 27, 24, 905, DateTimeKind.Utc).AddTicks(4233) });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: 2058,
                columns: new[] { "ConcurrencyStamp", "CreatedTime", "LastUpdatedTime", "RefreshTokenCreateTime" },
                values: new object[] { "596df4d0-9e9d-4d26-b584-14324c004c92", new DateTime(2024, 8, 23, 11, 27, 24, 905, DateTimeKind.Utc).AddTicks(4247), new DateTime(2024, 8, 23, 11, 27, 24, 905, DateTimeKind.Utc).AddTicks(4248), new DateTime(2024, 8, 23, 11, 27, 24, 905, DateTimeKind.Utc).AddTicks(4244) });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: 2059,
                columns: new[] { "ConcurrencyStamp", "CreatedTime", "LastUpdatedTime", "RefreshTokenCreateTime" },
                values: new object[] { "7562f530-7343-447c-8610-b8eb27fdd428", new DateTime(2024, 8, 23, 11, 27, 24, 905, DateTimeKind.Utc).AddTicks(4258), new DateTime(2024, 8, 23, 11, 27, 24, 905, DateTimeKind.Utc).AddTicks(4259), new DateTime(2024, 8, 23, 11, 27, 24, 905, DateTimeKind.Utc).AddTicks(4255) });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: 2060,
                columns: new[] { "ConcurrencyStamp", "CreatedTime", "LastUpdatedTime", "RefreshTokenCreateTime" },
                values: new object[] { "7ca6ed39-dd8a-41d1-b778-01176bbcb5a2", new DateTime(2024, 8, 23, 11, 27, 24, 905, DateTimeKind.Utc).AddTicks(4269), new DateTime(2024, 8, 23, 11, 27, 24, 905, DateTimeKind.Utc).AddTicks(4270), new DateTime(2024, 8, 23, 11, 27, 24, 905, DateTimeKind.Utc).AddTicks(4266) });

            migrationBuilder.UpdateData(
                table: "Breeds",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedTime",
                value: new DateTime(2024, 8, 23, 15, 27, 24, 895, DateTimeKind.Local).AddTicks(6486));

            migrationBuilder.UpdateData(
                table: "Breeds",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreatedTime",
                value: new DateTime(2024, 8, 23, 15, 27, 24, 895, DateTimeKind.Local).AddTicks(6493));

            migrationBuilder.UpdateData(
                table: "Breeds",
                keyColumn: "Id",
                keyValue: 3,
                column: "CreatedTime",
                value: new DateTime(2024, 8, 23, 15, 27, 24, 895, DateTimeKind.Local).AddTicks(6495));

            migrationBuilder.UpdateData(
                table: "Breeds",
                keyColumn: "Id",
                keyValue: 4,
                column: "CreatedTime",
                value: new DateTime(2024, 8, 23, 15, 27, 24, 895, DateTimeKind.Local).AddTicks(6496));

            migrationBuilder.UpdateData(
                table: "Breeds",
                keyColumn: "Id",
                keyValue: 5,
                column: "CreatedTime",
                value: new DateTime(2024, 8, 23, 15, 27, 24, 895, DateTimeKind.Local).AddTicks(6498));

            migrationBuilder.UpdateData(
                table: "Breeds",
                keyColumn: "Id",
                keyValue: 6,
                column: "CreatedTime",
                value: new DateTime(2024, 8, 23, 15, 27, 24, 895, DateTimeKind.Local).AddTicks(6499));

            migrationBuilder.UpdateData(
                table: "Breeds",
                keyColumn: "Id",
                keyValue: 7,
                column: "CreatedTime",
                value: new DateTime(2024, 8, 23, 15, 27, 24, 895, DateTimeKind.Local).AddTicks(6501));

            migrationBuilder.UpdateData(
                table: "Breeds",
                keyColumn: "Id",
                keyValue: 8,
                column: "CreatedTime",
                value: new DateTime(2024, 8, 23, 15, 27, 24, 895, DateTimeKind.Local).AddTicks(6502));

            migrationBuilder.UpdateData(
                table: "Breeds",
                keyColumn: "Id",
                keyValue: 9,
                column: "CreatedTime",
                value: new DateTime(2024, 8, 23, 15, 27, 24, 895, DateTimeKind.Local).AddTicks(6504));

            migrationBuilder.UpdateData(
                table: "Breeds",
                keyColumn: "Id",
                keyValue: 10,
                column: "CreatedTime",
                value: new DateTime(2024, 8, 23, 15, 27, 24, 895, DateTimeKind.Local).AddTicks(6505));

            migrationBuilder.UpdateData(
                table: "Breeds",
                keyColumn: "Id",
                keyValue: 11,
                column: "CreatedTime",
                value: new DateTime(2024, 8, 23, 15, 27, 24, 895, DateTimeKind.Local).AddTicks(6507));

            migrationBuilder.UpdateData(
                table: "Breeds",
                keyColumn: "Id",
                keyValue: 12,
                column: "CreatedTime",
                value: new DateTime(2024, 8, 23, 15, 27, 24, 895, DateTimeKind.Local).AddTicks(6508));

            migrationBuilder.UpdateData(
                table: "Breeds",
                keyColumn: "Id",
                keyValue: 13,
                column: "CreatedTime",
                value: new DateTime(2024, 8, 23, 15, 27, 24, 895, DateTimeKind.Local).AddTicks(6509));

            migrationBuilder.UpdateData(
                table: "Breeds",
                keyColumn: "Id",
                keyValue: 14,
                column: "CreatedTime",
                value: new DateTime(2024, 8, 23, 15, 27, 24, 895, DateTimeKind.Local).AddTicks(6511));

            migrationBuilder.UpdateData(
                table: "Breeds",
                keyColumn: "Id",
                keyValue: 15,
                column: "CreatedTime",
                value: new DateTime(2024, 8, 23, 15, 27, 24, 895, DateTimeKind.Local).AddTicks(6512));

            migrationBuilder.UpdateData(
                table: "Breeds",
                keyColumn: "Id",
                keyValue: 16,
                column: "CreatedTime",
                value: new DateTime(2024, 8, 23, 15, 27, 24, 895, DateTimeKind.Local).AddTicks(6513));

            migrationBuilder.UpdateData(
                table: "Breeds",
                keyColumn: "Id",
                keyValue: 17,
                column: "CreatedTime",
                value: new DateTime(2024, 8, 23, 15, 27, 24, 895, DateTimeKind.Local).AddTicks(6514));

            migrationBuilder.UpdateData(
                table: "Breeds",
                keyColumn: "Id",
                keyValue: 18,
                column: "CreatedTime",
                value: new DateTime(2024, 8, 23, 15, 27, 24, 895, DateTimeKind.Local).AddTicks(6516));

            migrationBuilder.UpdateData(
                table: "Breeds",
                keyColumn: "Id",
                keyValue: 19,
                column: "CreatedTime",
                value: new DateTime(2024, 8, 23, 15, 27, 24, 895, DateTimeKind.Local).AddTicks(6517));

            migrationBuilder.UpdateData(
                table: "Breeds",
                keyColumn: "Id",
                keyValue: 20,
                column: "CreatedTime",
                value: new DateTime(2024, 8, 23, 15, 27, 24, 895, DateTimeKind.Local).AddTicks(6518));

            migrationBuilder.UpdateData(
                table: "Breeds",
                keyColumn: "Id",
                keyValue: 21,
                column: "CreatedTime",
                value: new DateTime(2024, 8, 23, 15, 27, 24, 895, DateTimeKind.Local).AddTicks(6519));

            migrationBuilder.UpdateData(
                table: "Breeds",
                keyColumn: "Id",
                keyValue: 22,
                column: "CreatedTime",
                value: new DateTime(2024, 8, 23, 15, 27, 24, 895, DateTimeKind.Local).AddTicks(6521));

            migrationBuilder.UpdateData(
                table: "Breeds",
                keyColumn: "Id",
                keyValue: 23,
                column: "CreatedTime",
                value: new DateTime(2024, 8, 23, 15, 27, 24, 895, DateTimeKind.Local).AddTicks(6523));

            migrationBuilder.UpdateData(
                table: "Breeds",
                keyColumn: "Id",
                keyValue: 24,
                column: "CreatedTime",
                value: new DateTime(2024, 8, 23, 15, 27, 24, 895, DateTimeKind.Local).AddTicks(6524));

            migrationBuilder.UpdateData(
                table: "Breeds",
                keyColumn: "Id",
                keyValue: 25,
                column: "CreatedTime",
                value: new DateTime(2024, 8, 23, 15, 27, 24, 895, DateTimeKind.Local).AddTicks(6525));

            migrationBuilder.UpdateData(
                table: "Breeds",
                keyColumn: "Id",
                keyValue: 26,
                column: "CreatedTime",
                value: new DateTime(2024, 8, 23, 15, 27, 24, 895, DateTimeKind.Local).AddTicks(6527));

            migrationBuilder.UpdateData(
                table: "Breeds",
                keyColumn: "Id",
                keyValue: 27,
                column: "CreatedTime",
                value: new DateTime(2024, 8, 23, 15, 27, 24, 895, DateTimeKind.Local).AddTicks(6528));

            migrationBuilder.UpdateData(
                table: "Breeds",
                keyColumn: "Id",
                keyValue: 28,
                column: "CreatedTime",
                value: new DateTime(2024, 8, 23, 15, 27, 24, 895, DateTimeKind.Local).AddTicks(6529));

            migrationBuilder.UpdateData(
                table: "Breeds",
                keyColumn: "Id",
                keyValue: 29,
                column: "CreatedTime",
                value: new DateTime(2024, 8, 23, 15, 27, 24, 895, DateTimeKind.Local).AddTicks(6531));

            migrationBuilder.UpdateData(
                table: "Breeds",
                keyColumn: "Id",
                keyValue: 30,
                column: "CreatedTime",
                value: new DateTime(2024, 8, 23, 15, 27, 24, 895, DateTimeKind.Local).AddTicks(6532));

            migrationBuilder.UpdateData(
                table: "Breeds",
                keyColumn: "Id",
                keyValue: 31,
                column: "CreatedTime",
                value: new DateTime(2024, 8, 23, 15, 27, 24, 895, DateTimeKind.Local).AddTicks(6533));

            migrationBuilder.UpdateData(
                table: "Breeds",
                keyColumn: "Id",
                keyValue: 32,
                column: "CreatedTime",
                value: new DateTime(2024, 8, 23, 15, 27, 24, 895, DateTimeKind.Local).AddTicks(6535));

            migrationBuilder.UpdateData(
                table: "Breeds",
                keyColumn: "Id",
                keyValue: 33,
                column: "CreatedTime",
                value: new DateTime(2024, 8, 23, 15, 27, 24, 895, DateTimeKind.Local).AddTicks(6536));

            migrationBuilder.UpdateData(
                table: "Breeds",
                keyColumn: "Id",
                keyValue: 34,
                column: "CreatedTime",
                value: new DateTime(2024, 8, 23, 15, 27, 24, 895, DateTimeKind.Local).AddTicks(6538));

            migrationBuilder.UpdateData(
                table: "Breeds",
                keyColumn: "Id",
                keyValue: 35,
                column: "CreatedTime",
                value: new DateTime(2024, 8, 23, 15, 27, 24, 895, DateTimeKind.Local).AddTicks(6539));

            migrationBuilder.UpdateData(
                table: "Breeds",
                keyColumn: "Id",
                keyValue: 36,
                column: "CreatedTime",
                value: new DateTime(2024, 8, 23, 15, 27, 24, 895, DateTimeKind.Local).AddTicks(6540));

            migrationBuilder.UpdateData(
                table: "Breeds",
                keyColumn: "Id",
                keyValue: 37,
                column: "CreatedTime",
                value: new DateTime(2024, 8, 23, 15, 27, 24, 895, DateTimeKind.Local).AddTicks(6541));

            migrationBuilder.UpdateData(
                table: "Breeds",
                keyColumn: "Id",
                keyValue: 38,
                column: "CreatedTime",
                value: new DateTime(2024, 8, 23, 15, 27, 24, 895, DateTimeKind.Local).AddTicks(6543));

            migrationBuilder.UpdateData(
                table: "Breeds",
                keyColumn: "Id",
                keyValue: 39,
                column: "CreatedTime",
                value: new DateTime(2024, 8, 23, 15, 27, 24, 895, DateTimeKind.Local).AddTicks(6544));

            migrationBuilder.UpdateData(
                table: "Breeds",
                keyColumn: "Id",
                keyValue: 40,
                column: "CreatedTime",
                value: new DateTime(2024, 8, 23, 15, 27, 24, 895, DateTimeKind.Local).AddTicks(6545));

            migrationBuilder.UpdateData(
                table: "Breeds",
                keyColumn: "Id",
                keyValue: 41,
                column: "CreatedTime",
                value: new DateTime(2024, 8, 23, 15, 27, 24, 895, DateTimeKind.Local).AddTicks(6547));

            migrationBuilder.UpdateData(
                table: "Breeds",
                keyColumn: "Id",
                keyValue: 42,
                column: "CreatedTime",
                value: new DateTime(2024, 8, 23, 15, 27, 24, 895, DateTimeKind.Local).AddTicks(6548));

            migrationBuilder.UpdateData(
                table: "Breeds",
                keyColumn: "Id",
                keyValue: 43,
                column: "CreatedTime",
                value: new DateTime(2024, 8, 23, 15, 27, 24, 895, DateTimeKind.Local).AddTicks(6549));

            migrationBuilder.UpdateData(
                table: "Breeds",
                keyColumn: "Id",
                keyValue: 44,
                column: "CreatedTime",
                value: new DateTime(2024, 8, 23, 15, 27, 24, 895, DateTimeKind.Local).AddTicks(6550));

            migrationBuilder.UpdateData(
                table: "Breeds",
                keyColumn: "Id",
                keyValue: 45,
                column: "CreatedTime",
                value: new DateTime(2024, 8, 23, 15, 27, 24, 895, DateTimeKind.Local).AddTicks(6552));

            migrationBuilder.UpdateData(
                table: "Breeds",
                keyColumn: "Id",
                keyValue: 46,
                column: "CreatedTime",
                value: new DateTime(2024, 8, 23, 15, 27, 24, 895, DateTimeKind.Local).AddTicks(6553));

            migrationBuilder.UpdateData(
                table: "Breeds",
                keyColumn: "Id",
                keyValue: 47,
                column: "CreatedTime",
                value: new DateTime(2024, 8, 23, 15, 27, 24, 895, DateTimeKind.Local).AddTicks(6554));

            migrationBuilder.UpdateData(
                table: "Breeds",
                keyColumn: "Id",
                keyValue: 48,
                column: "CreatedTime",
                value: new DateTime(2024, 8, 23, 15, 27, 24, 895, DateTimeKind.Local).AddTicks(6555));

            migrationBuilder.UpdateData(
                table: "Breeds",
                keyColumn: "Id",
                keyValue: 49,
                column: "CreatedTime",
                value: new DateTime(2024, 8, 23, 15, 27, 24, 895, DateTimeKind.Local).AddTicks(6557));

            migrationBuilder.UpdateData(
                table: "Breeds",
                keyColumn: "Id",
                keyValue: 50,
                column: "CreatedTime",
                value: new DateTime(2024, 8, 23, 15, 27, 24, 895, DateTimeKind.Local).AddTicks(6558));

            migrationBuilder.UpdateData(
                table: "Breeds",
                keyColumn: "Id",
                keyValue: 51,
                column: "CreatedTime",
                value: new DateTime(2024, 8, 23, 15, 27, 24, 895, DateTimeKind.Local).AddTicks(6559));

            migrationBuilder.UpdateData(
                table: "Breeds",
                keyColumn: "Id",
                keyValue: 52,
                column: "CreatedTime",
                value: new DateTime(2024, 8, 23, 15, 27, 24, 895, DateTimeKind.Local).AddTicks(6561));

            migrationBuilder.UpdateData(
                table: "Breeds",
                keyColumn: "Id",
                keyValue: 53,
                column: "CreatedTime",
                value: new DateTime(2024, 8, 23, 15, 27, 24, 895, DateTimeKind.Local).AddTicks(6563));

            migrationBuilder.UpdateData(
                table: "Breeds",
                keyColumn: "Id",
                keyValue: 54,
                column: "CreatedTime",
                value: new DateTime(2024, 8, 23, 15, 27, 24, 895, DateTimeKind.Local).AddTicks(6564));

            migrationBuilder.UpdateData(
                table: "Breeds",
                keyColumn: "Id",
                keyValue: 55,
                column: "CreatedTime",
                value: new DateTime(2024, 8, 23, 15, 27, 24, 895, DateTimeKind.Local).AddTicks(6565));

            migrationBuilder.UpdateData(
                table: "Breeds",
                keyColumn: "Id",
                keyValue: 56,
                column: "CreatedTime",
                value: new DateTime(2024, 8, 23, 15, 27, 24, 895, DateTimeKind.Local).AddTicks(6567));

            migrationBuilder.UpdateData(
                table: "Breeds",
                keyColumn: "Id",
                keyValue: 57,
                column: "CreatedTime",
                value: new DateTime(2024, 8, 23, 15, 27, 24, 895, DateTimeKind.Local).AddTicks(6568));

            migrationBuilder.UpdateData(
                table: "Breeds",
                keyColumn: "Id",
                keyValue: 58,
                column: "CreatedTime",
                value: new DateTime(2024, 8, 23, 15, 27, 24, 895, DateTimeKind.Local).AddTicks(6569));

            migrationBuilder.UpdateData(
                table: "Breeds",
                keyColumn: "Id",
                keyValue: 59,
                column: "CreatedTime",
                value: new DateTime(2024, 8, 23, 15, 27, 24, 895, DateTimeKind.Local).AddTicks(6570));

            migrationBuilder.UpdateData(
                table: "Breeds",
                keyColumn: "Id",
                keyValue: 60,
                column: "CreatedTime",
                value: new DateTime(2024, 8, 23, 15, 27, 24, 895, DateTimeKind.Local).AddTicks(6572));

            migrationBuilder.UpdateData(
                table: "Breeds",
                keyColumn: "Id",
                keyValue: 61,
                column: "CreatedTime",
                value: new DateTime(2024, 8, 23, 15, 27, 24, 895, DateTimeKind.Local).AddTicks(6573));

            migrationBuilder.UpdateData(
                table: "Breeds",
                keyColumn: "Id",
                keyValue: 62,
                column: "CreatedTime",
                value: new DateTime(2024, 8, 23, 15, 27, 24, 895, DateTimeKind.Local).AddTicks(6574));

            migrationBuilder.UpdateData(
                table: "Breeds",
                keyColumn: "Id",
                keyValue: 63,
                column: "CreatedTime",
                value: new DateTime(2024, 8, 23, 15, 27, 24, 895, DateTimeKind.Local).AddTicks(6575));

            migrationBuilder.UpdateData(
                table: "Breeds",
                keyColumn: "Id",
                keyValue: 64,
                column: "CreatedTime",
                value: new DateTime(2024, 8, 23, 15, 27, 24, 895, DateTimeKind.Local).AddTicks(6577));

            migrationBuilder.UpdateData(
                table: "Breeds",
                keyColumn: "Id",
                keyValue: 65,
                column: "CreatedTime",
                value: new DateTime(2024, 8, 23, 15, 27, 24, 895, DateTimeKind.Local).AddTicks(6578));

            migrationBuilder.UpdateData(
                table: "Breeds",
                keyColumn: "Id",
                keyValue: 66,
                column: "CreatedTime",
                value: new DateTime(2024, 8, 23, 15, 27, 24, 895, DateTimeKind.Local).AddTicks(6579));

            migrationBuilder.UpdateData(
                table: "Breeds",
                keyColumn: "Id",
                keyValue: 67,
                column: "CreatedTime",
                value: new DateTime(2024, 8, 23, 15, 27, 24, 895, DateTimeKind.Local).AddTicks(6580));

            migrationBuilder.UpdateData(
                table: "Breeds",
                keyColumn: "Id",
                keyValue: 68,
                column: "CreatedTime",
                value: new DateTime(2024, 8, 23, 15, 27, 24, 895, DateTimeKind.Local).AddTicks(6582));

            migrationBuilder.UpdateData(
                table: "Breeds",
                keyColumn: "Id",
                keyValue: 69,
                column: "CreatedTime",
                value: new DateTime(2024, 8, 23, 15, 27, 24, 895, DateTimeKind.Local).AddTicks(6583));

            migrationBuilder.UpdateData(
                table: "Breeds",
                keyColumn: "Id",
                keyValue: 70,
                column: "CreatedTime",
                value: new DateTime(2024, 8, 23, 15, 27, 24, 895, DateTimeKind.Local).AddTicks(6584));

            migrationBuilder.UpdateData(
                table: "Breeds",
                keyColumn: "Id",
                keyValue: 71,
                column: "CreatedTime",
                value: new DateTime(2024, 8, 23, 15, 27, 24, 895, DateTimeKind.Local).AddTicks(6585));

            migrationBuilder.UpdateData(
                table: "Breeds",
                keyColumn: "Id",
                keyValue: 72,
                column: "CreatedTime",
                value: new DateTime(2024, 8, 23, 15, 27, 24, 895, DateTimeKind.Local).AddTicks(6587));

            migrationBuilder.UpdateData(
                table: "Breeds",
                keyColumn: "Id",
                keyValue: 73,
                column: "CreatedTime",
                value: new DateTime(2024, 8, 23, 15, 27, 24, 895, DateTimeKind.Local).AddTicks(6588));

            migrationBuilder.UpdateData(
                table: "Breeds",
                keyColumn: "Id",
                keyValue: 74,
                column: "CreatedTime",
                value: new DateTime(2024, 8, 23, 15, 27, 24, 895, DateTimeKind.Local).AddTicks(6589));

            migrationBuilder.UpdateData(
                table: "Breeds",
                keyColumn: "Id",
                keyValue: 75,
                column: "CreatedTime",
                value: new DateTime(2024, 8, 23, 15, 27, 24, 895, DateTimeKind.Local).AddTicks(6590));

            migrationBuilder.UpdateData(
                table: "Breeds",
                keyColumn: "Id",
                keyValue: 76,
                column: "CreatedTime",
                value: new DateTime(2024, 8, 23, 15, 27, 24, 895, DateTimeKind.Local).AddTicks(6592));

            migrationBuilder.UpdateData(
                table: "Breeds",
                keyColumn: "Id",
                keyValue: 77,
                column: "CreatedTime",
                value: new DateTime(2024, 8, 23, 15, 27, 24, 895, DateTimeKind.Local).AddTicks(6593));

            migrationBuilder.UpdateData(
                table: "Breeds",
                keyColumn: "Id",
                keyValue: 78,
                column: "CreatedTime",
                value: new DateTime(2024, 8, 23, 15, 27, 24, 895, DateTimeKind.Local).AddTicks(6594));

            migrationBuilder.UpdateData(
                table: "Breeds",
                keyColumn: "Id",
                keyValue: 79,
                column: "CreatedTime",
                value: new DateTime(2024, 8, 23, 15, 27, 24, 895, DateTimeKind.Local).AddTicks(6596));

            migrationBuilder.UpdateData(
                table: "Breeds",
                keyColumn: "Id",
                keyValue: 80,
                column: "CreatedTime",
                value: new DateTime(2024, 8, 23, 15, 27, 24, 895, DateTimeKind.Local).AddTicks(6597));

            migrationBuilder.UpdateData(
                table: "Breeds",
                keyColumn: "Id",
                keyValue: 81,
                column: "CreatedTime",
                value: new DateTime(2024, 8, 23, 15, 27, 24, 895, DateTimeKind.Local).AddTicks(6598));

            migrationBuilder.UpdateData(
                table: "Breeds",
                keyColumn: "Id",
                keyValue: 82,
                column: "CreatedTime",
                value: new DateTime(2024, 8, 23, 15, 27, 24, 895, DateTimeKind.Local).AddTicks(6600));

            migrationBuilder.UpdateData(
                table: "Breeds",
                keyColumn: "Id",
                keyValue: 83,
                column: "CreatedTime",
                value: new DateTime(2024, 8, 23, 15, 27, 24, 895, DateTimeKind.Local).AddTicks(6602));

            migrationBuilder.UpdateData(
                table: "Breeds",
                keyColumn: "Id",
                keyValue: 84,
                column: "CreatedTime",
                value: new DateTime(2024, 8, 23, 15, 27, 24, 895, DateTimeKind.Local).AddTicks(6603));

            migrationBuilder.UpdateData(
                table: "Breeds",
                keyColumn: "Id",
                keyValue: 85,
                column: "CreatedTime",
                value: new DateTime(2024, 8, 23, 15, 27, 24, 895, DateTimeKind.Local).AddTicks(6604));

            migrationBuilder.UpdateData(
                table: "Breeds",
                keyColumn: "Id",
                keyValue: 86,
                column: "CreatedTime",
                value: new DateTime(2024, 8, 23, 15, 27, 24, 895, DateTimeKind.Local).AddTicks(6605));

            migrationBuilder.UpdateData(
                table: "Breeds",
                keyColumn: "Id",
                keyValue: 87,
                column: "CreatedTime",
                value: new DateTime(2024, 8, 23, 15, 27, 24, 895, DateTimeKind.Local).AddTicks(6607));

            migrationBuilder.UpdateData(
                table: "Breeds",
                keyColumn: "Id",
                keyValue: 88,
                column: "CreatedTime",
                value: new DateTime(2024, 8, 23, 15, 27, 24, 895, DateTimeKind.Local).AddTicks(6609));

            migrationBuilder.UpdateData(
                table: "Breeds",
                keyColumn: "Id",
                keyValue: 89,
                column: "CreatedTime",
                value: new DateTime(2024, 8, 23, 15, 27, 24, 895, DateTimeKind.Local).AddTicks(6610));

            migrationBuilder.UpdateData(
                table: "Breeds",
                keyColumn: "Id",
                keyValue: 90,
                column: "CreatedTime",
                value: new DateTime(2024, 8, 23, 15, 27, 24, 895, DateTimeKind.Local).AddTicks(6611));

            migrationBuilder.UpdateData(
                table: "Breeds",
                keyColumn: "Id",
                keyValue: 91,
                column: "CreatedTime",
                value: new DateTime(2024, 8, 23, 15, 27, 24, 895, DateTimeKind.Local).AddTicks(6642));

            migrationBuilder.UpdateData(
                table: "Breeds",
                keyColumn: "Id",
                keyValue: 92,
                column: "CreatedTime",
                value: new DateTime(2024, 8, 23, 15, 27, 24, 895, DateTimeKind.Local).AddTicks(6644));

            migrationBuilder.UpdateData(
                table: "Breeds",
                keyColumn: "Id",
                keyValue: 93,
                column: "CreatedTime",
                value: new DateTime(2024, 8, 23, 15, 27, 24, 895, DateTimeKind.Local).AddTicks(6645));

            migrationBuilder.UpdateData(
                table: "Breeds",
                keyColumn: "Id",
                keyValue: 94,
                column: "CreatedTime",
                value: new DateTime(2024, 8, 23, 15, 27, 24, 895, DateTimeKind.Local).AddTicks(6646));

            migrationBuilder.UpdateData(
                table: "Breeds",
                keyColumn: "Id",
                keyValue: 95,
                column: "CreatedTime",
                value: new DateTime(2024, 8, 23, 15, 27, 24, 895, DateTimeKind.Local).AddTicks(6648));

            migrationBuilder.UpdateData(
                table: "Breeds",
                keyColumn: "Id",
                keyValue: 96,
                column: "CreatedTime",
                value: new DateTime(2024, 8, 23, 15, 27, 24, 895, DateTimeKind.Local).AddTicks(6649));

            migrationBuilder.UpdateData(
                table: "Breeds",
                keyColumn: "Id",
                keyValue: 97,
                column: "CreatedTime",
                value: new DateTime(2024, 8, 23, 15, 27, 24, 895, DateTimeKind.Local).AddTicks(6650));

            migrationBuilder.UpdateData(
                table: "Breeds",
                keyColumn: "Id",
                keyValue: 98,
                column: "CreatedTime",
                value: new DateTime(2024, 8, 23, 15, 27, 24, 895, DateTimeKind.Local).AddTicks(6652));

            migrationBuilder.UpdateData(
                table: "Breeds",
                keyColumn: "Id",
                keyValue: 99,
                column: "CreatedTime",
                value: new DateTime(2024, 8, 23, 15, 27, 24, 895, DateTimeKind.Local).AddTicks(6653));

            migrationBuilder.UpdateData(
                table: "Breeds",
                keyColumn: "Id",
                keyValue: 100,
                column: "CreatedTime",
                value: new DateTime(2024, 8, 23, 15, 27, 24, 895, DateTimeKind.Local).AddTicks(6654));

            migrationBuilder.UpdateData(
                table: "Breeds",
                keyColumn: "Id",
                keyValue: 101,
                column: "CreatedTime",
                value: new DateTime(2024, 8, 23, 15, 27, 24, 895, DateTimeKind.Local).AddTicks(6655));

            migrationBuilder.UpdateData(
                table: "Breeds",
                keyColumn: "Id",
                keyValue: 102,
                column: "CreatedTime",
                value: new DateTime(2024, 8, 23, 15, 27, 24, 895, DateTimeKind.Local).AddTicks(6657));

            migrationBuilder.UpdateData(
                table: "Breeds",
                keyColumn: "Id",
                keyValue: 103,
                column: "CreatedTime",
                value: new DateTime(2024, 8, 23, 15, 27, 24, 895, DateTimeKind.Local).AddTicks(6658));

            migrationBuilder.UpdateData(
                table: "Breeds",
                keyColumn: "Id",
                keyValue: 104,
                column: "CreatedTime",
                value: new DateTime(2024, 8, 23, 15, 27, 24, 895, DateTimeKind.Local).AddTicks(6659));

            migrationBuilder.UpdateData(
                table: "Breeds",
                keyColumn: "Id",
                keyValue: 105,
                column: "CreatedTime",
                value: new DateTime(2024, 8, 23, 15, 27, 24, 895, DateTimeKind.Local).AddTicks(6660));

            migrationBuilder.UpdateData(
                table: "Breeds",
                keyColumn: "Id",
                keyValue: 106,
                column: "CreatedTime",
                value: new DateTime(2024, 8, 23, 15, 27, 24, 895, DateTimeKind.Local).AddTicks(6662));

            migrationBuilder.UpdateData(
                table: "Breeds",
                keyColumn: "Id",
                keyValue: 107,
                column: "CreatedTime",
                value: new DateTime(2024, 8, 23, 15, 27, 24, 895, DateTimeKind.Local).AddTicks(6663));

            migrationBuilder.UpdateData(
                table: "Breeds",
                keyColumn: "Id",
                keyValue: 108,
                column: "CreatedTime",
                value: new DateTime(2024, 8, 23, 15, 27, 24, 895, DateTimeKind.Local).AddTicks(6664));

            migrationBuilder.UpdateData(
                table: "Breeds",
                keyColumn: "Id",
                keyValue: 109,
                column: "CreatedTime",
                value: new DateTime(2024, 8, 23, 15, 27, 24, 895, DateTimeKind.Local).AddTicks(6665));

            migrationBuilder.UpdateData(
                table: "Breeds",
                keyColumn: "Id",
                keyValue: 110,
                column: "CreatedTime",
                value: new DateTime(2024, 8, 23, 15, 27, 24, 895, DateTimeKind.Local).AddTicks(6667));

            migrationBuilder.UpdateData(
                table: "Breeds",
                keyColumn: "Id",
                keyValue: 111,
                column: "CreatedTime",
                value: new DateTime(2024, 8, 23, 15, 27, 24, 895, DateTimeKind.Local).AddTicks(6669));

            migrationBuilder.UpdateData(
                table: "Breeds",
                keyColumn: "Id",
                keyValue: 112,
                column: "CreatedTime",
                value: new DateTime(2024, 8, 23, 15, 27, 24, 895, DateTimeKind.Local).AddTicks(6671));

            migrationBuilder.UpdateData(
                table: "Breeds",
                keyColumn: "Id",
                keyValue: 113,
                column: "CreatedTime",
                value: new DateTime(2024, 8, 23, 15, 27, 24, 895, DateTimeKind.Local).AddTicks(6672));

            migrationBuilder.UpdateData(
                table: "Breeds",
                keyColumn: "Id",
                keyValue: 114,
                column: "CreatedTime",
                value: new DateTime(2024, 8, 23, 15, 27, 24, 895, DateTimeKind.Local).AddTicks(6673));

            migrationBuilder.UpdateData(
                table: "Breeds",
                keyColumn: "Id",
                keyValue: 115,
                column: "CreatedTime",
                value: new DateTime(2024, 8, 23, 15, 27, 24, 895, DateTimeKind.Local).AddTicks(6674));

            migrationBuilder.UpdateData(
                table: "Breeds",
                keyColumn: "Id",
                keyValue: 116,
                column: "CreatedTime",
                value: new DateTime(2024, 8, 23, 15, 27, 24, 895, DateTimeKind.Local).AddTicks(6675));

            migrationBuilder.UpdateData(
                table: "Breeds",
                keyColumn: "Id",
                keyValue: 117,
                column: "CreatedTime",
                value: new DateTime(2024, 8, 23, 15, 27, 24, 895, DateTimeKind.Local).AddTicks(6677));

            migrationBuilder.UpdateData(
                table: "Breeds",
                keyColumn: "Id",
                keyValue: 118,
                column: "CreatedTime",
                value: new DateTime(2024, 8, 23, 15, 27, 24, 895, DateTimeKind.Local).AddTicks(6678));

            migrationBuilder.UpdateData(
                table: "Breeds",
                keyColumn: "Id",
                keyValue: 119,
                column: "CreatedTime",
                value: new DateTime(2024, 8, 23, 15, 27, 24, 895, DateTimeKind.Local).AddTicks(6679));

            migrationBuilder.UpdateData(
                table: "Breeds",
                keyColumn: "Id",
                keyValue: 120,
                column: "CreatedTime",
                value: new DateTime(2024, 8, 23, 15, 27, 24, 895, DateTimeKind.Local).AddTicks(6681));

            migrationBuilder.UpdateData(
                table: "Breeds",
                keyColumn: "Id",
                keyValue: 121,
                column: "CreatedTime",
                value: new DateTime(2024, 8, 23, 15, 27, 24, 895, DateTimeKind.Local).AddTicks(6682));

            migrationBuilder.UpdateData(
                table: "Breeds",
                keyColumn: "Id",
                keyValue: 122,
                column: "CreatedTime",
                value: new DateTime(2024, 8, 23, 15, 27, 24, 895, DateTimeKind.Local).AddTicks(6683));

            migrationBuilder.UpdateData(
                table: "Breeds",
                keyColumn: "Id",
                keyValue: 123,
                column: "CreatedTime",
                value: new DateTime(2024, 8, 23, 15, 27, 24, 895, DateTimeKind.Local).AddTicks(6684));

            migrationBuilder.UpdateData(
                table: "Breeds",
                keyColumn: "Id",
                keyValue: 124,
                column: "CreatedTime",
                value: new DateTime(2024, 8, 23, 15, 27, 24, 895, DateTimeKind.Local).AddTicks(6686));

            migrationBuilder.UpdateData(
                table: "Breeds",
                keyColumn: "Id",
                keyValue: 125,
                column: "CreatedTime",
                value: new DateTime(2024, 8, 23, 15, 27, 24, 895, DateTimeKind.Local).AddTicks(6687));

            migrationBuilder.UpdateData(
                table: "Breeds",
                keyColumn: "Id",
                keyValue: 126,
                column: "CreatedTime",
                value: new DateTime(2024, 8, 23, 15, 27, 24, 895, DateTimeKind.Local).AddTicks(6688));

            migrationBuilder.UpdateData(
                table: "Breeds",
                keyColumn: "Id",
                keyValue: 127,
                column: "CreatedTime",
                value: new DateTime(2024, 8, 23, 15, 27, 24, 895, DateTimeKind.Local).AddTicks(6689));

            migrationBuilder.UpdateData(
                table: "Breeds",
                keyColumn: "Id",
                keyValue: 128,
                column: "CreatedTime",
                value: new DateTime(2024, 8, 23, 15, 27, 24, 895, DateTimeKind.Local).AddTicks(6691));

            migrationBuilder.UpdateData(
                table: "Breeds",
                keyColumn: "Id",
                keyValue: 129,
                column: "CreatedTime",
                value: new DateTime(2024, 8, 23, 15, 27, 24, 895, DateTimeKind.Local).AddTicks(6692));

            migrationBuilder.UpdateData(
                table: "Breeds",
                keyColumn: "Id",
                keyValue: 130,
                column: "CreatedTime",
                value: new DateTime(2024, 8, 23, 15, 27, 24, 895, DateTimeKind.Local).AddTicks(6693));

            migrationBuilder.UpdateData(
                table: "Breeds",
                keyColumn: "Id",
                keyValue: 131,
                column: "CreatedTime",
                value: new DateTime(2024, 8, 23, 15, 27, 24, 895, DateTimeKind.Local).AddTicks(6695));

            migrationBuilder.UpdateData(
                table: "Breeds",
                keyColumn: "Id",
                keyValue: 132,
                column: "CreatedTime",
                value: new DateTime(2024, 8, 23, 15, 27, 24, 895, DateTimeKind.Local).AddTicks(6696));

            migrationBuilder.UpdateData(
                table: "Breeds",
                keyColumn: "Id",
                keyValue: 133,
                column: "CreatedTime",
                value: new DateTime(2024, 8, 23, 15, 27, 24, 895, DateTimeKind.Local).AddTicks(6697));

            migrationBuilder.UpdateData(
                table: "Breeds",
                keyColumn: "Id",
                keyValue: 134,
                column: "CreatedTime",
                value: new DateTime(2024, 8, 23, 15, 27, 24, 895, DateTimeKind.Local).AddTicks(6699));

            migrationBuilder.UpdateData(
                table: "Breeds",
                keyColumn: "Id",
                keyValue: 135,
                column: "CreatedTime",
                value: new DateTime(2024, 8, 23, 15, 27, 24, 895, DateTimeKind.Local).AddTicks(6700));

            migrationBuilder.UpdateData(
                table: "Breeds",
                keyColumn: "Id",
                keyValue: 136,
                column: "CreatedTime",
                value: new DateTime(2024, 8, 23, 15, 27, 24, 895, DateTimeKind.Local).AddTicks(6701));

            migrationBuilder.UpdateData(
                table: "Breeds",
                keyColumn: "Id",
                keyValue: 137,
                column: "CreatedTime",
                value: new DateTime(2024, 8, 23, 15, 27, 24, 895, DateTimeKind.Local).AddTicks(6702));

            migrationBuilder.UpdateData(
                table: "Breeds",
                keyColumn: "Id",
                keyValue: 138,
                column: "CreatedTime",
                value: new DateTime(2024, 8, 23, 15, 27, 24, 895, DateTimeKind.Local).AddTicks(6703));

            migrationBuilder.UpdateData(
                table: "Breeds",
                keyColumn: "Id",
                keyValue: 139,
                column: "CreatedTime",
                value: new DateTime(2024, 8, 23, 15, 27, 24, 895, DateTimeKind.Local).AddTicks(6705));

            migrationBuilder.UpdateData(
                table: "Breeds",
                keyColumn: "Id",
                keyValue: 140,
                column: "CreatedTime",
                value: new DateTime(2024, 8, 23, 15, 27, 24, 895, DateTimeKind.Local).AddTicks(6706));

            migrationBuilder.UpdateData(
                table: "Breeds",
                keyColumn: "Id",
                keyValue: 141,
                column: "CreatedTime",
                value: new DateTime(2024, 8, 23, 15, 27, 24, 895, DateTimeKind.Local).AddTicks(6707));

            migrationBuilder.UpdateData(
                table: "Breeds",
                keyColumn: "Id",
                keyValue: 142,
                column: "CreatedTime",
                value: new DateTime(2024, 8, 23, 15, 27, 24, 895, DateTimeKind.Local).AddTicks(6708));

            migrationBuilder.UpdateData(
                table: "Breeds",
                keyColumn: "Id",
                keyValue: 143,
                column: "CreatedTime",
                value: new DateTime(2024, 8, 23, 15, 27, 24, 895, DateTimeKind.Local).AddTicks(6710));

            migrationBuilder.UpdateData(
                table: "Breeds",
                keyColumn: "Id",
                keyValue: 144,
                column: "CreatedTime",
                value: new DateTime(2024, 8, 23, 15, 27, 24, 895, DateTimeKind.Local).AddTicks(6711));

            migrationBuilder.UpdateData(
                table: "Breeds",
                keyColumn: "Id",
                keyValue: 145,
                column: "CreatedTime",
                value: new DateTime(2024, 8, 23, 15, 27, 24, 895, DateTimeKind.Local).AddTicks(6712));

            migrationBuilder.UpdateData(
                table: "Breeds",
                keyColumn: "Id",
                keyValue: 146,
                column: "CreatedTime",
                value: new DateTime(2024, 8, 23, 15, 27, 24, 895, DateTimeKind.Local).AddTicks(6714));

            migrationBuilder.UpdateData(
                table: "Breeds",
                keyColumn: "Id",
                keyValue: 147,
                column: "CreatedTime",
                value: new DateTime(2024, 8, 23, 15, 27, 24, 895, DateTimeKind.Local).AddTicks(6715));

            migrationBuilder.UpdateData(
                table: "Breeds",
                keyColumn: "Id",
                keyValue: 148,
                column: "CreatedTime",
                value: new DateTime(2024, 8, 23, 15, 27, 24, 895, DateTimeKind.Local).AddTicks(6716));

            migrationBuilder.UpdateData(
                table: "Breeds",
                keyColumn: "Id",
                keyValue: 149,
                column: "CreatedTime",
                value: new DateTime(2024, 8, 23, 15, 27, 24, 895, DateTimeKind.Local).AddTicks(6717));

            migrationBuilder.UpdateData(
                table: "Breeds",
                keyColumn: "Id",
                keyValue: 150,
                column: "CreatedTime",
                value: new DateTime(2024, 8, 23, 15, 27, 24, 895, DateTimeKind.Local).AddTicks(6719));

            migrationBuilder.UpdateData(
                table: "Breeds",
                keyColumn: "Id",
                keyValue: 151,
                column: "CreatedTime",
                value: new DateTime(2024, 8, 23, 15, 27, 24, 895, DateTimeKind.Local).AddTicks(6720));

            migrationBuilder.UpdateData(
                table: "Breeds",
                keyColumn: "Id",
                keyValue: 152,
                column: "CreatedTime",
                value: new DateTime(2024, 8, 23, 15, 27, 24, 895, DateTimeKind.Local).AddTicks(6721));

            migrationBuilder.UpdateData(
                table: "Breeds",
                keyColumn: "Id",
                keyValue: 153,
                column: "CreatedTime",
                value: new DateTime(2024, 8, 23, 15, 27, 24, 895, DateTimeKind.Local).AddTicks(6723));

            migrationBuilder.UpdateData(
                table: "Breeds",
                keyColumn: "Id",
                keyValue: 154,
                column: "CreatedTime",
                value: new DateTime(2024, 8, 23, 15, 27, 24, 895, DateTimeKind.Local).AddTicks(6724));

            migrationBuilder.UpdateData(
                table: "Breeds",
                keyColumn: "Id",
                keyValue: 155,
                column: "CreatedTime",
                value: new DateTime(2024, 8, 23, 15, 27, 24, 895, DateTimeKind.Local).AddTicks(6725));

            migrationBuilder.UpdateData(
                table: "Breeds",
                keyColumn: "Id",
                keyValue: 156,
                column: "CreatedTime",
                value: new DateTime(2024, 8, 23, 15, 27, 24, 895, DateTimeKind.Local).AddTicks(6728));

            migrationBuilder.UpdateData(
                table: "Breeds",
                keyColumn: "Id",
                keyValue: 157,
                column: "CreatedTime",
                value: new DateTime(2024, 8, 23, 15, 27, 24, 895, DateTimeKind.Local).AddTicks(6729));

            migrationBuilder.UpdateData(
                table: "Breeds",
                keyColumn: "Id",
                keyValue: 158,
                column: "CreatedTime",
                value: new DateTime(2024, 8, 23, 15, 27, 24, 895, DateTimeKind.Local).AddTicks(6730));

            migrationBuilder.UpdateData(
                table: "Breeds",
                keyColumn: "Id",
                keyValue: 159,
                column: "CreatedTime",
                value: new DateTime(2024, 8, 23, 15, 27, 24, 895, DateTimeKind.Local).AddTicks(6731));

            migrationBuilder.UpdateData(
                table: "Breeds",
                keyColumn: "Id",
                keyValue: 160,
                column: "CreatedTime",
                value: new DateTime(2024, 8, 23, 15, 27, 24, 895, DateTimeKind.Local).AddTicks(6733));

            migrationBuilder.UpdateData(
                table: "PetTypes",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedTime",
                value: new DateTime(2024, 8, 23, 15, 27, 24, 895, DateTimeKind.Local).AddTicks(3780));

            migrationBuilder.UpdateData(
                table: "PetTypes",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreatedTime",
                value: new DateTime(2024, 8, 23, 15, 27, 24, 895, DateTimeKind.Local).AddTicks(3793));

            migrationBuilder.UpdateData(
                table: "PetTypes",
                keyColumn: "Id",
                keyValue: 3,
                column: "CreatedTime",
                value: new DateTime(2024, 8, 23, 15, 27, 24, 895, DateTimeKind.Local).AddTicks(3794));

            migrationBuilder.UpdateData(
                table: "PetTypes",
                keyColumn: "Id",
                keyValue: 4,
                column: "CreatedTime",
                value: new DateTime(2024, 8, 23, 15, 27, 24, 895, DateTimeKind.Local).AddTicks(3795));

            migrationBuilder.UpdateData(
                table: "PetTypes",
                keyColumn: "Id",
                keyValue: 5,
                column: "CreatedTime",
                value: new DateTime(2024, 8, 23, 15, 27, 24, 895, DateTimeKind.Local).AddTicks(3796));

            migrationBuilder.UpdateData(
                table: "PetTypes",
                keyColumn: "Id",
                keyValue: 6,
                column: "CreatedTime",
                value: new DateTime(2024, 8, 23, 15, 27, 24, 895, DateTimeKind.Local).AddTicks(3798));

            migrationBuilder.UpdateData(
                table: "PetTypes",
                keyColumn: "Id",
                keyValue: 7,
                column: "CreatedTime",
                value: new DateTime(2024, 8, 23, 15, 27, 24, 895, DateTimeKind.Local).AddTicks(3799));

            migrationBuilder.UpdateData(
                table: "PetTypes",
                keyColumn: "Id",
                keyValue: 8,
                column: "CreatedTime",
                value: new DateTime(2024, 8, 23, 15, 27, 24, 895, DateTimeKind.Local).AddTicks(3800));

            migrationBuilder.UpdateData(
                table: "Shelters",
                keyColumn: "Id",
                keyValue: 1021,
                columns: new[] { "CreatedTime", "LastUpdatedTime", "ShelterImageUrl" },
                values: new object[] { new DateTime(2024, 8, 23, 11, 27, 24, 893, DateTimeKind.Utc).AddTicks(6906), new DateTime(2024, 8, 23, 11, 27, 24, 893, DateTimeKind.Utc).AddTicks(6907), null });

            migrationBuilder.UpdateData(
                table: "Shelters",
                keyColumn: "Id",
                keyValue: 1022,
                columns: new[] { "CreatedTime", "LastUpdatedTime", "ShelterImageUrl" },
                values: new object[] { new DateTime(2024, 8, 23, 11, 27, 24, 893, DateTimeKind.Utc).AddTicks(6916), new DateTime(2024, 8, 23, 11, 27, 24, 893, DateTimeKind.Utc).AddTicks(6917), null });

            migrationBuilder.UpdateData(
                table: "Shelters",
                keyColumn: "Id",
                keyValue: 1023,
                columns: new[] { "CreatedTime", "LastUpdatedTime", "ShelterImageUrl" },
                values: new object[] { new DateTime(2024, 8, 23, 11, 27, 24, 893, DateTimeKind.Utc).AddTicks(6923), new DateTime(2024, 8, 23, 11, 27, 24, 893, DateTimeKind.Utc).AddTicks(6923), null });

            migrationBuilder.UpdateData(
                table: "Shelters",
                keyColumn: "Id",
                keyValue: 1024,
                columns: new[] { "CreatedTime", "LastUpdatedTime", "ShelterImageUrl" },
                values: new object[] { new DateTime(2024, 8, 23, 11, 27, 24, 893, DateTimeKind.Utc).AddTicks(6928), new DateTime(2024, 8, 23, 11, 27, 24, 893, DateTimeKind.Utc).AddTicks(6928), null });

            migrationBuilder.UpdateData(
                table: "Shelters",
                keyColumn: "Id",
                keyValue: 1025,
                columns: new[] { "CreatedTime", "LastUpdatedTime", "ShelterImageUrl" },
                values: new object[] { new DateTime(2024, 8, 23, 11, 27, 24, 893, DateTimeKind.Utc).AddTicks(6933), new DateTime(2024, 8, 23, 11, 27, 24, 893, DateTimeKind.Utc).AddTicks(6933), null });

            migrationBuilder.UpdateData(
                table: "Shelters",
                keyColumn: "Id",
                keyValue: 1026,
                columns: new[] { "CreatedTime", "LastUpdatedTime", "ShelterImageUrl" },
                values: new object[] { new DateTime(2024, 8, 23, 11, 27, 24, 893, DateTimeKind.Utc).AddTicks(6941), new DateTime(2024, 8, 23, 11, 27, 24, 893, DateTimeKind.Utc).AddTicks(6941), null });

            migrationBuilder.UpdateData(
                table: "Shelters",
                keyColumn: "Id",
                keyValue: 1027,
                columns: new[] { "CreatedTime", "LastUpdatedTime", "ShelterImageUrl" },
                values: new object[] { new DateTime(2024, 8, 23, 11, 27, 24, 893, DateTimeKind.Utc).AddTicks(7046), new DateTime(2024, 8, 23, 11, 27, 24, 893, DateTimeKind.Utc).AddTicks(7046), null });

            migrationBuilder.UpdateData(
                table: "Shelters",
                keyColumn: "Id",
                keyValue: 1028,
                columns: new[] { "CreatedTime", "LastUpdatedTime", "ShelterImageUrl" },
                values: new object[] { new DateTime(2024, 8, 23, 11, 27, 24, 893, DateTimeKind.Utc).AddTicks(7051), new DateTime(2024, 8, 23, 11, 27, 24, 893, DateTimeKind.Utc).AddTicks(7051), null });

            migrationBuilder.UpdateData(
                table: "Shelters",
                keyColumn: "Id",
                keyValue: 1029,
                columns: new[] { "CreatedTime", "LastUpdatedTime", "ShelterImageUrl" },
                values: new object[] { new DateTime(2024, 8, 23, 11, 27, 24, 893, DateTimeKind.Utc).AddTicks(7056), new DateTime(2024, 8, 23, 11, 27, 24, 893, DateTimeKind.Utc).AddTicks(7056), null });

            migrationBuilder.UpdateData(
                table: "Shelters",
                keyColumn: "Id",
                keyValue: 1030,
                columns: new[] { "CreatedTime", "LastUpdatedTime", "ShelterImageUrl" },
                values: new object[] { new DateTime(2024, 8, 23, 11, 27, 24, 893, DateTimeKind.Utc).AddTicks(7063), new DateTime(2024, 8, 23, 11, 27, 24, 893, DateTimeKind.Utc).AddTicks(7064), null });

            migrationBuilder.UpdateData(
                table: "Shelters",
                keyColumn: "Id",
                keyValue: 1031,
                columns: new[] { "CreatedTime", "LastUpdatedTime", "ShelterImageUrl" },
                values: new object[] { new DateTime(2024, 8, 23, 11, 27, 24, 893, DateTimeKind.Utc).AddTicks(7069), new DateTime(2024, 8, 23, 11, 27, 24, 893, DateTimeKind.Utc).AddTicks(7069), null });

            migrationBuilder.UpdateData(
                table: "Shelters",
                keyColumn: "Id",
                keyValue: 1032,
                columns: new[] { "CreatedTime", "LastUpdatedTime", "ShelterImageUrl" },
                values: new object[] { new DateTime(2024, 8, 23, 11, 27, 24, 893, DateTimeKind.Utc).AddTicks(7074), new DateTime(2024, 8, 23, 11, 27, 24, 893, DateTimeKind.Utc).AddTicks(7074), null });

            migrationBuilder.UpdateData(
                table: "Shelters",
                keyColumn: "Id",
                keyValue: 1033,
                columns: new[] { "CreatedTime", "LastUpdatedTime", "ShelterImageUrl" },
                values: new object[] { new DateTime(2024, 8, 23, 11, 27, 24, 893, DateTimeKind.Utc).AddTicks(7079), new DateTime(2024, 8, 23, 11, 27, 24, 893, DateTimeKind.Utc).AddTicks(7079), null });

            migrationBuilder.UpdateData(
                table: "Shelters",
                keyColumn: "Id",
                keyValue: 1034,
                columns: new[] { "CreatedTime", "LastUpdatedTime", "ShelterImageUrl" },
                values: new object[] { new DateTime(2024, 8, 23, 11, 27, 24, 893, DateTimeKind.Utc).AddTicks(7084), new DateTime(2024, 8, 23, 11, 27, 24, 893, DateTimeKind.Utc).AddTicks(7084), null });

            migrationBuilder.UpdateData(
                table: "Shelters",
                keyColumn: "Id",
                keyValue: 1035,
                columns: new[] { "CreatedTime", "LastUpdatedTime", "ShelterImageUrl" },
                values: new object[] { new DateTime(2024, 8, 23, 11, 27, 24, 893, DateTimeKind.Utc).AddTicks(7089), new DateTime(2024, 8, 23, 11, 27, 24, 893, DateTimeKind.Utc).AddTicks(7089), null });

            migrationBuilder.UpdateData(
                table: "Shelters",
                keyColumn: "Id",
                keyValue: 1036,
                columns: new[] { "CreatedTime", "LastUpdatedTime", "ShelterImageUrl" },
                values: new object[] { new DateTime(2024, 8, 23, 11, 27, 24, 893, DateTimeKind.Utc).AddTicks(7094), new DateTime(2024, 8, 23, 11, 27, 24, 893, DateTimeKind.Utc).AddTicks(7094), null });

            migrationBuilder.UpdateData(
                table: "Shelters",
                keyColumn: "Id",
                keyValue: 1037,
                columns: new[] { "CreatedTime", "LastUpdatedTime", "ShelterImageUrl" },
                values: new object[] { new DateTime(2024, 8, 23, 11, 27, 24, 893, DateTimeKind.Utc).AddTicks(7099), new DateTime(2024, 8, 23, 11, 27, 24, 893, DateTimeKind.Utc).AddTicks(7100), null });

            migrationBuilder.UpdateData(
                table: "Shelters",
                keyColumn: "Id",
                keyValue: 1038,
                columns: new[] { "CreatedTime", "LastUpdatedTime", "ShelterImageUrl" },
                values: new object[] { new DateTime(2024, 8, 23, 11, 27, 24, 893, DateTimeKind.Utc).AddTicks(7106), new DateTime(2024, 8, 23, 11, 27, 24, 893, DateTimeKind.Utc).AddTicks(7106), null });

            migrationBuilder.UpdateData(
                table: "Shelters",
                keyColumn: "Id",
                keyValue: 1039,
                columns: new[] { "CreatedTime", "LastUpdatedTime", "ShelterImageUrl" },
                values: new object[] { new DateTime(2024, 8, 23, 11, 27, 24, 893, DateTimeKind.Utc).AddTicks(7111), new DateTime(2024, 8, 23, 11, 27, 24, 893, DateTimeKind.Utc).AddTicks(7111), null });

            migrationBuilder.UpdateData(
                table: "Shelters",
                keyColumn: "Id",
                keyValue: 1040,
                columns: new[] { "CreatedTime", "LastUpdatedTime", "ShelterImageUrl" },
                values: new object[] { new DateTime(2024, 8, 23, 11, 27, 24, 893, DateTimeKind.Utc).AddTicks(7116), new DateTime(2024, 8, 23, 11, 27, 24, 893, DateTimeKind.Utc).AddTicks(7116), null });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "ShelterImageUrl",
                table: "Shelters");

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: 2001,
                columns: new[] { "ConcurrencyStamp", "CreatedTime", "LastUpdatedTime", "RefreshTokenCreateTime" },
                values: new object[] { "e0fbcef8-ae95-4e6a-bf4d-fee25c2a08f2", new DateTime(2024, 8, 22, 13, 29, 17, 397, DateTimeKind.Utc).AddTicks(9865), new DateTime(2024, 8, 22, 13, 29, 17, 397, DateTimeKind.Utc).AddTicks(9867), new DateTime(2024, 8, 22, 13, 29, 17, 397, DateTimeKind.Utc).AddTicks(9783) });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: 2002,
                columns: new[] { "ConcurrencyStamp", "CreatedTime", "LastUpdatedTime", "RefreshTokenCreateTime" },
                values: new object[] { "cac3e464-f0ce-4cfd-b0e6-102b313a9369", new DateTime(2024, 8, 22, 13, 29, 17, 397, DateTimeKind.Utc).AddTicks(9923), new DateTime(2024, 8, 22, 13, 29, 17, 397, DateTimeKind.Utc).AddTicks(9924), new DateTime(2024, 8, 22, 13, 29, 17, 397, DateTimeKind.Utc).AddTicks(9918) });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: 2003,
                columns: new[] { "ConcurrencyStamp", "CreatedTime", "LastUpdatedTime", "RefreshTokenCreateTime" },
                values: new object[] { "83744078-8d8f-44fb-b66f-7611a6512bd5", new DateTime(2024, 8, 22, 13, 29, 17, 397, DateTimeKind.Utc).AddTicks(9937), new DateTime(2024, 8, 22, 13, 29, 17, 397, DateTimeKind.Utc).AddTicks(9938), new DateTime(2024, 8, 22, 13, 29, 17, 397, DateTimeKind.Utc).AddTicks(9934) });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: 2004,
                columns: new[] { "ConcurrencyStamp", "CreatedTime", "LastUpdatedTime", "RefreshTokenCreateTime" },
                values: new object[] { "3be1a587-5f9f-459c-9c8b-2841b7c1fbc1", new DateTime(2024, 8, 22, 13, 29, 17, 398, DateTimeKind.Utc).AddTicks(17), new DateTime(2024, 8, 22, 13, 29, 17, 398, DateTimeKind.Utc).AddTicks(17), new DateTime(2024, 8, 22, 13, 29, 17, 398, DateTimeKind.Utc).AddTicks(13) });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: 2005,
                columns: new[] { "ConcurrencyStamp", "CreatedTime", "LastUpdatedTime", "RefreshTokenCreateTime" },
                values: new object[] { "ac21d783-d9cf-45f9-a0c1-e9b8c51610ab", new DateTime(2024, 8, 22, 13, 29, 17, 398, DateTimeKind.Utc).AddTicks(31), new DateTime(2024, 8, 22, 13, 29, 17, 398, DateTimeKind.Utc).AddTicks(31), new DateTime(2024, 8, 22, 13, 29, 17, 398, DateTimeKind.Utc).AddTicks(27) });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: 2006,
                columns: new[] { "ConcurrencyStamp", "CreatedTime", "LastUpdatedTime", "RefreshTokenCreateTime" },
                values: new object[] { "90afae42-59ed-4bd6-bfa2-e5c65cda2b93", new DateTime(2024, 8, 22, 13, 29, 17, 398, DateTimeKind.Utc).AddTicks(46), new DateTime(2024, 8, 22, 13, 29, 17, 398, DateTimeKind.Utc).AddTicks(46), new DateTime(2024, 8, 22, 13, 29, 17, 398, DateTimeKind.Utc).AddTicks(42) });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: 2007,
                columns: new[] { "ConcurrencyStamp", "CreatedTime", "LastUpdatedTime", "RefreshTokenCreateTime" },
                values: new object[] { "9d51687b-4189-428f-9f31-c89777bc9879", new DateTime(2024, 8, 22, 13, 29, 17, 398, DateTimeKind.Utc).AddTicks(57), new DateTime(2024, 8, 22, 13, 29, 17, 398, DateTimeKind.Utc).AddTicks(57), new DateTime(2024, 8, 22, 13, 29, 17, 398, DateTimeKind.Utc).AddTicks(54) });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: 2008,
                columns: new[] { "ConcurrencyStamp", "CreatedTime", "LastUpdatedTime", "RefreshTokenCreateTime" },
                values: new object[] { "3baa380f-47ac-45f9-a28d-8908aed6f0f8", new DateTime(2024, 8, 22, 13, 29, 17, 398, DateTimeKind.Utc).AddTicks(68), new DateTime(2024, 8, 22, 13, 29, 17, 398, DateTimeKind.Utc).AddTicks(69), new DateTime(2024, 8, 22, 13, 29, 17, 398, DateTimeKind.Utc).AddTicks(65) });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: 2009,
                columns: new[] { "ConcurrencyStamp", "CreatedTime", "LastUpdatedTime", "RefreshTokenCreateTime" },
                values: new object[] { "42d574fd-fd71-4830-9ed9-b3877ba99ed7", new DateTime(2024, 8, 22, 13, 29, 17, 398, DateTimeKind.Utc).AddTicks(84), new DateTime(2024, 8, 22, 13, 29, 17, 398, DateTimeKind.Utc).AddTicks(84), new DateTime(2024, 8, 22, 13, 29, 17, 398, DateTimeKind.Utc).AddTicks(76) });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: 2010,
                columns: new[] { "ConcurrencyStamp", "CreatedTime", "LastUpdatedTime", "RefreshTokenCreateTime" },
                values: new object[] { "0230be15-ae84-449f-bcab-79bf2bf20ce6", new DateTime(2024, 8, 22, 13, 29, 17, 398, DateTimeKind.Utc).AddTicks(97), new DateTime(2024, 8, 22, 13, 29, 17, 398, DateTimeKind.Utc).AddTicks(98), new DateTime(2024, 8, 22, 13, 29, 17, 398, DateTimeKind.Utc).AddTicks(94) });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: 2011,
                columns: new[] { "ConcurrencyStamp", "CreatedTime", "LastUpdatedTime", "RefreshTokenCreateTime" },
                values: new object[] { "1bb826c5-90d5-4430-9314-eda5ff6a1010", new DateTime(2024, 8, 22, 13, 29, 17, 398, DateTimeKind.Utc).AddTicks(112), new DateTime(2024, 8, 22, 13, 29, 17, 398, DateTimeKind.Utc).AddTicks(112), new DateTime(2024, 8, 22, 13, 29, 17, 398, DateTimeKind.Utc).AddTicks(109) });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: 2012,
                columns: new[] { "ConcurrencyStamp", "CreatedTime", "LastUpdatedTime", "RefreshTokenCreateTime" },
                values: new object[] { "94261bbd-2618-4d20-8312-07361555af36", new DateTime(2024, 8, 22, 13, 29, 17, 398, DateTimeKind.Utc).AddTicks(124), new DateTime(2024, 8, 22, 13, 29, 17, 398, DateTimeKind.Utc).AddTicks(124), new DateTime(2024, 8, 22, 13, 29, 17, 398, DateTimeKind.Utc).AddTicks(121) });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: 2013,
                columns: new[] { "ConcurrencyStamp", "CreatedTime", "LastUpdatedTime", "RefreshTokenCreateTime" },
                values: new object[] { "1d14fe0a-5d8a-4700-b65d-629de2aee947", new DateTime(2024, 8, 22, 13, 29, 17, 398, DateTimeKind.Utc).AddTicks(136), new DateTime(2024, 8, 22, 13, 29, 17, 398, DateTimeKind.Utc).AddTicks(136), new DateTime(2024, 8, 22, 13, 29, 17, 398, DateTimeKind.Utc).AddTicks(132) });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: 2014,
                columns: new[] { "ConcurrencyStamp", "CreatedTime", "LastUpdatedTime", "RefreshTokenCreateTime" },
                values: new object[] { "ebc9308b-7b63-4274-9321-f15b7a1038ca", new DateTime(2024, 8, 22, 13, 29, 17, 398, DateTimeKind.Utc).AddTicks(188), new DateTime(2024, 8, 22, 13, 29, 17, 398, DateTimeKind.Utc).AddTicks(189), new DateTime(2024, 8, 22, 13, 29, 17, 398, DateTimeKind.Utc).AddTicks(184) });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: 2015,
                columns: new[] { "ConcurrencyStamp", "CreatedTime", "LastUpdatedTime", "RefreshTokenCreateTime" },
                values: new object[] { "d02e9e57-235f-4b21-a8a3-b8c71757d001", new DateTime(2024, 8, 22, 13, 29, 17, 398, DateTimeKind.Utc).AddTicks(201), new DateTime(2024, 8, 22, 13, 29, 17, 398, DateTimeKind.Utc).AddTicks(201), new DateTime(2024, 8, 22, 13, 29, 17, 398, DateTimeKind.Utc).AddTicks(198) });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: 2016,
                columns: new[] { "ConcurrencyStamp", "CreatedTime", "LastUpdatedTime", "RefreshTokenCreateTime" },
                values: new object[] { "1b5f4a44-8ea5-4b5a-a4bc-410f7e39510b", new DateTime(2024, 8, 22, 13, 29, 17, 398, DateTimeKind.Utc).AddTicks(212), new DateTime(2024, 8, 22, 13, 29, 17, 398, DateTimeKind.Utc).AddTicks(213), new DateTime(2024, 8, 22, 13, 29, 17, 398, DateTimeKind.Utc).AddTicks(210) });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: 2017,
                columns: new[] { "ConcurrencyStamp", "CreatedTime", "LastUpdatedTime", "RefreshTokenCreateTime" },
                values: new object[] { "db187d4e-44c9-4564-adb1-3a73a5fb6169", new DateTime(2024, 8, 22, 13, 29, 17, 398, DateTimeKind.Utc).AddTicks(227), new DateTime(2024, 8, 22, 13, 29, 17, 398, DateTimeKind.Utc).AddTicks(228), new DateTime(2024, 8, 22, 13, 29, 17, 398, DateTimeKind.Utc).AddTicks(221) });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: 2018,
                columns: new[] { "ConcurrencyStamp", "CreatedTime", "LastUpdatedTime", "RefreshTokenCreateTime" },
                values: new object[] { "73de01b2-fcf5-4447-97e8-9b1bd6de478f", new DateTime(2024, 8, 22, 13, 29, 17, 398, DateTimeKind.Utc).AddTicks(241), new DateTime(2024, 8, 22, 13, 29, 17, 398, DateTimeKind.Utc).AddTicks(241), new DateTime(2024, 8, 22, 13, 29, 17, 398, DateTimeKind.Utc).AddTicks(238) });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: 2019,
                columns: new[] { "ConcurrencyStamp", "CreatedTime", "LastUpdatedTime", "RefreshTokenCreateTime" },
                values: new object[] { "92dcd971-e09f-4ae2-a9fd-ca345d69b98d", new DateTime(2024, 8, 22, 13, 29, 17, 398, DateTimeKind.Utc).AddTicks(252), new DateTime(2024, 8, 22, 13, 29, 17, 398, DateTimeKind.Utc).AddTicks(253), new DateTime(2024, 8, 22, 13, 29, 17, 398, DateTimeKind.Utc).AddTicks(249) });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: 2020,
                columns: new[] { "ConcurrencyStamp", "CreatedTime", "LastUpdatedTime", "RefreshTokenCreateTime" },
                values: new object[] { "6dfa7895-a6a0-4058-b5e7-0bdb67113a8a", new DateTime(2024, 8, 22, 13, 29, 17, 398, DateTimeKind.Utc).AddTicks(264), new DateTime(2024, 8, 22, 13, 29, 17, 398, DateTimeKind.Utc).AddTicks(265), new DateTime(2024, 8, 22, 13, 29, 17, 398, DateTimeKind.Utc).AddTicks(261) });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: 2021,
                columns: new[] { "ConcurrencyStamp", "CreatedTime", "LastUpdatedTime", "RefreshTokenCreateTime" },
                values: new object[] { "55f4c7e2-5b68-46d4-89fe-65ec80e6b9ce", new DateTime(2024, 8, 22, 13, 29, 17, 398, DateTimeKind.Utc).AddTicks(276), new DateTime(2024, 8, 22, 13, 29, 17, 398, DateTimeKind.Utc).AddTicks(276), new DateTime(2024, 8, 22, 13, 29, 17, 398, DateTimeKind.Utc).AddTicks(273) });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: 2022,
                columns: new[] { "ConcurrencyStamp", "CreatedTime", "LastUpdatedTime", "RefreshTokenCreateTime" },
                values: new object[] { "19e55457-1395-4c4e-835f-c622ee2d2555", new DateTime(2024, 8, 22, 13, 29, 17, 398, DateTimeKind.Utc).AddTicks(295), new DateTime(2024, 8, 22, 13, 29, 17, 398, DateTimeKind.Utc).AddTicks(296), new DateTime(2024, 8, 22, 13, 29, 17, 398, DateTimeKind.Utc).AddTicks(292) });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: 2023,
                columns: new[] { "ConcurrencyStamp", "CreatedTime", "LastUpdatedTime", "RefreshTokenCreateTime" },
                values: new object[] { "0d7b2a35-f97d-4278-b05b-6f8dc4019046", new DateTime(2024, 8, 22, 13, 29, 17, 398, DateTimeKind.Utc).AddTicks(402), new DateTime(2024, 8, 22, 13, 29, 17, 398, DateTimeKind.Utc).AddTicks(402), new DateTime(2024, 8, 22, 13, 29, 17, 398, DateTimeKind.Utc).AddTicks(397) });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: 2024,
                columns: new[] { "ConcurrencyStamp", "CreatedTime", "LastUpdatedTime", "RefreshTokenCreateTime" },
                values: new object[] { "262c8f29-5b69-403e-9969-859b0715d7f1", new DateTime(2024, 8, 22, 13, 29, 17, 398, DateTimeKind.Utc).AddTicks(418), new DateTime(2024, 8, 22, 13, 29, 17, 398, DateTimeKind.Utc).AddTicks(419), new DateTime(2024, 8, 22, 13, 29, 17, 398, DateTimeKind.Utc).AddTicks(415) });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: 2025,
                columns: new[] { "ConcurrencyStamp", "CreatedTime", "LastUpdatedTime", "RefreshTokenCreateTime" },
                values: new object[] { "a3c42cbe-0eec-4825-b284-8202edc23e16", new DateTime(2024, 8, 22, 13, 29, 17, 398, DateTimeKind.Utc).AddTicks(434), new DateTime(2024, 8, 22, 13, 29, 17, 398, DateTimeKind.Utc).AddTicks(435), new DateTime(2024, 8, 22, 13, 29, 17, 398, DateTimeKind.Utc).AddTicks(428) });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: 2026,
                columns: new[] { "ConcurrencyStamp", "CreatedTime", "LastUpdatedTime", "RefreshTokenCreateTime" },
                values: new object[] { "fa2f6ca5-f0f4-4dd6-8dbf-b80dea44b37a", new DateTime(2024, 8, 22, 13, 29, 17, 398, DateTimeKind.Utc).AddTicks(447), new DateTime(2024, 8, 22, 13, 29, 17, 398, DateTimeKind.Utc).AddTicks(447), new DateTime(2024, 8, 22, 13, 29, 17, 398, DateTimeKind.Utc).AddTicks(444) });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: 2027,
                columns: new[] { "ConcurrencyStamp", "CreatedTime", "LastUpdatedTime", "RefreshTokenCreateTime" },
                values: new object[] { "9bd6fee1-36eb-419f-b566-e3c6872fb907", new DateTime(2024, 8, 22, 13, 29, 17, 398, DateTimeKind.Utc).AddTicks(460), new DateTime(2024, 8, 22, 13, 29, 17, 398, DateTimeKind.Utc).AddTicks(461), new DateTime(2024, 8, 22, 13, 29, 17, 398, DateTimeKind.Utc).AddTicks(457) });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: 2028,
                columns: new[] { "ConcurrencyStamp", "CreatedTime", "LastUpdatedTime", "RefreshTokenCreateTime" },
                values: new object[] { "ca00f0e4-a7a4-4378-b38f-814b1af30dd1", new DateTime(2024, 8, 22, 13, 29, 17, 398, DateTimeKind.Utc).AddTicks(473), new DateTime(2024, 8, 22, 13, 29, 17, 398, DateTimeKind.Utc).AddTicks(473), new DateTime(2024, 8, 22, 13, 29, 17, 398, DateTimeKind.Utc).AddTicks(470) });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: 2029,
                columns: new[] { "ConcurrencyStamp", "CreatedTime", "LastUpdatedTime", "RefreshTokenCreateTime" },
                values: new object[] { "4311d58f-2bf7-446a-8257-473de81a1ad8", new DateTime(2024, 8, 22, 13, 29, 17, 398, DateTimeKind.Utc).AddTicks(485), new DateTime(2024, 8, 22, 13, 29, 17, 398, DateTimeKind.Utc).AddTicks(486), new DateTime(2024, 8, 22, 13, 29, 17, 398, DateTimeKind.Utc).AddTicks(482) });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: 2030,
                columns: new[] { "ConcurrencyStamp", "CreatedTime", "LastUpdatedTime", "RefreshTokenCreateTime" },
                values: new object[] { "710dbdaa-6fdb-46d7-b9a2-fba7ceb53048", new DateTime(2024, 8, 22, 13, 29, 17, 398, DateTimeKind.Utc).AddTicks(498), new DateTime(2024, 8, 22, 13, 29, 17, 398, DateTimeKind.Utc).AddTicks(499), new DateTime(2024, 8, 22, 13, 29, 17, 398, DateTimeKind.Utc).AddTicks(495) });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: 2031,
                columns: new[] { "ConcurrencyStamp", "CreatedTime", "LastUpdatedTime", "RefreshTokenCreateTime" },
                values: new object[] { "dec62baf-9e84-40c8-b9bc-9d393db4c4b4", new DateTime(2024, 8, 22, 13, 29, 17, 398, DateTimeKind.Utc).AddTicks(511), new DateTime(2024, 8, 22, 13, 29, 17, 398, DateTimeKind.Utc).AddTicks(512), new DateTime(2024, 8, 22, 13, 29, 17, 398, DateTimeKind.Utc).AddTicks(508) });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: 2032,
                columns: new[] { "ConcurrencyStamp", "CreatedTime", "LastUpdatedTime", "RefreshTokenCreateTime" },
                values: new object[] { "a78446bf-a773-4bfc-8408-246cfcd2cba7", new DateTime(2024, 8, 22, 13, 29, 17, 398, DateTimeKind.Utc).AddTicks(586), new DateTime(2024, 8, 22, 13, 29, 17, 398, DateTimeKind.Utc).AddTicks(586), new DateTime(2024, 8, 22, 13, 29, 17, 398, DateTimeKind.Utc).AddTicks(582) });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: 2033,
                columns: new[] { "ConcurrencyStamp", "CreatedTime", "LastUpdatedTime", "RefreshTokenCreateTime" },
                values: new object[] { "019f0319-a7a4-42a8-8d12-333196fd203f", new DateTime(2024, 8, 22, 13, 29, 17, 398, DateTimeKind.Utc).AddTicks(602), new DateTime(2024, 8, 22, 13, 29, 17, 398, DateTimeKind.Utc).AddTicks(603), new DateTime(2024, 8, 22, 13, 29, 17, 398, DateTimeKind.Utc).AddTicks(596) });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: 2034,
                columns: new[] { "ConcurrencyStamp", "CreatedTime", "LastUpdatedTime", "RefreshTokenCreateTime" },
                values: new object[] { "ce765218-9276-4375-abe5-a5e0c944740f", new DateTime(2024, 8, 22, 13, 29, 17, 398, DateTimeKind.Utc).AddTicks(617), new DateTime(2024, 8, 22, 13, 29, 17, 398, DateTimeKind.Utc).AddTicks(618), new DateTime(2024, 8, 22, 13, 29, 17, 398, DateTimeKind.Utc).AddTicks(614) });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: 2035,
                columns: new[] { "ConcurrencyStamp", "CreatedTime", "LastUpdatedTime", "RefreshTokenCreateTime" },
                values: new object[] { "58ac2385-8401-4014-86ca-de54679b0d61", new DateTime(2024, 8, 22, 13, 29, 17, 398, DateTimeKind.Utc).AddTicks(630), new DateTime(2024, 8, 22, 13, 29, 17, 398, DateTimeKind.Utc).AddTicks(630), new DateTime(2024, 8, 22, 13, 29, 17, 398, DateTimeKind.Utc).AddTicks(627) });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: 2036,
                columns: new[] { "ConcurrencyStamp", "CreatedTime", "LastUpdatedTime", "RefreshTokenCreateTime" },
                values: new object[] { "f69e49f1-d7ac-42b3-b82f-306c53dda018", new DateTime(2024, 8, 22, 13, 29, 17, 398, DateTimeKind.Utc).AddTicks(643), new DateTime(2024, 8, 22, 13, 29, 17, 398, DateTimeKind.Utc).AddTicks(643), new DateTime(2024, 8, 22, 13, 29, 17, 398, DateTimeKind.Utc).AddTicks(639) });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: 2037,
                columns: new[] { "ConcurrencyStamp", "CreatedTime", "LastUpdatedTime", "RefreshTokenCreateTime" },
                values: new object[] { "368162bd-494c-4a7f-9bd4-c228611f74bc", new DateTime(2024, 8, 22, 13, 29, 17, 398, DateTimeKind.Utc).AddTicks(655), new DateTime(2024, 8, 22, 13, 29, 17, 398, DateTimeKind.Utc).AddTicks(655), new DateTime(2024, 8, 22, 13, 29, 17, 398, DateTimeKind.Utc).AddTicks(652) });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: 2038,
                columns: new[] { "ConcurrencyStamp", "CreatedTime", "LastUpdatedTime", "RefreshTokenCreateTime" },
                values: new object[] { "d329cd76-d884-4233-95b3-53a93a048f56", new DateTime(2024, 8, 22, 13, 29, 17, 398, DateTimeKind.Utc).AddTicks(667), new DateTime(2024, 8, 22, 13, 29, 17, 398, DateTimeKind.Utc).AddTicks(668), new DateTime(2024, 8, 22, 13, 29, 17, 398, DateTimeKind.Utc).AddTicks(664) });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: 2039,
                columns: new[] { "ConcurrencyStamp", "CreatedTime", "LastUpdatedTime", "RefreshTokenCreateTime" },
                values: new object[] { "fe18f4b1-b615-421c-84c3-5ea5b8c2eccf", new DateTime(2024, 8, 22, 13, 29, 17, 398, DateTimeKind.Utc).AddTicks(680), new DateTime(2024, 8, 22, 13, 29, 17, 398, DateTimeKind.Utc).AddTicks(681), new DateTime(2024, 8, 22, 13, 29, 17, 398, DateTimeKind.Utc).AddTicks(677) });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: 2040,
                columns: new[] { "ConcurrencyStamp", "CreatedTime", "LastUpdatedTime", "RefreshTokenCreateTime" },
                values: new object[] { "eb3edaac-d8cb-45b6-8225-295df4ed8253", new DateTime(2024, 8, 22, 13, 29, 17, 398, DateTimeKind.Utc).AddTicks(723), new DateTime(2024, 8, 22, 13, 29, 17, 398, DateTimeKind.Utc).AddTicks(724), new DateTime(2024, 8, 22, 13, 29, 17, 398, DateTimeKind.Utc).AddTicks(720) });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: 2041,
                columns: new[] { "ConcurrencyStamp", "CreatedTime", "LastUpdatedTime", "RefreshTokenCreateTime" },
                values: new object[] { "f0f1d4a3-d4c6-4410-8685-78ca1785dc4d", new DateTime(2024, 8, 22, 13, 29, 17, 398, DateTimeKind.Utc).AddTicks(740), new DateTime(2024, 8, 22, 13, 29, 17, 398, DateTimeKind.Utc).AddTicks(740), new DateTime(2024, 8, 22, 13, 29, 17, 398, DateTimeKind.Utc).AddTicks(734) });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: 2042,
                columns: new[] { "ConcurrencyStamp", "CreatedTime", "LastUpdatedTime", "RefreshTokenCreateTime" },
                values: new object[] { "3b647d72-59e9-4769-a9df-c2d885f05282", new DateTime(2024, 8, 22, 13, 29, 17, 398, DateTimeKind.Utc).AddTicks(757), new DateTime(2024, 8, 22, 13, 29, 17, 398, DateTimeKind.Utc).AddTicks(757), new DateTime(2024, 8, 22, 13, 29, 17, 398, DateTimeKind.Utc).AddTicks(754) });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: 2043,
                columns: new[] { "ConcurrencyStamp", "CreatedTime", "LastUpdatedTime", "RefreshTokenCreateTime" },
                values: new object[] { "5ff31c53-8205-4e97-a2ba-9b0fd9bb01a6", new DateTime(2024, 8, 22, 13, 29, 17, 398, DateTimeKind.Utc).AddTicks(769), new DateTime(2024, 8, 22, 13, 29, 17, 398, DateTimeKind.Utc).AddTicks(770), new DateTime(2024, 8, 22, 13, 29, 17, 398, DateTimeKind.Utc).AddTicks(766) });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: 2044,
                columns: new[] { "ConcurrencyStamp", "CreatedTime", "LastUpdatedTime", "RefreshTokenCreateTime" },
                values: new object[] { "f70a646c-9e54-4ed1-8b94-4638ad8739b9", new DateTime(2024, 8, 22, 13, 29, 17, 398, DateTimeKind.Utc).AddTicks(780), new DateTime(2024, 8, 22, 13, 29, 17, 398, DateTimeKind.Utc).AddTicks(781), new DateTime(2024, 8, 22, 13, 29, 17, 398, DateTimeKind.Utc).AddTicks(777) });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: 2045,
                columns: new[] { "ConcurrencyStamp", "CreatedTime", "LastUpdatedTime", "RefreshTokenCreateTime" },
                values: new object[] { "dda614a0-abdc-4711-98a5-51947a1cc225", new DateTime(2024, 8, 22, 13, 29, 17, 398, DateTimeKind.Utc).AddTicks(792), new DateTime(2024, 8, 22, 13, 29, 17, 398, DateTimeKind.Utc).AddTicks(792), new DateTime(2024, 8, 22, 13, 29, 17, 398, DateTimeKind.Utc).AddTicks(789) });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: 2046,
                columns: new[] { "ConcurrencyStamp", "CreatedTime", "LastUpdatedTime", "RefreshTokenCreateTime" },
                values: new object[] { "865a9336-7a32-40bc-af93-a987b3450475", new DateTime(2024, 8, 22, 13, 29, 17, 398, DateTimeKind.Utc).AddTicks(804), new DateTime(2024, 8, 22, 13, 29, 17, 398, DateTimeKind.Utc).AddTicks(805), new DateTime(2024, 8, 22, 13, 29, 17, 398, DateTimeKind.Utc).AddTicks(801) });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: 2047,
                columns: new[] { "ConcurrencyStamp", "CreatedTime", "LastUpdatedTime", "RefreshTokenCreateTime" },
                values: new object[] { "35845774-2b04-4249-9404-9c134270d24d", new DateTime(2024, 8, 22, 13, 29, 17, 398, DateTimeKind.Utc).AddTicks(816), new DateTime(2024, 8, 22, 13, 29, 17, 398, DateTimeKind.Utc).AddTicks(817), new DateTime(2024, 8, 22, 13, 29, 17, 398, DateTimeKind.Utc).AddTicks(813) });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: 2048,
                columns: new[] { "ConcurrencyStamp", "CreatedTime", "LastUpdatedTime", "RefreshTokenCreateTime" },
                values: new object[] { "e412eab7-eca6-431b-9e58-14ffeec8de52", new DateTime(2024, 8, 22, 13, 29, 17, 398, DateTimeKind.Utc).AddTicks(828), new DateTime(2024, 8, 22, 13, 29, 17, 398, DateTimeKind.Utc).AddTicks(828), new DateTime(2024, 8, 22, 13, 29, 17, 398, DateTimeKind.Utc).AddTicks(825) });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: 2049,
                columns: new[] { "ConcurrencyStamp", "CreatedTime", "LastUpdatedTime", "RefreshTokenCreateTime" },
                values: new object[] { "a6705f8a-b8bd-4520-b9cd-aba3b39185a0", new DateTime(2024, 8, 22, 13, 29, 17, 398, DateTimeKind.Utc).AddTicks(842), new DateTime(2024, 8, 22, 13, 29, 17, 398, DateTimeKind.Utc).AddTicks(843), new DateTime(2024, 8, 22, 13, 29, 17, 398, DateTimeKind.Utc).AddTicks(837) });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: 2050,
                columns: new[] { "ConcurrencyStamp", "CreatedTime", "LastUpdatedTime", "RefreshTokenCreateTime" },
                values: new object[] { "f218a8d9-e0e0-4619-b3a8-dd44205020f4", new DateTime(2024, 8, 22, 13, 29, 17, 398, DateTimeKind.Utc).AddTicks(884), new DateTime(2024, 8, 22, 13, 29, 17, 398, DateTimeKind.Utc).AddTicks(884), new DateTime(2024, 8, 22, 13, 29, 17, 398, DateTimeKind.Utc).AddTicks(880) });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: 2051,
                columns: new[] { "ConcurrencyStamp", "CreatedTime", "LastUpdatedTime", "RefreshTokenCreateTime" },
                values: new object[] { "ee149c39-b894-48fb-9578-98523f8fa97d", new DateTime(2024, 8, 22, 13, 29, 17, 398, DateTimeKind.Utc).AddTicks(897), new DateTime(2024, 8, 22, 13, 29, 17, 398, DateTimeKind.Utc).AddTicks(898), new DateTime(2024, 8, 22, 13, 29, 17, 398, DateTimeKind.Utc).AddTicks(893) });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: 2052,
                columns: new[] { "ConcurrencyStamp", "CreatedTime", "LastUpdatedTime", "RefreshTokenCreateTime" },
                values: new object[] { "dc7ee3c6-6c87-47fa-bb66-a6c5b71e6f6a", new DateTime(2024, 8, 22, 13, 29, 17, 398, DateTimeKind.Utc).AddTicks(909), new DateTime(2024, 8, 22, 13, 29, 17, 398, DateTimeKind.Utc).AddTicks(909), new DateTime(2024, 8, 22, 13, 29, 17, 398, DateTimeKind.Utc).AddTicks(906) });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: 2053,
                columns: new[] { "ConcurrencyStamp", "CreatedTime", "LastUpdatedTime", "RefreshTokenCreateTime" },
                values: new object[] { "22b576b8-3f5a-4cd3-9f75-6418510bd68d", new DateTime(2024, 8, 22, 13, 29, 17, 398, DateTimeKind.Utc).AddTicks(920), new DateTime(2024, 8, 22, 13, 29, 17, 398, DateTimeKind.Utc).AddTicks(921), new DateTime(2024, 8, 22, 13, 29, 17, 398, DateTimeKind.Utc).AddTicks(917) });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: 2054,
                columns: new[] { "ConcurrencyStamp", "CreatedTime", "LastUpdatedTime", "RefreshTokenCreateTime" },
                values: new object[] { "60073ebb-1e97-4ef7-a227-6d34fd2bbabc", new DateTime(2024, 8, 22, 13, 29, 17, 398, DateTimeKind.Utc).AddTicks(932), new DateTime(2024, 8, 22, 13, 29, 17, 398, DateTimeKind.Utc).AddTicks(932), new DateTime(2024, 8, 22, 13, 29, 17, 398, DateTimeKind.Utc).AddTicks(929) });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: 2055,
                columns: new[] { "ConcurrencyStamp", "CreatedTime", "LastUpdatedTime", "RefreshTokenCreateTime" },
                values: new object[] { "2b600f07-53a0-43d7-bcfb-d5b8f8db4bc4", new DateTime(2024, 8, 22, 13, 29, 17, 398, DateTimeKind.Utc).AddTicks(943), new DateTime(2024, 8, 22, 13, 29, 17, 398, DateTimeKind.Utc).AddTicks(944), new DateTime(2024, 8, 22, 13, 29, 17, 398, DateTimeKind.Utc).AddTicks(940) });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: 2056,
                columns: new[] { "ConcurrencyStamp", "CreatedTime", "LastUpdatedTime", "RefreshTokenCreateTime" },
                values: new object[] { "a2cbf250-5549-4f82-bf93-26ef28b783de", new DateTime(2024, 8, 22, 13, 29, 17, 398, DateTimeKind.Utc).AddTicks(955), new DateTime(2024, 8, 22, 13, 29, 17, 398, DateTimeKind.Utc).AddTicks(955), new DateTime(2024, 8, 22, 13, 29, 17, 398, DateTimeKind.Utc).AddTicks(952) });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: 2057,
                columns: new[] { "ConcurrencyStamp", "CreatedTime", "LastUpdatedTime", "RefreshTokenCreateTime" },
                values: new object[] { "3b74372f-c9fc-4b0b-b5c0-da4bc8a8ebfc", new DateTime(2024, 8, 22, 13, 29, 17, 398, DateTimeKind.Utc).AddTicks(970), new DateTime(2024, 8, 22, 13, 29, 17, 398, DateTimeKind.Utc).AddTicks(970), new DateTime(2024, 8, 22, 13, 29, 17, 398, DateTimeKind.Utc).AddTicks(964) });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: 2058,
                columns: new[] { "ConcurrencyStamp", "CreatedTime", "LastUpdatedTime", "RefreshTokenCreateTime" },
                values: new object[] { "aa3c9c6e-9039-45ae-8111-3db5a243f2e8", new DateTime(2024, 8, 22, 13, 29, 17, 398, DateTimeKind.Utc).AddTicks(981), new DateTime(2024, 8, 22, 13, 29, 17, 398, DateTimeKind.Utc).AddTicks(982), new DateTime(2024, 8, 22, 13, 29, 17, 398, DateTimeKind.Utc).AddTicks(978) });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: 2059,
                columns: new[] { "ConcurrencyStamp", "CreatedTime", "LastUpdatedTime", "RefreshTokenCreateTime" },
                values: new object[] { "fbd62533-88d7-4fcd-8dd9-c543e36fe6fa", new DateTime(2024, 8, 22, 13, 29, 17, 398, DateTimeKind.Utc).AddTicks(992), new DateTime(2024, 8, 22, 13, 29, 17, 398, DateTimeKind.Utc).AddTicks(992), new DateTime(2024, 8, 22, 13, 29, 17, 398, DateTimeKind.Utc).AddTicks(989) });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: 2060,
                columns: new[] { "ConcurrencyStamp", "CreatedTime", "LastUpdatedTime", "RefreshTokenCreateTime" },
                values: new object[] { "3e187a8e-4654-4e3c-a820-a45167610877", new DateTime(2024, 8, 22, 13, 29, 17, 398, DateTimeKind.Utc).AddTicks(1052), new DateTime(2024, 8, 22, 13, 29, 17, 398, DateTimeKind.Utc).AddTicks(1053), new DateTime(2024, 8, 22, 13, 29, 17, 398, DateTimeKind.Utc).AddTicks(1048) });

            migrationBuilder.UpdateData(
                table: "Breeds",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedTime",
                value: new DateTime(2024, 8, 22, 17, 29, 17, 389, DateTimeKind.Local).AddTicks(193));

            migrationBuilder.UpdateData(
                table: "Breeds",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreatedTime",
                value: new DateTime(2024, 8, 22, 17, 29, 17, 389, DateTimeKind.Local).AddTicks(201));

            migrationBuilder.UpdateData(
                table: "Breeds",
                keyColumn: "Id",
                keyValue: 3,
                column: "CreatedTime",
                value: new DateTime(2024, 8, 22, 17, 29, 17, 389, DateTimeKind.Local).AddTicks(202));

            migrationBuilder.UpdateData(
                table: "Breeds",
                keyColumn: "Id",
                keyValue: 4,
                column: "CreatedTime",
                value: new DateTime(2024, 8, 22, 17, 29, 17, 389, DateTimeKind.Local).AddTicks(203));

            migrationBuilder.UpdateData(
                table: "Breeds",
                keyColumn: "Id",
                keyValue: 5,
                column: "CreatedTime",
                value: new DateTime(2024, 8, 22, 17, 29, 17, 389, DateTimeKind.Local).AddTicks(206));

            migrationBuilder.UpdateData(
                table: "Breeds",
                keyColumn: "Id",
                keyValue: 6,
                column: "CreatedTime",
                value: new DateTime(2024, 8, 22, 17, 29, 17, 389, DateTimeKind.Local).AddTicks(207));

            migrationBuilder.UpdateData(
                table: "Breeds",
                keyColumn: "Id",
                keyValue: 7,
                column: "CreatedTime",
                value: new DateTime(2024, 8, 22, 17, 29, 17, 389, DateTimeKind.Local).AddTicks(209));

            migrationBuilder.UpdateData(
                table: "Breeds",
                keyColumn: "Id",
                keyValue: 8,
                column: "CreatedTime",
                value: new DateTime(2024, 8, 22, 17, 29, 17, 389, DateTimeKind.Local).AddTicks(210));

            migrationBuilder.UpdateData(
                table: "Breeds",
                keyColumn: "Id",
                keyValue: 9,
                column: "CreatedTime",
                value: new DateTime(2024, 8, 22, 17, 29, 17, 389, DateTimeKind.Local).AddTicks(211));

            migrationBuilder.UpdateData(
                table: "Breeds",
                keyColumn: "Id",
                keyValue: 10,
                column: "CreatedTime",
                value: new DateTime(2024, 8, 22, 17, 29, 17, 389, DateTimeKind.Local).AddTicks(213));

            migrationBuilder.UpdateData(
                table: "Breeds",
                keyColumn: "Id",
                keyValue: 11,
                column: "CreatedTime",
                value: new DateTime(2024, 8, 22, 17, 29, 17, 389, DateTimeKind.Local).AddTicks(215));

            migrationBuilder.UpdateData(
                table: "Breeds",
                keyColumn: "Id",
                keyValue: 12,
                column: "CreatedTime",
                value: new DateTime(2024, 8, 22, 17, 29, 17, 389, DateTimeKind.Local).AddTicks(216));

            migrationBuilder.UpdateData(
                table: "Breeds",
                keyColumn: "Id",
                keyValue: 13,
                column: "CreatedTime",
                value: new DateTime(2024, 8, 22, 17, 29, 17, 389, DateTimeKind.Local).AddTicks(217));

            migrationBuilder.UpdateData(
                table: "Breeds",
                keyColumn: "Id",
                keyValue: 14,
                column: "CreatedTime",
                value: new DateTime(2024, 8, 22, 17, 29, 17, 389, DateTimeKind.Local).AddTicks(219));

            migrationBuilder.UpdateData(
                table: "Breeds",
                keyColumn: "Id",
                keyValue: 15,
                column: "CreatedTime",
                value: new DateTime(2024, 8, 22, 17, 29, 17, 389, DateTimeKind.Local).AddTicks(220));

            migrationBuilder.UpdateData(
                table: "Breeds",
                keyColumn: "Id",
                keyValue: 16,
                column: "CreatedTime",
                value: new DateTime(2024, 8, 22, 17, 29, 17, 389, DateTimeKind.Local).AddTicks(221));

            migrationBuilder.UpdateData(
                table: "Breeds",
                keyColumn: "Id",
                keyValue: 17,
                column: "CreatedTime",
                value: new DateTime(2024, 8, 22, 17, 29, 17, 389, DateTimeKind.Local).AddTicks(223));

            migrationBuilder.UpdateData(
                table: "Breeds",
                keyColumn: "Id",
                keyValue: 18,
                column: "CreatedTime",
                value: new DateTime(2024, 8, 22, 17, 29, 17, 389, DateTimeKind.Local).AddTicks(224));

            migrationBuilder.UpdateData(
                table: "Breeds",
                keyColumn: "Id",
                keyValue: 19,
                column: "CreatedTime",
                value: new DateTime(2024, 8, 22, 17, 29, 17, 389, DateTimeKind.Local).AddTicks(225));

            migrationBuilder.UpdateData(
                table: "Breeds",
                keyColumn: "Id",
                keyValue: 20,
                column: "CreatedTime",
                value: new DateTime(2024, 8, 22, 17, 29, 17, 389, DateTimeKind.Local).AddTicks(227));

            migrationBuilder.UpdateData(
                table: "Breeds",
                keyColumn: "Id",
                keyValue: 21,
                column: "CreatedTime",
                value: new DateTime(2024, 8, 22, 17, 29, 17, 389, DateTimeKind.Local).AddTicks(228));

            migrationBuilder.UpdateData(
                table: "Breeds",
                keyColumn: "Id",
                keyValue: 22,
                column: "CreatedTime",
                value: new DateTime(2024, 8, 22, 17, 29, 17, 389, DateTimeKind.Local).AddTicks(229));

            migrationBuilder.UpdateData(
                table: "Breeds",
                keyColumn: "Id",
                keyValue: 23,
                column: "CreatedTime",
                value: new DateTime(2024, 8, 22, 17, 29, 17, 389, DateTimeKind.Local).AddTicks(231));

            migrationBuilder.UpdateData(
                table: "Breeds",
                keyColumn: "Id",
                keyValue: 24,
                column: "CreatedTime",
                value: new DateTime(2024, 8, 22, 17, 29, 17, 389, DateTimeKind.Local).AddTicks(232));

            migrationBuilder.UpdateData(
                table: "Breeds",
                keyColumn: "Id",
                keyValue: 25,
                column: "CreatedTime",
                value: new DateTime(2024, 8, 22, 17, 29, 17, 389, DateTimeKind.Local).AddTicks(233));

            migrationBuilder.UpdateData(
                table: "Breeds",
                keyColumn: "Id",
                keyValue: 26,
                column: "CreatedTime",
                value: new DateTime(2024, 8, 22, 17, 29, 17, 389, DateTimeKind.Local).AddTicks(266));

            migrationBuilder.UpdateData(
                table: "Breeds",
                keyColumn: "Id",
                keyValue: 27,
                column: "CreatedTime",
                value: new DateTime(2024, 8, 22, 17, 29, 17, 389, DateTimeKind.Local).AddTicks(268));

            migrationBuilder.UpdateData(
                table: "Breeds",
                keyColumn: "Id",
                keyValue: 28,
                column: "CreatedTime",
                value: new DateTime(2024, 8, 22, 17, 29, 17, 389, DateTimeKind.Local).AddTicks(269));

            migrationBuilder.UpdateData(
                table: "Breeds",
                keyColumn: "Id",
                keyValue: 29,
                column: "CreatedTime",
                value: new DateTime(2024, 8, 22, 17, 29, 17, 389, DateTimeKind.Local).AddTicks(271));

            migrationBuilder.UpdateData(
                table: "Breeds",
                keyColumn: "Id",
                keyValue: 30,
                column: "CreatedTime",
                value: new DateTime(2024, 8, 22, 17, 29, 17, 389, DateTimeKind.Local).AddTicks(272));

            migrationBuilder.UpdateData(
                table: "Breeds",
                keyColumn: "Id",
                keyValue: 31,
                column: "CreatedTime",
                value: new DateTime(2024, 8, 22, 17, 29, 17, 389, DateTimeKind.Local).AddTicks(273));

            migrationBuilder.UpdateData(
                table: "Breeds",
                keyColumn: "Id",
                keyValue: 32,
                column: "CreatedTime",
                value: new DateTime(2024, 8, 22, 17, 29, 17, 389, DateTimeKind.Local).AddTicks(275));

            migrationBuilder.UpdateData(
                table: "Breeds",
                keyColumn: "Id",
                keyValue: 33,
                column: "CreatedTime",
                value: new DateTime(2024, 8, 22, 17, 29, 17, 389, DateTimeKind.Local).AddTicks(276));

            migrationBuilder.UpdateData(
                table: "Breeds",
                keyColumn: "Id",
                keyValue: 34,
                column: "CreatedTime",
                value: new DateTime(2024, 8, 22, 17, 29, 17, 389, DateTimeKind.Local).AddTicks(277));

            migrationBuilder.UpdateData(
                table: "Breeds",
                keyColumn: "Id",
                keyValue: 35,
                column: "CreatedTime",
                value: new DateTime(2024, 8, 22, 17, 29, 17, 389, DateTimeKind.Local).AddTicks(279));

            migrationBuilder.UpdateData(
                table: "Breeds",
                keyColumn: "Id",
                keyValue: 36,
                column: "CreatedTime",
                value: new DateTime(2024, 8, 22, 17, 29, 17, 389, DateTimeKind.Local).AddTicks(280));

            migrationBuilder.UpdateData(
                table: "Breeds",
                keyColumn: "Id",
                keyValue: 37,
                column: "CreatedTime",
                value: new DateTime(2024, 8, 22, 17, 29, 17, 389, DateTimeKind.Local).AddTicks(281));

            migrationBuilder.UpdateData(
                table: "Breeds",
                keyColumn: "Id",
                keyValue: 38,
                column: "CreatedTime",
                value: new DateTime(2024, 8, 22, 17, 29, 17, 389, DateTimeKind.Local).AddTicks(282));

            migrationBuilder.UpdateData(
                table: "Breeds",
                keyColumn: "Id",
                keyValue: 39,
                column: "CreatedTime",
                value: new DateTime(2024, 8, 22, 17, 29, 17, 389, DateTimeKind.Local).AddTicks(284));

            migrationBuilder.UpdateData(
                table: "Breeds",
                keyColumn: "Id",
                keyValue: 40,
                column: "CreatedTime",
                value: new DateTime(2024, 8, 22, 17, 29, 17, 389, DateTimeKind.Local).AddTicks(285));

            migrationBuilder.UpdateData(
                table: "Breeds",
                keyColumn: "Id",
                keyValue: 41,
                column: "CreatedTime",
                value: new DateTime(2024, 8, 22, 17, 29, 17, 389, DateTimeKind.Local).AddTicks(286));

            migrationBuilder.UpdateData(
                table: "Breeds",
                keyColumn: "Id",
                keyValue: 42,
                column: "CreatedTime",
                value: new DateTime(2024, 8, 22, 17, 29, 17, 389, DateTimeKind.Local).AddTicks(287));

            migrationBuilder.UpdateData(
                table: "Breeds",
                keyColumn: "Id",
                keyValue: 43,
                column: "CreatedTime",
                value: new DateTime(2024, 8, 22, 17, 29, 17, 389, DateTimeKind.Local).AddTicks(289));

            migrationBuilder.UpdateData(
                table: "Breeds",
                keyColumn: "Id",
                keyValue: 44,
                column: "CreatedTime",
                value: new DateTime(2024, 8, 22, 17, 29, 17, 389, DateTimeKind.Local).AddTicks(290));

            migrationBuilder.UpdateData(
                table: "Breeds",
                keyColumn: "Id",
                keyValue: 45,
                column: "CreatedTime",
                value: new DateTime(2024, 8, 22, 17, 29, 17, 389, DateTimeKind.Local).AddTicks(292));

            migrationBuilder.UpdateData(
                table: "Breeds",
                keyColumn: "Id",
                keyValue: 46,
                column: "CreatedTime",
                value: new DateTime(2024, 8, 22, 17, 29, 17, 389, DateTimeKind.Local).AddTicks(294));

            migrationBuilder.UpdateData(
                table: "Breeds",
                keyColumn: "Id",
                keyValue: 47,
                column: "CreatedTime",
                value: new DateTime(2024, 8, 22, 17, 29, 17, 389, DateTimeKind.Local).AddTicks(295));

            migrationBuilder.UpdateData(
                table: "Breeds",
                keyColumn: "Id",
                keyValue: 48,
                column: "CreatedTime",
                value: new DateTime(2024, 8, 22, 17, 29, 17, 389, DateTimeKind.Local).AddTicks(296));

            migrationBuilder.UpdateData(
                table: "Breeds",
                keyColumn: "Id",
                keyValue: 49,
                column: "CreatedTime",
                value: new DateTime(2024, 8, 22, 17, 29, 17, 389, DateTimeKind.Local).AddTicks(298));

            migrationBuilder.UpdateData(
                table: "Breeds",
                keyColumn: "Id",
                keyValue: 50,
                column: "CreatedTime",
                value: new DateTime(2024, 8, 22, 17, 29, 17, 389, DateTimeKind.Local).AddTicks(299));

            migrationBuilder.UpdateData(
                table: "Breeds",
                keyColumn: "Id",
                keyValue: 51,
                column: "CreatedTime",
                value: new DateTime(2024, 8, 22, 17, 29, 17, 389, DateTimeKind.Local).AddTicks(300));

            migrationBuilder.UpdateData(
                table: "Breeds",
                keyColumn: "Id",
                keyValue: 52,
                column: "CreatedTime",
                value: new DateTime(2024, 8, 22, 17, 29, 17, 389, DateTimeKind.Local).AddTicks(302));

            migrationBuilder.UpdateData(
                table: "Breeds",
                keyColumn: "Id",
                keyValue: 53,
                column: "CreatedTime",
                value: new DateTime(2024, 8, 22, 17, 29, 17, 389, DateTimeKind.Local).AddTicks(303));

            migrationBuilder.UpdateData(
                table: "Breeds",
                keyColumn: "Id",
                keyValue: 54,
                column: "CreatedTime",
                value: new DateTime(2024, 8, 22, 17, 29, 17, 389, DateTimeKind.Local).AddTicks(304));

            migrationBuilder.UpdateData(
                table: "Breeds",
                keyColumn: "Id",
                keyValue: 55,
                column: "CreatedTime",
                value: new DateTime(2024, 8, 22, 17, 29, 17, 389, DateTimeKind.Local).AddTicks(306));

            migrationBuilder.UpdateData(
                table: "Breeds",
                keyColumn: "Id",
                keyValue: 56,
                column: "CreatedTime",
                value: new DateTime(2024, 8, 22, 17, 29, 17, 389, DateTimeKind.Local).AddTicks(307));

            migrationBuilder.UpdateData(
                table: "Breeds",
                keyColumn: "Id",
                keyValue: 57,
                column: "CreatedTime",
                value: new DateTime(2024, 8, 22, 17, 29, 17, 389, DateTimeKind.Local).AddTicks(308));

            migrationBuilder.UpdateData(
                table: "Breeds",
                keyColumn: "Id",
                keyValue: 58,
                column: "CreatedTime",
                value: new DateTime(2024, 8, 22, 17, 29, 17, 389, DateTimeKind.Local).AddTicks(310));

            migrationBuilder.UpdateData(
                table: "Breeds",
                keyColumn: "Id",
                keyValue: 59,
                column: "CreatedTime",
                value: new DateTime(2024, 8, 22, 17, 29, 17, 389, DateTimeKind.Local).AddTicks(311));

            migrationBuilder.UpdateData(
                table: "Breeds",
                keyColumn: "Id",
                keyValue: 60,
                column: "CreatedTime",
                value: new DateTime(2024, 8, 22, 17, 29, 17, 389, DateTimeKind.Local).AddTicks(312));

            migrationBuilder.UpdateData(
                table: "Breeds",
                keyColumn: "Id",
                keyValue: 61,
                column: "CreatedTime",
                value: new DateTime(2024, 8, 22, 17, 29, 17, 389, DateTimeKind.Local).AddTicks(314));

            migrationBuilder.UpdateData(
                table: "Breeds",
                keyColumn: "Id",
                keyValue: 62,
                column: "CreatedTime",
                value: new DateTime(2024, 8, 22, 17, 29, 17, 389, DateTimeKind.Local).AddTicks(315));

            migrationBuilder.UpdateData(
                table: "Breeds",
                keyColumn: "Id",
                keyValue: 63,
                column: "CreatedTime",
                value: new DateTime(2024, 8, 22, 17, 29, 17, 389, DateTimeKind.Local).AddTicks(317));

            migrationBuilder.UpdateData(
                table: "Breeds",
                keyColumn: "Id",
                keyValue: 64,
                column: "CreatedTime",
                value: new DateTime(2024, 8, 22, 17, 29, 17, 389, DateTimeKind.Local).AddTicks(318));

            migrationBuilder.UpdateData(
                table: "Breeds",
                keyColumn: "Id",
                keyValue: 65,
                column: "CreatedTime",
                value: new DateTime(2024, 8, 22, 17, 29, 17, 389, DateTimeKind.Local).AddTicks(319));

            migrationBuilder.UpdateData(
                table: "Breeds",
                keyColumn: "Id",
                keyValue: 66,
                column: "CreatedTime",
                value: new DateTime(2024, 8, 22, 17, 29, 17, 389, DateTimeKind.Local).AddTicks(320));

            migrationBuilder.UpdateData(
                table: "Breeds",
                keyColumn: "Id",
                keyValue: 67,
                column: "CreatedTime",
                value: new DateTime(2024, 8, 22, 17, 29, 17, 389, DateTimeKind.Local).AddTicks(322));

            migrationBuilder.UpdateData(
                table: "Breeds",
                keyColumn: "Id",
                keyValue: 68,
                column: "CreatedTime",
                value: new DateTime(2024, 8, 22, 17, 29, 17, 389, DateTimeKind.Local).AddTicks(323));

            migrationBuilder.UpdateData(
                table: "Breeds",
                keyColumn: "Id",
                keyValue: 69,
                column: "CreatedTime",
                value: new DateTime(2024, 8, 22, 17, 29, 17, 389, DateTimeKind.Local).AddTicks(324));

            migrationBuilder.UpdateData(
                table: "Breeds",
                keyColumn: "Id",
                keyValue: 70,
                column: "CreatedTime",
                value: new DateTime(2024, 8, 22, 17, 29, 17, 389, DateTimeKind.Local).AddTicks(325));

            migrationBuilder.UpdateData(
                table: "Breeds",
                keyColumn: "Id",
                keyValue: 71,
                column: "CreatedTime",
                value: new DateTime(2024, 8, 22, 17, 29, 17, 389, DateTimeKind.Local).AddTicks(327));

            migrationBuilder.UpdateData(
                table: "Breeds",
                keyColumn: "Id",
                keyValue: 72,
                column: "CreatedTime",
                value: new DateTime(2024, 8, 22, 17, 29, 17, 389, DateTimeKind.Local).AddTicks(328));

            migrationBuilder.UpdateData(
                table: "Breeds",
                keyColumn: "Id",
                keyValue: 73,
                column: "CreatedTime",
                value: new DateTime(2024, 8, 22, 17, 29, 17, 389, DateTimeKind.Local).AddTicks(329));

            migrationBuilder.UpdateData(
                table: "Breeds",
                keyColumn: "Id",
                keyValue: 74,
                column: "CreatedTime",
                value: new DateTime(2024, 8, 22, 17, 29, 17, 389, DateTimeKind.Local).AddTicks(332));

            migrationBuilder.UpdateData(
                table: "Breeds",
                keyColumn: "Id",
                keyValue: 75,
                column: "CreatedTime",
                value: new DateTime(2024, 8, 22, 17, 29, 17, 389, DateTimeKind.Local).AddTicks(333));

            migrationBuilder.UpdateData(
                table: "Breeds",
                keyColumn: "Id",
                keyValue: 76,
                column: "CreatedTime",
                value: new DateTime(2024, 8, 22, 17, 29, 17, 389, DateTimeKind.Local).AddTicks(334));

            migrationBuilder.UpdateData(
                table: "Breeds",
                keyColumn: "Id",
                keyValue: 77,
                column: "CreatedTime",
                value: new DateTime(2024, 8, 22, 17, 29, 17, 389, DateTimeKind.Local).AddTicks(336));

            migrationBuilder.UpdateData(
                table: "Breeds",
                keyColumn: "Id",
                keyValue: 78,
                column: "CreatedTime",
                value: new DateTime(2024, 8, 22, 17, 29, 17, 389, DateTimeKind.Local).AddTicks(337));

            migrationBuilder.UpdateData(
                table: "Breeds",
                keyColumn: "Id",
                keyValue: 79,
                column: "CreatedTime",
                value: new DateTime(2024, 8, 22, 17, 29, 17, 389, DateTimeKind.Local).AddTicks(338));

            migrationBuilder.UpdateData(
                table: "Breeds",
                keyColumn: "Id",
                keyValue: 80,
                column: "CreatedTime",
                value: new DateTime(2024, 8, 22, 17, 29, 17, 389, DateTimeKind.Local).AddTicks(340));

            migrationBuilder.UpdateData(
                table: "Breeds",
                keyColumn: "Id",
                keyValue: 81,
                column: "CreatedTime",
                value: new DateTime(2024, 8, 22, 17, 29, 17, 389, DateTimeKind.Local).AddTicks(341));

            migrationBuilder.UpdateData(
                table: "Breeds",
                keyColumn: "Id",
                keyValue: 82,
                column: "CreatedTime",
                value: new DateTime(2024, 8, 22, 17, 29, 17, 389, DateTimeKind.Local).AddTicks(342));

            migrationBuilder.UpdateData(
                table: "Breeds",
                keyColumn: "Id",
                keyValue: 83,
                column: "CreatedTime",
                value: new DateTime(2024, 8, 22, 17, 29, 17, 389, DateTimeKind.Local).AddTicks(344));

            migrationBuilder.UpdateData(
                table: "Breeds",
                keyColumn: "Id",
                keyValue: 84,
                column: "CreatedTime",
                value: new DateTime(2024, 8, 22, 17, 29, 17, 389, DateTimeKind.Local).AddTicks(345));

            migrationBuilder.UpdateData(
                table: "Breeds",
                keyColumn: "Id",
                keyValue: 85,
                column: "CreatedTime",
                value: new DateTime(2024, 8, 22, 17, 29, 17, 389, DateTimeKind.Local).AddTicks(346));

            migrationBuilder.UpdateData(
                table: "Breeds",
                keyColumn: "Id",
                keyValue: 86,
                column: "CreatedTime",
                value: new DateTime(2024, 8, 22, 17, 29, 17, 389, DateTimeKind.Local).AddTicks(347));

            migrationBuilder.UpdateData(
                table: "Breeds",
                keyColumn: "Id",
                keyValue: 87,
                column: "CreatedTime",
                value: new DateTime(2024, 8, 22, 17, 29, 17, 389, DateTimeKind.Local).AddTicks(349));

            migrationBuilder.UpdateData(
                table: "Breeds",
                keyColumn: "Id",
                keyValue: 88,
                column: "CreatedTime",
                value: new DateTime(2024, 8, 22, 17, 29, 17, 389, DateTimeKind.Local).AddTicks(350));

            migrationBuilder.UpdateData(
                table: "Breeds",
                keyColumn: "Id",
                keyValue: 89,
                column: "CreatedTime",
                value: new DateTime(2024, 8, 22, 17, 29, 17, 389, DateTimeKind.Local).AddTicks(351));

            migrationBuilder.UpdateData(
                table: "Breeds",
                keyColumn: "Id",
                keyValue: 90,
                column: "CreatedTime",
                value: new DateTime(2024, 8, 22, 17, 29, 17, 389, DateTimeKind.Local).AddTicks(353));

            migrationBuilder.UpdateData(
                table: "Breeds",
                keyColumn: "Id",
                keyValue: 91,
                column: "CreatedTime",
                value: new DateTime(2024, 8, 22, 17, 29, 17, 389, DateTimeKind.Local).AddTicks(354));

            migrationBuilder.UpdateData(
                table: "Breeds",
                keyColumn: "Id",
                keyValue: 92,
                column: "CreatedTime",
                value: new DateTime(2024, 8, 22, 17, 29, 17, 389, DateTimeKind.Local).AddTicks(355));

            migrationBuilder.UpdateData(
                table: "Breeds",
                keyColumn: "Id",
                keyValue: 93,
                column: "CreatedTime",
                value: new DateTime(2024, 8, 22, 17, 29, 17, 389, DateTimeKind.Local).AddTicks(357));

            migrationBuilder.UpdateData(
                table: "Breeds",
                keyColumn: "Id",
                keyValue: 94,
                column: "CreatedTime",
                value: new DateTime(2024, 8, 22, 17, 29, 17, 389, DateTimeKind.Local).AddTicks(359));

            migrationBuilder.UpdateData(
                table: "Breeds",
                keyColumn: "Id",
                keyValue: 95,
                column: "CreatedTime",
                value: new DateTime(2024, 8, 22, 17, 29, 17, 389, DateTimeKind.Local).AddTicks(361));

            migrationBuilder.UpdateData(
                table: "Breeds",
                keyColumn: "Id",
                keyValue: 96,
                column: "CreatedTime",
                value: new DateTime(2024, 8, 22, 17, 29, 17, 389, DateTimeKind.Local).AddTicks(362));

            migrationBuilder.UpdateData(
                table: "Breeds",
                keyColumn: "Id",
                keyValue: 97,
                column: "CreatedTime",
                value: new DateTime(2024, 8, 22, 17, 29, 17, 389, DateTimeKind.Local).AddTicks(363));

            migrationBuilder.UpdateData(
                table: "Breeds",
                keyColumn: "Id",
                keyValue: 98,
                column: "CreatedTime",
                value: new DateTime(2024, 8, 22, 17, 29, 17, 389, DateTimeKind.Local).AddTicks(364));

            migrationBuilder.UpdateData(
                table: "Breeds",
                keyColumn: "Id",
                keyValue: 99,
                column: "CreatedTime",
                value: new DateTime(2024, 8, 22, 17, 29, 17, 389, DateTimeKind.Local).AddTicks(366));

            migrationBuilder.UpdateData(
                table: "Breeds",
                keyColumn: "Id",
                keyValue: 100,
                column: "CreatedTime",
                value: new DateTime(2024, 8, 22, 17, 29, 17, 389, DateTimeKind.Local).AddTicks(367));

            migrationBuilder.UpdateData(
                table: "Breeds",
                keyColumn: "Id",
                keyValue: 101,
                column: "CreatedTime",
                value: new DateTime(2024, 8, 22, 17, 29, 17, 389, DateTimeKind.Local).AddTicks(368));

            migrationBuilder.UpdateData(
                table: "Breeds",
                keyColumn: "Id",
                keyValue: 102,
                column: "CreatedTime",
                value: new DateTime(2024, 8, 22, 17, 29, 17, 389, DateTimeKind.Local).AddTicks(369));

            migrationBuilder.UpdateData(
                table: "Breeds",
                keyColumn: "Id",
                keyValue: 103,
                column: "CreatedTime",
                value: new DateTime(2024, 8, 22, 17, 29, 17, 389, DateTimeKind.Local).AddTicks(372));

            migrationBuilder.UpdateData(
                table: "Breeds",
                keyColumn: "Id",
                keyValue: 104,
                column: "CreatedTime",
                value: new DateTime(2024, 8, 22, 17, 29, 17, 389, DateTimeKind.Local).AddTicks(373));

            migrationBuilder.UpdateData(
                table: "Breeds",
                keyColumn: "Id",
                keyValue: 105,
                column: "CreatedTime",
                value: new DateTime(2024, 8, 22, 17, 29, 17, 389, DateTimeKind.Local).AddTicks(374));

            migrationBuilder.UpdateData(
                table: "Breeds",
                keyColumn: "Id",
                keyValue: 106,
                column: "CreatedTime",
                value: new DateTime(2024, 8, 22, 17, 29, 17, 389, DateTimeKind.Local).AddTicks(375));

            migrationBuilder.UpdateData(
                table: "Breeds",
                keyColumn: "Id",
                keyValue: 107,
                column: "CreatedTime",
                value: new DateTime(2024, 8, 22, 17, 29, 17, 389, DateTimeKind.Local).AddTicks(377));

            migrationBuilder.UpdateData(
                table: "Breeds",
                keyColumn: "Id",
                keyValue: 108,
                column: "CreatedTime",
                value: new DateTime(2024, 8, 22, 17, 29, 17, 389, DateTimeKind.Local).AddTicks(378));

            migrationBuilder.UpdateData(
                table: "Breeds",
                keyColumn: "Id",
                keyValue: 109,
                column: "CreatedTime",
                value: new DateTime(2024, 8, 22, 17, 29, 17, 389, DateTimeKind.Local).AddTicks(379));

            migrationBuilder.UpdateData(
                table: "Breeds",
                keyColumn: "Id",
                keyValue: 110,
                column: "CreatedTime",
                value: new DateTime(2024, 8, 22, 17, 29, 17, 389, DateTimeKind.Local).AddTicks(380));

            migrationBuilder.UpdateData(
                table: "Breeds",
                keyColumn: "Id",
                keyValue: 111,
                column: "CreatedTime",
                value: new DateTime(2024, 8, 22, 17, 29, 17, 389, DateTimeKind.Local).AddTicks(382));

            migrationBuilder.UpdateData(
                table: "Breeds",
                keyColumn: "Id",
                keyValue: 112,
                column: "CreatedTime",
                value: new DateTime(2024, 8, 22, 17, 29, 17, 389, DateTimeKind.Local).AddTicks(383));

            migrationBuilder.UpdateData(
                table: "Breeds",
                keyColumn: "Id",
                keyValue: 113,
                column: "CreatedTime",
                value: new DateTime(2024, 8, 22, 17, 29, 17, 389, DateTimeKind.Local).AddTicks(384));

            migrationBuilder.UpdateData(
                table: "Breeds",
                keyColumn: "Id",
                keyValue: 114,
                column: "CreatedTime",
                value: new DateTime(2024, 8, 22, 17, 29, 17, 389, DateTimeKind.Local).AddTicks(385));

            migrationBuilder.UpdateData(
                table: "Breeds",
                keyColumn: "Id",
                keyValue: 115,
                column: "CreatedTime",
                value: new DateTime(2024, 8, 22, 17, 29, 17, 389, DateTimeKind.Local).AddTicks(387));

            migrationBuilder.UpdateData(
                table: "Breeds",
                keyColumn: "Id",
                keyValue: 116,
                column: "CreatedTime",
                value: new DateTime(2024, 8, 22, 17, 29, 17, 389, DateTimeKind.Local).AddTicks(388));

            migrationBuilder.UpdateData(
                table: "Breeds",
                keyColumn: "Id",
                keyValue: 117,
                column: "CreatedTime",
                value: new DateTime(2024, 8, 22, 17, 29, 17, 389, DateTimeKind.Local).AddTicks(389));

            migrationBuilder.UpdateData(
                table: "Breeds",
                keyColumn: "Id",
                keyValue: 118,
                column: "CreatedTime",
                value: new DateTime(2024, 8, 22, 17, 29, 17, 389, DateTimeKind.Local).AddTicks(390));

            migrationBuilder.UpdateData(
                table: "Breeds",
                keyColumn: "Id",
                keyValue: 119,
                column: "CreatedTime",
                value: new DateTime(2024, 8, 22, 17, 29, 17, 389, DateTimeKind.Local).AddTicks(392));

            migrationBuilder.UpdateData(
                table: "Breeds",
                keyColumn: "Id",
                keyValue: 120,
                column: "CreatedTime",
                value: new DateTime(2024, 8, 22, 17, 29, 17, 389, DateTimeKind.Local).AddTicks(393));

            migrationBuilder.UpdateData(
                table: "Breeds",
                keyColumn: "Id",
                keyValue: 121,
                column: "CreatedTime",
                value: new DateTime(2024, 8, 22, 17, 29, 17, 389, DateTimeKind.Local).AddTicks(394));

            migrationBuilder.UpdateData(
                table: "Breeds",
                keyColumn: "Id",
                keyValue: 122,
                column: "CreatedTime",
                value: new DateTime(2024, 8, 22, 17, 29, 17, 389, DateTimeKind.Local).AddTicks(396));

            migrationBuilder.UpdateData(
                table: "Breeds",
                keyColumn: "Id",
                keyValue: 123,
                column: "CreatedTime",
                value: new DateTime(2024, 8, 22, 17, 29, 17, 389, DateTimeKind.Local).AddTicks(397));

            migrationBuilder.UpdateData(
                table: "Breeds",
                keyColumn: "Id",
                keyValue: 124,
                column: "CreatedTime",
                value: new DateTime(2024, 8, 22, 17, 29, 17, 389, DateTimeKind.Local).AddTicks(398));

            migrationBuilder.UpdateData(
                table: "Breeds",
                keyColumn: "Id",
                keyValue: 125,
                column: "CreatedTime",
                value: new DateTime(2024, 8, 22, 17, 29, 17, 389, DateTimeKind.Local).AddTicks(399));

            migrationBuilder.UpdateData(
                table: "Breeds",
                keyColumn: "Id",
                keyValue: 126,
                column: "CreatedTime",
                value: new DateTime(2024, 8, 22, 17, 29, 17, 389, DateTimeKind.Local).AddTicks(401));

            migrationBuilder.UpdateData(
                table: "Breeds",
                keyColumn: "Id",
                keyValue: 127,
                column: "CreatedTime",
                value: new DateTime(2024, 8, 22, 17, 29, 17, 389, DateTimeKind.Local).AddTicks(402));

            migrationBuilder.UpdateData(
                table: "Breeds",
                keyColumn: "Id",
                keyValue: 128,
                column: "CreatedTime",
                value: new DateTime(2024, 8, 22, 17, 29, 17, 389, DateTimeKind.Local).AddTicks(403));

            migrationBuilder.UpdateData(
                table: "Breeds",
                keyColumn: "Id",
                keyValue: 129,
                column: "CreatedTime",
                value: new DateTime(2024, 8, 22, 17, 29, 17, 389, DateTimeKind.Local).AddTicks(405));

            migrationBuilder.UpdateData(
                table: "Breeds",
                keyColumn: "Id",
                keyValue: 130,
                column: "CreatedTime",
                value: new DateTime(2024, 8, 22, 17, 29, 17, 389, DateTimeKind.Local).AddTicks(406));

            migrationBuilder.UpdateData(
                table: "Breeds",
                keyColumn: "Id",
                keyValue: 131,
                column: "CreatedTime",
                value: new DateTime(2024, 8, 22, 17, 29, 17, 389, DateTimeKind.Local).AddTicks(407));

            migrationBuilder.UpdateData(
                table: "Breeds",
                keyColumn: "Id",
                keyValue: 132,
                column: "CreatedTime",
                value: new DateTime(2024, 8, 22, 17, 29, 17, 389, DateTimeKind.Local).AddTicks(409));

            migrationBuilder.UpdateData(
                table: "Breeds",
                keyColumn: "Id",
                keyValue: 133,
                column: "CreatedTime",
                value: new DateTime(2024, 8, 22, 17, 29, 17, 389, DateTimeKind.Local).AddTicks(411));

            migrationBuilder.UpdateData(
                table: "Breeds",
                keyColumn: "Id",
                keyValue: 134,
                column: "CreatedTime",
                value: new DateTime(2024, 8, 22, 17, 29, 17, 389, DateTimeKind.Local).AddTicks(412));

            migrationBuilder.UpdateData(
                table: "Breeds",
                keyColumn: "Id",
                keyValue: 135,
                column: "CreatedTime",
                value: new DateTime(2024, 8, 22, 17, 29, 17, 389, DateTimeKind.Local).AddTicks(413));

            migrationBuilder.UpdateData(
                table: "Breeds",
                keyColumn: "Id",
                keyValue: 136,
                column: "CreatedTime",
                value: new DateTime(2024, 8, 22, 17, 29, 17, 389, DateTimeKind.Local).AddTicks(415));

            migrationBuilder.UpdateData(
                table: "Breeds",
                keyColumn: "Id",
                keyValue: 137,
                column: "CreatedTime",
                value: new DateTime(2024, 8, 22, 17, 29, 17, 389, DateTimeKind.Local).AddTicks(416));

            migrationBuilder.UpdateData(
                table: "Breeds",
                keyColumn: "Id",
                keyValue: 138,
                column: "CreatedTime",
                value: new DateTime(2024, 8, 22, 17, 29, 17, 389, DateTimeKind.Local).AddTicks(417));

            migrationBuilder.UpdateData(
                table: "Breeds",
                keyColumn: "Id",
                keyValue: 139,
                column: "CreatedTime",
                value: new DateTime(2024, 8, 22, 17, 29, 17, 389, DateTimeKind.Local).AddTicks(419));

            migrationBuilder.UpdateData(
                table: "Breeds",
                keyColumn: "Id",
                keyValue: 140,
                column: "CreatedTime",
                value: new DateTime(2024, 8, 22, 17, 29, 17, 389, DateTimeKind.Local).AddTicks(420));

            migrationBuilder.UpdateData(
                table: "Breeds",
                keyColumn: "Id",
                keyValue: 141,
                column: "CreatedTime",
                value: new DateTime(2024, 8, 22, 17, 29, 17, 389, DateTimeKind.Local).AddTicks(421));

            migrationBuilder.UpdateData(
                table: "Breeds",
                keyColumn: "Id",
                keyValue: 142,
                column: "CreatedTime",
                value: new DateTime(2024, 8, 22, 17, 29, 17, 389, DateTimeKind.Local).AddTicks(423));

            migrationBuilder.UpdateData(
                table: "Breeds",
                keyColumn: "Id",
                keyValue: 143,
                column: "CreatedTime",
                value: new DateTime(2024, 8, 22, 17, 29, 17, 389, DateTimeKind.Local).AddTicks(424));

            migrationBuilder.UpdateData(
                table: "Breeds",
                keyColumn: "Id",
                keyValue: 144,
                column: "CreatedTime",
                value: new DateTime(2024, 8, 22, 17, 29, 17, 389, DateTimeKind.Local).AddTicks(425));

            migrationBuilder.UpdateData(
                table: "Breeds",
                keyColumn: "Id",
                keyValue: 145,
                column: "CreatedTime",
                value: new DateTime(2024, 8, 22, 17, 29, 17, 389, DateTimeKind.Local).AddTicks(426));

            migrationBuilder.UpdateData(
                table: "Breeds",
                keyColumn: "Id",
                keyValue: 146,
                column: "CreatedTime",
                value: new DateTime(2024, 8, 22, 17, 29, 17, 389, DateTimeKind.Local).AddTicks(427));

            migrationBuilder.UpdateData(
                table: "Breeds",
                keyColumn: "Id",
                keyValue: 147,
                column: "CreatedTime",
                value: new DateTime(2024, 8, 22, 17, 29, 17, 389, DateTimeKind.Local).AddTicks(429));

            migrationBuilder.UpdateData(
                table: "Breeds",
                keyColumn: "Id",
                keyValue: 148,
                column: "CreatedTime",
                value: new DateTime(2024, 8, 22, 17, 29, 17, 389, DateTimeKind.Local).AddTicks(430));

            migrationBuilder.UpdateData(
                table: "Breeds",
                keyColumn: "Id",
                keyValue: 149,
                column: "CreatedTime",
                value: new DateTime(2024, 8, 22, 17, 29, 17, 389, DateTimeKind.Local).AddTicks(431));

            migrationBuilder.UpdateData(
                table: "Breeds",
                keyColumn: "Id",
                keyValue: 150,
                column: "CreatedTime",
                value: new DateTime(2024, 8, 22, 17, 29, 17, 389, DateTimeKind.Local).AddTicks(500));

            migrationBuilder.UpdateData(
                table: "Breeds",
                keyColumn: "Id",
                keyValue: 151,
                column: "CreatedTime",
                value: new DateTime(2024, 8, 22, 17, 29, 17, 389, DateTimeKind.Local).AddTicks(502));

            migrationBuilder.UpdateData(
                table: "Breeds",
                keyColumn: "Id",
                keyValue: 152,
                column: "CreatedTime",
                value: new DateTime(2024, 8, 22, 17, 29, 17, 389, DateTimeKind.Local).AddTicks(503));

            migrationBuilder.UpdateData(
                table: "Breeds",
                keyColumn: "Id",
                keyValue: 153,
                column: "CreatedTime",
                value: new DateTime(2024, 8, 22, 17, 29, 17, 389, DateTimeKind.Local).AddTicks(505));

            migrationBuilder.UpdateData(
                table: "Breeds",
                keyColumn: "Id",
                keyValue: 154,
                column: "CreatedTime",
                value: new DateTime(2024, 8, 22, 17, 29, 17, 389, DateTimeKind.Local).AddTicks(506));

            migrationBuilder.UpdateData(
                table: "Breeds",
                keyColumn: "Id",
                keyValue: 155,
                column: "CreatedTime",
                value: new DateTime(2024, 8, 22, 17, 29, 17, 389, DateTimeKind.Local).AddTicks(507));

            migrationBuilder.UpdateData(
                table: "Breeds",
                keyColumn: "Id",
                keyValue: 156,
                column: "CreatedTime",
                value: new DateTime(2024, 8, 22, 17, 29, 17, 389, DateTimeKind.Local).AddTicks(509));

            migrationBuilder.UpdateData(
                table: "Breeds",
                keyColumn: "Id",
                keyValue: 157,
                column: "CreatedTime",
                value: new DateTime(2024, 8, 22, 17, 29, 17, 389, DateTimeKind.Local).AddTicks(510));

            migrationBuilder.UpdateData(
                table: "Breeds",
                keyColumn: "Id",
                keyValue: 158,
                column: "CreatedTime",
                value: new DateTime(2024, 8, 22, 17, 29, 17, 389, DateTimeKind.Local).AddTicks(511));

            migrationBuilder.UpdateData(
                table: "Breeds",
                keyColumn: "Id",
                keyValue: 159,
                column: "CreatedTime",
                value: new DateTime(2024, 8, 22, 17, 29, 17, 389, DateTimeKind.Local).AddTicks(512));

            migrationBuilder.UpdateData(
                table: "Breeds",
                keyColumn: "Id",
                keyValue: 160,
                column: "CreatedTime",
                value: new DateTime(2024, 8, 22, 17, 29, 17, 389, DateTimeKind.Local).AddTicks(514));

            migrationBuilder.UpdateData(
                table: "PetTypes",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedTime",
                value: new DateTime(2024, 8, 22, 17, 29, 17, 388, DateTimeKind.Local).AddTicks(7542));

            migrationBuilder.UpdateData(
                table: "PetTypes",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreatedTime",
                value: new DateTime(2024, 8, 22, 17, 29, 17, 388, DateTimeKind.Local).AddTicks(7555));

            migrationBuilder.UpdateData(
                table: "PetTypes",
                keyColumn: "Id",
                keyValue: 3,
                column: "CreatedTime",
                value: new DateTime(2024, 8, 22, 17, 29, 17, 388, DateTimeKind.Local).AddTicks(7557));

            migrationBuilder.UpdateData(
                table: "PetTypes",
                keyColumn: "Id",
                keyValue: 4,
                column: "CreatedTime",
                value: new DateTime(2024, 8, 22, 17, 29, 17, 388, DateTimeKind.Local).AddTicks(7558));

            migrationBuilder.UpdateData(
                table: "PetTypes",
                keyColumn: "Id",
                keyValue: 5,
                column: "CreatedTime",
                value: new DateTime(2024, 8, 22, 17, 29, 17, 388, DateTimeKind.Local).AddTicks(7559));

            migrationBuilder.UpdateData(
                table: "PetTypes",
                keyColumn: "Id",
                keyValue: 6,
                column: "CreatedTime",
                value: new DateTime(2024, 8, 22, 17, 29, 17, 388, DateTimeKind.Local).AddTicks(7560));

            migrationBuilder.UpdateData(
                table: "PetTypes",
                keyColumn: "Id",
                keyValue: 7,
                column: "CreatedTime",
                value: new DateTime(2024, 8, 22, 17, 29, 17, 388, DateTimeKind.Local).AddTicks(7561));

            migrationBuilder.UpdateData(
                table: "PetTypes",
                keyColumn: "Id",
                keyValue: 8,
                column: "CreatedTime",
                value: new DateTime(2024, 8, 22, 17, 29, 17, 388, DateTimeKind.Local).AddTicks(7563));

            migrationBuilder.UpdateData(
                table: "Shelters",
                keyColumn: "Id",
                keyValue: 1021,
                columns: new[] { "CreatedTime", "LastUpdatedTime" },
                values: new object[] { new DateTime(2024, 8, 22, 13, 29, 17, 387, DateTimeKind.Utc).AddTicks(184), new DateTime(2024, 8, 22, 13, 29, 17, 387, DateTimeKind.Utc).AddTicks(185) });

            migrationBuilder.UpdateData(
                table: "Shelters",
                keyColumn: "Id",
                keyValue: 1022,
                columns: new[] { "CreatedTime", "LastUpdatedTime" },
                values: new object[] { new DateTime(2024, 8, 22, 13, 29, 17, 387, DateTimeKind.Utc).AddTicks(194), new DateTime(2024, 8, 22, 13, 29, 17, 387, DateTimeKind.Utc).AddTicks(195) });

            migrationBuilder.UpdateData(
                table: "Shelters",
                keyColumn: "Id",
                keyValue: 1023,
                columns: new[] { "CreatedTime", "LastUpdatedTime" },
                values: new object[] { new DateTime(2024, 8, 22, 13, 29, 17, 387, DateTimeKind.Utc).AddTicks(202), new DateTime(2024, 8, 22, 13, 29, 17, 387, DateTimeKind.Utc).AddTicks(202) });

            migrationBuilder.UpdateData(
                table: "Shelters",
                keyColumn: "Id",
                keyValue: 1024,
                columns: new[] { "CreatedTime", "LastUpdatedTime" },
                values: new object[] { new DateTime(2024, 8, 22, 13, 29, 17, 387, DateTimeKind.Utc).AddTicks(208), new DateTime(2024, 8, 22, 13, 29, 17, 387, DateTimeKind.Utc).AddTicks(208) });

            migrationBuilder.UpdateData(
                table: "Shelters",
                keyColumn: "Id",
                keyValue: 1025,
                columns: new[] { "CreatedTime", "LastUpdatedTime" },
                values: new object[] { new DateTime(2024, 8, 22, 13, 29, 17, 387, DateTimeKind.Utc).AddTicks(213), new DateTime(2024, 8, 22, 13, 29, 17, 387, DateTimeKind.Utc).AddTicks(213) });

            migrationBuilder.UpdateData(
                table: "Shelters",
                keyColumn: "Id",
                keyValue: 1026,
                columns: new[] { "CreatedTime", "LastUpdatedTime" },
                values: new object[] { new DateTime(2024, 8, 22, 13, 29, 17, 387, DateTimeKind.Utc).AddTicks(221), new DateTime(2024, 8, 22, 13, 29, 17, 387, DateTimeKind.Utc).AddTicks(221) });

            migrationBuilder.UpdateData(
                table: "Shelters",
                keyColumn: "Id",
                keyValue: 1027,
                columns: new[] { "CreatedTime", "LastUpdatedTime" },
                values: new object[] { new DateTime(2024, 8, 22, 13, 29, 17, 387, DateTimeKind.Utc).AddTicks(226), new DateTime(2024, 8, 22, 13, 29, 17, 387, DateTimeKind.Utc).AddTicks(227) });

            migrationBuilder.UpdateData(
                table: "Shelters",
                keyColumn: "Id",
                keyValue: 1028,
                columns: new[] { "CreatedTime", "LastUpdatedTime" },
                values: new object[] { new DateTime(2024, 8, 22, 13, 29, 17, 387, DateTimeKind.Utc).AddTicks(232), new DateTime(2024, 8, 22, 13, 29, 17, 387, DateTimeKind.Utc).AddTicks(232) });

            migrationBuilder.UpdateData(
                table: "Shelters",
                keyColumn: "Id",
                keyValue: 1029,
                columns: new[] { "CreatedTime", "LastUpdatedTime" },
                values: new object[] { new DateTime(2024, 8, 22, 13, 29, 17, 387, DateTimeKind.Utc).AddTicks(237), new DateTime(2024, 8, 22, 13, 29, 17, 387, DateTimeKind.Utc).AddTicks(237) });

            migrationBuilder.UpdateData(
                table: "Shelters",
                keyColumn: "Id",
                keyValue: 1030,
                columns: new[] { "CreatedTime", "LastUpdatedTime" },
                values: new object[] { new DateTime(2024, 8, 22, 13, 29, 17, 387, DateTimeKind.Utc).AddTicks(244), new DateTime(2024, 8, 22, 13, 29, 17, 387, DateTimeKind.Utc).AddTicks(244) });

            migrationBuilder.UpdateData(
                table: "Shelters",
                keyColumn: "Id",
                keyValue: 1031,
                columns: new[] { "CreatedTime", "LastUpdatedTime" },
                values: new object[] { new DateTime(2024, 8, 22, 13, 29, 17, 387, DateTimeKind.Utc).AddTicks(250), new DateTime(2024, 8, 22, 13, 29, 17, 387, DateTimeKind.Utc).AddTicks(250) });

            migrationBuilder.UpdateData(
                table: "Shelters",
                keyColumn: "Id",
                keyValue: 1032,
                columns: new[] { "CreatedTime", "LastUpdatedTime" },
                values: new object[] { new DateTime(2024, 8, 22, 13, 29, 17, 387, DateTimeKind.Utc).AddTicks(255), new DateTime(2024, 8, 22, 13, 29, 17, 387, DateTimeKind.Utc).AddTicks(256) });

            migrationBuilder.UpdateData(
                table: "Shelters",
                keyColumn: "Id",
                keyValue: 1033,
                columns: new[] { "CreatedTime", "LastUpdatedTime" },
                values: new object[] { new DateTime(2024, 8, 22, 13, 29, 17, 387, DateTimeKind.Utc).AddTicks(261), new DateTime(2024, 8, 22, 13, 29, 17, 387, DateTimeKind.Utc).AddTicks(261) });

            migrationBuilder.UpdateData(
                table: "Shelters",
                keyColumn: "Id",
                keyValue: 1034,
                columns: new[] { "CreatedTime", "LastUpdatedTime" },
                values: new object[] { new DateTime(2024, 8, 22, 13, 29, 17, 387, DateTimeKind.Utc).AddTicks(266), new DateTime(2024, 8, 22, 13, 29, 17, 387, DateTimeKind.Utc).AddTicks(266) });

            migrationBuilder.UpdateData(
                table: "Shelters",
                keyColumn: "Id",
                keyValue: 1035,
                columns: new[] { "CreatedTime", "LastUpdatedTime" },
                values: new object[] { new DateTime(2024, 8, 22, 13, 29, 17, 387, DateTimeKind.Utc).AddTicks(271), new DateTime(2024, 8, 22, 13, 29, 17, 387, DateTimeKind.Utc).AddTicks(272) });

            migrationBuilder.UpdateData(
                table: "Shelters",
                keyColumn: "Id",
                keyValue: 1036,
                columns: new[] { "CreatedTime", "LastUpdatedTime" },
                values: new object[] { new DateTime(2024, 8, 22, 13, 29, 17, 387, DateTimeKind.Utc).AddTicks(277), new DateTime(2024, 8, 22, 13, 29, 17, 387, DateTimeKind.Utc).AddTicks(278) });

            migrationBuilder.UpdateData(
                table: "Shelters",
                keyColumn: "Id",
                keyValue: 1037,
                columns: new[] { "CreatedTime", "LastUpdatedTime" },
                values: new object[] { new DateTime(2024, 8, 22, 13, 29, 17, 387, DateTimeKind.Utc).AddTicks(283), new DateTime(2024, 8, 22, 13, 29, 17, 387, DateTimeKind.Utc).AddTicks(283) });

            migrationBuilder.UpdateData(
                table: "Shelters",
                keyColumn: "Id",
                keyValue: 1038,
                columns: new[] { "CreatedTime", "LastUpdatedTime" },
                values: new object[] { new DateTime(2024, 8, 22, 13, 29, 17, 387, DateTimeKind.Utc).AddTicks(290), new DateTime(2024, 8, 22, 13, 29, 17, 387, DateTimeKind.Utc).AddTicks(290) });

            migrationBuilder.UpdateData(
                table: "Shelters",
                keyColumn: "Id",
                keyValue: 1039,
                columns: new[] { "CreatedTime", "LastUpdatedTime" },
                values: new object[] { new DateTime(2024, 8, 22, 13, 29, 17, 387, DateTimeKind.Utc).AddTicks(348), new DateTime(2024, 8, 22, 13, 29, 17, 387, DateTimeKind.Utc).AddTicks(348) });

            migrationBuilder.UpdateData(
                table: "Shelters",
                keyColumn: "Id",
                keyValue: 1040,
                columns: new[] { "CreatedTime", "LastUpdatedTime" },
                values: new object[] { new DateTime(2024, 8, 22, 13, 29, 17, 387, DateTimeKind.Utc).AddTicks(353), new DateTime(2024, 8, 22, 13, 29, 17, 387, DateTimeKind.Utc).AddTicks(354) });
        }
    }
}
