using Microsoft.VisualStudio.TestTools.UnitTesting;
using laba5;

namespace TestProject1
{
    [TestClass]
    public class UnitTest1
    {
        enum ContributionTypes
        {
            Short,
            Medium,
            Long
        }

        [TestMethod]
        public void TestMethod1()
        {
            Bank vtb = new();

            vtb.AddContribution((int)ContributionTypes.Short, 300, 0.04);
            vtb.AddContribution((int)ContributionTypes.Medium, 500, 0.12);
            vtb.AddContribution((int)ContributionTypes.Long, 700, 0.22);

            vtb.AddContributer("Sergey");
            vtb.AddContributer("Anna");

            vtb.LogIn("Sergey");
            vtb.MakeDeposit((int)ContributionTypes.Short, 1000, 0.05);
            vtb.LogOut();
            vtb.LogIn("Anna");
            vtb.MakeDeposit((int)ContributionTypes.Short, 1000, 0.45);

            Assert.AreEqual(500, vtb.GetTotalPayments());
        }
        [TestMethod]
        public void TestMethod2()
        {
            Bank vtb = new();

            vtb.AddContribution((int)ContributionTypes.Short, 300, 0.04);
            vtb.AddContribution((int)ContributionTypes.Medium, 500, 0.12);
            vtb.AddContribution((int)ContributionTypes.Long, 700, 0.22);

            vtb.AddContributer("Sergey");
            vtb.AddContributer("Anna");

            vtb.LogIn("Sergey");
            vtb.MakeDeposit((int)ContributionTypes.Short, 1000, 0.05);
            vtb.LogOut();
            vtb.LogIn("Anna");
            vtb.MakeDeposit((int)ContributionTypes.Short, 1000, 0.4);

            Assert.AreEqual(450, vtb.GetTotalPayments());
        }
    }
}