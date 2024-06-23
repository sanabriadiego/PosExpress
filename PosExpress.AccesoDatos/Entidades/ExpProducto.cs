using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PosExpress.AccesoDatos.Entidades
{
    public class ExpProducto
    {
        public int IdProducto { get; set; }
        public string Nombre { get; set; }
        public decimal Precio { get; set;}
        public bool Activo { get; set; }
        public DateOnly Fecha_Vencimiento { get; set; }
        public string Observaciones { get; set; }
        public TipoProducto TipoProducto { get; set; }
        public ICollection<ProductosCategorias> ProductosCategorias { get; set; }
        public virtual ErpProducto ErpProducto { get; set; }

    }
}
