using Microsoft.VisualStudio.TestTools.UnitTesting;
using laba7;


namespace TestProject1
{
    [TestClass]
    public class UnitTest1
    {
        static char[] charArray = new char[] { 'a', 'b', 'c', 'd', 'e' };
        static char[] charArray2 = new char[] { 'a', 'b', 'h', 'i', 'j' };
        static char[] charArray3 = new char[] { 'a', 'b', 'c', 'd', 'e' };

        SetOfChar obj1 = new(charArray), obj2 = new(charArray2), obj3 = new(charArray3), obj4 = new(charArray), obj5;

        string str1, str2, str3;
        
        [TestMethod]
        public void TestMethod1()
        {
            Assert.IsTrue(obj1 == obj4);
        }
        [TestMethod]
        public void TestMethod2()
        {
            Assert.IsTrue(obj1 != obj2);
        }
        [TestMethod]
        public void TestMethod3()
        {
            if (obj1)
            {
                Assert.IsTrue(true);
            }
        }
        [TestMethod]
        public void TestMethod4()
        {
            obj5 = obj1 + obj2;
            str3 = "abcdehij";
            str1 = obj5;
            Assert.AreEqual(str1, str3);
        }
        [TestMethod]
        public void TestMethod5()
        {
            obj5 = obj1 - obj2;
            str3 = "cde";
            str1 = obj5;
            Assert.AreEqual(str1, str3);
        }
        [TestMethod]
        public void TestMethod6()
        {
            obj5 = obj1 * obj2;
            str3 = "ab";
            str1 = obj5;
            Assert.AreEqual(str1, str3);
        }

        [TestMethod]
       
        public void TestMethod7()
        {
            Assert.AreEqual(obj1[0], 'a');
        }
        
        
    }
}