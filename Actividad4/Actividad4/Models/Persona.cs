using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Actividad4.Models
{
    internal class Persona
    {
        public int DNI { get; set; }
        public string Nombre { get; set; }

        public Persona(int DNI, string Nombre)
        { 
            this.DNI = DNI;
            this.Nombre = Nombre;
        }



       

    }
}
