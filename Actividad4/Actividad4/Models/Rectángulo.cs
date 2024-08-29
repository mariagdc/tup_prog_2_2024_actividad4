using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Actividad4.Models
{
    internal class Rectángulo:IFigura
    {
        public double LadoA { get; set; }
        public double LadoB { get; set; }

        public Rectángulo(double ladoA, double ladoB)
        {
            LadoA = ladoA;
            LadoB = ladoB;
        }
        public double calcularArea() //double bas, double altura
        {
            double area = LadoA * LadoB;
            return area;
        }
        public double calcularPerimetro() 
        {
            double peri = (LadoA * 2) + (LadoB * 2);
            return peri;
        }

        public override string ToString()
        {
            return $"Rectángulo:{calcularArea():f2}"; //es igual a escribir figura.ToString
        }

    } 
}
