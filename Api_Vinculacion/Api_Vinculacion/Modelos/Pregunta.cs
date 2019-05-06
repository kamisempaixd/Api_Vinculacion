using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Api_Vinculacion.Modelos
{
    public class Pregunta
    {
        public int PreguntaId { get; set; }
        public string Pregun { get; set; }
        //foreing key
        public int IdSeccion { get; set; }
        //Tabla
        public  Seccion secciones { get; set; }
    }
}
