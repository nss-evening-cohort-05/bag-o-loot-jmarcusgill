using System;

namespace BagOLoot.Actions
{
    public class ReviewList
  {
    public static void DoAction(ToyRegister bag, ChildRegister book)
    {
      var kid = KidsMenu.Show(book);

      var toys = bag.GetToysForChild(kid).ToArray();

      foreach(var toy in toys)
      {
         Console.WriteLine($"{Array.IndexOf(toys, toy) +1}. {toy.name}");
      }

      Console.Write ("> ");
      Console.ReadKey();





    }
  }

}