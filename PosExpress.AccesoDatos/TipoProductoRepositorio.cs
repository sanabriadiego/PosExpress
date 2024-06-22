using Microsoft.EntityFrameworkCore.Infrastructure.Internal;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection.Metadata.Ecma335;
using System.Text;
using System.Threading.Tasks;

namespace PosExpress.AccesoDatos
{
    public class TipoProductoRepositorio
    {
        private readonly AppDbContext _context;

        public TipoProductoRepositorio()
        {
            _context = new AppDbContext();
        }

        public void Add(Entidades.TipoProducto tipo_producto)
        {
            _context.TiposProducto.Add(tipo_producto);
            _context.SaveChanges();
        }

        public IEnumerable<Entidades.TipoProducto> GetAll()
        {
            return _context.TiposProducto.ToList();
        }

        public Entidades.TipoProducto GetById(int tipo_productoId)
        {
            return _context.TiposProducto
                .FirstOrDefault(tp => tp.IdTipoProducto == tipo_productoId);
        }
    }
}
