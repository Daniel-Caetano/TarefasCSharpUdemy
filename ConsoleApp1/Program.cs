using System;
using System.Globalization;

namespace TarefaClasses
{
    public class Program
    {
        static void Main(string[] args)
        {
            Estudante[] quartos = new Estudante[10];
            Console.WriteLine("Quantos quartos serão alugados?");
            int qtdQuartos= int.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

            for(int i = 0; i < qtdQuartos; i++)
            {
                Console.WriteLine();
                Console.WriteLine($"Aluguel #{i+1}");
                Console.WriteLine("Qual o seu nome?");
                string nome= Console.ReadLine();
                Console.WriteLine("Qual o seu email?");
                string email = Console.ReadLine();
                Console.WriteLine("Qual quarto deseja ficar?");
                int numeroQuarto= int.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

                quartos[numeroQuarto] = new Estudante(nome, email); 
            }

            Console.WriteLine("\nQuartos ocupados:");
            for (int i = 0; i < quartos.Length; i++)
            {
                if (quartos[i] != null)
                {
                    Console.WriteLine(i +": "+ quartos[i]);
                }
            }


        }
    }
}
