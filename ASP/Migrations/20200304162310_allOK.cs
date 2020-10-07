using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace ASPNET.Migrations
{
    public partial class allOK : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "AutorSet",
                columns: table => new
                {
                    AutorId = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Nombre = table.Column<string>(nullable: false),
                    Apellidos = table.Column<string>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AutorSet", x => x.AutorId);
                });

            migrationBuilder.CreateTable(
                name: "ClasificacionSet",
                columns: table => new
                {
                    ClasificacionId = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Descripcion = table.Column<string>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_ClasificacionSet", x => x.ClasificacionId);
                });

            migrationBuilder.CreateTable(
                name: "ConfiguracionSet",
                columns: table => new
                {
                    ConfiguracionId = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    NumDiasPrestamo1 = table.Column<int>(nullable: true),
                    NumDiasPrestamo2 = table.Column<int>(nullable: true),
                    MaxPrestamoUsuario = table.Column<int>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_ConfiguracionSet", x => x.ConfiguracionId);
                });

            migrationBuilder.CreateTable(
                name: "EditorialSet",
                columns: table => new
                {
                    EditorialId = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    RazonSocial = table.Column<string>(nullable: false),
                    Direccion = table.Column<string>(nullable: false),
                    Poblacion = table.Column<string>(nullable: false),
                    CodigoPostal = table.Column<string>(nullable: false),
                    Provincia = table.Column<string>(nullable: false),
                    Telefono1 = table.Column<string>(nullable: false),
                    Telefono2 = table.Column<string>(nullable: true),
                    PersonaContacto = table.Column<string>(nullable: true),
                    Observaciones = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_EditorialSet", x => x.EditorialId);
                });

            migrationBuilder.CreateTable(
                name: "GeneroSet",
                columns: table => new
                {
                    GeneroId = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Descripcion = table.Column<string>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_GeneroSet", x => x.GeneroId);
                });

            migrationBuilder.CreateTable(
                name: "UsuarioSet",
                columns: table => new
                {
                    DNI = table.Column<string>(maxLength: 10, nullable: false),
                    Nombre = table.Column<string>(nullable: false),
                    Apellidos = table.Column<string>(nullable: false),
                    Direccion = table.Column<string>(nullable: false),
                    Poblacion = table.Column<string>(nullable: false),
                    CodigoPostal = table.Column<string>(nullable: false),
                    Provincia = table.Column<string>(nullable: false),
                    Telefono1 = table.Column<string>(nullable: false),
                    Telefono2 = table.Column<string>(nullable: true),
                    InicioSesion = table.Column<bool>(nullable: true),
                    Salt = table.Column<string>(nullable: true),
                    Email = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_UsuarioSet", x => x.DNI);
                });

            migrationBuilder.CreateTable(
                name: "LibroSet",
                columns: table => new
                {
                    LibroId = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Titulo = table.Column<string>(nullable: false),
                    Descripción = table.Column<string>(nullable: false),
                    Stock = table.Column<int>(nullable: true),
                    StockDisponible = table.Column<int>(nullable: true),
                    Imagen = table.Column<byte[]>(nullable: true),
                    AutorAutorId = table.Column<int>(nullable: false),
                    ClasificacionClasificacionId = table.Column<int>(nullable: false),
                    GeneroGeneroId = table.Column<int>(nullable: false),
                    EditorialEditorialId = table.Column<int>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_LibroSet", x => x.LibroId);
                    table.ForeignKey(
                        name: "FK_AutorLibro",
                        column: x => x.AutorAutorId,
                        principalTable: "AutorSet",
                        principalColumn: "AutorId",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_ClasificacionLibro",
                        column: x => x.ClasificacionClasificacionId,
                        principalTable: "ClasificacionSet",
                        principalColumn: "ClasificacionId",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_EditorialLibro",
                        column: x => x.EditorialEditorialId,
                        principalTable: "EditorialSet",
                        principalColumn: "EditorialId",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_GeneroLibro",
                        column: x => x.GeneroGeneroId,
                        principalTable: "GeneroSet",
                        principalColumn: "GeneroId",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "PrestamoSet",
                columns: table => new
                {
                    PrestamoId = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    FechaInicio = table.Column<DateTime>(type: "datetime", nullable: false),
                    FechaFin = table.Column<DateTime>(type: "datetime", nullable: false),
                    FechaDevolucion = table.Column<DateTime>(type: "datetime", nullable: true),
                    UsuarioDNI = table.Column<string>(maxLength: 10, nullable: false),
                    LibroLibroId = table.Column<int>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_PrestamoSet", x => x.PrestamoId);
                    table.ForeignKey(
                        name: "FK_LibroPrestamo",
                        column: x => x.LibroLibroId,
                        principalTable: "LibroSet",
                        principalColumn: "LibroId",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_UsuarioPrestamo",
                        column: x => x.UsuarioDNI,
                        principalTable: "UsuarioSet",
                        principalColumn: "DNI",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateIndex(
                name: "IX_FK_AutorLibro",
                table: "LibroSet",
                column: "AutorAutorId");

            migrationBuilder.CreateIndex(
                name: "IX_FK_ClasificacionLibro",
                table: "LibroSet",
                column: "ClasificacionClasificacionId");

            migrationBuilder.CreateIndex(
                name: "IX_FK_EditorialLibro",
                table: "LibroSet",
                column: "EditorialEditorialId");

            migrationBuilder.CreateIndex(
                name: "IX_FK_GeneroLibro",
                table: "LibroSet",
                column: "GeneroGeneroId");

            migrationBuilder.CreateIndex(
                name: "IX_FK_LibroPrestamo",
                table: "PrestamoSet",
                column: "LibroLibroId");

            migrationBuilder.CreateIndex(
                name: "IX_FK_UsuarioPrestamo",
                table: "PrestamoSet",
                column: "UsuarioDNI");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "ConfiguracionSet");

            migrationBuilder.DropTable(
                name: "PrestamoSet");

            migrationBuilder.DropTable(
                name: "LibroSet");

            migrationBuilder.DropTable(
                name: "UsuarioSet");

            migrationBuilder.DropTable(
                name: "AutorSet");

            migrationBuilder.DropTable(
                name: "ClasificacionSet");

            migrationBuilder.DropTable(
                name: "EditorialSet");

            migrationBuilder.DropTable(
                name: "GeneroSet");
        }
    }
}
