using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace generics2.Entities
{
    internal class CalculationService<T> where T : IComparable
    {
        public int Max(List<T> list)
        {
            if (list.Count == 0) throw new ArgumentException("The list cannot be empty");

            T max = list[0];
            for (int i = 1; i < list.Count; i++)
            {
                if (list[i] > max) max = list[i];
            }
            return max;
        }
    }
