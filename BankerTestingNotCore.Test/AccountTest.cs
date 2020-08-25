using BankerAccount2;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xunit;

namespace BankerTestingNotCore.Test
{
    public class AccountTest
    {
        [Theory]
        [InlineData(1234,1234,true)]
        [InlineData(1234, 5555, false)]
        [InlineData(1234, 8000, false)]
        public void ValiDateAccount_ShouldReturnBool(int pin, int CardPin,bool expeted)
        {
            Account acc = new Account("Andi",1,500,pin);

            bool actuel = acc.ValidateUser(CardPin);
            Assert.Equal(expeted,actuel);

        }
    }
}
