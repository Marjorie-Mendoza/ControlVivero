using SysControlVivero.EntidadesDeNegocio;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SysControlVivero.AccesoADatos
{
    public class CategoriaDAL
    {
        public int AgregarCategoria(List<Categoria> ListaCategoria, Categoria pcategoria)
        {
            ListaCategoria.Add(pcategoria);
            return 1;
        }
        public List<Categoria> MostrarCategoria(List<Categoria> ListaCategoria)
        {
            return ListaCategoria;
        }
        public int ModificarCategoria(List<Categoria> ListaCategoria, int id, Categoria pCategoria)
        {
            if (id != 0)
            {
                Categoria? CategoriaBuscada = ListaCategoria.Where(c => c.Id == id).FirstOrDefault();
                if (CategoriaBuscada != null)
                {
                    CategoriaBuscada.Id = pCategoria.Id;
                    CategoriaBuscada.Nombre = pCategoria.Nombre;
                    CategoriaBuscada.Descripcion = pCategoria.Descripcion;
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
        public int EliminarCategoria(List<Categoria> ListaCategoria, int id)
        {
            if (id != 0)
            {
                Categoria? CategoriaBuscada = ListaCategoria.Where(c => c.Id == id).FirstOrDefault();
                if (CategoriaBuscada != null)
                {
                    ListaCategoria.Remove(CategoriaBuscada);
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
