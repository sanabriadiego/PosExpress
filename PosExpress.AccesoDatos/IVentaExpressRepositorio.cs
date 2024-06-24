using PosExpress.AccesoDatos.Entidades;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PosExpress.AccesoDatos
{
    public interface IVentaExpressRepositorio
    {
        void Add(VentaExpress venta);
    }
}
