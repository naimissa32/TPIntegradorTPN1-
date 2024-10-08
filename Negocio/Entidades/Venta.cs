using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TPGrupo4.Clases
{
    class Venta
    {
        public int cantObjeto { get; set; }
        public string fechaCompra { get; set; }
        public Cliente comprador { get; set; }
        public Cliente vendedor { get; set; }
        public Objeto item { get; set; }
        public MedioPagoEnum medioPago { get; set; }
    }
}
