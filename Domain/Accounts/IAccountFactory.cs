using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Domain
{
    public interface IAccountFactory
    {
        IAccount NewAccount(Guid CustomerId);
        ICredit NewCredit(IAccount account, double amountToDeposit, DateTime transactionDate);
        IDebit NewDebit(IAccount account, double amountToWithdraw, DateTime transactionDate);
    } 
}
