using PosExpress.AccesoDatos.Entidades;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PosExpress.AccesoDatos
{
    public class ExpProductoRepositorio : IExpProductoRepositorio
    {
        private readonly AppDbContext _context;

        public ExpProductoRepositorio(AppDbContext context)
        {
            _context = context;
        }

        public ExpProducto GetExpProductobyId(int id) 
        {
            return _context.ExpProductos.Find(id);
        }
    }
}
