using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PosExpress.LogicadeNegocio
{
    public class CodigoUnicoServicio { 
        public string GenerarCodigoUnico()
        {
            return Guid.NewGuid().ToString("N");
        }

        public string GenerarCodigoBarras()
        {
            Random random = new Random();
            string codigo = random.Next(0, 1000000000).ToString("D9") + random.Next(0, 1000).ToString("D3");
            return codigo;
        }
    }
}
