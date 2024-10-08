using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TPGrupo4.Clases
{
    class Objeto
    {

        [Key, DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int idObjeto { get; set; }

        [MaxLength(50)]
        [Required]
        public string Nombre { get; set; }

        [Required]
        public int Id { get; set; }

        [MaxLength(30)]
        [Required]
        public string Marca { get; set; }

        [Range(0.01, double.MaxValue)]
        [Required]
        public double Precio { get; set; }
    }

}
