using ClaseObjetos2.ClasePadre;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClaseObjetos2.ClaseHija
{
    internal class Xbox:clsConsola
    {
        public string movivimiento { get; set; }
        public string mostrardetalleXbox()
        {
            return mostrarDetalles() + " Xbox 360 tiene kineckt:" + movivimiento;
        }
    }
}
