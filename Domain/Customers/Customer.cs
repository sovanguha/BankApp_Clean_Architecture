using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Domain.Customers
{
    public abstract class Customer : ICustomer
    {
        public Guid Id { get; protected set; }
        public string Name { get; protected set; }
        public List<Guid> Accounts { get; protected set; }

        IList<IAccount> ICustomer.Accounts => throw new NotImplementedException();

        public Customer()
        {
            this.Accounts = new List<Guid>(); 
        }

        public void Register(Guid accountId)
        {
            this.Accounts.Add(accountId);
        }
    }

}
