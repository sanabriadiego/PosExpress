using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace PosExpress.AccesoDatos.Migrations
{
    /// <inheritdoc />
    public partial class Added_Codigo_Barras_entity : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.RenameColumn(
                name: "UniqueCode",
                table: "ErpProductos",
                newName: "UniqueCodigo");

            migrationBuilder.CreateTable(
                name: "CodigosBarras",
                columns: table => new
                {
                    IdCodigoBarra = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    UniqueCodigo = table.Column<int>(type: "int", nullable: false),
                    Activo = table.Column<bool>(type: "bit", nullable: false, defaultValue: true),
                    ExpProductoIdProducto = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_CodigosBarras", x => x.IdCodigoBarra);
                    table.ForeignKey(
                        name: "FK_CodigosBarras_ExpProductos_ExpProductoIdProducto",
                        column: x => x.ExpProductoIdProducto,
                        principalTable: "ExpProductos",
                        principalColumn: "IdProducto",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateIndex(
                name: "IX_CodigosBarras_ExpProductoIdProducto",
                table: "CodigosBarras",
                column: "ExpProductoIdProducto");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "CodigosBarras");

            migrationBuilder.RenameColumn(
                name: "UniqueCodigo",
                table: "ErpProductos",
                newName: "UniqueCode");
        }
    }
}
