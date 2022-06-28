using System.Collections.Generic;
using System;

namespace NumbersToWords.Models
{
  public class ParseNumbers
  {

    // public int number {get; set; }

    // //constructor
    // public ParseNumbers(int number)
    // {
    //   Number = number;
    // }

    public int NumberLength(int number)
      {
        string numberStr = number.ToString();
        int numLength = numberStr.Length;
        return numLength;
      }
  }
}