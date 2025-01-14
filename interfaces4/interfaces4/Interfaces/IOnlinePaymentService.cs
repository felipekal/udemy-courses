using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace interfaces4.Interfaces
{
    public interface IOnlinePaymentService
    {
        public double PaymentFee(double amount);

        public double Interest(double amount, int months);
    }
}
