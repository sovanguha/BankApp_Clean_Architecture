using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Application
{
    public sealed class Transaction
    {
        public string Description { get; set; }
        public double Amount { get; set; }
        public DateTime TransactionDate { get; set; }

        public Transaction(
            string description,
            double amount,
            DateTime transactionDate)
        {
            this.Description = description;
            this.Amount = amount;
            this.TransactionDate = transactionDate;
        }
    }
}
