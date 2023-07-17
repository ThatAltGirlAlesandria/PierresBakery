using System;
using Bakery.Models;

namespace Bakery
{
  class Program
  {
    static void Main()
    {
      Console.WriteLine("-----------------------------------------------------------------");
      Console.WriteLine("Hello! Welcome to my Bakery");
      Console.WriteLine("My name is Pierre!");
      Console.WriteLine("I sell bread for five dollars a loaf,");
      Console.WriteLine("and I sell pastries for two dollars.");
      Console.WriteLine("-----------------------------------------------------------------");
      Console.WriteLine("I currently have a deal going on!");
      Console.WriteLine("For every two loafs of bread you buy, you get one free!");
      Console.WriteLine("For every three pastries you buy, you get one free!");
      Console.WriteLine("-----------------------------------------------------------------");

      try
      {
        Console.WriteLine("How many loafs of bread would you like?");
        int howManyLoafs = int.Parse(Console.ReadLine());
        Console.WriteLine("How many pastries would you like?");
        int howManyPastries = int.Parse(Console.ReadLine());

        Bread newBread = new Bread(howManyLoafs);
        Pastry newPastry = new Pastry(howManyPastries);

        int breadPrice = newBread.BreadPrice();
        int pastryPrice = newPastry.PastryPrice();
        int total = breadPrice + pastryPrice;

        Console.WriteLine("-----------------------------------------------------------------");
        Console.WriteLine($"Loafs of bread ordered: {howManyLoafs}");
        Console.WriteLine($"Amount of pastries ordered {howManyPastries}");

        Console.WriteLine($"That brings your total to: ${total}");
      }
      catch (Exception e)
      {
        Console.WriteLine($"Sorry, there was an order processing your order! {e.Message}");
      }
      Console.WriteLine("-----------------------------------------------------------------");
      Console.WriteLine("Would you like to place an order for tomorrow too?");
      Console.WriteLine("Please type yes or no.");
      string future = Console.ReadLine().ToLower();
      if (future == "yes")
      {
        Main();
      }
      else 
      {
        Console.WriteLine("-----------------------------------------------------------------");
        Console.WriteLine("Thank you for your business");
        Console.WriteLine("I will be excited to serve you again.");
        Console.WriteLine("-----------------------------------------------------------------");
      }
    }
  }
}