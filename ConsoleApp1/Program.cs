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
                Estudante estudante = new Estudante();
                Console.WriteLine("Qual o seu nome?");
                estudante.Nome= Console.ReadLine();
                Console.WriteLine("Qual o seu email?");
                estudante.Email = Console.ReadLine();
                Console.WriteLine("Qual quarto deseja ficar?");
                int numeroQuarto= int.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

                quartos[numeroQuarto] = estudante; 
            }

            Console.WriteLine("Quartos ocupados:");
            for (int i = 0; i < quartos.Length; i++)
            {
                if (!(quartos[i] == null))
                {
                    Console.WriteLine($"{i}: {quartos[i].Nome}, {quartos[i].Email}");
                }
            }


        }
    }
}
