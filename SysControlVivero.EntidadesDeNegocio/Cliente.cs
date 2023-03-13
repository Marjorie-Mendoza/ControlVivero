using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SysControlVivero.EntidadesDeNegocio
{
    public class Cliente
    {
        public int Id { get; set; }
        public string DUI { get; set; }
        public string Nombre { get; set; }
        private string Direccion { get; set; }
        private string Telefono { get; set; }

          public List<Factura> facturas { get; set; }
    }
}
