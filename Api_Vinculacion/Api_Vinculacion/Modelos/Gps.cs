using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Api_Vinculacion.Modelos
{
    public class Gps
    {

        public int idgps { get; set; }
        public string Longitud { get; set; }
        public string Latitud { get; set; }
        //foreing key
        public int NumFichaId { get; set; }
        //Tabla
        public Ficha fichas { get; set; }
    }
}
