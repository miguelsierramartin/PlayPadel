using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace Alquiler.Persistence.Databse.Migrations
{
    public partial class Actualizando : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.EnsureSchema(
                name: "Alquiler");

            migrationBuilder.CreateTable(
                name: "Pistas",
                schema: "Alquiler",
                columns: table => new
                {
                    PistaID = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Nombre = table.Column<int>(maxLength: 100, nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Pistas", x => x.PistaID);
                });

            migrationBuilder.CreateTable(
                name: "Reservas",
                schema: "Alquiler",
                columns: table => new
                {
                    ReservaID = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Usuario = table.Column<string>(nullable: true),
                    Pista = table.Column<int>(nullable: false),
                    Fecha = table.Column<DateTime>(nullable: false),
                    HoraInicio = table.Column<int>(nullable: false),
                    HoraFin = table.Column<int>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Reservas", x => x.ReservaID);
                });

            migrationBuilder.InsertData(
                schema: "Alquiler",
                table: "Pistas",
                columns: new[] { "PistaID", "Nombre" },
                values: new object[,]
                {
                    { 1, 0 },
                    { 2, 1 },
                    { 3, 2 },
                    { 4, 3 },
                    { 5, 4 },
                    { 6, 5 },
                    { 7, 6 },
                    { 8, 7 },
                    { 9, 8 },
                    { 10, 9 }
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Pistas",
                schema: "Alquiler");

            migrationBuilder.DropTable(
                name: "Reservas",
                schema: "Alquiler");
        }
    }
}
