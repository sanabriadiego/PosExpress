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
        }

        public ITipoProductoRepositorio TiposProducto { get; private set; }

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
