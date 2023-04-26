using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace VapourWallet
{
    sealed class WalletGBP: ForeignCurrency, IForeignCurrency
    {
        public WalletGBP(string name, string password)
        {
            this.name = name;
            this.password = password;
            this.currency = "GBP";
            this.fee = (decimal)0.005;
            ActivateWallet();
        }
        public void ShowFeeInformation()
        {
            Console.ForegroundColor = ConsoleColor.Cyan;
            Console.WriteLine($"Hello {this.name}! This is wallet for your pounds.");
            Console.WriteLine("Remember that we charge fee for every operation that you make.");
            Console.WriteLine($"fee: {fee * 100} %\n");
            Console.ForegroundColor = ConsoleColor.White;

        }
    }
}
