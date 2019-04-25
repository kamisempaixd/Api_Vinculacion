using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Api_Vinculacion.Modelos
{
    public class Respuesta
    {
        public int IdRespuesta { get; set; }
        public string Respu { get; set; }
        //foreing key
        public int IdPregunta { get; set; }
        //Tabla
        public Pregunta preguntas { get; set; }
    }
}
