using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClaseObjetos2.ClasePadre
{
    internal class clsConsola
    {
        public int aniolanzamiento { get; set; }
        public string marca { get; set; }
        public string mostrarDetalles()
        {
            return ($"Marca:{marca} Año {aniolanzamiento}");
        }
    }
}
