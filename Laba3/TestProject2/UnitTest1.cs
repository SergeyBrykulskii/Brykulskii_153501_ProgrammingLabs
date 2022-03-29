using Microsoft.VisualStudio.TestTools.UnitTesting;
using Laba3_2;

namespace TestProject2
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void TestMethod1()
        {
            Assert.AreEqual(5, Services.ChooseX(4, 3, 1));
        }

        [TestMethod]

        public void TestMethod2()
        {
            Assert.IsTrue(12.5 < Services.ChooseX(1, 3, 4) && Services.ChooseX(1, 3, 4) < 12.6);
        }

        [TestMethod]

        public void TestMethod3()
        {
            Assert.IsTrue(0.6 < Services.SolveEquation(4, 3, 1) && Services.SolveEquation(4, 3, 1) < 0.7);
        }

        [TestMethod]

        public void TestMethod4()
        {
            Assert.IsTrue(-1.5 < Services.SolveEquation(1, 3, 4) && Services.SolveEquation(1, 3, 4) < -1.4);
        }
    }
}