using PosExpress.AccesoDatos;
using PosExpress.AccesoDatos.Entidades;
using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PosExpress.LogicadeNegocio
{
    public class ErpProductoServicio : IErpProductoServicio
    {
        private readonly IUnitOfWork _unitOfWork;

        public ErpProductoServicio(IUnitOfWork unitOfWork)
        {
            _unitOfWork = unitOfWork;
        }

        CodigoUnicoServicio codigo = new CodigoUnicoServicio();

        public void AddProducto()
        {
            Console.WriteLine("Por favor ingrese los siguientes datos para el Producto:\n");
            Console.WriteLine("Nombre:");
            string nombre = Console.ReadLine();
            Console.WriteLine("Asigne el tipo de Producto");
            foreach (var tipo in _unitOfWork.TiposProducto.GetAll())
            {
                Console.WriteLine($"- {tipo.Descripcion}");
            }
            string tipo_producto = Console.ReadLine();
            Console.WriteLine("Costo:");
            string costo = Console.ReadLine();
            Console.WriteLine("Fecha de Vencimiento:");
            string fecha_vencimiento = Console.ReadLine();
            Console.WriteLine("Stock:");
            string stock = Console.ReadLine();
            Console.WriteLine("Observaciones:");
            string observaciones = Console.ReadLine();

            decimal precio;
            if(GlobalGanamax.ganamax)
            {
                precio = Convert.ToDecimal(costo) * 1.8m;
            }
            else
            {
                precio = Convert.ToDecimal(costo) * 1.5m;
            }

            ExpProducto exp_producto = new ExpProducto 
            {
                Nombre = nombre,
                Precio = precio,
                Fecha_Vencimiento = DateOnly.Parse(fecha_vencimiento),
                Observaciones = observaciones,
                TipoProducto = _unitOfWork.TiposProducto.GetByDescripcion(tipo_producto)
            };

            ErpProducto erp_producto = new ErpProducto();
            erp_producto.ExpProducto = exp_producto;
            erp_producto.Costo = Convert.ToDecimal(costo);
            erp_producto.UniqueCodigo = codigo.GenerarCodigoUnico();
            erp_producto.FechaRegistro = DateTime.Now;
            erp_producto.Stock = Int32.Parse(stock);
            
            CodigoBarras codigo_barras =  new CodigoBarras();
            codigo_barras.UniqueCodigo = codigo.GenerarCodigoBarras();
            codigo_barras.ExpProducto = exp_producto;

            _unitOfWork.ErpProductos.Add(erp_producto, codigo_barras);
            _unitOfWork.Complete();
            Console.WriteLine("Producto creado con exito!");
           
        }
    }
}
