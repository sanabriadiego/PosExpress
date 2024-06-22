using PosExpress.AccesoDatos.Entidades;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PosExpress.LogicadeNegocio
{
    public interface ITipoProductoServicio
    {
        void AddTipoProducto();
        void GetProducts();
        TipoProducto GetTipoProducto(int tipo_productoId);
    }
}
