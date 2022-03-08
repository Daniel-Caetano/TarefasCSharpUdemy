using System;
using System.Collections.Generic;
using System.Globalization;
using ExercicioClasseAbstract.Entities;

namespace ExercicioClasseAbstract
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Enter the number of tax payers: ");
            int numTaxPayers= int.Parse(Console.ReadLine());

            List<TaxPayer> taxPayers = new List<TaxPayer>();
            for(int i = 1; i <= numTaxPayers; i++)
            {
                Console.WriteLine($"Tax payer #{i} data:");
                Console.Write("Individual or company (i/c)?");
                char type= char.Parse(Console.ReadLine());
                Console.Write("Name: ");
                string name = Console.ReadLine();
                Console.Write("Anual income: ");
                double anualIncome = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
                if (type == 'i')
                {
                    Console.Write("Health expenditures: ");
                    double healthExpenditures = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
                    taxPayers.Add(new Individual(name,anualIncome,healthExpenditures));
                }
                else if(type =='c')
                {
                    Console.Write("Number of employees: ");
                    int numberOfEmployees = int.Parse(Console.ReadLine());
                    taxPayers.Add(new Company(name, anualIncome, numberOfEmployees));
                }
            }

            Console.WriteLine("\nTAXES PAID:");
            double totalTaxes=0;
            foreach(TaxPayer taxPayer in taxPayers)
            {
                Console.WriteLine(taxPayer);
                totalTaxes += taxPayer.Tax();
            }

            Console.WriteLine($"\nTOTAL TAXES: $ {totalTaxes.ToString("F2",CultureInfo.InvariantCulture)}");
        }
    }
}
