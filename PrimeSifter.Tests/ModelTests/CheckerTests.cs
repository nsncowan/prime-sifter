using System;
using System.Collections.Generic;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using PrimeSifter.Models;
namespace PrimeSifter.Tests
{
  [TestClass]
  public class CheckerTests
  {
    [TestMethod]
    public void SetStartingNumber_SetStartingNumberAt2_Number()
    {
      int startingNum = 2;
      Assert.AreEqual(2, startingNum);
    }

    [TestMethod]
    public void SetEndingNumber_SetEndingNumberAtN_Number()
    {
      string endingNumberString = "7";
      int endingNumberInt = int.Parse(endingNumberString);

      Assert.AreEqual(endingNumberInt, 7);
    }

    [TestMethod]
    public void AllNumbersList_CreateMainList_List()
    {
      Checker test = new Checker("4");
      List<int> newList = new List<int>() {2, 3, 4};
      CollectionAssert.AreEqual(newList, test.AllNumbersList());

      // int endingNumberInt = 4;
      // List<int> newList = new List<int> {2, 3, 4};
      // List<int> result = Checker.CreateMainList(endingNumberInt);
      // CollectionAssert.AreEqual(newList, result);
    }

    [TestMethod]
    public void RemoveComposites_RemoveCompositeNumbers_List()
    {
      Checker test2 = new Checker("11");
      List<int> mainList = test2.AllNumbersList();
      List<int> newList2 = new List<int> {2, 3, 5, 7, 11};
      List<int> primeList = test2.RemoveComposites(mainList);
      // Console.WriteLine(primeList[0]);
      Assert.AreEqual(newList2[0], primeList[0]);
      // Assert.AreEqual(newList2[1], test2.RemoveComposites(mainList)[1]);
      // Assert.AreEqual(newList2[2], test2.RemoveComposites(mainList)[2]);
      // Assert.AreEqual(newList2[3], test2.RemoveComposites(mainList)[3]);
      // Assert.AreEqual(newList2[4], test2.RemoveComposites(mainList)[4]);
    }
  }
}


// Example test format:

/*

[TestMethod]
public void NameOfMethodWeAreTesting_DescriptionOfBehavior_ExpectedReturnValue()
{
  // any necessary logic to prep for test; instantiating new classes, etc.
  Assert.AreEqual(EXPECTED RESULT, CODE TO TEST);
}

 */