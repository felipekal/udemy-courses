﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace interfaces4.Entities
{
    public class Contract
    {
        public string Number { get; set; }
        public DateTime Date { get; set; }
        public double TotalValue { get; set; }

        public List<Installment> Installments { get; set; } = new List<Installment>();

        public Contract(string number, DateTime date, double totalValue)
        {
            Number = number;
            Date = date;
            TotalValue = totalValue;
        }

        public void AddInstallments(Installment installment)
        {
            Installments.Add(installment);
        } 

    }
}
