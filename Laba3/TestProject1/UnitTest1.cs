using Microsoft.VisualStudio.TestTools.UnitTesting;
using Laba3_1;

namespace TestProject1
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void TestMethod1()
        {
            Assert.AreEqual(6, StrangeOperation.ChangeNum(12));
        }

        [TestMethod]

        public void TestMethod2()
        {
            Assert.AreEqual(16, StrangeOperation.ChangeNum(13));
        }
    }
}