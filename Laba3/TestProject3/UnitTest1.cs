using Microsoft.VisualStudio.TestTools.UnitTesting;
using Laba3_3;

namespace TestProject3
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void TestMethod1()
        {
            Assert.AreEqual(1, DateService.GetDaysSpan(29, 3, 2022));
        }
    }
}