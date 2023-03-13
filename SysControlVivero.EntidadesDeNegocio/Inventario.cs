using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SysControlVivero.EntidadesDeNegocio
{
    public class Inventario
    {
        public int Id { get; set; }
        public int CodProducto { get; set; }
        public string Descripcion { get; set; }
        public int ExistenciasMesAnterior { get; set; }
        public int Entradas { get; set; }
        public int Salidas { get; set; }
        public int Stock { get; set; }

            public List<Producto> productos { get; set; }
    }
}
