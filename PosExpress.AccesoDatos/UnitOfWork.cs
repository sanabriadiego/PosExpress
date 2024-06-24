using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PosExpress.AccesoDatos
{
    public class UnitOfWork : IUnitOfWork
    {
        private readonly AppDbContext _context;

        public UnitOfWork(AppDbContext context)
        {
            _context = context;
            TiposProducto = new TipoProductoRepositorio(_context);
            Categorias = new CategoriaRepositorio(_context);
            ErpProductos = new ErpProductoRepositorio(_context);
            VentaExpress = new VentaExpressRepositorio(_context);
            ExpProductos = new ExpProductoRepositorio(_context);
            Productos_Categorias = new ProductosCategoriasRepositorio(_context);

        }

        public ITipoProductoRepositorio TiposProducto { get; private set; }
        public ICategoriaRepositorio Categorias { get; private set; }

        public IErpProductoRepositorio ErpProductos { get; private set; }

        public IVentaExpressRepositorio VentaExpress {  get; private set; }

        public IExpProductoRepositorio ExpProductos { get; private set; }
        public IProductosCategoriasRepositorio Productos_Categorias { get; private set; }

        public int Complete() 
        {
            return _context.SaveChanges();
        }

        public void Dispose() 
        { 
            _context.Dispose();
        }
    }
}
