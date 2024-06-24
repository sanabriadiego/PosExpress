using PosExpress.AccesoDatos.Entidades;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PosExpress.AccesoDatos
{
    public class ErpProductoRepositorio : IErpProductoRepositorio
    {
        private readonly AppDbContext _context;

        public ErpProductoRepositorio(AppDbContext context)
        {
            _context = context;
        }

        public void Add(ErpProducto erp_producto, CodigoBarras codigo_barras)
        {

            _context.ErpProductos.Add(erp_producto);
            Console.WriteLine("ProductoERP Añadido");
            _context.CodigosBarras.Add(codigo_barras);
            Console.WriteLine("Codigo de Barras Añadido");

        }
        public IEnumerable<ErpProducto> GetAll()
        {
            return _context.ErpProductos.ToList();
        }
        public ErpProducto GetByCodigo(string codigo_producto) 
        {
            return _context.ErpProductos.SingleOrDefault(c => c.UniqueCodigo == codigo_producto);
        }
        
    }
}
