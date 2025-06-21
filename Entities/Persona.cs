using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejemplodeifelse2.Entities
{
    public class Persona
    {
        [Key]
        public int PKPersona { get; set; }
        public string Nombre { get; set; }
        public string Apellido { get; set; }
        public string Correo { get; set; }
        public int edad { get; set; }

        [ForeignKey("Ciudades")]

        public int FKCiudad {get; set;}  
        public Ciudad Ciudades { get; set; }
    }
}
