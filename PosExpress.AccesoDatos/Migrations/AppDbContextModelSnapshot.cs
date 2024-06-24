﻿// <auto-generated />
using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using PosExpress.AccesoDatos;

#nullable disable

namespace PosExpress.AccesoDatos.Migrations
{
    [DbContext(typeof(AppDbContext))]
    partial class AppDbContextModelSnapshot : ModelSnapshot
    {
        protected override void BuildModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "8.0.6")
                .HasAnnotation("Relational:MaxIdentifierLength", 128);

            SqlServerModelBuilderExtensions.UseIdentityColumns(modelBuilder);

            modelBuilder.Entity("PosExpress.AccesoDatos.Entidades.Categoria", b =>
                {
                    b.Property<int>("IdCategoria")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("IdCategoria"));

                    b.Property<bool>("Activo")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("bit")
                        .HasDefaultValue(true);

                    b.Property<string>("Descripcion")
                        .IsRequired()
                        .HasMaxLength(255)
                        .HasColumnType("nvarchar(255)");

                    b.HasKey("IdCategoria");

                    b.ToTable("Categorias");
                });

            modelBuilder.Entity("PosExpress.AccesoDatos.Entidades.CodigoBarras", b =>
                {
                    b.Property<int>("IdCodigoBarra")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("IdCodigoBarra"));

                    b.Property<bool>("Activo")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("bit")
                        .HasDefaultValue(true);

                    b.Property<int>("ExpProductoIdProducto")
                        .HasColumnType("int");

                    b.Property<string>("UniqueCodigo")
                        .IsRequired()
                        .HasMaxLength(50)
                        .HasColumnType("nvarchar(50)");

                    b.HasKey("IdCodigoBarra");

                    b.HasIndex("ExpProductoIdProducto");

                    b.ToTable("CodigosBarras");
                });

            modelBuilder.Entity("PosExpress.AccesoDatos.Entidades.ErpProducto", b =>
                {
                    b.Property<int>("IdProducto")
                        .HasColumnType("int");

                    b.Property<decimal>("Costo")
                        .HasColumnType("decimal(10,2)");

                    b.Property<DateTime>("FechaRegistro")
                        .HasColumnType("datetime2");

                    b.Property<int>("Stock")
                        .HasColumnType("int");

                    b.Property<string>("UniqueCodigo")
                        .IsRequired()
                        .HasMaxLength(50)
                        .HasColumnType("nvarchar(50)");

                    b.HasKey("IdProducto");

                    b.ToTable("ErpProductos");
                });

            modelBuilder.Entity("PosExpress.AccesoDatos.Entidades.ExpProducto", b =>
                {
                    b.Property<int>("IdProducto")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("IdProducto"));

                    b.Property<bool>("Activo")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("bit")
                        .HasDefaultValue(true);

                    b.Property<DateOnly>("Fecha_Vencimiento")
                        .HasColumnType("date");

                    b.Property<string>("Nombre")
                        .IsRequired()
                        .HasMaxLength(100)
                        .HasColumnType("nvarchar(100)");

                    b.Property<string>("Observaciones")
                        .IsRequired()
                        .ValueGeneratedOnAdd()
                        .HasColumnType("nvarchar(max)")
                        .HasDefaultValue("");

                    b.Property<decimal>("Precio")
                        .HasColumnType("decimal(10,2)");

                    b.Property<int>("TipoProductoIdTipoProducto")
                        .HasColumnType("int");

                    b.HasKey("IdProducto");

                    b.HasIndex("TipoProductoIdTipoProducto");

                    b.ToTable("ExpProductos");
                });

            modelBuilder.Entity("PosExpress.AccesoDatos.Entidades.ProductosCategorias", b =>
                {
                    b.Property<int>("IdDetalle")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("IdDetalle"));

                    b.Property<int>("CategoriaIdCategoria")
                        .HasColumnType("int");

                    b.Property<int>("ExpProductoIdProducto")
                        .HasColumnType("int");

                    b.Property<DateTime>("FechaCreacion")
                        .HasColumnType("datetime2");

                    b.HasKey("IdDetalle");

                    b.HasIndex("CategoriaIdCategoria");

                    b.HasIndex("ExpProductoIdProducto");

                    b.ToTable("ProductosCategorias");
                });

            modelBuilder.Entity("PosExpress.AccesoDatos.Entidades.TipoProducto", b =>
                {
                    b.Property<int>("IdTipoProducto")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("IdTipoProducto"));

                    b.Property<string>("Descripcion")
                        .IsRequired()
                        .HasMaxLength(255)
                        .HasColumnType("nvarchar(255)");

                    b.HasKey("IdTipoProducto");

                    b.ToTable("TiposProducto");
                });

            modelBuilder.Entity("PosExpress.AccesoDatos.Entidades.VentaExpress", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.Property<int>("Cantidad")
                        .HasColumnType("int");

                    b.Property<string>("Cliente")
                        .IsRequired()
                        .HasMaxLength(100)
                        .HasColumnType("nvarchar(100)");

                    b.Property<decimal>("Descuento")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("decimal(3,2)")
                        .HasDefaultValue(0.0m);

                    b.Property<int>("ExpProductoIdProducto")
                        .HasColumnType("int");

                    b.Property<DateTime>("Fecha")
                        .HasColumnType("datetime2");

                    b.Property<decimal>("Precio")
                        .HasColumnType("decimal(10,2)");

                    b.Property<string>("Producto")
                        .IsRequired()
                        .HasMaxLength(100)
                        .HasColumnType("nvarchar(100)");

                    b.Property<decimal>("Total")
                        .HasColumnType("decimal(10,2)");

                    b.Property<string>("UniqueProducto")
                        .IsRequired()
                        .HasMaxLength(50)
                        .HasColumnType("nvarchar(50)");

                    b.HasKey("Id");

                    b.HasIndex("ExpProductoIdProducto");

                    b.ToTable("VentaExpress");
                });

            modelBuilder.Entity("PosExpress.AccesoDatos.Entidades.CodigoBarras", b =>
                {
                    b.HasOne("PosExpress.AccesoDatos.Entidades.ExpProducto", "ExpProducto")
                        .WithMany()
                        .HasForeignKey("ExpProductoIdProducto")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("ExpProducto");
                });

            modelBuilder.Entity("PosExpress.AccesoDatos.Entidades.ErpProducto", b =>
                {
                    b.HasOne("PosExpress.AccesoDatos.Entidades.ExpProducto", "ExpProducto")
                        .WithOne("ErpProducto")
                        .HasForeignKey("PosExpress.AccesoDatos.Entidades.ErpProducto", "IdProducto")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("ExpProducto");
                });

            modelBuilder.Entity("PosExpress.AccesoDatos.Entidades.ExpProducto", b =>
                {
                    b.HasOne("PosExpress.AccesoDatos.Entidades.TipoProducto", "TipoProducto")
                        .WithMany()
                        .HasForeignKey("TipoProductoIdTipoProducto")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("TipoProducto");
                });

            modelBuilder.Entity("PosExpress.AccesoDatos.Entidades.ProductosCategorias", b =>
                {
                    b.HasOne("PosExpress.AccesoDatos.Entidades.Categoria", "Categoria")
                        .WithMany("ProductosCategorias")
                        .HasForeignKey("CategoriaIdCategoria")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("PosExpress.AccesoDatos.Entidades.ExpProducto", "ExpProducto")
                        .WithMany("ProductosCategorias")
                        .HasForeignKey("ExpProductoIdProducto")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Categoria");

                    b.Navigation("ExpProducto");
                });

            modelBuilder.Entity("PosExpress.AccesoDatos.Entidades.VentaExpress", b =>
                {
                    b.HasOne("PosExpress.AccesoDatos.Entidades.ExpProducto", "ExpProducto")
                        .WithMany()
                        .HasForeignKey("ExpProductoIdProducto")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("ExpProducto");
                });

            modelBuilder.Entity("PosExpress.AccesoDatos.Entidades.Categoria", b =>
                {
                    b.Navigation("ProductosCategorias");
                });

            modelBuilder.Entity("PosExpress.AccesoDatos.Entidades.ExpProducto", b =>
                {
                    b.Navigation("ErpProducto")
                        .IsRequired();

                    b.Navigation("ProductosCategorias");
                });
#pragma warning restore 612, 618
        }
    }
}
