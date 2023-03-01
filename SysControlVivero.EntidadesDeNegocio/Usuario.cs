using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SysControlVivero.EntidadesDeNegocio
{
    public class Usuario
    {
        public int Cod { get; set; }
        public string Nombre { get; set; }
        private string Clave { get; set; }

           public Rol rol { get; set; }
        public Empleado empleados { get; set; }
    }
}
