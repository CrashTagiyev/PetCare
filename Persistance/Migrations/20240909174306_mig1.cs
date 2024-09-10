﻿using System;
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
                    PhoneNumber = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    EmailAddress = table.Column<string>(type: "nvarchar(max)", nullable: true),
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
                        onDelete: ReferentialAction.Cascade);
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
                    BreedId = table.Column<int>(type: "int", nullable: true),
                    PetTypeId = table.Column<int>(type: "int", nullable: true),
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
                        name: "FK_Pets_Breeds_PetTypeId",
                        column: x => x.PetTypeId,
                        principalTable: "Breeds",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.SetNull);
                    table.ForeignKey(
                        name: "FK_Pets_PetTypes_PetTypeId",
                        column: x => x.PetTypeId,
                        principalTable: "PetTypes",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.SetNull);
                    table.ForeignKey(
                        name: "FK_Pets_Shelters_ShelterId",
                        column: x => x.ShelterId,
                        principalTable: "Shelters",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "AcceptRequests",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    AcceptStatus = table.Column<int>(type: "int", nullable: false, defaultValue: 2),
                    Description = table.Column<string>(type: "nvarchar(max)", nullable: false),
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
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_AcceptRequests_Pets_PetId",
                        column: x => x.PetId,
                        principalTable: "Pets",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "Adoptions",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    PetId = table.Column<int>(type: "int", nullable: false),
                    UserId = table.Column<int>(type: "int", nullable: false),
                    About = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    YearsOfPetExperience = table.Column<int>(type: "int", nullable: false),
                    isAccepted = table.Column<bool>(type: "bit", nullable: false),
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
                    { 2001, "Somme about text for something bla bla bla", 0, "Koroglu Rahimov 70", "Baku", null, "959583fe-0a64-4651-9107-6d064474d77f", new DateTime(2024, 5, 9, 17, 43, 5, 319, DateTimeKind.Utc).AddTicks(5930), new DateTime(2000, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 1, "user1@example.com", true, "FirstName1", false, new DateTime(2024, 9, 9, 17, 43, 5, 319, DateTimeKind.Utc).AddTicks(5935), "LastName1", 1, false, null, "USER1@EXAMPLE.COM", "USER1", "AQAAAAIAAYagAAAAEK3JbxnMOU+exC6cOxQLvXvHG6Xt/a7qhEXNftH7DTJLiaC5qZ4fuRAYHF58dVJXaQ==", "+993509998485", false, "https://picsum.photos/seed/user1/200/300", null, new DateTime(2024, 9, 9, 17, 43, 5, 319, DateTimeKind.Utc).AddTicks(5924), null, "RYZH37KPG6EEDGSYWW37NETRG56JM7KG", false, "user1" },
                    { 2002, "Somme about text for something bla bla bla", 0, "Koroglu Rahimov 70", "Baku", null, "174b7ad7-9a9f-458f-aaef-b7d1e0ed8d0f", new DateTime(2024, 1, 9, 17, 43, 5, 319, DateTimeKind.Utc).AddTicks(6027), new DateTime(2000, 1, 2, 0, 0, 0, 0, DateTimeKind.Unspecified), 1, "user2@example.com", true, "FirstName2", false, new DateTime(2024, 9, 9, 17, 43, 5, 319, DateTimeKind.Utc).AddTicks(6028), "LastName2", 1, false, null, "USER2@EXAMPLE.COM", "USER2", "AQAAAAIAAYagAAAAEK3JbxnMOU+exC6cOxQLvXvHG6Xt/a7qhEXNftH7DTJLiaC5qZ4fuRAYHF58dVJXaQ==", "+993509998485", false, "https://picsum.photos/seed/user2/200/300", null, new DateTime(2024, 9, 9, 17, 43, 5, 319, DateTimeKind.Utc).AddTicks(6011), null, "RYZH37KPG6EEDGSYWW37NETRG56JM7KG", false, "user2" },
                    { 2003, "Somme about text for something bla bla bla", 0, "Koroglu Rahimov 70", "Baku", null, "a058e5dc-25fd-430e-b956-9f43d433dfcb", new DateTime(2023, 11, 9, 17, 43, 5, 319, DateTimeKind.Utc).AddTicks(6043), new DateTime(2000, 1, 3, 0, 0, 0, 0, DateTimeKind.Unspecified), 1, "user3@example.com", true, "FirstName3", false, new DateTime(2024, 9, 9, 17, 43, 5, 319, DateTimeKind.Utc).AddTicks(6044), "LastName3", 1, false, null, "USER3@EXAMPLE.COM", "USER3", "AQAAAAIAAYagAAAAEK3JbxnMOU+exC6cOxQLvXvHG6Xt/a7qhEXNftH7DTJLiaC5qZ4fuRAYHF58dVJXaQ==", "+993509998485", false, "https://picsum.photos/seed/user3/200/300", null, new DateTime(2024, 9, 9, 17, 43, 5, 319, DateTimeKind.Utc).AddTicks(6039), null, "RYZH37KPG6EEDGSYWW37NETRG56JM7KG", false, "user3" },
                    { 2004, "Somme about text for something bla bla bla", 0, "Koroglu Rahimov 70", "Baku", null, "e91fb3b2-4497-4c8e-8934-334d3a3c5b16", new DateTime(2024, 8, 9, 17, 43, 5, 319, DateTimeKind.Utc).AddTicks(6055), new DateTime(2000, 1, 4, 0, 0, 0, 0, DateTimeKind.Unspecified), 1, "user4@example.com", true, "FirstName4", false, new DateTime(2024, 9, 9, 17, 43, 5, 319, DateTimeKind.Utc).AddTicks(6055), "LastName4", 1, false, null, "USER4@EXAMPLE.COM", "USER4", "AQAAAAIAAYagAAAAEK3JbxnMOU+exC6cOxQLvXvHG6Xt/a7qhEXNftH7DTJLiaC5qZ4fuRAYHF58dVJXaQ==", "+993509998485", false, "https://picsum.photos/seed/user4/200/300", null, new DateTime(2024, 9, 9, 17, 43, 5, 319, DateTimeKind.Utc).AddTicks(6052), null, "RYZH37KPG6EEDGSYWW37NETRG56JM7KG", false, "user4" },
                    { 2005, "Somme about text for something bla bla bla", 0, "Koroglu Rahimov 70", "Baku", null, "0b8b359d-1cc4-4f0d-b3e5-7a0f4444666c", new DateTime(2023, 12, 9, 17, 43, 5, 319, DateTimeKind.Utc).AddTicks(6070), new DateTime(2000, 1, 5, 0, 0, 0, 0, DateTimeKind.Unspecified), 1, "user5@example.com", true, "FirstName5", false, new DateTime(2024, 9, 9, 17, 43, 5, 319, DateTimeKind.Utc).AddTicks(6071), "LastName5", 1, false, null, "USER5@EXAMPLE.COM", "USER5", "AQAAAAIAAYagAAAAEK3JbxnMOU+exC6cOxQLvXvHG6Xt/a7qhEXNftH7DTJLiaC5qZ4fuRAYHF58dVJXaQ==", "+993509998485", false, "https://picsum.photos/seed/user5/200/300", null, new DateTime(2024, 9, 9, 17, 43, 5, 319, DateTimeKind.Utc).AddTicks(6067), null, "RYZH37KPG6EEDGSYWW37NETRG56JM7KG", false, "user5" },
                    { 2006, "Somme about text for something bla bla bla", 0, "Koroglu Rahimov 70", "Baku", null, "ffdb4642-4c97-48be-96ed-0fdc42208e72", new DateTime(2024, 3, 9, 17, 43, 5, 319, DateTimeKind.Utc).AddTicks(6082), new DateTime(2000, 1, 6, 0, 0, 0, 0, DateTimeKind.Unspecified), 1, "user6@example.com", true, "FirstName6", false, new DateTime(2024, 9, 9, 17, 43, 5, 319, DateTimeKind.Utc).AddTicks(6082), "LastName6", 1, false, null, "USER6@EXAMPLE.COM", "USER6", "AQAAAAIAAYagAAAAEK3JbxnMOU+exC6cOxQLvXvHG6Xt/a7qhEXNftH7DTJLiaC5qZ4fuRAYHF58dVJXaQ==", "+993509998485", false, "https://picsum.photos/seed/user6/200/300", null, new DateTime(2024, 9, 9, 17, 43, 5, 319, DateTimeKind.Utc).AddTicks(6079), null, "RYZH37KPG6EEDGSYWW37NETRG56JM7KG", false, "user6" },
                    { 2007, "Somme about text for something bla bla bla", 0, "Koroglu Rahimov 70", "Baku", null, "7ce60ed1-7cf1-44ae-b450-c1b5c0d83ffb", new DateTime(2024, 2, 9, 17, 43, 5, 319, DateTimeKind.Utc).AddTicks(6093), new DateTime(2000, 1, 7, 0, 0, 0, 0, DateTimeKind.Unspecified), 1, "user7@example.com", true, "FirstName7", false, new DateTime(2024, 9, 9, 17, 43, 5, 319, DateTimeKind.Utc).AddTicks(6094), "LastName7", 1, false, null, "USER7@EXAMPLE.COM", "USER7", "AQAAAAIAAYagAAAAEK3JbxnMOU+exC6cOxQLvXvHG6Xt/a7qhEXNftH7DTJLiaC5qZ4fuRAYHF58dVJXaQ==", "+993509998485", false, "https://picsum.photos/seed/user7/200/300", null, new DateTime(2024, 9, 9, 17, 43, 5, 319, DateTimeKind.Utc).AddTicks(6090), null, "RYZH37KPG6EEDGSYWW37NETRG56JM7KG", false, "user7" },
                    { 2008, "Somme about text for something bla bla bla", 0, "Koroglu Rahimov 70", "Baku", null, "395c7cbf-c0ac-4842-8992-1dba83714adc", new DateTime(2024, 2, 9, 17, 43, 5, 319, DateTimeKind.Utc).AddTicks(6105), new DateTime(2000, 1, 8, 0, 0, 0, 0, DateTimeKind.Unspecified), 1, "user8@example.com", true, "FirstName8", false, new DateTime(2024, 9, 9, 17, 43, 5, 319, DateTimeKind.Utc).AddTicks(6106), "LastName8", 1, false, null, "USER8@EXAMPLE.COM", "USER8", "AQAAAAIAAYagAAAAEK3JbxnMOU+exC6cOxQLvXvHG6Xt/a7qhEXNftH7DTJLiaC5qZ4fuRAYHF58dVJXaQ==", "+993509998485", false, "https://picsum.photos/seed/user8/200/300", null, new DateTime(2024, 9, 9, 17, 43, 5, 319, DateTimeKind.Utc).AddTicks(6102), null, "RYZH37KPG6EEDGSYWW37NETRG56JM7KG", false, "user8" },
                    { 2009, "Somme about text for something bla bla bla", 0, "Koroglu Rahimov 70", "Baku", null, "4ec2992a-4a56-4a1f-93cd-cbfaf31386cc", new DateTime(2024, 6, 9, 17, 43, 5, 319, DateTimeKind.Utc).AddTicks(6118), new DateTime(2000, 1, 9, 0, 0, 0, 0, DateTimeKind.Unspecified), 1, "user9@example.com", true, "FirstName9", false, new DateTime(2024, 9, 9, 17, 43, 5, 319, DateTimeKind.Utc).AddTicks(6119), "LastName9", 1, false, null, "USER9@EXAMPLE.COM", "USER9", "AQAAAAIAAYagAAAAEK3JbxnMOU+exC6cOxQLvXvHG6Xt/a7qhEXNftH7DTJLiaC5qZ4fuRAYHF58dVJXaQ==", "+993509998485", false, "https://picsum.photos/seed/user9/200/300", null, new DateTime(2024, 9, 9, 17, 43, 5, 319, DateTimeKind.Utc).AddTicks(6115), null, "RYZH37KPG6EEDGSYWW37NETRG56JM7KG", false, "user9" },
                    { 2010, "Somme about text for something bla bla bla", 0, "Koroglu Rahimov 70", "Baku", null, "3a33ca50-7afd-4bce-87e8-1edbde5b732c", new DateTime(2023, 10, 9, 17, 43, 5, 319, DateTimeKind.Utc).AddTicks(6135), new DateTime(2000, 1, 10, 0, 0, 0, 0, DateTimeKind.Unspecified), 1, "user10@example.com", true, "FirstName10", false, new DateTime(2024, 9, 9, 17, 43, 5, 319, DateTimeKind.Utc).AddTicks(6136), "LastName10", 1, false, null, "USER10@EXAMPLE.COM", "USER10", "AQAAAAIAAYagAAAAEK3JbxnMOU+exC6cOxQLvXvHG6Xt/a7qhEXNftH7DTJLiaC5qZ4fuRAYHF58dVJXaQ==", "+993509998485", false, "https://picsum.photos/seed/user10/200/300", null, new DateTime(2024, 9, 9, 17, 43, 5, 319, DateTimeKind.Utc).AddTicks(6127), null, "RYZH37KPG6EEDGSYWW37NETRG56JM7KG", false, "user10" },
                    { 2011, "Somme about text for something bla bla bla", 0, "Koroglu Rahimov 70", "Baku", null, "19d75239-7c5b-4928-9781-10342d780f2c", new DateTime(2024, 6, 9, 17, 43, 5, 319, DateTimeKind.Utc).AddTicks(6150), new DateTime(2000, 1, 11, 0, 0, 0, 0, DateTimeKind.Unspecified), 1, "user11@example.com", true, "FirstName11", false, new DateTime(2024, 9, 9, 17, 43, 5, 319, DateTimeKind.Utc).AddTicks(6151), "LastName11", 1, false, null, "USER11@EXAMPLE.COM", "USER11", "AQAAAAIAAYagAAAAEK3JbxnMOU+exC6cOxQLvXvHG6Xt/a7qhEXNftH7DTJLiaC5qZ4fuRAYHF58dVJXaQ==", "+993509998485", false, "https://picsum.photos/seed/user11/200/300", null, new DateTime(2024, 9, 9, 17, 43, 5, 319, DateTimeKind.Utc).AddTicks(6146), null, "RYZH37KPG6EEDGSYWW37NETRG56JM7KG", false, "user11" },
                    { 2012, "Somme about text for something bla bla bla", 0, "Koroglu Rahimov 70", "Baku", null, "65ac5925-21d2-4f41-82f7-b040b7b0e597", new DateTime(2024, 4, 9, 17, 43, 5, 319, DateTimeKind.Utc).AddTicks(6198), new DateTime(2000, 1, 12, 0, 0, 0, 0, DateTimeKind.Unspecified), 1, "user12@example.com", true, "FirstName12", false, new DateTime(2024, 9, 9, 17, 43, 5, 319, DateTimeKind.Utc).AddTicks(6199), "LastName12", 1, false, null, "USER12@EXAMPLE.COM", "USER12", "AQAAAAIAAYagAAAAEK3JbxnMOU+exC6cOxQLvXvHG6Xt/a7qhEXNftH7DTJLiaC5qZ4fuRAYHF58dVJXaQ==", "+993509998485", false, "https://picsum.photos/seed/user12/200/300", null, new DateTime(2024, 9, 9, 17, 43, 5, 319, DateTimeKind.Utc).AddTicks(6195), null, "RYZH37KPG6EEDGSYWW37NETRG56JM7KG", false, "user12" },
                    { 2013, "Somme about text for something bla bla bla", 0, "Koroglu Rahimov 70", "Baku", null, "871d8e7e-379f-4aaa-aafc-85470938d002", new DateTime(2024, 4, 9, 17, 43, 5, 319, DateTimeKind.Utc).AddTicks(6210), new DateTime(2000, 1, 13, 0, 0, 0, 0, DateTimeKind.Unspecified), 1, "user13@example.com", true, "FirstName13", false, new DateTime(2024, 9, 9, 17, 43, 5, 319, DateTimeKind.Utc).AddTicks(6211), "LastName13", 1, false, null, "USER13@EXAMPLE.COM", "USER13", "AQAAAAIAAYagAAAAEK3JbxnMOU+exC6cOxQLvXvHG6Xt/a7qhEXNftH7DTJLiaC5qZ4fuRAYHF58dVJXaQ==", "+993509998485", false, "https://picsum.photos/seed/user13/200/300", null, new DateTime(2024, 9, 9, 17, 43, 5, 319, DateTimeKind.Utc).AddTicks(6207), null, "RYZH37KPG6EEDGSYWW37NETRG56JM7KG", false, "user13" },
                    { 2014, "Somme about text for something bla bla bla", 0, "Koroglu Rahimov 70", "Baku", null, "3c5806b4-a40b-452b-8f9c-bfe14486aaf5", new DateTime(2024, 5, 9, 17, 43, 5, 319, DateTimeKind.Utc).AddTicks(6222), new DateTime(2000, 1, 14, 0, 0, 0, 0, DateTimeKind.Unspecified), 1, "user14@example.com", true, "FirstName14", false, new DateTime(2024, 9, 9, 17, 43, 5, 319, DateTimeKind.Utc).AddTicks(6223), "LastName14", 1, false, null, "USER14@EXAMPLE.COM", "USER14", "AQAAAAIAAYagAAAAEK3JbxnMOU+exC6cOxQLvXvHG6Xt/a7qhEXNftH7DTJLiaC5qZ4fuRAYHF58dVJXaQ==", "+993509998485", false, "https://picsum.photos/seed/user14/200/300", null, new DateTime(2024, 9, 9, 17, 43, 5, 319, DateTimeKind.Utc).AddTicks(6219), null, "RYZH37KPG6EEDGSYWW37NETRG56JM7KG", false, "user14" },
                    { 2015, "Somme about text for something bla bla bla", 0, "Koroglu Rahimov 70", "Baku", null, "ca58d1be-475d-4027-ba7b-52bdfe8ae4b9", new DateTime(2024, 1, 9, 17, 43, 5, 319, DateTimeKind.Utc).AddTicks(6233), new DateTime(2000, 1, 15, 0, 0, 0, 0, DateTimeKind.Unspecified), 1, "user15@example.com", true, "FirstName15", false, new DateTime(2024, 9, 9, 17, 43, 5, 319, DateTimeKind.Utc).AddTicks(6234), "LastName15", 1, false, null, "USER15@EXAMPLE.COM", "USER15", "AQAAAAIAAYagAAAAEK3JbxnMOU+exC6cOxQLvXvHG6Xt/a7qhEXNftH7DTJLiaC5qZ4fuRAYHF58dVJXaQ==", "+993509998485", false, "https://picsum.photos/seed/user15/200/300", null, new DateTime(2024, 9, 9, 17, 43, 5, 319, DateTimeKind.Utc).AddTicks(6230), null, "RYZH37KPG6EEDGSYWW37NETRG56JM7KG", false, "user15" },
                    { 2016, "Somme about text for something bla bla bla", 0, "Koroglu Rahimov 70", "Baku", null, "5760c71c-10af-4ffa-856b-6d8baff4fcf0", new DateTime(2024, 6, 9, 17, 43, 5, 319, DateTimeKind.Utc).AddTicks(6245), new DateTime(2000, 1, 16, 0, 0, 0, 0, DateTimeKind.Unspecified), 1, "user16@example.com", true, "FirstName16", false, new DateTime(2024, 9, 9, 17, 43, 5, 319, DateTimeKind.Utc).AddTicks(6246), "LastName16", 1, false, null, "USER16@EXAMPLE.COM", "USER16", "AQAAAAIAAYagAAAAEK3JbxnMOU+exC6cOxQLvXvHG6Xt/a7qhEXNftH7DTJLiaC5qZ4fuRAYHF58dVJXaQ==", "+993509998485", false, "https://picsum.photos/seed/user16/200/300", null, new DateTime(2024, 9, 9, 17, 43, 5, 319, DateTimeKind.Utc).AddTicks(6242), null, "RYZH37KPG6EEDGSYWW37NETRG56JM7KG", false, "user16" },
                    { 2017, "Somme about text for something bla bla bla", 0, "Koroglu Rahimov 70", "Baku", null, "fbb8eadd-93c0-4ea2-a505-c32c84dd63b4", new DateTime(2023, 11, 9, 17, 43, 5, 319, DateTimeKind.Utc).AddTicks(6259), new DateTime(2000, 1, 17, 0, 0, 0, 0, DateTimeKind.Unspecified), 1, "user17@example.com", true, "FirstName17", false, new DateTime(2024, 9, 9, 17, 43, 5, 319, DateTimeKind.Utc).AddTicks(6259), "LastName17", 1, false, null, "USER17@EXAMPLE.COM", "USER17", "AQAAAAIAAYagAAAAEK3JbxnMOU+exC6cOxQLvXvHG6Xt/a7qhEXNftH7DTJLiaC5qZ4fuRAYHF58dVJXaQ==", "+993509998485", false, "https://picsum.photos/seed/user17/200/300", null, new DateTime(2024, 9, 9, 17, 43, 5, 319, DateTimeKind.Utc).AddTicks(6256), null, "RYZH37KPG6EEDGSYWW37NETRG56JM7KG", false, "user17" },
                    { 2018, "Somme about text for something bla bla bla", 0, "Koroglu Rahimov 70", "Baku", null, "1a8416ed-53e3-41fa-b163-1dc1b7bf9cc6", new DateTime(2024, 1, 9, 17, 43, 5, 319, DateTimeKind.Utc).AddTicks(6274), new DateTime(2000, 1, 18, 0, 0, 0, 0, DateTimeKind.Unspecified), 1, "user18@example.com", true, "FirstName18", false, new DateTime(2024, 9, 9, 17, 43, 5, 319, DateTimeKind.Utc).AddTicks(6275), "LastName18", 1, false, null, "USER18@EXAMPLE.COM", "USER18", "AQAAAAIAAYagAAAAEK3JbxnMOU+exC6cOxQLvXvHG6Xt/a7qhEXNftH7DTJLiaC5qZ4fuRAYHF58dVJXaQ==", "+993509998485", false, "https://picsum.photos/seed/user18/200/300", null, new DateTime(2024, 9, 9, 17, 43, 5, 319, DateTimeKind.Utc).AddTicks(6268), null, "RYZH37KPG6EEDGSYWW37NETRG56JM7KG", false, "user18" },
                    { 2019, "Somme about text for something bla bla bla", 0, "Koroglu Rahimov 70", "Baku", null, "879b533e-41a9-412e-a369-fbb31e210ec9", new DateTime(2023, 11, 9, 17, 43, 5, 319, DateTimeKind.Utc).AddTicks(6286), new DateTime(2000, 1, 19, 0, 0, 0, 0, DateTimeKind.Unspecified), 1, "user19@example.com", true, "FirstName19", false, new DateTime(2024, 9, 9, 17, 43, 5, 319, DateTimeKind.Utc).AddTicks(6287), "LastName19", 1, false, null, "USER19@EXAMPLE.COM", "USER19", "AQAAAAIAAYagAAAAEK3JbxnMOU+exC6cOxQLvXvHG6Xt/a7qhEXNftH7DTJLiaC5qZ4fuRAYHF58dVJXaQ==", "+993509998485", false, "https://picsum.photos/seed/user19/200/300", null, new DateTime(2024, 9, 9, 17, 43, 5, 319, DateTimeKind.Utc).AddTicks(6283), null, "RYZH37KPG6EEDGSYWW37NETRG56JM7KG", false, "user19" },
                    { 2020, "Somme about text for something bla bla bla", 0, "Koroglu Rahimov 70", "Baku", null, "19073e5b-c2e9-4186-905c-aad90110456d", new DateTime(2024, 7, 9, 17, 43, 5, 319, DateTimeKind.Utc).AddTicks(6297), new DateTime(2000, 1, 20, 0, 0, 0, 0, DateTimeKind.Unspecified), 1, "user20@example.com", true, "FirstName20", false, new DateTime(2024, 9, 9, 17, 43, 5, 319, DateTimeKind.Utc).AddTicks(6298), "LastName20", 1, false, null, "USER20@EXAMPLE.COM", "USER20", "AQAAAAIAAYagAAAAEK3JbxnMOU+exC6cOxQLvXvHG6Xt/a7qhEXNftH7DTJLiaC5qZ4fuRAYHF58dVJXaQ==", "+993509998485", false, "https://picsum.photos/seed/user20/200/300", null, new DateTime(2024, 9, 9, 17, 43, 5, 319, DateTimeKind.Utc).AddTicks(6294), null, "RYZH37KPG6EEDGSYWW37NETRG56JM7KG", false, "user20" },
                    { 2021, "Somme about text for something bla bla bla", 0, "Koroglu Rahimov 70", "Baku", "Company Name21", "815953d6-0502-46be-ac17-cbbd4acfeadc", new DateTime(2024, 8, 9, 17, 43, 5, 319, DateTimeKind.Utc).AddTicks(6309), new DateTime(2000, 1, 21, 0, 0, 0, 0, DateTimeKind.Unspecified), 1, "Company21@example.com", true, "CompanyFirstName21", false, new DateTime(2024, 9, 9, 17, 43, 5, 319, DateTimeKind.Utc).AddTicks(6310), "CompanyLastName21", 1, false, null, "COMPANY21@EXAMPLE.COM", "COMPANY21", "AQAAAAIAAYagAAAAEK3JbxnMOU+exC6cOxQLvXvHG6Xt/a7qhEXNftH7DTJLiaC5qZ4fuRAYHF58dVJXaQ==", "+993509998485", false, "https://picsum.photos/seed/user21/200/300", null, new DateTime(2024, 9, 9, 17, 43, 5, 319, DateTimeKind.Utc).AddTicks(6306), null, "RYZH37KPG6EEDGSYWW37NETRG56JM7KG", false, "Company21" },
                    { 2022, "Somme about text for something bla bla bla", 0, "Koroglu Rahimov 70", "Baku", "Company Name22", "a01e62ac-f28c-4507-849b-69ec0a42fb4b", new DateTime(2024, 2, 9, 17, 43, 5, 319, DateTimeKind.Utc).AddTicks(6372), new DateTime(2000, 1, 22, 0, 0, 0, 0, DateTimeKind.Unspecified), 1, "Company22@example.com", true, "CompanyFirstName22", false, new DateTime(2024, 9, 9, 17, 43, 5, 319, DateTimeKind.Utc).AddTicks(6373), "CompanyLastName22", 1, false, null, "COMPANY22@EXAMPLE.COM", "COMPANY22", "AQAAAAIAAYagAAAAEK3JbxnMOU+exC6cOxQLvXvHG6Xt/a7qhEXNftH7DTJLiaC5qZ4fuRAYHF58dVJXaQ==", "+993509998485", false, "https://picsum.photos/seed/user22/200/300", null, new DateTime(2024, 9, 9, 17, 43, 5, 319, DateTimeKind.Utc).AddTicks(6369), null, "RYZH37KPG6EEDGSYWW37NETRG56JM7KG", false, "Company22" },
                    { 2023, "Somme about text for something bla bla bla", 0, "Koroglu Rahimov 70", "Baku", "Company Name23", "bd206b18-cb62-4415-96a2-5eb81868239e", new DateTime(2024, 5, 9, 17, 43, 5, 319, DateTimeKind.Utc).AddTicks(6385), new DateTime(2000, 1, 23, 0, 0, 0, 0, DateTimeKind.Unspecified), 1, "Company23@example.com", true, "CompanyFirstName23", false, new DateTime(2024, 9, 9, 17, 43, 5, 319, DateTimeKind.Utc).AddTicks(6386), "CompanyLastName23", 1, false, null, "COMPANY23@EXAMPLE.COM", "COMPANY23", "AQAAAAIAAYagAAAAEK3JbxnMOU+exC6cOxQLvXvHG6Xt/a7qhEXNftH7DTJLiaC5qZ4fuRAYHF58dVJXaQ==", "+993509998485", false, "https://picsum.photos/seed/user23/200/300", null, new DateTime(2024, 9, 9, 17, 43, 5, 319, DateTimeKind.Utc).AddTicks(6382), null, "RYZH37KPG6EEDGSYWW37NETRG56JM7KG", false, "Company23" },
                    { 2024, "Somme about text for something bla bla bla", 0, "Koroglu Rahimov 70", "Baku", "Company Name24", "ff414d57-11f4-4b55-a8f0-00060fc626fd", new DateTime(2024, 3, 9, 17, 43, 5, 319, DateTimeKind.Utc).AddTicks(6398), new DateTime(2000, 1, 24, 0, 0, 0, 0, DateTimeKind.Unspecified), 1, "Company24@example.com", true, "CompanyFirstName24", false, new DateTime(2024, 9, 9, 17, 43, 5, 319, DateTimeKind.Utc).AddTicks(6399), "CompanyLastName24", 1, false, null, "COMPANY24@EXAMPLE.COM", "COMPANY24", "AQAAAAIAAYagAAAAEK3JbxnMOU+exC6cOxQLvXvHG6Xt/a7qhEXNftH7DTJLiaC5qZ4fuRAYHF58dVJXaQ==", "+993509998485", false, "https://picsum.photos/seed/user24/200/300", null, new DateTime(2024, 9, 9, 17, 43, 5, 319, DateTimeKind.Utc).AddTicks(6395), null, "RYZH37KPG6EEDGSYWW37NETRG56JM7KG", false, "Company24" },
                    { 2025, "Somme about text for something bla bla bla", 0, "Koroglu Rahimov 70", "Baku", "Company Name25", "3338265e-e760-48af-bf13-feaa10ccc387", new DateTime(2024, 1, 9, 17, 43, 5, 319, DateTimeKind.Utc).AddTicks(6410), new DateTime(2000, 1, 25, 0, 0, 0, 0, DateTimeKind.Unspecified), 1, "Company25@example.com", true, "CompanyFirstName25", false, new DateTime(2024, 9, 9, 17, 43, 5, 319, DateTimeKind.Utc).AddTicks(6411), "CompanyLastName25", 1, false, null, "COMPANY25@EXAMPLE.COM", "COMPANY25", "AQAAAAIAAYagAAAAEK3JbxnMOU+exC6cOxQLvXvHG6Xt/a7qhEXNftH7DTJLiaC5qZ4fuRAYHF58dVJXaQ==", "+993509998485", false, "https://picsum.photos/seed/user25/200/300", null, new DateTime(2024, 9, 9, 17, 43, 5, 319, DateTimeKind.Utc).AddTicks(6407), null, "RYZH37KPG6EEDGSYWW37NETRG56JM7KG", false, "Company25" },
                    { 2026, "Somme about text for something bla bla bla", 0, "Koroglu Rahimov 70", "Baku", "Company Name26", "39e04dc0-9ded-4466-adc9-55077e5b73bf", new DateTime(2024, 1, 9, 17, 43, 5, 319, DateTimeKind.Utc).AddTicks(6426), new DateTime(2000, 1, 26, 0, 0, 0, 0, DateTimeKind.Unspecified), 1, "Company26@example.com", true, "CompanyFirstName26", false, new DateTime(2024, 9, 9, 17, 43, 5, 319, DateTimeKind.Utc).AddTicks(6427), "CompanyLastName26", 1, false, null, "COMPANY26@EXAMPLE.COM", "COMPANY26", "AQAAAAIAAYagAAAAEK3JbxnMOU+exC6cOxQLvXvHG6Xt/a7qhEXNftH7DTJLiaC5qZ4fuRAYHF58dVJXaQ==", "+993509998485", false, "https://picsum.photos/seed/user26/200/300", null, new DateTime(2024, 9, 9, 17, 43, 5, 319, DateTimeKind.Utc).AddTicks(6420), null, "RYZH37KPG6EEDGSYWW37NETRG56JM7KG", false, "Company26" },
                    { 2027, "Somme about text for something bla bla bla", 0, "Koroglu Rahimov 70", "Baku", "Company Name27", "d2f9d83f-6a53-4685-9da9-92b0d6e8ba47", new DateTime(2024, 8, 9, 17, 43, 5, 319, DateTimeKind.Utc).AddTicks(6439), new DateTime(2000, 1, 27, 0, 0, 0, 0, DateTimeKind.Unspecified), 1, "Company27@example.com", true, "CompanyFirstName27", false, new DateTime(2024, 9, 9, 17, 43, 5, 319, DateTimeKind.Utc).AddTicks(6439), "CompanyLastName27", 1, false, null, "COMPANY27@EXAMPLE.COM", "COMPANY27", "AQAAAAIAAYagAAAAEK3JbxnMOU+exC6cOxQLvXvHG6Xt/a7qhEXNftH7DTJLiaC5qZ4fuRAYHF58dVJXaQ==", "+993509998485", false, "https://picsum.photos/seed/user27/200/300", null, new DateTime(2024, 9, 9, 17, 43, 5, 319, DateTimeKind.Utc).AddTicks(6436), null, "RYZH37KPG6EEDGSYWW37NETRG56JM7KG", false, "Company27" },
                    { 2028, "Somme about text for something bla bla bla", 0, "Koroglu Rahimov 70", "Baku", "Company Name28", "a155818c-aa0e-4e43-a428-804cb62e4d7a", new DateTime(2023, 11, 9, 17, 43, 5, 319, DateTimeKind.Utc).AddTicks(6452), new DateTime(2000, 1, 28, 0, 0, 0, 0, DateTimeKind.Unspecified), 1, "Company28@example.com", true, "CompanyFirstName28", false, new DateTime(2024, 9, 9, 17, 43, 5, 319, DateTimeKind.Utc).AddTicks(6453), "CompanyLastName28", 1, false, null, "COMPANY28@EXAMPLE.COM", "COMPANY28", "AQAAAAIAAYagAAAAEK3JbxnMOU+exC6cOxQLvXvHG6Xt/a7qhEXNftH7DTJLiaC5qZ4fuRAYHF58dVJXaQ==", "+993509998485", false, "https://picsum.photos/seed/user28/200/300", null, new DateTime(2024, 9, 9, 17, 43, 5, 319, DateTimeKind.Utc).AddTicks(6448), null, "RYZH37KPG6EEDGSYWW37NETRG56JM7KG", false, "Company28" },
                    { 2029, "Somme about text for something bla bla bla", 0, "Koroglu Rahimov 70", "Baku", "Company Name29", "c5edd2de-44cf-4fa9-ac56-587a14e3f331", new DateTime(2024, 3, 9, 17, 43, 5, 319, DateTimeKind.Utc).AddTicks(6465), new DateTime(2000, 1, 29, 0, 0, 0, 0, DateTimeKind.Unspecified), 1, "Company29@example.com", true, "CompanyFirstName29", false, new DateTime(2024, 9, 9, 17, 43, 5, 319, DateTimeKind.Utc).AddTicks(6465), "CompanyLastName29", 1, false, null, "COMPANY29@EXAMPLE.COM", "COMPANY29", "AQAAAAIAAYagAAAAEK3JbxnMOU+exC6cOxQLvXvHG6Xt/a7qhEXNftH7DTJLiaC5qZ4fuRAYHF58dVJXaQ==", "+993509998485", false, "https://picsum.photos/seed/user29/200/300", null, new DateTime(2024, 9, 9, 17, 43, 5, 319, DateTimeKind.Utc).AddTicks(6462), null, "RYZH37KPG6EEDGSYWW37NETRG56JM7KG", false, "Company29" },
                    { 2030, "Somme about text for something bla bla bla", 0, "Koroglu Rahimov 70", "Baku", "Company Name30", "9c4b68d0-1b93-4a29-b499-5e833b1b4012", new DateTime(2024, 6, 9, 17, 43, 5, 319, DateTimeKind.Utc).AddTicks(6477), new DateTime(2000, 1, 30, 0, 0, 0, 0, DateTimeKind.Unspecified), 1, "Company30@example.com", true, "CompanyFirstName30", false, new DateTime(2024, 9, 9, 17, 43, 5, 319, DateTimeKind.Utc).AddTicks(6477), "CompanyLastName30", 1, false, null, "COMPANY30@EXAMPLE.COM", "COMPANY30", "AQAAAAIAAYagAAAAEK3JbxnMOU+exC6cOxQLvXvHG6Xt/a7qhEXNftH7DTJLiaC5qZ4fuRAYHF58dVJXaQ==", "+993509998485", false, "https://picsum.photos/seed/user30/200/300", null, new DateTime(2024, 9, 9, 17, 43, 5, 319, DateTimeKind.Utc).AddTicks(6474), null, "RYZH37KPG6EEDGSYWW37NETRG56JM7KG", false, "Company30" },
                    { 2031, "Somme about text for something bla bla bla", 0, "Koroglu Rahimov 70", "Baku", "Company Name31", "568c6973-4399-4c09-aaaf-880754c150da", new DateTime(2024, 2, 9, 17, 43, 5, 319, DateTimeKind.Utc).AddTicks(6526), new DateTime(2000, 1, 31, 0, 0, 0, 0, DateTimeKind.Unspecified), 1, "Company31@example.com", true, "CompanyFirstName31", false, new DateTime(2024, 9, 9, 17, 43, 5, 319, DateTimeKind.Utc).AddTicks(6527), "CompanyLastName31", 1, false, null, "COMPANY31@EXAMPLE.COM", "COMPANY31", "AQAAAAIAAYagAAAAEK3JbxnMOU+exC6cOxQLvXvHG6Xt/a7qhEXNftH7DTJLiaC5qZ4fuRAYHF58dVJXaQ==", "+993509998485", false, "https://picsum.photos/seed/user31/200/300", null, new DateTime(2024, 9, 9, 17, 43, 5, 319, DateTimeKind.Utc).AddTicks(6523), null, "RYZH37KPG6EEDGSYWW37NETRG56JM7KG", false, "Company31" },
                    { 2032, "Somme about text for something bla bla bla", 0, "Koroglu Rahimov 70", "Baku", "Company Name32", "dbed0c3d-fd8f-4dc2-b231-fdd4f87ff4b2", new DateTime(2024, 8, 9, 17, 43, 5, 319, DateTimeKind.Utc).AddTicks(6539), new DateTime(2000, 2, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 1, "Company32@example.com", true, "CompanyFirstName32", false, new DateTime(2024, 9, 9, 17, 43, 5, 319, DateTimeKind.Utc).AddTicks(6539), "CompanyLastName32", 1, false, null, "COMPANY32@EXAMPLE.COM", "COMPANY32", "AQAAAAIAAYagAAAAEK3JbxnMOU+exC6cOxQLvXvHG6Xt/a7qhEXNftH7DTJLiaC5qZ4fuRAYHF58dVJXaQ==", "+993509998485", false, "https://picsum.photos/seed/user32/200/300", null, new DateTime(2024, 9, 9, 17, 43, 5, 319, DateTimeKind.Utc).AddTicks(6536), null, "RYZH37KPG6EEDGSYWW37NETRG56JM7KG", false, "Company32" },
                    { 2033, "Somme about text for something bla bla bla", 0, "Koroglu Rahimov 70", "Baku", "Company Name33", "21493008-711d-4d6e-91a7-18aafcf6742e", new DateTime(2024, 8, 9, 17, 43, 5, 319, DateTimeKind.Utc).AddTicks(6553), new DateTime(2000, 2, 2, 0, 0, 0, 0, DateTimeKind.Unspecified), 1, "Company33@example.com", true, "CompanyFirstName33", false, new DateTime(2024, 9, 9, 17, 43, 5, 319, DateTimeKind.Utc).AddTicks(6554), "CompanyLastName33", 1, false, null, "COMPANY33@EXAMPLE.COM", "COMPANY33", "AQAAAAIAAYagAAAAEK3JbxnMOU+exC6cOxQLvXvHG6Xt/a7qhEXNftH7DTJLiaC5qZ4fuRAYHF58dVJXaQ==", "+993509998485", false, "https://picsum.photos/seed/user33/200/300", null, new DateTime(2024, 9, 9, 17, 43, 5, 319, DateTimeKind.Utc).AddTicks(6550), null, "RYZH37KPG6EEDGSYWW37NETRG56JM7KG", false, "Company33" },
                    { 2034, "Somme about text for something bla bla bla", 0, "Koroglu Rahimov 70", "Baku", "Company Name34", "a4bf0a56-7cc9-417f-8d90-23c9683971b8", new DateTime(2024, 1, 9, 17, 43, 5, 319, DateTimeKind.Utc).AddTicks(6569), new DateTime(2000, 2, 3, 0, 0, 0, 0, DateTimeKind.Unspecified), 1, "Company34@example.com", true, "CompanyFirstName34", false, new DateTime(2024, 9, 9, 17, 43, 5, 319, DateTimeKind.Utc).AddTicks(6570), "CompanyLastName34", 1, false, null, "COMPANY34@EXAMPLE.COM", "COMPANY34", "AQAAAAIAAYagAAAAEK3JbxnMOU+exC6cOxQLvXvHG6Xt/a7qhEXNftH7DTJLiaC5qZ4fuRAYHF58dVJXaQ==", "+993509998485", false, "https://picsum.photos/seed/user34/200/300", null, new DateTime(2024, 9, 9, 17, 43, 5, 319, DateTimeKind.Utc).AddTicks(6563), null, "RYZH37KPG6EEDGSYWW37NETRG56JM7KG", false, "Company34" },
                    { 2035, "Somme about text for something bla bla bla", 0, "Koroglu Rahimov 70", "Baku", "Company Name35", "a0d52b16-f3e0-41bc-afb8-415f30bcfa73", new DateTime(2024, 2, 9, 17, 43, 5, 319, DateTimeKind.Utc).AddTicks(6582), new DateTime(2000, 2, 4, 0, 0, 0, 0, DateTimeKind.Unspecified), 1, "Company35@example.com", true, "CompanyFirstName35", false, new DateTime(2024, 9, 9, 17, 43, 5, 319, DateTimeKind.Utc).AddTicks(6583), "CompanyLastName35", 1, false, null, "COMPANY35@EXAMPLE.COM", "COMPANY35", "AQAAAAIAAYagAAAAEK3JbxnMOU+exC6cOxQLvXvHG6Xt/a7qhEXNftH7DTJLiaC5qZ4fuRAYHF58dVJXaQ==", "+993509998485", false, "https://picsum.photos/seed/user35/200/300", null, new DateTime(2024, 9, 9, 17, 43, 5, 319, DateTimeKind.Utc).AddTicks(6579), null, "RYZH37KPG6EEDGSYWW37NETRG56JM7KG", false, "Company35" },
                    { 2036, "Somme about text for something bla bla bla", 0, "Koroglu Rahimov 70", "Baku", "Company Name36", "86317f10-2503-4650-b26d-80b27a41f037", new DateTime(2024, 7, 9, 17, 43, 5, 319, DateTimeKind.Utc).AddTicks(6595), new DateTime(2000, 2, 5, 0, 0, 0, 0, DateTimeKind.Unspecified), 1, "Company36@example.com", true, "CompanyFirstName36", false, new DateTime(2024, 9, 9, 17, 43, 5, 319, DateTimeKind.Utc).AddTicks(6595), "CompanyLastName36", 1, false, null, "COMPANY36@EXAMPLE.COM", "COMPANY36", "AQAAAAIAAYagAAAAEK3JbxnMOU+exC6cOxQLvXvHG6Xt/a7qhEXNftH7DTJLiaC5qZ4fuRAYHF58dVJXaQ==", "+993509998485", false, "https://picsum.photos/seed/user36/200/300", null, new DateTime(2024, 9, 9, 17, 43, 5, 319, DateTimeKind.Utc).AddTicks(6592), null, "RYZH37KPG6EEDGSYWW37NETRG56JM7KG", false, "Company36" },
                    { 2037, "Somme about text for something bla bla bla", 0, "Koroglu Rahimov 70", "Baku", "Company Name37", "a9d2d6fc-8a33-4bfe-94c6-825b11cdd194", new DateTime(2023, 10, 9, 17, 43, 5, 319, DateTimeKind.Utc).AddTicks(6607), new DateTime(2000, 2, 6, 0, 0, 0, 0, DateTimeKind.Unspecified), 1, "Company37@example.com", true, "CompanyFirstName37", false, new DateTime(2024, 9, 9, 17, 43, 5, 319, DateTimeKind.Utc).AddTicks(6608), "CompanyLastName37", 1, false, null, "COMPANY37@EXAMPLE.COM", "COMPANY37", "AQAAAAIAAYagAAAAEK3JbxnMOU+exC6cOxQLvXvHG6Xt/a7qhEXNftH7DTJLiaC5qZ4fuRAYHF58dVJXaQ==", "+993509998485", false, "https://picsum.photos/seed/user37/200/300", null, new DateTime(2024, 9, 9, 17, 43, 5, 319, DateTimeKind.Utc).AddTicks(6604), null, "RYZH37KPG6EEDGSYWW37NETRG56JM7KG", false, "Company37" },
                    { 2038, "Somme about text for something bla bla bla", 0, "Koroglu Rahimov 70", "Baku", "Company Name38", "b0383b49-3935-4640-a477-186be309edb7", new DateTime(2024, 1, 9, 17, 43, 5, 319, DateTimeKind.Utc).AddTicks(6620), new DateTime(2000, 2, 7, 0, 0, 0, 0, DateTimeKind.Unspecified), 1, "Company38@example.com", true, "CompanyFirstName38", false, new DateTime(2024, 9, 9, 17, 43, 5, 319, DateTimeKind.Utc).AddTicks(6621), "CompanyLastName38", 1, false, null, "COMPANY38@EXAMPLE.COM", "COMPANY38", "AQAAAAIAAYagAAAAEK3JbxnMOU+exC6cOxQLvXvHG6Xt/a7qhEXNftH7DTJLiaC5qZ4fuRAYHF58dVJXaQ==", "+993509998485", false, "https://picsum.photos/seed/user38/200/300", null, new DateTime(2024, 9, 9, 17, 43, 5, 319, DateTimeKind.Utc).AddTicks(6617), null, "RYZH37KPG6EEDGSYWW37NETRG56JM7KG", false, "Company38" },
                    { 2039, "Somme about text for something bla bla bla", 0, "Koroglu Rahimov 70", "Baku", "Company Name39", "190bcf65-22fe-461d-8bf8-a5664b48a5f6", new DateTime(2024, 1, 9, 17, 43, 5, 319, DateTimeKind.Utc).AddTicks(6655), new DateTime(2000, 2, 8, 0, 0, 0, 0, DateTimeKind.Unspecified), 1, "Company39@example.com", true, "CompanyFirstName39", false, new DateTime(2024, 9, 9, 17, 43, 5, 319, DateTimeKind.Utc).AddTicks(6656), "CompanyLastName39", 1, false, null, "COMPANY39@EXAMPLE.COM", "COMPANY39", "AQAAAAIAAYagAAAAEK3JbxnMOU+exC6cOxQLvXvHG6Xt/a7qhEXNftH7DTJLiaC5qZ4fuRAYHF58dVJXaQ==", "+993509998485", false, "https://picsum.photos/seed/user39/200/300", null, new DateTime(2024, 9, 9, 17, 43, 5, 319, DateTimeKind.Utc).AddTicks(6652), null, "RYZH37KPG6EEDGSYWW37NETRG56JM7KG", false, "Company39" },
                    { 2040, "Somme about text for something bla bla bla", 0, "Koroglu Rahimov 70", "Baku", "Company Name40", "b8f50280-b385-46d4-8a74-7a894a5ca861", new DateTime(2023, 12, 9, 17, 43, 5, 319, DateTimeKind.Utc).AddTicks(6668), new DateTime(2000, 2, 9, 0, 0, 0, 0, DateTimeKind.Unspecified), 1, "Company40@example.com", true, "CompanyFirstName40", false, new DateTime(2024, 9, 9, 17, 43, 5, 319, DateTimeKind.Utc).AddTicks(6669), "CompanyLastName40", 1, false, null, "COMPANY40@EXAMPLE.COM", "COMPANY40", "AQAAAAIAAYagAAAAEK3JbxnMOU+exC6cOxQLvXvHG6Xt/a7qhEXNftH7DTJLiaC5qZ4fuRAYHF58dVJXaQ==", "+993509998485", false, "https://picsum.photos/seed/user40/200/300", null, new DateTime(2024, 9, 9, 17, 43, 5, 319, DateTimeKind.Utc).AddTicks(6665), null, "RYZH37KPG6EEDGSYWW37NETRG56JM7KG", false, "Company40" },
                    { 2041, "Somme about text for something bla bla bla", 0, "Koroglu Rahimov 70", "Baku", null, "7c4e6b44-f87a-407d-8f25-90d193d65e01", new DateTime(2023, 12, 9, 17, 43, 5, 319, DateTimeKind.Utc).AddTicks(6681), new DateTime(2000, 2, 10, 0, 0, 0, 0, DateTimeKind.Unspecified), 1, "Vet41@example.com", true, "VetFirstName41", false, new DateTime(2024, 9, 9, 17, 43, 5, 319, DateTimeKind.Utc).AddTicks(6682), "VetLastName41", 1, false, null, "VET41@EXAMPLE.COM", "VET41", "AQAAAAIAAYagAAAAEK3JbxnMOU+exC6cOxQLvXvHG6Xt/a7qhEXNftH7DTJLiaC5qZ4fuRAYHF58dVJXaQ==", "+993509998485", false, "https://picsum.photos/seed/user41/200/300", null, new DateTime(2024, 9, 9, 17, 43, 5, 319, DateTimeKind.Utc).AddTicks(6678), null, "RYZH37KPG6EEDGSYWW37NETRG56JM7KG", false, "Vet41" },
                    { 2042, "Somme about text for something bla bla bla", 0, "Koroglu Rahimov 70", "Baku", null, "9c1389a1-fe14-49ec-bf05-73fa7ffc6e1d", new DateTime(2023, 11, 9, 17, 43, 5, 319, DateTimeKind.Utc).AddTicks(6701), new DateTime(2000, 2, 11, 0, 0, 0, 0, DateTimeKind.Unspecified), 1, "Vet42@example.com", true, "VetFirstName42", false, new DateTime(2024, 9, 9, 17, 43, 5, 319, DateTimeKind.Utc).AddTicks(6701), "VetLastName42", 1, false, null, "VET42@EXAMPLE.COM", "VET42", "AQAAAAIAAYagAAAAEK3JbxnMOU+exC6cOxQLvXvHG6Xt/a7qhEXNftH7DTJLiaC5qZ4fuRAYHF58dVJXaQ==", "+993509998485", false, "https://picsum.photos/seed/user42/200/300", null, new DateTime(2024, 9, 9, 17, 43, 5, 319, DateTimeKind.Utc).AddTicks(6695), null, "RYZH37KPG6EEDGSYWW37NETRG56JM7KG", false, "Vet42" },
                    { 2043, "Somme about text for something bla bla bla", 0, "Koroglu Rahimov 70", "Baku", null, "c43c41b6-bde3-459a-8828-aeb1eb99cc9a", new DateTime(2023, 11, 9, 17, 43, 5, 319, DateTimeKind.Utc).AddTicks(6713), new DateTime(2000, 2, 12, 0, 0, 0, 0, DateTimeKind.Unspecified), 1, "Vet43@example.com", true, "VetFirstName43", false, new DateTime(2024, 9, 9, 17, 43, 5, 319, DateTimeKind.Utc).AddTicks(6714), "VetLastName43", 1, false, null, "VET43@EXAMPLE.COM", "VET43", "AQAAAAIAAYagAAAAEK3JbxnMOU+exC6cOxQLvXvHG6Xt/a7qhEXNftH7DTJLiaC5qZ4fuRAYHF58dVJXaQ==", "+993509998485", false, "https://picsum.photos/seed/user43/200/300", null, new DateTime(2024, 9, 9, 17, 43, 5, 319, DateTimeKind.Utc).AddTicks(6710), null, "RYZH37KPG6EEDGSYWW37NETRG56JM7KG", false, "Vet43" },
                    { 2044, "Somme about text for something bla bla bla", 0, "Koroglu Rahimov 70", "Baku", null, "9068600c-c476-48a6-8d25-efb4377cc2c3", new DateTime(2023, 10, 9, 17, 43, 5, 319, DateTimeKind.Utc).AddTicks(6724), new DateTime(2000, 2, 13, 0, 0, 0, 0, DateTimeKind.Unspecified), 1, "Vet44@example.com", true, "VetFirstName44", false, new DateTime(2024, 9, 9, 17, 43, 5, 319, DateTimeKind.Utc).AddTicks(6725), "VetLastName44", 1, false, null, "VET44@EXAMPLE.COM", "VET44", "AQAAAAIAAYagAAAAEK3JbxnMOU+exC6cOxQLvXvHG6Xt/a7qhEXNftH7DTJLiaC5qZ4fuRAYHF58dVJXaQ==", "+993509998485", false, "https://picsum.photos/seed/user44/200/300", null, new DateTime(2024, 9, 9, 17, 43, 5, 319, DateTimeKind.Utc).AddTicks(6722), null, "RYZH37KPG6EEDGSYWW37NETRG56JM7KG", false, "Vet44" },
                    { 2045, "Somme about text for something bla bla bla", 0, "Koroglu Rahimov 70", "Baku", null, "c9357b67-afc2-4b86-a08c-b5e16f253265", new DateTime(2024, 2, 9, 17, 43, 5, 319, DateTimeKind.Utc).AddTicks(6736), new DateTime(2000, 2, 14, 0, 0, 0, 0, DateTimeKind.Unspecified), 1, "Vet45@example.com", true, "VetFirstName45", false, new DateTime(2024, 9, 9, 17, 43, 5, 319, DateTimeKind.Utc).AddTicks(6737), "VetLastName45", 1, false, null, "VET45@EXAMPLE.COM", "VET45", "AQAAAAIAAYagAAAAEK3JbxnMOU+exC6cOxQLvXvHG6Xt/a7qhEXNftH7DTJLiaC5qZ4fuRAYHF58dVJXaQ==", "+993509998485", false, "https://picsum.photos/seed/user45/200/300", null, new DateTime(2024, 9, 9, 17, 43, 5, 319, DateTimeKind.Utc).AddTicks(6733), null, "RYZH37KPG6EEDGSYWW37NETRG56JM7KG", false, "Vet45" },
                    { 2046, "Somme about text for something bla bla bla", 0, "Koroglu Rahimov 70", "Baku", null, "a6b21a6a-4d38-4d4f-a7f3-d63dbdcd9e1c", new DateTime(2024, 5, 9, 17, 43, 5, 319, DateTimeKind.Utc).AddTicks(6748), new DateTime(2000, 2, 15, 0, 0, 0, 0, DateTimeKind.Unspecified), 1, "Vet46@example.com", true, "VetFirstName46", false, new DateTime(2024, 9, 9, 17, 43, 5, 319, DateTimeKind.Utc).AddTicks(6749), "VetLastName46", 1, false, null, "VET46@EXAMPLE.COM", "VET46", "AQAAAAIAAYagAAAAEK3JbxnMOU+exC6cOxQLvXvHG6Xt/a7qhEXNftH7DTJLiaC5qZ4fuRAYHF58dVJXaQ==", "+993509998485", false, "https://picsum.photos/seed/user46/200/300", null, new DateTime(2024, 9, 9, 17, 43, 5, 319, DateTimeKind.Utc).AddTicks(6745), null, "RYZH37KPG6EEDGSYWW37NETRG56JM7KG", false, "Vet46" },
                    { 2047, "Somme about text for something bla bla bla", 0, "Koroglu Rahimov 70", "Baku", null, "280d5328-0e8d-45b6-9745-42d9cdce707b", new DateTime(2024, 2, 9, 17, 43, 5, 319, DateTimeKind.Utc).AddTicks(6759), new DateTime(2000, 2, 16, 0, 0, 0, 0, DateTimeKind.Unspecified), 1, "Vet47@example.com", true, "VetFirstName47", false, new DateTime(2024, 9, 9, 17, 43, 5, 319, DateTimeKind.Utc).AddTicks(6760), "VetLastName47", 1, false, null, "VET47@EXAMPLE.COM", "VET47", "AQAAAAIAAYagAAAAEK3JbxnMOU+exC6cOxQLvXvHG6Xt/a7qhEXNftH7DTJLiaC5qZ4fuRAYHF58dVJXaQ==", "+993509998485", false, "https://picsum.photos/seed/user47/200/300", null, new DateTime(2024, 9, 9, 17, 43, 5, 319, DateTimeKind.Utc).AddTicks(6757), null, "RYZH37KPG6EEDGSYWW37NETRG56JM7KG", false, "Vet47" },
                    { 2048, "Somme about text for something bla bla bla", 0, "Koroglu Rahimov 70", "Baku", null, "e7ee9edc-c9c1-4215-8075-c4db1ab3990d", new DateTime(2024, 6, 9, 17, 43, 5, 319, DateTimeKind.Utc).AddTicks(6771), new DateTime(2000, 2, 17, 0, 0, 0, 0, DateTimeKind.Unspecified), 1, "Vet48@example.com", true, "VetFirstName48", false, new DateTime(2024, 9, 9, 17, 43, 5, 319, DateTimeKind.Utc).AddTicks(6772), "VetLastName48", 1, false, null, "VET48@EXAMPLE.COM", "VET48", "AQAAAAIAAYagAAAAEK3JbxnMOU+exC6cOxQLvXvHG6Xt/a7qhEXNftH7DTJLiaC5qZ4fuRAYHF58dVJXaQ==", "+993509998485", false, "https://picsum.photos/seed/user48/200/300", null, new DateTime(2024, 9, 9, 17, 43, 5, 319, DateTimeKind.Utc).AddTicks(6768), null, "RYZH37KPG6EEDGSYWW37NETRG56JM7KG", false, "Vet48" },
                    { 2049, "Somme about text for something bla bla bla", 0, "Koroglu Rahimov 70", "Baku", null, "8529bcf6-18fd-4fb7-a030-8c23a10639ea", new DateTime(2024, 5, 9, 17, 43, 5, 319, DateTimeKind.Utc).AddTicks(6846), new DateTime(2000, 2, 18, 0, 0, 0, 0, DateTimeKind.Unspecified), 1, "Vet49@example.com", true, "VetFirstName49", false, new DateTime(2024, 9, 9, 17, 43, 5, 319, DateTimeKind.Utc).AddTicks(6847), "VetLastName49", 1, false, null, "VET49@EXAMPLE.COM", "VET49", "AQAAAAIAAYagAAAAEK3JbxnMOU+exC6cOxQLvXvHG6Xt/a7qhEXNftH7DTJLiaC5qZ4fuRAYHF58dVJXaQ==", "+993509998485", false, "https://picsum.photos/seed/user49/200/300", null, new DateTime(2024, 9, 9, 17, 43, 5, 319, DateTimeKind.Utc).AddTicks(6843), null, "RYZH37KPG6EEDGSYWW37NETRG56JM7KG", false, "Vet49" },
                    { 2050, "Somme about text for something bla bla bla", 0, "Koroglu Rahimov 70", "Baku", null, "33fc9e75-2e42-47c0-a7f9-d7d8d7b2c640", new DateTime(2024, 6, 9, 17, 43, 5, 319, DateTimeKind.Utc).AddTicks(6861), new DateTime(2000, 2, 19, 0, 0, 0, 0, DateTimeKind.Unspecified), 1, "Vet50@example.com", true, "VetFirstName50", false, new DateTime(2024, 9, 9, 17, 43, 5, 319, DateTimeKind.Utc).AddTicks(6862), "VetLastName50", 1, false, null, "VET50@EXAMPLE.COM", "VET50", "AQAAAAIAAYagAAAAEK3JbxnMOU+exC6cOxQLvXvHG6Xt/a7qhEXNftH7DTJLiaC5qZ4fuRAYHF58dVJXaQ==", "+993509998485", false, "https://picsum.photos/seed/user50/200/300", null, new DateTime(2024, 9, 9, 17, 43, 5, 319, DateTimeKind.Utc).AddTicks(6855), null, "RYZH37KPG6EEDGSYWW37NETRG56JM7KG", false, "Vet50" },
                    { 2051, "Somme about text for something bla bla bla", 0, "Koroglu Rahimov 70", "Baku", null, "9dc62516-c415-49d9-a4a1-567c481e7e2e", new DateTime(2024, 6, 9, 17, 43, 5, 319, DateTimeKind.Utc).AddTicks(6873), new DateTime(2000, 2, 20, 0, 0, 0, 0, DateTimeKind.Unspecified), 1, "Vet51@example.com", true, "VetFirstName51", false, new DateTime(2024, 9, 9, 17, 43, 5, 319, DateTimeKind.Utc).AddTicks(6874), "VetLastName51", 1, false, null, "VET51@EXAMPLE.COM", "VET51", "AQAAAAIAAYagAAAAEK3JbxnMOU+exC6cOxQLvXvHG6Xt/a7qhEXNftH7DTJLiaC5qZ4fuRAYHF58dVJXaQ==", "+993509998485", false, "https://picsum.photos/seed/user51/200/300", null, new DateTime(2024, 9, 9, 17, 43, 5, 319, DateTimeKind.Utc).AddTicks(6870), null, "RYZH37KPG6EEDGSYWW37NETRG56JM7KG", false, "Vet51" },
                    { 2052, "Somme about text for something bla bla bla", 0, "Koroglu Rahimov 70", "Baku", null, "344204e2-0616-4c50-9d00-5b50d65d1332", new DateTime(2024, 5, 9, 17, 43, 5, 319, DateTimeKind.Utc).AddTicks(6885), new DateTime(2000, 2, 21, 0, 0, 0, 0, DateTimeKind.Unspecified), 1, "Vet52@example.com", true, "VetFirstName52", false, new DateTime(2024, 9, 9, 17, 43, 5, 319, DateTimeKind.Utc).AddTicks(6886), "VetLastName52", 1, false, null, "VET52@EXAMPLE.COM", "VET52", "AQAAAAIAAYagAAAAEK3JbxnMOU+exC6cOxQLvXvHG6Xt/a7qhEXNftH7DTJLiaC5qZ4fuRAYHF58dVJXaQ==", "+993509998485", false, "https://picsum.photos/seed/user52/200/300", null, new DateTime(2024, 9, 9, 17, 43, 5, 319, DateTimeKind.Utc).AddTicks(6882), null, "RYZH37KPG6EEDGSYWW37NETRG56JM7KG", false, "Vet52" },
                    { 2053, "Somme about text for something bla bla bla", 0, "Koroglu Rahimov 70", "Baku", null, "f20eed5e-4121-45a1-b321-b42287f08df4", new DateTime(2023, 11, 9, 17, 43, 5, 319, DateTimeKind.Utc).AddTicks(6897), new DateTime(2000, 2, 22, 0, 0, 0, 0, DateTimeKind.Unspecified), 1, "Vet53@example.com", true, "VetFirstName53", false, new DateTime(2024, 9, 9, 17, 43, 5, 319, DateTimeKind.Utc).AddTicks(6898), "VetLastName53", 1, false, null, "VET53@EXAMPLE.COM", "VET53", "AQAAAAIAAYagAAAAEK3JbxnMOU+exC6cOxQLvXvHG6Xt/a7qhEXNftH7DTJLiaC5qZ4fuRAYHF58dVJXaQ==", "+993509998485", false, "https://picsum.photos/seed/user53/200/300", null, new DateTime(2024, 9, 9, 17, 43, 5, 319, DateTimeKind.Utc).AddTicks(6894), null, "RYZH37KPG6EEDGSYWW37NETRG56JM7KG", false, "Vet53" },
                    { 2054, "Somme about text for something bla bla bla", 0, "Koroglu Rahimov 70", "Baku", null, "1879bbf3-1aff-4743-9bf3-7b29a917f79d", new DateTime(2024, 6, 9, 17, 43, 5, 319, DateTimeKind.Utc).AddTicks(6908), new DateTime(2000, 2, 23, 0, 0, 0, 0, DateTimeKind.Unspecified), 1, "Vet54@example.com", true, "VetFirstName54", false, new DateTime(2024, 9, 9, 17, 43, 5, 319, DateTimeKind.Utc).AddTicks(6909), "VetLastName54", 1, false, null, "VET54@EXAMPLE.COM", "VET54", "AQAAAAIAAYagAAAAEK3JbxnMOU+exC6cOxQLvXvHG6Xt/a7qhEXNftH7DTJLiaC5qZ4fuRAYHF58dVJXaQ==", "+993509998485", false, "https://picsum.photos/seed/user54/200/300", null, new DateTime(2024, 9, 9, 17, 43, 5, 319, DateTimeKind.Utc).AddTicks(6906), null, "RYZH37KPG6EEDGSYWW37NETRG56JM7KG", false, "Vet54" },
                    { 2055, "Somme about text for something bla bla bla", 0, "Koroglu Rahimov 70", "Baku", null, "b23b0c2b-591e-43d4-b15e-04c6213183d5", new DateTime(2024, 7, 9, 17, 43, 5, 319, DateTimeKind.Utc).AddTicks(6920), new DateTime(2000, 2, 24, 0, 0, 0, 0, DateTimeKind.Unspecified), 1, "Vet55@example.com", true, "VetFirstName55", false, new DateTime(2024, 9, 9, 17, 43, 5, 319, DateTimeKind.Utc).AddTicks(6921), "VetLastName55", 1, false, null, "VET55@EXAMPLE.COM", "VET55", "AQAAAAIAAYagAAAAEK3JbxnMOU+exC6cOxQLvXvHG6Xt/a7qhEXNftH7DTJLiaC5qZ4fuRAYHF58dVJXaQ==", "+993509998485", false, "https://picsum.photos/seed/user55/200/300", null, new DateTime(2024, 9, 9, 17, 43, 5, 319, DateTimeKind.Utc).AddTicks(6917), null, "RYZH37KPG6EEDGSYWW37NETRG56JM7KG", false, "Vet55" },
                    { 2056, "Somme about text for something bla bla bla", 0, "Koroglu Rahimov 70", "Baku", null, "b99b53b6-e093-4559-a38a-0f5678ba0329", new DateTime(2023, 11, 9, 17, 43, 5, 319, DateTimeKind.Utc).AddTicks(6932), new DateTime(2000, 2, 25, 0, 0, 0, 0, DateTimeKind.Unspecified), 1, "Vet56@example.com", true, "VetFirstName56", false, new DateTime(2024, 9, 9, 17, 43, 5, 319, DateTimeKind.Utc).AddTicks(6933), "VetLastName56", 1, false, null, "VET56@EXAMPLE.COM", "VET56", "AQAAAAIAAYagAAAAEK3JbxnMOU+exC6cOxQLvXvHG6Xt/a7qhEXNftH7DTJLiaC5qZ4fuRAYHF58dVJXaQ==", "+993509998485", false, "https://picsum.photos/seed/user56/200/300", null, new DateTime(2024, 9, 9, 17, 43, 5, 319, DateTimeKind.Utc).AddTicks(6929), null, "RYZH37KPG6EEDGSYWW37NETRG56JM7KG", false, "Vet56" },
                    { 2057, "Somme about text for something bla bla bla", 0, "Koroglu Rahimov 70", "Baku", null, "8d81a453-29fa-4919-8e56-8a25309ec361", new DateTime(2024, 4, 9, 17, 43, 5, 319, DateTimeKind.Utc).AddTicks(6944), new DateTime(2000, 2, 26, 0, 0, 0, 0, DateTimeKind.Unspecified), 1, "Vet57@example.com", true, "VetFirstName57", false, new DateTime(2024, 9, 9, 17, 43, 5, 319, DateTimeKind.Utc).AddTicks(6945), "VetLastName57", 1, false, null, "VET57@EXAMPLE.COM", "VET57", "AQAAAAIAAYagAAAAEK3JbxnMOU+exC6cOxQLvXvHG6Xt/a7qhEXNftH7DTJLiaC5qZ4fuRAYHF58dVJXaQ==", "+993509998485", false, "https://picsum.photos/seed/user57/200/300", null, new DateTime(2024, 9, 9, 17, 43, 5, 319, DateTimeKind.Utc).AddTicks(6941), null, "RYZH37KPG6EEDGSYWW37NETRG56JM7KG", false, "Vet57" },
                    { 2058, "Somme about text for something bla bla bla", 0, "Koroglu Rahimov 70", "Baku", null, "c4a86733-8f76-4d4a-9c59-90bd4a1a9b18", new DateTime(2023, 10, 9, 17, 43, 5, 319, DateTimeKind.Utc).AddTicks(6959), new DateTime(2000, 2, 27, 0, 0, 0, 0, DateTimeKind.Unspecified), 1, "Vet58@example.com", true, "VetFirstName58", false, new DateTime(2024, 9, 9, 17, 43, 5, 319, DateTimeKind.Utc).AddTicks(6960), "VetLastName58", 1, false, null, "VET58@EXAMPLE.COM", "VET58", "AQAAAAIAAYagAAAAEK3JbxnMOU+exC6cOxQLvXvHG6Xt/a7qhEXNftH7DTJLiaC5qZ4fuRAYHF58dVJXaQ==", "+993509998485", false, "https://picsum.photos/seed/user58/200/300", null, new DateTime(2024, 9, 9, 17, 43, 5, 319, DateTimeKind.Utc).AddTicks(6953), null, "RYZH37KPG6EEDGSYWW37NETRG56JM7KG", false, "Vet58" },
                    { 2059, "Somme about text for something bla bla bla", 0, "Koroglu Rahimov 70", "Baku", null, "3adb6ebe-e50e-464a-a132-0379f0fb59a6", new DateTime(2024, 4, 9, 17, 43, 5, 319, DateTimeKind.Utc).AddTicks(7026), new DateTime(2000, 2, 28, 0, 0, 0, 0, DateTimeKind.Unspecified), 1, "Vet59@example.com", true, "VetFirstName59", false, new DateTime(2024, 9, 9, 17, 43, 5, 319, DateTimeKind.Utc).AddTicks(7027), "VetLastName59", 1, false, null, "VET59@EXAMPLE.COM", "VET59", "AQAAAAIAAYagAAAAEK3JbxnMOU+exC6cOxQLvXvHG6Xt/a7qhEXNftH7DTJLiaC5qZ4fuRAYHF58dVJXaQ==", "+993509998485", false, "https://picsum.photos/seed/user59/200/300", null, new DateTime(2024, 9, 9, 17, 43, 5, 319, DateTimeKind.Utc).AddTicks(7022), null, "RYZH37KPG6EEDGSYWW37NETRG56JM7KG", false, "Vet59" },
                    { 2060, "Somme about text for something bla bla bla", 0, "Koroglu Rahimov 70", "Baku", null, "23bc0b46-a580-4c8f-a4ff-e8a5f2d0708c", new DateTime(2024, 6, 9, 17, 43, 5, 319, DateTimeKind.Utc).AddTicks(7038), new DateTime(2000, 2, 29, 0, 0, 0, 0, DateTimeKind.Unspecified), 1, "Vet60@example.com", true, "VetFirstName60", false, new DateTime(2024, 9, 9, 17, 43, 5, 319, DateTimeKind.Utc).AddTicks(7039), "VetLastName60", 1, false, null, "VET60@EXAMPLE.COM", "VET60", "AQAAAAIAAYagAAAAEK3JbxnMOU+exC6cOxQLvXvHG6Xt/a7qhEXNftH7DTJLiaC5qZ4fuRAYHF58dVJXaQ==", "+993509998485", false, "https://picsum.photos/seed/user60/200/300", null, new DateTime(2024, 9, 9, 17, 43, 5, 319, DateTimeKind.Utc).AddTicks(7035), null, "RYZH37KPG6EEDGSYWW37NETRG56JM7KG", false, "Vet60" },
                    { 9999, "Somme about text for something bla bla bla", 0, "Koroglu Rahimov 70", "Baku", null, "3f8eec4b-6184-4570-a0e0-a1239c57742b", new DateTime(2024, 9, 9, 17, 43, 5, 319, DateTimeKind.Utc).AddTicks(5889), new DateTime(2000, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 1, "crashtagiyev@gmail.com", true, null, false, new DateTime(2024, 9, 9, 17, 43, 5, 319, DateTimeKind.Utc).AddTicks(5890), null, 1, false, null, "CRASHTAGIYEV@GMAIL.COM", "PETCAREADMIN", "AQAAAAIAAYagAAAAEK3JbxnMOU+exC6cOxQLvXvHG6Xt/a7qhEXNftH7DTJLiaC5qZ4fuRAYHF58dVJXaQ==", "+993509998485", false, "https://picsum.photos/seed/user1/200/300", null, new DateTime(2024, 9, 9, 17, 43, 5, 319, DateTimeKind.Utc).AddTicks(5833), null, "RYZH37KPG6EEDGSYWW37NETRG56JM7KG", false, "PetCareAdmin" }
                });

            migrationBuilder.InsertData(
                table: "PetTypes",
                columns: new[] { "Id", "CreatedTime", "IsDeleted", "LastUpdatedTime", "TypeName" },
                values: new object[,]
                {
                    { 1, new DateTime(2024, 9, 9, 21, 43, 5, 314, DateTimeKind.Local).AddTicks(5834), false, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "Dogs" },
                    { 2, new DateTime(2024, 9, 9, 21, 43, 5, 314, DateTimeKind.Local).AddTicks(5838), false, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "Cats" },
                    { 3, new DateTime(2024, 9, 9, 21, 43, 5, 314, DateTimeKind.Local).AddTicks(5840), false, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "Birds" },
                    { 4, new DateTime(2024, 9, 9, 21, 43, 5, 314, DateTimeKind.Local).AddTicks(5841), false, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "Reptiles" },
                    { 5, new DateTime(2024, 9, 9, 21, 43, 5, 314, DateTimeKind.Local).AddTicks(5842), false, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "Rodents" },
                    { 6, new DateTime(2024, 9, 9, 21, 43, 5, 314, DateTimeKind.Local).AddTicks(5844), false, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "Fish" },
                    { 7, new DateTime(2024, 9, 9, 21, 43, 5, 314, DateTimeKind.Local).AddTicks(5845), false, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "Farm Animals" },
                    { 8, new DateTime(2024, 9, 9, 21, 43, 5, 314, DateTimeKind.Local).AddTicks(5846), false, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "Exotic Pets" }
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
                    { 3, 2060 },
                    { 4, 9999 }
                });

            migrationBuilder.InsertData(
                table: "Breeds",
                columns: new[] { "Id", "BreedName", "CreatedTime", "IsDeleted", "LastUpdatedTime", "PetTypeId" },
                values: new object[,]
                {
                    { 1, "Labrador Retriever", new DateTime(2024, 9, 9, 21, 43, 5, 314, DateTimeKind.Local).AddTicks(8829), false, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 1 },
                    { 2, "German Shepherd", new DateTime(2024, 9, 9, 21, 43, 5, 314, DateTimeKind.Local).AddTicks(8837), false, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 1 },
                    { 3, "Golden Retriever", new DateTime(2024, 9, 9, 21, 43, 5, 314, DateTimeKind.Local).AddTicks(8838), false, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 1 },
                    { 4, "French Bulldog", new DateTime(2024, 9, 9, 21, 43, 5, 314, DateTimeKind.Local).AddTicks(8840), false, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 1 },
                    { 5, "Bulldog", new DateTime(2024, 9, 9, 21, 43, 5, 314, DateTimeKind.Local).AddTicks(8841), false, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 1 },
                    { 6, "Beagle", new DateTime(2024, 9, 9, 21, 43, 5, 314, DateTimeKind.Local).AddTicks(8843), false, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 1 },
                    { 7, "Poodle", new DateTime(2024, 9, 9, 21, 43, 5, 314, DateTimeKind.Local).AddTicks(8844), false, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 1 },
                    { 8, "Rottweiler", new DateTime(2024, 9, 9, 21, 43, 5, 314, DateTimeKind.Local).AddTicks(8846), false, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 1 },
                    { 9, "Yorkshire Terrier", new DateTime(2024, 9, 9, 21, 43, 5, 314, DateTimeKind.Local).AddTicks(8847), false, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 1 },
                    { 10, "Boxer", new DateTime(2024, 9, 9, 21, 43, 5, 314, DateTimeKind.Local).AddTicks(8849), false, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 1 },
                    { 11, "Dachshund", new DateTime(2024, 9, 9, 21, 43, 5, 314, DateTimeKind.Local).AddTicks(8850), false, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 1 },
                    { 12, "Pembroke Welsh Corgi", new DateTime(2024, 9, 9, 21, 43, 5, 314, DateTimeKind.Local).AddTicks(8851), false, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 1 },
                    { 13, "Doberman Pinscher", new DateTime(2024, 9, 9, 21, 43, 5, 314, DateTimeKind.Local).AddTicks(8853), false, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 1 },
                    { 14, "Shih Tzu", new DateTime(2024, 9, 9, 21, 43, 5, 314, DateTimeKind.Local).AddTicks(8854), false, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 1 },
                    { 15, "Siberian Husky", new DateTime(2024, 9, 9, 21, 43, 5, 314, DateTimeKind.Local).AddTicks(8856), false, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 1 },
                    { 16, "Great Dane", new DateTime(2024, 9, 9, 21, 43, 5, 314, DateTimeKind.Local).AddTicks(8857), false, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 1 },
                    { 17, "Border Collie", new DateTime(2024, 9, 9, 21, 43, 5, 314, DateTimeKind.Local).AddTicks(8858), false, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 1 },
                    { 18, "Chihuahua", new DateTime(2024, 9, 9, 21, 43, 5, 314, DateTimeKind.Local).AddTicks(8860), false, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 1 },
                    { 19, "Boston Terrier", new DateTime(2024, 9, 9, 21, 43, 5, 314, DateTimeKind.Local).AddTicks(8861), false, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 1 },
                    { 20, "Australian Shepherd", new DateTime(2024, 9, 9, 21, 43, 5, 314, DateTimeKind.Local).AddTicks(8862), false, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 1 },
                    { 21, "Pug", new DateTime(2024, 9, 9, 21, 43, 5, 314, DateTimeKind.Local).AddTicks(8864), false, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 1 },
                    { 22, "Havanese", new DateTime(2024, 9, 9, 21, 43, 5, 314, DateTimeKind.Local).AddTicks(8865), false, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 1 },
                    { 23, "Maltese", new DateTime(2024, 9, 9, 21, 43, 5, 314, DateTimeKind.Local).AddTicks(8866), false, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 1 },
                    { 24, "Saint Bernard", new DateTime(2024, 9, 9, 21, 43, 5, 314, DateTimeKind.Local).AddTicks(8868), false, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 1 },
                    { 25, "Akita", new DateTime(2024, 9, 9, 21, 43, 5, 314, DateTimeKind.Local).AddTicks(8869), false, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 1 },
                    { 26, "Alaskan Malamute", new DateTime(2024, 9, 9, 21, 43, 5, 314, DateTimeKind.Local).AddTicks(8870), false, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 1 },
                    { 27, "Bichon Frise", new DateTime(2024, 9, 9, 21, 43, 5, 314, DateTimeKind.Local).AddTicks(8872), false, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 1 },
                    { 28, "Bull Terrier", new DateTime(2024, 9, 9, 21, 43, 5, 314, DateTimeKind.Local).AddTicks(8873), false, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 1 },
                    { 29, "Cane Corso", new DateTime(2024, 9, 9, 21, 43, 5, 314, DateTimeKind.Local).AddTicks(8874), false, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 1 },
                    { 30, "Chow Chow", new DateTime(2024, 9, 9, 21, 43, 5, 314, DateTimeKind.Local).AddTicks(8876), false, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 1 },
                    { 31, "Cocker Spaniel", new DateTime(2024, 9, 9, 21, 43, 5, 314, DateTimeKind.Local).AddTicks(8878), false, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 1 },
                    { 32, "Dogo Argentino", new DateTime(2024, 9, 9, 21, 43, 5, 314, DateTimeKind.Local).AddTicks(8879), false, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 1 },
                    { 33, "English Springer Spaniel", new DateTime(2024, 9, 9, 21, 43, 5, 314, DateTimeKind.Local).AddTicks(8880), false, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 1 },
                    { 34, "Irish Setter", new DateTime(2024, 9, 9, 21, 43, 5, 314, DateTimeKind.Local).AddTicks(8882), false, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 1 },
                    { 35, "Jack Russell Terrier", new DateTime(2024, 9, 9, 21, 43, 5, 314, DateTimeKind.Local).AddTicks(8883), false, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 1 },
                    { 36, "Lhasa Apso", new DateTime(2024, 9, 9, 21, 43, 5, 314, DateTimeKind.Local).AddTicks(8884), false, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 1 },
                    { 37, "Miniature Schnauzer", new DateTime(2024, 9, 9, 21, 43, 5, 314, DateTimeKind.Local).AddTicks(8885), false, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 1 },
                    { 38, "Neapolitan Mastiff", new DateTime(2024, 9, 9, 21, 43, 5, 314, DateTimeKind.Local).AddTicks(8887), false, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 1 },
                    { 39, "Old English Sheepdog", new DateTime(2024, 9, 9, 21, 43, 5, 314, DateTimeKind.Local).AddTicks(8888), false, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 1 },
                    { 40, "Papillon", new DateTime(2024, 9, 9, 21, 43, 5, 314, DateTimeKind.Local).AddTicks(8889), false, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 1 },
                    { 41, "Pekingese", new DateTime(2024, 9, 9, 21, 43, 5, 314, DateTimeKind.Local).AddTicks(8891), false, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 1 },
                    { 42, "Petit Basset Griffon Vendeen", new DateTime(2024, 9, 9, 21, 43, 5, 314, DateTimeKind.Local).AddTicks(8892), false, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 1 },
                    { 43, "Pomeranian", new DateTime(2024, 9, 9, 21, 43, 5, 314, DateTimeKind.Local).AddTicks(8893), false, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 1 },
                    { 44, "Portuguese Water Dog", new DateTime(2024, 9, 9, 21, 43, 5, 314, DateTimeKind.Local).AddTicks(8894), false, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 1 },
                    { 45, "Samoyed", new DateTime(2024, 9, 9, 21, 43, 5, 314, DateTimeKind.Local).AddTicks(8896), false, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 1 },
                    { 46, "Scottish Terrier", new DateTime(2024, 9, 9, 21, 43, 5, 314, DateTimeKind.Local).AddTicks(8897), false, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 1 },
                    { 47, "Shiba Inu", new DateTime(2024, 9, 9, 21, 43, 5, 314, DateTimeKind.Local).AddTicks(8898), false, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 1 },
                    { 48, "Weimaraner", new DateTime(2024, 9, 9, 21, 43, 5, 314, DateTimeKind.Local).AddTicks(8899), false, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 1 },
                    { 49, "Whippet", new DateTime(2024, 9, 9, 21, 43, 5, 314, DateTimeKind.Local).AddTicks(8901), false, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 1 },
                    { 50, "Persian", new DateTime(2024, 9, 9, 21, 43, 5, 314, DateTimeKind.Local).AddTicks(8902), false, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 2 },
                    { 51, "Maine Coon", new DateTime(2024, 9, 9, 21, 43, 5, 314, DateTimeKind.Local).AddTicks(8903), false, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 2 },
                    { 52, "Siamese", new DateTime(2024, 9, 9, 21, 43, 5, 314, DateTimeKind.Local).AddTicks(8905), false, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 2 },
                    { 53, "Ragdoll", new DateTime(2024, 9, 9, 21, 43, 5, 314, DateTimeKind.Local).AddTicks(8906), false, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 2 },
                    { 54, "British Shorthair", new DateTime(2024, 9, 9, 21, 43, 5, 314, DateTimeKind.Local).AddTicks(8908), false, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 2 },
                    { 55, "Sphynx", new DateTime(2024, 9, 9, 21, 43, 5, 314, DateTimeKind.Local).AddTicks(8909), false, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 2 },
                    { 56, "Bengal", new DateTime(2024, 9, 9, 21, 43, 5, 314, DateTimeKind.Local).AddTicks(8910), false, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 2 },
                    { 57, "Scottish Fold", new DateTime(2024, 9, 9, 21, 43, 5, 314, DateTimeKind.Local).AddTicks(8911), false, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 2 },
                    { 58, "Abyssinian", new DateTime(2024, 9, 9, 21, 43, 5, 314, DateTimeKind.Local).AddTicks(8913), false, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 2 },
                    { 59, "Burmese", new DateTime(2024, 9, 9, 21, 43, 5, 314, DateTimeKind.Local).AddTicks(8915), false, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 2 },
                    { 60, "Somali", new DateTime(2024, 9, 9, 21, 43, 5, 314, DateTimeKind.Local).AddTicks(8916), false, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 2 },
                    { 61, "Manx", new DateTime(2024, 9, 9, 21, 43, 5, 314, DateTimeKind.Local).AddTicks(8918), false, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 2 },
                    { 62, "Norwegian Forest Cat", new DateTime(2024, 9, 9, 21, 43, 5, 314, DateTimeKind.Local).AddTicks(8919), false, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 2 },
                    { 63, "Devon Rex", new DateTime(2024, 9, 9, 21, 43, 5, 314, DateTimeKind.Local).AddTicks(8920), false, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 2 },
                    { 64, "Cornish Rex", new DateTime(2024, 9, 9, 21, 43, 5, 314, DateTimeKind.Local).AddTicks(8922), false, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 2 },
                    { 65, "Russian Blue", new DateTime(2024, 9, 9, 21, 43, 5, 314, DateTimeKind.Local).AddTicks(8923), false, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 2 },
                    { 66, "Birman", new DateTime(2024, 9, 9, 21, 43, 5, 314, DateTimeKind.Local).AddTicks(8924), false, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 2 },
                    { 67, "Ocicat", new DateTime(2024, 9, 9, 21, 43, 5, 314, DateTimeKind.Local).AddTicks(8925), false, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 2 },
                    { 68, "American Shorthair", new DateTime(2024, 9, 9, 21, 43, 5, 314, DateTimeKind.Local).AddTicks(8927), false, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 2 },
                    { 69, "Turkish Angora", new DateTime(2024, 9, 9, 21, 43, 5, 314, DateTimeKind.Local).AddTicks(8928), false, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 2 },
                    { 70, "Selkirk Rex", new DateTime(2024, 9, 9, 21, 43, 5, 314, DateTimeKind.Local).AddTicks(8930), false, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 2 },
                    { 71, "Exotic Shorthair", new DateTime(2024, 9, 9, 21, 43, 5, 314, DateTimeKind.Local).AddTicks(8931), false, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 2 },
                    { 72, "LaPerm", new DateTime(2024, 9, 9, 21, 43, 5, 314, DateTimeKind.Local).AddTicks(8932), false, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 2 },
                    { 73, "Havana Brown", new DateTime(2024, 9, 9, 21, 43, 5, 314, DateTimeKind.Local).AddTicks(8933), false, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 2 },
                    { 74, "Tonkinese", new DateTime(2024, 9, 9, 21, 43, 5, 314, DateTimeKind.Local).AddTicks(8935), false, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 2 },
                    { 75, "Egyptian Mau", new DateTime(2024, 9, 9, 21, 43, 5, 314, DateTimeKind.Local).AddTicks(8936), false, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 2 },
                    { 76, "Singapura", new DateTime(2024, 9, 9, 21, 43, 5, 314, DateTimeKind.Local).AddTicks(8937), false, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 2 },
                    { 77, "Japanese Bobtail", new DateTime(2024, 9, 9, 21, 43, 5, 314, DateTimeKind.Local).AddTicks(8939), false, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 2 },
                    { 78, "American Curl", new DateTime(2024, 9, 9, 21, 43, 5, 314, DateTimeKind.Local).AddTicks(8940), false, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 2 },
                    { 79, "Parrot", new DateTime(2024, 9, 9, 21, 43, 5, 314, DateTimeKind.Local).AddTicks(8941), false, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 3 },
                    { 80, "Canary", new DateTime(2024, 9, 9, 21, 43, 5, 314, DateTimeKind.Local).AddTicks(8943), false, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 3 },
                    { 81, "Budgerigar", new DateTime(2024, 9, 9, 21, 43, 5, 314, DateTimeKind.Local).AddTicks(8944), false, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 3 },
                    { 82, "Cockatiel", new DateTime(2024, 9, 9, 21, 43, 5, 314, DateTimeKind.Local).AddTicks(8945), false, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 3 },
                    { 83, "Lovebird", new DateTime(2024, 9, 9, 21, 43, 5, 314, DateTimeKind.Local).AddTicks(8946), false, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 3 },
                    { 84, "Macaw", new DateTime(2024, 9, 9, 21, 43, 5, 314, DateTimeKind.Local).AddTicks(8948), false, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 3 },
                    { 85, "Conure", new DateTime(2024, 9, 9, 21, 43, 5, 314, DateTimeKind.Local).AddTicks(8949), false, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 3 },
                    { 86, "African Grey Parrot", new DateTime(2024, 9, 9, 21, 43, 5, 314, DateTimeKind.Local).AddTicks(8950), false, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 3 },
                    { 87, "Finches", new DateTime(2024, 9, 9, 21, 43, 5, 314, DateTimeKind.Local).AddTicks(8951), false, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 3 },
                    { 88, "Quaker Parrot", new DateTime(2024, 9, 9, 21, 43, 5, 314, DateTimeKind.Local).AddTicks(8954), false, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 3 },
                    { 89, "Amazon Parrot", new DateTime(2024, 9, 9, 21, 43, 5, 314, DateTimeKind.Local).AddTicks(8955), false, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 3 },
                    { 90, "Eclectus Parrot", new DateTime(2024, 9, 9, 21, 43, 5, 314, DateTimeKind.Local).AddTicks(8956), false, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 3 },
                    { 91, "Pigeon", new DateTime(2024, 9, 9, 21, 43, 5, 314, DateTimeKind.Local).AddTicks(8958), false, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 3 },
                    { 92, "Dove", new DateTime(2024, 9, 9, 21, 43, 5, 314, DateTimeKind.Local).AddTicks(8959), false, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 3 },
                    { 93, "Cockatoo", new DateTime(2024, 9, 9, 21, 43, 5, 314, DateTimeKind.Local).AddTicks(8960), false, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 3 },
                    { 94, "Sun Conure", new DateTime(2024, 9, 9, 21, 43, 5, 314, DateTimeKind.Local).AddTicks(8961), false, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 3 },
                    { 95, "Hyacinth Macaw", new DateTime(2024, 9, 9, 21, 43, 5, 314, DateTimeKind.Local).AddTicks(8962), false, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 3 },
                    { 96, "Lorikeet", new DateTime(2024, 9, 9, 21, 43, 5, 314, DateTimeKind.Local).AddTicks(8964), false, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 3 },
                    { 97, "Zebra Finch", new DateTime(2024, 9, 9, 21, 43, 5, 314, DateTimeKind.Local).AddTicks(8965), false, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 3 },
                    { 98, "Gouldian Finch", new DateTime(2024, 9, 9, 21, 43, 5, 314, DateTimeKind.Local).AddTicks(8966), false, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 3 },
                    { 99, "Canary Winged Parakeet", new DateTime(2024, 9, 9, 21, 43, 5, 314, DateTimeKind.Local).AddTicks(8967), false, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 3 },
                    { 100, "Quail", new DateTime(2024, 9, 9, 21, 43, 5, 314, DateTimeKind.Local).AddTicks(8968), false, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 3 },
                    { 101, "Iguana", new DateTime(2024, 9, 9, 21, 43, 5, 314, DateTimeKind.Local).AddTicks(8970), false, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 4 },
                    { 102, "Gecko", new DateTime(2024, 9, 9, 21, 43, 5, 314, DateTimeKind.Local).AddTicks(9039), false, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 4 },
                    { 103, "Bearded Dragon", new DateTime(2024, 9, 9, 21, 43, 5, 314, DateTimeKind.Local).AddTicks(9041), false, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 4 },
                    { 104, "Chameleon", new DateTime(2024, 9, 9, 21, 43, 5, 314, DateTimeKind.Local).AddTicks(9042), false, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 4 },
                    { 105, "Python", new DateTime(2024, 9, 9, 21, 43, 5, 314, DateTimeKind.Local).AddTicks(9043), false, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 4 },
                    { 106, "Boa Constrictor", new DateTime(2024, 9, 9, 21, 43, 5, 314, DateTimeKind.Local).AddTicks(9045), false, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 4 },
                    { 107, "Skink", new DateTime(2024, 9, 9, 21, 43, 5, 314, DateTimeKind.Local).AddTicks(9046), false, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 4 },
                    { 108, "Tortoise", new DateTime(2024, 9, 9, 21, 43, 5, 314, DateTimeKind.Local).AddTicks(9047), false, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 4 },
                    { 109, "Turtle", new DateTime(2024, 9, 9, 21, 43, 5, 314, DateTimeKind.Local).AddTicks(9048), false, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 4 },
                    { 110, "Monitor Lizard", new DateTime(2024, 9, 9, 21, 43, 5, 314, DateTimeKind.Local).AddTicks(9050), false, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 4 },
                    { 111, "Water Dragon", new DateTime(2024, 9, 9, 21, 43, 5, 314, DateTimeKind.Local).AddTicks(9051), false, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 4 },
                    { 112, "Uromastyx", new DateTime(2024, 9, 9, 21, 43, 5, 314, DateTimeKind.Local).AddTicks(9052), false, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 4 },
                    { 113, "Horned Toad", new DateTime(2024, 9, 9, 21, 43, 5, 314, DateTimeKind.Local).AddTicks(9054), false, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 4 },
                    { 114, "Hamster", new DateTime(2024, 9, 9, 21, 43, 5, 314, DateTimeKind.Local).AddTicks(9055), false, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 5 },
                    { 115, "Guinea Pig", new DateTime(2024, 9, 9, 21, 43, 5, 314, DateTimeKind.Local).AddTicks(9056), false, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 5 },
                    { 116, "Rat", new DateTime(2024, 9, 9, 21, 43, 5, 314, DateTimeKind.Local).AddTicks(9058), false, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 5 },
                    { 117, "Mouse", new DateTime(2024, 9, 9, 21, 43, 5, 314, DateTimeKind.Local).AddTicks(9060), false, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 5 },
                    { 118, "Gerbil", new DateTime(2024, 9, 9, 21, 43, 5, 314, DateTimeKind.Local).AddTicks(9061), false, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 5 },
                    { 119, "Chinchilla", new DateTime(2024, 9, 9, 21, 43, 5, 314, DateTimeKind.Local).AddTicks(9063), false, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 5 },
                    { 120, "Degu", new DateTime(2024, 9, 9, 21, 43, 5, 314, DateTimeKind.Local).AddTicks(9064), false, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 5 },
                    { 121, "Capybara", new DateTime(2024, 9, 9, 21, 43, 5, 314, DateTimeKind.Local).AddTicks(9065), false, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 5 },
                    { 122, "Prairie Dog", new DateTime(2024, 9, 9, 21, 43, 5, 314, DateTimeKind.Local).AddTicks(9066), false, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 5 },
                    { 123, "Goldfish", new DateTime(2024, 9, 9, 21, 43, 5, 314, DateTimeKind.Local).AddTicks(9068), false, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 6 },
                    { 124, "Betta", new DateTime(2024, 9, 9, 21, 43, 5, 314, DateTimeKind.Local).AddTicks(9069), false, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 6 },
                    { 125, "Guppy", new DateTime(2024, 9, 9, 21, 43, 5, 314, DateTimeKind.Local).AddTicks(9070), false, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 6 },
                    { 126, "Neon Tetra", new DateTime(2024, 9, 9, 21, 43, 5, 314, DateTimeKind.Local).AddTicks(9072), false, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 6 },
                    { 127, "Angelfish", new DateTime(2024, 9, 9, 21, 43, 5, 314, DateTimeKind.Local).AddTicks(9073), false, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 6 },
                    { 128, "Oscar", new DateTime(2024, 9, 9, 21, 43, 5, 314, DateTimeKind.Local).AddTicks(9074), false, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 6 },
                    { 129, "Clownfish", new DateTime(2024, 9, 9, 21, 43, 5, 314, DateTimeKind.Local).AddTicks(9076), false, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 6 },
                    { 130, "Corydoras Catfish", new DateTime(2024, 9, 9, 21, 43, 5, 314, DateTimeKind.Local).AddTicks(9077), false, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 6 },
                    { 131, "Molly", new DateTime(2024, 9, 9, 21, 43, 5, 314, DateTimeKind.Local).AddTicks(9079), false, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 6 },
                    { 132, "Swordtail", new DateTime(2024, 9, 9, 21, 43, 5, 314, DateTimeKind.Local).AddTicks(9080), false, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 6 },
                    { 133, "Rainbowfish", new DateTime(2024, 9, 9, 21, 43, 5, 314, DateTimeKind.Local).AddTicks(9081), false, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 6 },
                    { 134, "Plecostomus", new DateTime(2024, 9, 9, 21, 43, 5, 314, DateTimeKind.Local).AddTicks(9082), false, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 6 },
                    { 135, "Gourami", new DateTime(2024, 9, 9, 21, 43, 5, 314, DateTimeKind.Local).AddTicks(9084), false, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 6 },
                    { 136, "Danios", new DateTime(2024, 9, 9, 21, 43, 5, 314, DateTimeKind.Local).AddTicks(9085), false, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 6 },
                    { 137, "Apistogramma", new DateTime(2024, 9, 9, 21, 43, 5, 314, DateTimeKind.Local).AddTicks(9087), false, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 6 },
                    { 138, "Discus", new DateTime(2024, 9, 9, 21, 43, 5, 314, DateTimeKind.Local).AddTicks(9088), false, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 6 },
                    { 139, "Koi", new DateTime(2024, 9, 9, 21, 43, 5, 314, DateTimeKind.Local).AddTicks(9090), false, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 6 },
                    { 140, "Holstein Cow", new DateTime(2024, 9, 9, 21, 43, 5, 314, DateTimeKind.Local).AddTicks(9091), false, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 7 },
                    { 141, "Angus Cow", new DateTime(2024, 9, 9, 21, 43, 5, 314, DateTimeKind.Local).AddTicks(9092), false, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 7 },
                    { 142, "Jersey Cow", new DateTime(2024, 9, 9, 21, 43, 5, 314, DateTimeKind.Local).AddTicks(9093), false, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 7 },
                    { 143, "Guernsey Cow", new DateTime(2024, 9, 9, 21, 43, 5, 314, DateTimeKind.Local).AddTicks(9095), false, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 7 },
                    { 144, "Merino Sheep", new DateTime(2024, 9, 9, 21, 43, 5, 314, DateTimeKind.Local).AddTicks(9096), false, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 7 },
                    { 145, "Suffolk Sheep", new DateTime(2024, 9, 9, 21, 43, 5, 314, DateTimeKind.Local).AddTicks(9097), false, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 7 },
                    { 146, "Dorset Sheep", new DateTime(2024, 9, 9, 21, 43, 5, 314, DateTimeKind.Local).AddTicks(9098), false, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 7 },
                    { 147, "Hampshire Sheep", new DateTime(2024, 9, 9, 21, 43, 5, 314, DateTimeKind.Local).AddTicks(9100), false, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 7 },
                    { 148, "Berkshire Pig", new DateTime(2024, 9, 9, 21, 43, 5, 314, DateTimeKind.Local).AddTicks(9101), false, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 7 },
                    { 149, "Duroc Pig", new DateTime(2024, 9, 9, 21, 43, 5, 314, DateTimeKind.Local).AddTicks(9102), false, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 7 },
                    { 150, "Yorkshire Pig", new DateTime(2024, 9, 9, 21, 43, 5, 314, DateTimeKind.Local).AddTicks(9103), false, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 7 },
                    { 151, "Landrace Pig", new DateTime(2024, 9, 9, 21, 43, 5, 314, DateTimeKind.Local).AddTicks(9104), false, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 7 },
                    { 152, "Rhode Island Red Chicken", new DateTime(2024, 9, 9, 21, 43, 5, 314, DateTimeKind.Local).AddTicks(9106), false, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 7 },
                    { 153, "Leghorn Chicken", new DateTime(2024, 9, 9, 21, 43, 5, 314, DateTimeKind.Local).AddTicks(9107), false, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 7 },
                    { 154, "Plymouth Rock Chicken", new DateTime(2024, 9, 9, 21, 43, 5, 314, DateTimeKind.Local).AddTicks(9108), false, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 7 },
                    { 155, "Sussex Chicken", new DateTime(2024, 9, 9, 21, 43, 5, 314, DateTimeKind.Local).AddTicks(9110), false, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 7 },
                    { 156, "Turkeys", new DateTime(2024, 9, 9, 21, 43, 5, 314, DateTimeKind.Local).AddTicks(9111), false, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 7 },
                    { 157, "Ducks", new DateTime(2024, 9, 9, 21, 43, 5, 314, DateTimeKind.Local).AddTicks(9112), false, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 7 },
                    { 158, "Goats", new DateTime(2024, 9, 9, 21, 43, 5, 314, DateTimeKind.Local).AddTicks(9113), false, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 7 },
                    { 159, "Llamas", new DateTime(2024, 9, 9, 21, 43, 5, 314, DateTimeKind.Local).AddTicks(9115), false, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 7 },
                    { 160, "Alpacas", new DateTime(2024, 9, 9, 21, 43, 5, 314, DateTimeKind.Local).AddTicks(9116), false, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 7 }
                });

            migrationBuilder.InsertData(
                table: "Shelters",
                columns: new[] { "Id", "AboutShelter", "Address", "AdoptionPolicy", "City", "CompanyId", "CreatedTime", "EmailAddress", "IsDeleted", "LastUpdatedTime", "PhoneNumber", "ShelterImageUrl", "ShelterName" },
                values: new object[,]
                {
                    { 1021, "This is about shelter for Company21.", "Street 21", "Adoption policy for Company21.", "Baku", 2021, new DateTime(2024, 9, 9, 17, 43, 5, 314, DateTimeKind.Utc).AddTicks(4953), "ShelterEmailAddress21@gmail.com", false, new DateTime(2024, 9, 9, 17, 43, 5, 314, DateTimeKind.Utc).AddTicks(4955), "+994501234567", "https://picsum.photos/seed/user21/200/300", "Shelter Name 21" },
                    { 1022, "This is about shelter for Company22.", "Street 22", "Adoption policy for Company22.", "Baku", 2022, new DateTime(2024, 9, 9, 17, 43, 5, 314, DateTimeKind.Utc).AddTicks(4972), "ShelterEmailAddress22@gmail.com", false, new DateTime(2024, 9, 9, 17, 43, 5, 314, DateTimeKind.Utc).AddTicks(4972), "+994501234567", "https://picsum.photos/seed/user22/200/300", "Shelter Name 22" },
                    { 1023, "This is about shelter for Company23.", "Street 23", "Adoption policy for Company23.", "Baku", 2023, new DateTime(2024, 9, 9, 17, 43, 5, 314, DateTimeKind.Utc).AddTicks(4981), "ShelterEmailAddress23@gmail.com", false, new DateTime(2024, 9, 9, 17, 43, 5, 314, DateTimeKind.Utc).AddTicks(4981), "+994501234567", "https://picsum.photos/seed/user23/200/300", "Shelter Name 23" },
                    { 1024, "This is about shelter for Company24.", "Street 24", "Adoption policy for Company24.", "Baku", 2024, new DateTime(2024, 9, 9, 17, 43, 5, 314, DateTimeKind.Utc).AddTicks(4989), "ShelterEmailAddress24@gmail.com", false, new DateTime(2024, 9, 9, 17, 43, 5, 314, DateTimeKind.Utc).AddTicks(4989), "+994501234567", "https://picsum.photos/seed/user24/200/300", "Shelter Name 24" },
                    { 1025, "This is about shelter for Company25.", "Street 25", "Adoption policy for Company25.", "Baku", 2025, new DateTime(2024, 9, 9, 17, 43, 5, 314, DateTimeKind.Utc).AddTicks(4998), "ShelterEmailAddress25@gmail.com", false, new DateTime(2024, 9, 9, 17, 43, 5, 314, DateTimeKind.Utc).AddTicks(4998), "+994501234567", "https://picsum.photos/seed/user25/200/300", "Shelter Name 25" },
                    { 1026, "This is about shelter for Company26.", "Street 26", "Adoption policy for Company26.", "Baku", 2026, new DateTime(2024, 9, 9, 17, 43, 5, 314, DateTimeKind.Utc).AddTicks(5009), "ShelterEmailAddress26@gmail.com", false, new DateTime(2024, 9, 9, 17, 43, 5, 314, DateTimeKind.Utc).AddTicks(5009), "+994501234567", "https://picsum.photos/seed/user26/200/300", "Shelter Name 26" },
                    { 1027, "This is about shelter for Company27.", "Street 27", "Adoption policy for Company27.", "Baku", 2027, new DateTime(2024, 9, 9, 17, 43, 5, 314, DateTimeKind.Utc).AddTicks(5017), "ShelterEmailAddress27@gmail.com", false, new DateTime(2024, 9, 9, 17, 43, 5, 314, DateTimeKind.Utc).AddTicks(5018), "+994501234567", "https://picsum.photos/seed/user27/200/300", "Shelter Name 27" },
                    { 1028, "This is about shelter for Company28.", "Street 28", "Adoption policy for Company28.", "Baku", 2028, new DateTime(2024, 9, 9, 17, 43, 5, 314, DateTimeKind.Utc).AddTicks(5025), "ShelterEmailAddress28@gmail.com", false, new DateTime(2024, 9, 9, 17, 43, 5, 314, DateTimeKind.Utc).AddTicks(5026), "+994501234567", "https://picsum.photos/seed/user28/200/300", "Shelter Name 28" },
                    { 1029, "This is about shelter for Company29.", "Street 29", "Adoption policy for Company29.", "Baku", 2029, new DateTime(2024, 9, 9, 17, 43, 5, 314, DateTimeKind.Utc).AddTicks(5033), "ShelterEmailAddress29@gmail.com", false, new DateTime(2024, 9, 9, 17, 43, 5, 314, DateTimeKind.Utc).AddTicks(5034), "+994501234567", "https://picsum.photos/seed/user29/200/300", "Shelter Name 29" },
                    { 1030, "This is about shelter for Company30.", "Street 30", "Adoption policy for Company30.", "Baku", 2030, new DateTime(2024, 9, 9, 17, 43, 5, 314, DateTimeKind.Utc).AddTicks(5087), "ShelterEmailAddress30@gmail.com", false, new DateTime(2024, 9, 9, 17, 43, 5, 314, DateTimeKind.Utc).AddTicks(5088), "+994501234567", "https://picsum.photos/seed/user30/200/300", "Shelter Name 30" },
                    { 1031, "This is about shelter for Company31.", "Street 31", "Adoption policy for Company31.", "Baku", 2031, new DateTime(2024, 9, 9, 17, 43, 5, 314, DateTimeKind.Utc).AddTicks(5095), "ShelterEmailAddress31@gmail.com", false, new DateTime(2024, 9, 9, 17, 43, 5, 314, DateTimeKind.Utc).AddTicks(5096), "+994501234567", "https://picsum.photos/seed/user31/200/300", "Shelter Name 31" },
                    { 1032, "This is about shelter for Company32.", "Street 32", "Adoption policy for Company32.", "Baku", 2032, new DateTime(2024, 9, 9, 17, 43, 5, 314, DateTimeKind.Utc).AddTicks(5104), "ShelterEmailAddress32@gmail.com", false, new DateTime(2024, 9, 9, 17, 43, 5, 314, DateTimeKind.Utc).AddTicks(5104), "+994501234567", "https://picsum.photos/seed/user32/200/300", "Shelter Name 32" },
                    { 1033, "This is about shelter for Company33.", "Street 33", "Adoption policy for Company33.", "Baku", 2033, new DateTime(2024, 9, 9, 17, 43, 5, 314, DateTimeKind.Utc).AddTicks(5112), "ShelterEmailAddress33@gmail.com", false, new DateTime(2024, 9, 9, 17, 43, 5, 314, DateTimeKind.Utc).AddTicks(5112), "+994501234567", "https://picsum.photos/seed/user33/200/300", "Shelter Name 33" },
                    { 1034, "This is about shelter for Company34.", "Street 34", "Adoption policy for Company34.", "Baku", 2034, new DateTime(2024, 9, 9, 17, 43, 5, 314, DateTimeKind.Utc).AddTicks(5120), "ShelterEmailAddress34@gmail.com", false, new DateTime(2024, 9, 9, 17, 43, 5, 314, DateTimeKind.Utc).AddTicks(5120), "+994501234567", "https://picsum.photos/seed/user34/200/300", "Shelter Name 34" },
                    { 1035, "This is about shelter for Company35.", "Street 35", "Adoption policy for Company35.", "Baku", 2035, new DateTime(2024, 9, 9, 17, 43, 5, 314, DateTimeKind.Utc).AddTicks(5129), "ShelterEmailAddress35@gmail.com", false, new DateTime(2024, 9, 9, 17, 43, 5, 314, DateTimeKind.Utc).AddTicks(5129), "+994501234567", "https://picsum.photos/seed/user35/200/300", "Shelter Name 35" },
                    { 1036, "This is about shelter for Company36.", "Street 36", "Adoption policy for Company36.", "Baku", 2036, new DateTime(2024, 9, 9, 17, 43, 5, 314, DateTimeKind.Utc).AddTicks(5137), "ShelterEmailAddress36@gmail.com", false, new DateTime(2024, 9, 9, 17, 43, 5, 314, DateTimeKind.Utc).AddTicks(5137), "+994501234567", "https://picsum.photos/seed/user36/200/300", "Shelter Name 36" },
                    { 1037, "This is about shelter for Company37.", "Street 37", "Adoption policy for Company37.", "Baku", 2037, new DateTime(2024, 9, 9, 17, 43, 5, 314, DateTimeKind.Utc).AddTicks(5145), "ShelterEmailAddress37@gmail.com", false, new DateTime(2024, 9, 9, 17, 43, 5, 314, DateTimeKind.Utc).AddTicks(5146), "+994501234567", "https://picsum.photos/seed/user37/200/300", "Shelter Name 37" },
                    { 1038, "This is about shelter for Company38.", "Street 38", "Adoption policy for Company38.", "Baku", 2038, new DateTime(2024, 9, 9, 17, 43, 5, 314, DateTimeKind.Utc).AddTicks(5155), "ShelterEmailAddress38@gmail.com", false, new DateTime(2024, 9, 9, 17, 43, 5, 314, DateTimeKind.Utc).AddTicks(5155), "+994501234567", "https://picsum.photos/seed/user38/200/300", "Shelter Name 38" },
                    { 1039, "This is about shelter for Company39.", "Street 39", "Adoption policy for Company39.", "Baku", 2039, new DateTime(2024, 9, 9, 17, 43, 5, 314, DateTimeKind.Utc).AddTicks(5163), "ShelterEmailAddress39@gmail.com", false, new DateTime(2024, 9, 9, 17, 43, 5, 314, DateTimeKind.Utc).AddTicks(5164), "+994501234567", "https://picsum.photos/seed/user39/200/300", "Shelter Name 39" },
                    { 1040, "This is about shelter for Company40.", "Street 40", "Adoption policy for Company40.", "Baku", 2040, new DateTime(2024, 9, 9, 17, 43, 5, 314, DateTimeKind.Utc).AddTicks(5171), "ShelterEmailAddress40@gmail.com", false, new DateTime(2024, 9, 9, 17, 43, 5, 314, DateTimeKind.Utc).AddTicks(5172), "+994501234567", "https://picsum.photos/seed/user40/200/300", "Shelter Name 40" }
                });

            migrationBuilder.InsertData(
                table: "Pets",
                columns: new[] { "Id", "AdoptionId", "Age", "BreedId", "CreatedTime", "Description", "Gender", "Health", "ImageUrls", "IsAdopted", "IsDeleted", "LastUpdatedTime", "PetName", "PetTypeId", "ShelterId", "Size", "Weight" },
                values: new object[,]
                {
                    { 1, null, (short)3, 1, new DateTime(2023, 11, 9, 21, 43, 5, 321, DateTimeKind.Local).AddTicks(1096), "Friendly Labrador Retriever", 1, "Healthy", "[\"https://images.unsplash.com/photo-1574158622682-e40e69881006\",\"https://images.unsplash.com/photo-1583511656127-8a22f6e9f018\"]", false, false, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "Buddy", 2, 1026, "Large", 30.5m },
                    { 2, null, (short)2, 2, new DateTime(2024, 7, 9, 21, 43, 5, 321, DateTimeKind.Local).AddTicks(1117), "Energetic Beagle", 2, "Healthy", "[\"https://images.unsplash.com/photo-1560807707-8cc77767d783\",\"https://images.unsplash.com/photo-1560807707-8cc77767d783\"]", false, false, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "Bella", 1, 1026, "Medium", 10.2m },
                    { 3, null, (short)5, 3, new DateTime(2024, 2, 9, 21, 43, 5, 321, DateTimeKind.Local).AddTicks(1124), "Loyal German Shepherd", 1, "Healthy", "[\"https://images.unsplash.com/photo-1560807707-8cc77767d783\",\"https://images.unsplash.com/photo-1601758124199-0a4b30c13d8e\"]", true, false, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "Max", 1, 1026, "Large", 40.8m },
                    { 4, null, (short)4, 4, new DateTime(2024, 2, 9, 21, 43, 5, 321, DateTimeKind.Local).AddTicks(1129), "Clever Border Collie", 2, "Healthy", "[\"https://images.unsplash.com/photo-1579362242788-7d8d553f7d82\",\"https://images.unsplash.com/photo-1593137318309-7d0bdc18f9c3\"]", false, false, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "Lucy", 1, 1026, "Medium", 18.7m },
                    { 5, null, (short)2, 5, new DateTime(2023, 12, 9, 21, 43, 5, 321, DateTimeKind.Local).AddTicks(1134), "Playful Golden Retriever", 1, "Healthy", "[\"https://images.unsplash.com/photo-1557302985-673a2c6c8c83\",\"https://images.unsplash.com/photo-1596495577886-d920f15eb45d\"]", true, false, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "Charlie", 1, 1026, "Large", 28.3m },
                    { 6, null, (short)2, 6, new DateTime(2024, 8, 9, 21, 43, 5, 321, DateTimeKind.Local).AddTicks(1140), "Playful Maine Coon", 2, "Healthy", "[\"https://images.unsplash.com/photo-1585791325888-0fc79fae1484\",\"https://images.unsplash.com/photo-1570816118443-e11a95c3f168\"]", true, false, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "Mittens", 2, 1026, "Large", 10.2m },
                    { 7, null, (short)4, 7, new DateTime(2024, 5, 9, 21, 43, 5, 321, DateTimeKind.Local).AddTicks(1145), "Curious Siamese", 1, "Healthy", "[\"https://images.unsplash.com/photo-1560807707-8cc77767d783\",\"https://images.unsplash.com/photo-1584358147545-7fd7b772d2e8\"]", false, false, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "Whiskers", 2, 1026, "Medium", 7.8m },
                    { 8, null, (short)3, 8, new DateTime(2023, 10, 9, 21, 43, 5, 321, DateTimeKind.Local).AddTicks(1151), "Silent Russian Blue", 1, "Healthy", "[\"https://images.unsplash.com/photo-1592194996308-7b19e0c4730b\",\"https://images.unsplash.com/photo-1593137318309-7d0bdc18f9c3\"]", true, false, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "Shadow", 2, 1026, "Medium", 8.5m },
                    { 9, null, (short)2, 9, new DateTime(2024, 5, 9, 21, 43, 5, 321, DateTimeKind.Local).AddTicks(1158), "Graceful Persian", 2, "Healthy", "[\"https://images.unsplash.com/photo-1583511656127-8a22f6e9f018\",\"https://images.unsplash.com/photo-1560807707-8cc77767d783\"]", false, false, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "Luna", 2, 1026, "Small", 5.3m },
                    { 10, null, (short)3, 10, new DateTime(2024, 6, 9, 21, 43, 5, 321, DateTimeKind.Local).AddTicks(1163), "Adventurous Bengal", 1, "Healthy", "[\"https://images.unsplash.com/photo-1560807707-8cc77767d783\",\"https://images.unsplash.com/photo-1601758124199-0a4b30c13d8e\"]", false, false, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "Simba", 2, 1026, "Large", 9.2m },
                    { 11, null, (short)1, 11, new DateTime(2024, 6, 9, 21, 43, 5, 321, DateTimeKind.Local).AddTicks(1169), "Chirpy Canary", 2, "Healthy", "[\"https://images.unsplash.com/photo-1558981289-42a1e2b2133e\",\"https://images.unsplash.com/photo-1560807707-8cc77767d783\"]", false, false, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "Tweety", 3, 1026, "Small", 0.05m },
                    { 12, null, (short)5, 12, new DateTime(2023, 10, 9, 21, 43, 5, 321, DateTimeKind.Local).AddTicks(1174), "Talkative Parrot", 2, "Healthy", "[\"https://images.unsplash.com/photo-1507611097612-5ff4d04e4b7e\",\"https://images.unsplash.com/photo-1508546293063-3094b6a13db5\"]", false, false, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "Polly", 3, 1026, "Medium", 0.9m },
                    { 13, null, (short)2, 13, new DateTime(2023, 11, 9, 21, 43, 5, 321, DateTimeKind.Local).AddTicks(1181), "Graceful Cockatiel", 1, "Healthy", "[\"https://images.unsplash.com/photo-1560807707-8cc77767d783\",\"https://images.unsplash.com/photo-1558981289-42a1e2b2133e\"]", true, false, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "Sky", 3, 1026, "Small", 0.12m },
                    { 14, null, (short)3, 14, new DateTime(2024, 8, 9, 21, 43, 5, 321, DateTimeKind.Local).AddTicks(1186), "Colorful Parakeet", 2, "Healthy", "[\"https://images.unsplash.com/photo-1508610048659-a06d45f8a1a5\",\"https://images.unsplash.com/photo-1558981289-42a1e2b2133e\"]", false, false, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "Kiwi", 3, 1026, "Small", 0.06m },
                    { 15, null, (short)4, 15, new DateTime(2023, 11, 9, 21, 43, 5, 321, DateTimeKind.Local).AddTicks(1192), "Clever African Grey", 2, "Healthy", "[\"https://images.unsplash.com/photo-1558981289-42a1e2b2133e\",\"https://images.unsplash.com/photo-1508546293063-3094b6a13db5\"]", true, false, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "Coco", 3, 1025, "Medium", 0.45m },
                    { 16, null, (short)4, 16, new DateTime(2024, 5, 9, 21, 43, 5, 321, DateTimeKind.Local).AddTicks(1198), "Spiky Bearded Dragon", 1, "Healthy", "[\"https://images.unsplash.com/photo-1599945863043-c972ca05f8d0\",\"https://images.unsplash.com/photo-1560807707-8cc77767d783\"]", false, false, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "Spike", 4, 1026, "Medium", 1.1m },
                    { 17, null, (short)2, 17, new DateTime(2023, 12, 9, 21, 43, 5, 321, DateTimeKind.Local).AddTicks(1203), "Stealthy Corn Snake", 1, "Healthy", "[\"https://images.unsplash.com/photo-1587137112204-ff2af20e59d5\",\"https://images.unsplash.com/photo-1560807707-8cc77767d783\"]", false, false, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "Slinky", 4, 1026, "Small", 0.3m },
                    { 18, null, (short)3, 18, new DateTime(2024, 1, 9, 21, 43, 5, 321, DateTimeKind.Local).AddTicks(1208), "Agile Gecko", 2, "Healthy", "[\"https://images.unsplash.com/photo-1593137318309-7d0bdc18f9c3\",\"https://images.unsplash.com/photo-1587137112204-ff2af20e59d5\"]", false, false, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "Gizmo", 4, 1026, "Small", 0.07m },
                    { 19, null, (short)1, 19, new DateTime(2023, 10, 9, 21, 43, 5, 321, DateTimeKind.Local).AddTicks(1214), "Curious Hamster", 1, "Healthy", "[\"https://images.unsplash.com/photo-1550807012-514e38ec9ad4\",\"https://images.unsplash.com/photo-1558981289-42a1e2b2133e\"]", true, false, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "Nibbles", 5, 1026, "Small", 0.03m },
                    { 20, null, (short)2, 20, new DateTime(2024, 3, 9, 21, 43, 5, 321, DateTimeKind.Local).AddTicks(1221), "Fluffy Guinea Pig", 2, "Healthy", "[\"https://images.unsplash.com/photo-1550807012-514e38ec9ad4\",\"https://images.unsplash.com/photo-1558981289-42a1e2b2133e\"]", false, false, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "Fuzzy", 5, 1026, "Small", 1.2m },
                    { 21, null, (short)3, 21, new DateTime(2024, 1, 9, 21, 43, 5, 321, DateTimeKind.Local).AddTicks(1226), "Playful Rabbit", 1, "Healthy", "[\"https://images.unsplash.com/photo-1550807012-514e38ec9ad4\",\"https://images.unsplash.com/photo-1560807707-8cc77767d783\"]", false, false, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "Pip", 5, 1026, "Small", 2.5m },
                    { 22, null, (short)3, 22, new DateTime(2024, 7, 9, 21, 43, 5, 321, DateTimeKind.Local).AddTicks(1231), "Charming Chinchilla", 1, "Healthy", "[\"https://images.unsplash.com/photo-1550807012-514e38ec9ad4\",\"https://images.unsplash.com/photo-1558981289-42a1e2b2133e\"]", false, false, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "Chester", 6, 1026, "Small", 0.6m },
                    { 23, null, (short)2, 23, new DateTime(2024, 3, 9, 21, 43, 5, 321, DateTimeKind.Local).AddTicks(1236), "Lively Sugar Glider", 2, "Healthy", "[\"https://images.unsplash.com/photo-1550807012-514e38ec9ad4\",\"https://images.unsplash.com/photo-1558981289-42a1e2b2133e\"]", false, false, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "Zara", 6, 1026, "Small", 0.1m },
                    { 24, null, (short)2, 24, new DateTime(2023, 11, 9, 21, 43, 5, 321, DateTimeKind.Local).AddTicks(1241), "Spiky Hedgehog", 1, "Healthy", "[\"https://images.unsplash.com/photo-1550807012-514e38ec9ad4\",\"https://images.unsplash.com/photo-1558981289-42a1e2b2133e\"]", true, false, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "Spike", 6, 1026, "Small", 0.4m },
                    { 25, null, (short)4, 25, new DateTime(2023, 11, 9, 21, 43, 5, 321, DateTimeKind.Local).AddTicks(1247), "Soft Chinchilla", 1, "Healthy", "[\"url49.jpg\",\"url50.jpg\"]", true, false, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "Chinchy", 5, 1024, "Small", 0.6m },
                    { 26, null, (short)1, 26, new DateTime(2024, 8, 9, 21, 43, 5, 321, DateTimeKind.Local).AddTicks(1252), "Colorful Betta Fish", 1, "Healthy", "[\"url51.jpg\",\"url52.jpg\"]", false, false, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "Bubbles", 6, 1024, "Small", 0.02m },
                    { 27, null, (short)2, 27, new DateTime(2024, 7, 9, 21, 43, 5, 321, DateTimeKind.Local).AddTicks(1260), "Tiny Frog", 2, "Healthy", "[\"url53.jpg\",\"url54.jpg\"]", false, false, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "Frodo", 6, 1024, "Small", 0.05m },
                    { 28, null, (short)3, 28, new DateTime(2024, 4, 9, 21, 43, 5, 321, DateTimeKind.Local).AddTicks(1265), "Creepy Tarantula", 2, "Healthy", "[\"url55.jpg\",\"url56.jpg\"]", true, false, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "Spidey", 6, 1024, "Small", 0.1m },
                    { 29, null, (short)2, 29, new DateTime(2023, 10, 9, 21, 43, 5, 321, DateTimeKind.Local).AddTicks(1270), "Amphibious Newt", 2, "Healthy", "[\"url57.jpg\",\"url58.jpg\"]", false, false, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "Newt", 6, 1024, "Small", 0.07m },
                    { 30, null, (short)5, 30, new DateTime(2023, 10, 9, 21, 43, 5, 321, DateTimeKind.Local).AddTicks(1275), "Scaly Iguana", 1, "Healthy", "[\"url59.jpg\",\"url60.jpg\"]", true, false, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "Scales", 6, 1024, "Medium", 1.5m },
                    { 31, null, (short)4, 31, new DateTime(2024, 3, 9, 21, 43, 5, 321, DateTimeKind.Local).AddTicks(1280), "Guard Dog Rottweiler", 1, "Healthy", "[\"url61.jpg\",\"url62.jpg\"]", false, false, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "Rex", 1, 1024, "Large", 50.0m },
                    { 32, null, (short)2, 32, new DateTime(2024, 1, 9, 21, 43, 5, 321, DateTimeKind.Local).AddTicks(1286), "Playful Pug", 1, "Healthy", "[\"url63.jpg\",\"url64.jpg\"]", true, false, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "Milo", 1, 1024, "Small", 8.5m },
                    { 33, null, (short)3, 33, new DateTime(2024, 2, 9, 21, 43, 5, 321, DateTimeKind.Local).AddTicks(1291), "Adorable Shih Tzu", 2, "Healthy", "[\"url65.jpg\",\"url66.jpg\"]", false, false, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "Bailey", 1, 1023, "Small", 6.2m },
                    { 34, null, (short)4, 34, new DateTime(2024, 2, 9, 21, 43, 5, 321, DateTimeKind.Local).AddTicks(1296), "Agile Greyhound", 2, "Healthy", "[\"url67.jpg\",\"url68.jpg\"]", true, false, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "Sasha", 1, 1023, "Large", 28.0m },
                    { 35, null, (short)3, 35, new DateTime(2024, 2, 9, 21, 43, 5, 321, DateTimeKind.Local).AddTicks(1301), "Energetic Boxer", 1, "Healthy", "[\"url69.jpg\",\"url70.jpg\"]", false, false, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "Rocky", 1, 1023, "Large", 35.0m },
                    { 36, null, (short)2, 36, new DateTime(2023, 11, 9, 21, 43, 5, 321, DateTimeKind.Local).AddTicks(1306), "Affectionate Ragdoll", 1, "Healthy", "[\"url71.jpg\",\"url72.jpg\"]", true, false, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "Toby", 2, 1023, "Large", 9.0m },
                    { 37, null, (short)3, 37, new DateTime(2024, 5, 9, 21, 43, 5, 321, DateTimeKind.Local).AddTicks(1311), "Quiet British Shorthair", 2, "Healthy", "[\"url73.jpg\",\"url74.jpg\"]", false, false, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "Misty", 2, 1022, "Medium", 7.0m },
                    { 38, null, (short)4, 38, new DateTime(2024, 2, 9, 21, 43, 5, 321, DateTimeKind.Local).AddTicks(1316), "Mischievous Sphynx", 1, "Healthy", "[\"url75.jpg\",\"url76.jpg\"]", true, false, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "Oscar", 2, 1022, "Medium", 8.0m },
                    { 39, null, (short)2, 39, new DateTime(2024, 7, 9, 21, 43, 5, 321, DateTimeKind.Local).AddTicks(1364), "Active Abyssinian", 2, "Healthy", "[\"url77.jpg\",\"url78.jpg\"]", false, false, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "Ginger", 2, 1022, "Small", 5.5m },
                    { 40, null, (short)3, 40, new DateTime(2024, 2, 9, 21, 43, 5, 321, DateTimeKind.Local).AddTicks(1370), "Laid-back Birman", 1, "Healthy", "[\"url79.jpg\",\"url80.jpg\"]", true, false, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "Jasper", 2, 1022, "Medium", 6.5m },
                    { 41, null, (short)3, 41, new DateTime(2023, 12, 9, 21, 43, 5, 321, DateTimeKind.Local).AddTicks(1375), "Bright Sun Conure", 2, "Healthy", "[\"url81.jpg\",\"url82.jpg\"]", false, false, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "Sunshine", 3, 1022, "Small", 0.12m },
                    { 42, null, (short)1, 42, new DateTime(2024, 1, 9, 21, 43, 5, 321, DateTimeKind.Local).AddTicks(1381), "Chirpy Canary", 1, "Healthy", "[\"url83.jpg\",\"url84.jpg\"]", false, false, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "Tweety", 3, 1022, "Small", 0.03m },
                    { 43, null, (short)2, 43, new DateTime(2024, 6, 9, 21, 43, 5, 321, DateTimeKind.Local).AddTicks(1387), "Friendly Budgie", 1, "Healthy", "[\"url85.jpg\",\"url86.jpg\"]", true, false, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "Buddy", 3, 1022, "Small", 0.04m },
                    { 44, null, (short)2, 44, new DateTime(2024, 1, 9, 21, 43, 5, 321, DateTimeKind.Local).AddTicks(1392), "Talkative Parakeet", 2, "Healthy", "[\"url87.jpg\",\"url88.jpg\"]", false, false, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "Chirpy", 3, 1021, "Small", 0.05m },
                    { 45, null, (short)4, 45, new DateTime(2024, 7, 9, 21, 43, 5, 321, DateTimeKind.Local).AddTicks(1397), "Noisy Cockatoo", 1, "Healthy", "[\"url89.jpg\",\"url90.jpg\"]", true, false, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "Pepper", 3, 1021, "Medium", 0.5m },
                    { 46, null, (short)5, 46, new DateTime(2024, 2, 9, 21, 43, 5, 321, DateTimeKind.Local).AddTicks(1402), "Venomous King Cobra", 1, "Healthy", "[\"url91.jpg\",\"url92.jpg\"]", false, false, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "Slither", 4, 1021, "Large", 6.0m },
                    { 47, null, (short)7, 47, new DateTime(2024, 2, 9, 21, 43, 5, 321, DateTimeKind.Local).AddTicks(1407), "Large Komodo Dragon", 1, "Healthy", "[\"url93.jpg\",\"url94.jpg\"]", false, false, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "Rex", 4, 1021, "Large", 70.0m },
                    { 48, null, (short)4, 48, new DateTime(2024, 5, 9, 21, 43, 5, 321, DateTimeKind.Local).AddTicks(1414), "Green Iguana", 2, "Healthy", "[\"url95.jpg\",\"url96.jpg\"]", true, false, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "Ivy", 4, 1021, "Medium", 3.5m },
                    { 49, null, (short)5, 49, new DateTime(2024, 4, 9, 21, 43, 5, 321, DateTimeKind.Local).AddTicks(1419), "Horned Lizard", 1, "Healthy", "[\"url97.jpg\",\"url98.jpg\"]", false, false, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "Spike", 4, 1021, "Medium", 2.5m },
                    { 50, null, (short)100, 50, new DateTime(2023, 10, 9, 21, 43, 5, 321, DateTimeKind.Local).AddTicks(1424), "Giant Tortoise", 1, "Healthy", "[\"url99.jpg\",\"url100.jpg\"]", true, false, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "Shelly", 4, 1021, "Large", 200.0m }
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
                column: "PetId");

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