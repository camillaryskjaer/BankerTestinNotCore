using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using BankerAccount2.InterFaces;

namespace BankerAccount2
{
    public class AccsseDataBase : IDataBaseAccesse
    {
        /// <summary>
        /// Fake test data, since this is not useing any moq¨s
        /// </summary>
        private List<string[]> notReelData;
        string[] userFakeDataAndi = { "Andi", "5761 0089 8745 3215", "5000", "1234" };
        string[] userFakeDataCasper = { "casper", "5761 0089 8745 3215", "4500", "5243" };
        string[] userFakeDataMiki = { "miki", "5761 0089 8745 3215", "8756","2556"};
        public AccsseDataBase()
        {
            notReelData = new List<string[]>();
            notReelData.Add(userFakeDataAndi);
            notReelData.Add(userFakeDataCasper);
            notReelData.Add(userFakeDataMiki);
        }
        /// <summary>
        /// Looks for the user with  userid or name.
        /// </summary>
        /// <param name="userId"></param>
        /// <param name="userName"></param>
        /// <returns></returns>
        public string[] GetUserAccount(int userId = -1, string userName = "")
        {
            string[] tempobject = null;
            for (int i = 0; i < notReelData.Count; i++)
            {
                if (notReelData[i][0].ToLower() == userName.ToLower() || userId == i)
                {
                    tempobject = notReelData[i];
                    return tempobject;
                }
            }
            return tempobject;
        }
    }
}
