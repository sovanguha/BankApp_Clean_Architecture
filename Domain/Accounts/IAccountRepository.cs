using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Domain
{
    public interface IAccountRepository
    {
        Task Add(IAccount account, ICredit credit);
        Task Update(IAccount account, IDebit debit);
        Task Update(IAccount account, ICredit credit);
    }
}
