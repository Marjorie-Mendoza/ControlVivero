using SysControlVivero.EntidadesDeNegocio;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SysControlVivero.AccesoADatos
{
    public class EmpleadoDAL
    {
        public int AgregarEmpleado(List<Empleado> ListaEmpelado, Empleado pEmpleado)
        {
            ListaEmpelado.Add(pEmpleado);
            return 1;
        }
        public List<Empleado> MostrarEmpleado(List<Empleado> ListaEmpleado)
        {
            return ListaEmpleado;
        }
        public int ModificarEmpleado(List<Empleado> ListaEmpleado, int id, Empleado pEmpleado)
        {
            if (id != 0)
            {
                Empleado? EmpleadoBuscado = ListaEmpleado.Where(c => c.IdEmpleado == id).FirstOrDefault();
                if (EmpleadoBuscado != null)
                {
                    EmpleadoBuscado.IdEmpleado = pEmpleado.IdEmpleado;
                    EmpleadoBuscado.Nombre = pEmpleado.Nombre;
                    EmpleadoBuscado.Cargo = pEmpleado.Cargo;
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
        public int EliminarEmpleado(List<Empleado> ListaEmpleado, int id)
        {
            if (id != 0)
            {
                Empleado? EmpleadoBuscado = ListaEmpleado.Where(c => c.IdEmpleado == id).FirstOrDefault();
                if (EmpleadoBuscado != null)
                {
                    ListaEmpleado.Remove(EmpleadoBuscado);
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


