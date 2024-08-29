using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Actividad4.Models
{
    interface IFigura
    {
        double calcularArea();
        double calcularPerimetro();

        string ToString();

        int CompareTo(IFigura other);
    }
}
