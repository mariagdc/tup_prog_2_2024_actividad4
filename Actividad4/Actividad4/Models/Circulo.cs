using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Actividad4.Models
{
    internal class Circulo:IFigura
    {
        public double Radio { get; set; }

        public Circulo(double Radio)
        { }
        public double calcularArea()
        { 
            double res = Math.PI * Radio;
            return res;
        }
        public double calcularPerimetro()
        {
            double res;
            double diametro = 2 * Radio;
            res= Math.PI * Radio;
            return res;
        }

        public override string ToString()
        {
            return $"Círculo:{calcularArea():f2}"; //es igual a escribir figura.ToString
        }
    }
}
