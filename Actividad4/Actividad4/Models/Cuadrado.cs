using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Actividad4.Models
{
    internal class Cuadrado : Rectángulo
    {
        public double Lado { get; set; }

        public Cuadrado(double Lado):base(Lado,Lado)
        {
            
        }

        //public double calcularArea() //double bas, double altura
        //{
        //    double area = LadoA * LadoB;
        //    return area;
        //}
        //public double calcularPerimetro()
        //{
        //    double peri = (LadoA * 2) + (LadoB * 2);
        //    return peri;
        //}

    }
}
