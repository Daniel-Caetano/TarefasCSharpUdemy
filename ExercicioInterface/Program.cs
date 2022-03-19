using System;
using System.Globalization;
using ExercicioInterface.Entities;
using ExercicioInterface.Services;

namespace ExercicioInterface
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter contract data");
            Console.Write("Number: ");
            int number = int.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
            Console.Write("Date (dd/MM/yyyy): ");
            DateTime data = DateTime.ParseExact(Console.ReadLine(), "dd/MM/yyyy", CultureInfo.InvariantCulture);
            Console.Write("Contract value: ");
            double value = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
            Console.Write("Enter number of installments: ");
            int monsths = int.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

            var contract = new Contract(number, data, value);

            var contractService = new ContractService(contract, monsths, new PaypalService());
            contractService.calculateInterest();
            Console.WriteLine("Intallments: ");
            Console.WriteLine(contract);
        }
    }
}
