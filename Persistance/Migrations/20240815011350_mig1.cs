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
                    Firstname = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Lastname = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    DateOfBirth = table.Column<DateTime>(type: "datetime2", nullable: true),
                    City = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Address = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    RefreshToken = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    RefreshTokenExpireTime = table.Column<DateTime>(type: "datetime2", nullable: true),
                    RefreshTokenCreateTime = table.Column<DateTime>(type: "datetime2", nullable: true),
                    CreatedTime = table.Column<DateTime>(type: "datetime2", nullable: false),
                    LastUpdatedTime = table.Column<DateTime>(type: "datetime2", nullable: false),
                    IsDeleted = table.Column<bool>(type: "bit", nullable: false),
                    ProfileImageUrl = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Likes = table.Column<int>(type: "int", nullable: false),
                    Dislikes = table.Column<int>(type: "int", nullable: false),
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
                name: "Locations",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    City = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Region = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Street = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    ShelterId = table.Column<int>(type: "int", nullable: false),
                    CreatedTime = table.Column<DateTime>(type: "datetime2", nullable: false),
                    LastUpdatedTime = table.Column<DateTime>(type: "datetime2", nullable: false),
                    IsDeleted = table.Column<bool>(type: "bit", nullable: false)
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
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
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
                columns: new[] { "Id", "About", "AccessFailedCount", "Address", "City", "ConcurrencyStamp", "CreatedTime", "DateOfBirth", "Dislikes", "Email", "EmailConfirmed", "Firstname", "IsDeleted", "LastUpdatedTime", "Lastname", "Likes", "LockoutEnabled", "LockoutEnd", "NormalizedEmail", "NormalizedUserName", "PasswordHash", "PhoneNumber", "PhoneNumberConfirmed", "ProfileImageUrl", "RefreshToken", "RefreshTokenCreateTime", "RefreshTokenExpireTime", "SecurityStamp", "TwoFactorEnabled", "UserName" },
                values: new object[,]
                {
                    { 2001, "NULL", 0, "Address1", "City1", "33a73321-5750-4b65-bb2d-1788ec4cafe9", new DateTime(2024, 8, 15, 1, 13, 49, 161, DateTimeKind.Utc).AddTicks(6453), new DateTime(2000, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 0, "user1@example.com", true, "FirstName1", false, new DateTime(2024, 8, 15, 1, 13, 49, 161, DateTimeKind.Utc).AddTicks(6454), "LastName1", 0, false, null, "USER1@EXAMPLE.COM", "USER1", "AQAAAAIAAYagAAAAEK3JbxnMOU+exC6cOxQLvXvHG6Xt/a7qhEXNftH7DTJLiaC5qZ4fuRAYHF58dVJXaQ==", null, false, "https://picsum.photos/seed/user1/200/300", null, new DateTime(2024, 8, 15, 5, 13, 49, 161, DateTimeKind.Local).AddTicks(6346), null, null, false, "user1" },
                    { 2002, "NULL", 0, "Address2", "City2", "85e8a777-037c-4dc0-9398-106f8fe0bf37", new DateTime(2024, 8, 15, 1, 13, 49, 161, DateTimeKind.Utc).AddTicks(6487), new DateTime(2000, 1, 2, 0, 0, 0, 0, DateTimeKind.Unspecified), 0, "user2@example.com", true, "FirstName2", false, new DateTime(2024, 8, 15, 1, 13, 49, 161, DateTimeKind.Utc).AddTicks(6487), "LastName2", 0, false, null, "USER2@EXAMPLE.COM", "USER2", "AQAAAAIAAYagAAAAEK3JbxnMOU+exC6cOxQLvXvHG6Xt/a7qhEXNftH7DTJLiaC5qZ4fuRAYHF58dVJXaQ==", null, false, "https://picsum.photos/seed/user2/200/300", null, new DateTime(2024, 8, 15, 5, 13, 49, 161, DateTimeKind.Local).AddTicks(6481), null, null, false, "user2" },
                    { 2003, "NULL", 0, "Address3", "City3", "b420fdfd-c5ff-4203-9f65-44603076a833", new DateTime(2024, 8, 15, 1, 13, 49, 161, DateTimeKind.Utc).AddTicks(6510), new DateTime(2000, 1, 3, 0, 0, 0, 0, DateTimeKind.Unspecified), 0, "user3@example.com", true, "FirstName3", false, new DateTime(2024, 8, 15, 1, 13, 49, 161, DateTimeKind.Utc).AddTicks(6511), "LastName3", 0, false, null, "USER3@EXAMPLE.COM", "USER3", "AQAAAAIAAYagAAAAEK3JbxnMOU+exC6cOxQLvXvHG6Xt/a7qhEXNftH7DTJLiaC5qZ4fuRAYHF58dVJXaQ==", null, false, "https://picsum.photos/seed/user3/200/300", null, new DateTime(2024, 8, 15, 5, 13, 49, 161, DateTimeKind.Local).AddTicks(6505), null, null, false, "user3" },
                    { 2004, "NULL", 0, "Address4", "City4", "dbc68685-c476-4f8a-bb42-1a8fbf659cb5", new DateTime(2024, 8, 15, 1, 13, 49, 161, DateTimeKind.Utc).AddTicks(6523), new DateTime(2000, 1, 4, 0, 0, 0, 0, DateTimeKind.Unspecified), 0, "user4@example.com", true, "FirstName4", false, new DateTime(2024, 8, 15, 1, 13, 49, 161, DateTimeKind.Utc).AddTicks(6523), "LastName4", 0, false, null, "USER4@EXAMPLE.COM", "USER4", "AQAAAAIAAYagAAAAEK3JbxnMOU+exC6cOxQLvXvHG6Xt/a7qhEXNftH7DTJLiaC5qZ4fuRAYHF58dVJXaQ==", null, false, "https://picsum.photos/seed/user4/200/300", null, new DateTime(2024, 8, 15, 5, 13, 49, 161, DateTimeKind.Local).AddTicks(6518), null, null, false, "user4" },
                    { 2005, "NULL", 0, "Address5", "City5", "b894c9af-5b42-4b2b-adfd-944caed2acf4", new DateTime(2024, 8, 15, 1, 13, 49, 161, DateTimeKind.Utc).AddTicks(6536), new DateTime(2000, 1, 5, 0, 0, 0, 0, DateTimeKind.Unspecified), 0, "user5@example.com", true, "FirstName5", false, new DateTime(2024, 8, 15, 1, 13, 49, 161, DateTimeKind.Utc).AddTicks(6537), "LastName5", 0, false, null, "USER5@EXAMPLE.COM", "USER5", "AQAAAAIAAYagAAAAEK3JbxnMOU+exC6cOxQLvXvHG6Xt/a7qhEXNftH7DTJLiaC5qZ4fuRAYHF58dVJXaQ==", null, false, "https://picsum.photos/seed/user5/200/300", null, new DateTime(2024, 8, 15, 5, 13, 49, 161, DateTimeKind.Local).AddTicks(6531), null, null, false, "user5" },
                    { 2006, "NULL", 0, "Address6", "City6", "9e023dff-06ad-45cf-b32e-16510f3a3da6", new DateTime(2024, 8, 15, 1, 13, 49, 161, DateTimeKind.Utc).AddTicks(6552), new DateTime(2000, 1, 6, 0, 0, 0, 0, DateTimeKind.Unspecified), 0, "user6@example.com", true, "FirstName6", false, new DateTime(2024, 8, 15, 1, 13, 49, 161, DateTimeKind.Utc).AddTicks(6553), "LastName6", 0, false, null, "USER6@EXAMPLE.COM", "USER6", "AQAAAAIAAYagAAAAEK3JbxnMOU+exC6cOxQLvXvHG6Xt/a7qhEXNftH7DTJLiaC5qZ4fuRAYHF58dVJXaQ==", null, false, "https://picsum.photos/seed/user6/200/300", null, new DateTime(2024, 8, 15, 5, 13, 49, 161, DateTimeKind.Local).AddTicks(6547), null, null, false, "user6" },
                    { 2007, "NULL", 0, "Address7", "City7", "457a779f-ce80-4b5f-923a-a520c7490fdb", new DateTime(2024, 8, 15, 1, 13, 49, 161, DateTimeKind.Utc).AddTicks(6565), new DateTime(2000, 1, 7, 0, 0, 0, 0, DateTimeKind.Unspecified), 0, "user7@example.com", true, "FirstName7", false, new DateTime(2024, 8, 15, 1, 13, 49, 161, DateTimeKind.Utc).AddTicks(6565), "LastName7", 0, false, null, "USER7@EXAMPLE.COM", "USER7", "AQAAAAIAAYagAAAAEK3JbxnMOU+exC6cOxQLvXvHG6Xt/a7qhEXNftH7DTJLiaC5qZ4fuRAYHF58dVJXaQ==", null, false, "https://picsum.photos/seed/user7/200/300", null, new DateTime(2024, 8, 15, 5, 13, 49, 161, DateTimeKind.Local).AddTicks(6560), null, null, false, "user7" },
                    { 2008, "NULL", 0, "Address8", "City8", "4b4e7c90-194c-47da-98ee-9ad57e235eeb", new DateTime(2024, 8, 15, 1, 13, 49, 161, DateTimeKind.Utc).AddTicks(6591), new DateTime(2000, 1, 8, 0, 0, 0, 0, DateTimeKind.Unspecified), 0, "user8@example.com", true, "FirstName8", false, new DateTime(2024, 8, 15, 1, 13, 49, 161, DateTimeKind.Utc).AddTicks(6592), "LastName8", 0, false, null, "USER8@EXAMPLE.COM", "USER8", "AQAAAAIAAYagAAAAEK3JbxnMOU+exC6cOxQLvXvHG6Xt/a7qhEXNftH7DTJLiaC5qZ4fuRAYHF58dVJXaQ==", null, false, "https://picsum.photos/seed/user8/200/300", null, new DateTime(2024, 8, 15, 5, 13, 49, 161, DateTimeKind.Local).AddTicks(6572), null, null, false, "user8" },
                    { 2009, "NULL", 0, "Address9", "City9", "c1dfb5d0-9afd-440d-a211-55cdbcbd6fa0", new DateTime(2024, 8, 15, 1, 13, 49, 161, DateTimeKind.Utc).AddTicks(6604), new DateTime(2000, 1, 9, 0, 0, 0, 0, DateTimeKind.Unspecified), 0, "user9@example.com", true, "FirstName9", false, new DateTime(2024, 8, 15, 1, 13, 49, 161, DateTimeKind.Utc).AddTicks(6605), "LastName9", 0, false, null, "USER9@EXAMPLE.COM", "USER9", "AQAAAAIAAYagAAAAEK3JbxnMOU+exC6cOxQLvXvHG6Xt/a7qhEXNftH7DTJLiaC5qZ4fuRAYHF58dVJXaQ==", null, false, "https://picsum.photos/seed/user9/200/300", null, new DateTime(2024, 8, 15, 5, 13, 49, 161, DateTimeKind.Local).AddTicks(6599), null, null, false, "user9" },
                    { 2010, "NULL", 0, "Address10", "City10", "1f9291e1-2531-4d2f-bdb2-895c189bd0e7", new DateTime(2024, 8, 15, 1, 13, 49, 161, DateTimeKind.Utc).AddTicks(6620), new DateTime(2000, 1, 10, 0, 0, 0, 0, DateTimeKind.Unspecified), 0, "user10@example.com", true, "FirstName10", false, new DateTime(2024, 8, 15, 1, 13, 49, 161, DateTimeKind.Utc).AddTicks(6620), "LastName10", 0, false, null, "USER10@EXAMPLE.COM", "USER10", "AQAAAAIAAYagAAAAEK3JbxnMOU+exC6cOxQLvXvHG6Xt/a7qhEXNftH7DTJLiaC5qZ4fuRAYHF58dVJXaQ==", null, false, "https://picsum.photos/seed/user10/200/300", null, new DateTime(2024, 8, 15, 5, 13, 49, 161, DateTimeKind.Local).AddTicks(6613), null, null, false, "user10" },
                    { 2011, "NULL", 0, "Address11", "City11", "0ce38957-e552-4255-85c7-17729bc9b7e6", new DateTime(2024, 8, 15, 1, 13, 49, 161, DateTimeKind.Utc).AddTicks(6634), new DateTime(2000, 1, 11, 0, 0, 0, 0, DateTimeKind.Unspecified), 0, "user11@example.com", true, "FirstName11", false, new DateTime(2024, 8, 15, 1, 13, 49, 161, DateTimeKind.Utc).AddTicks(6634), "LastName11", 0, false, null, "USER11@EXAMPLE.COM", "USER11", "AQAAAAIAAYagAAAAEK3JbxnMOU+exC6cOxQLvXvHG6Xt/a7qhEXNftH7DTJLiaC5qZ4fuRAYHF58dVJXaQ==", null, false, "https://picsum.photos/seed/user11/200/300", null, new DateTime(2024, 8, 15, 5, 13, 49, 161, DateTimeKind.Local).AddTicks(6629), null, null, false, "user11" },
                    { 2012, "NULL", 0, "Address12", "City12", "13bfbc57-a5eb-4f99-bbd0-fc4c9ca7643d", new DateTime(2024, 8, 15, 1, 13, 49, 161, DateTimeKind.Utc).AddTicks(6656), new DateTime(2000, 1, 12, 0, 0, 0, 0, DateTimeKind.Unspecified), 0, "user12@example.com", true, "FirstName12", false, new DateTime(2024, 8, 15, 1, 13, 49, 161, DateTimeKind.Utc).AddTicks(6657), "LastName12", 0, false, null, "USER12@EXAMPLE.COM", "USER12", "AQAAAAIAAYagAAAAEK3JbxnMOU+exC6cOxQLvXvHG6Xt/a7qhEXNftH7DTJLiaC5qZ4fuRAYHF58dVJXaQ==", null, false, "https://picsum.photos/seed/user12/200/300", null, new DateTime(2024, 8, 15, 5, 13, 49, 161, DateTimeKind.Local).AddTicks(6651), null, null, false, "user12" },
                    { 2013, "NULL", 0, "Address13", "City13", "76903605-4c7d-4271-b0bb-85ca3e6aae4f", new DateTime(2024, 8, 15, 1, 13, 49, 161, DateTimeKind.Utc).AddTicks(6669), new DateTime(2000, 1, 13, 0, 0, 0, 0, DateTimeKind.Unspecified), 0, "user13@example.com", true, "FirstName13", false, new DateTime(2024, 8, 15, 1, 13, 49, 161, DateTimeKind.Utc).AddTicks(6669), "LastName13", 0, false, null, "USER13@EXAMPLE.COM", "USER13", "AQAAAAIAAYagAAAAEK3JbxnMOU+exC6cOxQLvXvHG6Xt/a7qhEXNftH7DTJLiaC5qZ4fuRAYHF58dVJXaQ==", null, false, "https://picsum.photos/seed/user13/200/300", null, new DateTime(2024, 8, 15, 5, 13, 49, 161, DateTimeKind.Local).AddTicks(6664), null, null, false, "user13" },
                    { 2014, "NULL", 0, "Address14", "City14", "efa8a616-f7a5-4766-a687-080a3efb8e93", new DateTime(2024, 8, 15, 1, 13, 49, 161, DateTimeKind.Utc).AddTicks(6682), new DateTime(2000, 1, 14, 0, 0, 0, 0, DateTimeKind.Unspecified), 0, "user14@example.com", true, "FirstName14", false, new DateTime(2024, 8, 15, 1, 13, 49, 161, DateTimeKind.Utc).AddTicks(6682), "LastName14", 0, false, null, "USER14@EXAMPLE.COM", "USER14", "AQAAAAIAAYagAAAAEK3JbxnMOU+exC6cOxQLvXvHG6Xt/a7qhEXNftH7DTJLiaC5qZ4fuRAYHF58dVJXaQ==", null, false, "https://picsum.photos/seed/user14/200/300", null, new DateTime(2024, 8, 15, 5, 13, 49, 161, DateTimeKind.Local).AddTicks(6677), null, null, false, "user14" },
                    { 2015, "NULL", 0, "Address15", "City15", "c40690ae-f28e-4623-b3ab-c27d4cbe42e5", new DateTime(2024, 8, 15, 1, 13, 49, 161, DateTimeKind.Utc).AddTicks(6695), new DateTime(2000, 1, 15, 0, 0, 0, 0, DateTimeKind.Unspecified), 0, "user15@example.com", true, "FirstName15", false, new DateTime(2024, 8, 15, 1, 13, 49, 161, DateTimeKind.Utc).AddTicks(6695), "LastName15", 0, false, null, "USER15@EXAMPLE.COM", "USER15", "AQAAAAIAAYagAAAAEK3JbxnMOU+exC6cOxQLvXvHG6Xt/a7qhEXNftH7DTJLiaC5qZ4fuRAYHF58dVJXaQ==", null, false, "https://picsum.photos/seed/user15/200/300", null, new DateTime(2024, 8, 15, 5, 13, 49, 161, DateTimeKind.Local).AddTicks(6690), null, null, false, "user15" },
                    { 2016, "NULL", 0, "Address16", "City16", "a07a2abb-3ad9-4111-b40e-83b397795b86", new DateTime(2024, 8, 15, 1, 13, 49, 161, DateTimeKind.Utc).AddTicks(6711), new DateTime(2000, 1, 16, 0, 0, 0, 0, DateTimeKind.Unspecified), 0, "user16@example.com", true, "FirstName16", false, new DateTime(2024, 8, 15, 1, 13, 49, 161, DateTimeKind.Utc).AddTicks(6711), "LastName16", 0, false, null, "USER16@EXAMPLE.COM", "USER16", "AQAAAAIAAYagAAAAEK3JbxnMOU+exC6cOxQLvXvHG6Xt/a7qhEXNftH7DTJLiaC5qZ4fuRAYHF58dVJXaQ==", null, false, "https://picsum.photos/seed/user16/200/300", null, new DateTime(2024, 8, 15, 5, 13, 49, 161, DateTimeKind.Local).AddTicks(6703), null, null, false, "user16" },
                    { 2017, "NULL", 0, "Address17", "City17", "4f1d8679-b957-431c-a0ab-8cd4b9c91c8d", new DateTime(2024, 8, 15, 1, 13, 49, 161, DateTimeKind.Utc).AddTicks(6724), new DateTime(2000, 1, 17, 0, 0, 0, 0, DateTimeKind.Unspecified), 0, "user17@example.com", true, "FirstName17", false, new DateTime(2024, 8, 15, 1, 13, 49, 161, DateTimeKind.Utc).AddTicks(6725), "LastName17", 0, false, null, "USER17@EXAMPLE.COM", "USER17", "AQAAAAIAAYagAAAAEK3JbxnMOU+exC6cOxQLvXvHG6Xt/a7qhEXNftH7DTJLiaC5qZ4fuRAYHF58dVJXaQ==", null, false, "https://picsum.photos/seed/user17/200/300", null, new DateTime(2024, 8, 15, 5, 13, 49, 161, DateTimeKind.Local).AddTicks(6719), null, null, false, "user17" },
                    { 2018, "NULL", 0, "Address18", "City18", "b9472f80-24eb-495e-93ef-90a19fbb51be", new DateTime(2024, 8, 15, 1, 13, 49, 161, DateTimeKind.Utc).AddTicks(6738), new DateTime(2000, 1, 18, 0, 0, 0, 0, DateTimeKind.Unspecified), 0, "user18@example.com", true, "FirstName18", false, new DateTime(2024, 8, 15, 1, 13, 49, 161, DateTimeKind.Utc).AddTicks(6739), "LastName18", 0, false, null, "USER18@EXAMPLE.COM", "USER18", "AQAAAAIAAYagAAAAEK3JbxnMOU+exC6cOxQLvXvHG6Xt/a7qhEXNftH7DTJLiaC5qZ4fuRAYHF58dVJXaQ==", null, false, "https://picsum.photos/seed/user18/200/300", null, new DateTime(2024, 8, 15, 5, 13, 49, 161, DateTimeKind.Local).AddTicks(6733), null, null, false, "user18" },
                    { 2019, "NULL", 0, "Address19", "City19", "7857b964-3ff2-4043-96bf-17eeb2132002", new DateTime(2024, 8, 15, 1, 13, 49, 161, DateTimeKind.Utc).AddTicks(6752), new DateTime(2000, 1, 19, 0, 0, 0, 0, DateTimeKind.Unspecified), 0, "user19@example.com", true, "FirstName19", false, new DateTime(2024, 8, 15, 1, 13, 49, 161, DateTimeKind.Utc).AddTicks(6752), "LastName19", 0, false, null, "USER19@EXAMPLE.COM", "USER19", "AQAAAAIAAYagAAAAEK3JbxnMOU+exC6cOxQLvXvHG6Xt/a7qhEXNftH7DTJLiaC5qZ4fuRAYHF58dVJXaQ==", null, false, "https://picsum.photos/seed/user19/200/300", null, new DateTime(2024, 8, 15, 5, 13, 49, 161, DateTimeKind.Local).AddTicks(6747), null, null, false, "user19" },
                    { 2020, "NULL", 0, "Address20", "City20", "f55d8a7a-27be-4145-92de-8599aac8624a", new DateTime(2024, 8, 15, 1, 13, 49, 161, DateTimeKind.Utc).AddTicks(6766), new DateTime(2000, 1, 20, 0, 0, 0, 0, DateTimeKind.Unspecified), 0, "user20@example.com", true, "FirstName20", false, new DateTime(2024, 8, 15, 1, 13, 49, 161, DateTimeKind.Utc).AddTicks(6766), "LastName20", 0, false, null, "USER20@EXAMPLE.COM", "USER20", "AQAAAAIAAYagAAAAEK3JbxnMOU+exC6cOxQLvXvHG6Xt/a7qhEXNftH7DTJLiaC5qZ4fuRAYHF58dVJXaQ==", null, false, "https://picsum.photos/seed/user20/200/300", null, new DateTime(2024, 8, 15, 5, 13, 49, 161, DateTimeKind.Local).AddTicks(6760), null, null, false, "user20" },
                    { 2021, "NULL", 0, "Address21", "City21", "a04cc06f-8565-4927-bf83-b78bf9c16cf5", new DateTime(2024, 8, 15, 1, 13, 49, 161, DateTimeKind.Utc).AddTicks(6785), new DateTime(2000, 1, 21, 0, 0, 0, 0, DateTimeKind.Unspecified), 0, "Company21@example.com", true, "CompanyFirstName21", false, new DateTime(2024, 8, 15, 1, 13, 49, 161, DateTimeKind.Utc).AddTicks(6786), "CompanyLastName21", 0, false, null, "COMPANY21@EXAMPLE.COM", "COMPANY21", "AQAAAAIAAYagAAAAEK3JbxnMOU+exC6cOxQLvXvHG6Xt/a7qhEXNftH7DTJLiaC5qZ4fuRAYHF58dVJXaQ==", null, false, "https://picsum.photos/seed/user21/200/300", null, new DateTime(2024, 8, 15, 5, 13, 49, 161, DateTimeKind.Local).AddTicks(6781), null, null, false, "Company21" },
                    { 2022, "NULL", 0, "Address22", "City22", "2029f037-3b60-4ee1-9548-6b9c9baa0999", new DateTime(2024, 8, 15, 1, 13, 49, 161, DateTimeKind.Utc).AddTicks(6804), new DateTime(2000, 1, 22, 0, 0, 0, 0, DateTimeKind.Unspecified), 0, "Company22@example.com", true, "CompanyFirstName22", false, new DateTime(2024, 8, 15, 1, 13, 49, 161, DateTimeKind.Utc).AddTicks(6805), "CompanyLastName22", 0, false, null, "COMPANY22@EXAMPLE.COM", "COMPANY22", "AQAAAAIAAYagAAAAEK3JbxnMOU+exC6cOxQLvXvHG6Xt/a7qhEXNftH7DTJLiaC5qZ4fuRAYHF58dVJXaQ==", null, false, "https://picsum.photos/seed/user22/200/300", null, new DateTime(2024, 8, 15, 5, 13, 49, 161, DateTimeKind.Local).AddTicks(6799), null, null, false, "Company22" },
                    { 2023, "NULL", 0, "Address23", "City23", "99e5fbfe-05cf-484a-9b88-9b996c9ea1c8", new DateTime(2024, 8, 15, 1, 13, 49, 161, DateTimeKind.Utc).AddTicks(6818), new DateTime(2000, 1, 23, 0, 0, 0, 0, DateTimeKind.Unspecified), 0, "Company23@example.com", true, "CompanyFirstName23", false, new DateTime(2024, 8, 15, 1, 13, 49, 161, DateTimeKind.Utc).AddTicks(6818), "CompanyLastName23", 0, false, null, "COMPANY23@EXAMPLE.COM", "COMPANY23", "AQAAAAIAAYagAAAAEK3JbxnMOU+exC6cOxQLvXvHG6Xt/a7qhEXNftH7DTJLiaC5qZ4fuRAYHF58dVJXaQ==", null, false, "https://picsum.photos/seed/user23/200/300", null, new DateTime(2024, 8, 15, 5, 13, 49, 161, DateTimeKind.Local).AddTicks(6813), null, null, false, "Company23" },
                    { 2024, "NULL", 0, "Address24", "City24", "d9089a58-6294-413b-bd6e-24c3fe47ff2e", new DateTime(2024, 8, 15, 1, 13, 49, 161, DateTimeKind.Utc).AddTicks(6834), new DateTime(2000, 1, 24, 0, 0, 0, 0, DateTimeKind.Unspecified), 0, "Company24@example.com", true, "CompanyFirstName24", false, new DateTime(2024, 8, 15, 1, 13, 49, 161, DateTimeKind.Utc).AddTicks(6834), "CompanyLastName24", 0, false, null, "COMPANY24@EXAMPLE.COM", "COMPANY24", "AQAAAAIAAYagAAAAEK3JbxnMOU+exC6cOxQLvXvHG6Xt/a7qhEXNftH7DTJLiaC5qZ4fuRAYHF58dVJXaQ==", null, false, "https://picsum.photos/seed/user24/200/300", null, new DateTime(2024, 8, 15, 5, 13, 49, 161, DateTimeKind.Local).AddTicks(6826), null, null, false, "Company24" },
                    { 2025, "NULL", 0, "Address25", "City25", "8789290f-6b5a-4b9c-8869-62f117d9c4ae", new DateTime(2024, 8, 15, 1, 13, 49, 161, DateTimeKind.Utc).AddTicks(6847), new DateTime(2000, 1, 25, 0, 0, 0, 0, DateTimeKind.Unspecified), 0, "Company25@example.com", true, "CompanyFirstName25", false, new DateTime(2024, 8, 15, 1, 13, 49, 161, DateTimeKind.Utc).AddTicks(6847), "CompanyLastName25", 0, false, null, "COMPANY25@EXAMPLE.COM", "COMPANY25", "AQAAAAIAAYagAAAAEK3JbxnMOU+exC6cOxQLvXvHG6Xt/a7qhEXNftH7DTJLiaC5qZ4fuRAYHF58dVJXaQ==", null, false, "https://picsum.photos/seed/user25/200/300", null, new DateTime(2024, 8, 15, 5, 13, 49, 161, DateTimeKind.Local).AddTicks(6842), null, null, false, "Company25" },
                    { 2026, "NULL", 0, "Address26", "City26", "92ea9853-993c-4679-8e54-697640629f03", new DateTime(2024, 8, 15, 1, 13, 49, 161, DateTimeKind.Utc).AddTicks(6860), new DateTime(2000, 1, 26, 0, 0, 0, 0, DateTimeKind.Unspecified), 0, "Company26@example.com", true, "CompanyFirstName26", false, new DateTime(2024, 8, 15, 1, 13, 49, 161, DateTimeKind.Utc).AddTicks(6861), "CompanyLastName26", 0, false, null, "COMPANY26@EXAMPLE.COM", "COMPANY26", "AQAAAAIAAYagAAAAEK3JbxnMOU+exC6cOxQLvXvHG6Xt/a7qhEXNftH7DTJLiaC5qZ4fuRAYHF58dVJXaQ==", null, false, "https://picsum.photos/seed/user26/200/300", null, new DateTime(2024, 8, 15, 5, 13, 49, 161, DateTimeKind.Local).AddTicks(6855), null, null, false, "Company26" },
                    { 2027, "NULL", 0, "Address27", "City27", "8e31054b-edd2-40bc-b8a0-022430242bed", new DateTime(2024, 8, 15, 1, 13, 49, 161, DateTimeKind.Utc).AddTicks(6873), new DateTime(2000, 1, 27, 0, 0, 0, 0, DateTimeKind.Unspecified), 0, "Company27@example.com", true, "CompanyFirstName27", false, new DateTime(2024, 8, 15, 1, 13, 49, 161, DateTimeKind.Utc).AddTicks(6874), "CompanyLastName27", 0, false, null, "COMPANY27@EXAMPLE.COM", "COMPANY27", "AQAAAAIAAYagAAAAEK3JbxnMOU+exC6cOxQLvXvHG6Xt/a7qhEXNftH7DTJLiaC5qZ4fuRAYHF58dVJXaQ==", null, false, "https://picsum.photos/seed/user27/200/300", null, new DateTime(2024, 8, 15, 5, 13, 49, 161, DateTimeKind.Local).AddTicks(6868), null, null, false, "Company27" },
                    { 2028, "NULL", 0, "Address28", "City28", "54ad50cb-63e3-40d9-a877-221ba6d9cfca", new DateTime(2024, 8, 15, 1, 13, 49, 161, DateTimeKind.Utc).AddTicks(6886), new DateTime(2000, 1, 28, 0, 0, 0, 0, DateTimeKind.Unspecified), 0, "Company28@example.com", true, "CompanyFirstName28", false, new DateTime(2024, 8, 15, 1, 13, 49, 161, DateTimeKind.Utc).AddTicks(6887), "CompanyLastName28", 0, false, null, "COMPANY28@EXAMPLE.COM", "COMPANY28", "AQAAAAIAAYagAAAAEK3JbxnMOU+exC6cOxQLvXvHG6Xt/a7qhEXNftH7DTJLiaC5qZ4fuRAYHF58dVJXaQ==", null, false, "https://picsum.photos/seed/user28/200/300", null, new DateTime(2024, 8, 15, 5, 13, 49, 161, DateTimeKind.Local).AddTicks(6881), null, null, false, "Company28" },
                    { 2029, "NULL", 0, "Address29", "City29", "f1acd1a4-9931-4c8d-88de-b0efe77c715e", new DateTime(2024, 8, 15, 1, 13, 49, 161, DateTimeKind.Utc).AddTicks(6900), new DateTime(2000, 1, 29, 0, 0, 0, 0, DateTimeKind.Unspecified), 0, "Company29@example.com", true, "CompanyFirstName29", false, new DateTime(2024, 8, 15, 1, 13, 49, 161, DateTimeKind.Utc).AddTicks(6900), "CompanyLastName29", 0, false, null, "COMPANY29@EXAMPLE.COM", "COMPANY29", "AQAAAAIAAYagAAAAEK3JbxnMOU+exC6cOxQLvXvHG6Xt/a7qhEXNftH7DTJLiaC5qZ4fuRAYHF58dVJXaQ==", null, false, "https://picsum.photos/seed/user29/200/300", null, new DateTime(2024, 8, 15, 5, 13, 49, 161, DateTimeKind.Local).AddTicks(6894), null, null, false, "Company29" },
                    { 2030, "NULL", 0, "Address30", "City30", "1d9d8381-939c-4c34-9045-1e5a21898a31", new DateTime(2024, 8, 15, 1, 13, 49, 161, DateTimeKind.Utc).AddTicks(6920), new DateTime(2000, 1, 30, 0, 0, 0, 0, DateTimeKind.Unspecified), 0, "Company30@example.com", true, "CompanyFirstName30", false, new DateTime(2024, 8, 15, 1, 13, 49, 161, DateTimeKind.Utc).AddTicks(6920), "CompanyLastName30", 0, false, null, "COMPANY30@EXAMPLE.COM", "COMPANY30", "AQAAAAIAAYagAAAAEK3JbxnMOU+exC6cOxQLvXvHG6Xt/a7qhEXNftH7DTJLiaC5qZ4fuRAYHF58dVJXaQ==", null, false, "https://picsum.photos/seed/user30/200/300", null, new DateTime(2024, 8, 15, 5, 13, 49, 161, DateTimeKind.Local).AddTicks(6915), null, null, false, "Company30" },
                    { 2031, "NULL", 0, "Address31", "City31", "c214f3da-90bd-4b8d-9fec-72b46714de8b", new DateTime(2024, 8, 15, 1, 13, 49, 161, DateTimeKind.Utc).AddTicks(6933), new DateTime(2000, 1, 31, 0, 0, 0, 0, DateTimeKind.Unspecified), 0, "Company31@example.com", true, "CompanyFirstName31", false, new DateTime(2024, 8, 15, 1, 13, 49, 161, DateTimeKind.Utc).AddTicks(6933), "CompanyLastName31", 0, false, null, "COMPANY31@EXAMPLE.COM", "COMPANY31", "AQAAAAIAAYagAAAAEK3JbxnMOU+exC6cOxQLvXvHG6Xt/a7qhEXNftH7DTJLiaC5qZ4fuRAYHF58dVJXaQ==", null, false, "https://picsum.photos/seed/user31/200/300", null, new DateTime(2024, 8, 15, 5, 13, 49, 161, DateTimeKind.Local).AddTicks(6928), null, null, false, "Company31" },
                    { 2032, "NULL", 0, "Address32", "City32", "eaeb9dda-72cd-46e6-b219-b3bf0ba37142", new DateTime(2024, 8, 15, 1, 13, 49, 161, DateTimeKind.Utc).AddTicks(6949), new DateTime(2000, 2, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 0, "Company32@example.com", true, "CompanyFirstName32", false, new DateTime(2024, 8, 15, 1, 13, 49, 161, DateTimeKind.Utc).AddTicks(6949), "CompanyLastName32", 0, false, null, "COMPANY32@EXAMPLE.COM", "COMPANY32", "AQAAAAIAAYagAAAAEK3JbxnMOU+exC6cOxQLvXvHG6Xt/a7qhEXNftH7DTJLiaC5qZ4fuRAYHF58dVJXaQ==", null, false, "https://picsum.photos/seed/user32/200/300", null, new DateTime(2024, 8, 15, 5, 13, 49, 161, DateTimeKind.Local).AddTicks(6941), null, null, false, "Company32" },
                    { 2033, "NULL", 0, "Address33", "City33", "4838552f-76d3-42bc-bc8c-1b5aa454e96a", new DateTime(2024, 8, 15, 1, 13, 49, 161, DateTimeKind.Utc).AddTicks(6962), new DateTime(2000, 2, 2, 0, 0, 0, 0, DateTimeKind.Unspecified), 0, "Company33@example.com", true, "CompanyFirstName33", false, new DateTime(2024, 8, 15, 1, 13, 49, 161, DateTimeKind.Utc).AddTicks(6962), "CompanyLastName33", 0, false, null, "COMPANY33@EXAMPLE.COM", "COMPANY33", "AQAAAAIAAYagAAAAEK3JbxnMOU+exC6cOxQLvXvHG6Xt/a7qhEXNftH7DTJLiaC5qZ4fuRAYHF58dVJXaQ==", null, false, "https://picsum.photos/seed/user33/200/300", null, new DateTime(2024, 8, 15, 5, 13, 49, 161, DateTimeKind.Local).AddTicks(6956), null, null, false, "Company33" },
                    { 2034, "NULL", 0, "Address34", "City34", "5c6c7d4c-c471-4095-9c5e-5cd6006e2997", new DateTime(2024, 8, 15, 1, 13, 49, 161, DateTimeKind.Utc).AddTicks(6976), new DateTime(2000, 2, 3, 0, 0, 0, 0, DateTimeKind.Unspecified), 0, "Company34@example.com", true, "CompanyFirstName34", false, new DateTime(2024, 8, 15, 1, 13, 49, 161, DateTimeKind.Utc).AddTicks(6976), "CompanyLastName34", 0, false, null, "COMPANY34@EXAMPLE.COM", "COMPANY34", "AQAAAAIAAYagAAAAEK3JbxnMOU+exC6cOxQLvXvHG6Xt/a7qhEXNftH7DTJLiaC5qZ4fuRAYHF58dVJXaQ==", null, false, "https://picsum.photos/seed/user34/200/300", null, new DateTime(2024, 8, 15, 5, 13, 49, 161, DateTimeKind.Local).AddTicks(6971), null, null, false, "Company34" },
                    { 2035, "NULL", 0, "Address35", "City35", "f7a882ca-12f8-4355-b570-5e0dd8603f60", new DateTime(2024, 8, 15, 1, 13, 49, 161, DateTimeKind.Utc).AddTicks(6989), new DateTime(2000, 2, 4, 0, 0, 0, 0, DateTimeKind.Unspecified), 0, "Company35@example.com", true, "CompanyFirstName35", false, new DateTime(2024, 8, 15, 1, 13, 49, 161, DateTimeKind.Utc).AddTicks(6990), "CompanyLastName35", 0, false, null, "COMPANY35@EXAMPLE.COM", "COMPANY35", "AQAAAAIAAYagAAAAEK3JbxnMOU+exC6cOxQLvXvHG6Xt/a7qhEXNftH7DTJLiaC5qZ4fuRAYHF58dVJXaQ==", null, false, "https://picsum.photos/seed/user35/200/300", null, new DateTime(2024, 8, 15, 5, 13, 49, 161, DateTimeKind.Local).AddTicks(6985), null, null, false, "Company35" },
                    { 2036, "NULL", 0, "Address36", "City36", "0d32cfdf-528a-46a0-8cb1-33ab0f16301b", new DateTime(2024, 8, 15, 1, 13, 49, 161, DateTimeKind.Utc).AddTicks(7002), new DateTime(2000, 2, 5, 0, 0, 0, 0, DateTimeKind.Unspecified), 0, "Company36@example.com", true, "CompanyFirstName36", false, new DateTime(2024, 8, 15, 1, 13, 49, 161, DateTimeKind.Utc).AddTicks(7003), "CompanyLastName36", 0, false, null, "COMPANY36@EXAMPLE.COM", "COMPANY36", "AQAAAAIAAYagAAAAEK3JbxnMOU+exC6cOxQLvXvHG6Xt/a7qhEXNftH7DTJLiaC5qZ4fuRAYHF58dVJXaQ==", null, false, "https://picsum.photos/seed/user36/200/300", null, new DateTime(2024, 8, 15, 5, 13, 49, 161, DateTimeKind.Local).AddTicks(6997), null, null, false, "Company36" },
                    { 2037, "NULL", 0, "Address37", "City37", "da155a13-0b6e-412e-9937-7e6fc9e1b1e8", new DateTime(2024, 8, 15, 1, 13, 49, 161, DateTimeKind.Utc).AddTicks(7015), new DateTime(2000, 2, 6, 0, 0, 0, 0, DateTimeKind.Unspecified), 0, "Company37@example.com", true, "CompanyFirstName37", false, new DateTime(2024, 8, 15, 1, 13, 49, 161, DateTimeKind.Utc).AddTicks(7016), "CompanyLastName37", 0, false, null, "COMPANY37@EXAMPLE.COM", "COMPANY37", "AQAAAAIAAYagAAAAEK3JbxnMOU+exC6cOxQLvXvHG6Xt/a7qhEXNftH7DTJLiaC5qZ4fuRAYHF58dVJXaQ==", null, false, "https://picsum.photos/seed/user37/200/300", null, new DateTime(2024, 8, 15, 5, 13, 49, 161, DateTimeKind.Local).AddTicks(7010), null, null, false, "Company37" },
                    { 2038, "NULL", 0, "Address38", "City38", "05f401a1-a5b9-4ec4-83c0-ff7fb211e04a", new DateTime(2024, 8, 15, 1, 13, 49, 161, DateTimeKind.Utc).AddTicks(7036), new DateTime(2000, 2, 7, 0, 0, 0, 0, DateTimeKind.Unspecified), 0, "Company38@example.com", true, "CompanyFirstName38", false, new DateTime(2024, 8, 15, 1, 13, 49, 161, DateTimeKind.Utc).AddTicks(7036), "CompanyLastName38", 0, false, null, "COMPANY38@EXAMPLE.COM", "COMPANY38", "AQAAAAIAAYagAAAAEK3JbxnMOU+exC6cOxQLvXvHG6Xt/a7qhEXNftH7DTJLiaC5qZ4fuRAYHF58dVJXaQ==", null, false, "https://picsum.photos/seed/user38/200/300", null, new DateTime(2024, 8, 15, 5, 13, 49, 161, DateTimeKind.Local).AddTicks(7031), null, null, false, "Company38" },
                    { 2039, "NULL", 0, "Address39", "City39", "6ea6ad8a-bf6a-433f-a462-9100c52fd725", new DateTime(2024, 8, 15, 1, 13, 49, 161, DateTimeKind.Utc).AddTicks(7049), new DateTime(2000, 2, 8, 0, 0, 0, 0, DateTimeKind.Unspecified), 0, "Company39@example.com", true, "CompanyFirstName39", false, new DateTime(2024, 8, 15, 1, 13, 49, 161, DateTimeKind.Utc).AddTicks(7049), "CompanyLastName39", 0, false, null, "COMPANY39@EXAMPLE.COM", "COMPANY39", "AQAAAAIAAYagAAAAEK3JbxnMOU+exC6cOxQLvXvHG6Xt/a7qhEXNftH7DTJLiaC5qZ4fuRAYHF58dVJXaQ==", null, false, "https://picsum.photos/seed/user39/200/300", null, new DateTime(2024, 8, 15, 5, 13, 49, 161, DateTimeKind.Local).AddTicks(7044), null, null, false, "Company39" },
                    { 2040, "NULL", 0, "Address40", "City40", "242e51c2-76d7-490e-b878-3246d3af073c", new DateTime(2024, 8, 15, 1, 13, 49, 161, DateTimeKind.Utc).AddTicks(7065), new DateTime(2000, 2, 9, 0, 0, 0, 0, DateTimeKind.Unspecified), 0, "Company40@example.com", true, "CompanyFirstName40", false, new DateTime(2024, 8, 15, 1, 13, 49, 161, DateTimeKind.Utc).AddTicks(7065), "CompanyLastName40", 0, false, null, "COMPANY40@EXAMPLE.COM", "COMPANY40", "AQAAAAIAAYagAAAAEK3JbxnMOU+exC6cOxQLvXvHG6Xt/a7qhEXNftH7DTJLiaC5qZ4fuRAYHF58dVJXaQ==", null, false, "https://picsum.photos/seed/user40/200/300", null, new DateTime(2024, 8, 15, 5, 13, 49, 161, DateTimeKind.Local).AddTicks(7057), null, null, false, "Company40" },
                    { 2041, "NULL", 0, "Address41", "City41", "55ec3270-b436-482b-86c7-ec352384f044", new DateTime(2024, 8, 15, 1, 13, 49, 161, DateTimeKind.Utc).AddTicks(7078), new DateTime(2000, 2, 10, 0, 0, 0, 0, DateTimeKind.Unspecified), 0, "Vet41@example.com", true, "VetFirstName41", false, new DateTime(2024, 8, 15, 1, 13, 49, 161, DateTimeKind.Utc).AddTicks(7079), "VetLastName41", 0, false, null, "VET41@EXAMPLE.COM", "VET41", "AQAAAAIAAYagAAAAEK3JbxnMOU+exC6cOxQLvXvHG6Xt/a7qhEXNftH7DTJLiaC5qZ4fuRAYHF58dVJXaQ==", null, false, "https://picsum.photos/seed/user41/200/300", null, new DateTime(2024, 8, 15, 5, 13, 49, 161, DateTimeKind.Local).AddTicks(7073), null, null, false, "Vet41" },
                    { 2042, "NULL", 0, "Address42", "City42", "4a245672-3bbc-4924-b21d-f08adc16eff9", new DateTime(2024, 8, 15, 1, 13, 49, 161, DateTimeKind.Utc).AddTicks(7096), new DateTime(2000, 2, 11, 0, 0, 0, 0, DateTimeKind.Unspecified), 0, "Vet42@example.com", true, "VetFirstName42", false, new DateTime(2024, 8, 15, 1, 13, 49, 161, DateTimeKind.Utc).AddTicks(7097), "VetLastName42", 0, false, null, "VET42@EXAMPLE.COM", "VET42", "AQAAAAIAAYagAAAAEK3JbxnMOU+exC6cOxQLvXvHG6Xt/a7qhEXNftH7DTJLiaC5qZ4fuRAYHF58dVJXaQ==", null, false, "https://picsum.photos/seed/user42/200/300", null, new DateTime(2024, 8, 15, 5, 13, 49, 161, DateTimeKind.Local).AddTicks(7092), null, null, false, "Vet42" },
                    { 2043, "NULL", 0, "Address43", "City43", "1d0bcb8f-7a14-473e-9f1f-b81b5c6ed64a", new DateTime(2024, 8, 15, 1, 13, 49, 161, DateTimeKind.Utc).AddTicks(7109), new DateTime(2000, 2, 12, 0, 0, 0, 0, DateTimeKind.Unspecified), 0, "Vet43@example.com", true, "VetFirstName43", false, new DateTime(2024, 8, 15, 1, 13, 49, 161, DateTimeKind.Utc).AddTicks(7110), "VetLastName43", 0, false, null, "VET43@EXAMPLE.COM", "VET43", "AQAAAAIAAYagAAAAEK3JbxnMOU+exC6cOxQLvXvHG6Xt/a7qhEXNftH7DTJLiaC5qZ4fuRAYHF58dVJXaQ==", null, false, "https://picsum.photos/seed/user43/200/300", null, new DateTime(2024, 8, 15, 5, 13, 49, 161, DateTimeKind.Local).AddTicks(7105), null, null, false, "Vet43" },
                    { 2044, "NULL", 0, "Address44", "City44", "3681c405-9213-4be4-a93c-f95bb4d0a018", new DateTime(2024, 8, 15, 1, 13, 49, 161, DateTimeKind.Utc).AddTicks(7122), new DateTime(2000, 2, 13, 0, 0, 0, 0, DateTimeKind.Unspecified), 0, "Vet44@example.com", true, "VetFirstName44", false, new DateTime(2024, 8, 15, 1, 13, 49, 161, DateTimeKind.Utc).AddTicks(7123), "VetLastName44", 0, false, null, "VET44@EXAMPLE.COM", "VET44", "AQAAAAIAAYagAAAAEK3JbxnMOU+exC6cOxQLvXvHG6Xt/a7qhEXNftH7DTJLiaC5qZ4fuRAYHF58dVJXaQ==", null, false, "https://picsum.photos/seed/user44/200/300", null, new DateTime(2024, 8, 15, 5, 13, 49, 161, DateTimeKind.Local).AddTicks(7117), null, null, false, "Vet44" },
                    { 2045, "NULL", 0, "Address45", "City45", "e2abd875-2885-40e8-8559-2de5f6913ff9", new DateTime(2024, 8, 15, 1, 13, 49, 161, DateTimeKind.Utc).AddTicks(7135), new DateTime(2000, 2, 14, 0, 0, 0, 0, DateTimeKind.Unspecified), 0, "Vet45@example.com", true, "VetFirstName45", false, new DateTime(2024, 8, 15, 1, 13, 49, 161, DateTimeKind.Utc).AddTicks(7136), "VetLastName45", 0, false, null, "VET45@EXAMPLE.COM", "VET45", "AQAAAAIAAYagAAAAEK3JbxnMOU+exC6cOxQLvXvHG6Xt/a7qhEXNftH7DTJLiaC5qZ4fuRAYHF58dVJXaQ==", null, false, "https://picsum.photos/seed/user45/200/300", null, new DateTime(2024, 8, 15, 5, 13, 49, 161, DateTimeKind.Local).AddTicks(7130), null, null, false, "Vet45" },
                    { 2046, "NULL", 0, "Address46", "City46", "b60c84eb-a122-4837-8ed5-043934545052", new DateTime(2024, 8, 15, 1, 13, 49, 161, DateTimeKind.Utc).AddTicks(7148), new DateTime(2000, 2, 15, 0, 0, 0, 0, DateTimeKind.Unspecified), 0, "Vet46@example.com", true, "VetFirstName46", false, new DateTime(2024, 8, 15, 1, 13, 49, 161, DateTimeKind.Utc).AddTicks(7149), "VetLastName46", 0, false, null, "VET46@EXAMPLE.COM", "VET46", "AQAAAAIAAYagAAAAEK3JbxnMOU+exC6cOxQLvXvHG6Xt/a7qhEXNftH7DTJLiaC5qZ4fuRAYHF58dVJXaQ==", null, false, "https://picsum.photos/seed/user46/200/300", null, new DateTime(2024, 8, 15, 5, 13, 49, 161, DateTimeKind.Local).AddTicks(7143), null, null, false, "Vet46" },
                    { 2047, "NULL", 0, "Address47", "City47", "db5d53d6-4841-47a6-82ee-e323eef10374", new DateTime(2024, 8, 15, 1, 13, 49, 161, DateTimeKind.Utc).AddTicks(7168), new DateTime(2000, 2, 16, 0, 0, 0, 0, DateTimeKind.Unspecified), 0, "Vet47@example.com", true, "VetFirstName47", false, new DateTime(2024, 8, 15, 1, 13, 49, 161, DateTimeKind.Utc).AddTicks(7169), "VetLastName47", 0, false, null, "VET47@EXAMPLE.COM", "VET47", "AQAAAAIAAYagAAAAEK3JbxnMOU+exC6cOxQLvXvHG6Xt/a7qhEXNftH7DTJLiaC5qZ4fuRAYHF58dVJXaQ==", null, false, "https://picsum.photos/seed/user47/200/300", null, new DateTime(2024, 8, 15, 5, 13, 49, 161, DateTimeKind.Local).AddTicks(7163), null, null, false, "Vet47" },
                    { 2048, "NULL", 0, "Address48", "City48", "b82fe1ba-4a41-4098-bb85-3e9c56449a1c", new DateTime(2024, 8, 15, 1, 13, 49, 161, DateTimeKind.Utc).AddTicks(7184), new DateTime(2000, 2, 17, 0, 0, 0, 0, DateTimeKind.Unspecified), 0, "Vet48@example.com", true, "VetFirstName48", false, new DateTime(2024, 8, 15, 1, 13, 49, 161, DateTimeKind.Utc).AddTicks(7184), "VetLastName48", 0, false, null, "VET48@EXAMPLE.COM", "VET48", "AQAAAAIAAYagAAAAEK3JbxnMOU+exC6cOxQLvXvHG6Xt/a7qhEXNftH7DTJLiaC5qZ4fuRAYHF58dVJXaQ==", null, false, "https://picsum.photos/seed/user48/200/300", null, new DateTime(2024, 8, 15, 5, 13, 49, 161, DateTimeKind.Local).AddTicks(7176), null, null, false, "Vet48" },
                    { 2049, "NULL", 0, "Address49", "City49", "ae69d81d-3503-437e-ac67-7ea119c7b635", new DateTime(2024, 8, 15, 1, 13, 49, 161, DateTimeKind.Utc).AddTicks(7197), new DateTime(2000, 2, 18, 0, 0, 0, 0, DateTimeKind.Unspecified), 0, "Vet49@example.com", true, "VetFirstName49", false, new DateTime(2024, 8, 15, 1, 13, 49, 161, DateTimeKind.Utc).AddTicks(7197), "VetLastName49", 0, false, null, "VET49@EXAMPLE.COM", "VET49", "AQAAAAIAAYagAAAAEK3JbxnMOU+exC6cOxQLvXvHG6Xt/a7qhEXNftH7DTJLiaC5qZ4fuRAYHF58dVJXaQ==", null, false, "https://picsum.photos/seed/user49/200/300", null, new DateTime(2024, 8, 15, 5, 13, 49, 161, DateTimeKind.Local).AddTicks(7192), null, null, false, "Vet49" },
                    { 2050, "NULL", 0, "Address50", "City50", "021082fc-de22-4219-981b-20d65bdaabfa", new DateTime(2024, 8, 15, 1, 13, 49, 161, DateTimeKind.Utc).AddTicks(7209), new DateTime(2000, 2, 19, 0, 0, 0, 0, DateTimeKind.Unspecified), 0, "Vet50@example.com", true, "VetFirstName50", false, new DateTime(2024, 8, 15, 1, 13, 49, 161, DateTimeKind.Utc).AddTicks(7210), "VetLastName50", 0, false, null, "VET50@EXAMPLE.COM", "VET50", "AQAAAAIAAYagAAAAEK3JbxnMOU+exC6cOxQLvXvHG6Xt/a7qhEXNftH7DTJLiaC5qZ4fuRAYHF58dVJXaQ==", null, false, "https://picsum.photos/seed/user50/200/300", null, new DateTime(2024, 8, 15, 5, 13, 49, 161, DateTimeKind.Local).AddTicks(7205), null, null, false, "Vet50" },
                    { 2051, "NULL", 0, "Address51", "City51", "e1418f2b-40da-4e78-92fd-865402f34631", new DateTime(2024, 8, 15, 1, 13, 49, 161, DateTimeKind.Utc).AddTicks(7223), new DateTime(2000, 2, 20, 0, 0, 0, 0, DateTimeKind.Unspecified), 0, "Vet51@example.com", true, "VetFirstName51", false, new DateTime(2024, 8, 15, 1, 13, 49, 161, DateTimeKind.Utc).AddTicks(7223), "VetLastName51", 0, false, null, "VET51@EXAMPLE.COM", "VET51", "AQAAAAIAAYagAAAAEK3JbxnMOU+exC6cOxQLvXvHG6Xt/a7qhEXNftH7DTJLiaC5qZ4fuRAYHF58dVJXaQ==", null, false, "https://picsum.photos/seed/user51/200/300", null, new DateTime(2024, 8, 15, 5, 13, 49, 161, DateTimeKind.Local).AddTicks(7218), null, null, false, "Vet51" },
                    { 2052, "NULL", 0, "Address52", "City52", "dc26b1e1-4f62-4786-87dd-d6e0ef4be651", new DateTime(2024, 8, 15, 1, 13, 49, 161, DateTimeKind.Utc).AddTicks(7235), new DateTime(2000, 2, 21, 0, 0, 0, 0, DateTimeKind.Unspecified), 0, "Vet52@example.com", true, "VetFirstName52", false, new DateTime(2024, 8, 15, 1, 13, 49, 161, DateTimeKind.Utc).AddTicks(7236), "VetLastName52", 0, false, null, "VET52@EXAMPLE.COM", "VET52", "AQAAAAIAAYagAAAAEK3JbxnMOU+exC6cOxQLvXvHG6Xt/a7qhEXNftH7DTJLiaC5qZ4fuRAYHF58dVJXaQ==", null, false, "https://picsum.photos/seed/user52/200/300", null, new DateTime(2024, 8, 15, 5, 13, 49, 161, DateTimeKind.Local).AddTicks(7230), null, null, false, "Vet52" },
                    { 2053, "NULL", 0, "Address53", "City53", "4a451653-f37b-4381-a19e-5b620ca5bc79", new DateTime(2024, 8, 15, 1, 13, 49, 161, DateTimeKind.Utc).AddTicks(7248), new DateTime(2000, 2, 22, 0, 0, 0, 0, DateTimeKind.Unspecified), 0, "Vet53@example.com", true, "VetFirstName53", false, new DateTime(2024, 8, 15, 1, 13, 49, 161, DateTimeKind.Utc).AddTicks(7249), "VetLastName53", 0, false, null, "VET53@EXAMPLE.COM", "VET53", "AQAAAAIAAYagAAAAEK3JbxnMOU+exC6cOxQLvXvHG6Xt/a7qhEXNftH7DTJLiaC5qZ4fuRAYHF58dVJXaQ==", null, false, "https://picsum.photos/seed/user53/200/300", null, new DateTime(2024, 8, 15, 5, 13, 49, 161, DateTimeKind.Local).AddTicks(7243), null, null, false, "Vet53" },
                    { 2054, "NULL", 0, "Address54", "City54", "184dc55d-0b5b-43c3-8d18-6b78769d8190", new DateTime(2024, 8, 15, 1, 13, 49, 161, DateTimeKind.Utc).AddTicks(7261), new DateTime(2000, 2, 23, 0, 0, 0, 0, DateTimeKind.Unspecified), 0, "Vet54@example.com", true, "VetFirstName54", false, new DateTime(2024, 8, 15, 1, 13, 49, 161, DateTimeKind.Utc).AddTicks(7261), "VetLastName54", 0, false, null, "VET54@EXAMPLE.COM", "VET54", "AQAAAAIAAYagAAAAEK3JbxnMOU+exC6cOxQLvXvHG6Xt/a7qhEXNftH7DTJLiaC5qZ4fuRAYHF58dVJXaQ==", null, false, "https://picsum.photos/seed/user54/200/300", null, new DateTime(2024, 8, 15, 5, 13, 49, 161, DateTimeKind.Local).AddTicks(7256), null, null, false, "Vet54" },
                    { 2055, "NULL", 0, "Address55", "City55", "7d3a7c49-b103-4bf9-a0dd-bae65bf3f39a", new DateTime(2024, 8, 15, 1, 13, 49, 161, DateTimeKind.Utc).AddTicks(7273), new DateTime(2000, 2, 24, 0, 0, 0, 0, DateTimeKind.Unspecified), 0, "Vet55@example.com", true, "VetFirstName55", false, new DateTime(2024, 8, 15, 1, 13, 49, 161, DateTimeKind.Utc).AddTicks(7274), "VetLastName55", 0, false, null, "VET55@EXAMPLE.COM", "VET55", "AQAAAAIAAYagAAAAEK3JbxnMOU+exC6cOxQLvXvHG6Xt/a7qhEXNftH7DTJLiaC5qZ4fuRAYHF58dVJXaQ==", null, false, "https://picsum.photos/seed/user55/200/300", null, new DateTime(2024, 8, 15, 5, 13, 49, 161, DateTimeKind.Local).AddTicks(7269), null, null, false, "Vet55" },
                    { 2056, "NULL", 0, "Address56", "City56", "ca9aae54-f8fe-4043-a150-027c5ca8fb3a", new DateTime(2024, 8, 15, 1, 13, 49, 161, DateTimeKind.Utc).AddTicks(7289), new DateTime(2000, 2, 25, 0, 0, 0, 0, DateTimeKind.Unspecified), 0, "Vet56@example.com", true, "VetFirstName56", false, new DateTime(2024, 8, 15, 1, 13, 49, 161, DateTimeKind.Utc).AddTicks(7290), "VetLastName56", 0, false, null, "VET56@EXAMPLE.COM", "VET56", "AQAAAAIAAYagAAAAEK3JbxnMOU+exC6cOxQLvXvHG6Xt/a7qhEXNftH7DTJLiaC5qZ4fuRAYHF58dVJXaQ==", null, false, "https://picsum.photos/seed/user56/200/300", null, new DateTime(2024, 8, 15, 5, 13, 49, 161, DateTimeKind.Local).AddTicks(7281), null, null, false, "Vet56" },
                    { 2057, "NULL", 0, "Address57", "City57", "cedacc49-3a41-469c-bc17-d6b8a9f5122d", new DateTime(2024, 8, 15, 1, 13, 49, 161, DateTimeKind.Utc).AddTicks(7310), new DateTime(2000, 2, 26, 0, 0, 0, 0, DateTimeKind.Unspecified), 0, "Vet57@example.com", true, "VetFirstName57", false, new DateTime(2024, 8, 15, 1, 13, 49, 161, DateTimeKind.Utc).AddTicks(7311), "VetLastName57", 0, false, null, "VET57@EXAMPLE.COM", "VET57", "AQAAAAIAAYagAAAAEK3JbxnMOU+exC6cOxQLvXvHG6Xt/a7qhEXNftH7DTJLiaC5qZ4fuRAYHF58dVJXaQ==", null, false, "https://picsum.photos/seed/user57/200/300", null, new DateTime(2024, 8, 15, 5, 13, 49, 161, DateTimeKind.Local).AddTicks(7305), null, null, false, "Vet57" },
                    { 2058, "NULL", 0, "Address58", "City58", "d56008f3-05dc-4995-abb2-1ea2e8e2d0a5", new DateTime(2024, 8, 15, 1, 13, 49, 161, DateTimeKind.Utc).AddTicks(7324), new DateTime(2000, 2, 27, 0, 0, 0, 0, DateTimeKind.Unspecified), 0, "Vet58@example.com", true, "VetFirstName58", false, new DateTime(2024, 8, 15, 1, 13, 49, 161, DateTimeKind.Utc).AddTicks(7324), "VetLastName58", 0, false, null, "VET58@EXAMPLE.COM", "VET58", "AQAAAAIAAYagAAAAEK3JbxnMOU+exC6cOxQLvXvHG6Xt/a7qhEXNftH7DTJLiaC5qZ4fuRAYHF58dVJXaQ==", null, false, "https://picsum.photos/seed/user58/200/300", null, new DateTime(2024, 8, 15, 5, 13, 49, 161, DateTimeKind.Local).AddTicks(7318), null, null, false, "Vet58" },
                    { 2059, "NULL", 0, "Address59", "City59", "ea5c4d22-d962-4b7a-a879-14958d4516e6", new DateTime(2024, 8, 15, 1, 13, 49, 161, DateTimeKind.Utc).AddTicks(7336), new DateTime(2000, 2, 28, 0, 0, 0, 0, DateTimeKind.Unspecified), 0, "Vet59@example.com", true, "VetFirstName59", false, new DateTime(2024, 8, 15, 1, 13, 49, 161, DateTimeKind.Utc).AddTicks(7337), "VetLastName59", 0, false, null, "VET59@EXAMPLE.COM", "VET59", "AQAAAAIAAYagAAAAEK3JbxnMOU+exC6cOxQLvXvHG6Xt/a7qhEXNftH7DTJLiaC5qZ4fuRAYHF58dVJXaQ==", null, false, "https://picsum.photos/seed/user59/200/300", null, new DateTime(2024, 8, 15, 5, 13, 49, 161, DateTimeKind.Local).AddTicks(7332), null, null, false, "Vet59" },
                    { 2060, "NULL", 0, "Address60", "City60", "5a839e7f-cabf-4f0e-942a-617f140fc6c8", new DateTime(2024, 8, 15, 1, 13, 49, 161, DateTimeKind.Utc).AddTicks(7349), new DateTime(2000, 2, 29, 0, 0, 0, 0, DateTimeKind.Unspecified), 0, "Vet60@example.com", true, "VetFirstName60", false, new DateTime(2024, 8, 15, 1, 13, 49, 161, DateTimeKind.Utc).AddTicks(7350), "VetLastName60", 0, false, null, "VET60@EXAMPLE.COM", "VET60", "AQAAAAIAAYagAAAAEK3JbxnMOU+exC6cOxQLvXvHG6Xt/a7qhEXNftH7DTJLiaC5qZ4fuRAYHF58dVJXaQ==", null, false, "https://picsum.photos/seed/user60/200/300", null, new DateTime(2024, 8, 15, 5, 13, 49, 161, DateTimeKind.Local).AddTicks(7344), null, null, false, "Vet60" }
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
                name: "IX_Locations_ShelterId",
                table: "Locations",
                column: "ShelterId",
                unique: true);

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
                name: "Breeds");

            migrationBuilder.DropTable(
                name: "Donations");

            migrationBuilder.DropTable(
                name: "Locations");

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
                name: "PetTypes");

            migrationBuilder.DropTable(
                name: "Shelters");

            migrationBuilder.DropTable(
                name: "AspNetUsers");
        }
    }
}
