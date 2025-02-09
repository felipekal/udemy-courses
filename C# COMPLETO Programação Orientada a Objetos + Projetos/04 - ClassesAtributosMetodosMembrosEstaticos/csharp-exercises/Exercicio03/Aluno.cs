using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercicio03
{
    internal class Aluno
    {
        public string Nome { get; set; }
        public double[] Notas { get; set; }

        public string  NotaFinal(double n1,double n2, double n3)
        {
           double media = n1 * 30 + n2 * 35 + n3 * 35 / 30 + 35 + 35;

            if (media > 60)
            {
                return "APROVADO";
            }
            else
            {
                return "REPROVADO";
            }
        }
    }
}
