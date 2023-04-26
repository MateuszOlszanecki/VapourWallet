using System;
using System.Collections.Generic;

namespace VapourWallet
{
    class Program
    {
        public void LogIn(List<Wallet> wallets)
        {
            int walletIndex = -1;
            bool loop = true;
            Console.Write("Enter your name: ");
            string name = Console.ReadLine();
            Console.Write("Enter your password: ");
            string password = Console.ReadLine();
            foreach (Wallet w in wallets){
                if(w.Name == name)
                    if(w.Password == password)
                        walletIndex = wallets.IndexOf(w);
            }
            Console.WriteLine();
            if(walletIndex == -1)
            {
                Console.WriteLine("!This account does not exist!\n");
            }
            else
            {
                int choice = -1;
                decimal amount = 0;
                wallets[walletIndex].WelcomeMessage();
                while (loop)
                {
                    Console.Clear();
                    Console.WriteLine($"   Name: {wallets[walletIndex].Name}\n");
                    Console.WriteLine("   VapourWallet");
                    Console.WriteLine("1. Show balance");
                    Console.WriteLine("2. Withdraw money");
                    Console.WriteLine("3. Deposit money");
                    Console.WriteLine("4. Exit");
                    Console.Write("Choice: ");
                    choice = Convert.ToInt32(Console.ReadLine());
                    Console.Clear();
                    if (choice == 1)
                    {
                        Console.WriteLine(wallets[walletIndex]);
                        Console.Write("Press any key to go to menu...");
                        Console.ReadLine();
                    }
                    else if (choice == 2)
                    {
                        Console.Write("amount: ");
                        amount = Convert.ToDecimal(Console.ReadLine());
                        wallets[walletIndex].WithdrawMoney(amount);
                        Console.Write("Press any key to go to menu...");
                        Console.ReadLine();
                    }
                    else if (choice == 3)
                    {
                        Console.Write("amount: ");
                        amount = Convert.ToDecimal(Console.ReadLine());
                        wallets[walletIndex].DepositMoney(amount);
                        Console.Write("Press any key to go to menu...");
                        Console.ReadLine();
                    }
                    else if (choice == 4)
                    {
                        loop = false;
                    }
                    else
                    {
                        Console.WriteLine("!Wrong number!");
                        Console.Write("Press any key to go to menu...");
                        Console.ReadLine();
                    }
                }
            }
        }


        static void Main(string[] args)
        {
            Program p = new Program();

            Console.ForegroundColor = ConsoleColor.DarkYellow;
            Console.WriteLine("          *** Test funkcjonalności logowania do portfeli ***\n");
            Console.ForegroundColor = ConsoleColor.White;

            List<Wallet> wallets = new List<Wallet>();
            wallets.Add(new WalletPLN("Mateusz", "123"));
            wallets.Add(new WalletGBP("Jan", "ciastko"));
            wallets.Add(new WalletEUR("Krysia", "23qwe32"));
            wallets.Add(new WalletUSD("Paweł", "epop123"));
            p.LogIn(wallets);

            WalletPLN wPLN = new WalletPLN("test1", "t1");
            WalletGBP wGBP = new WalletGBP("test2", "t2");
            WalletEUR wEUR = new WalletEUR("test3", "t3");
            WalletUSD wUSD = new WalletUSD("test4", "t4");

            Console.ForegroundColor = ConsoleColor.DarkYellow;
            Console.WriteLine("          *** Test funkcjonalności wyświetlania informacji o portfelach ***\n");
            Console.ForegroundColor = ConsoleColor.White;

            Console.ForegroundColor = ConsoleColor.DarkYellow;
            Console.WriteLine("          *** Dla WalletPLN ***\n");
            Console.ForegroundColor = ConsoleColor.White;
            wPLN.ShowAllDetails();

            Console.ForegroundColor = ConsoleColor.DarkYellow;
            Console.WriteLine("          *** Dla WalletGBP ***\n");
            Console.ForegroundColor = ConsoleColor.White;
            wGBP.ShowAllDetails();
            wGBP.ShowFeeInformation();

            Console.ForegroundColor = ConsoleColor.DarkYellow;
            Console.WriteLine("          *** Dla WalletEUR ***\n");
            Console.ForegroundColor = ConsoleColor.White;
            wEUR.ShowAllDetails();
            wEUR.ShowFeeInformation();

            Console.ForegroundColor = ConsoleColor.DarkYellow;
            Console.WriteLine("          *** Dla WalletUSD ***\n");
            Console.ForegroundColor = ConsoleColor.White;
            wUSD.ShowAllDetails();
            wUSD.ShowFeeInformation();
        }
    }
}