using PosExpress.AccesoDatos.Entidades;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PosExpress.AccesoDatos
{
    public interface IErpProductoRepositorio
    {
        void Add(ErpProducto erp_producto, CodigoBarras codigo_barras);
        public IEnumerable<ErpProducto> GetAll();

        public ErpProducto GetByCodigo(string codigo_producto);
    }
}
