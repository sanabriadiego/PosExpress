using PosExpress.AccesoDatos;
using PosExpress.AccesoDatos.Entidades;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PosExpress.LogicadeNegocio
{
    public class TipoProductoServicio : ITipoProductoServicio
    {
        private readonly IUnitOfWork _unitOfWork;

        public TipoProductoServicio(IUnitOfWork unitOfWork)
        {
            _unitOfWork = unitOfWork;
        }

        public void AddTipoProducto()
        {
            Console.WriteLine("Por favor ingrese una descripcion del nuevo tipo de producto: ");
            string descripcion = Console.ReadLine();
            TipoProducto tipo_producto = new TipoProducto();
            tipo_producto.Descripcion = descripcion;
            _unitOfWork.TiposProducto.Add(tipo_producto);
            _unitOfWork.Complete();
            Console.WriteLine("Tipo Producto creado!");
        }

        public void GetProducts()
        {
            foreach (var tipo in _unitOfWork.TiposProducto.GetAll())
            {
                Console.WriteLine($"ID: {tipo.IdTipoProducto}, Descripción: {tipo.Descripcion}");
            }
        }

        public TipoProducto GetTipoProducto(int tipo_productoId)
        {
            return _unitOfWork.TiposProducto.GetById(tipo_productoId);
        }
    }
}
