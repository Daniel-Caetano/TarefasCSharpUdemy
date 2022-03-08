using ExercicioException.Entities;
using ExercicioException.Entities.Exceptions;
using System;
using System.Globalization;

namespace ExercicioException
{
    internal class Program
    {
        static void Main(string[] args)
        {
            try
            {
                Account account = new Account();

                Console.WriteLine("Enter account data");
                Console.Write("Number: ");
                account.Number = int.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
                Console.Write("Holder: ");
                account.Holder = Console.ReadLine();
                Console.Write("Initial balance: ");
                account.Balance = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
                Console.Write("Withdraw limit: ");
                account.WithdrawLimit = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

                Console.Write("\nEnter amount for withdraw: ");
                double amount=double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
                account.Withdraw(amount);

                Console.WriteLine();
                Console.WriteLine(account);
            }
            catch (DomainException ex)
            {
                Console.WriteLine("Withdraw error: "+ex.Message);
            }
            catch(Exception ex)
            {
                Console.WriteLine("Unexpected error: " + ex.Message);
            }
        }
    }
}
