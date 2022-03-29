using Microsoft.VisualStudio.TestTools.UnitTesting;
using laba2_1;

namespace laba2_1_test
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void TestMethod0()
        {
            double a = 2, b = 3, c = 4;
            Assert.AreEqual(0, Program.QuadraticEquation(a, b, c));
        }
        
        [TestMethod]
        public void TestMethod1()
        {
            double a = 1, b = -4, c = 4;

            Assert.AreEqual(1, Program.QuadraticEquation(a, b, c));
        }

        [TestMethod]
        public void TestMethod2()
        {
            double a = 1, b = 3, c = -5;

            Assert.AreEqual(2, Program.QuadraticEquation(a, b, c));
        }
        
    }
}
