using System;
using System.Collections.Generic;
using ToDoList.Models;

namespace ToDoList {
  class Program
  {
    static void Main()
    {
      Console.WriteLine("Would you like to add an item or view the list? ['add' or 'view']");
      string answer = Console.ReadLine();
      if (answer == "add")
      {
        Console.WriteLine("What would you like to add?"); 
        string description = Console.ReadLine();
        Item newItem =new Item (description);
        List<Item> newList = new List<Item> {newItem};

        Main();
      }
      else 
      {
      List<Item> result = Item.GetAll();
        foreach (Item thisItem in result)
        {
          Console.WriteLine(thisItem.Description); //Comment out the dispose method to see the output!
        }
      }
    }
  }
}
