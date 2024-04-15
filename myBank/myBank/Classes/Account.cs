using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace myBank.Classes
{
    public abstract class Account
    {
        // Properties
        public int AccountId { get;}
        public int CustomerId { get;}
        public decimal Balance { get; set; }
        public decimal InterestRate { get; protected set; }
        public decimal OverdraftLimit { get; protected set; }
        public decimal FeeForFailedWithdrawls { get; protected set; }

        // Constructor
        protected Account(int accountId, int customerId, decimal balance, decimal interestRate, decimal overdraftLimit, decimal feeForFailedWithdrawls)
        {
            AccountId = accountId;
            CustomerId = customerId;
            Balance = balance;
            InterestRate = interestRate;
            OverdraftLimit = overdraftLimit;
            FeeForFailedWithdrawls = feeForFailedWithdrawls;
        }

        // Methods
        public abstract string AccountType();
        public abstract string AccountDetails();
        public abstract void Deposit(decimal amount);
        public abstract string Withdraw(decimal amount);
        public abstract string CalculateAndAddInterest();
        public abstract string DeductFailedTransactionFee();

    }
}
