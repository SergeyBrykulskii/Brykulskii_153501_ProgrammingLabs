using Microsoft.VisualStudio.TestTools.UnitTesting;
using Laba4;

namespace TestProject1
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void TestMethod1()
        {
            Hotel hotel =  Hotel.GetHotel("hotel", 12, 12);
            Assert.AreEqual(hotel.Name, "hotel");
            Assert.AreEqual(hotel.NumberOfRooms, 12);
            Assert.AreEqual(1200, hotel.calculate());
            
        }
    }
}