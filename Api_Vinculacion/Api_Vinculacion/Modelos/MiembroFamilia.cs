using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Api_Vinculacion.Modelos
{
    public class MiembroFamilia
    {
        public int IdMiembroFam { get; set; }
        public int Edad { get; set; }
        public string Sexo { get; set; }
        public string Embarazo { get; set; }
        //Foreing key
        public int IdFamilia { get; set; }
        //Tabla
        public Familia familias { get; set; }
        //foreing key
        public int IdRangoEdad { get; set; }
        //Tabla
        public RangoEdad rangoedades { get; set; }
    }
}
