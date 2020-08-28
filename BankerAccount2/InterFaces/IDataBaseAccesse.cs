using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BankerAccount2.InterFaces
{
   public interface IDataBaseAccesse
    {
        /// <summary>
        /// Gets the account with ehter the name or the id.
        /// </summary>
        /// <param name="userId"></param>
        /// <param name="userName"></param>
        /// <returns></returns>
        string[] GetUserAccount(int userId = -1, string userName = "");
    }
}
