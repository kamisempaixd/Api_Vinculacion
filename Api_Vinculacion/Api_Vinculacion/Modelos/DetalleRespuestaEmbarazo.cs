using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Api_Vinculacion.Modelos
{
    public class DetalleRespuestaEmbarazo
    {
        public int DetalleRespuestaEmbarazoId { get; set; }
        //foreing key
        public int NumFichaId { get; set; }
        //Tabla
        public Ficha fichas { get; set; }
        //foreing key
        public int IdRespuesta { get; set; }
        //Tabla
        public Respuesta respuestas { get; set; }
    }
}
