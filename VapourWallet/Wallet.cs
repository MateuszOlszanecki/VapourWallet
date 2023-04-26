using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace VapourWallet
{
    abstract class Wallet
    {
        protected string name = "";
        public string Name
        {
            set => name = value;
            get => name;
        }

        protected string password = "";
        public string Password
        {
            set => password = value;
            get => password;
        }

        protected string currency = "";
        public string Currency
        {
            set => currency = value;
            get => currency;
        }

        protected bool isActive = false;
        public bool IsActive
        {
            set => isActive = value;
            get => isActive;
        }

        protected decimal balance = 0;
        public decimal Balance
        {
            set => balance = value;
            get => balance;
        }
        public override string ToString()
        {
            return $"Balance: {balance} {currency}\n";
        }

        public void ActivateWallet()
        {
            this.isActive = true;
        }

        public abstract void WelcomeMessage();

        public abstract void WithdrawMoney(decimal amount);

        public abstract void DepositMoney(decimal amount);
    }
}
