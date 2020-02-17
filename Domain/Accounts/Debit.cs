using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Domain
{
    public abstract class Debit : IDebit
    {
        public Guid Id { get; protected set; }
        public double Amount { get; protected set; }
        public static string Description { get => "Debit"; }
        public DateTime TransactionDate { get; protected set; }

        public double Sum(double amount)
        {
            throw new NotImplementedException();
        }
    }
}
