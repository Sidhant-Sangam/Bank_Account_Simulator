using System;

namespace BankAccountSimulator
{
    class BankAccount
    {
        private string accountHolder;
        private string accountNumber;
        private double balance;

        public BankAccount(string holder, string number)
        {
            accountHolder = holder;
            accountNumber = number;
            balance = 0.0;
        }

        public void Deposit(double amount)
        {
            if (amount <= 0)
            {
                Console.WriteLine("Amount must be positive.");
                return;
            }

            balance += amount;
            Console.WriteLine($"₹{amount} deposited successfully.");
        }

        public void Withdraw(double amount)
        {
            if (amount <= 0)
            {
                Console.WriteLine("Amount must be positive.");
                return;
            }

            if (amount > balance)
            {
                Console.WriteLine("Insufficient balance.");
                return;
            }

            balance -= amount;
            Console.WriteLine($"₹{amount} withdrawn successfully.");
        }

        public void ShowBalance()
        {
            Console.WriteLine($"\nAccount Holder: {accountHolder}");
            Console.WriteLine($"Account Number: {accountNumber}");
            Console.WriteLine($"Current Balance: ₹{balance}\n");
        }
    }

    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("=== Welcome to Simple Bank Simulator ===");

            Console.Write("Enter Account Holder Name: ");
            string name = Console.ReadLine();

            Console.Write("Enter Account Number: ");
            string accNo = Console.ReadLine();

            BankAccount account = new BankAccount(name, accNo);

            int choice;
            do
            {
                Console.WriteLine("\nMenu:");
                Console.WriteLine("1. Deposit");
                Console.WriteLine("2. Withdraw");
                Console.WriteLine("3. Show Balance");
                Console.WriteLine("4. Exit");
                Console.Write("Choose an option (1-4): ");
                choice = Convert.ToInt32(Console.ReadLine());

                switch (choice)
                {
                    case 1:
                        Console.Write("Enter amount to deposit: ₹");
                        double depositAmount = Convert.ToDouble(Console.ReadLine());
                        account.Deposit(depositAmount);
                        break;

                    case 2:
                        Console.Write("Enter amount to withdraw: ₹");
                        double withdrawAmount = Convert.ToDouble(Console.ReadLine());
                        account.Withdraw(withdrawAmount);
                        break;

                    case 3:
                        account.ShowBalance();
                        break;

                    case 4:
                        Console.WriteLine("Thank you for using Simple Bank Simulator.");
                        break;

                    default:
                        Console.WriteLine("Invalid choice. Try again.");
                        break;
                }

            } while (choice != 4);
        }
    }
}