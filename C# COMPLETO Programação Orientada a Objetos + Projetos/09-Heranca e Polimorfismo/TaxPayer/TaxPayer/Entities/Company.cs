using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TaxPayer.Entities
{
    public class Company : TaxPayer
    {

        public int Employees { get; set; }

        public Company()
        {
            
        }

        public Company(int employees, string name, double anualIncome) : base(name, anualIncome)
        {
            Employees = employees;
        }

        public override double Tax()
        {
            if (Employees >= 10)
            {
                return AnualIncome * (14 / 100);
            }
            return AnualIncome * (16 / 100);
        }
    }
}
