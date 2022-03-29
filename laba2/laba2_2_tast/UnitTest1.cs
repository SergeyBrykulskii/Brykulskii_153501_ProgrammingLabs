using Microsoft.VisualStudio.TestTools.UnitTesting;
using laba2_2;

namespace laba2_2_tast
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void TestMethodIn()
        {
            int x = -1, y = -1;

            Assert.AreEqual(1, Program.IsInZone(x, y));
        }
        
        [TestMethod]
        public void TestMethodOut()
        {
            int x = 2, y = 3;

            Assert.AreEqual(0, Program.IsInZone(x, y));
        }
        
        [TestMethod]
        public void TestMethodOnBorder()
        {
            int x = 0, y = 0;

            Assert.AreEqual(-1, Program.IsInZone(x, y));
        }
    }
}
