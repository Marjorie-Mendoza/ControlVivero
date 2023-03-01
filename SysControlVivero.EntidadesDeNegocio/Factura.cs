using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SysControlVivero.EntidadesDeNegocio
{
    public class Factura
    {
        public int Numero { get; set; }
        public DateTime Fecha { get; set;}
        public string Dirrecion { get; set;}
        public string Telefono { get; set;}
        public string DUI { get; set;}
        public string Sumas { get; set;}
        public decimal VentaTotal { get; set;}

          public Cliente cliente { get; set;}
          public Empleado empleado { get; set;}

          public DetalleDeVenta detalledeventa { get; set;}

    }
}
