using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PosExpress.AccesoDatos
{
    public class ExpProductoRepositorio
    {
        private readonly AppDbContext _context;

        public ExpProductoRepositorio()
        {
            _context = new AppDbContext();
        }

        public void Add(Entidades.ExpProducto product)
        {
            _context.ExpProductos.Add(product);
            _context.SaveChanges();
        }

        //public IEnumerable<Product> GetAll()
        //{
        //    return _context.Products.ToList();
        //}

        //public void Update(Product product)
        //{
        //    _context.Products.Update(product);
        //    _context.SaveChanges();
        //}

        //public void Delete(int productId)
        //{
        //    var product = _context.Products.Find(productId);
        //    if (product != null)
        //    {
        //        _context.Products.Remove(product);
        //        _context.SaveChanges();
        //    }
        //}
    }
}
