using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace PosExpress.AccesoDatos.Migrations
{
    /// <inheritdoc />
    public partial class Initial : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "TiposProducto",
                columns: table => new
                {
                    IdTipoProducto = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Descripcion = table.Column<string>(type: "nvarchar(255)", maxLength: 255, nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_TiposProducto", x => x.IdTipoProducto);
                });

            migrationBuilder.CreateTable(
                name: "ExpProductos",
                columns: table => new
                {
                    IdProducto = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Nombre = table.Column<string>(type: "nvarchar(100)", maxLength: 100, nullable: false),
                    Precio = table.Column<decimal>(type: "decimal(5,2)", nullable: false),
                    Activo = table.Column<bool>(type: "bit", nullable: false, defaultValue: true),
                    Fecha_Vencimiento = table.Column<DateOnly>(type: "date", nullable: false),
                    Observaciones = table.Column<string>(type: "nvarchar(max)", nullable: false, defaultValue: ""),
                    TipoProductoIdTipoProducto = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_ExpProductos", x => x.IdProducto);
                    table.ForeignKey(
                        name: "FK_ExpProductos_TiposProducto_TipoProductoIdTipoProducto",
                        column: x => x.TipoProductoIdTipoProducto,
                        principalTable: "TiposProducto",
                        principalColumn: "IdTipoProducto",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateIndex(
                name: "IX_ExpProductos_TipoProductoIdTipoProducto",
                table: "ExpProductos",
                column: "TipoProductoIdTipoProducto");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "ExpProductos");

            migrationBuilder.DropTable(
                name: "TiposProducto");
        }
    }
}
