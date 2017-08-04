using System;
using System.Collections.Generic;
using System.Linq;
using BagOLoot.Actions;

namespace BagOLoot
{
    public class Program
    {
        public static void Main(string[] args)
        {
            MainMenu menu = new MainMenu();
            ChildRegister book = new ChildRegister();
            ToyRegister bag = new ToyRegister();

            // Choice will hold the number entered by the user
            // after main menu ws displayed
            int choice;

            do
            {
                // Show the main menu
                choice = menu.Show();

                switch (choice)
                {
                    // Menu option 1: Adding Children
                    case 1:
                        CreateChild.DoAction(book);
                        break;

                    // Menu option 2: Adding Toy
                    case 2:
                        AddToy.DoAction(bag, book);
                        break;
                    // Menu option 3: Removing Toy
                    case 3:
                        RemoveToy.DoAction(bag, book);
                        break;
                    // Menu option 4: Review List of Toys
                    case 4:
                        ReviewList.DoAction(bag, book);
                        break;

                   
                }
            } while (choice <= 6);
        }
    }
}
