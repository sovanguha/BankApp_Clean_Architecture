using Domain;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Policy;
using System.Text;
using System.Threading.Tasks;

namespace Application
{
    public sealed class Account
    {
        public List<Transaction> GetAllTransactions(IAccount account)
        {
            var accountEntity = (Domain.Account) account;
            var transactionResults = new List<Transaction>();

            foreach (var credit in accountEntity.GetCreditTransactions())
            {
                var creditEntity = (Credit)credit;

                var transaction = new Transaction(
                    "Credit",
                    creditEntity.Amount,
                    creditEntity.TransactionDate);

                transactionResults.Add(transaction);
            }

            foreach (var debit in accountEntity.GetDebitTransactions())
            {
                var debitEntity = (Debit)debit;

                var transaction = new Transaction(
                    "Debit",
                    debitEntity.Amount,
                    debitEntity.TransactionDate);

                transactionResults.Add(transaction);
            }

            return transactionResults;
        }
    }
}
