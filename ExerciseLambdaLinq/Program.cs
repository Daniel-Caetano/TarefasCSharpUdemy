using ExerciseLambdaLinq.Entities;
using System;
using System.Collections.Generic;
using System.Globalization;
using System.IO;
using System.Linq;

namespace ExerciseLambdaLinq
{
    internal class Program
    {
        static void Main(string[] args)
        {
            List<Employee> employees = new List<Employee>();

            Console.Write("Enter full file path: ");
            string path = Console.ReadLine();

            using (StreamReader sr = File.OpenText(path))
            {
                while( sr.EndOfStream is false)
                {
                     string[] line = sr.ReadLine().Split(",");
                    employees.Add( new Employee(line[0].ToString(), line[1].ToString(), double.Parse(line[2],CultureInfo.InvariantCulture) ) );
                }
            }

            Console.Write("Enter salary: ");
            double salary = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

            Console.WriteLine("Email of people whose salary is more than 2000.00:");

            var emails = employees.Where(e => e.Salary>salary).OrderBy(e => e.Email).ToList();

            foreach (Employee email in emails)
            {
                Console.WriteLine(email.Email);
            }

            var sum = employees.Where(e => e.Name.StartsWith("M")).Sum(e => e.Salary);

            Console.WriteLine("Sum of salary of people whose name starts with 'M': "+ sum);
            

        }
    }
}
