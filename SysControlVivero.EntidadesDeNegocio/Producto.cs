using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SysControlVivero.EntidadesDeNegocio
{
    internal class Producto
    {
        public int Cod { get; set; }
        public string Nombre { get; set; }
        public string Descripcion { get; set; }
        public int FechaVencimiento { get; set; }
        public decimal Precio { get; set; }
   

        public Categoria categoria { get; set; }
    }

}
