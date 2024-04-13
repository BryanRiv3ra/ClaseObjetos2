using ClaseObjetos2.ClasePadre;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClaseObjetos2.ClaseHija
{
    internal class SegaDreamcast:clsConsola
    {
        public string compatibilidad { get; set; }
        public string mostrardetallesdreamcast()
        {
            return mostrarDetalles() + " la dream cast teiene varias compatibilidades:" + compatibilidad;
        }
    }
}
