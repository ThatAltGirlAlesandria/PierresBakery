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
            Bread newBread = new Bread(5);
            Assert.AreEqual(typeof(Bread), newBread.GetType());
        }
        [TestMethod]
        public void GetHowManyBreads_ReturnsHowManyBreads_Int()
        {
          Bread newBread = new Bread(5);
          int result = newBread.HowManyBreads;
          Assert.AreEqual(5, result);
        }
        [TestMethod]
        public void BreadPrice_ReturnsBreadPrice_Int()
        {
          Bread newBread = new Bread(5);
          int result = newBread.BreadPrice();
          Assert.AreEqual(25, result);
        }
    }
}