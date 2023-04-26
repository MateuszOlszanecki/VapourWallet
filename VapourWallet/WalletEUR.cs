using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace VapourWallet
{
    sealed class WalletEUR : ForeignCurrency, IForeignCurrency
    {
        public WalletEUR(string name, string password)
        {
            this.name = name;
            this.password = password;
            this.currency = "EUR";
            this.fee = (decimal)0.01;
            ActivateWallet();
        }
        public void ShowFeeInformation()
        {
            Console.ForegroundColor = ConsoleColor.Yellow;
            Console.WriteLine($"Hi {this.name}! Welcome to your wallet for euros!");
            Console.WriteLine("You are charged small fee for every operation that you make on this wallet.");
            Console.WriteLine($"fee: {fee * 100} %\n");
            Console.ForegroundColor = ConsoleColor.White;

        }
    }
}
