using interfaces4.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace interfaces4.Interfaces
{
    public class ContractService
    {
        public void ProcessContract(Contract contract, int months)
        {
            DateTime fodase;
            double x = 0;
            double value = contract.TotalValue / months;
            IOnlinePaymentService paypalService = new PaypalService();

            for (int i = 0; i <= months; i++) 
            {
                fodase = contract.Date.AddMonths(i);
                x = paypalService.Interest(value, i);
                x = paypalService.PaymentFee(x);

                contract.AddInstallments(new Installment(fodase, x));
            }


        }
    }
}
