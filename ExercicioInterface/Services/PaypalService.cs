using System;
using System.Collections.Generic;
using System.Linq;

namespace ExercicioInterface.Services
{
    internal class PaypalService : IPaymentService 
    {

        public double _paymentRate = 0;
        public double paymentRate(double amount, int month)
        {
            _paymentRate = amount+ (amount * (0.01 * month));
            _paymentRate+= _paymentRate * 0.02;
            return _paymentRate;
        }
    }
}
