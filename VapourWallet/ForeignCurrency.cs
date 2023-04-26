using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace VapourWallet
{
    abstract class ForeignCurrency: Wallet, IWallet
    {
        protected decimal fee = 0;
        public decimal Fee
        {
            set => fee = value;
            get => fee;
        }
        public void ShowAllDetails()
        {
            Console.ForegroundColor = ConsoleColor.Blue;
            Console.WriteLine("!This account is not free!");
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
            Console.WriteLine("Remember that your withdraws and deposits will cost you small fee!\n");
        }

        public override void WithdrawMoney(decimal amount)
        {
            if (this.isActive)
            {
                if (amount < 0)
                {
                    Console.WriteLine("!You entered wrong amount!\n");
                }
                else if ((amount + amount*fee) > this.balance)
                {
                    Console.WriteLine("!You do not have that much money to withdraw!\n");
                }
                else
                {
                    this.balance -= amount + amount * fee;
                    Console.WriteLine($"You successfully withdraw {amount} {this.currency}\n");
                    Console.WriteLine($"This operation cost you {fee * amount} {this.currency}\n");
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
                    this.balance += amount - amount * fee;
                    Console.WriteLine($"You successfully deposit {amount} {this.currency}\n");
                    Console.WriteLine($"This operation cost you {fee * amount} {this.currency}\n");
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
