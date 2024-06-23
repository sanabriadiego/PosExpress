using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PosExpress.AccesoDatos.Entidades
{
    public class ProductosCategorias
    {
        public int IdDetalle {  get; set; }
        public DateTime FechaCreacion { get; set; }
        public ExpProducto ExpProducto { get; set; }
        public Categoria Categoria { get; set; }


    }
}
