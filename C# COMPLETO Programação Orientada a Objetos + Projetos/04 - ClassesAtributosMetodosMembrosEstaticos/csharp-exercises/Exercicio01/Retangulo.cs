using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercicio01
{
    internal class Retangulo
    {
        public double Lado { get; set; }
        public double Altura { get; set; }

        public double Area( double lad, double alt)
        {
            return lad * alt;
        }

        public double Perimetro ( double lad, double alt )
        {
            return 2 * (alt + lad);
        }

        public double Diagonal ( double lad, double alt )
        {
            return Math.Sqrt(Lado*Lado + Altura*Altura);
        }


    }
}
