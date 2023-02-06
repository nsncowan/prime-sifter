using System;
using System.Collections.Generic;


namespace PrimeSifter.Models
{
  public class Checker
  {
    public int startingNum = 2;
    public int EndingNumber { get; set; }

    // public List<int> mainList = new List<int> {};

    
    public Checker(string input)
    {
      EndingNumber = int.Parse(input);
    }

    public List<int> AllNumbersList()
    {
      List<int> mainList = new List<int> {};

      for (int i = 2; i <= EndingNumber; i++)
      {
        mainList.Add(i);
      }

      // Console.WriteLine("Mainlist:" + mainList);
      return mainList;
    }

   public List<int> RemoveComposites(List<int> mainList)
   {
    Console.WriteLine("Main List:");
    Console.WriteLine(mainList[0]);

    List<int> primeList = new List<int> {};
    // primeList.AddRange(mainList);

    for (int i = 2; i <= EndingNumber; i++)
    {
      Console.WriteLine("i = " + i);
      // primeList.RemoveAll(x => x % i && x )

      foreach (int number in mainList)
      {
        if (number % i == 0 && number != i)
        {
          primeList.Add(number);
        }
      }
   }
  Console.WriteLine("Prime List:");
  Console.WriteLine(primeList);
   return primeList;

  }
}
}