using Microsoft.Extensions.DependencyInjection;
using PosExpress.AccesoDatos;
using System;
using Microsoft.EntityFrameworkCore;
using PosExpress.AccesoDatos.Entidades;
using PosExpress.LogicadeNegocio;

namespace PosExpress.Presentacion
{
    internal class Program
    {
        static void Main(string[] args)
        {
            var serviceProvider = new ServiceCollection()
                .AddDbContext<AppDbContext>()
                .AddSingleton<ITipoProductoRepositorio, TipoProductoRepositorio>()
                .AddSingleton<IUnitOfWork, UnitOfWork>()
                .AddSingleton<ITipoProductoServicio, TipoProductoServicio>()
                .BuildServiceProvider();

            var catServiveProvider = new ServiceCollection()
                .AddDbContext<AppDbContext>()
                .AddSingleton<ICategoriaRepositorio, CategoriaRepositorio>()
                .AddSingleton<IUnitOfWork, UnitOfWork>()
                .AddSingleton<ICategoriaServicio, CategoriaServicio>()
                .BuildServiceProvider();

            var erpServiveProvider = new ServiceCollection()
                .AddDbContext<AppDbContext>()
                .AddSingleton<IErpProductoRepositorio, ErpProductoRepositorio>()
                .AddSingleton<IUnitOfWork, UnitOfWork>()
                .AddSingleton<IErpProductoServicio, ErpProductoServicio>()
                .BuildServiceProvider();

            var ventaServiceProvider = new ServiceCollection()
                .AddDbContext<AppDbContext>()
                .AddSingleton<IVentaExpressRepositorio, VentaExpressRepositorio>()
                .AddSingleton<IUnitOfWork, UnitOfWork>()
                .AddSingleton<IVentaExpressServicio, VentaExpressServicio>()
                .BuildServiceProvider();

            var prod_cat_ServiceProvider = new ServiceCollection()
                .AddDbContext<AppDbContext>()
                .AddSingleton<IProductosCategoriasRepositorio, ProductosCategoriasRepositorio>()
                .AddSingleton<IUnitOfWork, UnitOfWork>()
                .AddSingleton<IProductosCategoriasServicio, ProductosCategoriasServicio>()
                .BuildServiceProvider();

            var service = serviceProvider.GetService<ITipoProductoServicio>();
            var cat_service = catServiveProvider.GetService<ICategoriaServicio>();
            var erp_producto_servicio = erpServiveProvider.GetService<IErpProductoServicio>();
            var venta_servicio = ventaServiceProvider.GetService<IVentaExpressServicio>(); 
            var prod_cat_servicio = prod_cat_ServiceProvider.GetService<IProductosCategoriasServicio>();

             while (true)
            {
                Console.WriteLine("-------------------------------------------");
                Console.WriteLine("1. Agregar Tipo de Producto");
                Console.WriteLine("2. Mostrar todos los Tipo de Productos");
                Console.WriteLine("3. Agregar Categoria");
                Console.WriteLine("4. Mostrar todas las Categorias");
                Console.WriteLine("5. Agregar Nuevo Producto");
                Console.WriteLine("6. Agregar Nueva Venta");
                Console.WriteLine("7. Agregar un Producto a Una Categoria");
                Console.WriteLine("8. Activar Servicio GANAMAX");
                Console.WriteLine("9. Desactivar Servicio GANAMAX");
                Console.WriteLine("0. Exit");
                Console.Write("Escoge una opcion: \n");
                Console.WriteLine("-------------------------------------------");
                var choice = Console.ReadLine();

                switch (choice)
                {
                    case "1":
                        service.AddTipoProducto();
                        Console.WriteLine("Tipo de Producto agregado!");
                        break;
                    case "2":
                        service.GetProducts();
                        break;
                    case "3":
                        cat_service.AddCategoria();
                        break;
                    case "4":
                        cat_service.GetCategorias();
                        break;
                    case "5":
                        erp_producto_servicio.AddProducto();
                        break;
                    case "6":
                        venta_servicio.AddVenta();
                        break;
                    case "7":
                        prod_cat_servicio.AddProductoCategoria();
                        break;
                    case "8":
                        GlobalGanamax.ganamax = true;
                        Console.WriteLine("GANAMAX ACTIVADO!");
                        break;
                    case "9":
                        GlobalGanamax.ganamax = false;
                        Console.WriteLine("GANAMAX DESACTIVADO!");
                        break;
                    case "0":
                        return;
                    default:
                        Console.WriteLine("Opcion invalida, intente de nuevo");
                        break;
                }
            }
        }
    }
}
