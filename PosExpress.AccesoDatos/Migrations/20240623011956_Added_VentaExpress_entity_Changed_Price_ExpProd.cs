using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace PosExpress.AccesoDatos.Migrations
{
    /// <inheritdoc />
    public partial class Added_VentaExpress_entity_Changed_Price_ExpProd : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AlterColumn<decimal>(
                name: "Precio",
                table: "ExpProductos",
                type: "decimal(10,2)",
                nullable: false,
                oldClrType: typeof(decimal),
                oldType: "decimal(5,2)");

            migrationBuilder.CreateTable(
                name: "VentaExpress",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Fecha = table.Column<DateTime>(type: "datetime2", nullable: false),
                    Cliente = table.Column<string>(type: "nvarchar(100)", maxLength: 100, nullable: false),
                    Producto = table.Column<string>(type: "nvarchar(100)", maxLength: 100, nullable: false),
                    UniqueProducto = table.Column<int>(type: "int", nullable: false),
                    Cantidad = table.Column<int>(type: "int", nullable: false),
                    Precio = table.Column<decimal>(type: "decimal(10,2)", nullable: false),
                    Descuento = table.Column<decimal>(type: "decimal(3,2)", nullable: false, defaultValue: 0.0m),
                    Total = table.Column<decimal>(type: "decimal(10,2)", nullable: false),
                    ExpProductoIdProducto = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_VentaExpress", x => x.Id);
                    table.ForeignKey(
                        name: "FK_VentaExpress_ExpProductos_ExpProductoIdProducto",
                        column: x => x.ExpProductoIdProducto,
                        principalTable: "ExpProductos",
                        principalColumn: "IdProducto",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateIndex(
                name: "IX_VentaExpress_ExpProductoIdProducto",
                table: "VentaExpress",
                column: "ExpProductoIdProducto");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "VentaExpress");

            migrationBuilder.AlterColumn<decimal>(
                name: "Precio",
                table: "ExpProductos",
                type: "decimal(5,2)",
                nullable: false,
                oldClrType: typeof(decimal),
                oldType: "decimal(10,2)");
        }
    }
}
