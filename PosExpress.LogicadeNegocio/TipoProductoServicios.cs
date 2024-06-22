using PosExpress.AccesoDatos;
using PosExpress.AccesoDatos.Entidades;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static PosExpress.AccesoDatos.ExpProductoRepositorio;

namespace PosExpress.LogicadeNegocio
{
    public class TipoProductoServicios
    {
        private readonly TipoProductoRepositorio _repository;

        public TipoProductoServicios()
        {
            _repository = new TipoProductoRepositorio();
        }

        public void AddTipoProducto(TipoProducto tipo_producto)
        {
            _repository.Add(tipo_producto);
        }

        public IEnumerable<TipoProducto> GetProducts()
        {
            return _repository.GetAll();
        }

        public TipoProducto GetTipoProducto(int tipo_productoId)
        {
            return _repository.GetById(tipo_productoId);
        }
    }
}
