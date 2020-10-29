using Microsoft.VisualStudio.TestTools.UnitTesting;
using MyMathLibrary;

namespace TestMyMath
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void TestPower_10_3_Returns_1000()
        {
            int value = 10;
            int exp = 3;
            int result = MyMath.Power(value, exp);
            Assert.AreEqual(1000, result);
        }

        [TestMethod]
        public void TestPower_100_0_5_Returns_10()
        {
            int value = 100;
            double exp = 0.5;
            double result = MyMath.Power(value, exp);
            Assert.AreEqual(10, result);
        }
    }
}
