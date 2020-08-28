using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using BankerAccount2.InterFaces;

namespace BankerAccount2
{
    /// <summary>
    /// This is the "Bank" and acts as the hub for all the oprationes such as withdraw,dipost,uservalidate.
    /// </summary>
   public class Bank : IBanker
    {
        public string Name { get; set; }
        public IDataBaseAccesse DataBaseAccesse { get; set; }
        public bool UserValidate(int userInput,int cardPin)
        {
            return (userInput == cardPin);
        }

        public bool WithDraw(double amountToWithDraw,double currentBalance)
        {
            return (amountToWithDraw <= currentBalance);
        }
        public bool DepositMoney(int CardID,double amount) {
            return true;
        }
    }
}
