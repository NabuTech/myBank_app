using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace myBank.Classes
{
    public class EverydayAccount : Account
    {
        // Constructor
        public EverydayAccount(int accountId, int customerId, decimal balance)
            : base(accountId, customerId, balance, 0.0m, 0.0m, 0.0m) // Fill in appropriate values for interestRate, overdraftLimit, and feeForFailedWithdrawls
        {
            // No need to assign balance again here since it's already assigned in the base constructor
        }

        // Methods
        
        public override string AccountDetails()
        {
            return $"Everyday Account {AccountId}; Balance: {Balance:C}";
        }

        public override void Deposit(decimal amount)
        {
            Balance += amount;
        }

        public override string Withdraw(decimal amount)
        {
            if (Balance >= amount)
            {
                Balance -= amount;
                return $"Withdrawal Successful: {amount:C}; Current Balance: {Balance:C}";
            }
            else
            {
                return $"Withdrawal Failed: Insufficient Funds";
            }
        }

        public override string CalculateAndAddInterest()
        {
            // Everyday accounts typically don't earn interest
            return "Interest calculation not applicable for Everyday accounts.";
        }

        public override string DeductFailedTransactionFee()
        {
            // Everyday accounts typically don't have fees for failed transactions
            return "Failed transaction fee not applicable for Everyday accounts.";
        }
    }

}
