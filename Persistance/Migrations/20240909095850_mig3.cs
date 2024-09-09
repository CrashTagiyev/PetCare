using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace Persistance.Migrations
{
    /// <inheritdoc />
    public partial class mig3 : Migration
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
                    { 2001, "Somme about text for something bla bla bla", 0, "Koroglu Rahimov 70", "Baku", null, "dbc0f3f7-5e6b-4527-a73f-6cfe783d66ab", new DateTime(2024, 6, 9, 9, 58, 48, 689, DateTimeKind.Utc).AddTicks(6046), new DateTime(2000, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 1, "user1@example.com", true, "FirstName1", false, new DateTime(2024, 9, 9, 9, 58, 48, 689, DateTimeKind.Utc).AddTicks(6053), "LastName1", 1, false, null, "USER1@EXAMPLE.COM", "USER1", "AQAAAAIAAYagAAAAEK3JbxnMOU+exC6cOxQLvXvHG6Xt/a7qhEXNftH7DTJLiaC5qZ4fuRAYHF58dVJXaQ==", "+993509998485", false, "https://picsum.photos/seed/user1/200/300", null, new DateTime(2024, 9, 9, 9, 58, 48, 689, DateTimeKind.Utc).AddTicks(6040), null, "RYZH37KPG6EEDGSYWW37NETRG56JM7KG", false, "user1" },
                    { 2002, "Somme about text for something bla bla bla", 0, "Koroglu Rahimov 70", "Baku", null, "c7b85f4e-e190-4f10-9399-6e6a058a3e95", new DateTime(2024, 5, 9, 9, 58, 48, 689, DateTimeKind.Utc).AddTicks(6091), new DateTime(2000, 1, 2, 0, 0, 0, 0, DateTimeKind.Unspecified), 1, "user2@example.com", true, "FirstName2", false, new DateTime(2024, 9, 9, 9, 58, 48, 689, DateTimeKind.Utc).AddTicks(6092), "LastName2", 1, false, null, "USER2@EXAMPLE.COM", "USER2", "AQAAAAIAAYagAAAAEK3JbxnMOU+exC6cOxQLvXvHG6Xt/a7qhEXNftH7DTJLiaC5qZ4fuRAYHF58dVJXaQ==", "+993509998485", false, "https://picsum.photos/seed/user2/200/300", null, new DateTime(2024, 9, 9, 9, 58, 48, 689, DateTimeKind.Utc).AddTicks(6074), null, "RYZH37KPG6EEDGSYWW37NETRG56JM7KG", false, "user2" },
                    { 2003, "Somme about text for something bla bla bla", 0, "Koroglu Rahimov 70", "Baku", null, "9714c5c7-190a-4d29-a14f-64674d4cfa29", new DateTime(2024, 8, 9, 9, 58, 48, 689, DateTimeKind.Utc).AddTicks(6104), new DateTime(2000, 1, 3, 0, 0, 0, 0, DateTimeKind.Unspecified), 1, "user3@example.com", true, "FirstName3", false, new DateTime(2024, 9, 9, 9, 58, 48, 689, DateTimeKind.Utc).AddTicks(6105), "LastName3", 1, false, null, "USER3@EXAMPLE.COM", "USER3", "AQAAAAIAAYagAAAAEK3JbxnMOU+exC6cOxQLvXvHG6Xt/a7qhEXNftH7DTJLiaC5qZ4fuRAYHF58dVJXaQ==", "+993509998485", false, "https://picsum.photos/seed/user3/200/300", null, new DateTime(2024, 9, 9, 9, 58, 48, 689, DateTimeKind.Utc).AddTicks(6101), null, "RYZH37KPG6EEDGSYWW37NETRG56JM7KG", false, "user3" },
                    { 2004, "Somme about text for something bla bla bla", 0, "Koroglu Rahimov 70", "Baku", null, "b92ae244-2110-47fc-931c-eec90b7ad022", new DateTime(2024, 3, 9, 9, 58, 48, 689, DateTimeKind.Utc).AddTicks(6117), new DateTime(2000, 1, 4, 0, 0, 0, 0, DateTimeKind.Unspecified), 1, "user4@example.com", true, "FirstName4", false, new DateTime(2024, 9, 9, 9, 58, 48, 689, DateTimeKind.Utc).AddTicks(6118), "LastName4", 1, false, null, "USER4@EXAMPLE.COM", "USER4", "AQAAAAIAAYagAAAAEK3JbxnMOU+exC6cOxQLvXvHG6Xt/a7qhEXNftH7DTJLiaC5qZ4fuRAYHF58dVJXaQ==", "+993509998485", false, "https://picsum.photos/seed/user4/200/300", null, new DateTime(2024, 9, 9, 9, 58, 48, 689, DateTimeKind.Utc).AddTicks(6114), null, "RYZH37KPG6EEDGSYWW37NETRG56JM7KG", false, "user4" },
                    { 2005, "Somme about text for something bla bla bla", 0, "Koroglu Rahimov 70", "Baku", null, "8972cc73-5f44-40c0-8012-4f360fa05fd4", new DateTime(2024, 8, 9, 9, 58, 48, 689, DateTimeKind.Utc).AddTicks(6134), new DateTime(2000, 1, 5, 0, 0, 0, 0, DateTimeKind.Unspecified), 1, "user5@example.com", true, "FirstName5", false, new DateTime(2024, 9, 9, 9, 58, 48, 689, DateTimeKind.Utc).AddTicks(6134), "LastName5", 1, false, null, "USER5@EXAMPLE.COM", "USER5", "AQAAAAIAAYagAAAAEK3JbxnMOU+exC6cOxQLvXvHG6Xt/a7qhEXNftH7DTJLiaC5qZ4fuRAYHF58dVJXaQ==", "+993509998485", false, "https://picsum.photos/seed/user5/200/300", null, new DateTime(2024, 9, 9, 9, 58, 48, 689, DateTimeKind.Utc).AddTicks(6130), null, "RYZH37KPG6EEDGSYWW37NETRG56JM7KG", false, "user5" },
                    { 2006, "Somme about text for something bla bla bla", 0, "Koroglu Rahimov 70", "Baku", null, "7d759e53-64d8-4677-9780-a6f4d81dfe36", new DateTime(2024, 2, 9, 9, 58, 48, 689, DateTimeKind.Utc).AddTicks(6145), new DateTime(2000, 1, 6, 0, 0, 0, 0, DateTimeKind.Unspecified), 1, "user6@example.com", true, "FirstName6", false, new DateTime(2024, 9, 9, 9, 58, 48, 689, DateTimeKind.Utc).AddTicks(6146), "LastName6", 1, false, null, "USER6@EXAMPLE.COM", "USER6", "AQAAAAIAAYagAAAAEK3JbxnMOU+exC6cOxQLvXvHG6Xt/a7qhEXNftH7DTJLiaC5qZ4fuRAYHF58dVJXaQ==", "+993509998485", false, "https://picsum.photos/seed/user6/200/300", null, new DateTime(2024, 9, 9, 9, 58, 48, 689, DateTimeKind.Utc).AddTicks(6142), null, "RYZH37KPG6EEDGSYWW37NETRG56JM7KG", false, "user6" },
                    { 2007, "Somme about text for something bla bla bla", 0, "Koroglu Rahimov 70", "Baku", null, "54c34b54-a97a-460a-92c9-df39ad9d8713", new DateTime(2024, 6, 9, 9, 58, 48, 689, DateTimeKind.Utc).AddTicks(6157), new DateTime(2000, 1, 7, 0, 0, 0, 0, DateTimeKind.Unspecified), 1, "user7@example.com", true, "FirstName7", false, new DateTime(2024, 9, 9, 9, 58, 48, 689, DateTimeKind.Utc).AddTicks(6158), "LastName7", 1, false, null, "USER7@EXAMPLE.COM", "USER7", "AQAAAAIAAYagAAAAEK3JbxnMOU+exC6cOxQLvXvHG6Xt/a7qhEXNftH7DTJLiaC5qZ4fuRAYHF58dVJXaQ==", "+993509998485", false, "https://picsum.photos/seed/user7/200/300", null, new DateTime(2024, 9, 9, 9, 58, 48, 689, DateTimeKind.Utc).AddTicks(6154), null, "RYZH37KPG6EEDGSYWW37NETRG56JM7KG", false, "user7" },
                    { 2008, "Somme about text for something bla bla bla", 0, "Koroglu Rahimov 70", "Baku", null, "40ff3b4c-4f62-4021-8863-446662e9ce85", new DateTime(2024, 6, 9, 9, 58, 48, 689, DateTimeKind.Utc).AddTicks(6267), new DateTime(2000, 1, 8, 0, 0, 0, 0, DateTimeKind.Unspecified), 1, "user8@example.com", true, "FirstName8", false, new DateTime(2024, 9, 9, 9, 58, 48, 689, DateTimeKind.Utc).AddTicks(6268), "LastName8", 1, false, null, "USER8@EXAMPLE.COM", "USER8", "AQAAAAIAAYagAAAAEK3JbxnMOU+exC6cOxQLvXvHG6Xt/a7qhEXNftH7DTJLiaC5qZ4fuRAYHF58dVJXaQ==", "+993509998485", false, "https://picsum.photos/seed/user8/200/300", null, new DateTime(2024, 9, 9, 9, 58, 48, 689, DateTimeKind.Utc).AddTicks(6263), null, "RYZH37KPG6EEDGSYWW37NETRG56JM7KG", false, "user8" },
                    { 2009, "Somme about text for something bla bla bla", 0, "Koroglu Rahimov 70", "Baku", null, "08a56cf9-63d0-4af1-b6bc-6743baa3972a", new DateTime(2024, 3, 9, 9, 58, 48, 689, DateTimeKind.Utc).AddTicks(6280), new DateTime(2000, 1, 9, 0, 0, 0, 0, DateTimeKind.Unspecified), 1, "user9@example.com", true, "FirstName9", false, new DateTime(2024, 9, 9, 9, 58, 48, 689, DateTimeKind.Utc).AddTicks(6281), "LastName9", 1, false, null, "USER9@EXAMPLE.COM", "USER9", "AQAAAAIAAYagAAAAEK3JbxnMOU+exC6cOxQLvXvHG6Xt/a7qhEXNftH7DTJLiaC5qZ4fuRAYHF58dVJXaQ==", "+993509998485", false, "https://picsum.photos/seed/user9/200/300", null, new DateTime(2024, 9, 9, 9, 58, 48, 689, DateTimeKind.Utc).AddTicks(6277), null, "RYZH37KPG6EEDGSYWW37NETRG56JM7KG", false, "user9" },
                    { 2010, "Somme about text for something bla bla bla", 0, "Koroglu Rahimov 70", "Baku", null, "8fdec251-b39b-4bf8-a09e-262460fc8438", new DateTime(2024, 5, 9, 9, 58, 48, 689, DateTimeKind.Utc).AddTicks(6297), new DateTime(2000, 1, 10, 0, 0, 0, 0, DateTimeKind.Unspecified), 1, "user10@example.com", true, "FirstName10", false, new DateTime(2024, 9, 9, 9, 58, 48, 689, DateTimeKind.Utc).AddTicks(6297), "LastName10", 1, false, null, "USER10@EXAMPLE.COM", "USER10", "AQAAAAIAAYagAAAAEK3JbxnMOU+exC6cOxQLvXvHG6Xt/a7qhEXNftH7DTJLiaC5qZ4fuRAYHF58dVJXaQ==", "+993509998485", false, "https://picsum.photos/seed/user10/200/300", null, new DateTime(2024, 9, 9, 9, 58, 48, 689, DateTimeKind.Utc).AddTicks(6289), null, "RYZH37KPG6EEDGSYWW37NETRG56JM7KG", false, "user10" },
                    { 2011, "Somme about text for something bla bla bla", 0, "Koroglu Rahimov 70", "Baku", null, "88592e8f-9f68-44e2-974b-0f21e2607e88", new DateTime(2023, 12, 9, 9, 58, 48, 689, DateTimeKind.Utc).AddTicks(6311), new DateTime(2000, 1, 11, 0, 0, 0, 0, DateTimeKind.Unspecified), 1, "user11@example.com", true, "FirstName11", false, new DateTime(2024, 9, 9, 9, 58, 48, 689, DateTimeKind.Utc).AddTicks(6312), "LastName11", 1, false, null, "USER11@EXAMPLE.COM", "USER11", "AQAAAAIAAYagAAAAEK3JbxnMOU+exC6cOxQLvXvHG6Xt/a7qhEXNftH7DTJLiaC5qZ4fuRAYHF58dVJXaQ==", "+993509998485", false, "https://picsum.photos/seed/user11/200/300", null, new DateTime(2024, 9, 9, 9, 58, 48, 689, DateTimeKind.Utc).AddTicks(6308), null, "RYZH37KPG6EEDGSYWW37NETRG56JM7KG", false, "user11" },
                    { 2012, "Somme about text for something bla bla bla", 0, "Koroglu Rahimov 70", "Baku", null, "90c7efa2-19ce-49ec-8b58-9b7df7153b7b", new DateTime(2024, 7, 9, 9, 58, 48, 689, DateTimeKind.Utc).AddTicks(6323), new DateTime(2000, 1, 12, 0, 0, 0, 0, DateTimeKind.Unspecified), 1, "user12@example.com", true, "FirstName12", false, new DateTime(2024, 9, 9, 9, 58, 48, 689, DateTimeKind.Utc).AddTicks(6324), "LastName12", 1, false, null, "USER12@EXAMPLE.COM", "USER12", "AQAAAAIAAYagAAAAEK3JbxnMOU+exC6cOxQLvXvHG6Xt/a7qhEXNftH7DTJLiaC5qZ4fuRAYHF58dVJXaQ==", "+993509998485", false, "https://picsum.photos/seed/user12/200/300", null, new DateTime(2024, 9, 9, 9, 58, 48, 689, DateTimeKind.Utc).AddTicks(6320), null, "RYZH37KPG6EEDGSYWW37NETRG56JM7KG", false, "user12" },
                    { 2013, "Somme about text for something bla bla bla", 0, "Koroglu Rahimov 70", "Baku", null, "36b830e4-bbe9-4d07-b643-15fb7cfd1e6f", new DateTime(2024, 1, 9, 9, 58, 48, 689, DateTimeKind.Utc).AddTicks(6336), new DateTime(2000, 1, 13, 0, 0, 0, 0, DateTimeKind.Unspecified), 1, "user13@example.com", true, "FirstName13", false, new DateTime(2024, 9, 9, 9, 58, 48, 689, DateTimeKind.Utc).AddTicks(6337), "LastName13", 1, false, null, "USER13@EXAMPLE.COM", "USER13", "AQAAAAIAAYagAAAAEK3JbxnMOU+exC6cOxQLvXvHG6Xt/a7qhEXNftH7DTJLiaC5qZ4fuRAYHF58dVJXaQ==", "+993509998485", false, "https://picsum.photos/seed/user13/200/300", null, new DateTime(2024, 9, 9, 9, 58, 48, 689, DateTimeKind.Utc).AddTicks(6333), null, "RYZH37KPG6EEDGSYWW37NETRG56JM7KG", false, "user13" },
                    { 2014, "Somme about text for something bla bla bla", 0, "Koroglu Rahimov 70", "Baku", null, "bb8ba31a-031e-40e5-8f7a-223ca460fb80", new DateTime(2024, 4, 9, 9, 58, 48, 689, DateTimeKind.Utc).AddTicks(6348), new DateTime(2000, 1, 14, 0, 0, 0, 0, DateTimeKind.Unspecified), 1, "user14@example.com", true, "FirstName14", false, new DateTime(2024, 9, 9, 9, 58, 48, 689, DateTimeKind.Utc).AddTicks(6349), "LastName14", 1, false, null, "USER14@EXAMPLE.COM", "USER14", "AQAAAAIAAYagAAAAEK3JbxnMOU+exC6cOxQLvXvHG6Xt/a7qhEXNftH7DTJLiaC5qZ4fuRAYHF58dVJXaQ==", "+993509998485", false, "https://picsum.photos/seed/user14/200/300", null, new DateTime(2024, 9, 9, 9, 58, 48, 689, DateTimeKind.Utc).AddTicks(6345), null, "RYZH37KPG6EEDGSYWW37NETRG56JM7KG", false, "user14" },
                    { 2015, "Somme about text for something bla bla bla", 0, "Koroglu Rahimov 70", "Baku", null, "8d8e5f1c-eff0-49d7-8e85-4b8546b5aa4f", new DateTime(2024, 7, 9, 9, 58, 48, 689, DateTimeKind.Utc).AddTicks(6361), new DateTime(2000, 1, 15, 0, 0, 0, 0, DateTimeKind.Unspecified), 1, "user15@example.com", true, "FirstName15", false, new DateTime(2024, 9, 9, 9, 58, 48, 689, DateTimeKind.Utc).AddTicks(6362), "LastName15", 1, false, null, "USER15@EXAMPLE.COM", "USER15", "AQAAAAIAAYagAAAAEK3JbxnMOU+exC6cOxQLvXvHG6Xt/a7qhEXNftH7DTJLiaC5qZ4fuRAYHF58dVJXaQ==", "+993509998485", false, "https://picsum.photos/seed/user15/200/300", null, new DateTime(2024, 9, 9, 9, 58, 48, 689, DateTimeKind.Utc).AddTicks(6357), null, "RYZH37KPG6EEDGSYWW37NETRG56JM7KG", false, "user15" },
                    { 2016, "Somme about text for something bla bla bla", 0, "Koroglu Rahimov 70", "Baku", null, "93a6e73e-98a2-4883-8cb1-9c7863ff93f8", new DateTime(2024, 1, 9, 9, 58, 48, 689, DateTimeKind.Utc).AddTicks(6373), new DateTime(2000, 1, 16, 0, 0, 0, 0, DateTimeKind.Unspecified), 1, "user16@example.com", true, "FirstName16", false, new DateTime(2024, 9, 9, 9, 58, 48, 689, DateTimeKind.Utc).AddTicks(6374), "LastName16", 1, false, null, "USER16@EXAMPLE.COM", "USER16", "AQAAAAIAAYagAAAAEK3JbxnMOU+exC6cOxQLvXvHG6Xt/a7qhEXNftH7DTJLiaC5qZ4fuRAYHF58dVJXaQ==", "+993509998485", false, "https://picsum.photos/seed/user16/200/300", null, new DateTime(2024, 9, 9, 9, 58, 48, 689, DateTimeKind.Utc).AddTicks(6370), null, "RYZH37KPG6EEDGSYWW37NETRG56JM7KG", false, "user16" },
                    { 2017, "Somme about text for something bla bla bla", 0, "Koroglu Rahimov 70", "Baku", null, "4cb18820-3480-48f0-94aa-94a2889efe70", new DateTime(2024, 4, 9, 9, 58, 48, 689, DateTimeKind.Utc).AddTicks(6464), new DateTime(2000, 1, 17, 0, 0, 0, 0, DateTimeKind.Unspecified), 1, "user17@example.com", true, "FirstName17", false, new DateTime(2024, 9, 9, 9, 58, 48, 689, DateTimeKind.Utc).AddTicks(6465), "LastName17", 1, false, null, "USER17@EXAMPLE.COM", "USER17", "AQAAAAIAAYagAAAAEK3JbxnMOU+exC6cOxQLvXvHG6Xt/a7qhEXNftH7DTJLiaC5qZ4fuRAYHF58dVJXaQ==", "+993509998485", false, "https://picsum.photos/seed/user17/200/300", null, new DateTime(2024, 9, 9, 9, 58, 48, 689, DateTimeKind.Utc).AddTicks(6460), null, "RYZH37KPG6EEDGSYWW37NETRG56JM7KG", false, "user17" },
                    { 2018, "Somme about text for something bla bla bla", 0, "Koroglu Rahimov 70", "Baku", null, "9e630d2b-690b-41b4-92ae-0b8aa780ce80", new DateTime(2023, 12, 9, 9, 58, 48, 689, DateTimeKind.Utc).AddTicks(6480), new DateTime(2000, 1, 18, 0, 0, 0, 0, DateTimeKind.Unspecified), 1, "user18@example.com", true, "FirstName18", false, new DateTime(2024, 9, 9, 9, 58, 48, 689, DateTimeKind.Utc).AddTicks(6481), "LastName18", 1, false, null, "USER18@EXAMPLE.COM", "USER18", "AQAAAAIAAYagAAAAEK3JbxnMOU+exC6cOxQLvXvHG6Xt/a7qhEXNftH7DTJLiaC5qZ4fuRAYHF58dVJXaQ==", "+993509998485", false, "https://picsum.photos/seed/user18/200/300", null, new DateTime(2024, 9, 9, 9, 58, 48, 689, DateTimeKind.Utc).AddTicks(6474), null, "RYZH37KPG6EEDGSYWW37NETRG56JM7KG", false, "user18" },
                    { 2019, "Somme about text for something bla bla bla", 0, "Koroglu Rahimov 70", "Baku", null, "ed82a3eb-af43-4735-8be6-44e0ba8106f0", new DateTime(2024, 3, 9, 9, 58, 48, 689, DateTimeKind.Utc).AddTicks(6491), new DateTime(2000, 1, 19, 0, 0, 0, 0, DateTimeKind.Unspecified), 1, "user19@example.com", true, "FirstName19", false, new DateTime(2024, 9, 9, 9, 58, 48, 689, DateTimeKind.Utc).AddTicks(6492), "LastName19", 1, false, null, "USER19@EXAMPLE.COM", "USER19", "AQAAAAIAAYagAAAAEK3JbxnMOU+exC6cOxQLvXvHG6Xt/a7qhEXNftH7DTJLiaC5qZ4fuRAYHF58dVJXaQ==", "+993509998485", false, "https://picsum.photos/seed/user19/200/300", null, new DateTime(2024, 9, 9, 9, 58, 48, 689, DateTimeKind.Utc).AddTicks(6488), null, "RYZH37KPG6EEDGSYWW37NETRG56JM7KG", false, "user19" },
                    { 2020, "Somme about text for something bla bla bla", 0, "Koroglu Rahimov 70", "Baku", null, "51bd634e-f2da-468e-aca1-5d2ffc6e324e", new DateTime(2023, 10, 9, 9, 58, 48, 689, DateTimeKind.Utc).AddTicks(6503), new DateTime(2000, 1, 20, 0, 0, 0, 0, DateTimeKind.Unspecified), 1, "user20@example.com", true, "FirstName20", false, new DateTime(2024, 9, 9, 9, 58, 48, 689, DateTimeKind.Utc).AddTicks(6504), "LastName20", 1, false, null, "USER20@EXAMPLE.COM", "USER20", "AQAAAAIAAYagAAAAEK3JbxnMOU+exC6cOxQLvXvHG6Xt/a7qhEXNftH7DTJLiaC5qZ4fuRAYHF58dVJXaQ==", "+993509998485", false, "https://picsum.photos/seed/user20/200/300", null, new DateTime(2024, 9, 9, 9, 58, 48, 689, DateTimeKind.Utc).AddTicks(6500), null, "RYZH37KPG6EEDGSYWW37NETRG56JM7KG", false, "user20" },
                    { 2021, "Somme about text for something bla bla bla", 0, "Koroglu Rahimov 70", "Baku", "Company Name21", "0aee1577-1b33-46bd-80d3-f57dec60fcd2", new DateTime(2023, 10, 9, 9, 58, 48, 689, DateTimeKind.Utc).AddTicks(6515), new DateTime(2000, 1, 21, 0, 0, 0, 0, DateTimeKind.Unspecified), 1, "Company21@example.com", true, "CompanyFirstName21", false, new DateTime(2024, 9, 9, 9, 58, 48, 689, DateTimeKind.Utc).AddTicks(6516), "CompanyLastName21", 1, false, null, "COMPANY21@EXAMPLE.COM", "COMPANY21", "AQAAAAIAAYagAAAAEK3JbxnMOU+exC6cOxQLvXvHG6Xt/a7qhEXNftH7DTJLiaC5qZ4fuRAYHF58dVJXaQ==", "+993509998485", false, "https://picsum.photos/seed/user21/200/300", null, new DateTime(2024, 9, 9, 9, 58, 48, 689, DateTimeKind.Utc).AddTicks(6512), null, "RYZH37KPG6EEDGSYWW37NETRG56JM7KG", false, "Company21" },
                    { 2022, "Somme about text for something bla bla bla", 0, "Koroglu Rahimov 70", "Baku", "Company Name22", "2726a9e4-19ab-4b11-a9dc-9adfd4a41f7a", new DateTime(2024, 7, 9, 9, 58, 48, 689, DateTimeKind.Utc).AddTicks(6535), new DateTime(2000, 1, 22, 0, 0, 0, 0, DateTimeKind.Unspecified), 1, "Company22@example.com", true, "CompanyFirstName22", false, new DateTime(2024, 9, 9, 9, 58, 48, 689, DateTimeKind.Utc).AddTicks(6535), "CompanyLastName22", 1, false, null, "COMPANY22@EXAMPLE.COM", "COMPANY22", "AQAAAAIAAYagAAAAEK3JbxnMOU+exC6cOxQLvXvHG6Xt/a7qhEXNftH7DTJLiaC5qZ4fuRAYHF58dVJXaQ==", "+993509998485", false, "https://picsum.photos/seed/user22/200/300", null, new DateTime(2024, 9, 9, 9, 58, 48, 689, DateTimeKind.Utc).AddTicks(6532), null, "RYZH37KPG6EEDGSYWW37NETRG56JM7KG", false, "Company22" },
                    { 2023, "Somme about text for something bla bla bla", 0, "Koroglu Rahimov 70", "Baku", "Company Name23", "c51a1002-2df6-4bb2-aba4-09a54d1c2e35", new DateTime(2024, 2, 9, 9, 58, 48, 689, DateTimeKind.Utc).AddTicks(6548), new DateTime(2000, 1, 23, 0, 0, 0, 0, DateTimeKind.Unspecified), 1, "Company23@example.com", true, "CompanyFirstName23", false, new DateTime(2024, 9, 9, 9, 58, 48, 689, DateTimeKind.Utc).AddTicks(6549), "CompanyLastName23", 1, false, null, "COMPANY23@EXAMPLE.COM", "COMPANY23", "AQAAAAIAAYagAAAAEK3JbxnMOU+exC6cOxQLvXvHG6Xt/a7qhEXNftH7DTJLiaC5qZ4fuRAYHF58dVJXaQ==", "+993509998485", false, "https://picsum.photos/seed/user23/200/300", null, new DateTime(2024, 9, 9, 9, 58, 48, 689, DateTimeKind.Utc).AddTicks(6544), null, "RYZH37KPG6EEDGSYWW37NETRG56JM7KG", false, "Company23" },
                    { 2024, "Somme about text for something bla bla bla", 0, "Koroglu Rahimov 70", "Baku", "Company Name24", "ae2988ec-046c-4473-92e3-b0ad7f4f4115", new DateTime(2024, 2, 9, 9, 58, 48, 689, DateTimeKind.Utc).AddTicks(6560), new DateTime(2000, 1, 24, 0, 0, 0, 0, DateTimeKind.Unspecified), 1, "Company24@example.com", true, "CompanyFirstName24", false, new DateTime(2024, 9, 9, 9, 58, 48, 689, DateTimeKind.Utc).AddTicks(6561), "CompanyLastName24", 1, false, null, "COMPANY24@EXAMPLE.COM", "COMPANY24", "AQAAAAIAAYagAAAAEK3JbxnMOU+exC6cOxQLvXvHG6Xt/a7qhEXNftH7DTJLiaC5qZ4fuRAYHF58dVJXaQ==", "+993509998485", false, "https://picsum.photos/seed/user24/200/300", null, new DateTime(2024, 9, 9, 9, 58, 48, 689, DateTimeKind.Utc).AddTicks(6557), null, "RYZH37KPG6EEDGSYWW37NETRG56JM7KG", false, "Company24" },
                    { 2025, "Somme about text for something bla bla bla", 0, "Koroglu Rahimov 70", "Baku", "Company Name25", "a344cdea-4939-4669-b1fd-3b2df01b6c46", new DateTime(2024, 3, 9, 9, 58, 48, 689, DateTimeKind.Utc).AddTicks(6573), new DateTime(2000, 1, 25, 0, 0, 0, 0, DateTimeKind.Unspecified), 1, "Company25@example.com", true, "CompanyFirstName25", false, new DateTime(2024, 9, 9, 9, 58, 48, 689, DateTimeKind.Utc).AddTicks(6574), "CompanyLastName25", 1, false, null, "COMPANY25@EXAMPLE.COM", "COMPANY25", "AQAAAAIAAYagAAAAEK3JbxnMOU+exC6cOxQLvXvHG6Xt/a7qhEXNftH7DTJLiaC5qZ4fuRAYHF58dVJXaQ==", "+993509998485", false, "https://picsum.photos/seed/user25/200/300", null, new DateTime(2024, 9, 9, 9, 58, 48, 689, DateTimeKind.Utc).AddTicks(6570), null, "RYZH37KPG6EEDGSYWW37NETRG56JM7KG", false, "Company25" },
                    { 2026, "Somme about text for something bla bla bla", 0, "Koroglu Rahimov 70", "Baku", "Company Name26", "cb8e9ae2-16ad-4a2f-b3b9-349fc384e419", new DateTime(2024, 2, 9, 9, 58, 48, 689, DateTimeKind.Utc).AddTicks(6644), new DateTime(2000, 1, 26, 0, 0, 0, 0, DateTimeKind.Unspecified), 1, "Company26@example.com", true, "CompanyFirstName26", false, new DateTime(2024, 9, 9, 9, 58, 48, 689, DateTimeKind.Utc).AddTicks(6645), "CompanyLastName26", 1, false, null, "COMPANY26@EXAMPLE.COM", "COMPANY26", "AQAAAAIAAYagAAAAEK3JbxnMOU+exC6cOxQLvXvHG6Xt/a7qhEXNftH7DTJLiaC5qZ4fuRAYHF58dVJXaQ==", "+993509998485", false, "https://picsum.photos/seed/user26/200/300", null, new DateTime(2024, 9, 9, 9, 58, 48, 689, DateTimeKind.Utc).AddTicks(6638), null, "RYZH37KPG6EEDGSYWW37NETRG56JM7KG", false, "Company26" },
                    { 2027, "Somme about text for something bla bla bla", 0, "Koroglu Rahimov 70", "Baku", "Company Name27", "8a9a5b53-fd6f-4bd1-97fd-02d03a0b186a", new DateTime(2024, 5, 9, 9, 58, 48, 689, DateTimeKind.Utc).AddTicks(6658), new DateTime(2000, 1, 27, 0, 0, 0, 0, DateTimeKind.Unspecified), 1, "Company27@example.com", true, "CompanyFirstName27", false, new DateTime(2024, 9, 9, 9, 58, 48, 689, DateTimeKind.Utc).AddTicks(6659), "CompanyLastName27", 1, false, null, "COMPANY27@EXAMPLE.COM", "COMPANY27", "AQAAAAIAAYagAAAAEK3JbxnMOU+exC6cOxQLvXvHG6Xt/a7qhEXNftH7DTJLiaC5qZ4fuRAYHF58dVJXaQ==", "+993509998485", false, "https://picsum.photos/seed/user27/200/300", null, new DateTime(2024, 9, 9, 9, 58, 48, 689, DateTimeKind.Utc).AddTicks(6655), null, "RYZH37KPG6EEDGSYWW37NETRG56JM7KG", false, "Company27" },
                    { 2028, "Somme about text for something bla bla bla", 0, "Koroglu Rahimov 70", "Baku", "Company Name28", "ddea3898-77a9-43b8-b171-faf73a988641", new DateTime(2024, 5, 9, 9, 58, 48, 689, DateTimeKind.Utc).AddTicks(6671), new DateTime(2000, 1, 28, 0, 0, 0, 0, DateTimeKind.Unspecified), 1, "Company28@example.com", true, "CompanyFirstName28", false, new DateTime(2024, 9, 9, 9, 58, 48, 689, DateTimeKind.Utc).AddTicks(6672), "CompanyLastName28", 1, false, null, "COMPANY28@EXAMPLE.COM", "COMPANY28", "AQAAAAIAAYagAAAAEK3JbxnMOU+exC6cOxQLvXvHG6Xt/a7qhEXNftH7DTJLiaC5qZ4fuRAYHF58dVJXaQ==", "+993509998485", false, "https://picsum.photos/seed/user28/200/300", null, new DateTime(2024, 9, 9, 9, 58, 48, 689, DateTimeKind.Utc).AddTicks(6668), null, "RYZH37KPG6EEDGSYWW37NETRG56JM7KG", false, "Company28" },
                    { 2029, "Somme about text for something bla bla bla", 0, "Koroglu Rahimov 70", "Baku", "Company Name29", "5bf4c76e-ca93-4632-85a5-5c3b2170f342", new DateTime(2024, 7, 9, 9, 58, 48, 689, DateTimeKind.Utc).AddTicks(6684), new DateTime(2000, 1, 29, 0, 0, 0, 0, DateTimeKind.Unspecified), 1, "Company29@example.com", true, "CompanyFirstName29", false, new DateTime(2024, 9, 9, 9, 58, 48, 689, DateTimeKind.Utc).AddTicks(6684), "CompanyLastName29", 1, false, null, "COMPANY29@EXAMPLE.COM", "COMPANY29", "AQAAAAIAAYagAAAAEK3JbxnMOU+exC6cOxQLvXvHG6Xt/a7qhEXNftH7DTJLiaC5qZ4fuRAYHF58dVJXaQ==", "+993509998485", false, "https://picsum.photos/seed/user29/200/300", null, new DateTime(2024, 9, 9, 9, 58, 48, 689, DateTimeKind.Utc).AddTicks(6680), null, "RYZH37KPG6EEDGSYWW37NETRG56JM7KG", false, "Company29" },
                    { 2030, "Somme about text for something bla bla bla", 0, "Koroglu Rahimov 70", "Baku", "Company Name30", "8bebd0bb-c9bf-44d2-9e39-bcc083a9d3e4", new DateTime(2024, 7, 9, 9, 58, 48, 689, DateTimeKind.Utc).AddTicks(6696), new DateTime(2000, 1, 30, 0, 0, 0, 0, DateTimeKind.Unspecified), 1, "Company30@example.com", true, "CompanyFirstName30", false, new DateTime(2024, 9, 9, 9, 58, 48, 689, DateTimeKind.Utc).AddTicks(6697), "CompanyLastName30", 1, false, null, "COMPANY30@EXAMPLE.COM", "COMPANY30", "AQAAAAIAAYagAAAAEK3JbxnMOU+exC6cOxQLvXvHG6Xt/a7qhEXNftH7DTJLiaC5qZ4fuRAYHF58dVJXaQ==", "+993509998485", false, "https://picsum.photos/seed/user30/200/300", null, new DateTime(2024, 9, 9, 9, 58, 48, 689, DateTimeKind.Utc).AddTicks(6693), null, "RYZH37KPG6EEDGSYWW37NETRG56JM7KG", false, "Company30" },
                    { 2031, "Somme about text for something bla bla bla", 0, "Koroglu Rahimov 70", "Baku", "Company Name31", "0539f62a-dc07-465c-84fc-a95d96969ab1", new DateTime(2023, 12, 9, 9, 58, 48, 689, DateTimeKind.Utc).AddTicks(6709), new DateTime(2000, 1, 31, 0, 0, 0, 0, DateTimeKind.Unspecified), 1, "Company31@example.com", true, "CompanyFirstName31", false, new DateTime(2024, 9, 9, 9, 58, 48, 689, DateTimeKind.Utc).AddTicks(6710), "CompanyLastName31", 1, false, null, "COMPANY31@EXAMPLE.COM", "COMPANY31", "AQAAAAIAAYagAAAAEK3JbxnMOU+exC6cOxQLvXvHG6Xt/a7qhEXNftH7DTJLiaC5qZ4fuRAYHF58dVJXaQ==", "+993509998485", false, "https://picsum.photos/seed/user31/200/300", null, new DateTime(2024, 9, 9, 9, 58, 48, 689, DateTimeKind.Utc).AddTicks(6706), null, "RYZH37KPG6EEDGSYWW37NETRG56JM7KG", false, "Company31" },
                    { 2032, "Somme about text for something bla bla bla", 0, "Koroglu Rahimov 70", "Baku", "Company Name32", "a029d56f-32e3-454b-b947-c3873e4e8548", new DateTime(2024, 5, 9, 9, 58, 48, 689, DateTimeKind.Utc).AddTicks(6722), new DateTime(2000, 2, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 1, "Company32@example.com", true, "CompanyFirstName32", false, new DateTime(2024, 9, 9, 9, 58, 48, 689, DateTimeKind.Utc).AddTicks(6722), "CompanyLastName32", 1, false, null, "COMPANY32@EXAMPLE.COM", "COMPANY32", "AQAAAAIAAYagAAAAEK3JbxnMOU+exC6cOxQLvXvHG6Xt/a7qhEXNftH7DTJLiaC5qZ4fuRAYHF58dVJXaQ==", "+993509998485", false, "https://picsum.photos/seed/user32/200/300", null, new DateTime(2024, 9, 9, 9, 58, 48, 689, DateTimeKind.Utc).AddTicks(6719), null, "RYZH37KPG6EEDGSYWW37NETRG56JM7KG", false, "Company32" },
                    { 2033, "Somme about text for something bla bla bla", 0, "Koroglu Rahimov 70", "Baku", "Company Name33", "67fff504-11d0-4387-b640-d70ae7faaa37", new DateTime(2024, 5, 9, 9, 58, 48, 689, DateTimeKind.Utc).AddTicks(6736), new DateTime(2000, 2, 2, 0, 0, 0, 0, DateTimeKind.Unspecified), 1, "Company33@example.com", true, "CompanyFirstName33", false, new DateTime(2024, 9, 9, 9, 58, 48, 689, DateTimeKind.Utc).AddTicks(6737), "CompanyLastName33", 1, false, null, "COMPANY33@EXAMPLE.COM", "COMPANY33", "AQAAAAIAAYagAAAAEK3JbxnMOU+exC6cOxQLvXvHG6Xt/a7qhEXNftH7DTJLiaC5qZ4fuRAYHF58dVJXaQ==", "+993509998485", false, "https://picsum.photos/seed/user33/200/300", null, new DateTime(2024, 9, 9, 9, 58, 48, 689, DateTimeKind.Utc).AddTicks(6733), null, "RYZH37KPG6EEDGSYWW37NETRG56JM7KG", false, "Company33" },
                    { 2034, "Somme about text for something bla bla bla", 0, "Koroglu Rahimov 70", "Baku", "Company Name34", "28f8682a-984b-4cb1-b54b-914e4cc6db2f", new DateTime(2023, 12, 9, 9, 58, 48, 689, DateTimeKind.Utc).AddTicks(6752), new DateTime(2000, 2, 3, 0, 0, 0, 0, DateTimeKind.Unspecified), 1, "Company34@example.com", true, "CompanyFirstName34", false, new DateTime(2024, 9, 9, 9, 58, 48, 689, DateTimeKind.Utc).AddTicks(6753), "CompanyLastName34", 1, false, null, "COMPANY34@EXAMPLE.COM", "COMPANY34", "AQAAAAIAAYagAAAAEK3JbxnMOU+exC6cOxQLvXvHG6Xt/a7qhEXNftH7DTJLiaC5qZ4fuRAYHF58dVJXaQ==", "+993509998485", false, "https://picsum.photos/seed/user34/200/300", null, new DateTime(2024, 9, 9, 9, 58, 48, 689, DateTimeKind.Utc).AddTicks(6746), null, "RYZH37KPG6EEDGSYWW37NETRG56JM7KG", false, "Company34" },
                    { 2035, "Somme about text for something bla bla bla", 0, "Koroglu Rahimov 70", "Baku", "Company Name35", "b354827b-30d4-49e9-9ebc-9f08bdd881ff", new DateTime(2023, 10, 9, 9, 58, 48, 689, DateTimeKind.Utc).AddTicks(6823), new DateTime(2000, 2, 4, 0, 0, 0, 0, DateTimeKind.Unspecified), 1, "Company35@example.com", true, "CompanyFirstName35", false, new DateTime(2024, 9, 9, 9, 58, 48, 689, DateTimeKind.Utc).AddTicks(6824), "CompanyLastName35", 1, false, null, "COMPANY35@EXAMPLE.COM", "COMPANY35", "AQAAAAIAAYagAAAAEK3JbxnMOU+exC6cOxQLvXvHG6Xt/a7qhEXNftH7DTJLiaC5qZ4fuRAYHF58dVJXaQ==", "+993509998485", false, "https://picsum.photos/seed/user35/200/300", null, new DateTime(2024, 9, 9, 9, 58, 48, 689, DateTimeKind.Utc).AddTicks(6820), null, "RYZH37KPG6EEDGSYWW37NETRG56JM7KG", false, "Company35" },
                    { 2036, "Somme about text for something bla bla bla", 0, "Koroglu Rahimov 70", "Baku", "Company Name36", "7ecf11f8-ba83-4e60-a2e6-dd64821e4e3d", new DateTime(2024, 4, 9, 9, 58, 48, 689, DateTimeKind.Utc).AddTicks(6836), new DateTime(2000, 2, 5, 0, 0, 0, 0, DateTimeKind.Unspecified), 1, "Company36@example.com", true, "CompanyFirstName36", false, new DateTime(2024, 9, 9, 9, 58, 48, 689, DateTimeKind.Utc).AddTicks(6837), "CompanyLastName36", 1, false, null, "COMPANY36@EXAMPLE.COM", "COMPANY36", "AQAAAAIAAYagAAAAEK3JbxnMOU+exC6cOxQLvXvHG6Xt/a7qhEXNftH7DTJLiaC5qZ4fuRAYHF58dVJXaQ==", "+993509998485", false, "https://picsum.photos/seed/user36/200/300", null, new DateTime(2024, 9, 9, 9, 58, 48, 689, DateTimeKind.Utc).AddTicks(6833), null, "RYZH37KPG6EEDGSYWW37NETRG56JM7KG", false, "Company36" },
                    { 2037, "Somme about text for something bla bla bla", 0, "Koroglu Rahimov 70", "Baku", "Company Name37", "c88ee0d0-7da7-49a3-86e3-4f0608c1d2d6", new DateTime(2024, 1, 9, 9, 58, 48, 689, DateTimeKind.Utc).AddTicks(6849), new DateTime(2000, 2, 6, 0, 0, 0, 0, DateTimeKind.Unspecified), 1, "Company37@example.com", true, "CompanyFirstName37", false, new DateTime(2024, 9, 9, 9, 58, 48, 689, DateTimeKind.Utc).AddTicks(6850), "CompanyLastName37", 1, false, null, "COMPANY37@EXAMPLE.COM", "COMPANY37", "AQAAAAIAAYagAAAAEK3JbxnMOU+exC6cOxQLvXvHG6Xt/a7qhEXNftH7DTJLiaC5qZ4fuRAYHF58dVJXaQ==", "+993509998485", false, "https://picsum.photos/seed/user37/200/300", null, new DateTime(2024, 9, 9, 9, 58, 48, 689, DateTimeKind.Utc).AddTicks(6846), null, "RYZH37KPG6EEDGSYWW37NETRG56JM7KG", false, "Company37" },
                    { 2038, "Somme about text for something bla bla bla", 0, "Koroglu Rahimov 70", "Baku", "Company Name38", "0d16ef15-ddc9-499c-a0e0-60025bf2396d", new DateTime(2023, 12, 9, 9, 58, 48, 689, DateTimeKind.Utc).AddTicks(6862), new DateTime(2000, 2, 7, 0, 0, 0, 0, DateTimeKind.Unspecified), 1, "Company38@example.com", true, "CompanyFirstName38", false, new DateTime(2024, 9, 9, 9, 58, 48, 689, DateTimeKind.Utc).AddTicks(6862), "CompanyLastName38", 1, false, null, "COMPANY38@EXAMPLE.COM", "COMPANY38", "AQAAAAIAAYagAAAAEK3JbxnMOU+exC6cOxQLvXvHG6Xt/a7qhEXNftH7DTJLiaC5qZ4fuRAYHF58dVJXaQ==", "+993509998485", false, "https://picsum.photos/seed/user38/200/300", null, new DateTime(2024, 9, 9, 9, 58, 48, 689, DateTimeKind.Utc).AddTicks(6859), null, "RYZH37KPG6EEDGSYWW37NETRG56JM7KG", false, "Company38" },
                    { 2039, "Somme about text for something bla bla bla", 0, "Koroglu Rahimov 70", "Baku", "Company Name39", "29fad224-0806-44d8-ada3-5298b7a9e2a4", new DateTime(2024, 2, 9, 9, 58, 48, 689, DateTimeKind.Utc).AddTicks(6874), new DateTime(2000, 2, 8, 0, 0, 0, 0, DateTimeKind.Unspecified), 1, "Company39@example.com", true, "CompanyFirstName39", false, new DateTime(2024, 9, 9, 9, 58, 48, 689, DateTimeKind.Utc).AddTicks(6875), "CompanyLastName39", 1, false, null, "COMPANY39@EXAMPLE.COM", "COMPANY39", "AQAAAAIAAYagAAAAEK3JbxnMOU+exC6cOxQLvXvHG6Xt/a7qhEXNftH7DTJLiaC5qZ4fuRAYHF58dVJXaQ==", "+993509998485", false, "https://picsum.photos/seed/user39/200/300", null, new DateTime(2024, 9, 9, 9, 58, 48, 689, DateTimeKind.Utc).AddTicks(6871), null, "RYZH37KPG6EEDGSYWW37NETRG56JM7KG", false, "Company39" },
                    { 2040, "Somme about text for something bla bla bla", 0, "Koroglu Rahimov 70", "Baku", "Company Name40", "37d93c2a-4a0a-4007-b3f4-2de372614eeb", new DateTime(2023, 10, 9, 9, 58, 48, 689, DateTimeKind.Utc).AddTicks(6887), new DateTime(2000, 2, 9, 0, 0, 0, 0, DateTimeKind.Unspecified), 1, "Company40@example.com", true, "CompanyFirstName40", false, new DateTime(2024, 9, 9, 9, 58, 48, 689, DateTimeKind.Utc).AddTicks(6888), "CompanyLastName40", 1, false, null, "COMPANY40@EXAMPLE.COM", "COMPANY40", "AQAAAAIAAYagAAAAEK3JbxnMOU+exC6cOxQLvXvHG6Xt/a7qhEXNftH7DTJLiaC5qZ4fuRAYHF58dVJXaQ==", "+993509998485", false, "https://picsum.photos/seed/user40/200/300", null, new DateTime(2024, 9, 9, 9, 58, 48, 689, DateTimeKind.Utc).AddTicks(6884), null, "RYZH37KPG6EEDGSYWW37NETRG56JM7KG", false, "Company40" },
                    { 2041, "Somme about text for something bla bla bla", 0, "Koroglu Rahimov 70", "Baku", null, "28ca8ccf-edbd-437c-b0c2-758301a271fd", new DateTime(2023, 11, 9, 9, 58, 48, 689, DateTimeKind.Utc).AddTicks(6900), new DateTime(2000, 2, 10, 0, 0, 0, 0, DateTimeKind.Unspecified), 1, "Vet41@example.com", true, "VetFirstName41", false, new DateTime(2024, 9, 9, 9, 58, 48, 689, DateTimeKind.Utc).AddTicks(6901), "VetLastName41", 1, false, null, "VET41@EXAMPLE.COM", "VET41", "AQAAAAIAAYagAAAAEK3JbxnMOU+exC6cOxQLvXvHG6Xt/a7qhEXNftH7DTJLiaC5qZ4fuRAYHF58dVJXaQ==", "+993509998485", false, "https://picsum.photos/seed/user41/200/300", null, new DateTime(2024, 9, 9, 9, 58, 48, 689, DateTimeKind.Utc).AddTicks(6897), null, "RYZH37KPG6EEDGSYWW37NETRG56JM7KG", false, "Vet41" },
                    { 2042, "Somme about text for something bla bla bla", 0, "Koroglu Rahimov 70", "Baku", null, "cc45e0d3-980c-4cf9-9377-978866834a74", new DateTime(2024, 8, 9, 9, 58, 48, 689, DateTimeKind.Utc).AddTicks(6921), new DateTime(2000, 2, 11, 0, 0, 0, 0, DateTimeKind.Unspecified), 1, "Vet42@example.com", true, "VetFirstName42", false, new DateTime(2024, 9, 9, 9, 58, 48, 689, DateTimeKind.Utc).AddTicks(6921), "VetLastName42", 1, false, null, "VET42@EXAMPLE.COM", "VET42", "AQAAAAIAAYagAAAAEK3JbxnMOU+exC6cOxQLvXvHG6Xt/a7qhEXNftH7DTJLiaC5qZ4fuRAYHF58dVJXaQ==", "+993509998485", false, "https://picsum.photos/seed/user42/200/300", null, new DateTime(2024, 9, 9, 9, 58, 48, 689, DateTimeKind.Utc).AddTicks(6915), null, "RYZH37KPG6EEDGSYWW37NETRG56JM7KG", false, "Vet42" },
                    { 2043, "Somme about text for something bla bla bla", 0, "Koroglu Rahimov 70", "Baku", null, "c7c0a771-a4db-4f2a-a70e-79bb2fc47daf", new DateTime(2024, 8, 9, 9, 58, 48, 689, DateTimeKind.Utc).AddTicks(6934), new DateTime(2000, 2, 12, 0, 0, 0, 0, DateTimeKind.Unspecified), 1, "Vet43@example.com", true, "VetFirstName43", false, new DateTime(2024, 9, 9, 9, 58, 48, 689, DateTimeKind.Utc).AddTicks(6934), "VetLastName43", 1, false, null, "VET43@EXAMPLE.COM", "VET43", "AQAAAAIAAYagAAAAEK3JbxnMOU+exC6cOxQLvXvHG6Xt/a7qhEXNftH7DTJLiaC5qZ4fuRAYHF58dVJXaQ==", "+993509998485", false, "https://picsum.photos/seed/user43/200/300", null, new DateTime(2024, 9, 9, 9, 58, 48, 689, DateTimeKind.Utc).AddTicks(6930), null, "RYZH37KPG6EEDGSYWW37NETRG56JM7KG", false, "Vet43" },
                    { 2044, "Somme about text for something bla bla bla", 0, "Koroglu Rahimov 70", "Baku", null, "a8c849c8-3019-4352-8119-9ffdd1a53e83", new DateTime(2023, 10, 9, 9, 58, 48, 689, DateTimeKind.Utc).AddTicks(6985), new DateTime(2000, 2, 13, 0, 0, 0, 0, DateTimeKind.Unspecified), 1, "Vet44@example.com", true, "VetFirstName44", false, new DateTime(2024, 9, 9, 9, 58, 48, 689, DateTimeKind.Utc).AddTicks(6986), "VetLastName44", 1, false, null, "VET44@EXAMPLE.COM", "VET44", "AQAAAAIAAYagAAAAEK3JbxnMOU+exC6cOxQLvXvHG6Xt/a7qhEXNftH7DTJLiaC5qZ4fuRAYHF58dVJXaQ==", "+993509998485", false, "https://picsum.photos/seed/user44/200/300", null, new DateTime(2024, 9, 9, 9, 58, 48, 689, DateTimeKind.Utc).AddTicks(6982), null, "RYZH37KPG6EEDGSYWW37NETRG56JM7KG", false, "Vet44" },
                    { 2045, "Somme about text for something bla bla bla", 0, "Koroglu Rahimov 70", "Baku", null, "12cfffc6-aba5-48f2-9ed5-8ca53584e251", new DateTime(2023, 10, 9, 9, 58, 48, 689, DateTimeKind.Utc).AddTicks(6997), new DateTime(2000, 2, 14, 0, 0, 0, 0, DateTimeKind.Unspecified), 1, "Vet45@example.com", true, "VetFirstName45", false, new DateTime(2024, 9, 9, 9, 58, 48, 689, DateTimeKind.Utc).AddTicks(6998), "VetLastName45", 1, false, null, "VET45@EXAMPLE.COM", "VET45", "AQAAAAIAAYagAAAAEK3JbxnMOU+exC6cOxQLvXvHG6Xt/a7qhEXNftH7DTJLiaC5qZ4fuRAYHF58dVJXaQ==", "+993509998485", false, "https://picsum.photos/seed/user45/200/300", null, new DateTime(2024, 9, 9, 9, 58, 48, 689, DateTimeKind.Utc).AddTicks(6994), null, "RYZH37KPG6EEDGSYWW37NETRG56JM7KG", false, "Vet45" },
                    { 2046, "Somme about text for something bla bla bla", 0, "Koroglu Rahimov 70", "Baku", null, "9ca6fffa-dd72-4c05-b59a-f3950b1e2f74", new DateTime(2024, 5, 9, 9, 58, 48, 689, DateTimeKind.Utc).AddTicks(7009), new DateTime(2000, 2, 15, 0, 0, 0, 0, DateTimeKind.Unspecified), 1, "Vet46@example.com", true, "VetFirstName46", false, new DateTime(2024, 9, 9, 9, 58, 48, 689, DateTimeKind.Utc).AddTicks(7010), "VetLastName46", 1, false, null, "VET46@EXAMPLE.COM", "VET46", "AQAAAAIAAYagAAAAEK3JbxnMOU+exC6cOxQLvXvHG6Xt/a7qhEXNftH7DTJLiaC5qZ4fuRAYHF58dVJXaQ==", "+993509998485", false, "https://picsum.photos/seed/user46/200/300", null, new DateTime(2024, 9, 9, 9, 58, 48, 689, DateTimeKind.Utc).AddTicks(7006), null, "RYZH37KPG6EEDGSYWW37NETRG56JM7KG", false, "Vet46" },
                    { 2047, "Somme about text for something bla bla bla", 0, "Koroglu Rahimov 70", "Baku", null, "501db3a9-e8ee-4b46-ba34-9e67c163985f", new DateTime(2023, 11, 9, 9, 58, 48, 689, DateTimeKind.Utc).AddTicks(7021), new DateTime(2000, 2, 16, 0, 0, 0, 0, DateTimeKind.Unspecified), 1, "Vet47@example.com", true, "VetFirstName47", false, new DateTime(2024, 9, 9, 9, 58, 48, 689, DateTimeKind.Utc).AddTicks(7022), "VetLastName47", 1, false, null, "VET47@EXAMPLE.COM", "VET47", "AQAAAAIAAYagAAAAEK3JbxnMOU+exC6cOxQLvXvHG6Xt/a7qhEXNftH7DTJLiaC5qZ4fuRAYHF58dVJXaQ==", "+993509998485", false, "https://picsum.photos/seed/user47/200/300", null, new DateTime(2024, 9, 9, 9, 58, 48, 689, DateTimeKind.Utc).AddTicks(7018), null, "RYZH37KPG6EEDGSYWW37NETRG56JM7KG", false, "Vet47" },
                    { 2048, "Somme about text for something bla bla bla", 0, "Koroglu Rahimov 70", "Baku", null, "e29b60c5-eef7-4a03-837f-f695b970c7e9", new DateTime(2024, 1, 9, 9, 58, 48, 689, DateTimeKind.Utc).AddTicks(7033), new DateTime(2000, 2, 17, 0, 0, 0, 0, DateTimeKind.Unspecified), 1, "Vet48@example.com", true, "VetFirstName48", false, new DateTime(2024, 9, 9, 9, 58, 48, 689, DateTimeKind.Utc).AddTicks(7034), "VetLastName48", 1, false, null, "VET48@EXAMPLE.COM", "VET48", "AQAAAAIAAYagAAAAEK3JbxnMOU+exC6cOxQLvXvHG6Xt/a7qhEXNftH7DTJLiaC5qZ4fuRAYHF58dVJXaQ==", "+993509998485", false, "https://picsum.photos/seed/user48/200/300", null, new DateTime(2024, 9, 9, 9, 58, 48, 689, DateTimeKind.Utc).AddTicks(7030), null, "RYZH37KPG6EEDGSYWW37NETRG56JM7KG", false, "Vet48" },
                    { 2049, "Somme about text for something bla bla bla", 0, "Koroglu Rahimov 70", "Baku", null, "5d8127f9-d6a2-497d-84ce-9269937ec3d8", new DateTime(2024, 6, 9, 9, 58, 48, 689, DateTimeKind.Utc).AddTicks(7045), new DateTime(2000, 2, 18, 0, 0, 0, 0, DateTimeKind.Unspecified), 1, "Vet49@example.com", true, "VetFirstName49", false, new DateTime(2024, 9, 9, 9, 58, 48, 689, DateTimeKind.Utc).AddTicks(7046), "VetLastName49", 1, false, null, "VET49@EXAMPLE.COM", "VET49", "AQAAAAIAAYagAAAAEK3JbxnMOU+exC6cOxQLvXvHG6Xt/a7qhEXNftH7DTJLiaC5qZ4fuRAYHF58dVJXaQ==", "+993509998485", false, "https://picsum.photos/seed/user49/200/300", null, new DateTime(2024, 9, 9, 9, 58, 48, 689, DateTimeKind.Utc).AddTicks(7042), null, "RYZH37KPG6EEDGSYWW37NETRG56JM7KG", false, "Vet49" },
                    { 2050, "Somme about text for something bla bla bla", 0, "Koroglu Rahimov 70", "Baku", null, "d1730c99-1b7f-49f8-83f6-48f05bd7815e", new DateTime(2024, 4, 9, 9, 58, 48, 689, DateTimeKind.Utc).AddTicks(7060), new DateTime(2000, 2, 19, 0, 0, 0, 0, DateTimeKind.Unspecified), 1, "Vet50@example.com", true, "VetFirstName50", false, new DateTime(2024, 9, 9, 9, 58, 48, 689, DateTimeKind.Utc).AddTicks(7061), "VetLastName50", 1, false, null, "VET50@EXAMPLE.COM", "VET50", "AQAAAAIAAYagAAAAEK3JbxnMOU+exC6cOxQLvXvHG6Xt/a7qhEXNftH7DTJLiaC5qZ4fuRAYHF58dVJXaQ==", "+993509998485", false, "https://picsum.photos/seed/user50/200/300", null, new DateTime(2024, 9, 9, 9, 58, 48, 689, DateTimeKind.Utc).AddTicks(7053), null, "RYZH37KPG6EEDGSYWW37NETRG56JM7KG", false, "Vet50" },
                    { 2051, "Somme about text for something bla bla bla", 0, "Koroglu Rahimov 70", "Baku", null, "978a6a8f-acd6-41d8-8bbf-e67376116d40", new DateTime(2024, 3, 9, 9, 58, 48, 689, DateTimeKind.Utc).AddTicks(7072), new DateTime(2000, 2, 20, 0, 0, 0, 0, DateTimeKind.Unspecified), 1, "Vet51@example.com", true, "VetFirstName51", false, new DateTime(2024, 9, 9, 9, 58, 48, 689, DateTimeKind.Utc).AddTicks(7073), "VetLastName51", 1, false, null, "VET51@EXAMPLE.COM", "VET51", "AQAAAAIAAYagAAAAEK3JbxnMOU+exC6cOxQLvXvHG6Xt/a7qhEXNftH7DTJLiaC5qZ4fuRAYHF58dVJXaQ==", "+993509998485", false, "https://picsum.photos/seed/user51/200/300", null, new DateTime(2024, 9, 9, 9, 58, 48, 689, DateTimeKind.Utc).AddTicks(7069), null, "RYZH37KPG6EEDGSYWW37NETRG56JM7KG", false, "Vet51" },
                    { 2052, "Somme about text for something bla bla bla", 0, "Koroglu Rahimov 70", "Baku", null, "e8402985-2e68-4621-82ae-7c8338b4ba29", new DateTime(2024, 6, 9, 9, 58, 48, 689, DateTimeKind.Utc).AddTicks(7083), new DateTime(2000, 2, 21, 0, 0, 0, 0, DateTimeKind.Unspecified), 1, "Vet52@example.com", true, "VetFirstName52", false, new DateTime(2024, 9, 9, 9, 58, 48, 689, DateTimeKind.Utc).AddTicks(7084), "VetLastName52", 1, false, null, "VET52@EXAMPLE.COM", "VET52", "AQAAAAIAAYagAAAAEK3JbxnMOU+exC6cOxQLvXvHG6Xt/a7qhEXNftH7DTJLiaC5qZ4fuRAYHF58dVJXaQ==", "+993509998485", false, "https://picsum.photos/seed/user52/200/300", null, new DateTime(2024, 9, 9, 9, 58, 48, 689, DateTimeKind.Utc).AddTicks(7081), null, "RYZH37KPG6EEDGSYWW37NETRG56JM7KG", false, "Vet52" },
                    { 2053, "Somme about text for something bla bla bla", 0, "Koroglu Rahimov 70", "Baku", null, "69de11ec-fc57-4916-9ef3-74d150d553ee", new DateTime(2023, 12, 9, 9, 58, 48, 689, DateTimeKind.Utc).AddTicks(7095), new DateTime(2000, 2, 22, 0, 0, 0, 0, DateTimeKind.Unspecified), 1, "Vet53@example.com", true, "VetFirstName53", false, new DateTime(2024, 9, 9, 9, 58, 48, 689, DateTimeKind.Utc).AddTicks(7096), "VetLastName53", 1, false, null, "VET53@EXAMPLE.COM", "VET53", "AQAAAAIAAYagAAAAEK3JbxnMOU+exC6cOxQLvXvHG6Xt/a7qhEXNftH7DTJLiaC5qZ4fuRAYHF58dVJXaQ==", "+993509998485", false, "https://picsum.photos/seed/user53/200/300", null, new DateTime(2024, 9, 9, 9, 58, 48, 689, DateTimeKind.Utc).AddTicks(7092), null, "RYZH37KPG6EEDGSYWW37NETRG56JM7KG", false, "Vet53" },
                    { 2054, "Somme about text for something bla bla bla", 0, "Koroglu Rahimov 70", "Baku", null, "a33dcd9c-f447-4544-8477-6466c3647ef9", new DateTime(2024, 4, 9, 9, 58, 48, 689, DateTimeKind.Utc).AddTicks(7143), new DateTime(2000, 2, 23, 0, 0, 0, 0, DateTimeKind.Unspecified), 1, "Vet54@example.com", true, "VetFirstName54", false, new DateTime(2024, 9, 9, 9, 58, 48, 689, DateTimeKind.Utc).AddTicks(7144), "VetLastName54", 1, false, null, "VET54@EXAMPLE.COM", "VET54", "AQAAAAIAAYagAAAAEK3JbxnMOU+exC6cOxQLvXvHG6Xt/a7qhEXNftH7DTJLiaC5qZ4fuRAYHF58dVJXaQ==", "+993509998485", false, "https://picsum.photos/seed/user54/200/300", null, new DateTime(2024, 9, 9, 9, 58, 48, 689, DateTimeKind.Utc).AddTicks(7140), null, "RYZH37KPG6EEDGSYWW37NETRG56JM7KG", false, "Vet54" },
                    { 2055, "Somme about text for something bla bla bla", 0, "Koroglu Rahimov 70", "Baku", null, "d3c22306-e7bc-44c6-939b-16d36d366362", new DateTime(2024, 1, 9, 9, 58, 48, 689, DateTimeKind.Utc).AddTicks(7155), new DateTime(2000, 2, 24, 0, 0, 0, 0, DateTimeKind.Unspecified), 1, "Vet55@example.com", true, "VetFirstName55", false, new DateTime(2024, 9, 9, 9, 58, 48, 689, DateTimeKind.Utc).AddTicks(7156), "VetLastName55", 1, false, null, "VET55@EXAMPLE.COM", "VET55", "AQAAAAIAAYagAAAAEK3JbxnMOU+exC6cOxQLvXvHG6Xt/a7qhEXNftH7DTJLiaC5qZ4fuRAYHF58dVJXaQ==", "+993509998485", false, "https://picsum.photos/seed/user55/200/300", null, new DateTime(2024, 9, 9, 9, 58, 48, 689, DateTimeKind.Utc).AddTicks(7152), null, "RYZH37KPG6EEDGSYWW37NETRG56JM7KG", false, "Vet55" },
                    { 2056, "Somme about text for something bla bla bla", 0, "Koroglu Rahimov 70", "Baku", null, "6b8c26a2-c67b-456a-9dea-09e043464b78", new DateTime(2024, 8, 9, 9, 58, 48, 689, DateTimeKind.Utc).AddTicks(7167), new DateTime(2000, 2, 25, 0, 0, 0, 0, DateTimeKind.Unspecified), 1, "Vet56@example.com", true, "VetFirstName56", false, new DateTime(2024, 9, 9, 9, 58, 48, 689, DateTimeKind.Utc).AddTicks(7168), "VetLastName56", 1, false, null, "VET56@EXAMPLE.COM", "VET56", "AQAAAAIAAYagAAAAEK3JbxnMOU+exC6cOxQLvXvHG6Xt/a7qhEXNftH7DTJLiaC5qZ4fuRAYHF58dVJXaQ==", "+993509998485", false, "https://picsum.photos/seed/user56/200/300", null, new DateTime(2024, 9, 9, 9, 58, 48, 689, DateTimeKind.Utc).AddTicks(7164), null, "RYZH37KPG6EEDGSYWW37NETRG56JM7KG", false, "Vet56" },
                    { 2057, "Somme about text for something bla bla bla", 0, "Koroglu Rahimov 70", "Baku", null, "754b704c-017b-4ec2-935b-cad67e3f75fa", new DateTime(2024, 2, 9, 9, 58, 48, 689, DateTimeKind.Utc).AddTicks(7179), new DateTime(2000, 2, 26, 0, 0, 0, 0, DateTimeKind.Unspecified), 1, "Vet57@example.com", true, "VetFirstName57", false, new DateTime(2024, 9, 9, 9, 58, 48, 689, DateTimeKind.Utc).AddTicks(7180), "VetLastName57", 1, false, null, "VET57@EXAMPLE.COM", "VET57", "AQAAAAIAAYagAAAAEK3JbxnMOU+exC6cOxQLvXvHG6Xt/a7qhEXNftH7DTJLiaC5qZ4fuRAYHF58dVJXaQ==", "+993509998485", false, "https://picsum.photos/seed/user57/200/300", null, new DateTime(2024, 9, 9, 9, 58, 48, 689, DateTimeKind.Utc).AddTicks(7176), null, "RYZH37KPG6EEDGSYWW37NETRG56JM7KG", false, "Vet57" },
                    { 2058, "Somme about text for something bla bla bla", 0, "Koroglu Rahimov 70", "Baku", null, "8ae8001c-6d60-48cf-b7cd-b29b0cdfe20d", new DateTime(2024, 8, 9, 9, 58, 48, 689, DateTimeKind.Utc).AddTicks(7194), new DateTime(2000, 2, 27, 0, 0, 0, 0, DateTimeKind.Unspecified), 1, "Vet58@example.com", true, "VetFirstName58", false, new DateTime(2024, 9, 9, 9, 58, 48, 689, DateTimeKind.Utc).AddTicks(7195), "VetLastName58", 1, false, null, "VET58@EXAMPLE.COM", "VET58", "AQAAAAIAAYagAAAAEK3JbxnMOU+exC6cOxQLvXvHG6Xt/a7qhEXNftH7DTJLiaC5qZ4fuRAYHF58dVJXaQ==", "+993509998485", false, "https://picsum.photos/seed/user58/200/300", null, new DateTime(2024, 9, 9, 9, 58, 48, 689, DateTimeKind.Utc).AddTicks(7188), null, "RYZH37KPG6EEDGSYWW37NETRG56JM7KG", false, "Vet58" },
                    { 2059, "Somme about text for something bla bla bla", 0, "Koroglu Rahimov 70", "Baku", null, "3c674a30-bc4b-4959-ae0a-9ea3a19a5f8b", new DateTime(2024, 6, 9, 9, 58, 48, 689, DateTimeKind.Utc).AddTicks(7206), new DateTime(2000, 2, 28, 0, 0, 0, 0, DateTimeKind.Unspecified), 1, "Vet59@example.com", true, "VetFirstName59", false, new DateTime(2024, 9, 9, 9, 58, 48, 689, DateTimeKind.Utc).AddTicks(7206), "VetLastName59", 1, false, null, "VET59@EXAMPLE.COM", "VET59", "AQAAAAIAAYagAAAAEK3JbxnMOU+exC6cOxQLvXvHG6Xt/a7qhEXNftH7DTJLiaC5qZ4fuRAYHF58dVJXaQ==", "+993509998485", false, "https://picsum.photos/seed/user59/200/300", null, new DateTime(2024, 9, 9, 9, 58, 48, 689, DateTimeKind.Utc).AddTicks(7203), null, "RYZH37KPG6EEDGSYWW37NETRG56JM7KG", false, "Vet59" },
                    { 2060, "Somme about text for something bla bla bla", 0, "Koroglu Rahimov 70", "Baku", null, "484cb79f-3c61-4c07-a0f7-7e3da14f2fe0", new DateTime(2024, 8, 9, 9, 58, 48, 689, DateTimeKind.Utc).AddTicks(7218), new DateTime(2000, 2, 29, 0, 0, 0, 0, DateTimeKind.Unspecified), 1, "Vet60@example.com", true, "VetFirstName60", false, new DateTime(2024, 9, 9, 9, 58, 48, 689, DateTimeKind.Utc).AddTicks(7218), "VetLastName60", 1, false, null, "VET60@EXAMPLE.COM", "VET60", "AQAAAAIAAYagAAAAEK3JbxnMOU+exC6cOxQLvXvHG6Xt/a7qhEXNftH7DTJLiaC5qZ4fuRAYHF58dVJXaQ==", "+993509998485", false, "https://picsum.photos/seed/user60/200/300", null, new DateTime(2024, 9, 9, 9, 58, 48, 689, DateTimeKind.Utc).AddTicks(7215), null, "RYZH37KPG6EEDGSYWW37NETRG56JM7KG", false, "Vet60" },
                    { 9999, "Somme about text for something bla bla bla", 0, "Koroglu Rahimov 70", "Baku", null, "1d99a366-3c95-4ef8-823e-afbe2fdc84af", new DateTime(2024, 9, 9, 9, 58, 48, 689, DateTimeKind.Utc).AddTicks(5996), new DateTime(2000, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 1, "crashtagiyev@gmail.com", true, null, false, new DateTime(2024, 9, 9, 9, 58, 48, 689, DateTimeKind.Utc).AddTicks(5997), null, 1, false, null, "CRASHTAGIYEV@GMAIL.COM", "PETCAREADMIN", "AQAAAAIAAYagAAAAEK3JbxnMOU+exC6cOxQLvXvHG6Xt/a7qhEXNftH7DTJLiaC5qZ4fuRAYHF58dVJXaQ==", "+993509998485", false, "https://picsum.photos/seed/user1/200/300", null, new DateTime(2024, 9, 9, 9, 58, 48, 689, DateTimeKind.Utc).AddTicks(5911), null, "RYZH37KPG6EEDGSYWW37NETRG56JM7KG", false, "PetCareAdmin" }
                });

            migrationBuilder.InsertData(
                table: "PetTypes",
                columns: new[] { "Id", "CreatedTime", "IsDeleted", "LastUpdatedTime", "TypeName" },
                values: new object[,]
                {
                    { 1, new DateTime(2024, 9, 9, 13, 58, 48, 676, DateTimeKind.Local).AddTicks(1251), false, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "Dogs" },
                    { 2, new DateTime(2024, 9, 9, 13, 58, 48, 676, DateTimeKind.Local).AddTicks(1257), false, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "Cats" },
                    { 3, new DateTime(2024, 9, 9, 13, 58, 48, 676, DateTimeKind.Local).AddTicks(1259), false, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "Birds" },
                    { 4, new DateTime(2024, 9, 9, 13, 58, 48, 676, DateTimeKind.Local).AddTicks(1261), false, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "Reptiles" },
                    { 5, new DateTime(2024, 9, 9, 13, 58, 48, 676, DateTimeKind.Local).AddTicks(1262), false, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "Rodents" },
                    { 6, new DateTime(2024, 9, 9, 13, 58, 48, 676, DateTimeKind.Local).AddTicks(1263), false, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "Fish" },
                    { 7, new DateTime(2024, 9, 9, 13, 58, 48, 676, DateTimeKind.Local).AddTicks(1264), false, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "Farm Animals" },
                    { 8, new DateTime(2024, 9, 9, 13, 58, 48, 676, DateTimeKind.Local).AddTicks(1266), false, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "Exotic Pets" }
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
                    { 1, "Labrador Retriever", new DateTime(2024, 9, 9, 13, 58, 48, 676, DateTimeKind.Local).AddTicks(4308), false, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 1 },
                    { 2, "German Shepherd", new DateTime(2024, 9, 9, 13, 58, 48, 676, DateTimeKind.Local).AddTicks(4317), false, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 1 },
                    { 3, "Golden Retriever", new DateTime(2024, 9, 9, 13, 58, 48, 676, DateTimeKind.Local).AddTicks(4319), false, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 1 },
                    { 4, "French Bulldog", new DateTime(2024, 9, 9, 13, 58, 48, 676, DateTimeKind.Local).AddTicks(4320), false, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 1 },
                    { 5, "Bulldog", new DateTime(2024, 9, 9, 13, 58, 48, 676, DateTimeKind.Local).AddTicks(4322), false, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 1 },
                    { 6, "Beagle", new DateTime(2024, 9, 9, 13, 58, 48, 676, DateTimeKind.Local).AddTicks(4323), false, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 1 },
                    { 7, "Poodle", new DateTime(2024, 9, 9, 13, 58, 48, 676, DateTimeKind.Local).AddTicks(4325), false, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 1 },
                    { 8, "Rottweiler", new DateTime(2024, 9, 9, 13, 58, 48, 676, DateTimeKind.Local).AddTicks(4326), false, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 1 },
                    { 9, "Yorkshire Terrier", new DateTime(2024, 9, 9, 13, 58, 48, 676, DateTimeKind.Local).AddTicks(4328), false, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 1 },
                    { 10, "Boxer", new DateTime(2024, 9, 9, 13, 58, 48, 676, DateTimeKind.Local).AddTicks(4329), false, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 1 },
                    { 11, "Dachshund", new DateTime(2024, 9, 9, 13, 58, 48, 676, DateTimeKind.Local).AddTicks(4330), false, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 1 },
                    { 12, "Pembroke Welsh Corgi", new DateTime(2024, 9, 9, 13, 58, 48, 676, DateTimeKind.Local).AddTicks(4332), false, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 1 },
                    { 13, "Doberman Pinscher", new DateTime(2024, 9, 9, 13, 58, 48, 676, DateTimeKind.Local).AddTicks(4333), false, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 1 },
                    { 14, "Shih Tzu", new DateTime(2024, 9, 9, 13, 58, 48, 676, DateTimeKind.Local).AddTicks(4334), false, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 1 },
                    { 15, "Siberian Husky", new DateTime(2024, 9, 9, 13, 58, 48, 676, DateTimeKind.Local).AddTicks(4336), false, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 1 },
                    { 16, "Great Dane", new DateTime(2024, 9, 9, 13, 58, 48, 676, DateTimeKind.Local).AddTicks(4337), false, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 1 },
                    { 17, "Border Collie", new DateTime(2024, 9, 9, 13, 58, 48, 676, DateTimeKind.Local).AddTicks(4338), false, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 1 },
                    { 18, "Chihuahua", new DateTime(2024, 9, 9, 13, 58, 48, 676, DateTimeKind.Local).AddTicks(4339), false, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 1 },
                    { 19, "Boston Terrier", new DateTime(2024, 9, 9, 13, 58, 48, 676, DateTimeKind.Local).AddTicks(4341), false, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 1 },
                    { 20, "Australian Shepherd", new DateTime(2024, 9, 9, 13, 58, 48, 676, DateTimeKind.Local).AddTicks(4342), false, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 1 },
                    { 21, "Pug", new DateTime(2024, 9, 9, 13, 58, 48, 676, DateTimeKind.Local).AddTicks(4344), false, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 1 },
                    { 22, "Havanese", new DateTime(2024, 9, 9, 13, 58, 48, 676, DateTimeKind.Local).AddTicks(4345), false, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 1 },
                    { 23, "Maltese", new DateTime(2024, 9, 9, 13, 58, 48, 676, DateTimeKind.Local).AddTicks(4346), false, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 1 },
                    { 24, "Saint Bernard", new DateTime(2024, 9, 9, 13, 58, 48, 676, DateTimeKind.Local).AddTicks(4348), false, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 1 },
                    { 25, "Akita", new DateTime(2024, 9, 9, 13, 58, 48, 676, DateTimeKind.Local).AddTicks(4349), false, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 1 },
                    { 26, "Alaskan Malamute", new DateTime(2024, 9, 9, 13, 58, 48, 676, DateTimeKind.Local).AddTicks(4350), false, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 1 },
                    { 27, "Bichon Frise", new DateTime(2024, 9, 9, 13, 58, 48, 676, DateTimeKind.Local).AddTicks(4351), false, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 1 },
                    { 28, "Bull Terrier", new DateTime(2024, 9, 9, 13, 58, 48, 676, DateTimeKind.Local).AddTicks(4353), false, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 1 },
                    { 29, "Cane Corso", new DateTime(2024, 9, 9, 13, 58, 48, 676, DateTimeKind.Local).AddTicks(4354), false, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 1 },
                    { 30, "Chow Chow", new DateTime(2024, 9, 9, 13, 58, 48, 676, DateTimeKind.Local).AddTicks(4355), false, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 1 },
                    { 31, "Cocker Spaniel", new DateTime(2024, 9, 9, 13, 58, 48, 676, DateTimeKind.Local).AddTicks(4357), false, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 1 },
                    { 32, "Dogo Argentino", new DateTime(2024, 9, 9, 13, 58, 48, 676, DateTimeKind.Local).AddTicks(4359), false, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 1 },
                    { 33, "English Springer Spaniel", new DateTime(2024, 9, 9, 13, 58, 48, 676, DateTimeKind.Local).AddTicks(4360), false, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 1 },
                    { 34, "Irish Setter", new DateTime(2024, 9, 9, 13, 58, 48, 676, DateTimeKind.Local).AddTicks(4361), false, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 1 },
                    { 35, "Jack Russell Terrier", new DateTime(2024, 9, 9, 13, 58, 48, 676, DateTimeKind.Local).AddTicks(4363), false, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 1 },
                    { 36, "Lhasa Apso", new DateTime(2024, 9, 9, 13, 58, 48, 676, DateTimeKind.Local).AddTicks(4364), false, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 1 },
                    { 37, "Miniature Schnauzer", new DateTime(2024, 9, 9, 13, 58, 48, 676, DateTimeKind.Local).AddTicks(4365), false, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 1 },
                    { 38, "Neapolitan Mastiff", new DateTime(2024, 9, 9, 13, 58, 48, 676, DateTimeKind.Local).AddTicks(4367), false, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 1 },
                    { 39, "Old English Sheepdog", new DateTime(2024, 9, 9, 13, 58, 48, 676, DateTimeKind.Local).AddTicks(4368), false, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 1 },
                    { 40, "Papillon", new DateTime(2024, 9, 9, 13, 58, 48, 676, DateTimeKind.Local).AddTicks(4369), false, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 1 },
                    { 41, "Pekingese", new DateTime(2024, 9, 9, 13, 58, 48, 676, DateTimeKind.Local).AddTicks(4371), false, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 1 },
                    { 42, "Petit Basset Griffon Vendeen", new DateTime(2024, 9, 9, 13, 58, 48, 676, DateTimeKind.Local).AddTicks(4372), false, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 1 },
                    { 43, "Pomeranian", new DateTime(2024, 9, 9, 13, 58, 48, 676, DateTimeKind.Local).AddTicks(4373), false, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 1 },
                    { 44, "Portuguese Water Dog", new DateTime(2024, 9, 9, 13, 58, 48, 676, DateTimeKind.Local).AddTicks(4374), false, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 1 },
                    { 45, "Samoyed", new DateTime(2024, 9, 9, 13, 58, 48, 676, DateTimeKind.Local).AddTicks(4376), false, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 1 },
                    { 46, "Scottish Terrier", new DateTime(2024, 9, 9, 13, 58, 48, 676, DateTimeKind.Local).AddTicks(4377), false, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 1 },
                    { 47, "Shiba Inu", new DateTime(2024, 9, 9, 13, 58, 48, 676, DateTimeKind.Local).AddTicks(4378), false, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 1 },
                    { 48, "Weimaraner", new DateTime(2024, 9, 9, 13, 58, 48, 676, DateTimeKind.Local).AddTicks(4379), false, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 1 },
                    { 49, "Whippet", new DateTime(2024, 9, 9, 13, 58, 48, 676, DateTimeKind.Local).AddTicks(4381), false, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 1 },
                    { 50, "Persian", new DateTime(2024, 9, 9, 13, 58, 48, 676, DateTimeKind.Local).AddTicks(4382), false, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 2 },
                    { 51, "Maine Coon", new DateTime(2024, 9, 9, 13, 58, 48, 676, DateTimeKind.Local).AddTicks(4383), false, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 2 },
                    { 52, "Siamese", new DateTime(2024, 9, 9, 13, 58, 48, 676, DateTimeKind.Local).AddTicks(4385), false, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 2 },
                    { 53, "Ragdoll", new DateTime(2024, 9, 9, 13, 58, 48, 676, DateTimeKind.Local).AddTicks(4386), false, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 2 },
                    { 54, "British Shorthair", new DateTime(2024, 9, 9, 13, 58, 48, 676, DateTimeKind.Local).AddTicks(4387), false, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 2 },
                    { 55, "Sphynx", new DateTime(2024, 9, 9, 13, 58, 48, 676, DateTimeKind.Local).AddTicks(4388), false, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 2 },
                    { 56, "Bengal", new DateTime(2024, 9, 9, 13, 58, 48, 676, DateTimeKind.Local).AddTicks(4390), false, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 2 },
                    { 57, "Scottish Fold", new DateTime(2024, 9, 9, 13, 58, 48, 676, DateTimeKind.Local).AddTicks(4391), false, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 2 },
                    { 58, "Abyssinian", new DateTime(2024, 9, 9, 13, 58, 48, 676, DateTimeKind.Local).AddTicks(4392), false, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 2 },
                    { 59, "Burmese", new DateTime(2024, 9, 9, 13, 58, 48, 676, DateTimeKind.Local).AddTicks(4394), false, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 2 },
                    { 60, "Somali", new DateTime(2024, 9, 9, 13, 58, 48, 676, DateTimeKind.Local).AddTicks(4396), false, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 2 },
                    { 61, "Manx", new DateTime(2024, 9, 9, 13, 58, 48, 676, DateTimeKind.Local).AddTicks(4397), false, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 2 },
                    { 62, "Norwegian Forest Cat", new DateTime(2024, 9, 9, 13, 58, 48, 676, DateTimeKind.Local).AddTicks(4398), false, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 2 },
                    { 63, "Devon Rex", new DateTime(2024, 9, 9, 13, 58, 48, 676, DateTimeKind.Local).AddTicks(4399), false, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 2 },
                    { 64, "Cornish Rex", new DateTime(2024, 9, 9, 13, 58, 48, 676, DateTimeKind.Local).AddTicks(4401), false, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 2 },
                    { 65, "Russian Blue", new DateTime(2024, 9, 9, 13, 58, 48, 676, DateTimeKind.Local).AddTicks(4402), false, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 2 },
                    { 66, "Birman", new DateTime(2024, 9, 9, 13, 58, 48, 676, DateTimeKind.Local).AddTicks(4403), false, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 2 },
                    { 67, "Ocicat", new DateTime(2024, 9, 9, 13, 58, 48, 676, DateTimeKind.Local).AddTicks(4404), false, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 2 },
                    { 68, "American Shorthair", new DateTime(2024, 9, 9, 13, 58, 48, 676, DateTimeKind.Local).AddTicks(4406), false, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 2 },
                    { 69, "Turkish Angora", new DateTime(2024, 9, 9, 13, 58, 48, 676, DateTimeKind.Local).AddTicks(4407), false, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 2 },
                    { 70, "Selkirk Rex", new DateTime(2024, 9, 9, 13, 58, 48, 676, DateTimeKind.Local).AddTicks(4408), false, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 2 },
                    { 71, "Exotic Shorthair", new DateTime(2024, 9, 9, 13, 58, 48, 676, DateTimeKind.Local).AddTicks(4410), false, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 2 },
                    { 72, "LaPerm", new DateTime(2024, 9, 9, 13, 58, 48, 676, DateTimeKind.Local).AddTicks(4411), false, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 2 },
                    { 73, "Havana Brown", new DateTime(2024, 9, 9, 13, 58, 48, 676, DateTimeKind.Local).AddTicks(4412), false, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 2 },
                    { 74, "Tonkinese", new DateTime(2024, 9, 9, 13, 58, 48, 676, DateTimeKind.Local).AddTicks(4413), false, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 2 },
                    { 75, "Egyptian Mau", new DateTime(2024, 9, 9, 13, 58, 48, 676, DateTimeKind.Local).AddTicks(4415), false, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 2 },
                    { 76, "Singapura", new DateTime(2024, 9, 9, 13, 58, 48, 676, DateTimeKind.Local).AddTicks(4416), false, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 2 },
                    { 77, "Japanese Bobtail", new DateTime(2024, 9, 9, 13, 58, 48, 676, DateTimeKind.Local).AddTicks(4418), false, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 2 },
                    { 78, "American Curl", new DateTime(2024, 9, 9, 13, 58, 48, 676, DateTimeKind.Local).AddTicks(4419), false, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 2 },
                    { 79, "Parrot", new DateTime(2024, 9, 9, 13, 58, 48, 676, DateTimeKind.Local).AddTicks(4420), false, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 3 },
                    { 80, "Canary", new DateTime(2024, 9, 9, 13, 58, 48, 676, DateTimeKind.Local).AddTicks(4422), false, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 3 },
                    { 81, "Budgerigar", new DateTime(2024, 9, 9, 13, 58, 48, 676, DateTimeKind.Local).AddTicks(4423), false, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 3 },
                    { 82, "Cockatiel", new DateTime(2024, 9, 9, 13, 58, 48, 676, DateTimeKind.Local).AddTicks(4424), false, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 3 },
                    { 83, "Lovebird", new DateTime(2024, 9, 9, 13, 58, 48, 676, DateTimeKind.Local).AddTicks(4426), false, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 3 },
                    { 84, "Macaw", new DateTime(2024, 9, 9, 13, 58, 48, 676, DateTimeKind.Local).AddTicks(4427), false, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 3 },
                    { 85, "Conure", new DateTime(2024, 9, 9, 13, 58, 48, 676, DateTimeKind.Local).AddTicks(4428), false, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 3 },
                    { 86, "African Grey Parrot", new DateTime(2024, 9, 9, 13, 58, 48, 676, DateTimeKind.Local).AddTicks(4429), false, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 3 },
                    { 87, "Finches", new DateTime(2024, 9, 9, 13, 58, 48, 676, DateTimeKind.Local).AddTicks(4431), false, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 3 },
                    { 88, "Quaker Parrot", new DateTime(2024, 9, 9, 13, 58, 48, 676, DateTimeKind.Local).AddTicks(4432), false, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 3 },
                    { 89, "Amazon Parrot", new DateTime(2024, 9, 9, 13, 58, 48, 676, DateTimeKind.Local).AddTicks(4433), false, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 3 },
                    { 90, "Eclectus Parrot", new DateTime(2024, 9, 9, 13, 58, 48, 676, DateTimeKind.Local).AddTicks(4481), false, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 3 },
                    { 91, "Pigeon", new DateTime(2024, 9, 9, 13, 58, 48, 676, DateTimeKind.Local).AddTicks(4483), false, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 3 },
                    { 92, "Dove", new DateTime(2024, 9, 9, 13, 58, 48, 676, DateTimeKind.Local).AddTicks(4484), false, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 3 },
                    { 93, "Cockatoo", new DateTime(2024, 9, 9, 13, 58, 48, 676, DateTimeKind.Local).AddTicks(4486), false, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 3 },
                    { 94, "Sun Conure", new DateTime(2024, 9, 9, 13, 58, 48, 676, DateTimeKind.Local).AddTicks(4487), false, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 3 },
                    { 95, "Hyacinth Macaw", new DateTime(2024, 9, 9, 13, 58, 48, 676, DateTimeKind.Local).AddTicks(4488), false, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 3 },
                    { 96, "Lorikeet", new DateTime(2024, 9, 9, 13, 58, 48, 676, DateTimeKind.Local).AddTicks(4490), false, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 3 },
                    { 97, "Zebra Finch", new DateTime(2024, 9, 9, 13, 58, 48, 676, DateTimeKind.Local).AddTicks(4491), false, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 3 },
                    { 98, "Gouldian Finch", new DateTime(2024, 9, 9, 13, 58, 48, 676, DateTimeKind.Local).AddTicks(4493), false, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 3 },
                    { 99, "Canary Winged Parakeet", new DateTime(2024, 9, 9, 13, 58, 48, 676, DateTimeKind.Local).AddTicks(4494), false, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 3 },
                    { 100, "Quail", new DateTime(2024, 9, 9, 13, 58, 48, 676, DateTimeKind.Local).AddTicks(4495), false, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 3 },
                    { 101, "Iguana", new DateTime(2024, 9, 9, 13, 58, 48, 676, DateTimeKind.Local).AddTicks(4497), false, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 4 },
                    { 102, "Gecko", new DateTime(2024, 9, 9, 13, 58, 48, 676, DateTimeKind.Local).AddTicks(4498), false, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 4 },
                    { 103, "Bearded Dragon", new DateTime(2024, 9, 9, 13, 58, 48, 676, DateTimeKind.Local).AddTicks(4499), false, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 4 },
                    { 104, "Chameleon", new DateTime(2024, 9, 9, 13, 58, 48, 676, DateTimeKind.Local).AddTicks(4501), false, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 4 },
                    { 105, "Python", new DateTime(2024, 9, 9, 13, 58, 48, 676, DateTimeKind.Local).AddTicks(4502), false, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 4 },
                    { 106, "Boa Constrictor", new DateTime(2024, 9, 9, 13, 58, 48, 676, DateTimeKind.Local).AddTicks(4504), false, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 4 },
                    { 107, "Skink", new DateTime(2024, 9, 9, 13, 58, 48, 676, DateTimeKind.Local).AddTicks(4505), false, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 4 },
                    { 108, "Tortoise", new DateTime(2024, 9, 9, 13, 58, 48, 676, DateTimeKind.Local).AddTicks(4506), false, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 4 },
                    { 109, "Turtle", new DateTime(2024, 9, 9, 13, 58, 48, 676, DateTimeKind.Local).AddTicks(4508), false, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 4 },
                    { 110, "Monitor Lizard", new DateTime(2024, 9, 9, 13, 58, 48, 676, DateTimeKind.Local).AddTicks(4509), false, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 4 },
                    { 111, "Water Dragon", new DateTime(2024, 9, 9, 13, 58, 48, 676, DateTimeKind.Local).AddTicks(4510), false, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 4 },
                    { 112, "Uromastyx", new DateTime(2024, 9, 9, 13, 58, 48, 676, DateTimeKind.Local).AddTicks(4512), false, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 4 },
                    { 113, "Horned Toad", new DateTime(2024, 9, 9, 13, 58, 48, 676, DateTimeKind.Local).AddTicks(4513), false, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 4 },
                    { 114, "Hamster", new DateTime(2024, 9, 9, 13, 58, 48, 676, DateTimeKind.Local).AddTicks(4514), false, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 5 },
                    { 115, "Guinea Pig", new DateTime(2024, 9, 9, 13, 58, 48, 676, DateTimeKind.Local).AddTicks(4515), false, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 5 },
                    { 116, "Rat", new DateTime(2024, 9, 9, 13, 58, 48, 676, DateTimeKind.Local).AddTicks(4517), false, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 5 },
                    { 117, "Mouse", new DateTime(2024, 9, 9, 13, 58, 48, 676, DateTimeKind.Local).AddTicks(4518), false, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 5 },
                    { 118, "Gerbil", new DateTime(2024, 9, 9, 13, 58, 48, 676, DateTimeKind.Local).AddTicks(4519), false, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 5 },
                    { 119, "Chinchilla", new DateTime(2024, 9, 9, 13, 58, 48, 676, DateTimeKind.Local).AddTicks(4521), false, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 5 },
                    { 120, "Degu", new DateTime(2024, 9, 9, 13, 58, 48, 676, DateTimeKind.Local).AddTicks(4523), false, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 5 },
                    { 121, "Capybara", new DateTime(2024, 9, 9, 13, 58, 48, 676, DateTimeKind.Local).AddTicks(4524), false, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 5 },
                    { 122, "Prairie Dog", new DateTime(2024, 9, 9, 13, 58, 48, 676, DateTimeKind.Local).AddTicks(4525), false, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 5 },
                    { 123, "Goldfish", new DateTime(2024, 9, 9, 13, 58, 48, 676, DateTimeKind.Local).AddTicks(4527), false, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 6 },
                    { 124, "Betta", new DateTime(2024, 9, 9, 13, 58, 48, 676, DateTimeKind.Local).AddTicks(4528), false, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 6 },
                    { 125, "Guppy", new DateTime(2024, 9, 9, 13, 58, 48, 676, DateTimeKind.Local).AddTicks(4529), false, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 6 },
                    { 126, "Neon Tetra", new DateTime(2024, 9, 9, 13, 58, 48, 676, DateTimeKind.Local).AddTicks(4531), false, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 6 },
                    { 127, "Angelfish", new DateTime(2024, 9, 9, 13, 58, 48, 676, DateTimeKind.Local).AddTicks(4532), false, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 6 },
                    { 128, "Oscar", new DateTime(2024, 9, 9, 13, 58, 48, 676, DateTimeKind.Local).AddTicks(4533), false, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 6 },
                    { 129, "Clownfish", new DateTime(2024, 9, 9, 13, 58, 48, 676, DateTimeKind.Local).AddTicks(4535), false, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 6 },
                    { 130, "Corydoras Catfish", new DateTime(2024, 9, 9, 13, 58, 48, 676, DateTimeKind.Local).AddTicks(4536), false, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 6 },
                    { 131, "Molly", new DateTime(2024, 9, 9, 13, 58, 48, 676, DateTimeKind.Local).AddTicks(4537), false, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 6 },
                    { 132, "Swordtail", new DateTime(2024, 9, 9, 13, 58, 48, 676, DateTimeKind.Local).AddTicks(4539), false, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 6 },
                    { 133, "Rainbowfish", new DateTime(2024, 9, 9, 13, 58, 48, 676, DateTimeKind.Local).AddTicks(4540), false, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 6 },
                    { 134, "Plecostomus", new DateTime(2024, 9, 9, 13, 58, 48, 676, DateTimeKind.Local).AddTicks(4541), false, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 6 },
                    { 135, "Gourami", new DateTime(2024, 9, 9, 13, 58, 48, 676, DateTimeKind.Local).AddTicks(4542), false, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 6 },
                    { 136, "Danios", new DateTime(2024, 9, 9, 13, 58, 48, 676, DateTimeKind.Local).AddTicks(4543), false, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 6 },
                    { 137, "Apistogramma", new DateTime(2024, 9, 9, 13, 58, 48, 676, DateTimeKind.Local).AddTicks(4545), false, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 6 },
                    { 138, "Discus", new DateTime(2024, 9, 9, 13, 58, 48, 676, DateTimeKind.Local).AddTicks(4546), false, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 6 },
                    { 139, "Koi", new DateTime(2024, 9, 9, 13, 58, 48, 676, DateTimeKind.Local).AddTicks(4547), false, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 6 },
                    { 140, "Holstein Cow", new DateTime(2024, 9, 9, 13, 58, 48, 676, DateTimeKind.Local).AddTicks(4549), false, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 7 },
                    { 141, "Angus Cow", new DateTime(2024, 9, 9, 13, 58, 48, 676, DateTimeKind.Local).AddTicks(4550), false, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 7 },
                    { 142, "Jersey Cow", new DateTime(2024, 9, 9, 13, 58, 48, 676, DateTimeKind.Local).AddTicks(4551), false, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 7 },
                    { 143, "Guernsey Cow", new DateTime(2024, 9, 9, 13, 58, 48, 676, DateTimeKind.Local).AddTicks(4552), false, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 7 },
                    { 144, "Merino Sheep", new DateTime(2024, 9, 9, 13, 58, 48, 676, DateTimeKind.Local).AddTicks(4554), false, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 7 },
                    { 145, "Suffolk Sheep", new DateTime(2024, 9, 9, 13, 58, 48, 676, DateTimeKind.Local).AddTicks(4555), false, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 7 },
                    { 146, "Dorset Sheep", new DateTime(2024, 9, 9, 13, 58, 48, 676, DateTimeKind.Local).AddTicks(4556), false, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 7 },
                    { 147, "Hampshire Sheep", new DateTime(2024, 9, 9, 13, 58, 48, 676, DateTimeKind.Local).AddTicks(4557), false, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 7 },
                    { 148, "Berkshire Pig", new DateTime(2024, 9, 9, 13, 58, 48, 676, DateTimeKind.Local).AddTicks(4559), false, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 7 },
                    { 149, "Duroc Pig", new DateTime(2024, 9, 9, 13, 58, 48, 676, DateTimeKind.Local).AddTicks(4560), false, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 7 },
                    { 150, "Yorkshire Pig", new DateTime(2024, 9, 9, 13, 58, 48, 676, DateTimeKind.Local).AddTicks(4561), false, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 7 },
                    { 151, "Landrace Pig", new DateTime(2024, 9, 9, 13, 58, 48, 676, DateTimeKind.Local).AddTicks(4562), false, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 7 },
                    { 152, "Rhode Island Red Chicken", new DateTime(2024, 9, 9, 13, 58, 48, 676, DateTimeKind.Local).AddTicks(4564), false, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 7 },
                    { 153, "Leghorn Chicken", new DateTime(2024, 9, 9, 13, 58, 48, 676, DateTimeKind.Local).AddTicks(4565), false, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 7 },
                    { 154, "Plymouth Rock Chicken", new DateTime(2024, 9, 9, 13, 58, 48, 676, DateTimeKind.Local).AddTicks(4566), false, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 7 },
                    { 155, "Sussex Chicken", new DateTime(2024, 9, 9, 13, 58, 48, 676, DateTimeKind.Local).AddTicks(4568), false, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 7 },
                    { 156, "Turkeys", new DateTime(2024, 9, 9, 13, 58, 48, 676, DateTimeKind.Local).AddTicks(4569), false, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 7 },
                    { 157, "Ducks", new DateTime(2024, 9, 9, 13, 58, 48, 676, DateTimeKind.Local).AddTicks(4570), false, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 7 },
                    { 158, "Goats", new DateTime(2024, 9, 9, 13, 58, 48, 676, DateTimeKind.Local).AddTicks(4571), false, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 7 },
                    { 159, "Llamas", new DateTime(2024, 9, 9, 13, 58, 48, 676, DateTimeKind.Local).AddTicks(4572), false, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 7 },
                    { 160, "Alpacas", new DateTime(2024, 9, 9, 13, 58, 48, 676, DateTimeKind.Local).AddTicks(4574), false, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 7 }
                });

            migrationBuilder.InsertData(
                table: "Shelters",
                columns: new[] { "Id", "AboutShelter", "Address", "AdoptionPolicy", "City", "CompanyId", "CreatedTime", "EmailAddress", "IsDeleted", "LastUpdatedTime", "PhoneNumber", "ShelterImageUrl", "ShelterName" },
                values: new object[,]
                {
                    { 1021, "This is about shelter for Company21.", "Street 21", "Adoption policy for Company21.", "Baku", 2021, new DateTime(2024, 9, 9, 9, 58, 48, 676, DateTimeKind.Utc).AddTicks(137), "ShelterEmailAddress21@gmail.com", false, new DateTime(2024, 9, 9, 9, 58, 48, 676, DateTimeKind.Utc).AddTicks(139), "+994501234567", "https://picsum.photos/seed/user21/200/300", "Shelter Name 21" },
                    { 1022, "This is about shelter for Company22.", "Street 22", "Adoption policy for Company22.", "Baku", 2022, new DateTime(2024, 9, 9, 9, 58, 48, 676, DateTimeKind.Utc).AddTicks(155), "ShelterEmailAddress22@gmail.com", false, new DateTime(2024, 9, 9, 9, 58, 48, 676, DateTimeKind.Utc).AddTicks(155), "+994501234567", "https://picsum.photos/seed/user22/200/300", "Shelter Name 22" },
                    { 1023, "This is about shelter for Company23.", "Street 23", "Adoption policy for Company23.", "Baku", 2023, new DateTime(2024, 9, 9, 9, 58, 48, 676, DateTimeKind.Utc).AddTicks(164), "ShelterEmailAddress23@gmail.com", false, new DateTime(2024, 9, 9, 9, 58, 48, 676, DateTimeKind.Utc).AddTicks(164), "+994501234567", "https://picsum.photos/seed/user23/200/300", "Shelter Name 23" },
                    { 1024, "This is about shelter for Company24.", "Street 24", "Adoption policy for Company24.", "Baku", 2024, new DateTime(2024, 9, 9, 9, 58, 48, 676, DateTimeKind.Utc).AddTicks(173), "ShelterEmailAddress24@gmail.com", false, new DateTime(2024, 9, 9, 9, 58, 48, 676, DateTimeKind.Utc).AddTicks(173), "+994501234567", "https://picsum.photos/seed/user24/200/300", "Shelter Name 24" },
                    { 1025, "This is about shelter for Company25.", "Street 25", "Adoption policy for Company25.", "Baku", 2025, new DateTime(2024, 9, 9, 9, 58, 48, 676, DateTimeKind.Utc).AddTicks(181), "ShelterEmailAddress25@gmail.com", false, new DateTime(2024, 9, 9, 9, 58, 48, 676, DateTimeKind.Utc).AddTicks(182), "+994501234567", "https://picsum.photos/seed/user25/200/300", "Shelter Name 25" },
                    { 1026, "This is about shelter for Company26.", "Street 26", "Adoption policy for Company26.", "Baku", 2026, new DateTime(2024, 9, 9, 9, 58, 48, 676, DateTimeKind.Utc).AddTicks(193), "ShelterEmailAddress26@gmail.com", false, new DateTime(2024, 9, 9, 9, 58, 48, 676, DateTimeKind.Utc).AddTicks(193), "+994501234567", "https://picsum.photos/seed/user26/200/300", "Shelter Name 26" },
                    { 1027, "This is about shelter for Company27.", "Street 27", "Adoption policy for Company27.", "Baku", 2027, new DateTime(2024, 9, 9, 9, 58, 48, 676, DateTimeKind.Utc).AddTicks(246), "ShelterEmailAddress27@gmail.com", false, new DateTime(2024, 9, 9, 9, 58, 48, 676, DateTimeKind.Utc).AddTicks(247), "+994501234567", "https://picsum.photos/seed/user27/200/300", "Shelter Name 27" },
                    { 1028, "This is about shelter for Company28.", "Street 28", "Adoption policy for Company28.", "Baku", 2028, new DateTime(2024, 9, 9, 9, 58, 48, 676, DateTimeKind.Utc).AddTicks(255), "ShelterEmailAddress28@gmail.com", false, new DateTime(2024, 9, 9, 9, 58, 48, 676, DateTimeKind.Utc).AddTicks(255), "+994501234567", "https://picsum.photos/seed/user28/200/300", "Shelter Name 28" },
                    { 1029, "This is about shelter for Company29.", "Street 29", "Adoption policy for Company29.", "Baku", 2029, new DateTime(2024, 9, 9, 9, 58, 48, 676, DateTimeKind.Utc).AddTicks(263), "ShelterEmailAddress29@gmail.com", false, new DateTime(2024, 9, 9, 9, 58, 48, 676, DateTimeKind.Utc).AddTicks(264), "+994501234567", "https://picsum.photos/seed/user29/200/300", "Shelter Name 29" },
                    { 1030, "This is about shelter for Company30.", "Street 30", "Adoption policy for Company30.", "Baku", 2030, new DateTime(2024, 9, 9, 9, 58, 48, 676, DateTimeKind.Utc).AddTicks(274), "ShelterEmailAddress30@gmail.com", false, new DateTime(2024, 9, 9, 9, 58, 48, 676, DateTimeKind.Utc).AddTicks(274), "+994501234567", "https://picsum.photos/seed/user30/200/300", "Shelter Name 30" },
                    { 1031, "This is about shelter for Company31.", "Street 31", "Adoption policy for Company31.", "Baku", 2031, new DateTime(2024, 9, 9, 9, 58, 48, 676, DateTimeKind.Utc).AddTicks(282), "ShelterEmailAddress31@gmail.com", false, new DateTime(2024, 9, 9, 9, 58, 48, 676, DateTimeKind.Utc).AddTicks(282), "+994501234567", "https://picsum.photos/seed/user31/200/300", "Shelter Name 31" },
                    { 1032, "This is about shelter for Company32.", "Street 32", "Adoption policy for Company32.", "Baku", 2032, new DateTime(2024, 9, 9, 9, 58, 48, 676, DateTimeKind.Utc).AddTicks(291), "ShelterEmailAddress32@gmail.com", false, new DateTime(2024, 9, 9, 9, 58, 48, 676, DateTimeKind.Utc).AddTicks(291), "+994501234567", "https://picsum.photos/seed/user32/200/300", "Shelter Name 32" },
                    { 1033, "This is about shelter for Company33.", "Street 33", "Adoption policy for Company33.", "Baku", 2033, new DateTime(2024, 9, 9, 9, 58, 48, 676, DateTimeKind.Utc).AddTicks(299), "ShelterEmailAddress33@gmail.com", false, new DateTime(2024, 9, 9, 9, 58, 48, 676, DateTimeKind.Utc).AddTicks(300), "+994501234567", "https://picsum.photos/seed/user33/200/300", "Shelter Name 33" },
                    { 1034, "This is about shelter for Company34.", "Street 34", "Adoption policy for Company34.", "Baku", 2034, new DateTime(2024, 9, 9, 9, 58, 48, 676, DateTimeKind.Utc).AddTicks(308), "ShelterEmailAddress34@gmail.com", false, new DateTime(2024, 9, 9, 9, 58, 48, 676, DateTimeKind.Utc).AddTicks(308), "+994501234567", "https://picsum.photos/seed/user34/200/300", "Shelter Name 34" },
                    { 1035, "This is about shelter for Company35.", "Street 35", "Adoption policy for Company35.", "Baku", 2035, new DateTime(2024, 9, 9, 9, 58, 48, 676, DateTimeKind.Utc).AddTicks(317), "ShelterEmailAddress35@gmail.com", false, new DateTime(2024, 9, 9, 9, 58, 48, 676, DateTimeKind.Utc).AddTicks(318), "+994501234567", "https://picsum.photos/seed/user35/200/300", "Shelter Name 35" },
                    { 1036, "This is about shelter for Company36.", "Street 36", "Adoption policy for Company36.", "Baku", 2036, new DateTime(2024, 9, 9, 9, 58, 48, 676, DateTimeKind.Utc).AddTicks(326), "ShelterEmailAddress36@gmail.com", false, new DateTime(2024, 9, 9, 9, 58, 48, 676, DateTimeKind.Utc).AddTicks(327), "+994501234567", "https://picsum.photos/seed/user36/200/300", "Shelter Name 36" },
                    { 1037, "This is about shelter for Company37.", "Street 37", "Adoption policy for Company37.", "Baku", 2037, new DateTime(2024, 9, 9, 9, 58, 48, 676, DateTimeKind.Utc).AddTicks(335), "ShelterEmailAddress37@gmail.com", false, new DateTime(2024, 9, 9, 9, 58, 48, 676, DateTimeKind.Utc).AddTicks(335), "+994501234567", "https://picsum.photos/seed/user37/200/300", "Shelter Name 37" },
                    { 1038, "This is about shelter for Company38.", "Street 38", "Adoption policy for Company38.", "Baku", 2038, new DateTime(2024, 9, 9, 9, 58, 48, 676, DateTimeKind.Utc).AddTicks(346), "ShelterEmailAddress38@gmail.com", false, new DateTime(2024, 9, 9, 9, 58, 48, 676, DateTimeKind.Utc).AddTicks(347), "+994501234567", "https://picsum.photos/seed/user38/200/300", "Shelter Name 38" },
                    { 1039, "This is about shelter for Company39.", "Street 39", "Adoption policy for Company39.", "Baku", 2039, new DateTime(2024, 9, 9, 9, 58, 48, 676, DateTimeKind.Utc).AddTicks(435), "ShelterEmailAddress39@gmail.com", false, new DateTime(2024, 9, 9, 9, 58, 48, 676, DateTimeKind.Utc).AddTicks(435), "+994501234567", "https://picsum.photos/seed/user39/200/300", "Shelter Name 39" },
                    { 1040, "This is about shelter for Company40.", "Street 40", "Adoption policy for Company40.", "Baku", 2040, new DateTime(2024, 9, 9, 9, 58, 48, 676, DateTimeKind.Utc).AddTicks(444), "ShelterEmailAddress40@gmail.com", false, new DateTime(2024, 9, 9, 9, 58, 48, 676, DateTimeKind.Utc).AddTicks(444), "+994501234567", "https://picsum.photos/seed/user40/200/300", "Shelter Name 40" }
                });

            migrationBuilder.InsertData(
                table: "Pets",
                columns: new[] { "Id", "AdoptionId", "Age", "BreedId", "CreatedTime", "Description", "Gender", "Health", "ImageUrls", "IsAdopted", "IsDeleted", "LastUpdatedTime", "PetName", "PetTypeId", "ShelterId", "Size", "Weight" },
                values: new object[,]
                {
                    { 1, null, (short)3, 1, new DateTime(2024, 4, 9, 13, 58, 48, 690, DateTimeKind.Local).AddTicks(6589), "Friendly Labrador Retriever", 1, "Healthy", "[\"https://images.unsplash.com/photo-1574158622682-e40e69881006\",\"https://images.unsplash.com/photo-1583511656127-8a22f6e9f018\"]", false, false, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "Buddy", 2, 1026, "Large", 30.5m },
                    { 2, null, (short)2, 2, new DateTime(2023, 10, 9, 13, 58, 48, 690, DateTimeKind.Local).AddTicks(6610), "Energetic Beagle", 2, "Healthy", "[\"https://images.unsplash.com/photo-1560807707-8cc77767d783\",\"https://images.unsplash.com/photo-1560807707-8cc77767d783\"]", false, false, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "Bella", 1, 1026, "Medium", 10.2m },
                    { 3, null, (short)5, 3, new DateTime(2023, 11, 9, 13, 58, 48, 690, DateTimeKind.Local).AddTicks(6618), "Loyal German Shepherd", 1, "Healthy", "[\"https://images.unsplash.com/photo-1560807707-8cc77767d783\",\"https://images.unsplash.com/photo-1601758124199-0a4b30c13d8e\"]", true, false, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "Max", 1, 1026, "Large", 40.8m },
                    { 4, null, (short)4, 4, new DateTime(2024, 6, 9, 13, 58, 48, 690, DateTimeKind.Local).AddTicks(6623), "Clever Border Collie", 2, "Healthy", "[\"https://images.unsplash.com/photo-1579362242788-7d8d553f7d82\",\"https://images.unsplash.com/photo-1593137318309-7d0bdc18f9c3\"]", false, false, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "Lucy", 1, 1026, "Medium", 18.7m },
                    { 5, null, (short)2, 5, new DateTime(2024, 7, 9, 13, 58, 48, 690, DateTimeKind.Local).AddTicks(6629), "Playful Golden Retriever", 1, "Healthy", "[\"https://images.unsplash.com/photo-1557302985-673a2c6c8c83\",\"https://images.unsplash.com/photo-1596495577886-d920f15eb45d\"]", true, false, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "Charlie", 1, 1026, "Large", 28.3m },
                    { 6, null, (short)2, 6, new DateTime(2024, 3, 9, 13, 58, 48, 690, DateTimeKind.Local).AddTicks(6634), "Playful Maine Coon", 2, "Healthy", "[\"https://images.unsplash.com/photo-1585791325888-0fc79fae1484\",\"https://images.unsplash.com/photo-1570816118443-e11a95c3f168\"]", true, false, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "Mittens", 2, 1026, "Large", 10.2m },
                    { 7, null, (short)4, 7, new DateTime(2024, 3, 9, 13, 58, 48, 690, DateTimeKind.Local).AddTicks(6639), "Curious Siamese", 1, "Healthy", "[\"https://images.unsplash.com/photo-1560807707-8cc77767d783\",\"https://images.unsplash.com/photo-1584358147545-7fd7b772d2e8\"]", false, false, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "Whiskers", 2, 1026, "Medium", 7.8m },
                    { 8, null, (short)3, 8, new DateTime(2024, 7, 9, 13, 58, 48, 690, DateTimeKind.Local).AddTicks(6644), "Silent Russian Blue", 1, "Healthy", "[\"https://images.unsplash.com/photo-1592194996308-7b19e0c4730b\",\"https://images.unsplash.com/photo-1593137318309-7d0bdc18f9c3\"]", true, false, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "Shadow", 2, 1026, "Medium", 8.5m },
                    { 9, null, (short)2, 9, new DateTime(2024, 3, 9, 13, 58, 48, 690, DateTimeKind.Local).AddTicks(6649), "Graceful Persian", 2, "Healthy", "[\"https://images.unsplash.com/photo-1583511656127-8a22f6e9f018\",\"https://images.unsplash.com/photo-1560807707-8cc77767d783\"]", false, false, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "Luna", 2, 1026, "Small", 5.3m },
                    { 10, null, (short)3, 10, new DateTime(2024, 2, 9, 13, 58, 48, 690, DateTimeKind.Local).AddTicks(6654), "Adventurous Bengal", 1, "Healthy", "[\"https://images.unsplash.com/photo-1560807707-8cc77767d783\",\"https://images.unsplash.com/photo-1601758124199-0a4b30c13d8e\"]", false, false, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "Simba", 2, 1026, "Large", 9.2m },
                    { 11, null, (short)1, 11, new DateTime(2023, 11, 9, 13, 58, 48, 690, DateTimeKind.Local).AddTicks(6659), "Chirpy Canary", 2, "Healthy", "[\"https://images.unsplash.com/photo-1558981289-42a1e2b2133e\",\"https://images.unsplash.com/photo-1560807707-8cc77767d783\"]", false, false, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "Tweety", 3, 1026, "Small", 0.05m },
                    { 12, null, (short)5, 12, new DateTime(2024, 1, 9, 13, 58, 48, 690, DateTimeKind.Local).AddTicks(6665), "Talkative Parrot", 2, "Healthy", "[\"https://images.unsplash.com/photo-1507611097612-5ff4d04e4b7e\",\"https://images.unsplash.com/photo-1508546293063-3094b6a13db5\"]", false, false, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "Polly", 3, 1026, "Medium", 0.9m },
                    { 13, null, (short)2, 13, new DateTime(2023, 11, 9, 13, 58, 48, 690, DateTimeKind.Local).AddTicks(6669), "Graceful Cockatiel", 1, "Healthy", "[\"https://images.unsplash.com/photo-1560807707-8cc77767d783\",\"https://images.unsplash.com/photo-1558981289-42a1e2b2133e\"]", true, false, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "Sky", 3, 1026, "Small", 0.12m },
                    { 14, null, (short)3, 14, new DateTime(2024, 8, 9, 13, 58, 48, 690, DateTimeKind.Local).AddTicks(6674), "Colorful Parakeet", 2, "Healthy", "[\"https://images.unsplash.com/photo-1508610048659-a06d45f8a1a5\",\"https://images.unsplash.com/photo-1558981289-42a1e2b2133e\"]", false, false, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "Kiwi", 3, 1026, "Small", 0.06m },
                    { 15, null, (short)4, 15, new DateTime(2024, 8, 9, 13, 58, 48, 690, DateTimeKind.Local).AddTicks(6679), "Clever African Grey", 2, "Healthy", "[\"https://images.unsplash.com/photo-1558981289-42a1e2b2133e\",\"https://images.unsplash.com/photo-1508546293063-3094b6a13db5\"]", true, false, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "Coco", 3, 1025, "Medium", 0.45m },
                    { 16, null, (short)4, 16, new DateTime(2024, 2, 9, 13, 58, 48, 690, DateTimeKind.Local).AddTicks(6731), "Spiky Bearded Dragon", 1, "Healthy", "[\"https://images.unsplash.com/photo-1599945863043-c972ca05f8d0\",\"https://images.unsplash.com/photo-1560807707-8cc77767d783\"]", false, false, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "Spike", 4, 1026, "Medium", 1.1m },
                    { 17, null, (short)2, 17, new DateTime(2023, 11, 9, 13, 58, 48, 690, DateTimeKind.Local).AddTicks(6736), "Stealthy Corn Snake", 1, "Healthy", "[\"https://images.unsplash.com/photo-1587137112204-ff2af20e59d5\",\"https://images.unsplash.com/photo-1560807707-8cc77767d783\"]", false, false, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "Slinky", 4, 1026, "Small", 0.3m },
                    { 18, null, (short)3, 18, new DateTime(2024, 4, 9, 13, 58, 48, 690, DateTimeKind.Local).AddTicks(6742), "Agile Gecko", 2, "Healthy", "[\"https://images.unsplash.com/photo-1593137318309-7d0bdc18f9c3\",\"https://images.unsplash.com/photo-1587137112204-ff2af20e59d5\"]", false, false, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "Gizmo", 4, 1026, "Small", 0.07m },
                    { 19, null, (short)1, 19, new DateTime(2023, 11, 9, 13, 58, 48, 690, DateTimeKind.Local).AddTicks(6747), "Curious Hamster", 1, "Healthy", "[\"https://images.unsplash.com/photo-1550807012-514e38ec9ad4\",\"https://images.unsplash.com/photo-1558981289-42a1e2b2133e\"]", true, false, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "Nibbles", 5, 1026, "Small", 0.03m },
                    { 20, null, (short)2, 20, new DateTime(2023, 11, 9, 13, 58, 48, 690, DateTimeKind.Local).AddTicks(6752), "Fluffy Guinea Pig", 2, "Healthy", "[\"https://images.unsplash.com/photo-1550807012-514e38ec9ad4\",\"https://images.unsplash.com/photo-1558981289-42a1e2b2133e\"]", false, false, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "Fuzzy", 5, 1026, "Small", 1.2m },
                    { 21, null, (short)3, 21, new DateTime(2024, 4, 9, 13, 58, 48, 690, DateTimeKind.Local).AddTicks(6759), "Playful Rabbit", 1, "Healthy", "[\"https://images.unsplash.com/photo-1550807012-514e38ec9ad4\",\"https://images.unsplash.com/photo-1560807707-8cc77767d783\"]", false, false, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "Pip", 5, 1026, "Small", 2.5m },
                    { 22, null, (short)3, 22, new DateTime(2024, 2, 9, 13, 58, 48, 690, DateTimeKind.Local).AddTicks(6765), "Charming Chinchilla", 1, "Healthy", "[\"https://images.unsplash.com/photo-1550807012-514e38ec9ad4\",\"https://images.unsplash.com/photo-1558981289-42a1e2b2133e\"]", false, false, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "Chester", 6, 1026, "Small", 0.6m },
                    { 23, null, (short)2, 23, new DateTime(2024, 2, 9, 13, 58, 48, 690, DateTimeKind.Local).AddTicks(6770), "Lively Sugar Glider", 2, "Healthy", "[\"https://images.unsplash.com/photo-1550807012-514e38ec9ad4\",\"https://images.unsplash.com/photo-1558981289-42a1e2b2133e\"]", false, false, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "Zara", 6, 1026, "Small", 0.1m },
                    { 24, null, (short)2, 24, new DateTime(2023, 10, 9, 13, 58, 48, 690, DateTimeKind.Local).AddTicks(6775), "Spiky Hedgehog", 1, "Healthy", "[\"https://images.unsplash.com/photo-1550807012-514e38ec9ad4\",\"https://images.unsplash.com/photo-1558981289-42a1e2b2133e\"]", true, false, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "Spike", 6, 1026, "Small", 0.4m },
                    { 25, null, (short)4, 25, new DateTime(2023, 10, 9, 13, 58, 48, 690, DateTimeKind.Local).AddTicks(6780), "Soft Chinchilla", 1, "Healthy", "[\"url49.jpg\",\"url50.jpg\"]", true, false, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "Chinchy", 5, 1024, "Small", 0.6m },
                    { 26, null, (short)1, 26, new DateTime(2024, 5, 9, 13, 58, 48, 690, DateTimeKind.Local).AddTicks(6787), "Colorful Betta Fish", 1, "Healthy", "[\"url51.jpg\",\"url52.jpg\"]", false, false, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "Bubbles", 6, 1024, "Small", 0.02m },
                    { 27, null, (short)2, 27, new DateTime(2024, 4, 9, 13, 58, 48, 690, DateTimeKind.Local).AddTicks(6792), "Tiny Frog", 2, "Healthy", "[\"url53.jpg\",\"url54.jpg\"]", false, false, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "Frodo", 6, 1024, "Small", 0.05m },
                    { 28, null, (short)3, 28, new DateTime(2023, 12, 9, 13, 58, 48, 690, DateTimeKind.Local).AddTicks(6797), "Creepy Tarantula", 2, "Healthy", "[\"url55.jpg\",\"url56.jpg\"]", true, false, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "Spidey", 6, 1024, "Small", 0.1m },
                    { 29, null, (short)2, 29, new DateTime(2024, 5, 9, 13, 58, 48, 690, DateTimeKind.Local).AddTicks(6802), "Amphibious Newt", 2, "Healthy", "[\"url57.jpg\",\"url58.jpg\"]", false, false, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "Newt", 6, 1024, "Small", 0.07m },
                    { 30, null, (short)5, 30, new DateTime(2023, 10, 9, 13, 58, 48, 690, DateTimeKind.Local).AddTicks(6808), "Scaly Iguana", 1, "Healthy", "[\"url59.jpg\",\"url60.jpg\"]", true, false, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "Scales", 6, 1024, "Medium", 1.5m },
                    { 31, null, (short)4, 31, new DateTime(2023, 10, 9, 13, 58, 48, 690, DateTimeKind.Local).AddTicks(6813), "Guard Dog Rottweiler", 1, "Healthy", "[\"url61.jpg\",\"url62.jpg\"]", false, false, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "Rex", 1, 1024, "Large", 50.0m },
                    { 32, null, (short)2, 32, new DateTime(2024, 7, 9, 13, 58, 48, 690, DateTimeKind.Local).AddTicks(6818), "Playful Pug", 1, "Healthy", "[\"url63.jpg\",\"url64.jpg\"]", true, false, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "Milo", 1, 1024, "Small", 8.5m },
                    { 33, null, (short)3, 33, new DateTime(2023, 10, 9, 13, 58, 48, 690, DateTimeKind.Local).AddTicks(6823), "Adorable Shih Tzu", 2, "Healthy", "[\"url65.jpg\",\"url66.jpg\"]", false, false, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "Bailey", 1, 1023, "Small", 6.2m },
                    { 34, null, (short)4, 34, new DateTime(2024, 6, 9, 13, 58, 48, 690, DateTimeKind.Local).AddTicks(6828), "Agile Greyhound", 2, "Healthy", "[\"url67.jpg\",\"url68.jpg\"]", true, false, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "Sasha", 1, 1023, "Large", 28.0m },
                    { 35, null, (short)3, 35, new DateTime(2023, 11, 9, 13, 58, 48, 690, DateTimeKind.Local).AddTicks(6833), "Energetic Boxer", 1, "Healthy", "[\"url69.jpg\",\"url70.jpg\"]", false, false, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "Rocky", 1, 1023, "Large", 35.0m },
                    { 36, null, (short)2, 36, new DateTime(2023, 10, 9, 13, 58, 48, 690, DateTimeKind.Local).AddTicks(6839), "Affectionate Ragdoll", 1, "Healthy", "[\"url71.jpg\",\"url72.jpg\"]", true, false, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "Toby", 2, 1023, "Large", 9.0m },
                    { 37, null, (short)3, 37, new DateTime(2023, 12, 9, 13, 58, 48, 690, DateTimeKind.Local).AddTicks(6843), "Quiet British Shorthair", 2, "Healthy", "[\"url73.jpg\",\"url74.jpg\"]", false, false, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "Misty", 2, 1022, "Medium", 7.0m },
                    { 38, null, (short)4, 38, new DateTime(2023, 10, 9, 13, 58, 48, 690, DateTimeKind.Local).AddTicks(6848), "Mischievous Sphynx", 1, "Healthy", "[\"url75.jpg\",\"url76.jpg\"]", true, false, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "Oscar", 2, 1022, "Medium", 8.0m },
                    { 39, null, (short)2, 39, new DateTime(2023, 10, 9, 13, 58, 48, 690, DateTimeKind.Local).AddTicks(6853), "Active Abyssinian", 2, "Healthy", "[\"url77.jpg\",\"url78.jpg\"]", false, false, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "Ginger", 2, 1022, "Small", 5.5m },
                    { 40, null, (short)3, 40, new DateTime(2023, 10, 9, 13, 58, 48, 690, DateTimeKind.Local).AddTicks(6858), "Laid-back Birman", 1, "Healthy", "[\"url79.jpg\",\"url80.jpg\"]", true, false, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "Jasper", 2, 1022, "Medium", 6.5m },
                    { 41, null, (short)3, 41, new DateTime(2024, 4, 9, 13, 58, 48, 690, DateTimeKind.Local).AddTicks(6863), "Bright Sun Conure", 2, "Healthy", "[\"url81.jpg\",\"url82.jpg\"]", false, false, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "Sunshine", 3, 1022, "Small", 0.12m },
                    { 42, null, (short)1, 42, new DateTime(2023, 10, 9, 13, 58, 48, 690, DateTimeKind.Local).AddTicks(6868), "Chirpy Canary", 1, "Healthy", "[\"url83.jpg\",\"url84.jpg\"]", false, false, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "Tweety", 3, 1022, "Small", 0.03m },
                    { 43, null, (short)2, 43, new DateTime(2024, 1, 9, 13, 58, 48, 690, DateTimeKind.Local).AddTicks(6873), "Friendly Budgie", 1, "Healthy", "[\"url85.jpg\",\"url86.jpg\"]", true, false, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "Buddy", 3, 1022, "Small", 0.04m },
                    { 44, null, (short)2, 44, new DateTime(2024, 6, 9, 13, 58, 48, 690, DateTimeKind.Local).AddTicks(6878), "Talkative Parakeet", 2, "Healthy", "[\"url87.jpg\",\"url88.jpg\"]", false, false, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "Chirpy", 3, 1021, "Small", 0.05m },
                    { 45, null, (short)4, 45, new DateTime(2023, 11, 9, 13, 58, 48, 690, DateTimeKind.Local).AddTicks(6883), "Noisy Cockatoo", 1, "Healthy", "[\"url89.jpg\",\"url90.jpg\"]", true, false, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "Pepper", 3, 1021, "Medium", 0.5m },
                    { 46, null, (short)5, 46, new DateTime(2024, 2, 9, 13, 58, 48, 690, DateTimeKind.Local).AddTicks(6888), "Venomous King Cobra", 1, "Healthy", "[\"url91.jpg\",\"url92.jpg\"]", false, false, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "Slither", 4, 1021, "Large", 6.0m },
                    { 47, null, (short)7, 47, new DateTime(2024, 7, 9, 13, 58, 48, 690, DateTimeKind.Local).AddTicks(6893), "Large Komodo Dragon", 1, "Healthy", "[\"url93.jpg\",\"url94.jpg\"]", false, false, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "Rex", 4, 1021, "Large", 70.0m },
                    { 48, null, (short)4, 48, new DateTime(2024, 4, 9, 13, 58, 48, 690, DateTimeKind.Local).AddTicks(6898), "Green Iguana", 2, "Healthy", "[\"url95.jpg\",\"url96.jpg\"]", true, false, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "Ivy", 4, 1021, "Medium", 3.5m },
                    { 49, null, (short)5, 49, new DateTime(2023, 11, 9, 13, 58, 48, 690, DateTimeKind.Local).AddTicks(6903), "Horned Lizard", 1, "Healthy", "[\"url97.jpg\",\"url98.jpg\"]", false, false, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "Spike", 4, 1021, "Medium", 2.5m },
                    { 50, null, (short)100, 50, new DateTime(2024, 8, 9, 13, 58, 48, 690, DateTimeKind.Local).AddTicks(6908), "Giant Tortoise", 1, "Healthy", "[\"url99.jpg\",\"url100.jpg\"]", true, false, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "Shelly", 4, 1021, "Large", 200.0m }
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
