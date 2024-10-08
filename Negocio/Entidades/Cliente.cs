using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TPGrupo4.Clases
{
    class Cliente
    {
        [MaxLength(20)]
        [Required]
        public string usuario { get; set; }

        [MaxLength(20)]
        [Required]
        public string contrasenia { get; set; }
        // con este atributo evitamos que la clave de la clase sea autonumerada
        [Key, DatabaseGenerated(DatabaseGeneratedOption.None)]
        public string dni { get; set; }

        [MaxLength(20)]
        [Required]
        public string nombreCompleto { get; set; }

        [MaxLength(20)]
        [Required]
        public Domicilio domicilio { get; set; }
    }
}
