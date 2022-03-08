using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Globalization;

namespace ExercicioClasseAbstract.Entities
{
    internal class Individual : TaxPayer
    {
        public double HealthExpenditures { get; set; }
        public Individual()
        {
        }
        public Individual(string name, double anualIncome, double healthExpenditures) : base(name, anualIncome)
        {
            HealthExpenditures = healthExpenditures;
        }
        public override double Tax()
        {
            if (AnualIncome < 20000.00 && AnualIncome > 0.00)
            {
                double tax = AnualIncome * 0.15;
                tax = tax - (HealthExpenditures * 0.50);
                return tax;
            }
            else
            {
                double tax = AnualIncome * 0.25;
                tax -= HealthExpenditures * 0.50;
                return tax;
            }
        }
        public override string ToString()
        {
            return $"{Name}: $ {Tax().ToString("F2",CultureInfo.InvariantCulture)}";
        }
    }
}
