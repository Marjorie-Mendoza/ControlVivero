using SysControlVivero.EntidadesDeNegocio;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SysControlVivero.AccesoADatos
{
    public class InventarioDAL
    {
        //life goes ON like this 
        public int AgregarInventario(List<Inventario> ListaInventario, Inventario pInventario)
        {
            ListaInventario.Add(pInventario);
            return 1;
        }
        public List<Inventario> Inventario(List<Inventario> ListaInventario)
        {
            return ListaInventario;
        }

        public int ModificarInventario(List<Inventario> ListaInventario, int id, Inventario pInventario)
        {
            if (id != 0)
            {
                //aqui se busca el Inventario que quiero modificar
                Inventario InventarioBuscado = ListaInventario.Where(c => c.IdInventario == id).FirstOrDefault();
                if (InventarioBuscado != null)
                {
                    InventarioBuscado.IdInventario = pInventario.IdInventario;
                    InventarioBuscado.CodProducto = pInventario.CodProducto;
                    InventarioBuscado.Descripcion = pInventario.Descripcion;
                    InventarioBuscado.ExistenciasMesAnterior = pInventario.ExistenciasMesAnterior;
                    InventarioBuscado.Entradas = pInventario.Entradas;
                    InventarioBuscado.Salidas = pInventario.Salidas;
                    InventarioBuscado.Stock = pInventario.Stock;
                    return 1;
                }
                else
                {
                    return 0;
                }
            }
            else
            {
                return 0;
            }
        }
    }
}
