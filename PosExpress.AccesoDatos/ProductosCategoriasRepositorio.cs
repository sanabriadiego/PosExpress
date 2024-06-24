using PosExpress.AccesoDatos.Entidades;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PosExpress.AccesoDatos
{
    public class ProductosCategoriasRepositorio : IProductosCategoriasRepositorio
    {
        private readonly AppDbContext _context;

        public ProductosCategoriasRepositorio(AppDbContext context)
        {
            _context = context;
        }
        public void Add(ProductosCategorias producto_categoria) 
        {
            _context.Add(producto_categoria);
        }
        public int ProdCat_RelationQty(int id_producto)
        {
            return _context.ProductosCategorias.Count(pc => pc.ExpProducto.IdProducto == id_producto);
        }
    }
}
