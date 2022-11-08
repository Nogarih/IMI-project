using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace Imi.Project.Api.Infrastructure.Migrations
{
    public partial class InitialMigration : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "AspNetRoles",
                columns: table => new
                {
                    Id = table.Column<string>(nullable: false),
                    Name = table.Column<string>(maxLength: 256, nullable: true),
                    NormalizedName = table.Column<string>(maxLength: 256, nullable: true),
                    ConcurrencyStamp = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AspNetRoles", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "AspNetUsers",
                columns: table => new
                {
                    Id = table.Column<string>(nullable: false),
                    UserName = table.Column<string>(maxLength: 256, nullable: true),
                    NormalizedUserName = table.Column<string>(maxLength: 256, nullable: true),
                    Email = table.Column<string>(maxLength: 256, nullable: true),
                    NormalizedEmail = table.Column<string>(maxLength: 256, nullable: true),
                    EmailConfirmed = table.Column<bool>(nullable: false),
                    PasswordHash = table.Column<string>(nullable: true),
                    SecurityStamp = table.Column<string>(nullable: true),
                    ConcurrencyStamp = table.Column<string>(nullable: true),
                    PhoneNumber = table.Column<string>(nullable: true),
                    PhoneNumberConfirmed = table.Column<bool>(nullable: false),
                    TwoFactorEnabled = table.Column<bool>(nullable: false),
                    LockoutEnd = table.Column<DateTimeOffset>(nullable: true),
                    LockoutEnabled = table.Column<bool>(nullable: false),
                    AccessFailedCount = table.Column<int>(nullable: false),
                    Birthday = table.Column<DateTime>(nullable: false),
                    HasApprovedTermsAndConditions = table.Column<bool>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AspNetUsers", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Directors",
                columns: table => new
                {
                    Id = table.Column<Guid>(nullable: false),
                    Name = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Directors", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Genres",
                columns: table => new
                {
                    Id = table.Column<Guid>(nullable: false),
                    Name = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Genres", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Languages",
                columns: table => new
                {
                    Id = table.Column<Guid>(nullable: false),
                    Name = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Languages", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "AspNetRoleClaims",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    RoleId = table.Column<string>(nullable: false),
                    ClaimType = table.Column<string>(nullable: true),
                    ClaimValue = table.Column<string>(nullable: true)
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
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    UserId = table.Column<string>(nullable: false),
                    ClaimType = table.Column<string>(nullable: true),
                    ClaimValue = table.Column<string>(nullable: true)
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
                    LoginProvider = table.Column<string>(nullable: false),
                    ProviderKey = table.Column<string>(nullable: false),
                    ProviderDisplayName = table.Column<string>(nullable: true),
                    UserId = table.Column<string>(nullable: false)
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
                    UserId = table.Column<string>(nullable: false),
                    RoleId = table.Column<string>(nullable: false)
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
                    UserId = table.Column<string>(nullable: false),
                    LoginProvider = table.Column<string>(nullable: false),
                    Name = table.Column<string>(nullable: false),
                    Value = table.Column<string>(nullable: true)
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
                name: "WatchItems",
                columns: table => new
                {
                    Id = table.Column<Guid>(nullable: false),
                    Title = table.Column<string>(nullable: true),
                    ReleaseYear = table.Column<int>(nullable: false),
                    Description = table.Column<string>(nullable: true),
                    Image = table.Column<string>(nullable: true),
                    LanguageId = table.Column<Guid>(nullable: false),
                    GenreId = table.Column<Guid>(nullable: false),
                    Discriminator = table.Column<string>(nullable: false),
                    Seasons = table.Column<int>(nullable: true),
                    TotalEpisodes = table.Column<int>(nullable: true),
                    HasSub = table.Column<bool>(nullable: true),
                    DirectorId = table.Column<Guid>(nullable: true),
                    TvSerie_Seasons = table.Column<int>(nullable: true),
                    TvSerie_TotalEpisodes = table.Column<int>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_WatchItems", x => x.Id);
                    table.ForeignKey(
                        name: "FK_WatchItems_Directors_DirectorId",
                        column: x => x.DirectorId,
                        principalTable: "Directors",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_WatchItems_Genres_GenreId",
                        column: x => x.GenreId,
                        principalTable: "Genres",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_WatchItems_Languages_LanguageId",
                        column: x => x.LanguageId,
                        principalTable: "Languages",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "UserWatchItems",
                columns: table => new
                {
                    UserId = table.Column<Guid>(nullable: false),
                    WatchItemId = table.Column<Guid>(nullable: false),
                    UserId1 = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_UserWatchItems", x => new { x.UserId, x.WatchItemId });
                    table.ForeignKey(
                        name: "FK_UserWatchItems_AspNetUsers_UserId1",
                        column: x => x.UserId1,
                        principalTable: "AspNetUsers",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_UserWatchItems_WatchItems_WatchItemId",
                        column: x => x.WatchItemId,
                        principalTable: "WatchItems",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.InsertData(
                table: "AspNetRoles",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[,]
                {
                    { "00000000-0000-0000-0000-000000000002", "72fe3f15-670b-423c-94c2-924dd4bd0630", "User", "USER" },
                    { "00000000-0000-0000-0000-000000000001", "2152188c-7484-43a2-b630-4672cdf38ad3", "Admin", "ADMIN" }
                });

            migrationBuilder.InsertData(
                table: "AspNetUsers",
                columns: new[] { "Id", "AccessFailedCount", "Birthday", "ConcurrencyStamp", "Email", "EmailConfirmed", "HasApprovedTermsAndConditions", "LockoutEnabled", "LockoutEnd", "NormalizedEmail", "NormalizedUserName", "PasswordHash", "PhoneNumber", "PhoneNumberConfirmed", "SecurityStamp", "TwoFactorEnabled", "UserName" },
                values: new object[,]
                {
                    { "00000000-0000-0000-0000-000000000005", 0, new DateTime(1995, 5, 28, 0, 0, 0, 0, DateTimeKind.Unspecified), "c8554266-b401-4519-9aeb-a9283053fc60", "jordanh@email.com", true, false, false, null, "JORDANH@EMAIL.COM", "JORDANH", "AQAAAAEAACcQAAAAEBXuuHqXposvHJzYKY/QfS9J2niFHQ7zTfeZ2sThipP+rhph7bgs6emvbzZWwEfWSQ==", null, false, "VVPCRDAS3MJWQD5CSW2GWPRADBXEZINC", false, "jordanh" },
                    { "00000000-0000-0000-0000-000000000004", 0, new DateTime(1996, 2, 15, 0, 0, 0, 0, DateTimeKind.Unspecified), "c8554266-b401-4519-9aeb-a9283053fc60", "ellen@email.com", true, true, false, null, "ELLEN@EMAIL.COM", "EMEULENI", "AQAAAAEAACcQAAAAEOJ+7bbwFNnzJUxqu4t/Pi1zAv3g9jXPgfE9l6qKWI1An+17cwzifQzeudDZm2vYEQ==", null, false, "VVPCRDAS3MJWQD5CSW2GWPRADBXEZINC", false, "emeuleni" },
                    { "00000000-0000-0000-0000-000000000003", 0, new DateTime(1986, 2, 18, 0, 0, 0, 0, DateTimeKind.Unspecified), "c8554266-b401-4519-9aeb-a9283053fc60", "refuser@pri.be", true, false, false, null, "REFUSER@PRI.BE", "PRIREFUSER", "AQAAAAEAACcQAAAAEM4MRjJbBuCWKiWyPR7F4UGNrqbBcxNrqcKUPg+HB05Ma+ZGlL5ONI+XwIQaMFHl7A==", null, false, "VVPCRDAS3MJWQD5CSW2GWPRADBXEZINC", false, "PriRefuser" },
                    { "00000000-0000-0000-0000-000000000002", 0, new DateTime(1990, 4, 2, 0, 0, 0, 0, DateTimeKind.Unspecified), "c8554266-b401-4519-9aeb-a9283053fc59", "user@pri.be", true, true, false, null, "USER@PRI.BE", "PRIUSER", "AQAAAAEAACcQAAAAEOhyqNMWsu9P4jr529qlYCSIoKQpSCY9LAtL5VJ/FP4P2PmtL2RJvHdHI8nVVCOmww==", null, false, "VVPCRDAS3MJWQD5CSW2GWPRADBXEZINB", false, "PriUser" },
                    { "00000000-0000-0000-0000-000000000001", 0, new DateTime(1996, 2, 15, 0, 0, 0, 0, DateTimeKind.Unspecified), "c8554266-b401-4519-9aeb-a9283053fc58", "admin@pri.be", true, null, false, null, "ADMIN@PRI.BE", "PRIADMIN", "AQAAAAEAACcQAAAAELBh5+VF+fX5NxPQUcOEHOA0RXmMaV9J+6ScZtMUX5AHR0Q8k0aTDoDVS7afVnTI8w==", null, false, "VVPCRDAS3MJWQD5CSW2GWPRADBXEZINA", false, "PriAdmin" }
                });

            migrationBuilder.InsertData(
                table: "Directors",
                columns: new[] { "Id", "Name" },
                values: new object[,]
                {
                    { new Guid("00000000-0000-0000-0000-000000000014"), "Makoto Shinkai" },
                    { new Guid("00000000-0000-0000-0000-000000000013"), "James Mangold" },
                    { new Guid("00000000-0000-0000-0000-000000000012"), "Bong Joon Ho" },
                    { new Guid("00000000-0000-0000-0000-000000000001"), "Todd Phillips" },
                    { new Guid("00000000-0000-0000-0000-000000000010"), "Ridley Scott" },
                    { new Guid("00000000-0000-0000-0000-000000000009"), "Robert Kirkman" },
                    { new Guid("00000000-0000-0000-0000-000000000008"), "David Milch" },
                    { new Guid("00000000-0000-0000-0000-000000000002"), "Eric Kripke" },
                    { new Guid("00000000-0000-0000-0000-000000000003"), "Christopher Nolan" },
                    { new Guid("00000000-0000-0000-0000-000000000004"), "Vince Gilligan" },
                    { new Guid("00000000-0000-0000-0000-000000000005"), "Chris Buck" },
                    { new Guid("00000000-0000-0000-0000-000000000006"), "F.Gary Gray" },
                    { new Guid("00000000-0000-0000-0000-000000000007"), "James Manos Jr." },
                    { new Guid("00000000-0000-0000-0000-000000000011"), "John Carpenter" }
                });

            migrationBuilder.InsertData(
                table: "Genres",
                columns: new[] { "Id", "Name" },
                values: new object[,]
                {
                    { new Guid("00000000-0000-0000-0000-000000000019"), "Josei" },
                    { new Guid("00000000-0000-0000-0000-000000000020"), "Ecchi" },
                    { new Guid("00000000-0000-0000-0000-000000000022"), "Isekai" },
                    { new Guid("00000000-0000-0000-0000-000000000027"), "Family" },
                    { new Guid("00000000-0000-0000-0000-000000000024"), "Magic" },
                    { new Guid("00000000-0000-0000-0000-000000000025"), "Yaoi" },
                    { new Guid("00000000-0000-0000-0000-000000000026"), "Yuri" },
                    { new Guid("00000000-0000-0000-0000-000000000028"), "Animation" },
                    { new Guid("00000000-0000-0000-0000-000000000023"), "Mecha" },
                    { new Guid("00000000-0000-0000-0000-000000000018"), "Seinen" },
                    { new Guid("00000000-0000-0000-0000-000000000021"), "Harem" },
                    { new Guid("00000000-0000-0000-0000-000000000015"), "Sci-Fi" },
                    { new Guid("00000000-0000-0000-0000-000000000001"), "Crime" },
                    { new Guid("00000000-0000-0000-0000-000000000002"), "Drama" },
                    { new Guid("00000000-0000-0000-0000-000000000003"), "Thriller" },
                    { new Guid("00000000-0000-0000-0000-000000000004"), "Horror" },
                    { new Guid("00000000-0000-0000-0000-000000000005"), "Action" },
                    { new Guid("00000000-0000-0000-0000-000000000017"), "Shoujo" },
                    { new Guid("00000000-0000-0000-0000-000000000006"), "Romance" },
                    { new Guid("00000000-0000-0000-0000-000000000016"), "Shonen" },
                    { new Guid("00000000-0000-0000-0000-000000000008"), "Western" },
                    { new Guid("00000000-0000-0000-0000-000000000014"), "Documentary" },
                    { new Guid("00000000-0000-0000-0000-000000000013"), "Biographical" },
                    { new Guid("00000000-0000-0000-0000-000000000012"), "Fantasy" },
                    { new Guid("00000000-0000-0000-0000-000000000009"), "Documentary" },
                    { new Guid("00000000-0000-0000-0000-000000000011"), "Superhero" },
                    { new Guid("00000000-0000-0000-0000-000000000010"), "Historical" },
                    { new Guid("00000000-0000-0000-0000-000000000007"), "Comedy" }
                });

            migrationBuilder.InsertData(
                table: "Languages",
                columns: new[] { "Id", "Name" },
                values: new object[,]
                {
                    { new Guid("00000000-0000-0000-0000-000000000010"), "Spanish" },
                    { new Guid("00000000-0000-0000-0000-000000000008"), "Chinese" },
                    { new Guid("00000000-0000-0000-0000-000000000007"), "German" },
                    { new Guid("00000000-0000-0000-0000-000000000006"), "Norwegian" },
                    { new Guid("00000000-0000-0000-0000-000000000005"), "French" },
                    { new Guid("00000000-0000-0000-0000-000000000003"), "Korean" },
                    { new Guid("00000000-0000-0000-0000-000000000002"), "Japanese" },
                    { new Guid("00000000-0000-0000-0000-000000000001"), "English" },
                    { new Guid("00000000-0000-0000-0000-000000000009"), "Italian" },
                    { new Guid("00000000-0000-0000-0000-000000000004"), "Dutch" }
                });

            migrationBuilder.InsertData(
                table: "AspNetUserClaims",
                columns: new[] { "Id", "ClaimType", "ClaimValue", "UserId" },
                values: new object[,]
                {
                    { 3, "hasApprovedTermsAndConditions", "True", "00000000-0000-0000-0000-000000000002" },
                    { 1, "http://schemas.microsoft.com/ws/2008/06/identity/claims/role", "Admin", "00000000-0000-0000-0000-000000000001" },
                    { 2, "http://schemas.microsoft.com/ws/2008/06/identity/claims/role", "User", "00000000-0000-0000-0000-000000000002" },
                    { 4, "http://schemas.microsoft.com/ws/2008/06/identity/claims/role", "User", "00000000-0000-0000-0000-000000000003" },
                    { 9, "hasApprovedTermsAndConditions", "False", "00000000-0000-0000-0000-000000000005" },
                    { 8, "http://schemas.microsoft.com/ws/2008/06/identity/claims/role", "User", "00000000-0000-0000-0000-000000000005" },
                    { 7, "hasApprovedTermsAndConditions", "True", "00000000-0000-0000-0000-000000000004" },
                    { 6, "http://schemas.microsoft.com/ws/2008/06/identity/claims/role", "User", "00000000-0000-0000-0000-000000000004" },
                    { 5, "hasApprovedTermsAndConditions", "False", "00000000-0000-0000-0000-000000000003" }
                });

            migrationBuilder.InsertData(
                table: "AspNetUserRoles",
                columns: new[] { "UserId", "RoleId" },
                values: new object[,]
                {
                    { "00000000-0000-0000-0000-000000000005", "00000000-0000-0000-0000-000000000002" },
                    { "00000000-0000-0000-0000-000000000002", "00000000-0000-0000-0000-000000000002" },
                    { "00000000-0000-0000-0000-000000000003", "00000000-0000-0000-0000-000000000002" },
                    { "00000000-0000-0000-0000-000000000001", "00000000-0000-0000-0000-000000000001" },
                    { "00000000-0000-0000-0000-000000000004", "00000000-0000-0000-0000-000000000002" }
                });

            migrationBuilder.InsertData(
                table: "WatchItems",
                columns: new[] { "Id", "Description", "Discriminator", "GenreId", "Image", "LanguageId", "ReleaseYear", "Title", "HasSub", "Seasons", "TotalEpisodes" },
                values: new object[] { new Guid("00000000-0000-0000-0000-000000000006"), "Naruto Uzumaki, is a loud, hyperactive, adolescent ninja who constantly searches for approval and recognition, as well as to become Hokage, who is acknowledged as the leader and strongest of all ninja in the village.", "Anime", new Guid("00000000-0000-0000-0000-000000000016"), "https://www.ecranlarge.com/uploads/image/001/151/affiche-1151327.jpg", new Guid("00000000-0000-0000-0000-000000000002"), 2007, "Naruto", true, 21, 502 });

            migrationBuilder.InsertData(
                table: "WatchItems",
                columns: new[] { "Id", "Description", "Discriminator", "GenreId", "Image", "LanguageId", "ReleaseYear", "Title", "TvSerie_Seasons", "TvSerie_TotalEpisodes" },
                values: new object[] { new Guid("00000000-0000-0000-0000-000000000028"), "Hundreds of cash-strapped players accept a strange invitation to compete in children's games. Inside, a tempting prize awaits with deadly high stakes. A survival game that has a whopping 45.6 billion-won prize at stake.", "TvSerie", new Guid("00000000-0000-0000-0000-000000000002"), "https://0.soompi.io/wp-content/uploads/2021/08/23110511/squid-game.jpeg", new Guid("00000000-0000-0000-0000-000000000003"), 2021, "Squid Game", 1, 9 });

            migrationBuilder.InsertData(
                table: "WatchItems",
                columns: new[] { "Id", "Description", "Discriminator", "GenreId", "Image", "LanguageId", "ReleaseYear", "Title", "DirectorId" },
                values: new object[,]
                {
                    { new Guid("00000000-0000-0000-0000-000000000020"), "Greed and class discrimination threaten the newly formed symbiotic relationship between the wealthy Park family and the destitute Kim clan.", "Movie", new Guid("00000000-0000-0000-0000-000000000007"), "https://m.media-amazon.com/images/I/91sustfojBL._AC_SL1500_.jpg", new Guid("00000000-0000-0000-0000-000000000003"), 2019, "Parasite", new Guid("00000000-0000-0000-0000-000000000012") },
                    { new Guid("00000000-0000-0000-0000-000000000015"), "Two strangers find themselves linked in a bizarre way. When a connection forms, will distance be the only thing to keep them apart?", "Movie", new Guid("00000000-0000-0000-0000-000000000012"), "https://cdn.hmv.com/r/w-640/hmv/files/7e/7e218362-fccb-4eea-9d9a-f8df684538ec.jpg", new Guid("00000000-0000-0000-0000-000000000002"), 2016, "Your Name", new Guid("00000000-0000-0000-0000-000000000014") }
                });

            migrationBuilder.InsertData(
                table: "WatchItems",
                columns: new[] { "Id", "Description", "Discriminator", "GenreId", "Image", "LanguageId", "ReleaseYear", "Title", "HasSub", "Seasons", "TotalEpisodes" },
                values: new object[,]
                {
                    { new Guid("00000000-0000-0000-0000-000000000010"), "After Tohru is taken in by the Soma family, she learns that twelve family members transform involuntarily into animals of the Chinese zodiac and helps them deal with the emotional pain caused by the transformations.", "Anime", new Guid("00000000-0000-0000-0000-000000000017"), "https://image.animedigitalnetwork.fr/license/fruitsbasket/tv/web/affiche_370x0.jpg", new Guid("00000000-0000-0000-0000-000000000002"), 2019, "Fruits Basket", true, 5, 63 },
                    { new Guid("00000000-0000-0000-0000-000000000009"), "In an era where aliens have invaded and taken over feudal Tokyo, an unemployed samurai finds work however he can.", "Anime", new Guid("00000000-0000-0000-0000-000000000007"), "https://www.themoviedb.org/t/p/w500/5AX6ObPYZN0RP3L0Eu7s0RCLxeX.jpg", new Guid("00000000-0000-0000-0000-000000000002"), 2005, "Gintama", true, 8, 375 },
                    { new Guid("00000000-0000-0000-0000-000000000008"), "After his hometown is destroyed and his mother is killed, young Eren Jaeger vows to cleanse the earth of the giant humanoid Titans that have brought humanity to the brink of extinction.", "Anime", new Guid("00000000-0000-0000-0000-000000000016"), "https://cdn.europosters.eu/image/750/posters/attack-on-titan-shingeki-no-kyojin-key-art-i22808.jpg", new Guid("00000000-0000-0000-0000-000000000002"), 2013, "Shingeki no Kyojin", true, 4, 86 },
                    { new Guid("00000000-0000-0000-0000-000000000007"), "Ayuzawa Misaki serves as the student council president at Seika High. However, unbeknownst to her classmates, she works part-time as an employee at a Maid Cafe. Usui Takumi, a boy from her school, discovers this secret.", "Anime", new Guid("00000000-0000-0000-0000-000000000017"), "https://www.themoviedb.org/t/p/original/igkn0M1bgMeATz59LShvVxZNdVd.jpg", new Guid("00000000-0000-0000-0000-000000000002"), 2010, "Kaichou wa Maid-sama!", true, 1, 28 },
                    { new Guid("00000000-0000-0000-0000-000000000005"), "After learning that he is from another planet, a warrior named Goku and his friends are prompted to defend it from an onslaught of extraterrestrial enemies.", "Anime", new Guid("00000000-0000-0000-0000-000000000016"), "https://m.media-amazon.com/images/M/MV5BMGMyOThiMGUtYmFmZi00YWM0LWJiM2QtZGMwM2Q2ODE4MzhhXkEyXkFqcGdeQXVyMjc2Nzg5OTQ@._V1_.jpg", new Guid("00000000-0000-0000-0000-000000000002"), 1996, "Dragon Ball Z", false, 16, 227 },
                    { new Guid("00000000-0000-0000-0000-000000000003"), "High school student Ichigo Kurosaki, who has the ability to see ghosts, gains soul reaper powers from Rukia Kuchiki and sets out to save the world from Hollows.", "Anime", new Guid("00000000-0000-0000-0000-000000000016"), "https://pics.filmaffinity.com/Bleach_TV_Series-214857327-large.jpg", new Guid("00000000-0000-0000-0000-000000000002"), 2004, "Bleach", false, 16, 369 }
                });

            migrationBuilder.InsertData(
                table: "WatchItems",
                columns: new[] { "Id", "Description", "Discriminator", "GenreId", "Image", "LanguageId", "ReleaseYear", "Title", "DirectorId" },
                values: new object[,]
                {
                    { new Guid("00000000-0000-0000-0000-000000000012"), "A frustrated man decides to take justice into his own hands after a plea bargain sets one of his family's killers free.", "Movie", new Guid("00000000-0000-0000-0000-000000000001"), "https://i.pinimg.com/originals/98/53/97/985397db12c9ee1e9a6f1887132d7143.jpg", new Guid("00000000-0000-0000-0000-000000000001"), 2009, "Law Abiding Citizen", new Guid("00000000-0000-0000-0000-000000000006") },
                    { new Guid("00000000-0000-0000-0000-000000000013"), "In a future where mutants are nearly extinct, an elderly and weary Logan leads a quiet life. But when Laura, a mutant child pursued by scientists, comes to him for help, he must get her to safety.", "Movie", new Guid("00000000-0000-0000-0000-000000000011"), "https://m.media-amazon.com/images/I/91WgnhSHyzL._AC_SL1500_.jpg", new Guid("00000000-0000-0000-0000-000000000001"), 2017, "Logan", new Guid("00000000-0000-0000-0000-000000000013") },
                    { new Guid("00000000-0000-0000-0000-000000000014"), "After a tragic accident, two stage magicians in 1890s London engage in a battle to create the ultimate illusion while sacrificing everything they have to outwit each other.", "Movie", new Guid("00000000-0000-0000-0000-000000000002"), "https://i.pinimg.com/originals/b8/ca/36/b8ca36698e80e2e5b8da7ac5311dea68.jpg", new Guid("00000000-0000-0000-0000-000000000001"), 2006, "The Prestige", new Guid("00000000-0000-0000-0000-000000000003") },
                    { new Guid("00000000-0000-0000-0000-000000000016"), "A man raised by gorillas must decide where he really belongs when he discovers he is a human.", "Movie", new Guid("00000000-0000-0000-0000-000000000028"), "https://m.media-amazon.com/images/I/511JYaL4kAL._AC_.jpg", new Guid("00000000-0000-0000-0000-000000000001"), 1999, "Tarzan", new Guid("00000000-0000-0000-0000-000000000005") },
                    { new Guid("00000000-0000-0000-0000-000000000017"), "A research team in Antarctica is hunted by a shape-shifting alien that assumes the appearance of its victims.", "Movie", new Guid("00000000-0000-0000-0000-000000000004"), "https://m.media-amazon.com/images/M/MV5BNGViZWZmM2EtNGYzZi00ZDAyLTk3ODMtNzIyZTBjN2Y1NmM1XkEyXkFqcGdeQXVyNTAyODkwOQ@@._V1_.jpg", new Guid("00000000-0000-0000-0000-000000000001"), 1982, "The Thing", new Guid("00000000-0000-0000-0000-000000000011") },
                    { new Guid("00000000-0000-0000-0000-000000000018"), "A former Roman General sets out to exact vengeance against the corrupt emperor who murdered his family and sent him into slavery.", "Movie", new Guid("00000000-0000-0000-0000-000000000005"), "https://lh3.googleusercontent.com/proxy/Urw2HIVZ39hfNxch37mGggoOCjTsUlncvcSO1W5fwAcXO3CzMIlRzZHN_By1QEHCuG6ETpP5lF-ZVUOatxTM_hAu6ub9bT0ovDE_oOww7XfWfKak", new Guid("00000000-0000-0000-0000-000000000001"), 2000, "Gladiator", new Guid("00000000-0000-0000-0000-000000000010") },
                    { new Guid("00000000-0000-0000-0000-000000000019"), "King Charles VI declares that Knight Jean de Carrouges settle his dispute with his squire by challenging him to a duel.", "Movie", new Guid("00000000-0000-0000-0000-000000000010"), "https://lh3.googleusercontent.com/proxy/8Jbnz5trqlL0vTp5gazZ_r8zE3PCniCJkolTQgsW7X0Q5mniaV02QKhkrI0Zq7M9VKWLlNHai28fa1PMQVyT2z-yRVi0xmVbbygndelZ1cs", new Guid("00000000-0000-0000-0000-000000000001"), 2021, "The Last Duel", new Guid("00000000-0000-0000-0000-000000000010") }
                });

            migrationBuilder.InsertData(
                table: "WatchItems",
                columns: new[] { "Id", "Description", "Discriminator", "GenreId", "Image", "LanguageId", "ReleaseYear", "Title", "TvSerie_Seasons", "TvSerie_TotalEpisodes" },
                values: new object[] { new Guid("00000000-0000-0000-0000-000000000021"), "He's smart. He's lovable. He's Dexter Morgan, America's favorite serial killer, who spends his days solving crimes and nights committing them. Golden Globe winner Michael C. Hall stars in the hit SHOWTIME Original Series.", "TvSerie", new Guid("00000000-0000-0000-0000-000000000001"), "https://m.media-amazon.com/images/I/71OC--Zwi2L._AC_SL1000_.jpg", new Guid("00000000-0000-0000-0000-000000000001"), 2006, "Dexter", 8, 96 });

            migrationBuilder.InsertData(
                table: "WatchItems",
                columns: new[] { "Id", "Description", "Discriminator", "GenreId", "Image", "LanguageId", "ReleaseYear", "Title", "HasSub", "Seasons", "TotalEpisodes" },
                values: new object[] { new Guid("00000000-0000-0000-0000-000000000004"), "An intelligent high school student goes on a secret crusade to eliminate criminals from the world after discovering a notebook capable of killing anyone whose name is written into it.", "Anime", new Guid("00000000-0000-0000-0000-000000000001"), "https://m.media-amazon.com/images/I/716ASj7z2GL._AC_SL1000_.jpg", new Guid("00000000-0000-0000-0000-000000000002"), 2019, "Death Note", true, 1, 37 });

            migrationBuilder.InsertData(
                table: "WatchItems",
                columns: new[] { "Id", "Description", "Discriminator", "GenreId", "Image", "LanguageId", "ReleaseYear", "Title", "TvSerie_Seasons", "TvSerie_TotalEpisodes" },
                values: new object[,]
                {
                    { new Guid("00000000-0000-0000-0000-000000000022"), "A show set in the late 1800s, revolving around the characters of Deadwood, South Dakota; a town of deep corruption and crime.", "TvSerie", new Guid("00000000-0000-0000-0000-000000000008"), "https://m.media-amazon.com/images/I/918wMqktUNL._SY500_.jpg", new Guid("00000000-0000-0000-0000-000000000001"), 2004, "Deadwood", 3, 36 },
                    { new Guid("00000000-0000-0000-0000-000000000024"), "A group of vigilantes set out to take down corrupt superheroes who abuse their superpowers.", "TvSerie", new Guid("00000000-0000-0000-0000-000000000011"), "https://m.media-amazon.com/images/M/MV5BNGEyOGJiNWEtMTgwMi00ODU4LTlkMjItZWI4NjFmMzgxZGY2XkEyXkFqcGdeQXVyNjcyNjcyMzQ@._V1_.jpg", new Guid("00000000-0000-0000-0000-000000000001"), 2019, "The Boys", 2, 24 },
                    { new Guid("00000000-0000-0000-0000-000000000025"), "An adult animated series based on the Skybound/Image comic about a teenager whose father is the most powerful superhero on the planet.", "TvSerie", new Guid("00000000-0000-0000-0000-000000000028"), "https://m.media-amazon.com/images/M/MV5BNWYwYjAyMzgtNzQyNC00M2JiLWI2ZTQtNzRmZThmOTk4NmRmXkEyXkFqcGdeQXVyMTkxNjUyNQ@@._V1_.jpg", new Guid("00000000-0000-0000-0000-000000000001"), 2021, "Invincible", 1, 8 },
                    { new Guid("00000000-0000-0000-0000-000000000026"), "A writer tries to juggle his career, his relationship with his daughter and his ex-girlfriend, as well as his appetite for beautiful women.", "TvSerie", new Guid("00000000-0000-0000-0000-000000000007"), "https://www.themoviedb.org/t/p/original/jPqOY8cq9KXQN4bD7zJGHCNvcb4.jpg", new Guid("00000000-0000-0000-0000-000000000001"), 2007, "Californication", 7, 84 },
                    { new Guid("00000000-0000-0000-0000-000000000027"), "Geralt of Rivia, a solitary monster hunter, struggles to find his place in a world where people often prove more wicked than beasts.", "TvSerie", new Guid("00000000-0000-0000-0000-000000000012"), "https://m.media-amazon.com/images/I/713TM23V+CL._AC_SL1000_.jpg", new Guid("00000000-0000-0000-0000-000000000001"), 2019, "The Witcher", 1, 17 },
                    { new Guid("00000000-0000-0000-0000-000000000029"), "In a war-torn world of elemental magic, a young boy reawakens to undertake a dangerous mystic quest to fulfill his destiny as the Avatar, and bring peace to the world.", "TvSerie", new Guid("00000000-0000-0000-0000-000000000028"), "https://images-na.ssl-images-amazon.com/images/I/81KjBiKs-AL.jpg", new Guid("00000000-0000-0000-0000-000000000001"), 2005, "Avatar: The Last Airbender", 3, 62 },
                    { new Guid("00000000-0000-0000-0000-000000000030"), "A gangster family epic set in 1900s England, centering on a gang who sew razor blades in the peaks of their caps, and their fierce boss Tommy Shelby.", "TvSerie", new Guid("00000000-0000-0000-0000-000000000001"), "https://i.pinimg.com/originals/b7/7c/ec/b77cec7281be7c2fc1dd793362927f76.jpg", new Guid("00000000-0000-0000-0000-000000000001"), 2014, "Peaky Blinders", 5, 36 }
                });

            migrationBuilder.InsertData(
                table: "WatchItems",
                columns: new[] { "Id", "Description", "Discriminator", "GenreId", "Image", "LanguageId", "ReleaseYear", "Title", "HasSub", "Seasons", "TotalEpisodes" },
                values: new object[,]
                {
                    { new Guid("00000000-0000-0000-0000-000000000001"), "A superhero-loving boy without any powers is determined to enroll in a prestigious hero academy and learn what it really means to be a hero.", "Anime", new Guid("00000000-0000-0000-0000-000000000011"), "https://static.posters.cz/image/750/posters/my-hero-academia-cobalt-blast-group-i63331.jpg", new Guid("00000000-0000-0000-0000-000000000002"), 2016, "My Hero Academia", true, 5, 117 },
                    { new Guid("00000000-0000-0000-0000-000000000002"), "A boy swallows a cursed talisman - the finger of a demon - and becomes cursed himself. He enters a shaman's school to be able to locate the demon's other body parts and thus exorcise himself.", "Anime", new Guid("00000000-0000-0000-0000-000000000016"), "https://www.themoviedb.org/t/p/original/mJVUZpPR4BdZzLWyP51h8pOU1RO.jpg", new Guid("00000000-0000-0000-0000-000000000002"), 2020, "Jujutsu Kaisen", true, 1, 24 }
                });

            migrationBuilder.InsertData(
                table: "WatchItems",
                columns: new[] { "Id", "Description", "Discriminator", "GenreId", "Image", "LanguageId", "ReleaseYear", "Title", "TvSerie_Seasons", "TvSerie_TotalEpisodes" },
                values: new object[] { new Guid("00000000-0000-0000-0000-000000000023"), "A high school chemistry teacher diagnosed with inoperable lung cancer turns to manufacturing and selling methamphetamine in order to secure his family's future.", "TvSerie", new Guid("00000000-0000-0000-0000-000000000001"), "https://i.pinimg.com/originals/72/83/92/728392b482329cfef27833fe110321b8.jpg", new Guid("00000000-0000-0000-0000-000000000001"), 2008, "Breaking Bad", 5, 62 });

            migrationBuilder.InsertData(
                table: "WatchItems",
                columns: new[] { "Id", "Description", "Discriminator", "GenreId", "Image", "LanguageId", "ReleaseYear", "Title", "DirectorId" },
                values: new object[] { new Guid("00000000-0000-0000-0000-000000000011"), "In Gotham City, mentally troubled comedian Arthur Fleck is disregarded and mistreated by society. He then embarks on a downward spiral of revolution and bloody crime. This path brings him face-to-face with his alter-ego: the Joker.", "Movie", new Guid("00000000-0000-0000-0000-000000000002"), "https://cdn11.bigcommerce.com/s-ydriczk/images/stencil/608x608/products/89058/93685/Joker-2019-Final-Style-steps-Poster-buy-original-movie-posters-at-starstills__62518.1572351179.jpg?c=2", new Guid("00000000-0000-0000-0000-000000000001"), 2019, "Joker", new Guid("00000000-0000-0000-0000-000000000001") });

            migrationBuilder.InsertData(
                table: "UserWatchItems",
                columns: new[] { "UserId", "WatchItemId", "UserId1" },
                values: new object[,]
                {
                    { new Guid("00000000-0000-0000-0000-000000000001"), new Guid("00000000-0000-0000-0000-000000000001"), null },
                    { new Guid("00000000-0000-0000-0000-000000000001"), new Guid("00000000-0000-0000-0000-000000000002"), null },
                    { new Guid("00000000-0000-0000-0000-000000000001"), new Guid("00000000-0000-0000-0000-000000000003"), null },
                    { new Guid("00000000-0000-0000-0000-000000000001"), new Guid("00000000-0000-0000-0000-000000000004"), null },
                    { new Guid("00000000-0000-0000-0000-000000000001"), new Guid("00000000-0000-0000-0000-000000000005"), null },
                    { new Guid("00000000-0000-0000-0000-000000000001"), new Guid("00000000-0000-0000-0000-000000000006"), null },
                    { new Guid("00000000-0000-0000-0000-000000000001"), new Guid("00000000-0000-0000-0000-000000000007"), null },
                    { new Guid("00000000-0000-0000-0000-000000000001"), new Guid("00000000-0000-0000-0000-000000000008"), null },
                    { new Guid("00000000-0000-0000-0000-000000000001"), new Guid("00000000-0000-0000-0000-000000000009"), null },
                    { new Guid("00000000-0000-0000-0000-000000000001"), new Guid("00000000-0000-0000-0000-000000000010"), null }
                });

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
                name: "IX_UserWatchItems_UserId1",
                table: "UserWatchItems",
                column: "UserId1");

            migrationBuilder.CreateIndex(
                name: "IX_UserWatchItems_WatchItemId",
                table: "UserWatchItems",
                column: "WatchItemId");

            migrationBuilder.CreateIndex(
                name: "IX_WatchItems_DirectorId",
                table: "WatchItems",
                column: "DirectorId");

            migrationBuilder.CreateIndex(
                name: "IX_WatchItems_GenreId",
                table: "WatchItems",
                column: "GenreId");

            migrationBuilder.CreateIndex(
                name: "IX_WatchItems_LanguageId",
                table: "WatchItems",
                column: "LanguageId");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
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
                name: "UserWatchItems");

            migrationBuilder.DropTable(
                name: "AspNetRoles");

            migrationBuilder.DropTable(
                name: "AspNetUsers");

            migrationBuilder.DropTable(
                name: "WatchItems");

            migrationBuilder.DropTable(
                name: "Directors");

            migrationBuilder.DropTable(
                name: "Genres");

            migrationBuilder.DropTable(
                name: "Languages");
        }
    }
}
