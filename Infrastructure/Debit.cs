using Domain;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Infrastructure
{
    public class Debit : Domain.Debit
    {
        public Debit()
        {

        }

        public Debit(
            IAccount account,
            double amountToWithdraw,
            DateTime transactionDate)
        {
            this.Id = Guid.NewGuid();
            this.Amount = amountToWithdraw;
            this.TransactionDate = transactionDate;
        }
    }
}
