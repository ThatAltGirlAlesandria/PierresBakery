using System;

namespace Bakery.Models
{
    public class Pastry
    {
      public int HowManyPastrys {get; }
      public Pastry(int count)
      {
        HowManyPastrys = count;
      }
      public int PastryPrice()
      {
        int pastryPrice = 2 * HowManyPastrys;
        return pastryPrice;
      }

      public int PastryCoupon(int pastryPrice)
      {
        int fourForThree = (int)Math.Floor((double)HowManyPastrys / 4);
        int getFourForThree = fourForThree * 2;
        int couponAmount = pastryPrice - getFourForThree;
        return couponAmount;
      }
    }
}