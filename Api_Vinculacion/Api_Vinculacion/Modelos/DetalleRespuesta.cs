using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Api_Vinculacion.Modelos
{
    public class DetalleRespuesta
    {
        public int DetalleRespuestaId { get; set; }
        //foreing key
        public int NumFichaId { get; set; }
        //tabla
        public Ficha fichas { get; set; }
        //foreing key
        public int IdRespuesta { get; set; }
        //tabla
        public Respuesta respuestas { get; set; }
    }
}
