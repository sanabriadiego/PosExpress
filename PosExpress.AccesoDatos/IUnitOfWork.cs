﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PosExpress.AccesoDatos
{
    public interface IUnitOfWork : IDisposable
    {
        ITipoProductoRepositorio TiposProducto { get; }
        int Complete();
    }
}