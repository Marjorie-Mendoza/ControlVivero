using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SysControlVivero.EntidadesDeNegocio
{
    public class Rol
    {
        public int Cod { get; set; }
        public string Nombre { get; set; }
        public int Nivel { get; set; }

           public List<Rol> rols { get; set; }
    }
}
