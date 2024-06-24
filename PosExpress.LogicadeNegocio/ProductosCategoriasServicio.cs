using PosExpress.AccesoDatos;
using PosExpress.AccesoDatos.Entidades;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PosExpress.LogicadeNegocio
{
    public class ProductosCategoriasServicio : IProductosCategoriasServicio
    {
        private readonly IUnitOfWork _unitOfWork;

        public ProductosCategoriasServicio(IUnitOfWork unitOfWork)
        {
            _unitOfWork = unitOfWork;
        }
        public void AddProductoCategoria()
        {
            Console.WriteLine("Por favor ingrese los siguientes datos para agregar un Producto a una Categoria:\n");
            Console.WriteLine("Codigo Producto:");
            string codigo = Console.ReadLine();
            Console.WriteLine("Categoria:");
            foreach (var cat in _unitOfWork.Categorias.GetAll())
            {
                Console.WriteLine($"- {cat.Descripcion}");
            }
            string descripcion_categoria = Console.ReadLine();
            ErpProducto erp_producto = _unitOfWork.ErpProductos.GetByCodigo(codigo);
            //Console.WriteLine(erp_producto.IdProducto);
            ExpProducto exp_producto = _unitOfWork.ExpProductos.GetExpProductobyId(erp_producto.IdProducto);
            Categoria categoria = _unitOfWork.Categorias.GetByDescripcion(descripcion_categoria);
            //Console.WriteLine(categoria.IdCategoria);
            ProductosCategorias producto_categoria = new ProductosCategorias
            {
                FechaCreacion = DateTime.Now,
                ExpProducto = exp_producto,
                Categoria = categoria
            };
            _unitOfWork.Productos_Categorias.Add(producto_categoria);
            _unitOfWork.Complete();
            Console.WriteLine("Producto añadido a Categoria con exito!");

        }
    }
}
