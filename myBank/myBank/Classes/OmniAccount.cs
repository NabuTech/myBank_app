using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace myBank.Classes
{
    public class OmniAccount : Account
    {
        // Constructor
        public OmniAccount(int accountId, int customerId, decimal balance)
            : base(accountId, customerId, balance, 4.0m, 100.0m, 10.0m) 
        {
            // No need to assign balance again here since it's already assigned in the base constructor
        }

        // Methods
        
        public override string AccountDetails()
        {
            return $"Omni Account {AccountId}; Balance: {Balance:C}; Interest Rate: 4%; Overdraft Limit: $100; Fee for Failed Transactions: $10";
        }

        public override void Deposit(decimal amount)
        {
            Balance += amount;
        }

        public override string Withdraw(decimal amount)
        {
            if (Balance + OverdraftLimit >= amount)
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
            if (Balance > 1000)
            {
                decimal interestAmount = Balance * (InterestRate / 100);
                Balance += interestAmount;
                return $"Interest Added: {interestAmount:C}; Updated Balance: {Balance:C}";
            }
            else
            {
                return "Interest calculation not applicable for Omni accounts with balance less than $1000.";
            }
        }

        public override string DeductFailedTransactionFee()
        {
            if (Balance >= 10.0m) 
            {
                Balance -= 10.0m;
                return $"Failed Transaction Fee Deducted: $10; Updated Balance: {Balance:C}";
            }
            else
            {
                return $"Failed Transaction Fee Cannot Be Deducted: Insufficient Funds";
            }
        }
    }

}
