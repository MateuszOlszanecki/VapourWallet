using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace VapourWallet
{
    sealed class WalletUSD: ForeignCurrency, IForeignCurrency
    {
        public WalletUSD(string name, string password)
        {
            this.name = name;
            this.password = password;
            this.currency = "USD";
            this.fee = (decimal)0.0096;
            ActivateWallet();
        }
        public void ShowFeeInformation()
        {
            Console.ForegroundColor = ConsoleColor.Green;
            Console.WriteLine($"Hi {this.name}! You have some dollars here.");
            Console.WriteLine("Remember about your fee.");
            Console.WriteLine($"fee: {fee * 100} %\n");
            Console.ForegroundColor = ConsoleColor.White;

        }
    }
}
