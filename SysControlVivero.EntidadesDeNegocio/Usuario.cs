using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SysControlVivero.EntidadesDeNegocio
{
    public class Usuario
    {
        
        [Key]
        public int Id { get; set; }
        [ForeignKey("Rol")]
        [Required(ErrorMessage ="Rol es obligatorio")]
        public int IdRol { get; set; }
        [ForeignKey("Empleado")]
        [Required(ErrorMessage = "Empleado es obligatorio")]
        public int IdEmpleado { get; set; }

        [Required(ErrorMessage ="Nombre es hobligatorio")]
        [StringLength(50,ErrorMessage ="Maximo 50 caracteres")]
        public string? Nombre { get; set; }
        [Required(ErrorMessage ="este campo es obligatorio")]
        [StringLength(50,ErrorMessage ="maximo 8 caracteres",MinimumLength =8)]
        private string? Clave { get; set; }
  

        public Rol? rol { get; set; }
        public Empleado? empleados { get; set; }
    }
}
