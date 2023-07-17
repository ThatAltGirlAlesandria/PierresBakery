using Microsoft.VisualStudio.TestTools.UnitTesting;
using Bakery.Models;

namespace Bakery.Tests
{
    [TestClass]
    public class BreadTests
    {
        [TestMethod]
        public void BreadConstructor_CreatesInstanceOfBreadClass_Bread()
        {
            Bread newBread = new Bread(1);
            Assert.AreEqual(typeof(Bread), newBread.GetType());
        }
        [TestMethod]
        public void GetHowManyBreads_ReturnsHowManyBreads_Int()
        {
          int count = 1;
          Bread newBread = new Bread(count);
          int result = newBread.HowManyBreads;
          Assert.AreEqual(count, result);
        }
    }
}