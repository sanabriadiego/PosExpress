﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PosExpress.AccesoDatos.Entidades
{
    public class CodigoBarras
    {
        public int IdCodigoBarra { get; set; }
        public string UniqueCodigo {  get; set; }
        public bool Activo { get; set; } = true;
        public ExpProducto ExpProducto { get; set; }

    }
}
