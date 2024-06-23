using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace PosExpress.AccesoDatos.Migrations
{
    /// <inheritdoc />
    public partial class Added_ProductoCategoria_entity : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "ProductosCategorias",
                columns: table => new
                {
                    IdDetalle = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    FechaCreacion = table.Column<DateTime>(type: "datetime2", nullable: false, defaultValue: new DateTime(2024, 6, 22, 20, 27, 44, 110, DateTimeKind.Local).AddTicks(3586)),
                    IdProducto = table.Column<int>(type: "int", nullable: false),
                    ExpProductoIdProducto = table.Column<int>(type: "int", nullable: false),
                    IdCategoria = table.Column<int>(type: "int", nullable: false),
                    CategoriaIdCategoria = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_ProductosCategorias", x => x.IdDetalle);
                    table.ForeignKey(
                        name: "FK_ProductosCategorias_Categorias_CategoriaIdCategoria",
                        column: x => x.CategoriaIdCategoria,
                        principalTable: "Categorias",
                        principalColumn: "IdCategoria",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_ProductosCategorias_ExpProductos_ExpProductoIdProducto",
                        column: x => x.ExpProductoIdProducto,
                        principalTable: "ExpProductos",
                        principalColumn: "IdProducto",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateIndex(
                name: "IX_ProductosCategorias_CategoriaIdCategoria",
                table: "ProductosCategorias",
                column: "CategoriaIdCategoria");

            migrationBuilder.CreateIndex(
                name: "IX_ProductosCategorias_ExpProductoIdProducto",
                table: "ProductosCategorias",
                column: "ExpProductoIdProducto");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "ProductosCategorias");
        }
    }
}
