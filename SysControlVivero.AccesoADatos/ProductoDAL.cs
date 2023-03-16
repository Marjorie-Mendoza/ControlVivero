using SysControlVivero.EntidadesDeNegocio;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace SysControlVivero.AccesoADatos
{
    public class ProductoDAL
    {
        public int AgregarProducto(List<Producto> ListaProducto, Producto pProducto)
        {
            ListaProducto.Add(pProducto);
            return 1;
        }
        public List<Producto> MostrarProducto(List<Producto> ListaProducto)
        {
            return ListaProducto;
        }
        public int ModificarProducto(List<Producto> ListaProducto, int id, Producto pProducto)
        {
            if (id != 0)
            {
                //aqui se busca el Producto que quiero modificar
                Producto? ProductoBuscado = ListaProducto.Where(c => c.IdProducto == id).FirstOrDefault();
                if (ProductoBuscado != null)
                {
                    ProductoBuscado.IdProducto = pProducto.IdProducto;
                    ProductoBuscado.CodProducto = pProducto.CodProducto;
                    ProductoBuscado.Nombre = pProducto.Nombre;
                    ProductoBuscado.Descripcion = pProducto.Descripcion;
                    ProductoBuscado.FechaVencimiento = pProducto.FechaVencimiento;
                    ProductoBuscado.Precio = pProducto.Precio;
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
        //FOREVER WE ARE YOUNG 
        public int EliminarProducto(List<Producto> ListaProducto, int id)
        {
            if (id != 0)
            {
                //aqui se busca el Producto que quiero eliminar
                Producto? ProductoBuscado = ListaProducto.Where(c => c.IdProducto == id).FirstOrDefault();
                if (ProductoBuscado != null)
                {
                    ListaProducto.Remove(ProductoBuscado);
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
