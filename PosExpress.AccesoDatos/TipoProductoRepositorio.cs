﻿using Microsoft.EntityFrameworkCore.Infrastructure.Internal;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection.Metadata.Ecma335;
using System.Text;
using System.Threading.Tasks;
using PosExpress.AccesoDatos.Entidades;

namespace PosExpress.AccesoDatos
{
    public class TipoProductoRepositorio : ITipoProductoRepositorio
    {
        private readonly AppDbContext _context;

        public TipoProductoRepositorio(AppDbContext context)
        {
            _context = context;
        }

        public void Add(TipoProducto tipo_producto)
        {
            _context.TiposProducto.Add(tipo_producto);
        }

        public IEnumerable<TipoProducto> GetAll()
        {
            return _context.TiposProducto.ToList();
        }

        public TipoProducto GetById(int tipo_productoId)
        {
            return _context.TiposProducto
                .FirstOrDefault(tp => tp.IdTipoProducto == tipo_productoId);
        }
    }
}
