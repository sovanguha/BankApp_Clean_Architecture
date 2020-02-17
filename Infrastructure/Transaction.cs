using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Infrastructure
{
    public class Transaction
    {
        public Transaction(
            string description,
            double amount,
            DateTime transactionDate)
        {
            this.Description = description;
            this.Amount = amount;
            this.TransactionDate = transactionDate;
        }

        public string Description { get; }
        public double Amount { get;  }
        public DateTime TransactionDate { get; set; }
    }
}
