using PosExpress.AccesoDatos.Entidades;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PosExpress.AccesoDatos
{
    public class VentaExpressRepositorio : IVentaExpressRepositorio
    {
        private readonly AppDbContext _context;

        public VentaExpressRepositorio(AppDbContext context)
        {
            _context = context;
        }

        public void Add(VentaExpress venta)
        {
            _context.Add(venta);
        }
    }
}
