using ClaseObjetos2.ClasePadre;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClaseObjetos2.ClaseHija
{
    internal class Nintendo:clsConsola
    {
        public bool esPortable { get; set; }
        public string MostrarDeatallesNintendo()
        {
            string detallepadre = mostrarDetalles();
            return detallepadre + " Es portable:" + esPortable;

        }
    }
}
