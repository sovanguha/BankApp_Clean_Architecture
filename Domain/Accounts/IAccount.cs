using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Domain
{
    public interface IAccount
    {
        int Id { get; }
        ICredit Deposit(IAccountFactory accountFactory, double amountToDeposit);
        IDebit Withdraw(IAccountFactory accountFactory, double amountToWithdraw);
        double GetCurrentBalance();
    }

}
