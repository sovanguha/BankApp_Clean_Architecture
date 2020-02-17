using Domain;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Infrastructure
{
    public class Credit : Domain.Credit
    {
        public Credit()
        {

        }

        public Credit(
            IAccount account,
            double amountToDeposit,
            DateTime transactionDate)
        {
            this.Id = Guid.NewGuid();
            this.Amount = amountToDeposit;
            this.TransactionDate = transactionDate;
        }
    }
}
