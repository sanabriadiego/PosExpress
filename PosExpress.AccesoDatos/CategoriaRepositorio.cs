﻿using PosExpress.AccesoDatos.Entidades;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PosExpress.AccesoDatos
{
    public class CategoriaRepositorio : ICategoriaRepositorio
    {
        private readonly AppDbContext _context;

        public CategoriaRepositorio(AppDbContext context)
        {
            _context = context;
        }

        public void Add(Categoria categoria)
        {
            _context.Categorias.Add(categoria);
        }

        public IEnumerable<Categoria> GetAll()
        {
            return _context.Categorias.ToList();
        }
    }
}
