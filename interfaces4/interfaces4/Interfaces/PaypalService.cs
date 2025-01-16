using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace interfaces4.Interfaces
{
    public class PaypalService : IOnlinePaymentService
    {
        public double Interest(double amount, int months)
        {
            
            return amount + (amount * 0.01) * months;
        }

        public double PaymentFee(double amount)
        {
            return amount + (amount * 0.02);
        }
    }
}
