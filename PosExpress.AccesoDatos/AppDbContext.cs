using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using PosExpress.AccesoDatos.Entidades;
using Microsoft.EntityFrameworkCore;
using System.Diagnostics.CodeAnalysis;

namespace PosExpress.AccesoDatos
{
    public class AppDbContext : DbContext
    {
        public DbSet<ExpProducto> ExpProductos { get; set; }
        public DbSet<TipoProducto> TiposProducto { get; set; }
        public DbSet<Categoria> Categorias { get; set; }
        public DbSet<ProductosCategorias> ProductosCategorias { get; set; }
        public DbSet<VentaExpress> VentaExpress { get; set; }
        public DbSet<ErpProducto> ErpProductos { get; set; }
        public DbSet<CodigoBarras> CodigosBarras { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer(
                @"Server=(localdb)\MSSQLLocalDB;Database=PosExpressDb3;Trusted_Connection=True;",
                options => options.EnableRetryOnFailure(
                    maxRetryCount: 5,
                    maxRetryDelay: TimeSpan.FromSeconds(30),
                    errorNumbersToAdd: null));
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<ExpProducto>(entity =>
            {
                entity.HasKey(p => p.IdProducto);
                entity.Property(p => p.Nombre)
                    .IsRequired()
                    .HasMaxLength(100);
                entity.Property(p => p.Precio)
                    .HasColumnType("decimal(10,2)")
                    .IsRequired();
                entity.Property(p => p.Activo)
                    .HasDefaultValue(true);
                entity.Property(p => p.Fecha_Vencimiento)
                    .IsRequired();
                entity.Property(p => p.Observaciones)
                    .HasDefaultValue("");
            });

            modelBuilder.Entity<TipoProducto>(entity =>
            {

                entity.HasKey(tp => tp.IdTipoProducto);
                entity.Property(tp => tp.Descripcion)
                    .HasMaxLength(255)
                    .IsRequired();
            });

            modelBuilder.Entity<Categoria>(entity =>
            {
                entity.HasKey(c => c.IdCategoria);
                entity.Property(c => c.Descripcion)
                    .HasMaxLength(255)
                    .IsRequired(true);
                entity.Property(c => c.Activo)
                    .HasDefaultValue(true);
            });

            modelBuilder.Entity<ProductosCategorias>(entity =>
            {
                entity.HasKey(pc => pc.IdDetalle);
                entity.Property(pc => pc.FechaCreacion);
            });

            modelBuilder.Entity<VentaExpress>(entity =>
            {
                entity.HasKey(ve => ve.Id);
                entity.Property(ve => ve.Fecha)
                    .IsRequired(true);
                entity.Property(ve => ve.Cliente)
                    .HasMaxLength(100)
                    .IsRequired(true);
                entity.Property(ve => ve.Producto)
                    .HasMaxLength(100)
                    .IsRequired(true);
                entity.Property(ve => ve.UniqueProducto)
                    .IsRequired(true);
                entity.Property(ve => ve.Cantidad)
                    .IsRequired(true);
                entity.Property(ve => ve.Precio)
                    .HasColumnType("decimal(10,2)")
                    .IsRequired(true);
                entity.Property(ve => ve.Descuento)
                    .HasColumnType("decimal(3,2)")
                    .HasDefaultValue(0.0m);
                entity.Property(ve => ve.Total)
                    .HasColumnType("decimal(10,2)")
                    .IsRequired(true);
            });

            modelBuilder.Entity<ErpProducto>(entity =>
            {
                entity.HasKey(p => p.IdProducto);
                entity.Property(p => p.Costo)
                    .HasColumnType("decimal(10,2)")
                    .IsRequired(true);
                entity.Property(p => p.UniqueCodigo)
                   .IsRequired(true);
                entity.Property(p => p.FechaRegistro)
                   .IsRequired(true);
                entity.Property(p => p.Stock)
                   .IsRequired(true);

            });

            modelBuilder.Entity<CodigoBarras>(entity =>
            {
                entity.HasKey(cb => cb.IdCodigoBarra);
                entity.Property(cb => cb.UniqueCodigo)
                   .IsRequired(true);
                entity.Property(cb => cb.Activo)
                   .IsRequired(true)
                   .HasDefaultValue(true);
            });
        }
    }
}
