﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TarefaListas
{
    public class Employee
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public double Salary { get; private set; }

        public Employee(int id, string name, double salary)
        {
            Id = id;   
            Name = name;
            Salary = salary;
        }

        public void AumentoSalary(double porcentagem)
        {
            double aumento = Salary * (porcentagem / 100.00);
            Salary += aumento;
        }

        public override string ToString()
        {
            return $"{Id}, {Name}, {Salary}";
        }
    }
}
