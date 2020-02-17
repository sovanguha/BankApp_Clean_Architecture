
using System.Collections.ObjectModel;

namespace Infrastructure
{
    public sealed class InMemoryContext
    {
        public InMemoryContext()
        {
            var factory = new EntityFactory();
            this.Customers = new Collection<Customer>();
            this.Accounts = new Collection<Account>();
            this.Credits = new Collection<Credit>();
            this.Debits = new Collection<Debit>();

            var customer = new Customer("Sovan Guha");
            var account = new Account(customer.Id);

            var credit = account.Deposit(
                factory,
                800);
            var debit = account.Withdraw(
                factory,
                100);

            customer.Register(account.Id);

            this.Customers.Add(customer);
            this.Accounts.Add(account);
            this.Credits.Add((Credit)credit);
            this.Debits.Add((Debit)debit);
        }

        public Collection<Customer> Customers { get; set; }

        public Collection<Account> Accounts { get; set; }

        public Collection<Credit> Credits { get; set; }

        public Collection<Debit> Debits { get; set; }
    }
}
