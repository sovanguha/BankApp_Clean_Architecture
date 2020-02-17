using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Infrastructure
{
    public class Account : Domain.Account
    {
        public Account(Guid CustomerId)
        {
            this.Id = Guid.NewGuid();
            this.CustomerId = CustomerId;
        }

        public Account()
        {

        }

        public Guid CustomerId { get; protected set; }

        public void Load(IList<Credit> credits, IList<Debit> debits)
        {
            ((List<Credit>)Credits).AddRange(credits);
            ((List<Debit>)Debits).AddRange(debits);
        }
    }
}
