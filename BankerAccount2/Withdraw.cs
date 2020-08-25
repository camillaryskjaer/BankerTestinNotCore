using System;
using System.Collections.Generic;
using System.Text;

namespace BankerAccount2
{
    public class WithDraw
    {
        public bool WithDrawMoney(double amount, double balance)
        {
            
            if (balance < amount)
            {
                return false;
            }
            else
            {
                return true;
            }

        }
    }
}
