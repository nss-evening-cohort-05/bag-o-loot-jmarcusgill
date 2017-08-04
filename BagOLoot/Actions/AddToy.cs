using System;
using System.Collections.Generic;


namespace BagOLoot.Actions
{
  public class AddToy
  {
    public static void DoAction(ToyRegister bag, ChildRegister book)
    {
      // Console.Clear();
      // Console.WriteLine ("Choose child");

      // var children = book.GetChildren().ToArray();
      // foreach (Child child in children)
      // {
      //     Console.WriteLine($"{Array.IndexOf(children,child)+1}. {child.name}");
      // }

      // Console.Write ("> ");
      // string childName = Console.ReadLine();
      // Child kid = book.GetChild(children[int.Parse(childName)-1].name);

      var kid = KidsMenu.Show(book);
      
      Console.WriteLine ("Enter toy");
      Console.Write ("> ");
      string toyName = Console.ReadLine();
      bag.Add(toyName, kid);
    }
  }
}
