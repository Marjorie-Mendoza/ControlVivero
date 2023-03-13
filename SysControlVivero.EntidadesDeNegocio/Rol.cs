using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace SysControlVivero.EntidadesDeNegocio
{
    public class Rol
    {        
        public int Id { get; set; }

        [Required(ErrorMessage = "Nombre es obligatorio")]
        [StringLength(20,ErrorMessage = "Maximo 50 caracteres")]
        public string Nombre { get; set; }

        [Required(ErrorMessage = "Especificar el número de nivel")]
        public int Nivel { get; set; }
           public List<Usuario> usuarios { get; set; }
    }
}
