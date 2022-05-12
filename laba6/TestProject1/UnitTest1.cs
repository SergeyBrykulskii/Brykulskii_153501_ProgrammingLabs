using Microsoft.VisualStudio.TestTools.UnitTesting;
using laba6;

namespace TestProject1
{
    [TestClass]
    public class UnitTest1
    {
        readonly Clothes cl = new("Куртка", 13, 23);
        readonly Food fd = new("Хлеб", 5, 10, 2022, 12, 12);
        
        [TestMethod]
        public void TestMethod1()
        {
            
            Assert.IsTrue(cl.IsGood());
        }

        [TestMethod]
        public void TestMethod2()
        {

            Assert.IsTrue(fd.IsGood());
        }
        
        [TestMethod]
        public void TestMethod3()
        {
            Assert.AreEqual(fd.Weight, 10);
        } 
        
        [TestMethod]
        public void TestMethod4()
        {
            Assert.AreEqual(fd.Price, 5);
        }

        [TestMethod]
        public void TestMethod5()
        {
            Assert.AreEqual(fd.Name, "Хлеб");
        }

        [TestMethod]
        public void TestMethod6()
        {
            Assert.AreEqual(cl.Name, "Куртка");
        }

        [TestMethod]
        public void TestMethod7()
        {
            Assert.AreEqual(cl.Price, 13);
        }
    }
}