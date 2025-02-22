using System;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace AboutSongs.Migrations
{
    /// <inheritdoc />
    public partial class InitialCreate : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AlterDatabase()
                .Annotation("MySql:CharSet", "utf8mb4");

            migrationBuilder.CreateTable(
                name: "Album",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("MySql:ValueGenerationStrategy", MySqlValueGenerationStrategy.IdentityColumn),
                    Nome = table.Column<string>(type: "longtext", nullable: true)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    Titulo = table.Column<string>(type: "varchar(100)", maxLength: 100, nullable: false)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    Foto = table.Column<string>(type: "varchar(100)", maxLength: 100, nullable: true)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    DataDeLancamento = table.Column<DateTime>(type: "datetime(6)", nullable: false),
                    ExibirHome = table.Column<bool>(type: "tinyint(1)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Album", x => x.Id);
                })
                .Annotation("MySql:CharSet", "utf8mb4");

            migrationBuilder.CreateTable(
                name: "Artista",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("MySql:ValueGenerationStrategy", MySqlValueGenerationStrategy.IdentityColumn),
                    Nome = table.Column<string>(type: "varchar(80)", maxLength: 80, nullable: false)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    Biografia = table.Column<string>(type: "varchar(1000)", maxLength: 1000, nullable: true)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    DataDeNascimento = table.Column<DateTime>(type: "datetime(6)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Artista", x => x.Id);
                })
                .Annotation("MySql:CharSet", "utf8mb4");

            migrationBuilder.CreateTable(
                name: "AspNetRoles",
                columns: table => new
                {
                    Id = table.Column<string>(type: "varchar(255)", nullable: false)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    Name = table.Column<string>(type: "varchar(256)", maxLength: 256, nullable: true)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    NormalizedName = table.Column<string>(type: "varchar(256)", maxLength: 256, nullable: true)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    ConcurrencyStamp = table.Column<string>(type: "longtext", nullable: true)
                        .Annotation("MySql:CharSet", "utf8mb4")
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AspNetRoles", x => x.Id);
                })
                .Annotation("MySql:CharSet", "utf8mb4");

            migrationBuilder.CreateTable(
                name: "AspNetUsers",
                columns: table => new
                {
                    Id = table.Column<string>(type: "varchar(255)", nullable: false)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    UserName = table.Column<string>(type: "varchar(256)", maxLength: 256, nullable: true)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    NormalizedUserName = table.Column<string>(type: "varchar(256)", maxLength: 256, nullable: true)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    Email = table.Column<string>(type: "varchar(256)", maxLength: 256, nullable: true)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    NormalizedEmail = table.Column<string>(type: "varchar(256)", maxLength: 256, nullable: true)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    EmailConfirmed = table.Column<bool>(type: "tinyint(1)", nullable: false),
                    PasswordHash = table.Column<string>(type: "longtext", nullable: true)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    SecurityStamp = table.Column<string>(type: "longtext", nullable: true)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    ConcurrencyStamp = table.Column<string>(type: "longtext", nullable: true)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    PhoneNumber = table.Column<string>(type: "longtext", nullable: true)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    PhoneNumberConfirmed = table.Column<bool>(type: "tinyint(1)", nullable: false),
                    TwoFactorEnabled = table.Column<bool>(type: "tinyint(1)", nullable: false),
                    LockoutEnd = table.Column<DateTimeOffset>(type: "datetime(6)", nullable: true),
                    LockoutEnabled = table.Column<bool>(type: "tinyint(1)", nullable: false),
                    AccessFailedCount = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AspNetUsers", x => x.Id);
                })
                .Annotation("MySql:CharSet", "utf8mb4");

            migrationBuilder.CreateTable(
                name: "Critica",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("MySql:ValueGenerationStrategy", MySqlValueGenerationStrategy.IdentityColumn),
                    Nota = table.Column<int>(type: "int", nullable: false),
                    Comentario = table.Column<string>(type: "varchar(1000)", maxLength: 1000, nullable: true)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    DataDePublicacao = table.Column<DateTime>(type: "datetime(6)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Critica", x => x.Id);
                })
                .Annotation("MySql:CharSet", "utf8mb4");

            migrationBuilder.CreateTable(
                name: "Genero",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("MySql:ValueGenerationStrategy", MySqlValueGenerationStrategy.IdentityColumn),
                    Nome = table.Column<string>(type: "longtext", nullable: false)
                        .Annotation("MySql:CharSet", "utf8mb4")
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Genero", x => x.Id);
                })
                .Annotation("MySql:CharSet", "utf8mb4");

            migrationBuilder.CreateTable(
                name: "Musica",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("MySql:ValueGenerationStrategy", MySqlValueGenerationStrategy.IdentityColumn),
                    Título = table.Column<string>(type: "varchar(100)", maxLength: 100, nullable: false)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    Compositores = table.Column<string>(type: "varchar(1000)", maxLength: 1000, nullable: false)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    Foto = table.Column<string>(type: "longtext", nullable: true)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    Spotify = table.Column<string>(type: "longtext", nullable: true)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    AppleMusic = table.Column<string>(type: "longtext", nullable: true)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    Youtube = table.Column<string>(type: "longtext", nullable: true)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    Duracao = table.Column<TimeSpan>(type: "time(6)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Musica", x => x.Id);
                })
                .Annotation("MySql:CharSet", "utf8mb4");

            migrationBuilder.CreateTable(
                name: "AspNetRoleClaims",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("MySql:ValueGenerationStrategy", MySqlValueGenerationStrategy.IdentityColumn),
                    RoleId = table.Column<string>(type: "varchar(255)", nullable: false)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    ClaimType = table.Column<string>(type: "longtext", nullable: true)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    ClaimValue = table.Column<string>(type: "longtext", nullable: true)
                        .Annotation("MySql:CharSet", "utf8mb4")
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
                })
                .Annotation("MySql:CharSet", "utf8mb4");

            migrationBuilder.CreateTable(
                name: "AspNetUserClaims",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("MySql:ValueGenerationStrategy", MySqlValueGenerationStrategy.IdentityColumn),
                    UserId = table.Column<string>(type: "varchar(255)", nullable: false)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    ClaimType = table.Column<string>(type: "longtext", nullable: true)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    ClaimValue = table.Column<string>(type: "longtext", nullable: true)
                        .Annotation("MySql:CharSet", "utf8mb4")
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
                })
                .Annotation("MySql:CharSet", "utf8mb4");

            migrationBuilder.CreateTable(
                name: "AspNetUserLogins",
                columns: table => new
                {
                    LoginProvider = table.Column<string>(type: "varchar(255)", nullable: false)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    ProviderKey = table.Column<string>(type: "varchar(255)", nullable: false)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    ProviderDisplayName = table.Column<string>(type: "longtext", nullable: true)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    UserId = table.Column<string>(type: "varchar(255)", nullable: false)
                        .Annotation("MySql:CharSet", "utf8mb4")
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
                })
                .Annotation("MySql:CharSet", "utf8mb4");

            migrationBuilder.CreateTable(
                name: "AspNetUserRoles",
                columns: table => new
                {
                    UserId = table.Column<string>(type: "varchar(255)", nullable: false)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    RoleId = table.Column<string>(type: "varchar(255)", nullable: false)
                        .Annotation("MySql:CharSet", "utf8mb4")
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
                })
                .Annotation("MySql:CharSet", "utf8mb4");

            migrationBuilder.CreateTable(
                name: "AspNetUserTokens",
                columns: table => new
                {
                    UserId = table.Column<string>(type: "varchar(255)", nullable: false)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    LoginProvider = table.Column<string>(type: "varchar(255)", nullable: false)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    Name = table.Column<string>(type: "varchar(255)", nullable: false)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    Value = table.Column<string>(type: "longtext", nullable: true)
                        .Annotation("MySql:CharSet", "utf8mb4")
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
                })
                .Annotation("MySql:CharSet", "utf8mb4");

            migrationBuilder.CreateTable(
                name: "Usuario",
                columns: table => new
                {
                    UsuarioId = table.Column<string>(type: "varchar(255)", nullable: false)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    Nome = table.Column<string>(type: "varchar(60)", maxLength: 60, nullable: false)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    Foto = table.Column<string>(type: "varchar(300)", maxLength: 300, nullable: true)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    DataDeNascimento = table.Column<DateTime>(type: "datetime(6)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Usuario", x => x.UsuarioId);
                    table.ForeignKey(
                        name: "FK_Usuario_AspNetUsers_UsuarioId",
                        column: x => x.UsuarioId,
                        principalTable: "AspNetUsers",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                })
                .Annotation("MySql:CharSet", "utf8mb4");

            migrationBuilder.CreateTable(
                name: "AlbumGenero",
                columns: table => new
                {
                    AlbumId = table.Column<int>(type: "int", nullable: false),
                    GeneroId = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AlbumGenero", x => new { x.AlbumId, x.GeneroId });
                    table.ForeignKey(
                        name: "FK_AlbumGenero_Album_AlbumId",
                        column: x => x.AlbumId,
                        principalTable: "Album",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_AlbumGenero_Genero_GeneroId",
                        column: x => x.GeneroId,
                        principalTable: "Genero",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                })
                .Annotation("MySql:CharSet", "utf8mb4");

            migrationBuilder.CreateTable(
                name: "GeneroArtista",
                columns: table => new
                {
                    GeneroId = table.Column<int>(type: "int", nullable: false),
                    ArtistaId = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_GeneroArtista", x => new { x.GeneroId, x.ArtistaId });
                    table.ForeignKey(
                        name: "FK_GeneroArtista_Artista_ArtistaId",
                        column: x => x.ArtistaId,
                        principalTable: "Artista",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_GeneroArtista_Genero_GeneroId",
                        column: x => x.GeneroId,
                        principalTable: "Genero",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                })
                .Annotation("MySql:CharSet", "utf8mb4");

            migrationBuilder.CreateTable(
                name: "AlbumArtista",
                columns: table => new
                {
                    AlbumId = table.Column<int>(type: "int", nullable: false),
                    ArtistaId = table.Column<int>(type: "int", nullable: false),
                    MusicaId = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AlbumArtista", x => new { x.AlbumId, x.ArtistaId, x.MusicaId });
                    table.ForeignKey(
                        name: "FK_AlbumArtista_Album_AlbumId",
                        column: x => x.AlbumId,
                        principalTable: "Album",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_AlbumArtista_Artista_ArtistaId",
                        column: x => x.ArtistaId,
                        principalTable: "Artista",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_AlbumArtista_Musica_MusicaId",
                        column: x => x.MusicaId,
                        principalTable: "Musica",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                })
                .Annotation("MySql:CharSet", "utf8mb4");

            migrationBuilder.CreateTable(
                name: "MusicaGenero",
                columns: table => new
                {
                    MusicaId = table.Column<int>(type: "int", nullable: false),
                    GeneroId = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_MusicaGenero", x => new { x.MusicaId, x.GeneroId });
                    table.ForeignKey(
                        name: "FK_MusicaGenero_Genero_GeneroId",
                        column: x => x.GeneroId,
                        principalTable: "Genero",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_MusicaGenero_Musica_MusicaId",
                        column: x => x.MusicaId,
                        principalTable: "Musica",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                })
                .Annotation("MySql:CharSet", "utf8mb4");

            migrationBuilder.CreateTable(
                name: "ComentarioAlbum",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("MySql:ValueGenerationStrategy", MySqlValueGenerationStrategy.IdentityColumn),
                    AlbumId = table.Column<int>(type: "int", nullable: false),
                    UsuarioId = table.Column<string>(type: "varchar(255)", nullable: false)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    DataDePublicacao = table.Column<DateTime>(type: "datetime(6)", maxLength: 1000, nullable: false),
                    Comentario = table.Column<string>(type: "varchar(1000)", maxLength: 1000, nullable: false)
                        .Annotation("MySql:CharSet", "utf8mb4")
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_ComentarioAlbum", x => x.Id);
                    table.ForeignKey(
                        name: "FK_ComentarioAlbum_Album_AlbumId",
                        column: x => x.AlbumId,
                        principalTable: "Album",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_ComentarioAlbum_Usuario_UsuarioId",
                        column: x => x.UsuarioId,
                        principalTable: "Usuario",
                        principalColumn: "UsuarioId",
                        onDelete: ReferentialAction.Cascade);
                })
                .Annotation("MySql:CharSet", "utf8mb4");

            migrationBuilder.CreateTable(
                name: "ComentarioMusica",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("MySql:ValueGenerationStrategy", MySqlValueGenerationStrategy.IdentityColumn),
                    MusicaId = table.Column<int>(type: "int", nullable: false),
                    UsuarioId = table.Column<string>(type: "varchar(255)", nullable: false)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    DataDePublicacao = table.Column<DateTime>(type: "datetime(6)", maxLength: 1000, nullable: false),
                    Comentario = table.Column<string>(type: "varchar(1000)", maxLength: 1000, nullable: false)
                        .Annotation("MySql:CharSet", "utf8mb4")
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_ComentarioMusica", x => x.Id);
                    table.ForeignKey(
                        name: "FK_ComentarioMusica_Musica_MusicaId",
                        column: x => x.MusicaId,
                        principalTable: "Musica",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_ComentarioMusica_Usuario_UsuarioId",
                        column: x => x.UsuarioId,
                        principalTable: "Usuario",
                        principalColumn: "UsuarioId",
                        onDelete: ReferentialAction.Cascade);
                })
                .Annotation("MySql:CharSet", "utf8mb4");

            migrationBuilder.InsertData(
                table: "Album",
                columns: new[] { "Id", "DataDeLancamento", "ExibirHome", "Foto", "Nome", "Titulo" },
                values: new object[,]
                {
                    { 1, new DateTime(2024, 3, 22, 0, 0, 0, 0, DateTimeKind.Unspecified), true, "/img/Albuns/1.png", null, "We Don't Trust You" },
                    { 2, new DateTime(2024, 5, 17, 0, 0, 0, 0, DateTimeKind.Unspecified), true, "/img/Albuns/2.jpg", null, "HIT ME HARD AND SOFT" },
                    { 3, new DateTime(2024, 8, 23, 0, 0, 0, 0, DateTimeKind.Unspecified), true, "/img/Albuns/3.png", null, "Short n'Sweet" },
                    { 4, new DateTime(2024, 1, 12, 0, 0, 0, 0, DateTimeKind.Unspecified), true, "/img/Albuns/4.jpg", null, "American Dream" },
                    { 5, new DateTime(2023, 7, 28, 0, 0, 0, 0, DateTimeKind.Unspecified), false, "/img/Albuns/5.jpg", null, "Utopia" },
                    { 6, new DateTime(2024, 9, 9, 0, 0, 0, 0, DateTimeKind.Unspecified), true, "/img/Albuns/6.jpg", null, "333" },
                    { 7, new DateTime(2024, 7, 10, 0, 0, 0, 0, DateTimeKind.Unspecified), false, "/img/Albuns/7.png", null, "Vagabundo de Luxo" },
                    { 8, new DateTime(2024, 6, 7, 0, 0, 0, 0, DateTimeKind.Unspecified), true, "/img/Albuns/8.jpg", null, "Brat" },
                    { 9, new DateTime(2024, 5, 4, 0, 0, 0, 0, DateTimeKind.Unspecified), false, "/img/Albuns/9.png", null, "Not Like Us" },
                    { 10, new DateTime(2024, 8, 16, 0, 0, 0, 0, DateTimeKind.Unspecified), true, "/img/Albuns/10.jpeg", null, "Die With A Smile" },
                    { 11, new DateTime(2024, 5, 21, 0, 0, 0, 0, DateTimeKind.Unspecified), false, "/img/Albuns/11.png", null, "WOKE UP" },
                    { 12, new DateTime(2024, 5, 3, 0, 0, 0, 0, DateTimeKind.Unspecified), false, "/img/Albuns/12.png", null, "Family Matters" },
                    { 13, new DateTime(2024, 7, 2, 0, 0, 0, 0, DateTimeKind.Unspecified), false, "/img/Albuns/13.png", null, "MTG QUERO VER SE VOCÊ TEM ATITUDE" },
                    { 14, new DateTime(2024, 4, 30, 0, 0, 0, 0, DateTimeKind.Unspecified), false, "/img/Albuns/14.png", null, "Euphoria" },
                    { 15, new DateTime(2024, 9, 27, 0, 0, 0, 0, DateTimeKind.Unspecified), false, "/img/Albuns/15.jpg", null, "Timeless (with Playboi Carti)" },
                    { 16, new DateTime(2024, 4, 26, 0, 0, 0, 0, DateTimeKind.Unspecified), false, "/img/Albuns/16.png", null, "MILLION DOLLAR BABY" },
                    { 17, new DateTime(2024, 6, 21, 0, 0, 0, 0, DateTimeKind.Unspecified), false, "/img/Albuns/17.png", null, "Feelslikeimfallinginlove" },
                    { 18, new DateTime(2024, 3, 8, 0, 0, 0, 0, DateTimeKind.Unspecified), false, "/img/Albuns/18.png", null, "Eternal Sunshine" },
                    { 19, new DateTime(2024, 2, 9, 0, 0, 0, 0, DateTimeKind.Unspecified), false, "/img/Albuns/19.png", null, "Vultures 1" },
                    { 20, new DateTime(2024, 4, 18, 0, 0, 0, 0, DateTimeKind.Unspecified), false, "/img/Albuns/20.png", null, "THE BOX MEDLEY FUNK 2" },
                    { 21, new DateTime(2024, 2, 16, 0, 0, 0, 0, DateTimeKind.Unspecified), false, "/img/Albuns/21.png", null, "2093" },
                    { 22, new DateTime(2024, 10, 28, 0, 0, 0, 0, DateTimeKind.Unspecified), true, "/img/Albuns/22.png", null, "Chromakopia" },
                    { 23, new DateTime(2024, 10, 18, 0, 0, 0, 0, DateTimeKind.Unspecified), false, "/img/Albuns/23.png", null, "Barbie" },
                    { 24, new DateTime(2024, 10, 18, 0, 0, 0, 0, DateTimeKind.Unspecified), false, "/img/Albuns/24.png", null, "APT." },
                    { 25, new DateTime(2007, 10, 7, 0, 0, 0, 0, DateTimeKind.Unspecified), false, "/img/Albuns/25.png", null, "Nada Como um Dia Após o Outro Dia, Vol. 1 & 2" },
                    { 26, new DateTime(2024, 11, 5, 0, 0, 0, 0, DateTimeKind.Unspecified), false, "/img/Albuns/26.png", null, "The Emptiness Machine" }
                });

            migrationBuilder.InsertData(
                table: "Artista",
                columns: new[] { "Id", "Biografia", "DataDeNascimento", "Nome" },
                values: new object[,]
                {
                    { 1, null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "Future, Metro Boomin" },
                    { 2, null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "Billie Eilish" },
                    { 3, null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "Lady Gaga, Bruno Mars" },
                    { 4, null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "Sabrina Carpenter" },
                    { 5, null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "21 Savage" },
                    { 6, null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "Travis Scott" },
                    { 7, null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "Kendrick Lamar" },
                    { 8, null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "Matuê" },
                    { 9, null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "Wiu" },
                    { 10, null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "XG" },
                    { 11, null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "HARDY" },
                    { 12, null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "Linkin Park" },
                    { 13, null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "Charli XCX " },
                    { 14, null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "Dj Luan Gomes" },
                    { 15, null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "Drake" },
                    { 16, null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "Playboi Carti e The Weeknd" },
                    { 17, null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "Tommy Richman" },
                    { 18, null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "Coldplay" },
                    { 19, null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "Ariana Grande" },
                    { 20, null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "Kanye West" },
                    { 21, null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "DJ Oreia, Mc Brinquedo, MC Cebezinho, Mc Laranjinha, MC Tuto e THE BOX" },
                    { 22, null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "Yeat" },
                    { 23, null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "Tyler, The Creator" },
                    { 24, null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "DJ Glenner e MC Tuto" },
                    { 25, null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "Bruno Mars e ROSÉ" },
                    { 26, null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "Racionais MC's" }
                });

            migrationBuilder.InsertData(
                table: "AspNetRoles",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[,]
                {
                    { "0b44ca04-f6b0-4a8f-a953-1f2330d30894", null, "Administrador", "ADMINISTRADOR" },
                    { "bec71b05-8f3d-4849-88bb-0e8d518d2de8", null, "Usuário", "USUÁRIO" },
                    { "ddf093a6-6cb5-4ff7-9a64-83da34aee005", null, "Moderador", "MODERADOR" }
                });

            migrationBuilder.InsertData(
                table: "AspNetUsers",
                columns: new[] { "Id", "AccessFailedCount", "ConcurrencyStamp", "Email", "EmailConfirmed", "LockoutEnabled", "LockoutEnd", "NormalizedEmail", "NormalizedUserName", "PasswordHash", "PhoneNumber", "PhoneNumberConfirmed", "SecurityStamp", "TwoFactorEnabled", "UserName" },
                values: new object[] { "ddf093a6-6cb5-4ff7-9a64-83da34aee005", 0, "f2fff825-fc4c-44c1-8e14-6f384d42c82c", "admin@aboutsongs.com", true, false, null, "ADMIN@ABOUTSONGS.COM", "ADMIN", "AQAAAAIAAYagAAAAEJj3MrN/7B48Coq6sEMTEX5swfenNM5PFE2VBk1lSOxgFo1mofIitWtEIzlVw89gqQ==", null, false, "f10e4f24-bb45-4aa3-b950-5de690ee75fe", false, "Admin" });

            migrationBuilder.InsertData(
                table: "Genero",
                columns: new[] { "Id", "Nome" },
                values: new object[,]
                {
                    { 1, "Pop" },
                    { 2, "Rap/Hip-Hop" },
                    { 3, "Rock" },
                    { 4, "Funk" },
                    { 5, "Eletrônica" }
                });

            migrationBuilder.InsertData(
                table: "Musica",
                columns: new[] { "Id", "AppleMusic", "Compositores", "Duracao", "Foto", "Spotify", "Título", "Youtube" },
                values: new object[,]
                {
                    { 1, "https://music.apple.com/br/album/we-dont-trust-you/1737149923", "Barrett Strong, Christopher Townsend, Dwayne Richardson, Leland Wayne, Mejdi Rhars, Nayvadius Wilburn, Norman Whitfield e Paul Fishman", new TimeSpan(0, 3, 46, 0, 0), null, "https://open.spotify.com/intl-pt/album/2vHRMDYWkdjZLRsLD4l76m", "We Don’t Trust You ", "https://music.youtube.com/watch?v=ntP8vvswhYM&si=M-b2L6_XjMRkJfxm" },
                    { 2, "https://music.apple.com/br/song/ice-attack/1737150153", "Abel Tesfaye, Eren Yüksel, Leland Wayne e Nayvadius Wilburn", new TimeSpan(0, 3, 25, 0, 0), null, "https://open.spotify.com/intl-pt/track/2pt55UXA7ycI7zlTqWoUWp", "Young Metro", "https://music.youtube.com/watch?v=ntP8vvswhYM&list=OLAK5uy_nexYBihVfegVxOxvYnnhlZyTqLDW_wjY8" },
                    { 3, "https://music.apple.com/br/song/ice-attack/1737150153", "Darnell Carlton, Jordan Houston, Leland Wayne, Nayvadius Wilburn, Nik Frascona, Paul Beauregard e Ricky Dunigan", new TimeSpan(0, 3, 19, 0, 0), null, "https://open.spotify.com/intl-pt/track/0ftg9eDVh0t4qEBhdbPld8", "Ice Attack", "https://music.youtube.com/watch?v=ycRKgIDciG4&list=OLAK5uy_nexYBihVfegVxOxvYnnhlZyTqLDW_wjY8" },
                    { 4, "https://music.apple.com/br/song/type-shit/1737150156", "Joe Cooley,Kendrick Lamar Duckworth, Kobe Hood, Leland Wayne, Nayvadius Wilburn e Rodney Oliver", new TimeSpan(0, 3, 48, 0, 0), null, "https://open.spotify.com/intl-pt/track/15dWsK6pH4OAEKD2aUt1aY", "Type Shit", "https://music.youtube.com/watch?v=I0fgkcTbBoI&list=OLAK5uy_nexYBihVfegVxOxvYnnhlZyTqLDW_wjY8" },
                    { 5, "https://music.apple.com/br/song/claustrophobic/1737150164", "Leland Wayne e Nayvadius Wilburn", new TimeSpan(0, 3, 42, 0, 0), null, "https://open.spotify.com/intl-pt/track/2dEnQVj4DqzvaUgWOy33UW", "Claustrophobic", "https://music.youtube.com/watch?v=LP2WmJCaUfU&list=OLAK5uy_nexYBihVfegVxOxvYnnhlZyTqLDW_wjY8" },
                    { 6, "https://open.spotify.com/intl-pt/track/5M2KX4eOJLWlPdjV1UPwzS", "Billie Eilish e Finneas O'Connell", new TimeSpan(0, 4, 27, 0, 0), null, "https://open.spotify.com/intl-pt/track/5M2KX4eOJLWlPdjV1UPwzS", "Like That", "https://music.youtube.com/watch?v=N9bKBAA22Go&list=OLAK5uy_nexYBihVfegVxOxvYnnhlZyTqLDW_wjY8" },
                    { 7, "https://music.apple.com/br/song/slimed-in/1737150442", "Boi-1da, Bobby Raps, Leland Wayne, Nayvadius Wilburn e Shantae Allen", new TimeSpan(0, 3, 14, 0, 0), null, "https://open.spotify.com/intl-pt/track/66lptTO1aTEYHzamQKupjG", "Slimed In", "https://music.youtube.com/watch?v=ZJ0d2c3FOow&list=OLAK5uy_nexYBihVfegVxOxvYnnhlZyTqLDW_wjY8" },
                    { 8, "https://music.apple.com/br/song/magic-don-juan-princess-diana/1737150443", "Boi-1da, Bobby Raps, Leland Wayne, Nayvadius Wilburn e Shantae Allen", new TimeSpan(0, 3, 40, 0, 0), null, "https://open.spotify.com/intl-pt/track/6mT6KW30jV7sz9TFW2G5S1", "Magic Don Juan (Princess Diana)", "https://music.youtube.com/watch?v=MfTFbkKHPGI&list=OLAK5uy_nexYBihVfegVxOxvYnnhlZyTqLDW_wjY8" },
                    { 9, "https://music.apple.com/br/song/cinderella/1737150446", "Allen Ritter, Andre Proctor, Ethan Stevens, Jacques Webster, Leland Wayne e Nayvadius Wilburn", new TimeSpan(0, 2, 49, 0, 0), null, "https://open.spotify.com/intl-pt/track/4xAuVetRNiHvfZYppbTLPF", "Cinderella", "https://music.youtube.com/watch?v=onP2eoO7byc&list=OLAK5uy_nexYBihVfegVxOxvYnnhlZyTqLDW_wjY8" },
                    { 10, "https://music.apple.com/br/song/runnin-outta-time/1737150450", "Bobby Raps, Leland Wayne, Nayvadius Wilburn", new TimeSpan(0, 3, 25, 0, 0), null, "https://open.spotify.com/intl-pt/track/67i0lzzfTYrhxthfxBqYq6", "Runnin Outta Time", "https://music.youtube.com/watch?v=Vv5UuKSBhZg&list=OLAK5uy_nexYBihVfegVxOxvYnnhlZyTqLDW_wjY8" },
                    { 11, "https://music.apple.com/br/song/fried-she-a-vibe/1737150451", "Leland Wayne e Nayvadius Wilburn", new TimeSpan(0, 3, 30, 0, 0), null, "https://open.spotify.com/intl-pt/track/6ucsW32idjJuE6OIUeqsNB", "Fried (She a Vibe)", "https://music.youtube.com/watch?v=0Z8eMHVwFDw&list=OLAK5uy_nexYBihVfegVxOxvYnnhlZyTqLDW_wjY8" },
                    { 12, "https://music.apple.com/br/song/everyday-hustle/1737150458", "Leland Wayne e Nayvadius Wilburn", new TimeSpan(0, 3, 2, 0, 0), null, "https://open.spotify.com/intl-pt/track/6FV9QPuQIhLFCC0EF2hn3c", "Ain’t No Love", "https://music.youtube.com/watch?v=Dat993XlIf0&list=OLAK5uy_nexYBihVfegVxOxvYnnhlZyTqLDW_wjY8" },
                    { 13, "https://music.apple.com/br/song/everyday-hustle/1737150458", "Alfreda Brockington, Leland Wayne, Nayvadius Wilburn e William Leonard Roberts II", new TimeSpan(0, 3, 46, 0, 0), null, "https://open.spotify.com/intl-pt/track/4eRqmUWBmEdnVEEDHu765H", "Everyday Hustle", "https://music.youtube.com/watch?v=cdxE4QtUz-8&list=OLAK5uy_nexYBihVfegVxOxvYnnhlZyTqLDW_wjY8" },
                    { 14, "https://music.apple.com/br/song/gta/1737150460", "Leland Wayne e Nayvadius Wilburn", new TimeSpan(0, 3, 53, 0, 0), null, "https://open.spotify.com/intl-pt/track/7e3fAVgYa6rLAWVZtcXYlN", "GTA", "https://music.youtube.com/watch?v=A8bE-MPs0K0&list=OLAK5uy_nexYBihVfegVxOxvYnnhlZyTqLDW_wjY8" },
                    { 15, "https://music.apple.com/br/song/seen-it-all/1737150465", "Allen Ritter, Leland Wayne e Nayvadius Wilburn", new TimeSpan(0, 2, 59, 0, 0), null, "https://open.spotify.com/intl-pt/track/7e3fAVgYa6rLAWVZtcXYlN", "Seen it All", "https://music.youtube.com/watch?v=NZJGKmGhbwY&list=OLAK5uy_nexYBihVfegVxOxvYnnhlZyTqLDW_wjY8" },
                    { 16, "https://music.apple.com/br/album/we-dont-trust-you/1737149923", "Leland Wayne e Nayvadius Wilburn", new TimeSpan(0, 4, 52, 0, 0), null, "https://open.spotify.com/intl-pt/track/5NJjhW5AtfaMM14pbqAOtn", "WTFYM", "https://music.youtube.com/watch?v=bDgZEPAaXyw&list=OLAK5uy_nexYBihVfegVxOxvYnnhlZyTqLDW_wjY8" },
                    { 17, "https://music.apple.com/br/song/where-my-twin-bonus-track/1737150980", "Leland Wayne e Nayvadius Wilburn", new TimeSpan(0, 2, 2, 0, 0), null, "https://open.spotify.com/intl-pt/track/5Hu9qHhcDlDbXG7EiGYZhR", "Where My Twin @ - Bonus", "https://music.youtube.com/watch?v=jiMDe3U6_5M&list=OLAK5uy_nexYBihVfegVxOxvYnnhlZyTqLDW_wjY8" },
                    { 18, "https://music.apple.com/br/song/skinny/1739659137", "Billie Eilish e Finneas O'Connell", new TimeSpan(0, 3, 39, 0, 0), null, "https://open.spotify.com/intl-pt/track/1CsMKhwEmNnmvHUuO5nryA", "SKINNY", "https://music.youtube.com/watch?v=GcY-5alayP8&list=OLAK5uy_kxB-Qzc9hso0Ipd3TJaDW5n8C8iz39ik0" },
                    { 19, "https://music.apple.com/br/song/lunch/1739659140", "Billie Eilish e Finneas O'Connell", new TimeSpan(0, 2, 59, 0, 0), null, "https://open.spotify.com/intl-pt/track/629DixmZGHc7ILtEntuiWE", "LUNCH", "https://music.youtube.com/watch?v=MB3VkzPdgLA&list=OLAK5uy_kxB-Qzc9hso0Ipd3TJaDW5n8C8iz39ik0" },
                    { 20, "https://music.apple.com/br/song/chihiro/1739659141", "Billie Eilish e Finneas O'Connell", new TimeSpan(0, 5, 3, 0, 0), null, "https://open.spotify.com/intl-pt/track/7BRD7x5pt8Lqa1eGYC4dzj", "CHIHIRO", "https://music.youtube.com/watch?v=BY_XwvKogC8&list=OLAK5uy_kxB-Qzc9hso0Ipd3TJaDW5n8C8iz39ik0" },
                    { 21, "https://music.apple.com/br/song/birds-of-a-feather/1739659142", "Billie Eilish e Finneas O'Connell", new TimeSpan(0, 3, 30, 0, 0), null, "https://open.spotify.com/intl-pt/track/6dOtVTDdiauQNBQEDOtlAB", "BIRDS OF A FEATHER", "https://music.youtube.com/watch?v=BY_XwvKogC8&list=OLAK5uy_kxB-Qzc9hso0Ipd3TJaDW5n8C8iz39ik0" },
                    { 22, "https://music.apple.com/br/song/wildflower/1739659144", "Billie Eilish e Finneas O'Connell", new TimeSpan(0, 4, 21, 0, 0), null, "https://open.spotify.com/intl-pt/track/3QaPy1KgI7nu9FJEQUgn6h", "WILDFLOWER", "https://music.youtube.com/watch?v=IWKyykQBRKo&list=OLAK5uy_kxB-Qzc9hso0Ipd3TJaDW5n8C8iz39ik0" },
                    { 23, "https://music.apple.com/br/song/the-greatest/1739659145", "Billie Eilish e Finneas O'Connell", new TimeSpan(0, 4, 53, 0, 0), null, "https://open.spotify.com/intl-pt/track/6TGd66r0nlPaYm3KIoI7ET", "THE GREATEST", "https://music.youtube.com/watch?v=xozgvccBHk8&list=OLAK5uy_kxB-Qzc9hso0Ipd3TJaDW5n8C8iz39ik0" },
                    { 24, "https://music.apple.com/br/song/lamour-de-ma-vie/1739659149", "Billie Eilish e Finneas O'Connell", new TimeSpan(0, 5, 33, 0, 0), null, "https://open.spotify.com/intl-pt/track/6fPan2saHdFaIHuTSatORv", "L’AMOUR DE MA VIE", "https://music.youtube.com/watch?v=lWzjDk5sJRc&list=OLAK5uy_kxB-Qzc9hso0Ipd3TJaDW5n8C8iz39ik0" },
                    { 25, "https://music.apple.com/br/song/the-diner/1739659150", "Billie Eilish e Finneas O'Connell", new TimeSpan(0, 3, 6, 0, 0), null, "https://open.spotify.com/intl-pt/track/1LLUoftvmTjVNBHZoQyveF", "THE DINER", "https://music.youtube.com/watch?v=UKkObvtycq8&list=OLAK5uy_kxB-Qzc9hso0Ipd3TJaDW5n8C8iz39ik0" },
                    { 26, "https://music.apple.com/br/song/bittersuite/1739659277", "Billie Eilish e Finneas O'Connell", new TimeSpan(0, 4, 58, 0, 0), null, "https://open.spotify.com/intl-pt/track/7DpUoxGSdlDHfqCYj0otzU", "BITTERSUITE", "https://music.youtube.com/watch?v=5qIUoTIHwac&list=OLAK5uy_kxB-Qzc9hso0Ipd3TJaDW5n8C8iz39ik0" },
                    { 27, "https://music.apple.com/br/song/blue/1739659278", "Billie Eilish e Finneas O'Connell", new TimeSpan(0, 5, 43, 0, 0), null, "https://open.spotify.com/intl-pt/track/2prqm9sPLj10B4Wg0wE5x9", "BLUE", "https://music.youtube.com/watch?v=mZqiawnNCQg&list=OLAK5uy_kxB-Qzc9hso0Ipd3TJaDW5n8C8iz39ik0" },
                    { 28, "https://music.apple.com/br/album/die-with-a-smile-single/1762656724", "Andrew Watt,Bruno Mars, Dernst Emile IIJames Faunt, leroy e Lady Gaga", new TimeSpan(0, 4, 11, 0, 0), null, "https://open.spotify.com/intl-pt/track/2plbrEY59IikOBgBGLjaoe", "Die With A Smile", "https://music.youtube.com/watch?v=kPa7bsKwL-c&si=bMVzjSb-hhGRsgQY" },
                    { 29, "https://music.apple.com/br/album/taste/1750307020?i=1750307079", "Amy Allen, Ian Kirkpatrick, John Ryan, Julia Michaels e Sabrina Carpenter", new TimeSpan(0, 2, 37, 0, 0), null, "https://open.spotify.com/intl-pt/track/5G2f63n7IPVPPjfNIGih7Q", "Taste", "https://music.youtube.com/watch?v=KEG7b851Ric&si=KRCelRKdDsTmFNk0" },
                    { 30, "https://music.apple.com/br/album/please-please-please/1750307020?i=1750307080", "Amy Allen, Jack Antonoff e Sabrina Carpenter", new TimeSpan(0, 3, 6, 0, 0), null, "https://open.spotify.com/intl-pt/track/2tHwzyyOLoWSFqYNjeVMzj?si=779dd46eb00c4d29", "Please Please Please", "https://music.youtube.com/watch?v=cF1Na4AIecM&si=Ct5BV2uaRkzQyZJS" },
                    { 31, "https://music.apple.com/br/album/good-graces/1750307020?i=1750307081", "Amy Allen, Julia Michaels, John Ryan, Julian Bunetta e Sabrina Carpenter", new TimeSpan(0, 3, 5, 0, 0), null, "https://open.spotify.com/intl-pt/track/102YUQbYmwdBXS7jwamI90?si=dee78dcff6c1468b", "Good Graces", "https://music.youtube.com/watch?v=alYCYZvB3yo&si=ECxbbLSlQKFR6_gu" },
                    { 32, "https://music.apple.com/br/album/sharpest-tool/1750307020?i=1750307082", "Amy Allen, Jack Antonoff e Sabrina Carpenter", new TimeSpan(0, 3, 38, 0, 0), null, "https://open.spotify.com/intl-pt/track/3iPIDAFybaoyqX7hvAfWkl?si=2a50e66fe6fa42a0", "Sharpest Tool", "https://music.youtube.com/watch?v=TuOwCuECUvM&si=RKdelYesnjvqUz58" },
                    { 33, "https://music.apple.com/br/album/coincidence/1750307020?i=1750307084", "Amy Allen, Ian Kirkpatrick, Julia Michaels, John Ryan e Sabrina Carpenter", new TimeSpan(0, 2, 44, 0, 0), null, "https://open.spotify.com/intl-pt/track/5oIVNm56t6OIf9ZjdEG3ud?si=3ae5c699e46b4b37", "Coincidence", "https://music.youtube.com/watch?v=jbJhdc2zLz0&si=y5jHGgcKgWS2P67-" },
                    { 34, "https://music.apple.com/br/album/bed-chem/1750307020?i=1750307088", "Amy Allen, Ian Kirkpatrick, Julia Michaels, John Ryan e Sabrina Carpenter", new TimeSpan(0, 2, 51, 0, 0), null, "https://open.spotify.com/intl-pt/track/1UHS8Rf6h5Ar3CDWRd3wjF?si=a961cb3290044147", "Bed Chem", "https://music.youtube.com/watch?v=x8VkB8ap_FQ&si=qEX7xZ6fetSszG1j" },
                    { 35, "https://music.apple.com/br/album/espresso/1750307020?i=1750307362", "Amy Allen, Julian Bunetta, Steph Jones e Sabrina Carpenter", new TimeSpan(0, 2, 55, 0, 0), null, "https://open.spotify.com/intl-pt/track/2HRqTpkrJO5ggZyyK6NPWz?si=b6ca528011d24c28", "Espresso", "https://music.youtube.com/watch?v=eVli-tstM5E&si=YR217Xcajos35f3f" },
                    { 36, "https://music.apple.com/br/album/dumb-poetic/1750307020?i=1750307368", "Amy Allen, John Ryan, Julia Michaels e Sabrina Carpenter", new TimeSpan(0, 2, 13, 0, 0), null, "https://open.spotify.com/intl-pt/track/5VhvD0AKRprEaFtPNKGBQR?si=eb1a88a7dd954a2c", "Dumb & Poetic", "https://music.youtube.com/watch?v=moMdJBDCblE&si=Nfz-7Fbs4wdB3tZr" },
                    { 37, "https://music.apple.com/br/album/slim-pickins/1750307020?i=1750307371", "Amy Allen, Jack Antonoff e Sabrina Carpenter", new TimeSpan(0, 2, 32, 0, 0), null, "https://open.spotify.com/intl-pt/track/0XkZmBCCcdMY0EPY8ij6Gb?si=35c4c8d6e63a4a6f", "Slim Pickins", "https://music.youtube.com/watch?v=TmP-d1KQqQo&si=z1AbTQBWUYRXnFF8" },
                    { 38, "https://music.apple.com/br/album/juno/1750307020?i=1750307372", "Amy Allen, John Ryan e Sabrina Carpenter", new TimeSpan(0, 4, 11, 0, 0), null, "https://open.spotify.com/intl-pt/track/21B4gaTWnTkuSh77iWEXdS?si=4dba330e243c4896", "Juno", "https://music.youtube.com/watch?v=1aMCVgRKcP4&si=HZ7SkYc0NnMwKDqM" },
                    { 39, "https://music.apple.com/br/album/lie-to-girls/1750307020?i=1750307375", "Amy Allen, Jack Antonoff e Sabrina Carpenter", new TimeSpan(0, 3, 22, 0, 0), null, "https://open.spotify.com/intl-pt/track/5il0jwWUlvgtIzWvzJi12z?si=ac92528c47f44a13", "Lie To Girls", "https://music.youtube.com/watch?v=xYQT5qx1ROE&si=D7arwfmuEmqCGj-E" },
                    { 40, "https://music.apple.com/br/album/dont-smile/1750307020?i=1750307379", "Amy Allen, John Ryan, Julian Bunetta e Sabrina Carpenter", new TimeSpan(0, 3, 26, 0, 0), null, "https://open.spotify.com/intl-pt/track/09LrGvT9KsACH66RHYMDyR?si=db4eb49cb20f46fc", "Don't Smile", "https://music.youtube.com/watch?v=Ju9X2HMMid4&si=2BIy_n2EDrhuo7eM" },
                    { 41, "https://music.apple.com/br/album/american-dream/1724494274?i=1724494706", "BK Rube, Isaiah Brown, James Owens, Sterling White", new TimeSpan(0, 1, 3, 0, 0), null, "https://open.spotify.com/intl-pt/track/4yreExU3eRNTe2iJz6X6k3?si=f362a1073ea74d90", "american dream", "https://music.youtube.com/watch?v=xH3nqcOA2DA&si=d0GuF0QRkilMEPlV" },
                    { 42, "https://music.apple.com/br/album/all-of-me/1724494274?i=1724494713", "Billie Rae Calvin, Isaiah Brown, Jalen Jackson, Jared Brown, Khaya Gilika, Raphael Oliveira, Shéyaa Bin Abraham-Joseph, Sterling White Jr. e Yakki Davis", new TimeSpan(0, 3, 18, 0, 0), null, "https://open.spotify.com/intl-pt/track/2FoahzOSxJnalPA8aBUme3?si=4dcf0ff36dfc41bf", "all of me", "https://music.youtube.com/watch?v=UpYb4C2--UY&si=SLZyVKaMHj_L5Iqu" },
                    { 43, "https://music.apple.com/br/album/redrum/1724494274?i=1724494724", "London Tyler Holmes, Mateen Kyle Niknam, Shéyaa Bin Abraham-Joseph e Vinícius de Moraes", new TimeSpan(0, 4, 30, 0, 0), null, "https://open.spotify.com/intl-pt/track/52eIcoLUM25zbQupAZYoFh?si=6e6e2de7c6424585", "redrum", "https://music.youtube.com/watch?v=U4mADkt6o-M&si=3Q_fwieZCwEz5AK7" },
                    { 44, "https://music.apple.com/br/album/n-h-i-e/1724494274?i=1724494847", "Anthony Paul Jefferies, Amala Dlamini, Douglas Ford, Jonah Stevens, Kurtis McKenzie, Michael Orabiyi e Shéyaa Bin Abraham-Joseph", new TimeSpan(0, 2, 23, 0, 0), null, "https://open.spotify.com/intl-pt/track/6x9pCndnXEoea0CMcfjs9W?si=77313696de6c4d69", "n.h.i.e", "https://music.youtube.com/watch?v=xDmb610okx0&si=LR6vKS48X8AKKR4n" },
                    { 45, "https://music.apple.com/br/album/sneaky/1724494274?i=1724494853", "Edward Maclin Cooper III e Shéyaa Bin Abraham-Joseph", new TimeSpan(0, 3, 21, 0, 0), null, "https://open.spotify.com/intl-pt/track/2K7sv1mno9PvbXVBpqvSKn?si=ca4fc57f5aa046c5", "sneaky", "https://music.youtube.com/watch?v=gnwBjjXjuH4&si=WL2v7DfHg7SPtkz2" },
                    { 46, "https://music.apple.com/br/album/family-matters/1744684618?i=1744684622", "A. Graham", new TimeSpan(0, 7, 36, 0, 0), null, "https://open.spotify.com/intl-pt/track/1wFFFzJ5EsKbBWZriAcubN?si=db2108699e654142", "Family Matters", "https://music.youtube.com/watch?v=ZkXG3ZrXlbc&si=PxyMmF1rflZ2L1JI" },
                    { 47, "https://music.apple.com/br/album/pop-ur-shit/1724494274?i=1724494854", "Allen Ritter, Jeffery Lamar Williams, Leland Tyler Wayne e Shéyaa Bin Abraham-Joseph", new TimeSpan(0, 3, 13, 0, 0), null, "https://open.spotify.com/intl-pt/track/47yD0e9MCRIB8dgUXPfyW3?si=452a79acf0d14699", "pop ur shit", "https://music.youtube.com/watch?v=GnhJziHDzCg&si=n3DpCY13siLvdWgM" },
                    { 48, "https://music.apple.com/br/album/letter-to-my-brudda/1724494274?i=1724494860", "Kavi Lybarger, Paola Barba, Park Min Geon, Shéyaa Bin Abraham-Joseph, Tchakalla Anthony Romeo, Tyrese McGriff e William Boyette", new TimeSpan(0, 2, 39, 0, 0), null, "https://open.spotify.com/intl-pt/track/5P1z8XwsCStb74emERTx9v?si=89a85f813b8846fe", "letter to my brudda", "https://music.youtube.com/watch?v=jBnzs_UMtGk&si=w3G787ZuJv15PhZT" },
                    { 49, "https://music.apple.com/br/album/dangerous/1724494274?i=1724494865", "Durk Banks, Jahmal Gwin, Jahshua Brown, Leland Tyler Wayne e Shéyaa Bin Abraham-Joseph", new TimeSpan(0, 4, 25, 0, 0), null, "https://open.spotify.com/intl-pt/track/0fyP96TikhD9sM4eKqw5Yp?si=1c60bf3ca1e047a0", "dangerous", "https://music.youtube.com/watch?v=Gy6urUcig5A&si=CayiEMOdzvNBJ5Xt" },
                    { 50, "https://music.apple.com/br/album/n%C3%A9e-nah/1724494274?i=1724494870", "Douglas Ford, Jacques Webster, Leland Tyler Wayne, Malcolm McLaren, Rodney Argent, Shéyaa Bin Abraham-Joseph e William Handy", new TimeSpan(0, 3, 40, 0, 0), null, "https://open.spotify.com/intl-pt/track/2yUzr8Sr6ldG8vmHhZwTnz?si=88ef52cb03f445de", "née-nah", "https://music.youtube.com/watch?v=hSitXYlIqKI&si=buF2LOhcYZmawLRH" },
                    { 51, "https://music.apple.com/br/album/see-the-real/1724494274?i=1724494876", "Dylan Cleary-Krell, Joshua Parker, Jason Cornet, Jocelyn Donald, Jordan Holt-May, Samuel David Jimenez e Shéyaa Bin Abraham-Joseph", new TimeSpan(0, 3, 2, 0, 0), null, "https://open.spotify.com/intl-pt/track/4E64eAph6AYI98ucunrGH8?si=fb8bc79e7f6943a0", "see the real", "https://music.youtube.com/watch?v=InwWpxgt6DE&si=B-BSGVTKu6kQIY1p" },
                    { 52, "https://music.apple.com/br/album/prove-it/1724494274?i=1724495061", "Carl Thompson, Edward Maclin Cooper III, Faith Evans, Isaiah Brown, James Owens,Keith Thomas, Shéyaa Bin Abraham-Joseph, Summer Walker, Tauren kngs Stovall e Tye Beats", new TimeSpan(0, 3, 27, 0, 0), null, "https://open.spotify.com/intl-pt/track/5wttBUDyaHAR5q9fYnN3YF?si=3074cc7786e94921", "prove it", "https://music.youtube.com/watch?v=oa8kjoT-MrM&si=cWMoHjuEPd02CwLU" },
                    { 53, "https://music.apple.com/br/album/shouldve-wore-a-bonnet/1724494274?i=1724495063", "Ronald LaTour, Christopher Wood, Darryl Pearson, Daveon Jackson, David Patino, Donald Earle De Grate Jr Francis Esteban, Joel Hailey, John Julian e Shéyaa Bin Abraham-Joseph", new TimeSpan(0, 3, 6, 0, 0), null, "https://open.spotify.com/intl-pt/track/4Xzq2WibDHR5Eufi21HlEZ?si=24153cc7554b496f", "should've wore a bonnet", "https://music.youtube.com/watch?v=EGJ7lxoRhlA&si=ZgOT4RzZk5MPN7lm" },
                    { 54, "https://music.apple.com/br/album/just-like-me/1724494274?i=1724495068", "Isaac De Boni, Michael Mule, Akeel Henry, Damini Ebunoluwa Ogulu, Jahmal Gwin, Jordon Manswell, Kevin Ekofo, Khadijah Lopez, Kira Huszar, Leland Tyler Wayne, Nevon Sinclair e Shéyaa Bin Abraham-Joseph", new TimeSpan(0, 3, 51, 0, 0), null, "https://open.spotify.com/intl-pt/track/5KI7I4mEtulXcv5VQJaV35?si=2e63f26a441844d8", "just like me", "https://music.youtube.com/watch?v=lgj851mZcfA&si=u60cjiwLuEVSovP5" },
                    { 55, "https://music.apple.com/br/album/red-sky/1724494274?i=1724495070", "4th Pyramid, Carlton Davis Mays, Jr.,Courtney Dwight, John Stephen Sudduth, Shaan Ramaprasad, Shéyaa Bin Abraham-Joseph e Tommy Newport", new TimeSpan(0, 2, 56, 0, 0), null, "https://open.spotify.com/intl-pt/track/4yLyVdEqV790aIXyGif85v?si=f5b4bfcff3604f52", "red sky", "https://music.youtube.com/watch?v=5_-sIkbYd_M&si=KvXwtEY0gvHd7uBM" },
                    { 56, "https://music.apple.com/br/album/dark-days/1724494274?i=1724495073", "Ahmar Bailey, Atia Boggs, JONAS LEE, Kavi Lybarger,Mariah Buckles, Paola Madelaine Barba Amado, Shéyaa Bin Abraham-Joseph, Yakki Davis e Yousef Sameh", new TimeSpan(0, 4, 55, 0, 0), null, "https://open.spotify.com/intl-pt/track/02Cp3VTUWNed8hr69BhKz6?si=7925d9440a6b467f", "dark days", "https://music.youtube.com/watch?v=CiFxS8JaUfM&si=ZX5084H4Jb7neQC8" },
                    { 57, "https://music.apple.com/br/album/not-like-us/1781353928?i=1781353929", "Kendrick LamarRay Charles e Sean Momberger", new TimeSpan(0, 4, 34, 0, 0), null, "https://open.spotify.com/intl-pt/track/6AI3ezQ4o3HUoP6Dhudph3?si=b8dca7f0f8354702", "Not Like Us", "https://music.youtube.com/watch?v=phLb_SoPBlA&si=pqlYAoGqNFjwLXSk" },
                    { 58, "https://music.apple.com/br/album/hyaena/1699712635?i=1699712637", "Mike Dean, Noah Goldstein, Andy Votel, Derek Shulman, Ebony Oshunrinde, Edward Hazel, George Clinton, Jacques Webster, Jahaan Sweet, Kerry Minnear e Ray Shulman", new TimeSpan(0, 3, 42, 0, 0), null, "https://open.spotify.com/intl-pt/track/0hL9gOw6XBWsygEUcVjxEc?si=fd1cf4efcfe345bc", "HYAENA", "https://music.youtube.com/watch?v=N20q-391r48&si=aik_98jTi19G-E35" },
                    { 59, "https://music.apple.com/br/album/thank-god/1699712635?i=1699712638", "Allen Ritter, Ebony Oshunrinde, Finatik(of FNZ), Zac(of FNZ), Isaac Boni, Jacques Webster, Jahmal Gwin, Mark Mbogo, Micheal Mule, Stormi Webster e Ye", new TimeSpan(0, 3, 4, 0, 0), null, "https://open.spotify.com/intl-pt/track/1PH2MDbcBAU094DlgTIND1?si=3b17478bf986451d", "THANK GOD", "https://music.youtube.com/watch?v=UVtTc4zqbxQ&si=UqaAdmHLIggAy48d" },
                    { 60, "https://music.apple.com/br/album/modern-jam-feat-teezo-touchdown/1699712635?i=1699712643", "Mike Dean, Aaron Thomas, Guy-Manuel de Homem, Jacques Webster e Jahaan Sweet", new TimeSpan(0, 4, 15, 0, 0), null, "https://open.spotify.com/intl-pt/track/3KCNiDi9Pza6ZD8FggNoaw?si=87a05d35086b4b1d", "MODERN JAM (feat. Teezo Touchdown)", "https://music.youtube.com/watch?v=g8IvO7OwdaM&si=sHLaSerO7bIgc4OP" },
                    { 61, "https://music.apple.com/br/album/my-eyes/1699712635?i=1699712644", "Josiah Sherman, Wesley Glass,Dua Saleh, Ebony Oshunrinde, Jacques Webster, Joseph Thornalley, Justin Vernon, Phil Cook e Sampha Sisay ", new TimeSpan(0, 4, 11, 0, 0), null, "https://open.spotify.com/intl-pt/track/4kjI1gwQZRKNDkw1nI475M?si=f041f16fa3cb41e6", "MY EYES", "https://music.youtube.com/watch?v=pildU9lK6vM&si=-LbHFPpS4QCGSa1e" },
                    { 62, "https://music.apple.com/br/album/gods-country/1699712635?i=1699712646", "Dez Wright, Samuel Gloade, Jacques Webster e Ye ", new TimeSpan(0, 2, 7, 0, 0), null, "https://open.spotify.com/intl-pt/track/04WxWo7XeVyx22xEsrWRUb?si=34148e061c8942be", "GOD'S COUNTRY", "https://music.youtube.com/watch?v=E9VVEdw5Dng&si=tpz7f-KYteNMrrKN" },
                    { 63, "https://music.apple.com/br/album/sirens/1699712635?i=1699712647", "Josiah Sherman, Noah Goldstein, Psymun, Ebony Oshunrinde, Isaac Mpofu, Jacques Webster, Jahaan Sweet, John Fannon, Keith Kawbe e Evan mast", new TimeSpan(0, 3, 24, 0, 0), null, "https://open.spotify.com/intl-pt/track/7LSpFCvRZZot2AlmkUzy9k?si=3c3b221b2fa146fd", "SIRENS", "https://music.youtube.com/watch?v=6gUiQ8CqLcY&si=u4S6n119zOmBNtqT" },
                    { 64, "https://music.apple.com/br/album/meltdown-feat-drake/1699712635?i=1699712649", "ANDERSON HERNANDEZ, Brytavious Chambers, Coleman, Matthew Samuels, A. Graham, Benjamin Saint Fort e Jacques Webster", new TimeSpan(0, 4, 6, 0, 0), null, "https://open.spotify.com/intl-pt/track/67nepsnrcZkowTxMWigSbb?si=01448f585c8a40d5", "MELTDOWN (feat. Drake)", "https://music.youtube.com/watch?v=LuKm4L9ryB0&si=t9yAnLlfbZd3zePd" },
                    { 65, "https://music.apple.com/br/album/fe-n-feat-playboi-carti/1699712635?i=1699712651", "Jahaan Sweet, Jacques Webster, Jordan Carter e Khadimou Fall", new TimeSpan(0, 3, 11, 0, 0), null, "https://open.spotify.com/intl-pt/track/42VsgItocQwOQC3XWZ8JNA?si=6eb554e558b4426e", "FE!N (feat. Playboi Carti)", "https://music.youtube.com/watch?v=B9synWjqBn8&si=lqdU6AoMhcy5dY3G" },
                    { 66, "https://music.apple.com/br/album/delresto-echoes-feat-beyonc%C3%A9/1699712635?i=1699712652", "Allen Ritter, Chauncey Hollis, MIke Dean, Beyoncé, Jacques Webster, James Blake e Terius Gesteelde-Diamant", new TimeSpan(0, 4, 34, 0, 0), null, "https://open.spotify.com/intl-pt/track/0OEe83mMZ5kaNw5uZQ7ilG?si=c8e91268170245ff", "DELRESTO (ECHOES) (feat. Beyoncé)", "https://music.youtube.com/watch?v=vM34QWOrz4A&si=8KI7cVKZb-88ypMs" },
                    { 67, "https://music.apple.com/br/album/i-know/1699712635?i=1699712653", "Josiah Sherman, Ozan Yildrim, Scotty Coleman, Jacques Webster, Kobe Hood e Terrance George", new TimeSpan(0, 3, 31, 0, 0), null, "https://open.spotify.com/intl-pt/track/6wsqVwoiVH2kde4k4KKAFU?si=9a584bbedb1a49f3", "I KNOW ?", "https://music.youtube.com/watch?v=X7aF3nZOS98&si=2ZBLmlOBdD-s_x8B" },
                    { 68, "https://music.apple.com/br/album/topia-twins-feat-rob49-21-savage/1699712635?i=1699712655", "Dez Wright, Wesley Glass, Cash Esmailian,Douglas Ford, Harry Edwards, Henri Velasco, Jacques Webster, Oliver Rodigan, Robert Thomas e Shéyaa Bin Abraham-Joseph", new TimeSpan(0, 3, 43, 0, 0), null, "https://open.spotify.com/intl-pt/track/0lodMO0qK83vfPiiD7FMEt?si=ff6685695b0f4661", "TOPIA TWINS (feat. Rob49 & 21 Savage)", "https://music.youtube.com/watch?v=BsHcPP9KQdU&si=NoBXPJu5Lcdkk2tv" },
                    { 69, "https://music.apple.com/br/album/circus-maximus-feat-the-weeknd-swae-lee/1699712635?i=1699712656", "Noah Goldstein, Abel Tesfaye, Ebony Oshunrinde, Gary Klebe, Jacques Webster, Jahaan Sweet, Khalif Brown e Mike Dean", new TimeSpan(0, 4, 18, 0, 0), null, "https://open.spotify.com/intl-pt/track/4GL9GMX9t7Qkprvf1YighZ?si=7d37e9b3349c49b2", "CIRCUS MAXIMUS (feat. The Weeknd & Swae Lee)", "https://music.youtube.com/watch?v=BwhRWpHxKdM&si=cYJQ7AFEQBKTdGTM" },
                    { 70, "https://music.apple.com/br/album/parasail-feat-yung-lean-dave-chappelle/1699712635?i=1699712657", "Buddy Ross, Jahaan Sweet, Noah Goldstein, Anthony Ruiz, Dave Bixby, David Chappelle, Jacques Webster, Jonatan Håsted e Joseph Thornalley", new TimeSpan(0, 2, 34, 0, 0), null, "https://open.spotify.com/intl-pt/track/2Q0aElTZQtEUsoiaQfizu6?si=136ad3df1be44995", "PARASAIL (feat. Yung Lean & Dave Chappelle)", "https://music.youtube.com/watch?v=aEiD3UZDmiY&si=DCQTuyv1dsQLVB-s" },
                    { 71, "https://music.apple.com/br/album/skitzo-feat-young-thug/1699712635?i=1699712660", "Dylan Teixeira, Matthew Samuels, Scotty Coleman, Sevn Thomas, Blue Miller, Douglas Ford, Ebony Oshunrinde, India Simpson, Jacques Webster, Jahaan Sweet, Jeffrey Williams, Nami Ondas, Nik Dean, Slim Pharoah e Travis Sayles", new TimeSpan(0, 6, 6, 0, 0), null, "https://open.spotify.com/intl-pt/track/0bkV1iQHSxBaksUqgEkcbc?si=30f1f7458f424794", "SKITZO (feat. Young Thug)", "https://music.youtube.com/watch?v=Zk-4WvSPpac&si=bTYs5izCSgIPdmX-" },
                    { 72, "https://music.apple.com/br/album/lost-forever-feat-westside-gunn/1699712635?i=1699712661", "Alan Maman, Alvin Worthy, Dominic Maker, Douglas Ford, Elliott Baker, Jacques Webster e James Litherland", new TimeSpan(0, 2, 43, 0, 0), null, "https://open.spotify.com/intl-pt/track/7EiUtdeoWcKqLi5ELZCjYf?si=d184061f602f474b", "LOST FOREVER (feat. Westside Gunn)", "https://music.youtube.com/watch?v=AppJbl-wODs&si=E196LCdbPfhommXf" },
                    { 73, "https://music.apple.com/br/album/looove-feat-kid-cudi/1699712635?i=1699712662", "Buddy Ross, Jacques Webster, Pharrell Williams e Scott Mescudi", new TimeSpan(0, 3, 46, 0, 0), null, "https://open.spotify.com/intl-pt/track/0a4SMs889NwP8oWI7Vemle?si=86ab55a806e44995", "LOOOVE (feat. Kid Cudi)", "https://music.youtube.com/watch?v=tPdPgFhdp58&si=a1wpujn9PmhKos6O" },
                    { 74, "https://music.apple.com/br/album/k-pop-feat-bad-bunny-the-weeknd/1699712635?i=1699712663", "Bigram John Zayas, Carlo Montagnese, Jahaan Sweet, Matthew Samuels, Abel Tesfaye, Benito Antonio Martínez Ocasio, Benjamin Saint Fort e Jacques Webster", new TimeSpan(0, 3, 5, 0, 0), null, "https://open.spotify.com/intl-pt/track/4o82J5zr4DFEs9yj5szCVX?si=87917e1dfcfd4892", "K-POP (feat. Bad Bunny & The Weeknd)", "https://music.youtube.com/watch?v=_kS7F4VpJa0&si=YD2f9XolQuM5_Ng8" },
                    { 75, "https://music.apple.com/br/album/telekinesis-feat-sza-future/1699712635?i=1699712664", "Edgar Nabeyin Pandord, Jacques Webster, Jahaan Sweet, Jahmal Gwin, Nayvadius Wilburn, Nima Jahanbin, Paimon Jahanbin, Solana Rowe, Victory Boyd e Ye", new TimeSpan(0, 5, 53, 0, 0), null, "https://open.spotify.com/intl-pt/track/1i9lZvlaDdWDPyXEE95aiq?si=3d84e6abb37e4a9a", "TELEKINESIS (feat. SZA & Future)", "https://music.youtube.com/watch?v=zptRsa1pqsk&si=WVocK7o1SZe3fPZI" },
                    { 76, "https://music.apple.com/br/album/til-further-notice-feat-james-blake-21-savage/1699712635?i=1699712667", "Jacques Webster, James Litherland, Leland Wayne e Shéyaa Bin Abraham-Joseph", new TimeSpan(0, 5, 14, 0, 0), null, "https://open.spotify.com/intl-pt/track/76gcXhY3Zv6wW0BTe9nHJo?si=8c00b0ac3a1d403e", "TIL FURTHER NOTICE (feat. James Blake & 21 Savage)", "https://music.youtube.com/watch?v=zptRsa1pqsk&si=8W45t0fmrNacgXLd" },
                    { 77, "https://music.apple.com/br/song/crack-com-mussilon/1767049265", "Citação: Oceano - Djavan, Djavan e Matuê", new TimeSpan(0, 2, 34, 0, 0), null, "https://open.spotify.com/intl-pt/track/4ssHL7bSnOAE7HjiuLx6Co", "Crack com Mussilon", "https://music.youtube.com/watch?v=zctKiN-okXI&list=OLAK5uy_l1VAkYkb3kDuWpTSAvRplwnLdVCUHT0A" },
                    { 78, "https://music.apple.com/br/song/imagina-essecen%C3%A1rio/1767049268", "Matuê e Veigh", new TimeSpan(0, 2, 35, 0, 0), null, "https://open.spotify.com/intl-pt/track/2fjqfFUq64thFsqfKN01kS", "Imagina esse Cenário", "https://music.youtube.com/watch?v=Leep9KouXMo&list=OLAK5uy_l1V-AkYkb3kDuWpTSAvRplwnLdVCUHT0A" },
                    { 79, "https://music.apple.com/br/album/isso-%C3%A9-s%C3%A9rio/1767049264?i=1767049270", "Brandão85 e Matuê", new TimeSpan(0, 4, 45, 0, 0), null, "https://open.spotify.com/intl-pt/track/3Sa2gVQioE31DcG4nKNDqD", "Isso é Sério", "https://music.youtube.com/watch?v=d-6DzlhlBxA&list=OLAK5uy_l1VAkYkb3kDuWpTSAvRplwnLdVCUHT0A" },
                    { 80, "https://music.apple.com/br/song/1993/1767049273", "Matuê", new TimeSpan(0, 2, 7, 0, 0), null, "https://open.spotify.com/intl-pt/track/6QsHhB0W9GtLF3cI7mUVkQ", "1993", "https://music.youtube.com/watch?v=gyVmdwtvKwg&list=OLAK5uy_l1V-AkYkb3kDuWpTSAvRplwnLdVCUHT0A" },
                    { 81, "https://music.apple.com/br/song/4tal/1767049274", "Matuê e Teto", new TimeSpan(0, 3, 24, 0, 0), null, "https://open.spotify.com/intl-pt/track/6OcZP4rUfuxms2r8Mwx5BQ", "4Tal", "https://music.youtube.com/watch?v=mr_AunTy2pk&list=OLAK5uy_l1VAkYkb3kDuWpTSAvRplwnLdVCUHT0A" },
                    { 82, "https://music.apple.com/br/song/o-som/1767049277", "Matuê", new TimeSpan(0, 5, 12, 0, 0), null, "https://open.spotify.com/intl-pt/track/4v0VOuuaZSQHjnjzkC3cnk", "O Som", "https://music.youtube.com/watch?v=iEb-OKbn-w8&list=OLAK5uy_l1VAkYkb3kDuWpTSAvRplwnLdVCUHT0A" },
                    { 83, "https://music.apple.com/br/song/04am/1767049401", "Matuê", new TimeSpan(0, 3, 19, 0, 0), null, "https://open.spotify.com/intl-pt/track/2fTTmjyF7pfarDBAbsJkvb", "04AM", "https://music.youtube.com/watch?v=-bYNcpEBY9E&list=OLAK5uy_l1VAkYkb3kDuWpTSAvRplwnLdVCUHT0A" },
                    { 84, "https://music.apple.com/br/song/castlevania/1767049403", "Matuê", new TimeSpan(0, 3, 50, 0, 0), null, "https://open.spotify.com/intl-pt/track/3Kh5a6vXMiJtC35jMEfmyy", "Castlevania", "https://music.youtube.com/watch?v=A4FRq2QK6mw&list=OLAK5uy_l1V-AkYkb3kDuWpTSAvRplwnLdVCUHT0A" },
                    { 85, "https://music.apple.com/br/song/v-de-vil%C3%A3o/1767049407", "Matuê", new TimeSpan(0, 2, 26, 0, 0), null, "https://open.spotify.com/intl-pt/track/7pMfMzfYSTbNxj5lJEbQIp", "V de Vilão", "https://music.youtube.com/watch?v=QGSdmEsv4G0&list=OLAK5uy_l1V-AkYkb3kDuWpTSAvRplwnLdVCUHT0A" },
                    { 86, "https://music.apple.com/br/song/maria/1767049408", "Matuê", new TimeSpan(0, 3, 24, 0, 0), null, "https://open.spotify.com/intl-pt/track/2ux3Sb90r5aA74nLMls1u0", "Maria", "https://music.youtube.com/watch?v=-x2cE--r3L8&list=OLAK5uy_l1VAkYkb3kDuWpTSAvRplwnLdVCUHT0A" },
                    { 87, "https://music.apple.com/br/song/333/1767049409", "Matuê", new TimeSpan(0, 5, 24, 0, 0), null, "https://open.spotify.com/intl-pt/track/0qsKefQyXCzaxjHbOcd8IU", "333", "https://music.youtube.com/watch?v=aq-DH4iwviE&list=OLAK5uy_l1VAkYkb3kDuWpTSAvRplwnLdVCUHT0A" },
                    { 88, "https://music.apple.com/br/song/like-this/1767049410", "Matuê", new TimeSpan(0, 3, 28, 0, 0), null, "https://open.spotify.com/intl-pt/track/49gGZLLm1d7fBFQkTqskXo", "Like This!", "https://music.youtube.com/watch?v=0zamf27iJ1E&list=OLAK5uy_l1VAkYkb3kDuWpTSAvRplwnLdVCUHT0A" },
                    { 89, "https://music.apple.com/br/album/medo-de-quem/1755821257?i=1755821259", "msahlholdt, RUXN e WIU", new TimeSpan(0, 2, 54, 0, 0), null, "https://open.spotify.com/intl-pt/track/5EKCczncKlpSmDoP074cVF?si=bd980e97ceac47ee", "Medo de Quem?", "https://music.youtube.com/watch?v=O1AD591l-3Y&si=P7pgSsJLLsCgz6zn" },
                    { 90, "https://music.apple.com/br/album/casa-do-tio-wiu/1755821257?i=1755821262", "WIU", new TimeSpan(0, 3, 2, 0, 0), null, "https://open.spotify.com/intl-pt/track/2umpEVeKbYxx1Qx2Dy1mcz?si=528997fb07824862", "Casa do Tio Wiu", "https://music.youtube.com/watch?v=MXf6fcSLUyU&si=Wth2jKGkGXM5-jZV" },
                    { 91, "https://music.apple.com/br/album/rainha-da-finesse/1755821257?i=1755821263", "WIU", new TimeSpan(0, 2, 46, 0, 0), null, "https://open.spotify.com/intl-pt/track/0w7vodPWFEcuEYvWpbNbOu?si=2468dd3b313248b4", "Rainha da Finesse", "https://music.youtube.com/watch?v=dC6NPbqJV6k&si=8x-hIFTVccdbi0DM" },
                    { 92, "https://music.apple.com/br/album/vidigal/1755821257?i=1755821267", "BlueFire, WIU e Yako", new TimeSpan(0, 3, 17, 0, 0), null, "https://open.spotify.com/intl-pt/track/42XLOKRo2bv2Ne9lTOGSQA?si=ecaff77709804ed1", "Vidigal", "https://music.youtube.com/watch?v=Zpe-s1ROP50&si=ZrHEDo6FYvZfaGi6" },
                    { 93, "https://music.apple.com/br/album/amor-de-1h/1755821257?i=1755821268", "WIU", new TimeSpan(0, 3, 28, 0, 0), null, "https://open.spotify.com/intl-pt/track/688p6uyAS8MBxWSfExaXx5?si=738ed23c7c5c4ea9", "Amor de 1h", "https://music.youtube.com/watch?v=cy6K9SLa8h4&si=INI3F5VjNeWx0jwX" },
                    { 94, "https://music.apple.com/br/album/se-eu-ver-sua-m%C3%A3e-na-rua/1755821257?i=1755821419", "Saint Blunts e WIU", new TimeSpan(0, 3, 2, 0, 0), null, "https://open.spotify.com/intl-pt/track/2ifEk0oT5FYOLIsvjvdxIK?si=c9b26407581e42ff", "Se eu ver sua mãe na rua", "https://music.youtube.com/watch?v=7Jv-PLTy6WA&si=6wDTEWgCa01GQKYs" },
                    { 95, "https://music.apple.com/br/album/desgra%C3%A7adagostosamaldita/1755821257?i=1755821420", "Desro, Dragzi, Moras e WIU", new TimeSpan(0, 3, 0, 0, 0), null, "https://open.spotify.com/intl-pt/track/1Goev6cA7GPslY2CdxXzDG?si=ae19d108602a43dc", "desgraçadagostosamaldita", "https://music.youtube.com/watch?v=9p4M9Jc8CT8&si=Mlsmuamsf4w4jGqz" },
                    { 96, "https://music.apple.com/br/album/teimosa/1755821257?i=1755821421", "AK On De Beat, Stoneraider e WIU", new TimeSpan(0, 3, 3, 0, 0), null, "https://open.spotify.com/intl-pt/track/3FcxqTlyvhCNH0j3gxWy8u?si=8176ba72b1704bbd", "Teimosa", "https://music.youtube.com/watch?v=1_djuKtQHG8&si=zSxrN9mx6j-4yP1D" },
                    { 97, "https://music.apple.com/br/album/olha-oq-ce-fez-comigo/1755821257?i=1755821424", "WIU", new TimeSpan(0, 3, 28, 0, 0), null, "https://open.spotify.com/intl-pt/track/5SD6Hqq4oI64KSfAyEUrRV?si=578747aa05a84359", "Olha oq ce fez comigo", "https://music.youtube.com/watch?v=iNOyX10Nqgc&si=p5LZRSmjwishroCK" },
                    { 98, "https://music.apple.com/br/album/guala/1755821257?i=1755821427", "INQBOI BEATZ e WIU", new TimeSpan(0, 3, 2, 0, 0), null, "https://open.spotify.com/intl-pt/track/5emXCWhIK8qnUJeB2CCcIl?si=827631d0c804414a", "Guala", "https://music.youtube.com/watch?v=plRxytI9hvo&si=Ug2SPfeA-0Ja0g90" },
                    { 99, "https://music.apple.com/br/album/maria-do-olho-verde/1755821257?i=1755821428", "RRareBear e WIU", new TimeSpan(0, 3, 24, 0, 0), null, "https://open.spotify.com/intl-pt/track/6c5AQO3llPWxeAK4b3cAut?si=74599532ff394d8e", "Maria do Olho Verde", "https://music.youtube.com/watch?v=cD0tBkCG9AI&si=j4FbxZ-CipsGJUKB" },
                    { 100, "https://music.apple.com/br/album/eu-n%C3%A3o-ou%C3%A7o-mais-trap/1755821257?i=1755821430", "Cheek, Hulls e WIU", new TimeSpan(0, 3, 16, 0, 0), null, "https://open.spotify.com/intl-pt/track/54mhCPc4XuWiv7aaFBqTAk?si=246db7ec7ccc434b", "Eu Não Ouço Mais Trap", "https://music.youtube.com/watch?v=z5R9JzNpvPc&si=zmF2DvFPtPgnb5CT" },
                    { 101, "https://music.apple.com/br/album/rol%C3%AA-de-sempre/1755821257?i=1755821431", "WIU", new TimeSpan(0, 5, 32, 0, 0), null, "https://open.spotify.com/intl-pt/track/1IA7U01tZDZmMarnf9QIa4?si=ec68be502f2b4ff8", "Rolê de Sempre", "https://music.youtube.com/watch?v=bDOVDVgEJl4&si=d8VtI4W051y6ZWDI" },
                    { 102, "https://music.apple.com/br/album/euphoria/1744024729?i=1744024751", "Cardo, Kenneth Gamble, Jordan Houston, Kendrick Lamar, Leon Huff e Paul Beauregard", new TimeSpan(0, 6, 23, 0, 0), null, "https://open.spotify.com/intl-pt/track/77DRzu7ERs0TX3roZcre7Q?si=1dc67c5f16d0400e", "Euphoria", "https://music.youtube.com/watch?v=fAqa1ozCuj8&si=cHwY_Lb-Ps-q9GKU" },
                    { 103, "https://music.apple.com/br/album/woke-up-single/1742262122", "Chancellor´, JAEYOUNG, JAKOPS, LYRICKS e Shintaro Yasuda", new TimeSpan(0, 3, 8, 0, 0), null, "https://open.spotify.com/intl-pt/album/2e9eizo3Euh2aaBef2B2bw?highlight=spotify:track:4keuUM29CtIWgsPRzRhXoW", "WOKE UP", "https://music.youtube.com/watch?v=Q06IepqwpVc&si=IfuwwE3G4tEb-wsU" },
                    { 104, null, "Luan Gabriel", new TimeSpan(0, 1, 57, 0, 0), null, "https://open.spotify.com/intl-pt/track/4PDw1XpsurgUnN7YSZmh1Q?si=f03b26626a09443f", "MTG QUERO VER SE VOCÊ TEM ATITUDE", "https://music.youtube.com/watch?v=Ahr9n7xjNDg&si=sGTIz79UMzLfrHwa" },
                    { 105, "https://music.apple.com/br/album/timeless-single/1770380869", "Abel Tesfaye, Blessed, Devon Chisolm (Lawson), Jarrod Morgan, Jordan Terrell Carter, Kobe Hood, Mark Williams (Oji), MIKE DEAN, Pharrell Williams, Raul Cubina (Volta) e Tariq Sharrieff", new TimeSpan(0, 4, 16, 0, 0), null, "https://open.spotify.com/intl-pt/track/1Es7AUAhQvapIcoh3qMKDL?si=880329414f5e4c39", "Timeless (with Playboi Carti)", "https://music.youtube.com/watch?v=JpOgr4s3GrE&si=_ZvEAyaAQGwdQ-90" },
                    { 106, "https://music.apple.com/br/album/360/1739079974?i=1739079976", "Alexander Guy Cook, Blake Slatkin, Charlotte Aitchison, Finn Keane, Henry Walter e Omer Fedi", new TimeSpan(0, 2, 13, 0, 0), null, "https://open.spotify.com/intl-pt/track/4w2GLmK2wnioVnb5CPQeex?si=304419c971634e60 ", "360", "https://music.youtube.com/watch?v=nI6GP8wKJ6o&si=ge1eCroEQEv4gDlL" },
                    { 107, "https://music.apple.com/br/album/club-classics/1739079974?i=1739080339", "A.G.Cook, Charlotte Aitchison e George Daniel", new TimeSpan(0, 2, 33, 0, 0), null, "https://open.spotify.com/intl-pt/track/0CySZwyRJ0vyUqtSjM9i2k?si=c47c9971ed94424c", "Club classics", "https://music.youtube.com/watch?v=bg9EmWTRt3Y&si=KLHrSIaMskTlI9zT" },
                    { 108, "https://music.apple.com/br/album/sympathy-is-a-knife/1739079974?i=1739080343", "Charlotte Aitchison, Finn Keane e Jonathan Christopher Shave", new TimeSpan(0, 2, 31, 0, 0), null, "https://open.spotify.com/intl-pt/track/5c9tBmJKbTdn1vhzXHeAwW?si=ada15865e96a4196", "Sympathy is a knife", "https://music.youtube.com/watch?v=EFdiM0f2FWE&si=nZliM-HO_1iJS92V" },
                    { 109, "https://music.apple.com/br/album/i-might-say-something-stupid/1739079974?i=1739080345", "Charlotte Aitchison e Mike Levy", new TimeSpan(0, 1, 49, 0, 0), null, "https://open.spotify.com/intl-pt/track/0PFZCt7UNmpas24HejQGu8?si=1971006689074161", "I might isay something stupid", "https://music.youtube.com/watch?v=TD2j1OuHoik&si=AV-16SwXdgQugKVz" },
                    { 110, "https://music.apple.com/br/album/talk-talk/1739079974?i=1739080348", "Alexander Guy Cook, Charlotte Aitchison e Ross Matthew Birchard", new TimeSpan(0, 2, 41, 0, 0), null, "https://open.spotify.com/intl-pt/track/62fqMvguJbsSs9HKhhRfuS?si=9c0182c60f9343af", "Talk talk", "https://music.youtube.com/watch?v=pIs46LzZUws&si=h6eQ04HjF07lfvdY" },
                    { 111, "https://music.apple.com/br/album/von-dutch/1739079974?i=1739080354", "Charlotte Aitchison e Finn Keane", new TimeSpan(0, 2, 44, 0, 0), null, "https://open.spotify.com/intl-pt/track/3Y1EvIgEVw51XtgNEgpz5c?si=f5410f920d4b4102", "Von dutch", "https://music.youtube.com/watch?v=cwZ1L_0QLjw&si=qOEkJQwF_KG1FYZk" },
                    { 112, "https://music.apple.com/br/album/everything-is-romantic/1739079974?i=1739080358", "A.G.Cook, Charlotte Aitchison, Jasper Harris, Jae Deal, Marlon Travis Barrow e Pablo Diaz-Reixa", new TimeSpan(0, 3, 23, 0, 0), null, "https://open.spotify.com/intl-pt/track/5sMEEjviCkH6Rp5X2ZvIIc?si=61fdf4b6b61548cc", "Everything is romantic", "https://music.youtube.com/watch?v=FTIvFD7TCVg&si=KTAEgxCSbkVMI3W6" },
                    { 113, "https://music.apple.com/br/album/rewind/1739079974?i=1739080366", "Alexander Guy Cook, Charlotte Aitchison, e Henry Walter", new TimeSpan(0, 2, 48, 0, 0), null, "https://open.spotify.com/intl-pt/track/50GxvQA2KEWNt31EdwIlzY?si=2059e6a0bdea47b5", "Rewind", "https://music.youtube.com/watch?v=WlM7nm3TLnY&si=N2OMJ-ZdPZGmgifB" },
                    { 114, "https://music.apple.com/br/album/so-i/1739079974?i=1739080637", "Charlotte Aitchison, Finn Keane e Jonathan Christopher Shave", new TimeSpan(0, 3, 31, 0, 0), null, "https://open.spotify.com/intl-pt/track/0AkiAfilrTUXV49dleC5SB?si=fe4deb019dc941b9", "So I", "https://music.youtube.com/watch?v=r9k1CR4LBjk&si=TyR8oMOXtDo2vg1J" },
                    { 115, "https://music.apple.com/br/album/girl-so-confusing/1739079974?i=1739080642", "Alexander Guy Cook e Charlotte Aitchison", new TimeSpan(0, 2, 54, 0, 0), null, "https://open.spotify.com/intl-pt/track/41krZZovstMJKeJZJtbL78?si=5dd90ceb33284137", "Girl, so confusing", "https://music.youtube.com/watch?v=QXKvjyoH5lM&si=iO9eEHkRUTsGocNk" },
                    { 116, "https://music.apple.com/br/album/apple/1739079974?i=1739080645", "Charlotte Aitchison, Linus Wiklund, Noonie Bao e George", new TimeSpan(0, 2, 31, 0, 0), null, "https://open.spotify.com/intl-pt/track/19RybK6XDbAVpcdxSbZL1o?si=872e3df52a854914", "Apple", "https://music.youtube.com/watch?v=CPWxExGk7PM&si=bLpquEdjse8ivk_3" },
                    { 117, "https://music.apple.com/br/album/b2b/1739079974?i=1739080650", "Alexander Guy Cook, Charlotte Aitchison, Omer Fedi e Mike Levy", new TimeSpan(0, 2, 58, 0, 0), null, "https://open.spotify.com/intl-pt/track/4wTvw1dBiPXNiHTh0zzpcI?si=b793d2254c6542a7", "B2b", "https://music.youtube.com/watch?v=If4-ckGcr0c&si=bK1QagE7EYx9Rcx4" },
                    { 118, "https://music.apple.com/br/album/mean-girls/1739079974?i=1739080652", "Alexander Guy Cook, Charlotte Aitchison e Ross Matthew Birchard", new TimeSpan(0, 3, 9, 0, 0), null, "https://open.spotify.com/intl-pt/track/1qKCO2Tocwg8CbepJ9uDtd?si=badd5edde12f4db5", "Mean girls", "https://music.youtube.com/watch?v=IKUQDMEBXN0&si=A_DCSuIiYNpM-p-A" },
                    { 119, "https://music.apple.com/br/album/i-think-about-it-all-the-time/1739079974?i=1739080653", "Alexander Guy Cook, Charlotte Aitchison, Finn Keane e Jonathan Christopher Shave", new TimeSpan(0, 2, 15, 0, 0), null, "https://open.spotify.com/intl-pt/track/3OaFGqHUyxGVkOcSILw8Kx?si=f58dd756b3154952", "I think about it all the time", "https://music.youtube.com/watch?v=Mn0aho8Ayfk&si=V-fdhPAxEUZ9YhPh" },
                    { 120, "https://music.apple.com/br/album/365/1739079974?i=1739080656", "Alexander Guy Cook, Blake Slatkin, Charlotte Aitchison, Cirkut, Finn Keane (EasyFun) e Omer Fedi", new TimeSpan(0, 3, 23, 0, 0), null, "https://open.spotify.com/intl-pt/track/5h68SoVFGleijCtjEja3xG?si=2c866d204c6e466a", "365", "https://music.youtube.com/watch?v=Ol9CCM240Ag&si=XgTSu7paaDBFS2gK" },
                    { 121, "https://music.apple.com/br/album/the-emptiness-machine/1766137049?i=1766137051", "Linkin Park", new TimeSpan(0, 3, 10, 0, 0), null, "https://open.spotify.com/intl-pt/track/2PnlsTsOTLE5jnBnNe2K0A?si=4e0b25da6b25415b", "The Emptiness Machine", "https://music.youtube.com/watch?v=KBV_zpMm_0Q&si=amcNs3gO9fxshGrO" },
                    { 122, "https://music.apple.com/br/album/million-dollar-baby/1749616853?i=1749616863", "Ava La'RaeTommy Richman", new TimeSpan(0, 2, 35, 0, 0), null, "https://open.spotify.com/intl-pt/track/5AJ9hqTS2wcFQCELCFRO7A?si=b3438597a14a49e9", "MILLION DOLLAR BABY", "https://music.youtube.com/watch?v=LF2LGaCsMbc&si=Jhw2LoK82XEMCbEX" },
                    { 123, "https://music.apple.com/br/album/feelslikeimfallinginlove/1751728791?i=1751728802", "Max Martin, Apple Martin, Chris Martin, Guy Berryman, Jon Hopkins, Jonny Buckland, Oscar Holter, Tim Rutili e Will Champion", new TimeSpan(0, 3, 57, 0, 0), null, "https://open.spotify.com/intl-pt/track/49S3znqBAQyPyMpEuKeyJ6?si=875946f59e014c90", "Feelslikeimfallinginlove", "https://music.youtube.com/watch?v=mG5jXd3MlE0&si=yMwWYbEQLsCfMoIk" },
                    { 124, "https://music.apple.com/br/album/intro-end-of-the-world/1725877944?i=1725877946", "Ariana Grande, Nick Lee, Shintaro Yasuda e Aaron Cheung", new TimeSpan(0, 1, 32, 0, 0), null, "https://open.spotify.com/intl-pt/track/2o1pb13quMReXZqE7jWsgq?si=4374e14482564ae2", "Intro (end of the world)", "https://music.youtube.com/watch?v=p7jATa6Soag&si=D7-rTk3pplkgsRqt" },
                    { 125, "https://music.apple.com/br/album/bye/1725877944?i=1725877947", "Ariana Grande, LLya Salamanzadeh e Max Martin", new TimeSpan(0, 2, 44, 0, 0), null, "https://open.spotify.com/intl-pt/track/1Rweq7vNjK4kZBbGrmxQsl?si=b19329ca14c74f2c", "bye", "https://music.youtube.com/watch?v=PlaiDnJyabE&si=64c5X_3TLskiFmXw" },
                    { 126, "https://music.apple.com/br/album/dont-wanna-break-up-again/1725877944?i=1725877948", "Ariana Grande, LLya Salamanzadeh e Max Martin", new TimeSpan(0, 2, 54, 0, 0), null, "https://open.spotify.com/intl-pt/track/0o3ua5ufFK7nfRzbDUNoGA?si=fe78b91da3024d30", "don't wanna break up again", "https://music.youtube.com/watch?v=_ZSuyl3BZHY&si=YQt6HGyMNVi2tktS" },
                    { 127, "https://music.apple.com/br/album/saturn-returns-interlude/1725877944?i=1725877958", "Ariana Grande, LLya Salamanzadeh e Max Martin", new TimeSpan(0, 0, 42, 0, 0), null, "https://open.spotify.com/intl-pt/track/13jRSCLoWbCoU1XEdJRbgn?si=c8def65641074f94", "Saturn Returns Interlude", "https://music.youtube.com/watch?v=f68Og1FPFfw&si=d4LPkT0E2_h-wWmN" },
                    { 128, "https://music.apple.com/br/album/eternal-sunshine/1725877944?i=1725877964", "Ariana Grande, Max Martin, Shintaro Yasuda e DaviDior", new TimeSpan(0, 3, 30, 0, 0), null, "https://open.spotify.com/intl-pt/track/3RwWW7KeVhHGayYJgUL5eZ?si=32acb57d292f4bc8", "eternal sunshine", "https://music.youtube.com/watch?v=dS_HLHozs1E&si=t9lFD0pCSviunMeB" },
                    { 129, "https://music.apple.com/br/album/supernatural/1725877944?i=1725877965", "Ariana Grande, Max Martin e Oscar Görres", new TimeSpan(0, 2, 43, 0, 0), null, "https://open.spotify.com/intl-pt/track/142PiXzA84lmEw2RstFHFa?si=b0945fa7a0244d9a", "supernatural", "https://music.youtube.com/watch?v=4bwnO0FQp1s&si=pJgDjA2-b1lg4HIS" },
                    { 130, "https://music.apple.com/br/album/true-story/1725877944?i=1725878238", "Ariana Grande e Max Martin", new TimeSpan(0, 2, 43, 0, 0), null, "https://open.spotify.com/intl-pt/track/14kyXBpg91RVq8bNRDS1q2?si=e33bfabbd7d1460b", "true story", "https://music.youtube.com/watch?v=sZTugkGSxSg&si=HCSx7OUHLBnD__XQ" },
                    { 131, "https://music.apple.com/br/album/the-boy-is-mine/1725877944?i=1725878239", "Ariana Grande, Max Martin, Shintaro Yasuda e DaviDior", new TimeSpan(0, 2, 53, 0, 0), null, "https://open.spotify.com/intl-pt/track/0Lmbke3KNVFXtoH2mMSHCw?si=8fc0516c3e8546ed", "the boy is mine", "https://music.youtube.com/watch?v=KwRxeZ9Ro24&si=sjrN78C-uv1Kac_s" },
                    { 132, "https://music.apple.com/br/album/yes-and/1725877944?i=1725878240", "Ariana Grande, LLya Salamanzadeh e Max Martin", new TimeSpan(0, 3, 34, 0, 0), null, "https://open.spotify.com/intl-pt/track/5D34wRmbFS29AjtTOP2QJe?si=b7294dfd89fa42d5", "yes, and?", "https://music.youtube.com/watch?v=eB6txyhHFG4&si=AtSKx75D9cXOtKvd" },
                    { 133, "https://music.apple.com/br/album/we-cant-be-friends-wait-for-your-love/1725877944?i=1725878242", "Ariana Grande, LLya Salamanzadeh e Max Martin", new TimeSpan(0, 3, 48, 0, 0), null, "https://open.spotify.com/intl-pt/track/51ZQ1vr10ffzbwIjDCwqm4?si=8e3431c973bc49d7", "we can't be friends (wait for your love)", "https://music.youtube.com/watch?v=KNtJGQkC-WI&si=_XZcfDVk2eNPknZe" },
                    { 134, "https://music.apple.com/br/album/i-wish-i-hated-you/1725877944?i=1725878245", "Ariana Grande e LLya Salamanzadeh", new TimeSpan(0, 2, 33, 0, 0), null, "https://open.spotify.com/intl-pt/track/5cQX9BexkPIEESTZijJhXg?si=f26b2bc6b2b94dc4", "i wish i hated you", "https://music.youtube.com/watch?v=T5k2-0yRzKc&si=arzgZRNiUA-v-H2x" },
                    { 135, "https://music.apple.com/br/album/imperfect-for-you/1725877944?i=1725878247", "Ariana Grande, LLya Salamanzadeh, Max Martin e Peter Kahm", new TimeSpan(0, 3, 2, 0, 0), null, "https://open.spotify.com/intl-pt/track/6XXKB32Om6WuXg3uEWwTob?si=ab7add9bcfd646ff", "imperfect for you", "https://music.youtube.com/watch?v=VtQorLzzbQw&si=Ae7IxhrhTw2LJLzP" },
                    { 136, "https://music.apple.com/br/album/ordinary-things-feat-nonna/1725877944?i=1725878248", "Ariana Grande, Nick Lee, Luka Kloser e Nonna", new TimeSpan(0, 2, 48, 0, 0), null, "https://open.spotify.com/intl-pt/track/4mHM5d2fK3n8xgymjf92w2?si=a1bf604ddb3f4a88", "ordinary things (feat. Nonna)", "https://music.youtube.com/watch?v=6XWMiMlZHfA&si=fcUbIQgEq8Fc2OZp" },
                    { 137, "https://music.apple.com/br/album/stars/1732096585?i=1732096589", "Lucien Parker,Barringington D. Hendricks, Billy Ray Schlag, Darhyl Camper Jr., Isaac De Boni, Michael Mule, Quentin Miller, Samuel C. Lindley, Tyrone Griffin, Jr. e Ye", new TimeSpan(0, 1, 55, 0, 0), null, "https://open.spotify.com/intl-pt/track/1LaTWJ35Atk7Esoqxdb1WG?si=22fb62a7df514fcf", "STARS", "https://music.youtube.com/watch?v=j1BkA7KXV3c&si=QJcF30jQGeFCxvL2" },
                    { 138, "https://music.apple.com/br/album/keys-to-my-life/1732096585?i=1732096602", "Cydel C. Young, Hubert E. Polinski, Konrad Żyrek, Samuel C. Lindley, Tim Mosley, Ty Dolla $ign, Veyis-Can Urun, Vincent Vendi e Ye", new TimeSpan(0, 2, 54, 0, 0), null, "https://open.spotify.com/intl-pt/track/7oPlYYNWDSEQRDb978Bhhc?si=e3c4597993e34afc", "KEYS TO MY LIFE", "https://music.youtube.com/watch?v=kX3ivxNp9PY&si=p94mtlap1V6mQ5iP" },
                    { 139, "https://music.apple.com/br/album/paid/1732096585?i=1732096927", "Chrishan, Anthony Kilhoffer, Cedric R Hailey, Christopher C. Dotson, Hamid Bashir, Louis K. Celestin, Samuel C. LindleyTyrone Griffin, Jr. e Ye", new TimeSpan(0, 3, 15, 0, 0), null, "https://open.spotify.com/intl-pt/track/2uK5bMcng3sT2tv0BOyhCt?si=5040bbb44a494ae9", "PAID", "https://music.youtube.com/watch?v=oG1xb5KOcN4&si=Gu8HzGL7e6x1kEdi" },
                    { 140, "https://music.apple.com/br/album/talking/1732096585?i=1732097210", "Anthony Clemons Jr, Darhyl Camper Jr., Dominic Maker, Edward Davadi, James B. Litherland, Kasseem D. Dean, North West, Quentin Miller, Shawntoni A. Nichols, Tyrone Griffin, Jr. e Ye", new TimeSpan(0, 3, 5, 0, 0), null, "https://open.spotify.com/intl-pt/track/3cPz4AkNOXwDf4DlWmKmIE?si=2b7231910abd41fa", "TALKING", "https://music.youtube.com/watch?v=Tqlw87XV4kU&si=4nHKH-sRJ1Yj7WpJ" },
                    { 141, "https://music.apple.com/br/album/back-to-me/1732096585?i=1732097229", "Aswad Asif, Charles M. Njapa, Daniel Kin J. Chien, Frederick Tipton, James A. Hau, Nicholas M. Balding, Sasha Hashemi, Tyrone Griffin, Jr., Ye e Zachary R. Frenes", new TimeSpan(0, 4, 55, 0, 0), null, "https://open.spotify.com/intl-pt/track/5d4XWuMLbTuPMTPaMYA0VG?si=c6068e0319cb4707", "BACK TO ME", "https://music.youtube.com/watch?v=MiTIhSb-b2k&si=e1E4kHtSU2bHKGnY" },
                    { 142, "https://music.apple.com/br/album/hoodrat/1732096585?i=1732097780", "Charles M. Njapa, Darhyl Camper Jr., Malik Y. Jones, Robert G. Booker, Tyrone Griffin, Jr. e Ye", new TimeSpan(0, 3, 42, 0, 0), null, "https://open.spotify.com/intl-pt/track/5FlpNdFCZfcrtV6HcAg9Rx?si=14d61eb84b0b43fe", "HOODRAT", "https://music.youtube.com/watch?v=eHHwQMxvVOU&si=nHNRhYPjcsBzLxqy" },
                    { 143, "https://music.apple.com/br/album/do-it/1732096585?i=1732097972", "Chrishan, Alexander West, Billy Ray Schlag, Darhyl Camper Jr., Denis Raab, Dijon I. McFarlane, Ermias J. Asghedom, Keenon Dequan R. Jackson, Kevin Gomringer, Lukas Benjamin Leth Kroll, Samuel C. Lindley, Supreme Williams, Tim Gomringer, Tyrone Griffin, Jr. e Ye", new TimeSpan(0, 3, 45, 0, 0), null, "https://open.spotify.com/intl-pt/track/5iroQL70VoSFrC8ZhVnskA?si=91b801d494d442aa", "DO IT", "https://music.youtube.com/watch?v=G0hxhn7-Hps&si=UFaZzy6f_DaoiE6Q" },
                    { 144, "https://music.apple.com/br/album/paperwork/1732096585?i=1732098149", "ADERLI RAMIREZ OVIEDO, Bruno Gioia Martins Funke Da Costa, Charles M. Njapa, Kasseem D. Dean, Leonardo Felipe Yasmil Garces, Nasir H. Pemberton, Quavious Keyate Marshall, Samuel C. Lindley, Ty Dolla $ign, Tyrone Griffin, Jr. e Victor Hugo Maciel dos Santos", new TimeSpan(0, 2, 25, 0, 0), null, "https://open.spotify.com/intl-pt/track/4QrJxzBxuIWWW0NxA6FRNF?si=8571179049d74e0e", "PAPERWORK", "https://music.youtube.com/watch?v=FmrXYkfv2eU&si=5_ooPr4toBJ08ccl" },
                    { 145, "https://music.apple.com/br/album/burn/1732096585?i=1732098274", "Amir Stivie B, Christopher C. Dotson, John Beck, Joseph Goddard, Leon Thomas, Morten Ristorp, Samuel C. Lindley, Tyrone Griffin, Jr., Tyshane Thompson, Valentina Pappalardo e Ye", new TimeSpan(0, 1, 51, 0, 0), null, "https://open.spotify.com/intl-pt/track/38BgRP0EX5p0sBj0fFhqN9?si=7e91c8bbcfad4f75", "BURN", "https://music.youtube.com/watch?v=oAbX14IadBo&si=HnrVjugcjbur-Fuz" },
                    { 146, "https://music.apple.com/br/album/fuk-sumn/1732096585?i=1732098446", "Chrishan, Barringington D. Hendricks, Christopher C. Dotson, Evan K. Hood-Atlas, Jacques B. Webster II, Jordan T. Carter, Quavious Keyate Marshall, Quentin Miller, Samuel C. Lindley, Tim Mosley, Tyrone Griffin, Jr. e Ye", new TimeSpan(0, 3, 29, 0, 0), null, "https://open.spotify.com/intl-pt/track/4eIYnlcgI2chjQBuW1VRr7?si=ec536947ed2e47f7", "FUK SUMN", "https://music.youtube.com/watch?v=xd2SEKy6HIM&si=eRW1RTw63Vfc59WL" },
                    { 147, "https://music.apple.com/br/album/vultures/1732096585?i=1732098460", "Jasper Harris, Mark Williams, Cydel C. Young, Durk D. Banks, Gustave Rudman Rambali, Jason T. Harris, Jordan Houston, Marlon T. Barrow, Mathias D. Liyew, Paul Beauregard, Pharris Thomas, Raul I. Cubina, Terrace M. Boykin, Tyrone Griffin, Jr. e Ye ", new TimeSpan(0, 4, 36, 0, 0), null, "https://open.spotify.com/intl-pt/track/0Cz12ejDQ5L1c1f4sVck4n?si=796bf14c24014f42", "VULTURES", "https://music.youtube.com/watch?v=kCMz7HW6O-g&si=q2HirAxnrr2i8hus" },
                    { 148, "https://music.apple.com/br/album/carnival-feat-playboi-carti/1732096585?i=1732098695", "Mark Williams, Raul Cubina(of Ojivolta), Dimitri Rogers, Grant Dickinson, Jordan T. Carter, Raul I. Cubina, Samuel C. Lindley, Tyrone Griffin, Jr. e Ye", new TimeSpan(0, 4, 24, 0, 0), null, "https://open.spotify.com/intl-pt/track/4OssqCixV2Xsxd43wMIQyS?si=ae9a6ec5cef04764", "CARNIVAL", "https://music.youtube.com/watch?v=pEskP0ulPlA&si=YAVfefsckULF308S" },
                    { 149, "https://music.apple.com/br/album/beg-forgiveness/1732096585?i=1732098706", "Barrington D. Hendricks, Faouzia Ouihya, John Beck, Joseph Goddard, Latia T. Lindley, London T. Holmes, Quentin Miller, Tyrone Griffin, Jr., Valentina Pappalardo e Ye", new TimeSpan(0, 6, 8, 0, 0), null, "https://open.spotify.com/intl-pt/track/6hMzSNx3vrFu3y27lnEDWE?si=1b0247569f434bf2", "BEG FORGIVENESS", "https://music.youtube.com/watch?v=EXmMiBNDVz4&si=EBT-1QiZlBCbDIVS" },
                    { 150, "https://music.apple.com/br/album/problematic/1732096585?i=1732099023", "Camper, Amber D. Streeter, Charles E. Hugo, Charles M. Njapa, Denzel A. Charles, Melvin Moore, Tyrone Griffin, Jr. e Ye", new TimeSpan(0, 3, 14, 0, 0), null, "https://open.spotify.com/intl-pt/track/1zO4yPBdlaRSLko5BY33od?si=4c4af39dfa5848da", "PROBLEMATIC", "https://music.youtube.com/watch?v=xcprkHw4cd8&si=QeRtrihJH0YqNE1p" },
                    { 151, "https://music.apple.com/br/album/king/1732096585?i=1732099368", "Arturo Fratini, Barringington D. Hendricks, Charles M. Njapa, Dylan T. Cleary-Krell, Frederick Tipton, Tyrone Griffin, Jr., Victor Mensah e Ye", new TimeSpan(0, 2, 36, 0, 0), null, "https://open.spotify.com/intl-pt/track/3nmtzobpqStsxsfRNykwFC?si=e0db7d8749f544b4", "KING", "https://music.youtube.com/watch?v=g6vAQpxo35g&si=u8HDaW3Z1EISRbdK" },
                    { 152, "https://music.apple.com/br/album/the-box-medley-funk-2/1740221242?i=1740221258", "Mc Brinquedo, MC Cebezinho, Mc Laranjinha e MC Tuto", new TimeSpan(0, 4, 26, 0, 0), null, "https://open.spotify.com/intl-pt/track/7IFsTX5H1sWcEl8joV0IdD?si=dbd352ce7f3749c8", "THE BOX MEDLEY FUNK 2", "https://music.youtube.com/watch?v=ZRcA5aH0Wto&si=XYJ0RcMHdJ5Oq349" },
                    { 153, "https://music.apple.com/br/album/psycho-ceo/1731490449?i=1731490455", "Abdul Moiz, George Kala, Michael Ojha e Noah Smith", new TimeSpan(0, 3, 45, 0, 0), null, "https://open.spotify.com/intl-pt/track/2dyAiC9k6s0mWnMSQRQJGd?si=a33dec0a4fdb47b9", "Psycho CEO", "https://music.youtube.com/watch?v=mJgpzJpodk8&si=dW6JlWC8E1vtMCdf" },
                    { 154, "https://music.apple.com/br/album/power-trip/1731490449?i=1731490456", "Aaron Shadrow, Jasper Harris, Tom Levesque, Anton Martin Mendo, Arman Andican, Donald Glover, Noah Smith, Oscar Adler e Thomas Levesque", new TimeSpan(0, 4, 24, 0, 0), null, "https://open.spotify.com/intl-pt/track/3bDH7eIQ84QWdBeWwffUZD?si=38916b289c4a4e79", "Power Trip", "https://music.youtube.com/watch?v=cVEa5o9W77U&si=MJPG1QO23kl-BxXs" },
                    { 155, "https://music.apple.com/br/album/breathe/1731490449?i=1731490577", "Anton Martin Mendo, Bart van Hoewijk e Noah Smith", new TimeSpan(0, 2, 50, 0, 0), null, "https://open.spotify.com/intl-pt/track/5NAOhPAZ57eFAXr3qatS6i?si=6968dbda934c483c", "Breathe", "https://music.youtube.com/watch?v=zWaVz9m3S_k&si=0eCNdWEqgIezqEQt" },
                    { 156, "https://music.apple.com/br/album/mor%C3%AB/1731490449?i=1731490578", "Daniel Pérez, Javier Mercado e Noah Smith", new TimeSpan(0, 2, 45, 0, 0), null, "https://open.spotify.com/intl-pt/track/7KdQOqCspznOjPDT0KAnuq?si=2f132730a72b439f", "Morë", "https://music.youtube.com/watch?v=L4U1ByXfHGo&si=uxTZP653wwf88Q4Q" },
                    { 157, "https://music.apple.com/br/album/bought-the-earth/1731490449?i=1731490579", "Aaron Cheung, Carlton McDowell Jr, Charlie Coffeen, Noah Smith e Rex Masamune Kudo", new TimeSpan(0, 2, 58, 0, 0), null, "https://open.spotify.com/intl-pt/track/5Bno6wFa22tRbFUwh4iZdk?si=ce79ad844f46409d", "Bought The Earth", "https://music.youtube.com/watch?v=NuZoznmvo88&si=n6OBRFm2kDEO_3ZW" },
                    { 158, "https://music.apple.com/br/album/nothing-chang%C3%AB/1731490449?i=1731490583", "Cooper Coad, George Kala e Noah Smith", new TimeSpan(0, 3, 57, 0, 0), null, "https://open.spotify.com/intl-pt/track/3rLjenWhYQNFGI1xrvTHWy?si=5757612570db4d7e", "Nothing Changë", "https://music.youtube.com/watch?v=8yTPJ15dSz4&si=MEoIvCkHC2VRXDww" },
                    { 159, "https://music.apple.com/br/album/u-should-know/1731490449?i=1731490590", "Abdul Moiz, Neile Ode e Noah Smith", new TimeSpan(0, 3, 6, 0, 0), null, "https://open.spotify.com/intl-pt/track/17vVm6v7GE2tP2KRVbCwqv?si=d72f7dc05c744298", "U Should Know", "https://music.youtube.com/watch?v=H9lmz6dFhi8&si=5UAQHEEhdp4mM_Mt" },
                    { 160, "https://music.apple.com/br/album/lyfestyl%C3%AB/1731490449?i=1731490593", "Javier Mercado, Joey Fenderson, Noah Smith e Salah Nizami", new TimeSpan(0, 3, 56, 0, 0), null, "https://open.spotify.com/intl-pt/track/15qRV1yUqFR6ViOwxoopod?si=137f05bf6d624d5d", "Lyfestylë (with Lil Wayne)", "https://music.youtube.com/watch?v=uRWvjctfhqo&si=G-yHsv0XOmd52OxF" },
                    { 161, "https://music.apple.com/br/album/iluv/1731490449?i=1731490594", "Edith Frances, Ethan Kath, Javier Mercado, Noah Smith e Rio Leyva", new TimeSpan(0, 3, 3, 0, 0), null, "https://open.spotify.com/intl-pt/track/30ln1OwxEZdXDfEploBcsU?si=f40ff35e01d840af", "ILUV", "https://music.youtube.com/watch?v=dMC9SZH-HrU&si=x8F9uqNqAutOMuuB" },
                    { 162, "https://music.apple.com/br/album/tell-m%C3%AB/1731490449?i=1731490595", "Cyrus Spurlock, Gabriel St-Onge, Javier Mercado, Louis Esposito, Noah Smith e Spencer Mott", new TimeSpan(0, 4, 3, 0, 0), null, "https://open.spotify.com/intl-pt/track/1ObrUCFugAMJoXcvpggbOd?si=862ba6ef4208451d", "Tell më", "https://music.youtube.com/watch?v=f8JEilGmNUM&si=B6MFteNQJVKnwIAV" },
                    { 163, "https://music.apple.com/br/album/shade/1731490449?i=1731490596", "Christian Boggs, Daniel Mohammadi, Francesca Boszormenyi, Javier Mercado, Joy Evangeline Moreno, Louis Esposito, Nathan Andrew Chen e Noah Smith", new TimeSpan(0, 4, 2, 0, 0), null, "https://open.spotify.com/intl-pt/track/3vpocwyn0RvKzeXo1tzSrW?si=e06f5884a0d04800", "Shade", "https://music.youtube.com/watch?v=1sXnH2l0Pfw&si=e7zB9G7QEa-6T6Ap" },
                    { 164, "https://music.apple.com/br/album/keep-pushin/1731490449?i=1731490601", "Abdul Moiz, Anton Martin Mendo, Neile Ode, Noah Smith e Tobias Dekker", new TimeSpan(0, 2, 46, 0, 0), null, "https://open.spotify.com/intl-pt/track/49wkg1xBo56T3oSa778RWA?si=1bc0195014784d15", "Keep Pushin", "https://music.youtube.com/watch?v=biHsQTXavBs&si=hnCsp_xZ0J5cCn5l" },
                    { 165, "https://music.apple.com/br/album/riot-set-it-off/1731490449?i=1731490602", "Anton Martin Mendo, Clint Mansell e Noah Smith", new TimeSpan(0, 2, 38, 0, 0), null, "https://open.spotify.com/intl-pt/track/2qzkFJtbIFrGpOctOBeCbi?si=7bfbe9843ffc4635", "Riot & Set it off", "https://music.youtube.com/watch?v=n28xgaiXy8g&si=2dUBlYuTVUesOyPc" },
                    { 166, "https://music.apple.com/br/album/team-ceo/1731490449?i=1731490604", "Anton Martin Mendo, Noah Smith, Sam Lawalata e Tobias Dekker", new TimeSpan(0, 3, 17, 0, 0), null, "https://open.spotify.com/intl-pt/track/0D01toUYF9V47nYuzov5BZ?si=ded582ea7a8e492e", "Team ceo", "https://music.youtube.com/watch?v=2ZGMuOuE6Fc&si=1P_rxXEPbw8uqN-p" },
                    { 167, "https://music.apple.com/br/album/2093/1731490449?i=1731490605", "Anton Martin Mendo, Arman Andican, Ethan Andrade, Noah Smith e Oscar Adler", new TimeSpan(0, 2, 24, 0, 0), null, "https://open.spotify.com/intl-pt/track/3si9GTRnTpVGI1UIysHtrC?si=3e91bf8d569441dd", "2093", "https://music.youtube.com/watch?v=NNUbwA-oS1c&si=QP7i5E7IimMLwwQ3" },
                    { 168, "https://music.apple.com/br/album/stand-on-it/1731490449?i=1731490606", "George Kala, Nayvadius Wilburn e Noah Smith", new TimeSpan(0, 3, 0, 0, 0), null, "https://open.spotify.com/intl-pt/track/7H3lr9bsPBGFx5NyTuBBGc?si=abf787df56da4bb8", "Stand On It (with Future)", "https://music.youtube.com/watch?v=Mnw4LnbU8hQ&si=AZRE1iVDjMxcom-C" },
                    { 169, "https://music.apple.com/br/album/familia/1731490449?i=1731490817", "Benjamin Saint Fort, Abdul Moiz, Cyrus Spurlock e Noah Smith", new TimeSpan(0, 2, 34, 0, 0), null, "https://open.spotify.com/intl-pt/track/2OM0MeY7mPIRbs8SCzRdTH?si=2aa77c4e08324b8d", "Familia", "https://music.youtube.com/watch?v=Ye02TykznWI&si=IGf_wnnVABMWOlyd" },
                    { 170, "https://music.apple.com/br/album/mr-inbetweenit/1731490449?i=1731490818", "Matthew Shalnev, Nikita Zvorygin e Noah Smith", new TimeSpan(0, 3, 18, 0, 0), null, "https://open.spotify.com/intl-pt/track/0S4xIJdaXd30Y7Lqe5WQws?si=57b812dfa6e246ce", "Mr. Inbetweenit", "https://music.youtube.com/watch?v=e02uqFGuiJA&si=SeiV8lHSsSCfLGql" },
                    { 171, "https://music.apple.com/br/album/psychocain%C3%AB/1731490449?i=1731490819", "Abdul Moiz, Michael Ojha,Noah Smith e Oscar Vidal", new TimeSpan(0, 2, 46, 0, 0), null, "https://open.spotify.com/intl-pt/track/3xGMKrKN8DdLltEfA17ivN?si=aaba553dd14240c2", "Psychocainë", "https://music.youtube.com/watch?v=VfkDWye904A&si=2MClzoX2YHWIjdQy" },
                    { 172, "https://music.apple.com/br/album/run-th%C3%ABy-mouth/1731490449?i=1731490820", "George Kala, Noah Smith e Oscar Vidal", new TimeSpan(0, 3, 26, 0, 0), null, "https://open.spotify.com/intl-pt/track/6Y9LODoptY2RDhLJtZXAG7?si=39ca64e7405746c3", "Run Thëy Mouth", "https://music.youtube.com/watch?v=p_sNK5qZir4&si=rNx0i95Bgi2ZYgEi" },
                    { 173, "https://music.apple.com/br/album/if-we-being-r%C3%ABal/1731490449?i=1731490822", "Eric Kjell Jowett, Gabriel St-Onge, Javier Mercado, Joey Fenderson, Louis Esposito, Noah Smith e Spencer Mott", new TimeSpan(0, 2, 52, 0, 0), null, "https://open.spotify.com/intl-pt/track/0YThXX1dqUpYBLyJNAsF9N?si=82d0573bfdf649e5", "If We Being Rëal", "https://music.youtube.com/watch?v=1xcvWmN0Pe4&si=u4VM7ygf_5nny3_W" },
                    { 174, "https://music.apple.com/br/album/1093/1731490449?i=1731490824", "Aaron Shadrow, Benjamin Bock, Noah Smith e Rex Masamune Kudo", new TimeSpan(0, 2, 36, 0, 0), null, "https://open.spotify.com/intl-pt/track/4ueAQTrrK9U3gx1VubzdcD?si=e55b5e7125984074", "1093", "https://music.youtube.com/watch?v=Q_YqjsDZRFk&si=_QORzzvSxOzieo1Z" },
                    { 175, "https://music.apple.com/br/album/st-chroma-feat-daniel-caesar/1776500452?i=1776500453", "Ashton Dumar Simmonds e Tyler Okonma", new TimeSpan(0, 3, 17, 0, 0), null, "https://open.spotify.com/intl-pt/track/1QoyuMHNBe7lg3YW4Qtll4?si=98a8898576d4436a", "St. Chroma (feat. Daniel Caesar)", "https://music.youtube.com/watch?v=hCcwCv3G1FQ&si=tXIXoE0u-mQcbmXx" },
                    { 176, "https://music.apple.com/br/album/rah-tah-tah/1776500452?i=1776500454", "Tyler Okonma", new TimeSpan(0, 2, 45, 0, 0), null, "https://open.spotify.com/intl-pt/track/5RePVWy39tLpHH0WwXgBsK?si=8e403a9c400f45ba", "Rah Tah Tah", "https://music.youtube.com/watch?v=R_clisSImS4&si=-fj8lWF5j2_iOiR0" },
                    { 177, "https://music.apple.com/br/album/noid/1776500452?i=1776500455", "Paul Dobson Nyirongo e Tyler Okonma", new TimeSpan(0, 4, 44, 0, 0), null, "https://open.spotify.com/intl-pt/track/1YdtGoSYDvVQKoUqSDXX41?si=b896b5f548924285", "Noid", "https://music.youtube.com/watch?v=Qer3lwd5hyA&si=nsF3qTxgb_lJdqNO" },
                    { 178, "https://music.apple.com/br/album/darling-i-feat-teezo-touchdown/1776500452?i=1776500456", "Barry White, Kamaal Ibn John Fareed e Tyler Okonma", new TimeSpan(0, 4, 13, 0, 0), null, "https://open.spotify.com/intl-pt/track/0VaeksJaXy5R1nvcTMh3Xk?si=448d803d41e94079", "Darling, I (feat. Teezo Touchdown)", "https://music.youtube.com/watch?v=ZWDoUsxpkKE&si=i7oDOuvRlvho3wZp" },
                    { 179, "https://music.apple.com/br/album/hey-jane/1776500452?i=1776500457", "Tyler Okonma", new TimeSpan(0, 4, 0, 0, 0), null, "https://open.spotify.com/intl-pt/track/3Umj02ZNl4d356pS1D38mn?si=66f86cfd705542ad", "Hey Jane", "https://music.youtube.com/watch?v=qFfjnPOXmUM&si=FKujOBnHZmq3iH8w" },
                    { 180, "https://music.apple.com/br/album/i-killed-you/1776500452?i=1776500458", "Tyler Okonma", new TimeSpan(0, 2, 48, 0, 0), null, "https://open.spotify.com/intl-pt/track/3GdwjAsCsoE79ObhsJFyYb?si=9c7b1cb2cdc441e2", "I Killed You", "https://music.youtube.com/watch?v=bKTmpKPjJxs&si=9OeobLDbzk27gd10" },
                    { 181, "https://music.apple.com/br/album/judge-judy/1776500452?i=1776500459", "Tyler Okonma", new TimeSpan(0, 4, 29, 0, 0), null, "https://open.spotify.com/intl-pt/track/6ie0uyyvOKTTuIFBMPiNIl?si=29b0e9ffba9a417b", "Judge Judy", "https://music.youtube.com/watch?v=FQUI8KmRUw0&si=Mf2MHlr6nuqK94N-" },
                    { 182, "https://music.apple.com/br/album/sticky-feat-glorilla-sexyy-red-lil-wayne/1776500452?i=1776500460", "Aaron Bolton, David Darnell Brown, Dudley Alexander Duverne, Dwyane Carter, Jr., Elvis L. Jr. Williams, Gloria Woods, Jamal F Jones, Janae Wherry, Rex Zamor, Tim Mosley, Timothy clayton, Tyler Okonma e Zachary Anson Wallace", new TimeSpan(0, 4, 15, 0, 0), null, "https://open.spotify.com/intl-pt/track/3tFed7YsjGnIfxeLEQwx3R?si=ee53712adbf347b6", "Sticky (feat. GloRilla, Sexyy Red & Lil Wayne)", "https://music.youtube.com/watch?v=16KSivdIGjQ&si=VzRo3NkIah_-IxS0" },
                    { 183, "https://music.apple.com/br/album/take-your-mask-off-feat-daniel-caesar-latoiya-williams/1776500452?i=1776500462", "Greg Cook, K. Thomas e Tyler Okonma", new TimeSpan(0, 4, 13, 0, 0), null, "https://open.spotify.com/intl-pt/track/4BSR9I4ExlCJdXJo2GpBD5?si=5a9f26477a664f84", "Take Your Mask Off (feat. Daniel Caesar & LaToiya Williams)", "https://music.youtube.com/watch?v=JPOjiXoPmOk&si=xrxpK24OV7YkNOzj" },
                    { 184, "https://music.apple.com/br/album/tomorrow/1776500452?i=1776500463", "Ashton Dumar Simmonds e Tyler Okonma", new TimeSpan(0, 3, 2, 0, 0), null, "https://open.spotify.com/intl-pt/track/3yw3m8wgRB4ptDyAvtdhq5?si=696ce821c3d74e4d", "Tomorrow", "https://music.youtube.com/watch?v=n2KOgQJbZAw&si=fmns2mOlVSnLhVrW" },
                    { 185, "https://music.apple.com/br/album/thought-i-was-dead-feat-schoolboy-q-santigold/1776500452?i=1776500464", "Quincy Hanley e Tyler Okonma", new TimeSpan(0, 3, 27, 0, 0), null, "https://open.spotify.com/intl-pt/track/2aYHxnMF2umAavtgBvmkY1?si=b9d5d0360b694ac9", "Thought I Was Dead (feat. ScHoolboy Q & Santigold)", "https://music.youtube.com/watch?v=HS1OUFCfFdY&si=jgeUBqL_J94IISxe" },
                    { 186, "https://music.apple.com/br/album/like-him-feat-lola-young/1776500452?i=1776500465", "Tyler Okonma", new TimeSpan(0, 4, 38, 0, 0), null, "https://open.spotify.com/intl-pt/track/6jbYpRPTEFl1HFKHk1IC0m?si=b078f08e8ee1437a", "Like Him (feat. Lola Young)", "https://music.youtube.com/watch?v=dgUHE8wWhiE&si=onANzdP8S1Zcg8E_" },
                    { 187, "https://music.apple.com/br/album/balloon-feat-doechii/1776500452?i=1776500466", "Harry Wayne Casey, James Brown, Jaylah Hickmon, Luther Campbell, Rick Finch, Robert Ginyard e Tyler Okonma", new TimeSpan(0, 4, 29, 0, 0), null, "https://open.spotify.com/intl-pt/track/35D1RA5uVFVhMc1qX80TaQ?si=6ad6caa61f5a4b39", "Balloon (feat. Doechii)", "https://music.youtube.com/watch?v=eZNxD4NbxLA&si=nyre0TlPAQovIFhh" },
                    { 188, "https://music.apple.com/br/album/barbie/1774463235?i=1774463237", "Emerson Teixeira Muniz e Glenner Robert Cândido", new TimeSpan(0, 3, 12, 0, 0), null, "https://open.spotify.com/intl-pt/track/6s1kzj4EbhFLXbuAGJbhbn?si=8ce7f820135746df", "Barbie", "https://music.youtube.com/watch?v=4t7au8Tm9xY&si=4JDPe0rNykqFWdqI" },
                    { 189, "https://music.apple.com/br/album/apt/1773452219?i=1773452221", "Amy Allen, Bruno Mars, Chae Young Park, Christopher Brody Brown, Henry Walter, Michael Chapman, Nicholas Chinn, Omer Fedi, Philip Lawrence, Rogét Chahayed e Theron Thomas", new TimeSpan(0, 2, 49, 0, 0), null, "https://open.spotify.com/intl-pt/track/5vNRhkKd0yEAg8suGBpjeY?si=2ac95c59109944e6", "APT.", "https://music.youtube.com/watch?v=58-AKkNMZNQ&si=h8WaQTEorxCsFRP-" },
                    { 190, "https://music.apple.com/br/album/sou-voc%C3%AA/1198317040?i=1198317073", "Caetano Veloso e Mano Brown", new TimeSpan(0, 1, 48, 0, 0), null, "https://open.spotify.com/intl-pt/track/5G1T3Cj4vP7uiGMUb278ut?si=e3e3f28f397d4787", "Sou + Você", "https://music.youtube.com/watch?v=TB5gzXCAx7o&si=NoTmImmFRsWvyq3_" },
                    { 191, "https://music.apple.com/br/album/viv%C3%A3o-e-vivendo/1198317040?i=1198317074", "Mano Brown", new TimeSpan(0, 1, 57, 0, 0), null, "https://open.spotify.com/intl-pt/track/2igfCmo0TuciHyKMB8zWrr?si=8e944ca5c4ff45ac", "Vivão e Vivendo", "https://music.youtube.com/watch?v=wnkougMAqog&si=blIGPj5ieViMGThx" },
                    { 192, "https://music.apple.com/br/album/vida-loka-intro/1198317040?i=1198317075", "Mano Brown", new TimeSpan(0, 0, 24, 0, 0), null, "https://open.spotify.com/intl-pt/track/7ATfKy3NYMRfK5JZvFQJYX?si=8e69f06f7b1d4a52", "Vida Loka (Intro)", "https://music.youtube.com/watch?v=mnhX41tvuUU&si=-XUUKBHYLj8beWkF" },
                    { 193, "https://music.apple.com/br/album/vida-loka-pt-1/1198317040?i=1198317076", "Mano Brown", new TimeSpan(0, 5, 3, 0, 0), null, "https://open.spotify.com/intl-pt/track/6m8AgjfI28ER6odzMxmHtR?si=04abde4ef81e45c7", "Vida Loka, Pt. 1", "https://music.youtube.com/watch?v=IL1epaZCTmk&si=-nw1u-Q6Z5kk1grD" },
                    { 194, "https://music.apple.com/br/album/negro-drama/1198317040?i=1198317077", "Mano Brown", new TimeSpan(0, 6, 51, 0, 0), null, "https://open.spotify.com/intl-pt/track/3ytXzEJFeVydFfmUhHvti8?si=49ba04f17c6a44bb", "Negro Drama", "https://music.youtube.com/watch?v=u4lcUooNNLY&si=RKuecvXNwdW6pJas" },
                    { 195, "https://music.apple.com/br/album/a-v%C3%ADtima/1198317040?i=1198317078", "Mano Brown", new TimeSpan(0, 7, 20, 0, 0), null, "https://open.spotify.com/intl-pt/track/2ki0ZW9m5HIAdALRldfXM1?si=890dc6add925447d", "A Vítima", "https://music.youtube.com/watch?v=Hr2Kn6CozzY&si=XnBW5vZj2z7OgIVS" },
                    { 196, "https://music.apple.com/br/album/na-f%C3%A9-firm%C3%A3o/1198317040?i=1198317079", "Mano Brown", new TimeSpan(0, 6, 5, 0, 0), null, "https://open.spotify.com/intl-pt/track/0TYKO6toBeKLbyD18AVTNU?si=44ae992d5d094d98", "Na Fé Firmão", "https://music.youtube.com/watch?v=3Qjrtsg5HXo&si=n1ScgQKzIRZU7xbZ" },
                    { 197, "https://music.apple.com/br/album/12-de-outubro/1198317040?i=1198317080", "Mano Brown", new TimeSpan(0, 3, 30, 0, 0), null, "https://open.spotify.com/intl-pt/track/4Nqj9K6kxvIr4PnvtI1RRA?si=79ea86d595ac4e84", "12 de Outubro", "https://music.youtube.com/watch?v=b6XO9GGQDqw&si=m_cteFipo47DyWxl" },
                    { 198, "https://music.apple.com/br/album/eu-sou-157/1198317040?i=1198317081", "Mano Brown", new TimeSpan(0, 8, 49, 0, 0), null, "https://open.spotify.com/intl-pt/track/33UECsx4DcDRampb2ah316?si=02f3f8f8415d4e0a", "Eu Sou 157", "https://music.youtube.com/watch?v=fgysUhl98As&si=Ayvo-g0jwcsvhbI4" },
                    { 199, "https://music.apple.com/br/album/a-vida-%C3%A9-desafio/1198317040?i=1198317082", "Mano Brown", new TimeSpan(0, 7, 13, 0, 0), null, "https://open.spotify.com/intl-pt/track/4mZu6NuOntvYZqCZPrxTqT?si=dd6baafb4c344173", "A Vida É Desafio", "https://music.youtube.com/watch?v=Wb3rvC6z5ao&si=B48ryiwGGr0oT4PU" },
                    { 200, "https://music.apple.com/br/album/1-por-amor-2-por-dinheiro/1198317040?i=1198317083", "Mano Brown", new TimeSpan(0, 6, 58, 0, 0), null, "https://open.spotify.com/intl-pt/track/0VQ1mXWqoXynNmc0wdligL?si=7d472a2b750641cd", "1 por Amor, 2 por Dinheiro", "https://music.youtube.com/watch?v=JovdffVqJF4&si=PoBdSA4uUHXp0o7t" },
                    { 201, "https://music.apple.com/br/album/de-volta-%C3%A0-cena/1198317040?i=1198317084", "Mano Brown", new TimeSpan(0, 2, 1, 0, 0), null, "https://open.spotify.com/intl-pt/track/16oVqtzrcrdzQvtIRnA2Wx?si=6ce171ba988043b2", "De Volta À Cena", "https://music.youtube.com/watch?v=-2XWmz3BL2E&si=KEvmDmZjB5a6FioP" },
                    { 202, "https://music.apple.com/br/album/otus-500/1198317040?i=1198317085", "Mano Brown", new TimeSpan(0, 2, 11, 0, 0), null, "https://open.spotify.com/intl-pt/track/3tuMjoF61Uo54BPVzV4e0d?si=928873c4f72b4899", "Otus 500", "https://music.youtube.com/watch?v=JWQDQgkjOFY&si=b0p7znSk28BvERQH" },
                    { 203, "https://music.apple.com/br/album/crime-vai-e-vem/1198317040?i=1198317086", "Mano Brown", new TimeSpan(0, 7, 55, 0, 0), null, "https://open.spotify.com/intl-pt/track/29JxbOQf5YFFpqWgNauToo?si=5ec33c26b3ff4846", "Crime Vai e Vem", "https://music.youtube.com/watch?v=Npl2rJ5lzHE&si=8LzEtK11rHcQdzlf" },
                    { 204, "https://music.apple.com/br/album/jesus-chorou/1198317040?i=1198317087", "Mano Brown", new TimeSpan(0, 7, 51, 0, 0), null, "https://open.spotify.com/intl-pt/track/5wZUvwWGKaZ6NG8yckZcTM?si=b9e6a27d33734497", "Jesus Chorou", "https://music.youtube.com/watch?v=jLfWZ0nhTAE&si=rJJENiAdy1nCjkED" },
                    { 205, "https://music.apple.com/br/album/fone-intro/1198317040?i=1198317088", "Mano Brown", new TimeSpan(0, 1, 56, 0, 0), null, "https://open.spotify.com/intl-pt/track/1QEit92Juvj8i9QrM60gpn?si=da7e1a81dba64d70", "Fone (Intro)", "https://music.youtube.com/watch?v=7zHFe8qaf9Q&si=1P8Gp1vX2zQT4kg8" },
                    { 206, "https://music.apple.com/br/album/estilo-cachorro/1198317040?i=1198317089", "Mano Brown", new TimeSpan(0, 6, 17, 0, 0), null, "https://open.spotify.com/intl-pt/track/2tR8iLdCeYhVcyPZvN6T7X?si=2dad9da569b8475d", "Estilo Cachorro", "https://music.youtube.com/watch?v=q_xeCu3P9hU&si=XS3RUSMGTEK9vkx_" },
                    { 207, "https://music.apple.com/br/album/vida-loka-pt-2/1198317040?i=1198317090", "Mano Brown", new TimeSpan(0, 5, 50, 0, 0), null, "https://open.spotify.com/intl-pt/track/4nTrxp4aH0g2yLVPkFmljF?si=e66780a58a57434e", "Vida Loka, Pt. 2", "https://music.youtube.com/watch?v=Fu5kcgz73TY&si=ZxOg0rfHwPiyQ24T" },
                    { 208, "https://music.apple.com/br/album/expresso-da-meia-noite/1198317040?i=1198317091", "Mano Brown", new TimeSpan(0, 5, 21, 0, 0), null, "https://open.spotify.com/intl-pt/track/6CI6QHlg9ejvkWOTOni5oX?si=efb0f334ac0a415b", "Expresso da Meia-Noite", "https://music.youtube.com/watch?v=flpOCM7OXDQ&si=bML-4jKlbY2bkuyF" },
                    { 209, "https://music.apple.com/br/album/trutas-e-quebradas/1198317040?i=1198317096", "Mano Brown", new TimeSpan(0, 6, 17, 0, 0), null, "https://open.spotify.com/intl-pt/track/6xmtjVIcjMRdgdB1sywkjb?si=7901eb3bbf744144", "Trutas e Quebradas", "https://music.youtube.com/watch?v=tiPAMEtI38k&si=5MjRak4G7wE3ptxz" },
                    { 210, "https://music.apple.com/br/album/da-ponte-pra-c%C3%A1/1198317040?i=1198317097", "Mano Brown", new TimeSpan(0, 8, 47, 0, 0), null, "https://open.spotify.com/intl-pt/track/77ZXEJcwC7r4gfodNwERJz?si=8f38d0eaa5534781", "Da Ponte pra Cá", "https://music.youtube.com/watch?v=Xe8DN92jtbg&si=uM7wwS4WXkEbidVu" }
                });

            migrationBuilder.InsertData(
                table: "AlbumArtista",
                columns: new[] { "AlbumId", "ArtistaId", "MusicaId" },
                values: new object[,]
                {
                    { 1, 1, 1 },
                    { 1, 1, 2 },
                    { 1, 1, 3 },
                    { 1, 1, 4 },
                    { 1, 1, 5 },
                    { 1, 1, 6 },
                    { 1, 1, 7 },
                    { 1, 1, 8 },
                    { 1, 1, 9 },
                    { 1, 1, 10 },
                    { 1, 1, 11 },
                    { 1, 1, 12 },
                    { 1, 1, 13 },
                    { 1, 1, 14 },
                    { 1, 1, 15 },
                    { 1, 1, 16 },
                    { 1, 1, 17 },
                    { 1, 1, 18 },
                    { 2, 2, 19 },
                    { 2, 2, 20 },
                    { 2, 2, 21 },
                    { 2, 2, 22 },
                    { 2, 2, 23 },
                    { 2, 2, 24 },
                    { 2, 2, 25 },
                    { 2, 2, 26 },
                    { 2, 2, 27 },
                    { 3, 4, 29 },
                    { 3, 4, 30 },
                    { 3, 4, 31 },
                    { 3, 4, 32 },
                    { 3, 4, 33 },
                    { 3, 4, 34 },
                    { 3, 4, 35 },
                    { 3, 4, 36 },
                    { 3, 4, 37 },
                    { 3, 4, 38 },
                    { 3, 4, 39 },
                    { 3, 4, 40 },
                    { 4, 5, 41 },
                    { 4, 5, 42 },
                    { 4, 5, 43 },
                    { 4, 5, 44 },
                    { 4, 5, 45 },
                    { 4, 5, 47 },
                    { 4, 5, 48 },
                    { 4, 5, 49 },
                    { 4, 5, 50 },
                    { 4, 5, 51 },
                    { 4, 5, 52 },
                    { 4, 5, 53 },
                    { 4, 5, 54 },
                    { 4, 5, 55 },
                    { 4, 5, 56 },
                    { 5, 6, 58 },
                    { 5, 6, 59 },
                    { 5, 6, 60 },
                    { 5, 6, 61 },
                    { 5, 6, 62 },
                    { 5, 6, 63 },
                    { 5, 6, 64 },
                    { 5, 6, 65 },
                    { 5, 6, 66 },
                    { 5, 6, 67 },
                    { 5, 6, 68 },
                    { 5, 6, 69 },
                    { 5, 6, 70 },
                    { 5, 6, 71 },
                    { 5, 6, 72 },
                    { 5, 6, 73 },
                    { 5, 6, 74 },
                    { 5, 6, 75 },
                    { 5, 6, 76 },
                    { 6, 8, 77 },
                    { 6, 8, 78 },
                    { 6, 8, 79 },
                    { 6, 8, 80 },
                    { 6, 8, 81 },
                    { 6, 8, 82 },
                    { 6, 8, 83 },
                    { 6, 8, 84 },
                    { 6, 8, 85 },
                    { 6, 8, 86 },
                    { 6, 8, 87 },
                    { 6, 8, 88 },
                    { 7, 9, 89 },
                    { 7, 9, 90 },
                    { 7, 9, 91 },
                    { 7, 9, 92 },
                    { 7, 9, 93 },
                    { 7, 9, 94 },
                    { 7, 9, 95 },
                    { 7, 9, 96 },
                    { 7, 9, 97 },
                    { 7, 9, 98 },
                    { 7, 9, 99 },
                    { 7, 9, 100 },
                    { 7, 9, 101 },
                    { 8, 13, 106 },
                    { 8, 13, 107 },
                    { 8, 13, 108 },
                    { 8, 13, 109 },
                    { 8, 13, 110 },
                    { 8, 13, 111 },
                    { 8, 13, 112 },
                    { 8, 13, 113 },
                    { 8, 13, 114 },
                    { 8, 13, 115 },
                    { 8, 13, 116 },
                    { 8, 13, 117 },
                    { 8, 13, 118 },
                    { 8, 13, 119 },
                    { 8, 13, 120 },
                    { 9, 7, 57 },
                    { 10, 3, 28 },
                    { 11, 10, 103 },
                    { 12, 15, 46 },
                    { 13, 14, 104 },
                    { 14, 7, 102 },
                    { 15, 16, 105 },
                    { 16, 17, 122 },
                    { 17, 18, 123 },
                    { 18, 19, 124 },
                    { 18, 19, 125 },
                    { 18, 19, 126 },
                    { 18, 19, 127 },
                    { 18, 19, 128 },
                    { 18, 19, 129 },
                    { 18, 19, 130 },
                    { 18, 19, 131 },
                    { 18, 19, 132 },
                    { 18, 19, 133 },
                    { 18, 19, 134 },
                    { 18, 19, 135 },
                    { 18, 19, 136 },
                    { 19, 20, 137 },
                    { 19, 20, 138 },
                    { 19, 20, 139 },
                    { 19, 20, 140 },
                    { 19, 20, 141 },
                    { 19, 20, 142 },
                    { 19, 20, 143 },
                    { 19, 20, 144 },
                    { 19, 20, 145 },
                    { 19, 20, 146 },
                    { 19, 20, 147 },
                    { 19, 20, 148 },
                    { 19, 20, 149 },
                    { 19, 20, 150 },
                    { 19, 20, 151 },
                    { 20, 21, 152 },
                    { 21, 22, 153 },
                    { 21, 22, 154 },
                    { 21, 22, 155 },
                    { 21, 22, 156 },
                    { 21, 22, 157 },
                    { 21, 22, 158 },
                    { 21, 22, 159 },
                    { 21, 22, 160 },
                    { 21, 22, 161 },
                    { 21, 22, 162 },
                    { 21, 22, 163 },
                    { 21, 22, 164 },
                    { 21, 22, 165 },
                    { 21, 22, 166 },
                    { 21, 22, 167 },
                    { 21, 22, 168 },
                    { 21, 22, 169 },
                    { 21, 22, 170 },
                    { 21, 22, 171 },
                    { 21, 22, 172 },
                    { 21, 22, 173 },
                    { 21, 22, 174 },
                    { 22, 23, 175 },
                    { 22, 23, 176 },
                    { 22, 23, 177 },
                    { 22, 23, 178 },
                    { 22, 23, 179 },
                    { 22, 23, 180 },
                    { 22, 23, 181 },
                    { 22, 23, 182 },
                    { 22, 23, 183 },
                    { 22, 23, 184 },
                    { 22, 23, 185 },
                    { 22, 23, 186 },
                    { 22, 23, 187 },
                    { 23, 24, 188 },
                    { 24, 25, 189 },
                    { 25, 26, 190 },
                    { 25, 26, 191 },
                    { 25, 26, 192 },
                    { 25, 26, 193 },
                    { 25, 26, 194 },
                    { 25, 26, 195 },
                    { 25, 26, 196 },
                    { 25, 26, 197 },
                    { 25, 26, 198 },
                    { 25, 26, 199 },
                    { 25, 26, 200 },
                    { 25, 26, 201 },
                    { 25, 26, 202 },
                    { 25, 26, 203 },
                    { 25, 26, 204 },
                    { 25, 26, 205 },
                    { 25, 26, 206 },
                    { 25, 26, 207 },
                    { 25, 26, 208 },
                    { 25, 26, 209 },
                    { 25, 26, 210 },
                    { 26, 12, 121 }
                });

            migrationBuilder.InsertData(
                table: "AspNetUserRoles",
                columns: new[] { "RoleId", "UserId" },
                values: new object[,]
                {
                    { "0b44ca04-f6b0-4a8f-a953-1f2330d30894", "ddf093a6-6cb5-4ff7-9a64-83da34aee005" },
                    { "bec71b05-8f3d-4849-88bb-0e8d518d2de8", "ddf093a6-6cb5-4ff7-9a64-83da34aee005" },
                    { "ddf093a6-6cb5-4ff7-9a64-83da34aee005", "ddf093a6-6cb5-4ff7-9a64-83da34aee005" }
                });

            migrationBuilder.InsertData(
                table: "MusicaGenero",
                columns: new[] { "GeneroId", "MusicaId" },
                values: new object[,]
                {
                    { 2, 1 },
                    { 2, 2 },
                    { 2, 3 },
                    { 2, 4 },
                    { 2, 5 },
                    { 2, 6 },
                    { 2, 7 },
                    { 2, 8 },
                    { 2, 9 },
                    { 2, 10 },
                    { 2, 11 },
                    { 2, 12 },
                    { 2, 13 },
                    { 2, 14 },
                    { 2, 15 },
                    { 2, 16 },
                    { 2, 17 },
                    { 1, 18 },
                    { 1, 19 },
                    { 1, 20 },
                    { 3, 21 },
                    { 2, 22 },
                    { 1, 23 },
                    { 1, 24 },
                    { 1, 25 },
                    { 1, 26 },
                    { 1, 27 },
                    { 1, 28 },
                    { 1, 29 },
                    { 1, 30 },
                    { 1, 31 },
                    { 1, 32 },
                    { 1, 33 },
                    { 1, 34 },
                    { 1, 35 },
                    { 1, 36 },
                    { 1, 37 },
                    { 1, 38 },
                    { 1, 39 },
                    { 1, 40 },
                    { 2, 41 },
                    { 2, 42 },
                    { 2, 43 },
                    { 2, 44 },
                    { 2, 45 },
                    { 2, 46 },
                    { 2, 47 },
                    { 2, 48 },
                    { 2, 49 },
                    { 2, 50 },
                    { 2, 51 },
                    { 2, 52 },
                    { 2, 53 },
                    { 2, 54 },
                    { 2, 55 },
                    { 2, 56 },
                    { 2, 57 },
                    { 2, 58 },
                    { 2, 59 },
                    { 2, 60 },
                    { 2, 61 },
                    { 2, 62 },
                    { 2, 63 },
                    { 2, 64 },
                    { 2, 65 },
                    { 2, 66 },
                    { 2, 67 },
                    { 2, 68 },
                    { 2, 69 },
                    { 2, 70 },
                    { 2, 71 },
                    { 2, 72 },
                    { 2, 73 },
                    { 2, 74 },
                    { 2, 75 },
                    { 2, 76 },
                    { 2, 77 },
                    { 2, 78 },
                    { 2, 79 },
                    { 2, 80 },
                    { 2, 81 },
                    { 2, 82 },
                    { 2, 83 },
                    { 2, 84 },
                    { 2, 85 },
                    { 2, 86 },
                    { 2, 87 },
                    { 2, 88 },
                    { 2, 89 },
                    { 2, 90 },
                    { 2, 91 },
                    { 2, 92 },
                    { 2, 93 },
                    { 2, 94 },
                    { 2, 95 },
                    { 2, 96 },
                    { 2, 97 },
                    { 2, 98 },
                    { 2, 99 },
                    { 2, 100 },
                    { 2, 101 },
                    { 4, 102 },
                    { 2, 103 },
                    { 2, 104 },
                    { 2, 105 },
                    { 5, 106 },
                    { 5, 107 },
                    { 1, 108 },
                    { 5, 109 },
                    { 1, 110 },
                    { 5, 111 },
                    { 5, 112 },
                    { 5, 113 },
                    { 5, 114 },
                    { 1, 115 },
                    { 5, 116 },
                    { 5, 117 },
                    { 1, 118 },
                    { 1, 119 },
                    { 5, 120 },
                    { 3, 121 },
                    { 2, 122 },
                    { 1, 123 },
                    { 1, 124 },
                    { 1, 125 },
                    { 1, 126 },
                    { 1, 127 },
                    { 1, 128 },
                    { 5, 129 },
                    { 1, 130 },
                    { 1, 131 },
                    { 1, 132 },
                    { 1, 133 },
                    { 1, 134 },
                    { 1, 135 },
                    { 1, 136 },
                    { 2, 137 },
                    { 2, 138 },
                    { 2, 139 },
                    { 2, 140 },
                    { 2, 141 },
                    { 2, 142 },
                    { 2, 143 },
                    { 2, 144 },
                    { 2, 145 },
                    { 2, 146 },
                    { 2, 147 },
                    { 2, 148 },
                    { 2, 149 },
                    { 2, 150 },
                    { 2, 151 },
                    { 4, 152 },
                    { 2, 153 },
                    { 2, 154 },
                    { 2, 155 },
                    { 2, 156 },
                    { 2, 157 },
                    { 2, 158 },
                    { 2, 159 },
                    { 2, 160 },
                    { 2, 161 },
                    { 2, 162 },
                    { 2, 163 },
                    { 2, 164 },
                    { 2, 165 },
                    { 2, 166 },
                    { 2, 167 },
                    { 2, 168 },
                    { 2, 169 },
                    { 2, 170 },
                    { 2, 171 },
                    { 2, 172 },
                    { 2, 173 },
                    { 2, 174 },
                    { 2, 175 },
                    { 2, 176 },
                    { 2, 177 },
                    { 2, 178 },
                    { 2, 179 },
                    { 2, 180 },
                    { 2, 181 },
                    { 2, 182 },
                    { 2, 183 },
                    { 2, 184 },
                    { 2, 185 },
                    { 2, 186 },
                    { 2, 187 },
                    { 4, 188 },
                    { 1, 189 },
                    { 2, 190 },
                    { 2, 191 },
                    { 2, 192 },
                    { 2, 193 },
                    { 2, 194 },
                    { 2, 195 },
                    { 2, 196 },
                    { 2, 197 },
                    { 2, 198 },
                    { 2, 199 },
                    { 2, 200 },
                    { 2, 201 },
                    { 2, 202 },
                    { 2, 203 },
                    { 2, 204 },
                    { 2, 205 },
                    { 2, 206 },
                    { 2, 207 },
                    { 2, 208 },
                    { 2, 209 },
                    { 2, 210 }
                });

            migrationBuilder.InsertData(
                table: "Usuario",
                columns: new[] { "UsuarioId", "DataDeNascimento", "Foto", "Nome" },
                values: new object[] { "ddf093a6-6cb5-4ff7-9a64-83da34aee005", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "/img/usuarios/admin.png", "Administrador" });

            migrationBuilder.CreateIndex(
                name: "IX_AlbumArtista_ArtistaId",
                table: "AlbumArtista",
                column: "ArtistaId");

            migrationBuilder.CreateIndex(
                name: "IX_AlbumArtista_MusicaId",
                table: "AlbumArtista",
                column: "MusicaId");

            migrationBuilder.CreateIndex(
                name: "IX_AlbumGenero_GeneroId",
                table: "AlbumGenero",
                column: "GeneroId");

            migrationBuilder.CreateIndex(
                name: "IX_AspNetRoleClaims_RoleId",
                table: "AspNetRoleClaims",
                column: "RoleId");

            migrationBuilder.CreateIndex(
                name: "RoleNameIndex",
                table: "AspNetRoles",
                column: "NormalizedName",
                unique: true);

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
                unique: true);

            migrationBuilder.CreateIndex(
                name: "IX_ComentarioAlbum_AlbumId",
                table: "ComentarioAlbum",
                column: "AlbumId");

            migrationBuilder.CreateIndex(
                name: "IX_ComentarioAlbum_UsuarioId",
                table: "ComentarioAlbum",
                column: "UsuarioId");

            migrationBuilder.CreateIndex(
                name: "IX_ComentarioMusica_MusicaId",
                table: "ComentarioMusica",
                column: "MusicaId");

            migrationBuilder.CreateIndex(
                name: "IX_ComentarioMusica_UsuarioId",
                table: "ComentarioMusica",
                column: "UsuarioId");

            migrationBuilder.CreateIndex(
                name: "IX_GeneroArtista_ArtistaId",
                table: "GeneroArtista",
                column: "ArtistaId");

            migrationBuilder.CreateIndex(
                name: "IX_MusicaGenero_GeneroId",
                table: "MusicaGenero",
                column: "GeneroId");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "AlbumArtista");

            migrationBuilder.DropTable(
                name: "AlbumGenero");

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
                name: "ComentarioAlbum");

            migrationBuilder.DropTable(
                name: "ComentarioMusica");

            migrationBuilder.DropTable(
                name: "Critica");

            migrationBuilder.DropTable(
                name: "GeneroArtista");

            migrationBuilder.DropTable(
                name: "MusicaGenero");

            migrationBuilder.DropTable(
                name: "AspNetRoles");

            migrationBuilder.DropTable(
                name: "Album");

            migrationBuilder.DropTable(
                name: "Usuario");

            migrationBuilder.DropTable(
                name: "Artista");

            migrationBuilder.DropTable(
                name: "Genero");

            migrationBuilder.DropTable(
                name: "Musica");

            migrationBuilder.DropTable(
                name: "AspNetUsers");
        }
    }
}
