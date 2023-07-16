using Microsoft.VisualStudio.TestTools.UnitTesting;
using Bakery.Models;


namespace Bakery.Tests
{
    [TestClass]
    public class NumberOfBreadTests
    {
      [TestMethod]
      public void BreadConstructor_CreatesInstanceOfBreadClass_Bread()
      {
        Bread NewBread = new Bread();
        Assert.AreEqual(typeof(Bread), NewBread.GetType());
      }
    }
}