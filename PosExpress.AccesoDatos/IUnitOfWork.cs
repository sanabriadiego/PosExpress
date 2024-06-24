using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PosExpress.AccesoDatos
{
    public interface IUnitOfWork : IDisposable
    {
        ITipoProductoRepositorio TiposProducto { get; }
        ICategoriaRepositorio Categorias {  get; }
        IErpProductoRepositorio ErpProductos { get; }
        IVentaExpressRepositorio VentaExpress {  get; }
        IExpProductoRepositorio ExpProductos { get; }
        IProductosCategoriasRepositorio Productos_Categorias { get;  }
        int Complete();
    }
}
