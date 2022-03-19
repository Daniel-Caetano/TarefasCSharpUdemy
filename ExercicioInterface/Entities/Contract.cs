using System;
using System.Text;
using System.Collections.Generic;


namespace ExercicioInterface.Entities
{
    internal class Contract
    {
        public int Number { get; set; }
        public DateTime Date { get; set; }
        public double TotalValue { get; set; }
        public List<Installment> Installments { get; set; }

        public Contract(int number, DateTime date, double totalValue)
        {
            Number = number;
            Date = date;
            TotalValue = totalValue;
            Installments = new List<Installment>();
        }
        public void Add(DateTime dueDate, double amount )
        {
            Installment installment = new Installment(dueDate, amount);
            Installments.Add(installment);
        }
        public override string ToString()
        {
            StringBuilder sb = new StringBuilder(); 
            foreach (Installment installment in Installments)
            {
                sb.AppendLine(installment.ToString());
            }
            return sb.ToString();
        }
    }
}
