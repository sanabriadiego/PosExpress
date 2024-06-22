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
            var productServicio = new ExpProductoServicios();
            var tipoProductoServicio = new TipoProductoServicios();

            //Console.WriteLine($"La lista de Tipos de productos es: {tipoProductoServicio.GetProducts()}");


            //foreach (var tipo in tipoProductoServicio.GetProducts())
            //{
            //    Console.WriteLine($"ID: {tipo.IdTipoProducto}, Descripción: {tipo.Descripcion}");
            //}

            // Crear

            //var tipoProducto = new TipoProducto
            //{
            //    Descripcion = "Intangible"
            //};
            //tipoProductoServicio.AddTipoProducto(tipoProducto);
            //Console.WriteLine("Tipo de producto creado!");

            //var product = new ExpProducto
            //{
            //    Nombre = "Leche Pil",
            //    Precio = 11,
            //    Fecha_Vencimiento = new DateOnly(2024, 11, 23),
            //    TipoProducto = tipoProducto
            //};
            //productServicio.AddProduct(product);
            //Console.WriteLine("Producto creado!");

            while (true)
            {
                Console.WriteLine("1. Ingresar Producto");
                Console.WriteLine("2. Encontrar Tipo Producto");
                Console.WriteLine("3. Exit");
                Console.Write("Escoge una opcion: ");
                var choice = Console.ReadLine();

                switch (choice)
                {
                    case "1":
                        Console.WriteLine("Ingresado!");
                        break;
                    case "2":
                        var id = Console.ReadLine();
                        Console.WriteLine($"El tipo de producto es: {tipoProductoServicio.GetTipoProducto(Int32.Parse(id)).Descripcion}");
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
