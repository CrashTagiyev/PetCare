using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace Persistance.Migrations
{
    /// <inheritdoc />
    public partial class mig997 : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.InsertData(
                table: "AspNetRoles",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[,]
                {
                    { 1, null, "User", "USER" },
                    { 2, null, "Vet", "VET" },
                    { 3, null, "Company", "COMPANY" },
                    { 4, null, "Admin", "Admin" }
                });

            migrationBuilder.InsertData(
                table: "AspNetUsers",
                columns: new[] { "Id", "About", "AccessFailedCount", "Address", "City", "ConcurrencyStamp", "CreatedTime", "DateOfBirth", "Dislikes", "Email", "EmailConfirmed", "Firstname", "IsDeleted", "LastUpdatedTime", "Lastname", "Likes", "LockoutEnabled", "LockoutEnd", "NormalizedEmail", "NormalizedUserName", "PasswordHash", "PhoneNumber", "PhoneNumberConfirmed", "ProfileImageUrl", "RefreshToken", "RefreshTokenCreateTime", "RefreshTokenExpireTime", "SecurityStamp", "TwoFactorEnabled", "UserName" },
                values: new object[,]
                {
                    { 2001, null, 0, "Address1", "City1", "f2c3a4ef-9e6b-4bed-b5c3-60adf74d7c18", new DateTime(2024, 8, 14, 18, 47, 27, 812, DateTimeKind.Utc).AddTicks(3362), new DateTime(2000, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 0, "user1@example.com", false, "FirstName1", false, new DateTime(2024, 8, 14, 18, 47, 27, 812, DateTimeKind.Utc).AddTicks(3363), "LastName1", 0, false, null, "USER1@EXAMPLE.COM", "USER1", null, null, false, "https://picsum.photos/seed/user1/200/300", null, new DateTime(2024, 8, 14, 22, 47, 27, 812, DateTimeKind.Local).AddTicks(3255), null, null, false, "user1" },
                    { 2002, null, 0, "Address2", "City2", "930df030-a53d-415e-9ada-c5aec6414642", new DateTime(2024, 8, 14, 18, 47, 27, 812, DateTimeKind.Utc).AddTicks(3414), new DateTime(2000, 1, 2, 0, 0, 0, 0, DateTimeKind.Unspecified), 0, "user2@example.com", false, "FirstName2", false, new DateTime(2024, 8, 14, 18, 47, 27, 812, DateTimeKind.Utc).AddTicks(3414), "LastName2", 0, false, null, "USER2@EXAMPLE.COM", "USER2", null, null, false, "https://picsum.photos/seed/user2/200/300", null, new DateTime(2024, 8, 14, 22, 47, 27, 812, DateTimeKind.Local).AddTicks(3392), null, null, false, "user2" },
                    { 2003, null, 0, "Address3", "City3", "2207d92a-afc8-427a-b0c8-b6be2831d8ef", new DateTime(2024, 8, 14, 18, 47, 27, 812, DateTimeKind.Utc).AddTicks(3529), new DateTime(2000, 1, 3, 0, 0, 0, 0, DateTimeKind.Unspecified), 0, "user3@example.com", false, "FirstName3", false, new DateTime(2024, 8, 14, 18, 47, 27, 812, DateTimeKind.Utc).AddTicks(3529), "LastName3", 0, false, null, "USER3@EXAMPLE.COM", "USER3", null, null, false, "https://picsum.photos/seed/user3/200/300", null, new DateTime(2024, 8, 14, 22, 47, 27, 812, DateTimeKind.Local).AddTicks(3521), null, null, false, "user3" },
                    { 2004, null, 0, "Address4", "City4", "34cce0e8-2505-4e98-bd98-463d657e723d", new DateTime(2024, 8, 14, 18, 47, 27, 812, DateTimeKind.Utc).AddTicks(3543), new DateTime(2000, 1, 4, 0, 0, 0, 0, DateTimeKind.Unspecified), 0, "user4@example.com", false, "FirstName4", false, new DateTime(2024, 8, 14, 18, 47, 27, 812, DateTimeKind.Utc).AddTicks(3543), "LastName4", 0, false, null, "USER4@EXAMPLE.COM", "USER4", null, null, false, "https://picsum.photos/seed/user4/200/300", null, new DateTime(2024, 8, 14, 22, 47, 27, 812, DateTimeKind.Local).AddTicks(3538), null, null, false, "user4" },
                    { 2005, null, 0, "Address5", "City5", "e25ca98e-f4fd-4cd5-923a-4173342bff24", new DateTime(2024, 8, 14, 18, 47, 27, 812, DateTimeKind.Utc).AddTicks(3555), new DateTime(2000, 1, 5, 0, 0, 0, 0, DateTimeKind.Unspecified), 0, "user5@example.com", false, "FirstName5", false, new DateTime(2024, 8, 14, 18, 47, 27, 812, DateTimeKind.Utc).AddTicks(3555), "LastName5", 0, false, null, "USER5@EXAMPLE.COM", "USER5", null, null, false, "https://picsum.photos/seed/user5/200/300", null, new DateTime(2024, 8, 14, 22, 47, 27, 812, DateTimeKind.Local).AddTicks(3550), null, null, false, "user5" },
                    { 2006, null, 0, "Address6", "City6", "0d152788-cc2c-49c3-9c42-8fb66be14326", new DateTime(2024, 8, 14, 18, 47, 27, 812, DateTimeKind.Utc).AddTicks(3574), new DateTime(2000, 1, 6, 0, 0, 0, 0, DateTimeKind.Unspecified), 0, "user6@example.com", false, "FirstName6", false, new DateTime(2024, 8, 14, 18, 47, 27, 812, DateTimeKind.Utc).AddTicks(3574), "LastName6", 0, false, null, "USER6@EXAMPLE.COM", "USER6", null, null, false, "https://picsum.photos/seed/user6/200/300", null, new DateTime(2024, 8, 14, 22, 47, 27, 812, DateTimeKind.Local).AddTicks(3568), null, null, false, "user6" },
                    { 2007, null, 0, "Address7", "City7", "c74bfb5b-03bd-4e27-aa90-ce94bcad6f6c", new DateTime(2024, 8, 14, 18, 47, 27, 812, DateTimeKind.Utc).AddTicks(3587), new DateTime(2000, 1, 7, 0, 0, 0, 0, DateTimeKind.Unspecified), 0, "user7@example.com", false, "FirstName7", false, new DateTime(2024, 8, 14, 18, 47, 27, 812, DateTimeKind.Utc).AddTicks(3587), "LastName7", 0, false, null, "USER7@EXAMPLE.COM", "USER7", null, null, false, "https://picsum.photos/seed/user7/200/300", null, new DateTime(2024, 8, 14, 22, 47, 27, 812, DateTimeKind.Local).AddTicks(3581), null, null, false, "user7" },
                    { 2008, null, 0, "Address8", "City8", "853cfc47-c8e8-487d-ac2b-e8ec178de0c9", new DateTime(2024, 8, 14, 18, 47, 27, 812, DateTimeKind.Utc).AddTicks(3599), new DateTime(2000, 1, 8, 0, 0, 0, 0, DateTimeKind.Unspecified), 0, "user8@example.com", false, "FirstName8", false, new DateTime(2024, 8, 14, 18, 47, 27, 812, DateTimeKind.Utc).AddTicks(3599), "LastName8", 0, false, null, "USER8@EXAMPLE.COM", "USER8", null, null, false, "https://picsum.photos/seed/user8/200/300", null, new DateTime(2024, 8, 14, 22, 47, 27, 812, DateTimeKind.Local).AddTicks(3594), null, null, false, "user8" },
                    { 2009, null, 0, "Address9", "City9", "cfdb5138-42ae-4252-9f8b-c1c40b1ee575", new DateTime(2024, 8, 14, 18, 47, 27, 812, DateTimeKind.Utc).AddTicks(3611), new DateTime(2000, 1, 9, 0, 0, 0, 0, DateTimeKind.Unspecified), 0, "user9@example.com", false, "FirstName9", false, new DateTime(2024, 8, 14, 18, 47, 27, 812, DateTimeKind.Utc).AddTicks(3611), "LastName9", 0, false, null, "USER9@EXAMPLE.COM", "USER9", null, null, false, "https://picsum.photos/seed/user9/200/300", null, new DateTime(2024, 8, 14, 22, 47, 27, 812, DateTimeKind.Local).AddTicks(3606), null, null, false, "user9" },
                    { 2010, null, 0, "Address10", "City10", "482a9d14-bf42-4874-9c30-a54e401f3fb6", new DateTime(2024, 8, 14, 18, 47, 27, 812, DateTimeKind.Utc).AddTicks(3631), new DateTime(2000, 1, 10, 0, 0, 0, 0, DateTimeKind.Unspecified), 0, "user10@example.com", false, "FirstName10", false, new DateTime(2024, 8, 14, 18, 47, 27, 812, DateTimeKind.Utc).AddTicks(3632), "LastName10", 0, false, null, "USER10@EXAMPLE.COM", "USER10", null, null, false, "https://picsum.photos/seed/user10/200/300", null, new DateTime(2024, 8, 14, 22, 47, 27, 812, DateTimeKind.Local).AddTicks(3620), null, null, false, "user10" },
                    { 2011, null, 0, "Address11", "City11", "038dd7c9-a709-4cd7-a80b-ec7cd1aa4d1e", new DateTime(2024, 8, 14, 18, 47, 27, 812, DateTimeKind.Utc).AddTicks(3645), new DateTime(2000, 1, 11, 0, 0, 0, 0, DateTimeKind.Unspecified), 0, "user11@example.com", false, "FirstName11", false, new DateTime(2024, 8, 14, 18, 47, 27, 812, DateTimeKind.Utc).AddTicks(3645), "LastName11", 0, false, null, "USER11@EXAMPLE.COM", "USER11", null, null, false, "https://picsum.photos/seed/user11/200/300", null, new DateTime(2024, 8, 14, 22, 47, 27, 812, DateTimeKind.Local).AddTicks(3640), null, null, false, "user11" },
                    { 2012, null, 0, "Address12", "City12", "7348915d-8ff6-4aed-8f34-b262a02c67ba", new DateTime(2024, 8, 14, 18, 47, 27, 812, DateTimeKind.Utc).AddTicks(3699), new DateTime(2000, 1, 12, 0, 0, 0, 0, DateTimeKind.Unspecified), 0, "user12@example.com", false, "FirstName12", false, new DateTime(2024, 8, 14, 18, 47, 27, 812, DateTimeKind.Utc).AddTicks(3699), "LastName12", 0, false, null, "USER12@EXAMPLE.COM", "USER12", null, null, false, "https://picsum.photos/seed/user12/200/300", null, new DateTime(2024, 8, 14, 22, 47, 27, 812, DateTimeKind.Local).AddTicks(3693), null, null, false, "user12" },
                    { 2013, null, 0, "Address13", "City13", "2984acdd-eafb-4eab-ba03-0a4f523fdc4f", new DateTime(2024, 8, 14, 18, 47, 27, 812, DateTimeKind.Utc).AddTicks(3711), new DateTime(2000, 1, 13, 0, 0, 0, 0, DateTimeKind.Unspecified), 0, "user13@example.com", false, "FirstName13", false, new DateTime(2024, 8, 14, 18, 47, 27, 812, DateTimeKind.Utc).AddTicks(3712), "LastName13", 0, false, null, "USER13@EXAMPLE.COM", "USER13", null, null, false, "https://picsum.photos/seed/user13/200/300", null, new DateTime(2024, 8, 14, 22, 47, 27, 812, DateTimeKind.Local).AddTicks(3707), null, null, false, "user13" },
                    { 2014, null, 0, "Address14", "City14", "f27cd168-5ff0-44fc-af04-4ec23c29ddfe", new DateTime(2024, 8, 14, 18, 47, 27, 812, DateTimeKind.Utc).AddTicks(3724), new DateTime(2000, 1, 14, 0, 0, 0, 0, DateTimeKind.Unspecified), 0, "user14@example.com", false, "FirstName14", false, new DateTime(2024, 8, 14, 18, 47, 27, 812, DateTimeKind.Utc).AddTicks(3724), "LastName14", 0, false, null, "USER14@EXAMPLE.COM", "USER14", null, null, false, "https://picsum.photos/seed/user14/200/300", null, new DateTime(2024, 8, 14, 22, 47, 27, 812, DateTimeKind.Local).AddTicks(3719), null, null, false, "user14" },
                    { 2015, null, 0, "Address15", "City15", "4699c959-bc8b-4d25-bdbe-eff1868ccb86", new DateTime(2024, 8, 14, 18, 47, 27, 812, DateTimeKind.Utc).AddTicks(3736), new DateTime(2000, 1, 15, 0, 0, 0, 0, DateTimeKind.Unspecified), 0, "user15@example.com", false, "FirstName15", false, new DateTime(2024, 8, 14, 18, 47, 27, 812, DateTimeKind.Utc).AddTicks(3737), "LastName15", 0, false, null, "USER15@EXAMPLE.COM", "USER15", null, null, false, "https://picsum.photos/seed/user15/200/300", null, new DateTime(2024, 8, 14, 22, 47, 27, 812, DateTimeKind.Local).AddTicks(3732), null, null, false, "user15" },
                    { 2016, null, 0, "Address16", "City16", "99a56221-35b5-4d9a-b0dc-e9607f101560", new DateTime(2024, 8, 14, 18, 47, 27, 812, DateTimeKind.Utc).AddTicks(3749), new DateTime(2000, 1, 16, 0, 0, 0, 0, DateTimeKind.Unspecified), 0, "user16@example.com", false, "FirstName16", false, new DateTime(2024, 8, 14, 18, 47, 27, 812, DateTimeKind.Utc).AddTicks(3750), "LastName16", 0, false, null, "USER16@EXAMPLE.COM", "USER16", null, null, false, "https://picsum.photos/seed/user16/200/300", null, new DateTime(2024, 8, 14, 22, 47, 27, 812, DateTimeKind.Local).AddTicks(3744), null, null, false, "user16" },
                    { 2017, null, 0, "Address17", "City17", "86be6abc-dbe7-41cc-8406-5e99ecbf6336", new DateTime(2024, 8, 14, 18, 47, 27, 812, DateTimeKind.Utc).AddTicks(3762), new DateTime(2000, 1, 17, 0, 0, 0, 0, DateTimeKind.Unspecified), 0, "user17@example.com", false, "FirstName17", false, new DateTime(2024, 8, 14, 18, 47, 27, 812, DateTimeKind.Utc).AddTicks(3763), "LastName17", 0, false, null, "USER17@EXAMPLE.COM", "USER17", null, null, false, "https://picsum.photos/seed/user17/200/300", null, new DateTime(2024, 8, 14, 22, 47, 27, 812, DateTimeKind.Local).AddTicks(3757), null, null, false, "user17" },
                    { 2018, null, 0, "Address18", "City18", "869132c2-3729-4e11-b0ad-e2e46700f60d", new DateTime(2024, 8, 14, 18, 47, 27, 812, DateTimeKind.Utc).AddTicks(3780), new DateTime(2000, 1, 18, 0, 0, 0, 0, DateTimeKind.Unspecified), 0, "user18@example.com", false, "FirstName18", false, new DateTime(2024, 8, 14, 18, 47, 27, 812, DateTimeKind.Utc).AddTicks(3780), "LastName18", 0, false, null, "USER18@EXAMPLE.COM", "USER18", null, null, false, "https://picsum.photos/seed/user18/200/300", null, new DateTime(2024, 8, 14, 22, 47, 27, 812, DateTimeKind.Local).AddTicks(3771), null, null, false, "user18" },
                    { 2019, null, 0, "Address19", "City19", "1c203c0a-d82e-4adf-abf6-30e8ab1d4cb2", new DateTime(2024, 8, 14, 18, 47, 27, 812, DateTimeKind.Utc).AddTicks(3794), new DateTime(2000, 1, 19, 0, 0, 0, 0, DateTimeKind.Unspecified), 0, "user19@example.com", false, "FirstName19", false, new DateTime(2024, 8, 14, 18, 47, 27, 812, DateTimeKind.Utc).AddTicks(3794), "LastName19", 0, false, null, "USER19@EXAMPLE.COM", "USER19", null, null, false, "https://picsum.photos/seed/user19/200/300", null, new DateTime(2024, 8, 14, 22, 47, 27, 812, DateTimeKind.Local).AddTicks(3788), null, null, false, "user19" },
                    { 2020, null, 0, "Address20", "City20", "1f5da236-c5e8-4474-b096-c77f8064589c", new DateTime(2024, 8, 14, 18, 47, 27, 812, DateTimeKind.Utc).AddTicks(3807), new DateTime(2000, 1, 20, 0, 0, 0, 0, DateTimeKind.Unspecified), 0, "user20@example.com", false, "FirstName20", false, new DateTime(2024, 8, 14, 18, 47, 27, 812, DateTimeKind.Utc).AddTicks(3807), "LastName20", 0, false, null, "USER20@EXAMPLE.COM", "USER20", null, null, false, "https://picsum.photos/seed/user20/200/300", null, new DateTime(2024, 8, 14, 22, 47, 27, 812, DateTimeKind.Local).AddTicks(3802), null, null, false, "user20" },
                    { 2021, null, 0, "Address21", "City21", "bcd19252-936a-440e-914a-54eef9f44d69", new DateTime(2024, 8, 14, 18, 47, 27, 812, DateTimeKind.Utc).AddTicks(3844), new DateTime(2000, 1, 21, 0, 0, 0, 0, DateTimeKind.Unspecified), 0, "Company21@example.com", false, "CompanyFirstName21", false, new DateTime(2024, 8, 14, 18, 47, 27, 812, DateTimeKind.Utc).AddTicks(3844), "CompanyLastName21", 0, false, null, "COMPANY21@EXAMPLE.COM", "COMPANY21", null, null, false, "https://picsum.photos/seed/user21/200/300", null, new DateTime(2024, 8, 14, 22, 47, 27, 812, DateTimeKind.Local).AddTicks(3838), null, null, false, "Company21" },
                    { 2022, null, 0, "Address22", "City22", "31a07b3b-a58c-462f-bb2b-6efb9120b4c4", new DateTime(2024, 8, 14, 18, 47, 27, 812, DateTimeKind.Utc).AddTicks(3861), new DateTime(2000, 1, 22, 0, 0, 0, 0, DateTimeKind.Unspecified), 0, "Company22@example.com", false, "CompanyFirstName22", false, new DateTime(2024, 8, 14, 18, 47, 27, 812, DateTimeKind.Utc).AddTicks(3862), "CompanyLastName22", 0, false, null, "COMPANY22@EXAMPLE.COM", "COMPANY22", null, null, false, "https://picsum.photos/seed/user22/200/300", null, new DateTime(2024, 8, 14, 22, 47, 27, 812, DateTimeKind.Local).AddTicks(3856), null, null, false, "Company22" },
                    { 2023, null, 0, "Address23", "City23", "bae91ee6-3ac0-4a3e-b414-aa8093ed48e9", new DateTime(2024, 8, 14, 18, 47, 27, 812, DateTimeKind.Utc).AddTicks(3876), new DateTime(2000, 1, 23, 0, 0, 0, 0, DateTimeKind.Unspecified), 0, "Company23@example.com", false, "CompanyFirstName23", false, new DateTime(2024, 8, 14, 18, 47, 27, 812, DateTimeKind.Utc).AddTicks(3877), "CompanyLastName23", 0, false, null, "COMPANY23@EXAMPLE.COM", "COMPANY23", null, null, false, "https://picsum.photos/seed/user23/200/300", null, new DateTime(2024, 8, 14, 22, 47, 27, 812, DateTimeKind.Local).AddTicks(3871), null, null, false, "Company23" },
                    { 2024, null, 0, "Address24", "City24", "8ae394c0-2a0c-4193-a2a6-b2550e608385", new DateTime(2024, 8, 14, 18, 47, 27, 812, DateTimeKind.Utc).AddTicks(3889), new DateTime(2000, 1, 24, 0, 0, 0, 0, DateTimeKind.Unspecified), 0, "Company24@example.com", false, "CompanyFirstName24", false, new DateTime(2024, 8, 14, 18, 47, 27, 812, DateTimeKind.Utc).AddTicks(3890), "CompanyLastName24", 0, false, null, "COMPANY24@EXAMPLE.COM", "COMPANY24", null, null, false, "https://picsum.photos/seed/user24/200/300", null, new DateTime(2024, 8, 14, 22, 47, 27, 812, DateTimeKind.Local).AddTicks(3884), null, null, false, "Company24" },
                    { 2025, null, 0, "Address25", "City25", "2baf22c7-7682-4923-929b-6b2885ee2258", new DateTime(2024, 8, 14, 18, 47, 27, 812, DateTimeKind.Utc).AddTicks(3902), new DateTime(2000, 1, 25, 0, 0, 0, 0, DateTimeKind.Unspecified), 0, "Company25@example.com", false, "CompanyFirstName25", false, new DateTime(2024, 8, 14, 18, 47, 27, 812, DateTimeKind.Utc).AddTicks(3902), "CompanyLastName25", 0, false, null, "COMPANY25@EXAMPLE.COM", "COMPANY25", null, null, false, "https://picsum.photos/seed/user25/200/300", null, new DateTime(2024, 8, 14, 22, 47, 27, 812, DateTimeKind.Local).AddTicks(3897), null, null, false, "Company25" },
                    { 2026, null, 0, "Address26", "City26", "e1300148-231a-44e4-a927-88a31ffc4915", new DateTime(2024, 8, 14, 18, 47, 27, 812, DateTimeKind.Utc).AddTicks(3918), new DateTime(2000, 1, 26, 0, 0, 0, 0, DateTimeKind.Unspecified), 0, "Company26@example.com", false, "CompanyFirstName26", false, new DateTime(2024, 8, 14, 18, 47, 27, 812, DateTimeKind.Utc).AddTicks(3918), "CompanyLastName26", 0, false, null, "COMPANY26@EXAMPLE.COM", "COMPANY26", null, null, false, "https://picsum.photos/seed/user26/200/300", null, new DateTime(2024, 8, 14, 22, 47, 27, 812, DateTimeKind.Local).AddTicks(3909), null, null, false, "Company26" },
                    { 2027, null, 0, "Address27", "City27", "bbbba7c2-866d-4db1-a5ea-772982b149f4", new DateTime(2024, 8, 14, 18, 47, 27, 812, DateTimeKind.Utc).AddTicks(3930), new DateTime(2000, 1, 27, 0, 0, 0, 0, DateTimeKind.Unspecified), 0, "Company27@example.com", false, "CompanyFirstName27", false, new DateTime(2024, 8, 14, 18, 47, 27, 812, DateTimeKind.Utc).AddTicks(3930), "CompanyLastName27", 0, false, null, "COMPANY27@EXAMPLE.COM", "COMPANY27", null, null, false, "https://picsum.photos/seed/user27/200/300", null, new DateTime(2024, 8, 14, 22, 47, 27, 812, DateTimeKind.Local).AddTicks(3925), null, null, false, "Company27" },
                    { 2028, null, 0, "Address28", "City28", "fdc9b6ce-dce8-4ed0-bb6f-80c6647e8e67", new DateTime(2024, 8, 14, 18, 47, 27, 812, DateTimeKind.Utc).AddTicks(3943), new DateTime(2000, 1, 28, 0, 0, 0, 0, DateTimeKind.Unspecified), 0, "Company28@example.com", false, "CompanyFirstName28", false, new DateTime(2024, 8, 14, 18, 47, 27, 812, DateTimeKind.Utc).AddTicks(3944), "CompanyLastName28", 0, false, null, "COMPANY28@EXAMPLE.COM", "COMPANY28", null, null, false, "https://picsum.photos/seed/user28/200/300", null, new DateTime(2024, 8, 14, 22, 47, 27, 812, DateTimeKind.Local).AddTicks(3938), null, null, false, "Company28" },
                    { 2029, null, 0, "Address29", "City29", "eb29e831-9166-4823-bdce-ebd72bda2d7c", new DateTime(2024, 8, 14, 18, 47, 27, 812, DateTimeKind.Utc).AddTicks(3955), new DateTime(2000, 1, 29, 0, 0, 0, 0, DateTimeKind.Unspecified), 0, "Company29@example.com", false, "CompanyFirstName29", false, new DateTime(2024, 8, 14, 18, 47, 27, 812, DateTimeKind.Utc).AddTicks(3956), "CompanyLastName29", 0, false, null, "COMPANY29@EXAMPLE.COM", "COMPANY29", null, null, false, "https://picsum.photos/seed/user29/200/300", null, new DateTime(2024, 8, 14, 22, 47, 27, 812, DateTimeKind.Local).AddTicks(3951), null, null, false, "Company29" },
                    { 2030, null, 0, "Address30", "City30", "54844170-840f-462c-a196-2b5dc4af5e71", new DateTime(2024, 8, 14, 18, 47, 27, 812, DateTimeKind.Utc).AddTicks(4063), new DateTime(2000, 1, 30, 0, 0, 0, 0, DateTimeKind.Unspecified), 0, "Company30@example.com", false, "CompanyFirstName30", false, new DateTime(2024, 8, 14, 18, 47, 27, 812, DateTimeKind.Utc).AddTicks(4063), "CompanyLastName30", 0, false, null, "COMPANY30@EXAMPLE.COM", "COMPANY30", null, null, false, "https://picsum.photos/seed/user30/200/300", null, new DateTime(2024, 8, 14, 22, 47, 27, 812, DateTimeKind.Local).AddTicks(4057), null, null, false, "Company30" },
                    { 2031, null, 0, "Address31", "City31", "81c3b78b-7f77-4c3e-b48a-95f5de26d55d", new DateTime(2024, 8, 14, 18, 47, 27, 812, DateTimeKind.Utc).AddTicks(4075), new DateTime(2000, 1, 31, 0, 0, 0, 0, DateTimeKind.Unspecified), 0, "Company31@example.com", false, "CompanyFirstName31", false, new DateTime(2024, 8, 14, 18, 47, 27, 812, DateTimeKind.Utc).AddTicks(4076), "CompanyLastName31", 0, false, null, "COMPANY31@EXAMPLE.COM", "COMPANY31", null, null, false, "https://picsum.photos/seed/user31/200/300", null, new DateTime(2024, 8, 14, 22, 47, 27, 812, DateTimeKind.Local).AddTicks(4070), null, null, false, "Company31" },
                    { 2032, null, 0, "Address32", "City32", "256217a1-d1ed-488f-8f25-6dac2f729175", new DateTime(2024, 8, 14, 18, 47, 27, 812, DateTimeKind.Utc).AddTicks(4088), new DateTime(2000, 2, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 0, "Company32@example.com", false, "CompanyFirstName32", false, new DateTime(2024, 8, 14, 18, 47, 27, 812, DateTimeKind.Utc).AddTicks(4088), "CompanyLastName32", 0, false, null, "COMPANY32@EXAMPLE.COM", "COMPANY32", null, null, false, "https://picsum.photos/seed/user32/200/300", null, new DateTime(2024, 8, 14, 22, 47, 27, 812, DateTimeKind.Local).AddTicks(4083), null, null, false, "Company32" },
                    { 2033, null, 0, "Address33", "City33", "da8832db-44ff-4c2d-a5a4-6ac2fc1c3bd9", new DateTime(2024, 8, 14, 18, 47, 27, 812, DateTimeKind.Utc).AddTicks(4101), new DateTime(2000, 2, 2, 0, 0, 0, 0, DateTimeKind.Unspecified), 0, "Company33@example.com", false, "CompanyFirstName33", false, new DateTime(2024, 8, 14, 18, 47, 27, 812, DateTimeKind.Utc).AddTicks(4101), "CompanyLastName33", 0, false, null, "COMPANY33@EXAMPLE.COM", "COMPANY33", null, null, false, "https://picsum.photos/seed/user33/200/300", null, new DateTime(2024, 8, 14, 22, 47, 27, 812, DateTimeKind.Local).AddTicks(4096), null, null, false, "Company33" },
                    { 2034, null, 0, "Address34", "City34", "6dcd36dd-f93a-4f7c-90ad-7521c5428fa6", new DateTime(2024, 8, 14, 18, 47, 27, 812, DateTimeKind.Utc).AddTicks(4119), new DateTime(2000, 2, 3, 0, 0, 0, 0, DateTimeKind.Unspecified), 0, "Company34@example.com", false, "CompanyFirstName34", false, new DateTime(2024, 8, 14, 18, 47, 27, 812, DateTimeKind.Utc).AddTicks(4120), "CompanyLastName34", 0, false, null, "COMPANY34@EXAMPLE.COM", "COMPANY34", null, null, false, "https://picsum.photos/seed/user34/200/300", null, new DateTime(2024, 8, 14, 22, 47, 27, 812, DateTimeKind.Local).AddTicks(4111), null, null, false, "Company34" },
                    { 2035, null, 0, "Address35", "City35", "097afa24-e2d3-4f6e-8870-2c3a4e389e7c", new DateTime(2024, 8, 14, 18, 47, 27, 812, DateTimeKind.Utc).AddTicks(4132), new DateTime(2000, 2, 4, 0, 0, 0, 0, DateTimeKind.Unspecified), 0, "Company35@example.com", false, "CompanyFirstName35", false, new DateTime(2024, 8, 14, 18, 47, 27, 812, DateTimeKind.Utc).AddTicks(4133), "CompanyLastName35", 0, false, null, "COMPANY35@EXAMPLE.COM", "COMPANY35", null, null, false, "https://picsum.photos/seed/user35/200/300", null, new DateTime(2024, 8, 14, 22, 47, 27, 812, DateTimeKind.Local).AddTicks(4127), null, null, false, "Company35" },
                    { 2036, null, 0, "Address36", "City36", "f8abc663-2dd6-4f95-902c-4c49210614f7", new DateTime(2024, 8, 14, 18, 47, 27, 812, DateTimeKind.Utc).AddTicks(4145), new DateTime(2000, 2, 5, 0, 0, 0, 0, DateTimeKind.Unspecified), 0, "Company36@example.com", false, "CompanyFirstName36", false, new DateTime(2024, 8, 14, 18, 47, 27, 812, DateTimeKind.Utc).AddTicks(4145), "CompanyLastName36", 0, false, null, "COMPANY36@EXAMPLE.COM", "COMPANY36", null, null, false, "https://picsum.photos/seed/user36/200/300", null, new DateTime(2024, 8, 14, 22, 47, 27, 812, DateTimeKind.Local).AddTicks(4140), null, null, false, "Company36" },
                    { 2037, null, 0, "Address37", "City37", "482e32f4-685c-4fa0-885e-8b1c124a9538", new DateTime(2024, 8, 14, 18, 47, 27, 812, DateTimeKind.Utc).AddTicks(4157), new DateTime(2000, 2, 6, 0, 0, 0, 0, DateTimeKind.Unspecified), 0, "Company37@example.com", false, "CompanyFirstName37", false, new DateTime(2024, 8, 14, 18, 47, 27, 812, DateTimeKind.Utc).AddTicks(4157), "CompanyLastName37", 0, false, null, "COMPANY37@EXAMPLE.COM", "COMPANY37", null, null, false, "https://picsum.photos/seed/user37/200/300", null, new DateTime(2024, 8, 14, 22, 47, 27, 812, DateTimeKind.Local).AddTicks(4152), null, null, false, "Company37" },
                    { 2038, null, 0, "Address38", "City38", "be6df1d4-8085-4034-8eef-e5c01f782f83", new DateTime(2024, 8, 14, 18, 47, 27, 812, DateTimeKind.Utc).AddTicks(4843), new DateTime(2000, 2, 7, 0, 0, 0, 0, DateTimeKind.Unspecified), 0, "Company38@example.com", false, "CompanyFirstName38", false, new DateTime(2024, 8, 14, 18, 47, 27, 812, DateTimeKind.Utc).AddTicks(4843), "CompanyLastName38", 0, false, null, "COMPANY38@EXAMPLE.COM", "COMPANY38", null, null, false, "https://picsum.photos/seed/user38/200/300", null, new DateTime(2024, 8, 14, 22, 47, 27, 812, DateTimeKind.Local).AddTicks(4804), null, null, false, "Company38" },
                    { 2039, null, 0, "Address39", "City39", "d692dabe-93a3-44a6-b22c-9708fc2503b6", new DateTime(2024, 8, 14, 18, 47, 27, 812, DateTimeKind.Utc).AddTicks(4861), new DateTime(2000, 2, 8, 0, 0, 0, 0, DateTimeKind.Unspecified), 0, "Company39@example.com", false, "CompanyFirstName39", false, new DateTime(2024, 8, 14, 18, 47, 27, 812, DateTimeKind.Utc).AddTicks(4862), "CompanyLastName39", 0, false, null, "COMPANY39@EXAMPLE.COM", "COMPANY39", null, null, false, "https://picsum.photos/seed/user39/200/300", null, new DateTime(2024, 8, 14, 22, 47, 27, 812, DateTimeKind.Local).AddTicks(4855), null, null, false, "Company39" },
                    { 2040, null, 0, "Address40", "City40", "f8d5212f-586b-46af-8c1f-9b7139f0f92a", new DateTime(2024, 8, 14, 18, 47, 27, 812, DateTimeKind.Utc).AddTicks(4875), new DateTime(2000, 2, 9, 0, 0, 0, 0, DateTimeKind.Unspecified), 0, "Company40@example.com", false, "CompanyFirstName40", false, new DateTime(2024, 8, 14, 18, 47, 27, 812, DateTimeKind.Utc).AddTicks(4875), "CompanyLastName40", 0, false, null, "COMPANY40@EXAMPLE.COM", "COMPANY40", null, null, false, "https://picsum.photos/seed/user40/200/300", null, new DateTime(2024, 8, 14, 22, 47, 27, 812, DateTimeKind.Local).AddTicks(4870), null, null, false, "Company40" },
                    { 2041, null, 0, "Address41", "City41", "4f640f81-ba19-43ac-b5ae-0d5ba818b483", new DateTime(2024, 8, 14, 18, 47, 27, 812, DateTimeKind.Utc).AddTicks(4887), new DateTime(2000, 2, 10, 0, 0, 0, 0, DateTimeKind.Unspecified), 0, "Vet41@example.com", false, "VetFirstName41", false, new DateTime(2024, 8, 14, 18, 47, 27, 812, DateTimeKind.Utc).AddTicks(4888), "VetLastName41", 0, false, null, "VET41@EXAMPLE.COM", "VET41", null, null, false, "https://picsum.photos/seed/user41/200/300", null, new DateTime(2024, 8, 14, 22, 47, 27, 812, DateTimeKind.Local).AddTicks(4883), null, null, false, "Vet41" },
                    { 2042, null, 0, "Address42", "City42", "e0ffa5e6-9915-4d05-ba78-501bbdb1696c", new DateTime(2024, 8, 14, 18, 47, 27, 812, DateTimeKind.Utc).AddTicks(4909), new DateTime(2000, 2, 11, 0, 0, 0, 0, DateTimeKind.Unspecified), 0, "Vet42@example.com", false, "VetFirstName42", false, new DateTime(2024, 8, 14, 18, 47, 27, 812, DateTimeKind.Utc).AddTicks(4910), "VetLastName42", 0, false, null, "VET42@EXAMPLE.COM", "VET42", null, null, false, "https://picsum.photos/seed/user42/200/300", null, new DateTime(2024, 8, 14, 22, 47, 27, 812, DateTimeKind.Local).AddTicks(4901), null, null, false, "Vet42" },
                    { 2043, null, 0, "Address43", "City43", "d94badf1-1b84-4223-a98b-4e5b8466a9a6", new DateTime(2024, 8, 14, 18, 47, 27, 812, DateTimeKind.Utc).AddTicks(4923), new DateTime(2000, 2, 12, 0, 0, 0, 0, DateTimeKind.Unspecified), 0, "Vet43@example.com", false, "VetFirstName43", false, new DateTime(2024, 8, 14, 18, 47, 27, 812, DateTimeKind.Utc).AddTicks(4923), "VetLastName43", 0, false, null, "VET43@EXAMPLE.COM", "VET43", null, null, false, "https://picsum.photos/seed/user43/200/300", null, new DateTime(2024, 8, 14, 22, 47, 27, 812, DateTimeKind.Local).AddTicks(4918), null, null, false, "Vet43" },
                    { 2044, null, 0, "Address44", "City44", "b97dce33-94a4-459d-bf17-ecfcf45107fe", new DateTime(2024, 8, 14, 18, 47, 27, 812, DateTimeKind.Utc).AddTicks(4935), new DateTime(2000, 2, 13, 0, 0, 0, 0, DateTimeKind.Unspecified), 0, "Vet44@example.com", false, "VetFirstName44", false, new DateTime(2024, 8, 14, 18, 47, 27, 812, DateTimeKind.Utc).AddTicks(4936), "VetLastName44", 0, false, null, "VET44@EXAMPLE.COM", "VET44", null, null, false, "https://picsum.photos/seed/user44/200/300", null, new DateTime(2024, 8, 14, 22, 47, 27, 812, DateTimeKind.Local).AddTicks(4931), null, null, false, "Vet44" },
                    { 2045, null, 0, "Address45", "City45", "9a428cab-7b07-4615-b837-512a65411c0d", new DateTime(2024, 8, 14, 18, 47, 27, 812, DateTimeKind.Utc).AddTicks(4949), new DateTime(2000, 2, 14, 0, 0, 0, 0, DateTimeKind.Unspecified), 0, "Vet45@example.com", false, "VetFirstName45", false, new DateTime(2024, 8, 14, 18, 47, 27, 812, DateTimeKind.Utc).AddTicks(4949), "VetLastName45", 0, false, null, "VET45@EXAMPLE.COM", "VET45", null, null, false, "https://picsum.photos/seed/user45/200/300", null, new DateTime(2024, 8, 14, 22, 47, 27, 812, DateTimeKind.Local).AddTicks(4944), null, null, false, "Vet45" },
                    { 2046, null, 0, "Address46", "City46", "e361df6d-9a2d-4da5-aef3-b20b3663c0fa", new DateTime(2024, 8, 14, 18, 47, 27, 812, DateTimeKind.Utc).AddTicks(4961), new DateTime(2000, 2, 15, 0, 0, 0, 0, DateTimeKind.Unspecified), 0, "Vet46@example.com", false, "VetFirstName46", false, new DateTime(2024, 8, 14, 18, 47, 27, 812, DateTimeKind.Utc).AddTicks(4962), "VetLastName46", 0, false, null, "VET46@EXAMPLE.COM", "VET46", null, null, false, "https://picsum.photos/seed/user46/200/300", null, new DateTime(2024, 8, 14, 22, 47, 27, 812, DateTimeKind.Local).AddTicks(4957), null, null, false, "Vet46" },
                    { 2047, null, 0, "Address47", "City47", "50d5fd5f-c0f0-45ee-9841-66b9279a0858", new DateTime(2024, 8, 14, 18, 47, 27, 812, DateTimeKind.Utc).AddTicks(5015), new DateTime(2000, 2, 16, 0, 0, 0, 0, DateTimeKind.Unspecified), 0, "Vet47@example.com", false, "VetFirstName47", false, new DateTime(2024, 8, 14, 18, 47, 27, 812, DateTimeKind.Utc).AddTicks(5016), "VetLastName47", 0, false, null, "VET47@EXAMPLE.COM", "VET47", null, null, false, "https://picsum.photos/seed/user47/200/300", null, new DateTime(2024, 8, 14, 22, 47, 27, 812, DateTimeKind.Local).AddTicks(5009), null, null, false, "Vet47" },
                    { 2048, null, 0, "Address48", "City48", "4a3b150f-a171-4374-9fad-52d99e04bacf", new DateTime(2024, 8, 14, 18, 47, 27, 812, DateTimeKind.Utc).AddTicks(5029), new DateTime(2000, 2, 17, 0, 0, 0, 0, DateTimeKind.Unspecified), 0, "Vet48@example.com", false, "VetFirstName48", false, new DateTime(2024, 8, 14, 18, 47, 27, 812, DateTimeKind.Utc).AddTicks(5029), "VetLastName48", 0, false, null, "VET48@EXAMPLE.COM", "VET48", null, null, false, "https://picsum.photos/seed/user48/200/300", null, new DateTime(2024, 8, 14, 22, 47, 27, 812, DateTimeKind.Local).AddTicks(5023), null, null, false, "Vet48" },
                    { 2049, null, 0, "Address49", "City49", "b7ba4f54-7ef6-4d5c-ad1d-e4a1650d235d", new DateTime(2024, 8, 14, 18, 47, 27, 812, DateTimeKind.Utc).AddTicks(5043), new DateTime(2000, 2, 18, 0, 0, 0, 0, DateTimeKind.Unspecified), 0, "Vet49@example.com", false, "VetFirstName49", false, new DateTime(2024, 8, 14, 18, 47, 27, 812, DateTimeKind.Utc).AddTicks(5043), "VetLastName49", 0, false, null, "VET49@EXAMPLE.COM", "VET49", null, null, false, "https://picsum.photos/seed/user49/200/300", null, new DateTime(2024, 8, 14, 22, 47, 27, 812, DateTimeKind.Local).AddTicks(5037), null, null, false, "Vet49" },
                    { 2050, null, 0, "Address50", "City50", "9272af22-c9aa-4215-beb5-6c945444282b", new DateTime(2024, 8, 14, 18, 47, 27, 812, DateTimeKind.Utc).AddTicks(5059), new DateTime(2000, 2, 19, 0, 0, 0, 0, DateTimeKind.Unspecified), 0, "Vet50@example.com", false, "VetFirstName50", false, new DateTime(2024, 8, 14, 18, 47, 27, 812, DateTimeKind.Utc).AddTicks(5059), "VetLastName50", 0, false, null, "VET50@EXAMPLE.COM", "VET50", null, null, false, "https://picsum.photos/seed/user50/200/300", null, new DateTime(2024, 8, 14, 22, 47, 27, 812, DateTimeKind.Local).AddTicks(5051), null, null, false, "Vet50" },
                    { 2051, null, 0, "Address51", "City51", "b0e5171d-ed0c-4094-90bd-49c4ee09fef9", new DateTime(2024, 8, 14, 18, 47, 27, 812, DateTimeKind.Utc).AddTicks(5071), new DateTime(2000, 2, 20, 0, 0, 0, 0, DateTimeKind.Unspecified), 0, "Vet51@example.com", false, "VetFirstName51", false, new DateTime(2024, 8, 14, 18, 47, 27, 812, DateTimeKind.Utc).AddTicks(5072), "VetLastName51", 0, false, null, "VET51@EXAMPLE.COM", "VET51", null, null, false, "https://picsum.photos/seed/user51/200/300", null, new DateTime(2024, 8, 14, 22, 47, 27, 812, DateTimeKind.Local).AddTicks(5067), null, null, false, "Vet51" },
                    { 2052, null, 0, "Address52", "City52", "60be114c-6482-4097-a87f-46073339bb92", new DateTime(2024, 8, 14, 18, 47, 27, 812, DateTimeKind.Utc).AddTicks(5084), new DateTime(2000, 2, 21, 0, 0, 0, 0, DateTimeKind.Unspecified), 0, "Vet52@example.com", false, "VetFirstName52", false, new DateTime(2024, 8, 14, 18, 47, 27, 812, DateTimeKind.Utc).AddTicks(5085), "VetLastName52", 0, false, null, "VET52@EXAMPLE.COM", "VET52", null, null, false, "https://picsum.photos/seed/user52/200/300", null, new DateTime(2024, 8, 14, 22, 47, 27, 812, DateTimeKind.Local).AddTicks(5079), null, null, false, "Vet52" },
                    { 2053, null, 0, "Address53", "City53", "c4c0dcfc-a3f3-4afc-9ad0-9704974ac376", new DateTime(2024, 8, 14, 18, 47, 27, 812, DateTimeKind.Utc).AddTicks(5096), new DateTime(2000, 2, 22, 0, 0, 0, 0, DateTimeKind.Unspecified), 0, "Vet53@example.com", false, "VetFirstName53", false, new DateTime(2024, 8, 14, 18, 47, 27, 812, DateTimeKind.Utc).AddTicks(5097), "VetLastName53", 0, false, null, "VET53@EXAMPLE.COM", "VET53", null, null, false, "https://picsum.photos/seed/user53/200/300", null, new DateTime(2024, 8, 14, 22, 47, 27, 812, DateTimeKind.Local).AddTicks(5092), null, null, false, "Vet53" },
                    { 2054, null, 0, "Address54", "City54", "35f6910c-48f3-4665-bf04-80224f851c94", new DateTime(2024, 8, 14, 18, 47, 27, 812, DateTimeKind.Utc).AddTicks(5109), new DateTime(2000, 2, 23, 0, 0, 0, 0, DateTimeKind.Unspecified), 0, "Vet54@example.com", false, "VetFirstName54", false, new DateTime(2024, 8, 14, 18, 47, 27, 812, DateTimeKind.Utc).AddTicks(5110), "VetLastName54", 0, false, null, "VET54@EXAMPLE.COM", "VET54", null, null, false, "https://picsum.photos/seed/user54/200/300", null, new DateTime(2024, 8, 14, 22, 47, 27, 812, DateTimeKind.Local).AddTicks(5104), null, null, false, "Vet54" },
                    { 2055, null, 0, "Address55", "City55", "549ee3fe-6b8c-4407-918b-f371016fde2a", new DateTime(2024, 8, 14, 18, 47, 27, 812, DateTimeKind.Utc).AddTicks(5122), new DateTime(2000, 2, 24, 0, 0, 0, 0, DateTimeKind.Unspecified), 0, "Vet55@example.com", false, "VetFirstName55", false, new DateTime(2024, 8, 14, 18, 47, 27, 812, DateTimeKind.Utc).AddTicks(5122), "VetLastName55", 0, false, null, "VET55@EXAMPLE.COM", "VET55", null, null, false, "https://picsum.photos/seed/user55/200/300", null, new DateTime(2024, 8, 14, 22, 47, 27, 812, DateTimeKind.Local).AddTicks(5117), null, null, false, "Vet55" },
                    { 2056, null, 0, "Address56", "City56", "b6dd5747-4700-4ff2-bafb-f2792ef0f831", new DateTime(2024, 8, 14, 18, 47, 27, 812, DateTimeKind.Utc).AddTicks(5135), new DateTime(2000, 2, 25, 0, 0, 0, 0, DateTimeKind.Unspecified), 0, "Vet56@example.com", false, "VetFirstName56", false, new DateTime(2024, 8, 14, 18, 47, 27, 812, DateTimeKind.Utc).AddTicks(5135), "VetLastName56", 0, false, null, "VET56@EXAMPLE.COM", "VET56", null, null, false, "https://picsum.photos/seed/user56/200/300", null, new DateTime(2024, 8, 14, 22, 47, 27, 812, DateTimeKind.Local).AddTicks(5130), null, null, false, "Vet56" },
                    { 2057, null, 0, "Address57", "City57", "69dfd73e-3a28-4f20-88ab-dea2be07df2a", new DateTime(2024, 8, 14, 18, 47, 27, 812, DateTimeKind.Utc).AddTicks(5185), new DateTime(2000, 2, 26, 0, 0, 0, 0, DateTimeKind.Unspecified), 0, "Vet57@example.com", false, "VetFirstName57", false, new DateTime(2024, 8, 14, 18, 47, 27, 812, DateTimeKind.Utc).AddTicks(5186), "VetLastName57", 0, false, null, "VET57@EXAMPLE.COM", "VET57", null, null, false, "https://picsum.photos/seed/user57/200/300", null, new DateTime(2024, 8, 14, 22, 47, 27, 812, DateTimeKind.Local).AddTicks(5180), null, null, false, "Vet57" },
                    { 2058, null, 0, "Address58", "City58", "d47e30d8-dbcb-448f-86ed-dcf908713d06", new DateTime(2024, 8, 14, 18, 47, 27, 812, DateTimeKind.Utc).AddTicks(5201), new DateTime(2000, 2, 27, 0, 0, 0, 0, DateTimeKind.Unspecified), 0, "Vet58@example.com", false, "VetFirstName58", false, new DateTime(2024, 8, 14, 18, 47, 27, 812, DateTimeKind.Utc).AddTicks(5202), "VetLastName58", 0, false, null, "VET58@EXAMPLE.COM", "VET58", null, null, false, "https://picsum.photos/seed/user58/200/300", null, new DateTime(2024, 8, 14, 22, 47, 27, 812, DateTimeKind.Local).AddTicks(5193), null, null, false, "Vet58" },
                    { 2059, null, 0, "Address59", "City59", "56f16dd0-554d-40f0-92f5-e2a593d169a9", new DateTime(2024, 8, 14, 18, 47, 27, 812, DateTimeKind.Utc).AddTicks(5214), new DateTime(2000, 2, 28, 0, 0, 0, 0, DateTimeKind.Unspecified), 0, "Vet59@example.com", false, "VetFirstName59", false, new DateTime(2024, 8, 14, 18, 47, 27, 812, DateTimeKind.Utc).AddTicks(5214), "VetLastName59", 0, false, null, "VET59@EXAMPLE.COM", "VET59", null, null, false, "https://picsum.photos/seed/user59/200/300", null, new DateTime(2024, 8, 14, 22, 47, 27, 812, DateTimeKind.Local).AddTicks(5209), null, null, false, "Vet59" },
                    { 2060, null, 0, "Address60", "City60", "00190766-f3e5-4850-ace0-edfb38f54dc5", new DateTime(2024, 8, 14, 18, 47, 27, 812, DateTimeKind.Utc).AddTicks(5226), new DateTime(2000, 2, 29, 0, 0, 0, 0, DateTimeKind.Unspecified), 0, "Vet60@example.com", false, "VetFirstName60", false, new DateTime(2024, 8, 14, 18, 47, 27, 812, DateTimeKind.Utc).AddTicks(5227), "VetLastName60", 0, false, null, "VET60@EXAMPLE.COM", "VET60", null, null, false, "https://picsum.photos/seed/user60/200/300", null, new DateTime(2024, 8, 14, 22, 47, 27, 812, DateTimeKind.Local).AddTicks(5221), null, null, false, "Vet60" }
                });

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
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: 4);

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

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: 3);

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: 2001);

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: 2002);

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: 2003);

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: 2004);

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: 2005);

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: 2006);

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: 2007);

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: 2008);

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: 2009);

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: 2010);

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: 2011);

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: 2012);

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: 2013);

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: 2014);

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: 2015);

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: 2016);

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: 2017);

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: 2018);

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: 2019);

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: 2020);

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: 2021);

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: 2022);

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: 2023);

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: 2024);

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: 2025);

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: 2026);

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: 2027);

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: 2028);

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: 2029);

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: 2030);

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: 2031);

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: 2032);

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: 2033);

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: 2034);

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: 2035);

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: 2036);

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: 2037);

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: 2038);

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: 2039);

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: 2040);

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: 2041);

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: 2042);

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: 2043);

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: 2044);

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: 2045);

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: 2046);

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: 2047);

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: 2048);

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: 2049);

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: 2050);

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: 2051);

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: 2052);

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: 2053);

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: 2054);

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: 2055);

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: 2056);

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: 2057);

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: 2058);

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: 2059);

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: 2060);
        }
    }
}
