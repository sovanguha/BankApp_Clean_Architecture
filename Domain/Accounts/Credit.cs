using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Domain
{
    public abstract class Credit : ICredit
    {
        public Guid Id { get; protected set; }

        public double Amount { get; protected set; }

        public static string Description
        {
            get { return "Credit"; }
        }

        public DateTime TransactionDate { get; protected set; }

        public double Sum(double amount)
        {
            return this.Amount + amount;
        }
    }
}
