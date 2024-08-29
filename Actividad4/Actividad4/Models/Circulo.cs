using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Actividad4.Models
{
    internal class Circulo:Figura
    {
        public double Radio { get; set; }

        public Circulo(double Radio)
        { }
        public override double calcularArea()
        { 
            double res = Math.PI * Radio;
            return res;
        }
        public override double calcularPerimetro()
        {
            double res;
            double diametro = 2 * Radio;
            res= Math.PI * Radio;
            return res;
        }
    }
}
