using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExercicioClasseAbstract.Entities
{
    internal class Company : TaxPayer
    {
        public int NumberOfEmployers { get; set; }
        public Company()
        {
        }
        public Company(string name, double anualIncome, int numberOfEmployers) : base(name, anualIncome)
        {
            NumberOfEmployers = numberOfEmployers;
        }
        public override double Tax()
        {
            if (NumberOfEmployers <= 10)
            {
                return AnualIncome * 0.16;
            }
            else
            {
                return AnualIncome * 0.14;
            }
        }
        public override string ToString()
        {
            return $"{Name}: $ {Tax().ToString("F2", CultureInfo.InvariantCulture)}";
        }
    }
}
