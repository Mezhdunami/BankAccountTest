using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BankAccountTest
{
    public class Bank:BankAccount
    {
        List<BankAccount> BankAccounts = new List<BankAccount>();

        
       
        public void CreateAccount()
        {
            Random rnd = new Random();
            int random = rnd.Next(1, 787874);
            string HolderName;
            Console.WriteLine("What is your name?");
            HolderName = Console.ReadLine();
            BankAccounts.Add(new BankAccount(HolderName));
            Console.WriteLine($"{HolderName} created an account");
            ActHolderName = HolderName;
            AccountNumber = random;

        }

        public void StartProgram()
        {
            while (true)
            {
                Console.WriteLine("\nEnter a command \n[Command list:]\nnew - To create an account\ndeposit - to add money\nwithdraw - to withdraw money\ninfo - to display Info\n(Type 'exit' to quit):");
                string input = Console.ReadLine();

                if (input.Equals("exit", StringComparison.OrdinalIgnoreCase))
                {
                    break; // Exit the program
                }

                ExecuteCommand(input);
            }
        }
        private void ExecuteCommand(string command)
        {
            switch (command.ToLower())
            {
                case "new":
                    CreateAccount();
                    break;
                case "deposit":
                    Deposit();
                    break;
                case "withdraw":
                    Withdraw();
                    break;
                case "info":
                    DisplayInfo();
                    break;
                default:
                    Console.WriteLine("Unknown command. Please try again.");
                    break;
            }
        }





    }
}
