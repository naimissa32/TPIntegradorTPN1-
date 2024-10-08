using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TPGrupo4.Clases
{
    class Cliente
    {
        public string usuario { get; set; }
        public string contrasenia { get; set; }
        public string dni { get; set; }
        public string nombreCOmpleto { get; set; }
        public Domicilio domicilio { get; set; }
    }
}
