using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Api_Vinculacion.Modelos
{
    public class Familiograma
    {
        public int FamiliogramaId { get; set; }
        public int Foto { get; set; }
        //foreing key
        public int NumFichaId { get; set; }
        //Tabla
        public Ficha fichas { get; set; }
    }
}
