using Microsoft.VisualStudio.TestTools.UnitTesting;
using Bakery.Models;

namespace Bakery.Tests
{
  [TestClass]
  public class PastryTests
  {
    [TestMethod]
    public void PastryConstructor_CreatesInstanceOfPastryClass_Pastry()
    {
      Pastry newPastry = new Pastry(1);
      Assert.AreEqual(typeof(Pastry), newPastry.GetType());
    }
    [TestMethod]
    public void GetHowManyPastrys_ReturnHowManyPastrys_Int()
    {
      Pastry newPastry = new Pastry(1);
      int result = newPastry.HowManyPastrys;
      Assert.AreEqual(1, result);
    }
    [TestMethod]
    public void PastryPrice_ReturnPastryPrice_Int()
    {
      Pastry newPastry = new Pastry(1);
      int result = newPastry.PastryPrice();
      Assert.AreEqual(2, result);
    }
  }
}