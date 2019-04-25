using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Api_Vinculacion.Modelos
{
    public class Familia
    {
        public int idFamilia { get; set; }
        public int CantidadIntegrantes { get; set; }
        //Foreing Key
        public int NumFichaId { get; set; }
        //Tabla
        public Ficha fichas { get; set; }
    }
}
