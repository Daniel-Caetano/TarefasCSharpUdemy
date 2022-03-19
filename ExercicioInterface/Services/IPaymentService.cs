using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExercicioInterface.Services
{
    internal interface IPaymentService
    {
       double paymentRate(double amount,int month);

    }
}
