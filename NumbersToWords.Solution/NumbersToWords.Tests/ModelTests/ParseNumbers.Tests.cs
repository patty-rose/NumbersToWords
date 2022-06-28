using Microsoft.VisualStudio.TestTools.UnitTesting;
using NumbersToWords.Models;
using System.Collections.Generic;
using System;

namespace NumbersToWords.Tests
{
  [TestClass]
  public class ParseNumbersTests
  {
    [TestMethod]
    public void NumberLength_OneDigit_1()
    {
      ParseNumbers testParseNumbers = new ParseNumbers();
      Assert.AreEqual(1, testParseNumbers.NumberLength(4));
    }

    [TestMethod]
    public void NumberLength_TwoDigit_2()
    {
      ParseNumbers testParseNumbers = new ParseNumbers();
      Assert.AreEqual(2, testParseNumbers.NumberLength(44));
    }

    [TestMethod]
    public void NumberLength_ThreeDigit_3()
    {
      ParseNumbers testParseNumbers = new ParseNumbers();
      Assert.AreEqual(3, testParseNumbers.NumberLength(444));
    }

    [TestMethod]
    public void OneDigitDictionary_returnWord_two()
    {
      ParseNumbers testParseNumbers = new ParseNumbers();
      Assert.AreEqual("two", testParseNumbers.OneDigitDictionary(2));
    }

    // [TestMethod]
    // public void ParsedNumber
  }
}
// // sample test
//     [TestMethod]
//     public void ItemConstructor_CreatesInstanceOfItem_Item() 
//     {
//       Item newItem = new Item("test");
//       Assert.AreEqual(typeof(Item), newItem.GetType());
//     }