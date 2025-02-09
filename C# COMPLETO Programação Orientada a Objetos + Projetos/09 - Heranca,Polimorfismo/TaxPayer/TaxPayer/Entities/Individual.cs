using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Authentication.ExtendedProtection;
using System.Text;
using System.Threading.Tasks;

namespace TaxPayer.Entities
{
    public class Individual : TaxPayer
    {
        public double HealthExpendure { get; set; }

        public Individual(double healthExpendure , string name , double anualIncome) : base (name, anualIncome)
        {
            HealthExpendure = healthExpendure;
        }

        public override double Tax()
        {

            double health = 0;
            if (HealthExpendure > 0)
            {
                health = (HealthExpendure * (50 / 100));
            }

            if(AnualIncome <= 20000)
            {
                return  (AnualIncome * (15 / 100)) - health;

            }
            
            return (AnualIncome * (25 / 100)) - health;


        }

    }
}
