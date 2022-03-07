using System;
using System.Collections.Generic;
using System.Globalization;

namespace TarefaListas
{
    internal class ListProgram
    {
        static void Main(string[] args)
        {

            Console.WriteLine("How many employees will be registered?");
            int numEmployees = int.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

            List<Employee> employees = new List<Employee>();

            for (int i = 1; i <= numEmployees; i++)
            {

                Console.WriteLine($"Emplyoee #{i}:");

                Console.Write("ID: ");
                int newId = int.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

                Console.Write("Name: ");
                string newName = Console.ReadLine();

                Console.Write("Salary: ");
                double newSalary = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

                employees.Add(new Employee(newId, newName, newSalary));
                Console.WriteLine();
            }

            Console.Write("Enter the employee id that will have salary increase : ");
            int id = int.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

            if (!employees.Exists(x => x.Id == id))
            {
                Console.WriteLine("This id does not exist!");
            }
            else
            {
                Console.Write("Enter the percentage: ");
                double percentage = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
                int posicao = employees.FindIndex(x => x.Id == id);
                employees[posicao].AumentoSalary(percentage);
            }

            Console.WriteLine();
            Console.WriteLine("Updated list of employees:");
            for (int i = 0; i < numEmployees; i++)
            {
                Console.WriteLine(employees[i]);
            }
        }
    }
}
