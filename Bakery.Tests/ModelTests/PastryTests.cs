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
      Pastry newPastry = new Pastry(5);
      Assert.AreEqual(typeof(Pastry), newPastry.GetType());
    }
    [TestMethod]
    public void GetHowManyPastrys_ReturnHowManyPastrys_Int()
    {
      Pastry newPastry = new Pastry(5);
      int result = newPastry.HowManyPastrys;
      Assert.AreEqual(5, result);
    }
    [TestMethod]
    public void PastryPrice_ReturnPastryPrice_Int()
    {
      Pastry newPastry = new Pastry(5);
      int result = newPastry.PastryPrice();
      Assert.AreEqual(10, result);
    }

    [TestMethod]
    public void PastryCoupon_AddCouponToPastry_Int()
    {
      Pastry newPastry = new Pastry(5);
      int pastryPrice = newPastry.PastryPrice();
      int couponAmount = newPastry.PastryCoupon(pastryPrice);
      Assert.AreEqual(8, couponAmount);
    }
  }
}