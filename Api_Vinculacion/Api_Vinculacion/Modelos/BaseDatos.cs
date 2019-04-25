using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Api_Vinculacion.Modelos
{
    public class BaseDatos:DbContext
    {
        public BaseDatos(DbContextOptions basedatos):base (basedatos)
        {

        }
    }
}
