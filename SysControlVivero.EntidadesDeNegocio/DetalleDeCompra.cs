using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SysControlVivero.EntidadesDeNegocio
{
    public class DetalleDeCompra
    {
        public DateTime fecha { get; set; }
        public string NombreEmpresa { get; set; }
        public int cantidad { get; set; }
        public string descripcion { get; set; }
        public decimal precioTotal { get; set; }

          public List<Producto> productos { get; set; }
    }
}
