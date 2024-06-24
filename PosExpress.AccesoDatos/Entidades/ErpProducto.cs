using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PosExpress.AccesoDatos.Entidades
{
    public class ErpProducto
    {
        [ForeignKey("ExpProducto")]
        public int IdProducto { get; set; }
        public decimal Costo { get; set; }
        public string UniqueCodigo { get; set; }
        public DateTime FechaRegistro { get; set; }
        public int Stock {  get; set; }
        public virtual ExpProducto ExpProducto { get; set; }

    }
}
