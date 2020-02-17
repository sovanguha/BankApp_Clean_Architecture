using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Domain
{
    public class AccountService
    {
        private readonly IAccountFactory accountFactory;
        private readonly IAccountRepository accountRepository;

        public AccountService(IAccountFactory accountFactory, IAccountRepository accountRepository)
        {
            this.accountFactory = accountFactory;
            this.accountRepository = accountRepository;
        }

        public async Task<IDebit> Withdraw(IAccount account, double amount)
        {
            if (account is null)
                throw new ArgumentNullException(nameof(account));

            var debit = account.Withdraw(accountFactory, amount);
            await this.accountRepository.Update(account, debit).ConfigureAwait(false);

            return debit;
        }

        public async Task<ICredit> Deposit(IAccount account, double amount)
        {
            if (account is null)
                throw new ArgumentNullException(nameof(account));

            var credit = account.Deposit(accountFactory, amount);
            await this.accountRepository.Update(account, credit).ConfigureAwait(false);
            return credit;
        }
    }
}
