using Domain;
using Domain.Customers;
using System;
using Xunit;


namespace UnitTests.EntitiesTest
{
    public class AccountTests
    {
        private readonly Infrastructure.EntityFactory entityFactory;
        private readonly ICustomer customer;
        private readonly IAccount account;


        public AccountTests()
        {
            entityFactory = new Infrastructure.EntityFactory();
            customer = entityFactory.NewCustomer("Sovan");
            account = entityFactory.NewAccount(customer.Id);
        }

        [Fact]
        public void Create_New_Account()
        {
            var actual = (Credit) account.Deposit(entityFactory, 100);

            Assert.Equal(100, actual.Amount);
        }

        [Fact]
        public void Deposit_1000_Check_Account_Balance()
        {
            var account = entityFactory.NewAccount(customer.Id);

            account.Deposit(entityFactory, 1000);

            Assert.Equal(1000, account.GetCurrentBalance());
        }

        [Fact]
        public void Withdraw_100_Check_Account_Balance()
        {
            var account = entityFactory.NewAccount(customer.Id);

            account.Withdraw(entityFactory, 100);

            Assert.Equal(1000, account.GetCurrentBalance());
        }

        [Fact]
        public void Get_All_Transaction()
        {
            var account = entityFactory.NewAccount(customer.Id);
            var accountEntity = new Application.Account();
            var list = accountEntity.GetAllTransactions(account);
        }


    }
}
