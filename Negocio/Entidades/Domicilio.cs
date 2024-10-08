using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TPGrupo4.Clases
{
    class Domicilio
    {
        [MaxLength(50)]
        [Required]
        [Key, DatabaseGenerated(DatabaseGeneratedOption.None)]
        public string Calle { get; set; }

   
        [Range(1000, 9999)]
        [Required]
        public int CodigoPostal { get; set; }

        [Required]
        public bool EsCasa { get; set; }
    }
}
