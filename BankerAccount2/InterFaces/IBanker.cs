using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

Hvad er en banker?? Hvilket formål er der med dette interface? Er det hævemaskine interface?
namespace BankerAccount2.InterFaces
{
   public interface IBanker
    {
        /// <summary>
        /// Send a resuqst to withdraw a amount from the current account.
        /// </summary>
        /// <param name="amountToWithDraw"></param>
        /// <param name="currentBalance"></param>
        /// <returns></returns>
        bool WithDraw(double amountToWithDraw, double currentBalance);
        /// <summary>
        /// Validates the user with the pin.
        /// </summary>
        /// <param name="userInput"></param>
        /// <param name="cardPin"></param>
        /// <returns></returns>
        bool UserValidate(int userInput, int cardPin);
        /// <summary>
        /// Adds money to a giving account
        /// </summary>
        /// <param name="CardID"></param>
        /// <param name="amount"></param>
        /// <returns></returns>
        bool DepositMoney(int CardID, double amount);
    }
}
