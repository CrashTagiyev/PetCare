using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace Persistance.Migrations
{
    /// <inheritdoc />
    public partial class mig1 : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "AspNetRoles",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Name = table.Column<string>(type: "nvarchar(256)", maxLength: 256, nullable: true),
                    NormalizedName = table.Column<string>(type: "nvarchar(256)", maxLength: 256, nullable: true),
                    ConcurrencyStamp = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AspNetRoles", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "AspNetUsers",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Firstname = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Lastname = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    DateOfBirth = table.Column<DateTime>(type: "datetime2", nullable: true),
                    City = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Address = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    RefreshToken = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    RefreshTokenExpireTime = table.Column<DateTime>(type: "datetime2", nullable: true),
                    RefreshTokenCreateTime = table.Column<DateTime>(type: "datetime2", nullable: true),
                    CreatedTime = table.Column<DateTime>(type: "datetime2", nullable: false),
                    LastUpdatedTime = table.Column<DateTime>(type: "datetime2", nullable: false),
                    IsDeleted = table.Column<bool>(type: "bit", nullable: false),
                    ProfileImageUrl = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Likes = table.Column<int>(type: "int", nullable: true),
                    Dislikes = table.Column<int>(type: "int", nullable: true),
                    CompanyName = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    About = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    UserName = table.Column<string>(type: "nvarchar(256)", maxLength: 256, nullable: true),
                    NormalizedUserName = table.Column<string>(type: "nvarchar(256)", maxLength: 256, nullable: true),
                    Email = table.Column<string>(type: "nvarchar(256)", maxLength: 256, nullable: true),
                    NormalizedEmail = table.Column<string>(type: "nvarchar(256)", maxLength: 256, nullable: true),
                    EmailConfirmed = table.Column<bool>(type: "bit", nullable: false),
                    PasswordHash = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    SecurityStamp = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    ConcurrencyStamp = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    PhoneNumber = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    PhoneNumberConfirmed = table.Column<bool>(type: "bit", nullable: false),
                    TwoFactorEnabled = table.Column<bool>(type: "bit", nullable: false),
                    LockoutEnd = table.Column<DateTimeOffset>(type: "datetimeoffset", nullable: true),
                    LockoutEnabled = table.Column<bool>(type: "bit", nullable: false),
                    AccessFailedCount = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AspNetUsers", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "PetTypes",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    TypeName = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    CreatedTime = table.Column<DateTime>(type: "datetime2", nullable: false),
                    LastUpdatedTime = table.Column<DateTime>(type: "datetime2", nullable: false),
                    IsDeleted = table.Column<bool>(type: "bit", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_PetTypes", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "AspNetRoleClaims",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    RoleId = table.Column<int>(type: "int", nullable: false),
                    ClaimType = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    ClaimValue = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AspNetRoleClaims", x => x.Id);
                    table.ForeignKey(
                        name: "FK_AspNetRoleClaims_AspNetRoles_RoleId",
                        column: x => x.RoleId,
                        principalTable: "AspNetRoles",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "AspNetUserClaims",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    UserId = table.Column<int>(type: "int", nullable: false),
                    ClaimType = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    ClaimValue = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AspNetUserClaims", x => x.Id);
                    table.ForeignKey(
                        name: "FK_AspNetUserClaims_AspNetUsers_UserId",
                        column: x => x.UserId,
                        principalTable: "AspNetUsers",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "AspNetUserLogins",
                columns: table => new
                {
                    LoginProvider = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    ProviderKey = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    ProviderDisplayName = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    UserId = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AspNetUserLogins", x => new { x.LoginProvider, x.ProviderKey });
                    table.ForeignKey(
                        name: "FK_AspNetUserLogins_AspNetUsers_UserId",
                        column: x => x.UserId,
                        principalTable: "AspNetUsers",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "AspNetUserRoles",
                columns: table => new
                {
                    UserId = table.Column<int>(type: "int", nullable: false),
                    RoleId = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AspNetUserRoles", x => new { x.UserId, x.RoleId });
                    table.ForeignKey(
                        name: "FK_AspNetUserRoles_AspNetRoles_RoleId",
                        column: x => x.RoleId,
                        principalTable: "AspNetRoles",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_AspNetUserRoles_AspNetUsers_UserId",
                        column: x => x.UserId,
                        principalTable: "AspNetUsers",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "AspNetUserTokens",
                columns: table => new
                {
                    UserId = table.Column<int>(type: "int", nullable: false),
                    LoginProvider = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    Name = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    Value = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AspNetUserTokens", x => new { x.UserId, x.LoginProvider, x.Name });
                    table.ForeignKey(
                        name: "FK_AspNetUserTokens_AspNetUsers_UserId",
                        column: x => x.UserId,
                        principalTable: "AspNetUsers",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "Chats",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    UserId = table.Column<int>(type: "int", nullable: false),
                    VetId = table.Column<int>(type: "int", nullable: false),
                    ChatName = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    EndedAt = table.Column<DateTime>(type: "datetime2", nullable: true),
                    CreatedTime = table.Column<DateTime>(type: "datetime2", nullable: false),
                    LastUpdatedTime = table.Column<DateTime>(type: "datetime2", nullable: false),
                    IsDeleted = table.Column<bool>(type: "bit", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Chats", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Chats_AspNetUsers_UserId",
                        column: x => x.UserId,
                        principalTable: "AspNetUsers",
                        principalColumn: "Id");
                    table.ForeignKey(
                        name: "FK_Chats_AspNetUsers_VetId",
                        column: x => x.VetId,
                        principalTable: "AspNetUsers",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "Donations",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Amount = table.Column<decimal>(type: "decimal(18,2)", nullable: false),
                    CompanyId = table.Column<int>(type: "int", nullable: false),
                    UserId = table.Column<int>(type: "int", nullable: false),
                    CreatedTime = table.Column<DateTime>(type: "datetime2", nullable: false),
                    LastUpdatedTime = table.Column<DateTime>(type: "datetime2", nullable: false),
                    IsDeleted = table.Column<bool>(type: "bit", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Donations", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Donations_AspNetUsers_CompanyId",
                        column: x => x.CompanyId,
                        principalTable: "AspNetUsers",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_Donations_AspNetUsers_UserId",
                        column: x => x.UserId,
                        principalTable: "AspNetUsers",
                        principalColumn: "Id");
                });

            migrationBuilder.CreateTable(
                name: "Notifications",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    SenderUserName = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    ReceiverUserName = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Content = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    UserId = table.Column<int>(type: "int", nullable: false),
                    CreatedTime = table.Column<DateTime>(type: "datetime2", nullable: false),
                    LastUpdatedTime = table.Column<DateTime>(type: "datetime2", nullable: false),
                    IsDeleted = table.Column<bool>(type: "bit", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Notifications", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Notifications_AspNetUsers_UserId",
                        column: x => x.UserId,
                        principalTable: "AspNetUsers",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "Shelters",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    CompanyId = table.Column<int>(type: "int", nullable: false),
                    ShelterName = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    AboutShelter = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    AdoptionPolicy = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    City = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Address = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    ShelterImageUrl = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    CreatedTime = table.Column<DateTime>(type: "datetime2", nullable: false),
                    LastUpdatedTime = table.Column<DateTime>(type: "datetime2", nullable: false),
                    IsDeleted = table.Column<bool>(type: "bit", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Shelters", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Shelters_AspNetUsers_CompanyId",
                        column: x => x.CompanyId,
                        principalTable: "AspNetUsers",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "AppUserPetType",
                columns: table => new
                {
                    ProficientPetTypesId = table.Column<int>(type: "int", nullable: false),
                    VetsId = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AppUserPetType", x => new { x.ProficientPetTypesId, x.VetsId });
                    table.ForeignKey(
                        name: "FK_AppUserPetType_AspNetUsers_VetsId",
                        column: x => x.VetsId,
                        principalTable: "AspNetUsers",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_AppUserPetType_PetTypes_ProficientPetTypesId",
                        column: x => x.ProficientPetTypesId,
                        principalTable: "PetTypes",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "Breeds",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    BreedName = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    PetTypeId = table.Column<int>(type: "int", nullable: false),
                    CreatedTime = table.Column<DateTime>(type: "datetime2", nullable: false),
                    LastUpdatedTime = table.Column<DateTime>(type: "datetime2", nullable: false),
                    IsDeleted = table.Column<bool>(type: "bit", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Breeds", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Breeds_PetTypes_PetTypeId",
                        column: x => x.PetTypeId,
                        principalTable: "PetTypes",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "Messages",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    ChatId = table.Column<int>(type: "int", nullable: false),
                    SenderId = table.Column<int>(type: "int", nullable: false),
                    Content = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    IsSeen = table.Column<bool>(type: "bit", nullable: false),
                    CreatedTime = table.Column<DateTime>(type: "datetime2", nullable: false),
                    LastUpdatedTime = table.Column<DateTime>(type: "datetime2", nullable: false),
                    IsDeleted = table.Column<bool>(type: "bit", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Messages", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Messages_AspNetUsers_SenderId",
                        column: x => x.SenderId,
                        principalTable: "AspNetUsers",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_Messages_Chats_ChatId",
                        column: x => x.ChatId,
                        principalTable: "Chats",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "Pets",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    PetName = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Description = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Size = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Age = table.Column<short>(type: "smallint", nullable: false),
                    Gender = table.Column<int>(type: "int", nullable: false),
                    ImageUrls = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    IsAdopted = table.Column<bool>(type: "bit", nullable: false),
                    Health = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Weight = table.Column<decimal>(type: "decimal(18,2)", nullable: false),
                    BreedId = table.Column<int>(type: "int", nullable: false),
                    PetTypeId = table.Column<int>(type: "int", nullable: false),
                    ShelterId = table.Column<int>(type: "int", nullable: false),
                    AdoptionId = table.Column<int>(type: "int", nullable: true),
                    CreatedTime = table.Column<DateTime>(type: "datetime2", nullable: false),
                    LastUpdatedTime = table.Column<DateTime>(type: "datetime2", nullable: false),
                    IsDeleted = table.Column<bool>(type: "bit", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Pets", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Pets_Breeds_BreedId",
                        column: x => x.BreedId,
                        principalTable: "Breeds",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_Pets_PetTypes_PetTypeId",
                        column: x => x.PetTypeId,
                        principalTable: "PetTypes",
                        principalColumn: "Id");
                    table.ForeignKey(
                        name: "FK_Pets_Shelters_ShelterId",
                        column: x => x.ShelterId,
                        principalTable: "Shelters",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "AcceptRequests",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    AcceptStatus = table.Column<int>(type: "int", nullable: false, defaultValue: 2),
                    Description = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    YearsOfPetExperience = table.Column<int>(type: "int", nullable: false),
                    PetId = table.Column<int>(type: "int", nullable: false),
                    UserId = table.Column<int>(type: "int", nullable: false),
                    CreatedTime = table.Column<DateTime>(type: "datetime2", nullable: false),
                    LastUpdatedTime = table.Column<DateTime>(type: "datetime2", nullable: false),
                    IsDeleted = table.Column<bool>(type: "bit", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AcceptRequests", x => x.Id);
                    table.ForeignKey(
                        name: "FK_AcceptRequests_AspNetUsers_UserId",
                        column: x => x.UserId,
                        principalTable: "AspNetUsers",
                        principalColumn: "Id");
                    table.ForeignKey(
                        name: "FK_AcceptRequests_Pets_PetId",
                        column: x => x.PetId,
                        principalTable: "Pets",
                        principalColumn: "Id");
                });

            migrationBuilder.CreateTable(
                name: "Adoptions",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    PetId = table.Column<int>(type: "int", nullable: false),
                    UserId = table.Column<int>(type: "int", nullable: false),
                    CreatedTime = table.Column<DateTime>(type: "datetime2", nullable: false),
                    LastUpdatedTime = table.Column<DateTime>(type: "datetime2", nullable: false),
                    IsDeleted = table.Column<bool>(type: "bit", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Adoptions", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Adoptions_AspNetUsers_UserId",
                        column: x => x.UserId,
                        principalTable: "AspNetUsers",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_Adoptions_Pets_PetId",
                        column: x => x.PetId,
                        principalTable: "Pets",
                        principalColumn: "Id");
                });

            migrationBuilder.InsertData(
                table: "AspNetRoles",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[,]
                {
                    { 1, null, "User", "USER" },
                    { 2, null, "Company", "COMPANY" },
                    { 3, null, "Vet", "VET" },
                    { 4, null, "Admin", "Admin" }
                });

            migrationBuilder.InsertData(
                table: "AspNetUsers",
                columns: new[] { "Id", "About", "AccessFailedCount", "Address", "City", "CompanyName", "ConcurrencyStamp", "CreatedTime", "DateOfBirth", "Dislikes", "Email", "EmailConfirmed", "Firstname", "IsDeleted", "LastUpdatedTime", "Lastname", "Likes", "LockoutEnabled", "LockoutEnd", "NormalizedEmail", "NormalizedUserName", "PasswordHash", "PhoneNumber", "PhoneNumberConfirmed", "ProfileImageUrl", "RefreshToken", "RefreshTokenCreateTime", "RefreshTokenExpireTime", "SecurityStamp", "TwoFactorEnabled", "UserName" },
                values: new object[,]
                {
                    { 2001, "Somme about text for something bla bla bla", 0, "Koroglu Rahimov 70", "Baku", null, "546515a9-23a7-4aec-9034-9a9f4fe309f5", new DateTime(2024, 8, 26, 8, 2, 41, 232, DateTimeKind.Utc).AddTicks(2340), new DateTime(2000, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 1, "user1@example.com", true, "FirstName1", false, new DateTime(2024, 8, 26, 8, 2, 41, 232, DateTimeKind.Utc).AddTicks(2341), "LastName1", 1, false, null, "USER1@EXAMPLE.COM", "USER1", "AQAAAAIAAYagAAAAEK3JbxnMOU+exC6cOxQLvXvHG6Xt/a7qhEXNftH7DTJLiaC5qZ4fuRAYHF58dVJXaQ==", null, false, "https://picsum.photos/seed/user1/200/300", null, new DateTime(2024, 8, 26, 8, 2, 41, 232, DateTimeKind.Utc).AddTicks(2272), null, "RYZH37KPG6EEDGSYWW37NETRG56JM7KG", false, "user1" },
                    { 2002, "Somme about text for something bla bla bla", 0, "Koroglu Rahimov 70", "Baku", null, "c5f00b48-f3f8-480f-863f-0ab40777c9ae", new DateTime(2024, 8, 26, 8, 2, 41, 232, DateTimeKind.Utc).AddTicks(2403), new DateTime(2000, 1, 2, 0, 0, 0, 0, DateTimeKind.Unspecified), 1, "user2@example.com", true, "FirstName2", false, new DateTime(2024, 8, 26, 8, 2, 41, 232, DateTimeKind.Utc).AddTicks(2404), "LastName2", 1, false, null, "USER2@EXAMPLE.COM", "USER2", "AQAAAAIAAYagAAAAEK3JbxnMOU+exC6cOxQLvXvHG6Xt/a7qhEXNftH7DTJLiaC5qZ4fuRAYHF58dVJXaQ==", null, false, "https://picsum.photos/seed/user2/200/300", null, new DateTime(2024, 8, 26, 8, 2, 41, 232, DateTimeKind.Utc).AddTicks(2399), null, "RYZH37KPG6EEDGSYWW37NETRG56JM7KG", false, "user2" },
                    { 2003, "Somme about text for something bla bla bla", 0, "Koroglu Rahimov 70", "Baku", null, "98042ee5-42ee-48b5-b1e5-f708eada4f81", new DateTime(2024, 8, 26, 8, 2, 41, 232, DateTimeKind.Utc).AddTicks(2429), new DateTime(2000, 1, 3, 0, 0, 0, 0, DateTimeKind.Unspecified), 1, "user3@example.com", true, "FirstName3", false, new DateTime(2024, 8, 26, 8, 2, 41, 232, DateTimeKind.Utc).AddTicks(2429), "LastName3", 1, false, null, "USER3@EXAMPLE.COM", "USER3", "AQAAAAIAAYagAAAAEK3JbxnMOU+exC6cOxQLvXvHG6Xt/a7qhEXNftH7DTJLiaC5qZ4fuRAYHF58dVJXaQ==", null, false, "https://picsum.photos/seed/user3/200/300", null, new DateTime(2024, 8, 26, 8, 2, 41, 232, DateTimeKind.Utc).AddTicks(2413), null, "RYZH37KPG6EEDGSYWW37NETRG56JM7KG", false, "user3" },
                    { 2004, "Somme about text for something bla bla bla", 0, "Koroglu Rahimov 70", "Baku", null, "b32a27d5-9246-42d6-864b-c96236e5a2ff", new DateTime(2024, 8, 26, 8, 2, 41, 232, DateTimeKind.Utc).AddTicks(2441), new DateTime(2000, 1, 4, 0, 0, 0, 0, DateTimeKind.Unspecified), 1, "user4@example.com", true, "FirstName4", false, new DateTime(2024, 8, 26, 8, 2, 41, 232, DateTimeKind.Utc).AddTicks(2442), "LastName4", 1, false, null, "USER4@EXAMPLE.COM", "USER4", "AQAAAAIAAYagAAAAEK3JbxnMOU+exC6cOxQLvXvHG6Xt/a7qhEXNftH7DTJLiaC5qZ4fuRAYHF58dVJXaQ==", null, false, "https://picsum.photos/seed/user4/200/300", null, new DateTime(2024, 8, 26, 8, 2, 41, 232, DateTimeKind.Utc).AddTicks(2438), null, "RYZH37KPG6EEDGSYWW37NETRG56JM7KG", false, "user4" },
                    { 2005, "Somme about text for something bla bla bla", 0, "Koroglu Rahimov 70", "Baku", null, "b0bbfa29-6f61-4c35-ab8b-babdf2ba9cc0", new DateTime(2024, 8, 26, 8, 2, 41, 232, DateTimeKind.Utc).AddTicks(2453), new DateTime(2000, 1, 5, 0, 0, 0, 0, DateTimeKind.Unspecified), 1, "user5@example.com", true, "FirstName5", false, new DateTime(2024, 8, 26, 8, 2, 41, 232, DateTimeKind.Utc).AddTicks(2453), "LastName5", 1, false, null, "USER5@EXAMPLE.COM", "USER5", "AQAAAAIAAYagAAAAEK3JbxnMOU+exC6cOxQLvXvHG6Xt/a7qhEXNftH7DTJLiaC5qZ4fuRAYHF58dVJXaQ==", null, false, "https://picsum.photos/seed/user5/200/300", null, new DateTime(2024, 8, 26, 8, 2, 41, 232, DateTimeKind.Utc).AddTicks(2450), null, "RYZH37KPG6EEDGSYWW37NETRG56JM7KG", false, "user5" },
                    { 2006, "Somme about text for something bla bla bla", 0, "Koroglu Rahimov 70", "Baku", null, "8299c46f-9f11-4334-a851-90bc46c0f830", new DateTime(2024, 8, 26, 8, 2, 41, 232, DateTimeKind.Utc).AddTicks(2467), new DateTime(2000, 1, 6, 0, 0, 0, 0, DateTimeKind.Unspecified), 1, "user6@example.com", true, "FirstName6", false, new DateTime(2024, 8, 26, 8, 2, 41, 232, DateTimeKind.Utc).AddTicks(2468), "LastName6", 1, false, null, "USER6@EXAMPLE.COM", "USER6", "AQAAAAIAAYagAAAAEK3JbxnMOU+exC6cOxQLvXvHG6Xt/a7qhEXNftH7DTJLiaC5qZ4fuRAYHF58dVJXaQ==", null, false, "https://picsum.photos/seed/user6/200/300", null, new DateTime(2024, 8, 26, 8, 2, 41, 232, DateTimeKind.Utc).AddTicks(2464), null, "RYZH37KPG6EEDGSYWW37NETRG56JM7KG", false, "user6" },
                    { 2007, "Somme about text for something bla bla bla", 0, "Koroglu Rahimov 70", "Baku", null, "cf0dcfdc-3943-4ca5-a6c0-9d550d248278", new DateTime(2024, 8, 26, 8, 2, 41, 232, DateTimeKind.Utc).AddTicks(2479), new DateTime(2000, 1, 7, 0, 0, 0, 0, DateTimeKind.Unspecified), 1, "user7@example.com", true, "FirstName7", false, new DateTime(2024, 8, 26, 8, 2, 41, 232, DateTimeKind.Utc).AddTicks(2480), "LastName7", 1, false, null, "USER7@EXAMPLE.COM", "USER7", "AQAAAAIAAYagAAAAEK3JbxnMOU+exC6cOxQLvXvHG6Xt/a7qhEXNftH7DTJLiaC5qZ4fuRAYHF58dVJXaQ==", null, false, "https://picsum.photos/seed/user7/200/300", null, new DateTime(2024, 8, 26, 8, 2, 41, 232, DateTimeKind.Utc).AddTicks(2476), null, "RYZH37KPG6EEDGSYWW37NETRG56JM7KG", false, "user7" },
                    { 2008, "Somme about text for something bla bla bla", 0, "Koroglu Rahimov 70", "Baku", null, "8c890f9d-6b0c-4089-847c-6caba45338d4", new DateTime(2024, 8, 26, 8, 2, 41, 232, DateTimeKind.Utc).AddTicks(2491), new DateTime(2000, 1, 8, 0, 0, 0, 0, DateTimeKind.Unspecified), 1, "user8@example.com", true, "FirstName8", false, new DateTime(2024, 8, 26, 8, 2, 41, 232, DateTimeKind.Utc).AddTicks(2492), "LastName8", 1, false, null, "USER8@EXAMPLE.COM", "USER8", "AQAAAAIAAYagAAAAEK3JbxnMOU+exC6cOxQLvXvHG6Xt/a7qhEXNftH7DTJLiaC5qZ4fuRAYHF58dVJXaQ==", null, false, "https://picsum.photos/seed/user8/200/300", null, new DateTime(2024, 8, 26, 8, 2, 41, 232, DateTimeKind.Utc).AddTicks(2488), null, "RYZH37KPG6EEDGSYWW37NETRG56JM7KG", false, "user8" },
                    { 2009, "Somme about text for something bla bla bla", 0, "Koroglu Rahimov 70", "Baku", null, "07b3d827-55b6-4a4a-a6c7-aeef6d022aea", new DateTime(2024, 8, 26, 8, 2, 41, 232, DateTimeKind.Utc).AddTicks(2502), new DateTime(2000, 1, 9, 0, 0, 0, 0, DateTimeKind.Unspecified), 1, "user9@example.com", true, "FirstName9", false, new DateTime(2024, 8, 26, 8, 2, 41, 232, DateTimeKind.Utc).AddTicks(2503), "LastName9", 1, false, null, "USER9@EXAMPLE.COM", "USER9", "AQAAAAIAAYagAAAAEK3JbxnMOU+exC6cOxQLvXvHG6Xt/a7qhEXNftH7DTJLiaC5qZ4fuRAYHF58dVJXaQ==", null, false, "https://picsum.photos/seed/user9/200/300", null, new DateTime(2024, 8, 26, 8, 2, 41, 232, DateTimeKind.Utc).AddTicks(2500), null, "RYZH37KPG6EEDGSYWW37NETRG56JM7KG", false, "user9" },
                    { 2010, "Somme about text for something bla bla bla", 0, "Koroglu Rahimov 70", "Baku", null, "4b6276bc-b2a2-4d3c-b943-e071fdca5f09", new DateTime(2024, 8, 26, 8, 2, 41, 232, DateTimeKind.Utc).AddTicks(2596), new DateTime(2000, 1, 10, 0, 0, 0, 0, DateTimeKind.Unspecified), 1, "user10@example.com", true, "FirstName10", false, new DateTime(2024, 8, 26, 8, 2, 41, 232, DateTimeKind.Utc).AddTicks(2597), "LastName10", 1, false, null, "USER10@EXAMPLE.COM", "USER10", "AQAAAAIAAYagAAAAEK3JbxnMOU+exC6cOxQLvXvHG6Xt/a7qhEXNftH7DTJLiaC5qZ4fuRAYHF58dVJXaQ==", null, false, "https://picsum.photos/seed/user10/200/300", null, new DateTime(2024, 8, 26, 8, 2, 41, 232, DateTimeKind.Utc).AddTicks(2592), null, "RYZH37KPG6EEDGSYWW37NETRG56JM7KG", false, "user10" },
                    { 2011, "Somme about text for something bla bla bla", 0, "Koroglu Rahimov 70", "Baku", null, "9fb51c97-c955-4018-995e-38e4900bab8c", new DateTime(2024, 8, 26, 8, 2, 41, 232, DateTimeKind.Utc).AddTicks(2616), new DateTime(2000, 1, 11, 0, 0, 0, 0, DateTimeKind.Unspecified), 1, "user11@example.com", true, "FirstName11", false, new DateTime(2024, 8, 26, 8, 2, 41, 232, DateTimeKind.Utc).AddTicks(2617), "LastName11", 1, false, null, "USER11@EXAMPLE.COM", "USER11", "AQAAAAIAAYagAAAAEK3JbxnMOU+exC6cOxQLvXvHG6Xt/a7qhEXNftH7DTJLiaC5qZ4fuRAYHF58dVJXaQ==", null, false, "https://picsum.photos/seed/user11/200/300", null, new DateTime(2024, 8, 26, 8, 2, 41, 232, DateTimeKind.Utc).AddTicks(2608), null, "RYZH37KPG6EEDGSYWW37NETRG56JM7KG", false, "user11" },
                    { 2012, "Somme about text for something bla bla bla", 0, "Koroglu Rahimov 70", "Baku", null, "ff189fc5-03ad-4ea2-ad32-fc3126ef6dc7", new DateTime(2024, 8, 26, 8, 2, 41, 232, DateTimeKind.Utc).AddTicks(2628), new DateTime(2000, 1, 12, 0, 0, 0, 0, DateTimeKind.Unspecified), 1, "user12@example.com", true, "FirstName12", false, new DateTime(2024, 8, 26, 8, 2, 41, 232, DateTimeKind.Utc).AddTicks(2628), "LastName12", 1, false, null, "USER12@EXAMPLE.COM", "USER12", "AQAAAAIAAYagAAAAEK3JbxnMOU+exC6cOxQLvXvHG6Xt/a7qhEXNftH7DTJLiaC5qZ4fuRAYHF58dVJXaQ==", null, false, "https://picsum.photos/seed/user12/200/300", null, new DateTime(2024, 8, 26, 8, 2, 41, 232, DateTimeKind.Utc).AddTicks(2625), null, "RYZH37KPG6EEDGSYWW37NETRG56JM7KG", false, "user12" },
                    { 2013, "Somme about text for something bla bla bla", 0, "Koroglu Rahimov 70", "Baku", null, "da1c9d59-a11c-4ab7-8d9d-111aa76d658a", new DateTime(2024, 8, 26, 8, 2, 41, 232, DateTimeKind.Utc).AddTicks(2639), new DateTime(2000, 1, 13, 0, 0, 0, 0, DateTimeKind.Unspecified), 1, "user13@example.com", true, "FirstName13", false, new DateTime(2024, 8, 26, 8, 2, 41, 232, DateTimeKind.Utc).AddTicks(2639), "LastName13", 1, false, null, "USER13@EXAMPLE.COM", "USER13", "AQAAAAIAAYagAAAAEK3JbxnMOU+exC6cOxQLvXvHG6Xt/a7qhEXNftH7DTJLiaC5qZ4fuRAYHF58dVJXaQ==", null, false, "https://picsum.photos/seed/user13/200/300", null, new DateTime(2024, 8, 26, 8, 2, 41, 232, DateTimeKind.Utc).AddTicks(2636), null, "RYZH37KPG6EEDGSYWW37NETRG56JM7KG", false, "user13" },
                    { 2014, "Somme about text for something bla bla bla", 0, "Koroglu Rahimov 70", "Baku", null, "23356796-4ef3-4028-bf5e-6ceaefea22ea", new DateTime(2024, 8, 26, 8, 2, 41, 232, DateTimeKind.Utc).AddTicks(2650), new DateTime(2000, 1, 14, 0, 0, 0, 0, DateTimeKind.Unspecified), 1, "user14@example.com", true, "FirstName14", false, new DateTime(2024, 8, 26, 8, 2, 41, 232, DateTimeKind.Utc).AddTicks(2650), "LastName14", 1, false, null, "USER14@EXAMPLE.COM", "USER14", "AQAAAAIAAYagAAAAEK3JbxnMOU+exC6cOxQLvXvHG6Xt/a7qhEXNftH7DTJLiaC5qZ4fuRAYHF58dVJXaQ==", null, false, "https://picsum.photos/seed/user14/200/300", null, new DateTime(2024, 8, 26, 8, 2, 41, 232, DateTimeKind.Utc).AddTicks(2647), null, "RYZH37KPG6EEDGSYWW37NETRG56JM7KG", false, "user14" },
                    { 2015, "Somme about text for something bla bla bla", 0, "Koroglu Rahimov 70", "Baku", null, "5ee4c89c-75f1-4b26-8602-834c7ed55e15", new DateTime(2024, 8, 26, 8, 2, 41, 232, DateTimeKind.Utc).AddTicks(2662), new DateTime(2000, 1, 15, 0, 0, 0, 0, DateTimeKind.Unspecified), 1, "user15@example.com", true, "FirstName15", false, new DateTime(2024, 8, 26, 8, 2, 41, 232, DateTimeKind.Utc).AddTicks(2662), "LastName15", 1, false, null, "USER15@EXAMPLE.COM", "USER15", "AQAAAAIAAYagAAAAEK3JbxnMOU+exC6cOxQLvXvHG6Xt/a7qhEXNftH7DTJLiaC5qZ4fuRAYHF58dVJXaQ==", null, false, "https://picsum.photos/seed/user15/200/300", null, new DateTime(2024, 8, 26, 8, 2, 41, 232, DateTimeKind.Utc).AddTicks(2658), null, "RYZH37KPG6EEDGSYWW37NETRG56JM7KG", false, "user15" },
                    { 2016, "Somme about text for something bla bla bla", 0, "Koroglu Rahimov 70", "Baku", null, "096f3701-1107-411a-b7b8-e57f27ebfef9", new DateTime(2024, 8, 26, 8, 2, 41, 232, DateTimeKind.Utc).AddTicks(2673), new DateTime(2000, 1, 16, 0, 0, 0, 0, DateTimeKind.Unspecified), 1, "user16@example.com", true, "FirstName16", false, new DateTime(2024, 8, 26, 8, 2, 41, 232, DateTimeKind.Utc).AddTicks(2673), "LastName16", 1, false, null, "USER16@EXAMPLE.COM", "USER16", "AQAAAAIAAYagAAAAEK3JbxnMOU+exC6cOxQLvXvHG6Xt/a7qhEXNftH7DTJLiaC5qZ4fuRAYHF58dVJXaQ==", null, false, "https://picsum.photos/seed/user16/200/300", null, new DateTime(2024, 8, 26, 8, 2, 41, 232, DateTimeKind.Utc).AddTicks(2670), null, "RYZH37KPG6EEDGSYWW37NETRG56JM7KG", false, "user16" },
                    { 2017, "Somme about text for something bla bla bla", 0, "Koroglu Rahimov 70", "Baku", null, "532c4e5f-2650-40b4-b99b-388fdb4f457d", new DateTime(2024, 8, 26, 8, 2, 41, 232, DateTimeKind.Utc).AddTicks(2684), new DateTime(2000, 1, 17, 0, 0, 0, 0, DateTimeKind.Unspecified), 1, "user17@example.com", true, "FirstName17", false, new DateTime(2024, 8, 26, 8, 2, 41, 232, DateTimeKind.Utc).AddTicks(2685), "LastName17", 1, false, null, "USER17@EXAMPLE.COM", "USER17", "AQAAAAIAAYagAAAAEK3JbxnMOU+exC6cOxQLvXvHG6Xt/a7qhEXNftH7DTJLiaC5qZ4fuRAYHF58dVJXaQ==", null, false, "https://picsum.photos/seed/user17/200/300", null, new DateTime(2024, 8, 26, 8, 2, 41, 232, DateTimeKind.Utc).AddTicks(2681), null, "RYZH37KPG6EEDGSYWW37NETRG56JM7KG", false, "user17" },
                    { 2018, "Somme about text for something bla bla bla", 0, "Koroglu Rahimov 70", "Baku", null, "b33d9df1-49a7-45d9-9bab-ca4675f037ad", new DateTime(2024, 8, 26, 8, 2, 41, 232, DateTimeKind.Utc).AddTicks(2698), new DateTime(2000, 1, 18, 0, 0, 0, 0, DateTimeKind.Unspecified), 1, "user18@example.com", true, "FirstName18", false, new DateTime(2024, 8, 26, 8, 2, 41, 232, DateTimeKind.Utc).AddTicks(2698), "LastName18", 1, false, null, "USER18@EXAMPLE.COM", "USER18", "AQAAAAIAAYagAAAAEK3JbxnMOU+exC6cOxQLvXvHG6Xt/a7qhEXNftH7DTJLiaC5qZ4fuRAYHF58dVJXaQ==", null, false, "https://picsum.photos/seed/user18/200/300", null, new DateTime(2024, 8, 26, 8, 2, 41, 232, DateTimeKind.Utc).AddTicks(2695), null, "RYZH37KPG6EEDGSYWW37NETRG56JM7KG", false, "user18" },
                    { 2019, "Somme about text for something bla bla bla", 0, "Koroglu Rahimov 70", "Baku", null, "ebe8153b-2afc-498e-9229-b198daa29311", new DateTime(2024, 8, 26, 8, 2, 41, 232, DateTimeKind.Utc).AddTicks(2765), new DateTime(2000, 1, 19, 0, 0, 0, 0, DateTimeKind.Unspecified), 1, "user19@example.com", true, "FirstName19", false, new DateTime(2024, 8, 26, 8, 2, 41, 232, DateTimeKind.Utc).AddTicks(2766), "LastName19", 1, false, null, "USER19@EXAMPLE.COM", "USER19", "AQAAAAIAAYagAAAAEK3JbxnMOU+exC6cOxQLvXvHG6Xt/a7qhEXNftH7DTJLiaC5qZ4fuRAYHF58dVJXaQ==", null, false, "https://picsum.photos/seed/user19/200/300", null, new DateTime(2024, 8, 26, 8, 2, 41, 232, DateTimeKind.Utc).AddTicks(2758), null, "RYZH37KPG6EEDGSYWW37NETRG56JM7KG", false, "user19" },
                    { 2020, "Somme about text for something bla bla bla", 0, "Koroglu Rahimov 70", "Baku", null, "c2929caa-ec2f-4c1f-ab46-3b23ca3fd76a", new DateTime(2024, 8, 26, 8, 2, 41, 232, DateTimeKind.Utc).AddTicks(2778), new DateTime(2000, 1, 20, 0, 0, 0, 0, DateTimeKind.Unspecified), 1, "user20@example.com", true, "FirstName20", false, new DateTime(2024, 8, 26, 8, 2, 41, 232, DateTimeKind.Utc).AddTicks(2779), "LastName20", 1, false, null, "USER20@EXAMPLE.COM", "USER20", "AQAAAAIAAYagAAAAEK3JbxnMOU+exC6cOxQLvXvHG6Xt/a7qhEXNftH7DTJLiaC5qZ4fuRAYHF58dVJXaQ==", null, false, "https://picsum.photos/seed/user20/200/300", null, new DateTime(2024, 8, 26, 8, 2, 41, 232, DateTimeKind.Utc).AddTicks(2775), null, "RYZH37KPG6EEDGSYWW37NETRG56JM7KG", false, "user20" },
                    { 2021, "Somme about text for something bla bla bla", 0, "Koroglu Rahimov 70", "Baku", "Company Name21", "2f09ea2a-c710-4720-915c-3094f355579e", new DateTime(2024, 8, 26, 8, 2, 41, 232, DateTimeKind.Utc).AddTicks(2792), new DateTime(2000, 1, 21, 0, 0, 0, 0, DateTimeKind.Unspecified), 1, "Company21@example.com", true, "CompanyFirstName21", false, new DateTime(2024, 8, 26, 8, 2, 41, 232, DateTimeKind.Utc).AddTicks(2792), "CompanyLastName21", 1, false, null, "COMPANY21@EXAMPLE.COM", "COMPANY21", "AQAAAAIAAYagAAAAEK3JbxnMOU+exC6cOxQLvXvHG6Xt/a7qhEXNftH7DTJLiaC5qZ4fuRAYHF58dVJXaQ==", null, false, "https://picsum.photos/seed/user21/200/300", null, new DateTime(2024, 8, 26, 8, 2, 41, 232, DateTimeKind.Utc).AddTicks(2789), null, "RYZH37KPG6EEDGSYWW37NETRG56JM7KG", false, "Company21" },
                    { 2022, "Somme about text for something bla bla bla", 0, "Koroglu Rahimov 70", "Baku", "Company Name22", "e444f09d-d1dd-468c-ad4b-e0d8dca25d09", new DateTime(2024, 8, 26, 8, 2, 41, 232, DateTimeKind.Utc).AddTicks(2811), new DateTime(2000, 1, 22, 0, 0, 0, 0, DateTimeKind.Unspecified), 1, "Company22@example.com", true, "CompanyFirstName22", false, new DateTime(2024, 8, 26, 8, 2, 41, 232, DateTimeKind.Utc).AddTicks(2812), "CompanyLastName22", 1, false, null, "COMPANY22@EXAMPLE.COM", "COMPANY22", "AQAAAAIAAYagAAAAEK3JbxnMOU+exC6cOxQLvXvHG6Xt/a7qhEXNftH7DTJLiaC5qZ4fuRAYHF58dVJXaQ==", null, false, "https://picsum.photos/seed/user22/200/300", null, new DateTime(2024, 8, 26, 8, 2, 41, 232, DateTimeKind.Utc).AddTicks(2808), null, "RYZH37KPG6EEDGSYWW37NETRG56JM7KG", false, "Company22" },
                    { 2023, "Somme about text for something bla bla bla", 0, "Koroglu Rahimov 70", "Baku", "Company Name23", "f6ab9f36-0ca5-4812-b7f2-a9b567c45c85", new DateTime(2024, 8, 26, 8, 2, 41, 232, DateTimeKind.Utc).AddTicks(2824), new DateTime(2000, 1, 23, 0, 0, 0, 0, DateTimeKind.Unspecified), 1, "Company23@example.com", true, "CompanyFirstName23", false, new DateTime(2024, 8, 26, 8, 2, 41, 232, DateTimeKind.Utc).AddTicks(2825), "CompanyLastName23", 1, false, null, "COMPANY23@EXAMPLE.COM", "COMPANY23", "AQAAAAIAAYagAAAAEK3JbxnMOU+exC6cOxQLvXvHG6Xt/a7qhEXNftH7DTJLiaC5qZ4fuRAYHF58dVJXaQ==", null, false, "https://picsum.photos/seed/user23/200/300", null, new DateTime(2024, 8, 26, 8, 2, 41, 232, DateTimeKind.Utc).AddTicks(2821), null, "RYZH37KPG6EEDGSYWW37NETRG56JM7KG", false, "Company23" },
                    { 2024, "Somme about text for something bla bla bla", 0, "Koroglu Rahimov 70", "Baku", "Company Name24", "4db6007a-72b5-46fd-95b4-2da6ec39e4ce", new DateTime(2024, 8, 26, 8, 2, 41, 232, DateTimeKind.Utc).AddTicks(2837), new DateTime(2000, 1, 24, 0, 0, 0, 0, DateTimeKind.Unspecified), 1, "Company24@example.com", true, "CompanyFirstName24", false, new DateTime(2024, 8, 26, 8, 2, 41, 232, DateTimeKind.Utc).AddTicks(2838), "CompanyLastName24", 1, false, null, "COMPANY24@EXAMPLE.COM", "COMPANY24", "AQAAAAIAAYagAAAAEK3JbxnMOU+exC6cOxQLvXvHG6Xt/a7qhEXNftH7DTJLiaC5qZ4fuRAYHF58dVJXaQ==", null, false, "https://picsum.photos/seed/user24/200/300", null, new DateTime(2024, 8, 26, 8, 2, 41, 232, DateTimeKind.Utc).AddTicks(2834), null, "RYZH37KPG6EEDGSYWW37NETRG56JM7KG", false, "Company24" },
                    { 2025, "Somme about text for something bla bla bla", 0, "Koroglu Rahimov 70", "Baku", "Company Name25", "9036a215-b509-4920-b45a-2af239f42032", new DateTime(2024, 8, 26, 8, 2, 41, 232, DateTimeKind.Utc).AddTicks(2849), new DateTime(2000, 1, 25, 0, 0, 0, 0, DateTimeKind.Unspecified), 1, "Company25@example.com", true, "CompanyFirstName25", false, new DateTime(2024, 8, 26, 8, 2, 41, 232, DateTimeKind.Utc).AddTicks(2849), "CompanyLastName25", 1, false, null, "COMPANY25@EXAMPLE.COM", "COMPANY25", "AQAAAAIAAYagAAAAEK3JbxnMOU+exC6cOxQLvXvHG6Xt/a7qhEXNftH7DTJLiaC5qZ4fuRAYHF58dVJXaQ==", null, false, "https://picsum.photos/seed/user25/200/300", null, new DateTime(2024, 8, 26, 8, 2, 41, 232, DateTimeKind.Utc).AddTicks(2846), null, "RYZH37KPG6EEDGSYWW37NETRG56JM7KG", false, "Company25" },
                    { 2026, "Somme about text for something bla bla bla", 0, "Koroglu Rahimov 70", "Baku", "Company Name26", "a6f19736-9722-4c35-b516-05dc3d872e43", new DateTime(2024, 8, 26, 8, 2, 41, 232, DateTimeKind.Utc).AddTicks(2861), new DateTime(2000, 1, 26, 0, 0, 0, 0, DateTimeKind.Unspecified), 1, "Company26@example.com", true, "CompanyFirstName26", false, new DateTime(2024, 8, 26, 8, 2, 41, 232, DateTimeKind.Utc).AddTicks(2862), "CompanyLastName26", 1, false, null, "COMPANY26@EXAMPLE.COM", "COMPANY26", "AQAAAAIAAYagAAAAEK3JbxnMOU+exC6cOxQLvXvHG6Xt/a7qhEXNftH7DTJLiaC5qZ4fuRAYHF58dVJXaQ==", null, false, "https://picsum.photos/seed/user26/200/300", null, new DateTime(2024, 8, 26, 8, 2, 41, 232, DateTimeKind.Utc).AddTicks(2858), null, "RYZH37KPG6EEDGSYWW37NETRG56JM7KG", false, "Company26" },
                    { 2027, "Somme about text for something bla bla bla", 0, "Koroglu Rahimov 70", "Baku", "Company Name27", "a5f77e36-3da9-4818-b679-a1b1b168cfa9", new DateTime(2024, 8, 26, 8, 2, 41, 232, DateTimeKind.Utc).AddTicks(2878), new DateTime(2000, 1, 27, 0, 0, 0, 0, DateTimeKind.Unspecified), 1, "Company27@example.com", true, "CompanyFirstName27", false, new DateTime(2024, 8, 26, 8, 2, 41, 232, DateTimeKind.Utc).AddTicks(2878), "CompanyLastName27", 1, false, null, "COMPANY27@EXAMPLE.COM", "COMPANY27", "AQAAAAIAAYagAAAAEK3JbxnMOU+exC6cOxQLvXvHG6Xt/a7qhEXNftH7DTJLiaC5qZ4fuRAYHF58dVJXaQ==", null, false, "https://picsum.photos/seed/user27/200/300", null, new DateTime(2024, 8, 26, 8, 2, 41, 232, DateTimeKind.Utc).AddTicks(2872), null, "RYZH37KPG6EEDGSYWW37NETRG56JM7KG", false, "Company27" },
                    { 2028, "Somme about text for something bla bla bla", 0, "Koroglu Rahimov 70", "Baku", "Company Name28", "bbd831bf-8882-453e-ae2c-9850997c6bd8", new DateTime(2024, 8, 26, 8, 2, 41, 232, DateTimeKind.Utc).AddTicks(2925), new DateTime(2000, 1, 28, 0, 0, 0, 0, DateTimeKind.Unspecified), 1, "Company28@example.com", true, "CompanyFirstName28", false, new DateTime(2024, 8, 26, 8, 2, 41, 232, DateTimeKind.Utc).AddTicks(2925), "CompanyLastName28", 1, false, null, "COMPANY28@EXAMPLE.COM", "COMPANY28", "AQAAAAIAAYagAAAAEK3JbxnMOU+exC6cOxQLvXvHG6Xt/a7qhEXNftH7DTJLiaC5qZ4fuRAYHF58dVJXaQ==", null, false, "https://picsum.photos/seed/user28/200/300", null, new DateTime(2024, 8, 26, 8, 2, 41, 232, DateTimeKind.Utc).AddTicks(2922), null, "RYZH37KPG6EEDGSYWW37NETRG56JM7KG", false, "Company28" },
                    { 2029, "Somme about text for something bla bla bla", 0, "Koroglu Rahimov 70", "Baku", "Company Name29", "9b46643c-94b4-4bdb-b2fe-8463baa4339e", new DateTime(2024, 8, 26, 8, 2, 41, 232, DateTimeKind.Utc).AddTicks(2938), new DateTime(2000, 1, 29, 0, 0, 0, 0, DateTimeKind.Unspecified), 1, "Company29@example.com", true, "CompanyFirstName29", false, new DateTime(2024, 8, 26, 8, 2, 41, 232, DateTimeKind.Utc).AddTicks(2939), "CompanyLastName29", 1, false, null, "COMPANY29@EXAMPLE.COM", "COMPANY29", "AQAAAAIAAYagAAAAEK3JbxnMOU+exC6cOxQLvXvHG6Xt/a7qhEXNftH7DTJLiaC5qZ4fuRAYHF58dVJXaQ==", null, false, "https://picsum.photos/seed/user29/200/300", null, new DateTime(2024, 8, 26, 8, 2, 41, 232, DateTimeKind.Utc).AddTicks(2935), null, "RYZH37KPG6EEDGSYWW37NETRG56JM7KG", false, "Company29" },
                    { 2030, "Somme about text for something bla bla bla", 0, "Koroglu Rahimov 70", "Baku", "Company Name30", "24507c25-7477-428b-b615-1a4b38a61486", new DateTime(2024, 8, 26, 8, 2, 41, 232, DateTimeKind.Utc).AddTicks(2951), new DateTime(2000, 1, 30, 0, 0, 0, 0, DateTimeKind.Unspecified), 1, "Company30@example.com", true, "CompanyFirstName30", false, new DateTime(2024, 8, 26, 8, 2, 41, 232, DateTimeKind.Utc).AddTicks(2951), "CompanyLastName30", 1, false, null, "COMPANY30@EXAMPLE.COM", "COMPANY30", "AQAAAAIAAYagAAAAEK3JbxnMOU+exC6cOxQLvXvHG6Xt/a7qhEXNftH7DTJLiaC5qZ4fuRAYHF58dVJXaQ==", null, false, "https://picsum.photos/seed/user30/200/300", null, new DateTime(2024, 8, 26, 8, 2, 41, 232, DateTimeKind.Utc).AddTicks(2948), null, "RYZH37KPG6EEDGSYWW37NETRG56JM7KG", false, "Company30" },
                    { 2031, "Somme about text for something bla bla bla", 0, "Koroglu Rahimov 70", "Baku", "Company Name31", "4d775e06-2dc1-4eb0-a00d-7a0fedacfbe2", new DateTime(2024, 8, 26, 8, 2, 41, 232, DateTimeKind.Utc).AddTicks(2963), new DateTime(2000, 1, 31, 0, 0, 0, 0, DateTimeKind.Unspecified), 1, "Company31@example.com", true, "CompanyFirstName31", false, new DateTime(2024, 8, 26, 8, 2, 41, 232, DateTimeKind.Utc).AddTicks(2963), "CompanyLastName31", 1, false, null, "COMPANY31@EXAMPLE.COM", "COMPANY31", "AQAAAAIAAYagAAAAEK3JbxnMOU+exC6cOxQLvXvHG6Xt/a7qhEXNftH7DTJLiaC5qZ4fuRAYHF58dVJXaQ==", null, false, "https://picsum.photos/seed/user31/200/300", null, new DateTime(2024, 8, 26, 8, 2, 41, 232, DateTimeKind.Utc).AddTicks(2960), null, "RYZH37KPG6EEDGSYWW37NETRG56JM7KG", false, "Company31" },
                    { 2032, "Somme about text for something bla bla bla", 0, "Koroglu Rahimov 70", "Baku", "Company Name32", "44ce0e53-0c68-4fbd-8ddd-e90218c0a096", new DateTime(2024, 8, 26, 8, 2, 41, 232, DateTimeKind.Utc).AddTicks(2976), new DateTime(2000, 2, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 1, "Company32@example.com", true, "CompanyFirstName32", false, new DateTime(2024, 8, 26, 8, 2, 41, 232, DateTimeKind.Utc).AddTicks(2976), "CompanyLastName32", 1, false, null, "COMPANY32@EXAMPLE.COM", "COMPANY32", "AQAAAAIAAYagAAAAEK3JbxnMOU+exC6cOxQLvXvHG6Xt/a7qhEXNftH7DTJLiaC5qZ4fuRAYHF58dVJXaQ==", null, false, "https://picsum.photos/seed/user32/200/300", null, new DateTime(2024, 8, 26, 8, 2, 41, 232, DateTimeKind.Utc).AddTicks(2972), null, "RYZH37KPG6EEDGSYWW37NETRG56JM7KG", false, "Company32" },
                    { 2033, "Somme about text for something bla bla bla", 0, "Koroglu Rahimov 70", "Baku", "Company Name33", "5f2bbf4c-1e2f-457a-bfbf-5fe8f8d296df", new DateTime(2024, 8, 26, 8, 2, 41, 232, DateTimeKind.Utc).AddTicks(2988), new DateTime(2000, 2, 2, 0, 0, 0, 0, DateTimeKind.Unspecified), 1, "Company33@example.com", true, "CompanyFirstName33", false, new DateTime(2024, 8, 26, 8, 2, 41, 232, DateTimeKind.Utc).AddTicks(2989), "CompanyLastName33", 1, false, null, "COMPANY33@EXAMPLE.COM", "COMPANY33", "AQAAAAIAAYagAAAAEK3JbxnMOU+exC6cOxQLvXvHG6Xt/a7qhEXNftH7DTJLiaC5qZ4fuRAYHF58dVJXaQ==", null, false, "https://picsum.photos/seed/user33/200/300", null, new DateTime(2024, 8, 26, 8, 2, 41, 232, DateTimeKind.Utc).AddTicks(2985), null, "RYZH37KPG6EEDGSYWW37NETRG56JM7KG", false, "Company33" },
                    { 2034, "Somme about text for something bla bla bla", 0, "Koroglu Rahimov 70", "Baku", "Company Name34", "e86a3f2e-2604-4f6b-aaa8-9db01c0ff762", new DateTime(2024, 8, 26, 8, 2, 41, 232, DateTimeKind.Utc).AddTicks(3003), new DateTime(2000, 2, 3, 0, 0, 0, 0, DateTimeKind.Unspecified), 1, "Company34@example.com", true, "CompanyFirstName34", false, new DateTime(2024, 8, 26, 8, 2, 41, 232, DateTimeKind.Utc).AddTicks(3003), "CompanyLastName34", 1, false, null, "COMPANY34@EXAMPLE.COM", "COMPANY34", "AQAAAAIAAYagAAAAEK3JbxnMOU+exC6cOxQLvXvHG6Xt/a7qhEXNftH7DTJLiaC5qZ4fuRAYHF58dVJXaQ==", null, false, "https://picsum.photos/seed/user34/200/300", null, new DateTime(2024, 8, 26, 8, 2, 41, 232, DateTimeKind.Utc).AddTicks(2999), null, "RYZH37KPG6EEDGSYWW37NETRG56JM7KG", false, "Company34" },
                    { 2035, "Somme about text for something bla bla bla", 0, "Koroglu Rahimov 70", "Baku", "Company Name35", "19d91566-833a-406d-8dd9-e241bfdc6204", new DateTime(2024, 8, 26, 8, 2, 41, 232, DateTimeKind.Utc).AddTicks(3018), new DateTime(2000, 2, 4, 0, 0, 0, 0, DateTimeKind.Unspecified), 1, "Company35@example.com", true, "CompanyFirstName35", false, new DateTime(2024, 8, 26, 8, 2, 41, 232, DateTimeKind.Utc).AddTicks(3019), "CompanyLastName35", 1, false, null, "COMPANY35@EXAMPLE.COM", "COMPANY35", "AQAAAAIAAYagAAAAEK3JbxnMOU+exC6cOxQLvXvHG6Xt/a7qhEXNftH7DTJLiaC5qZ4fuRAYHF58dVJXaQ==", null, false, "https://picsum.photos/seed/user35/200/300", null, new DateTime(2024, 8, 26, 8, 2, 41, 232, DateTimeKind.Utc).AddTicks(3012), null, "RYZH37KPG6EEDGSYWW37NETRG56JM7KG", false, "Company35" },
                    { 2036, "Somme about text for something bla bla bla", 0, "Koroglu Rahimov 70", "Baku", "Company Name36", "550b374a-95bb-4fc6-bbd9-0a889c1d003e", new DateTime(2024, 8, 26, 8, 2, 41, 232, DateTimeKind.Utc).AddTicks(3031), new DateTime(2000, 2, 5, 0, 0, 0, 0, DateTimeKind.Unspecified), 1, "Company36@example.com", true, "CompanyFirstName36", false, new DateTime(2024, 8, 26, 8, 2, 41, 232, DateTimeKind.Utc).AddTicks(3031), "CompanyLastName36", 1, false, null, "COMPANY36@EXAMPLE.COM", "COMPANY36", "AQAAAAIAAYagAAAAEK3JbxnMOU+exC6cOxQLvXvHG6Xt/a7qhEXNftH7DTJLiaC5qZ4fuRAYHF58dVJXaQ==", null, false, "https://picsum.photos/seed/user36/200/300", null, new DateTime(2024, 8, 26, 8, 2, 41, 232, DateTimeKind.Utc).AddTicks(3028), null, "RYZH37KPG6EEDGSYWW37NETRG56JM7KG", false, "Company36" },
                    { 2037, "Somme about text for something bla bla bla", 0, "Koroglu Rahimov 70", "Baku", "Company Name37", "de6a6dfb-76f3-4dbe-9d5a-fb84ff3453d3", new DateTime(2024, 8, 26, 8, 2, 41, 232, DateTimeKind.Utc).AddTicks(3081), new DateTime(2000, 2, 6, 0, 0, 0, 0, DateTimeKind.Unspecified), 1, "Company37@example.com", true, "CompanyFirstName37", false, new DateTime(2024, 8, 26, 8, 2, 41, 232, DateTimeKind.Utc).AddTicks(3082), "CompanyLastName37", 1, false, null, "COMPANY37@EXAMPLE.COM", "COMPANY37", "AQAAAAIAAYagAAAAEK3JbxnMOU+exC6cOxQLvXvHG6Xt/a7qhEXNftH7DTJLiaC5qZ4fuRAYHF58dVJXaQ==", null, false, "https://picsum.photos/seed/user37/200/300", null, new DateTime(2024, 8, 26, 8, 2, 41, 232, DateTimeKind.Utc).AddTicks(3078), null, "RYZH37KPG6EEDGSYWW37NETRG56JM7KG", false, "Company37" },
                    { 2038, "Somme about text for something bla bla bla", 0, "Koroglu Rahimov 70", "Baku", "Company Name38", "2c58d7fa-3f19-4c76-83d9-d2e23f2fe427", new DateTime(2024, 8, 26, 8, 2, 41, 232, DateTimeKind.Utc).AddTicks(3094), new DateTime(2000, 2, 7, 0, 0, 0, 0, DateTimeKind.Unspecified), 1, "Company38@example.com", true, "CompanyFirstName38", false, new DateTime(2024, 8, 26, 8, 2, 41, 232, DateTimeKind.Utc).AddTicks(3094), "CompanyLastName38", 1, false, null, "COMPANY38@EXAMPLE.COM", "COMPANY38", "AQAAAAIAAYagAAAAEK3JbxnMOU+exC6cOxQLvXvHG6Xt/a7qhEXNftH7DTJLiaC5qZ4fuRAYHF58dVJXaQ==", null, false, "https://picsum.photos/seed/user38/200/300", null, new DateTime(2024, 8, 26, 8, 2, 41, 232, DateTimeKind.Utc).AddTicks(3091), null, "RYZH37KPG6EEDGSYWW37NETRG56JM7KG", false, "Company38" },
                    { 2039, "Somme about text for something bla bla bla", 0, "Koroglu Rahimov 70", "Baku", "Company Name39", "0b243900-cce9-43e3-abae-bd91cf207538", new DateTime(2024, 8, 26, 8, 2, 41, 232, DateTimeKind.Utc).AddTicks(3107), new DateTime(2000, 2, 8, 0, 0, 0, 0, DateTimeKind.Unspecified), 1, "Company39@example.com", true, "CompanyFirstName39", false, new DateTime(2024, 8, 26, 8, 2, 41, 232, DateTimeKind.Utc).AddTicks(3107), "CompanyLastName39", 1, false, null, "COMPANY39@EXAMPLE.COM", "COMPANY39", "AQAAAAIAAYagAAAAEK3JbxnMOU+exC6cOxQLvXvHG6Xt/a7qhEXNftH7DTJLiaC5qZ4fuRAYHF58dVJXaQ==", null, false, "https://picsum.photos/seed/user39/200/300", null, new DateTime(2024, 8, 26, 8, 2, 41, 232, DateTimeKind.Utc).AddTicks(3104), null, "RYZH37KPG6EEDGSYWW37NETRG56JM7KG", false, "Company39" },
                    { 2040, "Somme about text for something bla bla bla", 0, "Koroglu Rahimov 70", "Baku", "Company Name40", "8cac7d98-a39a-45c6-bc0d-9510a108ea90", new DateTime(2024, 8, 26, 8, 2, 41, 232, DateTimeKind.Utc).AddTicks(3119), new DateTime(2000, 2, 9, 0, 0, 0, 0, DateTimeKind.Unspecified), 1, "Company40@example.com", true, "CompanyFirstName40", false, new DateTime(2024, 8, 26, 8, 2, 41, 232, DateTimeKind.Utc).AddTicks(3120), "CompanyLastName40", 1, false, null, "COMPANY40@EXAMPLE.COM", "COMPANY40", "AQAAAAIAAYagAAAAEK3JbxnMOU+exC6cOxQLvXvHG6Xt/a7qhEXNftH7DTJLiaC5qZ4fuRAYHF58dVJXaQ==", null, false, "https://picsum.photos/seed/user40/200/300", null, new DateTime(2024, 8, 26, 8, 2, 41, 232, DateTimeKind.Utc).AddTicks(3116), null, "RYZH37KPG6EEDGSYWW37NETRG56JM7KG", false, "Company40" },
                    { 2041, "Somme about text for something bla bla bla", 0, "Koroglu Rahimov 70", "Baku", null, "ae57dfec-7bf2-4c45-9772-6c1ea7d7f210", new DateTime(2024, 8, 26, 8, 2, 41, 232, DateTimeKind.Utc).AddTicks(3134), new DateTime(2000, 2, 10, 0, 0, 0, 0, DateTimeKind.Unspecified), 1, "Vet41@example.com", true, "VetFirstName41", false, new DateTime(2024, 8, 26, 8, 2, 41, 232, DateTimeKind.Utc).AddTicks(3134), "VetLastName41", 1, false, null, "VET41@EXAMPLE.COM", "VET41", "AQAAAAIAAYagAAAAEK3JbxnMOU+exC6cOxQLvXvHG6Xt/a7qhEXNftH7DTJLiaC5qZ4fuRAYHF58dVJXaQ==", null, false, "https://picsum.photos/seed/user41/200/300", null, new DateTime(2024, 8, 26, 8, 2, 41, 232, DateTimeKind.Utc).AddTicks(3130), null, "RYZH37KPG6EEDGSYWW37NETRG56JM7KG", false, "Vet41" },
                    { 2042, "Somme about text for something bla bla bla", 0, "Koroglu Rahimov 70", "Baku", null, "dd702af2-73c3-4e8d-972e-28bc1600f002", new DateTime(2024, 8, 26, 8, 2, 41, 232, DateTimeKind.Utc).AddTicks(3150), new DateTime(2000, 2, 11, 0, 0, 0, 0, DateTimeKind.Unspecified), 1, "Vet42@example.com", true, "VetFirstName42", false, new DateTime(2024, 8, 26, 8, 2, 41, 232, DateTimeKind.Utc).AddTicks(3151), "VetLastName42", 1, false, null, "VET42@EXAMPLE.COM", "VET42", "AQAAAAIAAYagAAAAEK3JbxnMOU+exC6cOxQLvXvHG6Xt/a7qhEXNftH7DTJLiaC5qZ4fuRAYHF58dVJXaQ==", null, false, "https://picsum.photos/seed/user42/200/300", null, new DateTime(2024, 8, 26, 8, 2, 41, 232, DateTimeKind.Utc).AddTicks(3147), null, "RYZH37KPG6EEDGSYWW37NETRG56JM7KG", false, "Vet42" },
                    { 2043, "Somme about text for something bla bla bla", 0, "Koroglu Rahimov 70", "Baku", null, "a89e86d8-1e53-45d0-afc8-08a103d6b04d", new DateTime(2024, 8, 26, 8, 2, 41, 232, DateTimeKind.Utc).AddTicks(3165), new DateTime(2000, 2, 12, 0, 0, 0, 0, DateTimeKind.Unspecified), 1, "Vet43@example.com", true, "VetFirstName43", false, new DateTime(2024, 8, 26, 8, 2, 41, 232, DateTimeKind.Utc).AddTicks(3165), "VetLastName43", 1, false, null, "VET43@EXAMPLE.COM", "VET43", "AQAAAAIAAYagAAAAEK3JbxnMOU+exC6cOxQLvXvHG6Xt/a7qhEXNftH7DTJLiaC5qZ4fuRAYHF58dVJXaQ==", null, false, "https://picsum.photos/seed/user43/200/300", null, new DateTime(2024, 8, 26, 8, 2, 41, 232, DateTimeKind.Utc).AddTicks(3159), null, "RYZH37KPG6EEDGSYWW37NETRG56JM7KG", false, "Vet43" },
                    { 2044, "Somme about text for something bla bla bla", 0, "Koroglu Rahimov 70", "Baku", null, "cea17281-1fec-465b-b7b5-69218cc00566", new DateTime(2024, 8, 26, 8, 2, 41, 232, DateTimeKind.Utc).AddTicks(3176), new DateTime(2000, 2, 13, 0, 0, 0, 0, DateTimeKind.Unspecified), 1, "Vet44@example.com", true, "VetFirstName44", false, new DateTime(2024, 8, 26, 8, 2, 41, 232, DateTimeKind.Utc).AddTicks(3177), "VetLastName44", 1, false, null, "VET44@EXAMPLE.COM", "VET44", "AQAAAAIAAYagAAAAEK3JbxnMOU+exC6cOxQLvXvHG6Xt/a7qhEXNftH7DTJLiaC5qZ4fuRAYHF58dVJXaQ==", null, false, "https://picsum.photos/seed/user44/200/300", null, new DateTime(2024, 8, 26, 8, 2, 41, 232, DateTimeKind.Utc).AddTicks(3173), null, "RYZH37KPG6EEDGSYWW37NETRG56JM7KG", false, "Vet44" },
                    { 2045, "Somme about text for something bla bla bla", 0, "Koroglu Rahimov 70", "Baku", null, "114840a7-9697-4595-9d16-0c0ef3828caf", new DateTime(2024, 8, 26, 8, 2, 41, 232, DateTimeKind.Utc).AddTicks(3188), new DateTime(2000, 2, 14, 0, 0, 0, 0, DateTimeKind.Unspecified), 1, "Vet45@example.com", true, "VetFirstName45", false, new DateTime(2024, 8, 26, 8, 2, 41, 232, DateTimeKind.Utc).AddTicks(3189), "VetLastName45", 1, false, null, "VET45@EXAMPLE.COM", "VET45", "AQAAAAIAAYagAAAAEK3JbxnMOU+exC6cOxQLvXvHG6Xt/a7qhEXNftH7DTJLiaC5qZ4fuRAYHF58dVJXaQ==", null, false, "https://picsum.photos/seed/user45/200/300", null, new DateTime(2024, 8, 26, 8, 2, 41, 232, DateTimeKind.Utc).AddTicks(3185), null, "RYZH37KPG6EEDGSYWW37NETRG56JM7KG", false, "Vet45" },
                    { 2046, "Somme about text for something bla bla bla", 0, "Koroglu Rahimov 70", "Baku", null, "6302f3d4-378c-4e07-90a2-e199131f406f", new DateTime(2024, 8, 26, 8, 2, 41, 232, DateTimeKind.Utc).AddTicks(3236), new DateTime(2000, 2, 15, 0, 0, 0, 0, DateTimeKind.Unspecified), 1, "Vet46@example.com", true, "VetFirstName46", false, new DateTime(2024, 8, 26, 8, 2, 41, 232, DateTimeKind.Utc).AddTicks(3236), "VetLastName46", 1, false, null, "VET46@EXAMPLE.COM", "VET46", "AQAAAAIAAYagAAAAEK3JbxnMOU+exC6cOxQLvXvHG6Xt/a7qhEXNftH7DTJLiaC5qZ4fuRAYHF58dVJXaQ==", null, false, "https://picsum.photos/seed/user46/200/300", null, new DateTime(2024, 8, 26, 8, 2, 41, 232, DateTimeKind.Utc).AddTicks(3232), null, "RYZH37KPG6EEDGSYWW37NETRG56JM7KG", false, "Vet46" },
                    { 2047, "Somme about text for something bla bla bla", 0, "Koroglu Rahimov 70", "Baku", null, "e3746cad-81f6-4585-a4a4-f64001554d27", new DateTime(2024, 8, 26, 8, 2, 41, 232, DateTimeKind.Utc).AddTicks(3247), new DateTime(2000, 2, 16, 0, 0, 0, 0, DateTimeKind.Unspecified), 1, "Vet47@example.com", true, "VetFirstName47", false, new DateTime(2024, 8, 26, 8, 2, 41, 232, DateTimeKind.Utc).AddTicks(3248), "VetLastName47", 1, false, null, "VET47@EXAMPLE.COM", "VET47", "AQAAAAIAAYagAAAAEK3JbxnMOU+exC6cOxQLvXvHG6Xt/a7qhEXNftH7DTJLiaC5qZ4fuRAYHF58dVJXaQ==", null, false, "https://picsum.photos/seed/user47/200/300", null, new DateTime(2024, 8, 26, 8, 2, 41, 232, DateTimeKind.Utc).AddTicks(3245), null, "RYZH37KPG6EEDGSYWW37NETRG56JM7KG", false, "Vet47" },
                    { 2048, "Somme about text for something bla bla bla", 0, "Koroglu Rahimov 70", "Baku", null, "38e7f195-12c8-4690-8b79-d878ff660c68", new DateTime(2024, 8, 26, 8, 2, 41, 232, DateTimeKind.Utc).AddTicks(3260), new DateTime(2000, 2, 17, 0, 0, 0, 0, DateTimeKind.Unspecified), 1, "Vet48@example.com", true, "VetFirstName48", false, new DateTime(2024, 8, 26, 8, 2, 41, 232, DateTimeKind.Utc).AddTicks(3260), "VetLastName48", 1, false, null, "VET48@EXAMPLE.COM", "VET48", "AQAAAAIAAYagAAAAEK3JbxnMOU+exC6cOxQLvXvHG6Xt/a7qhEXNftH7DTJLiaC5qZ4fuRAYHF58dVJXaQ==", null, false, "https://picsum.photos/seed/user48/200/300", null, new DateTime(2024, 8, 26, 8, 2, 41, 232, DateTimeKind.Utc).AddTicks(3256), null, "RYZH37KPG6EEDGSYWW37NETRG56JM7KG", false, "Vet48" },
                    { 2049, "Somme about text for something bla bla bla", 0, "Koroglu Rahimov 70", "Baku", null, "6b7c15de-37e8-49d8-91dd-80f126250cef", new DateTime(2024, 8, 26, 8, 2, 41, 232, DateTimeKind.Utc).AddTicks(3271), new DateTime(2000, 2, 18, 0, 0, 0, 0, DateTimeKind.Unspecified), 1, "Vet49@example.com", true, "VetFirstName49", false, new DateTime(2024, 8, 26, 8, 2, 41, 232, DateTimeKind.Utc).AddTicks(3271), "VetLastName49", 1, false, null, "VET49@EXAMPLE.COM", "VET49", "AQAAAAIAAYagAAAAEK3JbxnMOU+exC6cOxQLvXvHG6Xt/a7qhEXNftH7DTJLiaC5qZ4fuRAYHF58dVJXaQ==", null, false, "https://picsum.photos/seed/user49/200/300", null, new DateTime(2024, 8, 26, 8, 2, 41, 232, DateTimeKind.Utc).AddTicks(3268), null, "RYZH37KPG6EEDGSYWW37NETRG56JM7KG", false, "Vet49" },
                    { 2050, "Somme about text for something bla bla bla", 0, "Koroglu Rahimov 70", "Baku", null, "42a043e2-5a3e-44af-8bdf-4d075919436a", new DateTime(2024, 8, 26, 8, 2, 41, 232, DateTimeKind.Utc).AddTicks(3282), new DateTime(2000, 2, 19, 0, 0, 0, 0, DateTimeKind.Unspecified), 1, "Vet50@example.com", true, "VetFirstName50", false, new DateTime(2024, 8, 26, 8, 2, 41, 232, DateTimeKind.Utc).AddTicks(3283), "VetLastName50", 1, false, null, "VET50@EXAMPLE.COM", "VET50", "AQAAAAIAAYagAAAAEK3JbxnMOU+exC6cOxQLvXvHG6Xt/a7qhEXNftH7DTJLiaC5qZ4fuRAYHF58dVJXaQ==", null, false, "https://picsum.photos/seed/user50/200/300", null, new DateTime(2024, 8, 26, 8, 2, 41, 232, DateTimeKind.Utc).AddTicks(3279), null, "RYZH37KPG6EEDGSYWW37NETRG56JM7KG", false, "Vet50" },
                    { 2051, "Somme about text for something bla bla bla", 0, "Koroglu Rahimov 70", "Baku", null, "8227f51a-4ddf-4dba-bfd2-482e80b43f8b", new DateTime(2024, 8, 26, 8, 2, 41, 232, DateTimeKind.Utc).AddTicks(3296), new DateTime(2000, 2, 20, 0, 0, 0, 0, DateTimeKind.Unspecified), 1, "Vet51@example.com", true, "VetFirstName51", false, new DateTime(2024, 8, 26, 8, 2, 41, 232, DateTimeKind.Utc).AddTicks(3297), "VetLastName51", 1, false, null, "VET51@EXAMPLE.COM", "VET51", "AQAAAAIAAYagAAAAEK3JbxnMOU+exC6cOxQLvXvHG6Xt/a7qhEXNftH7DTJLiaC5qZ4fuRAYHF58dVJXaQ==", null, false, "https://picsum.photos/seed/user51/200/300", null, new DateTime(2024, 8, 26, 8, 2, 41, 232, DateTimeKind.Utc).AddTicks(3290), null, "RYZH37KPG6EEDGSYWW37NETRG56JM7KG", false, "Vet51" },
                    { 2052, "Somme about text for something bla bla bla", 0, "Koroglu Rahimov 70", "Baku", null, "74229607-ed1f-44dc-97fe-b53bd73da51d", new DateTime(2024, 8, 26, 8, 2, 41, 232, DateTimeKind.Utc).AddTicks(3308), new DateTime(2000, 2, 21, 0, 0, 0, 0, DateTimeKind.Unspecified), 1, "Vet52@example.com", true, "VetFirstName52", false, new DateTime(2024, 8, 26, 8, 2, 41, 232, DateTimeKind.Utc).AddTicks(3308), "VetLastName52", 1, false, null, "VET52@EXAMPLE.COM", "VET52", "AQAAAAIAAYagAAAAEK3JbxnMOU+exC6cOxQLvXvHG6Xt/a7qhEXNftH7DTJLiaC5qZ4fuRAYHF58dVJXaQ==", null, false, "https://picsum.photos/seed/user52/200/300", null, new DateTime(2024, 8, 26, 8, 2, 41, 232, DateTimeKind.Utc).AddTicks(3304), null, "RYZH37KPG6EEDGSYWW37NETRG56JM7KG", false, "Vet52" },
                    { 2053, "Somme about text for something bla bla bla", 0, "Koroglu Rahimov 70", "Baku", null, "4c03f496-6af1-42f2-a3c4-c7af88612fab", new DateTime(2024, 8, 26, 8, 2, 41, 232, DateTimeKind.Utc).AddTicks(3319), new DateTime(2000, 2, 22, 0, 0, 0, 0, DateTimeKind.Unspecified), 1, "Vet53@example.com", true, "VetFirstName53", false, new DateTime(2024, 8, 26, 8, 2, 41, 232, DateTimeKind.Utc).AddTicks(3319), "VetLastName53", 1, false, null, "VET53@EXAMPLE.COM", "VET53", "AQAAAAIAAYagAAAAEK3JbxnMOU+exC6cOxQLvXvHG6Xt/a7qhEXNftH7DTJLiaC5qZ4fuRAYHF58dVJXaQ==", null, false, "https://picsum.photos/seed/user53/200/300", null, new DateTime(2024, 8, 26, 8, 2, 41, 232, DateTimeKind.Utc).AddTicks(3316), null, "RYZH37KPG6EEDGSYWW37NETRG56JM7KG", false, "Vet53" },
                    { 2054, "Somme about text for something bla bla bla", 0, "Koroglu Rahimov 70", "Baku", null, "04767bc4-0f5b-40e2-a64a-3a3b9b1f5115", new DateTime(2024, 8, 26, 8, 2, 41, 232, DateTimeKind.Utc).AddTicks(3330), new DateTime(2000, 2, 23, 0, 0, 0, 0, DateTimeKind.Unspecified), 1, "Vet54@example.com", true, "VetFirstName54", false, new DateTime(2024, 8, 26, 8, 2, 41, 232, DateTimeKind.Utc).AddTicks(3331), "VetLastName54", 1, false, null, "VET54@EXAMPLE.COM", "VET54", "AQAAAAIAAYagAAAAEK3JbxnMOU+exC6cOxQLvXvHG6Xt/a7qhEXNftH7DTJLiaC5qZ4fuRAYHF58dVJXaQ==", null, false, "https://picsum.photos/seed/user54/200/300", null, new DateTime(2024, 8, 26, 8, 2, 41, 232, DateTimeKind.Utc).AddTicks(3327), null, "RYZH37KPG6EEDGSYWW37NETRG56JM7KG", false, "Vet54" },
                    { 2055, "Somme about text for something bla bla bla", 0, "Koroglu Rahimov 70", "Baku", null, "161210e1-73d7-4696-8be4-9a33733c2365", new DateTime(2024, 8, 26, 8, 2, 41, 232, DateTimeKind.Utc).AddTicks(3341), new DateTime(2000, 2, 24, 0, 0, 0, 0, DateTimeKind.Unspecified), 1, "Vet55@example.com", true, "VetFirstName55", false, new DateTime(2024, 8, 26, 8, 2, 41, 232, DateTimeKind.Utc).AddTicks(3342), "VetLastName55", 1, false, null, "VET55@EXAMPLE.COM", "VET55", "AQAAAAIAAYagAAAAEK3JbxnMOU+exC6cOxQLvXvHG6Xt/a7qhEXNftH7DTJLiaC5qZ4fuRAYHF58dVJXaQ==", null, false, "https://picsum.photos/seed/user55/200/300", null, new DateTime(2024, 8, 26, 8, 2, 41, 232, DateTimeKind.Utc).AddTicks(3338), null, "RYZH37KPG6EEDGSYWW37NETRG56JM7KG", false, "Vet55" },
                    { 2056, "Somme about text for something bla bla bla", 0, "Koroglu Rahimov 70", "Baku", null, "cd264ea6-c31e-4948-a1ea-dce62969e335", new DateTime(2024, 8, 26, 8, 2, 41, 232, DateTimeKind.Utc).AddTicks(3388), new DateTime(2000, 2, 25, 0, 0, 0, 0, DateTimeKind.Unspecified), 1, "Vet56@example.com", true, "VetFirstName56", false, new DateTime(2024, 8, 26, 8, 2, 41, 232, DateTimeKind.Utc).AddTicks(3389), "VetLastName56", 1, false, null, "VET56@EXAMPLE.COM", "VET56", "AQAAAAIAAYagAAAAEK3JbxnMOU+exC6cOxQLvXvHG6Xt/a7qhEXNftH7DTJLiaC5qZ4fuRAYHF58dVJXaQ==", null, false, "https://picsum.photos/seed/user56/200/300", null, new DateTime(2024, 8, 26, 8, 2, 41, 232, DateTimeKind.Utc).AddTicks(3385), null, "RYZH37KPG6EEDGSYWW37NETRG56JM7KG", false, "Vet56" },
                    { 2057, "Somme about text for something bla bla bla", 0, "Koroglu Rahimov 70", "Baku", null, "bfdb1f9c-c3cd-4a9a-ba0a-da2806cea88d", new DateTime(2024, 8, 26, 8, 2, 41, 232, DateTimeKind.Utc).AddTicks(3401), new DateTime(2000, 2, 26, 0, 0, 0, 0, DateTimeKind.Unspecified), 1, "Vet57@example.com", true, "VetFirstName57", false, new DateTime(2024, 8, 26, 8, 2, 41, 232, DateTimeKind.Utc).AddTicks(3401), "VetLastName57", 1, false, null, "VET57@EXAMPLE.COM", "VET57", "AQAAAAIAAYagAAAAEK3JbxnMOU+exC6cOxQLvXvHG6Xt/a7qhEXNftH7DTJLiaC5qZ4fuRAYHF58dVJXaQ==", null, false, "https://picsum.photos/seed/user57/200/300", null, new DateTime(2024, 8, 26, 8, 2, 41, 232, DateTimeKind.Utc).AddTicks(3397), null, "RYZH37KPG6EEDGSYWW37NETRG56JM7KG", false, "Vet57" },
                    { 2058, "Somme about text for something bla bla bla", 0, "Koroglu Rahimov 70", "Baku", null, "7181cc92-2898-4d65-b40b-fbde5c68d471", new DateTime(2024, 8, 26, 8, 2, 41, 232, DateTimeKind.Utc).AddTicks(3412), new DateTime(2000, 2, 27, 0, 0, 0, 0, DateTimeKind.Unspecified), 1, "Vet58@example.com", true, "VetFirstName58", false, new DateTime(2024, 8, 26, 8, 2, 41, 232, DateTimeKind.Utc).AddTicks(3412), "VetLastName58", 1, false, null, "VET58@EXAMPLE.COM", "VET58", "AQAAAAIAAYagAAAAEK3JbxnMOU+exC6cOxQLvXvHG6Xt/a7qhEXNftH7DTJLiaC5qZ4fuRAYHF58dVJXaQ==", null, false, "https://picsum.photos/seed/user58/200/300", null, new DateTime(2024, 8, 26, 8, 2, 41, 232, DateTimeKind.Utc).AddTicks(3409), null, "RYZH37KPG6EEDGSYWW37NETRG56JM7KG", false, "Vet58" },
                    { 2059, "Somme about text for something bla bla bla", 0, "Koroglu Rahimov 70", "Baku", null, "1c112ec5-5a6d-4faf-97e5-e35602dc7313", new DateTime(2024, 8, 26, 8, 2, 41, 232, DateTimeKind.Utc).AddTicks(3426), new DateTime(2000, 2, 28, 0, 0, 0, 0, DateTimeKind.Unspecified), 1, "Vet59@example.com", true, "VetFirstName59", false, new DateTime(2024, 8, 26, 8, 2, 41, 232, DateTimeKind.Utc).AddTicks(3427), "VetLastName59", 1, false, null, "VET59@EXAMPLE.COM", "VET59", "AQAAAAIAAYagAAAAEK3JbxnMOU+exC6cOxQLvXvHG6Xt/a7qhEXNftH7DTJLiaC5qZ4fuRAYHF58dVJXaQ==", null, false, "https://picsum.photos/seed/user59/200/300", null, new DateTime(2024, 8, 26, 8, 2, 41, 232, DateTimeKind.Utc).AddTicks(3420), null, "RYZH37KPG6EEDGSYWW37NETRG56JM7KG", false, "Vet59" },
                    { 2060, "Somme about text for something bla bla bla", 0, "Koroglu Rahimov 70", "Baku", null, "ffcdf433-68d6-40f7-a720-9bfbb042ebec", new DateTime(2024, 8, 26, 8, 2, 41, 232, DateTimeKind.Utc).AddTicks(3437), new DateTime(2000, 2, 29, 0, 0, 0, 0, DateTimeKind.Unspecified), 1, "Vet60@example.com", true, "VetFirstName60", false, new DateTime(2024, 8, 26, 8, 2, 41, 232, DateTimeKind.Utc).AddTicks(3438), "VetLastName60", 1, false, null, "VET60@EXAMPLE.COM", "VET60", "AQAAAAIAAYagAAAAEK3JbxnMOU+exC6cOxQLvXvHG6Xt/a7qhEXNftH7DTJLiaC5qZ4fuRAYHF58dVJXaQ==", null, false, "https://picsum.photos/seed/user60/200/300", null, new DateTime(2024, 8, 26, 8, 2, 41, 232, DateTimeKind.Utc).AddTicks(3434), null, "RYZH37KPG6EEDGSYWW37NETRG56JM7KG", false, "Vet60" }
                });

            migrationBuilder.InsertData(
                table: "PetTypes",
                columns: new[] { "Id", "CreatedTime", "IsDeleted", "LastUpdatedTime", "TypeName" },
                values: new object[,]
                {
                    { 1, new DateTime(2024, 8, 26, 12, 2, 41, 221, DateTimeKind.Local).AddTicks(5418), false, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "Dogs" },
                    { 2, new DateTime(2024, 8, 26, 12, 2, 41, 221, DateTimeKind.Local).AddTicks(5423), false, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "Cats" },
                    { 3, new DateTime(2024, 8, 26, 12, 2, 41, 221, DateTimeKind.Local).AddTicks(5425), false, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "Birds" },
                    { 4, new DateTime(2024, 8, 26, 12, 2, 41, 221, DateTimeKind.Local).AddTicks(5426), false, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "Reptiles" },
                    { 5, new DateTime(2024, 8, 26, 12, 2, 41, 221, DateTimeKind.Local).AddTicks(5428), false, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "Rodents" },
                    { 6, new DateTime(2024, 8, 26, 12, 2, 41, 221, DateTimeKind.Local).AddTicks(5429), false, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "Fish" },
                    { 7, new DateTime(2024, 8, 26, 12, 2, 41, 221, DateTimeKind.Local).AddTicks(5430), false, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "Farm Animals" },
                    { 8, new DateTime(2024, 8, 26, 12, 2, 41, 221, DateTimeKind.Local).AddTicks(5431), false, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "Exotic Pets" }
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
                    { 2, 2021 },
                    { 2, 2022 },
                    { 2, 2023 },
                    { 2, 2024 },
                    { 2, 2025 },
                    { 2, 2026 },
                    { 2, 2027 },
                    { 2, 2028 },
                    { 2, 2029 },
                    { 2, 2030 },
                    { 2, 2031 },
                    { 2, 2032 },
                    { 2, 2033 },
                    { 2, 2034 },
                    { 2, 2035 },
                    { 2, 2036 },
                    { 2, 2037 },
                    { 2, 2038 },
                    { 2, 2039 },
                    { 3, 2040 },
                    { 3, 2041 },
                    { 3, 2042 },
                    { 3, 2043 },
                    { 3, 2044 },
                    { 3, 2045 },
                    { 3, 2046 },
                    { 3, 2047 },
                    { 3, 2048 },
                    { 3, 2049 },
                    { 3, 2050 },
                    { 3, 2051 },
                    { 3, 2052 },
                    { 3, 2053 },
                    { 3, 2054 },
                    { 3, 2055 },
                    { 3, 2056 },
                    { 3, 2057 },
                    { 3, 2058 },
                    { 3, 2059 },
                    { 3, 2060 }
                });

            migrationBuilder.InsertData(
                table: "Breeds",
                columns: new[] { "Id", "BreedName", "CreatedTime", "IsDeleted", "LastUpdatedTime", "PetTypeId" },
                values: new object[,]
                {
                    { 1, "Labrador Retriever", new DateTime(2024, 8, 26, 12, 2, 41, 221, DateTimeKind.Local).AddTicks(8275), false, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 1 },
                    { 2, "German Shepherd", new DateTime(2024, 8, 26, 12, 2, 41, 221, DateTimeKind.Local).AddTicks(8284), false, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 1 },
                    { 3, "Golden Retriever", new DateTime(2024, 8, 26, 12, 2, 41, 221, DateTimeKind.Local).AddTicks(8286), false, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 1 },
                    { 4, "French Bulldog", new DateTime(2024, 8, 26, 12, 2, 41, 221, DateTimeKind.Local).AddTicks(8287), false, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 1 },
                    { 5, "Bulldog", new DateTime(2024, 8, 26, 12, 2, 41, 221, DateTimeKind.Local).AddTicks(8289), false, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 1 },
                    { 6, "Beagle", new DateTime(2024, 8, 26, 12, 2, 41, 221, DateTimeKind.Local).AddTicks(8290), false, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 1 },
                    { 7, "Poodle", new DateTime(2024, 8, 26, 12, 2, 41, 221, DateTimeKind.Local).AddTicks(8292), false, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 1 },
                    { 8, "Rottweiler", new DateTime(2024, 8, 26, 12, 2, 41, 221, DateTimeKind.Local).AddTicks(8293), false, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 1 },
                    { 9, "Yorkshire Terrier", new DateTime(2024, 8, 26, 12, 2, 41, 221, DateTimeKind.Local).AddTicks(8295), false, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 1 },
                    { 10, "Boxer", new DateTime(2024, 8, 26, 12, 2, 41, 221, DateTimeKind.Local).AddTicks(8296), false, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 1 },
                    { 11, "Dachshund", new DateTime(2024, 8, 26, 12, 2, 41, 221, DateTimeKind.Local).AddTicks(8298), false, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 1 },
                    { 12, "Pembroke Welsh Corgi", new DateTime(2024, 8, 26, 12, 2, 41, 221, DateTimeKind.Local).AddTicks(8299), false, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 1 },
                    { 13, "Doberman Pinscher", new DateTime(2024, 8, 26, 12, 2, 41, 221, DateTimeKind.Local).AddTicks(8438), false, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 1 },
                    { 14, "Shih Tzu", new DateTime(2024, 8, 26, 12, 2, 41, 221, DateTimeKind.Local).AddTicks(8440), false, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 1 },
                    { 15, "Siberian Husky", new DateTime(2024, 8, 26, 12, 2, 41, 221, DateTimeKind.Local).AddTicks(8441), false, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 1 },
                    { 16, "Great Dane", new DateTime(2024, 8, 26, 12, 2, 41, 221, DateTimeKind.Local).AddTicks(8443), false, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 1 },
                    { 17, "Border Collie", new DateTime(2024, 8, 26, 12, 2, 41, 221, DateTimeKind.Local).AddTicks(8448), false, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 1 },
                    { 18, "Chihuahua", new DateTime(2024, 8, 26, 12, 2, 41, 221, DateTimeKind.Local).AddTicks(8450), false, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 1 },
                    { 19, "Boston Terrier", new DateTime(2024, 8, 26, 12, 2, 41, 221, DateTimeKind.Local).AddTicks(8451), false, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 1 },
                    { 20, "Australian Shepherd", new DateTime(2024, 8, 26, 12, 2, 41, 221, DateTimeKind.Local).AddTicks(8452), false, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 1 },
                    { 21, "Pug", new DateTime(2024, 8, 26, 12, 2, 41, 221, DateTimeKind.Local).AddTicks(8454), false, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 1 },
                    { 22, "Havanese", new DateTime(2024, 8, 26, 12, 2, 41, 221, DateTimeKind.Local).AddTicks(8455), false, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 1 },
                    { 23, "Maltese", new DateTime(2024, 8, 26, 12, 2, 41, 221, DateTimeKind.Local).AddTicks(8457), false, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 1 },
                    { 24, "Saint Bernard", new DateTime(2024, 8, 26, 12, 2, 41, 221, DateTimeKind.Local).AddTicks(8458), false, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 1 },
                    { 25, "Akita", new DateTime(2024, 8, 26, 12, 2, 41, 221, DateTimeKind.Local).AddTicks(8459), false, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 1 },
                    { 26, "Alaskan Malamute", new DateTime(2024, 8, 26, 12, 2, 41, 221, DateTimeKind.Local).AddTicks(8461), false, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 1 },
                    { 27, "Bichon Frise", new DateTime(2024, 8, 26, 12, 2, 41, 221, DateTimeKind.Local).AddTicks(8466), false, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 1 },
                    { 28, "Bull Terrier", new DateTime(2024, 8, 26, 12, 2, 41, 221, DateTimeKind.Local).AddTicks(8467), false, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 1 },
                    { 29, "Cane Corso", new DateTime(2024, 8, 26, 12, 2, 41, 221, DateTimeKind.Local).AddTicks(8469), false, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 1 },
                    { 30, "Chow Chow", new DateTime(2024, 8, 26, 12, 2, 41, 221, DateTimeKind.Local).AddTicks(8470), false, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 1 },
                    { 31, "Cocker Spaniel", new DateTime(2024, 8, 26, 12, 2, 41, 221, DateTimeKind.Local).AddTicks(8472), false, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 1 },
                    { 32, "Dogo Argentino", new DateTime(2024, 8, 26, 12, 2, 41, 221, DateTimeKind.Local).AddTicks(8473), false, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 1 },
                    { 33, "English Springer Spaniel", new DateTime(2024, 8, 26, 12, 2, 41, 221, DateTimeKind.Local).AddTicks(8474), false, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 1 },
                    { 34, "Irish Setter", new DateTime(2024, 8, 26, 12, 2, 41, 221, DateTimeKind.Local).AddTicks(8476), false, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 1 },
                    { 35, "Jack Russell Terrier", new DateTime(2024, 8, 26, 12, 2, 41, 221, DateTimeKind.Local).AddTicks(8477), false, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 1 },
                    { 36, "Lhasa Apso", new DateTime(2024, 8, 26, 12, 2, 41, 221, DateTimeKind.Local).AddTicks(8479), false, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 1 },
                    { 37, "Miniature Schnauzer", new DateTime(2024, 8, 26, 12, 2, 41, 221, DateTimeKind.Local).AddTicks(8480), false, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 1 },
                    { 38, "Neapolitan Mastiff", new DateTime(2024, 8, 26, 12, 2, 41, 221, DateTimeKind.Local).AddTicks(8482), false, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 1 },
                    { 39, "Old English Sheepdog", new DateTime(2024, 8, 26, 12, 2, 41, 221, DateTimeKind.Local).AddTicks(8483), false, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 1 },
                    { 40, "Papillon", new DateTime(2024, 8, 26, 12, 2, 41, 221, DateTimeKind.Local).AddTicks(8485), false, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 1 },
                    { 41, "Pekingese", new DateTime(2024, 8, 26, 12, 2, 41, 221, DateTimeKind.Local).AddTicks(8486), false, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 1 },
                    { 42, "Petit Basset Griffon Vendeen", new DateTime(2024, 8, 26, 12, 2, 41, 221, DateTimeKind.Local).AddTicks(8487), false, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 1 },
                    { 43, "Pomeranian", new DateTime(2024, 8, 26, 12, 2, 41, 221, DateTimeKind.Local).AddTicks(8489), false, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 1 },
                    { 44, "Portuguese Water Dog", new DateTime(2024, 8, 26, 12, 2, 41, 221, DateTimeKind.Local).AddTicks(8490), false, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 1 },
                    { 45, "Samoyed", new DateTime(2024, 8, 26, 12, 2, 41, 221, DateTimeKind.Local).AddTicks(8491), false, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 1 },
                    { 46, "Scottish Terrier", new DateTime(2024, 8, 26, 12, 2, 41, 221, DateTimeKind.Local).AddTicks(8494), false, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 1 },
                    { 47, "Shiba Inu", new DateTime(2024, 8, 26, 12, 2, 41, 221, DateTimeKind.Local).AddTicks(8496), false, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 1 },
                    { 48, "Weimaraner", new DateTime(2024, 8, 26, 12, 2, 41, 221, DateTimeKind.Local).AddTicks(8497), false, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 1 },
                    { 49, "Whippet", new DateTime(2024, 8, 26, 12, 2, 41, 221, DateTimeKind.Local).AddTicks(8498), false, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 1 },
                    { 50, "Persian", new DateTime(2024, 8, 26, 12, 2, 41, 221, DateTimeKind.Local).AddTicks(8499), false, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 2 },
                    { 51, "Maine Coon", new DateTime(2024, 8, 26, 12, 2, 41, 221, DateTimeKind.Local).AddTicks(8501), false, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 2 },
                    { 52, "Siamese", new DateTime(2024, 8, 26, 12, 2, 41, 221, DateTimeKind.Local).AddTicks(8502), false, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 2 },
                    { 53, "Ragdoll", new DateTime(2024, 8, 26, 12, 2, 41, 221, DateTimeKind.Local).AddTicks(8503), false, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 2 },
                    { 54, "British Shorthair", new DateTime(2024, 8, 26, 12, 2, 41, 221, DateTimeKind.Local).AddTicks(8507), false, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 2 },
                    { 55, "Sphynx", new DateTime(2024, 8, 26, 12, 2, 41, 221, DateTimeKind.Local).AddTicks(8508), false, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 2 },
                    { 56, "Bengal", new DateTime(2024, 8, 26, 12, 2, 41, 221, DateTimeKind.Local).AddTicks(8510), false, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 2 },
                    { 57, "Scottish Fold", new DateTime(2024, 8, 26, 12, 2, 41, 221, DateTimeKind.Local).AddTicks(8511), false, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 2 },
                    { 58, "Abyssinian", new DateTime(2024, 8, 26, 12, 2, 41, 221, DateTimeKind.Local).AddTicks(8512), false, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 2 },
                    { 59, "Burmese", new DateTime(2024, 8, 26, 12, 2, 41, 221, DateTimeKind.Local).AddTicks(8514), false, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 2 },
                    { 60, "Somali", new DateTime(2024, 8, 26, 12, 2, 41, 221, DateTimeKind.Local).AddTicks(8515), false, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 2 },
                    { 61, "Manx", new DateTime(2024, 8, 26, 12, 2, 41, 221, DateTimeKind.Local).AddTicks(8516), false, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 2 },
                    { 62, "Norwegian Forest Cat", new DateTime(2024, 8, 26, 12, 2, 41, 221, DateTimeKind.Local).AddTicks(8518), false, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 2 },
                    { 63, "Devon Rex", new DateTime(2024, 8, 26, 12, 2, 41, 221, DateTimeKind.Local).AddTicks(8519), false, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 2 },
                    { 64, "Cornish Rex", new DateTime(2024, 8, 26, 12, 2, 41, 221, DateTimeKind.Local).AddTicks(8520), false, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 2 },
                    { 65, "Russian Blue", new DateTime(2024, 8, 26, 12, 2, 41, 221, DateTimeKind.Local).AddTicks(8522), false, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 2 },
                    { 66, "Birman", new DateTime(2024, 8, 26, 12, 2, 41, 221, DateTimeKind.Local).AddTicks(8523), false, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 2 },
                    { 67, "Ocicat", new DateTime(2024, 8, 26, 12, 2, 41, 221, DateTimeKind.Local).AddTicks(8524), false, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 2 },
                    { 68, "American Shorthair", new DateTime(2024, 8, 26, 12, 2, 41, 221, DateTimeKind.Local).AddTicks(8526), false, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 2 },
                    { 69, "Turkish Angora", new DateTime(2024, 8, 26, 12, 2, 41, 221, DateTimeKind.Local).AddTicks(8527), false, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 2 },
                    { 70, "Selkirk Rex", new DateTime(2024, 8, 26, 12, 2, 41, 221, DateTimeKind.Local).AddTicks(8528), false, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 2 },
                    { 71, "Exotic Shorthair", new DateTime(2024, 8, 26, 12, 2, 41, 221, DateTimeKind.Local).AddTicks(8530), false, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 2 },
                    { 72, "LaPerm", new DateTime(2024, 8, 26, 12, 2, 41, 221, DateTimeKind.Local).AddTicks(8531), false, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 2 },
                    { 73, "Havana Brown", new DateTime(2024, 8, 26, 12, 2, 41, 221, DateTimeKind.Local).AddTicks(8532), false, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 2 },
                    { 74, "Tonkinese", new DateTime(2024, 8, 26, 12, 2, 41, 221, DateTimeKind.Local).AddTicks(8533), false, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 2 },
                    { 75, "Egyptian Mau", new DateTime(2024, 8, 26, 12, 2, 41, 221, DateTimeKind.Local).AddTicks(8538), false, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 2 },
                    { 76, "Singapura", new DateTime(2024, 8, 26, 12, 2, 41, 221, DateTimeKind.Local).AddTicks(8540), false, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 2 },
                    { 77, "Japanese Bobtail", new DateTime(2024, 8, 26, 12, 2, 41, 221, DateTimeKind.Local).AddTicks(8541), false, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 2 },
                    { 78, "American Curl", new DateTime(2024, 8, 26, 12, 2, 41, 221, DateTimeKind.Local).AddTicks(8542), false, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 2 },
                    { 79, "Parrot", new DateTime(2024, 8, 26, 12, 2, 41, 221, DateTimeKind.Local).AddTicks(8544), false, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 3 },
                    { 80, "Canary", new DateTime(2024, 8, 26, 12, 2, 41, 221, DateTimeKind.Local).AddTicks(8545), false, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 3 },
                    { 81, "Budgerigar", new DateTime(2024, 8, 26, 12, 2, 41, 221, DateTimeKind.Local).AddTicks(8546), false, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 3 },
                    { 82, "Cockatiel", new DateTime(2024, 8, 26, 12, 2, 41, 221, DateTimeKind.Local).AddTicks(8547), false, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 3 },
                    { 83, "Lovebird", new DateTime(2024, 8, 26, 12, 2, 41, 221, DateTimeKind.Local).AddTicks(8549), false, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 3 },
                    { 84, "Macaw", new DateTime(2024, 8, 26, 12, 2, 41, 221, DateTimeKind.Local).AddTicks(8550), false, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 3 },
                    { 85, "Conure", new DateTime(2024, 8, 26, 12, 2, 41, 221, DateTimeKind.Local).AddTicks(8551), false, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 3 },
                    { 86, "African Grey Parrot", new DateTime(2024, 8, 26, 12, 2, 41, 221, DateTimeKind.Local).AddTicks(8552), false, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 3 },
                    { 87, "Finches", new DateTime(2024, 8, 26, 12, 2, 41, 221, DateTimeKind.Local).AddTicks(8554), false, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 3 },
                    { 88, "Quaker Parrot", new DateTime(2024, 8, 26, 12, 2, 41, 221, DateTimeKind.Local).AddTicks(8555), false, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 3 },
                    { 89, "Amazon Parrot", new DateTime(2024, 8, 26, 12, 2, 41, 221, DateTimeKind.Local).AddTicks(8556), false, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 3 },
                    { 90, "Eclectus Parrot", new DateTime(2024, 8, 26, 12, 2, 41, 221, DateTimeKind.Local).AddTicks(8558), false, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 3 },
                    { 91, "Pigeon", new DateTime(2024, 8, 26, 12, 2, 41, 221, DateTimeKind.Local).AddTicks(8559), false, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 3 },
                    { 92, "Dove", new DateTime(2024, 8, 26, 12, 2, 41, 221, DateTimeKind.Local).AddTicks(8560), false, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 3 },
                    { 93, "Cockatoo", new DateTime(2024, 8, 26, 12, 2, 41, 221, DateTimeKind.Local).AddTicks(8561), false, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 3 },
                    { 94, "Sun Conure", new DateTime(2024, 8, 26, 12, 2, 41, 221, DateTimeKind.Local).AddTicks(8563), false, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 3 },
                    { 95, "Hyacinth Macaw", new DateTime(2024, 8, 26, 12, 2, 41, 221, DateTimeKind.Local).AddTicks(8564), false, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 3 },
                    { 96, "Lorikeet", new DateTime(2024, 8, 26, 12, 2, 41, 221, DateTimeKind.Local).AddTicks(8565), false, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 3 },
                    { 97, "Zebra Finch", new DateTime(2024, 8, 26, 12, 2, 41, 221, DateTimeKind.Local).AddTicks(8567), false, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 3 },
                    { 98, "Gouldian Finch", new DateTime(2024, 8, 26, 12, 2, 41, 221, DateTimeKind.Local).AddTicks(8568), false, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 3 },
                    { 99, "Canary Winged Parakeet", new DateTime(2024, 8, 26, 12, 2, 41, 221, DateTimeKind.Local).AddTicks(8569), false, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 3 },
                    { 100, "Quail", new DateTime(2024, 8, 26, 12, 2, 41, 221, DateTimeKind.Local).AddTicks(8570), false, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 3 },
                    { 101, "Iguana", new DateTime(2024, 8, 26, 12, 2, 41, 221, DateTimeKind.Local).AddTicks(8572), false, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 4 },
                    { 102, "Gecko", new DateTime(2024, 8, 26, 12, 2, 41, 221, DateTimeKind.Local).AddTicks(8573), false, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 4 },
                    { 103, "Bearded Dragon", new DateTime(2024, 8, 26, 12, 2, 41, 221, DateTimeKind.Local).AddTicks(8575), false, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 4 },
                    { 104, "Chameleon", new DateTime(2024, 8, 26, 12, 2, 41, 221, DateTimeKind.Local).AddTicks(8576), false, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 4 },
                    { 105, "Python", new DateTime(2024, 8, 26, 12, 2, 41, 221, DateTimeKind.Local).AddTicks(8577), false, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 4 },
                    { 106, "Boa Constrictor", new DateTime(2024, 8, 26, 12, 2, 41, 221, DateTimeKind.Local).AddTicks(8579), false, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 4 },
                    { 107, "Skink", new DateTime(2024, 8, 26, 12, 2, 41, 221, DateTimeKind.Local).AddTicks(8580), false, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 4 },
                    { 108, "Tortoise", new DateTime(2024, 8, 26, 12, 2, 41, 221, DateTimeKind.Local).AddTicks(8581), false, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 4 },
                    { 109, "Turtle", new DateTime(2024, 8, 26, 12, 2, 41, 221, DateTimeKind.Local).AddTicks(8582), false, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 4 },
                    { 110, "Monitor Lizard", new DateTime(2024, 8, 26, 12, 2, 41, 221, DateTimeKind.Local).AddTicks(8583), false, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 4 },
                    { 111, "Water Dragon", new DateTime(2024, 8, 26, 12, 2, 41, 221, DateTimeKind.Local).AddTicks(8585), false, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 4 },
                    { 112, "Uromastyx", new DateTime(2024, 8, 26, 12, 2, 41, 221, DateTimeKind.Local).AddTicks(8586), false, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 4 },
                    { 113, "Horned Toad", new DateTime(2024, 8, 26, 12, 2, 41, 221, DateTimeKind.Local).AddTicks(8588), false, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 4 },
                    { 114, "Hamster", new DateTime(2024, 8, 26, 12, 2, 41, 221, DateTimeKind.Local).AddTicks(8589), false, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 5 },
                    { 115, "Guinea Pig", new DateTime(2024, 8, 26, 12, 2, 41, 221, DateTimeKind.Local).AddTicks(8590), false, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 5 },
                    { 116, "Rat", new DateTime(2024, 8, 26, 12, 2, 41, 221, DateTimeKind.Local).AddTicks(8591), false, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 5 },
                    { 117, "Mouse", new DateTime(2024, 8, 26, 12, 2, 41, 221, DateTimeKind.Local).AddTicks(8593), false, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 5 },
                    { 118, "Gerbil", new DateTime(2024, 8, 26, 12, 2, 41, 221, DateTimeKind.Local).AddTicks(8595), false, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 5 },
                    { 119, "Chinchilla", new DateTime(2024, 8, 26, 12, 2, 41, 221, DateTimeKind.Local).AddTicks(8597), false, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 5 },
                    { 120, "Degu", new DateTime(2024, 8, 26, 12, 2, 41, 221, DateTimeKind.Local).AddTicks(8598), false, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 5 },
                    { 121, "Capybara", new DateTime(2024, 8, 26, 12, 2, 41, 221, DateTimeKind.Local).AddTicks(8599), false, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 5 },
                    { 122, "Prairie Dog", new DateTime(2024, 8, 26, 12, 2, 41, 221, DateTimeKind.Local).AddTicks(8600), false, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 5 },
                    { 123, "Goldfish", new DateTime(2024, 8, 26, 12, 2, 41, 221, DateTimeKind.Local).AddTicks(8602), false, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 6 },
                    { 124, "Betta", new DateTime(2024, 8, 26, 12, 2, 41, 221, DateTimeKind.Local).AddTicks(8604), false, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 6 },
                    { 125, "Guppy", new DateTime(2024, 8, 26, 12, 2, 41, 221, DateTimeKind.Local).AddTicks(8605), false, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 6 },
                    { 126, "Neon Tetra", new DateTime(2024, 8, 26, 12, 2, 41, 221, DateTimeKind.Local).AddTicks(8606), false, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 6 },
                    { 127, "Angelfish", new DateTime(2024, 8, 26, 12, 2, 41, 221, DateTimeKind.Local).AddTicks(8607), false, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 6 },
                    { 128, "Oscar", new DateTime(2024, 8, 26, 12, 2, 41, 221, DateTimeKind.Local).AddTicks(8609), false, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 6 },
                    { 129, "Clownfish", new DateTime(2024, 8, 26, 12, 2, 41, 221, DateTimeKind.Local).AddTicks(8611), false, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 6 },
                    { 130, "Corydoras Catfish", new DateTime(2024, 8, 26, 12, 2, 41, 221, DateTimeKind.Local).AddTicks(8612), false, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 6 },
                    { 131, "Molly", new DateTime(2024, 8, 26, 12, 2, 41, 221, DateTimeKind.Local).AddTicks(8613), false, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 6 },
                    { 132, "Swordtail", new DateTime(2024, 8, 26, 12, 2, 41, 221, DateTimeKind.Local).AddTicks(8614), false, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 6 },
                    { 133, "Rainbowfish", new DateTime(2024, 8, 26, 12, 2, 41, 221, DateTimeKind.Local).AddTicks(8616), false, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 6 },
                    { 134, "Plecostomus", new DateTime(2024, 8, 26, 12, 2, 41, 221, DateTimeKind.Local).AddTicks(8617), false, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 6 },
                    { 135, "Gourami", new DateTime(2024, 8, 26, 12, 2, 41, 221, DateTimeKind.Local).AddTicks(8618), false, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 6 },
                    { 136, "Danios", new DateTime(2024, 8, 26, 12, 2, 41, 221, DateTimeKind.Local).AddTicks(8620), false, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 6 },
                    { 137, "Apistogramma", new DateTime(2024, 8, 26, 12, 2, 41, 221, DateTimeKind.Local).AddTicks(8621), false, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 6 },
                    { 138, "Discus", new DateTime(2024, 8, 26, 12, 2, 41, 221, DateTimeKind.Local).AddTicks(8622), false, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 6 },
                    { 139, "Koi", new DateTime(2024, 8, 26, 12, 2, 41, 221, DateTimeKind.Local).AddTicks(8623), false, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 6 },
                    { 140, "Holstein Cow", new DateTime(2024, 8, 26, 12, 2, 41, 221, DateTimeKind.Local).AddTicks(8625), false, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 7 },
                    { 141, "Angus Cow", new DateTime(2024, 8, 26, 12, 2, 41, 221, DateTimeKind.Local).AddTicks(8626), false, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 7 },
                    { 142, "Jersey Cow", new DateTime(2024, 8, 26, 12, 2, 41, 221, DateTimeKind.Local).AddTicks(8684), false, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 7 },
                    { 143, "Guernsey Cow", new DateTime(2024, 8, 26, 12, 2, 41, 221, DateTimeKind.Local).AddTicks(8685), false, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 7 },
                    { 144, "Merino Sheep", new DateTime(2024, 8, 26, 12, 2, 41, 221, DateTimeKind.Local).AddTicks(8687), false, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 7 },
                    { 145, "Suffolk Sheep", new DateTime(2024, 8, 26, 12, 2, 41, 221, DateTimeKind.Local).AddTicks(8688), false, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 7 },
                    { 146, "Dorset Sheep", new DateTime(2024, 8, 26, 12, 2, 41, 221, DateTimeKind.Local).AddTicks(8690), false, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 7 },
                    { 147, "Hampshire Sheep", new DateTime(2024, 8, 26, 12, 2, 41, 221, DateTimeKind.Local).AddTicks(8691), false, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 7 },
                    { 148, "Berkshire Pig", new DateTime(2024, 8, 26, 12, 2, 41, 221, DateTimeKind.Local).AddTicks(8693), false, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 7 },
                    { 149, "Duroc Pig", new DateTime(2024, 8, 26, 12, 2, 41, 221, DateTimeKind.Local).AddTicks(8694), false, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 7 },
                    { 150, "Yorkshire Pig", new DateTime(2024, 8, 26, 12, 2, 41, 221, DateTimeKind.Local).AddTicks(8695), false, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 7 },
                    { 151, "Landrace Pig", new DateTime(2024, 8, 26, 12, 2, 41, 221, DateTimeKind.Local).AddTicks(8697), false, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 7 },
                    { 152, "Rhode Island Red Chicken", new DateTime(2024, 8, 26, 12, 2, 41, 221, DateTimeKind.Local).AddTicks(8698), false, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 7 },
                    { 153, "Leghorn Chicken", new DateTime(2024, 8, 26, 12, 2, 41, 221, DateTimeKind.Local).AddTicks(8699), false, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 7 },
                    { 154, "Plymouth Rock Chicken", new DateTime(2024, 8, 26, 12, 2, 41, 221, DateTimeKind.Local).AddTicks(8701), false, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 7 },
                    { 155, "Sussex Chicken", new DateTime(2024, 8, 26, 12, 2, 41, 221, DateTimeKind.Local).AddTicks(8702), false, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 7 },
                    { 156, "Turkeys", new DateTime(2024, 8, 26, 12, 2, 41, 221, DateTimeKind.Local).AddTicks(8703), false, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 7 },
                    { 157, "Ducks", new DateTime(2024, 8, 26, 12, 2, 41, 221, DateTimeKind.Local).AddTicks(8704), false, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 7 },
                    { 158, "Goats", new DateTime(2024, 8, 26, 12, 2, 41, 221, DateTimeKind.Local).AddTicks(8706), false, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 7 },
                    { 159, "Llamas", new DateTime(2024, 8, 26, 12, 2, 41, 221, DateTimeKind.Local).AddTicks(8707), false, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 7 },
                    { 160, "Alpacas", new DateTime(2024, 8, 26, 12, 2, 41, 221, DateTimeKind.Local).AddTicks(8708), false, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 7 }
                });

            migrationBuilder.InsertData(
                table: "Shelters",
                columns: new[] { "Id", "AboutShelter", "Address", "AdoptionPolicy", "City", "CompanyId", "CreatedTime", "IsDeleted", "LastUpdatedTime", "ShelterImageUrl", "ShelterName" },
                values: new object[,]
                {
                    { 1021, "This is about shelter for Company21.", "Street 21", "Adoption policy for Company21.", "Baku", 2021, new DateTime(2024, 8, 26, 8, 2, 41, 221, DateTimeKind.Utc).AddTicks(4428), false, new DateTime(2024, 8, 26, 8, 2, 41, 221, DateTimeKind.Utc).AddTicks(4430), "https://picsum.photos/seed/user21/200/300", "Shelter Name 21" },
                    { 1022, "This is about shelter for Company22.", "Street 22", "Adoption policy for Company22.", "Baku", 2022, new DateTime(2024, 8, 26, 8, 2, 41, 221, DateTimeKind.Utc).AddTicks(4444), false, new DateTime(2024, 8, 26, 8, 2, 41, 221, DateTimeKind.Utc).AddTicks(4444), "https://picsum.photos/seed/user22/200/300", "Shelter Name 22" },
                    { 1023, "This is about shelter for Company23.", "Street 23", "Adoption policy for Company23.", "Baku", 2023, new DateTime(2024, 8, 26, 8, 2, 41, 221, DateTimeKind.Utc).AddTicks(4451), false, new DateTime(2024, 8, 26, 8, 2, 41, 221, DateTimeKind.Utc).AddTicks(4452), "https://picsum.photos/seed/user23/200/300", "Shelter Name 23" },
                    { 1024, "This is about shelter for Company24.", "Street 24", "Adoption policy for Company24.", "Baku", 2024, new DateTime(2024, 8, 26, 8, 2, 41, 221, DateTimeKind.Utc).AddTicks(4458), false, new DateTime(2024, 8, 26, 8, 2, 41, 221, DateTimeKind.Utc).AddTicks(4459), "https://picsum.photos/seed/user24/200/300", "Shelter Name 24" },
                    { 1025, "This is about shelter for Company25.", "Street 25", "Adoption policy for Company25.", "Baku", 2025, new DateTime(2024, 8, 26, 8, 2, 41, 221, DateTimeKind.Utc).AddTicks(4466), false, new DateTime(2024, 8, 26, 8, 2, 41, 221, DateTimeKind.Utc).AddTicks(4466), "https://picsum.photos/seed/user25/200/300", "Shelter Name 25" },
                    { 1026, "This is about shelter for Company26.", "Street 26", "Adoption policy for Company26.", "Baku", 2026, new DateTime(2024, 8, 26, 8, 2, 41, 221, DateTimeKind.Utc).AddTicks(4475), false, new DateTime(2024, 8, 26, 8, 2, 41, 221, DateTimeKind.Utc).AddTicks(4475), "https://picsum.photos/seed/user26/200/300", "Shelter Name 26" },
                    { 1027, "This is about shelter for Company27.", "Street 27", "Adoption policy for Company27.", "Baku", 2027, new DateTime(2024, 8, 26, 8, 2, 41, 221, DateTimeKind.Utc).AddTicks(4482), false, new DateTime(2024, 8, 26, 8, 2, 41, 221, DateTimeKind.Utc).AddTicks(4482), "https://picsum.photos/seed/user27/200/300", "Shelter Name 27" },
                    { 1028, "This is about shelter for Company28.", "Street 28", "Adoption policy for Company28.", "Baku", 2028, new DateTime(2024, 8, 26, 8, 2, 41, 221, DateTimeKind.Utc).AddTicks(4489), false, new DateTime(2024, 8, 26, 8, 2, 41, 221, DateTimeKind.Utc).AddTicks(4489), "https://picsum.photos/seed/user28/200/300", "Shelter Name 28" },
                    { 1029, "This is about shelter for Company29.", "Street 29", "Adoption policy for Company29.", "Baku", 2029, new DateTime(2024, 8, 26, 8, 2, 41, 221, DateTimeKind.Utc).AddTicks(4547), false, new DateTime(2024, 8, 26, 8, 2, 41, 221, DateTimeKind.Utc).AddTicks(4547), "https://picsum.photos/seed/user29/200/300", "Shelter Name 29" },
                    { 1030, "This is about shelter for Company30.", "Street 30", "Adoption policy for Company30.", "Baku", 2030, new DateTime(2024, 8, 26, 8, 2, 41, 221, DateTimeKind.Utc).AddTicks(4556), false, new DateTime(2024, 8, 26, 8, 2, 41, 221, DateTimeKind.Utc).AddTicks(4557), "https://picsum.photos/seed/user30/200/300", "Shelter Name 30" },
                    { 1031, "This is about shelter for Company31.", "Street 31", "Adoption policy for Company31.", "Baku", 2031, new DateTime(2024, 8, 26, 8, 2, 41, 221, DateTimeKind.Utc).AddTicks(4563), false, new DateTime(2024, 8, 26, 8, 2, 41, 221, DateTimeKind.Utc).AddTicks(4563), "https://picsum.photos/seed/user31/200/300", "Shelter Name 31" },
                    { 1032, "This is about shelter for Company32.", "Street 32", "Adoption policy for Company32.", "Baku", 2032, new DateTime(2024, 8, 26, 8, 2, 41, 221, DateTimeKind.Utc).AddTicks(4570), false, new DateTime(2024, 8, 26, 8, 2, 41, 221, DateTimeKind.Utc).AddTicks(4570), "https://picsum.photos/seed/user32/200/300", "Shelter Name 32" },
                    { 1033, "This is about shelter for Company33.", "Street 33", "Adoption policy for Company33.", "Baku", 2033, new DateTime(2024, 8, 26, 8, 2, 41, 221, DateTimeKind.Utc).AddTicks(4577), false, new DateTime(2024, 8, 26, 8, 2, 41, 221, DateTimeKind.Utc).AddTicks(4577), "https://picsum.photos/seed/user33/200/300", "Shelter Name 33" },
                    { 1034, "This is about shelter for Company34.", "Street 34", "Adoption policy for Company34.", "Baku", 2034, new DateTime(2024, 8, 26, 8, 2, 41, 221, DateTimeKind.Utc).AddTicks(4584), false, new DateTime(2024, 8, 26, 8, 2, 41, 221, DateTimeKind.Utc).AddTicks(4585), "https://picsum.photos/seed/user34/200/300", "Shelter Name 34" },
                    { 1035, "This is about shelter for Company35.", "Street 35", "Adoption policy for Company35.", "Baku", 2035, new DateTime(2024, 8, 26, 8, 2, 41, 221, DateTimeKind.Utc).AddTicks(4592), false, new DateTime(2024, 8, 26, 8, 2, 41, 221, DateTimeKind.Utc).AddTicks(4592), "https://picsum.photos/seed/user35/200/300", "Shelter Name 35" },
                    { 1036, "This is about shelter for Company36.", "Street 36", "Adoption policy for Company36.", "Baku", 2036, new DateTime(2024, 8, 26, 8, 2, 41, 221, DateTimeKind.Utc).AddTicks(4599), false, new DateTime(2024, 8, 26, 8, 2, 41, 221, DateTimeKind.Utc).AddTicks(4599), "https://picsum.photos/seed/user36/200/300", "Shelter Name 36" },
                    { 1037, "This is about shelter for Company37.", "Street 37", "Adoption policy for Company37.", "Baku", 2037, new DateTime(2024, 8, 26, 8, 2, 41, 221, DateTimeKind.Utc).AddTicks(4605), false, new DateTime(2024, 8, 26, 8, 2, 41, 221, DateTimeKind.Utc).AddTicks(4606), "https://picsum.photos/seed/user37/200/300", "Shelter Name 37" },
                    { 1038, "This is about shelter for Company38.", "Street 38", "Adoption policy for Company38.", "Baku", 2038, new DateTime(2024, 8, 26, 8, 2, 41, 221, DateTimeKind.Utc).AddTicks(4614), false, new DateTime(2024, 8, 26, 8, 2, 41, 221, DateTimeKind.Utc).AddTicks(4615), "https://picsum.photos/seed/user38/200/300", "Shelter Name 38" },
                    { 1039, "This is about shelter for Company39.", "Street 39", "Adoption policy for Company39.", "Baku", 2039, new DateTime(2024, 8, 26, 8, 2, 41, 221, DateTimeKind.Utc).AddTicks(4621), false, new DateTime(2024, 8, 26, 8, 2, 41, 221, DateTimeKind.Utc).AddTicks(4621), "https://picsum.photos/seed/user39/200/300", "Shelter Name 39" },
                    { 1040, "This is about shelter for Company40.", "Street 40", "Adoption policy for Company40.", "Baku", 2040, new DateTime(2024, 8, 26, 8, 2, 41, 221, DateTimeKind.Utc).AddTicks(4628), false, new DateTime(2024, 8, 26, 8, 2, 41, 221, DateTimeKind.Utc).AddTicks(4628), "https://picsum.photos/seed/user40/200/300", "Shelter Name 40" }
                });

            migrationBuilder.InsertData(
                table: "Pets",
                columns: new[] { "Id", "AdoptionId", "Age", "BreedId", "CreatedTime", "Description", "Gender", "Health", "ImageUrls", "IsAdopted", "IsDeleted", "LastUpdatedTime", "PetName", "PetTypeId", "ShelterId", "Size", "Weight" },
                values: new object[,]
                {
                    { 1, null, (short)3, 1, new DateTime(2024, 8, 26, 12, 2, 41, 233, DateTimeKind.Local).AddTicks(780), "Friendly Labrador Retriever", 1, "Healthy", "[\"https://images.unsplash.com/photo-1574158622682-e40e69881006\",\"https://images.unsplash.com/photo-1583511656127-8a22f6e9f018\"]", false, false, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "Buddy", 1, 1026, "Large", 30.5m },
                    { 2, null, (short)2, 2, new DateTime(2024, 8, 26, 12, 2, 41, 233, DateTimeKind.Local).AddTicks(805), "Energetic Beagle", 2, "Healthy", "[\"https://images.unsplash.com/photo-1560807707-8cc77767d783\",\"https://images.unsplash.com/photo-1560807707-8cc77767d783\"]", false, false, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "Bella", 1, 1026, "Medium", 10.2m },
                    { 3, null, (short)5, 3, new DateTime(2024, 8, 26, 12, 2, 41, 233, DateTimeKind.Local).AddTicks(811), "Loyal German Shepherd", 1, "Healthy", "[\"https://images.unsplash.com/photo-1560807707-8cc77767d783\",\"https://images.unsplash.com/photo-1601758124199-0a4b30c13d8e\"]", true, false, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "Max", 1, 1026, "Large", 40.8m },
                    { 4, null, (short)4, 4, new DateTime(2024, 8, 26, 12, 2, 41, 233, DateTimeKind.Local).AddTicks(815), "Clever Border Collie", 2, "Healthy", "[\"https://images.unsplash.com/photo-1579362242788-7d8d553f7d82\",\"https://images.unsplash.com/photo-1593137318309-7d0bdc18f9c3\"]", false, false, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "Lucy", 1, 1026, "Medium", 18.7m },
                    { 5, null, (short)2, 5, new DateTime(2024, 8, 26, 12, 2, 41, 233, DateTimeKind.Local).AddTicks(820), "Playful Golden Retriever", 1, "Healthy", "[\"https://images.unsplash.com/photo-1557302985-673a2c6c8c83\",\"https://images.unsplash.com/photo-1596495577886-d920f15eb45d\"]", true, false, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "Charlie", 1, 1026, "Large", 28.3m },
                    { 6, null, (short)2, 6, new DateTime(2024, 8, 26, 12, 2, 41, 233, DateTimeKind.Local).AddTicks(824), "Playful Maine Coon", 2, "Healthy", "[\"https://images.unsplash.com/photo-1585791325888-0fc79fae1484\",\"https://images.unsplash.com/photo-1570816118443-e11a95c3f168\"]", true, false, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "Mittens", 2, 1026, "Large", 10.2m },
                    { 7, null, (short)4, 7, new DateTime(2024, 8, 26, 12, 2, 41, 233, DateTimeKind.Local).AddTicks(828), "Curious Siamese", 1, "Healthy", "[\"https://images.unsplash.com/photo-1560807707-8cc77767d783\",\"https://images.unsplash.com/photo-1584358147545-7fd7b772d2e8\"]", false, false, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "Whiskers", 2, 1026, "Medium", 7.8m },
                    { 8, null, (short)3, 8, new DateTime(2024, 8, 26, 12, 2, 41, 233, DateTimeKind.Local).AddTicks(833), "Silent Russian Blue", 1, "Healthy", "[\"https://images.unsplash.com/photo-1592194996308-7b19e0c4730b\",\"https://images.unsplash.com/photo-1593137318309-7d0bdc18f9c3\"]", true, false, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "Shadow", 2, 1026, "Medium", 8.5m },
                    { 9, null, (short)2, 9, new DateTime(2024, 8, 26, 12, 2, 41, 233, DateTimeKind.Local).AddTicks(837), "Graceful Persian", 2, "Healthy", "[\"https://images.unsplash.com/photo-1583511656127-8a22f6e9f018\",\"https://images.unsplash.com/photo-1560807707-8cc77767d783\"]", false, false, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "Luna", 2, 1026, "Small", 5.3m },
                    { 10, null, (short)3, 10, new DateTime(2024, 8, 26, 12, 2, 41, 233, DateTimeKind.Local).AddTicks(842), "Adventurous Bengal", 1, "Healthy", "[\"https://images.unsplash.com/photo-1560807707-8cc77767d783\",\"https://images.unsplash.com/photo-1601758124199-0a4b30c13d8e\"]", false, false, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "Simba", 2, 1026, "Large", 9.2m },
                    { 11, null, (short)1, 11, new DateTime(2024, 8, 26, 12, 2, 41, 233, DateTimeKind.Local).AddTicks(846), "Chirpy Canary", 2, "Healthy", "[\"https://images.unsplash.com/photo-1558981289-42a1e2b2133e\",\"https://images.unsplash.com/photo-1560807707-8cc77767d783\"]", false, false, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "Tweety", 3, 1026, "Small", 0.05m },
                    { 12, null, (short)5, 12, new DateTime(2024, 8, 26, 12, 2, 41, 233, DateTimeKind.Local).AddTicks(851), "Talkative Parrot", 2, "Healthy", "[\"https://images.unsplash.com/photo-1507611097612-5ff4d04e4b7e\",\"https://images.unsplash.com/photo-1508546293063-3094b6a13db5\"]", false, false, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "Polly", 3, 1026, "Medium", 0.9m },
                    { 13, null, (short)2, 13, new DateTime(2024, 8, 26, 12, 2, 41, 233, DateTimeKind.Local).AddTicks(854), "Graceful Cockatiel", 1, "Healthy", "[\"https://images.unsplash.com/photo-1560807707-8cc77767d783\",\"https://images.unsplash.com/photo-1558981289-42a1e2b2133e\"]", true, false, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "Sky", 3, 1026, "Small", 0.12m },
                    { 14, null, (short)3, 14, new DateTime(2024, 8, 26, 12, 2, 41, 233, DateTimeKind.Local).AddTicks(908), "Colorful Parakeet", 2, "Healthy", "[\"https://images.unsplash.com/photo-1508610048659-a06d45f8a1a5\",\"https://images.unsplash.com/photo-1558981289-42a1e2b2133e\"]", false, false, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "Kiwi", 3, 1026, "Small", 0.06m },
                    { 15, null, (short)4, 15, new DateTime(2024, 8, 26, 12, 2, 41, 233, DateTimeKind.Local).AddTicks(914), "Clever African Grey", 2, "Healthy", "[\"https://images.unsplash.com/photo-1558981289-42a1e2b2133e\",\"https://images.unsplash.com/photo-1508546293063-3094b6a13db5\"]", true, false, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "Coco", 3, 1025, "Medium", 0.45m },
                    { 16, null, (short)4, 16, new DateTime(2024, 8, 26, 12, 2, 41, 233, DateTimeKind.Local).AddTicks(919), "Spiky Bearded Dragon", 1, "Healthy", "[\"https://images.unsplash.com/photo-1599945863043-c972ca05f8d0\",\"https://images.unsplash.com/photo-1560807707-8cc77767d783\"]", false, false, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "Spike", 4, 1026, "Medium", 1.1m },
                    { 17, null, (short)2, 17, new DateTime(2024, 8, 26, 12, 2, 41, 233, DateTimeKind.Local).AddTicks(923), "Stealthy Corn Snake", 1, "Healthy", "[\"https://images.unsplash.com/photo-1587137112204-ff2af20e59d5\",\"https://images.unsplash.com/photo-1560807707-8cc77767d783\"]", false, false, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "Slinky", 4, 1026, "Small", 0.3m },
                    { 18, null, (short)3, 18, new DateTime(2024, 8, 26, 12, 2, 41, 233, DateTimeKind.Local).AddTicks(927), "Agile Gecko", 2, "Healthy", "[\"https://images.unsplash.com/photo-1593137318309-7d0bdc18f9c3\",\"https://images.unsplash.com/photo-1587137112204-ff2af20e59d5\"]", false, false, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "Gizmo", 4, 1026, "Small", 0.07m },
                    { 19, null, (short)1, 19, new DateTime(2024, 8, 26, 12, 2, 41, 233, DateTimeKind.Local).AddTicks(931), "Curious Hamster", 1, "Healthy", "[\"https://images.unsplash.com/photo-1550807012-514e38ec9ad4\",\"https://images.unsplash.com/photo-1558981289-42a1e2b2133e\"]", true, false, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "Nibbles", 5, 1026, "Small", 0.03m },
                    { 20, null, (short)2, 20, new DateTime(2024, 8, 26, 12, 2, 41, 233, DateTimeKind.Local).AddTicks(936), "Fluffy Guinea Pig", 2, "Healthy", "[\"https://images.unsplash.com/photo-1550807012-514e38ec9ad4\",\"https://images.unsplash.com/photo-1558981289-42a1e2b2133e\"]", false, false, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "Fuzzy", 5, 1026, "Small", 1.2m },
                    { 21, null, (short)3, 21, new DateTime(2024, 8, 26, 12, 2, 41, 233, DateTimeKind.Local).AddTicks(942), "Playful Rabbit", 1, "Healthy", "[\"https://images.unsplash.com/photo-1550807012-514e38ec9ad4\",\"https://images.unsplash.com/photo-1560807707-8cc77767d783\"]", false, false, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "Pip", 5, 1026, "Small", 2.5m },
                    { 22, null, (short)3, 22, new DateTime(2024, 8, 26, 12, 2, 41, 233, DateTimeKind.Local).AddTicks(945), "Charming Chinchilla", 1, "Healthy", "[\"https://images.unsplash.com/photo-1550807012-514e38ec9ad4\",\"https://images.unsplash.com/photo-1558981289-42a1e2b2133e\"]", false, false, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "Chester", 6, 1026, "Small", 0.6m },
                    { 23, null, (short)2, 23, new DateTime(2024, 8, 26, 12, 2, 41, 233, DateTimeKind.Local).AddTicks(949), "Lively Sugar Glider", 2, "Healthy", "[\"https://images.unsplash.com/photo-1550807012-514e38ec9ad4\",\"https://images.unsplash.com/photo-1558981289-42a1e2b2133e\"]", false, false, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "Zara", 6, 1026, "Small", 0.1m },
                    { 24, null, (short)2, 24, new DateTime(2024, 8, 26, 12, 2, 41, 233, DateTimeKind.Local).AddTicks(953), "Spiky Hedgehog", 1, "Healthy", "[\"https://images.unsplash.com/photo-1550807012-514e38ec9ad4\",\"https://images.unsplash.com/photo-1558981289-42a1e2b2133e\"]", true, false, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "Spike", 6, 1026, "Small", 0.4m },
                    { 25, null, (short)4, 25, new DateTime(2024, 8, 26, 12, 2, 41, 233, DateTimeKind.Local).AddTicks(957), "Soft Chinchilla", 1, "Healthy", "[\"url49.jpg\",\"url50.jpg\"]", true, false, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "Chinchy", 5, 1024, "Small", 0.6m },
                    { 26, null, (short)1, 26, new DateTime(2024, 8, 26, 12, 2, 41, 233, DateTimeKind.Local).AddTicks(961), "Colorful Betta Fish", 1, "Healthy", "[\"url51.jpg\",\"url52.jpg\"]", false, false, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "Bubbles", 6, 1024, "Small", 0.02m },
                    { 27, null, (short)2, 27, new DateTime(2024, 8, 26, 12, 2, 41, 233, DateTimeKind.Local).AddTicks(966), "Tiny Frog", 2, "Healthy", "[\"url53.jpg\",\"url54.jpg\"]", false, false, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "Frodo", 6, 1024, "Small", 0.05m },
                    { 28, null, (short)3, 28, new DateTime(2024, 8, 26, 12, 2, 41, 233, DateTimeKind.Local).AddTicks(970), "Creepy Tarantula", 2, "Healthy", "[\"url55.jpg\",\"url56.jpg\"]", true, false, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "Spidey", 6, 1024, "Small", 0.1m },
                    { 29, null, (short)2, 29, new DateTime(2024, 8, 26, 12, 2, 41, 233, DateTimeKind.Local).AddTicks(974), "Amphibious Newt", 2, "Healthy", "[\"url57.jpg\",\"url58.jpg\"]", false, false, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "Newt", 6, 1024, "Small", 0.07m },
                    { 30, null, (short)5, 30, new DateTime(2024, 8, 26, 12, 2, 41, 233, DateTimeKind.Local).AddTicks(978), "Scaly Iguana", 1, "Healthy", "[\"url59.jpg\",\"url60.jpg\"]", true, false, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "Scales", 6, 1024, "Medium", 1.5m },
                    { 31, null, (short)4, 31, new DateTime(2024, 8, 26, 12, 2, 41, 233, DateTimeKind.Local).AddTicks(982), "Guard Dog Rottweiler", 1, "Healthy", "[\"url61.jpg\",\"url62.jpg\"]", false, false, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "Rex", 1, 1024, "Large", 50.0m },
                    { 32, null, (short)2, 32, new DateTime(2024, 8, 26, 12, 2, 41, 233, DateTimeKind.Local).AddTicks(986), "Playful Pug", 1, "Healthy", "[\"url63.jpg\",\"url64.jpg\"]", true, false, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "Milo", 1, 1024, "Small", 8.5m },
                    { 33, null, (short)3, 33, new DateTime(2024, 8, 26, 12, 2, 41, 233, DateTimeKind.Local).AddTicks(990), "Adorable Shih Tzu", 2, "Healthy", "[\"url65.jpg\",\"url66.jpg\"]", false, false, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "Bailey", 1, 1023, "Small", 6.2m },
                    { 34, null, (short)4, 34, new DateTime(2024, 8, 26, 12, 2, 41, 233, DateTimeKind.Local).AddTicks(994), "Agile Greyhound", 2, "Healthy", "[\"url67.jpg\",\"url68.jpg\"]", true, false, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "Sasha", 1, 1023, "Large", 28.0m },
                    { 35, null, (short)3, 35, new DateTime(2024, 8, 26, 12, 2, 41, 233, DateTimeKind.Local).AddTicks(999), "Energetic Boxer", 1, "Healthy", "[\"url69.jpg\",\"url70.jpg\"]", false, false, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "Rocky", 1, 1023, "Large", 35.0m },
                    { 36, null, (short)2, 36, new DateTime(2024, 8, 26, 12, 2, 41, 233, DateTimeKind.Local).AddTicks(1003), "Affectionate Ragdoll", 1, "Healthy", "[\"url71.jpg\",\"url72.jpg\"]", true, false, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "Toby", 2, 1023, "Large", 9.0m },
                    { 37, null, (short)3, 37, new DateTime(2024, 8, 26, 12, 2, 41, 233, DateTimeKind.Local).AddTicks(1007), "Quiet British Shorthair", 2, "Healthy", "[\"url73.jpg\",\"url74.jpg\"]", false, false, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "Misty", 2, 1022, "Medium", 7.0m },
                    { 38, null, (short)4, 38, new DateTime(2024, 8, 26, 12, 2, 41, 233, DateTimeKind.Local).AddTicks(1011), "Mischievous Sphynx", 1, "Healthy", "[\"url75.jpg\",\"url76.jpg\"]", true, false, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "Oscar", 2, 1022, "Medium", 8.0m },
                    { 39, null, (short)2, 39, new DateTime(2024, 8, 26, 12, 2, 41, 233, DateTimeKind.Local).AddTicks(1015), "Active Abyssinian", 2, "Healthy", "[\"url77.jpg\",\"url78.jpg\"]", false, false, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "Ginger", 2, 1022, "Small", 5.5m },
                    { 40, null, (short)3, 40, new DateTime(2024, 8, 26, 12, 2, 41, 233, DateTimeKind.Local).AddTicks(1019), "Laid-back Birman", 1, "Healthy", "[\"url79.jpg\",\"url80.jpg\"]", true, false, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "Jasper", 2, 1022, "Medium", 6.5m },
                    { 41, null, (short)3, 41, new DateTime(2024, 8, 26, 12, 2, 41, 233, DateTimeKind.Local).AddTicks(1023), "Bright Sun Conure", 2, "Healthy", "[\"url81.jpg\",\"url82.jpg\"]", false, false, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "Sunshine", 3, 1022, "Small", 0.12m },
                    { 42, null, (short)1, 42, new DateTime(2024, 8, 26, 12, 2, 41, 233, DateTimeKind.Local).AddTicks(1026), "Chirpy Canary", 1, "Healthy", "[\"url83.jpg\",\"url84.jpg\"]", false, false, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "Tweety", 3, 1022, "Small", 0.03m },
                    { 43, null, (short)2, 43, new DateTime(2024, 8, 26, 12, 2, 41, 233, DateTimeKind.Local).AddTicks(1031), "Friendly Budgie", 1, "Healthy", "[\"url85.jpg\",\"url86.jpg\"]", true, false, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "Buddy", 3, 1022, "Small", 0.04m },
                    { 44, null, (short)2, 44, new DateTime(2024, 8, 26, 12, 2, 41, 233, DateTimeKind.Local).AddTicks(1035), "Talkative Parakeet", 2, "Healthy", "[\"url87.jpg\",\"url88.jpg\"]", false, false, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "Chirpy", 3, 1021, "Small", 0.05m },
                    { 45, null, (short)4, 45, new DateTime(2024, 8, 26, 12, 2, 41, 233, DateTimeKind.Local).AddTicks(1039), "Noisy Cockatoo", 1, "Healthy", "[\"url89.jpg\",\"url90.jpg\"]", true, false, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "Pepper", 3, 1021, "Medium", 0.5m },
                    { 46, null, (short)5, 46, new DateTime(2024, 8, 26, 12, 2, 41, 233, DateTimeKind.Local).AddTicks(1042), "Venomous King Cobra", 1, "Healthy", "[\"url91.jpg\",\"url92.jpg\"]", false, false, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "Slither", 4, 1021, "Large", 6.0m },
                    { 47, null, (short)7, 47, new DateTime(2024, 8, 26, 12, 2, 41, 233, DateTimeKind.Local).AddTicks(1046), "Large Komodo Dragon", 1, "Healthy", "[\"url93.jpg\",\"url94.jpg\"]", false, false, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "Rex", 4, 1021, "Large", 70.0m },
                    { 48, null, (short)4, 48, new DateTime(2024, 8, 26, 12, 2, 41, 233, DateTimeKind.Local).AddTicks(1050), "Green Iguana", 2, "Healthy", "[\"url95.jpg\",\"url96.jpg\"]", true, false, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "Ivy", 4, 1021, "Medium", 3.5m },
                    { 49, null, (short)5, 49, new DateTime(2024, 8, 26, 12, 2, 41, 233, DateTimeKind.Local).AddTicks(1054), "Horned Lizard", 1, "Healthy", "[\"url97.jpg\",\"url98.jpg\"]", false, false, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "Spike", 4, 1021, "Medium", 2.5m },
                    { 50, null, (short)100, 50, new DateTime(2024, 8, 26, 12, 2, 41, 233, DateTimeKind.Local).AddTicks(1059), "Giant Tortoise", 1, "Healthy", "[\"url99.jpg\",\"url100.jpg\"]", true, false, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "Shelly", 4, 1021, "Large", 200.0m }
                });

            migrationBuilder.CreateIndex(
                name: "IX_AcceptRequests_PetId",
                table: "AcceptRequests",
                column: "PetId");

            migrationBuilder.CreateIndex(
                name: "IX_AcceptRequests_UserId",
                table: "AcceptRequests",
                column: "UserId");

            migrationBuilder.CreateIndex(
                name: "IX_Adoptions_PetId",
                table: "Adoptions",
                column: "PetId",
                unique: true);

            migrationBuilder.CreateIndex(
                name: "IX_Adoptions_UserId",
                table: "Adoptions",
                column: "UserId");

            migrationBuilder.CreateIndex(
                name: "IX_AppUserPetType_VetsId",
                table: "AppUserPetType",
                column: "VetsId");

            migrationBuilder.CreateIndex(
                name: "IX_AspNetRoleClaims_RoleId",
                table: "AspNetRoleClaims",
                column: "RoleId");

            migrationBuilder.CreateIndex(
                name: "RoleNameIndex",
                table: "AspNetRoles",
                column: "NormalizedName",
                unique: true,
                filter: "[NormalizedName] IS NOT NULL");

            migrationBuilder.CreateIndex(
                name: "IX_AspNetUserClaims_UserId",
                table: "AspNetUserClaims",
                column: "UserId");

            migrationBuilder.CreateIndex(
                name: "IX_AspNetUserLogins_UserId",
                table: "AspNetUserLogins",
                column: "UserId");

            migrationBuilder.CreateIndex(
                name: "IX_AspNetUserRoles_RoleId",
                table: "AspNetUserRoles",
                column: "RoleId");

            migrationBuilder.CreateIndex(
                name: "EmailIndex",
                table: "AspNetUsers",
                column: "NormalizedEmail");

            migrationBuilder.CreateIndex(
                name: "UserNameIndex",
                table: "AspNetUsers",
                column: "NormalizedUserName",
                unique: true,
                filter: "[NormalizedUserName] IS NOT NULL");

            migrationBuilder.CreateIndex(
                name: "IX_Breeds_PetTypeId",
                table: "Breeds",
                column: "PetTypeId");

            migrationBuilder.CreateIndex(
                name: "IX_Chats_UserId",
                table: "Chats",
                column: "UserId");

            migrationBuilder.CreateIndex(
                name: "IX_Chats_VetId",
                table: "Chats",
                column: "VetId");

            migrationBuilder.CreateIndex(
                name: "IX_Donations_CompanyId",
                table: "Donations",
                column: "CompanyId");

            migrationBuilder.CreateIndex(
                name: "IX_Donations_UserId",
                table: "Donations",
                column: "UserId");

            migrationBuilder.CreateIndex(
                name: "IX_Messages_ChatId",
                table: "Messages",
                column: "ChatId");

            migrationBuilder.CreateIndex(
                name: "IX_Messages_SenderId",
                table: "Messages",
                column: "SenderId");

            migrationBuilder.CreateIndex(
                name: "IX_Notifications_UserId",
                table: "Notifications",
                column: "UserId");

            migrationBuilder.CreateIndex(
                name: "IX_Pets_BreedId",
                table: "Pets",
                column: "BreedId");

            migrationBuilder.CreateIndex(
                name: "IX_Pets_PetTypeId",
                table: "Pets",
                column: "PetTypeId");

            migrationBuilder.CreateIndex(
                name: "IX_Pets_ShelterId",
                table: "Pets",
                column: "ShelterId");

            migrationBuilder.CreateIndex(
                name: "IX_Shelters_CompanyId",
                table: "Shelters",
                column: "CompanyId");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "AcceptRequests");

            migrationBuilder.DropTable(
                name: "Adoptions");

            migrationBuilder.DropTable(
                name: "AppUserPetType");

            migrationBuilder.DropTable(
                name: "AspNetRoleClaims");

            migrationBuilder.DropTable(
                name: "AspNetUserClaims");

            migrationBuilder.DropTable(
                name: "AspNetUserLogins");

            migrationBuilder.DropTable(
                name: "AspNetUserRoles");

            migrationBuilder.DropTable(
                name: "AspNetUserTokens");

            migrationBuilder.DropTable(
                name: "Donations");

            migrationBuilder.DropTable(
                name: "Messages");

            migrationBuilder.DropTable(
                name: "Notifications");

            migrationBuilder.DropTable(
                name: "Pets");

            migrationBuilder.DropTable(
                name: "AspNetRoles");

            migrationBuilder.DropTable(
                name: "Chats");

            migrationBuilder.DropTable(
                name: "Breeds");

            migrationBuilder.DropTable(
                name: "Shelters");

            migrationBuilder.DropTable(
                name: "PetTypes");

            migrationBuilder.DropTable(
                name: "AspNetUsers");
        }
    }
}
