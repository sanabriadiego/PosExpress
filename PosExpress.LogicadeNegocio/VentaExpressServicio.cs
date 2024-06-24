using Microsoft.Extensions.DependencyInjection;
using PosExpress.AccesoDatos;
using PosExpress.AccesoDatos.Entidades;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PosExpress.LogicadeNegocio
{
    public class VentaExpressServicio : IVentaExpressServicio
    {
        private readonly IUnitOfWork _unitOfWork;

        public VentaExpressServicio(IUnitOfWork unitOfWork)
        {
            _unitOfWork = unitOfWork;
        }

        public void AddVenta()
        {
            
            Console.WriteLine("Por favor ingrese los siguientes datos para la Venta:\n");
            Console.WriteLine("Codigo Producto:");
            string codigo = Console.ReadLine();
            Console.WriteLine("Cliente:");
            string cliente = Console.ReadLine();
            Console.WriteLine("Cantidad:");
            string cantidad = Console.ReadLine();
            ErpProducto erp_producto = _unitOfWork.ErpProductos.GetByCodigo(codigo);
            ExpProducto exp_producto = _unitOfWork.ExpProductos.GetExpProductobyId(erp_producto.IdProducto);
            decimal descuento;
            if (GlobalGanamax.ganamax && _unitOfWork.Productos_Categorias.ProdCat_RelationQty(erp_producto.IdProducto) < 2)
            {
                descuento = 0.1m;
            }
            else if (_unitOfWork.Productos_Categorias.ProdCat_RelationQty(erp_producto.IdProducto) < 2)
            {
                descuento = 0.3m;
            }
            else
            {
                descuento = 0.0m;
            }
            VentaExpress venta = new VentaExpress
            {
                Fecha = DateTime.Now,
                Cliente = cliente,
                Producto = exp_producto.Nombre,
                UniqueProducto = codigo,
                Cantidad = Int32.Parse(cantidad),
                Precio = exp_producto.Precio,
                Descuento = descuento,
                Total = (exp_producto.Precio * Int32.Parse(cantidad)) - (descuento * (exp_producto.Precio * Int32.Parse(cantidad))),
                ExpProducto = exp_producto
            };
            int restante_stock = erp_producto.Stock - Int32.Parse(cantidad);
            if (GlobalGanamax.ganamax && (restante_stock < 10)) 
            {
                Console.WriteLine("Lo sentimos la venta dejaria menos de 11 unidades en stock");
            }
            else if(!GlobalGanamax.ganamax && (Int32.Parse(cantidad) > erp_producto.Stock)) 
            {
                Console.WriteLine("Lo sentimos no tenemos las unidades suficientes en stock para esta venta");
            }
            else
            {
                _unitOfWork.VentaExpress.Add(venta);
                erp_producto.Stock = erp_producto.Stock - Int32.Parse(cantidad);
                _unitOfWork.Complete();
                Console.WriteLine("Venta realizada con exito!");
            }
        }
    }
}
