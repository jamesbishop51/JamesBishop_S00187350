using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using JamesBishop_S00187350;

namespace UnitTestProject1
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void TestMethod1()
        {
            //ARRANGE
            Phone s20 = new Phone();
            double NewPrice = 550;
            //ACT
            s20.IncreasePrice(10);
            //ASSERT

        }
    }
}
