using Microsoft.VisualStudio.TestTools.UnitTesting;
using Laba3_3;
using System;

namespace TestProject3
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void TestMethod1()
        {
            int num;
            DateOnly CurrDay = new(2022, 3, 29);
            num = Math.Abs(DateOnly.Parse(DateTime.Today.ToShortDateString()).DayNumber - CurrDay.DayNumber);
            
            Assert.AreEqual(num, DateService.GetDaysSpan(29, 3, 2022));
        }
    }
}