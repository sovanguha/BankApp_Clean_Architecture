using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Domain
{
    public class Account : IAccount
    {
        public Account()
        {
        }

        public IList<ICredit> Credits { get; protected set; }
        public IList<IDebit> Debits { get; protected set; }
        public Guid Id { get; protected set; }

        int IAccount.Id => throw new NotImplementedException();

        public ICredit Deposit(IAccountFactory accountFactory, double amountToDeposit)
        {
            if (accountFactory is null)
                throw new ArgumentNullException(nameof(accountFactory));

            var credit = accountFactory.NewCredit(this, amountToDeposit, DateTime.UtcNow);
            this.Credits.Add(credit);
            return credit;
        }

        public IDebit Withdraw(IAccountFactory accountFactory, double amountToWithdraw)
        {
            if (accountFactory is null)
                throw new ArgumentNullException(nameof(accountFactory));

            if (this.GetCurrentBalance() < amountToWithdraw)
                throw new Exception();

            var debit = accountFactory.NewDebit(this, amountToWithdraw, DateTime.UtcNow);
            this.Debits.Add(debit);
            return debit;
        }

        public IReadOnlyCollection<ICredit> GetCreditTransactions()
        {
            return new ReadOnlyCollection<ICredit>(Credits);
        }

        public IReadOnlyCollection<IDebit> GetDebitTransactions()
        {
            return new ReadOnlyCollection<IDebit>(Debits);
        }

        public double GetCurrentBalance()
        {
            double totalCredits = 0;

            foreach (var credit in Credits)
            {
                totalCredits = credit.Sum(totalCredits);
            }

            double totalDebits = 0;

            foreach (var debit in Debits)
            {
                totalDebits = debit.Sum(totalDebits);
            }
            
            var totalAmount = totalCredits - totalDebits;

            return totalAmount;
        }
    }
}
