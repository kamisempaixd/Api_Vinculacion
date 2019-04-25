using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Api_Vinculacion.Modelos
{
    public class Ficha
    {
        public int NumFichaId { get; set; }
        public string Provincia { get; set; }
        public string Canton { get; set; }
        public string Parroquia { get; set; }
        public string Barrio { get; set; }
        public string Dirrecion { get; set; }
        public string ReferenciaDom { get; set; }
        //foreign key
        public int EstudianteId { get; set; }
    }
}
