using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TPGrupo4.Clases
{
    class Venta

    {
        [Key, DatabaseGenerated(DatabaseGeneratedOption.None)]

        public int idVenta { get; set; }

        [Range(1, int.MaxValue)]
        [Required]
        public int cantObjeto { get; set; }

        [Required]

        public string fechaCompra { get; set; }

        [Required]

        public Cliente comprador { get; set; }

        [Required]

        public Cliente vendedor { get; set; }

        [Required]

        public Objeto item { get; set; }

        [Required]

        public MedioPagoEnum medioPago { get; set; }


        [Required]


        public double precioTotal { get; set; }

   
}
}
