using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace PosExpress.AccesoDatos.Migrations
{
    /// <inheritdoc />
    public partial class Modified_ProductosCategorias : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "IdCategoria",
                table: "ProductosCategorias");

            migrationBuilder.DropColumn(
                name: "IdProducto",
                table: "ProductosCategorias");

            migrationBuilder.AlterColumn<DateTime>(
                name: "FechaCreacion",
                table: "ProductosCategorias",
                type: "datetime2",
                nullable: false,
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2024, 6, 22, 20, 27, 44, 110, DateTimeKind.Local).AddTicks(3586));
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AlterColumn<DateTime>(
                name: "FechaCreacion",
                table: "ProductosCategorias",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2024, 6, 22, 20, 27, 44, 110, DateTimeKind.Local).AddTicks(3586),
                oldClrType: typeof(DateTime),
                oldType: "datetime2");

            migrationBuilder.AddColumn<int>(
                name: "IdCategoria",
                table: "ProductosCategorias",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<int>(
                name: "IdProducto",
                table: "ProductosCategorias",
                type: "int",
                nullable: false,
                defaultValue: 0);
        }
    }
}
