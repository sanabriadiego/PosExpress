using Microsoft.Extensions.DependencyInjection;
using PosExpress.AccesoDatos;
using System;
using Microsoft.EntityFrameworkCore;
using PosExpress.AccesoDatos.Entidades;
using static PosExpress.LogicadeNegocio.ExpProductoServicios;
using PosExpress.LogicadeNegocio;

namespace PosExpress.Presentacion
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //var productServicio = new ExpProductoServicios();
            var serviceProvider = new ServiceCollection()
                .AddDbContext<AppDbContext>()
                .AddSingleton<ITipoProductoRepositorio, TipoProductoRepositorio>()
                .AddSingleton<IUnitOfWork, UnitOfWork>()
                .AddSingleton<ITipoProductoServicio, TipoProductoServicio>()
                .BuildServiceProvider();

            var service = serviceProvider.GetService<ITipoProductoServicio>();

            while (true)
            {
                Console.WriteLine("1. Agregar Tipo de Producto");
                Console.WriteLine("2. Mostrar todos los Tipo de Productos");
                Console.WriteLine("3. Exit");
                Console.Write("Escoge una opcion: ");
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
                    return;
                default:
                    Console.WriteLine("Invalid option. Please try again.");
                    break;
                }
            }
        }
    }
}
