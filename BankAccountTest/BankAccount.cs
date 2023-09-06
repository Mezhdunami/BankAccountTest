using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BankAccountTest
{
    public class BankAccount
    {
        public int AccountNumber { get;protected set; }
        public string ActHolderName { get; set; }   
        public double Balance { get;private set; }


        public BankAccount(string HolderNamee="")
        {
            ActHolderName = HolderNamee;
        }
    

        public void Deposit()
        {
            Console.WriteLine("How much would you like to Deposit?");
            double deposit = double.Parse(Console.ReadLine());
            Balance = Balance + deposit;
            Console.WriteLine("\nYou now have " +Balance+"$ in your account\n");
        }
        public void Withdraw()
        {
            Console.WriteLine("How much would you like to Withdraw?");
            double withdraw = double.Parse(Console.ReadLine());
            if (withdraw<Balance)
            {
                Console.WriteLine("You don't have that much");
            }
            else
            {
                Balance = Balance - withdraw;
                Console.WriteLine("You now have " + Balance + "$ in your account");
            }
           
        }
        public void DisplayInfo()
        {
            Console.WriteLine($"Your account nr is: #{AccountNumber}\nYour name is: {ActHolderName}\nYour balance is: {Balance}$");

        }
    }
}
