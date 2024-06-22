using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using PosExpress.AccesoDatos;
using PosExpress.AccesoDatos.Entidades;
using static PosExpress.AccesoDatos.ExpProductoRepositorio;

namespace PosExpress.LogicadeNegocio
{
    public class ExpProductoServicios
    {
        private readonly ExpProductoRepositorio _repository;

        public ExpProductoServicios()
        {
            _repository = new ExpProductoRepositorio();
        }

        public void AddProduct(ExpProducto product)
        {
            _repository.Add(product);
        }

        //public IEnumerable<Product> GetProducts()
        //{
        //    return _repository.GetAll();
        //}

        //public void UpdateProduct(Product product)
        //{
        //    _repository.Update(product);
        //}

        //public void DeleteProduct(int productId)
        //{
        //    _repository.Delete(productId);
        //}
    }
}
