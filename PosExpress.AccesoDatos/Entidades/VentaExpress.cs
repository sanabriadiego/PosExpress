using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PosExpress.AccesoDatos.Entidades
{
    public class VentaExpress
    {
        public int Id { get; set; }
        public DateTime Fecha { get; set; }
        public string Cliente { get; set; }
        public string Producto { get; set; }
        public int UniqueProducto { get; set; }
        public int Cantidad { get; set; }
        public decimal Precio { get; set; }
        public decimal Descuento { get; set; }
        public decimal Total { get; set; }
        public ExpProducto ExpProducto { get; set; }

    }
}
