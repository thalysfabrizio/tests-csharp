using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace pooStudying
{

    public class myAccount
    {
        public int accNumber { get; set; }

        public string accOwner { get; set; }

        public int accBalance { get; set; }

        public myAccount(string accowner, int accbalance)
        {
            accOwner = accowner;
            accBalance = accbalance;
        }

        public virtual void moneyInput(int mValue)
        {
            accBalance += mValue;
        }
        public virtual void moneyOutput(int mValue)
        {
            if (mValue > accBalance)
            {
                throw new Exception("Insuficient Balance!");
            }
            accBalance -= mValue;
        }
    }
}