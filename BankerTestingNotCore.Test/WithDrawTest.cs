using System;
using System.Collections.Generic;
using System.Text;
using Xunit;
using BankerAccount2;

namespace UnitTestingBanker.Testing
{
    public class WithDrawTest
    {

        [Theory]
        [InlineData(1234, 5000, true)]
        [InlineData(2000, 5235, true)]
        [InlineData(10, 5000, true)]
        [InlineData(8552, 10, false)]
        public void WhithDrawMoney_ShouldReturnBool(int amount, double balcnce, bool expeted)
        {
            // Arrgae
            WithDraw withdraw = new WithDraw();
            // Act
            bool actuel = withdraw.WithDrawMoney(amount, balcnce);
            // Assert
            Assert.Equal(expeted, actuel);
        }       
    }
}
