using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace VapourWallet
{
    sealed class WalletPLN : Wallet, IWallet
    {
        public WalletPLN(string name, string password)
        {
            this.name = name;
            this.password = password;
            this.currency = "PLN";
            ActivateWallet();
        }

        public void ShowAllDetails()
        {
            Console.ForegroundColor = ConsoleColor.Red;
            Console.WriteLine("!This is 100% free wallet!");
            Console.WriteLine($"Name: {this.name}");
            Console.WriteLine($"Password: {this.password}");
            Console.WriteLine($"Currency: {this.currency}");
            Console.WriteLine($"IsActive: {this.isActive}");
            Console.WriteLine($"Balance: {this.balance}\n");
            Console.ForegroundColor = ConsoleColor.White;
        }

        public override void WelcomeMessage()
        {
            Console.WriteLine($"Hi {this.name}! This is your {this.currency} account.");
            Console.WriteLine("Remember that all your withdraws and deposits are 100% free!\n");
        }

        public override void WithdrawMoney(decimal amount)
        {
            if (this.isActive)
            {
                if (amount < 0)
                {
                    Console.WriteLine("!You entered wrong amount!\n");
                }
                else if (amount > this.balance)
                {
                    Console.WriteLine("!You do not have that much money to withdraw!\n");
                }
                else
                {
                    this.balance -= amount;
                    Console.WriteLine($"You successfully withdraw {amount} {this.currency}\n");
                    Console.WriteLine(this);
                }
            }
            else
            {
                Console.WriteLine("!You cannot withdraw money!\n");
            }
        }

        public override void DepositMoney(decimal amount)
        {
            if (this.isActive)
            {
                if (amount < 0)
                {
                    Console.WriteLine("!You entered wrong amount!\n");
                }
                else
                {
                    this.balance += amount;
                    Console.WriteLine($"You successfully deposit {amount} {this.currency}\n");
                    Console.WriteLine(this);
                }
            }
            else
            {
                Console.WriteLine("!You cannot deposit money!\n");
            }
        }
    }
}
