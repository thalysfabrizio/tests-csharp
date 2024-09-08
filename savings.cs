using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;

namespace pooStudying
{

    public class mySavings : myAccount
    {

        public mySavings(string accowner, int accbalance) : base(accowner, accbalance)
        {
        }

        public override void moneyInput(int mValue)
        {
                base.moneyInput(mValue + 5);
        }
    }

}

