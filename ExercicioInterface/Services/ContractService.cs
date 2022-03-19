using ExercicioInterface.Entities;
using System.Globalization;
using System;

namespace ExercicioInterface.Services
{
    internal class ContractService
    {
        public Contract Contract { get; set; }
        private IPaymentService _payment;
        private int _months;

        public ContractService(Contract contract, int months, IPaymentService payment)
        {
            Contract = contract;
            _months = months;
            _payment = payment;
        }
        public void calculateInterest()
        {
            double amount = Contract.TotalValue / (double)_months;
            for (int i = 0; i < _months; i++)
            {
                double duoAmount = _payment.paymentRate(amount, i + 1);
                Contract.Add(dateInterest(i),duoAmount);
            }
        }
        public DateTime dateInterest(int pos)
        {
            DateTime data = Contract.Date.AddMonths(pos+1);
            return data;
        }

    }
}