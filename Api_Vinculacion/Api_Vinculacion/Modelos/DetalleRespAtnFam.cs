using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Api_Vinculacion.Modelos
{
    public class DetalleRespAtnFam
    {
        public int IdDRAF { get; set; }
        public string Descripcion { get; set; }
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
