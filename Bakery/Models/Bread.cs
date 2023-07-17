using System;

namespace Bakery.Models
{
    public class Bread
    {
      public int HowManyBreads {get; }
      public Bread(int count)
      {
        HowManyBreads = count;
      }
      public int BreadPrice()
      {
        int breadPrice = 5 * HowManyBreads;
        return breadPrice;
      }
        public int BreadCoupon(int breadPrice)
        {
            int getThreeForTwo = (int)Math.Floor((double)HowManyBreads / 3);
            int threeForTwoCoupon = getThreeForTwo * 5;
            int couponAmount = breadPrice - threeForTwoCoupon;
            return couponAmount;

        }
    }
}