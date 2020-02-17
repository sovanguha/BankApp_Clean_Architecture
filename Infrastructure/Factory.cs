using Domain;
using Domain.Customers;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Infrastructure
{
    public sealed class EntityFactory : ICustomerFactory, IAccountFactory
    {
        public IAccount NewAccount(Guid CustomerId) => new Account(CustomerId);

        public ICredit NewCredit(
            IAccount account,
            double amountToDeposit,
            DateTime transactionDate) => new Credit(account, amountToDeposit, transactionDate);

        public ICustomer NewCustomer(string Name) => new Customer(Name);

        public IDebit NewDebit(
            IAccount account, 
            double amountToWithdraw, 
            DateTime transactionDate) => new Debit(account, amountToWithdraw, transactionDate);
        
    }
}
