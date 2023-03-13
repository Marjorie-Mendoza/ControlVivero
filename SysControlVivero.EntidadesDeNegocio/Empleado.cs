using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SysControlVivero.EntidadesDeNegocio
{
     public class Empleado
    {
        public int Id { get; set; }
        public string Nombre { get; set; }
        public string Correo { get; set; }
        private string DUI { get; set; }
        private string Direccion { get; set; }
        public string Cargo { get; set; }

           public List<Factura> facturas { get; set; }
    }
}
