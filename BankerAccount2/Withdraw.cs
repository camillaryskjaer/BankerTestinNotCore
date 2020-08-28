using System;
using System.Collections.Generic;
using System.Text;

namespace BankerAccount2
{
    [Obsolete("This class is not in used any more, plase use bank.WithDraw() insted")]
    public class WithDraw
    {
       
        public bool WithDrawMoney(double amount, double balance)
        {
            if (balance < amount)
                return false;
            else
                return true;
        }
    }
}
