using ClaseObjetos2.ClasePadre;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClaseObjetos2.ClaseHija
{
    internal class Playstation:clsConsola
    {
        public string modelocontrolador { get; set; }
        public string mostrardetalleplay()
        {
            return mostrarDetalles() + " controlador:" + modelocontrolador;
        }
    }
}
