using Microsoft.VisualStudio.TestTools.UnitTesting;
using NumbersToWords.Models;
using System.Collections.Generic;
using System;

namespace NumbersToWords.Tests
{
  [TestClass]
  public class ParseNumbersTests
  {
  //   [TestMethod]
  //   public void NumberLength_OneDigit_1()
  //   {
  //     ParseNumbers testParseNumbers = new ParseNumbers();
  //     Assert.AreEqual(1, testParseNumbers.NumberLength(4));
  //   }

  //   [TestMethod]
  //   public void NumberLength_TwoDigit_2()
  //   {
  //     ParseNumbers testParseNumbers = new ParseNumbers();
  //     Assert.AreEqual(2, testParseNumbers.NumberLength(44));
  //   }

  //   [TestMethod]
  //   public void NumberLength_ThreeDigit_3()
  //   {
  //     ParseNumbers testParseNumbers = new ParseNumbers();
  //     Assert.AreEqual(3, testParseNumbers.NumberLength(444));
  //   }

  //   [TestMethod]
  //   public void OneDigitDictionary_returnWord_one()
  //   {
  //     ParseNumbers testParseNumbers = new ParseNumbers();
  //     Assert.AreEqual("one", testParseNumbers.OneDigitDictionary(1));
  //   }

    [TestMethod]
    public void ParsedNumber_ReturnOneDigitWord_one()
    {
      ParseNumbers testParseNumbers = new ParseNumbers();
      Assert.AreEqual("one", testParseNumbers.ParsedNumber(1));
    }

    [TestMethod]
    public void ParsedNumber_ReturnTwoDigitWordNotTens_twentytwo()
    {
      ParseNumbers testParseNumbers = new ParseNumbers();
      Assert.AreEqual("twenty two", testParseNumbers.ParsedNumber(22));
    }

    [TestMethod]
    public void ParsedNumber_TeensAsWords_twelve()
    {
      ParseNumbers testParseNumbers = new ParseNumbers();
      Assert.AreEqual("twelve", testParseNumbers.ParsedNumber(12));
    }

    [TestMethod]
    public void ParsedNumber_ReturnThreeDigitsAsWords_684()
    {
      ParseNumbers testParseNumbers = new ParseNumbers();
      Assert.AreEqual("six hundred eighty four", testParseNumbers.ParsedNumber(684));
    }
  }
}
// // sample test
//     [TestMethod]
//     public void ItemConstructor_CreatesInstanceOfItem_Item() 
//     {
//       Item newItem = new Item("test");
//       Assert.AreEqual(typeof(Item), newItem.GetType());
//     }