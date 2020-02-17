using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Domain.Customers
{
    public interface ICustomer
    {
        Guid Id { get; }
        IList<IAccount> Accounts { get; }
        void Register(Guid accountId);
    }
}
