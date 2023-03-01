using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SysControlVivero.EntidadesDeNegocio
{
    public class DetalleDeVenta
    {
        public int Cantidad { get; set; }
        public decimal Descuento { get; set; }
        public string FormaDePago { get; set; }
        public decimal VentaNoSujeta { get; set; }
        public decimal VentaExenta { get; set; }

          public List<Producto> productos { get; set; }
          public List<Factura> facturas { get; set; }

    }
}
