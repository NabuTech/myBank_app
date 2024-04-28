using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace myBank.Classes
{
    public class InvestmentAccount : Account
    {
        // Constructor
        public InvestmentAccount(int accountId, int customerId, decimal balance)
        : base(accountId, customerId, balance, 4.0m, 10.0m, 0.0m)
        {
            // No need to assign balance again here since it's already assigned in the base constructor
        }

        // Methods
        
        public override string AccountDetails()
        {
            return $"Investment Account {AccountId}; Balance: {Balance:C}; Interest Rate: {InterestRate:P}";
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
            decimal interestAmount = Balance * InterestRate;
            Balance += interestAmount;
            return $"Interest Added: {interestAmount:C}; Updated Balance: {Balance:C}";
        }

        public override string DeductFailedTransactionFee()
        {
            if (Balance >= FeeForFailedWithdrawls)
            {
                Balance -= FeeForFailedWithdrawls;
                return $"Failed Transaction Fee Deducted: {FeeForFailedWithdrawls:C}; Updated Balance: {Balance:C}";
            }
            else
            {
                return $"Failed Transaction Fee Cannot Be Deducted: Insufficient Funds";
            }
        }



    }

}
