namespace CAPolymorphism
{


    // Base class Account
    class Account
    {
        // Methods for deposit and withdraw
        public virtual void Deposit(double amount)
        {
            Console.WriteLine($"Deposit: ${amount}");
        }

        public virtual void Withdraw(double amount)
        {
            Console.WriteLine($"Withdraw: ${amount}");
        }
    }

    // Subclass SavingsAccount
    class SavingsAccount : Account
    {
        // Override withdraw method to implement specific withdrawal rules
        public override void Withdraw(double amount)
        {
            if (amount > 1000)
            {
                Console.WriteLine("Withdrawal amount exceeds limit for Savings Account.");
            }
            else
            {
                base.Withdraw(amount);
            }
        }
    }

    // Subclass CurrentAccount
    class CurrentAccount : Account
    {
        // Override withdraw method to implement specific withdrawal rules
        public override void Withdraw(double amount)
        {
            base.Withdraw(amount);
            Console.WriteLine("Withdrawal from Current Account.");
        }
    }

    // Subclass FixedDepositAccount
    class FixedDepositAccount : Account
    {
        // Override withdraw method to implement specific withdrawal rules
        public override void Withdraw(double amount)
        {
            Console.WriteLine("Penalty applied for early withdrawal from Fixed Deposit Account.");
            base.Withdraw(amount);
        }
    }

    class Program
    {
        static void Main(string[] args)
        {
            // Create objects of different account types
            Account savingsAccount = new SavingsAccount();
            Account currentAccount = new CurrentAccount();
            Account fixedDepositAccount = new FixedDepositAccount();

            // Demonstrate polymorphism by calling withdraw method for each account type
            Console.WriteLine("Savings Account:");
            savingsAccount.Withdraw(500);

            Console.WriteLine("\nCurrent Account:");
            currentAccount.Withdraw(1000);

            Console.WriteLine("\nFixed Deposit Account:");
            fixedDepositAccount.Withdraw(2000);
        }
    }
}
