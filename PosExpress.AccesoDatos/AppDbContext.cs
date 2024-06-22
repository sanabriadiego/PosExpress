using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;

namespace PosExpress.AccesoDatos
{
    public class AppDbContext : DbContext
    {
        public DbSet<Entidades.ExpProducto> ExpProductos { get; set; }
        public DbSet<Entidades.TipoProducto> TiposProducto { get; set; }

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
            modelBuilder.Entity<Entidades.ExpProducto>(entity =>
            {
                entity.HasKey(p => p.IdProducto);
                entity.Property(p => p.Nombre)
                    .IsRequired()
                    .HasMaxLength(100);
                entity.Property(p => p.Precio)
                    .HasColumnType("decimal(5,2)")
                    .IsRequired();
                entity.Property(p => p.Activo)
                    .HasDefaultValue(true);
                entity.Property(p => p.Fecha_Vencimiento)
                    .IsRequired();
                entity.Property(p => p.Observaciones)
                    .HasDefaultValue("");
            });

            modelBuilder.Entity<Entidades.TipoProducto>(entity =>
            {

                entity.HasKey(tp => tp.IdTipoProducto);
                entity.Property(tp => tp.Descripcion)
                    .HasMaxLength(255)
                    .IsRequired();
            });

    
        }
    }
}
