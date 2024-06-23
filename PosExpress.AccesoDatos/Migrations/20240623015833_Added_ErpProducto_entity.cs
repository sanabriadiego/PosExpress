using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace PosExpress.AccesoDatos.Migrations
{
    /// <inheritdoc />
    public partial class Added_ErpProducto_entity : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "ErpProductos",
                columns: table => new
                {
                    IdProducto = table.Column<int>(type: "int", nullable: false),
                    Costo = table.Column<decimal>(type: "decimal(10,2)", nullable: false),
                    UniqueCode = table.Column<int>(type: "int", nullable: false),
                    FechaRegistro = table.Column<DateTime>(type: "datetime2", nullable: false),
                    Stock = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_ErpProductos", x => x.IdProducto);
                    table.ForeignKey(
                        name: "FK_ErpProductos_ExpProductos_IdProducto",
                        column: x => x.IdProducto,
                        principalTable: "ExpProductos",
                        principalColumn: "IdProducto",
                        onDelete: ReferentialAction.Cascade);
                });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "ErpProductos");
        }
    }
}
