using PosExpress.AccesoDatos.Entidades;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PosExpress.AccesoDatos
{
    public interface IProductosCategoriasRepositorio
    {
        void Add(ProductosCategorias producto_categoria);
        int ProdCat_RelationQty(int id_producto);
    }
}
